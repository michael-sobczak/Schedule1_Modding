internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 13068
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x212DDA0 Offset: 0x212C7A0 VA: 0x18212DDA0
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x212DC10 Offset: 0x212C610 VA: 0x18212DC10
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x212D620 Offset: 0x212C020 VA: 0x18212D620
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x212D740 Offset: 0x212C140 VA: 0x18212D740 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x212C900 Offset: 0x212B300 VA: 0x18212C900 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x212CBC0 Offset: 0x212B5C0 VA: 0x18212CBC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x212C940 Offset: 0x212B340 VA: 0x18212C940 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x212D540 Offset: 0x212BF40 VA: 0x18212D540 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x2114F00 Offset: 0x2113900 VA: 0x182114F00 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x212D970 Offset: 0x212C370 VA: 0x18212D970 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x212D7F0 Offset: 0x212C1F0 VA: 0x18212D7F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x212D180 Offset: 0x212BB80 VA: 0x18212D180 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x212CF30 Offset: 0x212B930 VA: 0x18212CF30 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x212CD10 Offset: 0x212B710 VA: 0x18212CD10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x212CC00 Offset: 0x212B600 VA: 0x18212CC00 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x212D5E0 Offset: 0x212BFE0 VA: 0x18212D5E0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x212D3C0 Offset: 0x212BDC0 VA: 0x18212D3C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x212D8D0 Offset: 0x212C2D0 VA: 0x18212D8D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x212DB80 Offset: 0x212C580 VA: 0x18212DB80
	private static void .cctor() { }
}
