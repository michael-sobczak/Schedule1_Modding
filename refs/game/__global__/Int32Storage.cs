internal sealed class Int32Storage : DataStorage // TypeDefIndex: 13047
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x210FF60 Offset: 0x210E960 VA: 0x18210FF60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x210EEA0 Offset: 0x210D8A0 VA: 0x18210EEA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x210F790 Offset: 0x210E190 VA: 0x18210F790 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x210F680 Offset: 0x210E080 VA: 0x18210F680 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x210F8A0 Offset: 0x210E2A0 VA: 0x18210F8A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x210FB10 Offset: 0x210E510 VA: 0x18210FB10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x210FBE0 Offset: 0x210E5E0 VA: 0x18210FBE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x210FE30 Offset: 0x210E830 VA: 0x18210FE30 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x210FC90 Offset: 0x210E690 VA: 0x18210FC90 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x210F9A0 Offset: 0x210E3A0 VA: 0x18210F9A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x210F810 Offset: 0x210E210 VA: 0x18210F810 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x210FBA0 Offset: 0x210E5A0 VA: 0x18210FBA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x210FA10 Offset: 0x210E410 VA: 0x18210FA10 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x210FD70 Offset: 0x210E770 VA: 0x18210FD70 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
