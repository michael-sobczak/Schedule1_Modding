public class JsonSchemaException : JsonException // TypeDefIndex: 11286
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x94
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public int get_LineNumber() { }

	[CompilerGenerated]
	// RVA: 0x1D0F570 Offset: 0x1D0DF70 VA: 0x181D0F570
	public int get_LinePosition() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_Path() { }

	// RVA: 0x1D6BDB0 Offset: 0x1D6A7B0 VA: 0x181D6BDB0
	public void .ctor() { }

	// RVA: 0x1D6BDC0 Offset: 0x1D6A7C0 VA: 0x181D6BDC0
	public void .ctor(string message) { }

	// RVA: 0x1D6BD60 Offset: 0x1D6A760 VA: 0x181D6BD60
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D6BD40 Offset: 0x1D6A740 VA: 0x181D6BD40
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D9CAA0 Offset: 0x1D9B4A0 VA: 0x181D9CAA0
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }
}
