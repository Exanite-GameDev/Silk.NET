// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_RenderFunc")]
public readonly unsafe struct RasterRenderFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<RasterRecHandle, RasterParams*, int> Handle =>
        (delegate* unmanaged<RasterRecHandle, RasterParams*, int>)Pointer;

    public RasterRenderFunc(delegate* unmanaged<RasterRecHandle, RasterParams*, int> ptr) =>
        Pointer = ptr;

    public RasterRenderFunc(RasterRenderFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterRenderFunc(
        delegate* unmanaged<RasterRecHandle, RasterParams*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<RasterRecHandle, RasterParams*, int>(
        RasterRenderFunc pfn
    ) => (delegate* unmanaged<RasterRecHandle, RasterParams*, int>)pfn.Pointer;
}
