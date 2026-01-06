internal class Dict<TValue> // TypeDefIndex: 10783
{
	// Fields
	private Dict.LessOrEqual<TValue> _leq; // 0x0
	private Dict.Node<TValue> _head; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dict.LessOrEqual<TValue> leq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7A40 Offset: 0x14E6440 VA: 0x1814E7A40
	|-Dict<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> Insert(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7890 Offset: 0x14E6290 VA: 0x1814E7890
	|-Dict<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> InsertBefore(Dict.Node<TValue> node, TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7760 Offset: 0x14E6160 VA: 0x1814E7760
	|-Dict<object>.InsertBefore
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> Find(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E76F0 Offset: 0x14E60F0 VA: 0x1814E76F0
	|-Dict<object>.Find
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E79D0 Offset: 0x14E63D0 VA: 0x1814E79D0
	|-Dict<object>.Min
	*/

	// RVA: -1 Offset: -1
	public void Remove(Dict.Node<TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E79F0 Offset: 0x14E63F0 VA: 0x1814E79F0
	|-Dict<object>.Remove
	*/
}
