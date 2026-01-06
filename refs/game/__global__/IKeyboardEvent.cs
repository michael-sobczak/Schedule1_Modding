public interface IKeyboardEvent // TypeDefIndex: 6557
{
	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract char character { get; }
	public abstract KeyCode keyCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventModifiers get_modifiers();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract char get_character();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract KeyCode get_keyCode();
}
