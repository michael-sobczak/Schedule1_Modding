internal abstract class DataStorage // TypeDefIndex: 13041
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x2108FD0 Offset: 0x21079D0 VA: 0x182108FD0
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x2108E00 Offset: 0x2107800 VA: 0x182108E00
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x2108E30 Offset: 0x2107830 VA: 0x182108E30
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x50B640 Offset: 0x50A040 VA: 0x18050B640
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x2109080 Offset: 0x2107A80 VA: 0x182109080
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x21056F0 Offset: 0x21040F0 VA: 0x1821056F0 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x2105640 Offset: 0x2104040 VA: 0x182105640
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x21057B0 Offset: 0x21041B0 VA: 0x1821057B0
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x21058D0 Offset: 0x21042D0 VA: 0x1821058D0
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x2106FD0 Offset: 0x21059D0 VA: 0x182106FD0
	protected object GetBits(int recordNo) { }

	// RVA: 0xCC3240 Offset: 0xCC1C40 VA: 0x180CC3240 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x2107370 Offset: 0x2105D70 VA: 0x182107370
	protected bool HasValue(int recordNo) { }

	// RVA: 0x21077A0 Offset: 0x21061A0 VA: 0x1821077A0 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x2107BF0 Offset: 0x21065F0 VA: 0x182107BF0
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x2107B60 Offset: 0x2106560 VA: 0x182107B60 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x2105880 Offset: 0x2104280 VA: 0x182105880 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x2105830 Offset: 0x2104230 VA: 0x182105830 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x2105940 Offset: 0x2104340 VA: 0x182105940
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x21070A0 Offset: 0x2105AA0 VA: 0x1821070A0
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x21071F0 Offset: 0x2105BF0 VA: 0x1821071F0
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x2107B00 Offset: 0x2106500 VA: 0x182107B00
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x2107AF0 Offset: 0x21064F0 VA: 0x182107AF0
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x2107AE0 Offset: 0x21064E0 VA: 0x182107AE0
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x21079D0 Offset: 0x21063D0 VA: 0x1821079D0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x2106F40 Offset: 0x2105940 VA: 0x182106F40
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x2107470 Offset: 0x2105E70 VA: 0x182107470
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x21075E0 Offset: 0x2105FE0 VA: 0x1821075E0
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x21073A0 Offset: 0x2105DA0 VA: 0x1821073A0
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x21077C0 Offset: 0x21061C0 VA: 0x1821077C0
	public static bool IsObjectNull(object value) { }

	// RVA: 0x2107910 Offset: 0x2106310 VA: 0x182107910
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x2107010 Offset: 0x2105A10 VA: 0x182107010
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x2105920 Offset: 0x2104320 VA: 0x182105920
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2107C10 Offset: 0x2106610 VA: 0x182107C10
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x2107260 Offset: 0x2105C60 VA: 0x182107260
	internal static Type GetType(string value) { }

	// RVA: 0x2107030 Offset: 0x2105A30 VA: 0x182107030
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x2107C30 Offset: 0x2106630 VA: 0x182107C30
	private static void .cctor() { }
}
