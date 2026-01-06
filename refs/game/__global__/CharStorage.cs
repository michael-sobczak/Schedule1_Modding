internal sealed class CharStorage : DataStorage // TypeDefIndex: 13039
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x2105550 Offset: 0x2103F50 VA: 0x182105550
	internal void .ctor(DataColumn column) { }

	// RVA: 0x2104850 Offset: 0x2103250 VA: 0x182104850 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2104CB0 Offset: 0x21036B0 VA: 0x182104CB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2104B80 Offset: 0x2103580 VA: 0x182104B80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2104E10 Offset: 0x2103810 VA: 0x182104E10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2105090 Offset: 0x2103A90 VA: 0x182105090 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2105160 Offset: 0x2103B60 VA: 0x182105160 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x21053B0 Offset: 0x2103DB0 VA: 0x1821053B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2105210 Offset: 0x2103C10 VA: 0x182105210 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2104F10 Offset: 0x2103910 VA: 0x182104F10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2104D80 Offset: 0x2103780 VA: 0x182104D80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2105120 Offset: 0x2103B20 VA: 0x182105120 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2104F80 Offset: 0x2103980 VA: 0x182104F80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x21052F0 Offset: 0x2103CF0 VA: 0x1821052F0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
