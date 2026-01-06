public class GravitySensor : Sensor // TypeDefIndex: 7409
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <gravity>k__BackingField; // 0x190
	[CompilerGenerated]
	private static GravitySensor <current>k__BackingField; // 0x0

	// Properties
	public Vector3Control gravity { get; set; }
	public static GravitySensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector3Control get_gravity() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_gravity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2808100 Offset: 0x2806B00 VA: 0x182808100
	public static GravitySensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2808140 Offset: 0x2806B40 VA: 0x182808140
	private static void set_current(GravitySensor value) { }

	// RVA: 0x2807FA0 Offset: 0x28069A0 VA: 0x182807FA0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2808010 Offset: 0x2806A10 VA: 0x182808010 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2808070 Offset: 0x2806A70 VA: 0x182808070 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
