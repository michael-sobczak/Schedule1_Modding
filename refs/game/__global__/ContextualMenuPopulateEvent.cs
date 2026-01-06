public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent> // TypeDefIndex: 6595
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DropdownMenu <menu>k__BackingField; // 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventBase <triggerEvent>k__BackingField; // 0xC8
	private ContextualMenuManager m_ContextualMenuManager; // 0xD0

	// Properties
	public DropdownMenu menu { get; set; }
	public EventBase triggerEvent { get; set; }

	// Methods

	// RVA: 0x2EA1160 Offset: 0x2E9FB60 VA: 0x182EA1160
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public DropdownMenu get_menu() { }

	[CompilerGenerated]
	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	private void set_menu(DropdownMenu value) { }

	[CompilerGenerated]
	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public EventBase get_triggerEvent() { }

	[CompilerGenerated]
	// RVA: 0x4B6CC0 Offset: 0x4B56C0 VA: 0x1804B6CC0
	private void set_triggerEvent(EventBase value) { }

	// RVA: 0x2EA0BC0 Offset: 0x2E9F5C0 VA: 0x182EA0BC0
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	// RVA: 0x2EA0FD0 Offset: 0x2E9F9D0 VA: 0x182EA0FD0 Slot: 12
	protected override void Init() { }

	// RVA: 0x2EA1020 Offset: 0x2E9FA20 VA: 0x182EA1020
	private void LocalInit() { }

	// RVA: 0x2EA1240 Offset: 0x2E9FC40 VA: 0x182EA1240
	public void .ctor() { }

	// RVA: 0x2EA10B0 Offset: 0x2E9FAB0 VA: 0x182EA10B0 Slot: 9
	protected internal override void PostDispatch(IPanel panel) { }
}
