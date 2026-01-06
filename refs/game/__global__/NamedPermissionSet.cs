public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 4151
{
	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x1AD2090 Offset: 0x1AD0A90 VA: 0x181AD2090
	internal void .ctor() { }

	// RVA: 0x1AD2130 Offset: 0x1AD0B30 VA: 0x181AD2130
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x1AD2080 Offset: 0x1AD0A80 VA: 0x181AD2080
	public void .ctor(string name) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Name() { }

	// RVA: 0x1AD2330 Offset: 0x1AD0D30 VA: 0x181AD2330
	public void set_Name(string value) { }

	// RVA: 0x1AD1FE0 Offset: 0x1AD09E0 VA: 0x181AD1FE0 Slot: 13
	public override SecurityElement ToXml() { }

	[ComVisible(False)]
	// RVA: 0x1AD1EE0 Offset: 0x1AD08E0 VA: 0x181AD1EE0 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x1AD1F60 Offset: 0x1AD0960 VA: 0x181AD1F60 Slot: 2
	public override int GetHashCode() { }
}
