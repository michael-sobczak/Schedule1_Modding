internal class ReaderPositionInfo : PositionInfo // TypeDefIndex: 8077
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Properties
	public override int LineNumber { get; }
	public override int LinePosition { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x250C410 Offset: 0x250AE10 VA: 0x18250C410 Slot: 7
	public override bool HasLineInfo() { }

	// RVA: 0x250C460 Offset: 0x250AE60 VA: 0x18250C460 Slot: 8
	public override int get_LineNumber() { }

	// RVA: 0x250C4B0 Offset: 0x250AEB0 VA: 0x18250C4B0 Slot: 9
	public override int get_LinePosition() { }
}
