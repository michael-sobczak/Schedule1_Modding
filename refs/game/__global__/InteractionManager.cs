public class InteractionManager : Singleton<InteractionManager> // TypeDefIndex: 1373
{
	// Fields
	public const float RayRadius = 0.075;
	public const float MaxInteractionRange = 5;
	[SerializeField]
	protected LayerMask interaction_SearchMask; // 0x28
	[SerializeField]
	protected float rightClickRange; // 0x2C
	public EInteractionSearchType interactionSearchType; // 0x30
	public bool DEBUG; // 0x34
	[CompilerGenerated]
	private bool <CanDestroy>k__BackingField; // 0x35
	[CompilerGenerated]
	private InteractableObject <HoveredInteractableObject>k__BackingField; // 0x38
	[CompilerGenerated]
	private InteractableObject <HoveredValidInteractableObject>k__BackingField; // 0x40
	[CompilerGenerated]
	private InteractableObject <InteractedObject>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <InteractKeyStr>k__BackingField; // 0x50
	[Header("Settings")]
	public InputActionReference InteractInput; // 0x58
	[Header("Visuals Settings")]
	public Color messageColor_Default; // 0x60
	public Color iconColor_Default; // 0x70
	public Color iconColor_Default_Key; // 0x80
	public Color messageColor_Invalid; // 0x90
	public Color iconColor_Invalid; // 0xA0
	public Sprite icon_Key; // 0xB0
	public Sprite icon_LeftMouse; // 0xB8
	public Sprite icon_Cross; // 0xC0
	public static float interactCooldown; // 0x0
	private float timeSinceLastInteractStart; // 0xC8
	private BuildableItem itemBeingDestroyed; // 0xD0
	private float destroyTime; // 0xD8
	private static float timeToDestroy; // 0x4

	// Properties
	public LayerMask Interaction_SearchMask { get; }
	public bool CanDestroy { get; set; }
	public InteractableObject HoveredInteractableObject { get; set; }
	public InteractableObject HoveredValidInteractableObject { get; set; }
	public InteractableObject InteractedObject { get; set; }
	public string InteractKeyStr { get; set; }

	// Methods

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public LayerMask get_Interaction_SearchMask() { }

	[CompilerGenerated]
	// RVA: 0x660940 Offset: 0x65F340 VA: 0x180660940
	public bool get_CanDestroy() { }

	[CompilerGenerated]
	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void set_CanDestroy(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public InteractableObject get_HoveredInteractableObject() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_HoveredInteractableObject(InteractableObject value) { }

	[CompilerGenerated]
	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public InteractableObject get_HoveredValidInteractableObject() { }

	[CompilerGenerated]
	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	protected void set_HoveredValidInteractableObject(InteractableObject value) { }

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public InteractableObject get_InteractedObject() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_InteractedObject(InteractableObject value) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_InteractKeyStr() { }

	[CompilerGenerated]
	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	protected void set_InteractKeyStr(string value) { }

	// RVA: 0x6604E0 Offset: 0x65EEE0 VA: 0x1806604E0 Slot: 4
	protected override void Start() { }

	// RVA: 0x660340 Offset: 0x65ED40 VA: 0x180660340 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x660260 Offset: 0x65EC60 VA: 0x180660260
	private void LoadInteractKey() { }

	// RVA: 0x660800 Offset: 0x65F200 VA: 0x180660800 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x660180 Offset: 0x65EB80 VA: 0x180660180 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x65E950 Offset: 0x65D350 VA: 0x18065E950 Slot: 9
	protected virtual void CheckHover() { }

	// RVA: 0x65FE70 Offset: 0x65E870 VA: 0x18065FE70
	public bool IsAnythingBlockingInteraction() { }

	// RVA: 0x65F580 Offset: 0x65DF80 VA: 0x18065F580 Slot: 10
	protected virtual void CheckInteraction() { }

	// RVA: 0x65F8D0 Offset: 0x65E2D0 VA: 0x18065F8D0 Slot: 11
	protected virtual void CheckRightClick() { }

	// RVA: 0x65FD20 Offset: 0x65E720 VA: 0x18065FD20 Slot: 12
	protected virtual BuildableItem GetHoveredBuildableItem() { }

	// RVA: 0x6604D0 Offset: 0x65EED0 VA: 0x1806604D0
	public void SetCanDestroy(bool canDestroy) { }

	// RVA: 0x6608D0 Offset: 0x65F2D0 VA: 0x1806608D0
	public void .ctor() { }

	// RVA: 0x660880 Offset: 0x65F280 VA: 0x180660880
	private static void .cctor() { }
}
