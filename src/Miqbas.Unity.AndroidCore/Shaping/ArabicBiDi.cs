using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Miqbas.Unity.AndroidCore.Shaping;

/// <summary>
/// Tag-safe Bidirectional visual orderer for Arabic text.
/// Preserves Unity rich text tags (e.g. <color=red>, <b>, <i>, <size=12>) and parameters ({0}, %s, \n).
/// </summary>
public static class ArabicBiDi
{
    private static readonly Regex TagPattern = new Regex(@"(<[^>]+>|\{[0-9]+\}|%[0-9]*[a-zA-Z]|\\[nrt]|[\r\n]+)", RegexOptions.Compiled);

    public static string ApplyVisualOrder(string text)
    {
        if (string.IsNullOrEmpty(text) || !ArabicShaper.ContainsArabic(text))
            return text;

        // Split text into tokens: tags and text chunks
        var tokens = new List<(string Content, bool IsTag)>();
        int lastIndex = 0;

        foreach (Match match in TagPattern.Matches(text))
        {
            if (match.Index > lastIndex)
            {
                tokens.Add((text.Substring(lastIndex, match.Index - lastIndex), false));
            }
            tokens.Add((match.Value, true));
            lastIndex = match.Index + match.Length;
        }

        if (lastIndex < text.Length)
        {
            tokens.Add((text.Substring(lastIndex), false));
        }

        // Process non-tag tokens with RTL word reversal
        var sb = new StringBuilder(text.Length);

        // Reverse overall token sequence so Arabic reads from right to left
        tokens.Reverse();

        foreach (var token in tokens)
        {
            if (token.IsTag)
            {
                // Tags stay intact (not reversed internally)
                sb.Append(token.Content);
            }
            else
            {
                // Reverse characters within the text token
                char[] chars = token.Content.ToCharArray();
                Array.Reverse(chars);
                sb.Append(new string(chars));
            }
        }

        return sb.ToString();
    }
}
