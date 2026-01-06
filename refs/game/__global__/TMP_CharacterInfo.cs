public struct TMP_CharacterInfo // TypeDefIndex: 14871
{
	// Fields
	public TMP_TextElementType elementType; // 0x0
	public char character; // 0x4
	public int index; // 0x8
	public int stringLength; // 0xC
	public TMP_TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public TMP_FontAsset fontAsset; // 0x20
	public Material material; // 0x28
	public int materialReferenceIndex; // 0x30
	public bool isUsingAlternateTypeface; // 0x34
	public float pointSize; // 0x38
	public int lineNumber; // 0x3C
	public int pageNumber; // 0x40
	public int vertexIndex; // 0x44
	public TMP_Vertex vertex_BL; // 0x48
	public TMP_Vertex vertex_TL; // 0x70
	public TMP_Vertex vertex_TR; // 0x98
	public TMP_Vertex vertex_BR; // 0xC0
	public Vector3 topLeft; // 0xE8
	public Vector3 bottomLeft; // 0xF4
	public Vector3 topRight; // 0x100
	public Vector3 bottomRight; // 0x10C
	public float origin; // 0x118
	public float xAdvance; // 0x11C
	public float ascender; // 0x120
	public float baseLine; // 0x124
	public float descender; // 0x128
	internal float adjustedAscender; // 0x12C
	internal float adjustedDescender; // 0x130
	internal float adjustedHorizontalAdvance; // 0x134
	public float aspectRatio; // 0x138
	public float scale; // 0x13C
	public Color32 color; // 0x140
	public Color32 underlineColor; // 0x144
	public int underlineVertexIndex; // 0x148
	public Color32 strikethroughColor; // 0x14C
	public int strikethroughVertexIndex; // 0x150
	public Color32 highlightColor; // 0x154
	public HighlightState highlightState; // 0x158
	public FontStyles style; // 0x16C
	public bool isVisible; // 0x170
}
