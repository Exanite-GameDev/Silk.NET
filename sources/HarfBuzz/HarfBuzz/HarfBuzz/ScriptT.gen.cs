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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.HarfBuzz;

[NativeName("hb_script_t")]
public enum ScriptT : uint
{
    [NativeName("HB_SCRIPT_COMMON")]
    Common = 1517910393,

    [NativeName("HB_SCRIPT_INHERITED")]
    Inherited = 1516858984,

    [NativeName("HB_SCRIPT_UNKNOWN")]
    Unknown = 1517976186,

    [NativeName("HB_SCRIPT_ARABIC")]
    Arabic = 1098015074,

    [NativeName("HB_SCRIPT_ARMENIAN")]
    Armenian = 1098018158,

    [NativeName("HB_SCRIPT_BENGALI")]
    Bengali = 1113943655,

    [NativeName("HB_SCRIPT_CYRILLIC")]
    Cyrillic = 1132032620,

    [NativeName("HB_SCRIPT_DEVANAGARI")]
    Devanagari = 1147500129,

    [NativeName("HB_SCRIPT_GEORGIAN")]
    Georgian = 1197830002,

    [NativeName("HB_SCRIPT_GREEK")]
    Greek = 1198679403,

    [NativeName("HB_SCRIPT_GUJARATI")]
    Gujarati = 1198877298,

    [NativeName("HB_SCRIPT_GURMUKHI")]
    Gurmukhi = 1198879349,

    [NativeName("HB_SCRIPT_HANGUL")]
    Hangul = 1214344807,

    [NativeName("HB_SCRIPT_HAN")]
    Han = 1214344809,

    [NativeName("HB_SCRIPT_HEBREW")]
    Hebrew = 1214603890,

    [NativeName("HB_SCRIPT_HIRAGANA")]
    Hiragana = 1214870113,

    [NativeName("HB_SCRIPT_KANNADA")]
    Kannada = 1265525857,

    [NativeName("HB_SCRIPT_KATAKANA")]
    Katakana = 1264676449,

    [NativeName("HB_SCRIPT_LAO")]
    Lao = 1281453935,

    [NativeName("HB_SCRIPT_LATIN")]
    Latin = 1281455214,

    [NativeName("HB_SCRIPT_MALAYALAM")]
    Malayalam = 1298954605,

    [NativeName("HB_SCRIPT_ORIYA")]
    Oriya = 1332902241,

    [NativeName("HB_SCRIPT_TAMIL")]
    Tamil = 1415671148,

    [NativeName("HB_SCRIPT_TELUGU")]
    Telugu = 1415933045,

    [NativeName("HB_SCRIPT_THAI")]
    Thai = 1416126825,

    [NativeName("HB_SCRIPT_TIBETAN")]
    Tibetan = 1416192628,

    [NativeName("HB_SCRIPT_BOPOMOFO")]
    Bopomofo = 1114599535,

    [NativeName("HB_SCRIPT_BRAILLE")]
    Braille = 1114792297,

    [NativeName("HB_SCRIPT_CANADIAN_SYLLABICS")]
    CanadianSyllabics = 1130458739,

    [NativeName("HB_SCRIPT_CHEROKEE")]
    Cherokee = 1130915186,

    [NativeName("HB_SCRIPT_ETHIOPIC")]
    Ethiopic = 1165256809,

    [NativeName("HB_SCRIPT_KHMER")]
    Khmer = 1265134962,

    [NativeName("HB_SCRIPT_MONGOLIAN")]
    Mongolian = 1299148391,

    [NativeName("HB_SCRIPT_MYANMAR")]
    Myanmar = 1299803506,

    [NativeName("HB_SCRIPT_OGHAM")]
    Ogham = 1332175213,

    [NativeName("HB_SCRIPT_RUNIC")]
    Runic = 1383427698,

    [NativeName("HB_SCRIPT_SINHALA")]
    Sinhala = 1399418472,

    [NativeName("HB_SCRIPT_SYRIAC")]
    Syriac = 1400468067,

    [NativeName("HB_SCRIPT_THAANA")]
    Thaana = 1416126817,

    [NativeName("HB_SCRIPT_YI")]
    Yi = 1500080489,

    [NativeName("HB_SCRIPT_DESERET")]
    Deseret = 1148416628,

    [NativeName("HB_SCRIPT_GOTHIC")]
    Gothic = 1198486632,

    [NativeName("HB_SCRIPT_OLD_ITALIC")]
    OldItalic = 1232363884,

    [NativeName("HB_SCRIPT_BUHID")]
    Buhid = 1114990692,

    [NativeName("HB_SCRIPT_HANUNOO")]
    Hanunoo = 1214344815,

    [NativeName("HB_SCRIPT_TAGALOG")]
    Tagalog = 1416064103,

