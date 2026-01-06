public struct KeyValuePair<TKey, TValue> // TypeDefIndex: 4984
{
	// Fields
	private readonly TKey key; // 0x0
	private readonly TValue value; // 0x0

	// Properties
	public TKey Key { get; }
	public TValue Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CC380 Offset: 0x18CAD80 VA: 0x1818CC380
	|-KeyValuePair<KeyValuePair<object, object>, object>..ctor
	|-KeyValuePair<StructMultiKey<object, object>, object>..ctor
	|-KeyValuePair<ValueTuple<object, int>, object>..ctor
	|-KeyValuePair<ValueTuple<object, object>, object>..ctor
	|-KeyValuePair<InternedString, object>..ctor
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x18CCB60 Offset: 0x18CB560 VA: 0x1818CCB60
	|-KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x18CC590 Offset: 0x18CAF90 VA: 0x1818CC590
	|-KeyValuePair<Bounds, object>..ctor
	|
	|-RVA: 0x18CC750 Offset: 0x18CB150 VA: 0x1818CC750
	|-KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x10F0D60 Offset: 0x10EF760 VA: 0x1810F0D60
	|-KeyValuePair<CSteamID, int>..ctor
	|-KeyValuePair<Int2, int>..ctor
	|
	|-RVA: 0x1330BA0 Offset: 0x132F5A0 VA: 0x181330BA0
	|-KeyValuePair<FullRank, object>..ctor
	|-KeyValuePair<Int2, object>..ctor
	|-KeyValuePair<long, object>..ctor
	|-KeyValuePair<IntPtr, object>..ctor
	|-KeyValuePair<TerrainTileCoord, object>..ctor
	|-KeyValuePair<ulong, object>..ctor
	|-KeyValuePair<Vector2Int, object>..ctor
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>..ctor
	|
	|-RVA: 0x18CC900 Offset: 0x18CB300 VA: 0x1818CC900
	|-KeyValuePair<Guid, object>..ctor
	|-KeyValuePair<Hash128, object>..ctor
	|-KeyValuePair<Rect, object>..ctor
	|
	|-RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	|-KeyValuePair<HSteamNetConnection, int>..ctor
	|-KeyValuePair<int, HSteamNetConnection>..ctor
	|-KeyValuePair<int, int>..ctor
	|-KeyValuePair<int, Int32Enum>..ctor
	|-KeyValuePair<int, uint>..ctor
	|-KeyValuePair<Int32Enum, int>..ctor
	|-KeyValuePair<Int32Enum, Int32Enum>..ctor
	|-KeyValuePair<uint, int>..ctor
	|
	|-RVA: 0x18CC9C0 Offset: 0x18CB3C0 VA: 0x1818CC9C0
	|-KeyValuePair<Hash128, int>..ctor
	|
	|-RVA: 0x18CC8E0 Offset: 0x18CB2E0 VA: 0x1818CC8E0
	|-KeyValuePair<Int3, int>..ctor
	|
	|-RVA: 0x1330BC0 Offset: 0x132F5C0 VA: 0x181330BC0
	|-KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-KeyValuePair<int, CSteamID>..ctor
	|-KeyValuePair<int, Vector2>..ctor
	|-KeyValuePair<int, Vector2Int>..ctor
	|-KeyValuePair<int, Multipass.TransportIdData>..ctor
	|-KeyValuePair<int, NetworkAnimator.SmoothedFloat>..ctor
	|-KeyValuePair<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x18CCC80 Offset: 0x18CB680 VA: 0x1818CCC80
	|-KeyValuePair<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x18CC530 Offset: 0x18CAF30 VA: 0x1818CC530
	|-KeyValuePair<int, ValueTuple<object, int>>..ctor
	|-KeyValuePair<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x18CC600 Offset: 0x18CB000 VA: 0x1818CC600
	|-KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>..ctor
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>..ctor
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>..ctor
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x1330B60 Offset: 0x132F560 VA: 0x181330B60
	|-KeyValuePair<int, bool>..ctor
	|-KeyValuePair<int, ByteEnum>..ctor
	|-KeyValuePair<Int32Enum, bool>..ctor
	|
	|-RVA: 0x18CC940 Offset: 0x18CB340 VA: 0x1818CC940
	|-KeyValuePair<int, short>..ctor
	|
	|-RVA: 0x18CC5E0 Offset: 0x18CAFE0 VA: 0x1818CC5E0
	|-KeyValuePair<int, Int3>..ctor
	|-KeyValuePair<int, Vector3>..ctor
	|
	|-RVA: 0x1330B50 Offset: 0x132F550 VA: 0x181330B50
	|-KeyValuePair<int, long>..ctor
	|-KeyValuePair<int, ulong>..ctor
	|
	|-RVA: 0xD59F60 Offset: 0xD58960 VA: 0x180D59F60
	|-KeyValuePair<int, object>..ctor
	|-KeyValuePair<Int32Enum, object>..ctor
	|-KeyValuePair<PropertyName, object>..ctor
	|-KeyValuePair<Scene, object>..ctor
	|-KeyValuePair<uint, object>..ctor
	|
	|-RVA: 0x18CC830 Offset: 0x18CB230 VA: 0x1818CC830
	|-KeyValuePair<int, RenderInstancedDataLayout>..ctor
	|-KeyValuePair<int, Vector4>..ctor
	|
	|-RVA: 0x18CCAF0 Offset: 0x18CB4F0 VA: 0x1818CCAF0
	|-KeyValuePair<int, float>..ctor
	|
	|-RVA: 0x18CC3C0 Offset: 0x18CADC0 VA: 0x1818CC3C0
	|-KeyValuePair<int, TreeItem>..ctor
	|
	|-RVA: 0x18CC690 Offset: 0x18CB090 VA: 0x1818CC690
	|-KeyValuePair<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x18CC6F0 Offset: 0x18CB0F0 VA: 0x1818CC6F0
	|-KeyValuePair<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x18CC840 Offset: 0x18CB240 VA: 0x1818CC840
	|-KeyValuePair<int, TMP_ResourceManager.FontAssetRef>..ctor
	|-KeyValuePair<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x18CCAA0 Offset: 0x18CB4A0 VA: 0x1818CCAA0
	|-KeyValuePair<long, ComputedStyle>..ctor
	|
	|-RVA: 0x18CC4C0 Offset: 0x18CAEC0 VA: 0x1818CC4C0
	|-KeyValuePair<InternedString, InternedString>..ctor
	|-KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x18CC920 Offset: 0x18CB320 VA: 0x1818CC920
	|-KeyValuePair<NativeAddr, object>..ctor
	|
	|-RVA: 0x18CC790 Offset: 0x18CB190 VA: 0x1818CC790
	|-KeyValuePair<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x18CC550 Offset: 0x18CAF50 VA: 0x1818CC550
	|-KeyValuePair<object, ValueTuple<Vector3, Quaternion>>..ctor
	|-KeyValuePair<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x1330BD0 Offset: 0x132F5D0 VA: 0x181330BD0
	|-KeyValuePair<object, bool>..ctor
	|
	|-RVA: 0x18CC410 Offset: 0x18CAE10 VA: 0x1818CC410
	|-KeyValuePair<object, Bounds>..ctor
	|
	|-RVA: 0xCF07F0 Offset: 0xCEF1F0 VA: 0x180CF07F0
	|-KeyValuePair<object, char>..ctor
	|
	|-RVA: 0x18CC450 Offset: 0x18CAE50 VA: 0x1818CC450
	|-KeyValuePair<object, Color>..ctor
	|-KeyValuePair<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x18CC5B0 Offset: 0x18CAFB0 VA: 0x1818CC5B0
	|-KeyValuePair<object, Color>..ctor
	|-KeyValuePair<object, Playable>..ctor
	|-KeyValuePair<object, Rect>..ctor
	|
	|-RVA: 0x18CC800 Offset: 0x18CB200 VA: 0x1818CC800
	|-KeyValuePair<object, Color32>..ctor
	|-KeyValuePair<object, TextureId>..ctor
	|
	|-RVA: 0x18CCB30 Offset: 0x18CB530 VA: 0x1818CCB30
	|-KeyValuePair<object, double>..ctor
	|
	|-RVA: 0xD900B0 Offset: 0xD8EAB0 VA: 0x180D900B0
	|-KeyValuePair<object, int>..ctor
	|-KeyValuePair<object, Int32Enum>..ctor
	|
	|-RVA: 0x18CC490 Offset: 0x18CAE90 VA: 0x1818CC490
	|-KeyValuePair<object, long>..ctor
	|
	|-RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	|-KeyValuePair<object, object>..ctor
	|
	|-RVA: 0x18CC6B0 Offset: 0x18CB0B0 VA: 0x1818CC6B0
	|-KeyValuePair<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x18CCBC0 Offset: 0x18CB5C0 VA: 0x1818CCBC0
	|-KeyValuePair<object, RaycastHit>..ctor
	|
	|-RVA: 0x1330C10 Offset: 0x132F610 VA: 0x181330C10
	|-KeyValuePair<object, ResourceLocator>..ctor
	|-KeyValuePair<object, StylePropertyValue>..ctor
	|-KeyValuePair<object, XPathNodeRef>..ctor
	|
	|-RVA: 0xC23450 Offset: 0xC21E50 VA: 0x180C23450
	|-KeyValuePair<object, float>..ctor
	|
	|-RVA: 0x18CC500 Offset: 0x18CAF00 VA: 0x1818CC500
	|-KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|-KeyValuePair<object, ObjectPool.DelayedStoreData>..ctor
	|-KeyValuePair<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x18CC9D0 Offset: 0x18CB3D0 VA: 0x1818CC9D0
	|-KeyValuePair<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x18CCC10 Offset: 0x18CB610 VA: 0x1818CCC10
	|-KeyValuePair<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x18CC620 Offset: 0x18CB020 VA: 0x1818CC620
	|-KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x18CC950 Offset: 0x18CB350 VA: 0x1818CC950
	|-KeyValuePair<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x18CC3E0 Offset: 0x18CADE0 VA: 0x1818CC3E0
	|-KeyValuePair<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x18CC8B0 Offset: 0x18CB2B0 VA: 0x1818CC8B0
	|-KeyValuePair<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x18CC980 Offset: 0x18CB380 VA: 0x1818CC980
	|-KeyValuePair<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x18CCCA0 Offset: 0x18CB6A0 VA: 0x1818CCCA0
	|-KeyValuePair<ushort, object>..ctor
	|
	|-RVA: 0x18CCC70 Offset: 0x18CB670 VA: 0x1818CCC70
	|-KeyValuePair<ushort, RpcLink>..ctor
	|
	|-RVA: 0x691550 Offset: 0x68FF50 VA: 0x180691550
	|-KeyValuePair<ushort, ushort>..ctor
	|
	|-RVA: 0x18CC7D0 Offset: 0x18CB1D0 VA: 0x1818CC7D0
	|-KeyValuePair<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x18CCB00 Offset: 0x18CB500 VA: 0x1818CCB00
	|-KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	|-KeyValuePair<Vector3, Vector3>..ctor
	|
	|-RVA: 0x18CCA80 Offset: 0x18CB480 VA: 0x1818CCA80
	|-KeyValuePair<Vector3Int, object>..ctor
	|
	|-RVA: 0x10EFFD0 Offset: 0x10EE9D0 VA: 0x1810EFFD0
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x18CC860 Offset: 0x18CB260 VA: 0x1818CC860
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x18CC660 Offset: 0x18CB060 VA: 0x1818CC660
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	|-KeyValuePair<KeyValuePair<object, object>, object>.get_Key
	|-KeyValuePair<StructMultiKey<object, object>, object>.get_Key
	|-KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>.get_Key
	|-KeyValuePair<ValueTuple<object, int>, object>.get_Key
	|-KeyValuePair<ValueTuple<object, object>, object>.get_Key
	|-KeyValuePair<Guid, object>.get_Key
	|-KeyValuePair<Hash128, int>.get_Key
	|-KeyValuePair<Hash128, object>.get_Key
	|-KeyValuePair<InternedString, InternedString>.get_Key
	|-KeyValuePair<InternedString, object>.get_Key
	|-KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Key
	|-KeyValuePair<Rect, object>.get_Key
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Key
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Key
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Key
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Key
	|
	|-RVA: 0x1122D20 Offset: 0x1121720 VA: 0x181122D20
	|-KeyValuePair<Bounds, object>.get_Key
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.get_Key
	|
	|-RVA: 0x18CCCC0 Offset: 0x18CB6C0 VA: 0x1818CCCC0
	|-KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>.get_Key
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-KeyValuePair<CSteamID, int>.get_Key
	|-KeyValuePair<FullRank, object>.get_Key
	|-KeyValuePair<Int2, int>.get_Key
	|-KeyValuePair<Int2, object>.get_Key
	|-KeyValuePair<long, ComputedStyle>.get_Key
	|-KeyValuePair<long, object>.get_Key
	|-KeyValuePair<IntPtr, object>.get_Key
	|-KeyValuePair<object, KeyValuePair<Int32Enum, object>>.get_Key
	|-KeyValuePair<object, ValueTuple<Vector3, Quaternion>>.get_Key
	|-KeyValuePair<object, bool>.get_Key
	|-KeyValuePair<object, Bounds>.get_Key
	|-KeyValuePair<object, char>.get_Key
	|-KeyValuePair<object, Color>.get_Key
	|-KeyValuePair<object, Color>.get_Key
	|-KeyValuePair<object, Color32>.get_Key
	|-KeyValuePair<object, double>.get_Key
	|-KeyValuePair<object, int>.get_Key
	|-KeyValuePair<object, Int32Enum>.get_Key
	|-KeyValuePair<object, long>.get_Key
	|-KeyValuePair<object, object>.get_Key
	|-KeyValuePair<object, Playable>.get_Key
	|-KeyValuePair<object, ProbeVolumeBakingProcessSettings>.get_Key
	|-KeyValuePair<object, RaycastHit>.get_Key
	|-KeyValuePair<object, Rect>.get_Key
	|-KeyValuePair<object, ResourceLocator>.get_Key
	|-KeyValuePair<object, float>.get_Key
	|-KeyValuePair<object, StylePropertyValue>.get_Key
	|-KeyValuePair<object, TextureId>.get_Key
	|-KeyValuePair<object, XPathNodeRef>.get_Key
	|-KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Key
	|-KeyValuePair<object, InputControlLayout.ControlItem>.get_Key
	|-KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>.get_Key
	|-KeyValuePair<object, JsonParser.JsonValue>.get_Key
	|-KeyValuePair<object, LiquidVolume.MeshCache>.get_Key
	|-KeyValuePair<object, ObjectPool.DelayedStoreData>.get_Key
	|-KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>.get_Key
	|-KeyValuePair<object, SVGDocument.ClipData>.get_Key
	|-KeyValuePair<object, SVGDocument.MaskData>.get_Key
	|-KeyValuePair<object, SVGDocument.NodeGlobalSceneState>.get_Key
	|-KeyValuePair<object, SVGDocument.PatternData>.get_Key
	|-KeyValuePair<object, SVGDocument.ViewBoxInfo>.get_Key
	|-KeyValuePair<object, StyleComplexSelector.PseudoStateData>.get_Key
	|-KeyValuePair<TerrainTileCoord, object>.get_Key
	|-KeyValuePair<ulong, object>.get_Key
	|-KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Key
	|-KeyValuePair<Vector2Int, object>.get_Key
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.get_Key
	|
	|-RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	|-KeyValuePair<HSteamNetConnection, int>.get_Key
	|-KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Key
	|-KeyValuePair<int, TreeViewItemData<object>>.get_Key
	|-KeyValuePair<int, ValueTuple<object, int>>.get_Key
	|-KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>.get_Key
	|-KeyValuePair<int, bool>.get_Key
	|-KeyValuePair<int, ByteEnum>.get_Key
	|-KeyValuePair<int, CSteamID>.get_Key
	|-KeyValuePair<int, HSteamNetConnection>.get_Key
	|-KeyValuePair<int, short>.get_Key
	|-KeyValuePair<int, Int3>.get_Key
	|-KeyValuePair<int, int>.get_Key
	|-KeyValuePair<int, Int32Enum>.get_Key
	|-KeyValuePair<int, long>.get_Key
	|-KeyValuePair<int, object>.get_Key
	|-KeyValuePair<int, RenderInstancedDataLayout>.get_Key
	|-KeyValuePair<int, float>.get_Key
	|-KeyValuePair<int, TreeItem>.get_Key
	|-KeyValuePair<int, uint>.get_Key
	|-KeyValuePair<int, ulong>.get_Key
	|-KeyValuePair<int, Vector2>.get_Key
	|-KeyValuePair<int, Vector2Int>.get_Key
	|-KeyValuePair<int, Vector3>.get_Key
	|-KeyValuePair<int, Vector4>.get_Key
	|-KeyValuePair<int, Multipass.TransportIdData>.get_Key
	|-KeyValuePair<int, NetworkAnimator.SmoothedFloat>.get_Key
	|-KeyValuePair<int, NetworkAnimator.StateChange>.get_Key
	|-KeyValuePair<int, ReflectionProbeManager.CachedProbe>.get_Key
	|-KeyValuePair<int, TMP_ResourceManager.FontAssetRef>.get_Key
	|-KeyValuePair<int, TextResourceManager.FontAssetRef>.get_Key
	|-KeyValuePair<Int32Enum, bool>.get_Key
	|-KeyValuePair<Int32Enum, int>.get_Key
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Key
	|-KeyValuePair<Int32Enum, object>.get_Key
	|-KeyValuePair<PropertyName, object>.get_Key
	|-KeyValuePair<Scene, object>.get_Key
	|-KeyValuePair<uint, GlyphPairAdjustmentRecord>.get_Key
	|-KeyValuePair<uint, int>.get_Key
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.get_Key
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.get_Key
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.get_Key
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.get_Key
	|-KeyValuePair<uint, object>.get_Key
	|-KeyValuePair<uint, RpcLinkType>.get_Key
	|-KeyValuePair<uint, NetworkBehaviour.BufferedRpc>.get_Key
	|
	|-RVA: 0x5762D0 Offset: 0x574CD0 VA: 0x1805762D0
	|-KeyValuePair<Int3, int>.get_Key
	|-KeyValuePair<Vector3, Vector3>.get_Key
	|-KeyValuePair<Vector3Int, object>.get_Key
	|
	|-RVA: 0x18CCCF0 Offset: 0x18CB6F0 VA: 0x1818CCCF0
	|-KeyValuePair<NativeAddr, object>.get_Key
	|
	|-RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	|-KeyValuePair<ushort, object>.get_Key
	|-KeyValuePair<ushort, RpcLink>.get_Key
	|-KeyValuePair<ushort, ushort>.get_Key
	|
	|-RVA: 0x18CCD10 Offset: 0x18CB710 VA: 0x1818CCD10
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-KeyValuePair<KeyValuePair<object, object>, object>.get_Value
	|-KeyValuePair<StructMultiKey<object, object>, object>.get_Value
	|-KeyValuePair<ValueTuple<object, int>, object>.get_Value
	|-KeyValuePair<ValueTuple<object, object>, object>.get_Value
	|-KeyValuePair<Guid, object>.get_Value
	|-KeyValuePair<Hash128, object>.get_Value
	|-KeyValuePair<InternedString, object>.get_Value
	|-KeyValuePair<Rect, object>.get_Value
	|-KeyValuePair<Vector3Int, object>.get_Value
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Value
	|
	|-RVA: 0x166C230 Offset: 0x166AC30 VA: 0x18166C230
	|-KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>.get_Value
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-KeyValuePair<Bounds, object>.get_Value
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.get_Value
	|
	|-RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	|-KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>.get_Value
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-KeyValuePair<CSteamID, int>.get_Value
	|-KeyValuePair<Int2, int>.get_Value
	|-KeyValuePair<object, Color32>.get_Value
	|-KeyValuePair<object, int>.get_Value
	|-KeyValuePair<object, Int32Enum>.get_Value
	|-KeyValuePair<object, TextureId>.get_Value
	|
	|-RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	|-KeyValuePair<FullRank, object>.get_Value
	|-KeyValuePair<Int2, object>.get_Value
	|-KeyValuePair<int, long>.get_Value
	|-KeyValuePair<int, object>.get_Value
	|-KeyValuePair<int, ulong>.get_Value
	|-KeyValuePair<Int32Enum, object>.get_Value
	|-KeyValuePair<long, object>.get_Value
	|-KeyValuePair<IntPtr, object>.get_Value
	|-KeyValuePair<object, long>.get_Value
	|-KeyValuePair<object, object>.get_Value
	|-KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Value
	|-KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>.get_Value
	|-KeyValuePair<object, ObjectPool.DelayedStoreData>.get_Value
	|-KeyValuePair<object, StyleComplexSelector.PseudoStateData>.get_Value
	|-KeyValuePair<PropertyName, object>.get_Value
	|-KeyValuePair<Scene, object>.get_Value
	|-KeyValuePair<TerrainTileCoord, object>.get_Value
	|-KeyValuePair<ushort, object>.get_Value
	|-KeyValuePair<uint, object>.get_Value
	|-KeyValuePair<ulong, object>.get_Value
	|-KeyValuePair<Vector2Int, object>.get_Value
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.get_Value
	|
	|-RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	|-KeyValuePair<HSteamNetConnection, int>.get_Value
	|-KeyValuePair<int, HSteamNetConnection>.get_Value
	|-KeyValuePair<int, int>.get_Value
	|-KeyValuePair<int, Int32Enum>.get_Value
	|-KeyValuePair<int, uint>.get_Value
	|-KeyValuePair<Int32Enum, int>.get_Value
	|-KeyValuePair<Int32Enum, Int32Enum>.get_Value
	|-KeyValuePair<uint, int>.get_Value
	|
	|-RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	|-KeyValuePair<Hash128, int>.get_Value
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Value
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Value
	|
	|-RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	|-KeyValuePair<Int3, int>.get_Value
	|
	|-RVA: 0x109F800 Offset: 0x109E200 VA: 0x18109F800
	|-KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Value
	|-KeyValuePair<int, CSteamID>.get_Value
	|-KeyValuePair<int, Vector2Int>.get_Value
	|-KeyValuePair<int, Multipass.TransportIdData>.get_Value
	|-KeyValuePair<uint, RpcLinkType>.get_Value
	|
	|-RVA: 0x109F5E0 Offset: 0x109DFE0 VA: 0x18109F5E0
	|-KeyValuePair<int, TreeViewItemData<object>>.get_Value
	|-KeyValuePair<object, Bounds>.get_Value
	|-KeyValuePair<object, Color>.get_Value
	|-KeyValuePair<object, LiquidVolume.MeshCache>.get_Value
	|-KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>.get_Value
	|
	|-RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	|-KeyValuePair<int, ValueTuple<object, int>>.get_Value
	|-KeyValuePair<int, TreeItem>.get_Value
	|-KeyValuePair<object, KeyValuePair<Int32Enum, object>>.get_Value
	|-KeyValuePair<object, Color>.get_Value
	|-KeyValuePair<object, Playable>.get_Value
	|-KeyValuePair<object, Rect>.get_Value
	|-KeyValuePair<object, ResourceLocator>.get_Value
	|-KeyValuePair<object, StylePropertyValue>.get_Value
	|-KeyValuePair<object, XPathNodeRef>.get_Value
	|-KeyValuePair<uint, NetworkBehaviour.BufferedRpc>.get_Value
	|
	|-RVA: 0x109F9C0 Offset: 0x109E3C0 VA: 0x18109F9C0
	|-KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>.get_Value
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.get_Value
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.get_Value
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.get_Value
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.get_Value
	|
	|-RVA: 0x4C2CD0 Offset: 0x4C16D0 VA: 0x1804C2CD0
	|-KeyValuePair<int, bool>.get_Value
	|-KeyValuePair<int, ByteEnum>.get_Value
	|-KeyValuePair<Int32Enum, bool>.get_Value
	|
	|-RVA: 0x18CCEC0 Offset: 0x18CB8C0 VA: 0x1818CCEC0
	|-KeyValuePair<int, short>.get_Value
	|
	|-RVA: 0x4FB270 Offset: 0x4F9C70 VA: 0x1804FB270
	|-KeyValuePair<int, Int3>.get_Value
	|-KeyValuePair<int, Vector3>.get_Value
	|
	|-RVA: 0x109F680 Offset: 0x109E080 VA: 0x18109F680
	|-KeyValuePair<int, RenderInstancedDataLayout>.get_Value
	|-KeyValuePair<int, Vector4>.get_Value
	|-KeyValuePair<ushort, RpcLink>.get_Value
	|
	|-RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	|-KeyValuePair<int, float>.get_Value
	|
	|-RVA: 0x7BCB70 Offset: 0x7BB570 VA: 0x1807BCB70
	|-KeyValuePair<int, Vector2>.get_Value
	|-KeyValuePair<int, NetworkAnimator.SmoothedFloat>.get_Value
	|
	|-RVA: 0x18CCF20 Offset: 0x18CB920 VA: 0x1818CCF20
	|-KeyValuePair<int, NetworkAnimator.StateChange>.get_Value
	|
	|-RVA: 0x109FB00 Offset: 0x109E500 VA: 0x18109FB00
	|-KeyValuePair<int, ReflectionProbeManager.CachedProbe>.get_Value
	|
	|-RVA: 0x18CCE20 Offset: 0x18CB820 VA: 0x1818CCE20
	|-KeyValuePair<int, TMP_ResourceManager.FontAssetRef>.get_Value
	|-KeyValuePair<int, TextResourceManager.FontAssetRef>.get_Value
	|-KeyValuePair<object, SVGDocument.ViewBoxInfo>.get_Value
	|
	|-RVA: 0x109F7B0 Offset: 0x109E1B0 VA: 0x18109F7B0
	|-KeyValuePair<long, ComputedStyle>.get_Value
	|
	|-RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	|-KeyValuePair<InternedString, InternedString>.get_Value
	|-KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Value
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.get_Value
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-KeyValuePair<NativeAddr, object>.get_Value
	|
	|-RVA: 0x18CCDE0 Offset: 0x18CB7E0 VA: 0x1818CCDE0
	|-KeyValuePair<object, ValueTuple<Vector3, Quaternion>>.get_Value
	|-KeyValuePair<object, SVGDocument.PatternData>.get_Value
	|
	|-RVA: 0x48A510 Offset: 0x488F10 VA: 0x18048A510
	|-KeyValuePair<object, bool>.get_Value
	|-KeyValuePair<object, SVGDocument.ClipData>.get_Value
	|
	|-RVA: 0x4C54D0 Offset: 0x4C3ED0 VA: 0x1804C54D0
	|-KeyValuePair<object, char>.get_Value
	|-KeyValuePair<object, SVGDocument.MaskData>.get_Value
	|
	|-RVA: 0x109F850 Offset: 0x109E250 VA: 0x18109F850
	|-KeyValuePair<object, double>.get_Value
	|
	|-RVA: 0x18CCED0 Offset: 0x18CB8D0 VA: 0x1818CCED0
	|-KeyValuePair<object, ProbeVolumeBakingProcessSettings>.get_Value
	|
	|-RVA: 0x18CCE90 Offset: 0x18CB890 VA: 0x1818CCE90
	|-KeyValuePair<object, RaycastHit>.get_Value
	|
	|-RVA: 0x4747A0 Offset: 0x4731A0 VA: 0x1804747A0
	|-KeyValuePair<object, float>.get_Value
	|
	|-RVA: 0x109FDF0 Offset: 0x109E7F0 VA: 0x18109FDF0
	|-KeyValuePair<object, InputControlLayout.ControlItem>.get_Value
	|
	|-RVA: 0x18CCEF0 Offset: 0x18CB8F0 VA: 0x1818CCEF0
	|-KeyValuePair<object, JsonParser.JsonValue>.get_Value
	|
	|-RVA: 0x18CCE00 Offset: 0x18CB800 VA: 0x1818CCE00
	|-KeyValuePair<object, SVGDocument.NodeGlobalSceneState>.get_Value
	|
	|-RVA: 0xCBDFC0 Offset: 0xCBC9C0 VA: 0x180CBDFC0
	|-KeyValuePair<ushort, ushort>.get_Value
	|
	|-RVA: 0x18CCE60 Offset: 0x18CB860 VA: 0x1818CCE60
	|-KeyValuePair<uint, GlyphPairAdjustmentRecord>.get_Value
	|
	|-RVA: 0x109FEB0 Offset: 0x109E8B0 VA: 0x18109FEB0
	|-KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Value
	|
	|-RVA: 0x18CCE40 Offset: 0x18CB840 VA: 0x1818CCE40
	|-KeyValuePair<Vector3, Vector3>.get_Value
	|
	|-RVA: 0x18CCF40 Offset: 0x18CB940 VA: 0x1818CCF40
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CAA90 Offset: 0x18C9490 VA: 0x1818CAA90
	|-KeyValuePair<KeyValuePair<object, object>, object>.ToString
	|-KeyValuePair<StructMultiKey<object, object>, object>.ToString
	|-KeyValuePair<ValueTuple<object, int>, object>.ToString
	|-KeyValuePair<ValueTuple<object, object>, object>.ToString
	|-KeyValuePair<Guid, object>.ToString
	|-KeyValuePair<Hash128, object>.ToString
	|-KeyValuePair<InternedString, object>.ToString
	|-KeyValuePair<Rect, object>.ToString
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>.ToString
	|
	|-RVA: 0x18CB8F0 Offset: 0x18CA2F0 VA: 0x1818CB8F0
	|-KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>.ToString
	|
	|-RVA: 0x18CC050 Offset: 0x18CAA50 VA: 0x1818CC050
	|-KeyValuePair<Bounds, object>.ToString
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.ToString
	|
	|-RVA: 0x18CAB20 Offset: 0x18C9520 VA: 0x1818CAB20
	|-KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>.ToString
	|
	|-RVA: 0x18CAE60 Offset: 0x18C9860 VA: 0x1818CAE60
	|-KeyValuePair<CSteamID, int>.ToString
	|-KeyValuePair<Int2, int>.ToString
	|
	|-RVA: 0x18CBC20 Offset: 0x18CA620 VA: 0x1818CBC20
	|-KeyValuePair<FullRank, object>.ToString
	|-KeyValuePair<Int2, object>.ToString
	|-KeyValuePair<long, object>.ToString
	|-KeyValuePair<IntPtr, object>.ToString
	|-KeyValuePair<TerrainTileCoord, object>.ToString
	|-KeyValuePair<ulong, object>.ToString
	|-KeyValuePair<Vector2Int, object>.ToString
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.ToString
	|
	|-RVA: 0x18CA330 Offset: 0x18C8D30 VA: 0x1818CA330
	|-KeyValuePair<HSteamNetConnection, int>.ToString
	|-KeyValuePair<int, HSteamNetConnection>.ToString
	|-KeyValuePair<int, int>.ToString
	|-KeyValuePair<int, Int32Enum>.ToString
	|-KeyValuePair<int, uint>.ToString
	|-KeyValuePair<Int32Enum, int>.ToString
	|-KeyValuePair<Int32Enum, Int32Enum>.ToString
	|-KeyValuePair<uint, int>.ToString
	|
	|-RVA: 0x18CB120 Offset: 0x18C9B20 VA: 0x1818CB120
	|-KeyValuePair<Hash128, int>.ToString
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>.ToString
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.ToString
	|
	|-RVA: 0x18CB410 Offset: 0x18C9E10 VA: 0x1818CB410
	|-KeyValuePair<Int3, int>.ToString
	|
	|-RVA: 0x18CBAA0 Offset: 0x18CA4A0 VA: 0x1818CBAA0
	|-KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.ToString
	|-KeyValuePair<int, CSteamID>.ToString
	|-KeyValuePair<int, Vector2Int>.ToString
	|-KeyValuePair<int, Multipass.TransportIdData>.ToString
	|-KeyValuePair<uint, RpcLinkType>.ToString
	|
	|-RVA: 0x18CB2A0 Offset: 0x18C9CA0 VA: 0x1818CB2A0
	|-KeyValuePair<int, TreeViewItemData<object>>.ToString
	|
	|-RVA: 0x18CB1E0 Offset: 0x18C9BE0 VA: 0x1818CB1E0
	|-KeyValuePair<int, ValueTuple<object, int>>.ToString
	|-KeyValuePair<int, TreeItem>.ToString
	|-KeyValuePair<uint, NetworkBehaviour.BufferedRpc>.ToString
	|
	|-RVA: 0x18CA070 Offset: 0x18C8A70 VA: 0x1818CA070
	|-KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>.ToString
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.ToString
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.ToString
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.ToString
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.ToString
	|
	|-RVA: 0x18CA9D0 Offset: 0x18C93D0 VA: 0x1818CA9D0
	|-KeyValuePair<int, bool>.ToString
	|-KeyValuePair<int, ByteEnum>.ToString
	|-KeyValuePair<Int32Enum, bool>.ToString
	|
	|-RVA: 0x18CBB60 Offset: 0x18CA560 VA: 0x1818CBB60
	|-KeyValuePair<int, short>.ToString
	|
	|-RVA: 0x18CBE60 Offset: 0x18CA860 VA: 0x1818CBE60
	|-KeyValuePair<int, Int3>.ToString
	|-KeyValuePair<int, Vector3>.ToString
	|
	|-RVA: 0x18CA550 Offset: 0x18C8F50 VA: 0x1818CA550
	|-KeyValuePair<int, long>.ToString
	|-KeyValuePair<int, ulong>.ToString
	|
	|-RVA: 0x18CA200 Offset: 0x18C8C00 VA: 0x1818CA200
	|-KeyValuePair<int, object>.ToString
	|-KeyValuePair<Int32Enum, object>.ToString
	|-KeyValuePair<PropertyName, object>.ToString
	|-KeyValuePair<Scene, object>.ToString
	|-KeyValuePair<uint, object>.ToString
	|
	|-RVA: 0x18CB830 Offset: 0x18CA230 VA: 0x1818CB830
	|-KeyValuePair<int, RenderInstancedDataLayout>.ToString
	|-KeyValuePair<int, Vector4>.ToString
	|
	|-RVA: 0x18CB4E0 Offset: 0x18C9EE0 VA: 0x1818CB4E0
	|-KeyValuePair<int, float>.ToString
	|
	|-RVA: 0x18CA140 Offset: 0x18C8B40 VA: 0x1818CA140
	|-KeyValuePair<int, Vector2>.ToString
	|-KeyValuePair<int, NetworkAnimator.SmoothedFloat>.ToString
	|
	|-RVA: 0x18CA480 Offset: 0x18C8E80 VA: 0x1818CA480
	|-KeyValuePair<int, NetworkAnimator.StateChange>.ToString
	|
	|-RVA: 0x18CBF30 Offset: 0x18CA930 VA: 0x1818CBF30
	|-KeyValuePair<int, ReflectionProbeManager.CachedProbe>.ToString
	|
	|-RVA: 0x18CB9D0 Offset: 0x18CA3D0 VA: 0x1818CB9D0
	|-KeyValuePair<int, TMP_ResourceManager.FontAssetRef>.ToString
	|-KeyValuePair<int, TextResourceManager.FontAssetRef>.ToString
	|
	|-RVA: 0x18C9EE0 Offset: 0x18C88E0 VA: 0x1818C9EE0
	|-KeyValuePair<long, ComputedStyle>.ToString
	|
	|-RVA: 0x18CAC00 Offset: 0x18C9600 VA: 0x1818CAC00
	|-KeyValuePair<InternedString, InternedString>.ToString
	|-KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>.ToString
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.ToString
	|
	|-RVA: 0x18CB080 Offset: 0x18C9A80 VA: 0x1818CB080
	|-KeyValuePair<NativeAddr, object>.ToString
	|
	|-RVA: 0x18C9E50 Offset: 0x18C8850 VA: 0x1818C9E50
	|-KeyValuePair<object, KeyValuePair<Int32Enum, object>>.ToString
	|-KeyValuePair<object, Color>.ToString
	|-KeyValuePair<object, Playable>.ToString
	|-KeyValuePair<object, Rect>.ToString
	|-KeyValuePair<object, ResourceLocator>.ToString
	|-KeyValuePair<object, StylePropertyValue>.ToString
	|-KeyValuePair<object, XPathNodeRef>.ToString
	|
	|-RVA: 0x18CAFE0 Offset: 0x18C99E0 VA: 0x1818CAFE0
	|-KeyValuePair<object, ValueTuple<Vector3, Quaternion>>.ToString
	|-KeyValuePair<object, SVGDocument.PatternData>.ToString
	|
	|-RVA: 0x18CC0F0 Offset: 0x18CAAF0 VA: 0x1818CC0F0
	|-KeyValuePair<object, bool>.ToString
	|-KeyValuePair<object, SVGDocument.ClipData>.ToString
	|
	|-RVA: 0x18CA880 Offset: 0x18C9280 VA: 0x1818CA880
	|-KeyValuePair<object, Bounds>.ToString
	|-KeyValuePair<object, Color>.ToString
	|-KeyValuePair<object, LiquidVolume.MeshCache>.ToString
	|-KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>.ToString
	|
	|-RVA: 0x18C9FE0 Offset: 0x18C89E0 VA: 0x1818C9FE0
	|-KeyValuePair<object, char>.ToString
	|-KeyValuePair<object, SVGDocument.MaskData>.ToString
	|
	|-RVA: 0x18CACC0 Offset: 0x18C96C0 VA: 0x1818CACC0
	|-KeyValuePair<object, Color32>.ToString
	|-KeyValuePair<object, int>.ToString
	|-KeyValuePair<object, Int32Enum>.ToString
	|-KeyValuePair<object, TextureId>.ToString
	|
	|-RVA: 0x18CA6D0 Offset: 0x18C90D0 VA: 0x1818CA6D0
	|-KeyValuePair<object, double>.ToString
	|-KeyValuePair<object, SVGDocument.NodeGlobalSceneState>.ToString
	|
	|-RVA: 0x18CA7F0 Offset: 0x18C91F0 VA: 0x1818CA7F0
	|-KeyValuePair<object, long>.ToString
	|-KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>.ToString
	|-KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>.ToString
	|-KeyValuePair<object, ObjectPool.DelayedStoreData>.ToString
	|-KeyValuePair<object, StyleComplexSelector.PseudoStateData>.ToString
	|
	|-RVA: 0x18CC320 Offset: 0x18CAD20 VA: 0x1818CC320
	|-KeyValuePair<object, object>.ToString
	|
	|-RVA: 0x18CB370 Offset: 0x18C9D70 VA: 0x1818CB370
	|-KeyValuePair<object, ProbeVolumeBakingProcessSettings>.ToString
	|
	|-RVA: 0x18CA920 Offset: 0x18C9320 VA: 0x1818CA920
	|-KeyValuePair<object, RaycastHit>.ToString
	|
	|-RVA: 0x18CA760 Offset: 0x18C9160 VA: 0x1818CA760
	|-KeyValuePair<object, float>.ToString
	|
	|-RVA: 0x18CAD50 Offset: 0x18C9750 VA: 0x1818CAD50
	|-KeyValuePair<object, InputControlLayout.ControlItem>.ToString
	|
	|-RVA: 0x18CAF20 Offset: 0x18C9920 VA: 0x1818CAF20
	|-KeyValuePair<object, JsonParser.JsonValue>.ToString
	|
	|-RVA: 0x18CB790 Offset: 0x18CA190 VA: 0x1818CB790
	|-KeyValuePair<object, SVGDocument.ViewBoxInfo>.ToString
	|
	|-RVA: 0x18CA3F0 Offset: 0x18C8DF0 VA: 0x1818CA3F0
	|-KeyValuePair<ushort, object>.ToString
	|
	|-RVA: 0x18CA610 Offset: 0x18C9010 VA: 0x1818CA610
	|-KeyValuePair<ushort, RpcLink>.ToString
	|
	|-RVA: 0x18CC260 Offset: 0x18CAC60 VA: 0x1818CC260
	|-KeyValuePair<ushort, ushort>.ToString
	|
	|-RVA: 0x18CBD80 Offset: 0x18CA780 VA: 0x1818CBD80
	|-KeyValuePair<uint, GlyphPairAdjustmentRecord>.ToString
	|
	|-RVA: 0x18CC180 Offset: 0x18CAB80 VA: 0x1818CC180
	|-KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>.ToString
	|
	|-RVA: 0x18CBCB0 Offset: 0x18CA6B0 VA: 0x1818CBCB0
	|-KeyValuePair<Vector3, Vector3>.ToString
	|
	|-RVA: 0x18CA290 Offset: 0x18C8C90 VA: 0x1818CA290
	|-KeyValuePair<Vector3Int, object>.ToString
	|
	|-RVA: 0x18CB5A0 Offset: 0x18C9FA0 VA: 0x1818CB5A0
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public void Deconstruct(out TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18C8640 Offset: 0x18C7040 VA: 0x1818C8640
	|-KeyValuePair<KeyValuePair<object, object>, object>.Deconstruct
	|-KeyValuePair<StructMultiKey<object, object>, object>.Deconstruct
	|-KeyValuePair<ValueTuple<object, int>, object>.Deconstruct
	|-KeyValuePair<ValueTuple<object, object>, object>.Deconstruct
	|-KeyValuePair<InternedString, object>.Deconstruct
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>.Deconstruct
	|
	|-RVA: 0x18C9030 Offset: 0x18C7A30 VA: 0x1818C9030
	|-KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>.Deconstruct
	|
	|-RVA: 0x18C9300 Offset: 0x18C7D00 VA: 0x1818C9300
	|-KeyValuePair<Bounds, object>.Deconstruct
	|
	|-RVA: 0x18C87B0 Offset: 0x18C71B0 VA: 0x1818C87B0
	|-KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>.Deconstruct
	|
	|-RVA: 0x18C8C00 Offset: 0x18C7600 VA: 0x1818C8C00
	|-KeyValuePair<CSteamID, int>.Deconstruct
	|-KeyValuePair<Int2, int>.Deconstruct
	|
	|-RVA: 0x18C8360 Offset: 0x18C6D60 VA: 0x1818C8360
	|-KeyValuePair<FullRank, object>.Deconstruct
	|-KeyValuePair<Int2, object>.Deconstruct
	|-KeyValuePair<long, object>.Deconstruct
	|-KeyValuePair<IntPtr, object>.Deconstruct
	|-KeyValuePair<TerrainTileCoord, object>.Deconstruct
	|-KeyValuePair<ulong, object>.Deconstruct
	|-KeyValuePair<Vector2Int, object>.Deconstruct
	|-KeyValuePair<StyleSheetCache.SheetHandleKey, object>.Deconstruct
	|
	|-RVA: 0x18C8840 Offset: 0x18C7240 VA: 0x1818C8840
	|-KeyValuePair<Guid, object>.Deconstruct
	|-KeyValuePair<Hash128, object>.Deconstruct
	|-KeyValuePair<Rect, object>.Deconstruct
	|
	|-RVA: 0x18C8080 Offset: 0x18C6A80 VA: 0x1818C8080
	|-KeyValuePair<HSteamNetConnection, int>.Deconstruct
	|-KeyValuePair<int, HSteamNetConnection>.Deconstruct
	|-KeyValuePair<int, int>.Deconstruct
	|-KeyValuePair<int, Int32Enum>.Deconstruct
	|-KeyValuePair<int, float>.Deconstruct
	|-KeyValuePair<int, uint>.Deconstruct
	|-KeyValuePair<Int32Enum, int>.Deconstruct
	|-KeyValuePair<Int32Enum, Int32Enum>.Deconstruct
	|-KeyValuePair<uint, int>.Deconstruct
	|
	|-RVA: 0x18C9D70 Offset: 0x18C8770 VA: 0x1818C9D70
	|-KeyValuePair<Hash128, int>.Deconstruct
	|
	|-RVA: 0x18C80F0 Offset: 0x18C6AF0 VA: 0x1818C80F0
	|-KeyValuePair<Int3, int>.Deconstruct
	|
	|-RVA: 0x18C8D00 Offset: 0x18C7700 VA: 0x1818C8D00
	|-KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Deconstruct
	|-KeyValuePair<int, CSteamID>.Deconstruct
	|-KeyValuePair<int, Vector2Int>.Deconstruct
	|-KeyValuePair<int, Multipass.TransportIdData>.Deconstruct
	|-KeyValuePair<uint, RpcLinkType>.Deconstruct
	|
	|-RVA: 0x18C9C70 Offset: 0x18C8670 VA: 0x1818C9C70
	|-KeyValuePair<int, TreeViewItemData<object>>.Deconstruct
	|
	|-RVA: 0x18C95E0 Offset: 0x18C7FE0 VA: 0x1818C95E0
	|-KeyValuePair<int, ValueTuple<object, int>>.Deconstruct
	|-KeyValuePair<uint, NetworkBehaviour.BufferedRpc>.Deconstruct
	|
	|-RVA: 0x18C8160 Offset: 0x18C6B60 VA: 0x1818C8160
	|-KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>.Deconstruct
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.Deconstruct
	|-KeyValuePair<uint, MarkToBaseAdjustmentRecord>.Deconstruct
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.Deconstruct
	|-KeyValuePair<uint, MarkToMarkAdjustmentRecord>.Deconstruct
	|
	|-RVA: 0x18C83D0 Offset: 0x18C6DD0 VA: 0x1818C83D0
	|-KeyValuePair<int, bool>.Deconstruct
	|-KeyValuePair<int, ByteEnum>.Deconstruct
	|-KeyValuePair<Int32Enum, bool>.Deconstruct
	|
	|-RVA: 0x18C9DE0 Offset: 0x18C87E0 VA: 0x1818C9DE0
	|-KeyValuePair<int, short>.Deconstruct
	|
	|-RVA: 0x18C9C00 Offset: 0x18C8600 VA: 0x1818C9C00
	|-KeyValuePair<int, Int3>.Deconstruct
	|-KeyValuePair<int, Vector3>.Deconstruct
	|
	|-RVA: 0x18C8A10 Offset: 0x18C7410 VA: 0x1818C8A10
	|-KeyValuePair<int, long>.Deconstruct
	|-KeyValuePair<int, ulong>.Deconstruct
	|
	|-RVA: 0x18C86C0 Offset: 0x18C70C0 VA: 0x1818C86C0
	|-KeyValuePair<int, object>.Deconstruct
	|-KeyValuePair<Int32Enum, object>.Deconstruct
	|-KeyValuePair<PropertyName, object>.Deconstruct
	|-KeyValuePair<Scene, object>.Deconstruct
	|-KeyValuePair<uint, object>.Deconstruct
	|
	|-RVA: 0x18C9750 Offset: 0x18C8150 VA: 0x1818C9750
	|-KeyValuePair<int, RenderInstancedDataLayout>.Deconstruct
	|-KeyValuePair<int, Vector4>.Deconstruct
	|
	|-RVA: 0x18C9280 Offset: 0x18C7C80 VA: 0x1818C9280
	|-KeyValuePair<int, TreeItem>.Deconstruct
	|
	|-RVA: 0x18C9380 Offset: 0x18C7D80 VA: 0x1818C9380
	|-KeyValuePair<int, Vector2>.Deconstruct
	|-KeyValuePair<int, NetworkAnimator.SmoothedFloat>.Deconstruct
	|
	|-RVA: 0x18C85C0 Offset: 0x18C6FC0 VA: 0x1818C85C0
	|-KeyValuePair<int, NetworkAnimator.StateChange>.Deconstruct
	|
	|-RVA: 0x18C9150 Offset: 0x18C7B50 VA: 0x1818C9150
	|-KeyValuePair<int, ReflectionProbeManager.CachedProbe>.Deconstruct
	|
	|-RVA: 0x18C9560 Offset: 0x18C7F60 VA: 0x1818C9560
	|-KeyValuePair<int, TMP_ResourceManager.FontAssetRef>.Deconstruct
	|-KeyValuePair<int, TextResourceManager.FontAssetRef>.Deconstruct
	|
	|-RVA: 0x18C9B60 Offset: 0x18C8560 VA: 0x1818C9B60
	|-KeyValuePair<long, ComputedStyle>.Deconstruct
	|
	|-RVA: 0x18C81E0 Offset: 0x18C6BE0 VA: 0x1818C81E0
	|-KeyValuePair<InternedString, InternedString>.Deconstruct
	|-KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Deconstruct
	|-KeyValuePair<XPathNodeRef, XPathNodeRef>.Deconstruct
	|
	|-RVA: 0x18C96D0 Offset: 0x18C80D0 VA: 0x1818C96D0
	|-KeyValuePair<NativeAddr, object>.Deconstruct
	|
	|-RVA: 0x18C8440 Offset: 0x18C6E40 VA: 0x1818C8440
	|-KeyValuePair<object, KeyValuePair<Int32Enum, object>>.Deconstruct
	|
	|-RVA: 0x18C8A80 Offset: 0x18C7480 VA: 0x1818C8A80
	|-KeyValuePair<object, ValueTuple<Vector3, Quaternion>>.Deconstruct
	|-KeyValuePair<object, SVGDocument.PatternData>.Deconstruct
	|
	|-RVA: 0x18C8920 Offset: 0x18C7320 VA: 0x1818C8920
	|-KeyValuePair<object, bool>.Deconstruct
	|-KeyValuePair<object, SVGDocument.ClipData>.Deconstruct
	|
	|-RVA: 0x18C9400 Offset: 0x18C7E00 VA: 0x1818C9400
	|-KeyValuePair<object, Bounds>.Deconstruct
	|
	|-RVA: 0x18C97C0 Offset: 0x18C81C0 VA: 0x1818C97C0
	|-KeyValuePair<object, char>.Deconstruct
	|-KeyValuePair<object, SVGDocument.MaskData>.Deconstruct
	|
	|-RVA: 0x18C8260 Offset: 0x18C6C60 VA: 0x1818C8260
	|-KeyValuePair<object, Color>.Deconstruct
	|-KeyValuePair<object, LiquidVolume.MeshCache>.Deconstruct
	|
	|-RVA: 0x18C9480 Offset: 0x18C7E80 VA: 0x1818C9480
	|-KeyValuePair<object, Color>.Deconstruct
	|-KeyValuePair<object, Playable>.Deconstruct
	|-KeyValuePair<object, Rect>.Deconstruct
	|
	|-RVA: 0x18C8B00 Offset: 0x18C7500 VA: 0x1818C8B00
	|-KeyValuePair<object, Color32>.Deconstruct
	|-KeyValuePair<object, int>.Deconstruct
	|-KeyValuePair<object, Int32Enum>.Deconstruct
	|-KeyValuePair<object, float>.Deconstruct
	|-KeyValuePair<object, TextureId>.Deconstruct
	|
	|-RVA: 0x18C8010 Offset: 0x18C6A10 VA: 0x1818C8010
	|-KeyValuePair<object, double>.Deconstruct
	|-KeyValuePair<object, long>.Deconstruct
	|-KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>.Deconstruct
	|-KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>.Deconstruct
	|-KeyValuePair<object, ObjectPool.DelayedStoreData>.Deconstruct
	|-KeyValuePair<object, StyleComplexSelector.PseudoStateData>.Deconstruct
	|
	|-RVA: 0x18C9830 Offset: 0x18C8230 VA: 0x1818C9830
	|-KeyValuePair<object, object>.Deconstruct
	|
	|-RVA: 0x18C84C0 Offset: 0x18C6EC0 VA: 0x1818C84C0
	|-KeyValuePair<object, ProbeVolumeBakingProcessSettings>.Deconstruct
	|
	|-RVA: 0x18C98B0 Offset: 0x18C82B0 VA: 0x1818C98B0
	|-KeyValuePair<object, RaycastHit>.Deconstruct
	|
	|-RVA: 0x18C8990 Offset: 0x18C7390 VA: 0x1818C8990
	|-KeyValuePair<object, ResourceLocator>.Deconstruct
	|-KeyValuePair<object, StylePropertyValue>.Deconstruct
	|-KeyValuePair<object, XPathNodeRef>.Deconstruct
	|
	|-RVA: 0x18C9940 Offset: 0x18C8340 VA: 0x1818C9940
	|-KeyValuePair<object, InputControlLayout.ControlItem>.Deconstruct
	|
	|-RVA: 0x18C9AC0 Offset: 0x18C84C0 VA: 0x1818C9AC0
	|-KeyValuePair<object, JsonParser.JsonValue>.Deconstruct
	|
	|-RVA: 0x18C8FA0 Offset: 0x18C79A0 VA: 0x1818C8FA0
	|-KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>.Deconstruct
	|
	|-RVA: 0x18C8730 Offset: 0x18C7130 VA: 0x1818C8730
	|-KeyValuePair<object, SVGDocument.NodeGlobalSceneState>.Deconstruct
	|
	|-RVA: 0x18C9CF0 Offset: 0x18C86F0 VA: 0x1818C9CF0
	|-KeyValuePair<object, SVGDocument.ViewBoxInfo>.Deconstruct
	|
	|-RVA: 0x18C82F0 Offset: 0x18C6CF0 VA: 0x1818C82F0
	|-KeyValuePair<ushort, object>.Deconstruct
	|
	|-RVA: 0x18C94F0 Offset: 0x18C7EF0 VA: 0x1818C94F0
	|-KeyValuePair<ushort, RpcLink>.Deconstruct
	|
	|-RVA: 0x18C88B0 Offset: 0x18C72B0 VA: 0x1818C88B0
	|-KeyValuePair<ushort, ushort>.Deconstruct
	|
	|-RVA: 0x18C9650 Offset: 0x18C8050 VA: 0x1818C9650
	|-KeyValuePair<uint, GlyphPairAdjustmentRecord>.Deconstruct
	|
	|-RVA: 0x18C8C70 Offset: 0x18C7670 VA: 0x1818C8C70
	|-KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Deconstruct
	|
	|-RVA: 0x18C90D0 Offset: 0x18C7AD0 VA: 0x1818C90D0
	|-KeyValuePair<Vector3, Vector3>.Deconstruct
	|
	|-RVA: 0x18C8540 Offset: 0x18C6F40 VA: 0x1818C8540
	|-KeyValuePair<Vector3Int, object>.Deconstruct
	|
	|-RVA: 0x18C8D70 Offset: 0x18C7770 VA: 0x1818C8D70
	|-KeyValuePair<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Deconstruct
	|
	|-RVA: 0x18C8B70 Offset: 0x18C7570 VA: 0x1818C8B70
	|-KeyValuePair<Regex.CachedCodeEntryKey, object>.Deconstruct
	|
	|-RVA: 0x18C9210 Offset: 0x18C7C10 VA: 0x1818C9210
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>.Deconstruct
	|-KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Deconstruct
	*/
}
