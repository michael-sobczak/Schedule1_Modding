internal abstract class PathFilter // TypeDefIndex: 11375
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings);

	// RVA: 0x1DE54C0 Offset: 0x1DE3EC0 VA: 0x181DE54C0
	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

	// RVA: 0x1DE53F0 Offset: 0x1DE3DF0 VA: 0x181DE53F0
	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
