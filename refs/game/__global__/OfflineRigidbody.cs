public class OfflineRigidbody : MonoBehaviour // TypeDefIndex: 12674
{
	// Fields
	[Tooltip("Type of prediction movement which is being used.")]
	[SerializeField]
	private RigidbodyType _rigidbodyType; // 0x20
	private Transform _graphicalObject; // 0x28
	[SerializeField]
	[Tooltip("True to also get rigidbody components within children.")]
	private bool _getInChildren; // 0x30
	private RigidbodyPauser _rigidbodyPauser; // 0x38
	private PredictionManager _predictionManager; // 0x40

	// Methods

	// RVA: 0xD4B220 Offset: 0xD49C20 VA: 0x180D4B220
	public void SetGraphicalObject(Transform value) { }

	// RVA: 0xD4B010 Offset: 0xD49A10 VA: 0x180D4B010
	private void Awake() { }

	// RVA: 0xD4B210 Offset: 0xD49C10 VA: 0x180D4B210
	private void OnDestroy() { }

	// RVA: 0xD4B010 Offset: 0xD49A10 VA: 0x180D4B010
	private void InitializeOnce() { }

	// RVA: 0xD4B290 Offset: 0xD49C90 VA: 0x180D4B290
	public void SetPredictionManager(PredictionManager pm) { }

	// RVA: 0xD4B330 Offset: 0xD49D30 VA: 0x180D4B330
	public void UpdateRigidbodies() { }

	// RVA: 0xD4B090 Offset: 0xD49A90 VA: 0x180D4B090
	private void ChangeSubscription(bool subscribe) { }

	// RVA: 0xD4B420 Offset: 0xD49E20 VA: 0x180D4B420
	private void _predictionManager_OnPreReconcile(NetworkBehaviour obj) { }

	// RVA: 0xD4B400 Offset: 0xD49E00 VA: 0x180D4B400
	private void _predictionManager_OnPostReconcile(NetworkBehaviour obj) { }

	// RVA: 0xD4B390 Offset: 0xD49D90 VA: 0x180D4B390
	public void .ctor() { }
}
