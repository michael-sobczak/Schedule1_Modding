internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 13053
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x21151E0 Offset: 0x2113BE0 VA: 0x1821151E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x2114800 Offset: 0x2113200 VA: 0x182114800 Slot: 4
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

	// RVA: 0x21150E0 Offset: 0x2113AE0 VA: 0x1821150E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2114F70 Offset: 0x2113970 VA: 0x182114F70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2114B50 Offset: 0x2113550 VA: 0x182114B50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x21149A0 Offset: 0x21133A0 VA: 0x1821149A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2114EC0 Offset: 0x21138C0 VA: 0x182114EC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2114D50 Offset: 0x2113750 VA: 0x182114D50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2115040 Offset: 0x2113A40 VA: 0x182115040 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
