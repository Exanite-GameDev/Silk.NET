// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

[NativeName("FT_Face_InternalRec_")]
public readonly unsafe partial struct FaceInternalRecHandle : IEquatable<FaceInternalRecHandle>
{
    public readonly void* Handle;

    public FaceInternalRecHandle(void* handle)
    {
        Handle = handle;
    }

    public bool Equals(FaceInternalRecHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is FaceInternalRecHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(FaceInternalRecHandle left, FaceInternalRecHandle right) =>
        left.Equals(right);

    public static bool operator !=(FaceInternalRecHandle left, FaceInternalRecHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(FaceInternalRecHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(FaceInternalRecHandle left, NullPtr right) =>
        !left.Equals(right);

    public static implicit operator FaceInternalRecHandle(NullPtr _) => default;
}
