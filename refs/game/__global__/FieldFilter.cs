internal class FieldFilter : PathFilter // TypeDefIndex: 11370
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(FieldFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DD73D0 Offset: 0x1DD5DD0 VA: 0x181DD73D0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
