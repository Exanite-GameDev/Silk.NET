// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is under the following copyright and licensed under the MIT-Modern-Variant license:
// Copyright © 2010-2022  Google, Inc.
// Copyright © 2015-2020  Ebrahim Byagowi
// Copyright © 2019,2020  Facebook, Inc.
// Copyright © 2012,2015  Mozilla Foundation
// Copyright © 2011  Codethink Limited
// Copyright © 2008,2010  Nokia Corporation and/or its subsidiary(-ies)
// Copyright © 2009  Keith Stribley
// Copyright © 2011  Martin Hosken and SIL International
// Copyright © 2007  Chris Wilson
// Copyright © 2005,2006,2020,2021,2022,2023  Behdad Esfahbod
// Copyright © 2004,2007,2008,2009,2010,2013,2021,2022,2023  Red Hat, Inc.
// Copyright © 1998-2005  David Turner and Werner Lemberg
// Copyright © 2016  Igalia S.L.
// Copyright © 2022  Matthias Clasen
// Copyright © 2018,2021  Khaled Hosny
// Copyright © 2018,2019,2020  Adobe, Inc
// Copyright © 2013-2015  Alexei Podtelezhnikov
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.HarfBuzz;

[NativeName("hb_buffer_diff_flags_t")]
public enum BufferDiffFlagsT : uint
{
    [NativeName("HB_BUFFER_DIFF_FLAG_EQUAL")]
    Equal = 0,

    [NativeName("HB_BUFFER_DIFF_FLAG_CONTENT_TYPE_MISMATCH")]
    ContentTypeMismatch = 1,

    [NativeName("HB_BUFFER_DIFF_FLAG_LENGTH_MISMATCH")]
    LengthMismatch = 2,

    [NativeName("HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT")]
    NotdefPresent = 4,

    [NativeName("HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT")]
    DottedCirclePresent = 8,

    [NativeName("HB_BUFFER_DIFF_FLAG_CODEPOINT_MISMATCH")]
    CodepointMismatch = 16,

    [NativeName("HB_BUFFER_DIFF_FLAG_CLUSTER_MISMATCH")]
    ClusterMismatch = 32,

    [NativeName("HB_BUFFER_DIFF_FLAG_GLYPH_FLAGS_MISMATCH")]
    GlyphFlagsMismatch = 64,

    [NativeName("HB_BUFFER_DIFF_FLAG_POSITION_MISMATCH")]
    PositionMismatch = 128,
}
