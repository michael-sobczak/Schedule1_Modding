public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable // TypeDefIndex: 13610
{
	// Fields
	private readonly List<DebugUI.Widget> m_Widgets; // 0x10
	private readonly DisplayInfoAttribute m_DisplayInfo; // 0x18

	// Properties
	public virtual string PanelName { get; }
	public virtual int Order { get; }
	public DebugUI.Widget[] Widgets { get; }
	public virtual DebugUI.Flags Flags { get; }

	// Methods

	// RVA: 0x29E7F10 Offset: 0x29E6910 VA: 0x1829E7F10 Slot: 8
	public virtual string get_PanelName() { }

	// RVA: 0x29E7F00 Offset: 0x29E6900 VA: 0x1829E7F00 Slot: 9
	public virtual int get_Order() { }

	// RVA: 0x29E7F60 Offset: 0x29E6960 VA: 0x1829E7F60 Slot: 5
	public DebugUI.Widget[] get_Widgets() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public virtual DebugUI.Flags get_Flags() { }

	// RVA: 0x29E7CD0 Offset: 0x29E66D0 VA: 0x1829E7CD0
	protected void AddWidget(DebugUI.Widget widget) { }

	// RVA: 0x29E7D80 Offset: 0x29E6780 VA: 0x1829E7D80
	protected void Clear() { }

	// RVA: 0x29E7D80 Offset: 0x29E6780 VA: 0x1829E7D80 Slot: 7
	public void Dispose() { }

	// RVA: 0x29E7DE0 Offset: 0x29E67E0 VA: 0x1829E7DE0
	protected void .ctor() { }
}
