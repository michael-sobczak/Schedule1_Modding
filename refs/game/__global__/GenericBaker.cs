public class GenericBaker : Baker // TypeDefIndex: 14007
{
	// Fields
	[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
	public bool markAsLegacy; // 0x98
	[Tooltip("Root Transform of the hierarchy to bake.")]
	public Transform root; // 0xA0
	[Tooltip("Root Node used for root motion.")]
	public Transform rootNode; // 0xA8
	[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
	public Transform[] ignoreList; // 0xB0
	[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
	public Transform[] bakePositionList; // 0xB8
	private BakerTransform[] children; // 0xC0
	private BakerTransform rootChild; // 0xC8
	private int rootChildIndex; // 0xD0

	// Methods

	// RVA: 0x1EA4760 Offset: 0x1EA3160 VA: 0x181EA4760
	private void Awake() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x1EA5600 Offset: 0x1EA4000 VA: 0x181EA5600 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x1EA5350 Offset: 0x1EA3D50 VA: 0x181EA5350 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x1EA4C30 Offset: 0x1EA3630 VA: 0x181EA4C30 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x1EA4F90 Offset: 0x1EA3990 VA: 0x181EA4F90 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x1EA4B50 Offset: 0x1EA3550 VA: 0x181EA4B50
	private bool IsIgnored(Transform t) { }

	// RVA: 0x1EA4A70 Offset: 0x1EA3470 VA: 0x181EA4A70
	private bool BakePosition(Transform t) { }

	// RVA: 0x1EA5720 Offset: 0x1EA4120 VA: 0x181EA5720
	public void .ctor() { }
}
