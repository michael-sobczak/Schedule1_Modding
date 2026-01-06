public class XmlTypeAttribute : Attribute // TypeDefIndex: 8210
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IncludeInSchema() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Namespace() { }

	// RVA: 0x25730C0 Offset: 0x2571AC0 VA: 0x1825730C0
	public string get_TypeName() { }

	// RVA: 0x2573020 Offset: 0x2571A20 VA: 0x182573020
	internal void AddKeyHash(StringBuilder sb) { }
}
