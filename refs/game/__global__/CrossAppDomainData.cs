internal class CrossAppDomainData // TypeDefIndex: 4332
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x1B2D740 Offset: 0x1B2C140 VA: 0x181B2D740
	internal void .ctor(int domainId) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	internal int get_DomainID() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_ProcessID() { }
}
