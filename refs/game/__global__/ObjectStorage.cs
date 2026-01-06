internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 13034
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x20E1120 Offset: 0x20DFB20 VA: 0x1820E1120
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x20DDB10 Offset: 0x20DC510 VA: 0x1820DDB10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x20DE240 Offset: 0x20DCC40 VA: 0x1820DE240 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x20DDC90 Offset: 0x20DC690 VA: 0x1820DDC90 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x20DDB50 Offset: 0x20DC550 VA: 0x1820DDB50
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x20DDE20 Offset: 0x20DC820 VA: 0x1820DDE20
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x20DF740 Offset: 0x20DE140 VA: 0x1820DF740 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x20E0010 Offset: 0x20DEA10 VA: 0x1820E0010 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x20DF810 Offset: 0x20DE210 VA: 0x1820DF810
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x20E0050 Offset: 0x20DEA50 VA: 0x1820E0050 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x20E03B0 Offset: 0x20DEDB0 VA: 0x1820E03B0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x20E0080 Offset: 0x20DEA80 VA: 0x1820E0080 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x20DEA10 Offset: 0x20DD410 VA: 0x1820DEA10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x20DEE60 Offset: 0x20DD860 VA: 0x1820DEE60 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x20DE490 Offset: 0x20DCE90 VA: 0x1820DE490 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x20DE360 Offset: 0x20DCD60 VA: 0x1820DE360 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x20DF7D0 Offset: 0x20DE1D0 VA: 0x1820DF7D0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x20DF4D0 Offset: 0x20DDED0 VA: 0x1820DF4D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x20E0150 Offset: 0x20DEB50 VA: 0x1820E0150 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x20E0EF0 Offset: 0x20DF8F0 VA: 0x1820E0EF0
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x20DF960 Offset: 0x20DE360 VA: 0x1820DF960
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x20DF9E0 Offset: 0x20DE3E0 VA: 0x1820DF9E0
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x20E1020 Offset: 0x20DFA20 VA: 0x1820E1020
	private static void .cctor() { }
}
