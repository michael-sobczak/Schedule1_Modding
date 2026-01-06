public struct ConsoleKeyInfo // TypeDefIndex: 3771
{
	// Fields
	private readonly char _keyChar; // 0x0
	private readonly ConsoleKey _key; // 0x4
	private readonly ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x1C7F9C0 Offset: 0x1C7E3C0 VA: 0x181C7F9C0
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	public char get_KeyChar() { }

	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public ConsoleKey get_Key() { }

	// RVA: 0x1C7F8F0 Offset: 0x1C7E2F0 VA: 0x181C7F8F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1C7F8D0 Offset: 0x1C7E2D0 VA: 0x181C7F8D0
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x1C7F9A0 Offset: 0x1C7E3A0 VA: 0x181C7F9A0 Slot: 2
	public override int GetHashCode() { }
}
