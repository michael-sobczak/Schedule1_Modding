public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 8187
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string methodName) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_MethodName() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsAny() { }

	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	public void set_IsAny(bool value) { }
}
