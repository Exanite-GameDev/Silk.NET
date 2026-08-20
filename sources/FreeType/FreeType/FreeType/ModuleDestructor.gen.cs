// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Module_Destructor")]
public readonly unsafe struct ModuleDestructor : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ModuleRecHandle, void> Handle =>
        (delegate* unmanaged<ModuleRecHandle, void>)Pointer;

    public ModuleDestructor(delegate* unmanaged<ModuleRecHandle, void> ptr) => Pointer = ptr;

    public ModuleDestructor(ModuleDestructorDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ModuleDestructor(
        delegate* unmanaged<ModuleRecHandle, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ModuleRecHandle, void>(
        ModuleDestructor pfn
    ) => (delegate* unmanaged<ModuleRecHandle, void>)pfn.Pointer;
}
