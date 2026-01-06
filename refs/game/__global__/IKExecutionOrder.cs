public class IKExecutionOrder : MonoBehaviour // TypeDefIndex: 14081
{
	// Fields
	[Tooltip("The IK components, assign in the order in which you wish to update them.")]
	public IK[] IKComponents; // 0x20
	[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
	public Animator animator; // 0x28
	private bool fixedFrame; // 0x30

	// Properties
	private bool animatePhysics { get; }

	// Methods

	// RVA: 0x1EC4820 Offset: 0x1EC3220 VA: 0x181EC4820
	private bool get_animatePhysics() { }

	// RVA: 0x1EC4770 Offset: 0x1EC3170 VA: 0x181EC4770
	private void Start() { }

	// RVA: 0x1EC47F0 Offset: 0x1EC31F0 VA: 0x181EC47F0
	private void Update() { }

	// RVA: 0x1EC4690 Offset: 0x1EC3090 VA: 0x181EC4690
	private void FixedUpdate() { }

	// RVA: 0x1EC46C0 Offset: 0x1EC30C0 VA: 0x181EC46C0
	private void LateUpdate() { }

	// RVA: 0x1EC45E0 Offset: 0x1EC2FE0 VA: 0x181EC45E0
	private void FixTransforms() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
