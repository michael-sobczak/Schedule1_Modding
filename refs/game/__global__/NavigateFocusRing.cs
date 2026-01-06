internal class NavigateFocusRing : IFocusRing // TypeDefIndex: 6674
{
	// Fields
	public static readonly NavigateFocusRing.ChangeDirection Left; // 0x0
	public static readonly NavigateFocusRing.ChangeDirection Right; // 0x8
	public static readonly NavigateFocusRing.ChangeDirection Up; // 0x10
	public static readonly NavigateFocusRing.ChangeDirection Down; // 0x18
	public static readonly FocusChangeDirection Next; // 0x20
	public static readonly FocusChangeDirection Previous; // 0x28
	private readonly VisualElement m_Root; // 0x10
	private readonly VisualElementFocusRing m_Ring; // 0x18

	// Properties
	private FocusController focusController { get; }

	// Methods

	// RVA: 0x1B56610 Offset: 0x1B55010 VA: 0x181B56610
	private FocusController get_focusController() { }

	// RVA: 0x2EACB70 Offset: 0x2EAB570 VA: 0x182EACB70
	public void .ctor(VisualElement root) { }

	// RVA: 0x2EABB50 Offset: 0x2EAA550 VA: 0x182EABB50 Slot: 4
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x2EAC630 Offset: 0x2EAB030 VA: 0x182EAC630 Slot: 6
	public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x2EAC030 Offset: 0x2EAAA30 VA: 0x182EAC030
	private Focusable GetNextFocusable2D(Focusable currentFocusable, NavigateFocusRing.ChangeDirection direction) { }

	// RVA: 0x2EAC790 Offset: 0x2EAB190 VA: 0x182EAC790
	private static bool IsActive(VisualElement v) { }

	// RVA: 0x2EAC800 Offset: 0x2EAB200 VA: 0x182EAC800
	private static bool IsNavigable(Focusable focusable) { }

	// RVA: 0x2EAC850 Offset: 0x2EAB250 VA: 0x182EAC850
	private static void .cctor() { }
}
