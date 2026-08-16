// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Raster_Params_")]
public unsafe partial struct RasterParams
{
    [NativeName("target")]
    public Bitmap* Target;

    [NativeName("source")]
    public void* Source;

    [NativeName("flags")]
    public int Flags;

    [NativeName("gray_spans")]
    public SpanFunc GraySpans;

    [NativeName("black_spans")]
    public SpanFunc BlackSpans;

    [NativeName("bit_test")]
    public RasterBitTestFunc BitTest;

    [NativeName("bit_set")]
    public RasterBitSetFunc BitSet;

    [NativeName("user")]
    public void* User;

    [NativeName("clip_box")]
    public BBox ClipBox;
}
