public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal // TypeDefIndex: 6498
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IEventHandler <relatedTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <pointerId>k__BackingField; // 0x0

	// Properties
	private IEventHandler relatedTarget { set; }
	public int pointerId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_relatedTarget(IEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	|-PointerCaptureEventBase<object>.set_relatedTarget
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public int get_pointerId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	|-PointerCaptureEventBase<object>.get_pointerId
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_pointerId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	|-PointerCaptureEventBase<object>.set_pointerId
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6530 Offset: 0x10F4F30 VA: 0x1810F6530
	|-PointerCaptureEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F65D0 Offset: 0x10F4FD0 VA: 0x1810F65D0
	|-PointerCaptureEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6420 Offset: 0x10F4E20 VA: 0x1810F6420
	|-PointerCaptureEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6660 Offset: 0x10F5060 VA: 0x1810F6660
	|-PointerCaptureEventBase<object>..ctor
	*/
}
