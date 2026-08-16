// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Size_Metrics_")]
public partial struct SizeMetrics
{
    [NativeName("x_ppem")]
    public ushort XPpem;

    [NativeName("y_ppem")]
    public ushort YPpem;

    [NativeName("x_scale")]
    public long XScale;

    [NativeName("y_scale")]
    public long YScale;

    [NativeName("ascender")]
    public long Ascender;

    [NativeName("descender")]
    public long Descender;

    [NativeName("height")]
    public long Height;

    [NativeName("max_advance")]
    public long MaxAdvance;
}
