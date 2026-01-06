internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 13063
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x212B620 Offset: 0x212A020 VA: 0x18212B620
	public void .ctor(DataColumn column) { }

	// RVA: 0x2129FE0 Offset: 0x21289E0 VA: 0x182129FE0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x212AD80 Offset: 0x2129780 VA: 0x18212AD80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x212ACD0 Offset: 0x21296D0 VA: 0x18212ACD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x212AFD0 Offset: 0x21299D0 VA: 0x18212AFD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2126940 Offset: 0x2125340 VA: 0x182126940 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x212B370 Offset: 0x2129D70 VA: 0x18212B370 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x212B3E0 Offset: 0x2129DE0 VA: 0x18212B3E0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x212B5D0 Offset: 0x2129FD0 VA: 0x18212B5D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x212B460 Offset: 0x2129E60 VA: 0x18212B460 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x212B040 Offset: 0x2129A40 VA: 0x18212B040 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x212AE20 Offset: 0x2129820 VA: 0x18212AE20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x212B330 Offset: 0x2129D30 VA: 0x18212B330 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x212B220 Offset: 0x2129C20 VA: 0x18212B220 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x212B530 Offset: 0x2129F30 VA: 0x18212B530 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
