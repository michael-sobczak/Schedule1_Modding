public class AttitudeSensor : Sensor // TypeDefIndex: 7410
{
	// Fields
	[CompilerGenerated]
	private QuaternionControl <attitude>k__BackingField; // 0x190
	[CompilerGenerated]
	private static AttitudeSensor <current>k__BackingField; // 0x0

	// Properties
	public QuaternionControl attitude { get; set; }
	public static AttitudeSensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public QuaternionControl get_attitude() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_attitude(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x2801300 Offset: 0x27FFD00 VA: 0x182801300
	public static AttitudeSensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2801340 Offset: 0x27FFD40 VA: 0x182801340
	private static void set_current(AttitudeSensor value) { }

	// RVA: 0x2801210 Offset: 0x27FFC10 VA: 0x182801210 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2801270 Offset: 0x27FFC70 VA: 0x182801270 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28011A0 Offset: 0x27FFBA0 VA: 0x1828011A0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
