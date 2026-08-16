// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Glyph_Format_")]
public enum GlyphFormat : uint
{
    [NativeName("FT_GLYPH_FORMAT_NONE")]
    None = 0,

    [NativeName("FT_GLYPH_FORMAT_COMPOSITE")]
    Composite = 1668246896,

    [NativeName("FT_GLYPH_FORMAT_BITMAP")]
    Bitmap = 1651078259,

    [NativeName("FT_GLYPH_FORMAT_OUTLINE")]
    Outline = 1869968492,

    [NativeName("FT_GLYPH_FORMAT_PLOTTER")]
    Plotter = 1886154612,

    [NativeName("FT_GLYPH_FORMAT_SVG")]
    Svg = 1398163232,
}
