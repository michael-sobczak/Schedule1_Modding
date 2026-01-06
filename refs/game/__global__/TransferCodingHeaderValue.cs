public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 17766
{
	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2194EC0 Offset: 0x21938C0 VA: 0x182194EC0
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2195150 Offset: 0x2193B50 VA: 0x182195150
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Value() { }

	// RVA: 0x2194B60 Offset: 0x2193560 VA: 0x182194B60 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2194A20 Offset: 0x2193420 VA: 0x182194A20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2194AD0 Offset: 0x21934D0 VA: 0x182194AD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2194BC0 Offset: 0x21935C0 VA: 0x182194BC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2194E10 Offset: 0x2193810 VA: 0x182194E10
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x2194C20 Offset: 0x2193620 VA: 0x182194C20
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }
}
