internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 13037
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x2103600 Offset: 0x2102000 VA: 0x182103600
	internal void .ctor(DataColumn column) { }

	// RVA: 0x2102990 Offset: 0x2101390 VA: 0x182102990 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2102DB0 Offset: 0x21017B0 VA: 0x182102DB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2102C70 Offset: 0x2101670 VA: 0x182102C70 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2102F20 Offset: 0x2101920 VA: 0x182102F20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x21031B0 Offset: 0x2101BB0 VA: 0x1821031B0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2103280 Offset: 0x2101C80 VA: 0x182103280 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x21034D0 Offset: 0x2101ED0 VA: 0x1821034D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2103330 Offset: 0x2101D30 VA: 0x182103330 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2103020 Offset: 0x2101A20 VA: 0x182103020 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2102E90 Offset: 0x2101890 VA: 0x182102E90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2103240 Offset: 0x2101C40 VA: 0x182103240 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2103090 Offset: 0x2101A90 VA: 0x182103090 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2103410 Offset: 0x2101E10 VA: 0x182103410 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
