public class BoilingFlask : Fillable // TypeDefIndex: 2412
{
	// Fields
	public const float TEMPERATURE_MAX = 500;
	public float TEMPERATURE_MAX_VELOCITY; // 0x38
	public float TEMPERATURE_ACCELERATION; // 0x3C
	public const float OVERHEAT_TIME = 1.25;
	[CompilerGenerated]
	private float <CurrentTemperature>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <CurrentTemperatureVelocity>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <OverheatScale>k__BackingField; // 0x48
	[CompilerGenerated]
	private StationRecipe <Recipe>k__BackingField; // 0x50
	public bool LockTemperature; // 0x58
	public AnimationCurve BoilSoundPitchCurve; // 0x60
	public float LabelJitterScale; // 0x68
	[Header("References")]
	public BunsenBurner Burner; // 0x70
	public Canvas TemperatureCanvas; // 0x78
	public TextMeshProUGUI TemperatureLabel; // 0x80
	public Slider TemperatureSlider; // 0x88
	public RectTransform TemperatureRangeIndicator; // 0x90
	public ParticleSystem SmokeParticles; // 0x98
	public AudioSourceController BoilSound; // 0xA0
	public MeshRenderer OverheatMesh; // 0xA8

	// Properties
	public float CurrentTemperature { get; set; }
	public float CurrentTemperatureVelocity { get; set; }
	public bool IsTemperatureInRange { get; }
	public float OverheatScale { get; set; }
	public StationRecipe Recipe { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_CurrentTemperature() { }

	[CompilerGenerated]
	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	private void set_CurrentTemperature(float value) { }

	[CompilerGenerated]
	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_CurrentTemperatureVelocity() { }

	[CompilerGenerated]
	// RVA: 0x49D340 Offset: 0x49BD40 VA: 0x18049D340
	private void set_CurrentTemperatureVelocity(float value) { }

	// RVA: 0x870C90 Offset: 0x86F690 VA: 0x180870C90
	public bool get_IsTemperatureInRange() { }

	[CompilerGenerated]
	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_OverheatScale() { }

	[CompilerGenerated]
	// RVA: 0x810830 Offset: 0x80F230 VA: 0x180810830
	private void set_OverheatScale(float value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public StationRecipe get_Recipe() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	private void set_Recipe(StationRecipe value) { }

	// RVA: 0x870730 Offset: 0x86F130 VA: 0x180870730
	public void Update() { }

	// RVA: 0x86FF00 Offset: 0x86E900 VA: 0x18086FF00
	private void FixedUpdate() { }

	// RVA: 0x870220 Offset: 0x86EC20 VA: 0x180870220
	private void UpdateCanvas() { }

	// RVA: 0x8705A0 Offset: 0x86EFA0 VA: 0x1808705A0
	private void UpdateSmoke() { }

	// RVA: 0x8700A0 Offset: 0x86EAA0 VA: 0x1808700A0
	public void SetCanvasVisible(bool visible) { }

	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	public void SetTemperature(float temp) { }

	// RVA: 0x8700E0 Offset: 0x86EAE0 VA: 0x1808700E0
	public void SetRecipe(StationRecipe recipe) { }

	// RVA: 0x870BF0 Offset: 0x86F5F0 VA: 0x180870BF0
	public void .ctor() { }
}
