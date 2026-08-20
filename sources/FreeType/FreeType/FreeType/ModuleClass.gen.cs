// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Module_Class_")]
public unsafe partial struct ModuleClass
{
    [NativeName("module_flags")]
    public ulong ModuleFlags;

    [NativeName("module_size")]
    public long ModuleSize;

    [NativeName("module_name")]
    public sbyte* ModuleName;

    [NativeName("module_version")]
    public long ModuleVersion;

    [NativeName("module_requires")]
    public long ModuleRequires;

    [NativeName("module_interface")]
    public void* ModuleInterface;

    [NativeName("module_init")]
    public ModuleConstructor ModuleInit;

    [NativeName("module_done")]
    public ModuleDestructor ModuleDone;

    [NativeName("get_interface")]
    public ModuleRequester GetInterface;
}
