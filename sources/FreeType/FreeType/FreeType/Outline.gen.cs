// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Outline_")]
public unsafe partial struct Outline
{
    [NativeName("n_contours")]
    public ushort NContours;

    [NativeName("n_points")]
    public ushort NPoints;

    [NativeName("points")]
    public Vector* Points;

    [NativeName("tags")]
    public byte* Tags;

    [NativeName("contours")]
    public ushort* Contours;

    [NativeName("flags")]
    public int Flags;
}
