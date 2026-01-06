public class CookableModule : ItemModule // TypeDefIndex: 2414
{
	// Fields
	[Header("Cook Settings")]
	public int CookTime; // 0x30
	public CookableModule.ECookableType CookType; // 0x34
	[Header("Product Settings")]
	public StorableItemDefinition Product; // 0x38
	public int ProductQuantity; // 0x40
	public Rigidbody ProductShardPrefab; // 0x48
	[Header("Appearance")]
	public Color LiquidColor; // 0x50
	public Color SolidColor; // 0x60

	// Methods

	// RVA: 0x870D50 Offset: 0x86F750 VA: 0x180870D50
	public void .ctor() { }
}
