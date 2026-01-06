public class FileNotFoundException : IOException // TypeDefIndex: 5047
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

	// RVA: 0x1C0C070 Offset: 0x1C0AA70 VA: 0x181C0C070
	public void .ctor() { }

	// RVA: 0x1C0C190 Offset: 0x1C0AB90 VA: 0x181C0C190
	public void .ctor(string message) { }

	// RVA: 0x1C0C1B0 Offset: 0x1C0ABB0 VA: 0x181C0C1B0
	public void .ctor(string message, string fileName) { }

	// RVA: 0x1C0C1F0 Offset: 0x1C0ABF0 VA: 0x181C0C1F0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1C0BDB0 Offset: 0x1C0A7B0 VA: 0x181C0BDB0
	private void SetMessageField() { }

	[CompilerGenerated]
	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public string get_FusionLog() { }

	// RVA: 0x1C0BE80 Offset: 0x1C0A880 VA: 0x181C0BE80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C0C0C0 Offset: 0x1C0AAC0 VA: 0x181C0C0C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0BC90 Offset: 0x1C0A690 VA: 0x181C0BC90 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
