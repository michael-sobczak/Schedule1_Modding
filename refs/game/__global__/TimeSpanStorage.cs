internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 13070
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x2130170 Offset: 0x212EB70 VA: 0x182130170
	public void .ctor(DataColumn column) { }

	// RVA: 0x212E980 Offset: 0x212D380 VA: 0x18212E980 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x212F680 Offset: 0x212E080 VA: 0x18212F680 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x212F4F0 Offset: 0x212DEF0 VA: 0x18212F4F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x212F880 Offset: 0x212E280 VA: 0x18212F880
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x212FAB0 Offset: 0x212E4B0 VA: 0x18212FAB0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x212FCD0 Offset: 0x212E6D0 VA: 0x18212FCD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x212FD70 Offset: 0x212E770 VA: 0x18212FD70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2130010 Offset: 0x212EA10 VA: 0x182130010 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x212FE70 Offset: 0x212E870 VA: 0x18212FE70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x212FB50 Offset: 0x212E550 VA: 0x18212FB50 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x212F7F0 Offset: 0x212E1F0 VA: 0x18212F7F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x212FD30 Offset: 0x212E730 VA: 0x18212FD30 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x212FBC0 Offset: 0x212E5C0 VA: 0x18212FBC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x212FF50 Offset: 0x212E950 VA: 0x18212FF50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x2130100 Offset: 0x212EB00 VA: 0x182130100
	private static void .cctor() { }
}
