// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Size_InternalRec_")]
public readonly unsafe partial struct SizeInternalRecHandle : IEquatable<SizeInternalRecHandle>
{
    public readonly void* Handle;

    public SizeInternalRecHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(SizeInternalRecHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is SizeInternalRecHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(SizeInternalRecHandle left, SizeInternalRecHandle right) =>
        left.Equals(right);

    public static bool operator !=(SizeInternalRecHandle left, SizeInternalRecHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(SizeInternalRecHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(SizeInternalRecHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator SizeInternalRecHandle(NullPtr _) => default;
}
