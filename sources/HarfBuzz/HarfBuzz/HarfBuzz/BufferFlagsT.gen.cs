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

[NativeName("hb_buffer_flags_t")]
public enum BufferFlagsT : uint
{
    [NativeName("HB_BUFFER_FLAG_DEFAULT")]
    Default = 0,

    [NativeName("HB_BUFFER_FLAG_BOT")]
    Bot = 1,

    [NativeName("HB_BUFFER_FLAG_EOT")]
    Eot = 2,

    [NativeName("HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES")]
    PreserveDefaultIgnorables = 4,

    [NativeName("HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES")]
    RemoveDefaultIgnorables = 8,

    [NativeName("HB_BUFFER_FLAG_DO_NOT_INSERT_DOTTED_CIRCLE")]
    DoNotInsertDottedCircle = 16,

    [NativeName("HB_BUFFER_FLAG_VERIFY")]
    Verify = 32,

    [NativeName("HB_BUFFER_FLAG_PRODUCE_UNSAFE_TO_CONCAT")]
    ProduceUnsafeToConcat = 64,

    [NativeName("HB_BUFFER_FLAG_PRODUCE_SAFE_TO_INSERT_TATWEEL")]
    ProduceSafeToInsertTatweel = 128,

    [NativeName("HB_BUFFER_FLAG_DEFINED")]
    Defined = 255,
}
