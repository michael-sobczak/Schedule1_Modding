public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 4937
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] _buckets; // 0x10
	private int _count; // 0x18
	private int _occupancy; // 0x1C
	private int _loadsize; // 0x20
	private float _loadFactor; // 0x24
	private int _version; // 0x28
	private bool _isWriterInProgress; // 0x2C
	private ICollection _keys; // 0x30
	private ICollection _values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x0

	// Properties
	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1BFBB10 Offset: 0x1BFA510 VA: 0x181BFBB10
	private static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor(bool trash) { }

	// RVA: 0x1BFB460 Offset: 0x1BF9E60 VA: 0x181BFB460
	public void .ctor() { }

	// RVA: 0x1BFB3A0 Offset: 0x1BF9DA0 VA: 0x181BFB3A0
	public void .ctor(int capacity) { }

	// RVA: 0x1BFB500 Offset: 0x1BF9F00 VA: 0x181BFB500
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x1BFB480 Offset: 0x1BF9E80 VA: 0x181BFB480
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	// RVA: 0x1BFB210 Offset: 0x1BF9C10 VA: 0x181BFB210
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1BFB1D0 Offset: 0x1BF9BD0 VA: 0x181BFB1D0
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1BFB4C0 Offset: 0x1BF9EC0 VA: 0x181BFB4C0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	// RVA: 0x1BFB2D0 Offset: 0x1BF9CD0 VA: 0x181BFB2D0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x1BFB3B0 Offset: 0x1BF9DB0 VA: 0x181BFB3B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BF9D50 Offset: 0x1BF8750 VA: 0x181BF9D50
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x1BF8DB0 Offset: 0x1BF77B0 VA: 0x181BF8DB0 Slot: 23
	public virtual void Add(object key, object value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1BF8DD0 Offset: 0x1BF77D0 VA: 0x181BF8DD0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1BF8F00 Offset: 0x1BF7900 VA: 0x181BF8F00 Slot: 25
	public virtual object Clone() { }

	// RVA: 0xB298C0 Offset: 0xB282C0 VA: 0x180B298C0 Slot: 26
	public virtual bool Contains(object key) { }

	// RVA: 0x1BF9030 Offset: 0x1BF7A30 VA: 0x181BF9030 Slot: 27
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1BF92E0 Offset: 0x1BF7CE0 VA: 0x181BF92E0
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x1BF91C0 Offset: 0x1BF7BC0 VA: 0x181BF91C0
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x1BF9380 Offset: 0x1BF7D80 VA: 0x181BF9380 Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1BF9640 Offset: 0x1BF8040 VA: 0x181BF9640
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x1BFB850 Offset: 0x1BFA250 VA: 0x181BFB850 Slot: 29
	public virtual object get_Item(object key) { }

	// RVA: 0x1BFBF40 Offset: 0x1BFA940 VA: 0x181BFBF40 Slot: 30
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1BFB790 Offset: 0x1BFA190 VA: 0x181BFB790
	private void expand() { }

	// RVA: 0x1BFBF10 Offset: 0x1BFA910 VA: 0x181BFBF10
	private void rehash() { }

	// RVA: 0x1BFB1A0 Offset: 0x1BF9BA0 VA: 0x181BFB1A0
	private void UpdateVersion() { }

	// RVA: 0x1BFBDA0 Offset: 0x1BFA7A0 VA: 0x181BFBDA0
	private void rehash(int newsize) { }

	// RVA: 0x1BFB140 Offset: 0x1BF9B40 VA: 0x181BFB140 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BF96E0 Offset: 0x1BF80E0 VA: 0x181BF96E0 Slot: 31
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1BF9740 Offset: 0x1BF8140 VA: 0x181BF9740 Slot: 32
	protected virtual int GetHash(object key) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 33
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 35
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1BFA2F0 Offset: 0x1BF8CF0 VA: 0x181BFA2F0 Slot: 36
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x1BFBA90 Offset: 0x1BFA490 VA: 0x181BFBA90 Slot: 37
	public virtual ICollection get_Keys() { }

	// RVA: 0x1BFBBD0 Offset: 0x1BFA5D0 VA: 0x181BFBBD0 Slot: 38
	public virtual ICollection get_Values() { }

	// RVA: 0x1BF9DA0 Offset: 0x1BF87A0 VA: 0x181BF9DA0
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x1BFBC50 Offset: 0x1BFA650 VA: 0x181BFBC50
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1BFADC0 Offset: 0x1BF97C0 VA: 0x181BFADC0 Slot: 39
	public virtual void Remove(object key) { }

	// RVA: 0x1BFBB60 Offset: 0x1BFA560 VA: 0x181BFBB60 Slot: 40
	public virtual object get_SyncRoot() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 41
	public virtual int get_Count() { }

	// RVA: 0x1BFB090 Offset: 0x1BF9A90 VA: 0x181BFB090
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x1BF97D0 Offset: 0x1BF81D0 VA: 0x181BF97D0 Slot: 42
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BFA430 Offset: 0x1BF8E30 VA: 0x181BFA430 Slot: 43
	public virtual void OnDeserialization(object sender) { }
}
