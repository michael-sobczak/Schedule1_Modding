internal class NativeMethodAttribute : Attribute // TypeDefIndex: 19072
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsThreadSafe>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsFreeFunction>k__BackingField; // 0x19
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Properties
	public string Name { set; }
	public bool IsThreadSafe { set; }
	public bool IsFreeFunction { set; }
	public bool ThrowsException { set; }
	public bool HasExplicitThis { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 7
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000 Slot: 8
	public void set_IsThreadSafe(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0 Slot: 9
	public void set_IsFreeFunction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1DFCEE0 Offset: 0x1DFB8E0 VA: 0x181DFCEE0 Slot: 10
	public void set_ThrowsException(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2853E90 Offset: 0x2852890 VA: 0x182853E90 Slot: 11
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x2D43420 Offset: 0x2D41E20 VA: 0x182D43420
	public void .ctor(string name) { }

	// RVA: 0x2D43530 Offset: 0x2D41F30 VA: 0x182D43530
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x2D433E0 Offset: 0x2D41DE0 VA: 0x182D433E0
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }
}
