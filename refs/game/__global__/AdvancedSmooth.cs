public class AdvancedSmooth : MonoModifier // TypeDefIndex: 13284
{
	// Fields
	public float turningRadius; // 0x30
	public AdvancedSmooth.MaxTurn turnConstruct1; // 0x38
	public AdvancedSmooth.ConstantTurn turnConstruct2; // 0x40

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0xB648E0 Offset: 0xB632E0 VA: 0x180B648E0 Slot: 15
	public override int get_Order() { }

	// RVA: 0xB64180 Offset: 0xB62B80 VA: 0x180B64180 Slot: 17
	public override void Apply(Path p) { }

	// RVA: 0xB645C0 Offset: 0xB62FC0 VA: 0x180B645C0
	private void EvaluatePaths(List<AdvancedSmooth.Turn> turnList, List<Vector3> output) { }

	// RVA: 0xB64750 Offset: 0xB63150 VA: 0x180B64750
	public void .ctor() { }
}
