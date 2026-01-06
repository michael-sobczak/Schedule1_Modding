public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> // TypeDefIndex: 11325
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly JEnumerable<T> Empty; // 0x0
	private readonly IEnumerable<T> _enumerable; // 0x0

	// Properties
	public IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A4640 Offset: 0x18A3040 VA: 0x1818A4640
	|-JEnumerable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A4300 Offset: 0x18A2D00 VA: 0x1818A4300
	|-JEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A4440 Offset: 0x18A2E40 VA: 0x1818A4440
	|-JEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IJEnumerable<JToken> get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A46A0 Offset: 0x18A30A0 VA: 0x1818A46A0
	|-JEnumerable<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(JEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A42F0 Offset: 0x18A2CF0 VA: 0x1818A42F0
	|-JEnumerable<object>.Equals
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A41B0 Offset: 0x18A2BB0 VA: 0x1818A41B0
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A4420 Offset: 0x18A2E20 VA: 0x1818A4420
	|-JEnumerable<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A44D0 Offset: 0x18A2ED0 VA: 0x1818A44D0
	|-JEnumerable<object>..cctor
	*/
}
