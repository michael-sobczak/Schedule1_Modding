internal static class TextGeneratorUtilities // TypeDefIndex: 16745
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8

	// Methods

	// RVA: 0x2D7E240 Offset: 0x2D7CC40 VA: 0x182D7E240
	public static bool Approximately(float a, float b) { }

	// RVA: 0x2D806F0 Offset: 0x2D7F0F0 VA: 0x182D806F0
	public static Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x2D80DB0 Offset: 0x2D7F7B0 VA: 0x182D80DB0
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x2D81030 Offset: 0x2D7FA30 VA: 0x182D81030
	public static uint HexToInt(char hex) { }

	// RVA: 0x2D7E3F0 Offset: 0x2D7CDF0 VA: 0x182D7E3F0
	public static float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x2D7E270 Offset: 0x2D7CC70 VA: 0x182D7E270
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x2D81E40 Offset: 0x2D80840 VA: 0x182D81E40
	public static Vector2 PackUV(float x, float y, float scale) { }

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5F460 Offset: 0xF5DE60 VA: 0x180F5F460
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0xF5F3A0 Offset: 0xF5DDA0 VA: 0x180F5F3A0
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF5F4C0 Offset: 0xF5DEC0 VA: 0x180F5F4C0
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0xF5F400 Offset: 0xF5DE00 VA: 0x180F5F400
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2D81430 Offset: 0x2D7FE30 VA: 0x182D81430
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81250 Offset: 0x2D7FC50 VA: 0x182D81250
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81FB0 Offset: 0x2D809B0 VA: 0x182D81FB0
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D821A0 Offset: 0x2D80BA0 VA: 0x182D821A0
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81E80 Offset: 0x2D80880 VA: 0x182D81E80
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81340 Offset: 0x2D7FD40 VA: 0x182D81340
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81150 Offset: 0x2D7FB50 VA: 0x182D81150
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D81520 Offset: 0x2D7FF20 VA: 0x182D81520
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x2D80110 Offset: 0x2D7EB10 VA: 0x182D80110
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x2D80020 Offset: 0x2D7EA20 VA: 0x182D80020
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x2D7FF30 Offset: 0x2D7E930 VA: 0x182D7FF30
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: 0x2D80300 Offset: 0x2D7ED00 VA: 0x182D80300
	public static uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x2D80200 Offset: 0x2D7EC00 VA: 0x182D80200
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x2D803E0 Offset: 0x2D7EDE0 VA: 0x182D803E0
	public static uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x2D80540 Offset: 0x2D7EF40 VA: 0x182D80540
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x2D7E480 Offset: 0x2D7CE80 VA: 0x182D7E480
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2D7F020 Offset: 0x2D7DA20 VA: 0x182D7F020
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x2D7DEA0 Offset: 0x2D7C8A0 VA: 0x182D7DEA0
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x2D82390 Offset: 0x2D80D90 VA: 0x182D82390
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x2D81DB0 Offset: 0x2D807B0 VA: 0x182D81DB0
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x2D81D30 Offset: 0x2D80730 VA: 0x182D81D30
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x2D7E470 Offset: 0x2D7CE70 VA: 0x182D7E470
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x2D7FE30 Offset: 0x2D7E830 VA: 0x182D7FE30
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x2D7FD40 Offset: 0x2D7E740 VA: 0x182D7FD40
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x2D825A0 Offset: 0x2D80FA0 VA: 0x182D825A0
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x2D82600 Offset: 0x2D81000 VA: 0x182D82600
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x2D82660 Offset: 0x2D81060 VA: 0x182D82660
	public static char ToUpperFast(char c) { }

	// RVA: 0x2D7FC50 Offset: 0x2D7E650 VA: 0x182D7FC50
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x2D81B00 Offset: 0x2D80500 VA: 0x182D81B00
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x2D819F0 Offset: 0x2D803F0 VA: 0x182D819F0
	public static bool IsBaseGlyph(uint c) { }

	[Extension]
	// RVA: 0x2D81DE0 Offset: 0x2D807E0 VA: 0x182D81DE0
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x2D7FB20 Offset: 0x2D7E520 VA: 0x182D7FB20
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x2D7FBA0 Offset: 0x2D7E5A0 VA: 0x182D7FBA0
	private static byte GammaToLinear(byte value) { }

	// RVA: 0x2D81C50 Offset: 0x2D80650 VA: 0x182D81C50
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x2D81CC0 Offset: 0x2D806C0 VA: 0x182D81CC0
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x2D81BF0 Offset: 0x2D805F0 VA: 0x182D81BF0
	internal static bool IsHangul(uint c) { }

	// RVA: 0x2D81B30 Offset: 0x2D80530 VA: 0x182D81B30
	internal static bool IsCJK(uint c) { }

	// RVA: 0x2D826C0 Offset: 0x2D810C0 VA: 0x182D826C0
	private static void .cctor() { }
}
