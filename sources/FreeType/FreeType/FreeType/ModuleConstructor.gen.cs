// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Module_Constructor")]
public readonly unsafe struct ModuleConstructor : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<ModuleRecHandle, int> Handle =>
        (delegate* unmanaged<ModuleRecHandle, int>)Pointer;

    public ModuleConstructor(delegate* unmanaged<ModuleRecHandle, int> ptr) => Pointer = ptr;

    public ModuleConstructor(ModuleConstructorDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator ModuleConstructor(
        delegate* unmanaged<ModuleRecHandle, int> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<ModuleRecHandle, int>(
        ModuleConstructor pfn
    ) => (delegate* unmanaged<ModuleRecHandle, int>)pfn.Pointer;
}
