// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_LineToFunc")]
public readonly unsafe struct OutlineLineToFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<Vector*, void*, int> Handle =>
        (delegate* unmanaged<Vector*, void*, int>)Pointer;

    public OutlineLineToFunc(delegate* unmanaged<Vector*, void*, int> ptr) => Pointer = ptr;

    public OutlineLineToFunc(OutlineLineToFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator OutlineLineToFunc(
        delegate* unmanaged<Vector*, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<Vector*, void*, int>(
        OutlineLineToFunc pfn
    ) => (delegate* unmanaged<Vector*, void*, int>)pfn.Pointer;
}
