public class AudioZone : Zone // TypeDefIndex: 2136
{
	// Fields
	public const float VOLUME_CHANGE_RATE = 1;
	public const float ROLLOFF_SCALE = 0.5;
	[CompilerGenerated]
	private float <LocalPlayerDistance>k__BackingField; // 0x48
	[Range(1, 200)]
	[Header("Settings")]
	public float MaxDistance; // 0x4C
	public List<AudioZone.Track> Tracks; // 0x50
	public Dictionary<AudioZoneModifierVolume, float> Modifiers; // 0x58
	[CompilerGenerated]
	private float <VolumeModifier>k__BackingField; // 0x60
	protected float CurrentVolumeMultiplier; // 0x64

	// Properties
	public float LocalPlayerDistance { get; set; }
	public float VolumeModifier { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_LocalPlayerDistance() { }

	[CompilerGenerated]
	// RVA: 0x810830 Offset: 0x80F230 VA: 0x180810830
	protected void set_LocalPlayerDistance(float value) { }

	[CompilerGenerated]
	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_VolumeModifier() { }

	[CompilerGenerated]
	// RVA: 0x810840 Offset: 0x80F240 VA: 0x180810840
	public void set_VolumeModifier(float value) { }

	// RVA: 0x80F7C0 Offset: 0x80E1C0 VA: 0x18080F7C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x810100 Offset: 0x80EB00 VA: 0x180810100
	private void Start() { }

	// RVA: 0x80FC10 Offset: 0x80E610 VA: 0x18080FC10
	public void Recalculate() { }

	// RVA: 0x810390 Offset: 0x80ED90 VA: 0x180810390
	private void Update() { }

	// RVA: 0x80F860 Offset: 0x80E260 VA: 0x18080F860
	private float GetTotalVolumeMultiplier() { }

	// RVA: 0x80F9B0 Offset: 0x80E3B0 VA: 0x18080F9B0
	private void MinPass() { }

	// RVA: 0x80F700 Offset: 0x80E100 VA: 0x18080F700
	public void AddModifier(AudioZoneModifierVolume modifier, float value) { }

	// RVA: 0x810080 Offset: 0x80EA80 VA: 0x180810080
	public void RemoveModifier(AudioZoneModifierVolume modifier) { }

	// RVA: 0x80F830 Offset: 0x80E230 VA: 0x18080F830
	private float GetFalloffFactor(float distance) { }

	// RVA: 0x810740 Offset: 0x80F140 VA: 0x180810740
	public void .ctor() { }
}
