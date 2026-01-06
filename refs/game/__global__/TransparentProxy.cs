internal class TransparentProxy // TypeDefIndex: 4304
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x1B1DC40 Offset: 0x1B1C640 VA: 0x181B1DC40
	internal RuntimeType GetProxyType() { }

	// RVA: 0x1B1E4B0 Offset: 0x1B1CEB0 VA: 0x181B1E4B0
	private bool get_IsContextBoundObject() { }

	// RVA: 0x1B1E570 Offset: 0x1B1CF70 VA: 0x181B1E570
	private Context get_TargetContext() { }

	// RVA: 0x1B1DD00 Offset: 0x1B1C700 VA: 0x181B1DD00
	private bool InCurrentContext() { }

	// RVA: 0x1B1DE00 Offset: 0x1B1C800 VA: 0x181B1DE00
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x1B1E150 Offset: 0x1B1CB50 VA: 0x181B1E150
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
