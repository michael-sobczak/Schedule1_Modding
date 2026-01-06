public class AstarSerializer // TypeDefIndex: 13373
{
	// Fields
	private AstarData data; // 0x10
	private ZipFile zip; // 0x18
	private MemoryStream zipStream; // 0x20
	private GraphMeta meta; // 0x28
	private SerializeSettings settings; // 0x30
	private GameObject contextRoot; // 0x38
	private NavGraph[] graphs; // 0x40
	private Dictionary<NavGraph, int> graphIndexInZip; // 0x48
	private int graphIndexOffset; // 0x50
	private const string binaryExt = ".binary";
	private const string jsonExt = ".json";
	private uint checksum; // 0x54
	private UTF8Encoding encoding; // 0x58
	private static StringBuilder _stringBuilder; // 0x0
	public static readonly Version V3_8_3; // 0x8
	public static readonly Version V3_9_0; // 0x10
	public static readonly Version V4_1_0; // 0x18

	// Methods

	// RVA: 0xB9F310 Offset: 0xB9DD10 VA: 0x180B9F310
	private static StringBuilder GetStringBuilder() { }

	// RVA: 0xBA1390 Offset: 0xB9FD90 VA: 0x180BA1390
	public void .ctor(AstarData data, GameObject contextRoot) { }

	// RVA: 0xBA1490 Offset: 0xB9FE90 VA: 0x180BA1490
	public void .ctor(AstarData data, SerializeSettings settings, GameObject contextRoot) { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void SetGraphIndexOffset(int offset) { }

	// RVA: 0xB9CD60 Offset: 0xB9B760 VA: 0x180B9CD60
	private void AddChecksum(byte[] bytes) { }

	// RVA: 0xB9CD90 Offset: 0xB9B790 VA: 0x180B9CD90
	private void AddEntry(string name, byte[] bytes) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public uint GetChecksum() { }

	// RVA: 0xB9FBE0 Offset: 0xB9E5E0 VA: 0x180B9FBE0
	public void OpenSerialize() { }

	// RVA: 0xB9CF60 Offset: 0xB9B960 VA: 0x180B9CF60
	public byte[] CloseSerialize() { }

	// RVA: 0xBA0640 Offset: 0xB9F040 VA: 0x180BA0640
	public void SerializeGraphs(NavGraph[] _graphs) { }

	// RVA: 0xBA0840 Offset: 0xB9F240 VA: 0x180BA0840
	private byte[] SerializeMeta() { }

	// RVA: 0xBA1120 Offset: 0xB9FB20 VA: 0x180BA1120
	public byte[] Serialize(NavGraph graph) { }

	[Obsolete("Not used anymore. You can safely remove the call to this function.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SerializeNodes() { }

	// RVA: 0xB9F1D0 Offset: 0xB9DBD0 VA: 0x180B9F1D0
	private static int GetMaxNodeIndexInAllGraphs(NavGraph[] graphs) { }

	// RVA: 0xBA0CD0 Offset: 0xB9F6D0 VA: 0x180BA0CD0
	private static byte[] SerializeNodeIndices(NavGraph[] graphs) { }

	// RVA: 0xBA0370 Offset: 0xB9ED70 VA: 0x180BA0370
	private static byte[] SerializeGraphExtraInfo(NavGraph graph) { }

	// RVA: 0xBA04A0 Offset: 0xB9EEA0 VA: 0x180BA04A0
	private static byte[] SerializeGraphNodeReferences(NavGraph graph) { }

	// RVA: 0xB9FFA0 Offset: 0xB9E9A0 VA: 0x180B9FFA0
	public void SerializeExtraInfo() { }

	// RVA: 0xBA1020 Offset: 0xB9FA20 VA: 0x180BA1020
	private byte[] SerializeNodeLinks() { }

	// RVA: 0xB9F1B0 Offset: 0xB9DBB0 VA: 0x180B9F1B0
	private ZipEntry GetEntry(string name) { }

	// RVA: 0xB9D370 Offset: 0xB9BD70 VA: 0x180B9D370
	private bool ContainsEntry(string name) { }

	// RVA: 0xB9F5E0 Offset: 0xB9DFE0 VA: 0x180B9F5E0
	public bool OpenDeserialize(byte[] bytes) { }

	// RVA: 0xB9F050 Offset: 0xB9DA50 VA: 0x180B9F050
	private static Version FullyDefinedVersion(Version v) { }

	// RVA: 0xB9CF00 Offset: 0xB9B900 VA: 0x180B9CF00
	public void CloseDeserialize() { }

	// RVA: 0xB9E040 Offset: 0xB9CA40 VA: 0x180B9E040
	private NavGraph DeserializeGraph(int zipIndex, int graphIndex, Type[] availableGraphTypes) { }

	// RVA: 0xB9E540 Offset: 0xB9CF40 VA: 0x180B9E540
	public NavGraph[] DeserializeGraphs(Type[] availableGraphTypes) { }

	// RVA: 0xB9D980 Offset: 0xB9C380 VA: 0x180B9D980
	private bool DeserializeExtraInfo(NavGraph graph) { }

	// RVA: 0xB9CDB0 Offset: 0xB9B7B0 VA: 0x180B9CDB0
	private bool AnyDestroyedNodesInGraphs() { }

	// RVA: 0xB9E960 Offset: 0xB9D360 VA: 0x180B9E960
	private GraphNode[] DeserializeNodeReferenceMap() { }

	// RVA: 0xB9EDC0 Offset: 0xB9D7C0 VA: 0x180B9EDC0
	private void DeserializeNodeReferences(NavGraph graph, GraphNode[] int2Node) { }

	// RVA: 0xB9DB30 Offset: 0xB9C530 VA: 0x180B9DB30
	public void DeserializeExtraInfo() { }

	// RVA: 0xB9E820 Offset: 0xB9D220 VA: 0x180B9E820
	private void DeserializeNodeLinks(GraphNode[] int2Node) { }

	// RVA: 0xB9FD00 Offset: 0xB9E700 VA: 0x180B9FD00
	public void PostDeserialization() { }

	// RVA: 0xB9D7F0 Offset: 0xB9C1F0 VA: 0x180B9D7F0
	public void DeserializeEditorSettingsCompatibility() { }

	// RVA: 0xB9F100 Offset: 0xB9DB00 VA: 0x180B9F100
	private static BinaryReader GetBinaryReader(ZipEntry entry) { }

	// RVA: 0xB9F390 Offset: 0xB9DD90 VA: 0x180B9F390
	private static string GetString(ZipEntry entry) { }

	// RVA: 0xB9E6F0 Offset: 0xB9D0F0 VA: 0x180B9E6F0
	private GraphMeta DeserializeMeta(ZipEntry entry) { }

	// RVA: 0xB9D3A0 Offset: 0xB9BDA0 VA: 0x180B9D3A0
	private GraphMeta DeserializeBinaryMeta(ZipEntry entry) { }

	// RVA: 0xB9FE90 Offset: 0xB9E890 VA: 0x180B9FE90
	public static void SaveToFile(string path, byte[] data) { }

	// RVA: 0xB9F470 Offset: 0xB9DE70 VA: 0x180B9F470
	public static byte[] LoadFromFile(string path) { }

	// RVA: 0xBA1200 Offset: 0xB9FC00 VA: 0x180BA1200
	private static void .cctor() { }
}
