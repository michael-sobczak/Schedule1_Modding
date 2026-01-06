internal class LocatedActiveAxis : ActiveAxis // TypeDefIndex: 8247
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Properties
	internal int Column { get; }

	// Methods

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal int get_Column() { }

	// RVA: 0x2565F30 Offset: 0x2564930 VA: 0x182565F30
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x2565F10 Offset: 0x2564910 VA: 0x182565F10
	internal void Reactivate(KeySequence ks) { }
}
