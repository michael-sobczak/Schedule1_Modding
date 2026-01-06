internal abstract class IncrementalReadDecoder // TypeDefIndex: 7932
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
