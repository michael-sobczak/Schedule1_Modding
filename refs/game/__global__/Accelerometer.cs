public class Accelerometer : Sensor // TypeDefIndex: 7407
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <acceleration>k__BackingField; // 0x190
	[CompilerGenerated]
	private static Accelerometer <current>k__BackingField; // 0x0

	// Properties
	public Vector3Control acceleration { get; set; }
	public static Accelerometer current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector3Control get_acceleration() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_acceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2800F00 Offset: 0x27FF900 VA: 0x182800F00
	public static Accelerometer get_current() { }

	[CompilerGenerated]
	// RVA: 0x2800F40 Offset: 0x27FF940 VA: 0x182800F40
	private static void set_current(Accelerometer value) { }

	// RVA: 0x2800E10 Offset: 0x27FF810 VA: 0x182800E10 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2800E70 Offset: 0x27FF870 VA: 0x182800E70 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x2800DA0 Offset: 0x27FF7A0 VA: 0x182800DA0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
