public class LinearAccelerationSensor : Sensor // TypeDefIndex: 7411
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <acceleration>k__BackingField; // 0x190
	[CompilerGenerated]
	private static LinearAccelerationSensor <current>k__BackingField; // 0x0

	// Properties
	public Vector3Control acceleration { get; set; }
	public static LinearAccelerationSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector3Control get_acceleration() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_acceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2819010 Offset: 0x2817A10 VA: 0x182819010
	public static LinearAccelerationSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2819050 Offset: 0x2817A50 VA: 0x182819050
	private static void set_current(LinearAccelerationSensor value) { }

	// RVA: 0x2818F20 Offset: 0x2817920 VA: 0x182818F20 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2818F80 Offset: 0x2817980 VA: 0x182818F80 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x2818EB0 Offset: 0x28178B0 VA: 0x182818EB0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
