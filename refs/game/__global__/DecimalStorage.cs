internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 13044
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x210CB60 Offset: 0x210B560 VA: 0x18210CB60
	internal void .ctor(DataColumn column) { }

	// RVA: 0x210B700 Offset: 0x210A100 VA: 0x18210B700 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x210C270 Offset: 0x210AC70 VA: 0x18210C270 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x210C0D0 Offset: 0x210AAD0 VA: 0x18210C0D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x210C4B0 Offset: 0x210AEB0 VA: 0x18210C4B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2109B80 Offset: 0x2108580 VA: 0x182109B80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x210C7B0 Offset: 0x210B1B0 VA: 0x18210C7B0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x210C9F0 Offset: 0x210B3F0 VA: 0x18210C9F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x210C850 Offset: 0x210B250 VA: 0x18210C850 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x210C5C0 Offset: 0x210AFC0 VA: 0x18210C5C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x210C420 Offset: 0x210AE20 VA: 0x18210C420 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x210C770 Offset: 0x210B170 VA: 0x18210C770 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x210C640 Offset: 0x210B040 VA: 0x18210C640 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x210C930 Offset: 0x210B330 VA: 0x18210C930 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
