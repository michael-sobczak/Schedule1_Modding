internal class ScanFilter : PathFilter // TypeDefIndex: 11386
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ScanFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1DE67A0 Offset: 0x1DE51A0 VA: 0x181DE67A0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}
