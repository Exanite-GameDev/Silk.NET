// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Tracy
{
    [NativeName("Name", "___tracy_c_zone_context")]
    public unsafe partial struct TracyCZoneContext
    {
        public TracyCZoneContext
        (
            uint? id = null,
            int? active = null,
            ulong? connectionId = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (active is not null)
            {
                Active = active.Value;
            }

            if (connectionId is not null)
            {
                ConnectionId = connectionId.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "id")]
        public uint Id;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "active")]
        public int Active;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "connectionId")]
        public ulong ConnectionId;
    }
}
