internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 13043
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x210B5E0 Offset: 0x2109FE0 VA: 0x18210B5E0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x210A1F0 Offset: 0x2108BF0 VA: 0x18210A1F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x210A7B0 Offset: 0x21091B0 VA: 0x18210A7B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x210A630 Offset: 0x2109030 VA: 0x18210A630 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x210AA10 Offset: 0x2109410 VA: 0x18210AA10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x210AD30 Offset: 0x2109730 VA: 0x18210AD30 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x210AE00 Offset: 0x2109800 VA: 0x18210AE00 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x210B230 Offset: 0x2109C30 VA: 0x18210B230 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x210AF10 Offset: 0x2109910 VA: 0x18210AF10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x210AB10 Offset: 0x2109510 VA: 0x18210AB10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x210A920 Offset: 0x2109320 VA: 0x18210A920 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x210ADC0 Offset: 0x21097C0 VA: 0x18210ADC0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x210ABC0 Offset: 0x21095C0 VA: 0x18210ABC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x210AFF0 Offset: 0x21099F0 VA: 0x18210AFF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x210B570 Offset: 0x2109F70 VA: 0x18210B570
	private static void .cctor() { }
}
