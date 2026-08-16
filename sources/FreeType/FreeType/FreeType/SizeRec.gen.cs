// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_SizeRec_")]
public unsafe partial struct SizeRec
{
    [NativeName("face")]
    public FaceRec* Face;

    [NativeName("generic")]
    public Generic Generic;

    [NativeName("metrics")]
    public SizeMetrics Metrics;

    [NativeName("@internal")]
    public SizeInternalRecHandle @internal;
}
