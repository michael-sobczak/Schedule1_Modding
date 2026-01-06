internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 13064
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x212C7A0 Offset: 0x212B1A0 VA: 0x18212C7A0
	public void .ctor(DataColumn column) { }

	// RVA: 0x212B760 Offset: 0x212A160 VA: 0x18212B760 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x212BBC0 Offset: 0x212A5C0 VA: 0x18212BBC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x212BC40 Offset: 0x212A640 VA: 0x18212BC40
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x212BAC0 Offset: 0x212A4C0 VA: 0x18212BAC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x212BF50 Offset: 0x212A950 VA: 0x18212BF50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x212C320 Offset: 0x212AD20 VA: 0x18212C320 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x212C4B0 Offset: 0x212AEB0 VA: 0x18212C4B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x212C3D0 Offset: 0x212ADD0 VA: 0x18212C3D0 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x212C530 Offset: 0x212AF30 VA: 0x18212C530 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x212C720 Offset: 0x212B120 VA: 0x18212C720 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x212C5B0 Offset: 0x212AFB0 VA: 0x18212C5B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x212BFD0 Offset: 0x212A9D0 VA: 0x18212BFD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x212BDA0 Offset: 0x212A7A0 VA: 0x18212BDA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x212C390 Offset: 0x212AD90 VA: 0x18212C390 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x212C1C0 Offset: 0x212ABC0 VA: 0x18212C1C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x212C680 Offset: 0x212B080 VA: 0x18212C680 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
