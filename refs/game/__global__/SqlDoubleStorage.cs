internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 13057
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x2123010 Offset: 0x2121A10 VA: 0x182123010
	public void .ctor(DataColumn column) { }

	// RVA: 0x2121930 Offset: 0x2120330 VA: 0x182121930 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x21226A0 Offset: 0x21210A0 VA: 0x1821226A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x21225E0 Offset: 0x2120FE0 VA: 0x1821225E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2122910 Offset: 0x2121310 VA: 0x182122910 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2122CB0 Offset: 0x21216B0 VA: 0x182122CB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2122D40 Offset: 0x2121740 VA: 0x182122D40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x2122DC0 Offset: 0x21217C0 VA: 0x182122DC0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x2122FB0 Offset: 0x21219B0 VA: 0x182122FB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2122E40 Offset: 0x2121840 VA: 0x182122E40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2122990 Offset: 0x2121390 VA: 0x182122990 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2122760 Offset: 0x2121160 VA: 0x182122760 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2122D00 Offset: 0x2121700 VA: 0x182122D00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2122B80 Offset: 0x2121580 VA: 0x182122B80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2122F10 Offset: 0x2121910 VA: 0x182122F10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
