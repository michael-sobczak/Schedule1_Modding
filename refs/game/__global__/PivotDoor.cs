public class PivotDoor : MonoBehaviour // TypeDefIndex: 1543
{
	// Fields
	[Header("Settings")]
	public Transform DoorTransform; // 0x20
	public bool FlipSide; // 0x28
	public float OpenInwardsAngle; // 0x2C
	public float OpenOutwardsAngle; // 0x30
	public float SwingSpeed; // 0x34
	private bool isUpdatingDoor; // 0x38
	private float targetDoorAngle; // 0x3C

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x6FC8A0 Offset: 0x6FB2A0 VA: 0x1806FC8A0 Slot: 5
	public virtual void Opened(EDoorSide openSide) { }

	// RVA: 0x6FC890 Offset: 0x6FB290 VA: 0x1806FC890 Slot: 6
	public virtual void Closed() { }

	// RVA: 0x6FC960 Offset: 0x6FB360 VA: 0x1806FC960
	private void UpdateDoor() { }

	// RVA: 0x6FC9E0 Offset: 0x6FB3E0 VA: 0x1806FC9E0
	public void .ctor() { }

	[IteratorStateMachine(typeof(PivotDoor.<<UpdateDoor>g__inner|10_0>d))]
	[CompilerGenerated]
	// RVA: 0x6FC8F0 Offset: 0x6FB2F0 VA: 0x1806FC8F0
	private IEnumerator <UpdateDoor>g__inner|10_0() { }
}
