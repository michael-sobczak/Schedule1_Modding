internal class TextHandle // TypeDefIndex: 16746
{
	// Fields
	private Vector2 m_PreferredSize; // 0x10
	private TextInfo m_TextInfo; // 0x18
	private static TextInfo m_LayoutTextInfo; // 0x0
	private int m_PreviousGenerationSettingsHash; // 0x20
	protected TextGenerationSettings textGenerationSettings; // 0x28
	protected static TextGenerationSettings s_LayoutSettings; // 0x8
	private bool isDirty; // 0x30

	// Properties
	internal TextInfo textInfo { get; }
	internal static TextInfo layoutTextInfo { get; }

	// Methods

	// RVA: 0x2D85EE0 Offset: 0x2D848E0 VA: 0x182D85EE0
	public void .ctor() { }

	// RVA: 0x2D86040 Offset: 0x2D84A40 VA: 0x182D86040
	internal TextInfo get_textInfo() { }

	// RVA: 0x2D85F50 Offset: 0x2D84950 VA: 0x182D85F50
	internal static TextInfo get_layoutTextInfo() { }

	// RVA: 0x2D84B50 Offset: 0x2D83550 VA: 0x182D84B50
	public bool IsDirty() { }

	// RVA: 0x2D84130 Offset: 0x2D82B30 VA: 0x182D84130
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = True) { }

	// RVA: 0x2D843C0 Offset: 0x2D82DC0 VA: 0x182D843C0
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x2D83D10 Offset: 0x2D82710 VA: 0x182D83D10
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = True) { }

	// RVA: 0x2D84D80 Offset: 0x2D83780 VA: 0x182D84D80
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x2D85340 Offset: 0x2D83D40 VA: 0x182D85340
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x2D83980 Offset: 0x2D82380 VA: 0x182D83980
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x2D82F80 Offset: 0x2D81980 VA: 0x182D82F80
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x2D82950 Offset: 0x2D81350 VA: 0x182D82950
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = True) { }

	// RVA: 0x2D85930 Offset: 0x2D84330 VA: 0x182D85930
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x2D82760 Offset: 0x2D81160 VA: 0x182D82760
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x2D848D0 Offset: 0x2D832D0 VA: 0x182D848D0
	public int GetLineNumber(int index) { }

	// RVA: 0x2D847F0 Offset: 0x2D831F0 VA: 0x182D847F0
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x2D84650 Offset: 0x2D83050 VA: 0x182D84650
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x2D83B30 Offset: 0x2D82530 VA: 0x182D83B30
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x2D84BA0 Offset: 0x2D835A0 VA: 0x182D84BA0
	public bool IsElided() { }

	// RVA: 0x2D85AB0 Offset: 0x2D844B0 VA: 0x182D85AB0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2D849B0 Offset: 0x2D833B0 VA: 0x182D849B0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2D84C40 Offset: 0x2D83640 VA: 0x182D84C40
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x2D82740 Offset: 0x2D81140 VA: 0x182D82740
	protected float ComputeTextWidth(TextGenerationSettings tgs) { }

	// RVA: 0x2D82720 Offset: 0x2D81120 VA: 0x182D82720
	protected float ComputeTextHeight(TextGenerationSettings tgs) { }

	// RVA: 0x2D85C70 Offset: 0x2D84670 VA: 0x182D85C70
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	// RVA: 0x2D85DC0 Offset: 0x2D847C0 VA: 0x182D85DC0
	protected TextInfo Update(TextGenerationSettings tgs) { }

	// RVA: 0x2D85E60 Offset: 0x2D84860 VA: 0x182D85E60
	private static void .cctor() { }
}
