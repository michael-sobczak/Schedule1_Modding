internal sealed class Int64Storage : DataStorage // TypeDefIndex: 13048
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x2111130 Offset: 0x210FB30 VA: 0x182111130
	internal void .ctor(DataColumn column) { }

	// RVA: 0x2110050 Offset: 0x210EA50 VA: 0x182110050 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2110950 Offset: 0x210F350 VA: 0x182110950 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2110830 Offset: 0x210F230 VA: 0x182110830 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2110A60 Offset: 0x210F460 VA: 0x182110A60 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2110CD0 Offset: 0x210F6D0 VA: 0x182110CD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2110DA0 Offset: 0x210F7A0 VA: 0x182110DA0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2110FF0 Offset: 0x210F9F0 VA: 0x182110FF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2110E50 Offset: 0x210F850 VA: 0x182110E50 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2110B60 Offset: 0x210F560 VA: 0x182110B60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x21109D0 Offset: 0x210F3D0 VA: 0x1821109D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2110D60 Offset: 0x210F760 VA: 0x182110D60 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2110BD0 Offset: 0x210F5D0 VA: 0x182110BD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2110F30 Offset: 0x210F930 VA: 0x182110F30 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
