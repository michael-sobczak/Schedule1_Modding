public class WarningHeaderValue : ICloneable // TypeDefIndex: 17769
{
	// Fields
	[CompilerGenerated]
	private string <Agent>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Code>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x38

	// Properties
	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Agent() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Agent(string value) { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Code() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	private void set_Code(int value) { }

	[CompilerGenerated]
	// RVA: 0x49CB90 Offset: 0x49B590 VA: 0x18049CB90
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGenerated]
	// RVA: 0x49CBC0 Offset: 0x49B5C0 VA: 0x18049CBC0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_Text(string value) { }

	// RVA: 0x2199B60 Offset: 0x2198560 VA: 0x182199B60
	private static bool IsCodeValid(int code) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2199900 Offset: 0x2198300 VA: 0x182199900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2199A70 Offset: 0x2198470 VA: 0x182199A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x219A330 Offset: 0x2198D30 VA: 0x18219A330
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x2199DD0 Offset: 0x21987D0 VA: 0x182199DD0
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x2199B80 Offset: 0x2198580 VA: 0x182199B80 Slot: 3
	public override string ToString() { }
}
