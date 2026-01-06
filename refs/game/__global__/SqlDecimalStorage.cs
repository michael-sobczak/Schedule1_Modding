internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 13056
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x211F650 Offset: 0x211E050 VA: 0x18211F650
	public void .ctor(DataColumn column) { }

	// RVA: 0x211DE60 Offset: 0x211C860 VA: 0x18211DE60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x211ECE0 Offset: 0x211D6E0 VA: 0x18211ECE0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x211EC10 Offset: 0x211D610 VA: 0x18211EC10 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x211EF50 Offset: 0x211D950 VA: 0x18211EF50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x211F2F0 Offset: 0x211DCF0 VA: 0x18211F2F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x211F380 Offset: 0x211DD80 VA: 0x18211F380 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x211F400 Offset: 0x211DE00 VA: 0x18211F400 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x211F5F0 Offset: 0x211DFF0 VA: 0x18211F5F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x211F480 Offset: 0x211DE80 VA: 0x18211F480 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x211EFD0 Offset: 0x211D9D0 VA: 0x18211EFD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x211EDA0 Offset: 0x211D7A0 VA: 0x18211EDA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x211F340 Offset: 0x211DD40 VA: 0x18211F340 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x211F1C0 Offset: 0x211DBC0 VA: 0x18211F1C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x211F550 Offset: 0x211DF50 VA: 0x18211F550 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
