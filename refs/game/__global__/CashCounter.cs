public class CashCounter : MonoBehaviour // TypeDefIndex: 3199
{
	// Fields
	public const float NoteLerpTime = 0.18;
	public bool IsOn; // 0x20
	[Header("References")]
	public GameObject UpperNotes; // 0x28
	public GameObject LowerNotes; // 0x30
	public Transform NoteStartPoint; // 0x38
	public Transform NoteEndPoint; // 0x40
	public List<Transform> MovingNotes; // 0x48
	public AudioSourceController Audio; // 0x50
	private bool lerping; // 0x58

	// Methods

	// RVA: 0x9CB220 Offset: 0x9C9C20 VA: 0x1809CB220 Slot: 4
	public virtual void LateUpdate() { }

	[IteratorStateMachine(typeof(CashCounter.<LerpNote>d__10))]
	// RVA: 0x9CB430 Offset: 0x9C9E30 VA: 0x1809CB430
	private IEnumerator LerpNote(Transform note) { }

	// RVA: 0x9CB4C0 Offset: 0x9C9EC0 VA: 0x1809CB4C0
	public void .ctor() { }
}
