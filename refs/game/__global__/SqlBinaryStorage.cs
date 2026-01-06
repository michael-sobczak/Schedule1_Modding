internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 13051
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x2112ED0 Offset: 0x21118D0 VA: 0x182112ED0
	public void .ctor(DataColumn column) { }

	// RVA: 0x2112350 Offset: 0x2110D50 VA: 0x182112350 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x21125D0 Offset: 0x2110FD0 VA: 0x1821125D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2112520 Offset: 0x2110F20 VA: 0x182112520 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2112820 Offset: 0x2111220 VA: 0x182112820 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2112B90 Offset: 0x2111590 VA: 0x182112B90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2112C20 Offset: 0x2111620 VA: 0x182112C20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2112C90 Offset: 0x2111690 VA: 0x182112C90 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2112E80 Offset: 0x2111880 VA: 0x182112E80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2112D10 Offset: 0x2111710 VA: 0x182112D10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2112890 Offset: 0x2111290 VA: 0x182112890 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2112670 Offset: 0x2111070 VA: 0x182112670 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2112BE0 Offset: 0x21115E0 VA: 0x182112BE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2112A70 Offset: 0x2111470 VA: 0x182112A70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2112DE0 Offset: 0x21117E0 VA: 0x182112DE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
