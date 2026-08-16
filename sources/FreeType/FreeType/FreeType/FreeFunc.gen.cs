// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Free_Func")]
public readonly unsafe struct FreeFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemoryRec*, void*, void> Handle =>
        (delegate* unmanaged<MemoryRec*, void*, void>)Pointer;

    public FreeFunc(delegate* unmanaged<MemoryRec*, void*, void> ptr) => Pointer = ptr;

    public FreeFunc(FreeFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator FreeFunc(delegate* unmanaged<MemoryRec*, void*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<MemoryRec*, void*, void>(FreeFunc pfn) =>
        (delegate* unmanaged<MemoryRec*, void*, void>)pfn.Pointer;
}
