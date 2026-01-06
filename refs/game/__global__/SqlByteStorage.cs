internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 13052
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x21146C0 Offset: 0x21130C0 VA: 0x1821146C0
	public void .ctor(DataColumn column) { }

	// RVA: 0x2113010 Offset: 0x2111A10 VA: 0x182113010 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2113DF0 Offset: 0x21127F0 VA: 0x182113DF0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2113D40 Offset: 0x2112740 VA: 0x182113D40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2114040 Offset: 0x2112A40 VA: 0x182114040 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2114390 Offset: 0x2112D90 VA: 0x182114390 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2114410 Offset: 0x2112E10 VA: 0x182114410 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2114480 Offset: 0x2112E80 VA: 0x182114480 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2114670 Offset: 0x2113070 VA: 0x182114670 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2114500 Offset: 0x2112F00 VA: 0x182114500 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x21140B0 Offset: 0x2112AB0 VA: 0x1821140B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2113E90 Offset: 0x2112890 VA: 0x182113E90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x21143D0 Offset: 0x2112DD0 VA: 0x1821143D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2114280 Offset: 0x2112C80 VA: 0x182114280 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x21145D0 Offset: 0x2112FD0 VA: 0x1821145D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
