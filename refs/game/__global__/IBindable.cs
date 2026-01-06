public interface IBindable // TypeDefIndex: 6237
{
	// Properties
	public abstract IBinding binding { get; }
	public abstract string bindingPath { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IBinding get_binding();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_bindingPath(string value);
}
