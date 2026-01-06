public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 8062
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x1CBDE10 Offset: 0x1CBC810 VA: 0x181CBDE10 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
