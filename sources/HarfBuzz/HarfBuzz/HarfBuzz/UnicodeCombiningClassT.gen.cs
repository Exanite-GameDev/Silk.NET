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

[NativeName("hb_unicode_combining_class_t")]
public enum UnicodeCombiningClassT : uint
{
    [NativeName("HB_UNICODE_COMBINING_CLASS_NOT_REORDERED")]
    NotReordered = 0,

    [NativeName("HB_UNICODE_COMBINING_CLASS_OVERLAY")]
    Overlay = 1,

    [NativeName("HB_UNICODE_COMBINING_CLASS_NUKTA")]
    Nukta = 7,

    [NativeName("HB_UNICODE_COMBINING_CLASS_KANA_VOICING")]
    KanaVoicing = 8,

    [NativeName("HB_UNICODE_COMBINING_CLASS_VIRAMA")]
    Virama = 9,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC10")]
    Ccc10 = 10,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC11")]
    Ccc11 = 11,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC12")]
    Ccc12 = 12,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC13")]
    Ccc13 = 13,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC14")]
    Ccc14 = 14,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC15")]
    Ccc15 = 15,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC16")]
    Ccc16 = 16,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC17")]
    Ccc17 = 17,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC18")]
    Ccc18 = 18,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC19")]
    Ccc19 = 19,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC20")]
    Ccc20 = 20,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC21")]
    Ccc21 = 21,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC22")]
    Ccc22 = 22,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC23")]
    Ccc23 = 23,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC24")]
    Ccc24 = 24,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC25")]
    Ccc25 = 25,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC26")]
    Ccc26 = 26,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC27")]
    Ccc27 = 27,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC28")]
    Ccc28 = 28,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC29")]
    Ccc29 = 29,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC30")]
    Ccc30 = 30,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC31")]
    Ccc31 = 31,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC32")]
    Ccc32 = 32,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC33")]
    Ccc33 = 33,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC34")]
    Ccc34 = 34,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC35")]
    Ccc35 = 35,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC36")]
    Ccc36 = 36,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC84")]
    Ccc84 = 84,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC91")]
    Ccc91 = 91,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC103")]
    Ccc103 = 103,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC107")]
    Ccc107 = 107,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC118")]
    Ccc118 = 118,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC122")]
    Ccc122 = 122,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC129")]
    Ccc129 = 129,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC130")]
    Ccc130 = 130,

    [NativeName("HB_UNICODE_COMBINING_CLASS_CCC132")]
    Ccc132 = 132,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW_LEFT")]
    AttachedBelowLeft = 200,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW")]
    AttachedBelow = 202,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE")]
    AttachedAbove = 214,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE_RIGHT")]
    AttachedAboveRight = 216,

    [NativeName("HB_UNICODE_COMBINING_CLASS_BELOW_LEFT")]
    BelowLeft = 218,

    [NativeName("HB_UNICODE_COMBINING_CLASS_BELOW")]
    Below = 220,

    [NativeName("HB_UNICODE_COMBINING_CLASS_BELOW_RIGHT")]
    BelowRight = 222,

    [NativeName("HB_UNICODE_COMBINING_CLASS_LEFT")]
    Left = 224,

    [NativeName("HB_UNICODE_COMBINING_CLASS_RIGHT")]
    Right = 226,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ABOVE_LEFT")]
    AboveLeft = 228,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ABOVE")]
    Above = 230,

    [NativeName("HB_UNICODE_COMBINING_CLASS_ABOVE_RIGHT")]
    AboveRight = 232,

    [NativeName("HB_UNICODE_COMBINING_CLASS_DOUBLE_BELOW")]
    DoubleBelow = 233,

    [NativeName("HB_UNICODE_COMBINING_CLASS_DOUBLE_ABOVE")]
    DoubleAbove = 234,

    [NativeName("HB_UNICODE_COMBINING_CLASS_IOTA_SUBSCRIPT")]
    IotaSubscript = 240,

    [NativeName("HB_UNICODE_COMBINING_CLASS_INVALID")]
    Invalid = 255,
}
