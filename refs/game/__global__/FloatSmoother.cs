public class FloatSmoother // TypeDefIndex: 2295
{
	// Fields
	[CompilerGenerated]
	private float <CurrentValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <Multiplier>k__BackingField; // 0x14
	[SerializeField]
	private float DefaultValue; // 0x18
	[SerializeField]
	private float SmoothingSpeed; // 0x1C
	private List<FloatSmoother.Override> overrides; // 0x20
	private FloatSmoother.Override activeOverride; // 0x28

	// Properties
	public float CurrentValue { get; set; }
	public float Multiplier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	private void set_CurrentValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_Multiplier() { }

	[CompilerGenerated]
	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	private void set_Multiplier(float value) { }

	// RVA: 0x840B70 Offset: 0x83F570 VA: 0x180840B70
	public void Initialize() { }

	// RVA: 0x840F40 Offset: 0x83F940 VA: 0x180840F40
	public void SetDefault(float value, bool apply = True) { }

	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	public void SetMultiplier(float value) { }

	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	public void SetSmoothingSpeed(float value) { }

	// RVA: 0x840750 Offset: 0x83F150 VA: 0x180840750
	public void AddOverride(float value, int priority, string label) { }

	// RVA: 0x840BD0 Offset: 0x83F5D0 VA: 0x180840BD0
	public void RemoveOverride(string label) { }

	// RVA: 0x840FB0 Offset: 0x83F9B0 VA: 0x180840FB0
	public void Update() { }

	// RVA: 0x841040 Offset: 0x83FA40 VA: 0x180841040
	public void .ctor() { }
}
