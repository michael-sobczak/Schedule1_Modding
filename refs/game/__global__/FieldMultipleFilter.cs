internal class FieldMultipleFilter : PathFilter // TypeDefIndex: 11373
{
	// Fields
	internal List<string> Names; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(FieldMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DD7480 Offset: 0x1DD5E80 VA: 0x181DD7480 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
