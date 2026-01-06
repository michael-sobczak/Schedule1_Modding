public class ModifierMixPaths : CGModule, IOnRequestProcessing, IPathProvider // TypeDefIndex: 10736
{
	// Fields
	private const int MixMinValue = -1;
	private const int MixMaxValue = 1;
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path A")]
	[HideInInspector]
	public CGModuleInputSlot InPathA; // 0xC0
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGPath) }, Name = "Path B")]
	public CGModuleInputSlot InPathB; // 0xC8
	[OutputSlotInfo(typeof(CGPath))]
	[HideInInspector]
	public CGModuleOutputSlot OutPath; // 0xD0
	[SerializeField]
	[RangeEx(-1, 1, "", "", Tooltip = "Mix between the paths. Values between -1 for Path A and 1 for Path B")]
	private float m_Mix; // 0xD8

	// Properties
	public float Mix { get; set; }
	public bool PathIsClosed { get; }

	// Methods

	// RVA: 0x537070 Offset: 0x535A70 VA: 0x180537070
	public float get_Mix() { }

	// RVA: 0x537150 Offset: 0x535B50 VA: 0x180537150
	public void set_Mix(float value) { }

	// RVA: 0x537080 Offset: 0x535A80 VA: 0x180537080 Slot: 19
	public bool get_PathIsClosed() { }

	// RVA: 0x4EFB50 Offset: 0x4EE550 VA: 0x1804EFB50 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x536F40 Offset: 0x535940 VA: 0x180536F40 Slot: 13
	public override void Reset() { }

	// RVA: 0x536D60 Offset: 0x535760 VA: 0x180536D60 Slot: 18
	public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, CGDataRequestParameter[] requests) { }

	[CanBeNull]
	// RVA: 0x536840 Offset: 0x535240 VA: 0x180536840
	public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, List<string> warningsContainer) { }

	// RVA: 0x536F90 Offset: 0x535990 VA: 0x180536F90
	public void .ctor() { }
}
