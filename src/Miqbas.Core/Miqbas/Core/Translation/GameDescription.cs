using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Translation;

public sealed class GameDescription : IEquatable<GameDescription>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, ValueTuple<string, Match>> _003C_003E9__19_0;

		public static Func<ValueTuple<string, Match>, bool> _003C_003E9__19_1;

		public static Func<ValueTuple<string, Match>, int> _003C_003E9__19_2;

		public static Func<ValueTuple<string, Match>, int> _003C_003E9__19_3;

		public static Func<ValueTuple<string, Match>, string> _003C_003E9__19_4;

		internal ValueTuple<string, Match> A(string P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, Match>(P_0, AFlash.Match(P_0));
		}

		internal bool A(ValueTuple<string, Match> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return ((Group)x.Item2).Success;
		}

		internal int a(ValueTuple<string, Match> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return int.Parse(((Capture)x.Item2.Groups[1]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}

		internal int B(ValueTuple<string, Match> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return int.Parse(((Capture)x.Item2.Groups[2]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}

		internal string b(ValueTuple<string, Match> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (!x.Item1.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rg(), (StringComparison)4))
			{
				return x.Item1;
			}
			string item = x.Item1;
			int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rg().Length;
			return item.Substring(length, item.Length - length);
		}
	}

	public const int LongestKept = 1500;

	public const string DoesNotKnowIt = "لا أعرفها";

	public const string SystemPrompt = "أنت خبير ألعاب فيديو. تكتب لمترجم\u064d سيعر\u0651ب نصوص لعبة وصف\u064bا قصير\u064bا يعينه على فهم سياقها.";

	private static readonly Regex AFlash = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BN(), (RegexOptions)512, TimeSpan.FromSeconds(1.0));

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GameDescription);
		}
	}

	[field: CompilerGenerated]
	public string Text
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string ByModel
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool Known => Text.Length > 0;

	public GameDescription(string Text, string ByModel)
	{
		this.Text = Text;
		this.ByModel = ByModel;
		base._002Ector();
	}

	public static string AskAbout(string gameName)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(174, 2);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BH());
		defaultInterpolatedStringHandler.AppendFormatted(gameName);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bh());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BI());
		defaultInterpolatedStringHandler.AppendFormatted(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bi());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BJ());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static GameDescription FromAnswer(string answer, string model)
	{
		ArgumentNullException.ThrowIfNull((object)answer, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bj());
		string text = answer.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BK(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), (StringComparison)4).Trim();
		if (text.Length < 40 && text.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bi(), (StringComparison)4))
		{
			text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		}
		return new GameDescription((text.Length > 1500) ? text.Substring(0, 1500).TrimEnd() : text, model);
	}

	public static System.Collections.Generic.IReadOnlyList<string> StrongestFlashes(System.Collections.Generic.IEnumerable<string> ids)
	{
		List<string> obj = new List<string>();
		obj.AddRange(Enumerable.Select<ValueTuple<string, Match>, string>((System.Collections.Generic.IEnumerable<ValueTuple<string, Match>>)Enumerable.ThenByDescending<ValueTuple<string, Match>, int>(Enumerable.OrderByDescending<ValueTuple<string, Match>, int>(Enumerable.Where<ValueTuple<string, Match>>(Enumerable.Select<string, ValueTuple<string, Match>>(ids, (Func<string, ValueTuple<string, Match>>)((string P_0) => new ValueTuple<string, Match>(P_0, AFlash.Match(P_0)))), (Func<ValueTuple<string, Match>, bool>)((ValueTuple<string, Match> x) => ((Group)x.Item2).Success)), (Func<ValueTuple<string, Match>, int>)((ValueTuple<string, Match> x) => int.Parse(((Capture)x.Item2.Groups[1]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture))), (Func<ValueTuple<string, Match>, int>)((ValueTuple<string, Match> x) => int.Parse(((Capture)x.Item2.Groups[2]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture))), (Func<ValueTuple<string, Match>, string>)delegate(ValueTuple<string, Match> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (!x.Item1.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rg(), (StringComparison)4))
			{
				return x.Item1;
			}
			string item = x.Item1;
			int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rg().Length;
			return item.Substring(length, item.Length - length);
		}));
		return new k<string>(obj);
	}

	public static string? WithTheEngine(string? engineLine, GameDescription? description)
	{
		if ((object)description == null || !description.Known)
		{
			return engineLine;
		}
		if (engineLine == null || engineLine.Length <= 0)
		{
			return description.Text;
		}
		return engineLine + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk() + description.Text;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BL());
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bl());
		P_0.Append((object)Text);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BM());
		P_0.Append((object)ByModel);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bm());
		P_0.Append(((object)Known).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameDescription? left, GameDescription? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameDescription? left, GameDescription? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ByModel);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GameDescription);
	}

	[CompilerGenerated]
	public bool Equals(GameDescription? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Text, other.Text))
			{
				return EqualityComparer<string>.Default.Equals(ByModel, other.ByModel);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private GameDescription(GameDescription P_0)
	{
		Text = P_0.Text;
		ByModel = P_0.ByModel;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Text, out string ByModel)
	{
		Text = this.Text;
		ByModel = this.ByModel;
	}
}
