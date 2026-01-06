internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 13062
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x2129E90 Offset: 0x2128890 VA: 0x182129E90
	public void .ctor(DataColumn column) { }

	// RVA: 0x21286A0 Offset: 0x21270A0 VA: 0x1821286A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2129570 Offset: 0x2127F70 VA: 0x182129570 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x21294B0 Offset: 0x2127EB0 VA: 0x1821294B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x21297E0 Offset: 0x21281E0 VA: 0x1821297E0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2122CB0 Offset: 0x21216B0 VA: 0x182122CB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2129BC0 Offset: 0x21285C0 VA: 0x182129BC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2129C40 Offset: 0x2128640 VA: 0x182129C40 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2129E30 Offset: 0x2128830 VA: 0x182129E30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2129CC0 Offset: 0x21286C0 VA: 0x182129CC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2129860 Offset: 0x2128260 VA: 0x182129860 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2129630 Offset: 0x2128030 VA: 0x182129630 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2129B80 Offset: 0x2128580 VA: 0x182129B80 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2129A50 Offset: 0x2128450 VA: 0x182129A50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2129D90 Offset: 0x2128790 VA: 0x182129D90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
