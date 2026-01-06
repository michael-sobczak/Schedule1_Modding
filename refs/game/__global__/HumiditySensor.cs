public class HumiditySensor : Sensor // TypeDefIndex: 7416
{
	// Fields
	[CompilerGenerated]
	private AxisControl <relativeHumidity>k__BackingField; // 0x190
	[CompilerGenerated]
	private static HumiditySensor <current>k__BackingField; // 0x0

	// Properties
	[InputControl(displayName = "Relative Humidity", noisy = True)]
	public AxisControl relativeHumidity { get; set; }
	public static HumiditySensor current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public AxisControl get_relativeHumidity() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_relativeHumidity(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x2808700 Offset: 0x2807100 VA: 0x182808700
	public static HumiditySensor get_current() { }

	[CompilerGenerated]
	// RVA: 0x2808740 Offset: 0x2807140 VA: 0x182808740
	private static void set_current(HumiditySensor value) { }

	// RVA: 0x2808610 Offset: 0x2807010 VA: 0x182808610 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x2808670 Offset: 0x2807070 VA: 0x182808670 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x28085A0 Offset: 0x2806FA0 VA: 0x1828085A0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
