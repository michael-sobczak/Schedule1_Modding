public interface ITypeDescriptorContext : IServiceProvider // TypeDefIndex: 9727
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract object Instance { get; }
	public abstract PropertyDescriptor PropertyDescriptor { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Instance();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptor get_PropertyDescriptor();
}
