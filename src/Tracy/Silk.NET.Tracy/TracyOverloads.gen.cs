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
    public static class TracyOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 32, Column 16 in TracyC.h")]
        public static unsafe void TracySetThreadName(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracySetThreadName(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, source, sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, function, functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, function, functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, source, sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 243, Column 25 in TracyC.h")]
        public static unsafe TracyCZoneContext TracyEmitZoneBegin(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc, int active)
        {
            // SpanOverloader
            return thisApi.TracyEmitZoneBegin(in srcloc.GetPinnableReference(), active);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 25 in TracyC.h")]
        public static unsafe TracyCZoneContext TracyEmitZoneBeginCallstack(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc, int depth, int active)
        {
            // SpanOverloader
            return thisApi.TracyEmitZoneBeginCallstack(in srcloc.GetPinnableReference(), depth, active);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneText(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneText(ctx, in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneTextFmt(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneTextFmt(ctx, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneName(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneName(ctx, in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 251, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneNameFmt(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneNameFmt(ctx, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAlloc<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAlloc(in ptr.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstack<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstack(in ptr.GetPinnableReference(), size, depth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFree<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFree(in ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 301, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstack<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstack(in ptr.GetPinnableReference(), depth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(ptr, size, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(ptr, size, depth, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(ptr, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 305, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(ptr, depth, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 305, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 305, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 305, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryDiscard(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryDiscard(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryDiscardCallstack(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int depth)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryDiscardCallstack(in name.GetPinnableReference(), depth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitLogString(this Tracy thisApi, byte severity, int color, int callstack_depth, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt)
        {
            // SpanOverloader
            thisApi.TracyEmitLogString(severity, color, callstack_depth, size, in txt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitLogStringL(this Tracy thisApi, byte severity, int color, int callstack_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt)
        {
            // SpanOverloader
            thisApi.TracyEmitLogStringL(severity, color, callstack_depth, in txt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMark(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMark(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMarkStart(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMarkStart(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMarkEnd(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMarkEnd(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameImage<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> image, ushort w, ushort h, byte offset, int flip) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitFrameImage(in image.GetPinnableReference(), w, h, offset, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 337, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlot(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, double val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlot(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotFloat(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, float val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotFloat(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotInt(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, long val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotInt(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotConfig(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int type, int step, int fill, uint color)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotConfig(in name.GetPinnableReference(), type, step, fill, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 341, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMessageAppinfo(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitMessageAppinfo(in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 49 in TracyC.h")]
        public static unsafe TracyLockableContextData* TracyAnnounceLockableCtx(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            return thisApi.TracyAnnounceLockableCtx(in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 16 in TracyC.h")]
        public static unsafe void TracyMarkLockableCtx(this Tracy thisApi, TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            thisApi.TracyMarkLockableCtx(lockdata, in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 16 in TracyC.h")]
        public static unsafe void TracyCustomNameLockableCtx(this Tracy thisApi, TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz)
        {
            // SpanOverloader
            thisApi.TracyCustomNameLockableCtx(lockdata, in name.GetPinnableReference(), nameSz);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 56 in TracyC.h")]
        public static unsafe TracySharedLockableContextData* TracyAnnounceSharedLockableCtx(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            return thisApi.TracyAnnounceSharedLockableCtx(in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 16 in TracyC.h")]
        public static unsafe void TracyMarkSharedLockableCtx(this Tracy thisApi, TracySharedLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            thisApi.TracyMarkSharedLockableCtx(lockdata, in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 16 in TracyC.h")]
        public static unsafe void TracyCustomNameSharedLockableCtx(this Tracy thisApi, TracySharedLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz)
        {
            // SpanOverloader
            thisApi.TracyCustomNameSharedLockableCtx(lockdata, in name.GetPinnableReference(), nameSz);
        }

    }
}

