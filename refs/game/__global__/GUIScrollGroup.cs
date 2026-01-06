internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 17616
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D1FE50 Offset: 0x2D1E850 VA: 0x182D1FE50
	public void .ctor() { }

	// RVA: 0x2D1FA30 Offset: 0x2D1E430 VA: 0x182D1FA30 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2D1FAD0 Offset: 0x2D1E4D0 VA: 0x182D1FAD0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x2D1F910 Offset: 0x2D1E310 VA: 0x182D1F910 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2D1FC20 Offset: 0x2D1E620 VA: 0x182D1FC20 Slot: 11
	public override void SetVertical(float y, float height) { }
}
