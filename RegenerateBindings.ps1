# Regenerate bindings
dotnet run --project src/Core/Silk.NET.BuildTools generator.json --profile=FreeType
dotnet run --project src/Core/Silk.NET.BuildTools generator.json --profile=HarfBuzz
dotnet run --project src/Core/Silk.NET.BuildTools generator.json --profile=VulkanMemoryAllocator
dotnet run --project src/Core/Silk.NET.BuildTools generator.json --profile=Tracy
dotnet run --project src/Core/Silk.NET.BuildTools generator.json --profile=Slang