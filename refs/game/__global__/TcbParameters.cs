public struct TcbParameters : IEquatable<TcbParameters> // TypeDefIndex: 10552
{
	// Fields
	[CompilerGenerated]
	private float <StartTension>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <EndTension>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <StartContinuity>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <EndContinuity>k__BackingField; // 0xC
	[CompilerGenerated]
	private float <StartBias>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <EndBias>k__BackingField; // 0x14

	// Properties
	public float StartTension { get; set; }
	public float EndTension { get; set; }
	public float StartContinuity { get; set; }
	public float EndContinuity { get; set; }
	public float StartBias { get; set; }
	public float EndBias { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x474780 Offset: 0x473180 VA: 0x180474780
	public float get_StartTension() { }

	[CompilerGenerated]
	// RVA: 0x4D53B0 Offset: 0x4D3DB0 VA: 0x1804D53B0
	public void set_StartTension(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	public float get_EndTension() { }

	[CompilerGenerated]
	// RVA: 0x4D5390 Offset: 0x4D3D90 VA: 0x1804D5390
	public void set_EndTension(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	public float get_StartContinuity() { }

	[CompilerGenerated]
	// RVA: 0x4D53A0 Offset: 0x4D3DA0 VA: 0x1804D53A0
	public void set_StartContinuity(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x474790 Offset: 0x473190 VA: 0x180474790
	public float get_EndContinuity() { }

	[CompilerGenerated]
	// RVA: 0x4D5380 Offset: 0x4D3D80 VA: 0x1804D5380
	public void set_EndContinuity(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4747B0 Offset: 0x4731B0 VA: 0x1804747B0
	public float get_StartBias() { }

	[CompilerGenerated]
	// RVA: 0x4944E0 Offset: 0x492EE0 VA: 0x1804944E0
	public void set_StartBias(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_EndBias() { }

	[CompilerGenerated]
	// RVA: 0x474920 Offset: 0x473320 VA: 0x180474920
	public void set_EndBias(float value) { }

	// RVA: 0x4D5130 Offset: 0x4D3B30 VA: 0x1804D5130 Slot: 4
	public bool Equals(TcbParameters other) { }

	// RVA: 0x4D5090 Offset: 0x4D3A90 VA: 0x1804D5090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D5220 Offset: 0x4D3C20 VA: 0x1804D5220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4D5320 Offset: 0x4D3D20 VA: 0x1804D5320
	public static bool op_Equality(TcbParameters left, TcbParameters right) { }

	// RVA: 0x4D5350 Offset: 0x4D3D50 VA: 0x1804D5350
	public static bool op_Inequality(TcbParameters left, TcbParameters right) { }
}
