internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 13065
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x21217F0 Offset: 0x21201F0 VA: 0x1821217F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x2120AD0 Offset: 0x211F4D0 VA: 0x182120AD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2120F30 Offset: 0x211F930 VA: 0x182120F30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2120E80 Offset: 0x211F880 VA: 0x182120E80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2121180 Offset: 0x211FB80 VA: 0x182121180 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x21214D0 Offset: 0x211FED0 VA: 0x1821214D0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2121550 Offset: 0x211FF50 VA: 0x182121550 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x21215C0 Offset: 0x211FFC0 VA: 0x1821215C0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x21217B0 Offset: 0x21201B0 VA: 0x1821217B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2121640 Offset: 0x2120040 VA: 0x182121640 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x21211F0 Offset: 0x211FBF0 VA: 0x1821211F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2120FD0 Offset: 0x211F9D0 VA: 0x182120FD0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2121510 Offset: 0x211FF10 VA: 0x182121510 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x21213C0 Offset: 0x211FDC0 VA: 0x1821213C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2121710 Offset: 0x2120110 VA: 0x182121710 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
