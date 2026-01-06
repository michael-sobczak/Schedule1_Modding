public static class LayoutUtility // TypeDefIndex: 16448
{
	// Methods

	// RVA: 0x2F29C70 Offset: 0x2F28670 VA: 0x182F29C70
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x2F2A160 Offset: 0x2F28B60 VA: 0x182F2A160
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x2F29550 Offset: 0x2F27F50 VA: 0x182F29550
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x2F29E60 Offset: 0x2F28860 VA: 0x182F29E60
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x2F2A4F0 Offset: 0x2F28EF0 VA: 0x182F2A4F0
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x2F29740 Offset: 0x2F28140 VA: 0x182F29740
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x2F29B60 Offset: 0x2F28560 VA: 0x182F29B60
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x2F29F70 Offset: 0x2F28970 VA: 0x182F29F70
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x2F29440 Offset: 0x2F27E40 VA: 0x182F29440
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x2F29850 Offset: 0x2F28250 VA: 0x182F29850
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x2F29870 Offset: 0x2F28270 VA: 0x182F29870
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}
