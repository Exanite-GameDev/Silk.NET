// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_ListNodeRec_")]
public unsafe partial struct ListNodeRec
{
    [NativeName("prev")]
    public ListNodeRec* Prev;

    [NativeName("next")]
    public ListNodeRec* Next;

    [NativeName("data")]
    public void* Data;
}
