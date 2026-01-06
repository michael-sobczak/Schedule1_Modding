public class PlayerEnergyUI : Singleton<PlayerEnergyUI> // TypeDefIndex: 2677
{
	// Fields
	public Slider Slider; // 0x28
	public RectTransform SliderRect; // 0x30
	public Image FillImage; // 0x38
	public TextMeshProUGUI Label; // 0x40
	[Header("Settings")]
	public Color SliderColor_Green; // 0x48
	public Color SliderColor_Red; // 0x58
	private float displayedValue; // 0x68

	// Methods

	// RVA: 0x900500 Offset: 0x8FEF00 VA: 0x180900500 Slot: 5
	protected override void Awake() { }

	// RVA: 0x9008A0 Offset: 0x8FF2A0 VA: 0x1809008A0
	private void UpdateDisplayedEnergy() { }

	// RVA: 0x900650 Offset: 0x8FF050 VA: 0x180900650
	public void SetDisplayedEnergy(float energy) { }

	// RVA: 0x900990 Offset: 0x8FF390 VA: 0x180900990 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x900CF0 Offset: 0x8FF6F0 VA: 0x180900CF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x9006E0 Offset: 0x8FF0E0 VA: 0x1809006E0
	private void <Awake>b__7_0() { }
}
