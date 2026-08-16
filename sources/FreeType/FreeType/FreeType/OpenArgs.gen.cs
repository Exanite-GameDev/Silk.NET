// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Open_Args_")]
public unsafe partial struct OpenArgs
{
    [NativeName("flags")]
    public UInt Flags;

    [NativeName("memory_base")]
    public byte* MemoryBase;

    [NativeName("memory_size")]
    public nint MemorySize;

    [NativeName("pathname")]
    public sbyte* Pathname;

    [NativeName("stream")]
    public StreamRec* Stream;

    [NativeName("driver")]
    public ModuleRecHandle Driver;

    [NativeName("num_params")]
    public Int NumParams;

    [NativeName("@params")]
    public Parameter* @params;
}
