public sealed class Action<T> : MulticastDelegate // TypeDefIndex: 3570
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F840 Offset: 0xB0E240 VA: 0x180B0F840
	|-Action<ArraySegment<byte>>..ctor
	|-Action<SyncList.CachedOnChange<int>>..ctor
	|-Action<KeyValuePair<int, object>>..ctor
	|-Action<KeyValuePair<object, bool>>..ctor
	|-Action<KeyValuePair<object, char>>..ctor
	|-Action<KeyValuePair<object, object>>..ctor
	|-Action<KeyValuePair<PropertyName, object>>..ctor
	|-Action<NativeArray<ConvertMeshJobData>>..ctor
	|-Action<NativeArray<CopyClosingMeshJobData>>..ctor
	|-Action<NativeArray<NudgeJobData>>..ctor
	|-Action<NativeSlice<ConvertMeshJobData>>..ctor
	|-Action<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-Action<NativeSlice<NudgeJobData>>..ctor
	|-Action<Nullable<DateTime>>..ctor
	|-Action<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|-Action<StructMultiKey<object, object>>..ctor
	|-Action<SubArray<int>>..ctor
	|-Action<ValueTuple<int, object>>..ctor
	|-Action<ValueTuple<object, object>>..ctor
	|-Action<AsyncGPUReadbackRequest>..ctor
	|-Action<AsyncWebRequestData>..ctor
	|-Action<BezierContour>..ctor
	|-Action<Color>..ctor
	|-Action<Connection>..ctor
	|-Action<CoordinateFootprintTilePair>..ctor
	|-Action<CoordinateStorageFootprintTilePair>..ctor
	|-Action<CoordinateStorageTilePair>..ctor
	|-Action<CoordinateTilePair>..ctor
	|-Action<DateTimeOffset>..ctor
	|-Action<Decimal>..ctor
	|-Action<DoublePoint>..ctor
	|-Action<DoublePoint>..ctor
	|-Action<DualPrefab>..ctor
	|-Action<Entry>..ctor
	|-Action<EventSummary>..ctor
	|-Action<GlyphRect>..ctor
	|-Action<Guid>..ctor
	|-Action<InputDevice>..ctor
	|-Action<IntPoint>..ctor
	|-Action<IntRect>..ctor
	|-Action<InternedString>..ctor
	|-Action<InterpretedFrameInfo>..ctor
	|-Action<LigatureSubstitutionRecord>..ctor
	|-Action<LigatureSubstitutionRecord>..ctor
	|-Action<MultipleSubstitutionRecord>..ctor
	|-Action<MultipleSubstitutionRecord>..ctor
	|-Action<NetworkTrafficArgs>..ctor
	|-Action<Playable>..ctor
	|-Action<Quaternion>..ctor
	|-Action<RangePositionInfo>..ctor
	|-Action<RectInt>..ctor
	|-Action<Resolution>..ctor
	|-Action<RuleMatcher>..ctor
	|-Action<SamplePointUData>..ctor
	|-Action<SceneLoadPercentEventArgs>..ctor
	|-Action<StylePropertyName>..ctor
	|-Action<StylePropertyValue>..ctor
	|-Action<StyleValueManaged>..ctor
	|-Action<Substring>..ctor
	|-Action<TimerState>..ctor
	|-Action<UILineInfo>..ctor
	|-Action<UnloadedScene>..ctor
	|-Action<VFXOutputEventArgs>..ctor
	|-Action<Vector4>..ctor
	|-Action<X509ChainStatus>..ctor
	|-Action<ZipGenericExtraField>..ctor
	|-Action<AdvancedSmooth.Turn>..ctor
	|-Action<BeforeRenderHelper.OrderBlock>..ctor
	|-Action<CameraState.CustomBlendable>..ctor
	|-Action<ClipperLib.DoublePoint>..ctor
	|-Action<ClipperLib.IntPoint>..ctor
	|-Action<ConfinerOven.PolygonSolution>..ctor
	|-Action<FocusController.FocusedElement>..ctor
	|-Action<HeatmapManager.PropertyRegionReference>..ctor
	|-Action<InputAction.CallbackContext>..ctor
	|-Action<InputStateHistory.Record>..ctor
	|-Action<InputTransformSpots.TransformSpot>..ctor
	|-Action<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-Action<NativeMethods.TASKDIALOG_BUTTON>..ctor
	|-Action<OutlineEffect.OutlineTargetGroup>..ctor
	|-Action<ProbeVolumeSceneData.SerializableHasPVItem>..ctor
	|-Action<ProbeVolumeSceneData.SerializablePVProfile>..ctor
	|-Action<RigidbodyPrediction.MoveData>..ctor
	|-Action<SVGDocument.NodeWithParent>..ctor
	|-Action<ServerSocket.ConnectionChange>..ctor
	|-Action<TargetStateListener.Callback>..ctor
	|-Action<TextSettings.FontReferenceMap>..ctor
	|-Action<TextureRegistry.TextureInfo>..ctor
	|-Action<TransportManager.DisconnectingClient>..ctor
	|-Action<VisualTreeAsset.SlotDefinition>..ctor
	|-Action<VisualTreeAsset.SlotUsageEntry>..ctor
	|-Action<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-Action<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-Action<DebugUI.Foldout.ContextMenuItem>..ctor
	|
	|-RVA: 0xFE2F60 Offset: 0xFE1960 VA: 0x180FE2F60
	|-Action<AsyncLocalValueChangedArgs<object>>..ctor
	|-Action<IntervalTree.Entry<object>>..ctor
	|-Action<KeyValuePair<Rect, object>>..ctor
	|-Action<Nullable<Decimal>>..ctor
	|-Action<TempAllocator.Page<ushort>>..ctor
	|-Action<TempAllocator.Page<Vertex>>..ctor
	|-Action<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|-Action<BezierPathSegment>..ctor
	|-Action<Bounds>..ctor
	|-Action<ClientPresenceChangeEventArgs>..ctor
	|-Action<ClientReceivedDataArgs>..ctor
	|-Action<ComputedTransitionProperty>..ctor
	|-Action<ContourVertex>..ctor
	|-Action<CoordinateProceduralTilePair>..ctor
	|-Action<FrameTimeSample>..ctor
	|-Action<IntervalTreeNode>..ctor
	|-Action<JsonPosition>..ctor
	|-Action<MarkToBaseAdjustmentRecord>..ctor
	|-Action<MarkToBaseAdjustmentRecord>..ctor
	|-Action<MarkToMarkAdjustmentRecord>..ctor
	|-Action<MarkToMarkAdjustmentRecord>..ctor
	|-Action<NameAndParameters>..ctor
	|-Action<NamedValue>..ctor
	|-Action<RendererList>..ctor
	|-Action<SelectorMatchRecord>..ctor
	|-Action<StyleSelectorPart>..ctor
	|-Action<StyleSyntaxToken>..ctor
	|-Action<StyleValue>..ctor
	|-Action<StyleVariable>..ctor
	|-Action<TreeViewItemWrapper>..ctor
	|-Action<WebResponse>..ctor
	|-Action<XRFeatureDescriptor>..ctor
	|-Action<AvatarSettings.LayerSetting>..ctor
	|-Action<HID.HIDCollectionDescriptor>..ctor
	|-Action<LatencySimulator.Message>..ctor
	|-Action<RetainedGizmos.MeshWithHash>..ctor
	|-Action<SVGDocument.HierarchyUpdate>..ctor
	|-Action<StructySync.ChangeData>..ctor
	|-Action<TemplateAsset.AttributeOverride>..ctor
	|-Action<TimeNotificationBehaviour.NotificationEntry>..ctor
	|-Action<UnitySynchronizationContext.WorkRequest>..ctor
	|-Action<VisualTreeAsset.UsingEntry>..ctor
	|-Action<InputControlLayout.Collection.LayoutMatcher>..ctor
	|
	|-RVA: 0xFE2EB0 Offset: 0xFE18B0 VA: 0x180FE2EB0
	|-Action<SyncList.ChangeData<int>>..ctor
	|-Action<ValueTuple<int, Vector2Int>>..ctor
	|-Action<DuplicateSamplePoint>..ctor
	|-Action<Int3>..ctor
	|-Action<IntRegion>..ctor
	|-Action<ManipulatorActivationFilter>..ctor
	|-Action<RemoteConnectionStateArgs>..ctor
	|-Action<UICharInfo>..ctor
	|-Action<Vector3>..ctor
	|-Action<DecalEntityIndexer.DecalEntityItem>..ctor
	|-Action<HIDParser.HIDReportData>..ctor
	|-Action<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-Action<SyncTimer.ChangeData>..ctor
	|
	|-RVA: 0xFE3170 Offset: 0xFE1B70 VA: 0x180FE3170
	|-Action<KeyValuePair<object, JsonParser.JsonValue>>..ctor
	|-Action<RaycastResult>..ctor
	|-Action<UIRStylePainter.Entry>..ctor
	|-Action<UIRenderDevice.AllocToUpdate>..ctor
	|
	|-RVA: 0xFE3010 Offset: 0xFE1A10 VA: 0x180FE3010
	|-Action<ValueTuple<int, int>>..ctor
	|-Action<ValueTuple<int, Scene>>..ctor
	|-Action<AnimatorClipInfo>..ctor
	|-Action<ClientConnectionChangeBroadcast>..ctor
	|-Action<ClientConnectionStateArgs>..ctor
	|-Action<ConnectedClientsArgs>..ctor
	|-Action<ConnectedClientsBroadcast>..ctor
	|-Action<DateTime>..ctor
	|-Action<InputEventPtr>..ctor
	|-Action<LoadScenesBroadcast>..ctor
	|-Action<RendererListHandle>..ctor
	|-Action<ResourceHandle>..ctor
	|-Action<SamplePointsPatch>..ctor
	|-Action<SceneLoadStartEventArgs>..ctor
	|-Action<SceneUnloadStartEventArgs>..ctor
	|-Action<ServerConnectionStateArgs>..ctor
	|-Action<TimeSpan>..ctor
	|-Action<TimeValue>..ctor
	|-Action<UnloadScenesBroadcast>..ctor
	|-Action<UsageHint>..ctor
	|-Action<BitmapAllocator32.Page>..ctor
	|-Action<CinemachineClearShot.Pair>..ctor
	|-Action<CinemachineStateDrivenCamera.HashPair>..ctor
	|-Action<PlayingCard.CardData>..ctor
	|-Action<SVGDocument.PostponedClip>..ctor
	|-Action<SVGDocument.PostponedStopData>..ctor
	|-Action<SyncStopwatch.ChangeData>..ctor
	|
	|-RVA: 0xFE3220 Offset: 0xFE1C20 VA: 0x180FE3220
	|-Action<BezierSegment>..ctor
	|-Action<NavMeshBuildMarkup>..ctor
	|-Action<PlayableBinding>..ctor
	|-Action<SceneLoadEndEventArgs>..ctor
	|-Action<VoxelContour>..ctor
	|-Action<FrameTimingsHUDDisplay.FrameTimingPoint>..ctor
	|-Action<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>..ctor
	|-Action<ProbeVolumeSceneData.SerializableBoundItem>..ctor
	|-Action<SVGDocument.NodeReferenceData>..ctor
	|-Action<TrackedDeviceRaycaster.RaycastHitData>..ctor
	|-Action<UIRStylePainter.RepeatRectUV>..ctor
	|-Action<VisualTreeAsset.AssetEntry>..ctor
	|-Action<InstructionList.DebugView.InstructionView>..ctor
	|-Action<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|
	|-RVA: 0x642E10 Offset: 0x641810 VA: 0x180642E10
	|-Action<bool>..ctor
	|-Action<byte>..ctor
	|-Action<ByteEnum>..ctor
	|-Action<sbyte>..ctor
	|
	|-RVA: 0xFE32D0 Offset: 0xFE1CD0 VA: 0x180FE32D0
	|-Action<CGSpot>..ctor
	|-Action<GlyphPairAdjustmentRecord>..ctor
	|-Action<RaycastHit>..ctor
	|
	|-RVA: 0xFE30C0 Offset: 0xFE1AC0 VA: 0x180FE30C0
	|-Action<char>..ctor
	|-Action<short>..ctor
	|-Action<ushort>..ctor
	|
	|-RVA: 0x12CAF60 Offset: 0x12C9960 VA: 0x1812CAF60
	|-Action<Color32>..ctor
	|-Action<EasingFunction>..ctor
	|-Action<Scene>..ctor
	|-Action<ShaderTagId>..ctor
	|-Action<UShort2>..ctor
	|-Action<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x14B29A0 Offset: 0x14B13A0 VA: 0x1814B29A0
	|-Action<CombineInstance>..ctor
	|
	|-RVA: 0x14B1DF0 Offset: 0x14B07F0 VA: 0x1814B1DF0
	|-Action<ControlPointOption>..ctor
	|-Action<RaycastHit2D>..ctor
	|-Action<Funnel.PathPart>..ctor
	|-Action<SewerMushroomLocation.MushroomLocationData>..ctor
	|-Action<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x14B2420 Offset: 0x14B0E20 VA: 0x1814B2420
	|-Action<DisplayInfo>..ctor
	|-Action<IntPoint>..ctor
	|-Action<RigidbodyPauser.Rigidbody2DData>..ctor
	|
	|-RVA: 0x12CB1D0 Offset: 0x12C9BD0 VA: 0x1812CB1D0
	|-Action<double>..ctor
	|-Action<float>..ctor
	|
	|-RVA: 0x14B26E0 Offset: 0x14B10E0 VA: 0x1814B26E0
	|-Action<EmptyStartScenesBroadcast>..ctor
	|-Action<ResponseBroadcast>..ctor
	|-Action<ProbeReferenceVolume.ExtraDataActionInput>..ctor
	|
	|-RVA: 0x14B1EA0 Offset: 0x14B08A0 VA: 0x1814B1EA0
	|-Action<IMECompositionString>..ctor
	|
	|-RVA: 0x14B24D0 Offset: 0x14B0ED0 VA: 0x1814B24D0
	|-Action<InputBinding>..ctor
	|-Action<MeshGenerationResult>..ctor
	|
	|-RVA: 0x14B2370 Offset: 0x14B0D70 VA: 0x1814B2370
	|-Action<InputDeviceDescription>..ctor
	|-Action<ProbeVolumeSceneData.SerializablePVBakeSettings>..ctor
	|-Action<RigidbodyPauser.RigidbodyData>..ctor
	|-Action<TextureBlitter.BlitInfo>..ctor
	|
	|-RVA: 0x8447E0 Offset: 0x8431E0 VA: 0x1808447E0
	|-Action<int>..ctor
	|-Action<Int32Enum>..ctor
	|-Action<uint>..ctor
	|-Action<UInt32Enum>..ctor
	|
	|-RVA: 0xC84F40 Offset: 0xC83940 VA: 0x180C84F40
	|-Action<long>..ctor
	|-Action<IntPtr>..ctor
	|-Action<ulong>..ctor
	|
	|-RVA: 0x14B1D40 Offset: 0x14B0740 VA: 0x1814B1D40
	|-Action<Label>..ctor
	|-Action<PlayerLoopSystem>..ctor
	|-Action<PlayerLoopSystemInternal>..ctor
	|-Action<RenderTargetIdentifier>..ctor
	|-Action<SceneUnloadEndEventArgs>..ctor
	|-Action<ServerReceivedDataArgs>..ctor
	|-Action<TypeDispatchData>..ctor
	|-Action<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|-Action<DecalEntityManager.CombinedChunks>..ctor
	|-Action<InputActionMap.BindingOverrideJson>..ctor
	|-Action<RenderGraphDebugData.PassDebugData>..ctor
	|-Action<RenderGraphDebugData.ResourceDebugData>..ctor
	|-Action<UIRenderDevice.AllocToFree>..ctor
	|-Action<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>..ctor
	|
	|-RVA: 0x14B2000 Offset: 0x14B0A00 VA: 0x1814B2000
	|-Action<Matrix4x4>..ctor
	|-Action<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x14B2790 Offset: 0x14B1190 VA: 0x1814B2790
	|-Action<NavMeshBuildSource>..ctor
	|-Action<TransformDispatchData>..ctor
	|-Action<XRNodeState>..ctor
	|-Action<RenderChain.RenderNodeData>..ctor
	|
	|-RVA: 0x5A15A0 Offset: 0x59FFA0 VA: 0x1805A15A0
	|-Action<object>..ctor
	|
	|-RVA: 0x14B2630 Offset: 0x14B1030 VA: 0x1814B2630
	|-Action<UIVertex>..ctor
	|
	|-RVA: 0x12CB120 Offset: 0x12C9B20 VA: 0x1812CB120
	|-Action<Vector2>..ctor
	|
	|-RVA: 0x14B2840 Offset: 0x14B1240 VA: 0x1814B2840
	|-Action<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|
	|-RVA: 0x14B1F50 Offset: 0x14B0950 VA: 0x1814B1F50
	|-Action<XRView>..ctor
	|
	|-RVA: 0x12CB010 Offset: 0x12C9A10 VA: 0x1812CB010
	|-Action<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x14B22C0 Offset: 0x14B0CC0 VA: 0x1814B22C0
	|-Action<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>..ctor
	|-Action<ShadowUtility.Edge>..ctor
	|-Action<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x14B2210 Offset: 0x14B0C10 VA: 0x1814B2210
	|-Action<GodRaysRenderPass.VisibleLightRemap>..ctor
	|
	|-RVA: 0x14B2160 Offset: 0x14B0B60 VA: 0x1814B2160
	|-Action<HID.HIDElementDescriptor>..ctor
	|-Action<JsonParser.JsonValue>..ctor
	|
	|-RVA: 0x14B20B0 Offset: 0x14B0AB0 VA: 0x1814B20B0
	|-Action<InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x14B2580 Offset: 0x14B0F80 VA: 0x1814B2580
	|-Action<NetworkAnimator.TriggerUpdate>..ctor
	|
	|-RVA: 0x14B28F0 Offset: 0x14B12F0 VA: 0x1814B28F0
	|-Action<ProbeBrickIndex.ReservedBrick>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F810 Offset: 0xB0E210 VA: 0x180B0F810
	|-Action<ArraySegment<byte>>.Invoke
	|-Action<SyncList.CachedOnChange<int>>.Invoke
	|-Action<KeyValuePair<int, object>>.Invoke
	|-Action<KeyValuePair<object, bool>>.Invoke
	|-Action<KeyValuePair<object, char>>.Invoke
	|-Action<KeyValuePair<object, object>>.Invoke
	|-Action<KeyValuePair<PropertyName, object>>.Invoke
	|-Action<NativeArray<ConvertMeshJobData>>.Invoke
	|-Action<NativeArray<CopyClosingMeshJobData>>.Invoke
	|-Action<NativeArray<NudgeJobData>>.Invoke
	|-Action<NativeSlice<ConvertMeshJobData>>.Invoke
	|-Action<NativeSlice<CopyClosingMeshJobData>>.Invoke
	|-Action<NativeSlice<NudgeJobData>>.Invoke
	|-Action<Nullable<DateTime>>.Invoke
	|-Action<RenderGraphResourcePool.ResourceLogInfo<object>>.Invoke
	|-Action<StructMultiKey<object, object>>.Invoke
	|-Action<SubArray<int>>.Invoke
	|-Action<ValueTuple<int, object>>.Invoke
	|-Action<ValueTuple<object, object>>.Invoke
	|-Action<AsyncGPUReadbackRequest>.Invoke
	|-Action<AsyncWebRequestData>.Invoke
	|-Action<BezierContour>.Invoke
	|-Action<Color>.Invoke
	|-Action<Connection>.Invoke
	|-Action<CoordinateFootprintTilePair>.Invoke
	|-Action<CoordinateStorageFootprintTilePair>.Invoke
	|-Action<CoordinateStorageTilePair>.Invoke
	|-Action<CoordinateTilePair>.Invoke
	|-Action<DateTimeOffset>.Invoke
	|-Action<Decimal>.Invoke
	|-Action<DoublePoint>.Invoke
	|-Action<DoublePoint>.Invoke
	|-Action<DualPrefab>.Invoke
	|-Action<Entry>.Invoke
	|-Action<EventSummary>.Invoke
	|-Action<GlyphRect>.Invoke
	|-Action<Guid>.Invoke
	|-Action<InputDevice>.Invoke
	|-Action<IntPoint>.Invoke
	|-Action<IntRect>.Invoke
	|-Action<InternedString>.Invoke
	|-Action<InterpretedFrameInfo>.Invoke
	|-Action<LigatureSubstitutionRecord>.Invoke
	|-Action<LigatureSubstitutionRecord>.Invoke
	|-Action<MultipleSubstitutionRecord>.Invoke
	|-Action<MultipleSubstitutionRecord>.Invoke
	|-Action<NetworkTrafficArgs>.Invoke
	|-Action<Playable>.Invoke
	|-Action<Quaternion>.Invoke
	|-Action<RangePositionInfo>.Invoke
	|-Action<RectInt>.Invoke
	|-Action<Resolution>.Invoke
	|-Action<RuleMatcher>.Invoke
	|-Action<SamplePointUData>.Invoke
	|-Action<SceneLoadPercentEventArgs>.Invoke
	|-Action<StylePropertyName>.Invoke
	|-Action<StylePropertyValue>.Invoke
	|-Action<StyleValueManaged>.Invoke
	|-Action<Substring>.Invoke
	|-Action<TimerState>.Invoke
	|-Action<UILineInfo>.Invoke
	|-Action<UnloadedScene>.Invoke
	|-Action<VFXOutputEventArgs>.Invoke
	|-Action<Vector4>.Invoke
	|-Action<X509ChainStatus>.Invoke
	|-Action<ZipGenericExtraField>.Invoke
	|-Action<AdvancedSmooth.Turn>.Invoke
	|-Action<BeforeRenderHelper.OrderBlock>.Invoke
	|-Action<CameraState.CustomBlendable>.Invoke
	|-Action<ClipperLib.DoublePoint>.Invoke
	|-Action<ClipperLib.IntPoint>.Invoke
	|-Action<ConfinerOven.PolygonSolution>.Invoke
	|-Action<FocusController.FocusedElement>.Invoke
	|-Action<HeatmapManager.PropertyRegionReference>.Invoke
	|-Action<InputAction.CallbackContext>.Invoke
	|-Action<InputStateHistory.Record>.Invoke
	|-Action<InputTransformSpots.TransformSpot>.Invoke
	|-Action<MultiColumnCollectionHeader.SortedColumnState>.Invoke
	|-Action<NativeMethods.TASKDIALOG_BUTTON>.Invoke
	|-Action<OutlineEffect.OutlineTargetGroup>.Invoke
	|-Action<ProbeVolumeSceneData.SerializableHasPVItem>.Invoke
	|-Action<ProbeVolumeSceneData.SerializablePVProfile>.Invoke
	|-Action<RigidbodyPrediction.MoveData>.Invoke
	|-Action<SVGDocument.NodeWithParent>.Invoke
	|-Action<ServerSocket.ConnectionChange>.Invoke
	|-Action<TargetStateListener.Callback>.Invoke
	|-Action<TextSettings.FontReferenceMap>.Invoke
	|-Action<TextureRegistry.TextureInfo>.Invoke
	|-Action<TransportManager.DisconnectingClient>.Invoke
	|-Action<VisualTreeAsset.SlotDefinition>.Invoke
	|-Action<VisualTreeAsset.SlotUsageEntry>.Invoke
	|-Action<VisualTreeAsset.UxmlObjectEntry>.Invoke
	|-Action<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Invoke
	|-Action<DebugUI.Foldout.ContextMenuItem>.Invoke
	|
	|-RVA: 0xFE2D90 Offset: 0xFE1790 VA: 0x180FE2D90
	|-Action<AsyncLocalValueChangedArgs<object>>.Invoke
	|-Action<IntervalTree.Entry<object>>.Invoke
	|-Action<KeyValuePair<Rect, object>>.Invoke
	|-Action<Nullable<Decimal>>.Invoke
	|-Action<TempAllocator.Page<ushort>>.Invoke
	|-Action<TempAllocator.Page<Vertex>>.Invoke
	|-Action<ValueTuple<object, ValueTuple<object, int>>>.Invoke
	|-Action<BezierPathSegment>.Invoke
	|-Action<Bounds>.Invoke
	|-Action<ClientPresenceChangeEventArgs>.Invoke
	|-Action<ClientReceivedDataArgs>.Invoke
	|-Action<ComputedTransitionProperty>.Invoke
	|-Action<ContourVertex>.Invoke
	|-Action<CoordinateProceduralTilePair>.Invoke
	|-Action<FrameTimeSample>.Invoke
	|-Action<IntervalTreeNode>.Invoke
	|-Action<JsonPosition>.Invoke
	|-Action<MarkToBaseAdjustmentRecord>.Invoke
	|-Action<MarkToBaseAdjustmentRecord>.Invoke
	|-Action<MarkToMarkAdjustmentRecord>.Invoke
	|-Action<MarkToMarkAdjustmentRecord>.Invoke
	|-Action<NameAndParameters>.Invoke
	|-Action<NamedValue>.Invoke
	|-Action<RendererList>.Invoke
	|-Action<SelectorMatchRecord>.Invoke
	|-Action<StyleSelectorPart>.Invoke
	|-Action<StyleSyntaxToken>.Invoke
	|-Action<StyleValue>.Invoke
	|-Action<StyleVariable>.Invoke
	|-Action<TreeViewItemWrapper>.Invoke
	|-Action<WebResponse>.Invoke
	|-Action<XRFeatureDescriptor>.Invoke
	|-Action<AvatarSettings.LayerSetting>.Invoke
	|-Action<HID.HIDCollectionDescriptor>.Invoke
	|-Action<LatencySimulator.Message>.Invoke
	|-Action<RetainedGizmos.MeshWithHash>.Invoke
	|-Action<SVGDocument.HierarchyUpdate>.Invoke
	|-Action<StructySync.ChangeData>.Invoke
	|-Action<TemplateAsset.AttributeOverride>.Invoke
	|-Action<TimeNotificationBehaviour.NotificationEntry>.Invoke
	|-Action<UnitySynchronizationContext.WorkRequest>.Invoke
	|-Action<VisualTreeAsset.UsingEntry>.Invoke
	|-Action<InputControlLayout.Collection.LayoutMatcher>.Invoke
	|
	|-RVA: 0xFE2DC0 Offset: 0xFE17C0 VA: 0x180FE2DC0
	|-Action<SyncList.ChangeData<int>>.Invoke
	|-Action<ValueTuple<int, Vector2Int>>.Invoke
	|-Action<DuplicateSamplePoint>.Invoke
	|-Action<Int3>.Invoke
	|-Action<IntRegion>.Invoke
	|-Action<ManipulatorActivationFilter>.Invoke
	|-Action<RemoteConnectionStateArgs>.Invoke
	|-Action<UICharInfo>.Invoke
	|-Action<Vector3>.Invoke
	|-Action<DecalEntityIndexer.DecalEntityItem>.Invoke
	|-Action<HIDParser.HIDReportData>.Invoke
	|-Action<ProbeBrickPool.BrickChunkAlloc>.Invoke
	|-Action<SyncTimer.ChangeData>.Invoke
	|
	|-RVA: 0xFE2E30 Offset: 0xFE1830 VA: 0x180FE2E30
	|-Action<KeyValuePair<object, JsonParser.JsonValue>>.Invoke
	|-Action<RaycastResult>.Invoke
	|-Action<UIRStylePainter.Entry>.Invoke
	|-Action<UIRenderDevice.AllocToUpdate>.Invoke
	|
	|-RVA: 0x593430 Offset: 0x591E30 VA: 0x180593430
	|-Action<ValueTuple<int, int>>.Invoke
	|-Action<ValueTuple<int, Scene>>.Invoke
	|-Action<AnimatorClipInfo>.Invoke
	|-Action<bool>.Invoke
	|-Action<byte>.Invoke
	|-Action<ByteEnum>.Invoke
	|-Action<char>.Invoke
	|-Action<ClientConnectionChangeBroadcast>.Invoke
	|-Action<ClientConnectionStateArgs>.Invoke
	|-Action<Color32>.Invoke
	|-Action<ConnectedClientsArgs>.Invoke
	|-Action<ConnectedClientsBroadcast>.Invoke
	|-Action<DateTime>.Invoke
	|-Action<double>.Invoke
	|-Action<EasingFunction>.Invoke
	|-Action<EmptyStartScenesBroadcast>.Invoke
	|-Action<InputEventPtr>.Invoke
	|-Action<short>.Invoke
	|-Action<int>.Invoke
	|-Action<Int32Enum>.Invoke
	|-Action<long>.Invoke
	|-Action<IntPtr>.Invoke
	|-Action<LoadScenesBroadcast>.Invoke
	|-Action<object>.Invoke
	|-Action<RendererListHandle>.Invoke
	|-Action<ResourceHandle>.Invoke
	|-Action<ResponseBroadcast>.Invoke
	|-Action<sbyte>.Invoke
	|-Action<SamplePointsPatch>.Invoke
	|-Action<Scene>.Invoke
	|-Action<SceneLoadStartEventArgs>.Invoke
	|-Action<SceneUnloadStartEventArgs>.Invoke
	|-Action<ServerConnectionStateArgs>.Invoke
	|-Action<ShaderTagId>.Invoke
	|-Action<float>.Invoke
	|-Action<TimeSpan>.Invoke
	|-Action<TimeValue>.Invoke
	|-Action<ushort>.Invoke
	|-Action<uint>.Invoke
	|-Action<UInt32Enum>.Invoke
	|-Action<ulong>.Invoke
	|-Action<UShort2>.Invoke
	|-Action<UnloadScenesBroadcast>.Invoke
	|-Action<UsageHint>.Invoke
	|-Action<Vector2>.Invoke
	|-Action<__Il2CppFullySharedGenericType>.Invoke
	|-Action<BitmapAllocator32.Page>.Invoke
	|-Action<CinemachineClearShot.Pair>.Invoke
	|-Action<CinemachineStateDrivenCamera.HashPair>.Invoke
	|-Action<NetworkAnimator.TriggerUpdate>.Invoke
	|-Action<PlayingCard.CardData>.Invoke
	|-Action<ProbeReferenceVolume.ExtraDataActionInput>.Invoke
	|-Action<RegexCharClass.SingleRange>.Invoke
	|-Action<SVGDocument.PostponedClip>.Invoke
	|-Action<SVGDocument.PostponedStopData>.Invoke
	|-Action<SyncStopwatch.ChangeData>.Invoke
	|
	|-RVA: 0xFE2E80 Offset: 0xFE1880 VA: 0x180FE2E80
	|-Action<BezierSegment>.Invoke
	|-Action<NavMeshBuildMarkup>.Invoke
	|-Action<PlayableBinding>.Invoke
	|-Action<SceneLoadEndEventArgs>.Invoke
	|-Action<VoxelContour>.Invoke
	|-Action<FrameTimingsHUDDisplay.FrameTimingPoint>.Invoke
	|-Action<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>.Invoke
	|-Action<ProbeVolumeSceneData.SerializableBoundItem>.Invoke
	|-Action<SVGDocument.NodeReferenceData>.Invoke
	|-Action<TrackedDeviceRaycaster.RaycastHitData>.Invoke
	|-Action<UIRStylePainter.RepeatRectUV>.Invoke
	|-Action<VisualTreeAsset.AssetEntry>.Invoke
	|-Action<InstructionList.DebugView.InstructionView>.Invoke
	|-Action<MultiColumnCollectionHeader.ViewState.ColumnState>.Invoke
	|
	|-RVA: 0xFE2DF0 Offset: 0xFE17F0 VA: 0x180FE2DF0
	|-Action<CGSpot>.Invoke
	|-Action<GlyphPairAdjustmentRecord>.Invoke
	|-Action<RaycastHit>.Invoke
	|
	|-RVA: 0x10FE540 Offset: 0x10FCF40 VA: 0x1810FE540
	|-Action<CombineInstance>.Invoke
	|
	|-RVA: 0x10FE190 Offset: 0x10FCB90 VA: 0x1810FE190
	|-Action<ControlPointOption>.Invoke
	|-Action<RaycastHit2D>.Invoke
	|-Action<Funnel.PathPart>.Invoke
	|-Action<SewerMushroomLocation.MushroomLocationData>.Invoke
	|-Action<TargetPositionCache.CacheEntry.RecordingItem>.Invoke
	|
	|-RVA: 0x10FE0F0 Offset: 0x10FCAF0 VA: 0x1810FE0F0
	|-Action<DisplayInfo>.Invoke
	|-Action<IntPoint>.Invoke
	|-Action<RigidbodyPauser.Rigidbody2DData>.Invoke
	|
	|-RVA: 0x14B1CC0 Offset: 0x14B06C0 VA: 0x1814B1CC0
	|-Action<IMECompositionString>.Invoke
	|
	|-RVA: 0x10FE300 Offset: 0x10FCD00 VA: 0x1810FE300
	|-Action<InputBinding>.Invoke
	|-Action<MeshGenerationResult>.Invoke
	|
	|-RVA: 0x10FE0A0 Offset: 0x10FCAA0 VA: 0x1810FE0A0
	|-Action<InputDeviceDescription>.Invoke
	|-Action<ProbeVolumeSceneData.SerializablePVBakeSettings>.Invoke
	|-Action<RigidbodyPauser.RigidbodyData>.Invoke
	|-Action<TextureBlitter.BlitInfo>.Invoke
	|
	|-RVA: 0x10FE060 Offset: 0x10FCA60 VA: 0x1810FE060
	|-Action<Label>.Invoke
	|-Action<PlayerLoopSystem>.Invoke
	|-Action<PlayerLoopSystemInternal>.Invoke
	|-Action<RenderTargetIdentifier>.Invoke
	|-Action<SceneUnloadEndEventArgs>.Invoke
	|-Action<ServerReceivedDataArgs>.Invoke
	|-Action<TypeDispatchData>.Invoke
	|-Action<AnimationOutputWeightProcessor.WeightInfo>.Invoke
	|-Action<DecalEntityManager.CombinedChunks>.Invoke
	|-Action<InputActionMap.BindingOverrideJson>.Invoke
	|-Action<RenderGraphDebugData.PassDebugData>.Invoke
	|-Action<RenderGraphDebugData.ResourceDebugData>.Invoke
	|-Action<UIRenderDevice.AllocToFree>.Invoke
	|-Action<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>.Invoke
	|
	|-RVA: 0x10FE4D0 Offset: 0x10FCED0 VA: 0x1810FE4D0
	|-Action<Matrix4x4>.Invoke
	|-Action<TexturePacker_JsonArray.Frame>.Invoke
	|
	|-RVA: 0x10FE130 Offset: 0x10FCB30 VA: 0x1810FE130
	|-Action<NavMeshBuildSource>.Invoke
	|-Action<TransformDispatchData>.Invoke
	|-Action<XRNodeState>.Invoke
	|-Action<RenderChain.RenderNodeData>.Invoke
	|
	|-RVA: 0x10FE6B0 Offset: 0x10FD0B0 VA: 0x1810FE6B0
	|-Action<UIVertex>.Invoke
	|
	|-RVA: 0x10FE5A0 Offset: 0x10FCFA0 VA: 0x1810FE5A0
	|-Action<Win32_IP_ADAPTER_ADDRESSES>.Invoke
	|
	|-RVA: 0x10FE210 Offset: 0x10FCC10 VA: 0x1810FE210
	|-Action<XRView>.Invoke
	|
	|-RVA: 0x10FE1D0 Offset: 0x10FCBD0 VA: 0x1810FE1D0
	|-Action<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.Invoke
	|-Action<ShadowUtility.Edge>.Invoke
	|-Action<TargetPositionCache.CacheCurve.Item>.Invoke
	|
	|-RVA: 0x10FE640 Offset: 0x10FD040 VA: 0x1810FE640
	|-Action<GodRaysRenderPass.VisibleLightRemap>.Invoke
	|
	|-RVA: 0x10FE2B0 Offset: 0x10FCCB0 VA: 0x1810FE2B0
	|-Action<HID.HIDElementDescriptor>.Invoke
	|-Action<JsonParser.JsonValue>.Invoke
	|
	|-RVA: 0x10FE420 Offset: 0x10FCE20 VA: 0x1810FE420
	|-Action<InputControlLayout.ControlItem>.Invoke
	|
	|-RVA: 0x10FE510 Offset: 0x10FCF10 VA: 0x1810FE510
	|-Action<ProbeBrickIndex.ReservedBrick>.Invoke
	*/
}