    [NativeName("HB_SCRIPT_TAGBANWA")]
    Tagbanwa = 1415669602,

    [NativeName("HB_SCRIPT_CYPRIOT")]
    Cypriot = 1131442804,

    [NativeName("HB_SCRIPT_LIMBU")]
    Limbu = 1281977698,

    [NativeName("HB_SCRIPT_LINEAR_B")]
    LinearB = 1281977954,

    [NativeName("HB_SCRIPT_OSMANYA")]
    Osmanya = 1332964705,

    [NativeName("HB_SCRIPT_SHAVIAN")]
    Shavian = 1399349623,

    [NativeName("HB_SCRIPT_TAI_LE")]
    TaiLe = 1415670885,

    [NativeName("HB_SCRIPT_UGARITIC")]
    Ugaritic = 1432838514,

    [NativeName("HB_SCRIPT_BUGINESE")]
    Buginese = 1114990441,

    [NativeName("HB_SCRIPT_COPTIC")]
    Coptic = 1131376756,

    [NativeName("HB_SCRIPT_GLAGOLITIC")]
    Glagolitic = 1198285159,

    [NativeName("HB_SCRIPT_KHAROSHTHI")]
    Kharoshthi = 1265131890,

    [NativeName("HB_SCRIPT_NEW_TAI_LUE")]
    NewTaiLue = 1415670901,

    [NativeName("HB_SCRIPT_OLD_PERSIAN")]
    OldPersian = 1483761007,

    [NativeName("HB_SCRIPT_SYLOTI_NAGRI")]
    SylotiNagri = 1400466543,

    [NativeName("HB_SCRIPT_TIFINAGH")]
    Tifinagh = 1415999079,

    [NativeName("HB_SCRIPT_BALINESE")]
    Balinese = 1113681001,

    [NativeName("HB_SCRIPT_CUNEIFORM")]
    Cuneiform = 1483961720,

    [NativeName("HB_SCRIPT_NKO")]
    Nko = 1315663727,

    [NativeName("HB_SCRIPT_PHAGS_PA")]
    PhagsPa = 1349017959,

    [NativeName("HB_SCRIPT_PHOENICIAN")]
    Phoenician = 1349021304,

    [NativeName("HB_SCRIPT_CARIAN")]
    Carian = 1130459753,

    [NativeName("HB_SCRIPT_CHAM")]
    Cham = 1130914157,

    [NativeName("HB_SCRIPT_KAYAH_LI")]
    KayahLi = 1264675945,

    [NativeName("HB_SCRIPT_LEPCHA")]
    Lepcha = 1281716323,

    [NativeName("HB_SCRIPT_LYCIAN")]
    Lycian = 1283023721,

    [NativeName("HB_SCRIPT_LYDIAN")]
    Lydian = 1283023977,

    [NativeName("HB_SCRIPT_OL_CHIKI")]
    OlChiki = 1332503403,

    [NativeName("HB_SCRIPT_REJANG")]
    Rejang = 1382706791,

    [NativeName("HB_SCRIPT_SAURASHTRA")]
    Saurashtra = 1398895986,

    [NativeName("HB_SCRIPT_SUNDANESE")]
    Sundanese = 1400204900,

    [NativeName("HB_SCRIPT_VAI")]
    Vai = 1449224553,

    [NativeName("HB_SCRIPT_AVESTAN")]
    Avestan = 1098281844,

    [NativeName("HB_SCRIPT_BAMUM")]
    Bamum = 1113681269,

    [NativeName("HB_SCRIPT_EGYPTIAN_HIEROGLYPHS")]
    EgyptianHieroglyphs = 1164409200,

    [NativeName("HB_SCRIPT_IMPERIAL_ARAMAIC")]
    ImperialAramaic = 1098018153,

    [NativeName("HB_SCRIPT_INSCRIPTIONAL_PAHLAVI")]
    InscriptionalPahlavi = 1349020777,

    [NativeName("HB_SCRIPT_INSCRIPTIONAL_PARTHIAN")]
    InscriptionalParthian = 1349678185,

    [NativeName("HB_SCRIPT_JAVANESE")]
    Javanese = 1247901281,

    [NativeName("HB_SCRIPT_KAITHI")]
    Kaithi = 1265920105,

    [NativeName("HB_SCRIPT_LISU")]
    Lisu = 1281979253,

    [NativeName("HB_SCRIPT_MEETEI_MAYEK")]
    MeeteiMayek = 1299473769,

    [NativeName("HB_SCRIPT_OLD_SOUTH_ARABIAN")]
    OldSouthArabian = 1398895202,

    [NativeName("HB_SCRIPT_OLD_TURKIC")]
    OldTurkic = 1332898664,

