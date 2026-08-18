// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is under the following copyright and licensed under the MIT-Modern-Variant license:
// Copyright © 2010-2022  Google, Inc.
// Copyright © 2015-2020  Ebrahim Byagowi
// Copyright © 2019,2020  Facebook, Inc.
// Copyright © 2012,2015  Mozilla Foundation
// Copyright © 2011  Codethink Limited
// Copyright © 2008,2010  Nokia Corporation and/or its subsidiary(-ies)
// Copyright © 2009  Keith Stribley
// Copyright © 2011  Martin Hosken and SIL International
// Copyright © 2007  Chris Wilson
// Copyright © 2005,2006,2020,2021,2022,2023  Behdad Esfahbod
// Copyright © 2004,2007,2008,2009,2010,2013,2021,2022,2023  Red Hat, Inc.
// Copyright © 1998-2005  David Turner and Werner Lemberg
// Copyright © 2016  Igalia S.L.
// Copyright © 2022  Matthias Clasen
// Copyright © 2018,2021  Khaled Hosny
// Copyright © 2018,2019,2020  Adobe, Inc
// Copyright © 2013-2015  Alexei Podtelezhnikov
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.HarfBuzz;

public unsafe partial interface IHarfBuzz
{
    public partial interface Static
    {
        [NativeName("hb_blob_copy_writable_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_copy_writable_or_fail")]
        static abstract BlobTHandle BlobCopyWritableOrFail(BlobTHandle blob);

        [NativeName("hb_blob_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create")]
        static abstract BlobTHandle BlobCreate(
            sbyte* data,
            uint length,
            MemoryModeT mode,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_blob_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create")]
        static abstract BlobTHandle BlobCreate(
            Ref<sbyte> data,
            uint length,
            MemoryModeT mode,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_blob_create_from_file")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file")]
        static abstract BlobTHandle BlobCreateFromFile(sbyte* file_name);

