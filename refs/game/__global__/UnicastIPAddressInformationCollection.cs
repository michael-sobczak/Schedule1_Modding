public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>, IEnumerable // TypeDefIndex: 10137
{
	// Fields
	private Collection<UnicastIPAddressInformation> addresses; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }

	// Methods

	// RVA: 0x25D00B0 Offset: 0x25CEAB0 VA: 0x1825D00B0
	protected internal void .ctor() { }

	// RVA: 0x25CFF30 Offset: 0x25CE930 VA: 0x1825CFF30 Slot: 13
	public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset) { }

	// RVA: 0x25D0130 Offset: 0x25CEB30 VA: 0x1825D0130 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 15
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x25CFE10 Offset: 0x25CE810 VA: 0x1825CFE10 Slot: 16
	public virtual void Add(UnicastIPAddressInformation address) { }

	// RVA: 0x25CFFF0 Offset: 0x25CE9F0 VA: 0x1825CFFF0
	internal void InternalAdd(UnicastIPAddressInformation address) { }

	// RVA: 0x25CFED0 Offset: 0x25CE8D0 VA: 0x1825CFED0 Slot: 17
	public virtual bool Contains(UnicastIPAddressInformation address) { }

	// RVA: 0xB1E170 Offset: 0xB1CB70 VA: 0x180B1E170 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x25CFFA0 Offset: 0x25CE9A0 VA: 0x1825CFFA0 Slot: 18
	public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator() { }

	// RVA: 0x25D0050 Offset: 0x25CEA50 VA: 0x1825D0050 Slot: 19
	public virtual bool Remove(UnicastIPAddressInformation address) { }

	// RVA: 0x25CFE70 Offset: 0x25CE870 VA: 0x1825CFE70 Slot: 20
	public virtual void Clear() { }
}
