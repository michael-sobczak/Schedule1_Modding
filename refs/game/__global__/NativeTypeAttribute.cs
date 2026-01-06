internal class NativeTypeAttribute : Attribute // TypeDefIndex: 19077
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 7
	public void set_Header(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490 Slot: 8
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x2D438B0 Offset: 0x2D422B0 VA: 0x182D438B0
	public void .ctor() { }

	// RVA: 0x2D43840 Offset: 0x2D42240 VA: 0x182D43840
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x2D43720 Offset: 0x2D42120 VA: 0x182D43720
	public void .ctor(string header) { }

	// RVA: 0x2D43870 Offset: 0x2D42270 VA: 0x182D43870
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}
