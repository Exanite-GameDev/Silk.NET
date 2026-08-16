// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_BitSet_Func")]
public readonly unsafe struct RasterBitSetFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, int, void*, void> Handle =>
        (delegate* unmanaged<int, int, void*, void>)Pointer;

    public RasterBitSetFunc(delegate* unmanaged<int, int, void*, void> ptr) => Pointer = ptr;

    public RasterBitSetFunc(RasterBitSetFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterBitSetFunc(
        delegate* unmanaged<int, int, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<int, int, void*, void>(
        RasterBitSetFunc pfn
    ) => (delegate* unmanaged<int, int, void*, void>)pfn.Pointer;
}
