// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_ConicToFunc")]
public readonly unsafe struct OutlineConicToFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<Vector*, Vector*, void*, int> Handle =>
        (delegate* unmanaged<Vector*, Vector*, void*, int>)Pointer;

    public OutlineConicToFunc(delegate* unmanaged<Vector*, Vector*, void*, int> ptr) =>
        Pointer = ptr;

    public OutlineConicToFunc(OutlineConicToFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator OutlineConicToFunc(
        delegate* unmanaged<Vector*, Vector*, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<Vector*, Vector*, void*, int>(
        OutlineConicToFunc pfn
    ) => (delegate* unmanaged<Vector*, Vector*, void*, int>)pfn.Pointer;
}
