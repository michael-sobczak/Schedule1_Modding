public class CharacterInterface : MonoBehaviour // TypeDefIndex: 2577
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	public ClothingSlotUI[] ClothingSlots; // 0x28
	public RectTransform Container; // 0x30
	public Slider RotationSlider; // 0x38
	private Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints; // 0x40

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x8DA230 Offset: 0x8D8C30 VA: 0x1808DA230
	private void Awake() { }

	// RVA: 0x8DA270 Offset: 0x8D8C70 VA: 0x1808DA270
	private void LateUpdate() { }

	// RVA: 0x8DA4A0 Offset: 0x8D8EA0 VA: 0x1808DA4A0
	public void Open() { }

	// RVA: 0x8DA230 Offset: 0x8D8C30 VA: 0x1808DA230
	public void Close() { }

	// RVA: 0x8DA810 Offset: 0x8D9210 VA: 0x1808DA810
	public void .ctor() { }
}
