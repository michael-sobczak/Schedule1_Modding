public sealed class ModuleInfoAttribute : Attribute, IComparable // TypeDefIndex: 10685
{
	// Fields
	public readonly string MenuName; // 0x10
	public string ModuleName; // 0x18
	public string Description; // 0x20
	public bool UsesRandom; // 0x28

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string name) { }

	// RVA: 0x50BA70 Offset: 0x50A470 VA: 0x18050BA70 Slot: 7
	public int CompareTo(object obj) { }
}
