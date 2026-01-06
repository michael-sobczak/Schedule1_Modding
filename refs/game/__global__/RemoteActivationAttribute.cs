internal class RemoteActivationAttribute : Attribute, IContextAttribute // TypeDefIndex: 4353
{
	// Fields
	private IList _contextProperties; // 0x10

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(IList contextProperties) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

	// RVA: 0x1B3EBB0 Offset: 0x1B3D5B0 VA: 0x181B3EBB0 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }
}
