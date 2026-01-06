public class TMP_UpdateRegistry // TypeDefIndex: 15009
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x2C3A210 Offset: 0x2C38C10 VA: 0x182C3A210
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x2C3A0B0 Offset: 0x2C38AB0 VA: 0x182C3A0B0
	protected void .ctor() { }

	// RVA: 0x2C39D80 Offset: 0x2C38780 VA: 0x182C39D80
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2C39600 Offset: 0x2C38000 VA: 0x182C39600
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2C39C50 Offset: 0x2C38650 VA: 0x182C39C50
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2C394D0 Offset: 0x2C37ED0 VA: 0x182C394D0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2C39930 Offset: 0x2C38330 VA: 0x182C39930
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x2C39BF0 Offset: 0x2C385F0 VA: 0x182C39BF0
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x2C39EB0 Offset: 0x2C388B0 VA: 0x182C39EB0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x2C39830 Offset: 0x2C38230 VA: 0x182C39830
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2C39730 Offset: 0x2C38130 VA: 0x182C39730
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}
