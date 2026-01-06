public sealed class Dictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 4966
{
	// Fields
	private Dictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3F70 Offset: 0x12F2970 VA: 0x1812F3F70
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>..ctor
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>..ctor
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>..ctor
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>..ctor
	|-Dictionary.ValueCollection<Bounds, object>..ctor
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|-Dictionary.ValueCollection<CSteamID, int>..ctor
	|-Dictionary.ValueCollection<FullRank, object>..ctor
	|-Dictionary.ValueCollection<Guid, object>..ctor
	|-Dictionary.ValueCollection<HSteamNetConnection, int>..ctor
	|-Dictionary.ValueCollection<Hash128, int>..ctor
	|-Dictionary.ValueCollection<Hash128, object>..ctor
	|-Dictionary.ValueCollection<Int2, int>..ctor
	|-Dictionary.ValueCollection<Int2, object>..ctor
	|-Dictionary.ValueCollection<Int3, int>..ctor
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>..ctor
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|-Dictionary.ValueCollection<int, bool>..ctor
	|-Dictionary.ValueCollection<int, ByteEnum>..ctor
	|-Dictionary.ValueCollection<int, CSteamID>..ctor
	|-Dictionary.ValueCollection<int, HSteamNetConnection>..ctor
	|-Dictionary.ValueCollection<int, short>..ctor
	|-Dictionary.ValueCollection<int, Int3>..ctor
	|-Dictionary.ValueCollection<int, int>..ctor
	|-Dictionary.ValueCollection<int, Int32Enum>..ctor
	|-Dictionary.ValueCollection<int, long>..ctor
	|-Dictionary.ValueCollection<int, object>..ctor
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>..ctor
	|-Dictionary.ValueCollection<int, float>..ctor
	|-Dictionary.ValueCollection<int, TreeItem>..ctor
	|-Dictionary.ValueCollection<int, uint>..ctor
	|-Dictionary.ValueCollection<int, ulong>..ctor
	|-Dictionary.ValueCollection<int, Vector2Int>..ctor
	|-Dictionary.ValueCollection<int, Vector3>..ctor
	|-Dictionary.ValueCollection<int, Vector4>..ctor
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>..ctor
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>..ctor
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>..ctor
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>..ctor
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>..ctor
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>..ctor
	|-Dictionary.ValueCollection<Int32Enum, bool>..ctor
	|-Dictionary.ValueCollection<Int32Enum, int>..ctor
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>..ctor
	|-Dictionary.ValueCollection<Int32Enum, object>..ctor
	|-Dictionary.ValueCollection<long, ComputedStyle>..ctor
	|-Dictionary.ValueCollection<long, object>..ctor
	|-Dictionary.ValueCollection<IntPtr, object>..ctor
	|-Dictionary.ValueCollection<InternedString, InternedString>..ctor
	|-Dictionary.ValueCollection<InternedString, object>..ctor
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|-Dictionary.ValueCollection<NativeAddr, object>..ctor
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>..ctor
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>..ctor
	|-Dictionary.ValueCollection<object, bool>..ctor
	|-Dictionary.ValueCollection<object, Bounds>..ctor
	|-Dictionary.ValueCollection<object, Color>..ctor
	|-Dictionary.ValueCollection<object, Color>..ctor
	|-Dictionary.ValueCollection<object, Color32>..ctor
	|-Dictionary.ValueCollection<object, double>..ctor
	|-Dictionary.ValueCollection<object, int>..ctor
	|-Dictionary.ValueCollection<object, Int32Enum>..ctor
	|-Dictionary.ValueCollection<object, long>..ctor
	|-Dictionary.ValueCollection<object, object>..ctor
	|-Dictionary.ValueCollection<object, Playable>..ctor
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>..ctor
	|-Dictionary.ValueCollection<object, RaycastHit>..ctor
	|-Dictionary.ValueCollection<object, Rect>..ctor
	|-Dictionary.ValueCollection<object, ResourceLocator>..ctor
	|-Dictionary.ValueCollection<object, float>..ctor
	|-Dictionary.ValueCollection<object, StylePropertyValue>..ctor
	|-Dictionary.ValueCollection<object, TextureId>..ctor
	|-Dictionary.ValueCollection<object, XPathNodeRef>..ctor
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>..ctor
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>..ctor
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>..ctor
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>..ctor
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>..ctor
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>..ctor
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>..ctor
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>..ctor
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>..ctor
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>..ctor
	|-Dictionary.ValueCollection<Scene, object>..ctor
	|-Dictionary.ValueCollection<TerrainTileCoord, object>..ctor
	|-Dictionary.ValueCollection<ushort, object>..ctor
	|-Dictionary.ValueCollection<ushort, RpcLink>..ctor
	|-Dictionary.ValueCollection<ushort, ushort>..ctor
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, int>..ctor
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary.ValueCollection<uint, object>..ctor
	|-Dictionary.ValueCollection<uint, RpcLinkType>..ctor
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>..ctor
	|-Dictionary.ValueCollection<ulong, object>..ctor
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|-Dictionary.ValueCollection<Vector2Int, object>..ctor
	|-Dictionary.ValueCollection<Vector3, Vector3>..ctor
	|-Dictionary.ValueCollection<Vector3Int, object>..ctor
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>..ctor
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3AD0 Offset: 0x12F24D0 VA: 0x1812F3AD0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.GetEnumerator
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.GetEnumerator
	|-Dictionary.ValueCollection<Bounds, object>.GetEnumerator
	|-Dictionary.ValueCollection<FullRank, object>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, object>.GetEnumerator
	|-Dictionary.ValueCollection<Int2, object>.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.GetEnumerator
	|-Dictionary.ValueCollection<int, CSteamID>.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.GetEnumerator
	|-Dictionary.ValueCollection<int, ulong>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector2Int>.GetEnumerator
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.GetEnumerator
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, object>.GetEnumerator
	|-Dictionary.ValueCollection<NativeAddr, object>.GetEnumerator
	|-Dictionary.ValueCollection<object, double>.GetEnumerator
	|-Dictionary.ValueCollection<object, long>.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.GetEnumerator
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.GetEnumerator
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.GetEnumerator
	|-Dictionary.ValueCollection<Scene, object>.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, object>.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.GetEnumerator
	|-Dictionary.ValueCollection<uint, RpcLinkType>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, object>.GetEnumerator
	|-Dictionary.ValueCollection<Vector2Int, object>.GetEnumerator
	|-Dictionary.ValueCollection<Vector3Int, object>.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0x12F6370 Offset: 0x12F4D70 VA: 0x1812F6370
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.GetEnumerator
	|
	|-RVA: 0x12F6190 Offset: 0x12F4B90 VA: 0x1812F6190
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.GetEnumerator
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector4>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InternedString>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.GetEnumerator
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.GetEnumerator
	|-Dictionary.ValueCollection<object, Playable>.GetEnumerator
	|-Dictionary.ValueCollection<object, Rect>.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, RpcLink>.GetEnumerator
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|
	|-RVA: 0x12F6150 Offset: 0x12F4B50 VA: 0x1812F6150
	|-Dictionary.ValueCollection<CSteamID, int>.GetEnumerator
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, int>.GetEnumerator
	|-Dictionary.ValueCollection<Int2, int>.GetEnumerator
	|-Dictionary.ValueCollection<Int3, int>.GetEnumerator
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.GetEnumerator
	|-Dictionary.ValueCollection<int, uint>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.GetEnumerator
	|
	|-RVA: 0x12F6250 Offset: 0x12F4C50 VA: 0x1812F6250
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.GetEnumerator
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.GetEnumerator
	|-Dictionary.ValueCollection<object, Bounds>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.GetEnumerator
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.GetEnumerator
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x12F6110 Offset: 0x12F4B10 VA: 0x1812F6110
	|-Dictionary.ValueCollection<int, bool>.GetEnumerator
	|-Dictionary.ValueCollection<int, ByteEnum>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.GetEnumerator
	|
	|-RVA: 0x12F62D0 Offset: 0x12F4CD0 VA: 0x1812F62D0
	|-Dictionary.ValueCollection<int, short>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, ushort>.GetEnumerator
	|
	|-RVA: 0x12F6290 Offset: 0x12F4C90 VA: 0x1812F6290
	|-Dictionary.ValueCollection<int, Int3>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector3>.GetEnumerator
	|-Dictionary.ValueCollection<Vector3, Vector3>.GetEnumerator
	|
	|-RVA: 0x12F6210 Offset: 0x12F4C10 VA: 0x1812F6210
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.GetEnumerator
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.GetEnumerator
	|
	|-RVA: 0x12F6310 Offset: 0x12F4D10 VA: 0x1812F6310
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.GetEnumerator
	|
	|-RVA: 0x12F61D0 Offset: 0x12F4BD0 VA: 0x1812F61D0
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.GetEnumerator
	|
	|-RVA: 0x12F60C0 Offset: 0x12F4AC0 VA: 0x1812F60C0
	|-Dictionary.ValueCollection<long, ComputedStyle>.GetEnumerator
	|
	|-RVA: 0x1305EF0 Offset: 0x13048F0 VA: 0x181305EF0
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.GetEnumerator
	|
	|-RVA: 0x1305F30 Offset: 0x1304930 VA: 0x181305F30
	|-Dictionary.ValueCollection<object, RaycastHit>.GetEnumerator
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x1305E90 Offset: 0x1304890 VA: 0x181305E90
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.GetEnumerator
	|
	|-RVA: 0x1305FC0 Offset: 0x13049C0 VA: 0x181305FC0
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.GetEnumerator
	|
	|-RVA: 0x1305E50 Offset: 0x1304850 VA: 0x181305E50
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.GetEnumerator
	|
	|-RVA: 0x1305DA0 Offset: 0x13047A0 VA: 0x181305DA0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3990 Offset: 0x12F2390 VA: 0x1812F3990
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.CopyTo
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.CopyTo
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.CopyTo
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.CopyTo
	|-Dictionary.ValueCollection<Guid, object>.CopyTo
	|-Dictionary.ValueCollection<Hash128, object>.CopyTo
	|-Dictionary.ValueCollection<InternedString, object>.CopyTo
	|-Dictionary.ValueCollection<Vector3Int, object>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.CopyTo
	|
	|-RVA: 0x12F4B50 Offset: 0x12F3550 VA: 0x1812F4B50
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.CopyTo
	|
	|-RVA: 0x12F5680 Offset: 0x12F4080 VA: 0x1812F5680
	|-Dictionary.ValueCollection<Bounds, object>.CopyTo
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.CopyTo
	|
	|-RVA: 0x12F5A30 Offset: 0x12F4430 VA: 0x1812F5A30
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.CopyTo
	|
	|-RVA: 0x12F46D0 Offset: 0x12F30D0 VA: 0x1812F46D0
	|-Dictionary.ValueCollection<CSteamID, int>.CopyTo
	|-Dictionary.ValueCollection<Int2, int>.CopyTo
	|
	|-RVA: 0x12F42A0 Offset: 0x12F2CA0 VA: 0x1812F42A0
	|-Dictionary.ValueCollection<FullRank, object>.CopyTo
	|-Dictionary.ValueCollection<Int2, object>.CopyTo
	|-Dictionary.ValueCollection<int, object>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, object>.CopyTo
	|-Dictionary.ValueCollection<long, object>.CopyTo
	|-Dictionary.ValueCollection<IntPtr, object>.CopyTo
	|-Dictionary.ValueCollection<object, object>.CopyTo
	|-Dictionary.ValueCollection<Scene, object>.CopyTo
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.CopyTo
	|-Dictionary.ValueCollection<ushort, object>.CopyTo
	|-Dictionary.ValueCollection<uint, object>.CopyTo
	|-Dictionary.ValueCollection<ulong, object>.CopyTo
	|-Dictionary.ValueCollection<Vector2Int, object>.CopyTo
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x12F47F0 Offset: 0x12F31F0 VA: 0x1812F47F0
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.CopyTo
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.CopyTo
	|-Dictionary.ValueCollection<int, int>.CopyTo
	|-Dictionary.ValueCollection<int, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<int, float>.CopyTo
	|-Dictionary.ValueCollection<int, uint>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, int>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<uint, int>.CopyTo
	|
	|-RVA: 0x12F5B80 Offset: 0x12F4580 VA: 0x1812F5B80
	|-Dictionary.ValueCollection<Hash128, int>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.CopyTo
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.CopyTo
	|
	|-RVA: 0x12F51F0 Offset: 0x12F3BF0 VA: 0x1812F51F0
	|-Dictionary.ValueCollection<Int3, int>.CopyTo
	|
	|-RVA: 0x12F4A30 Offset: 0x12F3430 VA: 0x1812F4A30
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.CopyTo
	|-Dictionary.ValueCollection<int, CSteamID>.CopyTo
	|-Dictionary.ValueCollection<int, Vector2Int>.CopyTo
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.CopyTo
	|-Dictionary.ValueCollection<uint, RpcLinkType>.CopyTo
	|
	|-RVA: 0x12F4CD0 Offset: 0x12F36D0 VA: 0x1812F4CD0
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.CopyTo
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.CopyTo
	|
	|-RVA: 0x12F5F90 Offset: 0x12F4990 VA: 0x1812F5F90
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.CopyTo
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x12F5430 Offset: 0x12F3E30 VA: 0x1812F5430
	|-Dictionary.ValueCollection<int, bool>.CopyTo
	|-Dictionary.ValueCollection<int, ByteEnum>.CopyTo
	|-Dictionary.ValueCollection<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x12F4910 Offset: 0x12F3310 VA: 0x1812F4910
	|-Dictionary.ValueCollection<int, short>.CopyTo
	|
	|-RVA: 0x12F5550 Offset: 0x12F3F50 VA: 0x1812F5550
	|-Dictionary.ValueCollection<int, Int3>.CopyTo
	|-Dictionary.ValueCollection<int, Vector3>.CopyTo
	|
	|-RVA: 0x12F5310 Offset: 0x12F3D10 VA: 0x1812F5310
	|-Dictionary.ValueCollection<int, long>.CopyTo
	|-Dictionary.ValueCollection<int, ulong>.CopyTo
	|-Dictionary.ValueCollection<object, double>.CopyTo
	|-Dictionary.ValueCollection<object, long>.CopyTo
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.CopyTo
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.CopyTo
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.CopyTo
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.CopyTo
	|
	|-RVA: 0x12F5900 Offset: 0x12F4300 VA: 0x1812F5900
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.CopyTo
	|-Dictionary.ValueCollection<int, Vector4>.CopyTo
	|-Dictionary.ValueCollection<ushort, RpcLink>.CopyTo
	|
	|-RVA: 0x12F4F70 Offset: 0x12F3970 VA: 0x1812F4F70
	|-Dictionary.ValueCollection<int, TreeItem>.CopyTo
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x12F50C0 Offset: 0x12F3AC0 VA: 0x1812F50C0
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.CopyTo
	|
	|-RVA: 0x12F3FF0 Offset: 0x12F29F0 VA: 0x1812F3FF0
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.CopyTo
	|
	|-RVA: 0x12F4520 Offset: 0x12F2F20 VA: 0x1812F4520
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.CopyTo
	|
	|-RVA: 0x12F4130 Offset: 0x12F2B30 VA: 0x1812F4130
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.CopyTo
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.CopyTo
	|
	|-RVA: 0x12F5DF0 Offset: 0x12F47F0 VA: 0x1812F5DF0
	|-Dictionary.ValueCollection<long, ComputedStyle>.CopyTo
	|
	|-RVA: 0x12F5CA0 Offset: 0x12F46A0 VA: 0x1812F5CA0
	|-Dictionary.ValueCollection<InternedString, InternedString>.CopyTo
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.CopyTo
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x12F43E0 Offset: 0x12F2DE0 VA: 0x1812F43E0
	|-Dictionary.ValueCollection<NativeAddr, object>.CopyTo
	|
	|-RVA: 0x12F57C0 Offset: 0x12F41C0 VA: 0x1812F57C0
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.CopyTo
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.CopyTo
	|
	|-RVA: 0x12F4E50 Offset: 0x12F3850 VA: 0x1812F4E50
	|-Dictionary.ValueCollection<object, bool>.CopyTo
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.CopyTo
	|
	|-RVA: 0x13048B0 Offset: 0x13032B0 VA: 0x1813048B0
	|-Dictionary.ValueCollection<object, Bounds>.CopyTo
	|
	|-RVA: 0x13049E0 Offset: 0x13033E0 VA: 0x1813049E0
	|-Dictionary.ValueCollection<object, Color>.CopyTo
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.CopyTo
	|
	|-RVA: 0x13040F0 Offset: 0x1302AF0 VA: 0x1813040F0
	|-Dictionary.ValueCollection<object, Color>.CopyTo
	|-Dictionary.ValueCollection<object, Playable>.CopyTo
	|-Dictionary.ValueCollection<object, Rect>.CopyTo
	|
	|-RVA: 0x13051C0 Offset: 0x1303BC0 VA: 0x1813051C0
	|-Dictionary.ValueCollection<object, Color32>.CopyTo
	|-Dictionary.ValueCollection<object, int>.CopyTo
	|-Dictionary.ValueCollection<object, Int32Enum>.CopyTo
	|-Dictionary.ValueCollection<object, float>.CopyTo
	|-Dictionary.ValueCollection<object, TextureId>.CopyTo
	|
	|-RVA: 0x13056E0 Offset: 0x13040E0 VA: 0x1813056E0
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.CopyTo
	|
	|-RVA: 0x1304CA0 Offset: 0x13036A0 VA: 0x181304CA0
	|-Dictionary.ValueCollection<object, RaycastHit>.CopyTo
	|
	|-RVA: 0x1304B50 Offset: 0x1303550 VA: 0x181304B50
	|-Dictionary.ValueCollection<object, ResourceLocator>.CopyTo
	|-Dictionary.ValueCollection<object, StylePropertyValue>.CopyTo
	|-Dictionary.ValueCollection<object, XPathNodeRef>.CopyTo
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.CopyTo
	|
	|-RVA: 0x1304470 Offset: 0x1302E70 VA: 0x181304470
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.CopyTo
	|
	|-RVA: 0x1305410 Offset: 0x1303E10 VA: 0x181305410
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.CopyTo
	|
	|-RVA: 0x1305820 Offset: 0x1304220 VA: 0x181305820
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.CopyTo
	|
	|-RVA: 0x13055B0 Offset: 0x1303FB0 VA: 0x1813055B0
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.CopyTo
	|
	|-RVA: 0x1305C70 Offset: 0x1304670 VA: 0x181305C70
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.CopyTo
	|
	|-RVA: 0x13050A0 Offset: 0x1303AA0 VA: 0x1813050A0
	|-Dictionary.ValueCollection<ushort, ushort>.CopyTo
	|
	|-RVA: 0x1304F60 Offset: 0x1303960 VA: 0x181304F60
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x1304DE0 Offset: 0x13037E0 VA: 0x181304DE0
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.CopyTo
	|
	|-RVA: 0x13052E0 Offset: 0x1303CE0 VA: 0x1813052E0
	|-Dictionary.ValueCollection<Vector3, Vector3>.CopyTo
	|
	|-RVA: 0x1304650 Offset: 0x1303050 VA: 0x181304650
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3FC0 Offset: 0x12F29C0 VA: 0x1812F3FC0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.get_Count
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.get_Count
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.get_Count
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.get_Count
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.get_Count
	|-Dictionary.ValueCollection<Bounds, object>.get_Count
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.get_Count
	|-Dictionary.ValueCollection<CSteamID, int>.get_Count
	|-Dictionary.ValueCollection<FullRank, object>.get_Count
	|-Dictionary.ValueCollection<Guid, object>.get_Count
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.get_Count
	|-Dictionary.ValueCollection<Hash128, int>.get_Count
	|-Dictionary.ValueCollection<Hash128, object>.get_Count
	|-Dictionary.ValueCollection<Int2, int>.get_Count
	|-Dictionary.ValueCollection<Int2, object>.get_Count
	|-Dictionary.ValueCollection<Int3, int>.get_Count
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Count
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.get_Count
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.get_Count
	|-Dictionary.ValueCollection<int, bool>.get_Count
	|-Dictionary.ValueCollection<int, ByteEnum>.get_Count
	|-Dictionary.ValueCollection<int, CSteamID>.get_Count
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.get_Count
	|-Dictionary.ValueCollection<int, short>.get_Count
	|-Dictionary.ValueCollection<int, Int3>.get_Count
	|-Dictionary.ValueCollection<int, int>.get_Count
	|-Dictionary.ValueCollection<int, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<int, long>.get_Count
	|-Dictionary.ValueCollection<int, object>.get_Count
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.get_Count
	|-Dictionary.ValueCollection<int, float>.get_Count
	|-Dictionary.ValueCollection<int, TreeItem>.get_Count
	|-Dictionary.ValueCollection<int, uint>.get_Count
	|-Dictionary.ValueCollection<int, ulong>.get_Count
	|-Dictionary.ValueCollection<int, Vector2Int>.get_Count
	|-Dictionary.ValueCollection<int, Vector3>.get_Count
	|-Dictionary.ValueCollection<int, Vector4>.get_Count
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.get_Count
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.get_Count
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.get_Count
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.get_Count
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.get_Count
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, bool>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, int>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<Int32Enum, object>.get_Count
	|-Dictionary.ValueCollection<long, ComputedStyle>.get_Count
	|-Dictionary.ValueCollection<long, object>.get_Count
	|-Dictionary.ValueCollection<IntPtr, object>.get_Count
	|-Dictionary.ValueCollection<InternedString, InternedString>.get_Count
	|-Dictionary.ValueCollection<InternedString, object>.get_Count
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Count
	|-Dictionary.ValueCollection<NativeAddr, object>.get_Count
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.get_Count
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.get_Count
	|-Dictionary.ValueCollection<object, bool>.get_Count
	|-Dictionary.ValueCollection<object, Bounds>.get_Count
	|-Dictionary.ValueCollection<object, Color>.get_Count
	|-Dictionary.ValueCollection<object, Color>.get_Count
	|-Dictionary.ValueCollection<object, Color32>.get_Count
	|-Dictionary.ValueCollection<object, double>.get_Count
	|-Dictionary.ValueCollection<object, int>.get_Count
	|-Dictionary.ValueCollection<object, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<object, long>.get_Count
	|-Dictionary.ValueCollection<object, object>.get_Count
	|-Dictionary.ValueCollection<object, Playable>.get_Count
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.get_Count
	|-Dictionary.ValueCollection<object, RaycastHit>.get_Count
	|-Dictionary.ValueCollection<object, Rect>.get_Count
	|-Dictionary.ValueCollection<object, ResourceLocator>.get_Count
	|-Dictionary.ValueCollection<object, float>.get_Count
	|-Dictionary.ValueCollection<object, StylePropertyValue>.get_Count
	|-Dictionary.ValueCollection<object, TextureId>.get_Count
	|-Dictionary.ValueCollection<object, XPathNodeRef>.get_Count
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Count
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.get_Count
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.get_Count
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.get_Count
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.get_Count
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.get_Count
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.get_Count
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.get_Count
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.get_Count
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.get_Count
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.get_Count
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.get_Count
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.get_Count
	|-Dictionary.ValueCollection<Scene, object>.get_Count
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.get_Count
	|-Dictionary.ValueCollection<ushort, object>.get_Count
	|-Dictionary.ValueCollection<ushort, RpcLink>.get_Count
	|-Dictionary.ValueCollection<ushort, ushort>.get_Count
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, int>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary.ValueCollection<uint, object>.get_Count
	|-Dictionary.ValueCollection<uint, RpcLinkType>.get_Count
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.get_Count
	|-Dictionary.ValueCollection<ulong, object>.get_Count
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Count
	|-Dictionary.ValueCollection<Vector2Int, object>.get_Count
	|-Dictionary.ValueCollection<Vector3, Vector3>.get_Count
	|-Dictionary.ValueCollection<Vector3Int, object>.get_Count
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.get_Count
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Count
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Count
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.get_Count
	|
	|-RVA: 0x13147C0 Offset: 0x13131C0 VA: 0x1813147C0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B10 Offset: 0x12F2510 VA: 0x1812F3B10
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Add
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B50 Offset: 0x12F2550 VA: 0x1812F3B50
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B10 Offset: 0x12F2510 VA: 0x1812F3B10
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B20 Offset: 0x12F2520 VA: 0x1812F3B20
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F65D0 Offset: 0x12F4FD0 VA: 0x1812F65D0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6C40 Offset: 0x12F5640 VA: 0x1812F6C40
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F63B0 Offset: 0x12F4DB0 VA: 0x1812F63B0
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F67E0 Offset: 0x12F51E0 VA: 0x1812F67E0
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F64E0 Offset: 0x12F4EE0 VA: 0x1812F64E0
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6560 Offset: 0x12F4F60 VA: 0x1812F6560
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6480 Offset: 0x12F4E80 VA: 0x1812F6480
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F66E0 Offset: 0x12F50E0 VA: 0x1812F66E0
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6780 Offset: 0x12F5180 VA: 0x1812F6780
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6A10 Offset: 0x12F5410 VA: 0x1812F6A10
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6C70 Offset: 0x12F5670 VA: 0x1812F6C70
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F66B0 Offset: 0x12F50B0 VA: 0x1812F66B0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6B80 Offset: 0x12F5580 VA: 0x1812F6B80
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6B10 Offset: 0x12F5510 VA: 0x1812F6B10
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F63F0 Offset: 0x12F4DF0 VA: 0x1812F63F0
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6A90 Offset: 0x12F5490 VA: 0x1812F6A90
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6BB0 Offset: 0x12F55B0 VA: 0x1812F6BB0
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6420 Offset: 0x12F4E20 VA: 0x1812F6420
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F68E0 Offset: 0x12F52E0 VA: 0x1812F68E0
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6D20 Offset: 0x12F5720 VA: 0x1812F6D20
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6CF0 Offset: 0x12F56F0 VA: 0x1812F6CF0
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6B40 Offset: 0x12F5540 VA: 0x1812F6B40
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6710 Offset: 0x12F5110 VA: 0x1812F6710
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F67B0 Offset: 0x12F51B0 VA: 0x1812F67B0
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6A60 Offset: 0x12F5460 VA: 0x1812F6A60
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6980 Offset: 0x12F5380 VA: 0x1812F6980
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6590 Offset: 0x12F4F90 VA: 0x1812F6590
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F64B0 Offset: 0x12F4EB0 VA: 0x1812F64B0
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6CC0 Offset: 0x12F56C0 VA: 0x1812F6CC0
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6660 Offset: 0x12F5060 VA: 0x1812F6660
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6810 Offset: 0x12F5210 VA: 0x1812F6810
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6510 Offset: 0x12F4F10 VA: 0x1812F6510
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6890 Offset: 0x12F5290 VA: 0x1812F6890
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6910 Offset: 0x12F5310 VA: 0x1812F6910
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F69D0 Offset: 0x12F53D0 VA: 0x1812F69D0
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6C00 Offset: 0x12F5600 VA: 0x1812F6C00
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6450 Offset: 0x12F4E50 VA: 0x1812F6450
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6740 Offset: 0x12F5140 VA: 0x1812F6740
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6AC0 Offset: 0x12F54C0 VA: 0x1812F6AC0
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x12F6630 Offset: 0x12F5030 VA: 0x1812F6630
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306DD0 Offset: 0x13057D0 VA: 0x181306DD0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306D80 Offset: 0x1305780 VA: 0x181306D80
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306BA0 Offset: 0x13055A0 VA: 0x181306BA0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306EE0 Offset: 0x13058E0 VA: 0x181306EE0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306EB0 Offset: 0x13058B0 VA: 0x181306EB0
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306140 Offset: 0x1304B40 VA: 0x181306140
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306B70 Offset: 0x1305570 VA: 0x181306B70
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13067A0 Offset: 0x13051A0 VA: 0x1813067A0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306460 Offset: 0x1304E60 VA: 0x181306460
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306820 Offset: 0x1305220 VA: 0x181306820
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306920 Offset: 0x1305320 VA: 0x181306920
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306320 Offset: 0x1304D20 VA: 0x181306320
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13068F0 Offset: 0x13052F0 VA: 0x1813068F0
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13067E0 Offset: 0x13051E0 VA: 0x1813067E0
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306400 Offset: 0x1304E00 VA: 0x181306400
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306880 Offset: 0x1305280 VA: 0x181306880
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13064E0 Offset: 0x1304EE0 VA: 0x1813064E0
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13066E0 Offset: 0x13050E0 VA: 0x1813066E0
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13064B0 Offset: 0x1304EB0 VA: 0x1813064B0
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306CE0 Offset: 0x13056E0 VA: 0x181306CE0
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306C60 Offset: 0x1305660 VA: 0x181306C60
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306F10 Offset: 0x1305910 VA: 0x181306F10
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306A50 Offset: 0x1305450 VA: 0x181306A50
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306430 Offset: 0x1304E30 VA: 0x181306430
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306B40 Offset: 0x1305540 VA: 0x181306B40
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306170 Offset: 0x1304B70 VA: 0x181306170
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13060F0 Offset: 0x1304AF0 VA: 0x1813060F0
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13062D0 Offset: 0x1304CD0 VA: 0x1813062D0
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13068C0 Offset: 0x13052C0 VA: 0x1813068C0
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13060B0 Offset: 0x1304AB0 VA: 0x1813060B0
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13061A0 Offset: 0x1304BA0 VA: 0x1813061A0
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306510 Offset: 0x1304F10 VA: 0x181306510
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306AF0 Offset: 0x13054F0 VA: 0x181306AF0
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306360 Offset: 0x1304D60 VA: 0x181306360
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x13063B0 Offset: 0x1304DB0 VA: 0x1813063B0
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306AA0 Offset: 0x13054A0 VA: 0x181306AA0
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306BE0 Offset: 0x13055E0 VA: 0x181306BE0
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306E70 Offset: 0x1305870 VA: 0x181306E70
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306C10 Offset: 0x1305610 VA: 0x181306C10
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306E20 Offset: 0x1305820 VA: 0x181306E20
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306D40 Offset: 0x1305740 VA: 0x181306D40
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1306960 Offset: 0x1305360 VA: 0x181306960
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x1315880 Offset: 0x1314280 VA: 0x181315880
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B70 Offset: 0x12F2570 VA: 0x1812F3B70
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, double>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, long>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6FB0 Offset: 0x12F59B0 VA: 0x1812F6FB0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6ED0 Offset: 0x12F58D0 VA: 0x1812F6ED0
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6DE0 Offset: 0x12F57E0 VA: 0x1812F6DE0
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, uint>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6E50 Offset: 0x12F5850 VA: 0x1812F6E50
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6F40 Offset: 0x12F5940 VA: 0x1812F6F40
	|-Dictionary.ValueCollection<int, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F7310 Offset: 0x12F5D10 VA: 0x1812F7310
	|-Dictionary.ValueCollection<int, short>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F72A0 Offset: 0x12F5CA0 VA: 0x1812F72A0
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F7220 Offset: 0x12F5C20 VA: 0x1812F7220
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F7140 Offset: 0x12F5B40 VA: 0x1812F7140
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F6D60 Offset: 0x12F5760 VA: 0x1812F6D60
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x12F7060 Offset: 0x12F5A60 VA: 0x1812F7060
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x1306F40 Offset: 0x1305940 VA: 0x181306F40
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x13072A0 Offset: 0x1305CA0 VA: 0x1813072A0
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x1307070 Offset: 0x1305A70 VA: 0x181307070
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x13073B0 Offset: 0x1305DB0 VA: 0x1813073B0
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x1306FD0 Offset: 0x13059D0 VA: 0x181306FD0
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x1307170 Offset: 0x1305B70 VA: 0x181307170
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3B70 Offset: 0x12F2570 VA: 0x1812F3B70
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, double>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6FB0 Offset: 0x12F59B0 VA: 0x1812F6FB0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6ED0 Offset: 0x12F58D0 VA: 0x1812F6ED0
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6DE0 Offset: 0x12F57E0 VA: 0x1812F6DE0
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6E50 Offset: 0x12F5850 VA: 0x1812F6E50
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6F40 Offset: 0x12F5940 VA: 0x1812F6F40
	|-Dictionary.ValueCollection<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F7310 Offset: 0x12F5D10 VA: 0x1812F7310
	|-Dictionary.ValueCollection<int, short>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F72A0 Offset: 0x12F5CA0 VA: 0x1812F72A0
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F7220 Offset: 0x12F5C20 VA: 0x1812F7220
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F7140 Offset: 0x12F5B40 VA: 0x1812F7140
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F6D60 Offset: 0x12F5760 VA: 0x1812F6D60
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12F7060 Offset: 0x12F5A60 VA: 0x1812F7060
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1306F40 Offset: 0x1305940 VA: 0x181306F40
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13072A0 Offset: 0x1305CA0 VA: 0x1813072A0
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1307070 Offset: 0x1305A70 VA: 0x181307070
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13073B0 Offset: 0x1305DB0 VA: 0x1813073B0
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1306FD0 Offset: 0x13059D0 VA: 0x181306FD0
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1307170 Offset: 0x1305B70 VA: 0x181307170
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3BE0 Offset: 0x12F25E0 VA: 0x1812F3BE0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE660 Offset: 0x12FD060 VA: 0x1812FE660
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FBDE0 Offset: 0x12FA7E0 VA: 0x1812FBDE0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FDC80 Offset: 0x12FC680 VA: 0x1812FDC80
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC530 Offset: 0x12FAF30 VA: 0x1812FC530
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13028F0 Offset: 0x13012F0 VA: 0x1813028F0
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FA670 Offset: 0x12F9070 VA: 0x1812FA670
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FDFC0 Offset: 0x12FC9C0 VA: 0x1812FDFC0
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD2C0 Offset: 0x12FBCC0 VA: 0x1812FD2C0
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F9FF0 Offset: 0x12F89F0 VA: 0x1812F9FF0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8FA0 Offset: 0x12F79A0 VA: 0x1812F8FA0
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD600 Offset: 0x12FC000 VA: 0x1812FD600
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13007F0 Offset: 0x12FF1F0 VA: 0x1813007F0
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC870 Offset: 0x12FB270 VA: 0x1812FC870
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FB3B0 Offset: 0x12F9DB0 VA: 0x1812FB3B0
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7380 Offset: 0x12F5D80 VA: 0x1812F7380
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF430 Offset: 0x12FDE30 VA: 0x1812FF430
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7A40 Offset: 0x12F6440 VA: 0x1812F7A40
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8170 Offset: 0x12F6B70 VA: 0x1812F8170
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FEDB0 Offset: 0x12FD7B0 VA: 0x1812FEDB0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301F30 Offset: 0x1300930 VA: 0x181301F30
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F9960 Offset: 0x12F8360 VA: 0x1812F9960
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FBAA0 Offset: 0x12FA4A0 VA: 0x1812FBAA0
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302270 Offset: 0x1300C70 VA: 0x181302270
	|-Dictionary.ValueCollection<int, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE300 Offset: 0x12FCD00 VA: 0x1812FE300
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301BF0 Offset: 0x13005F0 VA: 0x181301BF0
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1302C30 Offset: 0x1301630 VA: 0x181302C30
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FFDF0 Offset: 0x12FE7F0 VA: 0x1812FFDF0
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F9620 Offset: 0x12F8020 VA: 0x1812F9620
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300B30 Offset: 0x12FF530 VA: 0x181300B30
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FB070 Offset: 0x12F9A70 VA: 0x1812FB070
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1301520 Offset: 0x12FFF20 VA: 0x181301520
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8850 Offset: 0x12F7250 VA: 0x1812F8850
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF0F0 Offset: 0x12FDAF0 VA: 0x1812FF0F0
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FA9F0 Offset: 0x12F93F0 VA: 0x1812FA9F0
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13011C0 Offset: 0x12FFBC0 VA: 0x1813011C0
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F9CA0 Offset: 0x12F86A0 VA: 0x1812F9CA0
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300E80 Offset: 0x12FF880 VA: 0x181300E80
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FCBB0 Offset: 0x12FB5B0 VA: 0x1812FCBB0
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F76C0 Offset: 0x12F60C0 VA: 0x1812F76C0
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FE9A0 Offset: 0x12FD3A0 VA: 0x1812FE9A0
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FCF10 Offset: 0x12FB910 VA: 0x1812FCF10
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FB6F0 Offset: 0x12FA0F0 VA: 0x1812FB6F0
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FD940 Offset: 0x12FC340 VA: 0x1812FD940
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FFAB0 Offset: 0x12FE4B0 VA: 0x1812FFAB0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F92E0 Offset: 0x12F7CE0 VA: 0x1812F92E0
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FA330 Offset: 0x12F8D30 VA: 0x1812FA330
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F8B90 Offset: 0x12F7590 VA: 0x1812F8B90
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300130 Offset: 0x12FEB30 VA: 0x181300130
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13025B0 Offset: 0x1300FB0 VA: 0x1813025B0
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F7DF0 Offset: 0x12F67F0 VA: 0x1812F7DF0
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FAD30 Offset: 0x12F9730 VA: 0x1812FAD30
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12F84D0 Offset: 0x12F6ED0 VA: 0x1812F84D0
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13018A0 Offset: 0x13002A0 VA: 0x1813018A0
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FC1B0 Offset: 0x12FABB0 VA: 0x1812FC1B0
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1300470 Offset: 0x12FEE70 VA: 0x181300470
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x12FF770 Offset: 0x12FE170 VA: 0x1812FF770
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13107B0 Offset: 0x130F1B0 VA: 0x1813107B0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130AC80 Offset: 0x1309680 VA: 0x18130AC80
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130CAE0 Offset: 0x130B4E0 VA: 0x18130CAE0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130BDA0 Offset: 0x130A7A0 VA: 0x18130BDA0
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309160 Offset: 0x1307B60 VA: 0x181309160
	|-Dictionary.ValueCollection<object, double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1312C60 Offset: 0x1311660 VA: 0x181312C60
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F380 Offset: 0x130DD80 VA: 0x18130F380
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1311530 Offset: 0x130FF30 VA: 0x181311530
	|-Dictionary.ValueCollection<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130D8F0 Offset: 0x130C2F0 VA: 0x18130D8F0
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1310460 Offset: 0x130EE60 VA: 0x181310460
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13083E0 Offset: 0x1306DE0 VA: 0x1813083E0
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F6C0 Offset: 0x130E0C0 VA: 0x18130F6C0
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130DC30 Offset: 0x130C630 VA: 0x18130DC30
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1308DE0 Offset: 0x13077E0 VA: 0x181308DE0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C0E0 Offset: 0x130AAE0 VA: 0x18130C0E0
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130CE30 Offset: 0x130B830 VA: 0x18130CE30
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B720 Offset: 0x130A120 VA: 0x18130B720
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13100E0 Offset: 0x130EAE0 VA: 0x1813100E0
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13125E0 Offset: 0x1310FE0 VA: 0x1813125E0
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1312FA0 Offset: 0x13119A0 VA: 0x181312FA0
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130FDA0 Offset: 0x130E7A0 VA: 0x18130FDA0
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130D1B0 Offset: 0x130BBB0 VA: 0x18130D1B0
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1311190 Offset: 0x130FB90 VA: 0x181311190
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A600 Offset: 0x1309000 VA: 0x18130A600
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309B80 Offset: 0x1308580 VA: 0x181309B80
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130BA60 Offset: 0x130A460 VA: 0x18130BA60
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1310B10 Offset: 0x130F510 VA: 0x181310B10
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130F020 Offset: 0x130DA20 VA: 0x18130F020
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13094A0 Offset: 0x1307EA0 VA: 0x1813094A0
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A290 Offset: 0x1308C90 VA: 0x18130A290
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13122A0 Offset: 0x1310CA0 VA: 0x1813122A0
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130E2E0 Offset: 0x130CCE0 VA: 0x18130E2E0
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130A940 Offset: 0x1309340 VA: 0x18130A940
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13077D0 Offset: 0x13061D0 VA: 0x1813077D0
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1307480 Offset: 0x1305E80 VA: 0x181307480
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1310E50 Offset: 0x130F850 VA: 0x181310E50
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1311870 Offset: 0x1310270 VA: 0x181311870
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130ECC0 Offset: 0x130D6C0 VA: 0x18130ECC0
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130DF80 Offset: 0x130C980 VA: 0x18130DF80
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309F30 Offset: 0x1308930 VA: 0x181309F30
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1309820 Offset: 0x1308220 VA: 0x181309820
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130E620 Offset: 0x130D020 VA: 0x18130E620
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130D5B0 Offset: 0x130BFB0 VA: 0x18130D5B0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1308760 Offset: 0x1307160 VA: 0x181308760
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C760 Offset: 0x130B160 VA: 0x18130C760
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130C420 Offset: 0x130AE20 VA: 0x18130C420
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B360 Offset: 0x1309D60 VA: 0x18130B360
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1312920 Offset: 0x1311320 VA: 0x181312920
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130FA40 Offset: 0x130E440 VA: 0x18130FA40
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1308AA0 Offset: 0x13074A0 VA: 0x181308AA0
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1311F20 Offset: 0x1310920 VA: 0x181311F20
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1311BF0 Offset: 0x13105F0 VA: 0x181311BF0
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130E980 Offset: 0x130D380 VA: 0x18130E980
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130B020 Offset: 0x1309A20 VA: 0x18130B020
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13158B0 Offset: 0x13142B0 VA: 0x1813158B0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1315BF0 Offset: 0x13145F0 VA: 0x181315BF0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1315F30 Offset: 0x1314930 VA: 0x181315F30
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, short>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, double>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3F20 Offset: 0x12F2920 VA: 0x1812F3F20
	|-Dictionary.ValueCollection<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13037E0 Offset: 0x13021E0 VA: 0x1813037E0
	|-Dictionary.ValueCollection<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13030B0 Offset: 0x1301AB0 VA: 0x1813030B0
	|-Dictionary.ValueCollection<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303650 Offset: 0x1302050 VA: 0x181303650
	|-Dictionary.ValueCollection<ValueTuple<object, int>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303740 Offset: 0x1302140 VA: 0x181303740
	|-Dictionary.ValueCollection<ValueTuple<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303EC0 Offset: 0x13028C0 VA: 0x181303EC0
	|-Dictionary.ValueCollection<Bounds, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303D80 Offset: 0x1302780 VA: 0x181303D80
	|-Dictionary.ValueCollection<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13036F0 Offset: 0x13020F0 VA: 0x1813036F0
	|-Dictionary.ValueCollection<CSteamID, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1302FC0 Offset: 0x13019C0 VA: 0x181302FC0
	|-Dictionary.ValueCollection<FullRank, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13038D0 Offset: 0x13022D0 VA: 0x1813038D0
	|-Dictionary.ValueCollection<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303D30 Offset: 0x1302730 VA: 0x181303D30
	|-Dictionary.ValueCollection<HSteamNetConnection, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303510 Offset: 0x1301F10 VA: 0x181303510
	|-Dictionary.ValueCollection<Hash128, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303560 Offset: 0x1301F60 VA: 0x181303560
	|-Dictionary.ValueCollection<Hash128, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303970 Offset: 0x1302370 VA: 0x181303970
	|-Dictionary.ValueCollection<Int2, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303C90 Offset: 0x1302690 VA: 0x181303C90
	|-Dictionary.ValueCollection<Int2, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13036A0 Offset: 0x13020A0 VA: 0x1813036A0
	|-Dictionary.ValueCollection<Int3, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303290 Offset: 0x1301C90 VA: 0x181303290
	|-Dictionary.ValueCollection<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303600 Offset: 0x1302000 VA: 0x181303600
	|-Dictionary.ValueCollection<int, TreeViewItemData<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303A10 Offset: 0x1302410 VA: 0x181303A10
	|-Dictionary.ValueCollection<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13031F0 Offset: 0x1301BF0 VA: 0x1813031F0
	|-Dictionary.ValueCollection<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303A60 Offset: 0x1302460 VA: 0x181303A60
	|-Dictionary.ValueCollection<int, ByteEnum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303330 Offset: 0x1301D30 VA: 0x181303330
	|-Dictionary.ValueCollection<int, CSteamID>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303420 Offset: 0x1301E20 VA: 0x181303420
	|-Dictionary.ValueCollection<int, HSteamNetConnection>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303100 Offset: 0x1301B00 VA: 0x181303100
	|-Dictionary.ValueCollection<int, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13039C0 Offset: 0x13023C0 VA: 0x1813039C0
	|-Dictionary.ValueCollection<int, Int3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303BF0 Offset: 0x13025F0 VA: 0x181303BF0
	|-Dictionary.ValueCollection<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303FB0 Offset: 0x13029B0 VA: 0x181303FB0
	|-Dictionary.ValueCollection<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13035B0 Offset: 0x1301FB0 VA: 0x1813035B0
	|-Dictionary.ValueCollection<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1304000 Offset: 0x1302A00 VA: 0x181304000
	|-Dictionary.ValueCollection<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303C40 Offset: 0x1302640 VA: 0x181303C40
	|-Dictionary.ValueCollection<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303E70 Offset: 0x1302870 VA: 0x181303E70
	|-Dictionary.ValueCollection<int, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303830 Offset: 0x1302230 VA: 0x181303830
	|-Dictionary.ValueCollection<int, TreeItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1302F70 Offset: 0x1301970 VA: 0x181302F70
	|-Dictionary.ValueCollection<int, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13040A0 Offset: 0x1302AA0 VA: 0x1813040A0
	|-Dictionary.ValueCollection<int, ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303B50 Offset: 0x1302550 VA: 0x181303B50
	|-Dictionary.ValueCollection<int, Vector2Int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303CE0 Offset: 0x13026E0 VA: 0x181303CE0
	|-Dictionary.ValueCollection<int, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303240 Offset: 0x1301C40 VA: 0x181303240
	|-Dictionary.ValueCollection<int, Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303B00 Offset: 0x1302500 VA: 0x181303B00
	|-Dictionary.ValueCollection<int, Multipass.TransportIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303380 Offset: 0x1301D80 VA: 0x181303380
	|-Dictionary.ValueCollection<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303DD0 Offset: 0x13027D0 VA: 0x181303DD0
	|-Dictionary.ValueCollection<int, NetworkAnimator.StateChange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303150 Offset: 0x1301B50 VA: 0x181303150
	|-Dictionary.ValueCollection<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303880 Offset: 0x1302280 VA: 0x181303880
	|-Dictionary.ValueCollection<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303920 Offset: 0x1302320 VA: 0x181303920
	|-Dictionary.ValueCollection<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303060 Offset: 0x1301A60 VA: 0x181303060
	|-Dictionary.ValueCollection<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13032E0 Offset: 0x1301CE0 VA: 0x1813032E0
	|-Dictionary.ValueCollection<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303F60 Offset: 0x1302960 VA: 0x181303F60
	|-Dictionary.ValueCollection<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303AB0 Offset: 0x13024B0 VA: 0x181303AB0
	|-Dictionary.ValueCollection<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1304050 Offset: 0x1302A50 VA: 0x181304050
	|-Dictionary.ValueCollection<long, ComputedStyle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303470 Offset: 0x1301E70 VA: 0x181303470
	|-Dictionary.ValueCollection<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303BA0 Offset: 0x13025A0 VA: 0x181303BA0
	|-Dictionary.ValueCollection<IntPtr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303E20 Offset: 0x1302820 VA: 0x181303E20
	|-Dictionary.ValueCollection<InternedString, InternedString>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13033D0 Offset: 0x1301DD0 VA: 0x1813033D0
	|-Dictionary.ValueCollection<InternedString, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13031A0 Offset: 0x1301BA0 VA: 0x1813031A0
	|-Dictionary.ValueCollection<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303010 Offset: 0x1301A10 VA: 0x181303010
	|-Dictionary.ValueCollection<NativeAddr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303F10 Offset: 0x1302910 VA: 0x181303F10
	|-Dictionary.ValueCollection<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13034C0 Offset: 0x1301EC0 VA: 0x1813034C0
	|-Dictionary.ValueCollection<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1303790 Offset: 0x1302190 VA: 0x181303790
	|-Dictionary.ValueCollection<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13143E0 Offset: 0x1312DE0 VA: 0x1813143E0
	|-Dictionary.ValueCollection<object, Bounds>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313A30 Offset: 0x1312430 VA: 0x181313A30
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313EE0 Offset: 0x13128E0 VA: 0x181313EE0
	|-Dictionary.ValueCollection<object, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313400 Offset: 0x1311E00 VA: 0x181313400
	|-Dictionary.ValueCollection<object, Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313680 Offset: 0x1312080 VA: 0x181313680
	|-Dictionary.ValueCollection<object, double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313D50 Offset: 0x1312750 VA: 0x181313D50
	|-Dictionary.ValueCollection<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313590 Offset: 0x1311F90 VA: 0x181313590
	|-Dictionary.ValueCollection<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13135E0 Offset: 0x1311FE0 VA: 0x1813135E0
	|-Dictionary.ValueCollection<object, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313E90 Offset: 0x1312890 VA: 0x181313E90
	|-Dictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13144D0 Offset: 0x1312ED0 VA: 0x1813144D0
	|-Dictionary.ValueCollection<object, Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313940 Offset: 0x1312340 VA: 0x181313940
	|-Dictionary.ValueCollection<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313720 Offset: 0x1312120 VA: 0x181313720
	|-Dictionary.ValueCollection<object, RaycastHit>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313D00 Offset: 0x1312700 VA: 0x181313D00
	|-Dictionary.ValueCollection<object, Rect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313AD0 Offset: 0x13124D0 VA: 0x181313AD0
	|-Dictionary.ValueCollection<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313630 Offset: 0x1312030 VA: 0x181313630
	|-Dictionary.ValueCollection<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13138F0 Offset: 0x13122F0 VA: 0x1813138F0
	|-Dictionary.ValueCollection<object, StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313770 Offset: 0x1312170 VA: 0x181313770
	|-Dictionary.ValueCollection<object, TextureId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313F30 Offset: 0x1312930 VA: 0x181313F30
	|-Dictionary.ValueCollection<object, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313FD0 Offset: 0x13129D0 VA: 0x181313FD0
	|-Dictionary.ValueCollection<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13134A0 Offset: 0x1311EA0 VA: 0x1813134A0
	|-Dictionary.ValueCollection<object, InputControlLayout.ControlItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13141B0 Offset: 0x1312BB0 VA: 0x1813141B0
	|-Dictionary.ValueCollection<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314110 Offset: 0x1312B10 VA: 0x181314110
	|-Dictionary.ValueCollection<object, JsonParser.JsonValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314570 Offset: 0x1312F70 VA: 0x181314570
	|-Dictionary.ValueCollection<object, LiquidVolume.MeshCache>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314430 Offset: 0x1312E30 VA: 0x181314430
	|-Dictionary.ValueCollection<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313C10 Offset: 0x1312610 VA: 0x181313C10
	|-Dictionary.ValueCollection<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313BC0 Offset: 0x13125C0 VA: 0x181313BC0
	|-Dictionary.ValueCollection<object, SVGDocument.ClipData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13145C0 Offset: 0x1312FC0 VA: 0x1813145C0
	|-Dictionary.ValueCollection<object, SVGDocument.MaskData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314480 Offset: 0x1312E80 VA: 0x181314480
	|-Dictionary.ValueCollection<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13140C0 Offset: 0x1312AC0 VA: 0x1813140C0
	|-Dictionary.ValueCollection<object, SVGDocument.PatternData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314390 Offset: 0x1312D90 VA: 0x181314390
	|-Dictionary.ValueCollection<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314250 Offset: 0x1312C50 VA: 0x181314250
	|-Dictionary.ValueCollection<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314070 Offset: 0x1312A70 VA: 0x181314070
	|-Dictionary.ValueCollection<Scene, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313B20 Offset: 0x1312520 VA: 0x181313B20
	|-Dictionary.ValueCollection<TerrainTileCoord, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313CB0 Offset: 0x13126B0 VA: 0x181313CB0
	|-Dictionary.ValueCollection<ushort, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13142A0 Offset: 0x1312CA0 VA: 0x1813142A0
	|-Dictionary.ValueCollection<ushort, RpcLink>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313DF0 Offset: 0x13127F0 VA: 0x181313DF0
	|-Dictionary.ValueCollection<ushort, ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313C60 Offset: 0x1312660 VA: 0x181313C60
	|-Dictionary.ValueCollection<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314020 Offset: 0x1312A20 VA: 0x181314020
	|-Dictionary.ValueCollection<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314610 Offset: 0x1313010 VA: 0x181314610
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313F80 Offset: 0x1312980 VA: 0x181313F80
	|-Dictionary.ValueCollection<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13134F0 Offset: 0x1311EF0 VA: 0x1813134F0
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314520 Offset: 0x1312F20 VA: 0x181314520
	|-Dictionary.ValueCollection<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13142F0 Offset: 0x1312CF0 VA: 0x1813142F0
	|-Dictionary.ValueCollection<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314200 Offset: 0x1312C00 VA: 0x181314200
	|-Dictionary.ValueCollection<uint, RpcLinkType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314340 Offset: 0x1312D40 VA: 0x181314340
	|-Dictionary.ValueCollection<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13138A0 Offset: 0x13122A0 VA: 0x1813138A0
	|-Dictionary.ValueCollection<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13136D0 Offset: 0x13120D0 VA: 0x1813136D0
	|-Dictionary.ValueCollection<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313B70 Offset: 0x1312570 VA: 0x181313B70
	|-Dictionary.ValueCollection<Vector2Int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313E40 Offset: 0x1312840 VA: 0x181313E40
	|-Dictionary.ValueCollection<Vector3, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313450 Offset: 0x1311E50 VA: 0x181313450
	|-Dictionary.ValueCollection<Vector3Int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313A80 Offset: 0x1312480 VA: 0x181313A80
	|-Dictionary.ValueCollection<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313540 Offset: 0x1311F40 VA: 0x181313540
	|-Dictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1313DA0 Offset: 0x13127A0 VA: 0x181313DA0
	|-Dictionary.ValueCollection<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1314160 Offset: 0x1312B60 VA: 0x181314160
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1316270 Offset: 0x1314C70 VA: 0x181316270
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13162C0 Offset: 0x1314CC0 VA: 0x1813162C0
	|-Dictionary.ValueCollection<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1316310 Offset: 0x1314D10 VA: 0x181316310
	|-Dictionary.ValueCollection<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_SyncRoot
	*/
}
