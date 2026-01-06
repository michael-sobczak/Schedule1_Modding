internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 11225
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0x1D7E600 Offset: 0x1D7D000 VA: 0x181D7E600
	private BidirectionalDictionary<string, object> GetMappings(object context) { }

	// RVA: 0x1D7E870 Offset: 0x1D7D270 VA: 0x181D7E870 Slot: 4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0x1D7E700 Offset: 0x1D7D100 VA: 0x181D7E700 Slot: 5
	public string GetReference(object context, object value) { }

	// RVA: 0x1D7E580 Offset: 0x1D7CF80 VA: 0x181D7E580 Slot: 7
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0x1D7E7F0 Offset: 0x1D7D1F0 VA: 0x181D7E7F0 Slot: 6
	public bool IsReferenced(object context, object value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
