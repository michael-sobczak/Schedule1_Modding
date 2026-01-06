public class CanvasUpdateRegistry // TypeDefIndex: 16375
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x2D8F1D0 Offset: 0x2D8DBD0 VA: 0x182D8F1D0
	protected void .ctor() { }

	// RVA: 0x2D8F3E0 Offset: 0x2D8DDE0 VA: 0x182D8F3E0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x2D8E490 Offset: 0x2D8CE90 VA: 0x182D8E490
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x2D8DA60 Offset: 0x2D8C460 VA: 0x182D8DA60
	private void CleanInvalidItems() { }

	// RVA: 0x2D8E630 Offset: 0x2D8D030 VA: 0x182D8E630
	private void PerformUpdate() { }

	// RVA: 0x2D8E560 Offset: 0x2D8CF60 VA: 0x182D8E560
	private static int ParentCount(Transform child) { }

	// RVA: 0x2D8ED90 Offset: 0x2D8D790 VA: 0x182D8ED90
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x2D8ED30 Offset: 0x2D8D730 VA: 0x182D8ED30
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2D8EEA0 Offset: 0x2D8D8A0 VA: 0x182D8EEA0
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2D8E140 Offset: 0x2D8CB40 VA: 0x182D8E140
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2D8ECD0 Offset: 0x2D8D6D0 VA: 0x182D8ECD0
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2D8EE40 Offset: 0x2D8D840 VA: 0x182D8EE40
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2D8E080 Offset: 0x2D8CA80 VA: 0x182D8E080
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2D8EF00 Offset: 0x2D8D900 VA: 0x182D8EF00
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x2D8DC20 Offset: 0x2D8C620 VA: 0x182D8DC20
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x2D8E2E0 Offset: 0x2D8CCE0 VA: 0x182D8E2E0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2D8E1D0 Offset: 0x2D8CBD0 VA: 0x182D8E1D0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2D8DF70 Offset: 0x2D8C970 VA: 0x182D8DF70
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2D8DE60 Offset: 0x2D8C860 VA: 0x182D8DE60
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2D8E440 Offset: 0x2D8CE40 VA: 0x182D8E440
	public static bool IsRebuildingLayout() { }

	// RVA: 0x2D8E3F0 Offset: 0x2D8CDF0 VA: 0x182D8E3F0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x2D8F140 Offset: 0x2D8DB40 VA: 0x182D8F140
	private static void .cctor() { }
}
