// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Alloc_Func")]
public readonly unsafe struct AllocFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemoryRec*, nint, void*> Handle =>
        (delegate* unmanaged<MemoryRec*, nint, void*>)Pointer;

    public AllocFunc(delegate* unmanaged<MemoryRec*, nint, void*> ptr) => Pointer = ptr;

    public AllocFunc(AllocFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator AllocFunc(delegate* unmanaged<MemoryRec*, nint, void*> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<MemoryRec*, nint, void*>(AllocFunc pfn) =>
        (delegate* unmanaged<MemoryRec*, nint, void*>)pfn.Pointer;
}
