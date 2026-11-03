using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Baseline;

public static class ReadingLanes
{
	public sealed class Waiting : IEquatable<Waiting>
	{
		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Waiting);
			}
		}

		[field: CompilerGenerated]
		public string Key
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public long Megabytes
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public double Seconds
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public bool Alone
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public Waiting(string Key, long Megabytes, double Seconds, bool Alone = false)
		{
			this.Key = Key;
			this.Megabytes = Megabytes;
			this.Seconds = Seconds;
			this.Alone = Alone;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sl());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hZ());
			P_0.Append((object)Key);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SM());
			P_0.Append(((object)Megabytes).ToString());
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qk());
			P_0.Append(((object)Seconds).ToString());
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sm());
			P_0.Append(((object)Alone).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Waiting? left, Waiting? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Waiting? left, Waiting? right)
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
			return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Megabytes)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Seconds)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Alone);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Waiting);
		}

		[CompilerGenerated]
		public bool Equals(Waiting? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Key, other.Key) && EqualityComparer<long>.Default.Equals(Megabytes, other.Megabytes) && EqualityComparer<double>.Default.Equals(Seconds, other.Seconds))
				{
					return EqualityComparer<bool>.Default.Equals(Alone, other.Alone);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Waiting(Waiting P_0)
		{
			Key = P_0.Key;
			Megabytes = P_0.Megabytes;
			Seconds = P_0.Seconds;
			Alone = P_0.Alone;
		}

		[CompilerGenerated]
		public void Deconstruct(out string Key, out long Megabytes, out double Seconds, out bool Alone)
		{
			Key = this.Key;
			Megabytes = this.Megabytes;
			Seconds = this.Seconds;
			Alone = this.Alone;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<Waiting, long> _003C_003E9__1_2;

		public static Func<Waiting, double> _003C_003E9__4_0;

		public static Func<Waiting, string> _003C_003E9__4_1;

		internal long A(Waiting P_0)
		{
			return P_0.Megabytes;
		}

		internal double a(Waiting P_0)
		{
			return P_0.Seconds;
		}

		internal string B(Waiting P_0)
		{
			return P_0.Key;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public long budgetMegabytes;

		public long left;

		internal bool A(Waiting P_0)
		{
			return ReadingLanes.A(P_0, budgetMegabytes);
		}

		internal bool a(Waiting P_0)
		{
			return ReadingLanes.A(P_0, budgetMegabytes);
		}

		internal bool B(Waiting P_0)
		{
			return P_0.Megabytes <= left;
		}
	}

	public static Waiting? Next(System.Collections.Generic.IReadOnlyCollection<Waiting> waiting, System.Collections.Generic.IReadOnlyCollection<Waiting> running, long budgetMegabytes, int lanes)
	{
		if (waiting.Count == 0 || running.Count >= Math.Max(1, lanes))
		{
			return null;
		}
		if (Enumerable.Any<Waiting>((System.Collections.Generic.IEnumerable<Waiting>)running, (Func<Waiting, bool>)((Waiting P_0) => A(P_0, budgetMegabytes))))
		{
			return null;
		}
		Waiting waiting2 = A(Enumerable.Where<Waiting>((System.Collections.Generic.IEnumerable<Waiting>)waiting, (Func<Waiting, bool>)((Waiting P_0) => A(P_0, budgetMegabytes))));
		if ((object)waiting2 != null)
		{
			if (running.Count != 0)
			{
				return null;
			}
			return waiting2;
		}
		long left = budgetMegabytes - Enumerable.Sum<Waiting>((System.Collections.Generic.IEnumerable<Waiting>)running, (Func<Waiting, long>)((Waiting P_0) => P_0.Megabytes));
		return A(Enumerable.Where<Waiting>((System.Collections.Generic.IEnumerable<Waiting>)waiting, (Func<Waiting, bool>)((Waiting P_0) => P_0.Megabytes <= left)));
	}

	public static long? Estimate(long? lastPeakMegabytes)
	{
		if (lastPeakMegabytes.HasValue)
		{
			long valueOrDefault = lastPeakMegabytes.GetValueOrDefault();
			if (valueOrDefault > 0)
			{
				return Math.Max(256L, (long)Math.Ceiling((double)valueOrDefault * 1.25));
			}
		}
		return null;
	}

	private static bool A(Waiting P_0, long P_1)
	{
		if (!P_0.Alone)
		{
			return P_0.Megabytes > P_1;
		}
		return true;
	}

	private static Waiting? A(System.Collections.Generic.IEnumerable<Waiting> P_0)
	{
		return Enumerable.FirstOrDefault<Waiting>((System.Collections.Generic.IEnumerable<Waiting>)Enumerable.ThenBy<Waiting, string>(Enumerable.OrderByDescending<Waiting, double>(P_0, (Func<Waiting, double>)((Waiting P_0) => P_0.Seconds)), (Func<Waiting, string>)((Waiting P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.Ordinal));
	}
}
