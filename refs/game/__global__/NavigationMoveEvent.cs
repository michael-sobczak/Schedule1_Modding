public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent> // TypeDefIndex: 6604
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private NavigationMoveEvent.Direction <direction>k__BackingField; // 0x90
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <move>k__BackingField; // 0x94

	// Properties
	public NavigationMoveEvent.Direction direction { get; set; }
	private Vector2 move { set; }

	// Methods

	// RVA: 0x2EAD370 Offset: 0x2EABD70 VA: 0x182EAD370
	private static void .cctor() { }

	// RVA: 0x2EACEB0 Offset: 0x2EAB8B0 VA: 0x182EACEB0
	internal static NavigationMoveEvent.Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6) { }

	[CompilerGenerated]
	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	public NavigationMoveEvent.Direction get_direction() { }

	[CompilerGenerated]
	// RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	private void set_direction(NavigationMoveEvent.Direction value) { }

	[CompilerGenerated]
	// RVA: 0x1063DE0 Offset: 0x10627E0 VA: 0x181063DE0
	private void set_move(Vector2 value) { }

	// RVA: 0x2EAD180 Offset: 0x2EABB80 VA: 0x182EAD180
	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = 0) { }

	// RVA: 0x2EAD080 Offset: 0x2EABA80 VA: 0x182EAD080
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	// RVA: 0x2EACF30 Offset: 0x2EAB930 VA: 0x182EACF30
	public static NavigationMoveEvent GetPooled(NavigationMoveEvent.Direction direction, EventModifiers modifiers = 0) { }

	// RVA: 0x2EACFD0 Offset: 0x2EAB9D0 VA: 0x182EACFD0
	internal static NavigationMoveEvent GetPooled(NavigationMoveEvent.Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	// RVA: 0x2EAD280 Offset: 0x2EABC80 VA: 0x182EAD280 Slot: 12
	protected override void Init() { }

	// RVA: 0x2EAD450 Offset: 0x2EABE50 VA: 0x182EAD450
	public void .ctor() { }

	// RVA: 0x2EAD310 Offset: 0x2EABD10 VA: 0x182EAD310
	private void LocalInit() { }
}
