public abstract class GraphModifier : VersionedMonoBehaviour // TypeDefIndex: 13167
{
	// Fields
	private static GraphModifier root; // 0x0
	private GraphModifier prev; // 0x28
	private GraphModifier next; // 0x30
	[SerializeField]
	[HideInInspector]
	protected ulong uniqueID; // 0x38
	protected static Dictionary<ulong, GraphModifier> usedIDs; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	protected static List<T> GetModifiersOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD760 Offset: 0xEBC160 VA: 0x180EBD760
	|-GraphModifier.GetModifiersOfType<object>
	*/

	// RVA: 0xB163F0 Offset: 0xB14DF0 VA: 0x180B163F0
	public static void FindAllModifiers() { }

	// RVA: 0xB169C0 Offset: 0xB153C0 VA: 0x180B169C0
	public static void TriggerEvent(GraphModifier.EventType type) { }

	// RVA: 0xB165A0 Offset: 0xB14FA0 VA: 0x180B165A0 Slot: 10
	protected virtual void OnEnable() { }

	// RVA: 0xB16590 Offset: 0xB14F90 VA: 0x180B16590 Slot: 11
	protected virtual void OnDisable() { }

	// RVA: 0xB16290 Offset: 0xB14C90 VA: 0x180B16290 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB162B0 Offset: 0xB14CB0 VA: 0x180B162B0
	private void ConfigureUniqueID() { }

	// RVA: 0xB16150 Offset: 0xB14B50 VA: 0x180B16150
	private void AddToLinkedList() { }

	// RVA: 0xB166F0 Offset: 0xB150F0 VA: 0x180B166F0
	private void RemoveFromLinkedList() { }

	// RVA: 0xB16510 Offset: 0xB14F10 VA: 0x180B16510 Slot: 12
	protected virtual void OnDestroy() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void OnPostScan() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public virtual void OnPreScan() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public virtual void OnLatePostScan() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public virtual void OnPostCacheLoad() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public virtual void OnGraphsPreUpdate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public virtual void OnGraphsPostUpdate() { }

	// RVA: 0xB16900 Offset: 0xB15300 VA: 0x180B16900 Slot: 8
	protected override void Reset() { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	protected void .ctor() { }

	// RVA: 0xB16DC0 Offset: 0xB157C0 VA: 0x180B16DC0
	private static void .cctor() { }
}
