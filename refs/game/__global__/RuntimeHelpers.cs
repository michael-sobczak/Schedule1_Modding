public static class RuntimeHelpers // TypeDefIndex: 4648
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x1B72D30 Offset: 0x1B71730 VA: 0x181B72D30
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x1B72CB0 Offset: 0x1B716B0 VA: 0x181B72CB0
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x1B72DE0 Offset: 0x1B717E0 VA: 0x181B72DE0
	public static int get_OffsetToStringData() { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830
	public static int GetHashCode(object o) { }

	// RVA: 0x1B72CA0 Offset: 0x1B716A0 VA: 0x181B72CA0
	public static object GetObjectValue(object obj) { }

	// RVA: 0x1B72D40 Offset: 0x1B71740 VA: 0x181B72D40
	private static void RunClassConstructor(IntPtr type) { }

	// RVA: 0x1B72D50 Offset: 0x1B71750 VA: 0x181B72D50
	public static void RunClassConstructor(RuntimeTypeHandle type) { }

	// RVA: 0x1B62050 Offset: 0x1B60A50 VA: 0x181B62050
	private static bool SufficientExecutionStack() { }

	// RVA: 0x1B62050 Offset: 0x1B60A50 VA: 0x181B62050
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF32C40 Offset: 0xF31640 VA: 0x180F32C40
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ArraySegment<byte>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SyncList.CachedOnChange<int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SyncList.ChangeData<int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntervalTree.Entry<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Int32Enum, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, bool>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, char>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, JsonParser.JsonValue>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<PropertyName, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Rect, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<CopyClosingMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<CopyClosingMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Nullable<DateTime>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Nullable<Decimal>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<ushort>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<Vertex>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StructMultiKey<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SubArray<int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemData<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, Scene>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, Vector2Int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Int32Enum, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<IntPtr, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, ValueTuple<object, int>>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Vector3, Quaternion>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Vector4, Vector2Int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AnimatorClipInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncGPUReadbackRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BezierContour>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BezierPathSegment>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BezierSegment>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<bool>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Bounds>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<byte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ByteEnum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CGSpot>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CSteamID>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<char>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color32>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CombineInstance>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedStyle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedTransitionProperty>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Connection>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ContourVertex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ControlPointOption>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CoordinateFootprintTilePair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CoordinateProceduralTilePair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CoordinateStorageFootprintTilePair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CoordinateStorageTilePair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CoordinateTilePair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTime>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTimeOffset>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Decimal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DisplayInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<double>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DoublePoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DoublePoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DualPrefab>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DuplicateSamplePoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EasingFunction>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Entry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EnumData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventSummary>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FrameTimeSample>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FullRank>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphPairAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphRect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Guid>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HSteamNetConnection>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Hash128>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputBinding>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputDeviceDescription>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputEventPtr>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<short>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int2>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntRect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntRegion>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InternedString>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InterpretedFrameInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntervalTreeNode>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonPosition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Label>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LocalPacket>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LocalPacket>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ManipulatorActivationFilter>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Matrix4x4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NameAndParameters>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NamedValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeAddr>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NavMeshBuildMarkup>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NavMeshBuildSource>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Packet>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Playable>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayableBinding>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystemInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumeBakingProcessSettings>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Quaternion>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RangePositionInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit2D>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastResult>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Rect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RectInt>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderInstancedDataLayout>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderTargetIdentifier>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RendererList>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RendererListHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Resolution>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceLocator>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RpcLink>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RpcLinkType>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RuleMatcher>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<sbyte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SamplePointUData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SamplePointsPatch>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Scene>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SelectorMatchRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ShaderTagId>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyName>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSelectorPart>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSyntaxToken>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValueManaged>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariable>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Substring>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TerrainTileCoord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureId>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeSpan>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UICharInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UILineInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIVertex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ushort>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UInt32Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UShort2>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnloadedScene>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UsageHint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2Int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3Int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VoxelContour>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Win32_IP_ADAPTER_ADDRESSES>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<X509ChainStatus>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XPathNodeRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XRFeatureDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XRView>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ZipGenericExtraField>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<jvalue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AdvancedSmooth.Turn>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AnimationOutputWeightProcessor.WeightInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AvatarSettings.LayerSetting>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BaseStyleMatcher.MatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BeforeRenderHelper.OrderBlock>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BitmapAllocator32.Page>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CameraState.CustomBlendable>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CinemachineClearShot.Pair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CinemachineStateDrivenCamera.HashPair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ClipperLib.DoublePoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ClipperLib.IntPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ConfinerOven.PolygonSolution>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DecalEntityIndexer.DecalEntityItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DecalEntityManager.CombinedChunks>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.DispatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.EventRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventInterestReflectionUtils.DefaultEventInterests>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FocusController.FocusedElement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Funnel.PathPart>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GodRaysRenderPass.VisibleLightRemap>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GraphUpdateProcessor.GUOSingle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HID.HIDCollectionDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HID.HIDElementDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HIDParser.HIDReportData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HeatmapManager.PropertyRegionReference>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputActionMap.BindingOverrideJson>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputControlLayout.ControlItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputSystemUIInputModule.InputActionReferenceState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputTransformSpots.TransformSpot>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonParser.JsonValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LatencySimulator.Message>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LiquidVolume.MeshCache>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.SortedColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Multipass.TransportIdData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeMethods.TASKDIALOG_BUTTON>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NetworkAnimator.ReceivedServerData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NetworkAnimator.SmoothedFloat>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NetworkAnimator.StateChange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NetworkAnimator.TriggerUpdate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NetworkBehaviour.BufferedRpc>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ObjectPool.DelayedStoreData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<OutlineEffect.OutlineTargetGroup>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayingCard.CardData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeBrickIndex.ReservedBrick>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeBrickPool.BrickChunkAlloc>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumePerSceneData.PerScenarioData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumeSceneData.SerializableBoundItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumeSceneData.SerializableHasPVItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ProbeVolumeSceneData.SerializablePVProfile>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ReflectionProbeManager.CachedProbe>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Regex.CachedCodeEntryKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RegexCharClass.SingleRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderChain.RenderNodeData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderGraphDebugData.PassDebugData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderGraphDebugData.ResourceDebugData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RetainedGizmos.MeshWithHash>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RigidbodyPauser.Rigidbody2DData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RigidbodyPauser.RigidbodyData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RigidbodyPrediction.MoveData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.ClipData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.HierarchyUpdate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.MaskData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.NodeGlobalSceneState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.NodeReferenceData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.NodeWithParent>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.PatternData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.PostponedClip>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.PostponedStopData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SVGDocument.ViewBoxInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ServerSocket.ConnectionChange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SewerMushroomLocation.MushroomLocationData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ShadowUtility.Edge>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StructySync.ChangeData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleComplexSelector.PseudoStateData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyAnimationSystem.ElementPropertyPair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSheetCache.SheetHandleKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariableResolver.ResolveContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SyncStopwatch.ChangeData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SyncTimer.ChangeData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_DynamicFontAssetUtilities.FontReference>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_ResourceManager.FontAssetRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TargetStateListener.Callback>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TemplateAsset.AttributeOverride>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextResourceManager.FontAssetRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextSettings.FontReferenceMap>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureBlitter.BlitInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TexturePacker_JsonArray.Frame>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureRegistry.TextureInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeNotificationBehaviour.NotificationEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TrackedDeviceRaycaster.RaycastHitData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TransportManager.DisconnectingClient>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRStylePainter.Entry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRStylePainter.RepeatRectUV>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToFree>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToUpdate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnitySynchronizationContext.WorkRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.AssetEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotDefinition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotUsageEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UsingEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UxmlObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingRestrictions.TestBuilder.AndNode>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DebugUI.Foldout.ContextMenuItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputControlLayout.Collection.LayoutMatcher>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputControlLayout.Collection.PrecompiledLayout>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InstructionList.DebugView.InstructionView>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TargetPositionCache.CacheCurve.Item>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TargetPositionCache.CacheEntry.RecordingItem>
	*/
}
