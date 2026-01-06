public class Hash128Field : TextInputBaseField<Hash128> // TypeDefIndex: 6310
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Properties
	public override Hash128 value { get; set; }

	// Methods

	// RVA: 0x2DD27E0 Offset: 0x2DD11E0 VA: 0x182DD27E0
	public void .ctor() { }

	// RVA: 0x2DD2500 Offset: 0x2DD0F00 VA: 0x182DD2500
	public void .ctor(string label, int maxLength = -1) { }

	// RVA: 0x2DD27F0 Offset: 0x2DD11F0 VA: 0x182DD27F0 Slot: 107
	public override Hash128 get_value() { }

	// RVA: 0x2DD2850 Offset: 0x2DD1250 VA: 0x182DD2850 Slot: 108
	public override void set_value(Hash128 value) { }

	// RVA: 0x2DD22F0 Offset: 0x2DD0CF0 VA: 0x182DD22F0 Slot: 121
	internal override void UpdateValueFromText() { }

	// RVA: 0x2DD2260 Offset: 0x2DD0C60 VA: 0x182DD2260 Slot: 122
	internal override void UpdateTextFromValue() { }

	// RVA: 0x2DD2100 Offset: 0x2DD0B00 VA: 0x182DD2100 Slot: 118
	public override void SetValueWithoutNotify(Hash128 newValue) { }

	// RVA: 0x2DD23C0 Offset: 0x2DD0DC0 VA: 0x182DD23C0 Slot: 119
	protected override string ValueToString(Hash128 value) { }

	// RVA: 0x2DD21C0 Offset: 0x2DD0BC0 VA: 0x182DD21C0 Slot: 120
	protected override Hash128 StringToValue(string str) { }

	[EventInterest(new[] { typeof(BlurEvent) })]
	// RVA: 0x2DD1F60 Offset: 0x2DD0960 VA: 0x182DD1F60 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2DD23E0 Offset: 0x2DD0DE0 VA: 0x182DD23E0
	private static void .cctor() { }
}
