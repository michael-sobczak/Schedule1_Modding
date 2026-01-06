internal sealed class Int16Storage : DataStorage // TypeDefIndex: 13046
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x210EDB0 Offset: 0x210D7B0 VA: 0x18210EDB0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x210DD50 Offset: 0x210C750 VA: 0x18210DD50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x210E680 Offset: 0x210D080 VA: 0x18210E680 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x210E560 Offset: 0x210CF60 VA: 0x18210E560 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x210E780 Offset: 0x210D180 VA: 0x18210E780 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2105090 Offset: 0x2103A90 VA: 0x182105090 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x210EA30 Offset: 0x210D430 VA: 0x18210EA30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x210EC80 Offset: 0x210D680 VA: 0x18210EC80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x210EAE0 Offset: 0x210D4E0 VA: 0x18210EAE0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x210E880 Offset: 0x210D280 VA: 0x18210E880 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x210E6F0 Offset: 0x210D0F0 VA: 0x18210E6F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x210E9F0 Offset: 0x210D3F0 VA: 0x18210E9F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x210E8F0 Offset: 0x210D2F0 VA: 0x18210E8F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x210EBC0 Offset: 0x210D5C0 VA: 0x18210EBC0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
