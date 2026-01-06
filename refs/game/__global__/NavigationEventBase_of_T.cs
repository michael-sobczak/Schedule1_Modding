public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent // TypeDefIndex: 6601
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private NavigationDeviceType <deviceType>k__BackingField; // 0x0

	// Properties
	public EventModifiers modifiers { get; set; }
	public bool shiftKey { get; }
	public bool altKey { get; }
	internal NavigationDeviceType deviceType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	|-NavigationEventBase<object>.get_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	|-NavigationEventBase<object>.set_modifiers
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_shiftKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063CB0 Offset: 0x10626B0 VA: 0x181063CB0
	|-NavigationEventBase<object>.get_shiftKey
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool get_altKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063BF0 Offset: 0x10625F0 VA: 0x181063BF0
	|-NavigationEventBase<object>.get_altKey
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal NavigationDeviceType get_deviceType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0
	|-NavigationEventBase<object>.get_deviceType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_deviceType(NavigationDeviceType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1B4A0 Offset: 0xB19EA0 VA: 0x180B1B4A0
	|-NavigationEventBase<object>.set_deviceType
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096F60 Offset: 0x1095960 VA: 0x181096F60
	|-NavigationEventBase<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096ED0 Offset: 0x10958D0 VA: 0x181096ED0
	|-NavigationEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096F20 Offset: 0x1095920 VA: 0x181096F20
	|-NavigationEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(EventModifiers modifiers = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096E00 Offset: 0x1095800 VA: 0x181096E00
	|-NavigationEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096D20 Offset: 0x1095720 VA: 0x181096D20
	|-NavigationEventBase<object>.GetPooled
	*/
}
