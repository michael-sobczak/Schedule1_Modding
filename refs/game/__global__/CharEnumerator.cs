public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable // TypeDefIndex: 3611
{
	// Fields
	private string _str; // 0x10
	private int _index; // 0x18
	private char _currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x1BBF320 Offset: 0x1BBDD20 VA: 0x181BBF320
	internal void .ctor(string str) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 9
	public object Clone() { }

	// RVA: 0x1BBF1C0 Offset: 0x1BBDBC0 VA: 0x181BBF1C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1BBF190 Offset: 0x1BBDB90 VA: 0x181BBF190 Slot: 8
	public void Dispose() { }

	// RVA: 0x1BBF220 Offset: 0x1BBDC20 VA: 0x181BBF220 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1BBF390 Offset: 0x1BBDD90 VA: 0x181BBF390 Slot: 7
	public char get_Current() { }

	// RVA: 0x1BBF210 Offset: 0x1BBDC10 VA: 0x181BBF210 Slot: 6
	public void Reset() { }

	// RVA: 0x1BBF360 Offset: 0x1BBDD60 VA: 0x181BBF360
	internal void .ctor() { }
}
