internal struct SampleFrequencyCalculator // TypeDefIndex: 7602
{
	// Fields
	private double m_LastUpdateTime; // 0x0
	private int m_SampleCount; // 0x8
	[CompilerGenerated]
	private float <targetFrequency>k__BackingField; // 0xC
	[CompilerGenerated]
	private float <frequency>k__BackingField; // 0x10

	// Properties
	public float targetFrequency { get; set; }
	public float frequency { get; set; }

	// Methods

	// RVA: 0x2865F30 Offset: 0x2864930 VA: 0x182865F30
	public void .ctor(float targetFrequency, double realtimeSinceStartup) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_targetFrequency() { }

	[CompilerGenerated]
	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	private void set_targetFrequency(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_frequency() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	private void set_frequency(float value) { }

	// RVA: 0x2865E80 Offset: 0x2864880 VA: 0x182865E80
	public void ProcessSample(InputEventPtr eventPtr) { }

	// RVA: 0x2865ED0 Offset: 0x28648D0 VA: 0x182865ED0
	public bool Update() { }

	// RVA: 0x2865E90 Offset: 0x2864890 VA: 0x182865E90
	public bool Update(double realtimeSinceStartup) { }
}
