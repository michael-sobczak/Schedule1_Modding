public interface IActivator // TypeDefIndex: 4350
{
	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);
}
