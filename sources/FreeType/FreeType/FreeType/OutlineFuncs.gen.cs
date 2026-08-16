// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_Funcs_")]
public unsafe partial struct OutlineFuncs
{
    [NativeName("move_to")]
    public OutlineMoveToFunc MoveTo;

    [NativeName("line_to")]
    public OutlineLineToFunc LineTo;

    [NativeName("conic_to")]
    public OutlineConicToFunc ConicTo;

    [NativeName("cubic_to")]
    public OutlineCubicToFunc CubicTo;

    [NativeName("shift")]
    public int Shift;

    [NativeName("delta")]
    public long Delta;
}
