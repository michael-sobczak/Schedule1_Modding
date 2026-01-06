public interface IPathModifier // TypeDefIndex: 13287
{
	// Properties
	public abstract int Order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Order();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Apply(Path path);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PreProcess(Path path);
}
