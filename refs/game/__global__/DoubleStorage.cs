internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 13045
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x210DC60 Offset: 0x210C660 VA: 0x18210DC60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x210CC70 Offset: 0x210B670 VA: 0x18210CC70 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x210D450 Offset: 0x210BE50 VA: 0x18210D450 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x210D320 Offset: 0x210BD20 VA: 0x18210D320 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x210D570 Offset: 0x210BF70 VA: 0x18210D570 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x210D800 Offset: 0x210C200 VA: 0x18210D800 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x210D8D0 Offset: 0x210C2D0 VA: 0x18210D8D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x210DB20 Offset: 0x210C520 VA: 0x18210DB20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x210D980 Offset: 0x210C380 VA: 0x18210D980 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x210D670 Offset: 0x210C070 VA: 0x18210D670 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x210D4E0 Offset: 0x210BEE0 VA: 0x18210D4E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x210D890 Offset: 0x210C290 VA: 0x18210D890 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x210D6E0 Offset: 0x210C0E0 VA: 0x18210D6E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x210DA60 Offset: 0x210C460 VA: 0x18210DA60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
