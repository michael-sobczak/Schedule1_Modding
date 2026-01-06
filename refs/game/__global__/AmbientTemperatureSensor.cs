public class AmbientTemperatureSensor : Sensor // TypeDefIndex: 7417
{
	// Fields
	[CompilerGenerated]
	private AxisControl <ambientTemperature>k__BackingField; // 0x190
	[CompilerGenerated]
	private static AmbientTemperatureSensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Ambient Temperature", noisy = True)]
	public AxisControl ambientTemperature { get; set; }
	public static AmbientTemperatureSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_ambientTemperature() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_ambientTemperature(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x2801100 Offset: 0x27FFB00 VA: 0x182801100
	public static AmbientTemperatureSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2801140 Offset: 0x27FFB40 VA: 0x182801140
	private static void set_current(AmbientTemperatureSensor value) { }

	// RVA: 0x2801010 Offset: 0x27FFA10 VA: 0x182801010 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2801070 Offset: 0x27FFA70 VA: 0x182801070 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x2800FA0 Offset: 0x27FF9A0 VA: 0x182800FA0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
