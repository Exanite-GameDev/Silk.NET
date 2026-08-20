// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.FreeType;

partial class FreeType(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport : IFreeType.Static
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IFreeType.Static
    {
        public static ThreadLocal<IFreeType> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(IFreeType ctx) => Underlying.Value = ctx;
    }

    private readonly unsafe void*[] _slots = new void*[60];
    public static IFreeType Instance { get; } = new StaticWrapper<DllImport>();

    public static IFreeType Create() => Instance;

    public static IFreeType Create(INativeContext ctx) => new FreeType(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
