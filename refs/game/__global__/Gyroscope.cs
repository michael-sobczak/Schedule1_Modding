public class Gyroscope : Sensor // TypeDefIndex: 7408
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <angularVelocity>k__BackingField; // 0x190
	[CompilerGenerated]
	private static Gyroscope <current>k__BackingField; // 0x0

	// Properties
	public Vector3Control angularVelocity { get; set; }
	public static Gyroscope current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector3Control get_angularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_angularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2808300 Offset: 0x2806D00 VA: 0x182808300
	public static Gyroscope get_current() { }

	[CompilerGenerated]
	// RVA: 0x2808340 Offset: 0x2806D40 VA: 0x182808340
	private static void set_current(Gyroscope value) { }

	// RVA: 0x2808210 Offset: 0x2806C10 VA: 0x182808210 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2808270 Offset: 0x2806C70 VA: 0x182808270 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28081A0 Offset: 0x2806BA0 VA: 0x1828081A0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
