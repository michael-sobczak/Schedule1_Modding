public class ValidationEventArgs : EventArgs // TypeDefIndex: 11301
{
	// Fields
	private readonly JsonSchemaException _ex; // 0x10

	// Properties
	public JsonSchemaException Exception { get; }
	public string Path { get; }
	public string Message { get; }

	// Methods

	// RVA: 0x1DB2B70 Offset: 0x1DB1570 VA: 0x181DB2B70
	internal void .ctor(JsonSchemaException ex) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public JsonSchemaException get_Exception() { }

	// RVA: 0x1DB2C30 Offset: 0x1DB1630 VA: 0x181DB2C30
	public string get_Path() { }

	// RVA: 0x1DB2C00 Offset: 0x1DB1600 VA: 0x181DB2C00
	public string get_Message() { }
}
