internal class UIRRepaintUpdater : BaseVisualTreeUpdater // TypeDefIndex: 6755
{
	// Fields
	private BaseVisualElementPanel attachedPanel; // 0x20
	internal RenderChain renderChain; // 0x28
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawStats>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <breakBatches>k__BackingField; // 0x31
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x32

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	public bool drawStats { get; }
	public bool breakBatches { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2EE6680 Offset: 0x2EE5080 VA: 0x182EE6680
	public void .ctor() { }

	// RVA: 0x2EE6700 Offset: 0x2EE5100 VA: 0x182EE6700 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_drawStats() { }

	[CompilerGenerated]
	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_breakBatches() { }

	// RVA: 0x2EE6210 Offset: 0x2EE4C10 VA: 0x182EE6210 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2EE6420 Offset: 0x2EE4E20 VA: 0x182EE6420 Slot: 12
	public override void Update() { }

	// RVA: 0x2EE5610 Offset: 0x2EE4010 VA: 0x182EE5610 Slot: 14
	protected virtual RenderChain CreateRenderChain() { }

	// RVA: 0x2EE6570 Offset: 0x2EE4F70 VA: 0x182EE6570
	private static void .cctor() { }

	// RVA: 0x2EE5C70 Offset: 0x2EE4670 VA: 0x182EE5C70
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x2EE5E60 Offset: 0x2EE4860 VA: 0x182EE5E60
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	// RVA: 0x2EE5430 Offset: 0x2EE3E30 VA: 0x182EE5430
	private void AttachToPanel() { }

	// RVA: 0x2EE56F0 Offset: 0x2EE40F0 VA: 0x182EE56F0
	private void DetachFromPanel() { }

	// RVA: 0x2EE58C0 Offset: 0x2EE42C0 VA: 0x182EE58C0
	private void InitRenderChain() { }

	// RVA: 0x2EE5680 Offset: 0x2EE4080 VA: 0x182EE5680
	internal void DestroyRenderChain() { }

	// RVA: 0x2EE5680 Offset: 0x2EE4080 VA: 0x182EE5680
	private void OnPanelAtlasChanged() { }

	// RVA: 0x2EE5E80 Offset: 0x2EE4880 VA: 0x182EE5E80
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x2EE5EF0 Offset: 0x2EE48F0 VA: 0x182EE5EF0
	private void OnPanelStandardShaderChanged() { }

	// RVA: 0x2EE6080 Offset: 0x2EE4A80 VA: 0x182EE6080
	private void OnPanelStandardWorldSpaceShaderChanged() { }

	// RVA: 0x2EE6370 Offset: 0x2EE4D70 VA: 0x182EE6370
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x231C770 Offset: 0x231B170 VA: 0x18231C770
	private void set_disposed(bool value) { }

	// RVA: 0x2EE5890 Offset: 0x2EE4290 VA: 0x182EE5890 Slot: 11
	protected override void Dispose(bool disposing) { }
}
