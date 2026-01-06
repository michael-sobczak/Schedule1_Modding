public abstract class Manipulator : IManipulator // TypeDefIndex: 6704
{
	// Fields
	private VisualElement m_Target; // 0x10

	// Properties
	public VisualElement target { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void RegisterCallbacksOnTarget();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void UnregisterCallbacksFromTarget();

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270 Slot: 7
	public VisualElement get_target() { }

	// RVA: 0x2EAA800 Offset: 0x2EA9200 VA: 0x182EAA800 Slot: 4
	public void set_target(VisualElement value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
