// Copyright (c) 2016-2020 Alexander Ong
// See LICENSE in project root for license information.

using UnityEngine;
using System.IO;

/// <summary>
/// Loads and processes any persistent data, like save data, as well as just convenient defines and properties that exists outside of the "Chart Editor" concept.
/// </summary>
public static class Globals {
    public static readonly string LINE_ENDING = "\r\n";
    public const string TABSPACE = "  ";
    static string workingDirectory = string.Empty;

    public static readonly string[] validAudioExtensions = { ".ogg", ".wav", ".mp3", ".opus" };

#if UNITY_EDITOR
    public static readonly string CONFIG_FOLDER = Path.Combine("ExtraBuildFiles", "Config");
#else
    public static readonly string CONFIG_FOLDER = "Config";
#endif
}
