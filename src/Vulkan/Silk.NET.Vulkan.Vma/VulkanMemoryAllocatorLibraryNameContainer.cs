// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan.Vma
{
    /// <summary>
    /// Contains the library name of VulkanMemoryAllocator.
    /// </summary>
    public class VulkanMemoryAllocatorLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libExaniteVulkanMemoryAllocator.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libExaniteVulkanMemoryAllocator.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libExaniteVulkanMemoryAllocator.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "libExaniteVulkanMemoryAllocator.dylib" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "ExaniteVulkanMemoryAllocator.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "ExaniteVulkanMemoryAllocator.dll" };
    }
}
