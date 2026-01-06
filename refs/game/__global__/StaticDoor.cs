public class StaticDoor : MonoBehaviour // TypeDefIndex: 1550
{
	// Fields
	public const float KNOCK_COOLDOWN = 2;
	public const float SUMMON_DURATION = 8;
	[Header("References")]
	public Transform AccessPoint; // 0x20
	public InteractableObject IntObj; // 0x28
	public AudioSourceController KnockSound; // 0x30
	public NPCEnterableBuilding Building; // 0x38
	[Header("Settings")]
	public bool Usable; // 0x40
	public bool CanKnock; // 0x41
	private float timeSinceLastKnock; // 0x44
	private int doorIndex; // 0x48

	// Methods

	// RVA: 0x6FD820 Offset: 0x6FC220 VA: 0x1806FD820 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x6FDE70 Offset: 0x6FC870 VA: 0x1806FDE70 Slot: 5
	protected virtual void OnValidate() { }

	// RVA: 0x6FDB60 Offset: 0x6FC560 VA: 0x1806FDB60 Slot: 6
	protected virtual void Hovered() { }

	// RVA: 0x6FDAE0 Offset: 0x6FC4E0 VA: 0x1806FDAE0 Slot: 7
	protected virtual bool CanKnockNow() { }

	// RVA: 0x6FDC70 Offset: 0x6FC670 VA: 0x1806FDC70 Slot: 8
	protected virtual bool IsKnockValid(out string message) { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50 Slot: 9
	protected virtual void Interacted() { }

	// RVA: 0x6FDCC0 Offset: 0x6FC6C0 VA: 0x1806FDCC0 Slot: 10
	protected virtual void Knock() { }

	// RVA: 0x6FDDB0 Offset: 0x6FC7B0 VA: 0x1806FDDB0 Slot: 11
	protected virtual void NPCSelected(NPC npc) { }

	// RVA: 0x6E7C10 Offset: 0x6E6610 VA: 0x1806E7C10
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(StaticDoor.<<Knock>g__knockRoutine|16_0>d))]
	// RVA: 0x6FDFF0 Offset: 0x6FC9F0 VA: 0x1806FDFF0
	private IEnumerator <Knock>g__knockRoutine|16_0() { }
}
