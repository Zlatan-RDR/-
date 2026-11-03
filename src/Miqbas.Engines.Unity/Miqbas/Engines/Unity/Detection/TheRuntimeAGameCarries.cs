using System;
using System.IO;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Detection;

public static class TheRuntimeAGameCarries
{
	public const string TheOldProfile = "v2.0.50727";

	public static string? Of(string gameRoot)
	{
		UnityGameInfo unityGameInfo = UnityGameDetector.Inspect(gameRoot);
		if ((object)unityGameInfo != null)
		{
			string dataDirectory = unityGameInfo.DataDirectory;
			if (dataDirectory != null && dataDirectory.Length > 0)
			{
				string text = Path.Combine(dataDirectory, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aa(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bX());
				if (!File.Exists(text))
				{
					return null;
				}
				return A(text);
			}
		}
		return null;
	}

	public static bool CanLoadOurPlugin(string gameRoot)
	{
		return !string.Equals(Of(gameRoot), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bx(), (StringComparison)4);
	}

	private static string? A(string P_0)
	{
		try
		{
			byte[] array = File.ReadAllBytes(P_0);
			int num = Math.Min(array.Length - 20, 4194304);
			for (int i = 0; i < num; i++)
			{
				if (array[i] == 66 && array[i + 1] == 83 && array[i + 2] == 74 && array[i + 3] == 66)
				{
					int num2 = BitConverter.ToInt32(array, i + 12);
					bool flag = ((num2 <= 0 || num2 > 256) ? true : false);
					if (flag || i + 16 + num2 > array.Length)
					{
						return null;
					}
					return Encoding.ASCII.GetString(array, i + 16, num2).TrimEnd('\0');
				}
			}
			return null;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException || ex is ArgumentException) ? 1 : 0) != 0)
		{
			return null;
		}
	}
}
