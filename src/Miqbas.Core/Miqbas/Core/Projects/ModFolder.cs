using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Projects;

[RequiredMember]
public sealed class ModFolder : IEquatable<ModFolder>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ModFolder);
		}
	}

	[field: CompilerGenerated]
	public long Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long ProjectId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ModFolderOrigin Origin
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public DateTimeOffset AddedAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool KeepsItsLanguage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ks());
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
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CL());
		P_0.Append(((object)Id).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kT());
		P_0.Append(((object)ProjectId).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kt());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kg());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kU());
		P_0.Append(((object)Origin).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ku());
		DateTimeOffset addedAt = AddedAt;
		P_0.Append(((object)(DateTimeOffset)(ref addedAt)).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kV());
		P_0.Append(((object)KeepsItsLanguage).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ModFolder? left, ModFolder? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ModFolder? left, ModFolder? right)
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
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		return ((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(ProjectId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<ModFolderOrigin>.Default.GetHashCode(Origin)) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(AddedAt)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(KeepsItsLanguage);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ModFolder);
	}

	[CompilerGenerated]
	public bool Equals(ModFolder? other)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<long>.Default.Equals(Id, other.Id) && EqualityComparer<long>.Default.Equals(ProjectId, other.ProjectId) && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<ModFolderOrigin>.Default.Equals(Origin, other.Origin) && EqualityComparer<DateTimeOffset>.Default.Equals(AddedAt, other.AddedAt))
			{
				return EqualityComparer<bool>.Default.Equals(KeepsItsLanguage, other.KeepsItsLanguage);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ModFolder(ModFolder P_0)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Id = P_0.Id;
		ProjectId = P_0.ProjectId;
		Path = P_0.Path;
		Name = P_0.Name;
		Origin = P_0.Origin;
		AddedAt = P_0.AddedAt;
		KeepsItsLanguage = P_0.KeepsItsLanguage;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ModFolder()
	{
	}
}
