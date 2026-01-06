public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 4152
{
	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x1AD6B60 Offset: 0x1AD5560 VA: 0x181AD6B60
	internal void .ctor() { }

	// RVA: 0x1AD6BD0 Offset: 0x1AD55D0 VA: 0x181AD6BD0
	public void .ctor(PermissionState state) { }

	// RVA: 0x1AD6AC0 Offset: 0x1AD54C0 VA: 0x181AD6AC0
	internal void .ctor(IPermission perm) { }

	// RVA: 0x1AD5BD0 Offset: 0x1AD45D0 VA: 0x181AD5BD0 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1AD5D70 Offset: 0x1AD4770 VA: 0x181AD5D70 Slot: 12
	public void Demand() { }

	// RVA: 0x1AD5B50 Offset: 0x1AD4550 VA: 0x181AD5B50
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x1AD6150 Offset: 0x1AD4B50 VA: 0x181AD6150 Slot: 9
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1AD61D0 Offset: 0x1AD4BD0 VA: 0x181AD61D0
	public bool IsEmpty() { }

	// RVA: 0x11AB910 Offset: 0x11AA310 VA: 0x1811AB910
	public bool IsUnrestricted() { }

	// RVA: 0x1AD6460 Offset: 0x1AD4E60 VA: 0x181AD6460 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD64A0 Offset: 0x1AD4EA0 VA: 0x181AD64A0 Slot: 13
	public virtual SecurityElement ToXml() { }

	// RVA: 0x1AD6CE0 Offset: 0x1AD56E0 VA: 0x181AD6CE0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x1AD6D10 Offset: 0x1AD5710 VA: 0x181AD6D10 Slot: 15
	public virtual bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 16
	public virtual object get_SyncRoot() { }

	[MonoTODO("may not be required")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisible(False)]
	// RVA: 0x1AD5F80 Offset: 0x1AD4980 VA: 0x181AD5F80 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x1AD6180 Offset: 0x1AD4B80 VA: 0x181AD6180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD6910 Offset: 0x1AD5310 VA: 0x181AD6910
	private static void .cctor() { }
}
