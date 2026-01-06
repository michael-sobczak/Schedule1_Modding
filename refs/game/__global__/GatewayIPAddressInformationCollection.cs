public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>, IEnumerable // TypeDefIndex: 10124
{
	// Fields
	private Collection<GatewayIPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }

	// Methods

	// RVA: 0x25C13A0 Offset: 0x25BFDA0 VA: 0x1825C13A0
	protected internal void .ctor() { }

	// RVA: 0x25C1220 Offset: 0x25BFC20 VA: 0x1825C1220 Slot: 13
	public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset) { }

	// RVA: 0x25C1420 Offset: 0x25BFE20 VA: 0x1825C1420 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x25C1100 Offset: 0x25BFB00 VA: 0x1825C1100 Slot: 16
	public virtual void Add(GatewayIPAddressInformation address) { }

	// RVA: 0x25C12E0 Offset: 0x25BFCE0 VA: 0x1825C12E0
	internal void InternalAdd(GatewayIPAddressInformation address) { }

	// RVA: 0x25C11C0 Offset: 0x25BFBC0 VA: 0x1825C11C0 Slot: 17
	public virtual bool Contains(GatewayIPAddressInformation address) { }

	// RVA: 0x25C1290 Offset: 0x25BFC90 VA: 0x1825C1290 Slot: 18
	public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator() { }

	// RVA: 0xB1E170 Offset: 0xB1CB70 VA: 0x180B1E170 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x25C1340 Offset: 0x25BFD40 VA: 0x1825C1340 Slot: 19
	public virtual bool Remove(GatewayIPAddressInformation address) { }

	// RVA: 0x25C1160 Offset: 0x25BFB60 VA: 0x1825C1160 Slot: 20
	public virtual void Clear() { }
}
