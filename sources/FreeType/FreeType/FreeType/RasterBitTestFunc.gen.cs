// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_BitTest_Func")]
public readonly unsafe struct RasterBitTestFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, int, void*, int> Handle =>
        (delegate* unmanaged<int, int, void*, int>)Pointer;

    public RasterBitTestFunc(delegate* unmanaged<int, int, void*, int> ptr) => Pointer = ptr;

    public RasterBitTestFunc(RasterBitTestFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator RasterBitTestFunc(
        delegate* unmanaged<int, int, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<int, int, void*, int>(
        RasterBitTestFunc pfn
    ) => (delegate* unmanaged<int, int, void*, int>)pfn.Pointer;
}
