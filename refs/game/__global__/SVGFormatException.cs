internal class SVGFormatException : Exception // TypeDefIndex: 10285
{
	// Properties
	public static SVGFormatException StackError { get; }

	// Methods

	// RVA: 0x46D260 Offset: 0x46BC60 VA: 0x18046D260
	public void .ctor() { }

	// RVA: 0x46D1F0 Offset: 0x46BBF0 VA: 0x18046D1F0
	public void .ctor(string message) { }

	// RVA: 0x46D170 Offset: 0x46BB70 VA: 0x18046D170
	public void .ctor(XmlReader reader, string message) { }

	// RVA: 0x46D2B0 Offset: 0x46BCB0 VA: 0x18046D2B0
	public static SVGFormatException get_StackError() { }

	// RVA: 0x46CFA0 Offset: 0x46B9A0 VA: 0x18046CFA0
	private static string ComposeMessage(XmlReader reader, string message) { }
}
