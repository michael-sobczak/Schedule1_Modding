internal class DynamicPropertyCollection // TypeDefIndex: 4317
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x1B0E2B0 Offset: 0x1B0CCB0 VA: 0x181B0E2B0
	public bool get_HasProperties() { }

	// RVA: 0x1B0DEC0 Offset: 0x1B0C8C0 VA: 0x181B0DEC0
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1B0E0F0 Offset: 0x1B0CAF0 VA: 0x181B0E0F0
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1B0DA60 Offset: 0x1B0C460 VA: 0x181B0DA60
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1B0D930 Offset: 0x1B0C330 VA: 0x181B0D930
	private int FindProperty(string name) { }

	// RVA: 0x1B0E240 Offset: 0x1B0CC40 VA: 0x181B0E240
	public void .ctor() { }
}
