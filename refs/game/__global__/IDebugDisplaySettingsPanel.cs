public interface IDebugDisplaySettingsPanel // TypeDefIndex: 13690
{
	// Properties
	public abstract string PanelName { get; }
	public abstract DebugUI.Widget[] Widgets { get; }
	public abstract DebugUI.Flags Flags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_PanelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DebugUI.Widget[] get_Widgets();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DebugUI.Flags get_Flags();
}
