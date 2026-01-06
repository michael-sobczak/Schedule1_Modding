public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 3705
{
	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }
	public bool IsError { get; }

	// Methods

	// RVA: 0x1C811E0 Offset: 0x1C7FBE0 VA: 0x181C811E0
	public void .ctor() { }

	// RVA: 0x1C81210 Offset: 0x1C7FC10 VA: 0x181C81210
	public void .ctor(string message) { }

	// RVA: 0x4A5630 Offset: 0x4A4030 VA: 0x1804A5630
	public void .ctor(string message, bool error) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Message() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_IsError() { }
}