    [NativeName("HB_SCRIPT_SAMARITAN")]
    Samaritan = 1398893938,

    [NativeName("HB_SCRIPT_TAI_THAM")]
    TaiTham = 1281453665,

    [NativeName("HB_SCRIPT_TAI_VIET")]
    TaiViet = 1415673460,

    [NativeName("HB_SCRIPT_BATAK")]
    Batak = 1113683051,

    [NativeName("HB_SCRIPT_BRAHMI")]
    Brahmi = 1114792296,

    [NativeName("HB_SCRIPT_MANDAIC")]
    Mandaic = 1298230884,

    [NativeName("HB_SCRIPT_CHAKMA")]
    Chakma = 1130457965,

    [NativeName("HB_SCRIPT_MEROITIC_CURSIVE")]
    MeroiticCursive = 1298494051,

    [NativeName("HB_SCRIPT_MEROITIC_HIEROGLYPHS")]
    MeroiticHieroglyphs = 1298494063,

    [NativeName("HB_SCRIPT_MIAO")]
    Miao = 1349284452,

    [NativeName("HB_SCRIPT_SHARADA")]
    Sharada = 1399353956,

    [NativeName("HB_SCRIPT_SORA_SOMPENG")]
    SoraSompeng = 1399812705,

    [NativeName("HB_SCRIPT_TAKRI")]
    Takri = 1415670642,

    [NativeName("HB_SCRIPT_BASSA_VAH")]
    BassaVah = 1113682803,

    [NativeName("HB_SCRIPT_CAUCASIAN_ALBANIAN")]
    CaucasianAlbanian = 1097295970,

    [NativeName("HB_SCRIPT_DUPLOYAN")]
    Duployan = 1148547180,

    [NativeName("HB_SCRIPT_ELBASAN")]
    Elbasan = 1164730977,

    [NativeName("HB_SCRIPT_GRANTHA")]
    Grantha = 1198678382,

    [NativeName("HB_SCRIPT_KHOJKI")]
    Khojki = 1265135466,

    [NativeName("HB_SCRIPT_KHUDAWADI")]
    Khudawadi = 1399418468,

    [NativeName("HB_SCRIPT_LINEAR_A")]
    LinearA = 1281977953,

    [NativeName("HB_SCRIPT_MAHAJANI")]
    Mahajani = 1298229354,

    [NativeName("HB_SCRIPT_MANICHAEAN")]
    Manichaean = 1298230889,

    [NativeName("HB_SCRIPT_MENDE_KIKAKUI")]
    MendeKikakui = 1298493028,

    [NativeName("HB_SCRIPT_MODI")]
    Modi = 1299145833,

    [NativeName("HB_SCRIPT_MRO")]
    Mro = 1299345263,

    [NativeName("HB_SCRIPT_NABATAEAN")]
    Nabataean = 1315070324,

    [NativeName("HB_SCRIPT_OLD_NORTH_ARABIAN")]
    OldNorthArabian = 1315009122,

    [NativeName("HB_SCRIPT_OLD_PERMIC")]
    OldPermic = 1348825709,

    [NativeName("HB_SCRIPT_PAHAWH_HMONG")]
    PahawhHmong = 1215131239,

    [NativeName("HB_SCRIPT_PALMYRENE")]
    Palmyrene = 1348562029,

    [NativeName("HB_SCRIPT_PAU_CIN_HAU")]
    PauCinHau = 1348564323,

    [NativeName("HB_SCRIPT_PSALTER_PAHLAVI")]
    PsalterPahlavi = 1349020784,

    [NativeName("HB_SCRIPT_SIDDHAM")]
    Siddham = 1399415908,

    [NativeName("HB_SCRIPT_TIRHUTA")]
    Tirhuta = 1416196712,

    [NativeName("HB_SCRIPT_WARANG_CITI")]
    WarangCiti = 1466004065,

    [NativeName("HB_SCRIPT_AHOM")]
    Ahom = 1097363309,

    [NativeName("HB_SCRIPT_ANATOLIAN_HIEROGLYPHS")]
    AnatolianHieroglyphs = 1215067511,

    [NativeName("HB_SCRIPT_HATRAN")]
    Hatran = 1214346354,

    [NativeName("HB_SCRIPT_MULTANI")]
    Multani = 1299541108,

    [NativeName("HB_SCRIPT_OLD_HUNGARIAN")]
    OldHungarian = 1215655527,

    [NativeName("HB_SCRIPT_SIGNWRITING")]
    Signwriting = 1399287415,

    [NativeName("HB_SCRIPT_ADLAM")]
    Adlam = 1097100397,

    [NativeName("HB_SCRIPT_BHAIKSUKI")]
    Bhaiksuki = 1114139507,

    [NativeName("HB_SCRIPT_MARCHEN")]
    Marchen = 1298231907,

