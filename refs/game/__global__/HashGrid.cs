public class HashGrid : MonoBehaviour // TypeDefIndex: 12660
{
	// Fields
	internal static Vector2Int UnsetGridPosition; // 0x0
	internal static GridEntry EmptyGridEntry; // 0x8
	[Tooltip("Axes of world space to base the grid on.")]
	[SerializeField]
	private HashGrid.GridAxes _gridAxes; // 0x20
	[SerializeField]
	[Tooltip("Accuracy of the grid. Objects will be considered nearby if they are within this number of units. Lower values may be more expensive.")]
	[Range(1, 65535)]
	private ushort _accuracy; // 0x22
	private int _halfAccuracy; // 0x24
	private Stack<HashSet<GridEntry>> _gridEntryHashSetCache; // 0x28
	private Stack<GridEntry> _gridEntryCache; // 0x30
	private Dictionary<Vector2Int, GridEntry> _gridEntries; // 0x38
	private NetworkManager _networkManager; // 0x40

	// Methods

	// RVA: 0xD27DE0 Offset: 0xD267E0 VA: 0x180D27DE0
	private void Awake() { }

	// RVA: 0xD286C0 Offset: 0xD270C0 VA: 0x180D286C0
	private void OutputNewGridCollections(out GridEntry gridEntry, out HashSet<GridEntry> gridEntries) { }

	// RVA: 0xD280D0 Offset: 0xD26AD0 VA: 0x180D280D0
	private GridEntry CreateGridEntry(Vector2Int position) { }

	// RVA: 0xD285F0 Offset: 0xD26FF0 VA: 0x180D285F0
	internal void GetNearbyHashGridPositions(NetworkObject nob, ref HashSet<Vector2Int> collection) { }

	// RVA: 0xD284A0 Offset: 0xD26EA0 VA: 0x180D284A0
	internal Vector2Int GetHashGridPosition(NetworkObject nob) { }

	// RVA: 0xD283E0 Offset: 0xD26DE0 VA: 0x180D283E0
	internal GridEntry GetGridEntry(NetworkObject nob) { }

	// RVA: 0xD28410 Offset: 0xD26E10 VA: 0x180D28410
	internal GridEntry GetGridEntry(Vector2Int position) { }

	// RVA: 0xD289C0 Offset: 0xD273C0 VA: 0x180D289C0
	public void .ctor() { }

	// RVA: 0xD28890 Offset: 0xD27290 VA: 0x180D28890
	private static void .cctor() { }
}
