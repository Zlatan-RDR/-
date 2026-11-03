using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Setup;

public static class TheDataSurvivesAReinstall
{
	[CompilerGenerated]
	private sealed class A
	{
		public string data;

		public string keptPath;

		internal void A()
		{
			Directory.Move(keptPath, data);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string fresh;

		public A CS_0024_003C_003E8__locals1;

		internal void A()
		{
			Directory.Move(CS_0024_003C_003E8__locals1.data, fresh);
		}
	}

	public const string DataFolder = "data";

	private const string KeptSuffix = "-data-keep";

	public static string? MoveAside(string installFolder)
	{
		H.A(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JG());
		string text = Path.Combine(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jg());
		if (!Directory.Exists(text))
		{
			return null;
		}
		string text2 = A(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JH());
		try
		{
			Directory.Move(text, text2);
			return text2;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			throw new TheDataIsInUseException(text, ex);
		}
	}

	public static void MoveBack(string keptPath, string installFolder)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MoveBack(keptPath, installFolder, 40, TimeSpan.FromMilliseconds(500.0));
	}

	public static void MoveBack(string keptPath, string installFolder, int attempts, TimeSpan pause)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		string keptPath2 = keptPath;
		H.A(keptPath2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jh());
		H.A(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JG());
		string data = Path.Combine(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jg());
		Directory.CreateDirectory(installFolder);
		if (Directory.Exists(data))
		{
			string fresh = A(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JI());
			A((Action)delegate
			{
				Directory.Move(data, fresh);
			}, attempts, pause);
		}
		A((Action)delegate
		{
			Directory.Move(keptPath2, data);
		}, attempts, pause);
	}

	private static void A(Action P_0, int P_1, TimeSpan P_2)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		while (true)
		{
			try
			{
				P_0.Invoke();
				break;
			}
			catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? true : false) && num < P_1)
			{
				Thread.Sleep(P_2);
			}
			num++;
		}
	}

	public static string WhereItWasLeft(string keptPath)
	{
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ji() + keptPath + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JJ();
	}

	public static int AroundTheInstaller(string installFolder, Func<int> runTheInstaller, Action<string>? whenItCouldNotComeBack = null)
	{
		H.A(runTheInstaller, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jj());
		string text = MoveAside(installFolder);
		try
		{
			return runTheInstaller.Invoke();
		}
		finally
		{
			if (text != null)
			{
				try
				{
					MoveBack(text, installFolder);
				}
				catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
				{
					whenItCouldNotComeBack?.Invoke(WhereItWasLeft(text));
				}
			}
		}
	}

	private static string A(string P_0, string P_1)
	{
		string text = P_0.TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		}) + P_1;
		string text2 = text;
		int num = 2;
		while (Directory.Exists(text2) || File.Exists(text2))
		{
			text2 = text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JK() + num;
			num++;
		}
		return text2;
	}
}
