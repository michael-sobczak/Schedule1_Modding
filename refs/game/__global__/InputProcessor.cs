public abstract class InputProcessor // TypeDefIndex: 7365
{
	// Fields
	internal static TypeTable s_Processors; // 0x0

	// Properties
	public virtual InputProcessor.CachingPolicy cachingPolicy { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object ProcessAsObject(object value, InputControl control);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Process(void* buffer, int bufferSize, InputControl control);

	// RVA: 0x27A6B80 Offset: 0x27A5580 VA: 0x1827A6B80
	internal static Type GetValueTypeFromType(Type processorType) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual InputProcessor.CachingPolicy get_cachingPolicy() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
