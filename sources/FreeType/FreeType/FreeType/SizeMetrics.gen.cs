// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Size_Metrics_")]
public partial struct SizeMetrics
{
    [NativeName("x_ppem")]
    public ushort XPpem;

    [NativeName("y_ppem")]
    public ushort YPpem;

    [NativeName("x_scale")]
    public nint XScale;

    [NativeName("y_scale")]
    public nint YScale;

    [NativeName("ascender")]
    public nint Ascender;

    [NativeName("descender")]
    public nint Descender;

    [NativeName("height")]
    public nint Height;

    [NativeName("max_advance")]
    public nint MaxAdvance;
}
