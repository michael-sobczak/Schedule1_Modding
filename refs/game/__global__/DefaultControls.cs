public static class DefaultControls // TypeDefIndex: 16385
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x2D95B40 Offset: 0x2D94540 VA: 0x182D95B40
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x2D95540 Offset: 0x2D93F40 VA: 0x182D95540
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x2D95650 Offset: 0x2D94050 VA: 0x182D95650
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x2D95780 Offset: 0x2D94180 VA: 0x182D95780
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x2D95730 Offset: 0x2D94130 VA: 0x182D95730
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x2D95940 Offset: 0x2D94340 VA: 0x182D95940
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x2D95860 Offset: 0x2D94260 VA: 0x182D95860
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x2D92BB0 Offset: 0x2D915B0 VA: 0x182D92BB0
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x2D90460 Offset: 0x2D8EE60 VA: 0x182D90460
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x2D94C00 Offset: 0x2D93600 VA: 0x182D94C00
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x2D92230 Offset: 0x2D90C30 VA: 0x182D92230
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x2D92F30 Offset: 0x2D91930 VA: 0x182D92F30
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x2D94270 Offset: 0x2D92C70 VA: 0x182D94270
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x2D93C20 Offset: 0x2D92620 VA: 0x182D93C20
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x2D94DC0 Offset: 0x2D937C0 VA: 0x182D94DC0
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x2D92380 Offset: 0x2D90D80 VA: 0x182D92380
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x2D90980 Offset: 0x2D8F380 VA: 0x182D90980
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x2D93080 Offset: 0x2D91A80 VA: 0x182D93080
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x2D95A20 Offset: 0x2D94420 VA: 0x182D95A20
	private static void .cctor() { }
}
