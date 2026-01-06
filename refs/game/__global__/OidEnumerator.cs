public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 9608
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Properties
	public Oid Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1BBF320 Offset: 0x1BBDD20 VA: 0x181BBF320
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x262E740 Offset: 0x262D140 VA: 0x18262E740
	public Oid get_Current() { }

	// RVA: 0x262E740 Offset: 0x262D140 VA: 0x18262E740 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x262E6C0 Offset: 0x262D0C0 VA: 0x18262E6C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1663D50 Offset: 0x1662750 VA: 0x181663D50 Slot: 6
	public void Reset() { }
}
