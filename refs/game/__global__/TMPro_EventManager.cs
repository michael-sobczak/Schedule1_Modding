public static class TMPro_EventManager // TypeDefIndex: 14851
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x2BEA850 Offset: 0x2BE9250 VA: 0x182BEA850
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x2BEA7C0 Offset: 0x2BE91C0 VA: 0x182BEA7C0
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x2BEA940 Offset: 0x2BE9340 VA: 0x182BEA940
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x2BEA9D0 Offset: 0x2BE93D0 VA: 0x182BEA9D0
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x2BEA720 Offset: 0x2BE9120 VA: 0x182BEA720
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x2BEAB70 Offset: 0x2BE9570 VA: 0x182BEAB70
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x2BEA610 Offset: 0x2BE9010 VA: 0x182BEA610
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x2BEAAF0 Offset: 0x2BE94F0 VA: 0x182BEAAF0
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x2BEABF0 Offset: 0x2BE95F0 VA: 0x182BEABF0
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x2BEA8E0 Offset: 0x2BE92E0 VA: 0x182BEA8E0
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x2BEAA60 Offset: 0x2BE9460 VA: 0x182BEAA60
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x2BEA690 Offset: 0x2BE9090 VA: 0x182BEA690
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x2BEAC50 Offset: 0x2BE9650 VA: 0x182BEAC50
	private static void .cctor() { }
}
