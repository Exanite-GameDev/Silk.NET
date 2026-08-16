// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Bitmap_")]
public unsafe partial struct Bitmap
{
    [NativeName("rows")]
    public uint Rows;

    [NativeName("width")]
    public uint Width;

    [NativeName("pitch")]
    public int Pitch;

    [NativeName("buffer")]
    public byte* Buffer;

    [NativeName("num_grays")]
    public ushort NumGrays;

    [NativeName("pixel_mode")]
    public byte PixelMode;

    [NativeName("palette_mode")]
    public byte PaletteMode;

    [NativeName("palette")]
    public void* Palette;
}
