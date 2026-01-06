internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 13072
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x2132690 Offset: 0x2131090 VA: 0x182132690
	public void .ctor(DataColumn column) { }

	// RVA: 0x21315C0 Offset: 0x212FFC0 VA: 0x1821315C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2131EA0 Offset: 0x21308A0 VA: 0x182131EA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2131D80 Offset: 0x2130780 VA: 0x182131D80 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2132000 Offset: 0x2130A00 VA: 0x182132000 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2132260 Offset: 0x2130C60 VA: 0x182132260 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2132300 Offset: 0x2130D00 VA: 0x182132300 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2132560 Offset: 0x2130F60 VA: 0x182132560 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x21323C0 Offset: 0x2130DC0 VA: 0x1821323C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x21320F0 Offset: 0x2130AF0 VA: 0x1821320F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2131F70 Offset: 0x2130970 VA: 0x182131F70 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x21322C0 Offset: 0x2130CC0 VA: 0x1821322C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2132160 Offset: 0x2130B60 VA: 0x182132160 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x21324A0 Offset: 0x2130EA0 VA: 0x1821324A0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
