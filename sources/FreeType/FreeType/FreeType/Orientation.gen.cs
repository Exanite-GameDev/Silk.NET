// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Orientation_")]
public enum Orientation : uint
{
    [NativeName("FT_ORIENTATION_TRUETYPE")]
    Truetype = 0,

    [NativeName("FT_ORIENTATION_POSTSCRIPT")]
    Postscript = 1,

    [NativeName("FT_ORIENTATION_FILL_RIGHT")]
    FillRight = Truetype,

    [NativeName("FT_ORIENTATION_FILL_LEFT")]
    FillLeft = Postscript,

    [NativeName("FT_ORIENTATION_NONE")]
    None = 2,
}
