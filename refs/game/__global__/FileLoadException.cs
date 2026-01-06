public class FileLoadException : IOException // TypeDefIndex: 5045
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x1C0BBB0 Offset: 0x1C0A5B0 VA: 0x181C0BBB0
	public void .ctor() { }

	// RVA: 0x1C0BB90 Offset: 0x1C0A590 VA: 0x181C0BB90
	public void .ctor(string message) { }

	// RVA: 0x1C0BC00 Offset: 0x1C0A600 VA: 0x181C0BC00 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_FusionLog() { }

	// RVA: 0x1C0B8D0 Offset: 0x1C0A2D0 VA: 0x181C0B8D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C0BAC0 Offset: 0x1C0A4C0 VA: 0x181C0BAC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0B7B0 Offset: 0x1C0A1B0 VA: 0x181C0B7B0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0B750 Offset: 0x1C0A150 VA: 0x181C0B750
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}
