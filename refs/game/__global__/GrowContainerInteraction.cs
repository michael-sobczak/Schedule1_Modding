public class GrowContainerInteraction : MonoBehaviour // TypeDefIndex: 2362
{
	// Fields
	[SerializeField]
	private InteractableObject _interactableObject; // 0x20
	private bool _interactableActivatedThisFrame; // 0x28
	private Vector3 displayLocationPointDefaultLocalPosition; // 0x2C

	// Methods

	// RVA: 0x85A3E0 Offset: 0x858DE0 VA: 0x18085A3E0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x85A540 Offset: 0x858F40 VA: 0x18085A540
	private void LateUpdate() { }

	// RVA: 0x85A440 Offset: 0x858E40 VA: 0x18085A440
	public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, bool setLabelPosition = False, Vector3 labelPosition) { }

	// RVA: 0x85A5F0 Offset: 0x858FF0 VA: 0x18085A5F0 Slot: 5
	protected virtual bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state) { }

	// RVA: 0x85A650 Offset: 0x859050 VA: 0x18085A650
	public void .ctor() { }
}
