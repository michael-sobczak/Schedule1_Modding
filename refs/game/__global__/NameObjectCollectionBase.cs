public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 9868
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x26AE320 Offset: 0x26ACD20 VA: 0x1826AE320
	protected void .ctor() { }

	// RVA: 0x26AE380 Offset: 0x26ACD80 VA: 0x1826AE380
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x26AE2E0 Offset: 0x26ACCE0 VA: 0x1826AE2E0
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x445C20 Offset: 0x444620 VA: 0x180445C20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26ACD30 Offset: 0x26AB730 VA: 0x1826ACD30 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26AD4B0 Offset: 0x26ABEB0 VA: 0x1826AD4B0 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x26ADCB0 Offset: 0x26AC6B0 VA: 0x1826ADCB0
	private void Reset() { }

	// RVA: 0x26ADD80 Offset: 0x26AC780 VA: 0x1826ADD80
	private void Reset(int capacity) { }

	// RVA: 0x26ACBF0 Offset: 0x26AB5F0 VA: 0x1826ACBF0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	protected bool get_IsReadOnly() { }

	// RVA: 0x26AC430 Offset: 0x26AAE30 VA: 0x1826AC430
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x26AC8B0 Offset: 0x26AB2B0 VA: 0x1826AC8B0
	protected void BaseRemove(string name) { }

	// RVA: 0x26AC7F0 Offset: 0x26AB1F0 VA: 0x1826AC7F0
	protected object BaseGet(string name) { }

	// RVA: 0x26ACB20 Offset: 0x26AB520 VA: 0x1826ACB20
	protected void BaseSet(string name, object value) { }

	// RVA: 0x26AC810 Offset: 0x26AB210 VA: 0x1826AC810
	protected object BaseGet(int index) { }

	// RVA: 0x26AC750 Offset: 0x26AB150 VA: 0x1826AC750
	protected string BaseGetKey(int index) { }

	// RVA: 0x26ACCB0 Offset: 0x26AB6B0 VA: 0x1826ACCB0 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1AD6CE0 Offset: 0x1AD56E0 VA: 0x181AD6CE0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x26ADE60 Offset: 0x26AC860 VA: 0x1826ADE60 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x26AE1C0 Offset: 0x26ACBC0 VA: 0x1826AE1C0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x26AC5E0 Offset: 0x26AAFE0 VA: 0x1826AC5E0
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x26AE230 Offset: 0x26ACC30 VA: 0x1826AE230
	private static void .cctor() { }
}
