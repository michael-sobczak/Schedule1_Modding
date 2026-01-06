internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 13058
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x2123C90 Offset: 0x2122690 VA: 0x182123C90
	public void .ctor(DataColumn column) { }

	// RVA: 0x2123160 Offset: 0x2121B60 VA: 0x182123160 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x21233E0 Offset: 0x2121DE0 VA: 0x1821233E0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2123330 Offset: 0x2121D30 VA: 0x182123330 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2123630 Offset: 0x2122030 VA: 0x182123630 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2112B90 Offset: 0x2111590 VA: 0x182112B90 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x21239E0 Offset: 0x21223E0 VA: 0x1821239E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2123A50 Offset: 0x2122450 VA: 0x182123A50 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2123C40 Offset: 0x2122640 VA: 0x182123C40 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2123AD0 Offset: 0x21224D0 VA: 0x182123AD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x21236A0 Offset: 0x21220A0 VA: 0x1821236A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2123480 Offset: 0x2121E80 VA: 0x182123480 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x21239A0 Offset: 0x21223A0 VA: 0x1821239A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2123880 Offset: 0x2122280 VA: 0x182123880 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2123BA0 Offset: 0x21225A0 VA: 0x182123BA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
