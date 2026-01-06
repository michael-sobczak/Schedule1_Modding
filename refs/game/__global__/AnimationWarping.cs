public class AnimationWarping : OffsetModifier // TypeDefIndex: 14240
{
	// Fields
	[Tooltip("Reference to the Animator component to use")]
	public Animator animator; // 0x38
	[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
	public AnimationWarping.EffectorMode effectorMode; // 0x40
	[Space(10)]
	[Tooltip("The array of warps, can have multiple simultaneous warps.")]
	public AnimationWarping.Warp[] warps; // 0x48
	private AnimationWarping.EffectorMode lastMode; // 0x50

	// Methods

	// RVA: 0x1F37C00 Offset: 0x1F36600 VA: 0x181F37C00 Slot: 5
	protected override void Start() { }

	// RVA: 0x1F37550 Offset: 0x1F35F50 VA: 0x181F37550
	public float GetWarpWeight(int warpIndex) { }

	// RVA: 0x1F37860 Offset: 0x1F36260 VA: 0x181F37860 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F377B0 Offset: 0x1F361B0 VA: 0x181F377B0
	private void OnDisable() { }

	// RVA: 0x1F37C20 Offset: 0x1F36620 VA: 0x181F37C20
	public void .ctor() { }
}
