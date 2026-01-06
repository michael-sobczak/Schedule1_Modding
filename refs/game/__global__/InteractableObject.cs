public class InteractableObject : MonoBehaviour // TypeDefIndex: 1368
{
	// Fields
	[SerializeField]
	[Header("Settings")]
	protected string message; // 0x20
	[SerializeField]
	protected InteractableObject.EInteractionType interactionType; // 0x28
	[SerializeField]
	protected InteractableObject.EInteractableState interactionState; // 0x2C
	public float MaxInteractionRange; // 0x30
	public bool RequiresUniqueClick; // 0x34
	public int Priority; // 0x38
	[SerializeField]
	protected Collider displayLocationCollider; // 0x40
	public Transform displayLocationPoint; // 0x48
	[Header("Angle Limits")]
	public bool LimitInteractionAngle; // 0x50
	public float AngleLimit; // 0x54
	[Header("Events")]
	public UnityEvent onHovered; // 0x58
	public UnityEvent onInteractStart; // 0x60
	public UnityEvent onInteractEnd; // 0x68

	// Properties
	public InteractableObject.EInteractionType _interactionType { get; }
	public InteractableObject.EInteractableState _interactionState { get; }

	// Methods

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public InteractableObject.EInteractionType get__interactionType() { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public InteractableObject.EInteractableState get__interactionState() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void SetInteractionType(InteractableObject.EInteractionType type) { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void SetInteractableState(InteractableObject.EInteractableState state) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void SetMessage(string _message) { }

	// RVA: 0x65DFD0 Offset: 0x65C9D0 VA: 0x18065DFD0 Slot: 4
	public virtual void Hovered() { }

	// RVA: 0x65E4E0 Offset: 0x65CEE0 VA: 0x18065E4E0 Slot: 5
	public virtual void StartInteract() { }

	// RVA: 0x65DF30 Offset: 0x65C930 VA: 0x18065DF30 Slot: 6
	public virtual void EndInteract() { }

	// RVA: 0x65E030 Offset: 0x65CA30 VA: 0x18065E030 Slot: 7
	protected virtual void ShowMessage() { }

	// RVA: 0x65DCC0 Offset: 0x65C6C0 VA: 0x18065DCC0
	public bool CheckAngleLimit(Vector3 interactionSource) { }

	// RVA: 0x65DBC0 Offset: 0x65C5C0 VA: 0x18065DBC0
	public void .ctor() { }
}
