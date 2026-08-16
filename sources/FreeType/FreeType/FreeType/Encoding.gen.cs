// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Encoding_")]
public enum Encoding : uint
{
    [NativeName("FT_ENCODING_NONE")]
    None = 0,

    [NativeName("FT_ENCODING_MS_SYMBOL")]
    MsSymbol = 1937337698,

    [NativeName("FT_ENCODING_UNICODE")]
    Unicode = 1970170211,

    [NativeName("FT_ENCODING_SJIS")]
    Sjis = 1936353651,

    [NativeName("FT_ENCODING_PRC")]
    Prc = 1734484000,

    [NativeName("FT_ENCODING_BIG5")]
    Big5 = 1651074869,

    [NativeName("FT_ENCODING_WANSUNG")]
    Wansung = 2002873971,

    [NativeName("FT_ENCODING_JOHAB")]
    Johab = 1785686113,

    [NativeName("FT_ENCODING_GB2312")]
    Gb2312 = Prc,

    [NativeName("FT_ENCODING_MS_SJIS")]
    MsSjis = Sjis,

    [NativeName("FT_ENCODING_MS_GB2312")]
    MsGb2312 = Prc,

    [NativeName("FT_ENCODING_MS_BIG5")]
    MsBig5 = Big5,

    [NativeName("FT_ENCODING_MS_WANSUNG")]
    MsWansung = Wansung,

    [NativeName("FT_ENCODING_MS_JOHAB")]
    MsJohab = Johab,

    [NativeName("FT_ENCODING_ADOBE_STANDARD")]
    AdobeStandard = 1094995778,

    [NativeName("FT_ENCODING_ADOBE_EXPERT")]
    AdobeExpert = 1094992453,

    [NativeName("FT_ENCODING_ADOBE_CUSTOM")]
    AdobeCustom = 1094992451,

    [NativeName("FT_ENCODING_ADOBE_LATIN_1")]
    AdobeLatin1 = 1818326065,

    [NativeName("FT_ENCODING_OLD_LATIN_2")]
    OldLatin2 = 1818326066,

    [NativeName("FT_ENCODING_APPLE_ROMAN")]
    AppleRoman = 1634889070,
}
