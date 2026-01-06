public abstract class PickUp2Handed : MonoBehaviour // TypeDefIndex: 14268
{
	// Fields
	public int GUIspace; // 0x20
	public InteractionSystem interactionSystem; // 0x28
	public InteractionObject obj; // 0x30
	public Transform pivot; // 0x38
	public Transform holdPoint; // 0x40
	public float pickUpTime; // 0x48
	private float holdWeight; // 0x4C
	private float holdWeightVel; // 0x50
	private Vector3 pickUpPosition; // 0x54
	private Quaternion pickUpRotation; // 0x60

	// Properties
	private bool holding { get; }
	private bool holdingLeft { get; }
	private bool holdingRight { get; }

	// Methods

	// RVA: 0x1F49500 Offset: 0x1F47F00 VA: 0x181F49500
	private void OnGUI() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void RotatePivot();

	// RVA: 0x1F499D0 Offset: 0x1F483D0 VA: 0x181F499D0
	private void Start() { }

	// RVA: 0x1F49760 Offset: 0x1F48160 VA: 0x181F49760
	private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x1F498F0 Offset: 0x1F482F0 VA: 0x181F498F0
	private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x1F493C0 Offset: 0x1F47DC0 VA: 0x181F493C0
	private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x1F48F00 Offset: 0x1F47900 VA: 0x181F48F00
	private void LateUpdate() { }

	// RVA: 0x1F49DA0 Offset: 0x1F487A0 VA: 0x181F49DA0
	private bool get_holding() { }

	// RVA: 0x1F49C60 Offset: 0x1F48660 VA: 0x181F49C60
	private bool get_holdingLeft() { }

	// RVA: 0x1F49D00 Offset: 0x1F48700 VA: 0x181F49D00
	private bool get_holdingRight() { }

	// RVA: 0x1F49110 Offset: 0x1F47B10 VA: 0x181F49110
	private void OnDestroy() { }

	// RVA: 0x1F49C50 Offset: 0x1F48650 VA: 0x181F49C50
	protected void .ctor() { }
}
