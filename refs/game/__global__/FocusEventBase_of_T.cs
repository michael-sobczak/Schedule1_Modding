public abstract class FocusEventBase<T> : EventBase<T> // TypeDefIndex: 6541
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Focusable <relatedTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private FocusChangeDirection <direction>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private FocusController <focusController>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsFocusDelegated>k__BackingField; // 0x0

	// Properties
	public Focusable relatedTarget { get; set; }
	public FocusChangeDirection direction { get; set; }
	protected FocusController focusController { get; set; }
	internal bool IsFocusDelegated { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public Focusable get_relatedTarget() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	|-FocusEventBase<object>.get_relatedTarget
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_relatedTarget(Focusable value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	|-FocusEventBase<object>.set_relatedTarget
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public FocusChangeDirection get_direction() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	|-FocusEventBase<object>.get_direction
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_direction(FocusChangeDirection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	|-FocusEventBase<object>.set_direction
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected FocusController get_focusController() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	|-FocusEventBase<object>.get_focusController
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_focusController(FocusController value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	|-FocusEventBase<object>.set_focusController
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_IsFocusDelegated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	|-FocusEventBase<object>.get_IsFocusDelegated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_IsFocusDelegated(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	|-FocusEventBase<object>.set_IsFocusDelegated
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18020F0 Offset: 0x1800AF0 VA: 0x1818020F0
	|-FocusEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1802140 Offset: 0x1800B40 VA: 0x181802140
	|-FocusEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801F80 Offset: 0x1800980 VA: 0x181801F80
	|-FocusEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1802220 Offset: 0x1800C20 VA: 0x181802220
	|-FocusEventBase<object>..ctor
	*/
}
