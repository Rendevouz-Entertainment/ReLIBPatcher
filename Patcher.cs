﻿using ReLIB;
using Mono.Cecil;

namespace SlibPatcher;

public static class Patcher
{
    private static readonly string BasePath = Path.Combine("BepInEx", "plugins", "ReLIB", "Lib");

    public static IEnumerable<string> TargetDLLs { get; } = new[]
    {
        "System.Threading.Tasks.Extensions.dll",
        "ZstdNet.dll",
        "libzstd.dll",
        "System.Buffers.dll",
        "System.Memory.dll",
        "System.Runtime.CompilerServices.Unsafe.dll",
        "PuppeteerSharp.dll",
        "Microsoft.Extensions.Logging.dll",
        "Microsoft.Bcl.AsyncInterfaces.dll",
        "Microsoft.Extensions.Logging.Abstractions.dll",
        "Microsoft.Extensions.Options.dll",
        "System.Drawing.Common.dll",
        "System.Reflection.Metadata.dll",
        "System.Collections.Immutable.dll",
        "System.Text.Encodings.Web.dll",
        "Microsoft.CodeAnalysis.CSharp.dll",
        "Microsoft.CodeAnalysis.dll",
        "System.Numerics.Vectors.dll",
        "System.Threading.Tasks.Extensions.dll",
        "Microsoft.CSharp.dll"

    };

    public static void Patch(ref AssemblyDefinition assembly)
    {
        assembly = AssemblyDefinition.ReadAssembly(Path.Combine(BasePath, $"{assembly.Name.Name}.dll"));
    }
}