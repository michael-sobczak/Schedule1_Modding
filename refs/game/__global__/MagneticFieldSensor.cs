public class MagneticFieldSensor : Sensor // TypeDefIndex: 7412
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <magneticField>k__BackingField; // 0x190
	[CompilerGenerated]
	private static MagneticFieldSensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Magnetic Field", noisy = True)]
	public Vector3Control magneticField { get; set; }
	public static MagneticFieldSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector3Control get_magneticField() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_magneticField(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2819210 Offset: 0x2817C10 VA: 0x182819210
	public static MagneticFieldSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2819250 Offset: 0x2817C50 VA: 0x182819250
	private static void set_current(MagneticFieldSensor value) { }

	// RVA: 0x2819120 Offset: 0x2817B20 VA: 0x182819120 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2819180 Offset: 0x2817B80 VA: 0x182819180 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28190B0 Offset: 0x2817AB0 VA: 0x1828190B0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
