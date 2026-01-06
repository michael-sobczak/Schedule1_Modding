public abstract class MarshalByRefObject // TypeDefIndex: 3859
{
	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void .ctor() { }

	// RVA: 0x1CC1410 Offset: 0x1CBFE10 VA: 0x181CC1410
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x1CC1450 Offset: 0x1CBFE50 VA: 0x181CC1450
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x1CC1390 Offset: 0x1CBFD90 VA: 0x181CC1390 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1CC13D0 Offset: 0x1CBFDD0 VA: 0x181CC13D0 Slot: 5
	public virtual object InitializeLifetimeService() { }
}
