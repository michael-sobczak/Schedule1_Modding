public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 17716
{
	// Fields
	[CompilerGenerated]
	private string <Parameter>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Scheme>k__BackingField; // 0x18

	// Properties
	public string Parameter { get; set; }
	public string Scheme { get; set; }

	// Methods

	// RVA: 0x217E910 Offset: 0x217D310 VA: 0x18217E910
	public void .ctor(string scheme, string parameter) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Parameter() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Parameter(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Scheme() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Scheme(string value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x217E390 Offset: 0x217CD90 VA: 0x18217E390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x217E430 Offset: 0x217CE30 VA: 0x18217E430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217E780 Offset: 0x217D180 VA: 0x18217E780
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x217E860 Offset: 0x217D260 VA: 0x18217E860
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x217E520 Offset: 0x217CF20 VA: 0x18217E520
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x217E4C0 Offset: 0x217CEC0 VA: 0x18217E4C0 Slot: 3
	public override string ToString() { }
}
