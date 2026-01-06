public class CartelStatusChangePopup : MonoBehaviour // TypeDefIndex: 2573
{
	// Fields
	public Animation Anim; // 0x20
	public TextMeshProUGUI OldStatusLabel; // 0x28
	public TextMeshProUGUI NewStatusLabel; // 0x30
	public Color UnknownColor; // 0x38
	public Color TrucedColor; // 0x48
	public Color HostileColor; // 0x58
	public Color DefeatedColor; // 0x68

	// Methods

	// RVA: 0x8AD320 Offset: 0x8ABD20 VA: 0x1808AD320
	private void Start() { }

	// RVA: 0x8AD080 Offset: 0x8ABA80 VA: 0x1808AD080
	public void Show(ECartelStatus oldStatus, ECartelStatus newStatus) { }

	// RVA: 0x8AD030 Offset: 0x8ABA30 VA: 0x1808AD030
	private Color GetColor(ECartelStatus status) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[IteratorStateMachine(typeof(CartelStatusChangePopup.<<Show>g__Routine|8_0>d))]
	[CompilerGenerated]
	// RVA: 0x8AD480 Offset: 0x8ABE80 VA: 0x1808AD480
	private IEnumerator <Show>g__Routine|8_0() { }
}
