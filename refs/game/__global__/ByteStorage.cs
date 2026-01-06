internal sealed class ByteStorage : DataStorage // TypeDefIndex: 13038
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x2104760 Offset: 0x2103160 VA: 0x182104760
	internal void .ctor(DataColumn column) { }

	// RVA: 0x21036F0 Offset: 0x21020F0 VA: 0x1821036F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2103F80 Offset: 0x2102980 VA: 0x182103F80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2103E60 Offset: 0x2102860 VA: 0x182103E60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2104090 Offset: 0x2102A90 VA: 0x182104090 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2104310 Offset: 0x2102D10 VA: 0x182104310 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x21043E0 Offset: 0x2102DE0 VA: 0x1821043E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2104630 Offset: 0x2103030 VA: 0x182104630 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2104490 Offset: 0x2102E90 VA: 0x182104490 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2104190 Offset: 0x2102B90 VA: 0x182104190 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2104000 Offset: 0x2102A00 VA: 0x182104000 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x21043A0 Offset: 0x2102DA0 VA: 0x1821043A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2104200 Offset: 0x2102C00 VA: 0x182104200 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2104570 Offset: 0x2102F70 VA: 0x182104570 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
