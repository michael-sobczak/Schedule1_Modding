internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 13059
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x2125470 Offset: 0x2123E70 VA: 0x182125470
	public void .ctor(DataColumn column) { }

	// RVA: 0x2123DD0 Offset: 0x21227D0 VA: 0x182123DD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2124BB0 Offset: 0x21235B0 VA: 0x182124BB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2124B00 Offset: 0x2123500 VA: 0x182124B00 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2124E00 Offset: 0x2123800 VA: 0x182124E00 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2125150 Offset: 0x2123B50 VA: 0x182125150 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x21251D0 Offset: 0x2123BD0 VA: 0x1821251D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2125240 Offset: 0x2123C40 VA: 0x182125240 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2125430 Offset: 0x2123E30 VA: 0x182125430 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x21252C0 Offset: 0x2123CC0 VA: 0x1821252C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2124E70 Offset: 0x2123870 VA: 0x182124E70 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2124C50 Offset: 0x2123650 VA: 0x182124C50 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2125190 Offset: 0x2123B90 VA: 0x182125190 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2125040 Offset: 0x2123A40 VA: 0x182125040 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2125390 Offset: 0x2123D90 VA: 0x182125390 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
