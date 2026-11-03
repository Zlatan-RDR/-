using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ReadWhileWritten
{
	internal static string[] Lines(string path)
	{
		List<string> list = new List<string>();
		using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
		{
			using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
			string item;
			while ((item = streamReader.ReadLine()) != null)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}
}
