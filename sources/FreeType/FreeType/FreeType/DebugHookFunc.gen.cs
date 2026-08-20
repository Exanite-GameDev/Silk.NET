// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_DebugHook_Func")]
public readonly unsafe struct DebugHookFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, int> Handle => (delegate* unmanaged<void*, int>)Pointer;

    public DebugHookFunc(delegate* unmanaged<void*, int> ptr) => Pointer = ptr;

    public DebugHookFunc(DebugHookFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator DebugHookFunc(delegate* unmanaged<void*, int> pfn) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, int>(DebugHookFunc pfn) =>
        (delegate* unmanaged<void*, int>)pfn.Pointer;
}
