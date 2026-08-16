// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_FaceRec_")]
public unsafe partial struct FaceRec
{
    [NativeName("num_faces")]
    public nint NumFaces;

    [NativeName("face_index")]
    public nint FaceIndex;

    [NativeName("face_flags")]
    public nint FaceFlags;

    [NativeName("style_flags")]
    public nint StyleFlags;

    [NativeName("num_glyphs")]
    public nint NumGlyphs;

    [NativeName("family_name")]
    public sbyte* FamilyName;

    [NativeName("style_name")]
    public sbyte* StyleName;

    [NativeName("num_fixed_sizes")]
    public Int NumFixedSizes;

    [NativeName("available_sizes")]
    public BitmapSize* AvailableSizes;

    [NativeName("num_charmaps")]
    public Int NumCharmaps;

    [NativeName("charmaps")]
    public CharMapRec** Charmaps;

    [NativeName("generic")]
    public Generic Generic;

    [NativeName("bbox")]
    public BBox Bbox;

    [NativeName("units_per_EM")]
    public UShort UnitsPerEM;

    [NativeName("ascender")]
    public short Ascender;

    [NativeName("descender")]
    public short Descender;

    [NativeName("height")]
    public short Height;

    [NativeName("max_advance_width")]
    public short MaxAdvanceWidth;

    [NativeName("max_advance_height")]
    public short MaxAdvanceHeight;

    [NativeName("underline_position")]
    public short UnderlinePosition;

    [NativeName("underline_thickness")]
    public short UnderlineThickness;

    [NativeName("glyph")]
    public GlyphSlotRec* Glyph;

    [NativeName("size")]
    public SizeRec* Size;

    [NativeName("charmap")]
    public CharMapRec* Charmap;

    [NativeName("driver")]
    public DriverRecHandle Driver;

    [NativeName("memory")]
    public MemoryRec* Memory;

    [NativeName("stream")]
    public StreamRec* Stream;

    [NativeName("sizes_list")]
    public ListRec SizesList;

    [NativeName("autohint")]
    public Generic Autohint;

    [NativeName("extensions")]
    public void* Extensions;

    [NativeName("@internal")]
    public FaceInternalRecHandle @internal;
}
