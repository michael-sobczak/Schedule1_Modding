public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 4417
{
	// Fields
	private readonly string[] _members; // 0x10
	private readonly object[] _data; // 0x18
	private readonly Type[] _types; // 0x20
	private readonly int _numItems; // 0x28
	private int _currItem; // 0x2C
	private bool _current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x1B40720 Offset: 0x1B3F120 VA: 0x181B40720
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x1B40690 Offset: 0x1B3F090 VA: 0x181B40690 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1B406C0 Offset: 0x1B3F0C0 VA: 0x181B406C0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1B407A0 Offset: 0x1B3F1A0 VA: 0x181B407A0
	public SerializationEntry get_Current() { }

	// RVA: 0x1B406B0 Offset: 0x1B3F0B0 VA: 0x181B406B0 Slot: 6
	public void Reset() { }

	// RVA: 0x1B408C0 Offset: 0x1B3F2C0 VA: 0x181B408C0
	public string get_Name() { }

	// RVA: 0x1B409E0 Offset: 0x1B3F3E0 VA: 0x181B409E0
	public object get_Value() { }

	// RVA: 0x1B40950 Offset: 0x1B3F350 VA: 0x181B40950
	public Type get_ObjectType() { }
}
