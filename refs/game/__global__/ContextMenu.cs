public sealed class ContextMenu : Attribute // TypeDefIndex: 11799
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x2CBB7A0 Offset: 0x2CBA1A0 VA: 0x182CBB7A0
	public void .ctor(string itemName) { }

	// RVA: 0x2CBB750 Offset: 0x2CBA150 VA: 0x182CBB750
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x2CBB6F0 Offset: 0x2CBA0F0 VA: 0x182CBB6F0
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }
}
