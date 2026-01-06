public class AvatarIKController : MonoBehaviour // TypeDefIndex: 3144
{
	// Fields
	[Header("References")]
	public BipedIK BodyIK; // 0x20
	private Transform defaultLeftLegBendTarget; // 0x28
	private Transform defaultRightLegBendTarget; // 0x30

	// Methods

	// RVA: 0x9AF140 Offset: 0x9ADB40 VA: 0x1809AF140
	private void Awake() { }

	// RVA: 0x8DE600 Offset: 0x8DD000 VA: 0x1808DE600
	private void Start() { }

	// RVA: 0x9AF2D0 Offset: 0x9ADCD0 VA: 0x1809AF2D0
	public void SetIKActive(bool active) { }

	// RVA: 0x9AF1D0 Offset: 0x9ADBD0 VA: 0x1809AF1D0
	public void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget) { }

	// RVA: 0x9AF250 Offset: 0x9ADC50 VA: 0x1809AF250
	public void ResetLegBendTargets() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
