internal class RTFException : ApplicationException // TypeDefIndex: 5213
{
	// Fields
	private int pos; // 0x90
	private int line; // 0x94
	private TokenClass token_class; // 0x98
	private Major major; // 0x9C
	private Minor minor; // 0xA0
	private int param; // 0xA4
	private string text; // 0xA8
	private string error_message; // 0xB0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x21D2C20 Offset: 0x21D1620 VA: 0x1821D2C20
	public void .ctor(RTF rtf, string error_message) { }

	// RVA: 0x21D2CD0 Offset: 0x21D16D0 VA: 0x1821D2CD0 Slot: 5
	public override string get_Message() { }
}
