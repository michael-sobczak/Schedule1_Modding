public interface IInputActionCollection : IEnumerable<InputAction>, IEnumerable // TypeDefIndex: 7253
{
	// Properties
	public abstract Nullable<InputBinding> bindingMask { get; set; }
	public abstract Nullable<ReadOnlyArray<InputDevice>> devices { get; set; }
	public abstract ReadOnlyArray<InputControlScheme> controlSchemes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Nullable<InputBinding> get_bindingMask();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_bindingMask(Nullable<InputBinding> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Nullable<ReadOnlyArray<InputDevice>> get_devices();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_devices(Nullable<ReadOnlyArray<InputDevice>> value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ReadOnlyArray<InputControlScheme> get_controlSchemes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Contains(InputAction action);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Enable();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Disable();
}
