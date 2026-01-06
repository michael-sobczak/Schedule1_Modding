public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 11314
{
	// Properties
	public abstract IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IJEnumerable<JToken> get_Item(object key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJEnumerable<object>.get_Item
	*/
}
