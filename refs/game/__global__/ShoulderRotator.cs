public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 14218
{
	// Fields
	[Tooltip("Weight of shoulder rotation")]
	public float weight; // 0x20
	[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
	public float offset; // 0x24
	private FullBodyBipedIK ik; // 0x28
	private bool skip; // 0x30

	// Methods

	// RVA: 0x1F307A0 Offset: 0x1F2F1A0 VA: 0x181F307A0
	private void Start() { }

	// RVA: 0x1F306B0 Offset: 0x1F2F0B0 VA: 0x181F306B0
	private void RotateShoulders() { }

	// RVA: 0x1F300A0 Offset: 0x1F2EAA0 VA: 0x181F300A0
	private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) { }

	// RVA: 0x1F2FF20 Offset: 0x1F2E920 VA: 0x181F2FF20
	private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) { }

	// RVA: 0x1F2FF60 Offset: 0x1F2E960 VA: 0x181F2FF60
	private void OnDestroy() { }

	// RVA: 0x1F308D0 Offset: 0x1F2F2D0 VA: 0x181F308D0
	public void .ctor() { }
}
