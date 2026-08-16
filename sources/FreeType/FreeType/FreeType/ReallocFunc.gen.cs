// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Realloc_Func")]
public readonly unsafe struct ReallocFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<MemoryRec*, nint, nint, void*, void*> Handle =>
        (delegate* unmanaged<MemoryRec*, nint, nint, void*, void*>)Pointer;

    public ReallocFunc(delegate* unmanaged<MemoryRec*, nint, nint, void*, void*> ptr) =>
        Pointer = ptr;

    public ReallocFunc(ReallocFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ReallocFunc(
        delegate* unmanaged<MemoryRec*, nint, nint, void*, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<MemoryRec*, nint, nint, void*, void*>(
        ReallocFunc pfn
    ) => (delegate* unmanaged<MemoryRec*, nint, nint, void*, void*>)pfn.Pointer;
}
