internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 9990
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x26B6AF0 Offset: 0x26B54F0 VA: 0x1826B6AF0 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x26B6700 Offset: 0x26B5100 VA: 0x1826B6700 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x26B6A00 Offset: 0x26B5400 VA: 0x1826B6A00
	private int FastGetHashCode(string myString) { }

	// RVA: 0x26B6880 Offset: 0x26B5280 VA: 0x1826B6880 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x26B6C10 Offset: 0x26B5610 VA: 0x1826B6C10
	private static void .cctor() { }
}
