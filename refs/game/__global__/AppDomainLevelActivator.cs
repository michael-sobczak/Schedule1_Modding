internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 4347
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x1B24400 Offset: 0x1B22E00 VA: 0x181B24400 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}
