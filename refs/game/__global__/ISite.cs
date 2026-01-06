public interface ISite : IServiceProvider // TypeDefIndex: 9669
{
	// Properties
	public abstract IComponent Component { get; }
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_Component();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Name();
}
