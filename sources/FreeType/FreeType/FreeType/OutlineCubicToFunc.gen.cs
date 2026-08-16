// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_CubicToFunc")]
public readonly unsafe struct OutlineCubicToFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<Vector*, Vector*, Vector*, void*, int> Handle =>
        (delegate* unmanaged<Vector*, Vector*, Vector*, void*, int>)Pointer;

    public OutlineCubicToFunc(delegate* unmanaged<Vector*, Vector*, Vector*, void*, int> ptr) =>
        Pointer = ptr;

    public OutlineCubicToFunc(OutlineCubicToFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator OutlineCubicToFunc(
        delegate* unmanaged<Vector*, Vector*, Vector*, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<Vector*, Vector*, Vector*, void*, int>(
        OutlineCubicToFunc pfn
    ) => (delegate* unmanaged<Vector*, Vector*, Vector*, void*, int>)pfn.Pointer;
}
