#!/usr/bin/env bash
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
export DOTNET_gcServer=0
export DOTNET_GCHeapHardLimit=0x20000000
CLI_DLL="$SCRIPT_DIR/bin/Release/net8.0/Miqbas.UnityPatcher.Cli.dll"
if [ ! -f "$CLI_DLL" ]; then
    CLI_DLL="$SCRIPT_DIR/bin/Debug/net8.0/Miqbas.UnityPatcher.Cli.dll"
fi
/workspace/clever-kalam/dotnet/dotnet "$CLI_DLL" "$@"
