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
    public long Width;

    [NativeName("height")]
    public long Height;

    [NativeName("horiBearingX")]
    public long HoriBearingX;

    [NativeName("horiBearingY")]
    public long HoriBearingY;

    [NativeName("horiAdvance")]
    public long HoriAdvance;

    [NativeName("vertBearingX")]
    public long VertBearingX;

    [NativeName("vertBearingY")]
    public long VertBearingY;

    [NativeName("vertAdvance")]
    public long VertAdvance;
}
