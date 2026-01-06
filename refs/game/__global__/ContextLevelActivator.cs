internal class ContextLevelActivator : IActivator // TypeDefIndex: 4349
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(IActivator next) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x1B2CEC0 Offset: 0x1B2B8C0 VA: 0x181B2CEC0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}
