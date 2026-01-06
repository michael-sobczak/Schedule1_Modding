public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 17765
{
	// Fields
	[CompilerGenerated]
	private Nullable<double> <Quality>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x20

	// Properties
	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Nullable<double> get_Quality() { }

	[CompilerGenerated]
	// RVA: 0x49CD50 Offset: 0x49B750 VA: 0x18049CD50
	private void set_Quality(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_Value(string value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2193EE0 Offset: 0x21928E0 VA: 0x182193EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2193FD0 Offset: 0x21929D0 VA: 0x182193FD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2194580 Offset: 0x2192F80 VA: 0x182194580
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x2194150 Offset: 0x2192B50 VA: 0x182194150
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x2194060 Offset: 0x2192A60 VA: 0x182194060 Slot: 3
	public override string ToString() { }
}
