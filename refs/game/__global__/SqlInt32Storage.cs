internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 13060
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x2126C70 Offset: 0x2125670 VA: 0x182126C70
	public void .ctor(DataColumn column) { }

	// RVA: 0x21255B0 Offset: 0x2123FB0 VA: 0x1821255B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2126390 Offset: 0x2124D90 VA: 0x182126390 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x21262E0 Offset: 0x2124CE0 VA: 0x1821262E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x21265E0 Offset: 0x2124FE0 VA: 0x1821265E0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2126940 Offset: 0x2125340 VA: 0x182126940 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x21269C0 Offset: 0x21253C0 VA: 0x1821269C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2126A30 Offset: 0x2125430 VA: 0x182126A30 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2126C20 Offset: 0x2125620 VA: 0x182126C20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2126AB0 Offset: 0x21254B0 VA: 0x182126AB0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2126650 Offset: 0x2125050 VA: 0x182126650 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2126430 Offset: 0x2124E30 VA: 0x182126430 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2126980 Offset: 0x2125380 VA: 0x182126980 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2126830 Offset: 0x2125230 VA: 0x182126830 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2126B80 Offset: 0x2125580 VA: 0x182126B80 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
