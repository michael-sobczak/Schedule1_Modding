public class DryingOperation // TypeDefIndex: 3246
{
	// Fields
	public string ItemID; // 0x10
	public int Quantity; // 0x18
	public EQuality StartQuality; // 0x1C
	public int Time; // 0x20

	// Methods

	// RVA: 0xA0B1D0 Offset: 0xA09BD0 VA: 0x180A0B1D0
	public void .ctor(string itemID, int quantity, EQuality startQuality, int time) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xA0B1C0 Offset: 0xA09BC0 VA: 0x180A0B1C0
	public void IncreaseQuality() { }

	// RVA: 0xA0B0F0 Offset: 0xA09AF0 VA: 0x180A0B0F0
	public QualityItemInstance GetQualityItemInstance() { }

	// RVA: 0xA0B1A0 Offset: 0xA09BA0 VA: 0x180A0B1A0
	public EQuality GetQuality() { }
}
