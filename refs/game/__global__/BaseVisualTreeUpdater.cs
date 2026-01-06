internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable // TypeDefIndex: 7063
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<BaseVisualElementPanel> panelChanged; // 0x10
	private BaseVisualElementPanel m_Panel; // 0x18

	// Properties
	public BaseVisualElementPanel panel { get; set; }
	public VisualElement visualTree { get; }
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2DF9A20 Offset: 0x2DF8420 VA: 0x182DF9A20
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	[CompilerGenerated]
	// RVA: 0x2DF9B00 Offset: 0x2DF8500 VA: 0x182DF9B00
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50 Slot: 9
	public BaseVisualElementPanel get_panel() { }

	// RVA: 0x2DF9BB0 Offset: 0x2DF85B0 VA: 0x182DF9BB0 Slot: 4
	public void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x2DF9AD0 Offset: 0x2DF84D0 VA: 0x182DF9AD0
	public VisualElement get_visualTree() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ProfilerMarker get_profilerMarker();

	// RVA: 0x2DF99B0 Offset: 0x2DF83B0 VA: 0x182DF99B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
