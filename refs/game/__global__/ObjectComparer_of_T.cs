internal class ObjectComparer<T> : Comparer<T> // TypeDefIndex: 5012
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B0170 Offset: 0x10AEB70 VA: 0x1810B0170
	|-ObjectComparer<ArraySegment<byte>>.Compare
	|
	|-RVA: 0x10AF560 Offset: 0x10ADF60 VA: 0x1810AF560
	|-ObjectComparer<SyncList.CachedOnChange<int>>.Compare
	|
	|-RVA: 0x10AE660 Offset: 0x10AD060 VA: 0x1810AE660
	|-ObjectComparer<SyncList.ChangeData<int>>.Compare
	|
	|-RVA: 0x10B0A50 Offset: 0x10AF450 VA: 0x1810B0A50
	|-ObjectComparer<IntervalTree.Entry<object>>.Compare
	|
	|-RVA: 0x10B0E70 Offset: 0x10AF870 VA: 0x1810B0E70
	|-ObjectComparer<KeyValuePair<int, object>>.Compare
	|
	|-RVA: 0x10AEF60 Offset: 0x10AD960 VA: 0x1810AEF60
	|-ObjectComparer<KeyValuePair<object, bool>>.Compare
	|
	|-RVA: 0x10AE830 Offset: 0x10AD230 VA: 0x1810AE830
	|-ObjectComparer<KeyValuePair<object, char>>.Compare
	|
	|-RVA: 0x10B0B40 Offset: 0x10AF540 VA: 0x1810B0B40
	|-ObjectComparer<KeyValuePair<object, object>>.Compare
	|
	|-RVA: 0x10AF700 Offset: 0x10AE100 VA: 0x1810AF700
	|-ObjectComparer<KeyValuePair<object, JsonParser.JsonValue>>.Compare
	|
	|-RVA: 0x10AEE80 Offset: 0x10AD880 VA: 0x1810AEE80
	|-ObjectComparer<KeyValuePair<PropertyName, object>>.Compare
	|
	|-RVA: 0x10B05C0 Offset: 0x10AEFC0 VA: 0x1810B05C0
	|-ObjectComparer<KeyValuePair<Rect, object>>.Compare
	|
	|-RVA: 0x10AEBB0 Offset: 0x10AD5B0 VA: 0x1810AEBB0
	|-ObjectComparer<NativeArray<ConvertMeshJobData>>.Compare
	|
	|-RVA: 0x10AE030 Offset: 0x10ACA30 VA: 0x1810AE030
	|-ObjectComparer<NativeArray<CopyClosingMeshJobData>>.Compare
	|
	|-RVA: 0x10AFFB0 Offset: 0x10AE9B0 VA: 0x1810AFFB0
	|-ObjectComparer<NativeArray<NudgeJobData>>.Compare
	|
	|-RVA: 0x10ADCC0 Offset: 0x10AC6C0 VA: 0x1810ADCC0
	|-ObjectComparer<NativeSlice<ConvertMeshJobData>>.Compare
	|
	|-RVA: 0x10ADF50 Offset: 0x10AC950 VA: 0x1810ADF50
	|-ObjectComparer<NativeSlice<CopyClosingMeshJobData>>.Compare
	|
	|-RVA: 0x10B0880 Offset: 0x10AF280 VA: 0x1810B0880
	|-ObjectComparer<NativeSlice<NudgeJobData>>.Compare
	|
	|-RVA: 0x10AE1E0 Offset: 0x10ACBE0 VA: 0x1810AE1E0
	|-ObjectComparer<Nullable<DateTime>>.Compare
	|
	|-RVA: 0x10B0790 Offset: 0x10AF190 VA: 0x1810B0790
	|-ObjectComparer<Nullable<Decimal>>.Compare
	|
	|-RVA: 0x10B0960 Offset: 0x10AF360 VA: 0x1810B0960
	|-ObjectComparer<TempAllocator.Page<ushort>>.Compare
	|
	|-RVA: 0x10B0320 Offset: 0x10AED20 VA: 0x1810B0320
	|-ObjectComparer<TempAllocator.Page<Vertex>>.Compare
	|
	|-RVA: 0x10AE2C0 Offset: 0x10ACCC0 VA: 0x1810AE2C0
	|-ObjectComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.Compare
	|
	|-RVA: 0x10AF2B0 Offset: 0x10ADCB0 VA: 0x1810AF2B0
	|-ObjectComparer<StructMultiKey<object, object>>.Compare
	|
	|-RVA: 0x10B0410 Offset: 0x10AEE10 VA: 0x1810B0410
	|-ObjectComparer<SubArray<int>>.Compare
	|
	|-RVA: 0x10AF040 Offset: 0x10ADA40 VA: 0x1810AF040
	|-ObjectComparer<ValueTuple<bool>>.Compare
	|
	|-RVA: 0x10ADE90 Offset: 0x10AC890 VA: 0x1810ADE90
	|-ObjectComparer<ValueTuple<int, int>>.Compare
	|
	|-RVA: 0x10B06B0 Offset: 0x10AF0B0 VA: 0x1810B06B0
	|-ObjectComparer<ValueTuple<int, object>>.Compare
	|
	|-RVA: 0x10ADB20 Offset: 0x10AC520 VA: 0x1810ADB20
	|-ObjectComparer<ValueTuple<int, Scene>>.Compare
	|
	|-RVA: 0x10AFCB0 Offset: 0x10AE6B0 VA: 0x1810AFCB0
	|-ObjectComparer<ValueTuple<int, Vector2Int>>.Compare
	|
	|-RVA: 0x10AFAE0 Offset: 0x10AE4E0 VA: 0x1810AFAE0
	|-ObjectComparer<ValueTuple<object, ValueTuple<object, int>>>.Compare
	|
	|-RVA: 0x10B0090 Offset: 0x10AEA90 VA: 0x1810B0090
	|-ObjectComparer<ValueTuple<object, int>>.Compare
	|
	|-RVA: 0x10B0C20 Offset: 0x10AF620 VA: 0x1810B0C20
	|-ObjectComparer<ValueTuple<object, object>>.Compare
	|
	|-RVA: 0x10AF640 Offset: 0x10AE040 VA: 0x1810AF640
	|-ObjectComparer<AnimatorClipInfo>.Compare
	|
	|-RVA: 0x10ADBE0 Offset: 0x10AC5E0 VA: 0x1810ADBE0
	|-ObjectComparer<AsyncGPUReadbackRequest>.Compare
	|
	|-RVA: 0x10AFA00 Offset: 0x10AE400 VA: 0x1810AFA00
	|-ObjectComparer<BezierContour>.Compare
	|
	|-RVA: 0x10AF390 Offset: 0x10ADD90 VA: 0x1810AF390
	|-ObjectComparer<BezierPathSegment>.Compare
	|
	|-RVA: 0x10AFDA0 Offset: 0x10AE7A0 VA: 0x1810AFDA0
	|-ObjectComparer<BezierSegment>.Compare
	|
	|-RVA: 0x10B0250 Offset: 0x10AEC50 VA: 0x1810B0250
	|-ObjectComparer<bool>.Compare
	|
	|-RVA: 0x10AE570 Offset: 0x10ACF70 VA: 0x1810AE570
	|-ObjectComparer<Bounds>.Compare
	|
	|-RVA: 0x10B04F0 Offset: 0x10AEEF0 VA: 0x1810B04F0
	|-ObjectComparer<byte>.Compare
	|
	|-RVA: 0x10AFE90 Offset: 0x10AE890 VA: 0x1810AFE90
	|-ObjectComparer<CGSpot>.Compare
	|
	|-RVA: 0x10AE110 Offset: 0x10ACB10 VA: 0x1810AE110
	|-ObjectComparer<char>.Compare
	|
	|-RVA: 0x10AE750 Offset: 0x10AD150 VA: 0x1810AE750
	|-ObjectComparer<Color>.Compare
	|
	|-RVA: 0x10AF1F0 Offset: 0x10ADBF0 VA: 0x1810AF1F0
	|-ObjectComparer<Color32>.Compare
	|
	|-RVA: 0x10B0D00 Offset: 0x10AF700 VA: 0x1810B0D00
	|-ObjectComparer<CombineInstance>.Compare
	|
	|-RVA: 0x10AF100 Offset: 0x10ADB00 VA: 0x1810AF100
	|-ObjectComparer<ComputedTransitionProperty>.Compare
	|
	|-RVA: 0x10AFBD0 Offset: 0x10AE5D0 VA: 0x1810AFBD0
	|-ObjectComparer<Connection>.Compare
	|
	|-RVA: 0x10AE3A0 Offset: 0x10ACDA0 VA: 0x1810AE3A0
	|-ObjectComparer<ContourVertex>.Compare
	|
	|-RVA: 0x10AEAB0 Offset: 0x10AD4B0 VA: 0x1810AEAB0
	|-ObjectComparer<ControlPointOption>.Compare
	|
	|-RVA: 0x10AF840 Offset: 0x10AE240 VA: 0x1810AF840
	|-ObjectComparer<CoordinateFootprintTilePair>.Compare
	|
	|-RVA: 0x10ADDA0 Offset: 0x10AC7A0 VA: 0x1810ADDA0
	|-ObjectComparer<CoordinateProceduralTilePair>.Compare
	|
	|-RVA: 0x10AEC90 Offset: 0x10AD690 VA: 0x1810AEC90
	|-ObjectComparer<CoordinateStorageFootprintTilePair>.Compare
	|
	|-RVA: 0x10AF480 Offset: 0x10ADE80 VA: 0x1810AF480
	|-ObjectComparer<CoordinateStorageTilePair>.Compare
	|
	|-RVA: 0x10AE490 Offset: 0x10ACE90 VA: 0x1810AE490
	|-ObjectComparer<CoordinateTilePair>.Compare
	|
	|-RVA: 0x10AE9F0 Offset: 0x10AD3F0 VA: 0x1810AE9F0
	|-ObjectComparer<DateTime>.Compare
	|
	|-RVA: 0x10B1030 Offset: 0x10AFA30 VA: 0x1810B1030
	|-ObjectComparer<DateTimeOffset>.Compare
	|
	|-RVA: 0x10AF920 Offset: 0x10AE320 VA: 0x1810AF920
	|-ObjectComparer<Decimal>.Compare
	|
	|-RVA: 0x10AED70 Offset: 0x10AD770 VA: 0x1810AED70
	|-ObjectComparer<DisplayInfo>.Compare
	|
	|-RVA: 0x10AE910 Offset: 0x10AD310 VA: 0x1810AE910
	|-ObjectComparer<double>.Compare
	|
	|-RVA: 0x10B0F50 Offset: 0x10AF950 VA: 0x1810B0F50
	|-ObjectComparer<DoublePoint>.Compare
	|
	|-RVA: 0x10B9BC0 Offset: 0x10B85C0 VA: 0x1810B9BC0
	|-ObjectComparer<DoublePoint>.Compare
	|
	|-RVA: 0x10B4500 Offset: 0x10B2F00 VA: 0x1810B4500
	|-ObjectComparer<DualPrefab>.Compare
	|
	|-RVA: 0x10B9960 Offset: 0x10B8360 VA: 0x1810B9960
	|-ObjectComparer<DuplicateSamplePoint>.Compare
	|
	|-RVA: 0x10B3D90 Offset: 0x10B2790 VA: 0x1810B3D90
	|-ObjectComparer<EasingFunction>.Compare
	|
	|-RVA: 0x10B6FF0 Offset: 0x10B59F0 VA: 0x1810B6FF0
	|-ObjectComparer<Entry>.Compare
	|
	|-RVA: 0x10B8830 Offset: 0x10B7230 VA: 0x1810B8830
	|-ObjectComparer<EventSummary>.Compare
	|
	|-RVA: 0x10B9340 Offset: 0x10B7D40 VA: 0x1810B9340
	|-ObjectComparer<FrameTimeSample>.Compare
	|
	|-RVA: 0x10B47B0 Offset: 0x10B31B0 VA: 0x1810B47B0
	|-ObjectComparer<GlyphPairAdjustmentRecord>.Compare
	|
	|-RVA: 0x10B2600 Offset: 0x10B1000 VA: 0x1810B2600
	|-ObjectComparer<GlyphRect>.Compare
	|
	|-RVA: 0x10B7360 Offset: 0x10B5D60 VA: 0x1810B7360
	|-ObjectComparer<Guid>.Compare
	|
	|-RVA: 0x10B5B70 Offset: 0x10B4570 VA: 0x1810B5B70
	|-ObjectComparer<InputBinding>.Compare
	|
	|-RVA: 0x10B1C50 Offset: 0x10B0650 VA: 0x1810B1C50
	|-ObjectComparer<InputDeviceDescription>.Compare
	|
	|-RVA: 0x10BB010 Offset: 0x10B9A10 VA: 0x1810BB010
	|-ObjectComparer<InputEventPtr>.Compare
	|
	|-RVA: 0x10B4180 Offset: 0x10B2B80 VA: 0x1810B4180
	|-ObjectComparer<short>.Compare
	|
	|-RVA: 0x10B11B0 Offset: 0x10AFBB0 VA: 0x1810B11B0
	|-ObjectComparer<Int3>.Compare
	|
	|-RVA: 0x10B6C20 Offset: 0x10B5620 VA: 0x1810B6C20
	|-ObjectComparer<int>.Compare
	|
	|-RVA: 0x10B71D0 Offset: 0x10B5BD0 VA: 0x1810B71D0
	|-ObjectComparer<Int32Enum>.Compare
	|
	|-RVA: 0x10B95F0 Offset: 0x10B7FF0 VA: 0x1810B95F0
	|-ObjectComparer<long>.Compare
	|
	|-RVA: 0x10B28A0 Offset: 0x10B12A0 VA: 0x1810B28A0
	|-ObjectComparer<IntPoint>.Compare
	|
	|-RVA: 0x10B43F0 Offset: 0x10B2DF0 VA: 0x1810B43F0
	|-ObjectComparer<IntPoint>.Compare
	|
	|-RVA: 0x10B4990 Offset: 0x10B3390 VA: 0x1810B4990
	|-ObjectComparer<IntPtr>.Compare
	|
	|-RVA: 0x10B3050 Offset: 0x10B1A50 VA: 0x1810B3050
	|-ObjectComparer<IntRect>.Compare
	|
	|-RVA: 0x10B5780 Offset: 0x10B4180 VA: 0x1810B5780
	|-ObjectComparer<IntRegion>.Compare
	|
	|-RVA: 0x10B9430 Offset: 0x10B7E30 VA: 0x1810B9430
	|-ObjectComparer<InternedString>.Compare
	|
	|-RVA: 0x10B7DD0 Offset: 0x10B67D0 VA: 0x1810B7DD0
	|-ObjectComparer<InterpretedFrameInfo>.Compare
	|
	|-RVA: 0x10B2180 Offset: 0x10B0B80 VA: 0x1810B2180
	|-ObjectComparer<IntervalTreeNode>.Compare
	|
	|-RVA: 0x10B6DC0 Offset: 0x10B57C0 VA: 0x1810B6DC0
	|-ObjectComparer<JsonPosition>.Compare
	|
	|-RVA: 0x10B51C0 Offset: 0x10B3BC0 VA: 0x1810B51C0
	|-ObjectComparer<Label>.Compare
	|
	|-RVA: 0x10B1B70 Offset: 0x10B0570 VA: 0x1810B1B70
	|-ObjectComparer<LigatureSubstitutionRecord>.Compare
	|
	|-RVA: 0x10B27C0 Offset: 0x10B11C0 VA: 0x1810B27C0
	|-ObjectComparer<LigatureSubstitutionRecord>.Compare
	|
	|-RVA: 0x10B9160 Offset: 0x10B7B60 VA: 0x1810B9160
	|-ObjectComparer<ManipulatorActivationFilter>.Compare
	|
	|-RVA: 0x10B7520 Offset: 0x10B5F20 VA: 0x1810B7520
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.Compare
	|
	|-RVA: 0x10B6B30 Offset: 0x10B5530 VA: 0x1810B6B30
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.Compare
	|
	|-RVA: 0x10B9250 Offset: 0x10B7C50 VA: 0x1810B9250
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.Compare
	|
	|-RVA: 0x10B8910 Offset: 0x10B7310 VA: 0x1810B8910
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.Compare
	|
	|-RVA: 0x10B2E40 Offset: 0x10B1840 VA: 0x1810B2E40
	|-ObjectComparer<Matrix4x4>.Compare
	|
	|-RVA: 0x10BBA80 Offset: 0x10BA480 VA: 0x1810BBA80
	|-ObjectComparer<MultipleSubstitutionRecord>.Compare
	|
	|-RVA: 0x10B9CA0 Offset: 0x10B86A0 VA: 0x1810B9CA0
	|-ObjectComparer<MultipleSubstitutionRecord>.Compare
	|
	|-RVA: 0x10B5380 Offset: 0x10B3D80 VA: 0x1810B5380
	|-ObjectComparer<NameAndParameters>.Compare
	|
	|-RVA: 0x10BA6A0 Offset: 0x10B90A0 VA: 0x1810BA6A0
	|-ObjectComparer<NamedValue>.Compare
	|
	|-RVA: 0x10B65A0 Offset: 0x10B4FA0 VA: 0x1810B65A0
	|-ObjectComparer<NavMeshBuildMarkup>.Compare
	|
	|-RVA: 0x10B8F50 Offset: 0x10B7950 VA: 0x1810B8F50
	|-ObjectComparer<NavMeshBuildSource>.Compare
	|
	|-RVA: 0x10B1F30 Offset: 0x10B0930 VA: 0x1810B1F30
	|-ObjectComparer<object>.Compare
	|
	|-RVA: 0x10B20A0 Offset: 0x10B0AA0 VA: 0x1810B20A0
	|-ObjectComparer<Playable>.Compare
	|
	|-RVA: 0x10B1740 Offset: 0x10B0140 VA: 0x1810B1740
	|-ObjectComparer<PlayableBinding>.Compare
	|
	|-RVA: 0x10BA790 Offset: 0x10B9190 VA: 0x1810BA790
	|-ObjectComparer<PlayerLoopSystem>.Compare
	|
	|-RVA: 0x10BB2E0 Offset: 0x10B9CE0 VA: 0x1810BB2E0
	|-ObjectComparer<PlayerLoopSystemInternal>.Compare
	|
	|-RVA: 0x10B1D70 Offset: 0x10B0770 VA: 0x1810B1D70
	|-ObjectComparer<Quaternion>.Compare
	|
	|-RVA: 0x10B2360 Offset: 0x10B0D60 VA: 0x1810B2360
	|-ObjectComparer<RangePositionInfo>.Compare
	|
	|-RVA: 0x10BB0D0 Offset: 0x10B9AD0 VA: 0x1810BB0D0
	|-ObjectComparer<RaycastHit>.Compare
	|
	|-RVA: 0x10B7950 Offset: 0x10B6350 VA: 0x1810B7950
	|-ObjectComparer<RaycastHit2D>.Compare
	|
	|-RVA: 0x10BB690 Offset: 0x10BA090 VA: 0x1810BB690
	|-ObjectComparer<RaycastResult>.Compare
	|
	|-RVA: 0x10B19D0 Offset: 0x10B03D0 VA: 0x1810B19D0
	|-ObjectComparer<RectInt>.Compare
	|
	|-RVA: 0x10B2C40 Offset: 0x10B1640 VA: 0x1810B2C40
	|-ObjectComparer<RenderTargetIdentifier>.Compare
	|
	|-RVA: 0x10B3130 Offset: 0x10B1B30 VA: 0x1810B3130
	|-ObjectComparer<RendererList>.Compare
	|
	|-RVA: 0x10B1AB0 Offset: 0x10B04B0 VA: 0x1810B1AB0
	|-ObjectComparer<RendererListHandle>.Compare
	|
	|-RVA: 0x10B76D0 Offset: 0x10B60D0 VA: 0x1810B76D0
	|-ObjectComparer<Resolution>.Compare
	|
	|-RVA: 0x10B3770 Offset: 0x10B2170 VA: 0x1810B3770
	|-ObjectComparer<ResourceHandle>.Compare
	|
	|-RVA: 0x10B96B0 Offset: 0x10B80B0 VA: 0x1810B96B0
	|-ObjectComparer<RuleMatcher>.Compare
	|
	|-RVA: 0x10B4A50 Offset: 0x10B3450 VA: 0x1810B4A50
	|-ObjectComparer<sbyte>.Compare
	|
	|-RVA: 0x10BA050 Offset: 0x10B8A50 VA: 0x1810BA050
	|-ObjectComparer<SamplePointUData>.Compare
	|
	|-RVA: 0x10B3BF0 Offset: 0x10B25F0 VA: 0x1810B3BF0
	|-ObjectComparer<SamplePointsPatch>.Compare
	|
	|-RVA: 0x10B6310 Offset: 0x10B4D10 VA: 0x1810B6310
	|-ObjectComparer<Scene>.Compare
	|
	|-RVA: 0x10B8180 Offset: 0x10B6B80 VA: 0x1810B8180
	|-ObjectComparer<SelectorMatchRecord>.Compare
	|
	|-RVA: 0x10B8E90 Offset: 0x10B7890 VA: 0x1810B8E90
	|-ObjectComparer<ShaderTagId>.Compare
	|
	|-RVA: 0x10BA9B0 Offset: 0x10B93B0 VA: 0x1810BA9B0
	|-ObjectComparer<float>.Compare
	|
	|-RVA: 0x10B6CE0 Offset: 0x10B56E0 VA: 0x1810B6CE0
	|-ObjectComparer<StylePropertyName>.Compare
	|
	|-RVA: 0x10B9510 Offset: 0x10B7F10 VA: 0x1810B9510
	|-ObjectComparer<StylePropertyValue>.Compare
	|
	|-RVA: 0x10B8BC0 Offset: 0x10B75C0 VA: 0x1810B8BC0
	|-ObjectComparer<StyleSelectorPart>.Compare
	|
	|-RVA: 0x10B6070 Offset: 0x10B4A70 VA: 0x1810B6070
	|-ObjectComparer<StyleSyntaxToken>.Compare
	|
	|-RVA: 0x10BB8B0 Offset: 0x10BA2B0 VA: 0x1810BB8B0
	|-ObjectComparer<StyleValue>.Compare
	|
	|-RVA: 0x10B5970 Offset: 0x10B4370 VA: 0x1810B5970
	|-ObjectComparer<StyleValueManaged>.Compare
	|
	|-RVA: 0x10B3930 Offset: 0x10B2330 VA: 0x1810B3930
	|-ObjectComparer<StyleVariable>.Compare
	|
	|-RVA: 0x10BBB60 Offset: 0x10BA560 VA: 0x1810BBB60
	|-ObjectComparer<Substring>.Compare
	|
	|-RVA: 0x10B6160 Offset: 0x10B4B60 VA: 0x1810B6160
	|-ObjectComparer<TimeSpan>.Compare
	|
	|-RVA: 0x10B4330 Offset: 0x10B2D30 VA: 0x1810B4330
	|-ObjectComparer<TimeValue>.Compare
	|
	|-RVA: 0x10B2B50 Offset: 0x10B1550 VA: 0x1810B2B50
	|-ObjectComparer<TreeViewItemWrapper>.Compare
	|
	|-RVA: 0x10B9F60 Offset: 0x10B8960 VA: 0x1810B9F60
	|-ObjectComparer<UICharInfo>.Compare
	|
	|-RVA: 0x10BB7D0 Offset: 0x10BA1D0 VA: 0x1810BB7D0
	|-ObjectComparer<UILineInfo>.Compare
	|
	|-RVA: 0x10B4000 Offset: 0x10B2A00 VA: 0x1810B4000
	|-ObjectComparer<UIVertex>.Compare
	|
	|-RVA: 0x10B7290 Offset: 0x10B5C90 VA: 0x1810B7290
	|-ObjectComparer<ushort>.Compare
	|
	|-RVA: 0x10B1910 Offset: 0x10B0310 VA: 0x1810B1910
	|-ObjectComparer<uint>.Compare
	|
	|-RVA: 0x10BA130 Offset: 0x10B8B30 VA: 0x1810BA130
	|-ObjectComparer<UInt32Enum>.Compare
	|
	|-RVA: 0x10B3220 Offset: 0x10B1C20 VA: 0x1810B3220
	|-ObjectComparer<ulong>.Compare
	|
	|-RVA: 0x10BABB0 Offset: 0x10B95B0 VA: 0x1810BABB0
	|-ObjectComparer<UShort2>.Compare
	|
	|-RVA: 0x10B6A50 Offset: 0x10B5450 VA: 0x1810B6A50
	|-ObjectComparer<UnloadedScene>.Compare
	|
	|-RVA: 0x10B3E50 Offset: 0x10B2850 VA: 0x1810B3E50
	|-ObjectComparer<UsageHint>.Compare
	|
	|-RVA: 0x10B5DB0 Offset: 0x10B47B0 VA: 0x1810B5DB0
	|-ObjectComparer<Vector2>.Compare
	|
	|-RVA: 0x10B7610 Offset: 0x10B6010 VA: 0x1810B7610
	|-ObjectComparer<Vector2Int>.Compare
	|
	|-RVA: 0x10B33C0 Offset: 0x10B1DC0 VA: 0x1810B33C0
	|-ObjectComparer<Vector3>.Compare
	|
	|-RVA: 0x10B34B0 Offset: 0x10B1EB0 VA: 0x1810B34B0
	|-ObjectComparer<Vector4>.Compare
	|
	|-RVA: 0x10B8CB0 Offset: 0x10B76B0 VA: 0x1810B8CB0
	|-ObjectComparer<VoxelContour>.Compare
	|
	|-RVA: 0x10BB4E0 Offset: 0x10B9EE0 VA: 0x1810BB4E0
	|-ObjectComparer<Win32_IP_ADAPTER_ADDRESSES>.Compare
	|
	|-RVA: 0x10B7A50 Offset: 0x10B6450 VA: 0x1810B7A50
	|-ObjectComparer<X509ChainStatus>.Compare
	|
	|-RVA: 0x10B1490 Offset: 0x10AFE90 VA: 0x1810B1490
	|-ObjectComparer<XRFeatureDescriptor>.Compare
	|
	|-RVA: 0x10B7B30 Offset: 0x10B6530 VA: 0x1810B7B30
	|-ObjectComparer<XRView>.Compare
	|
	|-RVA: 0x10B4DD0 Offset: 0x10B37D0 VA: 0x1810B4DD0
	|-ObjectComparer<ZipGenericExtraField>.Compare
	|
	|-RVA: 0x10B9A50 Offset: 0x10B8450 VA: 0x1810B9A50
	|-ObjectComparer<__Il2CppFullySharedGenericType>.Compare
	|
	|-RVA: 0x10B70D0 Offset: 0x10B5AD0 VA: 0x1810B70D0
	|-ObjectComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Compare
	|
	|-RVA: 0x10B4250 Offset: 0x10B2C50 VA: 0x1810B4250
	|-ObjectComparer<AdvancedSmooth.Turn>.Compare
	|
	|-RVA: 0x10B2D40 Offset: 0x10B1740 VA: 0x1810B2D40
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.Compare
	|
	|-RVA: 0x10B8DA0 Offset: 0x10B77A0 VA: 0x1810B8DA0
	|-ObjectComparer<AvatarSettings.LayerSetting>.Compare
	|
	|-RVA: 0x10B50E0 Offset: 0x10B3AE0 VA: 0x1810B50E0
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Compare
	|
	|-RVA: 0x10B77B0 Offset: 0x10B61B0 VA: 0x1810B77B0
	|-ObjectComparer<BitmapAllocator32.Page>.Compare
	|
	|-RVA: 0x10B3CB0 Offset: 0x10B26B0 VA: 0x1810B3CB0
	|-ObjectComparer<CameraState.CustomBlendable>.Compare
	|
	|-RVA: 0x10B46F0 Offset: 0x10B30F0 VA: 0x1810B46F0
	|-ObjectComparer<CinemachineClearShot.Pair>.Compare
	|
	|-RVA: 0x10B52C0 Offset: 0x10B3CC0 VA: 0x1810B52C0
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.Compare
	|
	|-RVA: 0x10B9E80 Offset: 0x10B8880 VA: 0x1810B9E80
	|-ObjectComparer<ClipperLib.DoublePoint>.Compare
	|
	|-RVA: 0x10B32E0 Offset: 0x10B1CE0 VA: 0x1810B32E0
	|-ObjectComparer<ClipperLib.IntPoint>.Compare
	|
	|-RVA: 0x10B1660 Offset: 0x10B0060 VA: 0x1810B1660
	|-ObjectComparer<ConfinerOven.PolygonSolution>.Compare
	|
	|-RVA: 0x10B6810 Offset: 0x10B5210 VA: 0x1810B6810
	|-ObjectComparer<DecalEntityIndexer.DecalEntityItem>.Compare
	|
	|-RVA: 0x10B1390 Offset: 0x10AFD90 VA: 0x1810B1390
	|-ObjectComparer<DecalEntityManager.CombinedChunks>.Compare
	|
	|-RVA: 0x10B4C00 Offset: 0x10B3600 VA: 0x1810B4C00
	|-ObjectComparer<FocusController.FocusedElement>.Compare
	|
	|-RVA: 0x10B5690 Offset: 0x10B4090 VA: 0x1810B5690
	|-ObjectComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.Compare
	|
	|-RVA: 0x10B5870 Offset: 0x10B4270 VA: 0x1810B5870
	|-ObjectComparer<Funnel.PathPart>.Compare
	|
	|-RVA: 0x10B6690 Offset: 0x10B5090 VA: 0x1810B6690
	|-ObjectComparer<GodRaysRenderPass.VisibleLightRemap>.Compare
	|
	|-RVA: 0x10B1FB0 Offset: 0x10B09B0 VA: 0x1810B1FB0
	|-ObjectComparer<HID.HIDCollectionDescriptor>.Compare
	|
	|-RVA: 0x10B4EB0 Offset: 0x10B38B0 VA: 0x1810B4EB0
	|-ObjectComparer<HID.HIDElementDescriptor>.Compare
	|
	|-RVA: 0x10B8450 Offset: 0x10B6E50 VA: 0x1810B8450
	|-ObjectComparer<HIDParser.HIDReportData>.Compare
	|
	|-RVA: 0x10B8270 Offset: 0x10B6C70 VA: 0x1810B8270
	|-ObjectComparer<HeatmapManager.PropertyRegionReference>.Compare
	|
	|-RVA: 0x10BBC40 Offset: 0x10BA640 VA: 0x1810BBC40
	|-ObjectComparer<InputActionMap.BindingOverrideJson>.Compare
	|
	|-RVA: 0x10BAD70 Offset: 0x10B9770 VA: 0x1810BAD70
	|-ObjectComparer<InputControlLayout.ControlItem>.Compare
	|
	|-RVA: 0x10B7870 Offset: 0x10B6270 VA: 0x1810B7870
	|-ObjectComparer<InputTransformSpots.TransformSpot>.Compare
	|
	|-RVA: 0x10B8540 Offset: 0x10B6F40 VA: 0x1810B8540
	|-ObjectComparer<JsonParser.JsonValue>.Compare
	|
	|-RVA: 0x10B9790 Offset: 0x10B8190 VA: 0x1810B9790
	|-ObjectComparer<LatencySimulator.Message>.Compare
	|
	|-RVA: 0x10B7FB0 Offset: 0x10B69B0 VA: 0x1810B7FB0
	|-ObjectComparer<MultiColumnCollectionHeader.SortedColumnState>.Compare
	|
	|-RVA: 0x10B1830 Offset: 0x10B0230 VA: 0x1810B1830
	|-ObjectComparer<NativeMethods.TASKDIALOG_BUTTON>.Compare
	|
	|-RVA: 0x10B2440 Offset: 0x10B0E40 VA: 0x1810B2440
	|-ObjectComparer<NetworkAnimator.TriggerUpdate>.Compare
	|
	|-RVA: 0x10BA480 Offset: 0x10B8E80 VA: 0x1810BA480
	|-ObjectComparer<OutlineEffect.OutlineTargetGroup>.Compare
	|
	|-RVA: 0x10BA1F0 Offset: 0x10B8BF0 VA: 0x1810BA1F0
	|-ObjectComparer<PlayingCard.CardData>.Compare
	|
	|-RVA: 0x10B4CE0 Offset: 0x10B36E0 VA: 0x1810B4CE0
	|-ObjectComparer<ProbeBrickIndex.ReservedBrick>.Compare
	|
	|-RVA: 0x10B3680 Offset: 0x10B2080 VA: 0x1810B3680
	|-ObjectComparer<ProbeBrickPool.BrickChunkAlloc>.Compare
	|
	|-RVA: 0x10B4FF0 Offset: 0x10B39F0 VA: 0x1810B4FF0
	|-ObjectComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Compare
	|
	|-RVA: 0x10B2270 Offset: 0x10B0C70 VA: 0x1810B2270
	|-ObjectComparer<ProbeVolumeSceneData.SerializableBoundItem>.Compare
	|
	|-RVA: 0x10B63D0 Offset: 0x10B4DD0 VA: 0x1810B63D0
	|-ObjectComparer<ProbeVolumeSceneData.SerializableHasPVItem>.Compare
	|
	|-RVA: 0x10B5A50 Offset: 0x10B4450 VA: 0x1810B5A50
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.Compare
	|
	|-RVA: 0x10BB9A0 Offset: 0x10BA3A0 VA: 0x1810BB9A0
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVProfile>.Compare
	|
	|-RVA: 0x10B48D0 Offset: 0x10B32D0 VA: 0x1810B48D0
	|-ObjectComparer<RegexCharClass.SingleRange>.Compare
	|
	|-RVA: 0x10B6900 Offset: 0x10B5300 VA: 0x1810B6900
	|-ObjectComparer<RenderChain.RenderNodeData>.Compare
	|
	|-RVA: 0x10B3830 Offset: 0x10B2230 VA: 0x1810B3830
	|-ObjectComparer<RenderGraphDebugData.PassDebugData>.Compare
	|
	|-RVA: 0x10B8350 Offset: 0x10B6D50 VA: 0x1810B8350
	|-ObjectComparer<RenderGraphDebugData.ResourceDebugData>.Compare
	|
	|-RVA: 0x10B64B0 Offset: 0x10B4EB0 VA: 0x1810B64B0
	|-ObjectComparer<RetainedGizmos.MeshWithHash>.Compare
	|
	|-RVA: 0x10B45E0 Offset: 0x10B2FE0 VA: 0x1810B45E0
	|-ObjectComparer<RigidbodyPauser.Rigidbody2DData>.Compare
	|
	|-RVA: 0x10B5570 Offset: 0x10B3F70 VA: 0x1810B5570
	|-ObjectComparer<RigidbodyPauser.RigidbodyData>.Compare
	|
	|-RVA: 0x10B8AE0 Offset: 0x10B74E0 VA: 0x1810B8AE0
	|-ObjectComparer<RigidbodyPrediction.MoveData>.Compare
	|
	|-RVA: 0x10B2A60 Offset: 0x10B1460 VA: 0x1810B2A60
	|-ObjectComparer<SVGDocument.HierarchyUpdate>.Compare
	|
	|-RVA: 0x10B2F60 Offset: 0x10B1960 VA: 0x1810B2F60
	|-ObjectComparer<SVGDocument.NodeReferenceData>.Compare
	|
	|-RVA: 0x10B9880 Offset: 0x10B8280 VA: 0x1810B9880
	|-ObjectComparer<SVGDocument.NodeWithParent>.Compare
	|
	|-RVA: 0x10B8680 Offset: 0x10B7080 VA: 0x1810B8680
	|-ObjectComparer<SVGDocument.PostponedClip>.Compare
	|
	|-RVA: 0x10B90A0 Offset: 0x10B7AA0 VA: 0x1810B90A0
	|-ObjectComparer<SVGDocument.PostponedStopData>.Compare
	|
	|-RVA: 0x10B5E90 Offset: 0x10B4890 VA: 0x1810B5E90
	|-ObjectComparer<ServerSocket.ConnectionChange>.Compare
	|
	|-RVA: 0x10BAC70 Offset: 0x10B9670 VA: 0x1810BAC70
	|-ObjectComparer<SewerMushroomLocation.MushroomLocationData>.Compare
	|
	|-RVA: 0x10B5F70 Offset: 0x10B4970 VA: 0x1810B5F70
	|-ObjectComparer<ShadowUtility.Edge>.Compare
	|
	|-RVA: 0x10B3590 Offset: 0x10B1F90 VA: 0x1810B3590
	|-ObjectComparer<StructySync.ChangeData>.Compare
	|
	|-RVA: 0x10BAF50 Offset: 0x10B9950 VA: 0x1810BAF50
	|-ObjectComparer<SyncStopwatch.ChangeData>.Compare
	|
	|-RVA: 0x10B2510 Offset: 0x10B0F10 VA: 0x1810B2510
	|-ObjectComparer<SyncTimer.ChangeData>.Compare
	|
	|-RVA: 0x10BA2B0 Offset: 0x10B8CB0 VA: 0x1810BA2B0
	|-ObjectComparer<TargetStateListener.Callback>.Compare
	|
	|-RVA: 0x10B5CC0 Offset: 0x10B46C0 VA: 0x1810B5CC0
	|-ObjectComparer<TemplateAsset.AttributeOverride>.Compare
	|
	|-RVA: 0x10B8A00 Offset: 0x10B7400 VA: 0x1810B8A00
	|-ObjectComparer<TextSettings.FontReferenceMap>.Compare
	|
	|-RVA: 0x10BAA90 Offset: 0x10B9490 VA: 0x1810BAA90
	|-ObjectComparer<TextureBlitter.BlitInfo>.Compare
	|
	|-RVA: 0x10BA890 Offset: 0x10B9290 VA: 0x1810BA890
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.Compare
	|
	|-RVA: 0x10B3B10 Offset: 0x10B2510 VA: 0x1810B3B10
	|-ObjectComparer<TextureRegistry.TextureInfo>.Compare
	|
	|-RVA: 0x10B8090 Offset: 0x10B6A90 VA: 0x1810B8090
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.Compare
	|
	|-RVA: 0x10B7CE0 Offset: 0x10B66E0 VA: 0x1810B7CE0
	|-ObjectComparer<TrackedDeviceRaycaster.RaycastHitData>.Compare
	|
	|-RVA: 0x10B4B20 Offset: 0x10B3520 VA: 0x1810B4B20
	|-ObjectComparer<TransportManager.DisconnectingClient>.Compare
	|
	|-RVA: 0x10B6EB0 Offset: 0x10B58B0 VA: 0x1810B6EB0
	|-ObjectComparer<UIRStylePainter.Entry>.Compare
	|
	|-RVA: 0x10B6220 Offset: 0x10B4C20 VA: 0x1810B6220
	|-ObjectComparer<UIRStylePainter.RepeatRectUV>.Compare
	|
	|-RVA: 0x10B9D80 Offset: 0x10B8780 VA: 0x1810B9D80
	|-ObjectComparer<UIRenderDevice.AllocToFree>.Compare
	|
	|-RVA: 0x10BA560 Offset: 0x10B8F60 VA: 0x1810BA560
	|-ObjectComparer<UIRenderDevice.AllocToUpdate>.Compare
	|
	|-RVA: 0x10B3F10 Offset: 0x10B2910 VA: 0x1810B3F10
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Compare
	|
	|-RVA: 0x10B8740 Offset: 0x10B7140 VA: 0x1810B8740
	|-ObjectComparer<VisualTreeAsset.AssetEntry>.Compare
	|
	|-RVA: 0x10B26E0 Offset: 0x10B10E0 VA: 0x1810B26E0
	|-ObjectComparer<VisualTreeAsset.SlotDefinition>.Compare
	|
	|-RVA: 0x10B1580 Offset: 0x10AFF80 VA: 0x1810B1580
	|-ObjectComparer<VisualTreeAsset.SlotUsageEntry>.Compare
	|
	|-RVA: 0x10B3A20 Offset: 0x10B2420 VA: 0x1810B3A20
	|-ObjectComparer<VisualTreeAsset.UsingEntry>.Compare
	|
	|-RVA: 0x10B1E50 Offset: 0x10B0850 VA: 0x1810B1E50
	|-ObjectComparer<VisualTreeAsset.UxmlObjectEntry>.Compare
	|
	|-RVA: 0x10B7440 Offset: 0x10B5E40 VA: 0x1810B7440
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Compare
	|
	|-RVA: 0x10BB3E0 Offset: 0x10B9DE0 VA: 0x1810BB3E0
	|-ObjectComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Compare
	|
	|-RVA: 0x10B2980 Offset: 0x10B1380 VA: 0x1810B2980
	|-ObjectComparer<DebugUI.Foldout.ContextMenuItem>.Compare
	|
	|-RVA: 0x10BB1F0 Offset: 0x10B9BF0 VA: 0x1810BB1F0
	|-ObjectComparer<InputControlLayout.Collection.LayoutMatcher>.Compare
	|
	|-RVA: 0x10B12A0 Offset: 0x10AFCA0 VA: 0x1810B12A0
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.Compare
	|
	|-RVA: 0x10BA390 Offset: 0x10B8D90 VA: 0x1810BA390
	|-ObjectComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.Compare
	|
	|-RVA: 0x10B7EB0 Offset: 0x10B68B0 VA: 0x1810B7EB0
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.Compare
	|
	|-RVA: 0x10B5470 Offset: 0x10B3E70 VA: 0x1810B5470
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B1110 Offset: 0x10AFB10 VA: 0x1810B1110
	|-ObjectComparer<ArraySegment<byte>>.Equals
	|-ObjectComparer<SyncList.CachedOnChange<int>>.Equals
	|-ObjectComparer<SyncList.ChangeData<int>>.Equals
	|-ObjectComparer<IntervalTree.Entry<object>>.Equals
	|-ObjectComparer<KeyValuePair<int, object>>.Equals
	|-ObjectComparer<KeyValuePair<object, bool>>.Equals
	|-ObjectComparer<KeyValuePair<object, char>>.Equals
	|-ObjectComparer<KeyValuePair<object, object>>.Equals
	|-ObjectComparer<KeyValuePair<object, JsonParser.JsonValue>>.Equals
	|-ObjectComparer<KeyValuePair<PropertyName, object>>.Equals
	|-ObjectComparer<KeyValuePair<Rect, object>>.Equals
	|-ObjectComparer<NativeArray<ConvertMeshJobData>>.Equals
	|-ObjectComparer<NativeArray<CopyClosingMeshJobData>>.Equals
	|-ObjectComparer<NativeArray<NudgeJobData>>.Equals
	|-ObjectComparer<NativeSlice<ConvertMeshJobData>>.Equals
	|-ObjectComparer<NativeSlice<CopyClosingMeshJobData>>.Equals
	|-ObjectComparer<NativeSlice<NudgeJobData>>.Equals
	|-ObjectComparer<Nullable<DateTime>>.Equals
	|-ObjectComparer<Nullable<Decimal>>.Equals
	|-ObjectComparer<TempAllocator.Page<ushort>>.Equals
	|-ObjectComparer<TempAllocator.Page<Vertex>>.Equals
	|-ObjectComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.Equals
	|-ObjectComparer<StructMultiKey<object, object>>.Equals
	|-ObjectComparer<SubArray<int>>.Equals
	|-ObjectComparer<ValueTuple<bool>>.Equals
	|-ObjectComparer<ValueTuple<int, int>>.Equals
	|-ObjectComparer<ValueTuple<int, object>>.Equals
	|-ObjectComparer<ValueTuple<int, Scene>>.Equals
	|-ObjectComparer<ValueTuple<int, Vector2Int>>.Equals
	|-ObjectComparer<ValueTuple<object, ValueTuple<object, int>>>.Equals
	|-ObjectComparer<ValueTuple<object, int>>.Equals
	|-ObjectComparer<ValueTuple<object, object>>.Equals
	|-ObjectComparer<AnimatorClipInfo>.Equals
	|-ObjectComparer<AsyncGPUReadbackRequest>.Equals
	|-ObjectComparer<BezierContour>.Equals
	|-ObjectComparer<BezierPathSegment>.Equals
	|-ObjectComparer<BezierSegment>.Equals
	|-ObjectComparer<bool>.Equals
	|-ObjectComparer<Bounds>.Equals
	|-ObjectComparer<byte>.Equals
	|-ObjectComparer<CGSpot>.Equals
	|-ObjectComparer<char>.Equals
	|-ObjectComparer<Color>.Equals
	|-ObjectComparer<Color32>.Equals
	|-ObjectComparer<CombineInstance>.Equals
	|-ObjectComparer<ComputedTransitionProperty>.Equals
	|-ObjectComparer<Connection>.Equals
	|-ObjectComparer<ContourVertex>.Equals
	|-ObjectComparer<ControlPointOption>.Equals
	|-ObjectComparer<CoordinateFootprintTilePair>.Equals
	|-ObjectComparer<CoordinateProceduralTilePair>.Equals
	|-ObjectComparer<CoordinateStorageFootprintTilePair>.Equals
	|-ObjectComparer<CoordinateStorageTilePair>.Equals
	|-ObjectComparer<CoordinateTilePair>.Equals
	|-ObjectComparer<DateTime>.Equals
	|-ObjectComparer<DateTimeOffset>.Equals
	|-ObjectComparer<Decimal>.Equals
	|-ObjectComparer<DisplayInfo>.Equals
	|-ObjectComparer<double>.Equals
	|-ObjectComparer<DoublePoint>.Equals
	|-ObjectComparer<DoublePoint>.Equals
	|-ObjectComparer<DualPrefab>.Equals
	|-ObjectComparer<DuplicateSamplePoint>.Equals
	|-ObjectComparer<EasingFunction>.Equals
	|-ObjectComparer<Entry>.Equals
	|-ObjectComparer<EventSummary>.Equals
	|-ObjectComparer<FrameTimeSample>.Equals
	|-ObjectComparer<GlyphPairAdjustmentRecord>.Equals
	|-ObjectComparer<GlyphRect>.Equals
	|-ObjectComparer<Guid>.Equals
	|-ObjectComparer<InputBinding>.Equals
	|-ObjectComparer<InputDeviceDescription>.Equals
	|-ObjectComparer<InputEventPtr>.Equals
	|-ObjectComparer<short>.Equals
	|-ObjectComparer<Int3>.Equals
	|-ObjectComparer<int>.Equals
	|-ObjectComparer<Int32Enum>.Equals
	|-ObjectComparer<long>.Equals
	|-ObjectComparer<IntPoint>.Equals
	|-ObjectComparer<IntPoint>.Equals
	|-ObjectComparer<IntPtr>.Equals
	|-ObjectComparer<IntRect>.Equals
	|-ObjectComparer<IntRegion>.Equals
	|-ObjectComparer<InternedString>.Equals
	|-ObjectComparer<InterpretedFrameInfo>.Equals
	|-ObjectComparer<IntervalTreeNode>.Equals
	|-ObjectComparer<JsonPosition>.Equals
	|-ObjectComparer<Label>.Equals
	|-ObjectComparer<LigatureSubstitutionRecord>.Equals
	|-ObjectComparer<LigatureSubstitutionRecord>.Equals
	|-ObjectComparer<ManipulatorActivationFilter>.Equals
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.Equals
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.Equals
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.Equals
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.Equals
	|-ObjectComparer<Matrix4x4>.Equals
	|-ObjectComparer<MultipleSubstitutionRecord>.Equals
	|-ObjectComparer<MultipleSubstitutionRecord>.Equals
	|-ObjectComparer<NameAndParameters>.Equals
	|-ObjectComparer<NamedValue>.Equals
	|-ObjectComparer<NavMeshBuildMarkup>.Equals
	|-ObjectComparer<NavMeshBuildSource>.Equals
	|-ObjectComparer<object>.Equals
	|-ObjectComparer<Playable>.Equals
	|-ObjectComparer<PlayableBinding>.Equals
	|-ObjectComparer<PlayerLoopSystem>.Equals
	|-ObjectComparer<PlayerLoopSystemInternal>.Equals
	|-ObjectComparer<Quaternion>.Equals
	|-ObjectComparer<RangePositionInfo>.Equals
	|-ObjectComparer<RaycastHit>.Equals
	|-ObjectComparer<RaycastHit2D>.Equals
	|-ObjectComparer<RaycastResult>.Equals
	|-ObjectComparer<RectInt>.Equals
	|-ObjectComparer<RenderTargetIdentifier>.Equals
	|-ObjectComparer<RendererList>.Equals
	|-ObjectComparer<RendererListHandle>.Equals
	|-ObjectComparer<Resolution>.Equals
	|-ObjectComparer<ResourceHandle>.Equals
	|-ObjectComparer<RuleMatcher>.Equals
	|-ObjectComparer<sbyte>.Equals
	|-ObjectComparer<SamplePointUData>.Equals
	|-ObjectComparer<SamplePointsPatch>.Equals
	|-ObjectComparer<Scene>.Equals
	|-ObjectComparer<SelectorMatchRecord>.Equals
	|-ObjectComparer<ShaderTagId>.Equals
	|-ObjectComparer<float>.Equals
	|-ObjectComparer<StylePropertyName>.Equals
	|-ObjectComparer<StylePropertyValue>.Equals
	|-ObjectComparer<StyleSelectorPart>.Equals
	|-ObjectComparer<StyleSyntaxToken>.Equals
	|-ObjectComparer<StyleValue>.Equals
	|-ObjectComparer<StyleValueManaged>.Equals
	|-ObjectComparer<StyleVariable>.Equals
	|-ObjectComparer<Substring>.Equals
	|-ObjectComparer<TimeSpan>.Equals
	|-ObjectComparer<TimeValue>.Equals
	|-ObjectComparer<TreeViewItemWrapper>.Equals
	|-ObjectComparer<UICharInfo>.Equals
	|-ObjectComparer<UILineInfo>.Equals
	|-ObjectComparer<UIVertex>.Equals
	|-ObjectComparer<ushort>.Equals
	|-ObjectComparer<uint>.Equals
	|-ObjectComparer<UInt32Enum>.Equals
	|-ObjectComparer<ulong>.Equals
	|-ObjectComparer<UShort2>.Equals
	|-ObjectComparer<UnloadedScene>.Equals
	|-ObjectComparer<UsageHint>.Equals
	|-ObjectComparer<Vector2>.Equals
	|-ObjectComparer<Vector2Int>.Equals
	|-ObjectComparer<Vector3>.Equals
	|-ObjectComparer<Vector4>.Equals
	|-ObjectComparer<VoxelContour>.Equals
	|-ObjectComparer<Win32_IP_ADAPTER_ADDRESSES>.Equals
	|-ObjectComparer<X509ChainStatus>.Equals
	|-ObjectComparer<XRFeatureDescriptor>.Equals
	|-ObjectComparer<XRView>.Equals
	|-ObjectComparer<ZipGenericExtraField>.Equals
	|-ObjectComparer<__Il2CppFullySharedGenericType>.Equals
	|-ObjectComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Equals
	|-ObjectComparer<AdvancedSmooth.Turn>.Equals
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.Equals
	|-ObjectComparer<AvatarSettings.LayerSetting>.Equals
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.Equals
	|-ObjectComparer<BitmapAllocator32.Page>.Equals
	|-ObjectComparer<CameraState.CustomBlendable>.Equals
	|-ObjectComparer<CinemachineClearShot.Pair>.Equals
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.Equals
	|-ObjectComparer<ClipperLib.DoublePoint>.Equals
	|-ObjectComparer<ClipperLib.IntPoint>.Equals
	|-ObjectComparer<ConfinerOven.PolygonSolution>.Equals
	|-ObjectComparer<DecalEntityIndexer.DecalEntityItem>.Equals
	|-ObjectComparer<DecalEntityManager.CombinedChunks>.Equals
	|-ObjectComparer<FocusController.FocusedElement>.Equals
	|-ObjectComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.Equals
	|-ObjectComparer<Funnel.PathPart>.Equals
	|-ObjectComparer<GodRaysRenderPass.VisibleLightRemap>.Equals
	|-ObjectComparer<HID.HIDCollectionDescriptor>.Equals
	|-ObjectComparer<HID.HIDElementDescriptor>.Equals
	|-ObjectComparer<HIDParser.HIDReportData>.Equals
	|-ObjectComparer<HeatmapManager.PropertyRegionReference>.Equals
	|-ObjectComparer<InputActionMap.BindingOverrideJson>.Equals
	|-ObjectComparer<InputControlLayout.ControlItem>.Equals
	|-ObjectComparer<InputTransformSpots.TransformSpot>.Equals
	|-ObjectComparer<JsonParser.JsonValue>.Equals
	|-ObjectComparer<LatencySimulator.Message>.Equals
	|-ObjectComparer<MultiColumnCollectionHeader.SortedColumnState>.Equals
	|-ObjectComparer<NativeMethods.TASKDIALOG_BUTTON>.Equals
	|-ObjectComparer<NetworkAnimator.TriggerUpdate>.Equals
	|-ObjectComparer<OutlineEffect.OutlineTargetGroup>.Equals
	|-ObjectComparer<PlayingCard.CardData>.Equals
	|-ObjectComparer<ProbeBrickIndex.ReservedBrick>.Equals
	|-ObjectComparer<ProbeBrickPool.BrickChunkAlloc>.Equals
	|-ObjectComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Equals
	|-ObjectComparer<ProbeVolumeSceneData.SerializableBoundItem>.Equals
	|-ObjectComparer<ProbeVolumeSceneData.SerializableHasPVItem>.Equals
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.Equals
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVProfile>.Equals
	|-ObjectComparer<RegexCharClass.SingleRange>.Equals
	|-ObjectComparer<RenderChain.RenderNodeData>.Equals
	|-ObjectComparer<RenderGraphDebugData.PassDebugData>.Equals
	|-ObjectComparer<RenderGraphDebugData.ResourceDebugData>.Equals
	|-ObjectComparer<RetainedGizmos.MeshWithHash>.Equals
	|-ObjectComparer<RigidbodyPauser.Rigidbody2DData>.Equals
	|-ObjectComparer<RigidbodyPauser.RigidbodyData>.Equals
	|-ObjectComparer<RigidbodyPrediction.MoveData>.Equals
	|-ObjectComparer<SVGDocument.HierarchyUpdate>.Equals
	|-ObjectComparer<SVGDocument.NodeReferenceData>.Equals
	|-ObjectComparer<SVGDocument.NodeWithParent>.Equals
	|-ObjectComparer<SVGDocument.PostponedClip>.Equals
	|-ObjectComparer<SVGDocument.PostponedStopData>.Equals
	|-ObjectComparer<ServerSocket.ConnectionChange>.Equals
	|-ObjectComparer<SewerMushroomLocation.MushroomLocationData>.Equals
	|-ObjectComparer<ShadowUtility.Edge>.Equals
	|-ObjectComparer<StructySync.ChangeData>.Equals
	|-ObjectComparer<SyncStopwatch.ChangeData>.Equals
	|-ObjectComparer<SyncTimer.ChangeData>.Equals
	|-ObjectComparer<TargetStateListener.Callback>.Equals
	|-ObjectComparer<TemplateAsset.AttributeOverride>.Equals
	|-ObjectComparer<TextSettings.FontReferenceMap>.Equals
	|-ObjectComparer<TextureBlitter.BlitInfo>.Equals
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.Equals
	|-ObjectComparer<TextureRegistry.TextureInfo>.Equals
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.Equals
	|-ObjectComparer<TrackedDeviceRaycaster.RaycastHitData>.Equals
	|-ObjectComparer<TransportManager.DisconnectingClient>.Equals
	|-ObjectComparer<UIRStylePainter.Entry>.Equals
	|-ObjectComparer<UIRStylePainter.RepeatRectUV>.Equals
	|-ObjectComparer<UIRenderDevice.AllocToFree>.Equals
	|-ObjectComparer<UIRenderDevice.AllocToUpdate>.Equals
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.Equals
	|-ObjectComparer<VisualTreeAsset.AssetEntry>.Equals
	|-ObjectComparer<VisualTreeAsset.SlotDefinition>.Equals
	|-ObjectComparer<VisualTreeAsset.SlotUsageEntry>.Equals
	|-ObjectComparer<VisualTreeAsset.UsingEntry>.Equals
	|-ObjectComparer<VisualTreeAsset.UxmlObjectEntry>.Equals
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Equals
	|-ObjectComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Equals
	|-ObjectComparer<DebugUI.Foldout.ContextMenuItem>.Equals
	|-ObjectComparer<InputControlLayout.Collection.LayoutMatcher>.Equals
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.Equals
	|-ObjectComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.Equals
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.Equals
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10561A0 Offset: 0x1054BA0 VA: 0x1810561A0
	|-ObjectComparer<ArraySegment<byte>>.GetHashCode
	|-ObjectComparer<SyncList.CachedOnChange<int>>.GetHashCode
	|-ObjectComparer<SyncList.ChangeData<int>>.GetHashCode
	|-ObjectComparer<IntervalTree.Entry<object>>.GetHashCode
	|-ObjectComparer<KeyValuePair<int, object>>.GetHashCode
	|-ObjectComparer<KeyValuePair<object, bool>>.GetHashCode
	|-ObjectComparer<KeyValuePair<object, char>>.GetHashCode
	|-ObjectComparer<KeyValuePair<object, object>>.GetHashCode
	|-ObjectComparer<KeyValuePair<object, JsonParser.JsonValue>>.GetHashCode
	|-ObjectComparer<KeyValuePair<PropertyName, object>>.GetHashCode
	|-ObjectComparer<KeyValuePair<Rect, object>>.GetHashCode
	|-ObjectComparer<NativeArray<ConvertMeshJobData>>.GetHashCode
	|-ObjectComparer<NativeArray<CopyClosingMeshJobData>>.GetHashCode
	|-ObjectComparer<NativeArray<NudgeJobData>>.GetHashCode
	|-ObjectComparer<NativeSlice<ConvertMeshJobData>>.GetHashCode
	|-ObjectComparer<NativeSlice<CopyClosingMeshJobData>>.GetHashCode
	|-ObjectComparer<NativeSlice<NudgeJobData>>.GetHashCode
	|-ObjectComparer<Nullable<DateTime>>.GetHashCode
	|-ObjectComparer<Nullable<Decimal>>.GetHashCode
	|-ObjectComparer<TempAllocator.Page<ushort>>.GetHashCode
	|-ObjectComparer<TempAllocator.Page<Vertex>>.GetHashCode
	|-ObjectComparer<RenderGraphResourcePool.ResourceLogInfo<object>>.GetHashCode
	|-ObjectComparer<StructMultiKey<object, object>>.GetHashCode
	|-ObjectComparer<SubArray<int>>.GetHashCode
	|-ObjectComparer<ValueTuple<bool>>.GetHashCode
	|-ObjectComparer<ValueTuple<int, int>>.GetHashCode
	|-ObjectComparer<ValueTuple<int, object>>.GetHashCode
	|-ObjectComparer<ValueTuple<int, Scene>>.GetHashCode
	|-ObjectComparer<ValueTuple<int, Vector2Int>>.GetHashCode
	|-ObjectComparer<ValueTuple<object, ValueTuple<object, int>>>.GetHashCode
	|-ObjectComparer<ValueTuple<object, int>>.GetHashCode
	|-ObjectComparer<ValueTuple<object, object>>.GetHashCode
	|-ObjectComparer<AnimatorClipInfo>.GetHashCode
	|-ObjectComparer<AsyncGPUReadbackRequest>.GetHashCode
	|-ObjectComparer<BezierContour>.GetHashCode
	|-ObjectComparer<BezierPathSegment>.GetHashCode
	|-ObjectComparer<BezierSegment>.GetHashCode
	|-ObjectComparer<bool>.GetHashCode
	|-ObjectComparer<Bounds>.GetHashCode
	|-ObjectComparer<byte>.GetHashCode
	|-ObjectComparer<CGSpot>.GetHashCode
	|-ObjectComparer<char>.GetHashCode
	|-ObjectComparer<Color>.GetHashCode
	|-ObjectComparer<Color32>.GetHashCode
	|-ObjectComparer<CombineInstance>.GetHashCode
	|-ObjectComparer<ComputedTransitionProperty>.GetHashCode
	|-ObjectComparer<Connection>.GetHashCode
	|-ObjectComparer<ContourVertex>.GetHashCode
	|-ObjectComparer<ControlPointOption>.GetHashCode
	|-ObjectComparer<CoordinateFootprintTilePair>.GetHashCode
	|-ObjectComparer<CoordinateProceduralTilePair>.GetHashCode
	|-ObjectComparer<CoordinateStorageFootprintTilePair>.GetHashCode
	|-ObjectComparer<CoordinateStorageTilePair>.GetHashCode
	|-ObjectComparer<CoordinateTilePair>.GetHashCode
	|-ObjectComparer<DateTime>.GetHashCode
	|-ObjectComparer<DateTimeOffset>.GetHashCode
	|-ObjectComparer<Decimal>.GetHashCode
	|-ObjectComparer<DisplayInfo>.GetHashCode
	|-ObjectComparer<double>.GetHashCode
	|-ObjectComparer<DoublePoint>.GetHashCode
	|-ObjectComparer<DoublePoint>.GetHashCode
	|-ObjectComparer<DualPrefab>.GetHashCode
	|-ObjectComparer<DuplicateSamplePoint>.GetHashCode
	|-ObjectComparer<EasingFunction>.GetHashCode
	|-ObjectComparer<Entry>.GetHashCode
	|-ObjectComparer<EventSummary>.GetHashCode
	|-ObjectComparer<FrameTimeSample>.GetHashCode
	|-ObjectComparer<GlyphPairAdjustmentRecord>.GetHashCode
	|-ObjectComparer<GlyphRect>.GetHashCode
	|-ObjectComparer<Guid>.GetHashCode
	|-ObjectComparer<InputBinding>.GetHashCode
	|-ObjectComparer<InputDeviceDescription>.GetHashCode
	|-ObjectComparer<InputEventPtr>.GetHashCode
	|-ObjectComparer<short>.GetHashCode
	|-ObjectComparer<Int3>.GetHashCode
	|-ObjectComparer<int>.GetHashCode
	|-ObjectComparer<Int32Enum>.GetHashCode
	|-ObjectComparer<long>.GetHashCode
	|-ObjectComparer<IntPoint>.GetHashCode
	|-ObjectComparer<IntPoint>.GetHashCode
	|-ObjectComparer<IntPtr>.GetHashCode
	|-ObjectComparer<IntRect>.GetHashCode
	|-ObjectComparer<IntRegion>.GetHashCode
	|-ObjectComparer<InternedString>.GetHashCode
	|-ObjectComparer<InterpretedFrameInfo>.GetHashCode
	|-ObjectComparer<IntervalTreeNode>.GetHashCode
	|-ObjectComparer<JsonPosition>.GetHashCode
	|-ObjectComparer<Label>.GetHashCode
	|-ObjectComparer<LigatureSubstitutionRecord>.GetHashCode
	|-ObjectComparer<LigatureSubstitutionRecord>.GetHashCode
	|-ObjectComparer<ManipulatorActivationFilter>.GetHashCode
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.GetHashCode
	|-ObjectComparer<MarkToBaseAdjustmentRecord>.GetHashCode
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.GetHashCode
	|-ObjectComparer<MarkToMarkAdjustmentRecord>.GetHashCode
	|-ObjectComparer<Matrix4x4>.GetHashCode
	|-ObjectComparer<MultipleSubstitutionRecord>.GetHashCode
	|-ObjectComparer<MultipleSubstitutionRecord>.GetHashCode
	|-ObjectComparer<NameAndParameters>.GetHashCode
	|-ObjectComparer<NamedValue>.GetHashCode
	|-ObjectComparer<NavMeshBuildMarkup>.GetHashCode
	|-ObjectComparer<NavMeshBuildSource>.GetHashCode
	|-ObjectComparer<object>.GetHashCode
	|-ObjectComparer<Playable>.GetHashCode
	|-ObjectComparer<PlayableBinding>.GetHashCode
	|-ObjectComparer<PlayerLoopSystem>.GetHashCode
	|-ObjectComparer<PlayerLoopSystemInternal>.GetHashCode
	|-ObjectComparer<Quaternion>.GetHashCode
	|-ObjectComparer<RangePositionInfo>.GetHashCode
	|-ObjectComparer<RaycastHit>.GetHashCode
	|-ObjectComparer<RaycastHit2D>.GetHashCode
	|-ObjectComparer<RaycastResult>.GetHashCode
	|-ObjectComparer<RectInt>.GetHashCode
	|-ObjectComparer<RenderTargetIdentifier>.GetHashCode
	|-ObjectComparer<RendererList>.GetHashCode
	|-ObjectComparer<RendererListHandle>.GetHashCode
	|-ObjectComparer<Resolution>.GetHashCode
	|-ObjectComparer<ResourceHandle>.GetHashCode
	|-ObjectComparer<RuleMatcher>.GetHashCode
	|-ObjectComparer<sbyte>.GetHashCode
	|-ObjectComparer<SamplePointUData>.GetHashCode
	|-ObjectComparer<SamplePointsPatch>.GetHashCode
	|-ObjectComparer<Scene>.GetHashCode
	|-ObjectComparer<SelectorMatchRecord>.GetHashCode
	|-ObjectComparer<ShaderTagId>.GetHashCode
	|-ObjectComparer<float>.GetHashCode
	|-ObjectComparer<StylePropertyName>.GetHashCode
	|-ObjectComparer<StylePropertyValue>.GetHashCode
	|-ObjectComparer<StyleSelectorPart>.GetHashCode
	|-ObjectComparer<StyleSyntaxToken>.GetHashCode
	|-ObjectComparer<StyleValue>.GetHashCode
	|-ObjectComparer<StyleValueManaged>.GetHashCode
	|-ObjectComparer<StyleVariable>.GetHashCode
	|-ObjectComparer<Substring>.GetHashCode
	|-ObjectComparer<TimeSpan>.GetHashCode
	|-ObjectComparer<TimeValue>.GetHashCode
	|-ObjectComparer<TreeViewItemWrapper>.GetHashCode
	|-ObjectComparer<UICharInfo>.GetHashCode
	|-ObjectComparer<UILineInfo>.GetHashCode
	|-ObjectComparer<UIVertex>.GetHashCode
	|-ObjectComparer<ushort>.GetHashCode
	|-ObjectComparer<uint>.GetHashCode
	|-ObjectComparer<UInt32Enum>.GetHashCode
	|-ObjectComparer<ulong>.GetHashCode
	|-ObjectComparer<UShort2>.GetHashCode
	|-ObjectComparer<UnloadedScene>.GetHashCode
	|-ObjectComparer<UsageHint>.GetHashCode
	|-ObjectComparer<Vector2>.GetHashCode
	|-ObjectComparer<Vector2Int>.GetHashCode
	|-ObjectComparer<Vector3>.GetHashCode
	|-ObjectComparer<Vector4>.GetHashCode
	|-ObjectComparer<VoxelContour>.GetHashCode
	|-ObjectComparer<Win32_IP_ADAPTER_ADDRESSES>.GetHashCode
	|-ObjectComparer<X509ChainStatus>.GetHashCode
	|-ObjectComparer<XRFeatureDescriptor>.GetHashCode
	|-ObjectComparer<XRView>.GetHashCode
	|-ObjectComparer<ZipGenericExtraField>.GetHashCode
	|-ObjectComparer<__Il2CppFullySharedGenericType>.GetHashCode
	|-ObjectComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.GetHashCode
	|-ObjectComparer<AdvancedSmooth.Turn>.GetHashCode
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>.GetHashCode
	|-ObjectComparer<AvatarSettings.LayerSetting>.GetHashCode
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>.GetHashCode
	|-ObjectComparer<BitmapAllocator32.Page>.GetHashCode
	|-ObjectComparer<CameraState.CustomBlendable>.GetHashCode
	|-ObjectComparer<CinemachineClearShot.Pair>.GetHashCode
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>.GetHashCode
	|-ObjectComparer<ClipperLib.DoublePoint>.GetHashCode
	|-ObjectComparer<ClipperLib.IntPoint>.GetHashCode
	|-ObjectComparer<ConfinerOven.PolygonSolution>.GetHashCode
	|-ObjectComparer<DecalEntityIndexer.DecalEntityItem>.GetHashCode
	|-ObjectComparer<DecalEntityManager.CombinedChunks>.GetHashCode
	|-ObjectComparer<FocusController.FocusedElement>.GetHashCode
	|-ObjectComparer<FrameTimingsHUDDisplay.FrameTimingPoint>.GetHashCode
	|-ObjectComparer<Funnel.PathPart>.GetHashCode
	|-ObjectComparer<GodRaysRenderPass.VisibleLightRemap>.GetHashCode
	|-ObjectComparer<HID.HIDCollectionDescriptor>.GetHashCode
	|-ObjectComparer<HID.HIDElementDescriptor>.GetHashCode
	|-ObjectComparer<HIDParser.HIDReportData>.GetHashCode
	|-ObjectComparer<HeatmapManager.PropertyRegionReference>.GetHashCode
	|-ObjectComparer<InputActionMap.BindingOverrideJson>.GetHashCode
	|-ObjectComparer<InputControlLayout.ControlItem>.GetHashCode
	|-ObjectComparer<InputTransformSpots.TransformSpot>.GetHashCode
	|-ObjectComparer<JsonParser.JsonValue>.GetHashCode
	|-ObjectComparer<LatencySimulator.Message>.GetHashCode
	|-ObjectComparer<MultiColumnCollectionHeader.SortedColumnState>.GetHashCode
	|-ObjectComparer<NativeMethods.TASKDIALOG_BUTTON>.GetHashCode
	|-ObjectComparer<NetworkAnimator.TriggerUpdate>.GetHashCode
	|-ObjectComparer<OutlineEffect.OutlineTargetGroup>.GetHashCode
	|-ObjectComparer<PlayingCard.CardData>.GetHashCode
	|-ObjectComparer<ProbeBrickIndex.ReservedBrick>.GetHashCode
	|-ObjectComparer<ProbeBrickPool.BrickChunkAlloc>.GetHashCode
	|-ObjectComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.GetHashCode
	|-ObjectComparer<ProbeVolumeSceneData.SerializableBoundItem>.GetHashCode
	|-ObjectComparer<ProbeVolumeSceneData.SerializableHasPVItem>.GetHashCode
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>.GetHashCode
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVProfile>.GetHashCode
	|-ObjectComparer<RegexCharClass.SingleRange>.GetHashCode
	|-ObjectComparer<RenderChain.RenderNodeData>.GetHashCode
	|-ObjectComparer<RenderGraphDebugData.PassDebugData>.GetHashCode
	|-ObjectComparer<RenderGraphDebugData.ResourceDebugData>.GetHashCode
	|-ObjectComparer<RetainedGizmos.MeshWithHash>.GetHashCode
	|-ObjectComparer<RigidbodyPauser.Rigidbody2DData>.GetHashCode
	|-ObjectComparer<RigidbodyPauser.RigidbodyData>.GetHashCode
	|-ObjectComparer<RigidbodyPrediction.MoveData>.GetHashCode
	|-ObjectComparer<SVGDocument.HierarchyUpdate>.GetHashCode
	|-ObjectComparer<SVGDocument.NodeReferenceData>.GetHashCode
	|-ObjectComparer<SVGDocument.NodeWithParent>.GetHashCode
	|-ObjectComparer<SVGDocument.PostponedClip>.GetHashCode
	|-ObjectComparer<SVGDocument.PostponedStopData>.GetHashCode
	|-ObjectComparer<ServerSocket.ConnectionChange>.GetHashCode
	|-ObjectComparer<SewerMushroomLocation.MushroomLocationData>.GetHashCode
	|-ObjectComparer<ShadowUtility.Edge>.GetHashCode
	|-ObjectComparer<StructySync.ChangeData>.GetHashCode
	|-ObjectComparer<SyncStopwatch.ChangeData>.GetHashCode
	|-ObjectComparer<SyncTimer.ChangeData>.GetHashCode
	|-ObjectComparer<TargetStateListener.Callback>.GetHashCode
	|-ObjectComparer<TemplateAsset.AttributeOverride>.GetHashCode
	|-ObjectComparer<TextSettings.FontReferenceMap>.GetHashCode
	|-ObjectComparer<TextureBlitter.BlitInfo>.GetHashCode
	|-ObjectComparer<TexturePacker_JsonArray.Frame>.GetHashCode
	|-ObjectComparer<TextureRegistry.TextureInfo>.GetHashCode
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>.GetHashCode
	|-ObjectComparer<TrackedDeviceRaycaster.RaycastHitData>.GetHashCode
	|-ObjectComparer<TransportManager.DisconnectingClient>.GetHashCode
	|-ObjectComparer<UIRStylePainter.Entry>.GetHashCode
	|-ObjectComparer<UIRStylePainter.RepeatRectUV>.GetHashCode
	|-ObjectComparer<UIRenderDevice.AllocToFree>.GetHashCode
	|-ObjectComparer<UIRenderDevice.AllocToUpdate>.GetHashCode
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>.GetHashCode
	|-ObjectComparer<VisualTreeAsset.AssetEntry>.GetHashCode
	|-ObjectComparer<VisualTreeAsset.SlotDefinition>.GetHashCode
	|-ObjectComparer<VisualTreeAsset.SlotUsageEntry>.GetHashCode
	|-ObjectComparer<VisualTreeAsset.UsingEntry>.GetHashCode
	|-ObjectComparer<VisualTreeAsset.UxmlObjectEntry>.GetHashCode
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetHashCode
	|-ObjectComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.GetHashCode
	|-ObjectComparer<DebugUI.Foldout.ContextMenuItem>.GetHashCode
	|-ObjectComparer<InputControlLayout.Collection.LayoutMatcher>.GetHashCode
	|-ObjectComparer<InstructionList.DebugView.InstructionView>.GetHashCode
	|-ObjectComparer<MultiColumnCollectionHeader.ViewState.ColumnState>.GetHashCode
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>.GetHashCode
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B1190 Offset: 0x10AFB90 VA: 0x1810B1190
	|-ObjectComparer<ArraySegment<byte>>..ctor
	|-ObjectComparer<SyncList.CachedOnChange<int>>..ctor
	|-ObjectComparer<SyncList.ChangeData<int>>..ctor
	|-ObjectComparer<IntervalTree.Entry<object>>..ctor
	|-ObjectComparer<KeyValuePair<int, object>>..ctor
	|-ObjectComparer<KeyValuePair<object, bool>>..ctor
	|-ObjectComparer<KeyValuePair<object, char>>..ctor
	|-ObjectComparer<KeyValuePair<object, object>>..ctor
	|-ObjectComparer<KeyValuePair<object, JsonParser.JsonValue>>..ctor
	|-ObjectComparer<KeyValuePair<PropertyName, object>>..ctor
	|-ObjectComparer<KeyValuePair<Rect, object>>..ctor
	|-ObjectComparer<NativeArray<ConvertMeshJobData>>..ctor
	|-ObjectComparer<NativeArray<CopyClosingMeshJobData>>..ctor
	|-ObjectComparer<NativeArray<NudgeJobData>>..ctor
	|-ObjectComparer<NativeSlice<ConvertMeshJobData>>..ctor
	|-ObjectComparer<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-ObjectComparer<NativeSlice<NudgeJobData>>..ctor
	|-ObjectComparer<Nullable<DateTime>>..ctor
	|-ObjectComparer<Nullable<Decimal>>..ctor
	|-ObjectComparer<TempAllocator.Page<ushort>>..ctor
	|-ObjectComparer<TempAllocator.Page<Vertex>>..ctor
	|-ObjectComparer<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|-ObjectComparer<StructMultiKey<object, object>>..ctor
	|-ObjectComparer<SubArray<int>>..ctor
	|-ObjectComparer<ValueTuple<bool>>..ctor
	|-ObjectComparer<ValueTuple<int, int>>..ctor
	|-ObjectComparer<ValueTuple<int, object>>..ctor
	|-ObjectComparer<ValueTuple<int, Scene>>..ctor
	|-ObjectComparer<ValueTuple<int, Vector2Int>>..ctor
	|-ObjectComparer<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-ObjectComparer<ValueTuple<object, int>>..ctor
	|-ObjectComparer<ValueTuple<object, object>>..ctor
	|-ObjectComparer<AnimatorClipInfo>..ctor
	|-ObjectComparer<AsyncGPUReadbackRequest>..ctor
	|-ObjectComparer<BezierContour>..ctor
	|-ObjectComparer<BezierPathSegment>..ctor
	|-ObjectComparer<BezierSegment>..ctor
	|-ObjectComparer<bool>..ctor
	|-ObjectComparer<Bounds>..ctor
	|-ObjectComparer<byte>..ctor
	|-ObjectComparer<CGSpot>..ctor
	|-ObjectComparer<char>..ctor
	|-ObjectComparer<Color>..ctor
	|-ObjectComparer<Color32>..ctor
	|-ObjectComparer<CombineInstance>..ctor
	|-ObjectComparer<ComputedTransitionProperty>..ctor
	|-ObjectComparer<Connection>..ctor
	|-ObjectComparer<ContourVertex>..ctor
	|-ObjectComparer<ControlPointOption>..ctor
	|-ObjectComparer<CoordinateFootprintTilePair>..ctor
	|-ObjectComparer<CoordinateProceduralTilePair>..ctor
	|-ObjectComparer<CoordinateStorageFootprintTilePair>..ctor
	|-ObjectComparer<CoordinateStorageTilePair>..ctor
	|-ObjectComparer<CoordinateTilePair>..ctor
	|-ObjectComparer<DateTime>..ctor
	|-ObjectComparer<DateTimeOffset>..ctor
	|-ObjectComparer<Decimal>..ctor
	|-ObjectComparer<DisplayInfo>..ctor
	|-ObjectComparer<double>..ctor
	|-ObjectComparer<DoublePoint>..ctor
	|-ObjectComparer<DoublePoint>..ctor
	|-ObjectComparer<DualPrefab>..ctor
	|-ObjectComparer<DuplicateSamplePoint>..ctor
	|-ObjectComparer<EasingFunction>..ctor
	|-ObjectComparer<Entry>..ctor
	|-ObjectComparer<EventSummary>..ctor
	|-ObjectComparer<FrameTimeSample>..ctor
	|-ObjectComparer<GlyphPairAdjustmentRecord>..ctor
	|-ObjectComparer<GlyphRect>..ctor
	|-ObjectComparer<Guid>..ctor
	|-ObjectComparer<InputBinding>..ctor
	|-ObjectComparer<InputDeviceDescription>..ctor
	|-ObjectComparer<InputEventPtr>..ctor
	|-ObjectComparer<short>..ctor
	|-ObjectComparer<Int3>..ctor
	|-ObjectComparer<int>..ctor
	|-ObjectComparer<Int32Enum>..ctor
	|-ObjectComparer<long>..ctor
	|-ObjectComparer<IntPoint>..ctor
	|-ObjectComparer<IntPoint>..ctor
	|-ObjectComparer<IntPtr>..ctor
	|-ObjectComparer<IntRect>..ctor
	|-ObjectComparer<IntRegion>..ctor
	|-ObjectComparer<InternedString>..ctor
	|-ObjectComparer<InterpretedFrameInfo>..ctor
	|-ObjectComparer<IntervalTreeNode>..ctor
	|-ObjectComparer<JsonPosition>..ctor
	|-ObjectComparer<Label>..ctor
	|-ObjectComparer<LigatureSubstitutionRecord>..ctor
	|-ObjectComparer<LigatureSubstitutionRecord>..ctor
	|-ObjectComparer<ManipulatorActivationFilter>..ctor
	|-ObjectComparer<MarkToBaseAdjustmentRecord>..ctor
	|-ObjectComparer<MarkToBaseAdjustmentRecord>..ctor
	|-ObjectComparer<MarkToMarkAdjustmentRecord>..ctor
	|-ObjectComparer<MarkToMarkAdjustmentRecord>..ctor
	|-ObjectComparer<Matrix4x4>..ctor
	|-ObjectComparer<MultipleSubstitutionRecord>..ctor
	|-ObjectComparer<MultipleSubstitutionRecord>..ctor
	|-ObjectComparer<NameAndParameters>..ctor
	|-ObjectComparer<NamedValue>..ctor
	|-ObjectComparer<NavMeshBuildMarkup>..ctor
	|-ObjectComparer<NavMeshBuildSource>..ctor
	|-ObjectComparer<object>..ctor
	|-ObjectComparer<Playable>..ctor
	|-ObjectComparer<PlayableBinding>..ctor
	|-ObjectComparer<PlayerLoopSystem>..ctor
	|-ObjectComparer<PlayerLoopSystemInternal>..ctor
	|-ObjectComparer<Quaternion>..ctor
	|-ObjectComparer<RangePositionInfo>..ctor
	|-ObjectComparer<RaycastHit>..ctor
	|-ObjectComparer<RaycastHit2D>..ctor
	|-ObjectComparer<RaycastResult>..ctor
	|-ObjectComparer<RectInt>..ctor
	|-ObjectComparer<RenderTargetIdentifier>..ctor
	|-ObjectComparer<RendererList>..ctor
	|-ObjectComparer<RendererListHandle>..ctor
	|-ObjectComparer<Resolution>..ctor
	|-ObjectComparer<ResourceHandle>..ctor
	|-ObjectComparer<RuleMatcher>..ctor
	|-ObjectComparer<sbyte>..ctor
	|-ObjectComparer<SamplePointUData>..ctor
	|-ObjectComparer<SamplePointsPatch>..ctor
	|-ObjectComparer<Scene>..ctor
	|-ObjectComparer<SelectorMatchRecord>..ctor
	|-ObjectComparer<ShaderTagId>..ctor
	|-ObjectComparer<float>..ctor
	|-ObjectComparer<StylePropertyName>..ctor
	|-ObjectComparer<StylePropertyValue>..ctor
	|-ObjectComparer<StyleSelectorPart>..ctor
	|-ObjectComparer<StyleSyntaxToken>..ctor
	|-ObjectComparer<StyleValue>..ctor
	|-ObjectComparer<StyleValueManaged>..ctor
	|-ObjectComparer<StyleVariable>..ctor
	|-ObjectComparer<Substring>..ctor
	|-ObjectComparer<TimeSpan>..ctor
	|-ObjectComparer<TimeValue>..ctor
	|-ObjectComparer<TreeViewItemWrapper>..ctor
	|-ObjectComparer<UICharInfo>..ctor
	|-ObjectComparer<UILineInfo>..ctor
	|-ObjectComparer<UIVertex>..ctor
	|-ObjectComparer<ushort>..ctor
	|-ObjectComparer<uint>..ctor
	|-ObjectComparer<UInt32Enum>..ctor
	|-ObjectComparer<ulong>..ctor
	|-ObjectComparer<UShort2>..ctor
	|-ObjectComparer<UnloadedScene>..ctor
	|-ObjectComparer<UsageHint>..ctor
	|-ObjectComparer<Vector2>..ctor
	|-ObjectComparer<Vector2Int>..ctor
	|-ObjectComparer<Vector3>..ctor
	|-ObjectComparer<Vector4>..ctor
	|-ObjectComparer<VoxelContour>..ctor
	|-ObjectComparer<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|-ObjectComparer<X509ChainStatus>..ctor
	|-ObjectComparer<XRFeatureDescriptor>..ctor
	|-ObjectComparer<XRView>..ctor
	|-ObjectComparer<ZipGenericExtraField>..ctor
	|-ObjectComparer<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..ctor
	|-ObjectComparer<AdvancedSmooth.Turn>..ctor
	|-ObjectComparer<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|-ObjectComparer<AvatarSettings.LayerSetting>..ctor
	|-ObjectComparer<BeforeRenderHelper.OrderBlock>..ctor
	|-ObjectComparer<BitmapAllocator32.Page>..ctor
	|-ObjectComparer<CameraState.CustomBlendable>..ctor
	|-ObjectComparer<CinemachineClearShot.Pair>..ctor
	|-ObjectComparer<CinemachineStateDrivenCamera.HashPair>..ctor
	|-ObjectComparer<ClipperLib.DoublePoint>..ctor
	|-ObjectComparer<ClipperLib.IntPoint>..ctor
	|-ObjectComparer<ConfinerOven.PolygonSolution>..ctor
	|-ObjectComparer<DecalEntityIndexer.DecalEntityItem>..ctor
	|-ObjectComparer<DecalEntityManager.CombinedChunks>..ctor
	|-ObjectComparer<FocusController.FocusedElement>..ctor
	|-ObjectComparer<FrameTimingsHUDDisplay.FrameTimingPoint>..ctor
	|-ObjectComparer<Funnel.PathPart>..ctor
	|-ObjectComparer<GodRaysRenderPass.VisibleLightRemap>..ctor
	|-ObjectComparer<HID.HIDCollectionDescriptor>..ctor
	|-ObjectComparer<HID.HIDElementDescriptor>..ctor
	|-ObjectComparer<HIDParser.HIDReportData>..ctor
	|-ObjectComparer<HeatmapManager.PropertyRegionReference>..ctor
	|-ObjectComparer<InputActionMap.BindingOverrideJson>..ctor
	|-ObjectComparer<InputControlLayout.ControlItem>..ctor
	|-ObjectComparer<InputTransformSpots.TransformSpot>..ctor
	|-ObjectComparer<JsonParser.JsonValue>..ctor
	|-ObjectComparer<LatencySimulator.Message>..ctor
	|-ObjectComparer<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-ObjectComparer<NativeMethods.TASKDIALOG_BUTTON>..ctor
	|-ObjectComparer<NetworkAnimator.TriggerUpdate>..ctor
	|-ObjectComparer<OutlineEffect.OutlineTargetGroup>..ctor
	|-ObjectComparer<PlayingCard.CardData>..ctor
	|-ObjectComparer<ProbeBrickIndex.ReservedBrick>..ctor
	|-ObjectComparer<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-ObjectComparer<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..ctor
	|-ObjectComparer<ProbeVolumeSceneData.SerializableBoundItem>..ctor
	|-ObjectComparer<ProbeVolumeSceneData.SerializableHasPVItem>..ctor
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVBakeSettings>..ctor
	|-ObjectComparer<ProbeVolumeSceneData.SerializablePVProfile>..ctor
	|-ObjectComparer<RegexCharClass.SingleRange>..ctor
	|-ObjectComparer<RenderChain.RenderNodeData>..ctor
	|-ObjectComparer<RenderGraphDebugData.PassDebugData>..ctor
	|-ObjectComparer<RenderGraphDebugData.ResourceDebugData>..ctor
	|-ObjectComparer<RetainedGizmos.MeshWithHash>..ctor
	|-ObjectComparer<RigidbodyPauser.Rigidbody2DData>..ctor
	|-ObjectComparer<RigidbodyPauser.RigidbodyData>..ctor
	|-ObjectComparer<RigidbodyPrediction.MoveData>..ctor
	|-ObjectComparer<SVGDocument.HierarchyUpdate>..ctor
	|-ObjectComparer<SVGDocument.NodeReferenceData>..ctor
	|-ObjectComparer<SVGDocument.NodeWithParent>..ctor
	|-ObjectComparer<SVGDocument.PostponedClip>..ctor
	|-ObjectComparer<SVGDocument.PostponedStopData>..ctor
	|-ObjectComparer<ServerSocket.ConnectionChange>..ctor
	|-ObjectComparer<SewerMushroomLocation.MushroomLocationData>..ctor
	|-ObjectComparer<ShadowUtility.Edge>..ctor
	|-ObjectComparer<StructySync.ChangeData>..ctor
	|-ObjectComparer<SyncStopwatch.ChangeData>..ctor
	|-ObjectComparer<SyncTimer.ChangeData>..ctor
	|-ObjectComparer<TargetStateListener.Callback>..ctor
	|-ObjectComparer<TemplateAsset.AttributeOverride>..ctor
	|-ObjectComparer<TextSettings.FontReferenceMap>..ctor
	|-ObjectComparer<TextureBlitter.BlitInfo>..ctor
	|-ObjectComparer<TexturePacker_JsonArray.Frame>..ctor
	|-ObjectComparer<TextureRegistry.TextureInfo>..ctor
	|-ObjectComparer<TimeNotificationBehaviour.NotificationEntry>..ctor
	|-ObjectComparer<TrackedDeviceRaycaster.RaycastHitData>..ctor
	|-ObjectComparer<TransportManager.DisconnectingClient>..ctor
	|-ObjectComparer<UIRStylePainter.Entry>..ctor
	|-ObjectComparer<UIRStylePainter.RepeatRectUV>..ctor
	|-ObjectComparer<UIRenderDevice.AllocToFree>..ctor
	|-ObjectComparer<UIRenderDevice.AllocToUpdate>..ctor
	|-ObjectComparer<UnitySynchronizationContext.WorkRequest>..ctor
	|-ObjectComparer<VisualTreeAsset.AssetEntry>..ctor
	|-ObjectComparer<VisualTreeAsset.SlotDefinition>..ctor
	|-ObjectComparer<VisualTreeAsset.SlotUsageEntry>..ctor
	|-ObjectComparer<VisualTreeAsset.UsingEntry>..ctor
	|-ObjectComparer<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-ObjectComparer<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-ObjectComparer<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..ctor
	|-ObjectComparer<DebugUI.Foldout.ContextMenuItem>..ctor
	|-ObjectComparer<InputControlLayout.Collection.LayoutMatcher>..ctor
	|-ObjectComparer<InstructionList.DebugView.InstructionView>..ctor
	|-ObjectComparer<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|-ObjectComparer<TargetPositionCache.CacheCurve.Item>..ctor
	|-ObjectComparer<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x10BBD40 Offset: 0x10BA740 VA: 0x1810BBD40
	|-ObjectComparer<__Il2CppFullySharedGenericType>..ctor
	*/
}
