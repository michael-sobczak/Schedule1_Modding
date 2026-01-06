internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 13071
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x21314B0 Offset: 0x212FEB0 VA: 0x1821314B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x21303D0 Offset: 0x212EDD0 VA: 0x1821303D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2130CC0 Offset: 0x212F6C0 VA: 0x182130CC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2130BA0 Offset: 0x212F5A0 VA: 0x182130BA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2130E10 Offset: 0x212F810 VA: 0x182130E10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2131070 Offset: 0x212FA70 VA: 0x182131070 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2131110 Offset: 0x212FB10 VA: 0x182131110 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2131370 Offset: 0x212FD70 VA: 0x182131370 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x21311D0 Offset: 0x212FBD0 VA: 0x1821311D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2130F00 Offset: 0x212F900 VA: 0x182130F00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2130D80 Offset: 0x212F780 VA: 0x182130D80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x21310D0 Offset: 0x212FAD0 VA: 0x1821310D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2130F70 Offset: 0x212F970 VA: 0x182130F70 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x21312B0 Offset: 0x212FCB0 VA: 0x1821312B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
