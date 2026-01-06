internal sealed class SByteStorage : DataStorage // TypeDefIndex: 13049
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x2112260 Offset: 0x2110C60 VA: 0x182112260
	public void .ctor(DataColumn column) { }

	// RVA: 0x2111220 Offset: 0x210FC20 VA: 0x182111220 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2111AC0 Offset: 0x21104C0 VA: 0x182111AC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x21119A0 Offset: 0x21103A0 VA: 0x1821119A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2111C10 Offset: 0x2110610 VA: 0x182111C10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2104310 Offset: 0x2102D10 VA: 0x182104310 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2111ED0 Offset: 0x21108D0 VA: 0x182111ED0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2112130 Offset: 0x2110B30 VA: 0x182112130 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2111F90 Offset: 0x2110990 VA: 0x182111F90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2111D10 Offset: 0x2110710 VA: 0x182111D10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2111B80 Offset: 0x2110580 VA: 0x182111B80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2111E90 Offset: 0x2110890 VA: 0x182111E90 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2111D80 Offset: 0x2110780 VA: 0x182111D80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2112070 Offset: 0x2110A70 VA: 0x182112070 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
