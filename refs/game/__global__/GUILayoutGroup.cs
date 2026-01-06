internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 17615
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x2D1F7E0 Offset: 0x2D1E1E0 VA: 0x182D1F7E0
	public void .ctor() { }

	// RVA: 0x2D1D180 Offset: 0x2D1BB80 VA: 0x182D1D180 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x2D1D2C0 Offset: 0x2D1BCC0 VA: 0x182D1D2C0 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x2D1E3D0 Offset: 0x2D1CDD0 VA: 0x182D1E3D0
	public void ResetCursor() { }

	// RVA: 0x2D1E130 Offset: 0x2D1CB30 VA: 0x182D1E130
	public GUILayoutEntry GetNext() { }

	// RVA: 0x2D1D0D0 Offset: 0x2D1BAD0 VA: 0x182D1D0D0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x2D1DA00 Offset: 0x2D1C400 VA: 0x182D1DA00 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2D1E3E0 Offset: 0x2D1CDE0 VA: 0x182D1E3E0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x2D1D340 Offset: 0x2D1BD40 VA: 0x182D1D340 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2D1EBB0 Offset: 0x2D1D5B0 VA: 0x182D1EBB0 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x2D1F390 Offset: 0x2D1DD90 VA: 0x182D1F390 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D1F700 Offset: 0x2D1E100 VA: 0x182D1F700
	private static void .cctor() { }
}
