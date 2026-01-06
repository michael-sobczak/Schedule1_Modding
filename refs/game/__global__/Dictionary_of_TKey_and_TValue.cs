public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback // TypeDefIndex: 4967
{
	// Fields
	private int[] _buckets; // 0x0
	private Dictionary.Entry<TKey, TValue>[] _entries; // 0x0
	private int _count; // 0x0
	private int _freeList; // 0x0
	private int _freeCount; // 0x0
	private int _version; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private Dictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private Dictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private object _syncRoot; // 0x0
	private const string VersionName = "Version";
	private const string HashSizeName = "HashSize";
	private const string KeyValuePairsName = "KeyValuePairs";
	private const string ComparerName = "Comparer";

	// Properties
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; set; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FB340 Offset: 0x14F9D40 VA: 0x1814FB340
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FB420 Offset: 0x14F9E20 VA: 0x1814FB420
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FC500 Offset: 0x14FAF00 VA: 0x1814FC500
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FB3A0 Offset: 0x14F9DA0 VA: 0x1814FB3A0
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FC4A0 Offset: 0x14FAEA0 VA: 0x1814FC4A0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x1511160 Offset: 0x150FB60 VA: 0x181511160
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x1511770 Offset: 0x1510170 VA: 0x181511770
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x1511010 Offset: 0x150FA10 VA: 0x181511010
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x150F790 Offset: 0x150E190 VA: 0x18150F790
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x150FDD0 Offset: 0x150E7D0 VA: 0x18150FDD0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150F240 Offset: 0x150DC40 VA: 0x18150F240
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x1511C40 Offset: 0x1510640 VA: 0x181511C40
	|-Dictionary<Hash128, int>..ctor
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x15254D0 Offset: 0x1523ED0 VA: 0x1815254D0
	|-Dictionary<Int2, int>..ctor
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x1525A90 Offset: 0x1524490 VA: 0x181525A90
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1523850 Offset: 0x1522250 VA: 0x181523850
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|-Dictionary<int, bool>..ctor
	|-Dictionary<int, ByteEnum>..ctor
	|-Dictionary<int, CSteamID>..ctor
	|-Dictionary<int, HSteamNetConnection>..ctor
	|-Dictionary<int, short>..ctor
	|-Dictionary<int, Int3>..ctor
	|-Dictionary<int, int>..ctor
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, long>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|-Dictionary<int, float>..ctor
	|-Dictionary<int, TreeItem>..ctor
	|-Dictionary<int, uint>..ctor
	|-Dictionary<int, ulong>..ctor
	|-Dictionary<int, Vector2Int>..ctor
	|-Dictionary<int, Vector3>..ctor
	|-Dictionary<int, Vector4>..ctor
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1566E80 Offset: 0x1565880 VA: 0x181566E80
	|-Dictionary<Int32Enum, bool>..ctor
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157AF10 Offset: 0x1579910 VA: 0x18157AF10
	|-Dictionary<long, ComputedStyle>..ctor
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157B140 Offset: 0x1579B40 VA: 0x18157B140
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157C320 Offset: 0x157AD20 VA: 0x18157C320
	|-Dictionary<InternedString, InternedString>..ctor
	|-Dictionary<InternedString, object>..ctor
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157B5E0 Offset: 0x1579FE0 VA: 0x18157B5E0
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A2380 Offset: 0x15A0D80 VA: 0x1815A2380
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|-Dictionary<object, bool>..ctor
	|-Dictionary<object, Bounds>..ctor
	|-Dictionary<object, Color>..ctor
	|-Dictionary<object, Color>..ctor
	|-Dictionary<object, Color32>..ctor
	|-Dictionary<object, double>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<object, long>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<object, Playable>..ctor
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|-Dictionary<object, RaycastHit>..ctor
	|-Dictionary<object, Rect>..ctor
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<object, float>..ctor
	|-Dictionary<object, StylePropertyValue>..ctor
	|-Dictionary<object, TextureId>..ctor
	|-Dictionary<object, XPathNodeRef>..ctor
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E5D00 Offset: 0x15E4700 VA: 0x1815E5D00
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FB300 Offset: 0x15F9D00 VA: 0x1815FB300
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15FA6E0 Offset: 0x15F90E0 VA: 0x1815FA6E0
	|-Dictionary<ushort, object>..ctor
	|-Dictionary<ushort, RpcLink>..ctor
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15F9B90 Offset: 0x15F8590 VA: 0x1815F9B90
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, int>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, RpcLinkType>..ctor
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160CA70 Offset: 0x160B470 VA: 0x18160CA70
	|-Dictionary<ulong, object>..ctor
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1625780 Offset: 0x1624180 VA: 0x181625780
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x1623180 Offset: 0x1621B80 VA: 0x181623180
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1625620 Offset: 0x1624020 VA: 0x181625620
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x1625D50 Offset: 0x1624750 VA: 0x181625D50
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1624930 Offset: 0x1623330 VA: 0x181624930
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x16237F0 Offset: 0x16221F0 VA: 0x1816237F0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162F150 Offset: 0x162DB50 VA: 0x18162F150
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x1630760 Offset: 0x162F160 VA: 0x181630760
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FC620 Offset: 0x14FB020 VA: 0x1814FC620
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FC7B0 Offset: 0x14FB1B0 VA: 0x1814FC7B0
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FC3C0 Offset: 0x14FADC0 VA: 0x1814FC3C0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FBDD0 Offset: 0x14FA7D0 VA: 0x1814FBDD0
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FC3E0 Offset: 0x14FADE0 VA: 0x1814FC3E0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x1511730 Offset: 0x1510130 VA: 0x181511730
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x1510D70 Offset: 0x150F770 VA: 0x181510D70
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x1511090 Offset: 0x150FA90 VA: 0x181511090
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x150F8F0 Offset: 0x150E2F0 VA: 0x18150F8F0
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x15110B0 Offset: 0x150FAB0 VA: 0x1815110B0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150F9C0 Offset: 0x150E3C0 VA: 0x18150F9C0
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x150F910 Offset: 0x150E310 VA: 0x18150F910
	|-Dictionary<Hash128, int>..ctor
	|
	|-RVA: 0x1525470 Offset: 0x1523E70 VA: 0x181525470
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x1523D60 Offset: 0x1522760 VA: 0x181523D60
	|-Dictionary<Int2, int>..ctor
	|
	|-RVA: 0x1525370 Offset: 0x1523D70 VA: 0x181525370
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x1524950 Offset: 0x1523350 VA: 0x181524950
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x15237C0 Offset: 0x15221C0 VA: 0x1815237C0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1524EF0 Offset: 0x15238F0 VA: 0x181524EF0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1524F10 Offset: 0x1523910 VA: 0x181524F10
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|
	|-RVA: 0x1533B50 Offset: 0x1532550 VA: 0x181533B50
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1535060 Offset: 0x1533A60 VA: 0x181535060
	|-Dictionary<int, ByteEnum>..ctor
	|
	|-RVA: 0x1533C00 Offset: 0x1532600 VA: 0x181533C00
	|-Dictionary<int, CSteamID>..ctor
	|
	|-RVA: 0x15341E0 Offset: 0x1532BE0 VA: 0x1815341E0
	|-Dictionary<int, HSteamNetConnection>..ctor
	|
	|-RVA: 0x1533E00 Offset: 0x1532800 VA: 0x181533E00
	|-Dictionary<int, short>..ctor
	|
	|-RVA: 0x1533A90 Offset: 0x1532490 VA: 0x181533A90
	|-Dictionary<int, Int3>..ctor
	|
	|-RVA: 0x1535040 Offset: 0x1533A40 VA: 0x181535040
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1545070 Offset: 0x1543A70 VA: 0x181545070
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1544F20 Offset: 0x1543920 VA: 0x181544F20
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1544E70 Offset: 0x1543870 VA: 0x181544E70
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x1546910 Offset: 0x1545310 VA: 0x181546910
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x15451B0 Offset: 0x1543BB0 VA: 0x1815451B0
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x1544990 Offset: 0x1543390 VA: 0x181544990
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x15460D0 Offset: 0x1544AD0 VA: 0x1815460D0
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x15552D0 Offset: 0x1553CD0 VA: 0x1815552D0
	|-Dictionary<int, ulong>..ctor
	|
	|-RVA: 0x1555A80 Offset: 0x1554480 VA: 0x181555A80
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x1555E90 Offset: 0x1554890 VA: 0x181555E90
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x15551F0 Offset: 0x1553BF0 VA: 0x1815551F0
	|-Dictionary<int, Vector4>..ctor
	|
	|-RVA: 0x1555690 Offset: 0x1554090 VA: 0x181555690
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|
	|-RVA: 0x1555210 Offset: 0x1553C10 VA: 0x181555210
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|
	|-RVA: 0x15548A0 Offset: 0x15532A0 VA: 0x1815548A0
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x15679B0 Offset: 0x15663B0 VA: 0x1815679B0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x1567900 Offset: 0x1566300 VA: 0x181567900
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x15674D0 Offset: 0x1565ED0 VA: 0x1815674D0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x15665F0 Offset: 0x1564FF0 VA: 0x1815665F0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x1567F20 Offset: 0x1566920 VA: 0x181567F20
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x15683C0 Offset: 0x1566DC0 VA: 0x1815683C0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1568B80 Offset: 0x1567580 VA: 0x181568B80
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157AB20 Offset: 0x1579520 VA: 0x18157AB20
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x157C9F0 Offset: 0x157B3F0 VA: 0x18157C9F0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157C2E0 Offset: 0x157ACE0 VA: 0x18157C2E0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157BCE0 Offset: 0x157A6E0 VA: 0x18157BCE0
	|-Dictionary<InternedString, InternedString>..ctor
	|
	|-RVA: 0x157C9B0 Offset: 0x157B3B0 VA: 0x18157C9B0
	|-Dictionary<InternedString, object>..ctor
	|
	|-RVA: 0x157B5C0 Offset: 0x1579FC0 VA: 0x18157B5C0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157B010 Offset: 0x1579A10 VA: 0x18157B010
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A46D0 Offset: 0x15A30D0 VA: 0x1815A46D0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x15A2490 Offset: 0x15A0E90 VA: 0x1815A2490
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x15A23E0 Offset: 0x15A0DE0 VA: 0x1815A23E0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x15A3D00 Offset: 0x15A2700 VA: 0x1815A3D00
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x15A2A00 Offset: 0x15A1400 VA: 0x1815A2A00
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A2F80 Offset: 0x15A1980 VA: 0x1815A2F80
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A47C0 Offset: 0x15A31C0 VA: 0x1815A47C0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x15B4770 Offset: 0x15B3170 VA: 0x1815B4770
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x15B30F0 Offset: 0x15B1AF0 VA: 0x1815B30F0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x15B41A0 Offset: 0x15B2BA0 VA: 0x1815B41A0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x15B3040 Offset: 0x15B1A40 VA: 0x1815B3040
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x15B54D0 Offset: 0x15B3ED0 VA: 0x1815B54D0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x15B4180 Offset: 0x15B2B80 VA: 0x1815B4180
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x15B5590 Offset: 0x15B3F90 VA: 0x1815B5590
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x15C4560 Offset: 0x15C2F60 VA: 0x1815C4560
	|-Dictionary<object, RaycastHit>..ctor
	|
	|-RVA: 0x15C35F0 Offset: 0x15C1FF0 VA: 0x1815C35F0
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x15C46A0 Offset: 0x15C30A0 VA: 0x1815C46A0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x15C46C0 Offset: 0x15C30C0 VA: 0x1815C46C0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x15C2FD0 Offset: 0x15C19D0 VA: 0x1815C2FD0
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x15C3B70 Offset: 0x15C2570 VA: 0x1815C3B70
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x15C4770 Offset: 0x15C3170 VA: 0x1815C4770
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x15D4D00 Offset: 0x15D3700 VA: 0x1815D4D00
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x15D70A0 Offset: 0x15D5AA0 VA: 0x1815D70A0
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x15D6750 Offset: 0x15D5150 VA: 0x1815D6750
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|
	|-RVA: 0x15D6340 Offset: 0x15D4D40 VA: 0x1815D6340
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x15D4E50 Offset: 0x15D3850 VA: 0x1815D4E50
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x15D4CE0 Offset: 0x15D36E0 VA: 0x1815D4CE0
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|
	|-RVA: 0x15D6320 Offset: 0x15D4D20 VA: 0x1815D6320
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x15E5D60 Offset: 0x15E4760 VA: 0x1815E5D60
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x15E5ED0 Offset: 0x15E48D0 VA: 0x1815E5ED0
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x15E6C10 Offset: 0x15E5610 VA: 0x1815E6C10
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x15E5E10 Offset: 0x15E4810 VA: 0x1815E5E10
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x15E6BD0 Offset: 0x15E55D0 VA: 0x1815E6BD0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x15E7190 Offset: 0x15E5B90 VA: 0x1815E7190
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E6BF0 Offset: 0x15E55F0 VA: 0x1815E6BF0
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FA6C0 Offset: 0x15F90C0 VA: 0x1815FA6C0
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15F9CA0 Offset: 0x15F86A0 VA: 0x1815F9CA0
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x15FB4A0 Offset: 0x15F9EA0 VA: 0x1815FB4A0
	|-Dictionary<ushort, RpcLink>..ctor
	|
	|-RVA: 0x15FA1B0 Offset: 0x15F8BB0 VA: 0x1815FA1B0
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15FB3F0 Offset: 0x15F9DF0 VA: 0x1815FB3F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x15FAE20 Offset: 0x15F9820 VA: 0x1815FAE20
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x15FA190 Offset: 0x15F8B90 VA: 0x1815FA190
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160C9C0 Offset: 0x160B3C0 VA: 0x18160C9C0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160D6F0 Offset: 0x160C0F0 VA: 0x18160D6F0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160E0B0 Offset: 0x160CAB0 VA: 0x18160E0B0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BA40 Offset: 0x160A440 VA: 0x18160BA40
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x160DFA0 Offset: 0x160C9A0 VA: 0x18160DFA0
	|-Dictionary<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x160DFE0 Offset: 0x160C9E0 VA: 0x18160DFE0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160DFC0 Offset: 0x160C9C0 VA: 0x18160DFC0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x16253D0 Offset: 0x1623DD0 VA: 0x1816253D0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1623E40 Offset: 0x1622840 VA: 0x181623E40
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x1625920 Offset: 0x1624320 VA: 0x181625920
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1625DB0 Offset: 0x16247B0 VA: 0x181625DB0
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x1623310 Offset: 0x1621D10 VA: 0x181623310
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1625590 Offset: 0x1623F90 VA: 0x181625590
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1624DE0 Offset: 0x16237E0 VA: 0x181624DE0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162F780 Offset: 0x162E180 VA: 0x18162F780
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x162F8C0 Offset: 0x162E2C0 VA: 0x18162F8C0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x1630740 Offset: 0x162F140 VA: 0x181630740
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x1630330 Offset: 0x162ED30 VA: 0x181630330
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FB530 Offset: 0x14F9F30 VA: 0x1814FB530
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FAC80 Offset: 0x14F9680 VA: 0x1814FAC80
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FC2C0 Offset: 0x14FACC0 VA: 0x1814FC2C0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FC6D0 Offset: 0x14FB0D0 VA: 0x1814FC6D0
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FC740 Offset: 0x14FB140 VA: 0x1814FC740
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x1510760 Offset: 0x150F160 VA: 0x181510760
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x150F1D0 Offset: 0x150DBD0 VA: 0x18150F1D0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x15107D0 Offset: 0x150F1D0 VA: 0x1815107D0
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x150F7F0 Offset: 0x150E1F0 VA: 0x18150F7F0
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x150F930 Offset: 0x150E330 VA: 0x18150F930
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150F160 Offset: 0x150DB60 VA: 0x18150F160
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x15116C0 Offset: 0x15100C0 VA: 0x1815116C0
	|-Dictionary<Hash128, int>..ctor
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x1525300 Offset: 0x1523D00 VA: 0x181525300
	|-Dictionary<Int2, int>..ctor
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x15237E0 Offset: 0x15221E0 VA: 0x1815237E0
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1524300 Offset: 0x1522D00 VA: 0x181524300
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|-Dictionary<int, bool>..ctor
	|-Dictionary<int, ByteEnum>..ctor
	|-Dictionary<int, CSteamID>..ctor
	|-Dictionary<int, HSteamNetConnection>..ctor
	|-Dictionary<int, short>..ctor
	|-Dictionary<int, Int3>..ctor
	|-Dictionary<int, int>..ctor
	|-Dictionary<int, Int32Enum>..ctor
	|-Dictionary<int, long>..ctor
	|-Dictionary<int, object>..ctor
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|-Dictionary<int, float>..ctor
	|-Dictionary<int, TreeItem>..ctor
	|-Dictionary<int, uint>..ctor
	|-Dictionary<int, ulong>..ctor
	|-Dictionary<int, Vector2Int>..ctor
	|-Dictionary<int, Vector3>..ctor
	|-Dictionary<int, Vector4>..ctor
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1567590 Offset: 0x1565F90 VA: 0x181567590
	|-Dictionary<Int32Enum, bool>..ctor
	|-Dictionary<Int32Enum, int>..ctor
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157B780 Offset: 0x157A180 VA: 0x18157B780
	|-Dictionary<long, ComputedStyle>..ctor
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157B7F0 Offset: 0x157A1F0 VA: 0x18157B7F0
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157AAB0 Offset: 0x15794B0 VA: 0x18157AAB0
	|-Dictionary<InternedString, InternedString>..ctor
	|-Dictionary<InternedString, object>..ctor
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157B030 Offset: 0x1579A30 VA: 0x18157B030
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A2400 Offset: 0x15A0E00 VA: 0x1815A2400
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|-Dictionary<object, bool>..ctor
	|-Dictionary<object, Bounds>..ctor
	|-Dictionary<object, Color>..ctor
	|-Dictionary<object, Color>..ctor
	|-Dictionary<object, Color32>..ctor
	|-Dictionary<object, double>..ctor
	|-Dictionary<object, int>..ctor
	|-Dictionary<object, Int32Enum>..ctor
	|-Dictionary<object, long>..ctor
	|-Dictionary<object, object>..ctor
	|-Dictionary<object, Playable>..ctor
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|-Dictionary<object, RaycastHit>..ctor
	|-Dictionary<object, Rect>..ctor
	|-Dictionary<object, ResourceLocator>..ctor
	|-Dictionary<object, float>..ctor
	|-Dictionary<object, StylePropertyValue>..ctor
	|-Dictionary<object, TextureId>..ctor
	|-Dictionary<object, XPathNodeRef>..ctor
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E6060 Offset: 0x15E4A60 VA: 0x1815E6060
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FB4C0 Offset: 0x15F9EC0 VA: 0x1815FB4C0
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15FA9B0 Offset: 0x15F93B0 VA: 0x1815FA9B0
	|-Dictionary<ushort, object>..ctor
	|-Dictionary<ushort, RpcLink>..ctor
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15F9C30 Offset: 0x15F8630 VA: 0x1815F9C30
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|-Dictionary<uint, int>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|-Dictionary<uint, object>..ctor
	|-Dictionary<uint, RpcLinkType>..ctor
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160C070 Offset: 0x160AA70 VA: 0x18160C070
	|-Dictionary<ulong, object>..ctor
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1625340 Offset: 0x1623D40 VA: 0x181625340
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x16255B0 Offset: 0x1623FB0 VA: 0x1816255B0
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1625680 Offset: 0x1624080 VA: 0x181625680
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x1625480 Offset: 0x1623E80 VA: 0x181625480
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1623330 Offset: 0x1621D30 VA: 0x181623330
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1623350 Offset: 0x1621D50 VA: 0x181623350
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162F1B0 Offset: 0x162DBB0 VA: 0x18162F1B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x162F850 Offset: 0x162E250 VA: 0x18162F850
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FC580 Offset: 0x14FAF80 VA: 0x1814FC580
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FAE20 Offset: 0x14F9820 VA: 0x1814FAE20
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FBE30 Offset: 0x14FA830 VA: 0x1814FBE30
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FC400 Offset: 0x14FAE00 VA: 0x1814FC400
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FACF0 Offset: 0x14F96F0 VA: 0x1814FACF0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x1511600 Offset: 0x1510000 VA: 0x181511600
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x1510CD0 Offset: 0x150F6D0 VA: 0x181510CD0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x1511BA0 Offset: 0x15105A0 VA: 0x181511BA0
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x1510F70 Offset: 0x150F970 VA: 0x181510F70
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x1510ED0 Offset: 0x150F8D0 VA: 0x181510ED0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150F6F0 Offset: 0x150E0F0 VA: 0x18150F6F0
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x1510840 Offset: 0x150F240 VA: 0x181510840
	|-Dictionary<Hash128, int>..ctor
	|
	|-RVA: 0x1523720 Offset: 0x1522120 VA: 0x181523720
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x15253D0 Offset: 0x1523DD0 VA: 0x1815253D0
	|-Dictionary<Int2, int>..ctor
	|
	|-RVA: 0x15248B0 Offset: 0x15232B0 VA: 0x1815248B0
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x1523CC0 Offset: 0x15226C0 VA: 0x181523CC0
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1524780 Offset: 0x1523180 VA: 0x181524780
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1525950 Offset: 0x1524350 VA: 0x181525950
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x15259F0 Offset: 0x15243F0 VA: 0x1815259F0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|
	|-RVA: 0x1535450 Offset: 0x1533E50 VA: 0x181535450
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1533AB0 Offset: 0x15324B0 VA: 0x181533AB0
	|-Dictionary<int, ByteEnum>..ctor
	|
	|-RVA: 0x1534FA0 Offset: 0x15339A0 VA: 0x181534FA0
	|-Dictionary<int, CSteamID>..ctor
	|
	|-RVA: 0x15358B0 Offset: 0x15342B0 VA: 0x1815358B0
	|-Dictionary<int, HSteamNetConnection>..ctor
	|
	|-RVA: 0x1534F00 Offset: 0x1533900 VA: 0x181534F00
	|-Dictionary<int, short>..ctor
	|
	|-RVA: 0x1535970 Offset: 0x1534370 VA: 0x181535970
	|-Dictionary<int, Int3>..ctor
	|
	|-RVA: 0x1533CB0 Offset: 0x15326B0 VA: 0x181533CB0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1544FD0 Offset: 0x15439D0 VA: 0x181544FD0
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1545C30 Offset: 0x1544630 VA: 0x181545C30
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1544830 Offset: 0x1543230 VA: 0x181544830
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x15460F0 Offset: 0x1544AF0 VA: 0x1815460F0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x1545710 Offset: 0x1544110 VA: 0x181545710
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x15448F0 Offset: 0x15432F0 VA: 0x1815448F0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x1544DD0 Offset: 0x15437D0 VA: 0x181544DD0
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x1554800 Offset: 0x1553200 VA: 0x181554800
	|-Dictionary<int, ulong>..ctor
	|
	|-RVA: 0x1555EF0 Offset: 0x15548F0 VA: 0x181555EF0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x1555550 Offset: 0x1553F50 VA: 0x181555550
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x1555230 Offset: 0x1553C30 VA: 0x181555230
	|-Dictionary<int, Vector4>..ctor
	|
	|-RVA: 0x1555F90 Offset: 0x1554990 VA: 0x181555F90
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|
	|-RVA: 0x15555F0 Offset: 0x1553FF0 VA: 0x1815555F0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|
	|-RVA: 0x1554330 Offset: 0x1552D30 VA: 0x181554330
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x1567600 Offset: 0x1566000 VA: 0x181567600
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x15677D0 Offset: 0x15661D0 VA: 0x1815677D0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1568BC0 Offset: 0x15675C0 VA: 0x181568BC0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1567430 Offset: 0x1565E30 VA: 0x181567430
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x1567730 Offset: 0x1566130 VA: 0x181567730
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x15679D0 Offset: 0x15663D0 VA: 0x1815679D0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x15674F0 Offset: 0x1565EF0 VA: 0x1815674F0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157B0A0 Offset: 0x1579AA0 VA: 0x18157B0A0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x157B640 Offset: 0x157A040 VA: 0x18157B640
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157AA10 Offset: 0x1579410 VA: 0x18157AA10
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157B6E0 Offset: 0x157A0E0 VA: 0x18157B6E0
	|-Dictionary<InternedString, InternedString>..ctor
	|
	|-RVA: 0x157C3C0 Offset: 0x157ADC0 VA: 0x18157C3C0
	|-Dictionary<InternedString, object>..ctor
	|
	|-RVA: 0x157C240 Offset: 0x157AC40 VA: 0x18157C240
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157AF70 Offset: 0x1579970 VA: 0x18157AF70
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A4590 Offset: 0x15A2F90 VA: 0x1815A4590
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x15A24B0 Offset: 0x15A0EB0 VA: 0x1815A24B0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x15A4630 Offset: 0x15A3030 VA: 0x1815A4630
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x15A3890 Offset: 0x15A2290 VA: 0x1815A3890
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x15A2FC0 Offset: 0x15A19C0 VA: 0x1815A2FC0
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A44F0 Offset: 0x15A2EF0 VA: 0x1815A44F0
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A2250 Offset: 0x15A0C50 VA: 0x1815A2250
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x15B3760 Offset: 0x15B2160 VA: 0x1815B3760
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x15B3C60 Offset: 0x15B2660 VA: 0x1815B3C60
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x15B4C30 Offset: 0x15B3630 VA: 0x1815B4C30
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x15B3590 Offset: 0x15B1F90 VA: 0x1815B3590
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x15B54F0 Offset: 0x15B3EF0 VA: 0x1815B54F0
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x15B4B90 Offset: 0x15B3590 VA: 0x1815B4B90
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x15B36C0 Offset: 0x15B20C0 VA: 0x1815B36C0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x15C3A90 Offset: 0x15C2490 VA: 0x1815C3A90
	|-Dictionary<object, RaycastHit>..ctor
	|
	|-RVA: 0x15C3490 Offset: 0x15C1E90 VA: 0x1815C3490
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x15C5010 Offset: 0x15C3A10 VA: 0x1815C5010
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x15C40C0 Offset: 0x15C2AC0 VA: 0x1815C40C0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x15C33F0 Offset: 0x15C1DF0 VA: 0x1815C33F0
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x15C3F90 Offset: 0x15C2990 VA: 0x1815C3F90
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x15C3530 Offset: 0x15C1F30 VA: 0x1815C3530
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x15D4D20 Offset: 0x15D3720 VA: 0x1815D4D20
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x15D6C90 Offset: 0x15D5690 VA: 0x1815D6C90
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x15D6F10 Offset: 0x15D5910 VA: 0x1815D6F10
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|
	|-RVA: 0x15D5940 Offset: 0x15D4340 VA: 0x1815D5940
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x15D6B60 Offset: 0x15D5560 VA: 0x1815D6B60
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x15D52B0 Offset: 0x15D3CB0 VA: 0x1815D52B0
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|
	|-RVA: 0x15D6D30 Offset: 0x15D5730 VA: 0x1815D6D30
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x15E6930 Offset: 0x15E5330 VA: 0x1815E6930
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x15E6C30 Offset: 0x15E5630 VA: 0x1815E6C30
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x15E64C0 Offset: 0x15E4EC0 VA: 0x1815E64C0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x15E5E30 Offset: 0x15E4830 VA: 0x1815E5E30
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x15E6A60 Offset: 0x15E5460 VA: 0x1815E6A60
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x15E71B0 Offset: 0x15E5BB0 VA: 0x1815E71B0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E5F80 Offset: 0x15E4980 VA: 0x1815E5F80
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FA740 Offset: 0x15F9140 VA: 0x1815FA740
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15FB260 Offset: 0x15F9C60 VA: 0x1815FB260
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x15FB9A0 Offset: 0x15FA3A0 VA: 0x1815FB9A0
	|-Dictionary<ushort, RpcLink>..ctor
	|
	|-RVA: 0x15FBF00 Offset: 0x15FA900 VA: 0x1815FBF00
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15FBE60 Offset: 0x15FA860 VA: 0x1815FBE60
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x15FA1D0 Offset: 0x15F8BD0 VA: 0x1815FA1D0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x15FB530 Offset: 0x15F9F30 VA: 0x1815FB530
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160D520 Offset: 0x160BF20 VA: 0x18160D520
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160CF70 Offset: 0x160B970 VA: 0x18160CF70
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160DB30 Offset: 0x160C530 VA: 0x18160DB30
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160D650 Offset: 0x160C050 VA: 0x18160D650
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x160CED0 Offset: 0x160B8D0 VA: 0x18160CED0
	|-Dictionary<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x160D010 Offset: 0x160BA10 VA: 0x18160D010
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160D480 Offset: 0x160BE80 VA: 0x18160D480
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x16254F0 Offset: 0x1623EF0 VA: 0x1816254F0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1623270 Offset: 0x1621C70 VA: 0x181623270
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x1623870 Offset: 0x1622270 VA: 0x181623870
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1624E20 Offset: 0x1623820 VA: 0x181624E20
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x16257E0 Offset: 0x16241E0 VA: 0x1816257E0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1625880 Offset: 0x1624280 VA: 0x181625880
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1623DA0 Offset: 0x16227A0 VA: 0x181623DA0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162FE10 Offset: 0x162E810 VA: 0x18162FE10
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x162F8E0 Offset: 0x162E2E0 VA: 0x18162F8E0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x162FD50 Offset: 0x162E750 VA: 0x18162FD50
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x162F220 Offset: 0x162DC20 VA: 0x18162F220
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FB510 Offset: 0x14F9F10 VA: 0x1814FB510
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FB400 Offset: 0x14F9E00 VA: 0x1814FB400
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FBDF0 Offset: 0x14FA7F0 VA: 0x1814FBDF0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FBE10 Offset: 0x14FA810 VA: 0x1814FBE10
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FC560 Offset: 0x14FAF60 VA: 0x1814FC560
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x1510E20 Offset: 0x150F820 VA: 0x181510E20
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x150F9A0 Offset: 0x150E3A0 VA: 0x18150F9A0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x15115E0 Offset: 0x150FFE0 VA: 0x1815115E0
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x15116A0 Offset: 0x15100A0 VA: 0x1815116A0
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x15111C0 Offset: 0x150FBC0 VA: 0x1815111C0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x1511750 Offset: 0x1510150 VA: 0x181511750
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x1511070 Offset: 0x150FA70 VA: 0x181511070
	|-Dictionary<Hash128, int>..ctor
	|
	|-RVA: 0x15253B0 Offset: 0x1523DB0 VA: 0x1815253B0
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x1523310 Offset: 0x1521D10 VA: 0x181523310
	|-Dictionary<Int2, int>..ctor
	|
	|-RVA: 0x15254B0 Offset: 0x1523EB0 VA: 0x1815254B0
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x15232F0 Offset: 0x1521CF0 VA: 0x1815232F0
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1525390 Offset: 0x1523D90 VA: 0x181525390
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1524760 Offset: 0x1523160 VA: 0x181524760
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1525490 Offset: 0x1523E90 VA: 0x181525490
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|
	|-RVA: 0x1535AC0 Offset: 0x15344C0 VA: 0x181535AC0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1534200 Offset: 0x1532C00 VA: 0x181534200
	|-Dictionary<int, ByteEnum>..ctor
	|
	|-RVA: 0x15342B0 Offset: 0x1532CB0 VA: 0x1815342B0
	|-Dictionary<int, CSteamID>..ctor
	|
	|-RVA: 0x1533D50 Offset: 0x1532750 VA: 0x181533D50
	|-Dictionary<int, HSteamNetConnection>..ctor
	|
	|-RVA: 0x1535A10 Offset: 0x1534410 VA: 0x181535A10
	|-Dictionary<int, short>..ctor
	|
	|-RVA: 0x1535950 Offset: 0x1534350 VA: 0x181535950
	|-Dictionary<int, Int3>..ctor
	|
	|-RVA: 0x1534EE0 Offset: 0x15338E0 VA: 0x181534EE0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1546930 Offset: 0x1545330 VA: 0x181546930
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x15451D0 Offset: 0x1543BD0 VA: 0x1815451D0
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1545210 Offset: 0x1543C10 VA: 0x181545210
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x15451F0 Offset: 0x1543BF0 VA: 0x1815451F0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x1545840 Offset: 0x1544240 VA: 0x181545840
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x1544DB0 Offset: 0x15437B0 VA: 0x181544DB0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x15448D0 Offset: 0x15432D0 VA: 0x1815448D0
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x1555EB0 Offset: 0x15548B0 VA: 0x181555EB0
	|-Dictionary<int, ulong>..ctor
	|
	|-RVA: 0x1555ED0 Offset: 0x15548D0 VA: 0x181555ED0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x1554310 Offset: 0x1552D10 VA: 0x181554310
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x1554CC0 Offset: 0x15536C0 VA: 0x181554CC0
	|-Dictionary<int, Vector4>..ctor
	|
	|-RVA: 0x1555410 Offset: 0x1553E10 VA: 0x181555410
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|
	|-RVA: 0x1555E70 Offset: 0x1554870 VA: 0x181555E70
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|
	|-RVA: 0x1555140 Offset: 0x1553B40 VA: 0x181555140
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x1566F00 Offset: 0x1565900 VA: 0x181566F00
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x15683A0 Offset: 0x1566DA0 VA: 0x1815683A0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1566EE0 Offset: 0x15658E0 VA: 0x181566EE0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1568BA0 Offset: 0x15675A0 VA: 0x181568BA0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x1567410 Offset: 0x1565E10 VA: 0x181567410
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1568C60 Offset: 0x1567660 VA: 0x181568C60
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x15687A0 Offset: 0x15671A0 VA: 0x1815687A0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157C3A0 Offset: 0x157ADA0 VA: 0x18157C3A0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x157C4F0 Offset: 0x157AEF0 VA: 0x18157C4F0
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157C380 Offset: 0x157AD80 VA: 0x18157C380
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157C9D0 Offset: 0x157B3D0 VA: 0x18157C9D0
	|-Dictionary<InternedString, InternedString>..ctor
	|
	|-RVA: 0x157B1A0 Offset: 0x1579BA0 VA: 0x18157B1A0
	|-Dictionary<InternedString, object>..ctor
	|
	|-RVA: 0x157C300 Offset: 0x157AD00 VA: 0x18157C300
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157C990 Offset: 0x157B390 VA: 0x18157C990
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A4710 Offset: 0x15A3110 VA: 0x1815A4710
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x15A2A20 Offset: 0x15A1420 VA: 0x1815A2A20
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x15A46F0 Offset: 0x15A30F0 VA: 0x1815A46F0
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x15A4870 Offset: 0x15A3270 VA: 0x1815A4870
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x15A2FA0 Offset: 0x15A19A0 VA: 0x1815A2FA0
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A2470 Offset: 0x15A0E70 VA: 0x1815A2470
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A4920 Offset: 0x15A3320 VA: 0x1815A4920
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x15B4CD0 Offset: 0x15B36D0 VA: 0x1815B4CD0
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x15B54B0 Offset: 0x15B3EB0 VA: 0x1815B54B0
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x15B3110 Offset: 0x15B1B10 VA: 0x1815B3110
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x15B4610 Offset: 0x15B3010 VA: 0x1815B4610
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x15B4160 Offset: 0x15B2B60 VA: 0x1815B4160
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x15B5490 Offset: 0x15B3E90 VA: 0x1815B5490
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x15B46C0 Offset: 0x15B30C0 VA: 0x1815B46C0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x15C3A70 Offset: 0x15C2470 VA: 0x1815C3A70
	|-Dictionary<object, RaycastHit>..ctor
	|
	|-RVA: 0x15C35D0 Offset: 0x15C1FD0 VA: 0x1815C35D0
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x15C50B0 Offset: 0x15C3AB0 VA: 0x1815C50B0
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x15C4790 Offset: 0x15C3190 VA: 0x1815C4790
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x15C3B50 Offset: 0x15C2550 VA: 0x1815C3B50
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x15C2FB0 Offset: 0x15C19B0 VA: 0x1815C2FB0
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x15C3B30 Offset: 0x15C2530 VA: 0x1815C3B30
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x15D5290 Offset: 0x15D3C90 VA: 0x1815D5290
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x15D6FD0 Offset: 0x15D59D0 VA: 0x1815D6FD0
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x15D6FF0 Offset: 0x15D59F0 VA: 0x1815D6FF0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|
	|-RVA: 0x15D6DD0 Offset: 0x15D57D0 VA: 0x1815D6DD0
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x15D6FB0 Offset: 0x15D59B0 VA: 0x1815D6FB0
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x15D6B40 Offset: 0x15D5540 VA: 0x1815D6B40
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|
	|-RVA: 0x15D6360 Offset: 0x15D4D60 VA: 0x1815D6360
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x15E6040 Offset: 0x15E4A40 VA: 0x1815E6040
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x15E6CD0 Offset: 0x15E56D0 VA: 0x1815E6CD0
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x15E6D80 Offset: 0x15E5780 VA: 0x1815E6D80
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x15E6020 Offset: 0x15E4A20 VA: 0x1815E6020
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x15E6B20 Offset: 0x15E5520 VA: 0x1815E6B20
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x15E6B00 Offset: 0x15E5500 VA: 0x1815E6B00
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E60D0 Offset: 0x15E4AD0 VA: 0x1815E60D0
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FA900 Offset: 0x15F9300 VA: 0x1815FA900
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15FAA40 Offset: 0x15F9440 VA: 0x1815FAA40
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x15FAA20 Offset: 0x15F9420 VA: 0x1815FAA20
	|-Dictionary<ushort, RpcLink>..ctor
	|
	|-RVA: 0x15F97A0 Offset: 0x15F81A0 VA: 0x1815F97A0
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15FBE40 Offset: 0x15FA840 VA: 0x1815FBE40
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x15F9C10 Offset: 0x15F8610 VA: 0x1815F9C10
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x15F9BF0 Offset: 0x15F85F0 VA: 0x1815F9BF0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160C120 Offset: 0x160AB20 VA: 0x18160C120
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BC30 Offset: 0x160A630 VA: 0x18160BC30
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BAF0 Offset: 0x160A4F0 VA: 0x18160BAF0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160C100 Offset: 0x160AB00 VA: 0x18160C100
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x160E0D0 Offset: 0x160CAD0 VA: 0x18160E0D0
	|-Dictionary<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x160C0E0 Offset: 0x160AAE0 VA: 0x18160C0E0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160E090 Offset: 0x160CA90 VA: 0x18160E090
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x1625D10 Offset: 0x1624710 VA: 0x181625D10
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x16230D0 Offset: 0x1621AD0 VA: 0x1816230D0
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x16253B0 Offset: 0x1623DB0 VA: 0x1816253B0
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1623E60 Offset: 0x1622860 VA: 0x181623E60
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x1625D30 Offset: 0x1624730 VA: 0x181625D30
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x1623850 Offset: 0x1622250 VA: 0x181623850
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1624E00 Offset: 0x1623800 VA: 0x181624E00
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162F830 Offset: 0x162E230 VA: 0x18162F830
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x162F370 Offset: 0x162DD70 VA: 0x18162F370
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x162FDF0 Offset: 0x162E7F0 VA: 0x18162FDF0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x162F2C0 Offset: 0x162DCC0 VA: 0x18162F2C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FAF50 Offset: 0x14F9950 VA: 0x1814FAF50
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FA890 Offset: 0x14F9290 VA: 0x1814FA890
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FB5A0 Offset: 0x14F9FA0 VA: 0x1814FB5A0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FB9E0 Offset: 0x14FA3E0 VA: 0x1814FB9E0
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FBED0 Offset: 0x14FA8D0 VA: 0x1814FBED0
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x15111E0 Offset: 0x150FBE0 VA: 0x1815111E0
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x1510320 Offset: 0x150ED20 VA: 0x181510320
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x150FF50 Offset: 0x150E950 VA: 0x18150FF50
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x15117D0 Offset: 0x15101D0 VA: 0x1815117D0
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x15108E0 Offset: 0x150F2E0 VA: 0x1815108E0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150F330 Offset: 0x150DD30 VA: 0x18150F330
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x150F9E0 Offset: 0x150E3E0 VA: 0x18150F9E0
	|-Dictionary<Hash128, int>..ctor
	|
	|-RVA: 0x1523330 Offset: 0x1521D30 VA: 0x181523330
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x1524F30 Offset: 0x1523930 VA: 0x181524F30
	|-Dictionary<Int2, int>..ctor
	|
	|-RVA: 0x1523D80 Offset: 0x1522780 VA: 0x181523D80
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x1524370 Offset: 0x1522D70 VA: 0x181524370
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1524B20 Offset: 0x1523520 VA: 0x181524B20
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x15238B0 Offset: 0x15222B0 VA: 0x1815238B0
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1525530 Offset: 0x1523F30 VA: 0x181525530
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|
	|-RVA: 0x15354F0 Offset: 0x1533EF0 VA: 0x1815354F0
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1534760 Offset: 0x1533160 VA: 0x181534760
	|-Dictionary<int, ByteEnum>..ctor
	|
	|-RVA: 0x1535080 Offset: 0x1533A80 VA: 0x181535080
	|-Dictionary<int, CSteamID>..ctor
	|
	|-RVA: 0x1533E20 Offset: 0x1532820 VA: 0x181533E20
	|-Dictionary<int, HSteamNetConnection>..ctor
	|
	|-RVA: 0x1534B20 Offset: 0x1533520 VA: 0x181534B20
	|-Dictionary<int, short>..ctor
	|
	|-RVA: 0x15342D0 Offset: 0x1532CD0 VA: 0x1815342D0
	|-Dictionary<int, Int3>..ctor
	|
	|-RVA: 0x1535AE0 Offset: 0x15344E0 VA: 0x181535AE0
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1545230 Offset: 0x1543C30 VA: 0x181545230
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1546950 Offset: 0x1545350 VA: 0x181546950
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1545860 Offset: 0x1544260 VA: 0x181545860
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x15449B0 Offset: 0x15433B0 VA: 0x1815449B0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x1546550 Offset: 0x1544F50 VA: 0x181546550
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x1545CD0 Offset: 0x15446D0 VA: 0x181545CD0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x1546190 Offset: 0x1544B90 VA: 0x181546190
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x1554D70 Offset: 0x1553770 VA: 0x181554D70
	|-Dictionary<int, ulong>..ctor
	|
	|-RVA: 0x1555AA0 Offset: 0x15544A0 VA: 0x181555AA0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x15548C0 Offset: 0x15532C0 VA: 0x1815548C0
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x15564B0 Offset: 0x1554EB0 VA: 0x1815564B0
	|-Dictionary<int, Vector4>..ctor
	|
	|-RVA: 0x15556B0 Offset: 0x15540B0 VA: 0x1815556B0
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|
	|-RVA: 0x15560C0 Offset: 0x1554AC0 VA: 0x1815560C0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|
	|-RVA: 0x15543D0 Offset: 0x1552DD0 VA: 0x1815543D0
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x1566F20 Offset: 0x1565920 VA: 0x181566F20
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x1566A60 Offset: 0x1565460 VA: 0x181566A60
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1567B00 Offset: 0x1566500 VA: 0x181567B00
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x15666A0 Offset: 0x15650A0 VA: 0x1815666A0
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x15687C0 Offset: 0x15671C0 VA: 0x1815687C0
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x15683E0 Offset: 0x1566DE0 VA: 0x1815683E0
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1567FD0 Offset: 0x15669D0 VA: 0x181567FD0
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157BD90 Offset: 0x157A790 VA: 0x18157BD90
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x157CA10 Offset: 0x157B410 VA: 0x18157CA10
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157AB40 Offset: 0x1579540 VA: 0x18157AB40
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157C5A0 Offset: 0x157AFA0 VA: 0x18157C5A0
	|-Dictionary<InternedString, InternedString>..ctor
	|
	|-RVA: 0x157A620 Offset: 0x1579020 VA: 0x18157A620
	|-Dictionary<InternedString, object>..ctor
	|
	|-RVA: 0x157B860 Offset: 0x157A260 VA: 0x18157B860
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157B1C0 Offset: 0x1579BC0 VA: 0x18157B1C0
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A3490 Offset: 0x15A1E90 VA: 0x1815A3490
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x15A3060 Offset: 0x15A1A60 VA: 0x1815A3060
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x15A4120 Offset: 0x15A2B20 VA: 0x1815A4120
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x15A25E0 Offset: 0x15A0FE0 VA: 0x1815A25E0
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x15A2B60 Offset: 0x15A1560 VA: 0x1815A2B60
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A3D20 Offset: 0x15A2720 VA: 0x1815A3D20
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A3930 Offset: 0x15A2330 VA: 0x1815A3930
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x15B4CF0 Offset: 0x15B36F0 VA: 0x1815B4CF0
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x15B3800 Offset: 0x15B2200 VA: 0x1815B3800
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x15B50C0 Offset: 0x15B3AC0 VA: 0x1815B50C0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x15B31C0 Offset: 0x15B1BC0 VA: 0x1815B31C0
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x15B3D00 Offset: 0x15B2700 VA: 0x1815B3D00
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x15B4790 Offset: 0x15B3190 VA: 0x1815B4790
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x15B41C0 Offset: 0x15B2BC0 VA: 0x1815B41C0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x15C50D0 Offset: 0x15C3AD0 VA: 0x1815C50D0
	|-Dictionary<object, RaycastHit>..ctor
	|
	|-RVA: 0x15C4160 Offset: 0x15C2B60 VA: 0x1815C4160
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x15C3B90 Offset: 0x15C2590 VA: 0x1815C3B90
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x15C47B0 Offset: 0x15C31B0 VA: 0x1815C47B0
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x15C2FF0 Offset: 0x15C19F0 VA: 0x1815C2FF0
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x15C36A0 Offset: 0x15C20A0 VA: 0x1815C36A0
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x15C4C10 Offset: 0x15C3610 VA: 0x1815C4C10
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x15D6380 Offset: 0x15D4D80 VA: 0x1815D6380
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x15D5350 Offset: 0x15D3D50 VA: 0x1815D5350
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x15D70C0 Offset: 0x15D5AC0 VA: 0x1815D70C0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|
	|-RVA: 0x15D59E0 Offset: 0x15D43E0 VA: 0x1815D59E0
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x15D4E70 Offset: 0x15D3870 VA: 0x1815D4E70
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x15D6770 Offset: 0x15D5170 VA: 0x1815D6770
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|
	|-RVA: 0x15D5F00 Offset: 0x15D4900 VA: 0x1815D5F00
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x15E7620 Offset: 0x15E6020 VA: 0x1815E7620
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x15E7250 Offset: 0x15E5C50 VA: 0x1815E7250
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x15E6DA0 Offset: 0x15E57A0 VA: 0x1815E6DA0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x15E7A80 Offset: 0x15E6480 VA: 0x1815E7A80
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x15E5850 Offset: 0x15E4250 VA: 0x1815E5850
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x15E6560 Offset: 0x15E4F60 VA: 0x1815E6560
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E60F0 Offset: 0x15E4AF0 VA: 0x1815E60F0
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FB5D0 Offset: 0x15F9FD0 VA: 0x1815FB5D0
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15F97C0 Offset: 0x15F81C0 VA: 0x1815F97C0
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x15FBA40 Offset: 0x15FA440 VA: 0x1815FBA40
	|-Dictionary<ushort, RpcLink>..ctor
	|
	|-RVA: 0x15FAA60 Offset: 0x15F9460 VA: 0x1815FAA60
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15F9CC0 Offset: 0x15F86C0 VA: 0x1815F9CC0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x15FA270 Offset: 0x15F8C70 VA: 0x1815FA270
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x15FAE40 Offset: 0x15F9840 VA: 0x1815FAE40
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160D710 Offset: 0x160C110 VA: 0x18160D710
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BC50 Offset: 0x160A650 VA: 0x18160BC50
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160C5A0 Offset: 0x160AFA0 VA: 0x18160C5A0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160DBD0 Offset: 0x160C5D0 VA: 0x18160DBD0
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x160D0B0 Offset: 0x160BAB0 VA: 0x18160D0B0
	|-Dictionary<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x160CAD0 Offset: 0x160B4D0 VA: 0x18160CAD0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160C1D0 Offset: 0x160ABD0 VA: 0x18160C1D0
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x16233C0 Offset: 0x1621DC0 VA: 0x1816233C0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x1625940 Offset: 0x1624340 VA: 0x181625940
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x1623E80 Offset: 0x1622880 VA: 0x181623E80
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1624950 Offset: 0x1623350 VA: 0x181624950
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x1624EC0 Offset: 0x16238C0 VA: 0x181624EC0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x16242C0 Offset: 0x1622CC0 VA: 0x1816242C0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x16239A0 Offset: 0x16223A0 VA: 0x1816239A0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x162FEB0 Offset: 0x162E8B0 VA: 0x18162FEB0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x1630350 Offset: 0x162ED50 VA: 0x181630350
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x162F390 Offset: 0x162DD90 VA: 0x18162F390
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x162F980 Offset: 0x162E380 VA: 0x18162F980
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FC640 Offset: 0x14FB040 VA: 0x1814FC640
	|-Dictionary<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x14FAEC0 Offset: 0x14F98C0 VA: 0x1814FAEC0
	|-Dictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14FC330 Offset: 0x14FAD30 VA: 0x1814FC330
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>..ctor
	|
	|-RVA: 0x14FB480 Offset: 0x14F9E80 VA: 0x1814FB480
	|-Dictionary<ValueTuple<object, int>, object>..ctor
	|
	|-RVA: 0x14FAD90 Offset: 0x14F9790 VA: 0x1814FAD90
	|-Dictionary<ValueTuple<object, object>, object>..ctor
	|
	|-RVA: 0x150F2A0 Offset: 0x150DCA0 VA: 0x18150F2A0
	|-Dictionary<Bounds, object>..ctor
	|
	|-RVA: 0x1510D90 Offset: 0x150F790 VA: 0x181510D90
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>..ctor
	|
	|-RVA: 0x1510E40 Offset: 0x150F840 VA: 0x181510E40
	|-Dictionary<CSteamID, int>..ctor
	|
	|-RVA: 0x150F860 Offset: 0x150E260 VA: 0x18150F860
	|-Dictionary<FullRank, object>..ctor
	|
	|-RVA: 0x15110D0 Offset: 0x150FAD0 VA: 0x1815110D0
	|-Dictionary<Guid, object>..ctor
	|
	|-RVA: 0x150FEC0 Offset: 0x150E8C0 VA: 0x18150FEC0
	|-Dictionary<HSteamNetConnection, int>..ctor
	|
	|-RVA: 0x150FE30 Offset: 0x150E830 VA: 0x18150FE30
	|-Dictionary<Hash128, int>..ctor
	|
	|-RVA: 0x1524270 Offset: 0x1522C70 VA: 0x181524270
	|-Dictionary<Hash128, object>..ctor
	|
	|-RVA: 0x15241E0 Offset: 0x1522BE0 VA: 0x1815241E0
	|-Dictionary<Int2, int>..ctor
	|
	|-RVA: 0x1524970 Offset: 0x1523370 VA: 0x181524970
	|-Dictionary<Int2, object>..ctor
	|
	|-RVA: 0x1524820 Offset: 0x1523220 VA: 0x181524820
	|-Dictionary<Int3, int>..ctor
	|
	|-RVA: 0x1524A90 Offset: 0x1523490 VA: 0x181524A90
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|
	|-RVA: 0x1524A00 Offset: 0x1523400 VA: 0x181524A00
	|-Dictionary<int, TreeViewItemData<object>>..ctor
	|
	|-RVA: 0x1524150 Offset: 0x1522B50 VA: 0x181524150
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>..ctor
	|
	|-RVA: 0x1533D70 Offset: 0x1532770 VA: 0x181533D70
	|-Dictionary<int, bool>..ctor
	|
	|-RVA: 0x1533C20 Offset: 0x1532620 VA: 0x181533C20
	|-Dictionary<int, ByteEnum>..ctor
	|
	|-RVA: 0x1534220 Offset: 0x1532C20 VA: 0x181534220
	|-Dictionary<int, CSteamID>..ctor
	|
	|-RVA: 0x15346D0 Offset: 0x15330D0 VA: 0x1815346D0
	|-Dictionary<int, HSteamNetConnection>..ctor
	|
	|-RVA: 0x1535EA0 Offset: 0x15348A0 VA: 0x181535EA0
	|-Dictionary<int, short>..ctor
	|
	|-RVA: 0x1533B70 Offset: 0x1532570 VA: 0x181533B70
	|-Dictionary<int, Int3>..ctor
	|
	|-RVA: 0x1535A30 Offset: 0x1534430 VA: 0x181535A30
	|-Dictionary<int, int>..ctor
	|
	|-RVA: 0x1545680 Offset: 0x1544080 VA: 0x181545680
	|-Dictionary<int, Int32Enum>..ctor
	|
	|-RVA: 0x1544F40 Offset: 0x1543940 VA: 0x181544F40
	|-Dictionary<int, long>..ctor
	|
	|-RVA: 0x1545090 Offset: 0x1543A90 VA: 0x181545090
	|-Dictionary<int, object>..ctor
	|
	|-RVA: 0x15457B0 Offset: 0x15441B0 VA: 0x1815457B0
	|-Dictionary<int, RenderInstancedDataLayout>..ctor
	|
	|-RVA: 0x1544E90 Offset: 0x1543890 VA: 0x181544E90
	|-Dictionary<int, float>..ctor
	|
	|-RVA: 0x15455F0 Offset: 0x1543FF0 VA: 0x1815455F0
	|-Dictionary<int, TreeItem>..ctor
	|
	|-RVA: 0x1545120 Offset: 0x1543B20 VA: 0x181545120
	|-Dictionary<int, uint>..ctor
	|
	|-RVA: 0x1555380 Offset: 0x1553D80 VA: 0x181555380
	|-Dictionary<int, ulong>..ctor
	|
	|-RVA: 0x15554C0 Offset: 0x1553EC0 VA: 0x1815554C0
	|-Dictionary<int, Vector2Int>..ctor
	|
	|-RVA: 0x1554CE0 Offset: 0x15536E0 VA: 0x181554CE0
	|-Dictionary<int, Vector3>..ctor
	|
	|-RVA: 0x1555160 Offset: 0x1553B60 VA: 0x181555160
	|-Dictionary<int, Vector4>..ctor
	|
	|-RVA: 0x1556030 Offset: 0x1554A30 VA: 0x181556030
	|-Dictionary<int, Multipass.TransportIdData>..ctor
	|
	|-RVA: 0x1555430 Offset: 0x1553E30 VA: 0x181555430
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>..ctor
	|
	|-RVA: 0x15552F0 Offset: 0x1553CF0 VA: 0x1815552F0
	|-Dictionary<int, NetworkAnimator.StateChange>..ctor
	|
	|-RVA: 0x1566560 Offset: 0x1564F60 VA: 0x181566560
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>..ctor
	|
	|-RVA: 0x1566610 Offset: 0x1565010 VA: 0x181566610
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x15676A0 Offset: 0x15660A0 VA: 0x1815676A0
	|-Dictionary<int, TextResourceManager.FontAssetRef>..ctor
	|
	|-RVA: 0x1567920 Offset: 0x1566320 VA: 0x181567920
	|-Dictionary<Int32Enum, bool>..ctor
	|
	|-RVA: 0x1567870 Offset: 0x1566270 VA: 0x181567870
	|-Dictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x1567A70 Offset: 0x1566470 VA: 0x181567A70
	|-Dictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1567F40 Offset: 0x1566940 VA: 0x181567F40
	|-Dictionary<Int32Enum, object>..ctor
	|
	|-RVA: 0x157CDE0 Offset: 0x157B7E0 VA: 0x18157CDE0
	|-Dictionary<long, ComputedStyle>..ctor
	|
	|-RVA: 0x157BC50 Offset: 0x157A650 VA: 0x18157BC50
	|-Dictionary<long, object>..ctor
	|
	|-RVA: 0x157C510 Offset: 0x157AF10 VA: 0x18157C510
	|-Dictionary<IntPtr, object>..ctor
	|
	|-RVA: 0x157C460 Offset: 0x157AE60 VA: 0x18157C460
	|-Dictionary<InternedString, InternedString>..ctor
	|
	|-RVA: 0x157CE70 Offset: 0x157B870 VA: 0x18157CE70
	|-Dictionary<InternedString, object>..ctor
	|
	|-RVA: 0x157BD00 Offset: 0x157A700 VA: 0x18157BD00
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>..ctor
	|
	|-RVA: 0x157A590 Offset: 0x1578F90 VA: 0x18157A590
	|-Dictionary<NativeAddr, object>..ctor
	|
	|-RVA: 0x15A2AD0 Offset: 0x15A14D0 VA: 0x1815A2AD0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x15A47E0 Offset: 0x15A31E0 VA: 0x1815A47E0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>..ctor
	|
	|-RVA: 0x15A2A40 Offset: 0x15A1440 VA: 0x1815A2A40
	|-Dictionary<object, bool>..ctor
	|
	|-RVA: 0x15A4890 Offset: 0x15A3290 VA: 0x1815A4890
	|-Dictionary<object, Bounds>..ctor
	|
	|-RVA: 0x15A2550 Offset: 0x15A0F50 VA: 0x1815A2550
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A4730 Offset: 0x15A3130 VA: 0x1815A4730
	|-Dictionary<object, Color>..ctor
	|
	|-RVA: 0x15A22F0 Offset: 0x15A0CF0 VA: 0x1815A22F0
	|-Dictionary<object, Color32>..ctor
	|
	|-RVA: 0x15B40D0 Offset: 0x15B2AD0 VA: 0x1815B40D0
	|-Dictionary<object, double>..ctor
	|
	|-RVA: 0x15B3630 Offset: 0x15B2030 VA: 0x1815B3630
	|-Dictionary<object, int>..ctor
	|
	|-RVA: 0x15B46E0 Offset: 0x15B30E0 VA: 0x1815B46E0
	|-Dictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0x15B3BD0 Offset: 0x15B25D0 VA: 0x1815B3BD0
	|-Dictionary<object, long>..ctor
	|
	|-RVA: 0x15B3060 Offset: 0x15B1A60 VA: 0x1815B3060
	|-Dictionary<object, object>..ctor
	|
	|-RVA: 0x15B3130 Offset: 0x15B1B30 VA: 0x1815B3130
	|-Dictionary<object, Playable>..ctor
	|
	|-RVA: 0x15B4630 Offset: 0x15B3030 VA: 0x1815B4630
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>..ctor
	|
	|-RVA: 0x15C3610 Offset: 0x15C2010 VA: 0x1815C3610
	|-Dictionary<object, RaycastHit>..ctor
	|
	|-RVA: 0x15C46E0 Offset: 0x15C30E0 VA: 0x1815C46E0
	|-Dictionary<object, Rect>..ctor
	|
	|-RVA: 0x15C4030 Offset: 0x15C2A30 VA: 0x1815C4030
	|-Dictionary<object, ResourceLocator>..ctor
	|
	|-RVA: 0x15C4610 Offset: 0x15C3010 VA: 0x1815C4610
	|-Dictionary<object, float>..ctor
	|
	|-RVA: 0x15C2F20 Offset: 0x15C1920 VA: 0x1815C2F20
	|-Dictionary<object, StylePropertyValue>..ctor
	|
	|-RVA: 0x15C4580 Offset: 0x15C2F80 VA: 0x1815C4580
	|-Dictionary<object, TextureId>..ctor
	|
	|-RVA: 0x15C4B80 Offset: 0x15C3580 VA: 0x1815C4B80
	|-Dictionary<object, XPathNodeRef>..ctor
	|
	|-RVA: 0x15D5E70 Offset: 0x15D4870 VA: 0x1815D5E70
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|
	|-RVA: 0x15D6C00 Offset: 0x15D5600 VA: 0x1815D6C00
	|-Dictionary<object, InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x15D58B0 Offset: 0x15D42B0 VA: 0x1815D58B0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>..ctor
	|
	|-RVA: 0x15D7010 Offset: 0x15D5A10 VA: 0x1815D7010
	|-Dictionary<object, JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x15D6DF0 Offset: 0x15D57F0 VA: 0x1815D6DF0
	|-Dictionary<object, LiquidVolume.MeshCache>..ctor
	|
	|-RVA: 0x15D4DC0 Offset: 0x15D37C0 VA: 0x1815D4DC0
	|-Dictionary<object, ObjectPool.DelayedStoreData>..ctor
	|
	|-RVA: 0x15D6E80 Offset: 0x15D5880 VA: 0x1815D6E80
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>..ctor
	|
	|-RVA: 0x15E6B40 Offset: 0x15E5540 VA: 0x1815E6B40
	|-Dictionary<object, SVGDocument.ClipData>..ctor
	|
	|-RVA: 0x15E5D80 Offset: 0x15E4780 VA: 0x1815E5D80
	|-Dictionary<object, SVGDocument.MaskData>..ctor
	|
	|-RVA: 0x15E69D0 Offset: 0x15E53D0 VA: 0x1815E69D0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>..ctor
	|
	|-RVA: 0x15E79F0 Offset: 0x15E63F0 VA: 0x1815E79F0
	|-Dictionary<object, SVGDocument.PatternData>..ctor
	|
	|-RVA: 0x15E5C70 Offset: 0x15E4670 VA: 0x1815E5C70
	|-Dictionary<object, SVGDocument.ViewBoxInfo>..ctor
	|
	|-RVA: 0x15E5EF0 Offset: 0x15E48F0 VA: 0x1815E5EF0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>..ctor
	|
	|-RVA: 0x15E6CF0 Offset: 0x15E56F0 VA: 0x1815E6CF0
	|-Dictionary<Scene, object>..ctor
	|
	|-RVA: 0x15FB360 Offset: 0x15F9D60 VA: 0x1815FB360
	|-Dictionary<TerrainTileCoord, object>..ctor
	|
	|-RVA: 0x15FA630 Offset: 0x15F9030 VA: 0x1815FA630
	|-Dictionary<ushort, object>..ctor
	|
	|-RVA: 0x15FA870 Offset: 0x15F9270 VA: 0x1815FA870
	|-Dictionary<ushort, RpcLink>..ctor
	|
	|-RVA: 0x15FB410 Offset: 0x15F9E10 VA: 0x1815FB410
	|-Dictionary<ushort, ushort>..ctor
	|
	|-RVA: 0x15FA100 Offset: 0x15F8B00 VA: 0x1815FA100
	|-Dictionary<uint, GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x15FA7E0 Offset: 0x15F91E0 VA: 0x1815FA7E0
	|-Dictionary<uint, int>..ctor
	|
	|-RVA: 0x15FA920 Offset: 0x15F9320 VA: 0x1815FA920
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BB10 Offset: 0x160A510 VA: 0x18160BB10
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>..ctor
	|
	|-RVA: 0x160E000 Offset: 0x160CA00 VA: 0x18160E000
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160C9E0 Offset: 0x160B3E0 VA: 0x18160C9E0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>..ctor
	|
	|-RVA: 0x160BA60 Offset: 0x160A460 VA: 0x18160BA60
	|-Dictionary<uint, object>..ctor
	|
	|-RVA: 0x160BBA0 Offset: 0x160A5A0 VA: 0x18160BBA0
	|-Dictionary<uint, RpcLinkType>..ctor
	|
	|-RVA: 0x160D5C0 Offset: 0x160BFC0 VA: 0x18160D5C0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>..ctor
	|
	|-RVA: 0x160C140 Offset: 0x160AB40 VA: 0x18160C140
	|-Dictionary<ulong, object>..ctor
	|
	|-RVA: 0x1623910 Offset: 0x1622310 VA: 0x181623910
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|
	|-RVA: 0x16256F0 Offset: 0x16240F0 VA: 0x1816256F0
	|-Dictionary<Vector2Int, object>..ctor
	|
	|-RVA: 0x16252B0 Offset: 0x1623CB0 VA: 0x1816252B0
	|-Dictionary<Vector3, Vector3>..ctor
	|
	|-RVA: 0x1624D50 Offset: 0x1623750 VA: 0x181624D50
	|-Dictionary<Vector3Int, object>..ctor
	|
	|-RVA: 0x16230F0 Offset: 0x1621AF0 VA: 0x1816230F0
	|-Dictionary<XPathNodeRef, XPathNodeRef>..ctor
	|
	|-RVA: 0x16253F0 Offset: 0x1623DF0 VA: 0x1816253F0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x16231E0 Offset: 0x1621BE0 VA: 0x1816231E0
	|-Dictionary<Regex.CachedCodeEntryKey, object>..ctor
	|
	|-RVA: 0x16302A0 Offset: 0x162ECA0 VA: 0x1816302A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>..ctor
	|
	|-RVA: 0x162F0C0 Offset: 0x162DAC0 VA: 0x18162F0C0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>..ctor
	|
	|-RVA: 0x162F7A0 Offset: 0x162E1A0 VA: 0x18162F7A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>..ctor
	|
	|-RVA: 0x162F2E0 Offset: 0x162DCE0 VA: 0x18162F2E0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FC7D0 Offset: 0x14FB1D0 VA: 0x1814FC7D0
	|-Dictionary<KeyValuePair<object, object>, object>.get_Count
	|-Dictionary<StructMultiKey<object, object>, object>.get_Count
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Count
	|-Dictionary<ValueTuple<object, int>, object>.get_Count
	|-Dictionary<ValueTuple<object, object>, object>.get_Count
	|-Dictionary<Bounds, object>.get_Count
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.get_Count
	|-Dictionary<CSteamID, int>.get_Count
	|-Dictionary<FullRank, object>.get_Count
	|-Dictionary<Guid, object>.get_Count
	|-Dictionary<HSteamNetConnection, int>.get_Count
	|-Dictionary<Hash128, int>.get_Count
	|-Dictionary<Hash128, object>.get_Count
	|-Dictionary<Int2, int>.get_Count
	|-Dictionary<Int2, object>.get_Count
	|-Dictionary<Int3, int>.get_Count
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Count
	|-Dictionary<int, TreeViewItemData<object>>.get_Count
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.get_Count
	|-Dictionary<int, bool>.get_Count
	|-Dictionary<int, ByteEnum>.get_Count
	|-Dictionary<int, CSteamID>.get_Count
	|-Dictionary<int, HSteamNetConnection>.get_Count
	|-Dictionary<int, short>.get_Count
	|-Dictionary<int, Int3>.get_Count
	|-Dictionary<int, int>.get_Count
	|-Dictionary<int, Int32Enum>.get_Count
	|-Dictionary<int, long>.get_Count
	|-Dictionary<int, object>.get_Count
	|-Dictionary<int, RenderInstancedDataLayout>.get_Count
	|-Dictionary<int, float>.get_Count
	|-Dictionary<int, TreeItem>.get_Count
	|-Dictionary<int, uint>.get_Count
	|-Dictionary<int, ulong>.get_Count
	|-Dictionary<int, Vector2Int>.get_Count
	|-Dictionary<int, Vector3>.get_Count
	|-Dictionary<int, Vector4>.get_Count
	|-Dictionary<int, Multipass.TransportIdData>.get_Count
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.get_Count
	|-Dictionary<int, NetworkAnimator.StateChange>.get_Count
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.get_Count
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.get_Count
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Count
	|-Dictionary<Int32Enum, bool>.get_Count
	|-Dictionary<Int32Enum, int>.get_Count
	|-Dictionary<Int32Enum, Int32Enum>.get_Count
	|-Dictionary<Int32Enum, object>.get_Count
	|-Dictionary<long, ComputedStyle>.get_Count
	|-Dictionary<long, object>.get_Count
	|-Dictionary<IntPtr, object>.get_Count
	|-Dictionary<InternedString, InternedString>.get_Count
	|-Dictionary<InternedString, object>.get_Count
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Count
	|-Dictionary<NativeAddr, object>.get_Count
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.get_Count
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.get_Count
	|-Dictionary<object, bool>.get_Count
	|-Dictionary<object, Bounds>.get_Count
	|-Dictionary<object, Color>.get_Count
	|-Dictionary<object, Color>.get_Count
	|-Dictionary<object, Color32>.get_Count
	|-Dictionary<object, double>.get_Count
	|-Dictionary<object, int>.get_Count
	|-Dictionary<object, Int32Enum>.get_Count
	|-Dictionary<object, long>.get_Count
	|-Dictionary<object, object>.get_Count
	|-Dictionary<object, Playable>.get_Count
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.get_Count
	|-Dictionary<object, RaycastHit>.get_Count
	|-Dictionary<object, Rect>.get_Count
	|-Dictionary<object, ResourceLocator>.get_Count
	|-Dictionary<object, float>.get_Count
	|-Dictionary<object, StylePropertyValue>.get_Count
	|-Dictionary<object, TextureId>.get_Count
	|-Dictionary<object, XPathNodeRef>.get_Count
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Count
	|-Dictionary<object, InputControlLayout.ControlItem>.get_Count
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.get_Count
	|-Dictionary<object, JsonParser.JsonValue>.get_Count
	|-Dictionary<object, LiquidVolume.MeshCache>.get_Count
	|-Dictionary<object, ObjectPool.DelayedStoreData>.get_Count
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.get_Count
	|-Dictionary<object, SVGDocument.ClipData>.get_Count
	|-Dictionary<object, SVGDocument.MaskData>.get_Count
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.get_Count
	|-Dictionary<object, SVGDocument.PatternData>.get_Count
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.get_Count
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Count
	|-Dictionary<Scene, object>.get_Count
	|-Dictionary<TerrainTileCoord, object>.get_Count
	|-Dictionary<ushort, object>.get_Count
	|-Dictionary<ushort, RpcLink>.get_Count
	|-Dictionary<ushort, ushort>.get_Count
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Count
	|-Dictionary<uint, int>.get_Count
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Count
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Count
	|-Dictionary<uint, object>.get_Count
	|-Dictionary<uint, RpcLinkType>.get_Count
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.get_Count
	|-Dictionary<ulong, object>.get_Count
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Count
	|-Dictionary<Vector2Int, object>.get_Count
	|-Dictionary<Vector3, Vector3>.get_Count
	|-Dictionary<Vector3Int, object>.get_Count
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Count
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Count
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Count
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F43D0 Offset: 0x14F2DD0 VA: 0x1814F43D0
	|-Dictionary<KeyValuePair<object, object>, object>.get_Keys
	|-Dictionary<StructMultiKey<object, object>, object>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Keys
	|-Dictionary<ValueTuple<object, int>, object>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.get_Keys
	|-Dictionary<Bounds, object>.get_Keys
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.get_Keys
	|-Dictionary<CSteamID, int>.get_Keys
	|-Dictionary<FullRank, object>.get_Keys
	|-Dictionary<Guid, object>.get_Keys
	|-Dictionary<HSteamNetConnection, int>.get_Keys
	|-Dictionary<Hash128, int>.get_Keys
	|-Dictionary<Hash128, object>.get_Keys
	|-Dictionary<Int2, int>.get_Keys
	|-Dictionary<Int2, object>.get_Keys
	|-Dictionary<Int3, int>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.get_Keys
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.get_Keys
	|-Dictionary<int, bool>.get_Keys
	|-Dictionary<int, ByteEnum>.get_Keys
	|-Dictionary<int, CSteamID>.get_Keys
	|-Dictionary<int, HSteamNetConnection>.get_Keys
	|-Dictionary<int, short>.get_Keys
	|-Dictionary<int, Int3>.get_Keys
	|-Dictionary<int, int>.get_Keys
	|-Dictionary<int, Int32Enum>.get_Keys
	|-Dictionary<int, long>.get_Keys
	|-Dictionary<int, object>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.get_Keys
	|-Dictionary<int, float>.get_Keys
	|-Dictionary<int, TreeItem>.get_Keys
	|-Dictionary<int, uint>.get_Keys
	|-Dictionary<int, ulong>.get_Keys
	|-Dictionary<int, Vector2Int>.get_Keys
	|-Dictionary<int, Vector3>.get_Keys
	|-Dictionary<int, Vector4>.get_Keys
	|-Dictionary<int, Multipass.TransportIdData>.get_Keys
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.get_Keys
	|-Dictionary<int, NetworkAnimator.StateChange>.get_Keys
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.get_Keys
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Keys
	|-Dictionary<Int32Enum, bool>.get_Keys
	|-Dictionary<Int32Enum, int>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.get_Keys
	|-Dictionary<Int32Enum, object>.get_Keys
	|-Dictionary<long, ComputedStyle>.get_Keys
	|-Dictionary<long, object>.get_Keys
	|-Dictionary<IntPtr, object>.get_Keys
	|-Dictionary<InternedString, InternedString>.get_Keys
	|-Dictionary<InternedString, object>.get_Keys
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Keys
	|-Dictionary<NativeAddr, object>.get_Keys
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.get_Keys
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.get_Keys
	|-Dictionary<object, bool>.get_Keys
	|-Dictionary<object, Bounds>.get_Keys
	|-Dictionary<object, Color>.get_Keys
	|-Dictionary<object, Color>.get_Keys
	|-Dictionary<object, Color32>.get_Keys
	|-Dictionary<object, double>.get_Keys
	|-Dictionary<object, int>.get_Keys
	|-Dictionary<object, Int32Enum>.get_Keys
	|-Dictionary<object, long>.get_Keys
	|-Dictionary<object, object>.get_Keys
	|-Dictionary<object, Playable>.get_Keys
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.get_Keys
	|-Dictionary<object, RaycastHit>.get_Keys
	|-Dictionary<object, Rect>.get_Keys
	|-Dictionary<object, ResourceLocator>.get_Keys
	|-Dictionary<object, float>.get_Keys
	|-Dictionary<object, StylePropertyValue>.get_Keys
	|-Dictionary<object, TextureId>.get_Keys
	|-Dictionary<object, XPathNodeRef>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Keys
	|-Dictionary<object, InputControlLayout.ControlItem>.get_Keys
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.get_Keys
	|-Dictionary<object, JsonParser.JsonValue>.get_Keys
	|-Dictionary<object, LiquidVolume.MeshCache>.get_Keys
	|-Dictionary<object, ObjectPool.DelayedStoreData>.get_Keys
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.get_Keys
	|-Dictionary<object, SVGDocument.ClipData>.get_Keys
	|-Dictionary<object, SVGDocument.MaskData>.get_Keys
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.get_Keys
	|-Dictionary<object, SVGDocument.PatternData>.get_Keys
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Keys
	|-Dictionary<Scene, object>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.get_Keys
	|-Dictionary<ushort, object>.get_Keys
	|-Dictionary<ushort, RpcLink>.get_Keys
	|-Dictionary<ushort, ushort>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Keys
	|-Dictionary<uint, int>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Keys
	|-Dictionary<uint, object>.get_Keys
	|-Dictionary<uint, RpcLinkType>.get_Keys
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.get_Keys
	|-Dictionary<ulong, object>.get_Keys
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Keys
	|-Dictionary<Vector2Int, object>.get_Keys
	|-Dictionary<Vector3, Vector3>.get_Keys
	|-Dictionary<Vector3Int, object>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Keys
	|
	|-RVA: 0x1619B60 Offset: 0x1618560 VA: 0x181619B60
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F43D0 Offset: 0x14F2DD0 VA: 0x1814F43D0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Bounds, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<CSteamID, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<FullRank, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Hash128, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Hash128, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int2, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int2, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int3, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, CSteamID>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, short>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ulong>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector4>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Bounds>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color32>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, double>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Playable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Rect>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TextureId>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Scene, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, ushort>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x1619B60 Offset: 0x1618560 VA: 0x181619B60
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F43D0 Offset: 0x14F2DD0 VA: 0x1814F43D0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Bounds, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<CSteamID, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<FullRank, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Guid, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Hash128, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Hash128, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int2, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int2, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int3, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, CSteamID>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, short>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ulong>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Vector4>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Bounds>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Color32>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, double>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Playable>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, Rect>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, TextureId>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Scene, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ushort, ushort>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x1619B60 Offset: 0x1618560 VA: 0x181619B60
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F4470 Offset: 0x14F2E70 VA: 0x1814F4470
	|-Dictionary<KeyValuePair<object, object>, object>.get_Values
	|-Dictionary<StructMultiKey<object, object>, object>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Values
	|-Dictionary<ValueTuple<object, int>, object>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.get_Values
	|-Dictionary<Bounds, object>.get_Values
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.get_Values
	|-Dictionary<CSteamID, int>.get_Values
	|-Dictionary<FullRank, object>.get_Values
	|-Dictionary<Guid, object>.get_Values
	|-Dictionary<HSteamNetConnection, int>.get_Values
	|-Dictionary<Hash128, int>.get_Values
	|-Dictionary<Hash128, object>.get_Values
	|-Dictionary<Int2, int>.get_Values
	|-Dictionary<Int2, object>.get_Values
	|-Dictionary<Int3, int>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.get_Values
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.get_Values
	|-Dictionary<int, bool>.get_Values
	|-Dictionary<int, ByteEnum>.get_Values
	|-Dictionary<int, CSteamID>.get_Values
	|-Dictionary<int, HSteamNetConnection>.get_Values
	|-Dictionary<int, short>.get_Values
	|-Dictionary<int, Int3>.get_Values
	|-Dictionary<int, int>.get_Values
	|-Dictionary<int, Int32Enum>.get_Values
	|-Dictionary<int, long>.get_Values
	|-Dictionary<int, object>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.get_Values
	|-Dictionary<int, float>.get_Values
	|-Dictionary<int, TreeItem>.get_Values
	|-Dictionary<int, uint>.get_Values
	|-Dictionary<int, ulong>.get_Values
	|-Dictionary<int, Vector2Int>.get_Values
	|-Dictionary<int, Vector3>.get_Values
	|-Dictionary<int, Vector4>.get_Values
	|-Dictionary<int, Multipass.TransportIdData>.get_Values
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.get_Values
	|-Dictionary<int, NetworkAnimator.StateChange>.get_Values
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.get_Values
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Values
	|-Dictionary<Int32Enum, bool>.get_Values
	|-Dictionary<Int32Enum, int>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.get_Values
	|-Dictionary<Int32Enum, object>.get_Values
	|-Dictionary<long, ComputedStyle>.get_Values
	|-Dictionary<long, object>.get_Values
	|-Dictionary<IntPtr, object>.get_Values
	|-Dictionary<InternedString, InternedString>.get_Values
	|-Dictionary<InternedString, object>.get_Values
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Values
	|-Dictionary<NativeAddr, object>.get_Values
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.get_Values
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.get_Values
	|-Dictionary<object, bool>.get_Values
	|-Dictionary<object, Bounds>.get_Values
	|-Dictionary<object, Color>.get_Values
	|-Dictionary<object, Color>.get_Values
	|-Dictionary<object, Color32>.get_Values
	|-Dictionary<object, double>.get_Values
	|-Dictionary<object, int>.get_Values
	|-Dictionary<object, Int32Enum>.get_Values
	|-Dictionary<object, long>.get_Values
	|-Dictionary<object, object>.get_Values
	|-Dictionary<object, Playable>.get_Values
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.get_Values
	|-Dictionary<object, RaycastHit>.get_Values
	|-Dictionary<object, Rect>.get_Values
	|-Dictionary<object, ResourceLocator>.get_Values
	|-Dictionary<object, float>.get_Values
	|-Dictionary<object, StylePropertyValue>.get_Values
	|-Dictionary<object, TextureId>.get_Values
	|-Dictionary<object, XPathNodeRef>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Values
	|-Dictionary<object, InputControlLayout.ControlItem>.get_Values
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.get_Values
	|-Dictionary<object, JsonParser.JsonValue>.get_Values
	|-Dictionary<object, LiquidVolume.MeshCache>.get_Values
	|-Dictionary<object, ObjectPool.DelayedStoreData>.get_Values
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.get_Values
	|-Dictionary<object, SVGDocument.ClipData>.get_Values
	|-Dictionary<object, SVGDocument.MaskData>.get_Values
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.get_Values
	|-Dictionary<object, SVGDocument.PatternData>.get_Values
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Values
	|-Dictionary<Scene, object>.get_Values
	|-Dictionary<TerrainTileCoord, object>.get_Values
	|-Dictionary<ushort, object>.get_Values
	|-Dictionary<ushort, RpcLink>.get_Values
	|-Dictionary<ushort, ushort>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Values
	|-Dictionary<uint, int>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Values
	|-Dictionary<uint, object>.get_Values
	|-Dictionary<uint, RpcLinkType>.get_Values
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.get_Values
	|-Dictionary<ulong, object>.get_Values
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Values
	|-Dictionary<Vector2Int, object>.get_Values
	|-Dictionary<Vector3, Vector3>.get_Values
	|-Dictionary<Vector3Int, object>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Values
	|
	|-RVA: 0x1619C00 Offset: 0x1618600 VA: 0x181619C00
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F4470 Offset: 0x14F2E70 VA: 0x1814F4470
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Bounds, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<CSteamID, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<FullRank, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Hash128, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Hash128, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int2, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int2, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int3, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, CSteamID>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, short>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, uint>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ulong>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector4>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Bounds>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color32>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, double>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, long>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Playable>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Rect>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, float>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TextureId>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Scene, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, ushort>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1619C00 Offset: 0x1618600 VA: 0x181619C00
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F4470 Offset: 0x14F2E70 VA: 0x1814F4470
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Bounds, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<CSteamID, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<FullRank, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Guid, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Hash128, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Hash128, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int2, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int2, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int3, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, CSteamID>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, short>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, uint>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ulong>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Vector4>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<long, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Bounds>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Color32>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, double>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, long>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Playable>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, Rect>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, float>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, TextureId>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Scene, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ushort, ushort>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1619C00 Offset: 0x1618600 VA: 0x181619C00
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FCB10 Offset: 0x14FB510 VA: 0x1814FCB10
	|-Dictionary<KeyValuePair<object, object>, object>.get_Item
	|
	|-RVA: 0x14FC8A0 Offset: 0x14FB2A0 VA: 0x1814FC8A0
	|-Dictionary<StructMultiKey<object, object>, object>.get_Item
	|
	|-RVA: 0x14FC960 Offset: 0x14FB360 VA: 0x1814FC960
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.get_Item
	|
	|-RVA: 0x14FCA50 Offset: 0x14FB450 VA: 0x1814FCA50
	|-Dictionary<ValueTuple<object, int>, object>.get_Item
	|
	|-RVA: 0x14FC7E0 Offset: 0x14FB1E0 VA: 0x1814FC7E0
	|-Dictionary<ValueTuple<object, object>, object>.get_Item
	|
	|-RVA: 0x1512120 Offset: 0x1510B20 VA: 0x181512120
	|-Dictionary<Bounds, object>.get_Item
	|
	|-RVA: 0x1511CA0 Offset: 0x15106A0 VA: 0x181511CA0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.get_Item
	|
	|-RVA: 0x1511FC0 Offset: 0x15109C0 VA: 0x181511FC0
	|-Dictionary<CSteamID, int>.get_Item
	|
	|-RVA: 0x1512070 Offset: 0x1510A70 VA: 0x181512070
	|-Dictionary<FullRank, object>.get_Item
	|
	|-RVA: 0x1511DA0 Offset: 0x15107A0 VA: 0x181511DA0
	|-Dictionary<Guid, object>.get_Item
	|
	|-RVA: 0x1511F20 Offset: 0x1510920 VA: 0x181511F20
	|-Dictionary<HSteamNetConnection, int>.get_Item
	|
	|-RVA: 0x1511E60 Offset: 0x1510860 VA: 0x181511E60
	|-Dictionary<Hash128, int>.get_Item
	|
	|-RVA: 0x1525DC0 Offset: 0x15247C0 VA: 0x181525DC0
	|-Dictionary<Hash128, object>.get_Item
	|
	|-RVA: 0x1525C70 Offset: 0x1524670 VA: 0x181525C70
	|-Dictionary<Int2, int>.get_Item
	|
	|-RVA: 0x1525BC0 Offset: 0x15245C0 VA: 0x181525BC0
	|-Dictionary<Int2, object>.get_Item
	|
	|-RVA: 0x1525F50 Offset: 0x1524950 VA: 0x181525F50
	|-Dictionary<Int3, int>.get_Item
	|
	|-RVA: 0x1525D20 Offset: 0x1524720 VA: 0x181525D20
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Item
	|-Dictionary<int, CSteamID>.get_Item
	|-Dictionary<int, Vector2Int>.get_Item
	|-Dictionary<int, Multipass.TransportIdData>.get_Item
	|
	|-RVA: 0x1525E80 Offset: 0x1524880 VA: 0x181525E80
	|-Dictionary<int, TreeViewItemData<object>>.get_Item
	|
	|-RVA: 0x1525AF0 Offset: 0x15244F0 VA: 0x181525AF0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.get_Item
	|
	|-RVA: 0x1536140 Offset: 0x1534B40 VA: 0x181536140
	|-Dictionary<int, bool>.get_Item
	|-Dictionary<int, ByteEnum>.get_Item
	|
	|-RVA: 0x15360A0 Offset: 0x1534AA0 VA: 0x1815360A0
	|-Dictionary<int, HSteamNetConnection>.get_Item
	|-Dictionary<int, int>.get_Item
	|-Dictionary<int, Int32Enum>.get_Item
	|-Dictionary<int, uint>.get_Item
	|
	|-RVA: 0x1535F30 Offset: 0x1534930 VA: 0x181535F30
	|-Dictionary<int, short>.get_Item
	|
	|-RVA: 0x1535FD0 Offset: 0x15349D0 VA: 0x181535FD0
	|-Dictionary<int, Int3>.get_Item
	|-Dictionary<int, Vector3>.get_Item
	|
	|-RVA: 0x1546DD0 Offset: 0x15457D0 VA: 0x181546DD0
	|-Dictionary<int, long>.get_Item
	|-Dictionary<int, object>.get_Item
	|-Dictionary<int, ulong>.get_Item
	|
	|-RVA: 0x1546D20 Offset: 0x1545720 VA: 0x181546D20
	|-Dictionary<int, RenderInstancedDataLayout>.get_Item
	|-Dictionary<int, Vector4>.get_Item
	|
	|-RVA: 0x1546E80 Offset: 0x1545880 VA: 0x181546E80
	|-Dictionary<int, float>.get_Item
	|
	|-RVA: 0x1546F30 Offset: 0x1545930 VA: 0x181546F30
	|-Dictionary<int, TreeItem>.get_Item
	|
	|-RVA: 0x1556990 Offset: 0x1555390 VA: 0x181556990
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.get_Item
	|
	|-RVA: 0x15568B0 Offset: 0x15552B0 VA: 0x1815568B0
	|-Dictionary<int, NetworkAnimator.StateChange>.get_Item
	|
	|-RVA: 0x1568F40 Offset: 0x1567940 VA: 0x181568F40
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.get_Item
	|
	|-RVA: 0x1568C80 Offset: 0x1567680 VA: 0x181568C80
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.get_Item
	|-Dictionary<int, TextResourceManager.FontAssetRef>.get_Item
	|
	|-RVA: 0x1568DF0 Offset: 0x15677F0 VA: 0x181568DF0
	|-Dictionary<Int32Enum, bool>.get_Item
	|
	|-RVA: 0x1568D50 Offset: 0x1567750 VA: 0x181568D50
	|-Dictionary<Int32Enum, int>.get_Item
	|-Dictionary<Int32Enum, Int32Enum>.get_Item
	|
	|-RVA: 0x1568E90 Offset: 0x1567890 VA: 0x181568E90
	|-Dictionary<Int32Enum, object>.get_Item
	|
	|-RVA: 0x157D1F0 Offset: 0x157BBF0 VA: 0x18157D1F0
	|-Dictionary<long, ComputedStyle>.get_Item
	|
	|-RVA: 0x157D140 Offset: 0x157BB40 VA: 0x18157D140
	|-Dictionary<long, object>.get_Item
	|
	|-RVA: 0x157D090 Offset: 0x157BA90 VA: 0x18157D090
	|-Dictionary<IntPtr, object>.get_Item
	|
	|-RVA: 0x157CFD0 Offset: 0x157B9D0 VA: 0x18157CFD0
	|-Dictionary<InternedString, InternedString>.get_Item
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.get_Item
	|
	|-RVA: 0x157D310 Offset: 0x157BD10 VA: 0x18157D310
	|-Dictionary<InternedString, object>.get_Item
	|
	|-RVA: 0x157CF00 Offset: 0x157B900 VA: 0x18157CF00
	|-Dictionary<NativeAddr, object>.get_Item
	|
	|-RVA: 0x15A4940 Offset: 0x15A3340 VA: 0x1815A4940
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.get_Item
	|-Dictionary<object, Color>.get_Item
	|-Dictionary<object, Playable>.get_Item
	|-Dictionary<object, Rect>.get_Item
	|-Dictionary<object, ResourceLocator>.get_Item
	|-Dictionary<object, StylePropertyValue>.get_Item
	|-Dictionary<object, XPathNodeRef>.get_Item
	|
	|-RVA: 0x15A49D0 Offset: 0x15A33D0 VA: 0x1815A49D0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.get_Item
	|-Dictionary<object, SVGDocument.PatternData>.get_Item
	|
	|-RVA: 0x15A4B00 Offset: 0x15A3500 VA: 0x1815A4B00
	|-Dictionary<object, bool>.get_Item
	|
	|-RVA: 0x15A4B80 Offset: 0x15A3580 VA: 0x1815A4B80
	|-Dictionary<object, Bounds>.get_Item
	|-Dictionary<object, Color>.get_Item
	|-Dictionary<object, LiquidVolume.MeshCache>.get_Item
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.get_Item
	|
	|-RVA: 0x15A4A80 Offset: 0x15A3480 VA: 0x1815A4A80
	|-Dictionary<object, Color32>.get_Item
	|-Dictionary<object, TextureId>.get_Item
	|
	|-RVA: 0x15B5750 Offset: 0x15B4150 VA: 0x1815B5750
	|-Dictionary<object, double>.get_Item
	|
	|-RVA: 0x15B55B0 Offset: 0x15B3FB0 VA: 0x1815B55B0
	|-Dictionary<object, int>.get_Item
	|-Dictionary<object, Int32Enum>.get_Item
	|
	|-RVA: 0x15B5630 Offset: 0x15B4030 VA: 0x1815B5630
	|-Dictionary<object, long>.get_Item
	|-Dictionary<object, object>.get_Item
	|
	|-RVA: 0x15B56B0 Offset: 0x15B40B0 VA: 0x1815B56B0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.get_Item
	|
	|-RVA: 0x15C5530 Offset: 0x15C3F30 VA: 0x1815C5530
	|-Dictionary<object, RaycastHit>.get_Item
	|
	|-RVA: 0x15C55F0 Offset: 0x15C3FF0 VA: 0x1815C55F0
	|-Dictionary<object, float>.get_Item
	|
	|-RVA: 0x15D7490 Offset: 0x15D5E90 VA: 0x1815D7490
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.get_Item
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.get_Item
	|-Dictionary<object, ObjectPool.DelayedStoreData>.get_Item
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.get_Item
	|
	|-RVA: 0x15D7510 Offset: 0x15D5F10 VA: 0x1815D7510
	|-Dictionary<object, InputControlLayout.ControlItem>.get_Item
	|
	|-RVA: 0x15D76C0 Offset: 0x15D60C0 VA: 0x1815D76C0
	|-Dictionary<object, JsonParser.JsonValue>.get_Item
	|
	|-RVA: 0x15E7EB0 Offset: 0x15E68B0 VA: 0x1815E7EB0
	|-Dictionary<object, SVGDocument.ClipData>.get_Item
	|
	|-RVA: 0x15E7FE0 Offset: 0x15E69E0 VA: 0x1815E7FE0
	|-Dictionary<object, SVGDocument.MaskData>.get_Item
	|
	|-RVA: 0x15E8060 Offset: 0x15E6A60 VA: 0x1815E8060
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.get_Item
	|
	|-RVA: 0x15E80F0 Offset: 0x15E6AF0 VA: 0x1815E80F0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.get_Item
	|
	|-RVA: 0x15E7F30 Offset: 0x15E6930 VA: 0x1815E7F30
	|-Dictionary<Scene, object>.get_Item
	|
	|-RVA: 0x15FC050 Offset: 0x15FAA50 VA: 0x1815FC050
	|-Dictionary<TerrainTileCoord, object>.get_Item
	|
	|-RVA: 0x15FBFA0 Offset: 0x15FA9A0 VA: 0x1815FBFA0
	|-Dictionary<ushort, object>.get_Item
	|
	|-RVA: 0x15FC100 Offset: 0x15FAB00 VA: 0x1815FC100
	|-Dictionary<ushort, RpcLink>.get_Item
	|
	|-RVA: 0x15FC1B0 Offset: 0x15FABB0 VA: 0x1815FC1B0
	|-Dictionary<ushort, ushort>.get_Item
	|
	|-RVA: 0x15FC330 Offset: 0x15FAD30 VA: 0x1815FC330
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.get_Item
	|
	|-RVA: 0x15FC410 Offset: 0x15FAE10 VA: 0x1815FC410
	|-Dictionary<uint, int>.get_Item
	|
	|-RVA: 0x15FC260 Offset: 0x15FAC60 VA: 0x1815FC260
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Item
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.get_Item
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Item
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.get_Item
	|
	|-RVA: 0x160E0F0 Offset: 0x160CAF0 VA: 0x18160E0F0
	|-Dictionary<uint, object>.get_Item
	|
	|-RVA: 0x160E250 Offset: 0x160CC50 VA: 0x18160E250
	|-Dictionary<uint, RpcLinkType>.get_Item
	|
	|-RVA: 0x160E2F0 Offset: 0x160CCF0 VA: 0x18160E2F0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.get_Item
	|
	|-RVA: 0x160E1A0 Offset: 0x160CBA0 VA: 0x18160E1A0
	|-Dictionary<ulong, object>.get_Item
	|
	|-RVA: 0x16263F0 Offset: 0x1624DF0 VA: 0x1816263F0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.get_Item
	|
	|-RVA: 0x1625F60 Offset: 0x1624960 VA: 0x181625F60
	|-Dictionary<Vector2Int, object>.get_Item
	|
	|-RVA: 0x1626230 Offset: 0x1624C30 VA: 0x181626230
	|-Dictionary<Vector3, Vector3>.get_Item
	|
	|-RVA: 0x1626320 Offset: 0x1624D20 VA: 0x181626320
	|-Dictionary<Vector3Int, object>.get_Item
	|
	|-RVA: 0x1625DD0 Offset: 0x16247D0 VA: 0x181625DD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.get_Item
	|
	|-RVA: 0x1626010 Offset: 0x1624A10 VA: 0x181626010
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x1625E90 Offset: 0x1624890 VA: 0x181625E90
	|-Dictionary<Regex.CachedCodeEntryKey, object>.get_Item
	|
	|-RVA: 0x1630880 Offset: 0x162F280 VA: 0x181630880
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.get_Item
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.get_Item
	|
	|-RVA: 0x16307C0 Offset: 0x162F1C0 VA: 0x1816307C0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.get_Item
	|
	|-RVA: 0x1630940 Offset: 0x162F340 VA: 0x181630940
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14FCD00 Offset: 0x14FB700 VA: 0x1814FCD00
	|-Dictionary<KeyValuePair<object, object>, object>.set_Item
	|
	|-RVA: 0x14FCBD0 Offset: 0x14FB5D0 VA: 0x1814FCBD0
	|-Dictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0x14FCC90 Offset: 0x14FB690 VA: 0x1814FCC90
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.set_Item
	|
	|-RVA: 0x14FCC50 Offset: 0x14FB650 VA: 0x1814FCC50
	|-Dictionary<ValueTuple<object, int>, object>.set_Item
	|
	|-RVA: 0x14FCC10 Offset: 0x14FB610 VA: 0x1814FCC10
	|-Dictionary<ValueTuple<object, object>, object>.set_Item
	|
	|-RVA: 0x1512300 Offset: 0x1510D00 VA: 0x181512300
	|-Dictionary<Bounds, object>.set_Item
	|
	|-RVA: 0x1512290 Offset: 0x1510C90 VA: 0x181512290
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.set_Item
	|
	|-RVA: 0x15121F0 Offset: 0x1510BF0 VA: 0x1815121F0
	|-Dictionary<CSteamID, int>.set_Item
	|
	|-RVA: 0x1512260 Offset: 0x1510C60 VA: 0x181512260
	|-Dictionary<FullRank, object>.set_Item
	|
	|-RVA: 0x1512220 Offset: 0x1510C20 VA: 0x181512220
	|-Dictionary<Guid, object>.set_Item
	|
	|-RVA: 0x1512340 Offset: 0x1510D40 VA: 0x181512340
	|-Dictionary<HSteamNetConnection, int>.set_Item
	|
	|-RVA: 0x1512370 Offset: 0x1510D70 VA: 0x181512370
	|-Dictionary<Hash128, int>.set_Item
	|
	|-RVA: 0x1526110 Offset: 0x1524B10 VA: 0x181526110
	|-Dictionary<Hash128, object>.set_Item
	|
	|-RVA: 0x1526020 Offset: 0x1524A20 VA: 0x181526020
	|-Dictionary<Int2, int>.set_Item
	|
	|-RVA: 0x1526150 Offset: 0x1524B50 VA: 0x181526150
	|-Dictionary<Int2, object>.set_Item
	|
	|-RVA: 0x15260A0 Offset: 0x1524AA0 VA: 0x1815260A0
	|-Dictionary<Int3, int>.set_Item
	|
	|-RVA: 0x15260E0 Offset: 0x1524AE0 VA: 0x1815260E0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.set_Item
	|
	|-RVA: 0x1526050 Offset: 0x1524A50 VA: 0x181526050
	|-Dictionary<int, TreeViewItemData<object>>.set_Item
	|
	|-RVA: 0x1526180 Offset: 0x1524B80 VA: 0x181526180
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.set_Item
	|
	|-RVA: 0x15361E0 Offset: 0x1534BE0 VA: 0x1815361E0
	|-Dictionary<int, bool>.set_Item
	|
	|-RVA: 0x1536310 Offset: 0x1534D10 VA: 0x181536310
	|-Dictionary<int, ByteEnum>.set_Item
	|
	|-RVA: 0x1536210 Offset: 0x1534C10 VA: 0x181536210
	|-Dictionary<int, CSteamID>.set_Item
	|
	|-RVA: 0x1536270 Offset: 0x1534C70 VA: 0x181536270
	|-Dictionary<int, HSteamNetConnection>.set_Item
	|
	|-RVA: 0x15362E0 Offset: 0x1534CE0 VA: 0x1815362E0
	|-Dictionary<int, short>.set_Item
	|
	|-RVA: 0x15362A0 Offset: 0x1534CA0 VA: 0x1815362A0
	|-Dictionary<int, Int3>.set_Item
	|
	|-RVA: 0x1536240 Offset: 0x1534C40 VA: 0x181536240
	|-Dictionary<int, int>.set_Item
	|
	|-RVA: 0x15470A0 Offset: 0x1545AA0 VA: 0x1815470A0
	|-Dictionary<int, Int32Enum>.set_Item
	|
	|-RVA: 0x1547010 Offset: 0x1545A10 VA: 0x181547010
	|-Dictionary<int, long>.set_Item
	|
	|-RVA: 0x1546FE0 Offset: 0x15459E0 VA: 0x181546FE0
	|-Dictionary<int, object>.set_Item
	|
	|-RVA: 0x1547110 Offset: 0x1545B10 VA: 0x181547110
	|-Dictionary<int, RenderInstancedDataLayout>.set_Item
	|
	|-RVA: 0x1547040 Offset: 0x1545A40 VA: 0x181547040
	|-Dictionary<int, float>.set_Item
	|
	|-RVA: 0x15470D0 Offset: 0x1545AD0 VA: 0x1815470D0
	|-Dictionary<int, TreeItem>.set_Item
	|
	|-RVA: 0x1547070 Offset: 0x1545A70 VA: 0x181547070
	|-Dictionary<int, uint>.set_Item
	|
	|-RVA: 0x1556BC0 Offset: 0x15555C0 VA: 0x181556BC0
	|-Dictionary<int, ulong>.set_Item
	|
	|-RVA: 0x1556B00 Offset: 0x1555500 VA: 0x181556B00
	|-Dictionary<int, Vector2Int>.set_Item
	|
	|-RVA: 0x1556A90 Offset: 0x1555490 VA: 0x181556A90
	|-Dictionary<int, Vector3>.set_Item
	|
	|-RVA: 0x1556A50 Offset: 0x1555450 VA: 0x181556A50
	|-Dictionary<int, Vector4>.set_Item
	|
	|-RVA: 0x1556AD0 Offset: 0x15554D0 VA: 0x181556AD0
	|-Dictionary<int, Multipass.TransportIdData>.set_Item
	|
	|-RVA: 0x1556B30 Offset: 0x1555530 VA: 0x181556B30
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.set_Item
	|
	|-RVA: 0x1556B70 Offset: 0x1555570 VA: 0x181556B70
	|-Dictionary<int, NetworkAnimator.StateChange>.set_Item
	|
	|-RVA: 0x1569190 Offset: 0x1567B90 VA: 0x181569190
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.set_Item
	|
	|-RVA: 0x1569120 Offset: 0x1567B20 VA: 0x181569120
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.set_Item
	|
	|-RVA: 0x15690B0 Offset: 0x1567AB0 VA: 0x1815690B0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.set_Item
	|
	|-RVA: 0x15690F0 Offset: 0x1567AF0 VA: 0x1815690F0
	|-Dictionary<Int32Enum, bool>.set_Item
	|
	|-RVA: 0x1569220 Offset: 0x1567C20 VA: 0x181569220
	|-Dictionary<Int32Enum, int>.set_Item
	|
	|-RVA: 0x1569080 Offset: 0x1567A80 VA: 0x181569080
	|-Dictionary<Int32Enum, Int32Enum>.set_Item
	|
	|-RVA: 0x1569160 Offset: 0x1567B60 VA: 0x181569160
	|-Dictionary<Int32Enum, object>.set_Item
	|
	|-RVA: 0x157D3D0 Offset: 0x157BDD0 VA: 0x18157D3D0
	|-Dictionary<long, ComputedStyle>.set_Item
	|
	|-RVA: 0x157D450 Offset: 0x157BE50 VA: 0x18157D450
	|-Dictionary<long, object>.set_Item
	|
	|-RVA: 0x157D510 Offset: 0x157BF10 VA: 0x18157D510
	|-Dictionary<IntPtr, object>.set_Item
	|
	|-RVA: 0x157D580 Offset: 0x157BF80 VA: 0x18157D580
	|-Dictionary<InternedString, InternedString>.set_Item
	|
	|-RVA: 0x157D540 Offset: 0x157BF40 VA: 0x18157D540
	|-Dictionary<InternedString, object>.set_Item
	|
	|-RVA: 0x157D480 Offset: 0x157BE80 VA: 0x18157D480
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.set_Item
	|
	|-RVA: 0x157D4D0 Offset: 0x157BED0 VA: 0x18157D4D0
	|-Dictionary<NativeAddr, object>.set_Item
	|
	|-RVA: 0x15A4D50 Offset: 0x15A3750 VA: 0x1815A4D50
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.set_Item
	|
	|-RVA: 0x15A4CC0 Offset: 0x15A36C0 VA: 0x1815A4CC0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.set_Item
	|
	|-RVA: 0x15A4DE0 Offset: 0x15A37E0 VA: 0x1815A4DE0
	|-Dictionary<object, bool>.set_Item
	|
	|-RVA: 0x15A4D90 Offset: 0x15A3790 VA: 0x1815A4D90
	|-Dictionary<object, Bounds>.set_Item
	|
	|-RVA: 0x15A4C40 Offset: 0x15A3640 VA: 0x1815A4C40
	|-Dictionary<object, Color>.set_Item
	|
	|-RVA: 0x15A4D10 Offset: 0x15A3710 VA: 0x1815A4D10
	|-Dictionary<object, Color>.set_Item
	|
	|-RVA: 0x15A4C90 Offset: 0x15A3690 VA: 0x1815A4C90
	|-Dictionary<object, Color32>.set_Item
	|
	|-RVA: 0x15B58A0 Offset: 0x15B42A0 VA: 0x1815B58A0
	|-Dictionary<object, double>.set_Item
	|
	|-RVA: 0x15B5870 Offset: 0x15B4270 VA: 0x1815B5870
	|-Dictionary<object, int>.set_Item
	|
	|-RVA: 0x15B5920 Offset: 0x15B4320 VA: 0x1815B5920
	|-Dictionary<object, Int32Enum>.set_Item
	|
	|-RVA: 0x15B5800 Offset: 0x15B4200 VA: 0x1815B5800
	|-Dictionary<object, long>.set_Item
	|
	|-RVA: 0x15B57D0 Offset: 0x15B41D0 VA: 0x1815B57D0
	|-Dictionary<object, object>.set_Item
	|
	|-RVA: 0x15B5830 Offset: 0x15B4230 VA: 0x1815B5830
	|-Dictionary<object, Playable>.set_Item
	|
	|-RVA: 0x15B58D0 Offset: 0x15B42D0 VA: 0x1815B58D0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.set_Item
	|
	|-RVA: 0x15C56F0 Offset: 0x15C40F0 VA: 0x1815C56F0
	|-Dictionary<object, RaycastHit>.set_Item
	|
	|-RVA: 0x15C5670 Offset: 0x15C4070 VA: 0x1815C5670
	|-Dictionary<object, Rect>.set_Item
	|
	|-RVA: 0x15C5780 Offset: 0x15C4180 VA: 0x1815C5780
	|-Dictionary<object, ResourceLocator>.set_Item
	|
	|-RVA: 0x15C57C0 Offset: 0x15C41C0 VA: 0x1815C57C0
	|-Dictionary<object, float>.set_Item
	|
	|-RVA: 0x15C56B0 Offset: 0x15C40B0 VA: 0x1815C56B0
	|-Dictionary<object, StylePropertyValue>.set_Item
	|
	|-RVA: 0x15C5750 Offset: 0x15C4150 VA: 0x1815C5750
	|-Dictionary<object, TextureId>.set_Item
	|
	|-RVA: 0x15C57F0 Offset: 0x15C41F0 VA: 0x1815C57F0
	|-Dictionary<object, XPathNodeRef>.set_Item
	|
	|-RVA: 0x15D79D0 Offset: 0x15D63D0 VA: 0x1815D79D0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.set_Item
	|
	|-RVA: 0x15D7880 Offset: 0x15D6280 VA: 0x1815D7880
	|-Dictionary<object, InputControlLayout.ControlItem>.set_Item
	|
	|-RVA: 0x15D79A0 Offset: 0x15D63A0 VA: 0x1815D79A0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.set_Item
	|
	|-RVA: 0x15D77E0 Offset: 0x15D61E0 VA: 0x1815D77E0
	|-Dictionary<object, JsonParser.JsonValue>.set_Item
	|
	|-RVA: 0x15D7950 Offset: 0x15D6350 VA: 0x1815D7950
	|-Dictionary<object, LiquidVolume.MeshCache>.set_Item
	|
	|-RVA: 0x15D7850 Offset: 0x15D6250 VA: 0x1815D7850
	|-Dictionary<object, ObjectPool.DelayedStoreData>.set_Item
	|
	|-RVA: 0x15D7790 Offset: 0x15D6190 VA: 0x1815D7790
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.set_Item
	|
	|-RVA: 0x15E81F0 Offset: 0x15E6BF0 VA: 0x1815E81F0
	|-Dictionary<object, SVGDocument.ClipData>.set_Item
	|
	|-RVA: 0x15E8250 Offset: 0x15E6C50 VA: 0x1815E8250
	|-Dictionary<object, SVGDocument.MaskData>.set_Item
	|
	|-RVA: 0x15E82F0 Offset: 0x15E6CF0 VA: 0x1815E82F0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.set_Item
	|
	|-RVA: 0x15E81A0 Offset: 0x15E6BA0 VA: 0x1815E81A0
	|-Dictionary<object, SVGDocument.PatternData>.set_Item
	|
	|-RVA: 0x15E82B0 Offset: 0x15E6CB0 VA: 0x1815E82B0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.set_Item
	|
	|-RVA: 0x15E8220 Offset: 0x15E6C20 VA: 0x1815E8220
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.set_Item
	|
	|-RVA: 0x15E8280 Offset: 0x15E6C80 VA: 0x1815E8280
	|-Dictionary<Scene, object>.set_Item
	|
	|-RVA: 0x15FC4B0 Offset: 0x15FAEB0 VA: 0x1815FC4B0
	|-Dictionary<TerrainTileCoord, object>.set_Item
	|
	|-RVA: 0x15FC5B0 Offset: 0x15FAFB0 VA: 0x1815FC5B0
	|-Dictionary<ushort, object>.set_Item
	|
	|-RVA: 0x15FC510 Offset: 0x15FAF10 VA: 0x1815FC510
	|-Dictionary<ushort, RpcLink>.set_Item
	|
	|-RVA: 0x15FC4E0 Offset: 0x15FAEE0 VA: 0x1815FC4E0
	|-Dictionary<ushort, ushort>.set_Item
	|
	|-RVA: 0x15FC550 Offset: 0x15FAF50 VA: 0x1815FC550
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.set_Item
	|
	|-RVA: 0x15FC5E0 Offset: 0x15FAFE0 VA: 0x1815FC5E0
	|-Dictionary<uint, int>.set_Item
	|
	|-RVA: 0x15FC610 Offset: 0x15FB010 VA: 0x1815FC610
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.set_Item
	|
	|-RVA: 0x160E470 Offset: 0x160CE70 VA: 0x18160E470
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.set_Item
	|
	|-RVA: 0x160E3A0 Offset: 0x160CDA0 VA: 0x18160E3A0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.set_Item
	|
	|-RVA: 0x160E420 Offset: 0x160CE20 VA: 0x18160E420
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.set_Item
	|
	|-RVA: 0x160E3F0 Offset: 0x160CDF0 VA: 0x18160E3F0
	|-Dictionary<uint, object>.set_Item
	|
	|-RVA: 0x160E500 Offset: 0x160CF00 VA: 0x18160E500
	|-Dictionary<uint, RpcLinkType>.set_Item
	|
	|-RVA: 0x160E4C0 Offset: 0x160CEC0 VA: 0x18160E4C0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.set_Item
	|
	|-RVA: 0x160E530 Offset: 0x160CF30 VA: 0x18160E530
	|-Dictionary<ulong, object>.set_Item
	|
	|-RVA: 0x1626700 Offset: 0x1625100 VA: 0x181626700
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.set_Item
	|
	|-RVA: 0x16267E0 Offset: 0x16251E0 VA: 0x1816267E0
	|-Dictionary<Vector2Int, object>.set_Item
	|
	|-RVA: 0x16264D0 Offset: 0x1624ED0 VA: 0x1816264D0
	|-Dictionary<Vector3, Vector3>.set_Item
	|
	|-RVA: 0x16267A0 Offset: 0x16251A0 VA: 0x1816267A0
	|-Dictionary<Vector3Int, object>.set_Item
	|
	|-RVA: 0x1626750 Offset: 0x1625150 VA: 0x181626750
	|-Dictionary<XPathNodeRef, XPathNodeRef>.set_Item
	|
	|-RVA: 0x1626570 Offset: 0x1624F70 VA: 0x181626570
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x1626530 Offset: 0x1624F30 VA: 0x181626530
	|-Dictionary<Regex.CachedCodeEntryKey, object>.set_Item
	|
	|-RVA: 0x1630AA0 Offset: 0x162F4A0 VA: 0x181630AA0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.set_Item
	|
	|-RVA: 0x16309F0 Offset: 0x162F3F0 VA: 0x1816309F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.set_Item
	|
	|-RVA: 0x1630A30 Offset: 0x162F430 VA: 0x181630A30
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.set_Item
	|
	|-RVA: 0x1630A70 Offset: 0x162F470 VA: 0x181630A70
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED760 Offset: 0x14EC160 VA: 0x1814ED760
	|-Dictionary<KeyValuePair<object, object>, object>.Add
	|
	|-RVA: 0x14ED6E0 Offset: 0x14EC0E0 VA: 0x1814ED6E0
	|-Dictionary<StructMultiKey<object, object>, object>.Add
	|
	|-RVA: 0x14ED670 Offset: 0x14EC070 VA: 0x1814ED670
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Add
	|
	|-RVA: 0x14ED720 Offset: 0x14EC120 VA: 0x1814ED720
	|-Dictionary<ValueTuple<object, int>, object>.Add
	|
	|-RVA: 0x14ED7A0 Offset: 0x14EC1A0 VA: 0x1814ED7A0
	|-Dictionary<ValueTuple<object, object>, object>.Add
	|
	|-RVA: 0x14FCE20 Offset: 0x14FB820 VA: 0x1814FCE20
	|-Dictionary<Bounds, object>.Add
	|
	|-RVA: 0x14FCE90 Offset: 0x14FB890 VA: 0x1814FCE90
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Add
	|
	|-RVA: 0x14FCDC0 Offset: 0x14FB7C0 VA: 0x1814FCDC0
	|-Dictionary<CSteamID, int>.Add
	|
	|-RVA: 0x14FCE60 Offset: 0x14FB860 VA: 0x1814FCE60
	|-Dictionary<FullRank, object>.Add
	|
	|-RVA: 0x14FCD80 Offset: 0x14FB780 VA: 0x1814FCD80
	|-Dictionary<Guid, object>.Add
	|
	|-RVA: 0x14FCDF0 Offset: 0x14FB7F0 VA: 0x1814FCDF0
	|-Dictionary<HSteamNetConnection, int>.Add
	|
	|-RVA: 0x14FCD40 Offset: 0x14FB740 VA: 0x1814FCD40
	|-Dictionary<Hash128, int>.Add
	|
	|-RVA: 0x1512490 Offset: 0x1510E90 VA: 0x181512490
	|-Dictionary<Hash128, object>.Add
	|
	|-RVA: 0x15123B0 Offset: 0x1510DB0 VA: 0x1815123B0
	|-Dictionary<Int2, int>.Add
	|
	|-RVA: 0x1512460 Offset: 0x1510E60 VA: 0x181512460
	|-Dictionary<Int2, object>.Add
	|
	|-RVA: 0x15124D0 Offset: 0x1510ED0 VA: 0x1815124D0
	|-Dictionary<Int3, int>.Add
	|
	|-RVA: 0x1512430 Offset: 0x1510E30 VA: 0x181512430
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Add
	|
	|-RVA: 0x1512510 Offset: 0x1510F10 VA: 0x181512510
	|-Dictionary<int, TreeViewItemData<object>>.Add
	|
	|-RVA: 0x15123E0 Offset: 0x1510DE0 VA: 0x1815123E0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Add
	|
	|-RVA: 0x15261D0 Offset: 0x1524BD0 VA: 0x1815261D0
	|-Dictionary<int, bool>.Add
	|
	|-RVA: 0x15262D0 Offset: 0x1524CD0 VA: 0x1815262D0
	|-Dictionary<int, ByteEnum>.Add
	|
	|-RVA: 0x1526300 Offset: 0x1524D00 VA: 0x181526300
	|-Dictionary<int, CSteamID>.Add
	|
	|-RVA: 0x1526230 Offset: 0x1524C30 VA: 0x181526230
	|-Dictionary<int, HSteamNetConnection>.Add
	|
	|-RVA: 0x1526200 Offset: 0x1524C00 VA: 0x181526200
	|-Dictionary<int, short>.Add
	|
	|-RVA: 0x1526290 Offset: 0x1524C90 VA: 0x181526290
	|-Dictionary<int, Int3>.Add
	|
	|-RVA: 0x1526260 Offset: 0x1524C60 VA: 0x181526260
	|-Dictionary<int, int>.Add
	|
	|-RVA: 0x1536450 Offset: 0x1534E50 VA: 0x181536450
	|-Dictionary<int, Int32Enum>.Add
	|
	|-RVA: 0x1536340 Offset: 0x1534D40 VA: 0x181536340
	|-Dictionary<int, long>.Add
	|
	|-RVA: 0x1536480 Offset: 0x1534E80 VA: 0x181536480
	|-Dictionary<int, object>.Add
	|
	|-RVA: 0x15363D0 Offset: 0x1534DD0 VA: 0x1815363D0
	|-Dictionary<int, RenderInstancedDataLayout>.Add
	|
	|-RVA: 0x15363A0 Offset: 0x1534DA0 VA: 0x1815363A0
	|-Dictionary<int, float>.Add
	|
	|-RVA: 0x1536410 Offset: 0x1534E10 VA: 0x181536410
	|-Dictionary<int, TreeItem>.Add
	|
	|-RVA: 0x1536370 Offset: 0x1534D70 VA: 0x181536370
	|-Dictionary<int, uint>.Add
	|
	|-RVA: 0x15472C0 Offset: 0x1545CC0 VA: 0x1815472C0
	|-Dictionary<int, ulong>.Add
	|
	|-RVA: 0x1547290 Offset: 0x1545C90 VA: 0x181547290
	|-Dictionary<int, Vector2Int>.Add
	|
	|-RVA: 0x15471E0 Offset: 0x1545BE0 VA: 0x1815471E0
	|-Dictionary<int, Vector3>.Add
	|
	|-RVA: 0x1547250 Offset: 0x1545C50 VA: 0x181547250
	|-Dictionary<int, Vector4>.Add
	|
	|-RVA: 0x1547220 Offset: 0x1545C20 VA: 0x181547220
	|-Dictionary<int, Multipass.TransportIdData>.Add
	|
	|-RVA: 0x1547150 Offset: 0x1545B50 VA: 0x181547150
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Add
	|
	|-RVA: 0x1547190 Offset: 0x1545B90 VA: 0x181547190
	|-Dictionary<int, NetworkAnimator.StateChange>.Add
	|
	|-RVA: 0x1556C60 Offset: 0x1555660 VA: 0x181556C60
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Add
	|
	|-RVA: 0x1556D20 Offset: 0x1555720 VA: 0x181556D20
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Add
	|
	|-RVA: 0x1556BF0 Offset: 0x15555F0 VA: 0x181556BF0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Add
	|
	|-RVA: 0x1556D90 Offset: 0x1555790 VA: 0x181556D90
	|-Dictionary<Int32Enum, bool>.Add
	|
	|-RVA: 0x1556D60 Offset: 0x1555760 VA: 0x181556D60
	|-Dictionary<Int32Enum, int>.Add
	|
	|-RVA: 0x1556C30 Offset: 0x1555630 VA: 0x181556C30
	|-Dictionary<Int32Enum, Int32Enum>.Add
	|
	|-RVA: 0x1556CF0 Offset: 0x15556F0 VA: 0x181556CF0
	|-Dictionary<Int32Enum, object>.Add
	|
	|-RVA: 0x1569370 Offset: 0x1567D70 VA: 0x181569370
	|-Dictionary<long, ComputedStyle>.Add
	|
	|-RVA: 0x15693F0 Offset: 0x1567DF0 VA: 0x1815693F0
	|-Dictionary<long, object>.Add
	|
	|-RVA: 0x1569420 Offset: 0x1567E20 VA: 0x181569420
	|-Dictionary<IntPtr, object>.Add
	|
	|-RVA: 0x1569250 Offset: 0x1567C50 VA: 0x181569250
	|-Dictionary<InternedString, InternedString>.Add
	|
	|-RVA: 0x15692F0 Offset: 0x1567CF0 VA: 0x1815692F0
	|-Dictionary<InternedString, object>.Add
	|
	|-RVA: 0x15692A0 Offset: 0x1567CA0 VA: 0x1815692A0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Add
	|
	|-RVA: 0x1569330 Offset: 0x1567D30 VA: 0x181569330
	|-Dictionary<NativeAddr, object>.Add
	|
	|-RVA: 0x1591BA0 Offset: 0x15905A0 VA: 0x181591BA0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Add
	|
	|-RVA: 0x1591B00 Offset: 0x1590500 VA: 0x181591B00
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Add
	|
	|-RVA: 0x1591A50 Offset: 0x1590450 VA: 0x181591A50
	|-Dictionary<object, bool>.Add
	|
	|-RVA: 0x1591AB0 Offset: 0x15904B0 VA: 0x181591AB0
	|-Dictionary<object, Bounds>.Add
	|
	|-RVA: 0x1591B50 Offset: 0x1590550 VA: 0x181591B50
	|-Dictionary<object, Color>.Add
	|
	|-RVA: 0x1591BE0 Offset: 0x15905E0 VA: 0x181591BE0
	|-Dictionary<object, Color>.Add
	|
	|-RVA: 0x1591A80 Offset: 0x1590480 VA: 0x181591A80
	|-Dictionary<object, Color32>.Add
	|
	|-RVA: 0x15A4EC0 Offset: 0x15A38C0 VA: 0x1815A4EC0
	|-Dictionary<object, double>.Add
	|
	|-RVA: 0x15A4E90 Offset: 0x15A3890 VA: 0x1815A4E90
	|-Dictionary<object, int>.Add
	|
	|-RVA: 0x15A4E60 Offset: 0x15A3860 VA: 0x1815A4E60
	|-Dictionary<object, Int32Enum>.Add
	|
	|-RVA: 0x15A4F20 Offset: 0x15A3920 VA: 0x1815A4F20
	|-Dictionary<object, long>.Add
	|
	|-RVA: 0x15A4EF0 Offset: 0x15A38F0 VA: 0x1815A4EF0
	|-Dictionary<object, object>.Add
	|
	|-RVA: 0x15A4F50 Offset: 0x15A3950 VA: 0x1815A4F50
	|-Dictionary<object, Playable>.Add
	|
	|-RVA: 0x15A4E10 Offset: 0x15A3810 VA: 0x1815A4E10
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Add
	|
	|-RVA: 0x15B5AB0 Offset: 0x15B44B0 VA: 0x1815B5AB0
	|-Dictionary<object, RaycastHit>.Add
	|
	|-RVA: 0x15B5950 Offset: 0x15B4350 VA: 0x1815B5950
	|-Dictionary<object, Rect>.Add
	|
	|-RVA: 0x15B5A10 Offset: 0x15B4410 VA: 0x1815B5A10
	|-Dictionary<object, ResourceLocator>.Add
	|
	|-RVA: 0x15B5A80 Offset: 0x15B4480 VA: 0x1815B5A80
	|-Dictionary<object, float>.Add
	|
	|-RVA: 0x15B5990 Offset: 0x15B4390 VA: 0x1815B5990
	|-Dictionary<object, StylePropertyValue>.Add
	|
	|-RVA: 0x15B5A50 Offset: 0x15B4450 VA: 0x1815B5A50
	|-Dictionary<object, TextureId>.Add
	|
	|-RVA: 0x15B59D0 Offset: 0x15B43D0 VA: 0x1815B59D0
	|-Dictionary<object, XPathNodeRef>.Add
	|
	|-RVA: 0x15C5830 Offset: 0x15C4230 VA: 0x1815C5830
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Add
	|
	|-RVA: 0x15C5960 Offset: 0x15C4360 VA: 0x1815C5960
	|-Dictionary<object, InputControlLayout.ControlItem>.Add
	|
	|-RVA: 0x15C5930 Offset: 0x15C4330 VA: 0x1815C5930
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Add
	|
	|-RVA: 0x15C5A30 Offset: 0x15C4430 VA: 0x1815C5A30
	|-Dictionary<object, JsonParser.JsonValue>.Add
	|
	|-RVA: 0x15C5860 Offset: 0x15C4260 VA: 0x1815C5860
	|-Dictionary<object, LiquidVolume.MeshCache>.Add
	|
	|-RVA: 0x15C5900 Offset: 0x15C4300 VA: 0x1815C5900
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Add
	|
	|-RVA: 0x15C58B0 Offset: 0x15C42B0 VA: 0x1815C58B0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Add
	|
	|-RVA: 0x15D7AF0 Offset: 0x15D64F0 VA: 0x1815D7AF0
	|-Dictionary<object, SVGDocument.ClipData>.Add
	|
	|-RVA: 0x15D7B20 Offset: 0x15D6520 VA: 0x1815D7B20
	|-Dictionary<object, SVGDocument.MaskData>.Add
	|
	|-RVA: 0x15D7A00 Offset: 0x15D6400 VA: 0x1815D7A00
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Add
	|
	|-RVA: 0x15D7AA0 Offset: 0x15D64A0 VA: 0x1815D7AA0
	|-Dictionary<object, SVGDocument.PatternData>.Add
	|
	|-RVA: 0x15D7B50 Offset: 0x15D6550 VA: 0x1815D7B50
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Add
	|
	|-RVA: 0x15D7A70 Offset: 0x15D6470 VA: 0x1815D7A70
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Add
	|
	|-RVA: 0x15D7A40 Offset: 0x15D6440 VA: 0x1815D7A40
	|-Dictionary<Scene, object>.Add
	|
	|-RVA: 0x15E83C0 Offset: 0x15E6DC0 VA: 0x1815E83C0
	|-Dictionary<TerrainTileCoord, object>.Add
	|
	|-RVA: 0x15E8330 Offset: 0x15E6D30 VA: 0x1815E8330
	|-Dictionary<ushort, object>.Add
	|
	|-RVA: 0x15E8450 Offset: 0x15E6E50 VA: 0x1815E8450
	|-Dictionary<ushort, RpcLink>.Add
	|
	|-RVA: 0x15E8390 Offset: 0x15E6D90 VA: 0x1815E8390
	|-Dictionary<ushort, ushort>.Add
	|
	|-RVA: 0x15E83F0 Offset: 0x15E6DF0 VA: 0x1815E83F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Add
	|
	|-RVA: 0x15E8360 Offset: 0x15E6D60 VA: 0x1815E8360
	|-Dictionary<uint, int>.Add
	|
	|-RVA: 0x15E8490 Offset: 0x15E6E90 VA: 0x1815E8490
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Add
	|
	|-RVA: 0x15FC750 Offset: 0x15FB150 VA: 0x1815FC750
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Add
	|
	|-RVA: 0x15FC7D0 Offset: 0x15FB1D0 VA: 0x1815FC7D0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Add
	|
	|-RVA: 0x15FC700 Offset: 0x15FB100 VA: 0x1815FC700
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Add
	|
	|-RVA: 0x15FC6A0 Offset: 0x15FB0A0 VA: 0x1815FC6A0
	|-Dictionary<uint, object>.Add
	|
	|-RVA: 0x15FC6D0 Offset: 0x15FB0D0 VA: 0x1815FC6D0
	|-Dictionary<uint, RpcLinkType>.Add
	|
	|-RVA: 0x15FC660 Offset: 0x15FB060 VA: 0x1815FC660
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Add
	|
	|-RVA: 0x15FC7A0 Offset: 0x15FB1A0 VA: 0x1815FC7A0
	|-Dictionary<ulong, object>.Add
	|
	|-RVA: 0x160E560 Offset: 0x160CF60 VA: 0x18160E560
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Add
	|
	|-RVA: 0x160E5F0 Offset: 0x160CFF0 VA: 0x18160E5F0
	|-Dictionary<Vector2Int, object>.Add
	|
	|-RVA: 0x160E7B0 Offset: 0x160D1B0 VA: 0x18160E7B0
	|-Dictionary<Vector3, Vector3>.Add
	|
	|-RVA: 0x160E5B0 Offset: 0x160CFB0 VA: 0x18160E5B0
	|-Dictionary<Vector3Int, object>.Add
	|
	|-RVA: 0x160E810 Offset: 0x160D210 VA: 0x18160E810
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Add
	|
	|-RVA: 0x160E620 Offset: 0x160D020 VA: 0x18160E620
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0x160E860 Offset: 0x160D260 VA: 0x18160E860
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Add
	|
	|-RVA: 0x16268D0 Offset: 0x16252D0 VA: 0x1816268D0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Add
	|
	|-RVA: 0x1626850 Offset: 0x1625250 VA: 0x181626850
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Add
	|
	|-RVA: 0x1626890 Offset: 0x1625290 VA: 0x181626890
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Add
	|
	|-RVA: 0x1626910 Offset: 0x1625310 VA: 0x181626910
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F38A0 Offset: 0x14F22A0 VA: 0x1814F38A0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14F3800 Offset: 0x14F2200 VA: 0x1814F3800
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14F3940 Offset: 0x14F2340 VA: 0x1814F3940
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14F38F0 Offset: 0x14F22F0 VA: 0x1814F38F0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14F3850 Offset: 0x14F2250 VA: 0x1814F3850
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1505990 Offset: 0x1504390 VA: 0x181505990
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1505A40 Offset: 0x1504440 VA: 0x181505A40
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1505940 Offset: 0x1504340 VA: 0x181505940
	|-Dictionary<CSteamID, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15059F0 Offset: 0x15043F0 VA: 0x1815059F0
	|-Dictionary<FullRank, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15058F0 Offset: 0x15042F0 VA: 0x1815058F0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15058A0 Offset: 0x15042A0 VA: 0x1815058A0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1505AC0 Offset: 0x15044C0 VA: 0x181505AC0
	|-Dictionary<Hash128, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A530 Offset: 0x1518F30 VA: 0x18151A530
	|-Dictionary<Hash128, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A5E0 Offset: 0x1518FE0 VA: 0x18151A5E0
	|-Dictionary<Int2, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A6D0 Offset: 0x15190D0 VA: 0x18151A6D0
	|-Dictionary<Int2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A630 Offset: 0x1519030 VA: 0x18151A630
	|-Dictionary<Int3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A690 Offset: 0x1519090 VA: 0x18151A690
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A580 Offset: 0x1518F80 VA: 0x18151A580
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x151A4D0 Offset: 0x1518ED0 VA: 0x18151A4D0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C140 Offset: 0x152AB40 VA: 0x18152C140
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C190 Offset: 0x152AB90 VA: 0x18152C190
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C100 Offset: 0x152AB00 VA: 0x18152C100
	|-Dictionary<int, CSteamID>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C1E0 Offset: 0x152ABE0 VA: 0x18152C1E0
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C0B0 Offset: 0x152AAB0 VA: 0x18152C0B0
	|-Dictionary<int, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C230 Offset: 0x152AC30 VA: 0x18152C230
	|-Dictionary<int, Int3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x152C290 Offset: 0x152AC90 VA: 0x18152C290
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CB70 Offset: 0x153B570 VA: 0x18153CB70
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CC00 Offset: 0x153B600 VA: 0x18153CC00
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CBC0 Offset: 0x153B5C0 VA: 0x18153CBC0
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CB20 Offset: 0x153B520 VA: 0x18153CB20
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CAD0 Offset: 0x153B4D0 VA: 0x18153CAD0
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CC40 Offset: 0x153B640 VA: 0x18153CC40
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x153CC90 Offset: 0x153B690 VA: 0x18153CC90
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CED0 Offset: 0x154B8D0 VA: 0x18154CED0
	|-Dictionary<int, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CF10 Offset: 0x154B910 VA: 0x18154CF10
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CE70 Offset: 0x154B870 VA: 0x18154CE70
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CDD0 Offset: 0x154B7D0 VA: 0x18154CDD0
	|-Dictionary<int, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CFC0 Offset: 0x154B9C0 VA: 0x18154CFC0
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CE20 Offset: 0x154B820 VA: 0x18154CE20
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x154CF50 Offset: 0x154B950 VA: 0x18154CF50
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DA50 Offset: 0x155C450 VA: 0x18155DA50
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DC30 Offset: 0x155C630 VA: 0x18155DC30
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DBD0 Offset: 0x155C5D0 VA: 0x18155DBD0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DAF0 Offset: 0x155C4F0 VA: 0x18155DAF0
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DB80 Offset: 0x155C580 VA: 0x18155DB80
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DA00 Offset: 0x155C400 VA: 0x18155DA00
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155DB40 Offset: 0x155C540 VA: 0x18155DB40
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1571420 Offset: 0x156FE20 VA: 0x181571420
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1571510 Offset: 0x156FF10 VA: 0x181571510
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15713D0 Offset: 0x156FDD0 VA: 0x1815713D0
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1571370 Offset: 0x156FD70 VA: 0x181571370
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1571320 Offset: 0x156FD20 VA: 0x181571320
	|-Dictionary<InternedString, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1571560 Offset: 0x156FF60 VA: 0x181571560
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15714B0 Offset: 0x156FEB0 VA: 0x1815714B0
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A010 Offset: 0x1598A10 VA: 0x18159A010
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A060 Offset: 0x1598A60 VA: 0x18159A060
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A1D0 Offset: 0x1598BD0 VA: 0x18159A1D0
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1599FB0 Offset: 0x15989B0 VA: 0x181599FB0
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A170 Offset: 0x1598B70 VA: 0x18159A170
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A120 Offset: 0x1598B20 VA: 0x18159A120
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x159A0D0 Offset: 0x1598AD0 VA: 0x18159A0D0
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABD20 Offset: 0x15AA720 VA: 0x1815ABD20
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABBE0 Offset: 0x15AA5E0 VA: 0x1815ABBE0
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABCD0 Offset: 0x15AA6D0 VA: 0x1815ABCD0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABC30 Offset: 0x15AA630 VA: 0x1815ABC30
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABC80 Offset: 0x15AA680 VA: 0x1815ABC80
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABB90 Offset: 0x15AA590 VA: 0x1815ABB90
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15ABB20 Offset: 0x15AA520 VA: 0x1815ABB20
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BC040 Offset: 0x15BAA40 VA: 0x1815BC040
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBFA0 Offset: 0x15BA9A0 VA: 0x1815BBFA0
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBF00 Offset: 0x15BA900 VA: 0x1815BBF00
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBF50 Offset: 0x15BA950 VA: 0x1815BBF50
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBFF0 Offset: 0x15BA9F0 VA: 0x1815BBFF0
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBEB0 Offset: 0x15BA8B0 VA: 0x1815BBEB0
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15BBE60 Offset: 0x15BA860 VA: 0x1815BBE60
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCBD0 Offset: 0x15CB5D0 VA: 0x1815CCBD0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCC80 Offset: 0x15CB680 VA: 0x1815CCC80
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCB80 Offset: 0x15CB580 VA: 0x1815CCB80
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCD40 Offset: 0x15CB740 VA: 0x1815CCD40
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCC20 Offset: 0x15CB620 VA: 0x1815CCC20
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCB30 Offset: 0x15CB530 VA: 0x1815CCB30
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15CCAD0 Offset: 0x15CB4D0 VA: 0x1815CCAD0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE460 Offset: 0x15DCE60 VA: 0x1815DE460
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE410 Offset: 0x15DCE10 VA: 0x1815DE410
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE4B0 Offset: 0x15DCEB0 VA: 0x1815DE4B0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE500 Offset: 0x15DCF00 VA: 0x1815DE500
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE570 Offset: 0x15DCF70 VA: 0x1815DE570
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE610 Offset: 0x15DD010 VA: 0x1815DE610
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15DE5D0 Offset: 0x15DCFD0 VA: 0x1815DE5D0
	|-Dictionary<Scene, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F08F0 Offset: 0x15EF2F0 VA: 0x1815F08F0
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F0AB0 Offset: 0x15EF4B0 VA: 0x1815F0AB0
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F0A10 Offset: 0x15EF410 VA: 0x1815F0A10
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F08A0 Offset: 0x15EF2A0 VA: 0x1815F08A0
	|-Dictionary<ushort, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F0940 Offset: 0x15EF340 VA: 0x1815F0940
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F0A60 Offset: 0x15EF460 VA: 0x1815F0A60
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15F09B0 Offset: 0x15EF3B0 VA: 0x1815F09B0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603AA0 Offset: 0x16024A0 VA: 0x181603AA0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x16039A0 Offset: 0x16023A0 VA: 0x1816039A0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603B40 Offset: 0x1602540 VA: 0x181603B40
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603BA0 Offset: 0x16025A0 VA: 0x181603BA0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603B00 Offset: 0x1602500 VA: 0x181603B00
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603A00 Offset: 0x1602400 VA: 0x181603A00
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1603A50 Offset: 0x1602450 VA: 0x181603A50
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1618750 Offset: 0x1617150 VA: 0x181618750
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1618640 Offset: 0x1617040 VA: 0x181618640
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1618930 Offset: 0x1617330 VA: 0x181618930
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x16186F0 Offset: 0x16170F0 VA: 0x1816186F0
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x16185E0 Offset: 0x1616FE0 VA: 0x1816185E0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x16187C0 Offset: 0x16171C0 VA: 0x1816187C0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1618690 Offset: 0x1617090 VA: 0x181618690
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x162A4E0 Offset: 0x1628EE0 VA: 0x18162A4E0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x162A3F0 Offset: 0x1628DF0 VA: 0x18162A3F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x162A440 Offset: 0x1628E40 VA: 0x18162A440
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x162A490 Offset: 0x1628E90 VA: 0x18162A490
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F3BC0 Offset: 0x14F25C0 VA: 0x1814F3BC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14F3C90 Offset: 0x14F2690 VA: 0x1814F3C90
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14F39C0 Offset: 0x14F23C0 VA: 0x1814F39C0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14F3AF0 Offset: 0x14F24F0 VA: 0x1814F3AF0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14F3D60 Offset: 0x14F2760 VA: 0x1814F3D60
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505B10 Offset: 0x1504510 VA: 0x181505B10
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505E30 Offset: 0x1504830 VA: 0x181505E30
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505BE0 Offset: 0x15045E0 VA: 0x181505BE0
	|-Dictionary<CSteamID, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505D70 Offset: 0x1504770 VA: 0x181505D70
	|-Dictionary<FullRank, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505FF0 Offset: 0x15049F0 VA: 0x181505FF0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505F30 Offset: 0x1504930 VA: 0x181505F30
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1505CA0 Offset: 0x15046A0 VA: 0x181505CA0
	|-Dictionary<Hash128, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151AC30 Offset: 0x1519630 VA: 0x18151AC30
	|-Dictionary<Hash128, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151AAA0 Offset: 0x15194A0 VA: 0x18151AAA0
	|-Dictionary<Int2, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151A820 Offset: 0x1519220 VA: 0x18151A820
	|-Dictionary<Int2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151AB60 Offset: 0x1519560 VA: 0x18151AB60
	|-Dictionary<Int3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151A8E0 Offset: 0x15192E0 VA: 0x18151A8E0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151A720 Offset: 0x1519120 VA: 0x18151A720
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x151A9A0 Offset: 0x15193A0 VA: 0x18151A9A0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C3A0 Offset: 0x152ADA0 VA: 0x18152C3A0
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C2E0 Offset: 0x152ACE0 VA: 0x18152C2E0
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C520 Offset: 0x152AF20 VA: 0x18152C520
	|-Dictionary<int, CSteamID>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C460 Offset: 0x152AE60 VA: 0x18152C460
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C5E0 Offset: 0x152AFE0 VA: 0x18152C5E0
	|-Dictionary<int, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C6A0 Offset: 0x152B0A0 VA: 0x18152C6A0
	|-Dictionary<int, Int3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x152C790 Offset: 0x152B190 VA: 0x18152C790
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153CCE0 Offset: 0x153B6E0 VA: 0x18153CCE0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153D190 Offset: 0x153BB90 VA: 0x18153D190
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153D010 Offset: 0x153BA10 VA: 0x18153D010
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153CF40 Offset: 0x153B940 VA: 0x18153CF40
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153D0D0 Offset: 0x153BAD0 VA: 0x18153D0D0
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153CE60 Offset: 0x153B860 VA: 0x18153CE60
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x153CDA0 Offset: 0x153B7A0 VA: 0x18153CDA0
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D440 Offset: 0x154BE40 VA: 0x18154D440
	|-Dictionary<int, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D2C0 Offset: 0x154BCC0 VA: 0x18154D2C0
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D500 Offset: 0x154BF00 VA: 0x18154D500
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D000 Offset: 0x154BA00 VA: 0x18154D000
	|-Dictionary<int, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D380 Offset: 0x154BD80 VA: 0x18154D380
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D0D0 Offset: 0x154BAD0 VA: 0x18154D0D0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x154D1B0 Offset: 0x154BBB0 VA: 0x18154D1B0
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155DFD0 Offset: 0x155C9D0 VA: 0x18155DFD0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155DD50 Offset: 0x155C750 VA: 0x18155DD50
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155E230 Offset: 0x155CC30 VA: 0x18155E230
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155DE50 Offset: 0x155C850 VA: 0x18155DE50
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155DF10 Offset: 0x155C910 VA: 0x18155DF10
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155DC90 Offset: 0x155C690 VA: 0x18155DC90
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155E170 Offset: 0x155CB70 VA: 0x18155E170
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15715C0 Offset: 0x156FFC0 VA: 0x1815715C0
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1571A70 Offset: 0x1570470 VA: 0x181571A70
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1571800 Offset: 0x1570200 VA: 0x181571800
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15718C0 Offset: 0x15702C0 VA: 0x1815718C0
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1571B30 Offset: 0x1570530 VA: 0x181571B30
	|-Dictionary<InternedString, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1571720 Offset: 0x1570120 VA: 0x181571720
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15719A0 Offset: 0x15703A0 VA: 0x1815719A0
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A5E0 Offset: 0x1598FE0 VA: 0x18159A5E0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A4D0 Offset: 0x1598ED0 VA: 0x18159A4D0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A320 Offset: 0x1598D20 VA: 0x18159A320
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A220 Offset: 0x1598C20 VA: 0x18159A220
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A780 Offset: 0x1599180 VA: 0x18159A780
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A3F0 Offset: 0x1598DF0 VA: 0x18159A3F0
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x159A6C0 Offset: 0x15990C0 VA: 0x18159A6C0
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15ABD70 Offset: 0x15AA770 VA: 0x1815ABD70
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15ABFC0 Offset: 0x15AA9C0 VA: 0x1815ABFC0
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15AC1A0 Offset: 0x15AABA0 VA: 0x1815AC1A0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15ABE40 Offset: 0x15AA840 VA: 0x1815ABE40
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15ABF00 Offset: 0x15AA900 VA: 0x1815ABF00
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15AC260 Offset: 0x15AAC60 VA: 0x1815AC260
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15AC080 Offset: 0x15AAA80 VA: 0x1815AC080
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC4E0 Offset: 0x15BAEE0 VA: 0x1815BC4E0
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC610 Offset: 0x15BB010 VA: 0x1815BC610
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC0B0 Offset: 0x15BAAB0 VA: 0x1815BC0B0
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC410 Offset: 0x15BAE10 VA: 0x1815BC410
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC190 Offset: 0x15BAB90 VA: 0x1815BC190
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC350 Offset: 0x15BAD50 VA: 0x1815BC350
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15BC270 Offset: 0x15BAC70 VA: 0x1815BC270
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CD140 Offset: 0x15CBB40 VA: 0x1815CD140
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CD200 Offset: 0x15CBC00 VA: 0x1815CD200
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CD080 Offset: 0x15CBA80 VA: 0x1815CD080
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CD3F0 Offset: 0x15CBDF0 VA: 0x1815CD3F0
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CCF80 Offset: 0x15CB980 VA: 0x1815CCF80
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CCEC0 Offset: 0x15CB8C0 VA: 0x1815CCEC0
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15CCDC0 Offset: 0x15CB7C0 VA: 0x1815CCDC0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DEAE0 Offset: 0x15DD4E0 VA: 0x1815DEAE0
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DEA10 Offset: 0x15DD410 VA: 0x1815DEA10
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DE760 Offset: 0x15DD160 VA: 0x1815DE760
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DE900 Offset: 0x15DD300 VA: 0x1815DE900
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DE660 Offset: 0x15DD060 VA: 0x1815DE660
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DE840 Offset: 0x15DD240 VA: 0x1815DE840
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15DEBB0 Offset: 0x15DD5B0 VA: 0x1815DEBB0
	|-Dictionary<Scene, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0EB0 Offset: 0x15EF8B0 VA: 0x1815F0EB0
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0DF0 Offset: 0x15EF7F0 VA: 0x1815F0DF0
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0F70 Offset: 0x15EF970 VA: 0x1815F0F70
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0C30 Offset: 0x15EF630 VA: 0x1815F0C30
	|-Dictionary<ushort, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0B00 Offset: 0x15EF500 VA: 0x1815F0B00
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F1040 Offset: 0x15EFA40 VA: 0x1815F1040
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x15F0CF0 Offset: 0x15EF6F0 VA: 0x1815F0CF0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1603E60 Offset: 0x1602860 VA: 0x181603E60
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1603CA0 Offset: 0x16026A0 VA: 0x181603CA0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1603F60 Offset: 0x1602960 VA: 0x181603F60
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1603DA0 Offset: 0x16027A0 VA: 0x181603DA0
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1604060 Offset: 0x1602A60 VA: 0x181604060
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1604120 Offset: 0x1602B20 VA: 0x181604120
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1603BE0 Offset: 0x16025E0 VA: 0x181603BE0
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1618DA0 Offset: 0x16177A0 VA: 0x181618DA0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1618EC0 Offset: 0x16178C0 VA: 0x181618EC0
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1618F80 Offset: 0x1617980 VA: 0x181618F80
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1618A70 Offset: 0x1617470 VA: 0x181618A70
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1619080 Offset: 0x1617A80 VA: 0x181619080
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1618B40 Offset: 0x1617540 VA: 0x181618B40
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x16189A0 Offset: 0x16173A0 VA: 0x1816189A0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x162A5F0 Offset: 0x1628FF0 VA: 0x18162A5F0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x162A6C0 Offset: 0x16290C0 VA: 0x18162A6C0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x162A790 Offset: 0x1629190 VA: 0x18162A790
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x162A530 Offset: 0x1628F30 VA: 0x18162A530
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F42D0 Offset: 0x14F2CD0 VA: 0x1814F42D0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14F41D0 Offset: 0x14F2BD0 VA: 0x1814F41D0
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14F4070 Offset: 0x14F2A70 VA: 0x1814F4070
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14F3F70 Offset: 0x14F2970 VA: 0x1814F3F70
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14F3E70 Offset: 0x14F2870 VA: 0x1814F3E70
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1506460 Offset: 0x1504E60 VA: 0x181506460
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1506570 Offset: 0x1504F70 VA: 0x181506570
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15067C0 Offset: 0x15051C0 VA: 0x1815067C0
	|-Dictionary<CSteamID, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15062A0 Offset: 0x1504CA0 VA: 0x1815062A0
	|-Dictionary<FullRank, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15061A0 Offset: 0x1504BA0 VA: 0x1815061A0
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1506380 Offset: 0x1504D80 VA: 0x181506380
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15066C0 Offset: 0x15050C0 VA: 0x1815066C0
	|-Dictionary<Hash128, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151B370 Offset: 0x1519D70 VA: 0x18151B370
	|-Dictionary<Hash128, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151AE60 Offset: 0x1519860 VA: 0x18151AE60
	|-Dictionary<Int2, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151AD80 Offset: 0x1519780 VA: 0x18151AD80
	|-Dictionary<Int2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151B180 Offset: 0x1519B80 VA: 0x18151B180
	|-Dictionary<Int3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151B290 Offset: 0x1519C90 VA: 0x18151B290
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151AF40 Offset: 0x1519940 VA: 0x18151AF40
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x151B060 Offset: 0x1519A60 VA: 0x18151B060
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152CA90 Offset: 0x152B490 VA: 0x18152CA90
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152C9B0 Offset: 0x152B3B0 VA: 0x18152C9B0
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152CB70 Offset: 0x152B570 VA: 0x18152CB70
	|-Dictionary<int, CSteamID>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152CE40 Offset: 0x152B840 VA: 0x18152CE40
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152C8D0 Offset: 0x152B2D0 VA: 0x18152C8D0
	|-Dictionary<int, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152CC50 Offset: 0x152B650 VA: 0x18152CC50
	|-Dictionary<int, Int3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x152CD60 Offset: 0x152B760 VA: 0x18152CD60
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D5B0 Offset: 0x153BFB0 VA: 0x18153D5B0
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D4D0 Offset: 0x153BED0 VA: 0x18153D4D0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D870 Offset: 0x153C270 VA: 0x18153D870
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D2F0 Offset: 0x153BCF0 VA: 0x18153D2F0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D3F0 Offset: 0x153BDF0 VA: 0x18153D3F0
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D690 Offset: 0x153C090 VA: 0x18153D690
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x153D790 Offset: 0x153C190 VA: 0x18153D790
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154DB30 Offset: 0x154C530 VA: 0x18154DB30
	|-Dictionary<int, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154D630 Offset: 0x154C030 VA: 0x18154D630
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154D810 Offset: 0x154C210 VA: 0x18154D810
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154DC10 Offset: 0x154C610 VA: 0x18154DC10
	|-Dictionary<int, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154DA50 Offset: 0x154C450 VA: 0x18154DA50
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154D710 Offset: 0x154C110 VA: 0x18154D710
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x154D920 Offset: 0x154C320 VA: 0x18154D920
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E730 Offset: 0x155D130 VA: 0x18155E730
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E9D0 Offset: 0x155D3D0 VA: 0x18155E9D0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E610 Offset: 0x155D010 VA: 0x18155E610
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E370 Offset: 0x155CD70 VA: 0x18155E370
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E530 Offset: 0x155CF30 VA: 0x18155E530
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E450 Offset: 0x155CE50 VA: 0x18155E450
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155E8F0 Offset: 0x155D2F0 VA: 0x18155E8F0
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1571F70 Offset: 0x1570970 VA: 0x181571F70
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1571D90 Offset: 0x1570790 VA: 0x181571D90
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1572200 Offset: 0x1570C00 VA: 0x181572200
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1571C80 Offset: 0x1570680 VA: 0x181571C80
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1571E70 Offset: 0x1570870 VA: 0x181571E70
	|-Dictionary<InternedString, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15720F0 Offset: 0x1570AF0 VA: 0x1815720F0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15722E0 Offset: 0x1570CE0 VA: 0x1815722E0
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AC80 Offset: 0x1599680 VA: 0x18159AC80
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AF60 Offset: 0x1599960 VA: 0x18159AF60
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AE80 Offset: 0x1599880 VA: 0x18159AE80
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AB60 Offset: 0x1599560 VA: 0x18159AB60
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AA40 Offset: 0x1599440 VA: 0x18159AA40
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159AD80 Offset: 0x1599780 VA: 0x18159AD80
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x159A960 Offset: 0x1599360 VA: 0x18159A960
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC990 Offset: 0x15AB390 VA: 0x1815AC990
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC4C0 Offset: 0x15AAEC0 VA: 0x1815AC4C0
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC7D0 Offset: 0x15AB1D0 VA: 0x1815AC7D0
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC3E0 Offset: 0x15AADE0 VA: 0x1815AC3E0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC8B0 Offset: 0x15AB2B0 VA: 0x1815AC8B0
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC6D0 Offset: 0x15AB0D0 VA: 0x1815AC6D0
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15AC5A0 Offset: 0x15AAFA0 VA: 0x1815AC5A0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BCC10 Offset: 0x15BB610 VA: 0x1815BCC10
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BCA30 Offset: 0x15BB430 VA: 0x1815BCA30
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BCD60 Offset: 0x15BB760 VA: 0x1815BCD60
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BCB30 Offset: 0x15BB530 VA: 0x1815BCB30
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BC830 Offset: 0x15BB230 VA: 0x1815BC830
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BC750 Offset: 0x15BB150 VA: 0x1815BC750
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15BC930 Offset: 0x15BB330 VA: 0x1815BC930
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CDD30 Offset: 0x15CC730 VA: 0x1815CDD30
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CDB20 Offset: 0x15CC520 VA: 0x1815CDB20
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CD920 Offset: 0x15CC320 VA: 0x1815CD920
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CD6E0 Offset: 0x15CC0E0 VA: 0x1815CD6E0
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CD5C0 Offset: 0x15CBFC0 VA: 0x1815CD5C0
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CD840 Offset: 0x15CC240 VA: 0x1815CD840
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15CDA00 Offset: 0x15CC400 VA: 0x1815CDA00
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DEF60 Offset: 0x15DD960 VA: 0x1815DEF60
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DF040 Offset: 0x15DDA40 VA: 0x1815DF040
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DF200 Offset: 0x15DDC00 VA: 0x1815DF200
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DED10 Offset: 0x15DD710 VA: 0x1815DED10
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DEE40 Offset: 0x15DD840 VA: 0x1815DEE40
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DF310 Offset: 0x15DDD10 VA: 0x1815DF310
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15DF120 Offset: 0x15DDB20 VA: 0x1815DF120
	|-Dictionary<Scene, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1180 Offset: 0x15EFB80 VA: 0x1815F1180
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1260 Offset: 0x15EFC60 VA: 0x1815F1260
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1560 Offset: 0x15EFF60 VA: 0x1815F1560
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1340 Offset: 0x15EFD40 VA: 0x1815F1340
	|-Dictionary<ushort, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1420 Offset: 0x15EFE20 VA: 0x1815F1420
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1660 Offset: 0x15F0060 VA: 0x1815F1660
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15F1740 Offset: 0x15F0140 VA: 0x1815F1740
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604520 Offset: 0x1602F20 VA: 0x181604520
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604400 Offset: 0x1602E00 VA: 0x181604400
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604720 Offset: 0x1603120 VA: 0x181604720
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604840 Offset: 0x1603240 VA: 0x181604840
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604220 Offset: 0x1602C20 VA: 0x181604220
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604300 Offset: 0x1602D00 VA: 0x181604300
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1604640 Offset: 0x1603040 VA: 0x181604640
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x16197E0 Offset: 0x16181E0 VA: 0x1816197E0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1619200 Offset: 0x1617C00 VA: 0x181619200
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1619910 Offset: 0x1618310 VA: 0x181619910
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x1619A50 Offset: 0x1618450 VA: 0x181619A50
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x16196D0 Offset: 0x16180D0 VA: 0x1816196D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x16192E0 Offset: 0x1617CE0 VA: 0x1816192E0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x16195C0 Offset: 0x1617FC0 VA: 0x1816195C0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x162AB60 Offset: 0x1629560 VA: 0x18162AB60
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x162A960 Offset: 0x1629360 VA: 0x18162A960
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x162AA60 Offset: 0x1629460 VA: 0x18162AA60
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x162A880 Offset: 0x1629280 VA: 0x18162A880
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED7E0 Offset: 0x14EC1E0 VA: 0x1814ED7E0
	|-Dictionary<KeyValuePair<object, object>, object>.Clear
	|-Dictionary<StructMultiKey<object, object>, object>.Clear
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Clear
	|-Dictionary<ValueTuple<object, int>, object>.Clear
	|-Dictionary<ValueTuple<object, object>, object>.Clear
	|-Dictionary<Bounds, object>.Clear
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Clear
	|-Dictionary<CSteamID, int>.Clear
	|-Dictionary<FullRank, object>.Clear
	|-Dictionary<Guid, object>.Clear
	|-Dictionary<HSteamNetConnection, int>.Clear
	|-Dictionary<Hash128, int>.Clear
	|-Dictionary<Hash128, object>.Clear
	|-Dictionary<Int2, int>.Clear
	|-Dictionary<Int2, object>.Clear
	|-Dictionary<Int3, int>.Clear
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Clear
	|-Dictionary<int, TreeViewItemData<object>>.Clear
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Clear
	|-Dictionary<int, bool>.Clear
	|-Dictionary<int, ByteEnum>.Clear
	|-Dictionary<int, CSteamID>.Clear
	|-Dictionary<int, HSteamNetConnection>.Clear
	|-Dictionary<int, short>.Clear
	|-Dictionary<int, Int3>.Clear
	|-Dictionary<int, int>.Clear
	|-Dictionary<int, Int32Enum>.Clear
	|-Dictionary<int, long>.Clear
	|-Dictionary<int, object>.Clear
	|-Dictionary<int, RenderInstancedDataLayout>.Clear
	|-Dictionary<int, float>.Clear
	|-Dictionary<int, TreeItem>.Clear
	|-Dictionary<int, uint>.Clear
	|-Dictionary<int, ulong>.Clear
	|-Dictionary<int, Vector2Int>.Clear
	|-Dictionary<int, Vector3>.Clear
	|-Dictionary<int, Vector4>.Clear
	|-Dictionary<int, Multipass.TransportIdData>.Clear
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Clear
	|-Dictionary<int, NetworkAnimator.StateChange>.Clear
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Clear
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Clear
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Clear
	|-Dictionary<Int32Enum, bool>.Clear
	|-Dictionary<Int32Enum, int>.Clear
	|-Dictionary<Int32Enum, Int32Enum>.Clear
	|-Dictionary<Int32Enum, object>.Clear
	|-Dictionary<long, ComputedStyle>.Clear
	|-Dictionary<long, object>.Clear
	|-Dictionary<IntPtr, object>.Clear
	|-Dictionary<InternedString, InternedString>.Clear
	|-Dictionary<InternedString, object>.Clear
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Clear
	|-Dictionary<NativeAddr, object>.Clear
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Clear
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Clear
	|-Dictionary<object, bool>.Clear
	|-Dictionary<object, Bounds>.Clear
	|-Dictionary<object, Color>.Clear
	|-Dictionary<object, Color>.Clear
	|-Dictionary<object, Color32>.Clear
	|-Dictionary<object, double>.Clear
	|-Dictionary<object, int>.Clear
	|-Dictionary<object, Int32Enum>.Clear
	|-Dictionary<object, long>.Clear
	|-Dictionary<object, object>.Clear
	|-Dictionary<object, Playable>.Clear
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Clear
	|-Dictionary<object, RaycastHit>.Clear
	|-Dictionary<object, Rect>.Clear
	|-Dictionary<object, ResourceLocator>.Clear
	|-Dictionary<object, float>.Clear
	|-Dictionary<object, StylePropertyValue>.Clear
	|-Dictionary<object, TextureId>.Clear
	|-Dictionary<object, XPathNodeRef>.Clear
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Clear
	|-Dictionary<object, InputControlLayout.ControlItem>.Clear
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Clear
	|-Dictionary<object, JsonParser.JsonValue>.Clear
	|-Dictionary<object, LiquidVolume.MeshCache>.Clear
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Clear
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Clear
	|-Dictionary<object, SVGDocument.ClipData>.Clear
	|-Dictionary<object, SVGDocument.MaskData>.Clear
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Clear
	|-Dictionary<object, SVGDocument.PatternData>.Clear
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Clear
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Clear
	|-Dictionary<Scene, object>.Clear
	|-Dictionary<TerrainTileCoord, object>.Clear
	|-Dictionary<ushort, object>.Clear
	|-Dictionary<ushort, RpcLink>.Clear
	|-Dictionary<ushort, ushort>.Clear
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Clear
	|-Dictionary<uint, int>.Clear
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Clear
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Clear
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Clear
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Clear
	|-Dictionary<uint, object>.Clear
	|-Dictionary<uint, RpcLinkType>.Clear
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Clear
	|-Dictionary<ulong, object>.Clear
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Clear
	|-Dictionary<Vector2Int, object>.Clear
	|-Dictionary<Vector3, Vector3>.Clear
	|-Dictionary<Vector3Int, object>.Clear
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Clear
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Clear
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Clear
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Clear
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Clear
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED850 Offset: 0x14EC250 VA: 0x1814ED850
	|-Dictionary<KeyValuePair<object, object>, object>.ContainsKey
	|
	|-RVA: 0x14ED950 Offset: 0x14EC350 VA: 0x1814ED950
	|-Dictionary<StructMultiKey<object, object>, object>.ContainsKey
	|
	|-RVA: 0x14ED890 Offset: 0x14EC290 VA: 0x1814ED890
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.ContainsKey
	|
	|-RVA: 0x14ED910 Offset: 0x14EC310 VA: 0x1814ED910
	|-Dictionary<ValueTuple<object, int>, object>.ContainsKey
	|
	|-RVA: 0x14ED8D0 Offset: 0x14EC2D0 VA: 0x1814ED8D0
	|-Dictionary<ValueTuple<object, object>, object>.ContainsKey
	|
	|-RVA: 0x14FCF50 Offset: 0x14FB950 VA: 0x1814FCF50
	|-Dictionary<Bounds, object>.ContainsKey
	|
	|-RVA: 0x14FCF00 Offset: 0x14FB900 VA: 0x1814FCF00
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.ContainsKey
	|
	|-RVA: 0x14FD040 Offset: 0x14FBA40 VA: 0x1814FD040
	|-Dictionary<CSteamID, int>.ContainsKey
	|
	|-RVA: 0x14FD070 Offset: 0x14FBA70 VA: 0x1814FD070
	|-Dictionary<FullRank, object>.ContainsKey
	|
	|-RVA: 0x14FCFD0 Offset: 0x14FB9D0 VA: 0x1814FCFD0
	|-Dictionary<Guid, object>.ContainsKey
	|
	|-RVA: 0x14FD010 Offset: 0x14FBA10 VA: 0x1814FD010
	|-Dictionary<HSteamNetConnection, int>.ContainsKey
	|
	|-RVA: 0x14FCF90 Offset: 0x14FB990 VA: 0x1814FCF90
	|-Dictionary<Hash128, int>.ContainsKey
	|-Dictionary<Hash128, object>.ContainsKey
	|
	|-RVA: 0x15125C0 Offset: 0x1510FC0 VA: 0x1815125C0
	|-Dictionary<Int2, int>.ContainsKey
	|
	|-RVA: 0x15125F0 Offset: 0x1510FF0 VA: 0x1815125F0
	|-Dictionary<Int2, object>.ContainsKey
	|
	|-RVA: 0x1512650 Offset: 0x1511050 VA: 0x181512650
	|-Dictionary<Int3, int>.ContainsKey
	|
	|-RVA: 0x1512560 Offset: 0x1510F60 VA: 0x181512560
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.ContainsKey
	|-Dictionary<int, CSteamID>.ContainsKey
	|-Dictionary<int, Vector2Int>.ContainsKey
	|-Dictionary<int, Multipass.TransportIdData>.ContainsKey
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.ContainsKey
	|
	|-RVA: 0x1512590 Offset: 0x1510F90 VA: 0x181512590
	|-Dictionary<int, TreeViewItemData<object>>.ContainsKey
	|-Dictionary<int, NetworkAnimator.StateChange>.ContainsKey
	|
	|-RVA: 0x1512620 Offset: 0x1511020 VA: 0x181512620
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.ContainsKey
	|
	|-RVA: 0x1526330 Offset: 0x1524D30 VA: 0x181526330
	|-Dictionary<int, bool>.ContainsKey
	|-Dictionary<int, ByteEnum>.ContainsKey
	|-Dictionary<int, HSteamNetConnection>.ContainsKey
	|-Dictionary<int, short>.ContainsKey
	|-Dictionary<int, int>.ContainsKey
	|-Dictionary<int, Int32Enum>.ContainsKey
	|-Dictionary<int, float>.ContainsKey
	|-Dictionary<int, uint>.ContainsKey
	|
	|-RVA: 0x1526360 Offset: 0x1524D60 VA: 0x181526360
	|-Dictionary<int, Int3>.ContainsKey
	|-Dictionary<int, long>.ContainsKey
	|-Dictionary<int, object>.ContainsKey
	|-Dictionary<int, ulong>.ContainsKey
	|-Dictionary<int, Vector3>.ContainsKey
	|
	|-RVA: 0x15364E0 Offset: 0x1534EE0 VA: 0x1815364E0
	|-Dictionary<int, RenderInstancedDataLayout>.ContainsKey
	|-Dictionary<int, Vector4>.ContainsKey
	|
	|-RVA: 0x15364B0 Offset: 0x1534EB0 VA: 0x1815364B0
	|-Dictionary<int, TreeItem>.ContainsKey
	|
	|-RVA: 0x1556E50 Offset: 0x1555850 VA: 0x181556E50
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.ContainsKey
	|
	|-RVA: 0x1556DF0 Offset: 0x15557F0 VA: 0x181556DF0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.ContainsKey
	|-Dictionary<int, TextResourceManager.FontAssetRef>.ContainsKey
	|
	|-RVA: 0x1556DC0 Offset: 0x15557C0 VA: 0x181556DC0
	|-Dictionary<Int32Enum, bool>.ContainsKey
	|-Dictionary<Int32Enum, int>.ContainsKey
	|-Dictionary<Int32Enum, Int32Enum>.ContainsKey
	|
	|-RVA: 0x1556E20 Offset: 0x1555820 VA: 0x181556E20
	|-Dictionary<Int32Enum, object>.ContainsKey
	|
	|-RVA: 0x1569570 Offset: 0x1567F70 VA: 0x181569570
	|-Dictionary<long, ComputedStyle>.ContainsKey
	|
	|-RVA: 0x1569490 Offset: 0x1567E90 VA: 0x181569490
	|-Dictionary<long, object>.ContainsKey
	|
	|-RVA: 0x1569540 Offset: 0x1567F40 VA: 0x181569540
	|-Dictionary<IntPtr, object>.ContainsKey
	|
	|-RVA: 0x1569450 Offset: 0x1567E50 VA: 0x181569450
	|-Dictionary<InternedString, InternedString>.ContainsKey
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.ContainsKey
	|
	|-RVA: 0x15694C0 Offset: 0x1567EC0 VA: 0x1815694C0
	|-Dictionary<InternedString, object>.ContainsKey
	|
	|-RVA: 0x1569500 Offset: 0x1567F00 VA: 0x181569500
	|-Dictionary<NativeAddr, object>.ContainsKey
	|
	|-RVA: 0x1591C20 Offset: 0x1590620 VA: 0x181591C20
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.ContainsKey
	|-Dictionary<object, Color>.ContainsKey
	|-Dictionary<object, Playable>.ContainsKey
	|-Dictionary<object, Rect>.ContainsKey
	|-Dictionary<object, ResourceLocator>.ContainsKey
	|-Dictionary<object, StylePropertyValue>.ContainsKey
	|-Dictionary<object, XPathNodeRef>.ContainsKey
	|
	|-RVA: 0x1591C50 Offset: 0x1590650 VA: 0x181591C50
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.ContainsKey
	|-Dictionary<object, SVGDocument.PatternData>.ContainsKey
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.ContainsKey
	|
	|-RVA: 0x1591CB0 Offset: 0x15906B0 VA: 0x181591CB0
	|-Dictionary<object, bool>.ContainsKey
	|-Dictionary<object, Color32>.ContainsKey
	|-Dictionary<object, double>.ContainsKey
	|-Dictionary<object, int>.ContainsKey
	|-Dictionary<object, Int32Enum>.ContainsKey
	|-Dictionary<object, long>.ContainsKey
	|-Dictionary<object, object>.ContainsKey
	|-Dictionary<object, float>.ContainsKey
	|-Dictionary<object, TextureId>.ContainsKey
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.ContainsKey
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.ContainsKey
	|-Dictionary<object, ObjectPool.DelayedStoreData>.ContainsKey
	|-Dictionary<object, SVGDocument.ClipData>.ContainsKey
	|-Dictionary<object, SVGDocument.MaskData>.ContainsKey
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.ContainsKey
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.ContainsKey
	|
	|-RVA: 0x1591C80 Offset: 0x1590680 VA: 0x181591C80
	|-Dictionary<object, Bounds>.ContainsKey
	|-Dictionary<object, Color>.ContainsKey
	|-Dictionary<object, LiquidVolume.MeshCache>.ContainsKey
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.ContainsKey
	|
	|-RVA: 0x15A4F90 Offset: 0x15A3990 VA: 0x1815A4F90
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.ContainsKey
	|-Dictionary<object, RaycastHit>.ContainsKey
	|
	|-RVA: 0x15C5AA0 Offset: 0x15C44A0 VA: 0x1815C5AA0
	|-Dictionary<object, InputControlLayout.ControlItem>.ContainsKey
	|
	|-RVA: 0x15C5AD0 Offset: 0x15C44D0 VA: 0x1815C5AD0
	|-Dictionary<object, JsonParser.JsonValue>.ContainsKey
	|
	|-RVA: 0x15D7B90 Offset: 0x15D6590 VA: 0x1815D7B90
	|-Dictionary<Scene, object>.ContainsKey
	|
	|-RVA: 0x15E85D0 Offset: 0x15E6FD0 VA: 0x1815E85D0
	|-Dictionary<TerrainTileCoord, object>.ContainsKey
	|
	|-RVA: 0x15E85A0 Offset: 0x15E6FA0 VA: 0x1815E85A0
	|-Dictionary<ushort, object>.ContainsKey
	|
	|-RVA: 0x15E8600 Offset: 0x15E7000 VA: 0x1815E8600
	|-Dictionary<ushort, RpcLink>.ContainsKey
	|
	|-RVA: 0x15E8540 Offset: 0x15E6F40 VA: 0x1815E8540
	|-Dictionary<ushort, ushort>.ContainsKey
	|
	|-RVA: 0x15E84E0 Offset: 0x15E6EE0 VA: 0x1815E84E0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.ContainsKey
	|
	|-RVA: 0x15E8510 Offset: 0x15E6F10 VA: 0x1815E8510
	|-Dictionary<uint, int>.ContainsKey
	|
	|-RVA: 0x15E8570 Offset: 0x15E6F70 VA: 0x1815E8570
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.ContainsKey
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.ContainsKey
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.ContainsKey
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.ContainsKey
	|
	|-RVA: 0x15FC850 Offset: 0x15FB250 VA: 0x1815FC850
	|-Dictionary<uint, object>.ContainsKey
	|
	|-RVA: 0x15FC880 Offset: 0x15FB280 VA: 0x1815FC880
	|-Dictionary<uint, RpcLinkType>.ContainsKey
	|
	|-RVA: 0x15FC820 Offset: 0x15FB220 VA: 0x1815FC820
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.ContainsKey
	|
	|-RVA: 0x15FC8B0 Offset: 0x15FB2B0 VA: 0x1815FC8B0
	|-Dictionary<ulong, object>.ContainsKey
	|
	|-RVA: 0x160E8E0 Offset: 0x160D2E0 VA: 0x18160E8E0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.ContainsKey
	|
	|-RVA: 0x160E950 Offset: 0x160D350 VA: 0x18160E950
	|-Dictionary<Vector2Int, object>.ContainsKey
	|
	|-RVA: 0x160E8A0 Offset: 0x160D2A0 VA: 0x18160E8A0
	|-Dictionary<Vector3, Vector3>.ContainsKey
	|
	|-RVA: 0x160E910 Offset: 0x160D310 VA: 0x18160E910
	|-Dictionary<Vector3Int, object>.ContainsKey
	|
	|-RVA: 0x160EA70 Offset: 0x160D470 VA: 0x18160EA70
	|-Dictionary<XPathNodeRef, XPathNodeRef>.ContainsKey
	|
	|-RVA: 0x160E980 Offset: 0x160D380 VA: 0x18160E980
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	|
	|-RVA: 0x160EAB0 Offset: 0x160D4B0 VA: 0x18160EAB0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.ContainsKey
	|
	|-RVA: 0x1626970 Offset: 0x1625370 VA: 0x181626970
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.ContainsKey
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.ContainsKey
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.ContainsKey
	|
	|-RVA: 0x1626940 Offset: 0x1625340 VA: 0x181626940
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED990 Offset: 0x14EC390 VA: 0x1814ED990
	|-Dictionary<KeyValuePair<object, object>, object>.ContainsValue
	|-Dictionary<StructMultiKey<object, object>, object>.ContainsValue
	|-Dictionary<ValueTuple<object, int>, object>.ContainsValue
	|-Dictionary<ValueTuple<object, object>, object>.ContainsValue
	|-Dictionary<Guid, object>.ContainsValue
	|-Dictionary<Hash128, object>.ContainsValue
	|-Dictionary<InternedString, object>.ContainsValue
	|-Dictionary<Vector3Int, object>.ContainsValue
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.ContainsValue
	|
	|-RVA: 0x14EDAA0 Offset: 0x14EC4A0 VA: 0x1814EDAA0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.ContainsValue
	|
	|-RVA: 0x14FD0A0 Offset: 0x14FBAA0 VA: 0x1814FD0A0
	|-Dictionary<Bounds, object>.ContainsValue
	|-Dictionary<Regex.CachedCodeEntryKey, object>.ContainsValue
	|
	|-RVA: 0x14FD460 Offset: 0x14FBE60 VA: 0x1814FD460
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.ContainsValue
	|
	|-RVA: 0x14FD390 Offset: 0x14FBD90 VA: 0x1814FD390
	|-Dictionary<CSteamID, int>.ContainsValue
	|-Dictionary<Int2, int>.ContainsValue
	|
	|-RVA: 0x14FD280 Offset: 0x14FBC80 VA: 0x1814FD280
	|-Dictionary<FullRank, object>.ContainsValue
	|-Dictionary<Int2, object>.ContainsValue
	|-Dictionary<int, object>.ContainsValue
	|-Dictionary<Int32Enum, object>.ContainsValue
	|-Dictionary<long, object>.ContainsValue
	|-Dictionary<IntPtr, object>.ContainsValue
	|-Dictionary<object, object>.ContainsValue
	|-Dictionary<Scene, object>.ContainsValue
	|-Dictionary<TerrainTileCoord, object>.ContainsValue
	|-Dictionary<ushort, object>.ContainsValue
	|-Dictionary<uint, object>.ContainsValue
	|-Dictionary<ulong, object>.ContainsValue
	|-Dictionary<Vector2Int, object>.ContainsValue
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.ContainsValue
	|
	|-RVA: 0x14FD550 Offset: 0x14FBF50 VA: 0x1814FD550
	|-Dictionary<HSteamNetConnection, int>.ContainsValue
	|-Dictionary<int, int>.ContainsValue
	|-Dictionary<Int32Enum, int>.ContainsValue
	|-Dictionary<uint, int>.ContainsValue
	|
	|-RVA: 0x14FD1B0 Offset: 0x14FBBB0 VA: 0x1814FD1B0
	|-Dictionary<Hash128, int>.ContainsValue
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.ContainsValue
	|
	|-RVA: 0x15127A0 Offset: 0x15111A0 VA: 0x1815127A0
	|-Dictionary<Int3, int>.ContainsValue
	|
	|-RVA: 0x1512980 Offset: 0x1511380 VA: 0x181512980
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.ContainsValue
	|
	|-RVA: 0x1512870 Offset: 0x1511270 VA: 0x181512870
	|-Dictionary<int, TreeViewItemData<object>>.ContainsValue
	|
	|-RVA: 0x1512690 Offset: 0x1511090 VA: 0x181512690
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.ContainsValue
	|
	|-RVA: 0x15267C0 Offset: 0x15251C0 VA: 0x1815267C0
	|-Dictionary<int, bool>.ContainsValue
	|-Dictionary<Int32Enum, bool>.ContainsValue
	|
	|-RVA: 0x1526460 Offset: 0x1524E60 VA: 0x181526460
	|-Dictionary<int, ByteEnum>.ContainsValue
	|
	|-RVA: 0x1526390 Offset: 0x1524D90 VA: 0x181526390
	|-Dictionary<int, CSteamID>.ContainsValue
	|
	|-RVA: 0x1526630 Offset: 0x1525030 VA: 0x181526630
	|-Dictionary<int, HSteamNetConnection>.ContainsValue
	|
	|-RVA: 0x1526700 Offset: 0x1525100 VA: 0x181526700
	|-Dictionary<int, short>.ContainsValue
	|
	|-RVA: 0x1526520 Offset: 0x1524F20 VA: 0x181526520
	|-Dictionary<int, Int3>.ContainsValue
	|
	|-RVA: 0x15367C0 Offset: 0x15351C0 VA: 0x1815367C0
	|-Dictionary<int, Int32Enum>.ContainsValue
	|-Dictionary<Int32Enum, Int32Enum>.ContainsValue
	|
	|-RVA: 0x15366F0 Offset: 0x15350F0 VA: 0x1815366F0
	|-Dictionary<int, long>.ContainsValue
	|-Dictionary<object, long>.ContainsValue
	|
	|-RVA: 0x1536600 Offset: 0x1535000 VA: 0x181536600
	|-Dictionary<int, RenderInstancedDataLayout>.ContainsValue
	|
	|-RVA: 0x1536960 Offset: 0x1535360 VA: 0x181536960
	|-Dictionary<int, float>.ContainsValue
	|
	|-RVA: 0x1536510 Offset: 0x1534F10 VA: 0x181536510
	|-Dictionary<int, TreeItem>.ContainsValue
	|
	|-RVA: 0x1536890 Offset: 0x1535290 VA: 0x181536890
	|-Dictionary<int, uint>.ContainsValue
	|
	|-RVA: 0x15477A0 Offset: 0x15461A0 VA: 0x1815477A0
	|-Dictionary<int, ulong>.ContainsValue
	|
	|-RVA: 0x15472F0 Offset: 0x1545CF0 VA: 0x1815472F0
	|-Dictionary<int, Vector2Int>.ContainsValue
	|
	|-RVA: 0x1547870 Offset: 0x1546270 VA: 0x181547870
	|-Dictionary<int, Vector3>.ContainsValue
	|
	|-RVA: 0x15474F0 Offset: 0x1545EF0 VA: 0x1815474F0
	|-Dictionary<int, Vector4>.ContainsValue
	|
	|-RVA: 0x15475E0 Offset: 0x1545FE0 VA: 0x1815475E0
	|-Dictionary<int, Multipass.TransportIdData>.ContainsValue
	|
	|-RVA: 0x15476B0 Offset: 0x15460B0 VA: 0x1815476B0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.ContainsValue
	|
	|-RVA: 0x15473C0 Offset: 0x1545DC0 VA: 0x1815473C0
	|-Dictionary<int, NetworkAnimator.StateChange>.ContainsValue
	|
	|-RVA: 0x1556F90 Offset: 0x1555990 VA: 0x181556F90
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.ContainsValue
	|
	|-RVA: 0x1557140 Offset: 0x1555B40 VA: 0x181557140
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.ContainsValue
	|
	|-RVA: 0x1556E80 Offset: 0x1555880 VA: 0x181556E80
	|-Dictionary<int, TextResourceManager.FontAssetRef>.ContainsValue
	|
	|-RVA: 0x1569690 Offset: 0x1568090 VA: 0x181569690
	|-Dictionary<long, ComputedStyle>.ContainsValue
	|
	|-RVA: 0x1569810 Offset: 0x1568210 VA: 0x181569810
	|-Dictionary<InternedString, InternedString>.ContainsValue
	|
	|-RVA: 0x15695A0 Offset: 0x1567FA0 VA: 0x1815695A0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.ContainsValue
	|
	|-RVA: 0x1569900 Offset: 0x1568300 VA: 0x181569900
	|-Dictionary<NativeAddr, object>.ContainsValue
	|
	|-RVA: 0x1591DF0 Offset: 0x15907F0 VA: 0x181591DF0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.ContainsValue
	|
	|-RVA: 0x1592090 Offset: 0x1590A90 VA: 0x181592090
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.ContainsValue
	|
	|-RVA: 0x1591EE0 Offset: 0x15908E0 VA: 0x181591EE0
	|-Dictionary<object, bool>.ContainsValue
	|
	|-RVA: 0x1592290 Offset: 0x1590C90 VA: 0x181592290
	|-Dictionary<object, Bounds>.ContainsValue
	|
	|-RVA: 0x1591CE0 Offset: 0x15906E0 VA: 0x181591CE0
	|-Dictionary<object, Color>.ContainsValue
	|
	|-RVA: 0x1591FA0 Offset: 0x15909A0 VA: 0x181591FA0
	|-Dictionary<object, Color>.ContainsValue
	|
	|-RVA: 0x15921C0 Offset: 0x1590BC0 VA: 0x1815921C0
	|-Dictionary<object, Color32>.ContainsValue
	|
	|-RVA: 0x15A5180 Offset: 0x15A3B80 VA: 0x1815A5180
	|-Dictionary<object, double>.ContainsValue
	|
	|-RVA: 0x15A50B0 Offset: 0x15A3AB0 VA: 0x1815A50B0
	|-Dictionary<object, int>.ContainsValue
	|
	|-RVA: 0x15A53A0 Offset: 0x15A3DA0 VA: 0x1815A53A0
	|-Dictionary<object, Int32Enum>.ContainsValue
	|
	|-RVA: 0x15A4FC0 Offset: 0x15A39C0 VA: 0x1815A4FC0
	|-Dictionary<object, Playable>.ContainsValue
	|
	|-RVA: 0x15A5270 Offset: 0x15A3C70 VA: 0x1815A5270
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.ContainsValue
	|
	|-RVA: 0x15B5FA0 Offset: 0x15B49A0 VA: 0x1815B5FA0
	|-Dictionary<object, RaycastHit>.ContainsValue
	|
	|-RVA: 0x15B5DE0 Offset: 0x15B47E0 VA: 0x1815B5DE0
	|-Dictionary<object, Rect>.ContainsValue
	|
	|-RVA: 0x15B5CF0 Offset: 0x15B46F0 VA: 0x1815B5CF0
	|-Dictionary<object, ResourceLocator>.ContainsValue
	|
	|-RVA: 0x15B5B10 Offset: 0x15B4510 VA: 0x1815B5B10
	|-Dictionary<object, float>.ContainsValue
	|
	|-RVA: 0x15B5C00 Offset: 0x15B4600 VA: 0x1815B5C00
	|-Dictionary<object, StylePropertyValue>.ContainsValue
	|
	|-RVA: 0x15B5ED0 Offset: 0x15B48D0 VA: 0x1815B5ED0
	|-Dictionary<object, TextureId>.ContainsValue
	|
	|-RVA: 0x15B60E0 Offset: 0x15B4AE0 VA: 0x1815B60E0
	|-Dictionary<object, XPathNodeRef>.ContainsValue
	|
	|-RVA: 0x15C5D70 Offset: 0x15C4770 VA: 0x1815C5D70
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.ContainsValue
	|
	|-RVA: 0x15C5F10 Offset: 0x15C4910 VA: 0x1815C5F10
	|-Dictionary<object, InputControlLayout.ControlItem>.ContainsValue
	|
	|-RVA: 0x15C6110 Offset: 0x15C4B10 VA: 0x1815C6110
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.ContainsValue
	|
	|-RVA: 0x15C5B00 Offset: 0x15C4500 VA: 0x1815C5B00
	|-Dictionary<object, JsonParser.JsonValue>.ContainsValue
	|
	|-RVA: 0x15C5C60 Offset: 0x15C4660 VA: 0x1815C5C60
	|-Dictionary<object, LiquidVolume.MeshCache>.ContainsValue
	|
	|-RVA: 0x15C5E40 Offset: 0x15C4840 VA: 0x1815C5E40
	|-Dictionary<object, ObjectPool.DelayedStoreData>.ContainsValue
	|
	|-RVA: 0x15C61E0 Offset: 0x15C4BE0 VA: 0x1815C61E0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.ContainsValue
	|
	|-RVA: 0x15D7BC0 Offset: 0x15D65C0 VA: 0x1815D7BC0
	|-Dictionary<object, SVGDocument.ClipData>.ContainsValue
	|
	|-RVA: 0x15D7C90 Offset: 0x15D6690 VA: 0x1815D7C90
	|-Dictionary<object, SVGDocument.MaskData>.ContainsValue
	|
	|-RVA: 0x15D7D60 Offset: 0x15D6760 VA: 0x1815D7D60
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.ContainsValue
	|
	|-RVA: 0x15D8030 Offset: 0x15D6A30 VA: 0x1815D8030
	|-Dictionary<object, SVGDocument.PatternData>.ContainsValue
	|
	|-RVA: 0x15D7F20 Offset: 0x15D6920 VA: 0x1815D7F20
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.ContainsValue
	|
	|-RVA: 0x15D7E50 Offset: 0x15D6850 VA: 0x1815D7E50
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.ContainsValue
	|
	|-RVA: 0x15E8630 Offset: 0x15E7030 VA: 0x1815E8630
	|-Dictionary<ushort, RpcLink>.ContainsValue
	|
	|-RVA: 0x15E8830 Offset: 0x15E7230 VA: 0x1815E8830
	|-Dictionary<ushort, ushort>.ContainsValue
	|
	|-RVA: 0x15E88F0 Offset: 0x15E72F0 VA: 0x1815E88F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.ContainsValue
	|
	|-RVA: 0x15E8720 Offset: 0x15E7120 VA: 0x1815E8720
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.ContainsValue
	|
	|-RVA: 0x15FC9B0 Offset: 0x15FB3B0 VA: 0x1815FC9B0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.ContainsValue
	|
	|-RVA: 0x15FCBD0 Offset: 0x15FB5D0 VA: 0x1815FCBD0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.ContainsValue
	|
	|-RVA: 0x15FCAC0 Offset: 0x15FB4C0 VA: 0x1815FCAC0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.ContainsValue
	|
	|-RVA: 0x15FC8E0 Offset: 0x15FB2E0 VA: 0x1815FC8E0
	|-Dictionary<uint, RpcLinkType>.ContainsValue
	|
	|-RVA: 0x15FCCE0 Offset: 0x15FB6E0 VA: 0x1815FCCE0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.ContainsValue
	|
	|-RVA: 0x160F1C0 Offset: 0x160DBC0 VA: 0x18160F1C0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.ContainsValue
	|
	|-RVA: 0x160EAF0 Offset: 0x160D4F0 VA: 0x18160EAF0
	|-Dictionary<Vector3, Vector3>.ContainsValue
	|
	|-RVA: 0x160EC00 Offset: 0x160D600 VA: 0x18160EC00
	|-Dictionary<XPathNodeRef, XPathNodeRef>.ContainsValue
	|
	|-RVA: 0x160ECF0 Offset: 0x160D6F0 VA: 0x18160ECF0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	|
	|-RVA: 0x16269B0 Offset: 0x16253B0 VA: 0x1816269B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EDBF0 Offset: 0x14EC5F0 VA: 0x1814EDBF0
	|-Dictionary<KeyValuePair<object, object>, object>.CopyTo
	|-Dictionary<StructMultiKey<object, object>, object>.CopyTo
	|-Dictionary<ValueTuple<object, int>, object>.CopyTo
	|-Dictionary<ValueTuple<object, object>, object>.CopyTo
	|-Dictionary<InternedString, object>.CopyTo
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.CopyTo
	|
	|-RVA: 0x14EDDA0 Offset: 0x14EC7A0 VA: 0x1814EDDA0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.CopyTo
	|
	|-RVA: 0x14FDCA0 Offset: 0x14FC6A0 VA: 0x1814FDCA0
	|-Dictionary<Bounds, object>.CopyTo
	|
	|-RVA: 0x14FD950 Offset: 0x14FC350 VA: 0x1814FD950
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.CopyTo
	|
	|-RVA: 0x14FDFE0 Offset: 0x14FC9E0 VA: 0x1814FDFE0
	|-Dictionary<CSteamID, int>.CopyTo
	|-Dictionary<Int2, int>.CopyTo
	|
	|-RVA: 0x14FDE60 Offset: 0x14FC860 VA: 0x1814FDE60
	|-Dictionary<FullRank, object>.CopyTo
	|-Dictionary<Int2, object>.CopyTo
	|-Dictionary<TerrainTileCoord, object>.CopyTo
	|-Dictionary<Vector2Int, object>.CopyTo
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.CopyTo
	|
	|-RVA: 0x14FD620 Offset: 0x14FC020 VA: 0x1814FD620
	|-Dictionary<Guid, object>.CopyTo
	|-Dictionary<Hash128, object>.CopyTo
	|
	|-RVA: 0x14FDB50 Offset: 0x14FC550 VA: 0x1814FDB50
	|-Dictionary<HSteamNetConnection, int>.CopyTo
	|
	|-RVA: 0x14FD7D0 Offset: 0x14FC1D0 VA: 0x1814FD7D0
	|-Dictionary<Hash128, int>.CopyTo
	|
	|-RVA: 0x1512BE0 Offset: 0x15115E0 VA: 0x181512BE0
	|-Dictionary<Int3, int>.CopyTo
	|
	|-RVA: 0x1512D50 Offset: 0x1511750 VA: 0x181512D50
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.CopyTo
	|-Dictionary<int, CSteamID>.CopyTo
	|-Dictionary<int, Vector2Int>.CopyTo
	|-Dictionary<int, Multipass.TransportIdData>.CopyTo
	|-Dictionary<uint, RpcLinkType>.CopyTo
	|
	|-RVA: 0x1512EC0 Offset: 0x15118C0 VA: 0x181512EC0
	|-Dictionary<int, TreeViewItemData<object>>.CopyTo
	|
	|-RVA: 0x1512A50 Offset: 0x1511450 VA: 0x181512A50
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.CopyTo
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.CopyTo
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x1526880 Offset: 0x1525280 VA: 0x181526880
	|-Dictionary<int, bool>.CopyTo
	|-Dictionary<int, ByteEnum>.CopyTo
	|-Dictionary<Int32Enum, bool>.CopyTo
	|
	|-RVA: 0x15269D0 Offset: 0x15253D0 VA: 0x1815269D0
	|-Dictionary<int, HSteamNetConnection>.CopyTo
	|-Dictionary<int, int>.CopyTo
	|-Dictionary<int, Int32Enum>.CopyTo
	|-Dictionary<int, uint>.CopyTo
	|-Dictionary<Int32Enum, int>.CopyTo
	|-Dictionary<Int32Enum, Int32Enum>.CopyTo
	|-Dictionary<uint, int>.CopyTo
	|
	|-RVA: 0x1526C90 Offset: 0x1525690 VA: 0x181526C90
	|-Dictionary<int, short>.CopyTo
	|
	|-RVA: 0x1526B20 Offset: 0x1525520 VA: 0x181526B20
	|-Dictionary<int, Int3>.CopyTo
	|-Dictionary<int, Vector3>.CopyTo
	|
	|-RVA: 0x1536BD0 Offset: 0x15355D0 VA: 0x181536BD0
	|-Dictionary<int, long>.CopyTo
	|-Dictionary<int, ulong>.CopyTo
	|
	|-RVA: 0x1537030 Offset: 0x1535A30 VA: 0x181537030
	|-Dictionary<int, object>.CopyTo
	|-Dictionary<Int32Enum, object>.CopyTo
	|-Dictionary<uint, object>.CopyTo
	|
	|-RVA: 0x1536A50 Offset: 0x1535450 VA: 0x181536A50
	|-Dictionary<int, RenderInstancedDataLayout>.CopyTo
	|-Dictionary<int, Vector4>.CopyTo
	|
	|-RVA: 0x1536D30 Offset: 0x1535730 VA: 0x181536D30
	|-Dictionary<int, float>.CopyTo
	|
	|-RVA: 0x1536E80 Offset: 0x1535880 VA: 0x181536E80
	|-Dictionary<int, TreeItem>.CopyTo
	|
	|-RVA: 0x1547980 Offset: 0x1546380 VA: 0x181547980
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.CopyTo
	|
	|-RVA: 0x1547AF0 Offset: 0x15464F0 VA: 0x181547AF0
	|-Dictionary<int, NetworkAnimator.StateChange>.CopyTo
	|
	|-RVA: 0x1557250 Offset: 0x1555C50 VA: 0x181557250
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.CopyTo
	|
	|-RVA: 0x1557440 Offset: 0x1555E40 VA: 0x181557440
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.CopyTo
	|-Dictionary<int, TextResourceManager.FontAssetRef>.CopyTo
	|
	|-RVA: 0x1569BD0 Offset: 0x15685D0 VA: 0x181569BD0
	|-Dictionary<long, ComputedStyle>.CopyTo
	|
	|-RVA: 0x1569E10 Offset: 0x1568810 VA: 0x181569E10
	|-Dictionary<long, object>.CopyTo
	|-Dictionary<IntPtr, object>.CopyTo
	|-Dictionary<ulong, object>.CopyTo
	|
	|-RVA: 0x1569A10 Offset: 0x1568410 VA: 0x181569A10
	|-Dictionary<InternedString, InternedString>.CopyTo
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.CopyTo
	|-Dictionary<XPathNodeRef, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x1569F90 Offset: 0x1568990 VA: 0x181569F90
	|-Dictionary<NativeAddr, object>.CopyTo
	|
	|-RVA: 0x1592A00 Offset: 0x1591400 VA: 0x181592A00
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.CopyTo
	|
	|-RVA: 0x1592BB0 Offset: 0x15915B0 VA: 0x181592BB0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.CopyTo
	|-Dictionary<object, SVGDocument.PatternData>.CopyTo
	|
	|-RVA: 0x1592520 Offset: 0x1590F20 VA: 0x181592520
	|-Dictionary<object, bool>.CopyTo
	|
	|-RVA: 0x1592D80 Offset: 0x1591780 VA: 0x181592D80
	|-Dictionary<object, Bounds>.CopyTo
	|
	|-RVA: 0x1592850 Offset: 0x1591250 VA: 0x181592850
	|-Dictionary<object, Color>.CopyTo
	|-Dictionary<object, LiquidVolume.MeshCache>.CopyTo
	|
	|-RVA: 0x15926A0 Offset: 0x15910A0 VA: 0x1815926A0
	|-Dictionary<object, Color>.CopyTo
	|-Dictionary<object, Playable>.CopyTo
	|-Dictionary<object, Rect>.CopyTo
	|
	|-RVA: 0x15923A0 Offset: 0x1590DA0 VA: 0x1815923A0
	|-Dictionary<object, Color32>.CopyTo
	|-Dictionary<object, TextureId>.CopyTo
	|
	|-RVA: 0x15A5470 Offset: 0x15A3E70 VA: 0x1815A5470
	|-Dictionary<object, double>.CopyTo
	|
	|-RVA: 0x15A5AE0 Offset: 0x15A44E0 VA: 0x1815A5AE0
	|-Dictionary<object, int>.CopyTo
	|-Dictionary<object, Int32Enum>.CopyTo
	|
	|-RVA: 0x15A55F0 Offset: 0x15A3FF0 VA: 0x1815A55F0
	|-Dictionary<object, long>.CopyTo
	|
	|-RVA: 0x15A5960 Offset: 0x15A4360 VA: 0x1815A5960
	|-Dictionary<object, object>.CopyTo
	|
	|-RVA: 0x15A5770 Offset: 0x15A4170 VA: 0x1815A5770
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.CopyTo
	|
	|-RVA: 0x15B6500 Offset: 0x15B4F00 VA: 0x1815B6500
	|-Dictionary<object, RaycastHit>.CopyTo
	|
	|-RVA: 0x15B61D0 Offset: 0x15B4BD0 VA: 0x1815B61D0
	|-Dictionary<object, ResourceLocator>.CopyTo
	|-Dictionary<object, StylePropertyValue>.CopyTo
	|-Dictionary<object, XPathNodeRef>.CopyTo
	|
	|-RVA: 0x15B6380 Offset: 0x15B4D80 VA: 0x1815B6380
	|-Dictionary<object, float>.CopyTo
	|
	|-RVA: 0x15C64A0 Offset: 0x15C4EA0 VA: 0x1815C64A0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.CopyTo
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.CopyTo
	|-Dictionary<object, ObjectPool.DelayedStoreData>.CopyTo
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.CopyTo
	|
	|-RVA: 0x15C6620 Offset: 0x15C5020 VA: 0x1815C6620
	|-Dictionary<object, InputControlLayout.ControlItem>.CopyTo
	|
	|-RVA: 0x15C6890 Offset: 0x15C5290 VA: 0x1815C6890
	|-Dictionary<object, JsonParser.JsonValue>.CopyTo
	|
	|-RVA: 0x15C62F0 Offset: 0x15C4CF0 VA: 0x1815C62F0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.CopyTo
	|
	|-RVA: 0x15D8640 Offset: 0x15D7040 VA: 0x1815D8640
	|-Dictionary<object, SVGDocument.ClipData>.CopyTo
	|
	|-RVA: 0x15D84C0 Offset: 0x15D6EC0 VA: 0x1815D84C0
	|-Dictionary<object, SVGDocument.MaskData>.CopyTo
	|
	|-RVA: 0x15D8160 Offset: 0x15D6B60 VA: 0x1815D8160
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.CopyTo
	|
	|-RVA: 0x15D82F0 Offset: 0x15D6CF0 VA: 0x1815D82F0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.CopyTo
	|
	|-RVA: 0x15D87C0 Offset: 0x15D71C0 VA: 0x1815D87C0
	|-Dictionary<Scene, object>.CopyTo
	|
	|-RVA: 0x15E8EC0 Offset: 0x15E78C0 VA: 0x1815E8EC0
	|-Dictionary<ushort, object>.CopyTo
	|
	|-RVA: 0x15E8D40 Offset: 0x15E7740 VA: 0x1815E8D40
	|-Dictionary<ushort, RpcLink>.CopyTo
	|
	|-RVA: 0x15E8BF0 Offset: 0x15E75F0 VA: 0x1815E8BF0
	|-Dictionary<ushort, ushort>.CopyTo
	|
	|-RVA: 0x15E8A30 Offset: 0x15E7430 VA: 0x1815E8A30
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.CopyTo
	|
	|-RVA: 0x15FCDD0 Offset: 0x15FB7D0 VA: 0x1815FCDD0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.CopyTo
	|
	|-RVA: 0x160F800 Offset: 0x160E200 VA: 0x18160F800
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.CopyTo
	|
	|-RVA: 0x160F660 Offset: 0x160E060 VA: 0x18160F660
	|-Dictionary<Vector3, Vector3>.CopyTo
	|
	|-RVA: 0x160F2F0 Offset: 0x160DCF0 VA: 0x18160F2F0
	|-Dictionary<Vector3Int, object>.CopyTo
	|
	|-RVA: 0x160F9E0 Offset: 0x160E3E0 VA: 0x18160F9E0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x160F4A0 Offset: 0x160DEA0 VA: 0x18160F4A0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.CopyTo
	|
	|-RVA: 0x1626A80 Offset: 0x1625480 VA: 0x181626A80
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.CopyTo
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EF560 Offset: 0x14EDF60 VA: 0x1814EF560
	|-Dictionary<KeyValuePair<object, object>, object>.GetEnumerator
	|-Dictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|-Dictionary<ValueTuple<object, int>, object>.GetEnumerator
	|-Dictionary<ValueTuple<object, object>, object>.GetEnumerator
	|-Dictionary<Guid, object>.GetEnumerator
	|-Dictionary<Hash128, int>.GetEnumerator
	|-Dictionary<Hash128, object>.GetEnumerator
	|-Dictionary<int, TreeItem>.GetEnumerator
	|-Dictionary<InternedString, object>.GetEnumerator
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.GetEnumerator
	|-Dictionary<object, Color>.GetEnumerator
	|-Dictionary<object, Playable>.GetEnumerator
	|-Dictionary<object, Rect>.GetEnumerator
	|-Dictionary<object, ResourceLocator>.GetEnumerator
	|-Dictionary<object, StylePropertyValue>.GetEnumerator
	|-Dictionary<object, XPathNodeRef>.GetEnumerator
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.GetEnumerator
	|-Dictionary<Vector3, Vector3>.GetEnumerator
	|-Dictionary<Vector3Int, object>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.GetEnumerator
	|
	|-RVA: 0x14EF5A0 Offset: 0x14EDFA0 VA: 0x1814EF5A0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.GetEnumerator
	|-Dictionary<object, JsonParser.JsonValue>.GetEnumerator
	|
	|-RVA: 0x14FFF40 Offset: 0x14FE940 VA: 0x1814FFF40
	|-Dictionary<Bounds, object>.GetEnumerator
	|-Dictionary<int, TreeViewItemData<object>>.GetEnumerator
	|-Dictionary<int, NetworkAnimator.StateChange>.GetEnumerator
	|-Dictionary<InternedString, InternedString>.GetEnumerator
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.GetEnumerator
	|-Dictionary<object, Bounds>.GetEnumerator
	|-Dictionary<object, Color>.GetEnumerator
	|-Dictionary<object, LiquidVolume.MeshCache>.GetEnumerator
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.GetEnumerator
	|-Dictionary<XPathNodeRef, XPathNodeRef>.GetEnumerator
	|-Dictionary<Regex.CachedCodeEntryKey, object>.GetEnumerator
	|
	|-RVA: 0x14FFE70 Offset: 0x14FE870 VA: 0x1814FFE70
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.GetEnumerator
	|
	|-RVA: 0x14FFEC0 Offset: 0x14FE8C0 VA: 0x1814FFEC0
	|-Dictionary<CSteamID, int>.GetEnumerator
	|-Dictionary<Int2, int>.GetEnumerator
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.GetEnumerator
	|-Dictionary<int, CSteamID>.GetEnumerator
	|-Dictionary<int, Vector2Int>.GetEnumerator
	|-Dictionary<int, Multipass.TransportIdData>.GetEnumerator
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.GetEnumerator
	|-Dictionary<uint, RpcLinkType>.GetEnumerator
	|
	|-RVA: 0x14FFF00 Offset: 0x14FE900 VA: 0x1814FFF00
	|-Dictionary<FullRank, object>.GetEnumerator
	|-Dictionary<Int2, object>.GetEnumerator
	|-Dictionary<Int3, int>.GetEnumerator
	|-Dictionary<int, Int3>.GetEnumerator
	|-Dictionary<int, long>.GetEnumerator
	|-Dictionary<int, object>.GetEnumerator
	|-Dictionary<int, ulong>.GetEnumerator
	|-Dictionary<int, Vector3>.GetEnumerator
	|-Dictionary<Int32Enum, object>.GetEnumerator
	|-Dictionary<long, object>.GetEnumerator
	|-Dictionary<IntPtr, object>.GetEnumerator
	|-Dictionary<object, bool>.GetEnumerator
	|-Dictionary<object, Color32>.GetEnumerator
	|-Dictionary<object, double>.GetEnumerator
	|-Dictionary<object, int>.GetEnumerator
	|-Dictionary<object, Int32Enum>.GetEnumerator
	|-Dictionary<object, long>.GetEnumerator
	|-Dictionary<object, object>.GetEnumerator
	|-Dictionary<object, float>.GetEnumerator
	|-Dictionary<object, TextureId>.GetEnumerator
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.GetEnumerator
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.GetEnumerator
	|-Dictionary<object, ObjectPool.DelayedStoreData>.GetEnumerator
	|-Dictionary<object, SVGDocument.ClipData>.GetEnumerator
	|-Dictionary<object, SVGDocument.MaskData>.GetEnumerator
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.GetEnumerator
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.GetEnumerator
	|-Dictionary<Scene, object>.GetEnumerator
	|-Dictionary<TerrainTileCoord, object>.GetEnumerator
	|-Dictionary<ushort, object>.GetEnumerator
	|-Dictionary<uint, object>.GetEnumerator
	|-Dictionary<ulong, object>.GetEnumerator
	|-Dictionary<Vector2Int, object>.GetEnumerator
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.GetEnumerator
	|
	|-RVA: 0x14FFE30 Offset: 0x14FE830 VA: 0x1814FFE30
	|-Dictionary<HSteamNetConnection, int>.GetEnumerator
	|-Dictionary<int, bool>.GetEnumerator
	|-Dictionary<int, ByteEnum>.GetEnumerator
	|-Dictionary<int, HSteamNetConnection>.GetEnumerator
	|-Dictionary<int, short>.GetEnumerator
	|-Dictionary<int, int>.GetEnumerator
	|-Dictionary<int, Int32Enum>.GetEnumerator
	|-Dictionary<int, float>.GetEnumerator
	|-Dictionary<int, uint>.GetEnumerator
	|-Dictionary<Int32Enum, bool>.GetEnumerator
	|-Dictionary<Int32Enum, int>.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.GetEnumerator
	|-Dictionary<uint, int>.GetEnumerator
	|
	|-RVA: 0x1514700 Offset: 0x1513100 VA: 0x181514700
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.GetEnumerator
	|
	|-RVA: 0x15378D0 Offset: 0x15362D0 VA: 0x1815378D0
	|-Dictionary<int, RenderInstancedDataLayout>.GetEnumerator
	|-Dictionary<int, Vector4>.GetEnumerator
	|-Dictionary<ushort, RpcLink>.GetEnumerator
	|
	|-RVA: 0x1558480 Offset: 0x1556E80 VA: 0x181558480
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.GetEnumerator
	|
	|-RVA: 0x1558430 Offset: 0x1556E30 VA: 0x181558430
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary<int, TextResourceManager.FontAssetRef>.GetEnumerator
	|-Dictionary<NativeAddr, object>.GetEnumerator
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.GetEnumerator
	|-Dictionary<object, SVGDocument.PatternData>.GetEnumerator
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.GetEnumerator
	|
	|-RVA: 0x156B930 Offset: 0x156A330 VA: 0x18156B930
	|-Dictionary<long, ComputedStyle>.GetEnumerator
	|
	|-RVA: 0x15A5EF0 Offset: 0x15A48F0 VA: 0x1815A5EF0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.GetEnumerator
	|-Dictionary<object, RaycastHit>.GetEnumerator
	|
	|-RVA: 0x15C6FE0 Offset: 0x15C59E0 VA: 0x1815C6FE0
	|-Dictionary<object, InputControlLayout.ControlItem>.GetEnumerator
	|
	|-RVA: 0x15EA930 Offset: 0x15E9330 VA: 0x1815EA930
	|-Dictionary<ushort, ushort>.GetEnumerator
	|
	|-RVA: 0x15EA970 Offset: 0x15E9370 VA: 0x1815EA970
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.GetEnumerator
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.GetEnumerator
	|
	|-RVA: 0x1611FF0 Offset: 0x16109F0 VA: 0x181611FF0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F4510 Offset: 0x14F2F10 VA: 0x1814F4510
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Guid, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Hash128, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Hash128, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, TreeItem>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<InternedString, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Playable>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Rect>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x14F45A0 Offset: 0x14F2FA0 VA: 0x1814F45A0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1506920 Offset: 0x1505320 VA: 0x181506920
	|-Dictionary<Bounds, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Bounds>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1506AD0 Offset: 0x15054D0 VA: 0x181506AD0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15069C0 Offset: 0x15053C0 VA: 0x1815069C0
	|-Dictionary<CSteamID, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int2, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, CSteamID>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1506A40 Offset: 0x1505440 VA: 0x181506A40
	|-Dictionary<FullRank, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int2, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int3, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Int3>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, ulong>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Vector3>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<long, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<IntPtr, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Color32>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, double>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, long>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, float>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, TextureId>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Scene, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ushort, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ulong, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15068A0 Offset: 0x15052A0 VA: 0x1815068A0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, short>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, float>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, uint>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x151B470 Offset: 0x1519E70 VA: 0x18151B470
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x153D950 Offset: 0x153C350 VA: 0x18153D950
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, Vector4>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x155EB90 Offset: 0x155D590 VA: 0x18155EB90
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x155EAF0 Offset: 0x155D4F0 VA: 0x18155EAF0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15723F0 Offset: 0x1570DF0 VA: 0x1815723F0
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15ACA70 Offset: 0x15AB470 VA: 0x1815ACA70
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15CDE10 Offset: 0x15CC810 VA: 0x1815CDE10
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15F1920 Offset: 0x15F0320 VA: 0x1815F1920
	|-Dictionary<ushort, ushort>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x15F1860 Offset: 0x15F0260 VA: 0x1815F1860
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x1619CA0 Offset: 0x16186A0 VA: 0x181619CA0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EF5F0 Offset: 0x14EDFF0 VA: 0x1814EF5F0
	|-Dictionary<KeyValuePair<object, object>, object>.GetObjectData
	|
	|-RVA: 0x14EF7F0 Offset: 0x14EE1F0 VA: 0x1814EF7F0
	|-Dictionary<StructMultiKey<object, object>, object>.GetObjectData
	|
	|-RVA: 0x14EF9F0 Offset: 0x14EE3F0 VA: 0x1814EF9F0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.GetObjectData
	|
	|-RVA: 0x14EFDF0 Offset: 0x14EE7F0 VA: 0x1814EFDF0
	|-Dictionary<ValueTuple<object, int>, object>.GetObjectData
	|
	|-RVA: 0x14EFBF0 Offset: 0x14EE5F0 VA: 0x1814EFBF0
	|-Dictionary<ValueTuple<object, object>, object>.GetObjectData
	|
	|-RVA: 0x1500590 Offset: 0x14FEF90 VA: 0x181500590
	|-Dictionary<Bounds, object>.GetObjectData
	|
	|-RVA: 0x1500B90 Offset: 0x14FF590 VA: 0x181500B90
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.GetObjectData
	|
	|-RVA: 0x1500390 Offset: 0x14FED90 VA: 0x181500390
	|-Dictionary<CSteamID, int>.GetObjectData
	|
	|-RVA: 0x1500790 Offset: 0x14FF190 VA: 0x181500790
	|-Dictionary<FullRank, object>.GetObjectData
	|
	|-RVA: 0x1500190 Offset: 0x14FEB90 VA: 0x181500190
	|-Dictionary<Guid, object>.GetObjectData
	|
	|-RVA: 0x14FFF90 Offset: 0x14FE990 VA: 0x1814FFF90
	|-Dictionary<HSteamNetConnection, int>.GetObjectData
	|
	|-RVA: 0x1500990 Offset: 0x14FF390 VA: 0x181500990
	|-Dictionary<Hash128, int>.GetObjectData
	|
	|-RVA: 0x1514D40 Offset: 0x1513740 VA: 0x181514D40
	|-Dictionary<Hash128, object>.GetObjectData
	|
	|-RVA: 0x1515340 Offset: 0x1513D40 VA: 0x181515340
	|-Dictionary<Int2, int>.GetObjectData
	|
	|-RVA: 0x1514B40 Offset: 0x1513540 VA: 0x181514B40
	|-Dictionary<Int2, object>.GetObjectData
	|
	|-RVA: 0x1514940 Offset: 0x1513340 VA: 0x181514940
	|-Dictionary<Int3, int>.GetObjectData
	|
	|-RVA: 0x1514F40 Offset: 0x1513940 VA: 0x181514F40
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.GetObjectData
	|
	|-RVA: 0x1514740 Offset: 0x1513140 VA: 0x181514740
	|-Dictionary<int, TreeViewItemData<object>>.GetObjectData
	|
	|-RVA: 0x1515140 Offset: 0x1513B40 VA: 0x181515140
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.GetObjectData
	|
	|-RVA: 0x15278F0 Offset: 0x15262F0 VA: 0x1815278F0
	|-Dictionary<int, bool>.GetObjectData
	|
	|-RVA: 0x1527CF0 Offset: 0x15266F0 VA: 0x181527CF0
	|-Dictionary<int, ByteEnum>.GetObjectData
	|
	|-RVA: 0x1527EF0 Offset: 0x15268F0 VA: 0x181527EF0
	|-Dictionary<int, CSteamID>.GetObjectData
	|
	|-RVA: 0x1527AF0 Offset: 0x15264F0 VA: 0x181527AF0
	|-Dictionary<int, HSteamNetConnection>.GetObjectData
	|
	|-RVA: 0x15274F0 Offset: 0x1525EF0 VA: 0x1815274F0
	|-Dictionary<int, short>.GetObjectData
	|
	|-RVA: 0x15280F0 Offset: 0x1526AF0 VA: 0x1815280F0
	|-Dictionary<int, Int3>.GetObjectData
	|
	|-RVA: 0x15276F0 Offset: 0x15260F0 VA: 0x1815276F0
	|-Dictionary<int, int>.GetObjectData
	|
	|-RVA: 0x1537D10 Offset: 0x1536710 VA: 0x181537D10
	|-Dictionary<int, Int32Enum>.GetObjectData
	|
	|-RVA: 0x1538310 Offset: 0x1536D10 VA: 0x181538310
	|-Dictionary<int, long>.GetObjectData
	|
	|-RVA: 0x1538510 Offset: 0x1536F10 VA: 0x181538510
	|-Dictionary<int, object>.GetObjectData
	|
	|-RVA: 0x1537910 Offset: 0x1536310 VA: 0x181537910
	|-Dictionary<int, RenderInstancedDataLayout>.GetObjectData
	|
	|-RVA: 0x1537B10 Offset: 0x1536510 VA: 0x181537B10
	|-Dictionary<int, float>.GetObjectData
	|
	|-RVA: 0x1537F10 Offset: 0x1536910 VA: 0x181537F10
	|-Dictionary<int, TreeItem>.GetObjectData
	|
	|-RVA: 0x1538110 Offset: 0x1536B10 VA: 0x181538110
	|-Dictionary<int, uint>.GetObjectData
	|
	|-RVA: 0x1548680 Offset: 0x1547080 VA: 0x181548680
	|-Dictionary<int, ulong>.GetObjectData
	|
	|-RVA: 0x1547E80 Offset: 0x1546880 VA: 0x181547E80
	|-Dictionary<int, Vector2Int>.GetObjectData
	|
	|-RVA: 0x1548480 Offset: 0x1546E80 VA: 0x181548480
	|-Dictionary<int, Vector3>.GetObjectData
	|
	|-RVA: 0x1548080 Offset: 0x1546A80 VA: 0x181548080
	|-Dictionary<int, Vector4>.GetObjectData
	|
	|-RVA: 0x1548880 Offset: 0x1547280 VA: 0x181548880
	|-Dictionary<int, Multipass.TransportIdData>.GetObjectData
	|
	|-RVA: 0x1548280 Offset: 0x1546C80 VA: 0x181548280
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.GetObjectData
	|
	|-RVA: 0x1547C80 Offset: 0x1546680 VA: 0x181547C80
	|-Dictionary<int, NetworkAnimator.StateChange>.GetObjectData
	|
	|-RVA: 0x1558AF0 Offset: 0x15574F0 VA: 0x181558AF0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.GetObjectData
	|
	|-RVA: 0x1558CF0 Offset: 0x15576F0 VA: 0x181558CF0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.GetObjectData
	|
	|-RVA: 0x15584F0 Offset: 0x1556EF0 VA: 0x1815584F0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.GetObjectData
	|
	|-RVA: 0x15586F0 Offset: 0x15570F0 VA: 0x1815586F0
	|-Dictionary<Int32Enum, bool>.GetObjectData
	|
	|-RVA: 0x1558EF0 Offset: 0x15578F0 VA: 0x181558EF0
	|-Dictionary<Int32Enum, int>.GetObjectData
	|
	|-RVA: 0x15588F0 Offset: 0x15572F0 VA: 0x1815588F0
	|-Dictionary<Int32Enum, Int32Enum>.GetObjectData
	|
	|-RVA: 0x15590F0 Offset: 0x1557AF0 VA: 0x1815590F0
	|-Dictionary<Int32Enum, object>.GetObjectData
	|
	|-RVA: 0x156C190 Offset: 0x156AB90 VA: 0x18156C190
	|-Dictionary<long, ComputedStyle>.GetObjectData
	|
	|-RVA: 0x156C390 Offset: 0x156AD90 VA: 0x18156C390
	|-Dictionary<long, object>.GetObjectData
	|
	|-RVA: 0x156C590 Offset: 0x156AF90 VA: 0x18156C590
	|-Dictionary<IntPtr, object>.GetObjectData
	|
	|-RVA: 0x156BF90 Offset: 0x156A990 VA: 0x18156BF90
	|-Dictionary<InternedString, InternedString>.GetObjectData
	|
	|-RVA: 0x156BD90 Offset: 0x156A790 VA: 0x18156BD90
	|-Dictionary<InternedString, object>.GetObjectData
	|
	|-RVA: 0x156BB90 Offset: 0x156A590 VA: 0x18156BB90
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.GetObjectData
	|
	|-RVA: 0x156B990 Offset: 0x156A390 VA: 0x18156B990
	|-Dictionary<NativeAddr, object>.GetObjectData
	|
	|-RVA: 0x1593B80 Offset: 0x1592580 VA: 0x181593B80
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.GetObjectData
	|
	|-RVA: 0x1593D80 Offset: 0x1592780 VA: 0x181593D80
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.GetObjectData
	|
	|-RVA: 0x1593F80 Offset: 0x1592980 VA: 0x181593F80
	|-Dictionary<object, bool>.GetObjectData
	|
	|-RVA: 0x1594380 Offset: 0x1592D80 VA: 0x181594380
	|-Dictionary<object, Bounds>.GetObjectData
	|
	|-RVA: 0x1593980 Offset: 0x1592380 VA: 0x181593980
	|-Dictionary<object, Color>.GetObjectData
	|
	|-RVA: 0x1594580 Offset: 0x1592F80 VA: 0x181594580
	|-Dictionary<object, Color>.GetObjectData
	|
	|-RVA: 0x1594180 Offset: 0x1592B80 VA: 0x181594180
	|-Dictionary<object, Color32>.GetObjectData
	|
	|-RVA: 0x15A5F40 Offset: 0x15A4940 VA: 0x1815A5F40
	|-Dictionary<object, double>.GetObjectData
	|
	|-RVA: 0x15A6540 Offset: 0x15A4F40 VA: 0x1815A6540
	|-Dictionary<object, int>.GetObjectData
	|
	|-RVA: 0x15A6B40 Offset: 0x15A5540 VA: 0x1815A6B40
	|-Dictionary<object, Int32Enum>.GetObjectData
	|
	|-RVA: 0x15A6940 Offset: 0x15A5340 VA: 0x1815A6940
	|-Dictionary<object, long>.GetObjectData
	|
	|-RVA: 0x15A6740 Offset: 0x15A5140 VA: 0x1815A6740
	|-Dictionary<object, object>.GetObjectData
	|
	|-RVA: 0x15A6340 Offset: 0x15A4D40 VA: 0x1815A6340
	|-Dictionary<object, Playable>.GetObjectData
	|
	|-RVA: 0x15A6140 Offset: 0x15A4B40 VA: 0x1815A6140
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.GetObjectData
	|
	|-RVA: 0x15B72F0 Offset: 0x15B5CF0 VA: 0x1815B72F0
	|-Dictionary<object, RaycastHit>.GetObjectData
	|
	|-RVA: 0x15B6EF0 Offset: 0x15B58F0 VA: 0x1815B6EF0
	|-Dictionary<object, Rect>.GetObjectData
	|
	|-RVA: 0x15B70F0 Offset: 0x15B5AF0 VA: 0x1815B70F0
	|-Dictionary<object, ResourceLocator>.GetObjectData
	|
	|-RVA: 0x15B6CF0 Offset: 0x15B56F0 VA: 0x1815B6CF0
	|-Dictionary<object, float>.GetObjectData
	|
	|-RVA: 0x15B6AF0 Offset: 0x15B54F0 VA: 0x1815B6AF0
	|-Dictionary<object, StylePropertyValue>.GetObjectData
	|
	|-RVA: 0x15B68F0 Offset: 0x15B52F0 VA: 0x1815B68F0
	|-Dictionary<object, TextureId>.GetObjectData
	|
	|-RVA: 0x15B66F0 Offset: 0x15B50F0 VA: 0x1815B66F0
	|-Dictionary<object, XPathNodeRef>.GetObjectData
	|
	|-RVA: 0x15C7840 Offset: 0x15C6240 VA: 0x1815C7840
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.GetObjectData
	|
	|-RVA: 0x15C7640 Offset: 0x15C6040 VA: 0x1815C7640
	|-Dictionary<object, InputControlLayout.ControlItem>.GetObjectData
	|
	|-RVA: 0x15C7240 Offset: 0x15C5C40 VA: 0x1815C7240
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.GetObjectData
	|
	|-RVA: 0x15C7440 Offset: 0x15C5E40 VA: 0x1815C7440
	|-Dictionary<object, JsonParser.JsonValue>.GetObjectData
	|
	|-RVA: 0x15C7040 Offset: 0x15C5A40 VA: 0x1815C7040
	|-Dictionary<object, LiquidVolume.MeshCache>.GetObjectData
	|
	|-RVA: 0x15C7A40 Offset: 0x15C6440 VA: 0x1815C7A40
	|-Dictionary<object, ObjectPool.DelayedStoreData>.GetObjectData
	|
	|-RVA: 0x15C7C40 Offset: 0x15C6640 VA: 0x1815C7C40
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.GetObjectData
	|
	|-RVA: 0x15D92D0 Offset: 0x15D7CD0 VA: 0x1815D92D0
	|-Dictionary<object, SVGDocument.ClipData>.GetObjectData
	|
	|-RVA: 0x15D90D0 Offset: 0x15D7AD0 VA: 0x1815D90D0
	|-Dictionary<object, SVGDocument.MaskData>.GetObjectData
	|
	|-RVA: 0x15D8CD0 Offset: 0x15D76D0 VA: 0x1815D8CD0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.GetObjectData
	|
	|-RVA: 0x15D96D0 Offset: 0x15D80D0 VA: 0x1815D96D0
	|-Dictionary<object, SVGDocument.PatternData>.GetObjectData
	|
	|-RVA: 0x15D94D0 Offset: 0x15D7ED0 VA: 0x1815D94D0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.GetObjectData
	|
	|-RVA: 0x15D98D0 Offset: 0x15D82D0 VA: 0x1815D98D0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.GetObjectData
	|
	|-RVA: 0x15D8ED0 Offset: 0x15D78D0 VA: 0x1815D8ED0
	|-Dictionary<Scene, object>.GetObjectData
	|
	|-RVA: 0x15EB5C0 Offset: 0x15E9FC0 VA: 0x1815EB5C0
	|-Dictionary<TerrainTileCoord, object>.GetObjectData
	|
	|-RVA: 0x15EADC0 Offset: 0x15E97C0 VA: 0x1815EADC0
	|-Dictionary<ushort, object>.GetObjectData
	|
	|-RVA: 0x15EA9C0 Offset: 0x15E93C0 VA: 0x1815EA9C0
	|-Dictionary<ushort, RpcLink>.GetObjectData
	|
	|-RVA: 0x15EAFC0 Offset: 0x15E99C0 VA: 0x1815EAFC0
	|-Dictionary<ushort, ushort>.GetObjectData
	|
	|-RVA: 0x15EB3C0 Offset: 0x15E9DC0 VA: 0x1815EB3C0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.GetObjectData
	|
	|-RVA: 0x15EB1C0 Offset: 0x15E9BC0 VA: 0x1815EB1C0
	|-Dictionary<uint, int>.GetObjectData
	|
	|-RVA: 0x15EABC0 Offset: 0x15E95C0 VA: 0x1815EABC0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.GetObjectData
	|
	|-RVA: 0x15FE9C0 Offset: 0x15FD3C0 VA: 0x1815FE9C0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.GetObjectData
	|
	|-RVA: 0x15FE3C0 Offset: 0x15FCDC0 VA: 0x1815FE3C0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.GetObjectData
	|
	|-RVA: 0x15FDDC0 Offset: 0x15FC7C0 VA: 0x1815FDDC0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.GetObjectData
	|
	|-RVA: 0x15FE5C0 Offset: 0x15FCFC0 VA: 0x1815FE5C0
	|-Dictionary<uint, object>.GetObjectData
	|
	|-RVA: 0x15FDFC0 Offset: 0x15FC9C0 VA: 0x1815FDFC0
	|-Dictionary<uint, RpcLinkType>.GetObjectData
	|
	|-RVA: 0x15FE1C0 Offset: 0x15FCBC0 VA: 0x1815FE1C0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.GetObjectData
	|
	|-RVA: 0x15FE7C0 Offset: 0x15FD1C0 VA: 0x1815FE7C0
	|-Dictionary<ulong, object>.GetObjectData
	|
	|-RVA: 0x16124D0 Offset: 0x1610ED0 VA: 0x1816124D0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.GetObjectData
	|
	|-RVA: 0x1612CD0 Offset: 0x16116D0 VA: 0x181612CD0
	|-Dictionary<Vector2Int, object>.GetObjectData
	|
	|-RVA: 0x16128D0 Offset: 0x16112D0 VA: 0x1816128D0
	|-Dictionary<Vector3, Vector3>.GetObjectData
	|
	|-RVA: 0x16122D0 Offset: 0x1610CD0 VA: 0x1816122D0
	|-Dictionary<Vector3Int, object>.GetObjectData
	|
	|-RVA: 0x16126D0 Offset: 0x16110D0 VA: 0x1816126D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.GetObjectData
	|
	|-RVA: 0x16120B0 Offset: 0x1610AB0 VA: 0x1816120B0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetObjectData
	|
	|-RVA: 0x1612AD0 Offset: 0x16114D0 VA: 0x181612AD0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.GetObjectData
	|
	|-RVA: 0x1627630 Offset: 0x1626030 VA: 0x181627630
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.GetObjectData
	|
	|-RVA: 0x1627430 Offset: 0x1625E30 VA: 0x181627430
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.GetObjectData
	|
	|-RVA: 0x1627830 Offset: 0x1626230 VA: 0x181627830
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.GetObjectData
	|
	|-RVA: 0x1627A30 Offset: 0x1626430 VA: 0x181627A30
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	private int FindEntry(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EF100 Offset: 0x14EDB00 VA: 0x1814EF100
	|-Dictionary<KeyValuePair<object, object>, object>.FindEntry
	|
	|-RVA: 0x14EDFC0 Offset: 0x14EC9C0 VA: 0x1814EDFC0
	|-Dictionary<StructMultiKey<object, object>, object>.FindEntry
	|
	|-RVA: 0x14EE860 Offset: 0x14ED260 VA: 0x1814EE860
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.FindEntry
	|
	|-RVA: 0x14EE410 Offset: 0x14ECE10 VA: 0x1814EE410
	|-Dictionary<ValueTuple<object, int>, object>.FindEntry
	|
	|-RVA: 0x14EECB0 Offset: 0x14ED6B0 VA: 0x1814EECB0
	|-Dictionary<ValueTuple<object, object>, object>.FindEntry
	|
	|-RVA: 0x14FEC70 Offset: 0x14FD670 VA: 0x1814FEC70
	|-Dictionary<Bounds, object>.FindEntry
	|
	|-RVA: 0x14FF550 Offset: 0x14FDF50 VA: 0x1814FF550
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.FindEntry
	|
	|-RVA: 0x14FE8A0 Offset: 0x14FD2A0 VA: 0x1814FE8A0
	|-Dictionary<CSteamID, int>.FindEntry
	|
	|-RVA: 0x14FE510 Offset: 0x14FCF10 VA: 0x1814FE510
	|-Dictionary<FullRank, object>.FindEntry
	|
	|-RVA: 0x14FF9E0 Offset: 0x14FE3E0 VA: 0x1814FF9E0
	|-Dictionary<Guid, object>.FindEntry
	|
	|-RVA: 0x14FE150 Offset: 0x14FCB50 VA: 0x1814FE150
	|-Dictionary<HSteamNetConnection, int>.FindEntry
	|
	|-RVA: 0x14FF100 Offset: 0x14FDB00 VA: 0x1814FF100
	|-Dictionary<Hash128, int>.FindEntry
	|-Dictionary<Hash128, object>.FindEntry
	|
	|-RVA: 0x1513080 Offset: 0x1511A80 VA: 0x181513080
	|-Dictionary<Int2, int>.FindEntry
	|
	|-RVA: 0x1513C50 Offset: 0x1512650 VA: 0x181513C50
	|-Dictionary<Int2, object>.FindEntry
	|
	|-RVA: 0x1513420 Offset: 0x1511E20 VA: 0x181513420
	|-Dictionary<Int3, int>.FindEntry
	|
	|-RVA: 0x1513FE0 Offset: 0x15129E0 VA: 0x181513FE0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.FindEntry
	|-Dictionary<int, CSteamID>.FindEntry
	|-Dictionary<int, Vector2Int>.FindEntry
	|-Dictionary<int, Multipass.TransportIdData>.FindEntry
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.FindEntry
	|
	|-RVA: 0x15138C0 Offset: 0x15122C0 VA: 0x1815138C0
	|-Dictionary<int, TreeViewItemData<object>>.FindEntry
	|-Dictionary<int, NetworkAnimator.StateChange>.FindEntry
	|
	|-RVA: 0x1514370 Offset: 0x1512D70 VA: 0x181514370
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.FindEntry
	|
	|-RVA: 0x1526DE0 Offset: 0x15257E0 VA: 0x181526DE0
	|-Dictionary<int, bool>.FindEntry
	|-Dictionary<int, ByteEnum>.FindEntry
	|-Dictionary<int, HSteamNetConnection>.FindEntry
	|-Dictionary<int, short>.FindEntry
	|-Dictionary<int, int>.FindEntry
	|-Dictionary<int, Int32Enum>.FindEntry
	|-Dictionary<int, float>.FindEntry
	|-Dictionary<int, uint>.FindEntry
	|
	|-RVA: 0x1527160 Offset: 0x1525B60 VA: 0x181527160
	|-Dictionary<int, Int3>.FindEntry
	|-Dictionary<int, long>.FindEntry
	|-Dictionary<int, object>.FindEntry
	|-Dictionary<int, ulong>.FindEntry
	|-Dictionary<int, Vector3>.FindEntry
	|
	|-RVA: 0x15371B0 Offset: 0x1535BB0 VA: 0x1815371B0
	|-Dictionary<int, RenderInstancedDataLayout>.FindEntry
	|-Dictionary<int, Vector4>.FindEntry
	|
	|-RVA: 0x1537540 Offset: 0x1535F40 VA: 0x181537540
	|-Dictionary<int, TreeItem>.FindEntry
	|
	|-RVA: 0x1557D20 Offset: 0x1556720 VA: 0x181557D20
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.FindEntry
	|
	|-RVA: 0x1557610 Offset: 0x1556010 VA: 0x181557610
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.FindEntry
	|-Dictionary<int, TextResourceManager.FontAssetRef>.FindEntry
	|
	|-RVA: 0x15579A0 Offset: 0x15563A0 VA: 0x1815579A0
	|-Dictionary<Int32Enum, bool>.FindEntry
	|-Dictionary<Int32Enum, int>.FindEntry
	|-Dictionary<Int32Enum, Int32Enum>.FindEntry
	|
	|-RVA: 0x15580B0 Offset: 0x1556AB0 VA: 0x1815580B0
	|-Dictionary<Int32Enum, object>.FindEntry
	|
	|-RVA: 0x156A160 Offset: 0x1568B60 VA: 0x18156A160
	|-Dictionary<long, ComputedStyle>.FindEntry
	|
	|-RVA: 0x156B5A0 Offset: 0x1569FA0 VA: 0x18156B5A0
	|-Dictionary<long, object>.FindEntry
	|
	|-RVA: 0x156B210 Offset: 0x1569C10 VA: 0x18156B210
	|-Dictionary<IntPtr, object>.FindEntry
	|
	|-RVA: 0x156A4F0 Offset: 0x1568EF0 VA: 0x18156A4F0
	|-Dictionary<InternedString, InternedString>.FindEntry
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.FindEntry
	|
	|-RVA: 0x156A940 Offset: 0x1569340 VA: 0x18156A940
	|-Dictionary<InternedString, object>.FindEntry
	|
	|-RVA: 0x156AD90 Offset: 0x1569790 VA: 0x18156AD90
	|-Dictionary<NativeAddr, object>.FindEntry
	|
	|-RVA: 0x1593450 Offset: 0x1591E50 VA: 0x181593450
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.FindEntry
	|-Dictionary<object, Color>.FindEntry
	|-Dictionary<object, Playable>.FindEntry
	|-Dictionary<object, Rect>.FindEntry
	|-Dictionary<object, ResourceLocator>.FindEntry
	|-Dictionary<object, StylePropertyValue>.FindEntry
	|-Dictionary<object, XPathNodeRef>.FindEntry
	|
	|-RVA: 0x15936E0 Offset: 0x15920E0 VA: 0x1815936E0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.FindEntry
	|-Dictionary<object, SVGDocument.PatternData>.FindEntry
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.FindEntry
	|
	|-RVA: 0x1592F30 Offset: 0x1591930 VA: 0x181592F30
	|-Dictionary<object, bool>.FindEntry
	|-Dictionary<object, Color32>.FindEntry
	|-Dictionary<object, double>.FindEntry
	|-Dictionary<object, int>.FindEntry
	|-Dictionary<object, Int32Enum>.FindEntry
	|-Dictionary<object, long>.FindEntry
	|-Dictionary<object, object>.FindEntry
	|-Dictionary<object, float>.FindEntry
	|-Dictionary<object, TextureId>.FindEntry
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.FindEntry
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.FindEntry
	|-Dictionary<object, ObjectPool.DelayedStoreData>.FindEntry
	|-Dictionary<object, SVGDocument.ClipData>.FindEntry
	|-Dictionary<object, SVGDocument.MaskData>.FindEntry
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.FindEntry
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.FindEntry
	|
	|-RVA: 0x15931C0 Offset: 0x1591BC0 VA: 0x1815931C0
	|-Dictionary<object, Bounds>.FindEntry
	|-Dictionary<object, Color>.FindEntry
	|-Dictionary<object, LiquidVolume.MeshCache>.FindEntry
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.FindEntry
	|
	|-RVA: 0x15A5C60 Offset: 0x15A4660 VA: 0x1815A5C60
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.FindEntry
	|-Dictionary<object, RaycastHit>.FindEntry
	|
	|-RVA: 0x15C6AB0 Offset: 0x15C54B0 VA: 0x1815C6AB0
	|-Dictionary<object, InputControlLayout.ControlItem>.FindEntry
	|
	|-RVA: 0x15C6D50 Offset: 0x15C5750 VA: 0x1815C6D50
	|-Dictionary<object, JsonParser.JsonValue>.FindEntry
	|
	|-RVA: 0x15D8940 Offset: 0x15D7340 VA: 0x1815D8940
	|-Dictionary<Scene, object>.FindEntry
	|
	|-RVA: 0x15EA200 Offset: 0x15E8C00 VA: 0x1815EA200
	|-Dictionary<TerrainTileCoord, object>.FindEntry
	|
	|-RVA: 0x15E9AE0 Offset: 0x15E84E0 VA: 0x1815E9AE0
	|-Dictionary<ushort, object>.FindEntry
	|
	|-RVA: 0x15EA5A0 Offset: 0x15E8FA0 VA: 0x1815EA5A0
	|-Dictionary<ushort, RpcLink>.FindEntry
	|
	|-RVA: 0x15E9040 Offset: 0x15E7A40 VA: 0x1815E9040
	|-Dictionary<ushort, ushort>.FindEntry
	|
	|-RVA: 0x15E93D0 Offset: 0x15E7DD0 VA: 0x1815E93D0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.FindEntry
	|
	|-RVA: 0x15E9760 Offset: 0x15E8160 VA: 0x1815E9760
	|-Dictionary<uint, int>.FindEntry
	|
	|-RVA: 0x15E9E70 Offset: 0x15E8870 VA: 0x1815E9E70
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.FindEntry
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.FindEntry
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.FindEntry
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.FindEntry
	|
	|-RVA: 0x15FD6A0 Offset: 0x15FC0A0 VA: 0x1815FD6A0
	|-Dictionary<uint, object>.FindEntry
	|
	|-RVA: 0x15FCF80 Offset: 0x15FB980 VA: 0x1815FCF80
	|-Dictionary<uint, RpcLinkType>.FindEntry
	|
	|-RVA: 0x15FDA30 Offset: 0x15FC430 VA: 0x1815FDA30
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.FindEntry
	|
	|-RVA: 0x15FD310 Offset: 0x15FBD10 VA: 0x1815FD310
	|-Dictionary<ulong, object>.FindEntry
	|
	|-RVA: 0x1610690 Offset: 0x160F090 VA: 0x181610690
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.FindEntry
	|
	|-RVA: 0x1610A20 Offset: 0x160F420 VA: 0x181610A20
	|-Dictionary<Vector2Int, object>.FindEntry
	|
	|-RVA: 0x1610DC0 Offset: 0x160F7C0 VA: 0x181610DC0
	|-Dictionary<Vector3, Vector3>.FindEntry
	|
	|-RVA: 0x1611270 Offset: 0x160FC70 VA: 0x181611270
	|-Dictionary<Vector3Int, object>.FindEntry
	|
	|-RVA: 0x1611BA0 Offset: 0x16105A0 VA: 0x181611BA0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.FindEntry
	|
	|-RVA: 0x160FDE0 Offset: 0x160E7E0 VA: 0x18160FDE0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindEntry
	|
	|-RVA: 0x16116E0 Offset: 0x16100E0 VA: 0x1816116E0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.FindEntry
	|
	|-RVA: 0x1626C30 Offset: 0x1625630 VA: 0x181626C30
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.FindEntry
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.FindEntry
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.FindEntry
	|
	|-RVA: 0x1627090 Offset: 0x1625A90 VA: 0x181627090
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private int Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EFFF0 Offset: 0x14EE9F0 VA: 0x1814EFFF0
	|-Dictionary<KeyValuePair<object, object>, object>.Initialize
	|
	|-RVA: 0x14F01B0 Offset: 0x14EEBB0 VA: 0x1814F01B0
	|-Dictionary<StructMultiKey<object, object>, object>.Initialize
	|
	|-RVA: 0x14F00D0 Offset: 0x14EEAD0 VA: 0x1814F00D0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Initialize
	|
	|-RVA: 0x14F0370 Offset: 0x14EED70 VA: 0x1814F0370
	|-Dictionary<ValueTuple<object, int>, object>.Initialize
	|
	|-RVA: 0x14F0290 Offset: 0x14EEC90 VA: 0x1814F0290
	|-Dictionary<ValueTuple<object, object>, object>.Initialize
	|
	|-RVA: 0x15011F0 Offset: 0x14FFBF0 VA: 0x1815011F0
	|-Dictionary<Bounds, object>.Initialize
	|
	|-RVA: 0x1501030 Offset: 0x14FFA30 VA: 0x181501030
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Initialize
	|
	|-RVA: 0x1500D90 Offset: 0x14FF790 VA: 0x181500D90
	|-Dictionary<CSteamID, int>.Initialize
	|
	|-RVA: 0x1501110 Offset: 0x14FFB10 VA: 0x181501110
	|-Dictionary<FullRank, object>.Initialize
	|
	|-RVA: 0x1500F50 Offset: 0x14FF950 VA: 0x181500F50
	|-Dictionary<Guid, object>.Initialize
	|
	|-RVA: 0x1500E70 Offset: 0x14FF870 VA: 0x181500E70
	|-Dictionary<HSteamNetConnection, int>.Initialize
	|
	|-RVA: 0x15012D0 Offset: 0x14FFCD0 VA: 0x1815012D0
	|-Dictionary<Hash128, int>.Initialize
	|
	|-RVA: 0x1515A80 Offset: 0x1514480 VA: 0x181515A80
	|-Dictionary<Hash128, object>.Initialize
	|
	|-RVA: 0x15157E0 Offset: 0x15141E0 VA: 0x1815157E0
	|-Dictionary<Int2, int>.Initialize
	|
	|-RVA: 0x1515620 Offset: 0x1514020 VA: 0x181515620
	|-Dictionary<Int2, object>.Initialize
	|
	|-RVA: 0x1515700 Offset: 0x1514100 VA: 0x181515700
	|-Dictionary<Int3, int>.Initialize
	|
	|-RVA: 0x15159A0 Offset: 0x15143A0 VA: 0x1815159A0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Initialize
	|
	|-RVA: 0x15158C0 Offset: 0x15142C0 VA: 0x1815158C0
	|-Dictionary<int, TreeViewItemData<object>>.Initialize
	|
	|-RVA: 0x1515540 Offset: 0x1513F40 VA: 0x181515540
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Initialize
	|
	|-RVA: 0x15284B0 Offset: 0x1526EB0 VA: 0x1815284B0
	|-Dictionary<int, bool>.Initialize
	|
	|-RVA: 0x1528750 Offset: 0x1527150 VA: 0x181528750
	|-Dictionary<int, ByteEnum>.Initialize
	|
	|-RVA: 0x15283D0 Offset: 0x1526DD0 VA: 0x1815283D0
	|-Dictionary<int, CSteamID>.Initialize
	|
	|-RVA: 0x1528830 Offset: 0x1527230 VA: 0x181528830
	|-Dictionary<int, HSteamNetConnection>.Initialize
	|
	|-RVA: 0x15282F0 Offset: 0x1526CF0 VA: 0x1815282F0
	|-Dictionary<int, short>.Initialize
	|
	|-RVA: 0x1528670 Offset: 0x1527070 VA: 0x181528670
	|-Dictionary<int, Int3>.Initialize
	|
	|-RVA: 0x1528590 Offset: 0x1526F90 VA: 0x181528590
	|-Dictionary<int, int>.Initialize
	|
	|-RVA: 0x1538710 Offset: 0x1537110 VA: 0x181538710
	|-Dictionary<int, Int32Enum>.Initialize
	|
	|-RVA: 0x1538B70 Offset: 0x1537570 VA: 0x181538B70
	|-Dictionary<int, long>.Initialize
	|
	|-RVA: 0x15387F0 Offset: 0x15371F0 VA: 0x1815387F0
	|-Dictionary<int, object>.Initialize
	|
	|-RVA: 0x15389B0 Offset: 0x15373B0 VA: 0x1815389B0
	|-Dictionary<int, RenderInstancedDataLayout>.Initialize
	|
	|-RVA: 0x15388D0 Offset: 0x15372D0 VA: 0x1815388D0
	|-Dictionary<int, float>.Initialize
	|
	|-RVA: 0x1538A90 Offset: 0x1537490 VA: 0x181538A90
	|-Dictionary<int, TreeItem>.Initialize
	|
	|-RVA: 0x1538C50 Offset: 0x1537650 VA: 0x181538C50
	|-Dictionary<int, uint>.Initialize
	|
	|-RVA: 0x1548A80 Offset: 0x1547480 VA: 0x181548A80
	|-Dictionary<int, ulong>.Initialize
	|
	|-RVA: 0x1548EE0 Offset: 0x15478E0 VA: 0x181548EE0
	|-Dictionary<int, Vector2Int>.Initialize
	|
	|-RVA: 0x1548B60 Offset: 0x1547560 VA: 0x181548B60
	|-Dictionary<int, Vector3>.Initialize
	|
	|-RVA: 0x1548C40 Offset: 0x1547640 VA: 0x181548C40
	|-Dictionary<int, Vector4>.Initialize
	|
	|-RVA: 0x1548FC0 Offset: 0x15479C0 VA: 0x181548FC0
	|-Dictionary<int, Multipass.TransportIdData>.Initialize
	|
	|-RVA: 0x1548D20 Offset: 0x1547720 VA: 0x181548D20
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Initialize
	|
	|-RVA: 0x1548E00 Offset: 0x1547800 VA: 0x181548E00
	|-Dictionary<int, NetworkAnimator.StateChange>.Initialize
	|
	|-RVA: 0x15594B0 Offset: 0x1557EB0 VA: 0x1815594B0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Initialize
	|
	|-RVA: 0x1559750 Offset: 0x1558150 VA: 0x181559750
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Initialize
	|
	|-RVA: 0x15593D0 Offset: 0x1557DD0 VA: 0x1815593D0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Initialize
	|
	|-RVA: 0x1559590 Offset: 0x1557F90 VA: 0x181559590
	|-Dictionary<Int32Enum, bool>.Initialize
	|
	|-RVA: 0x1559830 Offset: 0x1558230 VA: 0x181559830
	|-Dictionary<Int32Enum, int>.Initialize
	|
	|-RVA: 0x1559670 Offset: 0x1558070 VA: 0x181559670
	|-Dictionary<Int32Enum, Int32Enum>.Initialize
	|
	|-RVA: 0x15592F0 Offset: 0x1557CF0 VA: 0x1815592F0
	|-Dictionary<Int32Enum, object>.Initialize
	|
	|-RVA: 0x156C950 Offset: 0x156B350 VA: 0x18156C950
	|-Dictionary<long, ComputedStyle>.Initialize
	|
	|-RVA: 0x156C870 Offset: 0x156B270 VA: 0x18156C870
	|-Dictionary<long, object>.Initialize
	|
	|-RVA: 0x156CBF0 Offset: 0x156B5F0 VA: 0x18156CBF0
	|-Dictionary<IntPtr, object>.Initialize
	|
	|-RVA: 0x156CB10 Offset: 0x156B510 VA: 0x18156CB10
	|-Dictionary<InternedString, InternedString>.Initialize
	|
	|-RVA: 0x156CA30 Offset: 0x156B430 VA: 0x18156CA30
	|-Dictionary<InternedString, object>.Initialize
	|
	|-RVA: 0x156C790 Offset: 0x156B190 VA: 0x18156C790
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Initialize
	|
	|-RVA: 0x156CCD0 Offset: 0x156B6D0 VA: 0x18156CCD0
	|-Dictionary<NativeAddr, object>.Initialize
	|
	|-RVA: 0x1594CC0 Offset: 0x15936C0 VA: 0x181594CC0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Initialize
	|
	|-RVA: 0x1594BE0 Offset: 0x15935E0 VA: 0x181594BE0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Initialize
	|
	|-RVA: 0x1594860 Offset: 0x1593260 VA: 0x181594860
	|-Dictionary<object, bool>.Initialize
	|
	|-RVA: 0x1594940 Offset: 0x1593340 VA: 0x181594940
	|-Dictionary<object, Bounds>.Initialize
	|
	|-RVA: 0x1594780 Offset: 0x1593180 VA: 0x181594780
	|-Dictionary<object, Color>.Initialize
	|
	|-RVA: 0x1594B00 Offset: 0x1593500 VA: 0x181594B00
	|-Dictionary<object, Color>.Initialize
	|
	|-RVA: 0x1594A20 Offset: 0x1593420 VA: 0x181594A20
	|-Dictionary<object, Color32>.Initialize
	|
	|-RVA: 0x15A6D40 Offset: 0x15A5740 VA: 0x1815A6D40
	|-Dictionary<object, double>.Initialize
	|
	|-RVA: 0x15A70C0 Offset: 0x15A5AC0 VA: 0x1815A70C0
	|-Dictionary<object, int>.Initialize
	|
	|-RVA: 0x15A6FE0 Offset: 0x15A59E0 VA: 0x1815A6FE0
	|-Dictionary<object, Int32Enum>.Initialize
	|
	|-RVA: 0x15A6F00 Offset: 0x15A5900 VA: 0x1815A6F00
	|-Dictionary<object, long>.Initialize
	|
	|-RVA: 0x15A6E20 Offset: 0x15A5820 VA: 0x1815A6E20
	|-Dictionary<object, object>.Initialize
	|
	|-RVA: 0x15A7280 Offset: 0x15A5C80 VA: 0x1815A7280
	|-Dictionary<object, Playable>.Initialize
	|
	|-RVA: 0x15A71A0 Offset: 0x15A5BA0 VA: 0x1815A71A0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Initialize
	|
	|-RVA: 0x15B76B0 Offset: 0x15B60B0 VA: 0x1815B76B0
	|-Dictionary<object, RaycastHit>.Initialize
	|
	|-RVA: 0x15B74F0 Offset: 0x15B5EF0 VA: 0x1815B74F0
	|-Dictionary<object, Rect>.Initialize
	|
	|-RVA: 0x15B7950 Offset: 0x15B6350 VA: 0x1815B7950
	|-Dictionary<object, ResourceLocator>.Initialize
	|
	|-RVA: 0x15B75D0 Offset: 0x15B5FD0 VA: 0x1815B75D0
	|-Dictionary<object, float>.Initialize
	|
	|-RVA: 0x15B7870 Offset: 0x15B6270 VA: 0x1815B7870
	|-Dictionary<object, StylePropertyValue>.Initialize
	|
	|-RVA: 0x15B7790 Offset: 0x15B6190 VA: 0x1815B7790
	|-Dictionary<object, TextureId>.Initialize
	|
	|-RVA: 0x15B7A30 Offset: 0x15B6430 VA: 0x1815B7A30
	|-Dictionary<object, XPathNodeRef>.Initialize
	|
	|-RVA: 0x15C82A0 Offset: 0x15C6CA0 VA: 0x1815C82A0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Initialize
	|
	|-RVA: 0x15C80E0 Offset: 0x15C6AE0 VA: 0x1815C80E0
	|-Dictionary<object, InputControlLayout.ControlItem>.Initialize
	|
	|-RVA: 0x15C8000 Offset: 0x15C6A00 VA: 0x1815C8000
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Initialize
	|
	|-RVA: 0x15C8380 Offset: 0x15C6D80 VA: 0x1815C8380
	|-Dictionary<object, JsonParser.JsonValue>.Initialize
	|
	|-RVA: 0x15C81C0 Offset: 0x15C6BC0 VA: 0x1815C81C0
	|-Dictionary<object, LiquidVolume.MeshCache>.Initialize
	|
	|-RVA: 0x15C7E40 Offset: 0x15C6840 VA: 0x1815C7E40
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Initialize
	|
	|-RVA: 0x15C7F20 Offset: 0x15C6920 VA: 0x1815C7F20
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Initialize
	|
	|-RVA: 0x15DA010 Offset: 0x15D8A10 VA: 0x1815DA010
	|-Dictionary<object, SVGDocument.ClipData>.Initialize
	|
	|-RVA: 0x15D9BB0 Offset: 0x15D85B0 VA: 0x1815D9BB0
	|-Dictionary<object, SVGDocument.MaskData>.Initialize
	|
	|-RVA: 0x15D9F30 Offset: 0x15D8930 VA: 0x1815D9F30
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Initialize
	|
	|-RVA: 0x15D9AD0 Offset: 0x15D84D0 VA: 0x1815D9AD0
	|-Dictionary<object, SVGDocument.PatternData>.Initialize
	|
	|-RVA: 0x15D9E50 Offset: 0x15D8850 VA: 0x1815D9E50
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Initialize
	|
	|-RVA: 0x15D9D70 Offset: 0x15D8770 VA: 0x1815D9D70
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Initialize
	|
	|-RVA: 0x15D9C90 Offset: 0x15D8690 VA: 0x1815D9C90
	|-Dictionary<Scene, object>.Initialize
	|
	|-RVA: 0x15EB980 Offset: 0x15EA380 VA: 0x1815EB980
	|-Dictionary<TerrainTileCoord, object>.Initialize
	|
	|-RVA: 0x15EBB40 Offset: 0x15EA540 VA: 0x1815EBB40
	|-Dictionary<ushort, object>.Initialize
	|
	|-RVA: 0x15EB7C0 Offset: 0x15EA1C0 VA: 0x1815EB7C0
	|-Dictionary<ushort, RpcLink>.Initialize
	|
	|-RVA: 0x15EBA60 Offset: 0x15EA460 VA: 0x1815EBA60
	|-Dictionary<ushort, ushort>.Initialize
	|
	|-RVA: 0x15EB8A0 Offset: 0x15EA2A0 VA: 0x1815EB8A0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Initialize
	|
	|-RVA: 0x15EBD00 Offset: 0x15EA700 VA: 0x1815EBD00
	|-Dictionary<uint, int>.Initialize
	|
	|-RVA: 0x15EBC20 Offset: 0x15EA620 VA: 0x1815EBC20
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Initialize
	|
	|-RVA: 0x15FED80 Offset: 0x15FD780 VA: 0x1815FED80
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Initialize
	|
	|-RVA: 0x15FEBC0 Offset: 0x15FD5C0 VA: 0x1815FEBC0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Initialize
	|
	|-RVA: 0x15FF100 Offset: 0x15FDB00 VA: 0x1815FF100
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Initialize
	|
	|-RVA: 0x15FF020 Offset: 0x15FDA20 VA: 0x1815FF020
	|-Dictionary<uint, object>.Initialize
	|
	|-RVA: 0x15FEF40 Offset: 0x15FD940 VA: 0x1815FEF40
	|-Dictionary<uint, RpcLinkType>.Initialize
	|
	|-RVA: 0x15FEE60 Offset: 0x15FD860 VA: 0x1815FEE60
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Initialize
	|
	|-RVA: 0x15FECA0 Offset: 0x15FD6A0 VA: 0x1815FECA0
	|-Dictionary<ulong, object>.Initialize
	|
	|-RVA: 0x1613090 Offset: 0x1611A90 VA: 0x181613090
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Initialize
	|
	|-RVA: 0x1613410 Offset: 0x1611E10 VA: 0x181613410
	|-Dictionary<Vector2Int, object>.Initialize
	|
	|-RVA: 0x1613330 Offset: 0x1611D30 VA: 0x181613330
	|-Dictionary<Vector3, Vector3>.Initialize
	|
	|-RVA: 0x1613250 Offset: 0x1611C50 VA: 0x181613250
	|-Dictionary<Vector3Int, object>.Initialize
	|
	|-RVA: 0x1612FB0 Offset: 0x16119B0 VA: 0x181612FB0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Initialize
	|
	|-RVA: 0x1613170 Offset: 0x1611B70 VA: 0x181613170
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Initialize
	|
	|-RVA: 0x1612ED0 Offset: 0x16118D0 VA: 0x181612ED0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Initialize
	|
	|-RVA: 0x1627C30 Offset: 0x1626630 VA: 0x181627C30
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Initialize
	|
	|-RVA: 0x1627ED0 Offset: 0x16268D0 VA: 0x181627ED0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Initialize
	|
	|-RVA: 0x1627D10 Offset: 0x1626710 VA: 0x181627D10
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Initialize
	|
	|-RVA: 0x1627DF0 Offset: 0x16267F0 VA: 0x181627DF0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Initialize
	*/

	// RVA: -1 Offset: -1
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F9CB0 Offset: 0x14F86B0 VA: 0x1814F9CB0
	|-Dictionary<KeyValuePair<object, object>, object>.TryInsert
	|
	|-RVA: 0x14F8A80 Offset: 0x14F7480 VA: 0x1814F8A80
	|-Dictionary<StructMultiKey<object, object>, object>.TryInsert
	|
	|-RVA: 0x14F9060 Offset: 0x14F7A60 VA: 0x1814F9060
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.TryInsert
	|
	|-RVA: 0x14F96D0 Offset: 0x14F80D0 VA: 0x1814F96D0
	|-Dictionary<ValueTuple<object, int>, object>.TryInsert
	|
	|-RVA: 0x14FA2B0 Offset: 0x14F8CB0 VA: 0x1814FA2B0
	|-Dictionary<ValueTuple<object, object>, object>.TryInsert
	|
	|-RVA: 0x150C930 Offset: 0x150B330 VA: 0x18150C930
	|-Dictionary<Bounds, object>.TryInsert
	|
	|-RVA: 0x150E4A0 Offset: 0x150CEA0 VA: 0x18150E4A0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.TryInsert
	|
	|-RVA: 0x150CF70 Offset: 0x150B970 VA: 0x18150CF70
	|-Dictionary<CSteamID, int>.TryInsert
	|
	|-RVA: 0x150D4B0 Offset: 0x150BEB0 VA: 0x18150D4B0
	|-Dictionary<FullRank, object>.TryInsert
	|
	|-RVA: 0x150EB90 Offset: 0x150D590 VA: 0x18150EB90
	|-Dictionary<Guid, object>.TryInsert
	|
	|-RVA: 0x150DF70 Offset: 0x150C970 VA: 0x18150DF70
	|-Dictionary<HSteamNetConnection, int>.TryInsert
	|
	|-RVA: 0x150D9E0 Offset: 0x150C3E0 VA: 0x18150D9E0
	|-Dictionary<Hash128, int>.TryInsert
	|
	|-RVA: 0x1521260 Offset: 0x151FC60 VA: 0x181521260
	|-Dictionary<Hash128, object>.TryInsert
	|
	|-RVA: 0x1521D50 Offset: 0x1520750 VA: 0x181521D50
	|-Dictionary<Int2, int>.TryInsert
	|
	|-RVA: 0x1522240 Offset: 0x1520C40 VA: 0x181522240
	|-Dictionary<Int2, object>.TryInsert
	|
	|-RVA: 0x1522CD0 Offset: 0x15216D0 VA: 0x181522CD0
	|-Dictionary<Int3, int>.TryInsert
	|
	|-RVA: 0x1520D60 Offset: 0x151F760 VA: 0x181520D60
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.TryInsert
	|
	|-RVA: 0x1522770 Offset: 0x1521170 VA: 0x181522770
	|-Dictionary<int, TreeViewItemData<object>>.TryInsert
	|
	|-RVA: 0x1521830 Offset: 0x1520230 VA: 0x181521830
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.TryInsert
	|
	|-RVA: 0x1532B80 Offset: 0x1531580 VA: 0x181532B80
	|-Dictionary<int, bool>.TryInsert
	|
	|-RVA: 0x1532180 Offset: 0x1530B80 VA: 0x181532180
	|-Dictionary<int, ByteEnum>.TryInsert
	|
	|-RVA: 0x1533080 Offset: 0x1531A80 VA: 0x181533080
	|-Dictionary<int, CSteamID>.TryInsert
	|
	|-RVA: 0x1531C80 Offset: 0x1530680 VA: 0x181531C80
	|-Dictionary<int, HSteamNetConnection>.TryInsert
	|
	|-RVA: 0x1532680 Offset: 0x1531080 VA: 0x181532680
	|-Dictionary<int, short>.TryInsert
	|
	|-RVA: 0x1533580 Offset: 0x1531F80 VA: 0x181533580
	|-Dictionary<int, Int3>.TryInsert
	|
	|-RVA: 0x1531780 Offset: 0x1530180 VA: 0x181531780
	|-Dictionary<int, int>.TryInsert
	|
	|-RVA: 0x1543E30 Offset: 0x1542830 VA: 0x181543E30
	|-Dictionary<int, Int32Enum>.TryInsert
	|
	|-RVA: 0x1543400 Offset: 0x1541E00 VA: 0x181543400
	|-Dictionary<int, long>.TryInsert
	|
	|-RVA: 0x15424D0 Offset: 0x1540ED0 VA: 0x1815424D0
	|-Dictionary<int, object>.TryInsert
	|
	|-RVA: 0x1544330 Offset: 0x1542D30 VA: 0x181544330
	|-Dictionary<int, RenderInstancedDataLayout>.TryInsert
	|
	|-RVA: 0x1542A10 Offset: 0x1541410 VA: 0x181542A10
	|-Dictionary<int, float>.TryInsert
	|
	|-RVA: 0x1543900 Offset: 0x1542300 VA: 0x181543900
	|-Dictionary<int, TreeItem>.TryInsert
	|
	|-RVA: 0x1542F00 Offset: 0x1541900 VA: 0x181542F00
	|-Dictionary<int, uint>.TryInsert
	|
	|-RVA: 0x1552EB0 Offset: 0x15518B0 VA: 0x181552EB0
	|-Dictionary<int, ulong>.TryInsert
	|
	|-RVA: 0x1551FA0 Offset: 0x15509A0 VA: 0x181551FA0
	|-Dictionary<int, Vector2Int>.TryInsert
	|
	|-RVA: 0x15524A0 Offset: 0x1550EA0 VA: 0x1815524A0
	|-Dictionary<int, Vector3>.TryInsert
	|
	|-RVA: 0x15529B0 Offset: 0x15513B0 VA: 0x1815529B0
	|-Dictionary<int, Vector4>.TryInsert
	|
	|-RVA: 0x15538E0 Offset: 0x15522E0 VA: 0x1815538E0
	|-Dictionary<int, Multipass.TransportIdData>.TryInsert
	|
	|-RVA: 0x1553DE0 Offset: 0x15527E0 VA: 0x181553DE0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.TryInsert
	|
	|-RVA: 0x15533B0 Offset: 0x1551DB0 VA: 0x1815533B0
	|-Dictionary<int, NetworkAnimator.StateChange>.TryInsert
	|
	|-RVA: 0x1564090 Offset: 0x1562A90 VA: 0x181564090
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.TryInsert
	|
	|-RVA: 0x1564B90 Offset: 0x1563590 VA: 0x181564B90
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.TryInsert
	|
	|-RVA: 0x15650F0 Offset: 0x1563AF0 VA: 0x1815650F0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.TryInsert
	|
	|-RVA: 0x15646A0 Offset: 0x15630A0 VA: 0x1815646A0
	|-Dictionary<Int32Enum, bool>.TryInsert
	|
	|-RVA: 0x1565650 Offset: 0x1564050 VA: 0x181565650
	|-Dictionary<Int32Enum, int>.TryInsert
	|
	|-RVA: 0x1565B40 Offset: 0x1564540 VA: 0x181565B40
	|-Dictionary<Int32Enum, Int32Enum>.TryInsert
	|
	|-RVA: 0x1566030 Offset: 0x1564A30 VA: 0x181566030
	|-Dictionary<Int32Enum, object>.TryInsert
	|
	|-RVA: 0x1579970 Offset: 0x1578370 VA: 0x181579970
	|-Dictionary<long, ComputedStyle>.TryInsert
	|
	|-RVA: 0x1578870 Offset: 0x1577270 VA: 0x181578870
	|-Dictionary<long, object>.TryInsert
	|
	|-RVA: 0x1578330 Offset: 0x1576D30 VA: 0x181578330
	|-Dictionary<IntPtr, object>.TryInsert
	|
	|-RVA: 0x1577D50 Offset: 0x1576750 VA: 0x181577D50
	|-Dictionary<InternedString, InternedString>.TryInsert
	|
	|-RVA: 0x1579390 Offset: 0x1577D90 VA: 0x181579390
	|-Dictionary<InternedString, object>.TryInsert
	|
	|-RVA: 0x1578DB0 Offset: 0x15777B0 VA: 0x181578DB0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.TryInsert
	|
	|-RVA: 0x1579F40 Offset: 0x1578940 VA: 0x181579F40
	|-Dictionary<NativeAddr, object>.TryInsert
	|
	|-RVA: 0x15A0BB0 Offset: 0x159F5B0 VA: 0x1815A0BB0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.TryInsert
	|
	|-RVA: 0x15A1920 Offset: 0x15A0320 VA: 0x1815A1920
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.TryInsert
	|
	|-RVA: 0x15A0760 Offset: 0x159F160 VA: 0x1815A0760
	|-Dictionary<object, bool>.TryInsert
	|
	|-RVA: 0x15A1DE0 Offset: 0x15A07E0 VA: 0x1815A1DE0
	|-Dictionary<object, Bounds>.TryInsert
	|
	|-RVA: 0x15A1480 Offset: 0x159FE80 VA: 0x1815A1480
	|-Dictionary<object, Color>.TryInsert
	|
	|-RVA: 0x15A1030 Offset: 0x159FA30 VA: 0x1815A1030
	|-Dictionary<object, Color>.TryInsert
	|
	|-RVA: 0x15A0320 Offset: 0x159ED20 VA: 0x1815A0320
	|-Dictionary<object, Color32>.TryInsert
	|
	|-RVA: 0x15B2BF0 Offset: 0x15B15F0 VA: 0x1815B2BF0
	|-Dictionary<object, double>.TryInsert
	|
	|-RVA: 0x15B2350 Offset: 0x15B0D50 VA: 0x1815B2350
	|-Dictionary<object, int>.TryInsert
	|
	|-RVA: 0x15B1A80 Offset: 0x15B0480 VA: 0x1815B1A80
	|-Dictionary<object, Int32Enum>.TryInsert
	|
	|-RVA: 0x15B27A0 Offset: 0x15B11A0 VA: 0x1815B27A0
	|-Dictionary<object, long>.TryInsert
	|
	|-RVA: 0x15B1ED0 Offset: 0x15B08D0 VA: 0x1815B1ED0
	|-Dictionary<object, object>.TryInsert
	|
	|-RVA: 0x15B11A0 Offset: 0x15AFBA0 VA: 0x1815B11A0
	|-Dictionary<object, Playable>.TryInsert
	|
	|-RVA: 0x15B15F0 Offset: 0x15AFFF0 VA: 0x1815B15F0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.TryInsert
	|
	|-RVA: 0x15C25F0 Offset: 0x15C0FF0 VA: 0x1815C25F0
	|-Dictionary<object, RaycastHit>.TryInsert
	|
	|-RVA: 0x15C1910 Offset: 0x15C0310 VA: 0x1815C1910
	|-Dictionary<object, Rect>.TryInsert
	|
	|-RVA: 0x15C2AA0 Offset: 0x15C14A0 VA: 0x1815C2AA0
	|-Dictionary<object, ResourceLocator>.TryInsert
	|
	|-RVA: 0x15C1D60 Offset: 0x15C0760 VA: 0x1815C1D60
	|-Dictionary<object, float>.TryInsert
	|
	|-RVA: 0x15C1490 Offset: 0x15BFE90 VA: 0x1815C1490
	|-Dictionary<object, StylePropertyValue>.TryInsert
	|
	|-RVA: 0x15C21B0 Offset: 0x15C0BB0 VA: 0x1815C21B0
	|-Dictionary<object, TextureId>.TryInsert
	|
	|-RVA: 0x15C1010 Offset: 0x15BFA10 VA: 0x1815C1010
	|-Dictionary<object, XPathNodeRef>.TryInsert
	|
	|-RVA: 0x15D48A0 Offset: 0x15D32A0 VA: 0x1815D48A0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.TryInsert
	|
	|-RVA: 0x15D3EC0 Offset: 0x15D28C0 VA: 0x1815D3EC0
	|-Dictionary<object, InputControlLayout.ControlItem>.TryInsert
	|
	|-RVA: 0x15D4460 Offset: 0x15D2E60 VA: 0x1815D4460
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.TryInsert
	|
	|-RVA: 0x15D3560 Offset: 0x15D1F60 VA: 0x1815D3560
	|-Dictionary<object, JsonParser.JsonValue>.TryInsert
	|
	|-RVA: 0x15D2C80 Offset: 0x15D1680 VA: 0x1815D2C80
	|-Dictionary<object, LiquidVolume.MeshCache>.TryInsert
	|
	|-RVA: 0x15D3120 Offset: 0x15D1B20 VA: 0x1815D3120
	|-Dictionary<object, ObjectPool.DelayedStoreData>.TryInsert
	|
	|-RVA: 0x15D3A20 Offset: 0x15D2420 VA: 0x1815D3A20
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.TryInsert
	|
	|-RVA: 0x15E4FD0 Offset: 0x15E39D0 VA: 0x1815E4FD0
	|-Dictionary<object, SVGDocument.ClipData>.TryInsert
	|
	|-RVA: 0x15E5410 Offset: 0x15E3E10 VA: 0x1815E5410
	|-Dictionary<object, SVGDocument.MaskData>.TryInsert
	|
	|-RVA: 0x15E42A0 Offset: 0x15E2CA0 VA: 0x1815E42A0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.TryInsert
	|
	|-RVA: 0x15E3DE0 Offset: 0x15E27E0 VA: 0x1815E3DE0
	|-Dictionary<object, SVGDocument.PatternData>.TryInsert
	|
	|-RVA: 0x15E4B50 Offset: 0x15E3550 VA: 0x1815E4B50
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.TryInsert
	|
	|-RVA: 0x15E4710 Offset: 0x15E3110 VA: 0x1815E4710
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.TryInsert
	|
	|-RVA: 0x15E38C0 Offset: 0x15E22C0 VA: 0x1815E38C0
	|-Dictionary<Scene, object>.TryInsert
	|
	|-RVA: 0x15F7880 Offset: 0x15F6280 VA: 0x1815F7880
	|-Dictionary<TerrainTileCoord, object>.TryInsert
	|
	|-RVA: 0x15F9260 Offset: 0x15F7C60 VA: 0x1815F9260
	|-Dictionary<ushort, object>.TryInsert
	|
	|-RVA: 0x15F87F0 Offset: 0x15F71F0 VA: 0x1815F87F0
	|-Dictionary<ushort, RpcLink>.TryInsert
	|
	|-RVA: 0x15F7380 Offset: 0x15F5D80 VA: 0x1815F7380
	|-Dictionary<ushort, ushort>.TryInsert
	|
	|-RVA: 0x15F8CF0 Offset: 0x15F76F0 VA: 0x1815F8CF0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.TryInsert
	|
	|-RVA: 0x15F7DD0 Offset: 0x15F67D0 VA: 0x1815F7DD0
	|-Dictionary<uint, int>.TryInsert
	|
	|-RVA: 0x15F82D0 Offset: 0x15F6CD0 VA: 0x1815F82D0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryInsert
	|
	|-RVA: 0x160AAE0 Offset: 0x16094E0 VA: 0x18160AAE0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryInsert
	|
	|-RVA: 0x160B000 Offset: 0x1609A00 VA: 0x18160B000
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryInsert
	|
	|-RVA: 0x160B520 Offset: 0x1609F20 VA: 0x18160B520
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryInsert
	|
	|-RVA: 0x1609B70 Offset: 0x1608570 VA: 0x181609B70
	|-Dictionary<uint, object>.TryInsert
	|
	|-RVA: 0x160A5E0 Offset: 0x1608FE0 VA: 0x18160A5E0
	|-Dictionary<uint, RpcLinkType>.TryInsert
	|
	|-RVA: 0x160A0B0 Offset: 0x1608AB0 VA: 0x18160A0B0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.TryInsert
	|
	|-RVA: 0x1609630 Offset: 0x1608030 VA: 0x181609630
	|-Dictionary<ulong, object>.TryInsert
	|
	|-RVA: 0x1621F10 Offset: 0x1620910 VA: 0x181621F10
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.TryInsert
	|
	|-RVA: 0x1620100 Offset: 0x161EB00 VA: 0x181620100
	|-Dictionary<Vector2Int, object>.TryInsert
	|
	|-RVA: 0x16218A0 Offset: 0x16202A0 VA: 0x1816218A0
	|-Dictionary<Vector3, Vector3>.TryInsert
	|
	|-RVA: 0x1620650 Offset: 0x161F050 VA: 0x181620650
	|-Dictionary<Vector3Int, object>.TryInsert
	|
	|-RVA: 0x1622AF0 Offset: 0x16214F0 VA: 0x181622AF0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryInsert
	|
	|-RVA: 0x1620C70 Offset: 0x161F670 VA: 0x181620C70
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryInsert
	|
	|-RVA: 0x1622480 Offset: 0x1620E80 VA: 0x181622480
	|-Dictionary<Regex.CachedCodeEntryKey, object>.TryInsert
	|
	|-RVA: 0x162E520 Offset: 0x162CF20 VA: 0x18162E520
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.TryInsert
	|
	|-RVA: 0x162EAF0 Offset: 0x162D4F0 VA: 0x18162EAF0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.TryInsert
	|
	|-RVA: 0x162D9D0 Offset: 0x162C3D0 VA: 0x18162D9D0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.TryInsert
	|
	|-RVA: 0x162DFD0 Offset: 0x162C9D0 VA: 0x18162DFD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryInsert
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F0CB0 Offset: 0x14EF6B0 VA: 0x1814F0CB0
	|-Dictionary<KeyValuePair<object, object>, object>.OnDeserialization
	|
	|-RVA: 0x14F1080 Offset: 0x14EFA80 VA: 0x1814F1080
	|-Dictionary<StructMultiKey<object, object>, object>.OnDeserialization
	|
	|-RVA: 0x14F0890 Offset: 0x14EF290 VA: 0x1814F0890
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.OnDeserialization
	|
	|-RVA: 0x14F1450 Offset: 0x14EFE50 VA: 0x1814F1450
	|-Dictionary<ValueTuple<object, int>, object>.OnDeserialization
	|
	|-RVA: 0x14F04C0 Offset: 0x14EEEC0 VA: 0x1814F04C0
	|-Dictionary<ValueTuple<object, object>, object>.OnDeserialization
	|
	|-RVA: 0x1502A80 Offset: 0x1501480 VA: 0x181502A80
	|-Dictionary<Bounds, object>.OnDeserialization
	|
	|-RVA: 0x15022B0 Offset: 0x1500CB0 VA: 0x1815022B0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.OnDeserialization
	|
	|-RVA: 0x15026D0 Offset: 0x15010D0 VA: 0x1815026D0
	|-Dictionary<CSteamID, int>.OnDeserialization
	|
	|-RVA: 0x1501780 Offset: 0x1500180 VA: 0x181501780
	|-Dictionary<FullRank, object>.OnDeserialization
	|
	|-RVA: 0x15013B0 Offset: 0x14FFDB0 VA: 0x1815013B0
	|-Dictionary<Guid, object>.OnDeserialization
	|
	|-RVA: 0x1501B30 Offset: 0x1500530 VA: 0x181501B30
	|-Dictionary<HSteamNetConnection, int>.OnDeserialization
	|
	|-RVA: 0x1501EE0 Offset: 0x15008E0 VA: 0x181501EE0
	|-Dictionary<Hash128, int>.OnDeserialization
	|
	|-RVA: 0x15175D0 Offset: 0x1515FD0 VA: 0x1815175D0
	|-Dictionary<Hash128, object>.OnDeserialization
	|
	|-RVA: 0x15179A0 Offset: 0x15163A0 VA: 0x1815179A0
	|-Dictionary<Int2, int>.OnDeserialization
	|
	|-RVA: 0x1517220 Offset: 0x1515C20 VA: 0x181517220
	|-Dictionary<Int2, object>.OnDeserialization
	|
	|-RVA: 0x1515B60 Offset: 0x1514560 VA: 0x181515B60
	|-Dictionary<Int3, int>.OnDeserialization
	|
	|-RVA: 0x15166D0 Offset: 0x15150D0 VA: 0x1815166D0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.OnDeserialization
	|
	|-RVA: 0x1516A80 Offset: 0x1515480 VA: 0x181516A80
	|-Dictionary<int, TreeViewItemData<object>>.OnDeserialization
	|
	|-RVA: 0x1515F40 Offset: 0x1514940 VA: 0x181515F40
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.OnDeserialization
	|
	|-RVA: 0x1529450 Offset: 0x1527E50 VA: 0x181529450
	|-Dictionary<int, bool>.OnDeserialization
	|
	|-RVA: 0x1529F60 Offset: 0x1528960 VA: 0x181529F60
	|-Dictionary<int, ByteEnum>.OnDeserialization
	|
	|-RVA: 0x1529800 Offset: 0x1528200 VA: 0x181529800
	|-Dictionary<int, CSteamID>.OnDeserialization
	|
	|-RVA: 0x15290A0 Offset: 0x1527AA0 VA: 0x1815290A0
	|-Dictionary<int, HSteamNetConnection>.OnDeserialization
	|
	|-RVA: 0x1529BB0 Offset: 0x15285B0 VA: 0x181529BB0
	|-Dictionary<int, short>.OnDeserialization
	|
	|-RVA: 0x1528910 Offset: 0x1527310 VA: 0x181528910
	|-Dictionary<int, Int3>.OnDeserialization
	|
	|-RVA: 0x152A310 Offset: 0x1528D10 VA: 0x18152A310
	|-Dictionary<int, int>.OnDeserialization
	|
	|-RVA: 0x153A740 Offset: 0x1539140 VA: 0x18153A740
	|-Dictionary<int, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x1538D30 Offset: 0x1537730 VA: 0x181538D30
	|-Dictionary<int, long>.OnDeserialization
	|
	|-RVA: 0x1539490 Offset: 0x1537E90 VA: 0x181539490
	|-Dictionary<int, object>.OnDeserialization
	|
	|-RVA: 0x1539840 Offset: 0x1538240 VA: 0x181539840
	|-Dictionary<int, RenderInstancedDataLayout>.OnDeserialization
	|
	|-RVA: 0x15390E0 Offset: 0x1537AE0 VA: 0x1815390E0
	|-Dictionary<int, float>.OnDeserialization
	|
	|-RVA: 0x1539FB0 Offset: 0x15389B0 VA: 0x181539FB0
	|-Dictionary<int, TreeItem>.OnDeserialization
	|
	|-RVA: 0x153AAF0 Offset: 0x15394F0 VA: 0x18153AAF0
	|-Dictionary<int, uint>.OnDeserialization
	|
	|-RVA: 0x154A740 Offset: 0x1549140 VA: 0x18154A740
	|-Dictionary<int, ulong>.OnDeserialization
	|
	|-RVA: 0x1549450 Offset: 0x1547E50 VA: 0x181549450
	|-Dictionary<int, Vector2Int>.OnDeserialization
	|
	|-RVA: 0x1549FB0 Offset: 0x15489B0 VA: 0x181549FB0
	|-Dictionary<int, Vector3>.OnDeserialization
	|
	|-RVA: 0x154AEB0 Offset: 0x15498B0 VA: 0x18154AEB0
	|-Dictionary<int, Vector4>.OnDeserialization
	|
	|-RVA: 0x15490A0 Offset: 0x1547AA0 VA: 0x1815490A0
	|-Dictionary<int, Multipass.TransportIdData>.OnDeserialization
	|
	|-RVA: 0x154AAF0 Offset: 0x15494F0 VA: 0x18154AAF0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.OnDeserialization
	|
	|-RVA: 0x1549800 Offset: 0x1548200 VA: 0x181549800
	|-Dictionary<int, NetworkAnimator.StateChange>.OnDeserialization
	|
	|-RVA: 0x1559910 Offset: 0x1558310 VA: 0x181559910
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.OnDeserialization
	|
	|-RVA: 0x155B3A0 Offset: 0x1559DA0 VA: 0x18155B3A0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.OnDeserialization
	|
	|-RVA: 0x155A490 Offset: 0x1558E90 VA: 0x18155A490
	|-Dictionary<int, TextResourceManager.FontAssetRef>.OnDeserialization
	|
	|-RVA: 0x155AFF0 Offset: 0x15599F0 VA: 0x18155AFF0
	|-Dictionary<Int32Enum, bool>.OnDeserialization
	|
	|-RVA: 0x155AC40 Offset: 0x1559640 VA: 0x18155AC40
	|-Dictionary<Int32Enum, int>.OnDeserialization
	|
	|-RVA: 0x1559D30 Offset: 0x1558730 VA: 0x181559D30
	|-Dictionary<Int32Enum, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x155A0E0 Offset: 0x1558AE0 VA: 0x18155A0E0
	|-Dictionary<Int32Enum, object>.OnDeserialization
	|
	|-RVA: 0x156D900 Offset: 0x156C300 VA: 0x18156D900
	|-Dictionary<long, ComputedStyle>.OnDeserialization
	|
	|-RVA: 0x156D1A0 Offset: 0x156BBA0 VA: 0x18156D1A0
	|-Dictionary<long, object>.OnDeserialization
	|
	|-RVA: 0x156D550 Offset: 0x156BF50 VA: 0x18156D550
	|-Dictionary<IntPtr, object>.OnDeserialization
	|
	|-RVA: 0x156CDB0 Offset: 0x156B7B0 VA: 0x18156CDB0
	|-Dictionary<InternedString, InternedString>.OnDeserialization
	|
	|-RVA: 0x156E500 Offset: 0x156CF00 VA: 0x18156E500
	|-Dictionary<InternedString, object>.OnDeserialization
	|
	|-RVA: 0x156E110 Offset: 0x156CB10 VA: 0x18156E110
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.OnDeserialization
	|
	|-RVA: 0x156E8D0 Offset: 0x156D2D0 VA: 0x18156E8D0
	|-Dictionary<NativeAddr, object>.OnDeserialization
	|
	|-RVA: 0x1597920 Offset: 0x1596320 VA: 0x181597920
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.OnDeserialization
	|
	|-RVA: 0x1596320 Offset: 0x1594D20 VA: 0x181596320
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.OnDeserialization
	|
	|-RVA: 0x1595C10 Offset: 0x1594610 VA: 0x181595C10
	|-Dictionary<object, bool>.OnDeserialization
	|
	|-RVA: 0x1594DA0 Offset: 0x15937A0 VA: 0x181594DA0
	|-Dictionary<object, Bounds>.OnDeserialization
	|
	|-RVA: 0x1596A90 Offset: 0x1595490 VA: 0x181596A90
	|-Dictionary<object, Color>.OnDeserialization
	|
	|-RVA: 0x15954F0 Offset: 0x1593EF0 VA: 0x1815954F0
	|-Dictionary<object, Color>.OnDeserialization
	|
	|-RVA: 0x15971F0 Offset: 0x1595BF0 VA: 0x1815971F0
	|-Dictionary<object, Color32>.OnDeserialization
	|
	|-RVA: 0x15A9000 Offset: 0x15A7A00 VA: 0x1815A9000
	|-Dictionary<object, double>.OnDeserialization
	|
	|-RVA: 0x15A9720 Offset: 0x15A8120 VA: 0x1815A9720
	|-Dictionary<object, int>.OnDeserialization
	|
	|-RVA: 0x15A88F0 Offset: 0x15A72F0 VA: 0x1815A88F0
	|-Dictionary<object, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x15A9E30 Offset: 0x15A8830 VA: 0x1815A9E30
	|-Dictionary<object, long>.OnDeserialization
	|
	|-RVA: 0x15A81D0 Offset: 0x15A6BD0 VA: 0x1815A81D0
	|-Dictionary<object, object>.OnDeserialization
	|
	|-RVA: 0x15A7360 Offset: 0x15A5D60 VA: 0x1815A7360
	|-Dictionary<object, Playable>.OnDeserialization
	|
	|-RVA: 0x15A7A80 Offset: 0x15A6480 VA: 0x1815A7A80
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.OnDeserialization
	|
	|-RVA: 0x15B9EC0 Offset: 0x15B88C0 VA: 0x1815B9EC0
	|-Dictionary<object, RaycastHit>.OnDeserialization
	|
	|-RVA: 0x15B7B10 Offset: 0x15B6510 VA: 0x1815B7B10
	|-Dictionary<object, Rect>.OnDeserialization
	|
	|-RVA: 0x15B9070 Offset: 0x15B7A70 VA: 0x1815B9070
	|-Dictionary<object, ResourceLocator>.OnDeserialization
	|
	|-RVA: 0x15B8950 Offset: 0x15B7350 VA: 0x1815B8950
	|-Dictionary<object, float>.OnDeserialization
	|
	|-RVA: 0x15BA630 Offset: 0x15B9030 VA: 0x1815BA630
	|-Dictionary<object, StylePropertyValue>.OnDeserialization
	|
	|-RVA: 0x15B9790 Offset: 0x15B8190 VA: 0x1815B9790
	|-Dictionary<object, TextureId>.OnDeserialization
	|
	|-RVA: 0x15B8230 Offset: 0x15B6C30 VA: 0x1815B8230
	|-Dictionary<object, XPathNodeRef>.OnDeserialization
	|
	|-RVA: 0x15CADA0 Offset: 0x15C97A0 VA: 0x1815CADA0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.OnDeserialization
	|
	|-RVA: 0x15CA1F0 Offset: 0x15C8BF0 VA: 0x1815CA1F0
	|-Dictionary<object, InputControlLayout.ControlItem>.OnDeserialization
	|
	|-RVA: 0x15C8BC0 Offset: 0x15C75C0 VA: 0x1815C8BC0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.OnDeserialization
	|
	|-RVA: 0x15C9A50 Offset: 0x15C8450 VA: 0x1815C9A50
	|-Dictionary<object, JsonParser.JsonValue>.OnDeserialization
	|
	|-RVA: 0x15C8460 Offset: 0x15C6E60 VA: 0x1815C8460
	|-Dictionary<object, LiquidVolume.MeshCache>.OnDeserialization
	|
	|-RVA: 0x15CA670 Offset: 0x15C9070 VA: 0x1815CA670
	|-Dictionary<object, ObjectPool.DelayedStoreData>.OnDeserialization
	|
	|-RVA: 0x15C92F0 Offset: 0x15C7CF0 VA: 0x1815C92F0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.OnDeserialization
	|
	|-RVA: 0x15DC1B0 Offset: 0x15DABB0 VA: 0x1815DC1B0
	|-Dictionary<object, SVGDocument.ClipData>.OnDeserialization
	|
	|-RVA: 0x15DA0F0 Offset: 0x15D8AF0 VA: 0x1815DA0F0
	|-Dictionary<object, SVGDocument.MaskData>.OnDeserialization
	|
	|-RVA: 0x15DBA70 Offset: 0x15DA470 VA: 0x1815DBA70
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.OnDeserialization
	|
	|-RVA: 0x15DABD0 Offset: 0x15D95D0 VA: 0x1815DABD0
	|-Dictionary<object, SVGDocument.PatternData>.OnDeserialization
	|
	|-RVA: 0x15DC8E0 Offset: 0x15DB2E0 VA: 0x1815DC8E0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.OnDeserialization
	|
	|-RVA: 0x15DB340 Offset: 0x15D9D40 VA: 0x1815DB340
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.OnDeserialization
	|
	|-RVA: 0x15DA820 Offset: 0x15D9220 VA: 0x1815DA820
	|-Dictionary<Scene, object>.OnDeserialization
	|
	|-RVA: 0x15ECD20 Offset: 0x15EB720 VA: 0x1815ECD20
	|-Dictionary<TerrainTileCoord, object>.OnDeserialization
	|
	|-RVA: 0x15ED0D0 Offset: 0x15EBAD0 VA: 0x1815ED0D0
	|-Dictionary<ushort, object>.OnDeserialization
	|
	|-RVA: 0x15EBDE0 Offset: 0x15EA7E0 VA: 0x1815EBDE0
	|-Dictionary<ushort, RpcLink>.OnDeserialization
	|
	|-RVA: 0x15ED480 Offset: 0x15EBE80 VA: 0x1815ED480
	|-Dictionary<ushort, ushort>.OnDeserialization
	|
	|-RVA: 0x15EC560 Offset: 0x15EAF60 VA: 0x1815EC560
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.OnDeserialization
	|
	|-RVA: 0x15EDFC0 Offset: 0x15EC9C0 VA: 0x1815EDFC0
	|-Dictionary<uint, int>.OnDeserialization
	|
	|-RVA: 0x15ED830 Offset: 0x15EC230 VA: 0x1815ED830
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.OnDeserialization
	|
	|-RVA: 0x16004B0 Offset: 0x15FEEB0 VA: 0x1816004B0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.OnDeserialization
	|
	|-RVA: 0x15FFD20 Offset: 0x15FE720 VA: 0x1815FFD20
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.OnDeserialization
	|
	|-RVA: 0x15FF1E0 Offset: 0x15FDBE0 VA: 0x1815FF1E0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.OnDeserialization
	|
	|-RVA: 0x15FF970 Offset: 0x15FE370 VA: 0x1815FF970
	|-Dictionary<uint, object>.OnDeserialization
	|
	|-RVA: 0x16013D0 Offset: 0x15FFDD0 VA: 0x1816013D0
	|-Dictionary<uint, RpcLinkType>.OnDeserialization
	|
	|-RVA: 0x1600C40 Offset: 0x15FF640 VA: 0x181600C40
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.OnDeserialization
	|
	|-RVA: 0x1601780 Offset: 0x1600180 VA: 0x181601780
	|-Dictionary<ulong, object>.OnDeserialization
	|
	|-RVA: 0x16140C0 Offset: 0x1612AC0 VA: 0x1816140C0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.OnDeserialization
	|
	|-RVA: 0x1615200 Offset: 0x1613C00 VA: 0x181615200
	|-Dictionary<Vector2Int, object>.OnDeserialization
	|
	|-RVA: 0x16134F0 Offset: 0x1611EF0 VA: 0x1816134F0
	|-Dictionary<Vector3, Vector3>.OnDeserialization
	|
	|-RVA: 0x16138F0 Offset: 0x16122F0 VA: 0x1816138F0
	|-Dictionary<Vector3Int, object>.OnDeserialization
	|
	|-RVA: 0x1614880 Offset: 0x1613280 VA: 0x181614880
	|-Dictionary<XPathNodeRef, XPathNodeRef>.OnDeserialization
	|
	|-RVA: 0x1614C70 Offset: 0x1613670 VA: 0x181614C70
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialization
	|
	|-RVA: 0x1613CD0 Offset: 0x16126D0 VA: 0x181613CD0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.OnDeserialization
	|
	|-RVA: 0x1627FB0 Offset: 0x16269B0 VA: 0x181627FB0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.OnDeserialization
	|
	|-RVA: 0x1628380 Offset: 0x1626D80 VA: 0x181628380
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.OnDeserialization
	|
	|-RVA: 0x1628B00 Offset: 0x1627500 VA: 0x181628B00
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.OnDeserialization
	|
	|-RVA: 0x1628750 Offset: 0x1627150 VA: 0x181628750
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F3030 Offset: 0x14F1A30 VA: 0x1814F3030
	|-Dictionary<KeyValuePair<object, object>, object>.Resize
	|
	|-RVA: 0x14F2A10 Offset: 0x14F1410 VA: 0x1814F2A10
	|-Dictionary<StructMultiKey<object, object>, object>.Resize
	|
	|-RVA: 0x14F2E80 Offset: 0x14F1880 VA: 0x1814F2E80
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Resize
	|
	|-RVA: 0x14F34F0 Offset: 0x14F1EF0 VA: 0x1814F34F0
	|-Dictionary<ValueTuple<object, int>, object>.Resize
	|
	|-RVA: 0x14F31E0 Offset: 0x14F1BE0 VA: 0x1814F31E0
	|-Dictionary<ValueTuple<object, object>, object>.Resize
	|
	|-RVA: 0x1504720 Offset: 0x1503120 VA: 0x181504720
	|-Dictionary<Bounds, object>.Resize
	|
	|-RVA: 0x15048D0 Offset: 0x15032D0 VA: 0x1815048D0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Resize
	|
	|-RVA: 0x1504A80 Offset: 0x1503480 VA: 0x181504A80
	|-Dictionary<CSteamID, int>.Resize
	|
	|-RVA: 0x15050C0 Offset: 0x1503AC0 VA: 0x1815050C0
	|-Dictionary<FullRank, object>.Resize
	|
	|-RVA: 0x1505590 Offset: 0x1503F90 VA: 0x181505590
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x15053D0 Offset: 0x1503DD0 VA: 0x1815053D0
	|-Dictionary<HSteamNetConnection, int>.Resize
	|
	|-RVA: 0x1504DA0 Offset: 0x15037A0 VA: 0x181504DA0
	|-Dictionary<Hash128, int>.Resize
	|
	|-RVA: 0x1519A40 Offset: 0x1518440 VA: 0x181519A40
	|-Dictionary<Hash128, object>.Resize
	|
	|-RVA: 0x1519890 Offset: 0x1518290 VA: 0x181519890
	|-Dictionary<Int2, int>.Resize
	|
	|-RVA: 0x1519220 Offset: 0x1517C20 VA: 0x181519220
	|-Dictionary<Int2, object>.Resize
	|
	|-RVA: 0x1519F00 Offset: 0x1518900 VA: 0x181519F00
	|-Dictionary<Int3, int>.Resize
	|
	|-RVA: 0x15193D0 Offset: 0x1517DD0 VA: 0x1815193D0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Resize
	|
	|-RVA: 0x15196E0 Offset: 0x15180E0 VA: 0x1815196E0
	|-Dictionary<int, TreeViewItemData<object>>.Resize
	|
	|-RVA: 0x1519D50 Offset: 0x1518750 VA: 0x181519D50
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Resize
	|
	|-RVA: 0x152AFB0 Offset: 0x15299B0 VA: 0x18152AFB0
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x152BC40 Offset: 0x152A640 VA: 0x18152BC40
	|-Dictionary<int, ByteEnum>.Resize
	|
	|-RVA: 0x152B420 Offset: 0x1529E20 VA: 0x18152B420
	|-Dictionary<int, CSteamID>.Resize
	|
	|-RVA: 0x152B930 Offset: 0x152A330 VA: 0x18152B930
	|-Dictionary<int, HSteamNetConnection>.Resize
	|
	|-RVA: 0x152B780 Offset: 0x152A180 VA: 0x18152B780
	|-Dictionary<int, short>.Resize
	|
	|-RVA: 0x152B5D0 Offset: 0x1529FD0 VA: 0x18152B5D0
	|-Dictionary<int, Int3>.Resize
	|
	|-RVA: 0x152ACA0 Offset: 0x15296A0 VA: 0x18152ACA0
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x153C350 Offset: 0x153AD50 VA: 0x18153C350
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x153B9D0 Offset: 0x153A3D0 VA: 0x18153B9D0
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x153C920 Offset: 0x153B320 VA: 0x18153C920
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x153B6C0 Offset: 0x153A0C0 VA: 0x18153B6C0
	|-Dictionary<int, RenderInstancedDataLayout>.Resize
	|
	|-RVA: 0x153BE40 Offset: 0x153A840 VA: 0x18153BE40
	|-Dictionary<int, float>.Resize
	|
	|-RVA: 0x153BFF0 Offset: 0x153A9F0 VA: 0x18153BFF0
	|-Dictionary<int, TreeItem>.Resize
	|
	|-RVA: 0x153C1A0 Offset: 0x153ABA0 VA: 0x18153C1A0
	|-Dictionary<int, uint>.Resize
	|
	|-RVA: 0x154C340 Offset: 0x154AD40 VA: 0x18154C340
	|-Dictionary<int, ulong>.Resize
	|
	|-RVA: 0x154BB70 Offset: 0x154A570 VA: 0x18154BB70
	|-Dictionary<int, Vector2Int>.Resize
	|
	|-RVA: 0x154CC20 Offset: 0x154B620 VA: 0x18154CC20
	|-Dictionary<int, Vector3>.Resize
	|
	|-RVA: 0x154C190 Offset: 0x154AB90 VA: 0x18154C190
	|-Dictionary<int, Vector4>.Resize
	|
	|-RVA: 0x154CA70 Offset: 0x154B470 VA: 0x18154CA70
	|-Dictionary<int, Multipass.TransportIdData>.Resize
	|
	|-RVA: 0x154BD20 Offset: 0x154A720 VA: 0x18154BD20
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Resize
	|
	|-RVA: 0x154B860 Offset: 0x154A260 VA: 0x18154B860
	|-Dictionary<int, NetworkAnimator.StateChange>.Resize
	|
	|-RVA: 0x155D120 Offset: 0x155BB20 VA: 0x18155D120
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Resize
	|
	|-RVA: 0x155D590 Offset: 0x155BF90 VA: 0x18155D590
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Resize
	|
	|-RVA: 0x155CE10 Offset: 0x155B810 VA: 0x18155CE10
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Resize
	|
	|-RVA: 0x155CC60 Offset: 0x155B660 VA: 0x18155CC60
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x155CAB0 Offset: 0x155B4B0 VA: 0x18155CAB0
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x155C750 Offset: 0x155B150 VA: 0x18155C750
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x155C900 Offset: 0x155B300 VA: 0x18155C900
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x15703D0 Offset: 0x156EDD0 VA: 0x1815703D0
	|-Dictionary<long, ComputedStyle>.Resize
	|
	|-RVA: 0x1570890 Offset: 0x156F290 VA: 0x181570890
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x156FDB0 Offset: 0x156E7B0 VA: 0x18156FDB0
	|-Dictionary<IntPtr, object>.Resize
	|
	|-RVA: 0x1570A40 Offset: 0x156F440 VA: 0x181570A40
	|-Dictionary<InternedString, InternedString>.Resize
	|
	|-RVA: 0x1570EB0 Offset: 0x156F8B0 VA: 0x181570EB0
	|-Dictionary<InternedString, object>.Resize
	|
	|-RVA: 0x15706E0 Offset: 0x156F0E0 VA: 0x1815706E0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Resize
	|
	|-RVA: 0x15700C0 Offset: 0x156EAC0 VA: 0x1815700C0
	|-Dictionary<NativeAddr, object>.Resize
	|
	|-RVA: 0x1599EB0 Offset: 0x15988B0 VA: 0x181599EB0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Resize
	|
	|-RVA: 0x1598EA0 Offset: 0x15978A0 VA: 0x181598EA0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Resize
	|
	|-RVA: 0x15997E0 Offset: 0x15981E0 VA: 0x1815997E0
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x1599380 Offset: 0x1597D80 VA: 0x181599380
	|-Dictionary<object, Bounds>.Resize
	|
	|-RVA: 0x1599110 Offset: 0x1597B10 VA: 0x181599110
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x1599F30 Offset: 0x1598930 VA: 0x181599F30
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x1599A50 Offset: 0x1598450 VA: 0x181599A50
	|-Dictionary<object, Color32>.Resize
	|
	|-RVA: 0x15ABAA0 Offset: 0x15AA4A0 VA: 0x1815ABAA0
	|-Dictionary<object, double>.Resize
	|
	|-RVA: 0x15AB830 Offset: 0x15AA230 VA: 0x1815AB830
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x15AB2D0 Offset: 0x15A9CD0 VA: 0x1815AB2D0
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x15AB060 Offset: 0x15A9A60 VA: 0x1815AB060
	|-Dictionary<object, long>.Resize
	|
	|-RVA: 0x15AB730 Offset: 0x15AA130 VA: 0x1815AB730
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x15AAFE0 Offset: 0x15A99E0 VA: 0x1815AAFE0
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x15AB7B0 Offset: 0x15AA1B0 VA: 0x1815AB7B0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Resize
	|
	|-RVA: 0x15BB690 Offset: 0x15BA090 VA: 0x1815BB690
	|-Dictionary<object, RaycastHit>.Resize
	|
	|-RVA: 0x15BB1B0 Offset: 0x15B9BB0 VA: 0x1815BB1B0
	|-Dictionary<object, Rect>.Resize
	|
	|-RVA: 0x15BBA00 Offset: 0x15BA400 VA: 0x1815BBA00
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x15BAD50 Offset: 0x15B9750 VA: 0x1815BAD50
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x15BB790 Offset: 0x15BA190 VA: 0x1815BB790
	|-Dictionary<object, StylePropertyValue>.Resize
	|
	|-RVA: 0x15BB610 Offset: 0x15BA010 VA: 0x1815BB610
	|-Dictionary<object, TextureId>.Resize
	|
	|-RVA: 0x15BB710 Offset: 0x15BA110 VA: 0x1815BB710
	|-Dictionary<object, XPathNodeRef>.Resize
	|
	|-RVA: 0x15CC090 Offset: 0x15CAA90 VA: 0x1815CC090
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Resize
	|
	|-RVA: 0x15CC010 Offset: 0x15CAA10 VA: 0x1815CC010
	|-Dictionary<object, InputControlLayout.ControlItem>.Resize
	|
	|-RVA: 0x15CC570 Offset: 0x15CAF70 VA: 0x1815CC570
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Resize
	|
	|-RVA: 0x15CC4F0 Offset: 0x15CAEF0 VA: 0x1815CC4F0
	|-Dictionary<object, JsonParser.JsonValue>.Resize
	|
	|-RVA: 0x15CB9C0 Offset: 0x15CA3C0 VA: 0x1815CB9C0
	|-Dictionary<object, LiquidVolume.MeshCache>.Resize
	|
	|-RVA: 0x15CCA50 Offset: 0x15CB450 VA: 0x1815CCA50
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Resize
	|
	|-RVA: 0x15CC9D0 Offset: 0x15CB3D0 VA: 0x1815CC9D0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Resize
	|
	|-RVA: 0x15DD960 Offset: 0x15DC360 VA: 0x1815DD960
	|-Dictionary<object, SVGDocument.ClipData>.Resize
	|
	|-RVA: 0x15DD4D0 Offset: 0x15DBED0 VA: 0x1815DD4D0
	|-Dictionary<object, SVGDocument.MaskData>.Resize
	|
	|-RVA: 0x15DD8E0 Offset: 0x15DC2E0 VA: 0x1815DD8E0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Resize
	|
	|-RVA: 0x15DDDC0 Offset: 0x15DC7C0 VA: 0x1815DDDC0
	|-Dictionary<object, SVGDocument.PatternData>.Resize
	|
	|-RVA: 0x15DD260 Offset: 0x15DBC60 VA: 0x1815DD260
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Resize
	|
	|-RVA: 0x15DD860 Offset: 0x15DC260 VA: 0x1815DD860
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Resize
	|
	|-RVA: 0x15DD6B0 Offset: 0x15DC0B0 VA: 0x1815DD6B0
	|-Dictionary<Scene, object>.Resize
	|
	|-RVA: 0x15F00D0 Offset: 0x15EEAD0 VA: 0x1815F00D0
	|-Dictionary<TerrainTileCoord, object>.Resize
	|
	|-RVA: 0x15F0280 Offset: 0x15EEC80 VA: 0x1815F0280
	|-Dictionary<ushort, object>.Resize
	|
	|-RVA: 0x15EF900 Offset: 0x15EE300 VA: 0x1815EF900
	|-Dictionary<ushort, RpcLink>.Resize
	|
	|-RVA: 0x15EF330 Offset: 0x15EDD30 VA: 0x1815EF330
	|-Dictionary<ushort, ushort>.Resize
	|
	|-RVA: 0x15F06F0 Offset: 0x15EF0F0 VA: 0x1815F06F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Resize
	|
	|-RVA: 0x15EFC10 Offset: 0x15EE610 VA: 0x1815EFC10
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x15EFF20 Offset: 0x15EE920 VA: 0x1815EFF20
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Resize
	|
	|-RVA: 0x1602AF0 Offset: 0x16014F0 VA: 0x181602AF0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Resize
	|
	|-RVA: 0x1602940 Offset: 0x1601340 VA: 0x181602940
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Resize
	|
	|-RVA: 0x1603640 Offset: 0x1602040 VA: 0x181603640
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Resize
	|
	|-RVA: 0x16025E0 Offset: 0x1600FE0 VA: 0x1816025E0
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x16037F0 Offset: 0x16021F0 VA: 0x1816037F0
	|-Dictionary<uint, RpcLinkType>.Resize
	|
	|-RVA: 0x1602430 Offset: 0x1600E30 VA: 0x181602430
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Resize
	|
	|-RVA: 0x1602790 Offset: 0x1601190 VA: 0x181602790
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x1617F20 Offset: 0x1616920 VA: 0x181617F20
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Resize
	|
	|-RVA: 0x1618280 Offset: 0x1616C80 VA: 0x181618280
	|-Dictionary<Vector2Int, object>.Resize
	|
	|-RVA: 0x16180D0 Offset: 0x1616AD0 VA: 0x1816180D0
	|-Dictionary<Vector3, Vector3>.Resize
	|
	|-RVA: 0x1617020 Offset: 0x1615A20 VA: 0x181617020
	|-Dictionary<Vector3Int, object>.Resize
	|
	|-RVA: 0x1618430 Offset: 0x1616E30 VA: 0x181618430
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Resize
	|
	|-RVA: 0x1617600 Offset: 0x1616000 VA: 0x181617600
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	|
	|-RVA: 0x1617AB0 Offset: 0x16164B0 VA: 0x181617AB0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Resize
	|
	|-RVA: 0x162A090 Offset: 0x1628A90 VA: 0x18162A090
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Resize
	|
	|-RVA: 0x1629910 Offset: 0x1628310 VA: 0x181629910
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Resize
	|
	|-RVA: 0x1629D80 Offset: 0x1628780 VA: 0x181629D80
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Resize
	|
	|-RVA: 0x162A240 Offset: 0x1628C40 VA: 0x18162A240
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Resize
	*/

	// RVA: -1 Offset: -1
	private void Resize(int newSize, bool forceNewHashCodes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F36A0 Offset: 0x14F20A0 VA: 0x1814F36A0
	|-Dictionary<KeyValuePair<object, object>, object>.Resize
	|
	|-RVA: 0x14F3390 Offset: 0x14F1D90 VA: 0x1814F3390
	|-Dictionary<StructMultiKey<object, object>, object>.Resize
	|
	|-RVA: 0x14F2BC0 Offset: 0x14F15C0 VA: 0x1814F2BC0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Resize
	|
	|-RVA: 0x14F28B0 Offset: 0x14F12B0 VA: 0x1814F28B0
	|-Dictionary<ValueTuple<object, int>, object>.Resize
	|
	|-RVA: 0x14F2D20 Offset: 0x14F1720 VA: 0x1814F2D20
	|-Dictionary<ValueTuple<object, object>, object>.Resize
	|
	|-RVA: 0x1504C40 Offset: 0x1503640 VA: 0x181504C40
	|-Dictionary<Bounds, object>.Resize
	|
	|-RVA: 0x15042F0 Offset: 0x1502CF0 VA: 0x1815042F0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Resize
	|
	|-RVA: 0x1504450 Offset: 0x1502E50 VA: 0x181504450
	|-Dictionary<CSteamID, int>.Resize
	|
	|-RVA: 0x15045C0 Offset: 0x1502FC0 VA: 0x1815045C0
	|-Dictionary<FullRank, object>.Resize
	|
	|-RVA: 0x1505740 Offset: 0x1504140 VA: 0x181505740
	|-Dictionary<Guid, object>.Resize
	|
	|-RVA: 0x1504F50 Offset: 0x1503950 VA: 0x181504F50
	|-Dictionary<HSteamNetConnection, int>.Resize
	|
	|-RVA: 0x1505270 Offset: 0x1503C70 VA: 0x181505270
	|-Dictionary<Hash128, int>.Resize
	|
	|-RVA: 0x15190C0 Offset: 0x1517AC0 VA: 0x1815190C0
	|-Dictionary<Hash128, object>.Resize
	|
	|-RVA: 0x151A0B0 Offset: 0x1518AB0 VA: 0x18151A0B0
	|-Dictionary<Int2, int>.Resize
	|
	|-RVA: 0x1519580 Offset: 0x1517F80 VA: 0x181519580
	|-Dictionary<Int2, object>.Resize
	|
	|-RVA: 0x1518F60 Offset: 0x1517960 VA: 0x181518F60
	|-Dictionary<Int3, int>.Resize
	|
	|-RVA: 0x151A210 Offset: 0x1518C10 VA: 0x18151A210
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Resize
	|
	|-RVA: 0x151A370 Offset: 0x1518D70 VA: 0x18151A370
	|-Dictionary<int, TreeViewItemData<object>>.Resize
	|
	|-RVA: 0x1519BF0 Offset: 0x15185F0 VA: 0x181519BF0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Resize
	|
	|-RVA: 0x152BAE0 Offset: 0x152A4E0 VA: 0x18152BAE0
	|-Dictionary<int, bool>.Resize
	|
	|-RVA: 0x152AB40 Offset: 0x1529540 VA: 0x18152AB40
	|-Dictionary<int, ByteEnum>.Resize
	|
	|-RVA: 0x152AE50 Offset: 0x1529850 VA: 0x18152AE50
	|-Dictionary<int, CSteamID>.Resize
	|
	|-RVA: 0x152B160 Offset: 0x1529B60 VA: 0x18152B160
	|-Dictionary<int, HSteamNetConnection>.Resize
	|
	|-RVA: 0x152BF50 Offset: 0x152A950 VA: 0x18152BF50
	|-Dictionary<int, short>.Resize
	|
	|-RVA: 0x152BDF0 Offset: 0x152A7F0 VA: 0x18152BDF0
	|-Dictionary<int, Int3>.Resize
	|
	|-RVA: 0x152B2C0 Offset: 0x1529CC0 VA: 0x18152B2C0
	|-Dictionary<int, int>.Resize
	|
	|-RVA: 0x153B560 Offset: 0x1539F60 VA: 0x18153B560
	|-Dictionary<int, Int32Enum>.Resize
	|
	|-RVA: 0x153BB80 Offset: 0x153A580 VA: 0x18153BB80
	|-Dictionary<int, long>.Resize
	|
	|-RVA: 0x153C7C0 Offset: 0x153B1C0 VA: 0x18153C7C0
	|-Dictionary<int, object>.Resize
	|
	|-RVA: 0x153BCE0 Offset: 0x153A6E0 VA: 0x18153BCE0
	|-Dictionary<int, RenderInstancedDataLayout>.Resize
	|
	|-RVA: 0x153B870 Offset: 0x153A270 VA: 0x18153B870
	|-Dictionary<int, float>.Resize
	|
	|-RVA: 0x153C500 Offset: 0x153AF00 VA: 0x18153C500
	|-Dictionary<int, TreeItem>.Resize
	|
	|-RVA: 0x153C660 Offset: 0x153B060 VA: 0x18153C660
	|-Dictionary<int, uint>.Resize
	|
	|-RVA: 0x154BED0 Offset: 0x154A8D0 VA: 0x18154BED0
	|-Dictionary<int, ulong>.Resize
	|
	|-RVA: 0x154C7B0 Offset: 0x154B1B0 VA: 0x18154C7B0
	|-Dictionary<int, Vector2Int>.Resize
	|
	|-RVA: 0x154C4F0 Offset: 0x154AEF0 VA: 0x18154C4F0
	|-Dictionary<int, Vector3>.Resize
	|
	|-RVA: 0x154C910 Offset: 0x154B310 VA: 0x18154C910
	|-Dictionary<int, Vector4>.Resize
	|
	|-RVA: 0x154C030 Offset: 0x154AA30 VA: 0x18154C030
	|-Dictionary<int, Multipass.TransportIdData>.Resize
	|
	|-RVA: 0x154BA10 Offset: 0x154A410 VA: 0x18154BA10
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Resize
	|
	|-RVA: 0x154C650 Offset: 0x154B050 VA: 0x18154C650
	|-Dictionary<int, NetworkAnimator.StateChange>.Resize
	|
	|-RVA: 0x155D740 Offset: 0x155C140 VA: 0x18155D740
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Resize
	|
	|-RVA: 0x155D8A0 Offset: 0x155C2A0 VA: 0x18155D8A0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Resize
	|
	|-RVA: 0x155D430 Offset: 0x155BE30 VA: 0x18155D430
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Resize
	|
	|-RVA: 0x155C490 Offset: 0x155AE90 VA: 0x18155C490
	|-Dictionary<Int32Enum, bool>.Resize
	|
	|-RVA: 0x155C5F0 Offset: 0x155AFF0 VA: 0x18155C5F0
	|-Dictionary<Int32Enum, int>.Resize
	|
	|-RVA: 0x155CFC0 Offset: 0x155B9C0 VA: 0x18155CFC0
	|-Dictionary<Int32Enum, Int32Enum>.Resize
	|
	|-RVA: 0x155D2D0 Offset: 0x155BCD0 VA: 0x18155D2D0
	|-Dictionary<Int32Enum, object>.Resize
	|
	|-RVA: 0x1571060 Offset: 0x156FA60 VA: 0x181571060
	|-Dictionary<long, ComputedStyle>.Resize
	|
	|-RVA: 0x156FF60 Offset: 0x156E960 VA: 0x18156FF60
	|-Dictionary<long, object>.Resize
	|
	|-RVA: 0x15711C0 Offset: 0x156FBC0 VA: 0x1815711C0
	|-Dictionary<IntPtr, object>.Resize
	|
	|-RVA: 0x1570D50 Offset: 0x156F750 VA: 0x181570D50
	|-Dictionary<InternedString, InternedString>.Resize
	|
	|-RVA: 0x1570270 Offset: 0x156EC70 VA: 0x181570270
	|-Dictionary<InternedString, object>.Resize
	|
	|-RVA: 0x1570BF0 Offset: 0x156F5F0 VA: 0x181570BF0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Resize
	|
	|-RVA: 0x1570580 Offset: 0x156EF80 VA: 0x181570580
	|-Dictionary<NativeAddr, object>.Resize
	|
	|-RVA: 0x1599400 Offset: 0x1597E00 VA: 0x181599400
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Resize
	|
	|-RVA: 0x1599860 Offset: 0x1598260 VA: 0x181599860
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Resize
	|
	|-RVA: 0x15995F0 Offset: 0x1597FF0 VA: 0x1815995F0
	|-Dictionary<object, bool>.Resize
	|
	|-RVA: 0x1599190 Offset: 0x1597B90 VA: 0x181599190
	|-Dictionary<object, Bounds>.Resize
	|
	|-RVA: 0x1599AD0 Offset: 0x15984D0 VA: 0x181599AD0
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x1599CC0 Offset: 0x15986C0 VA: 0x181599CC0
	|-Dictionary<object, Color>.Resize
	|
	|-RVA: 0x1598F20 Offset: 0x1597920 VA: 0x181598F20
	|-Dictionary<object, Color32>.Resize
	|
	|-RVA: 0x15AB8B0 Offset: 0x15AA2B0 VA: 0x1815AB8B0
	|-Dictionary<object, double>.Resize
	|
	|-RVA: 0x15AAC00 Offset: 0x15A9600 VA: 0x1815AAC00
	|-Dictionary<object, int>.Resize
	|
	|-RVA: 0x15AAA10 Offset: 0x15A9410 VA: 0x1815AAA10
	|-Dictionary<object, Int32Enum>.Resize
	|
	|-RVA: 0x15AB0E0 Offset: 0x15A9AE0 VA: 0x1815AB0E0
	|-Dictionary<object, long>.Resize
	|
	|-RVA: 0x15AB540 Offset: 0x15A9F40 VA: 0x1815AB540
	|-Dictionary<object, object>.Resize
	|
	|-RVA: 0x15AADF0 Offset: 0x15A97F0 VA: 0x1815AADF0
	|-Dictionary<object, Playable>.Resize
	|
	|-RVA: 0x15AB350 Offset: 0x15A9D50 VA: 0x1815AB350
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Resize
	|
	|-RVA: 0x15BB810 Offset: 0x15BA210 VA: 0x1815BB810
	|-Dictionary<object, RaycastHit>.Resize
	|
	|-RVA: 0x15BADD0 Offset: 0x15B97D0 VA: 0x1815BADD0
	|-Dictionary<object, Rect>.Resize
	|
	|-RVA: 0x15BAFC0 Offset: 0x15B99C0 VA: 0x1815BAFC0
	|-Dictionary<object, ResourceLocator>.Resize
	|
	|-RVA: 0x15BB230 Offset: 0x15B9C30 VA: 0x1815BB230
	|-Dictionary<object, float>.Resize
	|
	|-RVA: 0x15BB420 Offset: 0x15B9E20 VA: 0x1815BB420
	|-Dictionary<object, StylePropertyValue>.Resize
	|
	|-RVA: 0x15BBA80 Offset: 0x15BA480 VA: 0x1815BBA80
	|-Dictionary<object, TextureId>.Resize
	|
	|-RVA: 0x15BBC70 Offset: 0x15BA670 VA: 0x1815BBC70
	|-Dictionary<object, XPathNodeRef>.Resize
	|
	|-RVA: 0x15CC5F0 Offset: 0x15CAFF0 VA: 0x1815CC5F0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Resize
	|
	|-RVA: 0x15CC300 Offset: 0x15CAD00 VA: 0x1815CC300
	|-Dictionary<object, InputControlLayout.ControlItem>.Resize
	|
	|-RVA: 0x15CBE20 Offset: 0x15CA820 VA: 0x1815CBE20
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Resize
	|
	|-RVA: 0x15CBA40 Offset: 0x15CA440 VA: 0x1815CBA40
	|-Dictionary<object, JsonParser.JsonValue>.Resize
	|
	|-RVA: 0x15CC110 Offset: 0x15CAB10 VA: 0x1815CC110
	|-Dictionary<object, LiquidVolume.MeshCache>.Resize
	|
	|-RVA: 0x15CBC30 Offset: 0x15CA630 VA: 0x1815CBC30
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Resize
	|
	|-RVA: 0x15CC7E0 Offset: 0x15CB1E0 VA: 0x1815CC7E0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Resize
	|
	|-RVA: 0x15DE220 Offset: 0x15DCC20 VA: 0x1815DE220
	|-Dictionary<object, SVGDocument.ClipData>.Resize
	|
	|-RVA: 0x15DDE40 Offset: 0x15DC840 VA: 0x1815DDE40
	|-Dictionary<object, SVGDocument.MaskData>.Resize
	|
	|-RVA: 0x15DD2E0 Offset: 0x15DBCE0 VA: 0x1815DD2E0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Resize
	|
	|-RVA: 0x15DD9E0 Offset: 0x15DC3E0 VA: 0x1815DD9E0
	|-Dictionary<object, SVGDocument.PatternData>.Resize
	|
	|-RVA: 0x15DE030 Offset: 0x15DCA30 VA: 0x1815DE030
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Resize
	|
	|-RVA: 0x15DDBD0 Offset: 0x15DC5D0 VA: 0x1815DDBD0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Resize
	|
	|-RVA: 0x15DD550 Offset: 0x15DBF50 VA: 0x1815DD550
	|-Dictionary<Scene, object>.Resize
	|
	|-RVA: 0x15F0590 Offset: 0x15EEF90 VA: 0x1815F0590
	|-Dictionary<TerrainTileCoord, object>.Resize
	|
	|-RVA: 0x15EF7A0 Offset: 0x15EE1A0 VA: 0x1815EF7A0
	|-Dictionary<ushort, object>.Resize
	|
	|-RVA: 0x15EF4E0 Offset: 0x15EDEE0 VA: 0x1815EF4E0
	|-Dictionary<ushort, RpcLink>.Resize
	|
	|-RVA: 0x15F0430 Offset: 0x15EEE30 VA: 0x1815F0430
	|-Dictionary<ushort, ushort>.Resize
	|
	|-RVA: 0x15EFDC0 Offset: 0x15EE7C0 VA: 0x1815EFDC0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Resize
	|
	|-RVA: 0x15EFAB0 Offset: 0x15EE4B0 VA: 0x1815EFAB0
	|-Dictionary<uint, int>.Resize
	|
	|-RVA: 0x15EF640 Offset: 0x15EE040 VA: 0x1815EF640
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Resize
	|
	|-RVA: 0x1602CA0 Offset: 0x16016A0 VA: 0x181602CA0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Resize
	|
	|-RVA: 0x1603380 Offset: 0x1601D80 VA: 0x181603380
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Resize
	|
	|-RVA: 0x1602F60 Offset: 0x1601960 VA: 0x181602F60
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Resize
	|
	|-RVA: 0x16034E0 Offset: 0x1601EE0 VA: 0x1816034E0
	|-Dictionary<uint, object>.Resize
	|
	|-RVA: 0x1602E00 Offset: 0x1601800 VA: 0x181602E00
	|-Dictionary<uint, RpcLinkType>.Resize
	|
	|-RVA: 0x1603220 Offset: 0x1601C20 VA: 0x181603220
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Resize
	|
	|-RVA: 0x16030C0 Offset: 0x1601AC0 VA: 0x1816030C0
	|-Dictionary<ulong, object>.Resize
	|
	|-RVA: 0x1617950 Offset: 0x1616350 VA: 0x181617950
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Resize
	|
	|-RVA: 0x1617DC0 Offset: 0x16167C0 VA: 0x181617DC0
	|-Dictionary<Vector2Int, object>.Resize
	|
	|-RVA: 0x1617690 Offset: 0x1616090 VA: 0x181617690
	|-Dictionary<Vector3, Vector3>.Resize
	|
	|-RVA: 0x1616EC0 Offset: 0x16158C0 VA: 0x181616EC0
	|-Dictionary<Vector3Int, object>.Resize
	|
	|-RVA: 0x16177F0 Offset: 0x16161F0 VA: 0x1816177F0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Resize
	|
	|-RVA: 0x16171D0 Offset: 0x1615BD0 VA: 0x1816171D0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	|
	|-RVA: 0x1617C60 Offset: 0x1616660 VA: 0x181617C60
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Resize
	|
	|-RVA: 0x1629F30 Offset: 0x1628930 VA: 0x181629F30
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Resize
	|
	|-RVA: 0x16297B0 Offset: 0x16281B0 VA: 0x1816297B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Resize
	|
	|-RVA: 0x1629C20 Offset: 0x1628620 VA: 0x181629C20
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Resize
	|
	|-RVA: 0x1629AC0 Offset: 0x16284C0 VA: 0x181629AC0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F1B70 Offset: 0x14F0570 VA: 0x1814F1B70
	|-Dictionary<KeyValuePair<object, object>, object>.Remove
	|
	|-RVA: 0x14F2560 Offset: 0x14F0F60 VA: 0x1814F2560
	|-Dictionary<StructMultiKey<object, object>, object>.Remove
	|
	|-RVA: 0x14F1820 Offset: 0x14F0220 VA: 0x1814F1820
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.Remove
	|
	|-RVA: 0x14F1EC0 Offset: 0x14F08C0 VA: 0x1814F1EC0
	|-Dictionary<ValueTuple<object, int>, object>.Remove
	|
	|-RVA: 0x14F2210 Offset: 0x14F0C10 VA: 0x1814F2210
	|-Dictionary<ValueTuple<object, object>, object>.Remove
	|
	|-RVA: 0x15031B0 Offset: 0x1501BB0 VA: 0x1815031B0
	|-Dictionary<Bounds, object>.Remove
	|
	|-RVA: 0x1503750 Offset: 0x1502150 VA: 0x181503750
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.Remove
	|
	|-RVA: 0x1503A40 Offset: 0x1502440 VA: 0x181503A40
	|-Dictionary<CSteamID, int>.Remove
	|
	|-RVA: 0x1503520 Offset: 0x1501F20 VA: 0x181503520
	|-Dictionary<FullRank, object>.Remove
	|
	|-RVA: 0x1503FB0 Offset: 0x15029B0 VA: 0x181503FB0
	|-Dictionary<Guid, object>.Remove
	|
	|-RVA: 0x1503D00 Offset: 0x1502700 VA: 0x181503D00
	|-Dictionary<HSteamNetConnection, int>.Remove
	|
	|-RVA: 0x1502E70 Offset: 0x1501870 VA: 0x181502E70
	|-Dictionary<Hash128, int>.Remove
	|
	|-RVA: 0x1518570 Offset: 0x1516F70 VA: 0x181518570
	|-Dictionary<Hash128, object>.Remove
	|
	|-RVA: 0x1518340 Offset: 0x1516D40 VA: 0x181518340
	|-Dictionary<Int2, int>.Remove
	|
	|-RVA: 0x15188B0 Offset: 0x15172B0 VA: 0x1815188B0
	|-Dictionary<Int2, object>.Remove
	|
	|-RVA: 0x1517FA0 Offset: 0x15169A0 VA: 0x181517FA0
	|-Dictionary<Int3, int>.Remove
	|
	|-RVA: 0x1518AE0 Offset: 0x15174E0 VA: 0x181518AE0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.Remove
	|-Dictionary<int, CSteamID>.Remove
	|-Dictionary<int, Vector2Int>.Remove
	|-Dictionary<int, Multipass.TransportIdData>.Remove
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.Remove
	|
	|-RVA: 0x1517D50 Offset: 0x1516750 VA: 0x181517D50
	|-Dictionary<int, TreeViewItemData<object>>.Remove
	|
	|-RVA: 0x1518D20 Offset: 0x1517720 VA: 0x181518D20
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.Remove
	|
	|-RVA: 0x152A6C0 Offset: 0x15290C0 VA: 0x18152A6C0
	|-Dictionary<int, bool>.Remove
	|-Dictionary<int, ByteEnum>.Remove
	|-Dictionary<int, HSteamNetConnection>.Remove
	|-Dictionary<int, short>.Remove
	|-Dictionary<int, int>.Remove
	|-Dictionary<int, Int32Enum>.Remove
	|-Dictionary<int, float>.Remove
	|-Dictionary<int, uint>.Remove
	|
	|-RVA: 0x152A900 Offset: 0x1529300 VA: 0x18152A900
	|-Dictionary<int, Int3>.Remove
	|-Dictionary<int, long>.Remove
	|-Dictionary<int, ulong>.Remove
	|-Dictionary<int, Vector3>.Remove
	|
	|-RVA: 0x153AEA0 Offset: 0x15398A0 VA: 0x18153AEA0
	|-Dictionary<int, object>.Remove
	|
	|-RVA: 0x153B320 Offset: 0x1539D20 VA: 0x18153B320
	|-Dictionary<int, RenderInstancedDataLayout>.Remove
	|-Dictionary<int, Vector4>.Remove
	|
	|-RVA: 0x153B0E0 Offset: 0x1539AE0 VA: 0x18153B0E0
	|-Dictionary<int, TreeItem>.Remove
	|
	|-RVA: 0x154B620 Offset: 0x154A020 VA: 0x18154B620
	|-Dictionary<int, NetworkAnimator.StateChange>.Remove
	|
	|-RVA: 0x155C210 Offset: 0x155AC10 VA: 0x18155C210
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.Remove
	|
	|-RVA: 0x155BD80 Offset: 0x155A780 VA: 0x18155BD80
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.Remove
	|-Dictionary<int, TextResourceManager.FontAssetRef>.Remove
	|
	|-RVA: 0x155BB50 Offset: 0x155A550 VA: 0x18155BB50
	|-Dictionary<Int32Enum, bool>.Remove
	|-Dictionary<Int32Enum, int>.Remove
	|-Dictionary<Int32Enum, Int32Enum>.Remove
	|
	|-RVA: 0x155BFE0 Offset: 0x155A9E0 VA: 0x18155BFE0
	|-Dictionary<Int32Enum, object>.Remove
	|
	|-RVA: 0x156F5A0 Offset: 0x156DFA0 VA: 0x18156F5A0
	|-Dictionary<long, ComputedStyle>.Remove
	|
	|-RVA: 0x156F800 Offset: 0x156E200 VA: 0x18156F800
	|-Dictionary<long, object>.Remove
	|
	|-RVA: 0x156F010 Offset: 0x156DA10 VA: 0x18156F010
	|-Dictionary<IntPtr, object>.Remove
	|
	|-RVA: 0x156ECC0 Offset: 0x156D6C0 VA: 0x18156ECC0
	|-Dictionary<InternedString, InternedString>.Remove
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.Remove
	|
	|-RVA: 0x156F250 Offset: 0x156DC50 VA: 0x18156F250
	|-Dictionary<InternedString, object>.Remove
	|
	|-RVA: 0x156FA40 Offset: 0x156E440 VA: 0x18156FA40
	|-Dictionary<NativeAddr, object>.Remove
	|
	|-RVA: 0x15989E0 Offset: 0x15973E0 VA: 0x1815989E0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.Remove
	|-Dictionary<object, ResourceLocator>.Remove
	|-Dictionary<object, StylePropertyValue>.Remove
	|-Dictionary<object, XPathNodeRef>.Remove
	|
	|-RVA: 0x1598770 Offset: 0x1597170 VA: 0x181598770
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.Remove
	|-Dictionary<object, SVGDocument.PatternData>.Remove
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.Remove
	|
	|-RVA: 0x1598040 Offset: 0x1596A40 VA: 0x181598040
	|-Dictionary<object, bool>.Remove
	|-Dictionary<object, Color32>.Remove
	|-Dictionary<object, double>.Remove
	|-Dictionary<object, int>.Remove
	|-Dictionary<object, Int32Enum>.Remove
	|-Dictionary<object, long>.Remove
	|-Dictionary<object, float>.Remove
	|-Dictionary<object, TextureId>.Remove
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.Remove
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.Remove
	|-Dictionary<object, ObjectPool.DelayedStoreData>.Remove
	|-Dictionary<object, SVGDocument.ClipData>.Remove
	|-Dictionary<object, SVGDocument.MaskData>.Remove
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.Remove
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.Remove
	|
	|-RVA: 0x15982A0 Offset: 0x1596CA0 VA: 0x1815982A0
	|-Dictionary<object, Bounds>.Remove
	|
	|-RVA: 0x1598500 Offset: 0x1596F00 VA: 0x181598500
	|-Dictionary<object, Color>.Remove
	|-Dictionary<object, LiquidVolume.MeshCache>.Remove
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.Remove
	|
	|-RVA: 0x1598C40 Offset: 0x1597640 VA: 0x181598C40
	|-Dictionary<object, Color>.Remove
	|-Dictionary<object, Playable>.Remove
	|-Dictionary<object, Rect>.Remove
	|
	|-RVA: 0x15AA550 Offset: 0x15A8F50 VA: 0x1815AA550
	|-Dictionary<object, object>.Remove
	|
	|-RVA: 0x15AA7B0 Offset: 0x15A91B0 VA: 0x1815AA7B0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.Remove
	|-Dictionary<object, RaycastHit>.Remove
	|
	|-RVA: 0x15CB4D0 Offset: 0x15C9ED0 VA: 0x1815CB4D0
	|-Dictionary<object, InputControlLayout.ControlItem>.Remove
	|
	|-RVA: 0x15CB750 Offset: 0x15CA150 VA: 0x1815CB750
	|-Dictionary<object, JsonParser.JsonValue>.Remove
	|
	|-RVA: 0x15DD040 Offset: 0x15DBA40 VA: 0x1815DD040
	|-Dictionary<Scene, object>.Remove
	|
	|-RVA: 0x15EE7F0 Offset: 0x15ED1F0 VA: 0x1815EE7F0
	|-Dictionary<TerrainTileCoord, object>.Remove
	|
	|-RVA: 0x15EE5B0 Offset: 0x15ECFB0 VA: 0x1815EE5B0
	|-Dictionary<ushort, object>.Remove
	|
	|-RVA: 0x15EEA30 Offset: 0x15ED430 VA: 0x1815EEA30
	|-Dictionary<ushort, RpcLink>.Remove
	|
	|-RVA: 0x15EEEB0 Offset: 0x15ED8B0 VA: 0x1815EEEB0
	|-Dictionary<ushort, ushort>.Remove
	|
	|-RVA: 0x15EE370 Offset: 0x15ECD70 VA: 0x1815EE370
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.Remove
	|
	|-RVA: 0x15EF0F0 Offset: 0x15EDAF0 VA: 0x1815EF0F0
	|-Dictionary<uint, int>.Remove
	|
	|-RVA: 0x15EEC70 Offset: 0x15ED670 VA: 0x1815EEC70
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Remove
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.Remove
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Remove
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.Remove
	|
	|-RVA: 0x1601FB0 Offset: 0x16009B0 VA: 0x181601FB0
	|-Dictionary<uint, object>.Remove
	|
	|-RVA: 0x1601B30 Offset: 0x1600530 VA: 0x181601B30
	|-Dictionary<uint, RpcLinkType>.Remove
	|
	|-RVA: 0x16021F0 Offset: 0x1600BF0 VA: 0x1816021F0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.Remove
	|
	|-RVA: 0x1601D70 Offset: 0x1600770 VA: 0x181601D70
	|-Dictionary<ulong, object>.Remove
	|
	|-RVA: 0x16155B0 Offset: 0x1613FB0 VA: 0x1816155B0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.Remove
	|
	|-RVA: 0x1616C80 Offset: 0x1615680 VA: 0x181616C80
	|-Dictionary<Vector2Int, object>.Remove
	|
	|-RVA: 0x1615800 Offset: 0x1614200 VA: 0x181615800
	|-Dictionary<Vector3, Vector3>.Remove
	|
	|-RVA: 0x1616920 Offset: 0x1615320 VA: 0x181616920
	|-Dictionary<Vector3Int, object>.Remove
	|
	|-RVA: 0x16165D0 Offset: 0x1614FD0 VA: 0x1816165D0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.Remove
	|
	|-RVA: 0x1615F70 Offset: 0x1614970 VA: 0x181615F70
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x1615BC0 Offset: 0x16145C0 VA: 0x181615BC0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.Remove
	|
	|-RVA: 0x1628ED0 Offset: 0x16278D0 VA: 0x181628ED0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.Remove
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.Remove
	|
	|-RVA: 0x1629220 Offset: 0x1627C20 VA: 0x181629220
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.Remove
	|
	|-RVA: 0x1629570 Offset: 0x1627F70 VA: 0x181629570
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F89F0 Offset: 0x14F73F0 VA: 0x1814F89F0
	|-Dictionary<KeyValuePair<object, object>, object>.TryGetValue
	|
	|-RVA: 0x14F8840 Offset: 0x14F7240 VA: 0x1814F8840
	|-Dictionary<StructMultiKey<object, object>, object>.TryGetValue
	|
	|-RVA: 0x14F8780 Offset: 0x14F7180 VA: 0x1814F8780
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.TryGetValue
	|
	|-RVA: 0x14F8960 Offset: 0x14F7360 VA: 0x1814F8960
	|-Dictionary<ValueTuple<object, int>, object>.TryGetValue
	|
	|-RVA: 0x14F88D0 Offset: 0x14F72D0 VA: 0x1814F88D0
	|-Dictionary<ValueTuple<object, object>, object>.TryGetValue
	|
	|-RVA: 0x150C810 Offset: 0x150B210 VA: 0x18150C810
	|-Dictionary<Bounds, object>.TryGetValue
	|
	|-RVA: 0x150C5F0 Offset: 0x150AFF0 VA: 0x18150C5F0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.TryGetValue
	|
	|-RVA: 0x150C580 Offset: 0x150AF80 VA: 0x18150C580
	|-Dictionary<CSteamID, int>.TryGetValue
	|
	|-RVA: 0x150C6A0 Offset: 0x150B0A0 VA: 0x18150C6A0
	|-Dictionary<FullRank, object>.TryGetValue
	|
	|-RVA: 0x150C8A0 Offset: 0x150B2A0 VA: 0x18150C8A0
	|-Dictionary<Guid, object>.TryGetValue
	|
	|-RVA: 0x150C720 Offset: 0x150B120 VA: 0x18150C720
	|-Dictionary<HSteamNetConnection, int>.TryGetValue
	|
	|-RVA: 0x150C790 Offset: 0x150B190 VA: 0x18150C790
	|-Dictionary<Hash128, int>.TryGetValue
	|
	|-RVA: 0x1520A50 Offset: 0x151F450 VA: 0x181520A50
	|-Dictionary<Hash128, object>.TryGetValue
	|
	|-RVA: 0x1520AE0 Offset: 0x151F4E0 VA: 0x181520AE0
	|-Dictionary<Int2, int>.TryGetValue
	|
	|-RVA: 0x1520CE0 Offset: 0x151F6E0 VA: 0x181520CE0
	|-Dictionary<Int2, object>.TryGetValue
	|
	|-RVA: 0x1520B50 Offset: 0x151F550 VA: 0x181520B50
	|-Dictionary<Int3, int>.TryGetValue
	|
	|-RVA: 0x1520BE0 Offset: 0x151F5E0 VA: 0x181520BE0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.TryGetValue
	|-Dictionary<int, CSteamID>.TryGetValue
	|-Dictionary<int, Vector2Int>.TryGetValue
	|-Dictionary<int, Multipass.TransportIdData>.TryGetValue
	|
	|-RVA: 0x1520C50 Offset: 0x151F650 VA: 0x181520C50
	|-Dictionary<int, TreeViewItemData<object>>.TryGetValue
	|
	|-RVA: 0x15209C0 Offset: 0x151F3C0 VA: 0x1815209C0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.TryGetValue
	|
	|-RVA: 0x1531690 Offset: 0x1530090 VA: 0x181531690
	|-Dictionary<int, bool>.TryGetValue
	|-Dictionary<int, ByteEnum>.TryGetValue
	|
	|-RVA: 0x1531620 Offset: 0x1530020 VA: 0x181531620
	|-Dictionary<int, HSteamNetConnection>.TryGetValue
	|-Dictionary<int, int>.TryGetValue
	|-Dictionary<int, Int32Enum>.TryGetValue
	|-Dictionary<int, float>.TryGetValue
	|-Dictionary<int, uint>.TryGetValue
	|
	|-RVA: 0x15315B0 Offset: 0x152FFB0 VA: 0x1815315B0
	|-Dictionary<int, short>.TryGetValue
	|
	|-RVA: 0x1531700 Offset: 0x1530100 VA: 0x181531700
	|-Dictionary<int, Int3>.TryGetValue
	|-Dictionary<int, Vector3>.TryGetValue
	|
	|-RVA: 0x15423D0 Offset: 0x1540DD0 VA: 0x1815423D0
	|-Dictionary<int, long>.TryGetValue
	|-Dictionary<int, ulong>.TryGetValue
	|
	|-RVA: 0x1542350 Offset: 0x1540D50 VA: 0x181542350
	|-Dictionary<int, object>.TryGetValue
	|
	|-RVA: 0x15422D0 Offset: 0x1540CD0 VA: 0x1815422D0
	|-Dictionary<int, RenderInstancedDataLayout>.TryGetValue
	|-Dictionary<int, Vector4>.TryGetValue
	|
	|-RVA: 0x1542450 Offset: 0x1540E50 VA: 0x181542450
	|-Dictionary<int, TreeItem>.TryGetValue
	|
	|-RVA: 0x1551E90 Offset: 0x1550890 VA: 0x181551E90
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.TryGetValue
	|
	|-RVA: 0x1551F10 Offset: 0x1550910 VA: 0x181551F10
	|-Dictionary<int, NetworkAnimator.StateChange>.TryGetValue
	|
	|-RVA: 0x1563D90 Offset: 0x1562790 VA: 0x181563D90
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.TryGetValue
	|
	|-RVA: 0x1563F10 Offset: 0x1562910 VA: 0x181563F10
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.TryGetValue
	|-Dictionary<int, TextResourceManager.FontAssetRef>.TryGetValue
	|
	|-RVA: 0x1563FA0 Offset: 0x15629A0 VA: 0x181563FA0
	|-Dictionary<Int32Enum, bool>.TryGetValue
	|
	|-RVA: 0x1563EA0 Offset: 0x15628A0 VA: 0x181563EA0
	|-Dictionary<Int32Enum, int>.TryGetValue
	|-Dictionary<Int32Enum, Int32Enum>.TryGetValue
	|
	|-RVA: 0x1564010 Offset: 0x1562A10 VA: 0x181564010
	|-Dictionary<Int32Enum, object>.TryGetValue
	|
	|-RVA: 0x1577A50 Offset: 0x1576450 VA: 0x181577A50
	|-Dictionary<long, ComputedStyle>.TryGetValue
	|
	|-RVA: 0x1577B20 Offset: 0x1576520 VA: 0x181577B20
	|-Dictionary<long, object>.TryGetValue
	|
	|-RVA: 0x1577CD0 Offset: 0x15766D0 VA: 0x181577CD0
	|-Dictionary<IntPtr, object>.TryGetValue
	|
	|-RVA: 0x1577BA0 Offset: 0x15765A0 VA: 0x181577BA0
	|-Dictionary<InternedString, InternedString>.TryGetValue
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.TryGetValue
	|
	|-RVA: 0x15779C0 Offset: 0x15763C0 VA: 0x1815779C0
	|-Dictionary<InternedString, object>.TryGetValue
	|
	|-RVA: 0x1577C30 Offset: 0x1576630 VA: 0x181577C30
	|-Dictionary<NativeAddr, object>.TryGetValue
	|
	|-RVA: 0x15A02A0 Offset: 0x159ECA0 VA: 0x1815A02A0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.TryGetValue
	|
	|-RVA: 0x159FF70 Offset: 0x159E970 VA: 0x18159FF70
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.TryGetValue
	|-Dictionary<object, SVGDocument.PatternData>.TryGetValue
	|
	|-RVA: 0x15A01B0 Offset: 0x159EBB0 VA: 0x1815A01B0
	|-Dictionary<object, bool>.TryGetValue
	|-Dictionary<object, SVGDocument.ClipData>.TryGetValue
	|
	|-RVA: 0x15A0090 Offset: 0x159EA90 VA: 0x1815A0090
	|-Dictionary<object, Bounds>.TryGetValue
	|
	|-RVA: 0x15A0120 Offset: 0x159EB20 VA: 0x1815A0120
	|-Dictionary<object, Color>.TryGetValue
	|-Dictionary<object, LiquidVolume.MeshCache>.TryGetValue
	|
	|-RVA: 0x15A0010 Offset: 0x159EA10 VA: 0x1815A0010
	|-Dictionary<object, Color>.TryGetValue
	|-Dictionary<object, Playable>.TryGetValue
	|-Dictionary<object, Rect>.TryGetValue
	|
	|-RVA: 0x15A0230 Offset: 0x159EC30 VA: 0x1815A0230
	|-Dictionary<object, Color32>.TryGetValue
	|-Dictionary<object, int>.TryGetValue
	|-Dictionary<object, Int32Enum>.TryGetValue
	|-Dictionary<object, float>.TryGetValue
	|-Dictionary<object, TextureId>.TryGetValue
	|
	|-RVA: 0x15B1010 Offset: 0x15AFA10 VA: 0x1815B1010
	|-Dictionary<object, double>.TryGetValue
	|-Dictionary<object, long>.TryGetValue
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.TryGetValue
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.TryGetValue
	|-Dictionary<object, ObjectPool.DelayedStoreData>.TryGetValue
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.TryGetValue
	|
	|-RVA: 0x15B1090 Offset: 0x15AFA90 VA: 0x1815B1090
	|-Dictionary<object, object>.TryGetValue
	|
	|-RVA: 0x15B1110 Offset: 0x15AFB10 VA: 0x1815B1110
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.TryGetValue
	|
	|-RVA: 0x15C0F70 Offset: 0x15BF970 VA: 0x1815C0F70
	|-Dictionary<object, RaycastHit>.TryGetValue
	|
	|-RVA: 0x15C0EF0 Offset: 0x15BF8F0 VA: 0x1815C0EF0
	|-Dictionary<object, ResourceLocator>.TryGetValue
	|-Dictionary<object, StylePropertyValue>.TryGetValue
	|-Dictionary<object, XPathNodeRef>.TryGetValue
	|
	|-RVA: 0x15D2980 Offset: 0x15D1380 VA: 0x1815D2980
	|-Dictionary<object, InputControlLayout.ControlItem>.TryGetValue
	|
	|-RVA: 0x15D2B30 Offset: 0x15D1530 VA: 0x1815D2B30
	|-Dictionary<object, JsonParser.JsonValue>.TryGetValue
	|
	|-RVA: 0x15D2BF0 Offset: 0x15D15F0 VA: 0x1815D2BF0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.TryGetValue
	|
	|-RVA: 0x15E36B0 Offset: 0x15E20B0 VA: 0x1815E36B0
	|-Dictionary<object, SVGDocument.MaskData>.TryGetValue
	|
	|-RVA: 0x15E37C0 Offset: 0x15E21C0 VA: 0x1815E37C0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.TryGetValue
	|
	|-RVA: 0x15E3730 Offset: 0x15E2130 VA: 0x1815E3730
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.TryGetValue
	|
	|-RVA: 0x15E3840 Offset: 0x15E2240 VA: 0x1815E3840
	|-Dictionary<Scene, object>.TryGetValue
	|
	|-RVA: 0x15F7300 Offset: 0x15F5D00 VA: 0x1815F7300
	|-Dictionary<TerrainTileCoord, object>.TryGetValue
	|
	|-RVA: 0x15F7280 Offset: 0x15F5C80 VA: 0x1815F7280
	|-Dictionary<ushort, object>.TryGetValue
	|
	|-RVA: 0x15F7120 Offset: 0x15F5B20 VA: 0x1815F7120
	|-Dictionary<ushort, RpcLink>.TryGetValue
	|
	|-RVA: 0x15F7210 Offset: 0x15F5C10 VA: 0x1815F7210
	|-Dictionary<ushort, ushort>.TryGetValue
	|
	|-RVA: 0x15F6FF0 Offset: 0x15F59F0 VA: 0x1815F6FF0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.TryGetValue
	|
	|-RVA: 0x15F71A0 Offset: 0x15F5BA0 VA: 0x1815F71A0
	|-Dictionary<uint, int>.TryGetValue
	|
	|-RVA: 0x15F7090 Offset: 0x15F5A90 VA: 0x1815F7090
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryGetValue
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryGetValue
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryGetValue
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryGetValue
	|
	|-RVA: 0x16095B0 Offset: 0x1607FB0 VA: 0x1816095B0
	|-Dictionary<uint, object>.TryGetValue
	|
	|-RVA: 0x16094C0 Offset: 0x1607EC0 VA: 0x1816094C0
	|-Dictionary<uint, RpcLinkType>.TryGetValue
	|
	|-RVA: 0x1609440 Offset: 0x1607E40 VA: 0x181609440
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.TryGetValue
	|
	|-RVA: 0x1609530 Offset: 0x1607F30 VA: 0x181609530
	|-Dictionary<ulong, object>.TryGetValue
	|
	|-RVA: 0x1620060 Offset: 0x161EA60 VA: 0x181620060
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.TryGetValue
	|
	|-RVA: 0x161FFE0 Offset: 0x161E9E0 VA: 0x18161FFE0
	|-Dictionary<Vector2Int, object>.TryGetValue
	|
	|-RVA: 0x161FD60 Offset: 0x161E760 VA: 0x18161FD60
	|-Dictionary<Vector3, Vector3>.TryGetValue
	|
	|-RVA: 0x161FBB0 Offset: 0x161E5B0 VA: 0x18161FBB0
	|-Dictionary<Vector3Int, object>.TryGetValue
	|
	|-RVA: 0x161FC40 Offset: 0x161E640 VA: 0x18161FC40
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryGetValue
	|
	|-RVA: 0x161FE00 Offset: 0x161E800 VA: 0x18161FE00
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	|
	|-RVA: 0x161FCD0 Offset: 0x161E6D0 VA: 0x18161FCD0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.TryGetValue
	|
	|-RVA: 0x162D840 Offset: 0x162C240 VA: 0x18162D840
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.TryGetValue
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.TryGetValue
	|
	|-RVA: 0x162D940 Offset: 0x162C340 VA: 0x18162D940
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.TryGetValue
	|
	|-RVA: 0x162D8C0 Offset: 0x162C2C0 VA: 0x18162D8C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F8650 Offset: 0x14F7050 VA: 0x1814F8650
	|-Dictionary<KeyValuePair<object, object>, object>.TryAdd
	|
	|-RVA: 0x14F8690 Offset: 0x14F7090 VA: 0x1814F8690
	|-Dictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0x14F86D0 Offset: 0x14F70D0 VA: 0x1814F86D0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.TryAdd
	|
	|-RVA: 0x14F8610 Offset: 0x14F7010 VA: 0x1814F8610
	|-Dictionary<ValueTuple<object, int>, object>.TryAdd
	|
	|-RVA: 0x14F8740 Offset: 0x14F7140 VA: 0x1814F8740
	|-Dictionary<ValueTuple<object, object>, object>.TryAdd
	|
	|-RVA: 0x150C3F0 Offset: 0x150ADF0 VA: 0x18150C3F0
	|-Dictionary<Bounds, object>.TryAdd
	|
	|-RVA: 0x150C430 Offset: 0x150AE30 VA: 0x18150C430
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.TryAdd
	|
	|-RVA: 0x150C4A0 Offset: 0x150AEA0 VA: 0x18150C4A0
	|-Dictionary<CSteamID, int>.TryAdd
	|
	|-RVA: 0x150C550 Offset: 0x150AF50 VA: 0x18150C550
	|-Dictionary<FullRank, object>.TryAdd
	|
	|-RVA: 0x150C510 Offset: 0x150AF10 VA: 0x18150C510
	|-Dictionary<Guid, object>.TryAdd
	|
	|-RVA: 0x150C3C0 Offset: 0x150ADC0 VA: 0x18150C3C0
	|-Dictionary<HSteamNetConnection, int>.TryAdd
	|
	|-RVA: 0x150C4D0 Offset: 0x150AED0 VA: 0x18150C4D0
	|-Dictionary<Hash128, int>.TryAdd
	|
	|-RVA: 0x1520950 Offset: 0x151F350 VA: 0x181520950
	|-Dictionary<Hash128, object>.TryAdd
	|
	|-RVA: 0x15208B0 Offset: 0x151F2B0 VA: 0x1815208B0
	|-Dictionary<Int2, int>.TryAdd
	|
	|-RVA: 0x15208E0 Offset: 0x151F2E0 VA: 0x1815208E0
	|-Dictionary<Int2, object>.TryAdd
	|
	|-RVA: 0x1520910 Offset: 0x151F310 VA: 0x181520910
	|-Dictionary<Int3, int>.TryAdd
	|
	|-RVA: 0x1520990 Offset: 0x151F390 VA: 0x181520990
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.TryAdd
	|
	|-RVA: 0x1520860 Offset: 0x151F260 VA: 0x181520860
	|-Dictionary<int, TreeViewItemData<object>>.TryAdd
	|
	|-RVA: 0x1520810 Offset: 0x151F210 VA: 0x181520810
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.TryAdd
	|
	|-RVA: 0x15314F0 Offset: 0x152FEF0 VA: 0x1815314F0
	|-Dictionary<int, bool>.TryAdd
	|
	|-RVA: 0x15314C0 Offset: 0x152FEC0 VA: 0x1815314C0
	|-Dictionary<int, ByteEnum>.TryAdd
	|
	|-RVA: 0x1531450 Offset: 0x152FE50 VA: 0x181531450
	|-Dictionary<int, CSteamID>.TryAdd
	|
	|-RVA: 0x1531520 Offset: 0x152FF20 VA: 0x181531520
	|-Dictionary<int, HSteamNetConnection>.TryAdd
	|
	|-RVA: 0x1531580 Offset: 0x152FF80 VA: 0x181531580
	|-Dictionary<int, short>.TryAdd
	|
	|-RVA: 0x1531480 Offset: 0x152FE80 VA: 0x181531480
	|-Dictionary<int, Int3>.TryAdd
	|
	|-RVA: 0x1531550 Offset: 0x152FF50 VA: 0x181531550
	|-Dictionary<int, int>.TryAdd
	|
	|-RVA: 0x15421D0 Offset: 0x1540BD0 VA: 0x1815421D0
	|-Dictionary<int, Int32Enum>.TryAdd
	|
	|-RVA: 0x1542200 Offset: 0x1540C00 VA: 0x181542200
	|-Dictionary<int, long>.TryAdd
	|
	|-RVA: 0x1542230 Offset: 0x1540C30 VA: 0x181542230
	|-Dictionary<int, object>.TryAdd
	|
	|-RVA: 0x1542160 Offset: 0x1540B60 VA: 0x181542160
	|-Dictionary<int, RenderInstancedDataLayout>.TryAdd
	|
	|-RVA: 0x15421A0 Offset: 0x1540BA0 VA: 0x1815421A0
	|-Dictionary<int, float>.TryAdd
	|
	|-RVA: 0x1542260 Offset: 0x1540C60 VA: 0x181542260
	|-Dictionary<int, TreeItem>.TryAdd
	|
	|-RVA: 0x15422A0 Offset: 0x1540CA0 VA: 0x1815422A0
	|-Dictionary<int, uint>.TryAdd
	|
	|-RVA: 0x1551E30 Offset: 0x1550830 VA: 0x181551E30
	|-Dictionary<int, ulong>.TryAdd
	|
	|-RVA: 0x1551E60 Offset: 0x1550860 VA: 0x181551E60
	|-Dictionary<int, Vector2Int>.TryAdd
	|
	|-RVA: 0x1551CF0 Offset: 0x15506F0 VA: 0x181551CF0
	|-Dictionary<int, Vector3>.TryAdd
	|
	|-RVA: 0x1551DB0 Offset: 0x15507B0 VA: 0x181551DB0
	|-Dictionary<int, Vector4>.TryAdd
	|
	|-RVA: 0x1551D30 Offset: 0x1550730 VA: 0x181551D30
	|-Dictionary<int, Multipass.TransportIdData>.TryAdd
	|
	|-RVA: 0x1551DF0 Offset: 0x15507F0 VA: 0x181551DF0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.TryAdd
	|
	|-RVA: 0x1551D60 Offset: 0x1550760 VA: 0x181551D60
	|-Dictionary<int, NetworkAnimator.StateChange>.TryAdd
	|
	|-RVA: 0x1563CA0 Offset: 0x15626A0 VA: 0x181563CA0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.TryAdd
	|
	|-RVA: 0x1563C60 Offset: 0x1562660 VA: 0x181563C60
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.TryAdd
	|
	|-RVA: 0x1563BC0 Offset: 0x15625C0 VA: 0x181563BC0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.TryAdd
	|
	|-RVA: 0x1563D60 Offset: 0x1562760 VA: 0x181563D60
	|-Dictionary<Int32Enum, bool>.TryAdd
	|
	|-RVA: 0x1563C30 Offset: 0x1562630 VA: 0x181563C30
	|-Dictionary<Int32Enum, int>.TryAdd
	|
	|-RVA: 0x1563D30 Offset: 0x1562730 VA: 0x181563D30
	|-Dictionary<Int32Enum, Int32Enum>.TryAdd
	|
	|-RVA: 0x1563C00 Offset: 0x1562600 VA: 0x181563C00
	|-Dictionary<Int32Enum, object>.TryAdd
	|
	|-RVA: 0x1577890 Offset: 0x1576290 VA: 0x181577890
	|-Dictionary<long, ComputedStyle>.TryAdd
	|
	|-RVA: 0x1577990 Offset: 0x1576390 VA: 0x181577990
	|-Dictionary<long, object>.TryAdd
	|
	|-RVA: 0x1577810 Offset: 0x1576210 VA: 0x181577810
	|-Dictionary<IntPtr, object>.TryAdd
	|
	|-RVA: 0x1577840 Offset: 0x1576240 VA: 0x181577840
	|-Dictionary<InternedString, InternedString>.TryAdd
	|
	|-RVA: 0x1577950 Offset: 0x1576350 VA: 0x181577950
	|-Dictionary<InternedString, object>.TryAdd
	|
	|-RVA: 0x15777C0 Offset: 0x15761C0 VA: 0x1815777C0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.TryAdd
	|
	|-RVA: 0x1577910 Offset: 0x1576310 VA: 0x181577910
	|-Dictionary<NativeAddr, object>.TryAdd
	|
	|-RVA: 0x159FE90 Offset: 0x159E890 VA: 0x18159FE90
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.TryAdd
	|
	|-RVA: 0x159FED0 Offset: 0x159E8D0 VA: 0x18159FED0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.TryAdd
	|
	|-RVA: 0x159FE60 Offset: 0x159E860 VA: 0x18159FE60
	|-Dictionary<object, bool>.TryAdd
	|
	|-RVA: 0x159FDE0 Offset: 0x159E7E0 VA: 0x18159FDE0
	|-Dictionary<object, Bounds>.TryAdd
	|
	|-RVA: 0x159FF20 Offset: 0x159E920 VA: 0x18159FF20
	|-Dictionary<object, Color>.TryAdd
	|
	|-RVA: 0x159FDA0 Offset: 0x159E7A0 VA: 0x18159FDA0
	|-Dictionary<object, Color>.TryAdd
	|
	|-RVA: 0x159FE30 Offset: 0x159E830 VA: 0x18159FE30
	|-Dictionary<object, Color32>.TryAdd
	|
	|-RVA: 0x15B0F70 Offset: 0x15AF970 VA: 0x1815B0F70
	|-Dictionary<object, double>.TryAdd
	|
	|-RVA: 0x15B0FE0 Offset: 0x15AF9E0 VA: 0x1815B0FE0
	|-Dictionary<object, int>.TryAdd
	|
	|-RVA: 0x15B0E90 Offset: 0x15AF890 VA: 0x1815B0E90
	|-Dictionary<object, Int32Enum>.TryAdd
	|
	|-RVA: 0x15B0EC0 Offset: 0x15AF8C0 VA: 0x1815B0EC0
	|-Dictionary<object, long>.TryAdd
	|
	|-RVA: 0x15B0F40 Offset: 0x15AF940 VA: 0x1815B0F40
	|-Dictionary<object, object>.TryAdd
	|
	|-RVA: 0x15B0FA0 Offset: 0x15AF9A0 VA: 0x1815B0FA0
	|-Dictionary<object, Playable>.TryAdd
	|
	|-RVA: 0x15B0EF0 Offset: 0x15AF8F0 VA: 0x1815B0EF0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.TryAdd
	|
	|-RVA: 0x15C0DE0 Offset: 0x15BF7E0 VA: 0x1815C0DE0
	|-Dictionary<object, RaycastHit>.TryAdd
	|
	|-RVA: 0x15C0D70 Offset: 0x15BF770 VA: 0x1815C0D70
	|-Dictionary<object, Rect>.TryAdd
	|
	|-RVA: 0x15C0E40 Offset: 0x15BF840 VA: 0x1815C0E40
	|-Dictionary<object, ResourceLocator>.TryAdd
	|
	|-RVA: 0x15C0E80 Offset: 0x15BF880 VA: 0x1815C0E80
	|-Dictionary<object, float>.TryAdd
	|
	|-RVA: 0x15C0EB0 Offset: 0x15BF8B0 VA: 0x1815C0EB0
	|-Dictionary<object, StylePropertyValue>.TryAdd
	|
	|-RVA: 0x15C0DB0 Offset: 0x15BF7B0 VA: 0x1815C0DB0
	|-Dictionary<object, TextureId>.TryAdd
	|
	|-RVA: 0x15C0D30 Offset: 0x15BF730 VA: 0x1815C0D30
	|-Dictionary<object, XPathNodeRef>.TryAdd
	|
	|-RVA: 0x15D2800 Offset: 0x15D1200 VA: 0x1815D2800
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.TryAdd
	|
	|-RVA: 0x15D28B0 Offset: 0x15D12B0 VA: 0x1815D28B0
	|-Dictionary<object, InputControlLayout.ControlItem>.TryAdd
	|
	|-RVA: 0x15D27D0 Offset: 0x15D11D0 VA: 0x1815D27D0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.TryAdd
	|
	|-RVA: 0x15D2710 Offset: 0x15D1110 VA: 0x1815D2710
	|-Dictionary<object, JsonParser.JsonValue>.TryAdd
	|
	|-RVA: 0x15D2830 Offset: 0x15D1230 VA: 0x1815D2830
	|-Dictionary<object, LiquidVolume.MeshCache>.TryAdd
	|
	|-RVA: 0x15D2880 Offset: 0x15D1280 VA: 0x1815D2880
	|-Dictionary<object, ObjectPool.DelayedStoreData>.TryAdd
	|
	|-RVA: 0x15D2780 Offset: 0x15D1180 VA: 0x1815D2780
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.TryAdd
	|
	|-RVA: 0x15E3580 Offset: 0x15E1F80 VA: 0x1815E3580
	|-Dictionary<object, SVGDocument.ClipData>.TryAdd
	|
	|-RVA: 0x15E35B0 Offset: 0x15E1FB0 VA: 0x1815E35B0
	|-Dictionary<object, SVGDocument.MaskData>.TryAdd
	|
	|-RVA: 0x15E3670 Offset: 0x15E2070 VA: 0x1815E3670
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.TryAdd
	|
	|-RVA: 0x15E35E0 Offset: 0x15E1FE0 VA: 0x1815E35E0
	|-Dictionary<object, SVGDocument.PatternData>.TryAdd
	|
	|-RVA: 0x15E3630 Offset: 0x15E2030 VA: 0x1815E3630
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.TryAdd
	|
	|-RVA: 0x15E3550 Offset: 0x15E1F50 VA: 0x1815E3550
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.TryAdd
	|
	|-RVA: 0x15E3520 Offset: 0x15E1F20 VA: 0x1815E3520
	|-Dictionary<Scene, object>.TryAdd
	|
	|-RVA: 0x15F6F60 Offset: 0x15F5960 VA: 0x1815F6F60
	|-Dictionary<TerrainTileCoord, object>.TryAdd
	|
	|-RVA: 0x15F6F90 Offset: 0x15F5990 VA: 0x1815F6F90
	|-Dictionary<ushort, object>.TryAdd
	|
	|-RVA: 0x15F6EC0 Offset: 0x15F58C0 VA: 0x1815F6EC0
	|-Dictionary<ushort, RpcLink>.TryAdd
	|
	|-RVA: 0x15F6FC0 Offset: 0x15F59C0 VA: 0x1815F6FC0
	|-Dictionary<ushort, ushort>.TryAdd
	|
	|-RVA: 0x15F6F00 Offset: 0x15F5900 VA: 0x1815F6F00
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.TryAdd
	|
	|-RVA: 0x15F6E40 Offset: 0x15F5840 VA: 0x1815F6E40
	|-Dictionary<uint, int>.TryAdd
	|
	|-RVA: 0x15F6E70 Offset: 0x15F5870 VA: 0x1815F6E70
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryAdd
	|
	|-RVA: 0x1609330 Offset: 0x1607D30 VA: 0x181609330
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.TryAdd
	|
	|-RVA: 0x1609380 Offset: 0x1607D80 VA: 0x181609380
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryAdd
	|
	|-RVA: 0x16092E0 Offset: 0x1607CE0 VA: 0x1816092E0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.TryAdd
	|
	|-RVA: 0x1609410 Offset: 0x1607E10 VA: 0x181609410
	|-Dictionary<uint, object>.TryAdd
	|
	|-RVA: 0x1609280 Offset: 0x1607C80 VA: 0x181609280
	|-Dictionary<uint, RpcLinkType>.TryAdd
	|
	|-RVA: 0x16093D0 Offset: 0x1607DD0 VA: 0x1816093D0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.TryAdd
	|
	|-RVA: 0x16092B0 Offset: 0x1607CB0 VA: 0x1816092B0
	|-Dictionary<ulong, object>.TryAdd
	|
	|-RVA: 0x161FA90 Offset: 0x161E490 VA: 0x18161FA90
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.TryAdd
	|
	|-RVA: 0x161FB40 Offset: 0x161E540 VA: 0x18161FB40
	|-Dictionary<Vector2Int, object>.TryAdd
	|
	|-RVA: 0x161FAE0 Offset: 0x161E4E0 VA: 0x18161FAE0
	|-Dictionary<Vector3, Vector3>.TryAdd
	|
	|-RVA: 0x161FA50 Offset: 0x161E450 VA: 0x18161FA50
	|-Dictionary<Vector3Int, object>.TryAdd
	|
	|-RVA: 0x161FA00 Offset: 0x161E400 VA: 0x18161FA00
	|-Dictionary<XPathNodeRef, XPathNodeRef>.TryAdd
	|
	|-RVA: 0x161F870 Offset: 0x161E270 VA: 0x18161F870
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	|
	|-RVA: 0x161FB70 Offset: 0x161E570 VA: 0x18161FB70
	|-Dictionary<Regex.CachedCodeEntryKey, object>.TryAdd
	|
	|-RVA: 0x162D800 Offset: 0x162C200 VA: 0x18162D800
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.TryAdd
	|
	|-RVA: 0x162D750 Offset: 0x162C150 VA: 0x18162D750
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.TryAdd
	|
	|-RVA: 0x162D790 Offset: 0x162C190 VA: 0x18162D790
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.TryAdd
	|
	|-RVA: 0x162D7D0 Offset: 0x162C1D0 VA: 0x18162D7D0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<CSteamID, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<FullRank, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Hash128, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Hash128, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int2, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, CSteamID>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Int3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<InternedString, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Scene, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ushort, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F3E30 Offset: 0x14F2830 VA: 0x1814F3E30
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<InternedString, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x14F3E50 Offset: 0x14F2850 VA: 0x1814F3E50
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15060E0 Offset: 0x1504AE0 VA: 0x1815060E0
	|-Dictionary<Bounds, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15060C0 Offset: 0x1504AC0 VA: 0x1815060C0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1506140 Offset: 0x1504B40 VA: 0x181506140
	|-Dictionary<CSteamID, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int2, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1506160 Offset: 0x1504B60 VA: 0x181506160
	|-Dictionary<FullRank, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int2, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<TerrainTileCoord, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Vector2Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1506100 Offset: 0x1504B00 VA: 0x181506100
	|-Dictionary<Guid, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Hash128, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1506120 Offset: 0x1504B20 VA: 0x181506120
	|-Dictionary<HSteamNetConnection, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1506180 Offset: 0x1504B80 VA: 0x181506180
	|-Dictionary<Hash128, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x151AD40 Offset: 0x1519740 VA: 0x18151AD40
	|-Dictionary<Int3, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x151AD00 Offset: 0x1519700 VA: 0x18151AD00
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, CSteamID>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, Vector2Int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, RpcLinkType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x151AD60 Offset: 0x1519760 VA: 0x18151AD60
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x151AD20 Offset: 0x1519720 VA: 0x18151AD20
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x152C850 Offset: 0x152B250 VA: 0x18152C850
	|-Dictionary<int, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, ByteEnum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int32Enum, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x152C890 Offset: 0x152B290 VA: 0x18152C890
	|-Dictionary<int, HSteamNetConnection>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, uint>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int32Enum, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x152C870 Offset: 0x152B270 VA: 0x18152C870
	|-Dictionary<int, short>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x152C8B0 Offset: 0x152B2B0 VA: 0x18152C8B0
	|-Dictionary<int, Int3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x153D2B0 Offset: 0x153BCB0 VA: 0x18153D2B0
	|-Dictionary<int, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, ulong>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x153D2D0 Offset: 0x153BCD0 VA: 0x18153D2D0
	|-Dictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<Int32Enum, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<uint, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x153D250 Offset: 0x153BC50 VA: 0x18153D250
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, Vector4>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x153D270 Offset: 0x153BC70 VA: 0x18153D270
	|-Dictionary<int, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x153D290 Offset: 0x153BC90 VA: 0x18153D290
	|-Dictionary<int, TreeItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x154D5F0 Offset: 0x154BFF0 VA: 0x18154D5F0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x154D610 Offset: 0x154C010 VA: 0x18154D610
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x155E350 Offset: 0x155CD50 VA: 0x18155E350
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x155E330 Offset: 0x155CD30 VA: 0x18155E330
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1571C60 Offset: 0x1570660 VA: 0x181571C60
	|-Dictionary<long, ComputedStyle>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1571C40 Offset: 0x1570640 VA: 0x181571C40
	|-Dictionary<long, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<IntPtr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<ulong, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1571C00 Offset: 0x1570600 VA: 0x181571C00
	|-Dictionary<InternedString, InternedString>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1571C20 Offset: 0x1570620 VA: 0x181571C20
	|-Dictionary<NativeAddr, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A8E0 Offset: 0x15992E0 VA: 0x18159A8E0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A880 Offset: 0x1599280 VA: 0x18159A880
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A900 Offset: 0x1599300 VA: 0x18159A900
	|-Dictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A8C0 Offset: 0x15992C0 VA: 0x18159A8C0
	|-Dictionary<object, Bounds>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A8A0 Offset: 0x15992A0 VA: 0x18159A8A0
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A920 Offset: 0x1599320 VA: 0x18159A920
	|-Dictionary<object, Color>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, Playable>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, Rect>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x159A940 Offset: 0x1599340 VA: 0x18159A940
	|-Dictionary<object, Color32>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, TextureId>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15AC3A0 Offset: 0x15AADA0 VA: 0x1815AC3A0
	|-Dictionary<object, double>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15AC360 Offset: 0x15AAD60 VA: 0x1815AC360
	|-Dictionary<object, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15AC3C0 Offset: 0x15AADC0 VA: 0x1815AC3C0
	|-Dictionary<object, long>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15AC380 Offset: 0x15AAD80 VA: 0x1815AC380
	|-Dictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15AC340 Offset: 0x15AAD40 VA: 0x1815AC340
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15BC730 Offset: 0x15BB130 VA: 0x1815BC730
	|-Dictionary<object, RaycastHit>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15BC710 Offset: 0x15BB110 VA: 0x1815BC710
	|-Dictionary<object, ResourceLocator>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, StylePropertyValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, XPathNodeRef>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15BC6F0 Offset: 0x15BB0F0 VA: 0x1815BC6F0
	|-Dictionary<object, float>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15CD560 Offset: 0x15CBF60 VA: 0x1815CD560
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15CD5A0 Offset: 0x15CBFA0 VA: 0x1815CD5A0
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15CD580 Offset: 0x15CBF80 VA: 0x1815CD580
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15CD540 Offset: 0x15CBF40 VA: 0x1815CD540
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15DECB0 Offset: 0x15DD6B0 VA: 0x1815DECB0
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15DEC70 Offset: 0x15DD670 VA: 0x1815DEC70
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15DECF0 Offset: 0x15DD6F0 VA: 0x1815DECF0
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15DECD0 Offset: 0x15DD6D0 VA: 0x1815DECD0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15DEC90 Offset: 0x15DD690 VA: 0x1815DEC90
	|-Dictionary<Scene, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15F1160 Offset: 0x15EFB60 VA: 0x1815F1160
	|-Dictionary<ushort, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15F1120 Offset: 0x15EFB20 VA: 0x1815F1120
	|-Dictionary<ushort, RpcLink>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15F1100 Offset: 0x15EFB00 VA: 0x1815F1100
	|-Dictionary<ushort, ushort>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15F1140 Offset: 0x15EFB40 VA: 0x1815F1140
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1604200 Offset: 0x1602C00 VA: 0x181604200
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x16191C0 Offset: 0x1617BC0 VA: 0x1816191C0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1619180 Offset: 0x1617B80 VA: 0x181619180
	|-Dictionary<Vector3, Vector3>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x1619160 Offset: 0x1617B60 VA: 0x181619160
	|-Dictionary<Vector3Int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x16191E0 Offset: 0x1617BE0 VA: 0x1816191E0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x16191A0 Offset: 0x1617BA0 VA: 0x1816191A0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x162A860 Offset: 0x1629260 VA: 0x18162A860
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F52C0 Offset: 0x14F3CC0 VA: 0x1814F52C0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14F4690 Offset: 0x14F3090 VA: 0x1814F4690
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14F56D0 Offset: 0x14F40D0 VA: 0x1814F56D0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14F4AA0 Offset: 0x14F34A0 VA: 0x1814F4AA0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14F4EB0 Offset: 0x14F38B0 VA: 0x1814F4EB0
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1507CD0 Offset: 0x15066D0 VA: 0x181507CD0
	|-Dictionary<Bounds, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15073C0 Offset: 0x1505DC0 VA: 0x1815073C0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1506F90 Offset: 0x1505990 VA: 0x181506F90
	|-Dictionary<CSteamID, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1506BA0 Offset: 0x15055A0 VA: 0x181506BA0
	|-Dictionary<FullRank, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1508570 Offset: 0x1506F70 VA: 0x181508570
	|-Dictionary<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15078A0 Offset: 0x15062A0 VA: 0x1815078A0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1508120 Offset: 0x1506B20 VA: 0x181508120
	|-Dictionary<Hash128, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151BD70 Offset: 0x151A770 VA: 0x18151BD70
	|-Dictionary<Hash128, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151C570 Offset: 0x151AF70 VA: 0x18151C570
	|-Dictionary<Int2, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151C180 Offset: 0x151AB80 VA: 0x18151C180
	|-Dictionary<Int2, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151B500 Offset: 0x1519F00 VA: 0x18151B500
	|-Dictionary<Int3, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151B940 Offset: 0x151A340 VA: 0x18151B940
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151C9A0 Offset: 0x151B3A0 VA: 0x18151C9A0
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x151CE10 Offset: 0x151B810 VA: 0x18151CE10
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152E430 Offset: 0x152CE30 VA: 0x18152E430
	|-Dictionary<int, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152DBC0 Offset: 0x152C5C0 VA: 0x18152DBC0
	|-Dictionary<int, ByteEnum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152D350 Offset: 0x152BD50 VA: 0x18152D350
	|-Dictionary<int, CSteamID>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152CF20 Offset: 0x152B920 VA: 0x18152CF20
	|-Dictionary<int, HSteamNetConnection>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152D780 Offset: 0x152C180 VA: 0x18152D780
	|-Dictionary<int, short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152E000 Offset: 0x152CA00 VA: 0x18152E000
	|-Dictionary<int, Int3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x152E870 Offset: 0x152D270 VA: 0x18152E870
	|-Dictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153F2F0 Offset: 0x153DCF0 VA: 0x18153F2F0
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153E660 Offset: 0x153D060 VA: 0x18153E660
	|-Dictionary<int, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153DE20 Offset: 0x153C820 VA: 0x18153DE20
	|-Dictionary<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153EA80 Offset: 0x153D480 VA: 0x18153EA80
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153D9E0 Offset: 0x153C3E0 VA: 0x18153D9E0
	|-Dictionary<int, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153E210 Offset: 0x153CC10 VA: 0x18153E210
	|-Dictionary<int, TreeItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x153EEC0 Offset: 0x153D8C0 VA: 0x18153EEC0
	|-Dictionary<int, uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154E140 Offset: 0x154CB40 VA: 0x18154E140
	|-Dictionary<int, ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154E560 Offset: 0x154CF60 VA: 0x18154E560
	|-Dictionary<int, Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154F680 Offset: 0x154E080 VA: 0x18154F680
	|-Dictionary<int, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154EE00 Offset: 0x154D800 VA: 0x18154EE00
	|-Dictionary<int, Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154DD10 Offset: 0x154C710 VA: 0x18154DD10
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154F240 Offset: 0x154DC40 VA: 0x18154F240
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x154E990 Offset: 0x154D390 VA: 0x18154E990
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155F0C0 Offset: 0x155DAC0 VA: 0x18155F0C0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155FEE0 Offset: 0x155E8E0 VA: 0x18155FEE0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155F670 Offset: 0x155E070 VA: 0x18155F670
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1560790 Offset: 0x155F190 VA: 0x181560790
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1560360 Offset: 0x155ED60 VA: 0x181560360
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155EC90 Offset: 0x155D690 VA: 0x18155EC90
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155FAF0 Offset: 0x155E4F0 VA: 0x18155FAF0
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1573990 Offset: 0x1572390 VA: 0x181573990
	|-Dictionary<long, ComputedStyle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15724D0 Offset: 0x1570ED0 VA: 0x1815724D0
	|-Dictionary<long, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1573140 Offset: 0x1571B40 VA: 0x181573140
	|-Dictionary<IntPtr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1573EC0 Offset: 0x15728C0 VA: 0x181573EC0
	|-Dictionary<InternedString, InternedString>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15728C0 Offset: 0x15712C0 VA: 0x1815728C0
	|-Dictionary<InternedString, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1573530 Offset: 0x1571F30 VA: 0x181573530
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1572CD0 Offset: 0x15716D0 VA: 0x181572CD0
	|-Dictionary<NativeAddr, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159B930 Offset: 0x159A330 VA: 0x18159B930
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159B4D0 Offset: 0x1599ED0 VA: 0x18159B4D0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159C170 Offset: 0x159AB70 VA: 0x18159C170
	|-Dictionary<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159C550 Offset: 0x159AF50 VA: 0x18159C550
	|-Dictionary<object, Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159B090 Offset: 0x1599A90 VA: 0x18159B090
	|-Dictionary<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159BD50 Offset: 0x159A750 VA: 0x18159BD50
	|-Dictionary<object, Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x159C990 Offset: 0x159B390 VA: 0x18159C990
	|-Dictionary<object, Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15AD770 Offset: 0x15AC170 VA: 0x1815AD770
	|-Dictionary<object, double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15ADF40 Offset: 0x15AC940 VA: 0x1815ADF40
	|-Dictionary<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15AE320 Offset: 0x15ACD20 VA: 0x1815AE320
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15ADB60 Offset: 0x15AC560 VA: 0x1815ADB60
	|-Dictionary<object, long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15ACF40 Offset: 0x15AB940 VA: 0x1815ACF40
	|-Dictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15ACB20 Offset: 0x15AB520 VA: 0x1815ACB20
	|-Dictionary<object, Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15AD2F0 Offset: 0x15ABCF0 VA: 0x1815AD2F0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BE6B0 Offset: 0x15BD0B0 VA: 0x1815BE6B0
	|-Dictionary<object, RaycastHit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BDE70 Offset: 0x15BC870 VA: 0x1815BDE70
	|-Dictionary<object, Rect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BD670 Offset: 0x15BC070 VA: 0x1815BD670
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BCE60 Offset: 0x15BB860 VA: 0x1815BCE60
	|-Dictionary<object, float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BD250 Offset: 0x15BBC50 VA: 0x1815BD250
	|-Dictionary<object, StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BDA90 Offset: 0x15BC490 VA: 0x1815BDA90
	|-Dictionary<object, TextureId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15BE290 Offset: 0x15BCC90 VA: 0x1815BE290
	|-Dictionary<object, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CF9F0 Offset: 0x15CE3F0 VA: 0x1815CF9F0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CEC10 Offset: 0x15CD610 VA: 0x1815CEC10
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CF1D0 Offset: 0x15CDBD0 VA: 0x1815CF1D0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CDF20 Offset: 0x15CC920 VA: 0x1815CDF20
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CF5B0 Offset: 0x15CDFB0 VA: 0x1815CF5B0
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CE830 Offset: 0x15CD230 VA: 0x1815CE830
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15CE3F0 Offset: 0x15CCDF0 VA: 0x1815CE3F0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15E0400 Offset: 0x15DEE00 VA: 0x1815E0400
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15E0020 Offset: 0x15DEA20 VA: 0x1815E0020
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15E0C40 Offset: 0x15DF640 VA: 0x1815E0C40
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15DF3F0 Offset: 0x15DDDF0 VA: 0x1815DF3F0
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15E07E0 Offset: 0x15DF1E0 VA: 0x1815E07E0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15DFC40 Offset: 0x15DE640 VA: 0x1815DFC40
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15DF850 Offset: 0x15DE250 VA: 0x1815DF850
	|-Dictionary<Scene, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F1D90 Offset: 0x15F0790 VA: 0x1815F1D90
	|-Dictionary<TerrainTileCoord, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F19A0 Offset: 0x15F03A0 VA: 0x1815F19A0
	|-Dictionary<ushort, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F25B0 Offset: 0x15F0FB0 VA: 0x1815F25B0
	|-Dictionary<ushort, RpcLink>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F3310 Offset: 0x15F1D10 VA: 0x1815F3310
	|-Dictionary<ushort, ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F29F0 Offset: 0x15F13F0 VA: 0x1815F29F0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F2180 Offset: 0x15F0B80 VA: 0x1815F2180
	|-Dictionary<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15F2EA0 Offset: 0x15F18A0 VA: 0x1815F2EA0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x16055D0 Offset: 0x1603FD0 VA: 0x1816055D0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1604920 Offset: 0x1603320 VA: 0x181604920
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1606260 Offset: 0x1604C60 VA: 0x181606260
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1604D90 Offset: 0x1603790 VA: 0x181604D90
	|-Dictionary<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1605A40 Offset: 0x1604440 VA: 0x181605A40
	|-Dictionary<uint, RpcLinkType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1605180 Offset: 0x1603B80 VA: 0x181605180
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1605E70 Offset: 0x1604870 VA: 0x181605E70
	|-Dictionary<ulong, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161A600 Offset: 0x1619000 VA: 0x18161A600
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161AEF0 Offset: 0x16198F0 VA: 0x18161AEF0
	|-Dictionary<Vector2Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161A190 Offset: 0x1618B90 VA: 0x18161A190
	|-Dictionary<Vector3, Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1619D60 Offset: 0x1618760 VA: 0x181619D60
	|-Dictionary<Vector3Int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161B2E0 Offset: 0x1619CE0 VA: 0x18161B2E0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161B740 Offset: 0x161A140 VA: 0x18161B740
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x161AAA0 Offset: 0x16194A0 VA: 0x18161AAA0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x162B460 Offset: 0x1629E60 VA: 0x18162B460
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x162B8B0 Offset: 0x162A2B0 VA: 0x18162B8B0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x162B050 Offset: 0x1629A50 VA: 0x18162B050
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x162AC60 Offset: 0x1629660 VA: 0x18162AC60
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F4510 Offset: 0x14F2F10 VA: 0x1814F4510
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Hash128, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Hash128, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, TreeItem>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<InternedString, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Playable>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Rect>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, ResourceLocator>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Vector3, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Vector3Int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14F45A0 Offset: 0x14F2FA0 VA: 0x1814F45A0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1506920 Offset: 0x1505320 VA: 0x181506920
	|-Dictionary<Bounds, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<InternedString, InternedString>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Bounds>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1506AD0 Offset: 0x15054D0 VA: 0x181506AD0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15069C0 Offset: 0x15053C0 VA: 0x1815069C0
	|-Dictionary<CSteamID, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int2, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, CSteamID>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, RpcLinkType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1506A40 Offset: 0x1505440 VA: 0x181506A40
	|-Dictionary<FullRank, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int2, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int3, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Int3>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, ulong>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int32Enum, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<long, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<IntPtr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Color32>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, double>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, long>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, TextureId>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Scene, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ushort, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ulong, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Vector2Int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15068A0 Offset: 0x15052A0 VA: 0x1815068A0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, ByteEnum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, short>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, float>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, uint>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int32Enum, bool>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x151B470 Offset: 0x1519E70 VA: 0x18151B470
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x153D950 Offset: 0x153C350 VA: 0x18153D950
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ushort, RpcLink>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x155EB90 Offset: 0x155D590 VA: 0x18155EB90
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x155EAF0 Offset: 0x155D4F0 VA: 0x18155EAF0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<NativeAddr, object>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15723F0 Offset: 0x1570DF0 VA: 0x1815723F0
	|-Dictionary<long, ComputedStyle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15ACA70 Offset: 0x15AB470 VA: 0x1815ACA70
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<object, RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15CDE10 Offset: 0x15CC810 VA: 0x1815CDE10
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15F1920 Offset: 0x15F0320 VA: 0x1815F1920
	|-Dictionary<ushort, ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x15F1860 Offset: 0x15F0260 VA: 0x1815F1860
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1619CA0 Offset: 0x16186A0 VA: 0x181619CA0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Bounds, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<CSteamID, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<FullRank, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<HSteamNetConnection, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Hash128, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Hash128, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int2, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int2, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int3, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, ByteEnum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, CSteamID>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, HSteamNetConnection>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, short>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Int3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, TreeItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, uint>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, ulong>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Vector2Int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Vector4>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<long, ComputedStyle>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<long, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<IntPtr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<InternedString, InternedString>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<InternedString, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<NativeAddr, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Bounds>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Color>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Color32>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, double>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, long>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Playable>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, RaycastHit>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, Rect>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, float>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, TextureId>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Scene, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<TerrainTileCoord, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ushort, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ushort, RpcLink>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ushort, ushort>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, RpcLinkType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ulong, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Vector2Int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Vector3, Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Vector3Int, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_IsSynchronized
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F5D80 Offset: 0x14F4780 VA: 0x1814F5D80
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14F5C30 Offset: 0x14F4630 VA: 0x1814F5C30
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14F5CA0 Offset: 0x14F46A0 VA: 0x1814F5CA0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14F5D10 Offset: 0x14F4710 VA: 0x1814F5D10
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14F5BC0 Offset: 0x14F45C0 VA: 0x1814F5BC0
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508A60 Offset: 0x1507460 VA: 0x181508A60
	|-Dictionary<Bounds, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508980 Offset: 0x1507380 VA: 0x181508980
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508C20 Offset: 0x1507620 VA: 0x181508C20
	|-Dictionary<CSteamID, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508BB0 Offset: 0x15075B0 VA: 0x181508BB0
	|-Dictionary<FullRank, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508AD0 Offset: 0x15074D0 VA: 0x181508AD0
	|-Dictionary<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15089F0 Offset: 0x15073F0 VA: 0x1815089F0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1508B40 Offset: 0x1507540 VA: 0x181508B40
	|-Dictionary<Hash128, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D2F0 Offset: 0x151BCF0 VA: 0x18151D2F0
	|-Dictionary<Hash128, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D520 Offset: 0x151BF20 VA: 0x18151D520
	|-Dictionary<Int2, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D440 Offset: 0x151BE40 VA: 0x18151D440
	|-Dictionary<Int2, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D360 Offset: 0x151BD60 VA: 0x18151D360
	|-Dictionary<Int3, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D3D0 Offset: 0x151BDD0 VA: 0x18151D3D0
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D4B0 Offset: 0x151BEB0 VA: 0x18151D4B0
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x151D280 Offset: 0x151BC80 VA: 0x18151D280
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152ECA0 Offset: 0x152D6A0 VA: 0x18152ECA0
	|-Dictionary<int, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152ED80 Offset: 0x152D780 VA: 0x18152ED80
	|-Dictionary<int, ByteEnum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152EED0 Offset: 0x152D8D0 VA: 0x18152EED0
	|-Dictionary<int, CSteamID>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152ED10 Offset: 0x152D710 VA: 0x18152ED10
	|-Dictionary<int, HSteamNetConnection>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152EF40 Offset: 0x152D940 VA: 0x18152EF40
	|-Dictionary<int, short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152EDF0 Offset: 0x152D7F0 VA: 0x18152EDF0
	|-Dictionary<int, Int3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x152EE60 Offset: 0x152D860 VA: 0x18152EE60
	|-Dictionary<int, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F800 Offset: 0x153E200 VA: 0x18153F800
	|-Dictionary<int, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F790 Offset: 0x153E190 VA: 0x18153F790
	|-Dictionary<int, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F8E0 Offset: 0x153E2E0 VA: 0x18153F8E0
	|-Dictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F720 Offset: 0x153E120 VA: 0x18153F720
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F950 Offset: 0x153E350 VA: 0x18153F950
	|-Dictionary<int, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F9C0 Offset: 0x153E3C0 VA: 0x18153F9C0
	|-Dictionary<int, TreeItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x153F870 Offset: 0x153E270 VA: 0x18153F870
	|-Dictionary<int, uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FCE0 Offset: 0x154E6E0 VA: 0x18154FCE0
	|-Dictionary<int, ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FC70 Offset: 0x154E670 VA: 0x18154FC70
	|-Dictionary<int, Vector2Int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FB90 Offset: 0x154E590 VA: 0x18154FB90
	|-Dictionary<int, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FD50 Offset: 0x154E750 VA: 0x18154FD50
	|-Dictionary<int, Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FC00 Offset: 0x154E600 VA: 0x18154FC00
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FAB0 Offset: 0x154E4B0 VA: 0x18154FAB0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x154FB20 Offset: 0x154E520 VA: 0x18154FB20
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560BD0 Offset: 0x155F5D0 VA: 0x181560BD0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560D90 Offset: 0x155F790 VA: 0x181560D90
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560E70 Offset: 0x155F870 VA: 0x181560E70
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560E00 Offset: 0x155F800 VA: 0x181560E00
	|-Dictionary<Int32Enum, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560D20 Offset: 0x155F720 VA: 0x181560D20
	|-Dictionary<Int32Enum, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560CB0 Offset: 0x155F6B0 VA: 0x181560CB0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1560C40 Offset: 0x155F640 VA: 0x181560C40
	|-Dictionary<Int32Enum, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1574390 Offset: 0x1572D90 VA: 0x181574390
	|-Dictionary<long, ComputedStyle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1574320 Offset: 0x1572D20 VA: 0x181574320
	|-Dictionary<long, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1574400 Offset: 0x1572E00 VA: 0x181574400
	|-Dictionary<IntPtr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1574550 Offset: 0x1572F50 VA: 0x181574550
	|-Dictionary<InternedString, InternedString>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1574470 Offset: 0x1572E70 VA: 0x181574470
	|-Dictionary<InternedString, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15744E0 Offset: 0x1572EE0 VA: 0x1815744E0
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15745C0 Offset: 0x1572FC0 VA: 0x1815745C0
	|-Dictionary<NativeAddr, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CF30 Offset: 0x159B930 VA: 0x18159CF30
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CFA0 Offset: 0x159B9A0 VA: 0x18159CFA0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CEC0 Offset: 0x159B8C0 VA: 0x18159CEC0
	|-Dictionary<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159D010 Offset: 0x159BA10 VA: 0x18159D010
	|-Dictionary<object, Bounds>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CDE0 Offset: 0x159B7E0 VA: 0x18159CDE0
	|-Dictionary<object, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CD70 Offset: 0x159B770 VA: 0x18159CD70
	|-Dictionary<object, Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x159CE50 Offset: 0x159B850 VA: 0x18159CE50
	|-Dictionary<object, Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE930 Offset: 0x15AD330 VA: 0x1815AE930
	|-Dictionary<object, double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE850 Offset: 0x15AD250 VA: 0x1815AE850
	|-Dictionary<object, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE8C0 Offset: 0x15AD2C0 VA: 0x1815AE8C0
	|-Dictionary<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE7E0 Offset: 0x15AD1E0 VA: 0x1815AE7E0
	|-Dictionary<object, long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE700 Offset: 0x15AD100 VA: 0x1815AE700
	|-Dictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE9A0 Offset: 0x15AD3A0 VA: 0x1815AE9A0
	|-Dictionary<object, Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15AE770 Offset: 0x15AD170 VA: 0x1815AE770
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BEDF0 Offset: 0x15BD7F0 VA: 0x1815BEDF0
	|-Dictionary<object, RaycastHit>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BEB50 Offset: 0x15BD550 VA: 0x1815BEB50
	|-Dictionary<object, Rect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BEBC0 Offset: 0x15BD5C0 VA: 0x1815BEBC0
	|-Dictionary<object, ResourceLocator>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BECA0 Offset: 0x15BD6A0 VA: 0x1815BECA0
	|-Dictionary<object, float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BED80 Offset: 0x15BD780 VA: 0x1815BED80
	|-Dictionary<object, StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BED10 Offset: 0x15BD710 VA: 0x1815BED10
	|-Dictionary<object, TextureId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15BEC30 Offset: 0x15BD630 VA: 0x1815BEC30
	|-Dictionary<object, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15CFE40 Offset: 0x15CE840 VA: 0x1815CFE40
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15CFF20 Offset: 0x15CE920 VA: 0x1815CFF20
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15CFF90 Offset: 0x15CE990 VA: 0x1815CFF90
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15D0070 Offset: 0x15CEA70 VA: 0x1815D0070
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15D0000 Offset: 0x15CEA00 VA: 0x1815D0000
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15CFDD0 Offset: 0x15CE7D0 VA: 0x1815CFDD0
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15CFEB0 Offset: 0x15CE8B0 VA: 0x1815CFEB0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E1040 Offset: 0x15DFA40 VA: 0x1815E1040
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E1120 Offset: 0x15DFB20 VA: 0x1815E1120
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E1190 Offset: 0x15DFB90 VA: 0x1815E1190
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E1200 Offset: 0x15DFC00 VA: 0x1815E1200
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E10B0 Offset: 0x15DFAB0 VA: 0x1815E10B0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E12E0 Offset: 0x15DFCE0 VA: 0x1815E12E0
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15E1270 Offset: 0x15DFC70 VA: 0x1815E1270
	|-Dictionary<Scene, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F3810 Offset: 0x15F2210 VA: 0x1815F3810
	|-Dictionary<TerrainTileCoord, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F3960 Offset: 0x15F2360 VA: 0x1815F3960
	|-Dictionary<ushort, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F38F0 Offset: 0x15F22F0 VA: 0x1815F38F0
	|-Dictionary<ushort, RpcLink>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F3730 Offset: 0x15F2130 VA: 0x1815F3730
	|-Dictionary<ushort, ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F39D0 Offset: 0x15F23D0 VA: 0x1815F39D0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F37A0 Offset: 0x15F21A0 VA: 0x1815F37A0
	|-Dictionary<uint, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x15F3880 Offset: 0x15F2280 VA: 0x1815F3880
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1606900 Offset: 0x1605300 VA: 0x181606900
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1606820 Offset: 0x1605220 VA: 0x181606820
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x16067B0 Offset: 0x16051B0 VA: 0x1816067B0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x16066D0 Offset: 0x16050D0 VA: 0x1816066D0
	|-Dictionary<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1606890 Offset: 0x1605290 VA: 0x181606890
	|-Dictionary<uint, RpcLinkType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1606970 Offset: 0x1605370 VA: 0x181606970
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1606740 Offset: 0x1605140 VA: 0x181606740
	|-Dictionary<ulong, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161BF00 Offset: 0x161A900 VA: 0x18161BF00
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161C0C0 Offset: 0x161AAC0 VA: 0x18161C0C0
	|-Dictionary<Vector2Int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161BF70 Offset: 0x161A970 VA: 0x18161BF70
	|-Dictionary<Vector3, Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161BE20 Offset: 0x161A820 VA: 0x18161BE20
	|-Dictionary<Vector3Int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161C050 Offset: 0x161AA50 VA: 0x18161C050
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161BFE0 Offset: 0x161A9E0 VA: 0x18161BFE0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x161BE90 Offset: 0x161A890 VA: 0x18161BE90
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x162BDE0 Offset: 0x162A7E0 VA: 0x18162BDE0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x162BD70 Offset: 0x162A770 VA: 0x18162BD70
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x162BD00 Offset: 0x162A700 VA: 0x18162BD00
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x162BE50 Offset: 0x162A850 VA: 0x18162BE50
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int2, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int2, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int3, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, short>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Int3>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, long>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, float>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, ulong>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<long, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, double>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, long>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, float>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Scene, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.get_IsFixedSize
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int2, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int2, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int3, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, short>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Int3>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, long>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, float>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, ulong>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<long, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, double>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, long>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, float>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Scene, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.get_IsReadOnly
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F7A80 Offset: 0x14F6480 VA: 0x1814F7A80
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.get_Keys
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int2, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int2, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int3, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, short>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Int3>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, float>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, ulong>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Keys
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.get_Keys
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.get_Keys
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.get_Keys
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, double>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, long>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.get_Keys
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Scene, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.get_Keys
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Keys
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.get_Keys
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.get_Keys
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x14BFF20 Offset: 0x14BE920 VA: 0x1814BFF20
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F7B30 Offset: 0x14F6530 VA: 0x1814F7B30
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.get_Values
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.get_Values
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int2, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int2, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int3, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, short>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Int3>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, float>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, ulong>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Values
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Values
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.get_Values
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.get_Values
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.get_Values
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, double>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, long>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.get_Values
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.get_Values
	|-Dictionary<Scene, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.get_Values
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.get_Values
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.get_Values
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.get_Values
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.get_Values
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Values
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.get_Values
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.get_Values
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x161E960 Offset: 0x161D360 VA: 0x18161E960
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F76F0 Offset: 0x14F60F0 VA: 0x1814F76F0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14F7820 Offset: 0x14F6220 VA: 0x1814F7820
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14F7570 Offset: 0x14F5F70 VA: 0x1814F7570
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14F7950 Offset: 0x14F6350 VA: 0x1814F7950
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14F7440 Offset: 0x14F5E40 VA: 0x1814F7440
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150ADF0 Offset: 0x15097F0 VA: 0x18150ADF0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150AF30 Offset: 0x1509930 VA: 0x18150AF30
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150B450 Offset: 0x1509E50 VA: 0x18150B450
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150B0B0 Offset: 0x1509AB0 VA: 0x18150B0B0
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150B1D0 Offset: 0x1509BD0 VA: 0x18150B1D0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150B300 Offset: 0x1509D00 VA: 0x18150B300
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x150ACA0 Offset: 0x15096A0 VA: 0x18150ACA0
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F160 Offset: 0x151DB60 VA: 0x18151F160
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F3E0 Offset: 0x151DDE0 VA: 0x18151F3E0
	|-Dictionary<Int2, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F680 Offset: 0x151E080 VA: 0x18151F680
	|-Dictionary<Int2, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F8F0 Offset: 0x151E2F0 VA: 0x18151F8F0
	|-Dictionary<Int3, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F530 Offset: 0x151DF30 VA: 0x18151F530
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F290 Offset: 0x151DC90 VA: 0x18151F290
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x151F7A0 Offset: 0x151E1A0 VA: 0x18151F7A0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1530170 Offset: 0x152EB70 VA: 0x181530170
	|-Dictionary<int, bool>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15302C0 Offset: 0x152ECC0 VA: 0x1815302C0
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, int>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, uint>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1530560 Offset: 0x152EF60 VA: 0x181530560
	|-Dictionary<int, short>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1530410 Offset: 0x152EE10 VA: 0x181530410
	|-Dictionary<int, Int3>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1540FE0 Offset: 0x153F9E0 VA: 0x181540FE0
	|-Dictionary<int, long>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, ulong>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1540D70 Offset: 0x153F770 VA: 0x181540D70
	|-Dictionary<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1540E90 Offset: 0x153F890 VA: 0x181540E90
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1541130 Offset: 0x153FB30 VA: 0x181541130
	|-Dictionary<int, float>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1541280 Offset: 0x153FC80 VA: 0x181541280
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1550DE0 Offset: 0x154F7E0 VA: 0x181550DE0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1550C80 Offset: 0x154F680 VA: 0x181550C80
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1562820 Offset: 0x1561220 VA: 0x181562820
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1562B00 Offset: 0x1561500 VA: 0x181562B00
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Item
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1562C60 Offset: 0x1561660 VA: 0x181562C60
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15626D0 Offset: 0x15610D0 VA: 0x1815626D0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.get_Item
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15629E0 Offset: 0x15613E0 VA: 0x1815629E0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15765A0 Offset: 0x1574FA0 VA: 0x1815765A0
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1576730 Offset: 0x1575130 VA: 0x181576730
	|-Dictionary<long, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1576480 Offset: 0x1574E80 VA: 0x181576480
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15761F0 Offset: 0x1574BF0 VA: 0x1815761F0
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.get_Item
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1576850 Offset: 0x1575250 VA: 0x181576850
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1576340 Offset: 0x1574D40 VA: 0x181576340
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x159EA20 Offset: 0x159D420 VA: 0x18159EA20
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, Playable>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, Rect>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x159EE10 Offset: 0x159D810 VA: 0x18159EE10
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x159ECD0 Offset: 0x159D6D0 VA: 0x18159ECD0
	|-Dictionary<object, bool>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x159EB70 Offset: 0x159D570 VA: 0x18159EB70
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, Color>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x159E8E0 Offset: 0x159D2E0 VA: 0x18159E8E0
	|-Dictionary<object, Color32>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, int>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15AFF80 Offset: 0x15AE980 VA: 0x1815AFF80
	|-Dictionary<object, double>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15AFE40 Offset: 0x15AE840 VA: 0x1815AFE40
	|-Dictionary<object, long>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.get_Item
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15AFD10 Offset: 0x15AE710 VA: 0x1815AFD10
	|-Dictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15AFBA0 Offset: 0x15AE5A0 VA: 0x1815AFBA0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15BFDB0 Offset: 0x15BE7B0 VA: 0x1815BFDB0
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15BFC70 Offset: 0x15BE670 VA: 0x1815BFC70
	|-Dictionary<object, float>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15D1650 Offset: 0x15D0050 VA: 0x1815D1650
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15D14C0 Offset: 0x15CFEC0 VA: 0x1815D14C0
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15E2360 Offset: 0x15E0D60 VA: 0x1815E2360
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15E24A0 Offset: 0x15E0EA0 VA: 0x1815E24A0
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15E2600 Offset: 0x15E1000 VA: 0x1815E2600
	|-Dictionary<Scene, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F5F70 Offset: 0x15F4970 VA: 0x1815F5F70
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F58F0 Offset: 0x15F42F0 VA: 0x1815F58F0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F57A0 Offset: 0x15F41A0 VA: 0x1815F57A0
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F5B60 Offset: 0x15F4560 VA: 0x1815F5B60
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F5CB0 Offset: 0x15F46B0 VA: 0x1815F5CB0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F5E20 Offset: 0x15F4820 VA: 0x1815F5E20
	|-Dictionary<uint, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x15F5A10 Offset: 0x15F4410 VA: 0x1815F5A10
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Item
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.get_Item
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Item
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1608250 Offset: 0x1606C50 VA: 0x181608250
	|-Dictionary<uint, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1607FE0 Offset: 0x16069E0 VA: 0x181607FE0
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1608370 Offset: 0x1606D70 VA: 0x181608370
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1608130 Offset: 0x1606B30 VA: 0x181608130
	|-Dictionary<ulong, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E2A0 Offset: 0x161CCA0 VA: 0x18161E2A0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E670 Offset: 0x161D070 VA: 0x18161E670
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161DFE0 Offset: 0x161C9E0 VA: 0x18161DFE0
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E540 Offset: 0x161CF40 VA: 0x18161E540
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E150 Offset: 0x161CB50 VA: 0x18161E150
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E790 Offset: 0x161D190 VA: 0x18161E790
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x161E400 Offset: 0x161CE00 VA: 0x18161E400
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x162CCF0 Offset: 0x162B6F0 VA: 0x18162CCF0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.get_Item
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x162CE40 Offset: 0x162B840 VA: 0x18162CE40
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x162CBD0 Offset: 0x162B5D0 VA: 0x18162CBD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F8410 Offset: 0x14F6E10 VA: 0x1814F8410
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14F7BE0 Offset: 0x14F65E0 VA: 0x1814F7BE0
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14F7FE0 Offset: 0x14F69E0 VA: 0x1814F7FE0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14F8210 Offset: 0x14F6C10 VA: 0x1814F8210
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14F7DE0 Offset: 0x14F67E0 VA: 0x1814F7DE0
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150B9F0 Offset: 0x150A3F0 VA: 0x18150B9F0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150B5A0 Offset: 0x1509FA0 VA: 0x18150B5A0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150BDE0 Offset: 0x150A7E0 VA: 0x18150BDE0
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150BC00 Offset: 0x150A600 VA: 0x18150BC00
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150C1C0 Offset: 0x150ABC0 VA: 0x18150C1C0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150BFD0 Offset: 0x150A9D0 VA: 0x18150BFD0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x150B7F0 Offset: 0x150A1F0 VA: 0x18150B7F0
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1520030 Offset: 0x151EA30 VA: 0x181520030
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x151FE40 Offset: 0x151E840 VA: 0x18151FE40
	|-Dictionary<Int2, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1520630 Offset: 0x151F030 VA: 0x181520630
	|-Dictionary<Int2, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x151FA50 Offset: 0x151E450 VA: 0x18151FA50
	|-Dictionary<Int3, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x151FC50 Offset: 0x151E650 VA: 0x18151FC50
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1520230 Offset: 0x151EC30 VA: 0x181520230
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1520430 Offset: 0x151EE30 VA: 0x181520430
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1530AA0 Offset: 0x152F4A0 VA: 0x181530AA0
	|-Dictionary<int, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1531260 Offset: 0x152FC60 VA: 0x181531260
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15308B0 Offset: 0x152F2B0 VA: 0x1815308B0
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1530C90 Offset: 0x152F690 VA: 0x181530C90
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1531070 Offset: 0x152FA70 VA: 0x181531070
	|-Dictionary<int, short>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15306B0 Offset: 0x152F0B0 VA: 0x1815306B0
	|-Dictionary<int, Int3>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1530E80 Offset: 0x152F880 VA: 0x181530E80
	|-Dictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1541B90 Offset: 0x1540590 VA: 0x181541B90
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15419A0 Offset: 0x15403A0 VA: 0x1815419A0
	|-Dictionary<int, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15415C0 Offset: 0x153FFC0 VA: 0x1815415C0
	|-Dictionary<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15417B0 Offset: 0x15401B0 VA: 0x1815417B0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1541D80 Offset: 0x1540780 VA: 0x181541D80
	|-Dictionary<int, float>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1541F70 Offset: 0x1540970 VA: 0x181541F70
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15413D0 Offset: 0x153FDD0 VA: 0x1815413D0
	|-Dictionary<int, uint>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551130 Offset: 0x154FB30 VA: 0x181551130
	|-Dictionary<int, ulong>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551910 Offset: 0x1550310 VA: 0x181551910
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1550F30 Offset: 0x154F930 VA: 0x181550F30
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551B00 Offset: 0x1550500 VA: 0x181551B00
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551320 Offset: 0x154FD20 VA: 0x181551320
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551710 Offset: 0x1550110 VA: 0x181551710
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1551510 Offset: 0x154FF10 VA: 0x181551510
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1563770 Offset: 0x1562170 VA: 0x181563770
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1563190 Offset: 0x1561B90 VA: 0x181563190
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15639C0 Offset: 0x15623C0 VA: 0x1815639C0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1563580 Offset: 0x1561F80 VA: 0x181563580
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1562DB0 Offset: 0x15617B0 VA: 0x181562DB0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1562FA0 Offset: 0x15619A0 VA: 0x181562FA0
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1563390 Offset: 0x1561D90 VA: 0x181563390
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1576B90 Offset: 0x1575590 VA: 0x181576B90
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1576FC0 Offset: 0x15759C0 VA: 0x181576FC0
	|-Dictionary<long, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15773C0 Offset: 0x1575DC0 VA: 0x1815773C0
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15775B0 Offset: 0x1575FB0 VA: 0x1815775B0
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1576DC0 Offset: 0x15757C0 VA: 0x181576DC0
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1576980 Offset: 0x1575380 VA: 0x181576980
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15771B0 Offset: 0x1575BB0 VA: 0x1815771B0
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159F190 Offset: 0x159DB90 VA: 0x18159F190
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159F590 Offset: 0x159DF90 VA: 0x18159F590
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159F9B0 Offset: 0x159E3B0 VA: 0x18159F9B0
	|-Dictionary<object, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159EF80 Offset: 0x159D980 VA: 0x18159EF80
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159F7A0 Offset: 0x159E1A0 VA: 0x18159F7A0
	|-Dictionary<object, Color>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159F390 Offset: 0x159DD90 VA: 0x18159F390
	|-Dictionary<object, Color>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x159FBA0 Offset: 0x159E5A0 VA: 0x18159FBA0
	|-Dictionary<object, Color32>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B06C0 Offset: 0x15AF0C0 VA: 0x1815B06C0
	|-Dictionary<object, double>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B0CA0 Offset: 0x15AF6A0 VA: 0x1815B0CA0
	|-Dictionary<object, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B0AB0 Offset: 0x15AF4B0 VA: 0x1815B0AB0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B04D0 Offset: 0x15AEED0 VA: 0x1815B04D0
	|-Dictionary<object, long>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B02E0 Offset: 0x15AECE0 VA: 0x1815B02E0
	|-Dictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B08B0 Offset: 0x15AF2B0 VA: 0x1815B08B0
	|-Dictionary<object, Playable>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15B00C0 Offset: 0x15AEAC0 VA: 0x1815B00C0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0320 Offset: 0x15BED20 VA: 0x1815C0320
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0120 Offset: 0x15BEB20 VA: 0x1815C0120
	|-Dictionary<object, Rect>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0930 Offset: 0x15BF330 VA: 0x1815C0930
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0540 Offset: 0x15BEF40 VA: 0x1815C0540
	|-Dictionary<object, float>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0B30 Offset: 0x15BF530 VA: 0x1815C0B30
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15BFF20 Offset: 0x15BE920 VA: 0x1815BFF20
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15C0730 Offset: 0x15BF130 VA: 0x1815C0730
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D1C40 Offset: 0x15D0640 VA: 0x1815D1C40
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D2070 Offset: 0x15D0A70 VA: 0x1815D2070
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D1840 Offset: 0x15D0240 VA: 0x1815D1840
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D1E40 Offset: 0x15D0840 VA: 0x1815D1E40
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D2500 Offset: 0x15D0F00 VA: 0x1815D2500
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D1A40 Offset: 0x15D0440 VA: 0x1815D1A40
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15D22F0 Offset: 0x15D0CF0 VA: 0x1815D22F0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E3320 Offset: 0x15E1D20 VA: 0x1815E3320
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E3120 Offset: 0x15E1B20 VA: 0x1815E3120
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E2B30 Offset: 0x15E1530 VA: 0x1815E2B30
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E2920 Offset: 0x15E1320 VA: 0x1815E2920
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E2D30 Offset: 0x15E1730 VA: 0x1815E2D30
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E2720 Offset: 0x15E1120 VA: 0x1815E2720
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15E2F40 Offset: 0x15E1940 VA: 0x1815E2F40
	|-Dictionary<Scene, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6A50 Offset: 0x15F5450 VA: 0x1815F6A50
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6290 Offset: 0x15F4C90 VA: 0x1815F6290
	|-Dictionary<ushort, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6480 Offset: 0x15F4E80 VA: 0x1815F6480
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6860 Offset: 0x15F5260 VA: 0x1815F6860
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6C30 Offset: 0x15F5630 VA: 0x1815F6C30
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6670 Offset: 0x15F5070 VA: 0x1815F6670
	|-Dictionary<uint, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x15F6090 Offset: 0x15F4A90 VA: 0x1815F6090
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1608C90 Offset: 0x1607690 VA: 0x181608C90
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x16086B0 Offset: 0x16070B0 VA: 0x1816086B0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1608E90 Offset: 0x1607890 VA: 0x181608E90
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1608AA0 Offset: 0x16074A0 VA: 0x181608AA0
	|-Dictionary<uint, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x16088B0 Offset: 0x16072B0 VA: 0x1816088B0
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1609090 Offset: 0x1607A90 VA: 0x181609090
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x16084C0 Offset: 0x1606EC0 VA: 0x1816084C0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161F270 Offset: 0x161DC70 VA: 0x18161F270
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161F690 Offset: 0x161E090 VA: 0x18161F690
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161EE40 Offset: 0x161D840 VA: 0x18161EE40
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161F480 Offset: 0x161DE80 VA: 0x18161F480
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161F060 Offset: 0x161DA60 VA: 0x18161F060
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161E980 Offset: 0x161D380 VA: 0x18161E980
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x161EC30 Offset: 0x161D630 VA: 0x18161EC30
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x162D170 Offset: 0x162BB70 VA: 0x18162D170
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x162D370 Offset: 0x162BD70 VA: 0x18162D370
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x162CF70 Offset: 0x162B970 VA: 0x18162CF70
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x162D570 Offset: 0x162BF70 VA: 0x18162D570
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F0450 Offset: 0x14EEE50 VA: 0x1814F0450
	|-Dictionary<KeyValuePair<object, object>, object>.IsCompatibleKey
	|-Dictionary<StructMultiKey<object, object>, object>.IsCompatibleKey
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.IsCompatibleKey
	|-Dictionary<ValueTuple<object, int>, object>.IsCompatibleKey
	|-Dictionary<ValueTuple<object, object>, object>.IsCompatibleKey
	|-Dictionary<Bounds, object>.IsCompatibleKey
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.IsCompatibleKey
	|-Dictionary<CSteamID, int>.IsCompatibleKey
	|-Dictionary<FullRank, object>.IsCompatibleKey
	|-Dictionary<Guid, object>.IsCompatibleKey
	|-Dictionary<HSteamNetConnection, int>.IsCompatibleKey
	|-Dictionary<Hash128, int>.IsCompatibleKey
	|-Dictionary<Hash128, object>.IsCompatibleKey
	|-Dictionary<Int2, int>.IsCompatibleKey
	|-Dictionary<Int2, object>.IsCompatibleKey
	|-Dictionary<Int3, int>.IsCompatibleKey
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.IsCompatibleKey
	|-Dictionary<int, TreeViewItemData<object>>.IsCompatibleKey
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.IsCompatibleKey
	|-Dictionary<int, bool>.IsCompatibleKey
	|-Dictionary<int, ByteEnum>.IsCompatibleKey
	|-Dictionary<int, CSteamID>.IsCompatibleKey
	|-Dictionary<int, HSteamNetConnection>.IsCompatibleKey
	|-Dictionary<int, short>.IsCompatibleKey
	|-Dictionary<int, Int3>.IsCompatibleKey
	|-Dictionary<int, int>.IsCompatibleKey
	|-Dictionary<int, Int32Enum>.IsCompatibleKey
	|-Dictionary<int, long>.IsCompatibleKey
	|-Dictionary<int, object>.IsCompatibleKey
	|-Dictionary<int, RenderInstancedDataLayout>.IsCompatibleKey
	|-Dictionary<int, float>.IsCompatibleKey
	|-Dictionary<int, TreeItem>.IsCompatibleKey
	|-Dictionary<int, uint>.IsCompatibleKey
	|-Dictionary<int, ulong>.IsCompatibleKey
	|-Dictionary<int, Vector2Int>.IsCompatibleKey
	|-Dictionary<int, Vector3>.IsCompatibleKey
	|-Dictionary<int, Vector4>.IsCompatibleKey
	|-Dictionary<int, Multipass.TransportIdData>.IsCompatibleKey
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.IsCompatibleKey
	|-Dictionary<int, NetworkAnimator.StateChange>.IsCompatibleKey
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.IsCompatibleKey
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.IsCompatibleKey
	|-Dictionary<int, TextResourceManager.FontAssetRef>.IsCompatibleKey
	|-Dictionary<Int32Enum, bool>.IsCompatibleKey
	|-Dictionary<Int32Enum, int>.IsCompatibleKey
	|-Dictionary<Int32Enum, Int32Enum>.IsCompatibleKey
	|-Dictionary<Int32Enum, object>.IsCompatibleKey
	|-Dictionary<long, ComputedStyle>.IsCompatibleKey
	|-Dictionary<long, object>.IsCompatibleKey
	|-Dictionary<IntPtr, object>.IsCompatibleKey
	|-Dictionary<InternedString, InternedString>.IsCompatibleKey
	|-Dictionary<InternedString, object>.IsCompatibleKey
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.IsCompatibleKey
	|-Dictionary<NativeAddr, object>.IsCompatibleKey
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.IsCompatibleKey
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.IsCompatibleKey
	|-Dictionary<object, bool>.IsCompatibleKey
	|-Dictionary<object, Bounds>.IsCompatibleKey
	|-Dictionary<object, Color>.IsCompatibleKey
	|-Dictionary<object, Color>.IsCompatibleKey
	|-Dictionary<object, Color32>.IsCompatibleKey
	|-Dictionary<object, double>.IsCompatibleKey
	|-Dictionary<object, int>.IsCompatibleKey
	|-Dictionary<object, Int32Enum>.IsCompatibleKey
	|-Dictionary<object, long>.IsCompatibleKey
	|-Dictionary<object, object>.IsCompatibleKey
	|-Dictionary<object, Playable>.IsCompatibleKey
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.IsCompatibleKey
	|-Dictionary<object, RaycastHit>.IsCompatibleKey
	|-Dictionary<object, Rect>.IsCompatibleKey
	|-Dictionary<object, ResourceLocator>.IsCompatibleKey
	|-Dictionary<object, float>.IsCompatibleKey
	|-Dictionary<object, StylePropertyValue>.IsCompatibleKey
	|-Dictionary<object, TextureId>.IsCompatibleKey
	|-Dictionary<object, XPathNodeRef>.IsCompatibleKey
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.IsCompatibleKey
	|-Dictionary<object, InputControlLayout.ControlItem>.IsCompatibleKey
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.IsCompatibleKey
	|-Dictionary<object, JsonParser.JsonValue>.IsCompatibleKey
	|-Dictionary<object, LiquidVolume.MeshCache>.IsCompatibleKey
	|-Dictionary<object, ObjectPool.DelayedStoreData>.IsCompatibleKey
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.IsCompatibleKey
	|-Dictionary<object, SVGDocument.ClipData>.IsCompatibleKey
	|-Dictionary<object, SVGDocument.MaskData>.IsCompatibleKey
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.IsCompatibleKey
	|-Dictionary<object, SVGDocument.PatternData>.IsCompatibleKey
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.IsCompatibleKey
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.IsCompatibleKey
	|-Dictionary<Scene, object>.IsCompatibleKey
	|-Dictionary<TerrainTileCoord, object>.IsCompatibleKey
	|-Dictionary<ushort, object>.IsCompatibleKey
	|-Dictionary<ushort, RpcLink>.IsCompatibleKey
	|-Dictionary<ushort, ushort>.IsCompatibleKey
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.IsCompatibleKey
	|-Dictionary<uint, int>.IsCompatibleKey
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.IsCompatibleKey
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.IsCompatibleKey
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.IsCompatibleKey
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.IsCompatibleKey
	|-Dictionary<uint, object>.IsCompatibleKey
	|-Dictionary<uint, RpcLinkType>.IsCompatibleKey
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.IsCompatibleKey
	|-Dictionary<ulong, object>.IsCompatibleKey
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.IsCompatibleKey
	|-Dictionary<Vector2Int, object>.IsCompatibleKey
	|-Dictionary<Vector3, Vector3>.IsCompatibleKey
	|-Dictionary<Vector3Int, object>.IsCompatibleKey
	|-Dictionary<XPathNodeRef, XPathNodeRef>.IsCompatibleKey
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	|-Dictionary<Regex.CachedCodeEntryKey, object>.IsCompatibleKey
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.IsCompatibleKey
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.IsCompatibleKey
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.IsCompatibleKey
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F5DF0 Offset: 0x14F47F0 VA: 0x1814F5DF0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14F61F0 Offset: 0x14F4BF0 VA: 0x1814F61F0
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14F63F0 Offset: 0x14F4DF0 VA: 0x1814F63F0
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14F5FF0 Offset: 0x14F49F0 VA: 0x1814F5FF0
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14F6620 Offset: 0x14F5020 VA: 0x1814F6620
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15096C0 Offset: 0x15080C0 VA: 0x1815096C0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1509270 Offset: 0x1507C70 VA: 0x181509270
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1509080 Offset: 0x1507A80 VA: 0x181509080
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15098D0 Offset: 0x15082D0 VA: 0x1815098D0
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15094C0 Offset: 0x1507EC0 VA: 0x1815094C0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1508C90 Offset: 0x1507690 VA: 0x181508C90
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1508E80 Offset: 0x1507880 VA: 0x181508E80
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151D590 Offset: 0x151BF90 VA: 0x18151D590
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151D790 Offset: 0x151C190 VA: 0x18151D790
	|-Dictionary<Int2, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151E170 Offset: 0x151CB70 VA: 0x18151E170
	|-Dictionary<Int2, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151DF70 Offset: 0x151C970 VA: 0x18151DF70
	|-Dictionary<Int3, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151DB80 Offset: 0x151C580 VA: 0x18151DB80
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151D980 Offset: 0x151C380 VA: 0x18151D980
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x151DD70 Offset: 0x151C770 VA: 0x18151DD70
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152F960 Offset: 0x152E360 VA: 0x18152F960
	|-Dictionary<int, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152F390 Offset: 0x152DD90 VA: 0x18152F390
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152F770 Offset: 0x152E170 VA: 0x18152F770
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152F1A0 Offset: 0x152DBA0 VA: 0x18152F1A0
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152EFB0 Offset: 0x152D9B0 VA: 0x18152EFB0
	|-Dictionary<int, short>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152FB50 Offset: 0x152E550 VA: 0x18152FB50
	|-Dictionary<int, Int3>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x152F580 Offset: 0x152DF80 VA: 0x18152F580
	|-Dictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1540000 Offset: 0x153EA00 VA: 0x181540000
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x153FE10 Offset: 0x153E810 VA: 0x18153FE10
	|-Dictionary<int, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15403E0 Offset: 0x153EDE0 VA: 0x1815403E0
	|-Dictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15401F0 Offset: 0x153EBF0 VA: 0x1815401F0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15405D0 Offset: 0x153EFD0 VA: 0x1815405D0
	|-Dictionary<int, float>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x153FC20 Offset: 0x153E620 VA: 0x18153FC20
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x153FA30 Offset: 0x153E430 VA: 0x18153FA30
	|-Dictionary<int, uint>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15505B0 Offset: 0x154EFB0 VA: 0x1815505B0
	|-Dictionary<int, ulong>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15507A0 Offset: 0x154F1A0 VA: 0x1815507A0
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x154FFB0 Offset: 0x154E9B0 VA: 0x18154FFB0
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x154FDC0 Offset: 0x154E7C0 VA: 0x18154FDC0
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1550990 Offset: 0x154F390 VA: 0x181550990
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15501B0 Offset: 0x154EBB0 VA: 0x1815501B0
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15503B0 Offset: 0x154EDB0 VA: 0x1815503B0
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15616C0 Offset: 0x15600C0 VA: 0x1815616C0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15614C0 Offset: 0x155FEC0 VA: 0x1815614C0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1560EE0 Offset: 0x155F8E0 VA: 0x181560EE0
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1561B00 Offset: 0x1560500 VA: 0x181561B00
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15612D0 Offset: 0x155FCD0 VA: 0x1815612D0
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1561910 Offset: 0x1560310 VA: 0x181561910
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15610E0 Offset: 0x155FAE0 VA: 0x1815610E0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1575030 Offset: 0x1573A30 VA: 0x181575030
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1574840 Offset: 0x1573240 VA: 0x181574840
	|-Dictionary<long, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1574C40 Offset: 0x1573640 VA: 0x181574C40
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1575260 Offset: 0x1573C60 VA: 0x181575260
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1574E30 Offset: 0x1573830 VA: 0x181574E30
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1574A30 Offset: 0x1573430 VA: 0x181574A30
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1574630 Offset: 0x1573030 VA: 0x181574630
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159D6A0 Offset: 0x159C0A0 VA: 0x18159D6A0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159D080 Offset: 0x159BA80 VA: 0x18159D080
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159DAA0 Offset: 0x159C4A0 VA: 0x18159DAA0
	|-Dictionary<object, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159DC90 Offset: 0x159C690 VA: 0x18159DC90
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159D290 Offset: 0x159BC90 VA: 0x18159D290
	|-Dictionary<object, Color>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159D4A0 Offset: 0x159BEA0 VA: 0x18159D4A0
	|-Dictionary<object, Color>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x159D8A0 Offset: 0x159C2A0 VA: 0x18159D8A0
	|-Dictionary<object, Color32>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AEA10 Offset: 0x15AD410 VA: 0x1815AEA10
	|-Dictionary<object, double>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AF210 Offset: 0x15ADC10 VA: 0x1815AF210
	|-Dictionary<object, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AF5F0 Offset: 0x15ADFF0 VA: 0x1815AF5F0
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AEC00 Offset: 0x15AD600 VA: 0x1815AEC00
	|-Dictionary<object, long>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AF400 Offset: 0x15ADE00 VA: 0x1815AF400
	|-Dictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AF010 Offset: 0x15ADA10 VA: 0x1815AF010
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15AEDF0 Offset: 0x15AD7F0 VA: 0x1815AEDF0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BF650 Offset: 0x15BE050 VA: 0x1815BF650
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BF250 Offset: 0x15BDC50 VA: 0x1815BF250
	|-Dictionary<object, Rect>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BEE60 Offset: 0x15BD860 VA: 0x1815BEE60
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BF060 Offset: 0x15BDA60 VA: 0x1815BF060
	|-Dictionary<object, float>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BF450 Offset: 0x15BDE50 VA: 0x1815BF450
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BFA70 Offset: 0x15BE470 VA: 0x1815BFA70
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15BF870 Offset: 0x15BE270 VA: 0x1815BF870
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D02F0 Offset: 0x15CECF0 VA: 0x1815D02F0
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D0B00 Offset: 0x15CF500 VA: 0x1815D0B00
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D04F0 Offset: 0x15CEEF0 VA: 0x1815D04F0
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D0D60 Offset: 0x15CF760 VA: 0x1815D0D60
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D00E0 Offset: 0x15CEAE0 VA: 0x1815D00E0
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D06F0 Offset: 0x15CF0F0 VA: 0x1815D06F0
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15D08F0 Offset: 0x15CF2F0 VA: 0x1815D08F0
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1550 Offset: 0x15DFF50 VA: 0x1815E1550
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1750 Offset: 0x15E0150 VA: 0x1815E1750
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1350 Offset: 0x15DFD50 VA: 0x1815E1350
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1D30 Offset: 0x15E0730 VA: 0x1815E1D30
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1F40 Offset: 0x15E0940 VA: 0x1815E1F40
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1950 Offset: 0x15E0350 VA: 0x1815E1950
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15E1B50 Offset: 0x15E0550 VA: 0x1815E1B50
	|-Dictionary<Scene, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F4220 Offset: 0x15F2C20 VA: 0x1815F4220
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F4600 Offset: 0x15F3000 VA: 0x1815F4600
	|-Dictionary<ushort, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F4030 Offset: 0x15F2A30 VA: 0x1815F4030
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F3C50 Offset: 0x15F2650 VA: 0x1815F3C50
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F3A40 Offset: 0x15F2440 VA: 0x1815F3A40
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F3E40 Offset: 0x15F2840 VA: 0x1815F3E40
	|-Dictionary<uint, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15F4400 Offset: 0x15F2E00 VA: 0x1815F4400
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x16073A0 Offset: 0x1605DA0 VA: 0x1816073A0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x16075A0 Offset: 0x1605FA0 VA: 0x1816075A0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1606FB0 Offset: 0x16059B0 VA: 0x181606FB0
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1606DC0 Offset: 0x16057C0 VA: 0x181606DC0
	|-Dictionary<uint, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x16071B0 Offset: 0x1605BB0 VA: 0x1816071B0
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1606BD0 Offset: 0x16055D0 VA: 0x181606BD0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x16069E0 Offset: 0x16053E0 VA: 0x1816069E0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161C5F0 Offset: 0x161AFF0 VA: 0x18161C5F0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161CE40 Offset: 0x161B840 VA: 0x18161CE40
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161CA10 Offset: 0x161B410 VA: 0x18161CA10
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161C3E0 Offset: 0x161ADE0 VA: 0x18161C3E0
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161CC30 Offset: 0x161B630 VA: 0x18161CC30
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161C130 Offset: 0x161AB30 VA: 0x18161C130
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x161C800 Offset: 0x161B200 VA: 0x18161C800
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x162C0A0 Offset: 0x162AAA0 VA: 0x18162C0A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x162C4A0 Offset: 0x162AEA0 VA: 0x18162C4A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x162C2A0 Offset: 0x162ACA0 VA: 0x18162C2A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x162BEC0 Offset: 0x162A8C0 VA: 0x18162BEC0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F6CA0 Offset: 0x14F56A0 VA: 0x1814F6CA0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14F6940 Offset: 0x14F5340 VA: 0x1814F6940
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14F6820 Offset: 0x14F5220 VA: 0x1814F6820
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14F6B80 Offset: 0x14F5580 VA: 0x1814F6B80
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14F6A60 Offset: 0x14F5460 VA: 0x1814F6A60
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x150A030 Offset: 0x1508A30 VA: 0x18150A030
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1509AB0 Offset: 0x15084B0 VA: 0x181509AB0
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1509BE0 Offset: 0x15085E0 VA: 0x181509BE0
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1509E00 Offset: 0x1508800 VA: 0x181509E00
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1509F10 Offset: 0x1508910 VA: 0x181509F10
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1509CF0 Offset: 0x15086F0 VA: 0x181509CF0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x150A150 Offset: 0x1508B50 VA: 0x18150A150
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.Contains
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E7A0 Offset: 0x151D1A0 VA: 0x18151E7A0
	|-Dictionary<Int2, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E8B0 Offset: 0x151D2B0 VA: 0x18151E8B0
	|-Dictionary<Int2, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E460 Offset: 0x151CE60 VA: 0x18151E460
	|-Dictionary<Int3, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E690 Offset: 0x151D090 VA: 0x18151E690
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.Contains
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.Contains
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.Contains
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.Contains
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E350 Offset: 0x151CD50 VA: 0x18151E350
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.Contains
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x151E580 Offset: 0x151CF80 VA: 0x18151E580
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x152FD50 Offset: 0x152E750 VA: 0x18152FD50
	|-Dictionary<int, bool>.System.Collections.IDictionary.Contains
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.Contains
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.Contains
	|-Dictionary<int, short>.System.Collections.IDictionary.Contains
	|-Dictionary<int, int>.System.Collections.IDictionary.Contains
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Contains
	|-Dictionary<int, float>.System.Collections.IDictionary.Contains
	|-Dictionary<int, uint>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x152FE60 Offset: 0x152E860 VA: 0x18152FE60
	|-Dictionary<int, Int3>.System.Collections.IDictionary.Contains
	|-Dictionary<int, long>.System.Collections.IDictionary.Contains
	|-Dictionary<int, object>.System.Collections.IDictionary.Contains
	|-Dictionary<int, ulong>.System.Collections.IDictionary.Contains
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15408D0 Offset: 0x153F2D0 VA: 0x1815408D0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.Contains
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15407C0 Offset: 0x153F1C0 VA: 0x1815407C0
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1562020 Offset: 0x1560A20 VA: 0x181562020
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1561E00 Offset: 0x1560800 VA: 0x181561E00
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.Contains
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1561CF0 Offset: 0x15606F0 VA: 0x181561CF0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Contains
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Contains
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1561F10 Offset: 0x1560910 VA: 0x181561F10
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1575580 Offset: 0x1573F80 VA: 0x181575580
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1575470 Offset: 0x1573E70 VA: 0x181575470
	|-Dictionary<long, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15759F0 Offset: 0x15743F0 VA: 0x1815759F0
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15757B0 Offset: 0x15741B0 VA: 0x1815757B0
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.Contains
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1575690 Offset: 0x1574090 VA: 0x181575690
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15758D0 Offset: 0x15742D0 VA: 0x1815758D0
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x159DFB0 Offset: 0x159C9B0 VA: 0x18159DFB0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Color>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Rect>.System.Collections.IDictionary.Contains
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Contains
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.Contains
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x159E0C0 Offset: 0x159CAC0 VA: 0x18159E0C0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.Contains
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.Contains
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x159DEA0 Offset: 0x159C8A0 VA: 0x18159DEA0
	|-Dictionary<object, bool>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Color32>.System.Collections.IDictionary.Contains
	|-Dictionary<object, double>.System.Collections.IDictionary.Contains
	|-Dictionary<object, int>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Contains
	|-Dictionary<object, long>.System.Collections.IDictionary.Contains
	|-Dictionary<object, object>.System.Collections.IDictionary.Contains
	|-Dictionary<object, float>.System.Collections.IDictionary.Contains
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.Contains
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.Contains
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.Contains
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.Contains
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.Contains
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.Contains
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.Contains
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x159E1D0 Offset: 0x159CBD0 VA: 0x18159E1D0
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.Contains
	|-Dictionary<object, Color>.System.Collections.IDictionary.Contains
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.Contains
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15AF7E0 Offset: 0x15AE1E0 VA: 0x1815AF7E0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.Contains
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15D0F90 Offset: 0x15CF990 VA: 0x1815D0F90
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15D10A0 Offset: 0x15CFAA0 VA: 0x1815D10A0
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15E2150 Offset: 0x15E0B50 VA: 0x1815E2150
	|-Dictionary<Scene, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4900 Offset: 0x15F3300 VA: 0x1815F4900
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4C30 Offset: 0x15F3630 VA: 0x1815F4C30
	|-Dictionary<ushort, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4E50 Offset: 0x15F3850 VA: 0x1815F4E50
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4B20 Offset: 0x15F3520 VA: 0x1815F4B20
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4D40 Offset: 0x15F3740 VA: 0x1815F4D40
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F47F0 Offset: 0x15F31F0 VA: 0x1815F47F0
	|-Dictionary<uint, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15F4A10 Offset: 0x15F3410 VA: 0x1815F4A10
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Contains
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Contains
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Contains
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x16079C0 Offset: 0x16063C0 VA: 0x1816079C0
	|-Dictionary<uint, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x16077A0 Offset: 0x16061A0 VA: 0x1816077A0
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1607AD0 Offset: 0x16064D0 VA: 0x181607AD0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x16078B0 Offset: 0x16062B0 VA: 0x1816078B0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D5C0 Offset: 0x161BFC0 VA: 0x18161D5C0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D6D0 Offset: 0x161C0D0 VA: 0x18161D6D0
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D140 Offset: 0x161BB40 VA: 0x18161D140
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D020 Offset: 0x161BA20 VA: 0x18161D020
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D260 Offset: 0x161BC60 VA: 0x18161D260
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D380 Offset: 0x161BD80 VA: 0x18161D380
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x161D4A0 Offset: 0x161BEA0 VA: 0x18161D4A0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x162C6A0 Offset: 0x162B0A0 VA: 0x18162C6A0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.Contains
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.Contains
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x162C7C0 Offset: 0x162B1C0 VA: 0x18162C7C0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F6DC0 Offset: 0x14F57C0 VA: 0x1814F6DC0
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Guid, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Playable>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Rect>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x14F6E50 Offset: 0x14F5850 VA: 0x1814F6E50
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x150A3C0 Offset: 0x1508DC0 VA: 0x18150A3C0
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Color>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x150A270 Offset: 0x1508C70 VA: 0x18150A270
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x150A460 Offset: 0x1508E60 VA: 0x18150A460
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int2, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x150A4E0 Offset: 0x1508EE0 VA: 0x18150A4E0
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int2, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int3, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Int3>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, long>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, ulong>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<long, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, bool>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Color32>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, double>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, long>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, float>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Scene, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ushort, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ulong, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x150A340 Offset: 0x1508D40 VA: 0x18150A340
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, bool>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, short>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, float>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, uint>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x151E9C0 Offset: 0x151D3C0 VA: 0x18151E9C0
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15409E0 Offset: 0x153F3E0 VA: 0x1815409E0
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15621D0 Offset: 0x1560BD0 VA: 0x1815621D0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x1562130 Offset: 0x1560B30 VA: 0x181562130
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x1575B00 Offset: 0x1574500 VA: 0x181575B00
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15AF8F0 Offset: 0x15AE2F0 VA: 0x1815AF8F0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15D11B0 Offset: 0x15CFBB0 VA: 0x1815D11B0
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15F5020 Offset: 0x15F3A20 VA: 0x1815F5020
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15F4F60 Offset: 0x15F3960 VA: 0x1815F4F60
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.GetEnumerator
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x161D7E0 Offset: 0x161C1E0 VA: 0x18161D7E0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14F7240 Offset: 0x14F5C40 VA: 0x1814F7240
	|-Dictionary<KeyValuePair<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14F6F40 Offset: 0x14F5940 VA: 0x1814F6F40
	|-Dictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14F7040 Offset: 0x14F5A40 VA: 0x1814F7040
	|-Dictionary<ValueTuple<Int32Enum, object>, EnumData>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14F7140 Offset: 0x14F5B40 VA: 0x1814F7140
	|-Dictionary<ValueTuple<object, int>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14F7340 Offset: 0x14F5D40 VA: 0x1814F7340
	|-Dictionary<ValueTuple<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150A790 Offset: 0x1509190 VA: 0x18150A790
	|-Dictionary<Bounds, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150A670 Offset: 0x1509070 VA: 0x18150A670
	|-Dictionary<CGSpot, InputTransformSpots.TransformSpot>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150A570 Offset: 0x1508F70 VA: 0x18150A570
	|-Dictionary<CSteamID, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150A8A0 Offset: 0x15092A0 VA: 0x18150A8A0
	|-Dictionary<FullRank, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150ABA0 Offset: 0x15095A0 VA: 0x18150ABA0
	|-Dictionary<Guid, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150AAA0 Offset: 0x15094A0 VA: 0x18150AAA0
	|-Dictionary<HSteamNetConnection, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x150A9A0 Offset: 0x15093A0 VA: 0x18150A9A0
	|-Dictionary<Hash128, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151ED50 Offset: 0x151D750 VA: 0x18151ED50
	|-Dictionary<Hash128, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151EB50 Offset: 0x151D550 VA: 0x18151EB50
	|-Dictionary<Int2, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151EE50 Offset: 0x151D850 VA: 0x18151EE50
	|-Dictionary<Int2, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151EF50 Offset: 0x151D950 VA: 0x18151EF50
	|-Dictionary<Int3, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151F060 Offset: 0x151DA60 VA: 0x18151F060
	|-Dictionary<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IDictionary.Remove
	|-Dictionary<int, CSteamID>.System.Collections.IDictionary.Remove
	|-Dictionary<int, Vector2Int>.System.Collections.IDictionary.Remove
	|-Dictionary<int, Multipass.TransportIdData>.System.Collections.IDictionary.Remove
	|-Dictionary<int, NetworkAnimator.SmoothedFloat>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151EA50 Offset: 0x151D450 VA: 0x18151EA50
	|-Dictionary<int, TreeViewItemData<object>>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x151EC50 Offset: 0x151D650 VA: 0x18151EC50
	|-Dictionary<int, ValueTuple<Vector4, Vector2Int>>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x152FF70 Offset: 0x152E970 VA: 0x18152FF70
	|-Dictionary<int, bool>.System.Collections.IDictionary.Remove
	|-Dictionary<int, ByteEnum>.System.Collections.IDictionary.Remove
	|-Dictionary<int, HSteamNetConnection>.System.Collections.IDictionary.Remove
	|-Dictionary<int, short>.System.Collections.IDictionary.Remove
	|-Dictionary<int, int>.System.Collections.IDictionary.Remove
	|-Dictionary<int, Int32Enum>.System.Collections.IDictionary.Remove
	|-Dictionary<int, float>.System.Collections.IDictionary.Remove
	|-Dictionary<int, uint>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1530070 Offset: 0x152EA70 VA: 0x181530070
	|-Dictionary<int, Int3>.System.Collections.IDictionary.Remove
	|-Dictionary<int, long>.System.Collections.IDictionary.Remove
	|-Dictionary<int, ulong>.System.Collections.IDictionary.Remove
	|-Dictionary<int, Vector3>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1540B70 Offset: 0x153F570 VA: 0x181540B70
	|-Dictionary<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1540A70 Offset: 0x153F470 VA: 0x181540A70
	|-Dictionary<int, RenderInstancedDataLayout>.System.Collections.IDictionary.Remove
	|-Dictionary<int, Vector4>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1540C70 Offset: 0x153F670 VA: 0x181540C70
	|-Dictionary<int, TreeItem>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1550B80 Offset: 0x154F580 VA: 0x181550B80
	|-Dictionary<int, NetworkAnimator.StateChange>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15624D0 Offset: 0x1560ED0 VA: 0x1815624D0
	|-Dictionary<int, ReflectionProbeManager.CachedProbe>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15623D0 Offset: 0x1560DD0 VA: 0x1815623D0
	|-Dictionary<int, TMP_ResourceManager.FontAssetRef>.System.Collections.IDictionary.Remove
	|-Dictionary<int, TextResourceManager.FontAssetRef>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15622D0 Offset: 0x1560CD0 VA: 0x1815622D0
	|-Dictionary<Int32Enum, bool>.System.Collections.IDictionary.Remove
	|-Dictionary<Int32Enum, int>.System.Collections.IDictionary.Remove
	|-Dictionary<Int32Enum, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15625D0 Offset: 0x1560FD0 VA: 0x1815625D0
	|-Dictionary<Int32Enum, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15760F0 Offset: 0x1574AF0 VA: 0x1815760F0
	|-Dictionary<long, ComputedStyle>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1575DE0 Offset: 0x15747E0 VA: 0x181575DE0
	|-Dictionary<long, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1575CE0 Offset: 0x15746E0 VA: 0x181575CE0
	|-Dictionary<IntPtr, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1575FF0 Offset: 0x15749F0 VA: 0x181575FF0
	|-Dictionary<InternedString, InternedString>.System.Collections.IDictionary.Remove
	|-Dictionary<InternedString, InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1575BE0 Offset: 0x15745E0 VA: 0x181575BE0
	|-Dictionary<InternedString, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1575EE0 Offset: 0x15748E0 VA: 0x181575EE0
	|-Dictionary<NativeAddr, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E4E0 Offset: 0x159CEE0 VA: 0x18159E4E0
	|-Dictionary<object, KeyValuePair<Int32Enum, object>>.System.Collections.IDictionary.Remove
	|-Dictionary<object, ResourceLocator>.System.Collections.IDictionary.Remove
	|-Dictionary<object, StylePropertyValue>.System.Collections.IDictionary.Remove
	|-Dictionary<object, XPathNodeRef>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E6E0 Offset: 0x159D0E0 VA: 0x18159E6E0
	|-Dictionary<object, ValueTuple<Vector3, Quaternion>>.System.Collections.IDictionary.Remove
	|-Dictionary<object, SVGDocument.PatternData>.System.Collections.IDictionary.Remove
	|-Dictionary<object, SVGDocument.ViewBoxInfo>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E7E0 Offset: 0x159D1E0 VA: 0x18159E7E0
	|-Dictionary<object, bool>.System.Collections.IDictionary.Remove
	|-Dictionary<object, Color32>.System.Collections.IDictionary.Remove
	|-Dictionary<object, double>.System.Collections.IDictionary.Remove
	|-Dictionary<object, int>.System.Collections.IDictionary.Remove
	|-Dictionary<object, Int32Enum>.System.Collections.IDictionary.Remove
	|-Dictionary<object, long>.System.Collections.IDictionary.Remove
	|-Dictionary<object, float>.System.Collections.IDictionary.Remove
	|-Dictionary<object, TextureId>.System.Collections.IDictionary.Remove
	|-Dictionary<object, EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IDictionary.Remove
	|-Dictionary<object, InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IDictionary.Remove
	|-Dictionary<object, ObjectPool.DelayedStoreData>.System.Collections.IDictionary.Remove
	|-Dictionary<object, SVGDocument.ClipData>.System.Collections.IDictionary.Remove
	|-Dictionary<object, SVGDocument.MaskData>.System.Collections.IDictionary.Remove
	|-Dictionary<object, SVGDocument.NodeGlobalSceneState>.System.Collections.IDictionary.Remove
	|-Dictionary<object, StyleComplexSelector.PseudoStateData>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E3E0 Offset: 0x159CDE0 VA: 0x18159E3E0
	|-Dictionary<object, Bounds>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E5E0 Offset: 0x159CFE0 VA: 0x18159E5E0
	|-Dictionary<object, Color>.System.Collections.IDictionary.Remove
	|-Dictionary<object, LiquidVolume.MeshCache>.System.Collections.IDictionary.Remove
	|-Dictionary<object, ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x159E2E0 Offset: 0x159CCE0 VA: 0x18159E2E0
	|-Dictionary<object, Color>.System.Collections.IDictionary.Remove
	|-Dictionary<object, Playable>.System.Collections.IDictionary.Remove
	|-Dictionary<object, Rect>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15AF9A0 Offset: 0x15AE3A0 VA: 0x1815AF9A0
	|-Dictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15AFAA0 Offset: 0x15AE4A0 VA: 0x1815AFAA0
	|-Dictionary<object, ProbeVolumeBakingProcessSettings>.System.Collections.IDictionary.Remove
	|-Dictionary<object, RaycastHit>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15D12C0 Offset: 0x15CFCC0 VA: 0x1815D12C0
	|-Dictionary<object, InputControlLayout.ControlItem>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15D13C0 Offset: 0x15CFDC0 VA: 0x1815D13C0
	|-Dictionary<object, JsonParser.JsonValue>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15E2260 Offset: 0x15E0C60 VA: 0x1815E2260
	|-Dictionary<Scene, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F51A0 Offset: 0x15F3BA0 VA: 0x1815F51A0
	|-Dictionary<TerrainTileCoord, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F55A0 Offset: 0x15F3FA0 VA: 0x1815F55A0
	|-Dictionary<ushort, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F54A0 Offset: 0x15F3EA0 VA: 0x1815F54A0
	|-Dictionary<ushort, RpcLink>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F56A0 Offset: 0x15F40A0 VA: 0x1815F56A0
	|-Dictionary<ushort, ushort>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F53A0 Offset: 0x15F3DA0 VA: 0x1815F53A0
	|-Dictionary<uint, GlyphPairAdjustmentRecord>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F50A0 Offset: 0x15F3AA0 VA: 0x1815F50A0
	|-Dictionary<uint, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x15F52A0 Offset: 0x15F3CA0 VA: 0x1815F52A0
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Remove
	|-Dictionary<uint, MarkToBaseAdjustmentRecord>.System.Collections.IDictionary.Remove
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Remove
	|-Dictionary<uint, MarkToMarkAdjustmentRecord>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1607BE0 Offset: 0x16065E0 VA: 0x181607BE0
	|-Dictionary<uint, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1607EE0 Offset: 0x16068E0 VA: 0x181607EE0
	|-Dictionary<uint, RpcLinkType>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1607DE0 Offset: 0x16067E0 VA: 0x181607DE0
	|-Dictionary<uint, NetworkBehaviour.BufferedRpc>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1607CE0 Offset: 0x16066E0 VA: 0x181607CE0
	|-Dictionary<ulong, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161DAC0 Offset: 0x161C4C0 VA: 0x18161DAC0
	|-Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161DDD0 Offset: 0x161C7D0 VA: 0x18161DDD0
	|-Dictionary<Vector2Int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161D8A0 Offset: 0x161C2A0 VA: 0x18161D8A0
	|-Dictionary<Vector3, Vector3>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161DBC0 Offset: 0x161C5C0 VA: 0x18161DBC0
	|-Dictionary<Vector3Int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161DCD0 Offset: 0x161C6D0 VA: 0x18161DCD0
	|-Dictionary<XPathNodeRef, XPathNodeRef>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161DED0 Offset: 0x161C8D0 VA: 0x18161DED0
	|-Dictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x161D9B0 Offset: 0x161C3B0 VA: 0x18161D9B0
	|-Dictionary<Regex.CachedCodeEntryKey, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x162C9D0 Offset: 0x162B3D0 VA: 0x18162C9D0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int>.System.Collections.IDictionary.Remove
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x162C8D0 Offset: 0x162B2D0 VA: 0x18162C8D0
	|-Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x162CAD0 Offset: 0x162B4D0 VA: 0x18162CAD0
	|-Dictionary<StyleSheetCache.SheetHandleKey, object>.System.Collections.IDictionary.Remove
	*/
}
