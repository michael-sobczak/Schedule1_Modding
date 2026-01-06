internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 13073
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x2133940 Offset: 0x2132340 VA: 0x182133940
	public void .ctor(DataColumn column) { }

	// RVA: 0x21327A0 Offset: 0x21311A0 VA: 0x1821327A0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x21330F0 Offset: 0x2131AF0 VA: 0x1821330F0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2132FD0 Offset: 0x21319D0 VA: 0x182132FD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x21332A0 Offset: 0x2131CA0 VA: 0x1821332A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2133500 Offset: 0x2131F00 VA: 0x182133500 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x21335A0 Offset: 0x2131FA0 VA: 0x1821335A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2133800 Offset: 0x2132200 VA: 0x182133800 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2133660 Offset: 0x2132060 VA: 0x182133660 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2133390 Offset: 0x2131D90 VA: 0x182133390 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2133210 Offset: 0x2131C10 VA: 0x182133210 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2133560 Offset: 0x2131F60 VA: 0x182133560 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2133400 Offset: 0x2131E00 VA: 0x182133400 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2133740 Offset: 0x2132140 VA: 0x182133740 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
