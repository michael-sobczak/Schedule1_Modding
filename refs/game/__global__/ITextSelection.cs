public interface ITextSelection // TypeDefIndex: 6921
{
	// Properties
	public abstract bool isSelectable { get; set; }
	public abstract Color cursorColor { get; set; }
	public abstract int cursorIndex { get; set; }
	public abstract bool doubleClickSelectsWord { get; }
	public abstract int selectIndex { get; set; }
	public abstract Color selectionColor { get; set; }
	public abstract bool tripleClickSelectsLine { get; }
	internal abstract bool selectAllOnFocus { get; set; }
	internal abstract bool selectAllOnMouseUp { get; set; }
	public abstract Vector2 cursorPosition { get; }
	internal abstract float lineHeightAtCursorPosition { get; }
	internal abstract float cursorWidth { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isSelectable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isSelectable(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Color get_cursorColor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_cursorColor(Color value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_cursorIndex();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_cursorIndex(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_doubleClickSelectsWord();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_selectIndex();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_selectIndex(int value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Color get_selectionColor();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_selectionColor(Color value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_tripleClickSelectsLine();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool HasSelection();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SelectAll();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SelectNone();

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract bool get_selectAllOnFocus();

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void set_selectAllOnFocus(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract bool get_selectAllOnMouseUp();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void set_selectAllOnMouseUp(bool value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Vector2 get_cursorPosition();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract float get_lineHeightAtCursorPosition();

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract float get_cursorWidth();
}
