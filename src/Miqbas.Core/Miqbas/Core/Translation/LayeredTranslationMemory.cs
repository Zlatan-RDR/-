using System;
using System.Collections.Generic;

namespace Miqbas.Core.Translation;

public sealed class LayeredTranslationMemory : ITranslationMemory
{
	private readonly ITranslationMemory _own;

	private readonly IReadOnlyDictionary<string, string> _shared;

	private readonly HashSet<string> _answeredFromShared = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);

	private readonly object _gate = new object();

	public LayeredTranslationMemory(ITranslationMemory own, IReadOnlyDictionary<string, string> shared)
	{
		_own = own;
		_shared = shared;
	}

	public string? Lookup(string sourceText)
	{
		string text = _own.Lookup(sourceText);
		if (text != null)
		{
			return text;
		}
		string result = default(string);
		if (!_shared.TryGetValue(sourceText, ref result))
		{
			return null;
		}
		lock (_gate)
		{
			_answeredFromShared.Add(sourceText);
			return result;
		}
	}

	public void Remember(string sourceText, string translation)
	{
		_own.Remember(sourceText, translation);
	}

	public bool AnsweredFromShared(string sourceText)
	{
		lock (_gate)
		{
			return _answeredFromShared.Contains(sourceText);
		}
	}
}
