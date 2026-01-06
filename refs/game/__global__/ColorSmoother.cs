public class ColorSmoother // TypeDefIndex: 2279
{
	// Fields
	[CompilerGenerated]
	private Color <CurrentValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <Multiplier>k__BackingField; // 0x20
	[SerializeField]
	private Color DefaultValue; // 0x24
	[SerializeField]
	private float SmoothingSpeed; // 0x34
	[SerializeField]
	private List<ColorSmoother.Override> overrides; // 0x38
	private ColorSmoother.Override activeOverride; // 0x40

	// Properties
	public Color CurrentValue { get; set; }
	public float Multiplier { get; set; }
	public Color Default { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	public Color get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x49CD50 Offset: 0x49B750 VA: 0x18049CD50
	private void set_CurrentValue(Color value) { }

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_Multiplier() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	private void set_Multiplier(float value) { }

	// RVA: 0x83F4E0 Offset: 0x83DEE0 VA: 0x18083F4E0
	public Color get_Default() { }

	// RVA: 0x83EEE0 Offset: 0x83D8E0 VA: 0x18083EEE0
	public void Initialize() { }

	// RVA: 0x83F2C0 Offset: 0x83DCC0 VA: 0x18083F2C0
	public void SetDefault(Color value) { }

	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void SetMultiplier(float value) { }

	// RVA: 0x83EAC0 Offset: 0x83D4C0 VA: 0x18083EAC0
	public void AddOverride(Color value, int priority, string label) { }

	// RVA: 0x83EF50 Offset: 0x83D950 VA: 0x18083EF50
	public void RemoveOverride(string label) { }

	// RVA: 0x83F330 Offset: 0x83DD30 VA: 0x18083F330
	public void Update() { }

	// RVA: 0x83F440 Offset: 0x83DE40 VA: 0x18083F440
	public void .ctor() { }
}
