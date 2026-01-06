public class Reader // TypeDefIndex: 12502
{
	// Fields
	public Reader.DataSource Source; // 0x10
	public NetworkManager NetworkManager; // 0x18
	[CompilerGenerated]
	private int <Offset>k__BackingField; // 0x20
	public int Position; // 0x24
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x28
	[CompilerGenerated]
	private NetworkConnection <NetworkConnection>k__BackingField; // 0x30
	private byte[] _buffer; // 0x38

	// Properties
	public int Capacity { get; }
	public int Offset { get; set; }
	public int Length { get; set; }
	public int Remaining { get; }
	public NetworkConnection NetworkConnection { get; set; }

	// Methods

	// RVA: 0xD1A390 Offset: 0xD18D90 VA: 0x180D1A390
	public int get_Capacity() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_Offset() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_Offset(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_Length(int value) { }

	// RVA: 0xD1A3B0 Offset: 0xD18DB0 VA: 0x180D1A3B0
	public int get_Remaining() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public NetworkConnection get_NetworkConnection() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_NetworkConnection(NetworkConnection value) { }

	// RVA: 0xD1A2C0 Offset: 0xD18CC0 VA: 0x180D1A2C0
	public void .ctor(byte[] bytes, NetworkManager networkManager, NetworkConnection networkConnection, Reader.DataSource source = 0) { }

	// RVA: 0xD1A320 Offset: 0xD18D20 VA: 0x180D1A320
	public void .ctor(ArraySegment<byte> segment, NetworkManager networkManager, NetworkConnection networkConnection, Reader.DataSource source = 0) { }

	// RVA: 0xD1A1E0 Offset: 0xD18BE0 VA: 0x180D1A1E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD1A0D0 Offset: 0xD18AD0 VA: 0x180D1A0D0
	public string RemainingToString() { }

	// RVA: 0xD17C40 Offset: 0xD16640 VA: 0x180D17C40
	public ArraySegment<byte> GetRemainingData() { }

	// RVA: 0xD17CC0 Offset: 0xD166C0 VA: 0x180D17CC0
	internal void Initialize(ArraySegment<byte> segment, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD17E30 Offset: 0xD16830 VA: 0x180D17E30
	internal void Initialize(ArraySegment<byte> segment, NetworkManager networkManager, NetworkConnection networkConnection, Reader.DataSource source = 0) { }

	// RVA: 0xD17CF0 Offset: 0xD166F0 VA: 0x180D17CF0
	internal void Initialize(byte[] bytes, NetworkManager networkManager, Reader.DataSource source = 0) { }

	// RVA: 0xD17D90 Offset: 0xD16790 VA: 0x180D17D90
	internal void Initialize(byte[] bytes, NetworkManager networkManager, NetworkConnection networkConnection, Reader.DataSource source = 0) { }

	[Obsolete("Use ReadDictionaryAllocated.")]
	[CodegenExclude]
	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2A400 Offset: 0xF28E00 VA: 0x180F2A400
	|-Reader.ReadDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> ReadDictionaryAllocated<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2A0F0 Offset: 0xF28AF0 VA: 0x180F2A0F0
	|-Reader.ReadDictionaryAllocated<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: 0xD18AC0 Offset: 0xD174C0 VA: 0x180D18AC0
	internal int ReadLength() { }

	[CodegenExclude]
	// RVA: 0x580F50 Offset: 0x57F950 VA: 0x180580F50
	internal PacketId ReadPacketId() { }

	[CodegenExclude]
	// RVA: 0xD18200 Offset: 0xD16C00 VA: 0x180D18200
	internal PacketId PeekPacketId() { }

	// RVA: 0xD181D0 Offset: 0xD16BD0 VA: 0x180D181D0
	internal byte PeekByte() { }

	[CodegenExclude]
	// RVA: 0xD1A1C0 Offset: 0xD18BC0 VA: 0x180D1A1C0
	public void Skip(int value) { }

	[CodegenExclude]
	// RVA: 0xD17B40 Offset: 0xD16540 VA: 0x180D17B40
	public void Clear() { }

	// RVA: 0xD17B70 Offset: 0xD16570 VA: 0x180D17B70
	public ArraySegment<byte> GetArraySegmentBuffer() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public byte[] GetByteBuffer() { }

	// RVA: 0xD17BD0 Offset: 0xD165D0 VA: 0x180D17BD0
	public byte[] GetByteBufferAllocated() { }

	// RVA: 0xD179C0 Offset: 0xD163C0 VA: 0x180D179C0
	public void BlockCopy(ref byte[] target, int targetOffset, int count) { }

	// RVA: 0xD18380 Offset: 0xD16D80 VA: 0x180D18380
	public byte ReadByte() { }

	[CodegenExclude]
	// RVA: 0xD18520 Offset: 0xD16F20 VA: 0x180D18520
	public void ReadBytes(ref byte[] buffer, int count) { }

	[CodegenExclude]
	// RVA: 0xD18310 Offset: 0xD16D10 VA: 0x180D18310
	public ArraySegment<byte> ReadArraySegment(int count) { }

	// RVA: 0xD18380 Offset: 0xD16D80 VA: 0x180D18380
	public sbyte ReadSByte() { }

	// RVA: 0x580F50 Offset: 0x57F950 VA: 0x180580F50
	public char ReadChar() { }

	// RVA: 0x580C70 Offset: 0x57F670 VA: 0x180580C70
	public bool ReadBoolean() { }

	// RVA: 0x580F50 Offset: 0x57F950 VA: 0x180580F50
	public ushort ReadUInt16() { }

	// RVA: 0x580F50 Offset: 0x57F950 VA: 0x180580F50
	public short ReadInt16() { }

	// RVA: 0x59E970 Offset: 0x59D370 VA: 0x18059E970
	public uint ReadUInt32(AutoPackType packType = 1) { }

	// RVA: 0xD18A40 Offset: 0xD17440 VA: 0x180D18A40
	public int ReadInt32(AutoPackType packType = 1) { }

	// RVA: 0xD18A80 Offset: 0xD17480 VA: 0x180D18A80
	public long ReadInt64(AutoPackType packType = 1) { }

	// RVA: 0x624C80 Offset: 0x623680 VA: 0x180624C80
	public ulong ReadUInt64(AutoPackType packType = 1) { }

	// RVA: 0x59E700 Offset: 0x59D100 VA: 0x18059E700
	public float ReadSingle(AutoPackType packType = 0) { }

	// RVA: 0xD18730 Offset: 0xD17130 VA: 0x180D18730
	public double ReadDouble() { }

	// RVA: 0xD186E0 Offset: 0xD170E0 VA: 0x180D186E0
	public Decimal ReadDecimal() { }

	// RVA: 0xD19B20 Offset: 0xD18520 VA: 0x180D19B20
	public string ReadString() { }

	// RVA: 0xD18430 Offset: 0xD16E30 VA: 0x180D18430
	public byte[] ReadBytesAndSizeAllocated() { }

	[CodegenExclude]
	// RVA: 0xD184C0 Offset: 0xD16EC0 VA: 0x180D184C0
	public int ReadBytesAndSize(ref byte[] target) { }

	// RVA: 0xD18260 Offset: 0xD16C60 VA: 0x180D18260
	public ArraySegment<byte> ReadArraySegmentAndSize() { }

	// RVA: 0xD19F30 Offset: 0xD18930 VA: 0x180D19F30
	public Vector2 ReadVector2() { }

	// RVA: 0xD1A060 Offset: 0xD18A60 VA: 0x180D1A060
	public Vector3 ReadVector3() { }

	// RVA: 0xD19A70 Offset: 0xD18470 VA: 0x180D19A70
	public Vector4 ReadVector4() { }

	// RVA: 0xD19EA0 Offset: 0xD188A0 VA: 0x180D19EA0
	public Vector2Int ReadVector2Int(AutoPackType packType = 1) { }

	// RVA: 0xD19F80 Offset: 0xD18980 VA: 0x180D19F80
	public Vector3Int ReadVector3Int(AutoPackType packType = 1) { }

	// RVA: 0xA61CC0 Offset: 0xA606C0 VA: 0x180A61CC0
	public Color ReadColor(AutoPackType packType = 1) { }

	// RVA: 0xA61C10 Offset: 0xA60610 VA: 0x180A61C10
	public Color32 ReadColor32() { }

	// RVA: 0x624BA0 Offset: 0x6235A0 VA: 0x180624BA0
	public Quaternion ReadQuaternion(AutoPackType packType = 1) { }

	// RVA: 0xD19A70 Offset: 0xD18470 VA: 0x180D19A70
	public Rect ReadRect() { }

	// RVA: 0xD19720 Offset: 0xD18120 VA: 0x180D19720
	public Plane ReadPlane() { }

	// RVA: 0xD19960 Offset: 0xD18360 VA: 0x180D19960
	public Ray ReadRay() { }

	// RVA: 0xD19800 Offset: 0xD18200 VA: 0x180D19800
	public Ray2D ReadRay2D() { }

	// RVA: 0xD18AF0 Offset: 0xD174F0 VA: 0x180D18AF0
	public Matrix4x4 ReadMatrix4x4() { }

	[CodegenExclude]
	// RVA: 0xD183C0 Offset: 0xD16DC0 VA: 0x180D183C0
	public byte[] ReadBytesAllocated(int count) { }

	// RVA: 0xD18970 Offset: 0xD17370 VA: 0x180D18970
	public Guid ReadGuid() { }

	[CodegenExclude]
	// RVA: 0xD19E00 Offset: 0xD18800 VA: 0x180D19E00
	public uint ReadTickUnpacked() { }

	// RVA: 0xD18750 Offset: 0xD17150 VA: 0x180D18750
	public GameObject ReadGameObject() { }

	// RVA: 0xD19E10 Offset: 0xD18810 VA: 0x180D19E10
	public Transform ReadTransform() { }

	// RVA: 0xD196F0 Offset: 0xD180F0 VA: 0x180D196F0
	public NetworkObject ReadNetworkObject() { }

	[CodegenExclude]
	// RVA: 0xD19450 Offset: 0xD17E50 VA: 0x180D19450
	public NetworkObject ReadNetworkObject(out int objectOrPrefabId, HashSet<int> readSpawningObjects) { }

	[CodegenExclude]
	// RVA: 0xD193F0 Offset: 0xD17DF0 VA: 0x180D193F0
	public int ReadNetworkObjectId() { }

	[CodegenExclude]
	// RVA: 0xD192A0 Offset: 0xD17CA0 VA: 0x180D192A0
	internal int ReadNetworkObjectForSpawn(out sbyte initializeOrder, out ushort collectionid, out bool spawned) { }

	[CodegenExclude]
	// RVA: 0xD19210 Offset: 0xD17C10 VA: 0x180D19210
	internal int ReadNetworkObjectForDepawn(out DespawnType dt) { }

	[CodegenExclude]
	// RVA: 0xD18C20 Offset: 0xD17620 VA: 0x180D18C20
	internal byte ReadNetworkBehaviourId(out int objectId) { }

	[CodegenExclude]
	// RVA: 0xD18CE0 Offset: 0xD176E0 VA: 0x180D18CE0
	public NetworkBehaviour ReadNetworkBehaviour(out int objectId, out byte componentIndex, HashSet<int> readSpawningObjects) { }

	// RVA: 0xD18CB0 Offset: 0xD176B0 VA: 0x180D18CB0
	public NetworkBehaviour ReadNetworkBehaviour() { }

	// RVA: 0xD18670 Offset: 0xD17070 VA: 0x180D18670
	public DateTime ReadDateTime() { }

	// RVA: 0xD18380 Offset: 0xD16D80 VA: 0x180D18380
	public Channel ReadChannel() { }

	[CodegenExclude]
	// RVA: 0xD18E90 Offset: 0xD17890 VA: 0x180D18E90
	public int ReadNetworkConnectionId() { }

	// RVA: 0xD18EF0 Offset: 0xD178F0 VA: 0x180D18EF0
	public NetworkConnection ReadNetworkConnection() { }

	// RVA: 0xD17A00 Offset: 0xD16400 VA: 0x180D17A00
	private bool CheckAllocationAttack(int size) { }

	[CodegenExclude]
	// RVA: 0xD19B00 Offset: 0xD18500 VA: 0x180D19B00
	internal void ReadStateUpdatePacket(out uint clientTick) { }

	// RVA: 0xD1A2A0 Offset: 0xD18CA0 VA: 0x180D1A2A0
	public ulong ZigZagDecode(ulong value) { }

	[CodegenExclude]
	// RVA: 0x59E3F0 Offset: 0x59CDF0 VA: 0x18059E3F0
	public ulong ReadPackedWhole() { }

	[CodegenExclude]
	// RVA: -1 Offset: -1
	internal int ReadReplicate<T>(ref T[] collection, uint tick) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2AE50 Offset: 0xF29850 VA: 0x180F2AE50
	|-Reader.ReadReplicate<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF01D30 Offset: 0xF00730 VA: 0x180F01D30
	|-Reader.ReadReplicate<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public ListCache<T> ReadListCacheAllocated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2A490 Offset: 0xF28E90 VA: 0x180F2A490
	|-Reader.ReadListCacheAllocated<__Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public int ReadListCache<T>(ref ListCache<T> listCache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2A530 Offset: 0xF28F30 VA: 0x180F2A530
	|-Reader.ReadListCache<__Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public List<T> ReadListAllocated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61E40 Offset: 0xA60840 VA: 0x180A61E40
	|-Reader.ReadListAllocated<CoordinateProceduralTilePair>
	|
	|-RVA: 0xD90520 Offset: 0xD8EF20 VA: 0x180D90520
	|-Reader.ReadListAllocated<int>
	|
	|-RVA: 0xA62020 Offset: 0xA60A20 VA: 0x180A62020
	|-Reader.ReadListAllocated<Int32Enum>
	|
	|-RVA: 0xA62360 Offset: 0xA60D60 VA: 0x180A62360
	|-Reader.ReadListAllocated<object>
	|
	|-RVA: 0xF2A440 Offset: 0xF28E40 VA: 0x180F2A440
	|-Reader.ReadListAllocated<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA62180 Offset: 0xA60B80 VA: 0x180A62180
	|-Reader.ReadListAllocated<AvatarSettings.LayerSetting>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public int ReadList<T>(ref List<T> collection, bool allowNullification = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2A5D0 Offset: 0xF28FD0 VA: 0x180F2A5D0
	|-Reader.ReadList<CoordinateProceduralTilePair>
	|
	|-RVA: 0xD57DD0 Offset: 0xD567D0 VA: 0x180D57DD0
	|-Reader.ReadList<int>
	|
	|-RVA: 0xF2A960 Offset: 0xF29360 VA: 0x180F2A960
	|-Reader.ReadList<Int32Enum>
	|
	|-RVA: 0xF2ACB0 Offset: 0xF296B0 VA: 0x180F2ACB0
	|-Reader.ReadList<object>
	|
	|-RVA: 0xF2A7B0 Offset: 0xF291B0 VA: 0x180F2A7B0
	|-Reader.ReadList<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF2AAD0 Offset: 0xF294D0 VA: 0x180F2AAD0
	|-Reader.ReadList<AvatarSettings.LayerSetting>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public T[] ReadArrayAllocated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF29DA0 Offset: 0xF287A0 VA: 0x180F29DA0
	|-Reader.ReadArrayAllocated<int>
	|
	|-RVA: 0xF29D50 Offset: 0xF28750 VA: 0x180F29D50
	|-Reader.ReadArrayAllocated<Int32Enum>
	|
	|-RVA: 0xF29E40 Offset: 0xF28840 VA: 0x180F29E40
	|-Reader.ReadArrayAllocated<object>
	|
	|-RVA: 0xF29E90 Offset: 0xF28890 VA: 0x180F29E90
	|-Reader.ReadArrayAllocated<float>
	|
	|-RVA: 0xF29D00 Offset: 0xF28700 VA: 0x180F29D00
	|-Reader.ReadArrayAllocated<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF29DF0 Offset: 0xF287F0 VA: 0x180F29DF0
	|-Reader.ReadArrayAllocated<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public int ReadArray<T>(ref T[] collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA61910 Offset: 0xA60310 VA: 0x180A61910
	|-Reader.ReadArray<int>
	|
	|-RVA: 0xA61790 Offset: 0xA60190 VA: 0x180A61790
	|-Reader.ReadArray<Int32Enum>
	|
	|-RVA: 0x98BDD0 Offset: 0x98A7D0 VA: 0x18098BDD0
	|-Reader.ReadArray<object>
	|
	|-RVA: 0xA61A90 Offset: 0xA60490 VA: 0x180A61A90
	|-Reader.ReadArray<float>
	|
	|-RVA: 0x98BF60 Offset: 0x98A960 VA: 0x18098BF60
	|-Reader.ReadArray<ushort>
	|
	|-RVA: 0xF29EE0 Offset: 0xF288E0 VA: 0x180F29EE0
	|-Reader.ReadArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xCE3E40 Offset: 0xCE2840 VA: 0x180CE3E40
	|-Reader.ReadArray<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public T Read<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2B4B0 Offset: 0xF29EB0 VA: 0x180F2B4B0
	|-Reader.Read<ClientConnectionChangeBroadcast>
	|
	|-RVA: 0xF2B6A0 Offset: 0xF2A0A0 VA: 0x180F2B6A0
	|-Reader.Read<ClientScenesLoadedBroadcast>
	|
	|-RVA: 0xF2B890 Offset: 0xF2A290 VA: 0x180F2B890
	|-Reader.Read<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF2BA80 Offset: 0xF2A480 VA: 0x180F2BA80
	|-Reader.Read<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF2BCA0 Offset: 0xF2A6A0 VA: 0x180F2BCA0
	|-Reader.Read<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF2BE90 Offset: 0xF2A890 VA: 0x180F2BE90
	|-Reader.Read<HostPasswordBroadcast>
	|
	|-RVA: 0xF2C460 Offset: 0xF2AE60 VA: 0x180F2C460
	|-Reader.Read<int>
	|
	|-RVA: 0xF2C270 Offset: 0xF2AC70 VA: 0x180F2C270
	|-Reader.Read<Int32Enum>
	|
	|-RVA: 0xF2C870 Offset: 0xF2B270 VA: 0x180F2C870
	|-Reader.Read<LoadScenesBroadcast>
	|
	|-RVA: 0xF2D270 Offset: 0xF2BC70 VA: 0x180F2D270
	|-Reader.Read<object>
	|
	|-RVA: 0xF2CC50 Offset: 0xF2B650 VA: 0x180F2CC50
	|-Reader.Read<PasswordBroadcast>
	|
	|-RVA: 0xF2D080 Offset: 0xF2BA80 VA: 0x180F2D080
	|-Reader.Read<ResponseBroadcast>
	|
	|-RVA: 0xF2D460 Offset: 0xF2BE60 VA: 0x180F2D460
	|-Reader.Read<float>
	|
	|-RVA: 0xF2D650 Offset: 0xF2C050 VA: 0x180F2D650
	|-Reader.Read<Structy>
	|
	|-RVA: 0xF2D840 Offset: 0xF2C240 VA: 0x180F2D840
	|-Reader.Read<ushort>
	|
	|-RVA: 0xF2DA70 Offset: 0xF2C470 VA: 0x180F2DA70
	|-Reader.Read<UnloadScenesBroadcast>
	|
	|-RVA: 0xF2C080 Offset: 0xF2AA80 VA: 0x180F2C080
	|-Reader.Read<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF2C650 Offset: 0xF2B050 VA: 0x180F2C650
	|-Reader.Read<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xF2CA60 Offset: 0xF2B460 VA: 0x180F2CA60
	|-Reader.Read<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF2CE40 Offset: 0xF2B840 VA: 0x180F2CE40
	|-Reader.Read<RigidbodyPrediction.ReconcileData>
	*/

	// RVA: 0xD18110 Offset: 0xD16B10 VA: 0x180D18110
	private void LogWarning(string msg) { }

	// RVA: 0xD18050 Offset: 0xD16A50 VA: 0x180D18050
	private void LogError(string msg) { }

	// RVA: -1 Offset: -1
	internal bool IsAutoPackType<T>(out AutoPackType packType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF29CC0 Offset: 0xF286C0 VA: 0x180F29CC0
	|-Reader.IsAutoPackType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD17F50 Offset: 0xD16950 VA: 0x180D17F50
	internal bool IsAutoPackType(Type type, out AutoPackType packType) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal static string <Read>g__GetLogMessage|102_0<T>(ref Reader.<>c__DisplayClass102_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF2DC60 Offset: 0xF2C660 VA: 0x180F2DC60
	|-Reader.<Read>g__GetLogMessage|102_0<ClientConnectionChangeBroadcast>
	|
	|-RVA: 0xF2DCD0 Offset: 0xF2C6D0 VA: 0x180F2DCD0
	|-Reader.<Read>g__GetLogMessage|102_0<ClientScenesLoadedBroadcast>
	|
	|-RVA: 0xF2DD40 Offset: 0xF2C740 VA: 0x180F2DD40
	|-Reader.<Read>g__GetLogMessage|102_0<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF2DDB0 Offset: 0xF2C7B0 VA: 0x180F2DDB0
	|-Reader.<Read>g__GetLogMessage|102_0<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF2DE20 Offset: 0xF2C820 VA: 0x180F2DE20
	|-Reader.<Read>g__GetLogMessage|102_0<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF2DE90 Offset: 0xF2C890 VA: 0x180F2DE90
	|-Reader.<Read>g__GetLogMessage|102_0<HostPasswordBroadcast>
	|
	|-RVA: 0xF2DFE0 Offset: 0xF2C9E0 VA: 0x180F2DFE0
	|-Reader.<Read>g__GetLogMessage|102_0<int>
	|
	|-RVA: 0xF2DF70 Offset: 0xF2C970 VA: 0x180F2DF70
	|-Reader.<Read>g__GetLogMessage|102_0<Int32Enum>
	|
	|-RVA: 0xF2E0C0 Offset: 0xF2CAC0 VA: 0x180F2E0C0
	|-Reader.<Read>g__GetLogMessage|102_0<LoadScenesBroadcast>
	|
	|-RVA: 0xF2E2F0 Offset: 0xF2CCF0 VA: 0x180F2E2F0
	|-Reader.<Read>g__GetLogMessage|102_0<object>
	|
	|-RVA: 0xF2E1A0 Offset: 0xF2CBA0 VA: 0x180F2E1A0
	|-Reader.<Read>g__GetLogMessage|102_0<PasswordBroadcast>
	|
	|-RVA: 0xF2E280 Offset: 0xF2CC80 VA: 0x180F2E280
	|-Reader.<Read>g__GetLogMessage|102_0<ResponseBroadcast>
	|
	|-RVA: 0xF2E360 Offset: 0xF2CD60 VA: 0x180F2E360
	|-Reader.<Read>g__GetLogMessage|102_0<float>
	|
	|-RVA: 0xF2E3D0 Offset: 0xF2CDD0 VA: 0x180F2E3D0
	|-Reader.<Read>g__GetLogMessage|102_0<Structy>
	|
	|-RVA: 0xF2E440 Offset: 0xF2CE40 VA: 0x180F2E440
	|-Reader.<Read>g__GetLogMessage|102_0<ushort>
	|
	|-RVA: 0xF2E4B0 Offset: 0xF2CEB0 VA: 0x180F2E4B0
	|-Reader.<Read>g__GetLogMessage|102_0<UnloadScenesBroadcast>
	|
	|-RVA: 0xF2DF00 Offset: 0xF2C900 VA: 0x180F2DF00
	|-Reader.<Read>g__GetLogMessage|102_0<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF2E050 Offset: 0xF2CA50 VA: 0x180F2E050
	|-Reader.<Read>g__GetLogMessage|102_0<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xF2E130 Offset: 0xF2CB30 VA: 0x180F2E130
	|-Reader.<Read>g__GetLogMessage|102_0<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF2E210 Offset: 0xF2CC10 VA: 0x180F2E210
	|-Reader.<Read>g__GetLogMessage|102_0<RigidbodyPrediction.ReconcileData>
	*/
}
