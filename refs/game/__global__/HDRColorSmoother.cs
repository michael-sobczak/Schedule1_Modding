public class HDRColorSmoother // TypeDefIndex: 2302
{
	// Fields
	[CompilerGenerated]
	private Color <CurrentValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <Multiplier>k__BackingField; // 0x20
	[ColorUsage(True, True)]
	[SerializeField]
	private Color DefaultValue; // 0x24
	[SerializeField]
	private float SmoothingSpeed; // 0x34
	[SerializeField]
	private List<HDRColorSmoother.Override> overrides; // 0x38
	private HDRColorSmoother.Override activeOverride; // 0x40
	private bool isBeingUpdated; // 0x48

	// Properties
	public Color CurrentValue { get; set; }
	public float Multiplier { get; set; }

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

	// RVA: 0x841620 Offset: 0x840020 VA: 0x180841620
	public void Initialize() { }

	// RVA: 0x841A00 Offset: 0x840400 VA: 0x180841A00
	public void SetDefault(Color value) { }

	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	public void SetMultiplier(float value) { }

	// RVA: 0x841200 Offset: 0x83FC00 VA: 0x180841200
	public void AddOverride(Color value, int priority, string label) { }

	// RVA: 0x841690 Offset: 0x840090 VA: 0x180841690
	public void RemoveOverride(string label) { }

	// RVA: 0x83F330 Offset: 0x83DD30 VA: 0x18083F330
	public void Update() { }

	// RVA: 0x841A70 Offset: 0x840470 VA: 0x180841A70
	public void .ctor() { }
}
