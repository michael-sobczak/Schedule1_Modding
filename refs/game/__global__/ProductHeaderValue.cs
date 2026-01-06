public class ProductHeaderValue : ICloneable // TypeDefIndex: 17759
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Version(string value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2190860 Offset: 0x218F260 VA: 0x182190860 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2190910 Offset: 0x218F310 VA: 0x182190910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2190C90 Offset: 0x218F690 VA: 0x182190C90
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x21909F0 Offset: 0x218F3F0 VA: 0x1821909F0
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x2190990 Offset: 0x218F390 VA: 0x182190990 Slot: 3
	public override string ToString() { }
}
