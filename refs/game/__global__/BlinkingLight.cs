public class BlinkingLight : MonoBehaviour // TypeDefIndex: 1263
{
	// Fields
	public bool IsOn; // 0x20
	public float OnTime; // 0x24
	public float OffTime; // 0x28
	private ToggleableLight light; // 0x30
	private Coroutine blinkRoutine; // 0x38

	// Methods

	// RVA: 0x60BE30 Offset: 0x60A830 VA: 0x18060BE30
	private void Awake() { }

	// RVA: 0x60BEF0 Offset: 0x60A8F0 VA: 0x18060BEF0
	private void Update() { }

	[IteratorStateMachine(typeof(BlinkingLight.<Blink>d__7))]
	// RVA: 0x60BE80 Offset: 0x60A880 VA: 0x18060BE80
	private IEnumerator Blink() { }

	// RVA: 0x60BF80 Offset: 0x60A980 VA: 0x18060BF80
	public void .ctor() { }
}
