public struct FontAssetCreationSettings // TypeDefIndex: 14901
{
	// Fields
	public string sourceFontFileName; // 0x0
	public string sourceFontFileGUID; // 0x8
	public int faceIndex; // 0x10
	public int pointSizeSamplingMode; // 0x14
	public int pointSize; // 0x18
	public int padding; // 0x1C
	public int paddingMode; // 0x20
	public int packingMode; // 0x24
	public int atlasWidth; // 0x28
	public int atlasHeight; // 0x2C
	public int characterSetSelectionMode; // 0x30
	public string characterSequence; // 0x38
	public string referencedFontAssetGUID; // 0x40
	public string referencedTextAssetGUID; // 0x48
	public int fontStyle; // 0x50
	public float fontStyleModifier; // 0x54
	public int renderMode; // 0x58
	public bool includeFontFeatures; // 0x5C

	// Methods

	// RVA: 0x2BEBB50 Offset: 0x2BEA550 VA: 0x182BEBB50
	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }
}
