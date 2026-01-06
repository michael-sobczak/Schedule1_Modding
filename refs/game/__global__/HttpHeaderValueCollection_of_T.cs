public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 17732
{
	// Fields
	private readonly List<T> list; // 0x0
	private readonly HttpHeaders headers; // 0x0
	private readonly HeaderInfo headerInfo; // 0x0
	private List<string> invalidValues; // 0x0

	// Properties
	public int Count { get; }
	internal List<string> InvalidValues { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850C00 Offset: 0x184F600 VA: 0x181850C00
	|-HttpHeaderValueCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-HttpHeaderValueCollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	internal List<string> get_InvalidValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-HttpHeaderValueCollection<object>.get_InvalidValues
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-HttpHeaderValueCollection<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C27C0 Offset: 0x11C11C0 VA: 0x1811C27C0
	|-HttpHeaderValueCollection<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void AddRange(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850910 Offset: 0x184F310 VA: 0x181850910
	|-HttpHeaderValueCollection<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	internal void AddInvalidValue(string invalidValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850810 Offset: 0x184F210 VA: 0x181850810
	|-HttpHeaderValueCollection<object>.AddInvalidValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850940 Offset: 0x184F340 VA: 0x181850940
	|-HttpHeaderValueCollection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18509A0 Offset: 0x184F3A0 VA: 0x1818509A0
	|-HttpHeaderValueCollection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18509D0 Offset: 0x184F3D0 VA: 0x1818509D0
	|-HttpHeaderValueCollection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850AA0 Offset: 0x184F4A0 VA: 0x181850AA0
	|-HttpHeaderValueCollection<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850B50 Offset: 0x184F550 VA: 0x181850B50
	|-HttpHeaderValueCollection<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850A30 Offset: 0x184F430 VA: 0x181850A30
	|-HttpHeaderValueCollection<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850AD0 Offset: 0x184F4D0 VA: 0x181850AD0
	|-HttpHeaderValueCollection<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal T Find(Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850A00 Offset: 0x184F400 VA: 0x181850A00
	|-HttpHeaderValueCollection<object>.Find
	*/
}
