internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 13036
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x2102850 Offset: 0x2101250 VA: 0x182102850
	internal void .ctor(DataColumn column) { }

	// RVA: 0x2100D90 Offset: 0x20FF790 VA: 0x182100D90 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x2100F40 Offset: 0x20FF940 VA: 0x182100F40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x2100DD0 Offset: 0x20FF7D0 VA: 0x182100DD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x2101930 Offset: 0x2100330 VA: 0x182101930
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x2101090 Offset: 0x20FFA90 VA: 0x182101090
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x21020D0 Offset: 0x2100AD0 VA: 0x1821020D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x2102350 Offset: 0x2100D50 VA: 0x182102350 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2102440 Offset: 0x2100E40 VA: 0x182102440 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x21026D0 Offset: 0x21010D0 VA: 0x1821026D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x2102530 Offset: 0x2100F30 VA: 0x182102530 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x2102170 Offset: 0x2100B70 VA: 0x182102170 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x2101860 Offset: 0x2100260 VA: 0x182101860 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x2102400 Offset: 0x2100E00 VA: 0x182102400 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x2102210 Offset: 0x2100C10 VA: 0x182102210 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2102610 Offset: 0x2101010 VA: 0x182102610 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}
