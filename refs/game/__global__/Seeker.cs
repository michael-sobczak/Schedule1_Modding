public class Seeker : VersionedMonoBehaviour // TypeDefIndex: 13110
{
	// Fields
	public bool drawGizmos; // 0x28
	public bool detailedGizmos; // 0x29
	[HideInInspector]
	public StartEndModifier startEndModifier; // 0x30
	[HideInInspector]
	public int traversableTags; // 0x38
	[HideInInspector]
	public int[] tagPenalties; // 0x40
	[HideInInspector]
	public GraphMask graphMask; // 0x48
	[FormerlySerializedAs("graphMask")]
	private int graphMaskCompatibility; // 0x4C
	public OnPathDelegate pathCallback; // 0x50
	public OnPathDelegate preProcessPath; // 0x58
	public OnPathDelegate postProcessPath; // 0x60
	private List<Vector3> lastCompletedVectorPath; // 0x68
	private List<GraphNode> lastCompletedNodePath; // 0x70
	protected Path path; // 0x78
	private Path prevPath; // 0x80
	private readonly OnPathDelegate onPathDelegate; // 0x88
	private readonly OnPathDelegate onPartialPathDelegate; // 0x90
	private OnPathDelegate tmpPathCallback; // 0x98
	protected uint lastPathID; // 0xA0
	private readonly List<IPathModifier> modifiers; // 0xA8

	// Methods

	// RVA: 0xAFFA60 Offset: 0xAFE460 VA: 0x180AFFA60
	public void .ctor() { }

	// RVA: 0xAFE5C0 Offset: 0xAFCFC0 VA: 0x180AFE5C0 Slot: 7
	protected override void Awake() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Path GetCurrentPath() { }

	// RVA: 0xAFE5F0 Offset: 0xAFCFF0 VA: 0x180AFE5F0
	public void CancelCurrentPathRequest(bool pool = True) { }

	// RVA: 0xAFE790 Offset: 0xAFD190 VA: 0x180AFE790
	public void OnDestroy() { }

	// RVA: 0xAFEFB0 Offset: 0xAFD9B0 VA: 0x180AFEFB0
	private void ReleaseClaimedPath() { }

	// RVA: 0xAFEE00 Offset: 0xAFD800 VA: 0x180AFEE00
	public void RegisterModifier(IPathModifier modifier) { }

	// RVA: 0xAFE680 Offset: 0xAFD080 VA: 0x180AFE680
	public void DeregisterModifier(IPathModifier modifier) { }

	// RVA: 0xAFEDF0 Offset: 0xAFD7F0 VA: 0x180AFEDF0
	public void PostProcess(Path path) { }

	// RVA: 0xAFF000 Offset: 0xAFDA00 VA: 0x180AFF000
	public void RunModifiers(Seeker.ModifierPass pass, Path path) { }

	// RVA: 0xAFE770 Offset: 0xAFD170 VA: 0x180AFE770
	public bool IsDone() { }

	// RVA: 0xAFECE0 Offset: 0xAFD6E0 VA: 0x180AFECE0
	private void OnPathComplete(Path path) { }

	// RVA: 0xAFEB50 Offset: 0xAFD550 VA: 0x180AFEB50
	private void OnPathComplete(Path p, bool runModifiers, bool sendCallbacks) { }

	// RVA: 0xAFEAB0 Offset: 0xAFD4B0 VA: 0x180AFEAB0
	private void OnPartialPathComplete(Path p) { }

	// RVA: 0xAFEA90 Offset: 0xAFD490 VA: 0x180AFEA90
	private void OnMultiPathComplete(Path p) { }

	[Obsolete("Use ABPath.Construct(start, end, null) instead")]
	// RVA: 0xAFE6E0 Offset: 0xAFD0E0 VA: 0x180AFE6E0
	public ABPath GetNewPath(Vector3 start, Vector3 end) { }

	// RVA: 0xAFF790 Offset: 0xAFE190 VA: 0x180AFF790
	public Path StartPath(Vector3 start, Vector3 end) { }

	// RVA: 0xAFF860 Offset: 0xAFE260 VA: 0x180AFF860
	public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback) { }

	// RVA: 0xAFF940 Offset: 0xAFE340 VA: 0x180AFF940
	public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback, GraphMask graphMask) { }

	// RVA: 0xAFFA10 Offset: 0xAFE410 VA: 0x180AFFA10
	public Path StartPath(Path p, OnPathDelegate callback) { }

	// RVA: 0xAFF750 Offset: 0xAFE150 VA: 0x180AFF750
	public Path StartPath(Path p, OnPathDelegate callback, GraphMask graphMask) { }

	// RVA: 0xAFF420 Offset: 0xAFDE20 VA: 0x180AFF420
	private void StartPathInternal(Path p, OnPathDelegate callback) { }

	// RVA: 0xAFF2E0 Offset: 0xAFDCE0 VA: 0x180AFF2E0
	public MultiTargetPath StartMultiTargetPath(Vector3 start, Vector3[] endPoints, bool pathsForAll, OnPathDelegate callback, int graphMask = -1) { }

	// RVA: 0xAFF380 Offset: 0xAFDD80 VA: 0x180AFF380
	public MultiTargetPath StartMultiTargetPath(Vector3[] startPoints, Vector3 end, bool pathsForAll, OnPathDelegate callback, int graphMask = -1) { }

	[Obsolete("You can use StartPath instead of this method now. It will behave identically.")]
	// RVA: 0xAFF280 Offset: 0xAFDC80 VA: 0x180AFF280
	public MultiTargetPath StartMultiTargetPath(MultiTargetPath p, OnPathDelegate callback, int graphMask = -1) { }

	// RVA: 0xAFE7F0 Offset: 0xAFD1F0 VA: 0x180AFE7F0
	public void OnDrawGizmos() { }

	// RVA: 0xAFED00 Offset: 0xAFD700 VA: 0x180AFED00 Slot: 9
	protected override int OnUpgradeSerializedData(int version, bool unityThread) { }
}
