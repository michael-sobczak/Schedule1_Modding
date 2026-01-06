public class PayPhone : MonoBehaviour // TypeDefIndex: 2095
{
	// Fields
	public const float RING_INTERVAL = 4;
	public const float RING_RANGE = 9;
	public PhoneCallData QueuedCall; // 0x20
	public PhoneCallData ActiveCall; // 0x28
	public BlinkingLight Light; // 0x30
	public AudioSourceController RingSound; // 0x38
	public AudioSourceController AnswerSound; // 0x40
	public InteractableObject IntObj; // 0x48
	public Transform CameraPosition; // 0x50
	private float lastRingTime; // 0x58
	private const float ringRangeSquared = 81;
	private Coroutine periodicRingHandle; // 0x60

	// Methods

	// RVA: 0x80AB20 Offset: 0x809520 VA: 0x18080AB20
	private void Start() { }

	// RVA: 0x80A770 Offset: 0x809170 VA: 0x18080A770
	private void OnDestroy() { }

	// RVA: 0x80A740 Offset: 0x809140 VA: 0x18080A740
	private void OnCallStarted(PhoneCallData data) { }

	// RVA: 0x80A6E0 Offset: 0x8090E0 VA: 0x18080A6E0
	private void OnCallCompleted(PhoneCallData data) { }

	// RVA: 0x80A710 Offset: 0x809110 VA: 0x18080A710
	private void OnCallQueued(PhoneCallData data) { }

	// RVA: 0x80B130 Offset: 0x809B30 VA: 0x18080B130
	private void UpdateCallState() { }

	[IteratorStateMachine(typeof(PayPhone.<PeriodicRing>d__18))]
	// RVA: 0x80AAB0 Offset: 0x8094B0 VA: 0x18080AAB0
	private IEnumerator PeriodicRing() { }

	// RVA: 0x80A430 Offset: 0x808E30 VA: 0x18080A430
	public void Hovered() { }

	// RVA: 0x80A4B0 Offset: 0x808EB0 VA: 0x18080A4B0
	public void Interacted() { }

	// RVA: 0x80A370 Offset: 0x808D70 VA: 0x18080A370
	private bool CanInteract() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
