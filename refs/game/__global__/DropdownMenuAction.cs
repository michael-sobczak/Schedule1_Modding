public class DropdownMenuAction : DropdownMenuItem // TypeDefIndex: 6488
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DropdownMenuAction.Status <status>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DropdownMenuEventInfo <eventInfo>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private object <userData>k__BackingField; // 0x28
	private readonly Action<DropdownMenuAction> actionCallback; // 0x30
	private readonly Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback; // 0x38

	// Properties
	private DropdownMenuAction.Status status { set; }
	private DropdownMenuEventInfo eventInfo { set; }
	private object userData { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_status(DropdownMenuAction.Status value) { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_userData(object value) { }

	// RVA: 0x2E8ACD0 Offset: 0x2E896D0 VA: 0x182E8ACD0
	public static DropdownMenuAction.Status AlwaysEnabled(DropdownMenuAction a) { }

	// RVA: 0x2E8ACC0 Offset: 0x2E896C0 VA: 0x182E8ACC0
	public static DropdownMenuAction.Status AlwaysDisabled(DropdownMenuAction a) { }

	// RVA: 0x2E8AD30 Offset: 0x2E89730 VA: 0x182E8AD30
	public void .ctor(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x2E8ACE0 Offset: 0x2E896E0 VA: 0x182E8ACE0
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }
}
