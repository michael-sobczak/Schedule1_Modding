public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 4300
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x1B1FA90 Offset: 0x1B1E490 VA: 0x181B1FA90
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_ObjectType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_ObjectUri() { }

	// RVA: 0x1B1F990 Offset: 0x1B1E390 VA: 0x181B1F990 Slot: 3
	public override string ToString() { }
}
