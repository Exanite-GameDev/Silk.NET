// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_DoneFunc")]
public readonly unsafe struct RasterDoneFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<FT_RasterRec_*, void> Handle =>
        (delegate* unmanaged<FT_RasterRec_*, void>)Pointer;

    public RasterDoneFunc(delegate* unmanaged<FT_RasterRec_*, void> ptr) => Pointer = ptr;

    public RasterDoneFunc(RasterDoneFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterDoneFunc(delegate* unmanaged<FT_RasterRec_*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<FT_RasterRec_*, void>(RasterDoneFunc pfn) =>
        (delegate* unmanaged<FT_RasterRec_*, void>)pfn.Pointer;
}
