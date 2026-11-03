using System;
using System.Collections;
using System.Collections.Generic;

namespace Miqbas.Core.Translation;

public sealed class InMemoryTranslationMemory : ITranslationMemory
{
	private readonly Dictionary<string, string> _entries = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);

	public int Count => _entries.Count;

	public InMemoryTranslationMemory()
	{
	}

	public InMemoryTranslationMemory(System.Collections.Generic.IEnumerable<KeyValuePair<string, string>> seed)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = seed.GetEnumerator();
		try
		{
			string text = default(string);
			string text2 = default(string);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.Current.Deconstruct(ref text, ref text2);
				string text3 = text;
				string text4 = text2;
				_entries[text3] = text4;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public string? Lookup(string sourceText)
	{
		return CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)_entries, sourceText);
	}

	public void Remember(string sourceText, string translation)
	{
		_entries[sourceText] = translation;
	}
}
