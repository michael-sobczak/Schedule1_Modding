public sealed class Func<T1, T2, TResult> : MulticastDelegate // TypeDefIndex: 3580
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1809280 Offset: 0x1807C80 VA: 0x181809280
	|-Func<Background, Background, bool>..ctor
	|
	|-RVA: 0x180AE40 Offset: 0x1809840 VA: 0x18180AE40
	|-Func<BackgroundPosition, BackgroundPosition, bool>..ctor
	|
	|-RVA: 0x180ABB0 Offset: 0x18095B0 VA: 0x18180ABB0
	|-Func<BackgroundRepeat, BackgroundRepeat, bool>..ctor
	|-Func<Length, Length, bool>..ctor
	|
	|-RVA: 0x1808F70 Offset: 0x1807970 VA: 0x181808F70
	|-Func<BackgroundSize, BackgroundSize, bool>..ctor
	|-Func<TransformOrigin, TransformOrigin, bool>..ctor
	|
	|-RVA: 0x1809330 Offset: 0x1807D30 VA: 0x181809330
	|-Func<bool, bool, bool>..ctor
	|
	|-RVA: 0x180A4E0 Offset: 0x1808EE0 VA: 0x18180A4E0
	|-Func<Color, Color, bool>..ctor
	|-Func<FontDefinition, FontDefinition, bool>..ctor
	|-Func<Scale, Scale, bool>..ctor
	|-Func<RigidbodyPrediction.MoveData, RigidbodyPrediction.MoveData, bool>..ctor
	|
	|-RVA: 0x180AEF0 Offset: 0x18098F0 VA: 0x18180AEF0
	|-Func<Color, object, Color>..ctor
	|
	|-RVA: 0x180A120 Offset: 0x1808B20 VA: 0x18180A120
	|-Func<InputEventPtr, object, bool>..ctor
	|
	|-RVA: 0x180A300 Offset: 0x1808D00 VA: 0x18180A300
	|-Func<int, int, bool>..ctor
	|
	|-RVA: 0x180B0D0 Offset: 0x1809AD0 VA: 0x18180B0D0
	|-Func<int, IntPtr, bool>..ctor
	|
	|-RVA: 0x180A640 Offset: 0x1809040 VA: 0x18180A640
	|-Func<int, object, object>..ctor
	|
	|-RVA: 0x1809D90 Offset: 0x1808790 VA: 0x181809D90
	|-Func<object, bool, bool>..ctor
	|
	|-RVA: 0x1809FF0 Offset: 0x18089F0 VA: 0x181809FF0
	|-Func<object, double, double>..ctor
	|-Func<object, float, float>..ctor
	|
	|-RVA: 0x1809B30 Offset: 0x1808530 VA: 0x181809B30
	|-Func<object, Hash128, Hash128>..ctor
	|
	|-RVA: 0x180B490 Offset: 0x1809E90 VA: 0x18180B490
	|-Func<object, InputEventPtr, bool>..ctor
	|
	|-RVA: 0x180B180 Offset: 0x1809B80 VA: 0x18180B180
	|-Func<object, InputEventPtr, float>..ctor
	|
	|-RVA: 0x1809020 Offset: 0x1807A20 VA: 0x181809020
	|-Func<object, int, int>..ctor
	|-Func<object, Int32Enum, int>..ctor
	|-Func<object, Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x180A820 Offset: 0x1809220 VA: 0x18180A820
	|-Func<object, int, object>..ctor
	|-Func<object, Int32Enum, object>..ctor
	|
	|-RVA: 0x1809820 Offset: 0x1808220 VA: 0x181809820
	|-Func<object, Int32Enum, ArraySegment<byte>>..ctor
	|-Func<object, Int32Enum, Color>..ctor
	|-Func<object, Int32Enum, Decimal>..ctor
	|-Func<object, Int32Enum, Guid>..ctor
	|-Func<object, Int32Enum, Plane>..ctor
	|-Func<object, Int32Enum, PreciseTick>..ctor
	|-Func<object, Int32Enum, Quaternion>..ctor
	|-Func<object, Int32Enum, Ray2D>..ctor
	|-Func<object, Int32Enum, Rect>..ctor
	|-Func<object, Int32Enum, Structy>..ctor
	|-Func<object, Int32Enum, Vector4>..ctor
	|-Func<object, Int32Enum, RigidbodyPrediction.MoveData>..ctor
	|
	|-RVA: 0x1809510 Offset: 0x1807F10 VA: 0x181809510
	|-Func<object, Int32Enum, bool>..ctor
	|-Func<object, Int32Enum, EmptyStartScenesBroadcast>..ctor
	|-Func<object, Int32Enum, ResponseBroadcast>..ctor
	|-Func<object, Int32Enum, sbyte>..ctor
	|
	|-RVA: 0x1809150 Offset: 0x1807B50 VA: 0x181809150
	|-Func<object, Int32Enum, byte>..ctor
	|-Func<object, Int32Enum, ByteEnum>..ctor
	|
	|-RVA: 0x180A3B0 Offset: 0x1808DB0 VA: 0x18180A3B0
	|-Func<object, Int32Enum, char>..ctor
	|-Func<object, Int32Enum, short>..ctor
	|-Func<object, Int32Enum, ushort>..ctor
	|
	|-RVA: 0x1809640 Offset: 0x1808040 VA: 0x181809640
	|-Func<object, Int32Enum, ClientConnectionChangeBroadcast>..ctor
	|-Func<object, Int32Enum, ClientScenesLoadedBroadcast>..ctor
	|-Func<object, Int32Enum, ConnectedClientsBroadcast>..ctor
	|-Func<object, Int32Enum, DateTime>..ctor
	|-Func<object, Int32Enum, FullRank>..ctor
	|-Func<object, Int32Enum, GameDateTime>..ctor
	|-Func<object, Int32Enum, HostPasswordBroadcast>..ctor
	|-Func<object, Int32Enum, long>..ctor
	|-Func<object, Int32Enum, LoadScenesBroadcast>..ctor
	|-Func<object, Int32Enum, PasswordBroadcast>..ctor
	|-Func<object, Int32Enum, ulong>..ctor
	|-Func<object, Int32Enum, UnloadScenesBroadcast>..ctor
	|-Func<object, Int32Enum, Vector2Int>..ctor
	|
	|-RVA: 0x18093E0 Offset: 0x1807DE0 VA: 0x1818093E0
	|-Func<object, Int32Enum, Color32>..ctor
	|-Func<object, Int32Enum, uint>..ctor
	|-Func<object, Int32Enum, UShort2>..ctor
	|-Func<object, uint, uint>..ctor
	|
	|-RVA: 0x1809EC0 Offset: 0x18088C0 VA: 0x181809EC0
	|-Func<object, Int32Enum, CoordinateProceduralTilePair>..ctor
	|-Func<object, Int32Enum, Ray>..ctor
	|-Func<object, Int32Enum, AvatarSettings.LayerSetting>..ctor
	|
	|-RVA: 0x1809C60 Offset: 0x1808660 VA: 0x181809C60
	|-Func<object, Int32Enum, double>..ctor
	|-Func<object, Int32Enum, float>..ctor
	|
	|-RVA: 0x180A1D0 Offset: 0x1808BD0 VA: 0x18180A1D0
	|-Func<object, Int32Enum, ExplosionData>..ctor
	|
	|-RVA: 0x180A950 Offset: 0x1809350 VA: 0x18180A950
	|-Func<object, Int32Enum, Matrix4x4>..ctor
	|
	|-RVA: 0x1809A00 Offset: 0x1808400 VA: 0x181809A00
	|-Func<object, Int32Enum, Rigidbody2DState>..ctor
	|
	|-RVA: 0x180AFA0 Offset: 0x18099A0 VA: 0x18180AFA0
	|-Func<object, Int32Enum, RigidbodyState>..ctor
	|
	|-RVA: 0x180A6F0 Offset: 0x18090F0 VA: 0x18180A6F0
	|-Func<object, Int32Enum, Vector2>..ctor
	|-Func<object, Int32Enum, Eye.EyeLidConfiguration>..ctor
	|
	|-RVA: 0x180B360 Offset: 0x1809D60 VA: 0x18180B360
	|-Func<object, Int32Enum, Vector3>..ctor
	|-Func<object, Int32Enum, Vector3Int>..ctor
	|
	|-RVA: 0x180AC60 Offset: 0x1809660 VA: 0x18180AC60
	|-Func<object, Int32Enum, RigidbodyPrediction.ReconcileData>..ctor
	|
	|-RVA: 0x105F670 Offset: 0x105E070 VA: 0x18105F670
	|-Func<object, long, long>..ctor
	|-Func<object, object, Nullable<int>>..ctor
	|-Func<object, object, object>..ctor
	|-Func<object, ulong, ulong>..ctor
	|
	|-RVA: 0x60BBE0 Offset: 0x60A5E0 VA: 0x18060BBE0
	|-Func<object, object, bool>..ctor
	|-Func<object, object, VoidTaskResult>..ctor
	|
	|-RVA: 0x14B5B60 Offset: 0x14B4560 VA: 0x1814B5B60
	|-Func<object, object, int>..ctor
	|
	|-RVA: 0x180AA80 Offset: 0x1809480 VA: 0x18180AA80
	|-Func<object, Vector2, Matrix4x4>..ctor
	|
	|-RVA: 0x180A590 Offset: 0x1808F90 VA: 0x18180A590
	|-Func<Rotate, Rotate, bool>..ctor
	|-Func<Translate, Translate, bool>..ctor
	|
	|-RVA: 0x180B2B0 Offset: 0x1809CB0 VA: 0x18180B2B0
	|-Func<float, float, bool>..ctor
	|
	|-RVA: 0x8D4E10 Offset: 0x8D3810 VA: 0x1808D4E10
	|-Func<float, float, float>..ctor
	|
	|-RVA: 0x1809770 Offset: 0x1808170 VA: 0x181809770
	|-Func<TextShadow, TextShadow, bool>..ctor
	|
	|-RVA: 0x180AD90 Offset: 0x1809790 VA: 0x18180AD90
	|-Func<Vector3, float, Vector3>..ctor
	|
	|-RVA: 0x1809950 Offset: 0x1808350 VA: 0x181809950
	|-Func<Vector3, Vector3, Vector3>..ctor
	|
	|-RVA: 0x14B0AF0 Offset: 0x14AF4F0 VA: 0x1814B0AF0
	|-Func<Vector4, Vector4, int>..ctor
	|-Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int>..ctor
	|
	|-RVA: 0x105F7A0 Offset: 0x105E1A0 VA: 0x18105F7A0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B08A0 Offset: 0x14AF2A0 VA: 0x1814B08A0
	|-Func<Background, Background, bool>.Invoke
	|
	|-RVA: 0x14B0850 Offset: 0x14AF250 VA: 0x1814B0850
	|-Func<BackgroundPosition, BackgroundPosition, bool>.Invoke
	|
	|-RVA: 0x5554B0 Offset: 0x553EB0 VA: 0x1805554B0
	|-Func<BackgroundRepeat, BackgroundRepeat, bool>.Invoke
	|-Func<bool, bool, bool>.Invoke
	|-Func<InputEventPtr, object, bool>.Invoke
	|-Func<int, int, bool>.Invoke
	|-Func<int, IntPtr, bool>.Invoke
	|-Func<int, object, object>.Invoke
	|-Func<Length, Length, bool>.Invoke
	|-Func<object, bool, bool>.Invoke
	|-Func<object, double, double>.Invoke
	|-Func<object, InputEventPtr, bool>.Invoke
	|-Func<object, InputEventPtr, float>.Invoke
	|-Func<object, int, int>.Invoke
	|-Func<object, int, object>.Invoke
	|-Func<object, Int32Enum, bool>.Invoke
	|-Func<object, Int32Enum, byte>.Invoke
	|-Func<object, Int32Enum, ByteEnum>.Invoke
	|-Func<object, Int32Enum, char>.Invoke
	|-Func<object, Int32Enum, ClientConnectionChangeBroadcast>.Invoke
	|-Func<object, Int32Enum, ClientScenesLoadedBroadcast>.Invoke
	|-Func<object, Int32Enum, Color32>.Invoke
	|-Func<object, Int32Enum, ConnectedClientsBroadcast>.Invoke
	|-Func<object, Int32Enum, DateTime>.Invoke
	|-Func<object, Int32Enum, double>.Invoke
	|-Func<object, Int32Enum, EmptyStartScenesBroadcast>.Invoke
	|-Func<object, Int32Enum, FullRank>.Invoke
	|-Func<object, Int32Enum, GameDateTime>.Invoke
	|-Func<object, Int32Enum, HostPasswordBroadcast>.Invoke
	|-Func<object, Int32Enum, short>.Invoke
	|-Func<object, Int32Enum, int>.Invoke
	|-Func<object, Int32Enum, Int32Enum>.Invoke
	|-Func<object, Int32Enum, long>.Invoke
	|-Func<object, Int32Enum, LoadScenesBroadcast>.Invoke
	|-Func<object, Int32Enum, object>.Invoke
	|-Func<object, Int32Enum, PasswordBroadcast>.Invoke
	|-Func<object, Int32Enum, ResponseBroadcast>.Invoke
	|-Func<object, Int32Enum, sbyte>.Invoke
	|-Func<object, Int32Enum, float>.Invoke
	|-Func<object, Int32Enum, ushort>.Invoke
	|-Func<object, Int32Enum, uint>.Invoke
	|-Func<object, Int32Enum, ulong>.Invoke
	|-Func<object, Int32Enum, UShort2>.Invoke
	|-Func<object, Int32Enum, UnloadScenesBroadcast>.Invoke
	|-Func<object, Int32Enum, Vector2>.Invoke
	|-Func<object, Int32Enum, Vector2Int>.Invoke
	|-Func<object, Int32Enum, Eye.EyeLidConfiguration>.Invoke
	|-Func<object, long, long>.Invoke
	|-Func<object, object, Nullable<int>>.Invoke
	|-Func<object, object, bool>.Invoke
	|-Func<object, object, int>.Invoke
	|-Func<object, object, object>.Invoke
	|-Func<object, object, VoidTaskResult>.Invoke
	|-Func<object, float, float>.Invoke
	|-Func<object, uint, uint>.Invoke
	|-Func<object, ulong, ulong>.Invoke
	|-Func<float, float, bool>.Invoke
	|-Func<float, float, float>.Invoke
	|
	|-RVA: 0x14B4900 Offset: 0x14B3300 VA: 0x1814B4900
	|-Func<BackgroundSize, BackgroundSize, bool>.Invoke
	|-Func<TransformOrigin, TransformOrigin, bool>.Invoke
	|
	|-RVA: 0x11DD0F0 Offset: 0x11DBAF0 VA: 0x1811DD0F0
	|-Func<Color, Color, bool>.Invoke
	|-Func<FontDefinition, FontDefinition, bool>.Invoke
	|-Func<Scale, Scale, bool>.Invoke
	|-Func<Vector4, Vector4, int>.Invoke
	|-Func<LightCookieManager.LightCookieMapping, LightCookieManager.LightCookieMapping, int>.Invoke
	|-Func<RigidbodyPrediction.MoveData, RigidbodyPrediction.MoveData, bool>.Invoke
	|
	|-RVA: 0x1808D90 Offset: 0x1807790 VA: 0x181808D90
	|-Func<Color, object, Color>.Invoke
	|
	|-RVA: 0x1808F30 Offset: 0x1807930 VA: 0x181808F30
	|-Func<object, Hash128, Hash128>.Invoke
	|
	|-RVA: 0x1808CB0 Offset: 0x18076B0 VA: 0x181808CB0
	|-Func<object, Int32Enum, ArraySegment<byte>>.Invoke
	|-Func<object, Int32Enum, Color>.Invoke
	|-Func<object, Int32Enum, Decimal>.Invoke
	|-Func<object, Int32Enum, Guid>.Invoke
	|-Func<object, Int32Enum, Plane>.Invoke
	|-Func<object, Int32Enum, PreciseTick>.Invoke
	|-Func<object, Int32Enum, Quaternion>.Invoke
	|-Func<object, Int32Enum, Ray2D>.Invoke
	|-Func<object, Int32Enum, Rect>.Invoke
	|-Func<object, Int32Enum, Structy>.Invoke
	|-Func<object, Int32Enum, Vector4>.Invoke
	|-Func<object, Int32Enum, RigidbodyPrediction.MoveData>.Invoke
	|
	|-RVA: 0x1808C70 Offset: 0x1807670 VA: 0x181808C70
	|-Func<object, Int32Enum, CoordinateProceduralTilePair>.Invoke
	|-Func<object, Int32Enum, Ray>.Invoke
	|-Func<object, Int32Enum, AvatarSettings.LayerSetting>.Invoke
	|
	|-RVA: 0x1808E80 Offset: 0x1807880 VA: 0x181808E80
	|-Func<object, Int32Enum, ExplosionData>.Invoke
	|
	|-RVA: 0x1808D40 Offset: 0x1807740 VA: 0x181808D40
	|-Func<object, Int32Enum, Matrix4x4>.Invoke
	|-Func<object, Vector2, Matrix4x4>.Invoke
	|
	|-RVA: 0x1808CF0 Offset: 0x18076F0 VA: 0x181808CF0
	|-Func<object, Int32Enum, Rigidbody2DState>.Invoke
	|
	|-RVA: 0x1808C10 Offset: 0x1807610 VA: 0x181808C10
	|-Func<object, Int32Enum, RigidbodyState>.Invoke
	|
	|-RVA: 0x1808BD0 Offset: 0x18075D0 VA: 0x181808BD0
	|-Func<object, Int32Enum, Vector3>.Invoke
	|-Func<object, Int32Enum, Vector3Int>.Invoke
	|
	|-RVA: 0x1808E30 Offset: 0x1807830 VA: 0x181808E30
	|-Func<object, Int32Enum, RigidbodyPrediction.ReconcileData>.Invoke
	|
	|-RVA: 0x14B08F0 Offset: 0x14AF2F0 VA: 0x1814B08F0
	|-Func<Rotate, Rotate, bool>.Invoke
	|-Func<Translate, Translate, bool>.Invoke
	|
	|-RVA: 0x14B48A0 Offset: 0x14B32A0 VA: 0x1814B48A0
	|-Func<TextShadow, TextShadow, bool>.Invoke
	|
	|-RVA: 0x1808DD0 Offset: 0x18077D0 VA: 0x181808DD0
	|-Func<Vector3, float, Vector3>.Invoke
	|
	|-RVA: 0x1808EC0 Offset: 0x18078C0 VA: 0x181808EC0
	|-Func<Vector3, Vector3, Vector3>.Invoke
	|
	|-RVA: 0x566F40 Offset: 0x565940 VA: 0x180566F40
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}
