public class XPathException : SystemException // TypeDefIndex: 8130
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x252C770 Offset: 0x252B170 VA: 0x18252C770
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x252C4E0 Offset: 0x252AEE0 VA: 0x18252C4E0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x252C6A0 Offset: 0x252B0A0 VA: 0x18252C6A0
	public void .ctor() { }

	// RVA: 0x252C5E0 Offset: 0x252AFE0 VA: 0x18252C5E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x252C210 Offset: 0x252AC10 VA: 0x18252C210
	internal static XPathException Create(string res) { }

	// RVA: 0x252C270 Offset: 0x252AC70 VA: 0x18252C270
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x252C330 Offset: 0x252AD30 VA: 0x18252C330
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x252C410 Offset: 0x252AE10 VA: 0x18252C410
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x252C5C0 Offset: 0x252AFC0 VA: 0x18252C5C0
	private void .ctor(string res, string[] args) { }

	// RVA: 0x252CA50 Offset: 0x252B450 VA: 0x18252CA50
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x252C160 Offset: 0x252AB60 VA: 0x18252C160
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x252CAE0 Offset: 0x252B4E0 VA: 0x18252CAE0 Slot: 5
	public override string get_Message() { }
}
