// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Glyph_Metrics_")]
public partial struct GlyphMetrics
{
    [NativeName("width")]
    public nint Width;

    [NativeName("height")]
    public nint Height;

    [NativeName("horiBearingX")]
    public nint HoriBearingX;

    [NativeName("horiBearingY")]
    public nint HoriBearingY;

    [NativeName("horiAdvance")]
    public nint HoriAdvance;

    [NativeName("vertBearingX")]
    public nint VertBearingX;

    [NativeName("vertBearingY")]
    public nint VertBearingY;

    [NativeName("vertAdvance")]
    public nint VertAdvance;
}
