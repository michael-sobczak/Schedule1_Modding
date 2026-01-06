public class TurnBasedDoor : MonoBehaviour // TypeDefIndex: 13456
{
	// Fields
	private Animator animator; // 0x20
	private SingleNodeBlocker blocker; // 0x28
	private bool open; // 0x30

	// Methods

	// RVA: 0xBD4550 Offset: 0xBD2F50 VA: 0x180BD4550
	private void Awake() { }

	// RVA: 0xBD46C0 Offset: 0xBD30C0 VA: 0x180BD46C0
	private void Start() { }

	// RVA: 0xBD45D0 Offset: 0xBD2FD0 VA: 0x180BD45D0
	public void Close() { }

	[IteratorStateMachine(typeof(TurnBasedDoor.<WaitAndClose>d__6))]
	// RVA: 0xBD4810 Offset: 0xBD3210 VA: 0x180BD4810
	private IEnumerator WaitAndClose() { }

	// RVA: 0xBD4650 Offset: 0xBD3050 VA: 0x180BD4650
	public void Open() { }

	// RVA: 0xBD4720 Offset: 0xBD3120 VA: 0x180BD4720
	public void Toggle() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
