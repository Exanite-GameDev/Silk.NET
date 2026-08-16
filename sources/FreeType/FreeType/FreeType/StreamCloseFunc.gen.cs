// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Stream_CloseFunc")]
public readonly unsafe struct StreamCloseFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<StreamRec*, void> Handle =>
        (delegate* unmanaged<StreamRec*, void>)Pointer;

    public StreamCloseFunc(delegate* unmanaged<StreamRec*, void> ptr) => Pointer = ptr;

    public StreamCloseFunc(StreamCloseFuncDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StreamCloseFunc(delegate* unmanaged<StreamRec*, void> pfn) =>
        new(pfn);

    public static implicit operator delegate* unmanaged<StreamRec*, void>(StreamCloseFunc pfn) =>
        (delegate* unmanaged<StreamRec*, void>)pfn.Pointer;
}