        [NativeName("hb_blob_create_from_file")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file")]
        static abstract BlobTHandle BlobCreateFromFile(Ref<sbyte> file_name);

        [NativeName("hb_blob_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file_or_fail")]
        static abstract BlobTHandle BlobCreateFromFileOrFail(sbyte* file_name);

        [NativeName("hb_blob_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file_or_fail")]
        static abstract BlobTHandle BlobCreateFromFileOrFail(Ref<sbyte> file_name);

        [NativeName("hb_blob_create_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_or_fail")]
        static abstract BlobTHandle BlobCreateOrFail(
            sbyte* data,
            uint length,
            MemoryModeT mode,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_blob_create_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_or_fail")]
        static abstract BlobTHandle BlobCreateOrFail(
            Ref<sbyte> data,
            uint length,
            MemoryModeT mode,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_blob_create_sub_blob")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_sub_blob")]
        static abstract BlobTHandle BlobCreateSubBlob(BlobTHandle parent, uint offset, uint length);

        [NativeName("hb_blob_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_destroy")]
        static abstract void BlobDestroy(BlobTHandle blob);

        [NativeName("hb_blob_get_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data")]
        static abstract sbyte* BlobGetData(BlobTHandle blob, uint* length);

        [NativeName("hb_blob_get_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data")]
        static abstract Ptr<sbyte> BlobGetData(BlobTHandle blob, Ref<uint> length);

        [NativeName("hb_blob_get_data_writable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data_writable")]
        static abstract sbyte* BlobGetDataWritable(BlobTHandle blob, uint* length);

        [NativeName("hb_blob_get_data_writable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data_writable")]
        static abstract Ptr<sbyte> BlobGetDataWritable(BlobTHandle blob, Ref<uint> length);

        [NativeName("hb_blob_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_empty")]
        static abstract BlobTHandle BlobGetEmpty();

        [NativeName("hb_blob_get_length")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_length")]
        static abstract uint BlobGetLength(BlobTHandle blob);

        [NativeName("hb_blob_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_user_data")]
        static abstract void* BlobGetUserData(BlobTHandle blob, UserDataKeyT* key);

        [NativeName("hb_blob_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_user_data")]
        static abstract Ptr BlobGetUserData(BlobTHandle blob, Ref<UserDataKeyT> key);

        [NativeName("hb_blob_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_is_immutable")]
        static abstract int BlobIsImmutable(BlobTHandle blob);

        [NativeName("hb_blob_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_make_immutable")]
        static abstract void BlobMakeImmutable(BlobTHandle blob);

        [NativeName("hb_blob_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_reference")]
        static abstract BlobTHandle BlobReference(BlobTHandle blob);

        [NativeName("hb_blob_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_set_user_data")]
        static abstract int BlobSetUserData(
            BlobTHandle blob,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_blob_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_blob_set_user_data")]
        static abstract int BlobSetUserData(
            BlobTHandle blob,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_buffer_add")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add")]
        static abstract void BufferAdd(BufferTHandle buffer, uint codepoint, uint cluster);

        [NativeName("hb_buffer_add_codepoints")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_codepoints")]
        static abstract void BufferAddCodepoints(
            BufferTHandle buffer,
            uint* text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_codepoints")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_codepoints")]
        static abstract void BufferAddCodepoints(
            BufferTHandle buffer,
            Ref<uint> text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_latin1")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_latin1")]
        static abstract void BufferAddLatin1(
            BufferTHandle buffer,
            byte* text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_latin1")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_latin1")]
        static abstract void BufferAddLatin1(
            BufferTHandle buffer,
            Ref<byte> text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf16")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf16")]
        static abstract void BufferAddUtf16(
            BufferTHandle buffer,
            ushort* text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf16")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf16")]
        static abstract void BufferAddUtf16(
            BufferTHandle buffer,
            Ref<ushort> text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf32")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf32")]
        static abstract void BufferAddUtf32(
            BufferTHandle buffer,
            uint* text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf32")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf32")]
        static abstract void BufferAddUtf32(
            BufferTHandle buffer,
            Ref<uint> text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf8")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf8")]
        static abstract void BufferAddUtf8(
            BufferTHandle buffer,
            sbyte* text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_add_utf8")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf8")]
        static abstract void BufferAddUtf8(
            BufferTHandle buffer,
            Ref<sbyte> text,
            int text_length,
            uint item_offset,
            int item_length
        );

        [NativeName("hb_buffer_allocation_successful")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_allocation_successful")]
        static abstract int BufferAllocationSuccessful(BufferTHandle buffer);

        [NativeName("hb_buffer_append")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_append")]
        static abstract void BufferAppend(
            BufferTHandle buffer,
            BufferTHandle source,
            uint start,
            uint end
        );

        [NativeName("hb_buffer_clear_contents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_clear_contents")]
        static abstract void BufferClearContents(BufferTHandle buffer);

        [NativeName("hb_buffer_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_create")]
        static abstract BufferTHandle BufferCreate();

        [NativeName("hb_buffer_create_similar")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_create_similar")]
        static abstract BufferTHandle BufferCreateSimilar(BufferTHandle src);

        [NativeName("hb_buffer_deserialize_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_glyphs")]
        static abstract int BufferDeserializeGlyphs(
            BufferTHandle buffer,
            sbyte* buf,
            int buf_len,
            sbyte** end_ptr,
            FontTHandle font,
            BufferSerializeFormatT format
        );

        [NativeName("hb_buffer_deserialize_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_glyphs")]
        static abstract int BufferDeserializeGlyphs(
            BufferTHandle buffer,
            Ref<sbyte> buf,
            int buf_len,
            Ref2D<sbyte> end_ptr,
            FontTHandle font,
            BufferSerializeFormatT format
        );

        [NativeName("hb_buffer_deserialize_unicode")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_unicode")]
        static abstract int BufferDeserializeUnicode(
            BufferTHandle buffer,
            sbyte* buf,
            int buf_len,
            sbyte** end_ptr,
            BufferSerializeFormatT format
        );

        [NativeName("hb_buffer_deserialize_unicode")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_unicode")]
        static abstract int BufferDeserializeUnicode(
            BufferTHandle buffer,
            Ref<sbyte> buf,
            int buf_len,
            Ref2D<sbyte> end_ptr,
            BufferSerializeFormatT format
        );

        [NativeName("hb_buffer_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_destroy")]
        static abstract void BufferDestroy(BufferTHandle buffer);

        [NativeName("hb_buffer_diff")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_diff")]
        static abstract BufferDiffFlagsT BufferDiff(
            BufferTHandle buffer,
            BufferTHandle reference,
            uint dottedcircle_glyph,
            uint position_fuzz
        );

        [NativeName("hb_buffer_get_cluster_level")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_cluster_level")]
        static abstract BufferClusterLevelT BufferGetClusterLevel(BufferTHandle buffer);

        [NativeName("hb_buffer_get_content_type")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_content_type")]
        static abstract BufferContentTypeT BufferGetContentType(BufferTHandle buffer);

        [NativeName("hb_buffer_get_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_direction")]
        static abstract DirectionT BufferGetDirection(BufferTHandle buffer);

        [NativeName("hb_buffer_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_empty")]
        static abstract BufferTHandle BufferGetEmpty();

        [NativeName("hb_buffer_get_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_flags")]
        static abstract BufferFlagsT BufferGetFlags(BufferTHandle buffer);

        [NativeName("hb_buffer_get_glyph_infos")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_infos")]
        static abstract GlyphInfoT* BufferGetGlyphInfos(BufferTHandle buffer, uint* length);

        [NativeName("hb_buffer_get_glyph_infos")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_infos")]
        static abstract Ptr<GlyphInfoT> BufferGetGlyphInfos(BufferTHandle buffer, Ref<uint> length);

        [NativeName("hb_buffer_get_glyph_positions")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_positions")]
        static abstract GlyphPositionT* BufferGetGlyphPositions(BufferTHandle buffer, uint* length);

        [NativeName("hb_buffer_get_glyph_positions")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_positions")]
        static abstract Ptr<GlyphPositionT> BufferGetGlyphPositions(
            BufferTHandle buffer,
            Ref<uint> length
        );

        [NativeName("hb_buffer_get_invisible_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_invisible_glyph")]
        static abstract uint BufferGetInvisibleGlyph(BufferTHandle buffer);

        [NativeName("hb_buffer_get_language")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_language")]
        static abstract LanguageImplTHandle BufferGetLanguage(BufferTHandle buffer);

        [NativeName("hb_buffer_get_length")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_length")]
        static abstract uint BufferGetLength(BufferTHandle buffer);

        [NativeName("hb_buffer_get_not_found_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_not_found_glyph")]
        static abstract uint BufferGetNotFoundGlyph(BufferTHandle buffer);

        [NativeName("hb_buffer_get_not_found_variation_selector_glyph")]
        [NativeFunction(
            "harfbuzz",
            EntryPoint = "hb_buffer_get_not_found_variation_selector_glyph"
        )]
        static abstract uint BufferGetNotFoundVariationSelectorGlyph(BufferTHandle buffer);

        [NativeName("hb_buffer_get_random_state")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_random_state")]
        static abstract uint BufferGetRandomState(BufferTHandle buffer);

        [NativeName("hb_buffer_get_replacement_codepoint")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_replacement_codepoint")]
        static abstract uint BufferGetReplacementCodepoint(BufferTHandle buffer);

        [NativeName("hb_buffer_get_script")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_script")]
        static abstract ScriptT BufferGetScript(BufferTHandle buffer);

        [NativeName("hb_buffer_get_segment_properties")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_segment_properties")]
        static abstract void BufferGetSegmentProperties(
            BufferTHandle buffer,
            SegmentPropertiesT* props
        );

        [NativeName("hb_buffer_get_segment_properties")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_segment_properties")]
        static abstract void BufferGetSegmentProperties(
            BufferTHandle buffer,
            Ref<SegmentPropertiesT> props
        );

        [NativeName("hb_buffer_get_unicode_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_unicode_funcs")]
        static abstract UnicodeFuncsTHandle BufferGetUnicodeFuncs(BufferTHandle buffer);

        [NativeName("hb_buffer_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_user_data")]
        static abstract void* BufferGetUserData(BufferTHandle buffer, UserDataKeyT* key);

        [NativeName("hb_buffer_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_user_data")]
        static abstract Ptr BufferGetUserData(BufferTHandle buffer, Ref<UserDataKeyT> key);

        [NativeName("hb_buffer_guess_segment_properties")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_guess_segment_properties")]
        static abstract void BufferGuessSegmentProperties(BufferTHandle buffer);

        [NativeName("hb_buffer_has_positions")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_has_positions")]
        static abstract int BufferHasPositions(BufferTHandle buffer);

        [NativeName("hb_buffer_normalize_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_normalize_glyphs")]
        static abstract void BufferNormalizeGlyphs(BufferTHandle buffer);

        [NativeName("hb_buffer_pre_allocate")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_pre_allocate")]
        static abstract int BufferPreAllocate(BufferTHandle buffer, uint size);

        [NativeName("hb_buffer_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reference")]
        static abstract BufferTHandle BufferReference(BufferTHandle buffer);

        [NativeName("hb_buffer_reset")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reset")]
        static abstract void BufferReset(BufferTHandle buffer);

        [NativeName("hb_buffer_reverse")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse")]
        static abstract void BufferReverse(BufferTHandle buffer);

        [NativeName("hb_buffer_reverse_clusters")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse_clusters")]
        static abstract void BufferReverseClusters(BufferTHandle buffer);

        [NativeName("hb_buffer_reverse_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse_range")]
        static abstract void BufferReverseRange(BufferTHandle buffer, uint start, uint end);

        [NativeName("hb_buffer_serialize")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize")]
        static abstract uint BufferSerialize(
            BufferTHandle buffer,
            uint start,
            uint end,
            sbyte* buf,
            uint buf_size,
            uint* buf_consumed,
            FontTHandle font,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_serialize")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize")]
        static abstract uint BufferSerialize(
            BufferTHandle buffer,
            uint start,
            uint end,
            Ref<sbyte> buf,
            uint buf_size,
            Ref<uint> buf_consumed,
            FontTHandle font,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_serialize_format_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_from_string")]
        static abstract BufferSerializeFormatT BufferSerializeFormatFromString(sbyte* str, int len);

        [NativeName("hb_buffer_serialize_format_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_from_string")]
        static abstract BufferSerializeFormatT BufferSerializeFormatFromString(
            Ref<sbyte> str,
            int len
        );

        [NativeName("hb_buffer_serialize_format_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_to_string")]
        static abstract Ptr<sbyte> BufferSerializeFormatToString(BufferSerializeFormatT format);

        [NativeName("hb_buffer_serialize_format_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_to_string")]
        static abstract sbyte* BufferSerializeFormatToStringRaw(BufferSerializeFormatT format);

        [NativeName("hb_buffer_serialize_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_glyphs")]
        static abstract uint BufferSerializeGlyphs(
            BufferTHandle buffer,
            uint start,
            uint end,
            sbyte* buf,
            uint buf_size,
            uint* buf_consumed,
            FontTHandle font,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_serialize_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_glyphs")]
        static abstract uint BufferSerializeGlyphs(
            BufferTHandle buffer,
            uint start,
            uint end,
            Ref<sbyte> buf,
            uint buf_size,
            Ref<uint> buf_consumed,
            FontTHandle font,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_serialize_list_formats")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_list_formats")]
        static abstract Ptr2D<sbyte> BufferSerializeListFormats();

        [NativeName("hb_buffer_serialize_list_formats")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_list_formats")]
        static abstract sbyte** BufferSerializeListFormatsRaw();

        [NativeName("hb_buffer_serialize_unicode")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_unicode")]
        static abstract uint BufferSerializeUnicode(
            BufferTHandle buffer,
            uint start,
            uint end,
            sbyte* buf,
            uint buf_size,
            uint* buf_consumed,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_serialize_unicode")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_unicode")]
        static abstract uint BufferSerializeUnicode(
            BufferTHandle buffer,
            uint start,
            uint end,
            Ref<sbyte> buf,
            uint buf_size,
            Ref<uint> buf_consumed,
            BufferSerializeFormatT format,
            BufferSerializeFlagsT flags
        );

        [NativeName("hb_buffer_set_cluster_level")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_cluster_level")]
        static abstract void BufferSetClusterLevel(
            BufferTHandle buffer,
            BufferClusterLevelT cluster_level
        );

        [NativeName("hb_buffer_set_content_type")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_content_type")]
        static abstract void BufferSetContentType(
            BufferTHandle buffer,
            BufferContentTypeT content_type
        );

        [NativeName("hb_buffer_set_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_direction")]
        static abstract void BufferSetDirection(BufferTHandle buffer, DirectionT direction);

        [NativeName("hb_buffer_set_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_flags")]
        static abstract void BufferSetFlags(BufferTHandle buffer, BufferFlagsT flags);

        [NativeName("hb_buffer_set_invisible_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_invisible_glyph")]
        static abstract void BufferSetInvisibleGlyph(BufferTHandle buffer, uint invisible);

        [NativeName("hb_buffer_set_language")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_language")]
        static abstract void BufferSetLanguage(BufferTHandle buffer, LanguageImplTHandle language);

        [NativeName("hb_buffer_set_length")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_length")]
        static abstract int BufferSetLength(BufferTHandle buffer, uint length);

        [NativeName("hb_buffer_set_message_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_message_func")]
        static abstract void BufferSetMessageFunc(
            BufferTHandle buffer,
            BufferMessageFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_buffer_set_message_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_message_func")]
        static abstract void BufferSetMessageFunc(
            BufferTHandle buffer,
            BufferMessageFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_buffer_set_not_found_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_not_found_glyph")]
        static abstract void BufferSetNotFoundGlyph(BufferTHandle buffer, uint not_found);

        [NativeName("hb_buffer_set_not_found_variation_selector_glyph")]
        [NativeFunction(
            "harfbuzz",
            EntryPoint = "hb_buffer_set_not_found_variation_selector_glyph"
        )]
        static abstract void BufferSetNotFoundVariationSelectorGlyph(
            BufferTHandle buffer,
            uint not_found_variation_selector
        );

        [NativeName("hb_buffer_set_random_state")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_random_state")]
        static abstract void BufferSetRandomState(BufferTHandle buffer, uint state);

        [NativeName("hb_buffer_set_replacement_codepoint")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_replacement_codepoint")]
        static abstract void BufferSetReplacementCodepoint(BufferTHandle buffer, uint replacement);

        [NativeName("hb_buffer_set_script")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_script")]
        static abstract void BufferSetScript(BufferTHandle buffer, ScriptT script);

        [NativeName("hb_buffer_set_segment_properties")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_segment_properties")]
        static abstract void BufferSetSegmentProperties(
            BufferTHandle buffer,
            SegmentPropertiesT* props
        );

        [NativeName("hb_buffer_set_segment_properties")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_segment_properties")]
        static abstract void BufferSetSegmentProperties(
            BufferTHandle buffer,
            Ref<SegmentPropertiesT> props
        );

        [NativeName("hb_buffer_set_unicode_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_unicode_funcs")]
        static abstract void BufferSetUnicodeFuncs(
            BufferTHandle buffer,
            UnicodeFuncsTHandle unicode_funcs
        );

        [NativeName("hb_buffer_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_user_data")]
        static abstract int BufferSetUserData(
            BufferTHandle buffer,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_buffer_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_user_data")]
        static abstract int BufferSetUserData(
            BufferTHandle buffer,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_calloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_calloc")]
        static abstract Ptr Calloc(nuint nmemb, nuint size);

        [NativeName("hb_calloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_calloc")]
        static abstract void* CallocRaw(nuint nmemb, nuint size);

        [NativeName("hb_color_get_alpha")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_alpha")]
        static abstract byte ColorGetAlpha(uint color);

        [NativeName("hb_color_get_blue")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_blue")]
        static abstract byte ColorGetBlue(uint color);

        [NativeName("hb_color_get_green")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_green")]
        static abstract byte ColorGetGreen(uint color);

        [NativeName("hb_color_get_red")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_red")]
        static abstract byte ColorGetRed(uint color);

        [NativeName("hb_color_line_get_color_stops")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_color_stops")]
        static abstract uint ColorLineGetColorStops(
            ColorLineT* color_line,
            uint start,
            uint* count,
            ColorStopT* color_stops
        );

        [NativeName("hb_color_line_get_color_stops")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_color_stops")]
        static abstract uint ColorLineGetColorStops(
            Ref<ColorLineT> color_line,
            uint start,
            Ref<uint> count,
            Ref<ColorStopT> color_stops
        );

        [NativeName("hb_color_line_get_extend")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_extend")]
        static abstract PaintExtendT ColorLineGetExtend(ColorLineT* color_line);

        [NativeName("hb_color_line_get_extend")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_extend")]
        static abstract PaintExtendT ColorLineGetExtend(Ref<ColorLineT> color_line);

        [NativeName("hb_direction_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_direction_from_string")]
        static abstract DirectionT DirectionFromString(sbyte* str, int len);

        [NativeName("hb_direction_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_direction_from_string")]
        static abstract DirectionT DirectionFromString(Ref<sbyte> str, int len);

        [NativeName("hb_direction_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_direction_to_string")]
        static abstract Ptr<sbyte> DirectionToString(DirectionT direction);

        [NativeName("hb_direction_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_direction_to_string")]
        static abstract sbyte* DirectionToStringRaw(DirectionT direction);

        [NativeName("hb_draw_close_path")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_close_path")]
        static abstract void DrawClosePath(
            DrawFuncsTHandle dfuncs,
            void* draw_data,
            DrawStateT* st
        );

        [NativeName("hb_draw_close_path")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_close_path")]
        static abstract void DrawClosePath(
            DrawFuncsTHandle dfuncs,
            Ref draw_data,
            Ref<DrawStateT> st
        );

        [NativeName("hb_draw_cubic_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_cubic_to")]
        static abstract void DrawCubicTo(
            DrawFuncsTHandle dfuncs,
            void* draw_data,
            DrawStateT* st,
            float control1_x,
            float control1_y,
            float control2_x,
            float control2_y,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_cubic_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_cubic_to")]
        static abstract void DrawCubicTo(
            DrawFuncsTHandle dfuncs,
            Ref draw_data,
            Ref<DrawStateT> st,
            float control1_x,
            float control1_y,
            float control2_x,
            float control2_y,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_funcs_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_create")]
        static abstract DrawFuncsTHandle DrawFuncsCreate();

        [NativeName("hb_draw_funcs_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_destroy")]
        static abstract void DrawFuncsDestroy(DrawFuncsTHandle dfuncs);

        [NativeName("hb_draw_funcs_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_empty")]
        static abstract DrawFuncsTHandle DrawFuncsGetEmpty();

        [NativeName("hb_draw_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_user_data")]
        static abstract void* DrawFuncsGetUserData(DrawFuncsTHandle dfuncs, UserDataKeyT* key);

        [NativeName("hb_draw_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_user_data")]
        static abstract Ptr DrawFuncsGetUserData(DrawFuncsTHandle dfuncs, Ref<UserDataKeyT> key);

        [NativeName("hb_draw_funcs_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_is_immutable")]
        static abstract int DrawFuncsIsImmutable(DrawFuncsTHandle dfuncs);

        [NativeName("hb_draw_funcs_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_make_immutable")]
        static abstract void DrawFuncsMakeImmutable(DrawFuncsTHandle dfuncs);

        [NativeName("hb_draw_funcs_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_reference")]
        static abstract DrawFuncsTHandle DrawFuncsReference(DrawFuncsTHandle dfuncs);

        [NativeName("hb_draw_funcs_set_close_path_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_close_path_func")]
        static abstract void DrawFuncsSetClosePathFunc(
            DrawFuncsTHandle dfuncs,
            DrawClosePathFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_close_path_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_close_path_func")]
        static abstract void DrawFuncsSetClosePathFunc(
            DrawFuncsTHandle dfuncs,
            DrawClosePathFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_cubic_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
        static abstract void DrawFuncsSetCubicToFunc(
            DrawFuncsTHandle dfuncs,
            DrawCubicToFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_cubic_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
        static abstract void DrawFuncsSetCubicToFunc(
            DrawFuncsTHandle dfuncs,
            DrawCubicToFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_line_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_line_to_func")]
        static abstract void DrawFuncsSetLineToFunc(
            DrawFuncsTHandle dfuncs,
            DrawLineToFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_line_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_line_to_func")]
        static abstract void DrawFuncsSetLineToFunc(
            DrawFuncsTHandle dfuncs,
            DrawLineToFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_move_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_move_to_func")]
        static abstract void DrawFuncsSetMoveToFunc(
            DrawFuncsTHandle dfuncs,
            DrawMoveToFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_move_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_move_to_func")]
        static abstract void DrawFuncsSetMoveToFunc(
            DrawFuncsTHandle dfuncs,
            DrawMoveToFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_quadratic_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
        static abstract void DrawFuncsSetQuadraticToFunc(
            DrawFuncsTHandle dfuncs,
            DrawQuadraticToFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_quadratic_to_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
        static abstract void DrawFuncsSetQuadraticToFunc(
            DrawFuncsTHandle dfuncs,
            DrawQuadraticToFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_draw_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_user_data")]
        static abstract int DrawFuncsSetUserData(
            DrawFuncsTHandle dfuncs,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_draw_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_user_data")]
        static abstract int DrawFuncsSetUserData(
            DrawFuncsTHandle dfuncs,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_draw_line_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_line_to")]
        static abstract void DrawLineTo(
            DrawFuncsTHandle dfuncs,
            void* draw_data,
            DrawStateT* st,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_line_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_line_to")]
        static abstract void DrawLineTo(
            DrawFuncsTHandle dfuncs,
            Ref draw_data,
            Ref<DrawStateT> st,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_move_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_move_to")]
        static abstract void DrawMoveTo(
            DrawFuncsTHandle dfuncs,
            void* draw_data,
            DrawStateT* st,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_move_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_move_to")]
        static abstract void DrawMoveTo(
            DrawFuncsTHandle dfuncs,
            Ref draw_data,
            Ref<DrawStateT> st,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_quadratic_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_quadratic_to")]
        static abstract void DrawQuadraticTo(
            DrawFuncsTHandle dfuncs,
            void* draw_data,
            DrawStateT* st,
            float control_x,
            float control_y,
            float to_x,
            float to_y
        );

        [NativeName("hb_draw_quadratic_to")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_draw_quadratic_to")]
        static abstract void DrawQuadraticTo(
            DrawFuncsTHandle dfuncs,
            Ref draw_data,
            Ref<DrawStateT> st,
            float control_x,
            float control_y,
            float to_x,
            float to_y
        );

        [NativeName("hb_face_builder_add_table")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_add_table")]
        static abstract int FaceBuilderAddTable(FaceTHandle face, uint tag, BlobTHandle blob);

        [NativeName("hb_face_builder_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_create")]
        static abstract FaceTHandle FaceBuilderCreate();

        [NativeName("hb_face_builder_sort_tables")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_sort_tables")]
        static abstract void FaceBuilderSortTables(FaceTHandle face, uint* tags);

        [NativeName("hb_face_builder_sort_tables")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_sort_tables")]
        static abstract void FaceBuilderSortTables(FaceTHandle face, Ref<uint> tags);

        [NativeName("hb_face_collect_nominal_glyph_mapping")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_nominal_glyph_mapping")]
        static abstract void FaceCollectNominalGlyphMapping(
            FaceTHandle face,
            MapTHandle mapping,
            SetTHandle unicodes
        );

        [NativeName("hb_face_collect_unicodes")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_unicodes")]
        static abstract void FaceCollectUnicodes(FaceTHandle face, SetTHandle @out);

        [NativeName("hb_face_collect_variation_selectors")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_variation_selectors")]
        static abstract void FaceCollectVariationSelectors(FaceTHandle face, SetTHandle @out);

        [NativeName("hb_face_collect_variation_unicodes")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_variation_unicodes")]
        static abstract void FaceCollectVariationUnicodes(
            FaceTHandle face,
            uint variation_selector,
            SetTHandle @out
        );

        [NativeName("hb_face_count")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_count")]
        static abstract uint FaceCount(BlobTHandle blob);

        [NativeName("hb_face_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create")]
        static abstract FaceTHandle FaceCreate(BlobTHandle blob, uint index);

        [NativeName("hb_face_create_for_tables")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_for_tables")]
        static abstract FaceTHandle FaceCreateForTables(
            ReferenceTableFuncT reference_table_func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_face_create_for_tables")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_for_tables")]
        static abstract FaceTHandle FaceCreateForTables(
            ReferenceTableFuncT reference_table_func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_face_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail")]
        static abstract FaceTHandle FaceCreateFromFileOrFail(sbyte* file_name, uint index);

        [NativeName("hb_face_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail")]
        static abstract FaceTHandle FaceCreateFromFileOrFail(Ref<sbyte> file_name, uint index);

        [NativeName("hb_face_create_from_file_or_fail_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail_using")]
        static abstract FaceTHandle FaceCreateFromFileOrFailUsing(
            sbyte* file_name,
            uint index,
            sbyte* loader_name
        );

        [NativeName("hb_face_create_from_file_or_fail_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail_using")]
        static abstract FaceTHandle FaceCreateFromFileOrFailUsing(
            Ref<sbyte> file_name,
            uint index,
            Ref<sbyte> loader_name
        );

        [NativeName("hb_face_create_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail")]
        static abstract FaceTHandle FaceCreateOrFail(BlobTHandle blob, uint index);

        [NativeName("hb_face_create_or_fail_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail_using")]
        static abstract FaceTHandle FaceCreateOrFailUsing(
            BlobTHandle blob,
            uint index,
            sbyte* loader_name
        );

        [NativeName("hb_face_create_or_fail_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail_using")]
        static abstract FaceTHandle FaceCreateOrFailUsing(
            BlobTHandle blob,
            uint index,
            Ref<sbyte> loader_name
        );

        [NativeName("hb_face_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_destroy")]
        static abstract void FaceDestroy(FaceTHandle face);

        [NativeName("hb_face_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_empty")]
        static abstract FaceTHandle FaceGetEmpty();

        [NativeName("hb_face_get_glyph_count")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_glyph_count")]
        static abstract uint FaceGetGlyphCount(FaceTHandle face);

        [NativeName("hb_face_get_index")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_index")]
        static abstract uint FaceGetIndex(FaceTHandle face);

        [NativeName("hb_face_get_table_tags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_table_tags")]
        static abstract uint FaceGetTableTags(
            FaceTHandle face,
            uint start_offset,
            uint* table_count,
            uint* table_tags
        );

        [NativeName("hb_face_get_table_tags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_table_tags")]
        static abstract uint FaceGetTableTags(
            FaceTHandle face,
            uint start_offset,
            Ref<uint> table_count,
            Ref<uint> table_tags
        );

        [NativeName("hb_face_get_upem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_upem")]
        static abstract uint FaceGetUpem(FaceTHandle face);

        [NativeName("hb_face_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_user_data")]
        static abstract void* FaceGetUserData(FaceTHandle face, UserDataKeyT* key);

        [NativeName("hb_face_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_user_data")]
        static abstract Ptr FaceGetUserData(FaceTHandle face, Ref<UserDataKeyT> key);

        [NativeName("hb_face_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_is_immutable")]
        static abstract int FaceIsImmutable(FaceTHandle face);

        [NativeName("hb_face_list_loaders")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_list_loaders")]
        static abstract Ptr2D<sbyte> FaceListLoaders();

        [NativeName("hb_face_list_loaders")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_list_loaders")]
        static abstract sbyte** FaceListLoadersRaw();

        [NativeName("hb_face_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_make_immutable")]
        static abstract void FaceMakeImmutable(FaceTHandle face);

        [NativeName("hb_face_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference")]
        static abstract FaceTHandle FaceReference(FaceTHandle face);

        [NativeName("hb_face_reference_blob")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference_blob")]
        static abstract BlobTHandle FaceReferenceBlob(FaceTHandle face);

        [NativeName("hb_face_reference_table")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference_table")]
        static abstract BlobTHandle FaceReferenceTable(FaceTHandle face, uint tag);

        [NativeName("hb_face_set_get_table_tags_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_get_table_tags_func")]
        static abstract void FaceSetGetTableTagsFunc(
            FaceTHandle face,
            GetTableTagsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_face_set_get_table_tags_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_get_table_tags_func")]
        static abstract void FaceSetGetTableTagsFunc(
            FaceTHandle face,
            GetTableTagsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_face_set_glyph_count")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_glyph_count")]
        static abstract void FaceSetGlyphCount(FaceTHandle face, uint glyph_count);

        [NativeName("hb_face_set_index")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_index")]
        static abstract void FaceSetIndex(FaceTHandle face, uint index);

        [NativeName("hb_face_set_upem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_upem")]
        static abstract void FaceSetUpem(FaceTHandle face, uint upem);

        [NativeName("hb_face_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_user_data")]
        static abstract int FaceSetUserData(
            FaceTHandle face,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_face_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_user_data")]
        static abstract int FaceSetUserData(
            FaceTHandle face,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_feature_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_feature_from_string")]
        static abstract int FeatureFromString(sbyte* str, int len, FeatureT* feature);

        [NativeName("hb_feature_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_feature_from_string")]
        static abstract int FeatureFromString(Ref<sbyte> str, int len, Ref<FeatureT> feature);

        [NativeName("hb_feature_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_feature_to_string")]
        static abstract void FeatureToString(FeatureT* feature, sbyte* buf, uint size);

        [NativeName("hb_feature_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_feature_to_string")]
        static abstract void FeatureToString(Ref<FeatureT> feature, Ref<sbyte> buf, uint size);

        [NativeName("hb_font_add_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        static abstract void FontAddGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_add_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        static abstract void FontAddGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_changed")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_changed")]
        static abstract void FontChanged(FontTHandle font);

        [NativeName("hb_font_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_create")]
        static abstract FontTHandle FontCreate(FaceTHandle face);

        [NativeName("hb_font_create_sub_font")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_create_sub_font")]
        static abstract FontTHandle FontCreateSubFont(FontTHandle parent);

        [NativeName("hb_font_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_destroy")]
        static abstract void FontDestroy(FontTHandle font);

        [NativeName("hb_font_draw_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph")]
        static abstract void FontDrawGlyph(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            void* draw_data
        );

        [NativeName("hb_font_draw_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph")]
        static abstract void FontDrawGlyph(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            Ref draw_data
        );

        [NativeName("hb_font_draw_glyph_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph_or_fail")]
        static abstract int FontDrawGlyphOrFail(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            void* draw_data
        );

        [NativeName("hb_font_draw_glyph_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph_or_fail")]
        static abstract int FontDrawGlyphOrFail(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            Ref draw_data
        );

        [NativeName("hb_font_funcs_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_create")]
        static abstract FontFuncsTHandle FontFuncsCreate();

        [NativeName("hb_font_funcs_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_destroy")]
        static abstract void FontFuncsDestroy(FontFuncsTHandle ffuncs);

        [NativeName("hb_font_funcs_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_empty")]
        static abstract FontFuncsTHandle FontFuncsGetEmpty();

        [NativeName("hb_font_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_user_data")]
        static abstract void* FontFuncsGetUserData(FontFuncsTHandle ffuncs, UserDataKeyT* key);

        [NativeName("hb_font_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_user_data")]
        static abstract Ptr FontFuncsGetUserData(FontFuncsTHandle ffuncs, Ref<UserDataKeyT> key);

        [NativeName("hb_font_funcs_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_is_immutable")]
        static abstract int FontFuncsIsImmutable(FontFuncsTHandle ffuncs);

        [NativeName("hb_font_funcs_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_make_immutable")]
        static abstract void FontFuncsMakeImmutable(FontFuncsTHandle ffuncs);

        [NativeName("hb_font_funcs_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_reference")]
        static abstract FontFuncsTHandle FontFuncsReference(FontFuncsTHandle ffuncs);

        [NativeName("hb_font_funcs_set_draw_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
        static abstract void FontFuncsSetDrawGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontDrawGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_draw_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
        static abstract void FontFuncsSetDrawGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontDrawGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_draw_glyph_or_fail_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
        static abstract void FontFuncsSetDrawGlyphOrFailFunc(
            FontFuncsTHandle ffuncs,
            FontDrawGlyphOrFailFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_draw_glyph_or_fail_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
        static abstract void FontFuncsSetDrawGlyphOrFailFunc(
            FontFuncsTHandle ffuncs,
            FontDrawGlyphOrFailFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_font_h_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
        static abstract void FontFuncsSetFontHExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetFontHExtentsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_font_h_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
        static abstract void FontFuncsSetFontHExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetFontHExtentsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_font_v_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
        static abstract void FontFuncsSetFontVExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetFontVExtentsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_font_v_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
        static abstract void FontFuncsSetFontVExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetFontVExtentsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_contour_point_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
        static abstract void FontFuncsSetGlyphContourPointFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphContourPointFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_contour_point_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
        static abstract void FontFuncsSetGlyphContourPointFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphContourPointFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
        static abstract void FontFuncsSetGlyphExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphExtentsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_extents_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
        static abstract void FontFuncsSetGlyphExtentsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphExtentsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_from_name_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
        static abstract void FontFuncsSetGlyphFromNameFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphFromNameFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_from_name_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
        static abstract void FontFuncsSetGlyphFromNameFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphFromNameFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_func")]
        static abstract void FontFuncsSetGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_func")]
        static abstract void FontFuncsSetGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_advance_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
        static abstract void FontFuncsSetGlyphHAdvanceFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHAdvanceFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_advance_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
        static abstract void FontFuncsSetGlyphHAdvanceFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHAdvanceFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_advances_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
        static abstract void FontFuncsSetGlyphHAdvancesFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHAdvancesFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_advances_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
        static abstract void FontFuncsSetGlyphHAdvancesFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHAdvancesFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_kerning_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
        static abstract void FontFuncsSetGlyphHKerningFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHKerningFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_kerning_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
        static abstract void FontFuncsSetGlyphHKerningFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHKerningFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_origin_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
        static abstract void FontFuncsSetGlyphHOriginFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHOriginFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_origin_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
        static abstract void FontFuncsSetGlyphHOriginFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHOriginFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_origins_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
        static abstract void FontFuncsSetGlyphHOriginsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHOriginsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_h_origins_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
        static abstract void FontFuncsSetGlyphHOriginsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphHOriginsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_name_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_name_func")]
        static abstract void FontFuncsSetGlyphNameFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphNameFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_name_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_name_func")]
        static abstract void FontFuncsSetGlyphNameFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphNameFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_shape_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
        static abstract void FontFuncsSetGlyphShapeFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphShapeFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_shape_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
        static abstract void FontFuncsSetGlyphShapeFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphShapeFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_advance_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
        static abstract void FontFuncsSetGlyphVAdvanceFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVAdvanceFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_advance_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
        static abstract void FontFuncsSetGlyphVAdvanceFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVAdvanceFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_advances_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
        static abstract void FontFuncsSetGlyphVAdvancesFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVAdvancesFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_advances_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
        static abstract void FontFuncsSetGlyphVAdvancesFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVAdvancesFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_kerning_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
        static abstract void FontFuncsSetGlyphVKerningFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVKerningFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_kerning_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
        static abstract void FontFuncsSetGlyphVKerningFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVKerningFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_origin_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
        static abstract void FontFuncsSetGlyphVOriginFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVOriginFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_origin_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
        static abstract void FontFuncsSetGlyphVOriginFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVOriginFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_origins_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
        static abstract void FontFuncsSetGlyphVOriginsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVOriginsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_glyph_v_origins_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
        static abstract void FontFuncsSetGlyphVOriginsFunc(
            FontFuncsTHandle ffuncs,
            FontGetGlyphVOriginsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_nominal_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
        static abstract void FontFuncsSetNominalGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetNominalGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_nominal_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
        static abstract void FontFuncsSetNominalGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetNominalGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_nominal_glyphs_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
        static abstract void FontFuncsSetNominalGlyphsFunc(
            FontFuncsTHandle ffuncs,
            FontGetNominalGlyphsFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_nominal_glyphs_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
        static abstract void FontFuncsSetNominalGlyphsFunc(
            FontFuncsTHandle ffuncs,
            FontGetNominalGlyphsFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_paint_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
        static abstract void FontFuncsSetPaintGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontPaintGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_paint_glyph_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
        static abstract void FontFuncsSetPaintGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontPaintGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_paint_glyph_or_fail_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
        static abstract void FontFuncsSetPaintGlyphOrFailFunc(
            FontFuncsTHandle ffuncs,
            FontPaintGlyphOrFailFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_paint_glyph_or_fail_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
        static abstract void FontFuncsSetPaintGlyphOrFailFunc(
            FontFuncsTHandle ffuncs,
            FontPaintGlyphOrFailFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_user_data")]
        static abstract int FontFuncsSetUserData(
            FontFuncsTHandle ffuncs,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_font_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_user_data")]
        static abstract int FontFuncsSetUserData(
            FontFuncsTHandle ffuncs,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_font_funcs_set_variation_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
        static abstract void FontFuncsSetVariationGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetVariationGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_funcs_set_variation_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
        static abstract void FontFuncsSetVariationGlyphFunc(
            FontFuncsTHandle ffuncs,
            FontGetVariationGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_empty")]
        static abstract FontTHandle FontGetEmpty();

        [NativeName("hb_font_get_extents_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_extents_for_direction")]
        static abstract void FontGetExtentsForDirection(
            FontTHandle font,
            DirectionT direction,
            FontExtentsT* extents
        );

        [NativeName("hb_font_get_extents_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_extents_for_direction")]
        static abstract void FontGetExtentsForDirection(
            FontTHandle font,
            DirectionT direction,
            Ref<FontExtentsT> extents
        );

        [NativeName("hb_font_get_face")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_face")]
        static abstract FaceTHandle FontGetFace(FontTHandle font);

        [NativeName("hb_font_get_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph")]
        static abstract int FontGetGlyph(
            FontTHandle font,
            uint unicode,
            uint variation_selector,
            uint* glyph
        );

        [NativeName("hb_font_get_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph")]
        static abstract int FontGetGlyph(
            FontTHandle font,
            uint unicode,
            uint variation_selector,
            Ref<uint> glyph
        );

        [NativeName("hb_font_get_glyph_advance_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        static abstract void FontGetGlyphAdvanceForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_get_glyph_advance_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        static abstract void FontGetGlyphAdvanceForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_advances_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        static abstract void FontGetGlyphAdvancesForDirection(
            FontTHandle font,
            DirectionT direction,
            uint count,
            uint* first_glyph,
            uint glyph_stride,
            int* first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_advances_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        static abstract void FontGetGlyphAdvancesForDirection(
            FontTHandle font,
            DirectionT direction,
            uint count,
            Ref<uint> first_glyph,
            uint glyph_stride,
            Ref<int> first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_contour_point")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point")]
        static abstract int FontGetGlyphContourPoint(
            FontTHandle font,
            uint glyph,
            uint point_index,
            int* x,
            int* y
        );

        [NativeName("hb_font_get_glyph_contour_point")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point")]
        static abstract int FontGetGlyphContourPoint(
            FontTHandle font,
            uint glyph,
            uint point_index,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_contour_point_for_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        static abstract int FontGetGlyphContourPointForOrigin(
            FontTHandle font,
            uint glyph,
            uint point_index,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_get_glyph_contour_point_for_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        static abstract int FontGetGlyphContourPointForOrigin(
            FontTHandle font,
            uint glyph,
            uint point_index,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents")]
        static abstract int FontGetGlyphExtents(
            FontTHandle font,
            uint glyph,
            GlyphExtentsT* extents
        );

        [NativeName("hb_font_get_glyph_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents")]
        static abstract int FontGetGlyphExtents(
            FontTHandle font,
            uint glyph,
            Ref<GlyphExtentsT> extents
        );

        [NativeName("hb_font_get_glyph_extents_for_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents_for_origin")]
        static abstract int FontGetGlyphExtentsForOrigin(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            GlyphExtentsT* extents
        );

        [NativeName("hb_font_get_glyph_extents_for_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents_for_origin")]
        static abstract int FontGetGlyphExtentsForOrigin(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            Ref<GlyphExtentsT> extents
        );

        [NativeName("hb_font_get_glyph_from_name")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_from_name")]
        static abstract int FontGetGlyphFromName(
            FontTHandle font,
            sbyte* name,
            int len,
            uint* glyph
        );

        [NativeName("hb_font_get_glyph_from_name")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_from_name")]
        static abstract int FontGetGlyphFromName(
            FontTHandle font,
            Ref<sbyte> name,
            int len,
            Ref<uint> glyph
        );

        [NativeName("hb_font_get_glyph_h_advance")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advance")]
        static abstract int FontGetGlyphHAdvance(FontTHandle font, uint glyph);

        [NativeName("hb_font_get_glyph_h_advances")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advances")]
        static abstract void FontGetGlyphHAdvances(
            FontTHandle font,
            uint count,
            uint* first_glyph,
            uint glyph_stride,
            int* first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_h_advances")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advances")]
        static abstract void FontGetGlyphHAdvances(
            FontTHandle font,
            uint count,
            Ref<uint> first_glyph,
            uint glyph_stride,
            Ref<int> first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_h_kerning")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_kerning")]
        static abstract int FontGetGlyphHKerning(
            FontTHandle font,
            uint left_glyph,
            uint right_glyph
        );

        [NativeName("hb_font_get_glyph_h_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origin")]
        static abstract int FontGetGlyphHOrigin(FontTHandle font, uint glyph, int* x, int* y);

        [NativeName("hb_font_get_glyph_h_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origin")]
        static abstract int FontGetGlyphHOrigin(
            FontTHandle font,
            uint glyph,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_h_origins")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origins")]
        static abstract int FontGetGlyphHOrigins(
            FontTHandle font,
            uint count,
            uint* first_glyph,
            uint glyph_stride,
            int* first_x,
            uint x_stride,
            int* first_y,
            uint y_stride
        );

        [NativeName("hb_font_get_glyph_h_origins")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origins")]
        static abstract int FontGetGlyphHOrigins(
            FontTHandle font,
            uint count,
            Ref<uint> first_glyph,
            uint glyph_stride,
            Ref<int> first_x,
            uint x_stride,
            Ref<int> first_y,
            uint y_stride
        );

        [NativeName("hb_font_get_glyph_kerning_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        static abstract void FontGetGlyphKerningForDirection(
            FontTHandle font,
            uint first_glyph,
            uint second_glyph,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_get_glyph_kerning_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        static abstract void FontGetGlyphKerningForDirection(
            FontTHandle font,
            uint first_glyph,
            uint second_glyph,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_name")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_name")]
        static abstract int FontGetGlyphName(FontTHandle font, uint glyph, sbyte* name, uint size);

        [NativeName("hb_font_get_glyph_name")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_name")]
        static abstract int FontGetGlyphName(
            FontTHandle font,
            uint glyph,
            Ref<sbyte> name,
            uint size
        );

        [NativeName("hb_font_get_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        static abstract void FontGetGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_get_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        static abstract void FontGetGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_shape")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_shape")]
        static abstract void FontGetGlyphShape(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            void* draw_data
        );

        [NativeName("hb_font_get_glyph_shape")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_shape")]
        static abstract void FontGetGlyphShape(
            FontTHandle font,
            uint glyph,
            DrawFuncsTHandle dfuncs,
            Ref draw_data
        );

        [NativeName("hb_font_get_glyph_v_advance")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advance")]
        static abstract int FontGetGlyphVAdvance(FontTHandle font, uint glyph);

        [NativeName("hb_font_get_glyph_v_advances")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advances")]
        static abstract void FontGetGlyphVAdvances(
            FontTHandle font,
            uint count,
            uint* first_glyph,
            uint glyph_stride,
            int* first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_v_advances")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advances")]
        static abstract void FontGetGlyphVAdvances(
            FontTHandle font,
            uint count,
            Ref<uint> first_glyph,
            uint glyph_stride,
            Ref<int> first_advance,
            uint advance_stride
        );

        [NativeName("hb_font_get_glyph_v_kerning")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_kerning")]
        static abstract int FontGetGlyphVKerning(
            FontTHandle font,
            uint top_glyph,
            uint bottom_glyph
        );

        [NativeName("hb_font_get_glyph_v_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origin")]
        static abstract int FontGetGlyphVOrigin(FontTHandle font, uint glyph, int* x, int* y);

        [NativeName("hb_font_get_glyph_v_origin")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origin")]
        static abstract int FontGetGlyphVOrigin(
            FontTHandle font,
            uint glyph,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_font_get_glyph_v_origins")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origins")]
        static abstract int FontGetGlyphVOrigins(
            FontTHandle font,
            uint count,
            uint* first_glyph,
            uint glyph_stride,
            int* first_x,
            uint x_stride,
            int* first_y,
            uint y_stride
        );

        [NativeName("hb_font_get_glyph_v_origins")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origins")]
        static abstract int FontGetGlyphVOrigins(
            FontTHandle font,
            uint count,
            Ref<uint> first_glyph,
            uint glyph_stride,
            Ref<int> first_x,
            uint x_stride,
            Ref<int> first_y,
            uint y_stride
        );

        [NativeName("hb_font_get_h_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_h_extents")]
        static abstract int FontGetHExtents(FontTHandle font, FontExtentsT* extents);

        [NativeName("hb_font_get_h_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_h_extents")]
        static abstract int FontGetHExtents(FontTHandle font, Ref<FontExtentsT> extents);

        [NativeName("hb_font_get_nominal_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyph")]
        static abstract int FontGetNominalGlyph(FontTHandle font, uint unicode, uint* glyph);

        [NativeName("hb_font_get_nominal_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyph")]
        static abstract int FontGetNominalGlyph(FontTHandle font, uint unicode, Ref<uint> glyph);

        [NativeName("hb_font_get_nominal_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyphs")]
        static abstract uint FontGetNominalGlyphs(
            FontTHandle font,
            uint count,
            uint* first_unicode,
            uint unicode_stride,
            uint* first_glyph,
            uint glyph_stride
        );

        [NativeName("hb_font_get_nominal_glyphs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyphs")]
        static abstract uint FontGetNominalGlyphs(
            FontTHandle font,
            uint count,
            Ref<uint> first_unicode,
            uint unicode_stride,
            Ref<uint> first_glyph,
            uint glyph_stride
        );

        [NativeName("hb_font_get_parent")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_parent")]
        static abstract FontTHandle FontGetParent(FontTHandle font);

        [NativeName("hb_font_get_ppem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ppem")]
        static abstract void FontGetPpem(FontTHandle font, uint* x_ppem, uint* y_ppem);

        [NativeName("hb_font_get_ppem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ppem")]
        static abstract void FontGetPpem(FontTHandle font, Ref<uint> x_ppem, Ref<uint> y_ppem);

        [NativeName("hb_font_get_ptem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ptem")]
        static abstract float FontGetPtem(FontTHandle font);

        [NativeName("hb_font_get_scale")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_scale")]
        static abstract void FontGetScale(FontTHandle font, int* x_scale, int* y_scale);

        [NativeName("hb_font_get_scale")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_scale")]
        static abstract void FontGetScale(FontTHandle font, Ref<int> x_scale, Ref<int> y_scale);

        [NativeName("hb_font_get_serial")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_serial")]
        static abstract uint FontGetSerial(FontTHandle font);

        [NativeName("hb_font_get_synthetic_bold")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_bold")]
        static abstract void FontGetSyntheticBold(
            FontTHandle font,
            float* x_embolden,
            float* y_embolden,
            int* in_place
        );

        [NativeName("hb_font_get_synthetic_bold")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_bold")]
        static abstract void FontGetSyntheticBold(
            FontTHandle font,
            Ref<float> x_embolden,
            Ref<float> y_embolden,
            Ref<int> in_place
        );

        [NativeName("hb_font_get_synthetic_slant")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_slant")]
        static abstract float FontGetSyntheticSlant(FontTHandle font);

        [NativeName("hb_font_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_user_data")]
        static abstract void* FontGetUserData(FontTHandle font, UserDataKeyT* key);

        [NativeName("hb_font_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_user_data")]
        static abstract Ptr FontGetUserData(FontTHandle font, Ref<UserDataKeyT> key);

        [NativeName("hb_font_get_v_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_v_extents")]
        static abstract int FontGetVExtents(FontTHandle font, FontExtentsT* extents);

        [NativeName("hb_font_get_v_extents")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_v_extents")]
        static abstract int FontGetVExtents(FontTHandle font, Ref<FontExtentsT> extents);

        [NativeName("hb_font_get_var_coords_design")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_design")]
        static abstract float* FontGetVarCoordsDesign(FontTHandle font, uint* length);

        [NativeName("hb_font_get_var_coords_design")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_design")]
        static abstract Ptr<float> FontGetVarCoordsDesign(FontTHandle font, Ref<uint> length);

        [NativeName("hb_font_get_var_coords_normalized")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_normalized")]
        static abstract int* FontGetVarCoordsNormalized(FontTHandle font, uint* length);

        [NativeName("hb_font_get_var_coords_normalized")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_normalized")]
        static abstract Ptr<int> FontGetVarCoordsNormalized(FontTHandle font, Ref<uint> length);

        [NativeName("hb_font_get_var_named_instance")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_named_instance")]
        static abstract uint FontGetVarNamedInstance(FontTHandle font);

        [NativeName("hb_font_get_variation_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_variation_glyph")]
        static abstract int FontGetVariationGlyph(
            FontTHandle font,
            uint unicode,
            uint variation_selector,
            uint* glyph
        );

        [NativeName("hb_font_get_variation_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_variation_glyph")]
        static abstract int FontGetVariationGlyph(
            FontTHandle font,
            uint unicode,
            uint variation_selector,
            Ref<uint> glyph
        );

        [NativeName("hb_font_glyph_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_from_string")]
        static abstract int FontGlyphFromString(FontTHandle font, sbyte* s, int len, uint* glyph);

        [NativeName("hb_font_glyph_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_from_string")]
        static abstract int FontGlyphFromString(
            FontTHandle font,
            Ref<sbyte> s,
            int len,
            Ref<uint> glyph
        );

        [NativeName("hb_font_glyph_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_to_string")]
        static abstract void FontGlyphToString(FontTHandle font, uint glyph, sbyte* s, uint size);

        [NativeName("hb_font_glyph_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_to_string")]
        static abstract void FontGlyphToString(
            FontTHandle font,
            uint glyph,
            Ref<sbyte> s,
            uint size
        );

        [NativeName("hb_font_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_is_immutable")]
        static abstract int FontIsImmutable(FontTHandle font);

        [NativeName("hb_font_is_synthetic")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_is_synthetic")]
        static abstract int FontIsSynthetic(FontTHandle font);

        [NativeName("hb_font_list_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_list_funcs")]
        static abstract Ptr2D<sbyte> FontListFuncs();

        [NativeName("hb_font_list_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_list_funcs")]
        static abstract sbyte** FontListFuncsRaw();

        [NativeName("hb_font_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_make_immutable")]
        static abstract void FontMakeImmutable(FontTHandle font);

        [NativeName("hb_font_paint_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph")]
        static abstract void FontPaintGlyph(
            FontTHandle font,
            uint glyph,
            PaintFuncsTHandle pfuncs,
            void* paint_data,
            uint palette_index,
            uint foreground
        );

        [NativeName("hb_font_paint_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph")]
        static abstract void FontPaintGlyph(
            FontTHandle font,
            uint glyph,
            PaintFuncsTHandle pfuncs,
            Ref paint_data,
            uint palette_index,
            uint foreground
        );

        [NativeName("hb_font_paint_glyph_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph_or_fail")]
        static abstract int FontPaintGlyphOrFail(
            FontTHandle font,
            uint glyph,
            PaintFuncsTHandle pfuncs,
            void* paint_data,
            uint palette_index,
            uint foreground
        );

        [NativeName("hb_font_paint_glyph_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph_or_fail")]
        static abstract int FontPaintGlyphOrFail(
            FontTHandle font,
            uint glyph,
            PaintFuncsTHandle pfuncs,
            Ref paint_data,
            uint palette_index,
            uint foreground
        );

        [NativeName("hb_font_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_reference")]
        static abstract FontTHandle FontReference(FontTHandle font);

        [NativeName("hb_font_set_face")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_face")]
        static abstract void FontSetFace(FontTHandle font, FaceTHandle face);

        [NativeName("hb_font_set_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs")]
        static abstract void FontSetFuncs(
            FontTHandle font,
            FontFuncsTHandle klass,
            void* font_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_set_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs")]
        static abstract void FontSetFuncs(
            FontTHandle font,
            FontFuncsTHandle klass,
            Ref font_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_set_funcs_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_data")]
        static abstract void FontSetFuncsData(
            FontTHandle font,
            void* font_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_set_funcs_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_data")]
        static abstract void FontSetFuncsData(
            FontTHandle font,
            Ref font_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_font_set_funcs_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_using")]
        static abstract int FontSetFuncsUsing(FontTHandle font, sbyte* name);

        [NativeName("hb_font_set_funcs_using")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_using")]
        static abstract int FontSetFuncsUsing(FontTHandle font, Ref<sbyte> name);

        [NativeName("hb_font_set_parent")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_parent")]
        static abstract void FontSetParent(FontTHandle font, FontTHandle parent);

        [NativeName("hb_font_set_ppem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_ppem")]
        static abstract void FontSetPpem(FontTHandle font, uint x_ppem, uint y_ppem);

        [NativeName("hb_font_set_ptem")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_ptem")]
        static abstract void FontSetPtem(FontTHandle font, float ptem);

        [NativeName("hb_font_set_scale")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_scale")]
        static abstract void FontSetScale(FontTHandle font, int x_scale, int y_scale);

        [NativeName("hb_font_set_synthetic_bold")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_synthetic_bold")]
        static abstract void FontSetSyntheticBold(
            FontTHandle font,
            float x_embolden,
            float y_embolden,
            int in_place
        );

        [NativeName("hb_font_set_synthetic_slant")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_synthetic_slant")]
        static abstract void FontSetSyntheticSlant(FontTHandle font, float slant);

        [NativeName("hb_font_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_user_data")]
        static abstract int FontSetUserData(
            FontTHandle font,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_font_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_user_data")]
        static abstract int FontSetUserData(
            FontTHandle font,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_font_set_var_coords_design")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_design")]
        static abstract void FontSetVarCoordsDesign(
            FontTHandle font,
            float* coords,
            uint coords_length
        );

        [NativeName("hb_font_set_var_coords_design")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_design")]
        static abstract void FontSetVarCoordsDesign(
            FontTHandle font,
            Ref<float> coords,
            uint coords_length
        );

        [NativeName("hb_font_set_var_coords_normalized")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_normalized")]
        static abstract void FontSetVarCoordsNormalized(
            FontTHandle font,
            int* coords,
            uint coords_length
        );

        [NativeName("hb_font_set_var_coords_normalized")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_normalized")]
        static abstract void FontSetVarCoordsNormalized(
            FontTHandle font,
            Ref<int> coords,
            uint coords_length
        );

        [NativeName("hb_font_set_var_named_instance")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_named_instance")]
        static abstract void FontSetVarNamedInstance(FontTHandle font, uint instance_index);

        [NativeName("hb_font_set_variation")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variation")]
        static abstract void FontSetVariation(FontTHandle font, uint tag, float value);

        [NativeName("hb_font_set_variations")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variations")]
        static abstract void FontSetVariations(
            FontTHandle font,
            VariationT* variations,
            uint variations_length
        );

        [NativeName("hb_font_set_variations")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variations")]
        static abstract void FontSetVariations(
            FontTHandle font,
            Ref<VariationT> variations,
            uint variations_length
        );

        [NativeName("hb_font_subtract_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        static abstract void FontSubtractGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            int* x,
            int* y
        );

        [NativeName("hb_font_subtract_glyph_origin_for_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        static abstract void FontSubtractGlyphOriginForDirection(
            FontTHandle font,
            uint glyph,
            DirectionT direction,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("hb_free")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_free")]
        static abstract void Free(void* ptr);

        [NativeName("hb_free")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_free")]
        static abstract void Free(Ref ptr);

        [NativeName("hb_ft_face_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create")]
        static abstract FaceTHandle FtFaceCreate(FTFaceRecHandle ft_face, DestroyFuncT destroy);

        [NativeName("hb_ft_face_create_cached")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_cached")]
        static abstract FaceTHandle FtFaceCreateCached(FTFaceRecHandle ft_face);

        [NativeName("hb_ft_face_create_from_blob_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_blob_or_fail")]
        static abstract FaceTHandle FtFaceCreateFromBlobOrFail(BlobTHandle blob, uint index);

        [NativeName("hb_ft_face_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_file_or_fail")]
        static abstract FaceTHandle FtFaceCreateFromFileOrFail(sbyte* file_name, uint index);

        [NativeName("hb_ft_face_create_from_file_or_fail")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_file_or_fail")]
        static abstract FaceTHandle FtFaceCreateFromFileOrFail(Ref<sbyte> file_name, uint index);

        [NativeName("hb_ft_face_create_referenced")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_referenced")]
        static abstract FaceTHandle FtFaceCreateReferenced(FTFaceRecHandle ft_face);

        [NativeName("hb_ft_font_changed")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_changed")]
        static abstract void FtFontChanged(FontTHandle font);

        [NativeName("hb_ft_font_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_create")]
        static abstract FontTHandle FtFontCreate(FTFaceRecHandle ft_face, DestroyFuncT destroy);

        [NativeName("hb_ft_font_create_referenced")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_create_referenced")]
        static abstract FontTHandle FtFontCreateReferenced(FTFaceRecHandle ft_face);

        [NativeName("hb_ft_font_get_face")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_face")]
        static abstract FTFaceRecHandle FtFontGetFace(FontTHandle font);

        [NativeName("hb_ft_font_get_ft_face")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_ft_face")]
        static abstract FTFaceRecHandle FtFontGetFtFace(FontTHandle font);

        [NativeName("hb_ft_font_get_load_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_load_flags")]
        static abstract int FtFontGetLoadFlags(FontTHandle font);

        [NativeName("hb_ft_font_lock_face")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_lock_face")]
        static abstract FTFaceRecHandle FtFontLockFace(FontTHandle font);

        [NativeName("hb_ft_font_set_funcs")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_set_funcs")]
        static abstract void FtFontSetFuncs(FontTHandle font);

        [NativeName("hb_ft_font_set_load_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_set_load_flags")]
        static abstract void FtFontSetLoadFlags(FontTHandle font, int load_flags);

        [NativeName("hb_ft_font_unlock_face")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_unlock_face")]
        static abstract void FtFontUnlockFace(FontTHandle font);

        [NativeName("hb_ft_hb_font_changed")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_ft_hb_font_changed")]
        static abstract int FtHbFontChanged(FontTHandle font);

        [NativeName("hb_glyph_info_get_glyph_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_glyph_info_get_glyph_flags")]
        static abstract GlyphFlagsT GlyphInfoGetGlyphFlags(GlyphInfoT* info);

        [NativeName("hb_glyph_info_get_glyph_flags")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_glyph_info_get_glyph_flags")]
        static abstract GlyphFlagsT GlyphInfoGetGlyphFlags(Ref<GlyphInfoT> info);

        [NativeName("hb_language_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_from_string")]
        static abstract LanguageImplTHandle LanguageFromString(sbyte* str, int len);

        [NativeName("hb_language_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_from_string")]
        static abstract LanguageImplTHandle LanguageFromString(Ref<sbyte> str, int len);

        [NativeName("hb_language_get_default")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_get_default")]
        static abstract LanguageImplTHandle LanguageGetDefault();

        [NativeName("hb_language_matches")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_matches")]
        static abstract int LanguageMatches(
            LanguageImplTHandle language,
            LanguageImplTHandle specific
        );

        [NativeName("hb_language_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_to_string")]
        static abstract Ptr<sbyte> LanguageToString(LanguageImplTHandle language);

        [NativeName("hb_language_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_language_to_string")]
        static abstract sbyte* LanguageToStringRaw(LanguageImplTHandle language);

        [NativeName("hb_malloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_malloc")]
        static abstract Ptr Malloc(nuint size);

        [NativeName("hb_malloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_malloc")]
        static abstract void* MallocRaw(nuint size);

        [NativeName("hb_map_allocation_successful")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_allocation_successful")]
        static abstract int MapAllocationSuccessful(MapTHandle map);

        [NativeName("hb_map_clear")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_clear")]
        static abstract void MapClear(MapTHandle map);

        [NativeName("hb_map_copy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_copy")]
        static abstract MapTHandle MapCopy(MapTHandle map);

        [NativeName("hb_map_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_create")]
        static abstract MapTHandle MapCreate();

        [NativeName("hb_map_del")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_del")]
        static abstract void MapDel(MapTHandle map, uint key);

        [NativeName("hb_map_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_destroy")]
        static abstract void MapDestroy(MapTHandle map);

        [NativeName("hb_map_get")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_get")]
        static abstract uint MapGet(MapTHandle map, uint key);

        [NativeName("hb_map_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_empty")]
        static abstract MapTHandle MapGetEmpty();

        [NativeName("hb_map_get_population")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_population")]
        static abstract uint MapGetPopulation(MapTHandle map);

        [NativeName("hb_map_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_user_data")]
        static abstract void* MapGetUserData(MapTHandle map, UserDataKeyT* key);

        [NativeName("hb_map_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_user_data")]
        static abstract Ptr MapGetUserData(MapTHandle map, Ref<UserDataKeyT> key);

        [NativeName("hb_map_has")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_has")]
        static abstract int MapHas(MapTHandle map, uint key);

        [NativeName("hb_map_hash")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_hash")]
        static abstract uint MapHash(MapTHandle map);

        [NativeName("hb_map_is_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_is_empty")]
        static abstract int MapIsEmpty(MapTHandle map);

        [NativeName("hb_map_is_equal")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_is_equal")]
        static abstract int MapIsEqual(MapTHandle map, MapTHandle other);

        [NativeName("hb_map_keys")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_keys")]
        static abstract void MapKeys(MapTHandle map, SetTHandle keys);

        [NativeName("hb_map_next")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_next")]
        static abstract int MapNext(MapTHandle map, int* idx, uint* key, uint* value);

        [NativeName("hb_map_next")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_next")]
        static abstract int MapNext(MapTHandle map, Ref<int> idx, Ref<uint> key, Ref<uint> value);

        [NativeName("hb_map_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_reference")]
        static abstract MapTHandle MapReference(MapTHandle map);

        [NativeName("hb_map_set")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_set")]
        static abstract void MapSet(MapTHandle map, uint key, uint value);

        [NativeName("hb_map_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_set_user_data")]
        static abstract int MapSetUserData(
            MapTHandle map,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_map_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_set_user_data")]
        static abstract int MapSetUserData(
            MapTHandle map,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_map_update")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_update")]
        static abstract void MapUpdate(MapTHandle map, MapTHandle other);

        [NativeName("hb_map_values")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_map_values")]
        static abstract void MapValues(MapTHandle map, SetTHandle values);

        [NativeName("hb_paint_color")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color")]
        static abstract void PaintColor(
            PaintFuncsTHandle funcs,
            void* paint_data,
            int is_foreground,
            uint color
        );

        [NativeName("hb_paint_color")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color")]
        static abstract void PaintColor(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            int is_foreground,
            uint color
        );

        [NativeName("hb_paint_color_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color_glyph")]
        static abstract int PaintColorGlyph(
            PaintFuncsTHandle funcs,
            void* paint_data,
            uint glyph,
            FontTHandle font
        );

        [NativeName("hb_paint_color_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color_glyph")]
        static abstract int PaintColorGlyph(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            uint glyph,
            FontTHandle font
        );

        [NativeName("hb_paint_custom_palette_color")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_custom_palette_color")]
        static abstract int PaintCustomPaletteColor(
            PaintFuncsTHandle funcs,
            void* paint_data,
            uint color_index,
            uint* color
        );

        [NativeName("hb_paint_custom_palette_color")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_custom_palette_color")]
        static abstract int PaintCustomPaletteColor(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            uint color_index,
            Ref<uint> color
        );

        [NativeName("hb_paint_funcs_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_create")]
        static abstract PaintFuncsTHandle PaintFuncsCreate();

        [NativeName("hb_paint_funcs_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_destroy")]
        static abstract void PaintFuncsDestroy(PaintFuncsTHandle funcs);

        [NativeName("hb_paint_funcs_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_empty")]
        static abstract PaintFuncsTHandle PaintFuncsGetEmpty();

        [NativeName("hb_paint_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_user_data")]
        static abstract void* PaintFuncsGetUserData(PaintFuncsTHandle funcs, UserDataKeyT* key);

        [NativeName("hb_paint_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_user_data")]
        static abstract Ptr PaintFuncsGetUserData(PaintFuncsTHandle funcs, Ref<UserDataKeyT> key);

        [NativeName("hb_paint_funcs_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_is_immutable")]
        static abstract int PaintFuncsIsImmutable(PaintFuncsTHandle funcs);

        [NativeName("hb_paint_funcs_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_make_immutable")]
        static abstract void PaintFuncsMakeImmutable(PaintFuncsTHandle funcs);

        [NativeName("hb_paint_funcs_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_reference")]
        static abstract PaintFuncsTHandle PaintFuncsReference(PaintFuncsTHandle funcs);

        [NativeName("hb_paint_funcs_set_color_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_func")]
        static abstract void PaintFuncsSetColorFunc(
            PaintFuncsTHandle funcs,
            PaintColorFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_color_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_func")]
        static abstract void PaintFuncsSetColorFunc(
            PaintFuncsTHandle funcs,
            PaintColorFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_color_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
        static abstract void PaintFuncsSetColorGlyphFunc(
            PaintFuncsTHandle funcs,
            PaintColorGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_color_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
        static abstract void PaintFuncsSetColorGlyphFunc(
            PaintFuncsTHandle funcs,
            PaintColorGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_custom_palette_color_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
        static abstract void PaintFuncsSetCustomPaletteColorFunc(
            PaintFuncsTHandle funcs,
            PaintCustomPaletteColorFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_custom_palette_color_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
        static abstract void PaintFuncsSetCustomPaletteColorFunc(
            PaintFuncsTHandle funcs,
            PaintCustomPaletteColorFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_image_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_image_func")]
        static abstract void PaintFuncsSetImageFunc(
            PaintFuncsTHandle funcs,
            PaintImageFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_image_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_image_func")]
        static abstract void PaintFuncsSetImageFunc(
            PaintFuncsTHandle funcs,
            PaintImageFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_linear_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
        static abstract void PaintFuncsSetLinearGradientFunc(
            PaintFuncsTHandle funcs,
            PaintLinearGradientFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_linear_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
        static abstract void PaintFuncsSetLinearGradientFunc(
            PaintFuncsTHandle funcs,
            PaintLinearGradientFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_clip_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
        static abstract void PaintFuncsSetPopClipFunc(
            PaintFuncsTHandle funcs,
            PaintPopClipFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_clip_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
        static abstract void PaintFuncsSetPopClipFunc(
            PaintFuncsTHandle funcs,
            PaintPopClipFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_group_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_group_func")]
        static abstract void PaintFuncsSetPopGroupFunc(
            PaintFuncsTHandle funcs,
            PaintPopGroupFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_group_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_group_func")]
        static abstract void PaintFuncsSetPopGroupFunc(
            PaintFuncsTHandle funcs,
            PaintPopGroupFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_transform_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
        static abstract void PaintFuncsSetPopTransformFunc(
            PaintFuncsTHandle funcs,
            PaintPopTransformFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_pop_transform_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
        static abstract void PaintFuncsSetPopTransformFunc(
            PaintFuncsTHandle funcs,
            PaintPopTransformFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_clip_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
        static abstract void PaintFuncsSetPushClipGlyphFunc(
            PaintFuncsTHandle funcs,
            PaintPushClipGlyphFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_clip_glyph_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
        static abstract void PaintFuncsSetPushClipGlyphFunc(
            PaintFuncsTHandle funcs,
            PaintPushClipGlyphFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_clip_rectangle_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
        static abstract void PaintFuncsSetPushClipRectangleFunc(
            PaintFuncsTHandle funcs,
            PaintPushClipRectangleFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_clip_rectangle_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
        static abstract void PaintFuncsSetPushClipRectangleFunc(
            PaintFuncsTHandle funcs,
            PaintPushClipRectangleFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_group_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_group_func")]
        static abstract void PaintFuncsSetPushGroupFunc(
            PaintFuncsTHandle funcs,
            PaintPushGroupFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_group_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_group_func")]
        static abstract void PaintFuncsSetPushGroupFunc(
            PaintFuncsTHandle funcs,
            PaintPushGroupFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_transform_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_transform_func")]
        static abstract void PaintFuncsSetPushTransformFunc(
            PaintFuncsTHandle funcs,
            PaintPushTransformFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_push_transform_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_transform_func")]
        static abstract void PaintFuncsSetPushTransformFunc(
            PaintFuncsTHandle funcs,
            PaintPushTransformFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_radial_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
        static abstract void PaintFuncsSetRadialGradientFunc(
            PaintFuncsTHandle funcs,
            PaintRadialGradientFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_radial_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
        static abstract void PaintFuncsSetRadialGradientFunc(
            PaintFuncsTHandle funcs,
            PaintRadialGradientFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_sweep_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
        static abstract void PaintFuncsSetSweepGradientFunc(
            PaintFuncsTHandle funcs,
            PaintSweepGradientFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_sweep_gradient_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
        static abstract void PaintFuncsSetSweepGradientFunc(
            PaintFuncsTHandle funcs,
            PaintSweepGradientFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_paint_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_user_data")]
        static abstract int PaintFuncsSetUserData(
            PaintFuncsTHandle funcs,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_paint_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_user_data")]
        static abstract int PaintFuncsSetUserData(
            PaintFuncsTHandle funcs,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_paint_image")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_image")]
        static abstract void PaintImage(
            PaintFuncsTHandle funcs,
            void* paint_data,
            BlobTHandle image,
            uint width,
            uint height,
            uint format,
            float slant,
            GlyphExtentsT* extents
        );

        [NativeName("hb_paint_image")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_image")]
        static abstract void PaintImage(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            BlobTHandle image,
            uint width,
            uint height,
            uint format,
            float slant,
            Ref<GlyphExtentsT> extents
        );

        [NativeName("hb_paint_linear_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_linear_gradient")]
        static abstract void PaintLinearGradient(
            PaintFuncsTHandle funcs,
            void* paint_data,
            ColorLineT* color_line,
            float x0,
            float y0,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [NativeName("hb_paint_linear_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_linear_gradient")]
        static abstract void PaintLinearGradient(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            Ref<ColorLineT> color_line,
            float x0,
            float y0,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [NativeName("hb_paint_pop_clip")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_clip")]
        static abstract void PaintPopClip(PaintFuncsTHandle funcs, void* paint_data);

        [NativeName("hb_paint_pop_clip")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_clip")]
        static abstract void PaintPopClip(PaintFuncsTHandle funcs, Ref paint_data);

        [NativeName("hb_paint_pop_group")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_group")]
        static abstract void PaintPopGroup(
            PaintFuncsTHandle funcs,
            void* paint_data,
            PaintCompositeModeT mode
        );

        [NativeName("hb_paint_pop_group")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_group")]
        static abstract void PaintPopGroup(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            PaintCompositeModeT mode
        );

        [NativeName("hb_paint_pop_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_transform")]
        static abstract void PaintPopTransform(PaintFuncsTHandle funcs, void* paint_data);

        [NativeName("hb_paint_pop_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_transform")]
        static abstract void PaintPopTransform(PaintFuncsTHandle funcs, Ref paint_data);

        [NativeName("hb_paint_push_clip_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_glyph")]
        static abstract void PaintPushClipGlyph(
            PaintFuncsTHandle funcs,
            void* paint_data,
            uint glyph,
            FontTHandle font
        );

        [NativeName("hb_paint_push_clip_glyph")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_glyph")]
        static abstract void PaintPushClipGlyph(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            uint glyph,
            FontTHandle font
        );

        [NativeName("hb_paint_push_clip_rectangle")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_rectangle")]
        static abstract void PaintPushClipRectangle(
            PaintFuncsTHandle funcs,
            void* paint_data,
            float xmin,
            float ymin,
            float xmax,
            float ymax
        );

        [NativeName("hb_paint_push_clip_rectangle")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_rectangle")]
        static abstract void PaintPushClipRectangle(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            float xmin,
            float ymin,
            float xmax,
            float ymax
        );

        [NativeName("hb_paint_push_font_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_font_transform")]
        static abstract void PaintPushFontTransform(
            PaintFuncsTHandle funcs,
            void* paint_data,
            FontTHandle font
        );

        [NativeName("hb_paint_push_font_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_font_transform")]
        static abstract void PaintPushFontTransform(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            FontTHandle font
        );

        [NativeName("hb_paint_push_group")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_group")]
        static abstract void PaintPushGroup(PaintFuncsTHandle funcs, void* paint_data);

        [NativeName("hb_paint_push_group")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_group")]
        static abstract void PaintPushGroup(PaintFuncsTHandle funcs, Ref paint_data);

        [NativeName("hb_paint_push_inverse_font_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_inverse_font_transform")]
        static abstract void PaintPushInverseFontTransform(
            PaintFuncsTHandle funcs,
            void* paint_data,
            FontTHandle font
        );

        [NativeName("hb_paint_push_inverse_font_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_inverse_font_transform")]
        static abstract void PaintPushInverseFontTransform(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            FontTHandle font
        );

        [NativeName("hb_paint_push_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_transform")]
        static abstract void PaintPushTransform(
            PaintFuncsTHandle funcs,
            void* paint_data,
            float xx,
            float yx,
            float xy,
            float yy,
            float dx,
            float dy
        );

        [NativeName("hb_paint_push_transform")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_transform")]
        static abstract void PaintPushTransform(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            float xx,
            float yx,
            float xy,
            float yy,
            float dx,
            float dy
        );

        [NativeName("hb_paint_radial_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_radial_gradient")]
        static abstract void PaintRadialGradient(
            PaintFuncsTHandle funcs,
            void* paint_data,
            ColorLineT* color_line,
            float x0,
            float y0,
            float r0,
            float x1,
            float y1,
            float r1
        );

        [NativeName("hb_paint_radial_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_radial_gradient")]
        static abstract void PaintRadialGradient(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            Ref<ColorLineT> color_line,
            float x0,
            float y0,
            float r0,
            float x1,
            float y1,
            float r1
        );

        [NativeName("hb_paint_sweep_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_sweep_gradient")]
        static abstract void PaintSweepGradient(
            PaintFuncsTHandle funcs,
            void* paint_data,
            ColorLineT* color_line,
            float x0,
            float y0,
            float start_angle,
            float end_angle
        );

        [NativeName("hb_paint_sweep_gradient")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_paint_sweep_gradient")]
        static abstract void PaintSweepGradient(
            PaintFuncsTHandle funcs,
            Ref paint_data,
            Ref<ColorLineT> color_line,
            float x0,
            float y0,
            float start_angle,
            float end_angle
        );

        [NativeName("hb_realloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_realloc")]
        static abstract void* Realloc(void* ptr, nuint size);

        [NativeName("hb_realloc")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_realloc")]
        static abstract Ptr Realloc(Ref ptr, nuint size);

        [NativeName("hb_script_from_iso15924_tag")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_iso15924_tag")]
        static abstract ScriptT ScriptFromIso15924Tag(uint tag);

        [NativeName("hb_script_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_string")]
        static abstract ScriptT ScriptFromString(sbyte* str, int len);

        [NativeName("hb_script_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_string")]
        static abstract ScriptT ScriptFromString(Ref<sbyte> str, int len);

        [NativeName("hb_script_get_horizontal_direction")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_script_get_horizontal_direction")]
        static abstract DirectionT ScriptGetHorizontalDirection(ScriptT script);

        [NativeName("hb_script_to_iso15924_tag")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_script_to_iso15924_tag")]
        static abstract uint ScriptToIso15924Tag(ScriptT script);

        [NativeName("hb_segment_properties_equal")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_equal")]
        static abstract int SegmentPropertiesEqual(SegmentPropertiesT* a, SegmentPropertiesT* b);

        [NativeName("hb_segment_properties_equal")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_equal")]
        static abstract int SegmentPropertiesEqual(
            Ref<SegmentPropertiesT> a,
            Ref<SegmentPropertiesT> b
        );

        [NativeName("hb_segment_properties_hash")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_hash")]
        static abstract uint SegmentPropertiesHash(SegmentPropertiesT* p);

        [NativeName("hb_segment_properties_hash")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_hash")]
        static abstract uint SegmentPropertiesHash(Ref<SegmentPropertiesT> p);

        [NativeName("hb_segment_properties_overlay")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_overlay")]
        static abstract void SegmentPropertiesOverlay(
            SegmentPropertiesT* p,
            SegmentPropertiesT* src
        );

        [NativeName("hb_segment_properties_overlay")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_overlay")]
        static abstract void SegmentPropertiesOverlay(
            Ref<SegmentPropertiesT> p,
            Ref<SegmentPropertiesT> src
        );

        [NativeName("hb_set_add")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_add")]
        static abstract void SetAdd(SetTHandle set, uint codepoint);

        [NativeName("hb_set_add_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_range")]
        static abstract void SetAddRange(SetTHandle set, uint first, uint last);

        [NativeName("hb_set_add_sorted_array")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_sorted_array")]
        static abstract void SetAddSortedArray(
            SetTHandle set,
            uint* sorted_codepoints,
            uint num_codepoints
        );

        [NativeName("hb_set_add_sorted_array")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_sorted_array")]
        static abstract void SetAddSortedArray(
            SetTHandle set,
            Ref<uint> sorted_codepoints,
            uint num_codepoints
        );

        [NativeName("hb_set_allocation_successful")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_allocation_successful")]
        static abstract int SetAllocationSuccessful(SetTHandle set);

        [NativeName("hb_set_clear")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_clear")]
        static abstract void SetClear(SetTHandle set);

        [NativeName("hb_set_copy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_copy")]
        static abstract SetTHandle SetCopy(SetTHandle set);

        [NativeName("hb_set_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_create")]
        static abstract SetTHandle SetCreate();

        [NativeName("hb_set_del")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_del")]
        static abstract void SetDel(SetTHandle set, uint codepoint);

        [NativeName("hb_set_del_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_del_range")]
        static abstract void SetDelRange(SetTHandle set, uint first, uint last);

        [NativeName("hb_set_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_destroy")]
        static abstract void SetDestroy(SetTHandle set);

        [NativeName("hb_set_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_empty")]
        static abstract SetTHandle SetGetEmpty();

        [NativeName("hb_set_get_max")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_max")]
        static abstract uint SetGetMax(SetTHandle set);

        [NativeName("hb_set_get_min")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_min")]
        static abstract uint SetGetMin(SetTHandle set);

        [NativeName("hb_set_get_population")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_population")]
        static abstract uint SetGetPopulation(SetTHandle set);

        [NativeName("hb_set_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_user_data")]
        static abstract void* SetGetUserData(SetTHandle set, UserDataKeyT* key);

        [NativeName("hb_set_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_user_data")]
        static abstract Ptr SetGetUserData(SetTHandle set, Ref<UserDataKeyT> key);

        [NativeName("hb_set_has")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_has")]
        static abstract int SetHas(SetTHandle set, uint codepoint);

        [NativeName("hb_set_hash")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_hash")]
        static abstract uint SetHash(SetTHandle set);

        [NativeName("hb_set_intersect")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_intersect")]
        static abstract void SetIntersect(SetTHandle set, SetTHandle other);

        [NativeName("hb_set_invert")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_invert")]
        static abstract void SetInvert(SetTHandle set);

        [NativeName("hb_set_is_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_empty")]
        static abstract int SetIsEmpty(SetTHandle set);

        [NativeName("hb_set_is_equal")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_equal")]
        static abstract int SetIsEqual(SetTHandle set, SetTHandle other);

        [NativeName("hb_set_is_inverted")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_inverted")]
        static abstract int SetIsInverted(SetTHandle set);

        [NativeName("hb_set_is_subset")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_subset")]
        static abstract int SetIsSubset(SetTHandle set, SetTHandle larger_set);

        [NativeName("hb_set_next")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next")]
        static abstract int SetNext(SetTHandle set, uint* codepoint);

        [NativeName("hb_set_next")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next")]
        static abstract int SetNext(SetTHandle set, Ref<uint> codepoint);

        [NativeName("hb_set_next_many")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_many")]
        static abstract uint SetNextMany(SetTHandle set, uint codepoint, uint* @out, uint size);

        [NativeName("hb_set_next_many")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_many")]
        static abstract uint SetNextMany(SetTHandle set, uint codepoint, Ref<uint> @out, uint size);

        [NativeName("hb_set_next_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_range")]
        static abstract int SetNextRange(SetTHandle set, uint* first, uint* last);

        [NativeName("hb_set_next_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_range")]
        static abstract int SetNextRange(SetTHandle set, Ref<uint> first, Ref<uint> last);

        [NativeName("hb_set_previous")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous")]
        static abstract int SetPrevious(SetTHandle set, uint* codepoint);

        [NativeName("hb_set_previous")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous")]
        static abstract int SetPrevious(SetTHandle set, Ref<uint> codepoint);

        [NativeName("hb_set_previous_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous_range")]
        static abstract int SetPreviousRange(SetTHandle set, uint* first, uint* last);

        [NativeName("hb_set_previous_range")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous_range")]
        static abstract int SetPreviousRange(SetTHandle set, Ref<uint> first, Ref<uint> last);

        [NativeName("hb_set_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_reference")]
        static abstract SetTHandle SetReference(SetTHandle set);

        [NativeName("hb_set_set")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_set")]
        static abstract void SetSet(SetTHandle set, SetTHandle other);

        [NativeName("hb_set_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_set_user_data")]
        static abstract int SetSetUserData(
            SetTHandle set,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_set_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_set_user_data")]
        static abstract int SetSetUserData(
            SetTHandle set,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_set_subtract")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_subtract")]
        static abstract void SetSubtract(SetTHandle set, SetTHandle other);

        [NativeName("hb_set_symmetric_difference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_symmetric_difference")]
        static abstract void SetSymmetricDifference(SetTHandle set, SetTHandle other);

        [NativeName("hb_set_union")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_set_union")]
        static abstract void SetUnion(SetTHandle set, SetTHandle other);

        [NativeName("hb_shape")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape")]
        static abstract void Shape(
            FontTHandle font,
            BufferTHandle buffer,
            FeatureT* features,
            uint num_features
        );

        [NativeName("hb_shape")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape")]
        static abstract void Shape(
            FontTHandle font,
            BufferTHandle buffer,
            Ref<FeatureT> features,
            uint num_features
        );

        [NativeName("hb_shape_full")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_full")]
        static abstract int ShapeFull(
            FontTHandle font,
            BufferTHandle buffer,
            FeatureT* features,
            uint num_features,
            sbyte** shaper_list
        );

        [NativeName("hb_shape_full")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_full")]
        static abstract int ShapeFull(
            FontTHandle font,
            BufferTHandle buffer,
            Ref<FeatureT> features,
            uint num_features,
            Ref2D<sbyte> shaper_list
        );

        [NativeName("hb_shape_list_shapers")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_list_shapers")]
        static abstract Ptr2D<sbyte> ShapeListShapers();

        [NativeName("hb_shape_list_shapers")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_list_shapers")]
        static abstract sbyte** ShapeListShapersRaw();

        [NativeName("hb_shape_plan_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create")]
        static abstract ShapePlanTHandle ShapePlanCreate(
            FaceTHandle face,
            SegmentPropertiesT* props,
            FeatureT* user_features,
            uint num_user_features,
            sbyte** shaper_list
        );

        [NativeName("hb_shape_plan_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create")]
        static abstract ShapePlanTHandle ShapePlanCreate(
            FaceTHandle face,
            Ref<SegmentPropertiesT> props,
            Ref<FeatureT> user_features,
            uint num_user_features,
            Ref2D<sbyte> shaper_list
        );

        [NativeName("hb_shape_plan_create_cached")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached")]
        static abstract ShapePlanTHandle ShapePlanCreateCached(
            FaceTHandle face,
            SegmentPropertiesT* props,
            FeatureT* user_features,
            uint num_user_features,
            sbyte** shaper_list
        );

        [NativeName("hb_shape_plan_create_cached")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached")]
        static abstract ShapePlanTHandle ShapePlanCreateCached(
            FaceTHandle face,
            Ref<SegmentPropertiesT> props,
            Ref<FeatureT> user_features,
            uint num_user_features,
            Ref2D<sbyte> shaper_list
        );

        [NativeName("hb_shape_plan_create_cached2")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached2")]
        static abstract ShapePlanTHandle ShapePlanCreateCached2(
            FaceTHandle face,
            SegmentPropertiesT* props,
            FeatureT* user_features,
            uint num_user_features,
            int* coords,
            uint num_coords,
            sbyte** shaper_list
        );

        [NativeName("hb_shape_plan_create_cached2")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached2")]
        static abstract ShapePlanTHandle ShapePlanCreateCached2(
            FaceTHandle face,
            Ref<SegmentPropertiesT> props,
            Ref<FeatureT> user_features,
            uint num_user_features,
            Ref<int> coords,
            uint num_coords,
            Ref2D<sbyte> shaper_list
        );

        [NativeName("hb_shape_plan_create2")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create2")]
        static abstract ShapePlanTHandle ShapePlanCreate2(
            FaceTHandle face,
            SegmentPropertiesT* props,
            FeatureT* user_features,
            uint num_user_features,
            int* coords,
            uint num_coords,
            sbyte** shaper_list
        );

        [NativeName("hb_shape_plan_create2")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create2")]
        static abstract ShapePlanTHandle ShapePlanCreate2(
            FaceTHandle face,
            Ref<SegmentPropertiesT> props,
            Ref<FeatureT> user_features,
            uint num_user_features,
            Ref<int> coords,
            uint num_coords,
            Ref2D<sbyte> shaper_list
        );

        [NativeName("hb_shape_plan_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_destroy")]
        static abstract void ShapePlanDestroy(ShapePlanTHandle shape_plan);

        [NativeName("hb_shape_plan_execute")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_execute")]
        static abstract int ShapePlanExecute(
            ShapePlanTHandle shape_plan,
            FontTHandle font,
            BufferTHandle buffer,
            FeatureT* features,
            uint num_features
        );

        [NativeName("hb_shape_plan_execute")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_execute")]
        static abstract int ShapePlanExecute(
            ShapePlanTHandle shape_plan,
            FontTHandle font,
            BufferTHandle buffer,
            Ref<FeatureT> features,
            uint num_features
        );

        [NativeName("hb_shape_plan_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_empty")]
        static abstract ShapePlanTHandle ShapePlanGetEmpty();

        [NativeName("hb_shape_plan_get_shaper")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_shaper")]
        static abstract Ptr<sbyte> ShapePlanGetShaper(ShapePlanTHandle shape_plan);

        [NativeName("hb_shape_plan_get_shaper")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_shaper")]
        static abstract sbyte* ShapePlanGetShaperRaw(ShapePlanTHandle shape_plan);

        [NativeName("hb_shape_plan_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_user_data")]
        static abstract void* ShapePlanGetUserData(ShapePlanTHandle shape_plan, UserDataKeyT* key);

        [NativeName("hb_shape_plan_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_user_data")]
        static abstract Ptr ShapePlanGetUserData(
            ShapePlanTHandle shape_plan,
            Ref<UserDataKeyT> key
        );

        [NativeName("hb_shape_plan_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_reference")]
        static abstract ShapePlanTHandle ShapePlanReference(ShapePlanTHandle shape_plan);

        [NativeName("hb_shape_plan_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_set_user_data")]
        static abstract int ShapePlanSetUserData(
            ShapePlanTHandle shape_plan,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_shape_plan_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_set_user_data")]
        static abstract int ShapePlanSetUserData(
            ShapePlanTHandle shape_plan,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_style_get_value")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_style_get_value")]
        static abstract float StyleGetValue(FontTHandle font, StyleTagT style_tag);

        [NativeName("hb_tag_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_tag_from_string")]
        static abstract uint TagFromString(sbyte* str, int len);

        [NativeName("hb_tag_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_tag_from_string")]
        static abstract uint TagFromString(Ref<sbyte> str, int len);

        [NativeName("hb_tag_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_tag_to_string")]
        static abstract void TagToString(uint tag, sbyte* buf);

        [NativeName("hb_tag_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_tag_to_string")]
        static abstract void TagToString(uint tag, Ref<sbyte> buf);

        [NativeName("hb_unicode_combining_class")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_combining_class")]
        static abstract UnicodeCombiningClassT UnicodeCombiningClass(
            UnicodeFuncsTHandle ufuncs,
            uint unicode
        );

        [NativeName("hb_unicode_compose")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_compose")]
        static abstract int UnicodeCompose(UnicodeFuncsTHandle ufuncs, uint a, uint b, uint* ab);

        [NativeName("hb_unicode_compose")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_compose")]
        static abstract int UnicodeCompose(
            UnicodeFuncsTHandle ufuncs,
            uint a,
            uint b,
            Ref<uint> ab
        );

        [NativeName("hb_unicode_decompose")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose")]
        static abstract int UnicodeDecompose(UnicodeFuncsTHandle ufuncs, uint ab, uint* a, uint* b);

        [NativeName("hb_unicode_decompose")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose")]
        static abstract int UnicodeDecompose(
            UnicodeFuncsTHandle ufuncs,
            uint ab,
            Ref<uint> a,
            Ref<uint> b
        );

        [NativeName("hb_unicode_decompose_compatibility")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose_compatibility")]
        static abstract uint UnicodeDecomposeCompatibility(
            UnicodeFuncsTHandle ufuncs,
            uint u,
            uint* decomposed
        );

        [NativeName("hb_unicode_decompose_compatibility")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose_compatibility")]
        static abstract uint UnicodeDecomposeCompatibility(
            UnicodeFuncsTHandle ufuncs,
            uint u,
            Ref<uint> decomposed
        );

        [NativeName("hb_unicode_eastasian_width")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_eastasian_width")]
        static abstract uint UnicodeEastasianWidth(UnicodeFuncsTHandle ufuncs, uint unicode);

        [NativeName("hb_unicode_funcs_create")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_create")]
        static abstract UnicodeFuncsTHandle UnicodeFuncsCreate(UnicodeFuncsTHandle parent);

        [NativeName("hb_unicode_funcs_destroy")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_destroy")]
        static abstract void UnicodeFuncsDestroy(UnicodeFuncsTHandle ufuncs);

        [NativeName("hb_unicode_funcs_get_default")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_default")]
        static abstract UnicodeFuncsTHandle UnicodeFuncsGetDefault();

        [NativeName("hb_unicode_funcs_get_empty")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_empty")]
        static abstract UnicodeFuncsTHandle UnicodeFuncsGetEmpty();

        [NativeName("hb_unicode_funcs_get_parent")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_parent")]
        static abstract UnicodeFuncsTHandle UnicodeFuncsGetParent(UnicodeFuncsTHandle ufuncs);

        [NativeName("hb_unicode_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_user_data")]
        static abstract void* UnicodeFuncsGetUserData(
            UnicodeFuncsTHandle ufuncs,
            UserDataKeyT* key
        );

        [NativeName("hb_unicode_funcs_get_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_user_data")]
        static abstract Ptr UnicodeFuncsGetUserData(
            UnicodeFuncsTHandle ufuncs,
            Ref<UserDataKeyT> key
        );

        [NativeName("hb_unicode_funcs_is_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_is_immutable")]
        static abstract int UnicodeFuncsIsImmutable(UnicodeFuncsTHandle ufuncs);

        [NativeName("hb_unicode_funcs_make_immutable")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_make_immutable")]
        static abstract void UnicodeFuncsMakeImmutable(UnicodeFuncsTHandle ufuncs);

        [NativeName("hb_unicode_funcs_reference")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_reference")]
        static abstract UnicodeFuncsTHandle UnicodeFuncsReference(UnicodeFuncsTHandle ufuncs);

        [NativeName("hb_unicode_funcs_set_combining_class_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
        static abstract void UnicodeFuncsSetCombiningClassFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeCombiningClassFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_combining_class_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
        static abstract void UnicodeFuncsSetCombiningClassFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeCombiningClassFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_compose_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_compose_func")]
        static abstract void UnicodeFuncsSetComposeFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeComposeFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_compose_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_compose_func")]
        static abstract void UnicodeFuncsSetComposeFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeComposeFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_decompose_compatibility_func")]
        [Obsolete]
        [NativeFunction(
            "harfbuzz",
            EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func"
        )]
        static abstract void UnicodeFuncsSetDecomposeCompatibilityFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeDecomposeCompatibilityFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_decompose_compatibility_func")]
        [Obsolete]
        [NativeFunction(
            "harfbuzz",
            EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func"
        )]
        static abstract void UnicodeFuncsSetDecomposeCompatibilityFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeDecomposeCompatibilityFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_decompose_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_func")]
        static abstract void UnicodeFuncsSetDecomposeFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeDecomposeFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_decompose_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_func")]
        static abstract void UnicodeFuncsSetDecomposeFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeDecomposeFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_eastasian_width_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
        static abstract void UnicodeFuncsSetEastasianWidthFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeEastasianWidthFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_eastasian_width_func")]
        [Obsolete]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
        static abstract void UnicodeFuncsSetEastasianWidthFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeEastasianWidthFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_general_category_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_general_category_func")]
        static abstract void UnicodeFuncsSetGeneralCategoryFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeGeneralCategoryFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_general_category_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_general_category_func")]
        static abstract void UnicodeFuncsSetGeneralCategoryFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeGeneralCategoryFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_mirroring_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
        static abstract void UnicodeFuncsSetMirroringFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeMirroringFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_mirroring_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
        static abstract void UnicodeFuncsSetMirroringFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeMirroringFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_script_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_script_func")]
        static abstract void UnicodeFuncsSetScriptFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeScriptFuncT func,
            void* user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_script_func")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_script_func")]
        static abstract void UnicodeFuncsSetScriptFunc(
            UnicodeFuncsTHandle ufuncs,
            UnicodeScriptFuncT func,
            Ref user_data,
            DestroyFuncT destroy
        );

        [NativeName("hb_unicode_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_user_data")]
        static abstract int UnicodeFuncsSetUserData(
            UnicodeFuncsTHandle ufuncs,
            UserDataKeyT* key,
            void* data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_unicode_funcs_set_user_data")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_user_data")]
        static abstract int UnicodeFuncsSetUserData(
            UnicodeFuncsTHandle ufuncs,
            Ref<UserDataKeyT> key,
            Ref data,
            DestroyFuncT destroy,
            int replace
        );

        [NativeName("hb_unicode_general_category")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_general_category")]
        static abstract UnicodeGeneralCategoryT UnicodeGeneralCategory(
            UnicodeFuncsTHandle ufuncs,
            uint unicode
        );

        [NativeName("hb_unicode_mirroring")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_mirroring")]
        static abstract uint UnicodeMirroring(UnicodeFuncsTHandle ufuncs, uint unicode);

        [NativeName("hb_unicode_script")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_script")]
        static abstract ScriptT UnicodeScript(UnicodeFuncsTHandle ufuncs, uint unicode);

        [NativeName("hb_variation_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_variation_from_string")]
        static abstract int VariationFromString(sbyte* str, int len, VariationT* variation);

        [NativeName("hb_variation_from_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_variation_from_string")]
        static abstract int VariationFromString(Ref<sbyte> str, int len, Ref<VariationT> variation);

        [NativeName("hb_variation_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_variation_to_string")]
        static abstract void VariationToString(VariationT* variation, sbyte* buf, uint size);

        [NativeName("hb_variation_to_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_variation_to_string")]
        static abstract void VariationToString(
            Ref<VariationT> variation,
            Ref<sbyte> buf,
            uint size
        );

        [NativeName("hb_version")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_version")]
        static abstract void Version(uint* major, uint* minor, uint* micro);

        [NativeName("hb_version")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_version")]
        static abstract void Version(Ref<uint> major, Ref<uint> minor, Ref<uint> micro);

        [NativeName("hb_version_atleast")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_version_atleast")]
        static abstract int VersionAtleast(uint major, uint minor, uint micro);

        [NativeName("hb_version_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_version_string")]
        static abstract Ptr<sbyte> VersionString();

        [NativeName("hb_version_string")]
        [NativeFunction("harfbuzz", EntryPoint = "hb_version_string")]
        static abstract sbyte* VersionStringRaw();
    }

    [NativeName("hb_blob_copy_writable_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_copy_writable_or_fail")]
    BlobTHandle BlobCopyWritableOrFail(BlobTHandle blob);

    [NativeName("hb_blob_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create")]
    BlobTHandle BlobCreate(
        sbyte* data,
        uint length,
        MemoryModeT mode,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_blob_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create")]
    BlobTHandle BlobCreate(
        Ref<sbyte> data,
        uint length,
        MemoryModeT mode,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_blob_create_from_file")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file")]
    BlobTHandle BlobCreateFromFile(sbyte* file_name);

    [NativeName("hb_blob_create_from_file")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file")]
    BlobTHandle BlobCreateFromFile(Ref<sbyte> file_name);

    [NativeName("hb_blob_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file_or_fail")]
    BlobTHandle BlobCreateFromFileOrFail(sbyte* file_name);

    [NativeName("hb_blob_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_from_file_or_fail")]
    BlobTHandle BlobCreateFromFileOrFail(Ref<sbyte> file_name);

    [NativeName("hb_blob_create_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_or_fail")]
    BlobTHandle BlobCreateOrFail(
        sbyte* data,
        uint length,
        MemoryModeT mode,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_blob_create_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_or_fail")]
    BlobTHandle BlobCreateOrFail(
        Ref<sbyte> data,
        uint length,
        MemoryModeT mode,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_blob_create_sub_blob")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_create_sub_blob")]
    BlobTHandle BlobCreateSubBlob(BlobTHandle parent, uint offset, uint length);

    [NativeName("hb_blob_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_destroy")]
    void BlobDestroy(BlobTHandle blob);

    [NativeName("hb_blob_get_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data")]
    sbyte* BlobGetData(BlobTHandle blob, uint* length);

    [NativeName("hb_blob_get_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data")]
    Ptr<sbyte> BlobGetData(BlobTHandle blob, Ref<uint> length);

    [NativeName("hb_blob_get_data_writable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data_writable")]
    sbyte* BlobGetDataWritable(BlobTHandle blob, uint* length);

    [NativeName("hb_blob_get_data_writable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_data_writable")]
    Ptr<sbyte> BlobGetDataWritable(BlobTHandle blob, Ref<uint> length);

    [NativeName("hb_blob_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_empty")]
    BlobTHandle BlobGetEmpty();

    [NativeName("hb_blob_get_length")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_length")]
    uint BlobGetLength(BlobTHandle blob);

    [NativeName("hb_blob_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_user_data")]
    void* BlobGetUserData(BlobTHandle blob, UserDataKeyT* key);

    [NativeName("hb_blob_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_get_user_data")]
    Ptr BlobGetUserData(BlobTHandle blob, Ref<UserDataKeyT> key);

    [NativeName("hb_blob_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_is_immutable")]
    int BlobIsImmutable(BlobTHandle blob);

    [NativeName("hb_blob_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_make_immutable")]
    void BlobMakeImmutable(BlobTHandle blob);

    [NativeName("hb_blob_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_reference")]
    BlobTHandle BlobReference(BlobTHandle blob);

    [NativeName("hb_blob_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_set_user_data")]
    int BlobSetUserData(
        BlobTHandle blob,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_blob_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_blob_set_user_data")]
    int BlobSetUserData(
        BlobTHandle blob,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_buffer_add")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add")]
    void BufferAdd(BufferTHandle buffer, uint codepoint, uint cluster);

    [NativeName("hb_buffer_add_codepoints")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_codepoints")]
    void BufferAddCodepoints(
        BufferTHandle buffer,
        uint* text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_codepoints")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_codepoints")]
    void BufferAddCodepoints(
        BufferTHandle buffer,
        Ref<uint> text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_latin1")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_latin1")]
    void BufferAddLatin1(
        BufferTHandle buffer,
        byte* text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_latin1")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_latin1")]
    void BufferAddLatin1(
        BufferTHandle buffer,
        Ref<byte> text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf16")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf16")]
    void BufferAddUtf16(
        BufferTHandle buffer,
        ushort* text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf16")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf16")]
    void BufferAddUtf16(
        BufferTHandle buffer,
        Ref<ushort> text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf32")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf32")]
    void BufferAddUtf32(
        BufferTHandle buffer,
        uint* text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf32")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf32")]
    void BufferAddUtf32(
        BufferTHandle buffer,
        Ref<uint> text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf8")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf8")]
    void BufferAddUtf8(
        BufferTHandle buffer,
        sbyte* text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_add_utf8")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_add_utf8")]
    void BufferAddUtf8(
        BufferTHandle buffer,
        Ref<sbyte> text,
        int text_length,
        uint item_offset,
        int item_length
    );

    [NativeName("hb_buffer_allocation_successful")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_allocation_successful")]
    int BufferAllocationSuccessful(BufferTHandle buffer);

    [NativeName("hb_buffer_append")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_append")]
    void BufferAppend(BufferTHandle buffer, BufferTHandle source, uint start, uint end);

    [NativeName("hb_buffer_clear_contents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_clear_contents")]
    void BufferClearContents(BufferTHandle buffer);

    [NativeName("hb_buffer_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_create")]
    BufferTHandle BufferCreate();

    [NativeName("hb_buffer_create_similar")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_create_similar")]
    BufferTHandle BufferCreateSimilar(BufferTHandle src);

    [NativeName("hb_buffer_deserialize_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_glyphs")]
    int BufferDeserializeGlyphs(
        BufferTHandle buffer,
        sbyte* buf,
        int buf_len,
        sbyte** end_ptr,
        FontTHandle font,
        BufferSerializeFormatT format
    );

    [NativeName("hb_buffer_deserialize_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_glyphs")]
    int BufferDeserializeGlyphs(
        BufferTHandle buffer,
        Ref<sbyte> buf,
        int buf_len,
        Ref2D<sbyte> end_ptr,
        FontTHandle font,
        BufferSerializeFormatT format
    );

    [NativeName("hb_buffer_deserialize_unicode")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_unicode")]
    int BufferDeserializeUnicode(
        BufferTHandle buffer,
        sbyte* buf,
        int buf_len,
        sbyte** end_ptr,
        BufferSerializeFormatT format
    );

    [NativeName("hb_buffer_deserialize_unicode")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_deserialize_unicode")]
    int BufferDeserializeUnicode(
        BufferTHandle buffer,
        Ref<sbyte> buf,
        int buf_len,
        Ref2D<sbyte> end_ptr,
        BufferSerializeFormatT format
    );

    [NativeName("hb_buffer_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_destroy")]
    void BufferDestroy(BufferTHandle buffer);

    [NativeName("hb_buffer_diff")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_diff")]
    BufferDiffFlagsT BufferDiff(
        BufferTHandle buffer,
        BufferTHandle reference,
        uint dottedcircle_glyph,
        uint position_fuzz
    );

    [NativeName("hb_buffer_get_cluster_level")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_cluster_level")]
    BufferClusterLevelT BufferGetClusterLevel(BufferTHandle buffer);

    [NativeName("hb_buffer_get_content_type")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_content_type")]
    BufferContentTypeT BufferGetContentType(BufferTHandle buffer);

    [NativeName("hb_buffer_get_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_direction")]
    DirectionT BufferGetDirection(BufferTHandle buffer);

    [NativeName("hb_buffer_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_empty")]
    BufferTHandle BufferGetEmpty();

    [NativeName("hb_buffer_get_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_flags")]
    BufferFlagsT BufferGetFlags(BufferTHandle buffer);

    [NativeName("hb_buffer_get_glyph_infos")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_infos")]
    GlyphInfoT* BufferGetGlyphInfos(BufferTHandle buffer, uint* length);

    [NativeName("hb_buffer_get_glyph_infos")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_infos")]
    Ptr<GlyphInfoT> BufferGetGlyphInfos(BufferTHandle buffer, Ref<uint> length);

    [NativeName("hb_buffer_get_glyph_positions")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_positions")]
    GlyphPositionT* BufferGetGlyphPositions(BufferTHandle buffer, uint* length);

    [NativeName("hb_buffer_get_glyph_positions")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_glyph_positions")]
    Ptr<GlyphPositionT> BufferGetGlyphPositions(BufferTHandle buffer, Ref<uint> length);

    [NativeName("hb_buffer_get_invisible_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_invisible_glyph")]
    uint BufferGetInvisibleGlyph(BufferTHandle buffer);

    [NativeName("hb_buffer_get_language")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_language")]
    LanguageImplTHandle BufferGetLanguage(BufferTHandle buffer);

    [NativeName("hb_buffer_get_length")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_length")]
    uint BufferGetLength(BufferTHandle buffer);

    [NativeName("hb_buffer_get_not_found_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_not_found_glyph")]
    uint BufferGetNotFoundGlyph(BufferTHandle buffer);

    [NativeName("hb_buffer_get_not_found_variation_selector_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_not_found_variation_selector_glyph")]
    uint BufferGetNotFoundVariationSelectorGlyph(BufferTHandle buffer);

    [NativeName("hb_buffer_get_random_state")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_random_state")]
    uint BufferGetRandomState(BufferTHandle buffer);

    [NativeName("hb_buffer_get_replacement_codepoint")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_replacement_codepoint")]
    uint BufferGetReplacementCodepoint(BufferTHandle buffer);

    [NativeName("hb_buffer_get_script")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_script")]
    ScriptT BufferGetScript(BufferTHandle buffer);

    [NativeName("hb_buffer_get_segment_properties")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_segment_properties")]
    void BufferGetSegmentProperties(BufferTHandle buffer, SegmentPropertiesT* props);

    [NativeName("hb_buffer_get_segment_properties")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_segment_properties")]
    void BufferGetSegmentProperties(BufferTHandle buffer, Ref<SegmentPropertiesT> props);

    [NativeName("hb_buffer_get_unicode_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_unicode_funcs")]
    UnicodeFuncsTHandle BufferGetUnicodeFuncs(BufferTHandle buffer);

    [NativeName("hb_buffer_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_user_data")]
    void* BufferGetUserData(BufferTHandle buffer, UserDataKeyT* key);

    [NativeName("hb_buffer_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_get_user_data")]
    Ptr BufferGetUserData(BufferTHandle buffer, Ref<UserDataKeyT> key);

    [NativeName("hb_buffer_guess_segment_properties")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_guess_segment_properties")]
    void BufferGuessSegmentProperties(BufferTHandle buffer);

    [NativeName("hb_buffer_has_positions")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_has_positions")]
    int BufferHasPositions(BufferTHandle buffer);

    [NativeName("hb_buffer_normalize_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_normalize_glyphs")]
    void BufferNormalizeGlyphs(BufferTHandle buffer);

    [NativeName("hb_buffer_pre_allocate")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_pre_allocate")]
    int BufferPreAllocate(BufferTHandle buffer, uint size);

    [NativeName("hb_buffer_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reference")]
    BufferTHandle BufferReference(BufferTHandle buffer);

    [NativeName("hb_buffer_reset")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reset")]
    void BufferReset(BufferTHandle buffer);

    [NativeName("hb_buffer_reverse")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse")]
    void BufferReverse(BufferTHandle buffer);

    [NativeName("hb_buffer_reverse_clusters")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse_clusters")]
    void BufferReverseClusters(BufferTHandle buffer);

    [NativeName("hb_buffer_reverse_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_reverse_range")]
    void BufferReverseRange(BufferTHandle buffer, uint start, uint end);

    [NativeName("hb_buffer_serialize")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize")]
    uint BufferSerialize(
        BufferTHandle buffer,
        uint start,
        uint end,
        sbyte* buf,
        uint buf_size,
        uint* buf_consumed,
        FontTHandle font,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_serialize")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize")]
    uint BufferSerialize(
        BufferTHandle buffer,
        uint start,
        uint end,
        Ref<sbyte> buf,
        uint buf_size,
        Ref<uint> buf_consumed,
        FontTHandle font,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_serialize_format_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_from_string")]
    BufferSerializeFormatT BufferSerializeFormatFromString(sbyte* str, int len);

    [NativeName("hb_buffer_serialize_format_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_from_string")]
    BufferSerializeFormatT BufferSerializeFormatFromString(Ref<sbyte> str, int len);

    [NativeName("hb_buffer_serialize_format_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_to_string")]
    Ptr<sbyte> BufferSerializeFormatToString(BufferSerializeFormatT format);

    [NativeName("hb_buffer_serialize_format_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_format_to_string")]
    sbyte* BufferSerializeFormatToStringRaw(BufferSerializeFormatT format);

    [NativeName("hb_buffer_serialize_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_glyphs")]
    uint BufferSerializeGlyphs(
        BufferTHandle buffer,
        uint start,
        uint end,
        sbyte* buf,
        uint buf_size,
        uint* buf_consumed,
        FontTHandle font,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_serialize_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_glyphs")]
    uint BufferSerializeGlyphs(
        BufferTHandle buffer,
        uint start,
        uint end,
        Ref<sbyte> buf,
        uint buf_size,
        Ref<uint> buf_consumed,
        FontTHandle font,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_serialize_list_formats")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_list_formats")]
    Ptr2D<sbyte> BufferSerializeListFormats();

    [NativeName("hb_buffer_serialize_list_formats")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_list_formats")]
    sbyte** BufferSerializeListFormatsRaw();

    [NativeName("hb_buffer_serialize_unicode")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_unicode")]
    uint BufferSerializeUnicode(
        BufferTHandle buffer,
        uint start,
        uint end,
        sbyte* buf,
        uint buf_size,
        uint* buf_consumed,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_serialize_unicode")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_serialize_unicode")]
    uint BufferSerializeUnicode(
        BufferTHandle buffer,
        uint start,
        uint end,
        Ref<sbyte> buf,
        uint buf_size,
        Ref<uint> buf_consumed,
        BufferSerializeFormatT format,
        BufferSerializeFlagsT flags
    );

    [NativeName("hb_buffer_set_cluster_level")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_cluster_level")]
    void BufferSetClusterLevel(BufferTHandle buffer, BufferClusterLevelT cluster_level);

    [NativeName("hb_buffer_set_content_type")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_content_type")]
    void BufferSetContentType(BufferTHandle buffer, BufferContentTypeT content_type);

    [NativeName("hb_buffer_set_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_direction")]
    void BufferSetDirection(BufferTHandle buffer, DirectionT direction);

    [NativeName("hb_buffer_set_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_flags")]
    void BufferSetFlags(BufferTHandle buffer, BufferFlagsT flags);

    [NativeName("hb_buffer_set_invisible_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_invisible_glyph")]
    void BufferSetInvisibleGlyph(BufferTHandle buffer, uint invisible);

    [NativeName("hb_buffer_set_language")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_language")]
    void BufferSetLanguage(BufferTHandle buffer, LanguageImplTHandle language);

    [NativeName("hb_buffer_set_length")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_length")]
    int BufferSetLength(BufferTHandle buffer, uint length);

    [NativeName("hb_buffer_set_message_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_message_func")]
    void BufferSetMessageFunc(
        BufferTHandle buffer,
        BufferMessageFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_buffer_set_message_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_message_func")]
    void BufferSetMessageFunc(
        BufferTHandle buffer,
        BufferMessageFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_buffer_set_not_found_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_not_found_glyph")]
    void BufferSetNotFoundGlyph(BufferTHandle buffer, uint not_found);

    [NativeName("hb_buffer_set_not_found_variation_selector_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_not_found_variation_selector_glyph")]
    void BufferSetNotFoundVariationSelectorGlyph(
        BufferTHandle buffer,
        uint not_found_variation_selector
    );

    [NativeName("hb_buffer_set_random_state")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_random_state")]
    void BufferSetRandomState(BufferTHandle buffer, uint state);

    [NativeName("hb_buffer_set_replacement_codepoint")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_replacement_codepoint")]
    void BufferSetReplacementCodepoint(BufferTHandle buffer, uint replacement);

    [NativeName("hb_buffer_set_script")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_script")]
    void BufferSetScript(BufferTHandle buffer, ScriptT script);

    [NativeName("hb_buffer_set_segment_properties")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_segment_properties")]
    void BufferSetSegmentProperties(BufferTHandle buffer, SegmentPropertiesT* props);

    [NativeName("hb_buffer_set_segment_properties")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_segment_properties")]
    void BufferSetSegmentProperties(BufferTHandle buffer, Ref<SegmentPropertiesT> props);

    [NativeName("hb_buffer_set_unicode_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_unicode_funcs")]
    void BufferSetUnicodeFuncs(BufferTHandle buffer, UnicodeFuncsTHandle unicode_funcs);

    [NativeName("hb_buffer_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_user_data")]
    int BufferSetUserData(
        BufferTHandle buffer,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_buffer_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_buffer_set_user_data")]
    int BufferSetUserData(
        BufferTHandle buffer,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_calloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_calloc")]
    Ptr Calloc(nuint nmemb, nuint size);

    [NativeName("hb_calloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_calloc")]
    void* CallocRaw(nuint nmemb, nuint size);

    [NativeName("hb_color_get_alpha")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_alpha")]
    byte ColorGetAlpha(uint color);

    [NativeName("hb_color_get_blue")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_blue")]
    byte ColorGetBlue(uint color);

    [NativeName("hb_color_get_green")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_green")]
    byte ColorGetGreen(uint color);

    [NativeName("hb_color_get_red")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_get_red")]
    byte ColorGetRed(uint color);

    [NativeName("hb_color_line_get_color_stops")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_color_stops")]
    uint ColorLineGetColorStops(
        ColorLineT* color_line,
        uint start,
        uint* count,
        ColorStopT* color_stops
    );

    [NativeName("hb_color_line_get_color_stops")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_color_stops")]
    uint ColorLineGetColorStops(
        Ref<ColorLineT> color_line,
        uint start,
        Ref<uint> count,
        Ref<ColorStopT> color_stops
    );

    [NativeName("hb_color_line_get_extend")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_extend")]
    PaintExtendT ColorLineGetExtend(ColorLineT* color_line);

    [NativeName("hb_color_line_get_extend")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_color_line_get_extend")]
    PaintExtendT ColorLineGetExtend(Ref<ColorLineT> color_line);

    [NativeName("hb_direction_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_direction_from_string")]
    DirectionT DirectionFromString(sbyte* str, int len);

    [NativeName("hb_direction_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_direction_from_string")]
    DirectionT DirectionFromString(Ref<sbyte> str, int len);

    [NativeName("hb_direction_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_direction_to_string")]
    Ptr<sbyte> DirectionToString(DirectionT direction);

    [NativeName("hb_direction_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_direction_to_string")]
    sbyte* DirectionToStringRaw(DirectionT direction);

    [NativeName("hb_draw_close_path")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_close_path")]
    void DrawClosePath(DrawFuncsTHandle dfuncs, void* draw_data, DrawStateT* st);

    [NativeName("hb_draw_close_path")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_close_path")]
    void DrawClosePath(DrawFuncsTHandle dfuncs, Ref draw_data, Ref<DrawStateT> st);

    [NativeName("hb_draw_cubic_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_cubic_to")]
    void DrawCubicTo(
        DrawFuncsTHandle dfuncs,
        void* draw_data,
        DrawStateT* st,
        float control1_x,
        float control1_y,
        float control2_x,
        float control2_y,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_cubic_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_cubic_to")]
    void DrawCubicTo(
        DrawFuncsTHandle dfuncs,
        Ref draw_data,
        Ref<DrawStateT> st,
        float control1_x,
        float control1_y,
        float control2_x,
        float control2_y,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_funcs_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_create")]
    DrawFuncsTHandle DrawFuncsCreate();

    [NativeName("hb_draw_funcs_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_destroy")]
    void DrawFuncsDestroy(DrawFuncsTHandle dfuncs);

    [NativeName("hb_draw_funcs_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_empty")]
    DrawFuncsTHandle DrawFuncsGetEmpty();

    [NativeName("hb_draw_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_user_data")]
    void* DrawFuncsGetUserData(DrawFuncsTHandle dfuncs, UserDataKeyT* key);

    [NativeName("hb_draw_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_get_user_data")]
    Ptr DrawFuncsGetUserData(DrawFuncsTHandle dfuncs, Ref<UserDataKeyT> key);

    [NativeName("hb_draw_funcs_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_is_immutable")]
    int DrawFuncsIsImmutable(DrawFuncsTHandle dfuncs);

    [NativeName("hb_draw_funcs_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_make_immutable")]
    void DrawFuncsMakeImmutable(DrawFuncsTHandle dfuncs);

    [NativeName("hb_draw_funcs_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_reference")]
    DrawFuncsTHandle DrawFuncsReference(DrawFuncsTHandle dfuncs);

    [NativeName("hb_draw_funcs_set_close_path_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_close_path_func")]
    void DrawFuncsSetClosePathFunc(
        DrawFuncsTHandle dfuncs,
        DrawClosePathFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_close_path_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_close_path_func")]
    void DrawFuncsSetClosePathFunc(
        DrawFuncsTHandle dfuncs,
        DrawClosePathFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_cubic_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
    void DrawFuncsSetCubicToFunc(
        DrawFuncsTHandle dfuncs,
        DrawCubicToFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_cubic_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
    void DrawFuncsSetCubicToFunc(
        DrawFuncsTHandle dfuncs,
        DrawCubicToFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_line_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_line_to_func")]
    void DrawFuncsSetLineToFunc(
        DrawFuncsTHandle dfuncs,
        DrawLineToFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_line_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_line_to_func")]
    void DrawFuncsSetLineToFunc(
        DrawFuncsTHandle dfuncs,
        DrawLineToFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_move_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_move_to_func")]
    void DrawFuncsSetMoveToFunc(
        DrawFuncsTHandle dfuncs,
        DrawMoveToFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_move_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_move_to_func")]
    void DrawFuncsSetMoveToFunc(
        DrawFuncsTHandle dfuncs,
        DrawMoveToFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_quadratic_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
    void DrawFuncsSetQuadraticToFunc(
        DrawFuncsTHandle dfuncs,
        DrawQuadraticToFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_quadratic_to_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
    void DrawFuncsSetQuadraticToFunc(
        DrawFuncsTHandle dfuncs,
        DrawQuadraticToFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_draw_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_user_data")]
    int DrawFuncsSetUserData(
        DrawFuncsTHandle dfuncs,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_draw_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_funcs_set_user_data")]
    int DrawFuncsSetUserData(
        DrawFuncsTHandle dfuncs,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_draw_line_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_line_to")]
    void DrawLineTo(
        DrawFuncsTHandle dfuncs,
        void* draw_data,
        DrawStateT* st,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_line_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_line_to")]
    void DrawLineTo(
        DrawFuncsTHandle dfuncs,
        Ref draw_data,
        Ref<DrawStateT> st,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_move_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_move_to")]
    void DrawMoveTo(
        DrawFuncsTHandle dfuncs,
        void* draw_data,
        DrawStateT* st,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_move_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_move_to")]
    void DrawMoveTo(
        DrawFuncsTHandle dfuncs,
        Ref draw_data,
        Ref<DrawStateT> st,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_quadratic_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_quadratic_to")]
    void DrawQuadraticTo(
        DrawFuncsTHandle dfuncs,
        void* draw_data,
        DrawStateT* st,
        float control_x,
        float control_y,
        float to_x,
        float to_y
    );

    [NativeName("hb_draw_quadratic_to")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_draw_quadratic_to")]
    void DrawQuadraticTo(
        DrawFuncsTHandle dfuncs,
        Ref draw_data,
        Ref<DrawStateT> st,
        float control_x,
        float control_y,
        float to_x,
        float to_y
    );

    [NativeName("hb_face_builder_add_table")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_add_table")]
    int FaceBuilderAddTable(FaceTHandle face, uint tag, BlobTHandle blob);

    [NativeName("hb_face_builder_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_create")]
    FaceTHandle FaceBuilderCreate();

    [NativeName("hb_face_builder_sort_tables")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_sort_tables")]
    void FaceBuilderSortTables(FaceTHandle face, uint* tags);

    [NativeName("hb_face_builder_sort_tables")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_builder_sort_tables")]
    void FaceBuilderSortTables(FaceTHandle face, Ref<uint> tags);

    [NativeName("hb_face_collect_nominal_glyph_mapping")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_nominal_glyph_mapping")]
    void FaceCollectNominalGlyphMapping(FaceTHandle face, MapTHandle mapping, SetTHandle unicodes);

    [NativeName("hb_face_collect_unicodes")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_unicodes")]
    void FaceCollectUnicodes(FaceTHandle face, SetTHandle @out);

    [NativeName("hb_face_collect_variation_selectors")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_variation_selectors")]
    void FaceCollectVariationSelectors(FaceTHandle face, SetTHandle @out);

    [NativeName("hb_face_collect_variation_unicodes")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_collect_variation_unicodes")]
    void FaceCollectVariationUnicodes(FaceTHandle face, uint variation_selector, SetTHandle @out);

    [NativeName("hb_face_count")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_count")]
    uint FaceCount(BlobTHandle blob);

    [NativeName("hb_face_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create")]
    FaceTHandle FaceCreate(BlobTHandle blob, uint index);

    [NativeName("hb_face_create_for_tables")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_for_tables")]
    FaceTHandle FaceCreateForTables(
        ReferenceTableFuncT reference_table_func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_face_create_for_tables")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_for_tables")]
    FaceTHandle FaceCreateForTables(
        ReferenceTableFuncT reference_table_func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_face_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail")]
    FaceTHandle FaceCreateFromFileOrFail(sbyte* file_name, uint index);

    [NativeName("hb_face_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail")]
    FaceTHandle FaceCreateFromFileOrFail(Ref<sbyte> file_name, uint index);

    [NativeName("hb_face_create_from_file_or_fail_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail_using")]
    FaceTHandle FaceCreateFromFileOrFailUsing(sbyte* file_name, uint index, sbyte* loader_name);

    [NativeName("hb_face_create_from_file_or_fail_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_from_file_or_fail_using")]
    FaceTHandle FaceCreateFromFileOrFailUsing(
        Ref<sbyte> file_name,
        uint index,
        Ref<sbyte> loader_name
    );

    [NativeName("hb_face_create_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail")]
    FaceTHandle FaceCreateOrFail(BlobTHandle blob, uint index);

    [NativeName("hb_face_create_or_fail_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail_using")]
    FaceTHandle FaceCreateOrFailUsing(BlobTHandle blob, uint index, sbyte* loader_name);

    [NativeName("hb_face_create_or_fail_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_create_or_fail_using")]
    FaceTHandle FaceCreateOrFailUsing(BlobTHandle blob, uint index, Ref<sbyte> loader_name);

    [NativeName("hb_face_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_destroy")]
    void FaceDestroy(FaceTHandle face);

    [NativeName("hb_face_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_empty")]
    FaceTHandle FaceGetEmpty();

    [NativeName("hb_face_get_glyph_count")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_glyph_count")]
    uint FaceGetGlyphCount(FaceTHandle face);

    [NativeName("hb_face_get_index")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_index")]
    uint FaceGetIndex(FaceTHandle face);

    [NativeName("hb_face_get_table_tags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_table_tags")]
    uint FaceGetTableTags(FaceTHandle face, uint start_offset, uint* table_count, uint* table_tags);

    [NativeName("hb_face_get_table_tags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_table_tags")]
    uint FaceGetTableTags(
        FaceTHandle face,
        uint start_offset,
        Ref<uint> table_count,
        Ref<uint> table_tags
    );

    [NativeName("hb_face_get_upem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_upem")]
    uint FaceGetUpem(FaceTHandle face);

    [NativeName("hb_face_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_user_data")]
    void* FaceGetUserData(FaceTHandle face, UserDataKeyT* key);

    [NativeName("hb_face_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_get_user_data")]
    Ptr FaceGetUserData(FaceTHandle face, Ref<UserDataKeyT> key);

    [NativeName("hb_face_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_is_immutable")]
    int FaceIsImmutable(FaceTHandle face);

    [NativeName("hb_face_list_loaders")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_list_loaders")]
    Ptr2D<sbyte> FaceListLoaders();

    [NativeName("hb_face_list_loaders")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_list_loaders")]
    sbyte** FaceListLoadersRaw();

    [NativeName("hb_face_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_make_immutable")]
    void FaceMakeImmutable(FaceTHandle face);

    [NativeName("hb_face_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference")]
    FaceTHandle FaceReference(FaceTHandle face);

    [NativeName("hb_face_reference_blob")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference_blob")]
    BlobTHandle FaceReferenceBlob(FaceTHandle face);

    [NativeName("hb_face_reference_table")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_reference_table")]
    BlobTHandle FaceReferenceTable(FaceTHandle face, uint tag);

    [NativeName("hb_face_set_get_table_tags_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_get_table_tags_func")]
    void FaceSetGetTableTagsFunc(
        FaceTHandle face,
        GetTableTagsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_face_set_get_table_tags_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_get_table_tags_func")]
    void FaceSetGetTableTagsFunc(
        FaceTHandle face,
        GetTableTagsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_face_set_glyph_count")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_glyph_count")]
    void FaceSetGlyphCount(FaceTHandle face, uint glyph_count);

    [NativeName("hb_face_set_index")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_index")]
    void FaceSetIndex(FaceTHandle face, uint index);

    [NativeName("hb_face_set_upem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_upem")]
    void FaceSetUpem(FaceTHandle face, uint upem);

    [NativeName("hb_face_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_user_data")]
    int FaceSetUserData(
        FaceTHandle face,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_face_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_face_set_user_data")]
    int FaceSetUserData(
        FaceTHandle face,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_feature_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_feature_from_string")]
    int FeatureFromString(sbyte* str, int len, FeatureT* feature);

    [NativeName("hb_feature_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_feature_from_string")]
    int FeatureFromString(Ref<sbyte> str, int len, Ref<FeatureT> feature);

    [NativeName("hb_feature_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_feature_to_string")]
    void FeatureToString(FeatureT* feature, sbyte* buf, uint size);

    [NativeName("hb_feature_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_feature_to_string")]
    void FeatureToString(Ref<FeatureT> feature, Ref<sbyte> buf, uint size);

    [NativeName("hb_font_add_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_add_glyph_origin_for_direction")]
    void FontAddGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_add_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_add_glyph_origin_for_direction")]
    void FontAddGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_changed")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_changed")]
    void FontChanged(FontTHandle font);

    [NativeName("hb_font_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_create")]
    FontTHandle FontCreate(FaceTHandle face);

    [NativeName("hb_font_create_sub_font")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_create_sub_font")]
    FontTHandle FontCreateSubFont(FontTHandle parent);

    [NativeName("hb_font_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_destroy")]
    void FontDestroy(FontTHandle font);

    [NativeName("hb_font_draw_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph")]
    void FontDrawGlyph(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, void* draw_data);

    [NativeName("hb_font_draw_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph")]
    void FontDrawGlyph(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, Ref draw_data);

    [NativeName("hb_font_draw_glyph_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph_or_fail")]
    int FontDrawGlyphOrFail(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, void* draw_data);

    [NativeName("hb_font_draw_glyph_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_draw_glyph_or_fail")]
    int FontDrawGlyphOrFail(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, Ref draw_data);

    [NativeName("hb_font_funcs_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_create")]
    FontFuncsTHandle FontFuncsCreate();

    [NativeName("hb_font_funcs_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_destroy")]
    void FontFuncsDestroy(FontFuncsTHandle ffuncs);

    [NativeName("hb_font_funcs_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_empty")]
    FontFuncsTHandle FontFuncsGetEmpty();

    [NativeName("hb_font_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_user_data")]
    void* FontFuncsGetUserData(FontFuncsTHandle ffuncs, UserDataKeyT* key);

    [NativeName("hb_font_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_get_user_data")]
    Ptr FontFuncsGetUserData(FontFuncsTHandle ffuncs, Ref<UserDataKeyT> key);

    [NativeName("hb_font_funcs_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_is_immutable")]
    int FontFuncsIsImmutable(FontFuncsTHandle ffuncs);

    [NativeName("hb_font_funcs_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_make_immutable")]
    void FontFuncsMakeImmutable(FontFuncsTHandle ffuncs);

    [NativeName("hb_font_funcs_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_reference")]
    FontFuncsTHandle FontFuncsReference(FontFuncsTHandle ffuncs);

    [NativeName("hb_font_funcs_set_draw_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
    void FontFuncsSetDrawGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontDrawGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_draw_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
    void FontFuncsSetDrawGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontDrawGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_draw_glyph_or_fail_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
    void FontFuncsSetDrawGlyphOrFailFunc(
        FontFuncsTHandle ffuncs,
        FontDrawGlyphOrFailFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_draw_glyph_or_fail_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
    void FontFuncsSetDrawGlyphOrFailFunc(
        FontFuncsTHandle ffuncs,
        FontDrawGlyphOrFailFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_font_h_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
    void FontFuncsSetFontHExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetFontHExtentsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_font_h_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
    void FontFuncsSetFontHExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetFontHExtentsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_font_v_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
    void FontFuncsSetFontVExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetFontVExtentsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_font_v_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
    void FontFuncsSetFontVExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetFontVExtentsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_contour_point_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
    void FontFuncsSetGlyphContourPointFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphContourPointFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_contour_point_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
    void FontFuncsSetGlyphContourPointFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphContourPointFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
    void FontFuncsSetGlyphExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphExtentsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_extents_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
    void FontFuncsSetGlyphExtentsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphExtentsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_from_name_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
    void FontFuncsSetGlyphFromNameFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphFromNameFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_from_name_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
    void FontFuncsSetGlyphFromNameFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphFromNameFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_func")]
    void FontFuncsSetGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_func")]
    void FontFuncsSetGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_advance_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
    void FontFuncsSetGlyphHAdvanceFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHAdvanceFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_advance_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
    void FontFuncsSetGlyphHAdvanceFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHAdvanceFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_advances_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
    void FontFuncsSetGlyphHAdvancesFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHAdvancesFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_advances_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
    void FontFuncsSetGlyphHAdvancesFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHAdvancesFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_kerning_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
    void FontFuncsSetGlyphHKerningFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHKerningFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_kerning_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
    void FontFuncsSetGlyphHKerningFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHKerningFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_origin_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
    void FontFuncsSetGlyphHOriginFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHOriginFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_origin_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
    void FontFuncsSetGlyphHOriginFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHOriginFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_origins_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
    void FontFuncsSetGlyphHOriginsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHOriginsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_h_origins_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
    void FontFuncsSetGlyphHOriginsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphHOriginsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_name_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_name_func")]
    void FontFuncsSetGlyphNameFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphNameFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_name_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_name_func")]
    void FontFuncsSetGlyphNameFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphNameFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_shape_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
    void FontFuncsSetGlyphShapeFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphShapeFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_shape_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
    void FontFuncsSetGlyphShapeFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphShapeFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_advance_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
    void FontFuncsSetGlyphVAdvanceFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVAdvanceFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_advance_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
    void FontFuncsSetGlyphVAdvanceFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVAdvanceFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_advances_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
    void FontFuncsSetGlyphVAdvancesFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVAdvancesFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_advances_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
    void FontFuncsSetGlyphVAdvancesFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVAdvancesFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_kerning_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
    void FontFuncsSetGlyphVKerningFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVKerningFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_kerning_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
    void FontFuncsSetGlyphVKerningFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVKerningFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_origin_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
    void FontFuncsSetGlyphVOriginFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVOriginFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_origin_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
    void FontFuncsSetGlyphVOriginFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVOriginFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_origins_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
    void FontFuncsSetGlyphVOriginsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVOriginsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_glyph_v_origins_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
    void FontFuncsSetGlyphVOriginsFunc(
        FontFuncsTHandle ffuncs,
        FontGetGlyphVOriginsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_nominal_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
    void FontFuncsSetNominalGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetNominalGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_nominal_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
    void FontFuncsSetNominalGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetNominalGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_nominal_glyphs_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
    void FontFuncsSetNominalGlyphsFunc(
        FontFuncsTHandle ffuncs,
        FontGetNominalGlyphsFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_nominal_glyphs_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
    void FontFuncsSetNominalGlyphsFunc(
        FontFuncsTHandle ffuncs,
        FontGetNominalGlyphsFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_paint_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
    void FontFuncsSetPaintGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontPaintGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_paint_glyph_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
    void FontFuncsSetPaintGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontPaintGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_paint_glyph_or_fail_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
    void FontFuncsSetPaintGlyphOrFailFunc(
        FontFuncsTHandle ffuncs,
        FontPaintGlyphOrFailFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_paint_glyph_or_fail_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
    void FontFuncsSetPaintGlyphOrFailFunc(
        FontFuncsTHandle ffuncs,
        FontPaintGlyphOrFailFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_user_data")]
    int FontFuncsSetUserData(
        FontFuncsTHandle ffuncs,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_font_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_user_data")]
    int FontFuncsSetUserData(
        FontFuncsTHandle ffuncs,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_font_funcs_set_variation_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
    void FontFuncsSetVariationGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetVariationGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_funcs_set_variation_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
    void FontFuncsSetVariationGlyphFunc(
        FontFuncsTHandle ffuncs,
        FontGetVariationGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_empty")]
    FontTHandle FontGetEmpty();

    [NativeName("hb_font_get_extents_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_extents_for_direction")]
    void FontGetExtentsForDirection(FontTHandle font, DirectionT direction, FontExtentsT* extents);

    [NativeName("hb_font_get_extents_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_extents_for_direction")]
    void FontGetExtentsForDirection(
        FontTHandle font,
        DirectionT direction,
        Ref<FontExtentsT> extents
    );

    [NativeName("hb_font_get_face")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_face")]
    FaceTHandle FontGetFace(FontTHandle font);

    [NativeName("hb_font_get_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph")]
    int FontGetGlyph(FontTHandle font, uint unicode, uint variation_selector, uint* glyph);

    [NativeName("hb_font_get_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph")]
    int FontGetGlyph(FontTHandle font, uint unicode, uint variation_selector, Ref<uint> glyph);

    [NativeName("hb_font_get_glyph_advance_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advance_for_direction")]
    void FontGetGlyphAdvanceForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_get_glyph_advance_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advance_for_direction")]
    void FontGetGlyphAdvanceForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_get_glyph_advances_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advances_for_direction")]
    void FontGetGlyphAdvancesForDirection(
        FontTHandle font,
        DirectionT direction,
        uint count,
        uint* first_glyph,
        uint glyph_stride,
        int* first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_advances_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_advances_for_direction")]
    void FontGetGlyphAdvancesForDirection(
        FontTHandle font,
        DirectionT direction,
        uint count,
        Ref<uint> first_glyph,
        uint glyph_stride,
        Ref<int> first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_contour_point")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point")]
    int FontGetGlyphContourPoint(FontTHandle font, uint glyph, uint point_index, int* x, int* y);

    [NativeName("hb_font_get_glyph_contour_point")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point")]
    int FontGetGlyphContourPoint(
        FontTHandle font,
        uint glyph,
        uint point_index,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_get_glyph_contour_point_for_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
    int FontGetGlyphContourPointForOrigin(
        FontTHandle font,
        uint glyph,
        uint point_index,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_get_glyph_contour_point_for_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
    int FontGetGlyphContourPointForOrigin(
        FontTHandle font,
        uint glyph,
        uint point_index,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_get_glyph_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents")]
    int FontGetGlyphExtents(FontTHandle font, uint glyph, GlyphExtentsT* extents);

    [NativeName("hb_font_get_glyph_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents")]
    int FontGetGlyphExtents(FontTHandle font, uint glyph, Ref<GlyphExtentsT> extents);

    [NativeName("hb_font_get_glyph_extents_for_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents_for_origin")]
    int FontGetGlyphExtentsForOrigin(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        GlyphExtentsT* extents
    );

    [NativeName("hb_font_get_glyph_extents_for_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_extents_for_origin")]
    int FontGetGlyphExtentsForOrigin(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        Ref<GlyphExtentsT> extents
    );

    [NativeName("hb_font_get_glyph_from_name")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_from_name")]
    int FontGetGlyphFromName(FontTHandle font, sbyte* name, int len, uint* glyph);

    [NativeName("hb_font_get_glyph_from_name")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_from_name")]
    int FontGetGlyphFromName(FontTHandle font, Ref<sbyte> name, int len, Ref<uint> glyph);

    [NativeName("hb_font_get_glyph_h_advance")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advance")]
    int FontGetGlyphHAdvance(FontTHandle font, uint glyph);

    [NativeName("hb_font_get_glyph_h_advances")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advances")]
    void FontGetGlyphHAdvances(
        FontTHandle font,
        uint count,
        uint* first_glyph,
        uint glyph_stride,
        int* first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_h_advances")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_advances")]
    void FontGetGlyphHAdvances(
        FontTHandle font,
        uint count,
        Ref<uint> first_glyph,
        uint glyph_stride,
        Ref<int> first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_h_kerning")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_kerning")]
    int FontGetGlyphHKerning(FontTHandle font, uint left_glyph, uint right_glyph);

    [NativeName("hb_font_get_glyph_h_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origin")]
    int FontGetGlyphHOrigin(FontTHandle font, uint glyph, int* x, int* y);

    [NativeName("hb_font_get_glyph_h_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origin")]
    int FontGetGlyphHOrigin(FontTHandle font, uint glyph, Ref<int> x, Ref<int> y);

    [NativeName("hb_font_get_glyph_h_origins")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origins")]
    int FontGetGlyphHOrigins(
        FontTHandle font,
        uint count,
        uint* first_glyph,
        uint glyph_stride,
        int* first_x,
        uint x_stride,
        int* first_y,
        uint y_stride
    );

    [NativeName("hb_font_get_glyph_h_origins")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_h_origins")]
    int FontGetGlyphHOrigins(
        FontTHandle font,
        uint count,
        Ref<uint> first_glyph,
        uint glyph_stride,
        Ref<int> first_x,
        uint x_stride,
        Ref<int> first_y,
        uint y_stride
    );

    [NativeName("hb_font_get_glyph_kerning_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
    void FontGetGlyphKerningForDirection(
        FontTHandle font,
        uint first_glyph,
        uint second_glyph,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_get_glyph_kerning_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
    void FontGetGlyphKerningForDirection(
        FontTHandle font,
        uint first_glyph,
        uint second_glyph,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_get_glyph_name")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_name")]
    int FontGetGlyphName(FontTHandle font, uint glyph, sbyte* name, uint size);

    [NativeName("hb_font_get_glyph_name")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_name")]
    int FontGetGlyphName(FontTHandle font, uint glyph, Ref<sbyte> name, uint size);

    [NativeName("hb_font_get_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_origin_for_direction")]
    void FontGetGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_get_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_origin_for_direction")]
    void FontGetGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_font_get_glyph_shape")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_shape")]
    void FontGetGlyphShape(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, void* draw_data);

    [NativeName("hb_font_get_glyph_shape")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_shape")]
    void FontGetGlyphShape(FontTHandle font, uint glyph, DrawFuncsTHandle dfuncs, Ref draw_data);

    [NativeName("hb_font_get_glyph_v_advance")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advance")]
    int FontGetGlyphVAdvance(FontTHandle font, uint glyph);

    [NativeName("hb_font_get_glyph_v_advances")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advances")]
    void FontGetGlyphVAdvances(
        FontTHandle font,
        uint count,
        uint* first_glyph,
        uint glyph_stride,
        int* first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_v_advances")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_advances")]
    void FontGetGlyphVAdvances(
        FontTHandle font,
        uint count,
        Ref<uint> first_glyph,
        uint glyph_stride,
        Ref<int> first_advance,
        uint advance_stride
    );

    [NativeName("hb_font_get_glyph_v_kerning")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_kerning")]
    int FontGetGlyphVKerning(FontTHandle font, uint top_glyph, uint bottom_glyph);

    [NativeName("hb_font_get_glyph_v_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origin")]
    int FontGetGlyphVOrigin(FontTHandle font, uint glyph, int* x, int* y);

    [NativeName("hb_font_get_glyph_v_origin")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origin")]
    int FontGetGlyphVOrigin(FontTHandle font, uint glyph, Ref<int> x, Ref<int> y);

    [NativeName("hb_font_get_glyph_v_origins")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origins")]
    int FontGetGlyphVOrigins(
        FontTHandle font,
        uint count,
        uint* first_glyph,
        uint glyph_stride,
        int* first_x,
        uint x_stride,
        int* first_y,
        uint y_stride
    );

    [NativeName("hb_font_get_glyph_v_origins")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_glyph_v_origins")]
    int FontGetGlyphVOrigins(
        FontTHandle font,
        uint count,
        Ref<uint> first_glyph,
        uint glyph_stride,
        Ref<int> first_x,
        uint x_stride,
        Ref<int> first_y,
        uint y_stride
    );

    [NativeName("hb_font_get_h_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_h_extents")]
    int FontGetHExtents(FontTHandle font, FontExtentsT* extents);

    [NativeName("hb_font_get_h_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_h_extents")]
    int FontGetHExtents(FontTHandle font, Ref<FontExtentsT> extents);

    [NativeName("hb_font_get_nominal_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyph")]
    int FontGetNominalGlyph(FontTHandle font, uint unicode, uint* glyph);

    [NativeName("hb_font_get_nominal_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyph")]
    int FontGetNominalGlyph(FontTHandle font, uint unicode, Ref<uint> glyph);

    [NativeName("hb_font_get_nominal_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyphs")]
    uint FontGetNominalGlyphs(
        FontTHandle font,
        uint count,
        uint* first_unicode,
        uint unicode_stride,
        uint* first_glyph,
        uint glyph_stride
    );

    [NativeName("hb_font_get_nominal_glyphs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_nominal_glyphs")]
    uint FontGetNominalGlyphs(
        FontTHandle font,
        uint count,
        Ref<uint> first_unicode,
        uint unicode_stride,
        Ref<uint> first_glyph,
        uint glyph_stride
    );

    [NativeName("hb_font_get_parent")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_parent")]
    FontTHandle FontGetParent(FontTHandle font);

    [NativeName("hb_font_get_ppem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ppem")]
    void FontGetPpem(FontTHandle font, uint* x_ppem, uint* y_ppem);

    [NativeName("hb_font_get_ppem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ppem")]
    void FontGetPpem(FontTHandle font, Ref<uint> x_ppem, Ref<uint> y_ppem);

    [NativeName("hb_font_get_ptem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_ptem")]
    float FontGetPtem(FontTHandle font);

    [NativeName("hb_font_get_scale")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_scale")]
    void FontGetScale(FontTHandle font, int* x_scale, int* y_scale);

    [NativeName("hb_font_get_scale")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_scale")]
    void FontGetScale(FontTHandle font, Ref<int> x_scale, Ref<int> y_scale);

    [NativeName("hb_font_get_serial")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_serial")]
    uint FontGetSerial(FontTHandle font);

    [NativeName("hb_font_get_synthetic_bold")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_bold")]
    void FontGetSyntheticBold(
        FontTHandle font,
        float* x_embolden,
        float* y_embolden,
        int* in_place
    );

    [NativeName("hb_font_get_synthetic_bold")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_bold")]
    void FontGetSyntheticBold(
        FontTHandle font,
        Ref<float> x_embolden,
        Ref<float> y_embolden,
        Ref<int> in_place
    );

    [NativeName("hb_font_get_synthetic_slant")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_synthetic_slant")]
    float FontGetSyntheticSlant(FontTHandle font);

    [NativeName("hb_font_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_user_data")]
    void* FontGetUserData(FontTHandle font, UserDataKeyT* key);

    [NativeName("hb_font_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_user_data")]
    Ptr FontGetUserData(FontTHandle font, Ref<UserDataKeyT> key);

    [NativeName("hb_font_get_v_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_v_extents")]
    int FontGetVExtents(FontTHandle font, FontExtentsT* extents);

    [NativeName("hb_font_get_v_extents")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_v_extents")]
    int FontGetVExtents(FontTHandle font, Ref<FontExtentsT> extents);

    [NativeName("hb_font_get_var_coords_design")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_design")]
    float* FontGetVarCoordsDesign(FontTHandle font, uint* length);

    [NativeName("hb_font_get_var_coords_design")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_design")]
    Ptr<float> FontGetVarCoordsDesign(FontTHandle font, Ref<uint> length);

    [NativeName("hb_font_get_var_coords_normalized")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_normalized")]
    int* FontGetVarCoordsNormalized(FontTHandle font, uint* length);

    [NativeName("hb_font_get_var_coords_normalized")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_coords_normalized")]
    Ptr<int> FontGetVarCoordsNormalized(FontTHandle font, Ref<uint> length);

    [NativeName("hb_font_get_var_named_instance")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_var_named_instance")]
    uint FontGetVarNamedInstance(FontTHandle font);

    [NativeName("hb_font_get_variation_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_variation_glyph")]
    int FontGetVariationGlyph(FontTHandle font, uint unicode, uint variation_selector, uint* glyph);

    [NativeName("hb_font_get_variation_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_get_variation_glyph")]
    int FontGetVariationGlyph(
        FontTHandle font,
        uint unicode,
        uint variation_selector,
        Ref<uint> glyph
    );

    [NativeName("hb_font_glyph_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_from_string")]
    int FontGlyphFromString(FontTHandle font, sbyte* s, int len, uint* glyph);

    [NativeName("hb_font_glyph_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_from_string")]
    int FontGlyphFromString(FontTHandle font, Ref<sbyte> s, int len, Ref<uint> glyph);

    [NativeName("hb_font_glyph_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_to_string")]
    void FontGlyphToString(FontTHandle font, uint glyph, sbyte* s, uint size);

    [NativeName("hb_font_glyph_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_glyph_to_string")]
    void FontGlyphToString(FontTHandle font, uint glyph, Ref<sbyte> s, uint size);

    [NativeName("hb_font_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_is_immutable")]
    int FontIsImmutable(FontTHandle font);

    [NativeName("hb_font_is_synthetic")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_is_synthetic")]
    int FontIsSynthetic(FontTHandle font);

    [NativeName("hb_font_list_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_list_funcs")]
    Ptr2D<sbyte> FontListFuncs();

    [NativeName("hb_font_list_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_list_funcs")]
    sbyte** FontListFuncsRaw();

    [NativeName("hb_font_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_make_immutable")]
    void FontMakeImmutable(FontTHandle font);

    [NativeName("hb_font_paint_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph")]
    void FontPaintGlyph(
        FontTHandle font,
        uint glyph,
        PaintFuncsTHandle pfuncs,
        void* paint_data,
        uint palette_index,
        uint foreground
    );

    [NativeName("hb_font_paint_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph")]
    void FontPaintGlyph(
        FontTHandle font,
        uint glyph,
        PaintFuncsTHandle pfuncs,
        Ref paint_data,
        uint palette_index,
        uint foreground
    );

    [NativeName("hb_font_paint_glyph_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph_or_fail")]
    int FontPaintGlyphOrFail(
        FontTHandle font,
        uint glyph,
        PaintFuncsTHandle pfuncs,
        void* paint_data,
        uint palette_index,
        uint foreground
    );

    [NativeName("hb_font_paint_glyph_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_paint_glyph_or_fail")]
    int FontPaintGlyphOrFail(
        FontTHandle font,
        uint glyph,
        PaintFuncsTHandle pfuncs,
        Ref paint_data,
        uint palette_index,
        uint foreground
    );

    [NativeName("hb_font_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_reference")]
    FontTHandle FontReference(FontTHandle font);

    [NativeName("hb_font_set_face")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_face")]
    void FontSetFace(FontTHandle font, FaceTHandle face);

    [NativeName("hb_font_set_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs")]
    void FontSetFuncs(
        FontTHandle font,
        FontFuncsTHandle klass,
        void* font_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_set_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs")]
    void FontSetFuncs(
        FontTHandle font,
        FontFuncsTHandle klass,
        Ref font_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_font_set_funcs_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_data")]
    void FontSetFuncsData(FontTHandle font, void* font_data, DestroyFuncT destroy);

    [NativeName("hb_font_set_funcs_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_data")]
    void FontSetFuncsData(FontTHandle font, Ref font_data, DestroyFuncT destroy);

    [NativeName("hb_font_set_funcs_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_using")]
    int FontSetFuncsUsing(FontTHandle font, sbyte* name);

    [NativeName("hb_font_set_funcs_using")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_funcs_using")]
    int FontSetFuncsUsing(FontTHandle font, Ref<sbyte> name);

    [NativeName("hb_font_set_parent")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_parent")]
    void FontSetParent(FontTHandle font, FontTHandle parent);

    [NativeName("hb_font_set_ppem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_ppem")]
    void FontSetPpem(FontTHandle font, uint x_ppem, uint y_ppem);

    [NativeName("hb_font_set_ptem")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_ptem")]
    void FontSetPtem(FontTHandle font, float ptem);

    [NativeName("hb_font_set_scale")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_scale")]
    void FontSetScale(FontTHandle font, int x_scale, int y_scale);

    [NativeName("hb_font_set_synthetic_bold")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_synthetic_bold")]
    void FontSetSyntheticBold(FontTHandle font, float x_embolden, float y_embolden, int in_place);

    [NativeName("hb_font_set_synthetic_slant")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_synthetic_slant")]
    void FontSetSyntheticSlant(FontTHandle font, float slant);

    [NativeName("hb_font_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_user_data")]
    int FontSetUserData(
        FontTHandle font,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_font_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_user_data")]
    int FontSetUserData(
        FontTHandle font,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_font_set_var_coords_design")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_design")]
    void FontSetVarCoordsDesign(FontTHandle font, float* coords, uint coords_length);

    [NativeName("hb_font_set_var_coords_design")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_design")]
    void FontSetVarCoordsDesign(FontTHandle font, Ref<float> coords, uint coords_length);

    [NativeName("hb_font_set_var_coords_normalized")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_normalized")]
    void FontSetVarCoordsNormalized(FontTHandle font, int* coords, uint coords_length);

    [NativeName("hb_font_set_var_coords_normalized")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_coords_normalized")]
    void FontSetVarCoordsNormalized(FontTHandle font, Ref<int> coords, uint coords_length);

    [NativeName("hb_font_set_var_named_instance")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_var_named_instance")]
    void FontSetVarNamedInstance(FontTHandle font, uint instance_index);

    [NativeName("hb_font_set_variation")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variation")]
    void FontSetVariation(FontTHandle font, uint tag, float value);

    [NativeName("hb_font_set_variations")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variations")]
    void FontSetVariations(FontTHandle font, VariationT* variations, uint variations_length);

    [NativeName("hb_font_set_variations")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_set_variations")]
    void FontSetVariations(FontTHandle font, Ref<VariationT> variations, uint variations_length);

    [NativeName("hb_font_subtract_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
    void FontSubtractGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        int* x,
        int* y
    );

    [NativeName("hb_font_subtract_glyph_origin_for_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
    void FontSubtractGlyphOriginForDirection(
        FontTHandle font,
        uint glyph,
        DirectionT direction,
        Ref<int> x,
        Ref<int> y
    );

    [NativeName("hb_free")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_free")]
    void Free(void* ptr);

    [NativeName("hb_free")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_free")]
    void Free(Ref ptr);

    [NativeName("hb_ft_face_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create")]
    FaceTHandle FtFaceCreate(FTFaceRecHandle ft_face, DestroyFuncT destroy);

    [NativeName("hb_ft_face_create_cached")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_cached")]
    FaceTHandle FtFaceCreateCached(FTFaceRecHandle ft_face);

    [NativeName("hb_ft_face_create_from_blob_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_blob_or_fail")]
    FaceTHandle FtFaceCreateFromBlobOrFail(BlobTHandle blob, uint index);

    [NativeName("hb_ft_face_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_file_or_fail")]
    FaceTHandle FtFaceCreateFromFileOrFail(sbyte* file_name, uint index);

    [NativeName("hb_ft_face_create_from_file_or_fail")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_from_file_or_fail")]
    FaceTHandle FtFaceCreateFromFileOrFail(Ref<sbyte> file_name, uint index);

    [NativeName("hb_ft_face_create_referenced")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_face_create_referenced")]
    FaceTHandle FtFaceCreateReferenced(FTFaceRecHandle ft_face);

    [NativeName("hb_ft_font_changed")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_changed")]
    void FtFontChanged(FontTHandle font);

    [NativeName("hb_ft_font_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_create")]
    FontTHandle FtFontCreate(FTFaceRecHandle ft_face, DestroyFuncT destroy);

    [NativeName("hb_ft_font_create_referenced")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_create_referenced")]
    FontTHandle FtFontCreateReferenced(FTFaceRecHandle ft_face);

    [NativeName("hb_ft_font_get_face")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_face")]
    FTFaceRecHandle FtFontGetFace(FontTHandle font);

    [NativeName("hb_ft_font_get_ft_face")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_ft_face")]
    FTFaceRecHandle FtFontGetFtFace(FontTHandle font);

    [NativeName("hb_ft_font_get_load_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_get_load_flags")]
    int FtFontGetLoadFlags(FontTHandle font);

    [NativeName("hb_ft_font_lock_face")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_lock_face")]
    FTFaceRecHandle FtFontLockFace(FontTHandle font);

    [NativeName("hb_ft_font_set_funcs")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_set_funcs")]
    void FtFontSetFuncs(FontTHandle font);

    [NativeName("hb_ft_font_set_load_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_set_load_flags")]
    void FtFontSetLoadFlags(FontTHandle font, int load_flags);

    [NativeName("hb_ft_font_unlock_face")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_font_unlock_face")]
    void FtFontUnlockFace(FontTHandle font);

    [NativeName("hb_ft_hb_font_changed")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_ft_hb_font_changed")]
    int FtHbFontChanged(FontTHandle font);

    [NativeName("hb_glyph_info_get_glyph_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_glyph_info_get_glyph_flags")]
    GlyphFlagsT GlyphInfoGetGlyphFlags(GlyphInfoT* info);

    [NativeName("hb_glyph_info_get_glyph_flags")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_glyph_info_get_glyph_flags")]
    GlyphFlagsT GlyphInfoGetGlyphFlags(Ref<GlyphInfoT> info);

    [NativeName("hb_language_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_from_string")]
    LanguageImplTHandle LanguageFromString(sbyte* str, int len);

    [NativeName("hb_language_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_from_string")]
    LanguageImplTHandle LanguageFromString(Ref<sbyte> str, int len);

    [NativeName("hb_language_get_default")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_get_default")]
    LanguageImplTHandle LanguageGetDefault();

    [NativeName("hb_language_matches")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_matches")]
    int LanguageMatches(LanguageImplTHandle language, LanguageImplTHandle specific);

    [NativeName("hb_language_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_to_string")]
    Ptr<sbyte> LanguageToString(LanguageImplTHandle language);

    [NativeName("hb_language_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_language_to_string")]
    sbyte* LanguageToStringRaw(LanguageImplTHandle language);

    [NativeName("hb_malloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_malloc")]
    Ptr Malloc(nuint size);

    [NativeName("hb_malloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_malloc")]
    void* MallocRaw(nuint size);

    [NativeName("hb_map_allocation_successful")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_allocation_successful")]
    int MapAllocationSuccessful(MapTHandle map);

    [NativeName("hb_map_clear")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_clear")]
    void MapClear(MapTHandle map);

    [NativeName("hb_map_copy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_copy")]
    MapTHandle MapCopy(MapTHandle map);

    [NativeName("hb_map_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_create")]
    MapTHandle MapCreate();

    [NativeName("hb_map_del")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_del")]
    void MapDel(MapTHandle map, uint key);

    [NativeName("hb_map_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_destroy")]
    void MapDestroy(MapTHandle map);

    [NativeName("hb_map_get")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_get")]
    uint MapGet(MapTHandle map, uint key);

    [NativeName("hb_map_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_empty")]
    MapTHandle MapGetEmpty();

    [NativeName("hb_map_get_population")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_population")]
    uint MapGetPopulation(MapTHandle map);

    [NativeName("hb_map_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_user_data")]
    void* MapGetUserData(MapTHandle map, UserDataKeyT* key);

    [NativeName("hb_map_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_get_user_data")]
    Ptr MapGetUserData(MapTHandle map, Ref<UserDataKeyT> key);

    [NativeName("hb_map_has")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_has")]
    int MapHas(MapTHandle map, uint key);

    [NativeName("hb_map_hash")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_hash")]
    uint MapHash(MapTHandle map);

    [NativeName("hb_map_is_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_is_empty")]
    int MapIsEmpty(MapTHandle map);

    [NativeName("hb_map_is_equal")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_is_equal")]
    int MapIsEqual(MapTHandle map, MapTHandle other);

    [NativeName("hb_map_keys")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_keys")]
    void MapKeys(MapTHandle map, SetTHandle keys);

    [NativeName("hb_map_next")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_next")]
    int MapNext(MapTHandle map, int* idx, uint* key, uint* value);

    [NativeName("hb_map_next")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_next")]
    int MapNext(MapTHandle map, Ref<int> idx, Ref<uint> key, Ref<uint> value);

    [NativeName("hb_map_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_reference")]
    MapTHandle MapReference(MapTHandle map);

    [NativeName("hb_map_set")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_set")]
    void MapSet(MapTHandle map, uint key, uint value);

    [NativeName("hb_map_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_set_user_data")]
    int MapSetUserData(
        MapTHandle map,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_map_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_set_user_data")]
    int MapSetUserData(
        MapTHandle map,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_map_update")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_update")]
    void MapUpdate(MapTHandle map, MapTHandle other);

    [NativeName("hb_map_values")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_map_values")]
    void MapValues(MapTHandle map, SetTHandle values);

    [NativeName("hb_paint_color")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color")]
    void PaintColor(PaintFuncsTHandle funcs, void* paint_data, int is_foreground, uint color);

    [NativeName("hb_paint_color")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color")]
    void PaintColor(PaintFuncsTHandle funcs, Ref paint_data, int is_foreground, uint color);

    [NativeName("hb_paint_color_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color_glyph")]
    int PaintColorGlyph(PaintFuncsTHandle funcs, void* paint_data, uint glyph, FontTHandle font);

    [NativeName("hb_paint_color_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_color_glyph")]
    int PaintColorGlyph(PaintFuncsTHandle funcs, Ref paint_data, uint glyph, FontTHandle font);

    [NativeName("hb_paint_custom_palette_color")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_custom_palette_color")]
    int PaintCustomPaletteColor(
        PaintFuncsTHandle funcs,
        void* paint_data,
        uint color_index,
        uint* color
    );

    [NativeName("hb_paint_custom_palette_color")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_custom_palette_color")]
    int PaintCustomPaletteColor(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        uint color_index,
        Ref<uint> color
    );

    [NativeName("hb_paint_funcs_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_create")]
    PaintFuncsTHandle PaintFuncsCreate();

    [NativeName("hb_paint_funcs_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_destroy")]
    void PaintFuncsDestroy(PaintFuncsTHandle funcs);

    [NativeName("hb_paint_funcs_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_empty")]
    PaintFuncsTHandle PaintFuncsGetEmpty();

    [NativeName("hb_paint_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_user_data")]
    void* PaintFuncsGetUserData(PaintFuncsTHandle funcs, UserDataKeyT* key);

    [NativeName("hb_paint_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_get_user_data")]
    Ptr PaintFuncsGetUserData(PaintFuncsTHandle funcs, Ref<UserDataKeyT> key);

    [NativeName("hb_paint_funcs_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_is_immutable")]
    int PaintFuncsIsImmutable(PaintFuncsTHandle funcs);

    [NativeName("hb_paint_funcs_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_make_immutable")]
    void PaintFuncsMakeImmutable(PaintFuncsTHandle funcs);

    [NativeName("hb_paint_funcs_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_reference")]
    PaintFuncsTHandle PaintFuncsReference(PaintFuncsTHandle funcs);

    [NativeName("hb_paint_funcs_set_color_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_func")]
    void PaintFuncsSetColorFunc(
        PaintFuncsTHandle funcs,
        PaintColorFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_color_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_func")]
    void PaintFuncsSetColorFunc(
        PaintFuncsTHandle funcs,
        PaintColorFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_color_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
    void PaintFuncsSetColorGlyphFunc(
        PaintFuncsTHandle funcs,
        PaintColorGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_color_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
    void PaintFuncsSetColorGlyphFunc(
        PaintFuncsTHandle funcs,
        PaintColorGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_custom_palette_color_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
    void PaintFuncsSetCustomPaletteColorFunc(
        PaintFuncsTHandle funcs,
        PaintCustomPaletteColorFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_custom_palette_color_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
    void PaintFuncsSetCustomPaletteColorFunc(
        PaintFuncsTHandle funcs,
        PaintCustomPaletteColorFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_image_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_image_func")]
    void PaintFuncsSetImageFunc(
        PaintFuncsTHandle funcs,
        PaintImageFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_image_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_image_func")]
    void PaintFuncsSetImageFunc(
        PaintFuncsTHandle funcs,
        PaintImageFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_linear_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
    void PaintFuncsSetLinearGradientFunc(
        PaintFuncsTHandle funcs,
        PaintLinearGradientFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_linear_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
    void PaintFuncsSetLinearGradientFunc(
        PaintFuncsTHandle funcs,
        PaintLinearGradientFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_clip_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
    void PaintFuncsSetPopClipFunc(
        PaintFuncsTHandle funcs,
        PaintPopClipFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_clip_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
    void PaintFuncsSetPopClipFunc(
        PaintFuncsTHandle funcs,
        PaintPopClipFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_group_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_group_func")]
    void PaintFuncsSetPopGroupFunc(
        PaintFuncsTHandle funcs,
        PaintPopGroupFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_group_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_group_func")]
    void PaintFuncsSetPopGroupFunc(
        PaintFuncsTHandle funcs,
        PaintPopGroupFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_transform_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
    void PaintFuncsSetPopTransformFunc(
        PaintFuncsTHandle funcs,
        PaintPopTransformFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_pop_transform_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
    void PaintFuncsSetPopTransformFunc(
        PaintFuncsTHandle funcs,
        PaintPopTransformFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_clip_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
    void PaintFuncsSetPushClipGlyphFunc(
        PaintFuncsTHandle funcs,
        PaintPushClipGlyphFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_clip_glyph_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
    void PaintFuncsSetPushClipGlyphFunc(
        PaintFuncsTHandle funcs,
        PaintPushClipGlyphFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_clip_rectangle_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
    void PaintFuncsSetPushClipRectangleFunc(
        PaintFuncsTHandle funcs,
        PaintPushClipRectangleFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_clip_rectangle_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
    void PaintFuncsSetPushClipRectangleFunc(
        PaintFuncsTHandle funcs,
        PaintPushClipRectangleFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_group_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_group_func")]
    void PaintFuncsSetPushGroupFunc(
        PaintFuncsTHandle funcs,
        PaintPushGroupFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_group_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_group_func")]
    void PaintFuncsSetPushGroupFunc(
        PaintFuncsTHandle funcs,
        PaintPushGroupFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_transform_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_transform_func")]
    void PaintFuncsSetPushTransformFunc(
        PaintFuncsTHandle funcs,
        PaintPushTransformFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_push_transform_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_push_transform_func")]
    void PaintFuncsSetPushTransformFunc(
        PaintFuncsTHandle funcs,
        PaintPushTransformFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_radial_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
    void PaintFuncsSetRadialGradientFunc(
        PaintFuncsTHandle funcs,
        PaintRadialGradientFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_radial_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
    void PaintFuncsSetRadialGradientFunc(
        PaintFuncsTHandle funcs,
        PaintRadialGradientFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_sweep_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
    void PaintFuncsSetSweepGradientFunc(
        PaintFuncsTHandle funcs,
        PaintSweepGradientFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_sweep_gradient_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
    void PaintFuncsSetSweepGradientFunc(
        PaintFuncsTHandle funcs,
        PaintSweepGradientFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_paint_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_user_data")]
    int PaintFuncsSetUserData(
        PaintFuncsTHandle funcs,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_paint_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_funcs_set_user_data")]
    int PaintFuncsSetUserData(
        PaintFuncsTHandle funcs,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_paint_image")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_image")]
    void PaintImage(
        PaintFuncsTHandle funcs,
        void* paint_data,
        BlobTHandle image,
        uint width,
        uint height,
        uint format,
        float slant,
        GlyphExtentsT* extents
    );

    [NativeName("hb_paint_image")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_image")]
    void PaintImage(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        BlobTHandle image,
        uint width,
        uint height,
        uint format,
        float slant,
        Ref<GlyphExtentsT> extents
    );

    [NativeName("hb_paint_linear_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_linear_gradient")]
    void PaintLinearGradient(
        PaintFuncsTHandle funcs,
        void* paint_data,
        ColorLineT* color_line,
        float x0,
        float y0,
        float x1,
        float y1,
        float x2,
        float y2
    );

    [NativeName("hb_paint_linear_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_linear_gradient")]
    void PaintLinearGradient(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        Ref<ColorLineT> color_line,
        float x0,
        float y0,
        float x1,
        float y1,
        float x2,
        float y2
    );

    [NativeName("hb_paint_pop_clip")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_clip")]
    void PaintPopClip(PaintFuncsTHandle funcs, void* paint_data);

    [NativeName("hb_paint_pop_clip")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_clip")]
    void PaintPopClip(PaintFuncsTHandle funcs, Ref paint_data);

    [NativeName("hb_paint_pop_group")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_group")]
    void PaintPopGroup(PaintFuncsTHandle funcs, void* paint_data, PaintCompositeModeT mode);

    [NativeName("hb_paint_pop_group")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_group")]
    void PaintPopGroup(PaintFuncsTHandle funcs, Ref paint_data, PaintCompositeModeT mode);

    [NativeName("hb_paint_pop_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_transform")]
    void PaintPopTransform(PaintFuncsTHandle funcs, void* paint_data);

    [NativeName("hb_paint_pop_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_pop_transform")]
    void PaintPopTransform(PaintFuncsTHandle funcs, Ref paint_data);

    [NativeName("hb_paint_push_clip_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_glyph")]
    void PaintPushClipGlyph(
        PaintFuncsTHandle funcs,
        void* paint_data,
        uint glyph,
        FontTHandle font
    );

    [NativeName("hb_paint_push_clip_glyph")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_glyph")]
    void PaintPushClipGlyph(PaintFuncsTHandle funcs, Ref paint_data, uint glyph, FontTHandle font);

    [NativeName("hb_paint_push_clip_rectangle")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_rectangle")]
    void PaintPushClipRectangle(
        PaintFuncsTHandle funcs,
        void* paint_data,
        float xmin,
        float ymin,
        float xmax,
        float ymax
    );

    [NativeName("hb_paint_push_clip_rectangle")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_clip_rectangle")]
    void PaintPushClipRectangle(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        float xmin,
        float ymin,
        float xmax,
        float ymax
    );

    [NativeName("hb_paint_push_font_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_font_transform")]
    void PaintPushFontTransform(PaintFuncsTHandle funcs, void* paint_data, FontTHandle font);

    [NativeName("hb_paint_push_font_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_font_transform")]
    void PaintPushFontTransform(PaintFuncsTHandle funcs, Ref paint_data, FontTHandle font);

    [NativeName("hb_paint_push_group")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_group")]
    void PaintPushGroup(PaintFuncsTHandle funcs, void* paint_data);

    [NativeName("hb_paint_push_group")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_group")]
    void PaintPushGroup(PaintFuncsTHandle funcs, Ref paint_data);

    [NativeName("hb_paint_push_inverse_font_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_inverse_font_transform")]
    void PaintPushInverseFontTransform(PaintFuncsTHandle funcs, void* paint_data, FontTHandle font);

    [NativeName("hb_paint_push_inverse_font_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_inverse_font_transform")]
    void PaintPushInverseFontTransform(PaintFuncsTHandle funcs, Ref paint_data, FontTHandle font);

    [NativeName("hb_paint_push_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_transform")]
    void PaintPushTransform(
        PaintFuncsTHandle funcs,
        void* paint_data,
        float xx,
        float yx,
        float xy,
        float yy,
        float dx,
        float dy
    );

    [NativeName("hb_paint_push_transform")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_push_transform")]
    void PaintPushTransform(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        float xx,
        float yx,
        float xy,
        float yy,
        float dx,
        float dy
    );

    [NativeName("hb_paint_radial_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_radial_gradient")]
    void PaintRadialGradient(
        PaintFuncsTHandle funcs,
        void* paint_data,
        ColorLineT* color_line,
        float x0,
        float y0,
        float r0,
        float x1,
        float y1,
        float r1
    );

    [NativeName("hb_paint_radial_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_radial_gradient")]
    void PaintRadialGradient(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        Ref<ColorLineT> color_line,
        float x0,
        float y0,
        float r0,
        float x1,
        float y1,
        float r1
    );

    [NativeName("hb_paint_sweep_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_sweep_gradient")]
    void PaintSweepGradient(
        PaintFuncsTHandle funcs,
        void* paint_data,
        ColorLineT* color_line,
        float x0,
        float y0,
        float start_angle,
        float end_angle
    );

    [NativeName("hb_paint_sweep_gradient")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_paint_sweep_gradient")]
    void PaintSweepGradient(
        PaintFuncsTHandle funcs,
        Ref paint_data,
        Ref<ColorLineT> color_line,
        float x0,
        float y0,
        float start_angle,
        float end_angle
    );

    [NativeName("hb_realloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_realloc")]
    void* Realloc(void* ptr, nuint size);

    [NativeName("hb_realloc")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_realloc")]
    Ptr Realloc(Ref ptr, nuint size);

    [NativeName("hb_script_from_iso15924_tag")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_iso15924_tag")]
    ScriptT ScriptFromIso15924Tag(uint tag);

    [NativeName("hb_script_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_string")]
    ScriptT ScriptFromString(sbyte* str, int len);

    [NativeName("hb_script_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_script_from_string")]
    ScriptT ScriptFromString(Ref<sbyte> str, int len);

    [NativeName("hb_script_get_horizontal_direction")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_script_get_horizontal_direction")]
    DirectionT ScriptGetHorizontalDirection(ScriptT script);

    [NativeName("hb_script_to_iso15924_tag")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_script_to_iso15924_tag")]
    uint ScriptToIso15924Tag(ScriptT script);

    [NativeName("hb_segment_properties_equal")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_equal")]
    int SegmentPropertiesEqual(SegmentPropertiesT* a, SegmentPropertiesT* b);

    [NativeName("hb_segment_properties_equal")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_equal")]
    int SegmentPropertiesEqual(Ref<SegmentPropertiesT> a, Ref<SegmentPropertiesT> b);

    [NativeName("hb_segment_properties_hash")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_hash")]
    uint SegmentPropertiesHash(SegmentPropertiesT* p);

    [NativeName("hb_segment_properties_hash")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_hash")]
    uint SegmentPropertiesHash(Ref<SegmentPropertiesT> p);

    [NativeName("hb_segment_properties_overlay")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_overlay")]
    void SegmentPropertiesOverlay(SegmentPropertiesT* p, SegmentPropertiesT* src);

    [NativeName("hb_segment_properties_overlay")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_segment_properties_overlay")]
    void SegmentPropertiesOverlay(Ref<SegmentPropertiesT> p, Ref<SegmentPropertiesT> src);

    [NativeName("hb_set_add")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_add")]
    void SetAdd(SetTHandle set, uint codepoint);

    [NativeName("hb_set_add_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_range")]
    void SetAddRange(SetTHandle set, uint first, uint last);

    [NativeName("hb_set_add_sorted_array")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_sorted_array")]
    void SetAddSortedArray(SetTHandle set, uint* sorted_codepoints, uint num_codepoints);

    [NativeName("hb_set_add_sorted_array")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_add_sorted_array")]
    void SetAddSortedArray(SetTHandle set, Ref<uint> sorted_codepoints, uint num_codepoints);

    [NativeName("hb_set_allocation_successful")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_allocation_successful")]
    int SetAllocationSuccessful(SetTHandle set);

    [NativeName("hb_set_clear")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_clear")]
    void SetClear(SetTHandle set);

    [NativeName("hb_set_copy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_copy")]
    SetTHandle SetCopy(SetTHandle set);

    [NativeName("hb_set_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_create")]
    SetTHandle SetCreate();

    [NativeName("hb_set_del")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_del")]
    void SetDel(SetTHandle set, uint codepoint);

    [NativeName("hb_set_del_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_del_range")]
    void SetDelRange(SetTHandle set, uint first, uint last);

    [NativeName("hb_set_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_destroy")]
    void SetDestroy(SetTHandle set);

    [NativeName("hb_set_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_empty")]
    SetTHandle SetGetEmpty();

    [NativeName("hb_set_get_max")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_max")]
    uint SetGetMax(SetTHandle set);

    [NativeName("hb_set_get_min")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_min")]
    uint SetGetMin(SetTHandle set);

    [NativeName("hb_set_get_population")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_population")]
    uint SetGetPopulation(SetTHandle set);

    [NativeName("hb_set_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_user_data")]
    void* SetGetUserData(SetTHandle set, UserDataKeyT* key);

    [NativeName("hb_set_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_get_user_data")]
    Ptr SetGetUserData(SetTHandle set, Ref<UserDataKeyT> key);

    [NativeName("hb_set_has")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_has")]
    int SetHas(SetTHandle set, uint codepoint);

    [NativeName("hb_set_hash")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_hash")]
    uint SetHash(SetTHandle set);

    [NativeName("hb_set_intersect")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_intersect")]
    void SetIntersect(SetTHandle set, SetTHandle other);

    [NativeName("hb_set_invert")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_invert")]
    void SetInvert(SetTHandle set);

    [NativeName("hb_set_is_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_empty")]
    int SetIsEmpty(SetTHandle set);

    [NativeName("hb_set_is_equal")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_equal")]
    int SetIsEqual(SetTHandle set, SetTHandle other);

    [NativeName("hb_set_is_inverted")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_inverted")]
    int SetIsInverted(SetTHandle set);

    [NativeName("hb_set_is_subset")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_is_subset")]
    int SetIsSubset(SetTHandle set, SetTHandle larger_set);

    [NativeName("hb_set_next")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next")]
    int SetNext(SetTHandle set, uint* codepoint);

    [NativeName("hb_set_next")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next")]
    int SetNext(SetTHandle set, Ref<uint> codepoint);

    [NativeName("hb_set_next_many")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_many")]
    uint SetNextMany(SetTHandle set, uint codepoint, uint* @out, uint size);

    [NativeName("hb_set_next_many")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_many")]
    uint SetNextMany(SetTHandle set, uint codepoint, Ref<uint> @out, uint size);

    [NativeName("hb_set_next_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_range")]
    int SetNextRange(SetTHandle set, uint* first, uint* last);

    [NativeName("hb_set_next_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_next_range")]
    int SetNextRange(SetTHandle set, Ref<uint> first, Ref<uint> last);

    [NativeName("hb_set_previous")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous")]
    int SetPrevious(SetTHandle set, uint* codepoint);

    [NativeName("hb_set_previous")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous")]
    int SetPrevious(SetTHandle set, Ref<uint> codepoint);

    [NativeName("hb_set_previous_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous_range")]
    int SetPreviousRange(SetTHandle set, uint* first, uint* last);

    [NativeName("hb_set_previous_range")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_previous_range")]
    int SetPreviousRange(SetTHandle set, Ref<uint> first, Ref<uint> last);

    [NativeName("hb_set_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_reference")]
    SetTHandle SetReference(SetTHandle set);

    [NativeName("hb_set_set")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_set")]
    void SetSet(SetTHandle set, SetTHandle other);

    [NativeName("hb_set_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_set_user_data")]
    int SetSetUserData(
        SetTHandle set,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_set_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_set_user_data")]
    int SetSetUserData(
        SetTHandle set,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_set_subtract")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_subtract")]
    void SetSubtract(SetTHandle set, SetTHandle other);

    [NativeName("hb_set_symmetric_difference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_symmetric_difference")]
    void SetSymmetricDifference(SetTHandle set, SetTHandle other);

    [NativeName("hb_set_union")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_set_union")]
    void SetUnion(SetTHandle set, SetTHandle other);

    [NativeName("hb_shape")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape")]
    void Shape(FontTHandle font, BufferTHandle buffer, FeatureT* features, uint num_features);

    [NativeName("hb_shape")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape")]
    void Shape(FontTHandle font, BufferTHandle buffer, Ref<FeatureT> features, uint num_features);

    [NativeName("hb_shape_full")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_full")]
    int ShapeFull(
        FontTHandle font,
        BufferTHandle buffer,
        FeatureT* features,
        uint num_features,
        sbyte** shaper_list
    );

    [NativeName("hb_shape_full")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_full")]
    int ShapeFull(
        FontTHandle font,
        BufferTHandle buffer,
        Ref<FeatureT> features,
        uint num_features,
        Ref2D<sbyte> shaper_list
    );

    [NativeName("hb_shape_list_shapers")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_list_shapers")]
    Ptr2D<sbyte> ShapeListShapers();

    [NativeName("hb_shape_list_shapers")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_list_shapers")]
    sbyte** ShapeListShapersRaw();

    [NativeName("hb_shape_plan_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create")]
    ShapePlanTHandle ShapePlanCreate(
        FaceTHandle face,
        SegmentPropertiesT* props,
        FeatureT* user_features,
        uint num_user_features,
        sbyte** shaper_list
    );

    [NativeName("hb_shape_plan_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create")]
    ShapePlanTHandle ShapePlanCreate(
        FaceTHandle face,
        Ref<SegmentPropertiesT> props,
        Ref<FeatureT> user_features,
        uint num_user_features,
        Ref2D<sbyte> shaper_list
    );

    [NativeName("hb_shape_plan_create_cached")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached")]
    ShapePlanTHandle ShapePlanCreateCached(
        FaceTHandle face,
        SegmentPropertiesT* props,
        FeatureT* user_features,
        uint num_user_features,
        sbyte** shaper_list
    );

    [NativeName("hb_shape_plan_create_cached")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached")]
    ShapePlanTHandle ShapePlanCreateCached(
        FaceTHandle face,
        Ref<SegmentPropertiesT> props,
        Ref<FeatureT> user_features,
        uint num_user_features,
        Ref2D<sbyte> shaper_list
    );

    [NativeName("hb_shape_plan_create_cached2")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached2")]
    ShapePlanTHandle ShapePlanCreateCached2(
        FaceTHandle face,
        SegmentPropertiesT* props,
        FeatureT* user_features,
        uint num_user_features,
        int* coords,
        uint num_coords,
        sbyte** shaper_list
    );

    [NativeName("hb_shape_plan_create_cached2")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create_cached2")]
    ShapePlanTHandle ShapePlanCreateCached2(
        FaceTHandle face,
        Ref<SegmentPropertiesT> props,
        Ref<FeatureT> user_features,
        uint num_user_features,
        Ref<int> coords,
        uint num_coords,
        Ref2D<sbyte> shaper_list
    );

    [NativeName("hb_shape_plan_create2")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create2")]
    ShapePlanTHandle ShapePlanCreate2(
        FaceTHandle face,
        SegmentPropertiesT* props,
        FeatureT* user_features,
        uint num_user_features,
        int* coords,
        uint num_coords,
        sbyte** shaper_list
    );

    [NativeName("hb_shape_plan_create2")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_create2")]
    ShapePlanTHandle ShapePlanCreate2(
        FaceTHandle face,
        Ref<SegmentPropertiesT> props,
        Ref<FeatureT> user_features,
        uint num_user_features,
        Ref<int> coords,
        uint num_coords,
        Ref2D<sbyte> shaper_list
    );

    [NativeName("hb_shape_plan_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_destroy")]
    void ShapePlanDestroy(ShapePlanTHandle shape_plan);

    [NativeName("hb_shape_plan_execute")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_execute")]
    int ShapePlanExecute(
        ShapePlanTHandle shape_plan,
        FontTHandle font,
        BufferTHandle buffer,
        FeatureT* features,
        uint num_features
    );

    [NativeName("hb_shape_plan_execute")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_execute")]
    int ShapePlanExecute(
        ShapePlanTHandle shape_plan,
        FontTHandle font,
        BufferTHandle buffer,
        Ref<FeatureT> features,
        uint num_features
    );

    [NativeName("hb_shape_plan_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_empty")]
    ShapePlanTHandle ShapePlanGetEmpty();

    [NativeName("hb_shape_plan_get_shaper")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_shaper")]
    Ptr<sbyte> ShapePlanGetShaper(ShapePlanTHandle shape_plan);

    [NativeName("hb_shape_plan_get_shaper")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_shaper")]
    sbyte* ShapePlanGetShaperRaw(ShapePlanTHandle shape_plan);

    [NativeName("hb_shape_plan_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_user_data")]
    void* ShapePlanGetUserData(ShapePlanTHandle shape_plan, UserDataKeyT* key);

    [NativeName("hb_shape_plan_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_get_user_data")]
    Ptr ShapePlanGetUserData(ShapePlanTHandle shape_plan, Ref<UserDataKeyT> key);

    [NativeName("hb_shape_plan_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_reference")]
    ShapePlanTHandle ShapePlanReference(ShapePlanTHandle shape_plan);

    [NativeName("hb_shape_plan_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_set_user_data")]
    int ShapePlanSetUserData(
        ShapePlanTHandle shape_plan,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_shape_plan_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_shape_plan_set_user_data")]
    int ShapePlanSetUserData(
        ShapePlanTHandle shape_plan,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_style_get_value")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_style_get_value")]
    float StyleGetValue(FontTHandle font, StyleTagT style_tag);

    [NativeName("hb_tag_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_tag_from_string")]
    uint TagFromString(sbyte* str, int len);

    [NativeName("hb_tag_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_tag_from_string")]
    uint TagFromString(Ref<sbyte> str, int len);

    [NativeName("hb_tag_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_tag_to_string")]
    void TagToString(uint tag, sbyte* buf);

    [NativeName("hb_tag_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_tag_to_string")]
    void TagToString(uint tag, Ref<sbyte> buf);

    [NativeName("hb_unicode_combining_class")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_combining_class")]
    UnicodeCombiningClassT UnicodeCombiningClass(UnicodeFuncsTHandle ufuncs, uint unicode);

    [NativeName("hb_unicode_compose")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_compose")]
    int UnicodeCompose(UnicodeFuncsTHandle ufuncs, uint a, uint b, uint* ab);

    [NativeName("hb_unicode_compose")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_compose")]
    int UnicodeCompose(UnicodeFuncsTHandle ufuncs, uint a, uint b, Ref<uint> ab);

    [NativeName("hb_unicode_decompose")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose")]
    int UnicodeDecompose(UnicodeFuncsTHandle ufuncs, uint ab, uint* a, uint* b);

    [NativeName("hb_unicode_decompose")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose")]
    int UnicodeDecompose(UnicodeFuncsTHandle ufuncs, uint ab, Ref<uint> a, Ref<uint> b);

    [NativeName("hb_unicode_decompose_compatibility")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose_compatibility")]
    uint UnicodeDecomposeCompatibility(UnicodeFuncsTHandle ufuncs, uint u, uint* decomposed);

    [NativeName("hb_unicode_decompose_compatibility")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_decompose_compatibility")]
    uint UnicodeDecomposeCompatibility(UnicodeFuncsTHandle ufuncs, uint u, Ref<uint> decomposed);

    [NativeName("hb_unicode_eastasian_width")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_eastasian_width")]
    uint UnicodeEastasianWidth(UnicodeFuncsTHandle ufuncs, uint unicode);

    [NativeName("hb_unicode_funcs_create")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_create")]
    UnicodeFuncsTHandle UnicodeFuncsCreate(UnicodeFuncsTHandle parent);

    [NativeName("hb_unicode_funcs_destroy")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_destroy")]
    void UnicodeFuncsDestroy(UnicodeFuncsTHandle ufuncs);

    [NativeName("hb_unicode_funcs_get_default")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_default")]
    UnicodeFuncsTHandle UnicodeFuncsGetDefault();

    [NativeName("hb_unicode_funcs_get_empty")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_empty")]
    UnicodeFuncsTHandle UnicodeFuncsGetEmpty();

    [NativeName("hb_unicode_funcs_get_parent")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_parent")]
    UnicodeFuncsTHandle UnicodeFuncsGetParent(UnicodeFuncsTHandle ufuncs);

    [NativeName("hb_unicode_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_user_data")]
    void* UnicodeFuncsGetUserData(UnicodeFuncsTHandle ufuncs, UserDataKeyT* key);

    [NativeName("hb_unicode_funcs_get_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_get_user_data")]
    Ptr UnicodeFuncsGetUserData(UnicodeFuncsTHandle ufuncs, Ref<UserDataKeyT> key);

    [NativeName("hb_unicode_funcs_is_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_is_immutable")]
    int UnicodeFuncsIsImmutable(UnicodeFuncsTHandle ufuncs);

    [NativeName("hb_unicode_funcs_make_immutable")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_make_immutable")]
    void UnicodeFuncsMakeImmutable(UnicodeFuncsTHandle ufuncs);

    [NativeName("hb_unicode_funcs_reference")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_reference")]
    UnicodeFuncsTHandle UnicodeFuncsReference(UnicodeFuncsTHandle ufuncs);

    [NativeName("hb_unicode_funcs_set_combining_class_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
    void UnicodeFuncsSetCombiningClassFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeCombiningClassFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_combining_class_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
    void UnicodeFuncsSetCombiningClassFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeCombiningClassFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_compose_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_compose_func")]
    void UnicodeFuncsSetComposeFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeComposeFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_compose_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_compose_func")]
    void UnicodeFuncsSetComposeFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeComposeFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_decompose_compatibility_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func")]
    void UnicodeFuncsSetDecomposeCompatibilityFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeDecomposeCompatibilityFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_decompose_compatibility_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func")]
    void UnicodeFuncsSetDecomposeCompatibilityFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeDecomposeCompatibilityFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_decompose_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_func")]
    void UnicodeFuncsSetDecomposeFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeDecomposeFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_decompose_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_decompose_func")]
    void UnicodeFuncsSetDecomposeFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeDecomposeFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_eastasian_width_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
    void UnicodeFuncsSetEastasianWidthFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeEastasianWidthFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_eastasian_width_func")]
    [Obsolete]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
    void UnicodeFuncsSetEastasianWidthFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeEastasianWidthFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_general_category_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_general_category_func")]
    void UnicodeFuncsSetGeneralCategoryFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeGeneralCategoryFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_general_category_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_general_category_func")]
    void UnicodeFuncsSetGeneralCategoryFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeGeneralCategoryFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_mirroring_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
    void UnicodeFuncsSetMirroringFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeMirroringFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_mirroring_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
    void UnicodeFuncsSetMirroringFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeMirroringFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_script_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_script_func")]
    void UnicodeFuncsSetScriptFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeScriptFuncT func,
        void* user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_script_func")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_script_func")]
    void UnicodeFuncsSetScriptFunc(
        UnicodeFuncsTHandle ufuncs,
        UnicodeScriptFuncT func,
        Ref user_data,
        DestroyFuncT destroy
    );

    [NativeName("hb_unicode_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_user_data")]
    int UnicodeFuncsSetUserData(
        UnicodeFuncsTHandle ufuncs,
        UserDataKeyT* key,
        void* data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_unicode_funcs_set_user_data")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_funcs_set_user_data")]
    int UnicodeFuncsSetUserData(
        UnicodeFuncsTHandle ufuncs,
        Ref<UserDataKeyT> key,
        Ref data,
        DestroyFuncT destroy,
        int replace
    );

    [NativeName("hb_unicode_general_category")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_general_category")]
    UnicodeGeneralCategoryT UnicodeGeneralCategory(UnicodeFuncsTHandle ufuncs, uint unicode);

    [NativeName("hb_unicode_mirroring")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_mirroring")]
    uint UnicodeMirroring(UnicodeFuncsTHandle ufuncs, uint unicode);

    [NativeName("hb_unicode_script")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_unicode_script")]
    ScriptT UnicodeScript(UnicodeFuncsTHandle ufuncs, uint unicode);

    [NativeName("hb_variation_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_variation_from_string")]
    int VariationFromString(sbyte* str, int len, VariationT* variation);

    [NativeName("hb_variation_from_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_variation_from_string")]
    int VariationFromString(Ref<sbyte> str, int len, Ref<VariationT> variation);

    [NativeName("hb_variation_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_variation_to_string")]
    void VariationToString(VariationT* variation, sbyte* buf, uint size);

    [NativeName("hb_variation_to_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_variation_to_string")]
    void VariationToString(Ref<VariationT> variation, Ref<sbyte> buf, uint size);

    [NativeName("hb_version")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_version")]
    void Version(uint* major, uint* minor, uint* micro);

    [NativeName("hb_version")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_version")]
    void Version(Ref<uint> major, Ref<uint> minor, Ref<uint> micro);

    [NativeName("hb_version_atleast")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_version_atleast")]
    int VersionAtleast(uint major, uint minor, uint micro);

    [NativeName("hb_version_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_version_string")]
    Ptr<sbyte> VersionString();

    [NativeName("hb_version_string")]
    [NativeFunction("harfbuzz", EntryPoint = "hb_version_string")]
    sbyte* VersionStringRaw();
}
