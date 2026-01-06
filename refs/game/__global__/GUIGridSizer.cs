internal sealed class GUIGridSizer : GUILayoutEntry // TypeDefIndex: 17613
{
	// Fields
	private readonly int m_Count; // 0x48
	private readonly int m_XCount; // 0x4C
	private readonly float m_MinButtonWidth; // 0x50
	private readonly float m_MaxButtonWidth; // 0x54
	private readonly float m_MinButtonHeight; // 0x58
	private readonly float m_MaxButtonHeight; // 0x5C

	// Properties
	private int rows { get; }

	// Methods

	// RVA: 0x2D05350 Offset: 0x2D03D50 VA: 0x182D05350
	public static Rect GetRect(GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D05550 Offset: 0x2D03F50 VA: 0x182D05550
	private void .ctor(GUIContent[] contents, int xCount, GUIStyle buttonStyle, GUILayoutOption[] options) { }

	// RVA: 0x2D05BB0 Offset: 0x2D045B0 VA: 0x182D05BB0
	private int get_rows() { }
}
