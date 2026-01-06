internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 13061
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x2128550 Offset: 0x2126F50 VA: 0x182128550
	public void .ctor(DataColumn column) { }

	// RVA: 0x2126DB0 Offset: 0x21257B0 VA: 0x182126DB0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2127C30 Offset: 0x2126630 VA: 0x182127C30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2127B70 Offset: 0x2126570 VA: 0x182127B70 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2127EA0 Offset: 0x21268A0 VA: 0x182127EA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2122CB0 Offset: 0x21216B0 VA: 0x182122CB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2128280 Offset: 0x2126C80 VA: 0x182128280 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2128300 Offset: 0x2126D00 VA: 0x182128300 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x21284F0 Offset: 0x2126EF0 VA: 0x1821284F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2128380 Offset: 0x2126D80 VA: 0x182128380 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2127F20 Offset: 0x2126920 VA: 0x182127F20 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2127CF0 Offset: 0x21266F0 VA: 0x182127CF0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2128240 Offset: 0x2126C40 VA: 0x182128240 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2128110 Offset: 0x2126B10 VA: 0x182128110 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2128450 Offset: 0x2126E50 VA: 0x182128450 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
