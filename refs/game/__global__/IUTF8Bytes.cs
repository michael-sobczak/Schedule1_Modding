public interface IUTF8Bytes // TypeDefIndex: 15838
{
	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsEmpty();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract byte* GetUnsafePtr();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryResize(int newLength, NativeArrayOptions clearOptions = 1);
}
