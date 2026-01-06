internal class ArraySortHelper<T> // TypeDefIndex: 5007
{
	// Fields
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A39C0 Offset: 0x16A23C0 VA: 0x1816A39C0
	|-ArraySortHelper<ArraySegment<byte>>.Sort
	|
	|-RVA: 0x16A3BE0 Offset: 0x16A25E0 VA: 0x1816A3BE0
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.Sort
	|
	|-RVA: 0x16A6060 Offset: 0x16A4A60 VA: 0x1816A6060
	|-ArraySortHelper<SyncList.ChangeData<int>>.Sort
	|
	|-RVA: 0x16A66C0 Offset: 0x16A50C0 VA: 0x1816A66C0
	|-ArraySortHelper<IntervalTree.Entry<object>>.Sort
	|
	|-RVA: 0x16A5C20 Offset: 0x16A4620 VA: 0x1816A5C20
	|-ArraySortHelper<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x16A3360 Offset: 0x16A1D60 VA: 0x1816A3360
	|-ArraySortHelper<KeyValuePair<object, bool>>.Sort
	|
	|-RVA: 0x16A5A00 Offset: 0x16A4400 VA: 0x1816A5A00
	|-ArraySortHelper<KeyValuePair<object, char>>.Sort
	|
	|-RVA: 0x16A53A0 Offset: 0x16A3DA0 VA: 0x1816A53A0
	|-ArraySortHelper<KeyValuePair<object, object>>.Sort
	|
	|-RVA: 0x16A3E00 Offset: 0x16A2800 VA: 0x1816A3E00
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.Sort
	|
	|-RVA: 0x16A55C0 Offset: 0x16A3FC0 VA: 0x1816A55C0
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.Sort
	|
	|-RVA: 0x16A2F20 Offset: 0x16A1920 VA: 0x1816A2F20
	|-ArraySortHelper<KeyValuePair<Rect, object>>.Sort
	|
	|-RVA: 0x16A4680 Offset: 0x16A3080 VA: 0x1816A4680
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.Sort
	|
	|-RVA: 0x16A68E0 Offset: 0x16A52E0 VA: 0x1816A68E0
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.Sort
	|
	|-RVA: 0x16A4240 Offset: 0x16A2C40 VA: 0x1816A4240
	|-ArraySortHelper<NativeArray<NudgeJobData>>.Sort
	|
	|-RVA: 0x16A37A0 Offset: 0x16A21A0 VA: 0x1816A37A0
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.Sort
	|
	|-RVA: 0x16A4F60 Offset: 0x16A3960 VA: 0x1816A4F60
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.Sort
	|
	|-RVA: 0x16A5E40 Offset: 0x16A4840 VA: 0x1816A5E40
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.Sort
	|
	|-RVA: 0x16A6B00 Offset: 0x16A5500 VA: 0x1816A6B00
	|-ArraySortHelper<Nullable<DateTime>>.Sort
	|
	|-RVA: 0x16A3140 Offset: 0x16A1B40 VA: 0x1816A3140
	|-ArraySortHelper<Nullable<Decimal>>.Sort
	|
	|-RVA: 0x16A4460 Offset: 0x16A2E60 VA: 0x1816A4460
	|-ArraySortHelper<TempAllocator.Page<ushort>>.Sort
	|
	|-RVA: 0x16A49E0 Offset: 0x16A33E0 VA: 0x1816A49E0
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.Sort
	|
	|-RVA: 0x16A5180 Offset: 0x16A3B80 VA: 0x1816A5180
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|
	|-RVA: 0x16A57E0 Offset: 0x16A41E0 VA: 0x1816A57E0
	|-ArraySortHelper<StructMultiKey<object, object>>.Sort
	|
	|-RVA: 0x16A64A0 Offset: 0x16A4EA0 VA: 0x1816A64A0
	|-ArraySortHelper<SubArray<int>>.Sort
	|
	|-RVA: 0x16A4020 Offset: 0x16A2A20 VA: 0x1816A4020
	|-ArraySortHelper<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x16A3580 Offset: 0x16A1F80 VA: 0x1816A3580
	|-ArraySortHelper<ValueTuple<int, object>>.Sort
	|
	|-RVA: 0x16A6280 Offset: 0x16A4C80 VA: 0x1816A6280
	|-ArraySortHelper<ValueTuple<int, Scene>>.Sort
	|
	|-RVA: 0x16A4C00 Offset: 0x16A3600 VA: 0x1816A4C00
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.Sort
	|
	|-RVA: 0x17F9DA0 Offset: 0x17F87A0 VA: 0x1817F9DA0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|
	|-RVA: 0x17F73A0 Offset: 0x17F5DA0 VA: 0x1817F73A0
	|-ArraySortHelper<ValueTuple<object, object>>.Sort
	|
	|-RVA: 0x17FAF00 Offset: 0x17F9900 VA: 0x1817FAF00
	|-ArraySortHelper<AnimatorClipInfo>.Sort
	|
	|-RVA: 0x17F96E0 Offset: 0x17F80E0 VA: 0x1817F96E0
	|-ArraySortHelper<AsyncGPUReadbackRequest>.Sort
	|
	|-RVA: 0x17FA980 Offset: 0x17F9380 VA: 0x1817FA980
	|-ArraySortHelper<BezierContour>.Sort
	|
	|-RVA: 0x17F6F60 Offset: 0x17F5960 VA: 0x1817F6F60
	|-ArraySortHelper<BezierPathSegment>.Sort
	|
	|-RVA: 0x17FA620 Offset: 0x17F9020 VA: 0x1817FA620
	|-ArraySortHelper<BezierSegment>.Sort
	|
	|-RVA: 0x17F8E60 Offset: 0x17F7860 VA: 0x1817F8E60
	|-ArraySortHelper<bool>.Sort
	|
	|-RVA: 0x17F8A20 Offset: 0x17F7420 VA: 0x1817F8A20
	|-ArraySortHelper<Bounds>.Sort
	|
	|-RVA: 0x17F9B80 Offset: 0x17F8580 VA: 0x1817F9B80
	|-ArraySortHelper<byte>.Sort
	|
	|-RVA: 0x17F8060 Offset: 0x17F6A60 VA: 0x1817F8060
	|-ArraySortHelper<CGSpot>.Sort
	|
	|-RVA: 0x17FA400 Offset: 0x17F8E00 VA: 0x1817FA400
	|-ArraySortHelper<char>.Sort
	|
	|-RVA: 0x17F83C0 Offset: 0x17F6DC0 VA: 0x1817F83C0
	|-ArraySortHelper<Color>.Sort
	|
	|-RVA: 0x17F7E40 Offset: 0x17F6840 VA: 0x1817F7E40
	|-ArraySortHelper<Color32>.Sort
	|
	|-RVA: 0x17F7180 Offset: 0x17F5B80 VA: 0x1817F7180
	|-ArraySortHelper<CombineInstance>.Sort
	|
	|-RVA: 0x17F75C0 Offset: 0x17F5FC0 VA: 0x1817F75C0
	|-ArraySortHelper<ComputedTransitionProperty>.Sort
	|
	|-RVA: 0x17FA1E0 Offset: 0x17F8BE0 VA: 0x1817FA1E0
	|-ArraySortHelper<Connection>.Sort
	|
	|-RVA: 0x17F7C20 Offset: 0x17F6620 VA: 0x1817F7C20
	|-ArraySortHelper<ContourVertex>.Sort
	|
	|-RVA: 0x17F9080 Offset: 0x17F7A80 VA: 0x1817F9080
	|-ArraySortHelper<ControlPointOption>.Sort
	|
	|-RVA: 0x17F7A00 Offset: 0x17F6400 VA: 0x1817F7A00
	|-ArraySortHelper<CoordinateFootprintTilePair>.Sort
	|
	|-RVA: 0x17F85E0 Offset: 0x17F6FE0 VA: 0x1817F85E0
	|-ArraySortHelper<CoordinateProceduralTilePair>.Sort
	|
	|-RVA: 0x17FB120 Offset: 0x17F9B20 VA: 0x1817FB120
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.Sort
	|
	|-RVA: 0x17F92A0 Offset: 0x17F7CA0 VA: 0x1817F92A0
	|-ArraySortHelper<CoordinateStorageTilePair>.Sort
	|
	|-RVA: 0x17F94C0 Offset: 0x17F7EC0 VA: 0x1817F94C0
	|-ArraySortHelper<CoordinateTilePair>.Sort
	|
	|-RVA: 0x17F8800 Offset: 0x17F7200 VA: 0x1817F8800
	|-ArraySortHelper<DateTime>.Sort
	|
	|-RVA: 0x17FB340 Offset: 0x17F9D40 VA: 0x1817FB340
	|-ArraySortHelper<DateTimeOffset>.Sort
	|
	|-RVA: 0x17F77E0 Offset: 0x17F61E0 VA: 0x1817F77E0
	|-ArraySortHelper<Decimal>.Sort
	|
	|-RVA: 0x17F9FC0 Offset: 0x17F89C0 VA: 0x1817F9FC0
	|-ArraySortHelper<DisplayInfo>.Sort
	|
	|-RVA: 0x17FACE0 Offset: 0x17F96E0 VA: 0x1817FACE0
	|-ArraySortHelper<double>.Sort
	|
	|-RVA: 0x17F8C40 Offset: 0x17F7640 VA: 0x1817F8C40
	|-ArraySortHelper<DoublePoint>.Sort
	|
	|-RVA: 0x1894B30 Offset: 0x1893530 VA: 0x181894B30
	|-ArraySortHelper<DoublePoint>.Sort
	|
	|-RVA: 0x1895C90 Offset: 0x1894690 VA: 0x181895C90
	|-ArraySortHelper<DualPrefab>.Sort
	|
	|-RVA: 0x18960D0 Offset: 0x1894AD0 VA: 0x1818960D0
	|-ArraySortHelper<DuplicateSamplePoint>.Sort
	|
	|-RVA: 0x18944D0 Offset: 0x1892ED0 VA: 0x1818944D0
	|-ArraySortHelper<EasingFunction>.Sort
	|
	|-RVA: 0x18942B0 Offset: 0x1892CB0 VA: 0x1818942B0
	|-ArraySortHelper<Entry>.Sort
	|
	|-RVA: 0x1894910 Offset: 0x1893310 VA: 0x181894910
	|-ArraySortHelper<EventSummary>.Sort
	|
	|-RVA: 0x18926B0 Offset: 0x18910B0 VA: 0x1818926B0
	|-ArraySortHelper<FrameTimeSample>.Sort
	|
	|-RVA: 0x18950B0 Offset: 0x1893AB0 VA: 0x1818950B0
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.Sort
	|
	|-RVA: 0x1895EB0 Offset: 0x18948B0 VA: 0x181895EB0
	|-ArraySortHelper<GlyphRect>.Sort
	|
	|-RVA: 0x1896950 Offset: 0x1895350 VA: 0x181896950
	|-ArraySortHelper<Guid>.Sort
	|
	|-RVA: 0x18952D0 Offset: 0x1893CD0 VA: 0x1818952D0
	|-ArraySortHelper<InputBinding>.Sort
	|
	|-RVA: 0x1893290 Offset: 0x1891C90 VA: 0x181893290
	|-ArraySortHelper<InputDeviceDescription>.Sort
	|
	|-RVA: 0x18946F0 Offset: 0x18930F0 VA: 0x1818946F0
	|-ArraySortHelper<InputEventPtr>.Sort
	|
	|-RVA: 0x18962F0 Offset: 0x1894CF0 VA: 0x1818962F0
	|-ArraySortHelper<short>.Sort
	|
	|-RVA: 0x1893D30 Offset: 0x1892730 VA: 0x181893D30
	|-ArraySortHelper<Int3>.Sort
	|
	|-RVA: 0x18938F0 Offset: 0x18922F0 VA: 0x1818938F0
	|-ArraySortHelper<int>.Sort
	|
	|-RVA: 0x1894090 Offset: 0x1892A90 VA: 0x181894090
	|-ArraySortHelper<Int32Enum>.Sort
	|
	|-RVA: 0x1895630 Offset: 0x1894030 VA: 0x181895630
	|-ArraySortHelper<long>.Sort
	|
	|-RVA: 0x1896730 Offset: 0x1895130 VA: 0x181896730
	|-ArraySortHelper<IntPoint>.Sort
	|
	|-RVA: 0x1892E50 Offset: 0x1891850 VA: 0x181892E50
	|-ArraySortHelper<IntPoint>.Sort
	|
	|-RVA: 0x1893B10 Offset: 0x1892510 VA: 0x181893B10
	|-ArraySortHelper<IntRect>.Sort
	|
	|-RVA: 0x1896510 Offset: 0x1894F10 VA: 0x181896510
	|-ArraySortHelper<IntRegion>.Sort
	|
	|-RVA: 0x1894D50 Offset: 0x1893750 VA: 0x181894D50
	|-ArraySortHelper<InternedString>.Sort
	|
	|-RVA: 0x1895850 Offset: 0x1894250 VA: 0x181895850
	|-ArraySortHelper<InterpretedFrameInfo>.Sort
	|
	|-RVA: 0x18934B0 Offset: 0x1891EB0 VA: 0x1818934B0
	|-ArraySortHelper<IntervalTreeNode>.Sort
	|
	|-RVA: 0x1895A70 Offset: 0x1894470 VA: 0x181895A70
	|-ArraySortHelper<JsonPosition>.Sort
	|
	|-RVA: 0x1892AF0 Offset: 0x18914F0 VA: 0x181892AF0
	|-ArraySortHelper<Label>.Sort
	|
	|-RVA: 0x1893070 Offset: 0x1891A70 VA: 0x181893070
	|-ArraySortHelper<LigatureSubstitutionRecord>.Sort
	|
	|-RVA: 0x18928D0 Offset: 0x18912D0 VA: 0x1818928D0
	|-ArraySortHelper<LigatureSubstitutionRecord>.Sort
	|
	|-RVA: 0x18936D0 Offset: 0x18920D0 VA: 0x1818936D0
	|-ArraySortHelper<ManipulatorActivationFilter>.Sort
	|
	|-RVA: 0x1919DB0 Offset: 0x19187B0 VA: 0x181919DB0
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x191B2F0 Offset: 0x1919CF0 VA: 0x18191B2F0
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Sort
	|
	|-RVA: 0x191C670 Offset: 0x191B070 VA: 0x18191C670
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x1918730 Offset: 0x1917130 VA: 0x181918730
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Sort
	|
	|-RVA: 0x191A1F0 Offset: 0x1918BF0 VA: 0x18191A1F0
	|-ArraySortHelper<Matrix4x4>.Sort
	|
	|-RVA: 0x191C010 Offset: 0x191AA10 VA: 0x18191C010
	|-ArraySortHelper<MultipleSubstitutionRecord>.Sort
	|
	|-RVA: 0x1919970 Offset: 0x1918370 VA: 0x181919970
	|-ArraySortHelper<MultipleSubstitutionRecord>.Sort
	|
	|-RVA: 0x191A630 Offset: 0x1919030 VA: 0x18191A630
	|-ArraySortHelper<NameAndParameters>.Sort
	|
	|-RVA: 0x191A410 Offset: 0x1918E10 VA: 0x18191A410
	|-ArraySortHelper<NamedValue>.Sort
	|
	|-RVA: 0x1919310 Offset: 0x1917D10 VA: 0x181919310
	|-ArraySortHelper<NavMeshBuildMarkup>.Sort
	|
	|-RVA: 0x191BA90 Offset: 0x191A490 VA: 0x18191BA90
	|-ArraySortHelper<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x19190F0 Offset: 0x1917AF0 VA: 0x1819190F0
	|-ArraySortHelper<object>.Sort
	|
	|-RVA: 0x1918B70 Offset: 0x1917570 VA: 0x181918B70
	|-ArraySortHelper<Playable>.Sort
	|
	|-RVA: 0x1919FD0 Offset: 0x19189D0 VA: 0x181919FD0
	|-ArraySortHelper<PlayableBinding>.Sort
	|
	|-RVA: 0x191B730 Offset: 0x191A130 VA: 0x18191B730
	|-ArraySortHelper<PlayerLoopSystem>.Sort
	|
	|-RVA: 0x191B0D0 Offset: 0x1919AD0 VA: 0x18191B0D0
	|-ArraySortHelper<PlayerLoopSystemInternal>.Sort
	|
	|-RVA: 0x191C450 Offset: 0x191AE50 VA: 0x18191C450
	|-ArraySortHelper<Quaternion>.Sort
	|
	|-RVA: 0x191B510 Offset: 0x1919F10 VA: 0x18191B510
	|-ArraySortHelper<RangePositionInfo>.Sort
	|
	|-RVA: 0x1918510 Offset: 0x1916F10 VA: 0x181918510
	|-ArraySortHelper<RaycastHit>.Sort
	|
	|-RVA: 0x191AC90 Offset: 0x1919690 VA: 0x18191AC90
	|-ArraySortHelper<RaycastHit2D>.Sort
	|
	|-RVA: 0x191A850 Offset: 0x1919250 VA: 0x18191A850
	|-ArraySortHelper<RaycastResult>.Sort
	|
	|-RVA: 0x191AEB0 Offset: 0x19198B0 VA: 0x18191AEB0
	|-ArraySortHelper<RectInt>.Sort
	|
	|-RVA: 0x1919B90 Offset: 0x1918590 VA: 0x181919B90
	|-ArraySortHelper<RenderTargetIdentifier>.Sort
	|
	|-RVA: 0x1918950 Offset: 0x1917350 VA: 0x181918950
	|-ArraySortHelper<RendererList>.Sort
	|
	|-RVA: 0x1918D90 Offset: 0x1917790 VA: 0x181918D90
	|-ArraySortHelper<RendererListHandle>.Sort
	|
	|-RVA: 0x191BCB0 Offset: 0x191A6B0 VA: 0x18191BCB0
	|-ArraySortHelper<Resolution>.Sort
	|
	|-RVA: 0x191C230 Offset: 0x191AC30 VA: 0x18191C230
	|-ArraySortHelper<ResourceHandle>.Sort
	|
	|-RVA: 0x1919530 Offset: 0x1917F30 VA: 0x181919530
	|-ArraySortHelper<RuleMatcher>.Sort
	|
	|-RVA: 0x191AA70 Offset: 0x1919470 VA: 0x18191AA70
	|-ArraySortHelper<sbyte>.Sort
	|
	|-RVA: 0x1919750 Offset: 0x1918150 VA: 0x181919750
	|-ArraySortHelper<SamplePointUData>.Sort
	|
	|-RVA: 0x19A6890 Offset: 0x19A5290 VA: 0x1819A6890
	|-ArraySortHelper<SamplePointsPatch>.Sort
	|
	|-RVA: 0x19A7FF0 Offset: 0x19A69F0 VA: 0x1819A7FF0
	|-ArraySortHelper<Scene>.Sort
	|
	|-RVA: 0x19A7770 Offset: 0x19A6170 VA: 0x1819A7770
	|-ArraySortHelper<SelectorMatchRecord>.Sort
	|
	|-RVA: 0x19A9890 Offset: 0x19A8290 VA: 0x1819A9890
	|-ArraySortHelper<ShaderTagId>.Sort
	|
	|-RVA: 0x19A7990 Offset: 0x19A6390 VA: 0x1819A7990
	|-ArraySortHelper<float>.Sort
	|
	|-RVA: 0x19A8ED0 Offset: 0x19A78D0 VA: 0x1819A8ED0
	|-ArraySortHelper<StylePropertyName>.Sort
	|
	|-RVA: 0x19AA110 Offset: 0x19A8B10 VA: 0x1819AA110
	|-ArraySortHelper<StylePropertyValue>.Sort
	|
	|-RVA: 0x19A8CB0 Offset: 0x19A76B0 VA: 0x1819A8CB0
	|-ArraySortHelper<StyleSelectorPart>.Sort
	|
	|-RVA: 0x19A8870 Offset: 0x19A7270 VA: 0x1819A8870
	|-ArraySortHelper<StyleSyntaxToken>.Sort
	|
	|-RVA: 0x19A7110 Offset: 0x19A5B10 VA: 0x1819A7110
	|-ArraySortHelper<StyleValue>.Sort
	|
	|-RVA: 0x19A61D0 Offset: 0x19A4BD0 VA: 0x1819A61D0
	|-ArraySortHelper<StyleValueManaged>.Sort
	|
	|-RVA: 0x19A6AB0 Offset: 0x19A54B0 VA: 0x1819A6AB0
	|-ArraySortHelper<StyleVariable>.Sort
	|
	|-RVA: 0x19A9EF0 Offset: 0x19A88F0 VA: 0x1819A9EF0
	|-ArraySortHelper<Substring>.Sort
	|
	|-RVA: 0x19A6EF0 Offset: 0x19A58F0 VA: 0x1819A6EF0
	|-ArraySortHelper<TimeSpan>.Sort
	|
	|-RVA: 0x19A6CD0 Offset: 0x19A56D0 VA: 0x1819A6CD0
	|-ArraySortHelper<TimeValue>.Sort
	|
	|-RVA: 0x19A8650 Offset: 0x19A7050 VA: 0x1819A8650
	|-ArraySortHelper<TreeViewItemWrapper>.Sort
	|
	|-RVA: 0x19A9310 Offset: 0x19A7D10 VA: 0x1819A9310
	|-ArraySortHelper<UICharInfo>.Sort
	|
	|-RVA: 0x19A8210 Offset: 0x19A6C10 VA: 0x1819A8210
	|-ArraySortHelper<UILineInfo>.Sort
	|
	|-RVA: 0x19A90F0 Offset: 0x19A7AF0 VA: 0x1819A90F0
	|-ArraySortHelper<UIVertex>.Sort
	|
	|-RVA: 0x19A6530 Offset: 0x19A4F30 VA: 0x1819A6530
	|-ArraySortHelper<ushort>.Sort
	|
	|-RVA: 0x19A7DD0 Offset: 0x19A67D0 VA: 0x1819A7DD0
	|-ArraySortHelper<uint>.Sort
	|
	|-RVA: 0x19A7330 Offset: 0x19A5D30 VA: 0x1819A7330
	|-ArraySortHelper<UInt32Enum>.Sort
	|
	|-RVA: 0x19A5FB0 Offset: 0x19A49B0 VA: 0x1819A5FB0
	|-ArraySortHelper<ulong>.Sort
	|
	|-RVA: 0x19A8430 Offset: 0x19A6E30 VA: 0x1819A8430
	|-ArraySortHelper<UShort2>.Sort
	|
	|-RVA: 0x19A9670 Offset: 0x19A8070 VA: 0x1819A9670
	|-ArraySortHelper<UnloadedScene>.Sort
	|
	|-RVA: 0x19A8A90 Offset: 0x19A7490 VA: 0x1819A8A90
	|-ArraySortHelper<UsageHint>.Sort
	|
	|-RVA: 0x19A7550 Offset: 0x19A5F50 VA: 0x1819A7550
	|-ArraySortHelper<Vector2>.Sort
	|
	|-RVA: 0x19A9AB0 Offset: 0x19A84B0 VA: 0x1819A9AB0
	|-ArraySortHelper<Vector3>.Sort
	|
	|-RVA: 0x19A9CD0 Offset: 0x19A86D0 VA: 0x1819A9CD0
	|-ArraySortHelper<Vector4>.Sort
	|
	|-RVA: 0x19A7BB0 Offset: 0x19A65B0 VA: 0x1819A7BB0
	|-ArraySortHelper<VoxelContour>.Sort
	|
	|-RVA: 0x1013FF0 Offset: 0x10129F0 VA: 0x181013FF0
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.Sort
	|
	|-RVA: 0x10123F0 Offset: 0x1010DF0 VA: 0x1810123F0
	|-ArraySortHelper<X509ChainStatus>.Sort
	|
	|-RVA: 0x1011B70 Offset: 0x1010570 VA: 0x181011B70
	|-ArraySortHelper<XRFeatureDescriptor>.Sort
	|
	|-RVA: 0x1014AF0 Offset: 0x10134F0 VA: 0x181014AF0
	|-ArraySortHelper<XRView>.Sort
	|
	|-RVA: 0x1010FB0 Offset: 0x100F9B0 VA: 0x181010FB0
	|-ArraySortHelper<ZipGenericExtraField>.Sort
	|
	|-RVA: 0x1010320 Offset: 0x100ED20 VA: 0x181010320
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x1014790 Offset: 0x1013190 VA: 0x181014790
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Sort
	|
	|-RVA: 0x1013BB0 Offset: 0x10125B0 VA: 0x181013BB0
	|-ArraySortHelper<AdvancedSmooth.Turn>.Sort
	|
	|-RVA: 0x100FB20 Offset: 0x100E520 VA: 0x18100FB20
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x1012970 Offset: 0x1011370 VA: 0x181012970
	|-ArraySortHelper<AvatarSettings.LayerSetting>.Sort
	|
	|-RVA: 0x1012610 Offset: 0x1011010 VA: 0x181012610
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Sort
	|
	|-RVA: 0x1011FB0 Offset: 0x10109B0 VA: 0x181011FB0
	|-ArraySortHelper<BitmapAllocator32.Page>.Sort
	|
	|-RVA: 0x1013990 Offset: 0x1012390 VA: 0x181013990
	|-ArraySortHelper<CameraState.CustomBlendable>.Sort
	|
	|-RVA: 0x1013770 Offset: 0x1012170 VA: 0x181013770
	|-ArraySortHelper<CinemachineClearShot.Pair>.Sort
	|
	|-RVA: 0x1013110 Offset: 0x1011B10 VA: 0x181013110
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Sort
	|
	|-RVA: 0x10121D0 Offset: 0x1010BD0 VA: 0x1810121D0
	|-ArraySortHelper<ClipperLib.DoublePoint>.Sort
	|
	|-RVA: 0x1010560 Offset: 0x100EF60 VA: 0x181010560
	|-ArraySortHelper<ClipperLib.IntPoint>.Sort
	|
	|-RVA: 0x1010A00 Offset: 0x100F400 VA: 0x181010A00
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.Sort
	|
	|-RVA: 0x100FD40 Offset: 0x100E740 VA: 0x18100FD40
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.Sort
	|
	|-RVA: 0x1014210 Offset: 0x1012C10 VA: 0x181014210
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.Sort
	|
	|-RVA: 0x1013DD0 Offset: 0x10127D0 VA: 0x181013DD0
	|-ArraySortHelper<FocusController.FocusedElement>.Sort
	|
	|-RVA: 0x1012EF0 Offset: 0x10118F0 VA: 0x181012EF0
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.Sort
	|
	|-RVA: 0x1014D10 Offset: 0x1013710 VA: 0x181014D10
	|-ArraySortHelper<Funnel.PathPart>.Sort
	|
	|-RVA: 0x1014570 Offset: 0x1012F70 VA: 0x181014570
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.Sort
	|
	|-RVA: 0x1011D90 Offset: 0x1010790 VA: 0x181011D90
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.Sort
	|
	|-RVA: 0x1010C20 Offset: 0x100F620 VA: 0x181010C20
	|-ArraySortHelper<HID.HIDElementDescriptor>.Sort
	|
	|-RVA: 0x1012B90 Offset: 0x1011590 VA: 0x181012B90
	|-ArraySortHelper<HIDParser.HIDReportData>.Sort
	|
	|-RVA: 0x1013330 Offset: 0x1011D30 VA: 0x181013330
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.Sort
	|
	|-RVA: 0x1011450 Offset: 0x100FE50 VA: 0x181011450
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.Sort
	|
	|-RVA: 0x1013550 Offset: 0x1011F50 VA: 0x181013550
	|-ArraySortHelper<InputControlLayout.ControlItem>.Sort
	|
	|-RVA: 0x10DA830 Offset: 0x10D9230 VA: 0x1810DA830
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.Sort
	|
	|-RVA: 0x10DB770 Offset: 0x10DA170 VA: 0x1810DB770
	|-ArraySortHelper<JsonParser.JsonValue>.Sort
	|
	|-RVA: 0x10D96D0 Offset: 0x10D80D0 VA: 0x1810D96D0
	|-ArraySortHelper<LatencySimulator.Message>.Sort
	|
	|-RVA: 0x10DB330 Offset: 0x10D9D30 VA: 0x1810DB330
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.Sort
	|
	|-RVA: 0x10D9E70 Offset: 0x10D8870 VA: 0x1810D9E70
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.Sort
	|
	|-RVA: 0x10D7F10 Offset: 0x10D6910 VA: 0x1810D7F10
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.Sort
	|
	|-RVA: 0x10DB550 Offset: 0x10D9F50 VA: 0x1810DB550
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.Sort
	|
	|-RVA: 0x10DC7F0 Offset: 0x10DB1F0 VA: 0x1810DC7F0
	|-ArraySortHelper<PlayingCard.CardData>.Sort
	|
	|-RVA: 0x10D8790 Offset: 0x10D7190 VA: 0x1810D8790
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.Sort
	|
	|-RVA: 0x10D9C50 Offset: 0x10D8650 VA: 0x1810D9C50
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.Sort
	|
	|-RVA: 0x10D8570 Offset: 0x10D6F70 VA: 0x1810D8570
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Sort
	|
	|-RVA: 0x10DB110 Offset: 0x10D9B10 VA: 0x1810DB110
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.Sort
	|
	|-RVA: 0x10D8AF0 Offset: 0x10D74F0 VA: 0x1810D8AF0
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.Sort
	|
	|-RVA: 0x10DBCF0 Offset: 0x10DA6F0 VA: 0x1810DBCF0
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.Sort
	|
	|-RVA: 0x10D8350 Offset: 0x10D6D50 VA: 0x1810D8350
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.Sort
	|
	|-RVA: 0x10DAB90 Offset: 0x10D9590 VA: 0x1810DAB90
	|-ArraySortHelper<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x10D9A30 Offset: 0x10D8430 VA: 0x1810D9A30
	|-ArraySortHelper<RenderChain.RenderNodeData>.Sort
	|
	|-RVA: 0x10DAEF0 Offset: 0x10D98F0 VA: 0x1810DAEF0
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Sort
	|
	|-RVA: 0x10DC270 Offset: 0x10DAC70 VA: 0x1810DC270
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Sort
	|
	|-RVA: 0x10D8130 Offset: 0x10D6B30 VA: 0x1810D8130
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.Sort
	|
	|-RVA: 0x10D9070 Offset: 0x10D7A70 VA: 0x1810D9070
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.Sort
	|
	|-RVA: 0x10DA3F0 Offset: 0x10D8DF0 VA: 0x1810DA3F0
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.Sort
	|
	|-RVA: 0x10DC050 Offset: 0x10DAA50 VA: 0x1810DC050
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.Sort
	|
	|-RVA: 0x10D94B0 Offset: 0x10D7EB0 VA: 0x1810D94B0
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.Sort
	|
	|-RVA: 0x10DA610 Offset: 0x10D9010 VA: 0x1810DA610
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.Sort
	|
	|-RVA: 0x10DB990 Offset: 0x10DA390 VA: 0x1810DB990
	|-ArraySortHelper<SVGDocument.NodeWithParent>.Sort
	|
	|-RVA: 0x10D9290 Offset: 0x10D7C90 VA: 0x1810D9290
	|-ArraySortHelper<SVGDocument.PostponedClip>.Sort
	|
	|-RVA: 0x10D8D10 Offset: 0x10D7710 VA: 0x1810D8D10
	|-ArraySortHelper<SVGDocument.PostponedStopData>.Sort
	|
	|-RVA: 0x10DA1D0 Offset: 0x10D8BD0 VA: 0x1810DA1D0
	|-ArraySortHelper<ServerSocket.ConnectionChange>.Sort
	|
	|-RVA: 0x10DC5D0 Offset: 0x10DAFD0 VA: 0x1810DC5D0
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.Sort
	|
	|-RVA: 0x117B060 Offset: 0x1179A60 VA: 0x18117B060
	|-ArraySortHelper<ShadowUtility.Edge>.Sort
	|
	|-RVA: 0x117BA20 Offset: 0x117A420 VA: 0x18117BA20
	|-ArraySortHelper<StructySync.ChangeData>.Sort
	|
	|-RVA: 0x117C1C0 Offset: 0x117ABC0 VA: 0x18117C1C0
	|-ArraySortHelper<SyncStopwatch.ChangeData>.Sort
	|
	|-RVA: 0x117B280 Offset: 0x1179C80 VA: 0x18117B280
	|-ArraySortHelper<SyncTimer.ChangeData>.Sort
	|
	|-RVA: 0x117EDE0 Offset: 0x117D7E0 VA: 0x18117EDE0
	|-ArraySortHelper<TargetStateListener.Callback>.Sort
	|
	|-RVA: 0x117B6C0 Offset: 0x117A0C0 VA: 0x18117B6C0
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.Sort
	|
	|-RVA: 0x117C820 Offset: 0x117B220 VA: 0x18117C820
	|-ArraySortHelper<TextSettings.FontReferenceMap>.Sort
	|
	|-RVA: 0x117AA00 Offset: 0x1179400 VA: 0x18117AA00
	|-ArraySortHelper<TextureBlitter.BlitInfo>.Sort
	|
	|-RVA: 0x117DDC0 Offset: 0x117C7C0 VA: 0x18117DDC0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x117D100 Offset: 0x117BB00 VA: 0x18117D100
	|-ArraySortHelper<TextureRegistry.TextureInfo>.Sort
	|
	|-RVA: 0x117BFA0 Offset: 0x117A9A0 VA: 0x18117BFA0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x117D980 Offset: 0x117C380 VA: 0x18117D980
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.Sort
	|
	|-RVA: 0x117D320 Offset: 0x117BD20 VA: 0x18117D320
	|-ArraySortHelper<TransportManager.DisconnectingClient>.Sort
	|
	|-RVA: 0x117BD80 Offset: 0x117A780 VA: 0x18117BD80
	|-ArraySortHelper<UIRStylePainter.Entry>.Sort
	|
	|-RVA: 0x117DBA0 Offset: 0x117C5A0 VA: 0x18117DBA0
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.Sort
	|
	|-RVA: 0x117E640 Offset: 0x117D040 VA: 0x18117E640
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.Sort
	|
	|-RVA: 0x117C3E0 Offset: 0x117ADE0 VA: 0x18117C3E0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.Sort
	|
	|-RVA: 0x117DFE0 Offset: 0x117C9E0 VA: 0x18117DFE0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Sort
	|
	|-RVA: 0x117AE40 Offset: 0x1179840 VA: 0x18117AE40
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.Sort
	|
	|-RVA: 0x117C600 Offset: 0x117B000 VA: 0x18117C600
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.Sort
	|
	|-RVA: 0x117E860 Offset: 0x117D260 VA: 0x18117E860
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.Sort
	|
	|-RVA: 0x117E200 Offset: 0x117CC00 VA: 0x18117E200
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.Sort
	|
	|-RVA: 0x117B4A0 Offset: 0x1179EA0 VA: 0x18117B4A0
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.Sort
	|
	|-RVA: 0x117D760 Offset: 0x117C160 VA: 0x18117D760
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|
	|-RVA: 0x117AC20 Offset: 0x1179620 VA: 0x18117AC20
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Sort
	|
	|-RVA: 0x117CDA0 Offset: 0x117B7A0 VA: 0x18117CDA0
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.Sort
	|
	|-RVA: 0x117CB80 Offset: 0x117B580 VA: 0x18117CB80
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.Sort
	|
	|-RVA: 0x117E420 Offset: 0x117CE20 VA: 0x18117E420
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.Sort
	|
	|-RVA: 0x117EBC0 Offset: 0x117D5C0 VA: 0x18117EBC0
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.Sort
	|
	|-RVA: 0x117D540 Offset: 0x117BF40 VA: 0x18117D540
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x1295870 Offset: 0x1294270 VA: 0x181295870
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	*/

	// RVA: -1 Offset: -1
	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16A0710 Offset: 0x169F110 VA: 0x1816A0710
	|-ArraySortHelper<ArraySegment<byte>>.BinarySearch
	|
	|-RVA: 0x169F620 Offset: 0x169E020 VA: 0x18169F620
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.BinarySearch
	|
	|-RVA: 0x169F8B0 Offset: 0x169E2B0 VA: 0x18169F8B0
	|-ArraySortHelper<SyncList.ChangeData<int>>.BinarySearch
	|
	|-RVA: 0x169EB70 Offset: 0x169D570 VA: 0x18169EB70
	|-ArraySortHelper<IntervalTree.Entry<object>>.BinarySearch
	|
	|-RVA: 0x16A01D0 Offset: 0x169EBD0 VA: 0x1816A01D0
	|-ArraySortHelper<KeyValuePair<int, object>>.BinarySearch
	|
	|-RVA: 0x169F380 Offset: 0x169DD80 VA: 0x18169F380
	|-ArraySortHelper<KeyValuePair<object, bool>>.BinarySearch
	|
	|-RVA: 0x16A0080 Offset: 0x169EA80 VA: 0x1816A0080
	|-ArraySortHelper<KeyValuePair<object, char>>.BinarySearch
	|
	|-RVA: 0x169FDF0 Offset: 0x169E7F0 VA: 0x18169FDF0
	|-ArraySortHelper<KeyValuePair<object, object>>.BinarySearch
	|
	|-RVA: 0x169EE10 Offset: 0x169D810 VA: 0x18169EE10
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.BinarySearch
	|
	|-RVA: 0x16A0B00 Offset: 0x169F500 VA: 0x1816A0B00
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.BinarySearch
	|
	|-RVA: 0x169FB50 Offset: 0x169E550 VA: 0x18169FB50
	|-ArraySortHelper<KeyValuePair<Rect, object>>.BinarySearch
	|
	|-RVA: 0x169F4D0 Offset: 0x169DED0 VA: 0x18169F4D0
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.BinarySearch
	|
	|-RVA: 0x16A0320 Offset: 0x169ED20 VA: 0x1816A0320
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.BinarySearch
	|
	|-RVA: 0x169E8D0 Offset: 0x169D2D0 VA: 0x18169E8D0
	|-ArraySortHelper<NativeArray<NudgeJobData>>.BinarySearch
	|
	|-RVA: 0x169EA20 Offset: 0x169D420 VA: 0x18169EA20
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.BinarySearch
	|
	|-RVA: 0x169FCA0 Offset: 0x169E6A0 VA: 0x18169FCA0
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.BinarySearch
	|
	|-RVA: 0x169EF90 Offset: 0x169D990 VA: 0x18169EF90
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.BinarySearch
	|
	|-RVA: 0x16A05C0 Offset: 0x169EFC0 VA: 0x1816A05C0
	|-ArraySortHelper<Nullable<DateTime>>.BinarySearch
	|
	|-RVA: 0x169FA00 Offset: 0x169E400 VA: 0x18169FA00
	|-ArraySortHelper<Nullable<Decimal>>.BinarySearch
	|
	|-RVA: 0x169F230 Offset: 0x169DC30 VA: 0x18169F230
	|-ArraySortHelper<TempAllocator.Page<ushort>>.BinarySearch
	|
	|-RVA: 0x169ECC0 Offset: 0x169D6C0 VA: 0x18169ECC0
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.BinarySearch
	|
	|-RVA: 0x169F0E0 Offset: 0x169DAE0 VA: 0x18169F0E0
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.BinarySearch
	|
	|-RVA: 0x16A09B0 Offset: 0x169F3B0 VA: 0x1816A09B0
	|-ArraySortHelper<StructMultiKey<object, object>>.BinarySearch
	|
	|-RVA: 0x16A0860 Offset: 0x169F260 VA: 0x1816A0860
	|-ArraySortHelper<SubArray<int>>.BinarySearch
	|
	|-RVA: 0x169F770 Offset: 0x169E170 VA: 0x18169F770
	|-ArraySortHelper<ValueTuple<int, int>>.BinarySearch
	|
	|-RVA: 0x16A0470 Offset: 0x169EE70 VA: 0x1816A0470
	|-ArraySortHelper<ValueTuple<int, object>>.BinarySearch
	|
	|-RVA: 0x169FF40 Offset: 0x169E940 VA: 0x18169FF40
	|-ArraySortHelper<ValueTuple<int, Scene>>.BinarySearch
	|
	|-RVA: 0x169E780 Offset: 0x169D180 VA: 0x18169E780
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.BinarySearch
	|
	|-RVA: 0x17EE920 Offset: 0x17ED320 VA: 0x1817EE920
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.BinarySearch
	|
	|-RVA: 0x17ED040 Offset: 0x17EBA40 VA: 0x1817ED040
	|-ArraySortHelper<ValueTuple<object, object>>.BinarySearch
	|
	|-RVA: 0x17EDD30 Offset: 0x17EC730 VA: 0x1817EDD30
	|-ArraySortHelper<AnimatorClipInfo>.BinarySearch
	|
	|-RVA: 0x17EEA70 Offset: 0x17ED470 VA: 0x1817EEA70
	|-ArraySortHelper<AsyncGPUReadbackRequest>.BinarySearch
	|
	|-RVA: 0x17EDE70 Offset: 0x17EC870 VA: 0x1817EDE70
	|-ArraySortHelper<BezierContour>.BinarySearch
	|
	|-RVA: 0x17ECD80 Offset: 0x17EB780 VA: 0x1817ECD80
	|-ArraySortHelper<BezierPathSegment>.BinarySearch
	|
	|-RVA: 0x17ECAD0 Offset: 0x17EB4D0 VA: 0x1817ECAD0
	|-ArraySortHelper<BezierSegment>.BinarySearch
	|
	|-RVA: 0x17ED420 Offset: 0x17EBE20 VA: 0x1817ED420
	|-ArraySortHelper<bool>.BinarySearch
	|
	|-RVA: 0x17EE680 Offset: 0x17ED080 VA: 0x1817EE680
	|-ArraySortHelper<Bounds>.BinarySearch
	|
	|-RVA: 0x17EDBF0 Offset: 0x17EC5F0 VA: 0x1817EDBF0
	|-ArraySortHelper<byte>.BinarySearch
	|
	|-RVA: 0x17ECED0 Offset: 0x17EB8D0 VA: 0x1817ECED0
	|-ArraySortHelper<CGSpot>.BinarySearch
	|
	|-RVA: 0x17EEE60 Offset: 0x17ED860 VA: 0x1817EEE60
	|-ArraySortHelper<char>.BinarySearch
	|
	|-RVA: 0x17EE7D0 Offset: 0x17ED1D0 VA: 0x1817EE7D0
	|-ArraySortHelper<Color>.BinarySearch
	|
	|-RVA: 0x17ED2E0 Offset: 0x17EBCE0 VA: 0x1817ED2E0
	|-ArraySortHelper<Color32>.BinarySearch
	|
	|-RVA: 0x17EDFC0 Offset: 0x17EC9C0 VA: 0x1817EDFC0
	|-ArraySortHelper<CombineInstance>.BinarySearch
	|
	|-RVA: 0x17EDAA0 Offset: 0x17EC4A0 VA: 0x1817EDAA0
	|-ArraySortHelper<ComputedTransitionProperty>.BinarySearch
	|
	|-RVA: 0x17ED560 Offset: 0x17EBF60 VA: 0x1817ED560
	|-ArraySortHelper<Connection>.BinarySearch
	|
	|-RVA: 0x17EE290 Offset: 0x17ECC90 VA: 0x1817EE290
	|-ArraySortHelper<ContourVertex>.BinarySearch
	|
	|-RVA: 0x17EC970 Offset: 0x17EB370 VA: 0x1817EC970
	|-ArraySortHelper<ControlPointOption>.BinarySearch
	|
	|-RVA: 0x17EE530 Offset: 0x17ECF30 VA: 0x1817EE530
	|-ArraySortHelper<CoordinateFootprintTilePair>.BinarySearch
	|
	|-RVA: 0x17ED800 Offset: 0x17EC200 VA: 0x1817ED800
	|-ArraySortHelper<CoordinateProceduralTilePair>.BinarySearch
	|
	|-RVA: 0x17EED10 Offset: 0x17ED710 VA: 0x1817EED10
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.BinarySearch
	|
	|-RVA: 0x17EEBC0 Offset: 0x17ED5C0 VA: 0x1817EEBC0
	|-ArraySortHelper<CoordinateStorageTilePair>.BinarySearch
	|
	|-RVA: 0x17ED190 Offset: 0x17EBB90 VA: 0x1817ED190
	|-ArraySortHelper<CoordinateTilePair>.BinarySearch
	|
	|-RVA: 0x17EEFA0 Offset: 0x17ED9A0 VA: 0x1817EEFA0
	|-ArraySortHelper<DateTime>.BinarySearch
	|
	|-RVA: 0x17ED950 Offset: 0x17EC350 VA: 0x1817ED950
	|-ArraySortHelper<DateTimeOffset>.BinarySearch
	|
	|-RVA: 0x17ED6B0 Offset: 0x17EC0B0 VA: 0x1817ED6B0
	|-ArraySortHelper<Decimal>.BinarySearch
	|
	|-RVA: 0x17ECC20 Offset: 0x17EB620 VA: 0x1817ECC20
	|-ArraySortHelper<DisplayInfo>.BinarySearch
	|
	|-RVA: 0x17EE150 Offset: 0x17ECB50 VA: 0x1817EE150
	|-ArraySortHelper<double>.BinarySearch
	|
	|-RVA: 0x17EE3E0 Offset: 0x17ECDE0 VA: 0x1817EE3E0
	|-ArraySortHelper<DoublePoint>.BinarySearch
	|
	|-RVA: 0x188CD30 Offset: 0x188B730 VA: 0x18188CD30
	|-ArraySortHelper<DoublePoint>.BinarySearch
	|
	|-RVA: 0x188CBE0 Offset: 0x188B5E0 VA: 0x18188CBE0
	|-ArraySortHelper<DualPrefab>.BinarySearch
	|
	|-RVA: 0x188BA70 Offset: 0x188A470 VA: 0x18188BA70
	|-ArraySortHelper<DuplicateSamplePoint>.BinarySearch
	|
	|-RVA: 0x188B620 Offset: 0x188A020 VA: 0x18188B620
	|-ArraySortHelper<EasingFunction>.BinarySearch
	|
	|-RVA: 0x188C640 Offset: 0x188B040 VA: 0x18188C640
	|-ArraySortHelper<Entry>.BinarySearch
	|
	|-RVA: 0x188C4F0 Offset: 0x188AEF0 VA: 0x18188C4F0
	|-ArraySortHelper<EventSummary>.BinarySearch
	|
	|-RVA: 0x188C100 Offset: 0x188AB00 VA: 0x18188C100
	|-ArraySortHelper<FrameTimeSample>.BinarySearch
	|
	|-RVA: 0x188CA70 Offset: 0x188B470 VA: 0x18188CA70
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.BinarySearch
	|
	|-RVA: 0x188D140 Offset: 0x188BB40 VA: 0x18188D140
	|-ArraySortHelper<GlyphRect>.BinarySearch
	|
	|-RVA: 0x188BE70 Offset: 0x188A870 VA: 0x18188BE70
	|-ArraySortHelper<Guid>.BinarySearch
	|
	|-RVA: 0x188C790 Offset: 0x188B190 VA: 0x18188C790
	|-ArraySortHelper<InputBinding>.BinarySearch
	|
	|-RVA: 0x188CFD0 Offset: 0x188B9D0 VA: 0x18188CFD0
	|-ArraySortHelper<InputDeviceDescription>.BinarySearch
	|
	|-RVA: 0x188D3E0 Offset: 0x188BDE0 VA: 0x18188D3E0
	|-ArraySortHelper<InputEventPtr>.BinarySearch
	|
	|-RVA: 0x188BFC0 Offset: 0x188A9C0 VA: 0x18188BFC0
	|-ArraySortHelper<short>.BinarySearch
	|
	|-RVA: 0x188C3A0 Offset: 0x188ADA0 VA: 0x18188C3A0
	|-ArraySortHelper<Int3>.BinarySearch
	|
	|-RVA: 0x188D7D0 Offset: 0x188C1D0 VA: 0x18188D7D0
	|-ArraySortHelper<int>.BinarySearch
	|
	|-RVA: 0x188B760 Offset: 0x188A160 VA: 0x18188B760
	|-ArraySortHelper<Int32Enum>.BinarySearch
	|
	|-RVA: 0x188B930 Offset: 0x188A330 VA: 0x18188B930
	|-ArraySortHelper<long>.BinarySearch
	|
	|-RVA: 0x188BD20 Offset: 0x188A720 VA: 0x18188BD20
	|-ArraySortHelper<IntPoint>.BinarySearch
	|
	|-RVA: 0x188D520 Offset: 0x188BF20 VA: 0x18188D520
	|-ArraySortHelper<IntPoint>.BinarySearch
	|
	|-RVA: 0x188DAF0 Offset: 0x188C4F0 VA: 0x18188DAF0
	|-ArraySortHelper<IntRect>.BinarySearch
	|
	|-RVA: 0x188CE80 Offset: 0x188B880 VA: 0x18188CE80
	|-ArraySortHelper<IntRegion>.BinarySearch
	|
	|-RVA: 0x188D290 Offset: 0x188BC90 VA: 0x18188D290
	|-ArraySortHelper<InternedString>.BinarySearch
	|
	|-RVA: 0x188C250 Offset: 0x188AC50 VA: 0x18188C250
	|-ArraySortHelper<InterpretedFrameInfo>.BinarySearch
	|
	|-RVA: 0x188DD90 Offset: 0x188C790 VA: 0x18188DD90
	|-ArraySortHelper<IntervalTreeNode>.BinarySearch
	|
	|-RVA: 0x188C920 Offset: 0x188B320 VA: 0x18188C920
	|-ArraySortHelper<JsonPosition>.BinarySearch
	|
	|-RVA: 0x188BBC0 Offset: 0x188A5C0 VA: 0x18188BBC0
	|-ArraySortHelper<Label>.BinarySearch
	|
	|-RVA: 0x188D9A0 Offset: 0x188C3A0 VA: 0x18188D9A0
	|-ArraySortHelper<LigatureSubstitutionRecord>.BinarySearch
	|
	|-RVA: 0x188D680 Offset: 0x188C080 VA: 0x18188D680
	|-ArraySortHelper<LigatureSubstitutionRecord>.BinarySearch
	|
	|-RVA: 0x188DC40 Offset: 0x188C640 VA: 0x18188DC40
	|-ArraySortHelper<ManipulatorActivationFilter>.BinarySearch
	|
	|-RVA: 0x19133D0 Offset: 0x1911DD0 VA: 0x1819133D0
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.BinarySearch
	|
	|-RVA: 0x1913280 Offset: 0x1911C80 VA: 0x181913280
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.BinarySearch
	|
	|-RVA: 0x1913D20 Offset: 0x1912720 VA: 0x181913D20
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.BinarySearch
	|
	|-RVA: 0x1912930 Offset: 0x1911330 VA: 0x181912930
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.BinarySearch
	|
	|-RVA: 0x1914BA0 Offset: 0x19135A0 VA: 0x181914BA0
	|-ArraySortHelper<Matrix4x4>.BinarySearch
	|
	|-RVA: 0x1914A50 Offset: 0x1913450 VA: 0x181914A50
	|-ArraySortHelper<MultipleSubstitutionRecord>.BinarySearch
	|
	|-RVA: 0x1912BE0 Offset: 0x19115E0 VA: 0x181912BE0
	|-ArraySortHelper<MultipleSubstitutionRecord>.BinarySearch
	|
	|-RVA: 0x1914E60 Offset: 0x1913860 VA: 0x181914E60
	|-ArraySortHelper<NameAndParameters>.BinarySearch
	|
	|-RVA: 0x1913E70 Offset: 0x1912870 VA: 0x181913E70
	|-ArraySortHelper<NamedValue>.BinarySearch
	|
	|-RVA: 0x19137C0 Offset: 0x19121C0 VA: 0x1819137C0
	|-ArraySortHelper<NavMeshBuildMarkup>.BinarySearch
	|
	|-RVA: 0x1914FB0 Offset: 0x19139B0 VA: 0x181914FB0
	|-ArraySortHelper<NavMeshBuildSource>.BinarySearch
	|
	|-RVA: 0x1913BE0 Offset: 0x19125E0 VA: 0x181913BE0
	|-ArraySortHelper<object>.BinarySearch
	|
	|-RVA: 0x1913670 Offset: 0x1912070 VA: 0x181913670
	|-ArraySortHelper<Playable>.BinarySearch
	|
	|-RVA: 0x1914660 Offset: 0x1913060 VA: 0x181914660
	|-ArraySortHelper<PlayableBinding>.BinarySearch
	|
	|-RVA: 0x1914100 Offset: 0x1912B00 VA: 0x181914100
	|-ArraySortHelper<PlayerLoopSystem>.BinarySearch
	|
	|-RVA: 0x19147B0 Offset: 0x19131B0 VA: 0x1819147B0
	|-ArraySortHelper<PlayerLoopSystemInternal>.BinarySearch
	|
	|-RVA: 0x1914D10 Offset: 0x1913710 VA: 0x181914D10
	|-ArraySortHelper<Quaternion>.BinarySearch
	|
	|-RVA: 0x1913520 Offset: 0x1911F20 VA: 0x181913520
	|-ArraySortHelper<RangePositionInfo>.BinarySearch
	|
	|-RVA: 0x1912D30 Offset: 0x1911730 VA: 0x181912D30
	|-ArraySortHelper<RaycastHit>.BinarySearch
	|
	|-RVA: 0x1912A80 Offset: 0x1911480 VA: 0x181912A80
	|-ArraySortHelper<RaycastHit2D>.BinarySearch
	|
	|-RVA: 0x1913910 Offset: 0x1912310 VA: 0x181913910
	|-ArraySortHelper<RaycastResult>.BinarySearch
	|
	|-RVA: 0x1913A90 Offset: 0x1912490 VA: 0x181913A90
	|-ArraySortHelper<RectInt>.BinarySearch
	|
	|-RVA: 0x1914260 Offset: 0x1912C60 VA: 0x181914260
	|-ArraySortHelper<RenderTargetIdentifier>.BinarySearch
	|
	|-RVA: 0x1913130 Offset: 0x1911B30 VA: 0x181913130
	|-ArraySortHelper<RendererList>.BinarySearch
	|
	|-RVA: 0x1912FF0 Offset: 0x19119F0 VA: 0x181912FF0
	|-ArraySortHelper<RendererListHandle>.BinarySearch
	|
	|-RVA: 0x1912EA0 Offset: 0x19118A0 VA: 0x181912EA0
	|-ArraySortHelper<Resolution>.BinarySearch
	|
	|-RVA: 0x1913FC0 Offset: 0x19129C0 VA: 0x181913FC0
	|-ArraySortHelper<ResourceHandle>.BinarySearch
	|
	|-RVA: 0x1914510 Offset: 0x1912F10 VA: 0x181914510
	|-ArraySortHelper<RuleMatcher>.BinarySearch
	|
	|-RVA: 0x1914910 Offset: 0x1913310 VA: 0x181914910
	|-ArraySortHelper<sbyte>.BinarySearch
	|
	|-RVA: 0x19143C0 Offset: 0x1912DC0 VA: 0x1819143C0
	|-ArraySortHelper<SamplePointUData>.BinarySearch
	|
	|-RVA: 0x19A16B0 Offset: 0x19A00B0 VA: 0x1819A16B0
	|-ArraySortHelper<SamplePointsPatch>.BinarySearch
	|
	|-RVA: 0x19A1A70 Offset: 0x19A0470 VA: 0x1819A1A70
	|-ArraySortHelper<Scene>.BinarySearch
	|
	|-RVA: 0x19A0AB0 Offset: 0x199F4B0 VA: 0x1819A0AB0
	|-ArraySortHelper<SelectorMatchRecord>.BinarySearch
	|
	|-RVA: 0x199FF60 Offset: 0x199E960 VA: 0x18199FF60
	|-ArraySortHelper<ShaderTagId>.BinarySearch
	|
	|-RVA: 0x19A1930 Offset: 0x19A0330 VA: 0x1819A1930
	|-ArraySortHelper<float>.BinarySearch
	|
	|-RVA: 0x19A0C00 Offset: 0x199F600 VA: 0x1819A0C00
	|-ArraySortHelper<StylePropertyName>.BinarySearch
	|
	|-RVA: 0x19A00A0 Offset: 0x199EAA0 VA: 0x1819A00A0
	|-ArraySortHelper<StylePropertyValue>.BinarySearch
	|
	|-RVA: 0x19A2370 Offset: 0x19A0D70 VA: 0x1819A2370
	|-ArraySortHelper<StyleSelectorPart>.BinarySearch
	|
	|-RVA: 0x19A1410 Offset: 0x199FE10 VA: 0x1819A1410
	|-ArraySortHelper<StyleSyntaxToken>.BinarySearch
	|
	|-RVA: 0x19A20E0 Offset: 0x19A0AE0 VA: 0x1819A20E0
	|-ArraySortHelper<StyleValue>.BinarySearch
	|
	|-RVA: 0x19A0790 Offset: 0x199F190 VA: 0x1819A0790
	|-ArraySortHelper<StyleValueManaged>.BinarySearch
	|
	|-RVA: 0x19A1560 Offset: 0x199FF60 VA: 0x1819A1560
	|-ArraySortHelper<StyleVariable>.BinarySearch
	|
	|-RVA: 0x19A1030 Offset: 0x199FA30 VA: 0x1819A1030
	|-ArraySortHelper<Substring>.BinarySearch
	|
	|-RVA: 0x19A03C0 Offset: 0x199EDC0 VA: 0x1819A03C0
	|-ArraySortHelper<TimeSpan>.BinarySearch
	|
	|-RVA: 0x19A2230 Offset: 0x19A0C30 VA: 0x1819A2230
	|-ArraySortHelper<TimeValue>.BinarySearch
	|
	|-RVA: 0x19A1E50 Offset: 0x19A0850 VA: 0x1819A1E50
	|-ArraySortHelper<TreeViewItemWrapper>.BinarySearch
	|
	|-RVA: 0x19A1180 Offset: 0x199FB80 VA: 0x1819A1180
	|-ArraySortHelper<UICharInfo>.BinarySearch
	|
	|-RVA: 0x19A0640 Offset: 0x199F040 VA: 0x1819A0640
	|-ArraySortHelper<UILineInfo>.BinarySearch
	|
	|-RVA: 0x19A0E90 Offset: 0x199F890 VA: 0x1819A0E90
	|-ArraySortHelper<UIVertex>.BinarySearch
	|
	|-RVA: 0x19A0500 Offset: 0x199EF00 VA: 0x1819A0500
	|-ArraySortHelper<ushort>.BinarySearch
	|
	|-RVA: 0x19A01F0 Offset: 0x199EBF0 VA: 0x1819A01F0
	|-ArraySortHelper<uint>.BinarySearch
	|
	|-RVA: 0x19A08E0 Offset: 0x199F2E0 VA: 0x1819A08E0
	|-ArraySortHelper<UInt32Enum>.BinarySearch
	|
	|-RVA: 0x19A12D0 Offset: 0x199FCD0 VA: 0x1819A12D0
	|-ArraySortHelper<ulong>.BinarySearch
	|
	|-RVA: 0x19A17F0 Offset: 0x19A01F0 VA: 0x1819A17F0
	|-ArraySortHelper<UShort2>.BinarySearch
	|
	|-RVA: 0x19A24C0 Offset: 0x19A0EC0 VA: 0x1819A24C0
	|-ArraySortHelper<UnloadedScene>.BinarySearch
	|
	|-RVA: 0x19A1FA0 Offset: 0x19A09A0 VA: 0x1819A1FA0
	|-ArraySortHelper<UsageHint>.BinarySearch
	|
	|-RVA: 0x19A0D50 Offset: 0x199F750 VA: 0x1819A0D50
	|-ArraySortHelper<Vector2>.BinarySearch
	|
	|-RVA: 0x199FE10 Offset: 0x199E810 VA: 0x18199FE10
	|-ArraySortHelper<Vector3>.BinarySearch
	|
	|-RVA: 0x19A1BB0 Offset: 0x19A05B0 VA: 0x1819A1BB0
	|-ArraySortHelper<Vector4>.BinarySearch
	|
	|-RVA: 0x19A1D00 Offset: 0x19A0700 VA: 0x1819A1D00
	|-ArraySortHelper<VoxelContour>.BinarySearch
	|
	|-RVA: 0xFF77D0 Offset: 0xFF61D0 VA: 0x180FF77D0
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.BinarySearch
	|
	|-RVA: 0xFF7F90 Offset: 0xFF6990 VA: 0x180FF7F90
	|-ArraySortHelper<X509ChainStatus>.BinarySearch
	|
	|-RVA: 0xFF80E0 Offset: 0xFF6AE0 VA: 0x180FF80E0
	|-ArraySortHelper<XRFeatureDescriptor>.BinarySearch
	|
	|-RVA: 0xFF68A0 Offset: 0xFF52A0 VA: 0x180FF68A0
	|-ArraySortHelper<XRView>.BinarySearch
	|
	|-RVA: 0xFF6E30 Offset: 0xFF5830 VA: 0x180FF6E30
	|-ArraySortHelper<ZipGenericExtraField>.BinarySearch
	|
	|-RVA: 0xFF7980 Offset: 0xFF6380 VA: 0x180FF7980
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.BinarySearch
	|
	|-RVA: 0xFF6570 Offset: 0xFF4F70 VA: 0x180FF6570
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.BinarySearch
	|
	|-RVA: 0xFF6CE0 Offset: 0xFF56E0 VA: 0x180FF6CE0
	|-ArraySortHelper<AdvancedSmooth.Turn>.BinarySearch
	|
	|-RVA: 0xFF73D0 Offset: 0xFF5DD0 VA: 0x180FF73D0
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.BinarySearch
	|
	|-RVA: 0xFF7120 Offset: 0xFF5B20 VA: 0x180FF7120
	|-ArraySortHelper<AvatarSettings.LayerSetting>.BinarySearch
	|
	|-RVA: 0xFF6420 Offset: 0xFF4E20 VA: 0x180FF6420
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.BinarySearch
	|
	|-RVA: 0xFF6BA0 Offset: 0xFF55A0 VA: 0x180FF6BA0
	|-ArraySortHelper<BitmapAllocator32.Page>.BinarySearch
	|
	|-RVA: 0xFF5970 Offset: 0xFF4370 VA: 0x180FF5970
	|-ArraySortHelper<CameraState.CustomBlendable>.BinarySearch
	|
	|-RVA: 0xFF62E0 Offset: 0xFF4CE0 VA: 0x180FF62E0
	|-ArraySortHelper<CinemachineClearShot.Pair>.BinarySearch
	|
	|-RVA: 0xFF8230 Offset: 0xFF6C30 VA: 0x180FF8230
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.BinarySearch
	|
	|-RVA: 0xFF5EC0 Offset: 0xFF48C0 VA: 0x180FF5EC0
	|-ArraySortHelper<ClipperLib.DoublePoint>.BinarySearch
	|
	|-RVA: 0xFF7530 Offset: 0xFF5F30 VA: 0x180FF7530
	|-ArraySortHelper<ClipperLib.IntPoint>.BinarySearch
	|
	|-RVA: 0xFF7680 Offset: 0xFF6080 VA: 0x180FF7680
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.BinarySearch
	|
	|-RVA: 0xFF5C10 Offset: 0xFF4610 VA: 0x180FF5C10
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.BinarySearch
	|
	|-RVA: 0xFF5D60 Offset: 0xFF4760 VA: 0x180FF5D60
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.BinarySearch
	|
	|-RVA: 0xFF7B90 Offset: 0xFF6590 VA: 0x180FF7B90
	|-ArraySortHelper<FocusController.FocusedElement>.BinarySearch
	|
	|-RVA: 0xFF6A50 Offset: 0xFF5450 VA: 0x180FF6A50
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.BinarySearch
	|
	|-RVA: 0xFF7E30 Offset: 0xFF6830 VA: 0x180FF7E30
	|-ArraySortHelper<Funnel.PathPart>.BinarySearch
	|
	|-RVA: 0xFF6F80 Offset: 0xFF5980 VA: 0x180FF6F80
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.BinarySearch
	|
	|-RVA: 0xFF6190 Offset: 0xFF4B90 VA: 0x180FF6190
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.BinarySearch
	|
	|-RVA: 0xFF6010 Offset: 0xFF4A10 VA: 0x180FF6010
	|-ArraySortHelper<HID.HIDElementDescriptor>.BinarySearch
	|
	|-RVA: 0xFF7CE0 Offset: 0xFF66E0 VA: 0x180FF7CE0
	|-ArraySortHelper<HIDParser.HIDReportData>.BinarySearch
	|
	|-RVA: 0xFF5AC0 Offset: 0xFF44C0 VA: 0x180FF5AC0
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.BinarySearch
	|
	|-RVA: 0xFF7270 Offset: 0xFF5C70 VA: 0x180FF7270
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.BinarySearch
	|
	|-RVA: 0xFF66D0 Offset: 0xFF50D0 VA: 0x180FF66D0
	|-ArraySortHelper<InputControlLayout.ControlItem>.BinarySearch
	|
	|-RVA: 0x10CA490 Offset: 0x10C8E90 VA: 0x1810CA490
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.BinarySearch
	|
	|-RVA: 0x10CB2F0 Offset: 0x10C9CF0 VA: 0x1810CB2F0
	|-ArraySortHelper<JsonParser.JsonValue>.BinarySearch
	|
	|-RVA: 0x10CBB60 Offset: 0x10CA560 VA: 0x1810CBB60
	|-ArraySortHelper<LatencySimulator.Message>.BinarySearch
	|
	|-RVA: 0x10CC880 Offset: 0x10CB280 VA: 0x1810CC880
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.BinarySearch
	|
	|-RVA: 0x10CC730 Offset: 0x10CB130 VA: 0x1810CC730
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.BinarySearch
	|
	|-RVA: 0x10CC0B0 Offset: 0x10CAAB0 VA: 0x1810CC0B0
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.BinarySearch
	|
	|-RVA: 0x10CB050 Offset: 0x10C9A50 VA: 0x1810CB050
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.BinarySearch
	|
	|-RVA: 0x10CA5E0 Offset: 0x10C8FE0 VA: 0x1810CA5E0
	|-ArraySortHelper<PlayingCard.CardData>.BinarySearch
	|
	|-RVA: 0x10CA860 Offset: 0x10C9260 VA: 0x1810CA860
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.BinarySearch
	|
	|-RVA: 0x10CB750 Offset: 0x10CA150 VA: 0x1810CB750
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.BinarySearch
	|
	|-RVA: 0x10CB600 Offset: 0x10CA000 VA: 0x1810CB600
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.BinarySearch
	|
	|-RVA: 0x10CC340 Offset: 0x10CAD40 VA: 0x1810CC340
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.BinarySearch
	|
	|-RVA: 0x10CC9D0 Offset: 0x10CB3D0 VA: 0x1810CC9D0
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.BinarySearch
	|
	|-RVA: 0x10CCB20 Offset: 0x10CB520 VA: 0x1810CCB20
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.BinarySearch
	|
	|-RVA: 0x10CC1F0 Offset: 0x10CABF0 VA: 0x1810CC1F0
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.BinarySearch
	|
	|-RVA: 0x10CC490 Offset: 0x10CAE90 VA: 0x1810CC490
	|-ArraySortHelper<RegexCharClass.SingleRange>.BinarySearch
	|
	|-RVA: 0x10CB470 Offset: 0x10C9E70 VA: 0x1810CB470
	|-ArraySortHelper<RenderChain.RenderNodeData>.BinarySearch
	|
	|-RVA: 0x10CAB00 Offset: 0x10C9500 VA: 0x1810CAB00
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.BinarySearch
	|
	|-RVA: 0x10CBCB0 Offset: 0x10CA6B0 VA: 0x1810CBCB0
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.BinarySearch
	|
	|-RVA: 0x10CBE10 Offset: 0x10CA810 VA: 0x1810CBE10
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.BinarySearch
	|
	|-RVA: 0x10CAEF0 Offset: 0x10C98F0 VA: 0x1810CAEF0
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.BinarySearch
	|
	|-RVA: 0x10CB8A0 Offset: 0x10CA2A0 VA: 0x1810CB8A0
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.BinarySearch
	|
	|-RVA: 0x10CA9B0 Offset: 0x10C93B0 VA: 0x1810CA9B0
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.BinarySearch
	|
	|-RVA: 0x10CB1A0 Offset: 0x10C9BA0 VA: 0x1810CB1A0
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.BinarySearch
	|
	|-RVA: 0x10CAC60 Offset: 0x10C9660 VA: 0x1810CAC60
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.BinarySearch
	|
	|-RVA: 0x10CBA10 Offset: 0x10CA410 VA: 0x1810CBA10
	|-ArraySortHelper<SVGDocument.NodeWithParent>.BinarySearch
	|
	|-RVA: 0x10CADB0 Offset: 0x10C97B0 VA: 0x1810CADB0
	|-ArraySortHelper<SVGDocument.PostponedClip>.BinarySearch
	|
	|-RVA: 0x10CA720 Offset: 0x10C9120 VA: 0x1810CA720
	|-ArraySortHelper<SVGDocument.PostponedStopData>.BinarySearch
	|
	|-RVA: 0x10CBF60 Offset: 0x10CA960 VA: 0x1810CBF60
	|-ArraySortHelper<ServerSocket.ConnectionChange>.BinarySearch
	|
	|-RVA: 0x10CC5D0 Offset: 0x10CAFD0 VA: 0x1810CC5D0
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.BinarySearch
	|
	|-RVA: 0x11724E0 Offset: 0x1170EE0 VA: 0x1811724E0
	|-ArraySortHelper<ShadowUtility.Edge>.BinarySearch
	|
	|-RVA: 0x1172E50 Offset: 0x1171850 VA: 0x181172E50
	|-ArraySortHelper<StructySync.ChangeData>.BinarySearch
	|
	|-RVA: 0x1173780 Offset: 0x1172180 VA: 0x181173780
	|-ArraySortHelper<SyncStopwatch.ChangeData>.BinarySearch
	|
	|-RVA: 0x1171750 Offset: 0x1170150 VA: 0x181171750
	|-ArraySortHelper<SyncTimer.ChangeData>.BinarySearch
	|
	|-RVA: 0x1171F70 Offset: 0x1170970 VA: 0x181171F70
	|-ArraySortHelper<TargetStateListener.Callback>.BinarySearch
	|
	|-RVA: 0x1171490 Offset: 0x116FE90 VA: 0x181171490
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.BinarySearch
	|
	|-RVA: 0x11734E0 Offset: 0x1171EE0 VA: 0x1811734E0
	|-ArraySortHelper<TextSettings.FontReferenceMap>.BinarySearch
	|
	|-RVA: 0x11718A0 Offset: 0x11702A0 VA: 0x1811718A0
	|-ArraySortHelper<TextureBlitter.BlitInfo>.BinarySearch
	|
	|-RVA: 0x11715E0 Offset: 0x116FFE0 VA: 0x1811715E0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.BinarySearch
	|
	|-RVA: 0x1172B80 Offset: 0x1171580 VA: 0x181172B80
	|-ArraySortHelper<TextureRegistry.TextureInfo>.BinarySearch
	|
	|-RVA: 0x1171CC0 Offset: 0x11706C0 VA: 0x181171CC0
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.BinarySearch
	|
	|-RVA: 0x1171B70 Offset: 0x1170570 VA: 0x181171B70
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.BinarySearch
	|
	|-RVA: 0x1172390 Offset: 0x1170D90 VA: 0x181172390
	|-ArraySortHelper<TransportManager.DisconnectingClient>.BinarySearch
	|
	|-RVA: 0x1172CD0 Offset: 0x11716D0 VA: 0x181172CD0
	|-ArraySortHelper<UIRStylePainter.Entry>.BinarySearch
	|
	|-RVA: 0x1172790 Offset: 0x1171190 VA: 0x181172790
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.BinarySearch
	|
	|-RVA: 0x1171E10 Offset: 0x1170810 VA: 0x181171E10
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.BinarySearch
	|
	|-RVA: 0x11720C0 Offset: 0x1170AC0 VA: 0x1811720C0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.BinarySearch
	|
	|-RVA: 0x1172FA0 Offset: 0x11719A0 VA: 0x181172FA0
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.BinarySearch
	|
	|-RVA: 0x1172640 Offset: 0x1171040 VA: 0x181172640
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.BinarySearch
	|
	|-RVA: 0x11728E0 Offset: 0x11712E0 VA: 0x1811728E0
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.BinarySearch
	|
	|-RVA: 0x11738C0 Offset: 0x11722C0 VA: 0x1811738C0
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.BinarySearch
	|
	|-RVA: 0x1172A30 Offset: 0x1171430 VA: 0x181172A30
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.BinarySearch
	|
	|-RVA: 0x1173390 Offset: 0x1171D90 VA: 0x181173390
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.BinarySearch
	|
	|-RVA: 0x11730F0 Offset: 0x1171AF0 VA: 0x1811730F0
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.BinarySearch
	|
	|-RVA: 0x1171A10 Offset: 0x1170410 VA: 0x181171A10
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.BinarySearch
	|
	|-RVA: 0x1173630 Offset: 0x1172030 VA: 0x181173630
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.BinarySearch
	|
	|-RVA: 0x1173240 Offset: 0x1171C40 VA: 0x181173240
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.BinarySearch
	|
	|-RVA: 0x1173A10 Offset: 0x1172410 VA: 0x181173A10
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.BinarySearch
	|
	|-RVA: 0x1172240 Offset: 0x1170C40 VA: 0x181172240
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.BinarySearch
	|
	|-RVA: 0x1173B60 Offset: 0x1172560 VA: 0x181173B60
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.BinarySearch
	|
	|-RVA: 0x1295710 Offset: 0x1294110 VA: 0x181295710
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.BinarySearch
	*/

	// RVA: -1 Offset: -1
	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1010780 Offset: 0x100F180 VA: 0x181010780
	|-ArraySortHelper<ArraySegment<byte>>.Sort
	|-ArraySortHelper<KeyValuePair<object, bool>>.Sort
	|-ArraySortHelper<KeyValuePair<object, char>>.Sort
	|-ArraySortHelper<KeyValuePair<object, object>>.Sort
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Sort
	|-ArraySortHelper<StructMultiKey<object, object>>.Sort
	|-ArraySortHelper<SubArray<int>>.Sort
	|-ArraySortHelper<ValueTuple<object, object>>.Sort
	|-ArraySortHelper<BezierContour>.Sort
	|-ArraySortHelper<Connection>.Sort
	|-ArraySortHelper<CoordinateFootprintTilePair>.Sort
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.Sort
	|-ArraySortHelper<CoordinateStorageTilePair>.Sort
	|-ArraySortHelper<CoordinateTilePair>.Sort
	|-ArraySortHelper<DualPrefab>.Sort
	|-ArraySortHelper<Entry>.Sort
	|-ArraySortHelper<InternedString>.Sort
	|-ArraySortHelper<InterpretedFrameInfo>.Sort
	|-ArraySortHelper<LigatureSubstitutionRecord>.Sort
	|-ArraySortHelper<LigatureSubstitutionRecord>.Sort
	|-ArraySortHelper<RangePositionInfo>.Sort
	|-ArraySortHelper<RuleMatcher>.Sort
	|-ArraySortHelper<StylePropertyValue>.Sort
	|-ArraySortHelper<Substring>.Sort
	|-ArraySortHelper<UnloadedScene>.Sort
	|-ArraySortHelper<CameraState.CustomBlendable>.Sort
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.Sort
	|-ArraySortHelper<FocusController.FocusedElement>.Sort
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.Sort
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.Sort
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.Sort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.Sort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.Sort
	|-ArraySortHelper<SVGDocument.NodeWithParent>.Sort
	|-ArraySortHelper<TargetStateListener.Callback>.Sort
	|-ArraySortHelper<TextSettings.FontReferenceMap>.Sort
	|-ArraySortHelper<TextureRegistry.TextureInfo>.Sort
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.Sort
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.Sort
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Sort
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.Sort
	|
	|-RVA: 0x1014430 Offset: 0x1012E30 VA: 0x181014430
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.Sort
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.Sort
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.Sort
	|-ArraySortHelper<NativeArray<NudgeJobData>>.Sort
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.Sort
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.Sort
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.Sort
	|-ArraySortHelper<Nullable<DateTime>>.Sort
	|-ArraySortHelper<AsyncGPUReadbackRequest>.Sort
	|-ArraySortHelper<DateTimeOffset>.Sort
	|-ArraySortHelper<Decimal>.Sort
	|-ArraySortHelper<GlyphRect>.Sort
	|-ArraySortHelper<Guid>.Sort
	|-ArraySortHelper<IntPoint>.Sort
	|-ArraySortHelper<IntRect>.Sort
	|-ArraySortHelper<Playable>.Sort
	|-ArraySortHelper<RectInt>.Sort
	|-ArraySortHelper<Resolution>.Sort
	|-ArraySortHelper<SamplePointUData>.Sort
	|-ArraySortHelper<UILineInfo>.Sort
	|-ArraySortHelper<ClipperLib.IntPoint>.Sort
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.Sort
	|-ArraySortHelper<ServerSocket.ConnectionChange>.Sort
	|
	|-RVA: 0x10100A0 Offset: 0x100EAA0 VA: 0x1810100A0
	|-ArraySortHelper<SyncList.ChangeData<int>>.Sort
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.Sort
	|-ArraySortHelper<DuplicateSamplePoint>.Sort
	|-ArraySortHelper<Int3>.Sort
	|-ArraySortHelper<IntRegion>.Sort
	|-ArraySortHelper<ManipulatorActivationFilter>.Sort
	|-ArraySortHelper<UICharInfo>.Sort
	|-ArraySortHelper<Vector3>.Sort
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.Sort
	|-ArraySortHelper<HIDParser.HIDReportData>.Sort
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.Sort
	|-ArraySortHelper<SyncTimer.ChangeData>.Sort
	|
	|-RVA: 0x16A48A0 Offset: 0x16A32A0 VA: 0x1816A48A0
	|-ArraySortHelper<IntervalTree.Entry<object>>.Sort
	|-ArraySortHelper<KeyValuePair<Rect, object>>.Sort
	|-ArraySortHelper<ComputedTransitionProperty>.Sort
	|-ArraySortHelper<ContourVertex>.Sort
	|
	|-RVA: 0x100F9E0 Offset: 0x100E3E0 VA: 0x18100F9E0
	|-ArraySortHelper<KeyValuePair<int, object>>.Sort
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.Sort
	|-ArraySortHelper<ValueTuple<int, object>>.Sort
	|-ArraySortHelper<EventSummary>.Sort
	|-ArraySortHelper<MultipleSubstitutionRecord>.Sort
	|-ArraySortHelper<MultipleSubstitutionRecord>.Sort
	|-ArraySortHelper<StylePropertyName>.Sort
	|-ArraySortHelper<StyleValueManaged>.Sort
	|-ArraySortHelper<X509ChainStatus>.Sort
	|-ArraySortHelper<ZipGenericExtraField>.Sort
	|-ArraySortHelper<AdvancedSmooth.Turn>.Sort
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Sort
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.Sort
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.Sort
	|-ArraySortHelper<TransportManager.DisconnectingClient>.Sort
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.Sort
	|
	|-RVA: 0x16A4E20 Offset: 0x16A3820 VA: 0x1816A4E20
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.Sort
	|-ArraySortHelper<RaycastResult>.Sort
	|
	|-RVA: 0x100FF60 Offset: 0x100E960 VA: 0x18100FF60
	|-ArraySortHelper<Nullable<Decimal>>.Sort
	|-ArraySortHelper<TempAllocator.Page<ushort>>.Sort
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.Sort
	|-ArraySortHelper<BezierPathSegment>.Sort
	|-ArraySortHelper<Bounds>.Sort
	|-ArraySortHelper<FrameTimeSample>.Sort
	|-ArraySortHelper<IntervalTreeNode>.Sort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Sort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Sort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Sort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Sort
	|-ArraySortHelper<RendererList>.Sort
	|-ArraySortHelper<StyleValue>.Sort
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.Sort
	|
	|-RVA: 0x10108C0 Offset: 0x100F2C0 VA: 0x1810108C0
	|-ArraySortHelper<ValueTuple<int, int>>.Sort
	|-ArraySortHelper<ValueTuple<int, Scene>>.Sort
	|-ArraySortHelper<AnimatorClipInfo>.Sort
	|-ArraySortHelper<DateTime>.Sort
	|-ArraySortHelper<InputEventPtr>.Sort
	|-ArraySortHelper<RendererListHandle>.Sort
	|-ArraySortHelper<ResourceHandle>.Sort
	|-ArraySortHelper<SamplePointsPatch>.Sort
	|-ArraySortHelper<TimeSpan>.Sort
	|-ArraySortHelper<TimeValue>.Sort
	|-ArraySortHelper<BitmapAllocator32.Page>.Sort
	|-ArraySortHelper<CinemachineClearShot.Pair>.Sort
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Sort
	|-ArraySortHelper<PlayingCard.CardData>.Sort
	|-ArraySortHelper<SyncStopwatch.ChangeData>.Sort
	|
	|-RVA: 0x10111D0 Offset: 0x100FBD0 VA: 0x1810111D0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Sort
	|-ArraySortHelper<CoordinateProceduralTilePair>.Sort
	|-ArraySortHelper<NameAndParameters>.Sort
	|-ArraySortHelper<NamedValue>.Sort
	|-ArraySortHelper<SelectorMatchRecord>.Sort
	|-ArraySortHelper<StyleSelectorPart>.Sort
	|-ArraySortHelper<StyleVariable>.Sort
	|-ArraySortHelper<XRFeatureDescriptor>.Sort
	|-ArraySortHelper<AvatarSettings.LayerSetting>.Sort
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.Sort
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.Sort
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Sort
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.Sort
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.Sort
	|
	|-RVA: 0x1011670 Offset: 0x1010070 VA: 0x181011670
	|-ArraySortHelper<BezierSegment>.Sort
	|-ArraySortHelper<NavMeshBuildMarkup>.Sort
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.Sort
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.Sort
	|
	|-RVA: 0x17F6CE0 Offset: 0x17F56E0 VA: 0x1817F6CE0
	|-ArraySortHelper<bool>.Sort
	|-ArraySortHelper<byte>.Sort
	|-ArraySortHelper<sbyte>.Sort
	|
	|-RVA: 0x17F8280 Offset: 0x17F6C80 VA: 0x1817F8280
	|-ArraySortHelper<CGSpot>.Sort
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.Sort
	|-ArraySortHelper<RaycastHit>.Sort
	|
	|-RVA: 0x17FA840 Offset: 0x17F9240 VA: 0x1817FA840
	|-ArraySortHelper<char>.Sort
	|-ArraySortHelper<short>.Sort
	|-ArraySortHelper<ushort>.Sort
	|
	|-RVA: 0x17FABA0 Offset: 0x17F95A0 VA: 0x1817FABA0
	|-ArraySortHelper<Color>.Sort
	|-ArraySortHelper<Quaternion>.Sort
	|-ArraySortHelper<Vector4>.Sort
	|
	|-RVA: 0x10D89B0 Offset: 0x10D73B0 VA: 0x1810D89B0
	|-ArraySortHelper<Color32>.Sort
	|-ArraySortHelper<EasingFunction>.Sort
	|-ArraySortHelper<Scene>.Sort
	|-ArraySortHelper<ShaderTagId>.Sort
	|-ArraySortHelper<UShort2>.Sort
	|-ArraySortHelper<RegexCharClass.SingleRange>.Sort
	|
	|-RVA: 0x17F9A40 Offset: 0x17F8440 VA: 0x1817F9A40
	|-ArraySortHelper<CombineInstance>.Sort
	|
	|-RVA: 0x10149B0 Offset: 0x10133B0 VA: 0x1810149B0
	|-ArraySortHelper<ControlPointOption>.Sort
	|-ArraySortHelper<RaycastHit2D>.Sort
	|-ArraySortHelper<Funnel.PathPart>.Sort
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.Sort
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Sort
	|
	|-RVA: 0x17F6E20 Offset: 0x17F5820 VA: 0x1817F6E20
	|-ArraySortHelper<DisplayInfo>.Sort
	|
	|-RVA: 0x17F9900 Offset: 0x17F8300 VA: 0x1817F9900
	|-ArraySortHelper<double>.Sort
	|
	|-RVA: 0x1012DB0 Offset: 0x10117B0 VA: 0x181012DB0
	|-ArraySortHelper<DoublePoint>.Sort
	|-ArraySortHelper<DoublePoint>.Sort
	|-ArraySortHelper<ClipperLib.DoublePoint>.Sort
	|
	|-RVA: 0x18954F0 Offset: 0x1893EF0 VA: 0x1818954F0
	|-ArraySortHelper<InputBinding>.Sort
	|
	|-RVA: 0x10D8F30 Offset: 0x10D7930 VA: 0x1810D8F30
	|-ArraySortHelper<InputDeviceDescription>.Sort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.Sort
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.Sort
	|-ArraySortHelper<TextureBlitter.BlitInfo>.Sort
	|
	|-RVA: 0x1893F50 Offset: 0x1892950 VA: 0x181893F50
	|-ArraySortHelper<int>.Sort
	|-ArraySortHelper<Int32Enum>.Sort
	|-ArraySortHelper<uint>.Sort
	|-ArraySortHelper<UInt32Enum>.Sort
	|
	|-RVA: 0x1892D10 Offset: 0x1891710 VA: 0x181892D10
	|-ArraySortHelper<long>.Sort
	|-ArraySortHelper<ulong>.Sort
	|
	|-RVA: 0x1894F70 Offset: 0x1893970 VA: 0x181894F70
	|-ArraySortHelper<IntPoint>.Sort
	|
	|-RVA: 0x10D98F0 Offset: 0x10D82F0 VA: 0x1810D98F0
	|-ArraySortHelper<JsonPosition>.Sort
	|-ArraySortHelper<StyleSyntaxToken>.Sort
	|-ArraySortHelper<TreeViewItemWrapper>.Sort
	|-ArraySortHelper<LatencySimulator.Message>.Sort
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.Sort
	|-ArraySortHelper<StructySync.ChangeData>.Sort
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Sort
	|
	|-RVA: 0x100F760 Offset: 0x100E160 VA: 0x18100F760
	|-ArraySortHelper<Label>.Sort
	|-ArraySortHelper<PlayerLoopSystem>.Sort
	|-ArraySortHelper<PlayerLoopSystemInternal>.Sort
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.Sort
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.Sort
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Sort
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Sort
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Sort
	|
	|-RVA: 0x191BED0 Offset: 0x191A8D0 VA: 0x18191BED0
	|-ArraySortHelper<Matrix4x4>.Sort
	|
	|-RVA: 0x191B950 Offset: 0x191A350 VA: 0x18191B950
	|-ArraySortHelper<NavMeshBuildSource>.Sort
	|
	|-RVA: 0x1918FB0 Offset: 0x19179B0 VA: 0x181918FB0
	|-ArraySortHelper<object>.Sort
	|
	|-RVA: 0x10DAA50 Offset: 0x10D9450 VA: 0x1810DAA50
	|-ArraySortHelper<PlayableBinding>.Sort
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Sort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.Sort
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.Sort
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.Sort
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.Sort
	|
	|-RVA: 0x1011310 Offset: 0x100FD10 VA: 0x181011310
	|-ArraySortHelper<RenderTargetIdentifier>.Sort
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Sort
	|
	|-RVA: 0x19A9530 Offset: 0x19A7F30 VA: 0x1819A9530
	|-ArraySortHelper<float>.Sort
	|
	|-RVA: 0x19A6750 Offset: 0x19A5150 VA: 0x1819A6750
	|-ArraySortHelper<UIVertex>.Sort
	|
	|-RVA: 0x10DADB0 Offset: 0x10D97B0 VA: 0x1810DADB0
	|-ArraySortHelper<UsageHint>.Sort
	|-ArraySortHelper<SVGDocument.PostponedClip>.Sort
	|-ArraySortHelper<SVGDocument.PostponedStopData>.Sort
	|
	|-RVA: 0x19A63F0 Offset: 0x19A4DF0 VA: 0x1819A63F0
	|-ArraySortHelper<Vector2>.Sort
	|
	|-RVA: 0x117CFC0 Offset: 0x117B9C0 VA: 0x18117CFC0
	|-ArraySortHelper<VoxelContour>.Sort
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.Sort
	|
	|-RVA: 0x10101E0 Offset: 0x100EBE0 VA: 0x1810101E0
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.Sort
	|
	|-RVA: 0x1011A30 Offset: 0x1010430 VA: 0x181011A30
	|-ArraySortHelper<XRView>.Sort
	|
	|-RVA: 0x1010E40 Offset: 0x100F840 VA: 0x181010E40
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x100F8A0 Offset: 0x100E2A0 VA: 0x18100F8A0
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Sort
	|-ArraySortHelper<ShadowUtility.Edge>.Sort
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Sort
	|
	|-RVA: 0x10117B0 Offset: 0x10101B0 VA: 0x1810117B0
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.Sort
	|
	|-RVA: 0x1012830 Offset: 0x1011230 VA: 0x181012830
	|-ArraySortHelper<HID.HIDElementDescriptor>.Sort
	|
	|-RVA: 0x10118F0 Offset: 0x10102F0 VA: 0x1810118F0
	|-ArraySortHelper<InputControlLayout.ControlItem>.Sort
	|
	|-RVA: 0x10DBBB0 Offset: 0x10DA5B0 VA: 0x1810DBBB0
	|-ArraySortHelper<JsonParser.JsonValue>.Sort
	|
	|-RVA: 0x10DBF10 Offset: 0x10DA910 VA: 0x1810DBF10
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.Sort
	|
	|-RVA: 0x10DC490 Offset: 0x10DAE90 VA: 0x1810DC490
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.Sort
	|
	|-RVA: 0x10D7DD0 Offset: 0x10D67D0 VA: 0x1810D7DD0
	|-ArraySortHelper<RenderChain.RenderNodeData>.Sort
	|
	|-RVA: 0x10DA090 Offset: 0x10D8A90 VA: 0x1810DA090
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.Sort
	|
	|-RVA: 0x117BC40 Offset: 0x117A640 VA: 0x18117BC40
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Sort
	|
	|-RVA: 0x117B8E0 Offset: 0x117A2E0 VA: 0x18117B8E0
	|-ArraySortHelper<UIRStylePainter.Entry>.Sort
	|
	|-RVA: 0x117CA40 Offset: 0x117B440 VA: 0x18117CA40
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.Sort
	|
	|-RVA: 0x117EA80 Offset: 0x117D480 VA: 0x18117EA80
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.Sort
	|
	|-RVA: 0x117F000 Offset: 0x117DA00 VA: 0x18117F000
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.Sort
	*/

	// RVA: -1 Offset: -1
	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10028B0 Offset: 0x10012B0 VA: 0x1810028B0
	|-ArraySortHelper<ArraySegment<byte>>.InternalBinarySearch
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<int, object>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<object, bool>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<object, char>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<object, object>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.InternalBinarySearch
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.InternalBinarySearch
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.InternalBinarySearch
	|-ArraySortHelper<NativeArray<NudgeJobData>>.InternalBinarySearch
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.InternalBinarySearch
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.InternalBinarySearch
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.InternalBinarySearch
	|-ArraySortHelper<Nullable<DateTime>>.InternalBinarySearch
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.InternalBinarySearch
	|-ArraySortHelper<StructMultiKey<object, object>>.InternalBinarySearch
	|-ArraySortHelper<SubArray<int>>.InternalBinarySearch
	|-ArraySortHelper<ValueTuple<int, object>>.InternalBinarySearch
	|-ArraySortHelper<ValueTuple<object, object>>.InternalBinarySearch
	|-ArraySortHelper<AsyncGPUReadbackRequest>.InternalBinarySearch
	|-ArraySortHelper<BezierContour>.InternalBinarySearch
	|-ArraySortHelper<Connection>.InternalBinarySearch
	|-ArraySortHelper<CoordinateFootprintTilePair>.InternalBinarySearch
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.InternalBinarySearch
	|-ArraySortHelper<CoordinateStorageTilePair>.InternalBinarySearch
	|-ArraySortHelper<CoordinateTilePair>.InternalBinarySearch
	|-ArraySortHelper<DateTimeOffset>.InternalBinarySearch
	|-ArraySortHelper<Decimal>.InternalBinarySearch
	|-ArraySortHelper<DualPrefab>.InternalBinarySearch
	|-ArraySortHelper<Entry>.InternalBinarySearch
	|-ArraySortHelper<EventSummary>.InternalBinarySearch
	|-ArraySortHelper<GlyphRect>.InternalBinarySearch
	|-ArraySortHelper<Guid>.InternalBinarySearch
	|-ArraySortHelper<IntPoint>.InternalBinarySearch
	|-ArraySortHelper<IntRect>.InternalBinarySearch
	|-ArraySortHelper<InternedString>.InternalBinarySearch
	|-ArraySortHelper<InterpretedFrameInfo>.InternalBinarySearch
	|-ArraySortHelper<LigatureSubstitutionRecord>.InternalBinarySearch
	|-ArraySortHelper<LigatureSubstitutionRecord>.InternalBinarySearch
	|-ArraySortHelper<MultipleSubstitutionRecord>.InternalBinarySearch
	|-ArraySortHelper<MultipleSubstitutionRecord>.InternalBinarySearch
	|-ArraySortHelper<Playable>.InternalBinarySearch
	|-ArraySortHelper<RangePositionInfo>.InternalBinarySearch
	|-ArraySortHelper<RectInt>.InternalBinarySearch
	|-ArraySortHelper<Resolution>.InternalBinarySearch
	|-ArraySortHelper<RuleMatcher>.InternalBinarySearch
	|-ArraySortHelper<SamplePointUData>.InternalBinarySearch
	|-ArraySortHelper<StylePropertyName>.InternalBinarySearch
	|-ArraySortHelper<StylePropertyValue>.InternalBinarySearch
	|-ArraySortHelper<StyleValueManaged>.InternalBinarySearch
	|-ArraySortHelper<Substring>.InternalBinarySearch
	|-ArraySortHelper<UILineInfo>.InternalBinarySearch
	|-ArraySortHelper<UnloadedScene>.InternalBinarySearch
	|-ArraySortHelper<X509ChainStatus>.InternalBinarySearch
	|-ArraySortHelper<ZipGenericExtraField>.InternalBinarySearch
	|-ArraySortHelper<AdvancedSmooth.Turn>.InternalBinarySearch
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.InternalBinarySearch
	|-ArraySortHelper<CameraState.CustomBlendable>.InternalBinarySearch
	|-ArraySortHelper<ClipperLib.IntPoint>.InternalBinarySearch
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.InternalBinarySearch
	|-ArraySortHelper<FocusController.FocusedElement>.InternalBinarySearch
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.InternalBinarySearch
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.InternalBinarySearch
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.InternalBinarySearch
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.InternalBinarySearch
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.InternalBinarySearch
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.InternalBinarySearch
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.InternalBinarySearch
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.InternalBinarySearch
	|-ArraySortHelper<SVGDocument.NodeWithParent>.InternalBinarySearch
	|-ArraySortHelper<ServerSocket.ConnectionChange>.InternalBinarySearch
	|-ArraySortHelper<TargetStateListener.Callback>.InternalBinarySearch
	|-ArraySortHelper<TextSettings.FontReferenceMap>.InternalBinarySearch
	|-ArraySortHelper<TextureRegistry.TextureInfo>.InternalBinarySearch
	|-ArraySortHelper<TransportManager.DisconnectingClient>.InternalBinarySearch
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.InternalBinarySearch
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.InternalBinarySearch
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.InternalBinarySearch
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InternalBinarySearch
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.InternalBinarySearch
	|
	|-RVA: 0x1003040 Offset: 0x1001A40 VA: 0x181003040
	|-ArraySortHelper<SyncList.ChangeData<int>>.InternalBinarySearch
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.InternalBinarySearch
	|-ArraySortHelper<DuplicateSamplePoint>.InternalBinarySearch
	|-ArraySortHelper<Int3>.InternalBinarySearch
	|-ArraySortHelper<IntRegion>.InternalBinarySearch
	|-ArraySortHelper<ManipulatorActivationFilter>.InternalBinarySearch
	|-ArraySortHelper<UICharInfo>.InternalBinarySearch
	|-ArraySortHelper<Vector3>.InternalBinarySearch
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.InternalBinarySearch
	|-ArraySortHelper<HIDParser.HIDReportData>.InternalBinarySearch
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.InternalBinarySearch
	|-ArraySortHelper<SyncTimer.ChangeData>.InternalBinarySearch
	|
	|-RVA: 0x1003640 Offset: 0x1002040 VA: 0x181003640
	|-ArraySortHelper<IntervalTree.Entry<object>>.InternalBinarySearch
	|-ArraySortHelper<KeyValuePair<Rect, object>>.InternalBinarySearch
	|-ArraySortHelper<Nullable<Decimal>>.InternalBinarySearch
	|-ArraySortHelper<TempAllocator.Page<ushort>>.InternalBinarySearch
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.InternalBinarySearch
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.InternalBinarySearch
	|-ArraySortHelper<BezierPathSegment>.InternalBinarySearch
	|-ArraySortHelper<Bounds>.InternalBinarySearch
	|-ArraySortHelper<ComputedTransitionProperty>.InternalBinarySearch
	|-ArraySortHelper<ContourVertex>.InternalBinarySearch
	|-ArraySortHelper<CoordinateProceduralTilePair>.InternalBinarySearch
	|-ArraySortHelper<FrameTimeSample>.InternalBinarySearch
	|-ArraySortHelper<IntervalTreeNode>.InternalBinarySearch
	|-ArraySortHelper<JsonPosition>.InternalBinarySearch
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.InternalBinarySearch
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.InternalBinarySearch
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.InternalBinarySearch
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.InternalBinarySearch
	|-ArraySortHelper<NameAndParameters>.InternalBinarySearch
	|-ArraySortHelper<NamedValue>.InternalBinarySearch
	|-ArraySortHelper<RendererList>.InternalBinarySearch
	|-ArraySortHelper<SelectorMatchRecord>.InternalBinarySearch
	|-ArraySortHelper<StyleSelectorPart>.InternalBinarySearch
	|-ArraySortHelper<StyleSyntaxToken>.InternalBinarySearch
	|-ArraySortHelper<StyleValue>.InternalBinarySearch
	|-ArraySortHelper<StyleVariable>.InternalBinarySearch
	|-ArraySortHelper<TreeViewItemWrapper>.InternalBinarySearch
	|-ArraySortHelper<XRFeatureDescriptor>.InternalBinarySearch
	|-ArraySortHelper<AvatarSettings.LayerSetting>.InternalBinarySearch
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.InternalBinarySearch
	|-ArraySortHelper<LatencySimulator.Message>.InternalBinarySearch
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.InternalBinarySearch
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.InternalBinarySearch
	|-ArraySortHelper<StructySync.ChangeData>.InternalBinarySearch
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.InternalBinarySearch
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.InternalBinarySearch
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.InternalBinarySearch
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.InternalBinarySearch
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.InternalBinarySearch
	|
	|-RVA: 0x1177080 Offset: 0x1175A80 VA: 0x181177080
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.InternalBinarySearch
	|-ArraySortHelper<RaycastResult>.InternalBinarySearch
	|-ArraySortHelper<UIRStylePainter.Entry>.InternalBinarySearch
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.InternalBinarySearch
	|
	|-RVA: 0x10031F0 Offset: 0x1001BF0 VA: 0x1810031F0
	|-ArraySortHelper<ValueTuple<int, int>>.InternalBinarySearch
	|-ArraySortHelper<ValueTuple<int, Scene>>.InternalBinarySearch
	|-ArraySortHelper<AnimatorClipInfo>.InternalBinarySearch
	|-ArraySortHelper<DateTime>.InternalBinarySearch
	|-ArraySortHelper<InputEventPtr>.InternalBinarySearch
	|-ArraySortHelper<RendererListHandle>.InternalBinarySearch
	|-ArraySortHelper<ResourceHandle>.InternalBinarySearch
	|-ArraySortHelper<SamplePointsPatch>.InternalBinarySearch
	|-ArraySortHelper<TimeSpan>.InternalBinarySearch
	|-ArraySortHelper<TimeValue>.InternalBinarySearch
	|-ArraySortHelper<UsageHint>.InternalBinarySearch
	|-ArraySortHelper<BitmapAllocator32.Page>.InternalBinarySearch
	|-ArraySortHelper<CinemachineClearShot.Pair>.InternalBinarySearch
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.InternalBinarySearch
	|-ArraySortHelper<PlayingCard.CardData>.InternalBinarySearch
	|-ArraySortHelper<SVGDocument.PostponedClip>.InternalBinarySearch
	|-ArraySortHelper<SVGDocument.PostponedStopData>.InternalBinarySearch
	|-ArraySortHelper<SyncStopwatch.ChangeData>.InternalBinarySearch
	|
	|-RVA: 0x1002A50 Offset: 0x1001450 VA: 0x181002A50
	|-ArraySortHelper<BezierSegment>.InternalBinarySearch
	|-ArraySortHelper<NavMeshBuildMarkup>.InternalBinarySearch
	|-ArraySortHelper<PlayableBinding>.InternalBinarySearch
	|-ArraySortHelper<VoxelContour>.InternalBinarySearch
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.InternalBinarySearch
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.InternalBinarySearch
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.InternalBinarySearch
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.InternalBinarySearch
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.InternalBinarySearch
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.InternalBinarySearch
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.InternalBinarySearch
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.InternalBinarySearch
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.InternalBinarySearch
	|
	|-RVA: 0x17F23D0 Offset: 0x17F0DD0 VA: 0x1817F23D0
	|-ArraySortHelper<bool>.InternalBinarySearch
	|-ArraySortHelper<byte>.InternalBinarySearch
	|-ArraySortHelper<sbyte>.InternalBinarySearch
	|
	|-RVA: 0x17F27D0 Offset: 0x17F11D0 VA: 0x1817F27D0
	|-ArraySortHelper<CGSpot>.InternalBinarySearch
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.InternalBinarySearch
	|-ArraySortHelper<RaycastHit>.InternalBinarySearch
	|
	|-RVA: 0x17F2260 Offset: 0x17F0C60 VA: 0x1817F2260
	|-ArraySortHelper<char>.InternalBinarySearch
	|-ArraySortHelper<short>.InternalBinarySearch
	|-ArraySortHelper<ushort>.InternalBinarySearch
	|
	|-RVA: 0x17F29D0 Offset: 0x17F13D0 VA: 0x1817F29D0
	|-ArraySortHelper<Color>.InternalBinarySearch
	|-ArraySortHelper<Quaternion>.InternalBinarySearch
	|-ArraySortHelper<Vector4>.InternalBinarySearch
	|
	|-RVA: 0x10D19B0 Offset: 0x10D03B0 VA: 0x1810D19B0
	|-ArraySortHelper<Color32>.InternalBinarySearch
	|-ArraySortHelper<EasingFunction>.InternalBinarySearch
	|-ArraySortHelper<Scene>.InternalBinarySearch
	|-ArraySortHelper<ShaderTagId>.InternalBinarySearch
	|-ArraySortHelper<UShort2>.InternalBinarySearch
	|-ArraySortHelper<RegexCharClass.SingleRange>.InternalBinarySearch
	|
	|-RVA: 0x17F2540 Offset: 0x17F0F40 VA: 0x1817F2540
	|-ArraySortHelper<CombineInstance>.InternalBinarySearch
	|
	|-RVA: 0x1003B80 Offset: 0x1002580 VA: 0x181003B80
	|-ArraySortHelper<ControlPointOption>.InternalBinarySearch
	|-ArraySortHelper<RaycastHit2D>.InternalBinarySearch
	|-ArraySortHelper<Funnel.PathPart>.InternalBinarySearch
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.InternalBinarySearch
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.InternalBinarySearch
	|
	|-RVA: 0x10D2110 Offset: 0x10D0B10 VA: 0x1810D2110
	|-ArraySortHelper<DisplayInfo>.InternalBinarySearch
	|-ArraySortHelper<IntPoint>.InternalBinarySearch
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.InternalBinarySearch
	|
	|-RVA: 0x17F2B60 Offset: 0x17F1560 VA: 0x1817F2B60
	|-ArraySortHelper<double>.InternalBinarySearch
	|
	|-RVA: 0x10039D0 Offset: 0x10023D0 VA: 0x1810039D0
	|-ArraySortHelper<DoublePoint>.InternalBinarySearch
	|-ArraySortHelper<DoublePoint>.InternalBinarySearch
	|-ArraySortHelper<ClipperLib.DoublePoint>.InternalBinarySearch
	|
	|-RVA: 0x188FDB0 Offset: 0x188E7B0 VA: 0x18188FDB0
	|-ArraySortHelper<InputBinding>.InternalBinarySearch
	|
	|-RVA: 0x10D1B20 Offset: 0x10D0520 VA: 0x1810D1B20
	|-ArraySortHelper<InputDeviceDescription>.InternalBinarySearch
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.InternalBinarySearch
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.InternalBinarySearch
	|-ArraySortHelper<TextureBlitter.BlitInfo>.InternalBinarySearch
	|
	|-RVA: 0x1890020 Offset: 0x188EA20 VA: 0x181890020
	|-ArraySortHelper<int>.InternalBinarySearch
	|-ArraySortHelper<Int32Enum>.InternalBinarySearch
	|-ArraySortHelper<uint>.InternalBinarySearch
	|-ArraySortHelper<UInt32Enum>.InternalBinarySearch
	|
	|-RVA: 0x188FC40 Offset: 0x188E640 VA: 0x18188FC40
	|-ArraySortHelper<long>.InternalBinarySearch
	|-ArraySortHelper<object>.InternalBinarySearch
	|-ArraySortHelper<ulong>.InternalBinarySearch
	|
	|-RVA: 0x1002C10 Offset: 0x1001610 VA: 0x181002C10
	|-ArraySortHelper<Label>.InternalBinarySearch
	|-ArraySortHelper<PlayerLoopSystem>.InternalBinarySearch
	|-ArraySortHelper<PlayerLoopSystemInternal>.InternalBinarySearch
	|-ArraySortHelper<RenderTargetIdentifier>.InternalBinarySearch
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.InternalBinarySearch
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.InternalBinarySearch
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.InternalBinarySearch
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.InternalBinarySearch
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.InternalBinarySearch
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.InternalBinarySearch
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.InternalBinarySearch
	|
	|-RVA: 0x11772B0 Offset: 0x1175CB0 VA: 0x1811772B0
	|-ArraySortHelper<Matrix4x4>.InternalBinarySearch
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.InternalBinarySearch
	|
	|-RVA: 0x10D1EB0 Offset: 0x10D08B0 VA: 0x1810D1EB0
	|-ArraySortHelper<NavMeshBuildSource>.InternalBinarySearch
	|-ArraySortHelper<RenderChain.RenderNodeData>.InternalBinarySearch
	|
	|-RVA: 0x19A3EB0 Offset: 0x19A28B0 VA: 0x1819A3EB0
	|-ArraySortHelper<float>.InternalBinarySearch
	|
	|-RVA: 0x19A41E0 Offset: 0x19A2BE0 VA: 0x1819A41E0
	|-ArraySortHelper<UIVertex>.InternalBinarySearch
	|
	|-RVA: 0x19A4030 Offset: 0x19A2A30 VA: 0x1819A4030
	|-ArraySortHelper<Vector2>.InternalBinarySearch
	|
	|-RVA: 0x1003360 Offset: 0x1001D60 VA: 0x181003360
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.InternalBinarySearch
	|
	|-RVA: 0x1003D50 Offset: 0x1002750 VA: 0x181003D50
	|-ArraySortHelper<XRView>.InternalBinarySearch
	|
	|-RVA: 0x1002E00 Offset: 0x1001800 VA: 0x181002E00
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.InternalBinarySearch
	|
	|-RVA: 0x1003800 Offset: 0x1002200 VA: 0x181003800
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.InternalBinarySearch
	|-ArraySortHelper<ShadowUtility.Edge>.InternalBinarySearch
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.InternalBinarySearch
	|
	|-RVA: 0x10023B0 Offset: 0x1000DB0 VA: 0x1810023B0
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.InternalBinarySearch
	|
	|-RVA: 0x1002670 Offset: 0x1001070 VA: 0x181002670
	|-ArraySortHelper<HID.HIDElementDescriptor>.InternalBinarySearch
	|-ArraySortHelper<JsonParser.JsonValue>.InternalBinarySearch
	|
	|-RVA: 0x1004050 Offset: 0x1002A50 VA: 0x181004050
	|-ArraySortHelper<InputControlLayout.ControlItem>.InternalBinarySearch
	|
	|-RVA: 0x10D1D40 Offset: 0x10D0740 VA: 0x1810D1D40
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.InternalBinarySearch
	|
	|-RVA: 0x10D2300 Offset: 0x10D0D00 VA: 0x1810D2300
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.InternalBinarySearch
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1014F30 Offset: 0x1013930 VA: 0x181014F30
	|-ArraySortHelper<ArraySegment<byte>>.SwapIfGreater
	|-ArraySortHelper<KeyValuePair<object, bool>>.SwapIfGreater
	|-ArraySortHelper<KeyValuePair<object, char>>.SwapIfGreater
	|-ArraySortHelper<KeyValuePair<object, object>>.SwapIfGreater
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.SwapIfGreater
	|-ArraySortHelper<StructMultiKey<object, object>>.SwapIfGreater
	|-ArraySortHelper<SubArray<int>>.SwapIfGreater
	|-ArraySortHelper<ValueTuple<object, object>>.SwapIfGreater
	|-ArraySortHelper<BezierContour>.SwapIfGreater
	|-ArraySortHelper<Connection>.SwapIfGreater
	|-ArraySortHelper<CoordinateFootprintTilePair>.SwapIfGreater
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.SwapIfGreater
	|-ArraySortHelper<CoordinateStorageTilePair>.SwapIfGreater
	|-ArraySortHelper<CoordinateTilePair>.SwapIfGreater
	|-ArraySortHelper<DualPrefab>.SwapIfGreater
	|-ArraySortHelper<Entry>.SwapIfGreater
	|-ArraySortHelper<InternedString>.SwapIfGreater
	|-ArraySortHelper<InterpretedFrameInfo>.SwapIfGreater
	|-ArraySortHelper<LigatureSubstitutionRecord>.SwapIfGreater
	|-ArraySortHelper<LigatureSubstitutionRecord>.SwapIfGreater
	|-ArraySortHelper<RangePositionInfo>.SwapIfGreater
	|-ArraySortHelper<RuleMatcher>.SwapIfGreater
	|-ArraySortHelper<StylePropertyValue>.SwapIfGreater
	|-ArraySortHelper<Substring>.SwapIfGreater
	|-ArraySortHelper<UnloadedScene>.SwapIfGreater
	|-ArraySortHelper<CameraState.CustomBlendable>.SwapIfGreater
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.SwapIfGreater
	|-ArraySortHelper<FocusController.FocusedElement>.SwapIfGreater
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.SwapIfGreater
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.SwapIfGreater
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.SwapIfGreater
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.SwapIfGreater
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.SwapIfGreater
	|-ArraySortHelper<SVGDocument.NodeWithParent>.SwapIfGreater
	|-ArraySortHelper<TargetStateListener.Callback>.SwapIfGreater
	|-ArraySortHelper<TextSettings.FontReferenceMap>.SwapIfGreater
	|-ArraySortHelper<TextureRegistry.TextureInfo>.SwapIfGreater
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.SwapIfGreater
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.SwapIfGreater
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.SwapIfGreater
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.SwapIfGreater
	|
	|-RVA: 0x1015320 Offset: 0x1013D20 VA: 0x181015320
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.SwapIfGreater
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.SwapIfGreater
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.SwapIfGreater
	|-ArraySortHelper<NativeArray<NudgeJobData>>.SwapIfGreater
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.SwapIfGreater
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.SwapIfGreater
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.SwapIfGreater
	|-ArraySortHelper<Nullable<DateTime>>.SwapIfGreater
	|-ArraySortHelper<AsyncGPUReadbackRequest>.SwapIfGreater
	|-ArraySortHelper<Color>.SwapIfGreater
	|-ArraySortHelper<DateTimeOffset>.SwapIfGreater
	|-ArraySortHelper<Decimal>.SwapIfGreater
	|-ArraySortHelper<GlyphRect>.SwapIfGreater
	|-ArraySortHelper<Guid>.SwapIfGreater
	|-ArraySortHelper<IntPoint>.SwapIfGreater
	|-ArraySortHelper<IntRect>.SwapIfGreater
	|-ArraySortHelper<Playable>.SwapIfGreater
	|-ArraySortHelper<Quaternion>.SwapIfGreater
	|-ArraySortHelper<RectInt>.SwapIfGreater
	|-ArraySortHelper<Resolution>.SwapIfGreater
	|-ArraySortHelper<SamplePointUData>.SwapIfGreater
	|-ArraySortHelper<UILineInfo>.SwapIfGreater
	|-ArraySortHelper<Vector4>.SwapIfGreater
	|-ArraySortHelper<ClipperLib.IntPoint>.SwapIfGreater
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.SwapIfGreater
	|-ArraySortHelper<ServerSocket.ConnectionChange>.SwapIfGreater
	|
	|-RVA: 0x1015440 Offset: 0x1013E40 VA: 0x181015440
	|-ArraySortHelper<SyncList.ChangeData<int>>.SwapIfGreater
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.SwapIfGreater
	|-ArraySortHelper<DuplicateSamplePoint>.SwapIfGreater
	|-ArraySortHelper<Int3>.SwapIfGreater
	|-ArraySortHelper<IntRegion>.SwapIfGreater
	|-ArraySortHelper<ManipulatorActivationFilter>.SwapIfGreater
	|-ArraySortHelper<UICharInfo>.SwapIfGreater
	|-ArraySortHelper<Vector3>.SwapIfGreater
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.SwapIfGreater
	|-ArraySortHelper<HIDParser.HIDReportData>.SwapIfGreater
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.SwapIfGreater
	|-ArraySortHelper<SyncTimer.ChangeData>.SwapIfGreater
	|
	|-RVA: 0x16A6D20 Offset: 0x16A5720 VA: 0x1816A6D20
	|-ArraySortHelper<IntervalTree.Entry<object>>.SwapIfGreater
	|-ArraySortHelper<KeyValuePair<Rect, object>>.SwapIfGreater
	|-ArraySortHelper<ComputedTransitionProperty>.SwapIfGreater
	|-ArraySortHelper<ContourVertex>.SwapIfGreater
	|
	|-RVA: 0x10151D0 Offset: 0x1013BD0 VA: 0x1810151D0
	|-ArraySortHelper<KeyValuePair<int, object>>.SwapIfGreater
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.SwapIfGreater
	|-ArraySortHelper<ValueTuple<int, object>>.SwapIfGreater
	|-ArraySortHelper<EventSummary>.SwapIfGreater
	|-ArraySortHelper<MultipleSubstitutionRecord>.SwapIfGreater
	|-ArraySortHelper<MultipleSubstitutionRecord>.SwapIfGreater
	|-ArraySortHelper<StylePropertyName>.SwapIfGreater
	|-ArraySortHelper<StyleValueManaged>.SwapIfGreater
	|-ArraySortHelper<X509ChainStatus>.SwapIfGreater
	|-ArraySortHelper<ZipGenericExtraField>.SwapIfGreater
	|-ArraySortHelper<AdvancedSmooth.Turn>.SwapIfGreater
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.SwapIfGreater
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.SwapIfGreater
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.SwapIfGreater
	|-ArraySortHelper<TransportManager.DisconnectingClient>.SwapIfGreater
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.SwapIfGreater
	|
	|-RVA: 0x16A6EC0 Offset: 0x16A58C0 VA: 0x1816A6EC0
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.SwapIfGreater
	|-ArraySortHelper<RaycastResult>.SwapIfGreater
	|
	|-RVA: 0x10171D0 Offset: 0x1015BD0 VA: 0x1810171D0
	|-ArraySortHelper<Nullable<Decimal>>.SwapIfGreater
	|-ArraySortHelper<TempAllocator.Page<ushort>>.SwapIfGreater
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.SwapIfGreater
	|-ArraySortHelper<BezierPathSegment>.SwapIfGreater
	|-ArraySortHelper<Bounds>.SwapIfGreater
	|-ArraySortHelper<FrameTimeSample>.SwapIfGreater
	|-ArraySortHelper<IntervalTreeNode>.SwapIfGreater
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.SwapIfGreater
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.SwapIfGreater
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.SwapIfGreater
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.SwapIfGreater
	|-ArraySortHelper<RendererList>.SwapIfGreater
	|-ArraySortHelper<StyleValue>.SwapIfGreater
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.SwapIfGreater
	|
	|-RVA: 0x1015780 Offset: 0x1014180 VA: 0x181015780
	|-ArraySortHelper<ValueTuple<int, int>>.SwapIfGreater
	|-ArraySortHelper<ValueTuple<int, Scene>>.SwapIfGreater
	|-ArraySortHelper<AnimatorClipInfo>.SwapIfGreater
	|-ArraySortHelper<DateTime>.SwapIfGreater
	|-ArraySortHelper<InputEventPtr>.SwapIfGreater
	|-ArraySortHelper<RendererListHandle>.SwapIfGreater
	|-ArraySortHelper<ResourceHandle>.SwapIfGreater
	|-ArraySortHelper<SamplePointsPatch>.SwapIfGreater
	|-ArraySortHelper<TimeSpan>.SwapIfGreater
	|-ArraySortHelper<TimeValue>.SwapIfGreater
	|-ArraySortHelper<BitmapAllocator32.Page>.SwapIfGreater
	|-ArraySortHelper<CinemachineClearShot.Pair>.SwapIfGreater
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.SwapIfGreater
	|-ArraySortHelper<PlayingCard.CardData>.SwapIfGreater
	|-ArraySortHelper<SyncStopwatch.ChangeData>.SwapIfGreater
	|
	|-RVA: 0x1016740 Offset: 0x1015140 VA: 0x181016740
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.SwapIfGreater
	|-ArraySortHelper<CoordinateProceduralTilePair>.SwapIfGreater
	|-ArraySortHelper<NameAndParameters>.SwapIfGreater
	|-ArraySortHelper<NamedValue>.SwapIfGreater
	|-ArraySortHelper<SelectorMatchRecord>.SwapIfGreater
	|-ArraySortHelper<StyleSelectorPart>.SwapIfGreater
	|-ArraySortHelper<StyleVariable>.SwapIfGreater
	|-ArraySortHelper<XRFeatureDescriptor>.SwapIfGreater
	|-ArraySortHelper<AvatarSettings.LayerSetting>.SwapIfGreater
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.SwapIfGreater
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.SwapIfGreater
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.SwapIfGreater
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.SwapIfGreater
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.SwapIfGreater
	|
	|-RVA: 0x1015070 Offset: 0x1013A70 VA: 0x181015070
	|-ArraySortHelper<BezierSegment>.SwapIfGreater
	|-ArraySortHelper<NavMeshBuildMarkup>.SwapIfGreater
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.SwapIfGreater
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.SwapIfGreater
	|
	|-RVA: 0x17FB9D0 Offset: 0x17FA3D0 VA: 0x1817FB9D0
	|-ArraySortHelper<bool>.SwapIfGreater
	|-ArraySortHelper<byte>.SwapIfGreater
	|-ArraySortHelper<sbyte>.SwapIfGreater
	|
	|-RVA: 0x17FBB70 Offset: 0x17FA570 VA: 0x1817FBB70
	|-ArraySortHelper<CGSpot>.SwapIfGreater
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.SwapIfGreater
	|-ArraySortHelper<RaycastHit>.SwapIfGreater
	|
	|-RVA: 0x17FBAA0 Offset: 0x17FA4A0 VA: 0x1817FBAA0
	|-ArraySortHelper<char>.SwapIfGreater
	|-ArraySortHelper<short>.SwapIfGreater
	|-ArraySortHelper<ushort>.SwapIfGreater
	|
	|-RVA: 0x10DD690 Offset: 0x10DC090 VA: 0x1810DD690
	|-ArraySortHelper<Color32>.SwapIfGreater
	|-ArraySortHelper<EasingFunction>.SwapIfGreater
	|-ArraySortHelper<Scene>.SwapIfGreater
	|-ArraySortHelper<ShaderTagId>.SwapIfGreater
	|-ArraySortHelper<UShort2>.SwapIfGreater
	|-ArraySortHelper<RegexCharClass.SingleRange>.SwapIfGreater
	|
	|-RVA: 0x17FB560 Offset: 0x17F9F60 VA: 0x1817FB560
	|-ArraySortHelper<CombineInstance>.SwapIfGreater
	|
	|-RVA: 0x10168E0 Offset: 0x10152E0 VA: 0x1810168E0
	|-ArraySortHelper<ControlPointOption>.SwapIfGreater
	|-ArraySortHelper<RaycastHit2D>.SwapIfGreater
	|-ArraySortHelper<Funnel.PathPart>.SwapIfGreater
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.SwapIfGreater
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.SwapIfGreater
	|
	|-RVA: 0x17FBD60 Offset: 0x17FA760 VA: 0x1817FBD60
	|-ArraySortHelper<DisplayInfo>.SwapIfGreater
	|
	|-RVA: 0x17FB8F0 Offset: 0x17FA2F0 VA: 0x1817FB8F0
	|-ArraySortHelper<double>.SwapIfGreater
	|
	|-RVA: 0x1016070 Offset: 0x1014A70 VA: 0x181016070
	|-ArraySortHelper<DoublePoint>.SwapIfGreater
	|-ArraySortHelper<DoublePoint>.SwapIfGreater
	|-ArraySortHelper<ClipperLib.DoublePoint>.SwapIfGreater
	|
	|-RVA: 0x1896EC0 Offset: 0x18958C0 VA: 0x181896EC0
	|-ArraySortHelper<InputBinding>.SwapIfGreater
	|
	|-RVA: 0x10DCA10 Offset: 0x10DB410 VA: 0x1810DCA10
	|-ArraySortHelper<InputDeviceDescription>.SwapIfGreater
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.SwapIfGreater
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.SwapIfGreater
	|-ArraySortHelper<TextureBlitter.BlitInfo>.SwapIfGreater
	|
	|-RVA: 0x1896B70 Offset: 0x1895570 VA: 0x181896B70
	|-ArraySortHelper<int>.SwapIfGreater
	|-ArraySortHelper<Int32Enum>.SwapIfGreater
	|-ArraySortHelper<uint>.SwapIfGreater
	|-ArraySortHelper<UInt32Enum>.SwapIfGreater
	|
	|-RVA: 0x1896C30 Offset: 0x1895630 VA: 0x181896C30
	|-ArraySortHelper<long>.SwapIfGreater
	|-ArraySortHelper<ulong>.SwapIfGreater
	|
	|-RVA: 0x1896D00 Offset: 0x1895700 VA: 0x181896D00
	|-ArraySortHelper<IntPoint>.SwapIfGreater
	|
	|-RVA: 0x10DCC80 Offset: 0x10DB680 VA: 0x1810DCC80
	|-ArraySortHelper<JsonPosition>.SwapIfGreater
	|-ArraySortHelper<StyleSyntaxToken>.SwapIfGreater
	|-ArraySortHelper<TreeViewItemWrapper>.SwapIfGreater
	|-ArraySortHelper<LatencySimulator.Message>.SwapIfGreater
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.SwapIfGreater
	|-ArraySortHelper<StructySync.ChangeData>.SwapIfGreater
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.SwapIfGreater
	|
	|-RVA: 0x1015580 Offset: 0x1013F80 VA: 0x181015580
	|-ArraySortHelper<Label>.SwapIfGreater
	|-ArraySortHelper<PlayerLoopSystem>.SwapIfGreater
	|-ArraySortHelper<PlayerLoopSystemInternal>.SwapIfGreater
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.SwapIfGreater
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.SwapIfGreater
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.SwapIfGreater
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.SwapIfGreater
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.SwapIfGreater
	|
	|-RVA: 0x191CC90 Offset: 0x191B690 VA: 0x18191CC90
	|-ArraySortHelper<Matrix4x4>.SwapIfGreater
	|
	|-RVA: 0x191C890 Offset: 0x191B290 VA: 0x18191C890
	|-ArraySortHelper<NavMeshBuildSource>.SwapIfGreater
	|
	|-RVA: 0x191CBA0 Offset: 0x191B5A0 VA: 0x18191CBA0
	|-ArraySortHelper<object>.SwapIfGreater
	|
	|-RVA: 0x10DD3F0 Offset: 0x10DBDF0 VA: 0x1810DD3F0
	|-ArraySortHelper<PlayableBinding>.SwapIfGreater
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.SwapIfGreater
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.SwapIfGreater
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.SwapIfGreater
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.SwapIfGreater
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.SwapIfGreater
	|
	|-RVA: 0x1015EC0 Offset: 0x10148C0 VA: 0x181015EC0
	|-ArraySortHelper<RenderTargetIdentifier>.SwapIfGreater
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.SwapIfGreater
	|
	|-RVA: 0x19AA850 Offset: 0x19A9250 VA: 0x1819AA850
	|-ArraySortHelper<float>.SwapIfGreater
	|
	|-RVA: 0x19AA330 Offset: 0x19A8D30 VA: 0x1819AA330
	|-ArraySortHelper<UIVertex>.SwapIfGreater
	|
	|-RVA: 0x10DD590 Offset: 0x10DBF90 VA: 0x1810DD590
	|-ArraySortHelper<UsageHint>.SwapIfGreater
	|-ArraySortHelper<SVGDocument.PostponedClip>.SwapIfGreater
	|-ArraySortHelper<SVGDocument.PostponedStopData>.SwapIfGreater
	|
	|-RVA: 0x19AA710 Offset: 0x19A9110 VA: 0x1819AA710
	|-ArraySortHelper<Vector2>.SwapIfGreater
	|
	|-RVA: 0x117FD70 Offset: 0x117E770 VA: 0x18117FD70
	|-ArraySortHelper<VoxelContour>.SwapIfGreater
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.SwapIfGreater
	|
	|-RVA: 0x1017320 Offset: 0x1015D20 VA: 0x181017320
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.SwapIfGreater
	|
	|-RVA: 0x10161E0 Offset: 0x1014BE0 VA: 0x1810161E0
	|-ArraySortHelper<XRView>.SwapIfGreater
	|
	|-RVA: 0x1015850 Offset: 0x1014250 VA: 0x181015850
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.SwapIfGreater
	|
	|-RVA: 0x10165C0 Offset: 0x1014FC0 VA: 0x1810165C0
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.SwapIfGreater
	|-ArraySortHelper<ShadowUtility.Edge>.SwapIfGreater
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.SwapIfGreater
	|
	|-RVA: 0x1016A70 Offset: 0x1015470 VA: 0x181016A70
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.SwapIfGreater
	|
	|-RVA: 0x1015C30 Offset: 0x1014630 VA: 0x181015C30
	|-ArraySortHelper<HID.HIDElementDescriptor>.SwapIfGreater
	|
	|-RVA: 0x1016E90 Offset: 0x1015890 VA: 0x181016E90
	|-ArraySortHelper<InputControlLayout.ControlItem>.SwapIfGreater
	|
	|-RVA: 0x10DD100 Offset: 0x10DBB00 VA: 0x1810DD100
	|-ArraySortHelper<JsonParser.JsonValue>.SwapIfGreater
	|
	|-RVA: 0x10DCE20 Offset: 0x10DB820 VA: 0x1810DCE20
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.SwapIfGreater
	|
	|-RVA: 0x10DD760 Offset: 0x10DC160 VA: 0x1810DD760
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.SwapIfGreater
	|
	|-RVA: 0x10DD8A0 Offset: 0x10DC2A0 VA: 0x1810DD8A0
	|-ArraySortHelper<RenderChain.RenderNodeData>.SwapIfGreater
	|
	|-RVA: 0x10DCEF0 Offset: 0x10DB8F0 VA: 0x1810DCEF0
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.SwapIfGreater
	|
	|-RVA: 0x117FAF0 Offset: 0x117E4F0 VA: 0x18117FAF0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.SwapIfGreater
	|
	|-RVA: 0x117F4F0 Offset: 0x117DEF0 VA: 0x18117F4F0
	|-ArraySortHelper<UIRStylePainter.Entry>.SwapIfGreater
	|
	|-RVA: 0x117F140 Offset: 0x117DB40 VA: 0x18117F140
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.SwapIfGreater
	|
	|-RVA: 0x117F7F0 Offset: 0x117E1F0 VA: 0x18117F7F0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.SwapIfGreater
	|
	|-RVA: 0x117F340 Offset: 0x117DD40 VA: 0x18117F340
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.SwapIfGreater
	*/

	// RVA: -1 Offset: -1
	private static void Swap(T[] a, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10181E0 Offset: 0x1016BE0 VA: 0x1810181E0
	|-ArraySortHelper<ArraySegment<byte>>.Swap
	|-ArraySortHelper<KeyValuePair<object, bool>>.Swap
	|-ArraySortHelper<KeyValuePair<object, char>>.Swap
	|-ArraySortHelper<KeyValuePair<object, object>>.Swap
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Swap
	|-ArraySortHelper<StructMultiKey<object, object>>.Swap
	|-ArraySortHelper<SubArray<int>>.Swap
	|-ArraySortHelper<ValueTuple<object, object>>.Swap
	|-ArraySortHelper<BezierContour>.Swap
	|-ArraySortHelper<Connection>.Swap
	|-ArraySortHelper<CoordinateFootprintTilePair>.Swap
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.Swap
	|-ArraySortHelper<CoordinateStorageTilePair>.Swap
	|-ArraySortHelper<CoordinateTilePair>.Swap
	|-ArraySortHelper<DualPrefab>.Swap
	|-ArraySortHelper<Entry>.Swap
	|-ArraySortHelper<InternedString>.Swap
	|-ArraySortHelper<InterpretedFrameInfo>.Swap
	|-ArraySortHelper<LigatureSubstitutionRecord>.Swap
	|-ArraySortHelper<LigatureSubstitutionRecord>.Swap
	|-ArraySortHelper<RangePositionInfo>.Swap
	|-ArraySortHelper<RuleMatcher>.Swap
	|-ArraySortHelper<StylePropertyValue>.Swap
	|-ArraySortHelper<Substring>.Swap
	|-ArraySortHelper<UnloadedScene>.Swap
	|-ArraySortHelper<CameraState.CustomBlendable>.Swap
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.Swap
	|-ArraySortHelper<FocusController.FocusedElement>.Swap
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.Swap
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.Swap
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.Swap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.Swap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.Swap
	|-ArraySortHelper<SVGDocument.NodeWithParent>.Swap
	|-ArraySortHelper<TargetStateListener.Callback>.Swap
	|-ArraySortHelper<TextSettings.FontReferenceMap>.Swap
	|-ArraySortHelper<TextureRegistry.TextureInfo>.Swap
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.Swap
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.Swap
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Swap
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.Swap
	|
	|-RVA: 0x10180D0 Offset: 0x1016AD0 VA: 0x1810180D0
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.Swap
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.Swap
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.Swap
	|-ArraySortHelper<NativeArray<NudgeJobData>>.Swap
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.Swap
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.Swap
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.Swap
	|-ArraySortHelper<Nullable<DateTime>>.Swap
	|-ArraySortHelper<AsyncGPUReadbackRequest>.Swap
	|-ArraySortHelper<Color>.Swap
	|-ArraySortHelper<DateTimeOffset>.Swap
	|-ArraySortHelper<Decimal>.Swap
	|-ArraySortHelper<GlyphRect>.Swap
	|-ArraySortHelper<Guid>.Swap
	|-ArraySortHelper<IntPoint>.Swap
	|-ArraySortHelper<IntRect>.Swap
	|-ArraySortHelper<Playable>.Swap
	|-ArraySortHelper<Quaternion>.Swap
	|-ArraySortHelper<RectInt>.Swap
	|-ArraySortHelper<Resolution>.Swap
	|-ArraySortHelper<SamplePointUData>.Swap
	|-ArraySortHelper<UILineInfo>.Swap
	|-ArraySortHelper<Vector4>.Swap
	|-ArraySortHelper<ClipperLib.IntPoint>.Swap
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.Swap
	|-ArraySortHelper<ServerSocket.ConnectionChange>.Swap
	|
	|-RVA: 0x1017C70 Offset: 0x1016670 VA: 0x181017C70
	|-ArraySortHelper<SyncList.ChangeData<int>>.Swap
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.Swap
	|-ArraySortHelper<DuplicateSamplePoint>.Swap
	|-ArraySortHelper<Int3>.Swap
	|-ArraySortHelper<IntRegion>.Swap
	|-ArraySortHelper<ManipulatorActivationFilter>.Swap
	|-ArraySortHelper<UICharInfo>.Swap
	|-ArraySortHelper<Vector3>.Swap
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.Swap
	|-ArraySortHelper<HIDParser.HIDReportData>.Swap
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.Swap
	|-ArraySortHelper<SyncTimer.ChangeData>.Swap
	|
	|-RVA: 0x16A71C0 Offset: 0x16A5BC0 VA: 0x1816A71C0
	|-ArraySortHelper<IntervalTree.Entry<object>>.Swap
	|-ArraySortHelper<KeyValuePair<Rect, object>>.Swap
	|-ArraySortHelper<ComputedTransitionProperty>.Swap
	|-ArraySortHelper<ContourVertex>.Swap
	|
	|-RVA: 0x1017B10 Offset: 0x1016510 VA: 0x181017B10
	|-ArraySortHelper<KeyValuePair<int, object>>.Swap
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.Swap
	|-ArraySortHelper<ValueTuple<int, object>>.Swap
	|-ArraySortHelper<EventSummary>.Swap
	|-ArraySortHelper<MultipleSubstitutionRecord>.Swap
	|-ArraySortHelper<MultipleSubstitutionRecord>.Swap
	|-ArraySortHelper<StylePropertyName>.Swap
	|-ArraySortHelper<StyleValueManaged>.Swap
	|-ArraySortHelper<X509ChainStatus>.Swap
	|-ArraySortHelper<ZipGenericExtraField>.Swap
	|-ArraySortHelper<AdvancedSmooth.Turn>.Swap
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Swap
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.Swap
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.Swap
	|-ArraySortHelper<TransportManager.DisconnectingClient>.Swap
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.Swap
	|
	|-RVA: 0x16A7290 Offset: 0x16A5C90 VA: 0x1816A7290
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.Swap
	|-ArraySortHelper<RaycastResult>.Swap
	|
	|-RVA: 0x10179B0 Offset: 0x10163B0 VA: 0x1810179B0
	|-ArraySortHelper<Nullable<Decimal>>.Swap
	|-ArraySortHelper<TempAllocator.Page<ushort>>.Swap
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.Swap
	|-ArraySortHelper<BezierPathSegment>.Swap
	|-ArraySortHelper<Bounds>.Swap
	|-ArraySortHelper<FrameTimeSample>.Swap
	|-ArraySortHelper<IntervalTreeNode>.Swap
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Swap
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Swap
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Swap
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Swap
	|-ArraySortHelper<RendererList>.Swap
	|-ArraySortHelper<StyleValue>.Swap
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.Swap
	|
	|-RVA: 0x1017950 Offset: 0x1016350 VA: 0x181017950
	|-ArraySortHelper<ValueTuple<int, int>>.Swap
	|-ArraySortHelper<ValueTuple<int, Scene>>.Swap
	|-ArraySortHelper<AnimatorClipInfo>.Swap
	|-ArraySortHelper<DateTime>.Swap
	|-ArraySortHelper<InputEventPtr>.Swap
	|-ArraySortHelper<RendererListHandle>.Swap
	|-ArraySortHelper<ResourceHandle>.Swap
	|-ArraySortHelper<SamplePointsPatch>.Swap
	|-ArraySortHelper<TimeSpan>.Swap
	|-ArraySortHelper<TimeValue>.Swap
	|-ArraySortHelper<BitmapAllocator32.Page>.Swap
	|-ArraySortHelper<CinemachineClearShot.Pair>.Swap
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Swap
	|-ArraySortHelper<PlayingCard.CardData>.Swap
	|-ArraySortHelper<SyncStopwatch.ChangeData>.Swap
	|
	|-RVA: 0x1017A40 Offset: 0x1016440 VA: 0x181017A40
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Swap
	|-ArraySortHelper<CoordinateProceduralTilePair>.Swap
	|-ArraySortHelper<NameAndParameters>.Swap
	|-ArraySortHelper<NamedValue>.Swap
	|-ArraySortHelper<SelectorMatchRecord>.Swap
	|-ArraySortHelper<StyleSelectorPart>.Swap
	|-ArraySortHelper<StyleVariable>.Swap
	|-ArraySortHelper<XRFeatureDescriptor>.Swap
	|-ArraySortHelper<AvatarSettings.LayerSetting>.Swap
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.Swap
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.Swap
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Swap
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.Swap
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.Swap
	|
	|-RVA: 0x1017DE0 Offset: 0x10167E0 VA: 0x181017DE0
	|-ArraySortHelper<BezierSegment>.Swap
	|-ArraySortHelper<NavMeshBuildMarkup>.Swap
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.Swap
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.Swap
	|
	|-RVA: 0x17FC110 Offset: 0x17FAB10 VA: 0x1817FC110
	|-ArraySortHelper<bool>.Swap
	|-ArraySortHelper<byte>.Swap
	|-ArraySortHelper<sbyte>.Swap
	|
	|-RVA: 0x17FC170 Offset: 0x17FAB70 VA: 0x1817FC170
	|-ArraySortHelper<CGSpot>.Swap
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.Swap
	|-ArraySortHelper<RaycastHit>.Swap
	|
	|-RVA: 0x17FBF70 Offset: 0x17FA970 VA: 0x1817FBF70
	|-ArraySortHelper<char>.Swap
	|-ArraySortHelper<short>.Swap
	|-ArraySortHelper<ushort>.Swap
	|
	|-RVA: 0x10DE1B0 Offset: 0x10DCBB0 VA: 0x1810DE1B0
	|-ArraySortHelper<Color32>.Swap
	|-ArraySortHelper<EasingFunction>.Swap
	|-ArraySortHelper<Scene>.Swap
	|-ArraySortHelper<ShaderTagId>.Swap
	|-ArraySortHelper<UShort2>.Swap
	|-ArraySortHelper<RegexCharClass.SingleRange>.Swap
	|
	|-RVA: 0x17FBFD0 Offset: 0x17FA9D0 VA: 0x1817FBFD0
	|-ArraySortHelper<CombineInstance>.Swap
	|
	|-RVA: 0x1018140 Offset: 0x1016B40 VA: 0x181018140
	|-ArraySortHelper<ControlPointOption>.Swap
	|-ArraySortHelper<RaycastHit2D>.Swap
	|-ArraySortHelper<Funnel.PathPart>.Swap
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.Swap
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Swap
	|
	|-RVA: 0x17FC230 Offset: 0x17FAC30 VA: 0x1817FC230
	|-ArraySortHelper<DisplayInfo>.Swap
	|
	|-RVA: 0x17FC330 Offset: 0x17FAD30 VA: 0x1817FC330
	|-ArraySortHelper<double>.Swap
	|
	|-RVA: 0x1018710 Offset: 0x1017110 VA: 0x181018710
	|-ArraySortHelper<DoublePoint>.Swap
	|-ArraySortHelper<DoublePoint>.Swap
	|-ArraySortHelper<ClipperLib.DoublePoint>.Swap
	|
	|-RVA: 0x18972D0 Offset: 0x1895CD0 VA: 0x1818972D0
	|-ArraySortHelper<InputBinding>.Swap
	|
	|-RVA: 0x10DDF60 Offset: 0x10DC960 VA: 0x1810DDF60
	|-ArraySortHelper<InputDeviceDescription>.Swap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.Swap
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.Swap
	|-ArraySortHelper<TextureBlitter.BlitInfo>.Swap
	|
	|-RVA: 0x1897480 Offset: 0x1895E80 VA: 0x181897480
	|-ArraySortHelper<int>.Swap
	|-ArraySortHelper<Int32Enum>.Swap
	|-ArraySortHelper<uint>.Swap
	|-ArraySortHelper<UInt32Enum>.Swap
	|
	|-RVA: 0x1897420 Offset: 0x1895E20 VA: 0x181897420
	|-ArraySortHelper<long>.Swap
	|-ArraySortHelper<ulong>.Swap
	|
	|-RVA: 0x1897220 Offset: 0x1895C20 VA: 0x181897220
	|-ArraySortHelper<IntPoint>.Swap
	|
	|-RVA: 0x10DDCA0 Offset: 0x10DC6A0 VA: 0x1810DDCA0
	|-ArraySortHelper<JsonPosition>.Swap
	|-ArraySortHelper<StyleSyntaxToken>.Swap
	|-ArraySortHelper<TreeViewItemWrapper>.Swap
	|-ArraySortHelper<LatencySimulator.Message>.Swap
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.Swap
	|-ArraySortHelper<StructySync.ChangeData>.Swap
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Swap
	|
	|-RVA: 0x1017E70 Offset: 0x1016870 VA: 0x181017E70
	|-ArraySortHelper<Label>.Swap
	|-ArraySortHelper<PlayerLoopSystem>.Swap
	|-ArraySortHelper<PlayerLoopSystemInternal>.Swap
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.Swap
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.Swap
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Swap
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Swap
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Swap
	|
	|-RVA: 0x191CFE0 Offset: 0x191B9E0 VA: 0x18191CFE0
	|-ArraySortHelper<Matrix4x4>.Swap
	|
	|-RVA: 0x191CEC0 Offset: 0x191B8C0 VA: 0x18191CEC0
	|-ArraySortHelper<NavMeshBuildSource>.Swap
	|
	|-RVA: 0x191D0A0 Offset: 0x191BAA0 VA: 0x18191D0A0
	|-ArraySortHelper<object>.Swap
	|
	|-RVA: 0x10DE210 Offset: 0x10DCC10 VA: 0x1810DE210
	|-ArraySortHelper<PlayableBinding>.Swap
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Swap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.Swap
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.Swap
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.Swap
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.Swap
	|
	|-RVA: 0x1017BD0 Offset: 0x10165D0 VA: 0x181017BD0
	|-ArraySortHelper<RenderTargetIdentifier>.Swap
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Swap
	|
	|-RVA: 0x19AAB10 Offset: 0x19A9510 VA: 0x1819AAB10
	|-ArraySortHelper<float>.Swap
	|
	|-RVA: 0x19AA930 Offset: 0x19A9330 VA: 0x1819AA930
	|-ArraySortHelper<UIVertex>.Swap
	|
	|-RVA: 0x10DDD70 Offset: 0x10DC770 VA: 0x1810DDD70
	|-ArraySortHelper<UsageHint>.Swap
	|-ArraySortHelper<SVGDocument.PostponedClip>.Swap
	|-ArraySortHelper<SVGDocument.PostponedStopData>.Swap
	|
	|-RVA: 0x19AAA90 Offset: 0x19A9490 VA: 0x1819AAA90
	|-ArraySortHelper<Vector2>.Swap
	|
	|-RVA: 0x1180060 Offset: 0x117EA60 VA: 0x181180060
	|-ArraySortHelper<VoxelContour>.Swap
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.Swap
	|
	|-RVA: 0x1018520 Offset: 0x1016F20 VA: 0x181018520
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.Swap
	|
	|-RVA: 0x1017760 Offset: 0x1016160 VA: 0x181017760
	|-ArraySortHelper<XRView>.Swap
	|
	|-RVA: 0x1018290 Offset: 0x1016C90 VA: 0x181018290
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.Swap
	|
	|-RVA: 0x1018940 Offset: 0x1017340 VA: 0x181018940
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Swap
	|-ArraySortHelper<ShadowUtility.Edge>.Swap
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Swap
	|
	|-RVA: 0x1017F60 Offset: 0x1016960 VA: 0x181017F60
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.Swap
	|
	|-RVA: 0x1017CF0 Offset: 0x10166F0 VA: 0x181017CF0
	|-ArraySortHelper<HID.HIDElementDescriptor>.Swap
	|
	|-RVA: 0x10187A0 Offset: 0x10171A0 VA: 0x1810187A0
	|-ArraySortHelper<InputControlLayout.ControlItem>.Swap
	|
	|-RVA: 0x10DE070 Offset: 0x10DCA70 VA: 0x1810DE070
	|-ArraySortHelper<JsonParser.JsonValue>.Swap
	|
	|-RVA: 0x10DE3E0 Offset: 0x10DCDE0 VA: 0x1810DE3E0
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.Swap
	|
	|-RVA: 0x10DDC20 Offset: 0x10DC620 VA: 0x1810DDC20
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.Swap
	|
	|-RVA: 0x10DDE00 Offset: 0x10DC800 VA: 0x1810DDE00
	|-ArraySortHelper<RenderChain.RenderNodeData>.Swap
	|
	|-RVA: 0x10DE2E0 Offset: 0x10DCCE0 VA: 0x1810DE2E0
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.Swap
	|
	|-RVA: 0x1180220 Offset: 0x117EC20 VA: 0x181180220
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Swap
	|
	|-RVA: 0x117FF20 Offset: 0x117E920 VA: 0x18117FF20
	|-ArraySortHelper<UIRStylePainter.Entry>.Swap
	|
	|-RVA: 0x1180330 Offset: 0x117ED30 VA: 0x181180330
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.Swap
	|
	|-RVA: 0x1180420 Offset: 0x117EE20 VA: 0x181180420
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.Swap
	|
	|-RVA: 0x1180140 Offset: 0x117EB40 VA: 0x181180140
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1008E30 Offset: 0x1007830 VA: 0x181008E30
	|-ArraySortHelper<ArraySegment<byte>>.IntrospectiveSort
	|-ArraySortHelper<KeyValuePair<object, bool>>.IntrospectiveSort
	|-ArraySortHelper<KeyValuePair<object, char>>.IntrospectiveSort
	|-ArraySortHelper<KeyValuePair<object, object>>.IntrospectiveSort
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.IntrospectiveSort
	|-ArraySortHelper<StructMultiKey<object, object>>.IntrospectiveSort
	|-ArraySortHelper<SubArray<int>>.IntrospectiveSort
	|-ArraySortHelper<ValueTuple<object, object>>.IntrospectiveSort
	|-ArraySortHelper<BezierContour>.IntrospectiveSort
	|-ArraySortHelper<Connection>.IntrospectiveSort
	|-ArraySortHelper<CoordinateFootprintTilePair>.IntrospectiveSort
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.IntrospectiveSort
	|-ArraySortHelper<CoordinateStorageTilePair>.IntrospectiveSort
	|-ArraySortHelper<CoordinateTilePair>.IntrospectiveSort
	|-ArraySortHelper<DualPrefab>.IntrospectiveSort
	|-ArraySortHelper<Entry>.IntrospectiveSort
	|-ArraySortHelper<InternedString>.IntrospectiveSort
	|-ArraySortHelper<InterpretedFrameInfo>.IntrospectiveSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.IntrospectiveSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.IntrospectiveSort
	|-ArraySortHelper<RangePositionInfo>.IntrospectiveSort
	|-ArraySortHelper<RuleMatcher>.IntrospectiveSort
	|-ArraySortHelper<StylePropertyValue>.IntrospectiveSort
	|-ArraySortHelper<Substring>.IntrospectiveSort
	|-ArraySortHelper<UnloadedScene>.IntrospectiveSort
	|-ArraySortHelper<CameraState.CustomBlendable>.IntrospectiveSort
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.IntrospectiveSort
	|-ArraySortHelper<FocusController.FocusedElement>.IntrospectiveSort
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.IntrospectiveSort
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.IntrospectiveSort
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.IntrospectiveSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.IntrospectiveSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.IntrospectiveSort
	|-ArraySortHelper<SVGDocument.NodeWithParent>.IntrospectiveSort
	|-ArraySortHelper<TargetStateListener.Callback>.IntrospectiveSort
	|-ArraySortHelper<TextSettings.FontReferenceMap>.IntrospectiveSort
	|-ArraySortHelper<TextureRegistry.TextureInfo>.IntrospectiveSort
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.IntrospectiveSort
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.IntrospectiveSort
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IntrospectiveSort
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.IntrospectiveSort
	|
	|-RVA: 0x1008B90 Offset: 0x1007590 VA: 0x181008B90
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.IntrospectiveSort
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.IntrospectiveSort
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.IntrospectiveSort
	|-ArraySortHelper<NativeArray<NudgeJobData>>.IntrospectiveSort
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.IntrospectiveSort
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.IntrospectiveSort
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.IntrospectiveSort
	|-ArraySortHelper<Nullable<DateTime>>.IntrospectiveSort
	|-ArraySortHelper<AsyncGPUReadbackRequest>.IntrospectiveSort
	|-ArraySortHelper<DateTimeOffset>.IntrospectiveSort
	|-ArraySortHelper<Decimal>.IntrospectiveSort
	|-ArraySortHelper<GlyphRect>.IntrospectiveSort
	|-ArraySortHelper<Guid>.IntrospectiveSort
	|-ArraySortHelper<IntPoint>.IntrospectiveSort
	|-ArraySortHelper<IntRect>.IntrospectiveSort
	|-ArraySortHelper<Playable>.IntrospectiveSort
	|-ArraySortHelper<RectInt>.IntrospectiveSort
	|-ArraySortHelper<Resolution>.IntrospectiveSort
	|-ArraySortHelper<SamplePointUData>.IntrospectiveSort
	|-ArraySortHelper<UILineInfo>.IntrospectiveSort
	|-ArraySortHelper<ClipperLib.IntPoint>.IntrospectiveSort
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.IntrospectiveSort
	|-ArraySortHelper<ServerSocket.ConnectionChange>.IntrospectiveSort
	|
	|-RVA: 0x1009370 Offset: 0x1007D70 VA: 0x181009370
	|-ArraySortHelper<SyncList.ChangeData<int>>.IntrospectiveSort
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.IntrospectiveSort
	|-ArraySortHelper<DuplicateSamplePoint>.IntrospectiveSort
	|-ArraySortHelper<Int3>.IntrospectiveSort
	|-ArraySortHelper<IntRegion>.IntrospectiveSort
	|-ArraySortHelper<ManipulatorActivationFilter>.IntrospectiveSort
	|-ArraySortHelper<UICharInfo>.IntrospectiveSort
	|-ArraySortHelper<Vector3>.IntrospectiveSort
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.IntrospectiveSort
	|-ArraySortHelper<HIDParser.HIDReportData>.IntrospectiveSort
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.IntrospectiveSort
	|-ArraySortHelper<SyncTimer.ChangeData>.IntrospectiveSort
	|
	|-RVA: 0x16A25A0 Offset: 0x16A0FA0 VA: 0x1816A25A0
	|-ArraySortHelper<IntervalTree.Entry<object>>.IntrospectiveSort
	|-ArraySortHelper<KeyValuePair<Rect, object>>.IntrospectiveSort
	|-ArraySortHelper<ComputedTransitionProperty>.IntrospectiveSort
	|-ArraySortHelper<ContourVertex>.IntrospectiveSort
	|
	|-RVA: 0x10088F0 Offset: 0x10072F0 VA: 0x1810088F0
	|-ArraySortHelper<KeyValuePair<int, object>>.IntrospectiveSort
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.IntrospectiveSort
	|-ArraySortHelper<ValueTuple<int, object>>.IntrospectiveSort
	|-ArraySortHelper<EventSummary>.IntrospectiveSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.IntrospectiveSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.IntrospectiveSort
	|-ArraySortHelper<StylePropertyName>.IntrospectiveSort
	|-ArraySortHelper<StyleValueManaged>.IntrospectiveSort
	|-ArraySortHelper<X509ChainStatus>.IntrospectiveSort
	|-ArraySortHelper<ZipGenericExtraField>.IntrospectiveSort
	|-ArraySortHelper<AdvancedSmooth.Turn>.IntrospectiveSort
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.IntrospectiveSort
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.IntrospectiveSort
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.IntrospectiveSort
	|-ArraySortHelper<TransportManager.DisconnectingClient>.IntrospectiveSort
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.IntrospectiveSort
	|
	|-RVA: 0x16A24C0 Offset: 0x16A0EC0 VA: 0x1816A24C0
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.IntrospectiveSort
	|-ArraySortHelper<RaycastResult>.IntrospectiveSort
	|
	|-RVA: 0x1009530 Offset: 0x1007F30 VA: 0x181009530
	|-ArraySortHelper<Nullable<Decimal>>.IntrospectiveSort
	|-ArraySortHelper<TempAllocator.Page<ushort>>.IntrospectiveSort
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.IntrospectiveSort
	|-ArraySortHelper<BezierPathSegment>.IntrospectiveSort
	|-ArraySortHelper<Bounds>.IntrospectiveSort
	|-ArraySortHelper<FrameTimeSample>.IntrospectiveSort
	|-ArraySortHelper<IntervalTreeNode>.IntrospectiveSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.IntrospectiveSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.IntrospectiveSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.IntrospectiveSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.IntrospectiveSort
	|-ArraySortHelper<RendererList>.IntrospectiveSort
	|-ArraySortHelper<StyleValue>.IntrospectiveSort
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.IntrospectiveSort
	|
	|-RVA: 0x1008F10 Offset: 0x1007910 VA: 0x181008F10
	|-ArraySortHelper<ValueTuple<int, int>>.IntrospectiveSort
	|-ArraySortHelper<ValueTuple<int, Scene>>.IntrospectiveSort
	|-ArraySortHelper<AnimatorClipInfo>.IntrospectiveSort
	|-ArraySortHelper<DateTime>.IntrospectiveSort
	|-ArraySortHelper<InputEventPtr>.IntrospectiveSort
	|-ArraySortHelper<RendererListHandle>.IntrospectiveSort
	|-ArraySortHelper<ResourceHandle>.IntrospectiveSort
	|-ArraySortHelper<SamplePointsPatch>.IntrospectiveSort
	|-ArraySortHelper<TimeSpan>.IntrospectiveSort
	|-ArraySortHelper<TimeValue>.IntrospectiveSort
	|-ArraySortHelper<BitmapAllocator32.Page>.IntrospectiveSort
	|-ArraySortHelper<CinemachineClearShot.Pair>.IntrospectiveSort
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.IntrospectiveSort
	|-ArraySortHelper<PlayingCard.CardData>.IntrospectiveSort
	|-ArraySortHelper<SyncStopwatch.ChangeData>.IntrospectiveSort
	|
	|-RVA: 0x1008D50 Offset: 0x1007750 VA: 0x181008D50
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.IntrospectiveSort
	|-ArraySortHelper<CoordinateProceduralTilePair>.IntrospectiveSort
	|-ArraySortHelper<NameAndParameters>.IntrospectiveSort
	|-ArraySortHelper<NamedValue>.IntrospectiveSort
	|-ArraySortHelper<SelectorMatchRecord>.IntrospectiveSort
	|-ArraySortHelper<StyleSelectorPart>.IntrospectiveSort
	|-ArraySortHelper<StyleVariable>.IntrospectiveSort
	|-ArraySortHelper<XRFeatureDescriptor>.IntrospectiveSort
	|-ArraySortHelper<AvatarSettings.LayerSetting>.IntrospectiveSort
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.IntrospectiveSort
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.IntrospectiveSort
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.IntrospectiveSort
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.IntrospectiveSort
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.IntrospectiveSort
	|
	|-RVA: 0x10090D0 Offset: 0x1007AD0 VA: 0x1810090D0
	|-ArraySortHelper<BezierSegment>.IntrospectiveSort
	|-ArraySortHelper<NavMeshBuildMarkup>.IntrospectiveSort
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.IntrospectiveSort
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.IntrospectiveSort
	|
	|-RVA: 0x17F4720 Offset: 0x17F3120 VA: 0x1817F4720
	|-ArraySortHelper<bool>.IntrospectiveSort
	|-ArraySortHelper<byte>.IntrospectiveSort
	|-ArraySortHelper<sbyte>.IntrospectiveSort
	|
	|-RVA: 0x17F4800 Offset: 0x17F3200 VA: 0x1817F4800
	|-ArraySortHelper<CGSpot>.IntrospectiveSort
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.IntrospectiveSort
	|-ArraySortHelper<RaycastHit>.IntrospectiveSort
	|
	|-RVA: 0x17F4640 Offset: 0x17F3040 VA: 0x1817F4640
	|-ArraySortHelper<char>.IntrospectiveSort
	|-ArraySortHelper<short>.IntrospectiveSort
	|-ArraySortHelper<ushort>.IntrospectiveSort
	|
	|-RVA: 0x17F48E0 Offset: 0x17F32E0 VA: 0x1817F48E0
	|-ArraySortHelper<Color>.IntrospectiveSort
	|-ArraySortHelper<Quaternion>.IntrospectiveSort
	|-ArraySortHelper<Vector4>.IntrospectiveSort
	|
	|-RVA: 0x10D50C0 Offset: 0x10D3AC0 VA: 0x1810D50C0
	|-ArraySortHelper<Color32>.IntrospectiveSort
	|-ArraySortHelper<EasingFunction>.IntrospectiveSort
	|-ArraySortHelper<Scene>.IntrospectiveSort
	|-ArraySortHelper<ShaderTagId>.IntrospectiveSort
	|-ArraySortHelper<UShort2>.IntrospectiveSort
	|-ArraySortHelper<RegexCharClass.SingleRange>.IntrospectiveSort
	|
	|-RVA: 0x17F49C0 Offset: 0x17F33C0 VA: 0x1817F49C0
	|-ArraySortHelper<CombineInstance>.IntrospectiveSort
	|
	|-RVA: 0x10098E0 Offset: 0x10082E0 VA: 0x1810098E0
	|-ArraySortHelper<ControlPointOption>.IntrospectiveSort
	|-ArraySortHelper<RaycastHit2D>.IntrospectiveSort
	|-ArraySortHelper<Funnel.PathPart>.IntrospectiveSort
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.IntrospectiveSort
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.IntrospectiveSort
	|
	|-RVA: 0x17F4B80 Offset: 0x17F3580 VA: 0x1817F4B80
	|-ArraySortHelper<DisplayInfo>.IntrospectiveSort
	|
	|-RVA: 0x17F4AA0 Offset: 0x17F34A0 VA: 0x1817F4AA0
	|-ArraySortHelper<double>.IntrospectiveSort
	|
	|-RVA: 0x1008FF0 Offset: 0x10079F0 VA: 0x181008FF0
	|-ArraySortHelper<DoublePoint>.IntrospectiveSort
	|-ArraySortHelper<DoublePoint>.IntrospectiveSort
	|-ArraySortHelper<ClipperLib.DoublePoint>.IntrospectiveSort
	|
	|-RVA: 0x1891170 Offset: 0x188FB70 VA: 0x181891170
	|-ArraySortHelper<InputBinding>.IntrospectiveSort
	|
	|-RVA: 0x10D49C0 Offset: 0x10D33C0 VA: 0x1810D49C0
	|-ArraySortHelper<InputDeviceDescription>.IntrospectiveSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.IntrospectiveSort
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.IntrospectiveSort
	|-ArraySortHelper<TextureBlitter.BlitInfo>.IntrospectiveSort
	|
	|-RVA: 0x1890FB0 Offset: 0x188F9B0 VA: 0x181890FB0
	|-ArraySortHelper<int>.IntrospectiveSort
	|-ArraySortHelper<Int32Enum>.IntrospectiveSort
	|-ArraySortHelper<uint>.IntrospectiveSort
	|-ArraySortHelper<UInt32Enum>.IntrospectiveSort
	|
	|-RVA: 0x1891250 Offset: 0x188FC50 VA: 0x181891250
	|-ArraySortHelper<long>.IntrospectiveSort
	|-ArraySortHelper<ulong>.IntrospectiveSort
	|
	|-RVA: 0x1891090 Offset: 0x188FA90 VA: 0x181891090
	|-ArraySortHelper<IntPoint>.IntrospectiveSort
	|
	|-RVA: 0x10D4FE0 Offset: 0x10D39E0 VA: 0x1810D4FE0
	|-ArraySortHelper<JsonPosition>.IntrospectiveSort
	|-ArraySortHelper<StyleSyntaxToken>.IntrospectiveSort
	|-ArraySortHelper<TreeViewItemWrapper>.IntrospectiveSort
	|-ArraySortHelper<LatencySimulator.Message>.IntrospectiveSort
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.IntrospectiveSort
	|-ArraySortHelper<StructySync.ChangeData>.IntrospectiveSort
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.IntrospectiveSort
	|
	|-RVA: 0x1009290 Offset: 0x1007C90 VA: 0x181009290
	|-ArraySortHelper<Label>.IntrospectiveSort
	|-ArraySortHelper<PlayerLoopSystem>.IntrospectiveSort
	|-ArraySortHelper<PlayerLoopSystemInternal>.IntrospectiveSort
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.IntrospectiveSort
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.IntrospectiveSort
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.IntrospectiveSort
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.IntrospectiveSort
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.IntrospectiveSort
	|
	|-RVA: 0x19175C0 Offset: 0x1915FC0 VA: 0x1819175C0
	|-ArraySortHelper<Matrix4x4>.IntrospectiveSort
	|
	|-RVA: 0x19176A0 Offset: 0x19160A0 VA: 0x1819176A0
	|-ArraySortHelper<NavMeshBuildSource>.IntrospectiveSort
	|
	|-RVA: 0x19174E0 Offset: 0x1915EE0 VA: 0x1819174E0
	|-ArraySortHelper<object>.IntrospectiveSort
	|
	|-RVA: 0x10D4B80 Offset: 0x10D3580 VA: 0x1810D4B80
	|-ArraySortHelper<PlayableBinding>.IntrospectiveSort
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.IntrospectiveSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.IntrospectiveSort
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.IntrospectiveSort
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.IntrospectiveSort
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.IntrospectiveSort
	|
	|-RVA: 0x10091B0 Offset: 0x1007BB0 VA: 0x1810091B0
	|-ArraySortHelper<RenderTargetIdentifier>.IntrospectiveSort
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.IntrospectiveSort
	|
	|-RVA: 0x19A4F60 Offset: 0x19A3960 VA: 0x1819A4F60
	|-ArraySortHelper<float>.IntrospectiveSort
	|
	|-RVA: 0x19A5120 Offset: 0x19A3B20 VA: 0x1819A5120
	|-ArraySortHelper<UIVertex>.IntrospectiveSort
	|
	|-RVA: 0x10D48E0 Offset: 0x10D32E0 VA: 0x1810D48E0
	|-ArraySortHelper<UsageHint>.IntrospectiveSort
	|-ArraySortHelper<SVGDocument.PostponedClip>.IntrospectiveSort
	|-ArraySortHelper<SVGDocument.PostponedStopData>.IntrospectiveSort
	|
	|-RVA: 0x19A5040 Offset: 0x19A3A40 VA: 0x1819A5040
	|-ArraySortHelper<Vector2>.IntrospectiveSort
	|
	|-RVA: 0x1178E10 Offset: 0x1177810 VA: 0x181178E10
	|-ArraySortHelper<VoxelContour>.IntrospectiveSort
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.IntrospectiveSort
	|
	|-RVA: 0x1009450 Offset: 0x1007E50 VA: 0x181009450
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.IntrospectiveSort
	|
	|-RVA: 0x10089D0 Offset: 0x10073D0 VA: 0x1810089D0
	|-ArraySortHelper<XRView>.IntrospectiveSort
	|
	|-RVA: 0x10096F0 Offset: 0x10080F0 VA: 0x1810096F0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.IntrospectiveSort
	|
	|-RVA: 0x1008C70 Offset: 0x1007670 VA: 0x181008C70
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.IntrospectiveSort
	|-ArraySortHelper<ShadowUtility.Edge>.IntrospectiveSort
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.IntrospectiveSort
	|
	|-RVA: 0x1009610 Offset: 0x1008010 VA: 0x181009610
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.IntrospectiveSort
	|
	|-RVA: 0x1008AB0 Offset: 0x10074B0 VA: 0x181008AB0
	|-ArraySortHelper<HID.HIDElementDescriptor>.IntrospectiveSort
	|
	|-RVA: 0x1009800 Offset: 0x1008200 VA: 0x181009800
	|-ArraySortHelper<InputControlLayout.ControlItem>.IntrospectiveSort
	|
	|-RVA: 0x10D4D40 Offset: 0x10D3740 VA: 0x1810D4D40
	|-ArraySortHelper<JsonParser.JsonValue>.IntrospectiveSort
	|
	|-RVA: 0x10D4C60 Offset: 0x10D3660 VA: 0x1810D4C60
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.IntrospectiveSort
	|
	|-RVA: 0x10D4E20 Offset: 0x10D3820 VA: 0x1810D4E20
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.IntrospectiveSort
	|
	|-RVA: 0x10D4F00 Offset: 0x10D3900 VA: 0x1810D4F00
	|-ArraySortHelper<RenderChain.RenderNodeData>.IntrospectiveSort
	|
	|-RVA: 0x10D4AA0 Offset: 0x10D34A0 VA: 0x1810D4AA0
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.IntrospectiveSort
	|
	|-RVA: 0x1178D30 Offset: 0x1177730 VA: 0x181178D30
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.IntrospectiveSort
	|
	|-RVA: 0x1178C50 Offset: 0x1177650 VA: 0x181178C50
	|-ArraySortHelper<UIRStylePainter.Entry>.IntrospectiveSort
	|
	|-RVA: 0x1178A90 Offset: 0x1177490 VA: 0x181178A90
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.IntrospectiveSort
	|
	|-RVA: 0x1178B70 Offset: 0x1177570 VA: 0x181178B70
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.IntrospectiveSort
	|
	|-RVA: 0x1178EF0 Offset: 0x11778F0 VA: 0x181178EF0
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1005180 Offset: 0x1003B80 VA: 0x181005180
	|-ArraySortHelper<ArraySegment<byte>>.IntroSort
	|-ArraySortHelper<KeyValuePair<object, bool>>.IntroSort
	|-ArraySortHelper<KeyValuePair<object, char>>.IntroSort
	|-ArraySortHelper<KeyValuePair<object, object>>.IntroSort
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.IntroSort
	|-ArraySortHelper<StructMultiKey<object, object>>.IntroSort
	|-ArraySortHelper<SubArray<int>>.IntroSort
	|-ArraySortHelper<ValueTuple<object, object>>.IntroSort
	|-ArraySortHelper<BezierContour>.IntroSort
	|-ArraySortHelper<Connection>.IntroSort
	|-ArraySortHelper<CoordinateFootprintTilePair>.IntroSort
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.IntroSort
	|-ArraySortHelper<CoordinateStorageTilePair>.IntroSort
	|-ArraySortHelper<CoordinateTilePair>.IntroSort
	|-ArraySortHelper<DualPrefab>.IntroSort
	|-ArraySortHelper<Entry>.IntroSort
	|-ArraySortHelper<InternedString>.IntroSort
	|-ArraySortHelper<InterpretedFrameInfo>.IntroSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.IntroSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.IntroSort
	|-ArraySortHelper<RangePositionInfo>.IntroSort
	|-ArraySortHelper<RuleMatcher>.IntroSort
	|-ArraySortHelper<StylePropertyValue>.IntroSort
	|-ArraySortHelper<Substring>.IntroSort
	|-ArraySortHelper<UnloadedScene>.IntroSort
	|-ArraySortHelper<CameraState.CustomBlendable>.IntroSort
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.IntroSort
	|-ArraySortHelper<FocusController.FocusedElement>.IntroSort
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.IntroSort
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.IntroSort
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.IntroSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.IntroSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.IntroSort
	|-ArraySortHelper<SVGDocument.NodeWithParent>.IntroSort
	|-ArraySortHelper<TargetStateListener.Callback>.IntroSort
	|-ArraySortHelper<TextSettings.FontReferenceMap>.IntroSort
	|-ArraySortHelper<TextureRegistry.TextureInfo>.IntroSort
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.IntroSort
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.IntroSort
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IntroSort
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.IntroSort
	|
	|-RVA: 0x1007A70 Offset: 0x1006470 VA: 0x181007A70
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.IntroSort
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.IntroSort
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.IntroSort
	|-ArraySortHelper<NativeArray<NudgeJobData>>.IntroSort
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.IntroSort
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.IntroSort
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.IntroSort
	|-ArraySortHelper<Nullable<DateTime>>.IntroSort
	|-ArraySortHelper<AsyncGPUReadbackRequest>.IntroSort
	|-ArraySortHelper<DateTimeOffset>.IntroSort
	|-ArraySortHelper<Decimal>.IntroSort
	|-ArraySortHelper<GlyphRect>.IntroSort
	|-ArraySortHelper<Guid>.IntroSort
	|-ArraySortHelper<IntPoint>.IntroSort
	|-ArraySortHelper<IntRect>.IntroSort
	|-ArraySortHelper<Playable>.IntroSort
	|-ArraySortHelper<RectInt>.IntroSort
	|-ArraySortHelper<Resolution>.IntroSort
	|-ArraySortHelper<SamplePointUData>.IntroSort
	|-ArraySortHelper<UILineInfo>.IntroSort
	|-ArraySortHelper<ClipperLib.IntPoint>.IntroSort
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.IntroSort
	|-ArraySortHelper<ServerSocket.ConnectionChange>.IntroSort
	|
	|-RVA: 0x10058C0 Offset: 0x10042C0 VA: 0x1810058C0
	|-ArraySortHelper<SyncList.ChangeData<int>>.IntroSort
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.IntroSort
	|-ArraySortHelper<DuplicateSamplePoint>.IntroSort
	|-ArraySortHelper<Int3>.IntroSort
	|-ArraySortHelper<IntRegion>.IntroSort
	|-ArraySortHelper<ManipulatorActivationFilter>.IntroSort
	|-ArraySortHelper<UICharInfo>.IntroSort
	|-ArraySortHelper<Vector3>.IntroSort
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.IntroSort
	|-ArraySortHelper<HIDParser.HIDReportData>.IntroSort
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.IntroSort
	|-ArraySortHelper<SyncTimer.ChangeData>.IntroSort
	|
	|-RVA: 0x16A2120 Offset: 0x16A0B20 VA: 0x1816A2120
	|-ArraySortHelper<IntervalTree.Entry<object>>.IntroSort
	|-ArraySortHelper<KeyValuePair<Rect, object>>.IntroSort
	|-ArraySortHelper<ComputedTransitionProperty>.IntroSort
	|-ArraySortHelper<ContourVertex>.IntroSort
	|
	|-RVA: 0x10046A0 Offset: 0x10030A0 VA: 0x1810046A0
	|-ArraySortHelper<KeyValuePair<int, object>>.IntroSort
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.IntroSort
	|-ArraySortHelper<ValueTuple<int, object>>.IntroSort
	|-ArraySortHelper<EventSummary>.IntroSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.IntroSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.IntroSort
	|-ArraySortHelper<StylePropertyName>.IntroSort
	|-ArraySortHelper<StyleValueManaged>.IntroSort
	|-ArraySortHelper<X509ChainStatus>.IntroSort
	|-ArraySortHelper<ZipGenericExtraField>.IntroSort
	|-ArraySortHelper<AdvancedSmooth.Turn>.IntroSort
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.IntroSort
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.IntroSort
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.IntroSort
	|-ArraySortHelper<TransportManager.DisconnectingClient>.IntroSort
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.IntroSort
	|
	|-RVA: 0x16A1D80 Offset: 0x16A0780 VA: 0x1816A1D80
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.IntroSort
	|-ArraySortHelper<RaycastResult>.IntroSort
	|
	|-RVA: 0x1007220 Offset: 0x1005C20 VA: 0x181007220
	|-ArraySortHelper<Nullable<Decimal>>.IntroSort
	|-ArraySortHelper<TempAllocator.Page<ushort>>.IntroSort
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.IntroSort
	|-ArraySortHelper<BezierPathSegment>.IntroSort
	|-ArraySortHelper<Bounds>.IntroSort
	|-ArraySortHelper<FrameTimeSample>.IntroSort
	|-ArraySortHelper<IntervalTreeNode>.IntroSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.IntroSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.IntroSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.IntroSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.IntroSort
	|-ArraySortHelper<RendererList>.IntroSort
	|-ArraySortHelper<StyleValue>.IntroSort
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.IntroSort
	|
	|-RVA: 0x1004300 Offset: 0x1002D00 VA: 0x181004300
	|-ArraySortHelper<ValueTuple<int, int>>.IntroSort
	|-ArraySortHelper<ValueTuple<int, Scene>>.IntroSort
	|-ArraySortHelper<AnimatorClipInfo>.IntroSort
	|-ArraySortHelper<DateTime>.IntroSort
	|-ArraySortHelper<InputEventPtr>.IntroSort
	|-ArraySortHelper<RendererListHandle>.IntroSort
	|-ArraySortHelper<ResourceHandle>.IntroSort
	|-ArraySortHelper<SamplePointsPatch>.IntroSort
	|-ArraySortHelper<TimeSpan>.IntroSort
	|-ArraySortHelper<TimeValue>.IntroSort
	|-ArraySortHelper<BitmapAllocator32.Page>.IntroSort
	|-ArraySortHelper<CinemachineClearShot.Pair>.IntroSort
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.IntroSort
	|-ArraySortHelper<PlayingCard.CardData>.IntroSort
	|-ArraySortHelper<SyncStopwatch.ChangeData>.IntroSort
	|
	|-RVA: 0x1006000 Offset: 0x1004A00 VA: 0x181006000
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.IntroSort
	|-ArraySortHelper<CoordinateProceduralTilePair>.IntroSort
	|-ArraySortHelper<NameAndParameters>.IntroSort
	|-ArraySortHelper<NamedValue>.IntroSort
	|-ArraySortHelper<SelectorMatchRecord>.IntroSort
	|-ArraySortHelper<StyleSelectorPart>.IntroSort
	|-ArraySortHelper<StyleVariable>.IntroSort
	|-ArraySortHelper<XRFeatureDescriptor>.IntroSort
	|-ArraySortHelper<AvatarSettings.LayerSetting>.IntroSort
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.IntroSort
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.IntroSort
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.IntroSort
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.IntroSort
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.IntroSort
	|
	|-RVA: 0x10081B0 Offset: 0x1006BB0 VA: 0x1810081B0
	|-ArraySortHelper<BezierSegment>.IntroSort
	|-ArraySortHelper<NavMeshBuildMarkup>.IntroSort
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.IntroSort
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.IntroSort
	|
	|-RVA: 0x17F3080 Offset: 0x17F1A80 VA: 0x1817F3080
	|-ArraySortHelper<bool>.IntroSort
	|-ArraySortHelper<byte>.IntroSort
	|-ArraySortHelper<sbyte>.IntroSort
	|
	|-RVA: 0x17F42A0 Offset: 0x17F2CA0 VA: 0x1817F42A0
	|-ArraySortHelper<CGSpot>.IntroSort
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.IntroSort
	|-ArraySortHelper<RaycastHit>.IntroSort
	|
	|-RVA: 0x17F3420 Offset: 0x17F1E20 VA: 0x1817F3420
	|-ArraySortHelper<char>.IntroSort
	|-ArraySortHelper<short>.IntroSort
	|-ArraySortHelper<ushort>.IntroSort
	|
	|-RVA: 0x17F37C0 Offset: 0x17F21C0 VA: 0x1817F37C0
	|-ArraySortHelper<Color>.IntroSort
	|-ArraySortHelper<Quaternion>.IntroSort
	|-ArraySortHelper<Vector4>.IntroSort
	|
	|-RVA: 0x10D36C0 Offset: 0x10D20C0 VA: 0x1810D36C0
	|-ArraySortHelper<Color32>.IntroSort
	|-ArraySortHelper<EasingFunction>.IntroSort
	|-ArraySortHelper<Scene>.IntroSort
	|-ArraySortHelper<ShaderTagId>.IntroSort
	|-ArraySortHelper<UShort2>.IntroSort
	|-ArraySortHelper<RegexCharClass.SingleRange>.IntroSort
	|
	|-RVA: 0x17F3B60 Offset: 0x17F2560 VA: 0x1817F3B60
	|-ArraySortHelper<CombineInstance>.IntroSort
	|
	|-RVA: 0x1007E10 Offset: 0x1006810 VA: 0x181007E10
	|-ArraySortHelper<ControlPointOption>.IntroSort
	|-ArraySortHelper<RaycastHit2D>.IntroSort
	|-ArraySortHelper<Funnel.PathPart>.IntroSort
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.IntroSort
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.IntroSort
	|
	|-RVA: 0x17F2CE0 Offset: 0x17F16E0 VA: 0x1817F2CE0
	|-ArraySortHelper<DisplayInfo>.IntroSort
	|
	|-RVA: 0x17F3F00 Offset: 0x17F2900 VA: 0x1817F3F00
	|-ArraySortHelper<double>.IntroSort
	|
	|-RVA: 0x1004DE0 Offset: 0x10037E0 VA: 0x181004DE0
	|-ArraySortHelper<DoublePoint>.IntroSort
	|-ArraySortHelper<DoublePoint>.IntroSort
	|-ArraySortHelper<ClipperLib.DoublePoint>.IntroSort
	|
	|-RVA: 0x1890130 Offset: 0x188EB30 VA: 0x181890130
	|-ArraySortHelper<InputBinding>.IntroSort
	|
	|-RVA: 0x10D2BE0 Offset: 0x10D15E0 VA: 0x1810D2BE0
	|-ArraySortHelper<InputDeviceDescription>.IntroSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.IntroSort
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.IntroSort
	|-ArraySortHelper<TextureBlitter.BlitInfo>.IntroSort
	|
	|-RVA: 0x18904D0 Offset: 0x188EED0 VA: 0x1818904D0
	|-ArraySortHelper<int>.IntroSort
	|-ArraySortHelper<Int32Enum>.IntroSort
	|-ArraySortHelper<uint>.IntroSort
	|-ArraySortHelper<UInt32Enum>.IntroSort
	|
	|-RVA: 0x1890C10 Offset: 0x188F610 VA: 0x181890C10
	|-ArraySortHelper<long>.IntroSort
	|-ArraySortHelper<ulong>.IntroSort
	|
	|-RVA: 0x1890870 Offset: 0x188F270 VA: 0x181890870
	|-ArraySortHelper<IntPoint>.IntroSort
	|
	|-RVA: 0x10D41A0 Offset: 0x10D2BA0 VA: 0x1810D41A0
	|-ArraySortHelper<JsonPosition>.IntroSort
	|-ArraySortHelper<StyleSyntaxToken>.IntroSort
	|-ArraySortHelper<TreeViewItemWrapper>.IntroSort
	|-ArraySortHelper<LatencySimulator.Message>.IntroSort
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.IntroSort
	|-ArraySortHelper<StructySync.ChangeData>.IntroSort
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.IntroSort
	|
	|-RVA: 0x1005C60 Offset: 0x1004660 VA: 0x181005C60
	|-ArraySortHelper<Label>.IntroSort
	|-ArraySortHelper<PlayerLoopSystem>.IntroSort
	|-ArraySortHelper<PlayerLoopSystemInternal>.IntroSort
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.IntroSort
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.IntroSort
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.IntroSort
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.IntroSort
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.IntroSort
	|
	|-RVA: 0x1916A00 Offset: 0x1915400 VA: 0x181916A00
	|-ArraySortHelper<Matrix4x4>.IntroSort
	|
	|-RVA: 0x1917140 Offset: 0x1915B40 VA: 0x181917140
	|-ArraySortHelper<NavMeshBuildSource>.IntroSort
	|
	|-RVA: 0x1916DA0 Offset: 0x19157A0 VA: 0x181916DA0
	|-ArraySortHelper<object>.IntroSort
	|
	|-RVA: 0x10D3320 Offset: 0x10D1D20 VA: 0x1810D3320
	|-ArraySortHelper<PlayableBinding>.IntroSort
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.IntroSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.IntroSort
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.IntroSort
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.IntroSort
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.IntroSort
	|
	|-RVA: 0x1004A40 Offset: 0x1003440 VA: 0x181004A40
	|-ArraySortHelper<RenderTargetIdentifier>.IntroSort
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.IntroSort
	|
	|-RVA: 0x19A4BC0 Offset: 0x19A35C0 VA: 0x1819A4BC0
	|-ArraySortHelper<float>.IntroSort
	|
	|-RVA: 0x19A4480 Offset: 0x19A2E80 VA: 0x1819A4480
	|-ArraySortHelper<UIVertex>.IntroSort
	|
	|-RVA: 0x10D24A0 Offset: 0x10D0EA0 VA: 0x1810D24A0
	|-ArraySortHelper<UsageHint>.IntroSort
	|-ArraySortHelper<SVGDocument.PostponedClip>.IntroSort
	|-ArraySortHelper<SVGDocument.PostponedStopData>.IntroSort
	|
	|-RVA: 0x19A4820 Offset: 0x19A3220 VA: 0x1819A4820
	|-ArraySortHelper<Vector2>.IntroSort
	|
	|-RVA: 0x1178350 Offset: 0x1176D50 VA: 0x181178350
	|-ArraySortHelper<VoxelContour>.IntroSort
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.IntroSort
	|
	|-RVA: 0x1006740 Offset: 0x1005140 VA: 0x181006740
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.IntroSort
	|
	|-RVA: 0x1006E80 Offset: 0x1005880 VA: 0x181006E80
	|-ArraySortHelper<XRView>.IntroSort
	|
	|-RVA: 0x10075C0 Offset: 0x1005FC0 VA: 0x1810075C0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.IntroSort
	|
	|-RVA: 0x10063A0 Offset: 0x1004DA0 VA: 0x1810063A0
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.IntroSort
	|-ArraySortHelper<ShadowUtility.Edge>.IntroSort
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.IntroSort
	|
	|-RVA: 0x1006AE0 Offset: 0x10054E0 VA: 0x181006AE0
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.IntroSort
	|
	|-RVA: 0x1005520 Offset: 0x1003F20 VA: 0x181005520
	|-ArraySortHelper<HID.HIDElementDescriptor>.IntroSort
	|
	|-RVA: 0x1008550 Offset: 0x1006F50 VA: 0x181008550
	|-ArraySortHelper<InputControlLayout.ControlItem>.IntroSort
	|
	|-RVA: 0x10D4540 Offset: 0x10D2F40 VA: 0x1810D4540
	|-ArraySortHelper<JsonParser.JsonValue>.IntroSort
	|
	|-RVA: 0x10D2840 Offset: 0x10D1240 VA: 0x1810D2840
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.IntroSort
	|
	|-RVA: 0x10D3A60 Offset: 0x10D2460 VA: 0x1810D3A60
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.IntroSort
	|
	|-RVA: 0x10D3E00 Offset: 0x10D2800 VA: 0x1810D3E00
	|-ArraySortHelper<RenderChain.RenderNodeData>.IntroSort
	|
	|-RVA: 0x10D2F80 Offset: 0x10D1980 VA: 0x1810D2F80
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.IntroSort
	|
	|-RVA: 0x11786F0 Offset: 0x11770F0 VA: 0x1811786F0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.IntroSort
	|
	|-RVA: 0x11774D0 Offset: 0x1175ED0 VA: 0x1811774D0
	|-ArraySortHelper<UIRStylePainter.Entry>.IntroSort
	|
	|-RVA: 0x1177870 Offset: 0x1176270 VA: 0x181177870
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.IntroSort
	|
	|-RVA: 0x1177C10 Offset: 0x1176610 VA: 0x181177C10
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.IntroSort
	|
	|-RVA: 0x1177FB0 Offset: 0x11769B0 VA: 0x181177FB0
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A3A0 Offset: 0x1008DA0 VA: 0x18100A3A0
	|-ArraySortHelper<ArraySegment<byte>>.PickPivotAndPartition
	|-ArraySortHelper<KeyValuePair<object, bool>>.PickPivotAndPartition
	|-ArraySortHelper<KeyValuePair<object, char>>.PickPivotAndPartition
	|-ArraySortHelper<KeyValuePair<object, object>>.PickPivotAndPartition
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.PickPivotAndPartition
	|-ArraySortHelper<StructMultiKey<object, object>>.PickPivotAndPartition
	|-ArraySortHelper<SubArray<int>>.PickPivotAndPartition
	|-ArraySortHelper<ValueTuple<object, object>>.PickPivotAndPartition
	|-ArraySortHelper<BezierContour>.PickPivotAndPartition
	|-ArraySortHelper<Connection>.PickPivotAndPartition
	|-ArraySortHelper<CoordinateFootprintTilePair>.PickPivotAndPartition
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.PickPivotAndPartition
	|-ArraySortHelper<CoordinateStorageTilePair>.PickPivotAndPartition
	|-ArraySortHelper<CoordinateTilePair>.PickPivotAndPartition
	|-ArraySortHelper<DualPrefab>.PickPivotAndPartition
	|-ArraySortHelper<Entry>.PickPivotAndPartition
	|-ArraySortHelper<InternedString>.PickPivotAndPartition
	|-ArraySortHelper<InterpretedFrameInfo>.PickPivotAndPartition
	|-ArraySortHelper<LigatureSubstitutionRecord>.PickPivotAndPartition
	|-ArraySortHelper<LigatureSubstitutionRecord>.PickPivotAndPartition
	|-ArraySortHelper<RangePositionInfo>.PickPivotAndPartition
	|-ArraySortHelper<RuleMatcher>.PickPivotAndPartition
	|-ArraySortHelper<StylePropertyValue>.PickPivotAndPartition
	|-ArraySortHelper<Substring>.PickPivotAndPartition
	|-ArraySortHelper<UnloadedScene>.PickPivotAndPartition
	|-ArraySortHelper<CameraState.CustomBlendable>.PickPivotAndPartition
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.PickPivotAndPartition
	|-ArraySortHelper<FocusController.FocusedElement>.PickPivotAndPartition
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.PickPivotAndPartition
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.PickPivotAndPartition
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.PickPivotAndPartition
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.PickPivotAndPartition
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.PickPivotAndPartition
	|-ArraySortHelper<SVGDocument.NodeWithParent>.PickPivotAndPartition
	|-ArraySortHelper<TargetStateListener.Callback>.PickPivotAndPartition
	|-ArraySortHelper<TextSettings.FontReferenceMap>.PickPivotAndPartition
	|-ArraySortHelper<TextureRegistry.TextureInfo>.PickPivotAndPartition
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.PickPivotAndPartition
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.PickPivotAndPartition
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.PickPivotAndPartition
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.PickPivotAndPartition
	|
	|-RVA: 0x100B630 Offset: 0x100A030 VA: 0x18100B630
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.PickPivotAndPartition
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.PickPivotAndPartition
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.PickPivotAndPartition
	|-ArraySortHelper<NativeArray<NudgeJobData>>.PickPivotAndPartition
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.PickPivotAndPartition
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.PickPivotAndPartition
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.PickPivotAndPartition
	|-ArraySortHelper<Nullable<DateTime>>.PickPivotAndPartition
	|-ArraySortHelper<AsyncGPUReadbackRequest>.PickPivotAndPartition
	|-ArraySortHelper<DateTimeOffset>.PickPivotAndPartition
	|-ArraySortHelper<Decimal>.PickPivotAndPartition
	|-ArraySortHelper<GlyphRect>.PickPivotAndPartition
	|-ArraySortHelper<Guid>.PickPivotAndPartition
	|-ArraySortHelper<IntPoint>.PickPivotAndPartition
	|-ArraySortHelper<IntRect>.PickPivotAndPartition
	|-ArraySortHelper<Playable>.PickPivotAndPartition
	|-ArraySortHelper<RectInt>.PickPivotAndPartition
	|-ArraySortHelper<Resolution>.PickPivotAndPartition
	|-ArraySortHelper<SamplePointUData>.PickPivotAndPartition
	|-ArraySortHelper<UILineInfo>.PickPivotAndPartition
	|-ArraySortHelper<ClipperLib.IntPoint>.PickPivotAndPartition
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.PickPivotAndPartition
	|-ArraySortHelper<ServerSocket.ConnectionChange>.PickPivotAndPartition
	|
	|-RVA: 0x100A790 Offset: 0x1009190 VA: 0x18100A790
	|-ArraySortHelper<SyncList.ChangeData<int>>.PickPivotAndPartition
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.PickPivotAndPartition
	|-ArraySortHelper<DuplicateSamplePoint>.PickPivotAndPartition
	|-ArraySortHelper<Int3>.PickPivotAndPartition
	|-ArraySortHelper<IntRegion>.PickPivotAndPartition
	|-ArraySortHelper<ManipulatorActivationFilter>.PickPivotAndPartition
	|-ArraySortHelper<UICharInfo>.PickPivotAndPartition
	|-ArraySortHelper<Vector3>.PickPivotAndPartition
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.PickPivotAndPartition
	|-ArraySortHelper<HIDParser.HIDReportData>.PickPivotAndPartition
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.PickPivotAndPartition
	|-ArraySortHelper<SyncTimer.ChangeData>.PickPivotAndPartition
	|
	|-RVA: 0x16A2680 Offset: 0x16A1080 VA: 0x1816A2680
	|-ArraySortHelper<IntervalTree.Entry<object>>.PickPivotAndPartition
	|-ArraySortHelper<KeyValuePair<Rect, object>>.PickPivotAndPartition
	|-ArraySortHelper<ComputedTransitionProperty>.PickPivotAndPartition
	|-ArraySortHelper<ContourVertex>.PickPivotAndPartition
	|
	|-RVA: 0x100EA30 Offset: 0x100D430 VA: 0x18100EA30
	|-ArraySortHelper<KeyValuePair<int, object>>.PickPivotAndPartition
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.PickPivotAndPartition
	|-ArraySortHelper<ValueTuple<int, object>>.PickPivotAndPartition
	|-ArraySortHelper<EventSummary>.PickPivotAndPartition
	|-ArraySortHelper<MultipleSubstitutionRecord>.PickPivotAndPartition
	|-ArraySortHelper<MultipleSubstitutionRecord>.PickPivotAndPartition
	|-ArraySortHelper<StylePropertyName>.PickPivotAndPartition
	|-ArraySortHelper<StyleValueManaged>.PickPivotAndPartition
	|-ArraySortHelper<X509ChainStatus>.PickPivotAndPartition
	|-ArraySortHelper<ZipGenericExtraField>.PickPivotAndPartition
	|-ArraySortHelper<AdvancedSmooth.Turn>.PickPivotAndPartition
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.PickPivotAndPartition
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.PickPivotAndPartition
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.PickPivotAndPartition
	|-ArraySortHelper<TransportManager.DisconnectingClient>.PickPivotAndPartition
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.PickPivotAndPartition
	|
	|-RVA: 0x16A2A80 Offset: 0x16A1480 VA: 0x1816A2A80
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.PickPivotAndPartition
	|-ArraySortHelper<RaycastResult>.PickPivotAndPartition
	|
	|-RVA: 0x100E120 Offset: 0x100CB20 VA: 0x18100E120
	|-ArraySortHelper<Nullable<Decimal>>.PickPivotAndPartition
	|-ArraySortHelper<TempAllocator.Page<ushort>>.PickPivotAndPartition
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.PickPivotAndPartition
	|-ArraySortHelper<BezierPathSegment>.PickPivotAndPartition
	|-ArraySortHelper<Bounds>.PickPivotAndPartition
	|-ArraySortHelper<FrameTimeSample>.PickPivotAndPartition
	|-ArraySortHelper<IntervalTreeNode>.PickPivotAndPartition
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.PickPivotAndPartition
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.PickPivotAndPartition
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.PickPivotAndPartition
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.PickPivotAndPartition
	|-ArraySortHelper<RendererList>.PickPivotAndPartition
	|-ArraySortHelper<StyleValue>.PickPivotAndPartition
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.PickPivotAndPartition
	|
	|-RVA: 0x100BA30 Offset: 0x100A430 VA: 0x18100BA30
	|-ArraySortHelper<ValueTuple<int, int>>.PickPivotAndPartition
	|-ArraySortHelper<ValueTuple<int, Scene>>.PickPivotAndPartition
	|-ArraySortHelper<AnimatorClipInfo>.PickPivotAndPartition
	|-ArraySortHelper<DateTime>.PickPivotAndPartition
	|-ArraySortHelper<InputEventPtr>.PickPivotAndPartition
	|-ArraySortHelper<RendererListHandle>.PickPivotAndPartition
	|-ArraySortHelper<ResourceHandle>.PickPivotAndPartition
	|-ArraySortHelper<SamplePointsPatch>.PickPivotAndPartition
	|-ArraySortHelper<TimeSpan>.PickPivotAndPartition
	|-ArraySortHelper<TimeValue>.PickPivotAndPartition
	|-ArraySortHelper<BitmapAllocator32.Page>.PickPivotAndPartition
	|-ArraySortHelper<CinemachineClearShot.Pair>.PickPivotAndPartition
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.PickPivotAndPartition
	|-ArraySortHelper<PlayingCard.CardData>.PickPivotAndPartition
	|-ArraySortHelper<SyncStopwatch.ChangeData>.PickPivotAndPartition
	|
	|-RVA: 0x100B230 Offset: 0x1009C30 VA: 0x18100B230
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.PickPivotAndPartition
	|-ArraySortHelper<CoordinateProceduralTilePair>.PickPivotAndPartition
	|-ArraySortHelper<NameAndParameters>.PickPivotAndPartition
	|-ArraySortHelper<NamedValue>.PickPivotAndPartition
	|-ArraySortHelper<SelectorMatchRecord>.PickPivotAndPartition
	|-ArraySortHelper<StyleSelectorPart>.PickPivotAndPartition
	|-ArraySortHelper<StyleVariable>.PickPivotAndPartition
	|-ArraySortHelper<XRFeatureDescriptor>.PickPivotAndPartition
	|-ArraySortHelper<AvatarSettings.LayerSetting>.PickPivotAndPartition
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.PickPivotAndPartition
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.PickPivotAndPartition
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.PickPivotAndPartition
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.PickPivotAndPartition
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.PickPivotAndPartition
	|
	|-RVA: 0x100E5B0 Offset: 0x100CFB0 VA: 0x18100E5B0
	|-ArraySortHelper<BezierSegment>.PickPivotAndPartition
	|-ArraySortHelper<NavMeshBuildMarkup>.PickPivotAndPartition
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.PickPivotAndPartition
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.PickPivotAndPartition
	|
	|-RVA: 0x17F5060 Offset: 0x17F3A60 VA: 0x1817F5060
	|-ArraySortHelper<bool>.PickPivotAndPartition
	|-ArraySortHelper<byte>.PickPivotAndPartition
	|-ArraySortHelper<sbyte>.PickPivotAndPartition
	|
	|-RVA: 0x17F5DB0 Offset: 0x17F47B0 VA: 0x1817F5DB0
	|-ArraySortHelper<CGSpot>.PickPivotAndPartition
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.PickPivotAndPartition
	|-ArraySortHelper<RaycastHit>.PickPivotAndPartition
	|
	|-RVA: 0x17F6250 Offset: 0x17F4C50 VA: 0x1817F6250
	|-ArraySortHelper<char>.PickPivotAndPartition
	|-ArraySortHelper<short>.PickPivotAndPartition
	|-ArraySortHelper<ushort>.PickPivotAndPartition
	|
	|-RVA: 0x17F4C60 Offset: 0x17F3660 VA: 0x1817F4C60
	|-ArraySortHelper<Color>.PickPivotAndPartition
	|-ArraySortHelper<Quaternion>.PickPivotAndPartition
	|-ArraySortHelper<Vector4>.PickPivotAndPartition
	|
	|-RVA: 0x10D66E0 Offset: 0x10D50E0 VA: 0x1810D66E0
	|-ArraySortHelper<Color32>.PickPivotAndPartition
	|-ArraySortHelper<EasingFunction>.PickPivotAndPartition
	|-ArraySortHelper<Scene>.PickPivotAndPartition
	|-ArraySortHelper<ShaderTagId>.PickPivotAndPartition
	|-ArraySortHelper<UShort2>.PickPivotAndPartition
	|-ArraySortHelper<RegexCharClass.SingleRange>.PickPivotAndPartition
	|
	|-RVA: 0x17F6780 Offset: 0x17F5180 VA: 0x1817F6780
	|-ArraySortHelper<CombineInstance>.PickPivotAndPartition
	|
	|-RVA: 0x100F270 Offset: 0x100DC70 VA: 0x18100F270
	|-ArraySortHelper<ControlPointOption>.PickPivotAndPartition
	|-ArraySortHelper<RaycastHit2D>.PickPivotAndPartition
	|-ArraySortHelper<Funnel.PathPart>.PickPivotAndPartition
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.PickPivotAndPartition
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.PickPivotAndPartition
	|
	|-RVA: 0x17F5580 Offset: 0x17F3F80 VA: 0x1817F5580
	|-ArraySortHelper<DisplayInfo>.PickPivotAndPartition
	|
	|-RVA: 0x17F59F0 Offset: 0x17F43F0 VA: 0x1817F59F0
	|-ArraySortHelper<double>.PickPivotAndPartition
	|
	|-RVA: 0x100D1C0 Offset: 0x100BBC0 VA: 0x18100D1C0
	|-ArraySortHelper<DoublePoint>.PickPivotAndPartition
	|-ArraySortHelper<DoublePoint>.PickPivotAndPartition
	|-ArraySortHelper<ClipperLib.DoublePoint>.PickPivotAndPartition
	|
	|-RVA: 0x1891330 Offset: 0x188FD30 VA: 0x181891330
	|-ArraySortHelper<InputBinding>.PickPivotAndPartition
	|
	|-RVA: 0x10D5E30 Offset: 0x10D4830 VA: 0x1810D5E30
	|-ArraySortHelper<InputDeviceDescription>.PickPivotAndPartition
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.PickPivotAndPartition
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.PickPivotAndPartition
	|-ArraySortHelper<TextureBlitter.BlitInfo>.PickPivotAndPartition
	|
	|-RVA: 0x1891C90 Offset: 0x1890690 VA: 0x181891C90
	|-ArraySortHelper<int>.PickPivotAndPartition
	|-ArraySortHelper<Int32Enum>.PickPivotAndPartition
	|-ArraySortHelper<uint>.PickPivotAndPartition
	|-ArraySortHelper<UInt32Enum>.PickPivotAndPartition
	|
	|-RVA: 0x1892190 Offset: 0x1890B90 VA: 0x181892190
	|-ArraySortHelper<long>.PickPivotAndPartition
	|-ArraySortHelper<ulong>.PickPivotAndPartition
	|
	|-RVA: 0x1891820 Offset: 0x1890220 VA: 0x181891820
	|-ArraySortHelper<IntPoint>.PickPivotAndPartition
	|
	|-RVA: 0x10D5A30 Offset: 0x10D4430 VA: 0x1810D5A30
	|-ArraySortHelper<JsonPosition>.PickPivotAndPartition
	|-ArraySortHelper<StyleSyntaxToken>.PickPivotAndPartition
	|-ArraySortHelper<TreeViewItemWrapper>.PickPivotAndPartition
	|-ArraySortHelper<LatencySimulator.Message>.PickPivotAndPartition
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.PickPivotAndPartition
	|-ArraySortHelper<StructySync.ChangeData>.PickPivotAndPartition
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.PickPivotAndPartition
	|
	|-RVA: 0x10099C0 Offset: 0x10083C0 VA: 0x1810099C0
	|-ArraySortHelper<Label>.PickPivotAndPartition
	|-ArraySortHelper<PlayerLoopSystem>.PickPivotAndPartition
	|-ArraySortHelper<PlayerLoopSystemInternal>.PickPivotAndPartition
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.PickPivotAndPartition
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.PickPivotAndPartition
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.PickPivotAndPartition
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.PickPivotAndPartition
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.PickPivotAndPartition
	|
	|-RVA: 0x1917C80 Offset: 0x1916680 VA: 0x181917C80
	|-ArraySortHelper<Matrix4x4>.PickPivotAndPartition
	|
	|-RVA: 0x1917780 Offset: 0x1916180 VA: 0x181917780
	|-ArraySortHelper<NavMeshBuildSource>.PickPivotAndPartition
	|
	|-RVA: 0x1918140 Offset: 0x1916B40 VA: 0x181918140
	|-ArraySortHelper<object>.PickPivotAndPartition
	|
	|-RVA: 0x10D51A0 Offset: 0x10D3BA0 VA: 0x1810D51A0
	|-ArraySortHelper<PlayableBinding>.PickPivotAndPartition
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.PickPivotAndPartition
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.PickPivotAndPartition
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.PickPivotAndPartition
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.PickPivotAndPartition
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.PickPivotAndPartition
	|
	|-RVA: 0x100C650 Offset: 0x100B050 VA: 0x18100C650
	|-ArraySortHelper<RenderTargetIdentifier>.PickPivotAndPartition
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.PickPivotAndPartition
	|
	|-RVA: 0x19A57B0 Offset: 0x19A41B0 VA: 0x1819A57B0
	|-ArraySortHelper<float>.PickPivotAndPartition
	|
	|-RVA: 0x19A5200 Offset: 0x19A3C00 VA: 0x1819A5200
	|-ArraySortHelper<UIVertex>.PickPivotAndPartition
	|
	|-RVA: 0x10D6300 Offset: 0x10D4D00 VA: 0x1810D6300
	|-ArraySortHelper<UsageHint>.PickPivotAndPartition
	|-ArraySortHelper<SVGDocument.PostponedClip>.PickPivotAndPartition
	|-ArraySortHelper<SVGDocument.PostponedStopData>.PickPivotAndPartition
	|
	|-RVA: 0x19A5B70 Offset: 0x19A4570 VA: 0x1819A5B70
	|-ArraySortHelper<Vector2>.PickPivotAndPartition
	|
	|-RVA: 0x117A620 Offset: 0x1179020 VA: 0x18117A620
	|-ArraySortHelper<VoxelContour>.PickPivotAndPartition
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.PickPivotAndPartition
	|
	|-RVA: 0x100AC00 Offset: 0x1009600 VA: 0x18100AC00
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.PickPivotAndPartition
	|
	|-RVA: 0x100CB80 Offset: 0x100B580 VA: 0x18100CB80
	|-ArraySortHelper<XRView>.PickPivotAndPartition
	|
	|-RVA: 0x100BF70 Offset: 0x100A970 VA: 0x18100BF70
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.PickPivotAndPartition
	|
	|-RVA: 0x100DC30 Offset: 0x100C630 VA: 0x18100DC30
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.PickPivotAndPartition
	|-ArraySortHelper<ShadowUtility.Edge>.PickPivotAndPartition
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.PickPivotAndPartition
	|
	|-RVA: 0x100D640 Offset: 0x100C040 VA: 0x18100D640
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.PickPivotAndPartition
	|
	|-RVA: 0x100EDC0 Offset: 0x100D7C0 VA: 0x18100EDC0
	|-ArraySortHelper<HID.HIDElementDescriptor>.PickPivotAndPartition
	|
	|-RVA: 0x1009E30 Offset: 0x1008830 VA: 0x181009E30
	|-ArraySortHelper<InputControlLayout.ControlItem>.PickPivotAndPartition
	|
	|-RVA: 0x10D5580 Offset: 0x10D3F80 VA: 0x1810D5580
	|-ArraySortHelper<JsonParser.JsonValue>.PickPivotAndPartition
	|
	|-RVA: 0x10D74E0 Offset: 0x10D5EE0 VA: 0x1810D74E0
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.PickPivotAndPartition
	|
	|-RVA: 0x10D7080 Offset: 0x10D5A80 VA: 0x1810D7080
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.PickPivotAndPartition
	|
	|-RVA: 0x10D78D0 Offset: 0x10D62D0 VA: 0x1810D78D0
	|-ArraySortHelper<RenderChain.RenderNodeData>.PickPivotAndPartition
	|
	|-RVA: 0x10D6C10 Offset: 0x10D5610 VA: 0x1810D6C10
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.PickPivotAndPartition
	|
	|-RVA: 0x117A160 Offset: 0x1178B60 VA: 0x18117A160
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.PickPivotAndPartition
	|
	|-RVA: 0x1179820 Offset: 0x1178220 VA: 0x181179820
	|-ArraySortHelper<UIRStylePainter.Entry>.PickPivotAndPartition
	|
	|-RVA: 0x11793B0 Offset: 0x1177DB0 VA: 0x1811793B0
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.PickPivotAndPartition
	|
	|-RVA: 0x1179CC0 Offset: 0x11786C0 VA: 0x181179CC0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.PickPivotAndPartition
	|
	|-RVA: 0x1178FD0 Offset: 0x11779D0 VA: 0x181178FD0
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDB90 Offset: 0xFFC590 VA: 0x180FFDB90
	|-ArraySortHelper<ArraySegment<byte>>.Heapsort
	|-ArraySortHelper<KeyValuePair<object, bool>>.Heapsort
	|-ArraySortHelper<KeyValuePair<object, char>>.Heapsort
	|-ArraySortHelper<KeyValuePair<object, object>>.Heapsort
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.Heapsort
	|-ArraySortHelper<StructMultiKey<object, object>>.Heapsort
	|-ArraySortHelper<SubArray<int>>.Heapsort
	|-ArraySortHelper<ValueTuple<object, object>>.Heapsort
	|-ArraySortHelper<BezierContour>.Heapsort
	|-ArraySortHelper<Connection>.Heapsort
	|-ArraySortHelper<CoordinateFootprintTilePair>.Heapsort
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.Heapsort
	|-ArraySortHelper<CoordinateStorageTilePair>.Heapsort
	|-ArraySortHelper<CoordinateTilePair>.Heapsort
	|-ArraySortHelper<DualPrefab>.Heapsort
	|-ArraySortHelper<Entry>.Heapsort
	|-ArraySortHelper<InternedString>.Heapsort
	|-ArraySortHelper<InterpretedFrameInfo>.Heapsort
	|-ArraySortHelper<LigatureSubstitutionRecord>.Heapsort
	|-ArraySortHelper<LigatureSubstitutionRecord>.Heapsort
	|-ArraySortHelper<RangePositionInfo>.Heapsort
	|-ArraySortHelper<RuleMatcher>.Heapsort
	|-ArraySortHelper<StylePropertyValue>.Heapsort
	|-ArraySortHelper<Substring>.Heapsort
	|-ArraySortHelper<UnloadedScene>.Heapsort
	|-ArraySortHelper<CameraState.CustomBlendable>.Heapsort
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.Heapsort
	|-ArraySortHelper<FocusController.FocusedElement>.Heapsort
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.Heapsort
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.Heapsort
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.Heapsort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.Heapsort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.Heapsort
	|-ArraySortHelper<SVGDocument.NodeWithParent>.Heapsort
	|-ArraySortHelper<TargetStateListener.Callback>.Heapsort
	|-ArraySortHelper<TextSettings.FontReferenceMap>.Heapsort
	|-ArraySortHelper<TextureRegistry.TextureInfo>.Heapsort
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.Heapsort
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.Heapsort
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Heapsort
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.Heapsort
	|
	|-RVA: 0xFFE860 Offset: 0xFFD260 VA: 0x180FFE860
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.Heapsort
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.Heapsort
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.Heapsort
	|-ArraySortHelper<NativeArray<NudgeJobData>>.Heapsort
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.Heapsort
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.Heapsort
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.Heapsort
	|-ArraySortHelper<Nullable<DateTime>>.Heapsort
	|-ArraySortHelper<AsyncGPUReadbackRequest>.Heapsort
	|-ArraySortHelper<DateTimeOffset>.Heapsort
	|-ArraySortHelper<Decimal>.Heapsort
	|-ArraySortHelper<GlyphRect>.Heapsort
	|-ArraySortHelper<Guid>.Heapsort
	|-ArraySortHelper<IntPoint>.Heapsort
	|-ArraySortHelper<IntRect>.Heapsort
	|-ArraySortHelper<Playable>.Heapsort
	|-ArraySortHelper<RectInt>.Heapsort
	|-ArraySortHelper<Resolution>.Heapsort
	|-ArraySortHelper<SamplePointUData>.Heapsort
	|-ArraySortHelper<UILineInfo>.Heapsort
	|-ArraySortHelper<ClipperLib.IntPoint>.Heapsort
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.Heapsort
	|-ArraySortHelper<ServerSocket.ConnectionChange>.Heapsort
	|
	|-RVA: 0xFFD960 Offset: 0xFFC360 VA: 0x180FFD960
	|-ArraySortHelper<SyncList.ChangeData<int>>.Heapsort
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.Heapsort
	|-ArraySortHelper<DuplicateSamplePoint>.Heapsort
	|-ArraySortHelper<Int3>.Heapsort
	|-ArraySortHelper<IntRegion>.Heapsort
	|-ArraySortHelper<ManipulatorActivationFilter>.Heapsort
	|-ArraySortHelper<UICharInfo>.Heapsort
	|-ArraySortHelper<Vector3>.Heapsort
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.Heapsort
	|-ArraySortHelper<HIDParser.HIDReportData>.Heapsort
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.Heapsort
	|-ArraySortHelper<SyncTimer.ChangeData>.Heapsort
	|
	|-RVA: 0x16A1330 Offset: 0x169FD30 VA: 0x1816A1330
	|-ArraySortHelper<IntervalTree.Entry<object>>.Heapsort
	|-ArraySortHelper<KeyValuePair<Rect, object>>.Heapsort
	|-ArraySortHelper<ComputedTransitionProperty>.Heapsort
	|-ArraySortHelper<ContourVertex>.Heapsort
	|
	|-RVA: 0xFFC590 Offset: 0xFFAF90 VA: 0x180FFC590
	|-ArraySortHelper<KeyValuePair<int, object>>.Heapsort
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.Heapsort
	|-ArraySortHelper<ValueTuple<int, object>>.Heapsort
	|-ArraySortHelper<EventSummary>.Heapsort
	|-ArraySortHelper<MultipleSubstitutionRecord>.Heapsort
	|-ArraySortHelper<MultipleSubstitutionRecord>.Heapsort
	|-ArraySortHelper<StylePropertyName>.Heapsort
	|-ArraySortHelper<StyleValueManaged>.Heapsort
	|-ArraySortHelper<X509ChainStatus>.Heapsort
	|-ArraySortHelper<ZipGenericExtraField>.Heapsort
	|-ArraySortHelper<AdvancedSmooth.Turn>.Heapsort
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.Heapsort
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.Heapsort
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.Heapsort
	|-ArraySortHelper<TransportManager.DisconnectingClient>.Heapsort
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.Heapsort
	|
	|-RVA: 0x16A15B0 Offset: 0x169FFB0 VA: 0x1816A15B0
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.Heapsort
	|-ArraySortHelper<RaycastResult>.Heapsort
	|
	|-RVA: 0xFFED00 Offset: 0xFFD700 VA: 0x180FFED00
	|-ArraySortHelper<Nullable<Decimal>>.Heapsort
	|-ArraySortHelper<TempAllocator.Page<ushort>>.Heapsort
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.Heapsort
	|-ArraySortHelper<BezierPathSegment>.Heapsort
	|-ArraySortHelper<Bounds>.Heapsort
	|-ArraySortHelper<FrameTimeSample>.Heapsort
	|-ArraySortHelper<IntervalTreeNode>.Heapsort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Heapsort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.Heapsort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Heapsort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.Heapsort
	|-ArraySortHelper<RendererList>.Heapsort
	|-ArraySortHelper<StyleValue>.Heapsort
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.Heapsort
	|
	|-RVA: 0xFFCA60 Offset: 0xFFB460 VA: 0x180FFCA60
	|-ArraySortHelper<ValueTuple<int, int>>.Heapsort
	|-ArraySortHelper<ValueTuple<int, Scene>>.Heapsort
	|-ArraySortHelper<AnimatorClipInfo>.Heapsort
	|-ArraySortHelper<DateTime>.Heapsort
	|-ArraySortHelper<InputEventPtr>.Heapsort
	|-ArraySortHelper<RendererListHandle>.Heapsort
	|-ArraySortHelper<ResourceHandle>.Heapsort
	|-ArraySortHelper<SamplePointsPatch>.Heapsort
	|-ArraySortHelper<TimeSpan>.Heapsort
	|-ArraySortHelper<TimeValue>.Heapsort
	|-ArraySortHelper<BitmapAllocator32.Page>.Heapsort
	|-ArraySortHelper<CinemachineClearShot.Pair>.Heapsort
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.Heapsort
	|-ArraySortHelper<PlayingCard.CardData>.Heapsort
	|-ArraySortHelper<SyncStopwatch.ChangeData>.Heapsort
	|
	|-RVA: 0xFFEA80 Offset: 0xFFD480 VA: 0x180FFEA80
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.Heapsort
	|-ArraySortHelper<CoordinateProceduralTilePair>.Heapsort
	|-ArraySortHelper<NameAndParameters>.Heapsort
	|-ArraySortHelper<NamedValue>.Heapsort
	|-ArraySortHelper<SelectorMatchRecord>.Heapsort
	|-ArraySortHelper<StyleSelectorPart>.Heapsort
	|-ArraySortHelper<StyleVariable>.Heapsort
	|-ArraySortHelper<XRFeatureDescriptor>.Heapsort
	|-ArraySortHelper<AvatarSettings.LayerSetting>.Heapsort
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.Heapsort
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.Heapsort
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.Heapsort
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.Heapsort
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.Heapsort
	|
	|-RVA: 0xFFDDF0 Offset: 0xFFC7F0 VA: 0x180FFDDF0
	|-ArraySortHelper<BezierSegment>.Heapsort
	|-ArraySortHelper<NavMeshBuildMarkup>.Heapsort
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.Heapsort
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.Heapsort
	|
	|-RVA: 0x17F0570 Offset: 0x17EEF70 VA: 0x1817F0570
	|-ArraySortHelper<bool>.Heapsort
	|-ArraySortHelper<byte>.Heapsort
	|-ArraySortHelper<sbyte>.Heapsort
	|
	|-RVA: 0x17F1120 Offset: 0x17EFB20 VA: 0x1817F1120
	|-ArraySortHelper<CGSpot>.Heapsort
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.Heapsort
	|-ArraySortHelper<RaycastHit>.Heapsort
	|
	|-RVA: 0x17F0C60 Offset: 0x17EF660 VA: 0x1817F0C60
	|-ArraySortHelper<char>.Heapsort
	|-ArraySortHelper<short>.Heapsort
	|-ArraySortHelper<ushort>.Heapsort
	|
	|-RVA: 0x17F0A40 Offset: 0x17EF440 VA: 0x1817F0A40
	|-ArraySortHelper<Color>.Heapsort
	|-ArraySortHelper<Quaternion>.Heapsort
	|-ArraySortHelper<Vector4>.Heapsort
	|
	|-RVA: 0x10CFF10 Offset: 0x10CE910 VA: 0x1810CFF10
	|-ArraySortHelper<Color32>.Heapsort
	|-ArraySortHelper<EasingFunction>.Heapsort
	|-ArraySortHelper<Scene>.Heapsort
	|-ArraySortHelper<ShaderTagId>.Heapsort
	|-ArraySortHelper<UShort2>.Heapsort
	|-ArraySortHelper<RegexCharClass.SingleRange>.Heapsort
	|
	|-RVA: 0x17F0E60 Offset: 0x17EF860 VA: 0x1817F0E60
	|-ArraySortHelper<CombineInstance>.Heapsort
	|
	|-RVA: 0xFFD390 Offset: 0xFFBD90 VA: 0x180FFD390
	|-ArraySortHelper<ControlPointOption>.Heapsort
	|-ArraySortHelper<RaycastHit2D>.Heapsort
	|-ArraySortHelper<Funnel.PathPart>.Heapsort
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.Heapsort
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.Heapsort
	|
	|-RVA: 0x17F0780 Offset: 0x17EF180 VA: 0x1817F0780
	|-ArraySortHelper<DisplayInfo>.Heapsort
	|
	|-RVA: 0x17F1370 Offset: 0x17EFD70 VA: 0x1817F1370
	|-ArraySortHelper<double>.Heapsort
	|
	|-RVA: 0xFFE010 Offset: 0xFFCA10 VA: 0x180FFE010
	|-ArraySortHelper<DoublePoint>.Heapsort
	|-ArraySortHelper<DoublePoint>.Heapsort
	|-ArraySortHelper<ClipperLib.DoublePoint>.Heapsort
	|
	|-RVA: 0x188ECB0 Offset: 0x188D6B0 VA: 0x18188ECB0
	|-ArraySortHelper<InputBinding>.Heapsort
	|
	|-RVA: 0x10CEF80 Offset: 0x10CD980 VA: 0x1810CEF80
	|-ArraySortHelper<InputDeviceDescription>.Heapsort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.Heapsort
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.Heapsort
	|-ArraySortHelper<TextureBlitter.BlitInfo>.Heapsort
	|
	|-RVA: 0x188EAB0 Offset: 0x188D4B0 VA: 0x18188EAB0
	|-ArraySortHelper<int>.Heapsort
	|-ArraySortHelper<Int32Enum>.Heapsort
	|-ArraySortHelper<uint>.Heapsort
	|-ArraySortHelper<UInt32Enum>.Heapsort
	|
	|-RVA: 0x188EFA0 Offset: 0x188D9A0 VA: 0x18188EFA0
	|-ArraySortHelper<long>.Heapsort
	|-ArraySortHelper<ulong>.Heapsort
	|
	|-RVA: 0x188F1A0 Offset: 0x188DBA0 VA: 0x18188F1A0
	|-ArraySortHelper<IntPoint>.Heapsort
	|
	|-RVA: 0x10CF440 Offset: 0x10CDE40 VA: 0x1810CF440
	|-ArraySortHelper<JsonPosition>.Heapsort
	|-ArraySortHelper<StyleSyntaxToken>.Heapsort
	|-ArraySortHelper<TreeViewItemWrapper>.Heapsort
	|-ArraySortHelper<LatencySimulator.Message>.Heapsort
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.Heapsort
	|-ArraySortHelper<StructySync.ChangeData>.Heapsort
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.Heapsort
	|
	|-RVA: 0xFFD0E0 Offset: 0xFFBAE0 VA: 0x180FFD0E0
	|-ArraySortHelper<Label>.Heapsort
	|-ArraySortHelper<PlayerLoopSystem>.Heapsort
	|-ArraySortHelper<PlayerLoopSystemInternal>.Heapsort
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.Heapsort
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.Heapsort
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.Heapsort
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.Heapsort
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Heapsort
	|
	|-RVA: 0x1915DD0 Offset: 0x19147D0 VA: 0x181915DD0
	|-ArraySortHelper<Matrix4x4>.Heapsort
	|
	|-RVA: 0x1916020 Offset: 0x1914A20 VA: 0x181916020
	|-ArraySortHelper<NavMeshBuildSource>.Heapsort
	|
	|-RVA: 0x1915BB0 Offset: 0x19145B0 VA: 0x181915BB0
	|-ArraySortHelper<object>.Heapsort
	|
	|-RVA: 0x10CF6D0 Offset: 0x10CE0D0 VA: 0x1810CF6D0
	|-ArraySortHelper<PlayableBinding>.Heapsort
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Heapsort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.Heapsort
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.Heapsort
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.Heapsort
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.Heapsort
	|
	|-RVA: 0xFFCC60 Offset: 0xFFB660 VA: 0x180FFCC60
	|-ArraySortHelper<RenderTargetIdentifier>.Heapsort
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.Heapsort
	|
	|-RVA: 0x19A3530 Offset: 0x19A1F30 VA: 0x1819A3530
	|-ArraySortHelper<float>.Heapsort
	|
	|-RVA: 0x19A3260 Offset: 0x19A1C60 VA: 0x1819A3260
	|-ArraySortHelper<UIVertex>.Heapsort
	|
	|-RVA: 0x10CEB30 Offset: 0x10CD530 VA: 0x1810CEB30
	|-ArraySortHelper<UsageHint>.Heapsort
	|-ArraySortHelper<SVGDocument.PostponedClip>.Heapsort
	|-ArraySortHelper<SVGDocument.PostponedStopData>.Heapsort
	|
	|-RVA: 0x19A3040 Offset: 0x19A1A40 VA: 0x1819A3040
	|-ArraySortHelper<Vector2>.Heapsort
	|
	|-RVA: 0x11751D0 Offset: 0x1173BD0 VA: 0x1811751D0
	|-ArraySortHelper<VoxelContour>.Heapsort
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.Heapsort
	|
	|-RVA: 0xFFD5D0 Offset: 0xFFBFD0 VA: 0x180FFD5D0
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.Heapsort
	|
	|-RVA: 0xFFF170 Offset: 0xFFDB70 VA: 0x180FFF170
	|-ArraySortHelper<XRView>.Heapsort
	|
	|-RVA: 0xFFCEA0 Offset: 0xFFB8A0 VA: 0x180FFCEA0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.Heapsort
	|
	|-RVA: 0xFFEF30 Offset: 0xFFD930 VA: 0x180FFEF30
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Heapsort
	|-ArraySortHelper<ShadowUtility.Edge>.Heapsort
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.Heapsort
	|
	|-RVA: 0xFFE570 Offset: 0xFFCF70 VA: 0x180FFE570
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.Heapsort
	|
	|-RVA: 0xFFC7F0 Offset: 0xFFB1F0 VA: 0x180FFC7F0
	|-ArraySortHelper<HID.HIDElementDescriptor>.Heapsort
	|
	|-RVA: 0xFFE240 Offset: 0xFFCC40 VA: 0x180FFE240
	|-ArraySortHelper<InputControlLayout.ControlItem>.Heapsort
	|
	|-RVA: 0x10D0110 Offset: 0x10CEB10 VA: 0x1810D0110
	|-ArraySortHelper<JsonParser.JsonValue>.Heapsort
	|
	|-RVA: 0x10CF240 Offset: 0x10CDC40 VA: 0x1810CF240
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.Heapsort
	|
	|-RVA: 0x10CED60 Offset: 0x10CD760 VA: 0x1810CED60
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.Heapsort
	|
	|-RVA: 0x10CFC10 Offset: 0x10CE610 VA: 0x1810CFC10
	|-ArraySortHelper<RenderChain.RenderNodeData>.Heapsort
	|
	|-RVA: 0x10CF950 Offset: 0x10CE350 VA: 0x1810CF950
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.Heapsort
	|
	|-RVA: 0x1175CB0 Offset: 0x11746B0 VA: 0x181175CB0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.Heapsort
	|
	|-RVA: 0x11756F0 Offset: 0x11740F0 VA: 0x1811756F0
	|-ArraySortHelper<UIRStylePainter.Entry>.Heapsort
	|
	|-RVA: 0x1175450 Offset: 0x1173E50 VA: 0x181175450
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.Heapsort
	|
	|-RVA: 0x11759D0 Offset: 0x11743D0 VA: 0x1811759D0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.Heapsort
	|
	|-RVA: 0x1175F70 Offset: 0x1174970 VA: 0x181175F70
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF9640 Offset: 0xFF8040 VA: 0x180FF9640
	|-ArraySortHelper<ArraySegment<byte>>.DownHeap
	|-ArraySortHelper<KeyValuePair<object, bool>>.DownHeap
	|-ArraySortHelper<KeyValuePair<object, char>>.DownHeap
	|-ArraySortHelper<KeyValuePair<object, object>>.DownHeap
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.DownHeap
	|-ArraySortHelper<StructMultiKey<object, object>>.DownHeap
	|-ArraySortHelper<SubArray<int>>.DownHeap
	|-ArraySortHelper<ValueTuple<object, object>>.DownHeap
	|-ArraySortHelper<BezierContour>.DownHeap
	|-ArraySortHelper<Connection>.DownHeap
	|-ArraySortHelper<CoordinateFootprintTilePair>.DownHeap
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.DownHeap
	|-ArraySortHelper<CoordinateStorageTilePair>.DownHeap
	|-ArraySortHelper<CoordinateTilePair>.DownHeap
	|-ArraySortHelper<DualPrefab>.DownHeap
	|-ArraySortHelper<Entry>.DownHeap
	|-ArraySortHelper<InternedString>.DownHeap
	|-ArraySortHelper<InterpretedFrameInfo>.DownHeap
	|-ArraySortHelper<LigatureSubstitutionRecord>.DownHeap
	|-ArraySortHelper<LigatureSubstitutionRecord>.DownHeap
	|-ArraySortHelper<RangePositionInfo>.DownHeap
	|-ArraySortHelper<RuleMatcher>.DownHeap
	|-ArraySortHelper<StylePropertyValue>.DownHeap
	|-ArraySortHelper<Substring>.DownHeap
	|-ArraySortHelper<UnloadedScene>.DownHeap
	|-ArraySortHelper<CameraState.CustomBlendable>.DownHeap
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.DownHeap
	|-ArraySortHelper<FocusController.FocusedElement>.DownHeap
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.DownHeap
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.DownHeap
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.DownHeap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.DownHeap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.DownHeap
	|-ArraySortHelper<SVGDocument.NodeWithParent>.DownHeap
	|-ArraySortHelper<TargetStateListener.Callback>.DownHeap
	|-ArraySortHelper<TextSettings.FontReferenceMap>.DownHeap
	|-ArraySortHelper<TextureRegistry.TextureInfo>.DownHeap
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.DownHeap
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.DownHeap
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.DownHeap
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.DownHeap
	|
	|-RVA: 0xFFA690 Offset: 0xFF9090 VA: 0x180FFA690
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.DownHeap
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.DownHeap
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.DownHeap
	|-ArraySortHelper<NativeArray<NudgeJobData>>.DownHeap
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.DownHeap
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.DownHeap
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.DownHeap
	|-ArraySortHelper<Nullable<DateTime>>.DownHeap
	|-ArraySortHelper<AsyncGPUReadbackRequest>.DownHeap
	|-ArraySortHelper<DateTimeOffset>.DownHeap
	|-ArraySortHelper<Decimal>.DownHeap
	|-ArraySortHelper<GlyphRect>.DownHeap
	|-ArraySortHelper<Guid>.DownHeap
	|-ArraySortHelper<IntPoint>.DownHeap
	|-ArraySortHelper<IntRect>.DownHeap
	|-ArraySortHelper<Playable>.DownHeap
	|-ArraySortHelper<RectInt>.DownHeap
	|-ArraySortHelper<Resolution>.DownHeap
	|-ArraySortHelper<SamplePointUData>.DownHeap
	|-ArraySortHelper<UILineInfo>.DownHeap
	|-ArraySortHelper<ClipperLib.IntPoint>.DownHeap
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.DownHeap
	|-ArraySortHelper<ServerSocket.ConnectionChange>.DownHeap
	|
	|-RVA: 0xFF9BB0 Offset: 0xFF85B0 VA: 0x180FF9BB0
	|-ArraySortHelper<SyncList.ChangeData<int>>.DownHeap
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.DownHeap
	|-ArraySortHelper<DuplicateSamplePoint>.DownHeap
	|-ArraySortHelper<Int3>.DownHeap
	|-ArraySortHelper<IntRegion>.DownHeap
	|-ArraySortHelper<ManipulatorActivationFilter>.DownHeap
	|-ArraySortHelper<UICharInfo>.DownHeap
	|-ArraySortHelper<Vector3>.DownHeap
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.DownHeap
	|-ArraySortHelper<HIDParser.HIDReportData>.DownHeap
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.DownHeap
	|-ArraySortHelper<SyncTimer.ChangeData>.DownHeap
	|
	|-RVA: 0x16A0C50 Offset: 0x169F650 VA: 0x1816A0C50
	|-ArraySortHelper<IntervalTree.Entry<object>>.DownHeap
	|-ArraySortHelper<KeyValuePair<Rect, object>>.DownHeap
	|-ArraySortHelper<ComputedTransitionProperty>.DownHeap
	|-ArraySortHelper<ContourVertex>.DownHeap
	|
	|-RVA: 0xFF93E0 Offset: 0xFF7DE0 VA: 0x180FF93E0
	|-ArraySortHelper<KeyValuePair<int, object>>.DownHeap
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.DownHeap
	|-ArraySortHelper<ValueTuple<int, object>>.DownHeap
	|-ArraySortHelper<EventSummary>.DownHeap
	|-ArraySortHelper<MultipleSubstitutionRecord>.DownHeap
	|-ArraySortHelper<MultipleSubstitutionRecord>.DownHeap
	|-ArraySortHelper<StylePropertyName>.DownHeap
	|-ArraySortHelper<StyleValueManaged>.DownHeap
	|-ArraySortHelper<X509ChainStatus>.DownHeap
	|-ArraySortHelper<ZipGenericExtraField>.DownHeap
	|-ArraySortHelper<AdvancedSmooth.Turn>.DownHeap
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.DownHeap
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.DownHeap
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.DownHeap
	|-ArraySortHelper<TransportManager.DisconnectingClient>.DownHeap
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.DownHeap
	|
	|-RVA: 0x16A0F30 Offset: 0x169F930 VA: 0x1816A0F30
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.DownHeap
	|-ArraySortHelper<RaycastResult>.DownHeap
	|
	|-RVA: 0xFF8370 Offset: 0xFF6D70 VA: 0x180FF8370
	|-ArraySortHelper<Nullable<Decimal>>.DownHeap
	|-ArraySortHelper<TempAllocator.Page<ushort>>.DownHeap
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.DownHeap
	|-ArraySortHelper<BezierPathSegment>.DownHeap
	|-ArraySortHelper<Bounds>.DownHeap
	|-ArraySortHelper<FrameTimeSample>.DownHeap
	|-ArraySortHelper<IntervalTreeNode>.DownHeap
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.DownHeap
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.DownHeap
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.DownHeap
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.DownHeap
	|-ArraySortHelper<RendererList>.DownHeap
	|-ArraySortHelper<StyleValue>.DownHeap
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.DownHeap
	|
	|-RVA: 0xFF8630 Offset: 0xFF7030 VA: 0x180FF8630
	|-ArraySortHelper<ValueTuple<int, int>>.DownHeap
	|-ArraySortHelper<ValueTuple<int, Scene>>.DownHeap
	|-ArraySortHelper<AnimatorClipInfo>.DownHeap
	|-ArraySortHelper<DateTime>.DownHeap
	|-ArraySortHelper<InputEventPtr>.DownHeap
	|-ArraySortHelper<RendererListHandle>.DownHeap
	|-ArraySortHelper<ResourceHandle>.DownHeap
	|-ArraySortHelper<SamplePointsPatch>.DownHeap
	|-ArraySortHelper<TimeSpan>.DownHeap
	|-ArraySortHelper<TimeValue>.DownHeap
	|-ArraySortHelper<BitmapAllocator32.Page>.DownHeap
	|-ArraySortHelper<CinemachineClearShot.Pair>.DownHeap
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.DownHeap
	|-ArraySortHelper<PlayingCard.CardData>.DownHeap
	|-ArraySortHelper<SyncStopwatch.ChangeData>.DownHeap
	|
	|-RVA: 0xFFBD00 Offset: 0xFFA700 VA: 0x180FFBD00
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.DownHeap
	|-ArraySortHelper<CoordinateProceduralTilePair>.DownHeap
	|-ArraySortHelper<NameAndParameters>.DownHeap
	|-ArraySortHelper<NamedValue>.DownHeap
	|-ArraySortHelper<SelectorMatchRecord>.DownHeap
	|-ArraySortHelper<StyleSelectorPart>.DownHeap
	|-ArraySortHelper<StyleVariable>.DownHeap
	|-ArraySortHelper<XRFeatureDescriptor>.DownHeap
	|-ArraySortHelper<AvatarSettings.LayerSetting>.DownHeap
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.DownHeap
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.DownHeap
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.DownHeap
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.DownHeap
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.DownHeap
	|
	|-RVA: 0xFFA8C0 Offset: 0xFF92C0 VA: 0x180FFA8C0
	|-ArraySortHelper<BezierSegment>.DownHeap
	|-ArraySortHelper<NavMeshBuildMarkup>.DownHeap
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.DownHeap
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.DownHeap
	|
	|-RVA: 0x17EFA80 Offset: 0x17EE480 VA: 0x1817EFA80
	|-ArraySortHelper<bool>.DownHeap
	|-ArraySortHelper<byte>.DownHeap
	|-ArraySortHelper<sbyte>.DownHeap
	|
	|-RVA: 0x17F01B0 Offset: 0x17EEBB0 VA: 0x1817F01B0
	|-ArraySortHelper<CGSpot>.DownHeap
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.DownHeap
	|-ArraySortHelper<RaycastHit>.DownHeap
	|
	|-RVA: 0x17EF320 Offset: 0x17EDD20 VA: 0x1817EF320
	|-ArraySortHelper<char>.DownHeap
	|-ArraySortHelper<short>.DownHeap
	|-ArraySortHelper<ushort>.DownHeap
	|
	|-RVA: 0x17EF0E0 Offset: 0x17EDAE0 VA: 0x1817EF0E0
	|-ArraySortHelper<Color>.DownHeap
	|-ArraySortHelper<Quaternion>.DownHeap
	|-ArraySortHelper<Vector4>.DownHeap
	|
	|-RVA: 0x10CE760 Offset: 0x10CD160 VA: 0x1810CE760
	|-ArraySortHelper<Color32>.DownHeap
	|-ArraySortHelper<EasingFunction>.DownHeap
	|-ArraySortHelper<Scene>.DownHeap
	|-ArraySortHelper<ShaderTagId>.DownHeap
	|-ArraySortHelper<UShort2>.DownHeap
	|-ArraySortHelper<RegexCharClass.SingleRange>.DownHeap
	|
	|-RVA: 0x17EFC70 Offset: 0x17EE670 VA: 0x1817EFC70
	|-ArraySortHelper<CombineInstance>.DownHeap
	|
	|-RVA: 0xFF8820 Offset: 0xFF7220 VA: 0x180FF8820
	|-ArraySortHelper<ControlPointOption>.DownHeap
	|-ArraySortHelper<RaycastHit2D>.DownHeap
	|-ArraySortHelper<Funnel.PathPart>.DownHeap
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.DownHeap
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.DownHeap
	|
	|-RVA: 0x17EF700 Offset: 0x17EE100 VA: 0x1817EF700
	|-ArraySortHelper<DisplayInfo>.DownHeap
	|
	|-RVA: 0x17EF510 Offset: 0x17EDF10 VA: 0x1817EF510
	|-ArraySortHelper<double>.DownHeap
	|
	|-RVA: 0xFF8B40 Offset: 0xFF7540 VA: 0x180FF8B40
	|-ArraySortHelper<DoublePoint>.DownHeap
	|-ArraySortHelper<DoublePoint>.DownHeap
	|-ArraySortHelper<ClipperLib.DoublePoint>.DownHeap
	|
	|-RVA: 0x188E5F0 Offset: 0x188CFF0 VA: 0x18188E5F0
	|-ArraySortHelper<InputBinding>.DownHeap
	|
	|-RVA: 0x10CD090 Offset: 0x10CBA90 VA: 0x1810CD090
	|-ArraySortHelper<InputDeviceDescription>.DownHeap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.DownHeap
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.DownHeap
	|-ArraySortHelper<TextureBlitter.BlitInfo>.DownHeap
	|
	|-RVA: 0x188DEE0 Offset: 0x188C8E0 VA: 0x18188DEE0
	|-ArraySortHelper<int>.DownHeap
	|-ArraySortHelper<Int32Enum>.DownHeap
	|-ArraySortHelper<uint>.DownHeap
	|-ArraySortHelper<UInt32Enum>.DownHeap
	|
	|-RVA: 0x188E0C0 Offset: 0x188CAC0 VA: 0x18188E0C0
	|-ArraySortHelper<long>.DownHeap
	|-ArraySortHelper<ulong>.DownHeap
	|
	|-RVA: 0x188E2A0 Offset: 0x188CCA0 VA: 0x18188E2A0
	|-ArraySortHelper<IntPoint>.DownHeap
	|
	|-RVA: 0x10CD490 Offset: 0x10CBE90 VA: 0x1810CD490
	|-ArraySortHelper<JsonPosition>.DownHeap
	|-ArraySortHelper<StyleSyntaxToken>.DownHeap
	|-ArraySortHelper<TreeViewItemWrapper>.DownHeap
	|-ArraySortHelper<LatencySimulator.Message>.DownHeap
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.DownHeap
	|-ArraySortHelper<StructySync.ChangeData>.DownHeap
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.DownHeap
	|
	|-RVA: 0xFFAB70 Offset: 0xFF9570 VA: 0x180FFAB70
	|-ArraySortHelper<Label>.DownHeap
	|-ArraySortHelper<PlayerLoopSystem>.DownHeap
	|-ArraySortHelper<PlayerLoopSystemInternal>.DownHeap
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.DownHeap
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.DownHeap
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.DownHeap
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.DownHeap
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.DownHeap
	|
	|-RVA: 0x19155E0 Offset: 0x1913FE0 VA: 0x1819155E0
	|-ArraySortHelper<Matrix4x4>.DownHeap
	|
	|-RVA: 0x1915140 Offset: 0x1913B40 VA: 0x181915140
	|-ArraySortHelper<NavMeshBuildSource>.DownHeap
	|
	|-RVA: 0x19159B0 Offset: 0x19143B0 VA: 0x1819159B0
	|-ArraySortHelper<object>.DownHeap
	|
	|-RVA: 0x10CD9B0 Offset: 0x10CC3B0 VA: 0x1810CD9B0
	|-ArraySortHelper<PlayableBinding>.DownHeap
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.DownHeap
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.DownHeap
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.DownHeap
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.DownHeap
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.DownHeap
	|
	|-RVA: 0xFFA350 Offset: 0xFF8D50 VA: 0x180FFA350
	|-ArraySortHelper<RenderTargetIdentifier>.DownHeap
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.DownHeap
	|
	|-RVA: 0x19A2610 Offset: 0x19A1010 VA: 0x1819A2610
	|-ArraySortHelper<float>.DownHeap
	|
	|-RVA: 0x19A2A80 Offset: 0x19A1480 VA: 0x1819A2A80
	|-ArraySortHelper<UIVertex>.DownHeap
	|
	|-RVA: 0x10CD780 Offset: 0x10CC180 VA: 0x1810CD780
	|-ArraySortHelper<UsageHint>.DownHeap
	|-ArraySortHelper<SVGDocument.PostponedClip>.DownHeap
	|-ArraySortHelper<SVGDocument.PostponedStopData>.DownHeap
	|
	|-RVA: 0x19A2800 Offset: 0x19A1200 VA: 0x1819A2800
	|-ArraySortHelper<Vector2>.DownHeap
	|
	|-RVA: 0x1174700 Offset: 0x1173100 VA: 0x181174700
	|-ArraySortHelper<VoxelContour>.DownHeap
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.DownHeap
	|
	|-RVA: 0xFF9E50 Offset: 0xFF8850 VA: 0x180FF9E50
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.DownHeap
	|
	|-RVA: 0xFFAEE0 Offset: 0xFF98E0 VA: 0x180FFAEE0
	|-ArraySortHelper<XRView>.DownHeap
	|
	|-RVA: 0xFFBFE0 Offset: 0xFFA9E0 VA: 0x180FFBFE0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.DownHeap
	|
	|-RVA: 0xFF98A0 Offset: 0xFF82A0 VA: 0x180FF98A0
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.DownHeap
	|-ArraySortHelper<ShadowUtility.Edge>.DownHeap
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.DownHeap
	|
	|-RVA: 0xFF8DF0 Offset: 0xFF77F0 VA: 0x180FF8DF0
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.DownHeap
	|
	|-RVA: 0xFFB930 Offset: 0xFFA330 VA: 0x180FFB930
	|-ArraySortHelper<HID.HIDElementDescriptor>.DownHeap
	|
	|-RVA: 0xFFB410 Offset: 0xFF9E10 VA: 0x180FFB410
	|-ArraySortHelper<InputControlLayout.ControlItem>.DownHeap
	|
	|-RVA: 0x10CCC90 Offset: 0x10CB690 VA: 0x1810CCC90
	|-ArraySortHelper<JsonParser.JsonValue>.DownHeap
	|
	|-RVA: 0x10CE940 Offset: 0x10CD340 VA: 0x1810CE940
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.DownHeap
	|
	|-RVA: 0x10CE4D0 Offset: 0x10CCED0 VA: 0x1810CE4D0
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.DownHeap
	|
	|-RVA: 0x10CE000 Offset: 0x10CCA00 VA: 0x1810CE000
	|-ArraySortHelper<RenderChain.RenderNodeData>.DownHeap
	|
	|-RVA: 0x10CDC80 Offset: 0x10CC680 VA: 0x1810CDC80
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.DownHeap
	|
	|-RVA: 0x11749D0 Offset: 0x11733D0 VA: 0x1811749D0
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.DownHeap
	|
	|-RVA: 0x1174DD0 Offset: 0x11737D0 VA: 0x181174DD0
	|-ArraySortHelper<UIRStylePainter.Entry>.DownHeap
	|
	|-RVA: 0x1174390 Offset: 0x1172D90 VA: 0x181174390
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.DownHeap
	|
	|-RVA: 0x1173CC0 Offset: 0x11726C0 VA: 0x181173CC0
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.DownHeap
	|
	|-RVA: 0x11740C0 Offset: 0x1172AC0 VA: 0x1811740C0
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1001D50 Offset: 0x1000750 VA: 0x181001D50
	|-ArraySortHelper<ArraySegment<byte>>.InsertionSort
	|-ArraySortHelper<KeyValuePair<object, bool>>.InsertionSort
	|-ArraySortHelper<KeyValuePair<object, char>>.InsertionSort
	|-ArraySortHelper<KeyValuePair<object, object>>.InsertionSort
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.InsertionSort
	|-ArraySortHelper<StructMultiKey<object, object>>.InsertionSort
	|-ArraySortHelper<SubArray<int>>.InsertionSort
	|-ArraySortHelper<ValueTuple<object, object>>.InsertionSort
	|-ArraySortHelper<BezierContour>.InsertionSort
	|-ArraySortHelper<Connection>.InsertionSort
	|-ArraySortHelper<CoordinateFootprintTilePair>.InsertionSort
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.InsertionSort
	|-ArraySortHelper<CoordinateStorageTilePair>.InsertionSort
	|-ArraySortHelper<CoordinateTilePair>.InsertionSort
	|-ArraySortHelper<DualPrefab>.InsertionSort
	|-ArraySortHelper<Entry>.InsertionSort
	|-ArraySortHelper<InternedString>.InsertionSort
	|-ArraySortHelper<InterpretedFrameInfo>.InsertionSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.InsertionSort
	|-ArraySortHelper<LigatureSubstitutionRecord>.InsertionSort
	|-ArraySortHelper<RangePositionInfo>.InsertionSort
	|-ArraySortHelper<RuleMatcher>.InsertionSort
	|-ArraySortHelper<StylePropertyValue>.InsertionSort
	|-ArraySortHelper<Substring>.InsertionSort
	|-ArraySortHelper<UnloadedScene>.InsertionSort
	|-ArraySortHelper<CameraState.CustomBlendable>.InsertionSort
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.InsertionSort
	|-ArraySortHelper<FocusController.FocusedElement>.InsertionSort
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.InsertionSort
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.InsertionSort
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.InsertionSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.InsertionSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.InsertionSort
	|-ArraySortHelper<SVGDocument.NodeWithParent>.InsertionSort
	|-ArraySortHelper<TargetStateListener.Callback>.InsertionSort
	|-ArraySortHelper<TextSettings.FontReferenceMap>.InsertionSort
	|-ArraySortHelper<TextureRegistry.TextureInfo>.InsertionSort
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.InsertionSort
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.InsertionSort
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.InsertionSort
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.InsertionSort
	|
	|-RVA: 0x1000C20 Offset: 0xFFF620 VA: 0x181000C20
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.InsertionSort
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.InsertionSort
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.InsertionSort
	|-ArraySortHelper<NativeArray<NudgeJobData>>.InsertionSort
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.InsertionSort
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.InsertionSort
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.InsertionSort
	|-ArraySortHelper<Nullable<DateTime>>.InsertionSort
	|-ArraySortHelper<AsyncGPUReadbackRequest>.InsertionSort
	|-ArraySortHelper<Color>.InsertionSort
	|-ArraySortHelper<DateTimeOffset>.InsertionSort
	|-ArraySortHelper<Decimal>.InsertionSort
	|-ArraySortHelper<GlyphRect>.InsertionSort
	|-ArraySortHelper<Guid>.InsertionSort
	|-ArraySortHelper<IntPoint>.InsertionSort
	|-ArraySortHelper<IntRect>.InsertionSort
	|-ArraySortHelper<Playable>.InsertionSort
	|-ArraySortHelper<Quaternion>.InsertionSort
	|-ArraySortHelper<RectInt>.InsertionSort
	|-ArraySortHelper<Resolution>.InsertionSort
	|-ArraySortHelper<SamplePointUData>.InsertionSort
	|-ArraySortHelper<UILineInfo>.InsertionSort
	|-ArraySortHelper<Vector4>.InsertionSort
	|-ArraySortHelper<ClipperLib.IntPoint>.InsertionSort
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.InsertionSort
	|-ArraySortHelper<ServerSocket.ConnectionChange>.InsertionSort
	|
	|-RVA: 0x1000060 Offset: 0xFFEA60 VA: 0x181000060
	|-ArraySortHelper<SyncList.ChangeData<int>>.InsertionSort
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.InsertionSort
	|-ArraySortHelper<DuplicateSamplePoint>.InsertionSort
	|-ArraySortHelper<Int3>.InsertionSort
	|-ArraySortHelper<IntRegion>.InsertionSort
	|-ArraySortHelper<ManipulatorActivationFilter>.InsertionSort
	|-ArraySortHelper<UICharInfo>.InsertionSort
	|-ArraySortHelper<Vector3>.InsertionSort
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.InsertionSort
	|-ArraySortHelper<HIDParser.HIDReportData>.InsertionSort
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.InsertionSort
	|-ArraySortHelper<SyncTimer.ChangeData>.InsertionSort
	|
	|-RVA: 0x16A1B80 Offset: 0x16A0580 VA: 0x1816A1B80
	|-ArraySortHelper<IntervalTree.Entry<object>>.InsertionSort
	|-ArraySortHelper<KeyValuePair<Rect, object>>.InsertionSort
	|-ArraySortHelper<ComputedTransitionProperty>.InsertionSort
	|-ArraySortHelper<ContourVertex>.InsertionSort
	|
	|-RVA: 0xFFF510 Offset: 0xFFDF10 VA: 0x180FFF510
	|-ArraySortHelper<KeyValuePair<int, object>>.InsertionSort
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.InsertionSort
	|-ArraySortHelper<ValueTuple<int, object>>.InsertionSort
	|-ArraySortHelper<EventSummary>.InsertionSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.InsertionSort
	|-ArraySortHelper<MultipleSubstitutionRecord>.InsertionSort
	|-ArraySortHelper<StylePropertyName>.InsertionSort
	|-ArraySortHelper<StyleValueManaged>.InsertionSort
	|-ArraySortHelper<X509ChainStatus>.InsertionSort
	|-ArraySortHelper<ZipGenericExtraField>.InsertionSort
	|-ArraySortHelper<AdvancedSmooth.Turn>.InsertionSort
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.InsertionSort
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.InsertionSort
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.InsertionSort
	|-ArraySortHelper<TransportManager.DisconnectingClient>.InsertionSort
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.InsertionSort
	|
	|-RVA: 0x16A1890 Offset: 0x16A0290 VA: 0x1816A1890
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.InsertionSort
	|-ArraySortHelper<RaycastResult>.InsertionSort
	|
	|-RVA: 0x1001F10 Offset: 0x1000910 VA: 0x181001F10
	|-ArraySortHelper<Nullable<Decimal>>.InsertionSort
	|-ArraySortHelper<TempAllocator.Page<ushort>>.InsertionSort
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.InsertionSort
	|-ArraySortHelper<BezierPathSegment>.InsertionSort
	|-ArraySortHelper<Bounds>.InsertionSort
	|-ArraySortHelper<FrameTimeSample>.InsertionSort
	|-ArraySortHelper<IntervalTreeNode>.InsertionSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.InsertionSort
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.InsertionSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.InsertionSort
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.InsertionSort
	|-ArraySortHelper<RendererList>.InsertionSort
	|-ArraySortHelper<StyleValue>.InsertionSort
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.InsertionSort
	|
	|-RVA: 0xFFF8E0 Offset: 0xFFE2E0 VA: 0x180FFF8E0
	|-ArraySortHelper<ValueTuple<int, int>>.InsertionSort
	|-ArraySortHelper<ValueTuple<int, Scene>>.InsertionSort
	|-ArraySortHelper<AnimatorClipInfo>.InsertionSort
	|-ArraySortHelper<DateTime>.InsertionSort
	|-ArraySortHelper<InputEventPtr>.InsertionSort
	|-ArraySortHelper<RendererListHandle>.InsertionSort
	|-ArraySortHelper<ResourceHandle>.InsertionSort
	|-ArraySortHelper<SamplePointsPatch>.InsertionSort
	|-ArraySortHelper<TimeSpan>.InsertionSort
	|-ArraySortHelper<TimeValue>.InsertionSort
	|-ArraySortHelper<BitmapAllocator32.Page>.InsertionSort
	|-ArraySortHelper<CinemachineClearShot.Pair>.InsertionSort
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.InsertionSort
	|-ArraySortHelper<PlayingCard.CardData>.InsertionSort
	|-ArraySortHelper<SyncStopwatch.ChangeData>.InsertionSort
	|
	|-RVA: 0xFFF6D0 Offset: 0xFFE0D0 VA: 0x180FFF6D0
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.InsertionSort
	|-ArraySortHelper<CoordinateProceduralTilePair>.InsertionSort
	|-ArraySortHelper<NameAndParameters>.InsertionSort
	|-ArraySortHelper<NamedValue>.InsertionSort
	|-ArraySortHelper<SelectorMatchRecord>.InsertionSort
	|-ArraySortHelper<StyleSelectorPart>.InsertionSort
	|-ArraySortHelper<StyleVariable>.InsertionSort
	|-ArraySortHelper<XRFeatureDescriptor>.InsertionSort
	|-ArraySortHelper<AvatarSettings.LayerSetting>.InsertionSort
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.InsertionSort
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.InsertionSort
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.InsertionSort
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.InsertionSort
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.InsertionSort
	|
	|-RVA: 0x1001020 Offset: 0xFFFA20 VA: 0x181001020
	|-ArraySortHelper<BezierSegment>.InsertionSort
	|-ArraySortHelper<NavMeshBuildMarkup>.InsertionSort
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.InsertionSort
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.InsertionSort
	|
	|-RVA: 0x17F1570 Offset: 0x17EFF70 VA: 0x1817F1570
	|-ArraySortHelper<bool>.InsertionSort
	|-ArraySortHelper<byte>.InsertionSort
	|-ArraySortHelper<sbyte>.InsertionSort
	|
	|-RVA: 0x17F1C50 Offset: 0x17F0650 VA: 0x1817F1C50
	|-ArraySortHelper<CGSpot>.InsertionSort
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.InsertionSort
	|-ArraySortHelper<RaycastHit>.InsertionSort
	|
	|-RVA: 0x17F16F0 Offset: 0x17F00F0 VA: 0x1817F16F0
	|-ArraySortHelper<char>.InsertionSort
	|-ArraySortHelper<short>.InsertionSort
	|-ArraySortHelper<ushort>.InsertionSort
	|
	|-RVA: 0x10D1640 Offset: 0x10D0040 VA: 0x1810D1640
	|-ArraySortHelper<Color32>.InsertionSort
	|-ArraySortHelper<EasingFunction>.InsertionSort
	|-ArraySortHelper<Scene>.InsertionSort
	|-ArraySortHelper<ShaderTagId>.InsertionSort
	|-ArraySortHelper<UShort2>.InsertionSort
	|-ArraySortHelper<RegexCharClass.SingleRange>.InsertionSort
	|
	|-RVA: 0x17F1ED0 Offset: 0x17F08D0 VA: 0x1817F1ED0
	|-ArraySortHelper<CombineInstance>.InsertionSort
	|
	|-RVA: 0xFFFE20 Offset: 0xFFE820 VA: 0x180FFFE20
	|-ArraySortHelper<ControlPointOption>.InsertionSort
	|-ArraySortHelper<RaycastHit2D>.InsertionSort
	|-ArraySortHelper<Funnel.PathPart>.InsertionSort
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.InsertionSort
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.InsertionSort
	|
	|-RVA: 0x17F19F0 Offset: 0x17F03F0 VA: 0x1817F19F0
	|-ArraySortHelper<DisplayInfo>.InsertionSort
	|
	|-RVA: 0x17F1870 Offset: 0x17F0270 VA: 0x1817F1870
	|-ArraySortHelper<double>.InsertionSort
	|
	|-RVA: 0x1001590 Offset: 0xFFFF90 VA: 0x181001590
	|-ArraySortHelper<DoublePoint>.InsertionSort
	|-ArraySortHelper<DoublePoint>.InsertionSort
	|-ArraySortHelper<ClipperLib.DoublePoint>.InsertionSort
	|
	|-RVA: 0x188F3E0 Offset: 0x188DDE0 VA: 0x18188F3E0
	|-ArraySortHelper<InputBinding>.InsertionSort
	|
	|-RVA: 0x10D0B30 Offset: 0x10CF530 VA: 0x1810D0B30
	|-ArraySortHelper<InputDeviceDescription>.InsertionSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.InsertionSort
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.InsertionSort
	|-ArraySortHelper<TextureBlitter.BlitInfo>.InsertionSort
	|
	|-RVA: 0x188F940 Offset: 0x188E340 VA: 0x18188F940
	|-ArraySortHelper<int>.InsertionSort
	|-ArraySortHelper<Int32Enum>.InsertionSort
	|-ArraySortHelper<uint>.InsertionSort
	|-ArraySortHelper<UInt32Enum>.InsertionSort
	|
	|-RVA: 0x188FAC0 Offset: 0x188E4C0 VA: 0x18188FAC0
	|-ArraySortHelper<long>.InsertionSort
	|-ArraySortHelper<ulong>.InsertionSort
	|
	|-RVA: 0x188F710 Offset: 0x188E110 VA: 0x18188F710
	|-ArraySortHelper<IntPoint>.InsertionSort
	|
	|-RVA: 0x10D0920 Offset: 0x10CF320 VA: 0x1810D0920
	|-ArraySortHelper<JsonPosition>.InsertionSort
	|-ArraySortHelper<StyleSyntaxToken>.InsertionSort
	|-ArraySortHelper<TreeViewItemWrapper>.InsertionSort
	|-ArraySortHelper<LatencySimulator.Message>.InsertionSort
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.InsertionSort
	|-ArraySortHelper<StructySync.ChangeData>.InsertionSort
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.InsertionSort
	|
	|-RVA: 0x1000DC0 Offset: 0xFFF7C0 VA: 0x181000DC0
	|-ArraySortHelper<Label>.InsertionSort
	|-ArraySortHelper<PlayerLoopSystem>.InsertionSort
	|-ArraySortHelper<PlayerLoopSystemInternal>.InsertionSort
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.InsertionSort
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.InsertionSort
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.InsertionSort
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.InsertionSort
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.InsertionSort
	|
	|-RVA: 0x1916460 Offset: 0x1914E60 VA: 0x181916460
	|-ArraySortHelper<Matrix4x4>.InsertionSort
	|
	|-RVA: 0x19166D0 Offset: 0x19150D0 VA: 0x1819166D0
	|-ArraySortHelper<NavMeshBuildSource>.InsertionSort
	|
	|-RVA: 0x19162C0 Offset: 0x1914CC0 VA: 0x1819162C0
	|-ArraySortHelper<object>.InsertionSort
	|
	|-RVA: 0x10D03F0 Offset: 0x10CEDF0 VA: 0x1810D03F0
	|-ArraySortHelper<PlayableBinding>.InsertionSort
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.InsertionSort
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.InsertionSort
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.InsertionSort
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.InsertionSort
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.InsertionSort
	|
	|-RVA: 0x1000250 Offset: 0xFFEC50 VA: 0x181000250
	|-ArraySortHelper<RenderTargetIdentifier>.InsertionSort
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.InsertionSort
	|
	|-RVA: 0x19A3B40 Offset: 0x19A2540 VA: 0x1819A3B40
	|-ArraySortHelper<float>.InsertionSort
	|
	|-RVA: 0x19A3730 Offset: 0x19A2130 VA: 0x1819A3730
	|-ArraySortHelper<UIVertex>.InsertionSort
	|
	|-RVA: 0x10D10B0 Offset: 0x10CFAB0 VA: 0x1810D10B0
	|-ArraySortHelper<UsageHint>.InsertionSort
	|-ArraySortHelper<SVGDocument.PostponedClip>.InsertionSort
	|-ArraySortHelper<SVGDocument.PostponedStopData>.InsertionSort
	|
	|-RVA: 0x19A3CC0 Offset: 0x19A26C0 VA: 0x1819A3CC0
	|-ArraySortHelper<Vector2>.InsertionSort
	|
	|-RVA: 0x1176E90 Offset: 0x1175890 VA: 0x181176E90
	|-ArraySortHelper<VoxelContour>.InsertionSort
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.InsertionSort
	|
	|-RVA: 0x10011F0 Offset: 0xFFFBF0 VA: 0x1810011F0
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.InsertionSort
	|
	|-RVA: 0xFFFA60 Offset: 0xFFE460 VA: 0x180FFFA60
	|-ArraySortHelper<XRView>.InsertionSort
	|
	|-RVA: 0x10007F0 Offset: 0xFFF1F0 VA: 0x1810007F0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.InsertionSort
	|
	|-RVA: 0x1001790 Offset: 0x1000190 VA: 0x181001790
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.InsertionSort
	|-ArraySortHelper<ShadowUtility.Edge>.InsertionSort
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.InsertionSort
	|
	|-RVA: 0x10019D0 Offset: 0x10003D0 VA: 0x1810019D0
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.InsertionSort
	|
	|-RVA: 0x10020F0 Offset: 0x1000AF0 VA: 0x1810020F0
	|-ArraySortHelper<HID.HIDElementDescriptor>.InsertionSort
	|
	|-RVA: 0x1000480 Offset: 0xFFEE80 VA: 0x181000480
	|-ArraySortHelper<InputControlLayout.ControlItem>.InsertionSort
	|
	|-RVA: 0x10D0DC0 Offset: 0x10CF7C0 VA: 0x1810D0DC0
	|-ArraySortHelper<JsonParser.JsonValue>.InsertionSort
	|
	|-RVA: 0x10D1250 Offset: 0x10CFC50 VA: 0x1810D1250
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.InsertionSort
	|
	|-RVA: 0x10D17C0 Offset: 0x10D01C0 VA: 0x1810D17C0
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.InsertionSort
	|
	|-RVA: 0x10D05E0 Offset: 0x10CEFE0 VA: 0x1810D05E0
	|-ArraySortHelper<RenderChain.RenderNodeData>.InsertionSort
	|
	|-RVA: 0x10D13E0 Offset: 0x10CFDE0 VA: 0x1810D13E0
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.InsertionSort
	|
	|-RVA: 0x1176A20 Offset: 0x1175420 VA: 0x181176A20
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.InsertionSort
	|
	|-RVA: 0x11761F0 Offset: 0x1174BF0 VA: 0x1811761F0
	|-ArraySortHelper<UIRStylePainter.Entry>.InsertionSort
	|
	|-RVA: 0x11764E0 Offset: 0x1174EE0 VA: 0x1811764E0
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.InsertionSort
	|
	|-RVA: 0x1176730 Offset: 0x1175130 VA: 0x181176730
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.InsertionSort
	|
	|-RVA: 0x1176CA0 Offset: 0x11756A0 VA: 0x181176CA0
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public static ArraySortHelper<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1018C00 Offset: 0x1017600 VA: 0x181018C00
	|-ArraySortHelper<ArraySegment<byte>>.get_Default
	|-ArraySortHelper<SyncList.CachedOnChange<int>>.get_Default
	|-ArraySortHelper<SyncList.ChangeData<int>>.get_Default
	|-ArraySortHelper<IntervalTree.Entry<object>>.get_Default
	|-ArraySortHelper<KeyValuePair<int, object>>.get_Default
	|-ArraySortHelper<KeyValuePair<object, bool>>.get_Default
	|-ArraySortHelper<KeyValuePair<object, char>>.get_Default
	|-ArraySortHelper<KeyValuePair<object, object>>.get_Default
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>.get_Default
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>.get_Default
	|-ArraySortHelper<KeyValuePair<Rect, object>>.get_Default
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>.get_Default
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>.get_Default
	|-ArraySortHelper<NativeArray<NudgeJobData>>.get_Default
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>.get_Default
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>.get_Default
	|-ArraySortHelper<NativeSlice<NudgeJobData>>.get_Default
	|-ArraySortHelper<Nullable<DateTime>>.get_Default
	|-ArraySortHelper<Nullable<Decimal>>.get_Default
	|-ArraySortHelper<TempAllocator.Page<ushort>>.get_Default
	|-ArraySortHelper<TempAllocator.Page<Vertex>>.get_Default
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Default
	|-ArraySortHelper<StructMultiKey<object, object>>.get_Default
	|-ArraySortHelper<SubArray<int>>.get_Default
	|-ArraySortHelper<ValueTuple<int, int>>.get_Default
	|-ArraySortHelper<ValueTuple<int, object>>.get_Default
	|-ArraySortHelper<ValueTuple<int, Scene>>.get_Default
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>.get_Default
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>.get_Default
	|-ArraySortHelper<ValueTuple<object, object>>.get_Default
	|-ArraySortHelper<AnimatorClipInfo>.get_Default
	|-ArraySortHelper<AsyncGPUReadbackRequest>.get_Default
	|-ArraySortHelper<BezierContour>.get_Default
	|-ArraySortHelper<BezierPathSegment>.get_Default
	|-ArraySortHelper<BezierSegment>.get_Default
	|-ArraySortHelper<bool>.get_Default
	|-ArraySortHelper<Bounds>.get_Default
	|-ArraySortHelper<byte>.get_Default
	|-ArraySortHelper<CGSpot>.get_Default
	|-ArraySortHelper<char>.get_Default
	|-ArraySortHelper<Color>.get_Default
	|-ArraySortHelper<Color32>.get_Default
	|-ArraySortHelper<CombineInstance>.get_Default
	|-ArraySortHelper<ComputedTransitionProperty>.get_Default
	|-ArraySortHelper<Connection>.get_Default
	|-ArraySortHelper<ContourVertex>.get_Default
	|-ArraySortHelper<ControlPointOption>.get_Default
	|-ArraySortHelper<CoordinateFootprintTilePair>.get_Default
	|-ArraySortHelper<CoordinateProceduralTilePair>.get_Default
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>.get_Default
	|-ArraySortHelper<CoordinateStorageTilePair>.get_Default
	|-ArraySortHelper<CoordinateTilePair>.get_Default
	|-ArraySortHelper<DateTime>.get_Default
	|-ArraySortHelper<DateTimeOffset>.get_Default
	|-ArraySortHelper<Decimal>.get_Default
	|-ArraySortHelper<DisplayInfo>.get_Default
	|-ArraySortHelper<double>.get_Default
	|-ArraySortHelper<DoublePoint>.get_Default
	|-ArraySortHelper<DoublePoint>.get_Default
	|-ArraySortHelper<DualPrefab>.get_Default
	|-ArraySortHelper<DuplicateSamplePoint>.get_Default
	|-ArraySortHelper<EasingFunction>.get_Default
	|-ArraySortHelper<Entry>.get_Default
	|-ArraySortHelper<EventSummary>.get_Default
	|-ArraySortHelper<FrameTimeSample>.get_Default
	|-ArraySortHelper<GlyphPairAdjustmentRecord>.get_Default
	|-ArraySortHelper<GlyphRect>.get_Default
	|-ArraySortHelper<Guid>.get_Default
	|-ArraySortHelper<InputBinding>.get_Default
	|-ArraySortHelper<InputDeviceDescription>.get_Default
	|-ArraySortHelper<InputEventPtr>.get_Default
	|-ArraySortHelper<short>.get_Default
	|-ArraySortHelper<Int3>.get_Default
	|-ArraySortHelper<int>.get_Default
	|-ArraySortHelper<Int32Enum>.get_Default
	|-ArraySortHelper<long>.get_Default
	|-ArraySortHelper<IntPoint>.get_Default
	|-ArraySortHelper<IntPoint>.get_Default
	|-ArraySortHelper<IntRect>.get_Default
	|-ArraySortHelper<IntRegion>.get_Default
	|-ArraySortHelper<InternedString>.get_Default
	|-ArraySortHelper<InterpretedFrameInfo>.get_Default
	|-ArraySortHelper<IntervalTreeNode>.get_Default
	|-ArraySortHelper<JsonPosition>.get_Default
	|-ArraySortHelper<Label>.get_Default
	|-ArraySortHelper<LigatureSubstitutionRecord>.get_Default
	|-ArraySortHelper<LigatureSubstitutionRecord>.get_Default
	|-ArraySortHelper<ManipulatorActivationFilter>.get_Default
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.get_Default
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>.get_Default
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.get_Default
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>.get_Default
	|-ArraySortHelper<Matrix4x4>.get_Default
	|-ArraySortHelper<MultipleSubstitutionRecord>.get_Default
	|-ArraySortHelper<MultipleSubstitutionRecord>.get_Default
	|-ArraySortHelper<NameAndParameters>.get_Default
	|-ArraySortHelper<NamedValue>.get_Default
	|-ArraySortHelper<NavMeshBuildMarkup>.get_Default
	|-ArraySortHelper<NavMeshBuildSource>.get_Default
	|-ArraySortHelper<object>.get_Default
	|-ArraySortHelper<Playable>.get_Default
	|-ArraySortHelper<PlayableBinding>.get_Default
	|-ArraySortHelper<PlayerLoopSystem>.get_Default
	|-ArraySortHelper<PlayerLoopSystemInternal>.get_Default
	|-ArraySortHelper<Quaternion>.get_Default
	|-ArraySortHelper<RangePositionInfo>.get_Default
	|-ArraySortHelper<RaycastHit>.get_Default
	|-ArraySortHelper<RaycastHit2D>.get_Default
	|-ArraySortHelper<RaycastResult>.get_Default
	|-ArraySortHelper<RectInt>.get_Default
	|-ArraySortHelper<RenderTargetIdentifier>.get_Default
	|-ArraySortHelper<RendererList>.get_Default
	|-ArraySortHelper<RendererListHandle>.get_Default
	|-ArraySortHelper<Resolution>.get_Default
	|-ArraySortHelper<ResourceHandle>.get_Default
	|-ArraySortHelper<RuleMatcher>.get_Default
	|-ArraySortHelper<sbyte>.get_Default
	|-ArraySortHelper<SamplePointUData>.get_Default
	|-ArraySortHelper<SamplePointsPatch>.get_Default
	|-ArraySortHelper<Scene>.get_Default
	|-ArraySortHelper<SelectorMatchRecord>.get_Default
	|-ArraySortHelper<ShaderTagId>.get_Default
	|-ArraySortHelper<float>.get_Default
	|-ArraySortHelper<StylePropertyName>.get_Default
	|-ArraySortHelper<StylePropertyValue>.get_Default
	|-ArraySortHelper<StyleSelectorPart>.get_Default
	|-ArraySortHelper<StyleSyntaxToken>.get_Default
	|-ArraySortHelper<StyleValue>.get_Default
	|-ArraySortHelper<StyleValueManaged>.get_Default
	|-ArraySortHelper<StyleVariable>.get_Default
	|-ArraySortHelper<Substring>.get_Default
	|-ArraySortHelper<TimeSpan>.get_Default
	|-ArraySortHelper<TimeValue>.get_Default
	|-ArraySortHelper<TreeViewItemWrapper>.get_Default
	|-ArraySortHelper<UICharInfo>.get_Default
	|-ArraySortHelper<UILineInfo>.get_Default
	|-ArraySortHelper<UIVertex>.get_Default
	|-ArraySortHelper<ushort>.get_Default
	|-ArraySortHelper<uint>.get_Default
	|-ArraySortHelper<UInt32Enum>.get_Default
	|-ArraySortHelper<ulong>.get_Default
	|-ArraySortHelper<UShort2>.get_Default
	|-ArraySortHelper<UnloadedScene>.get_Default
	|-ArraySortHelper<UsageHint>.get_Default
	|-ArraySortHelper<Vector2>.get_Default
	|-ArraySortHelper<Vector3>.get_Default
	|-ArraySortHelper<Vector4>.get_Default
	|-ArraySortHelper<VoxelContour>.get_Default
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>.get_Default
	|-ArraySortHelper<X509ChainStatus>.get_Default
	|-ArraySortHelper<XRFeatureDescriptor>.get_Default
	|-ArraySortHelper<XRView>.get_Default
	|-ArraySortHelper<ZipGenericExtraField>.get_Default
	|-ArraySortHelper<__Il2CppFullySharedGenericType>.get_Default
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.get_Default
	|-ArraySortHelper<AdvancedSmooth.Turn>.get_Default
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>.get_Default
	|-ArraySortHelper<AvatarSettings.LayerSetting>.get_Default
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>.get_Default
	|-ArraySortHelper<BitmapAllocator32.Page>.get_Default
	|-ArraySortHelper<CameraState.CustomBlendable>.get_Default
	|-ArraySortHelper<CinemachineClearShot.Pair>.get_Default
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>.get_Default
	|-ArraySortHelper<ClipperLib.DoublePoint>.get_Default
	|-ArraySortHelper<ClipperLib.IntPoint>.get_Default
	|-ArraySortHelper<ConfinerOven.PolygonSolution>.get_Default
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>.get_Default
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>.get_Default
	|-ArraySortHelper<FocusController.FocusedElement>.get_Default
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>.get_Default
	|-ArraySortHelper<Funnel.PathPart>.get_Default
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>.get_Default
	|-ArraySortHelper<HID.HIDCollectionDescriptor>.get_Default
	|-ArraySortHelper<HID.HIDElementDescriptor>.get_Default
	|-ArraySortHelper<HIDParser.HIDReportData>.get_Default
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>.get_Default
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>.get_Default
	|-ArraySortHelper<InputControlLayout.ControlItem>.get_Default
	|-ArraySortHelper<InputTransformSpots.TransformSpot>.get_Default
	|-ArraySortHelper<JsonParser.JsonValue>.get_Default
	|-ArraySortHelper<LatencySimulator.Message>.get_Default
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>.get_Default
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>.get_Default
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>.get_Default
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>.get_Default
	|-ArraySortHelper<PlayingCard.CardData>.get_Default
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>.get_Default
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>.get_Default
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.get_Default
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>.get_Default
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>.get_Default
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>.get_Default
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>.get_Default
	|-ArraySortHelper<RegexCharClass.SingleRange>.get_Default
	|-ArraySortHelper<RenderChain.RenderNodeData>.get_Default
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>.get_Default
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>.get_Default
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>.get_Default
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>.get_Default
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>.get_Default
	|-ArraySortHelper<RigidbodyPrediction.MoveData>.get_Default
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>.get_Default
	|-ArraySortHelper<SVGDocument.NodeReferenceData>.get_Default
	|-ArraySortHelper<SVGDocument.NodeWithParent>.get_Default
	|-ArraySortHelper<SVGDocument.PostponedClip>.get_Default
	|-ArraySortHelper<SVGDocument.PostponedStopData>.get_Default
	|-ArraySortHelper<ServerSocket.ConnectionChange>.get_Default
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>.get_Default
	|-ArraySortHelper<ShadowUtility.Edge>.get_Default
	|-ArraySortHelper<StructySync.ChangeData>.get_Default
	|-ArraySortHelper<SyncStopwatch.ChangeData>.get_Default
	|-ArraySortHelper<SyncTimer.ChangeData>.get_Default
	|-ArraySortHelper<TargetStateListener.Callback>.get_Default
	|-ArraySortHelper<TemplateAsset.AttributeOverride>.get_Default
	|-ArraySortHelper<TextSettings.FontReferenceMap>.get_Default
	|-ArraySortHelper<TextureBlitter.BlitInfo>.get_Default
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>.get_Default
	|-ArraySortHelper<TextureRegistry.TextureInfo>.get_Default
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>.get_Default
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>.get_Default
	|-ArraySortHelper<TransportManager.DisconnectingClient>.get_Default
	|-ArraySortHelper<UIRStylePainter.Entry>.get_Default
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>.get_Default
	|-ArraySortHelper<UIRenderDevice.AllocToFree>.get_Default
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>.get_Default
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>.get_Default
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>.get_Default
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>.get_Default
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>.get_Default
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>.get_Default
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>.get_Default
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Default
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.get_Default
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>.get_Default
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>.get_Default
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>.get_Default
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Default
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>.get_Default
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>.get_Default
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-ArraySortHelper<ArraySegment<byte>>..ctor
	|-ArraySortHelper<SyncList.CachedOnChange<int>>..ctor
	|-ArraySortHelper<SyncList.ChangeData<int>>..ctor
	|-ArraySortHelper<IntervalTree.Entry<object>>..ctor
	|-ArraySortHelper<KeyValuePair<int, object>>..ctor
	|-ArraySortHelper<KeyValuePair<object, bool>>..ctor
	|-ArraySortHelper<KeyValuePair<object, char>>..ctor
	|-ArraySortHelper<KeyValuePair<object, object>>..ctor
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>..ctor
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>..ctor
	|-ArraySortHelper<KeyValuePair<Rect, object>>..ctor
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>..ctor
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>..ctor
	|-ArraySortHelper<NativeArray<NudgeJobData>>..ctor
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>..ctor
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-ArraySortHelper<NativeSlice<NudgeJobData>>..ctor
	|-ArraySortHelper<Nullable<DateTime>>..ctor
	|-ArraySortHelper<Nullable<Decimal>>..ctor
	|-ArraySortHelper<TempAllocator.Page<ushort>>..ctor
	|-ArraySortHelper<TempAllocator.Page<Vertex>>..ctor
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|-ArraySortHelper<StructMultiKey<object, object>>..ctor
	|-ArraySortHelper<SubArray<int>>..ctor
	|-ArraySortHelper<ValueTuple<int, int>>..ctor
	|-ArraySortHelper<ValueTuple<int, object>>..ctor
	|-ArraySortHelper<ValueTuple<int, Scene>>..ctor
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>..ctor
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-ArraySortHelper<ValueTuple<object, object>>..ctor
	|-ArraySortHelper<AnimatorClipInfo>..ctor
	|-ArraySortHelper<AsyncGPUReadbackRequest>..ctor
	|-ArraySortHelper<BezierContour>..ctor
	|-ArraySortHelper<BezierPathSegment>..ctor
	|-ArraySortHelper<BezierSegment>..ctor
	|-ArraySortHelper<bool>..ctor
	|-ArraySortHelper<Bounds>..ctor
	|-ArraySortHelper<byte>..ctor
	|-ArraySortHelper<CGSpot>..ctor
	|-ArraySortHelper<char>..ctor
	|-ArraySortHelper<Color>..ctor
	|-ArraySortHelper<Color32>..ctor
	|-ArraySortHelper<CombineInstance>..ctor
	|-ArraySortHelper<ComputedTransitionProperty>..ctor
	|-ArraySortHelper<Connection>..ctor
	|-ArraySortHelper<ContourVertex>..ctor
	|-ArraySortHelper<ControlPointOption>..ctor
	|-ArraySortHelper<CoordinateFootprintTilePair>..ctor
	|-ArraySortHelper<CoordinateProceduralTilePair>..ctor
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>..ctor
	|-ArraySortHelper<CoordinateStorageTilePair>..ctor
	|-ArraySortHelper<CoordinateTilePair>..ctor
	|-ArraySortHelper<DateTime>..ctor
	|-ArraySortHelper<DateTimeOffset>..ctor
	|-ArraySortHelper<Decimal>..ctor
	|-ArraySortHelper<DisplayInfo>..ctor
	|-ArraySortHelper<double>..ctor
	|-ArraySortHelper<DoublePoint>..ctor
	|-ArraySortHelper<DoublePoint>..ctor
	|-ArraySortHelper<DualPrefab>..ctor
	|-ArraySortHelper<DuplicateSamplePoint>..ctor
	|-ArraySortHelper<EasingFunction>..ctor
	|-ArraySortHelper<Entry>..ctor
	|-ArraySortHelper<EventSummary>..ctor
	|-ArraySortHelper<FrameTimeSample>..ctor
	|-ArraySortHelper<GlyphPairAdjustmentRecord>..ctor
	|-ArraySortHelper<GlyphRect>..ctor
	|-ArraySortHelper<Guid>..ctor
	|-ArraySortHelper<InputBinding>..ctor
	|-ArraySortHelper<InputDeviceDescription>..ctor
	|-ArraySortHelper<InputEventPtr>..ctor
	|-ArraySortHelper<short>..ctor
	|-ArraySortHelper<Int3>..ctor
	|-ArraySortHelper<int>..ctor
	|-ArraySortHelper<Int32Enum>..ctor
	|-ArraySortHelper<long>..ctor
	|-ArraySortHelper<IntPoint>..ctor
	|-ArraySortHelper<IntPoint>..ctor
	|-ArraySortHelper<IntRect>..ctor
	|-ArraySortHelper<IntRegion>..ctor
	|-ArraySortHelper<InternedString>..ctor
	|-ArraySortHelper<InterpretedFrameInfo>..ctor
	|-ArraySortHelper<IntervalTreeNode>..ctor
	|-ArraySortHelper<JsonPosition>..ctor
	|-ArraySortHelper<Label>..ctor
	|-ArraySortHelper<LigatureSubstitutionRecord>..ctor
	|-ArraySortHelper<LigatureSubstitutionRecord>..ctor
	|-ArraySortHelper<ManipulatorActivationFilter>..ctor
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>..ctor
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>..ctor
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>..ctor
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>..ctor
	|-ArraySortHelper<Matrix4x4>..ctor
	|-ArraySortHelper<MultipleSubstitutionRecord>..ctor
	|-ArraySortHelper<MultipleSubstitutionRecord>..ctor
	|-ArraySortHelper<NameAndParameters>..ctor
	|-ArraySortHelper<NamedValue>..ctor
	|-ArraySortHelper<NavMeshBuildMarkup>..ctor
	|-ArraySortHelper<NavMeshBuildSource>..ctor
	|-ArraySortHelper<object>..ctor
	|-ArraySortHelper<Playable>..ctor
	|-ArraySortHelper<PlayableBinding>..ctor
	|-ArraySortHelper<PlayerLoopSystem>..ctor
	|-ArraySortHelper<PlayerLoopSystemInternal>..ctor
	|-ArraySortHelper<Quaternion>..ctor
	|-ArraySortHelper<RangePositionInfo>..ctor
	|-ArraySortHelper<RaycastHit>..ctor
	|-ArraySortHelper<RaycastHit2D>..ctor
	|-ArraySortHelper<RaycastResult>..ctor
	|-ArraySortHelper<RectInt>..ctor
	|-ArraySortHelper<RenderTargetIdentifier>..ctor
	|-ArraySortHelper<RendererList>..ctor
	|-ArraySortHelper<RendererListHandle>..ctor
	|-ArraySortHelper<Resolution>..ctor
	|-ArraySortHelper<ResourceHandle>..ctor
	|-ArraySortHelper<RuleMatcher>..ctor
	|-ArraySortHelper<sbyte>..ctor
	|-ArraySortHelper<SamplePointUData>..ctor
	|-ArraySortHelper<SamplePointsPatch>..ctor
	|-ArraySortHelper<Scene>..ctor
	|-ArraySortHelper<SelectorMatchRecord>..ctor
	|-ArraySortHelper<ShaderTagId>..ctor
	|-ArraySortHelper<float>..ctor
	|-ArraySortHelper<StylePropertyName>..ctor
	|-ArraySortHelper<StylePropertyValue>..ctor
	|-ArraySortHelper<StyleSelectorPart>..ctor
	|-ArraySortHelper<StyleSyntaxToken>..ctor
	|-ArraySortHelper<StyleValue>..ctor
	|-ArraySortHelper<StyleValueManaged>..ctor
	|-ArraySortHelper<StyleVariable>..ctor
	|-ArraySortHelper<Substring>..ctor
	|-ArraySortHelper<TimeSpan>..ctor
	|-ArraySortHelper<TimeValue>..ctor
	|-ArraySortHelper<TreeViewItemWrapper>..ctor
	|-ArraySortHelper<UICharInfo>..ctor
	|-ArraySortHelper<UILineInfo>..ctor
	|-ArraySortHelper<UIVertex>..ctor
	|-ArraySortHelper<ushort>..ctor
	|-ArraySortHelper<uint>..ctor
	|-ArraySortHelper<UInt32Enum>..ctor
	|-ArraySortHelper<ulong>..ctor
	|-ArraySortHelper<UShort2>..ctor
	|-ArraySortHelper<UnloadedScene>..ctor
	|-ArraySortHelper<UsageHint>..ctor
	|-ArraySortHelper<Vector2>..ctor
	|-ArraySortHelper<Vector3>..ctor
	|-ArraySortHelper<Vector4>..ctor
	|-ArraySortHelper<VoxelContour>..ctor
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|-ArraySortHelper<X509ChainStatus>..ctor
	|-ArraySortHelper<XRFeatureDescriptor>..ctor
	|-ArraySortHelper<XRView>..ctor
	|-ArraySortHelper<ZipGenericExtraField>..ctor
	|-ArraySortHelper<__Il2CppFullySharedGenericType>..ctor
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..ctor
	|-ArraySortHelper<AdvancedSmooth.Turn>..ctor
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|-ArraySortHelper<AvatarSettings.LayerSetting>..ctor
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>..ctor
	|-ArraySortHelper<BitmapAllocator32.Page>..ctor
	|-ArraySortHelper<CameraState.CustomBlendable>..ctor
	|-ArraySortHelper<CinemachineClearShot.Pair>..ctor
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>..ctor
	|-ArraySortHelper<ClipperLib.DoublePoint>..ctor
	|-ArraySortHelper<ClipperLib.IntPoint>..ctor
	|-ArraySortHelper<ConfinerOven.PolygonSolution>..ctor
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>..ctor
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>..ctor
	|-ArraySortHelper<FocusController.FocusedElement>..ctor
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>..ctor
	|-ArraySortHelper<Funnel.PathPart>..ctor
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>..ctor
	|-ArraySortHelper<HID.HIDCollectionDescriptor>..ctor
	|-ArraySortHelper<HID.HIDElementDescriptor>..ctor
	|-ArraySortHelper<HIDParser.HIDReportData>..ctor
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>..ctor
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>..ctor
	|-ArraySortHelper<InputControlLayout.ControlItem>..ctor
	|-ArraySortHelper<InputTransformSpots.TransformSpot>..ctor
	|-ArraySortHelper<JsonParser.JsonValue>..ctor
	|-ArraySortHelper<LatencySimulator.Message>..ctor
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>..ctor
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>..ctor
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>..ctor
	|-ArraySortHelper<PlayingCard.CardData>..ctor
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>..ctor
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..ctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>..ctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>..ctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>..ctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>..ctor
	|-ArraySortHelper<RegexCharClass.SingleRange>..ctor
	|-ArraySortHelper<RenderChain.RenderNodeData>..ctor
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>..ctor
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>..ctor
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>..ctor
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>..ctor
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>..ctor
	|-ArraySortHelper<RigidbodyPrediction.MoveData>..ctor
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>..ctor
	|-ArraySortHelper<SVGDocument.NodeReferenceData>..ctor
	|-ArraySortHelper<SVGDocument.NodeWithParent>..ctor
	|-ArraySortHelper<SVGDocument.PostponedClip>..ctor
	|-ArraySortHelper<SVGDocument.PostponedStopData>..ctor
	|-ArraySortHelper<ServerSocket.ConnectionChange>..ctor
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>..ctor
	|-ArraySortHelper<ShadowUtility.Edge>..ctor
	|-ArraySortHelper<StructySync.ChangeData>..ctor
	|-ArraySortHelper<SyncStopwatch.ChangeData>..ctor
	|-ArraySortHelper<SyncTimer.ChangeData>..ctor
	|-ArraySortHelper<TargetStateListener.Callback>..ctor
	|-ArraySortHelper<TemplateAsset.AttributeOverride>..ctor
	|-ArraySortHelper<TextSettings.FontReferenceMap>..ctor
	|-ArraySortHelper<TextureBlitter.BlitInfo>..ctor
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>..ctor
	|-ArraySortHelper<TextureRegistry.TextureInfo>..ctor
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>..ctor
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>..ctor
	|-ArraySortHelper<TransportManager.DisconnectingClient>..ctor
	|-ArraySortHelper<UIRStylePainter.Entry>..ctor
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>..ctor
	|-ArraySortHelper<UIRenderDevice.AllocToFree>..ctor
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>..ctor
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>..ctor
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>..ctor
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>..ctor
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>..ctor
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>..ctor
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..ctor
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>..ctor
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>..ctor
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>..ctor
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>..ctor
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10189E0 Offset: 0x10173E0 VA: 0x1810189E0
	|-ArraySortHelper<ArraySegment<byte>>..cctor
	|-ArraySortHelper<SyncList.CachedOnChange<int>>..cctor
	|-ArraySortHelper<SyncList.ChangeData<int>>..cctor
	|-ArraySortHelper<IntervalTree.Entry<object>>..cctor
	|-ArraySortHelper<KeyValuePair<int, object>>..cctor
	|-ArraySortHelper<KeyValuePair<object, bool>>..cctor
	|-ArraySortHelper<KeyValuePair<object, char>>..cctor
	|-ArraySortHelper<KeyValuePair<object, object>>..cctor
	|-ArraySortHelper<KeyValuePair<object, JsonParser.JsonValue>>..cctor
	|-ArraySortHelper<KeyValuePair<PropertyName, object>>..cctor
	|-ArraySortHelper<KeyValuePair<Rect, object>>..cctor
	|-ArraySortHelper<NativeArray<ConvertMeshJobData>>..cctor
	|-ArraySortHelper<NativeArray<CopyClosingMeshJobData>>..cctor
	|-ArraySortHelper<NativeArray<NudgeJobData>>..cctor
	|-ArraySortHelper<NativeSlice<ConvertMeshJobData>>..cctor
	|-ArraySortHelper<NativeSlice<CopyClosingMeshJobData>>..cctor
	|-ArraySortHelper<NativeSlice<NudgeJobData>>..cctor
	|-ArraySortHelper<Nullable<DateTime>>..cctor
	|-ArraySortHelper<Nullable<Decimal>>..cctor
	|-ArraySortHelper<TempAllocator.Page<ushort>>..cctor
	|-ArraySortHelper<TempAllocator.Page<Vertex>>..cctor
	|-ArraySortHelper<RenderGraphResourcePool.ResourceLogInfo<object>>..cctor
	|-ArraySortHelper<StructMultiKey<object, object>>..cctor
	|-ArraySortHelper<SubArray<int>>..cctor
	|-ArraySortHelper<ValueTuple<int, int>>..cctor
	|-ArraySortHelper<ValueTuple<int, object>>..cctor
	|-ArraySortHelper<ValueTuple<int, Scene>>..cctor
	|-ArraySortHelper<ValueTuple<int, Vector2Int>>..cctor
	|-ArraySortHelper<ValueTuple<object, ValueTuple<object, int>>>..cctor
	|-ArraySortHelper<ValueTuple<object, object>>..cctor
	|-ArraySortHelper<AnimatorClipInfo>..cctor
	|-ArraySortHelper<AsyncGPUReadbackRequest>..cctor
	|-ArraySortHelper<BezierContour>..cctor
	|-ArraySortHelper<BezierPathSegment>..cctor
	|-ArraySortHelper<BezierSegment>..cctor
	|-ArraySortHelper<bool>..cctor
	|-ArraySortHelper<Bounds>..cctor
	|-ArraySortHelper<byte>..cctor
	|-ArraySortHelper<CGSpot>..cctor
	|-ArraySortHelper<char>..cctor
	|-ArraySortHelper<Color>..cctor
	|-ArraySortHelper<Color32>..cctor
	|-ArraySortHelper<CombineInstance>..cctor
	|-ArraySortHelper<ComputedTransitionProperty>..cctor
	|-ArraySortHelper<Connection>..cctor
	|-ArraySortHelper<ContourVertex>..cctor
	|-ArraySortHelper<ControlPointOption>..cctor
	|-ArraySortHelper<CoordinateFootprintTilePair>..cctor
	|-ArraySortHelper<CoordinateProceduralTilePair>..cctor
	|-ArraySortHelper<CoordinateStorageFootprintTilePair>..cctor
	|-ArraySortHelper<CoordinateStorageTilePair>..cctor
	|-ArraySortHelper<CoordinateTilePair>..cctor
	|-ArraySortHelper<DateTime>..cctor
	|-ArraySortHelper<DateTimeOffset>..cctor
	|-ArraySortHelper<Decimal>..cctor
	|-ArraySortHelper<DisplayInfo>..cctor
	|-ArraySortHelper<double>..cctor
	|-ArraySortHelper<DoublePoint>..cctor
	|-ArraySortHelper<DoublePoint>..cctor
	|-ArraySortHelper<DualPrefab>..cctor
	|-ArraySortHelper<DuplicateSamplePoint>..cctor
	|-ArraySortHelper<EasingFunction>..cctor
	|-ArraySortHelper<Entry>..cctor
	|-ArraySortHelper<EventSummary>..cctor
	|-ArraySortHelper<FrameTimeSample>..cctor
	|-ArraySortHelper<GlyphPairAdjustmentRecord>..cctor
	|-ArraySortHelper<GlyphRect>..cctor
	|-ArraySortHelper<Guid>..cctor
	|-ArraySortHelper<InputBinding>..cctor
	|-ArraySortHelper<InputDeviceDescription>..cctor
	|-ArraySortHelper<InputEventPtr>..cctor
	|-ArraySortHelper<short>..cctor
	|-ArraySortHelper<Int3>..cctor
	|-ArraySortHelper<int>..cctor
	|-ArraySortHelper<Int32Enum>..cctor
	|-ArraySortHelper<long>..cctor
	|-ArraySortHelper<IntPoint>..cctor
	|-ArraySortHelper<IntPoint>..cctor
	|-ArraySortHelper<IntRect>..cctor
	|-ArraySortHelper<IntRegion>..cctor
	|-ArraySortHelper<InternedString>..cctor
	|-ArraySortHelper<InterpretedFrameInfo>..cctor
	|-ArraySortHelper<IntervalTreeNode>..cctor
	|-ArraySortHelper<JsonPosition>..cctor
	|-ArraySortHelper<Label>..cctor
	|-ArraySortHelper<LigatureSubstitutionRecord>..cctor
	|-ArraySortHelper<LigatureSubstitutionRecord>..cctor
	|-ArraySortHelper<ManipulatorActivationFilter>..cctor
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>..cctor
	|-ArraySortHelper<MarkToBaseAdjustmentRecord>..cctor
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>..cctor
	|-ArraySortHelper<MarkToMarkAdjustmentRecord>..cctor
	|-ArraySortHelper<Matrix4x4>..cctor
	|-ArraySortHelper<MultipleSubstitutionRecord>..cctor
	|-ArraySortHelper<MultipleSubstitutionRecord>..cctor
	|-ArraySortHelper<NameAndParameters>..cctor
	|-ArraySortHelper<NamedValue>..cctor
	|-ArraySortHelper<NavMeshBuildMarkup>..cctor
	|-ArraySortHelper<NavMeshBuildSource>..cctor
	|-ArraySortHelper<object>..cctor
	|-ArraySortHelper<Playable>..cctor
	|-ArraySortHelper<PlayableBinding>..cctor
	|-ArraySortHelper<PlayerLoopSystem>..cctor
	|-ArraySortHelper<PlayerLoopSystemInternal>..cctor
	|-ArraySortHelper<Quaternion>..cctor
	|-ArraySortHelper<RangePositionInfo>..cctor
	|-ArraySortHelper<RaycastHit>..cctor
	|-ArraySortHelper<RaycastHit2D>..cctor
	|-ArraySortHelper<RaycastResult>..cctor
	|-ArraySortHelper<RectInt>..cctor
	|-ArraySortHelper<RenderTargetIdentifier>..cctor
	|-ArraySortHelper<RendererList>..cctor
	|-ArraySortHelper<RendererListHandle>..cctor
	|-ArraySortHelper<Resolution>..cctor
	|-ArraySortHelper<ResourceHandle>..cctor
	|-ArraySortHelper<RuleMatcher>..cctor
	|-ArraySortHelper<sbyte>..cctor
	|-ArraySortHelper<SamplePointUData>..cctor
	|-ArraySortHelper<SamplePointsPatch>..cctor
	|-ArraySortHelper<Scene>..cctor
	|-ArraySortHelper<SelectorMatchRecord>..cctor
	|-ArraySortHelper<ShaderTagId>..cctor
	|-ArraySortHelper<float>..cctor
	|-ArraySortHelper<StylePropertyName>..cctor
	|-ArraySortHelper<StylePropertyValue>..cctor
	|-ArraySortHelper<StyleSelectorPart>..cctor
	|-ArraySortHelper<StyleSyntaxToken>..cctor
	|-ArraySortHelper<StyleValue>..cctor
	|-ArraySortHelper<StyleValueManaged>..cctor
	|-ArraySortHelper<StyleVariable>..cctor
	|-ArraySortHelper<Substring>..cctor
	|-ArraySortHelper<TimeSpan>..cctor
	|-ArraySortHelper<TimeValue>..cctor
	|-ArraySortHelper<TreeViewItemWrapper>..cctor
	|-ArraySortHelper<UICharInfo>..cctor
	|-ArraySortHelper<UILineInfo>..cctor
	|-ArraySortHelper<UIVertex>..cctor
	|-ArraySortHelper<ushort>..cctor
	|-ArraySortHelper<uint>..cctor
	|-ArraySortHelper<UInt32Enum>..cctor
	|-ArraySortHelper<ulong>..cctor
	|-ArraySortHelper<UShort2>..cctor
	|-ArraySortHelper<UnloadedScene>..cctor
	|-ArraySortHelper<UsageHint>..cctor
	|-ArraySortHelper<Vector2>..cctor
	|-ArraySortHelper<Vector3>..cctor
	|-ArraySortHelper<Vector4>..cctor
	|-ArraySortHelper<VoxelContour>..cctor
	|-ArraySortHelper<Win32_IP_ADAPTER_ADDRESSES>..cctor
	|-ArraySortHelper<X509ChainStatus>..cctor
	|-ArraySortHelper<XRFeatureDescriptor>..cctor
	|-ArraySortHelper<XRView>..cctor
	|-ArraySortHelper<ZipGenericExtraField>..cctor
	|-ArraySortHelper<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..cctor
	|-ArraySortHelper<AdvancedSmooth.Turn>..cctor
	|-ArraySortHelper<AnimationOutputWeightProcessor.WeightInfo>..cctor
	|-ArraySortHelper<AvatarSettings.LayerSetting>..cctor
	|-ArraySortHelper<BeforeRenderHelper.OrderBlock>..cctor
	|-ArraySortHelper<BitmapAllocator32.Page>..cctor
	|-ArraySortHelper<CameraState.CustomBlendable>..cctor
	|-ArraySortHelper<CinemachineClearShot.Pair>..cctor
	|-ArraySortHelper<CinemachineStateDrivenCamera.HashPair>..cctor
	|-ArraySortHelper<ClipperLib.DoublePoint>..cctor
	|-ArraySortHelper<ClipperLib.IntPoint>..cctor
	|-ArraySortHelper<ConfinerOven.PolygonSolution>..cctor
	|-ArraySortHelper<DecalEntityIndexer.DecalEntityItem>..cctor
	|-ArraySortHelper<DecalEntityManager.CombinedChunks>..cctor
	|-ArraySortHelper<FocusController.FocusedElement>..cctor
	|-ArraySortHelper<FrameTimingsHUDDisplay.FrameTimingPoint>..cctor
	|-ArraySortHelper<Funnel.PathPart>..cctor
	|-ArraySortHelper<GodRaysRenderPass.VisibleLightRemap>..cctor
	|-ArraySortHelper<HID.HIDCollectionDescriptor>..cctor
	|-ArraySortHelper<HID.HIDElementDescriptor>..cctor
	|-ArraySortHelper<HIDParser.HIDReportData>..cctor
	|-ArraySortHelper<HeatmapManager.PropertyRegionReference>..cctor
	|-ArraySortHelper<InputActionMap.BindingOverrideJson>..cctor
	|-ArraySortHelper<InputControlLayout.ControlItem>..cctor
	|-ArraySortHelper<InputTransformSpots.TransformSpot>..cctor
	|-ArraySortHelper<JsonParser.JsonValue>..cctor
	|-ArraySortHelper<LatencySimulator.Message>..cctor
	|-ArraySortHelper<MultiColumnCollectionHeader.SortedColumnState>..cctor
	|-ArraySortHelper<NativeMethods.TASKDIALOG_BUTTON>..cctor
	|-ArraySortHelper<NetworkAnimator.TriggerUpdate>..cctor
	|-ArraySortHelper<OutlineEffect.OutlineTargetGroup>..cctor
	|-ArraySortHelper<PlayingCard.CardData>..cctor
	|-ArraySortHelper<ProbeBrickIndex.ReservedBrick>..cctor
	|-ArraySortHelper<ProbeBrickPool.BrickChunkAlloc>..cctor
	|-ArraySortHelper<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..cctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableBoundItem>..cctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializableHasPVItem>..cctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVBakeSettings>..cctor
	|-ArraySortHelper<ProbeVolumeSceneData.SerializablePVProfile>..cctor
	|-ArraySortHelper<RegexCharClass.SingleRange>..cctor
	|-ArraySortHelper<RenderChain.RenderNodeData>..cctor
	|-ArraySortHelper<RenderGraphDebugData.PassDebugData>..cctor
	|-ArraySortHelper<RenderGraphDebugData.ResourceDebugData>..cctor
	|-ArraySortHelper<RetainedGizmos.MeshWithHash>..cctor
	|-ArraySortHelper<RigidbodyPauser.Rigidbody2DData>..cctor
	|-ArraySortHelper<RigidbodyPauser.RigidbodyData>..cctor
	|-ArraySortHelper<RigidbodyPrediction.MoveData>..cctor
	|-ArraySortHelper<SVGDocument.HierarchyUpdate>..cctor
	|-ArraySortHelper<SVGDocument.NodeReferenceData>..cctor
	|-ArraySortHelper<SVGDocument.NodeWithParent>..cctor
	|-ArraySortHelper<SVGDocument.PostponedClip>..cctor
	|-ArraySortHelper<SVGDocument.PostponedStopData>..cctor
	|-ArraySortHelper<ServerSocket.ConnectionChange>..cctor
	|-ArraySortHelper<SewerMushroomLocation.MushroomLocationData>..cctor
	|-ArraySortHelper<ShadowUtility.Edge>..cctor
	|-ArraySortHelper<StructySync.ChangeData>..cctor
	|-ArraySortHelper<SyncStopwatch.ChangeData>..cctor
	|-ArraySortHelper<SyncTimer.ChangeData>..cctor
	|-ArraySortHelper<TargetStateListener.Callback>..cctor
	|-ArraySortHelper<TemplateAsset.AttributeOverride>..cctor
	|-ArraySortHelper<TextSettings.FontReferenceMap>..cctor
	|-ArraySortHelper<TextureBlitter.BlitInfo>..cctor
	|-ArraySortHelper<TexturePacker_JsonArray.Frame>..cctor
	|-ArraySortHelper<TextureRegistry.TextureInfo>..cctor
	|-ArraySortHelper<TimeNotificationBehaviour.NotificationEntry>..cctor
	|-ArraySortHelper<TrackedDeviceRaycaster.RaycastHitData>..cctor
	|-ArraySortHelper<TransportManager.DisconnectingClient>..cctor
	|-ArraySortHelper<UIRStylePainter.Entry>..cctor
	|-ArraySortHelper<UIRStylePainter.RepeatRectUV>..cctor
	|-ArraySortHelper<UIRenderDevice.AllocToFree>..cctor
	|-ArraySortHelper<UIRenderDevice.AllocToUpdate>..cctor
	|-ArraySortHelper<UnitySynchronizationContext.WorkRequest>..cctor
	|-ArraySortHelper<VisualTreeAsset.AssetEntry>..cctor
	|-ArraySortHelper<VisualTreeAsset.SlotDefinition>..cctor
	|-ArraySortHelper<VisualTreeAsset.SlotUsageEntry>..cctor
	|-ArraySortHelper<VisualTreeAsset.UsingEntry>..cctor
	|-ArraySortHelper<VisualTreeAsset.UxmlObjectEntry>..cctor
	|-ArraySortHelper<XmlSchemaObjectTable.XmlSchemaObjectEntry>..cctor
	|-ArraySortHelper<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..cctor
	|-ArraySortHelper<DebugUI.Foldout.ContextMenuItem>..cctor
	|-ArraySortHelper<InputControlLayout.Collection.LayoutMatcher>..cctor
	|-ArraySortHelper<InstructionList.DebugView.InstructionView>..cctor
	|-ArraySortHelper<MultiColumnCollectionHeader.ViewState.ColumnState>..cctor
	|-ArraySortHelper<TargetPositionCache.CacheCurve.Item>..cctor
	|-ArraySortHelper<TargetPositionCache.CacheEntry.RecordingItem>..cctor
	|
	|-RVA: 0x1018AD0 Offset: 0x10174D0 VA: 0x181018AD0
	|-ArraySortHelper<__Il2CppFullySharedGenericType>..cctor
	*/
}
