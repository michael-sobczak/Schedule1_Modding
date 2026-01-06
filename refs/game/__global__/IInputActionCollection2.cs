public interface IInputActionCollection2 : IInputActionCollection, IEnumerable<InputAction>, IEnumerable // TypeDefIndex: 7254
{
	// Properties
	public abstract IEnumerable<InputBinding> bindings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<InputBinding> get_bindings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract InputAction FindAction(string actionNameOrId, bool throwIfNotFound = False);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int FindBinding(InputBinding mask, out InputAction action);
}
