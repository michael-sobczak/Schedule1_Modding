public static class UQueryExtensions // TypeDefIndex: 6946
{
	// Fields
	private static UQueryState<VisualElement> SingleElementEmptyQuery; // 0x0
	private static UQueryState<VisualElement> SingleElementNameQuery; // 0x10
	private static UQueryState<VisualElement> SingleElementClassQuery; // 0x20
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; // 0x30
	private static UQueryState<VisualElement> SingleElementTypeQuery; // 0x40
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; // 0x50
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; // 0x60
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T Q<T>(VisualElement e, string name, string className) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF65A40 Offset: 0xF64440 VA: 0x180F65A40
	|-UQueryExtensions.Q<object>
	*/

	[Extension]
	// RVA: 0x2DEB240 Offset: 0x2DE9C40 VA: 0x182DEB240
	public static VisualElement Q(VisualElement e, string name, string className) { }

	// RVA: 0x2DEB710 Offset: 0x2DEA110 VA: 0x182DEB710
	private static void .cctor() { }
}
