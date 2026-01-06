internal class ObjectHolderList // TypeDefIndex: 4439
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1B49DD0 Offset: 0x1B487D0 VA: 0x181B49DD0
	internal void .ctor() { }

	// RVA: 0x1B49E30 Offset: 0x1B48830 VA: 0x181B49E30
	internal void .ctor(int startingSize) { }

	// RVA: 0x1B49BE0 Offset: 0x1B485E0 VA: 0x181B49BE0 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x1B49D50 Offset: 0x1B48750 VA: 0x181B49D50
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x1B49CC0 Offset: 0x1B486C0 VA: 0x181B49CC0
	private void EnlargeArray() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Version() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_Count() { }
}
