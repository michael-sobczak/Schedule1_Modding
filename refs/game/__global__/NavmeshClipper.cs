public abstract class NavmeshClipper : VersionedMonoBehaviour // TypeDefIndex: 13301
{
	// Fields
	private static Action<NavmeshClipper> OnEnableCallback; // 0x0
	private static Action<NavmeshClipper> OnDisableCallback; // 0x8
	private static readonly List<NavmeshClipper> all; // 0x10
	private int listIndex; // 0x28
	public GraphMask graphMask; // 0x2C

	// Properties
	public static List<NavmeshClipper> allEnabled { get; }

	// Methods

	// RVA: 0xB69390 Offset: 0xB67D90 VA: 0x180B69390
	public static void AddEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable) { }

	// RVA: 0xB69850 Offset: 0xB68250 VA: 0x180B69850
	public static void RemoveEnableCallback(Action<NavmeshClipper> onEnable, Action<NavmeshClipper> onDisable) { }

	// RVA: 0xB69AE0 Offset: 0xB684E0 VA: 0x180B69AE0
	public static List<NavmeshClipper> get_allEnabled() { }

	// RVA: 0xB696F0 Offset: 0xB680F0 VA: 0x180B696F0 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xB69560 Offset: 0xB67F60 VA: 0x180B69560 Slot: 11
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void NotifyUpdated();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Rect GetBounds(GraphTransform transform);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool RequiresUpdate();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void ForceUpdate();

	// RVA: 0xB69AB0 Offset: 0xB684B0 VA: 0x180B69AB0
	protected void .ctor() { }

	// RVA: 0xB69A20 Offset: 0xB68420 VA: 0x180B69A20
	private static void .cctor() { }
}
