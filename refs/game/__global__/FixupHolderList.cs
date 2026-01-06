internal class FixupHolderList // TypeDefIndex: 4437
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x1B492F0 Offset: 0x1B47CF0 VA: 0x181B492F0
	internal void .ctor() { }

	// RVA: 0x1B49280 Offset: 0x1B47C80 VA: 0x181B49280
	internal void .ctor(int startingSize) { }

	// RVA: 0x1B490E0 Offset: 0x1B47AE0 VA: 0x181B490E0 Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x1B491F0 Offset: 0x1B47BF0 VA: 0x181B491F0
	private void EnlargeArray() { }
}
