using System;
using System.Reflection;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal static class WhyItFailed
{
	internal static string Line(Exception e)
	{
		if (e == null)
		{
			return "بلا سبب مذكور.";
		}
		Exception ex = Innermost(e);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ex.GetType().Name).Append(": ").Append(ex.Message);
		if (ex != e)
		{
			stringBuilder.Append(" (داخل ").Append(e.GetType().Name).Append(')');
		}
		string text = FirstFrame(ex);
		if (text != null && text.Length > 0)
		{
			stringBuilder.Append(" — ").Append(text);
		}
		return stringBuilder.ToString();
	}

	private static Exception Innermost(Exception e)
	{
		while (true)
		{
			if (e is TargetInvocationException)
			{
				Exception innerException = e.InnerException;
				if (innerException != null)
				{
					e = innerException;
					continue;
				}
			}
			if (e is TypeInitializationException)
			{
				Exception innerException2 = e.InnerException;
				if (innerException2 != null)
				{
					e = innerException2;
					continue;
				}
			}
			if (e is AggregateException ex && ex.InnerExceptions.Count == 1)
			{
				e = ex.InnerExceptions[0];
				continue;
			}
			if (!(e.GetType().Name == "HarmonyException"))
			{
				break;
			}
			Exception innerException3 = e.InnerException;
			if (innerException3 == null)
			{
				break;
			}
			e = innerException3;
		}
		return e;
	}

	private static string FirstFrame(Exception e)
	{
		string stackTrace = e.StackTrace;
		if (stackTrace == null || stackTrace.Length <= 0)
		{
			return "";
		}
		int num = stackTrace.IndexOf('\n');
		string text = ((num < 0) ? stackTrace : stackTrace.Substring(0, num)).Trim();
		if (text.Length <= 200)
		{
			return text;
		}
		return text.Substring(0, 200);
	}
}
