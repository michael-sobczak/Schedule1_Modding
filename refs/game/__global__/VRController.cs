public class VRController : MonoBehaviour // TypeDefIndex: 14290
{
	// Fields
	public VRController.InputMode inputMode; // 0x20
	public VRIK ik; // 0x28
	public Transform centerEyeAnchor; // 0x30
	public float walkSpeed; // 0x38
	public float runSpeed; // 0x3C
	public float walkForwardSpeedMlp; // 0x40
	public float runForwardSpeedMlp; // 0x44
	private Vector3 smoothInput; // 0x48
	private Vector3 smoothInputV; // 0x54

	// Methods

	// RVA: 0x1F4E8D0 Offset: 0x1F4D2D0 VA: 0x181F4E8D0
	private void Update() { }

	// RVA: 0x1F4E590 Offset: 0x1F4CF90 VA: 0x181F4E590
	private Vector3 GetInput() { }

	// RVA: 0x1F4EBD0 Offset: 0x1F4D5D0 VA: 0x181F4EBD0
	public void .ctor() { }
}
