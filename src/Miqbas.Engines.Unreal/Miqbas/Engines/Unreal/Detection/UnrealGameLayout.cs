using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Detection;

[RequiredMember]
public sealed class UnrealGameLayout : IEquatable<UnrealGameLayout>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, long> _003C_003E9__30_0;

		public static Func<FileInfo, global::System.DateTime> _003C_003E9__34_0;

		public static Func<string, string> _003C_003E9__36_0;

		public static Func<string, bool> _003C_003E9__39_0;

		internal long A(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new FileInfo(P_0).Length;
		}

		internal global::System.DateTime A(FileInfo P_0)
		{
			return ((FileSystemInfo)P_0).LastWriteTimeUtc;
		}

		internal string a(string P_0)
		{
			return P_0;
		}

		internal bool B(string P_0)
		{
			return !Path.GetFileName(P_0).StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hL(), (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public UnrealGameLayout _003C_003E4__this;

		public string localAppData;

		internal string? A()
		{
			return _003C_003E4__this.A(localAppData);
		}
	}

	private static readonly string[] Platforms = new string[2]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.a(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gr()
	};

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(UnrealGameLayout);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string GameRoot
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string ProjectName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string ProjectDirectory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string PaksDirectory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> Packages
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Executable
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string RootMountPoint => _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bd();

	public string ContentPrefix => ProjectName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gG();

	public static UnrealGameLayout? Read(string gameRoot)
	{
		if (string.IsNullOrWhiteSpace(gameRoot) || !Directory.Exists(gameRoot))
		{
			return null;
		}
		string fullPath = Path.GetFullPath(gameRoot);
		global::System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateDirectories(fullPath).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text = Path.Combine(current, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.K());
				if (!Directory.Exists(text))
				{
					continue;
				}
				string fileName = Path.GetFileName(current);
				if (!string.Equals(fileName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.R(), (StringComparison)5))
				{
					List<string> val = Enumerable.ToList<string>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderByDescending<string, long>(Directory.EnumerateFiles(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CY(), (SearchOption)0), (Func<string, long>)((string P_0) => new FileInfo(P_0).Length)));
					bool flag = Enumerable.Any<string>(Directory.EnumerateFiles(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u(), (SearchOption)0));
					if (val.Count != 0 || flag)
					{
						return new UnrealGameLayout
						{
							GameRoot = fullPath,
							ProjectName = fileName,
							ProjectDirectory = current,
							PaksDirectory = text,
							Packages = (global::System.Collections.Generic.IReadOnlyList<string>)val,
							Executable = a(current)
						};
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	public string? EngineVersion(string? localAppData = null)
	{
		string localAppData2 = localAppData;
		if (Executable == null)
		{
			return null;
		}
		return ParseEngineVersion(FileVersionInfo.GetVersionInfo(Executable).ProductVersion, () => A(localAppData2));
	}

	public string? EngineVersionAtLeast(string? localAppData = null)
	{
		return EngineVersion(localAppData) ?? WhatTheFilesSayAboutTheEngine.EngineFloorIn(PaksDirectory);
	}

	public static string? ParseEngineVersion(string? productVersion, Func<string?> gameLog)
	{
		if (!string.IsNullOrWhiteSpace(productVersion))
		{
			Match val = Regex.Match(productVersion, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gg());
			if (((Group)val).Success)
			{
				return ((Capture)val.Groups[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gH()]).Value;
			}
			if (Regex.IsMatch(productVersion, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gh()))
			{
				return ((Capture)Regex.Match(productVersion, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gh())).Value;
			}
		}
		string text = gameLog.Invoke();
		if (text == null)
		{
			return null;
		}
		Match val2 = Regex.Match(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gI());
		if (!((Group)val2).Success)
		{
			return null;
		}
		return ((Capture)val2.Groups[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gH()]).Value;
	}

	private string? A(string? P_0)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		try
		{
			string text = Path.Combine(P_0 ?? Environment.GetFolderPath((SpecialFolder)28), ProjectName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gi(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gJ());
			if (!Directory.Exists(text))
			{
				return null;
			}
			FileInfo val = Enumerable.FirstOrDefault<FileInfo>((global::System.Collections.Generic.IEnumerable<FileInfo>)Enumerable.OrderByDescending<FileInfo, global::System.DateTime>(new DirectoryInfo(text).EnumerateFiles(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gj()), (Func<FileInfo, global::System.DateTime>)((FileInfo P_0) => ((FileSystemInfo)P_0).LastWriteTimeUtc)));
			if (val == null)
			{
				return null;
			}
			StreamReader val2 = new StreamReader(((FileSystemInfo)val).FullName, Encoding.UTF8, true, new FileStreamOptions
			{
				Mode = (FileMode)3,
				Access = (FileAccess)1,
				Share = (FileShare)7
			});
			try
			{
				StringBuilder val3 = new StringBuilder();
				for (int i = 0; i < 600; i++)
				{
					string text2 = ((TextReader)val2).ReadLine();
					if (text2 == null)
					{
						break;
					}
					val3.AppendLine(text2);
				}
				return ((object)val3).ToString();
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		catch
		{
			return null;
		}
	}

	public string GameName()
	{
		if (Executable != null)
		{
			string productName = FileVersionInfo.GetVersionInfo(Executable).ProductName;
			if (!string.IsNullOrWhiteSpace(productName))
			{
				return productName.Trim();
			}
		}
		return ProjectName;
	}

	public string Fingerprint()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		SHA256 val = SHA256.Create();
		try
		{
			global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Directory.EnumerateFiles(PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gK(), (SearchOption)0), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase)).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					FileInfo val2 = new FileInfo(current);
					Encoding uTF = Encoding.UTF8;
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(((FileSystemInfo)val2).Name);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gk());
					defaultInterpolatedStringHandler.AppendFormatted<long>(val2.Length);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gL());
					byte[] bytes = uTF.GetBytes(defaultInterpolatedStringHandler.ToStringAndClear());
					((HashAlgorithm)val).TransformBlock(bytes, 0, bytes.Length, (byte[])null, 0);
					byte[] array = A(current, 64);
					((HashAlgorithm)val).TransformBlock(array, 0, array.Length, (byte[])null, 0);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			((HashAlgorithm)val).TransformFinalBlock(global::System.Array.Empty<byte>(), 0, 0);
			return Convert.ToHexString(((HashAlgorithm)val).Hash);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static byte[] A(string P_0, int P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		FileStream val = new FileStream(P_0, (FileMode)3, (FileAccess)1, (FileShare)7);
		try
		{
			int num = (int)Math.Min((long)P_1, ((Stream)val).Length);
			byte[] array = new byte[num];
			((Stream)val).Position = ((Stream)val).Length - num;
			int num2;
			for (int i = 0; i < num; i += num2)
			{
				num2 = ((Stream)val).Read(array, i, num - i);
				if (num2 <= 0)
				{
					break;
				}
			}
			return array;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static string? a(string P_0)
	{
		string[] platforms = Platforms;
		foreach (string text in platforms)
		{
			string text2 = Path.Combine(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.A(), text);
			if (Directory.Exists(text2))
			{
				string text3 = Enumerable.FirstOrDefault<string>(Directory.EnumerateFiles(text2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gl() + text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gM(), (SearchOption)0)) ?? Enumerable.FirstOrDefault<string>(Directory.EnumerateFiles(text2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gm(), (SearchOption)0));
				if (text3 != null)
				{
					return text3;
				}
			}
		}
		string directoryName = Path.GetDirectoryName(P_0);
		if (directoryName == null || !Directory.Exists(directoryName))
		{
			return null;
		}
		platforms = Platforms;
		foreach (string text4 in platforms)
		{
			try
			{
				string text5 = Enumerable.FirstOrDefault<string>(Directory.EnumerateFiles(directoryName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gl() + text4 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gM(), (SearchOption)1), (Func<string, bool>)((string P_0) => !Path.GetFileName(P_0).StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hL(), (StringComparison)5)));
				if (text5 != null)
				{
					return text5;
				}
			}
			catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
			{
			}
		}
		return null;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gN());
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
		if (A(val))
		{
			val.Append(' ');
		}
		val.Append('}');
		return ((object)val).ToString();
	}

	[CompilerGenerated]
	private bool A(StringBuilder P_0)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gn());
		P_0.Append((object)GameRoot);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gO());
		P_0.Append((object)ProjectName);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.go());
		P_0.Append((object)ProjectDirectory);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gP());
		P_0.Append((object)PaksDirectory);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gp());
		P_0.Append((object)Packages);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gQ());
		P_0.Append((object)Executable);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gq());
		P_0.Append((object)RootMountPoint);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gR());
		P_0.Append((object)ContentPrefix);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(UnrealGameLayout? left, UnrealGameLayout? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(UnrealGameLayout? left, UnrealGameLayout? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameRoot)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProjectName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProjectDirectory)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PaksDirectory)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Packages)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Executable);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as UnrealGameLayout);
	}

	[CompilerGenerated]
	public bool Equals(UnrealGameLayout? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(GameRoot, other.GameRoot) && EqualityComparer<string>.Default.Equals(ProjectName, other.ProjectName) && EqualityComparer<string>.Default.Equals(ProjectDirectory, other.ProjectDirectory) && EqualityComparer<string>.Default.Equals(PaksDirectory, other.PaksDirectory) && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Packages, other.Packages))
			{
				return EqualityComparer<string>.Default.Equals(Executable, other.Executable);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private UnrealGameLayout(UnrealGameLayout P_0)
	{
		GameRoot = P_0.GameRoot;
		ProjectName = P_0.ProjectName;
		ProjectDirectory = P_0.ProjectDirectory;
		PaksDirectory = P_0.PaksDirectory;
		Packages = P_0.Packages;
		Executable = P_0.Executable;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public UnrealGameLayout()
	{
	}
}
