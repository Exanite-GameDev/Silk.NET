// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Slang
{
    /// <summary>
    /// Contains the library name of Slang.
    /// </summary>
    public class SlangLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libslang-compiler.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libslang-compiler.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libslang-compiler.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libslang-compiler.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "slang-compiler.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "slang-compiler.dll" };
    }
}
