public class Authorization // TypeDefIndex: 9960
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x26B6470 Offset: 0x26B4E70 VA: 0x1826B6470
	public void .ctor(string token) { }

	// RVA: 0x26B64F0 Offset: 0x26B4EF0 VA: 0x1826B64F0
	public void .ctor(string token, bool finished) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Message() { }

	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_Complete() { }
}
