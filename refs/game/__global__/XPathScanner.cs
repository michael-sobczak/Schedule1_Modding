internal sealed class XPathScanner // TypeDefIndex: 8602
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private XPathScanner.LexKind _kind; // 0x1C
	private char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurrentChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x24C0230 Offset: 0x24BEC30 VA: 0x1824C0230
	public void .ctor(string xpathExpr) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_SourceText() { }

	// RVA: 0xCC4E70 Offset: 0xCC3870 VA: 0x180CC4E70
	private char get_CurrentChar() { }

	// RVA: 0x24BF650 Offset: 0x24BE050 VA: 0x1824BF650
	private bool NextChar() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Name() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Prefix() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_StringValue() { }

	// RVA: 0xCDF810 Offset: 0xCDE210 VA: 0x180CDF810
	public double get_NumberValue() { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_CanBeFunction() { }

	// RVA: 0x24C01C0 Offset: 0x24BEBC0 VA: 0x1824C01C0
	private void SkipSpace() { }

	// RVA: 0x24BF6B0 Offset: 0x24BE0B0 VA: 0x1824BF6B0
	public bool NextLex() { }

	// RVA: 0x24BFF00 Offset: 0x24BE900 VA: 0x1824BFF00
	private double ScanNumber() { }

	// RVA: 0x24BFD50 Offset: 0x24BE750 VA: 0x1824BFD50
	private double ScanFraction() { }

	// RVA: 0x24C0080 Offset: 0x24BEA80 VA: 0x1824C0080
	private string ScanString() { }

	// RVA: 0x24BFE40 Offset: 0x24BE840 VA: 0x1824BFE40
	private string ScanName() { }
}
