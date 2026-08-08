<h1 align="center">⚠️ This is a fork of Silk.NET ⚠️</h1>

This is a fork of Silk.NET for use by Exanite.Engine. While changes to this repo will still be under the same license
as the official Silk.NET repo, the changes to this repo will be intended for use by Exanite.Engine only and no support
will be given for any other use case.

Please find the original repo here: https://github.com/dotnet/Silk.NET

The primary differences with this fork are the following:

- Packages will be distributed under the `Exanite` NuGet prefix.
- Bindings not used by Exanite.Engine are not maintained and will not be distributed.
- Additional bindings required by Exanite.Engine are added (FreeType, HarfBuzz, Slang, VulkanMemoryAllocator).

<h1 align="center">About Silk.NET 2.X</h1>

Silk.NET is your one-stop-shop for high-speed .NET multimedia, graphics, and compute; providing bindings to popular low-level APIs such as OpenGL, OpenCL, OpenAL, OpenXR, GLFW, SDL, Vulkan, Assimp, WebGPU, and DirectX.

Use Silk.NET to spruce up applications with cross-platform 3D graphics, audio, compute and haptics!

Silk.NET works on any .NET Standard 2.0 compliant platform, including .NET 6.0, Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

<!-- Package description inserted here automatically. -->

<!-- Begin exclude from NuGet readme. -->

<h1 align="center">Building from source</h1>

**Prerequisites**

- .NET 6 SDK and .NET 7 SDK
- Android, iOS, and Mac Catalyst workloads (use `dotnet workload install android ios maccatalyst` to install them)
    - On Linux, `ios` and `maccatalyst` should be omitted as they are not available
- Android SDK versions 31, 33, and 34 with NDK tools installed
    - On Windows, for best results, this should be installed into `C:\ProgramData\Android\android-sdk`
- Java JDK 11+
- Visual Studio 2022 Community version 17.0 or later (optional)

**Instructions**

- Clone the repository
    - Note: Avoid performing a recursive clone as the submodules are not necessary for a normal build
- Run `build.sh`, `build.cmd`, `build.ps1`, or `nuke compile`
    - On Linux, you may need to pass `--msbuild-properties AndroidSdkDirectory=/path/to/android/sdk`
- Use the built assemblies
    - To get `.nupkg`s that you can use with NuGet instead, use `nuke pack`

There are more advanced build actions you can do too, such as `FullBuild`, `Pack`, `FullPack`, among others which you can view by doing `nuke --plan`.

<h1 align="center">Contributing</h1>

This fork of Silk.NET does not currently accept contributions. If you would like to contribute to the original Silk.NET
project, please refer to the original repo: https://github.com/dotnet/Silk.NET

<h1 align="center">Funding</h1>

This fork of Silk.NET does not accept funding. If you would like to support the original Silk.NET project, please
refer to the original repo: https://github.com/dotnet/Silk.NET

<!-- End exclude from NuGet readme. -->

<h1 align="center">License</h1>

The original Silk.NET repo is distributed under the MIT license and all changes made to this fork are also distributed
under the MIT license.
