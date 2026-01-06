public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> // TypeDefIndex: 5013
{
	// Fields
	private static EqualityComparer<T> defaultComparer; // 0x0

	// Properties
	public static EqualityComparer<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16C6C20 Offset: 0x16C5620 VA: 0x1816C6C20
	|-EqualityComparer<ArraySegment<byte>>.get_Default
	|
	|-RVA: 0x16C77D0 Offset: 0x16C61D0 VA: 0x1816C77D0
	|-EqualityComparer<SyncList.CachedOnChange<int>>.get_Default
	|
	|-RVA: 0x16C79F0 Offset: 0x16C63F0 VA: 0x1816C79F0
	|-EqualityComparer<SyncList.ChangeData<int>>.get_Default
	|
	|-RVA: 0x16C75B0 Offset: 0x16C5FB0 VA: 0x1816C75B0
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.get_Default
	|
	|-RVA: 0x16C6180 Offset: 0x16C4B80 VA: 0x1816C6180
	|-EqualityComparer<IntervalTree.Entry<object>>.get_Default
	|
	|-RVA: 0x16C7170 Offset: 0x16C5B70 VA: 0x1816C7170
	|-EqualityComparer<KeyValuePair<int, int>>.get_Default
	|
	|-RVA: 0x16C7E30 Offset: 0x16C6830 VA: 0x1816C7E30
	|-EqualityComparer<KeyValuePair<int, object>>.get_Default
	|
	|-RVA: 0x16C6B10 Offset: 0x16C5510 VA: 0x1816C6B10
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x16C67E0 Offset: 0x16C51E0 VA: 0x1816C67E0
	|-EqualityComparer<KeyValuePair<object, bool>>.get_Default
	|
	|-RVA: 0x16C5D40 Offset: 0x16C4740 VA: 0x1816C5D40
	|-EqualityComparer<KeyValuePair<object, char>>.get_Default
	|
	|-RVA: 0x16C7B00 Offset: 0x16C6500 VA: 0x1816C7B00
	|-EqualityComparer<KeyValuePair<object, object>>.get_Default
	|
	|-RVA: 0x16C78E0 Offset: 0x16C62E0 VA: 0x1816C78E0
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.get_Default
	|
	|-RVA: 0x16C7390 Offset: 0x16C5D90 VA: 0x1816C7390
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.get_Default
	|
	|-RVA: 0x16C5E50 Offset: 0x16C4850 VA: 0x1816C5E50
	|-EqualityComparer<KeyValuePair<Rect, object>>.get_Default
	|
	|-RVA: 0x16C6F50 Offset: 0x16C5950 VA: 0x1816C6F50
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.get_Default
	|
	|-RVA: 0x16C7C10 Offset: 0x16C6610 VA: 0x1816C7C10
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.get_Default
	|
	|-RVA: 0x16C6070 Offset: 0x16C4A70 VA: 0x1816C6070
	|-EqualityComparer<NativeArray<NudgeJobData>>.get_Default
	|
	|-RVA: 0x16C63A0 Offset: 0x16C4DA0 VA: 0x1816C63A0
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.get_Default
	|
	|-RVA: 0x16C68F0 Offset: 0x16C52F0 VA: 0x1816C68F0
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.get_Default
	|
	|-RVA: 0x16C64B0 Offset: 0x16C4EB0 VA: 0x1816C64B0
	|-EqualityComparer<NativeSlice<NudgeJobData>>.get_Default
	|
	|-RVA: 0x16C7D20 Offset: 0x16C6720 VA: 0x1816C7D20
	|-EqualityComparer<Nullable<DateTime>>.get_Default
	|
	|-RVA: 0x16C5F60 Offset: 0x16C4960 VA: 0x1816C5F60
	|-EqualityComparer<Nullable<Decimal>>.get_Default
	|
	|-RVA: 0x16C7280 Offset: 0x16C5C80 VA: 0x1816C7280
	|-EqualityComparer<TempAllocator.Page<ushort>>.get_Default
	|
	|-RVA: 0x16C6D30 Offset: 0x16C5730 VA: 0x1816C6D30
	|-EqualityComparer<TempAllocator.Page<Vertex>>.get_Default
	|
	|-RVA: 0x16C6A00 Offset: 0x16C5400 VA: 0x1816C6A00
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Default
	|
	|-RVA: 0x16C66D0 Offset: 0x16C50D0 VA: 0x1816C66D0
	|-EqualityComparer<StructMultiKey<object, object>>.get_Default
	|
	|-RVA: 0x16C74A0 Offset: 0x16C5EA0 VA: 0x1816C74A0
	|-EqualityComparer<SubArray<int>>.get_Default
	|
	|-RVA: 0x16C6290 Offset: 0x16C4C90 VA: 0x1816C6290
	|-EqualityComparer<TreeViewItemData<object>>.get_Default
	|
	|-RVA: 0x16C76C0 Offset: 0x16C60C0 VA: 0x1816C76C0
	|-EqualityComparer<ValueTuple<bool>>.get_Default
	|
	|-RVA: 0x16C7060 Offset: 0x16C5A60 VA: 0x1816C7060
	|-EqualityComparer<ValueTuple<int, int>>.get_Default
	|
	|-RVA: 0x16C65C0 Offset: 0x16C4FC0 VA: 0x1816C65C0
	|-EqualityComparer<ValueTuple<int, object>>.get_Default
	|
	|-RVA: 0x16C6E40 Offset: 0x16C5840 VA: 0x1816C6E40
	|-EqualityComparer<ValueTuple<int, Scene>>.get_Default
	|
	|-RVA: 0x16EC140 Offset: 0x16EAB40 VA: 0x1816EC140
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.get_Default
	|
	|-RVA: 0x16ED460 Offset: 0x16EBE60 VA: 0x1816ED460
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.get_Default
	|
	|-RVA: 0x16EB260 Offset: 0x16E9C60 VA: 0x1816EB260
	|-EqualityComparer<ValueTuple<IntPtr, object>>.get_Default
	|
	|-RVA: 0x16EDAC0 Offset: 0x16EC4C0 VA: 0x1816EDAC0
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.get_Default
	|
	|-RVA: 0x16EC250 Offset: 0x16EAC50 VA: 0x1816EC250
	|-EqualityComparer<ValueTuple<object, int>>.get_Default
	|
	|-RVA: 0x16EBAE0 Offset: 0x16EA4E0 VA: 0x1816EBAE0
	|-EqualityComparer<ValueTuple<object, object>>.get_Default
	|
	|-RVA: 0x16EB7B0 Offset: 0x16EA1B0 VA: 0x1816EB7B0
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.get_Default
	|
	|-RVA: 0x16ED130 Offset: 0x16EBB30 VA: 0x1816ED130
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.get_Default
	|
	|-RVA: 0x16EB040 Offset: 0x16E9A40 VA: 0x1816EB040
	|-EqualityComparer<ValueTuple<object, object, object>>.get_Default
	|
	|-RVA: 0x16ED020 Offset: 0x16EBA20 VA: 0x1816ED020
	|-EqualityComparer<AnimatorClipInfo>.get_Default
	|
	|-RVA: 0x16EB9D0 Offset: 0x16EA3D0 VA: 0x1816EB9D0
	|-EqualityComparer<AsyncGPUReadbackRequest>.get_Default
	|
	|-RVA: 0x16EC470 Offset: 0x16EAE70 VA: 0x1816EC470
	|-EqualityComparer<Background>.get_Default
	|
	|-RVA: 0x16ED240 Offset: 0x16EBC40 VA: 0x1816ED240
	|-EqualityComparer<BackgroundPosition>.get_Default
	|
	|-RVA: 0x16EBBF0 Offset: 0x16EA5F0 VA: 0x1816EBBF0
	|-EqualityComparer<BackgroundRepeat>.get_Default
	|
	|-RVA: 0x16EDBD0 Offset: 0x16EC5D0 VA: 0x1816EDBD0
	|-EqualityComparer<BezierContour>.get_Default
	|
	|-RVA: 0x16EDDF0 Offset: 0x16EC7F0 VA: 0x1816EDDF0
	|-EqualityComparer<BezierPathSegment>.get_Default
	|
	|-RVA: 0x16EC9C0 Offset: 0x16EB3C0 VA: 0x1816EC9C0
	|-EqualityComparer<BezierSegment>.get_Default
	|
	|-RVA: 0x16ED790 Offset: 0x16EC190 VA: 0x1816ED790
	|-EqualityComparer<bool>.get_Default
	|
	|-RVA: 0x16ED8A0 Offset: 0x16EC2A0 VA: 0x1816ED8A0
	|-EqualityComparer<Bounds>.get_Default
	|
	|-RVA: 0x16EB590 Offset: 0x16E9F90 VA: 0x1816EB590
	|-EqualityComparer<BoundsInt>.get_Default
	|
	|-RVA: 0x16EBE10 Offset: 0x16EA810 VA: 0x1816EBE10
	|-EqualityComparer<byte>.get_Default
	|
	|-RVA: 0x16ED9B0 Offset: 0x16EC3B0 VA: 0x1816ED9B0
	|-EqualityComparer<ByteEnum>.get_Default
	|
	|-RVA: 0x16EAF30 Offset: 0x16E9930 VA: 0x1816EAF30
	|-EqualityComparer<CGSpot>.get_Default
	|
	|-RVA: 0x16EB8C0 Offset: 0x16EA2C0 VA: 0x1816EB8C0
	|-EqualityComparer<CSteamID>.get_Default
	|
	|-RVA: 0x16EB370 Offset: 0x16E9D70 VA: 0x1816EB370
	|-EqualityComparer<char>.get_Default
	|
	|-RVA: 0x16ECBE0 Offset: 0x16EB5E0 VA: 0x1816ECBE0
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x16ECAD0 Offset: 0x16EB4D0 VA: 0x1816ECAD0
	|-EqualityComparer<Color>.get_Default
	|
	|-RVA: 0x16EC690 Offset: 0x16EB090 VA: 0x1816EC690
	|-EqualityComparer<Color32>.get_Default
	|
	|-RVA: 0x16EBF20 Offset: 0x16EA920 VA: 0x1816EBF20
	|-EqualityComparer<ColorBlock>.get_Default
	|
	|-RVA: 0x16ECCF0 Offset: 0x16EB6F0 VA: 0x1816ECCF0
	|-EqualityComparer<CombineInstance>.get_Default
	|
	|-RVA: 0x16ED570 Offset: 0x16EBF70 VA: 0x1816ED570
	|-EqualityComparer<ComputedStyle>.get_Default
	|
	|-RVA: 0x16EB480 Offset: 0x16E9E80 VA: 0x1816EB480
	|-EqualityComparer<ComputedTransitionProperty>.get_Default
	|
	|-RVA: 0x16EBD00 Offset: 0x16EA700 VA: 0x1816EBD00
	|-EqualityComparer<Connection>.get_Default
	|
	|-RVA: 0x16EB6A0 Offset: 0x16EA0A0 VA: 0x1816EB6A0
	|-EqualityComparer<ContourVertex>.get_Default
	|
	|-RVA: 0x16ED680 Offset: 0x16EC080 VA: 0x1816ED680
	|-EqualityComparer<ControlPointOption>.get_Default
	|
	|-RVA: 0x16EC7A0 Offset: 0x16EB1A0 VA: 0x1816EC7A0
	|-EqualityComparer<CoordinateFootprintTilePair>.get_Default
	|
	|-RVA: 0x16ECF10 Offset: 0x16EB910 VA: 0x1816ECF10
	|-EqualityComparer<CoordinateProceduralTilePair>.get_Default
	|
	|-RVA: 0x16EC030 Offset: 0x16EAA30 VA: 0x1816EC030
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.get_Default
	|
	|-RVA: 0x16ECE00 Offset: 0x16EB800 VA: 0x1816ECE00
	|-EqualityComparer<CoordinateStorageTilePair>.get_Default
	|
	|-RVA: 0x16EC8B0 Offset: 0x16EB2B0 VA: 0x1816EC8B0
	|-EqualityComparer<CoordinateTilePair>.get_Default
	|
	|-RVA: 0x16EDCE0 Offset: 0x16EC6E0 VA: 0x1816EDCE0
	|-EqualityComparer<DateTime>.get_Default
	|
	|-RVA: 0x16EC580 Offset: 0x16EAF80 VA: 0x1816EC580
	|-EqualityComparer<DateTimeOffset>.get_Default
	|
	|-RVA: 0x16EDF00 Offset: 0x16EC900 VA: 0x1816EDF00
	|-EqualityComparer<Decimal>.get_Default
	|
	|-RVA: 0x16EC360 Offset: 0x16EAD60 VA: 0x1816EC360
	|-EqualityComparer<DisplayInfo>.get_Default
	|
	|-RVA: 0x16EB150 Offset: 0x16E9B50 VA: 0x1816EB150
	|-EqualityComparer<double>.get_Default
	|
	|-RVA: 0x16ED350 Offset: 0x16EBD50 VA: 0x1816ED350
	|-EqualityComparer<DoublePoint>.get_Default
	|
	|-RVA: 0x1710BF0 Offset: 0x170F5F0 VA: 0x181710BF0
	|-EqualityComparer<DoublePoint>.get_Default
	|
	|-RVA: 0x170EF40 Offset: 0x170D940 VA: 0x18170EF40
	|-EqualityComparer<DualPrefab>.get_Default
	|
	|-RVA: 0x17109D0 Offset: 0x170F3D0 VA: 0x1817109D0
	|-EqualityComparer<DuplicateSamplePoint>.get_Default
	|
	|-RVA: 0x1710E10 Offset: 0x170F810 VA: 0x181710E10
	|-EqualityComparer<EasingFunction>.get_Default
	|
	|-RVA: 0x170FAF0 Offset: 0x170E4F0 VA: 0x18170FAF0
	|-EqualityComparer<Entry>.get_Default
	|
	|-RVA: 0x1710480 Offset: 0x170EE80 VA: 0x181710480
	|-EqualityComparer<EnumData>.get_Default
	|
	|-RVA: 0x170F7C0 Offset: 0x170E1C0 VA: 0x18170F7C0
	|-EqualityComparer<EventSummary>.get_Default
	|
	|-RVA: 0x1711580 Offset: 0x170FF80 VA: 0x181711580
	|-EqualityComparer<FontDefinition>.get_Default
	|
	|-RVA: 0x17117A0 Offset: 0x17101A0 VA: 0x1817117A0
	|-EqualityComparer<FrameTimeSample>.get_Default
	|
	|-RVA: 0x170F050 Offset: 0x170DA50 VA: 0x18170F050
	|-EqualityComparer<FullRank>.get_Default
	|
	|-RVA: 0x170EE30 Offset: 0x170D830 VA: 0x18170EE30
	|-EqualityComparer<GCHandle>.get_Default
	|
	|-RVA: 0x1711030 Offset: 0x170FA30 VA: 0x181711030
	|-EqualityComparer<GlyphPairAdjustmentRecord>.get_Default
	|
	|-RVA: 0x17107B0 Offset: 0x170F1B0 VA: 0x1817107B0
	|-EqualityComparer<GlyphRect>.get_Default
	|
	|-RVA: 0x170F9E0 Offset: 0x170E3E0 VA: 0x18170F9E0
	|-EqualityComparer<Guid>.get_Default
	|
	|-RVA: 0x17119C0 Offset: 0x17103C0 VA: 0x1817119C0
	|-EqualityComparer<HSteamNetConnection>.get_Default
	|
	|-RVA: 0x170EC10 Offset: 0x170D610 VA: 0x18170EC10
	|-EqualityComparer<Hash128>.get_Default
	|
	|-RVA: 0x17106A0 Offset: 0x170F0A0 VA: 0x1817106A0
	|-EqualityComparer<InputBinding>.get_Default
	|
	|-RVA: 0x1711360 Offset: 0x170FD60 VA: 0x181711360
	|-EqualityComparer<InputDeviceDescription>.get_Default
	|
	|-RVA: 0x170F5A0 Offset: 0x170DFA0 VA: 0x18170F5A0
	|-EqualityComparer<InputEventPtr>.get_Default
	|
	|-RVA: 0x1710260 Offset: 0x170EC60 VA: 0x181710260
	|-EqualityComparer<short>.get_Default
	|
	|-RVA: 0x1710D00 Offset: 0x170F700 VA: 0x181710D00
	|-EqualityComparer<Int2>.get_Default
	|
	|-RVA: 0x1710040 Offset: 0x170EA40 VA: 0x181710040
	|-EqualityComparer<Int3>.get_Default
	|
	|-RVA: 0x17118B0 Offset: 0x17102B0 VA: 0x1817118B0
	|-EqualityComparer<int>.get_Default
	|
	|-RVA: 0x1710F20 Offset: 0x170F920 VA: 0x181710F20
	|-EqualityComparer<Int32Enum>.get_Default
	|
	|-RVA: 0x170FF30 Offset: 0x170E930 VA: 0x18170FF30
	|-EqualityComparer<long>.get_Default
	|
	|-RVA: 0x170F6B0 Offset: 0x170E0B0 VA: 0x18170F6B0
	|-EqualityComparer<IntPoint>.get_Default
	|
	|-RVA: 0x170E9F0 Offset: 0x170D3F0 VA: 0x18170E9F0
	|-EqualityComparer<IntPoint>.get_Default
	|
	|-RVA: 0x170FD10 Offset: 0x170E710 VA: 0x18170FD10
	|-EqualityComparer<IntPtr>.get_Default
	|
	|-RVA: 0x170F490 Offset: 0x170DE90 VA: 0x18170F490
	|-EqualityComparer<IntRect>.get_Default
	|
	|-RVA: 0x17108C0 Offset: 0x170F2C0 VA: 0x1817108C0
	|-EqualityComparer<IntRegion>.get_Default
	|
	|-RVA: 0x170F380 Offset: 0x170DD80 VA: 0x18170F380
	|-EqualityComparer<InternedString>.get_Default
	|
	|-RVA: 0x170EB00 Offset: 0x170D500 VA: 0x18170EB00
	|-EqualityComparer<InterpretedFrameInfo>.get_Default
	|
	|-RVA: 0x170FE20 Offset: 0x170E820 VA: 0x18170FE20
	|-EqualityComparer<IntervalTreeNode>.get_Default
	|
	|-RVA: 0x170F160 Offset: 0x170DB60 VA: 0x18170F160
	|-EqualityComparer<JsonPosition>.get_Default
	|
	|-RVA: 0x170FC00 Offset: 0x170E600 VA: 0x18170FC00
	|-EqualityComparer<Label>.get_Default
	|
	|-RVA: 0x1710150 Offset: 0x170EB50 VA: 0x181710150
	|-EqualityComparer<LayerMask>.get_Default
	|
	|-RVA: 0x1711470 Offset: 0x170FE70 VA: 0x181711470
	|-EqualityComparer<LigatureSubstitutionRecord>.get_Default
	|
	|-RVA: 0x170ED20 Offset: 0x170D720 VA: 0x18170ED20
	|-EqualityComparer<LigatureSubstitutionRecord>.get_Default
	|
	|-RVA: 0x1710370 Offset: 0x170ED70 VA: 0x181710370
	|-EqualityComparer<LocalPacket>.get_Default
	|
	|-RVA: 0x170F8D0 Offset: 0x170E2D0 VA: 0x18170F8D0
	|-EqualityComparer<LocalPacket>.get_Default
	|
	|-RVA: 0x1710590 Offset: 0x170EF90 VA: 0x181710590
	|-EqualityComparer<ManipulatorActivationFilter>.get_Default
	|
	|-RVA: 0x1711690 Offset: 0x1710090 VA: 0x181711690
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.get_Default
	|
	|-RVA: 0x1711140 Offset: 0x170FB40 VA: 0x181711140
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.get_Default
	|
	|-RVA: 0x1710AE0 Offset: 0x170F4E0 VA: 0x181710AE0
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.get_Default
	|
	|-RVA: 0x1711250 Offset: 0x170FC50 VA: 0x181711250
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.get_Default
	|
	|-RVA: 0x170F270 Offset: 0x170DC70 VA: 0x18170F270
	|-EqualityComparer<Matrix4x4>.get_Default
	|
	|-RVA: 0x17334E0 Offset: 0x1731EE0 VA: 0x1817334E0
	|-EqualityComparer<MultipleSubstitutionRecord>.get_Default
	|
	|-RVA: 0x1733B40 Offset: 0x1732540 VA: 0x181733B40
	|-EqualityComparer<MultipleSubstitutionRecord>.get_Default
	|
	|-RVA: 0x1732930 Offset: 0x1731330 VA: 0x181732930
	|-EqualityComparer<NameAndParameters>.get_Default
	|
	|-RVA: 0x17342B0 Offset: 0x1732CB0 VA: 0x1817342B0
	|-EqualityComparer<NamedValue>.get_Default
	|
	|-RVA: 0x1734910 Offset: 0x1733310 VA: 0x181734910
	|-EqualityComparer<NativeAddr>.get_Default
	|
	|-RVA: 0x1733D60 Offset: 0x1732760 VA: 0x181733D60
	|-EqualityComparer<NavMeshBuildMarkup>.get_Default
	|
	|-RVA: 0x1732D70 Offset: 0x1731770 VA: 0x181732D70
	|-EqualityComparer<NavMeshBuildSource>.get_Default
	|
	|-RVA: 0x1734C40 Offset: 0x1733640 VA: 0x181734C40
	|-EqualityComparer<Navigation>.get_Default
	|
	|-RVA: 0xD749C0 Offset: 0xD733C0 VA: 0x180D749C0
	|-EqualityComparer<object>.get_Default
	|
	|-RVA: 0x1735080 Offset: 0x1733A80 VA: 0x181735080
	|-EqualityComparer<Packet>.get_Default
	|
	|-RVA: 0x1732600 Offset: 0x1731000 VA: 0x181732600
	|-EqualityComparer<Playable>.get_Default
	|
	|-RVA: 0x1733F80 Offset: 0x1732980 VA: 0x181733F80
	|-EqualityComparer<PlayableBinding>.get_Default
	|
	|-RVA: 0x1732B50 Offset: 0x1731550 VA: 0x181732B50
	|-EqualityComparer<PlayerLoopSystem>.get_Default
	|
	|-RVA: 0x1734800 Offset: 0x1733200 VA: 0x181734800
	|-EqualityComparer<PlayerLoopSystemInternal>.get_Default
	|
	|-RVA: 0x1733920 Offset: 0x1732320 VA: 0x181733920
	|-EqualityComparer<PointerModel>.get_Default
	|
	|-RVA: 0x1732C60 Offset: 0x1731660 VA: 0x181732C60
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.get_Default
	|
	|-RVA: 0x1732820 Offset: 0x1731220 VA: 0x181732820
	|-EqualityComparer<Quaternion>.get_Default
	|
	|-RVA: 0x17345E0 Offset: 0x1732FE0 VA: 0x1817345E0
	|-EqualityComparer<RangePositionInfo>.get_Default
	|
	|-RVA: 0x1734A20 Offset: 0x1733420 VA: 0x181734A20
	|-EqualityComparer<RaycastHit>.get_Default
	|
	|-RVA: 0x17353B0 Offset: 0x1733DB0 VA: 0x1817353B0
	|-EqualityComparer<RaycastHit2D>.get_Default
	|
	|-RVA: 0x17333D0 Offset: 0x1731DD0 VA: 0x1817333D0
	|-EqualityComparer<RaycastResult>.get_Default
	|
	|-RVA: 0x1732710 Offset: 0x1731110 VA: 0x181732710
	|-EqualityComparer<Rect>.get_Default
	|
	|-RVA: 0x1735190 Offset: 0x1733B90 VA: 0x181735190
	|-EqualityComparer<RectInt>.get_Default
	|
	|-RVA: 0x1733C50 Offset: 0x1732650 VA: 0x181733C50
	|-EqualityComparer<RenderInstancedDataLayout>.get_Default
	|
	|-RVA: 0x17332C0 Offset: 0x1731CC0 VA: 0x1817332C0
	|-EqualityComparer<RenderTargetIdentifier>.get_Default
	|
	|-RVA: 0x17343C0 Offset: 0x1732DC0 VA: 0x1817343C0
	|-EqualityComparer<RendererList>.get_Default
	|
	|-RVA: 0x1734B30 Offset: 0x1733530 VA: 0x181734B30
	|-EqualityComparer<RendererListHandle>.get_Default
	|
	|-RVA: 0x1734D50 Offset: 0x1733750 VA: 0x181734D50
	|-EqualityComparer<Resolution>.get_Default
	|
	|-RVA: 0x17352A0 Offset: 0x1733CA0 VA: 0x1817352A0
	|-EqualityComparer<ResourceHandle>.get_Default
	|
	|-RVA: 0x1732A40 Offset: 0x1731440 VA: 0x181732A40
	|-EqualityComparer<ResourceLocator>.get_Default
	|
	|-RVA: 0x1733A30 Offset: 0x1732430 VA: 0x181733A30
	|-EqualityComparer<RpcLink>.get_Default
	|
	|-RVA: 0x1733810 Offset: 0x1732210 VA: 0x181733810
	|-EqualityComparer<RpcLinkType>.get_Default
	|
	|-RVA: 0x1734F70 Offset: 0x1733970 VA: 0x181734F70
	|-EqualityComparer<RuleMatcher>.get_Default
	|
	|-RVA: 0x17341A0 Offset: 0x1732BA0 VA: 0x1817341A0
	|-EqualityComparer<sbyte>.get_Default
	|
	|-RVA: 0x1734E60 Offset: 0x1733860 VA: 0x181734E60
	|-EqualityComparer<SamplePointUData>.get_Default
	|
	|-RVA: 0x17335F0 Offset: 0x1731FF0 VA: 0x1817335F0
	|-EqualityComparer<SamplePointsPatch>.get_Default
	|
	|-RVA: 0x1732F90 Offset: 0x1731990 VA: 0x181732F90
	|-EqualityComparer<Scene>.get_Default
	|
	|-RVA: 0x17346F0 Offset: 0x17330F0 VA: 0x1817346F0
	|-EqualityComparer<SelectorMatchRecord>.get_Default
	|
	|-RVA: 0x1733E70 Offset: 0x1732870 VA: 0x181733E70
	|-EqualityComparer<ShaderTagId>.get_Default
	|
	|-RVA: 0x17331B0 Offset: 0x1731BB0 VA: 0x1817331B0
	|-EqualityComparer<float>.get_Default
	|
	|-RVA: 0x1732E80 Offset: 0x1731880 VA: 0x181732E80
	|-EqualityComparer<SpriteState>.get_Default
	|
	|-RVA: 0x1733700 Offset: 0x1732100 VA: 0x181733700
	|-EqualityComparer<StylePropertyName>.get_Default
	|
	|-RVA: 0x17330A0 Offset: 0x1731AA0 VA: 0x1817330A0
	|-EqualityComparer<StylePropertyValue>.get_Default
	|
	|-RVA: 0x1734090 Offset: 0x1732A90 VA: 0x181734090
	|-EqualityComparer<StyleSelectorPart>.get_Default
	|
	|-RVA: 0x17344D0 Offset: 0x1732ED0 VA: 0x1817344D0
	|-EqualityComparer<StyleSyntaxToken>.get_Default
	|
	|-RVA: 0x17354C0 Offset: 0x1733EC0 VA: 0x1817354C0
	|-EqualityComparer<StyleValue>.get_Default
	|
	|-RVA: 0x1756CD0 Offset: 0x17556D0 VA: 0x181756CD0
	|-EqualityComparer<StyleValueManaged>.get_Default
	|
	|-RVA: 0x1758CB0 Offset: 0x17576B0 VA: 0x181758CB0
	|-EqualityComparer<StyleVariable>.get_Default
	|
	|-RVA: 0x1757EE0 Offset: 0x17568E0 VA: 0x181757EE0
	|-EqualityComparer<Substring>.get_Default
	|
	|-RVA: 0x1759200 Offset: 0x1757C00 VA: 0x181759200
	|-EqualityComparer<TerrainTileCoord>.get_Default
	|
	|-RVA: 0x1757880 Offset: 0x1756280 VA: 0x181757880
	|-EqualityComparer<TextureId>.get_Default
	|
	|-RVA: 0x1757CC0 Offset: 0x17566C0 VA: 0x181757CC0
	|-EqualityComparer<TimeSpan>.get_Default
	|
	|-RVA: 0x1758760 Offset: 0x1757160 VA: 0x181758760
	|-EqualityComparer<TimeValue>.get_Default
	|
	|-RVA: 0x1757770 Offset: 0x1756170 VA: 0x181757770
	|-EqualityComparer<TreeItem>.get_Default
	|
	|-RVA: 0x1759860 Offset: 0x1758260 VA: 0x181759860
	|-EqualityComparer<TreeViewItemWrapper>.get_Default
	|
	|-RVA: 0x1758980 Offset: 0x1757380 VA: 0x181758980
	|-EqualityComparer<UICharInfo>.get_Default
	|
	|-RVA: 0x1759310 Offset: 0x1757D10 VA: 0x181759310
	|-EqualityComparer<UILineInfo>.get_Default
	|
	|-RVA: 0x1758BA0 Offset: 0x17575A0 VA: 0x181758BA0
	|-EqualityComparer<UIVertex>.get_Default
	|
	|-RVA: 0x1758430 Offset: 0x1756E30 VA: 0x181758430
	|-EqualityComparer<ushort>.get_Default
	|
	|-RVA: 0x1759B90 Offset: 0x1758590 VA: 0x181759B90
	|-EqualityComparer<uint>.get_Default
	|
	|-RVA: 0x1758650 Offset: 0x1757050 VA: 0x181758650
	|-EqualityComparer<UInt32Enum>.get_Default
	|
	|-RVA: 0x1757FF0 Offset: 0x17569F0 VA: 0x181757FF0
	|-EqualityComparer<ulong>.get_Default
	|
	|-RVA: 0x1756EF0 Offset: 0x17558F0 VA: 0x181756EF0
	|-EqualityComparer<UShort2>.get_Default
	|
	|-RVA: 0x1759420 Offset: 0x1757E20 VA: 0x181759420
	|-EqualityComparer<UnloadedScene>.get_Default
	|
	|-RVA: 0x1757990 Offset: 0x1756390 VA: 0x181757990
	|-EqualityComparer<UsageHint>.get_Default
	|
	|-RVA: 0x17590F0 Offset: 0x1757AF0 VA: 0x1817590F0
	|-EqualityComparer<Vector2>.get_Default
	|
	|-RVA: 0x1759530 Offset: 0x1757F30 VA: 0x181759530
	|-EqualityComparer<Vector2Int>.get_Default
	|
	|-RVA: 0x1757330 Offset: 0x1755D30 VA: 0x181757330
	|-EqualityComparer<Vector3>.get_Default
	|
	|-RVA: 0x1757440 Offset: 0x1755E40 VA: 0x181757440
	|-EqualityComparer<Vector3Int>.get_Default
	|
	|-RVA: 0x1758870 Offset: 0x1757270 VA: 0x181758870
	|-EqualityComparer<Vector4>.get_Default
	|
	|-RVA: 0x1758A90 Offset: 0x1757490 VA: 0x181758A90
	|-EqualityComparer<VoxelContour>.get_Default
	|
	|-RVA: 0x1758ED0 Offset: 0x17578D0 VA: 0x181758ED0
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.get_Default
	|
	|-RVA: 0x1758FE0 Offset: 0x17579E0 VA: 0x181758FE0
	|-EqualityComparer<X509ChainStatus>.get_Default
	|
	|-RVA: 0x1759970 Offset: 0x1758370 VA: 0x181759970
	|-EqualityComparer<XPathNodeRef>.get_Default
	|
	|-RVA: 0x1757110 Offset: 0x1755B10 VA: 0x181757110
	|-EqualityComparer<XRFeatureDescriptor>.get_Default
	|
	|-RVA: 0x1757660 Offset: 0x1756060 VA: 0x181757660
	|-EqualityComparer<XRView>.get_Default
	|
	|-RVA: 0x1757DD0 Offset: 0x17567D0 VA: 0x181757DD0
	|-EqualityComparer<ZipGenericExtraField>.get_Default
	|
	|-RVA: 0x14AE300 Offset: 0x14ACD00 VA: 0x1814AE300
	|-EqualityComparer<__Il2CppFullySharedGenericType>.get_Default
	|
	|-RVA: 0x1757AA0 Offset: 0x17564A0 VA: 0x181757AA0
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.get_Default
	|
	|-RVA: 0x1758540 Offset: 0x1756F40 VA: 0x181758540
	|-EqualityComparer<AdvancedSmooth.Turn>.get_Default
	|
	|-RVA: 0x1759640 Offset: 0x1758040 VA: 0x181759640
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|
	|-RVA: 0x1758100 Offset: 0x1756B00 VA: 0x181758100
	|-EqualityComparer<AvatarSettings.LayerSetting>.get_Default
	|
	|-RVA: 0x1758210 Offset: 0x1756C10 VA: 0x181758210
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.get_Default
	|
	|-RVA: 0x1756DE0 Offset: 0x17557E0 VA: 0x181756DE0
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.get_Default
	|
	|-RVA: 0x1758DC0 Offset: 0x17577C0 VA: 0x181758DC0
	|-EqualityComparer<BitmapAllocator32.Page>.get_Default
	|
	|-RVA: 0x1757220 Offset: 0x1755C20 VA: 0x181757220
	|-EqualityComparer<CameraState.CustomBlendable>.get_Default
	|
	|-RVA: 0x1758320 Offset: 0x1756D20 VA: 0x181758320
	|-EqualityComparer<CinemachineClearShot.Pair>.get_Default
	|
	|-RVA: 0x1757000 Offset: 0x1755A00 VA: 0x181757000
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.get_Default
	|
	|-RVA: 0x1757550 Offset: 0x1755F50 VA: 0x181757550
	|-EqualityComparer<ClipperLib.DoublePoint>.get_Default
	|
	|-RVA: 0x1759750 Offset: 0x1758150 VA: 0x181759750
	|-EqualityComparer<ClipperLib.IntPoint>.get_Default
	|
	|-RVA: 0x1759A80 Offset: 0x1758480 VA: 0x181759A80
	|-EqualityComparer<ConfinerOven.PolygonSolution>.get_Default
	|
	|-RVA: 0x1757BB0 Offset: 0x17565B0 VA: 0x181757BB0
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.get_Default
	|
	|-RVA: 0x177CD70 Offset: 0x177B770 VA: 0x18177CD70
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.get_Default
	|
	|-RVA: 0x177CC60 Offset: 0x177B660 VA: 0x18177CC60
	|-EqualityComparer<EventDispatcher.DispatchContext>.get_Default
	|
	|-RVA: 0x177C3E0 Offset: 0x177ADE0 VA: 0x18177C3E0
	|-EqualityComparer<EventDispatcher.EventRecord>.get_Default
	|
	|-RVA: 0x177D700 Offset: 0x177C100 VA: 0x18177D700
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.get_Default
	|
	|-RVA: 0x177AFB0 Offset: 0x17799B0 VA: 0x18177AFB0
	|-EqualityComparer<FocusController.FocusedElement>.get_Default
	|
	|-RVA: 0x177DC50 Offset: 0x177C650 VA: 0x18177DC50
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.get_Default
	|
	|-RVA: 0x177DE70 Offset: 0x177C870 VA: 0x18177DE70
	|-EqualityComparer<Funnel.PathPart>.get_Default
	|
	|-RVA: 0x177BB60 Offset: 0x177A560 VA: 0x18177BB60
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.get_Default
	|
	|-RVA: 0x177D2C0 Offset: 0x177BCC0 VA: 0x18177D2C0
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.get_Default
	|
	|-RVA: 0x177B3F0 Offset: 0x1779DF0 VA: 0x18177B3F0
	|-EqualityComparer<HID.HIDCollectionDescriptor>.get_Default
	|
	|-RVA: 0x177BA50 Offset: 0x177A450 VA: 0x18177BA50
	|-EqualityComparer<HID.HIDElementDescriptor>.get_Default
	|
	|-RVA: 0x177B500 Offset: 0x1779F00 VA: 0x18177B500
	|-EqualityComparer<HIDParser.HIDReportData>.get_Default
	|
	|-RVA: 0x177D920 Offset: 0x177C320 VA: 0x18177D920
	|-EqualityComparer<HIDSupport.HIDPageUsage>.get_Default
	|
	|-RVA: 0x177CE80 Offset: 0x177B880 VA: 0x18177CE80
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.get_Default
	|
	|-RVA: 0x177CA40 Offset: 0x177B440 VA: 0x18177CA40
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.get_Default
	|
	|-RVA: 0x177CB50 Offset: 0x177B550 VA: 0x18177CB50
	|-EqualityComparer<InputControlLayout.ControlItem>.get_Default
	|
	|-RVA: 0x177B940 Offset: 0x177A340 VA: 0x18177B940
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.get_Default
	|
	|-RVA: 0x177C4F0 Offset: 0x177AEF0 VA: 0x18177C4F0
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.get_Default
	|
	|-RVA: 0x177C2D0 Offset: 0x177ACD0 VA: 0x18177C2D0
	|-EqualityComparer<InputTransformSpots.TransformSpot>.get_Default
	|
	|-RVA: 0x177BD80 Offset: 0x177A780 VA: 0x18177BD80
	|-EqualityComparer<InputUser.OngoingAccountSelection>.get_Default
	|
	|-RVA: 0x177B0C0 Offset: 0x1779AC0 VA: 0x18177B0C0
	|-EqualityComparer<JsonParser.JsonValue>.get_Default
	|
	|-RVA: 0x177C600 Offset: 0x177B000 VA: 0x18177C600
	|-EqualityComparer<LatencySimulator.Message>.get_Default
	|
	|-RVA: 0x177BFA0 Offset: 0x177A9A0 VA: 0x18177BFA0
	|-EqualityComparer<LiquidVolume.MeshCache>.get_Default
	|
	|-RVA: 0x177B610 Offset: 0x177A010 VA: 0x18177B610
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.get_Default
	|
	|-RVA: 0x177BE90 Offset: 0x177A890 VA: 0x18177BE90
	|-EqualityComparer<Multipass.TransportIdData>.get_Default
	|
	|-RVA: 0x177DB40 Offset: 0x177C540 VA: 0x18177DB40
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.get_Default
	|
	|-RVA: 0x177D3D0 Offset: 0x177BDD0 VA: 0x18177D3D0
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.get_Default
	|
	|-RVA: 0x177B2E0 Offset: 0x1779CE0 VA: 0x18177B2E0
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.get_Default
	|
	|-RVA: 0x177DA30 Offset: 0x177C430 VA: 0x18177DA30
	|-EqualityComparer<NetworkAnimator.StateChange>.get_Default
	|
	|-RVA: 0x177B720 Offset: 0x177A120 VA: 0x18177B720
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.get_Default
	|
	|-RVA: 0x177D810 Offset: 0x177C210 VA: 0x18177D810
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.get_Default
	|
	|-RVA: 0x177C1C0 Offset: 0x177ABC0 VA: 0x18177C1C0
	|-EqualityComparer<ObjectPool.DelayedStoreData>.get_Default
	|
	|-RVA: 0x177DD60 Offset: 0x177C760 VA: 0x18177DD60
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.get_Default
	|
	|-RVA: 0x177DF80 Offset: 0x177C980 VA: 0x18177DF80
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.get_Default
	|
	|-RVA: 0x177D0A0 Offset: 0x177BAA0 VA: 0x18177D0A0
	|-EqualityComparer<PlayingCard.CardData>.get_Default
	|
	|-RVA: 0x177BC70 Offset: 0x177A670 VA: 0x18177BC70
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.get_Default
	|
	|-RVA: 0x177B1D0 Offset: 0x1779BD0 VA: 0x18177B1D0
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.get_Default
	|
	|-RVA: 0x177C710 Offset: 0x177B110 VA: 0x18177C710
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.get_Default
	|
	|-RVA: 0x177B830 Offset: 0x177A230 VA: 0x18177B830
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.get_Default
	|
	|-RVA: 0x177CF90 Offset: 0x177B990 VA: 0x18177CF90
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.get_Default
	|
	|-RVA: 0x177D5F0 Offset: 0x177BFF0 VA: 0x18177D5F0
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.get_Default
	|
	|-RVA: 0x177C820 Offset: 0x177B220 VA: 0x18177C820
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.get_Default
	|
	|-RVA: 0x177D1B0 Offset: 0x177BBB0 VA: 0x18177D1B0
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.get_Default
	|
	|-RVA: 0x177C930 Offset: 0x177B330 VA: 0x18177C930
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.get_Default
	|
	|-RVA: 0x177D4E0 Offset: 0x177BEE0 VA: 0x18177D4E0
	|-EqualityComparer<Regex.CachedCodeEntryKey>.get_Default
	|
	|-RVA: 0x177C0B0 Offset: 0x177AAB0 VA: 0x18177C0B0
	|-EqualityComparer<RegexCharClass.SingleRange>.get_Default
	|
	|-RVA: 0x179E030 Offset: 0x179CA30 VA: 0x18179E030
	|-EqualityComparer<RenderChain.RenderNodeData>.get_Default
	|
	|-RVA: 0x17A0670 Offset: 0x179F070 VA: 0x1817A0670
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.get_Default
	|
	|-RVA: 0x17A0450 Offset: 0x179EE50 VA: 0x1817A0450
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.get_Default
	|
	|-RVA: 0x179DD00 Offset: 0x179C700 VA: 0x18179DD00
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.get_Default
	|
	|-RVA: 0x17A0780 Offset: 0x179F180 VA: 0x1817A0780
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.get_Default
	|
	|-RVA: 0x179EF10 Offset: 0x179D910 VA: 0x18179EF10
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.get_Default
	|
	|-RVA: 0x179DF20 Offset: 0x179C920 VA: 0x18179DF20
	|-EqualityComparer<RigidbodyPrediction.MoveData>.get_Default
	|
	|-RVA: 0x17A0120 Offset: 0x179EB20 VA: 0x1817A0120
	|-EqualityComparer<SVGDocument.ClipData>.get_Default
	|
	|-RVA: 0x179EE00 Offset: 0x179D800 VA: 0x18179EE00
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.get_Default
	|
	|-RVA: 0x179F8A0 Offset: 0x179E2A0 VA: 0x18179F8A0
	|-EqualityComparer<SVGDocument.MaskData>.get_Default
	|
	|-RVA: 0x179E470 Offset: 0x179CE70 VA: 0x18179E470
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.get_Default
	|
	|-RVA: 0x179FAC0 Offset: 0x179E4C0 VA: 0x18179FAC0
	|-EqualityComparer<SVGDocument.NodeReferenceData>.get_Default
	|
	|-RVA: 0x179F130 Offset: 0x179DB30 VA: 0x18179F130
	|-EqualityComparer<SVGDocument.NodeWithParent>.get_Default
	|
	|-RVA: 0x179F240 Offset: 0x179DC40 VA: 0x18179F240
	|-EqualityComparer<SVGDocument.PatternData>.get_Default
	|
	|-RVA: 0x179F9B0 Offset: 0x179E3B0 VA: 0x18179F9B0
	|-EqualityComparer<SVGDocument.PostponedClip>.get_Default
	|
	|-RVA: 0x179F570 Offset: 0x179DF70 VA: 0x18179F570
	|-EqualityComparer<SVGDocument.PostponedStopData>.get_Default
	|
	|-RVA: 0x179FF00 Offset: 0x179E900 VA: 0x18179FF00
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.get_Default
	|
	|-RVA: 0x179D7B0 Offset: 0x179C1B0 VA: 0x18179D7B0
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.get_Default
	|
	|-RVA: 0x179E580 Offset: 0x179CF80 VA: 0x18179E580
	|-EqualityComparer<ServerSocket.ConnectionChange>.get_Default
	|
	|-RVA: 0x179E7A0 Offset: 0x179D1A0 VA: 0x18179E7A0
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.get_Default
	|
	|-RVA: 0x179DBF0 Offset: 0x179C5F0 VA: 0x18179DBF0
	|-EqualityComparer<ShadowUtility.Edge>.get_Default
	|
	|-RVA: 0x179EAD0 Offset: 0x179D4D0 VA: 0x18179EAD0
	|-EqualityComparer<StructySync.ChangeData>.get_Default
	|
	|-RVA: 0x179FBD0 Offset: 0x179E5D0 VA: 0x18179FBD0
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.get_Default
	|
	|-RVA: 0x179F790 Offset: 0x179E190 VA: 0x18179F790
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.get_Default
	|
	|-RVA: 0x179F020 Offset: 0x179DA20 VA: 0x18179F020
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.get_Default
	|
	|-RVA: 0x179DE10 Offset: 0x179C810 VA: 0x18179DE10
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.get_Default
	|
	|-RVA: 0x179D9D0 Offset: 0x179C3D0 VA: 0x18179D9D0
	|-EqualityComparer<SyncStopwatch.ChangeData>.get_Default
	|
	|-RVA: 0x179FCE0 Offset: 0x179E6E0 VA: 0x18179FCE0
	|-EqualityComparer<SyncTimer.ChangeData>.get_Default
	|
	|-RVA: 0x179EBE0 Offset: 0x179D5E0 VA: 0x18179EBE0
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.get_Default
	|
	|-RVA: 0x179FDF0 Offset: 0x179E7F0 VA: 0x18179FDF0
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.get_Default
	|
	|-RVA: 0x179ECF0 Offset: 0x179D6F0 VA: 0x18179ECF0
	|-EqualityComparer<TargetStateListener.Callback>.get_Default
	|
	|-RVA: 0x17A0230 Offset: 0x179EC30 VA: 0x1817A0230
	|-EqualityComparer<TemplateAsset.AttributeOverride>.get_Default
	|
	|-RVA: 0x179E690 Offset: 0x179D090 VA: 0x18179E690
	|-EqualityComparer<TextResourceManager.FontAssetRef>.get_Default
	|
	|-RVA: 0x17A0340 Offset: 0x179ED40 VA: 0x1817A0340
	|-EqualityComparer<TextSettings.FontReferenceMap>.get_Default
	|
	|-RVA: 0x179E250 Offset: 0x179CC50 VA: 0x18179E250
	|-EqualityComparer<TextureBlitter.BlitInfo>.get_Default
	|
	|-RVA: 0x179F460 Offset: 0x179DE60 VA: 0x18179F460
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.get_Default
	|
	|-RVA: 0x179DAE0 Offset: 0x179C4E0 VA: 0x18179DAE0
	|-EqualityComparer<TextureRegistry.TextureInfo>.get_Default
	|
	|-RVA: 0x17A0560 Offset: 0x179EF60 VA: 0x1817A0560
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|
	|-RVA: 0x179E360 Offset: 0x179CD60 VA: 0x18179E360
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.get_Default
	|
	|-RVA: 0x179E8B0 Offset: 0x179D2B0 VA: 0x18179E8B0
	|-EqualityComparer<TransportManager.DisconnectingClient>.get_Default
	|
	|-RVA: 0x179D8C0 Offset: 0x179C2C0 VA: 0x18179D8C0
	|-EqualityComparer<UIRStylePainter.Entry>.get_Default
	|
	|-RVA: 0x179F680 Offset: 0x179E080 VA: 0x18179F680
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.get_Default
	|
	|-RVA: 0x17A0010 Offset: 0x179EA10 VA: 0x1817A0010
	|-EqualityComparer<UIRenderDevice.AllocToFree>.get_Default
	|
	|-RVA: 0x179E9C0 Offset: 0x179D3C0 VA: 0x18179E9C0
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.get_Default
	|
	|-RVA: 0x179E140 Offset: 0x179CB40 VA: 0x18179E140
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.get_Default
	|
	|-RVA: 0x179F350 Offset: 0x179DD50 VA: 0x18179F350
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.get_Default
	|
	|-RVA: 0x17AB1F0 Offset: 0x17A9BF0 VA: 0x1817AB1F0
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.get_Default
	|
	|-RVA: 0x17AB520 Offset: 0x17A9F20 VA: 0x1817AB520
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.get_Default
	|
	|-RVA: 0x17AAEC0 Offset: 0x17A98C0 VA: 0x1817AAEC0
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.get_Default
	|
	|-RVA: 0x17ABA70 Offset: 0x17AA470 VA: 0x1817ABA70
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.get_Default
	|
	|-RVA: 0x17AB410 Offset: 0x17A9E10 VA: 0x1817AB410
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.get_Default
	|
	|-RVA: 0x17AB0E0 Offset: 0x17A9AE0 VA: 0x1817AB0E0
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Default
	|
	|-RVA: 0x17AADB0 Offset: 0x17A97B0 VA: 0x1817AADB0
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.get_Default
	|
	|-RVA: 0x17AAFD0 Offset: 0x17A99D0 VA: 0x1817AAFD0
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.get_Default
	|
	|-RVA: 0x17AB630 Offset: 0x17AA030 VA: 0x1817AB630
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.get_Default
	|
	|-RVA: 0x17AB960 Offset: 0x17AA360 VA: 0x1817AB960
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.get_Default
	|
	|-RVA: 0x17ABB80 Offset: 0x17AA580 VA: 0x1817ABB80
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.get_Default
	|
	|-RVA: 0x17AB300 Offset: 0x17A9D00 VA: 0x1817AB300
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.get_Default
	|
	|-RVA: 0x17AB850 Offset: 0x17AA250 VA: 0x1817AB850
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Default
	|
	|-RVA: 0x17AACA0 Offset: 0x17A96A0 VA: 0x1817AACA0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.get_Default
	|
	|-RVA: 0x17AB740 Offset: 0x17AA140 VA: 0x1817AB740
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	*/

	// RVA: -1 Offset: -1
	private static EqualityComparer<T> CreateComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16B2C00 Offset: 0x16B1600 VA: 0x1816B2C00
	|-EqualityComparer<ArraySegment<byte>>.CreateComparer
	|
	|-RVA: 0x16C11B0 Offset: 0x16BFBB0 VA: 0x1816C11B0
	|-EqualityComparer<SyncList.CachedOnChange<int>>.CreateComparer
	|
	|-RVA: 0x16BC520 Offset: 0x16BAF20 VA: 0x1816BC520
	|-EqualityComparer<SyncList.ChangeData<int>>.CreateComparer
	|
	|-RVA: 0x16BE5F0 Offset: 0x16BCFF0 VA: 0x1816BE5F0
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.CreateComparer
	|
	|-RVA: 0x16B8380 Offset: 0x16B6D80 VA: 0x1816B8380
	|-EqualityComparer<IntervalTree.Entry<object>>.CreateComparer
	|
	|-RVA: 0x16AEA60 Offset: 0x16AD460 VA: 0x1816AEA60
	|-EqualityComparer<KeyValuePair<int, int>>.CreateComparer
	|
	|-RVA: 0x16C1CA0 Offset: 0x16C06A0 VA: 0x1816C1CA0
	|-EqualityComparer<KeyValuePair<int, object>>.CreateComparer
	|
	|-RVA: 0x16BFBD0 Offset: 0x16BE5D0 VA: 0x1816BFBD0
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x16C06C0 Offset: 0x16BF0C0 VA: 0x1816C06C0
	|-EqualityComparer<KeyValuePair<object, bool>>.CreateComparer
	|
	|-RVA: 0x16B62B0 Offset: 0x16B4CB0 VA: 0x1816B62B0
	|-EqualityComparer<KeyValuePair<object, char>>.CreateComparer
	|
	|-RVA: 0x16B57C0 Offset: 0x16B41C0 VA: 0x1816B57C0
	|-EqualityComparer<KeyValuePair<object, object>>.CreateComparer
	|
	|-RVA: 0x16B1620 Offset: 0x16B0020 VA: 0x1816B1620
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.CreateComparer
	|
	|-RVA: 0x16BF0E0 Offset: 0x16BDAE0 VA: 0x1816BF0E0
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.CreateComparer
	|
	|-RVA: 0x16B7890 Offset: 0x16B6290 VA: 0x1816B7890
	|-EqualityComparer<KeyValuePair<Rect, object>>.CreateComparer
	|
	|-RVA: 0x16C3280 Offset: 0x16C1C80 VA: 0x1816C3280
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.CreateComparer
	|
	|-RVA: 0x16B4CD0 Offset: 0x16B36D0 VA: 0x1816B4CD0
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.CreateComparer
	|
	|-RVA: 0x16BDB00 Offset: 0x16BC500 VA: 0x1816BDB00
	|-EqualityComparer<NativeArray<NudgeJobData>>.CreateComparer
	|
	|-RVA: 0x16AF550 Offset: 0x16ADF50 VA: 0x1816AF550
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.CreateComparer
	|
	|-RVA: 0x16BBA30 Offset: 0x16BA430 VA: 0x1816BBA30
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.CreateComparer
	|
	|-RVA: 0x16B0B30 Offset: 0x16AF530 VA: 0x1816B0B30
	|-EqualityComparer<NativeSlice<NudgeJobData>>.CreateComparer
	|
	|-RVA: 0x16B36F0 Offset: 0x16B20F0 VA: 0x1816B36F0
	|-EqualityComparer<Nullable<DateTime>>.CreateComparer
	|
	|-RVA: 0x16BA450 Offset: 0x16B8E50 VA: 0x1816BA450
	|-EqualityComparer<Nullable<Decimal>>.CreateComparer
	|
	|-RVA: 0x16BD010 Offset: 0x16BBA10 VA: 0x1816BD010
	|-EqualityComparer<TempAllocator.Page<ushort>>.CreateComparer
	|
	|-RVA: 0x16B9960 Offset: 0x16B8360 VA: 0x1816B9960
	|-EqualityComparer<TempAllocator.Page<Vertex>>.CreateComparer
	|
	|-RVA: 0x16B2110 Offset: 0x16B0B10 VA: 0x1816B2110
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.CreateComparer
	|
	|-RVA: 0x16C2790 Offset: 0x16C1190 VA: 0x1816C2790
	|-EqualityComparer<StructMultiKey<object, object>>.CreateComparer
	|
	|-RVA: 0x16B0040 Offset: 0x16AEA40 VA: 0x1816B0040
	|-EqualityComparer<SubArray<int>>.CreateComparer
	|
	|-RVA: 0x16B41E0 Offset: 0x16B2BE0 VA: 0x1816B41E0
	|-EqualityComparer<TreeViewItemData<object>>.CreateComparer
	|
	|-RVA: 0x16ADF70 Offset: 0x16AC970 VA: 0x1816ADF70
	|-EqualityComparer<ValueTuple<bool>>.CreateComparer
	|
	|-RVA: 0x16BAF40 Offset: 0x16B9940 VA: 0x1816BAF40
	|-EqualityComparer<ValueTuple<int, int>>.CreateComparer
	|
	|-RVA: 0x16B8E70 Offset: 0x16B7870 VA: 0x1816B8E70
	|-EqualityComparer<ValueTuple<int, object>>.CreateComparer
	|
	|-RVA: 0x16B6DA0 Offset: 0x16B57A0 VA: 0x1816B6DA0
	|-EqualityComparer<ValueTuple<int, Scene>>.CreateComparer
	|
	|-RVA: 0x16D1860 Offset: 0x16D0260 VA: 0x1816D1860
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.CreateComparer
	|
	|-RVA: 0x16E1EE0 Offset: 0x16E08E0 VA: 0x1816E1EE0
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.CreateComparer
	|
	|-RVA: 0x16CC0E0 Offset: 0x16CAAE0 VA: 0x1816CC0E0
	|-EqualityComparer<ValueTuple<IntPtr, object>>.CreateComparer
	|
	|-RVA: 0x16DB180 Offset: 0x16D9B80 VA: 0x1816DB180
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.CreateComparer
	|
	|-RVA: 0x16CECA0 Offset: 0x16CD6A0 VA: 0x1816CECA0
	|-EqualityComparer<ValueTuple<object, int>>.CreateComparer
	|
	|-RVA: 0x16E34C0 Offset: 0x16E1EC0 VA: 0x1816E34C0
	|-EqualityComparer<ValueTuple<object, object>>.CreateComparer
	|
	|-RVA: 0x16CCBD0 Offset: 0x16CB5D0 VA: 0x1816CCBD0
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.CreateComparer
	|
	|-RVA: 0x16DF320 Offset: 0x16DDD20 VA: 0x1816DF320
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.CreateComparer
	|
	|-RVA: 0x16CAB00 Offset: 0x16C9500 VA: 0x1816CAB00
	|-EqualityComparer<ValueTuple<object, object, object>>.CreateComparer
	|
	|-RVA: 0x16DDD40 Offset: 0x16DC740 VA: 0x1816DDD40
	|-EqualityComparer<AnimatorClipInfo>.CreateComparer
	|
	|-RVA: 0x16C9520 Offset: 0x16C7F20 VA: 0x1816C9520
	|-EqualityComparer<AsyncGPUReadbackRequest>.CreateComparer
	|
	|-RVA: 0x16E13F0 Offset: 0x16DFDF0 VA: 0x1816E13F0
	|-EqualityComparer<Background>.CreateComparer
	|
	|-RVA: 0x16E4AA0 Offset: 0x16E34A0 VA: 0x1816E4AA0
	|-EqualityComparer<BackgroundPosition>.CreateComparer
	|
	|-RVA: 0x16D7AD0 Offset: 0x16D64D0 VA: 0x1816D7AD0
	|-EqualityComparer<BackgroundRepeat>.CreateComparer
	|
	|-RVA: 0x16C8A30 Offset: 0x16C7430 VA: 0x1816C8A30
	|-EqualityComparer<BezierContour>.CreateComparer
	|
	|-RVA: 0x16D2E40 Offset: 0x16D1840 VA: 0x1816D2E40
	|-EqualityComparer<BezierPathSegment>.CreateComparer
	|
	|-RVA: 0x16DE830 Offset: 0x16DD230 VA: 0x1816DE830
	|-EqualityComparer<BezierSegment>.CreateComparer
	|
	|-RVA: 0x16D0D70 Offset: 0x16CF770 VA: 0x1816D0D70
	|-EqualityComparer<bool>.CreateComparer
	|
	|-RVA: 0x16C7F40 Offset: 0x16C6940 VA: 0x1816C7F40
	|-EqualityComparer<Bounds>.CreateComparer
	|
	|-RVA: 0x16D6FE0 Offset: 0x16D59E0 VA: 0x1816D6FE0
	|-EqualityComparer<BoundsInt>.CreateComparer
	|
	|-RVA: 0x16E3FB0 Offset: 0x16E29B0 VA: 0x1816E3FB0
	|-EqualityComparer<byte>.CreateComparer
	|
	|-RVA: 0x16CB5F0 Offset: 0x16C9FF0 VA: 0x1816CB5F0
	|-EqualityComparer<ByteEnum>.CreateComparer
	|
	|-RVA: 0x16D4420 Offset: 0x16D2E20 VA: 0x1816D4420
	|-EqualityComparer<CGSpot>.CreateComparer
	|
	|-RVA: 0x16CF790 Offset: 0x16CE190 VA: 0x1816CF790
	|-EqualityComparer<CSteamID>.CreateComparer
	|
	|-RVA: 0x16D9BA0 Offset: 0x16D85A0 VA: 0x1816D9BA0
	|-EqualityComparer<char>.CreateComparer
	|
	|-RVA: 0x16E6B70 Offset: 0x16E5570 VA: 0x1816E6B70
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x16CE1B0 Offset: 0x16CCBB0 VA: 0x1816CE1B0
	|-EqualityComparer<Color>.CreateComparer
	|
	|-RVA: 0x16D90B0 Offset: 0x16D7AB0 VA: 0x1816D90B0
	|-EqualityComparer<Color32>.CreateComparer
	|
	|-RVA: 0x16E5590 Offset: 0x16E3F90 VA: 0x1816E5590
	|-EqualityComparer<ColorBlock>.CreateComparer
	|
	|-RVA: 0x16D85C0 Offset: 0x16D6FC0 VA: 0x1816D85C0
	|-EqualityComparer<CombineInstance>.CreateComparer
	|
	|-RVA: 0x16D3930 Offset: 0x16D2330 VA: 0x1816D3930
	|-EqualityComparer<ComputedStyle>.CreateComparer
	|
	|-RVA: 0x16DBC70 Offset: 0x16DA670 VA: 0x1816DBC70
	|-EqualityComparer<ComputedTransitionProperty>.CreateComparer
	|
	|-RVA: 0x16E0900 Offset: 0x16DF300 VA: 0x1816E0900
	|-EqualityComparer<Connection>.CreateComparer
	|
	|-RVA: 0x16D4F10 Offset: 0x16D3910 VA: 0x1816D4F10
	|-EqualityComparer<ContourVertex>.CreateComparer
	|
	|-RVA: 0x16CA010 Offset: 0x16C8A10 VA: 0x1816CA010
	|-EqualityComparer<ControlPointOption>.CreateComparer
	|
	|-RVA: 0x16DFE10 Offset: 0x16DE810 VA: 0x1816DFE10
	|-EqualityComparer<CoordinateFootprintTilePair>.CreateComparer
	|
	|-RVA: 0x16D0280 Offset: 0x16CEC80 VA: 0x1816D0280
	|-EqualityComparer<CoordinateProceduralTilePair>.CreateComparer
	|
	|-RVA: 0x16E29D0 Offset: 0x16E13D0 VA: 0x1816E29D0
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.CreateComparer
	|
	|-RVA: 0x16DC760 Offset: 0x16DB160 VA: 0x1816DC760
	|-EqualityComparer<CoordinateStorageTilePair>.CreateComparer
	|
	|-RVA: 0x16DD250 Offset: 0x16DBC50 VA: 0x1816DD250
	|-EqualityComparer<CoordinateTilePair>.CreateComparer
	|
	|-RVA: 0x16D5A00 Offset: 0x16D4400 VA: 0x1816D5A00
	|-EqualityComparer<DateTime>.CreateComparer
	|
	|-RVA: 0x16E6080 Offset: 0x16E4A80 VA: 0x1816E6080
	|-EqualityComparer<DateTimeOffset>.CreateComparer
	|
	|-RVA: 0x16CD6C0 Offset: 0x16CC0C0 VA: 0x1816CD6C0
	|-EqualityComparer<Decimal>.CreateComparer
	|
	|-RVA: 0x16D2350 Offset: 0x16D0D50 VA: 0x1816D2350
	|-EqualityComparer<DisplayInfo>.CreateComparer
	|
	|-RVA: 0x16D64F0 Offset: 0x16D4EF0 VA: 0x1816D64F0
	|-EqualityComparer<double>.CreateComparer
	|
	|-RVA: 0x16DA690 Offset: 0x16D9090 VA: 0x1816DA690
	|-EqualityComparer<DoublePoint>.CreateComparer
	|
	|-RVA: 0x16F2CA0 Offset: 0x16F16A0 VA: 0x1816F2CA0
	|-EqualityComparer<DoublePoint>.CreateComparer
	|
	|-RVA: 0x16F4280 Offset: 0x16F2C80 VA: 0x1816F4280
	|-EqualityComparer<DualPrefab>.CreateComparer
	|
	|-RVA: 0x1704900 Offset: 0x1703300 VA: 0x181704900
	|-EqualityComparer<DuplicateSamplePoint>.CreateComparer
	|
	|-RVA: 0x16FAFE0 Offset: 0x16F99E0 VA: 0x1816FAFE0
	|-EqualityComparer<EasingFunction>.CreateComparer
	|
	|-RVA: 0x16FC5C0 Offset: 0x16FAFC0 VA: 0x1816FC5C0
	|-EqualityComparer<Entry>.CreateComparer
	|
	|-RVA: 0x1701D40 Offset: 0x1700740 VA: 0x181701D40
	|-EqualityComparer<EnumData>.CreateComparer
	|
	|-RVA: 0x16F5860 Offset: 0x16F4260 VA: 0x1816F5860
	|-EqualityComparer<EventSummary>.CreateComparer
	|
	|-RVA: 0x170C150 Offset: 0x170AB50 VA: 0x18170C150
	|-EqualityComparer<FontDefinition>.CreateComparer
	|
	|-RVA: 0x17074C0 Offset: 0x1705EC0 VA: 0x1817074C0
	|-EqualityComparer<FrameTimeSample>.CreateComparer
	|
	|-RVA: 0x170AB70 Offset: 0x1709570 VA: 0x18170AB70
	|-EqualityComparer<FullRank>.CreateComparer
	|
	|-RVA: 0x16F21B0 Offset: 0x16F0BB0 VA: 0x1816F21B0
	|-EqualityComparer<GCHandle>.CreateComparer
	|
	|-RVA: 0x16F4D70 Offset: 0x16F3770 VA: 0x1816F4D70
	|-EqualityComparer<GlyphPairAdjustmentRecord>.CreateComparer
	|
	|-RVA: 0x1701250 Offset: 0x16FFC50 VA: 0x181701250
	|-EqualityComparer<GlyphRect>.CreateComparer
	|
	|-RVA: 0x1709590 Offset: 0x1707F90 VA: 0x181709590
	|-EqualityComparer<Guid>.CreateComparer
	|
	|-RVA: 0x16F8420 Offset: 0x16F6E20 VA: 0x1816F8420
	|-EqualityComparer<HSteamNetConnection>.CreateComparer
	|
	|-RVA: 0x16F0BD0 Offset: 0x16EF5D0 VA: 0x1816F0BD0
	|-EqualityComparer<Hash128>.CreateComparer
	|
	|-RVA: 0x16EEB00 Offset: 0x16ED500 VA: 0x1816EEB00
	|-EqualityComparer<InputBinding>.CreateComparer
	|
	|-RVA: 0x16F6E40 Offset: 0x16F5840 VA: 0x1816F6E40
	|-EqualityComparer<InputDeviceDescription>.CreateComparer
	|
	|-RVA: 0x1703320 Offset: 0x1701D20 VA: 0x181703320
	|-EqualityComparer<InputEventPtr>.CreateComparer
	|
	|-RVA: 0x16EF5F0 Offset: 0x16EDFF0 VA: 0x1816EF5F0
	|-EqualityComparer<short>.CreateComparer
	|
	|-RVA: 0x1700760 Offset: 0x16FF160 VA: 0x181700760
	|-EqualityComparer<Int2>.CreateComparer
	|
	|-RVA: 0x1707FB0 Offset: 0x17069B0 VA: 0x181707FB0
	|-EqualityComparer<Int3>.CreateComparer
	|
	|-RVA: 0x16F3790 Offset: 0x16F2190 VA: 0x1816F3790
	|-EqualityComparer<int>.CreateComparer
	|
	|-RVA: 0x16FE690 Offset: 0x16FD090 VA: 0x1816FE690
	|-EqualityComparer<Int32Enum>.CreateComparer
	|
	|-RVA: 0x16FD0B0 Offset: 0x16FBAB0 VA: 0x1816FD0B0
	|-EqualityComparer<long>.CreateComparer
	|
	|-RVA: 0x1702830 Offset: 0x1701230 VA: 0x181702830
	|-EqualityComparer<IntPoint>.CreateComparer
	|
	|-RVA: 0x16FA4F0 Offset: 0x16F8EF0 VA: 0x1816FA4F0
	|-EqualityComparer<IntPoint>.CreateComparer
	|
	|-RVA: 0x1703E10 Offset: 0x1702810 VA: 0x181703E10
	|-EqualityComparer<IntPtr>.CreateComparer
	|
	|-RVA: 0x17069D0 Offset: 0x17053D0 VA: 0x1817069D0
	|-EqualityComparer<IntRect>.CreateComparer
	|
	|-RVA: 0x170B660 Offset: 0x170A060 VA: 0x18170B660
	|-EqualityComparer<IntRegion>.CreateComparer
	|
	|-RVA: 0x16F7930 Offset: 0x16F6330 VA: 0x1816F7930
	|-EqualityComparer<InternedString>.CreateComparer
	|
	|-RVA: 0x17053F0 Offset: 0x1703DF0 VA: 0x1817053F0
	|-EqualityComparer<InterpretedFrameInfo>.CreateComparer
	|
	|-RVA: 0x170A080 Offset: 0x1708A80 VA: 0x18170A080
	|-EqualityComparer<IntervalTreeNode>.CreateComparer
	|
	|-RVA: 0x16F6350 Offset: 0x16F4D50 VA: 0x1816F6350
	|-EqualityComparer<JsonPosition>.CreateComparer
	|
	|-RVA: 0x16FDBA0 Offset: 0x16FC5A0 VA: 0x1816FDBA0
	|-EqualityComparer<Label>.CreateComparer
	|
	|-RVA: 0x16FF180 Offset: 0x16FDB80 VA: 0x1816FF180
	|-EqualityComparer<LayerMask>.CreateComparer
	|
	|-RVA: 0x16F16C0 Offset: 0x16F00C0 VA: 0x1816F16C0
	|-EqualityComparer<LigatureSubstitutionRecord>.CreateComparer
	|
	|-RVA: 0x1708AA0 Offset: 0x17074A0 VA: 0x181708AA0
	|-EqualityComparer<LigatureSubstitutionRecord>.CreateComparer
	|
	|-RVA: 0x16EE010 Offset: 0x16ECA10 VA: 0x1816EE010
	|-EqualityComparer<LocalPacket>.CreateComparer
	|
	|-RVA: 0x170CC40 Offset: 0x170B640 VA: 0x18170CC40
	|-EqualityComparer<LocalPacket>.CreateComparer
	|
	|-RVA: 0x1705EE0 Offset: 0x17048E0 VA: 0x181705EE0
	|-EqualityComparer<ManipulatorActivationFilter>.CreateComparer
	|
	|-RVA: 0x16F00E0 Offset: 0x16EEAE0 VA: 0x1816F00E0
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.CreateComparer
	|
	|-RVA: 0x16F8F10 Offset: 0x16F7910 VA: 0x1816F8F10
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.CreateComparer
	|
	|-RVA: 0x16FFC70 Offset: 0x16FE670 VA: 0x1816FFC70
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.CreateComparer
	|
	|-RVA: 0x16FBAD0 Offset: 0x16FA4D0 VA: 0x1816FBAD0
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.CreateComparer
	|
	|-RVA: 0x16F9A00 Offset: 0x16F8400 VA: 0x1816F9A00
	|-EqualityComparer<Matrix4x4>.CreateComparer
	|
	|-RVA: 0x1725800 Offset: 0x1724200 VA: 0x181725800
	|-EqualityComparer<MultipleSubstitutionRecord>.CreateComparer
	|
	|-RVA: 0x1726DE0 Offset: 0x17257E0 VA: 0x181726DE0
	|-EqualityComparer<MultipleSubstitutionRecord>.CreateComparer
	|
	|-RVA: 0x17299A0 Offset: 0x17283A0 VA: 0x1817299A0
	|-EqualityComparer<NameAndParameters>.CreateComparer
	|
	|-RVA: 0x1722C40 Offset: 0x1721640 VA: 0x181722C40
	|-EqualityComparer<NamedValue>.CreateComparer
	|
	|-RVA: 0x171A900 Offset: 0x1719300 VA: 0x18171A900
	|-EqualityComparer<NativeAddr>.CreateComparer
	|
	|-RVA: 0x171D4C0 Offset: 0x171BEC0 VA: 0x18171D4C0
	|-EqualityComparer<NavMeshBuildMarkup>.CreateComparer
	|
	|-RVA: 0x1715180 Offset: 0x1713B80 VA: 0x181715180
	|-EqualityComparer<NavMeshBuildSource>.CreateComparer
	|
	|-RVA: 0x17283C0 Offset: 0x1726DC0 VA: 0x1817283C0
	|-EqualityComparer<Navigation>.CreateComparer
	|
	|-RVA: 0x172BA70 Offset: 0x172A470 VA: 0x18172BA70
	|-EqualityComparer<object>.CreateComparer
	|
	|-RVA: 0x1718830 Offset: 0x1717230 VA: 0x181718830
	|-EqualityComparer<Packet>.CreateComparer
	|
	|-RVA: 0x171B3F0 Offset: 0x1719DF0 VA: 0x18171B3F0
	|-EqualityComparer<Playable>.CreateComparer
	|
	|-RVA: 0x172E630 Offset: 0x172D030 VA: 0x18172E630
	|-EqualityComparer<PlayableBinding>.CreateComparer
	|
	|-RVA: 0x1722150 Offset: 0x1720B50 VA: 0x181722150
	|-EqualityComparer<PlayerLoopSystem>.CreateComparer
	|
	|-RVA: 0x171F590 Offset: 0x171DF90 VA: 0x18171F590
	|-EqualityComparer<PlayerLoopSystemInternal>.CreateComparer
	|
	|-RVA: 0x17125C0 Offset: 0x1710FC0 VA: 0x1817125C0
	|-EqualityComparer<PointerModel>.CreateComparer
	|
	|-RVA: 0x171EAA0 Offset: 0x171D4A0 VA: 0x18171EAA0
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.CreateComparer
	|
	|-RVA: 0x17278D0 Offset: 0x17262D0 VA: 0x1817278D0
	|-EqualityComparer<Quaternion>.CreateComparer
	|
	|-RVA: 0x172D050 Offset: 0x172BA50 VA: 0x18172D050
	|-EqualityComparer<RangePositionInfo>.CreateComparer
	|
	|-RVA: 0x1717250 Offset: 0x1715C50 VA: 0x181717250
	|-EqualityComparer<RaycastHit>.CreateComparer
	|
	|-RVA: 0x172DB40 Offset: 0x172C540 VA: 0x18172DB40
	|-EqualityComparer<RaycastHit2D>.CreateComparer
	|
	|-RVA: 0x172A490 Offset: 0x1728E90 VA: 0x18172A490
	|-EqualityComparer<RaycastResult>.CreateComparer
	|
	|-RVA: 0x1724220 Offset: 0x1722C20 VA: 0x181724220
	|-EqualityComparer<Rect>.CreateComparer
	|
	|-RVA: 0x172F120 Offset: 0x172DB20 VA: 0x18172F120
	|-EqualityComparer<RectInt>.CreateComparer
	|
	|-RVA: 0x1723730 Offset: 0x1722130 VA: 0x181723730
	|-EqualityComparer<RenderInstancedDataLayout>.CreateComparer
	|
	|-RVA: 0x1717D40 Offset: 0x1716740 VA: 0x181717D40
	|-EqualityComparer<RenderTargetIdentifier>.CreateComparer
	|
	|-RVA: 0x1728EB0 Offset: 0x17278B0 VA: 0x181728EB0
	|-EqualityComparer<RendererList>.CreateComparer
	|
	|-RVA: 0x1713BA0 Offset: 0x17125A0 VA: 0x181713BA0
	|-EqualityComparer<RendererListHandle>.CreateComparer
	|
	|-RVA: 0x1711AD0 Offset: 0x17104D0 VA: 0x181711AD0
	|-EqualityComparer<Resolution>.CreateComparer
	|
	|-RVA: 0x172FC10 Offset: 0x172E610 VA: 0x18172FC10
	|-EqualityComparer<ResourceHandle>.CreateComparer
	|
	|-RVA: 0x1724D10 Offset: 0x1723710 VA: 0x181724D10
	|-EqualityComparer<ResourceLocator>.CreateComparer
	|
	|-RVA: 0x1720080 Offset: 0x171EA80 VA: 0x181720080
	|-EqualityComparer<RpcLink>.CreateComparer
	|
	|-RVA: 0x1719320 Offset: 0x1717D20 VA: 0x181719320
	|-EqualityComparer<RpcLinkType>.CreateComparer
	|
	|-RVA: 0x1715C70 Offset: 0x1714670 VA: 0x181715C70
	|-EqualityComparer<RuleMatcher>.CreateComparer
	|
	|-RVA: 0x172C560 Offset: 0x172AF60 VA: 0x18172C560
	|-EqualityComparer<sbyte>.CreateComparer
	|
	|-RVA: 0x1719E10 Offset: 0x1718810 VA: 0x181719E10
	|-EqualityComparer<SamplePointUData>.CreateComparer
	|
	|-RVA: 0x17262F0 Offset: 0x1724CF0 VA: 0x1817262F0
	|-EqualityComparer<SamplePointsPatch>.CreateComparer
	|
	|-RVA: 0x17130B0 Offset: 0x1711AB0 VA: 0x1817130B0
	|-EqualityComparer<Scene>.CreateComparer
	|
	|-RVA: 0x1721660 Offset: 0x1720060 VA: 0x181721660
	|-EqualityComparer<SelectorMatchRecord>.CreateComparer
	|
	|-RVA: 0x171BEE0 Offset: 0x171A8E0 VA: 0x18171BEE0
	|-EqualityComparer<ShaderTagId>.CreateComparer
	|
	|-RVA: 0x1716760 Offset: 0x1715160 VA: 0x181716760
	|-EqualityComparer<float>.CreateComparer
	|
	|-RVA: 0x1720B70 Offset: 0x171F570 VA: 0x181720B70
	|-EqualityComparer<SpriteState>.CreateComparer
	|
	|-RVA: 0x171DFB0 Offset: 0x171C9B0 VA: 0x18171DFB0
	|-EqualityComparer<StylePropertyName>.CreateComparer
	|
	|-RVA: 0x171C9D0 Offset: 0x171B3D0 VA: 0x18171C9D0
	|-EqualityComparer<StylePropertyValue>.CreateComparer
	|
	|-RVA: 0x1730700 Offset: 0x172F100 VA: 0x181730700
	|-EqualityComparer<StyleSelectorPart>.CreateComparer
	|
	|-RVA: 0x1714690 Offset: 0x1713090 VA: 0x181714690
	|-EqualityComparer<StyleSyntaxToken>.CreateComparer
	|
	|-RVA: 0x172AF80 Offset: 0x1729980 VA: 0x18172AF80
	|-EqualityComparer<StyleValue>.CreateComparer
	|
	|-RVA: 0x1745160 Offset: 0x1743B60 VA: 0x181745160
	|-EqualityComparer<StyleValueManaged>.CreateComparer
	|
	|-RVA: 0x174BEC0 Offset: 0x174A8C0 VA: 0x18174BEC0
	|-EqualityComparer<StyleVariable>.CreateComparer
	|
	|-RVA: 0x1745C50 Offset: 0x1744650 VA: 0x181745C50
	|-EqualityComparer<Substring>.CreateComparer
	|
	|-RVA: 0x1753730 Offset: 0x1752130 VA: 0x181753730
	|-EqualityComparer<TerrainTileCoord>.CreateComparer
	|
	|-RVA: 0x17360C0 Offset: 0x1734AC0 VA: 0x1817360C0
	|-EqualityComparer<TextureId>.CreateComparer
	|
	|-RVA: 0x173B840 Offset: 0x173A240 VA: 0x18173B840
	|-EqualityComparer<TimeSpan>.CreateComparer
	|
	|-RVA: 0x1748810 Offset: 0x1747210 VA: 0x181748810
	|-EqualityComparer<TimeValue>.CreateComparer
	|
	|-RVA: 0x174D4A0 Offset: 0x174BEA0 VA: 0x18174D4A0
	|-EqualityComparer<TreeItem>.CreateComparer
	|
	|-RVA: 0x1747D20 Offset: 0x1746720 VA: 0x181747D20
	|-EqualityComparer<TreeViewItemWrapper>.CreateComparer
	|
	|-RVA: 0x173EEF0 Offset: 0x173D8F0 VA: 0x18173EEF0
	|-EqualityComparer<UICharInfo>.CreateComparer
	|
	|-RVA: 0x1738190 Offset: 0x1736B90 VA: 0x181738190
	|-EqualityComparer<UILineInfo>.CreateComparer
	|
	|-RVA: 0x1741AB0 Offset: 0x17404B0 VA: 0x181741AB0
	|-EqualityComparer<UIVertex>.CreateComparer
	|
	|-RVA: 0x173D910 Offset: 0x173C310 VA: 0x18173D910
	|-EqualityComparer<ushort>.CreateComparer
	|
	|-RVA: 0x173F9E0 Offset: 0x173E3E0 VA: 0x18173F9E0
	|-EqualityComparer<uint>.CreateComparer
	|
	|-RVA: 0x1752130 Offset: 0x1750B30 VA: 0x181752130
	|-EqualityComparer<UInt32Enum>.CreateComparer
	|
	|-RVA: 0x1740FC0 Offset: 0x173F9C0 VA: 0x181740FC0
	|-EqualityComparer<ulong>.CreateComparer
	|
	|-RVA: 0x1743B80 Offset: 0x1742580 VA: 0x181743B80
	|-EqualityComparer<UShort2>.CreateComparer
	|
	|-RVA: 0x174DF90 Offset: 0x174C990 VA: 0x18174DF90
	|-EqualityComparer<UnloadedScene>.CreateComparer
	|
	|-RVA: 0x1750060 Offset: 0x174EA60 VA: 0x181750060
	|-EqualityComparer<UsageHint>.CreateComparer
	|
	|-RVA: 0x173AD50 Offset: 0x1739750 VA: 0x18173AD50
	|-EqualityComparer<Vector2>.CreateComparer
	|
	|-RVA: 0x1736BB0 Offset: 0x17355B0 VA: 0x181736BB0
	|-EqualityComparer<Vector2Int>.CreateComparer
	|
	|-RVA: 0x173E400 Offset: 0x173CE00 VA: 0x18173E400
	|-EqualityComparer<Vector3>.CreateComparer
	|
	|-RVA: 0x1750B50 Offset: 0x174F550 VA: 0x181750B50
	|-EqualityComparer<Vector3Int>.CreateComparer
	|
	|-RVA: 0x1751640 Offset: 0x1750040 VA: 0x181751640
	|-EqualityComparer<Vector4>.CreateComparer
	|
	|-RVA: 0x174EA80 Offset: 0x174D480 VA: 0x18174EA80
	|-EqualityComparer<VoxelContour>.CreateComparer
	|
	|-RVA: 0x1749300 Offset: 0x1747D00 VA: 0x181749300
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.CreateComparer
	|
	|-RVA: 0x174C9B0 Offset: 0x174B3B0 VA: 0x18174C9B0
	|-EqualityComparer<X509ChainStatus>.CreateComparer
	|
	|-RVA: 0x174A8E0 Offset: 0x17492E0 VA: 0x18174A8E0
	|-EqualityComparer<XPathNodeRef>.CreateComparer
	|
	|-RVA: 0x1746740 Offset: 0x1745140 VA: 0x181746740
	|-EqualityComparer<XRFeatureDescriptor>.CreateComparer
	|
	|-RVA: 0x1739770 Offset: 0x1738170 VA: 0x181739770
	|-EqualityComparer<XRView>.CreateComparer
	|
	|-RVA: 0x17376A0 Offset: 0x17360A0 VA: 0x1817376A0
	|-EqualityComparer<ZipGenericExtraField>.CreateComparer
	|
	|-RVA: 0x1752C20 Offset: 0x1751620 VA: 0x181752C20
	|-EqualityComparer<__Il2CppFullySharedGenericType>.CreateComparer
	|
	|-RVA: 0x1754220 Offset: 0x1752C20 VA: 0x181754220
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.CreateComparer
	|
	|-RVA: 0x17355D0 Offset: 0x1733FD0 VA: 0x1817355D0
	|-EqualityComparer<AdvancedSmooth.Turn>.CreateComparer
	|
	|-RVA: 0x17425A0 Offset: 0x1740FA0 VA: 0x1817425A0
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.CreateComparer
	|
	|-RVA: 0x173C330 Offset: 0x173AD30 VA: 0x18173C330
	|-EqualityComparer<AvatarSettings.LayerSetting>.CreateComparer
	|
	|-RVA: 0x1744670 Offset: 0x1743070 VA: 0x181744670
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.CreateComparer
	|
	|-RVA: 0x173A260 Offset: 0x1738C60 VA: 0x18173A260
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.CreateComparer
	|
	|-RVA: 0x173CE20 Offset: 0x173B820 VA: 0x18173CE20
	|-EqualityComparer<BitmapAllocator32.Page>.CreateComparer
	|
	|-RVA: 0x174F570 Offset: 0x174DF70 VA: 0x18174F570
	|-EqualityComparer<CameraState.CustomBlendable>.CreateComparer
	|
	|-RVA: 0x17404D0 Offset: 0x173EED0 VA: 0x1817404D0
	|-EqualityComparer<CinemachineClearShot.Pair>.CreateComparer
	|
	|-RVA: 0x1749DF0 Offset: 0x17487F0 VA: 0x181749DF0
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.CreateComparer
	|
	|-RVA: 0x1747230 Offset: 0x1745C30 VA: 0x181747230
	|-EqualityComparer<ClipperLib.DoublePoint>.CreateComparer
	|
	|-RVA: 0x1738C80 Offset: 0x1737680 VA: 0x181738C80
	|-EqualityComparer<ClipperLib.IntPoint>.CreateComparer
	|
	|-RVA: 0x174B3D0 Offset: 0x1749DD0 VA: 0x18174B3D0
	|-EqualityComparer<ConfinerOven.PolygonSolution>.CreateComparer
	|
	|-RVA: 0x1743090 Offset: 0x1741A90 VA: 0x181743090
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.CreateComparer
	|
	|-RVA: 0x1764BA0 Offset: 0x17635A0 VA: 0x181764BA0
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.CreateComparer
	|
	|-RVA: 0x17772F0 Offset: 0x1775CF0 VA: 0x1817772F0
	|-EqualityComparer<EventDispatcher.DispatchContext>.CreateComparer
	|
	|-RVA: 0x175FF10 Offset: 0x175E910 VA: 0x18175FF10
	|-EqualityComparer<EventDispatcher.EventRecord>.CreateComparer
	|
	|-RVA: 0x17640B0 Offset: 0x1762AB0 VA: 0x1817640B0
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.CreateComparer
	|
	|-RVA: 0x17614F0 Offset: 0x175FEF0 VA: 0x1817614F0
	|-EqualityComparer<FocusController.FocusedElement>.CreateComparer
	|
	|-RVA: 0x1766180 Offset: 0x1764B80 VA: 0x181766180
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.CreateComparer
	|
	|-RVA: 0x175BD70 Offset: 0x175A770 VA: 0x18175BD70
	|-EqualityComparer<Funnel.PathPart>.CreateComparer
	|
	|-RVA: 0x175B280 Offset: 0x1759C80 VA: 0x18175B280
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.CreateComparer
	|
	|-RVA: 0x1768250 Offset: 0x1766C50 VA: 0x181768250
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.CreateComparer
	|
	|-RVA: 0x176D9D0 Offset: 0x176C3D0 VA: 0x18176D9D0
	|-EqualityComparer<HID.HIDCollectionDescriptor>.CreateComparer
	|
	|-RVA: 0x1775D10 Offset: 0x1774710 VA: 0x181775D10
	|-EqualityComparer<HID.HIDElementDescriptor>.CreateComparer
	|
	|-RVA: 0x17788D0 Offset: 0x17772D0 VA: 0x1817788D0
	|-EqualityComparer<HIDParser.HIDReportData>.CreateComparer
	|
	|-RVA: 0x17635C0 Offset: 0x1761FC0 VA: 0x1817635C0
	|-EqualityComparer<HIDSupport.HIDPageUsage>.CreateComparer
	|
	|-RVA: 0x176CEE0 Offset: 0x176B8E0 VA: 0x18176CEE0
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.CreateComparer
	|
	|-RVA: 0x176C3F0 Offset: 0x176ADF0 VA: 0x18176C3F0
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.CreateComparer
	|
	|-RVA: 0x175E930 Offset: 0x175D330 VA: 0x18175E930
	|-EqualityComparer<InputControlLayout.ControlItem>.CreateComparer
	|
	|-RVA: 0x1772660 Offset: 0x1771060 VA: 0x181772660
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.CreateComparer
	|
	|-RVA: 0x1760A00 Offset: 0x175F400 VA: 0x181760A00
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.CreateComparer
	|
	|-RVA: 0x1776800 Offset: 0x1775200 VA: 0x181776800
	|-EqualityComparer<InputTransformSpots.TransformSpot>.CreateComparer
	|
	|-RVA: 0x1766C70 Offset: 0x1765670 VA: 0x181766C70
	|-EqualityComparer<InputUser.OngoingAccountSelection>.CreateComparer
	|
	|-RVA: 0x1765690 Offset: 0x1764090 VA: 0x181765690
	|-EqualityComparer<JsonParser.JsonValue>.CreateComparer
	|
	|-RVA: 0x1773150 Offset: 0x1771B50 VA: 0x181773150
	|-EqualityComparer<LatencySimulator.Message>.CreateComparer
	|
	|-RVA: 0x176B900 Offset: 0x176A300 VA: 0x18176B900
	|-EqualityComparer<LiquidVolume.MeshCache>.CreateComparer
	|
	|-RVA: 0x1773C40 Offset: 0x1772640 VA: 0x181773C40
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.CreateComparer
	|
	|-RVA: 0x176FAA0 Offset: 0x176E4A0 VA: 0x18176FAA0
	|-EqualityComparer<Multipass.TransportIdData>.CreateComparer
	|
	|-RVA: 0x175C860 Offset: 0x175B260 VA: 0x18175C860
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.CreateComparer
	|
	|-RVA: 0x175A790 Offset: 0x1759190 VA: 0x18175A790
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.CreateComparer
	|
	|-RVA: 0x1777DE0 Offset: 0x17767E0 VA: 0x181777DE0
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.CreateComparer
	|
	|-RVA: 0x1771B70 Offset: 0x1770570 VA: 0x181771B70
	|-EqualityComparer<NetworkAnimator.StateChange>.CreateComparer
	|
	|-RVA: 0x1767760 Offset: 0x1766160 VA: 0x181767760
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.CreateComparer
	|
	|-RVA: 0x176E4C0 Offset: 0x176CEC0 VA: 0x18176E4C0
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.CreateComparer
	|
	|-RVA: 0x176EFB0 Offset: 0x176D9B0 VA: 0x18176EFB0
	|-EqualityComparer<ObjectPool.DelayedStoreData>.CreateComparer
	|
	|-RVA: 0x1775220 Offset: 0x1773C20 VA: 0x181775220
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.CreateComparer
	|
	|-RVA: 0x1769830 Offset: 0x1768230 VA: 0x181769830
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.CreateComparer
	|
	|-RVA: 0x175F420 Offset: 0x175DE20 VA: 0x18175F420
	|-EqualityComparer<PlayingCard.CardData>.CreateComparer
	|
	|-RVA: 0x1770590 Offset: 0x176EF90 VA: 0x181770590
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.CreateComparer
	|
	|-RVA: 0x176AE10 Offset: 0x1769810 VA: 0x18176AE10
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.CreateComparer
	|
	|-RVA: 0x1771080 Offset: 0x176FA80 VA: 0x181771080
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.CreateComparer
	|
	|-RVA: 0x175D350 Offset: 0x175BD50 VA: 0x18175D350
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.CreateComparer
	|
	|-RVA: 0x1774730 Offset: 0x1773130 VA: 0x181774730
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.CreateComparer
	|
	|-RVA: 0x1759CA0 Offset: 0x17586A0 VA: 0x181759CA0
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.CreateComparer
	|
	|-RVA: 0x1768D40 Offset: 0x1767740 VA: 0x181768D40
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.CreateComparer
	|
	|-RVA: 0x1761FE0 Offset: 0x17609E0 VA: 0x181761FE0
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.CreateComparer
	|
	|-RVA: 0x176A320 Offset: 0x1768D20 VA: 0x18176A320
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.CreateComparer
	|
	|-RVA: 0x1762AD0 Offset: 0x17614D0 VA: 0x181762AD0
	|-EqualityComparer<Regex.CachedCodeEntryKey>.CreateComparer
	|
	|-RVA: 0x175DE40 Offset: 0x175C840 VA: 0x18175DE40
	|-EqualityComparer<RegexCharClass.SingleRange>.CreateComparer
	|
	|-RVA: 0x1783810 Offset: 0x1782210 VA: 0x181783810
	|-EqualityComparer<RenderChain.RenderNodeData>.CreateComparer
	|
	|-RVA: 0x17933A0 Offset: 0x1791DA0 VA: 0x1817933A0
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.CreateComparer
	|
	|-RVA: 0x17879B0 Offset: 0x17863B0 VA: 0x1817879B0
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.CreateComparer
	|
	|-RVA: 0x1799610 Offset: 0x1798010 VA: 0x181799610
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.CreateComparer
	|
	|-RVA: 0x178B060 Offset: 0x1789A60 VA: 0x18178B060
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.CreateComparer
	|
	|-RVA: 0x177E090 Offset: 0x177CA90 VA: 0x18177E090
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.CreateComparer
	|
	|-RVA: 0x179CCC0 Offset: 0x179B6C0 VA: 0x18179CCC0
	|-EqualityComparer<RigidbodyPrediction.MoveData>.CreateComparer
	|
	|-RVA: 0x178F200 Offset: 0x178DC00 VA: 0x18178F200
	|-EqualityComparer<SVGDocument.ClipData>.CreateComparer
	|
	|-RVA: 0x17928B0 Offset: 0x17912B0 VA: 0x1817928B0
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.CreateComparer
	|
	|-RVA: 0x1798B20 Offset: 0x1797520 VA: 0x181798B20
	|-EqualityComparer<SVGDocument.MaskData>.CreateComparer
	|
	|-RVA: 0x1780160 Offset: 0x177EB60 VA: 0x181780160
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.CreateComparer
	|
	|-RVA: 0x178FCF0 Offset: 0x178E6F0 VA: 0x18178FCF0
	|-EqualityComparer<SVGDocument.NodeReferenceData>.CreateComparer
	|
	|-RVA: 0x179B6E0 Offset: 0x179A0E0 VA: 0x18179B6E0
	|-EqualityComparer<SVGDocument.NodeWithParent>.CreateComparer
	|
	|-RVA: 0x1789A80 Offset: 0x1788480 VA: 0x181789A80
	|-EqualityComparer<SVGDocument.PatternData>.CreateComparer
	|
	|-RVA: 0x1795F60 Offset: 0x1794960 VA: 0x181795F60
	|-EqualityComparer<SVGDocument.PostponedClip>.CreateComparer
	|
	|-RVA: 0x1796A50 Offset: 0x1795450 VA: 0x181796A50
	|-EqualityComparer<SVGDocument.PostponedStopData>.CreateComparer
	|
	|-RVA: 0x1780C50 Offset: 0x177F650 VA: 0x181780C50
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.CreateComparer
	|
	|-RVA: 0x1784300 Offset: 0x1782D00 VA: 0x181784300
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.CreateComparer
	|
	|-RVA: 0x17863D0 Offset: 0x1784DD0 VA: 0x1817863D0
	|-EqualityComparer<ServerSocket.ConnectionChange>.CreateComparer
	|
	|-RVA: 0x179C1D0 Offset: 0x179ABD0 VA: 0x18179C1D0
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.CreateComparer
	|
	|-RVA: 0x1781740 Offset: 0x1780140 VA: 0x181781740
	|-EqualityComparer<ShadowUtility.Edge>.CreateComparer
	|
	|-RVA: 0x177F670 Offset: 0x177E070 VA: 0x18177F670
	|-EqualityComparer<StructySync.ChangeData>.CreateComparer
	|
	|-RVA: 0x1784DF0 Offset: 0x17837F0 VA: 0x181784DF0
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.CreateComparer
	|
	|-RVA: 0x178D130 Offset: 0x178BB30 VA: 0x18178D130
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.CreateComparer
	|
	|-RVA: 0x178BB50 Offset: 0x178A550 VA: 0x18178BB50
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.CreateComparer
	|
	|-RVA: 0x178C640 Offset: 0x178B040 VA: 0x18178C640
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.CreateComparer
	|
	|-RVA: 0x178E710 Offset: 0x178D110 VA: 0x18178E710
	|-EqualityComparer<SyncStopwatch.ChangeData>.CreateComparer
	|
	|-RVA: 0x178A570 Offset: 0x1788F70 VA: 0x18178A570
	|-EqualityComparer<SyncTimer.ChangeData>.CreateComparer
	|
	|-RVA: 0x177EB80 Offset: 0x177D580 VA: 0x18177EB80
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.CreateComparer
	|
	|-RVA: 0x179ABF0 Offset: 0x17995F0 VA: 0x18179ABF0
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.CreateComparer
	|
	|-RVA: 0x178DC20 Offset: 0x178C620 VA: 0x18178DC20
	|-EqualityComparer<TargetStateListener.Callback>.CreateComparer
	|
	|-RVA: 0x1793E90 Offset: 0x1792890 VA: 0x181793E90
	|-EqualityComparer<TemplateAsset.AttributeOverride>.CreateComparer
	|
	|-RVA: 0x1797540 Offset: 0x1795F40 VA: 0x181797540
	|-EqualityComparer<TextResourceManager.FontAssetRef>.CreateComparer
	|
	|-RVA: 0x1786EC0 Offset: 0x17858C0 VA: 0x181786EC0
	|-EqualityComparer<TextSettings.FontReferenceMap>.CreateComparer
	|
	|-RVA: 0x1791DC0 Offset: 0x17907C0 VA: 0x181791DC0
	|-EqualityComparer<TextureBlitter.BlitInfo>.CreateComparer
	|
	|-RVA: 0x17858E0 Offset: 0x17842E0 VA: 0x1817858E0
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.CreateComparer
	|
	|-RVA: 0x1782230 Offset: 0x1780C30 VA: 0x181782230
	|-EqualityComparer<TextureRegistry.TextureInfo>.CreateComparer
	|
	|-RVA: 0x1782D20 Offset: 0x1781720 VA: 0x181782D20
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.CreateComparer
	|
	|-RVA: 0x1788F90 Offset: 0x1787990 VA: 0x181788F90
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.CreateComparer
	|
	|-RVA: 0x17907E0 Offset: 0x178F1E0 VA: 0x1817907E0
	|-EqualityComparer<TransportManager.DisconnectingClient>.CreateComparer
	|
	|-RVA: 0x17912D0 Offset: 0x178FCD0 VA: 0x1817912D0
	|-EqualityComparer<UIRStylePainter.Entry>.CreateComparer
	|
	|-RVA: 0x1794980 Offset: 0x1793380 VA: 0x181794980
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.CreateComparer
	|
	|-RVA: 0x179A100 Offset: 0x1798B00 VA: 0x18179A100
	|-EqualityComparer<UIRenderDevice.AllocToFree>.CreateComparer
	|
	|-RVA: 0x1798030 Offset: 0x1796A30 VA: 0x181798030
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.CreateComparer
	|
	|-RVA: 0x17884A0 Offset: 0x1786EA0 VA: 0x1817884A0
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.CreateComparer
	|
	|-RVA: 0x1795470 Offset: 0x1793E70 VA: 0x181795470
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.CreateComparer
	|
	|-RVA: 0x17A6B00 Offset: 0x17A5500 VA: 0x1817A6B00
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.CreateComparer
	|
	|-RVA: 0x17A4A30 Offset: 0x17A3430 VA: 0x1817A4A30
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.CreateComparer
	|
	|-RVA: 0x17A96C0 Offset: 0x17A80C0 VA: 0x1817A96C0
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.CreateComparer
	|
	|-RVA: 0x17A1380 Offset: 0x179FD80 VA: 0x1817A1380
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.CreateComparer
	|
	|-RVA: 0x17AA1B0 Offset: 0x17A8BB0 VA: 0x1817AA1B0
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.CreateComparer
	|
	|-RVA: 0x17A5520 Offset: 0x17A3F20 VA: 0x1817A5520
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CreateComparer
	|
	|-RVA: 0x17A2960 Offset: 0x17A1360 VA: 0x1817A2960
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.CreateComparer
	|
	|-RVA: 0x17A1E70 Offset: 0x17A0870 VA: 0x1817A1E70
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.CreateComparer
	|
	|-RVA: 0x17A3450 Offset: 0x17A1E50 VA: 0x1817A3450
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.CreateComparer
	|
	|-RVA: 0x17A6010 Offset: 0x17A4A10 VA: 0x1817A6010
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.CreateComparer
	|
	|-RVA: 0x17A75F0 Offset: 0x17A5FF0 VA: 0x1817A75F0
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.CreateComparer
	|
	|-RVA: 0x17A0890 Offset: 0x179F290 VA: 0x1817A0890
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.CreateComparer
	|
	|-RVA: 0x17A3F40 Offset: 0x17A2940 VA: 0x1817A3F40
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.CreateComparer
	|
	|-RVA: 0x17A80E0 Offset: 0x17A6AE0 VA: 0x1817A80E0
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.CreateComparer
	|
	|-RVA: 0x17A8BD0 Offset: 0x17A75D0 VA: 0x1817A8BD0
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.CreateComparer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Equals(T x, T y);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetHashCode(T obj);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16C3D70 Offset: 0x16C2770 VA: 0x1816C3D70
	|-EqualityComparer<ArraySegment<byte>>.IndexOf
	|-EqualityComparer<SyncList.CachedOnChange<int>>.IndexOf
	|-EqualityComparer<KeyValuePair<int, object>>.IndexOf
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.IndexOf
	|-EqualityComparer<KeyValuePair<object, bool>>.IndexOf
	|-EqualityComparer<KeyValuePair<object, char>>.IndexOf
	|-EqualityComparer<KeyValuePair<object, object>>.IndexOf
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.IndexOf
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.IndexOf
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.IndexOf
	|-EqualityComparer<NativeArray<NudgeJobData>>.IndexOf
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.IndexOf
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.IndexOf
	|-EqualityComparer<NativeSlice<NudgeJobData>>.IndexOf
	|-EqualityComparer<Nullable<DateTime>>.IndexOf
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|-EqualityComparer<StructMultiKey<object, object>>.IndexOf
	|-EqualityComparer<SubArray<int>>.IndexOf
	|-EqualityComparer<ValueTuple<int, object>>.IndexOf
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.IndexOf
	|-EqualityComparer<ValueTuple<IntPtr, object>>.IndexOf
	|-EqualityComparer<ValueTuple<object, int>>.IndexOf
	|-EqualityComparer<ValueTuple<object, object>>.IndexOf
	|-EqualityComparer<AsyncGPUReadbackRequest>.IndexOf
	|-EqualityComparer<BezierContour>.IndexOf
	|-EqualityComparer<Color>.IndexOf
	|-EqualityComparer<Connection>.IndexOf
	|-EqualityComparer<CoordinateFootprintTilePair>.IndexOf
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.IndexOf
	|-EqualityComparer<CoordinateStorageTilePair>.IndexOf
	|-EqualityComparer<CoordinateTilePair>.IndexOf
	|-EqualityComparer<DateTimeOffset>.IndexOf
	|-EqualityComparer<Decimal>.IndexOf
	|-EqualityComparer<DualPrefab>.IndexOf
	|-EqualityComparer<Entry>.IndexOf
	|-EqualityComparer<EventSummary>.IndexOf
	|-EqualityComparer<FontDefinition>.IndexOf
	|-EqualityComparer<GlyphRect>.IndexOf
	|-EqualityComparer<Guid>.IndexOf
	|-EqualityComparer<Hash128>.IndexOf
	|-EqualityComparer<IntPoint>.IndexOf
	|-EqualityComparer<IntRect>.IndexOf
	|-EqualityComparer<InternedString>.IndexOf
	|-EqualityComparer<InterpretedFrameInfo>.IndexOf
	|-EqualityComparer<LigatureSubstitutionRecord>.IndexOf
	|-EqualityComparer<LigatureSubstitutionRecord>.IndexOf
	|-EqualityComparer<LocalPacket>.IndexOf
	|-EqualityComparer<LocalPacket>.IndexOf
	|-EqualityComparer<MultipleSubstitutionRecord>.IndexOf
	|-EqualityComparer<MultipleSubstitutionRecord>.IndexOf
	|-EqualityComparer<Playable>.IndexOf
	|-EqualityComparer<Quaternion>.IndexOf
	|-EqualityComparer<RangePositionInfo>.IndexOf
	|-EqualityComparer<Rect>.IndexOf
	|-EqualityComparer<RectInt>.IndexOf
	|-EqualityComparer<RenderInstancedDataLayout>.IndexOf
	|-EqualityComparer<Resolution>.IndexOf
	|-EqualityComparer<ResourceLocator>.IndexOf
	|-EqualityComparer<RpcLink>.IndexOf
	|-EqualityComparer<RuleMatcher>.IndexOf
	|-EqualityComparer<SamplePointUData>.IndexOf
	|-EqualityComparer<StylePropertyName>.IndexOf
	|-EqualityComparer<StylePropertyValue>.IndexOf
	|-EqualityComparer<StyleValueManaged>.IndexOf
	|-EqualityComparer<Substring>.IndexOf
	|-EqualityComparer<TreeItem>.IndexOf
	|-EqualityComparer<UILineInfo>.IndexOf
	|-EqualityComparer<UnloadedScene>.IndexOf
	|-EqualityComparer<Vector4>.IndexOf
	|-EqualityComparer<X509ChainStatus>.IndexOf
	|-EqualityComparer<XPathNodeRef>.IndexOf
	|-EqualityComparer<ZipGenericExtraField>.IndexOf
	|-EqualityComparer<AdvancedSmooth.Turn>.IndexOf
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.IndexOf
	|-EqualityComparer<CameraState.CustomBlendable>.IndexOf
	|-EqualityComparer<ClipperLib.IntPoint>.IndexOf
	|-EqualityComparer<ConfinerOven.PolygonSolution>.IndexOf
	|-EqualityComparer<EventDispatcher.DispatchContext>.IndexOf
	|-EqualityComparer<EventDispatcher.EventRecord>.IndexOf
	|-EqualityComparer<FocusController.FocusedElement>.IndexOf
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.IndexOf
	|-EqualityComparer<InputTransformSpots.TransformSpot>.IndexOf
	|-EqualityComparer<InputUser.OngoingAccountSelection>.IndexOf
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.IndexOf
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.IndexOf
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.IndexOf
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.IndexOf
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.IndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.IndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.IndexOf
	|-EqualityComparer<RigidbodyPrediction.MoveData>.IndexOf
	|-EqualityComparer<SVGDocument.NodeWithParent>.IndexOf
	|-EqualityComparer<ServerSocket.ConnectionChange>.IndexOf
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.IndexOf
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.IndexOf
	|-EqualityComparer<TargetStateListener.Callback>.IndexOf
	|-EqualityComparer<TextSettings.FontReferenceMap>.IndexOf
	|-EqualityComparer<TextureRegistry.TextureInfo>.IndexOf
	|-EqualityComparer<TransportManager.DisconnectingClient>.IndexOf
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.IndexOf
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.IndexOf
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.IndexOf
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.IndexOf
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.IndexOf
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.IndexOf
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.IndexOf
	|
	|-RVA: 0x16C41E0 Offset: 0x16C2BE0 VA: 0x1816C41E0
	|-EqualityComparer<SyncList.ChangeData<int>>.IndexOf
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.IndexOf
	|-EqualityComparer<BackgroundPosition>.IndexOf
	|-EqualityComparer<DuplicateSamplePoint>.IndexOf
	|-EqualityComparer<Int3>.IndexOf
	|-EqualityComparer<IntRegion>.IndexOf
	|-EqualityComparer<ManipulatorActivationFilter>.IndexOf
	|-EqualityComparer<UICharInfo>.IndexOf
	|-EqualityComparer<Vector3>.IndexOf
	|-EqualityComparer<Vector3Int>.IndexOf
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.IndexOf
	|-EqualityComparer<HIDParser.HIDReportData>.IndexOf
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.IndexOf
	|-EqualityComparer<SyncTimer.ChangeData>.IndexOf
	|
	|-RVA: 0x16C3FE0 Offset: 0x16C29E0 VA: 0x1816C3FE0
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.IndexOf
	|-EqualityComparer<KeyValuePair<int, int>>.IndexOf
	|-EqualityComparer<ValueTuple<int, int>>.IndexOf
	|-EqualityComparer<ValueTuple<int, Scene>>.IndexOf
	|-EqualityComparer<AnimatorClipInfo>.IndexOf
	|-EqualityComparer<BackgroundRepeat>.IndexOf
	|-EqualityComparer<CSteamID>.IndexOf
	|-EqualityComparer<DateTime>.IndexOf
	|-EqualityComparer<FullRank>.IndexOf
	|-EqualityComparer<GCHandle>.IndexOf
	|-EqualityComparer<InputEventPtr>.IndexOf
	|-EqualityComparer<Int2>.IndexOf
	|-EqualityComparer<RendererListHandle>.IndexOf
	|-EqualityComparer<ResourceHandle>.IndexOf
	|-EqualityComparer<RpcLinkType>.IndexOf
	|-EqualityComparer<SamplePointsPatch>.IndexOf
	|-EqualityComparer<TerrainTileCoord>.IndexOf
	|-EqualityComparer<TimeSpan>.IndexOf
	|-EqualityComparer<TimeValue>.IndexOf
	|-EqualityComparer<UsageHint>.IndexOf
	|-EqualityComparer<Vector2Int>.IndexOf
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.IndexOf
	|-EqualityComparer<BitmapAllocator32.Page>.IndexOf
	|-EqualityComparer<CinemachineClearShot.Pair>.IndexOf
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.IndexOf
	|-EqualityComparer<HIDSupport.HIDPageUsage>.IndexOf
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.IndexOf
	|-EqualityComparer<Multipass.TransportIdData>.IndexOf
	|-EqualityComparer<ObjectPool.DelayedStoreData>.IndexOf
	|-EqualityComparer<PlayingCard.CardData>.IndexOf
	|-EqualityComparer<SVGDocument.PostponedClip>.IndexOf
	|-EqualityComparer<SVGDocument.PostponedStopData>.IndexOf
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.IndexOf
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.IndexOf
	|-EqualityComparer<SyncStopwatch.ChangeData>.IndexOf
	|
	|-RVA: 0x16C3E40 Offset: 0x16C2840 VA: 0x1816C3E40
	|-EqualityComparer<IntervalTree.Entry<object>>.IndexOf
	|-EqualityComparer<KeyValuePair<Rect, object>>.IndexOf
	|-EqualityComparer<Nullable<Decimal>>.IndexOf
	|-EqualityComparer<TempAllocator.Page<ushort>>.IndexOf
	|-EqualityComparer<TempAllocator.Page<Vertex>>.IndexOf
	|-EqualityComparer<TreeViewItemData<object>>.IndexOf
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.IndexOf
	|-EqualityComparer<ValueTuple<object, object, object>>.IndexOf
	|-EqualityComparer<BezierPathSegment>.IndexOf
	|-EqualityComparer<Bounds>.IndexOf
	|-EqualityComparer<BoundsInt>.IndexOf
	|-EqualityComparer<Color>.IndexOf
	|-EqualityComparer<ComputedTransitionProperty>.IndexOf
	|-EqualityComparer<ContourVertex>.IndexOf
	|-EqualityComparer<CoordinateProceduralTilePair>.IndexOf
	|-EqualityComparer<FrameTimeSample>.IndexOf
	|-EqualityComparer<IntervalTreeNode>.IndexOf
	|-EqualityComparer<JsonPosition>.IndexOf
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.IndexOf
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.IndexOf
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.IndexOf
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.IndexOf
	|-EqualityComparer<NameAndParameters>.IndexOf
	|-EqualityComparer<NamedValue>.IndexOf
	|-EqualityComparer<Packet>.IndexOf
	|-EqualityComparer<RendererList>.IndexOf
	|-EqualityComparer<SelectorMatchRecord>.IndexOf
	|-EqualityComparer<StyleSelectorPart>.IndexOf
	|-EqualityComparer<StyleSyntaxToken>.IndexOf
	|-EqualityComparer<StyleValue>.IndexOf
	|-EqualityComparer<StyleVariable>.IndexOf
	|-EqualityComparer<TreeViewItemWrapper>.IndexOf
	|-EqualityComparer<XRFeatureDescriptor>.IndexOf
	|-EqualityComparer<AvatarSettings.LayerSetting>.IndexOf
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.IndexOf
	|-EqualityComparer<HID.HIDCollectionDescriptor>.IndexOf
	|-EqualityComparer<LatencySimulator.Message>.IndexOf
	|-EqualityComparer<LiquidVolume.MeshCache>.IndexOf
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.IndexOf
	|-EqualityComparer<Regex.CachedCodeEntryKey>.IndexOf
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.IndexOf
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.IndexOf
	|-EqualityComparer<StructySync.ChangeData>.IndexOf
	|-EqualityComparer<TemplateAsset.AttributeOverride>.IndexOf
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.IndexOf
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.IndexOf
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.IndexOf
	|
	|-RVA: 0x16C40A0 Offset: 0x16C2AA0 VA: 0x1816C40A0
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.IndexOf
	|-EqualityComparer<RaycastResult>.IndexOf
	|-EqualityComparer<UIRStylePainter.Entry>.IndexOf
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.IndexOf
	|
	|-RVA: 0x16C3F40 Offset: 0x16C2940 VA: 0x1816C3F40
	|-EqualityComparer<ValueTuple<bool>>.IndexOf
	|-EqualityComparer<SVGDocument.ClipData>.IndexOf
	|
	|-RVA: 0x16E7AD0 Offset: 0x16E64D0 VA: 0x1816E7AD0
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.IndexOf
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.IndexOf
	|-EqualityComparer<NetworkAnimator.StateChange>.IndexOf
	|-EqualityComparer<SVGDocument.PatternData>.IndexOf
	|-EqualityComparer<ShadowUtility.Edge>.IndexOf
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x16E7E90 Offset: 0x16E6890 VA: 0x1816E7E90
	|-EqualityComparer<Background>.IndexOf
	|-EqualityComparer<BezierSegment>.IndexOf
	|-EqualityComparer<NativeAddr>.IndexOf
	|-EqualityComparer<NavMeshBuildMarkup>.IndexOf
	|-EqualityComparer<PlayableBinding>.IndexOf
	|-EqualityComparer<SpriteState>.IndexOf
	|-EqualityComparer<VoxelContour>.IndexOf
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.IndexOf
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.IndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.IndexOf
	|-EqualityComparer<SVGDocument.NodeReferenceData>.IndexOf
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.IndexOf
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.IndexOf
	|-EqualityComparer<TextResourceManager.FontAssetRef>.IndexOf
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.IndexOf
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.IndexOf
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.IndexOf
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.IndexOf
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.IndexOf
	|
	|-RVA: 0x16E7D30 Offset: 0x16E6730 VA: 0x1816E7D30
	|-EqualityComparer<bool>.IndexOf
	|-EqualityComparer<byte>.IndexOf
	|-EqualityComparer<ByteEnum>.IndexOf
	|-EqualityComparer<sbyte>.IndexOf
	|
	|-RVA: 0x16E78E0 Offset: 0x16E62E0 VA: 0x1816E78E0
	|-EqualityComparer<CGSpot>.IndexOf
	|-EqualityComparer<GlyphPairAdjustmentRecord>.IndexOf
	|-EqualityComparer<RaycastHit>.IndexOf
	|
	|-RVA: 0x16E7DD0 Offset: 0x16E67D0 VA: 0x1816E7DD0
	|-EqualityComparer<char>.IndexOf
	|-EqualityComparer<short>.IndexOf
	|-EqualityComparer<ushort>.IndexOf
	|
	|-RVA: 0x16E7F80 Offset: 0x16E6980 VA: 0x1816E7F80
	|-EqualityComparer<Color32>.IndexOf
	|-EqualityComparer<EasingFunction>.IndexOf
	|-EqualityComparer<HSteamNetConnection>.IndexOf
	|-EqualityComparer<LayerMask>.IndexOf
	|-EqualityComparer<Scene>.IndexOf
	|-EqualityComparer<ShaderTagId>.IndexOf
	|-EqualityComparer<TextureId>.IndexOf
	|-EqualityComparer<UShort2>.IndexOf
	|-EqualityComparer<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x16E7BD0 Offset: 0x16E65D0 VA: 0x1816E7BD0
	|-EqualityComparer<ColorBlock>.IndexOf
	|-EqualityComparer<ComputedStyle>.IndexOf
	|-EqualityComparer<InputBinding>.IndexOf
	|
	|-RVA: 0x16E7660 Offset: 0x16E6060 VA: 0x1816E7660
	|-EqualityComparer<CombineInstance>.IndexOf
	|
	|-RVA: 0x16E77E0 Offset: 0x16E61E0 VA: 0x1816E77E0
	|-EqualityComparer<ControlPointOption>.IndexOf
	|-EqualityComparer<RaycastHit2D>.IndexOf
	|-EqualityComparer<Funnel.PathPart>.IndexOf
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.IndexOf
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x16E8040 Offset: 0x16E6A40 VA: 0x1816E8040
	|-EqualityComparer<DisplayInfo>.IndexOf
	|-EqualityComparer<IntPoint>.IndexOf
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.IndexOf
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.IndexOf
	|
	|-RVA: 0x16E8150 Offset: 0x16E6B50 VA: 0x1816E8150
	|-EqualityComparer<double>.IndexOf
	|
	|-RVA: 0x16E7A00 Offset: 0x16E6400 VA: 0x1816E7A00
	|-EqualityComparer<DoublePoint>.IndexOf
	|-EqualityComparer<DoublePoint>.IndexOf
	|-EqualityComparer<ClipperLib.DoublePoint>.IndexOf
	|
	|-RVA: 0x170D900 Offset: 0x170C300 VA: 0x18170D900
	|-EqualityComparer<EnumData>.IndexOf
	|-EqualityComparer<Matrix4x4>.IndexOf
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x170DA30 Offset: 0x170C430 VA: 0x18170DA30
	|-EqualityComparer<InputDeviceDescription>.IndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.IndexOf
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.IndexOf
	|-EqualityComparer<TextureBlitter.BlitInfo>.IndexOf
	|
	|-RVA: 0x170DB60 Offset: 0x170C560 VA: 0x18170DB60
	|-EqualityComparer<int>.IndexOf
	|-EqualityComparer<Int32Enum>.IndexOf
	|-EqualityComparer<uint>.IndexOf
	|-EqualityComparer<UInt32Enum>.IndexOf
	|
	|-RVA: 0x170D840 Offset: 0x170C240 VA: 0x18170D840
	|-EqualityComparer<long>.IndexOf
	|-EqualityComparer<IntPtr>.IndexOf
	|-EqualityComparer<object>.IndexOf
	|-EqualityComparer<ulong>.IndexOf
	|
	|-RVA: 0x170D730 Offset: 0x170C130 VA: 0x18170D730
	|-EqualityComparer<Label>.IndexOf
	|-EqualityComparer<Navigation>.IndexOf
	|-EqualityComparer<PlayerLoopSystem>.IndexOf
	|-EqualityComparer<PlayerLoopSystemInternal>.IndexOf
	|-EqualityComparer<RenderTargetIdentifier>.IndexOf
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.IndexOf
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.IndexOf
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.IndexOf
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.IndexOf
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.IndexOf
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.IndexOf
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.IndexOf
	|-EqualityComparer<UIRenderDevice.AllocToFree>.IndexOf
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.IndexOf
	|
	|-RVA: 0x17312B0 Offset: 0x172FCB0 VA: 0x1817312B0
	|-EqualityComparer<NavMeshBuildSource>.IndexOf
	|-EqualityComparer<RenderChain.RenderNodeData>.IndexOf
	|
	|-RVA: 0x1731410 Offset: 0x172FE10 VA: 0x181731410
	|-EqualityComparer<PointerModel>.IndexOf
	|
	|-RVA: 0x17311F0 Offset: 0x172FBF0 VA: 0x1817311F0
	|-EqualityComparer<float>.IndexOf
	|
	|-RVA: 0x1754D10 Offset: 0x1753710 VA: 0x181754D10
	|-EqualityComparer<UIVertex>.IndexOf
	|
	|-RVA: 0x1754E90 Offset: 0x1753890 VA: 0x181754E90
	|-EqualityComparer<Vector2>.IndexOf
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.IndexOf
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.IndexOf
	|
	|-RVA: 0x17550C0 Offset: 0x1753AC0 VA: 0x1817550C0
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.IndexOf
	|
	|-RVA: 0x1755280 Offset: 0x1753C80 VA: 0x181755280
	|-EqualityComparer<XRView>.IndexOf
	|
	|-RVA: 0x1754F50 Offset: 0x1753950 VA: 0x181754F50
	|-EqualityComparer<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x17794B0 Offset: 0x1777EB0 VA: 0x1817794B0
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.IndexOf
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.IndexOf
	|
	|-RVA: 0x1779640 Offset: 0x1778040 VA: 0x181779640
	|-EqualityComparer<HID.HIDElementDescriptor>.IndexOf
	|-EqualityComparer<JsonParser.JsonValue>.IndexOf
	|
	|-RVA: 0x1779780 Offset: 0x1778180 VA: 0x181779780
	|-EqualityComparer<InputControlLayout.ControlItem>.IndexOf
	|
	|-RVA: 0x1779940 Offset: 0x1778340 VA: 0x181779940
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.IndexOf
	|-EqualityComparer<SVGDocument.MaskData>.IndexOf
	|
	|-RVA: 0x17793C0 Offset: 0x1777DC0 VA: 0x1817793C0
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16C4390 Offset: 0x16C2D90 VA: 0x1816C4390
	|-EqualityComparer<ArraySegment<byte>>.LastIndexOf
	|-EqualityComparer<SyncList.CachedOnChange<int>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<int, object>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<object, bool>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<object, char>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<object, object>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.LastIndexOf
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.LastIndexOf
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.LastIndexOf
	|-EqualityComparer<NativeArray<NudgeJobData>>.LastIndexOf
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.LastIndexOf
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.LastIndexOf
	|-EqualityComparer<NativeSlice<NudgeJobData>>.LastIndexOf
	|-EqualityComparer<Nullable<DateTime>>.LastIndexOf
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.LastIndexOf
	|-EqualityComparer<StructMultiKey<object, object>>.LastIndexOf
	|-EqualityComparer<SubArray<int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<int, object>>.LastIndexOf
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.LastIndexOf
	|-EqualityComparer<ValueTuple<IntPtr, object>>.LastIndexOf
	|-EqualityComparer<ValueTuple<object, int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<object, object>>.LastIndexOf
	|-EqualityComparer<AsyncGPUReadbackRequest>.LastIndexOf
	|-EqualityComparer<BezierContour>.LastIndexOf
	|-EqualityComparer<Color>.LastIndexOf
	|-EqualityComparer<Connection>.LastIndexOf
	|-EqualityComparer<CoordinateFootprintTilePair>.LastIndexOf
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.LastIndexOf
	|-EqualityComparer<CoordinateStorageTilePair>.LastIndexOf
	|-EqualityComparer<CoordinateTilePair>.LastIndexOf
	|-EqualityComparer<DateTimeOffset>.LastIndexOf
	|-EqualityComparer<Decimal>.LastIndexOf
	|-EqualityComparer<DualPrefab>.LastIndexOf
	|-EqualityComparer<Entry>.LastIndexOf
	|-EqualityComparer<EventSummary>.LastIndexOf
	|-EqualityComparer<FontDefinition>.LastIndexOf
	|-EqualityComparer<GlyphRect>.LastIndexOf
	|-EqualityComparer<Guid>.LastIndexOf
	|-EqualityComparer<Hash128>.LastIndexOf
	|-EqualityComparer<IntPoint>.LastIndexOf
	|-EqualityComparer<IntRect>.LastIndexOf
	|-EqualityComparer<InternedString>.LastIndexOf
	|-EqualityComparer<InterpretedFrameInfo>.LastIndexOf
	|-EqualityComparer<LigatureSubstitutionRecord>.LastIndexOf
	|-EqualityComparer<LigatureSubstitutionRecord>.LastIndexOf
	|-EqualityComparer<LocalPacket>.LastIndexOf
	|-EqualityComparer<LocalPacket>.LastIndexOf
	|-EqualityComparer<MultipleSubstitutionRecord>.LastIndexOf
	|-EqualityComparer<MultipleSubstitutionRecord>.LastIndexOf
	|-EqualityComparer<Playable>.LastIndexOf
	|-EqualityComparer<Quaternion>.LastIndexOf
	|-EqualityComparer<RangePositionInfo>.LastIndexOf
	|-EqualityComparer<Rect>.LastIndexOf
	|-EqualityComparer<RectInt>.LastIndexOf
	|-EqualityComparer<RenderInstancedDataLayout>.LastIndexOf
	|-EqualityComparer<Resolution>.LastIndexOf
	|-EqualityComparer<ResourceLocator>.LastIndexOf
	|-EqualityComparer<RpcLink>.LastIndexOf
	|-EqualityComparer<RuleMatcher>.LastIndexOf
	|-EqualityComparer<SamplePointUData>.LastIndexOf
	|-EqualityComparer<StylePropertyName>.LastIndexOf
	|-EqualityComparer<StylePropertyValue>.LastIndexOf
	|-EqualityComparer<StyleValueManaged>.LastIndexOf
	|-EqualityComparer<Substring>.LastIndexOf
	|-EqualityComparer<TreeItem>.LastIndexOf
	|-EqualityComparer<UILineInfo>.LastIndexOf
	|-EqualityComparer<UnloadedScene>.LastIndexOf
	|-EqualityComparer<Vector4>.LastIndexOf
	|-EqualityComparer<X509ChainStatus>.LastIndexOf
	|-EqualityComparer<XPathNodeRef>.LastIndexOf
	|-EqualityComparer<ZipGenericExtraField>.LastIndexOf
	|-EqualityComparer<AdvancedSmooth.Turn>.LastIndexOf
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.LastIndexOf
	|-EqualityComparer<CameraState.CustomBlendable>.LastIndexOf
	|-EqualityComparer<ClipperLib.IntPoint>.LastIndexOf
	|-EqualityComparer<ConfinerOven.PolygonSolution>.LastIndexOf
	|-EqualityComparer<EventDispatcher.DispatchContext>.LastIndexOf
	|-EqualityComparer<EventDispatcher.EventRecord>.LastIndexOf
	|-EqualityComparer<FocusController.FocusedElement>.LastIndexOf
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.LastIndexOf
	|-EqualityComparer<InputTransformSpots.TransformSpot>.LastIndexOf
	|-EqualityComparer<InputUser.OngoingAccountSelection>.LastIndexOf
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.LastIndexOf
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.LastIndexOf
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.LastIndexOf
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.LastIndexOf
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.LastIndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.LastIndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.LastIndexOf
	|-EqualityComparer<RigidbodyPrediction.MoveData>.LastIndexOf
	|-EqualityComparer<SVGDocument.NodeWithParent>.LastIndexOf
	|-EqualityComparer<ServerSocket.ConnectionChange>.LastIndexOf
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.LastIndexOf
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.LastIndexOf
	|-EqualityComparer<TargetStateListener.Callback>.LastIndexOf
	|-EqualityComparer<TextSettings.FontReferenceMap>.LastIndexOf
	|-EqualityComparer<TextureRegistry.TextureInfo>.LastIndexOf
	|-EqualityComparer<TransportManager.DisconnectingClient>.LastIndexOf
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.LastIndexOf
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.LastIndexOf
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.LastIndexOf
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.LastIndexOf
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.LastIndexOf
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.LastIndexOf
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.LastIndexOf
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.LastIndexOf
	|
	|-RVA: 0x16C46A0 Offset: 0x16C30A0 VA: 0x1816C46A0
	|-EqualityComparer<SyncList.ChangeData<int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.LastIndexOf
	|-EqualityComparer<BackgroundPosition>.LastIndexOf
	|-EqualityComparer<DuplicateSamplePoint>.LastIndexOf
	|-EqualityComparer<Int3>.LastIndexOf
	|-EqualityComparer<IntRegion>.LastIndexOf
	|-EqualityComparer<ManipulatorActivationFilter>.LastIndexOf
	|-EqualityComparer<UICharInfo>.LastIndexOf
	|-EqualityComparer<Vector3>.LastIndexOf
	|-EqualityComparer<Vector3Int>.LastIndexOf
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.LastIndexOf
	|-EqualityComparer<HIDParser.HIDReportData>.LastIndexOf
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.LastIndexOf
	|-EqualityComparer<SyncTimer.ChangeData>.LastIndexOf
	|
	|-RVA: 0x16C42D0 Offset: 0x16C2CD0 VA: 0x1816C42D0
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<int, int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<int, int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<int, Scene>>.LastIndexOf
	|-EqualityComparer<AnimatorClipInfo>.LastIndexOf
	|-EqualityComparer<BackgroundRepeat>.LastIndexOf
	|-EqualityComparer<CSteamID>.LastIndexOf
	|-EqualityComparer<DateTime>.LastIndexOf
	|-EqualityComparer<FullRank>.LastIndexOf
	|-EqualityComparer<GCHandle>.LastIndexOf
	|-EqualityComparer<InputEventPtr>.LastIndexOf
	|-EqualityComparer<Int2>.LastIndexOf
	|-EqualityComparer<RendererListHandle>.LastIndexOf
	|-EqualityComparer<ResourceHandle>.LastIndexOf
	|-EqualityComparer<RpcLinkType>.LastIndexOf
	|-EqualityComparer<SamplePointsPatch>.LastIndexOf
	|-EqualityComparer<TerrainTileCoord>.LastIndexOf
	|-EqualityComparer<TimeSpan>.LastIndexOf
	|-EqualityComparer<TimeValue>.LastIndexOf
	|-EqualityComparer<UsageHint>.LastIndexOf
	|-EqualityComparer<Vector2Int>.LastIndexOf
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.LastIndexOf
	|-EqualityComparer<BitmapAllocator32.Page>.LastIndexOf
	|-EqualityComparer<CinemachineClearShot.Pair>.LastIndexOf
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.LastIndexOf
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.LastIndexOf
	|-EqualityComparer<HIDSupport.HIDPageUsage>.LastIndexOf
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.LastIndexOf
	|-EqualityComparer<Multipass.TransportIdData>.LastIndexOf
	|-EqualityComparer<ObjectPool.DelayedStoreData>.LastIndexOf
	|-EqualityComparer<PlayingCard.CardData>.LastIndexOf
	|-EqualityComparer<SVGDocument.PostponedClip>.LastIndexOf
	|-EqualityComparer<SVGDocument.PostponedStopData>.LastIndexOf
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.LastIndexOf
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.LastIndexOf
	|-EqualityComparer<SyncStopwatch.ChangeData>.LastIndexOf
	|
	|-RVA: 0x16C45A0 Offset: 0x16C2FA0 VA: 0x1816C45A0
	|-EqualityComparer<IntervalTree.Entry<object>>.LastIndexOf
	|-EqualityComparer<KeyValuePair<Rect, object>>.LastIndexOf
	|-EqualityComparer<Nullable<Decimal>>.LastIndexOf
	|-EqualityComparer<TempAllocator.Page<ushort>>.LastIndexOf
	|-EqualityComparer<TempAllocator.Page<Vertex>>.LastIndexOf
	|-EqualityComparer<TreeViewItemData<object>>.LastIndexOf
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.LastIndexOf
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.LastIndexOf
	|-EqualityComparer<ValueTuple<object, object, object>>.LastIndexOf
	|-EqualityComparer<BezierPathSegment>.LastIndexOf
	|-EqualityComparer<Bounds>.LastIndexOf
	|-EqualityComparer<BoundsInt>.LastIndexOf
	|-EqualityComparer<Color>.LastIndexOf
	|-EqualityComparer<ComputedTransitionProperty>.LastIndexOf
	|-EqualityComparer<ContourVertex>.LastIndexOf
	|-EqualityComparer<CoordinateProceduralTilePair>.LastIndexOf
	|-EqualityComparer<FrameTimeSample>.LastIndexOf
	|-EqualityComparer<IntervalTreeNode>.LastIndexOf
	|-EqualityComparer<JsonPosition>.LastIndexOf
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.LastIndexOf
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.LastIndexOf
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.LastIndexOf
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.LastIndexOf
	|-EqualityComparer<NameAndParameters>.LastIndexOf
	|-EqualityComparer<NamedValue>.LastIndexOf
	|-EqualityComparer<Packet>.LastIndexOf
	|-EqualityComparer<RendererList>.LastIndexOf
	|-EqualityComparer<SelectorMatchRecord>.LastIndexOf
	|-EqualityComparer<StyleSelectorPart>.LastIndexOf
	|-EqualityComparer<StyleSyntaxToken>.LastIndexOf
	|-EqualityComparer<StyleValue>.LastIndexOf
	|-EqualityComparer<StyleVariable>.LastIndexOf
	|-EqualityComparer<TreeViewItemWrapper>.LastIndexOf
	|-EqualityComparer<XRFeatureDescriptor>.LastIndexOf
	|-EqualityComparer<AvatarSettings.LayerSetting>.LastIndexOf
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.LastIndexOf
	|-EqualityComparer<HID.HIDCollectionDescriptor>.LastIndexOf
	|-EqualityComparer<LatencySimulator.Message>.LastIndexOf
	|-EqualityComparer<LiquidVolume.MeshCache>.LastIndexOf
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.LastIndexOf
	|-EqualityComparer<Regex.CachedCodeEntryKey>.LastIndexOf
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.LastIndexOf
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.LastIndexOf
	|-EqualityComparer<StructySync.ChangeData>.LastIndexOf
	|-EqualityComparer<TemplateAsset.AttributeOverride>.LastIndexOf
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.LastIndexOf
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.LastIndexOf
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.LastIndexOf
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.LastIndexOf
	|
	|-RVA: 0x16C4460 Offset: 0x16C2E60 VA: 0x1816C4460
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.LastIndexOf
	|-EqualityComparer<RaycastResult>.LastIndexOf
	|-EqualityComparer<UIRStylePainter.Entry>.LastIndexOf
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.LastIndexOf
	|
	|-RVA: 0x16C4790 Offset: 0x16C3190 VA: 0x1816C4790
	|-EqualityComparer<ValueTuple<bool>>.LastIndexOf
	|-EqualityComparer<SVGDocument.ClipData>.LastIndexOf
	|
	|-RVA: 0x16E8B10 Offset: 0x16E7510 VA: 0x1816E8B10
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.LastIndexOf
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.LastIndexOf
	|-EqualityComparer<NetworkAnimator.StateChange>.LastIndexOf
	|-EqualityComparer<SVGDocument.PatternData>.LastIndexOf
	|-EqualityComparer<ShadowUtility.Edge>.LastIndexOf
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.LastIndexOf
	|
	|-RVA: 0x16E8430 Offset: 0x16E6E30 VA: 0x1816E8430
	|-EqualityComparer<Background>.LastIndexOf
	|-EqualityComparer<BezierSegment>.LastIndexOf
	|-EqualityComparer<NativeAddr>.LastIndexOf
	|-EqualityComparer<NavMeshBuildMarkup>.LastIndexOf
	|-EqualityComparer<PlayableBinding>.LastIndexOf
	|-EqualityComparer<SpriteState>.LastIndexOf
	|-EqualityComparer<VoxelContour>.LastIndexOf
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.LastIndexOf
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.LastIndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.LastIndexOf
	|-EqualityComparer<SVGDocument.NodeReferenceData>.LastIndexOf
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.LastIndexOf
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.LastIndexOf
	|-EqualityComparer<TextResourceManager.FontAssetRef>.LastIndexOf
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.LastIndexOf
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.LastIndexOf
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.LastIndexOf
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.LastIndexOf
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.LastIndexOf
	|
	|-RVA: 0x16E8210 Offset: 0x16E6C10 VA: 0x1816E8210
	|-EqualityComparer<bool>.LastIndexOf
	|-EqualityComparer<byte>.LastIndexOf
	|-EqualityComparer<ByteEnum>.LastIndexOf
	|-EqualityComparer<sbyte>.LastIndexOf
	|
	|-RVA: 0x16E85E0 Offset: 0x16E6FE0 VA: 0x1816E85E0
	|-EqualityComparer<CGSpot>.LastIndexOf
	|-EqualityComparer<GlyphPairAdjustmentRecord>.LastIndexOf
	|-EqualityComparer<RaycastHit>.LastIndexOf
	|
	|-RVA: 0x16E8700 Offset: 0x16E7100 VA: 0x1816E8700
	|-EqualityComparer<char>.LastIndexOf
	|-EqualityComparer<short>.LastIndexOf
	|-EqualityComparer<ushort>.LastIndexOf
	|
	|-RVA: 0x16E8D20 Offset: 0x16E7720 VA: 0x1816E8D20
	|-EqualityComparer<Color32>.LastIndexOf
	|-EqualityComparer<EasingFunction>.LastIndexOf
	|-EqualityComparer<HSteamNetConnection>.LastIndexOf
	|-EqualityComparer<LayerMask>.LastIndexOf
	|-EqualityComparer<Scene>.LastIndexOf
	|-EqualityComparer<ShaderTagId>.LastIndexOf
	|-EqualityComparer<TextureId>.LastIndexOf
	|-EqualityComparer<UShort2>.LastIndexOf
	|-EqualityComparer<RegexCharClass.SingleRange>.LastIndexOf
	|
	|-RVA: 0x16E88D0 Offset: 0x16E72D0 VA: 0x1816E88D0
	|-EqualityComparer<ColorBlock>.LastIndexOf
	|-EqualityComparer<ComputedStyle>.LastIndexOf
	|-EqualityComparer<InputBinding>.LastIndexOf
	|
	|-RVA: 0x16E82B0 Offset: 0x16E6CB0 VA: 0x1816E82B0
	|-EqualityComparer<CombineInstance>.LastIndexOf
	|
	|-RVA: 0x16E87C0 Offset: 0x16E71C0 VA: 0x1816E87C0
	|-EqualityComparer<ControlPointOption>.LastIndexOf
	|-EqualityComparer<RaycastHit2D>.LastIndexOf
	|-EqualityComparer<Funnel.PathPart>.LastIndexOf
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.LastIndexOf
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.LastIndexOf
	|
	|-RVA: 0x16E8C10 Offset: 0x16E7610 VA: 0x1816E8C10
	|-EqualityComparer<DisplayInfo>.LastIndexOf
	|-EqualityComparer<IntPoint>.LastIndexOf
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.LastIndexOf
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.LastIndexOf
	|
	|-RVA: 0x16E8520 Offset: 0x16E6F20 VA: 0x1816E8520
	|-EqualityComparer<double>.LastIndexOf
	|
	|-RVA: 0x16E8A30 Offset: 0x16E7430 VA: 0x1816E8A30
	|-EqualityComparer<DoublePoint>.LastIndexOf
	|-EqualityComparer<DoublePoint>.LastIndexOf
	|-EqualityComparer<ClipperLib.DoublePoint>.LastIndexOf
	|
	|-RVA: 0x170DCE0 Offset: 0x170C6E0 VA: 0x18170DCE0
	|-EqualityComparer<EnumData>.LastIndexOf
	|-EqualityComparer<Matrix4x4>.LastIndexOf
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.LastIndexOf
	|
	|-RVA: 0x170DED0 Offset: 0x170C8D0 VA: 0x18170DED0
	|-EqualityComparer<InputDeviceDescription>.LastIndexOf
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.LastIndexOf
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.LastIndexOf
	|-EqualityComparer<TextureBlitter.BlitInfo>.LastIndexOf
	|
	|-RVA: 0x170DC20 Offset: 0x170C620 VA: 0x18170DC20
	|-EqualityComparer<int>.LastIndexOf
	|-EqualityComparer<Int32Enum>.LastIndexOf
	|-EqualityComparer<uint>.LastIndexOf
	|-EqualityComparer<UInt32Enum>.LastIndexOf
	|
	|-RVA: 0x170DE10 Offset: 0x170C810 VA: 0x18170DE10
	|-EqualityComparer<long>.LastIndexOf
	|-EqualityComparer<IntPtr>.LastIndexOf
	|-EqualityComparer<object>.LastIndexOf
	|-EqualityComparer<ulong>.LastIndexOf
	|
	|-RVA: 0x170E000 Offset: 0x170CA00 VA: 0x18170E000
	|-EqualityComparer<Label>.LastIndexOf
	|-EqualityComparer<Navigation>.LastIndexOf
	|-EqualityComparer<PlayerLoopSystem>.LastIndexOf
	|-EqualityComparer<PlayerLoopSystemInternal>.LastIndexOf
	|-EqualityComparer<RenderTargetIdentifier>.LastIndexOf
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.LastIndexOf
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.LastIndexOf
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.LastIndexOf
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.LastIndexOf
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.LastIndexOf
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.LastIndexOf
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.LastIndexOf
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.LastIndexOf
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.LastIndexOf
	|-EqualityComparer<UIRenderDevice.AllocToFree>.LastIndexOf
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.LastIndexOf
	|
	|-RVA: 0x1731850 Offset: 0x1730250 VA: 0x181731850
	|-EqualityComparer<NavMeshBuildSource>.LastIndexOf
	|-EqualityComparer<RenderChain.RenderNodeData>.LastIndexOf
	|
	|-RVA: 0x17315D0 Offset: 0x172FFD0 VA: 0x1817315D0
	|-EqualityComparer<PointerModel>.LastIndexOf
	|
	|-RVA: 0x1731790 Offset: 0x1730190 VA: 0x181731790
	|-EqualityComparer<float>.LastIndexOf
	|
	|-RVA: 0x1755840 Offset: 0x1754240 VA: 0x181755840
	|-EqualityComparer<UIVertex>.LastIndexOf
	|
	|-RVA: 0x1755440 Offset: 0x1753E40 VA: 0x181755440
	|-EqualityComparer<Vector2>.LastIndexOf
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.LastIndexOf
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.LastIndexOf
	|
	|-RVA: 0x17559C0 Offset: 0x17543C0 VA: 0x1817559C0
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.LastIndexOf
	|
	|-RVA: 0x1755680 Offset: 0x1754080 VA: 0x181755680
	|-EqualityComparer<XRView>.LastIndexOf
	|
	|-RVA: 0x1755500 Offset: 0x1753F00 VA: 0x181755500
	|-EqualityComparer<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0x1779DC0 Offset: 0x17787C0 VA: 0x181779DC0
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.LastIndexOf
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.LastIndexOf
	|
	|-RVA: 0x1779A00 Offset: 0x1778400 VA: 0x181779A00
	|-EqualityComparer<HID.HIDElementDescriptor>.LastIndexOf
	|-EqualityComparer<JsonParser.JsonValue>.LastIndexOf
	|
	|-RVA: 0x1779B40 Offset: 0x1778540 VA: 0x181779B40
	|-EqualityComparer<InputControlLayout.ControlItem>.LastIndexOf
	|
	|-RVA: 0x1779D00 Offset: 0x1778700 VA: 0x181779D00
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.LastIndexOf
	|-EqualityComparer<SVGDocument.MaskData>.LastIndexOf
	|
	|-RVA: 0x1779F50 Offset: 0x1778950 VA: 0x181779F50
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.LastIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16C5870 Offset: 0x16C4270 VA: 0x1816C5870
	|-EqualityComparer<ArraySegment<byte>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SyncList.CachedOnChange<int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<object, bool>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<object, char>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeArray<NudgeJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeSlice<NudgeJobData>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StructMultiKey<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SubArray<int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<IntPtr, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<object, int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AsyncGPUReadbackRequest>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BezierContour>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Connection>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CoordinateFootprintTilePair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CoordinateStorageTilePair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CoordinateTilePair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DualPrefab>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Entry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<EventSummary>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<FontDefinition>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Hash128>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntPoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntRect>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InternedString>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LigatureSubstitutionRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LigatureSubstitutionRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LocalPacket>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LocalPacket>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MultipleSubstitutionRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MultipleSubstitutionRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderInstancedDataLayout>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Resolution>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RpcLink>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RuleMatcher>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SamplePointUData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StylePropertyName>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StylePropertyValue>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleValueManaged>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Substring>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TreeItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UnloadedScene>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ZipGenericExtraField>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AdvancedSmooth.Turn>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ClipperLib.IntPoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ConfinerOven.PolygonSolution>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<EventDispatcher.EventRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputTransformSpots.TransformSpot>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputUser.OngoingAccountSelection>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RigidbodyPrediction.MoveData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.NodeWithParent>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ServerSocket.ConnectionChange>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TargetStateListener.Callback>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TextSettings.FontReferenceMap>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TextureRegistry.TextureInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TransportManager.DisconnectingClient>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5B50 Offset: 0x16C4550 VA: 0x1816C5B50
	|-EqualityComparer<SyncList.ChangeData<int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BackgroundPosition>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DuplicateSamplePoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Int3>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntRegion>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ManipulatorActivationFilter>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<HIDParser.HIDReportData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SyncTimer.ChangeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5790 Offset: 0x16C4190 VA: 0x1816C5790
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<int, int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<int, Scene>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BackgroundRepeat>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CSteamID>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<FullRank>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<GCHandle>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputEventPtr>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Int2>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RendererListHandle>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ResourceHandle>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RpcLinkType>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SamplePointsPatch>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TerrainTileCoord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TimeValue>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UsageHint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BitmapAllocator32.Page>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<HIDSupport.HIDPageUsage>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Multipass.TransportIdData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ObjectPool.DelayedStoreData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<PlayingCard.CardData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.PostponedClip>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.PostponedStopData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SyncStopwatch.ChangeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5950 Offset: 0x16C4350 VA: 0x1816C5950
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<KeyValuePair<Rect, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TempAllocator.Page<ushort>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TempAllocator.Page<Vertex>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TreeViewItemData<object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BezierPathSegment>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ComputedTransitionProperty>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ContourVertex>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<CoordinateProceduralTilePair>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<FrameTimeSample>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<JsonPosition>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NameAndParameters>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NamedValue>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Packet>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RendererList>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SelectorMatchRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleSelectorPart>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleSyntaxToken>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleValue>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StyleVariable>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TreeViewItemWrapper>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<XRFeatureDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AvatarSettings.LayerSetting>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<HID.HIDCollectionDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LatencySimulator.Message>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LiquidVolume.MeshCache>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Regex.CachedCodeEntryKey>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<StructySync.ChangeData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TemplateAsset.AttributeOverride>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5A40 Offset: 0x16C4440 VA: 0x1816C5A40
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UIRStylePainter.Entry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5C40 Offset: 0x16C4640 VA: 0x1816C5C40
	|-EqualityComparer<Nullable<DateTime>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C5690 Offset: 0x16C4090 VA: 0x1816C5690
	|-EqualityComparer<Nullable<Decimal>>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16C55B0 Offset: 0x16C3FB0 VA: 0x1816C55B0
	|-EqualityComparer<ValueTuple<bool>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ByteEnum>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.ClipData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA890 Offset: 0x16E9290 VA: 0x1816EA890
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NetworkAnimator.StateChange>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.PatternData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ShadowUtility.Edge>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EAA60 Offset: 0x16E9460 VA: 0x1816EAA60
	|-EqualityComparer<Background>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<BezierSegment>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NativeAddr>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VoxelContour>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.NodeReferenceData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TextResourceManager.FontAssetRef>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EAE30 Offset: 0x16E9830 VA: 0x1816EAE30
	|-EqualityComparer<CGSpot>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<GlyphPairAdjustmentRecord>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EAD50 Offset: 0x16E9750 VA: 0x1816EAD50
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.MaskData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EAC70 Offset: 0x16E9670 VA: 0x1816EAC70
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<EasingFunction>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<HSteamNetConnection>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Scene>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ShaderTagId>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TextureId>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UInt32Enum>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UShort2>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RegexCharClass.SingleRange>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA4C0 Offset: 0x16E8EC0 VA: 0x1816EA4C0
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ComputedStyle>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputBinding>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EAB50 Offset: 0x16E9550 VA: 0x1816EAB50
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA7A0 Offset: 0x16E91A0 VA: 0x1816EA7A0
	|-EqualityComparer<ControlPointOption>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Funnel.PathPart>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA5D0 Offset: 0x16E8FD0 VA: 0x1816EA5D0
	|-EqualityComparer<DisplayInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<IntPoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA6C0 Offset: 0x16E90C0 VA: 0x1816EA6C0
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x16EA980 Offset: 0x16E9380 VA: 0x1816EA980
	|-EqualityComparer<DoublePoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DoublePoint>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ClipperLib.DoublePoint>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x170E7F0 Offset: 0x170D1F0 VA: 0x18170E7F0
	|-EqualityComparer<EnumData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x170E8F0 Offset: 0x170D2F0 VA: 0x18170E8F0
	|-EqualityComparer<InputDeviceDescription>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TextureBlitter.BlitInfo>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x170E700 Offset: 0x170D100 VA: 0x18170E700
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderTargetIdentifier>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<UIRenderDevice.AllocToFree>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x17322C0 Offset: 0x1730CC0 VA: 0x1817322C0
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<RenderChain.RenderNodeData>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x17321E0 Offset: 0x1730BE0 VA: 0x1817321E0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x17324B0 Offset: 0x1730EB0 VA: 0x1817324B0
	|-EqualityComparer<PointerModel>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x17323D0 Offset: 0x1730DD0 VA: 0x1817323D0
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x1756930 Offset: 0x1755330 VA: 0x181756930
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x1756700 Offset: 0x1755100 VA: 0x181756700
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x1756A50 Offset: 0x1755450 VA: 0x181756A50
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x17567E0 Offset: 0x17551E0 VA: 0x1817567E0
	|-EqualityComparer<XRView>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x1756B90 Offset: 0x1755590 VA: 0x181756B90
	|-EqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x177AC40 Offset: 0x1779640 VA: 0x18177AC40
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x177AB30 Offset: 0x1779530 VA: 0x18177AB30
	|-EqualityComparer<HID.HIDElementDescriptor>.System.Collections.IEqualityComparer.GetHashCode
	|-EqualityComparer<JsonParser.JsonValue>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x177AD60 Offset: 0x1779760 VA: 0x18177AD60
	|-EqualityComparer<InputControlLayout.ControlItem>.System.Collections.IEqualityComparer.GetHashCode
	|
	|-RVA: 0x177AEC0 Offset: 0x17798C0 VA: 0x18177AEC0
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.System.Collections.IEqualityComparer.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16C4B50 Offset: 0x16C3550 VA: 0x1816C4B50
	|-EqualityComparer<ArraySegment<byte>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SyncList.CachedOnChange<int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<int, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<object, bool>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<object, char>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<object, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<PropertyName, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeArray<NudgeJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeSlice<NudgeJobData>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StructMultiKey<object, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SubArray<int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<int, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<Int32Enum, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<IntPtr, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<object, int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<object, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AsyncGPUReadbackRequest>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BezierContour>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Connection>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CoordinateFootprintTilePair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CoordinateStorageFootprintTilePair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CoordinateStorageTilePair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CoordinateTilePair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DateTimeOffset>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Decimal>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DualPrefab>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Entry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<EventSummary>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<FontDefinition>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<GlyphRect>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Guid>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Hash128>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntPoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntRect>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InternedString>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InterpretedFrameInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LigatureSubstitutionRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LigatureSubstitutionRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LocalPacket>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LocalPacket>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MultipleSubstitutionRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MultipleSubstitutionRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Playable>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RangePositionInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RectInt>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderInstancedDataLayout>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Resolution>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ResourceLocator>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RpcLink>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RuleMatcher>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SamplePointUData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StylePropertyName>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StylePropertyValue>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleValueManaged>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Substring>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TreeItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UILineInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UnloadedScene>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<X509ChainStatus>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<XPathNodeRef>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ZipGenericExtraField>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AdvancedSmooth.Turn>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CameraState.CustomBlendable>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ClipperLib.IntPoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ConfinerOven.PolygonSolution>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<EventDispatcher.DispatchContext>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<EventDispatcher.EventRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<FocusController.FocusedElement>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputTransformSpots.TransformSpot>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputUser.OngoingAccountSelection>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RigidbodyPrediction.MoveData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.NodeWithParent>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ServerSocket.ConnectionChange>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleVariableResolver.ResolveContext>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TargetStateListener.Callback>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TextSettings.FontReferenceMap>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TextureRegistry.TextureInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TransportManager.DisconnectingClient>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UIRenderDevice.DeviceToFree>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C5240 Offset: 0x16C3C40 VA: 0x1816C5240
	|-EqualityComparer<SyncList.ChangeData<int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<int, Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BackgroundPosition>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DuplicateSamplePoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Int3>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntRegion>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ManipulatorActivationFilter>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UICharInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Vector3>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Vector3Int>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<HIDParser.HIDReportData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SyncTimer.ChangeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C4CE0 Offset: 0x16C36E0 VA: 0x1816C4CE0
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<int, int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<int, int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<int, Scene>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AnimatorClipInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BackgroundRepeat>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CSteamID>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DateTime>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<FullRank>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<GCHandle>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputEventPtr>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Int2>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<long>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntPtr>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RendererListHandle>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ResourceHandle>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RpcLinkType>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SamplePointsPatch>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TerrainTileCoord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TimeSpan>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TimeValue>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ulong>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UsageHint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Vector2Int>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BaseStyleMatcher.MatchContext>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BitmapAllocator32.Page>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CinemachineClearShot.Pair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<HIDSupport.HIDPageUsage>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Multipass.TransportIdData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ObjectPool.DelayedStoreData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<PlayingCard.CardData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.PostponedClip>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.PostponedStopData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SyncStopwatch.ChangeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C4830 Offset: 0x16C3230 VA: 0x1816C4830
	|-EqualityComparer<IntervalTree.Entry<object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<KeyValuePair<Rect, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TempAllocator.Page<ushort>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TempAllocator.Page<Vertex>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TreeViewItemData<object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ValueTuple<object, object, object>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BezierPathSegment>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Bounds>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BoundsInt>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ComputedTransitionProperty>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ContourVertex>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<CoordinateProceduralTilePair>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<FrameTimeSample>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntervalTreeNode>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<JsonPosition>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MarkToBaseAdjustmentRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MarkToMarkAdjustmentRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NameAndParameters>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NamedValue>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Packet>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RendererList>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SelectorMatchRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleSelectorPart>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleSyntaxToken>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleValue>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StyleVariable>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TreeViewItemWrapper>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<XRFeatureDescriptor>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AvatarSettings.LayerSetting>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<HID.HIDCollectionDescriptor>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LatencySimulator.Message>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LiquidVolume.MeshCache>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Regex.CachedCodeEntryKey>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RetainedGizmos.MeshWithHash>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.HierarchyUpdate>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<StructySync.ChangeData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TemplateAsset.AttributeOverride>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VisualTreeAsset.UsingEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C5010 Offset: 0x16C3A10 VA: 0x1816C5010
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RaycastResult>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UIRStylePainter.Entry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C4E50 Offset: 0x16C3850 VA: 0x1816C4E50
	|-EqualityComparer<Nullable<DateTime>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C53E0 Offset: 0x16C3DE0 VA: 0x1816C53E0
	|-EqualityComparer<Nullable<Decimal>>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16C49E0 Offset: 0x16C33E0 VA: 0x1816C49E0
	|-EqualityComparer<ValueTuple<bool>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.ClipData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16EA150 Offset: 0x16E8B50 VA: 0x1816EA150
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NetworkAnimator.StateChange>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.PatternData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ShadowUtility.Edge>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16EA310 Offset: 0x16E8D10 VA: 0x1816EA310
	|-EqualityComparer<Background>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<BezierSegment>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NativeAddr>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NavMeshBuildMarkup>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<PlayableBinding>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SpriteState>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VoxelContour>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.NodeReferenceData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.ViewBoxInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TextResourceManager.FontAssetRef>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<VisualTreeAsset.AssetEntry>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InstructionList.DebugView.InstructionView>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E92A0 Offset: 0x16E7CA0 VA: 0x1816E92A0
	|-EqualityComparer<bool>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<byte>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ByteEnum>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<sbyte>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E97A0 Offset: 0x16E81A0 VA: 0x1816E97A0
	|-EqualityComparer<CGSpot>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<GlyphPairAdjustmentRecord>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RaycastHit>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9990 Offset: 0x16E8390 VA: 0x1816E9990
	|-EqualityComparer<char>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<short>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ushort>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9E40 Offset: 0x16E8840 VA: 0x1816E9E40
	|-EqualityComparer<Color>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Quaternion>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Rect>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Vector4>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9CD0 Offset: 0x16E86D0 VA: 0x1816E9CD0
	|-EqualityComparer<Color32>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<EasingFunction>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<HSteamNetConnection>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<int>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Int32Enum>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<LayerMask>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Scene>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ShaderTagId>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TextureId>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<uint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UInt32Enum>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UShort2>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RegexCharClass.SingleRange>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9050 Offset: 0x16E7A50 VA: 0x1816E9050
	|-EqualityComparer<ColorBlock>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ComputedStyle>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputBinding>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E8DE0 Offset: 0x16E77E0 VA: 0x1816E8DE0
	|-EqualityComparer<CombineInstance>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9B00 Offset: 0x16E8500 VA: 0x1816E9B00
	|-EqualityComparer<ControlPointOption>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RaycastHit2D>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Funnel.PathPart>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9410 Offset: 0x16E7E10 VA: 0x1816E9410
	|-EqualityComparer<DisplayInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<IntPoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E9FD0 Offset: 0x16E89D0 VA: 0x1816E9FD0
	|-EqualityComparer<double>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x16E95F0 Offset: 0x16E7FF0 VA: 0x1816E95F0
	|-EqualityComparer<DoublePoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DoublePoint>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ClipperLib.DoublePoint>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x170E110 Offset: 0x170CB10 VA: 0x18170E110
	|-EqualityComparer<EnumData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Matrix4x4>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TexturePacker_JsonArray.Frame>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x170E310 Offset: 0x170CD10 VA: 0x18170E310
	|-EqualityComparer<InputDeviceDescription>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TextureBlitter.BlitInfo>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x170E520 Offset: 0x170CF20 VA: 0x18170E520
	|-EqualityComparer<Label>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<Navigation>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<PlayerLoopSystem>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<PlayerLoopSystemInternal>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderTargetIdentifier>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DecalEntityManager.CombinedChunks>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputActionMap.BindingOverrideJson>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<UIRenderDevice.AllocToFree>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1731B40 Offset: 0x1730540 VA: 0x181731B40
	|-EqualityComparer<NavMeshBuildSource>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<RenderChain.RenderNodeData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x17319B0 Offset: 0x17303B0 VA: 0x1817319B0
	|-EqualityComparer<object>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1731D90 Offset: 0x1730790 VA: 0x181731D90
	|-EqualityComparer<PointerModel>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1732060 Offset: 0x1730A60 VA: 0x181732060
	|-EqualityComparer<float>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1755E40 Offset: 0x1754840 VA: 0x181755E40
	|-EqualityComparer<UIVertex>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x17560C0 Offset: 0x1754AC0 VA: 0x1817560C0
	|-EqualityComparer<Vector2>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1755B80 Offset: 0x1754580 VA: 0x181755B80
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1756260 Offset: 0x1754C60 VA: 0x181756260
	|-EqualityComparer<XRView>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x1756530 Offset: 0x1754F30 VA: 0x181756530
	|-EqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x177A270 Offset: 0x1778C70 VA: 0x18177A270
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x177A040 Offset: 0x1778A40 VA: 0x18177A040
	|-EqualityComparer<HID.HIDElementDescriptor>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<JsonParser.JsonValue>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x177A510 Offset: 0x1778F10 VA: 0x18177A510
	|-EqualityComparer<InputControlLayout.ControlItem>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x177A820 Offset: 0x1779220 VA: 0x18177A820
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>.System.Collections.IEqualityComparer.Equals
	|-EqualityComparer<SVGDocument.MaskData>.System.Collections.IEqualityComparer.Equals
	|
	|-RVA: 0x177A990 Offset: 0x1779390 VA: 0x18177A990
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>.System.Collections.IEqualityComparer.Equals
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-EqualityComparer<ArraySegment<byte>>..ctor
	|-EqualityComparer<SyncList.CachedOnChange<int>>..ctor
	|-EqualityComparer<SyncList.ChangeData<int>>..ctor
	|-EqualityComparer<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>..ctor
	|-EqualityComparer<IntervalTree.Entry<object>>..ctor
	|-EqualityComparer<KeyValuePair<int, int>>..ctor
	|-EqualityComparer<KeyValuePair<int, object>>..ctor
	|-EqualityComparer<KeyValuePair<Int32Enum, object>>..ctor
	|-EqualityComparer<KeyValuePair<object, bool>>..ctor
	|-EqualityComparer<KeyValuePair<object, char>>..ctor
	|-EqualityComparer<KeyValuePair<object, object>>..ctor
	|-EqualityComparer<KeyValuePair<object, JsonParser.JsonValue>>..ctor
	|-EqualityComparer<KeyValuePair<PropertyName, object>>..ctor
	|-EqualityComparer<KeyValuePair<Rect, object>>..ctor
	|-EqualityComparer<NativeArray<ConvertMeshJobData>>..ctor
	|-EqualityComparer<NativeArray<CopyClosingMeshJobData>>..ctor
	|-EqualityComparer<NativeArray<NudgeJobData>>..ctor
	|-EqualityComparer<NativeSlice<ConvertMeshJobData>>..ctor
	|-EqualityComparer<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-EqualityComparer<NativeSlice<NudgeJobData>>..ctor
	|-EqualityComparer<Nullable<DateTime>>..ctor
	|-EqualityComparer<Nullable<Decimal>>..ctor
	|-EqualityComparer<TempAllocator.Page<ushort>>..ctor
	|-EqualityComparer<TempAllocator.Page<Vertex>>..ctor
	|-EqualityComparer<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|-EqualityComparer<StructMultiKey<object, object>>..ctor
	|-EqualityComparer<SubArray<int>>..ctor
	|-EqualityComparer<TreeViewItemData<object>>..ctor
	|-EqualityComparer<ValueTuple<bool>>..ctor
	|-EqualityComparer<ValueTuple<int, int>>..ctor
	|-EqualityComparer<ValueTuple<int, object>>..ctor
	|-EqualityComparer<ValueTuple<int, Scene>>..ctor
	|-EqualityComparer<ValueTuple<int, Vector2Int>>..ctor
	|-EqualityComparer<ValueTuple<Int32Enum, object>>..ctor
	|-EqualityComparer<ValueTuple<IntPtr, object>>..ctor
	|-EqualityComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-EqualityComparer<ValueTuple<object, int>>..ctor
	|-EqualityComparer<ValueTuple<object, object>>..ctor
	|-EqualityComparer<ValueTuple<Vector3, Quaternion>>..ctor
	|-EqualityComparer<ValueTuple<Vector4, Vector2Int>>..ctor
	|-EqualityComparer<ValueTuple<object, object, object>>..ctor
	|-EqualityComparer<AnimatorClipInfo>..ctor
	|-EqualityComparer<AsyncGPUReadbackRequest>..ctor
	|-EqualityComparer<Background>..ctor
	|-EqualityComparer<BackgroundPosition>..ctor
	|-EqualityComparer<BackgroundRepeat>..ctor
	|-EqualityComparer<BezierContour>..ctor
	|-EqualityComparer<BezierPathSegment>..ctor
	|-EqualityComparer<BezierSegment>..ctor
	|-EqualityComparer<bool>..ctor
	|-EqualityComparer<Bounds>..ctor
	|-EqualityComparer<BoundsInt>..ctor
	|-EqualityComparer<byte>..ctor
	|-EqualityComparer<ByteEnum>..ctor
	|-EqualityComparer<CGSpot>..ctor
	|-EqualityComparer<CSteamID>..ctor
	|-EqualityComparer<char>..ctor
	|-EqualityComparer<Color>..ctor
	|-EqualityComparer<Color>..ctor
	|-EqualityComparer<Color32>..ctor
	|-EqualityComparer<ColorBlock>..ctor
	|-EqualityComparer<CombineInstance>..ctor
	|-EqualityComparer<ComputedStyle>..ctor
	|-EqualityComparer<ComputedTransitionProperty>..ctor
	|-EqualityComparer<Connection>..ctor
	|-EqualityComparer<ContourVertex>..ctor
	|-EqualityComparer<ControlPointOption>..ctor
	|-EqualityComparer<CoordinateFootprintTilePair>..ctor
	|-EqualityComparer<CoordinateProceduralTilePair>..ctor
	|-EqualityComparer<CoordinateStorageFootprintTilePair>..ctor
	|-EqualityComparer<CoordinateStorageTilePair>..ctor
	|-EqualityComparer<CoordinateTilePair>..ctor
	|-EqualityComparer<DateTime>..ctor
	|-EqualityComparer<DateTimeOffset>..ctor
	|-EqualityComparer<Decimal>..ctor
	|-EqualityComparer<DisplayInfo>..ctor
	|-EqualityComparer<double>..ctor
	|-EqualityComparer<DoublePoint>..ctor
	|-EqualityComparer<DoublePoint>..ctor
	|-EqualityComparer<DualPrefab>..ctor
	|-EqualityComparer<DuplicateSamplePoint>..ctor
	|-EqualityComparer<EasingFunction>..ctor
	|-EqualityComparer<Entry>..ctor
	|-EqualityComparer<EnumData>..ctor
	|-EqualityComparer<EventSummary>..ctor
	|-EqualityComparer<FontDefinition>..ctor
	|-EqualityComparer<FrameTimeSample>..ctor
	|-EqualityComparer<FullRank>..ctor
	|-EqualityComparer<GCHandle>..ctor
	|-EqualityComparer<GlyphPairAdjustmentRecord>..ctor
	|-EqualityComparer<GlyphRect>..ctor
	|-EqualityComparer<Guid>..ctor
	|-EqualityComparer<HSteamNetConnection>..ctor
	|-EqualityComparer<Hash128>..ctor
	|-EqualityComparer<InputBinding>..ctor
	|-EqualityComparer<InputDeviceDescription>..ctor
	|-EqualityComparer<InputEventPtr>..ctor
	|-EqualityComparer<short>..ctor
	|-EqualityComparer<Int2>..ctor
	|-EqualityComparer<Int3>..ctor
	|-EqualityComparer<int>..ctor
	|-EqualityComparer<Int32Enum>..ctor
	|-EqualityComparer<long>..ctor
	|-EqualityComparer<IntPoint>..ctor
	|-EqualityComparer<IntPoint>..ctor
	|-EqualityComparer<IntPtr>..ctor
	|-EqualityComparer<IntRect>..ctor
	|-EqualityComparer<IntRegion>..ctor
	|-EqualityComparer<InternedString>..ctor
	|-EqualityComparer<InterpretedFrameInfo>..ctor
	|-EqualityComparer<IntervalTreeNode>..ctor
	|-EqualityComparer<JsonPosition>..ctor
	|-EqualityComparer<Label>..ctor
	|-EqualityComparer<LayerMask>..ctor
	|-EqualityComparer<LigatureSubstitutionRecord>..ctor
	|-EqualityComparer<LigatureSubstitutionRecord>..ctor
	|-EqualityComparer<LocalPacket>..ctor
	|-EqualityComparer<LocalPacket>..ctor
	|-EqualityComparer<ManipulatorActivationFilter>..ctor
	|-EqualityComparer<MarkToBaseAdjustmentRecord>..ctor
	|-EqualityComparer<MarkToBaseAdjustmentRecord>..ctor
	|-EqualityComparer<MarkToMarkAdjustmentRecord>..ctor
	|-EqualityComparer<MarkToMarkAdjustmentRecord>..ctor
	|-EqualityComparer<Matrix4x4>..ctor
	|-EqualityComparer<MultipleSubstitutionRecord>..ctor
	|-EqualityComparer<MultipleSubstitutionRecord>..ctor
	|-EqualityComparer<NameAndParameters>..ctor
	|-EqualityComparer<NamedValue>..ctor
	|-EqualityComparer<NativeAddr>..ctor
	|-EqualityComparer<NavMeshBuildMarkup>..ctor
	|-EqualityComparer<NavMeshBuildSource>..ctor
	|-EqualityComparer<Navigation>..ctor
	|-EqualityComparer<object>..ctor
	|-EqualityComparer<Packet>..ctor
	|-EqualityComparer<Playable>..ctor
	|-EqualityComparer<PlayableBinding>..ctor
	|-EqualityComparer<PlayerLoopSystem>..ctor
	|-EqualityComparer<PlayerLoopSystemInternal>..ctor
	|-EqualityComparer<PointerModel>..ctor
	|-EqualityComparer<ProbeVolumeBakingProcessSettings>..ctor
	|-EqualityComparer<Quaternion>..ctor
	|-EqualityComparer<RangePositionInfo>..ctor
	|-EqualityComparer<RaycastHit>..ctor
	|-EqualityComparer<RaycastHit2D>..ctor
	|-EqualityComparer<RaycastResult>..ctor
	|-EqualityComparer<Rect>..ctor
	|-EqualityComparer<RectInt>..ctor
	|-EqualityComparer<RenderInstancedDataLayout>..ctor
	|-EqualityComparer<RenderTargetIdentifier>..ctor
	|-EqualityComparer<RendererList>..ctor
	|-EqualityComparer<RendererListHandle>..ctor
	|-EqualityComparer<Resolution>..ctor
	|-EqualityComparer<ResourceHandle>..ctor
	|-EqualityComparer<ResourceLocator>..ctor
	|-EqualityComparer<RpcLink>..ctor
	|-EqualityComparer<RpcLinkType>..ctor
	|-EqualityComparer<RuleMatcher>..ctor
	|-EqualityComparer<sbyte>..ctor
	|-EqualityComparer<SamplePointUData>..ctor
	|-EqualityComparer<SamplePointsPatch>..ctor
	|-EqualityComparer<Scene>..ctor
	|-EqualityComparer<SelectorMatchRecord>..ctor
	|-EqualityComparer<ShaderTagId>..ctor
	|-EqualityComparer<float>..ctor
	|-EqualityComparer<SpriteState>..ctor
	|-EqualityComparer<StylePropertyName>..ctor
	|-EqualityComparer<StylePropertyValue>..ctor
	|-EqualityComparer<StyleSelectorPart>..ctor
	|-EqualityComparer<StyleSyntaxToken>..ctor
	|-EqualityComparer<StyleValue>..ctor
	|-EqualityComparer<StyleValueManaged>..ctor
	|-EqualityComparer<StyleVariable>..ctor
	|-EqualityComparer<Substring>..ctor
	|-EqualityComparer<TerrainTileCoord>..ctor
	|-EqualityComparer<TextureId>..ctor
	|-EqualityComparer<TimeSpan>..ctor
	|-EqualityComparer<TimeValue>..ctor
	|-EqualityComparer<TreeItem>..ctor
	|-EqualityComparer<TreeViewItemWrapper>..ctor
	|-EqualityComparer<UICharInfo>..ctor
	|-EqualityComparer<UILineInfo>..ctor
	|-EqualityComparer<UIVertex>..ctor
	|-EqualityComparer<ushort>..ctor
	|-EqualityComparer<uint>..ctor
	|-EqualityComparer<UInt32Enum>..ctor
	|-EqualityComparer<ulong>..ctor
	|-EqualityComparer<UShort2>..ctor
	|-EqualityComparer<UnloadedScene>..ctor
	|-EqualityComparer<UsageHint>..ctor
	|-EqualityComparer<Vector2>..ctor
	|-EqualityComparer<Vector2Int>..ctor
	|-EqualityComparer<Vector3>..ctor
	|-EqualityComparer<Vector3Int>..ctor
	|-EqualityComparer<Vector4>..ctor
	|-EqualityComparer<VoxelContour>..ctor
	|-EqualityComparer<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|-EqualityComparer<X509ChainStatus>..ctor
	|-EqualityComparer<XPathNodeRef>..ctor
	|-EqualityComparer<XRFeatureDescriptor>..ctor
	|-EqualityComparer<XRView>..ctor
	|-EqualityComparer<ZipGenericExtraField>..ctor
	|-EqualityComparer<__Il2CppFullySharedGenericType>..ctor
	|-EqualityComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..ctor
	|-EqualityComparer<AdvancedSmooth.Turn>..ctor
	|-EqualityComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|-EqualityComparer<AvatarSettings.LayerSetting>..ctor
	|-EqualityComparer<BaseStyleMatcher.MatchContext>..ctor
	|-EqualityComparer<BeforeRenderHelper.OrderBlock>..ctor
	|-EqualityComparer<BitmapAllocator32.Page>..ctor
	|-EqualityComparer<CameraState.CustomBlendable>..ctor
	|-EqualityComparer<CinemachineClearShot.Pair>..ctor
	|-EqualityComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|-EqualityComparer<ClipperLib.DoublePoint>..ctor
	|-EqualityComparer<ClipperLib.IntPoint>..ctor
	|-EqualityComparer<ConfinerOven.PolygonSolution>..ctor
	|-EqualityComparer<DecalEntityIndexer.DecalEntityItem>..ctor
	|-EqualityComparer<DecalEntityManager.CombinedChunks>..ctor
	|-EqualityComparer<EventDispatcher.DispatchContext>..ctor
	|-EqualityComparer<EventDispatcher.EventRecord>..ctor
	|-EqualityComparer<EventInterestReflectionUtils.DefaultEventInterests>..ctor
	|-EqualityComparer<FocusController.FocusedElement>..ctor
	|-EqualityComparer<FrameTimingsHUDDisplay.FrameTimingPoint>..ctor
	|-EqualityComparer<Funnel.PathPart>..ctor
	|-EqualityComparer<GodRaysRenderPass.VisibleLightRemap>..ctor
	|-EqualityComparer<GraphUpdateProcessor.GUOSingle>..ctor
	|-EqualityComparer<HID.HIDCollectionDescriptor>..ctor
	|-EqualityComparer<HID.HIDElementDescriptor>..ctor
	|-EqualityComparer<HIDParser.HIDReportData>..ctor
	|-EqualityComparer<HIDSupport.HIDPageUsage>..ctor
	|-EqualityComparer<HeatmapManager.PropertyRegionReference>..ctor
	|-EqualityComparer<InputActionMap.BindingOverrideJson>..ctor
	|-EqualityComparer<InputControlLayout.ControlItem>..ctor
	|-EqualityComparer<InputManager.StateChangeMonitorTimeout>..ctor
	|-EqualityComparer<InputSystemUIInputModule.InputActionReferenceState>..ctor
	|-EqualityComparer<InputTransformSpots.TransformSpot>..ctor
	|-EqualityComparer<InputUser.OngoingAccountSelection>..ctor
	|-EqualityComparer<JsonParser.JsonValue>..ctor
	|-EqualityComparer<LatencySimulator.Message>..ctor
	|-EqualityComparer<LiquidVolume.MeshCache>..ctor
	|-EqualityComparer<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-EqualityComparer<Multipass.TransportIdData>..ctor
	|-EqualityComparer<NativeMethods.TASKDIALOG_BUTTON>..ctor
	|-EqualityComparer<NetworkAnimator.ReceivedServerData>..ctor
	|-EqualityComparer<NetworkAnimator.SmoothedFloat>..ctor
	|-EqualityComparer<NetworkAnimator.StateChange>..ctor
	|-EqualityComparer<NetworkAnimator.TriggerUpdate>..ctor
	|-EqualityComparer<NetworkBehaviour.BufferedRpc>..ctor
	|-EqualityComparer<ObjectPool.DelayedStoreData>..ctor
	|-EqualityComparer<OnScreenControl.OnScreenDeviceInfo>..ctor
	|-EqualityComparer<OutlineEffect.OutlineTargetGroup>..ctor
	|-EqualityComparer<PlayingCard.CardData>..ctor
	|-EqualityComparer<ProbeBrickIndex.ReservedBrick>..ctor
	|-EqualityComparer<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-EqualityComparer<ProbeVolumePerSceneData.PerScenarioData>..ctor
	|-EqualityComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..ctor
	|-EqualityComparer<ProbeVolumeSceneData.SerializableBoundItem>..ctor
	|-EqualityComparer<ProbeVolumeSceneData.SerializableHasPVItem>..ctor
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>..ctor
	|-EqualityComparer<ProbeVolumeSceneData.SerializablePVProfile>..ctor
	|-EqualityComparer<ReflectionProbeManager.CachedProbe>..ctor
	|-EqualityComparer<Regex.CachedCodeEntryKey>..ctor
	|-EqualityComparer<RegexCharClass.SingleRange>..ctor
	|-EqualityComparer<RenderChain.RenderNodeData>..ctor
	|-EqualityComparer<RenderGraphDebugData.PassDebugData>..ctor
	|-EqualityComparer<RenderGraphDebugData.ResourceDebugData>..ctor
	|-EqualityComparer<RetainedGizmos.MeshWithHash>..ctor
	|-EqualityComparer<RigidbodyPauser.Rigidbody2DData>..ctor
	|-EqualityComparer<RigidbodyPauser.RigidbodyData>..ctor
	|-EqualityComparer<RigidbodyPrediction.MoveData>..ctor
	|-EqualityComparer<SVGDocument.ClipData>..ctor
	|-EqualityComparer<SVGDocument.HierarchyUpdate>..ctor
	|-EqualityComparer<SVGDocument.MaskData>..ctor
	|-EqualityComparer<SVGDocument.NodeGlobalSceneState>..ctor
	|-EqualityComparer<SVGDocument.NodeReferenceData>..ctor
	|-EqualityComparer<SVGDocument.NodeWithParent>..ctor
	|-EqualityComparer<SVGDocument.PatternData>..ctor
	|-EqualityComparer<SVGDocument.PostponedClip>..ctor
	|-EqualityComparer<SVGDocument.PostponedStopData>..ctor
	|-EqualityComparer<SVGDocument.ViewBoxInfo>..ctor
	|-EqualityComparer<SequenceNode.SequenceConstructPosContext>..ctor
	|-EqualityComparer<ServerSocket.ConnectionChange>..ctor
	|-EqualityComparer<SewerMushroomLocation.MushroomLocationData>..ctor
	|-EqualityComparer<ShadowUtility.Edge>..ctor
	|-EqualityComparer<StructySync.ChangeData>..ctor
	|-EqualityComparer<StyleComplexSelector.PseudoStateData>..ctor
	|-EqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair>..ctor
	|-EqualityComparer<StyleSheetCache.SheetHandleKey>..ctor
	|-EqualityComparer<StyleVariableResolver.ResolveContext>..ctor
	|-EqualityComparer<SyncStopwatch.ChangeData>..ctor
	|-EqualityComparer<SyncTimer.ChangeData>..ctor
	|-EqualityComparer<TMP_DynamicFontAssetUtilities.FontReference>..ctor
	|-EqualityComparer<TMP_ResourceManager.FontAssetRef>..ctor
	|-EqualityComparer<TargetStateListener.Callback>..ctor
	|-EqualityComparer<TemplateAsset.AttributeOverride>..ctor
	|-EqualityComparer<TextResourceManager.FontAssetRef>..ctor
	|-EqualityComparer<TextSettings.FontReferenceMap>..ctor
	|-EqualityComparer<TextureBlitter.BlitInfo>..ctor
	|-EqualityComparer<TexturePacker_JsonArray.Frame>..ctor
	|-EqualityComparer<TextureRegistry.TextureInfo>..ctor
	|-EqualityComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|-EqualityComparer<TrackedDeviceRaycaster.RaycastHitData>..ctor
	|-EqualityComparer<TransportManager.DisconnectingClient>..ctor
	|-EqualityComparer<UIRStylePainter.Entry>..ctor
	|-EqualityComparer<UIRStylePainter.RepeatRectUV>..ctor
	|-EqualityComparer<UIRenderDevice.AllocToFree>..ctor
	|-EqualityComparer<UIRenderDevice.AllocToUpdate>..ctor
	|-EqualityComparer<UIRenderDevice.DeviceToFree>..ctor
	|-EqualityComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|-EqualityComparer<VisualTreeAsset.AssetEntry>..ctor
	|-EqualityComparer<VisualTreeAsset.SlotDefinition>..ctor
	|-EqualityComparer<VisualTreeAsset.SlotUsageEntry>..ctor
	|-EqualityComparer<VisualTreeAsset.UsingEntry>..ctor
	|-EqualityComparer<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-EqualityComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-EqualityComparer<BindingRestrictions.TestBuilder.AndNode>..ctor
	|-EqualityComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..ctor
	|-EqualityComparer<DebugUI.Foldout.ContextMenuItem>..ctor
	|-EqualityComparer<InputControlLayout.Collection.LayoutMatcher>..ctor
	|-EqualityComparer<InputControlLayout.Collection.PrecompiledLayout>..ctor
	|-EqualityComparer<InstructionList.DebugView.InstructionView>..ctor
	|-EqualityComparer<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|-EqualityComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|-EqualityComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/
}
