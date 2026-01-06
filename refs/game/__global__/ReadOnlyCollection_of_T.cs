public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 4953
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113DE30 Offset: 0x113C830 VA: 0x18113DE30
	|-ReadOnlyCollection<ArraySegment<byte>>..ctor
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>..ctor
	|-ReadOnlyCollection<SyncList.ChangeData<int>>..ctor
	|-ReadOnlyCollection<IntervalTree.Entry<object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<int, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, bool>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, char>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>..ctor
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>..ctor
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>..ctor
	|-ReadOnlyCollection<Nullable<DateTime>>..ctor
	|-ReadOnlyCollection<Nullable<Decimal>>..ctor
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>..ctor
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>..ctor
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|-ReadOnlyCollection<StructMultiKey<object, object>>..ctor
	|-ReadOnlyCollection<SubArray<int>>..ctor
	|-ReadOnlyCollection<ValueTuple<int, int>>..ctor
	|-ReadOnlyCollection<ValueTuple<int, object>>..ctor
	|-ReadOnlyCollection<ValueTuple<int, Scene>>..ctor
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>..ctor
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-ReadOnlyCollection<ValueTuple<object, object>>..ctor
	|-ReadOnlyCollection<AnimatorClipInfo>..ctor
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>..ctor
	|-ReadOnlyCollection<BezierContour>..ctor
	|-ReadOnlyCollection<BezierPathSegment>..ctor
	|-ReadOnlyCollection<BezierSegment>..ctor
	|-ReadOnlyCollection<bool>..ctor
	|-ReadOnlyCollection<Bounds>..ctor
	|-ReadOnlyCollection<byte>..ctor
	|-ReadOnlyCollection<CGSpot>..ctor
	|-ReadOnlyCollection<char>..ctor
	|-ReadOnlyCollection<Color>..ctor
	|-ReadOnlyCollection<Color32>..ctor
	|-ReadOnlyCollection<CombineInstance>..ctor
	|-ReadOnlyCollection<ComputedTransitionProperty>..ctor
	|-ReadOnlyCollection<Connection>..ctor
	|-ReadOnlyCollection<ContourVertex>..ctor
	|-ReadOnlyCollection<ControlPointOption>..ctor
	|-ReadOnlyCollection<CoordinateFootprintTilePair>..ctor
	|-ReadOnlyCollection<CoordinateProceduralTilePair>..ctor
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>..ctor
	|-ReadOnlyCollection<CoordinateStorageTilePair>..ctor
	|-ReadOnlyCollection<CoordinateTilePair>..ctor
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|-ReadOnlyCollection<DateTime>..ctor
	|-ReadOnlyCollection<DateTimeOffset>..ctor
	|-ReadOnlyCollection<Decimal>..ctor
	|-ReadOnlyCollection<DisplayInfo>..ctor
	|-ReadOnlyCollection<double>..ctor
	|-ReadOnlyCollection<DoublePoint>..ctor
	|-ReadOnlyCollection<DoublePoint>..ctor
	|-ReadOnlyCollection<DualPrefab>..ctor
	|-ReadOnlyCollection<DuplicateSamplePoint>..ctor
	|-ReadOnlyCollection<EasingFunction>..ctor
	|-ReadOnlyCollection<Entry>..ctor
	|-ReadOnlyCollection<EventSummary>..ctor
	|-ReadOnlyCollection<FrameTimeSample>..ctor
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>..ctor
	|-ReadOnlyCollection<GlyphRect>..ctor
	|-ReadOnlyCollection<Guid>..ctor
	|-ReadOnlyCollection<InputBinding>..ctor
	|-ReadOnlyCollection<InputDeviceDescription>..ctor
	|-ReadOnlyCollection<InputEventPtr>..ctor
	|-ReadOnlyCollection<short>..ctor
	|-ReadOnlyCollection<Int3>..ctor
	|-ReadOnlyCollection<int>..ctor
	|-ReadOnlyCollection<Int32Enum>..ctor
	|-ReadOnlyCollection<long>..ctor
	|-ReadOnlyCollection<IntPoint>..ctor
	|-ReadOnlyCollection<IntPoint>..ctor
	|-ReadOnlyCollection<IntRect>..ctor
	|-ReadOnlyCollection<IntRegion>..ctor
	|-ReadOnlyCollection<InternedString>..ctor
	|-ReadOnlyCollection<InterpretedFrameInfo>..ctor
	|-ReadOnlyCollection<IntervalTreeNode>..ctor
	|-ReadOnlyCollection<JsonPosition>..ctor
	|-ReadOnlyCollection<Label>..ctor
	|-ReadOnlyCollection<LigatureSubstitutionRecord>..ctor
	|-ReadOnlyCollection<LigatureSubstitutionRecord>..ctor
	|-ReadOnlyCollection<ManipulatorActivationFilter>..ctor
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>..ctor
	|-ReadOnlyCollection<Matrix4x4>..ctor
	|-ReadOnlyCollection<MultipleSubstitutionRecord>..ctor
	|-ReadOnlyCollection<MultipleSubstitutionRecord>..ctor
	|-ReadOnlyCollection<NameAndParameters>..ctor
	|-ReadOnlyCollection<NamedValue>..ctor
	|-ReadOnlyCollection<NavMeshBuildMarkup>..ctor
	|-ReadOnlyCollection<NavMeshBuildSource>..ctor
	|-ReadOnlyCollection<object>..ctor
	|-ReadOnlyCollection<Playable>..ctor
	|-ReadOnlyCollection<PlayableBinding>..ctor
	|-ReadOnlyCollection<PlayerLoopSystem>..ctor
	|-ReadOnlyCollection<PlayerLoopSystemInternal>..ctor
	|-ReadOnlyCollection<Quaternion>..ctor
	|-ReadOnlyCollection<RangePositionInfo>..ctor
	|-ReadOnlyCollection<RaycastHit>..ctor
	|-ReadOnlyCollection<RaycastHit2D>..ctor
	|-ReadOnlyCollection<RaycastResult>..ctor
	|-ReadOnlyCollection<RectInt>..ctor
	|-ReadOnlyCollection<RenderTargetIdentifier>..ctor
	|-ReadOnlyCollection<RendererList>..ctor
	|-ReadOnlyCollection<RendererListHandle>..ctor
	|-ReadOnlyCollection<Resolution>..ctor
	|-ReadOnlyCollection<ResourceHandle>..ctor
	|-ReadOnlyCollection<RuleMatcher>..ctor
	|-ReadOnlyCollection<sbyte>..ctor
	|-ReadOnlyCollection<SamplePointUData>..ctor
	|-ReadOnlyCollection<SamplePointsPatch>..ctor
	|-ReadOnlyCollection<Scene>..ctor
	|-ReadOnlyCollection<SelectorMatchRecord>..ctor
	|-ReadOnlyCollection<ShaderTagId>..ctor
	|-ReadOnlyCollection<float>..ctor
	|-ReadOnlyCollection<StylePropertyName>..ctor
	|-ReadOnlyCollection<StylePropertyValue>..ctor
	|-ReadOnlyCollection<StyleSelectorPart>..ctor
	|-ReadOnlyCollection<StyleSyntaxToken>..ctor
	|-ReadOnlyCollection<StyleValue>..ctor
	|-ReadOnlyCollection<StyleValueManaged>..ctor
	|-ReadOnlyCollection<StyleVariable>..ctor
	|-ReadOnlyCollection<Substring>..ctor
	|-ReadOnlyCollection<TimeSpan>..ctor
	|-ReadOnlyCollection<TimeValue>..ctor
	|-ReadOnlyCollection<TreeViewItemWrapper>..ctor
	|-ReadOnlyCollection<UICharInfo>..ctor
	|-ReadOnlyCollection<UILineInfo>..ctor
	|-ReadOnlyCollection<UIVertex>..ctor
	|-ReadOnlyCollection<ushort>..ctor
	|-ReadOnlyCollection<uint>..ctor
	|-ReadOnlyCollection<UInt32Enum>..ctor
	|-ReadOnlyCollection<ulong>..ctor
	|-ReadOnlyCollection<UShort2>..ctor
	|-ReadOnlyCollection<UnloadedScene>..ctor
	|-ReadOnlyCollection<UsageHint>..ctor
	|-ReadOnlyCollection<Vector2>..ctor
	|-ReadOnlyCollection<Vector3>..ctor
	|-ReadOnlyCollection<Vector4>..ctor
	|-ReadOnlyCollection<VoxelContour>..ctor
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|-ReadOnlyCollection<X509ChainStatus>..ctor
	|-ReadOnlyCollection<XRFeatureDescriptor>..ctor
	|-ReadOnlyCollection<XRView>..ctor
	|-ReadOnlyCollection<ZipGenericExtraField>..ctor
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..ctor
	|-ReadOnlyCollection<AdvancedSmooth.Turn>..ctor
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>..ctor
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>..ctor
	|-ReadOnlyCollection<BitmapAllocator32.Page>..ctor
	|-ReadOnlyCollection<CameraState.CustomBlendable>..ctor
	|-ReadOnlyCollection<CinemachineClearShot.Pair>..ctor
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>..ctor
	|-ReadOnlyCollection<ClipperLib.DoublePoint>..ctor
	|-ReadOnlyCollection<ClipperLib.IntPoint>..ctor
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>..ctor
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>..ctor
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>..ctor
	|-ReadOnlyCollection<FocusController.FocusedElement>..ctor
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>..ctor
	|-ReadOnlyCollection<Funnel.PathPart>..ctor
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>..ctor
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>..ctor
	|-ReadOnlyCollection<HID.HIDElementDescriptor>..ctor
	|-ReadOnlyCollection<HIDParser.HIDReportData>..ctor
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>..ctor
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>..ctor
	|-ReadOnlyCollection<InputControlLayout.ControlItem>..ctor
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>..ctor
	|-ReadOnlyCollection<JsonParser.JsonValue>..ctor
	|-ReadOnlyCollection<LatencySimulator.Message>..ctor
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>..ctor
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>..ctor
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>..ctor
	|-ReadOnlyCollection<PlayingCard.CardData>..ctor
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>..ctor
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..ctor
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>..ctor
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>..ctor
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>..ctor
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>..ctor
	|-ReadOnlyCollection<RegexCharClass.SingleRange>..ctor
	|-ReadOnlyCollection<RenderChain.RenderNodeData>..ctor
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>..ctor
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>..ctor
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>..ctor
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>..ctor
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>..ctor
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>..ctor
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>..ctor
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>..ctor
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>..ctor
	|-ReadOnlyCollection<SVGDocument.PostponedClip>..ctor
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>..ctor
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>..ctor
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>..ctor
	|-ReadOnlyCollection<ShadowUtility.Edge>..ctor
	|-ReadOnlyCollection<StructySync.ChangeData>..ctor
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>..ctor
	|-ReadOnlyCollection<SyncTimer.ChangeData>..ctor
	|-ReadOnlyCollection<TargetStateListener.Callback>..ctor
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>..ctor
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>..ctor
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>..ctor
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>..ctor
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>..ctor
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>..ctor
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>..ctor
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>..ctor
	|-ReadOnlyCollection<UIRStylePainter.Entry>..ctor
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>..ctor
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>..ctor
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>..ctor
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..ctor
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>..ctor
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>..ctor
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>..ctor
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>..ctor
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113DE80 Offset: 0x113C880 VA: 0x18113DE80
	|-ReadOnlyCollection<ArraySegment<byte>>.get_Count
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.get_Count
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.get_Count
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, char>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.get_Count
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.get_Count
	|-ReadOnlyCollection<Nullable<DateTime>>.get_Count
	|-ReadOnlyCollection<Nullable<Decimal>>.get_Count
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.get_Count
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.get_Count
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Count
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Count
	|-ReadOnlyCollection<SubArray<int>>.get_Count
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Count
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Count
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.get_Count
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.get_Count
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.get_Count
	|-ReadOnlyCollection<ValueTuple<object, object>>.get_Count
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Count
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.get_Count
	|-ReadOnlyCollection<BezierContour>.get_Count
	|-ReadOnlyCollection<BezierPathSegment>.get_Count
	|-ReadOnlyCollection<BezierSegment>.get_Count
	|-ReadOnlyCollection<bool>.get_Count
	|-ReadOnlyCollection<Bounds>.get_Count
	|-ReadOnlyCollection<byte>.get_Count
	|-ReadOnlyCollection<CGSpot>.get_Count
	|-ReadOnlyCollection<char>.get_Count
	|-ReadOnlyCollection<Color>.get_Count
	|-ReadOnlyCollection<Color32>.get_Count
	|-ReadOnlyCollection<CombineInstance>.get_Count
	|-ReadOnlyCollection<ComputedTransitionProperty>.get_Count
	|-ReadOnlyCollection<Connection>.get_Count
	|-ReadOnlyCollection<ContourVertex>.get_Count
	|-ReadOnlyCollection<ControlPointOption>.get_Count
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.get_Count
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.get_Count
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.get_Count
	|-ReadOnlyCollection<CoordinateStorageTilePair>.get_Count
	|-ReadOnlyCollection<CoordinateTilePair>.get_Count
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|-ReadOnlyCollection<DateTime>.get_Count
	|-ReadOnlyCollection<DateTimeOffset>.get_Count
	|-ReadOnlyCollection<Decimal>.get_Count
	|-ReadOnlyCollection<DisplayInfo>.get_Count
	|-ReadOnlyCollection<double>.get_Count
	|-ReadOnlyCollection<DoublePoint>.get_Count
	|-ReadOnlyCollection<DoublePoint>.get_Count
	|-ReadOnlyCollection<DualPrefab>.get_Count
	|-ReadOnlyCollection<DuplicateSamplePoint>.get_Count
	|-ReadOnlyCollection<EasingFunction>.get_Count
	|-ReadOnlyCollection<Entry>.get_Count
	|-ReadOnlyCollection<EventSummary>.get_Count
	|-ReadOnlyCollection<FrameTimeSample>.get_Count
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<GlyphRect>.get_Count
	|-ReadOnlyCollection<Guid>.get_Count
	|-ReadOnlyCollection<InputBinding>.get_Count
	|-ReadOnlyCollection<InputDeviceDescription>.get_Count
	|-ReadOnlyCollection<InputEventPtr>.get_Count
	|-ReadOnlyCollection<short>.get_Count
	|-ReadOnlyCollection<Int3>.get_Count
	|-ReadOnlyCollection<int>.get_Count
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|-ReadOnlyCollection<long>.get_Count
	|-ReadOnlyCollection<IntPoint>.get_Count
	|-ReadOnlyCollection<IntPoint>.get_Count
	|-ReadOnlyCollection<IntRect>.get_Count
	|-ReadOnlyCollection<IntRegion>.get_Count
	|-ReadOnlyCollection<InternedString>.get_Count
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Count
	|-ReadOnlyCollection<IntervalTreeNode>.get_Count
	|-ReadOnlyCollection<JsonPosition>.get_Count
	|-ReadOnlyCollection<Label>.get_Count
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<ManipulatorActivationFilter>.get_Count
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<Matrix4x4>.get_Count
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<NameAndParameters>.get_Count
	|-ReadOnlyCollection<NamedValue>.get_Count
	|-ReadOnlyCollection<NavMeshBuildMarkup>.get_Count
	|-ReadOnlyCollection<NavMeshBuildSource>.get_Count
	|-ReadOnlyCollection<object>.get_Count
	|-ReadOnlyCollection<Playable>.get_Count
	|-ReadOnlyCollection<PlayableBinding>.get_Count
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Count
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Count
	|-ReadOnlyCollection<Quaternion>.get_Count
	|-ReadOnlyCollection<RangePositionInfo>.get_Count
	|-ReadOnlyCollection<RaycastHit>.get_Count
	|-ReadOnlyCollection<RaycastHit2D>.get_Count
	|-ReadOnlyCollection<RaycastResult>.get_Count
	|-ReadOnlyCollection<RectInt>.get_Count
	|-ReadOnlyCollection<RenderTargetIdentifier>.get_Count
	|-ReadOnlyCollection<RendererList>.get_Count
	|-ReadOnlyCollection<RendererListHandle>.get_Count
	|-ReadOnlyCollection<Resolution>.get_Count
	|-ReadOnlyCollection<ResourceHandle>.get_Count
	|-ReadOnlyCollection<RuleMatcher>.get_Count
	|-ReadOnlyCollection<sbyte>.get_Count
	|-ReadOnlyCollection<SamplePointUData>.get_Count
	|-ReadOnlyCollection<SamplePointsPatch>.get_Count
	|-ReadOnlyCollection<Scene>.get_Count
	|-ReadOnlyCollection<SelectorMatchRecord>.get_Count
	|-ReadOnlyCollection<ShaderTagId>.get_Count
	|-ReadOnlyCollection<float>.get_Count
	|-ReadOnlyCollection<StylePropertyName>.get_Count
	|-ReadOnlyCollection<StylePropertyValue>.get_Count
	|-ReadOnlyCollection<StyleSelectorPart>.get_Count
	|-ReadOnlyCollection<StyleSyntaxToken>.get_Count
	|-ReadOnlyCollection<StyleValue>.get_Count
	|-ReadOnlyCollection<StyleValueManaged>.get_Count
	|-ReadOnlyCollection<StyleVariable>.get_Count
	|-ReadOnlyCollection<Substring>.get_Count
	|-ReadOnlyCollection<TimeSpan>.get_Count
	|-ReadOnlyCollection<TimeValue>.get_Count
	|-ReadOnlyCollection<TreeViewItemWrapper>.get_Count
	|-ReadOnlyCollection<UICharInfo>.get_Count
	|-ReadOnlyCollection<UILineInfo>.get_Count
	|-ReadOnlyCollection<UIVertex>.get_Count
	|-ReadOnlyCollection<ushort>.get_Count
	|-ReadOnlyCollection<uint>.get_Count
	|-ReadOnlyCollection<UInt32Enum>.get_Count
	|-ReadOnlyCollection<ulong>.get_Count
	|-ReadOnlyCollection<UShort2>.get_Count
	|-ReadOnlyCollection<UnloadedScene>.get_Count
	|-ReadOnlyCollection<UsageHint>.get_Count
	|-ReadOnlyCollection<Vector2>.get_Count
	|-ReadOnlyCollection<Vector3>.get_Count
	|-ReadOnlyCollection<Vector4>.get_Count
	|-ReadOnlyCollection<VoxelContour>.get_Count
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.get_Count
	|-ReadOnlyCollection<X509ChainStatus>.get_Count
	|-ReadOnlyCollection<XRFeatureDescriptor>.get_Count
	|-ReadOnlyCollection<XRView>.get_Count
	|-ReadOnlyCollection<ZipGenericExtraField>.get_Count
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Count
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.get_Count
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.get_Count
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Count
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.get_Count
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Count
	|-ReadOnlyCollection<BitmapAllocator32.Page>.get_Count
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Count
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Count
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Count
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.get_Count
	|-ReadOnlyCollection<ClipperLib.IntPoint>.get_Count
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.get_Count
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.get_Count
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.get_Count
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Count
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.get_Count
	|-ReadOnlyCollection<Funnel.PathPart>.get_Count
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.get_Count
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.get_Count
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.get_Count
	|-ReadOnlyCollection<HIDParser.HIDReportData>.get_Count
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.get_Count
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.get_Count
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.get_Count
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.get_Count
	|-ReadOnlyCollection<JsonParser.JsonValue>.get_Count
	|-ReadOnlyCollection<LatencySimulator.Message>.get_Count
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.get_Count
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.get_Count
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.get_Count
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.get_Count
	|-ReadOnlyCollection<PlayingCard.CardData>.get_Count
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.get_Count
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.get_Count
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.get_Count
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.get_Count
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.get_Count
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.get_Count
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.get_Count
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Count
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.get_Count
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.get_Count
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.get_Count
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.get_Count
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.get_Count
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.get_Count
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.get_Count
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.get_Count
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.get_Count
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.get_Count
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.get_Count
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.get_Count
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.get_Count
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.get_Count
	|-ReadOnlyCollection<ShadowUtility.Edge>.get_Count
	|-ReadOnlyCollection<StructySync.ChangeData>.get_Count
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.get_Count
	|-ReadOnlyCollection<SyncTimer.ChangeData>.get_Count
	|-ReadOnlyCollection<TargetStateListener.Callback>.get_Count
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.get_Count
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.get_Count
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.get_Count
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Count
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.get_Count
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Count
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.get_Count
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.get_Count
	|-ReadOnlyCollection<UIRStylePainter.Entry>.get_Count
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.get_Count
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.get_Count
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.get_Count
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.get_Count
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.get_Count
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.get_Count
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.get_Count
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Count
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Count
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Count
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BC10 Offset: 0x112A610 VA: 0x18112BC10
	|-ReadOnlyCollection<ArraySegment<byte>>.get_Item
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, char>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.get_Item
	|-ReadOnlyCollection<Nullable<DateTime>>.get_Item
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Item
	|-ReadOnlyCollection<SubArray<int>>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, object>>.get_Item
	|-ReadOnlyCollection<ValueTuple<object, object>>.get_Item
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.get_Item
	|-ReadOnlyCollection<BezierContour>.get_Item
	|-ReadOnlyCollection<Color>.get_Item
	|-ReadOnlyCollection<Connection>.get_Item
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.get_Item
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.get_Item
	|-ReadOnlyCollection<CoordinateStorageTilePair>.get_Item
	|-ReadOnlyCollection<CoordinateTilePair>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.get_Item
	|-ReadOnlyCollection<Decimal>.get_Item
	|-ReadOnlyCollection<DoublePoint>.get_Item
	|-ReadOnlyCollection<DoublePoint>.get_Item
	|-ReadOnlyCollection<DualPrefab>.get_Item
	|-ReadOnlyCollection<Entry>.get_Item
	|-ReadOnlyCollection<EventSummary>.get_Item
	|-ReadOnlyCollection<GlyphRect>.get_Item
	|-ReadOnlyCollection<Guid>.get_Item
	|-ReadOnlyCollection<IntPoint>.get_Item
	|-ReadOnlyCollection<IntRect>.get_Item
	|-ReadOnlyCollection<InternedString>.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<Playable>.get_Item
	|-ReadOnlyCollection<Quaternion>.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.get_Item
	|-ReadOnlyCollection<RectInt>.get_Item
	|-ReadOnlyCollection<Resolution>.get_Item
	|-ReadOnlyCollection<RuleMatcher>.get_Item
	|-ReadOnlyCollection<SamplePointUData>.get_Item
	|-ReadOnlyCollection<StylePropertyName>.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.get_Item
	|-ReadOnlyCollection<Substring>.get_Item
	|-ReadOnlyCollection<UILineInfo>.get_Item
	|-ReadOnlyCollection<UnloadedScene>.get_Item
	|-ReadOnlyCollection<Vector4>.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.get_Item
	|-ReadOnlyCollection<ZipGenericExtraField>.get_Item
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Item
	|-ReadOnlyCollection<CameraState.CustomBlendable>.get_Item
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.get_Item
	|-ReadOnlyCollection<ClipperLib.IntPoint>.get_Item
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Item
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.get_Item
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.get_Item
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.get_Item
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.get_Item
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.get_Item
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.get_Item
	|-ReadOnlyCollection<TargetStateListener.Callback>.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.get_Item
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.get_Item
	|
	|-RVA: 0x112BE70 Offset: 0x112A870 VA: 0x18112BE70
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.get_Item
	|-ReadOnlyCollection<DuplicateSamplePoint>.get_Item
	|-ReadOnlyCollection<Int3>.get_Item
	|-ReadOnlyCollection<IntRegion>.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.get_Item
	|-ReadOnlyCollection<UICharInfo>.get_Item
	|-ReadOnlyCollection<Vector3>.get_Item
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.get_Item
	|-ReadOnlyCollection<HIDParser.HIDReportData>.get_Item
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.get_Item
	|-ReadOnlyCollection<SyncTimer.ChangeData>.get_Item
	|
	|-RVA: 0x112BB90 Offset: 0x112A590 VA: 0x18112BB90
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.get_Item
	|-ReadOnlyCollection<Nullable<Decimal>>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.get_Item
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.get_Item
	|-ReadOnlyCollection<BezierPathSegment>.get_Item
	|-ReadOnlyCollection<Bounds>.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.get_Item
	|-ReadOnlyCollection<ContourVertex>.get_Item
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.get_Item
	|-ReadOnlyCollection<FrameTimeSample>.get_Item
	|-ReadOnlyCollection<IntervalTreeNode>.get_Item
	|-ReadOnlyCollection<JsonPosition>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<NameAndParameters>.get_Item
	|-ReadOnlyCollection<NamedValue>.get_Item
	|-ReadOnlyCollection<RendererList>.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.get_Item
	|-ReadOnlyCollection<StyleValue>.get_Item
	|-ReadOnlyCollection<StyleVariable>.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.get_Item
	|-ReadOnlyCollection<XRFeatureDescriptor>.get_Item
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.get_Item
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.get_Item
	|-ReadOnlyCollection<LatencySimulator.Message>.get_Item
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.get_Item
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.get_Item
	|-ReadOnlyCollection<StructySync.ChangeData>.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.get_Item
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.get_Item
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.get_Item
	|
	|-RVA: 0x112BD70 Offset: 0x112A770 VA: 0x18112BD70
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.get_Item
	|-ReadOnlyCollection<RaycastResult>.get_Item
	|-ReadOnlyCollection<UIRStylePainter.Entry>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.get_Item
	|
	|-RVA: 0x112BE10 Offset: 0x112A810 VA: 0x18112BE10
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.get_Item
	|-ReadOnlyCollection<AnimatorClipInfo>.get_Item
	|-ReadOnlyCollection<bool>.get_Item
	|-ReadOnlyCollection<byte>.get_Item
	|-ReadOnlyCollection<char>.get_Item
	|-ReadOnlyCollection<Color32>.get_Item
	|-ReadOnlyCollection<DateTime>.get_Item
	|-ReadOnlyCollection<EasingFunction>.get_Item
	|-ReadOnlyCollection<InputEventPtr>.get_Item
	|-ReadOnlyCollection<short>.get_Item
	|-ReadOnlyCollection<int>.get_Item
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|-ReadOnlyCollection<long>.get_Item
	|-ReadOnlyCollection<object>.get_Item
	|-ReadOnlyCollection<RendererListHandle>.get_Item
	|-ReadOnlyCollection<ResourceHandle>.get_Item
	|-ReadOnlyCollection<sbyte>.get_Item
	|-ReadOnlyCollection<SamplePointsPatch>.get_Item
	|-ReadOnlyCollection<Scene>.get_Item
	|-ReadOnlyCollection<ShaderTagId>.get_Item
	|-ReadOnlyCollection<TimeSpan>.get_Item
	|-ReadOnlyCollection<TimeValue>.get_Item
	|-ReadOnlyCollection<ushort>.get_Item
	|-ReadOnlyCollection<uint>.get_Item
	|-ReadOnlyCollection<UInt32Enum>.get_Item
	|-ReadOnlyCollection<ulong>.get_Item
	|-ReadOnlyCollection<UShort2>.get_Item
	|-ReadOnlyCollection<UsageHint>.get_Item
	|-ReadOnlyCollection<Vector2>.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.get_Item
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.get_Item
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.get_Item
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.get_Item
	|-ReadOnlyCollection<PlayingCard.CardData>.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.get_Item
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.get_Item
	|
	|-RVA: 0x112BEF0 Offset: 0x112A8F0 VA: 0x18112BEF0
	|-ReadOnlyCollection<BezierSegment>.get_Item
	|-ReadOnlyCollection<NavMeshBuildMarkup>.get_Item
	|-ReadOnlyCollection<PlayableBinding>.get_Item
	|-ReadOnlyCollection<VoxelContour>.get_Item
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.get_Item
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.get_Item
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.get_Item
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Item
	|
	|-RVA: 0x112BCE0 Offset: 0x112A6E0 VA: 0x18112BCE0
	|-ReadOnlyCollection<CGSpot>.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<RaycastHit>.get_Item
	|
	|-RVA: 0x112BF70 Offset: 0x112A970 VA: 0x18112BF70
	|-ReadOnlyCollection<CombineInstance>.get_Item
	|
	|-RVA: 0x113EB90 Offset: 0x113D590 VA: 0x18113EB90
	|-ReadOnlyCollection<ControlPointOption>.get_Item
	|-ReadOnlyCollection<RaycastHit2D>.get_Item
	|-ReadOnlyCollection<Funnel.PathPart>.get_Item
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.get_Item
	|
	|-RVA: 0x113EA50 Offset: 0x113D450 VA: 0x18113EA50
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|-ReadOnlyCollection<DisplayInfo>.get_Item
	|-ReadOnlyCollection<IntPoint>.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.get_Item
	|
	|-RVA: 0x113ECA0 Offset: 0x113D6A0 VA: 0x18113ECA0
	|-ReadOnlyCollection<double>.get_Item
	|-ReadOnlyCollection<float>.get_Item
	|
	|-RVA: 0x113EAE0 Offset: 0x113D4E0 VA: 0x18113EAE0
	|-ReadOnlyCollection<InputBinding>.get_Item
	|
	|-RVA: 0x113EC10 Offset: 0x113D610 VA: 0x18113EC10
	|-ReadOnlyCollection<InputDeviceDescription>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.get_Item
	|
	|-RVA: 0x114FB60 Offset: 0x114E560 VA: 0x18114FB60
	|-ReadOnlyCollection<Label>.get_Item
	|-ReadOnlyCollection<PlayerLoopSystem>.get_Item
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.get_Item
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.get_Item
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.get_Item
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.get_Item
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.get_Item
	|
	|-RVA: 0x114FCA0 Offset: 0x114E6A0 VA: 0x18114FCA0
	|-ReadOnlyCollection<Matrix4x4>.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x114FBF0 Offset: 0x114E5F0 VA: 0x18114FBF0
	|-ReadOnlyCollection<NavMeshBuildSource>.get_Item
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.get_Item
	|
	|-RVA: 0x1160BC0 Offset: 0x115F5C0 VA: 0x181160BC0
	|-ReadOnlyCollection<UIVertex>.get_Item
	|
	|-RVA: 0x1160D10 Offset: 0x115F710 VA: 0x181160D10
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.get_Item
	|
	|-RVA: 0x1160AE0 Offset: 0x115F4E0 VA: 0x181160AE0
	|-ReadOnlyCollection<XRView>.get_Item
	|
	|-RVA: 0x1160DF0 Offset: 0x115F7F0 VA: 0x181160DF0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x1160C80 Offset: 0x115F680 VA: 0x181160C80
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.get_Item
	|-ReadOnlyCollection<ShadowUtility.Edge>.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.get_Item
	|
	|-RVA: 0x1181100 Offset: 0x117FB00 VA: 0x181181100
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.get_Item
	|
	|-RVA: 0x1181060 Offset: 0x117FA60 VA: 0x181181060
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.get_Item
	|-ReadOnlyCollection<JsonParser.JsonValue>.get_Item
	|
	|-RVA: 0x11811C0 Offset: 0x117FBC0 VA: 0x1811811C0
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.get_Item
	|
	|-RVA: 0x1180FE0 Offset: 0x117F9E0 VA: 0x181180FE0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A5C0 Offset: 0x1128FC0 VA: 0x18112A5C0
	|-ReadOnlyCollection<ArraySegment<byte>>.Contains
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.Contains
	|-ReadOnlyCollection<KeyValuePair<int, object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.Contains
	|-ReadOnlyCollection<KeyValuePair<object, char>>.Contains
	|-ReadOnlyCollection<KeyValuePair<object, object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.Contains
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.Contains
	|-ReadOnlyCollection<Nullable<DateTime>>.Contains
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.Contains
	|-ReadOnlyCollection<SubArray<int>>.Contains
	|-ReadOnlyCollection<ValueTuple<int, object>>.Contains
	|-ReadOnlyCollection<ValueTuple<object, object>>.Contains
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.Contains
	|-ReadOnlyCollection<BezierContour>.Contains
	|-ReadOnlyCollection<Color>.Contains
	|-ReadOnlyCollection<Connection>.Contains
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.Contains
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.Contains
	|-ReadOnlyCollection<CoordinateStorageTilePair>.Contains
	|-ReadOnlyCollection<CoordinateTilePair>.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|-ReadOnlyCollection<DateTimeOffset>.Contains
	|-ReadOnlyCollection<Decimal>.Contains
	|-ReadOnlyCollection<DoublePoint>.Contains
	|-ReadOnlyCollection<DoublePoint>.Contains
	|-ReadOnlyCollection<DualPrefab>.Contains
	|-ReadOnlyCollection<Entry>.Contains
	|-ReadOnlyCollection<EventSummary>.Contains
	|-ReadOnlyCollection<GlyphRect>.Contains
	|-ReadOnlyCollection<Guid>.Contains
	|-ReadOnlyCollection<IntPoint>.Contains
	|-ReadOnlyCollection<IntRect>.Contains
	|-ReadOnlyCollection<InternedString>.Contains
	|-ReadOnlyCollection<InterpretedFrameInfo>.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.Contains
	|-ReadOnlyCollection<Playable>.Contains
	|-ReadOnlyCollection<Quaternion>.Contains
	|-ReadOnlyCollection<RangePositionInfo>.Contains
	|-ReadOnlyCollection<RectInt>.Contains
	|-ReadOnlyCollection<Resolution>.Contains
	|-ReadOnlyCollection<RuleMatcher>.Contains
	|-ReadOnlyCollection<SamplePointUData>.Contains
	|-ReadOnlyCollection<StylePropertyName>.Contains
	|-ReadOnlyCollection<StylePropertyValue>.Contains
	|-ReadOnlyCollection<StyleValueManaged>.Contains
	|-ReadOnlyCollection<Substring>.Contains
	|-ReadOnlyCollection<UILineInfo>.Contains
	|-ReadOnlyCollection<UnloadedScene>.Contains
	|-ReadOnlyCollection<Vector4>.Contains
	|-ReadOnlyCollection<X509ChainStatus>.Contains
	|-ReadOnlyCollection<ZipGenericExtraField>.Contains
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.Contains
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.Contains
	|-ReadOnlyCollection<CameraState.CustomBlendable>.Contains
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.Contains
	|-ReadOnlyCollection<ClipperLib.IntPoint>.Contains
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.Contains
	|-ReadOnlyCollection<FocusController.FocusedElement>.Contains
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.Contains
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.Contains
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.Contains
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.Contains
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.Contains
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.Contains
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.Contains
	|-ReadOnlyCollection<TargetStateListener.Callback>.Contains
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.Contains
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.Contains
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.Contains
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.Contains
	|
	|-RVA: 0x112A690 Offset: 0x1129090 VA: 0x18112A690
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.Contains
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.Contains
	|-ReadOnlyCollection<DuplicateSamplePoint>.Contains
	|-ReadOnlyCollection<Int3>.Contains
	|-ReadOnlyCollection<IntRegion>.Contains
	|-ReadOnlyCollection<ManipulatorActivationFilter>.Contains
	|-ReadOnlyCollection<UICharInfo>.Contains
	|-ReadOnlyCollection<Vector3>.Contains
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.Contains
	|-ReadOnlyCollection<HIDParser.HIDReportData>.Contains
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.Contains
	|-ReadOnlyCollection<SyncTimer.ChangeData>.Contains
	|
	|-RVA: 0x112A770 Offset: 0x1129170 VA: 0x18112A770
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.Contains
	|-ReadOnlyCollection<Nullable<Decimal>>.Contains
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.Contains
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.Contains
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.Contains
	|-ReadOnlyCollection<BezierPathSegment>.Contains
	|-ReadOnlyCollection<Bounds>.Contains
	|-ReadOnlyCollection<ComputedTransitionProperty>.Contains
	|-ReadOnlyCollection<ContourVertex>.Contains
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.Contains
	|-ReadOnlyCollection<FrameTimeSample>.Contains
	|-ReadOnlyCollection<IntervalTreeNode>.Contains
	|-ReadOnlyCollection<JsonPosition>.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.Contains
	|-ReadOnlyCollection<NameAndParameters>.Contains
	|-ReadOnlyCollection<NamedValue>.Contains
	|-ReadOnlyCollection<RendererList>.Contains
	|-ReadOnlyCollection<SelectorMatchRecord>.Contains
	|-ReadOnlyCollection<StyleSelectorPart>.Contains
	|-ReadOnlyCollection<StyleSyntaxToken>.Contains
	|-ReadOnlyCollection<StyleValue>.Contains
	|-ReadOnlyCollection<StyleVariable>.Contains
	|-ReadOnlyCollection<TreeViewItemWrapper>.Contains
	|-ReadOnlyCollection<XRFeatureDescriptor>.Contains
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.Contains
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.Contains
	|-ReadOnlyCollection<LatencySimulator.Message>.Contains
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.Contains
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.Contains
	|-ReadOnlyCollection<StructySync.ChangeData>.Contains
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.Contains
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.Contains
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.Contains
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.Contains
	|
	|-RVA: 0x112AE80 Offset: 0x1129880 VA: 0x18112AE80
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.Contains
	|-ReadOnlyCollection<RaycastResult>.Contains
	|-ReadOnlyCollection<UIRStylePainter.Entry>.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.Contains
	|
	|-RVA: 0x112A920 Offset: 0x1129320 VA: 0x18112A920
	|-ReadOnlyCollection<ValueTuple<int, int>>.Contains
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.Contains
	|-ReadOnlyCollection<AnimatorClipInfo>.Contains
	|-ReadOnlyCollection<DateTime>.Contains
	|-ReadOnlyCollection<InputEventPtr>.Contains
	|-ReadOnlyCollection<RendererListHandle>.Contains
	|-ReadOnlyCollection<ResourceHandle>.Contains
	|-ReadOnlyCollection<SamplePointsPatch>.Contains
	|-ReadOnlyCollection<TimeSpan>.Contains
	|-ReadOnlyCollection<TimeValue>.Contains
	|-ReadOnlyCollection<UsageHint>.Contains
	|-ReadOnlyCollection<BitmapAllocator32.Page>.Contains
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.Contains
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.Contains
	|-ReadOnlyCollection<PlayingCard.CardData>.Contains
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.Contains
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.Contains
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.Contains
	|
	|-RVA: 0x112AAC0 Offset: 0x11294C0 VA: 0x18112AAC0
	|-ReadOnlyCollection<BezierSegment>.Contains
	|-ReadOnlyCollection<NavMeshBuildMarkup>.Contains
	|-ReadOnlyCollection<PlayableBinding>.Contains
	|-ReadOnlyCollection<VoxelContour>.Contains
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.Contains
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.Contains
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.Contains
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.Contains
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.Contains
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.Contains
	|
	|-RVA: 0x112ABA0 Offset: 0x11295A0 VA: 0x18112ABA0
	|-ReadOnlyCollection<bool>.Contains
	|-ReadOnlyCollection<byte>.Contains
	|-ReadOnlyCollection<sbyte>.Contains
	|
	|-RVA: 0x112AC70 Offset: 0x1129670 VA: 0x18112AC70
	|-ReadOnlyCollection<CGSpot>.Contains
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.Contains
	|-ReadOnlyCollection<RaycastHit>.Contains
	|
	|-RVA: 0x112A850 Offset: 0x1129250 VA: 0x18112A850
	|-ReadOnlyCollection<char>.Contains
	|-ReadOnlyCollection<short>.Contains
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0x112A9F0 Offset: 0x11293F0 VA: 0x18112A9F0
	|-ReadOnlyCollection<Color32>.Contains
	|-ReadOnlyCollection<EasingFunction>.Contains
	|-ReadOnlyCollection<Scene>.Contains
	|-ReadOnlyCollection<ShaderTagId>.Contains
	|-ReadOnlyCollection<UShort2>.Contains
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.Contains
	|
	|-RVA: 0x112AD60 Offset: 0x1129760 VA: 0x18112AD60
	|-ReadOnlyCollection<CombineInstance>.Contains
	|
	|-RVA: 0x113DF30 Offset: 0x113C930 VA: 0x18113DF30
	|-ReadOnlyCollection<ControlPointOption>.Contains
	|-ReadOnlyCollection<RaycastHit2D>.Contains
	|-ReadOnlyCollection<Funnel.PathPart>.Contains
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.Contains
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.Contains
	|
	|-RVA: 0x113E010 Offset: 0x113CA10 VA: 0x18113E010
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|-ReadOnlyCollection<DisplayInfo>.Contains
	|-ReadOnlyCollection<IntPoint>.Contains
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.Contains
	|
	|-RVA: 0x113E0F0 Offset: 0x113CAF0 VA: 0x18113E0F0
	|-ReadOnlyCollection<double>.Contains
	|-ReadOnlyCollection<float>.Contains
	|
	|-RVA: 0x113E290 Offset: 0x113CC90 VA: 0x18113E290
	|-ReadOnlyCollection<InputBinding>.Contains
	|
	|-RVA: 0x113E3A0 Offset: 0x113CDA0 VA: 0x18113E3A0
	|-ReadOnlyCollection<InputDeviceDescription>.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.Contains
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.Contains
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.Contains
	|
	|-RVA: 0x113DED0 Offset: 0x113C8D0 VA: 0x18113DED0
	|-ReadOnlyCollection<int>.Contains
	|-ReadOnlyCollection<Int32Enum>.Contains
	|-ReadOnlyCollection<uint>.Contains
	|-ReadOnlyCollection<UInt32Enum>.Contains
	|
	|-RVA: 0x113E1C0 Offset: 0x113CBC0 VA: 0x18113E1C0
	|-ReadOnlyCollection<long>.Contains
	|-ReadOnlyCollection<object>.Contains
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0x114F610 Offset: 0x114E010 VA: 0x18114F610
	|-ReadOnlyCollection<Label>.Contains
	|-ReadOnlyCollection<PlayerLoopSystem>.Contains
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.Contains
	|-ReadOnlyCollection<RenderTargetIdentifier>.Contains
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.Contains
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.Contains
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.Contains
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.Contains
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.Contains
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Contains
	|
	|-RVA: 0x114F520 Offset: 0x114DF20 VA: 0x18114F520
	|-ReadOnlyCollection<Matrix4x4>.Contains
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x114F700 Offset: 0x114E100 VA: 0x18114F700
	|-ReadOnlyCollection<NavMeshBuildSource>.Contains
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.Contains
	|
	|-RVA: 0x115FFD0 Offset: 0x115E9D0 VA: 0x18115FFD0
	|-ReadOnlyCollection<UIVertex>.Contains
	|
	|-RVA: 0x1160100 Offset: 0x115EB00 VA: 0x181160100
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0x115FE80 Offset: 0x115E880 VA: 0x18115FE80
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.Contains
	|
	|-RVA: 0x115FBC0 Offset: 0x115E5C0 VA: 0x18115FBC0
	|-ReadOnlyCollection<XRView>.Contains
	|
	|-RVA: 0x115FD10 Offset: 0x115E710 VA: 0x18115FD10
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x11601D0 Offset: 0x115EBD0 VA: 0x1811601D0
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Contains
	|-ReadOnlyCollection<ShadowUtility.Edge>.Contains
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.Contains
	|
	|-RVA: 0x1180740 Offset: 0x117F140 VA: 0x181180740
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.Contains
	|
	|-RVA: 0x1180640 Offset: 0x117F040 VA: 0x181180640
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.Contains
	|-ReadOnlyCollection<JsonParser.JsonValue>.Contains
	|
	|-RVA: 0x1180940 Offset: 0x117F340 VA: 0x181180940
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.Contains
	|
	|-RVA: 0x1180870 Offset: 0x117F270 VA: 0x181180870
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.Contains
	|
	|-RVA: 0x1180560 Offset: 0x117EF60 VA: 0x181180560
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112AF80 Offset: 0x1129980 VA: 0x18112AF80
	|-ReadOnlyCollection<ArraySegment<byte>>.CopyTo
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.CopyTo
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.CopyTo
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<int, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, char>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.CopyTo
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.CopyTo
	|-ReadOnlyCollection<Nullable<DateTime>>.CopyTo
	|-ReadOnlyCollection<Nullable<Decimal>>.CopyTo
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.CopyTo
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.CopyTo
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.CopyTo
	|-ReadOnlyCollection<StructMultiKey<object, object>>.CopyTo
	|-ReadOnlyCollection<SubArray<int>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<int, int>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<int, object>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<object, object>>.CopyTo
	|-ReadOnlyCollection<AnimatorClipInfo>.CopyTo
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.CopyTo
	|-ReadOnlyCollection<BezierContour>.CopyTo
	|-ReadOnlyCollection<BezierPathSegment>.CopyTo
	|-ReadOnlyCollection<BezierSegment>.CopyTo
	|-ReadOnlyCollection<bool>.CopyTo
	|-ReadOnlyCollection<Bounds>.CopyTo
	|-ReadOnlyCollection<byte>.CopyTo
	|-ReadOnlyCollection<CGSpot>.CopyTo
	|-ReadOnlyCollection<char>.CopyTo
	|-ReadOnlyCollection<Color>.CopyTo
	|-ReadOnlyCollection<Color32>.CopyTo
	|-ReadOnlyCollection<CombineInstance>.CopyTo
	|-ReadOnlyCollection<ComputedTransitionProperty>.CopyTo
	|-ReadOnlyCollection<Connection>.CopyTo
	|-ReadOnlyCollection<ContourVertex>.CopyTo
	|-ReadOnlyCollection<ControlPointOption>.CopyTo
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.CopyTo
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.CopyTo
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.CopyTo
	|-ReadOnlyCollection<CoordinateStorageTilePair>.CopyTo
	|-ReadOnlyCollection<CoordinateTilePair>.CopyTo
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|-ReadOnlyCollection<DateTime>.CopyTo
	|-ReadOnlyCollection<DateTimeOffset>.CopyTo
	|-ReadOnlyCollection<Decimal>.CopyTo
	|-ReadOnlyCollection<DisplayInfo>.CopyTo
	|-ReadOnlyCollection<double>.CopyTo
	|-ReadOnlyCollection<DoublePoint>.CopyTo
	|-ReadOnlyCollection<DoublePoint>.CopyTo
	|-ReadOnlyCollection<DualPrefab>.CopyTo
	|-ReadOnlyCollection<DuplicateSamplePoint>.CopyTo
	|-ReadOnlyCollection<EasingFunction>.CopyTo
	|-ReadOnlyCollection<Entry>.CopyTo
	|-ReadOnlyCollection<EventSummary>.CopyTo
	|-ReadOnlyCollection<FrameTimeSample>.CopyTo
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<GlyphRect>.CopyTo
	|-ReadOnlyCollection<Guid>.CopyTo
	|-ReadOnlyCollection<InputBinding>.CopyTo
	|-ReadOnlyCollection<InputDeviceDescription>.CopyTo
	|-ReadOnlyCollection<InputEventPtr>.CopyTo
	|-ReadOnlyCollection<short>.CopyTo
	|-ReadOnlyCollection<Int3>.CopyTo
	|-ReadOnlyCollection<int>.CopyTo
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|-ReadOnlyCollection<long>.CopyTo
	|-ReadOnlyCollection<IntPoint>.CopyTo
	|-ReadOnlyCollection<IntPoint>.CopyTo
	|-ReadOnlyCollection<IntRect>.CopyTo
	|-ReadOnlyCollection<IntRegion>.CopyTo
	|-ReadOnlyCollection<InternedString>.CopyTo
	|-ReadOnlyCollection<InterpretedFrameInfo>.CopyTo
	|-ReadOnlyCollection<IntervalTreeNode>.CopyTo
	|-ReadOnlyCollection<JsonPosition>.CopyTo
	|-ReadOnlyCollection<Label>.CopyTo
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<ManipulatorActivationFilter>.CopyTo
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<Matrix4x4>.CopyTo
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<NameAndParameters>.CopyTo
	|-ReadOnlyCollection<NamedValue>.CopyTo
	|-ReadOnlyCollection<NavMeshBuildMarkup>.CopyTo
	|-ReadOnlyCollection<NavMeshBuildSource>.CopyTo
	|-ReadOnlyCollection<object>.CopyTo
	|-ReadOnlyCollection<Playable>.CopyTo
	|-ReadOnlyCollection<PlayableBinding>.CopyTo
	|-ReadOnlyCollection<PlayerLoopSystem>.CopyTo
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.CopyTo
	|-ReadOnlyCollection<Quaternion>.CopyTo
	|-ReadOnlyCollection<RangePositionInfo>.CopyTo
	|-ReadOnlyCollection<RaycastHit>.CopyTo
	|-ReadOnlyCollection<RaycastHit2D>.CopyTo
	|-ReadOnlyCollection<RaycastResult>.CopyTo
	|-ReadOnlyCollection<RectInt>.CopyTo
	|-ReadOnlyCollection<RenderTargetIdentifier>.CopyTo
	|-ReadOnlyCollection<RendererList>.CopyTo
	|-ReadOnlyCollection<RendererListHandle>.CopyTo
	|-ReadOnlyCollection<Resolution>.CopyTo
	|-ReadOnlyCollection<ResourceHandle>.CopyTo
	|-ReadOnlyCollection<RuleMatcher>.CopyTo
	|-ReadOnlyCollection<sbyte>.CopyTo
	|-ReadOnlyCollection<SamplePointUData>.CopyTo
	|-ReadOnlyCollection<SamplePointsPatch>.CopyTo
	|-ReadOnlyCollection<Scene>.CopyTo
	|-ReadOnlyCollection<SelectorMatchRecord>.CopyTo
	|-ReadOnlyCollection<ShaderTagId>.CopyTo
	|-ReadOnlyCollection<float>.CopyTo
	|-ReadOnlyCollection<StylePropertyName>.CopyTo
	|-ReadOnlyCollection<StylePropertyValue>.CopyTo
	|-ReadOnlyCollection<StyleSelectorPart>.CopyTo
	|-ReadOnlyCollection<StyleSyntaxToken>.CopyTo
	|-ReadOnlyCollection<StyleValue>.CopyTo
	|-ReadOnlyCollection<StyleValueManaged>.CopyTo
	|-ReadOnlyCollection<StyleVariable>.CopyTo
	|-ReadOnlyCollection<Substring>.CopyTo
	|-ReadOnlyCollection<TimeSpan>.CopyTo
	|-ReadOnlyCollection<TimeValue>.CopyTo
	|-ReadOnlyCollection<TreeViewItemWrapper>.CopyTo
	|-ReadOnlyCollection<UICharInfo>.CopyTo
	|-ReadOnlyCollection<UILineInfo>.CopyTo
	|-ReadOnlyCollection<UIVertex>.CopyTo
	|-ReadOnlyCollection<ushort>.CopyTo
	|-ReadOnlyCollection<uint>.CopyTo
	|-ReadOnlyCollection<UInt32Enum>.CopyTo
	|-ReadOnlyCollection<ulong>.CopyTo
	|-ReadOnlyCollection<UShort2>.CopyTo
	|-ReadOnlyCollection<UnloadedScene>.CopyTo
	|-ReadOnlyCollection<UsageHint>.CopyTo
	|-ReadOnlyCollection<Vector2>.CopyTo
	|-ReadOnlyCollection<Vector3>.CopyTo
	|-ReadOnlyCollection<Vector4>.CopyTo
	|-ReadOnlyCollection<VoxelContour>.CopyTo
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.CopyTo
	|-ReadOnlyCollection<X509ChainStatus>.CopyTo
	|-ReadOnlyCollection<XRFeatureDescriptor>.CopyTo
	|-ReadOnlyCollection<XRView>.CopyTo
	|-ReadOnlyCollection<ZipGenericExtraField>.CopyTo
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.CopyTo
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.CopyTo
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.CopyTo
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.CopyTo
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.CopyTo
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.CopyTo
	|-ReadOnlyCollection<BitmapAllocator32.Page>.CopyTo
	|-ReadOnlyCollection<CameraState.CustomBlendable>.CopyTo
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.CopyTo
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.CopyTo
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.CopyTo
	|-ReadOnlyCollection<ClipperLib.IntPoint>.CopyTo
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.CopyTo
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.CopyTo
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.CopyTo
	|-ReadOnlyCollection<FocusController.FocusedElement>.CopyTo
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.CopyTo
	|-ReadOnlyCollection<Funnel.PathPart>.CopyTo
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.CopyTo
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.CopyTo
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.CopyTo
	|-ReadOnlyCollection<HIDParser.HIDReportData>.CopyTo
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.CopyTo
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.CopyTo
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.CopyTo
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.CopyTo
	|-ReadOnlyCollection<JsonParser.JsonValue>.CopyTo
	|-ReadOnlyCollection<LatencySimulator.Message>.CopyTo
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.CopyTo
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.CopyTo
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.CopyTo
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.CopyTo
	|-ReadOnlyCollection<PlayingCard.CardData>.CopyTo
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.CopyTo
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.CopyTo
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.CopyTo
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.CopyTo
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.CopyTo
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.CopyTo
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.CopyTo
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.CopyTo
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.CopyTo
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.CopyTo
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.CopyTo
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.CopyTo
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.CopyTo
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.CopyTo
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.CopyTo
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.CopyTo
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.CopyTo
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.CopyTo
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.CopyTo
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.CopyTo
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.CopyTo
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.CopyTo
	|-ReadOnlyCollection<ShadowUtility.Edge>.CopyTo
	|-ReadOnlyCollection<StructySync.ChangeData>.CopyTo
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.CopyTo
	|-ReadOnlyCollection<SyncTimer.ChangeData>.CopyTo
	|-ReadOnlyCollection<TargetStateListener.Callback>.CopyTo
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.CopyTo
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.CopyTo
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.CopyTo
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.CopyTo
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.CopyTo
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.CopyTo
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.CopyTo
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.CopyTo
	|-ReadOnlyCollection<UIRStylePainter.Entry>.CopyTo
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.CopyTo
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.CopyTo
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.CopyTo
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.CopyTo
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.CopyTo
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.CopyTo
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.CopyTo
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.CopyTo
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.CopyTo
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.CopyTo
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112AFF0 Offset: 0x11299F0 VA: 0x18112AFF0
	|-ReadOnlyCollection<ArraySegment<byte>>.GetEnumerator
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.GetEnumerator
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.GetEnumerator
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<int, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, char>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.GetEnumerator
	|-ReadOnlyCollection<Nullable<DateTime>>.GetEnumerator
	|-ReadOnlyCollection<Nullable<Decimal>>.GetEnumerator
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.GetEnumerator
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.GetEnumerator
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.GetEnumerator
	|-ReadOnlyCollection<StructMultiKey<object, object>>.GetEnumerator
	|-ReadOnlyCollection<SubArray<int>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<int, int>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<int, object>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<object, object>>.GetEnumerator
	|-ReadOnlyCollection<AnimatorClipInfo>.GetEnumerator
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.GetEnumerator
	|-ReadOnlyCollection<BezierContour>.GetEnumerator
	|-ReadOnlyCollection<BezierPathSegment>.GetEnumerator
	|-ReadOnlyCollection<BezierSegment>.GetEnumerator
	|-ReadOnlyCollection<bool>.GetEnumerator
	|-ReadOnlyCollection<Bounds>.GetEnumerator
	|-ReadOnlyCollection<byte>.GetEnumerator
	|-ReadOnlyCollection<CGSpot>.GetEnumerator
	|-ReadOnlyCollection<char>.GetEnumerator
	|-ReadOnlyCollection<Color>.GetEnumerator
	|-ReadOnlyCollection<Color32>.GetEnumerator
	|-ReadOnlyCollection<CombineInstance>.GetEnumerator
	|-ReadOnlyCollection<ComputedTransitionProperty>.GetEnumerator
	|-ReadOnlyCollection<Connection>.GetEnumerator
	|-ReadOnlyCollection<ContourVertex>.GetEnumerator
	|-ReadOnlyCollection<ControlPointOption>.GetEnumerator
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.GetEnumerator
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.GetEnumerator
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.GetEnumerator
	|-ReadOnlyCollection<CoordinateStorageTilePair>.GetEnumerator
	|-ReadOnlyCollection<CoordinateTilePair>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|-ReadOnlyCollection<DateTime>.GetEnumerator
	|-ReadOnlyCollection<DateTimeOffset>.GetEnumerator
	|-ReadOnlyCollection<Decimal>.GetEnumerator
	|-ReadOnlyCollection<DisplayInfo>.GetEnumerator
	|-ReadOnlyCollection<double>.GetEnumerator
	|-ReadOnlyCollection<DoublePoint>.GetEnumerator
	|-ReadOnlyCollection<DoublePoint>.GetEnumerator
	|-ReadOnlyCollection<DualPrefab>.GetEnumerator
	|-ReadOnlyCollection<DuplicateSamplePoint>.GetEnumerator
	|-ReadOnlyCollection<EasingFunction>.GetEnumerator
	|-ReadOnlyCollection<Entry>.GetEnumerator
	|-ReadOnlyCollection<EventSummary>.GetEnumerator
	|-ReadOnlyCollection<FrameTimeSample>.GetEnumerator
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<GlyphRect>.GetEnumerator
	|-ReadOnlyCollection<Guid>.GetEnumerator
	|-ReadOnlyCollection<InputBinding>.GetEnumerator
	|-ReadOnlyCollection<InputDeviceDescription>.GetEnumerator
	|-ReadOnlyCollection<InputEventPtr>.GetEnumerator
	|-ReadOnlyCollection<short>.GetEnumerator
	|-ReadOnlyCollection<Int3>.GetEnumerator
	|-ReadOnlyCollection<int>.GetEnumerator
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|-ReadOnlyCollection<long>.GetEnumerator
	|-ReadOnlyCollection<IntPoint>.GetEnumerator
	|-ReadOnlyCollection<IntPoint>.GetEnumerator
	|-ReadOnlyCollection<IntRect>.GetEnumerator
	|-ReadOnlyCollection<IntRegion>.GetEnumerator
	|-ReadOnlyCollection<InternedString>.GetEnumerator
	|-ReadOnlyCollection<InterpretedFrameInfo>.GetEnumerator
	|-ReadOnlyCollection<IntervalTreeNode>.GetEnumerator
	|-ReadOnlyCollection<JsonPosition>.GetEnumerator
	|-ReadOnlyCollection<Label>.GetEnumerator
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<ManipulatorActivationFilter>.GetEnumerator
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<Matrix4x4>.GetEnumerator
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<NameAndParameters>.GetEnumerator
	|-ReadOnlyCollection<NamedValue>.GetEnumerator
	|-ReadOnlyCollection<NavMeshBuildMarkup>.GetEnumerator
	|-ReadOnlyCollection<NavMeshBuildSource>.GetEnumerator
	|-ReadOnlyCollection<object>.GetEnumerator
	|-ReadOnlyCollection<Playable>.GetEnumerator
	|-ReadOnlyCollection<PlayableBinding>.GetEnumerator
	|-ReadOnlyCollection<PlayerLoopSystem>.GetEnumerator
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.GetEnumerator
	|-ReadOnlyCollection<Quaternion>.GetEnumerator
	|-ReadOnlyCollection<RangePositionInfo>.GetEnumerator
	|-ReadOnlyCollection<RaycastHit>.GetEnumerator
	|-ReadOnlyCollection<RaycastHit2D>.GetEnumerator
	|-ReadOnlyCollection<RaycastResult>.GetEnumerator
	|-ReadOnlyCollection<RectInt>.GetEnumerator
	|-ReadOnlyCollection<RenderTargetIdentifier>.GetEnumerator
	|-ReadOnlyCollection<RendererList>.GetEnumerator
	|-ReadOnlyCollection<RendererListHandle>.GetEnumerator
	|-ReadOnlyCollection<Resolution>.GetEnumerator
	|-ReadOnlyCollection<ResourceHandle>.GetEnumerator
	|-ReadOnlyCollection<RuleMatcher>.GetEnumerator
	|-ReadOnlyCollection<sbyte>.GetEnumerator
	|-ReadOnlyCollection<SamplePointUData>.GetEnumerator
	|-ReadOnlyCollection<SamplePointsPatch>.GetEnumerator
	|-ReadOnlyCollection<Scene>.GetEnumerator
	|-ReadOnlyCollection<SelectorMatchRecord>.GetEnumerator
	|-ReadOnlyCollection<ShaderTagId>.GetEnumerator
	|-ReadOnlyCollection<float>.GetEnumerator
	|-ReadOnlyCollection<StylePropertyName>.GetEnumerator
	|-ReadOnlyCollection<StylePropertyValue>.GetEnumerator
	|-ReadOnlyCollection<StyleSelectorPart>.GetEnumerator
	|-ReadOnlyCollection<StyleSyntaxToken>.GetEnumerator
	|-ReadOnlyCollection<StyleValue>.GetEnumerator
	|-ReadOnlyCollection<StyleValueManaged>.GetEnumerator
	|-ReadOnlyCollection<StyleVariable>.GetEnumerator
	|-ReadOnlyCollection<Substring>.GetEnumerator
	|-ReadOnlyCollection<TimeSpan>.GetEnumerator
	|-ReadOnlyCollection<TimeValue>.GetEnumerator
	|-ReadOnlyCollection<TreeViewItemWrapper>.GetEnumerator
	|-ReadOnlyCollection<UICharInfo>.GetEnumerator
	|-ReadOnlyCollection<UILineInfo>.GetEnumerator
	|-ReadOnlyCollection<UIVertex>.GetEnumerator
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|-ReadOnlyCollection<uint>.GetEnumerator
	|-ReadOnlyCollection<UInt32Enum>.GetEnumerator
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|-ReadOnlyCollection<UShort2>.GetEnumerator
	|-ReadOnlyCollection<UnloadedScene>.GetEnumerator
	|-ReadOnlyCollection<UsageHint>.GetEnumerator
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|-ReadOnlyCollection<Vector4>.GetEnumerator
	|-ReadOnlyCollection<VoxelContour>.GetEnumerator
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.GetEnumerator
	|-ReadOnlyCollection<X509ChainStatus>.GetEnumerator
	|-ReadOnlyCollection<XRFeatureDescriptor>.GetEnumerator
	|-ReadOnlyCollection<XRView>.GetEnumerator
	|-ReadOnlyCollection<ZipGenericExtraField>.GetEnumerator
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.GetEnumerator
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.GetEnumerator
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.GetEnumerator
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.GetEnumerator
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|-ReadOnlyCollection<BitmapAllocator32.Page>.GetEnumerator
	|-ReadOnlyCollection<CameraState.CustomBlendable>.GetEnumerator
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.GetEnumerator
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.GetEnumerator
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.GetEnumerator
	|-ReadOnlyCollection<ClipperLib.IntPoint>.GetEnumerator
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.GetEnumerator
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.GetEnumerator
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.GetEnumerator
	|-ReadOnlyCollection<FocusController.FocusedElement>.GetEnumerator
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.GetEnumerator
	|-ReadOnlyCollection<Funnel.PathPart>.GetEnumerator
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.GetEnumerator
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.GetEnumerator
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.GetEnumerator
	|-ReadOnlyCollection<HIDParser.HIDReportData>.GetEnumerator
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.GetEnumerator
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.GetEnumerator
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.GetEnumerator
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.GetEnumerator
	|-ReadOnlyCollection<JsonParser.JsonValue>.GetEnumerator
	|-ReadOnlyCollection<LatencySimulator.Message>.GetEnumerator
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.GetEnumerator
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.GetEnumerator
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.GetEnumerator
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.GetEnumerator
	|-ReadOnlyCollection<PlayingCard.CardData>.GetEnumerator
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.GetEnumerator
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.GetEnumerator
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.GetEnumerator
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.GetEnumerator
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.GetEnumerator
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.GetEnumerator
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.GetEnumerator
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.GetEnumerator
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.GetEnumerator
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.GetEnumerator
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.GetEnumerator
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.GetEnumerator
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.GetEnumerator
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.GetEnumerator
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.GetEnumerator
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.GetEnumerator
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.GetEnumerator
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.GetEnumerator
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.GetEnumerator
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.GetEnumerator
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.GetEnumerator
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.GetEnumerator
	|-ReadOnlyCollection<ShadowUtility.Edge>.GetEnumerator
	|-ReadOnlyCollection<StructySync.ChangeData>.GetEnumerator
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.GetEnumerator
	|-ReadOnlyCollection<SyncTimer.ChangeData>.GetEnumerator
	|-ReadOnlyCollection<TargetStateListener.Callback>.GetEnumerator
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.GetEnumerator
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.GetEnumerator
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.GetEnumerator
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.GetEnumerator
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.GetEnumerator
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.GetEnumerator
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.GetEnumerator
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.GetEnumerator
	|-ReadOnlyCollection<UIRStylePainter.Entry>.GetEnumerator
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.GetEnumerator
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.GetEnumerator
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.GetEnumerator
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.GetEnumerator
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.GetEnumerator
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.GetEnumerator
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.GetEnumerator
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.GetEnumerator
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.GetEnumerator
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.GetEnumerator
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112B120 Offset: 0x1129B20 VA: 0x18112B120
	|-ReadOnlyCollection<ArraySegment<byte>>.IndexOf
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, char>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.IndexOf
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.IndexOf
	|-ReadOnlyCollection<Nullable<DateTime>>.IndexOf
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IndexOf
	|-ReadOnlyCollection<SubArray<int>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, object>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<object, object>>.IndexOf
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.IndexOf
	|-ReadOnlyCollection<BezierContour>.IndexOf
	|-ReadOnlyCollection<Color>.IndexOf
	|-ReadOnlyCollection<Connection>.IndexOf
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.IndexOf
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.IndexOf
	|-ReadOnlyCollection<CoordinateStorageTilePair>.IndexOf
	|-ReadOnlyCollection<CoordinateTilePair>.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.IndexOf
	|-ReadOnlyCollection<Decimal>.IndexOf
	|-ReadOnlyCollection<DoublePoint>.IndexOf
	|-ReadOnlyCollection<DoublePoint>.IndexOf
	|-ReadOnlyCollection<DualPrefab>.IndexOf
	|-ReadOnlyCollection<Entry>.IndexOf
	|-ReadOnlyCollection<EventSummary>.IndexOf
	|-ReadOnlyCollection<GlyphRect>.IndexOf
	|-ReadOnlyCollection<Guid>.IndexOf
	|-ReadOnlyCollection<IntPoint>.IndexOf
	|-ReadOnlyCollection<IntRect>.IndexOf
	|-ReadOnlyCollection<InternedString>.IndexOf
	|-ReadOnlyCollection<InterpretedFrameInfo>.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<Playable>.IndexOf
	|-ReadOnlyCollection<Quaternion>.IndexOf
	|-ReadOnlyCollection<RangePositionInfo>.IndexOf
	|-ReadOnlyCollection<RectInt>.IndexOf
	|-ReadOnlyCollection<Resolution>.IndexOf
	|-ReadOnlyCollection<RuleMatcher>.IndexOf
	|-ReadOnlyCollection<SamplePointUData>.IndexOf
	|-ReadOnlyCollection<StylePropertyName>.IndexOf
	|-ReadOnlyCollection<StylePropertyValue>.IndexOf
	|-ReadOnlyCollection<StyleValueManaged>.IndexOf
	|-ReadOnlyCollection<Substring>.IndexOf
	|-ReadOnlyCollection<UILineInfo>.IndexOf
	|-ReadOnlyCollection<UnloadedScene>.IndexOf
	|-ReadOnlyCollection<Vector4>.IndexOf
	|-ReadOnlyCollection<X509ChainStatus>.IndexOf
	|-ReadOnlyCollection<ZipGenericExtraField>.IndexOf
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.IndexOf
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IndexOf
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IndexOf
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.IndexOf
	|-ReadOnlyCollection<ClipperLib.IntPoint>.IndexOf
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.IndexOf
	|-ReadOnlyCollection<FocusController.FocusedElement>.IndexOf
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.IndexOf
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.IndexOf
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.IndexOf
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.IndexOf
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.IndexOf
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.IndexOf
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.IndexOf
	|-ReadOnlyCollection<TargetStateListener.Callback>.IndexOf
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.IndexOf
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.IndexOf
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.IndexOf
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.IndexOf
	|
	|-RVA: 0x112B650 Offset: 0x112A050 VA: 0x18112B650
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.IndexOf
	|-ReadOnlyCollection<DuplicateSamplePoint>.IndexOf
	|-ReadOnlyCollection<Int3>.IndexOf
	|-ReadOnlyCollection<IntRegion>.IndexOf
	|-ReadOnlyCollection<ManipulatorActivationFilter>.IndexOf
	|-ReadOnlyCollection<UICharInfo>.IndexOf
	|-ReadOnlyCollection<Vector3>.IndexOf
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.IndexOf
	|-ReadOnlyCollection<HIDParser.HIDReportData>.IndexOf
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.IndexOf
	|-ReadOnlyCollection<SyncTimer.ChangeData>.IndexOf
	|
	|-RVA: 0x112B040 Offset: 0x1129A40 VA: 0x18112B040
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.IndexOf
	|-ReadOnlyCollection<Nullable<Decimal>>.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.IndexOf
	|-ReadOnlyCollection<BezierPathSegment>.IndexOf
	|-ReadOnlyCollection<Bounds>.IndexOf
	|-ReadOnlyCollection<ComputedTransitionProperty>.IndexOf
	|-ReadOnlyCollection<ContourVertex>.IndexOf
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.IndexOf
	|-ReadOnlyCollection<FrameTimeSample>.IndexOf
	|-ReadOnlyCollection<IntervalTreeNode>.IndexOf
	|-ReadOnlyCollection<JsonPosition>.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<NameAndParameters>.IndexOf
	|-ReadOnlyCollection<NamedValue>.IndexOf
	|-ReadOnlyCollection<RendererList>.IndexOf
	|-ReadOnlyCollection<SelectorMatchRecord>.IndexOf
	|-ReadOnlyCollection<StyleSelectorPart>.IndexOf
	|-ReadOnlyCollection<StyleSyntaxToken>.IndexOf
	|-ReadOnlyCollection<StyleValue>.IndexOf
	|-ReadOnlyCollection<StyleVariable>.IndexOf
	|-ReadOnlyCollection<TreeViewItemWrapper>.IndexOf
	|-ReadOnlyCollection<XRFeatureDescriptor>.IndexOf
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.IndexOf
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.IndexOf
	|-ReadOnlyCollection<LatencySimulator.Message>.IndexOf
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.IndexOf
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.IndexOf
	|-ReadOnlyCollection<StructySync.ChangeData>.IndexOf
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.IndexOf
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IndexOf
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.IndexOf
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.IndexOf
	|
	|-RVA: 0x112B480 Offset: 0x1129E80 VA: 0x18112B480
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.IndexOf
	|-ReadOnlyCollection<RaycastResult>.IndexOf
	|-ReadOnlyCollection<UIRStylePainter.Entry>.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.IndexOf
	|
	|-RVA: 0x112B580 Offset: 0x1129F80 VA: 0x18112B580
	|-ReadOnlyCollection<ValueTuple<int, int>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.IndexOf
	|-ReadOnlyCollection<AnimatorClipInfo>.IndexOf
	|-ReadOnlyCollection<DateTime>.IndexOf
	|-ReadOnlyCollection<InputEventPtr>.IndexOf
	|-ReadOnlyCollection<RendererListHandle>.IndexOf
	|-ReadOnlyCollection<ResourceHandle>.IndexOf
	|-ReadOnlyCollection<SamplePointsPatch>.IndexOf
	|-ReadOnlyCollection<TimeSpan>.IndexOf
	|-ReadOnlyCollection<TimeValue>.IndexOf
	|-ReadOnlyCollection<UsageHint>.IndexOf
	|-ReadOnlyCollection<BitmapAllocator32.Page>.IndexOf
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IndexOf
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IndexOf
	|-ReadOnlyCollection<PlayingCard.CardData>.IndexOf
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.IndexOf
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.IndexOf
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.IndexOf
	|
	|-RVA: 0x112B730 Offset: 0x112A130 VA: 0x18112B730
	|-ReadOnlyCollection<BezierSegment>.IndexOf
	|-ReadOnlyCollection<NavMeshBuildMarkup>.IndexOf
	|-ReadOnlyCollection<PlayableBinding>.IndexOf
	|-ReadOnlyCollection<VoxelContour>.IndexOf
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.IndexOf
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.IndexOf
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.IndexOf
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.IndexOf
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.IndexOf
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.IndexOf
	|
	|-RVA: 0x112B3B0 Offset: 0x1129DB0 VA: 0x18112B3B0
	|-ReadOnlyCollection<bool>.IndexOf
	|-ReadOnlyCollection<byte>.IndexOf
	|-ReadOnlyCollection<sbyte>.IndexOf
	|
	|-RVA: 0x112B1F0 Offset: 0x1129BF0 VA: 0x18112B1F0
	|-ReadOnlyCollection<CGSpot>.IndexOf
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<RaycastHit>.IndexOf
	|
	|-RVA: 0x112B810 Offset: 0x112A210 VA: 0x18112B810
	|-ReadOnlyCollection<char>.IndexOf
	|-ReadOnlyCollection<short>.IndexOf
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0x112B2E0 Offset: 0x1129CE0 VA: 0x18112B2E0
	|-ReadOnlyCollection<Color32>.IndexOf
	|-ReadOnlyCollection<EasingFunction>.IndexOf
	|-ReadOnlyCollection<Scene>.IndexOf
	|-ReadOnlyCollection<ShaderTagId>.IndexOf
	|-ReadOnlyCollection<UShort2>.IndexOf
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x112B8E0 Offset: 0x112A2E0 VA: 0x18112B8E0
	|-ReadOnlyCollection<CombineInstance>.IndexOf
	|
	|-RVA: 0x113E580 Offset: 0x113CF80 VA: 0x18113E580
	|-ReadOnlyCollection<ControlPointOption>.IndexOf
	|-ReadOnlyCollection<RaycastHit2D>.IndexOf
	|-ReadOnlyCollection<Funnel.PathPart>.IndexOf
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.IndexOf
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IndexOf
	|
	|-RVA: 0x113E660 Offset: 0x113D060 VA: 0x18113E660
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|-ReadOnlyCollection<DisplayInfo>.IndexOf
	|-ReadOnlyCollection<IntPoint>.IndexOf
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.IndexOf
	|
	|-RVA: 0x113E740 Offset: 0x113D140 VA: 0x18113E740
	|-ReadOnlyCollection<double>.IndexOf
	|-ReadOnlyCollection<float>.IndexOf
	|
	|-RVA: 0x113E810 Offset: 0x113D210 VA: 0x18113E810
	|-ReadOnlyCollection<InputBinding>.IndexOf
	|
	|-RVA: 0x113E490 Offset: 0x113CE90 VA: 0x18113E490
	|-ReadOnlyCollection<InputDeviceDescription>.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.IndexOf
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.IndexOf
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.IndexOf
	|
	|-RVA: 0x113E920 Offset: 0x113D320 VA: 0x18113E920
	|-ReadOnlyCollection<int>.IndexOf
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|-ReadOnlyCollection<uint>.IndexOf
	|-ReadOnlyCollection<UInt32Enum>.IndexOf
	|
	|-RVA: 0x113E980 Offset: 0x113D380 VA: 0x18113E980
	|-ReadOnlyCollection<long>.IndexOf
	|-ReadOnlyCollection<object>.IndexOf
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0x114F810 Offset: 0x114E210 VA: 0x18114F810
	|-ReadOnlyCollection<Label>.IndexOf
	|-ReadOnlyCollection<PlayerLoopSystem>.IndexOf
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IndexOf
	|-ReadOnlyCollection<RenderTargetIdentifier>.IndexOf
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IndexOf
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.IndexOf
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.IndexOf
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.IndexOf
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.IndexOf
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.IndexOf
	|
	|-RVA: 0x114F900 Offset: 0x114E300 VA: 0x18114F900
	|-ReadOnlyCollection<Matrix4x4>.IndexOf
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x114F9F0 Offset: 0x114E3F0 VA: 0x18114F9F0
	|-ReadOnlyCollection<NavMeshBuildSource>.IndexOf
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.IndexOf
	|
	|-RVA: 0x1160390 Offset: 0x115ED90 VA: 0x181160390
	|-ReadOnlyCollection<UIVertex>.IndexOf
	|
	|-RVA: 0x11604C0 Offset: 0x115EEC0 VA: 0x1811604C0
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0x1160590 Offset: 0x115EF90 VA: 0x181160590
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.IndexOf
	|
	|-RVA: 0x11606E0 Offset: 0x115F0E0 VA: 0x1811606E0
	|-ReadOnlyCollection<XRView>.IndexOf
	|
	|-RVA: 0x1160830 Offset: 0x115F230 VA: 0x181160830
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x11602B0 Offset: 0x115ECB0 VA: 0x1811602B0
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.IndexOf
	|-ReadOnlyCollection<ShadowUtility.Edge>.IndexOf
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IndexOf
	|
	|-RVA: 0x1180EB0 Offset: 0x117F8B0 VA: 0x181180EB0
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.IndexOf
	|
	|-RVA: 0x1180CE0 Offset: 0x117F6E0 VA: 0x181180CE0
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.IndexOf
	|-ReadOnlyCollection<JsonParser.JsonValue>.IndexOf
	|
	|-RVA: 0x1180AA0 Offset: 0x117F4A0 VA: 0x181180AA0
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.IndexOf
	|
	|-RVA: 0x1180DE0 Offset: 0x117F7E0 VA: 0x181180DE0
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.IndexOf
	|
	|-RVA: 0x1180C00 Offset: 0x117F600 VA: 0x181180C00
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Label>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BC10 Offset: 0x112A610 VA: 0x18112BC10
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BE70 Offset: 0x112A870 VA: 0x18112BE70
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BB90 Offset: 0x112A590 VA: 0x18112BB90
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BD70 Offset: 0x112A770 VA: 0x18112BD70
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BE10 Offset: 0x112A810 VA: 0x18112BE10
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BEF0 Offset: 0x112A8F0 VA: 0x18112BEF0
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BCE0 Offset: 0x112A6E0 VA: 0x18112BCE0
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x112BF70 Offset: 0x112A970 VA: 0x18112BF70
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x113EB90 Offset: 0x113D590 VA: 0x18113EB90
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x113EA50 Offset: 0x113D450 VA: 0x18113EA50
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x113ECA0 Offset: 0x113D6A0 VA: 0x18113ECA0
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x113EAE0 Offset: 0x113D4E0 VA: 0x18113EAE0
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x113EC10 Offset: 0x113D610 VA: 0x18113EC10
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x114FB60 Offset: 0x114E560 VA: 0x18114FB60
	|-ReadOnlyCollection<Label>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x114FCA0 Offset: 0x114E6A0 VA: 0x18114FCA0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x114FBF0 Offset: 0x114E5F0 VA: 0x18114FBF0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1160BC0 Offset: 0x115F5C0 VA: 0x181160BC0
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1160D10 Offset: 0x115F710 VA: 0x181160D10
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1160AE0 Offset: 0x115F4E0 VA: 0x181160AE0
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1160DF0 Offset: 0x115F7F0 VA: 0x181160DF0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1160C80 Offset: 0x115F680 VA: 0x181160C80
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1181100 Offset: 0x117FB00 VA: 0x181181100
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1181060 Offset: 0x117FA60 VA: 0x181181060
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x11811C0 Offset: 0x117FBC0 VA: 0x1811811C0
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1180FE0 Offset: 0x117F9E0 VA: 0x181180FE0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Label>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Label>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Label>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Label>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB70 Offset: 0x112A570 VA: 0x18112BB70
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Label>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BezierContour>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BezierSegment>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Bounds>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CGSpot>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ContourVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DoublePoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DualPrefab>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Entry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EventSummary>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputBinding>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Int3>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntRect>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntRegion>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InternedString>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Label>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NamedValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Playable>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastHit>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RectInt>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RendererList>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Scene>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Substring>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UShort2>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UsageHint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VoxelContour>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<XRView>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1139EF0 Offset: 0x11388F0 VA: 0x181139EF0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A850 Offset: 0x1139250 VA: 0x18113A850
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A670 Offset: 0x1139070 VA: 0x18113A670
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A080 Offset: 0x1138A80 VA: 0x18113A080
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A3A0 Offset: 0x1138DA0 VA: 0x18113A3A0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A4E0 Offset: 0x1138EE0 VA: 0x18113A4E0
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139F40 Offset: 0x1138940 VA: 0x181139F40
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A7B0 Offset: 0x11391B0 VA: 0x18113A7B0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139FE0 Offset: 0x11389E0 VA: 0x181139FE0
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A170 Offset: 0x1138B70 VA: 0x18113A170
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A800 Offset: 0x1139200 VA: 0x18113A800
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A120 Offset: 0x1138B20 VA: 0x18113A120
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139D10 Offset: 0x1138710 VA: 0x181139D10
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A1C0 Offset: 0x1138BC0 VA: 0x18113A1C0
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139E50 Offset: 0x1138850 VA: 0x181139E50
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A760 Offset: 0x1139160 VA: 0x18113A760
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A530 Offset: 0x1138F30 VA: 0x18113A530
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A350 Offset: 0x1138D50 VA: 0x18113A350
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139EA0 Offset: 0x11388A0 VA: 0x181139EA0
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A490 Offset: 0x1138E90 VA: 0x18113A490
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A0D0 Offset: 0x1138AD0 VA: 0x18113A0D0
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A440 Offset: 0x1138E40 VA: 0x18113A440
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139CC0 Offset: 0x11386C0 VA: 0x181139CC0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A580 Offset: 0x1138F80 VA: 0x18113A580
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139C70 Offset: 0x1138670 VA: 0x181139C70
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139B80 Offset: 0x1138580 VA: 0x181139B80
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A710 Offset: 0x1139110 VA: 0x18113A710
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139BD0 Offset: 0x11385D0 VA: 0x181139BD0
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A3F0 Offset: 0x1138DF0 VA: 0x18113A3F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A030 Offset: 0x1138A30 VA: 0x18113A030
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A620 Offset: 0x1139020 VA: 0x18113A620
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139D60 Offset: 0x1138760 VA: 0x181139D60
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A5D0 Offset: 0x1138FD0 VA: 0x18113A5D0
	|-ReadOnlyCollection<BezierContour>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139E00 Offset: 0x1138800 VA: 0x181139E00
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A210 Offset: 0x1138C10 VA: 0x18113A210
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139B30 Offset: 0x1138530 VA: 0x181139B30
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A6C0 Offset: 0x11390C0 VA: 0x18113A6C0
	|-ReadOnlyCollection<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A260 Offset: 0x1138C60 VA: 0x18113A260
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A2B0 Offset: 0x1138CB0 VA: 0x18113A2B0
	|-ReadOnlyCollection<CGSpot>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x113A300 Offset: 0x1138D00 VA: 0x18113A300
	|-ReadOnlyCollection<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139C20 Offset: 0x1138620 VA: 0x181139C20
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139DB0 Offset: 0x11387B0 VA: 0x181139DB0
	|-ReadOnlyCollection<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1139F90 Offset: 0x1138990 VA: 0x181139F90
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CAA0 Offset: 0x114B4A0 VA: 0x18114CAA0
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D400 Offset: 0x114BE00 VA: 0x18114D400
	|-ReadOnlyCollection<Connection>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CC30 Offset: 0x114B630 VA: 0x18114CC30
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D1D0 Offset: 0x114BBD0 VA: 0x18114D1D0
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D360 Offset: 0x114BD60 VA: 0x18114D360
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CE10 Offset: 0x114B810 VA: 0x18114CE10
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D130 Offset: 0x114BB30 VA: 0x18114D130
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D090 Offset: 0x114BA90 VA: 0x18114D090
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D220 Offset: 0x114BC20 VA: 0x18114D220
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D450 Offset: 0x114BE50 VA: 0x18114D450
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D540 Offset: 0x114BF40 VA: 0x18114D540
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D270 Offset: 0x114BC70 VA: 0x18114D270
	|-ReadOnlyCollection<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CF50 Offset: 0x114B950 VA: 0x18114CF50
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114C870 Offset: 0x114B270 VA: 0x18114C870
	|-ReadOnlyCollection<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D3B0 Offset: 0x114BDB0 VA: 0x18114D3B0
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114C910 Offset: 0x114B310 VA: 0x18114C910
	|-ReadOnlyCollection<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CB40 Offset: 0x114B540 VA: 0x18114CB40
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CFF0 Offset: 0x114B9F0 VA: 0x18114CFF0
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D2C0 Offset: 0x114BCC0 VA: 0x18114D2C0
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D040 Offset: 0x114BA40 VA: 0x18114D040
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CF00 Offset: 0x114B900 VA: 0x18114CF00
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CEB0 Offset: 0x114B8B0 VA: 0x18114CEB0
	|-ReadOnlyCollection<Entry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114C9B0 Offset: 0x114B3B0 VA: 0x18114C9B0
	|-ReadOnlyCollection<EventSummary>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CBE0 Offset: 0x114B5E0 VA: 0x18114CBE0
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CE60 Offset: 0x114B860 VA: 0x18114CE60
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114C8C0 Offset: 0x114B2C0 VA: 0x18114C8C0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CA00 Offset: 0x114B400 VA: 0x18114CA00
	|-ReadOnlyCollection<Guid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D590 Offset: 0x114BF90 VA: 0x18114D590
	|-ReadOnlyCollection<InputBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CDC0 Offset: 0x114B7C0 VA: 0x18114CDC0
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D0E0 Offset: 0x114BAE0 VA: 0x18114D0E0
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CB90 Offset: 0x114B590 VA: 0x18114CB90
	|-ReadOnlyCollection<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D4A0 Offset: 0x114BEA0 VA: 0x18114D4A0
	|-ReadOnlyCollection<Int3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CA50 Offset: 0x114B450 VA: 0x18114CA50
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CAF0 Offset: 0x114B4F0 VA: 0x18114CAF0
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CCD0 Offset: 0x114B6D0 VA: 0x18114CCD0
	|-ReadOnlyCollection<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CFA0 Offset: 0x114B9A0 VA: 0x18114CFA0
	|-ReadOnlyCollection<IntPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CD70 Offset: 0x114B770 VA: 0x18114CD70
	|-ReadOnlyCollection<IntPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D310 Offset: 0x114BD10 VA: 0x18114D310
	|-ReadOnlyCollection<IntRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CC80 Offset: 0x114B680 VA: 0x18114CC80
	|-ReadOnlyCollection<IntRegion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D4F0 Offset: 0x114BEF0 VA: 0x18114D4F0
	|-ReadOnlyCollection<InternedString>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114D180 Offset: 0x114BB80 VA: 0x18114D180
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114CD20 Offset: 0x114B720 VA: 0x18114CD20
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x114C960 Offset: 0x114B360 VA: 0x18114C960
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DD10 Offset: 0x115C710 VA: 0x18115DD10
	|-ReadOnlyCollection<Label>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E210 Offset: 0x115CC10 VA: 0x18115E210
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E120 Offset: 0x115CB20 VA: 0x18115E120
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E1C0 Offset: 0x115CBC0 VA: 0x18115E1C0
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E350 Offset: 0x115CD50 VA: 0x18115E350
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E670 Offset: 0x115D070 VA: 0x18115E670
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DAE0 Offset: 0x115C4E0 VA: 0x18115DAE0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DA90 Offset: 0x115C490 VA: 0x18115DA90
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DDB0 Offset: 0x115C7B0 VA: 0x18115DDB0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E260 Offset: 0x115CC60 VA: 0x18115E260
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E4E0 Offset: 0x115CEE0 VA: 0x18115E4E0
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DF90 Offset: 0x115C990 VA: 0x18115DF90
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DEF0 Offset: 0x115C8F0 VA: 0x18115DEF0
	|-ReadOnlyCollection<NamedValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DC20 Offset: 0x115C620 VA: 0x18115DC20
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DBD0 Offset: 0x115C5D0 VA: 0x18115DBD0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E440 Offset: 0x115CE40 VA: 0x18115E440
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DEA0 Offset: 0x115C8A0 VA: 0x18115DEA0
	|-ReadOnlyCollection<Playable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E030 Offset: 0x115CA30 VA: 0x18115E030
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DC70 Offset: 0x115C670 VA: 0x18115DC70
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115D950 Offset: 0x115C350 VA: 0x18115D950
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E3F0 Offset: 0x115CDF0 VA: 0x18115E3F0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E530 Offset: 0x115CF30 VA: 0x18115E530
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DA40 Offset: 0x115C440 VA: 0x18115DA40
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DE50 Offset: 0x115C850 VA: 0x18115DE50
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DFE0 Offset: 0x115C9E0 VA: 0x18115DFE0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DE00 Offset: 0x115C800 VA: 0x18115DE00
	|-ReadOnlyCollection<RectInt>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DB30 Offset: 0x115C530 VA: 0x18115DB30
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E620 Offset: 0x115D020 VA: 0x18115E620
	|-ReadOnlyCollection<RendererList>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E490 Offset: 0x115CE90 VA: 0x18115E490
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E580 Offset: 0x115CF80 VA: 0x18115E580
	|-ReadOnlyCollection<Resolution>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115D9F0 Offset: 0x115C3F0 VA: 0x18115D9F0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E2B0 Offset: 0x115CCB0 VA: 0x18115E2B0
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DCC0 Offset: 0x115C6C0 VA: 0x18115DCC0
	|-ReadOnlyCollection<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DD60 Offset: 0x115C760 VA: 0x18115DD60
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E5D0 Offset: 0x115CFD0 VA: 0x18115E5D0
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DB80 Offset: 0x115C580 VA: 0x18115DB80
	|-ReadOnlyCollection<Scene>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115D9A0 Offset: 0x115C3A0 VA: 0x18115D9A0
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E080 Offset: 0x115CA80 VA: 0x18115E080
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E0D0 Offset: 0x115CAD0 VA: 0x18115E0D0
	|-ReadOnlyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E3A0 Offset: 0x115CDA0 VA: 0x18115E3A0
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E300 Offset: 0x115CD00 VA: 0x18115E300
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115E170 Offset: 0x115CB70 VA: 0x18115E170
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x115DF40 Offset: 0x115C940 VA: 0x18115DF40
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EF50 Offset: 0x116D950 VA: 0x18116EF50
	|-ReadOnlyCollection<StyleValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F590 Offset: 0x116DF90 VA: 0x18116F590
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116ED20 Offset: 0x116D720 VA: 0x18116ED20
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F220 Offset: 0x116DC20 VA: 0x18116F220
	|-ReadOnlyCollection<Substring>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F180 Offset: 0x116DB80 VA: 0x18116F180
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F130 Offset: 0x116DB30 VA: 0x18116F130
	|-ReadOnlyCollection<TimeValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F310 Offset: 0x116DD10 VA: 0x18116F310
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EEB0 Offset: 0x116D8B0 VA: 0x18116EEB0
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F040 Offset: 0x116DA40 VA: 0x18116F040
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F0E0 Offset: 0x116DAE0 VA: 0x18116F0E0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F090 Offset: 0x116DA90 VA: 0x18116F090
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EAA0 Offset: 0x116D4A0 VA: 0x18116EAA0
	|-ReadOnlyCollection<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EE60 Offset: 0x116D860 VA: 0x18116EE60
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F5E0 Offset: 0x116DFE0 VA: 0x18116F5E0
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F6D0 Offset: 0x116E0D0 VA: 0x18116F6D0
	|-ReadOnlyCollection<UShort2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EFA0 Offset: 0x116D9A0 VA: 0x18116EFA0
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F540 Offset: 0x116DF40 VA: 0x18116F540
	|-ReadOnlyCollection<UsageHint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F7C0 Offset: 0x116E1C0 VA: 0x18116F7C0
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EDC0 Offset: 0x116D7C0 VA: 0x18116EDC0
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F400 Offset: 0x116DE00 VA: 0x18116F400
	|-ReadOnlyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F4F0 Offset: 0x116DEF0 VA: 0x18116F4F0
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EAF0 Offset: 0x116D4F0 VA: 0x18116EAF0
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EF00 Offset: 0x116D900 VA: 0x18116EF00
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116ED70 Offset: 0x116D770 VA: 0x18116ED70
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EBE0 Offset: 0x116D5E0 VA: 0x18116EBE0
	|-ReadOnlyCollection<XRView>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F270 Offset: 0x116DC70 VA: 0x18116F270
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F450 Offset: 0x116DE50 VA: 0x18116F450
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EB40 Offset: 0x116D540 VA: 0x18116EB40
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F630 Offset: 0x116E030 VA: 0x18116F630
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EC80 Offset: 0x116D680 VA: 0x18116EC80
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116ECD0 Offset: 0x116D6D0 VA: 0x18116ECD0
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EE10 Offset: 0x116D810 VA: 0x18116EE10
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EB90 Offset: 0x116D590 VA: 0x18116EB90
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F720 Offset: 0x116E120 VA: 0x18116F720
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F3B0 Offset: 0x116DDB0 VA: 0x18116F3B0
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F2C0 Offset: 0x116DCC0 VA: 0x18116F2C0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EFF0 Offset: 0x116D9F0 VA: 0x18116EFF0
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F360 Offset: 0x116DD60 VA: 0x18116F360
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F1D0 Offset: 0x116DBD0 VA: 0x18116F1D0
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F770 Offset: 0x116E170 VA: 0x18116F770
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116EC30 Offset: 0x116D630 VA: 0x18116EC30
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F680 Offset: 0x116E080 VA: 0x18116F680
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F4A0 Offset: 0x116DEA0 VA: 0x18116F4A0
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F810 Offset: 0x118E210 VA: 0x18118F810
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F5E0 Offset: 0x118DFE0 VA: 0x18118F5E0
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F220 Offset: 0x118DC20 VA: 0x18118F220
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F7C0 Offset: 0x118E1C0 VA: 0x18118F7C0
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F630 Offset: 0x118E030 VA: 0x18118F630
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F180 Offset: 0x118DB80 VA: 0x18118F180
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FB30 Offset: 0x118E530 VA: 0x18118FB30
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F9F0 Offset: 0x118E3F0 VA: 0x18118F9F0
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F4A0 Offset: 0x118DEA0 VA: 0x18118F4A0
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F680 Offset: 0x118E080 VA: 0x18118F680
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F6D0 Offset: 0x118E0D0 VA: 0x18118F6D0
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FD60 Offset: 0x118E760 VA: 0x18118FD60
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F2C0 Offset: 0x118DCC0 VA: 0x18118F2C0
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F450 Offset: 0x118DE50 VA: 0x18118F450
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F400 Offset: 0x118DE00 VA: 0x18118F400
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FA90 Offset: 0x118E490 VA: 0x18118FA90
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FC70 Offset: 0x118E670 VA: 0x18118FC70
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F590 Offset: 0x118DF90 VA: 0x18118F590
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F8B0 Offset: 0x118E2B0 VA: 0x18118F8B0
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FBD0 Offset: 0x118E5D0 VA: 0x18118FBD0
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F270 Offset: 0x118DC70 VA: 0x18118F270
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F770 Offset: 0x118E170 VA: 0x18118F770
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FAE0 Offset: 0x118E4E0 VA: 0x18118FAE0
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F0E0 Offset: 0x118DAE0 VA: 0x18118F0E0
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F090 Offset: 0x118DA90 VA: 0x18118F090
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F900 Offset: 0x118E300 VA: 0x18118F900
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F360 Offset: 0x118DD60 VA: 0x18118F360
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FD10 Offset: 0x118E710 VA: 0x18118FD10
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F310 Offset: 0x118DD10 VA: 0x18118F310
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FCC0 Offset: 0x118E6C0 VA: 0x18118FCC0
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FB80 Offset: 0x118E580 VA: 0x18118FB80
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FDB0 Offset: 0x118E7B0 VA: 0x18118FDB0
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F950 Offset: 0x118E350 VA: 0x18118F950
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F860 Offset: 0x118E260 VA: 0x18118F860
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F3B0 Offset: 0x118DDB0 VA: 0x18118F3B0
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F540 Offset: 0x118DF40 VA: 0x18118F540
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F130 Offset: 0x118DB30 VA: 0x18118F130
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FA40 Offset: 0x118E440 VA: 0x18118FA40
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F9A0 Offset: 0x118E3A0 VA: 0x18118F9A0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F4F0 Offset: 0x118DEF0 VA: 0x18118F4F0
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F1D0 Offset: 0x118DBD0 VA: 0x18118F1D0
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118F720 Offset: 0x118E120 VA: 0x18118F720
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x118FC20 Offset: 0x118E620 VA: 0x18118FC20
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B080 Offset: 0x1199A80 VA: 0x18119B080
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B1C0 Offset: 0x1199BC0 VA: 0x18119B1C0
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AA40 Offset: 0x1199440 VA: 0x18119AA40
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AF40 Offset: 0x1199940 VA: 0x18119AF40
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AD10 Offset: 0x1199710 VA: 0x18119AD10
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AEA0 Offset: 0x11998A0 VA: 0x18119AEA0
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AC20 Offset: 0x1199620 VA: 0x18119AC20
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AD60 Offset: 0x1199760 VA: 0x18119AD60
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AE50 Offset: 0x1199850 VA: 0x18119AE50
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AB30 Offset: 0x1199530 VA: 0x18119AB30
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AB80 Offset: 0x1199580 VA: 0x18119AB80
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AF90 Offset: 0x1199990 VA: 0x18119AF90
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AE00 Offset: 0x1199800 VA: 0x18119AE00
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AC70 Offset: 0x1199670 VA: 0x18119AC70
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119A9F0 Offset: 0x11993F0 VA: 0x18119A9F0
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AAE0 Offset: 0x11994E0 VA: 0x18119AAE0
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119ADB0 Offset: 0x11997B0 VA: 0x18119ADB0
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AFE0 Offset: 0x11999E0 VA: 0x18119AFE0
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B0D0 Offset: 0x1199AD0 VA: 0x18119B0D0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B030 Offset: 0x1199A30 VA: 0x18119B030
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119ABD0 Offset: 0x11995D0 VA: 0x18119ABD0
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119ACC0 Offset: 0x11996C0 VA: 0x18119ACC0
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B120 Offset: 0x1199B20 VA: 0x18119B120
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AA90 Offset: 0x1199490 VA: 0x18119AA90
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119AEF0 Offset: 0x11998F0 VA: 0x18119AEF0
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x119B170 Offset: 0x1199B70 VA: 0x18119B170
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BezierContour>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BezierSegment>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Bounds>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CGSpot>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DualPrefab>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Entry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputBinding>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Int3>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntRect>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntRegion>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InternedString>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Label>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NamedValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Playable>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastHit>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RectInt>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RendererList>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Scene>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Substring>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UShort2>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UsageHint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VoxelContour>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137BB0 Offset: 0x11365B0 VA: 0x181137BB0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139510 Offset: 0x1137F10 VA: 0x181139510
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138A90 Offset: 0x1137490 VA: 0x181138A90
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139270 Offset: 0x1137C70 VA: 0x181139270
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11397B0 Offset: 0x11381B0 VA: 0x1811397B0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11381D0 Offset: 0x1136BD0 VA: 0x1811381D0
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139890 Offset: 0x1138290 VA: 0x181139890
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139190 Offset: 0x1137B90 VA: 0x181139190
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137670 Offset: 0x1136070 VA: 0x181137670
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11388D0 Offset: 0x11372D0 VA: 0x1811388D0
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11389B0 Offset: 0x11373B0 VA: 0x1811389B0
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137830 Offset: 0x1136230 VA: 0x181137830
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138010 Offset: 0x1136A10 VA: 0x181138010
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137D70 Offset: 0x1136770 VA: 0x181137D70
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139A50 Offset: 0x1138450 VA: 0x181139A50
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138E10 Offset: 0x1137810 VA: 0x181138E10
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138EF0 Offset: 0x11378F0 VA: 0x181138EF0
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138D30 Offset: 0x1137730 VA: 0x181138D30
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11379F0 Offset: 0x11363F0 VA: 0x1811379F0
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139350 Offset: 0x1137D50 VA: 0x181139350
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139970 Offset: 0x1138370 VA: 0x181139970
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137AD0 Offset: 0x11364D0 VA: 0x181137AD0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1139430 Offset: 0x1137E30 VA: 0x181139430
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138550 Offset: 0x1136F50 VA: 0x181138550
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138630 Offset: 0x1137030 VA: 0x181138630
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137F30 Offset: 0x1136930 VA: 0x181137F30
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11390B0 Offset: 0x1137AB0 VA: 0x1811390B0
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137750 Offset: 0x1136150 VA: 0x181137750
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11387F0 Offset: 0x11371F0 VA: 0x1811387F0
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137910 Offset: 0x1136310 VA: 0x181137910
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137590 Offset: 0x1135F90 VA: 0x181137590
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138390 Offset: 0x1136D90 VA: 0x181138390
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11380F0 Offset: 0x1136AF0 VA: 0x1811380F0
	|-ReadOnlyCollection<BezierContour>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138FD0 Offset: 0x11379D0 VA: 0x181138FD0
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138B70 Offset: 0x1137570 VA: 0x181138B70
	|-ReadOnlyCollection<BezierSegment>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11395F0 Offset: 0x1137FF0 VA: 0x1811395F0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137C90 Offset: 0x1136690 VA: 0x181137C90
	|-ReadOnlyCollection<Bounds>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138C50 Offset: 0x1137650 VA: 0x181138C50
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138470 Offset: 0x1136E70 VA: 0x181138470
	|-ReadOnlyCollection<CGSpot>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11396D0 Offset: 0x11380D0 VA: 0x1811396D0
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1138710 Offset: 0x1137110 VA: 0x181138710
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1137E50 Offset: 0x1136850 VA: 0x181137E50
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11382B0 Offset: 0x1136CB0 VA: 0x1811382B0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C090 Offset: 0x114AA90 VA: 0x18114C090
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AFF0 Offset: 0x11499F0 VA: 0x18114AFF0
	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BA70 Offset: 0x114A470 VA: 0x18114BA70
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AE30 Offset: 0x1149830 VA: 0x18114AE30
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C5D0 Offset: 0x114AFD0 VA: 0x18114C5D0
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AC70 Offset: 0x1149670 VA: 0x18114AC70
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B610 Offset: 0x114A010 VA: 0x18114B610
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B530 Offset: 0x1149F30 VA: 0x18114B530
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A570 Offset: 0x1148F70 VA: 0x18114A570
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B8B0 Offset: 0x114A2B0 VA: 0x18114B8B0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B370 Offset: 0x1149D70 VA: 0x18114B370
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AB90 Offset: 0x1149590 VA: 0x18114AB90
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B6F0 Offset: 0x114A0F0 VA: 0x18114B6F0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B990 Offset: 0x114A390 VA: 0x18114B990
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C330 Offset: 0x114AD30 VA: 0x18114C330
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BD10 Offset: 0x114A710 VA: 0x18114BD10
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BC30 Offset: 0x114A630 VA: 0x18114BC30
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A490 Offset: 0x1148E90 VA: 0x18114A490
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AAB0 Offset: 0x11494B0 VA: 0x18114AAB0
	|-ReadOnlyCollection<DualPrefab>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B450 Offset: 0x1149E50 VA: 0x18114B450
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BED0 Offset: 0x114A8D0 VA: 0x18114BED0
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AD50 Offset: 0x1149750 VA: 0x18114AD50
	|-ReadOnlyCollection<Entry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A2D0 Offset: 0x1148CD0 VA: 0x18114A2D0
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C6B0 Offset: 0x114B0B0 VA: 0x18114C6B0
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A8F0 Offset: 0x11492F0 VA: 0x18114A8F0
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BDF0 Offset: 0x114A7F0 VA: 0x18114BDF0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A650 Offset: 0x1149050 VA: 0x18114A650
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A9D0 Offset: 0x11493D0 VA: 0x18114A9D0
	|-ReadOnlyCollection<InputBinding>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C790 Offset: 0x114B190 VA: 0x18114C790
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C4F0 Offset: 0x114AEF0 VA: 0x18114C4F0
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B7D0 Offset: 0x114A1D0 VA: 0x18114B7D0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A810 Offset: 0x1149210 VA: 0x18114A810
	|-ReadOnlyCollection<Int3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BFB0 Offset: 0x114A9B0 VA: 0x18114BFB0
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B290 Offset: 0x1149C90 VA: 0x18114B290
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114BB50 Offset: 0x114A550 VA: 0x18114BB50
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A3B0 Offset: 0x1148DB0 VA: 0x18114A3B0
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B0D0 Offset: 0x1149AD0 VA: 0x18114B0D0
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114A730 Offset: 0x1149130 VA: 0x18114A730
	|-ReadOnlyCollection<IntRect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C170 Offset: 0x114AB70 VA: 0x18114C170
	|-ReadOnlyCollection<IntRegion>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114B1B0 Offset: 0x1149BB0 VA: 0x18114B1B0
	|-ReadOnlyCollection<InternedString>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C410 Offset: 0x114AE10 VA: 0x18114C410
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114AF10 Offset: 0x1149910 VA: 0x18114AF10
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x114C250 Offset: 0x114AC50 VA: 0x18114C250
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C290 Offset: 0x115AC90 VA: 0x18115C290
	|-ReadOnlyCollection<Label>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CC30 Offset: 0x115B630 VA: 0x18115CC30
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D410 Offset: 0x115BE10 VA: 0x18115D410
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BFF0 Offset: 0x115A9F0 VA: 0x18115BFF0
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C530 Offset: 0x115AF30 VA: 0x18115C530
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B570 Offset: 0x1159F70 VA: 0x18115B570
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CED0 Offset: 0x115B8D0 VA: 0x18115CED0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C6F0 Offset: 0x115B0F0 VA: 0x18115C6F0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BF10 Offset: 0x115A910 VA: 0x18115BF10
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D870 Offset: 0x115C270 VA: 0x18115D870
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BC70 Offset: 0x115A670 VA: 0x18115BC70
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B9D0 Offset: 0x115A3D0 VA: 0x18115B9D0
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D330 Offset: 0x115BD30 VA: 0x18115D330
	|-ReadOnlyCollection<NamedValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B810 Offset: 0x115A210 VA: 0x18115B810
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CFB0 Offset: 0x115B9B0 VA: 0x18115CFB0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C450 Offset: 0x115AE50 VA: 0x18115C450
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B3B0 Offset: 0x1159DB0 VA: 0x18115B3B0
	|-ReadOnlyCollection<Playable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D790 Offset: 0x115C190 VA: 0x18115D790
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D4F0 Offset: 0x115BEF0 VA: 0x18115D4F0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D6B0 Offset: 0x115C0B0 VA: 0x18115D6B0
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B8F0 Offset: 0x115A2F0 VA: 0x18115B8F0
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D250 Offset: 0x115BC50 VA: 0x18115D250
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C610 Offset: 0x115B010 VA: 0x18115C610
	|-ReadOnlyCollection<RaycastHit>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CD10 Offset: 0x115B710 VA: 0x18115CD10
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D5D0 Offset: 0x115BFD0 VA: 0x18115D5D0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C0D0 Offset: 0x115AAD0 VA: 0x18115C0D0
	|-ReadOnlyCollection<RectInt>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C7D0 Offset: 0x115B1D0 VA: 0x18115C7D0
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CA70 Offset: 0x115B470 VA: 0x18115CA70
	|-ReadOnlyCollection<RendererList>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C370 Offset: 0x115AD70 VA: 0x18115C370
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B730 Offset: 0x115A130 VA: 0x18115B730
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D090 Offset: 0x115BA90 VA: 0x18115D090
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C1B0 Offset: 0x115ABB0 VA: 0x18115C1B0
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BE30 Offset: 0x115A830 VA: 0x18115BE30
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BD50 Offset: 0x115A750 VA: 0x18115BD50
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B650 Offset: 0x115A050 VA: 0x18115B650
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BAB0 Offset: 0x115A4B0 VA: 0x18115BAB0
	|-ReadOnlyCollection<Scene>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115BB90 Offset: 0x115A590 VA: 0x18115BB90
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115D170 Offset: 0x115BB70 VA: 0x18115D170
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CDF0 Offset: 0x115B7F0 VA: 0x18115CDF0
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115B490 Offset: 0x1159E90 VA: 0x18115B490
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115CB50 Offset: 0x115B550 VA: 0x18115CB50
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C8B0 Offset: 0x115B2B0 VA: 0x18115C8B0
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x115C990 Offset: 0x115B390 VA: 0x18115C990
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C7A0 Offset: 0x116B1A0 VA: 0x18116C7A0
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E9C0 Offset: 0x116D3C0 VA: 0x18116E9C0
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C6C0 Offset: 0x116B0C0 VA: 0x18116C6C0
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E560 Offset: 0x116CF60 VA: 0x18116E560
	|-ReadOnlyCollection<Substring>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D3E0 Offset: 0x116BDE0 VA: 0x18116D3E0
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D140 Offset: 0x116BB40 VA: 0x18116D140
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DAE0 Offset: 0x116C4E0 VA: 0x18116DAE0
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DF40 Offset: 0x116C940 VA: 0x18116DF40
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E1E0 Offset: 0x116CBE0 VA: 0x18116E1E0
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E720 Offset: 0x116D120 VA: 0x18116E720
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CEA0 Offset: 0x116B8A0 VA: 0x18116CEA0
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E640 Offset: 0x116D040 VA: 0x18116E640
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DE60 Offset: 0x116C860 VA: 0x18116DE60
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D060 Offset: 0x116BA60 VA: 0x18116D060
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D840 Offset: 0x116C240 VA: 0x18116D840
	|-ReadOnlyCollection<UShort2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D920 Offset: 0x116C320 VA: 0x18116D920
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DCA0 Offset: 0x116C6A0 VA: 0x18116DCA0
	|-ReadOnlyCollection<UsageHint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E100 Offset: 0x116CB00 VA: 0x18116E100
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C880 Offset: 0x116B280 VA: 0x18116C880
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C5E0 Offset: 0x116AFE0 VA: 0x18116C5E0
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D760 Offset: 0x116C160 VA: 0x18116D760
	|-ReadOnlyCollection<VoxelContour>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D5A0 Offset: 0x116BFA0 VA: 0x18116D5A0
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CA40 Offset: 0x116B440 VA: 0x18116CA40
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C960 Offset: 0x116B360 VA: 0x18116C960
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116C500 Offset: 0x116AF00 VA: 0x18116C500
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D680 Offset: 0x116C080 VA: 0x18116D680
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E3A0 Offset: 0x116CDA0 VA: 0x18116E3A0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D4C0 Offset: 0x116BEC0 VA: 0x18116D4C0
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CB20 Offset: 0x116B520 VA: 0x18116CB20
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E480 Offset: 0x116CE80 VA: 0x18116E480
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D220 Offset: 0x116BC20 VA: 0x18116D220
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E8E0 Offset: 0x116D2E0 VA: 0x18116E8E0
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CF80 Offset: 0x116B980 VA: 0x18116CF80
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CDC0 Offset: 0x116B7C0 VA: 0x18116CDC0
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E020 Offset: 0x116CA20 VA: 0x18116E020
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116D300 Offset: 0x116BD00 VA: 0x18116D300
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DD80 Offset: 0x116C780 VA: 0x18116DD80
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DA00 Offset: 0x116C400 VA: 0x18116DA00
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CCE0 Offset: 0x116B6E0 VA: 0x18116CCE0
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E2C0 Offset: 0x116CCC0 VA: 0x18116E2C0
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116E800 Offset: 0x116D200 VA: 0x18116E800
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116DBC0 Offset: 0x116C5C0 VA: 0x18116DBC0
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x116CC00 Offset: 0x116B600 VA: 0x18116CC00
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E450 Offset: 0x118CE50 VA: 0x18118E450
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DF10 Offset: 0x118C910 VA: 0x18118DF10
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D030 Offset: 0x118BA30 VA: 0x18118D030
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118ED10 Offset: 0x118D710 VA: 0x18118ED10
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D810 Offset: 0x118C210 VA: 0x18118D810
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EDF0 Offset: 0x118D7F0 VA: 0x18118EDF0
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DFF0 Offset: 0x118C9F0 VA: 0x18118DFF0
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CE70 Offset: 0x118B870 VA: 0x18118CE70
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E6F0 Offset: 0x118D0F0 VA: 0x18118E6F0
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DC70 Offset: 0x118C670 VA: 0x18118DC70
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D110 Offset: 0x118BB10 VA: 0x18118D110
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D650 Offset: 0x118C050 VA: 0x18118D650
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E0D0 Offset: 0x118CAD0 VA: 0x18118E0D0
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EB50 Offset: 0x118D550 VA: 0x18118EB50
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EA70 Offset: 0x118D470 VA: 0x18118EA70
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E8B0 Offset: 0x118D2B0 VA: 0x18118E8B0
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DAB0 Offset: 0x118C4B0 VA: 0x18118DAB0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D2D0 Offset: 0x118BCD0 VA: 0x18118D2D0
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D490 Offset: 0x118BE90 VA: 0x18118D490
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D9D0 Offset: 0x118C3D0 VA: 0x18118D9D0
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CF50 Offset: 0x118B950 VA: 0x18118CF50
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DB90 Offset: 0x118C590 VA: 0x18118DB90
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E1B0 Offset: 0x118CBB0 VA: 0x18118E1B0
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D730 Offset: 0x118C130 VA: 0x18118D730
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D1F0 Offset: 0x118BBF0 VA: 0x18118D1F0
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CBD0 Offset: 0x118B5D0 VA: 0x18118CBD0
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D3B0 Offset: 0x118BDB0 VA: 0x18118D3B0
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E290 Offset: 0x118CC90 VA: 0x18118E290
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CD90 Offset: 0x118B790 VA: 0x18118CD90
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EC30 Offset: 0x118D630 VA: 0x18118EC30
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E610 Offset: 0x118D010 VA: 0x18118E610
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D570 Offset: 0x118BF70 VA: 0x18118D570
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E370 Offset: 0x118CD70 VA: 0x18118E370
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DD50 Offset: 0x118C750 VA: 0x18118DD50
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CAF0 Offset: 0x118B4F0 VA: 0x18118CAF0
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E990 Offset: 0x118D390 VA: 0x18118E990
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118DE30 Offset: 0x118C830 VA: 0x18118DE30
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118CCB0 Offset: 0x118B6B0 VA: 0x18118CCB0
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E7D0 Offset: 0x118D1D0 VA: 0x18118E7D0
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EFB0 Offset: 0x118D9B0 VA: 0x18118EFB0
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118EED0 Offset: 0x118D8D0 VA: 0x18118EED0
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118D8F0 Offset: 0x118C2F0 VA: 0x18118D8F0
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x118E530 Offset: 0x118CF30 VA: 0x18118E530
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199B10 Offset: 0x1198510 VA: 0x181199B10
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199DB0 Offset: 0x11987B0 VA: 0x181199DB0
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A590 Offset: 0x1198F90 VA: 0x18119A590
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A2F0 Offset: 0x1198CF0 VA: 0x18119A2F0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11996B0 Offset: 0x11980B0 VA: 0x1811996B0
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A750 Offset: 0x1199150 VA: 0x18119A750
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A910 Offset: 0x1199310 VA: 0x18119A910
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11995D0 Offset: 0x1197FD0 VA: 0x1811995D0
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A130 Offset: 0x1198B30 VA: 0x18119A130
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A4B0 Offset: 0x1198EB0 VA: 0x18119A4B0
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199E90 Offset: 0x1198890 VA: 0x181199E90
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A210 Offset: 0x1198C10 VA: 0x18119A210
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199790 Offset: 0x1198190 VA: 0x181199790
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199950 Offset: 0x1198350 VA: 0x181199950
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11994F0 Offset: 0x1197EF0 VA: 0x1811994F0
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199CD0 Offset: 0x11986D0 VA: 0x181199CD0
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199F70 Offset: 0x1198970 VA: 0x181199F70
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A3D0 Offset: 0x1198DD0 VA: 0x18119A3D0
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A670 Offset: 0x1199070 VA: 0x18119A670
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A830 Offset: 0x1199230 VA: 0x18119A830
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199870 Offset: 0x1198270 VA: 0x181199870
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199BF0 Offset: 0x11985F0 VA: 0x181199BF0
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199330 Offset: 0x1197D30 VA: 0x181199330
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x119A050 Offset: 0x1198A50 VA: 0x18119A050
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199A30 Offset: 0x1198430 VA: 0x181199A30
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1199410 Offset: 0x1197E10 VA: 0x181199410
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D950 Offset: 0x112C350 VA: 0x18112D950
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112FF50 Offset: 0x112E950 VA: 0x18112FF50
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1134750 Offset: 0x1133150 VA: 0x181134750
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112C460 Offset: 0x112AE60 VA: 0x18112C460
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1133AC0 Offset: 0x11324C0 VA: 0x181133AC0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112EA20 Offset: 0x112D420 VA: 0x18112EA20
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1131430 Offset: 0x112FE30 VA: 0x181131430
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1135400 Offset: 0x1133E00 VA: 0x181135400
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1133650 Offset: 0x1132050 VA: 0x181133650
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11307B0 Offset: 0x112F1B0 VA: 0x1811307B0
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112C020 Offset: 0x112AA20 VA: 0x18112C020
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1135830 Offset: 0x1134230 VA: 0x181135830
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112E5F0 Offset: 0x112CFF0 VA: 0x18112E5F0
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1132560 Offset: 0x1130F60 VA: 0x181132560
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112D100 Offset: 0x112BB00 VA: 0x18112D100
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1137160 Offset: 0x1135B60 VA: 0x181137160
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1134320 Offset: 0x1132D20 VA: 0x181134320
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11364C0 Offset: 0x1134EC0 VA: 0x1811364C0
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1131860 Offset: 0x1130260 VA: 0x181131860
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1136D20 Offset: 0x1135720 VA: 0x181136D20
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112F6E0 Offset: 0x112E0E0 VA: 0x18112F6E0
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112F2B0 Offset: 0x112DCB0 VA: 0x18112F2B0
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112C8A0 Offset: 0x112B2A0 VA: 0x18112C8A0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1133EF0 Offset: 0x11328F0 VA: 0x181133EF0
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1131010 Offset: 0x112FA10 VA: 0x181131010
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112FB20 Offset: 0x112E520 VA: 0x18112FB20
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1134FE0 Offset: 0x11339E0 VA: 0x181134FE0
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1132DD0 Offset: 0x11317D0 VA: 0x181132DD0
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1132990 Offset: 0x1131390 VA: 0x181132990
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1136090 Offset: 0x1134A90 VA: 0x181136090
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112D530 Offset: 0x112BF30 VA: 0x18112D530
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1130380 Offset: 0x112ED80 VA: 0x181130380
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1130BE0 Offset: 0x112F5E0 VA: 0x181130BE0
	|-ReadOnlyCollection<BezierContour>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112DD80 Offset: 0x112C780 VA: 0x18112DD80
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1134B90 Offset: 0x1133590 VA: 0x181134B90
	|-ReadOnlyCollection<BezierSegment>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112CCD0 Offset: 0x112B6D0 VA: 0x18112CCD0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1133210 Offset: 0x1131C10 VA: 0x181133210
	|-ReadOnlyCollection<Bounds>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112E1C0 Offset: 0x112CBC0 VA: 0x18112E1C0
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x112EE50 Offset: 0x112D850 VA: 0x18112EE50
	|-ReadOnlyCollection<CGSpot>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1132130 Offset: 0x1130B30 VA: 0x181132130
	|-ReadOnlyCollection<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11368F0 Offset: 0x11352F0 VA: 0x1811368F0
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1135C60 Offset: 0x1134660 VA: 0x181135C60
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1131CA0 Offset: 0x11306A0 VA: 0x181131CA0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1145F70 Offset: 0x1144970 VA: 0x181145F70
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1149A70 Offset: 0x1148470 VA: 0x181149A70
	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11428A0 Offset: 0x11412A0 VA: 0x1811428A0
	|-ReadOnlyCollection<ContourVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x113F5E0 Offset: 0x113DFE0 VA: 0x18113F5E0
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1142030 Offset: 0x1140A30 VA: 0x181142030
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1141390 Offset: 0x113FD90 VA: 0x181141390
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1140F60 Offset: 0x113F960 VA: 0x181140F60
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x113FA40 Offset: 0x113E440 VA: 0x18113FA40
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11417D0 Offset: 0x11401D0 VA: 0x1811417D0
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1144A20 Offset: 0x1143420 VA: 0x181144A20
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1147050 Offset: 0x1145A50 VA: 0x181147050
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1148570 Offset: 0x1146F70 VA: 0x181148570
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11463B0 Offset: 0x1144DB0 VA: 0x1811463B0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1141C00 Offset: 0x1140600 VA: 0x181141C00
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11452C0 Offset: 0x1143CC0 VA: 0x1811452C0
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1143980 Offset: 0x1142380 VA: 0x181143980
	|-ReadOnlyCollection<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11478B0 Offset: 0x11462B0 VA: 0x1811478B0
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x113FE70 Offset: 0x113E870 VA: 0x18113FE70
	|-ReadOnlyCollection<DoublePoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1147CE0 Offset: 0x11466E0 VA: 0x181147CE0
	|-ReadOnlyCollection<DualPrefab>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1143110 Offset: 0x1141B10 VA: 0x181143110
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1145720 Offset: 0x1144120 VA: 0x181145720
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1148990 Offset: 0x1147390 VA: 0x181148990
	|-ReadOnlyCollection<Entry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1143550 Offset: 0x1141F50 VA: 0x181143550
	|-ReadOnlyCollection<EventSummary>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11467E0 Offset: 0x11451E0 VA: 0x1811467E0
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x113ED00 Offset: 0x113D700 VA: 0x18113ED00
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11402A0 Offset: 0x113ECA0 VA: 0x1811402A0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1146C20 Offset: 0x1145620 VA: 0x181146C20
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x113F160 Offset: 0x113DB60 VA: 0x18113F160
	|-ReadOnlyCollection<InputBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1148110 Offset: 0x1146B10 VA: 0x181148110
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1145B50 Offset: 0x1144550 VA: 0x181145B50
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1149EA0 Offset: 0x11488A0 VA: 0x181149EA0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1148DC0 Offset: 0x11477C0 VA: 0x181148DC0
	|-ReadOnlyCollection<Int3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1142CE0 Offset: 0x11416E0 VA: 0x181142CE0
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1140B30 Offset: 0x113F530 VA: 0x181140B30
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1143DA0 Offset: 0x11427A0 VA: 0x181143DA0
	|-ReadOnlyCollection<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11445F0 Offset: 0x1142FF0 VA: 0x1811445F0
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11406D0 Offset: 0x113F0D0 VA: 0x1811406D0
	|-ReadOnlyCollection<IntPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11441C0 Offset: 0x1142BC0 VA: 0x1811441C0
	|-ReadOnlyCollection<IntRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1149200 Offset: 0x1147C00 VA: 0x181149200
	|-ReadOnlyCollection<IntRegion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1149640 Offset: 0x1148040 VA: 0x181149640
	|-ReadOnlyCollection<InternedString>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1147480 Offset: 0x1145E80 VA: 0x181147480
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1144E80 Offset: 0x1143880 VA: 0x181144E80
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1142460 Offset: 0x1140E60 VA: 0x181142460
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1151240 Offset: 0x114FC40 VA: 0x181151240
	|-ReadOnlyCollection<Label>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1153840 Offset: 0x1152240 VA: 0x181153840
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x115A2A0 Offset: 0x1158CA0 VA: 0x18115A2A0
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11555D0 Offset: 0x1153FD0 VA: 0x1811555D0
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1150160 Offset: 0x114EB60 VA: 0x181150160
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1157C60 Offset: 0x1156660 VA: 0x181157C60
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1157820 Offset: 0x1156220 VA: 0x181157820
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11580A0 Offset: 0x1156AA0 VA: 0x1811580A0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1152310 Offset: 0x1150D10 VA: 0x181152310
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1156F70 Offset: 0x1155970 VA: 0x181156F70
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1158950 Offset: 0x1157350 VA: 0x181158950
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1151AA0 Offset: 0x11504A0 VA: 0x181151AA0
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1152FD0 Offset: 0x11519D0 VA: 0x181152FD0
	|-ReadOnlyCollection<NamedValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11595F0 Offset: 0x1157FF0 VA: 0x1811595F0
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11573A0 Offset: 0x1155DA0 VA: 0x1811573A0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11516A0 Offset: 0x11500A0 VA: 0x1811516A0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1154D80 Offset: 0x1153780 VA: 0x181154D80
	|-ReadOnlyCollection<Playable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x115A6D0 Offset: 0x11590D0 VA: 0x18115A6D0
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11566D0 Offset: 0x11550D0 VA: 0x1811566D0
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1155E40 Offset: 0x1154840 VA: 0x181155E40
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11591C0 Offset: 0x1157BC0 VA: 0x1811591C0
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1159A40 Offset: 0x1158440 VA: 0x181159A40
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1154500 Offset: 0x1152F00 VA: 0x181154500
	|-ReadOnlyCollection<RaycastHit>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x115AF50 Offset: 0x1159950 VA: 0x18115AF50
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11584E0 Offset: 0x1156EE0 VA: 0x1811584E0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1153C70 Offset: 0x1152670 VA: 0x181153C70
	|-ReadOnlyCollection<RectInt>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11540A0 Offset: 0x1152AA0 VA: 0x1811540A0
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1156B30 Offset: 0x1155530 VA: 0x181156B30
	|-ReadOnlyCollection<RendererList>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1154960 Offset: 0x1153360 VA: 0x181154960
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1152770 Offset: 0x1151170 VA: 0x181152770
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11551B0 Offset: 0x1153BB0 VA: 0x1811551B0
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11562A0 Offset: 0x1154CA0 VA: 0x1811562A0
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1155A10 Offset: 0x1154410 VA: 0x181155A10
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1153410 Offset: 0x1151E10 VA: 0x181153410
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1150E20 Offset: 0x114F820 VA: 0x181150E20
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x114FD30 Offset: 0x114E730 VA: 0x18114FD30
	|-ReadOnlyCollection<Scene>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11509E0 Offset: 0x114F3E0 VA: 0x1811509E0
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1159E70 Offset: 0x1158870 VA: 0x181159E70
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1152BA0 Offset: 0x11515A0 VA: 0x181152BA0
	|-ReadOnlyCollection<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x115AB20 Offset: 0x1159520 VA: 0x18115AB20
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1151EE0 Offset: 0x11508E0 VA: 0x181151EE0
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1158D80 Offset: 0x1157780 VA: 0x181158D80
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11505A0 Offset: 0x114EFA0 VA: 0x1811505A0
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1161F80 Offset: 0x1160980 VA: 0x181161F80
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1167040 Offset: 0x1165A40 VA: 0x181167040
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1161720 Offset: 0x1160120 VA: 0x181161720
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116ABC0 Offset: 0x11695C0 VA: 0x18116ABC0
	|-ReadOnlyCollection<Substring>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116C0E0 Offset: 0x116AAE0 VA: 0x18116C0E0
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1165690 Offset: 0x1164090 VA: 0x181165690
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1169250 Offset: 0x1167C50 VA: 0x181169250
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11689E0 Offset: 0x11673E0 VA: 0x1811689E0
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1168E20 Offset: 0x1167820 VA: 0x181168E20
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1166780 Offset: 0x1165180 VA: 0x181166780
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1166C10 Offset: 0x1165610 VA: 0x181166C10
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1167470 Offset: 0x1165E70 VA: 0x181167470
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1163D60 Offset: 0x1162760 VA: 0x181163D60
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1164E40 Offset: 0x1163840 VA: 0x181164E40
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11645B0 Offset: 0x1162FB0 VA: 0x1811645B0
	|-ReadOnlyCollection<UShort2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1169AF0 Offset: 0x11684F0 VA: 0x181169AF0
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116B8A0 Offset: 0x116A2A0 VA: 0x18116B8A0
	|-ReadOnlyCollection<UsageHint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1164190 Offset: 0x1162B90 VA: 0x181164190
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116A350 Offset: 0x1168D50 VA: 0x18116A350
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11685B0 Offset: 0x1166FB0 VA: 0x1811685B0
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116AFF0 Offset: 0x11699F0 VA: 0x18116AFF0
	|-ReadOnlyCollection<VoxelContour>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1167CD0 Offset: 0x11666D0 VA: 0x181167CD0
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1163930 Offset: 0x1162330 VA: 0x181163930
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1162C90 Offset: 0x1161690 VA: 0x181162C90
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11623C0 Offset: 0x1160DC0 VA: 0x1811623C0
	|-ReadOnlyCollection<XRView>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11678A0 Offset: 0x11662A0 VA: 0x1811678A0
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1166330 Offset: 0x1164D30 VA: 0x181166330
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116B440 Offset: 0x1169E40 VA: 0x18116B440
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1165260 Offset: 0x1163C60 VA: 0x181165260
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11649E0 Offset: 0x11633E0 VA: 0x1811649E0
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11634F0 Offset: 0x1161EF0 VA: 0x1811634F0
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116A790 Offset: 0x1169190 VA: 0x18116A790
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x116BCC0 Offset: 0x116A6C0 VA: 0x18116BCC0
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1165F00 Offset: 0x1164900 VA: 0x181165F00
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1161B60 Offset: 0x1160560 VA: 0x181161B60
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11630D0 Offset: 0x1161AD0 VA: 0x1811630D0
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1160EB0 Offset: 0x115F8B0 VA: 0x181160EB0
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1162860 Offset: 0x1161260 VA: 0x181162860
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1169F20 Offset: 0x1168920 VA: 0x181169F20
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11612E0 Offset: 0x115FCE0 VA: 0x1811612E0
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1169690 Offset: 0x1168090 VA: 0x181169690
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1168180 Offset: 0x1166B80 VA: 0x181168180
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1165AB0 Offset: 0x11644B0 VA: 0x181165AB0
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1189C00 Offset: 0x1188600 VA: 0x181189C00
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11838D0 Offset: 0x11822D0 VA: 0x1811838D0
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11841A0 Offset: 0x1182BA0 VA: 0x1811841A0
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1185700 Offset: 0x1184100 VA: 0x181185700
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118B5C0 Offset: 0x1189FC0 VA: 0x18118B5C0
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118BE20 Offset: 0x118A820 VA: 0x18118BE20
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1183470 Offset: 0x1181E70 VA: 0x181183470
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1186860 Offset: 0x1185260 VA: 0x181186860
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11812C0 Offset: 0x117FCC0 VA: 0x1811812C0
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11863F0 Offset: 0x1184DF0 VA: 0x1811863F0
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1187140 Offset: 0x1185B40 VA: 0x181187140
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1181F90 Offset: 0x1180990 VA: 0x181181F90
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1186D10 Offset: 0x1185710 VA: 0x181186D10
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118A060 Offset: 0x1188A60 VA: 0x18118A060
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11897D0 Offset: 0x11881D0 VA: 0x1811897D0
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118BA00 Offset: 0x118A400 VA: 0x18118BA00
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11882A0 Offset: 0x1186CA0 VA: 0x1811882A0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118B180 Offset: 0x1189B80 VA: 0x18118B180
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11816F0 Offset: 0x11800F0 VA: 0x1811816F0
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1181B40 Offset: 0x1180540 VA: 0x181181B40
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1188F40 Offset: 0x1187940 VA: 0x181188F40
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118AD20 Offset: 0x1189720 VA: 0x18118AD20
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1183D70 Offset: 0x1182770 VA: 0x181183D70
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11886E0 Offset: 0x11870E0 VA: 0x1811886E0
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11879E0 Offset: 0x11863E0 VA: 0x1811879E0
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118A490 Offset: 0x1188E90 VA: 0x18118A490
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1189370 Offset: 0x1187D70 VA: 0x181189370
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1187E60 Offset: 0x1186860 VA: 0x181187E60
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1187580 Offset: 0x1185F80 VA: 0x181187580
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1184A20 Offset: 0x1183420 VA: 0x181184A20
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1188B10 Offset: 0x1187510 VA: 0x181188B10
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1182C10 Offset: 0x1181610 VA: 0x181182C10
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1184E80 Offset: 0x1183880 VA: 0x181184E80
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11823C0 Offset: 0x1180DC0 VA: 0x1811823C0
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1185FD0 Offset: 0x11849D0 VA: 0x181185FD0
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11827F0 Offset: 0x11811F0 VA: 0x1811827F0
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118A8F0 Offset: 0x11892F0 VA: 0x18118A8F0
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1185B70 Offset: 0x1184570 VA: 0x181185B70
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118C690 Offset: 0x118B090 VA: 0x18118C690
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11845E0 Offset: 0x1182FE0 VA: 0x1811845E0
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1183050 Offset: 0x1181A50 VA: 0x181183050
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x118C250 Offset: 0x118AC50 VA: 0x18118C250
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11852D0 Offset: 0x1183CD0 VA: 0x1811852D0
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11934B0 Offset: 0x1191EB0 VA: 0x1811934B0
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11970D0 Offset: 0x1195AD0 VA: 0x1811970D0
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1195F50 Offset: 0x1194950 VA: 0x181195F50
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11949F0 Offset: 0x11933F0 VA: 0x1811949F0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11923C0 Offset: 0x1190DC0 VA: 0x1811923C0
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1194E50 Offset: 0x1193850 VA: 0x181194E50
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11963B0 Offset: 0x1194DB0 VA: 0x1811963B0
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1193080 Offset: 0x1191A80 VA: 0x181193080
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1196800 Offset: 0x1195200 VA: 0x181196800
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1198A90 Offset: 0x1197490 VA: 0x181198A90
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11927F0 Offset: 0x11911F0 VA: 0x1811927F0
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11981C0 Offset: 0x1196BC0 VA: 0x1811981C0
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1194180 Offset: 0x1192B80 VA: 0x181194180
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1198EE0 Offset: 0x11978E0 VA: 0x181198EE0
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1197500 Offset: 0x1195F00 VA: 0x181197500
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1192C50 Offset: 0x1191650 VA: 0x181192C50
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1193D40 Offset: 0x1192740 VA: 0x181193D40
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1195B20 Offset: 0x1194520 VA: 0x181195B20
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11945C0 Offset: 0x1192FC0 VA: 0x1811945C0
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1197930 Offset: 0x1196330 VA: 0x181197930
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1197D90 Offset: 0x1196790 VA: 0x181197D90
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11956E0 Offset: 0x11940E0 VA: 0x1811956E0
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1195290 Offset: 0x1193C90 VA: 0x181195290
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11938F0 Offset: 0x11922F0 VA: 0x1811938F0
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1198630 Offset: 0x1197030 VA: 0x181198630
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1196C70 Offset: 0x1195670 VA: 0x181196C70
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Entry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Int3>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Label>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Playable>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Scene>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Substring>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<XRView>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Entry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Int3>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Label>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Playable>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Scene>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Substring>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<XRView>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113D710 Offset: 0x113C110 VA: 0x18113D710
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Entry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Playable>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Substring>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DCB0 Offset: 0x113C6B0 VA: 0x18113DCB0
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Int3>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113D9B0 Offset: 0x113C3B0 VA: 0x18113D9B0
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DB70 Offset: 0x113C570 VA: 0x18113DB70
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DA50 Offset: 0x113C450 VA: 0x18113DA50
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<long>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DAD0 Offset: 0x113C4D0 VA: 0x18113DAD0
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113D930 Offset: 0x113C330 VA: 0x18113D930
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113D880 Offset: 0x113C280 VA: 0x18113D880
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DC30 Offset: 0x113C630 VA: 0x18113DC30
	|-ReadOnlyCollection<char>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<short>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113D800 Offset: 0x113C200 VA: 0x18113D800
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Scene>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_Item
	|
	|-RVA: 0x113DD50 Offset: 0x113C750 VA: 0x18113DD50
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_Item
	|
	|-RVA: 0x114F320 Offset: 0x114DD20 VA: 0x18114F320
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x114F1A0 Offset: 0x114DBA0 VA: 0x18114F1A0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x114F3D0 Offset: 0x114DDD0 VA: 0x18114F3D0
	|-ReadOnlyCollection<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x114F250 Offset: 0x114DC50 VA: 0x18114F250
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.get_Item
	|
	|-RVA: 0x114F460 Offset: 0x114DE60 VA: 0x18114F460
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x115F990 Offset: 0x115E390 VA: 0x18115F990
	|-ReadOnlyCollection<Label>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.get_Item
	|
	|-RVA: 0x115FA40 Offset: 0x115E440 VA: 0x18115FA40
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x115FAF0 Offset: 0x115E4F0 VA: 0x18115FAF0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x112BE10 Offset: 0x112A810 VA: 0x18112BE10
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x115F900 Offset: 0x115E300 VA: 0x18115F900
	|-ReadOnlyCollection<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x11710E0 Offset: 0x116FAE0 VA: 0x1811710E0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1171290 Offset: 0x116FC90 VA: 0x181171290
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1171390 Offset: 0x116FD90 VA: 0x181171390
	|-ReadOnlyCollection<XRView>.System.Collections.IList.get_Item
	|
	|-RVA: 0x11711C0 Offset: 0x116FBC0 VA: 0x1811711C0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1171040 Offset: 0x116FA40 VA: 0x181171040
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.get_Item
	|
	|-RVA: 0x11912F0 Offset: 0x118FCF0 VA: 0x1811912F0
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.get_Item
	|
	|-RVA: 0x11913E0 Offset: 0x118FDE0 VA: 0x1811913E0
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1191530 Offset: 0x118FF30 VA: 0x181191530
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.get_Item
	|
	|-RVA: 0x11914A0 Offset: 0x118FEA0 VA: 0x1811914A0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<char>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Color32>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Connection>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<double>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Entry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<short>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Int3>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<long>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Label>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Playable>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Scene>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<float>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Substring>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<uint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<XRView>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A8A0 Offset: 0x11392A0 VA: 0x18113A8A0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.Add
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.Add
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Add
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.Add
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.Add
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.Add
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Add
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.Add
	|-ReadOnlyCollection<char>.System.Collections.IList.Add
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Add
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Add
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Add
	|-ReadOnlyCollection<Connection>.System.Collections.IList.Add
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Add
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.Add
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Add
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Add
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<double>.System.Collections.IList.Add
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.Add
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Add
	|-ReadOnlyCollection<Entry>.System.Collections.IList.Add
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Add
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.Add
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Add
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.Add
	|-ReadOnlyCollection<short>.System.Collections.IList.Add
	|-ReadOnlyCollection<Int3>.System.Collections.IList.Add
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|-ReadOnlyCollection<long>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.Add
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.Add
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Add
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Add
	|-ReadOnlyCollection<Label>.System.Collections.IList.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.Add
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Add
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Add
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Add
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Add
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Add
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Add
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Add
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Add
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Add
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.Add
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Add
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Add
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Add
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Add
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Add
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.Add
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.Add
	|-ReadOnlyCollection<Scene>.System.Collections.IList.Add
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Add
	|-ReadOnlyCollection<float>.System.Collections.IList.Add
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Add
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Add
	|-ReadOnlyCollection<Substring>.System.Collections.IList.Add
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Add
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Add
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Add
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|-ReadOnlyCollection<uint>.System.Collections.IList.Add
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Add
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.Add
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.Add
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Add
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.Add
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.Add
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Add
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.Add
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Add
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.Add
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.Add
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Add
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Add
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Add
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Add
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.Add
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.Add
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Add
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.Add
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.Add
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.Add
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.Add
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.Add
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.Add
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.Add
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.Add
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.Add
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.Add
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.Add
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.Add
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.Add
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.Add
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.Add
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.Add
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.Add
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.Add
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.Add
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.Add
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Add
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.Add
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.Add
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.Add
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.Add
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.Add
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Add
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.Add
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.Add
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Add
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Add
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.Clear
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Clear
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.Clear
	|-ReadOnlyCollection<char>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Connection>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<double>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Entry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Clear
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.Clear
	|-ReadOnlyCollection<short>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Int3>.System.Collections.IList.Clear
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|-ReadOnlyCollection<long>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Clear
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Label>.System.Collections.IList.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Clear
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Clear
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Scene>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Clear
	|-ReadOnlyCollection<float>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Substring>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|-ReadOnlyCollection<uint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.Clear
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Clear
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.Clear
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.Clear
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Clear
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.Clear
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.Clear
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BA00 Offset: 0x112A400 VA: 0x18112BA00
	|-ReadOnlyCollection<ArraySegment<byte>>.IsCompatibleObject
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.IsCompatibleObject
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.IsCompatibleObject
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, char>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.IsCompatibleObject
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.IsCompatibleObject
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.IsCompatibleObject
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<SubArray<int>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<int, int>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<int, object>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<AnimatorClipInfo>.IsCompatibleObject
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.IsCompatibleObject
	|-ReadOnlyCollection<BezierContour>.IsCompatibleObject
	|-ReadOnlyCollection<BezierPathSegment>.IsCompatibleObject
	|-ReadOnlyCollection<BezierSegment>.IsCompatibleObject
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|-ReadOnlyCollection<Bounds>.IsCompatibleObject
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|-ReadOnlyCollection<CGSpot>.IsCompatibleObject
	|-ReadOnlyCollection<char>.IsCompatibleObject
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|-ReadOnlyCollection<Color32>.IsCompatibleObject
	|-ReadOnlyCollection<CombineInstance>.IsCompatibleObject
	|-ReadOnlyCollection<ComputedTransitionProperty>.IsCompatibleObject
	|-ReadOnlyCollection<Connection>.IsCompatibleObject
	|-ReadOnlyCollection<ContourVertex>.IsCompatibleObject
	|-ReadOnlyCollection<ControlPointOption>.IsCompatibleObject
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.IsCompatibleObject
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.IsCompatibleObject
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.IsCompatibleObject
	|-ReadOnlyCollection<CoordinateStorageTilePair>.IsCompatibleObject
	|-ReadOnlyCollection<CoordinateTilePair>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<DateTime>.IsCompatibleObject
	|-ReadOnlyCollection<DateTimeOffset>.IsCompatibleObject
	|-ReadOnlyCollection<Decimal>.IsCompatibleObject
	|-ReadOnlyCollection<DisplayInfo>.IsCompatibleObject
	|-ReadOnlyCollection<double>.IsCompatibleObject
	|-ReadOnlyCollection<DoublePoint>.IsCompatibleObject
	|-ReadOnlyCollection<DoublePoint>.IsCompatibleObject
	|-ReadOnlyCollection<DualPrefab>.IsCompatibleObject
	|-ReadOnlyCollection<DuplicateSamplePoint>.IsCompatibleObject
	|-ReadOnlyCollection<EasingFunction>.IsCompatibleObject
	|-ReadOnlyCollection<Entry>.IsCompatibleObject
	|-ReadOnlyCollection<EventSummary>.IsCompatibleObject
	|-ReadOnlyCollection<FrameTimeSample>.IsCompatibleObject
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<GlyphRect>.IsCompatibleObject
	|-ReadOnlyCollection<Guid>.IsCompatibleObject
	|-ReadOnlyCollection<InputBinding>.IsCompatibleObject
	|-ReadOnlyCollection<InputDeviceDescription>.IsCompatibleObject
	|-ReadOnlyCollection<InputEventPtr>.IsCompatibleObject
	|-ReadOnlyCollection<short>.IsCompatibleObject
	|-ReadOnlyCollection<Int3>.IsCompatibleObject
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|-ReadOnlyCollection<long>.IsCompatibleObject
	|-ReadOnlyCollection<IntPoint>.IsCompatibleObject
	|-ReadOnlyCollection<IntPoint>.IsCompatibleObject
	|-ReadOnlyCollection<IntRect>.IsCompatibleObject
	|-ReadOnlyCollection<IntRegion>.IsCompatibleObject
	|-ReadOnlyCollection<InternedString>.IsCompatibleObject
	|-ReadOnlyCollection<InterpretedFrameInfo>.IsCompatibleObject
	|-ReadOnlyCollection<IntervalTreeNode>.IsCompatibleObject
	|-ReadOnlyCollection<JsonPosition>.IsCompatibleObject
	|-ReadOnlyCollection<Label>.IsCompatibleObject
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<ManipulatorActivationFilter>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<Matrix4x4>.IsCompatibleObject
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<NameAndParameters>.IsCompatibleObject
	|-ReadOnlyCollection<NamedValue>.IsCompatibleObject
	|-ReadOnlyCollection<NavMeshBuildMarkup>.IsCompatibleObject
	|-ReadOnlyCollection<NavMeshBuildSource>.IsCompatibleObject
	|-ReadOnlyCollection<Playable>.IsCompatibleObject
	|-ReadOnlyCollection<PlayableBinding>.IsCompatibleObject
	|-ReadOnlyCollection<PlayerLoopSystem>.IsCompatibleObject
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.IsCompatibleObject
	|-ReadOnlyCollection<Quaternion>.IsCompatibleObject
	|-ReadOnlyCollection<RangePositionInfo>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastHit>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastHit2D>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastResult>.IsCompatibleObject
	|-ReadOnlyCollection<RectInt>.IsCompatibleObject
	|-ReadOnlyCollection<RenderTargetIdentifier>.IsCompatibleObject
	|-ReadOnlyCollection<RendererList>.IsCompatibleObject
	|-ReadOnlyCollection<RendererListHandle>.IsCompatibleObject
	|-ReadOnlyCollection<Resolution>.IsCompatibleObject
	|-ReadOnlyCollection<ResourceHandle>.IsCompatibleObject
	|-ReadOnlyCollection<RuleMatcher>.IsCompatibleObject
	|-ReadOnlyCollection<sbyte>.IsCompatibleObject
	|-ReadOnlyCollection<SamplePointUData>.IsCompatibleObject
	|-ReadOnlyCollection<SamplePointsPatch>.IsCompatibleObject
	|-ReadOnlyCollection<Scene>.IsCompatibleObject
	|-ReadOnlyCollection<SelectorMatchRecord>.IsCompatibleObject
	|-ReadOnlyCollection<ShaderTagId>.IsCompatibleObject
	|-ReadOnlyCollection<float>.IsCompatibleObject
	|-ReadOnlyCollection<StylePropertyName>.IsCompatibleObject
	|-ReadOnlyCollection<StylePropertyValue>.IsCompatibleObject
	|-ReadOnlyCollection<StyleSelectorPart>.IsCompatibleObject
	|-ReadOnlyCollection<StyleSyntaxToken>.IsCompatibleObject
	|-ReadOnlyCollection<StyleValue>.IsCompatibleObject
	|-ReadOnlyCollection<StyleValueManaged>.IsCompatibleObject
	|-ReadOnlyCollection<StyleVariable>.IsCompatibleObject
	|-ReadOnlyCollection<Substring>.IsCompatibleObject
	|-ReadOnlyCollection<TimeSpan>.IsCompatibleObject
	|-ReadOnlyCollection<TimeValue>.IsCompatibleObject
	|-ReadOnlyCollection<TreeViewItemWrapper>.IsCompatibleObject
	|-ReadOnlyCollection<UICharInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UILineInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UIVertex>.IsCompatibleObject
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|-ReadOnlyCollection<uint>.IsCompatibleObject
	|-ReadOnlyCollection<UInt32Enum>.IsCompatibleObject
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|-ReadOnlyCollection<UShort2>.IsCompatibleObject
	|-ReadOnlyCollection<UnloadedScene>.IsCompatibleObject
	|-ReadOnlyCollection<UsageHint>.IsCompatibleObject
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|-ReadOnlyCollection<Vector4>.IsCompatibleObject
	|-ReadOnlyCollection<VoxelContour>.IsCompatibleObject
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.IsCompatibleObject
	|-ReadOnlyCollection<X509ChainStatus>.IsCompatibleObject
	|-ReadOnlyCollection<XRFeatureDescriptor>.IsCompatibleObject
	|-ReadOnlyCollection<XRView>.IsCompatibleObject
	|-ReadOnlyCollection<ZipGenericExtraField>.IsCompatibleObject
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.IsCompatibleObject
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.IsCompatibleObject
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.IsCompatibleObject
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.IsCompatibleObject
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|-ReadOnlyCollection<BitmapAllocator32.Page>.IsCompatibleObject
	|-ReadOnlyCollection<CameraState.CustomBlendable>.IsCompatibleObject
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.IsCompatibleObject
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.IsCompatibleObject
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.IsCompatibleObject
	|-ReadOnlyCollection<ClipperLib.IntPoint>.IsCompatibleObject
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.IsCompatibleObject
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.IsCompatibleObject
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.IsCompatibleObject
	|-ReadOnlyCollection<FocusController.FocusedElement>.IsCompatibleObject
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.IsCompatibleObject
	|-ReadOnlyCollection<Funnel.PathPart>.IsCompatibleObject
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.IsCompatibleObject
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.IsCompatibleObject
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.IsCompatibleObject
	|-ReadOnlyCollection<HIDParser.HIDReportData>.IsCompatibleObject
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.IsCompatibleObject
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.IsCompatibleObject
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.IsCompatibleObject
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.IsCompatibleObject
	|-ReadOnlyCollection<JsonParser.JsonValue>.IsCompatibleObject
	|-ReadOnlyCollection<LatencySimulator.Message>.IsCompatibleObject
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.IsCompatibleObject
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.IsCompatibleObject
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.IsCompatibleObject
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.IsCompatibleObject
	|-ReadOnlyCollection<PlayingCard.CardData>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.IsCompatibleObject
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.IsCompatibleObject
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IsCompatibleObject
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.IsCompatibleObject
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.IsCompatibleObject
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.IsCompatibleObject
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.IsCompatibleObject
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.IsCompatibleObject
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.IsCompatibleObject
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.IsCompatibleObject
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.IsCompatibleObject
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.IsCompatibleObject
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.IsCompatibleObject
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.IsCompatibleObject
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.IsCompatibleObject
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.IsCompatibleObject
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.IsCompatibleObject
	|-ReadOnlyCollection<ShadowUtility.Edge>.IsCompatibleObject
	|-ReadOnlyCollection<StructySync.ChangeData>.IsCompatibleObject
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.IsCompatibleObject
	|-ReadOnlyCollection<SyncTimer.ChangeData>.IsCompatibleObject
	|-ReadOnlyCollection<TargetStateListener.Callback>.IsCompatibleObject
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.IsCompatibleObject
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.IsCompatibleObject
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.IsCompatibleObject
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.IsCompatibleObject
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.IsCompatibleObject
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.IsCompatibleObject
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.IsCompatibleObject
	|-ReadOnlyCollection<UIRStylePainter.Entry>.IsCompatibleObject
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.IsCompatibleObject
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.IsCompatibleObject
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.IsCompatibleObject
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.IsCompatibleObject
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.IsCompatibleObject
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.IsCompatibleObject
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.IsCompatibleObject
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IsCompatibleObject
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.IsCompatibleObject
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.IsCompatibleObject
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.IsCompatibleObject
	|
	|-RVA: 0x112BA60 Offset: 0x112A460 VA: 0x18112BA60
	|-ReadOnlyCollection<Nullable<DateTime>>.IsCompatibleObject
	|
	|-RVA: 0x112BAE0 Offset: 0x112A4E0 VA: 0x18112BAE0
	|-ReadOnlyCollection<Nullable<Decimal>>.IsCompatibleObject
	|
	|-RVA: 0x114FB00 Offset: 0x114E500 VA: 0x18114FB00
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x11609A0 Offset: 0x115F3A0 VA: 0x1811609A0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A8C0 Offset: 0x11392C0 VA: 0x18113A8C0
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Connection>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Entry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Substring>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Contains
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.Contains
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Contains
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.Contains
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B100 Offset: 0x1139B00 VA: 0x18113B100
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Int3>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x113AA70 Offset: 0x1139470 VA: 0x18113AA70
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Contains
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Contains
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.Contains
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.Contains
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B7B0 Offset: 0x113A1B0 VA: 0x18113B7B0
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B9C0 Offset: 0x113A3C0 VA: 0x18113B9C0
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B440 Offset: 0x1139E40 VA: 0x18113B440
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.Contains
	|
	|-RVA: 0x113ADE0 Offset: 0x11397E0 VA: 0x18113ADE0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x113AC30 Offset: 0x1139630 VA: 0x18113AC30
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.Contains
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B2B0 Offset: 0x1139CB0 VA: 0x18113B2B0
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x113BB80 Offset: 0x113A580 VA: 0x18113BB80
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Contains
	|
	|-RVA: 0x113B620 Offset: 0x113A020 VA: 0x18113B620
	|-ReadOnlyCollection<char>.System.Collections.IList.Contains
	|-ReadOnlyCollection<short>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x113AF70 Offset: 0x1139970 VA: 0x18113AF70
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Scene>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Contains
	|
	|-RVA: 0x113BD70 Offset: 0x113A770 VA: 0x18113BD70
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Contains
	|
	|-RVA: 0x114DE50 Offset: 0x114C850 VA: 0x18114DE50
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Contains
	|
	|-RVA: 0x114D9A0 Offset: 0x114C3A0 VA: 0x18114D9A0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.Contains
	|
	|-RVA: 0x114E210 Offset: 0x114CC10 VA: 0x18114E210
	|-ReadOnlyCollection<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x114DB70 Offset: 0x114C570 VA: 0x18114DB70
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.Contains
	|
	|-RVA: 0x114D770 Offset: 0x114C170 VA: 0x18114D770
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.Contains
	|
	|-RVA: 0x114E020 Offset: 0x114CA20 VA: 0x18114E020
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x114DD30 Offset: 0x114C730 VA: 0x18114DD30
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|-ReadOnlyCollection<uint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x114D5E0 Offset: 0x114BFE0 VA: 0x18114D5E0
	|-ReadOnlyCollection<long>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x115E860 Offset: 0x115D260 VA: 0x18115E860
	|-ReadOnlyCollection<Label>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.Contains
	|
	|-RVA: 0x115EDF0 Offset: 0x115D7F0 VA: 0x18115EDF0
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x115EA40 Offset: 0x115D440 VA: 0x18115EA40
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.Contains
	|
	|-RVA: 0x115EC60 Offset: 0x115D660 VA: 0x18115EC60
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x115E6C0 Offset: 0x115D0C0 VA: 0x18115E6C0
	|-ReadOnlyCollection<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x116F810 Offset: 0x116E210 VA: 0x18116F810
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x1170270 Offset: 0x116EC70 VA: 0x181170270
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x116FC40 Offset: 0x116E640 VA: 0x18116FC40
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.Contains
	|
	|-RVA: 0x116FEC0 Offset: 0x116E8C0 VA: 0x18116FEC0
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Contains
	|
	|-RVA: 0x1170150 Offset: 0x116EB50 VA: 0x181170150
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	|
	|-RVA: 0x116FA70 Offset: 0x116E470 VA: 0x18116FA70
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Contains
	|
	|-RVA: 0x1190010 Offset: 0x118EA10 VA: 0x181190010
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.Contains
	|
	|-RVA: 0x118FE00 Offset: 0x118E800 VA: 0x18118FE00
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.Contains
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.Contains
	|
	|-RVA: 0x1190270 Offset: 0x118EC70 VA: 0x181190270
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.Contains
	|
	|-RVA: 0x1190530 Offset: 0x118EF30 VA: 0x181190530
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.Contains
	|
	|-RVA: 0x11906C0 Offset: 0x118F0C0 VA: 0x1811906C0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113C310 Offset: 0x113AD10 VA: 0x18113C310
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Connection>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Entry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Guid>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Playable>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Substring>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113C660 Offset: 0x113B060 VA: 0x18113C660
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Int3>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113C810 Offset: 0x113B210 VA: 0x18113C810
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113CEF0 Offset: 0x113B8F0 VA: 0x18113CEF0
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113D100 Offset: 0x113BB00 VA: 0x18113D100
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113C9D0 Offset: 0x113B3D0 VA: 0x18113C9D0
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113C4C0 Offset: 0x113AEC0 VA: 0x18113C4C0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113C150 Offset: 0x113AB50 VA: 0x18113C150
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113CD50 Offset: 0x113B750 VA: 0x18113CD50
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113D2D0 Offset: 0x113BCD0 VA: 0x18113D2D0
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113BFB0 Offset: 0x113A9B0 VA: 0x18113BFB0
	|-ReadOnlyCollection<char>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<short>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113CBB0 Offset: 0x113B5B0 VA: 0x18113CBB0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Scene>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x113D4C0 Offset: 0x113BEC0 VA: 0x18113D4C0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114E3B0 Offset: 0x114CDB0 VA: 0x18114E3B0
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114E580 Offset: 0x114CF80 VA: 0x18114E580
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114F000 Offset: 0x114DA00 VA: 0x18114F000
	|-ReadOnlyCollection<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114EE40 Offset: 0x114D840 VA: 0x18114EE40
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114E880 Offset: 0x114D280 VA: 0x18114E880
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114EAB0 Offset: 0x114D4B0 VA: 0x18114EAB0
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114E750 Offset: 0x114D150 VA: 0x18114E750
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<uint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x114ECA0 Offset: 0x114D6A0 VA: 0x18114ECA0
	|-ReadOnlyCollection<long>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x115F200 Offset: 0x115DC00 VA: 0x18115F200
	|-ReadOnlyCollection<Label>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x115F580 Offset: 0x115DF80 VA: 0x18115F580
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x115EFD0 Offset: 0x115D9D0 VA: 0x18115EFD0
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x115F760 Offset: 0x115E160 VA: 0x18115F760
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x115F3E0 Offset: 0x115DDE0 VA: 0x18115F3E0
	|-ReadOnlyCollection<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1170DE0 Offset: 0x116F7E0 VA: 0x181170DE0
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1170B00 Offset: 0x116F500 VA: 0x181170B00
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x11705F0 Offset: 0x116EFF0 VA: 0x1811705F0
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1170870 Offset: 0x116F270 VA: 0x181170870
	|-ReadOnlyCollection<XRView>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1170CC0 Offset: 0x116F6C0 VA: 0x181170CC0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1170420 Offset: 0x116EE20 VA: 0x181170420
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1190870 Offset: 0x118F270 VA: 0x181190870
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1190E20 Offset: 0x118F820 VA: 0x181190E20
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1191030 Offset: 0x118FA30 VA: 0x181191030
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1190C80 Offset: 0x118F680 VA: 0x181190C80
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1190AD0 Offset: 0x118F4D0 VA: 0x181190AD0
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.Insert
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Insert
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.Insert
	|-ReadOnlyCollection<char>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Connection>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<double>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Entry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Insert
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.Insert
	|-ReadOnlyCollection<short>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Int3>.System.Collections.IList.Insert
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|-ReadOnlyCollection<long>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Insert
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Label>.System.Collections.IList.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Insert
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Insert
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Scene>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Insert
	|-ReadOnlyCollection<float>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Substring>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|-ReadOnlyCollection<uint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.Insert
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Insert
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.Insert
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.Insert
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Insert
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.Insert
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.Insert
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.Remove
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.Remove
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.Remove
	|-ReadOnlyCollection<char>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Connection>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<double>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Entry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.Remove
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.Remove
	|-ReadOnlyCollection<short>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Int3>.System.Collections.IList.Remove
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|-ReadOnlyCollection<long>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.Remove
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Label>.System.Collections.IList.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.Remove
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Playable>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Remove
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Scene>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.Remove
	|-ReadOnlyCollection<float>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Substring>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|-ReadOnlyCollection<uint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.Remove
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Remove
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.Remove
	|-ReadOnlyCollection<XRView>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.Remove
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Remove
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.Remove
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.Remove
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BB60 Offset: 0x112A560 VA: 0x18112BB60
	|-ReadOnlyCollection<ArraySegment<byte>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SyncList.CachedOnChange<int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SyncList.ChangeData<int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntervalTree.Entry<object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, char>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, JsonParser.JsonValue>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<PropertyName, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<Rect, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<CopyClosingMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<CopyClosingMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Nullable<DateTime>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Nullable<Decimal>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SubArray<int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, Scene>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, Vector2Int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AnimatorClipInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AsyncGPUReadbackRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BezierContour>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BezierPathSegment>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BezierSegment>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Bounds>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CGSpot>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<char>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Color32>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Connection>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ContourVertex>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ControlPointOption>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CoordinateFootprintTilePair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CoordinateProceduralTilePair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CoordinateStorageFootprintTilePair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CoordinateStorageTilePair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CoordinateTilePair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<double>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DoublePoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DualPrefab>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DuplicateSamplePoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Entry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EventSummary>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<FrameTimeSample>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputBinding>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputDeviceDescription>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputEventPtr>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<short>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Int3>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<long>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntPoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntRect>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntRegion>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InternedString>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntervalTreeNode>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Label>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Matrix4x4>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NameAndParameters>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NamedValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NavMeshBuildMarkup>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NavMeshBuildSource>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Playable>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PlayableBinding>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PlayerLoopSystem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PlayerLoopSystemInternal>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastHit>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RectInt>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RendererList>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RendererListHandle>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ResourceHandle>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SamplePointUData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SamplePointsPatch>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Scene>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ShaderTagId>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<float>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Substring>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<uint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UShort2>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UnloadedScene>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UsageHint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VoxelContour>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Win32_IP_ADAPTER_ADDRESSES>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<XRFeatureDescriptor>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<XRView>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ZipGenericExtraField>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AdvancedSmooth.Turn>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AvatarSettings.LayerSetting>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CameraState.CustomBlendable>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CinemachineClearShot.Pair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CinemachineStateDrivenCamera.HashPair>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ClipperLib.DoublePoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ClipperLib.IntPoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ConfinerOven.PolygonSolution>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DecalEntityIndexer.DecalEntityItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DecalEntityManager.CombinedChunks>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<FrameTimingsHUDDisplay.FrameTimingPoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Funnel.PathPart>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GodRaysRenderPass.VisibleLightRemap>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HID.HIDCollectionDescriptor>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HID.HIDElementDescriptor>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HIDParser.HIDReportData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HeatmapManager.PropertyRegionReference>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputActionMap.BindingOverrideJson>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputControlLayout.ControlItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputTransformSpots.TransformSpot>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<JsonParser.JsonValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<LatencySimulator.Message>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeMethods.TASKDIALOG_BUTTON>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NetworkAnimator.TriggerUpdate>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<OutlineEffect.OutlineTargetGroup>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PlayingCard.CardData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeBrickIndex.ReservedBrick>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableBoundItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializableHasPVItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVBakeSettings>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ProbeVolumeSceneData.SerializablePVProfile>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderChain.RenderNodeData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderGraphDebugData.PassDebugData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderGraphDebugData.ResourceDebugData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RetainedGizmos.MeshWithHash>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RigidbodyPauser.Rigidbody2DData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RigidbodyPauser.RigidbodyData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RigidbodyPrediction.MoveData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SVGDocument.HierarchyUpdate>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SVGDocument.NodeReferenceData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SVGDocument.NodeWithParent>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SVGDocument.PostponedClip>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SVGDocument.PostponedStopData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ServerSocket.ConnectionChange>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SewerMushroomLocation.MushroomLocationData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ShadowUtility.Edge>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StructySync.ChangeData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SyncStopwatch.ChangeData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SyncTimer.ChangeData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TargetStateListener.Callback>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TrackedDeviceRaycaster.RaycastHitData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TransportManager.DisconnectingClient>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRStylePainter.Entry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRStylePainter.RepeatRectUV>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DebugUI.Foldout.ContextMenuItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputControlLayout.Collection.LayoutMatcher>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TargetPositionCache.CacheCurve.Item>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IList.RemoveAt
	*/
}
