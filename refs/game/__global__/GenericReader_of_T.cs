public static class GenericReader<T> // TypeDefIndex: 12499
{
	// Fields
	[CompilerGenerated]
	private static Func<Reader, T> <Read>k__BackingField; // 0x0
	[CompilerGenerated]
	private static Func<Reader, AutoPackType, T> <ReadAutoPack>k__BackingField; // 0x0

	// Properties
	internal static Func<Reader, T> Read { get; set; }
	internal static Func<Reader, AutoPackType, T> ReadAutoPack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal static Func<Reader, T> get_Read() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10973F0 Offset: 0x1095DF0 VA: 0x1810973F0
	|-GenericReader<ArraySegment<byte>>.get_Read
	|-GenericReader<bool>.get_Read
	|-GenericReader<byte>.get_Read
	|-GenericReader<ByteEnum>.get_Read
	|-GenericReader<char>.get_Read
	|-GenericReader<ClientConnectionChangeBroadcast>.get_Read
	|-GenericReader<ClientScenesLoadedBroadcast>.get_Read
	|-GenericReader<Color>.get_Read
	|-GenericReader<Color32>.get_Read
	|-GenericReader<ConnectedClientsBroadcast>.get_Read
	|-GenericReader<CoordinateProceduralTilePair>.get_Read
	|-GenericReader<DateTime>.get_Read
	|-GenericReader<Decimal>.get_Read
	|-GenericReader<double>.get_Read
	|-GenericReader<EmptyStartScenesBroadcast>.get_Read
	|-GenericReader<ExplosionData>.get_Read
	|-GenericReader<FullRank>.get_Read
	|-GenericReader<GameDateTime>.get_Read
	|-GenericReader<Guid>.get_Read
	|-GenericReader<HostPasswordBroadcast>.get_Read
	|-GenericReader<short>.get_Read
	|-GenericReader<int>.get_Read
	|-GenericReader<Int32Enum>.get_Read
	|-GenericReader<long>.get_Read
	|-GenericReader<LoadScenesBroadcast>.get_Read
	|-GenericReader<Matrix4x4>.get_Read
	|-GenericReader<object>.get_Read
	|-GenericReader<PasswordBroadcast>.get_Read
	|-GenericReader<Plane>.get_Read
	|-GenericReader<PreciseTick>.get_Read
	|-GenericReader<Quaternion>.get_Read
	|-GenericReader<Ray>.get_Read
	|-GenericReader<Ray2D>.get_Read
	|-GenericReader<Rect>.get_Read
	|-GenericReader<ResponseBroadcast>.get_Read
	|-GenericReader<Rigidbody2DState>.get_Read
	|-GenericReader<RigidbodyState>.get_Read
	|-GenericReader<sbyte>.get_Read
	|-GenericReader<float>.get_Read
	|-GenericReader<Structy>.get_Read
	|-GenericReader<ushort>.get_Read
	|-GenericReader<uint>.get_Read
	|-GenericReader<ulong>.get_Read
	|-GenericReader<UShort2>.get_Read
	|-GenericReader<UnloadScenesBroadcast>.get_Read
	|-GenericReader<Vector2>.get_Read
	|-GenericReader<Vector2Int>.get_Read
	|-GenericReader<Vector3>.get_Read
	|-GenericReader<Vector3Int>.get_Read
	|-GenericReader<Vector4>.get_Read
	|-GenericReader<__Il2CppFullySharedGenericType>.get_Read
	|-GenericReader<AvatarSettings.LayerSetting>.get_Read
	|-GenericReader<Eye.EyeLidConfiguration>.get_Read
	|-GenericReader<RigidbodyPrediction.MoveData>.get_Read
	|-GenericReader<RigidbodyPrediction.ReconcileData>.get_Read
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static void set_Read(Func<Reader, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA616F0 Offset: 0xA600F0 VA: 0x180A616F0
	|-GenericReader<ArraySegment<byte>>.set_Read
	|-GenericReader<bool>.set_Read
	|-GenericReader<byte>.set_Read
	|-GenericReader<ByteEnum>.set_Read
	|-GenericReader<char>.set_Read
	|-GenericReader<ClientConnectionChangeBroadcast>.set_Read
	|-GenericReader<ClientScenesLoadedBroadcast>.set_Read
	|-GenericReader<Color>.set_Read
	|-GenericReader<Color32>.set_Read
	|-GenericReader<ConnectedClientsBroadcast>.set_Read
	|-GenericReader<CoordinateProceduralTilePair>.set_Read
	|-GenericReader<DateTime>.set_Read
	|-GenericReader<Decimal>.set_Read
	|-GenericReader<double>.set_Read
	|-GenericReader<EmptyStartScenesBroadcast>.set_Read
	|-GenericReader<ExplosionData>.set_Read
	|-GenericReader<FullRank>.set_Read
	|-GenericReader<GameDateTime>.set_Read
	|-GenericReader<Guid>.set_Read
	|-GenericReader<HostPasswordBroadcast>.set_Read
	|-GenericReader<short>.set_Read
	|-GenericReader<int>.set_Read
	|-GenericReader<Int32Enum>.set_Read
	|-GenericReader<long>.set_Read
	|-GenericReader<LoadScenesBroadcast>.set_Read
	|-GenericReader<Matrix4x4>.set_Read
	|-GenericReader<object>.set_Read
	|-GenericReader<PasswordBroadcast>.set_Read
	|-GenericReader<Plane>.set_Read
	|-GenericReader<PreciseTick>.set_Read
	|-GenericReader<Quaternion>.set_Read
	|-GenericReader<Ray>.set_Read
	|-GenericReader<Ray2D>.set_Read
	|-GenericReader<Rect>.set_Read
	|-GenericReader<ResponseBroadcast>.set_Read
	|-GenericReader<Rigidbody2DState>.set_Read
	|-GenericReader<RigidbodyState>.set_Read
	|-GenericReader<sbyte>.set_Read
	|-GenericReader<float>.set_Read
	|-GenericReader<Structy>.set_Read
	|-GenericReader<ushort>.set_Read
	|-GenericReader<uint>.set_Read
	|-GenericReader<ulong>.set_Read
	|-GenericReader<UShort2>.set_Read
	|-GenericReader<UnloadScenesBroadcast>.set_Read
	|-GenericReader<Vector2>.set_Read
	|-GenericReader<Vector2Int>.set_Read
	|-GenericReader<Vector3>.set_Read
	|-GenericReader<Vector3Int>.set_Read
	|-GenericReader<Vector4>.set_Read
	|-GenericReader<__Il2CppFullySharedGenericType>.set_Read
	|-GenericReader<AvatarSettings.LayerSetting>.set_Read
	|-GenericReader<Eye.EyeLidConfiguration>.set_Read
	|-GenericReader<RigidbodyPrediction.MoveData>.set_Read
	|-GenericReader<RigidbodyPrediction.ReconcileData>.set_Read
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal static Func<Reader, AutoPackType, T> get_ReadAutoPack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180EF00 Offset: 0x180D900 VA: 0x18180EF00
	|-GenericReader<ArraySegment<byte>>.get_ReadAutoPack
	|-GenericReader<bool>.get_ReadAutoPack
	|-GenericReader<byte>.get_ReadAutoPack
	|-GenericReader<ByteEnum>.get_ReadAutoPack
	|-GenericReader<char>.get_ReadAutoPack
	|-GenericReader<ClientConnectionChangeBroadcast>.get_ReadAutoPack
	|-GenericReader<ClientScenesLoadedBroadcast>.get_ReadAutoPack
	|-GenericReader<Color>.get_ReadAutoPack
	|-GenericReader<Color32>.get_ReadAutoPack
	|-GenericReader<ConnectedClientsBroadcast>.get_ReadAutoPack
	|-GenericReader<CoordinateProceduralTilePair>.get_ReadAutoPack
	|-GenericReader<DateTime>.get_ReadAutoPack
	|-GenericReader<Decimal>.get_ReadAutoPack
	|-GenericReader<double>.get_ReadAutoPack
	|-GenericReader<EmptyStartScenesBroadcast>.get_ReadAutoPack
	|-GenericReader<ExplosionData>.get_ReadAutoPack
	|-GenericReader<FullRank>.get_ReadAutoPack
	|-GenericReader<GameDateTime>.get_ReadAutoPack
	|-GenericReader<Guid>.get_ReadAutoPack
	|-GenericReader<HostPasswordBroadcast>.get_ReadAutoPack
	|-GenericReader<short>.get_ReadAutoPack
	|-GenericReader<int>.get_ReadAutoPack
	|-GenericReader<Int32Enum>.get_ReadAutoPack
	|-GenericReader<long>.get_ReadAutoPack
	|-GenericReader<LoadScenesBroadcast>.get_ReadAutoPack
	|-GenericReader<Matrix4x4>.get_ReadAutoPack
	|-GenericReader<object>.get_ReadAutoPack
	|-GenericReader<PasswordBroadcast>.get_ReadAutoPack
	|-GenericReader<Plane>.get_ReadAutoPack
	|-GenericReader<PreciseTick>.get_ReadAutoPack
	|-GenericReader<Quaternion>.get_ReadAutoPack
	|-GenericReader<Ray>.get_ReadAutoPack
	|-GenericReader<Ray2D>.get_ReadAutoPack
	|-GenericReader<Rect>.get_ReadAutoPack
	|-GenericReader<ResponseBroadcast>.get_ReadAutoPack
	|-GenericReader<Rigidbody2DState>.get_ReadAutoPack
	|-GenericReader<RigidbodyState>.get_ReadAutoPack
	|-GenericReader<sbyte>.get_ReadAutoPack
	|-GenericReader<float>.get_ReadAutoPack
	|-GenericReader<Structy>.get_ReadAutoPack
	|-GenericReader<ushort>.get_ReadAutoPack
	|-GenericReader<uint>.get_ReadAutoPack
	|-GenericReader<ulong>.get_ReadAutoPack
	|-GenericReader<UShort2>.get_ReadAutoPack
	|-GenericReader<UnloadScenesBroadcast>.get_ReadAutoPack
	|-GenericReader<Vector2>.get_ReadAutoPack
	|-GenericReader<Vector2Int>.get_ReadAutoPack
	|-GenericReader<Vector3>.get_ReadAutoPack
	|-GenericReader<Vector3Int>.get_ReadAutoPack
	|-GenericReader<Vector4>.get_ReadAutoPack
	|-GenericReader<__Il2CppFullySharedGenericType>.get_ReadAutoPack
	|-GenericReader<AvatarSettings.LayerSetting>.get_ReadAutoPack
	|-GenericReader<Eye.EyeLidConfiguration>.get_ReadAutoPack
	|-GenericReader<RigidbodyPrediction.MoveData>.get_ReadAutoPack
	|-GenericReader<RigidbodyPrediction.ReconcileData>.get_ReadAutoPack
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static void set_ReadAutoPack(Func<Reader, AutoPackType, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180EF60 Offset: 0x180D960 VA: 0x18180EF60
	|-GenericReader<ArraySegment<byte>>.set_ReadAutoPack
	|-GenericReader<bool>.set_ReadAutoPack
	|-GenericReader<byte>.set_ReadAutoPack
	|-GenericReader<ByteEnum>.set_ReadAutoPack
	|-GenericReader<char>.set_ReadAutoPack
	|-GenericReader<ClientConnectionChangeBroadcast>.set_ReadAutoPack
	|-GenericReader<ClientScenesLoadedBroadcast>.set_ReadAutoPack
	|-GenericReader<Color>.set_ReadAutoPack
	|-GenericReader<Color32>.set_ReadAutoPack
	|-GenericReader<ConnectedClientsBroadcast>.set_ReadAutoPack
	|-GenericReader<CoordinateProceduralTilePair>.set_ReadAutoPack
	|-GenericReader<DateTime>.set_ReadAutoPack
	|-GenericReader<Decimal>.set_ReadAutoPack
	|-GenericReader<double>.set_ReadAutoPack
	|-GenericReader<EmptyStartScenesBroadcast>.set_ReadAutoPack
	|-GenericReader<ExplosionData>.set_ReadAutoPack
	|-GenericReader<FullRank>.set_ReadAutoPack
	|-GenericReader<GameDateTime>.set_ReadAutoPack
	|-GenericReader<Guid>.set_ReadAutoPack
	|-GenericReader<HostPasswordBroadcast>.set_ReadAutoPack
	|-GenericReader<short>.set_ReadAutoPack
	|-GenericReader<int>.set_ReadAutoPack
	|-GenericReader<Int32Enum>.set_ReadAutoPack
	|-GenericReader<long>.set_ReadAutoPack
	|-GenericReader<LoadScenesBroadcast>.set_ReadAutoPack
	|-GenericReader<Matrix4x4>.set_ReadAutoPack
	|-GenericReader<object>.set_ReadAutoPack
	|-GenericReader<PasswordBroadcast>.set_ReadAutoPack
	|-GenericReader<Plane>.set_ReadAutoPack
	|-GenericReader<PreciseTick>.set_ReadAutoPack
	|-GenericReader<Quaternion>.set_ReadAutoPack
	|-GenericReader<Ray>.set_ReadAutoPack
	|-GenericReader<Ray2D>.set_ReadAutoPack
	|-GenericReader<Rect>.set_ReadAutoPack
	|-GenericReader<ResponseBroadcast>.set_ReadAutoPack
	|-GenericReader<Rigidbody2DState>.set_ReadAutoPack
	|-GenericReader<RigidbodyState>.set_ReadAutoPack
	|-GenericReader<sbyte>.set_ReadAutoPack
	|-GenericReader<float>.set_ReadAutoPack
	|-GenericReader<Structy>.set_ReadAutoPack
	|-GenericReader<ushort>.set_ReadAutoPack
	|-GenericReader<uint>.set_ReadAutoPack
	|-GenericReader<ulong>.set_ReadAutoPack
	|-GenericReader<UShort2>.set_ReadAutoPack
	|-GenericReader<UnloadScenesBroadcast>.set_ReadAutoPack
	|-GenericReader<Vector2>.set_ReadAutoPack
	|-GenericReader<Vector2Int>.set_ReadAutoPack
	|-GenericReader<Vector3>.set_ReadAutoPack
	|-GenericReader<Vector3Int>.set_ReadAutoPack
	|-GenericReader<Vector4>.set_ReadAutoPack
	|-GenericReader<__Il2CppFullySharedGenericType>.set_ReadAutoPack
	|-GenericReader<AvatarSettings.LayerSetting>.set_ReadAutoPack
	|-GenericReader<Eye.EyeLidConfiguration>.set_ReadAutoPack
	|-GenericReader<RigidbodyPrediction.MoveData>.set_ReadAutoPack
	|-GenericReader<RigidbodyPrediction.ReconcileData>.set_ReadAutoPack
	*/
}
