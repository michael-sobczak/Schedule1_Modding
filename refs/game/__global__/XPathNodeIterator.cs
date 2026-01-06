public abstract class XPathNodeIterator : ICloneable, IEnumerable // TypeDefIndex: 8138
{
	// Fields
	internal int count; // 0x10

	// Properties
	public abstract XPathNavigator Current { get; }
	public abstract int CurrentPosition { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XPathNodeIterator Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract XPathNavigator get_Current();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_CurrentPosition();

	// RVA: 0x2530170 Offset: 0x252EB70 VA: 0x182530170 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x25300E0 Offset: 0x252EAE0 VA: 0x1825300E0 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x5E0C50 Offset: 0x5DF650 VA: 0x1805E0C50
	protected void .ctor() { }
}
