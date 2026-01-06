internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 4655
{
	// Fields
	private CultureInfo m_startingCulture; // 0x10
	private CultureInfo m_neutralResourcesCulture; // 0x18
	private bool m_useParents; // 0x20

	// Methods

	// RVA: 0x1B6B0A0 Offset: 0x1B69AA0 VA: 0x181B6B0A0
	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	// RVA: 0x1B6B030 Offset: 0x1B69A30 VA: 0x181B6B030 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ResourceFallbackManager.<GetEnumerator>d__5))]
	// RVA: 0x1B6B030 Offset: 0x1B69A30 VA: 0x181B6B030 Slot: 4
	public IEnumerator<CultureInfo> GetEnumerator() { }
}
