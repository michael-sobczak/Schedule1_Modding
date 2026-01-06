internal interface ISerializableJsonDictionary // TypeDefIndex: 6697
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Set<T>(string key, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISerializableJsonDictionary.Set<object>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T Get<T>(string key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISerializableJsonDictionary.Get<object>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Overwrite(object obj, string key);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ContainsKey(string key);
}
