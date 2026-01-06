public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 4650
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();
}
