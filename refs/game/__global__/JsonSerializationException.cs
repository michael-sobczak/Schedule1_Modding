public class JsonSerializationException : JsonException // TypeDefIndex: 11011
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

	// RVA: 0x1D14D90 Offset: 0x1D13790 VA: 0x181D14D90
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0x1D14F40 Offset: 0x1D13940 VA: 0x181D14F40
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x1D150F0 Offset: 0x1D13AF0 VA: 0x181D150F0
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}
