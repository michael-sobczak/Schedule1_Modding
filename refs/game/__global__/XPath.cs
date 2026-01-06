public class XPath : ABPath // TypeDefIndex: 13322
{
	// Fields
	public PathEndingCondition endingCondition; // 0x138

	// Methods

	// RVA: 0xB9CD10 Offset: 0xB9B710 VA: 0x180B9CD10
	public void .ctor() { }

	// RVA: 0xB9CBE0 Offset: 0xB9B5E0 VA: 0x180B9CBE0
	public static XPath Construct(Vector3 start, Vector3 end, OnPathDelegate callback) { }

	// RVA: 0xB80060 Offset: 0xB7EA60 VA: 0x180B80060 Slot: 20
	protected override void Reset() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	protected override bool EndPointGridGraphSpecialCase(GraphNode endNode) { }

	// RVA: 0xB9CB40 Offset: 0xB9B540 VA: 0x180B9CB40 Slot: 30
	protected override void CompletePathIfStartIsValidTarget() { }

	// RVA: 0xB9CA60 Offset: 0xB9B460 VA: 0x180B9CA60
	private void ChangeEndNode(GraphNode target) { }

	// RVA: 0xB9C7E0 Offset: 0xB9B1E0 VA: 0x180B9C7E0 Slot: 27
	protected override void CalculateStep(long targetTick) { }
}
