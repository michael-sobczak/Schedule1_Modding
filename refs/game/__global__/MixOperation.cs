public class MixOperation // TypeDefIndex: 3267
{
	// Fields
	public string ProductID; // 0x10
	public EQuality ProductQuality; // 0x18
	public string IngredientID; // 0x20
	public int Quantity; // 0x28

	// Methods

	// RVA: 0xA21430 Offset: 0xA1FE30 VA: 0x180A21430
	public void .ctor(string productID, EQuality productQuality, string ingredientID, int quantity) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xA210A0 Offset: 0xA1FAA0 VA: 0x180A210A0
	public EDrugType GetOutput(out List<Effect> properties) { }

	// RVA: 0xA21340 Offset: 0xA1FD40 VA: 0x180A21340
	public bool IsOutputKnown(out ProductDefinition knownProduct) { }
}
