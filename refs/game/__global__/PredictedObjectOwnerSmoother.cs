internal class PredictedObjectOwnerSmoother // TypeDefIndex: 12683
{
	// Fields
	private Transform _graphicalObject; // 0x10
	private NetworkBehaviour _networkBehaviour; // 0x18
	private float _teleportThreshold; // 0x20
	private byte _interpolation; // 0x24
	private Vector3 _graphicalStartPosition; // 0x28
	private Quaternion _graphicalStartRotation; // 0x34
	private Vector3 _graphicalInstantiatedOffsetPosition; // 0x44
	private float _positionMoveRate; // 0x50
	private Quaternion _graphicalInstantiatedOffsetRotation; // 0x54
	private float _rotationMoveRate; // 0x64
	private bool _preTickReceived; // 0x68
	private bool _smoothPosition; // 0x69
	private bool _smoothRotation; // 0x6A

	// Methods

	// RVA: 0xD4C7E0 Offset: 0xD4B1E0 VA: 0x180D4C7E0
	public void SetGraphicalObject(Transform value) { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void SetInterpolation(byte value) { }

	// RVA: 0xD4C230 Offset: 0xD4AC30 VA: 0x180D4C230
	public void Initialize(NetworkBehaviour nb, Vector3 instantiatedOffsetPosition, Quaternion instantiatedOffsetRotation, Transform graphicalObject, bool smoothPosition, bool smoothRotation, byte interpolation, float teleportThreshold) { }

	// RVA: 0xD4C2B0 Offset: 0xD4ACB0 VA: 0x180D4C2B0
	public void ManualUpdate() { }

	// RVA: 0xD4C360 Offset: 0xD4AD60 VA: 0x180D4C360
	public void OnPreTick() { }

	// RVA: 0xD4C2C0 Offset: 0xD4ACC0 VA: 0x180D4C2C0
	public void OnPostTick() { }

	// RVA: 0xD4C090 Offset: 0xD4AA90 VA: 0x180D4C090
	private bool CanSmooth() { }

	// RVA: 0xD41ED0 Offset: 0xD408D0 VA: 0x180D41ED0
	private void MoveToTarget() { }

	// RVA: 0xD4C0E0 Offset: 0xD4AAE0 VA: 0x180D4C0E0
	private bool GraphicalObjectMatches(Vector3 position, Quaternion rotation) { }

	// RVA: 0xD4C8A0 Offset: 0xD4B2A0 VA: 0x180D4C8A0
	private bool SmoothPosition() { }

	// RVA: 0xD4C8F0 Offset: 0xD4B2F0 VA: 0x180D4C8F0
	private bool SmoothRotation() { }

	// RVA: 0xD4C570 Offset: 0xD4AF70 VA: 0x180D4C570
	private void SetGraphicalMoveRates() { }

	// RVA: 0xD41BB0 Offset: 0xD405B0 VA: 0x180D41BB0
	private Vector3 GetGraphicalGoalPosition() { }

	// RVA: 0xD41CA0 Offset: 0xD406A0 VA: 0x180D41CA0
	private Quaternion GetGraphicalGoalRotation() { }

	// RVA: 0xD4C840 Offset: 0xD4B240 VA: 0x180D4C840
	private void SetGraphicalPreviousProperties() { }

	// RVA: 0xD4C520 Offset: 0xD4AF20 VA: 0x180D4C520
	private void ResetGraphicalToPreviousProperties() { }

	// RVA: 0xD4C480 Offset: 0xD4AE80 VA: 0x180D4C480
	private void ResetGraphicalToInstantiatedProperties(bool position, bool rotation) { }

	// RVA: 0xD4C940 Offset: 0xD4B340 VA: 0x180D4C940
	public void .ctor() { }
}
