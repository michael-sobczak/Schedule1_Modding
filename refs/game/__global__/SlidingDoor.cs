public class SlidingDoor : MonoBehaviour // TypeDefIndex: 1548
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public Transform DoorTransform; // 0x28
	public Transform ClosedPosition; // 0x30
	public Transform OpenPosition; // 0x38
	public float SlideDuration; // 0x40
	public AnimationCurve SlideCurve; // 0x48
	private Coroutine MoveRoutine; // 0x50

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x6FD790 Offset: 0x6FC190 VA: 0x1806FD790 Slot: 4
	public virtual void Opened(EDoorSide openSide) { }

	// RVA: 0x6FD6E0 Offset: 0x6FC0E0 VA: 0x1806FD6E0 Slot: 5
	public virtual void Closed() { }

	// RVA: 0x6FD6F0 Offset: 0x6FC0F0 VA: 0x1806FD6F0
	private void Move() { }

	// RVA: 0x6FD810 Offset: 0x6FC210 VA: 0x1806FD810
	public void .ctor() { }

	[IteratorStateMachine(typeof(SlidingDoor.<<Move>g__Move|12_0>d))]
	[CompilerGenerated]
	// RVA: 0x6FD7A0 Offset: 0x6FC1A0 VA: 0x1806FD7A0
	private IEnumerator <Move>g__Move|12_0() { }
}
