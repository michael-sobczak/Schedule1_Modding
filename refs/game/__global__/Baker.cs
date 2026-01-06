public abstract class Baker : MonoBehaviour // TypeDefIndex: 14006
{
	// Fields
	[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
	[Range(1, 90)]
	public int frameRate; // 0x20
	[Tooltip("Maximum allowed error for keyframe reduction.")]
	[Range(0, 0.1)]
	public float keyReductionError; // 0x24
	[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
	public Baker.Mode mode; // 0x28
	[Tooltip("AnimationClips to bake.")]
	public AnimationClip[] animationClips; // 0x30
	[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
	public string[] animationStates; // 0x38
	[Tooltip("The folder to save the baked AnimationClips to.")]
	public string saveToFolder; // 0x40
	[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
	public string appendName; // 0x48
	[Tooltip("Name of the created AnimationClip file.")]
	public string saveName; // 0x50
	[CompilerGenerated]
	private bool <isBaking>k__BackingField; // 0x58
	[CompilerGenerated]
	private float <bakingProgress>k__BackingField; // 0x5C
	[HideInInspector]
	public Animator animator; // 0x60
	[HideInInspector]
	public PlayableDirector director; // 0x68
	public Baker.BakerDelegate OnStartClip; // 0x70
	public Baker.BakerDelegate OnUpdateClip; // 0x78
	[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
	public bool inheritClipSettings; // 0x80
	[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
	public Baker.ClipSettings clipSettings; // 0x88
	[CompilerGenerated]
	private float <clipLength>k__BackingField; // 0x90
	protected bool addLoopFrame; // 0x94

	// Properties
	public bool isBaking { get; set; }
	public float bakingProgress { get; set; }
	protected float clipLength { get; set; }

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1E98BC0 Offset: 0x1E975C0 VA: 0x181E98BC0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1E98B60 Offset: 0x1E97560 VA: 0x181E98B60
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1E98C20 Offset: 0x1E97620 VA: 0x181E98C20
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1E98B00 Offset: 0x1E97500 VA: 0x181E98B00
	private void ASThread() { }

	[CompilerGenerated]
	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_isBaking() { }

	[CompilerGenerated]
	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	private void set_isBaking(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_bakingProgress() { }

	[CompilerGenerated]
	// RVA: 0xD3E1E0 Offset: 0xD3CBE0 VA: 0x180D3E1E0
	private void set_bakingProgress(float value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Transform GetCharacterRoot();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnStartBaking();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnSetLoopFrame(float time);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnSetCurves(ref AnimationClip clip);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnSetKeyframes(float time, bool lastFrame);

	[CompilerGenerated]
	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	protected float get_clipLength() { }

	[CompilerGenerated]
	// RVA: 0x7B13B0 Offset: 0x7AFDB0 VA: 0x1807B13B0
	private void set_clipLength(float value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void BakeClip() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void StartBaking() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void StopBaking() { }

	// RVA: 0x1E98C80 Offset: 0x1E97680 VA: 0x181E98C80
	protected void .ctor() { }
}
