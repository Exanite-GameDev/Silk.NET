// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Generic_Finalizer")]
public readonly unsafe struct GenericFinalizer : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, void> Handle => (delegate* unmanaged<void*, void>)Pointer;

    public GenericFinalizer(delegate* unmanaged<void*, void> ptr) => Pointer = ptr;

    public GenericFinalizer(GenericFinalizerDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator GenericFinalizer(delegate* unmanaged<void*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<void*, void>(GenericFinalizer pfn) =>
        (delegate* unmanaged<void*, void>)pfn.Pointer;
}
