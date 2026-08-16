// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Generic_")]
public unsafe partial struct Generic
{
    [NativeName("data")]
    public void* Data;

    [NativeName("finalizer")]
    public GenericFinalizer Finalizer;
}
