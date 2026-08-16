// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_MoveToFunc")]
public readonly unsafe struct OutlineMoveToFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<Vector*, void*, int> Handle =>
        (delegate* unmanaged<Vector*, void*, int>)Pointer;

    public OutlineMoveToFunc(delegate* unmanaged<Vector*, void*, int> ptr) => Pointer = ptr;

    public OutlineMoveToFunc(OutlineMoveToFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator OutlineMoveToFunc(
        delegate* unmanaged<Vector*, void*, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<Vector*, void*, int>(
        OutlineMoveToFunc pfn
    ) => (delegate* unmanaged<Vector*, void*, int>)pfn.Pointer;
}
