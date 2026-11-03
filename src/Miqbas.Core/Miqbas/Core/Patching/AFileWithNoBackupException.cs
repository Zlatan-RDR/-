using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

public sealed class AFileWithNoBackupException : InvalidOperationException
{
	[field: CompilerGenerated]
	public string RelativePath
	{
		[CompilerGenerated]
		get;
	}

	public AFileWithNoBackupException(string relativePath)
	{
		RelativePath = relativePath;
		((InvalidOperationException)this)._002Ector(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ly() + relativePath + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LZ());
	}
}
