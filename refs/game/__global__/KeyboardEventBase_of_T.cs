public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent // TypeDefIndex: 6558
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventModifiers <modifiers>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private char <character>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private KeyCode <keyCode>k__BackingField; // 0x0

	// Properties
	public EventModifiers modifiers { get; set; }
	public char character { get; set; }
	public KeyCode keyCode { get; set; }
	public bool shiftKey { get; }
	public bool ctrlKey { get; }
	public bool commandKey { get; }
	public bool altKey { get; }
	internal bool functionKey { get; }
	public bool actionKey { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public EventModifiers get_modifiers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	|-KeyboardEventBase<object>.get_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_modifiers(EventModifiers value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063DF0 Offset: 0x10627F0 VA: 0x181063DF0
	|-KeyboardEventBase<object>.set_modifiers
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public char get_character() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD9B0 Offset: 0x18CC3B0 VA: 0x1818CD9B0
	|-KeyboardEventBase<object>.get_character
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_character(char value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD9D0 Offset: 0x18CC3D0 VA: 0x1818CD9D0
	|-KeyboardEventBase<object>.set_character
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public KeyCode get_keyCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	|-KeyboardEventBase<object>.get_keyCode
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_keyCode(KeyCode value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	|-KeyboardEventBase<object>.set_keyCode
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool get_shiftKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063CB0 Offset: 0x10626B0 VA: 0x181063CB0
	|-KeyboardEventBase<object>.get_shiftKey
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool get_ctrlKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C10 Offset: 0x1062610 VA: 0x181063C10
	|-KeyboardEventBase<object>.get_ctrlKey
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool get_commandKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063C00 Offset: 0x1062600 VA: 0x181063C00
	|-KeyboardEventBase<object>.get_commandKey
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool get_altKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063BF0 Offset: 0x10625F0 VA: 0x181063BF0
	|-KeyboardEventBase<object>.get_altKey
	*/

	// RVA: -1 Offset: -1
	internal bool get_functionKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD9C0 Offset: 0x18CC3C0 VA: 0x1818CD9C0
	|-KeyboardEventBase<object>.get_functionKey
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public bool get_actionKey() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD920 Offset: 0x18CC320 VA: 0x1818CD920
	|-KeyboardEventBase<object>.get_actionKey
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD810 Offset: 0x18CC210 VA: 0x1818CD810
	|-KeyboardEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD860 Offset: 0x18CC260 VA: 0x1818CD860
	|-KeyboardEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD6E0 Offset: 0x18CC0E0 VA: 0x1818CD6E0
	|-KeyboardEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CD890 Offset: 0x18CC290 VA: 0x1818CD890
	|-KeyboardEventBase<object>..ctor
	*/
}
