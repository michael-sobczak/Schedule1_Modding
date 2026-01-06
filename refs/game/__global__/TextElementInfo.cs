internal struct TextElementInfo // TypeDefIndex: 16727
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public TextElementType elementType; // 0x8
	public int stringLength; // 0xC
	public TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public FontAsset fontAsset; // 0x20
	public SpriteAsset spriteAsset; // 0x28
	public int spriteIndex; // 0x30
	public Material material; // 0x38
	public int materialReferenceIndex; // 0x40
	public bool isUsingAlternateTypeface; // 0x44
	public float pointSize; // 0x48
	public int lineNumber; // 0x4C
	public int pageNumber; // 0x50
	public int vertexIndex; // 0x54
	public TextVertex vertexTopLeft; // 0x58
	public TextVertex vertexBottomLeft; // 0x80
	public TextVertex vertexTopRight; // 0xA8
	public TextVertex vertexBottomRight; // 0xD0
	public Vector3 topLeft; // 0xF8
	public Vector3 bottomLeft; // 0x104
	public Vector3 topRight; // 0x110
	public Vector3 bottomRight; // 0x11C
	public float origin; // 0x128
	public float ascender; // 0x12C
	public float baseLine; // 0x130
	public float descender; // 0x134
	internal float adjustedAscender; // 0x138
	internal float adjustedDescender; // 0x13C
	internal float adjustedHorizontalAdvance; // 0x140
	public float xAdvance; // 0x144
	public float aspectRatio; // 0x148
	public float scale; // 0x14C
	public Color32 color; // 0x150
	public Color32 underlineColor; // 0x154
	public int underlineVertexIndex; // 0x158
	public Color32 strikethroughColor; // 0x15C
	public int strikethroughVertexIndex; // 0x160
	public Color32 highlightColor; // 0x164
	public HighlightState highlightState; // 0x168
	public FontStyles style; // 0x17C
	public bool isVisible; // 0x180

	// Methods

	// RVA: 0x2D5B520 Offset: 0x2D59F20 VA: 0x182D5B520 Slot: 3
	public override string ToString() { }
}
