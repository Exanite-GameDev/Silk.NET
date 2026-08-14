// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Tracy
{
    /// <summary>
    /// Contains the library name of Tracy.
    /// </summary>
    public class TracyLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libExaniteTracyClient.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libExaniteTracyClient.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libExaniteTracyClient.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libExaniteTracyClient.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "ExaniteTracyClient.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "ExaniteTracyClient.dll" };
    }
}
