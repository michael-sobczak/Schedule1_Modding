public class AlternativePath : MonoModifier // TypeDefIndex: 13285
{
	// Fields
	public int penalty; // 0x30
	public int randomStep; // 0x34
	private List<GraphNode> prevNodes; // 0x38
	private int prevPenalty; // 0x40
	private readonly Random rnd; // 0x48
	private bool destroyed; // 0x50

	// Properties
	public override int Order { get; }

	// Methods

	// RVA: 0xA2A280 Offset: 0xA28C80 VA: 0x180A2A280 Slot: 15
	public override int get_Order() { }

	// RVA: 0xB64AF0 Offset: 0xB634F0 VA: 0x180B64AF0 Slot: 17
	public override void Apply(Path p) { }

	// RVA: 0xB64D00 Offset: 0xB63700 VA: 0x180B64D00
	protected void OnDestroy() { }

	// RVA: 0xB64B70 Offset: 0xB63570 VA: 0x180B64B70
	private void ClearOnDestroy() { }

	// RVA: 0xB64B80 Offset: 0xB63580 VA: 0x180B64B80
	private void InversePrevious() { }

	// RVA: 0xB648F0 Offset: 0xB632F0 VA: 0x180B648F0
	private void ApplyNow(List<GraphNode> nodes) { }

	// RVA: 0xB64D10 Offset: 0xB63710 VA: 0x180B64D10
	public void .ctor() { }
}
