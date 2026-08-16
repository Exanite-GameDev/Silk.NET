// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_ResetFunc")]
public readonly unsafe struct RasterResetFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void> Handle =>
        (delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void>)Pointer;

    public RasterResetFunc(delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void> ptr) =>
        Pointer = ptr;

    public RasterResetFunc(RasterResetFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterResetFunc(
        delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void>(
        RasterResetFunc pfn
    ) => (delegate* unmanaged<FT_RasterRec_*, byte*, nuint, void>)pfn.Pointer;
}
