internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 19083
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Properties
	public string Name { set; }
	public StaticAccessorType Type { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_Type(StaticAccessorType value) { }

	[VisibleToOtherModules]
	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	internal void .ctor(string name) { }

	// RVA: 0x1B60630 Offset: 0x1B5F030 VA: 0x181B60630
	public void .ctor(string name, StaticAccessorType type) { }
}
