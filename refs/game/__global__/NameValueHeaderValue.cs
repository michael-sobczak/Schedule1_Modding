public class NameValueHeaderValue : ICloneable // TypeDefIndex: 17745
{
	// Fields
	internal string value; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x218F970 Offset: 0x218E370 VA: 0x18218F970
	public void .ctor(string name, string value) { }

	// RVA: 0x218F920 Offset: 0x218E320 VA: 0x18218F920
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_Name(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Value() { }

	// RVA: 0x218F9D0 Offset: 0x218E3D0 VA: 0x18218F9D0
	public void set_Value(string value) { }

	// RVA: 0x218EF70 Offset: 0x218D970 VA: 0x18218EF70
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x218F0D0 Offset: 0x218DAD0 VA: 0x18218F0D0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x217E430 Offset: 0x217CE30 VA: 0x18217E430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x218F000 Offset: 0x218DA00 VA: 0x18218F000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x218F870 Offset: 0x218E270 VA: 0x18218F870
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x218F470 Offset: 0x218DE70 VA: 0x18218F470
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x218F150 Offset: 0x218DB50 VA: 0x18218F150 Slot: 3
	public override string ToString() { }

	// RVA: 0x218F1B0 Offset: 0x218DBB0 VA: 0x18218F1B0
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }
}
