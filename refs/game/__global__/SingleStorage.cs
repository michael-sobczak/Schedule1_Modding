internal sealed class SingleStorage : DataStorage // TypeDefIndex: 13066
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x21209E0 Offset: 0x211F3E0 VA: 0x1821209E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x211FA40 Offset: 0x211E440 VA: 0x18211FA40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2120240 Offset: 0x211EC40 VA: 0x182120240 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2120120 Offset: 0x211EB20 VA: 0x182120120 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2120360 Offset: 0x211ED60 VA: 0x182120360 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x21205E0 Offset: 0x211EFE0 VA: 0x1821205E0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2120680 Offset: 0x211F080 VA: 0x182120680 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x21208C0 Offset: 0x211F2C0 VA: 0x1821208C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2120720 Offset: 0x211F120 VA: 0x182120720 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2120450 Offset: 0x211EE50 VA: 0x182120450 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x21202D0 Offset: 0x211ECD0 VA: 0x1821202D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2120640 Offset: 0x211F040 VA: 0x182120640 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x21204C0 Offset: 0x211EEC0 VA: 0x1821204C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2120800 Offset: 0x211F200 VA: 0x182120800 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
