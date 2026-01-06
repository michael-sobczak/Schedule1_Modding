public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 17746
{
	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x21902E0 Offset: 0x218ECE0 VA: 0x1821902E0
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2190540 Offset: 0x218EF40 VA: 0x182190540
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x218FDA0 Offset: 0x218E7A0 VA: 0x18218FDA0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x218FBA0 Offset: 0x218E5A0 VA: 0x18218FBA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x218FCE0 Offset: 0x218E6E0 VA: 0x18218FCE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x218FE00 Offset: 0x218E800 VA: 0x18218FE00 Slot: 3
	public override string ToString() { }

	// RVA: 0x2190230 Offset: 0x218EC30 VA: 0x182190230
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x218FF10 Offset: 0x218E910 VA: 0x18218FF10
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }
}
