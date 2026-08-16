// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is under the following copyright and licensed under the MIT-Modern-Variant license:
// Copyright © 2010-2022  Google, Inc.
// Copyright © 2015-2020  Ebrahim Byagowi
// Copyright © 2019,2020  Facebook, Inc.
// Copyright © 2012,2015  Mozilla Foundation
// Copyright © 2011  Codethink Limited
// Copyright © 2008,2010  Nokia Corporation and/or its subsidiary(-ies)
// Copyright © 2009  Keith Stribley
// Copyright © 2011  Martin Hosken and SIL International
// Copyright © 2007  Chris Wilson
// Copyright © 2005,2006,2020,2021,2022,2023  Behdad Esfahbod
// Copyright © 2004,2007,2008,2009,2010,2013,2021,2022,2023  Red Hat, Inc.
// Copyright © 1998-2005  David Turner and Werner Lemberg
// Copyright © 2016  Igalia S.L.
// Copyright © 2022  Matthias Clasen
// Copyright © 2018,2021  Khaled Hosny
// Copyright © 2018,2019,2020  Adobe, Inc
// Copyright © 2013-2015  Alexei Podtelezhnikov
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.HarfBuzz;

[NativeName("hb_paint_composite_mode_t")]
public enum PaintCompositeModeT : uint
{
    [NativeName("HB_PAINT_COMPOSITE_MODE_CLEAR")]
    Clear = 0,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SRC")]
    Src = 1,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DEST")]
    Dest = 2,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SRC_OVER")]
    SrcOver = 3,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DEST_OVER")]
    DestOver = 4,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SRC_IN")]
    SrcIn = 5,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DEST_IN")]
    DestIn = 6,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SRC_OUT")]
    SrcOut = 7,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DEST_OUT")]
    DestOut = 8,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SRC_ATOP")]
    SrcAtop = 9,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DEST_ATOP")]
    DestAtop = 10,

    [NativeName("HB_PAINT_COMPOSITE_MODE_XOR")]
    Xor = 11,

    [NativeName("HB_PAINT_COMPOSITE_MODE_PLUS")]
    Plus = 12,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SCREEN")]
    Screen = 13,

    [NativeName("HB_PAINT_COMPOSITE_MODE_OVERLAY")]
    Overlay = 14,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DARKEN")]
    Darken = 15,

    [NativeName("HB_PAINT_COMPOSITE_MODE_LIGHTEN")]
    Lighten = 16,

    [NativeName("HB_PAINT_COMPOSITE_MODE_COLOR_DODGE")]
    ColorDodge = 17,

    [NativeName("HB_PAINT_COMPOSITE_MODE_COLOR_BURN")]
    ColorBurn = 18,

    [NativeName("HB_PAINT_COMPOSITE_MODE_HARD_LIGHT")]
    HardLight = 19,

    [NativeName("HB_PAINT_COMPOSITE_MODE_SOFT_LIGHT")]
    SoftLight = 20,

    [NativeName("HB_PAINT_COMPOSITE_MODE_DIFFERENCE")]
    Difference = 21,

    [NativeName("HB_PAINT_COMPOSITE_MODE_EXCLUSION")]
    Exclusion = 22,

    [NativeName("HB_PAINT_COMPOSITE_MODE_MULTIPLY")]
    Multiply = 23,

    [NativeName("HB_PAINT_COMPOSITE_MODE_HSL_HUE")]
    HslHue = 24,

    [NativeName("HB_PAINT_COMPOSITE_MODE_HSL_SATURATION")]
    HslSaturation = 25,

    [NativeName("HB_PAINT_COMPOSITE_MODE_HSL_COLOR")]
    HslColor = 26,

    [NativeName("HB_PAINT_COMPOSITE_MODE_HSL_LUMINOSITY")]
    HslLuminosity = 27,
}
