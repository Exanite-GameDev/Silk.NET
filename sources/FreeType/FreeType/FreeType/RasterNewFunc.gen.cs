// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_NewFunc")]
public readonly unsafe struct RasterNewFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, FT_RasterRec_**, int> Handle =>
        (delegate* unmanaged<void*, FT_RasterRec_**, int>)Pointer;

    public RasterNewFunc(delegate* unmanaged<void*, FT_RasterRec_**, int> ptr) => Pointer = ptr;

    public RasterNewFunc(RasterNewFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterNewFunc(
        delegate* unmanaged<void*, FT_RasterRec_**, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, FT_RasterRec_**, int>(
        RasterNewFunc pfn
    ) => (delegate* unmanaged<void*, FT_RasterRec_**, int>)pfn.Pointer;
}
