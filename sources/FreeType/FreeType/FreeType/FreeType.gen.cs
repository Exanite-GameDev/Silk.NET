// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the FreeType headers and corresponding dependencies.
// Original source is Copyright (C) 2006-2026 by David Turner, Robert Wilhelm, and Werner Lemberg. Licensed under the FTL license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FreeType;

public unsafe partial class FreeType : IFreeType, IFreeType.Static
{
    public partial class DllImport : IFreeType.Static
    {
        [NativeName("FT_Add_Default_Modules")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Add_Default_Modules")]
        public static extern void AddDefaultModules(LibraryRecHandle library);

        [NativeName("FT_Add_Module")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Add_Module")]
        public static extern int AddModule(LibraryRecHandle library, ModuleClass* clazz);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz)
        {
            fixed (ModuleClass* __dsl_clazz = clazz)
            {
                return (int)AddModule(library, __dsl_clazz);
            }
        }

        [NativeName("FT_Attach_File")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Attach_File")]
        public static extern int AttachFile(FaceRec* face, sbyte* filepathname);

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname)
        {
            fixed (sbyte* __dsl_filepathname = filepathname)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)AttachFile(__dsl_face, __dsl_filepathname);
            }
        }

        [NativeName("FT_Attach_Stream")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Attach_Stream")]
        public static extern int AttachStream(FaceRec* face, OpenArgs* parameters);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters)
        {
            fixed (OpenArgs* __dsl_parameters = parameters)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)AttachStream(__dsl_face, __dsl_parameters);
            }
        }

        [NativeName("FT_CeilFix")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_CeilFix")]
        public static extern long CeilFix(long a);

        [NativeName("FT_DivFix")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_DivFix")]
        public static extern long DivFix(long a, long b);

        [NativeName("FT_Done_Face")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Done_Face")]
        public static extern int DoneFace(FaceRec* face);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int DoneFace(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)DoneFace(__dsl_face);
            }
        }

        [NativeName("FT_Done_FreeType")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Done_FreeType")]
        public static extern int DoneFreeType(LibraryRecHandle library);

        [NativeName("FT_Done_Library")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Done_Library")]
        public static extern int DoneLibrary(LibraryRecHandle library);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> ErrorString(int error_code) => (sbyte*)ErrorStringRaw(error_code);

        [NativeName("FT_Error_String")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Error_String")]
        public static extern sbyte* ErrorStringRaw(int error_code);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_CheckTrueTypePatents")]
        public static extern byte FaceCheckTrueTypePatents(FaceRec* face);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceCheckTrueTypePatents(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (byte)FaceCheckTrueTypePatents(__dsl_face);
            }
        }

        [NativeName("FT_Face_GetCharsOfVariant")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_GetCharsOfVariant")]
        public static extern uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetCharsOfVariant(__dsl_face, variantSelector);
            }
        }

        [NativeName("FT_Face_GetCharVariantIndex")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_GetCharVariantIndex")]
        public static extern uint FaceGetCharVariantIndex(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint FaceGetCharVariantIndex(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)FaceGetCharVariantIndex(__dsl_face, charcode, variantSelector);
            }
        }

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [DllImport(
            "freetype",
            ExactSpelling = true,
            EntryPoint = "FT_Face_GetCharVariantIsDefault"
        )]
        public static extern int FaceGetCharVariantIsDefault(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        );

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceGetCharVariantIsDefault(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)FaceGetCharVariantIsDefault(__dsl_face, charcode, variantSelector);
            }
        }

        [NativeName("FT_Face_GetVariantSelectors")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_GetVariantSelectors")]
        public static extern uint* FaceGetVariantSelectors(FaceRec* face);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetVariantSelectors(__dsl_face);
            }
        }

        [NativeName("FT_Face_GetVariantsOfChar")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_GetVariantsOfChar")]
        public static extern uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetVariantsOfChar(__dsl_face, charcode);
            }
        }

        [NativeName("FT_Face_Properties")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_Properties")]
        public static extern int FaceProperties(
            FaceRec* face,
            uint num_properties,
            Parameter* properties
        );

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceProperties(
            Ref<FaceRec> face,
            uint num_properties,
            Ref<Parameter> properties
        )
        {
            fixed (Parameter* __dsl_properties = properties)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)FaceProperties(__dsl_face, num_properties, __dsl_properties);
            }
        }

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Face_SetUnpatentedHinting")]
        public static extern byte FaceSetUnpatentedHinting(FaceRec* face, byte value);

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (byte)FaceSetUnpatentedHinting(__dsl_face, value);
            }
        }

        [NativeName("FT_FloorFix")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_FloorFix")]
        public static extern long FloorFix(long a);

        [NativeName("FT_Get_Char_Index")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Char_Index")]
        public static extern uint GetCharIndex(FaceRec* face, ulong charcode);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetCharIndex(Ref<FaceRec> face, ulong charcode)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)GetCharIndex(__dsl_face, charcode);
            }
        }

        [NativeName("FT_Get_Charmap_Index")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Charmap_Index")]
        public static extern int GetCharmapIndex(CharMapRec* charmap);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetCharmapIndex(Ref<CharMapRec> charmap)
        {
            fixed (CharMapRec* __dsl_charmap = charmap)
            {
                return (int)GetCharmapIndex(__dsl_charmap);
            }
        }

        [NativeName("FT_Get_First_Char")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_First_Char")]
        public static extern ulong GetFirstChar(FaceRec* face, uint* agindex);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex)
        {
            fixed (uint* __dsl_agindex = agindex)
            fixed (FaceRec* __dsl_face = face)
            {
                return (ulong)GetFirstChar(__dsl_face, __dsl_agindex);
            }
        }

        [NativeName("FT_Get_FSType_Flags")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_FSType_Flags")]
        public static extern ushort GetFSTypeFlags(FaceRec* face);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ushort GetFSTypeFlags(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (ushort)GetFSTypeFlags(__dsl_face);
            }
        }

        [NativeName("FT_Get_Glyph_Name")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Glyph_Name")]
        public static extern int GetGlyphName(
            FaceRec* face,
            uint glyph_index,
            void* buffer,
            uint buffer_max
        );

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetGlyphName(
            Ref<FaceRec> face,
            uint glyph_index,
            Ref buffer,
            uint buffer_max
        )
        {
            fixed (void* __dsl_buffer = buffer)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetGlyphName(__dsl_face, glyph_index, __dsl_buffer, buffer_max);
            }
        }

        [NativeName("FT_Get_Kerning")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Kerning")]
        public static extern int GetKerning(
            FaceRec* face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Vector* akerning
        );

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetKerning(
            Ref<FaceRec> face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Ref<Vector> akerning
        )
        {
            fixed (Vector* __dsl_akerning = akerning)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetKerning(
                    __dsl_face,
                    left_glyph,
                    right_glyph,
                    kern_mode,
                    __dsl_akerning
                );
            }
        }

        [NativeName("FT_Get_Module")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Module")]
        public static extern ModuleRecHandle GetModule(
            LibraryRecHandle library,
            sbyte* module_name
        );

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name)
        {
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (ModuleRecHandle)GetModule(library, __dsl_module_name);
            }
        }

        [NativeName("FT_Get_Name_Index")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Name_Index")]
        public static extern uint GetNameIndex(FaceRec* face, sbyte* glyph_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name)
        {
            fixed (sbyte* __dsl_glyph_name = glyph_name)
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)GetNameIndex(__dsl_face, __dsl_glyph_name);
            }
        }

        [NativeName("FT_Get_Next_Char")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Next_Char")]
        public static extern ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex)
        {
            fixed (uint* __dsl_agindex = agindex)
            fixed (FaceRec* __dsl_face = face)
            {
                return (ulong)GetNextChar(__dsl_face, char_code, __dsl_agindex);
            }
        }

        [NativeName("FT_Get_Postscript_Name")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Postscript_Name")]
        public static extern sbyte* GetPostscriptName(FaceRec* face);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (sbyte*)GetPostscriptName(__dsl_face);
            }
        }

        [NativeName("FT_Get_SubGlyph_Info")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_SubGlyph_Info")]
        public static extern int GetSubGlyphInfo(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetSubGlyphInfo(
            Ref<GlyphSlotRec> glyph,
            uint sub_index,
            Ref<int> p_index,
            Ref<uint> p_flags,
            Ref<int> p_arg1,
            Ref<int> p_arg2,
            Ref<Matrix> p_transform
        )
        {
            fixed (Matrix* __dsl_p_transform = p_transform)
            fixed (int* __dsl_p_arg2 = p_arg2)
            fixed (int* __dsl_p_arg1 = p_arg1)
            fixed (uint* __dsl_p_flags = p_flags)
            fixed (int* __dsl_p_index = p_index)
            fixed (GlyphSlotRec* __dsl_glyph = glyph)
            {
                return (int)GetSubGlyphInfo(
                    __dsl_glyph,
                    sub_index,
                    __dsl_p_index,
                    __dsl_p_flags,
                    __dsl_p_arg1,
                    __dsl_p_arg2,
                    __dsl_p_transform
                );
            }
        }

        [NativeName("FT_Get_Track_Kerning")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Track_Kerning")]
        public static extern int GetTrackKerning(
            FaceRec* face,
            long point_size,
            int degree,
            long* akerning
        );

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetTrackKerning(
            Ref<FaceRec> face,
            long point_size,
            int degree,
            Ref<long> akerning
        )
        {
            fixed (long* __dsl_akerning = akerning)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetTrackKerning(__dsl_face, point_size, degree, __dsl_akerning);
            }
        }

        [NativeName("FT_Get_Transform")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_Transform")]
        public static extern void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
        {
            fixed (Vector* __dsl_delta = delta)
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (FaceRec* __dsl_face = face)
            {
                GetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
            }
        }

        [NativeName("FT_Get_TrueType_Engine_Type")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Get_TrueType_Engine_Type")]
        public static extern TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library);

        [NativeName("FT_Init_FreeType")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Init_FreeType")]
        public static extern int InitFreeType(LibraryRecHandle* alibrary);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int InitFreeType(Ref<LibraryRecHandle> alibrary)
        {
            fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
            {
                return (int)InitFreeType(__dsl_alibrary);
            }
        }

        [NativeName("FT_Library_Version")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Library_Version")]
        public static extern void LibraryVersion(
            LibraryRecHandle library,
            int* amajor,
            int* aminor,
            int* apatch
        );

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void LibraryVersion(
            LibraryRecHandle library,
            Ref<int> amajor,
            Ref<int> aminor,
            Ref<int> apatch
        )
        {
            fixed (int* __dsl_apatch = apatch)
            fixed (int* __dsl_aminor = aminor)
            fixed (int* __dsl_amajor = amajor)
            {
                LibraryVersion(library, __dsl_amajor, __dsl_aminor, __dsl_apatch);
            }
        }

        [NativeName("FT_Load_Char")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Load_Char")]
        public static extern int LoadChar(FaceRec* face, ulong char_code, int load_flags);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)LoadChar(__dsl_face, char_code, load_flags);
            }
        }

        [NativeName("FT_Load_Glyph")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Load_Glyph")]
        public static extern int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)LoadGlyph(__dsl_face, glyph_index, load_flags);
            }
        }

        [NativeName("FT_MulDiv")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_MulDiv")]
        public static extern long MulDiv(long a, long b, long c);

        [NativeName("FT_MulFix")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_MulFix")]
        public static extern long MulFix(long a, long b);

        [NativeName("FT_New_Face")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_New_Face")]
        public static extern int NewFace(
            LibraryRecHandle library,
            sbyte* filepathname,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewFace(
            LibraryRecHandle library,
            Ref<sbyte> filepathname,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (sbyte* __dsl_filepathname = filepathname)
            {
                return (int)NewFace(library, __dsl_filepathname, face_index, __dsl_aface);
            }
        }

        [NativeName("FT_New_Library")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_New_Library")]
        public static extern int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary);

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary)
        {
            fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
            fixed (MemoryRec* __dsl_memory = memory)
            {
                return (int)NewLibrary(__dsl_memory, __dsl_alibrary);
            }
        }

        [NativeName("FT_New_Memory_Face")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_New_Memory_Face")]
        public static extern int NewMemoryFace(
            LibraryRecHandle library,
            byte* file_base,
            long file_size,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewMemoryFace(
            LibraryRecHandle library,
            Ref<byte> file_base,
            long file_size,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (byte* __dsl_file_base = file_base)
            {
                return (int)NewMemoryFace(
                    library,
                    __dsl_file_base,
                    file_size,
                    face_index,
                    __dsl_aface
                );
            }
        }

        [NativeName("FT_Open_Face")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Open_Face")]
        public static extern int OpenFace(
            LibraryRecHandle library,
            OpenArgs* args,
            long face_index,
            FaceRec** aface
        );

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OpenFace(
            LibraryRecHandle library,
            Ref<OpenArgs> args,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (OpenArgs* __dsl_args = args)
            {
                return (int)OpenFace(library, __dsl_args, face_index, __dsl_aface);
            }
        }

        [NativeName("FT_Outline_Check")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Check")]
        public static extern int OutlineCheck(Outline* outline);

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCheck(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineCheck(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_Copy")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Copy")]
        public static extern int OutlineCopy(Outline* source, Outline* target);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCopy(Ref<Outline> source, Ref<Outline> target)
        {
            fixed (Outline* __dsl_target = target)
            fixed (Outline* __dsl_source = source)
            {
                return (int)OutlineCopy(__dsl_source, __dsl_target);
            }
        }

        [NativeName("FT_Outline_Decompose")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Decompose")]
        public static extern int OutlineDecompose(
            Outline* outline,
            OutlineFuncs* func_interface,
            void* user
        );

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDecompose(
            Ref<Outline> outline,
            Ref<OutlineFuncs> func_interface,
            Ref user
        )
        {
            fixed (void* __dsl_user = user)
            fixed (OutlineFuncs* __dsl_func_interface = func_interface)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineDecompose(__dsl_outline, __dsl_func_interface, __dsl_user);
            }
        }

        [NativeName("FT_Outline_Done")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Done")]
        public static extern int OutlineDone(LibraryRecHandle library, Outline* outline);

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDone(LibraryRecHandle library, Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineDone(library, __dsl_outline);
            }
        }

        [NativeName("FT_Outline_Embolden")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Embolden")]
        public static extern int OutlineEmbolden(Outline* outline, long strength);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmbolden(Ref<Outline> outline, long strength)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineEmbolden(__dsl_outline, strength);
            }
        }

        [NativeName("FT_Outline_EmboldenXY")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_EmboldenXY")]
        public static extern int OutlineEmboldenXY(
            Outline* outline,
            long xstrength,
            long ystrength
        );

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineEmboldenXY(__dsl_outline, xstrength, ystrength);
            }
        }

        [NativeName("FT_Outline_Get_Bitmap")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Get_Bitmap")]
        public static extern int OutlineGetBitmap(
            LibraryRecHandle library,
            Outline* outline,
            Bitmap* abitmap
        );

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineGetBitmap(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<Bitmap> abitmap
        )
        {
            fixed (Bitmap* __dsl_abitmap = abitmap)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineGetBitmap(library, __dsl_outline, __dsl_abitmap);
            }
        }

        [NativeName("FT_Outline_Get_CBox")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Get_CBox")]
        public static extern void OutlineGetCBox(Outline* outline, BBox* acbox);

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox)
        {
            fixed (BBox* __dsl_acbox = acbox)
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineGetCBox(__dsl_outline, __dsl_acbox);
            }
        }

        [NativeName("FT_Outline_Get_Orientation")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Get_Orientation")]
        public static extern Orientation OutlineGetOrientation(Outline* outline);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Orientation OutlineGetOrientation(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (Orientation)OutlineGetOrientation(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_New")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_New")]
        public static extern int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Outline* anoutline
        );

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Ref<Outline> anoutline
        )
        {
            fixed (Outline* __dsl_anoutline = anoutline)
            {
                return (int)OutlineNew(library, numPoints, numContours, __dsl_anoutline);
            }
        }

        [NativeName("FT_Outline_Render")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Render")]
        public static extern int OutlineRender(
            LibraryRecHandle library,
            Outline* outline,
            RasterParams* @params
        );

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineRender(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<RasterParams> @params
        )
        {
            fixed (RasterParams* __dsl_params = @params)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineRender(library, __dsl_outline, __dsl_params);
            }
        }

        [NativeName("FT_Outline_Reverse")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Reverse")]
        public static extern void OutlineReverse(Outline* outline);

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineReverse(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineReverse(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_Transform")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Transform")]
        public static extern void OutlineTransform(Outline* outline, Matrix* matrix);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix)
        {
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineTransform(__dsl_outline, __dsl_matrix);
            }
        }

        [NativeName("FT_Outline_Translate")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Outline_Translate")]
        public static extern void OutlineTranslate(Outline* outline, long xOffset, long yOffset);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineTranslate(__dsl_outline, xOffset, yOffset);
            }
        }

        [NativeName("FT_Property_Get")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Property_Get")]
        public static extern int PropertyGet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        );

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertyGet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        )
        {
            fixed (void* __dsl_value = value)
            fixed (sbyte* __dsl_property_name = property_name)
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (int)PropertyGet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
            }
        }

        [NativeName("FT_Property_Set")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Property_Set")]
        public static extern int PropertySet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        );

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertySet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        )
        {
            fixed (void* __dsl_value = value)
            fixed (sbyte* __dsl_property_name = property_name)
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (int)PropertySet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
            }
        }

        [NativeName("FT_Reference_Face")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Reference_Face")]
        public static extern int ReferenceFace(FaceRec* face);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int ReferenceFace(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)ReferenceFace(__dsl_face);
            }
        }

        [NativeName("FT_Reference_Library")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Reference_Library")]
        public static extern int ReferenceLibrary(LibraryRecHandle library);

        [NativeName("FT_Remove_Module")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Remove_Module")]
        public static extern int RemoveModule(LibraryRecHandle library, ModuleRecHandle module);

        [NativeName("FT_Render_Glyph")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Render_Glyph")]
        public static extern int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode)
        {
            fixed (GlyphSlotRec* __dsl_slot = slot)
            {
                return (int)RenderGlyph(__dsl_slot, render_mode);
            }
        }

        [NativeName("FT_Request_Size")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Request_Size")]
        public static extern int RequestSize(FaceRec* face, SizeRequestRec* req);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req)
        {
            fixed (SizeRequestRec* __dsl_req = req)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)RequestSize(__dsl_face, __dsl_req);
            }
        }

        [NativeName("FT_RoundFix")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_RoundFix")]
        public static extern long RoundFix(long a);

        [NativeName("FT_Select_Charmap")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Select_Charmap")]
        public static extern int SelectCharmap(FaceRec* face, Encoding encoding);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectCharmap(Ref<FaceRec> face, Encoding encoding)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SelectCharmap(__dsl_face, encoding);
            }
        }

        [NativeName("FT_Select_Size")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Select_Size")]
        public static extern int SelectSize(FaceRec* face, int strike_index);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectSize(Ref<FaceRec> face, int strike_index)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SelectSize(__dsl_face, strike_index);
            }
        }

        [NativeName("FT_Set_Char_Size")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Char_Size")]
        public static extern int SetCharSize(
            FaceRec* face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        );

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharSize(
            Ref<FaceRec> face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetCharSize(
                    __dsl_face,
                    char_width,
                    char_height,
                    horz_resolution,
                    vert_resolution
                );
            }
        }

        [NativeName("FT_Set_Charmap")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Charmap")]
        public static extern int SetCharmap(FaceRec* face, CharMapRec* charmap);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap)
        {
            fixed (CharMapRec* __dsl_charmap = charmap)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetCharmap(__dsl_face, __dsl_charmap);
            }
        }

        [NativeName("FT_Set_Debug_Hook")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Debug_Hook")]
        public static extern void SetDebugHook(
            LibraryRecHandle library,
            uint hook_index,
            DebugHookFunc debug_hook
        );

        [NativeName("FT_Set_Default_Properties")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Default_Properties")]
        public static extern void SetDefaultProperties(LibraryRecHandle library);

        [NativeName("FT_Set_Pixel_Sizes")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Pixel_Sizes")]
        public static extern int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetPixelSizes(__dsl_face, pixel_width, pixel_height);
            }
        }

        [NativeName("FT_Set_Transform")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Set_Transform")]
        public static extern void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
        {
            fixed (Vector* __dsl_delta = delta)
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (FaceRec* __dsl_face = face)
            {
                SetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
            }
        }

        [NativeName("FT_Vector_Transform")]
        [DllImport("freetype", ExactSpelling = true, EntryPoint = "FT_Vector_Transform")]
        public static extern void VectorTransform(Vector* vector, Matrix* matrix);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix)
        {
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (Vector* __dsl_vector = vector)
            {
                VectorTransform(__dsl_vector, __dsl_matrix);
            }
        }
    }

    public partial class StaticWrapper<T> : IFreeType
        where T : IFreeType.Static
    {
        [NativeName("FT_Add_Default_Modules")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void AddDefaultModules(LibraryRecHandle library) => T.AddDefaultModules(library);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AddModule(LibraryRecHandle library, ModuleClass* clazz) =>
            T.AddModule(library, clazz);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz) =>
            T.AddModule(library, clazz);

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AttachFile(FaceRec* face, sbyte* filepathname) =>
            T.AttachFile(face, filepathname);

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname) =>
            T.AttachFile(face, filepathname);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AttachStream(FaceRec* face, OpenArgs* parameters) =>
            T.AttachStream(face, parameters);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters) =>
            T.AttachStream(face, parameters);

        [NativeName("FT_CeilFix")]
        [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long CeilFix(long a) => T.CeilFix(a);

        [NativeName("FT_DivFix")]
        [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long DivFix(long a, long b) => T.DivFix(a, b);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int DoneFace(FaceRec* face) => T.DoneFace(face);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int DoneFace(Ref<FaceRec> face) => T.DoneFace(face);

        [NativeName("FT_Done_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int DoneFreeType(LibraryRecHandle library) => T.DoneFreeType(library);

        [NativeName("FT_Done_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int DoneLibrary(LibraryRecHandle library) => T.DoneLibrary(library);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> ErrorString(int error_code) => T.ErrorString(error_code);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* ErrorStringRaw(int error_code) => T.ErrorStringRaw(error_code);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public byte FaceCheckTrueTypePatents(FaceRec* face) => T.FaceCheckTrueTypePatents(face);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public byte FaceCheckTrueTypePatents(Ref<FaceRec> face) => T.FaceCheckTrueTypePatents(face);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector) =>
            T.FaceGetCharsOfVariant(face, variantSelector);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector) =>
            T.FaceGetCharsOfVariant(face, variantSelector);

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint FaceGetCharVariantIndex(FaceRec* face, ulong charcode, ulong variantSelector) =>
            T.FaceGetCharVariantIndex(face, charcode, variantSelector);

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint FaceGetCharVariantIndex(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        ) => T.FaceGetCharVariantIndex(face, charcode, variantSelector);

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int FaceGetCharVariantIsDefault(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        ) => T.FaceGetCharVariantIsDefault(face, charcode, variantSelector);

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int FaceGetCharVariantIsDefault(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        ) => T.FaceGetCharVariantIsDefault(face, charcode, variantSelector);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint* FaceGetVariantSelectors(FaceRec* face) => T.FaceGetVariantSelectors(face);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face) =>
            T.FaceGetVariantSelectors(face);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode) =>
            T.FaceGetVariantsOfChar(face, charcode);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode) =>
            T.FaceGetVariantsOfChar(face, charcode);

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int FaceProperties(FaceRec* face, uint num_properties, Parameter* properties) =>
            T.FaceProperties(face, num_properties, properties);

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int FaceProperties(
            Ref<FaceRec> face,
            uint num_properties,
            Ref<Parameter> properties
        ) => T.FaceProperties(face, num_properties, properties);

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public byte FaceSetUnpatentedHinting(FaceRec* face, byte value) =>
            T.FaceSetUnpatentedHinting(face, value);

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value) =>
            T.FaceSetUnpatentedHinting(face, value);

        [NativeName("FT_FloorFix")]
        [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long FloorFix(long a) => T.FloorFix(a);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GetCharIndex(FaceRec* face, ulong charcode) => T.GetCharIndex(face, charcode);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GetCharIndex(Ref<FaceRec> face, ulong charcode) =>
            T.GetCharIndex(face, charcode);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetCharmapIndex(CharMapRec* charmap) => T.GetCharmapIndex(charmap);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetCharmapIndex(Ref<CharMapRec> charmap) => T.GetCharmapIndex(charmap);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ulong GetFirstChar(FaceRec* face, uint* agindex) => T.GetFirstChar(face, agindex);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex) =>
            T.GetFirstChar(face, agindex);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ushort GetFSTypeFlags(FaceRec* face) => T.GetFSTypeFlags(face);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ushort GetFSTypeFlags(Ref<FaceRec> face) => T.GetFSTypeFlags(face);

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetGlyphName(FaceRec* face, uint glyph_index, void* buffer, uint buffer_max) =>
            T.GetGlyphName(face, glyph_index, buffer, buffer_max);

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetGlyphName(Ref<FaceRec> face, uint glyph_index, Ref buffer, uint buffer_max) =>
            T.GetGlyphName(face, glyph_index, buffer, buffer_max);

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetKerning(
            FaceRec* face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Vector* akerning
        ) => T.GetKerning(face, left_glyph, right_glyph, kern_mode, akerning);

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetKerning(
            Ref<FaceRec> face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Ref<Vector> akerning
        ) => T.GetKerning(face, left_glyph, right_glyph, kern_mode, akerning);

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ModuleRecHandle GetModule(LibraryRecHandle library, sbyte* module_name) =>
            T.GetModule(library, module_name);

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name) =>
            T.GetModule(library, module_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GetNameIndex(FaceRec* face, sbyte* glyph_name) =>
            T.GetNameIndex(face, glyph_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name) =>
            T.GetNameIndex(face, glyph_name);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex) =>
            T.GetNextChar(face, char_code, agindex);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex) =>
            T.GetNextChar(face, char_code, agindex);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetPostscriptName(FaceRec* face) => T.GetPostscriptName(face);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face) => T.GetPostscriptName(face);

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetSubGlyphInfo(
            GlyphSlotRec* glyph,
            uint sub_index,
            int* p_index,
            uint* p_flags,
            int* p_arg1,
            int* p_arg2,
            Matrix* p_transform
        ) => T.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetSubGlyphInfo(
            Ref<GlyphSlotRec> glyph,
            uint sub_index,
            Ref<int> p_index,
            Ref<uint> p_flags,
            Ref<int> p_arg1,
            Ref<int> p_arg2,
            Ref<Matrix> p_transform
        ) => T.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetTrackKerning(FaceRec* face, long point_size, int degree, long* akerning) =>
            T.GetTrackKerning(face, point_size, degree, akerning);

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetTrackKerning(
            Ref<FaceRec> face,
            long point_size,
            int degree,
            Ref<long> akerning
        ) => T.GetTrackKerning(face, point_size, degree, akerning);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
            T.GetTransform(face, matrix, delta);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta) =>
            T.GetTransform(face, matrix, delta);

        [NativeName("FT_Get_TrueType_Engine_Type")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library) =>
            T.GetTrueTypeEngineType(library);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int InitFreeType(LibraryRecHandle* alibrary) => T.InitFreeType(alibrary);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int InitFreeType(Ref<LibraryRecHandle> alibrary) => T.InitFreeType(alibrary);

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void LibraryVersion(
            LibraryRecHandle library,
            int* amajor,
            int* aminor,
            int* apatch
        ) => T.LibraryVersion(library, amajor, aminor, apatch);

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void LibraryVersion(
            LibraryRecHandle library,
            Ref<int> amajor,
            Ref<int> aminor,
            Ref<int> apatch
        ) => T.LibraryVersion(library, amajor, aminor, apatch);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int LoadChar(FaceRec* face, ulong char_code, int load_flags) =>
            T.LoadChar(face, char_code, load_flags);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags) =>
            T.LoadChar(face, char_code, load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags) =>
            T.LoadGlyph(face, glyph_index, load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags) =>
            T.LoadGlyph(face, glyph_index, load_flags);

        [NativeName("FT_MulDiv")]
        [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long MulDiv(long a, long b, long c) => T.MulDiv(a, b, c);

        [NativeName("FT_MulFix")]
        [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long MulFix(long a, long b) => T.MulFix(a, b);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewFace(
            LibraryRecHandle library,
            sbyte* filepathname,
            long face_index,
            FaceRec** aface
        ) => T.NewFace(library, filepathname, face_index, aface);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewFace(
            LibraryRecHandle library,
            Ref<sbyte> filepathname,
            long face_index,
            Ref2D<FaceRec> aface
        ) => T.NewFace(library, filepathname, face_index, aface);

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary) =>
            T.NewLibrary(memory, alibrary);

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary) =>
            T.NewLibrary(memory, alibrary);

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewMemoryFace(
            LibraryRecHandle library,
            byte* file_base,
            long file_size,
            long face_index,
            FaceRec** aface
        ) => T.NewMemoryFace(library, file_base, file_size, face_index, aface);

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int NewMemoryFace(
            LibraryRecHandle library,
            Ref<byte> file_base,
            long file_size,
            long face_index,
            Ref2D<FaceRec> aface
        ) => T.NewMemoryFace(library, file_base, file_size, face_index, aface);

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OpenFace(
            LibraryRecHandle library,
            OpenArgs* args,
            long face_index,
            FaceRec** aface
        ) => T.OpenFace(library, args, face_index, aface);

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OpenFace(
            LibraryRecHandle library,
            Ref<OpenArgs> args,
            long face_index,
            Ref2D<FaceRec> aface
        ) => T.OpenFace(library, args, face_index, aface);

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineCheck(Outline* outline) => T.OutlineCheck(outline);

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineCheck(Ref<Outline> outline) => T.OutlineCheck(outline);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineCopy(Outline* source, Outline* target) => T.OutlineCopy(source, target);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineCopy(Ref<Outline> source, Ref<Outline> target) =>
            T.OutlineCopy(source, target);

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineDecompose(Outline* outline, OutlineFuncs* func_interface, void* user) =>
            T.OutlineDecompose(outline, func_interface, user);

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineDecompose(
            Ref<Outline> outline,
            Ref<OutlineFuncs> func_interface,
            Ref user
        ) => T.OutlineDecompose(outline, func_interface, user);

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineDone(LibraryRecHandle library, Outline* outline) =>
            T.OutlineDone(library, outline);

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineDone(LibraryRecHandle library, Ref<Outline> outline) =>
            T.OutlineDone(library, outline);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineEmbolden(Outline* outline, long strength) =>
            T.OutlineEmbolden(outline, strength);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineEmbolden(Ref<Outline> outline, long strength) =>
            T.OutlineEmbolden(outline, strength);

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength) =>
            T.OutlineEmboldenXY(outline, xstrength, ystrength);

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength) =>
            T.OutlineEmboldenXY(outline, xstrength, ystrength);

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineGetBitmap(LibraryRecHandle library, Outline* outline, Bitmap* abitmap) =>
            T.OutlineGetBitmap(library, outline, abitmap);

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineGetBitmap(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<Bitmap> abitmap
        ) => T.OutlineGetBitmap(library, outline, abitmap);

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineGetCBox(Outline* outline, BBox* acbox) =>
            T.OutlineGetCBox(outline, acbox);

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox) =>
            T.OutlineGetCBox(outline, acbox);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Orientation OutlineGetOrientation(Outline* outline) =>
            T.OutlineGetOrientation(outline);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Orientation OutlineGetOrientation(Ref<Outline> outline) =>
            T.OutlineGetOrientation(outline);

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Outline* anoutline
        ) => T.OutlineNew(library, numPoints, numContours, anoutline);

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Ref<Outline> anoutline
        ) => T.OutlineNew(library, numPoints, numContours, anoutline);

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineRender(
            LibraryRecHandle library,
            Outline* outline,
            RasterParams* @params
        ) => T.OutlineRender(library, outline, @params);

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int OutlineRender(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<RasterParams> @params
        ) => T.OutlineRender(library, outline, @params);

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineReverse(Outline* outline) => T.OutlineReverse(outline);

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineReverse(Ref<Outline> outline) => T.OutlineReverse(outline);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineTransform(Outline* outline, Matrix* matrix) =>
            T.OutlineTransform(outline, matrix);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix) =>
            T.OutlineTransform(outline, matrix);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineTranslate(Outline* outline, long xOffset, long yOffset) =>
            T.OutlineTranslate(outline, xOffset, yOffset);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset) =>
            T.OutlineTranslate(outline, xOffset, yOffset);

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int PropertyGet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        ) => T.PropertyGet(library, module_name, property_name, value);

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int PropertyGet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        ) => T.PropertyGet(library, module_name, property_name, value);

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int PropertySet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        ) => T.PropertySet(library, module_name, property_name, value);

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int PropertySet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        ) => T.PropertySet(library, module_name, property_name, value);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int ReferenceFace(FaceRec* face) => T.ReferenceFace(face);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int ReferenceFace(Ref<FaceRec> face) => T.ReferenceFace(face);

        [NativeName("FT_Reference_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int ReferenceLibrary(LibraryRecHandle library) => T.ReferenceLibrary(library);

        [NativeName("FT_Remove_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int RemoveModule(LibraryRecHandle library, ModuleRecHandle module) =>
            T.RemoveModule(library, module);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode) =>
            T.RenderGlyph(slot, render_mode);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode) =>
            T.RenderGlyph(slot, render_mode);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int RequestSize(FaceRec* face, SizeRequestRec* req) => T.RequestSize(face, req);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req) =>
            T.RequestSize(face, req);

        [NativeName("FT_RoundFix")]
        [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public long RoundFix(long a) => T.RoundFix(a);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SelectCharmap(FaceRec* face, Encoding encoding) =>
            T.SelectCharmap(face, encoding);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SelectCharmap(Ref<FaceRec> face, Encoding encoding) =>
            T.SelectCharmap(face, encoding);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SelectSize(FaceRec* face, int strike_index) => T.SelectSize(face, strike_index);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SelectSize(Ref<FaceRec> face, int strike_index) =>
            T.SelectSize(face, strike_index);

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetCharSize(
            FaceRec* face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        ) => T.SetCharSize(face, char_width, char_height, horz_resolution, vert_resolution);

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetCharSize(
            Ref<FaceRec> face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        ) => T.SetCharSize(face, char_width, char_height, horz_resolution, vert_resolution);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetCharmap(FaceRec* face, CharMapRec* charmap) => T.SetCharmap(face, charmap);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap) =>
            T.SetCharmap(face, charmap);

        [NativeName("FT_Set_Debug_Hook")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SetDebugHook(
            LibraryRecHandle library,
            uint hook_index,
            DebugHookFunc debug_hook
        ) => T.SetDebugHook(library, hook_index, debug_hook);

        [NativeName("FT_Set_Default_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SetDefaultProperties(LibraryRecHandle library) =>
            T.SetDefaultProperties(library);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height) =>
            T.SetPixelSizes(face, pixel_width, pixel_height);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height) =>
            T.SetPixelSizes(face, pixel_width, pixel_height);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
            T.SetTransform(face, matrix, delta);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta) =>
            T.SetTransform(face, matrix, delta);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void VectorTransform(Vector* vector, Matrix* matrix) =>
            T.VectorTransform(vector, matrix);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix) =>
            T.VectorTransform(vector, matrix);
    }

    public partial class ThisThread
    {
        [NativeName("FT_Add_Default_Modules")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void AddDefaultModules(LibraryRecHandle library) =>
            Underlying.Value!.AddDefaultModules(library);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AddModule(LibraryRecHandle library, ModuleClass* clazz) =>
            Underlying.Value!.AddModule(library, clazz);

        [NativeName("FT_Add_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz)
        {
            fixed (ModuleClass* __dsl_clazz = clazz)
            {
                return (int)AddModule(library, __dsl_clazz);
            }
        }

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachFile(FaceRec* face, sbyte* filepathname) =>
            Underlying.Value!.AttachFile(face, filepathname);

        [NativeName("FT_Attach_File")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname)
        {
            fixed (sbyte* __dsl_filepathname = filepathname)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)AttachFile(__dsl_face, __dsl_filepathname);
            }
        }

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachStream(FaceRec* face, OpenArgs* parameters) =>
            Underlying.Value!.AttachStream(face, parameters);

        [NativeName("FT_Attach_Stream")]
        [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters)
        {
            fixed (OpenArgs* __dsl_parameters = parameters)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)AttachStream(__dsl_face, __dsl_parameters);
            }
        }

        [NativeName("FT_CeilFix")]
        [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long CeilFix(long a) => Underlying.Value!.CeilFix(a);

        [NativeName("FT_DivFix")]
        [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long DivFix(long a, long b) => Underlying.Value!.DivFix(a, b);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int DoneFace(FaceRec* face) => Underlying.Value!.DoneFace(face);

        [NativeName("FT_Done_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int DoneFace(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)DoneFace(__dsl_face);
            }
        }

        [NativeName("FT_Done_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int DoneFreeType(LibraryRecHandle library) =>
            Underlying.Value!.DoneFreeType(library);

        [NativeName("FT_Done_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int DoneLibrary(LibraryRecHandle library) =>
            Underlying.Value!.DoneLibrary(library);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> ErrorString(int error_code) =>
            Underlying.Value!.ErrorString(error_code);

        [NativeName("FT_Error_String")]
        [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* ErrorStringRaw(int error_code) =>
            Underlying.Value!.ErrorStringRaw(error_code);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceCheckTrueTypePatents(FaceRec* face) =>
            Underlying.Value!.FaceCheckTrueTypePatents(face);

        [NativeName("FT_Face_CheckTrueTypePatents")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceCheckTrueTypePatents(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (byte)FaceCheckTrueTypePatents(__dsl_face);
            }
        }

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector) =>
            Underlying.Value!.FaceGetCharsOfVariant(face, variantSelector);

        [NativeName("FT_Face_GetCharsOfVariant")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetCharsOfVariant(__dsl_face, variantSelector);
            }
        }

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint FaceGetCharVariantIndex(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        ) => Underlying.Value!.FaceGetCharVariantIndex(face, charcode, variantSelector);

        [NativeName("FT_Face_GetCharVariantIndex")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint FaceGetCharVariantIndex(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)FaceGetCharVariantIndex(__dsl_face, charcode, variantSelector);
            }
        }

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceGetCharVariantIsDefault(
            FaceRec* face,
            ulong charcode,
            ulong variantSelector
        ) => Underlying.Value!.FaceGetCharVariantIsDefault(face, charcode, variantSelector);

        [NativeName("FT_Face_GetCharVariantIsDefault")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceGetCharVariantIsDefault(
            Ref<FaceRec> face,
            ulong charcode,
            ulong variantSelector
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)FaceGetCharVariantIsDefault(__dsl_face, charcode, variantSelector);
            }
        }

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint* FaceGetVariantSelectors(FaceRec* face) =>
            Underlying.Value!.FaceGetVariantSelectors(face);

        [NativeName("FT_Face_GetVariantSelectors")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetVariantSelectors(__dsl_face);
            }
        }

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode) =>
            Underlying.Value!.FaceGetVariantsOfChar(face, charcode);

        [NativeName("FT_Face_GetVariantsOfChar")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint*)FaceGetVariantsOfChar(__dsl_face, charcode);
            }
        }

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceProperties(
            FaceRec* face,
            uint num_properties,
            Parameter* properties
        ) => Underlying.Value!.FaceProperties(face, num_properties, properties);

        [NativeName("FT_Face_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int FaceProperties(
            Ref<FaceRec> face,
            uint num_properties,
            Ref<Parameter> properties
        )
        {
            fixed (Parameter* __dsl_properties = properties)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)FaceProperties(__dsl_face, num_properties, __dsl_properties);
            }
        }

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceSetUnpatentedHinting(FaceRec* face, byte value) =>
            Underlying.Value!.FaceSetUnpatentedHinting(face, value);

        [NativeName("FT_Face_SetUnpatentedHinting")]
        [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (byte)FaceSetUnpatentedHinting(__dsl_face, value);
            }
        }

        [NativeName("FT_FloorFix")]
        [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long FloorFix(long a) => Underlying.Value!.FloorFix(a);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetCharIndex(FaceRec* face, ulong charcode) =>
            Underlying.Value!.GetCharIndex(face, charcode);

        [NativeName("FT_Get_Char_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetCharIndex(Ref<FaceRec> face, ulong charcode)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)GetCharIndex(__dsl_face, charcode);
            }
        }

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetCharmapIndex(CharMapRec* charmap) =>
            Underlying.Value!.GetCharmapIndex(charmap);

        [NativeName("FT_Get_Charmap_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetCharmapIndex(Ref<CharMapRec> charmap)
        {
            fixed (CharMapRec* __dsl_charmap = charmap)
            {
                return (int)GetCharmapIndex(__dsl_charmap);
            }
        }

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetFirstChar(FaceRec* face, uint* agindex) =>
            Underlying.Value!.GetFirstChar(face, agindex);

        [NativeName("FT_Get_First_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex)
        {
            fixed (uint* __dsl_agindex = agindex)
            fixed (FaceRec* __dsl_face = face)
            {
                return (ulong)GetFirstChar(__dsl_face, __dsl_agindex);
            }
        }

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ushort GetFSTypeFlags(FaceRec* face) =>
            Underlying.Value!.GetFSTypeFlags(face);

        [NativeName("FT_Get_FSType_Flags")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ushort GetFSTypeFlags(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (ushort)GetFSTypeFlags(__dsl_face);
            }
        }

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetGlyphName(
            FaceRec* face,
            uint glyph_index,
            void* buffer,
            uint buffer_max
        ) => Underlying.Value!.GetGlyphName(face, glyph_index, buffer, buffer_max);

        [NativeName("FT_Get_Glyph_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetGlyphName(
            Ref<FaceRec> face,
            uint glyph_index,
            Ref buffer,
            uint buffer_max
        )
        {
            fixed (void* __dsl_buffer = buffer)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetGlyphName(__dsl_face, glyph_index, __dsl_buffer, buffer_max);
            }
        }

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetKerning(
            FaceRec* face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Vector* akerning
        ) => Underlying.Value!.GetKerning(face, left_glyph, right_glyph, kern_mode, akerning);

        [NativeName("FT_Get_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetKerning(
            Ref<FaceRec> face,
            uint left_glyph,
            uint right_glyph,
            uint kern_mode,
            Ref<Vector> akerning
        )
        {
            fixed (Vector* __dsl_akerning = akerning)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetKerning(
                    __dsl_face,
                    left_glyph,
                    right_glyph,
                    kern_mode,
                    __dsl_akerning
                );
            }
        }

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ModuleRecHandle GetModule(LibraryRecHandle library, sbyte* module_name) =>
            Underlying.Value!.GetModule(library, module_name);

        [NativeName("FT_Get_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name)
        {
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (ModuleRecHandle)GetModule(library, __dsl_module_name);
            }
        }

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetNameIndex(FaceRec* face, sbyte* glyph_name) =>
            Underlying.Value!.GetNameIndex(face, glyph_name);

        [NativeName("FT_Get_Name_Index")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name)
        {
            fixed (sbyte* __dsl_glyph_name = glyph_name)
            fixed (FaceRec* __dsl_face = face)
            {
                return (uint)GetNameIndex(__dsl_face, __dsl_glyph_name);
            }
        }

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex) =>
            Underlying.Value!.GetNextChar(face, char_code, agindex);

        [NativeName("FT_Get_Next_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex)
        {
            fixed (uint* __dsl_agindex = agindex)
            fixed (FaceRec* __dsl_face = face)
            {
                return (ulong)GetNextChar(__dsl_face, char_code, __dsl_agindex);
            }
        }

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetPostscriptName(FaceRec* face) =>
            Underlying.Value!.GetPostscriptName(face);

        [NativeName("FT_Get_Postscript_Name")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (sbyte*)GetPostscriptName(__dsl_face);
            }
        }

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetSubGlyphInfo(
            GlyphSlotRec* glyph,
            uint sub_index,
            int* p_index,
            uint* p_flags,
            int* p_arg1,
            int* p_arg2,
            Matrix* p_transform
        ) =>
            Underlying.Value!.GetSubGlyphInfo(
                glyph,
                sub_index,
                p_index,
                p_flags,
                p_arg1,
                p_arg2,
                p_transform
            );

        [NativeName("FT_Get_SubGlyph_Info")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetSubGlyphInfo(
            Ref<GlyphSlotRec> glyph,
            uint sub_index,
            Ref<int> p_index,
            Ref<uint> p_flags,
            Ref<int> p_arg1,
            Ref<int> p_arg2,
            Ref<Matrix> p_transform
        )
        {
            fixed (Matrix* __dsl_p_transform = p_transform)
            fixed (int* __dsl_p_arg2 = p_arg2)
            fixed (int* __dsl_p_arg1 = p_arg1)
            fixed (uint* __dsl_p_flags = p_flags)
            fixed (int* __dsl_p_index = p_index)
            fixed (GlyphSlotRec* __dsl_glyph = glyph)
            {
                return (int)GetSubGlyphInfo(
                    __dsl_glyph,
                    sub_index,
                    __dsl_p_index,
                    __dsl_p_flags,
                    __dsl_p_arg1,
                    __dsl_p_arg2,
                    __dsl_p_transform
                );
            }
        }

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetTrackKerning(
            FaceRec* face,
            long point_size,
            int degree,
            long* akerning
        ) => Underlying.Value!.GetTrackKerning(face, point_size, degree, akerning);

        [NativeName("FT_Get_Track_Kerning")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetTrackKerning(
            Ref<FaceRec> face,
            long point_size,
            int degree,
            Ref<long> akerning
        )
        {
            fixed (long* __dsl_akerning = akerning)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)GetTrackKerning(__dsl_face, point_size, degree, __dsl_akerning);
            }
        }

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
            Underlying.Value!.GetTransform(face, matrix, delta);

        [NativeName("FT_Get_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
        {
            fixed (Vector* __dsl_delta = delta)
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (FaceRec* __dsl_face = face)
            {
                GetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
            }
        }

        [NativeName("FT_Get_TrueType_Engine_Type")]
        [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library) =>
            Underlying.Value!.GetTrueTypeEngineType(library);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int InitFreeType(LibraryRecHandle* alibrary) =>
            Underlying.Value!.InitFreeType(alibrary);

        [NativeName("FT_Init_FreeType")]
        [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int InitFreeType(Ref<LibraryRecHandle> alibrary)
        {
            fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
            {
                return (int)InitFreeType(__dsl_alibrary);
            }
        }

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void LibraryVersion(
            LibraryRecHandle library,
            int* amajor,
            int* aminor,
            int* apatch
        ) => Underlying.Value!.LibraryVersion(library, amajor, aminor, apatch);

        [NativeName("FT_Library_Version")]
        [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void LibraryVersion(
            LibraryRecHandle library,
            Ref<int> amajor,
            Ref<int> aminor,
            Ref<int> apatch
        )
        {
            fixed (int* __dsl_apatch = apatch)
            fixed (int* __dsl_aminor = aminor)
            fixed (int* __dsl_amajor = amajor)
            {
                LibraryVersion(library, __dsl_amajor, __dsl_aminor, __dsl_apatch);
            }
        }

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadChar(FaceRec* face, ulong char_code, int load_flags) =>
            Underlying.Value!.LoadChar(face, char_code, load_flags);

        [NativeName("FT_Load_Char")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)LoadChar(__dsl_face, char_code, load_flags);
            }
        }

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags) =>
            Underlying.Value!.LoadGlyph(face, glyph_index, load_flags);

        [NativeName("FT_Load_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)LoadGlyph(__dsl_face, glyph_index, load_flags);
            }
        }

        [NativeName("FT_MulDiv")]
        [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long MulDiv(long a, long b, long c) => Underlying.Value!.MulDiv(a, b, c);

        [NativeName("FT_MulFix")]
        [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long MulFix(long a, long b) => Underlying.Value!.MulFix(a, b);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewFace(
            LibraryRecHandle library,
            sbyte* filepathname,
            long face_index,
            FaceRec** aface
        ) => Underlying.Value!.NewFace(library, filepathname, face_index, aface);

        [NativeName("FT_New_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewFace(
            LibraryRecHandle library,
            Ref<sbyte> filepathname,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (sbyte* __dsl_filepathname = filepathname)
            {
                return (int)NewFace(library, __dsl_filepathname, face_index, __dsl_aface);
            }
        }

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary) =>
            Underlying.Value!.NewLibrary(memory, alibrary);

        [NativeName("FT_New_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary)
        {
            fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
            fixed (MemoryRec* __dsl_memory = memory)
            {
                return (int)NewLibrary(__dsl_memory, __dsl_alibrary);
            }
        }

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewMemoryFace(
            LibraryRecHandle library,
            byte* file_base,
            long file_size,
            long face_index,
            FaceRec** aface
        ) => Underlying.Value!.NewMemoryFace(library, file_base, file_size, face_index, aface);

        [NativeName("FT_New_Memory_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int NewMemoryFace(
            LibraryRecHandle library,
            Ref<byte> file_base,
            long file_size,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (byte* __dsl_file_base = file_base)
            {
                return (int)NewMemoryFace(
                    library,
                    __dsl_file_base,
                    file_size,
                    face_index,
                    __dsl_aface
                );
            }
        }

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OpenFace(
            LibraryRecHandle library,
            OpenArgs* args,
            long face_index,
            FaceRec** aface
        ) => Underlying.Value!.OpenFace(library, args, face_index, aface);

        [NativeName("FT_Open_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OpenFace(
            LibraryRecHandle library,
            Ref<OpenArgs> args,
            long face_index,
            Ref2D<FaceRec> aface
        )
        {
            fixed (FaceRec** __dsl_aface = aface)
            fixed (OpenArgs* __dsl_args = args)
            {
                return (int)OpenFace(library, __dsl_args, face_index, __dsl_aface);
            }
        }

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCheck(Outline* outline) => Underlying.Value!.OutlineCheck(outline);

        [NativeName("FT_Outline_Check")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCheck(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineCheck(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCopy(Outline* source, Outline* target) =>
            Underlying.Value!.OutlineCopy(source, target);

        [NativeName("FT_Outline_Copy")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineCopy(Ref<Outline> source, Ref<Outline> target)
        {
            fixed (Outline* __dsl_target = target)
            fixed (Outline* __dsl_source = source)
            {
                return (int)OutlineCopy(__dsl_source, __dsl_target);
            }
        }

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDecompose(
            Outline* outline,
            OutlineFuncs* func_interface,
            void* user
        ) => Underlying.Value!.OutlineDecompose(outline, func_interface, user);

        [NativeName("FT_Outline_Decompose")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDecompose(
            Ref<Outline> outline,
            Ref<OutlineFuncs> func_interface,
            Ref user
        )
        {
            fixed (void* __dsl_user = user)
            fixed (OutlineFuncs* __dsl_func_interface = func_interface)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineDecompose(__dsl_outline, __dsl_func_interface, __dsl_user);
            }
        }

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDone(LibraryRecHandle library, Outline* outline) =>
            Underlying.Value!.OutlineDone(library, outline);

        [NativeName("FT_Outline_Done")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineDone(LibraryRecHandle library, Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineDone(library, __dsl_outline);
            }
        }

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmbolden(Outline* outline, long strength) =>
            Underlying.Value!.OutlineEmbolden(outline, strength);

        [NativeName("FT_Outline_Embolden")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmbolden(Ref<Outline> outline, long strength)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineEmbolden(__dsl_outline, strength);
            }
        }

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength) =>
            Underlying.Value!.OutlineEmboldenXY(outline, xstrength, ystrength);

        [NativeName("FT_Outline_EmboldenXY")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineEmboldenXY(__dsl_outline, xstrength, ystrength);
            }
        }

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineGetBitmap(
            LibraryRecHandle library,
            Outline* outline,
            Bitmap* abitmap
        ) => Underlying.Value!.OutlineGetBitmap(library, outline, abitmap);

        [NativeName("FT_Outline_Get_Bitmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineGetBitmap(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<Bitmap> abitmap
        )
        {
            fixed (Bitmap* __dsl_abitmap = abitmap)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineGetBitmap(library, __dsl_outline, __dsl_abitmap);
            }
        }

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineGetCBox(Outline* outline, BBox* acbox) =>
            Underlying.Value!.OutlineGetCBox(outline, acbox);

        [NativeName("FT_Outline_Get_CBox")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox)
        {
            fixed (BBox* __dsl_acbox = acbox)
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineGetCBox(__dsl_outline, __dsl_acbox);
            }
        }

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Orientation OutlineGetOrientation(Outline* outline) =>
            Underlying.Value!.OutlineGetOrientation(outline);

        [NativeName("FT_Outline_Get_Orientation")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Orientation OutlineGetOrientation(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                return (Orientation)OutlineGetOrientation(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Outline* anoutline
        ) => Underlying.Value!.OutlineNew(library, numPoints, numContours, anoutline);

        [NativeName("FT_Outline_New")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineNew(
            LibraryRecHandle library,
            uint numPoints,
            int numContours,
            Ref<Outline> anoutline
        )
        {
            fixed (Outline* __dsl_anoutline = anoutline)
            {
                return (int)OutlineNew(library, numPoints, numContours, __dsl_anoutline);
            }
        }

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineRender(
            LibraryRecHandle library,
            Outline* outline,
            RasterParams* @params
        ) => Underlying.Value!.OutlineRender(library, outline, @params);

        [NativeName("FT_Outline_Render")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int OutlineRender(
            LibraryRecHandle library,
            Ref<Outline> outline,
            Ref<RasterParams> @params
        )
        {
            fixed (RasterParams* __dsl_params = @params)
            fixed (Outline* __dsl_outline = outline)
            {
                return (int)OutlineRender(library, __dsl_outline, __dsl_params);
            }
        }

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineReverse(Outline* outline) =>
            Underlying.Value!.OutlineReverse(outline);

        [NativeName("FT_Outline_Reverse")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineReverse(Ref<Outline> outline)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineReverse(__dsl_outline);
            }
        }

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTransform(Outline* outline, Matrix* matrix) =>
            Underlying.Value!.OutlineTransform(outline, matrix);

        [NativeName("FT_Outline_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix)
        {
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineTransform(__dsl_outline, __dsl_matrix);
            }
        }

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTranslate(Outline* outline, long xOffset, long yOffset) =>
            Underlying.Value!.OutlineTranslate(outline, xOffset, yOffset);

        [NativeName("FT_Outline_Translate")]
        [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset)
        {
            fixed (Outline* __dsl_outline = outline)
            {
                OutlineTranslate(__dsl_outline, xOffset, yOffset);
            }
        }

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertyGet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        ) => Underlying.Value!.PropertyGet(library, module_name, property_name, value);

        [NativeName("FT_Property_Get")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertyGet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        )
        {
            fixed (void* __dsl_value = value)
            fixed (sbyte* __dsl_property_name = property_name)
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (int)PropertyGet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
            }
        }

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertySet(
            LibraryRecHandle library,
            sbyte* module_name,
            sbyte* property_name,
            void* value
        ) => Underlying.Value!.PropertySet(library, module_name, property_name, value);

        [NativeName("FT_Property_Set")]
        [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int PropertySet(
            LibraryRecHandle library,
            Ref<sbyte> module_name,
            Ref<sbyte> property_name,
            Ref value
        )
        {
            fixed (void* __dsl_value = value)
            fixed (sbyte* __dsl_property_name = property_name)
            fixed (sbyte* __dsl_module_name = module_name)
            {
                return (int)PropertySet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
            }
        }

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int ReferenceFace(FaceRec* face) => Underlying.Value!.ReferenceFace(face);

        [NativeName("FT_Reference_Face")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int ReferenceFace(Ref<FaceRec> face)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)ReferenceFace(__dsl_face);
            }
        }

        [NativeName("FT_Reference_Library")]
        [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int ReferenceLibrary(LibraryRecHandle library) =>
            Underlying.Value!.ReferenceLibrary(library);

        [NativeName("FT_Remove_Module")]
        [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RemoveModule(LibraryRecHandle library, ModuleRecHandle module) =>
            Underlying.Value!.RemoveModule(library, module);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode) =>
            Underlying.Value!.RenderGlyph(slot, render_mode);

        [NativeName("FT_Render_Glyph")]
        [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode)
        {
            fixed (GlyphSlotRec* __dsl_slot = slot)
            {
                return (int)RenderGlyph(__dsl_slot, render_mode);
            }
        }

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RequestSize(FaceRec* face, SizeRequestRec* req) =>
            Underlying.Value!.RequestSize(face, req);

        [NativeName("FT_Request_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req)
        {
            fixed (SizeRequestRec* __dsl_req = req)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)RequestSize(__dsl_face, __dsl_req);
            }
        }

        [NativeName("FT_RoundFix")]
        [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static long RoundFix(long a) => Underlying.Value!.RoundFix(a);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectCharmap(FaceRec* face, Encoding encoding) =>
            Underlying.Value!.SelectCharmap(face, encoding);

        [NativeName("FT_Select_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectCharmap(Ref<FaceRec> face, Encoding encoding)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SelectCharmap(__dsl_face, encoding);
            }
        }

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectSize(FaceRec* face, int strike_index) =>
            Underlying.Value!.SelectSize(face, strike_index);

        [NativeName("FT_Select_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SelectSize(Ref<FaceRec> face, int strike_index)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SelectSize(__dsl_face, strike_index);
            }
        }

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharSize(
            FaceRec* face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        ) =>
            Underlying.Value!.SetCharSize(
                face,
                char_width,
                char_height,
                horz_resolution,
                vert_resolution
            );

        [NativeName("FT_Set_Char_Size")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharSize(
            Ref<FaceRec> face,
            long char_width,
            long char_height,
            uint horz_resolution,
            uint vert_resolution
        )
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetCharSize(
                    __dsl_face,
                    char_width,
                    char_height,
                    horz_resolution,
                    vert_resolution
                );
            }
        }

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharmap(FaceRec* face, CharMapRec* charmap) =>
            Underlying.Value!.SetCharmap(face, charmap);

        [NativeName("FT_Set_Charmap")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap)
        {
            fixed (CharMapRec* __dsl_charmap = charmap)
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetCharmap(__dsl_face, __dsl_charmap);
            }
        }

        [NativeName("FT_Set_Debug_Hook")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetDebugHook(
            LibraryRecHandle library,
            uint hook_index,
            DebugHookFunc debug_hook
        ) => Underlying.Value!.SetDebugHook(library, hook_index, debug_hook);

        [NativeName("FT_Set_Default_Properties")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetDefaultProperties(LibraryRecHandle library) =>
            Underlying.Value!.SetDefaultProperties(library);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height) =>
            Underlying.Value!.SetPixelSizes(face, pixel_width, pixel_height);

        [NativeName("FT_Set_Pixel_Sizes")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height)
        {
            fixed (FaceRec* __dsl_face = face)
            {
                return (int)SetPixelSizes(__dsl_face, pixel_width, pixel_height);
            }
        }

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
            Underlying.Value!.SetTransform(face, matrix, delta);

        [NativeName("FT_Set_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
        {
            fixed (Vector* __dsl_delta = delta)
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (FaceRec* __dsl_face = face)
            {
                SetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
            }
        }

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void VectorTransform(Vector* vector, Matrix* matrix) =>
            Underlying.Value!.VectorTransform(vector, matrix);

        [NativeName("FT_Vector_Transform")]
        [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix)
        {
            fixed (Matrix* __dsl_matrix = matrix)
            fixed (Vector* __dsl_vector = vector)
            {
                VectorTransform(__dsl_vector, __dsl_matrix);
            }
        }
    }

    [NativeName("FT_Mod_Err_Base")]
    public const uint ModErrBase = 0;

    [NativeName("FT_Mod_Err_Autofit")]
    public const uint ModErrAutofit = 0;

    [NativeName("FT_Mod_Err_BDF")]
    public const uint ModErrBdf = 0;

    [NativeName("FT_Mod_Err_Bzip2")]
    public const uint ModErrBzip2 = 0;

    [NativeName("FT_Mod_Err_Cache")]
    public const uint ModErrCache = 0;

    [NativeName("FT_Mod_Err_CFF")]
    public const uint ModErrCff = 0;

    [NativeName("FT_Mod_Err_CID")]
    public const uint ModErrCid = 0;

    [NativeName("FT_Mod_Err_Gzip")]
    public const uint ModErrGzip = 0;

    [NativeName("FT_Mod_Err_LZW")]
    public const uint ModErrLzw = 0;

    [NativeName("FT_Mod_Err_OTvalid")]
    public const uint ModErrOTvalid = 0;

    [NativeName("FT_Mod_Err_PCF")]
    public const uint ModErrPcf = 0;

    [NativeName("FT_Mod_Err_PFR")]
    public const uint ModErrPfr = 0;

    [NativeName("FT_Mod_Err_PSaux")]
    public const uint ModErrPSaux = 0;

    [NativeName("FT_Mod_Err_PShinter")]
    public const uint ModErrPShinter = 0;

    [NativeName("FT_Mod_Err_PSnames")]
    public const uint ModErrPSnames = 0;

    [NativeName("FT_Mod_Err_Raster")]
    public const uint ModErrRaster = 0;

    [NativeName("FT_Mod_Err_SFNT")]
    public const uint ModErrSfnt = 0;

    [NativeName("FT_Mod_Err_Smooth")]
    public const uint ModErrSmooth = 0;

    [NativeName("FT_Mod_Err_TrueType")]
    public const uint ModErrTrueType = 0;

    [NativeName("FT_Mod_Err_Type1")]
    public const uint ModErrType1 = 0;

    [NativeName("FT_Mod_Err_Type42")]
    public const uint ModErrType42 = 0;

    [NativeName("FT_Mod_Err_Winfonts")]
    public const uint ModErrWinfonts = 0;

    [NativeName("FT_Mod_Err_GXvalid")]
    public const uint ModErrGXvalid = 0;

    [NativeName("FT_Mod_Err_Sdf")]
    public const uint ModErrSdf = 0;

    [NativeName("FT_Mod_Err_Max")]
    public const uint ModErrMax = 1;

    [NativeName("FT_Err_Ok")]
    public const uint ErrOk = 0x00;

    [NativeName("FT_Err_Cannot_Open_Resource")]
    public const uint ErrCannotOpenResource = 0x01 + 0;

    [NativeName("FT_Err_Unknown_File_Format")]
    public const uint ErrUnknownFileFormat = 0x02 + 0;

    [NativeName("FT_Err_Invalid_File_Format")]
    public const uint ErrInvalidFileFormat = 0x03 + 0;

    [NativeName("FT_Err_Invalid_Version")]
    public const uint ErrInvalidVersion = 0x04 + 0;

    [NativeName("FT_Err_Lower_Module_Version")]
    public const uint ErrLowerModuleVersion = 0x05 + 0;

    [NativeName("FT_Err_Invalid_Argument")]
    public const uint ErrInvalidArgument = 0x06 + 0;

    [NativeName("FT_Err_Unimplemented_Feature")]
    public const uint ErrUnimplementedFeature = 0x07 + 0;

    [NativeName("FT_Err_Invalid_Table")]
    public const uint ErrInvalidTable = 0x08 + 0;

    [NativeName("FT_Err_Invalid_Offset")]
    public const uint ErrInvalidOffset = 0x09 + 0;

    [NativeName("FT_Err_Array_Too_Large")]
    public const uint ErrArrayTooLarge = 0x0A + 0;

    [NativeName("FT_Err_Missing_Module")]
    public const uint ErrMissingModule = 0x0B + 0;

    [NativeName("FT_Err_Missing_Property")]
    public const uint ErrMissingProperty = 0x0C + 0;

    [NativeName("FT_Err_Invalid_Glyph_Index")]
    public const uint ErrInvalidGlyphIndex = 0x10 + 0;

    [NativeName("FT_Err_Invalid_Character_Code")]
    public const uint ErrInvalidCharacterCode = 0x11 + 0;

    [NativeName("FT_Err_Invalid_Glyph_Format")]
    public const uint ErrInvalidGlyphFormat = 0x12 + 0;

    [NativeName("FT_Err_Cannot_Render_Glyph")]
    public const uint ErrCannotRenderGlyph = 0x13 + 0;

    [NativeName("FT_Err_Invalid_Outline")]
    public const uint ErrInvalidOutline = 0x14 + 0;

    [NativeName("FT_Err_Invalid_Composite")]
    public const uint ErrInvalidComposite = 0x15 + 0;

    [NativeName("FT_Err_Too_Many_Hints")]
    public const uint ErrTooManyHints = 0x16 + 0;

    [NativeName("FT_Err_Invalid_Pixel_Size")]
    public const uint ErrInvalidPixelSize = 0x17 + 0;

    [NativeName("FT_Err_Invalid_SVG_Document")]
    public const uint ErrInvalidSvgDocument = 0x18 + 0;

    [NativeName("FT_Err_Invalid_Handle")]
    public const uint ErrInvalidHandle = 0x20 + 0;

    [NativeName("FT_Err_Invalid_Library_Handle")]
    public const uint ErrInvalidLibraryHandle = 0x21 + 0;

    [NativeName("FT_Err_Invalid_Driver_Handle")]
    public const uint ErrInvalidDriverHandle = 0x22 + 0;

    [NativeName("FT_Err_Invalid_Face_Handle")]
    public const uint ErrInvalidFaceHandle = 0x23 + 0;

    [NativeName("FT_Err_Invalid_Size_Handle")]
    public const uint ErrInvalidSizeHandle = 0x24 + 0;

    [NativeName("FT_Err_Invalid_Slot_Handle")]
    public const uint ErrInvalidSlotHandle = 0x25 + 0;

    [NativeName("FT_Err_Invalid_CharMap_Handle")]
    public const uint ErrInvalidCharMapHandle = 0x26 + 0;

    [NativeName("FT_Err_Invalid_Cache_Handle")]
    public const uint ErrInvalidCacheHandle = 0x27 + 0;

    [NativeName("FT_Err_Invalid_Stream_Handle")]
    public const uint ErrInvalidStreamHandle = 0x28 + 0;

    [NativeName("FT_Err_Too_Many_Drivers")]
    public const uint ErrTooManyDrivers = 0x30 + 0;

    [NativeName("FT_Err_Too_Many_Extensions")]
    public const uint ErrTooManyExtensions = 0x31 + 0;

    [NativeName("FT_Err_Out_Of_Memory")]
    public const uint ErrOutOfMemory = 0x40 + 0;

    [NativeName("FT_Err_Unlisted_Object")]
    public const uint ErrUnlistedObject = 0x41 + 0;

    [NativeName("FT_Err_Cannot_Open_Stream")]
    public const uint ErrCannotOpenStream = 0x51 + 0;

    [NativeName("FT_Err_Invalid_Stream_Seek")]
    public const uint ErrInvalidStreamSeek = 0x52 + 0;

    [NativeName("FT_Err_Invalid_Stream_Skip")]
    public const uint ErrInvalidStreamSkip = 0x53 + 0;

    [NativeName("FT_Err_Invalid_Stream_Read")]
    public const uint ErrInvalidStreamRead = 0x54 + 0;

    [NativeName("FT_Err_Invalid_Stream_Operation")]
    public const uint ErrInvalidStreamOperation = 0x55 + 0;

    [NativeName("FT_Err_Invalid_Frame_Operation")]
    public const uint ErrInvalidFrameOperation = 0x56 + 0;

    [NativeName("FT_Err_Nested_Frame_Access")]
    public const uint ErrNestedFrameAccess = 0x57 + 0;

    [NativeName("FT_Err_Invalid_Frame_Read")]
    public const uint ErrInvalidFrameRead = 0x58 + 0;

    [NativeName("FT_Err_Raster_Uninitialized")]
    public const uint ErrRasterUninitialized = 0x60 + 0;

    [NativeName("FT_Err_Raster_Corrupted")]
    public const uint ErrRasterCorrupted = 0x61 + 0;

    [NativeName("FT_Err_Raster_Overflow")]
    public const uint ErrRasterOverflow = 0x62 + 0;

    [NativeName("FT_Err_Raster_Negative_Height")]
    public const uint ErrRasterNegativeHeight = 0x63 + 0;

    [NativeName("FT_Err_Too_Many_Caches")]
    public const uint ErrTooManyCaches = 0x70 + 0;

    [NativeName("FT_Err_Invalid_Opcode")]
    public const uint ErrInvalidOpcode = 0x80 + 0;

    [NativeName("FT_Err_Too_Few_Arguments")]
    public const uint ErrTooFewArguments = 0x81 + 0;

    [NativeName("FT_Err_Stack_Overflow")]
    public const uint ErrStackOverflow = 0x82 + 0;

    [NativeName("FT_Err_Code_Overflow")]
    public const uint ErrCodeOverflow = 0x83 + 0;

    [NativeName("FT_Err_Bad_Argument")]
    public const uint ErrBadArgument = 0x84 + 0;

    [NativeName("FT_Err_Divide_By_Zero")]
    public const uint ErrDivideByZero = 0x85 + 0;

    [NativeName("FT_Err_Invalid_Reference")]
    public const uint ErrInvalidReference = 0x86 + 0;

    [NativeName("FT_Err_Debug_OpCode")]
    public const uint ErrDebugOpCode = 0x87 + 0;

    [NativeName("FT_Err_ENDF_In_Exec_Stream")]
    public const uint ErrEndfInExecStream = 0x88 + 0;

    [NativeName("FT_Err_Nested_DEFS")]
    public const uint ErrNestedDefs = 0x89 + 0;

    [NativeName("FT_Err_Invalid_CodeRange")]
    public const uint ErrInvalidCodeRange = 0x8A + 0;

    [NativeName("FT_Err_Execution_Too_Long")]
    public const uint ErrExecutionTooLong = 0x8B + 0;

    [NativeName("FT_Err_Too_Many_Function_Defs")]
    public const uint ErrTooManyFunctionDefs = 0x8C + 0;

    [NativeName("FT_Err_Too_Many_Instruction_Defs")]
    public const uint ErrTooManyInstructionDefs = 0x8D + 0;

    [NativeName("FT_Err_Table_Missing")]
    public const uint ErrTableMissing = 0x8E + 0;

    [NativeName("FT_Err_Horiz_Header_Missing")]
    public const uint ErrHorizHeaderMissing = 0x8F + 0;

    [NativeName("FT_Err_Locations_Missing")]
    public const uint ErrLocationsMissing = 0x90 + 0;

    [NativeName("FT_Err_Name_Table_Missing")]
    public const uint ErrNameTableMissing = 0x91 + 0;

    [NativeName("FT_Err_CMap_Table_Missing")]
    public const uint ErrCMapTableMissing = 0x92 + 0;

    [NativeName("FT_Err_Hmtx_Table_Missing")]
    public const uint ErrHmtxTableMissing = 0x93 + 0;

    [NativeName("FT_Err_Post_Table_Missing")]
    public const uint ErrPostTableMissing = 0x94 + 0;

    [NativeName("FT_Err_Invalid_Horiz_Metrics")]
    public const uint ErrInvalidHorizMetrics = 0x95 + 0;

    [NativeName("FT_Err_Invalid_CharMap_Format")]
    public const uint ErrInvalidCharMapFormat = 0x96 + 0;

    [NativeName("FT_Err_Invalid_PPem")]
    public const uint ErrInvalidPPem = 0x97 + 0;

    [NativeName("FT_Err_Invalid_Vert_Metrics")]
    public const uint ErrInvalidVertMetrics = 0x98 + 0;

    [NativeName("FT_Err_Could_Not_Find_Context")]
    public const uint ErrCouldNotFindContext = 0x99 + 0;

    [NativeName("FT_Err_Invalid_Post_Table_Format")]
    public const uint ErrInvalidPostTableFormat = 0x9A + 0;

    [NativeName("FT_Err_Invalid_Post_Table")]
    public const uint ErrInvalidPostTable = 0x9B + 0;

    [NativeName("FT_Err_DEF_In_Glyf_Bytecode")]
    public const uint ErrDefInGlyfBytecode = 0x9C + 0;

    [NativeName("FT_Err_Missing_Bitmap")]
    public const uint ErrMissingBitmap = 0x9D + 0;

    [NativeName("FT_Err_Missing_SVG_Hooks")]
    public const uint ErrMissingSvgHooks = 0x9E + 0;

    [NativeName("FT_Err_Syntax_Error")]
    public const uint ErrSyntaxError = 0xA0 + 0;

    [NativeName("FT_Err_Stack_Underflow")]
    public const uint ErrStackUnderflow = 0xA1 + 0;

    [NativeName("FT_Err_Ignore")]
    public const uint ErrIgnore = 0xA2 + 0;

    [NativeName("FT_Err_No_Unicode_Glyph_Name")]
    public const uint ErrNoUnicodeGlyphName = 0xA3 + 0;

    [NativeName("FT_Err_Glyph_Too_Big")]
    public const uint ErrGlyphTooBig = 0xA4 + 0;

    [NativeName("FT_Err_Missing_Startfont_Field")]
    public const uint ErrMissingStartfontField = 0xB0 + 0;

    [NativeName("FT_Err_Missing_Font_Field")]
    public const uint ErrMissingFontField = 0xB1 + 0;

    [NativeName("FT_Err_Missing_Size_Field")]
    public const uint ErrMissingSizeField = 0xB2 + 0;

    [NativeName("FT_Err_Missing_Fontboundingbox_Field")]
    public const uint ErrMissingFontboundingboxField = 0xB3 + 0;

    [NativeName("FT_Err_Missing_Chars_Field")]
    public const uint ErrMissingCharsField = 0xB4 + 0;

    [NativeName("FT_Err_Missing_Startchar_Field")]
    public const uint ErrMissingStartcharField = 0xB5 + 0;

    [NativeName("FT_Err_Missing_Encoding_Field")]
    public const uint ErrMissingEncodingField = 0xB6 + 0;

    [NativeName("FT_Err_Missing_Bbx_Field")]
    public const uint ErrMissingBbxField = 0xB7 + 0;

    [NativeName("FT_Err_Bbx_Too_Big")]
    public const uint ErrBbxTooBig = 0xB8 + 0;

    [NativeName("FT_Err_Corrupted_Font_Header")]
    public const uint ErrCorruptedFontHeader = 0xB9 + 0;

    [NativeName("FT_Err_Corrupted_Font_Glyphs")]
    public const uint ErrCorruptedFontGlyphs = 0xBA + 0;

    [NativeName("FT_Err_Max")]
    public const uint ErrMax = 187;

    [NativeName("FT_CHAR_BIT")]
    public const int CharBit = 8;

    [NativeName("FT_USHORT_MAX")]
    public const int UshortMax = (32767 * 2 + 1);

    [NativeName("FT_INT_MAX")]
    public const int IntMax = 2147483647;

    [NativeName("FT_INT_MIN")]
    public const int IntMin = (-2147483647 - 1);

    [NativeName("FT_UINT_MAX")]
    public const uint UintMax = (2147483647 * 2U + 1U);

    [NativeName("FT_LONG_MIN")]
    public static nint LongMin => unchecked((nint)(-9223372036854775807 - 1));

    [NativeName("FT_LONG_MAX")]
    public static nint LongMax => unchecked((nint)(9223372036854775807));

    [NativeName("FT_ULONG_MAX")]
    public static nuint UlongMax => unchecked((nuint)(9223372036854775807 * 2U + 1U));

    [NativeName("FT_LLONG_MAX")]
    public const long LlongMax = 9223372036854775807L;

    [NativeName("FT_LLONG_MIN")]
    public const long LlongMin = (-9223372036854775807L - 1L);

    [NativeName("FT_ULLONG_MAX")]
    public const ulong UllongMax = (9223372036854775807L * 2UL + 1UL);

    [NativeName("FT_SIZEOF_INT")]
    public const int SizeofInt = (32 / 8);

    [NativeName("FT_SIZEOF_LONG")]
    public const int SizeofLong = (64 / 8);

    [NativeName("FT_SIZEOF_LONG_LONG")]
    public const int SizeofLongLong = (64 / 8);

    [NativeName("FT_INT64_ZERO")]
    public const int Int64Zero = 0;

    [NativeName("ft_pixel_mode_none")]
    public const PixelMode PixelModeNone = PixelMode.None;

    [NativeName("ft_pixel_mode_mono")]
    public const PixelMode PixelModeMono = PixelMode.Mono;

    [NativeName("ft_pixel_mode_grays")]
    public const PixelMode PixelModeGrays = PixelMode.Gray;

    [NativeName("ft_pixel_mode_pal2")]
    public const PixelMode PixelModePal2 = PixelMode.Gray2;

    [NativeName("ft_pixel_mode_pal4")]
    public const PixelMode PixelModePal4 = PixelMode.Gray4;

    [NativeName("FT_OUTLINE_CONTOURS_MAX")]
    public const int OutlineContoursMax = (32767 * 2 + 1);

    [NativeName("FT_OUTLINE_POINTS_MAX")]
    public const int OutlinePointsMax = (32767 * 2 + 1);

    [NativeName("FT_OUTLINE_NONE")]
    public const int OutlineNone = 0x0;

    [NativeName("FT_OUTLINE_OWNER")]
    public const int OutlineOwner = 0x1;

    [NativeName("FT_OUTLINE_EVEN_ODD_FILL")]
    public const int OutlineEvenOddFill = 0x2;

    [NativeName("FT_OUTLINE_REVERSE_FILL")]
    public const int OutlineReverseFill = 0x4;

    [NativeName("FT_OUTLINE_IGNORE_DROPOUTS")]
    public const int OutlineIgnoreDropouts = 0x8;

    [NativeName("FT_OUTLINE_SMART_DROPOUTS")]
    public const int OutlineSmartDropouts = 0x10;

    [NativeName("FT_OUTLINE_INCLUDE_STUBS")]
    public const int OutlineIncludeStubs = 0x20;

    [NativeName("FT_OUTLINE_OVERLAP")]
    public const int OutlineOverlap = 0x40;

    [NativeName("FT_OUTLINE_HIGH_PRECISION")]
    public const int OutlineHighPrecision = 0x100;

    [NativeName("FT_OUTLINE_SINGLE_PASS")]
    public const int OutlineSinglePass = 0x200;

    [NativeName("FT_CURVE_TAG_ON")]
    public const int CurveTagOn = 0x01;

    [NativeName("FT_CURVE_TAG_CONIC")]
    public const int CurveTagConic = 0x00;

    [NativeName("FT_CURVE_TAG_CUBIC")]
    public const int CurveTagCubic = 0x02;

    [NativeName("FT_CURVE_TAG_HAS_SCANMODE")]
    public const int CurveTagHasScanmode = 0x04;

    [NativeName("FT_CURVE_TAG_TOUCH_X")]
    public const int CurveTagTouchX = 0x08;

    [NativeName("FT_CURVE_TAG_TOUCH_Y")]
    public const int CurveTagTouchY = 0x10;

    [NativeName("FT_CURVE_TAG_TOUCH_BOTH")]
    public const int CurveTagTouchBoth = (0x08 | 0x10);

    [NativeName("ft_glyph_format_none")]
    public const GlyphFormat GlyphFormatNone = GlyphFormat.None;

    [NativeName("ft_glyph_format_composite")]
    public const GlyphFormat GlyphFormatComposite = GlyphFormat.Composite;

    [NativeName("ft_glyph_format_bitmap")]
    public const GlyphFormat GlyphFormatBitmap = GlyphFormat.Bitmap;

    [NativeName("ft_glyph_format_outline")]
    public const GlyphFormat GlyphFormatOutline = GlyphFormat.Outline;

    [NativeName("ft_glyph_format_plotter")]
    public const GlyphFormat GlyphFormatPlotter = GlyphFormat.Plotter;

    [NativeName("FT_RASTER_FLAG_DEFAULT")]
    public const int RasterFlagDefault = 0x0;

    [NativeName("FT_RASTER_FLAG_AA")]
    public const int RasterFlagAa = 0x1;

    [NativeName("FT_RASTER_FLAG_DIRECT")]
    public const int RasterFlagDirect = 0x2;

    [NativeName("FT_RASTER_FLAG_CLIP")]
    public const int RasterFlagClip = 0x4;

    [NativeName("FT_RASTER_FLAG_SDF")]
    public const int RasterFlagSdf = 0x8;

    [NativeName("FT_ERR_BASE")]
    public const int ErrBase = 0;

    [NativeName("ft_encoding_none")]
    public const Encoding EncodingNone = Encoding.None;

    [NativeName("ft_encoding_unicode")]
    public const Encoding EncodingUnicode = Encoding.Unicode;

    [NativeName("ft_encoding_symbol")]
    public const Encoding EncodingSymbol = Encoding.MsSymbol;

    [NativeName("ft_encoding_latin_1")]
    public const Encoding EncodingLatin1 = Encoding.AdobeLatin1;

    [NativeName("ft_encoding_latin_2")]
    public const Encoding EncodingLatin2 = Encoding.OldLatin2;

    [NativeName("ft_encoding_sjis")]
    public const Encoding EncodingSjis = Encoding.Sjis;

    [NativeName("ft_encoding_gb2312")]
    public const Encoding EncodingGb2312 = Encoding.Prc;

    [NativeName("ft_encoding_big5")]
    public const Encoding EncodingBig5 = Encoding.Big5;

    [NativeName("ft_encoding_wansung")]
    public const Encoding EncodingWansung = Encoding.Wansung;

    [NativeName("ft_encoding_johab")]
    public const Encoding EncodingJohab = Encoding.Johab;

    [NativeName("ft_encoding_adobe_standard")]
    public const Encoding EncodingAdobeStandard = Encoding.AdobeStandard;

    [NativeName("ft_encoding_adobe_expert")]
    public const Encoding EncodingAdobeExpert = Encoding.AdobeExpert;

    [NativeName("ft_encoding_adobe_custom")]
    public const Encoding EncodingAdobeCustom = Encoding.AdobeCustom;

    [NativeName("ft_encoding_apple_roman")]
    public const Encoding EncodingAppleRoman = Encoding.AppleRoman;

    [NativeName("FT_FACE_FLAG_SCALABLE")]
    public const nint FaceFlagScalable = (1 << 0);

    [NativeName("FT_FACE_FLAG_FIXED_SIZES")]
    public const nint FaceFlagFixedSizes = (1 << 1);

    [NativeName("FT_FACE_FLAG_FIXED_WIDTH")]
    public const nint FaceFlagFixedWidth = (1 << 2);

    [NativeName("FT_FACE_FLAG_SFNT")]
    public const nint FaceFlagSfnt = (1 << 3);

    [NativeName("FT_FACE_FLAG_HORIZONTAL")]
    public const nint FaceFlagHorizontal = (1 << 4);

    [NativeName("FT_FACE_FLAG_VERTICAL")]
    public const nint FaceFlagVertical = (1 << 5);

    [NativeName("FT_FACE_FLAG_KERNING")]
    public const nint FaceFlagKerning = (1 << 6);

    [NativeName("FT_FACE_FLAG_FAST_GLYPHS")]
    public const nint FaceFlagFastGlyphs = (1 << 7);

    [NativeName("FT_FACE_FLAG_MULTIPLE_MASTERS")]
    public const nint FaceFlagMultipleMasters = (1 << 8);

    [NativeName("FT_FACE_FLAG_GLYPH_NAMES")]
    public const nint FaceFlagGlyphNames = (1 << 9);

    [NativeName("FT_FACE_FLAG_EXTERNAL_STREAM")]
    public const nint FaceFlagExternalStream = (1 << 10);

    [NativeName("FT_FACE_FLAG_HINTER")]
    public const nint FaceFlagHinter = (1 << 11);

    [NativeName("FT_FACE_FLAG_CID_KEYED")]
    public const nint FaceFlagCidKeyed = (1 << 12);

    [NativeName("FT_FACE_FLAG_TRICKY")]
    public const nint FaceFlagTricky = (1 << 13);

    [NativeName("FT_FACE_FLAG_COLOR")]
    public const nint FaceFlagColor = (1 << 14);

    [NativeName("FT_FACE_FLAG_VARIATION")]
    public const nint FaceFlagVariation = (1 << 15);

    [NativeName("FT_FACE_FLAG_SVG")]
    public const nint FaceFlagSvg = (1 << 16);

    [NativeName("FT_FACE_FLAG_SBIX")]
    public const nint FaceFlagSbix = (1 << 17);

    [NativeName("FT_FACE_FLAG_SBIX_OVERLAY")]
    public const nint FaceFlagSbixOverlay = (1 << 18);

    [NativeName("FT_STYLE_FLAG_ITALIC")]
    public const int StyleFlagItalic = (1 << 0);

    [NativeName("FT_STYLE_FLAG_BOLD")]
    public const int StyleFlagBold = (1 << 1);

    [NativeName("FT_OPEN_MEMORY")]
    public const int OpenMemory = 0x1;

    [NativeName("FT_OPEN_STREAM")]
    public const int OpenStream = 0x2;

    [NativeName("FT_OPEN_PATHNAME")]
    public const int OpenPathname = 0x4;

    [NativeName("FT_OPEN_DRIVER")]
    public const int OpenDriver = 0x8;

    [NativeName("FT_OPEN_PARAMS")]
    public const int OpenParams = 0x10;

    [NativeName("FT_LOAD_DEFAULT")]
    public const int LoadDefault = 0x0;

    [NativeName("FT_LOAD_NO_SCALE")]
    public const nint LoadNoScale = (1 << 0);

    [NativeName("FT_LOAD_NO_HINTING")]
    public const nint LoadNoHinting = (1 << 1);

    [NativeName("FT_LOAD_RENDER")]
    public const nint LoadRender = (1 << 2);

    [NativeName("FT_LOAD_NO_BITMAP")]
    public const nint LoadNoBitmap = (1 << 3);

    [NativeName("FT_LOAD_VERTICAL_LAYOUT")]
    public const nint LoadVerticalLayout = (1 << 4);

    [NativeName("FT_LOAD_FORCE_AUTOHINT")]
    public const nint LoadForceAutohint = (1 << 5);

    [NativeName("FT_LOAD_CROP_BITMAP")]
    public const nint LoadCropBitmap = (1 << 6);

    [NativeName("FT_LOAD_PEDANTIC")]
    public const nint LoadPedantic = (1 << 7);

    [NativeName("FT_LOAD_IGNORE_GLOBAL_ADVANCE_WIDTH")]
    public const nint LoadIgnoreGlobalAdvanceWidth = (1 << 9);

    [NativeName("FT_LOAD_NO_RECURSE")]
    public const nint LoadNoRecurse = (1 << 10);

    [NativeName("FT_LOAD_IGNORE_TRANSFORM")]
    public const nint LoadIgnoreTransform = (1 << 11);

    [NativeName("FT_LOAD_MONOCHROME")]
    public const nint LoadMonochrome = (1 << 12);

    [NativeName("FT_LOAD_LINEAR_DESIGN")]
    public const nint LoadLinearDesign = (1 << 13);

    [NativeName("FT_LOAD_SBITS_ONLY")]
    public const nint LoadSbitsOnly = (1 << 14);

    [NativeName("FT_LOAD_NO_AUTOHINT")]
    public const nint LoadNoAutohint = (1 << 15);

    [NativeName("FT_LOAD_COLOR")]
    public const nint LoadColor = (1 << 20);

    [NativeName("FT_LOAD_COMPUTE_METRICS")]
    public const nint LoadComputeMetrics = (1 << 21);

    [NativeName("FT_LOAD_BITMAP_METRICS_ONLY")]
    public const nint LoadBitmapMetricsOnly = (1 << 22);

    [NativeName("FT_LOAD_NO_SVG")]
    public const nint LoadNoSvg = (1 << 24);

    [NativeName("FT_LOAD_ADVANCE_ONLY")]
    public const nint LoadAdvanceOnly = (1 << 8);

    [NativeName("FT_LOAD_SVG_ONLY")]
    public const nint LoadSvgOnly = (1 << 23);

    [NativeName("FT_LOAD_TARGET_NORMAL")]
    public const int LoadTargetNormal = ((int)((int)(RenderMode.Normal) & 15) << 16);

    [NativeName("FT_LOAD_TARGET_LIGHT")]
    public const int LoadTargetLight = ((int)((int)(RenderMode.Light) & 15) << 16);

    [NativeName("FT_LOAD_TARGET_MONO")]
    public const int LoadTargetMono = ((int)((int)(RenderMode.Mono) & 15) << 16);

    [NativeName("FT_LOAD_TARGET_LCD")]
    public const int LoadTargetLcd = ((int)((int)(RenderMode.Lcd) & 15) << 16);

    [NativeName("FT_LOAD_TARGET_LCD_V")]
    public const int LoadTargetLcdV = ((int)((int)(RenderMode.LcdV) & 15) << 16);

    [NativeName("ft_render_mode_normal")]
    public const RenderMode RenderModeNormal = RenderMode.Normal;

    [NativeName("ft_render_mode_mono")]
    public const RenderMode RenderModeMono = RenderMode.Mono;

    [NativeName("ft_kerning_default")]
    public const KerningMode KerningDefault = KerningMode.Default;

    [NativeName("ft_kerning_unfitted")]
    public const KerningMode KerningUnfitted = KerningMode.Unfitted;

    [NativeName("ft_kerning_unscaled")]
    public const KerningMode KerningUnscaled = KerningMode.Unscaled;

    [NativeName("FT_SUBGLYPH_FLAG_ARGS_ARE_WORDS")]
    public const int SubglyphFlagArgsAreWords = 1;

    [NativeName("FT_SUBGLYPH_FLAG_ARGS_ARE_XY_VALUES")]
    public const int SubglyphFlagArgsAreXyValues = 2;

    [NativeName("FT_SUBGLYPH_FLAG_ROUND_XY_TO_GRID")]
    public const int SubglyphFlagRoundXyToGrid = 4;

    [NativeName("FT_SUBGLYPH_FLAG_SCALE")]
    public const int SubglyphFlagScale = 8;

    [NativeName("FT_SUBGLYPH_FLAG_XY_SCALE")]
    public const int SubglyphFlagXyScale = 0x40;

    [NativeName("FT_SUBGLYPH_FLAG_2X2")]
    public const int SubglyphFlag2x2 = 0x80;

    [NativeName("FT_SUBGLYPH_FLAG_USE_MY_METRICS")]
    public const int SubglyphFlagUseMyMetrics = 0x200;

    [NativeName("FT_FSTYPE_INSTALLABLE_EMBEDDING")]
    public const int FstypeInstallableEmbedding = 0x0000;

    [NativeName("FT_FSTYPE_RESTRICTED_LICENSE_EMBEDDING")]
    public const int FstypeRestrictedLicenseEmbedding = 0x0002;

    [NativeName("FT_FSTYPE_PREVIEW_AND_PRINT_EMBEDDING")]
    public const int FstypePreviewAndPrintEmbedding = 0x0004;

    [NativeName("FT_FSTYPE_EDITABLE_EMBEDDING")]
    public const int FstypeEditableEmbedding = 0x0008;

    [NativeName("FT_FSTYPE_NO_SUBSETTING")]
    public const int FstypeNoSubsetting = 0x0100;

    [NativeName("FT_FSTYPE_BITMAP_EMBEDDING_ONLY")]
    public const int FstypeBitmapEmbeddingOnly = 0x0200;

    [NativeName("FREETYPE_MAJOR")]
    public const int FreetypeMajor = 2;

    [NativeName("FREETYPE_MINOR")]
    public const int FreetypeMinor = 14;

    [NativeName("FREETYPE_PATCH")]
    public const int FreetypePatch = 1;

    [NativeName("FT_MODULE_FONT_DRIVER")]
    public const int ModuleFontDriver = 1;

    [NativeName("FT_MODULE_RENDERER")]
    public const int ModuleRenderer = 2;

    [NativeName("FT_MODULE_HINTER")]
    public const int ModuleHinter = 4;

    [NativeName("FT_MODULE_STYLER")]
    public const int ModuleStyler = 8;

    [NativeName("FT_MODULE_DRIVER_SCALABLE")]
    public const int ModuleDriverScalable = 0x100;

    [NativeName("FT_MODULE_DRIVER_NO_OUTLINES")]
    public const int ModuleDriverNoOutlines = 0x200;

    [NativeName("FT_MODULE_DRIVER_HAS_HINTER")]
    public const int ModuleDriverHasHinter = 0x400;

    [NativeName("FT_MODULE_DRIVER_HINTS_LIGHTLY")]
    public const int ModuleDriverHintsLightly = 0x800;

    [NativeName("FT_DEBUG_HOOK_TRUETYPE")]
    public const int DebugHookTruetype = 0;

    [NativeName("FT_Add_Default_Modules")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.AddDefaultModules(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, void>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("FT_Add_Default_Modules", "freetype")
            )
        )(library);

    [NativeName("FT_Add_Default_Modules")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Default_Modules")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void AddDefaultModules(LibraryRecHandle library) =>
        DllImport.AddDefaultModules(library);

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AddModule(LibraryRecHandle library, ModuleClass* clazz) =>
        (
            (delegate* unmanaged<LibraryRecHandle, ModuleClass*, int>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction("FT_Add_Module", "freetype")
            )
        )(library, clazz);

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AddModule(LibraryRecHandle library, ModuleClass* clazz) =>
        DllImport.AddModule(library, clazz);

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz)
    {
        fixed (ModuleClass* __dsl_clazz = clazz)
        {
            return (int)((IFreeType)this).AddModule(library, __dsl_clazz);
        }
    }

    [NativeName("FT_Add_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Add_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AddModule(LibraryRecHandle library, Ref<ModuleClass> clazz) =>
        DllImport.AddModule(library, clazz);

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AttachFile(FaceRec* face, sbyte* filepathname) =>
        (
            (delegate* unmanaged<FaceRec*, sbyte*, int>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction("FT_Attach_File", "freetype")
            )
        )(face, filepathname);

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AttachFile(FaceRec* face, sbyte* filepathname) =>
        DllImport.AttachFile(face, filepathname);

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname)
    {
        fixed (sbyte* __dsl_filepathname = filepathname)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).AttachFile(__dsl_face, __dsl_filepathname);
        }
    }

    [NativeName("FT_Attach_File")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_File")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AttachFile(Ref<FaceRec> face, Ref<sbyte> filepathname) =>
        DllImport.AttachFile(face, filepathname);

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AttachStream(FaceRec* face, OpenArgs* parameters) =>
        (
            (delegate* unmanaged<FaceRec*, OpenArgs*, int>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("FT_Attach_Stream", "freetype")
            )
        )(face, parameters);

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AttachStream(FaceRec* face, OpenArgs* parameters) =>
        DllImport.AttachStream(face, parameters);

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters)
    {
        fixed (OpenArgs* __dsl_parameters = parameters)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).AttachStream(__dsl_face, __dsl_parameters);
        }
    }

    [NativeName("FT_Attach_Stream")]
    [NativeFunction("freetype", EntryPoint = "FT_Attach_Stream")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int AttachStream(Ref<FaceRec> face, Ref<OpenArgs> parameters) =>
        DllImport.AttachStream(face, parameters);

    [NativeName("FT_CeilFix")]
    [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.CeilFix(long a) =>
        (
            (delegate* unmanaged<long, long>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("FT_CeilFix", "freetype")
            )
        )(a);

    [NativeName("FT_CeilFix")]
    [NativeFunction("freetype", EntryPoint = "FT_CeilFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long CeilFix(long a) => DllImport.CeilFix(a);

    [NativeName("FT_DivFix")]
    [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.DivFix(long a, long b) =>
        (
            (delegate* unmanaged<long, long, long>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("FT_DivFix", "freetype")
            )
        )(a, b);

    [NativeName("FT_DivFix")]
    [NativeFunction("freetype", EntryPoint = "FT_DivFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long DivFix(long a, long b) => DllImport.DivFix(a, b);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.DoneFace(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, int>)(
                _slots[6] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[6] = nativeContext.LoadFunction("FT_Done_Face", "freetype")
            )
        )(face);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int DoneFace(FaceRec* face) => DllImport.DoneFace(face);

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.DoneFace(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).DoneFace(__dsl_face);
        }
    }

    [NativeName("FT_Done_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int DoneFace(Ref<FaceRec> face) => DllImport.DoneFace(face);

    [NativeName("FT_Done_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.DoneFreeType(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, int>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("FT_Done_FreeType", "freetype")
            )
        )(library);

    [NativeName("FT_Done_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int DoneFreeType(LibraryRecHandle library) => DllImport.DoneFreeType(library);

    [NativeName("FT_Done_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.DoneLibrary(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, int>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("FT_Done_Library", "freetype")
            )
        )(library);

    [NativeName("FT_Done_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Done_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int DoneLibrary(LibraryRecHandle library) => DllImport.DoneLibrary(library);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IFreeType.ErrorString(int error_code) =>
        (sbyte*)((IFreeType)this).ErrorStringRaw(error_code);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> ErrorString(int error_code) => DllImport.ErrorString(error_code);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IFreeType.ErrorStringRaw(int error_code) =>
        (
            (delegate* unmanaged<int, sbyte*>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction("FT_Error_String", "freetype")
            )
        )(error_code);

    [NativeName("FT_Error_String")]
    [NativeFunction("freetype", EntryPoint = "FT_Error_String")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* ErrorStringRaw(int error_code) => DllImport.ErrorStringRaw(error_code);

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    byte IFreeType.FaceCheckTrueTypePatents(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, byte>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction(
                        "FT_Face_CheckTrueTypePatents",
                        "freetype"
                    )
            )
        )(face);

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte FaceCheckTrueTypePatents(FaceRec* face) =>
        DllImport.FaceCheckTrueTypePatents(face);

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    byte IFreeType.FaceCheckTrueTypePatents(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (byte)((IFreeType)this).FaceCheckTrueTypePatents(__dsl_face);
        }
    }

    [NativeName("FT_Face_CheckTrueTypePatents")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_CheckTrueTypePatents")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte FaceCheckTrueTypePatents(Ref<FaceRec> face) =>
        DllImport.FaceCheckTrueTypePatents(face);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint* IFreeType.FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, uint*>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction(
                        "FT_Face_GetCharsOfVariant",
                        "freetype"
                    )
            )
        )(face, variantSelector);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint* FaceGetCharsOfVariant(FaceRec* face, ulong variantSelector) =>
        DllImport.FaceGetCharsOfVariant(face, variantSelector);

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<uint> IFreeType.FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint*)((IFreeType)this).FaceGetCharsOfVariant(__dsl_face, variantSelector);
        }
    }

    [NativeName("FT_Face_GetCharsOfVariant")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharsOfVariant")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<uint> FaceGetCharsOfVariant(Ref<FaceRec> face, ulong variantSelector) =>
        DllImport.FaceGetCharsOfVariant(face, variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.FaceGetCharVariantIndex(FaceRec* face, ulong charcode, ulong variantSelector) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, ulong, uint>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction(
                        "FT_Face_GetCharVariantIndex",
                        "freetype"
                    )
            )
        )(face, charcode, variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint FaceGetCharVariantIndex(
        FaceRec* face,
        ulong charcode,
        ulong variantSelector
    ) => DllImport.FaceGetCharVariantIndex(face, charcode, variantSelector);

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.FaceGetCharVariantIndex(Ref<FaceRec> face, ulong charcode, ulong variantSelector)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint)
                ((IFreeType)this).FaceGetCharVariantIndex(__dsl_face, charcode, variantSelector);
        }
    }

    [NativeName("FT_Face_GetCharVariantIndex")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIndex")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint FaceGetCharVariantIndex(
        Ref<FaceRec> face,
        ulong charcode,
        ulong variantSelector
    ) => DllImport.FaceGetCharVariantIndex(face, charcode, variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.FaceGetCharVariantIsDefault(
        FaceRec* face,
        ulong charcode,
        ulong variantSelector
    ) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, ulong, int>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction(
                        "FT_Face_GetCharVariantIsDefault",
                        "freetype"
                    )
            )
        )(face, charcode, variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FaceGetCharVariantIsDefault(
        FaceRec* face,
        ulong charcode,
        ulong variantSelector
    ) => DllImport.FaceGetCharVariantIsDefault(face, charcode, variantSelector);

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.FaceGetCharVariantIsDefault(
        Ref<FaceRec> face,
        ulong charcode,
        ulong variantSelector
    )
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).FaceGetCharVariantIsDefault(
                    __dsl_face,
                    charcode,
                    variantSelector
                );
        }
    }

    [NativeName("FT_Face_GetCharVariantIsDefault")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetCharVariantIsDefault")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FaceGetCharVariantIsDefault(
        Ref<FaceRec> face,
        ulong charcode,
        ulong variantSelector
    ) => DllImport.FaceGetCharVariantIsDefault(face, charcode, variantSelector);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint* IFreeType.FaceGetVariantSelectors(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, uint*>)(
                _slots[14] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[14] = nativeContext.LoadFunction(
                        "FT_Face_GetVariantSelectors",
                        "freetype"
                    )
            )
        )(face);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint* FaceGetVariantSelectors(FaceRec* face) =>
        DllImport.FaceGetVariantSelectors(face);

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<uint> IFreeType.FaceGetVariantSelectors(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint*)((IFreeType)this).FaceGetVariantSelectors(__dsl_face);
        }
    }

    [NativeName("FT_Face_GetVariantSelectors")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantSelectors")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<uint> FaceGetVariantSelectors(Ref<FaceRec> face) =>
        DllImport.FaceGetVariantSelectors(face);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint* IFreeType.FaceGetVariantsOfChar(FaceRec* face, ulong charcode) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, uint*>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction(
                        "FT_Face_GetVariantsOfChar",
                        "freetype"
                    )
            )
        )(face, charcode);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint* FaceGetVariantsOfChar(FaceRec* face, ulong charcode) =>
        DllImport.FaceGetVariantsOfChar(face, charcode);

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<uint> IFreeType.FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint*)((IFreeType)this).FaceGetVariantsOfChar(__dsl_face, charcode);
        }
    }

    [NativeName("FT_Face_GetVariantsOfChar")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_GetVariantsOfChar")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<uint> FaceGetVariantsOfChar(Ref<FaceRec> face, ulong charcode) =>
        DllImport.FaceGetVariantsOfChar(face, charcode);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.FaceProperties(FaceRec* face, uint num_properties, Parameter* properties) =>
        (
            (delegate* unmanaged<FaceRec*, uint, Parameter*, int>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("FT_Face_Properties", "freetype")
            )
        )(face, num_properties, properties);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FaceProperties(FaceRec* face, uint num_properties, Parameter* properties) =>
        DllImport.FaceProperties(face, num_properties, properties);

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.FaceProperties(Ref<FaceRec> face, uint num_properties, Ref<Parameter> properties)
    {
        fixed (Parameter* __dsl_properties = properties)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).FaceProperties(__dsl_face, num_properties, __dsl_properties);
        }
    }

    [NativeName("FT_Face_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FaceProperties(
        Ref<FaceRec> face,
        uint num_properties,
        Ref<Parameter> properties
    ) => DllImport.FaceProperties(face, num_properties, properties);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    byte IFreeType.FaceSetUnpatentedHinting(FaceRec* face, byte value) =>
        (
            (delegate* unmanaged<FaceRec*, byte, byte>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction(
                        "FT_Face_SetUnpatentedHinting",
                        "freetype"
                    )
            )
        )(face, value);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte FaceSetUnpatentedHinting(FaceRec* face, byte value) =>
        DllImport.FaceSetUnpatentedHinting(face, value);

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    byte IFreeType.FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (byte)((IFreeType)this).FaceSetUnpatentedHinting(__dsl_face, value);
        }
    }

    [NativeName("FT_Face_SetUnpatentedHinting")]
    [NativeFunction("freetype", EntryPoint = "FT_Face_SetUnpatentedHinting")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte FaceSetUnpatentedHinting(Ref<FaceRec> face, byte value) =>
        DllImport.FaceSetUnpatentedHinting(face, value);

    [NativeName("FT_FloorFix")]
    [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.FloorFix(long a) =>
        (
            (delegate* unmanaged<long, long>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("FT_FloorFix", "freetype")
            )
        )(a);

    [NativeName("FT_FloorFix")]
    [NativeFunction("freetype", EntryPoint = "FT_FloorFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long FloorFix(long a) => DllImport.FloorFix(a);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.GetCharIndex(FaceRec* face, ulong charcode) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, uint>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("FT_Get_Char_Index", "freetype")
            )
        )(face, charcode);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GetCharIndex(FaceRec* face, ulong charcode) =>
        DllImport.GetCharIndex(face, charcode);

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.GetCharIndex(Ref<FaceRec> face, ulong charcode)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint)((IFreeType)this).GetCharIndex(__dsl_face, charcode);
        }
    }

    [NativeName("FT_Get_Char_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Char_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GetCharIndex(Ref<FaceRec> face, ulong charcode) =>
        DllImport.GetCharIndex(face, charcode);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetCharmapIndex(CharMapRec* charmap) =>
        (
            (delegate* unmanaged<CharMapRec*, int>)(
                _slots[20] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[20] = nativeContext.LoadFunction("FT_Get_Charmap_Index", "freetype")
            )
        )(charmap);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetCharmapIndex(CharMapRec* charmap) => DllImport.GetCharmapIndex(charmap);

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetCharmapIndex(Ref<CharMapRec> charmap)
    {
        fixed (CharMapRec* __dsl_charmap = charmap)
        {
            return (int)((IFreeType)this).GetCharmapIndex(__dsl_charmap);
        }
    }

    [NativeName("FT_Get_Charmap_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Charmap_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetCharmapIndex(Ref<CharMapRec> charmap) =>
        DllImport.GetCharmapIndex(charmap);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ulong IFreeType.GetFirstChar(FaceRec* face, uint* agindex) =>
        (
            (delegate* unmanaged<FaceRec*, uint*, ulong>)(
                _slots[21] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[21] = nativeContext.LoadFunction("FT_Get_First_Char", "freetype")
            )
        )(face, agindex);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong GetFirstChar(FaceRec* face, uint* agindex) =>
        DllImport.GetFirstChar(face, agindex);

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ulong IFreeType.GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex)
    {
        fixed (uint* __dsl_agindex = agindex)
        fixed (FaceRec* __dsl_face = face)
        {
            return (ulong)((IFreeType)this).GetFirstChar(__dsl_face, __dsl_agindex);
        }
    }

    [NativeName("FT_Get_First_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_First_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong GetFirstChar(Ref<FaceRec> face, Ref<uint> agindex) =>
        DllImport.GetFirstChar(face, agindex);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ushort IFreeType.GetFSTypeFlags(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, ushort>)(
                _slots[22] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[22] = nativeContext.LoadFunction("FT_Get_FSType_Flags", "freetype")
            )
        )(face);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ushort GetFSTypeFlags(FaceRec* face) => DllImport.GetFSTypeFlags(face);

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ushort IFreeType.GetFSTypeFlags(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (ushort)((IFreeType)this).GetFSTypeFlags(__dsl_face);
        }
    }

    [NativeName("FT_Get_FSType_Flags")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_FSType_Flags")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ushort GetFSTypeFlags(Ref<FaceRec> face) => DllImport.GetFSTypeFlags(face);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetGlyphName(FaceRec* face, uint glyph_index, void* buffer, uint buffer_max) =>
        (
            (delegate* unmanaged<FaceRec*, uint, void*, uint, int>)(
                _slots[23] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[23] = nativeContext.LoadFunction("FT_Get_Glyph_Name", "freetype")
            )
        )(face, glyph_index, buffer, buffer_max);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetGlyphName(
        FaceRec* face,
        uint glyph_index,
        void* buffer,
        uint buffer_max
    ) => DllImport.GetGlyphName(face, glyph_index, buffer, buffer_max);

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetGlyphName(Ref<FaceRec> face, uint glyph_index, Ref buffer, uint buffer_max)
    {
        fixed (void* __dsl_buffer = buffer)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).GetGlyphName(__dsl_face, glyph_index, __dsl_buffer, buffer_max);
        }
    }

    [NativeName("FT_Get_Glyph_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Glyph_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetGlyphName(
        Ref<FaceRec> face,
        uint glyph_index,
        Ref buffer,
        uint buffer_max
    ) => DllImport.GetGlyphName(face, glyph_index, buffer, buffer_max);

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetKerning(
        FaceRec* face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Vector* akerning
    ) =>
        (
            (delegate* unmanaged<FaceRec*, uint, uint, uint, Vector*, int>)(
                _slots[24] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[24] = nativeContext.LoadFunction("FT_Get_Kerning", "freetype")
            )
        )(face, left_glyph, right_glyph, kern_mode, akerning);

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetKerning(
        FaceRec* face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Vector* akerning
    ) => DllImport.GetKerning(face, left_glyph, right_glyph, kern_mode, akerning);

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetKerning(
        Ref<FaceRec> face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Ref<Vector> akerning
    )
    {
        fixed (Vector* __dsl_akerning = akerning)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).GetKerning(
                    __dsl_face,
                    left_glyph,
                    right_glyph,
                    kern_mode,
                    __dsl_akerning
                );
        }
    }

    [NativeName("FT_Get_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetKerning(
        Ref<FaceRec> face,
        uint left_glyph,
        uint right_glyph,
        uint kern_mode,
        Ref<Vector> akerning
    ) => DllImport.GetKerning(face, left_glyph, right_glyph, kern_mode, akerning);

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ModuleRecHandle IFreeType.GetModule(LibraryRecHandle library, sbyte* module_name) =>
        (
            (delegate* unmanaged<LibraryRecHandle, sbyte*, ModuleRecHandle>)(
                _slots[25] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[25] = nativeContext.LoadFunction("FT_Get_Module", "freetype")
            )
        )(library, module_name);

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ModuleRecHandle GetModule(LibraryRecHandle library, sbyte* module_name) =>
        DllImport.GetModule(library, module_name);

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ModuleRecHandle IFreeType.GetModule(LibraryRecHandle library, Ref<sbyte> module_name)
    {
        fixed (sbyte* __dsl_module_name = module_name)
        {
            return (ModuleRecHandle)((IFreeType)this).GetModule(library, __dsl_module_name);
        }
    }

    [NativeName("FT_Get_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ModuleRecHandle GetModule(LibraryRecHandle library, Ref<sbyte> module_name) =>
        DllImport.GetModule(library, module_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.GetNameIndex(FaceRec* face, sbyte* glyph_name) =>
        (
            (delegate* unmanaged<FaceRec*, sbyte*, uint>)(
                _slots[26] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[26] = nativeContext.LoadFunction("FT_Get_Name_Index", "freetype")
            )
        )(face, glyph_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GetNameIndex(FaceRec* face, sbyte* glyph_name) =>
        DllImport.GetNameIndex(face, glyph_name);

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFreeType.GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name)
    {
        fixed (sbyte* __dsl_glyph_name = glyph_name)
        fixed (FaceRec* __dsl_face = face)
        {
            return (uint)((IFreeType)this).GetNameIndex(__dsl_face, __dsl_glyph_name);
        }
    }

    [NativeName("FT_Get_Name_Index")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Name_Index")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GetNameIndex(Ref<FaceRec> face, Ref<sbyte> glyph_name) =>
        DllImport.GetNameIndex(face, glyph_name);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ulong IFreeType.GetNextChar(FaceRec* face, ulong char_code, uint* agindex) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, uint*, ulong>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction("FT_Get_Next_Char", "freetype")
            )
        )(face, char_code, agindex);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong GetNextChar(FaceRec* face, ulong char_code, uint* agindex) =>
        DllImport.GetNextChar(face, char_code, agindex);

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ulong IFreeType.GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex)
    {
        fixed (uint* __dsl_agindex = agindex)
        fixed (FaceRec* __dsl_face = face)
        {
            return (ulong)((IFreeType)this).GetNextChar(__dsl_face, char_code, __dsl_agindex);
        }
    }

    [NativeName("FT_Get_Next_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Next_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong GetNextChar(Ref<FaceRec> face, ulong char_code, Ref<uint> agindex) =>
        DllImport.GetNextChar(face, char_code, agindex);

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IFreeType.GetPostscriptName(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, sbyte*>)(
                _slots[28] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[28] = nativeContext.LoadFunction("FT_Get_Postscript_Name", "freetype")
            )
        )(face);

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetPostscriptName(FaceRec* face) => DllImport.GetPostscriptName(face);

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IFreeType.GetPostscriptName(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (sbyte*)((IFreeType)this).GetPostscriptName(__dsl_face);
        }
    }

    [NativeName("FT_Get_Postscript_Name")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Postscript_Name")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetPostscriptName(Ref<FaceRec> face) =>
        DllImport.GetPostscriptName(face);

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetSubGlyphInfo(
        GlyphSlotRec* glyph,
        uint sub_index,
        int* p_index,
        uint* p_flags,
        int* p_arg1,
        int* p_arg2,
        Matrix* p_transform
    ) =>
        (
            (delegate* unmanaged<GlyphSlotRec*, uint, int*, uint*, int*, int*, Matrix*, int>)(
                _slots[29] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[29] = nativeContext.LoadFunction("FT_Get_SubGlyph_Info", "freetype")
            )
        )(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetSubGlyphInfo(
        GlyphSlotRec* glyph,
        uint sub_index,
        int* p_index,
        uint* p_flags,
        int* p_arg1,
        int* p_arg2,
        Matrix* p_transform
    ) => DllImport.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetSubGlyphInfo(
        Ref<GlyphSlotRec> glyph,
        uint sub_index,
        Ref<int> p_index,
        Ref<uint> p_flags,
        Ref<int> p_arg1,
        Ref<int> p_arg2,
        Ref<Matrix> p_transform
    )
    {
        fixed (Matrix* __dsl_p_transform = p_transform)
        fixed (int* __dsl_p_arg2 = p_arg2)
        fixed (int* __dsl_p_arg1 = p_arg1)
        fixed (uint* __dsl_p_flags = p_flags)
        fixed (int* __dsl_p_index = p_index)
        fixed (GlyphSlotRec* __dsl_glyph = glyph)
        {
            return (int)
                ((IFreeType)this).GetSubGlyphInfo(
                    __dsl_glyph,
                    sub_index,
                    __dsl_p_index,
                    __dsl_p_flags,
                    __dsl_p_arg1,
                    __dsl_p_arg2,
                    __dsl_p_transform
                );
        }
    }

    [NativeName("FT_Get_SubGlyph_Info")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_SubGlyph_Info")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetSubGlyphInfo(
        Ref<GlyphSlotRec> glyph,
        uint sub_index,
        Ref<int> p_index,
        Ref<uint> p_flags,
        Ref<int> p_arg1,
        Ref<int> p_arg2,
        Ref<Matrix> p_transform
    ) => DllImport.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetTrackKerning(FaceRec* face, long point_size, int degree, long* akerning) =>
        (
            (delegate* unmanaged<FaceRec*, long, int, long*, int>)(
                _slots[30] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[30] = nativeContext.LoadFunction("FT_Get_Track_Kerning", "freetype")
            )
        )(face, point_size, degree, akerning);

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetTrackKerning(FaceRec* face, long point_size, int degree, long* akerning) =>
        DllImport.GetTrackKerning(face, point_size, degree, akerning);

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.GetTrackKerning(
        Ref<FaceRec> face,
        long point_size,
        int degree,
        Ref<long> akerning
    )
    {
        fixed (long* __dsl_akerning = akerning)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).GetTrackKerning(__dsl_face, point_size, degree, __dsl_akerning);
        }
    }

    [NativeName("FT_Get_Track_Kerning")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Track_Kerning")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetTrackKerning(
        Ref<FaceRec> face,
        long point_size,
        int degree,
        Ref<long> akerning
    ) => DllImport.GetTrackKerning(face, point_size, degree, akerning);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.GetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
        (
            (delegate* unmanaged<FaceRec*, Matrix*, Vector*, void>)(
                _slots[31] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[31] = nativeContext.LoadFunction("FT_Get_Transform", "freetype")
            )
        )(face, matrix, delta);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
        DllImport.GetTransform(face, matrix, delta);

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
    {
        fixed (Vector* __dsl_delta = delta)
        fixed (Matrix* __dsl_matrix = matrix)
        fixed (FaceRec* __dsl_face = face)
        {
            ((IFreeType)this).GetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
        }
    }

    [NativeName("FT_Get_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta) =>
        DllImport.GetTransform(face, matrix, delta);

    [NativeName("FT_Get_TrueType_Engine_Type")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    TrueTypeEngineType IFreeType.GetTrueTypeEngineType(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, TrueTypeEngineType>)(
                _slots[32] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[32] = nativeContext.LoadFunction(
                        "FT_Get_TrueType_Engine_Type",
                        "freetype"
                    )
            )
        )(library);

    [NativeName("FT_Get_TrueType_Engine_Type")]
    [NativeFunction("freetype", EntryPoint = "FT_Get_TrueType_Engine_Type")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static TrueTypeEngineType GetTrueTypeEngineType(LibraryRecHandle library) =>
        DllImport.GetTrueTypeEngineType(library);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.InitFreeType(LibraryRecHandle* alibrary) =>
        (
            (delegate* unmanaged<LibraryRecHandle*, int>)(
                _slots[33] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[33] = nativeContext.LoadFunction("FT_Init_FreeType", "freetype")
            )
        )(alibrary);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int InitFreeType(LibraryRecHandle* alibrary) => DllImport.InitFreeType(alibrary);

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.InitFreeType(Ref<LibraryRecHandle> alibrary)
    {
        fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
        {
            return (int)((IFreeType)this).InitFreeType(__dsl_alibrary);
        }
    }

    [NativeName("FT_Init_FreeType")]
    [NativeFunction("freetype", EntryPoint = "FT_Init_FreeType")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int InitFreeType(Ref<LibraryRecHandle> alibrary) =>
        DllImport.InitFreeType(alibrary);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.LibraryVersion(
        LibraryRecHandle library,
        int* amajor,
        int* aminor,
        int* apatch
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, int*, int*, int*, void>)(
                _slots[34] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[34] = nativeContext.LoadFunction("FT_Library_Version", "freetype")
            )
        )(library, amajor, aminor, apatch);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void LibraryVersion(
        LibraryRecHandle library,
        int* amajor,
        int* aminor,
        int* apatch
    ) => DllImport.LibraryVersion(library, amajor, aminor, apatch);

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.LibraryVersion(
        LibraryRecHandle library,
        Ref<int> amajor,
        Ref<int> aminor,
        Ref<int> apatch
    )
    {
        fixed (int* __dsl_apatch = apatch)
        fixed (int* __dsl_aminor = aminor)
        fixed (int* __dsl_amajor = amajor)
        {
            ((IFreeType)this).LibraryVersion(library, __dsl_amajor, __dsl_aminor, __dsl_apatch);
        }
    }

    [NativeName("FT_Library_Version")]
    [NativeFunction("freetype", EntryPoint = "FT_Library_Version")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void LibraryVersion(
        LibraryRecHandle library,
        Ref<int> amajor,
        Ref<int> aminor,
        Ref<int> apatch
    ) => DllImport.LibraryVersion(library, amajor, aminor, apatch);

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.LoadChar(FaceRec* face, ulong char_code, int load_flags) =>
        (
            (delegate* unmanaged<FaceRec*, ulong, int, int>)(
                _slots[35] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[35] = nativeContext.LoadFunction("FT_Load_Char", "freetype")
            )
        )(face, char_code, load_flags);

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int LoadChar(FaceRec* face, ulong char_code, int load_flags) =>
        DllImport.LoadChar(face, char_code, load_flags);

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).LoadChar(__dsl_face, char_code, load_flags);
        }
    }

    [NativeName("FT_Load_Char")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Char")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int LoadChar(Ref<FaceRec> face, ulong char_code, int load_flags) =>
        DllImport.LoadChar(face, char_code, load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.LoadGlyph(FaceRec* face, uint glyph_index, int load_flags) =>
        (
            (delegate* unmanaged<FaceRec*, uint, int, int>)(
                _slots[36] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[36] = nativeContext.LoadFunction("FT_Load_Glyph", "freetype")
            )
        )(face, glyph_index, load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags) =>
        DllImport.LoadGlyph(face, glyph_index, load_flags);

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).LoadGlyph(__dsl_face, glyph_index, load_flags);
        }
    }

    [NativeName("FT_Load_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Load_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int LoadGlyph(Ref<FaceRec> face, uint glyph_index, int load_flags) =>
        DllImport.LoadGlyph(face, glyph_index, load_flags);

    [NativeName("FT_MulDiv")]
    [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.MulDiv(long a, long b, long c) =>
        (
            (delegate* unmanaged<long, long, long, long>)(
                _slots[37] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[37] = nativeContext.LoadFunction("FT_MulDiv", "freetype")
            )
        )(a, b, c);

    [NativeName("FT_MulDiv")]
    [NativeFunction("freetype", EntryPoint = "FT_MulDiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long MulDiv(long a, long b, long c) => DllImport.MulDiv(a, b, c);

    [NativeName("FT_MulFix")]
    [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.MulFix(long a, long b) =>
        (
            (delegate* unmanaged<long, long, long>)(
                _slots[38] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[38] = nativeContext.LoadFunction("FT_MulFix", "freetype")
            )
        )(a, b);

    [NativeName("FT_MulFix")]
    [NativeFunction("freetype", EntryPoint = "FT_MulFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long MulFix(long a, long b) => DllImport.MulFix(a, b);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewFace(
        LibraryRecHandle library,
        sbyte* filepathname,
        long face_index,
        FaceRec** aface
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, sbyte*, long, FaceRec**, int>)(
                _slots[39] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[39] = nativeContext.LoadFunction("FT_New_Face", "freetype")
            )
        )(library, filepathname, face_index, aface);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewFace(
        LibraryRecHandle library,
        sbyte* filepathname,
        long face_index,
        FaceRec** aface
    ) => DllImport.NewFace(library, filepathname, face_index, aface);

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewFace(
        LibraryRecHandle library,
        Ref<sbyte> filepathname,
        long face_index,
        Ref2D<FaceRec> aface
    )
    {
        fixed (FaceRec** __dsl_aface = aface)
        fixed (sbyte* __dsl_filepathname = filepathname)
        {
            return (int)
                ((IFreeType)this).NewFace(library, __dsl_filepathname, face_index, __dsl_aface);
        }
    }

    [NativeName("FT_New_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewFace(
        LibraryRecHandle library,
        Ref<sbyte> filepathname,
        long face_index,
        Ref2D<FaceRec> aface
    ) => DllImport.NewFace(library, filepathname, face_index, aface);

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary) =>
        (
            (delegate* unmanaged<MemoryRec*, LibraryRecHandle*, int>)(
                _slots[40] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[40] = nativeContext.LoadFunction("FT_New_Library", "freetype")
            )
        )(memory, alibrary);

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewLibrary(MemoryRec* memory, LibraryRecHandle* alibrary) =>
        DllImport.NewLibrary(memory, alibrary);

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary)
    {
        fixed (LibraryRecHandle* __dsl_alibrary = alibrary)
        fixed (MemoryRec* __dsl_memory = memory)
        {
            return (int)((IFreeType)this).NewLibrary(__dsl_memory, __dsl_alibrary);
        }
    }

    [NativeName("FT_New_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewLibrary(Ref<MemoryRec> memory, Ref<LibraryRecHandle> alibrary) =>
        DllImport.NewLibrary(memory, alibrary);

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewMemoryFace(
        LibraryRecHandle library,
        byte* file_base,
        long file_size,
        long face_index,
        FaceRec** aface
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, byte*, long, long, FaceRec**, int>)(
                _slots[41] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[41] = nativeContext.LoadFunction("FT_New_Memory_Face", "freetype")
            )
        )(library, file_base, file_size, face_index, aface);

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewMemoryFace(
        LibraryRecHandle library,
        byte* file_base,
        long file_size,
        long face_index,
        FaceRec** aface
    ) => DllImport.NewMemoryFace(library, file_base, file_size, face_index, aface);

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.NewMemoryFace(
        LibraryRecHandle library,
        Ref<byte> file_base,
        long file_size,
        long face_index,
        Ref2D<FaceRec> aface
    )
    {
        fixed (FaceRec** __dsl_aface = aface)
        fixed (byte* __dsl_file_base = file_base)
        {
            return (int)
                ((IFreeType)this).NewMemoryFace(
                    library,
                    __dsl_file_base,
                    file_size,
                    face_index,
                    __dsl_aface
                );
        }
    }

    [NativeName("FT_New_Memory_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_New_Memory_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int NewMemoryFace(
        LibraryRecHandle library,
        Ref<byte> file_base,
        long file_size,
        long face_index,
        Ref2D<FaceRec> aface
    ) => DllImport.NewMemoryFace(library, file_base, file_size, face_index, aface);

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OpenFace(
        LibraryRecHandle library,
        OpenArgs* args,
        long face_index,
        FaceRec** aface
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, OpenArgs*, long, FaceRec**, int>)(
                _slots[42] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[42] = nativeContext.LoadFunction("FT_Open_Face", "freetype")
            )
        )(library, args, face_index, aface);

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OpenFace(
        LibraryRecHandle library,
        OpenArgs* args,
        long face_index,
        FaceRec** aface
    ) => DllImport.OpenFace(library, args, face_index, aface);

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OpenFace(
        LibraryRecHandle library,
        Ref<OpenArgs> args,
        long face_index,
        Ref2D<FaceRec> aface
    )
    {
        fixed (FaceRec** __dsl_aface = aface)
        fixed (OpenArgs* __dsl_args = args)
        {
            return (int)((IFreeType)this).OpenFace(library, __dsl_args, face_index, __dsl_aface);
        }
    }

    [NativeName("FT_Open_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Open_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OpenFace(
        LibraryRecHandle library,
        Ref<OpenArgs> args,
        long face_index,
        Ref2D<FaceRec> aface
    ) => DllImport.OpenFace(library, args, face_index, aface);

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineCheck(Outline* outline) =>
        (
            (delegate* unmanaged<Outline*, int>)(
                _slots[43] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[43] = nativeContext.LoadFunction("FT_Outline_Check", "freetype")
            )
        )(outline);

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineCheck(Outline* outline) => DllImport.OutlineCheck(outline);

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineCheck(Ref<Outline> outline)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineCheck(__dsl_outline);
        }
    }

    [NativeName("FT_Outline_Check")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Check")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineCheck(Ref<Outline> outline) => DllImport.OutlineCheck(outline);

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineCopy(Outline* source, Outline* target) =>
        (
            (delegate* unmanaged<Outline*, Outline*, int>)(
                _slots[44] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[44] = nativeContext.LoadFunction("FT_Outline_Copy", "freetype")
            )
        )(source, target);

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineCopy(Outline* source, Outline* target) =>
        DllImport.OutlineCopy(source, target);

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineCopy(Ref<Outline> source, Ref<Outline> target)
    {
        fixed (Outline* __dsl_target = target)
        fixed (Outline* __dsl_source = source)
        {
            return (int)((IFreeType)this).OutlineCopy(__dsl_source, __dsl_target);
        }
    }

    [NativeName("FT_Outline_Copy")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Copy")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineCopy(Ref<Outline> source, Ref<Outline> target) =>
        DllImport.OutlineCopy(source, target);

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineDecompose(Outline* outline, OutlineFuncs* func_interface, void* user) =>
        (
            (delegate* unmanaged<Outline*, OutlineFuncs*, void*, int>)(
                _slots[45] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[45] = nativeContext.LoadFunction("FT_Outline_Decompose", "freetype")
            )
        )(outline, func_interface, user);

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineDecompose(
        Outline* outline,
        OutlineFuncs* func_interface,
        void* user
    ) => DllImport.OutlineDecompose(outline, func_interface, user);

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineDecompose(Ref<Outline> outline, Ref<OutlineFuncs> func_interface, Ref user)
    {
        fixed (void* __dsl_user = user)
        fixed (OutlineFuncs* __dsl_func_interface = func_interface)
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)
                ((IFreeType)this).OutlineDecompose(__dsl_outline, __dsl_func_interface, __dsl_user);
        }
    }

    [NativeName("FT_Outline_Decompose")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Decompose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineDecompose(
        Ref<Outline> outline,
        Ref<OutlineFuncs> func_interface,
        Ref user
    ) => DllImport.OutlineDecompose(outline, func_interface, user);

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineDone(LibraryRecHandle library, Outline* outline) =>
        (
            (delegate* unmanaged<LibraryRecHandle, Outline*, int>)(
                _slots[46] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[46] = nativeContext.LoadFunction("FT_Outline_Done", "freetype")
            )
        )(library, outline);

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineDone(LibraryRecHandle library, Outline* outline) =>
        DllImport.OutlineDone(library, outline);

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineDone(LibraryRecHandle library, Ref<Outline> outline)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineDone(library, __dsl_outline);
        }
    }

    [NativeName("FT_Outline_Done")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Done")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineDone(LibraryRecHandle library, Ref<Outline> outline) =>
        DllImport.OutlineDone(library, outline);

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineEmbolden(Outline* outline, long strength) =>
        (
            (delegate* unmanaged<Outline*, long, int>)(
                _slots[47] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[47] = nativeContext.LoadFunction("FT_Outline_Embolden", "freetype")
            )
        )(outline, strength);

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineEmbolden(Outline* outline, long strength) =>
        DllImport.OutlineEmbolden(outline, strength);

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineEmbolden(Ref<Outline> outline, long strength)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineEmbolden(__dsl_outline, strength);
        }
    }

    [NativeName("FT_Outline_Embolden")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Embolden")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineEmbolden(Ref<Outline> outline, long strength) =>
        DllImport.OutlineEmbolden(outline, strength);

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength) =>
        (
            (delegate* unmanaged<Outline*, long, long, int>)(
                _slots[48] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[48] = nativeContext.LoadFunction("FT_Outline_EmboldenXY", "freetype")
            )
        )(outline, xstrength, ystrength);

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineEmboldenXY(Outline* outline, long xstrength, long ystrength) =>
        DllImport.OutlineEmboldenXY(outline, xstrength, ystrength);

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineEmboldenXY(__dsl_outline, xstrength, ystrength);
        }
    }

    [NativeName("FT_Outline_EmboldenXY")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_EmboldenXY")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineEmboldenXY(Ref<Outline> outline, long xstrength, long ystrength) =>
        DllImport.OutlineEmboldenXY(outline, xstrength, ystrength);

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineGetBitmap(LibraryRecHandle library, Outline* outline, Bitmap* abitmap) =>
        (
            (delegate* unmanaged<LibraryRecHandle, Outline*, Bitmap*, int>)(
                _slots[49] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[49] = nativeContext.LoadFunction("FT_Outline_Get_Bitmap", "freetype")
            )
        )(library, outline, abitmap);

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineGetBitmap(
        LibraryRecHandle library,
        Outline* outline,
        Bitmap* abitmap
    ) => DllImport.OutlineGetBitmap(library, outline, abitmap);

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineGetBitmap(
        LibraryRecHandle library,
        Ref<Outline> outline,
        Ref<Bitmap> abitmap
    )
    {
        fixed (Bitmap* __dsl_abitmap = abitmap)
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineGetBitmap(library, __dsl_outline, __dsl_abitmap);
        }
    }

    [NativeName("FT_Outline_Get_Bitmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Bitmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineGetBitmap(
        LibraryRecHandle library,
        Ref<Outline> outline,
        Ref<Bitmap> abitmap
    ) => DllImport.OutlineGetBitmap(library, outline, abitmap);

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineGetCBox(Outline* outline, BBox* acbox) =>
        (
            (delegate* unmanaged<Outline*, BBox*, void>)(
                _slots[50] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[50] = nativeContext.LoadFunction("FT_Outline_Get_CBox", "freetype")
            )
        )(outline, acbox);

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineGetCBox(Outline* outline, BBox* acbox) =>
        DllImport.OutlineGetCBox(outline, acbox);

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox)
    {
        fixed (BBox* __dsl_acbox = acbox)
        fixed (Outline* __dsl_outline = outline)
        {
            ((IFreeType)this).OutlineGetCBox(__dsl_outline, __dsl_acbox);
        }
    }

    [NativeName("FT_Outline_Get_CBox")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_CBox")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineGetCBox(Ref<Outline> outline, Ref<BBox> acbox) =>
        DllImport.OutlineGetCBox(outline, acbox);

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Orientation IFreeType.OutlineGetOrientation(Outline* outline) =>
        (
            (delegate* unmanaged<Outline*, Orientation>)(
                _slots[51] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[51] = nativeContext.LoadFunction(
                        "FT_Outline_Get_Orientation",
                        "freetype"
                    )
            )
        )(outline);

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Orientation OutlineGetOrientation(Outline* outline) =>
        DllImport.OutlineGetOrientation(outline);

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Orientation IFreeType.OutlineGetOrientation(Ref<Outline> outline)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            return (Orientation)((IFreeType)this).OutlineGetOrientation(__dsl_outline);
        }
    }

    [NativeName("FT_Outline_Get_Orientation")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Get_Orientation")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Orientation OutlineGetOrientation(Ref<Outline> outline) =>
        DllImport.OutlineGetOrientation(outline);

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineNew(
        LibraryRecHandle library,
        uint numPoints,
        int numContours,
        Outline* anoutline
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, uint, int, Outline*, int>)(
                _slots[52] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[52] = nativeContext.LoadFunction("FT_Outline_New", "freetype")
            )
        )(library, numPoints, numContours, anoutline);

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineNew(
        LibraryRecHandle library,
        uint numPoints,
        int numContours,
        Outline* anoutline
    ) => DllImport.OutlineNew(library, numPoints, numContours, anoutline);

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineNew(
        LibraryRecHandle library,
        uint numPoints,
        int numContours,
        Ref<Outline> anoutline
    )
    {
        fixed (Outline* __dsl_anoutline = anoutline)
        {
            return (int)
                ((IFreeType)this).OutlineNew(library, numPoints, numContours, __dsl_anoutline);
        }
    }

    [NativeName("FT_Outline_New")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_New")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineNew(
        LibraryRecHandle library,
        uint numPoints,
        int numContours,
        Ref<Outline> anoutline
    ) => DllImport.OutlineNew(library, numPoints, numContours, anoutline);

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineRender(
        LibraryRecHandle library,
        Outline* outline,
        RasterParams* @params
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, Outline*, RasterParams*, int>)(
                _slots[53] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[53] = nativeContext.LoadFunction("FT_Outline_Render", "freetype")
            )
        )(library, outline, @params);

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineRender(
        LibraryRecHandle library,
        Outline* outline,
        RasterParams* @params
    ) => DllImport.OutlineRender(library, outline, @params);

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.OutlineRender(
        LibraryRecHandle library,
        Ref<Outline> outline,
        Ref<RasterParams> @params
    )
    {
        fixed (RasterParams* __dsl_params = @params)
        fixed (Outline* __dsl_outline = outline)
        {
            return (int)((IFreeType)this).OutlineRender(library, __dsl_outline, __dsl_params);
        }
    }

    [NativeName("FT_Outline_Render")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Render")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int OutlineRender(
        LibraryRecHandle library,
        Ref<Outline> outline,
        Ref<RasterParams> @params
    ) => DllImport.OutlineRender(library, outline, @params);

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineReverse(Outline* outline) =>
        (
            (delegate* unmanaged<Outline*, void>)(
                _slots[54] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[54] = nativeContext.LoadFunction("FT_Outline_Reverse", "freetype")
            )
        )(outline);

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineReverse(Outline* outline) => DllImport.OutlineReverse(outline);

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineReverse(Ref<Outline> outline)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            ((IFreeType)this).OutlineReverse(__dsl_outline);
        }
    }

    [NativeName("FT_Outline_Reverse")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Reverse")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineReverse(Ref<Outline> outline) => DllImport.OutlineReverse(outline);

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineTransform(Outline* outline, Matrix* matrix) =>
        (
            (delegate* unmanaged<Outline*, Matrix*, void>)(
                _slots[55] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[55] = nativeContext.LoadFunction("FT_Outline_Transform", "freetype")
            )
        )(outline, matrix);

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineTransform(Outline* outline, Matrix* matrix) =>
        DllImport.OutlineTransform(outline, matrix);

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix)
    {
        fixed (Matrix* __dsl_matrix = matrix)
        fixed (Outline* __dsl_outline = outline)
        {
            ((IFreeType)this).OutlineTransform(__dsl_outline, __dsl_matrix);
        }
    }

    [NativeName("FT_Outline_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineTransform(Ref<Outline> outline, Ref<Matrix> matrix) =>
        DllImport.OutlineTransform(outline, matrix);

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineTranslate(Outline* outline, long xOffset, long yOffset) =>
        (
            (delegate* unmanaged<Outline*, long, long, void>)(
                _slots[56] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[56] = nativeContext.LoadFunction("FT_Outline_Translate", "freetype")
            )
        )(outline, xOffset, yOffset);

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineTranslate(Outline* outline, long xOffset, long yOffset) =>
        DllImport.OutlineTranslate(outline, xOffset, yOffset);

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset)
    {
        fixed (Outline* __dsl_outline = outline)
        {
            ((IFreeType)this).OutlineTranslate(__dsl_outline, xOffset, yOffset);
        }
    }

    [NativeName("FT_Outline_Translate")]
    [NativeFunction("freetype", EntryPoint = "FT_Outline_Translate")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void OutlineTranslate(Ref<Outline> outline, long xOffset, long yOffset) =>
        DllImport.OutlineTranslate(outline, xOffset, yOffset);

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.PropertyGet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, sbyte*, sbyte*, void*, int>)(
                _slots[57] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[57] = nativeContext.LoadFunction("FT_Property_Get", "freetype")
            )
        )(library, module_name, property_name, value);

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int PropertyGet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    ) => DllImport.PropertyGet(library, module_name, property_name, value);

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.PropertyGet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    )
    {
        fixed (void* __dsl_value = value)
        fixed (sbyte* __dsl_property_name = property_name)
        fixed (sbyte* __dsl_module_name = module_name)
        {
            return (int)
                ((IFreeType)this).PropertyGet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
        }
    }

    [NativeName("FT_Property_Get")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Get")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int PropertyGet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    ) => DllImport.PropertyGet(library, module_name, property_name, value);

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.PropertySet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, sbyte*, sbyte*, void*, int>)(
                _slots[58] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[58] = nativeContext.LoadFunction("FT_Property_Set", "freetype")
            )
        )(library, module_name, property_name, value);

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int PropertySet(
        LibraryRecHandle library,
        sbyte* module_name,
        sbyte* property_name,
        void* value
    ) => DllImport.PropertySet(library, module_name, property_name, value);

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.PropertySet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    )
    {
        fixed (void* __dsl_value = value)
        fixed (sbyte* __dsl_property_name = property_name)
        fixed (sbyte* __dsl_module_name = module_name)
        {
            return (int)
                ((IFreeType)this).PropertySet(
                    library,
                    __dsl_module_name,
                    __dsl_property_name,
                    __dsl_value
                );
        }
    }

    [NativeName("FT_Property_Set")]
    [NativeFunction("freetype", EntryPoint = "FT_Property_Set")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int PropertySet(
        LibraryRecHandle library,
        Ref<sbyte> module_name,
        Ref<sbyte> property_name,
        Ref value
    ) => DllImport.PropertySet(library, module_name, property_name, value);

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.ReferenceFace(FaceRec* face) =>
        (
            (delegate* unmanaged<FaceRec*, int>)(
                _slots[59] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[59] = nativeContext.LoadFunction("FT_Reference_Face", "freetype")
            )
        )(face);

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ReferenceFace(FaceRec* face) => DllImport.ReferenceFace(face);

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.ReferenceFace(Ref<FaceRec> face)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).ReferenceFace(__dsl_face);
        }
    }

    [NativeName("FT_Reference_Face")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Face")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ReferenceFace(Ref<FaceRec> face) => DllImport.ReferenceFace(face);

    [NativeName("FT_Reference_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.ReferenceLibrary(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, int>)(
                _slots[60] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[60] = nativeContext.LoadFunction("FT_Reference_Library", "freetype")
            )
        )(library);

    [NativeName("FT_Reference_Library")]
    [NativeFunction("freetype", EntryPoint = "FT_Reference_Library")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ReferenceLibrary(LibraryRecHandle library) =>
        DllImport.ReferenceLibrary(library);

    [NativeName("FT_Remove_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.RemoveModule(LibraryRecHandle library, ModuleRecHandle module) =>
        (
            (delegate* unmanaged<LibraryRecHandle, ModuleRecHandle, int>)(
                _slots[61] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[61] = nativeContext.LoadFunction("FT_Remove_Module", "freetype")
            )
        )(library, module);

    [NativeName("FT_Remove_Module")]
    [NativeFunction("freetype", EntryPoint = "FT_Remove_Module")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RemoveModule(LibraryRecHandle library, ModuleRecHandle module) =>
        DllImport.RemoveModule(library, module);

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode) =>
        (
            (delegate* unmanaged<GlyphSlotRec*, RenderMode, int>)(
                _slots[62] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[62] = nativeContext.LoadFunction("FT_Render_Glyph", "freetype")
            )
        )(slot, render_mode);

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode) =>
        DllImport.RenderGlyph(slot, render_mode);

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode)
    {
        fixed (GlyphSlotRec* __dsl_slot = slot)
        {
            return (int)((IFreeType)this).RenderGlyph(__dsl_slot, render_mode);
        }
    }

    [NativeName("FT_Render_Glyph")]
    [NativeFunction("freetype", EntryPoint = "FT_Render_Glyph")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RenderGlyph(Ref<GlyphSlotRec> slot, RenderMode render_mode) =>
        DllImport.RenderGlyph(slot, render_mode);

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.RequestSize(FaceRec* face, SizeRequestRec* req) =>
        (
            (delegate* unmanaged<FaceRec*, SizeRequestRec*, int>)(
                _slots[63] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[63] = nativeContext.LoadFunction("FT_Request_Size", "freetype")
            )
        )(face, req);

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RequestSize(FaceRec* face, SizeRequestRec* req) =>
        DllImport.RequestSize(face, req);

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req)
    {
        fixed (SizeRequestRec* __dsl_req = req)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).RequestSize(__dsl_face, __dsl_req);
        }
    }

    [NativeName("FT_Request_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Request_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int RequestSize(Ref<FaceRec> face, Ref<SizeRequestRec> req) =>
        DllImport.RequestSize(face, req);

    [NativeName("FT_RoundFix")]
    [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    long IFreeType.RoundFix(long a) =>
        (
            (delegate* unmanaged<long, long>)(
                _slots[64] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[64] = nativeContext.LoadFunction("FT_RoundFix", "freetype")
            )
        )(a);

    [NativeName("FT_RoundFix")]
    [NativeFunction("freetype", EntryPoint = "FT_RoundFix")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static long RoundFix(long a) => DllImport.RoundFix(a);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SelectCharmap(FaceRec* face, Encoding encoding) =>
        (
            (delegate* unmanaged<FaceRec*, Encoding, int>)(
                _slots[65] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[65] = nativeContext.LoadFunction("FT_Select_Charmap", "freetype")
            )
        )(face, encoding);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SelectCharmap(FaceRec* face, Encoding encoding) =>
        DllImport.SelectCharmap(face, encoding);

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SelectCharmap(Ref<FaceRec> face, Encoding encoding)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).SelectCharmap(__dsl_face, encoding);
        }
    }

    [NativeName("FT_Select_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SelectCharmap(Ref<FaceRec> face, Encoding encoding) =>
        DllImport.SelectCharmap(face, encoding);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SelectSize(FaceRec* face, int strike_index) =>
        (
            (delegate* unmanaged<FaceRec*, int, int>)(
                _slots[66] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[66] = nativeContext.LoadFunction("FT_Select_Size", "freetype")
            )
        )(face, strike_index);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SelectSize(FaceRec* face, int strike_index) =>
        DllImport.SelectSize(face, strike_index);

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SelectSize(Ref<FaceRec> face, int strike_index)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).SelectSize(__dsl_face, strike_index);
        }
    }

    [NativeName("FT_Select_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Select_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SelectSize(Ref<FaceRec> face, int strike_index) =>
        DllImport.SelectSize(face, strike_index);

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetCharSize(
        FaceRec* face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    ) =>
        (
            (delegate* unmanaged<FaceRec*, long, long, uint, uint, int>)(
                _slots[67] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[67] = nativeContext.LoadFunction("FT_Set_Char_Size", "freetype")
            )
        )(face, char_width, char_height, horz_resolution, vert_resolution);

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetCharSize(
        FaceRec* face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    ) => DllImport.SetCharSize(face, char_width, char_height, horz_resolution, vert_resolution);

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetCharSize(
        Ref<FaceRec> face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    )
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)
                ((IFreeType)this).SetCharSize(
                    __dsl_face,
                    char_width,
                    char_height,
                    horz_resolution,
                    vert_resolution
                );
        }
    }

    [NativeName("FT_Set_Char_Size")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Char_Size")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetCharSize(
        Ref<FaceRec> face,
        long char_width,
        long char_height,
        uint horz_resolution,
        uint vert_resolution
    ) => DllImport.SetCharSize(face, char_width, char_height, horz_resolution, vert_resolution);

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetCharmap(FaceRec* face, CharMapRec* charmap) =>
        (
            (delegate* unmanaged<FaceRec*, CharMapRec*, int>)(
                _slots[68] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[68] = nativeContext.LoadFunction("FT_Set_Charmap", "freetype")
            )
        )(face, charmap);

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetCharmap(FaceRec* face, CharMapRec* charmap) =>
        DllImport.SetCharmap(face, charmap);

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap)
    {
        fixed (CharMapRec* __dsl_charmap = charmap)
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).SetCharmap(__dsl_face, __dsl_charmap);
        }
    }

    [NativeName("FT_Set_Charmap")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Charmap")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetCharmap(Ref<FaceRec> face, Ref<CharMapRec> charmap) =>
        DllImport.SetCharmap(face, charmap);

    [NativeName("FT_Set_Debug_Hook")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.SetDebugHook(
        LibraryRecHandle library,
        uint hook_index,
        DebugHookFunc debug_hook
    ) =>
        (
            (delegate* unmanaged<LibraryRecHandle, uint, DebugHookFunc, void>)(
                _slots[69] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[69] = nativeContext.LoadFunction("FT_Set_Debug_Hook", "freetype")
            )
        )(library, hook_index, debug_hook);

    [NativeName("FT_Set_Debug_Hook")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Debug_Hook")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SetDebugHook(
        LibraryRecHandle library,
        uint hook_index,
        DebugHookFunc debug_hook
    ) => DllImport.SetDebugHook(library, hook_index, debug_hook);

    [NativeName("FT_Set_Default_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.SetDefaultProperties(LibraryRecHandle library) =>
        (
            (delegate* unmanaged<LibraryRecHandle, void>)(
                _slots[70] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[70] = nativeContext.LoadFunction(
                        "FT_Set_Default_Properties",
                        "freetype"
                    )
            )
        )(library);

    [NativeName("FT_Set_Default_Properties")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Default_Properties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SetDefaultProperties(LibraryRecHandle library) =>
        DllImport.SetDefaultProperties(library);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height) =>
        (
            (delegate* unmanaged<FaceRec*, uint, uint, int>)(
                _slots[71] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[71] = nativeContext.LoadFunction("FT_Set_Pixel_Sizes", "freetype")
            )
        )(face, pixel_width, pixel_height);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height) =>
        DllImport.SetPixelSizes(face, pixel_width, pixel_height);

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IFreeType.SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height)
    {
        fixed (FaceRec* __dsl_face = face)
        {
            return (int)((IFreeType)this).SetPixelSizes(__dsl_face, pixel_width, pixel_height);
        }
    }

    [NativeName("FT_Set_Pixel_Sizes")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Pixel_Sizes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int SetPixelSizes(Ref<FaceRec> face, uint pixel_width, uint pixel_height) =>
        DllImport.SetPixelSizes(face, pixel_width, pixel_height);

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.SetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
        (
            (delegate* unmanaged<FaceRec*, Matrix*, Vector*, void>)(
                _slots[72] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[72] = nativeContext.LoadFunction("FT_Set_Transform", "freetype")
            )
        )(face, matrix, delta);

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta) =>
        DllImport.SetTransform(face, matrix, delta);

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta)
    {
        fixed (Vector* __dsl_delta = delta)
        fixed (Matrix* __dsl_matrix = matrix)
        fixed (FaceRec* __dsl_face = face)
        {
            ((IFreeType)this).SetTransform(__dsl_face, __dsl_matrix, __dsl_delta);
        }
    }

    [NativeName("FT_Set_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Set_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SetTransform(Ref<FaceRec> face, Ref<Matrix> matrix, Ref<Vector> delta) =>
        DllImport.SetTransform(face, matrix, delta);

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.VectorTransform(Vector* vector, Matrix* matrix) =>
        (
            (delegate* unmanaged<Vector*, Matrix*, void>)(
                _slots[73] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[73] = nativeContext.LoadFunction("FT_Vector_Transform", "freetype")
            )
        )(vector, matrix);

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void VectorTransform(Vector* vector, Matrix* matrix) =>
        DllImport.VectorTransform(vector, matrix);

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IFreeType.VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix)
    {
        fixed (Matrix* __dsl_matrix = matrix)
        fixed (Vector* __dsl_vector = vector)
        {
            ((IFreeType)this).VectorTransform(__dsl_vector, __dsl_matrix);
        }
    }

    [NativeName("FT_Vector_Transform")]
    [NativeFunction("freetype", EntryPoint = "FT_Vector_Transform")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void VectorTransform(Ref<Vector> vector, Ref<Matrix> matrix) =>
        DllImport.VectorTransform(vector, matrix);
}
