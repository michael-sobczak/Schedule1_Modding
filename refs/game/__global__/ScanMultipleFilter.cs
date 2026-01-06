internal class ScanMultipleFilter : PathFilter // TypeDefIndex: 11388
{
	// Fields
	private List<string> _names; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(ScanMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DE6830 Offset: 0x1DE5230 VA: 0x181DE6830 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
