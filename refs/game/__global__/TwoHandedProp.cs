public class TwoHandedProp : MonoBehaviour // TypeDefIndex: 14280
{
	// Fields
	[Range(0, 1)]
	public float weight; // 0x20
	[Tooltip("The left hand target parented to the right hand.")]
	public Transform leftHandTarget; // 0x28
	[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
	public Poser leftHandPoser; // 0x30
	[Range(0, 1)]
	[Tooltip("The weight of pinning the left hand to the prop.")]
	public float leftHandWeight; // 0x38
	private FullBodyBipedIK ik; // 0x40
	private Vector3 targetPosRelativeToRight; // 0x48
	private Quaternion targetRotRelativeToRight; // 0x54

	// Methods

	// RVA: 0x1F4D4B0 Offset: 0x1F4BEB0 VA: 0x181F4D4B0
	private void Start() { }

	// RVA: 0x1F4CE10 Offset: 0x1F4B810 VA: 0x181F4CE10
	private void LateUpdate() { }

	// RVA: 0x1F4CC00 Offset: 0x1F4B600 VA: 0x181F4CC00
	private void AfterFBBIK() { }

	// RVA: 0x1F4D370 Offset: 0x1F4BD70 VA: 0x181F4D370
	private void OnDestroy() { }

	// RVA: 0x1F4D680 Offset: 0x1F4C080 VA: 0x181F4D680
	public void .ctor() { }
}
