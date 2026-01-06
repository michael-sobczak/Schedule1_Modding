public interface IDesignerHost : IServiceProvider // TypeDefIndex: 9828
{
	// Properties
	public abstract IComponent RootComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_RootComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDesigner GetDesigner(IComponent component);
}
