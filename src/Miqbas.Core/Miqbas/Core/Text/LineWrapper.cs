using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Rendering.Arabic.Layout;

namespace Miqbas.Core.Text;

public static class LineWrapper
{
	[CompilerGenerated]
	private sealed class A
	{
		public FontMetrics metrics;

		public WrapConstraints constraints;

		public Func<System.Collections.Generic.IList<string>, List<string>> _003C_003E9__0;

		public Func<string, bool> _003C_003E9__1;

		internal List<string> A(System.Collections.Generic.IList<string> P_0)
		{
			return LineWrapper.A(P_0, metrics, constraints);
		}

		internal bool A(string P_0)
		{
			return metrics.Measure(P_0, constraints.FontSize) <= constraints.MaxWidth;
		}
	}

	public const char NoBreakSpace = '\u00a0';

	public static WrapResult Wrap(string text, FontMetrics metrics, WrapConstraints constraints)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = new List<string>();
		bool flag = false;
		string[] array = text.Split('\n', (StringSplitOptions)0);
		for (int i = 0; i < array.Length; i++)
		{
			ValueTuple<List<string>, bool> val2 = A(array[i], metrics, constraints);
			List<string> item = val2.Item1;
			bool item2 = val2.Item2;
			val.AddRange((System.Collections.Generic.IEnumerable<string>)item);
			flag = flag || item2;
		}
		WrapResult obj = new WrapResult
		{
			Lines = (System.Collections.Generic.IReadOnlyList<string>)val,
			HasUnbreakableOverflow = flag
		};
		int? maxLines = constraints.MaxLines;
		int exceedsMaxLines;
		if (maxLines.HasValue)
		{
			int valueOrDefault = maxLines.GetValueOrDefault();
			exceedsMaxLines = ((val.Count > valueOrDefault) ? 1 : 0);
		}
		else
		{
			exceedsMaxLines = 0;
		}
		obj.ExceedsMaxLines = (byte)exceedsMaxLines != 0;
		return obj;
	}

	private static ValueTuple<List<string>, bool> A(string P_0, FontMetrics P_1, WrapConstraints P_2)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		FontMetrics metrics = P_1;
		WrapConstraints constraints = P_2;
		List<string> val = new List<string>();
		bool flag = false;
		if (P_0.Length == 0)
		{
			val.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
			return new ValueTuple<List<string>, bool>(val, false);
		}
		Enumerator<string> enumerator = WordsThatStayTogether.Break((System.Collections.Generic.IList<string>)A(P_0), (System.Collections.Generic.IList<string> P_0) => A(P_0, metrics, constraints), (string P_0) => metrics.Measure(P_0, constraints.FontSize) <= constraints.MaxWidth).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				val.Add(current);
				if (metrics.Measure(current, constraints.FontSize) > constraints.MaxWidth)
				{
					flag = true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return new ValueTuple<List<string>, bool>(val, flag);
	}

	private static List<string> A(System.Collections.Generic.IList<string> P_0, FontMetrics P_1, WrapConstraints P_2)
	{
		List<string> val = new List<string>();
		string text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_0).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text2 = ((text.Length == 0) ? current : (text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X() + current));
				if (text.Length == 0 || P_1.Measure(text2, P_2.FontSize) <= P_2.MaxWidth)
				{
					text = text2;
					continue;
				}
				val.Add(text);
				text = current;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (text.Length > 0)
		{
			val.Add(text);
		}
		return val;
	}

	private static List<string> A(string P_0)
	{
		return Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)P_0.Split(' ', (StringSplitOptions)1));
	}

	public static string JoinLatinRuns(string text)
	{
		if (!a(text))
		{
			return text;
		}
		string[] array = text.Split(' ', (StringSplitOptions)0);
		List<string> val = new List<string>();
		for (int i = 0; i < array.Length; i++)
		{
			if (val.Count > 0 && B(array[i]) && B(array[i - 1]))
			{
				List<string> val2 = val;
				int num = val2.Count - 1;
				val2[num] = val2[num] + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hE() + array[i];
			}
			else
			{
				val.Add(array[i]);
			}
		}
		return string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X(), (System.Collections.Generic.IEnumerable<string>)val);
	}

	private static bool a(string P_0)
	{
		foreach (char c in P_0)
		{
			if (c >= '\u0600' && c <= 'ۿ')
			{
				return true;
			}
		}
		return false;
	}

	private static bool B(string P_0)
	{
		bool result = false;
		foreach (char c in P_0)
		{
			if (c >= '\u0600' && c <= 'ۿ')
			{
				return false;
			}
			if (char.IsAsciiLetter(c))
			{
				result = true;
			}
		}
		return result;
	}
}
