using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class ReportLog
{
	private static readonly UTF8Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	private readonly HashSet<string> _reported = new HashSet<string>(StringComparer.Ordinal);

	private readonly object _gate = new object();

	private readonly string _path;

	internal int Count
	{
		get
		{
			lock (_gate)
			{
				return _reported.Count;
			}
		}
	}

	internal ReportLog(string path)
	{
		_path = path;
	}

	internal void Record(string sourceText)
	{
		if (string.IsNullOrEmpty(sourceText))
		{
			return;
		}
		lock (_gate)
		{
			if (!_reported.Add(sourceText))
			{
				return;
			}
			try
			{
				File.AppendAllText(_path, TextEscaping.Escape(sourceText) + Environment.NewLine, Utf8NoBom);
			}
			catch (IOException)
			{
			}
		}
	}
}
