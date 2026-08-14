// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.FreeType
{
    /// <summary>
    /// Contains the library name of FreeType.
    /// </summary>
    public class FreeTypeLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libfreetype.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libfreetype.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libfreetype.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libfreetype.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "freetype.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "freetype.dll" };
    }
}
