public class InteractionLookAt // TypeDefIndex: 14142
{
	// Fields
	[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
	public LookAtIK ik; // 0x10
	[Tooltip("Interpolation speed of the LookAtIK target.")]
	public float lerpSpeed; // 0x18
	[Tooltip("Interpolation speed of the LookAtIK weight.")]
	public float weightSpeed; // 0x1C
	[HideInInspector]
	public bool isPaused; // 0x20
	private Transform lookAtTarget; // 0x28
	private float stopLookTime; // 0x30
	private float weight; // 0x34
	private bool firstFBBIKSolve; // 0x38

	// Methods

	// RVA: 0x1F03620 Offset: 0x1F02020 VA: 0x181F03620
	public void Look(Transform target, float time) { }

	// RVA: 0x1F03790 Offset: 0x1F02190 VA: 0x181F03790
	public void OnFixTransforms() { }

	// RVA: 0x1F03A10 Offset: 0x1F02410 VA: 0x181F03A10
	public void Update() { }

	// RVA: 0x1F038F0 Offset: 0x1F022F0 VA: 0x181F038F0
	public void SolveSpine() { }

	// RVA: 0x1F03820 Offset: 0x1F02220 VA: 0x181F03820
	public void SolveHead() { }

	// RVA: 0x1F03CA0 Offset: 0x1F026A0 VA: 0x181F03CA0
	public void .ctor() { }
}
