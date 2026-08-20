// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Module_Requester")]
public readonly unsafe struct ModuleRequester : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ModuleRecHandle, sbyte*, void*> Handle =>
        (delegate* unmanaged<ModuleRecHandle, sbyte*, void*>)Pointer;

    public ModuleRequester(delegate* unmanaged<ModuleRecHandle, sbyte*, void*> ptr) =>
        Pointer = ptr;

    public ModuleRequester(ModuleRequesterDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ModuleRequester(
        delegate* unmanaged<ModuleRecHandle, sbyte*, void*> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ModuleRecHandle, sbyte*, void*>(
        ModuleRequester pfn
    ) => (delegate* unmanaged<ModuleRecHandle, sbyte*, void*>)pfn.Pointer;
}
