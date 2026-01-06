public class BoundsField : BaseField<Bounds> // TypeDefIndex: 6241
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string centerFieldUssClassName; // 0x18
	public static readonly string extentsFieldUssClassName; // 0x20
	private Vector3Field m_CenterField; // 0x458
	private Vector3Field m_ExtentsField; // 0x460

	// Methods

	// RVA: 0x2DC96C0 Offset: 0x2DC80C0 VA: 0x182DC96C0
	public void .ctor() { }

	// RVA: 0x2DC92D0 Offset: 0x2DC7CD0 VA: 0x182DC92D0
	public void .ctor(string label) { }

	// RVA: 0x2DC8DF0 Offset: 0x2DC77F0 VA: 0x182DC8DF0 Slot: 118
	public override void SetValueWithoutNotify(Bounds newValue) { }

	// RVA: 0x2DC9080 Offset: 0x2DC7A80 VA: 0x182DC9080 Slot: 117
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x2DC9100 Offset: 0x2DC7B00 VA: 0x182DC9100
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2DC8F10 Offset: 0x2DC7910 VA: 0x182DC8F10
	private void <.ctor>b__10_0(ChangeEvent<Vector3> e) { }

	[CompilerGenerated]
	// RVA: 0x2DC8FC0 Offset: 0x2DC79C0 VA: 0x182DC8FC0
	private void <.ctor>b__10_1(ChangeEvent<Vector3> e) { }
}
