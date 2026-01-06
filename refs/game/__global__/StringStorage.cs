internal sealed class StringStorage : DataStorage // TypeDefIndex: 13069
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x212E8A0 Offset: 0x212D2A0 VA: 0x18212E8A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x212E050 Offset: 0x212CA50 VA: 0x18212E050 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x212E3F0 Offset: 0x212CDF0 VA: 0x18212E3F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x212E310 Offset: 0x212CD10 VA: 0x18212E310 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x212E4C0 Offset: 0x212CEC0 VA: 0x18212E4C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2114E70 Offset: 0x2113870 VA: 0x182114E70 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x20E0010 Offset: 0x20DEA10 VA: 0x1820E0010 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x212E650 Offset: 0x212D050 VA: 0x18212E650 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x20E0050 Offset: 0x20DEA50 VA: 0x1820E0050 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x212E800 Offset: 0x212D200 VA: 0x18212E800 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x212E690 Offset: 0x212D090 VA: 0x18212E690 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x212E470 Offset: 0x212CE70 VA: 0x18212E470 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x212E610 Offset: 0x212D010 VA: 0x18212E610 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x212E4F0 Offset: 0x212CEF0 VA: 0x18212E4F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x212E760 Offset: 0x212D160 VA: 0x18212E760 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
