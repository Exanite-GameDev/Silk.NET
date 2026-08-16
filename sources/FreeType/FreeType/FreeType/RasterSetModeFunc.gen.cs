// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_SetModeFunc")]
public readonly unsafe struct RasterSetModeFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<RasterRecHandle, nuint, void*, int> Handle =>
        (delegate* unmanaged<RasterRecHandle, nuint, void*, int>)Pointer;

    public RasterSetModeFunc(delegate* unmanaged<RasterRecHandle, nuint, void*, int> ptr) =>
        Pointer = ptr;

    public RasterSetModeFunc(RasterSetModeFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterSetModeFunc(
        delegate* unmanaged<RasterRecHandle, nuint, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<RasterRecHandle, nuint, void*, int>(
        RasterSetModeFunc pfn
    ) => (delegate* unmanaged<RasterRecHandle, nuint, void*, int>)pfn.Pointer;
}
