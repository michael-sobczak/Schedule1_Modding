public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 7465
{
	// Fields
	[Tooltip("Which Transform properties to update.")]
	[SerializeField]
	private TrackedPoseDriver.TrackingType m_TrackingType; // 0x20
	[SerializeField]
	[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
	private TrackedPoseDriver.UpdateType m_UpdateType; // 0x24
	[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
	[SerializeField]
	private bool m_IgnoreTrackingState; // 0x28
	[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
	[SerializeField]
	private InputActionProperty m_PositionInput; // 0x30
	[SerializeField]
	[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
	private InputActionProperty m_RotationInput; // 0x48
	[SerializeField]
	[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
	private InputActionProperty m_TrackingStateInput; // 0x60
	private Vector3 m_CurrentPosition; // 0x78
	private Quaternion m_CurrentRotation; // 0x84
	private TrackedPoseDriver.TrackingStates m_CurrentTrackingState; // 0x94
	private bool m_RotationBound; // 0x98
	private bool m_PositionBound; // 0x99
	private bool m_TrackingStateBound; // 0x9A
	private bool m_IsFirstUpdate; // 0x9B
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_PositionAction; // 0xA0
	[Obsolete]
	[SerializeField]
	[HideInInspector]
	private InputAction m_RotationAction; // 0xA8

	// Properties
	public TrackedPoseDriver.TrackingType trackingType { get; set; }
	public TrackedPoseDriver.UpdateType updateType { get; set; }
	public bool ignoreTrackingState { get; set; }
	public InputActionProperty positionInput { get; set; }
	public InputActionProperty rotationInput { get; set; }
	public InputActionProperty trackingStateInput { get; set; }
	public InputAction positionAction { get; set; }
	public InputAction rotationAction { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public TrackedPoseDriver.TrackingType get_trackingType() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_trackingType(TrackedPoseDriver.TrackingType value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public TrackedPoseDriver.UpdateType get_updateType() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_updateType(TrackedPoseDriver.UpdateType value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_ignoreTrackingState() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_ignoreTrackingState(bool value) { }

	// RVA: 0xCCD880 Offset: 0xCCC280 VA: 0x180CCD880
	public InputActionProperty get_positionInput() { }

	// RVA: 0x2836B60 Offset: 0x2835560 VA: 0x182836B60
	public void set_positionInput(InputActionProperty value) { }

	// RVA: 0x2326210 Offset: 0x2324C10 VA: 0x182326210
	public InputActionProperty get_rotationInput() { }

	// RVA: 0x2836D00 Offset: 0x2835700 VA: 0x182836D00
	public void set_rotationInput(InputActionProperty value) { }

	// RVA: 0x2326230 Offset: 0x2324C30 VA: 0x182326230
	public InputActionProperty get_trackingStateInput() { }

	// RVA: 0x2836DC0 Offset: 0x28357C0 VA: 0x182836DC0
	public void set_trackingStateInput(InputActionProperty value) { }

	// RVA: 0x2835320 Offset: 0x2833D20 VA: 0x182835320
	private void BindActions() { }

	// RVA: 0x28362F0 Offset: 0x2834CF0 VA: 0x1828362F0
	private void UnbindActions() { }

	// RVA: 0x2835350 Offset: 0x2833D50 VA: 0x182835350
	private void BindPosition() { }

	// RVA: 0x28354D0 Offset: 0x2833ED0 VA: 0x1828354D0
	private void BindRotation() { }

	// RVA: 0x2835650 Offset: 0x2834050 VA: 0x182835650
	private void BindTrackingState() { }

	// RVA: 0x2835F70 Offset: 0x2834970 VA: 0x182835F70
	private static void RenameAndEnable(InputAction action, string name) { }

	// RVA: 0x2836320 Offset: 0x2834D20 VA: 0x182836320
	private void UnbindPosition() { }

	// RVA: 0x2836450 Offset: 0x2834E50 VA: 0x182836450
	private void UnbindRotation() { }

	// RVA: 0x2836580 Offset: 0x2834F80 VA: 0x182836580
	private void UnbindTrackingState() { }

	// RVA: 0x2835C30 Offset: 0x2834630 VA: 0x182835C30
	private void OnPositionPerformed(InputAction.CallbackContext context) { }

	// RVA: 0x2835BE0 Offset: 0x28345E0 VA: 0x182835BE0
	private void OnPositionCanceled(InputAction.CallbackContext context) { }

	// RVA: 0x2835CE0 Offset: 0x28346E0 VA: 0x182835CE0
	private void OnRotationPerformed(InputAction.CallbackContext context) { }

	// RVA: 0x2835C90 Offset: 0x2834690 VA: 0x182835C90
	private void OnRotationCanceled(InputAction.CallbackContext context) { }

	// RVA: 0x2835D50 Offset: 0x2834750 VA: 0x182835D50
	private void OnTrackingStatePerformed(InputAction.CallbackContext context) { }

	// RVA: 0x2835D40 Offset: 0x2834740 VA: 0x182835D40
	private void OnTrackingStateCanceled(InputAction.CallbackContext context) { }

	// RVA: 0x2835FA0 Offset: 0x28349A0 VA: 0x182835FA0
	protected void Reset() { }

	// RVA: 0x28352A0 Offset: 0x2833CA0 VA: 0x1828352A0 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x2835AE0 Offset: 0x28344E0 VA: 0x182835AE0
	protected void OnEnable() { }

	// RVA: 0x28359E0 Offset: 0x28343E0 VA: 0x1828359E0
	protected void OnDisable() { }

	// RVA: 0x2835940 Offset: 0x2834340 VA: 0x182835940 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x2836780 Offset: 0x2835180 VA: 0x182836780
	protected void UpdateCallback() { }

	// RVA: 0x28359C0 Offset: 0x28343C0 VA: 0x1828359C0
	private void OnDeviceChanged(InputDevice inputDevice, InputDeviceChange inputDeviceChange) { }

	// RVA: 0x2835E20 Offset: 0x2834820 VA: 0x182835E20
	private void ReadTrackingStateWithoutTrackingAction() { }

	// RVA: 0x2835EC0 Offset: 0x28348C0 VA: 0x182835EC0
	private void ReadTrackingState() { }

	// RVA: 0x2835DA0 Offset: 0x28347A0 VA: 0x182835DA0 Slot: 8
	protected virtual void OnUpdate() { }

	// RVA: 0x2835910 Offset: 0x2834310 VA: 0x182835910 Slot: 9
	protected virtual void OnBeforeRender() { }

	// RVA: 0x2835DD0 Offset: 0x28347D0 VA: 0x182835DD0 Slot: 10
	protected virtual void PerformUpdate() { }

	// RVA: 0x28361B0 Offset: 0x2834BB0 VA: 0x1828361B0 Slot: 11
	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	// RVA: 0x28358A0 Offset: 0x28342A0 VA: 0x1828358A0
	private bool HasStereoCamera(out Camera cameraComponent) { }

	// RVA: 0x28357D0 Offset: 0x28341D0 VA: 0x1828357D0
	private static bool HasResolvedControl(InputAction action) { }

	// RVA: 0x2836A60 Offset: 0x2835460 VA: 0x182836A60
	public InputAction get_positionAction() { }

	// RVA: 0x2836A80 Offset: 0x2835480 VA: 0x182836A80
	public void set_positionAction(InputAction value) { }

	// RVA: 0x2836A70 Offset: 0x2835470 VA: 0x182836A70
	public InputAction get_rotationAction() { }

	// RVA: 0x2836C20 Offset: 0x2835620 VA: 0x182836C20
	public void set_rotationAction(InputAction value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x28366B0 Offset: 0x28350B0 VA: 0x1828366B0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x28369C0 Offset: 0x28353C0 VA: 0x1828369C0
	public void .ctor() { }
}
