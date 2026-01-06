public class Writer // TypeDefIndex: 12510
{
	// Fields
	public int Position; // 0x10
	public int Length; // 0x14
	public NetworkManager NetworkManager; // 0x18
	private byte[] _buffer; // 0x20
	internal const byte REPLICATE_DEFAULT_BYTE = 0;
	internal const byte REPLICATE_DUPLICATE_BYTE = 1;
	internal const byte REPLICATE_UNIQUE_BYTE = 2;
	internal const byte REPLICATE_REPEATING_BYTE = 3;
	internal const byte REPLICATE_ALL_DEFAULT_BYTE = 4;
	public const int UNSET_COLLECTION_SIZE_VALUE = -1;

	// Properties
	public int Capacity { get; }

	// Methods

	// RVA: 0xD234F0 Offset: 0xD21EF0 VA: 0x180D234F0
	public int get_Capacity() { }

	// RVA: 0xD202B0 Offset: 0xD1ECB0 VA: 0x180D202B0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD20290 Offset: 0xD1EC90 VA: 0x180D20290
	public void Reset(NetworkManager manager) { }

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79CD0 Offset: 0xF786D0 VA: 0x180F79CD0
	|-Writer.WriteDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD1FEB0 Offset: 0xD1E8B0 VA: 0x180D1FEB0
	public void EnsureBufferCapacity(int count) { }

	// RVA: 0xD1FF10 Offset: 0xD1E910 VA: 0x180D1FF10
	public void EnsureBufferLength(int count) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public byte[] GetBuffer() { }

	// RVA: 0xD1FFB0 Offset: 0xD1E9B0 VA: 0x180D1FFB0
	public ArraySegment<byte> GetArraySegment() { }

	// RVA: 0xD201D0 Offset: 0xD1EBD0 VA: 0x180D201D0
	public void Reserve(int count) { }

	[CodegenExclude]
	// RVA: 0xD21360 Offset: 0xD1FD60 VA: 0x180D21360
	internal void WriteLength(int length) { }

	[CodegenExclude]
	// RVA: 0xD21830 Offset: 0xD20230 VA: 0x180D21830
	internal void WritePacketId(PacketId pid) { }

	[CodegenExclude]
	// RVA: 0xD1FF80 Offset: 0xD1E980 VA: 0x180D1FF80
	public void FastInsertByte(byte value, int index) { }

	// RVA: 0xD205C0 Offset: 0xD1EFC0 VA: 0x180D205C0
	public void WriteByte(byte value) { }

	[CodegenExclude]
	// RVA: 0xD207C0 Offset: 0xD1F1C0 VA: 0x180D207C0
	public void WriteBytes(byte[] value, int offset, int count) { }

	[CodegenExclude]
	// RVA: 0xD20730 Offset: 0xD1F130 VA: 0x180D20730
	public void WriteBytesAndSize(byte[] value, int offset, int count) { }

	// RVA: 0xD206B0 Offset: 0xD1F0B0 VA: 0x180D206B0
	public void WriteBytesAndSize(byte[] value) { }

	// RVA: 0xD22960 Offset: 0xD21360 VA: 0x180D22960
	public void WriteSByte(sbyte value) { }

	// RVA: 0xD208C0 Offset: 0xD1F2C0 VA: 0x180D208C0
	public void WriteChar(char value) { }

	// RVA: 0xD204D0 Offset: 0xD1EED0 VA: 0x180D204D0
	public void WriteBoolean(bool value) { }

	// RVA: 0xD22DD0 Offset: 0xD217D0 VA: 0x180D22DD0
	public void WriteUInt16(ushort value) { }

	// RVA: 0xD211F0 Offset: 0xD1FBF0 VA: 0x180D211F0
	public void WriteInt16(short value) { }

	// RVA: 0xD21300 Offset: 0xD1FD00 VA: 0x180D21300
	public void WriteInt32(int value, AutoPackType packType = 1) { }

	// RVA: 0xD22EE0 Offset: 0xD218E0 VA: 0x180D22EE0
	public void WriteUInt32(uint value, AutoPackType packType = 1) { }

	// RVA: 0xD21330 Offset: 0xD1FD30 VA: 0x180D21330
	public void WriteInt64(long value, AutoPackType packType = 1) { }

	// RVA: 0xD23060 Offset: 0xD21A60 VA: 0x180D23060
	public void WriteUInt64(ulong value, AutoPackType packType = 1) { }

	// RVA: 0xD22A50 Offset: 0xD21450 VA: 0x180D22A50
	public void WriteSingle(float value, AutoPackType packType = 0) { }

	// RVA: 0xD20DF0 Offset: 0xD1F7F0 VA: 0x180D20DF0
	public void WriteDouble(double value) { }

	// RVA: 0xD20DB0 Offset: 0xD1F7B0 VA: 0x180D20DB0
	public void WriteDecimal(Decimal value) { }

	// RVA: 0xD22A90 Offset: 0xD21490 VA: 0x180D22A90
	public void WriteString(string value) { }

	// RVA: 0xD20360 Offset: 0xD1ED60 VA: 0x180D20360
	public void WriteArraySegmentAndSize(ArraySegment<byte> value) { }

	[CodegenExclude]
	// RVA: 0xD20440 Offset: 0xD1EE40 VA: 0x180D20440
	public void WriteArraySegment(ArraySegment<byte> value) { }

	// RVA: 0xD23330 Offset: 0xD21D30 VA: 0x180D23330
	public void WriteVector2(Vector2 value) { }

	// RVA: 0xD23420 Offset: 0xD21E20 VA: 0x180D23420
	public void WriteVector3(Vector3 value) { }

	// RVA: 0xD23470 Offset: 0xD21E70 VA: 0x180D23470
	public void WriteVector4(Vector4 value) { }

	// RVA: 0xD232A0 Offset: 0xD21CA0 VA: 0x180D232A0
	public void WriteVector2Int(Vector2Int value, AutoPackType packType = 1) { }

	// RVA: 0xD23360 Offset: 0xD21D60 VA: 0x180D23360
	public void WriteVector3Int(Vector3Int value, AutoPackType packType = 1) { }

	// RVA: 0xD20B30 Offset: 0xD1F530 VA: 0x180D20B30
	public void WriteColor(Color value, AutoPackType packType = 1) { }

	// RVA: 0xD209D0 Offset: 0xD1F3D0 VA: 0x180D209D0
	public void WriteColor32(Color32 value) { }

	// RVA: 0xD224D0 Offset: 0xD20ED0 VA: 0x180D224D0
	public void WriteQuaternion(Quaternion value, AutoPackType packType = 1) { }

	// RVA: 0xD22900 Offset: 0xD21300 VA: 0x180D22900
	public void WriteRect(Rect value) { }

	// RVA: 0xD22450 Offset: 0xD20E50 VA: 0x180D22450
	public void WritePlane(Plane value) { }

	// RVA: 0xD22850 Offset: 0xD21250 VA: 0x180D22850
	public void WriteRay(Ray value) { }

	// RVA: 0xD227E0 Offset: 0xD211E0 VA: 0x180D227E0
	public void WriteRay2D(Ray2D value) { }

	// RVA: 0xD21390 Offset: 0xD1FD90 VA: 0x180D21390
	public void WriteMatrix4x4(Matrix4x4 value) { }

	// RVA: 0xD211A0 Offset: 0xD1FBA0 VA: 0x180D211A0
	public void WriteGuidAllocated(Guid value) { }

	[CodegenExclude]
	// RVA: 0xD22A80 Offset: 0xD21480 VA: 0x180D22A80
	public void WriteTickUnpacked(uint value) { }

	// RVA: 0xD20E00 Offset: 0xD1F800 VA: 0x180D20E00
	public void WriteGameObject(GameObject go) { }

	// RVA: 0xD22CD0 Offset: 0xD216D0 VA: 0x180D22CD0
	public void WriteTransform(Transform t) { }

	// RVA: 0xD21840 Offset: 0xD20240 VA: 0x180D21840
	public void WriteNetworkObject(NetworkObject nob) { }

	[CodegenExclude]
	// RVA: 0xD217B0 Offset: 0xD201B0 VA: 0x180D217B0
	public void WriteNetworkObjectId(NetworkObject nob) { }

	[CodegenExclude]
	// RVA: 0xD21910 Offset: 0xD20310 VA: 0x180D21910
	internal void WriteNetworkObject(NetworkObject nob, bool forSpawn) { }

	[CodegenExclude]
	// RVA: 0xD21750 Offset: 0xD20150 VA: 0x180D21750
	internal void WriteNetworkObjectForDespawn(NetworkObject nob, DespawnType dt) { }

	[CodegenExclude]
	// RVA: 0xD21830 Offset: 0xD20230 VA: 0x180D21830
	public void WriteNetworkObjectId(int objectId) { }

	[CodegenExclude]
	// RVA: 0xD217A0 Offset: 0xD201A0 VA: 0x180D217A0
	internal void WriteNetworkObjectForSpawn(NetworkObject nob) { }

	// RVA: 0xD21610 Offset: 0xD20010 VA: 0x180D21610
	public void WriteNetworkBehaviour(NetworkBehaviour nb) { }

	[CodegenExclude]
	// RVA: 0xD214C0 Offset: 0xD1FEC0 VA: 0x180D214C0
	public void WriteNetworkBehaviourId(NetworkBehaviour nb) { }

	// RVA: 0xD20D30 Offset: 0xD1F730 VA: 0x180D20D30
	public void WriteDateTime(DateTime dt) { }

	// RVA: 0xD208B0 Offset: 0xD1F2B0 VA: 0x180D208B0
	public void WriteChannel(Channel channel) { }

	// RVA: 0xD21700 Offset: 0xD20100 VA: 0x180D21700
	public void WriteNetworkConnection(NetworkConnection connection) { }

	[CodegenExclude]
	// RVA: 0xD216F0 Offset: 0xD200F0 VA: 0x180D216F0
	public void WriteNetworkConnectionId(short id) { }

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteListCache<T>(ListCache<T> lc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7A0E0 Offset: 0xF78AE0 VA: 0x180F7A0E0
	|-Writer.WriteListCache<__Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteList<T>(List<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7A250 Offset: 0xF78C50 VA: 0x180F7A250
	|-Writer.WriteList<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF7A840 Offset: 0xF79240 VA: 0x180F7A840
	|-Writer.WriteList<int>
	|
	|-RVA: 0xF7A6B0 Offset: 0xF790B0 VA: 0x180F7A6B0
	|-Writer.WriteList<Int32Enum>
	|
	|-RVA: 0xF7AB80 Offset: 0xF79580 VA: 0x180F7AB80
	|-Writer.WriteList<object>
	|
	|-RVA: 0xF7A2F0 Offset: 0xF78CF0 VA: 0x180F7A2F0
	|-Writer.WriteList<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF7A8E0 Offset: 0xF792E0 VA: 0x180F7A8E0
	|-Writer.WriteList<AvatarSettings.LayerSetting>
	*/

	[CodegenExclude]
	// RVA: 0xD22A80 Offset: 0xD21480 VA: 0x180D22A80
	internal void WriteStateUpdatePacket(uint lastPacketTick) { }

	[CodegenExclude]
	// RVA: 0xD234D0 Offset: 0xD21ED0 VA: 0x180D234D0
	public ulong ZigZagEncode(ulong value) { }

	[CodegenExclude]
	// RVA: 0xD21A20 Offset: 0xD20420 VA: 0x180D21A20
	public void WritePackedWhole(ulong value) { }

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteList<T>(List<T> value, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7A140 Offset: 0xF78B40 VA: 0x180F7A140
	|-Writer.WriteList<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF7A750 Offset: 0xF79150 VA: 0x180F7A750
	|-Writer.WriteList<int>
	|
	|-RVA: 0xF7A5C0 Offset: 0xF78FC0 VA: 0x180F7A5C0
	|-Writer.WriteList<Int32Enum>
	|
	|-RVA: 0xF7AA90 Offset: 0xF79490 VA: 0x180F7AA90
	|-Writer.WriteList<object>
	|
	|-RVA: 0xF7A430 Offset: 0xF78E30 VA: 0x180F7A430
	|-Writer.WriteList<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF7A980 Offset: 0xF79380 VA: 0x180F7A980
	|-Writer.WriteList<AvatarSettings.LayerSetting>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteList<T>(List<T> value, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7A390 Offset: 0xF78D90 VA: 0x180F7A390
	|-Writer.WriteList<__Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	internal void WriteReplicate<T>(List<T> values, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7AC20 Offset: 0xF79620 VA: 0x180F7AC20
	|-Writer.WriteReplicate<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF021E0 Offset: 0xF00BE0 VA: 0x180F021E0
	|-Writer.WriteReplicate<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteArray<T>(T[] value, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF795E0 Offset: 0xF77FE0 VA: 0x180F795E0
	|-Writer.WriteArray<int>
	|
	|-RVA: 0xF79440 Offset: 0xF77E40 VA: 0x180F79440
	|-Writer.WriteArray<Int32Enum>
	|
	|-RVA: 0xF79890 Offset: 0xF78290 VA: 0x180F79890
	|-Writer.WriteArray<object>
	|
	|-RVA: 0xF79AD0 Offset: 0xF784D0 VA: 0x180F79AD0
	|-Writer.WriteArray<float>
	|
	|-RVA: 0xF79BD0 Offset: 0xF785D0 VA: 0x180F79BD0
	|-Writer.WriteArray<ushort>
	|
	|-RVA: 0xF791C0 Offset: 0xF77BC0 VA: 0x180F791C0
	|-Writer.WriteArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF796E0 Offset: 0xF780E0 VA: 0x180F796E0
	|-Writer.WriteArray<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteArray<T>(T[] value, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79320 Offset: 0xF77D20 VA: 0x180F79320
	|-Writer.WriteArray<__Il2CppFullySharedGenericType>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void WriteArray<T>(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79540 Offset: 0xF77F40 VA: 0x180F79540
	|-Writer.WriteArray<int>
	|
	|-RVA: 0xF793A0 Offset: 0xF77DA0 VA: 0x180F793A0
	|-Writer.WriteArray<Int32Enum>
	|
	|-RVA: 0xF79990 Offset: 0xF78390 VA: 0x180F79990
	|-Writer.WriteArray<object>
	|
	|-RVA: 0xF79A30 Offset: 0xF78430 VA: 0x180F79A30
	|-Writer.WriteArray<float>
	|
	|-RVA: 0xF79140 Offset: 0xF77B40 VA: 0x180F79140
	|-Writer.WriteArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF797F0 Offset: 0xF781F0 VA: 0x180F797F0
	|-Writer.WriteArray<RigidbodyPrediction.MoveData>
	*/

	[CodegenExclude]
	// RVA: -1 Offset: -1
	public void Write<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7B270 Offset: 0xF79C70 VA: 0x180F7B270
	|-Writer.Write<bool>
	|
	|-RVA: 0xF7B460 Offset: 0xF79E60 VA: 0x180F7B460
	|-Writer.Write<ClientConnectionChangeBroadcast>
	|
	|-RVA: 0xF7B650 Offset: 0xF7A050 VA: 0x180F7B650
	|-Writer.Write<ClientScenesLoadedBroadcast>
	|
	|-RVA: 0xF7B840 Offset: 0xF7A240 VA: 0x180F7B840
	|-Writer.Write<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF7BA30 Offset: 0xF7A430 VA: 0x180F7BA30
	|-Writer.Write<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF7BC60 Offset: 0xF7A660 VA: 0x180F7BC60
	|-Writer.Write<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF7BE50 Offset: 0xF7A850 VA: 0x180F7BE50
	|-Writer.Write<HostPasswordBroadcast>
	|
	|-RVA: 0xF7C420 Offset: 0xF7AE20 VA: 0x180F7C420
	|-Writer.Write<int>
	|
	|-RVA: 0xF7C230 Offset: 0xF7AC30 VA: 0x180F7C230
	|-Writer.Write<Int32Enum>
	|
	|-RVA: 0xF7C840 Offset: 0xF7B240 VA: 0x180F7C840
	|-Writer.Write<LoadScenesBroadcast>
	|
	|-RVA: 0xF7D470 Offset: 0xF7BE70 VA: 0x180F7D470
	|-Writer.Write<object>
	|
	|-RVA: 0xF7CC30 Offset: 0xF7B630 VA: 0x180F7CC30
	|-Writer.Write<PasswordBroadcast>
	|
	|-RVA: 0xF7CE20 Offset: 0xF7B820 VA: 0x180F7CE20
	|-Writer.Write<Quaternion>
	|
	|-RVA: 0xF7D280 Offset: 0xF7BC80 VA: 0x180F7D280
	|-Writer.Write<ResponseBroadcast>
	|
	|-RVA: 0xF7D660 Offset: 0xF7C060 VA: 0x180F7D660
	|-Writer.Write<float>
	|
	|-RVA: 0xF7D850 Offset: 0xF7C250 VA: 0x180F7D850
	|-Writer.Write<Structy>
	|
	|-RVA: 0xF7DA50 Offset: 0xF7C450 VA: 0x180F7DA50
	|-Writer.Write<ushort>
	|
	|-RVA: 0xF7DC40 Offset: 0xF7C640 VA: 0x180F7DC40
	|-Writer.Write<UnloadScenesBroadcast>
	|
	|-RVA: 0xF7DE30 Offset: 0xF7C830 VA: 0x180F7DE30
	|-Writer.Write<Vector3>
	|
	|-RVA: 0xF7C040 Offset: 0xF7AA40 VA: 0x180F7C040
	|-Writer.Write<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF7C610 Offset: 0xF7B010 VA: 0x180F7C610
	|-Writer.Write<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xF7CA30 Offset: 0xF7B430 VA: 0x180F7CA30
	|-Writer.Write<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF7D020 Offset: 0xF7BA20 VA: 0x180F7D020
	|-Writer.Write<RigidbodyPrediction.ReconcileData>
	*/

	// RVA: 0xD20110 Offset: 0xD1EB10 VA: 0x180D20110
	private void LogError(string msg) { }

	// RVA: -1 Offset: -1
	internal static bool IsAutoPackType<T>(out AutoPackType packType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF786C0 Offset: 0xF770C0 VA: 0x180F786C0
	|-Writer.IsAutoPackType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD20010 Offset: 0xD1EA10 VA: 0x180D20010
	internal static bool IsAutoPackType(Type type, out AutoPackType packType) { }

	// RVA: 0xD16840 Offset: 0xD15240 VA: 0x180D16840
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal static string <Write>g__GetLogMessage|82_0<T>(ref Writer.<>c__DisplayClass82_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF78730 Offset: 0xF77130 VA: 0x180F78730
	|-Writer.<Write>g__GetLogMessage|82_0<bool>
	|
	|-RVA: 0xF787A0 Offset: 0xF771A0 VA: 0x180F787A0
	|-Writer.<Write>g__GetLogMessage|82_0<ClientConnectionChangeBroadcast>
	|
	|-RVA: 0xF78810 Offset: 0xF77210 VA: 0x180F78810
	|-Writer.<Write>g__GetLogMessage|82_0<ClientScenesLoadedBroadcast>
	|
	|-RVA: 0xF78880 Offset: 0xF77280 VA: 0x180F78880
	|-Writer.<Write>g__GetLogMessage|82_0<ConnectedClientsBroadcast>
	|
	|-RVA: 0xF788F0 Offset: 0xF772F0 VA: 0x180F788F0
	|-Writer.<Write>g__GetLogMessage|82_0<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF78960 Offset: 0xF77360 VA: 0x180F78960
	|-Writer.<Write>g__GetLogMessage|82_0<EmptyStartScenesBroadcast>
	|
	|-RVA: 0xF789D0 Offset: 0xF773D0 VA: 0x180F789D0
	|-Writer.<Write>g__GetLogMessage|82_0<HostPasswordBroadcast>
	|
	|-RVA: 0xF78B20 Offset: 0xF77520 VA: 0x180F78B20
	|-Writer.<Write>g__GetLogMessage|82_0<int>
	|
	|-RVA: 0xF78AB0 Offset: 0xF774B0 VA: 0x180F78AB0
	|-Writer.<Write>g__GetLogMessage|82_0<Int32Enum>
	|
	|-RVA: 0xF78C00 Offset: 0xF77600 VA: 0x180F78C00
	|-Writer.<Write>g__GetLogMessage|82_0<LoadScenesBroadcast>
	|
	|-RVA: 0xF78EA0 Offset: 0xF778A0 VA: 0x180F78EA0
	|-Writer.<Write>g__GetLogMessage|82_0<object>
	|
	|-RVA: 0xF78CE0 Offset: 0xF776E0 VA: 0x180F78CE0
	|-Writer.<Write>g__GetLogMessage|82_0<PasswordBroadcast>
	|
	|-RVA: 0xF78D50 Offset: 0xF77750 VA: 0x180F78D50
	|-Writer.<Write>g__GetLogMessage|82_0<Quaternion>
	|
	|-RVA: 0xF78E30 Offset: 0xF77830 VA: 0x180F78E30
	|-Writer.<Write>g__GetLogMessage|82_0<ResponseBroadcast>
	|
	|-RVA: 0xF78F10 Offset: 0xF77910 VA: 0x180F78F10
	|-Writer.<Write>g__GetLogMessage|82_0<float>
	|
	|-RVA: 0xF78F80 Offset: 0xF77980 VA: 0x180F78F80
	|-Writer.<Write>g__GetLogMessage|82_0<Structy>
	|
	|-RVA: 0xF78FF0 Offset: 0xF779F0 VA: 0x180F78FF0
	|-Writer.<Write>g__GetLogMessage|82_0<ushort>
	|
	|-RVA: 0xF79060 Offset: 0xF77A60 VA: 0x180F79060
	|-Writer.<Write>g__GetLogMessage|82_0<UnloadScenesBroadcast>
	|
	|-RVA: 0xF790D0 Offset: 0xF77AD0 VA: 0x180F790D0
	|-Writer.<Write>g__GetLogMessage|82_0<Vector3>
	|
	|-RVA: 0xF78A40 Offset: 0xF77440 VA: 0x180F78A40
	|-Writer.<Write>g__GetLogMessage|82_0<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF78B90 Offset: 0xF77590 VA: 0x180F78B90
	|-Writer.<Write>g__GetLogMessage|82_0<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xF78C70 Offset: 0xF77670 VA: 0x180F78C70
	|-Writer.<Write>g__GetLogMessage|82_0<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF78DC0 Offset: 0xF777C0 VA: 0x180F78DC0
	|-Writer.<Write>g__GetLogMessage|82_0<RigidbodyPrediction.ReconcileData>
	*/
}
