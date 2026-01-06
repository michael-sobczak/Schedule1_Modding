public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 4270
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x1B03220 Offset: 0x1B01C20 VA: 0x181B03220
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_ApplicationUrl() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Type get_ObjectType() { }

	// RVA: 0x1B03200 Offset: 0x1B01C00 VA: 0x181B03200 Slot: 3
	public override string ToString() { }
}
