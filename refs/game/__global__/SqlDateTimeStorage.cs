internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 13055
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x211DD00 Offset: 0x211C700 VA: 0x18211DD00
	public void .ctor(DataColumn column) { }

	// RVA: 0x211CD40 Offset: 0x211B740 VA: 0x18211CD40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x211D380 Offset: 0x211BD80 VA: 0x18211D380 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x211D2B0 Offset: 0x211BCB0 VA: 0x18211D2B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x211D600 Offset: 0x211C000 VA: 0x18211D600 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x211D9A0 Offset: 0x211C3A0 VA: 0x18211D9A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x211DA30 Offset: 0x211C430 VA: 0x18211DA30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x211DAB0 Offset: 0x211C4B0 VA: 0x18211DAB0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x211DCA0 Offset: 0x211C6A0 VA: 0x18211DCA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x211DB30 Offset: 0x211C530 VA: 0x18211DB30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x211D680 Offset: 0x211C080 VA: 0x18211D680 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x211D450 Offset: 0x211BE50 VA: 0x18211D450 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x211D9F0 Offset: 0x211C3F0 VA: 0x18211D9F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x211D870 Offset: 0x211C270 VA: 0x18211D870 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x211DC00 Offset: 0x211C600 VA: 0x18211DC00 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
