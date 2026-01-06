internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 13042
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x210A0D0 Offset: 0x2108AD0 VA: 0x18210A0D0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x21090A0 Offset: 0x2107AA0 VA: 0x1821090A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x21096D0 Offset: 0x21080D0 VA: 0x1821096D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2109530 Offset: 0x2107F30 VA: 0x182109530 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2109940 Offset: 0x2108340 VA: 0x182109940 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2109B80 Offset: 0x2108580 VA: 0x182109B80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2109C50 Offset: 0x2108650 VA: 0x182109C50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2109F30 Offset: 0x2108930 VA: 0x182109F30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2109D90 Offset: 0x2108790 VA: 0x182109D90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x21099D0 Offset: 0x21083D0 VA: 0x1821099D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x21098B0 Offset: 0x21082B0 VA: 0x1821098B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2109C10 Offset: 0x2108610 VA: 0x182109C10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2109A50 Offset: 0x2108450 VA: 0x182109A50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2109E70 Offset: 0x2108870 VA: 0x182109E70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x210A060 Offset: 0x2108A60 VA: 0x18210A060
	private static void .cctor() { }
}
