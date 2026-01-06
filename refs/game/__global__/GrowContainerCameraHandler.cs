public class GrowContainerCameraHandler : MonoBehaviour // TypeDefIndex: 2361
{
	// Fields
	[SerializeField]
	private bool RotateCameraContainerToFacePlayer; // 0x20
	[SerializeField]
	private bool SnapRotationToRightAngles; // 0x21
	[SerializeField]
	private Transform _midshotCamera; // 0x28
	[SerializeField]
	private Transform _closeupCamera; // 0x30
	[SerializeField]
	private Transform _fullshotContainer; // 0x38
	[SerializeField]
	private Transform _birdsEyeCamera; // 0x40
	[SerializeField]
	[Header("Debug & Development")]
	private GrowContainerCameraHandler.ECameraPosition _debugCameraPosition; // 0x48

	// Methods

	// RVA: 0x859E90 Offset: 0x858890 VA: 0x180859E90
	public void PositionCameraContainer() { }

	// RVA: 0x859E10 Offset: 0x858810 VA: 0x180859E10
	public Transform GetCameraPosition(GrowContainerCameraHandler.ECameraPosition pos, bool autoPosition = True) { }

	[Button("Set Camera Position")]
	// RVA: 0x85A280 Offset: 0x858C80 VA: 0x18085A280
	private void SetCameraPosition() { }

	// RVA: 0x85A3C0 Offset: 0x858DC0 VA: 0x18085A3C0
	public void .ctor() { }
}
