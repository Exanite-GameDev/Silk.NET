// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_GlyphSlotRec_")]
public unsafe partial struct GlyphSlotRec
{
    [NativeName("library")]
    public LibraryRecHandle Library;

    [NativeName("face")]
    public FaceRec* Face;

    [NativeName("next")]
    public GlyphSlotRec* Next;

    [NativeName("glyph_index")]
    public UInt GlyphIndex;

    [NativeName("generic")]
    public Generic Generic;

    [NativeName("metrics")]
    public GlyphMetrics Metrics;

    [NativeName("linearHoriAdvance")]
    public nint LinearHoriAdvance;

    [NativeName("linearVertAdvance")]
    public nint LinearVertAdvance;

    [NativeName("advance")]
    public Vector Advance;

    [NativeName("format")]
    public GlyphFormat Format;

    [NativeName("bitmap")]
    public Bitmap Bitmap;

    [NativeName("bitmap_left")]
    public Int BitmapLeft;

    [NativeName("bitmap_top")]
    public Int BitmapTop;

    [NativeName("outline")]
    public Outline Outline;

    [NativeName("num_subglyphs")]
    public UInt NumSubglyphs;

    [NativeName("subglyphs")]
    public SubGlyphRecHandle Subglyphs;

    [NativeName("control_data")]
    public void* ControlData;

    [NativeName("control_len")]
    public nint ControlLen;

    [NativeName("lsb_delta")]
    public nint LsbDelta;

    [NativeName("rsb_delta")]
    public nint RsbDelta;

    [NativeName("other")]
    public void* Other;

    [NativeName("@internal")]
    public SlotInternalRecHandle @internal;
}
