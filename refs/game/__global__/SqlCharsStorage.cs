internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 13054
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x2115C00 Offset: 0x2114600 VA: 0x182115C00
	public void .ctor(DataColumn column) { }

	// RVA: 0x21152D0 Offset: 0x2113CD0 VA: 0x1821152D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2114E70 Offset: 0x2113870 VA: 0x182114E70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2114F00 Offset: 0x2113900 VA: 0x182114F00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2114F30 Offset: 0x2113930 VA: 0x182114F30 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2115B00 Offset: 0x2114500 VA: 0x182115B00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2115990 Offset: 0x2114390 VA: 0x182115990 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2115620 Offset: 0x2114020 VA: 0x182115620 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2115470 Offset: 0x2113E70 VA: 0x182115470 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2115950 Offset: 0x2114350 VA: 0x182115950 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2115830 Offset: 0x2114230 VA: 0x182115830 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2115A60 Offset: 0x2114460 VA: 0x182115A60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
