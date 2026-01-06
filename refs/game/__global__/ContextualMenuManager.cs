public abstract class ContextualMenuManager // TypeDefIndex: 6208
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <displayMenuHandledOSX>k__BackingField; // 0x10

	// Properties
	internal bool displayMenuHandledOSX { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	internal bool get_displayMenuHandledOSX() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	internal void set_displayMenuHandledOSX(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);

	// RVA: 0x2DB5F50 Offset: 0x2DB4950 VA: 0x182DB5F50
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
