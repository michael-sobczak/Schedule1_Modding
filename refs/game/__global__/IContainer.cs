public interface IContainer : IDisposable // TypeDefIndex: 9668
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Add(IComponent component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Remove(IComponent component);
}
