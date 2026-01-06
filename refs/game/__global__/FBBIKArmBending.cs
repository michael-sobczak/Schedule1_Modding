public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 14089
{
	// Fields
	public FullBodyBipedIK ik; // 0x20
	public Vector3 bendDirectionOffsetLeft; // 0x28
	public Vector3 bendDirectionOffsetRight; // 0x34
	public Vector3 characterSpaceBendOffsetLeft; // 0x40
	public Vector3 characterSpaceBendOffsetRight; // 0x4C
	private Quaternion leftHandTargetRotation; // 0x58
	private Quaternion rightHandTargetRotation; // 0x68
	private bool initiated; // 0x78

	// Methods

	// RVA: 0x1EAF120 Offset: 0x1EADB20 VA: 0x181EAF120
	private void LateUpdate() { }

	// RVA: 0x1EAF910 Offset: 0x1EAE310 VA: 0x181EAF910
	private void OnPostFBBIK() { }

	// RVA: 0x1EAF7D0 Offset: 0x1EAE1D0 VA: 0x181EAF7D0
	private void OnDestroy() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
