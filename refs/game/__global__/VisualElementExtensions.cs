public static class VisualElementExtensions // TypeDefIndex: 7027
{
	// Methods

	[Extension]
	// RVA: 0x2DF0020 Offset: 0x2DEEA20 VA: 0x182DF0020
	public static void StretchToParentSize(VisualElement elem) { }

	[Extension]
	// RVA: 0x2DEFCE0 Offset: 0x2DEE6E0 VA: 0x182DEFCE0
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	// RVA: 0x2DEFFD0 Offset: 0x2DEE9D0 VA: 0x182DEFFD0
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	// RVA: 0x2DF0500 Offset: 0x2DEEF00 VA: 0x182DF0500
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	[Extension]
	// RVA: 0x2DEFEF0 Offset: 0x2DEE8F0 VA: 0x182DEFEF0
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	[Extension]
	// RVA: 0x2DF0420 Offset: 0x2DEEE20 VA: 0x182DF0420
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	[Extension]
	// RVA: 0x2DEFD30 Offset: 0x2DEE730 VA: 0x182DEFD30
	public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }
}
