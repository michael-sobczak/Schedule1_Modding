public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent // TypeDefIndex: 6512
{
	// Fields
	private string m_CommandName; // 0x0

	// Properties
	public string commandName { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 15
	public string get_commandName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D550 Offset: 0x144BF50 VA: 0x18144D550
	|-CommandEventBase<object>.get_commandName
	*/

	// RVA: -1 Offset: -1
	protected void set_commandName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	|-CommandEventBase<object>.set_commandName
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D430 Offset: 0x144BE30 VA: 0x18144D430
	|-CommandEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D480 Offset: 0x144BE80 VA: 0x18144D480
	|-CommandEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D380 Offset: 0x144BD80 VA: 0x18144D380
	|-CommandEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(string commandName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D2B0 Offset: 0x144BCB0 VA: 0x18144D2B0
	|-CommandEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D4C0 Offset: 0x144BEC0 VA: 0x18144D4C0
	|-CommandEventBase<object>..ctor
	*/
}
