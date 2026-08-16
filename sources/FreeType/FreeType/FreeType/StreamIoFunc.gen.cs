// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Stream_IoFunc")]
public readonly unsafe struct StreamIoFunc : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint> Handle =>
        (delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint>)Pointer;

    public StreamIoFunc(delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint> ptr) =>
        Pointer = ptr;

    public StreamIoFunc(StreamIoFuncDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StreamIoFunc(
        delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint>(
        StreamIoFunc pfn
    ) => (delegate* unmanaged<StreamRec*, nuint, byte*, nuint, nuint>)pfn.Pointer;
}
