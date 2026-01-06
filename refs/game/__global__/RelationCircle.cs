public class RelationCircle : MonoBehaviour // TypeDefIndex: 2776
{
	// Fields
	public const float NotchMinRot = 90;
	public const float NotchMaxRot = -90;
	public static Color PortraitColor_ZeroDependence; // 0x0
	public static Color PortraitColor_MaxDependence; // 0x10
	public string AssignedNPC_ID; // 0x20
	public NPC AssignedNPC; // 0x28
	public Action onClicked; // 0x30
	public Action onHoverStart; // 0x38
	public Action onHoverEnd; // 0x40
	public bool AutoSetName; // 0x48
	[Header("References")]
	public RectTransform Rect; // 0x50
	public Image PortraitBackground; // 0x58
	public Image HeadshotImg; // 0x60
	public RectTransform NotchPivot; // 0x68
	public RectTransform Locked; // 0x70
	public Button Button; // 0x78
	public EventTrigger Trigger; // 0x80

	// Methods

	// RVA: 0x939950 Offset: 0x938350 VA: 0x180939950
	private void Awake() { }

	// RVA: 0x939E10 Offset: 0x938810 VA: 0x180939E10
	private void OnValidate() { }

	// RVA: 0x9392F0 Offset: 0x937CF0 VA: 0x1809392F0
	public void AssignNPC(NPC npc) { }

	// RVA: 0x93A3F0 Offset: 0x938DF0 VA: 0x18093A3F0
	private void UnassignNPC() { }

	// RVA: 0x93A1C0 Offset: 0x938BC0 VA: 0x18093A1C0
	private void RelationshipChange(float change) { }

	// RVA: 0x93A2B0 Offset: 0x938CB0 VA: 0x18093A2B0
	public void SetNotchPosition(float relationshipDelta) { }

	// RVA: 0x93A100 Offset: 0x938B00 VA: 0x18093A100
	private void RefreshNotchPosition() { }

	// RVA: 0x939F10 Offset: 0x938910 VA: 0x180939F10
	private void RefreshDependenceDisplay() { }

	[Button]
	// RVA: 0x93A250 Offset: 0x938C50 VA: 0x18093A250
	public void SetLocked() { }

	[Button]
	// RVA: 0x93A350 Offset: 0x938D50 VA: 0x18093A350
	public void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = True) { }

	[Button]
	// RVA: 0x939DA0 Offset: 0x9387A0 VA: 0x180939DA0
	public void LoadNPCData() { }

	// RVA: 0x93A620 Offset: 0x939020 VA: 0x18093A620
	private void UpdateBlackout() { }

	// RVA: 0x93A1D0 Offset: 0x938BD0 VA: 0x18093A1D0
	public void SetBlackedOut(bool blackedOut) { }

	// RVA: 0x939D40 Offset: 0x938740 VA: 0x180939D40
	private void ButtonClicked() { }

	// RVA: 0x939D80 Offset: 0x938780 VA: 0x180939D80
	private void HoverStart() { }

	// RVA: 0x939D60 Offset: 0x938760 VA: 0x180939D60
	private void HoverEnd() { }

	// RVA: 0x93A920 Offset: 0x939320 VA: 0x18093A920
	public void .ctor() { }

	// RVA: 0x93A7F0 Offset: 0x9391F0 VA: 0x18093A7F0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x939D80 Offset: 0x938780 VA: 0x180939D80
	private void <Awake>b__17_0(BaseEventData <p0>) { }

	[CompilerGenerated]
	// RVA: 0x939D60 Offset: 0x938760 VA: 0x180939D60
	private void <Awake>b__17_1(BaseEventData <p0>) { }

	[CompilerGenerated]
	// RVA: 0x93A3E0 Offset: 0x938DE0 VA: 0x18093A3E0
	private void <AssignNPC>b__19_0(NPCRelationData.EUnlockType <p0>, bool <p1>) { }
}
