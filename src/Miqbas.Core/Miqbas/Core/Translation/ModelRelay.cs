using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Translation;

public sealed class ModelRelay
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ModelInfo, int?> _003C_003E9__20_0;

		internal int? A(ModelInfo P_0)
		{
			return P_0.ContextWindowTokens;
		}
	}

	private readonly System.Collections.Generic.IReadOnlyList<ModelInfo> _models;

	private readonly System.Collections.Generic.IReadOnlyList<ITranslationProvider?> _providers;

	private int _index;

	public ValueTuple<ModelInfo, ITranslationProvider?> Now
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			int num = Volatile.Read(ref _index);
			return new ValueTuple<ModelInfo, ITranslationProvider>(_models[num], _providers[num]);
		}
	}

	public ModelInfo Current => _models[Volatile.Read(ref _index)];

	public ITranslationProvider? CurrentProvider => _providers[Volatile.Read(ref _index)];

	public int Count => ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)_models).Count;

	public bool HasNext => Volatile.Read(ref _index) + 1 < ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)_models).Count;

	public int Retired => Volatile.Read(ref _index);

	public System.Collections.Generic.IReadOnlyList<ModelInfo> All => _models;

	public int? SmallestContextWindow
	{
		get
		{
			int num = Enumerable.Min(Enumerable.DefaultIfEmpty<int>(Enumerable.OfType<int>((System.Collections.IEnumerable)Enumerable.Select<ModelInfo, int?>((System.Collections.Generic.IEnumerable<ModelInfo>)_models, (Func<ModelInfo, int?>)((ModelInfo P_0) => P_0.ContextWindowTokens))), 0));
			if (num <= 0)
			{
				return null;
			}
			return num;
		}
	}

	public ModelRelay(System.Collections.Generic.IReadOnlyList<ModelInfo> models, System.Collections.Generic.IReadOnlyList<ITranslationProvider?>? providers = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)models).Count == 0)
		{
			throw new ArgumentException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cs(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CT());
		}
		if (providers != null && ((System.Collections.Generic.IReadOnlyCollection<ITranslationProvider>)providers).Count != ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)models).Count)
		{
			throw new ArgumentException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ct(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CU());
		}
		_models = models;
		object obj = providers;
		if (obj == null)
		{
			List<ITranslationProvider> obj2 = new List<ITranslationProvider>();
			obj2.AddRange(Enumerable.Repeat<ITranslationProvider>((ITranslationProvider)null, ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)models).Count));
			obj = new k<ITranslationProvider>(obj2);
		}
		_providers = (System.Collections.Generic.IReadOnlyList<ITranslationProvider?>)obj;
	}

	public ModelRelay(ModelInfo model)
		: this(new L<ModelInfo>(model))
	{
	}

	public ModelInfo? Retire(ModelInfo spent)
	{
		lock (_models)
		{
			if ((object)_models[_index] != spent && !string.Equals(_models[_index].Id, spent.Id, (StringComparison)4))
			{
				return (_index < ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)_models).Count) ? _models[_index] : null;
			}
			if (_index + 1 >= ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)_models).Count)
			{
				return null;
			}
			Volatile.Write(ref _index, _index + 1);
			return _models[_index];
		}
	}
}
