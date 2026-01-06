public sealed class FontEngine // TypeDefIndex: 18689
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; // 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; // 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; // 0x48
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x50

	// Methods

	// RVA: 0x2D48BD0 Offset: 0x2D475D0 VA: 0x182D48BD0
	public static FontEngineError LoadFontFace(string filePath) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2D488E0 Offset: 0x2D472E0 VA: 0x182D488E0
	private static int LoadFontFace_Internal(string filePath) { }

	// RVA: 0x2D48AB0 Offset: 0x2D474B0 VA: 0x182D48AB0
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2D48920 Offset: 0x2D47320 VA: 0x182D48920
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x2D48A20 Offset: 0x2D47420 VA: 0x182D48A20
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2D48970 Offset: 0x2D47370 VA: 0x182D48970
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x2D48B40 Offset: 0x2D47540 VA: 0x182D48B40
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x2D489C0 Offset: 0x2D473C0 VA: 0x182D489C0
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x2D4A480 Offset: 0x2D48E80 VA: 0x182D4A480
	public static FontEngineError UnloadFontFace() { }

	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	// RVA: 0x2D4A450 Offset: 0x2D48E50 VA: 0x182D4A450
	private static int UnloadFontFace_Internal() { }

	// RVA: 0x2D4A3C0 Offset: 0x2D48DC0 VA: 0x182D4A3C0
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D4A360 Offset: 0x2D48D60 VA: 0x182D4A360
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x2D475D0 Offset: 0x2D45FD0 VA: 0x182D475D0
	public static FaceInfo GetFaceInfo() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D47590 Offset: 0x2D45F90 VA: 0x182D47590
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0x2D476E0 Offset: 0x2D460E0 VA: 0x182D476E0
	public static string[] GetFontFaces() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D476B0 Offset: 0x2D460B0 VA: 0x182D476B0
	private static string[] GetFontFaces_Internal() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D48800 Offset: 0x2D47200 VA: 0x182D48800
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D47750 Offset: 0x2D46150 VA: 0x182D47750
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x2D4A1E0 Offset: 0x2D48BE0 VA: 0x182D4A1E0
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D4A190 Offset: 0x2D48B90 VA: 0x182D4A190
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x2D4A010 Offset: 0x2D48A10 VA: 0x182D4A010
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D49FC0 Offset: 0x2D489C0 VA: 0x182D49FC0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D48E10 Offset: 0x2D47810 VA: 0x182D48E10
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x2D48EC0 Offset: 0x2D478C0 VA: 0x182D48EC0
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D48E50 Offset: 0x2D47850 VA: 0x182D48E50
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x2D49560 Offset: 0x2D47F60 VA: 0x182D49560
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D494F0 Offset: 0x2D47EF0 VA: 0x182D494F0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D474D0 Offset: 0x2D45ED0 VA: 0x182D474D0
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	// RVA: 0x2D47AD0 Offset: 0x2D464D0 VA: 0x182D47AD0
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	// RVA: 0x2D47BD0 Offset: 0x2D465D0 VA: 0x182D47BD0
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<uint> glyphIndexes) { }

	// RVA: 0x2D47C60 Offset: 0x2D46660 VA: 0x182D47C60
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48C40 Offset: 0x2D47640 VA: 0x182D48C40
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D47A90 Offset: 0x2D46490 VA: 0x182D47A90
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	// RVA: 0x2D47930 Offset: 0x2D46330 VA: 0x182D47930
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	// RVA: 0x2D47790 Offset: 0x2D46190 VA: 0x182D47790
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	// RVA: 0x2D48D30 Offset: 0x2D47730 VA: 0x182D48D30
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D47560 Offset: 0x2D45F60 VA: 0x182D47560
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	// RVA: 0x2D484D0 Offset: 0x2D46ED0 VA: 0x182D484D0
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x2D486A0 Offset: 0x2D470A0 VA: 0x182D486A0
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48D80 Offset: 0x2D47780 VA: 0x182D48D80
	private static int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48490 Offset: 0x2D46E90 VA: 0x182D48490
	private static int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D47500 Offset: 0x2D45F00 VA: 0x182D47500
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	// RVA: 0x2D47F40 Offset: 0x2D46940 VA: 0x182D47F40
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x2D47DF0 Offset: 0x2D467F0 VA: 0x182D47DF0
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48C90 Offset: 0x2D47690 VA: 0x182D48C90
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D47DB0 Offset: 0x2D467B0 VA: 0x182D47DB0
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray([Out] MarkToBaseAdjustmentRecord[] adjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x2D47530 Offset: 0x2D45F30 VA: 0x182D47530
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	// RVA: 0x2D48150 Offset: 0x2D46B50 VA: 0x182D48150
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x2D48320 Offset: 0x2D46D20 VA: 0x182D48320
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48CE0 Offset: 0x2D476E0 VA: 0x182D48CE0
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x2D48110 Offset: 0x2D46B10 VA: 0x182D48110
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray([Out] MarkToMarkAdjustmentRecord[] adjustmentRecords) { }

	// RVA: 0x2D48840 Offset: 0x2D47240 VA: 0x182D48840
	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray) { }

	// RVA: -1 Offset: -1
	private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBB6A0 Offset: 0xEBA0A0 VA: 0x180EBB6A0
	|-FontEngine.GenericListToMarshallingArray<uint>
	|
	|-RVA: 0xEBBA10 Offset: 0xEBA410 VA: 0x180EBBA10
	|-FontEngine.GenericListToMarshallingArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBBCC0 Offset: 0xEBA6C0 VA: 0x180EBBCC0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	|-FontEngine.SetMarshallingArraySize<LigatureSubstitutionRecord>
	|-FontEngine.SetMarshallingArraySize<MarkToBaseAdjustmentRecord>
	|-FontEngine.SetMarshallingArraySize<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xEBBD70 Offset: 0xEBA770 VA: 0x180EBBD70
	|-FontEngine.SetMarshallingArraySize<__Il2CppFullySharedGenericType>
	*/

	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	// RVA: 0x2D48DD0 Offset: 0x2D477D0 VA: 0x182D48DD0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x2D4A4E0 Offset: 0x2D48EE0 VA: 0x182D4A4E0
	private static void .cctor() { }
}
