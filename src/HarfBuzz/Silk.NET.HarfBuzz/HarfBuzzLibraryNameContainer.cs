// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.HarfBuzz
{
    /// <summary>
    /// Contains the library name of HarfBuzz.
    /// </summary>
    public class HarfBuzzLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libharfbuzz.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libharfbuzz.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libharfbuzz.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libharfbuzz.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "harfbuzz.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "harfbuzz.dll" };
    }
}
