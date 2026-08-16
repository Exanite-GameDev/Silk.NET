// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Render_Mode_")]
public enum RenderMode : uint
{
    [NativeName("FT_RENDER_MODE_NORMAL")]
    Normal = 0,

    [NativeName("FT_RENDER_MODE_LIGHT")]
    Light = 1,

    [NativeName("FT_RENDER_MODE_MONO")]
    Mono = 2,

    [NativeName("FT_RENDER_MODE_LCD")]
    Lcd = 3,

    [NativeName("FT_RENDER_MODE_LCD_V")]
    LcdV = 4,

    [NativeName("FT_RENDER_MODE_SDF")]
    Sdf = 5,

    [NativeName("FT_RENDER_MODE_MAX")]
    Max = 6,
}
