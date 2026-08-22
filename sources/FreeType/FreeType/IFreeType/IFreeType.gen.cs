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
        [NativeName("FT_Add_Default_Modules")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
        static abstract void AddDefaultModules(LibraryRecHandle library);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        static abstract int AddModule(LibraryRecHandle library, ModuleClass* clazz);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        static abstract int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz);

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
        static abstract long CeilFix(long a);

        [NativeName("FT_DivFix")]
        [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
        static abstract long DivFix(long a, long b);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        static abstract int DoneFace(FaceRec* face);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        static abstract int DoneFace(Ref<FaceRec> face);

        [NativeName("FT_Done_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
        static abstract int DoneFreeType(LibraryRecHandle library);

        [NativeName("FT_Done_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
        static abstract int DoneLibrary(LibraryRecHandle library);

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
        static abstract uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        static abstract Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector);

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        static abstract uint FaceGetCharVariantIndex(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        static abstract uint FaceGetCharVariantIndex(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        static abstract int FaceGetCharVariantIsDefault(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        static abstract int FaceGetCharVariantIsDefault(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        static abstract uint* FaceGetVariantSelectors(FaceRec* face);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        static abstract Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        static abstract uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        static abstract Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode);

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        static abstract int FaceProperties(
            FaceRec* face,
            uint num_properties,
            Parameter* properties
        );

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        static abstract int FaceProperties(
            Ref<FaceRec> face,
            uint num_properties,
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
        static abstract long FloorFix(long a);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        static abstract uint GetCharIndex(FaceRec* face, ulong charcode);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        static abstract uint GetCharIndex(Ref<FaceRec> face, ulong charcode);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        static abstract int GetCharmapIndex(CharMapRec* charmap);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        static abstract int GetCharmapIndex(Ref<CharMapRec> charmap);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        static abstract ulong GetFirstChar(FaceRec* face, uint* agindex);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        static abstract ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        static abstract ushort GetFSTypeFlags(FaceRec* face);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        static abstract ushort GetFSTypeFlags(Ref<FaceRec> face);

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        static abstract int GetGlyphName(
            FaceRec* face,
            uint glyph_index,
            void* buffer,
            uint buffer_max
        );

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        static abstract int GetGlyphName(
            Ref<FaceRec> face,
            uint glyph_index,
            Ref buffer,
            uint buffer_max
        );

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        static abstract int GetKerning(
            FaceRec* face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Vector* akerning
        );

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        static abstract int GetKerning(
            Ref<FaceRec> face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Ref<Vector> akerning
        );

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        static abstract ModuleRecHandle GetModule(LibraryRecHandle library, sbyte* module_name);

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        static abstract ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        static abstract uint GetNameIndex(FaceRec* face, sbyte* glyph_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        static abstract uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        static abstract ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        static abstract ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex);

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
            uint sub_index,
            int* p_index,
            uint* p_flags,
            int* p_arg1,
            int* p_arg2,
            Matrix* p_transform
        );

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        static abstract int GetSubGlyphInfo(
            Ref<GlyphSlotRec> glyph,
            uint sub_index,
            Ref<int> p_index,
            Ref<uint> p_flags,
            Ref<int> p_arg1,
            Ref<int> p_arg2,
            Ref<Matrix> p_transform
        );

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        static abstract int GetTrackKerning(
            FaceRec* face,
            long point_size,
            int degree,
            long* akerning
        );

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        static abstract int GetTrackKerning(
            Ref<FaceRec> face,
            long point_size,
            int degree,
            Ref<long> akerning
        );

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        static abstract void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        static abstract void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

        [NativeName("FT_Get_TrueType_Engine_Type")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
        static abstract TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library);

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
            int* amajor,
            int* aminor,
            int* apatch
        );

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        static abstract void LibraryVersion(
            LibraryRecHandle library,
            Ref<int> amajor,
            Ref<int> aminor,
            Ref<int> apatch
        );

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        static abstract int LoadChar(FaceRec* face, ulong char_code, int load_flags);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        static abstract int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        static abstract int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        static abstract int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags);

        [NativeName("FT_MulDiv")]
        [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
        static abstract long MulDiv(long a, long b, long c);

        [NativeName("FT_MulFix")]
        [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
        static abstract long MulFix(long a, long b);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        static abstract int NewFace(
            LibraryRecHandle library,
            sbyte* filepathname,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        static abstract int NewFace(
            LibraryRecHandle library,
            Ref<sbyte> filepathname,
            long face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        static abstract int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary);

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        static abstract int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary);

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        static abstract int NewMemoryFace(
            LibraryRecHandle library,
            byte* file_base,
            long file_size,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        static abstract int NewMemoryFace(
            LibraryRecHandle library,
            Ref<byte> file_base,
            long file_size,
            long face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        static abstract int OpenFace(
            LibraryRecHandle library,
            OpenArgs* args,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        static abstract int OpenFace(
            LibraryRecHandle library,
            Ref<OpenArgs> args,
            long face_index,
            Ref2D<FaceRec> aface
        );

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        static abstract int OutlineCheck(Outline* outline);

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        static abstract int OutlineCheck(Ref<Outline> outline);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        static abstract int OutlineCopy(Outline* source, Outline* target);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        static abstract int OutlineCopy(Ref<Outline> source, Ref<Outline> target);

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        static abstract int OutlineDecompose(
            Outline* outline,
            OutlineFuncs* func_interface,
            void* user
        );

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        static abstract int OutlineDecompose(
            Ref<Outline> outline,
            Ref<OutlineFuncs> func_interface,
            Ref user
        );

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        static abstract int OutlineDone(LibraryRecHandle library, Outline* outline);

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        static abstract int OutlineDone(LibraryRecHandle library, Ref<Outline> outline);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        static abstract int OutlineEmbolden(Outline* outline, long strength);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        static abstract int OutlineEmbolden(Ref<Outline> outline, long strength);

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        static abstract int OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength);

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        static abstract int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength);

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        static abstract int OutlineGetBitmap(
            LibraryRecHandle library,
            Outline* outline,
            Bitmap* abitmap
        );

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        static abstract int OutlineGetBitmap(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<Bitmap> abitmap
        );

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        static abstract void OutlineGetCBox(Outline* outline, BBox* acbox);

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        static abstract void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        static abstract Orientation OutlineGetOrientation(Outline* outline);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        static abstract Orientation OutlineGetOrientation(Ref<Outline> outline);

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        static abstract int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Outline* anoutline
        );

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        static abstract int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Ref<Outline> anoutline
        );

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        static abstract int OutlineRender(
            LibraryRecHandle library,
            Outline* outline,
            RasterParams* @params
        );

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        static abstract int OutlineRender(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<RasterParams> @params
        );

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        static abstract void OutlineReverse(Outline* outline);

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        static abstract void OutlineReverse(Ref<Outline> outline);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        static abstract void OutlineTransform(Outline* outline, Matrix* matrix);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        static abstract void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        static abstract void OutlineTranslate(Outline* outline, long xOffset, long yOffset);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        static abstract void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset);

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        static abstract int PropertyGet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        );

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        static abstract int PropertyGet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        );

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        static abstract int PropertySet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        );

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        static abstract int PropertySet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        );

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        static abstract int ReferenceFace(FaceRec* face);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        static abstract int ReferenceFace(Ref<FaceRec> face);

        [NativeName("FT_Reference_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
        static abstract int ReferenceLibrary(LibraryRecHandle library);

        [NativeName("FT_Remove_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
        static abstract int RemoveModule(LibraryRecHandle library, ModuleRecHandle module);

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
        static abstract long RoundFix(long a);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        static abstract int SelectCharmap(FaceRec* face, Encoding encoding);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        static abstract int SelectCharmap(Ref<FaceRec> face, Encoding encoding);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        static abstract int SelectSize(FaceRec* face, int strike_index);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        static abstract int SelectSize(Ref<FaceRec> face, int strike_index);

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        static abstract int SetCharSize(
            FaceRec* face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        );

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        static abstract int SetCharSize(
            Ref<FaceRec> face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        );

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        static abstract int SetCharmap(FaceRec* face, CharMapRec* charmap);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        static abstract int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap);

        [NativeName("FT_Set_Debug_Hook")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
        static abstract void SetDebugHook(
            LibraryRecHandle library,
            uint hook_index,
            DebugHookFunc debug_hook
        );

        [NativeName("FT_Set_Default_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
        static abstract void SetDefaultProperties(LibraryRecHandle library);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        static abstract int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        static abstract int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height);

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

    [NativeName("FT_Add_Default_Modules")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
    void AddDefaultModules(LibraryRecHandle library);

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    int AddModule(LibraryRecHandle library, ModuleClass* clazz);

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz);

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
    long CeilFix(long a);

    [NativeName("FT_DivFix")]
    [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
    long DivFix(long a, long b);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    int DoneFace(FaceRec* face);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    int DoneFace(Ref<FaceRec> face);

    [NativeName("FT_Done_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
    int DoneFreeType(LibraryRecHandle library);

    [NativeName("FT_Done_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
    int DoneLibrary(LibraryRecHandle library);

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
    uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    uint FaceGetCharVariantIndex(FaceRec* face, ulong charcode, ulong variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    uint FaceGetCharVariantIndex(Ref<FaceRec> face, ulong charcode, ulong variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    int FaceGetCharVariantIsDefault(FaceRec* face, ulong charcode, ulong variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    int FaceGetCharVariantIsDefault(Ref<FaceRec> face, ulong charcode, ulong variantSelector);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    uint* FaceGetVariantSelectors(FaceRec* face);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    int FaceProperties(FaceRec* face, uint num_properties, Parameter* properties);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    int FaceProperties(Ref<FaceRec> face, uint num_properties, Ref<Parameter> properties);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    byte FaceSetUnpatentedHinting(FaceRec* face, byte value);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value);

    [NativeName("FT_FloorFix")]
    [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
    long FloorFix(long a);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    uint GetCharIndex(FaceRec* face, ulong charcode);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    uint GetCharIndex(Ref<FaceRec> face, ulong charcode);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    int GetCharmapIndex(CharMapRec* charmap);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    int GetCharmapIndex(Ref<CharMapRec> charmap);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    ulong GetFirstChar(FaceRec* face, uint* agindex);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    ushort GetFSTypeFlags(FaceRec* face);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    ushort GetFSTypeFlags(Ref<FaceRec> face);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    int GetGlyphName(FaceRec* face, uint glyph_index, void* buffer, uint buffer_max);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    int GetGlyphName(Ref<FaceRec> face, uint glyph_index, Ref buffer, uint buffer_max);

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    int GetKerning(
        FaceRec* face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Vector* akerning
    );

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    int GetKerning(
        Ref<FaceRec> face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Ref<Vector> akerning
    );

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    ModuleRecHandle GetModule(LibraryRecHandle library, sbyte* module_name);

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    uint GetNameIndex(FaceRec* face, sbyte* glyph_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex);

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
        uint sub_index,
        int* p_index,
        uint* p_flags,
        int* p_arg1,
        int* p_arg2,
        Matrix* p_transform
    );

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    int GetSubGlyphInfo(
        Ref<GlyphSlotRec> glyph,
        uint sub_index,
        Ref<int> p_index,
        Ref<uint> p_flags,
        Ref<int> p_arg1,
        Ref<int> p_arg2,
        Ref<Matrix> p_transform
    );

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    int GetTrackKerning(FaceRec* face, long point_size, int degree, long* akerning);

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    int GetTrackKerning(Ref<FaceRec> face, long point_size, int degree, Ref<long> akerning);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta);

    [NativeName("FT_Get_TrueType_Engine_Type")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
    TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    int InitFreeType(LibraryRecHandle* alibrary);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    int InitFreeType(Ref<LibraryRecHandle> alibrary);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    void LibraryVersion(LibraryRecHandle library, int* amajor, int* aminor, int* apatch);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    void LibraryVersion(
        LibraryRecHandle library,
        Ref<int> amajor,
        Ref<int> aminor,
        Ref<int> apatch
    );

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    int LoadChar(FaceRec* face, ulong char_code, int load_flags);

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags);

    [NativeName("FT_MulDiv")]
    [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
    long MulDiv(long a, long b, long c);

    [NativeName("FT_MulFix")]
    [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
    long MulFix(long a, long b);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    int NewFace(LibraryRecHandle library, sbyte* filepathname, long face_index, FaceRec** aface);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    int NewFace(
        LibraryRecHandle library,
        Ref<sbyte> filepathname,
        long face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary);

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary);

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    int NewMemoryFace(
        LibraryRecHandle library,
        byte* file_base,
        long file_size,
        long face_index,
        FaceRec** aface
    );

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    int NewMemoryFace(
        LibraryRecHandle library,
        Ref<byte> file_base,
        long file_size,
        long face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    int OpenFace(LibraryRecHandle library, OpenArgs* args, long face_index, FaceRec** aface);

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    int OpenFace(
        LibraryRecHandle library,
        Ref<OpenArgs> args,
        long face_index,
        Ref2D<FaceRec> aface
    );

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    int OutlineCheck(Outline* outline);

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    int OutlineCheck(Ref<Outline> outline);

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    int OutlineCopy(Outline* source, Outline* target);

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    int OutlineCopy(Ref<Outline> source, Ref<Outline> target);

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    int OutlineDecompose(Outline* outline, OutlineFuncs* func_interface, void* user);

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    int OutlineDecompose(Ref<Outline> outline, Ref<OutlineFuncs> func_interface, Ref user);

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    int OutlineDone(LibraryRecHandle library, Outline* outline);

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    int OutlineDone(LibraryRecHandle library, Ref<Outline> outline);

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    int OutlineEmbolden(Outline* outline, long strength);

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    int OutlineEmbolden(Ref<Outline> outline, long strength);

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    int OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength);

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength);

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    int OutlineGetBitmap(LibraryRecHandle library, Outline* outline, Bitmap* abitmap);

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    int OutlineGetBitmap(LibraryRecHandle library, Ref<Outline> outline, Ref<Bitmap> abitmap);

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    void OutlineGetCBox(Outline* outline, BBox* acbox);

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox);

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    Orientation OutlineGetOrientation(Outline* outline);

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    Orientation OutlineGetOrientation(Ref<Outline> outline);

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    int OutlineNew(LibraryRecHandle library, uint numPoints, int numContours, Outline* anoutline);

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    int OutlineNew(
        LibraryRecHandle library,
        uint numPoints,
        int numContours,
        Ref<Outline> anoutline
    );

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    int OutlineRender(LibraryRecHandle library, Outline* outline, RasterParams* @params);

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    int OutlineRender(LibraryRecHandle library, Ref<Outline> outline, Ref<RasterParams> @params);

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    void OutlineReverse(Outline* outline);

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    void OutlineReverse(Ref<Outline> outline);

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    void OutlineTransform(Outline* outline, Matrix* matrix);

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix);

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    void OutlineTranslate(Outline* outline, long xOffset, long yOffset);

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset);

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    int PropertyGet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    );

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    int PropertyGet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    );

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    int PropertySet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    );

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    int PropertySet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    );

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    int ReferenceFace(FaceRec* face);

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    int ReferenceFace(Ref<FaceRec> face);

    [NativeName("FT_Reference_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
    int ReferenceLibrary(LibraryRecHandle library);

    [NativeName("FT_Remove_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
    int RemoveModule(LibraryRecHandle library, ModuleRecHandle module);

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
    long RoundFix(long a);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    int SelectCharmap(FaceRec* face, Encoding encoding);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    int SelectCharmap(Ref<FaceRec> face, Encoding encoding);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    int SelectSize(FaceRec* face, int strike_index);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    int SelectSize(Ref<FaceRec> face, int strike_index);

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    int SetCharSize(
        FaceRec* face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    );

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    int SetCharSize(
        Ref<FaceRec> face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    );

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    int SetCharmap(FaceRec* face, CharMapRec* charmap);

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap);

    [NativeName("FT_Set_Debug_Hook")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
    void SetDebugHook(LibraryRecHandle library, uint hook_index, DebugHookFunc debug_hook);

    [NativeName("FT_Set_Default_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
    void SetDefaultProperties(LibraryRecHandle library);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height);

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
