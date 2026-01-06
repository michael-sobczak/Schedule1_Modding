public interface IMouseEvent // TypeDefIndex: 6569
{
	// Properties
	public abstract EventModifiers modifiers { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Vector2 localMousePosition { get; }
	public abstract Vector2 mouseDelta { get; }
	public abstract int clickCount { get; }
	public abstract int button { get; }
	public abstract int pressedButtons { get; }
	public abstract bool shiftKey { get; }
	public abstract bool ctrlKey { get; }
	public abstract bool commandKey { get; }
	public abstract bool altKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventModifiers get_modifiers();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector2 get_localMousePosition();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector2 get_mouseDelta();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_clickCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_button();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_pressedButtons();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_shiftKey();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ctrlKey();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_commandKey();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_altKey();
}
