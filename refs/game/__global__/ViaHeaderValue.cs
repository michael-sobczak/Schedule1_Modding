public class ViaHeaderValue : ICloneable // TypeDefIndex: 17768
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <ProtocolName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ProtocolVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ReceivedBy>k__BackingField; // 0x28

	// Properties
	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_ProtocolName() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_ProtocolName(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ProtocolVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_ReceivedBy() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_ReceivedBy(string value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x21990A0 Offset: 0x2197AA0 VA: 0x1821990A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2199180 Offset: 0x2197B80 VA: 0x182199180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2199850 Offset: 0x2198250 VA: 0x182199850
	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	// RVA: 0x21993E0 Offset: 0x2197DE0 VA: 0x1821993E0
	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	// RVA: 0x2199290 Offset: 0x2197C90 VA: 0x182199290 Slot: 3
	public override string ToString() { }
}
