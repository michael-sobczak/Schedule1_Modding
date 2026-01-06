public class JsonReaderException : JsonException // TypeDefIndex: 11009
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x94
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x98

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	[Nullable(2)]
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public int get_LineNumber() { }

	[CompilerGenerated]
	// RVA: 0x1D0F570 Offset: 0x1D0DF70 VA: 0x181D0F570
	public int get_LinePosition() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_Path() { }

	// RVA: 0x1D0DC80 Offset: 0x1D0C680 VA: 0x181D0DC80
	public void .ctor() { }

	// RVA: 0x1D0DCD0 Offset: 0x1D0C6D0 VA: 0x181D0DCD0
	public void .ctor(string message) { }

	// RVA: 0x1D0DD30 Offset: 0x1D0C730 VA: 0x181D0DD30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D0DDA0 Offset: 0x1D0C7A0 VA: 0x181D0DDA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D0F4D0 Offset: 0x1D0DED0 VA: 0x181D0F4D0
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x1D0F4C0 Offset: 0x1D0DEC0 VA: 0x181D0F4C0
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0x1D0F310 Offset: 0x1D0DD10 VA: 0x181D0F310
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x1D0F1B0 Offset: 0x1D0DBB0 VA: 0x181D0F1B0
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}
