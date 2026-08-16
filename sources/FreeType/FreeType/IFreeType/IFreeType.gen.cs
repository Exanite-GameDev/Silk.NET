// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

public unsafe partial interface IFreeType
{
    public partial interface Static
    {
        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        static abstract int AttachFile(FaceRec* face, sbyte* filepathname);

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        static abstract int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        static abstract int AttachStream(FaceRec* face, OpenArgs* parameters);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        static abstract int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters);

        [NativeName("FT_CeilFix")]
        [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
        static abstract nint CeilFix(nint a);

        [NativeName("FT_DivFix")]
        [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
        static abstract nint DivFix(nint a, nint b);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        static abstract int DoneFace(FaceRec* face);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        static abstract int DoneFace(Ref<FaceRec> face);

        [NativeName("FT_Done_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
        static abstract int DoneFreeType(LibraryRecHandle library);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        static abstract Ptr<sbyte> ErrorString(int error_code);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        static abstract sbyte* ErrorStringRaw(int error_code);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        static abstract byte FaceCheckTrueTypePatents(FaceRec* face);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        static abstract byte FaceCheckTrueTypePatents(Ref<FaceRec> face);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        static abstract uint* FaceGetCharsOfVariant(FaceRec* face, nuint variantSelector);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        static abstract Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, nuint variantSelector);

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        static abstract UInt FaceGetCharVariantIndex(
            FaceRec* face,
            nuint charcode,
            nuint variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        static abstract UInt FaceGetCharVariantIndex(
            Ref<FaceRec> face,
            nuint charcode,
            nuint variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        static abstract Int FaceGetCharVariantIsDefault(
            FaceRec* face,
            nuint charcode,
            nuint variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        static abstract Int FaceGetCharVariantIsDefault(
            Ref<FaceRec> face,
            nuint charcode,
            nuint variantSelector
        );

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        static abstract uint* FaceGetVariantSelectors(FaceRec* face);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        static abstract Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        static abstract uint* FaceGetVariantsOfChar(FaceRec* face, nuint charcode);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        static abstract Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, nuint charcode);

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        static abstract int FaceProperties(
            FaceRec* face,
            UInt num_properties,
            Parameter* properties
        );

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        static abstract int FaceProperties(
            Ref<FaceRec> face,
            UInt num_properties,
            Ref<Parameter> properties
        );

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        static abstract byte FaceSetUnpatentedHinting(FaceRec* face, byte value);

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        static abstract byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value);

        [NativeName("FT_FloorFix")]
        [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
        static abstract nint FloorFix(nint a);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        static abstract UInt GetCharIndex(FaceRec* face, nuint charcode);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        static abstract UInt GetCharIndex(Ref<FaceRec> face, nuint charcode);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        static abstract Int GetCharmapIndex(CharMapRec* charmap);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        static abstract Int GetCharmapIndex(Ref<CharMapRec> charmap);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        static abstract nuint GetFirstChar(FaceRec* face, UInt* agindex);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        static abstract nuint GetFirstChar(Ref<FaceRec> face, Ref<UInt> agindex);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        static abstract UShort GetFSTypeFlags(FaceRec* face);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        static abstract UShort GetFSTypeFlags(Ref<FaceRec> face);

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        static abstract int GetGlyphName(
            FaceRec* face,
            UInt glyph_index,
            void* buffer,
            UInt buffer_max
        );

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        static abstract int GetGlyphName(
            Ref<FaceRec> face,
            UInt glyph_index,
            Ref buffer,
            UInt buffer_max
        );

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        static abstract int GetKerning(
            FaceRec* face,
            UInt left_glyph,
            UInt right_glyph,
            UInt kern_mode,
            Vector* akerning
        );

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        static abstract int GetKerning(
            Ref<FaceRec> face,
            UInt left_glyph,
            UInt right_glyph,
            UInt kern_mode,
            Ref<Vector> akerning
        );

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        static abstract UInt GetNameIndex(FaceRec* face, sbyte* glyph_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        static abstract UInt GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        static abstract nuint GetNextChar(FaceRec* face, nuint char_code, UInt* agindex);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        static abstract nuint GetNextChar(Ref<FaceRec> face, nuint char_code, Ref<UInt> agindex);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        static abstract sbyte* GetPostscriptName(FaceRec* face);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        static abstract Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face);

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        static abstract int GetSubGlyphInfo(
            GlyphSlotRec* glyph,
            UInt sub_index,
            Int* p_index,
            UInt* p_flags,
            Int* p_arg1,
            Int* p_arg2,
            Matrix* p_transform
        );

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        static abstract int GetSubGlyphInfo(
            Ref<GlyphSlotRec> glyph,
            UInt sub_index,
            Ref<Int> p_index,
            Ref<UInt> p_flags,
            Ref<Int> p_arg1,
            Ref<Int> p_arg2,
            Ref<Matrix> p_transform
        );

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        static abstract int GetTrackKerning(
            FaceRec* face,
            nint point_size,
            Int degree,
            nint* akerning
        );

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        static abstract int GetTrackKerning(
            Ref<FaceRec> face,
            nint point_size,
            Int degree,
            Ref<nint> akerning
        );

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        static abstract void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        static abstract void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        static abstract int InitFreeType(LibraryRecHandle* alibrary);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        static abstract int InitFreeType(Ref<LibraryRecHandle> alibrary);

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        static abstract void LibraryVersion(
            LibraryRecHandle library,
            Int* amajor,
            Int* aminor,
            Int* apatch
        );

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        static abstract void LibraryVersion(
            LibraryRecHandle library,
            Ref<Int> amajor,
            Ref<Int> aminor,
            Ref<Int> apatch
        );

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        static abstract int LoadChar(FaceRec* face, nuint char_code, int load_flags);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        static abstract int LoadChar(Ref<FaceRec> face, nuint char_code, int load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        static abstract int LoadGlyph(FaceRec* face, UInt glyph_index, int load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        static abstract int LoadGlyph(Ref<FaceRec> face, UInt glyph_index, int load_flags);

        [NativeName("FT_MulDiv")]
        [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
        static abstract nint MulDiv(nint a, nint b, nint c);

        [NativeName("FT_MulFix")]
        [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
        static abstract nint MulFix(nint a, nint b);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        static abstract int NewFace(
            LibraryRecHandle library,
            sbyte* filepathname,
            nint face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        static abstract int NewFace(
            LibraryRecHandle library,
            Ref<sbyte> filepathname,
            nint face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        static abstract int NewMemoryFace(
            LibraryRecHandle library,
            byte* file_base,
            nint file_size,
            nint face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        static abstract int NewMemoryFace(
            LibraryRecHandle library,
            Ref<byte> file_base,
            nint file_size,
            nint face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        static abstract int OpenFace(
            LibraryRecHandle library,
            OpenArgs* args,
            nint face_index,
            FaceRec** aface
        );

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        static abstract int OpenFace(
            LibraryRecHandle library,
            Ref<OpenArgs> args,
            nint face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        static abstract int ReferenceFace(FaceRec* face);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        static abstract int ReferenceFace(Ref<FaceRec> face);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        static abstract int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        static abstract int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        static abstract int RequestSize(FaceRec* face, SizeRequestRec* req);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        static abstract int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req);

        [NativeName("FT_RoundFix")]
        [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
        static abstract nint RoundFix(nint a);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        static abstract int SelectCharmap(FaceRec* face, Encoding encoding);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        static abstract int SelectCharmap(Ref<FaceRec> face, Encoding encoding);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        static abstract int SelectSize(FaceRec* face, Int strike_index);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        static abstract int SelectSize(Ref<FaceRec> face, Int strike_index);

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        static abstract int SetCharSize(
            FaceRec* face,
            nint char_width,
            nint char_height,
            UInt horz_resolution,
            UInt vert_resolution
        );

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        static abstract int SetCharSize(
            Ref<FaceRec> face,
            nint char_width,
            nint char_height,
            UInt horz_resolution,
            UInt vert_resolution
        );

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        static abstract int SetCharmap(FaceRec* face, CharMapRec* charmap);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        static abstract int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        static abstract int SetPixelSizes(FaceRec* face, UInt pixel_width, UInt pixel_height);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        static abstract int SetPixelSizes(Ref<FaceRec> face, UInt pixel_width, UInt pixel_height);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        static abstract void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        static abstract void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        static abstract void VectorTransform(Vector* vector, Matrix* matrix);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        static abstract void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix);
    }

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    int AttachFile(FaceRec* face, sbyte* filepathname);

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname);

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    int AttachStream(FaceRec* face, OpenArgs* parameters);

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters);

    [NativeName("FT_CeilFix")]
    [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
    nint CeilFix(nint a);

    [NativeName("FT_DivFix")]
    [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
    nint DivFix(nint a, nint b);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    int DoneFace(FaceRec* face);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    int DoneFace(Ref<FaceRec> face);

    [NativeName("FT_Done_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
    int DoneFreeType(LibraryRecHandle library);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    Ptr<sbyte> ErrorString(int error_code);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    sbyte* ErrorStringRaw(int error_code);

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    byte FaceCheckTrueTypePatents(FaceRec* face);

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    byte FaceCheckTrueTypePatents(Ref<FaceRec> face);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    uint* FaceGetCharsOfVariant(FaceRec* face, nuint variantSelector);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, nuint variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    UInt FaceGetCharVariantIndex(FaceRec* face, nuint charcode, nuint variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    UInt FaceGetCharVariantIndex(Ref<FaceRec> face, nuint charcode, nuint variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    Int FaceGetCharVariantIsDefault(FaceRec* face, nuint charcode, nuint variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    Int FaceGetCharVariantIsDefault(Ref<FaceRec> face, nuint charcode, nuint variantSelector);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    uint* FaceGetVariantSelectors(FaceRec* face);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    uint* FaceGetVariantsOfChar(FaceRec* face, nuint charcode);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, nuint charcode);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    int FaceProperties(FaceRec* face, UInt num_properties, Parameter* properties);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    int FaceProperties(Ref<FaceRec> face, UInt num_properties, Ref<Parameter> properties);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    byte FaceSetUnpatentedHinting(FaceRec* face, byte value);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value);

    [NativeName("FT_FloorFix")]
    [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
    nint FloorFix(nint a);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    UInt GetCharIndex(FaceRec* face, nuint charcode);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    UInt GetCharIndex(Ref<FaceRec> face, nuint charcode);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    Int GetCharmapIndex(CharMapRec* charmap);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    Int GetCharmapIndex(Ref<CharMapRec> charmap);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    nuint GetFirstChar(FaceRec* face, UInt* agindex);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    nuint GetFirstChar(Ref<FaceRec> face, Ref<UInt> agindex);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    UShort GetFSTypeFlags(FaceRec* face);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    UShort GetFSTypeFlags(Ref<FaceRec> face);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    int GetGlyphName(FaceRec* face, UInt glyph_index, void* buffer, UInt buffer_max);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    int GetGlyphName(Ref<FaceRec> face, UInt glyph_index, Ref buffer, UInt buffer_max);

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    int GetKerning(
        FaceRec* face,
        UInt left_glyph,
        UInt right_glyph,
        UInt kern_mode,
        Vector* akerning
    );

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    int GetKerning(
        Ref<FaceRec> face,
        UInt left_glyph,
        UInt right_glyph,
        UInt kern_mode,
        Ref<Vector> akerning
    );

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    UInt GetNameIndex(FaceRec* face, sbyte* glyph_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    UInt GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    nuint GetNextChar(FaceRec* face, nuint char_code, UInt* agindex);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    nuint GetNextChar(Ref<FaceRec> face, nuint char_code, Ref<UInt> agindex);

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    sbyte* GetPostscriptName(FaceRec* face);

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face);

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    int GetSubGlyphInfo(
        GlyphSlotRec* glyph,
        UInt sub_index,
        Int* p_index,
        UInt* p_flags,
        Int* p_arg1,
        Int* p_arg2,
        Matrix* p_transform
    );

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    int GetSubGlyphInfo(
        Ref<GlyphSlotRec> glyph,
        UInt sub_index,
        Ref<Int> p_index,
        Ref<UInt> p_flags,
        Ref<Int> p_arg1,
        Ref<Int> p_arg2,
        Ref<Matrix> p_transform
    );

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    int GetTrackKerning(FaceRec* face, nint point_size, Int degree, nint* akerning);

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    int GetTrackKerning(Ref<FaceRec> face, nint point_size, Int degree, Ref<nint> akerning);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    int InitFreeType(LibraryRecHandle* alibrary);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    int InitFreeType(Ref<LibraryRecHandle> alibrary);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    void LibraryVersion(LibraryRecHandle library, Int* amajor, Int* aminor, Int* apatch);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    void LibraryVersion(
        LibraryRecHandle library,
        Ref<Int> amajor,
        Ref<Int> aminor,
        Ref<Int> apatch
    );

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    int LoadChar(FaceRec* face, nuint char_code, int load_flags);

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    int LoadChar(Ref<FaceRec> face, nuint char_code, int load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    int LoadGlyph(FaceRec* face, UInt glyph_index, int load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    int LoadGlyph(Ref<FaceRec> face, UInt glyph_index, int load_flags);

    [NativeName("FT_MulDiv")]
    [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
    nint MulDiv(nint a, nint b, nint c);

    [NativeName("FT_MulFix")]
    [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
    nint MulFix(nint a, nint b);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    int NewFace(LibraryRecHandle library, sbyte* filepathname, nint face_index, FaceRec** aface);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    int NewFace(
        LibraryRecHandle library,
        Ref<sbyte> filepathname,
        nint face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    int NewMemoryFace(
        LibraryRecHandle library,
        byte* file_base,
        nint file_size,
        nint face_index,
        FaceRec** aface
    );

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    int NewMemoryFace(
        LibraryRecHandle library,
        Ref<byte> file_base,
        nint file_size,
        nint face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    int OpenFace(LibraryRecHandle library, OpenArgs* args, nint face_index, FaceRec** aface);

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    int OpenFace(
        LibraryRecHandle library,
        Ref<OpenArgs> args,
        nint face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    int ReferenceFace(FaceRec* face);

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    int ReferenceFace(Ref<FaceRec> face);

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode);

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode);

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    int RequestSize(FaceRec* face, SizeRequestRec* req);

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req);

    [NativeName("FT_RoundFix")]
    [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
    nint RoundFix(nint a);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    int SelectCharmap(FaceRec* face, Encoding encoding);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    int SelectCharmap(Ref<FaceRec> face, Encoding encoding);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    int SelectSize(FaceRec* face, Int strike_index);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    int SelectSize(Ref<FaceRec> face, Int strike_index);

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    int SetCharSize(
        FaceRec* face,
        nint char_width,
        nint char_height,
        UInt horz_resolution,
        UInt vert_resolution
    );

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    int SetCharSize(
        Ref<FaceRec> face,
        nint char_width,
        nint char_height,
        UInt horz_resolution,
        UInt vert_resolution
    );

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    int SetCharmap(FaceRec* face, CharMapRec* charmap);

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    int SetPixelSizes(FaceRec* face, UInt pixel_width, UInt pixel_height);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    int SetPixelSizes(Ref<FaceRec> face, UInt pixel_width, UInt pixel_height);

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    void VectorTransform(Vector* vector, Matrix* matrix);

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix);
}
