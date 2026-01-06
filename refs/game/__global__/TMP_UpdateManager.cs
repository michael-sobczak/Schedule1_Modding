public class TMP_UpdateManager // TypeDefIndex: 15008
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x2C393F0 Offset: 0x2C37DF0 VA: 0x182C393F0
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x2C391D0 Offset: 0x2C37BD0 VA: 0x182C391D0
	private void .ctor() { }

	// RVA: 0x2C38CE0 Offset: 0x2C376E0 VA: 0x182C38CE0
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x2C38730 Offset: 0x2C37130 VA: 0x182C38730
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x2C38BE0 Offset: 0x2C375E0 VA: 0x182C38BE0
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x2C38670 Offset: 0x2C37070 VA: 0x182C38670
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x2C38AE0 Offset: 0x2C374E0 VA: 0x182C38AE0
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x2C385B0 Offset: 0x2C36FB0 VA: 0x182C385B0
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x2C389E0 Offset: 0x2C373E0 VA: 0x182C389E0
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x2C384F0 Offset: 0x2C36EF0 VA: 0x182C384F0
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x2C389D0 Offset: 0x2C373D0 VA: 0x182C389D0
	private void OnCameraPreCull() { }

	// RVA: 0x2C38200 Offset: 0x2C36C00 VA: 0x182C38200
	private void DoRebuilds() { }

	// RVA: 0x2C38FB0 Offset: 0x2C379B0 VA: 0x182C38FB0
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x2C38DE0 Offset: 0x2C377E0 VA: 0x182C38DE0
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x2C387F0 Offset: 0x2C371F0 VA: 0x182C387F0
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x2C38890 Offset: 0x2C37290 VA: 0x182C38890
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x2C38930 Offset: 0x2C37330 VA: 0x182C38930
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x2C39080 Offset: 0x2C37A80 VA: 0x182C39080
	private static void .cctor() { }
}
