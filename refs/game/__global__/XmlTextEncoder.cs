internal class XmlTextEncoder // TypeDefIndex: 7967
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0x24D3C30 Offset: 0x24D2630 VA: 0x1824D3C30
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x24D3CF0 Offset: 0x24D26F0 VA: 0x1824D3CF0
	internal void set_QuoteChar(char value) { }

	// RVA: 0x24D2610 Offset: 0x24D1010 VA: 0x1824D2610
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x24D25D0 Offset: 0x24D0FD0 VA: 0x1824D25D0
	internal void EndAttribute() { }

	// RVA: 0x24D3C80 Offset: 0x24D2680 VA: 0x1824D3C80
	internal string get_AttributeValue() { }

	// RVA: 0x24D3020 Offset: 0x24D1A20 VA: 0x1824D3020
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0x24D3640 Offset: 0x24D2040 VA: 0x1824D3640
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0x24D2E90 Offset: 0x24D1890 VA: 0x1824D2E90
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24D30F0 Offset: 0x24D1AF0 VA: 0x1824D30F0
	internal void Write(string text) { }

	// RVA: 0x24D2A00 Offset: 0x24D1400 VA: 0x1824D2A00
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x24D2C20 Offset: 0x24D1620 VA: 0x1824D2C20
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0x24D27B0 Offset: 0x24D11B0 VA: 0x1824D27B0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x24D2980 Offset: 0x24D1380 VA: 0x1824D2980
	internal void WriteEntityRef(string name) { }

	// RVA: 0x24D2DE0 Offset: 0x24D17E0 VA: 0x1824D2DE0
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0x24D26A0 Offset: 0x24D10A0 VA: 0x1824D26A0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0x24D2710 Offset: 0x24D1110 VA: 0x1824D2710
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x24D28F0 Offset: 0x24D12F0 VA: 0x1824D28F0
	private void WriteEntityRefImpl(string name) { }
}
