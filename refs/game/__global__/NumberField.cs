public class NumberField : ConfigField // TypeDefIndex: 1216
{
	// Fields
	[CompilerGenerated]
	private float <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <MinValue>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <MaxValue>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <WholeNumbers>k__BackingField; // 0x24
	public UnityEvent<float> onItemChanged; // 0x28

	// Properties
	public float Value { get; set; }
	public float MinValue { get; set; }
	public float MaxValue { get; set; }
	public bool WholeNumbers { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x54BD70 Offset: 0x54A770 VA: 0x18054BD70
	public float get_Value() { }

	[CompilerGenerated]
	// RVA: 0x61B4E0 Offset: 0x619EE0 VA: 0x18061B4E0
	protected void set_Value(float value) { }

	[CompilerGenerated]
	// RVA: 0x498A60 Offset: 0x497460 VA: 0x180498A60
	public float get_MinValue() { }

	[CompilerGenerated]
	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	protected void set_MinValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_MaxValue() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	protected void set_MaxValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_WholeNumbers() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	protected void set_WholeNumbers(bool value) { }

	// RVA: 0x61B450 Offset: 0x619E50 VA: 0x18061B450
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x61B3C0 Offset: 0x619DC0 VA: 0x18061B3C0
	public void SetValue(float value, bool network) { }

	// RVA: 0x61B2B0 Offset: 0x619CB0 VA: 0x18061B2B0
	public void Configure(float minValue, float maxValue, bool wholeNumbers) { }

	// RVA: 0x61B320 Offset: 0x619D20 VA: 0x18061B320 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x61B2C0 Offset: 0x619CC0 VA: 0x18061B2C0
	public NumberFieldData GetData() { }

	// RVA: 0x61B340 Offset: 0x619D40 VA: 0x18061B340
	public void Load(NumberFieldData data) { }
}
