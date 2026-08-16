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
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.HarfBuzz;

[NativeName("hb_unicode_general_category_t")]
public enum UnicodeGeneralCategoryT : uint
{
    [NativeName("HB_UNICODE_GENERAL_CATEGORY_CONTROL")]
    Control = 0,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_FORMAT")]
    Format = 1,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_UNASSIGNED")]
    Unassigned = 2,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_PRIVATE_USE")]
    PrivateUse = 3,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_SURROGATE")]
    Surrogate = 4,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_LOWERCASE_LETTER")]
    LowercaseLetter = 5,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_MODIFIER_LETTER")]
    ModifierLetter = 6,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_OTHER_LETTER")]
    OtherLetter = 7,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_TITLECASE_LETTER")]
    TitlecaseLetter = 8,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_UPPERCASE_LETTER")]
    UppercaseLetter = 9,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_SPACING_MARK")]
    SpacingMark = 10,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_ENCLOSING_MARK")]
    EnclosingMark = 11,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_NON_SPACING_MARK")]
    NonSpacingMark = 12,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_DECIMAL_NUMBER")]
    DecimalNumber = 13,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_LETTER_NUMBER")]
    LetterNumber = 14,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_OTHER_NUMBER")]
    OtherNumber = 15,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_CONNECT_PUNCTUATION")]
    ConnectPunctuation = 16,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_DASH_PUNCTUATION")]
    DashPunctuation = 17,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_CLOSE_PUNCTUATION")]
    ClosePunctuation = 18,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_FINAL_PUNCTUATION")]
    FinalPunctuation = 19,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_INITIAL_PUNCTUATION")]
    InitialPunctuation = 20,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_OTHER_PUNCTUATION")]
    OtherPunctuation = 21,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_OPEN_PUNCTUATION")]
    OpenPunctuation = 22,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_CURRENCY_SYMBOL")]
    CurrencySymbol = 23,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_MODIFIER_SYMBOL")]
    ModifierSymbol = 24,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_MATH_SYMBOL")]
    MathSymbol = 25,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_OTHER_SYMBOL")]
    OtherSymbol = 26,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_LINE_SEPARATOR")]
    LineSeparator = 27,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_PARAGRAPH_SEPARATOR")]
    ParagraphSeparator = 28,

    [NativeName("HB_UNICODE_GENERAL_CATEGORY_SPACE_SEPARATOR")]
    SpaceSeparator = 29,
}
