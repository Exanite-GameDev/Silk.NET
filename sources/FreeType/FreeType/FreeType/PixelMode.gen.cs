// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Pixel_Mode_")]
public enum PixelMode : uint
{
    [NativeName("FT_PIXEL_MODE_NONE")]
    None = 0,

    [NativeName("FT_PIXEL_MODE_MONO")]
    Mono = 1,

    [NativeName("FT_PIXEL_MODE_GRAY")]
    Gray = 2,

    [NativeName("FT_PIXEL_MODE_GRAY2")]
    Gray2 = 3,

    [NativeName("FT_PIXEL_MODE_GRAY4")]
    Gray4 = 4,

    [NativeName("FT_PIXEL_MODE_LCD")]
    Lcd = 5,

    [NativeName("FT_PIXEL_MODE_LCD_V")]
    LcdV = 6,

    [NativeName("FT_PIXEL_MODE_BGRA")]
    Bgra = 7,

    [NativeName("FT_PIXEL_MODE_MAX")]
    Max = 8,
}
