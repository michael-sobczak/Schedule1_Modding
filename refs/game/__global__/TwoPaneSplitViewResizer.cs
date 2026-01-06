internal class TwoPaneSplitViewResizer : PointerManipulator // TypeDefIndex: 6436
{
	// Fields
	private Vector3 m_Start; // 0x38
	protected bool m_Active; // 0x44
	private TwoPaneSplitView m_SplitView; // 0x48
	private int m_Direction; // 0x50

	// Properties
	private TwoPaneSplitViewOrientation orientation { get; }
	private VisualElement fixedPane { get; }
	private VisualElement flexedPane { get; }
	private float fixedPaneMinDimension { get; }
	private float fixedPaneMargins { get; }
	private float flexedPaneMinDimension { get; }
	private float flexedPaneMargin { get; }

	// Methods

	// RVA: 0x2E800D0 Offset: 0x2E7EAD0 VA: 0x182E800D0
	private TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x2E7FED0 Offset: 0x2E7E8D0 VA: 0x182E7FED0
	private VisualElement get_fixedPane() { }

	// RVA: 0x2E800B0 Offset: 0x2E7EAB0 VA: 0x182E800B0
	private VisualElement get_flexedPane() { }

	// RVA: 0x2E7FE30 Offset: 0x2E7E830 VA: 0x182E7FE30
	private float get_fixedPaneMinDimension() { }

	// RVA: 0x2E7FD10 Offset: 0x2E7E710 VA: 0x182E7FD10
	private float get_fixedPaneMargins() { }

	// RVA: 0x2E80010 Offset: 0x2E7EA10 VA: 0x182E80010
	private float get_flexedPaneMinDimension() { }

	// RVA: 0x2E7FEF0 Offset: 0x2E7E8F0 VA: 0x182E7FEF0
	private float get_flexedPaneMargin() { }

	// RVA: 0x2E7FBF0 Offset: 0x2E7E5F0 VA: 0x182E7FBF0
	public void .ctor(TwoPaneSplitView splitView, int dir) { }

	// RVA: 0x2E7F8D0 Offset: 0x2E7E2D0 VA: 0x182E7F8D0 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2E7FA60 Offset: 0x2E7E460 VA: 0x182E7FA60 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2E7E880 Offset: 0x2E7D280 VA: 0x182E7E880
	public void ApplyDelta(float delta) { }

	// RVA: 0x2E7F3B0 Offset: 0x2E7DDB0 VA: 0x182E7F3B0
	protected void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x2E7F470 Offset: 0x2E7DE70 VA: 0x182E7F470
	protected void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x2E7F820 Offset: 0x2E7E220 VA: 0x182E7F820
	protected void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x2E7F330 Offset: 0x2E7DD30 VA: 0x182E7F330
	protected void InterruptPointerMove(PointerMoveEvent e) { }
}
