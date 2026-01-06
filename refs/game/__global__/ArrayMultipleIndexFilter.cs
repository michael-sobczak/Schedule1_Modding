internal class ArrayMultipleIndexFilter : PathFilter // TypeDefIndex: 11366
{
	// Fields
	internal List<int> Indexes; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(List<int> indexes) { }

	[IteratorStateMachine(typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DD0A20 Offset: 0x1DCF420 VA: 0x181DD0A20 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
