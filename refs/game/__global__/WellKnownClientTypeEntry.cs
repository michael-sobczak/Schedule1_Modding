public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 4298
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x1B1F820 Offset: 0x1B1E220 VA: 0x181B1F820
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_ApplicationUrl() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_ObjectType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_ObjectUrl() { }

	// RVA: 0x1B1F7E0 Offset: 0x1B1E1E0 VA: 0x181B1F7E0 Slot: 3
	public override string ToString() { }
}
