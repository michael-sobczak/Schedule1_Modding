public class JsonWriterException : JsonException // TypeDefIndex: 11092
{
	// Fields
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; // 0x90

	// Properties
	[Nullable(2)]
	public string Path { get; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_Path() { }

	// RVA: 0x1D6BDB0 Offset: 0x1D6A7B0 VA: 0x181D6BDB0
	public void .ctor() { }

	// RVA: 0x1D6BDC0 Offset: 0x1D6A7C0 VA: 0x181D6BDC0
	public void .ctor(string message) { }

	// RVA: 0x1D6BD60 Offset: 0x1D6A760 VA: 0x181D6BD60
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D6BD40 Offset: 0x1D6A740 VA: 0x181D6BD40
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D6BD70 Offset: 0x1D6A770 VA: 0x181D6BD70
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0x1D6BC60 Offset: 0x1D6A660 VA: 0x181D6BC60
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0x1D6BBA0 Offset: 0x1D6A5A0 VA: 0x181D6BBA0
	internal static JsonWriterException Create(string path, string message, Exception ex) { }
}
