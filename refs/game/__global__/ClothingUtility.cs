public class ClothingUtility : Singleton<ClothingUtility> // TypeDefIndex: 2008
{
	// Fields
	public List<ClothingUtility.ColorData> ColorDataList; // 0x28
	public List<ClothingUtility.ClothingSlotData> ClothingSlotDataList; // 0x30

	// Methods

	// RVA: 0x7CFC20 Offset: 0x7CE620 VA: 0x1807CFC20 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7D0180 Offset: 0x7CEB80 VA: 0x1807D0180
	private void OnValidate() { }

	// RVA: 0x7CFFE0 Offset: 0x7CE9E0 VA: 0x1807CFFE0
	public ClothingUtility.ColorData GetColorData(EClothingColor color) { }

	// RVA: 0x7D00B0 Offset: 0x7CEAB0 VA: 0x1807D00B0
	public ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot) { }

	// RVA: 0x7D08D0 Offset: 0x7CF2D0 VA: 0x1807D08D0
	public void .ctor() { }
}
