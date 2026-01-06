internal class ObjectHolderListEnumerator // TypeDefIndex: 4440
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x1B49B40 Offset: 0x1B48540 VA: 0x181B49B40
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x1B49AB0 Offset: 0x1B484B0 VA: 0x181B49AB0
	internal bool MoveNext() { }

	// RVA: 0x1B49BA0 Offset: 0x1B485A0 VA: 0x181B49BA0
	internal ObjectHolder get_Current() { }
}
