internal abstract class BaseRuntimePanel : Panel // TypeDefIndex: 6732
{
	// Fields
	private GameObject m_SelectableGameObject; // 0x160
	private static int s_CurrentRuntimePanelCounter; // 0x0
	internal readonly int m_RuntimePanelCreationIndex; // 0x168
	private float m_SortingPriority; // 0x16C
	internal int resolvedSortingIndex; // 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action destroyed; // 0x178
	private Shader m_StandardWorldSpaceShader; // 0x180
	private bool m_DrawToCameras; // 0x188
	internal RenderTexture targetTexture; // 0x190
	internal Matrix4x4 panelToWorld; // 0x198
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <targetDisplay>k__BackingField; // 0x1D8
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; // 0x8
	private Func<Vector2, Vector2> m_ScreenToPanelSpace; // 0x1E0

	// Properties
	public GameObject selectableGameObject { get; set; }
	public float sortingPriority { get; set; }
	internal override Shader standardWorldSpaceShader { get; }
	internal bool drawToCameras { get; set; }
	internal int targetDisplay { get; set; }
	internal int screenRenderingWidth { get; }
	internal int screenRenderingHeight { get; }
	public Func<Vector2, Vector2> screenToPanelSpace { get; set; }

	// Methods

	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 55
	public GameObject get_selectableGameObject() { }

	// RVA: 0x2ED4470 Offset: 0x2ED2E70 VA: 0x182ED4470 Slot: 56
	public void set_selectableGameObject(GameObject value) { }

	// RVA: 0x653860 Offset: 0x652260 VA: 0x180653860
	public float get_sortingPriority() { }

	// RVA: 0x2ED4510 Offset: 0x2ED2F10 VA: 0x182ED4510
	public void set_sortingPriority(float value) { }

	[CompilerGenerated]
	// RVA: 0x2ED3E70 Offset: 0x2ED2870 VA: 0x182ED3E70
	public void add_destroyed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2ED4290 Offset: 0x2ED2C90 VA: 0x182ED4290
	public void remove_destroyed(Action value) { }

	// RVA: 0x2ED3D10 Offset: 0x2ED2710 VA: 0x182ED3D10
	protected void .ctor(ScriptableObject ownerObject, EventDispatcher dispatcher) { }

	// RVA: 0x2ED3380 Offset: 0x2ED1D80 VA: 0x182ED3380 Slot: 23
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2D55C80 Offset: 0x2D54680 VA: 0x182D55C80 Slot: 50
	internal override Shader get_standardWorldSpaceShader() { }

	// RVA: 0x2ED40A0 Offset: 0x2ED2AA0 VA: 0x182ED40A0
	internal bool get_drawToCameras() { }

	// RVA: 0x2ED4340 Offset: 0x2ED2D40 VA: 0x182ED4340
	internal void set_drawToCameras(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21C7AF0 Offset: 0x21C64F0 VA: 0x1821C7AF0
	internal int get_targetDisplay() { }

	[CompilerGenerated]
	// RVA: 0x2ED45A0 Offset: 0x2ED2FA0 VA: 0x182ED45A0
	internal void set_targetDisplay(int value) { }

	// RVA: 0x2ED41A0 Offset: 0x2ED2BA0 VA: 0x182ED41A0
	internal int get_screenRenderingWidth() { }

	// RVA: 0x2ED40B0 Offset: 0x2ED2AB0 VA: 0x182ED40B0
	internal int get_screenRenderingHeight() { }

	// RVA: 0x2ED3F20 Offset: 0x2ED2920 VA: 0x182ED3F20
	internal static int getScreenRenderingHeight(int display) { }

	// RVA: 0x2ED3FE0 Offset: 0x2ED29E0 VA: 0x182ED3FE0
	internal static int getScreenRenderingWidth(int display) { }

	// RVA: 0x2ED3520 Offset: 0x2ED1F20 VA: 0x182ED3520 Slot: 24
	public override void Repaint(Event e) { }

	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public Func<Vector2, Vector2> get_screenToPanelSpace() { }

	// RVA: 0x2ED43E0 Offset: 0x2ED2DE0 VA: 0x182ED43E0
	public void set_screenToPanelSpace(Func<Vector2, Vector2> value) { }

	// RVA: 0x2ED3900 Offset: 0x2ED2300 VA: 0x182ED3900
	internal Vector2 ScreenToPanel(Vector2 screen) { }

	// RVA: 0x2ED3960 Offset: 0x2ED2360 VA: 0x182ED3960
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = False) { }

	// RVA: 0x2ED30A0 Offset: 0x2ED1AA0 VA: 0x182ED30A0
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	// RVA: 0x2ED3470 Offset: 0x2ED1E70 VA: 0x182ED3470
	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	// RVA: 0x2ED33D0 Offset: 0x2ED1DD0 VA: 0x182ED33D0
	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	// RVA: 0x2ED3C20 Offset: 0x2ED2620 VA: 0x182ED3C20
	private static void .cctor() { }
}
