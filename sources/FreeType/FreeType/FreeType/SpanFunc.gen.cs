// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_SpanFunc")]
public readonly unsafe struct SpanFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<int, int, Span*, void*, void> Handle =>
        (delegate* unmanaged<int, int, Span*, void*, void>)Pointer;

    public SpanFunc(delegate* unmanaged<int, int, Span*, void*, void> ptr) => Pointer = ptr;

    public SpanFunc(SpanFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator SpanFunc(
        delegate* unmanaged<int, int, Span*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<int, int, Span*, void*, void>(
        SpanFunc pfn
    ) => (delegate* unmanaged<int, int, Span*, void*, void>)pfn.Pointer;
}
