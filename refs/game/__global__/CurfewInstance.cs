public class CurfewInstance // TypeDefIndex: 1300
{
	// Fields
	public static CurfewInstance ActiveInstance; // 0x0
	[Range(1, 10)]
	public int IntensityRequirement; // 0x10
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x14
	[HideInInspector]
	public bool shouldDisable; // 0x15

	// Properties
	public bool Enabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	protected void set_Enabled(bool value) { }

	// RVA: 0x60D580 Offset: 0x60BF80 VA: 0x18060D580
	public void Evaluate(bool ignoreSleepReq = False) { }

	// RVA: 0x60D650 Offset: 0x60C050 VA: 0x18060D650
	private void MinPass() { }

	// RVA: 0x60D3E0 Offset: 0x60BDE0 VA: 0x18060D3E0
	public void Enable() { }

	// RVA: 0x60D170 Offset: 0x60BB70 VA: 0x18060D170
	public void Disable() { }

	// RVA: 0x60D720 Offset: 0x60C120 VA: 0x18060D720
	public void .ctor() { }
}