    [NativeName("HB_SCRIPT_OSAGE")]
    Osage = 1332963173,

    [NativeName("HB_SCRIPT_TANGUT")]
    Tangut = 1415671399,

    [NativeName("HB_SCRIPT_NEWA")]
    Newa = 1315272545,

    [NativeName("HB_SCRIPT_MASARAM_GONDI")]
    MasaramGondi = 1198485101,

    [NativeName("HB_SCRIPT_NUSHU")]
    Nushu = 1316186229,

    [NativeName("HB_SCRIPT_SOYOMBO")]
    Soyombo = 1399814511,

    [NativeName("HB_SCRIPT_ZANABAZAR_SQUARE")]
    ZanabazarSquare = 1516334690,

    [NativeName("HB_SCRIPT_DOGRA")]
    Dogra = 1148151666,

    [NativeName("HB_SCRIPT_GUNJALA_GONDI")]
    GunjalaGondi = 1198485095,

    [NativeName("HB_SCRIPT_HANIFI_ROHINGYA")]
    HanifiRohingya = 1383032935,

    [NativeName("HB_SCRIPT_MAKASAR")]
    Makasar = 1298230113,

    [NativeName("HB_SCRIPT_MEDEFAIDRIN")]
    Medefaidrin = 1298490470,

    [NativeName("HB_SCRIPT_OLD_SOGDIAN")]
    OldSogdian = 1399809903,

    [NativeName("HB_SCRIPT_SOGDIAN")]
    Sogdian = 1399809892,

    [NativeName("HB_SCRIPT_ELYMAIC")]
    Elymaic = 1164736877,

    [NativeName("HB_SCRIPT_NANDINAGARI")]
    Nandinagari = 1315008100,

    [NativeName("HB_SCRIPT_NYIAKENG_PUACHUE_HMONG")]
    NyiakengPuachueHmong = 1215131248,

    [NativeName("HB_SCRIPT_WANCHO")]
    Wancho = 1466132591,

    [NativeName("HB_SCRIPT_CHORASMIAN")]
    Chorasmian = 1130918515,

    [NativeName("HB_SCRIPT_DIVES_AKURU")]
    DivesAkuru = 1147756907,

    [NativeName("HB_SCRIPT_KHITAN_SMALL_SCRIPT")]
    KhitanSmallScript = 1265202291,

    [NativeName("HB_SCRIPT_YEZIDI")]
    Yezidi = 1499822697,

    [NativeName("HB_SCRIPT_CYPRO_MINOAN")]
    CyproMinoan = 1131441518,

    [NativeName("HB_SCRIPT_OLD_UYGHUR")]
    OldUyghur = 1333094258,

    [NativeName("HB_SCRIPT_TANGSA")]
    Tangsa = 1416524641,

    [NativeName("HB_SCRIPT_TOTO")]
    Toto = 1416590447,

    [NativeName("HB_SCRIPT_VITHKUQI")]
    Vithkuqi = 1449751656,

    [NativeName("HB_SCRIPT_MATH")]
    Math = 1517122664,

    [NativeName("HB_SCRIPT_KAWI")]
    Kawi = 1264678761,

    [NativeName("HB_SCRIPT_NAG_MUNDARI")]
    NagMundari = 1315006317,

    [NativeName("HB_SCRIPT_GARAY")]
    Garay = 1197568609,

    [NativeName("HB_SCRIPT_GURUNG_KHEMA")]
    GurungKhema = 1198877544,

    [NativeName("HB_SCRIPT_KIRAT_RAI")]
    KiratRai = 1265787241,

    [NativeName("HB_SCRIPT_OL_ONAL")]
    OlOnal = 1332633967,

    [NativeName("HB_SCRIPT_SUNUWAR")]
    Sunuwar = 1400204917,

    [NativeName("HB_SCRIPT_TODHRI")]
    Todhri = 1416586354,

    [NativeName("HB_SCRIPT_TULU_TIGALARI")]
    TuluTigalari = 1416983655,

    [NativeName("HB_SCRIPT_BERIA_ERFE")]
    BeriaErfe = 1113944678,

    [NativeName("HB_SCRIPT_SIDETIC")]
    Sidetic = 1399415924,

    [NativeName("HB_SCRIPT_TAI_YO")]
    TaiYo = 1415674223,

    [NativeName("HB_SCRIPT_TOLONG_SIKI")]
    TolongSiki = 1416588403,

    [NativeName("HB_SCRIPT_INVALID")]
    Invalid = 0,

    [NativeName("_HB_SCRIPT_MAX_VALUE")]
    HbScriptMaxValue = 2147483647,

    [NativeName("_HB_SCRIPT_MAX_VALUE_SIGNED")]
    HbScriptMaxValueSigned = 2147483647,
}
