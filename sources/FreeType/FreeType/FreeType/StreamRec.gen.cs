// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_StreamRec_")]
public unsafe partial struct StreamRec
{
    [NativeName("@base")]
    public byte* @base;

    [NativeName("size")]
    public nuint Size;

    [NativeName("pos")]
    public nuint Pos;

    [NativeName("descriptor")]
    public StreamDesc Descriptor;

    [NativeName("pathname")]
    public StreamDesc Pathname;

    [NativeName("read")]
    public StreamIoFunc Read;

    [NativeName("close")]
    public StreamCloseFunc Close;

    [NativeName("memory")]
    public MemoryRec* Memory;

    [NativeName("cursor")]
    public byte* Cursor;

    [NativeName("limit")]
    public byte* Limit;
}
