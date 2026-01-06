public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable // TypeDefIndex: 3787
{
	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public long LongLength { get; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public int Length { get; }
	public int Rank { get; }

	// Methods

	// RVA: 0x1C7C060 Offset: 0x1C7AA60 VA: 0x181C7C060
	public static Array CreateInstance(Type elementType, long[] lengths) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFAD0 Offset: 0xDFE4D0 VA: 0x180DFFAD0
	|-Array.AsReadOnly<CustomAttributeNamedArgument>
	|-Array.AsReadOnly<CustomAttributeTypedArgument>
	|-Array.AsReadOnly<object>
	|
	|-RVA: 0xDFFB80 Offset: 0xDFE580 VA: 0x180DFFB80
	|-Array.AsReadOnly<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF28A0 Offset: 0xDF12A0 VA: 0x180DF28A0
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.Resize<KeyValuePair<int, int>>
	|-Array.Resize<KeyValuePair<InternedString, object>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.Resize<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.Resize<Background>
	|-Array.Resize<BackgroundPosition>
	|-Array.Resize<BackgroundRepeat>
	|-Array.Resize<BackgroundSize>
	|-Array.Resize<BoundingSphere>
	|-Array.Resize<byte>
	|-Array.Resize<char>
	|-Array.Resize<Color>
	|-Array.Resize<Color32>
	|-Array.Resize<ContourVertex>
	|-Array.Resize<FontDefinition>
	|-Array.Resize<GCHandle>
	|-Array.Resize<GlyphPairAdjustmentRecord>
	|-Array.Resize<HighlightState>
	|-Array.Resize<HighlightState>
	|-Array.Resize<InputBinding>
	|-Array.Resize<InputControlScheme>
	|-Array.Resize<InputUser>
	|-Array.Resize<short>
	|-Array.Resize<int>
	|-Array.Resize<Int32Enum>
	|-Array.Resize<InternedString>
	|-Array.Resize<Length>
	|-Array.Resize<LigatureSubstitutionRecord>
	|-Array.Resize<LinkInfo>
	|-Array.Resize<MarkToBaseAdjustmentRecord>
	|-Array.Resize<MarkToMarkAdjustmentRecord>
	|-Array.Resize<MaterialReference>
	|-Array.Resize<MaterialReference>
	|-Array.Resize<Matrix4x4>
	|-Array.Resize<MeshInfo>
	|-Array.Resize<object>
	|-Array.Resize<PageInfo>
	|-Array.Resize<PointerModel>
	|-Array.Resize<Rect>
	|-Array.Resize<Rotate>
	|-Array.Resize<Scale>
	|-Array.Resize<float>
	|-Array.Resize<Substring>
	|-Array.Resize<TMP_CharacterInfo>
	|-Array.Resize<TMP_LinkInfo>
	|-Array.Resize<TMP_MeshInfo>
	|-Array.Resize<TMP_PageInfo>
	|-Array.Resize<TMP_WordInfo>
	|-Array.Resize<TextElementInfo>
	|-Array.Resize<TextProcessingElement>
	|-Array.Resize<TextShadow>
	|-Array.Resize<TextureId>
	|-Array.Resize<TransformOrigin>
	|-Array.Resize<Translate>
	|-Array.Resize<ushort>
	|-Array.Resize<uint>
	|-Array.Resize<ulong>
	|-Array.Resize<Vector2>
	|-Array.Resize<Vector3>
	|-Array.Resize<Vector4>
	|-Array.Resize<WordInfo>
	|-Array.Resize<WordWrapState>
	|-Array.Resize<WordWrapState>
	|-Array.Resize<__Il2CppFullySharedGenericType>
	|-Array.Resize<BaseStyleMatcher.MatchContext>
	|-Array.Resize<BlitUtility.Vertex>
	|-Array.Resize<EventDispatcher.DispatchContext>
	|-Array.Resize<InputActionRebindingExtensions.ParameterOverride>
	|-Array.Resize<InputControlLayout.ControlItem>
	|-Array.Resize<InputControlScheme.DeviceRequirement>
	|-Array.Resize<InputDevice.ControlBitRangeNode>
	|-Array.Resize<InputEventTrace.DeviceInfo>
	|-Array.Resize<InputManager.AvailableDevice>
	|-Array.Resize<InputManager.StateChangeMonitorListener>
	|-Array.Resize<InputManager.StateChangeMonitorTimeout>
	|-Array.Resize<InputManager.StateChangeMonitorsForDevice>
	|-Array.Resize<InputRemoting.RemoteInputDevice>
	|-Array.Resize<InputRemoting.RemoteSender>
	|-Array.Resize<InputUser.OngoingAccountSelection>
	|-Array.Resize<InputUser.UserData>
	|-Array.Resize<MemoryHelpers.BitRegion>
	|-Array.Resize<OnScreenControl.OnScreenDeviceInfo>
	|-Array.Resize<ProbeBrickPool.BrickChunkAlloc>
	|-Array.Resize<RigidbodyPrediction.MoveData>
	|-Array.Resize<SequenceNode.SequenceConstructPosContext>
	|-Array.Resize<StyleVariableResolver.ResolveContext>
	|-Array.Resize<TMP_Text.TextProcessingElement>
	|-Array.Resize<BindingRestrictions.TestBuilder.AndNode>
	|-Array.Resize<InputDeviceMatcher.MatcherJson.Capability>
	*/

	// RVA: 0x1C7D160 Offset: 0x1C7BB60 VA: 0x181C7D160 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1C7F060 Offset: 0x1C7DA60 VA: 0x181C7F060 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1C7F070 Offset: 0x1C7DA70 VA: 0x181C7F070 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1C7EC50 Offset: 0x1C7D650 VA: 0x181C7EC50 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1C7EE80 Offset: 0x1C7D880 VA: 0x181C7EE80 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1C7ECA0 Offset: 0x1C7D6A0 VA: 0x181C7ECA0 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1C7CD00 Offset: 0x1C7B700 VA: 0x181C7CD00 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1C7EF70 Offset: 0x1C7D970 VA: 0x181C7EF70 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1C7F010 Offset: 0x1C7DA10 VA: 0x181C7F010 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1C7EFC0 Offset: 0x1C7D9C0 VA: 0x181C7EFC0 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1C7AAC0 Offset: 0x1C794C0 VA: 0x181C7AAC0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 23
	public object Clone() { }

	// RVA: 0x1C7F090 Offset: 0x1C7DA90 VA: 0x181C7F090 Slot: 20
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x1C7F2E0 Offset: 0x1C7DCE0 VA: 0x181C7F2E0 Slot: 21
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x105C7D0 Offset: 0x105B1D0 VA: 0x18105C7D0
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x1C7F4C0 Offset: 0x1C7DEC0 VA: 0x181C7F4C0 Slot: 22
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x1C7A0E0 Offset: 0x1C78AE0 VA: 0x181C7A0E0
	public static int BinarySearch(Array array, object value) { }

	// RVA: -1 Offset: -1
	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3B260 Offset: 0xF39C60 VA: 0x180F3B260
	|-Array.ConvertAll<object, object>
	|
	|-RVA: 0xF3AFE0 Offset: 0xF399E0 VA: 0x180F3AFE0
	|-Array.ConvertAll<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C7ABC0 Offset: 0x1C795C0 VA: 0x181C7ABC0
	public static void Copy(Array sourceArray, Array destinationArray, long length) { }

	// RVA: 0x1C7AE50 Offset: 0x1C79850 VA: 0x181C7AE50
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { }

	// RVA: 0x1C7A950 Offset: 0x1C79350 VA: 0x181C7A950
	public void CopyTo(Array array, long index) { }

	// RVA: -1 Offset: -1
	public static void ForEach<T>(T[] array, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3D160 Offset: 0xF3BB60 VA: 0x180F3D160
	|-Array.ForEach<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C7F6D0 Offset: 0x1C7E0D0 VA: 0x181C7F6D0
	public long get_LongLength() { }

	// RVA: 0x1C7C2B0 Offset: 0x1C7ACB0 VA: 0x181C7C2B0
	public long GetLongLength(int dimension) { }

	// RVA: 0x1C7C680 Offset: 0x1C7B080 VA: 0x181C7C680
	public object GetValue(long index) { }

	// RVA: 0x1C7C510 Offset: 0x1C7AF10 VA: 0x181C7C510
	public object GetValue(long index1, long index2) { }

	// RVA: 0x1C7CA20 Offset: 0x1C7B420 VA: 0x181C7CA20
	public object GetValue(long index1, long index2, long index3) { }

	// RVA: 0x1C7C720 Offset: 0x1C7B120 VA: 0x181C7C720
	public object GetValue(long[] indices) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 15
	public bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 24
	public bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1C7A680 Offset: 0x1C79080 VA: 0x181C7A680
	public static int BinarySearch(Array array, int index, int length, object value) { }

	// RVA: 0x1C7A1D0 Offset: 0x1C78BD0 VA: 0x181C7A1D0
	public static int BinarySearch(Array array, object value, IComparer comparer) { }

	// RVA: 0x1C7A2C0 Offset: 0x1C78CC0 VA: 0x181C7A2C0
	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) { }

	// RVA: 0x1C7C2D0 Offset: 0x1C7ACD0 VA: 0x181C7C2D0
	private static int GetMedian(int low, int hi) { }

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE18160 Offset: 0xE16B60 VA: 0x180E18160
	|-Array.BinarySearch<ulong>
	|
	|-RVA: 0xE07FF0 Offset: 0xE069F0 VA: 0x180E07FF0
	|-Array.BinarySearch<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE13420 Offset: 0xE11E20 VA: 0x180E13420
	|-Array.BinarySearch<object>
	|
	|-RVA: 0xE07EA0 Offset: 0xE068A0 VA: 0x180E07EA0
	|-Array.BinarySearch<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE07B50 Offset: 0xE06550 VA: 0x180E07B50
	|-Array.BinarySearch<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFFE80 Offset: 0xDFE880 VA: 0x180DFFE80
	|-Array.BinarySearch<ArraySegment<byte>>
	|
	|-RVA: 0xE015F0 Offset: 0xDFFFF0 VA: 0x180E015F0
	|-Array.BinarySearch<SyncList.CachedOnChange<int>>
	|
	|-RVA: 0xE01840 Offset: 0xE00240 VA: 0x180E01840
	|-Array.BinarySearch<SyncList.ChangeData<int>>
	|
	|-RVA: 0xE05CA0 Offset: 0xE046A0 VA: 0x180E05CA0
	|-Array.BinarySearch<IntervalTree.Entry<object>>
	|
	|-RVA: 0xE0B2A0 Offset: 0xE09CA0 VA: 0x180E0B2A0
	|-Array.BinarySearch<KeyValuePair<int, object>>
	|
	|-RVA: 0xE0B050 Offset: 0xE09A50 VA: 0x180E0B050
	|-Array.BinarySearch<KeyValuePair<object, bool>>
	|
	|-RVA: 0xE0B4F0 Offset: 0xE09EF0 VA: 0x180E0B4F0
	|-Array.BinarySearch<KeyValuePair<object, char>>
	|
	|-RVA: 0xE0B9D0 Offset: 0xE0A3D0 VA: 0x180E0B9D0
	|-Array.BinarySearch<KeyValuePair<object, object>>
	|
	|-RVA: 0xE0B740 Offset: 0xE0A140 VA: 0x180E0B740
	|-Array.BinarySearch<KeyValuePair<object, JsonParser.JsonValue>>
	|
	|-RVA: 0xE0AE00 Offset: 0xE09800 VA: 0x180E0AE00
	|-Array.BinarySearch<KeyValuePair<PropertyName, object>>
	|
	|-RVA: 0xE0ABA0 Offset: 0xE095A0 VA: 0x180E0ABA0
	|-Array.BinarySearch<KeyValuePair<Rect, object>>
	|
	|-RVA: 0xE0E450 Offset: 0xE0CE50 VA: 0x180E0E450
	|-Array.BinarySearch<NativeArray<ConvertMeshJobData>>
	|
	|-RVA: 0xE0DFB0 Offset: 0xE0C9B0 VA: 0x180E0DFB0
	|-Array.BinarySearch<NativeArray<CopyClosingMeshJobData>>
	|
	|-RVA: 0xE0E200 Offset: 0xE0CC00 VA: 0x180E0E200
	|-Array.BinarySearch<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xE0E6A0 Offset: 0xE0D0A0 VA: 0x180E0E6A0
	|-Array.BinarySearch<NativeSlice<ConvertMeshJobData>>
	|
	|-RVA: 0xE0EB40 Offset: 0xE0D540 VA: 0x180E0EB40
	|-Array.BinarySearch<NativeSlice<CopyClosingMeshJobData>>
	|
	|-RVA: 0xE0E8F0 Offset: 0xE0D2F0 VA: 0x180E0E8F0
	|-Array.BinarySearch<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xE0F4E0 Offset: 0xE0DEE0 VA: 0x180E0F4E0
	|-Array.BinarySearch<Nullable<DateTime>>
	|
	|-RVA: 0xE0F280 Offset: 0xE0DC80 VA: 0x180E0F280
	|-Array.BinarySearch<Nullable<Decimal>>
	|
	|-RVA: 0xE0F980 Offset: 0xE0E380 VA: 0x180E0F980
	|-Array.BinarySearch<TempAllocator.Page<ushort>>
	|
	|-RVA: 0xE0FE20 Offset: 0xE0E820 VA: 0x180E0FE20
	|-Array.BinarySearch<TempAllocator.Page<Vertex>>
	|
	|-RVA: 0xE12D40 Offset: 0xE11740 VA: 0x180E12D40
	|-Array.BinarySearch<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0xE14990 Offset: 0xE13390 VA: 0x180E14990
	|-Array.BinarySearch<StructMultiKey<object, object>>
	|
	|-RVA: 0xE15C50 Offset: 0xE14650 VA: 0x180E15C50
	|-Array.BinarySearch<SubArray<int>>
	|
	|-RVA: 0xE18D90 Offset: 0xE17790 VA: 0x180E18D90
	|-Array.BinarySearch<ValueTuple<int, int>>
	|
	|-RVA: 0xE19460 Offset: 0xE17E60 VA: 0x180E19460
	|-Array.BinarySearch<ValueTuple<int, object>>
	|
	|-RVA: 0xE18FD0 Offset: 0xE179D0 VA: 0x180E18FD0
	|-Array.BinarySearch<ValueTuple<int, Scene>>
	|
	|-RVA: 0xE18B30 Offset: 0xE17530 VA: 0x180E18B30
	|-Array.BinarySearch<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xE188D0 Offset: 0xE172D0 VA: 0x180E188D0
	|-Array.BinarySearch<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xE19210 Offset: 0xE17C10 VA: 0x180E19210
	|-Array.BinarySearch<ValueTuple<object, object>>
	|
	|-RVA: 0xDFFC40 Offset: 0xDFE640 VA: 0x180DFFC40
	|-Array.BinarySearch<AnimatorClipInfo>
	|
	|-RVA: 0xE000D0 Offset: 0xDFEAD0 VA: 0x180E000D0
	|-Array.BinarySearch<AsyncGPUReadbackRequest>
	|
	|-RVA: 0xE00320 Offset: 0xDFED20 VA: 0x180E00320
	|-Array.BinarySearch<BezierContour>
	|
	|-RVA: 0xE00570 Offset: 0xDFEF70 VA: 0x180E00570
	|-Array.BinarySearch<BezierPathSegment>
	|
	|-RVA: 0xE007D0 Offset: 0xDFF1D0 VA: 0x180E007D0
	|-Array.BinarySearch<BezierSegment>
	|
	|-RVA: 0xE00CA0 Offset: 0xDFF6A0 VA: 0x180E00CA0
	|-Array.BinarySearch<bool>
	|
	|-RVA: 0xE00EE0 Offset: 0xDFF8E0 VA: 0x180E00EE0
	|-Array.BinarySearch<Bounds>
	|
	|-RVA: 0xE01140 Offset: 0xDFFB40 VA: 0x180E01140
	|-Array.BinarySearch<byte>
	|
	|-RVA: 0xE01380 Offset: 0xDFFD80 VA: 0x180E01380
	|-Array.BinarySearch<CGSpot>
	|
	|-RVA: 0xE01AA0 Offset: 0xE004A0 VA: 0x180E01AA0
	|-Array.BinarySearch<char>
	|
	|-RVA: 0xE01F20 Offset: 0xE00920 VA: 0x180E01F20
	|-Array.BinarySearch<Color>
	|
	|-RVA: 0xE01CE0 Offset: 0xE006E0 VA: 0x180E01CE0
	|-Array.BinarySearch<Color32>
	|
	|-RVA: 0xE02170 Offset: 0xE00B70 VA: 0x180E02170
	|-Array.BinarySearch<CombineInstance>
	|
	|-RVA: 0xE02680 Offset: 0xE01080 VA: 0x180E02680
	|-Array.BinarySearch<ComputedTransitionProperty>
	|
	|-RVA: 0xE028E0 Offset: 0xE012E0 VA: 0x180E028E0
	|-Array.BinarySearch<Connection>
	|
	|-RVA: 0xE02B30 Offset: 0xE01530 VA: 0x180E02B30
	|-Array.BinarySearch<ContourVertex>
	|
	|-RVA: 0xE03070 Offset: 0xE01A70 VA: 0x180E03070
	|-Array.BinarySearch<ControlPointOption>
	|
	|-RVA: 0xE032D0 Offset: 0xE01CD0 VA: 0x180E032D0
	|-Array.BinarySearch<CoordinateFootprintTilePair>
	|
	|-RVA: 0xE03520 Offset: 0xE01F20 VA: 0x180E03520
	|-Array.BinarySearch<CoordinateProceduralTilePair>
	|
	|-RVA: 0xE03780 Offset: 0xE02180 VA: 0x180E03780
	|-Array.BinarySearch<CoordinateStorageFootprintTilePair>
	|
	|-RVA: 0xE039D0 Offset: 0xE023D0 VA: 0x180E039D0
	|-Array.BinarySearch<CoordinateStorageTilePair>
	|
	|-RVA: 0xE03C20 Offset: 0xE02620 VA: 0x180E03C20
	|-Array.BinarySearch<CoordinateTilePair>
	|
	|-RVA: 0xE04310 Offset: 0xE02D10 VA: 0x180E04310
	|-Array.BinarySearch<DateTime>
	|
	|-RVA: 0xE040C0 Offset: 0xE02AC0 VA: 0x180E040C0
	|-Array.BinarySearch<DateTimeOffset>
	|
	|-RVA: 0xE047B0 Offset: 0xE031B0 VA: 0x180E047B0
	|-Array.BinarySearch<Decimal>
	|
	|-RVA: 0xE04A00 Offset: 0xE03400 VA: 0x180E04A00
	|-Array.BinarySearch<DisplayInfo>
	|
	|-RVA: 0xE05360 Offset: 0xE03D60 VA: 0x180E05360
	|-Array.BinarySearch<double>
	|
	|-RVA: 0xE05110 Offset: 0xE03B10 VA: 0x180E05110
	|-Array.BinarySearch<DoublePoint>
	|
	|-RVA: 0xE04C70 Offset: 0xE03670 VA: 0x180E04C70
	|-Array.BinarySearch<DoublePoint>
	|
	|-RVA: 0xE055B0 Offset: 0xE03FB0 VA: 0x180E055B0
	|-Array.BinarySearch<DualPrefab>
	|
	|-RVA: 0xE05800 Offset: 0xE04200 VA: 0x180E05800
	|-Array.BinarySearch<DuplicateSamplePoint>
	|
	|-RVA: 0xE05A60 Offset: 0xE04460 VA: 0x180E05A60
	|-Array.BinarySearch<EasingFunction>
	|
	|-RVA: 0xE05F00 Offset: 0xE04900 VA: 0x180E05F00
	|-Array.BinarySearch<Entry>
	|
	|-RVA: 0xE06150 Offset: 0xE04B50 VA: 0x180E06150
	|-Array.BinarySearch<EventSummary>
	|
	|-RVA: 0xE065F0 Offset: 0xE04FF0 VA: 0x180E065F0
	|-Array.BinarySearch<FrameTimeSample>
	|
	|-RVA: 0xE06AB0 Offset: 0xE054B0 VA: 0x180E06AB0
	|-Array.BinarySearch<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xE06D20 Offset: 0xE05720 VA: 0x180E06D20
	|-Array.BinarySearch<GlyphRect>
	|
	|-RVA: 0xE06F70 Offset: 0xE05970 VA: 0x180E06F70
	|-Array.BinarySearch<Guid>
	|
	|-RVA: 0xE08130 Offset: 0xE06B30 VA: 0x180E08130
	|-Array.BinarySearch<InputBinding>
	|
	|-RVA: 0xE083D0 Offset: 0xE06DD0 VA: 0x180E083D0
	|-Array.BinarySearch<InputDeviceDescription>
	|
	|-RVA: 0xE08650 Offset: 0xE07050 VA: 0x180E08650
	|-Array.BinarySearch<InputEventPtr>
	|
	|-RVA: 0xE08890 Offset: 0xE07290 VA: 0x180E08890
	|-Array.BinarySearch<short>
	|
	|-RVA: 0xE08F50 Offset: 0xE07950 VA: 0x180E08F50
	|-Array.BinarySearch<Int3>
	|
	|-RVA: 0xE08D10 Offset: 0xE07710 VA: 0x180E08D10
	|-Array.BinarySearch<int>
	|
	|-RVA: 0xE08AD0 Offset: 0xE074D0 VA: 0x180E08AD0
	|-Array.BinarySearch<Int32Enum>
	|
	|-RVA: 0xE091B0 Offset: 0xE07BB0 VA: 0x180E091B0
	|-Array.BinarySearch<long>
	|
	|-RVA: 0xE098B0 Offset: 0xE082B0 VA: 0x180E098B0
	|-Array.BinarySearch<IntPoint>
	|
	|-RVA: 0xE093F0 Offset: 0xE07DF0 VA: 0x180E093F0
	|-Array.BinarySearch<IntPoint>
	|
	|-RVA: 0xE09B00 Offset: 0xE08500 VA: 0x180E09B00
	|-Array.BinarySearch<IntRect>
	|
	|-RVA: 0xE09D50 Offset: 0xE08750 VA: 0x180E09D50
	|-Array.BinarySearch<IntRegion>
	|
	|-RVA: 0xE09FB0 Offset: 0xE089B0 VA: 0x180E09FB0
	|-Array.BinarySearch<InternedString>
	|
	|-RVA: 0xE0A200 Offset: 0xE08C00 VA: 0x180E0A200
	|-Array.BinarySearch<InterpretedFrameInfo>
	|
	|-RVA: 0xE0A450 Offset: 0xE08E50 VA: 0x180E0A450
	|-Array.BinarySearch<IntervalTreeNode>
	|
	|-RVA: 0xE0A6B0 Offset: 0xE090B0 VA: 0x180E0A6B0
	|-Array.BinarySearch<JsonPosition>
	|
	|-RVA: 0xE0BC20 Offset: 0xE0A620 VA: 0x180E0BC20
	|-Array.BinarySearch<Label>
	|
	|-RVA: 0xE0C0F0 Offset: 0xE0AAF0 VA: 0x180E0C0F0
	|-Array.BinarySearch<LigatureSubstitutionRecord>
	|
	|-RVA: 0xE0C340 Offset: 0xE0AD40 VA: 0x180E0C340
	|-Array.BinarySearch<LigatureSubstitutionRecord>
	|
	|-RVA: 0xE0C590 Offset: 0xE0AF90 VA: 0x180E0C590
	|-Array.BinarySearch<ManipulatorActivationFilter>
	|
	|-RVA: 0xE0C7F0 Offset: 0xE0B1F0 VA: 0x180E0C7F0
	|-Array.BinarySearch<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE0CA50 Offset: 0xE0B450 VA: 0x180E0CA50
	|-Array.BinarySearch<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE0CCB0 Offset: 0xE0B6B0 VA: 0x180E0CCB0
	|-Array.BinarySearch<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE0CF10 Offset: 0xE0B910 VA: 0x180E0CF10
	|-Array.BinarySearch<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE0D170 Offset: 0xE0BB70 VA: 0x180E0D170
	|-Array.BinarySearch<Matrix4x4>
	|
	|-RVA: 0xE0D8A0 Offset: 0xE0C2A0 VA: 0x180E0D8A0
	|-Array.BinarySearch<MultipleSubstitutionRecord>
	|
	|-RVA: 0xE0D650 Offset: 0xE0C050 VA: 0x180E0D650
	|-Array.BinarySearch<MultipleSubstitutionRecord>
	|
	|-RVA: 0xE0DAF0 Offset: 0xE0C4F0 VA: 0x180E0DAF0
	|-Array.BinarySearch<NameAndParameters>
	|
	|-RVA: 0xE0DD50 Offset: 0xE0C750 VA: 0x180E0DD50
	|-Array.BinarySearch<NamedValue>
	|
	|-RVA: 0xE0ED90 Offset: 0xE0D790 VA: 0x180E0ED90
	|-Array.BinarySearch<NavMeshBuildMarkup>
	|
	|-RVA: 0xE0EFF0 Offset: 0xE0D9F0 VA: 0x180E0EFF0
	|-Array.BinarySearch<NavMeshBuildSource>
	|
	|-RVA: 0xE131E0 Offset: 0xE11BE0 VA: 0x180E131E0
	|-Array.BinarySearch<object>
	|
	|-RVA: 0xE10780 Offset: 0xE0F180 VA: 0x180E10780
	|-Array.BinarySearch<Playable>
	|
	|-RVA: 0xE10520 Offset: 0xE0EF20 VA: 0x180E10520
	|-Array.BinarySearch<PlayableBinding>
	|
	|-RVA: 0xE10C40 Offset: 0xE0F640 VA: 0x180E10C40
	|-Array.BinarySearch<PlayerLoopSystem>
	|
	|-RVA: 0xE109D0 Offset: 0xE0F3D0 VA: 0x180E109D0
	|-Array.BinarySearch<PlayerLoopSystemInternal>
	|
	|-RVA: 0xE11350 Offset: 0xE0FD50 VA: 0x180E11350
	|-Array.BinarySearch<Quaternion>
	|
	|-RVA: 0xE115A0 Offset: 0xE0FFA0 VA: 0x180E115A0
	|-Array.BinarySearch<RangePositionInfo>
	|
	|-RVA: 0xE11A50 Offset: 0xE10450 VA: 0x180E11A50
	|-Array.BinarySearch<RaycastHit>
	|
	|-RVA: 0xE117F0 Offset: 0xE101F0 VA: 0x180E117F0
	|-Array.BinarySearch<RaycastHit2D>
	|
	|-RVA: 0xE11CC0 Offset: 0xE106C0 VA: 0x180E11CC0
	|-Array.BinarySearch<RaycastResult>
	|
	|-RVA: 0xE11F50 Offset: 0xE10950 VA: 0x180E11F50
	|-Array.BinarySearch<RectInt>
	|
	|-RVA: 0xE121A0 Offset: 0xE10BA0 VA: 0x180E121A0
	|-Array.BinarySearch<RenderTargetIdentifier>
	|
	|-RVA: 0xE12650 Offset: 0xE11050 VA: 0x180E12650
	|-Array.BinarySearch<RendererList>
	|
	|-RVA: 0xE12410 Offset: 0xE10E10 VA: 0x180E12410
	|-Array.BinarySearch<RendererListHandle>
	|
	|-RVA: 0xE128B0 Offset: 0xE112B0 VA: 0x180E128B0
	|-Array.BinarySearch<Resolution>
	|
	|-RVA: 0xE12B00 Offset: 0xE11500 VA: 0x180E12B00
	|-Array.BinarySearch<ResourceHandle>
	|
	|-RVA: 0xE12F90 Offset: 0xE11990 VA: 0x180E12F90
	|-Array.BinarySearch<RuleMatcher>
	|
	|-RVA: 0xE134D0 Offset: 0xE11ED0 VA: 0x180E134D0
	|-Array.BinarySearch<sbyte>
	|
	|-RVA: 0xE13710 Offset: 0xE12110 VA: 0x180E13710
	|-Array.BinarySearch<SamplePointUData>
	|
	|-RVA: 0xE13960 Offset: 0xE12360 VA: 0x180E13960
	|-Array.BinarySearch<SamplePointsPatch>
	|
	|-RVA: 0xE13BA0 Offset: 0xE125A0 VA: 0x180E13BA0
	|-Array.BinarySearch<Scene>
	|
	|-RVA: 0xE13DE0 Offset: 0xE127E0 VA: 0x180E13DE0
	|-Array.BinarySearch<SelectorMatchRecord>
	|
	|-RVA: 0xE14040 Offset: 0xE12A40 VA: 0x180E14040
	|-Array.BinarySearch<ShaderTagId>
	|
	|-RVA: 0xE144F0 Offset: 0xE12EF0 VA: 0x180E144F0
	|-Array.BinarySearch<float>
	|
	|-RVA: 0xE14BE0 Offset: 0xE135E0 VA: 0x180E14BE0
	|-Array.BinarySearch<StylePropertyName>
	|
	|-RVA: 0xE14E30 Offset: 0xE13830 VA: 0x180E14E30
	|-Array.BinarySearch<StylePropertyValue>
	|
	|-RVA: 0xE15080 Offset: 0xE13A80 VA: 0x180E15080
	|-Array.BinarySearch<StyleSelectorPart>
	|
	|-RVA: 0xE152E0 Offset: 0xE13CE0 VA: 0x180E152E0
	|-Array.BinarySearch<StyleSyntaxToken>
	|
	|-RVA: 0xE15790 Offset: 0xE14190 VA: 0x180E15790
	|-Array.BinarySearch<StyleValue>
	|
	|-RVA: 0xE15540 Offset: 0xE13F40 VA: 0x180E15540
	|-Array.BinarySearch<StyleValueManaged>
	|
	|-RVA: 0xE159F0 Offset: 0xE143F0 VA: 0x180E159F0
	|-Array.BinarySearch<StyleVariable>
	|
	|-RVA: 0xE15EA0 Offset: 0xE148A0 VA: 0x180E15EA0
	|-Array.BinarySearch<Substring>
	|
	|-RVA: 0xE16340 Offset: 0xE14D40 VA: 0x180E16340
	|-Array.BinarySearch<TimeSpan>
	|
	|-RVA: 0xE16580 Offset: 0xE14F80 VA: 0x180E16580
	|-Array.BinarySearch<TimeValue>
	|
	|-RVA: 0xE16A10 Offset: 0xE15410 VA: 0x180E16A10
	|-Array.BinarySearch<TreeViewItemWrapper>
	|
	|-RVA: 0xE17100 Offset: 0xE15B00 VA: 0x180E17100
	|-Array.BinarySearch<UICharInfo>
	|
	|-RVA: 0xE17360 Offset: 0xE15D60 VA: 0x180E17360
	|-Array.BinarySearch<UILineInfo>
	|
	|-RVA: 0xE175B0 Offset: 0xE15FB0 VA: 0x180E175B0
	|-Array.BinarySearch<UIVertex>
	|
	|-RVA: 0xE17860 Offset: 0xE16260 VA: 0x180E17860
	|-Array.BinarySearch<ushort>
	|
	|-RVA: 0xE17CE0 Offset: 0xE166E0 VA: 0x180E17CE0
	|-Array.BinarySearch<uint>
	|
	|-RVA: 0xE17AA0 Offset: 0xE164A0 VA: 0x180E17AA0
	|-Array.BinarySearch<UInt32Enum>
	|
	|-RVA: 0xE17F20 Offset: 0xE16920 VA: 0x180E17F20
	|-Array.BinarySearch<ulong>
	|
	|-RVA: 0xE18200 Offset: 0xE16C00 VA: 0x180E18200
	|-Array.BinarySearch<UShort2>
	|
	|-RVA: 0xE18440 Offset: 0xE16E40 VA: 0x180E18440
	|-Array.BinarySearch<UnloadedScene>
	|
	|-RVA: 0xE18690 Offset: 0xE17090 VA: 0x180E18690
	|-Array.BinarySearch<UsageHint>
	|
	|-RVA: 0xE196B0 Offset: 0xE180B0 VA: 0x180E196B0
	|-Array.BinarySearch<Vector2>
	|
	|-RVA: 0xE19900 Offset: 0xE18300 VA: 0x180E19900
	|-Array.BinarySearch<Vector3>
	|
	|-RVA: 0xE19B60 Offset: 0xE18560 VA: 0x180E19B60
	|-Array.BinarySearch<Vector4>
	|
	|-RVA: 0xE1A060 Offset: 0xE18A60 VA: 0x180E1A060
	|-Array.BinarySearch<VoxelContour>
	|
	|-RVA: 0xE1A530 Offset: 0xE18F30 VA: 0x180E1A530
	|-Array.BinarySearch<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xE1A7F0 Offset: 0xE191F0 VA: 0x180E1A7F0
	|-Array.BinarySearch<X509ChainStatus>
	|
	|-RVA: 0xE1AA40 Offset: 0xE19440 VA: 0x180E1AA40
	|-Array.BinarySearch<XRFeatureDescriptor>
	|
	|-RVA: 0xE1ACA0 Offset: 0xE196A0 VA: 0x180E1ACA0
	|-Array.BinarySearch<XRView>
	|
	|-RVA: 0xE1AF70 Offset: 0xE19970 VA: 0x180E1AF70
	|-Array.BinarySearch<ZipGenericExtraField>
	|
	|-RVA: 0xE07C60 Offset: 0xE06660 VA: 0x180E07C60
	|-Array.BinarySearch<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE14280 Offset: 0xE12C80 VA: 0x180E14280
	|-Array.BinarySearch<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|
	|-RVA: 0xE16EB0 Offset: 0xE158B0 VA: 0x180E16EB0
	|-Array.BinarySearch<AdvancedSmooth.Turn>
	|
	|-RVA: 0xE1A2C0 Offset: 0xE18CC0 VA: 0x180E1A2C0
	|-Array.BinarySearch<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0xE0BE90 Offset: 0xE0A890 VA: 0x180E0BE90
	|-Array.BinarySearch<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xE0F730 Offset: 0xE0E130 VA: 0x180E0F730
	|-Array.BinarySearch<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0xE0FBE0 Offset: 0xE0E5E0 VA: 0x180E0FBE0
	|-Array.BinarySearch<BitmapAllocator32.Page>
	|
	|-RVA: 0xE03E70 Offset: 0xE02870 VA: 0x180E03E70
	|-Array.BinarySearch<CameraState.CustomBlendable>
	|
	|-RVA: 0xE10080 Offset: 0xE0EA80 VA: 0x180E10080
	|-Array.BinarySearch<CinemachineClearShot.Pair>
	|
	|-RVA: 0xE07910 Offset: 0xE06310 VA: 0x180E07910
	|-Array.BinarySearch<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0xE04EC0 Offset: 0xE038C0 VA: 0x180E04EC0
	|-Array.BinarySearch<ClipperLib.DoublePoint>
	|
	|-RVA: 0xE09660 Offset: 0xE08060 VA: 0x180E09660
	|-Array.BinarySearch<ClipperLib.IntPoint>
	|
	|-RVA: 0xE10EB0 Offset: 0xE0F8B0 VA: 0x180E10EB0
	|-Array.BinarySearch<ConfinerOven.PolygonSolution>
	|
	|-RVA: 0xE04550 Offset: 0xE02F50 VA: 0x180E04550
	|-Array.BinarySearch<DecalEntityIndexer.DecalEntityItem>
	|
	|-RVA: 0xE02410 Offset: 0xE00E10 VA: 0x180E02410
	|-Array.BinarySearch<DecalEntityManager.CombinedChunks>
	|
	|-RVA: 0xE063A0 Offset: 0xE04DA0 VA: 0x180E063A0
	|-Array.BinarySearch<FocusController.FocusedElement>
	|
	|-RVA: 0xE06850 Offset: 0xE05250 VA: 0x180E06850
	|-Array.BinarySearch<FrameTimingsHUDDisplay.FrameTimingPoint>
	|
	|-RVA: 0xE102C0 Offset: 0xE0ECC0 VA: 0x180E102C0
	|-Array.BinarySearch<Funnel.PathPart>
	|
	|-RVA: 0xE19DB0 Offset: 0xE187B0 VA: 0x180E19DB0
	|-Array.BinarySearch<GodRaysRenderPass.VisibleLightRemap>
	|
	|-RVA: 0xE071C0 Offset: 0xE05BC0 VA: 0x180E071C0
	|-Array.BinarySearch<HID.HIDCollectionDescriptor>
	|
	|-RVA: 0xE07420 Offset: 0xE05E20 VA: 0x180E07420
	|-Array.BinarySearch<HID.HIDElementDescriptor>
	|
	|-RVA: 0xE076B0 Offset: 0xE060B0 VA: 0x180E076B0
	|-Array.BinarySearch<HIDParser.HIDReportData>
	|
	|-RVA: 0xE11100 Offset: 0xE0FB00 VA: 0x180E11100
	|-Array.BinarySearch<HeatmapManager.PropertyRegionReference>
	|
	|-RVA: 0xE00A30 Offset: 0xDFF430 VA: 0x180E00A30
	|-Array.BinarySearch<InputActionMap.BindingOverrideJson>
	|
	|-RVA: 0xE02D90 Offset: 0xE01790 VA: 0x180E02D90
	|-Array.BinarySearch<InputControlLayout.ControlItem>
	|
	|-RVA: 0xE167C0 Offset: 0xE151C0 VA: 0x180E167C0
	|-Array.BinarySearch<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xE0A910 Offset: 0xE09310 VA: 0x180E0A910
	|-Array.BinarySearch<JsonParser.JsonValue>
	|
	|-RVA: 0xE0D3F0 Offset: 0xE0BDF0 VA: 0x180E0D3F0
	|-Array.BinarySearch<LatencySimulator.Message>
	|
	|-RVA: 0xE14740 Offset: 0xE13140 VA: 0x180E14740
	|-Array.BinarySearch<MultiColumnCollectionHeader.SortedColumnState>
	|
	|-RVA: 0xE160F0 Offset: 0xE14AF0 VA: 0x180E160F0
	|-Array.BinarySearch<NativeMethods.TASKDIALOG_BUTTON>
	|
	|-RVA: 0xE16C70 Offset: 0xE15670 VA: 0x180E16C70
	|-Array.BinarySearch<NetworkAnimator.TriggerUpdate>
	|
	|-RVA: 0xF37250 Offset: 0xF35C50 VA: 0x180F37250
	|-Array.BinarySearch<OutlineEffect.OutlineTargetGroup>
	|
	|-RVA: 0xF33E40 Offset: 0xF32840 VA: 0x180F33E40
	|-Array.BinarySearch<PlayingCard.CardData>
	|
	|-RVA: 0xF38540 Offset: 0xF36F40 VA: 0x180F38540
	|-Array.BinarySearch<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xF33990 Offset: 0xF32390 VA: 0x180F33990
	|-Array.BinarySearch<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xF39880 Offset: 0xF38280 VA: 0x180F39880
	|-Array.BinarySearch<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|
	|-RVA: 0xF38F00 Offset: 0xF37900 VA: 0x180F38F00
	|-Array.BinarySearch<ProbeVolumeSceneData.SerializableBoundItem>
	|
	|-RVA: 0xF39160 Offset: 0xF37B60 VA: 0x180F39160
	|-Array.BinarySearch<ProbeVolumeSceneData.SerializableHasPVItem>
	|
	|-RVA: 0xF393B0 Offset: 0xF37DB0 VA: 0x180F393B0
	|-Array.BinarySearch<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|
	|-RVA: 0xF39630 Offset: 0xF38030 VA: 0x180F39630
	|-Array.BinarySearch<ProbeVolumeSceneData.SerializablePVProfile>
	|
	|-RVA: 0xF39AE0 Offset: 0xF384E0 VA: 0x180F39AE0
	|-Array.BinarySearch<RegexCharClass.SingleRange>
	|
	|-RVA: 0xF38050 Offset: 0xF36A50 VA: 0x180F38050
	|-Array.BinarySearch<RenderChain.RenderNodeData>
	|
	|-RVA: 0xF374A0 Offset: 0xF35EA0 VA: 0x180F374A0
	|-Array.BinarySearch<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0xF387A0 Offset: 0xF371A0 VA: 0x180F387A0
	|-Array.BinarySearch<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0xF36430 Offset: 0xF34E30 VA: 0x180F36430
	|-Array.BinarySearch<RetainedGizmos.MeshWithHash>
	|
	|-RVA: 0xF38A10 Offset: 0xF37410 VA: 0x180F38A10
	|-Array.BinarySearch<RigidbodyPauser.Rigidbody2DData>
	|
	|-RVA: 0xF38C80 Offset: 0xF37680 VA: 0x180F38C80
	|-Array.BinarySearch<RigidbodyPauser.RigidbodyData>
	|
	|-RVA: 0xF36690 Offset: 0xF35090 VA: 0x180F36690
	|-Array.BinarySearch<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF35AA0 Offset: 0xF344A0 VA: 0x180F35AA0
	|-Array.BinarySearch<SVGDocument.HierarchyUpdate>
	|
	|-RVA: 0xF36B40 Offset: 0xF35540 VA: 0x180F36B40
	|-Array.BinarySearch<SVGDocument.NodeReferenceData>
	|
	|-RVA: 0xF36DA0 Offset: 0xF357A0 VA: 0x180F36DA0
	|-Array.BinarySearch<SVGDocument.NodeWithParent>
	|
	|-RVA: 0xF37710 Offset: 0xF36110 VA: 0x180F37710
	|-Array.BinarySearch<SVGDocument.PostponedClip>
	|
	|-RVA: 0xF37950 Offset: 0xF36350 VA: 0x180F37950
	|-Array.BinarySearch<SVGDocument.PostponedStopData>
	|
	|-RVA: 0xF349E0 Offset: 0xF333E0 VA: 0x180F349E0
	|-Array.BinarySearch<ServerSocket.ConnectionChange>
	|
	|-RVA: 0xF368E0 Offset: 0xF352E0 VA: 0x180F368E0
	|-Array.BinarySearch<SewerMushroomLocation.MushroomLocationData>
	|
	|-RVA: 0xF350D0 Offset: 0xF33AD0 VA: 0x180F350D0
	|-Array.BinarySearch<ShadowUtility.Edge>
	|
	|-RVA: 0xF34520 Offset: 0xF32F20 VA: 0x180F34520
	|-Array.BinarySearch<StructySync.ChangeData>
	|
	|-RVA: 0xF342E0 Offset: 0xF32CE0 VA: 0x180F342E0
	|-Array.BinarySearch<SyncStopwatch.ChangeData>
	|
	|-RVA: 0xF34080 Offset: 0xF32A80 VA: 0x180F34080
	|-Array.BinarySearch<SyncTimer.ChangeData>
	|
	|-RVA: 0xF33BF0 Offset: 0xF325F0 VA: 0x180F33BF0
	|-Array.BinarySearch<TargetStateListener.Callback>
	|
	|-RVA: 0xF334B0 Offset: 0xF31EB0 VA: 0x180F334B0
	|-Array.BinarySearch<TemplateAsset.AttributeOverride>
	|
	|-RVA: 0xF355D0 Offset: 0xF33FD0 VA: 0x180F355D0
	|-Array.BinarySearch<TextSettings.FontReferenceMap>
	|
	|-RVA: 0xF33710 Offset: 0xF32110 VA: 0x180F33710
	|-Array.BinarySearch<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xF35820 Offset: 0xF34220 VA: 0x180F35820
	|-Array.BinarySearch<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xF3A1C0 Offset: 0xF38BC0 VA: 0x180F3A1C0
	|-Array.BinarySearch<TextureRegistry.TextureInfo>
	|
	|-RVA: 0xF36FF0 Offset: 0xF359F0 VA: 0x180F36FF0
	|-Array.BinarySearch<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0xF37B90 Offset: 0xF36590 VA: 0x180F37B90
	|-Array.BinarySearch<TrackedDeviceRaycaster.RaycastHitData>
	|
	|-RVA: 0xF34E80 Offset: 0xF33880 VA: 0x180F34E80
	|-Array.BinarySearch<TransportManager.DisconnectingClient>
	|
	|-RVA: 0xF35340 Offset: 0xF33D40 VA: 0x180F35340
	|-Array.BinarySearch<UIRStylePainter.Entry>
	|
	|-RVA: 0xF382E0 Offset: 0xF36CE0 VA: 0x180F382E0
	|-Array.BinarySearch<UIRStylePainter.RepeatRectUV>
	|
	|-RVA: 0xF32D50 Offset: 0xF31750 VA: 0x180F32D50
	|-Array.BinarySearch<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xF32FC0 Offset: 0xF319C0 VA: 0x180F32FC0
	|-Array.BinarySearch<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xF3AB30 Offset: 0xF39530 VA: 0x180F3AB30
	|-Array.BinarySearch<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0xF33250 Offset: 0xF31C50 VA: 0x180F33250
	|-Array.BinarySearch<VisualTreeAsset.AssetEntry>
	|
	|-RVA: 0xF39D20 Offset: 0xF38720 VA: 0x180F39D20
	|-Array.BinarySearch<VisualTreeAsset.SlotDefinition>
	|
	|-RVA: 0xF39F70 Offset: 0xF38970 VA: 0x180F39F70
	|-Array.BinarySearch<VisualTreeAsset.SlotUsageEntry>
	|
	|-RVA: 0xF3A410 Offset: 0xF38E10 VA: 0x180F3A410
	|-Array.BinarySearch<VisualTreeAsset.UsingEntry>
	|
	|-RVA: 0xF3A670 Offset: 0xF39070 VA: 0x180F3A670
	|-Array.BinarySearch<VisualTreeAsset.UxmlObjectEntry>
	|
	|-RVA: 0xF3AD90 Offset: 0xF39790 VA: 0x180F3AD90
	|-Array.BinarySearch<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0xF3A8C0 Offset: 0xF392C0 VA: 0x180F3A8C0
	|-Array.BinarySearch<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xF34C30 Offset: 0xF33630 VA: 0x180F34C30
	|-Array.BinarySearch<DebugUI.Foldout.ContextMenuItem>
	|
	|-RVA: 0xF361D0 Offset: 0xF34BD0 VA: 0x180F361D0
	|-Array.BinarySearch<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xF35D00 Offset: 0xF34700 VA: 0x180F35D00
	|-Array.BinarySearch<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0xF34780 Offset: 0xF33180 VA: 0x180F34780
	|-Array.BinarySearch<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xF35F60 Offset: 0xF34960 VA: 0x180F35F60
	|-Array.BinarySearch<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xF37DF0 Offset: 0xF367F0 VA: 0x180F37DF0
	|-Array.BinarySearch<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x1C7CD00 Offset: 0x1C7B700 VA: 0x181C7CD00
	public static int IndexOf(Array array, object value) { }

	// RVA: 0x1C7CC10 Offset: 0x1C7B610 VA: 0x181C7CC10
	public static int IndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x1C7CDF0 Offset: 0x1C7B7F0 VA: 0x181C7CDF0
	public static int IndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3E0F0 Offset: 0xF3CAF0 VA: 0x180F3E0F0
	|-Array.IndexOf<byte>
	|
	|-RVA: 0xF3E7E0 Offset: 0xF3D1E0 VA: 0x180F3E7E0
	|-Array.IndexOf<char>
	|
	|-RVA: 0xF42450 Offset: 0xF40E50 VA: 0x180F42450
	|-Array.IndexOf<int>
	|
	|-RVA: 0xF42240 Offset: 0xF40C40 VA: 0x180F42240
	|-Array.IndexOf<Int32Enum>
	|
	|-RVA: 0xF48360 Offset: 0xF46D60 VA: 0x180F48360
	|-Array.IndexOf<object>
	|
	|-RVA: 0xF49390 Offset: 0xF47D90 VA: 0x180F49390
	|-Array.IndexOf<Vector2>
	|
	|-RVA: 0xF41640 Offset: 0xF40040 VA: 0x180F41640
	|-Array.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF41780 Offset: 0xF40180 VA: 0x180F41780
	|-Array.IndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3D460 Offset: 0xF3BE60 VA: 0x180F3D460
	|-Array.IndexOf<ArraySegment<byte>>
	|
	|-RVA: 0xF3E340 Offset: 0xF3CD40 VA: 0x180F3E340
	|-Array.IndexOf<SyncList.CachedOnChange<int>>
	|
	|-RVA: 0xF3E4D0 Offset: 0xF3CED0 VA: 0x180F3E4D0
	|-Array.IndexOf<SyncList.ChangeData<int>>
	|
	|-RVA: 0xF40B10 Offset: 0xF3F510 VA: 0x180F40B10
	|-Array.IndexOf<IntervalTree.Entry<object>>
	|
	|-RVA: 0xF43960 Offset: 0xF42360 VA: 0x180F43960
	|-Array.IndexOf<KeyValuePair<int, object>>
	|
	|-RVA: 0xF437D0 Offset: 0xF421D0 VA: 0x180F437D0
	|-Array.IndexOf<KeyValuePair<object, bool>>
	|
	|-RVA: 0xF43AF0 Offset: 0xF424F0 VA: 0x180F43AF0
	|-Array.IndexOf<KeyValuePair<object, char>>
	|
	|-RVA: 0xF43E40 Offset: 0xF42840 VA: 0x180F43E40
	|-Array.IndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0xF43C80 Offset: 0xF42680 VA: 0x180F43C80
	|-Array.IndexOf<KeyValuePair<object, JsonParser.JsonValue>>
	|
	|-RVA: 0xF43640 Offset: 0xF42040 VA: 0x180F43640
	|-Array.IndexOf<KeyValuePair<PropertyName, object>>
	|
	|-RVA: 0xF434A0 Offset: 0xF41EA0 VA: 0x180F434A0
	|-Array.IndexOf<KeyValuePair<Rect, object>>
	|
	|-RVA: 0xF45B00 Offset: 0xF44500 VA: 0x180F45B00
	|-Array.IndexOf<NativeArray<ConvertMeshJobData>>
	|
	|-RVA: 0xF457E0 Offset: 0xF441E0 VA: 0x180F457E0
	|-Array.IndexOf<NativeArray<CopyClosingMeshJobData>>
	|
	|-RVA: 0xF45970 Offset: 0xF44370 VA: 0x180F45970
	|-Array.IndexOf<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xF45C90 Offset: 0xF44690 VA: 0x180F45C90
	|-Array.IndexOf<NativeSlice<ConvertMeshJobData>>
	|
	|-RVA: 0xF45FB0 Offset: 0xF449B0 VA: 0x180F45FB0
	|-Array.IndexOf<NativeSlice<CopyClosingMeshJobData>>
	|
	|-RVA: 0xF45E20 Offset: 0xF44820 VA: 0x180F45E20
	|-Array.IndexOf<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xF46650 Offset: 0xF45050 VA: 0x180F46650
	|-Array.IndexOf<Nullable<DateTime>>
	|
	|-RVA: 0xF464B0 Offset: 0xF44EB0 VA: 0x180F464B0
	|-Array.IndexOf<Nullable<Decimal>>
	|
	|-RVA: 0xF46980 Offset: 0xF45380 VA: 0x180F46980
	|-Array.IndexOf<TempAllocator.Page<ushort>>
	|
	|-RVA: 0xF46B20 Offset: 0xF45520 VA: 0x180F46B20
	|-Array.IndexOf<TempAllocator.Page<Vertex>>
	|
	|-RVA: 0xF48060 Offset: 0xF46A60 VA: 0x180F48060
	|-Array.IndexOf<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0xF48400 Offset: 0xF46E00 VA: 0x180F48400
	|-Array.IndexOf<StructMultiKey<object, object>>
	|
	|-RVA: 0xF48590 Offset: 0xF46F90 VA: 0x180F48590
	|-Array.IndexOf<SubArray<int>>
	|
	|-RVA: 0xF48A50 Offset: 0xF47450 VA: 0x180F48A50
	|-Array.IndexOf<ValueTuple<int, int>>
	|
	|-RVA: 0xF49200 Offset: 0xF47C00 VA: 0x180F49200
	|-Array.IndexOf<ValueTuple<int, object>>
	|
	|-RVA: 0xF48BD0 Offset: 0xF475D0 VA: 0x180F48BD0
	|-Array.IndexOf<ValueTuple<int, Scene>>
	|
	|-RVA: 0xF488C0 Offset: 0xF472C0 VA: 0x180F488C0
	|-Array.IndexOf<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xF49070 Offset: 0xF47A70 VA: 0x180F49070
	|-Array.IndexOf<ValueTuple<IntPtr, object>>
	|
	|-RVA: 0xF48720 Offset: 0xF47120 VA: 0x180F48720
	|-Array.IndexOf<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xF48EE0 Offset: 0xF478E0 VA: 0x180F48EE0
	|-Array.IndexOf<ValueTuple<object, int>>
	|
	|-RVA: 0xF48D50 Offset: 0xF47750 VA: 0x180F48D50
	|-Array.IndexOf<ValueTuple<object, object>>
	|
	|-RVA: 0xF3D2E0 Offset: 0xF3BCE0 VA: 0x180F3D2E0
	|-Array.IndexOf<AnimatorClipInfo>
	|
	|-RVA: 0xF3D5F0 Offset: 0xF3BFF0 VA: 0x180F3D5F0
	|-Array.IndexOf<AsyncGPUReadbackRequest>
	|
	|-RVA: 0xF3D780 Offset: 0xF3C180 VA: 0x180F3D780
	|-Array.IndexOf<BezierContour>
	|
	|-RVA: 0xF3D910 Offset: 0xF3C310 VA: 0x180F3D910
	|-Array.IndexOf<BezierPathSegment>
	|
	|-RVA: 0xF3DAB0 Offset: 0xF3C4B0 VA: 0x180F3DAB0
	|-Array.IndexOf<BezierSegment>
	|
	|-RVA: 0xF3DC50 Offset: 0xF3C650 VA: 0x180F3DC50
	|-Array.IndexOf<bool>
	|
	|-RVA: 0xF3DDD0 Offset: 0xF3C7D0 VA: 0x180F3DDD0
	|-Array.IndexOf<Bounds>
	|
	|-RVA: 0xF3DF70 Offset: 0xF3C970 VA: 0x180F3DF70
	|-Array.IndexOf<byte>
	|
	|-RVA: 0xF3E190 Offset: 0xF3CB90 VA: 0x180F3E190
	|-Array.IndexOf<CGSpot>
	|
	|-RVA: 0xF3E660 Offset: 0xF3D060 VA: 0x180F3E660
	|-Array.IndexOf<char>
	|
	|-RVA: 0xF3E9F0 Offset: 0xF3D3F0 VA: 0x180F3E9F0
	|-Array.IndexOf<Color>
	|
	|-RVA: 0xF3E880 Offset: 0xF3D280 VA: 0x180F3E880
	|-Array.IndexOf<Color32>
	|
	|-RVA: 0xF3EB80 Offset: 0xF3D580 VA: 0x180F3EB80
	|-Array.IndexOf<CombineInstance>
	|
	|-RVA: 0xF3ED60 Offset: 0xF3D760 VA: 0x180F3ED60
	|-Array.IndexOf<ComputedTransitionProperty>
	|
	|-RVA: 0xF3EF00 Offset: 0xF3D900 VA: 0x180F3EF00
	|-Array.IndexOf<Connection>
	|
	|-RVA: 0xF3F090 Offset: 0xF3DA90 VA: 0x180F3F090
	|-Array.IndexOf<ContourVertex>
	|
	|-RVA: 0xF3F230 Offset: 0xF3DC30 VA: 0x180F3F230
	|-Array.IndexOf<ControlPointOption>
	|
	|-RVA: 0xF3F3D0 Offset: 0xF3DDD0 VA: 0x180F3F3D0
	|-Array.IndexOf<CoordinateFootprintTilePair>
	|
	|-RVA: 0xF3F560 Offset: 0xF3DF60 VA: 0x180F3F560
	|-Array.IndexOf<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF3F700 Offset: 0xF3E100 VA: 0x180F3F700
	|-Array.IndexOf<CoordinateStorageFootprintTilePair>
	|
	|-RVA: 0xF3F890 Offset: 0xF3E290 VA: 0x180F3F890
	|-Array.IndexOf<CoordinateStorageTilePair>
	|
	|-RVA: 0xF3FA20 Offset: 0xF3E420 VA: 0x180F3FA20
	|-Array.IndexOf<CoordinateTilePair>
	|
	|-RVA: 0xF3FD40 Offset: 0xF3E740 VA: 0x180F3FD40
	|-Array.IndexOf<DateTime>
	|
	|-RVA: 0xF3FBB0 Offset: 0xF3E5B0 VA: 0x180F3FBB0
	|-Array.IndexOf<DateTimeOffset>
	|
	|-RVA: 0xF3FEC0 Offset: 0xF3E8C0 VA: 0x180F3FEC0
	|-Array.IndexOf<Decimal>
	|
	|-RVA: 0xF40050 Offset: 0xF3EA50 VA: 0x180F40050
	|-Array.IndexOf<DisplayInfo>
	|
	|-RVA: 0xF40510 Offset: 0xF3EF10 VA: 0x180F40510
	|-Array.IndexOf<double>
	|
	|-RVA: 0xF40380 Offset: 0xF3ED80 VA: 0x180F40380
	|-Array.IndexOf<DoublePoint>
	|
	|-RVA: 0xF401F0 Offset: 0xF3EBF0 VA: 0x180F401F0
	|-Array.IndexOf<DoublePoint>
	|
	|-RVA: 0xF40680 Offset: 0xF3F080 VA: 0x180F40680
	|-Array.IndexOf<DualPrefab>
	|
	|-RVA: 0xF40810 Offset: 0xF3F210 VA: 0x180F40810
	|-Array.IndexOf<DuplicateSamplePoint>
	|
	|-RVA: 0xF409A0 Offset: 0xF3F3A0 VA: 0x180F409A0
	|-Array.IndexOf<EasingFunction>
	|
	|-RVA: 0xF40CB0 Offset: 0xF3F6B0 VA: 0x180F40CB0
	|-Array.IndexOf<Entry>
	|
	|-RVA: 0xF40E40 Offset: 0xF3F840 VA: 0x180F40E40
	|-Array.IndexOf<EventSummary>
	|
	|-RVA: 0xF40FD0 Offset: 0xF3F9D0 VA: 0x180F40FD0
	|-Array.IndexOf<FrameTimeSample>
	|
	|-RVA: 0xF41170 Offset: 0xF3FB70 VA: 0x180F41170
	|-Array.IndexOf<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xF41320 Offset: 0xF3FD20 VA: 0x180F41320
	|-Array.IndexOf<GlyphRect>
	|
	|-RVA: 0xF414B0 Offset: 0xF3FEB0 VA: 0x180F414B0
	|-Array.IndexOf<Guid>
	|
	|-RVA: 0xF418D0 Offset: 0xF402D0 VA: 0x180F418D0
	|-Array.IndexOf<InputBinding>
	|
	|-RVA: 0xF41AA0 Offset: 0xF404A0 VA: 0x180F41AA0
	|-Array.IndexOf<InputDeviceDescription>
	|
	|-RVA: 0xF41C50 Offset: 0xF40650 VA: 0x180F41C50
	|-Array.IndexOf<InputEventPtr>
	|
	|-RVA: 0xF41DD0 Offset: 0xF407D0 VA: 0x180F41DD0
	|-Array.IndexOf<short>
	|
	|-RVA: 0xF41F50 Offset: 0xF40950 VA: 0x180F41F50
	|-Array.IndexOf<Int2>
	|
	|-RVA: 0xF424F0 Offset: 0xF40EF0 VA: 0x180F424F0
	|-Array.IndexOf<Int3>
	|
	|-RVA: 0xF422E0 Offset: 0xF40CE0 VA: 0x180F422E0
	|-Array.IndexOf<int>
	|
	|-RVA: 0xF420D0 Offset: 0xF40AD0 VA: 0x180F420D0
	|-Array.IndexOf<Int32Enum>
	|
	|-RVA: 0xF42680 Offset: 0xF41080 VA: 0x180F42680
	|-Array.IndexOf<long>
	|
	|-RVA: 0xF42990 Offset: 0xF41390 VA: 0x180F42990
	|-Array.IndexOf<IntPoint>
	|
	|-RVA: 0xF427F0 Offset: 0xF411F0 VA: 0x180F427F0
	|-Array.IndexOf<IntPoint>
	|
	|-RVA: 0xF42B20 Offset: 0xF41520 VA: 0x180F42B20
	|-Array.IndexOf<IntRect>
	|
	|-RVA: 0xF42CB0 Offset: 0xF416B0 VA: 0x180F42CB0
	|-Array.IndexOf<IntRegion>
	|
	|-RVA: 0xF42E40 Offset: 0xF41840 VA: 0x180F42E40
	|-Array.IndexOf<InternedString>
	|
	|-RVA: 0xF42FD0 Offset: 0xF419D0 VA: 0x180F42FD0
	|-Array.IndexOf<InterpretedFrameInfo>
	|
	|-RVA: 0xF43160 Offset: 0xF41B60 VA: 0x180F43160
	|-Array.IndexOf<IntervalTreeNode>
	|
	|-RVA: 0xF43300 Offset: 0xF41D00 VA: 0x180F43300
	|-Array.IndexOf<JsonPosition>
	|
	|-RVA: 0xF43FD0 Offset: 0xF429D0 VA: 0x180F43FD0
	|-Array.IndexOf<Label>
	|
	|-RVA: 0xF44180 Offset: 0xF42B80 VA: 0x180F44180
	|-Array.IndexOf<LigatureSubstitutionRecord>
	|
	|-RVA: 0xF44310 Offset: 0xF42D10 VA: 0x180F44310
	|-Array.IndexOf<LigatureSubstitutionRecord>
	|
	|-RVA: 0xF44630 Offset: 0xF43030 VA: 0x180F44630
	|-Array.IndexOf<LocalPacket>
	|
	|-RVA: 0xF444A0 Offset: 0xF42EA0 VA: 0x180F444A0
	|-Array.IndexOf<LocalPacket>
	|
	|-RVA: 0xF447C0 Offset: 0xF431C0 VA: 0x180F447C0
	|-Array.IndexOf<ManipulatorActivationFilter>
	|
	|-RVA: 0xF44950 Offset: 0xF43350 VA: 0x180F44950
	|-Array.IndexOf<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xF44AF0 Offset: 0xF434F0 VA: 0x180F44AF0
	|-Array.IndexOf<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xF44C90 Offset: 0xF43690 VA: 0x180F44C90
	|-Array.IndexOf<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xF44E30 Offset: 0xF43830 VA: 0x180F44E30
	|-Array.IndexOf<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xF44FD0 Offset: 0xF439D0 VA: 0x180F44FD0
	|-Array.IndexOf<Matrix4x4>
	|
	|-RVA: 0xF45310 Offset: 0xF43D10 VA: 0x180F45310
	|-Array.IndexOf<MultipleSubstitutionRecord>
	|
	|-RVA: 0xF45180 Offset: 0xF43B80 VA: 0x180F45180
	|-Array.IndexOf<MultipleSubstitutionRecord>
	|
	|-RVA: 0xF454A0 Offset: 0xF43EA0 VA: 0x180F454A0
	|-Array.IndexOf<NameAndParameters>
	|
	|-RVA: 0xF45640 Offset: 0xF44040 VA: 0x180F45640
	|-Array.IndexOf<NamedValue>
	|
	|-RVA: 0xF46140 Offset: 0xF44B40 VA: 0x180F46140
	|-Array.IndexOf<NavMeshBuildMarkup>
	|
	|-RVA: 0xF462E0 Offset: 0xF44CE0 VA: 0x180F462E0
	|-Array.IndexOf<NavMeshBuildSource>
	|
	|-RVA: 0xF481F0 Offset: 0xF46BF0 VA: 0x180F481F0
	|-Array.IndexOf<object>
	|
	|-RVA: 0xF467E0 Offset: 0xF451E0 VA: 0x180F467E0
	|-Array.IndexOf<Packet>
	|
	|-RVA: 0xF46E60 Offset: 0xF45860 VA: 0x180F46E60
	|-Array.IndexOf<Playable>
	|
	|-RVA: 0xF46CC0 Offset: 0xF456C0 VA: 0x180F46CC0
	|-Array.IndexOf<PlayableBinding>
	|
	|-RVA: 0xF471A0 Offset: 0xF45BA0 VA: 0x180F471A0
	|-Array.IndexOf<PlayerLoopSystem>
	|
	|-RVA: 0xF46FF0 Offset: 0xF459F0 VA: 0x180F46FF0
	|-Array.IndexOf<PlayerLoopSystemInternal>
	|
	|-RVA: 0xF47350 Offset: 0xF45D50 VA: 0x180F47350
	|-Array.IndexOf<Quaternion>
	|
	|-RVA: 0xF474E0 Offset: 0xF45EE0 VA: 0x180F474E0
	|-Array.IndexOf<RangePositionInfo>
	|
	|-RVA: 0xF47810 Offset: 0xF46210 VA: 0x180F47810
	|-Array.IndexOf<RaycastHit>
	|
	|-RVA: 0xF47670 Offset: 0xF46070 VA: 0x180F47670
	|-Array.IndexOf<RaycastHit2D>
	|
	|-RVA: 0xF479C0 Offset: 0xF463C0 VA: 0x180F479C0
	|-Array.IndexOf<RaycastResult>
	|
	|-RVA: 0xF47B80 Offset: 0xF46580 VA: 0x180F47B80
	|-Array.IndexOf<RectInt>
	|
	|-RVA: 0xF47D10 Offset: 0xF46710 VA: 0x180F47D10
	|-Array.IndexOf<RenderTargetIdentifier>
	|
	|-RVA: 0xF47EC0 Offset: 0xF468C0 VA: 0x180F47EC0
	|-Array.IndexOf<RendererList>
	|
	|-RVA: 0xFAEA50 Offset: 0xFAD450 VA: 0x180FAEA50
	|-Array.IndexOf<RendererListHandle>
	|
	|-RVA: 0xFAEF00 Offset: 0xFAD900 VA: 0x180FAEF00
	|-Array.IndexOf<Resolution>
	|
	|-RVA: 0xFAF240 Offset: 0xFADC40 VA: 0x180FAF240
	|-Array.IndexOf<ResourceHandle>
	|
	|-RVA: 0xFAF710 Offset: 0xFAE110 VA: 0x180FAF710
	|-Array.IndexOf<RuleMatcher>
	|
	|-RVA: 0xFAF8A0 Offset: 0xFAE2A0 VA: 0x180FAF8A0
	|-Array.IndexOf<sbyte>
	|
	|-RVA: 0xFAFA20 Offset: 0xFAE420 VA: 0x180FAFA20
	|-Array.IndexOf<SamplePointUData>
	|
	|-RVA: 0xFAFBB0 Offset: 0xFAE5B0 VA: 0x180FAFBB0
	|-Array.IndexOf<SamplePointsPatch>
	|
	|-RVA: 0xFAFD30 Offset: 0xFAE730 VA: 0x180FAFD30
	|-Array.IndexOf<Scene>
	|
	|-RVA: 0xFAFEA0 Offset: 0xFAE8A0 VA: 0x180FAFEA0
	|-Array.IndexOf<SelectorMatchRecord>
	|
	|-RVA: 0xFB0850 Offset: 0xFAF250 VA: 0x180FB0850
	|-Array.IndexOf<ShaderTagId>
	|
	|-RVA: 0xFB0CD0 Offset: 0xFAF6D0 VA: 0x180FB0CD0
	|-Array.IndexOf<float>
	|
	|-RVA: 0xFB12F0 Offset: 0xFAFCF0 VA: 0x180FB12F0
	|-Array.IndexOf<StylePropertyName>
	|
	|-RVA: 0xFB1480 Offset: 0xFAFE80 VA: 0x180FB1480
	|-Array.IndexOf<StylePropertyValue>
	|
	|-RVA: 0xFB1610 Offset: 0xFB0010 VA: 0x180FB1610
	|-Array.IndexOf<StyleSelectorPart>
	|
	|-RVA: 0xFB17B0 Offset: 0xFB01B0 VA: 0x180FB17B0
	|-Array.IndexOf<StyleSyntaxToken>
	|
	|-RVA: 0xFB1AE0 Offset: 0xFB04E0 VA: 0x180FB1AE0
	|-Array.IndexOf<StyleValue>
	|
	|-RVA: 0xFB1950 Offset: 0xFB0350 VA: 0x180FB1950
	|-Array.IndexOf<StyleValueManaged>
	|
	|-RVA: 0xFB1C80 Offset: 0xFB0680 VA: 0x180FB1C80
	|-Array.IndexOf<StyleVariable>
	|
	|-RVA: 0xFB1E20 Offset: 0xFB0820 VA: 0x180FB1E20
	|-Array.IndexOf<Substring>
	|
	|-RVA: 0xFB22D0 Offset: 0xFB0CD0 VA: 0x180FB22D0
	|-Array.IndexOf<TimeSpan>
	|
	|-RVA: 0xFB2450 Offset: 0xFB0E50 VA: 0x180FB2450
	|-Array.IndexOf<TimeValue>
	|
	|-RVA: 0xFB2760 Offset: 0xFB1160 VA: 0x180FB2760
	|-Array.IndexOf<TreeViewItemWrapper>
	|
	|-RVA: 0xFB2C10 Offset: 0xFB1610 VA: 0x180FB2C10
	|-Array.IndexOf<UICharInfo>
	|
	|-RVA: 0xFB2DA0 Offset: 0xFB17A0 VA: 0x180FB2DA0
	|-Array.IndexOf<UILineInfo>
	|
	|-RVA: 0xFB2F30 Offset: 0xFB1930 VA: 0x180FB2F30
	|-Array.IndexOf<UIVertex>
	|
	|-RVA: 0xFB3110 Offset: 0xFB1B10 VA: 0x180FB3110
	|-Array.IndexOf<ushort>
	|
	|-RVA: 0xFB3400 Offset: 0xFB1E00 VA: 0x180FB3400
	|-Array.IndexOf<uint>
	|
	|-RVA: 0xFB3290 Offset: 0xFB1C90 VA: 0x180FB3290
	|-Array.IndexOf<UInt32Enum>
	|
	|-RVA: 0xFB3570 Offset: 0xFB1F70 VA: 0x180FB3570
	|-Array.IndexOf<ulong>
	|
	|-RVA: 0xFB36E0 Offset: 0xFB20E0 VA: 0x180FB36E0
	|-Array.IndexOf<UShort2>
	|
	|-RVA: 0xFB3850 Offset: 0xFB2250 VA: 0x180FB3850
	|-Array.IndexOf<UnloadedScene>
	|
	|-RVA: 0xFB39E0 Offset: 0xFB23E0 VA: 0x180FB39E0
	|-Array.IndexOf<UsageHint>
	|
	|-RVA: 0xFB3E90 Offset: 0xFB2890 VA: 0x180FB3E90
	|-Array.IndexOf<Vector2>
	|
	|-RVA: 0xFB4010 Offset: 0xFB2A10 VA: 0x180FB4010
	|-Array.IndexOf<Vector3>
	|
	|-RVA: 0xFB41A0 Offset: 0xFB2BA0 VA: 0x180FB41A0
	|-Array.IndexOf<Vector4>
	|
	|-RVA: 0xFB46D0 Offset: 0xFB30D0 VA: 0x180FB46D0
	|-Array.IndexOf<VoxelContour>
	|
	|-RVA: 0xFB4A20 Offset: 0xFB3420 VA: 0x180FB4A20
	|-Array.IndexOf<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xFB4DC0 Offset: 0xFB37C0 VA: 0x180FB4DC0
	|-Array.IndexOf<X509ChainStatus>
	|
	|-RVA: 0xFB4F50 Offset: 0xFB3950 VA: 0x180FB4F50
	|-Array.IndexOf<XRFeatureDescriptor>
	|
	|-RVA: 0xFB50F0 Offset: 0xFB3AF0 VA: 0x180FB50F0
	|-Array.IndexOf<XRView>
	|
	|-RVA: 0xFB5480 Offset: 0xFB3E80 VA: 0x180FB5480
	|-Array.IndexOf<ZipGenericExtraField>
	|
	|-RVA: 0xFABCF0 Offset: 0xFAA6F0 VA: 0x180FABCF0
	|-Array.IndexOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xFB09C0 Offset: 0xFAF3C0 VA: 0x180FB09C0
	|-Array.IndexOf<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|
	|-RVA: 0xFB2A80 Offset: 0xFB1480 VA: 0x180FB2A80
	|-Array.IndexOf<AdvancedSmooth.Turn>
	|
	|-RVA: 0xFB4870 Offset: 0xFB3270 VA: 0x180FB4870
	|-Array.IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0xFAC5A0 Offset: 0xFAAFA0 VA: 0x180FAC5A0
	|-Array.IndexOf<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xFAD420 Offset: 0xFABE20 VA: 0x180FAD420
	|-Array.IndexOf<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0xFAD740 Offset: 0xFAC140 VA: 0x180FAD740
	|-Array.IndexOf<BitmapAllocator32.Page>
	|
	|-RVA: 0xFAA1A0 Offset: 0xFA8BA0 VA: 0x180FAA1A0
	|-Array.IndexOf<CameraState.CustomBlendable>
	|
	|-RVA: 0xFAD8C0 Offset: 0xFAC2C0 VA: 0x180FAD8C0
	|-Array.IndexOf<CinemachineClearShot.Pair>
	|
	|-RVA: 0xFAB9D0 Offset: 0xFAA3D0 VA: 0x180FAB9D0
	|-Array.IndexOf<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0xFAA650 Offset: 0xFA9050 VA: 0x180FAA650
	|-Array.IndexOf<ClipperLib.DoublePoint>
	|
	|-RVA: 0xFAC0B0 Offset: 0xFAAAB0 VA: 0x180FAC0B0
	|-Array.IndexOf<ClipperLib.IntPoint>
	|
	|-RVA: 0xFADD90 Offset: 0xFAC790 VA: 0x180FADD90
	|-Array.IndexOf<ConfinerOven.PolygonSolution>
	|
	|-RVA: 0xFAA330 Offset: 0xFA8D30 VA: 0x180FAA330
	|-Array.IndexOf<DecalEntityIndexer.DecalEntityItem>
	|
	|-RVA: 0xFA9AB0 Offset: 0xFA84B0 VA: 0x180FA9AB0
	|-Array.IndexOf<DecalEntityManager.CombinedChunks>
	|
	|-RVA: 0xFAAB40 Offset: 0xFA9540 VA: 0x180FAAB40
	|-Array.IndexOf<EventDispatcher.EventRecord>
	|
	|-RVA: 0xFAACD0 Offset: 0xFA96D0 VA: 0x180FAACD0
	|-Array.IndexOf<FocusController.FocusedElement>
	|
	|-RVA: 0xFAAFF0 Offset: 0xFA99F0 VA: 0x180FAAFF0
	|-Array.IndexOf<FrameTimingsHUDDisplay.FrameTimingPoint>
	|
	|-RVA: 0xFADBF0 Offset: 0xFAC5F0 VA: 0x180FADBF0
	|-Array.IndexOf<Funnel.PathPart>
	|
	|-RVA: 0xFB4330 Offset: 0xFB2D30 VA: 0x180FB4330
	|-Array.IndexOf<GodRaysRenderPass.VisibleLightRemap>
	|
	|-RVA: 0xFAB340 Offset: 0xFA9D40 VA: 0x180FAB340
	|-Array.IndexOf<GraphUpdateProcessor.GUOSingle>
	|
	|-RVA: 0xFAB4E0 Offset: 0xFA9EE0 VA: 0x180FAB4E0
	|-Array.IndexOf<HID.HIDCollectionDescriptor>
	|
	|-RVA: 0xFAB680 Offset: 0xFAA080 VA: 0x180FAB680
	|-Array.IndexOf<HID.HIDElementDescriptor>
	|
	|-RVA: 0xFAB840 Offset: 0xFAA240 VA: 0x180FAB840
	|-Array.IndexOf<HIDParser.HIDReportData>
	|
	|-RVA: 0xFAE220 Offset: 0xFACC20 VA: 0x180FAE220
	|-Array.IndexOf<HeatmapManager.PropertyRegionReference>
	|
	|-RVA: 0xFA8C60 Offset: 0xFA7660 VA: 0x180FA8C60
	|-Array.IndexOf<InputActionMap.BindingOverrideJson>
	|
	|-RVA: 0xFA9F80 Offset: 0xFA8980 VA: 0x180FA9F80
	|-Array.IndexOf<InputControlLayout.ControlItem>
	|
	|-RVA: 0xFB25D0 Offset: 0xFB0FD0 VA: 0x180FB25D0
	|-Array.IndexOf<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xFAC3E0 Offset: 0xFAADE0 VA: 0x180FAC3E0
	|-Array.IndexOf<JsonParser.JsonValue>
	|
	|-RVA: 0xFACA80 Offset: 0xFAB480 VA: 0x180FACA80
	|-Array.IndexOf<LatencySimulator.Message>
	|
	|-RVA: 0xFB1160 Offset: 0xFAFB60 VA: 0x180FB1160
	|-Array.IndexOf<MultiColumnCollectionHeader.SortedColumnState>
	|
	|-RVA: 0xFB1FB0 Offset: 0xFB09B0 VA: 0x180FB1FB0
	|-Array.IndexOf<NativeMethods.TASKDIALOG_BUTTON>
	|
	|-RVA: 0xFAE550 Offset: 0xFACF50 VA: 0x180FAE550
	|-Array.IndexOf<NetworkAnimator.ReceivedServerData>
	|
	|-RVA: 0xFB2900 Offset: 0xFB1300 VA: 0x180FB2900
	|-Array.IndexOf<NetworkAnimator.TriggerUpdate>
	|
	|-RVA: 0xFAD5B0 Offset: 0xFABFB0 VA: 0x180FAD5B0
	|-Array.IndexOf<OutlineEffect.OutlineTargetGroup>
	|
	|-RVA: 0xFA92E0 Offset: 0xFA7CE0 VA: 0x180FA92E0
	|-Array.IndexOf<PlayingCard.CardData>
	|
	|-RVA: 0xFAED70 Offset: 0xFAD770 VA: 0x180FAED70
	|-Array.IndexOf<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xFA8FC0 Offset: 0xFA79C0 VA: 0x180FA8FC0
	|-Array.IndexOf<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xFB06B0 Offset: 0xFAF0B0 VA: 0x180FB06B0
	|-Array.IndexOf<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|
	|-RVA: 0xFB0040 Offset: 0xFAEA40 VA: 0x180FB0040
	|-Array.IndexOf<ProbeVolumeSceneData.SerializableBoundItem>
	|
	|-RVA: 0xFB01E0 Offset: 0xFAEBE0 VA: 0x180FB01E0
	|-Array.IndexOf<ProbeVolumeSceneData.SerializableHasPVItem>
	|
	|-RVA: 0xFB0370 Offset: 0xFAED70 VA: 0x180FB0370
	|-Array.IndexOf<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|
	|-RVA: 0xFB0520 Offset: 0xFAEF20 VA: 0x180FB0520
	|-Array.IndexOf<ProbeVolumeSceneData.SerializablePVProfile>
	|
	|-RVA: 0xFB0B60 Offset: 0xFAF560 VA: 0x180FB0B60
	|-Array.IndexOf<RegexCharClass.SingleRange>
	|
	|-RVA: 0xFAE880 Offset: 0xFAD280 VA: 0x180FAE880
	|-Array.IndexOf<RenderChain.RenderNodeData>
	|
	|-RVA: 0xFADA40 Offset: 0xFAC440 VA: 0x180FADA40
	|-Array.IndexOf<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0xFAF090 Offset: 0xFADA90 VA: 0x180FAF090
	|-Array.IndexOf<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0xFAC8E0 Offset: 0xFAB2E0 VA: 0x180FAC8E0
	|-Array.IndexOf<RetainedGizmos.MeshWithHash>
	|
	|-RVA: 0xFAF3C0 Offset: 0xFADDC0 VA: 0x180FAF3C0
	|-Array.IndexOf<RigidbodyPauser.Rigidbody2DData>
	|
	|-RVA: 0xFAF560 Offset: 0xFADF60 VA: 0x180FAF560
	|-Array.IndexOf<RigidbodyPauser.RigidbodyData>
	|
	|-RVA: 0xFACC20 Offset: 0xFAB620 VA: 0x180FACC20
	|-Array.IndexOf<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xFABB50 Offset: 0xFAA550 VA: 0x180FABB50
	|-Array.IndexOf<SVGDocument.HierarchyUpdate>
	|
	|-RVA: 0xFACF50 Offset: 0xFAB950 VA: 0x180FACF50
	|-Array.IndexOf<SVGDocument.NodeReferenceData>
	|
	|-RVA: 0xFAD0F0 Offset: 0xFABAF0 VA: 0x180FAD0F0
	|-Array.IndexOf<SVGDocument.NodeWithParent>
	|
	|-RVA: 0xFADF20 Offset: 0xFAC920 VA: 0x180FADF20
	|-Array.IndexOf<SVGDocument.PostponedClip>
	|
	|-RVA: 0xFAE0A0 Offset: 0xFACAA0 VA: 0x180FAE0A0
	|-Array.IndexOf<SVGDocument.PostponedStopData>
	|
	|-RVA: 0xFA9C60 Offset: 0xFA8660 VA: 0x180FA9C60
	|-Array.IndexOf<ServerSocket.ConnectionChange>
	|
	|-RVA: 0xFACDB0 Offset: 0xFAB7B0 VA: 0x180FACDB0
	|-Array.IndexOf<SewerMushroomLocation.MushroomLocationData>
	|
	|-RVA: 0xFAA7E0 Offset: 0xFA91E0 VA: 0x180FAA7E0
	|-Array.IndexOf<ShadowUtility.Edge>
	|
	|-RVA: 0xFA9770 Offset: 0xFA8170 VA: 0x180FA9770
	|-Array.IndexOf<StructySync.ChangeData>
	|
	|-RVA: 0xFA95F0 Offset: 0xFA7FF0 VA: 0x180FA95F0
	|-Array.IndexOf<SyncStopwatch.ChangeData>
	|
	|-RVA: 0xFA9460 Offset: 0xFA7E60 VA: 0x180FA9460
	|-Array.IndexOf<SyncTimer.ChangeData>
	|
	|-RVA: 0xFA9150 Offset: 0xFA7B50 VA: 0x180FA9150
	|-Array.IndexOf<TargetStateListener.Callback>
	|
	|-RVA: 0xFA8AC0 Offset: 0xFA74C0 VA: 0x180FA8AC0
	|-Array.IndexOf<TemplateAsset.AttributeOverride>
	|
	|-RVA: 0xFAAE60 Offset: 0xFA9860 VA: 0x180FAAE60
	|-Array.IndexOf<TextSettings.FontReferenceMap>
	|
	|-RVA: 0xFA8E10 Offset: 0xFA7810 VA: 0x180FA8E10
	|-Array.IndexOf<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xFAB190 Offset: 0xFA9B90 VA: 0x180FAB190
	|-Array.IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xFB2140 Offset: 0xFB0B40 VA: 0x180FB2140
	|-Array.IndexOf<TextureRegistry.TextureInfo>
	|
	|-RVA: 0xFAD280 Offset: 0xFABC80 VA: 0x180FAD280
	|-Array.IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0xFAE3B0 Offset: 0xFACDB0 VA: 0x180FAE3B0
	|-Array.IndexOf<TrackedDeviceRaycaster.RaycastHitData>
	|
	|-RVA: 0xFAA4C0 Offset: 0xFA8EC0 VA: 0x180FAA4C0
	|-Array.IndexOf<TransportManager.DisconnectingClient>
	|
	|-RVA: 0xFAA980 Offset: 0xFA9380 VA: 0x180FAA980
	|-Array.IndexOf<UIRStylePainter.Entry>
	|
	|-RVA: 0xFAEBD0 Offset: 0xFAD5D0 VA: 0x180FAEBD0
	|-Array.IndexOf<UIRStylePainter.RepeatRectUV>
	|
	|-RVA: 0xFA85B0 Offset: 0xFA6FB0 VA: 0x180FA85B0
	|-Array.IndexOf<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xFA8760 Offset: 0xFA7160 VA: 0x180FA8760
	|-Array.IndexOf<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xFB4C20 Offset: 0xFB3620 VA: 0x180FB4C20
	|-Array.IndexOf<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0xFA8920 Offset: 0xFA7320 VA: 0x180FA8920
	|-Array.IndexOf<VisualTreeAsset.AssetEntry>
	|
	|-RVA: 0xFB0E40 Offset: 0xFAF840 VA: 0x180FB0E40
	|-Array.IndexOf<VisualTreeAsset.SlotDefinition>
	|
	|-RVA: 0xFB0FD0 Offset: 0xFAF9D0 VA: 0x180FB0FD0
	|-Array.IndexOf<VisualTreeAsset.SlotUsageEntry>
	|
	|-RVA: 0xFB3B60 Offset: 0xFB2560 VA: 0x180FB3B60
	|-Array.IndexOf<VisualTreeAsset.UsingEntry>
	|
	|-RVA: 0xFB3D00 Offset: 0xFB2700 VA: 0x180FB3D00
	|-Array.IndexOf<VisualTreeAsset.UxmlObjectEntry>
	|
	|-RVA: 0xFB52F0 Offset: 0xFB3CF0 VA: 0x180FB52F0
	|-Array.IndexOf<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0xFB4520 Offset: 0xFB2F20 VA: 0x180FB4520
	|-Array.IndexOf<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xFA9DF0 Offset: 0xFA87F0 VA: 0x180FA9DF0
	|-Array.IndexOf<DebugUI.Foldout.ContextMenuItem>
	|
	|-RVA: 0xFAC740 Offset: 0xFAB140 VA: 0x180FAC740
	|-Array.IndexOf<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xFABF10 Offset: 0xFAA910 VA: 0x180FABF10
	|-Array.IndexOf<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0xFA9910 Offset: 0xFA8310 VA: 0x180FA9910
	|-Array.IndexOf<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xFAC240 Offset: 0xFAAC40 VA: 0x180FAC240
	|-Array.IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xFAE6E0 Offset: 0xFAD0E0 VA: 0x180FAE6E0
	|-Array.IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x1C7D210 Offset: 0x1C7BC10 VA: 0x181C7D210
	public static int LastIndexOf(Array array, object value) { }

	// RVA: 0x1C7D330 Offset: 0x1C7BD30 VA: 0x181C7D330
	public static int LastIndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x1C7D3B0 Offset: 0x1C7BDB0 VA: 0x181C7D3B0
	public static int LastIndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1ED0 Offset: 0xDF08D0 VA: 0x180DF1ED0
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0xDF0860 Offset: 0xDEF260 VA: 0x180DF0860
	|-Array.LastIndexOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF0ED0 Offset: 0xDEF8D0 VA: 0x180DF0ED0
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0xDF09A0 Offset: 0xDEF3A0 VA: 0x180DF09A0
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0xDF14E0 Offset: 0xDEFEE0 VA: 0x180DF14E0
	|-Array.LastIndexOf<Matrix4x4>
	|
	|-RVA: 0xDF1BE0 Offset: 0xDF05E0 VA: 0x180DF1BE0
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0xDF1810 Offset: 0xDF0210 VA: 0x180DF1810
	|-Array.LastIndexOf<Rect>
	|
	|-RVA: 0xDF24F0 Offset: 0xDF0EF0 VA: 0x180DF24F0
	|-Array.LastIndexOf<TextureId>
	|
	|-RVA: 0xDF27E0 Offset: 0xDF11E0 VA: 0x180DF27E0
	|-Array.LastIndexOf<Vector2>
	|
	|-RVA: 0xDF0340 Offset: 0xDEED40 VA: 0x180DF0340
	|-Array.LastIndexOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDF11C0 Offset: 0xDEFBC0 VA: 0x180DF11C0
	|-Array.LastIndexOf<BaseStyleMatcher.MatchContext>
	|
	|-RVA: 0xDF0030 Offset: 0xDEEA30 VA: 0x180DF0030
	|-Array.LastIndexOf<EventDispatcher.DispatchContext>
	|
	|-RVA: 0xDEFD00 Offset: 0xDEE700 VA: 0x180DEFD00
	|-Array.LastIndexOf<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xDF21E0 Offset: 0xDF0BE0 VA: 0x180DF21E0
	|-Array.LastIndexOf<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0xDF1B20 Offset: 0xDF0520 VA: 0x180DF1B20
	|-Array.LastIndexOf<StyleVariableResolver.ResolveContext>
	|
	|-RVA: 0xDEF9F0 Offset: 0xDEE3F0 VA: 0x180DEF9F0
	|-Array.LastIndexOf<BindingRestrictions.TestBuilder.AndNode>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF0C90 Offset: 0xDEF690 VA: 0x180DF0C90
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0xDF0A50 Offset: 0xDEF450 VA: 0x180DF0A50
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0xDF1270 Offset: 0xDEFC70 VA: 0x180DF1270
	|-Array.LastIndexOf<Matrix4x4>
	|
	|-RVA: 0xDF1C90 Offset: 0xDF0690 VA: 0x180DF1C90
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0xDF15C0 Offset: 0xDEFFC0 VA: 0x180DF15C0
	|-Array.LastIndexOf<Rect>
	|
	|-RVA: 0xDF22B0 Offset: 0xDF0CB0 VA: 0x180DF22B0
	|-Array.LastIndexOf<TextureId>
	|
	|-RVA: 0xDF25A0 Offset: 0xDF0FA0 VA: 0x180DF25A0
	|-Array.LastIndexOf<Vector2>
	|
	|-RVA: 0xDF0580 Offset: 0xDEEF80 VA: 0x180DF0580
	|-Array.LastIndexOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDF0F80 Offset: 0xDEF980 VA: 0x180DF0F80
	|-Array.LastIndexOf<BaseStyleMatcher.MatchContext>
	|
	|-RVA: 0xDF00F0 Offset: 0xDEEAF0 VA: 0x180DF00F0
	|-Array.LastIndexOf<EventDispatcher.DispatchContext>
	|
	|-RVA: 0xDEFDD0 Offset: 0xDEE7D0 VA: 0x180DEFDD0
	|-Array.LastIndexOf<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xDF1F70 Offset: 0xDF0970 VA: 0x180DF1F70
	|-Array.LastIndexOf<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0xDF18D0 Offset: 0xDF02D0 VA: 0x180DF18D0
	|-Array.LastIndexOf<StyleVariableResolver.ResolveContext>
	|
	|-RVA: 0xDEFAB0 Offset: 0xDEE4B0 VA: 0x180DEFAB0
	|-Array.LastIndexOf<BindingRestrictions.TestBuilder.AndNode>
	*/

	// RVA: 0x1C7D750 Offset: 0x1C7C150 VA: 0x181C7D750
	public static void Reverse(Array array) { }

	// RVA: 0x1C7D820 Offset: 0x1C7C220 VA: 0x181C7D820
	public static void Reverse(Array array, int index, int length) { }

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF3270 Offset: 0xDF1C70 VA: 0x180DF3270
	|-Array.Reverse<byte>
	|
	|-RVA: 0xDF4B40 Offset: 0xDF3540 VA: 0x180DF4B40
	|-Array.Reverse<int>
	|
	|-RVA: 0xDF6240 Offset: 0xDF4C40 VA: 0x180DF6240
	|-Array.Reverse<Vector3>
	|
	|-RVA: 0xDF46A0 Offset: 0xDF30A0 VA: 0x180DF46A0
	|-Array.Reverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2B30 Offset: 0xDF1530 VA: 0x180DF2B30
	|-Array.Reverse<ArraySegment<byte>>
	|-Array.Reverse<KeyValuePair<object, bool>>
	|-Array.Reverse<KeyValuePair<object, char>>
	|-Array.Reverse<KeyValuePair<object, object>>
	|-Array.Reverse<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.Reverse<StructMultiKey<object, object>>
	|-Array.Reverse<SubArray<int>>
	|-Array.Reverse<ValueTuple<object, object>>
	|-Array.Reverse<BezierContour>
	|-Array.Reverse<Connection>
	|-Array.Reverse<CoordinateFootprintTilePair>
	|-Array.Reverse<CoordinateStorageFootprintTilePair>
	|-Array.Reverse<CoordinateStorageTilePair>
	|-Array.Reverse<CoordinateTilePair>
	|-Array.Reverse<DualPrefab>
	|-Array.Reverse<Entry>
	|-Array.Reverse<InternedString>
	|-Array.Reverse<InterpretedFrameInfo>
	|-Array.Reverse<LigatureSubstitutionRecord>
	|-Array.Reverse<LigatureSubstitutionRecord>
	|-Array.Reverse<RangePositionInfo>
	|-Array.Reverse<RuleMatcher>
	|-Array.Reverse<StylePropertyValue>
	|-Array.Reverse<Substring>
	|-Array.Reverse<UnloadedScene>
	|-Array.Reverse<CameraState.CustomBlendable>
	|-Array.Reverse<ConfinerOven.PolygonSolution>
	|-Array.Reverse<FocusController.FocusedElement>
	|-Array.Reverse<HeatmapManager.PropertyRegionReference>
	|-Array.Reverse<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.Reverse<OutlineEffect.OutlineTargetGroup>
	|-Array.Reverse<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.Reverse<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.Reverse<SVGDocument.NodeWithParent>
	|-Array.Reverse<TargetStateListener.Callback>
	|-Array.Reverse<TextSettings.FontReferenceMap>
	|-Array.Reverse<TextureRegistry.TextureInfo>
	|-Array.Reverse<VisualTreeAsset.SlotDefinition>
	|-Array.Reverse<VisualTreeAsset.SlotUsageEntry>
	|-Array.Reverse<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.Reverse<DebugUI.Foldout.ContextMenuItem>
	|
	|-RVA: 0xDF2CB0 Offset: 0xDF16B0 VA: 0x180DF2CB0
	|-Array.Reverse<SyncList.CachedOnChange<int>>
	|-Array.Reverse<NativeArray<ConvertMeshJobData>>
	|-Array.Reverse<NativeArray<CopyClosingMeshJobData>>
	|-Array.Reverse<NativeArray<NudgeJobData>>
	|-Array.Reverse<NativeSlice<ConvertMeshJobData>>
	|-Array.Reverse<NativeSlice<CopyClosingMeshJobData>>
	|-Array.Reverse<NativeSlice<NudgeJobData>>
	|-Array.Reverse<Nullable<DateTime>>
	|-Array.Reverse<AsyncGPUReadbackRequest>
	|-Array.Reverse<Color>
	|-Array.Reverse<DateTimeOffset>
	|-Array.Reverse<Decimal>
	|-Array.Reverse<GlyphRect>
	|-Array.Reverse<Guid>
	|-Array.Reverse<IntPoint>
	|-Array.Reverse<IntRect>
	|-Array.Reverse<Playable>
	|-Array.Reverse<Quaternion>
	|-Array.Reverse<RectInt>
	|-Array.Reverse<Resolution>
	|-Array.Reverse<SamplePointUData>
	|-Array.Reverse<UILineInfo>
	|-Array.Reverse<Vector4>
	|-Array.Reverse<ClipperLib.IntPoint>
	|-Array.Reverse<RigidbodyPrediction.MoveData>
	|-Array.Reverse<ServerSocket.ConnectionChange>
	|
	|-RVA: 0xDF3520 Offset: 0xDF1F20 VA: 0x180DF3520
	|-Array.Reverse<SyncList.ChangeData<int>>
	|-Array.Reverse<ValueTuple<int, Vector2Int>>
	|-Array.Reverse<DuplicateSamplePoint>
	|-Array.Reverse<Int3>
	|-Array.Reverse<IntRegion>
	|-Array.Reverse<ManipulatorActivationFilter>
	|-Array.Reverse<UICharInfo>
	|-Array.Reverse<Vector3>
	|-Array.Reverse<DecalEntityIndexer.DecalEntityItem>
	|-Array.Reverse<HIDParser.HIDReportData>
	|-Array.Reverse<ProbeBrickPool.BrickChunkAlloc>
	|-Array.Reverse<SyncTimer.ChangeData>
	|
	|-RVA: 0xDF3BB0 Offset: 0xDF25B0 VA: 0x180DF3BB0
	|-Array.Reverse<IntervalTree.Entry<object>>
	|-Array.Reverse<KeyValuePair<Rect, object>>
	|-Array.Reverse<ComputedTransitionProperty>
	|-Array.Reverse<ContourVertex>
	|
	|-RVA: 0xDF4520 Offset: 0xDF2F20 VA: 0x180DF4520
	|-Array.Reverse<KeyValuePair<int, object>>
	|-Array.Reverse<KeyValuePair<PropertyName, object>>
	|-Array.Reverse<ValueTuple<int, object>>
	|-Array.Reverse<EventSummary>
	|-Array.Reverse<MultipleSubstitutionRecord>
	|-Array.Reverse<MultipleSubstitutionRecord>
	|-Array.Reverse<StylePropertyName>
	|-Array.Reverse<StyleValueManaged>
	|-Array.Reverse<X509ChainStatus>
	|-Array.Reverse<ZipGenericExtraField>
	|-Array.Reverse<AdvancedSmooth.Turn>
	|-Array.Reverse<BeforeRenderHelper.OrderBlock>
	|-Array.Reverse<InputTransformSpots.TransformSpot>
	|-Array.Reverse<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.Reverse<TransportManager.DisconnectingClient>
	|-Array.Reverse<VisualTreeAsset.UxmlObjectEntry>
	|
	|-RVA: 0xDF4F80 Offset: 0xDF3980 VA: 0x180DF4F80
	|-Array.Reverse<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.Reverse<RaycastResult>
	|
	|-RVA: 0xDF2E20 Offset: 0xDF1820 VA: 0x180DF2E20
	|-Array.Reverse<Nullable<Decimal>>
	|-Array.Reverse<TempAllocator.Page<ushort>>
	|-Array.Reverse<TempAllocator.Page<Vertex>>
	|-Array.Reverse<BezierPathSegment>
	|-Array.Reverse<Bounds>
	|-Array.Reverse<FrameTimeSample>
	|-Array.Reverse<IntervalTreeNode>
	|-Array.Reverse<MarkToBaseAdjustmentRecord>
	|-Array.Reverse<MarkToBaseAdjustmentRecord>
	|-Array.Reverse<MarkToMarkAdjustmentRecord>
	|-Array.Reverse<MarkToMarkAdjustmentRecord>
	|-Array.Reverse<RendererList>
	|-Array.Reverse<StyleValue>
	|-Array.Reverse<HID.HIDCollectionDescriptor>
	|
	|-RVA: 0xDF29D0 Offset: 0xDF13D0 VA: 0x180DF29D0
	|-Array.Reverse<ValueTuple<int, int>>
	|-Array.Reverse<ValueTuple<int, Scene>>
	|-Array.Reverse<AnimatorClipInfo>
	|-Array.Reverse<DateTime>
	|-Array.Reverse<InputEventPtr>
	|-Array.Reverse<long>
	|-Array.Reverse<RendererListHandle>
	|-Array.Reverse<ResourceHandle>
	|-Array.Reverse<SamplePointsPatch>
	|-Array.Reverse<TimeSpan>
	|-Array.Reverse<TimeValue>
	|-Array.Reverse<ulong>
	|-Array.Reverse<BitmapAllocator32.Page>
	|-Array.Reverse<CinemachineClearShot.Pair>
	|-Array.Reverse<CinemachineStateDrivenCamera.HashPair>
	|-Array.Reverse<PlayingCard.CardData>
	|-Array.Reverse<SyncStopwatch.ChangeData>
	|
	|-RVA: 0xDF3EE0 Offset: 0xDF28E0 VA: 0x180DF3EE0
	|-Array.Reverse<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.Reverse<CoordinateProceduralTilePair>
	|-Array.Reverse<NameAndParameters>
	|-Array.Reverse<NamedValue>
	|-Array.Reverse<SelectorMatchRecord>
	|-Array.Reverse<StyleSelectorPart>
	|-Array.Reverse<StyleVariable>
	|-Array.Reverse<XRFeatureDescriptor>
	|-Array.Reverse<AvatarSettings.LayerSetting>
	|-Array.Reverse<SVGDocument.HierarchyUpdate>
	|-Array.Reverse<TemplateAsset.AttributeOverride>
	|-Array.Reverse<UnitySynchronizationContext.WorkRequest>
	|-Array.Reverse<VisualTreeAsset.UsingEntry>
	|-Array.Reverse<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xDF2FA0 Offset: 0xDF19A0 VA: 0x180DF2FA0
	|-Array.Reverse<BezierSegment>
	|-Array.Reverse<NavMeshBuildMarkup>
	|-Array.Reverse<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.Reverse<UIRStylePainter.RepeatRectUV>
	|
	|-RVA: 0xDF3110 Offset: 0xDF1B10 VA: 0x180DF3110
	|-Array.Reverse<bool>
	|-Array.Reverse<byte>
	|-Array.Reverse<sbyte>
	|
	|-RVA: 0xDF3380 Offset: 0xDF1D80 VA: 0x180DF3380
	|-Array.Reverse<CGSpot>
	|-Array.Reverse<GlyphPairAdjustmentRecord>
	|-Array.Reverse<RaycastHit>
	|
	|-RVA: 0xDF36A0 Offset: 0xDF20A0 VA: 0x180DF36A0
	|-Array.Reverse<char>
	|-Array.Reverse<short>
	|-Array.Reverse<ushort>
	|-Array.Reverse<NetworkAnimator.TriggerUpdate>
	|
	|-RVA: 0xDF3800 Offset: 0xDF2200 VA: 0x180DF3800
	|-Array.Reverse<Color32>
	|-Array.Reverse<EasingFunction>
	|-Array.Reverse<int>
	|-Array.Reverse<Int32Enum>
	|-Array.Reverse<Scene>
	|-Array.Reverse<ShaderTagId>
	|-Array.Reverse<uint>
	|-Array.Reverse<UInt32Enum>
	|-Array.Reverse<UShort2>
	|-Array.Reverse<RegexCharClass.SingleRange>
	|
	|-RVA: 0xDF3960 Offset: 0xDF2360 VA: 0x180DF3960
	|-Array.Reverse<CombineInstance>
	|
	|-RVA: 0xDF3D50 Offset: 0xDF2750 VA: 0x180DF3D50
	|-Array.Reverse<ControlPointOption>
	|-Array.Reverse<RaycastHit2D>
	|-Array.Reverse<Funnel.PathPart>
	|-Array.Reverse<SewerMushroomLocation.MushroomLocationData>
	|-Array.Reverse<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xDF4080 Offset: 0xDF2A80 VA: 0x180DF4080
	|-Array.Reverse<DisplayInfo>
	|
	|-RVA: 0xDF43C0 Offset: 0xDF2DC0 VA: 0x180DF43C0
	|-Array.Reverse<double>
	|
	|-RVA: 0xDF4250 Offset: 0xDF2C50 VA: 0x180DF4250
	|-Array.Reverse<DoublePoint>
	|-Array.Reverse<DoublePoint>
	|-Array.Reverse<ClipperLib.DoublePoint>
	|
	|-RVA: 0xDF4730 Offset: 0xDF3130 VA: 0x180DF4730
	|-Array.Reverse<InputBinding>
	|
	|-RVA: 0xDF4960 Offset: 0xDF3360 VA: 0x180DF4960
	|-Array.Reverse<InputDeviceDescription>
	|-Array.Reverse<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.Reverse<RigidbodyPauser.RigidbodyData>
	|-Array.Reverse<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xDF4C50 Offset: 0xDF3650 VA: 0x180DF4C50
	|-Array.Reverse<IntPoint>
	|
	|-RVA: 0xDF4DE0 Offset: 0xDF37E0 VA: 0x180DF4DE0
	|-Array.Reverse<JsonPosition>
	|-Array.Reverse<StyleSyntaxToken>
	|-Array.Reverse<TreeViewItemWrapper>
	|-Array.Reverse<LatencySimulator.Message>
	|-Array.Reverse<RetainedGizmos.MeshWithHash>
	|-Array.Reverse<StructySync.ChangeData>
	|-Array.Reverse<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0xDF5180 Offset: 0xDF3B80 VA: 0x180DF5180
	|-Array.Reverse<Label>
	|-Array.Reverse<PlayerLoopSystem>
	|-Array.Reverse<PlayerLoopSystemInternal>
	|-Array.Reverse<DecalEntityManager.CombinedChunks>
	|-Array.Reverse<InputActionMap.BindingOverrideJson>
	|-Array.Reverse<RenderGraphDebugData.PassDebugData>
	|-Array.Reverse<RenderGraphDebugData.ResourceDebugData>
	|-Array.Reverse<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xDF5340 Offset: 0xDF3D40 VA: 0x180DF5340
	|-Array.Reverse<Matrix4x4>
	|
	|-RVA: 0xDF54E0 Offset: 0xDF3EE0 VA: 0x180DF54E0
	|-Array.Reverse<NavMeshBuildSource>
	|
	|-RVA: 0xDF5A30 Offset: 0xDF4430 VA: 0x180DF5A30
	|-Array.Reverse<object>
	|
	|-RVA: 0xDF5700 Offset: 0xDF4100 VA: 0x180DF5700
	|-Array.Reverse<PlayableBinding>
	|-Array.Reverse<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.Reverse<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.Reverse<SVGDocument.NodeReferenceData>
	|-Array.Reverse<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.Reverse<VisualTreeAsset.AssetEntry>
	|
	|-RVA: 0xDF58A0 Offset: 0xDF42A0 VA: 0x180DF58A0
	|-Array.Reverse<RenderTargetIdentifier>
	|-Array.Reverse<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0xDF5BA0 Offset: 0xDF45A0 VA: 0x180DF5BA0
	|-Array.Reverse<float>
	|
	|-RVA: 0xDF5D00 Offset: 0xDF4700 VA: 0x180DF5D00
	|-Array.Reverse<UIVertex>
	|
	|-RVA: 0xDF5F60 Offset: 0xDF4960 VA: 0x180DF5F60
	|-Array.Reverse<UsageHint>
	|-Array.Reverse<SVGDocument.PostponedClip>
	|-Array.Reverse<SVGDocument.PostponedStopData>
	|
	|-RVA: 0xDF60D0 Offset: 0xDF4AD0 VA: 0x180DF60D0
	|-Array.Reverse<Vector2>
	|
	|-RVA: 0xDF6370 Offset: 0xDF4D70 VA: 0x180DF6370
	|-Array.Reverse<VoxelContour>
	|-Array.Reverse<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xDF6510 Offset: 0xDF4F10 VA: 0x180DF6510
	|-Array.Reverse<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xDF6850 Offset: 0xDF5250 VA: 0x180DF6850
	|-Array.Reverse<XRView>
	|
	|-RVA: 0xE1C0A0 Offset: 0xE1AAA0 VA: 0x180E1C0A0
	|-Array.Reverse<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE1B940 Offset: 0xE1A340 VA: 0x180E1B940
	|-Array.Reverse<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.Reverse<ShadowUtility.Edge>
	|-Array.Reverse<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xE1CD10 Offset: 0xE1B710 VA: 0x180E1CD10
	|-Array.Reverse<GodRaysRenderPass.VisibleLightRemap>
	|
	|-RVA: 0xE1BEB0 Offset: 0xE1A8B0 VA: 0x180E1BEB0
	|-Array.Reverse<HID.HIDElementDescriptor>
	|
	|-RVA: 0xE1B5A0 Offset: 0xE19FA0 VA: 0x180E1B5A0
	|-Array.Reverse<InputControlLayout.ControlItem>
	|
	|-RVA: 0xE1C590 Offset: 0xE1AF90 VA: 0x180E1C590
	|-Array.Reverse<JsonParser.JsonValue>
	|
	|-RVA: 0xE1C9C0 Offset: 0xE1B3C0 VA: 0x180E1C9C0
	|-Array.Reverse<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xE1C7A0 Offset: 0xE1B1A0 VA: 0x180E1C7A0
	|-Array.Reverse<RenderChain.RenderNodeData>
	|
	|-RVA: 0xE1CB40 Offset: 0xE1B540 VA: 0x180E1CB40
	|-Array.Reverse<RigidbodyPauser.Rigidbody2DData>
	|
	|-RVA: 0xE1BCE0 Offset: 0xE1A6E0 VA: 0x180E1BCE0
	|-Array.Reverse<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xE1BAD0 Offset: 0xE1A4D0 VA: 0x180E1BAD0
	|-Array.Reverse<UIRStylePainter.Entry>
	|
	|-RVA: 0xE1B1C0 Offset: 0xE19BC0 VA: 0x180E1B1C0
	|-Array.Reverse<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xE1B390 Offset: 0xE19D90 VA: 0x180E1B390
	|-Array.Reverse<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xE1C3F0 Offset: 0xE1ADF0 VA: 0x180E1C3F0
	|-Array.Reverse<InstructionList.DebugView.InstructionView>
	*/

	// RVA: 0x1C7DDD0 Offset: 0x1C7C7D0 VA: 0x181C7DDD0
	public void SetValue(object value, long index) { }

	// RVA: 0x1C7E240 Offset: 0x1C7CC40 VA: 0x181C7E240
	public void SetValue(object value, long index1, long index2) { }

	// RVA: 0x1C7DE70 Offset: 0x1C7C870 VA: 0x181C7DE70
	public void SetValue(object value, long index1, long index2, long index3) { }

	// RVA: 0x1C7DB40 Offset: 0x1C7C540 VA: 0x181C7DB40
	public void SetValue(object value, long[] indices) { }

	// RVA: 0x1C7E960 Offset: 0x1C7D360 VA: 0x181C7E960
	public static void Sort(Array array) { }

	// RVA: 0x1C7E930 Offset: 0x1C7D330 VA: 0x181C7E930
	public static void Sort(Array array, int index, int length) { }

	// RVA: 0x1C7EA40 Offset: 0x1C7D440 VA: 0x181C7EA40
	public static void Sort(Array array, IComparer comparer) { }

	// RVA: 0x1C7EB30 Offset: 0x1C7D530 VA: 0x181C7EB30
	public static void Sort(Array array, int index, int length, IComparer comparer) { }

	// RVA: 0x1C7EB60 Offset: 0x1C7D560 VA: 0x181C7EB60
	public static void Sort(Array keys, Array items) { }

	// RVA: 0x1C7E840 Offset: 0x1C7D240 VA: 0x181C7E840
	public static void Sort(Array keys, Array items, IComparer comparer) { }

	// RVA: 0x1C7E820 Offset: 0x1C7D220 VA: 0x181C7E820
	public static void Sort(Array keys, Array items, int index, int length) { }

	// RVA: 0x1C7E4E0 Offset: 0x1C7CEE0 VA: 0x181C7E4E0
	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE1DAB0 Offset: 0xE1C4B0 VA: 0x180E1DAB0
	|-Array.Sort<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE206C0 Offset: 0xE1F0C0 VA: 0x180E206C0
	|-Array.Sort<object>
	|
	|-RVA: 0xE1D9B0 Offset: 0xE1C3B0 VA: 0x180E1D9B0
	|-Array.Sort<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE1DD00 Offset: 0xE1C700 VA: 0x180E1DD00
	|-Array.Sort<int>
	|
	|-RVA: 0xE20720 Offset: 0xE1F120 VA: 0x180E20720
	|-Array.Sort<object>
	|
	|-RVA: 0xE1DA10 Offset: 0xE1C410 VA: 0x180E1DA10
	|-Array.Sort<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE1CF90 Offset: 0xE1B990 VA: 0x180E1CF90
	|-Array.Sort<ArraySegment<byte>>
	|
	|-RVA: 0xE1D1C0 Offset: 0xE1BBC0 VA: 0x180E1D1C0
	|-Array.Sort<SyncList.CachedOnChange<int>>
	|
	|-RVA: 0xE1D3F0 Offset: 0xE1BDF0 VA: 0x180E1D3F0
	|-Array.Sort<SyncList.ChangeData<int>>
	|
	|-RVA: 0xE1D620 Offset: 0xE1C020 VA: 0x180E1D620
	|-Array.Sort<IntervalTree.Entry<object>>
	|
	|-RVA: 0xE1E430 Offset: 0xE1CE30 VA: 0x180E1E430
	|-Array.Sort<KeyValuePair<int, object>>
	|
	|-RVA: 0xE1E200 Offset: 0xE1CC00 VA: 0x180E1E200
	|-Array.Sort<KeyValuePair<object, bool>>
	|
	|-RVA: 0xE1E660 Offset: 0xE1D060 VA: 0x180E1E660
	|-Array.Sort<KeyValuePair<object, char>>
	|
	|-RVA: 0xE1EAC0 Offset: 0xE1D4C0 VA: 0x180E1EAC0
	|-Array.Sort<KeyValuePair<object, object>>
	|
	|-RVA: 0xE1E890 Offset: 0xE1D290 VA: 0x180E1E890
	|-Array.Sort<KeyValuePair<object, JsonParser.JsonValue>>
	|
	|-RVA: 0xE1DFD0 Offset: 0xE1C9D0 VA: 0x180E1DFD0
	|-Array.Sort<KeyValuePair<PropertyName, object>>
	|
	|-RVA: 0xE1DDA0 Offset: 0xE1C7A0 VA: 0x180E1DDA0
	|-Array.Sort<KeyValuePair<Rect, object>>
	|
	|-RVA: 0xE1F150 Offset: 0xE1DB50 VA: 0x180E1F150
	|-Array.Sort<NativeArray<ConvertMeshJobData>>
	|
	|-RVA: 0xE1ECF0 Offset: 0xE1D6F0 VA: 0x180E1ECF0
	|-Array.Sort<NativeArray<CopyClosingMeshJobData>>
	|
	|-RVA: 0xE1EF20 Offset: 0xE1D920 VA: 0x180E1EF20
	|-Array.Sort<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xE1F380 Offset: 0xE1DD80 VA: 0x180E1F380
	|-Array.Sort<NativeSlice<ConvertMeshJobData>>
	|
	|-RVA: 0xE1F7E0 Offset: 0xE1E1E0 VA: 0x180E1F7E0
	|-Array.Sort<NativeSlice<CopyClosingMeshJobData>>
	|
	|-RVA: 0xE1F5B0 Offset: 0xE1DFB0 VA: 0x180E1F5B0
	|-Array.Sort<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xE1FC40 Offset: 0xE1E640 VA: 0x180E1FC40
	|-Array.Sort<Nullable<DateTime>>
	|
	|-RVA: 0xE1FA10 Offset: 0xE1E410 VA: 0x180E1FA10
	|-Array.Sort<Nullable<Decimal>>
	|
	|-RVA: 0xE1FE70 Offset: 0xE1E870 VA: 0x180E1FE70
	|-Array.Sort<TempAllocator.Page<ushort>>
	|
	|-RVA: 0xE200A0 Offset: 0xE1EAA0 VA: 0x180E200A0
	|-Array.Sort<TempAllocator.Page<Vertex>>
	|
	|-RVA: 0xE203E0 Offset: 0xE1EDE0 VA: 0x180E203E0
	|-Array.Sort<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0xE208D0 Offset: 0xE1F2D0 VA: 0x180E208D0
	|-Array.Sort<StructMultiKey<object, object>>
	|
	|-RVA: 0xE3FA00 Offset: 0xE3E400 VA: 0x180E3FA00
	|-Array.Sort<SubArray<int>>
	|
	|-RVA: 0xE43100 Offset: 0xE41B00 VA: 0x180E43100
	|-Array.Sort<ValueTuple<int, int>>
	|
	|-RVA: 0xE43790 Offset: 0xE42190 VA: 0x180E43790
	|-Array.Sort<ValueTuple<int, object>>
	|
	|-RVA: 0xE43330 Offset: 0xE41D30 VA: 0x180E43330
	|-Array.Sort<ValueTuple<int, Scene>>
	|
	|-RVA: 0xE42ED0 Offset: 0xE418D0 VA: 0x180E42ED0
	|-Array.Sort<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xE42CA0 Offset: 0xE416A0 VA: 0x180E42CA0
	|-Array.Sort<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xE43560 Offset: 0xE41F60 VA: 0x180E43560
	|-Array.Sort<ValueTuple<object, object>>
	|
	|-RVA: 0xE277A0 Offset: 0xE261A0 VA: 0x180E277A0
	|-Array.Sort<AnimatorClipInfo>
	|
	|-RVA: 0xE27C00 Offset: 0xE26600 VA: 0x180E27C00
	|-Array.Sort<AsyncGPUReadbackRequest>
	|
	|-RVA: 0xE28060 Offset: 0xE26A60 VA: 0x180E28060
	|-Array.Sort<BezierContour>
	|
	|-RVA: 0xE28290 Offset: 0xE26C90 VA: 0x180E28290
	|-Array.Sort<BezierPathSegment>
	|
	|-RVA: 0xE284C0 Offset: 0xE26EC0 VA: 0x180E284C0
	|-Array.Sort<BezierSegment>
	|
	|-RVA: 0xE28B50 Offset: 0xE27550 VA: 0x180E28B50
	|-Array.Sort<bool>
	|
	|-RVA: 0xE28D80 Offset: 0xE27780 VA: 0x180E28D80
	|-Array.Sort<Bounds>
	|
	|-RVA: 0xE291E0 Offset: 0xE27BE0 VA: 0x180E291E0
	|-Array.Sort<byte>
	|
	|-RVA: 0xE29410 Offset: 0xE27E10 VA: 0x180E29410
	|-Array.Sort<CGSpot>
	|
	|-RVA: 0xE2A130 Offset: 0xE28B30 VA: 0x180E2A130
	|-Array.Sort<char>
	|
	|-RVA: 0xE2A590 Offset: 0xE28F90 VA: 0x180E2A590
	|-Array.Sort<Color>
	|
	|-RVA: 0xE2A360 Offset: 0xE28D60 VA: 0x180E2A360
	|-Array.Sort<Color32>
	|
	|-RVA: 0xE2A9F0 Offset: 0xE293F0 VA: 0x180E2A9F0
	|-Array.Sort<CombineInstance>
	|
	|-RVA: 0xE2AE50 Offset: 0xE29850 VA: 0x180E2AE50
	|-Array.Sort<ComputedTransitionProperty>
	|
	|-RVA: 0xE2B2B0 Offset: 0xE29CB0 VA: 0x180E2B2B0
	|-Array.Sort<Connection>
	|
	|-RVA: 0xE2B710 Offset: 0xE2A110 VA: 0x180E2B710
	|-Array.Sort<ContourVertex>
	|
	|-RVA: 0xE2BB70 Offset: 0xE2A570 VA: 0x180E2BB70
	|-Array.Sort<ControlPointOption>
	|
	|-RVA: 0xE2BDA0 Offset: 0xE2A7A0 VA: 0x180E2BDA0
	|-Array.Sort<CoordinateFootprintTilePair>
	|
	|-RVA: 0xE2BFD0 Offset: 0xE2A9D0 VA: 0x180E2BFD0
	|-Array.Sort<CoordinateProceduralTilePair>
	|
	|-RVA: 0xE2C200 Offset: 0xE2AC00 VA: 0x180E2C200
	|-Array.Sort<CoordinateStorageFootprintTilePair>
	|
	|-RVA: 0xE2C430 Offset: 0xE2AE30 VA: 0x180E2C430
	|-Array.Sort<CoordinateStorageTilePair>
	|
	|-RVA: 0xE2C660 Offset: 0xE2B060 VA: 0x180E2C660
	|-Array.Sort<CoordinateTilePair>
	|
	|-RVA: 0xE2CCF0 Offset: 0xE2B6F0 VA: 0x180E2CCF0
	|-Array.Sort<DateTime>
	|
	|-RVA: 0xE2CAC0 Offset: 0xE2B4C0 VA: 0x180E2CAC0
	|-Array.Sort<DateTimeOffset>
	|
	|-RVA: 0xE2D150 Offset: 0xE2BB50 VA: 0x180E2D150
	|-Array.Sort<Decimal>
	|
	|-RVA: 0xE2D5B0 Offset: 0xE2BFB0 VA: 0x180E2D5B0
	|-Array.Sort<DisplayInfo>
	|
	|-RVA: 0xE2DE70 Offset: 0xE2C870 VA: 0x180E2DE70
	|-Array.Sort<double>
	|
	|-RVA: 0xE2DC40 Offset: 0xE2C640 VA: 0x180E2DC40
	|-Array.Sort<DoublePoint>
	|
	|-RVA: 0xE2D7E0 Offset: 0xE2C1E0 VA: 0x180E2D7E0
	|-Array.Sort<DoublePoint>
	|
	|-RVA: 0xE2E0A0 Offset: 0xE2CAA0 VA: 0x180E2E0A0
	|-Array.Sort<DualPrefab>
	|
	|-RVA: 0xE2E2D0 Offset: 0xE2CCD0 VA: 0x180E2E2D0
	|-Array.Sort<DuplicateSamplePoint>
	|
	|-RVA: 0xE2E500 Offset: 0xE2CF00 VA: 0x180E2E500
	|-Array.Sort<EasingFunction>
	|
	|-RVA: 0xE2EB90 Offset: 0xE2D590 VA: 0x180E2EB90
	|-Array.Sort<Entry>
	|
	|-RVA: 0xE2EDC0 Offset: 0xE2D7C0 VA: 0x180E2EDC0
	|-Array.Sort<EventSummary>
	|
	|-RVA: 0xE2F450 Offset: 0xE2DE50 VA: 0x180E2F450
	|-Array.Sort<FrameTimeSample>
	|
	|-RVA: 0xE2FAE0 Offset: 0xE2E4E0 VA: 0x180E2FAE0
	|-Array.Sort<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xE2FD10 Offset: 0xE2E710 VA: 0x180E2FD10
	|-Array.Sort<GlyphRect>
	|
	|-RVA: 0xE2FF40 Offset: 0xE2E940 VA: 0x180E2FF40
	|-Array.Sort<Guid>
	|
	|-RVA: 0xE310B0 Offset: 0xE2FAB0 VA: 0x180E310B0
	|-Array.Sort<InputBinding>
	|
	|-RVA: 0xE312E0 Offset: 0xE2FCE0 VA: 0x180E312E0
	|-Array.Sort<InputDeviceDescription>
	|
	|-RVA: 0xE31510 Offset: 0xE2FF10 VA: 0x180E31510
	|-Array.Sort<InputEventPtr>
	|
	|-RVA: 0xE31970 Offset: 0xE30370 VA: 0x180E31970
	|-Array.Sort<short>
	|
	|-RVA: 0xE32280 Offset: 0xE30C80 VA: 0x180E32280
	|-Array.Sort<Int3>
	|
	|-RVA: 0xE32050 Offset: 0xE30A50 VA: 0x180E32050
	|-Array.Sort<int>
	|
	|-RVA: 0xE31BA0 Offset: 0xE305A0 VA: 0x180E31BA0
	|-Array.Sort<Int32Enum>
	|
	|-RVA: 0xE324B0 Offset: 0xE30EB0 VA: 0x180E324B0
	|-Array.Sort<long>
	|
	|-RVA: 0xE32B40 Offset: 0xE31540 VA: 0x180E32B40
	|-Array.Sort<IntPoint>
	|
	|-RVA: 0xE326E0 Offset: 0xE310E0 VA: 0x180E326E0
	|-Array.Sort<IntPoint>
	|
	|-RVA: 0xE32D70 Offset: 0xE31770 VA: 0x180E32D70
	|-Array.Sort<IntRect>
	|
	|-RVA: 0xE32FA0 Offset: 0xE319A0 VA: 0x180E32FA0
	|-Array.Sort<IntRegion>
	|
	|-RVA: 0xE331D0 Offset: 0xE31BD0 VA: 0x180E331D0
	|-Array.Sort<InternedString>
	|
	|-RVA: 0xE33400 Offset: 0xE31E00 VA: 0x180E33400
	|-Array.Sort<InterpretedFrameInfo>
	|
	|-RVA: 0xE33630 Offset: 0xE32030 VA: 0x180E33630
	|-Array.Sort<IntervalTreeNode>
	|
	|-RVA: 0xE33A90 Offset: 0xE32490 VA: 0x180E33A90
	|-Array.Sort<JsonPosition>
	|
	|-RVA: 0xE33EF0 Offset: 0xE328F0 VA: 0x180E33EF0
	|-Array.Sort<Label>
	|
	|-RVA: 0xE34580 Offset: 0xE32F80 VA: 0x180E34580
	|-Array.Sort<LigatureSubstitutionRecord>
	|
	|-RVA: 0xE347B0 Offset: 0xE331B0 VA: 0x180E347B0
	|-Array.Sort<LigatureSubstitutionRecord>
	|
	|-RVA: 0xE349E0 Offset: 0xE333E0 VA: 0x180E349E0
	|-Array.Sort<ManipulatorActivationFilter>
	|
	|-RVA: 0xE34C10 Offset: 0xE33610 VA: 0x180E34C10
	|-Array.Sort<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE34E40 Offset: 0xE33840 VA: 0x180E34E40
	|-Array.Sort<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xE35070 Offset: 0xE33A70 VA: 0x180E35070
	|-Array.Sort<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE352A0 Offset: 0xE33CA0 VA: 0x180E352A0
	|-Array.Sort<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xE354D0 Offset: 0xE33ED0 VA: 0x180E354D0
	|-Array.Sort<Matrix4x4>
	|
	|-RVA: 0xE35FC0 Offset: 0xE349C0 VA: 0x180E35FC0
	|-Array.Sort<MultipleSubstitutionRecord>
	|
	|-RVA: 0xE35D90 Offset: 0xE34790 VA: 0x180E35D90
	|-Array.Sort<MultipleSubstitutionRecord>
	|
	|-RVA: 0xE36420 Offset: 0xE34E20 VA: 0x180E36420
	|-Array.Sort<NameAndParameters>
	|
	|-RVA: 0xE36650 Offset: 0xE35050 VA: 0x180E36650
	|-Array.Sort<NamedValue>
	|
	|-RVA: 0xE36880 Offset: 0xE35280 VA: 0x180E36880
	|-Array.Sort<NavMeshBuildMarkup>
	|
	|-RVA: 0xE36AB0 Offset: 0xE354B0 VA: 0x180E36AB0
	|-Array.Sort<NavMeshBuildSource>
	|
	|-RVA: 0xE3C050 Offset: 0xE3AA50 VA: 0x180E3C050
	|-Array.Sort<object>
	|
	|-RVA: 0xE382C0 Offset: 0xE36CC0 VA: 0x180E382C0
	|-Array.Sort<Playable>
	|
	|-RVA: 0xE38090 Offset: 0xE36A90 VA: 0x180E38090
	|-Array.Sort<PlayableBinding>
	|
	|-RVA: 0xE38720 Offset: 0xE37120 VA: 0x180E38720
	|-Array.Sort<PlayerLoopSystem>
	|
	|-RVA: 0xE384F0 Offset: 0xE36EF0 VA: 0x180E384F0
	|-Array.Sort<PlayerLoopSystemInternal>
	|
	|-RVA: 0xE39210 Offset: 0xE37C10 VA: 0x180E39210
	|-Array.Sort<Quaternion>
	|
	|-RVA: 0xE39440 Offset: 0xE37E40 VA: 0x180E39440
	|-Array.Sort<RangePositionInfo>
	|
	|-RVA: 0xE39AD0 Offset: 0xE384D0 VA: 0x180E39AD0
	|-Array.Sort<RaycastHit>
	|
	|-RVA: 0xE39670 Offset: 0xE38070 VA: 0x180E39670
	|-Array.Sort<RaycastHit2D>
	|
	|-RVA: 0xE39D00 Offset: 0xE38700 VA: 0x180E39D00
	|-Array.Sort<RaycastResult>
	|
	|-RVA: 0xE3A160 Offset: 0xE38B60 VA: 0x180E3A160
	|-Array.Sort<RectInt>
	|
	|-RVA: 0xE3A5C0 Offset: 0xE38FC0 VA: 0x180E3A5C0
	|-Array.Sort<RenderTargetIdentifier>
	|
	|-RVA: 0xE3AA20 Offset: 0xE39420 VA: 0x180E3AA20
	|-Array.Sort<RendererList>
	|
	|-RVA: 0xE3A7F0 Offset: 0xE391F0 VA: 0x180E3A7F0
	|-Array.Sort<RendererListHandle>
	|
	|-RVA: 0xE3B0B0 Offset: 0xE39AB0 VA: 0x180E3B0B0
	|-Array.Sort<Resolution>
	|
	|-RVA: 0xE3B510 Offset: 0xE39F10 VA: 0x180E3B510
	|-Array.Sort<ResourceHandle>
	|
	|-RVA: 0xE3BBA0 Offset: 0xE3A5A0 VA: 0x180E3BBA0
	|-Array.Sort<RuleMatcher>
	|
	|-RVA: 0xE3C280 Offset: 0xE3AC80 VA: 0x180E3C280
	|-Array.Sort<sbyte>
	|
	|-RVA: 0xE3C4B0 Offset: 0xE3AEB0 VA: 0x180E3C4B0
	|-Array.Sort<SamplePointUData>
	|
	|-RVA: 0xE3C6E0 Offset: 0xE3B0E0 VA: 0x180E3C6E0
	|-Array.Sort<SamplePointsPatch>
	|
	|-RVA: 0xE3C910 Offset: 0xE3B310 VA: 0x180E3C910
	|-Array.Sort<Scene>
	|
	|-RVA: 0xE3CB40 Offset: 0xE3B540 VA: 0x180E3CB40
	|-Array.Sort<SelectorMatchRecord>
	|
	|-RVA: 0xE3D860 Offset: 0xE3C260 VA: 0x180E3D860
	|-Array.Sort<ShaderTagId>
	|
	|-RVA: 0xE3E1F0 Offset: 0xE3CBF0 VA: 0x180E3E1F0
	|-Array.Sort<float>
	|
	|-RVA: 0xE3EAB0 Offset: 0xE3D4B0 VA: 0x180E3EAB0
	|-Array.Sort<StylePropertyName>
	|
	|-RVA: 0xE3ECE0 Offset: 0xE3D6E0 VA: 0x180E3ECE0
	|-Array.Sort<StylePropertyValue>
	|
	|-RVA: 0xE3EF10 Offset: 0xE3D910 VA: 0x180E3EF10
	|-Array.Sort<StyleSelectorPart>
	|
	|-RVA: 0xE3F140 Offset: 0xE3DB40 VA: 0x180E3F140
	|-Array.Sort<StyleSyntaxToken>
	|
	|-RVA: 0xE3F5A0 Offset: 0xE3DFA0 VA: 0x180E3F5A0
	|-Array.Sort<StyleValue>
	|
	|-RVA: 0xE3F370 Offset: 0xE3DD70 VA: 0x180E3F370
	|-Array.Sort<StyleValueManaged>
	|
	|-RVA: 0xE3F7D0 Offset: 0xE3E1D0 VA: 0x180E3F7D0
	|-Array.Sort<StyleVariable>
	|
	|-RVA: 0xE3FC30 Offset: 0xE3E630 VA: 0x180E3FC30
	|-Array.Sort<Substring>
	|
	|-RVA: 0xE402C0 Offset: 0xE3ECC0 VA: 0x180E402C0
	|-Array.Sort<TimeSpan>
	|
	|-RVA: 0xE404F0 Offset: 0xE3EEF0 VA: 0x180E404F0
	|-Array.Sort<TimeValue>
	|
	|-RVA: 0xE40950 Offset: 0xE3F350 VA: 0x180E40950
	|-Array.Sort<TreeViewItemWrapper>
	|
	|-RVA: 0xE40FE0 Offset: 0xE3F9E0 VA: 0x180E40FE0
	|-Array.Sort<UICharInfo>
	|
	|-RVA: 0xE41210 Offset: 0xE3FC10 VA: 0x180E41210
	|-Array.Sort<UILineInfo>
	|
	|-RVA: 0xE41440 Offset: 0xE3FE40 VA: 0x180E41440
	|-Array.Sort<UIVertex>
	|
	|-RVA: 0xE41670 Offset: 0xE40070 VA: 0x180E41670
	|-Array.Sort<ushort>
	|
	|-RVA: 0xE41AD0 Offset: 0xE404D0 VA: 0x180E41AD0
	|-Array.Sort<uint>
	|
	|-RVA: 0xE418A0 Offset: 0xE402A0 VA: 0x180E418A0
	|-Array.Sort<UInt32Enum>
	|
	|-RVA: 0xE41F80 Offset: 0xE40980 VA: 0x180E41F80
	|-Array.Sort<ulong>
	|
	|-RVA: 0xE421B0 Offset: 0xE40BB0 VA: 0x180E421B0
	|-Array.Sort<UShort2>
	|
	|-RVA: 0xE423E0 Offset: 0xE40DE0 VA: 0x180E423E0
	|-Array.Sort<UnloadedScene>
	|
	|-RVA: 0xE42610 Offset: 0xE41010 VA: 0x180E42610
	|-Array.Sort<UsageHint>
	|
	|-RVA: 0xE439C0 Offset: 0xE423C0 VA: 0x180E439C0
	|-Array.Sort<Vector2>
	|
	|-RVA: 0xE43BF0 Offset: 0xE425F0 VA: 0x180E43BF0
	|-Array.Sort<Vector3>
	|
	|-RVA: 0xE43E20 Offset: 0xE42820 VA: 0x180E43E20
	|-Array.Sort<Vector4>
	|
	|-RVA: 0xE444B0 Offset: 0xE42EB0 VA: 0x180E444B0
	|-Array.Sort<VoxelContour>
	|
	|-RVA: 0xE44910 Offset: 0xE43310 VA: 0x180E44910
	|-Array.Sort<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xE44D70 Offset: 0xE43770 VA: 0x180E44D70
	|-Array.Sort<X509ChainStatus>
	|
	|-RVA: 0xE44FA0 Offset: 0xE439A0 VA: 0x180E44FA0
	|-Array.Sort<XRFeatureDescriptor>
	|
	|-RVA: 0xE451D0 Offset: 0xE43BD0 VA: 0x180E451D0
	|-Array.Sort<XRView>
	|
	|-RVA: 0xE45630 Offset: 0xE44030 VA: 0x180E45630
	|-Array.Sort<ZipGenericExtraField>
	|
	|-RVA: 0xE30EF0 Offset: 0xE2F8F0 VA: 0x180E30EF0
	|-Array.Sort<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE3DA90 Offset: 0xE3C490 VA: 0x180E3DA90
	|-Array.Sort<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|
	|-RVA: 0xE40DB0 Offset: 0xE3F7B0 VA: 0x180E40DB0
	|-Array.Sort<AdvancedSmooth.Turn>
	|
	|-RVA: 0xE446E0 Offset: 0xE430E0 VA: 0x180E446E0
	|-Array.Sort<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0xE34120 Offset: 0xE32B20 VA: 0x180E34120
	|-Array.Sort<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xE37370 Offset: 0xE35D70 VA: 0x180E37370
	|-Array.Sort<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0xE377D0 Offset: 0xE361D0 VA: 0x180E377D0
	|-Array.Sort<BitmapAllocator32.Page>
	|
	|-RVA: 0xE2C890 Offset: 0xE2B290 VA: 0x180E2C890
	|-Array.Sort<CameraState.CustomBlendable>
	|
	|-RVA: 0xE37A00 Offset: 0xE36400 VA: 0x180E37A00
	|-Array.Sort<CinemachineClearShot.Pair>
	|
	|-RVA: 0xE30800 Offset: 0xE2F200 VA: 0x180E30800
	|-Array.Sort<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0xE2DA10 Offset: 0xE2C410 VA: 0x180E2DA10
	|-Array.Sort<ClipperLib.DoublePoint>
	|
	|-RVA: 0xE32910 Offset: 0xE31310 VA: 0x180E32910
	|-Array.Sort<ClipperLib.IntPoint>
	|
	|-RVA: 0xE38950 Offset: 0xE37350 VA: 0x180E38950
	|-Array.Sort<ConfinerOven.PolygonSolution>
	|
	|-RVA: 0xE2CF20 Offset: 0xE2B920 VA: 0x180E2CF20
	|-Array.Sort<DecalEntityIndexer.DecalEntityItem>
	|
	|-RVA: 0xE2AC20 Offset: 0xE29620 VA: 0x180E2AC20
	|-Array.Sort<DecalEntityManager.CombinedChunks>
	|
	|-RVA: 0xE2EFF0 Offset: 0xE2D9F0 VA: 0x180E2EFF0
	|-Array.Sort<FocusController.FocusedElement>
	|
	|-RVA: 0xE2F680 Offset: 0xE2E080 VA: 0x180E2F680
	|-Array.Sort<FrameTimingsHUDDisplay.FrameTimingPoint>
	|
	|-RVA: 0xE37E60 Offset: 0xE36860 VA: 0x180E37E60
	|-Array.Sort<Funnel.PathPart>
	|
	|-RVA: 0xE44050 Offset: 0xE42A50 VA: 0x180E44050
	|-Array.Sort<GodRaysRenderPass.VisibleLightRemap>
	|
	|-RVA: 0xE30170 Offset: 0xE2EB70 VA: 0x180E30170
	|-Array.Sort<HID.HIDCollectionDescriptor>
	|
	|-RVA: 0xE303A0 Offset: 0xE2EDA0 VA: 0x180E303A0
	|-Array.Sort<HID.HIDElementDescriptor>
	|
	|-RVA: 0xE305D0 Offset: 0xE2EFD0 VA: 0x180E305D0
	|-Array.Sort<HIDParser.HIDReportData>
	|
	|-RVA: 0xE38FE0 Offset: 0xE379E0 VA: 0x180E38FE0
	|-Array.Sort<HeatmapManager.PropertyRegionReference>
	|
	|-RVA: 0xE286F0 Offset: 0xE270F0 VA: 0x180E286F0
	|-Array.Sort<InputActionMap.BindingOverrideJson>
	|
	|-RVA: 0xE2B940 Offset: 0xE2A340 VA: 0x180E2B940
	|-Array.Sort<InputControlLayout.ControlItem>
	|
	|-RVA: 0xE40720 Offset: 0xE3F120 VA: 0x180E40720
	|-Array.Sort<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xE33CC0 Offset: 0xE326C0 VA: 0x180E33CC0
	|-Array.Sort<JsonParser.JsonValue>
	|
	|-RVA: 0xE35930 Offset: 0xE34330 VA: 0x180E35930
	|-Array.Sort<LatencySimulator.Message>
	|
	|-RVA: 0xE3E880 Offset: 0xE3D280 VA: 0x180E3E880
	|-Array.Sort<MultiColumnCollectionHeader.SortedColumnState>
	|
	|-RVA: 0xE3FE60 Offset: 0xE3E860 VA: 0x180E3FE60
	|-Array.Sort<NativeMethods.TASKDIALOG_BUTTON>
	|
	|-RVA: 0xE40B80 Offset: 0xE3F580 VA: 0x180E40B80
	|-Array.Sort<NetworkAnimator.TriggerUpdate>
	|
	|-RVA: 0xE375A0 Offset: 0xE35FA0 VA: 0x180E375A0
	|-Array.Sort<OutlineEffect.OutlineTargetGroup>
	|
	|-RVA: 0xE29870 Offset: 0xE28270 VA: 0x180E29870
	|-Array.Sort<PlayingCard.CardData>
	|
	|-RVA: 0xE3AE80 Offset: 0xE39880 VA: 0x180E3AE80
	|-Array.Sort<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xE28FB0 Offset: 0xE279B0 VA: 0x180E28FB0
	|-Array.Sort<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xE3D630 Offset: 0xE3C030 VA: 0x180E3D630
	|-Array.Sort<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|
	|-RVA: 0xE3CD70 Offset: 0xE3B770 VA: 0x180E3CD70
	|-Array.Sort<ProbeVolumeSceneData.SerializableBoundItem>
	|
	|-RVA: 0xE3CFA0 Offset: 0xE3B9A0 VA: 0x180E3CFA0
	|-Array.Sort<ProbeVolumeSceneData.SerializableHasPVItem>
	|
	|-RVA: 0xE3D1D0 Offset: 0xE3BBD0 VA: 0x180E3D1D0
	|-Array.Sort<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|
	|-RVA: 0xE3D400 Offset: 0xE3BE00 VA: 0x180E3D400
	|-Array.Sort<ProbeVolumeSceneData.SerializablePVProfile>
	|
	|-RVA: 0xE3DCC0 Offset: 0xE3C6C0 VA: 0x180E3DCC0
	|-Array.Sort<RegexCharClass.SingleRange>
	|
	|-RVA: 0xE3A390 Offset: 0xE38D90 VA: 0x180E3A390
	|-Array.Sort<RenderChain.RenderNodeData>
	|
	|-RVA: 0xE37C30 Offset: 0xE36630 VA: 0x180E37C30
	|-Array.Sort<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0xE3B2E0 Offset: 0xE39CE0 VA: 0x180E3B2E0
	|-Array.Sort<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0xE35700 Offset: 0xE34100 VA: 0x180E35700
	|-Array.Sort<RetainedGizmos.MeshWithHash>
	|
	|-RVA: 0xE3B740 Offset: 0xE3A140 VA: 0x180E3B740
	|-Array.Sort<RigidbodyPauser.Rigidbody2DData>
	|
	|-RVA: 0xE3B970 Offset: 0xE3A370 VA: 0x180E3B970
	|-Array.Sort<RigidbodyPauser.RigidbodyData>
	|
	|-RVA: 0xE35B60 Offset: 0xE34560 VA: 0x180E35B60
	|-Array.Sort<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xE30A30 Offset: 0xE2F430 VA: 0x180E30A30
	|-Array.Sort<SVGDocument.HierarchyUpdate>
	|
	|-RVA: 0xE36CE0 Offset: 0xE356E0 VA: 0x180E36CE0
	|-Array.Sort<SVGDocument.NodeReferenceData>
	|
	|-RVA: 0xE36F10 Offset: 0xE35910 VA: 0x180E36F10
	|-Array.Sort<SVGDocument.NodeWithParent>
	|
	|-RVA: 0xE38B80 Offset: 0xE37580 VA: 0x180E38B80
	|-Array.Sort<SVGDocument.PostponedClip>
	|
	|-RVA: 0xE38DB0 Offset: 0xE377B0 VA: 0x180E38DB0
	|-Array.Sort<SVGDocument.PostponedStopData>
	|
	|-RVA: 0xE2B080 Offset: 0xE29A80 VA: 0x180E2B080
	|-Array.Sort<ServerSocket.ConnectionChange>
	|
	|-RVA: 0xE361F0 Offset: 0xE34BF0 VA: 0x180E361F0
	|-Array.Sort<SewerMushroomLocation.MushroomLocationData>
	|
	|-RVA: 0xE2E730 Offset: 0xE2D130 VA: 0x180E2E730
	|-Array.Sort<ShadowUtility.Edge>
	|
	|-RVA: 0xE29F00 Offset: 0xE28900 VA: 0x180E29F00
	|-Array.Sort<StructySync.ChangeData>
	|
	|-RVA: 0xE29CD0 Offset: 0xE286D0 VA: 0x180E29CD0
	|-Array.Sort<SyncStopwatch.ChangeData>
	|
	|-RVA: 0xE29AA0 Offset: 0xE284A0 VA: 0x180E29AA0
	|-Array.Sort<SyncTimer.ChangeData>
	|
	|-RVA: 0xE29640 Offset: 0xE28040 VA: 0x180E29640
	|-Array.Sort<TargetStateListener.Callback>
	|
	|-RVA: 0xE27E30 Offset: 0xE26830 VA: 0x180E27E30
	|-Array.Sort<TemplateAsset.AttributeOverride>
	|
	|-RVA: 0xE2F220 Offset: 0xE2DC20 VA: 0x180E2F220
	|-Array.Sort<TextSettings.FontReferenceMap>
	|
	|-RVA: 0xE28920 Offset: 0xE27320 VA: 0x180E28920
	|-Array.Sort<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xE2F8B0 Offset: 0xE2E2B0 VA: 0x180E2F8B0
	|-Array.Sort<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xE40090 Offset: 0xE3EA90 VA: 0x180E40090
	|-Array.Sort<TextureRegistry.TextureInfo>
	|
	|-RVA: 0xE37140 Offset: 0xE35B40 VA: 0x180E37140
	|-Array.Sort<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0xE398A0 Offset: 0xE382A0 VA: 0x180E398A0
	|-Array.Sort<TrackedDeviceRaycaster.RaycastHitData>
	|
	|-RVA: 0xE2D380 Offset: 0xE2BD80 VA: 0x180E2D380
	|-Array.Sort<TransportManager.DisconnectingClient>
	|
	|-RVA: 0xE2E960 Offset: 0xE2D360 VA: 0x180E2E960
	|-Array.Sort<UIRStylePainter.Entry>
	|
	|-RVA: 0xE3AC50 Offset: 0xE39650 VA: 0x180E3AC50
	|-Array.Sort<UIRStylePainter.RepeatRectUV>
	|
	|-RVA: 0xE27340 Offset: 0xE25D40 VA: 0x180E27340
	|-Array.Sort<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xE27570 Offset: 0xE25F70 VA: 0x180E27570
	|-Array.Sort<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xE44B40 Offset: 0xE43540 VA: 0x180E44B40
	|-Array.Sort<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0xE279D0 Offset: 0xE263D0 VA: 0x180E279D0
	|-Array.Sort<VisualTreeAsset.AssetEntry>
	|
	|-RVA: 0xE3E420 Offset: 0xE3CE20 VA: 0x180E3E420
	|-Array.Sort<VisualTreeAsset.SlotDefinition>
	|
	|-RVA: 0xE3E650 Offset: 0xE3D050 VA: 0x180E3E650
	|-Array.Sort<VisualTreeAsset.SlotUsageEntry>
	|
	|-RVA: 0xE42840 Offset: 0xE41240 VA: 0x180E42840
	|-Array.Sort<VisualTreeAsset.UsingEntry>
	|
	|-RVA: 0xE42A70 Offset: 0xE41470 VA: 0x180E42A70
	|-Array.Sort<VisualTreeAsset.UxmlObjectEntry>
	|
	|-RVA: 0xE45400 Offset: 0xE43E00 VA: 0x180E45400
	|-Array.Sort<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0xE44280 Offset: 0xE42C80 VA: 0x180E44280
	|-Array.Sort<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xE2B4E0 Offset: 0xE29EE0 VA: 0x180E2B4E0
	|-Array.Sort<DebugUI.Foldout.ContextMenuItem>
	|
	|-RVA: 0xE34350 Offset: 0xE32D50 VA: 0x180E34350
	|-Array.Sort<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xE31740 Offset: 0xE30140 VA: 0x180E31740
	|-Array.Sort<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0xE2A7C0 Offset: 0xE291C0 VA: 0x180E2A7C0
	|-Array.Sort<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xE33860 Offset: 0xE32260 VA: 0x180E33860
	|-Array.Sort<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xE39F30 Offset: 0xE38930 VA: 0x180E39F30
	|-Array.Sort<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE207C0 Offset: 0xE1F1C0 VA: 0x180E207C0
	|-Array.Sort<object>
	|
	|-RVA: 0xE202D0 Offset: 0xE1ECD0 VA: 0x180E202D0
	|-Array.Sort<RaycastHit>
	|
	|-RVA: 0xE20BB0 Offset: 0xE1F5B0 VA: 0x180E20BB0
	|-Array.Sort<Vector2>
	|
	|-RVA: 0xE20CC0 Offset: 0xE1F6C0 VA: 0x180E20CC0
	|-Array.Sort<Vector3>
	|
	|-RVA: 0xE1DB40 Offset: 0xE1C540 VA: 0x180E1DB40
	|-Array.Sort<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE1DC50 Offset: 0xE1C650 VA: 0x180E1DC50
	|-Array.Sort<int, int>
	|
	|-RVA: 0xE1D900 Offset: 0xE1C300 VA: 0x180E1D900
	|-Array.Sort<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3E170 Offset: 0xE3CB70 VA: 0x180E3E170
	|-Array.Sort<float, int>
	|
	|-RVA: 0xE30C60 Offset: 0xE2F660 VA: 0x180E30C60
	|-Array.Sort<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE20610 Offset: 0xE1F010 VA: 0x180E20610
	|-Array.Sort<object, int>
	|
	|-RVA: 0xE20B00 Offset: 0xE1F500 VA: 0x180E20B00
	|-Array.Sort<ulong, object>
	|
	|-RVA: 0xE1D850 Offset: 0xE1C250 VA: 0x180E1D850
	|-Array.Sort<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE31DD0 Offset: 0xE307D0 VA: 0x180E31DD0
	|-Array.Sort<int, int>
	|
	|-RVA: 0xE3BDD0 Offset: 0xE3A7D0 VA: 0x180E3BDD0
	|-Array.Sort<object, int>
	|
	|-RVA: 0xE3DEF0 Offset: 0xE3C8F0 VA: 0x180E3DEF0
	|-Array.Sort<float, int>
	|
	|-RVA: 0xE41D00 Offset: 0xE40700 VA: 0x180E41D00
	|-Array.Sort<ulong, object>
	|
	|-RVA: 0xE30CE0 Offset: 0xE2F6E0 VA: 0x180E30CE0
	|-Array.Sort<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Exists<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEA9320 Offset: 0xEA7D20 VA: 0x180EA9320
	|-Array.Exists<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3B3D0 Offset: 0xF39DD0 VA: 0x180F3B3D0
	|-Array.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3B550 Offset: 0xF39F50 VA: 0x180F3B550
	|-Array.Fill<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Find<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3D040 Offset: 0xF3BA40 VA: 0x180F3D040
	|-Array.Find<object>
	|
	|-RVA: 0xF3CE30 Offset: 0xF3B830 VA: 0x180F3CE30
	|-Array.Find<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF3CC70 Offset: 0xF3B670 VA: 0x180F3CC70
	|-Array.Find<HID.HIDElementDescriptor>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3BAC0 Offset: 0xF3A4C0 VA: 0x180F3BAC0
	|-Array.FindAll<Int32Enum>
	|
	|-RVA: 0xF3BD30 Offset: 0xF3A730 VA: 0x180F3BD30
	|-Array.FindAll<Vector2>
	|
	|-RVA: 0xF3B7B0 Offset: 0xF3A1B0 VA: 0x180F3B7B0
	|-Array.FindAll<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C390 Offset: 0xF3AD90 VA: 0x180F3C390
	|-Array.FindIndex<object>
	|
	|-RVA: 0xF3C240 Offset: 0xF3AC40 VA: 0x180F3C240
	|-Array.FindIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C2E0 Offset: 0xF3ACE0 VA: 0x180F3C2E0
	|-Array.FindIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C430 Offset: 0xF3AE30 VA: 0x180F3C430
	|-Array.FindIndex<object>
	|
	|-RVA: 0xF3BFD0 Offset: 0xF3A9D0 VA: 0x180F3BFD0
	|-Array.FindIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T FindLast<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3CA60 Offset: 0xF3B460 VA: 0x180F3CA60
	|-Array.FindLast<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C630 Offset: 0xF3B030 VA: 0x180F3C630
	|-Array.FindLastIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C9B0 Offset: 0xF3B3B0 VA: 0x180F3C9B0
	|-Array.FindLastIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3C6D0 Offset: 0xF3B0D0 VA: 0x180F3C6D0
	|-Array.FindLastIndex<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TrueForAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE45860 Offset: 0xE44260 VA: 0x180E45860
	|-Array.TrueForAll<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C7C240 Offset: 0x1C7AC40 VA: 0x181C7C240 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x1C7D160 Offset: 0x1C7BB60 VA: 0x181C7D160
	internal int InternalArray__ICollection_get_Count() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	internal bool InternalArray__ICollection_get_IsReadOnly() { }

	// RVA: 0x1C7C2F0 Offset: 0x1C7ACF0 VA: 0x181C7C2F0
	internal ref byte GetRawSzArrayData() { }

	// RVA: -1 Offset: -1
	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD1010 Offset: 0xDCFA10 VA: 0x180DD1010
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArraySegment<byte>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SyncList.ChangeData<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTree.Entry<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, short>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, long>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<long, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, double>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, long>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Guid, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int2, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int2, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int3, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, short>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Int3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, long>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, uint>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, ulong>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<long, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, char>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Color32>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, double>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, long>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Playable>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Rect>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Rect, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Scene, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ushort, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValue<int, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeArray<NudgeJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RBTree.Node<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RBTree.Node<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<DateTime>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nullable<Decimal>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TempAllocator.Page<ushort>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<char>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<InternedString>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Scene>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<uint>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<ulong>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StructMultiKey<object, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SubArray<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<Color32>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TreeViewItemData<object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Scene>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object>>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimatorClipInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AppId_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AstarWorkItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncGPUReadbackRequest>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AttachmentDescriptor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Background>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BackgroundPosition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BackgroundRepeat>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BackgroundSize>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BezierContour>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BezierPathSegment>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BezierSegment>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BigInteger>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Board>
	|-Array.InternalArray__IEnumerable_GetEnumerator<bool>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoundingSphere>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Bounds>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoundsInt>
	|-Array.InternalArray__IEnumerable_GetEnumerator<byte>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ByteEnum>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CGSpot>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CSteamID>
	|-Array.InternalArray__IEnumerable_GetEnumerator<char>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color32>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ColorBlock>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CombineInstance>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CompactVoxelCell>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CompactVoxelSpan>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ComputedStyle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ComputedTransitionProperty>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Connection>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPairHeader>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint2D>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContourVertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContourVertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ControlPointOption>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConvertMeshJobData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CoordinateFootprintTilePair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CoordinateProceduralTilePair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CoordinateStorageTilePair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CoordinateTilePair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CopyClosingMeshJobData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CullingSplit>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeNamedArgument>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeTypedArgument>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTime>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTimeOffset>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DecalEntity>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DecalSubDrawCall>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Decimal>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DepotId_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DictionaryEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dimension>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DisplayInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<double>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DoublePoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DoublePoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DrawBufferRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DualPrefab>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DuplicateSamplePoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EasingFunction>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Entry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EnumData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Ephemeron>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventSummary>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventTypeSpec>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ExtensionFilter>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FixedString128Bytes>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FontDefinition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FontWeightPair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FrameTimeSample>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FrameTiming>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FullRank>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GCHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GfxUpdateBufferRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphMarshallingStruct>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphRect>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientAlphaKey>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientColorKey>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientSettings>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GradientStop>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Guid>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HSteamNetConnection>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hash128>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeaderVariantInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HighlightState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HighlightState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HumanBone>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InclusiveRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IndexField>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IndexRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionSetHandle_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputBinding>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlScheme>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputDeviceDescription>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputEventPtr>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputHandle_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputUser>
	|-Array.InternalArray__IEnumerable_GetEnumerator<short>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int3>
	|-Array.InternalArray__IEnumerable_GetEnumerator<int>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int32Enum>
	|-Array.InternalArray__IEnumerable_GetEnumerator<long>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntPtr>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntRect>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntRegion>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalCodePageDataItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalEncodingDataItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternedString>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InterpretedFrameInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTreeNode>
	|-Array.InternalArray__IEnumerable_GetEnumerator<JobHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<JsonPosition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyStruct>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Keyframe>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Label>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LayerBatch>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LayerMask>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Length>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LigatureSubstitutionRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LigatureSubstitutionRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Light2DBlendStyle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightDataGI>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LineInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LinkInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LinkedVoxelSpan>
	|-Array.InternalArray__IEnumerable_GetEnumerator<List>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalDefinition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalKeyword>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalPacket>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalPacket>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ManipulatorActivationFilter>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MarkupAttribute>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MaterialReference>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MaterialReference>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Matrix4x4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MeshInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ModifiableContactPair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MultipleSubstitutionRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MultipleSubstitutionRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NameAndParameters>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NamedValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeAddr>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NavMeshBuildMarkup>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NavMeshBuildSource>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Navigation>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NudgeJobData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<object>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Packet>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PageInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterModifier>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Plane>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Playable>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayableBinding>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerLoopSystem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerLoopSystemInternal>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Point>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PointF>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PointerModel>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Pollfd>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Progress>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PublishedFileId_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<QosResult>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Quaternion>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RangePositionInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit2D>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastResult>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rect>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RectInt>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rectangle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RemoteConnectionEvent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderBuffer>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderInstancedDataLayout>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderStateBlock>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderTargetIdentifier>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RendererList>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RendererListHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RendererListResource>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Resolution>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResourceHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResourceLocator>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RichTextTagAttribute>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RichTextTagAttribute>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rigidbody2DState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RigidbodyState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rotate>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RpcLink>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RpcLinkType>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RuleMatcher>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RuntimeLabel>
	|-Array.InternalArray__IEnumerable_GetEnumerator<sbyte>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SByteEnum>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SamplePointUData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SamplePointsPatch>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ScalableImage>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Scale>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Scene>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SecondarySpriteTexture>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SelectorMatchRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SemanticMeaning>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderKeyword>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderTagId>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderVariablesProbeVolumes>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShadowSliceData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<float>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SkeletonBone>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SortingLayer>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpriteState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlBinary>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlBoolean>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlByte>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlDateTime>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlDecimal>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlDouble>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlGuid>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlInt16>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlInt32>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlInt64>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlMoney>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlSingle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SqlString>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamItemDef_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamItemDetails_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamItemInstanceID_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyName>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleSelectorPart>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleSyntaxToken>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleValueHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleValueManaged>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleVariable>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Substring>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_CharacterInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_FontWeightPair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LineInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LinkInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_MeshInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_PageInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_WordInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TemperatureEmitterInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TerrainTileCoord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextElementInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextProcessingElement>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextShadow>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextureHandle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextureId>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TileData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeSpan>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Touch>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Touch>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Transform3x4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TransformOrigin>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Translate>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TreeInstance>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TreeItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TreeViewItemWrapper>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UEncroachingSegment>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UEvent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UHull>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UICharInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UILineInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIVertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ushort>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt16Enum>
	|-Array.InternalArray__IEnumerable_GetEnumerator<uint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt32Enum>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ulong>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UShort2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UStar>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UTriangle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UnloadedScene>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UsageHint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2Int>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector3>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector3Int>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VectorImageVertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VertexAttributeDescriptor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisibleLight>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisibleReflectionProbe>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VoxelContour>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Win32_IP_ADAPTER_ADDRESSES>
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordWrapState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordWrapState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<X509ChainStatus>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XEvent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XPathNode>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XPathNodeRef>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XRFeatureDescriptor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XRView>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ZipGenericExtraField>
	|-Array.InternalArray__IEnumerable_GetEnumerator<__Il2CppFullySharedGenericType>
	|-Array.InternalArray__IEnumerable_GetEnumerator<double2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<float2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<float3>
	|-Array.InternalArray__IEnumerable_GetEnumerator<float4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<float4x4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<int2>
	|-Array.InternalArray__IEnumerable_GetEnumerator<int3>
	|-Array.InternalArray__IEnumerable_GetEnumerator<int4>
	|-Array.InternalArray__IEnumerable_GetEnumerator<jvalue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<quaternion>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AdvancedSmooth.Turn>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Agent.VO>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimationWarping.Warp>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AstarDebugger.GraphPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<AvatarSettings.LayerSetting>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BBTree.BBTreeBox>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BinaryHeap.Tuple>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BitmapAllocator32.Page>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BlitUtility.Vertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BloomRenderer.Level>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CameraState.CustomBlendable>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineClearShot.Pair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachinePath.Waypoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineTargetGroup.Target>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClipperLib.DoublePoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClipperLib.IntPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CodePointIndexer.TableRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__IEnumerable_GetEnumerator<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Cursor.CursorEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Cursor.CursorImage>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DataError.ColumnError>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventDispatcher.DispatchContext>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventDispatcher.EventRecord>
	|-Array.InternalArray__IEnumerable_GetEnumerator<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ExpressionParser.ReservedWords>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FocusController.FocusedElement>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Funnel.PathPart>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GrounderQuadruped.Foot>
	|-Array.InternalArray__IEnumerable_GetEnumerator<GtkPlus.GdkColor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HID.HIDElementDescriptor>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HIDParser.HIDReportData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hammersley.Hammersley2dSeq16>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hammersley.Hammersley2dSeq256>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hammersley.Hammersley2dSeq32>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hammersley.Hammersley2dSeq64>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hashtable.bucket>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeadingTracker.Item>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__IEnumerable_GetEnumerator<HebrewNumber.HebrewValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Icon.IconDirEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.BindingJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.ReadActionJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.ReadMapJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.WriteActionJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionMap.WriteMapJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlLayout.ControlItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlScheme.SchemeJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputDevice.ControlBitRangeNode>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputManager.AvailableDevice>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputRemoting.RemoteSender>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputStateHistory.Record>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputUser.UserData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<JsonParser.JsonValue>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LatencySimulator.Message>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LayerGridGraph.HeightSample>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightUtility.LightMeshVertex>
	|-Array.InternalArray__IEnumerable_GetEnumerator<LiquidVolume.MeshCache>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ListView.ItemMatrixLocation>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MemoryHelpers.BitRegion>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Multipass.TransportIdData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NatPunchModule.RequestEventData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkAnimator.StateChange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__IEnumerable_GetEnumerator<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayingCard.CardData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PointKDTree.Node>
	|-Array.InternalArray__IEnumerable_GetEnumerator<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeBrickIndex.Brick>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeBrickIndex.ReservedBrick>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RVOQuadtree.Node>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RegexCharClass.SingleRange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ReliableChannel.PendingPacket>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderChain.RenderNodeData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraph.CompiledPassInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.ClipData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.MaskData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.NodeGlobalSceneState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.NodeWithParent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.PatternData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.PostponedClip>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.PostponedStopData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SendMouseEvents.HitInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ServerSocket.ConnectionChange>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderInput.LightData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShadowUtility.Edge>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Socket.WSABUF>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StructySync.ChangeData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleSheet.ImportStruct>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__IEnumerable_GetEnumerator<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SyncStopwatch.ChangeData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<SyncTimer.ChangeData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Syscall._pollfd>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetStateListener.Callback>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextSettings.FontReferenceMap>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextureBlitter.BlitInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TexturePacker_JsonArray.Frame>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextureRegistry.TextureInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Tilemap.SyncTile>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TransportManager.DisconnectingClient>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIRStylePainter.Entry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIRenderDevice.AllocToUpdate>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__IEnumerable_GetEnumerator<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VolumetricFog.FogOfWarTransition>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Win32DnD.FORMATETC>
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordStorage.Entry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<X11DesktopColors.GdkColorStruct>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlEventCache.XmlEvent>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlTextReaderImpl.ParsingState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlTextWriter.Namespace>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlTextWriter.TagInfo>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__IEnumerable_GetEnumerator<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-Array.InternalArray__IEnumerable_GetEnumerator<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__IEnumerable_GetEnumerator<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlLayout.Collection.LayoutMatcher>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlScheme.MatchResult.Match>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__IEnumerable_GetEnumerator<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__IEnumerable_GetEnumerator<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheCurve.Item>
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheEntry.RecordingItem>
	|-Array.InternalArray__IEnumerable_GetEnumerator<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	*/

	// RVA: 0x1C7D110 Offset: 0x1C7BB10 VA: 0x181C7D110
	internal void InternalArray__ICollection_Clear() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_Add<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5610 Offset: 0xFB4010 VA: 0x180FB5610
	|-Array.InternalArray__ICollection_Add<ArraySegment<byte>>
	|-Array.InternalArray__ICollection_Add<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__ICollection_Add<SyncList.ChangeData<int>>
	|-Array.InternalArray__ICollection_Add<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__ICollection_Add<IntervalTree.Entry<object>>
	|-Array.InternalArray__ICollection_Add<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, short>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, long>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, float>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<long, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, double>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, long>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, float>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__ICollection_Add<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Guid, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int2, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int2, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int3, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, bool>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, short>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Int3>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, long>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, float>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, uint>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, ulong>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<long, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, bool>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, char>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Color32>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, double>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, long>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Playable>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Rect>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, float>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Rect, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Scene, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ushort, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Add<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Add<KeyValue<int, int>>
	|-Array.InternalArray__ICollection_Add<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Add<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Add<NativeArray<NudgeJobData>>
	|-Array.InternalArray__ICollection_Add<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Add<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Add<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__ICollection_Add<RBTree.Node<int>>
	|-Array.InternalArray__ICollection_Add<RBTree.Node<object>>
	|-Array.InternalArray__ICollection_Add<Nullable<DateTime>>
	|-Array.InternalArray__ICollection_Add<Nullable<Decimal>>
	|-Array.InternalArray__ICollection_Add<TempAllocator.Page<ushort>>
	|-Array.InternalArray__ICollection_Add<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__ICollection_Add<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__ICollection_Add<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<bool>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__ICollection_Add<Set.Slot<char>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<int>>
	|-Array.InternalArray__ICollection_Add<Set.Slot<int>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<InternedString>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<object>>
	|-Array.InternalArray__ICollection_Add<Set.Slot<object>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Scene>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<uint>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<ulong>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__ICollection_Add<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__ICollection_Add<StructMultiKey<object, object>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__ICollection_Add<SubArray<int>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Add<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__ICollection_Add<TreeViewItemData<object>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, int>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, object>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Scene>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, int>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object>>
	|-Array.InternalArray__ICollection_Add<AnimatorClipInfo>
	|-Array.InternalArray__ICollection_Add<AppId_t>
	|-Array.InternalArray__ICollection_Add<AstarWorkItem>
	|-Array.InternalArray__ICollection_Add<AsyncGPUReadbackRequest>
	|-Array.InternalArray__ICollection_Add<AttachmentDescriptor>
	|-Array.InternalArray__ICollection_Add<Background>
	|-Array.InternalArray__ICollection_Add<BackgroundPosition>
	|-Array.InternalArray__ICollection_Add<BackgroundRepeat>
	|-Array.InternalArray__ICollection_Add<BackgroundSize>
	|-Array.InternalArray__ICollection_Add<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__ICollection_Add<BezierContour>
	|-Array.InternalArray__ICollection_Add<BezierPathSegment>
	|-Array.InternalArray__ICollection_Add<BezierSegment>
	|-Array.InternalArray__ICollection_Add<BigInteger>
	|-Array.InternalArray__ICollection_Add<Board>
	|-Array.InternalArray__ICollection_Add<bool>
	|-Array.InternalArray__ICollection_Add<BoundingSphere>
	|-Array.InternalArray__ICollection_Add<Bounds>
	|-Array.InternalArray__ICollection_Add<BoundsInt>
	|-Array.InternalArray__ICollection_Add<byte>
	|-Array.InternalArray__ICollection_Add<ByteEnum>
	|-Array.InternalArray__ICollection_Add<CGSpot>
	|-Array.InternalArray__ICollection_Add<CSteamID>
	|-Array.InternalArray__ICollection_Add<char>
	|-Array.InternalArray__ICollection_Add<Color>
	|-Array.InternalArray__ICollection_Add<Color>
	|-Array.InternalArray__ICollection_Add<Color32>
	|-Array.InternalArray__ICollection_Add<ColorBlock>
	|-Array.InternalArray__ICollection_Add<CombineInstance>
	|-Array.InternalArray__ICollection_Add<CompactVoxelCell>
	|-Array.InternalArray__ICollection_Add<CompactVoxelSpan>
	|-Array.InternalArray__ICollection_Add<ComputedStyle>
	|-Array.InternalArray__ICollection_Add<ComputedTransitionProperty>
	|-Array.InternalArray__ICollection_Add<Connection>
	|-Array.InternalArray__ICollection_Add<ContactPairHeader>
	|-Array.InternalArray__ICollection_Add<ContactPoint>
	|-Array.InternalArray__ICollection_Add<ContactPoint2D>
	|-Array.InternalArray__ICollection_Add<ContourVertex>
	|-Array.InternalArray__ICollection_Add<ContourVertex>
	|-Array.InternalArray__ICollection_Add<ControlPointOption>
	|-Array.InternalArray__ICollection_Add<ConvertMeshJobData>
	|-Array.InternalArray__ICollection_Add<CoordinateFootprintTilePair>
	|-Array.InternalArray__ICollection_Add<CoordinateProceduralTilePair>
	|-Array.InternalArray__ICollection_Add<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__ICollection_Add<CoordinateStorageTilePair>
	|-Array.InternalArray__ICollection_Add<CoordinateTilePair>
	|-Array.InternalArray__ICollection_Add<CopyClosingMeshJobData>
	|-Array.InternalArray__ICollection_Add<CullingSplit>
	|-Array.InternalArray__ICollection_Add<CustomAttributeNamedArgument>
	|-Array.InternalArray__ICollection_Add<CustomAttributeTypedArgument>
	|-Array.InternalArray__ICollection_Add<DateTime>
	|-Array.InternalArray__ICollection_Add<DateTimeOffset>
	|-Array.InternalArray__ICollection_Add<DecalEntity>
	|-Array.InternalArray__ICollection_Add<DecalSubDrawCall>
	|-Array.InternalArray__ICollection_Add<Decimal>
	|-Array.InternalArray__ICollection_Add<DepotId_t>
	|-Array.InternalArray__ICollection_Add<DictionaryEntry>
	|-Array.InternalArray__ICollection_Add<Dimension>
	|-Array.InternalArray__ICollection_Add<DisplayInfo>
	|-Array.InternalArray__ICollection_Add<double>
	|-Array.InternalArray__ICollection_Add<DoublePoint>
	|-Array.InternalArray__ICollection_Add<DoublePoint>
	|-Array.InternalArray__ICollection_Add<DrawBufferRange>
	|-Array.InternalArray__ICollection_Add<DualPrefab>
	|-Array.InternalArray__ICollection_Add<DuplicateSamplePoint>
	|-Array.InternalArray__ICollection_Add<EasingFunction>
	|-Array.InternalArray__ICollection_Add<Entry>
	|-Array.InternalArray__ICollection_Add<EnumData>
	|-Array.InternalArray__ICollection_Add<Ephemeron>
	|-Array.InternalArray__ICollection_Add<EventSummary>
	|-Array.InternalArray__ICollection_Add<EventTypeSpec>
	|-Array.InternalArray__ICollection_Add<ExtensionFilter>
	|-Array.InternalArray__ICollection_Add<FixedString128Bytes>
	|-Array.InternalArray__ICollection_Add<FontDefinition>
	|-Array.InternalArray__ICollection_Add<FontWeightPair>
	|-Array.InternalArray__ICollection_Add<FrameTimeSample>
	|-Array.InternalArray__ICollection_Add<FrameTiming>
	|-Array.InternalArray__ICollection_Add<FullRank>
	|-Array.InternalArray__ICollection_Add<GCHandle>
	|-Array.InternalArray__ICollection_Add<GfxUpdateBufferRange>
	|-Array.InternalArray__ICollection_Add<GlyphMarshallingStruct>
	|-Array.InternalArray__ICollection_Add<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__ICollection_Add<GlyphRect>
	|-Array.InternalArray__ICollection_Add<GradientAlphaKey>
	|-Array.InternalArray__ICollection_Add<GradientColorKey>
	|-Array.InternalArray__ICollection_Add<GradientSettings>
	|-Array.InternalArray__ICollection_Add<GradientStop>
	|-Array.InternalArray__ICollection_Add<Guid>
	|-Array.InternalArray__ICollection_Add<HSteamNetConnection>
	|-Array.InternalArray__ICollection_Add<Hash128>
	|-Array.InternalArray__ICollection_Add<HeaderVariantInfo>
	|-Array.InternalArray__ICollection_Add<HighlightState>
	|-Array.InternalArray__ICollection_Add<HighlightState>
	|-Array.InternalArray__ICollection_Add<HumanBone>
	|-Array.InternalArray__ICollection_Add<InclusiveRange>
	|-Array.InternalArray__ICollection_Add<IndexField>
	|-Array.InternalArray__ICollection_Add<IndexRange>
	|-Array.InternalArray__ICollection_Add<InputActionSetHandle_t>
	|-Array.InternalArray__ICollection_Add<InputBinding>
	|-Array.InternalArray__ICollection_Add<InputControlScheme>
	|-Array.InternalArray__ICollection_Add<InputDeviceDescription>
	|-Array.InternalArray__ICollection_Add<InputEventPtr>
	|-Array.InternalArray__ICollection_Add<InputHandle_t>
	|-Array.InternalArray__ICollection_Add<InputUser>
	|-Array.InternalArray__ICollection_Add<short>
	|-Array.InternalArray__ICollection_Add<Int2>
	|-Array.InternalArray__ICollection_Add<Int3>
	|-Array.InternalArray__ICollection_Add<int>
	|-Array.InternalArray__ICollection_Add<Int32Enum>
	|-Array.InternalArray__ICollection_Add<long>
	|-Array.InternalArray__ICollection_Add<IntPoint>
	|-Array.InternalArray__ICollection_Add<IntPoint>
	|-Array.InternalArray__ICollection_Add<IntPtr>
	|-Array.InternalArray__ICollection_Add<IntRect>
	|-Array.InternalArray__ICollection_Add<IntRegion>
	|-Array.InternalArray__ICollection_Add<InternalCodePageDataItem>
	|-Array.InternalArray__ICollection_Add<InternalEncodingDataItem>
	|-Array.InternalArray__ICollection_Add<InternedString>
	|-Array.InternalArray__ICollection_Add<InterpretedFrameInfo>
	|-Array.InternalArray__ICollection_Add<IntervalTreeNode>
	|-Array.InternalArray__ICollection_Add<JobHandle>
	|-Array.InternalArray__ICollection_Add<JsonPosition>
	|-Array.InternalArray__ICollection_Add<KeyStruct>
	|-Array.InternalArray__ICollection_Add<Keyframe>
	|-Array.InternalArray__ICollection_Add<Label>
	|-Array.InternalArray__ICollection_Add<LayerBatch>
	|-Array.InternalArray__ICollection_Add<LayerMask>
	|-Array.InternalArray__ICollection_Add<Length>
	|-Array.InternalArray__ICollection_Add<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Add<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Add<Light2DBlendStyle>
	|-Array.InternalArray__ICollection_Add<LightDataGI>
	|-Array.InternalArray__ICollection_Add<LineInfo>
	|-Array.InternalArray__ICollection_Add<LinkInfo>
	|-Array.InternalArray__ICollection_Add<LinkedVoxelSpan>
	|-Array.InternalArray__ICollection_Add<List>
	|-Array.InternalArray__ICollection_Add<LocalDefinition>
	|-Array.InternalArray__ICollection_Add<LocalKeyword>
	|-Array.InternalArray__ICollection_Add<LocalPacket>
	|-Array.InternalArray__ICollection_Add<LocalPacket>
	|-Array.InternalArray__ICollection_Add<ManipulatorActivationFilter>
	|-Array.InternalArray__ICollection_Add<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Add<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Add<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Add<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Add<MarkupAttribute>
	|-Array.InternalArray__ICollection_Add<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__ICollection_Add<MaterialReference>
	|-Array.InternalArray__ICollection_Add<MaterialReference>
	|-Array.InternalArray__ICollection_Add<Matrix4x4>
	|-Array.InternalArray__ICollection_Add<MeshInfo>
	|-Array.InternalArray__ICollection_Add<ModifiableContactPair>
	|-Array.InternalArray__ICollection_Add<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Add<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Add<NameAndParameters>
	|-Array.InternalArray__ICollection_Add<NamedValue>
	|-Array.InternalArray__ICollection_Add<NativeAddr>
	|-Array.InternalArray__ICollection_Add<NavMeshBuildMarkup>
	|-Array.InternalArray__ICollection_Add<NavMeshBuildSource>
	|-Array.InternalArray__ICollection_Add<Navigation>
	|-Array.InternalArray__ICollection_Add<NudgeJobData>
	|-Array.InternalArray__ICollection_Add<object>
	|-Array.InternalArray__ICollection_Add<Packet>
	|-Array.InternalArray__ICollection_Add<PageInfo>
	|-Array.InternalArray__ICollection_Add<ParameterModifier>
	|-Array.InternalArray__ICollection_Add<Plane>
	|-Array.InternalArray__ICollection_Add<Playable>
	|-Array.InternalArray__ICollection_Add<PlayableBinding>
	|-Array.InternalArray__ICollection_Add<PlayerLoopSystem>
	|-Array.InternalArray__ICollection_Add<PlayerLoopSystemInternal>
	|-Array.InternalArray__ICollection_Add<Point>
	|-Array.InternalArray__ICollection_Add<PointF>
	|-Array.InternalArray__ICollection_Add<PointerModel>
	|-Array.InternalArray__ICollection_Add<Pollfd>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__ICollection_Add<Progress>
	|-Array.InternalArray__ICollection_Add<PublishedFileId_t>
	|-Array.InternalArray__ICollection_Add<QosResult>
	|-Array.InternalArray__ICollection_Add<Quaternion>
	|-Array.InternalArray__ICollection_Add<RangePositionInfo>
	|-Array.InternalArray__ICollection_Add<RaycastHit>
	|-Array.InternalArray__ICollection_Add<RaycastHit2D>
	|-Array.InternalArray__ICollection_Add<RaycastResult>
	|-Array.InternalArray__ICollection_Add<Rect>
	|-Array.InternalArray__ICollection_Add<RectInt>
	|-Array.InternalArray__ICollection_Add<Rectangle>
	|-Array.InternalArray__ICollection_Add<RemoteConnectionEvent>
	|-Array.InternalArray__ICollection_Add<RenderBuffer>
	|-Array.InternalArray__ICollection_Add<RenderInstancedDataLayout>
	|-Array.InternalArray__ICollection_Add<RenderStateBlock>
	|-Array.InternalArray__ICollection_Add<RenderTargetIdentifier>
	|-Array.InternalArray__ICollection_Add<RendererList>
	|-Array.InternalArray__ICollection_Add<RendererListHandle>
	|-Array.InternalArray__ICollection_Add<RendererListResource>
	|-Array.InternalArray__ICollection_Add<Resolution>
	|-Array.InternalArray__ICollection_Add<ResourceHandle>
	|-Array.InternalArray__ICollection_Add<ResourceLocator>
	|-Array.InternalArray__ICollection_Add<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Add<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Add<Rigidbody2DState>
	|-Array.InternalArray__ICollection_Add<RigidbodyState>
	|-Array.InternalArray__ICollection_Add<Rotate>
	|-Array.InternalArray__ICollection_Add<RpcLink>
	|-Array.InternalArray__ICollection_Add<RpcLinkType>
	|-Array.InternalArray__ICollection_Add<RuleMatcher>
	|-Array.InternalArray__ICollection_Add<RuntimeLabel>
	|-Array.InternalArray__ICollection_Add<sbyte>
	|-Array.InternalArray__ICollection_Add<SByteEnum>
	|-Array.InternalArray__ICollection_Add<SamplePointUData>
	|-Array.InternalArray__ICollection_Add<SamplePointsPatch>
	|-Array.InternalArray__ICollection_Add<ScalableImage>
	|-Array.InternalArray__ICollection_Add<Scale>
	|-Array.InternalArray__ICollection_Add<Scene>
	|-Array.InternalArray__ICollection_Add<SecondarySpriteTexture>
	|-Array.InternalArray__ICollection_Add<SelectorMatchRecord>
	|-Array.InternalArray__ICollection_Add<SemanticMeaning>
	|-Array.InternalArray__ICollection_Add<ShaderKeyword>
	|-Array.InternalArray__ICollection_Add<ShaderTagId>
	|-Array.InternalArray__ICollection_Add<ShaderVariablesProbeVolumes>
	|-Array.InternalArray__ICollection_Add<ShadowSliceData>
	|-Array.InternalArray__ICollection_Add<float>
	|-Array.InternalArray__ICollection_Add<SkeletonBone>
	|-Array.InternalArray__ICollection_Add<SortingLayer>
	|-Array.InternalArray__ICollection_Add<SpriteState>
	|-Array.InternalArray__ICollection_Add<SqlBinary>
	|-Array.InternalArray__ICollection_Add<SqlBoolean>
	|-Array.InternalArray__ICollection_Add<SqlByte>
	|-Array.InternalArray__ICollection_Add<SqlDateTime>
	|-Array.InternalArray__ICollection_Add<SqlDecimal>
	|-Array.InternalArray__ICollection_Add<SqlDouble>
	|-Array.InternalArray__ICollection_Add<SqlGuid>
	|-Array.InternalArray__ICollection_Add<SqlInt16>
	|-Array.InternalArray__ICollection_Add<SqlInt32>
	|-Array.InternalArray__ICollection_Add<SqlInt64>
	|-Array.InternalArray__ICollection_Add<SqlMoney>
	|-Array.InternalArray__ICollection_Add<SqlSingle>
	|-Array.InternalArray__ICollection_Add<SqlString>
	|-Array.InternalArray__ICollection_Add<SteamItemDef_t>
	|-Array.InternalArray__ICollection_Add<SteamItemDetails_t>
	|-Array.InternalArray__ICollection_Add<SteamItemInstanceID_t>
	|-Array.InternalArray__ICollection_Add<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__ICollection_Add<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__ICollection_Add<StylePropertyName>
	|-Array.InternalArray__ICollection_Add<StylePropertyValue>
	|-Array.InternalArray__ICollection_Add<StyleSelectorPart>
	|-Array.InternalArray__ICollection_Add<StyleSyntaxToken>
	|-Array.InternalArray__ICollection_Add<StyleValue>
	|-Array.InternalArray__ICollection_Add<StyleValueHandle>
	|-Array.InternalArray__ICollection_Add<StyleValueManaged>
	|-Array.InternalArray__ICollection_Add<StyleVariable>
	|-Array.InternalArray__ICollection_Add<Substring>
	|-Array.InternalArray__ICollection_Add<TMP_CharacterInfo>
	|-Array.InternalArray__ICollection_Add<TMP_FontWeightPair>
	|-Array.InternalArray__ICollection_Add<TMP_LineInfo>
	|-Array.InternalArray__ICollection_Add<TMP_LinkInfo>
	|-Array.InternalArray__ICollection_Add<TMP_MeshInfo>
	|-Array.InternalArray__ICollection_Add<TMP_PageInfo>
	|-Array.InternalArray__ICollection_Add<TMP_WordInfo>
	|-Array.InternalArray__ICollection_Add<TemperatureEmitterInfo>
	|-Array.InternalArray__ICollection_Add<TerrainTileCoord>
	|-Array.InternalArray__ICollection_Add<TextElementInfo>
	|-Array.InternalArray__ICollection_Add<TextProcessingElement>
	|-Array.InternalArray__ICollection_Add<TextShadow>
	|-Array.InternalArray__ICollection_Add<TextureHandle>
	|-Array.InternalArray__ICollection_Add<TextureId>
	|-Array.InternalArray__ICollection_Add<TileData>
	|-Array.InternalArray__ICollection_Add<TimeSpan>
	|-Array.InternalArray__ICollection_Add<TimeValue>
	|-Array.InternalArray__ICollection_Add<Touch>
	|-Array.InternalArray__ICollection_Add<Touch>
	|-Array.InternalArray__ICollection_Add<Transform3x4>
	|-Array.InternalArray__ICollection_Add<TransformOrigin>
	|-Array.InternalArray__ICollection_Add<Translate>
	|-Array.InternalArray__ICollection_Add<TreeInstance>
	|-Array.InternalArray__ICollection_Add<TreeItem>
	|-Array.InternalArray__ICollection_Add<TreeViewItemWrapper>
	|-Array.InternalArray__ICollection_Add<UEncroachingSegment>
	|-Array.InternalArray__ICollection_Add<UEvent>
	|-Array.InternalArray__ICollection_Add<UHull>
	|-Array.InternalArray__ICollection_Add<UICharInfo>
	|-Array.InternalArray__ICollection_Add<UILineInfo>
	|-Array.InternalArray__ICollection_Add<UIVertex>
	|-Array.InternalArray__ICollection_Add<ushort>
	|-Array.InternalArray__ICollection_Add<UInt16Enum>
	|-Array.InternalArray__ICollection_Add<uint>
	|-Array.InternalArray__ICollection_Add<UInt32Enum>
	|-Array.InternalArray__ICollection_Add<ulong>
	|-Array.InternalArray__ICollection_Add<UShort2>
	|-Array.InternalArray__ICollection_Add<UStar>
	|-Array.InternalArray__ICollection_Add<UTriangle>
	|-Array.InternalArray__ICollection_Add<UnloadedScene>
	|-Array.InternalArray__ICollection_Add<UsageHint>
	|-Array.InternalArray__ICollection_Add<Vector2>
	|-Array.InternalArray__ICollection_Add<Vector2Int>
	|-Array.InternalArray__ICollection_Add<Vector3>
	|-Array.InternalArray__ICollection_Add<Vector3Int>
	|-Array.InternalArray__ICollection_Add<Vector4>
	|-Array.InternalArray__ICollection_Add<VectorImageVertex>
	|-Array.InternalArray__ICollection_Add<Vertex>
	|-Array.InternalArray__ICollection_Add<VertexAttributeDescriptor>
	|-Array.InternalArray__ICollection_Add<VisibleLight>
	|-Array.InternalArray__ICollection_Add<VisibleReflectionProbe>
	|-Array.InternalArray__ICollection_Add<VoxelContour>
	|-Array.InternalArray__ICollection_Add<Win32_IP_ADAPTER_ADDRESSES>
	|-Array.InternalArray__ICollection_Add<WordInfo>
	|-Array.InternalArray__ICollection_Add<WordWrapState>
	|-Array.InternalArray__ICollection_Add<WordWrapState>
	|-Array.InternalArray__ICollection_Add<X509ChainStatus>
	|-Array.InternalArray__ICollection_Add<XEvent>
	|-Array.InternalArray__ICollection_Add<XPathNode>
	|-Array.InternalArray__ICollection_Add<XPathNodeRef>
	|-Array.InternalArray__ICollection_Add<XRFeatureDescriptor>
	|-Array.InternalArray__ICollection_Add<XRView>
	|-Array.InternalArray__ICollection_Add<ZipGenericExtraField>
	|-Array.InternalArray__ICollection_Add<__Il2CppFullySharedGenericType>
	|-Array.InternalArray__ICollection_Add<double2>
	|-Array.InternalArray__ICollection_Add<float2>
	|-Array.InternalArray__ICollection_Add<float3>
	|-Array.InternalArray__ICollection_Add<float4>
	|-Array.InternalArray__ICollection_Add<float4x4>
	|-Array.InternalArray__ICollection_Add<int2>
	|-Array.InternalArray__ICollection_Add<int3>
	|-Array.InternalArray__ICollection_Add<int4>
	|-Array.InternalArray__ICollection_Add<jvalue>
	|-Array.InternalArray__ICollection_Add<quaternion>
	|-Array.InternalArray__ICollection_Add<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__ICollection_Add<AdvancedSmooth.Turn>
	|-Array.InternalArray__ICollection_Add<Agent.VO>
	|-Array.InternalArray__ICollection_Add<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__ICollection_Add<AnimationWarping.Warp>
	|-Array.InternalArray__ICollection_Add<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__ICollection_Add<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__ICollection_Add<AstarDebugger.GraphPoint>
	|-Array.InternalArray__ICollection_Add<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__ICollection_Add<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__ICollection_Add<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__ICollection_Add<AvatarSettings.LayerSetting>
	|-Array.InternalArray__ICollection_Add<BBTree.BBTreeBox>
	|-Array.InternalArray__ICollection_Add<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__ICollection_Add<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__ICollection_Add<BinaryHeap.Tuple>
	|-Array.InternalArray__ICollection_Add<BitmapAllocator32.Page>
	|-Array.InternalArray__ICollection_Add<BlitUtility.Vertex>
	|-Array.InternalArray__ICollection_Add<BloomRenderer.Level>
	|-Array.InternalArray__ICollection_Add<CameraState.CustomBlendable>
	|-Array.InternalArray__ICollection_Add<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__ICollection_Add<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__ICollection_Add<CinemachineClearShot.Pair>
	|-Array.InternalArray__ICollection_Add<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__ICollection_Add<CinemachinePath.Waypoint>
	|-Array.InternalArray__ICollection_Add<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__ICollection_Add<CinemachineTargetGroup.Target>
	|-Array.InternalArray__ICollection_Add<ClipperLib.DoublePoint>
	|-Array.InternalArray__ICollection_Add<ClipperLib.IntPoint>
	|-Array.InternalArray__ICollection_Add<CodePointIndexer.TableRange>
	|-Array.InternalArray__ICollection_Add<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__ICollection_Add<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__ICollection_Add<Cursor.CursorEntry>
	|-Array.InternalArray__ICollection_Add<Cursor.CursorImage>
	|-Array.InternalArray__ICollection_Add<DataError.ColumnError>
	|-Array.InternalArray__ICollection_Add<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__ICollection_Add<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__ICollection_Add<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__ICollection_Add<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__ICollection_Add<EventDispatcher.DispatchContext>
	|-Array.InternalArray__ICollection_Add<EventDispatcher.EventRecord>
	|-Array.InternalArray__ICollection_Add<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__ICollection_Add<ExpressionParser.ReservedWords>
	|-Array.InternalArray__ICollection_Add<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__ICollection_Add<FocusController.FocusedElement>
	|-Array.InternalArray__ICollection_Add<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__ICollection_Add<Funnel.PathPart>
	|-Array.InternalArray__ICollection_Add<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__ICollection_Add<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__ICollection_Add<GrounderQuadruped.Foot>
	|-Array.InternalArray__ICollection_Add<GtkPlus.GdkColor>
	|-Array.InternalArray__ICollection_Add<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__ICollection_Add<HID.HIDElementDescriptor>
	|-Array.InternalArray__ICollection_Add<HIDParser.HIDReportData>
	|-Array.InternalArray__ICollection_Add<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__ICollection_Add<Hammersley.Hammersley2dSeq16>
	|-Array.InternalArray__ICollection_Add<Hammersley.Hammersley2dSeq256>
	|-Array.InternalArray__ICollection_Add<Hammersley.Hammersley2dSeq32>
	|-Array.InternalArray__ICollection_Add<Hammersley.Hammersley2dSeq64>
	|-Array.InternalArray__ICollection_Add<Hashtable.bucket>
	|-Array.InternalArray__ICollection_Add<HeadingTracker.Item>
	|-Array.InternalArray__ICollection_Add<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__ICollection_Add<HebrewNumber.HebrewValue>
	|-Array.InternalArray__ICollection_Add<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__ICollection_Add<Icon.IconDirEntry>
	|-Array.InternalArray__ICollection_Add<InputActionMap.BindingJson>
	|-Array.InternalArray__ICollection_Add<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__ICollection_Add<InputActionMap.ReadActionJson>
	|-Array.InternalArray__ICollection_Add<InputActionMap.ReadMapJson>
	|-Array.InternalArray__ICollection_Add<InputActionMap.WriteActionJson>
	|-Array.InternalArray__ICollection_Add<InputActionMap.WriteMapJson>
	|-Array.InternalArray__ICollection_Add<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__ICollection_Add<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__ICollection_Add<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__ICollection_Add<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__ICollection_Add<InputControlLayout.ControlItem>
	|-Array.InternalArray__ICollection_Add<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__ICollection_Add<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__ICollection_Add<InputControlScheme.SchemeJson>
	|-Array.InternalArray__ICollection_Add<InputDevice.ControlBitRangeNode>
	|-Array.InternalArray__ICollection_Add<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__ICollection_Add<InputManager.AvailableDevice>
	|-Array.InternalArray__ICollection_Add<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__ICollection_Add<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__ICollection_Add<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__ICollection_Add<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__ICollection_Add<InputRemoting.RemoteSender>
	|-Array.InternalArray__ICollection_Add<InputStateHistory.Record>
	|-Array.InternalArray__ICollection_Add<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__ICollection_Add<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__ICollection_Add<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__ICollection_Add<InputUser.UserData>
	|-Array.InternalArray__ICollection_Add<JsonParser.JsonValue>
	|-Array.InternalArray__ICollection_Add<LatencySimulator.Message>
	|-Array.InternalArray__ICollection_Add<LayerGridGraph.HeightSample>
	|-Array.InternalArray__ICollection_Add<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__ICollection_Add<LightUtility.LightMeshVertex>
	|-Array.InternalArray__ICollection_Add<LiquidVolume.MeshCache>
	|-Array.InternalArray__ICollection_Add<ListView.ItemMatrixLocation>
	|-Array.InternalArray__ICollection_Add<MemoryHelpers.BitRegion>
	|-Array.InternalArray__ICollection_Add<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__ICollection_Add<Multipass.TransportIdData>
	|-Array.InternalArray__ICollection_Add<NatPunchModule.RequestEventData>
	|-Array.InternalArray__ICollection_Add<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__ICollection_Add<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__ICollection_Add<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__ICollection_Add<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__ICollection_Add<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__ICollection_Add<NetworkAnimator.StateChange>
	|-Array.InternalArray__ICollection_Add<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__ICollection_Add<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__ICollection_Add<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__ICollection_Add<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__ICollection_Add<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__ICollection_Add<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__ICollection_Add<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__ICollection_Add<PlayingCard.CardData>
	|-Array.InternalArray__ICollection_Add<PointKDTree.Node>
	|-Array.InternalArray__ICollection_Add<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__ICollection_Add<ProbeBrickIndex.Brick>
	|-Array.InternalArray__ICollection_Add<ProbeBrickIndex.ReservedBrick>
	|-Array.InternalArray__ICollection_Add<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__ICollection_Add<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__ICollection_Add<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__ICollection_Add<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__ICollection_Add<RVOQuadtree.Node>
	|-Array.InternalArray__ICollection_Add<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__ICollection_Add<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__ICollection_Add<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__ICollection_Add<RegexCharClass.SingleRange>
	|-Array.InternalArray__ICollection_Add<ReliableChannel.PendingPacket>
	|-Array.InternalArray__ICollection_Add<RenderChain.RenderNodeData>
	|-Array.InternalArray__ICollection_Add<RenderGraph.CompiledPassInfo>
	|-Array.InternalArray__ICollection_Add<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__ICollection_Add<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__ICollection_Add<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__ICollection_Add<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__ICollection_Add<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__ICollection_Add<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__ICollection_Add<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.ClipData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__ICollection_Add<SVGDocument.MaskData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.NodeGlobalSceneState>
	|-Array.InternalArray__ICollection_Add<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.NodeWithParent>
	|-Array.InternalArray__ICollection_Add<SVGDocument.PatternData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.PostponedClip>
	|-Array.InternalArray__ICollection_Add<SVGDocument.PostponedStopData>
	|-Array.InternalArray__ICollection_Add<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__ICollection_Add<SendMouseEvents.HitInfo>
	|-Array.InternalArray__ICollection_Add<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__ICollection_Add<ServerSocket.ConnectionChange>
	|-Array.InternalArray__ICollection_Add<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__ICollection_Add<ShaderInput.LightData>
	|-Array.InternalArray__ICollection_Add<ShadowUtility.Edge>
	|-Array.InternalArray__ICollection_Add<Socket.WSABUF>
	|-Array.InternalArray__ICollection_Add<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__ICollection_Add<StructySync.ChangeData>
	|-Array.InternalArray__ICollection_Add<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__ICollection_Add<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__ICollection_Add<StyleSheet.ImportStruct>
	|-Array.InternalArray__ICollection_Add<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__ICollection_Add<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__ICollection_Add<SyncStopwatch.ChangeData>
	|-Array.InternalArray__ICollection_Add<SyncTimer.ChangeData>
	|-Array.InternalArray__ICollection_Add<Syscall._pollfd>
	|-Array.InternalArray__ICollection_Add<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__ICollection_Add<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Add<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__ICollection_Add<TargetStateListener.Callback>
	|-Array.InternalArray__ICollection_Add<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__ICollection_Add<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Add<TextSettings.FontReferenceMap>
	|-Array.InternalArray__ICollection_Add<TextureBlitter.BlitInfo>
	|-Array.InternalArray__ICollection_Add<TexturePacker_JsonArray.Frame>
	|-Array.InternalArray__ICollection_Add<TextureRegistry.TextureInfo>
	|-Array.InternalArray__ICollection_Add<Tilemap.SyncTile>
	|-Array.InternalArray__ICollection_Add<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__ICollection_Add<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__ICollection_Add<TransportManager.DisconnectingClient>
	|-Array.InternalArray__ICollection_Add<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__ICollection_Add<UIRStylePainter.Entry>
	|-Array.InternalArray__ICollection_Add<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__ICollection_Add<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__ICollection_Add<UIRenderDevice.AllocToUpdate>
	|-Array.InternalArray__ICollection_Add<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__ICollection_Add<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__ICollection_Add<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__ICollection_Add<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__ICollection_Add<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__ICollection_Add<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__ICollection_Add<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__ICollection_Add<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__ICollection_Add<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__ICollection_Add<VolumetricFog.FogOfWarTransition>
	|-Array.InternalArray__ICollection_Add<Win32DnD.FORMATETC>
	|-Array.InternalArray__ICollection_Add<WordStorage.Entry>
	|-Array.InternalArray__ICollection_Add<X11DesktopColors.GdkColorStruct>
	|-Array.InternalArray__ICollection_Add<XmlEventCache.XmlEvent>
	|-Array.InternalArray__ICollection_Add<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__ICollection_Add<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__ICollection_Add<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__ICollection_Add<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__ICollection_Add<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__ICollection_Add<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__ICollection_Add<XmlTextReaderImpl.ParsingState>
	|-Array.InternalArray__ICollection_Add<XmlTextWriter.Namespace>
	|-Array.InternalArray__ICollection_Add<XmlTextWriter.TagInfo>
	|-Array.InternalArray__ICollection_Add<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__ICollection_Add<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__ICollection_Add<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__ICollection_Add<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__ICollection_Add<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__ICollection_Add<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-Array.InternalArray__ICollection_Add<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__ICollection_Add<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__ICollection_Add<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__ICollection_Add<InputControlLayout.Collection.LayoutMatcher>
	|-Array.InternalArray__ICollection_Add<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__ICollection_Add<InputControlScheme.MatchResult.Match>
	|-Array.InternalArray__ICollection_Add<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__ICollection_Add<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__ICollection_Add<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__ICollection_Add<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__ICollection_Add<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheCurve.Item>
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheEntry.RecordingItem>
	|-Array.InternalArray__ICollection_Add<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Remove<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5610 Offset: 0xFB4010 VA: 0x180FB5610
	|-Array.InternalArray__ICollection_Remove<ArraySegment<byte>>
	|-Array.InternalArray__ICollection_Remove<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__ICollection_Remove<SyncList.ChangeData<int>>
	|-Array.InternalArray__ICollection_Remove<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__ICollection_Remove<IntervalTree.Entry<object>>
	|-Array.InternalArray__ICollection_Remove<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, short>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, long>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, float>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<long, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, double>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, long>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, float>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__ICollection_Remove<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Guid, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int2, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int2, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int3, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, bool>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, short>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Int3>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, long>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, float>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, uint>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, ulong>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<long, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, bool>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, char>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Color32>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, double>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, long>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Playable>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Rect>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, float>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Rect, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Scene, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ushort, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Remove<KeyValue<int, int>>
	|-Array.InternalArray__ICollection_Remove<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Remove<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Remove<NativeArray<NudgeJobData>>
	|-Array.InternalArray__ICollection_Remove<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Remove<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Remove<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__ICollection_Remove<RBTree.Node<int>>
	|-Array.InternalArray__ICollection_Remove<RBTree.Node<object>>
	|-Array.InternalArray__ICollection_Remove<Nullable<DateTime>>
	|-Array.InternalArray__ICollection_Remove<Nullable<Decimal>>
	|-Array.InternalArray__ICollection_Remove<TempAllocator.Page<ushort>>
	|-Array.InternalArray__ICollection_Remove<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__ICollection_Remove<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__ICollection_Remove<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<bool>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__ICollection_Remove<Set.Slot<char>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<int>>
	|-Array.InternalArray__ICollection_Remove<Set.Slot<int>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<InternedString>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<object>>
	|-Array.InternalArray__ICollection_Remove<Set.Slot<object>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Scene>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<uint>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<ulong>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__ICollection_Remove<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__ICollection_Remove<StructMultiKey<object, object>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__ICollection_Remove<SubArray<int>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Remove<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__ICollection_Remove<TreeViewItemData<object>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, int>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, object>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Scene>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, int>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object>>
	|-Array.InternalArray__ICollection_Remove<AnimatorClipInfo>
	|-Array.InternalArray__ICollection_Remove<AppId_t>
	|-Array.InternalArray__ICollection_Remove<AstarWorkItem>
	|-Array.InternalArray__ICollection_Remove<AsyncGPUReadbackRequest>
	|-Array.InternalArray__ICollection_Remove<AttachmentDescriptor>
	|-Array.InternalArray__ICollection_Remove<Background>
	|-Array.InternalArray__ICollection_Remove<BackgroundPosition>
	|-Array.InternalArray__ICollection_Remove<BackgroundRepeat>
	|-Array.InternalArray__ICollection_Remove<BackgroundSize>
	|-Array.InternalArray__ICollection_Remove<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__ICollection_Remove<BezierContour>
	|-Array.InternalArray__ICollection_Remove<BezierPathSegment>
	|-Array.InternalArray__ICollection_Remove<BezierSegment>
	|-Array.InternalArray__ICollection_Remove<BigInteger>
	|-Array.InternalArray__ICollection_Remove<Board>
	|-Array.InternalArray__ICollection_Remove<bool>
	|-Array.InternalArray__ICollection_Remove<BoundingSphere>
	|-Array.InternalArray__ICollection_Remove<Bounds>
	|-Array.InternalArray__ICollection_Remove<BoundsInt>
	|-Array.InternalArray__ICollection_Remove<byte>
	|-Array.InternalArray__ICollection_Remove<ByteEnum>
	|-Array.InternalArray__ICollection_Remove<CGSpot>
	|-Array.InternalArray__ICollection_Remove<CSteamID>
	|-Array.InternalArray__ICollection_Remove<char>
	|-Array.InternalArray__ICollection_Remove<Color>
	|-Array.InternalArray__ICollection_Remove<Color>
	|-Array.InternalArray__ICollection_Remove<Color32>
	|-Array.InternalArray__ICollection_Remove<ColorBlock>
	|-Array.InternalArray__ICollection_Remove<CombineInstance>
	|-Array.InternalArray__ICollection_Remove<CompactVoxelCell>
	|-Array.InternalArray__ICollection_Remove<CompactVoxelSpan>
	|-Array.InternalArray__ICollection_Remove<ComputedStyle>
	|-Array.InternalArray__ICollection_Remove<ComputedTransitionProperty>
	|-Array.InternalArray__ICollection_Remove<Connection>
	|-Array.InternalArray__ICollection_Remove<ContactPairHeader>
	|-Array.InternalArray__ICollection_Remove<ContactPoint>
	|-Array.InternalArray__ICollection_Remove<ContactPoint2D>
	|-Array.InternalArray__ICollection_Remove<ContourVertex>
	|-Array.InternalArray__ICollection_Remove<ContourVertex>
	|-Array.InternalArray__ICollection_Remove<ControlPointOption>
	|-Array.InternalArray__ICollection_Remove<ConvertMeshJobData>
	|-Array.InternalArray__ICollection_Remove<CoordinateFootprintTilePair>
	|-Array.InternalArray__ICollection_Remove<CoordinateProceduralTilePair>
	|-Array.InternalArray__ICollection_Remove<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__ICollection_Remove<CoordinateStorageTilePair>
	|-Array.InternalArray__ICollection_Remove<CoordinateTilePair>
	|-Array.InternalArray__ICollection_Remove<CopyClosingMeshJobData>
	|-Array.InternalArray__ICollection_Remove<CullingSplit>
	|-Array.InternalArray__ICollection_Remove<CustomAttributeNamedArgument>
	|-Array.InternalArray__ICollection_Remove<CustomAttributeTypedArgument>
	|-Array.InternalArray__ICollection_Remove<DateTime>
	|-Array.InternalArray__ICollection_Remove<DateTimeOffset>
	|-Array.InternalArray__ICollection_Remove<DecalEntity>
	|-Array.InternalArray__ICollection_Remove<DecalSubDrawCall>
	|-Array.InternalArray__ICollection_Remove<Decimal>
	|-Array.InternalArray__ICollection_Remove<DepotId_t>
	|-Array.InternalArray__ICollection_Remove<DictionaryEntry>
	|-Array.InternalArray__ICollection_Remove<Dimension>
	|-Array.InternalArray__ICollection_Remove<DisplayInfo>
	|-Array.InternalArray__ICollection_Remove<double>
	|-Array.InternalArray__ICollection_Remove<DoublePoint>
	|-Array.InternalArray__ICollection_Remove<DoublePoint>
	|-Array.InternalArray__ICollection_Remove<DrawBufferRange>
	|-Array.InternalArray__ICollection_Remove<DualPrefab>
	|-Array.InternalArray__ICollection_Remove<DuplicateSamplePoint>
	|-Array.InternalArray__ICollection_Remove<EasingFunction>
	|-Array.InternalArray__ICollection_Remove<Entry>
	|-Array.InternalArray__ICollection_Remove<EnumData>
	|-Array.InternalArray__ICollection_Remove<Ephemeron>
	|-Array.InternalArray__ICollection_Remove<EventSummary>
	|-Array.InternalArray__ICollection_Remove<EventTypeSpec>
	|-Array.InternalArray__ICollection_Remove<ExtensionFilter>
	|-Array.InternalArray__ICollection_Remove<FixedString128Bytes>
	|-Array.InternalArray__ICollection_Remove<FontDefinition>
	|-Array.InternalArray__ICollection_Remove<FontWeightPair>
	|-Array.InternalArray__ICollection_Remove<FrameTimeSample>
	|-Array.InternalArray__ICollection_Remove<FrameTiming>
	|-Array.InternalArray__ICollection_Remove<FullRank>
	|-Array.InternalArray__ICollection_Remove<GCHandle>
	|-Array.InternalArray__ICollection_Remove<GfxUpdateBufferRange>
	|-Array.InternalArray__ICollection_Remove<GlyphMarshallingStruct>
	|-Array.InternalArray__ICollection_Remove<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__ICollection_Remove<GlyphRect>
	|-Array.InternalArray__ICollection_Remove<GradientAlphaKey>
	|-Array.InternalArray__ICollection_Remove<GradientColorKey>
	|-Array.InternalArray__ICollection_Remove<GradientSettings>
	|-Array.InternalArray__ICollection_Remove<GradientStop>
	|-Array.InternalArray__ICollection_Remove<Guid>
	|-Array.InternalArray__ICollection_Remove<HSteamNetConnection>
	|-Array.InternalArray__ICollection_Remove<Hash128>
	|-Array.InternalArray__ICollection_Remove<HeaderVariantInfo>
	|-Array.InternalArray__ICollection_Remove<HighlightState>
	|-Array.InternalArray__ICollection_Remove<HighlightState>
	|-Array.InternalArray__ICollection_Remove<HumanBone>
	|-Array.InternalArray__ICollection_Remove<InclusiveRange>
	|-Array.InternalArray__ICollection_Remove<IndexField>
	|-Array.InternalArray__ICollection_Remove<IndexRange>
	|-Array.InternalArray__ICollection_Remove<InputActionSetHandle_t>
	|-Array.InternalArray__ICollection_Remove<InputBinding>
	|-Array.InternalArray__ICollection_Remove<InputControlScheme>
	|-Array.InternalArray__ICollection_Remove<InputDeviceDescription>
	|-Array.InternalArray__ICollection_Remove<InputEventPtr>
	|-Array.InternalArray__ICollection_Remove<InputHandle_t>
	|-Array.InternalArray__ICollection_Remove<InputUser>
	|-Array.InternalArray__ICollection_Remove<short>
	|-Array.InternalArray__ICollection_Remove<Int2>
	|-Array.InternalArray__ICollection_Remove<Int3>
	|-Array.InternalArray__ICollection_Remove<int>
	|-Array.InternalArray__ICollection_Remove<Int32Enum>
	|-Array.InternalArray__ICollection_Remove<long>
	|-Array.InternalArray__ICollection_Remove<IntPoint>
	|-Array.InternalArray__ICollection_Remove<IntPoint>
	|-Array.InternalArray__ICollection_Remove<IntPtr>
	|-Array.InternalArray__ICollection_Remove<IntRect>
	|-Array.InternalArray__ICollection_Remove<IntRegion>
	|-Array.InternalArray__ICollection_Remove<InternalCodePageDataItem>
	|-Array.InternalArray__ICollection_Remove<InternalEncodingDataItem>
	|-Array.InternalArray__ICollection_Remove<InternedString>
	|-Array.InternalArray__ICollection_Remove<InterpretedFrameInfo>
	|-Array.InternalArray__ICollection_Remove<IntervalTreeNode>
	|-Array.InternalArray__ICollection_Remove<JobHandle>
	|-Array.InternalArray__ICollection_Remove<JsonPosition>
	|-Array.InternalArray__ICollection_Remove<KeyStruct>
	|-Array.InternalArray__ICollection_Remove<Keyframe>
	|-Array.InternalArray__ICollection_Remove<Label>
	|-Array.InternalArray__ICollection_Remove<LayerBatch>
	|-Array.InternalArray__ICollection_Remove<LayerMask>
	|-Array.InternalArray__ICollection_Remove<Length>
	|-Array.InternalArray__ICollection_Remove<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Remove<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Remove<Light2DBlendStyle>
	|-Array.InternalArray__ICollection_Remove<LightDataGI>
	|-Array.InternalArray__ICollection_Remove<LineInfo>
	|-Array.InternalArray__ICollection_Remove<LinkInfo>
	|-Array.InternalArray__ICollection_Remove<LinkedVoxelSpan>
	|-Array.InternalArray__ICollection_Remove<List>
	|-Array.InternalArray__ICollection_Remove<LocalDefinition>
	|-Array.InternalArray__ICollection_Remove<LocalKeyword>
	|-Array.InternalArray__ICollection_Remove<LocalPacket>
	|-Array.InternalArray__ICollection_Remove<LocalPacket>
	|-Array.InternalArray__ICollection_Remove<ManipulatorActivationFilter>
	|-Array.InternalArray__ICollection_Remove<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Remove<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Remove<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Remove<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Remove<MarkupAttribute>
	|-Array.InternalArray__ICollection_Remove<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__ICollection_Remove<MaterialReference>
	|-Array.InternalArray__ICollection_Remove<MaterialReference>
	|-Array.InternalArray__ICollection_Remove<Matrix4x4>
	|-Array.InternalArray__ICollection_Remove<MeshInfo>
	|-Array.InternalArray__ICollection_Remove<ModifiableContactPair>
	|-Array.InternalArray__ICollection_Remove<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Remove<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Remove<NameAndParameters>
	|-Array.InternalArray__ICollection_Remove<NamedValue>
	|-Array.InternalArray__ICollection_Remove<NativeAddr>
	|-Array.InternalArray__ICollection_Remove<NavMeshBuildMarkup>
	|-Array.InternalArray__ICollection_Remove<NavMeshBuildSource>
	|-Array.InternalArray__ICollection_Remove<Navigation>
	|-Array.InternalArray__ICollection_Remove<NudgeJobData>
	|-Array.InternalArray__ICollection_Remove<object>
	|-Array.InternalArray__ICollection_Remove<Packet>
	|-Array.InternalArray__ICollection_Remove<PageInfo>
	|-Array.InternalArray__ICollection_Remove<ParameterModifier>
	|-Array.InternalArray__ICollection_Remove<Plane>
	|-Array.InternalArray__ICollection_Remove<Playable>
	|-Array.InternalArray__ICollection_Remove<PlayableBinding>
	|-Array.InternalArray__ICollection_Remove<PlayerLoopSystem>
	|-Array.InternalArray__ICollection_Remove<PlayerLoopSystemInternal>
	|-Array.InternalArray__ICollection_Remove<Point>
	|-Array.InternalArray__ICollection_Remove<PointF>
	|-Array.InternalArray__ICollection_Remove<PointerModel>
	|-Array.InternalArray__ICollection_Remove<Pollfd>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__ICollection_Remove<Progress>
	|-Array.InternalArray__ICollection_Remove<PublishedFileId_t>
	|-Array.InternalArray__ICollection_Remove<QosResult>
	|-Array.InternalArray__ICollection_Remove<Quaternion>
	|-Array.InternalArray__ICollection_Remove<RangePositionInfo>
	|-Array.InternalArray__ICollection_Remove<RaycastHit>
	|-Array.InternalArray__ICollection_Remove<RaycastHit2D>
	|-Array.InternalArray__ICollection_Remove<RaycastResult>
	|-Array.InternalArray__ICollection_Remove<Rect>
	|-Array.InternalArray__ICollection_Remove<RectInt>
	|-Array.InternalArray__ICollection_Remove<Rectangle>
	|-Array.InternalArray__ICollection_Remove<RemoteConnectionEvent>
	|-Array.InternalArray__ICollection_Remove<RenderBuffer>
	|-Array.InternalArray__ICollection_Remove<RenderInstancedDataLayout>
	|-Array.InternalArray__ICollection_Remove<RenderStateBlock>
	|-Array.InternalArray__ICollection_Remove<RenderTargetIdentifier>
	|-Array.InternalArray__ICollection_Remove<RendererList>
	|-Array.InternalArray__ICollection_Remove<RendererListHandle>
	|-Array.InternalArray__ICollection_Remove<RendererListResource>
	|-Array.InternalArray__ICollection_Remove<Resolution>
	|-Array.InternalArray__ICollection_Remove<ResourceHandle>
	|-Array.InternalArray__ICollection_Remove<ResourceLocator>
	|-Array.InternalArray__ICollection_Remove<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Remove<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Remove<Rigidbody2DState>
	|-Array.InternalArray__ICollection_Remove<RigidbodyState>
	|-Array.InternalArray__ICollection_Remove<Rotate>
	|-Array.InternalArray__ICollection_Remove<RpcLink>
	|-Array.InternalArray__ICollection_Remove<RpcLinkType>
	|-Array.InternalArray__ICollection_Remove<RuleMatcher>
	|-Array.InternalArray__ICollection_Remove<RuntimeLabel>
	|-Array.InternalArray__ICollection_Remove<sbyte>
	|-Array.InternalArray__ICollection_Remove<SByteEnum>
	|-Array.InternalArray__ICollection_Remove<SamplePointUData>
	|-Array.InternalArray__ICollection_Remove<SamplePointsPatch>
	|-Array.InternalArray__ICollection_Remove<ScalableImage>
	|-Array.InternalArray__ICollection_Remove<Scale>
	|-Array.InternalArray__ICollection_Remove<Scene>
	|-Array.InternalArray__ICollection_Remove<SecondarySpriteTexture>
	|-Array.InternalArray__ICollection_Remove<SelectorMatchRecord>
	|-Array.InternalArray__ICollection_Remove<SemanticMeaning>
	|-Array.InternalArray__ICollection_Remove<ShaderKeyword>
	|-Array.InternalArray__ICollection_Remove<ShaderTagId>
	|-Array.InternalArray__ICollection_Remove<ShaderVariablesProbeVolumes>
	|-Array.InternalArray__ICollection_Remove<ShadowSliceData>
	|-Array.InternalArray__ICollection_Remove<float>
	|-Array.InternalArray__ICollection_Remove<SkeletonBone>
	|-Array.InternalArray__ICollection_Remove<SortingLayer>
	|-Array.InternalArray__ICollection_Remove<SpriteState>
	|-Array.InternalArray__ICollection_Remove<SqlBinary>
	|-Array.InternalArray__ICollection_Remove<SqlBoolean>
	|-Array.InternalArray__ICollection_Remove<SqlByte>
	|-Array.InternalArray__ICollection_Remove<SqlDateTime>
	|-Array.InternalArray__ICollection_Remove<SqlDecimal>
	|-Array.InternalArray__ICollection_Remove<SqlDouble>
	|-Array.InternalArray__ICollection_Remove<SqlGuid>
	|-Array.InternalArray__ICollection_Remove<SqlInt16>
	|-Array.InternalArray__ICollection_Remove<SqlInt32>
	|-Array.InternalArray__ICollection_Remove<SqlInt64>
	|-Array.InternalArray__ICollection_Remove<SqlMoney>
	|-Array.InternalArray__ICollection_Remove<SqlSingle>
	|-Array.InternalArray__ICollection_Remove<SqlString>
	|-Array.InternalArray__ICollection_Remove<SteamItemDef_t>
	|-Array.InternalArray__ICollection_Remove<SteamItemDetails_t>
	|-Array.InternalArray__ICollection_Remove<SteamItemInstanceID_t>
	|-Array.InternalArray__ICollection_Remove<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__ICollection_Remove<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__ICollection_Remove<StylePropertyName>
	|-Array.InternalArray__ICollection_Remove<StylePropertyValue>
	|-Array.InternalArray__ICollection_Remove<StyleSelectorPart>
	|-Array.InternalArray__ICollection_Remove<StyleSyntaxToken>
	|-Array.InternalArray__ICollection_Remove<StyleValue>
	|-Array.InternalArray__ICollection_Remove<StyleValueHandle>
	|-Array.InternalArray__ICollection_Remove<StyleValueManaged>
	|-Array.InternalArray__ICollection_Remove<StyleVariable>
	|-Array.InternalArray__ICollection_Remove<Substring>
	|-Array.InternalArray__ICollection_Remove<TMP_CharacterInfo>
	|-Array.InternalArray__ICollection_Remove<TMP_FontWeightPair>
	|-Array.InternalArray__ICollection_Remove<TMP_LineInfo>
	|-Array.InternalArray__ICollection_Remove<TMP_LinkInfo>
	|-Array.InternalArray__ICollection_Remove<TMP_MeshInfo>
	|-Array.InternalArray__ICollection_Remove<TMP_PageInfo>
	|-Array.InternalArray__ICollection_Remove<TMP_WordInfo>
	|-Array.InternalArray__ICollection_Remove<TemperatureEmitterInfo>
	|-Array.InternalArray__ICollection_Remove<TerrainTileCoord>
	|-Array.InternalArray__ICollection_Remove<TextElementInfo>
	|-Array.InternalArray__ICollection_Remove<TextProcessingElement>
	|-Array.InternalArray__ICollection_Remove<TextShadow>
	|-Array.InternalArray__ICollection_Remove<TextureHandle>
	|-Array.InternalArray__ICollection_Remove<TextureId>
	|-Array.InternalArray__ICollection_Remove<TileData>
	|-Array.InternalArray__ICollection_Remove<TimeSpan>
	|-Array.InternalArray__ICollection_Remove<TimeValue>
	|-Array.InternalArray__ICollection_Remove<Touch>
	|-Array.InternalArray__ICollection_Remove<Touch>
	|-Array.InternalArray__ICollection_Remove<Transform3x4>
	|-Array.InternalArray__ICollection_Remove<TransformOrigin>
	|-Array.InternalArray__ICollection_Remove<Translate>
	|-Array.InternalArray__ICollection_Remove<TreeInstance>
	|-Array.InternalArray__ICollection_Remove<TreeItem>
	|-Array.InternalArray__ICollection_Remove<TreeViewItemWrapper>
	|-Array.InternalArray__ICollection_Remove<UEncroachingSegment>
	|-Array.InternalArray__ICollection_Remove<UEvent>
	|-Array.InternalArray__ICollection_Remove<UHull>
	|-Array.InternalArray__ICollection_Remove<UICharInfo>
	|-Array.InternalArray__ICollection_Remove<UILineInfo>
	|-Array.InternalArray__ICollection_Remove<UIVertex>
	|-Array.InternalArray__ICollection_Remove<ushort>
	|-Array.InternalArray__ICollection_Remove<UInt16Enum>
	|-Array.InternalArray__ICollection_Remove<uint>
	|-Array.InternalArray__ICollection_Remove<UInt32Enum>
	|-Array.InternalArray__ICollection_Remove<ulong>
	|-Array.InternalArray__ICollection_Remove<UShort2>
	|-Array.InternalArray__ICollection_Remove<UStar>
	|-Array.InternalArray__ICollection_Remove<UTriangle>
	|-Array.InternalArray__ICollection_Remove<UnloadedScene>
	|-Array.InternalArray__ICollection_Remove<UsageHint>
	|-Array.InternalArray__ICollection_Remove<Vector2>
	|-Array.InternalArray__ICollection_Remove<Vector2Int>
	|-Array.InternalArray__ICollection_Remove<Vector3>
	|-Array.InternalArray__ICollection_Remove<Vector3Int>
	|-Array.InternalArray__ICollection_Remove<Vector4>
	|-Array.InternalArray__ICollection_Remove<VectorImageVertex>
	|-Array.InternalArray__ICollection_Remove<Vertex>
	|-Array.InternalArray__ICollection_Remove<VertexAttributeDescriptor>
	|-Array.InternalArray__ICollection_Remove<VisibleLight>
	|-Array.InternalArray__ICollection_Remove<VisibleReflectionProbe>
	|-Array.InternalArray__ICollection_Remove<VoxelContour>
	|-Array.InternalArray__ICollection_Remove<Win32_IP_ADAPTER_ADDRESSES>
	|-Array.InternalArray__ICollection_Remove<WordInfo>
	|-Array.InternalArray__ICollection_Remove<WordWrapState>
	|-Array.InternalArray__ICollection_Remove<WordWrapState>
	|-Array.InternalArray__ICollection_Remove<X509ChainStatus>
	|-Array.InternalArray__ICollection_Remove<XEvent>
	|-Array.InternalArray__ICollection_Remove<XPathNode>
	|-Array.InternalArray__ICollection_Remove<XPathNodeRef>
	|-Array.InternalArray__ICollection_Remove<XRFeatureDescriptor>
	|-Array.InternalArray__ICollection_Remove<XRView>
	|-Array.InternalArray__ICollection_Remove<ZipGenericExtraField>
	|-Array.InternalArray__ICollection_Remove<__Il2CppFullySharedGenericType>
	|-Array.InternalArray__ICollection_Remove<double2>
	|-Array.InternalArray__ICollection_Remove<float2>
	|-Array.InternalArray__ICollection_Remove<float3>
	|-Array.InternalArray__ICollection_Remove<float4>
	|-Array.InternalArray__ICollection_Remove<float4x4>
	|-Array.InternalArray__ICollection_Remove<int2>
	|-Array.InternalArray__ICollection_Remove<int3>
	|-Array.InternalArray__ICollection_Remove<int4>
	|-Array.InternalArray__ICollection_Remove<jvalue>
	|-Array.InternalArray__ICollection_Remove<quaternion>
	|-Array.InternalArray__ICollection_Remove<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__ICollection_Remove<AdvancedSmooth.Turn>
	|-Array.InternalArray__ICollection_Remove<Agent.VO>
	|-Array.InternalArray__ICollection_Remove<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__ICollection_Remove<AnimationWarping.Warp>
	|-Array.InternalArray__ICollection_Remove<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__ICollection_Remove<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__ICollection_Remove<AstarDebugger.GraphPoint>
	|-Array.InternalArray__ICollection_Remove<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__ICollection_Remove<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__ICollection_Remove<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__ICollection_Remove<AvatarSettings.LayerSetting>
	|-Array.InternalArray__ICollection_Remove<BBTree.BBTreeBox>
	|-Array.InternalArray__ICollection_Remove<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__ICollection_Remove<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__ICollection_Remove<BinaryHeap.Tuple>
	|-Array.InternalArray__ICollection_Remove<BitmapAllocator32.Page>
	|-Array.InternalArray__ICollection_Remove<BlitUtility.Vertex>
	|-Array.InternalArray__ICollection_Remove<BloomRenderer.Level>
	|-Array.InternalArray__ICollection_Remove<CameraState.CustomBlendable>
	|-Array.InternalArray__ICollection_Remove<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__ICollection_Remove<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__ICollection_Remove<CinemachineClearShot.Pair>
	|-Array.InternalArray__ICollection_Remove<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__ICollection_Remove<CinemachinePath.Waypoint>
	|-Array.InternalArray__ICollection_Remove<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__ICollection_Remove<CinemachineTargetGroup.Target>
	|-Array.InternalArray__ICollection_Remove<ClipperLib.DoublePoint>
	|-Array.InternalArray__ICollection_Remove<ClipperLib.IntPoint>
	|-Array.InternalArray__ICollection_Remove<CodePointIndexer.TableRange>
	|-Array.InternalArray__ICollection_Remove<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__ICollection_Remove<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__ICollection_Remove<Cursor.CursorEntry>
	|-Array.InternalArray__ICollection_Remove<Cursor.CursorImage>
	|-Array.InternalArray__ICollection_Remove<DataError.ColumnError>
	|-Array.InternalArray__ICollection_Remove<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__ICollection_Remove<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__ICollection_Remove<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__ICollection_Remove<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__ICollection_Remove<EventDispatcher.DispatchContext>
	|-Array.InternalArray__ICollection_Remove<EventDispatcher.EventRecord>
	|-Array.InternalArray__ICollection_Remove<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__ICollection_Remove<ExpressionParser.ReservedWords>
	|-Array.InternalArray__ICollection_Remove<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__ICollection_Remove<FocusController.FocusedElement>
	|-Array.InternalArray__ICollection_Remove<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__ICollection_Remove<Funnel.PathPart>
	|-Array.InternalArray__ICollection_Remove<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__ICollection_Remove<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__ICollection_Remove<GrounderQuadruped.Foot>
	|-Array.InternalArray__ICollection_Remove<GtkPlus.GdkColor>
	|-Array.InternalArray__ICollection_Remove<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__ICollection_Remove<HID.HIDElementDescriptor>
	|-Array.InternalArray__ICollection_Remove<HIDParser.HIDReportData>
	|-Array.InternalArray__ICollection_Remove<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__ICollection_Remove<Hammersley.Hammersley2dSeq16>
	|-Array.InternalArray__ICollection_Remove<Hammersley.Hammersley2dSeq256>
	|-Array.InternalArray__ICollection_Remove<Hammersley.Hammersley2dSeq32>
	|-Array.InternalArray__ICollection_Remove<Hammersley.Hammersley2dSeq64>
	|-Array.InternalArray__ICollection_Remove<Hashtable.bucket>
	|-Array.InternalArray__ICollection_Remove<HeadingTracker.Item>
	|-Array.InternalArray__ICollection_Remove<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__ICollection_Remove<HebrewNumber.HebrewValue>
	|-Array.InternalArray__ICollection_Remove<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__ICollection_Remove<Icon.IconDirEntry>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.BindingJson>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.ReadActionJson>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.ReadMapJson>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.WriteActionJson>
	|-Array.InternalArray__ICollection_Remove<InputActionMap.WriteMapJson>
	|-Array.InternalArray__ICollection_Remove<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__ICollection_Remove<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__ICollection_Remove<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__ICollection_Remove<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__ICollection_Remove<InputControlLayout.ControlItem>
	|-Array.InternalArray__ICollection_Remove<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__ICollection_Remove<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__ICollection_Remove<InputControlScheme.SchemeJson>
	|-Array.InternalArray__ICollection_Remove<InputDevice.ControlBitRangeNode>
	|-Array.InternalArray__ICollection_Remove<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__ICollection_Remove<InputManager.AvailableDevice>
	|-Array.InternalArray__ICollection_Remove<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__ICollection_Remove<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__ICollection_Remove<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__ICollection_Remove<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__ICollection_Remove<InputRemoting.RemoteSender>
	|-Array.InternalArray__ICollection_Remove<InputStateHistory.Record>
	|-Array.InternalArray__ICollection_Remove<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__ICollection_Remove<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__ICollection_Remove<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__ICollection_Remove<InputUser.UserData>
	|-Array.InternalArray__ICollection_Remove<JsonParser.JsonValue>
	|-Array.InternalArray__ICollection_Remove<LatencySimulator.Message>
	|-Array.InternalArray__ICollection_Remove<LayerGridGraph.HeightSample>
	|-Array.InternalArray__ICollection_Remove<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__ICollection_Remove<LightUtility.LightMeshVertex>
	|-Array.InternalArray__ICollection_Remove<LiquidVolume.MeshCache>
	|-Array.InternalArray__ICollection_Remove<ListView.ItemMatrixLocation>
	|-Array.InternalArray__ICollection_Remove<MemoryHelpers.BitRegion>
	|-Array.InternalArray__ICollection_Remove<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__ICollection_Remove<Multipass.TransportIdData>
	|-Array.InternalArray__ICollection_Remove<NatPunchModule.RequestEventData>
	|-Array.InternalArray__ICollection_Remove<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__ICollection_Remove<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__ICollection_Remove<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__ICollection_Remove<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__ICollection_Remove<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__ICollection_Remove<NetworkAnimator.StateChange>
	|-Array.InternalArray__ICollection_Remove<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__ICollection_Remove<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__ICollection_Remove<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__ICollection_Remove<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__ICollection_Remove<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__ICollection_Remove<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__ICollection_Remove<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__ICollection_Remove<PlayingCard.CardData>
	|-Array.InternalArray__ICollection_Remove<PointKDTree.Node>
	|-Array.InternalArray__ICollection_Remove<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__ICollection_Remove<ProbeBrickIndex.Brick>
	|-Array.InternalArray__ICollection_Remove<ProbeBrickIndex.ReservedBrick>
	|-Array.InternalArray__ICollection_Remove<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__ICollection_Remove<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__ICollection_Remove<RVOQuadtree.Node>
	|-Array.InternalArray__ICollection_Remove<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__ICollection_Remove<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__ICollection_Remove<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__ICollection_Remove<RegexCharClass.SingleRange>
	|-Array.InternalArray__ICollection_Remove<ReliableChannel.PendingPacket>
	|-Array.InternalArray__ICollection_Remove<RenderChain.RenderNodeData>
	|-Array.InternalArray__ICollection_Remove<RenderGraph.CompiledPassInfo>
	|-Array.InternalArray__ICollection_Remove<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__ICollection_Remove<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__ICollection_Remove<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__ICollection_Remove<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__ICollection_Remove<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__ICollection_Remove<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__ICollection_Remove<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.ClipData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.MaskData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.NodeGlobalSceneState>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.NodeWithParent>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.PatternData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.PostponedClip>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.PostponedStopData>
	|-Array.InternalArray__ICollection_Remove<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__ICollection_Remove<SendMouseEvents.HitInfo>
	|-Array.InternalArray__ICollection_Remove<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__ICollection_Remove<ServerSocket.ConnectionChange>
	|-Array.InternalArray__ICollection_Remove<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__ICollection_Remove<ShaderInput.LightData>
	|-Array.InternalArray__ICollection_Remove<ShadowUtility.Edge>
	|-Array.InternalArray__ICollection_Remove<Socket.WSABUF>
	|-Array.InternalArray__ICollection_Remove<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__ICollection_Remove<StructySync.ChangeData>
	|-Array.InternalArray__ICollection_Remove<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__ICollection_Remove<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__ICollection_Remove<StyleSheet.ImportStruct>
	|-Array.InternalArray__ICollection_Remove<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__ICollection_Remove<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__ICollection_Remove<SyncStopwatch.ChangeData>
	|-Array.InternalArray__ICollection_Remove<SyncTimer.ChangeData>
	|-Array.InternalArray__ICollection_Remove<Syscall._pollfd>
	|-Array.InternalArray__ICollection_Remove<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__ICollection_Remove<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Remove<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__ICollection_Remove<TargetStateListener.Callback>
	|-Array.InternalArray__ICollection_Remove<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__ICollection_Remove<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Remove<TextSettings.FontReferenceMap>
	|-Array.InternalArray__ICollection_Remove<TextureBlitter.BlitInfo>
	|-Array.InternalArray__ICollection_Remove<TexturePacker_JsonArray.Frame>
	|-Array.InternalArray__ICollection_Remove<TextureRegistry.TextureInfo>
	|-Array.InternalArray__ICollection_Remove<Tilemap.SyncTile>
	|-Array.InternalArray__ICollection_Remove<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__ICollection_Remove<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__ICollection_Remove<TransportManager.DisconnectingClient>
	|-Array.InternalArray__ICollection_Remove<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__ICollection_Remove<UIRStylePainter.Entry>
	|-Array.InternalArray__ICollection_Remove<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__ICollection_Remove<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__ICollection_Remove<UIRenderDevice.AllocToUpdate>
	|-Array.InternalArray__ICollection_Remove<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__ICollection_Remove<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__ICollection_Remove<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__ICollection_Remove<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__ICollection_Remove<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__ICollection_Remove<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__ICollection_Remove<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__ICollection_Remove<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__ICollection_Remove<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__ICollection_Remove<VolumetricFog.FogOfWarTransition>
	|-Array.InternalArray__ICollection_Remove<Win32DnD.FORMATETC>
	|-Array.InternalArray__ICollection_Remove<WordStorage.Entry>
	|-Array.InternalArray__ICollection_Remove<X11DesktopColors.GdkColorStruct>
	|-Array.InternalArray__ICollection_Remove<XmlEventCache.XmlEvent>
	|-Array.InternalArray__ICollection_Remove<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__ICollection_Remove<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__ICollection_Remove<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__ICollection_Remove<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__ICollection_Remove<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__ICollection_Remove<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__ICollection_Remove<XmlTextReaderImpl.ParsingState>
	|-Array.InternalArray__ICollection_Remove<XmlTextWriter.Namespace>
	|-Array.InternalArray__ICollection_Remove<XmlTextWriter.TagInfo>
	|-Array.InternalArray__ICollection_Remove<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__ICollection_Remove<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__ICollection_Remove<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__ICollection_Remove<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__ICollection_Remove<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__ICollection_Remove<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-Array.InternalArray__ICollection_Remove<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__ICollection_Remove<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__ICollection_Remove<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__ICollection_Remove<InputControlLayout.Collection.LayoutMatcher>
	|-Array.InternalArray__ICollection_Remove<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__ICollection_Remove<InputControlScheme.MatchResult.Match>
	|-Array.InternalArray__ICollection_Remove<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__ICollection_Remove<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__ICollection_Remove<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__ICollection_Remove<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__ICollection_Remove<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheCurve.Item>
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheEntry.RecordingItem>
	|-Array.InternalArray__ICollection_Remove<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Contains<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5660 Offset: 0xFB4060 VA: 0x180FB5660
	|-Array.InternalArray__ICollection_Contains<ArraySegment<byte>>
	|
	|-RVA: 0xFB57A0 Offset: 0xFB41A0 VA: 0x180FB57A0
	|-Array.InternalArray__ICollection_Contains<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__ICollection_Contains<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, short>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, float>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int2, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int3, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Int3>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, long>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, ulong>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<long, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, bool>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, char>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Color32>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, double>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, long>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, float>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Scene, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ushort, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValue<int, int>>
	|-Array.InternalArray__ICollection_Contains<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<object>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<ulong>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__ICollection_Contains<AsyncGPUReadbackRequest>
	|-Array.InternalArray__ICollection_Contains<BezierContour>
	|-Array.InternalArray__ICollection_Contains<CompactVoxelSpan>
	|-Array.InternalArray__ICollection_Contains<CoordinateFootprintTilePair>
	|-Array.InternalArray__ICollection_Contains<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__ICollection_Contains<CoordinateStorageTilePair>
	|-Array.InternalArray__ICollection_Contains<CoordinateTilePair>
	|-Array.InternalArray__ICollection_Contains<DictionaryEntry>
	|-Array.InternalArray__ICollection_Contains<DrawBufferRange>
	|-Array.InternalArray__ICollection_Contains<DualPrefab>
	|-Array.InternalArray__ICollection_Contains<Entry>
	|-Array.InternalArray__ICollection_Contains<Ephemeron>
	|-Array.InternalArray__ICollection_Contains<EventSummary>
	|-Array.InternalArray__ICollection_Contains<ExtensionFilter>
	|-Array.InternalArray__ICollection_Contains<FontWeightPair>
	|-Array.InternalArray__ICollection_Contains<GfxUpdateBufferRange>
	|-Array.InternalArray__ICollection_Contains<HeaderVariantInfo>
	|-Array.InternalArray__ICollection_Contains<InternalCodePageDataItem>
	|-Array.InternalArray__ICollection_Contains<InternalEncodingDataItem>
	|-Array.InternalArray__ICollection_Contains<InterpretedFrameInfo>
	|-Array.InternalArray__ICollection_Contains<JobHandle>
	|-Array.InternalArray__ICollection_Contains<KeyStruct>
	|-Array.InternalArray__ICollection_Contains<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Contains<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_Contains<LinkedVoxelSpan>
	|-Array.InternalArray__ICollection_Contains<LocalPacket>
	|-Array.InternalArray__ICollection_Contains<LocalPacket>
	|-Array.InternalArray__ICollection_Contains<MarkupAttribute>
	|-Array.InternalArray__ICollection_Contains<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__ICollection_Contains<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Contains<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_Contains<Playable>
	|-Array.InternalArray__ICollection_Contains<Progress>
	|-Array.InternalArray__ICollection_Contains<QosResult>
	|-Array.InternalArray__ICollection_Contains<RangePositionInfo>
	|-Array.InternalArray__ICollection_Contains<RectInt>
	|-Array.InternalArray__ICollection_Contains<RenderBuffer>
	|-Array.InternalArray__ICollection_Contains<RenderInstancedDataLayout>
	|-Array.InternalArray__ICollection_Contains<Resolution>
	|-Array.InternalArray__ICollection_Contains<ResourceLocator>
	|-Array.InternalArray__ICollection_Contains<RpcLink>
	|-Array.InternalArray__ICollection_Contains<RuleMatcher>
	|-Array.InternalArray__ICollection_Contains<ScalableImage>
	|-Array.InternalArray__ICollection_Contains<SecondarySpriteTexture>
	|-Array.InternalArray__ICollection_Contains<SemanticMeaning>
	|-Array.InternalArray__ICollection_Contains<ShaderKeyword>
	|-Array.InternalArray__ICollection_Contains<SteamItemDetails_t>
	|-Array.InternalArray__ICollection_Contains<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__ICollection_Contains<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__ICollection_Contains<StylePropertyValue>
	|-Array.InternalArray__ICollection_Contains<StyleValueManaged>
	|-Array.InternalArray__ICollection_Contains<TMP_FontWeightPair>
	|-Array.InternalArray__ICollection_Contains<TextProcessingElement>
	|-Array.InternalArray__ICollection_Contains<TreeItem>
	|-Array.InternalArray__ICollection_Contains<UILineInfo>
	|-Array.InternalArray__ICollection_Contains<UnloadedScene>
	|-Array.InternalArray__ICollection_Contains<X509ChainStatus>
	|-Array.InternalArray__ICollection_Contains<XPathNodeRef>
	|-Array.InternalArray__ICollection_Contains<ZipGenericExtraField>
	|-Array.InternalArray__ICollection_Contains<AdvancedSmooth.Turn>
	|-Array.InternalArray__ICollection_Contains<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__ICollection_Contains<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__ICollection_Contains<BinaryHeap.Tuple>
	|-Array.InternalArray__ICollection_Contains<CameraState.CustomBlendable>
	|-Array.InternalArray__ICollection_Contains<CinemachineTargetGroup.Target>
	|-Array.InternalArray__ICollection_Contains<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__ICollection_Contains<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__ICollection_Contains<DataError.ColumnError>
	|-Array.InternalArray__ICollection_Contains<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__ICollection_Contains<EventDispatcher.DispatchContext>
	|-Array.InternalArray__ICollection_Contains<EventDispatcher.EventRecord>
	|-Array.InternalArray__ICollection_Contains<ExpressionParser.ReservedWords>
	|-Array.InternalArray__ICollection_Contains<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__ICollection_Contains<FocusController.FocusedElement>
	|-Array.InternalArray__ICollection_Contains<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__ICollection_Contains<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__ICollection_Contains<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__ICollection_Contains<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__ICollection_Contains<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__ICollection_Contains<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__ICollection_Contains<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__ICollection_Contains<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__ICollection_Contains<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__ICollection_Contains<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__ICollection_Contains<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__ICollection_Contains<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__ICollection_Contains<PointKDTree.Node>
	|-Array.InternalArray__ICollection_Contains<ProbeBrickIndex.Brick>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__ICollection_Contains<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.NodeWithParent>
	|-Array.InternalArray__ICollection_Contains<SendMouseEvents.HitInfo>
	|-Array.InternalArray__ICollection_Contains<ServerSocket.ConnectionChange>
	|-Array.InternalArray__ICollection_Contains<Socket.WSABUF>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__ICollection_Contains<StyleSheet.ImportStruct>
	|-Array.InternalArray__ICollection_Contains<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__ICollection_Contains<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__ICollection_Contains<TargetStateListener.Callback>
	|-Array.InternalArray__ICollection_Contains<TextSettings.FontReferenceMap>
	|-Array.InternalArray__ICollection_Contains<TextureRegistry.TextureInfo>
	|-Array.InternalArray__ICollection_Contains<TransportManager.DisconnectingClient>
	|-Array.InternalArray__ICollection_Contains<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__ICollection_Contains<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__ICollection_Contains<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__ICollection_Contains<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__ICollection_Contains<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__ICollection_Contains<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__ICollection_Contains<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__ICollection_Contains<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__ICollection_Contains<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__ICollection_Contains<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__ICollection_Contains<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__ICollection_Contains<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__ICollection_Contains<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__ICollection_Contains<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__ICollection_Contains<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__ICollection_Contains<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	|
	|-RVA: 0xFB5910 Offset: 0xFB4310 VA: 0x180FB5910
	|-Array.InternalArray__ICollection_Contains<SyncList.ChangeData<int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int2, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<bool>>
	|-Array.InternalArray__ICollection_Contains<Set.Slot<char>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<int>>
	|-Array.InternalArray__ICollection_Contains<Set.Slot<int>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Scene>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<uint>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__ICollection_Contains<RuntimeLabel>
	|-Array.InternalArray__ICollection_Contains<UICharInfo>
	|-Array.InternalArray__ICollection_Contains<WordInfo>
	|-Array.InternalArray__ICollection_Contains<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__ICollection_Contains<AstarDebugger.GraphPoint>
	|-Array.InternalArray__ICollection_Contains<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__ICollection_Contains<GtkPlus.GdkColor>
	|-Array.InternalArray__ICollection_Contains<HIDParser.HIDReportData>
	|-Array.InternalArray__ICollection_Contains<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__ICollection_Contains<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__ICollection_Contains<SyncTimer.ChangeData>
	|-Array.InternalArray__ICollection_Contains<X11DesktopColors.GdkColorStruct>
	|
	|-RVA: 0xFB5A90 Offset: 0xFB4490 VA: 0x180FB5A90
	|-Array.InternalArray__ICollection_Contains<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, bool>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, short>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, float>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, uint>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, int>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__ICollection_Contains<AnimatorClipInfo>
	|-Array.InternalArray__ICollection_Contains<CompactVoxelCell>
	|-Array.InternalArray__ICollection_Contains<DecalEntity>
	|-Array.InternalArray__ICollection_Contains<DecalSubDrawCall>
	|-Array.InternalArray__ICollection_Contains<EventTypeSpec>
	|-Array.InternalArray__ICollection_Contains<ParameterModifier>
	|-Array.InternalArray__ICollection_Contains<RemoteConnectionEvent>
	|-Array.InternalArray__ICollection_Contains<RendererListHandle>
	|-Array.InternalArray__ICollection_Contains<ResourceHandle>
	|-Array.InternalArray__ICollection_Contains<RpcLinkType>
	|-Array.InternalArray__ICollection_Contains<StyleValueHandle>
	|-Array.InternalArray__ICollection_Contains<TerrainTileCoord>
	|-Array.InternalArray__ICollection_Contains<TextureHandle>
	|-Array.InternalArray__ICollection_Contains<UsageHint>
	|-Array.InternalArray__ICollection_Contains<jvalue>
	|-Array.InternalArray__ICollection_Contains<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__ICollection_Contains<BitmapAllocator32.Page>
	|-Array.InternalArray__ICollection_Contains<BloomRenderer.Level>
	|-Array.InternalArray__ICollection_Contains<CinemachineClearShot.Pair>
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__ICollection_Contains<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__ICollection_Contains<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__ICollection_Contains<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__ICollection_Contains<ListView.ItemMatrixLocation>
	|-Array.InternalArray__ICollection_Contains<MemoryHelpers.BitRegion>
	|-Array.InternalArray__ICollection_Contains<Multipass.TransportIdData>
	|-Array.InternalArray__ICollection_Contains<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__ICollection_Contains<PlayingCard.CardData>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.PostponedClip>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.PostponedStopData>
	|-Array.InternalArray__ICollection_Contains<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__ICollection_Contains<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__ICollection_Contains<SyncStopwatch.ChangeData>
	|-Array.InternalArray__ICollection_Contains<Syscall._pollfd>
	|-Array.InternalArray__ICollection_Contains<WordStorage.Entry>
	|
	|-RVA: 0xFB5BE0 Offset: 0xFB45E0 VA: 0x180FB5BE0
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.ClipData>
	|
	|-RVA: 0xFB5EB0 Offset: 0xFB48B0 VA: 0x180FB5EB0
	|-Array.InternalArray__ICollection_Contains<IntervalTree.Entry<object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, long>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<long, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, double>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, long>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, float>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Guid, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Playable>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Rect>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Rect, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Contains<TempAllocator.Page<ushort>>
	|-Array.InternalArray__ICollection_Contains<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<InternedString>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__ICollection_Contains<Set.Slot<object>>
	|-Array.InternalArray__ICollection_Contains<TreeViewItemData<object>>
	|-Array.InternalArray__ICollection_Contains<BezierPathSegment>
	|-Array.InternalArray__ICollection_Contains<ComputedTransitionProperty>
	|-Array.InternalArray__ICollection_Contains<ContourVertex>
	|-Array.InternalArray__ICollection_Contains<ContourVertex>
	|-Array.InternalArray__ICollection_Contains<CoordinateProceduralTilePair>
	|-Array.InternalArray__ICollection_Contains<FrameTimeSample>
	|-Array.InternalArray__ICollection_Contains<IntervalTreeNode>
	|-Array.InternalArray__ICollection_Contains<JsonPosition>
	|-Array.InternalArray__ICollection_Contains<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Contains<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_Contains<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Contains<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_Contains<NameAndParameters>
	|-Array.InternalArray__ICollection_Contains<Packet>
	|-Array.InternalArray__ICollection_Contains<RendererList>
	|-Array.InternalArray__ICollection_Contains<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Contains<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_Contains<SelectorMatchRecord>
	|-Array.InternalArray__ICollection_Contains<StyleSelectorPart>
	|-Array.InternalArray__ICollection_Contains<StyleSyntaxToken>
	|-Array.InternalArray__ICollection_Contains<StyleValue>
	|-Array.InternalArray__ICollection_Contains<StyleVariable>
	|-Array.InternalArray__ICollection_Contains<TMP_WordInfo>
	|-Array.InternalArray__ICollection_Contains<TreeViewItemWrapper>
	|-Array.InternalArray__ICollection_Contains<UEvent>
	|-Array.InternalArray__ICollection_Contains<UStar>
	|-Array.InternalArray__ICollection_Contains<XRFeatureDescriptor>
	|-Array.InternalArray__ICollection_Contains<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__ICollection_Contains<AvatarSettings.LayerSetting>
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__ICollection_Contains<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__ICollection_Contains<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__ICollection_Contains<Hashtable.bucket>
	|-Array.InternalArray__ICollection_Contains<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__ICollection_Contains<InputControlScheme.SchemeJson>
	|-Array.InternalArray__ICollection_Contains<InputRemoting.RemoteSender>
	|-Array.InternalArray__ICollection_Contains<LatencySimulator.Message>
	|-Array.InternalArray__ICollection_Contains<LiquidVolume.MeshCache>
	|-Array.InternalArray__ICollection_Contains<NatPunchModule.RequestEventData>
	|-Array.InternalArray__ICollection_Contains<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__ICollection_Contains<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__ICollection_Contains<RVOQuadtree.Node>
	|-Array.InternalArray__ICollection_Contains<ReliableChannel.PendingPacket>
	|-Array.InternalArray__ICollection_Contains<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__ICollection_Contains<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__ICollection_Contains<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__ICollection_Contains<StructySync.ChangeData>
	|-Array.InternalArray__ICollection_Contains<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__ICollection_Contains<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__ICollection_Contains<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__ICollection_Contains<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__ICollection_Contains<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__ICollection_Contains<XmlTextWriter.Namespace>
	|-Array.InternalArray__ICollection_Contains<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__ICollection_Contains<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__ICollection_Contains<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xFB5D30 Offset: 0xFB4730 VA: 0x180FB5D30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__ICollection_Contains<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Contains<RBTree.Node<int>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__ICollection_Contains<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_Contains<AstarWorkItem>
	|-Array.InternalArray__ICollection_Contains<BezierSegment>
	|-Array.InternalArray__ICollection_Contains<GradientSettings>
	|-Array.InternalArray__ICollection_Contains<IndexRange>
	|-Array.InternalArray__ICollection_Contains<Light2DBlendStyle>
	|-Array.InternalArray__ICollection_Contains<NavMeshBuildMarkup>
	|-Array.InternalArray__ICollection_Contains<PlayableBinding>
	|-Array.InternalArray__ICollection_Contains<SpriteState>
	|-Array.InternalArray__ICollection_Contains<VoxelContour>
	|-Array.InternalArray__ICollection_Contains<XPathNode>
	|-Array.InternalArray__ICollection_Contains<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__ICollection_Contains<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__ICollection_Contains<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__ICollection_Contains<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__ICollection_Contains<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.ReadMapJson>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.WriteMapJson>
	|-Array.InternalArray__ICollection_Contains<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__ICollection_Contains<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__ICollection_Contains<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Contains<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_Contains<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__ICollection_Contains<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__ICollection_Contains<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__ICollection_Contains<Win32DnD.FORMATETC>
	|-Array.InternalArray__ICollection_Contains<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__ICollection_Contains<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__ICollection_Contains<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__ICollection_Contains<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xFB61D0 Offset: 0xFB4BD0 VA: 0x180FB61D0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_Contains<ComputedStyle>
	|-Array.InternalArray__ICollection_Contains<FrameTiming>
	|
	|-RVA: 0xFB6570 Offset: 0xFB4F70 VA: 0x180FB6570
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Contains<RBTree.Node<object>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__ICollection_Contains<ContactPairHeader>
	|-Array.InternalArray__ICollection_Contains<Label>
	|-Array.InternalArray__ICollection_Contains<List>
	|-Array.InternalArray__ICollection_Contains<Navigation>
	|-Array.InternalArray__ICollection_Contains<PlayerLoopSystem>
	|-Array.InternalArray__ICollection_Contains<PlayerLoopSystemInternal>
	|-Array.InternalArray__ICollection_Contains<TMP_LinkInfo>
	|-Array.InternalArray__ICollection_Contains<TreeInstance>
	|-Array.InternalArray__ICollection_Contains<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__ICollection_Contains<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__ICollection_Contains<GrounderQuadruped.Foot>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__ICollection_Contains<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__ICollection_Contains<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__ICollection_Contains<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__ICollection_Contains<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__ICollection_Contains<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__ICollection_Contains<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__ICollection_Contains<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__ICollection_Contains<XmlEventCache.XmlEvent>
	|-Array.InternalArray__ICollection_Contains<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xFB7220 Offset: 0xFB5C20 VA: 0x180FB7220
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Contains<UHull>
	|-Array.InternalArray__ICollection_Contains<HID.HIDElementDescriptor>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.ReadActionJson>
	|-Array.InternalArray__ICollection_Contains<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0xFB6720 Offset: 0xFB5120 VA: 0x180FB6720
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__ICollection_Contains<GradientColorKey>
	|-Array.InternalArray__ICollection_Contains<GradientStop>
	|-Array.InternalArray__ICollection_Contains<PageInfo>
	|-Array.InternalArray__ICollection_Contains<TMP_PageInfo>
	|-Array.InternalArray__ICollection_Contains<TemperatureEmitterInfo>
	|-Array.InternalArray__ICollection_Contains<UEncroachingSegment>
	|-Array.InternalArray__ICollection_Contains<CodePointIndexer.TableRange>
	|-Array.InternalArray__ICollection_Contains<Cursor.CursorEntry>
	|-Array.InternalArray__ICollection_Contains<HeadingTracker.Item>
	|-Array.InternalArray__ICollection_Contains<Icon.IconDirEntry>
	|-Array.InternalArray__ICollection_Contains<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xFB6030 Offset: 0xFB4A30 VA: 0x180FB6030
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<RaycastHit2D>
	|-Array.InternalArray__ICollection_Contains<Funnel.PathPart>
	|-Array.InternalArray__ICollection_Contains<LightUtility.LightMeshVertex>
	|-Array.InternalArray__ICollection_Contains<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__ICollection_Contains<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xFB6CB0 Offset: 0xFB56B0 VA: 0x180FB6CB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<Keyframe>
	|-Array.InternalArray__ICollection_Contains<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__ICollection_Contains<BBTree.BBTreeBox>
	|-Array.InternalArray__ICollection_Contains<BlitUtility.Vertex>
	|-Array.InternalArray__ICollection_Contains<CinemachinePath.Waypoint>
	|-Array.InternalArray__ICollection_Contains<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__ICollection_Contains<NetworkAnimator.StateChange>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.PatternData>
	|-Array.InternalArray__ICollection_Contains<ShadowUtility.Edge>
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xFB68A0 Offset: 0xFB52A0 VA: 0x180FB68A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|
	|-RVA: 0xFB63C0 Offset: 0xFB4DC0 VA: 0x180FB63C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_Contains<ContactPoint>
	|-Array.InternalArray__ICollection_Contains<CopyClosingMeshJobData>
	|-Array.InternalArray__ICollection_Contains<DisplayInfo>
	|-Array.InternalArray__ICollection_Contains<LinkInfo>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__ICollection_Contains<Rigidbody2DState>
	|-Array.InternalArray__ICollection_Contains<Transform3x4>
	|-Array.InternalArray__ICollection_Contains<VectorImageVertex>
	|-Array.InternalArray__ICollection_Contains<AnimationWarping.Warp>
	|-Array.InternalArray__ICollection_Contains<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__ICollection_Contains<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__ICollection_Contains<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__ICollection_Contains<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__ICollection_Contains<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__ICollection_Contains<InputControlScheme.MatchResult.Match>
	|
	|-RVA: 0xFB7020 Offset: 0xFB5A20 VA: 0x180FB7020
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Contains<CombineInstance>
	|-Array.InternalArray__ICollection_Contains<ModifiableContactPair>
	|
	|-RVA: 0xFB6E50 Offset: 0xFB5850 VA: 0x180FB6E50
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__ICollection_Contains<EnumData>
	|-Array.InternalArray__ICollection_Contains<HumanBone>
	|-Array.InternalArray__ICollection_Contains<Vertex>
	|-Array.InternalArray__ICollection_Contains<Cursor.CursorImage>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.BindingJson>
	|-Array.InternalArray__ICollection_Contains<InputManager.AvailableDevice>
	|-Array.InternalArray__ICollection_Contains<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__ICollection_Contains<LayerGridGraph.HeightSample>
	|-Array.InternalArray__ICollection_Contains<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xFB7400 Offset: 0xFB5E00 VA: 0x180FB7400
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xFB6AE0 Offset: 0xFB54E0 VA: 0x180FB6AE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__ICollection_Contains<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__ICollection_Contains<ContactPoint2D>
	|-Array.InternalArray__ICollection_Contains<MaterialReference>
	|-Array.InternalArray__ICollection_Contains<MaterialReference>
	|-Array.InternalArray__ICollection_Contains<SkeletonBone>
	|-Array.InternalArray__ICollection_Contains<InputActionMap.WriteActionJson>
	|-Array.InternalArray__ICollection_Contains<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__ICollection_Contains<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__ICollection_Contains<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__ICollection_Contains<TextureBlitter.BlitInfo>
	|-Array.InternalArray__ICollection_Contains<XmlTextWriter.TagInfo>
	|
	|-RVA: 0xFB7680 Offset: 0xFB6080 VA: 0x180FB7680
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__ICollection_Contains<MeshInfo>
	|-Array.InternalArray__ICollection_Contains<RaycastResult>
	|-Array.InternalArray__ICollection_Contains<TMP_MeshInfo>
	|-Array.InternalArray__ICollection_Contains<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__ICollection_Contains<UIRStylePainter.Entry>
	|-Array.InternalArray__ICollection_Contains<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xFB7A30 Offset: 0xFB6430 VA: 0x180FB7A30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__ICollection_Contains<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xFB7850 Offset: 0xFB6250 VA: 0x180FB7850
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__ICollection_Contains<CullingSplit>
	|-Array.InternalArray__ICollection_Contains<LightDataGI>
	|-Array.InternalArray__ICollection_Contains<LineInfo>
	|-Array.InternalArray__ICollection_Contains<NavMeshBuildSource>
	|-Array.InternalArray__ICollection_Contains<TMP_LineInfo>
	|-Array.InternalArray__ICollection_Contains<TileData>
	|-Array.InternalArray__ICollection_Contains<RenderChain.RenderNodeData>
	|
	|-RVA: 0xFB7DA0 Offset: 0xFB67A0 VA: 0x180FB7DA0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xFB7C50 Offset: 0xFB6650 VA: 0x180FB7C50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__ICollection_Contains<Color32>
	|-Array.InternalArray__ICollection_Contains<InclusiveRange>
	|-Array.InternalArray__ICollection_Contains<LayerMask>
	|-Array.InternalArray__ICollection_Contains<SortingLayer>
	|-Array.InternalArray__ICollection_Contains<UShort2>
	|-Array.InternalArray__ICollection_Contains<HebrewNumber.HebrewValue>
	|-Array.InternalArray__ICollection_Contains<RegexCharClass.SingleRange>
	|
	|-RVA: 0xFB8020 Offset: 0xFB6A20 VA: 0x180FB8020
	|-Array.InternalArray__ICollection_Contains<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Contains<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Contains<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xFB8140 Offset: 0xFB6B40 VA: 0x180FB8140
	|-Array.InternalArray__ICollection_Contains<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_Contains<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_Contains<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xFB83C0 Offset: 0xFB6DC0 VA: 0x180FB83C0
	|-Array.InternalArray__ICollection_Contains<Nullable<DateTime>>
	|
	|-RVA: 0xFB8260 Offset: 0xFB6C60 VA: 0x180FB8260
	|-Array.InternalArray__ICollection_Contains<Nullable<Decimal>>
	|
	|-RVA: 0xFB84F0 Offset: 0xFB6EF0 VA: 0x180FB84F0
	|-Array.InternalArray__ICollection_Contains<InputStateHistory.Record<TouchState>>
	|
	|-RVA: 0xFB8610 Offset: 0xFB7010 VA: 0x180FB8610
	|-Array.InternalArray__ICollection_Contains<StructMultiKey<object, object>>
	|
	|-RVA: 0xFB8730 Offset: 0xFB7130 VA: 0x180FB8730
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__ICollection_Contains<BoundingSphere>
	|-Array.InternalArray__ICollection_Contains<Plane>
	|-Array.InternalArray__ICollection_Contains<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__ICollection_Contains<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0xFC1580 Offset: 0xFBFF80 VA: 0x180FC1580
	|-Array.InternalArray__ICollection_Contains<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|
	|-RVA: 0xFC1770 Offset: 0xFC0170 VA: 0x180FC1770
	|-Array.InternalArray__ICollection_Contains<SubArray<int>>
	|
	|-RVA: 0xFC1890 Offset: 0xFC0290 VA: 0x180FC1890
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0xFC1B30 Offset: 0xFC0530 VA: 0x180FC1B30
	|-Array.InternalArray__ICollection_Contains<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_Contains<WordWrapState>
	|
	|-RVA: 0xFC1DB0 Offset: 0xFC07B0 VA: 0x180FC1DB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool>>
	|
	|-RVA: 0xFC2280 Offset: 0xFC0C80 VA: 0x180FC2280
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, int>>
	|
	|-RVA: 0xFC2920 Offset: 0xFC1320 VA: 0x180FC2920
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, object>>
	|
	|-RVA: 0xFC2390 Offset: 0xFC0D90 VA: 0x180FC2390
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Scene>>
	|
	|-RVA: 0xFC2150 Offset: 0xFC0B50 VA: 0x180FC2150
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xFC24A0 Offset: 0xFC0EA0 VA: 0x180FC24A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0xFC2800 Offset: 0xFC1200 VA: 0x180FC2800
	|-Array.InternalArray__ICollection_Contains<ValueTuple<IntPtr, object>>
	|
	|-RVA: 0xFC2010 Offset: 0xFC0A10 VA: 0x180FC2010
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xFC26E0 Offset: 0xFC10E0 VA: 0x180FC26E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, int>>
	|
	|-RVA: 0xFC25C0 Offset: 0xFC0FC0 VA: 0x180FC25C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object>>
	|
	|-RVA: 0xFC2A40 Offset: 0xFC1440 VA: 0x180FC2A40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0xFC1ED0 Offset: 0xFC08D0 VA: 0x180FC1ED0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Vector4, Vector2Int>>
	|
	|-RVA: 0xFC2B80 Offset: 0xFC1580 VA: 0x180FC2B80
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object>>
	|
	|-RVA: 0xFB88A0 Offset: 0xFB72A0 VA: 0x180FB88A0
	|-Array.InternalArray__ICollection_Contains<AppId_t>
	|
	|-RVA: 0xFB89E0 Offset: 0xFB73E0 VA: 0x180FB89E0
	|-Array.InternalArray__ICollection_Contains<AttachmentDescriptor>
	|
	|-RVA: 0xFB8EF0 Offset: 0xFB78F0 VA: 0x180FB8EF0
	|-Array.InternalArray__ICollection_Contains<Background>
	|
	|-RVA: 0xFB8B80 Offset: 0xFB7580 VA: 0x180FB8B80
	|-Array.InternalArray__ICollection_Contains<BackgroundPosition>
	|
	|-RVA: 0xFB8CB0 Offset: 0xFB76B0 VA: 0x180FB8CB0
	|-Array.InternalArray__ICollection_Contains<BackgroundRepeat>
	|
	|-RVA: 0xFB8DC0 Offset: 0xFB77C0 VA: 0x180FB8DC0
	|-Array.InternalArray__ICollection_Contains<BackgroundSize>
	|
	|-RVA: 0xFB9020 Offset: 0xFB7A20 VA: 0x180FB9020
	|-Array.InternalArray__ICollection_Contains<BigInteger>
	|
	|-RVA: 0xFB9160 Offset: 0xFB7B60 VA: 0x180FB9160
	|-Array.InternalArray__ICollection_Contains<Board>
	|-Array.InternalArray__ICollection_Contains<RendererListResource>
	|
	|-RVA: 0xFB93F0 Offset: 0xFB7DF0 VA: 0x180FB93F0
	|-Array.InternalArray__ICollection_Contains<bool>
	|
	|-RVA: 0xFB9670 Offset: 0xFB8070 VA: 0x180FB9670
	|-Array.InternalArray__ICollection_Contains<Bounds>
	|
	|-RVA: 0xFB9530 Offset: 0xFB7F30 VA: 0x180FB9530
	|-Array.InternalArray__ICollection_Contains<BoundsInt>
	|
	|-RVA: 0xFB9910 Offset: 0xFB8310 VA: 0x180FB9910
	|-Array.InternalArray__ICollection_Contains<byte>
	|
	|-RVA: 0xFB97B0 Offset: 0xFB81B0 VA: 0x180FB97B0
	|-Array.InternalArray__ICollection_Contains<ByteEnum>
	|-Array.InternalArray__ICollection_Contains<SByteEnum>
	|
	|-RVA: 0xFB9A30 Offset: 0xFB8430 VA: 0x180FB9A30
	|-Array.InternalArray__ICollection_Contains<CGSpot>
	|
	|-RVA: 0xFB9BA0 Offset: 0xFB85A0 VA: 0x180FB9BA0
	|-Array.InternalArray__ICollection_Contains<CSteamID>
	|
	|-RVA: 0xFB9CE0 Offset: 0xFB86E0 VA: 0x180FB9CE0
	|-Array.InternalArray__ICollection_Contains<char>
	|
	|-RVA: 0xFB9FF0 Offset: 0xFB89F0 VA: 0x180FB9FF0
	|-Array.InternalArray__ICollection_Contains<Color>
	|
	|-RVA: 0xFBA130 Offset: 0xFB8B30 VA: 0x180FBA130
	|-Array.InternalArray__ICollection_Contains<Color>
	|
	|-RVA: 0xFB9E20 Offset: 0xFB8820 VA: 0x180FB9E20
	|-Array.InternalArray__ICollection_Contains<ColorBlock>
	|
	|-RVA: 0xFBA250 Offset: 0xFB8C50 VA: 0x180FBA250
	|-Array.InternalArray__ICollection_Contains<Connection>
	|
	|-RVA: 0xFBA370 Offset: 0xFB8D70 VA: 0x180FBA370
	|-Array.InternalArray__ICollection_Contains<ControlPointOption>
	|
	|-RVA: 0xFBA4C0 Offset: 0xFB8EC0 VA: 0x180FBA4C0
	|-Array.InternalArray__ICollection_Contains<ConvertMeshJobData>
	|
	|-RVA: 0xFBA730 Offset: 0xFB9130 VA: 0x180FBA730
	|-Array.InternalArray__ICollection_Contains<CustomAttributeNamedArgument>
	|
	|-RVA: 0xFBA880 Offset: 0xFB9280 VA: 0x180FBA880
	|-Array.InternalArray__ICollection_Contains<CustomAttributeTypedArgument>
	|
	|-RVA: 0xFBAAE0 Offset: 0xFB94E0 VA: 0x180FBAAE0
	|-Array.InternalArray__ICollection_Contains<DateTime>
	|
	|-RVA: 0xFBA9A0 Offset: 0xFB93A0 VA: 0x180FBA9A0
	|-Array.InternalArray__ICollection_Contains<DateTimeOffset>
	|
	|-RVA: 0xFBAC20 Offset: 0xFB9620 VA: 0x180FBAC20
	|-Array.InternalArray__ICollection_Contains<Decimal>
	|
	|-RVA: 0xFBAD60 Offset: 0xFB9760 VA: 0x180FBAD60
	|-Array.InternalArray__ICollection_Contains<DepotId_t>
	|
	|-RVA: 0xFBAEA0 Offset: 0xFB98A0 VA: 0x180FBAEA0
	|-Array.InternalArray__ICollection_Contains<Dimension>
	|
	|-RVA: 0xFBB140 Offset: 0xFB9B40 VA: 0x180FBB140
	|-Array.InternalArray__ICollection_Contains<double>
	|
	|-RVA: 0xFBAFB0 Offset: 0xFB99B0 VA: 0x180FBAFB0
	|-Array.InternalArray__ICollection_Contains<DoublePoint>
	|-Array.InternalArray__ICollection_Contains<DoublePoint>
	|-Array.InternalArray__ICollection_Contains<ClipperLib.DoublePoint>
	|
	|-RVA: 0xFBB270 Offset: 0xFB9C70 VA: 0x180FBB270
	|-Array.InternalArray__ICollection_Contains<DuplicateSamplePoint>
	|
	|-RVA: 0xFBB3A0 Offset: 0xFB9DA0 VA: 0x180FBB3A0
	|-Array.InternalArray__ICollection_Contains<EasingFunction>
	|
	|-RVA: 0xFBB4B0 Offset: 0xFB9EB0 VA: 0x180FBB4B0
	|-Array.InternalArray__ICollection_Contains<FixedString128Bytes>
	|
	|-RVA: 0xFBB650 Offset: 0xFBA050 VA: 0x180FBB650
	|-Array.InternalArray__ICollection_Contains<FontDefinition>
	|
	|-RVA: 0xFBB770 Offset: 0xFBA170 VA: 0x180FBB770
	|-Array.InternalArray__ICollection_Contains<FullRank>
	|
	|-RVA: 0xFBB880 Offset: 0xFBA280 VA: 0x180FBB880
	|-Array.InternalArray__ICollection_Contains<GCHandle>
	|
	|-RVA: 0xFBB990 Offset: 0xFBA390 VA: 0x180FBB990
	|-Array.InternalArray__ICollection_Contains<GlyphMarshallingStruct>
	|-Array.InternalArray__ICollection_Contains<LayerBatch>
	|-Array.InternalArray__ICollection_Contains<UTriangle>
	|
	|-RVA: 0xFBBB60 Offset: 0xFBA560 VA: 0x180FBBB60
	|-Array.InternalArray__ICollection_Contains<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xFBBCD0 Offset: 0xFBA6D0 VA: 0x180FBBCD0
	|-Array.InternalArray__ICollection_Contains<GlyphRect>
	|
	|-RVA: 0xFBBE10 Offset: 0xFBA810 VA: 0x180FBBE10
	|-Array.InternalArray__ICollection_Contains<GradientAlphaKey>
	|-Array.InternalArray__ICollection_Contains<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__ICollection_Contains<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.NodeGlobalSceneState>
	|
	|-RVA: 0xFBBF80 Offset: 0xFBA980 VA: 0x180FBBF80
	|-Array.InternalArray__ICollection_Contains<Guid>
	|
	|-RVA: 0xFBC0A0 Offset: 0xFBAAA0 VA: 0x180FBC0A0
	|-Array.InternalArray__ICollection_Contains<HSteamNetConnection>
	|
	|-RVA: 0xFBC1E0 Offset: 0xFBABE0 VA: 0x180FBC1E0
	|-Array.InternalArray__ICollection_Contains<Hash128>
	|
	|-RVA: 0xFBC300 Offset: 0xFBAD00 VA: 0x180FBC300
	|-Array.InternalArray__ICollection_Contains<HighlightState>
	|
	|-RVA: 0xFBC430 Offset: 0xFBAE30 VA: 0x180FBC430
	|-Array.InternalArray__ICollection_Contains<HighlightState>
	|
	|-RVA: 0xFBC560 Offset: 0xFBAF60 VA: 0x180FBC560
	|-Array.InternalArray__ICollection_Contains<IndexField>
	|
	|-RVA: 0xFBC680 Offset: 0xFBB080 VA: 0x180FBC680
	|-Array.InternalArray__ICollection_Contains<InputActionSetHandle_t>
	|
	|-RVA: 0xFBC790 Offset: 0xFBB190 VA: 0x180FBC790
	|-Array.InternalArray__ICollection_Contains<InputBinding>
	|
	|-RVA: 0xFBC930 Offset: 0xFBB330 VA: 0x180FBC930
	|-Array.InternalArray__ICollection_Contains<InputControlScheme>
	|
	|-RVA: 0xFBCA70 Offset: 0xFBB470 VA: 0x180FBCA70
	|-Array.InternalArray__ICollection_Contains<InputDeviceDescription>
	|
	|-RVA: 0xFBCBE0 Offset: 0xFBB5E0 VA: 0x180FBCBE0
	|-Array.InternalArray__ICollection_Contains<InputEventPtr>
	|
	|-RVA: 0xFBCCF0 Offset: 0xFBB6F0 VA: 0x180FBCCF0
	|-Array.InternalArray__ICollection_Contains<InputHandle_t>
	|
	|-RVA: 0xFBCE00 Offset: 0xFBB800 VA: 0x180FBCE00
	|-Array.InternalArray__ICollection_Contains<InputUser>
	|
	|-RVA: 0xFBCF40 Offset: 0xFBB940 VA: 0x180FBCF40
	|-Array.InternalArray__ICollection_Contains<short>
	|
	|-RVA: 0xFBD050 Offset: 0xFBBA50 VA: 0x180FBD050
	|-Array.InternalArray__ICollection_Contains<Int2>
	|
	|-RVA: 0xFBD3C0 Offset: 0xFBBDC0 VA: 0x180FBD3C0
	|-Array.InternalArray__ICollection_Contains<Int3>
	|
	|-RVA: 0xFBD2B0 Offset: 0xFBBCB0 VA: 0x180FBD2B0
	|-Array.InternalArray__ICollection_Contains<int>
	|
	|-RVA: 0xFBD160 Offset: 0xFBBB60 VA: 0x180FBD160
	|-Array.InternalArray__ICollection_Contains<Int32Enum>
	|-Array.InternalArray__ICollection_Contains<UInt32Enum>
	|
	|-RVA: 0xFBD4F0 Offset: 0xFBBEF0 VA: 0x180FBD4F0
	|-Array.InternalArray__ICollection_Contains<long>
	|
	|-RVA: 0xFBD750 Offset: 0xFBC150 VA: 0x180FBD750
	|-Array.InternalArray__ICollection_Contains<IntPoint>
	|
	|-RVA: 0xFBD600 Offset: 0xFBC000 VA: 0x180FBD600
	|-Array.InternalArray__ICollection_Contains<IntPoint>
	|
	|-RVA: 0xFBD870 Offset: 0xFBC270 VA: 0x180FBD870
	|-Array.InternalArray__ICollection_Contains<IntPtr>
	|
	|-RVA: 0xFBD980 Offset: 0xFBC380 VA: 0x180FBD980
	|-Array.InternalArray__ICollection_Contains<IntRect>
	|
	|-RVA: 0xFBDAA0 Offset: 0xFBC4A0 VA: 0x180FBDAA0
	|-Array.InternalArray__ICollection_Contains<IntRegion>
	|
	|-RVA: 0xFBDBD0 Offset: 0xFBC5D0 VA: 0x180FBDBD0
	|-Array.InternalArray__ICollection_Contains<InternedString>
	|
	|-RVA: 0xFBDCF0 Offset: 0xFBC6F0 VA: 0x180FBDCF0
	|-Array.InternalArray__ICollection_Contains<Length>
	|
	|-RVA: 0xFBDE00 Offset: 0xFBC800 VA: 0x180FBDE00
	|-Array.InternalArray__ICollection_Contains<LocalDefinition>
	|
	|-RVA: 0xFBDF20 Offset: 0xFBC920 VA: 0x180FBDF20
	|-Array.InternalArray__ICollection_Contains<LocalKeyword>
	|
	|-RVA: 0xFBE060 Offset: 0xFBCA60 VA: 0x180FBE060
	|-Array.InternalArray__ICollection_Contains<ManipulatorActivationFilter>
	|
	|-RVA: 0xFBE190 Offset: 0xFBCB90 VA: 0x180FBE190
	|-Array.InternalArray__ICollection_Contains<Matrix4x4>
	|
	|-RVA: 0xFBE300 Offset: 0xFBCD00 VA: 0x180FBE300
	|-Array.InternalArray__ICollection_Contains<NamedValue>
	|
	|-RVA: 0xFBE440 Offset: 0xFBCE40 VA: 0x180FBE440
	|-Array.InternalArray__ICollection_Contains<NativeAddr>
	|
	|-RVA: 0xFBE570 Offset: 0xFBCF70 VA: 0x180FBE570
	|-Array.InternalArray__ICollection_Contains<NudgeJobData>
	|-Array.InternalArray__ICollection_Contains<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__ICollection_Contains<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__ICollection_Contains<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__ICollection_Contains<Tilemap.SyncTile>
	|-Array.InternalArray__ICollection_Contains<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0xFBF9A0 Offset: 0xFBE3A0 VA: 0x180FBF9A0
	|-Array.InternalArray__ICollection_Contains<object>
	|
	|-RVA: 0xFBE8C0 Offset: 0xFBD2C0 VA: 0x180FBE8C0
	|-Array.InternalArray__ICollection_Contains<Point>
	|
	|-RVA: 0xFBE790 Offset: 0xFBD190 VA: 0x180FBE790
	|-Array.InternalArray__ICollection_Contains<PointF>
	|
	|-RVA: 0xFBE9D0 Offset: 0xFBD3D0 VA: 0x180FBE9D0
	|-Array.InternalArray__ICollection_Contains<PointerModel>
	|
	|-RVA: 0xFBEC30 Offset: 0xFBD630 VA: 0x180FBEC30
	|-Array.InternalArray__ICollection_Contains<Pollfd>
	|
	|-RVA: 0xFBED40 Offset: 0xFBD740 VA: 0x180FBED40
	|-Array.InternalArray__ICollection_Contains<PublishedFileId_t>
	|
	|-RVA: 0xFBEE80 Offset: 0xFBD880 VA: 0x180FBEE80
	|-Array.InternalArray__ICollection_Contains<Quaternion>
	|
	|-RVA: 0xFBEFA0 Offset: 0xFBD9A0 VA: 0x180FBEFA0
	|-Array.InternalArray__ICollection_Contains<RaycastHit>
	|-Array.InternalArray__ICollection_Contains<VolumetricFog.FogOfWarTransition>
	|
	|-RVA: 0xFBF170 Offset: 0xFBDB70 VA: 0x180FBF170
	|-Array.InternalArray__ICollection_Contains<Rect>
	|
	|-RVA: 0xFBF290 Offset: 0xFBDC90 VA: 0x180FBF290
	|-Array.InternalArray__ICollection_Contains<Rectangle>
	|
	|-RVA: 0xFBF3B0 Offset: 0xFBDDB0 VA: 0x180FBF3B0
	|-Array.InternalArray__ICollection_Contains<RenderStateBlock>
	|
	|-RVA: 0xFBF540 Offset: 0xFBDF40 VA: 0x180FBF540
	|-Array.InternalArray__ICollection_Contains<RenderTargetIdentifier>
	|
	|-RVA: 0xFBF690 Offset: 0xFBE090 VA: 0x180FBF690
	|-Array.InternalArray__ICollection_Contains<RigidbodyState>
	|
	|-RVA: 0xFBF860 Offset: 0xFBE260 VA: 0x180FBF860
	|-Array.InternalArray__ICollection_Contains<Rotate>
	|
	|-RVA: 0xFBFA90 Offset: 0xFBE490 VA: 0x180FBFA90
	|-Array.InternalArray__ICollection_Contains<sbyte>
	|
	|-RVA: 0xFBFBB0 Offset: 0xFBE5B0 VA: 0x180FBFBB0
	|-Array.InternalArray__ICollection_Contains<SamplePointUData>
	|
	|-RVA: 0xFBFCD0 Offset: 0xFBE6D0 VA: 0x180FBFCD0
	|-Array.InternalArray__ICollection_Contains<SamplePointsPatch>
	|
	|-RVA: 0xFBFDE0 Offset: 0xFBE7E0 VA: 0x180FBFDE0
	|-Array.InternalArray__ICollection_Contains<Scale>
	|
	|-RVA: 0xFBFF00 Offset: 0xFBE900 VA: 0x180FBFF00
	|-Array.InternalArray__ICollection_Contains<Scene>
	|
	|-RVA: 0xFC0010 Offset: 0xFBEA10 VA: 0x180FC0010
	|-Array.InternalArray__ICollection_Contains<ShaderTagId>
	|
	|-RVA: 0xFC0120 Offset: 0xFBEB20 VA: 0x180FC0120
	|-Array.InternalArray__ICollection_Contains<ShadowSliceData>
	|
	|-RVA: 0xFC03B0 Offset: 0xFBEDB0 VA: 0x180FC03B0
	|-Array.InternalArray__ICollection_Contains<float>
	|
	|-RVA: 0xFC04E0 Offset: 0xFBEEE0 VA: 0x180FC04E0
	|-Array.InternalArray__ICollection_Contains<SqlBinary>
	|
	|-RVA: 0xFC0620 Offset: 0xFBF020 VA: 0x180FC0620
	|-Array.InternalArray__ICollection_Contains<SqlBoolean>
	|
	|-RVA: 0xFC0760 Offset: 0xFBF160 VA: 0x180FC0760
	|-Array.InternalArray__ICollection_Contains<SqlByte>
	|
	|-RVA: 0xFC08A0 Offset: 0xFBF2A0 VA: 0x180FC08A0
	|-Array.InternalArray__ICollection_Contains<SqlDateTime>
	|
	|-RVA: 0xFC09F0 Offset: 0xFBF3F0 VA: 0x180FC09F0
	|-Array.InternalArray__ICollection_Contains<SqlDecimal>
	|
	|-RVA: 0xFC0B50 Offset: 0xFBF550 VA: 0x180FC0B50
	|-Array.InternalArray__ICollection_Contains<SqlDouble>
	|
	|-RVA: 0xFC0C90 Offset: 0xFBF690 VA: 0x180FC0C90
	|-Array.InternalArray__ICollection_Contains<SqlGuid>
	|
	|-RVA: 0xFC0DD0 Offset: 0xFBF7D0 VA: 0x180FC0DD0
	|-Array.InternalArray__ICollection_Contains<SqlInt16>
	|
	|-RVA: 0xFC0F10 Offset: 0xFBF910 VA: 0x180FC0F10
	|-Array.InternalArray__ICollection_Contains<SqlInt32>
	|
	|-RVA: 0xFC1050 Offset: 0xFBFA50 VA: 0x180FC1050
	|-Array.InternalArray__ICollection_Contains<SqlInt64>
	|
	|-RVA: 0xFC1190 Offset: 0xFBFB90 VA: 0x180FC1190
	|-Array.InternalArray__ICollection_Contains<SqlMoney>
	|
	|-RVA: 0xFC12D0 Offset: 0xFBFCD0 VA: 0x180FC12D0
	|-Array.InternalArray__ICollection_Contains<SqlSingle>
	|
	|-RVA: 0xFC1410 Offset: 0xFBFE10 VA: 0x180FC1410
	|-Array.InternalArray__ICollection_Contains<SqlString>
	|
	|-RVA: 0xFC4530 Offset: 0xFC2F30 VA: 0x180FC4530
	|-Array.InternalArray__ICollection_Contains<SteamItemDef_t>
	|
	|-RVA: 0xFC4640 Offset: 0xFC3040 VA: 0x180FC4640
	|-Array.InternalArray__ICollection_Contains<SteamItemInstanceID_t>
	|
	|-RVA: 0xFC4780 Offset: 0xFC3180 VA: 0x180FC4780
	|-Array.InternalArray__ICollection_Contains<StylePropertyName>
	|
	|-RVA: 0xFC48A0 Offset: 0xFC32A0 VA: 0x180FC48A0
	|-Array.InternalArray__ICollection_Contains<Substring>
	|
	|-RVA: 0xFC49C0 Offset: 0xFC33C0 VA: 0x180FC49C0
	|-Array.InternalArray__ICollection_Contains<TMP_CharacterInfo>
	|
	|-RVA: 0xFC4C80 Offset: 0xFC3680 VA: 0x180FC4C80
	|-Array.InternalArray__ICollection_Contains<TextElementInfo>
	|
	|-RVA: 0xFC4ED0 Offset: 0xFC38D0 VA: 0x180FC4ED0
	|-Array.InternalArray__ICollection_Contains<TextShadow>
	|
	|-RVA: 0xFC5010 Offset: 0xFC3A10 VA: 0x180FC5010
	|-Array.InternalArray__ICollection_Contains<TextureId>
	|
	|-RVA: 0xFC5150 Offset: 0xFC3B50 VA: 0x180FC5150
	|-Array.InternalArray__ICollection_Contains<TimeSpan>
	|
	|-RVA: 0xFC5290 Offset: 0xFC3C90 VA: 0x180FC5290
	|-Array.InternalArray__ICollection_Contains<TimeValue>
	|
	|-RVA: 0xFC53A0 Offset: 0xFC3DA0 VA: 0x180FC53A0
	|-Array.InternalArray__ICollection_Contains<Touch>
	|
	|-RVA: 0xFC5570 Offset: 0xFC3F70 VA: 0x180FC5570
	|-Array.InternalArray__ICollection_Contains<Touch>
	|
	|-RVA: 0xFC56D0 Offset: 0xFC40D0 VA: 0x180FC56D0
	|-Array.InternalArray__ICollection_Contains<TransformOrigin>
	|
	|-RVA: 0xFC5920 Offset: 0xFC4320 VA: 0x180FC5920
	|-Array.InternalArray__ICollection_Contains<Translate>
	|
	|-RVA: 0xFC5A60 Offset: 0xFC4460 VA: 0x180FC5A60
	|-Array.InternalArray__ICollection_Contains<UIVertex>
	|
	|-RVA: 0xFC5DC0 Offset: 0xFC47C0 VA: 0x180FC5DC0
	|-Array.InternalArray__ICollection_Contains<ushort>
	|
	|-RVA: 0xFC5C70 Offset: 0xFC4670 VA: 0x180FC5C70
	|-Array.InternalArray__ICollection_Contains<UInt16Enum>
	|
	|-RVA: 0xFC5ED0 Offset: 0xFC48D0 VA: 0x180FC5ED0
	|-Array.InternalArray__ICollection_Contains<uint>
	|
	|-RVA: 0xFC5FE0 Offset: 0xFC49E0 VA: 0x180FC5FE0
	|-Array.InternalArray__ICollection_Contains<ulong>
	|
	|-RVA: 0xFC6680 Offset: 0xFC5080 VA: 0x180FC6680
	|-Array.InternalArray__ICollection_Contains<Vector2>
	|
	|-RVA: 0xFC6570 Offset: 0xFC4F70 VA: 0x180FC6570
	|-Array.InternalArray__ICollection_Contains<Vector2Int>
	|
	|-RVA: 0xFC68E0 Offset: 0xFC52E0 VA: 0x180FC68E0
	|-Array.InternalArray__ICollection_Contains<Vector3>
	|
	|-RVA: 0xFC67B0 Offset: 0xFC51B0 VA: 0x180FC67B0
	|-Array.InternalArray__ICollection_Contains<Vector3Int>
	|
	|-RVA: 0xFC6A10 Offset: 0xFC5410 VA: 0x180FC6A10
	|-Array.InternalArray__ICollection_Contains<Vector4>
	|
	|-RVA: 0xFC6B30 Offset: 0xFC5530 VA: 0x180FC6B30
	|-Array.InternalArray__ICollection_Contains<VertexAttributeDescriptor>
	|
	|-RVA: 0xFC6C50 Offset: 0xFC5650 VA: 0x180FC6C50
	|-Array.InternalArray__ICollection_Contains<VisibleLight>
	|
	|-RVA: 0xFC6DE0 Offset: 0xFC57E0 VA: 0x180FC6DE0
	|-Array.InternalArray__ICollection_Contains<VisibleReflectionProbe>
	|
	|-RVA: 0xFC6F90 Offset: 0xFC5990 VA: 0x180FC6F90
	|-Array.InternalArray__ICollection_Contains<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xFC71E0 Offset: 0xFC5BE0 VA: 0x180FC71E0
	|-Array.InternalArray__ICollection_Contains<WordWrapState>
	|
	|-RVA: 0xFC7440 Offset: 0xFC5E40 VA: 0x180FC7440
	|-Array.InternalArray__ICollection_Contains<XEvent>
	|
	|-RVA: 0xFC76C0 Offset: 0xFC60C0 VA: 0x180FC76C0
	|-Array.InternalArray__ICollection_Contains<XRView>
	|
	|-RVA: 0xFC3BD0 Offset: 0xFC25D0 VA: 0x180FC3BD0
	|-Array.InternalArray__ICollection_Contains<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xFC7920 Offset: 0xFC6320 VA: 0x180FC7920
	|-Array.InternalArray__ICollection_Contains<double2>
	|
	|-RVA: 0xFC7A40 Offset: 0xFC6440 VA: 0x180FC7A40
	|-Array.InternalArray__ICollection_Contains<float2>
	|
	|-RVA: 0xFC7B70 Offset: 0xFC6570 VA: 0x180FC7B70
	|-Array.InternalArray__ICollection_Contains<float3>
	|
	|-RVA: 0xFC7CA0 Offset: 0xFC66A0 VA: 0x180FC7CA0
	|-Array.InternalArray__ICollection_Contains<float4>
	|
	|-RVA: 0xFC7DC0 Offset: 0xFC67C0 VA: 0x180FC7DC0
	|-Array.InternalArray__ICollection_Contains<float4x4>
	|
	|-RVA: 0xFC7F30 Offset: 0xFC6930 VA: 0x180FC7F30
	|-Array.InternalArray__ICollection_Contains<int2>
	|
	|-RVA: 0xFC8040 Offset: 0xFC6A40 VA: 0x180FC8040
	|-Array.InternalArray__ICollection_Contains<int3>
	|
	|-RVA: 0xFC8170 Offset: 0xFC6B70 VA: 0x180FC8170
	|-Array.InternalArray__ICollection_Contains<int4>
	|
	|-RVA: 0xFC8290 Offset: 0xFC6C90 VA: 0x180FC8290
	|-Array.InternalArray__ICollection_Contains<quaternion>
	|
	|-RVA: 0xFC6370 Offset: 0xFC4D70 VA: 0x180FC6370
	|-Array.InternalArray__ICollection_Contains<Agent.VO>
	|
	|-RVA: 0xFC3E40 Offset: 0xFC2840 VA: 0x180FC3E40
	|-Array.InternalArray__ICollection_Contains<ClipperLib.IntPoint>
	|
	|-RVA: 0xFC3350 Offset: 0xFC1D50 VA: 0x180FC3350
	|-Array.InternalArray__ICollection_Contains<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xFC3590 Offset: 0xFC1F90 VA: 0x180FC3590
	|-Array.InternalArray__ICollection_Contains<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xFC3750 Offset: 0xFC2150 VA: 0x180FC3750
	|-Array.InternalArray__ICollection_Contains<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xFC3990 Offset: 0xFC2390 VA: 0x180FC3990
	|-Array.InternalArray__ICollection_Contains<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xFC2FA0 Offset: 0xFC19A0 VA: 0x180FC2FA0
	|-Array.InternalArray__ICollection_Contains<InputControlLayout.ControlItem>
	|
	|-RVA: 0xFC3230 Offset: 0xFC1C30 VA: 0x180FC3230
	|-Array.InternalArray__ICollection_Contains<InputControlScheme.DeviceRequirement>
	|
	|-RVA: 0xFC2E00 Offset: 0xFC1800 VA: 0x180FC2E00
	|-Array.InternalArray__ICollection_Contains<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xFC4410 Offset: 0xFC2E10 VA: 0x180FC4410
	|-Array.InternalArray__ICollection_Contains<InputStateHistory.Record>
	|
	|-RVA: 0xFC5800 Offset: 0xFC4200 VA: 0x180FC5800
	|-Array.InternalArray__ICollection_Contains<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xFC60F0 Offset: 0xFC4AF0 VA: 0x180FC60F0
	|-Array.InternalArray__ICollection_Contains<InputUser.UserData>
	|
	|-RVA: 0xFC3F60 Offset: 0xFC2960 VA: 0x180FC3F60
	|-Array.InternalArray__ICollection_Contains<JsonParser.JsonValue>
	|
	|-RVA: 0xFC42C0 Offset: 0xFC2CC0 VA: 0x180FC42C0
	|-Array.InternalArray__ICollection_Contains<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__ICollection_Contains<SVGDocument.MaskData>
	|
	|-RVA: 0xFC2CC0 Offset: 0xFC16C0 VA: 0x180FC2CC0
	|-Array.InternalArray__ICollection_Contains<Regex.CachedCodeEntryKey>
	|
	|-RVA: 0xFC40E0 Offset: 0xFC2AE0 VA: 0x180FC40E0
	|-Array.InternalArray__ICollection_Contains<ShaderInput.LightData>
	|
	|-RVA: 0xFC83B0 Offset: 0xFC6DB0 VA: 0x180FC83B0
	|-Array.InternalArray__ICollection_Contains<XmlSqlBinaryReader.QName>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC84F0 Offset: 0xFC6EF0 VA: 0x180FC84F0
	|-Array.InternalArray__ICollection_CopyTo<ArraySegment<byte>>
	|-Array.InternalArray__ICollection_CopyTo<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__ICollection_CopyTo<SyncList.ChangeData<int>>
	|-Array.InternalArray__ICollection_CopyTo<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__ICollection_CopyTo<IntervalTree.Entry<object>>
	|-Array.InternalArray__ICollection_CopyTo<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, short>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, long>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, float>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<long, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, double>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, long>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, float>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__ICollection_CopyTo<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Guid, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int2, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int2, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int3, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, bool>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, short>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Int3>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, long>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, float>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, uint>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, ulong>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<long, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, bool>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, char>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Color>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Color32>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, double>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, long>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Playable>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Rect>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, float>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Rect, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Scene, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ushort, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__ICollection_CopyTo<KeyValue<int, int>>
	|-Array.InternalArray__ICollection_CopyTo<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_CopyTo<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_CopyTo<NativeArray<NudgeJobData>>
	|-Array.InternalArray__ICollection_CopyTo<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__ICollection_CopyTo<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__ICollection_CopyTo<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__ICollection_CopyTo<RBTree.Node<int>>
	|-Array.InternalArray__ICollection_CopyTo<RBTree.Node<object>>
	|-Array.InternalArray__ICollection_CopyTo<Nullable<DateTime>>
	|-Array.InternalArray__ICollection_CopyTo<Nullable<Decimal>>
	|-Array.InternalArray__ICollection_CopyTo<TempAllocator.Page<ushort>>
	|-Array.InternalArray__ICollection_CopyTo<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__ICollection_CopyTo<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<bool>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<char>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<int>>
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<int>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<InternedString>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<object>>
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<object>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Scene>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<uint>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<ulong>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__ICollection_CopyTo<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__ICollection_CopyTo<StructMultiKey<object, object>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__ICollection_CopyTo<SubArray<int>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<Color32>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<int>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<object>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<float>>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__ICollection_CopyTo<TreeViewItemData<object>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, int>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, object>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Scene>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, int>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object>>
	|-Array.InternalArray__ICollection_CopyTo<AnimatorClipInfo>
	|-Array.InternalArray__ICollection_CopyTo<AppId_t>
	|-Array.InternalArray__ICollection_CopyTo<AstarWorkItem>
	|-Array.InternalArray__ICollection_CopyTo<AsyncGPUReadbackRequest>
	|-Array.InternalArray__ICollection_CopyTo<AttachmentDescriptor>
	|-Array.InternalArray__ICollection_CopyTo<Background>
	|-Array.InternalArray__ICollection_CopyTo<BackgroundPosition>
	|-Array.InternalArray__ICollection_CopyTo<BackgroundRepeat>
	|-Array.InternalArray__ICollection_CopyTo<BackgroundSize>
	|-Array.InternalArray__ICollection_CopyTo<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__ICollection_CopyTo<BezierContour>
	|-Array.InternalArray__ICollection_CopyTo<BezierPathSegment>
	|-Array.InternalArray__ICollection_CopyTo<BezierSegment>
	|-Array.InternalArray__ICollection_CopyTo<BigInteger>
	|-Array.InternalArray__ICollection_CopyTo<Board>
	|-Array.InternalArray__ICollection_CopyTo<bool>
	|-Array.InternalArray__ICollection_CopyTo<BoundingSphere>
	|-Array.InternalArray__ICollection_CopyTo<Bounds>
	|-Array.InternalArray__ICollection_CopyTo<BoundsInt>
	|-Array.InternalArray__ICollection_CopyTo<byte>
	|-Array.InternalArray__ICollection_CopyTo<ByteEnum>
	|-Array.InternalArray__ICollection_CopyTo<CGSpot>
	|-Array.InternalArray__ICollection_CopyTo<CSteamID>
	|-Array.InternalArray__ICollection_CopyTo<char>
	|-Array.InternalArray__ICollection_CopyTo<Color>
	|-Array.InternalArray__ICollection_CopyTo<Color>
	|-Array.InternalArray__ICollection_CopyTo<Color32>
	|-Array.InternalArray__ICollection_CopyTo<ColorBlock>
	|-Array.InternalArray__ICollection_CopyTo<CombineInstance>
	|-Array.InternalArray__ICollection_CopyTo<CompactVoxelCell>
	|-Array.InternalArray__ICollection_CopyTo<CompactVoxelSpan>
	|-Array.InternalArray__ICollection_CopyTo<ComputedStyle>
	|-Array.InternalArray__ICollection_CopyTo<ComputedTransitionProperty>
	|-Array.InternalArray__ICollection_CopyTo<Connection>
	|-Array.InternalArray__ICollection_CopyTo<ContactPairHeader>
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint>
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint2D>
	|-Array.InternalArray__ICollection_CopyTo<ContourVertex>
	|-Array.InternalArray__ICollection_CopyTo<ContourVertex>
	|-Array.InternalArray__ICollection_CopyTo<ControlPointOption>
	|-Array.InternalArray__ICollection_CopyTo<ConvertMeshJobData>
	|-Array.InternalArray__ICollection_CopyTo<CoordinateFootprintTilePair>
	|-Array.InternalArray__ICollection_CopyTo<CoordinateProceduralTilePair>
	|-Array.InternalArray__ICollection_CopyTo<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__ICollection_CopyTo<CoordinateStorageTilePair>
	|-Array.InternalArray__ICollection_CopyTo<CoordinateTilePair>
	|-Array.InternalArray__ICollection_CopyTo<CopyClosingMeshJobData>
	|-Array.InternalArray__ICollection_CopyTo<CullingSplit>
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeNamedArgument>
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeTypedArgument>
	|-Array.InternalArray__ICollection_CopyTo<DateTime>
	|-Array.InternalArray__ICollection_CopyTo<DateTimeOffset>
	|-Array.InternalArray__ICollection_CopyTo<DecalEntity>
	|-Array.InternalArray__ICollection_CopyTo<DecalSubDrawCall>
	|-Array.InternalArray__ICollection_CopyTo<Decimal>
	|-Array.InternalArray__ICollection_CopyTo<DepotId_t>
	|-Array.InternalArray__ICollection_CopyTo<DictionaryEntry>
	|-Array.InternalArray__ICollection_CopyTo<Dimension>
	|-Array.InternalArray__ICollection_CopyTo<DisplayInfo>
	|-Array.InternalArray__ICollection_CopyTo<double>
	|-Array.InternalArray__ICollection_CopyTo<DoublePoint>
	|-Array.InternalArray__ICollection_CopyTo<DoublePoint>
	|-Array.InternalArray__ICollection_CopyTo<DrawBufferRange>
	|-Array.InternalArray__ICollection_CopyTo<DualPrefab>
	|-Array.InternalArray__ICollection_CopyTo<DuplicateSamplePoint>
	|-Array.InternalArray__ICollection_CopyTo<EasingFunction>
	|-Array.InternalArray__ICollection_CopyTo<Entry>
	|-Array.InternalArray__ICollection_CopyTo<EnumData>
	|-Array.InternalArray__ICollection_CopyTo<Ephemeron>
	|-Array.InternalArray__ICollection_CopyTo<EventSummary>
	|-Array.InternalArray__ICollection_CopyTo<EventTypeSpec>
	|-Array.InternalArray__ICollection_CopyTo<ExtensionFilter>
	|-Array.InternalArray__ICollection_CopyTo<FixedString128Bytes>
	|-Array.InternalArray__ICollection_CopyTo<FontDefinition>
	|-Array.InternalArray__ICollection_CopyTo<FontWeightPair>
	|-Array.InternalArray__ICollection_CopyTo<FrameTimeSample>
	|-Array.InternalArray__ICollection_CopyTo<FrameTiming>
	|-Array.InternalArray__ICollection_CopyTo<FullRank>
	|-Array.InternalArray__ICollection_CopyTo<GCHandle>
	|-Array.InternalArray__ICollection_CopyTo<GfxUpdateBufferRange>
	|-Array.InternalArray__ICollection_CopyTo<GlyphMarshallingStruct>
	|-Array.InternalArray__ICollection_CopyTo<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__ICollection_CopyTo<GlyphRect>
	|-Array.InternalArray__ICollection_CopyTo<GradientAlphaKey>
	|-Array.InternalArray__ICollection_CopyTo<GradientColorKey>
	|-Array.InternalArray__ICollection_CopyTo<GradientSettings>
	|-Array.InternalArray__ICollection_CopyTo<GradientStop>
	|-Array.InternalArray__ICollection_CopyTo<Guid>
	|-Array.InternalArray__ICollection_CopyTo<HSteamNetConnection>
	|-Array.InternalArray__ICollection_CopyTo<Hash128>
	|-Array.InternalArray__ICollection_CopyTo<HeaderVariantInfo>
	|-Array.InternalArray__ICollection_CopyTo<HighlightState>
	|-Array.InternalArray__ICollection_CopyTo<HighlightState>
	|-Array.InternalArray__ICollection_CopyTo<HumanBone>
	|-Array.InternalArray__ICollection_CopyTo<InclusiveRange>
	|-Array.InternalArray__ICollection_CopyTo<IndexField>
	|-Array.InternalArray__ICollection_CopyTo<IndexRange>
	|-Array.InternalArray__ICollection_CopyTo<InputActionSetHandle_t>
	|-Array.InternalArray__ICollection_CopyTo<InputBinding>
	|-Array.InternalArray__ICollection_CopyTo<InputControlScheme>
	|-Array.InternalArray__ICollection_CopyTo<InputDeviceDescription>
	|-Array.InternalArray__ICollection_CopyTo<InputEventPtr>
	|-Array.InternalArray__ICollection_CopyTo<InputHandle_t>
	|-Array.InternalArray__ICollection_CopyTo<InputUser>
	|-Array.InternalArray__ICollection_CopyTo<short>
	|-Array.InternalArray__ICollection_CopyTo<Int2>
	|-Array.InternalArray__ICollection_CopyTo<Int3>
	|-Array.InternalArray__ICollection_CopyTo<int>
	|-Array.InternalArray__ICollection_CopyTo<Int32Enum>
	|-Array.InternalArray__ICollection_CopyTo<long>
	|-Array.InternalArray__ICollection_CopyTo<IntPoint>
	|-Array.InternalArray__ICollection_CopyTo<IntPoint>
	|-Array.InternalArray__ICollection_CopyTo<IntPtr>
	|-Array.InternalArray__ICollection_CopyTo<IntRect>
	|-Array.InternalArray__ICollection_CopyTo<IntRegion>
	|-Array.InternalArray__ICollection_CopyTo<InternalCodePageDataItem>
	|-Array.InternalArray__ICollection_CopyTo<InternalEncodingDataItem>
	|-Array.InternalArray__ICollection_CopyTo<InternedString>
	|-Array.InternalArray__ICollection_CopyTo<InterpretedFrameInfo>
	|-Array.InternalArray__ICollection_CopyTo<IntervalTreeNode>
	|-Array.InternalArray__ICollection_CopyTo<JobHandle>
	|-Array.InternalArray__ICollection_CopyTo<JsonPosition>
	|-Array.InternalArray__ICollection_CopyTo<KeyStruct>
	|-Array.InternalArray__ICollection_CopyTo<Keyframe>
	|-Array.InternalArray__ICollection_CopyTo<Label>
	|-Array.InternalArray__ICollection_CopyTo<LayerBatch>
	|-Array.InternalArray__ICollection_CopyTo<LayerMask>
	|-Array.InternalArray__ICollection_CopyTo<Length>
	|-Array.InternalArray__ICollection_CopyTo<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_CopyTo<LigatureSubstitutionRecord>
	|-Array.InternalArray__ICollection_CopyTo<Light2DBlendStyle>
	|-Array.InternalArray__ICollection_CopyTo<LightDataGI>
	|-Array.InternalArray__ICollection_CopyTo<LineInfo>
	|-Array.InternalArray__ICollection_CopyTo<LinkInfo>
	|-Array.InternalArray__ICollection_CopyTo<LinkedVoxelSpan>
	|-Array.InternalArray__ICollection_CopyTo<List>
	|-Array.InternalArray__ICollection_CopyTo<LocalDefinition>
	|-Array.InternalArray__ICollection_CopyTo<LocalKeyword>
	|-Array.InternalArray__ICollection_CopyTo<LocalPacket>
	|-Array.InternalArray__ICollection_CopyTo<LocalPacket>
	|-Array.InternalArray__ICollection_CopyTo<ManipulatorActivationFilter>
	|-Array.InternalArray__ICollection_CopyTo<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_CopyTo<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__ICollection_CopyTo<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_CopyTo<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__ICollection_CopyTo<MarkupAttribute>
	|-Array.InternalArray__ICollection_CopyTo<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__ICollection_CopyTo<MaterialReference>
	|-Array.InternalArray__ICollection_CopyTo<MaterialReference>
	|-Array.InternalArray__ICollection_CopyTo<Matrix4x4>
	|-Array.InternalArray__ICollection_CopyTo<MeshInfo>
	|-Array.InternalArray__ICollection_CopyTo<ModifiableContactPair>
	|-Array.InternalArray__ICollection_CopyTo<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_CopyTo<MultipleSubstitutionRecord>
	|-Array.InternalArray__ICollection_CopyTo<NameAndParameters>
	|-Array.InternalArray__ICollection_CopyTo<NamedValue>
	|-Array.InternalArray__ICollection_CopyTo<NativeAddr>
	|-Array.InternalArray__ICollection_CopyTo<NavMeshBuildMarkup>
	|-Array.InternalArray__ICollection_CopyTo<NavMeshBuildSource>
	|-Array.InternalArray__ICollection_CopyTo<Navigation>
	|-Array.InternalArray__ICollection_CopyTo<NudgeJobData>
	|-Array.InternalArray__ICollection_CopyTo<object>
	|-Array.InternalArray__ICollection_CopyTo<Packet>
	|-Array.InternalArray__ICollection_CopyTo<PageInfo>
	|-Array.InternalArray__ICollection_CopyTo<ParameterModifier>
	|-Array.InternalArray__ICollection_CopyTo<Plane>
	|-Array.InternalArray__ICollection_CopyTo<Playable>
	|-Array.InternalArray__ICollection_CopyTo<PlayableBinding>
	|-Array.InternalArray__ICollection_CopyTo<PlayerLoopSystem>
	|-Array.InternalArray__ICollection_CopyTo<PlayerLoopSystemInternal>
	|-Array.InternalArray__ICollection_CopyTo<Point>
	|-Array.InternalArray__ICollection_CopyTo<PointF>
	|-Array.InternalArray__ICollection_CopyTo<PointerModel>
	|-Array.InternalArray__ICollection_CopyTo<Pollfd>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__ICollection_CopyTo<Progress>
	|-Array.InternalArray__ICollection_CopyTo<PublishedFileId_t>
	|-Array.InternalArray__ICollection_CopyTo<QosResult>
	|-Array.InternalArray__ICollection_CopyTo<Quaternion>
	|-Array.InternalArray__ICollection_CopyTo<RangePositionInfo>
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit>
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit2D>
	|-Array.InternalArray__ICollection_CopyTo<RaycastResult>
	|-Array.InternalArray__ICollection_CopyTo<Rect>
	|-Array.InternalArray__ICollection_CopyTo<RectInt>
	|-Array.InternalArray__ICollection_CopyTo<Rectangle>
	|-Array.InternalArray__ICollection_CopyTo<RemoteConnectionEvent>
	|-Array.InternalArray__ICollection_CopyTo<RenderBuffer>
	|-Array.InternalArray__ICollection_CopyTo<RenderInstancedDataLayout>
	|-Array.InternalArray__ICollection_CopyTo<RenderStateBlock>
	|-Array.InternalArray__ICollection_CopyTo<RenderTargetIdentifier>
	|-Array.InternalArray__ICollection_CopyTo<RendererList>
	|-Array.InternalArray__ICollection_CopyTo<RendererListHandle>
	|-Array.InternalArray__ICollection_CopyTo<RendererListResource>
	|-Array.InternalArray__ICollection_CopyTo<Resolution>
	|-Array.InternalArray__ICollection_CopyTo<ResourceHandle>
	|-Array.InternalArray__ICollection_CopyTo<ResourceLocator>
	|-Array.InternalArray__ICollection_CopyTo<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_CopyTo<RichTextTagAttribute>
	|-Array.InternalArray__ICollection_CopyTo<Rigidbody2DState>
	|-Array.InternalArray__ICollection_CopyTo<RigidbodyState>
	|-Array.InternalArray__ICollection_CopyTo<Rotate>
	|-Array.InternalArray__ICollection_CopyTo<RpcLink>
	|-Array.InternalArray__ICollection_CopyTo<RpcLinkType>
	|-Array.InternalArray__ICollection_CopyTo<RuleMatcher>
	|-Array.InternalArray__ICollection_CopyTo<RuntimeLabel>
	|-Array.InternalArray__ICollection_CopyTo<sbyte>
	|-Array.InternalArray__ICollection_CopyTo<SByteEnum>
	|-Array.InternalArray__ICollection_CopyTo<SamplePointUData>
	|-Array.InternalArray__ICollection_CopyTo<SamplePointsPatch>
	|-Array.InternalArray__ICollection_CopyTo<ScalableImage>
	|-Array.InternalArray__ICollection_CopyTo<Scale>
	|-Array.InternalArray__ICollection_CopyTo<Scene>
	|-Array.InternalArray__ICollection_CopyTo<SecondarySpriteTexture>
	|-Array.InternalArray__ICollection_CopyTo<SelectorMatchRecord>
	|-Array.InternalArray__ICollection_CopyTo<SemanticMeaning>
	|-Array.InternalArray__ICollection_CopyTo<ShaderKeyword>
	|-Array.InternalArray__ICollection_CopyTo<ShaderTagId>
	|-Array.InternalArray__ICollection_CopyTo<ShaderVariablesProbeVolumes>
	|-Array.InternalArray__ICollection_CopyTo<ShadowSliceData>
	|-Array.InternalArray__ICollection_CopyTo<float>
	|-Array.InternalArray__ICollection_CopyTo<SkeletonBone>
	|-Array.InternalArray__ICollection_CopyTo<SortingLayer>
	|-Array.InternalArray__ICollection_CopyTo<SpriteState>
	|-Array.InternalArray__ICollection_CopyTo<SqlBinary>
	|-Array.InternalArray__ICollection_CopyTo<SqlBoolean>
	|-Array.InternalArray__ICollection_CopyTo<SqlByte>
	|-Array.InternalArray__ICollection_CopyTo<SqlDateTime>
	|-Array.InternalArray__ICollection_CopyTo<SqlDecimal>
	|-Array.InternalArray__ICollection_CopyTo<SqlDouble>
	|-Array.InternalArray__ICollection_CopyTo<SqlGuid>
	|-Array.InternalArray__ICollection_CopyTo<SqlInt16>
	|-Array.InternalArray__ICollection_CopyTo<SqlInt32>
	|-Array.InternalArray__ICollection_CopyTo<SqlInt64>
	|-Array.InternalArray__ICollection_CopyTo<SqlMoney>
	|-Array.InternalArray__ICollection_CopyTo<SqlSingle>
	|-Array.InternalArray__ICollection_CopyTo<SqlString>
	|-Array.InternalArray__ICollection_CopyTo<SteamItemDef_t>
	|-Array.InternalArray__ICollection_CopyTo<SteamItemDetails_t>
	|-Array.InternalArray__ICollection_CopyTo<SteamItemInstanceID_t>
	|-Array.InternalArray__ICollection_CopyTo<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__ICollection_CopyTo<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyName>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyValue>
	|-Array.InternalArray__ICollection_CopyTo<StyleSelectorPart>
	|-Array.InternalArray__ICollection_CopyTo<StyleSyntaxToken>
	|-Array.InternalArray__ICollection_CopyTo<StyleValue>
	|-Array.InternalArray__ICollection_CopyTo<StyleValueHandle>
	|-Array.InternalArray__ICollection_CopyTo<StyleValueManaged>
	|-Array.InternalArray__ICollection_CopyTo<StyleVariable>
	|-Array.InternalArray__ICollection_CopyTo<Substring>
	|-Array.InternalArray__ICollection_CopyTo<TMP_CharacterInfo>
	|-Array.InternalArray__ICollection_CopyTo<TMP_FontWeightPair>
	|-Array.InternalArray__ICollection_CopyTo<TMP_LineInfo>
	|-Array.InternalArray__ICollection_CopyTo<TMP_LinkInfo>
	|-Array.InternalArray__ICollection_CopyTo<TMP_MeshInfo>
	|-Array.InternalArray__ICollection_CopyTo<TMP_PageInfo>
	|-Array.InternalArray__ICollection_CopyTo<TMP_WordInfo>
	|-Array.InternalArray__ICollection_CopyTo<TemperatureEmitterInfo>
	|-Array.InternalArray__ICollection_CopyTo<TerrainTileCoord>
	|-Array.InternalArray__ICollection_CopyTo<TextElementInfo>
	|-Array.InternalArray__ICollection_CopyTo<TextProcessingElement>
	|-Array.InternalArray__ICollection_CopyTo<TextShadow>
	|-Array.InternalArray__ICollection_CopyTo<TextureHandle>
	|-Array.InternalArray__ICollection_CopyTo<TextureId>
	|-Array.InternalArray__ICollection_CopyTo<TileData>
	|-Array.InternalArray__ICollection_CopyTo<TimeSpan>
	|-Array.InternalArray__ICollection_CopyTo<TimeValue>
	|-Array.InternalArray__ICollection_CopyTo<Touch>
	|-Array.InternalArray__ICollection_CopyTo<Touch>
	|-Array.InternalArray__ICollection_CopyTo<Transform3x4>
	|-Array.InternalArray__ICollection_CopyTo<TransformOrigin>
	|-Array.InternalArray__ICollection_CopyTo<Translate>
	|-Array.InternalArray__ICollection_CopyTo<TreeInstance>
	|-Array.InternalArray__ICollection_CopyTo<TreeItem>
	|-Array.InternalArray__ICollection_CopyTo<TreeViewItemWrapper>
	|-Array.InternalArray__ICollection_CopyTo<UEncroachingSegment>
	|-Array.InternalArray__ICollection_CopyTo<UEvent>
	|-Array.InternalArray__ICollection_CopyTo<UHull>
	|-Array.InternalArray__ICollection_CopyTo<UICharInfo>
	|-Array.InternalArray__ICollection_CopyTo<UILineInfo>
	|-Array.InternalArray__ICollection_CopyTo<UIVertex>
	|-Array.InternalArray__ICollection_CopyTo<ushort>
	|-Array.InternalArray__ICollection_CopyTo<UInt16Enum>
	|-Array.InternalArray__ICollection_CopyTo<uint>
	|-Array.InternalArray__ICollection_CopyTo<UInt32Enum>
	|-Array.InternalArray__ICollection_CopyTo<ulong>
	|-Array.InternalArray__ICollection_CopyTo<UShort2>
	|-Array.InternalArray__ICollection_CopyTo<UStar>
	|-Array.InternalArray__ICollection_CopyTo<UTriangle>
	|-Array.InternalArray__ICollection_CopyTo<UnloadedScene>
	|-Array.InternalArray__ICollection_CopyTo<UsageHint>
	|-Array.InternalArray__ICollection_CopyTo<Vector2>
	|-Array.InternalArray__ICollection_CopyTo<Vector2Int>
	|-Array.InternalArray__ICollection_CopyTo<Vector3>
	|-Array.InternalArray__ICollection_CopyTo<Vector3Int>
	|-Array.InternalArray__ICollection_CopyTo<Vector4>
	|-Array.InternalArray__ICollection_CopyTo<VectorImageVertex>
	|-Array.InternalArray__ICollection_CopyTo<Vertex>
	|-Array.InternalArray__ICollection_CopyTo<VertexAttributeDescriptor>
	|-Array.InternalArray__ICollection_CopyTo<VisibleLight>
	|-Array.InternalArray__ICollection_CopyTo<VisibleReflectionProbe>
	|-Array.InternalArray__ICollection_CopyTo<VoxelContour>
	|-Array.InternalArray__ICollection_CopyTo<Win32_IP_ADAPTER_ADDRESSES>
	|-Array.InternalArray__ICollection_CopyTo<WordInfo>
	|-Array.InternalArray__ICollection_CopyTo<WordWrapState>
	|-Array.InternalArray__ICollection_CopyTo<WordWrapState>
	|-Array.InternalArray__ICollection_CopyTo<X509ChainStatus>
	|-Array.InternalArray__ICollection_CopyTo<XEvent>
	|-Array.InternalArray__ICollection_CopyTo<XPathNode>
	|-Array.InternalArray__ICollection_CopyTo<XPathNodeRef>
	|-Array.InternalArray__ICollection_CopyTo<XRFeatureDescriptor>
	|-Array.InternalArray__ICollection_CopyTo<XRView>
	|-Array.InternalArray__ICollection_CopyTo<ZipGenericExtraField>
	|-Array.InternalArray__ICollection_CopyTo<__Il2CppFullySharedGenericType>
	|-Array.InternalArray__ICollection_CopyTo<double2>
	|-Array.InternalArray__ICollection_CopyTo<float2>
	|-Array.InternalArray__ICollection_CopyTo<float3>
	|-Array.InternalArray__ICollection_CopyTo<float4>
	|-Array.InternalArray__ICollection_CopyTo<float4x4>
	|-Array.InternalArray__ICollection_CopyTo<int2>
	|-Array.InternalArray__ICollection_CopyTo<int3>
	|-Array.InternalArray__ICollection_CopyTo<int4>
	|-Array.InternalArray__ICollection_CopyTo<jvalue>
	|-Array.InternalArray__ICollection_CopyTo<quaternion>
	|-Array.InternalArray__ICollection_CopyTo<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__ICollection_CopyTo<AdvancedSmooth.Turn>
	|-Array.InternalArray__ICollection_CopyTo<Agent.VO>
	|-Array.InternalArray__ICollection_CopyTo<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__ICollection_CopyTo<AnimationWarping.Warp>
	|-Array.InternalArray__ICollection_CopyTo<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__ICollection_CopyTo<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__ICollection_CopyTo<AstarDebugger.GraphPoint>
	|-Array.InternalArray__ICollection_CopyTo<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__ICollection_CopyTo<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__ICollection_CopyTo<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__ICollection_CopyTo<AvatarSettings.LayerSetting>
	|-Array.InternalArray__ICollection_CopyTo<BBTree.BBTreeBox>
	|-Array.InternalArray__ICollection_CopyTo<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__ICollection_CopyTo<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__ICollection_CopyTo<BinaryHeap.Tuple>
	|-Array.InternalArray__ICollection_CopyTo<BitmapAllocator32.Page>
	|-Array.InternalArray__ICollection_CopyTo<BlitUtility.Vertex>
	|-Array.InternalArray__ICollection_CopyTo<BloomRenderer.Level>
	|-Array.InternalArray__ICollection_CopyTo<CameraState.CustomBlendable>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineClearShot.Pair>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__ICollection_CopyTo<CinemachinePath.Waypoint>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__ICollection_CopyTo<CinemachineTargetGroup.Target>
	|-Array.InternalArray__ICollection_CopyTo<ClipperLib.DoublePoint>
	|-Array.InternalArray__ICollection_CopyTo<ClipperLib.IntPoint>
	|-Array.InternalArray__ICollection_CopyTo<CodePointIndexer.TableRange>
	|-Array.InternalArray__ICollection_CopyTo<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__ICollection_CopyTo<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__ICollection_CopyTo<Cursor.CursorEntry>
	|-Array.InternalArray__ICollection_CopyTo<Cursor.CursorImage>
	|-Array.InternalArray__ICollection_CopyTo<DataError.ColumnError>
	|-Array.InternalArray__ICollection_CopyTo<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__ICollection_CopyTo<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__ICollection_CopyTo<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__ICollection_CopyTo<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__ICollection_CopyTo<EventDispatcher.DispatchContext>
	|-Array.InternalArray__ICollection_CopyTo<EventDispatcher.EventRecord>
	|-Array.InternalArray__ICollection_CopyTo<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__ICollection_CopyTo<ExpressionParser.ReservedWords>
	|-Array.InternalArray__ICollection_CopyTo<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__ICollection_CopyTo<FocusController.FocusedElement>
	|-Array.InternalArray__ICollection_CopyTo<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__ICollection_CopyTo<Funnel.PathPart>
	|-Array.InternalArray__ICollection_CopyTo<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__ICollection_CopyTo<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__ICollection_CopyTo<GrounderQuadruped.Foot>
	|-Array.InternalArray__ICollection_CopyTo<GtkPlus.GdkColor>
	|-Array.InternalArray__ICollection_CopyTo<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__ICollection_CopyTo<HID.HIDElementDescriptor>
	|-Array.InternalArray__ICollection_CopyTo<HIDParser.HIDReportData>
	|-Array.InternalArray__ICollection_CopyTo<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__ICollection_CopyTo<Hammersley.Hammersley2dSeq16>
	|-Array.InternalArray__ICollection_CopyTo<Hammersley.Hammersley2dSeq256>
	|-Array.InternalArray__ICollection_CopyTo<Hammersley.Hammersley2dSeq32>
	|-Array.InternalArray__ICollection_CopyTo<Hammersley.Hammersley2dSeq64>
	|-Array.InternalArray__ICollection_CopyTo<Hashtable.bucket>
	|-Array.InternalArray__ICollection_CopyTo<HeadingTracker.Item>
	|-Array.InternalArray__ICollection_CopyTo<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__ICollection_CopyTo<HebrewNumber.HebrewValue>
	|-Array.InternalArray__ICollection_CopyTo<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__ICollection_CopyTo<Icon.IconDirEntry>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.BindingJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.ReadActionJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.ReadMapJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.WriteActionJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionMap.WriteMapJson>
	|-Array.InternalArray__ICollection_CopyTo<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__ICollection_CopyTo<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__ICollection_CopyTo<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__ICollection_CopyTo<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__ICollection_CopyTo<InputControlLayout.ControlItem>
	|-Array.InternalArray__ICollection_CopyTo<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__ICollection_CopyTo<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__ICollection_CopyTo<InputControlScheme.SchemeJson>
	|-Array.InternalArray__ICollection_CopyTo<InputDevice.ControlBitRangeNode>
	|-Array.InternalArray__ICollection_CopyTo<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__ICollection_CopyTo<InputManager.AvailableDevice>
	|-Array.InternalArray__ICollection_CopyTo<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__ICollection_CopyTo<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__ICollection_CopyTo<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__ICollection_CopyTo<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__ICollection_CopyTo<InputRemoting.RemoteSender>
	|-Array.InternalArray__ICollection_CopyTo<InputStateHistory.Record>
	|-Array.InternalArray__ICollection_CopyTo<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__ICollection_CopyTo<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__ICollection_CopyTo<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__ICollection_CopyTo<InputUser.UserData>
	|-Array.InternalArray__ICollection_CopyTo<JsonParser.JsonValue>
	|-Array.InternalArray__ICollection_CopyTo<LatencySimulator.Message>
	|-Array.InternalArray__ICollection_CopyTo<LayerGridGraph.HeightSample>
	|-Array.InternalArray__ICollection_CopyTo<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__ICollection_CopyTo<LightUtility.LightMeshVertex>
	|-Array.InternalArray__ICollection_CopyTo<LiquidVolume.MeshCache>
	|-Array.InternalArray__ICollection_CopyTo<ListView.ItemMatrixLocation>
	|-Array.InternalArray__ICollection_CopyTo<MemoryHelpers.BitRegion>
	|-Array.InternalArray__ICollection_CopyTo<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__ICollection_CopyTo<Multipass.TransportIdData>
	|-Array.InternalArray__ICollection_CopyTo<NatPunchModule.RequestEventData>
	|-Array.InternalArray__ICollection_CopyTo<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__ICollection_CopyTo<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__ICollection_CopyTo<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__ICollection_CopyTo<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__ICollection_CopyTo<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__ICollection_CopyTo<NetworkAnimator.StateChange>
	|-Array.InternalArray__ICollection_CopyTo<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__ICollection_CopyTo<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__ICollection_CopyTo<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__ICollection_CopyTo<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__ICollection_CopyTo<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__ICollection_CopyTo<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__ICollection_CopyTo<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__ICollection_CopyTo<PlayingCard.CardData>
	|-Array.InternalArray__ICollection_CopyTo<PointKDTree.Node>
	|-Array.InternalArray__ICollection_CopyTo<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__ICollection_CopyTo<ProbeBrickIndex.Brick>
	|-Array.InternalArray__ICollection_CopyTo<ProbeBrickIndex.ReservedBrick>
	|-Array.InternalArray__ICollection_CopyTo<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__ICollection_CopyTo<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__ICollection_CopyTo<RVOQuadtree.Node>
	|-Array.InternalArray__ICollection_CopyTo<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__ICollection_CopyTo<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__ICollection_CopyTo<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__ICollection_CopyTo<RegexCharClass.SingleRange>
	|-Array.InternalArray__ICollection_CopyTo<ReliableChannel.PendingPacket>
	|-Array.InternalArray__ICollection_CopyTo<RenderChain.RenderNodeData>
	|-Array.InternalArray__ICollection_CopyTo<RenderGraph.CompiledPassInfo>
	|-Array.InternalArray__ICollection_CopyTo<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__ICollection_CopyTo<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__ICollection_CopyTo<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__ICollection_CopyTo<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__ICollection_CopyTo<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.ClipData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.MaskData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.NodeGlobalSceneState>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.NodeWithParent>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.PatternData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.PostponedClip>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.PostponedStopData>
	|-Array.InternalArray__ICollection_CopyTo<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__ICollection_CopyTo<SendMouseEvents.HitInfo>
	|-Array.InternalArray__ICollection_CopyTo<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__ICollection_CopyTo<ServerSocket.ConnectionChange>
	|-Array.InternalArray__ICollection_CopyTo<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__ICollection_CopyTo<ShaderInput.LightData>
	|-Array.InternalArray__ICollection_CopyTo<ShadowUtility.Edge>
	|-Array.InternalArray__ICollection_CopyTo<Socket.WSABUF>
	|-Array.InternalArray__ICollection_CopyTo<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__ICollection_CopyTo<StructySync.ChangeData>
	|-Array.InternalArray__ICollection_CopyTo<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__ICollection_CopyTo<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__ICollection_CopyTo<StyleSheet.ImportStruct>
	|-Array.InternalArray__ICollection_CopyTo<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__ICollection_CopyTo<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__ICollection_CopyTo<SyncStopwatch.ChangeData>
	|-Array.InternalArray__ICollection_CopyTo<SyncTimer.ChangeData>
	|-Array.InternalArray__ICollection_CopyTo<Syscall._pollfd>
	|-Array.InternalArray__ICollection_CopyTo<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__ICollection_CopyTo<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_CopyTo<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__ICollection_CopyTo<TargetStateListener.Callback>
	|-Array.InternalArray__ICollection_CopyTo<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__ICollection_CopyTo<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__ICollection_CopyTo<TextSettings.FontReferenceMap>
	|-Array.InternalArray__ICollection_CopyTo<TextureBlitter.BlitInfo>
	|-Array.InternalArray__ICollection_CopyTo<TexturePacker_JsonArray.Frame>
	|-Array.InternalArray__ICollection_CopyTo<TextureRegistry.TextureInfo>
	|-Array.InternalArray__ICollection_CopyTo<Tilemap.SyncTile>
	|-Array.InternalArray__ICollection_CopyTo<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__ICollection_CopyTo<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__ICollection_CopyTo<TransportManager.DisconnectingClient>
	|-Array.InternalArray__ICollection_CopyTo<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__ICollection_CopyTo<UIRStylePainter.Entry>
	|-Array.InternalArray__ICollection_CopyTo<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__ICollection_CopyTo<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__ICollection_CopyTo<UIRenderDevice.AllocToUpdate>
	|-Array.InternalArray__ICollection_CopyTo<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__ICollection_CopyTo<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__ICollection_CopyTo<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__ICollection_CopyTo<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__ICollection_CopyTo<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__ICollection_CopyTo<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__ICollection_CopyTo<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__ICollection_CopyTo<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__ICollection_CopyTo<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__ICollection_CopyTo<VolumetricFog.FogOfWarTransition>
	|-Array.InternalArray__ICollection_CopyTo<Win32DnD.FORMATETC>
	|-Array.InternalArray__ICollection_CopyTo<WordStorage.Entry>
	|-Array.InternalArray__ICollection_CopyTo<X11DesktopColors.GdkColorStruct>
	|-Array.InternalArray__ICollection_CopyTo<XmlEventCache.XmlEvent>
	|-Array.InternalArray__ICollection_CopyTo<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__ICollection_CopyTo<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__ICollection_CopyTo<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__ICollection_CopyTo<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__ICollection_CopyTo<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__ICollection_CopyTo<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__ICollection_CopyTo<XmlTextReaderImpl.ParsingState>
	|-Array.InternalArray__ICollection_CopyTo<XmlTextWriter.Namespace>
	|-Array.InternalArray__ICollection_CopyTo<XmlTextWriter.TagInfo>
	|-Array.InternalArray__ICollection_CopyTo<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__ICollection_CopyTo<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__ICollection_CopyTo<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__ICollection_CopyTo<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__ICollection_CopyTo<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__ICollection_CopyTo<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-Array.InternalArray__ICollection_CopyTo<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__ICollection_CopyTo<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__ICollection_CopyTo<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__ICollection_CopyTo<InputControlLayout.Collection.LayoutMatcher>
	|-Array.InternalArray__ICollection_CopyTo<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__ICollection_CopyTo<InputControlScheme.MatchResult.Match>
	|-Array.InternalArray__ICollection_CopyTo<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__ICollection_CopyTo<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__ICollection_CopyTo<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__ICollection_CopyTo<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__ICollection_CopyTo<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheCurve.Item>
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheEntry.RecordingItem>
	|-Array.InternalArray__ICollection_CopyTo<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__IReadOnlyList_get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD1220 Offset: 0xDCFC20 VA: 0x180DD1220
	|-Array.InternalArray__IReadOnlyList_get_Item<ArraySegment<byte>>
	|-Array.InternalArray__IReadOnlyList_get_Item<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, short>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int2, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int3, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Int3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, long>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, ulong>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<long, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, char>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Color32>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, double>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, long>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Scene, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ushort, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValue<int, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeArray<NudgeJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<DateTime>>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<ulong>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StructMultiKey<object, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<SubArray<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncGPUReadbackRequest>
	|-Array.InternalArray__IReadOnlyList_get_Item<BezierContour>
	|-Array.InternalArray__IReadOnlyList_get_Item<BigInteger>
	|-Array.InternalArray__IReadOnlyList_get_Item<BoundingSphere>
	|-Array.InternalArray__IReadOnlyList_get_Item<Color>
	|-Array.InternalArray__IReadOnlyList_get_Item<CompactVoxelSpan>
	|-Array.InternalArray__IReadOnlyList_get_Item<Connection>
	|-Array.InternalArray__IReadOnlyList_get_Item<CoordinateFootprintTilePair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CoordinateStorageTilePair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CoordinateTilePair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeTypedArgument>
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTimeOffset>
	|-Array.InternalArray__IReadOnlyList_get_Item<Decimal>
	|-Array.InternalArray__IReadOnlyList_get_Item<DictionaryEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<DoublePoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<DoublePoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<DrawBufferRange>
	|-Array.InternalArray__IReadOnlyList_get_Item<DualPrefab>
	|-Array.InternalArray__IReadOnlyList_get_Item<Entry>
	|-Array.InternalArray__IReadOnlyList_get_Item<Ephemeron>
	|-Array.InternalArray__IReadOnlyList_get_Item<EventSummary>
	|-Array.InternalArray__IReadOnlyList_get_Item<ExtensionFilter>
	|-Array.InternalArray__IReadOnlyList_get_Item<FontDefinition>
	|-Array.InternalArray__IReadOnlyList_get_Item<FontWeightPair>
	|-Array.InternalArray__IReadOnlyList_get_Item<GfxUpdateBufferRange>
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphRect>
	|-Array.InternalArray__IReadOnlyList_get_Item<Guid>
	|-Array.InternalArray__IReadOnlyList_get_Item<Hash128>
	|-Array.InternalArray__IReadOnlyList_get_Item<HeaderVariantInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<IndexField>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntRect>
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalCodePageDataItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalEncodingDataItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<InternedString>
	|-Array.InternalArray__IReadOnlyList_get_Item<InterpretedFrameInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<JobHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyStruct>
	|-Array.InternalArray__IReadOnlyList_get_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<LinkedVoxelSpan>
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalDefinition>
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalPacket>
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalPacket>
	|-Array.InternalArray__IReadOnlyList_get_Item<MarkupAttribute>
	|-Array.InternalArray__IReadOnlyList_get_Item<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<Plane>
	|-Array.InternalArray__IReadOnlyList_get_Item<Playable>
	|-Array.InternalArray__IReadOnlyList_get_Item<Progress>
	|-Array.InternalArray__IReadOnlyList_get_Item<QosResult>
	|-Array.InternalArray__IReadOnlyList_get_Item<Quaternion>
	|-Array.InternalArray__IReadOnlyList_get_Item<RangePositionInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<Rect>
	|-Array.InternalArray__IReadOnlyList_get_Item<RectInt>
	|-Array.InternalArray__IReadOnlyList_get_Item<Rectangle>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderBuffer>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderInstancedDataLayout>
	|-Array.InternalArray__IReadOnlyList_get_Item<Resolution>
	|-Array.InternalArray__IReadOnlyList_get_Item<ResourceLocator>
	|-Array.InternalArray__IReadOnlyList_get_Item<RpcLink>
	|-Array.InternalArray__IReadOnlyList_get_Item<RuleMatcher>
	|-Array.InternalArray__IReadOnlyList_get_Item<SamplePointUData>
	|-Array.InternalArray__IReadOnlyList_get_Item<ScalableImage>
	|-Array.InternalArray__IReadOnlyList_get_Item<Scale>
	|-Array.InternalArray__IReadOnlyList_get_Item<SecondarySpriteTexture>
	|-Array.InternalArray__IReadOnlyList_get_Item<SemanticMeaning>
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderKeyword>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlDouble>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlInt64>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlMoney>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamItemDetails_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyName>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleValueManaged>
	|-Array.InternalArray__IReadOnlyList_get_Item<Substring>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_FontWeightPair>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingElement>
	|-Array.InternalArray__IReadOnlyList_get_Item<TreeItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<UILineInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<UnloadedScene>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector4>
	|-Array.InternalArray__IReadOnlyList_get_Item<VertexAttributeDescriptor>
	|-Array.InternalArray__IReadOnlyList_get_Item<X509ChainStatus>
	|-Array.InternalArray__IReadOnlyList_get_Item<XPathNodeRef>
	|-Array.InternalArray__IReadOnlyList_get_Item<ZipGenericExtraField>
	|-Array.InternalArray__IReadOnlyList_get_Item<double2>
	|-Array.InternalArray__IReadOnlyList_get_Item<float4>
	|-Array.InternalArray__IReadOnlyList_get_Item<int4>
	|-Array.InternalArray__IReadOnlyList_get_Item<quaternion>
	|-Array.InternalArray__IReadOnlyList_get_Item<AdvancedSmooth.Turn>
	|-Array.InternalArray__IReadOnlyList_get_Item<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__IReadOnlyList_get_Item<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__IReadOnlyList_get_Item<BinaryHeap.Tuple>
	|-Array.InternalArray__IReadOnlyList_get_Item<CameraState.CustomBlendable>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineTargetGroup.Target>
	|-Array.InternalArray__IReadOnlyList_get_Item<ClipperLib.DoublePoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<ClipperLib.IntPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__IReadOnlyList_get_Item<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__IReadOnlyList_get_Item<DataError.ColumnError>
	|-Array.InternalArray__IReadOnlyList_get_Item<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__IReadOnlyList_get_Item<EventDispatcher.DispatchContext>
	|-Array.InternalArray__IReadOnlyList_get_Item<EventDispatcher.EventRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<ExpressionParser.ReservedWords>
	|-Array.InternalArray__IReadOnlyList_get_Item<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__IReadOnlyList_get_Item<FocusController.FocusedElement>
	|-Array.InternalArray__IReadOnlyList_get_Item<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputStateHistory.Record>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__IReadOnlyList_get_Item<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__IReadOnlyList_get_Item<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__IReadOnlyList_get_Item<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__IReadOnlyList_get_Item<PointKDTree.Node>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeBrickIndex.Brick>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__IReadOnlyList_get_Item<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.NodeWithParent>
	|-Array.InternalArray__IReadOnlyList_get_Item<SendMouseEvents.HitInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<ServerSocket.ConnectionChange>
	|-Array.InternalArray__IReadOnlyList_get_Item<Socket.WSABUF>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleSheet.ImportStruct>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetStateListener.Callback>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextSettings.FontReferenceMap>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextureRegistry.TextureInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TransportManager.DisconnectingClient>
	|-Array.InternalArray__IReadOnlyList_get_Item<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__IReadOnlyList_get_Item<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__IReadOnlyList_get_Item<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__IReadOnlyList_get_Item<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__IReadOnlyList_get_Item<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	|
	|-RVA: 0xDD1450 Offset: 0xDCFE50 VA: 0x180DD1450
	|-Array.InternalArray__IReadOnlyList_get_Item<SyncList.ChangeData<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int2, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<char>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Scene>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<uint>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BackgroundPosition>
	|-Array.InternalArray__IReadOnlyList_get_Item<DuplicateSamplePoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<Int3>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntRegion>
	|-Array.InternalArray__IReadOnlyList_get_Item<ManipulatorActivationFilter>
	|-Array.InternalArray__IReadOnlyList_get_Item<RuntimeLabel>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlDateTime>
	|-Array.InternalArray__IReadOnlyList_get_Item<UICharInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector3>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector3Int>
	|-Array.InternalArray__IReadOnlyList_get_Item<WordInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<float3>
	|-Array.InternalArray__IReadOnlyList_get_Item<int3>
	|-Array.InternalArray__IReadOnlyList_get_Item<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__IReadOnlyList_get_Item<AstarDebugger.GraphPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<GtkPlus.GdkColor>
	|-Array.InternalArray__IReadOnlyList_get_Item<HIDParser.HIDReportData>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__IReadOnlyList_get_Item<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__IReadOnlyList_get_Item<SyncTimer.ChangeData>
	|-Array.InternalArray__IReadOnlyList_get_Item<X11DesktopColors.GdkColorStruct>
	|
	|-RVA: 0xDD10E0 Offset: 0xDCFAE0 VA: 0x180DD10E0
	|-Array.InternalArray__IReadOnlyList_get_Item<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, short>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, uint>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Scene>>
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimatorClipInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<BackgroundRepeat>
	|-Array.InternalArray__IReadOnlyList_get_Item<CSteamID>
	|-Array.InternalArray__IReadOnlyList_get_Item<CompactVoxelCell>
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTime>
	|-Array.InternalArray__IReadOnlyList_get_Item<DecalEntity>
	|-Array.InternalArray__IReadOnlyList_get_Item<DecalSubDrawCall>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dimension>
	|-Array.InternalArray__IReadOnlyList_get_Item<EventTypeSpec>
	|-Array.InternalArray__IReadOnlyList_get_Item<FullRank>
	|-Array.InternalArray__IReadOnlyList_get_Item<GCHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionSetHandle_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputEventPtr>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputHandle_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<Int2>
	|-Array.InternalArray__IReadOnlyList_get_Item<long>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntPtr>
	|-Array.InternalArray__IReadOnlyList_get_Item<Length>
	|-Array.InternalArray__IReadOnlyList_get_Item<object>
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterModifier>
	|-Array.InternalArray__IReadOnlyList_get_Item<Point>
	|-Array.InternalArray__IReadOnlyList_get_Item<Pollfd>
	|-Array.InternalArray__IReadOnlyList_get_Item<PublishedFileId_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<RemoteConnectionEvent>
	|-Array.InternalArray__IReadOnlyList_get_Item<RendererListHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<ResourceHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<RpcLinkType>
	|-Array.InternalArray__IReadOnlyList_get_Item<SamplePointsPatch>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlBinary>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlGuid>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlInt32>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlSingle>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamItemInstanceID_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleValueHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<TerrainTileCoord>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextureHandle>
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeSpan>
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<ulong>
	|-Array.InternalArray__IReadOnlyList_get_Item<UsageHint>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2Int>
	|-Array.InternalArray__IReadOnlyList_get_Item<int2>
	|-Array.InternalArray__IReadOnlyList_get_Item<jvalue>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__IReadOnlyList_get_Item<BitmapAllocator32.Page>
	|-Array.InternalArray__IReadOnlyList_get_Item<BloomRenderer.Level>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineClearShot.Pair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__IReadOnlyList_get_Item<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__IReadOnlyList_get_Item<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__IReadOnlyList_get_Item<ListView.ItemMatrixLocation>
	|-Array.InternalArray__IReadOnlyList_get_Item<MemoryHelpers.BitRegion>
	|-Array.InternalArray__IReadOnlyList_get_Item<Multipass.TransportIdData>
	|-Array.InternalArray__IReadOnlyList_get_Item<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayingCard.CardData>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.PostponedClip>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.PostponedStopData>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__IReadOnlyList_get_Item<SyncStopwatch.ChangeData>
	|-Array.InternalArray__IReadOnlyList_get_Item<Syscall._pollfd>
	|-Array.InternalArray__IReadOnlyList_get_Item<WordStorage.Entry>
	|
	|-RVA: 0xDD17D0 Offset: 0xDD01D0 VA: 0x180DD17D0
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<bool>
	|-Array.InternalArray__IReadOnlyList_get_Item<byte>
	|-Array.InternalArray__IReadOnlyList_get_Item<ByteEnum>
	|-Array.InternalArray__IReadOnlyList_get_Item<sbyte>
	|-Array.InternalArray__IReadOnlyList_get_Item<SByteEnum>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlBoolean>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.ClipData>
	|
	|-RVA: 0xDD1670 Offset: 0xDD0070 VA: 0x180DD1670
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTree.Entry<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, long>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<long, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, double>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, long>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Guid, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Playable>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Rect>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Rect, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Nullable<Decimal>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TempAllocator.Page<ushort>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<InternedString>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TreeViewItemData<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BezierPathSegment>
	|-Array.InternalArray__IReadOnlyList_get_Item<Bounds>
	|-Array.InternalArray__IReadOnlyList_get_Item<BoundsInt>
	|-Array.InternalArray__IReadOnlyList_get_Item<Color>
	|-Array.InternalArray__IReadOnlyList_get_Item<ComputedTransitionProperty>
	|-Array.InternalArray__IReadOnlyList_get_Item<ContourVertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<ContourVertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<CoordinateProceduralTilePair>
	|-Array.InternalArray__IReadOnlyList_get_Item<FrameTimeSample>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlScheme>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTreeNode>
	|-Array.InternalArray__IReadOnlyList_get_Item<JsonPosition>
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalKeyword>
	|-Array.InternalArray__IReadOnlyList_get_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<NameAndParameters>
	|-Array.InternalArray__IReadOnlyList_get_Item<NamedValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<Packet>
	|-Array.InternalArray__IReadOnlyList_get_Item<RendererList>
	|-Array.InternalArray__IReadOnlyList_get_Item<RichTextTagAttribute>
	|-Array.InternalArray__IReadOnlyList_get_Item<RichTextTagAttribute>
	|-Array.InternalArray__IReadOnlyList_get_Item<Rotate>
	|-Array.InternalArray__IReadOnlyList_get_Item<SelectorMatchRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleSelectorPart>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleSyntaxToken>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<StyleVariable>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_WordInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<Touch>
	|-Array.InternalArray__IReadOnlyList_get_Item<Translate>
	|-Array.InternalArray__IReadOnlyList_get_Item<TreeViewItemWrapper>
	|-Array.InternalArray__IReadOnlyList_get_Item<UEvent>
	|-Array.InternalArray__IReadOnlyList_get_Item<UStar>
	|-Array.InternalArray__IReadOnlyList_get_Item<XRFeatureDescriptor>
	|-Array.InternalArray__IReadOnlyList_get_Item<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__IReadOnlyList_get_Item<AvatarSettings.LayerSetting>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__IReadOnlyList_get_Item<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__IReadOnlyList_get_Item<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__IReadOnlyList_get_Item<Hashtable.bucket>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlScheme.SchemeJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputRemoting.RemoteSender>
	|-Array.InternalArray__IReadOnlyList_get_Item<LatencySimulator.Message>
	|-Array.InternalArray__IReadOnlyList_get_Item<LiquidVolume.MeshCache>
	|-Array.InternalArray__IReadOnlyList_get_Item<NatPunchModule.RequestEventData>
	|-Array.InternalArray__IReadOnlyList_get_Item<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__IReadOnlyList_get_Item<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__IReadOnlyList_get_Item<RVOQuadtree.Node>
	|-Array.InternalArray__IReadOnlyList_get_Item<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__IReadOnlyList_get_Item<ReliableChannel.PendingPacket>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__IReadOnlyList_get_Item<StructySync.ChangeData>
	|-Array.InternalArray__IReadOnlyList_get_Item<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlTextWriter.Namespace>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__IReadOnlyList_get_Item<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xDD12D0 Offset: 0xDCFCD0 VA: 0x180DD12D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<RBTree.Node<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<Color32>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<AstarWorkItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<Background>
	|-Array.InternalArray__IReadOnlyList_get_Item<BezierSegment>
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientSettings>
	|-Array.InternalArray__IReadOnlyList_get_Item<IndexRange>
	|-Array.InternalArray__IReadOnlyList_get_Item<Light2DBlendStyle>
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeAddr>
	|-Array.InternalArray__IReadOnlyList_get_Item<NavMeshBuildMarkup>
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayableBinding>
	|-Array.InternalArray__IReadOnlyList_get_Item<SpriteState>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlString>
	|-Array.InternalArray__IReadOnlyList_get_Item<VoxelContour>
	|-Array.InternalArray__IReadOnlyList_get_Item<XPathNode>
	|-Array.InternalArray__IReadOnlyList_get_Item<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__IReadOnlyList_get_Item<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__IReadOnlyList_get_Item<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.ReadMapJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.WriteMapJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__IReadOnlyList_get_Item<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<Win32DnD.FORMATETC>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__IReadOnlyList_get_Item<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__IReadOnlyList_get_Item<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__IReadOnlyList_get_Item<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xDD19D0 Offset: 0xDD03D0 VA: 0x180DD19D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ColorBlock>
	|-Array.InternalArray__IReadOnlyList_get_Item<ComputedStyle>
	|-Array.InternalArray__IReadOnlyList_get_Item<FrameTiming>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputBinding>
	|
	|-RVA: 0xDD1B60 Offset: 0xDD0560 VA: 0x180DD1B60
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IReadOnlyList_get_Item<RBTree.Node<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPairHeader>
	|-Array.InternalArray__IReadOnlyList_get_Item<Label>
	|-Array.InternalArray__IReadOnlyList_get_Item<List>
	|-Array.InternalArray__IReadOnlyList_get_Item<Navigation>
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerLoopSystem>
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerLoopSystemInternal>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderTargetIdentifier>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LinkInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TreeInstance>
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__IReadOnlyList_get_Item<GrounderQuadruped.Foot>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__IReadOnlyList_get_Item<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__IReadOnlyList_get_Item<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlEventCache.XmlEvent>
	|-Array.InternalArray__IReadOnlyList_get_Item<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xDD2240 Offset: 0xDD0C40 VA: 0x180DD2240
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IReadOnlyList_get_Item<UHull>
	|-Array.InternalArray__IReadOnlyList_get_Item<HID.HIDElementDescriptor>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.ReadActionJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<JsonParser.JsonValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0xDD1500 Offset: 0xDCFF00 VA: 0x180DD1500
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BackgroundSize>
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientColorKey>
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientStop>
	|-Array.InternalArray__IReadOnlyList_get_Item<HighlightState>
	|-Array.InternalArray__IReadOnlyList_get_Item<HighlightState>
	|-Array.InternalArray__IReadOnlyList_get_Item<PageInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlDecimal>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_PageInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TemperatureEmitterInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TransformOrigin>
	|-Array.InternalArray__IReadOnlyList_get_Item<UEncroachingSegment>
	|-Array.InternalArray__IReadOnlyList_get_Item<CodePointIndexer.TableRange>
	|-Array.InternalArray__IReadOnlyList_get_Item<Cursor.CursorEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<HeadingTracker.Item>
	|-Array.InternalArray__IReadOnlyList_get_Item<Icon.IconDirEntry>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xDD1CE0 Offset: 0xDD06E0 VA: 0x180DD1CE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ControlPointOption>
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit2D>
	|-Array.InternalArray__IReadOnlyList_get_Item<Funnel.PathPart>
	|-Array.InternalArray__IReadOnlyList_get_Item<LightUtility.LightMeshVertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__IReadOnlyList_get_Item<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xDD20C0 Offset: 0xDD0AC0 VA: 0x180DD20C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Keyframe>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextShadow>
	|-Array.InternalArray__IReadOnlyList_get_Item<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__IReadOnlyList_get_Item<BBTree.BBTreeBox>
	|-Array.InternalArray__IReadOnlyList_get_Item<BlitUtility.Vertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachinePath.Waypoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkAnimator.StateChange>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.PatternData>
	|-Array.InternalArray__IReadOnlyList_get_Item<ShadowUtility.Edge>
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xDD1FF0 Offset: 0xDD09F0 VA: 0x180DD1FF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__IReadOnlyList_get_Item<VisibleReflectionProbe>
	|
	|-RVA: 0xDD1C20 Offset: 0xDD0620 VA: 0x180DD1C20
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<CopyClosingMeshJobData>
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeNamedArgument>
	|-Array.InternalArray__IReadOnlyList_get_Item<DisplayInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<IntPoint>
	|-Array.InternalArray__IReadOnlyList_get_Item<LinkInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__IReadOnlyList_get_Item<Rigidbody2DState>
	|-Array.InternalArray__IReadOnlyList_get_Item<Transform3x4>
	|-Array.InternalArray__IReadOnlyList_get_Item<VectorImageVertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimationWarping.Warp>
	|-Array.InternalArray__IReadOnlyList_get_Item<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__IReadOnlyList_get_Item<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlScheme.MatchResult.Match>
	|
	|-RVA: 0xDD1A90 Offset: 0xDD0490 VA: 0x180DD1A90
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__IReadOnlyList_get_Item<CombineInstance>
	|-Array.InternalArray__IReadOnlyList_get_Item<ModifiableContactPair>
	|
	|-RVA: 0xDD2180 Offset: 0xDD0B80 VA: 0x180DD2180
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__IReadOnlyList_get_Item<EnumData>
	|-Array.InternalArray__IReadOnlyList_get_Item<HumanBone>
	|-Array.InternalArray__IReadOnlyList_get_Item<Matrix4x4>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vertex>
	|-Array.InternalArray__IReadOnlyList_get_Item<float4x4>
	|-Array.InternalArray__IReadOnlyList_get_Item<Cursor.CursorImage>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.BindingJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputManager.AvailableDevice>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__IReadOnlyList_get_Item<LayerGridGraph.HeightSample>
	|-Array.InternalArray__IReadOnlyList_get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xDD2300 Offset: 0xDD0D00 VA: 0x180DD2300
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD15B0 Offset: 0xDCFFB0 VA: 0x180DD15B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__IReadOnlyList_get_Item<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint2D>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputDeviceDescription>
	|-Array.InternalArray__IReadOnlyList_get_Item<MaterialReference>
	|-Array.InternalArray__IReadOnlyList_get_Item<MaterialReference>
	|-Array.InternalArray__IReadOnlyList_get_Item<SkeletonBone>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionMap.WriteActionJson>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__IReadOnlyList_get_Item<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__IReadOnlyList_get_Item<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextureBlitter.BlitInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlTextWriter.TagInfo>
	|
	|-RVA: 0xDD25E0 Offset: 0xDD0FE0 VA: 0x180DD25E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__IReadOnlyList_get_Item<MeshInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastResult>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_MeshInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIRStylePainter.Entry>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xDD23B0 Offset: 0xDD0DB0 VA: 0x180DD23B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__IReadOnlyList_get_Item<FixedString128Bytes>
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xDD1E80 Offset: 0xDD0880 VA: 0x180DD1E80
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__IReadOnlyList_get_Item<CullingSplit>
	|-Array.InternalArray__IReadOnlyList_get_Item<LightDataGI>
	|-Array.InternalArray__IReadOnlyList_get_Item<LineInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<NavMeshBuildSource>
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LineInfo>
	|-Array.InternalArray__IReadOnlyList_get_Item<TileData>
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderChain.RenderNodeData>
	|
	|-RVA: 0xDD26A0 Offset: 0xDD10A0 VA: 0x180DD26A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD1180 Offset: 0xDCFB80 VA: 0x180DD1180
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__IReadOnlyList_get_Item<AppId_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<Color32>
	|-Array.InternalArray__IReadOnlyList_get_Item<DepotId_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<EasingFunction>
	|-Array.InternalArray__IReadOnlyList_get_Item<HSteamNetConnection>
	|-Array.InternalArray__IReadOnlyList_get_Item<InclusiveRange>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputUser>
	|-Array.InternalArray__IReadOnlyList_get_Item<int>
	|-Array.InternalArray__IReadOnlyList_get_Item<Int32Enum>
	|-Array.InternalArray__IReadOnlyList_get_Item<LayerMask>
	|-Array.InternalArray__IReadOnlyList_get_Item<Scene>
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderTagId>
	|-Array.InternalArray__IReadOnlyList_get_Item<SortingLayer>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlInt16>
	|-Array.InternalArray__IReadOnlyList_get_Item<SteamItemDef_t>
	|-Array.InternalArray__IReadOnlyList_get_Item<TextureId>
	|-Array.InternalArray__IReadOnlyList_get_Item<uint>
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt32Enum>
	|-Array.InternalArray__IReadOnlyList_get_Item<UShort2>
	|-Array.InternalArray__IReadOnlyList_get_Item<HebrewNumber.HebrewValue>
	|-Array.InternalArray__IReadOnlyList_get_Item<RegexCharClass.SingleRange>
	|
	|-RVA: 0xDD2AE0 Offset: 0xDD14E0 VA: 0x180DD2AE0
	|-Array.InternalArray__IReadOnlyList_get_Item<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|
	|-RVA: 0xDD2C60 Offset: 0xDD1660 VA: 0x180DD2C60
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0xDD2DC0 Offset: 0xDD17C0 VA: 0x180DD2DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__IReadOnlyList_get_Item<WordWrapState>
	|
	|-RVA: 0xDD1380 Offset: 0xDCFD80 VA: 0x180DD1380
	|-Array.InternalArray__IReadOnlyList_get_Item<AttachmentDescriptor>
	|-Array.InternalArray__IReadOnlyList_get_Item<NudgeJobData>
	|-Array.InternalArray__IReadOnlyList_get_Item<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__IReadOnlyList_get_Item<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__IReadOnlyList_get_Item<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__IReadOnlyList_get_Item<Tilemap.SyncTile>
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0xDD1720 Offset: 0xDD0120 VA: 0x180DD1720
	|-Array.InternalArray__IReadOnlyList_get_Item<Board>
	|-Array.InternalArray__IReadOnlyList_get_Item<RendererListResource>
	|
	|-RVA: 0xDD1870 Offset: 0xDD0270 VA: 0x180DD1870
	|-Array.InternalArray__IReadOnlyList_get_Item<CGSpot>
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit>
	|-Array.InternalArray__IReadOnlyList_get_Item<VolumetricFog.FogOfWarTransition>
	|
	|-RVA: 0xDD1930 Offset: 0xDD0330 VA: 0x180DD1930
	|-Array.InternalArray__IReadOnlyList_get_Item<char>
	|-Array.InternalArray__IReadOnlyList_get_Item<short>
	|-Array.InternalArray__IReadOnlyList_get_Item<SqlByte>
	|-Array.InternalArray__IReadOnlyList_get_Item<ushort>
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt16Enum>
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.MaskData>
	|
	|-RVA: 0xDD1DA0 Offset: 0xDD07A0 VA: 0x180DD1DA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ConvertMeshJobData>
	|
	|-RVA: 0xDD1F40 Offset: 0xDD0940 VA: 0x180DD1F40
	|-Array.InternalArray__IReadOnlyList_get_Item<double>
	|
	|-RVA: 0xDD2480 Offset: 0xDD0E80 VA: 0x180DD2480
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphMarshallingStruct>
	|-Array.InternalArray__IReadOnlyList_get_Item<LayerBatch>
	|-Array.InternalArray__IReadOnlyList_get_Item<UTriangle>
	|
	|-RVA: 0xDD2540 Offset: 0xDD0F40 VA: 0x180DD2540
	|-Array.InternalArray__IReadOnlyList_get_Item<GradientAlphaKey>
	|-Array.InternalArray__IReadOnlyList_get_Item<PointF>
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2>
	|-Array.InternalArray__IReadOnlyList_get_Item<float2>
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__IReadOnlyList_get_Item<SVGDocument.NodeGlobalSceneState>
	|
	|-RVA: 0xDD2750 Offset: 0xDD1150 VA: 0x180DD2750
	|-Array.InternalArray__IReadOnlyList_get_Item<PointerModel>
	|
	|-RVA: 0xDD2800 Offset: 0xDD1200 VA: 0x180DD2800
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderStateBlock>
	|-Array.InternalArray__IReadOnlyList_get_Item<UIVertex>
	|
	|-RVA: 0xDD28D0 Offset: 0xDD12D0 VA: 0x180DD28D0
	|-Array.InternalArray__IReadOnlyList_get_Item<RigidbodyState>
	|
	|-RVA: 0xDD2990 Offset: 0xDD1390 VA: 0x180DD2990
	|-Array.InternalArray__IReadOnlyList_get_Item<ShadowSliceData>
	|
	|-RVA: 0xDD2A40 Offset: 0xDD1440 VA: 0x180DD2A40
	|-Array.InternalArray__IReadOnlyList_get_Item<float>
	|
	|-RVA: 0xDD2BB0 Offset: 0xDD15B0 VA: 0x180DD2BB0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0xDD2D10 Offset: 0xDD1710 VA: 0x180DD2D10
	|-Array.InternalArray__IReadOnlyList_get_Item<TextElementInfo>
	|
	|-RVA: 0xDD2E70 Offset: 0xDD1870 VA: 0x180DD2E70
	|-Array.InternalArray__IReadOnlyList_get_Item<Touch>
	|
	|-RVA: 0xDD3720 Offset: 0xDD2120 VA: 0x180DD3720
	|-Array.InternalArray__IReadOnlyList_get_Item<VisibleLight>
	|
	|-RVA: 0xDD37F0 Offset: 0xDD21F0 VA: 0x180DD37F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xDD38A0 Offset: 0xDD22A0 VA: 0x180DD38A0
	|-Array.InternalArray__IReadOnlyList_get_Item<WordWrapState>
	|
	|-RVA: 0xDD3950 Offset: 0xDD2350 VA: 0x180DD3950
	|-Array.InternalArray__IReadOnlyList_get_Item<XEvent>
	|
	|-RVA: 0xDD3A00 Offset: 0xDD2400 VA: 0x180DD3A00
	|-Array.InternalArray__IReadOnlyList_get_Item<XRView>
	|
	|-RVA: 0xDD33A0 Offset: 0xDD1DA0 VA: 0x180DD33A0
	|-Array.InternalArray__IReadOnlyList_get_Item<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDD3650 Offset: 0xDD2050 VA: 0x180DD3650
	|-Array.InternalArray__IReadOnlyList_get_Item<Agent.VO>
	|
	|-RVA: 0xDD3090 Offset: 0xDD1A90 VA: 0x180DD3090
	|-Array.InternalArray__IReadOnlyList_get_Item<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xDD3140 Offset: 0xDD1B40 VA: 0x180DD3140
	|-Array.InternalArray__IReadOnlyList_get_Item<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xDD3240 Offset: 0xDD1C40 VA: 0x180DD3240
	|-Array.InternalArray__IReadOnlyList_get_Item<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xDD32F0 Offset: 0xDD1CF0 VA: 0x180DD32F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xDD2FE0 Offset: 0xDD19E0 VA: 0x180DD2FE0
	|-Array.InternalArray__IReadOnlyList_get_Item<InputControlLayout.ControlItem>
	|
	|-RVA: 0xDD2F30 Offset: 0xDD1930 VA: 0x180DD2F30
	|-Array.InternalArray__IReadOnlyList_get_Item<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xDD35A0 Offset: 0xDD1FA0 VA: 0x180DD35A0
	|-Array.InternalArray__IReadOnlyList_get_Item<InputUser.UserData>
	|
	|-RVA: 0xDD34E0 Offset: 0xDD1EE0 VA: 0x180DD34E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderInput.LightData>
	*/

	// RVA: 0x1C7D160 Offset: 0x1C7BB60 VA: 0x181C7D160
	internal int InternalArray__IReadOnlyCollection_get_Count() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__Insert<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE8BD0 Offset: 0xDE75D0 VA: 0x180DE8BD0
	|-Array.InternalArray__Insert<ArraySegment<byte>>
	|-Array.InternalArray__Insert<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__Insert<SyncList.ChangeData<int>>
	|-Array.InternalArray__Insert<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__Insert<IntervalTree.Entry<object>>
	|-Array.InternalArray__Insert<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__Insert<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, short>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, long>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, float>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__Insert<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__Insert<Dictionary.Entry<long, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__Insert<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__Insert<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, double>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, long>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, float>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__Insert<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__Insert<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__Insert<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__Insert<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__Insert<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__Insert<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__Insert<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__Insert<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__Insert<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__Insert<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__Insert<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__Insert<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__Insert<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__Insert<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Guid, object>>
	|-Array.InternalArray__Insert<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__Insert<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__Insert<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Int2, int>>
	|-Array.InternalArray__Insert<KeyValuePair<Int2, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Int3, int>>
	|-Array.InternalArray__Insert<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__Insert<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__Insert<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__Insert<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__Insert<KeyValuePair<int, bool>>
	|-Array.InternalArray__Insert<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__Insert<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__Insert<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__Insert<KeyValuePair<int, short>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Int3>>
	|-Array.InternalArray__Insert<KeyValuePair<int, int>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__Insert<KeyValuePair<int, long>>
	|-Array.InternalArray__Insert<KeyValuePair<int, object>>
	|-Array.InternalArray__Insert<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__Insert<KeyValuePair<int, float>>
	|-Array.InternalArray__Insert<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__Insert<KeyValuePair<int, uint>>
	|-Array.InternalArray__Insert<KeyValuePair<int, ulong>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__Insert<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__Insert<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__Insert<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__Insert<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__Insert<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__Insert<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__Insert<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__Insert<KeyValuePair<long, object>>
	|-Array.InternalArray__Insert<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__Insert<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__Insert<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__Insert<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__Insert<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__Insert<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__Insert<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__Insert<KeyValuePair<object, bool>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__Insert<KeyValuePair<object, char>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Color>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Color>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Color32>>
	|-Array.InternalArray__Insert<KeyValuePair<object, double>>
	|-Array.InternalArray__Insert<KeyValuePair<object, int>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__Insert<KeyValuePair<object, long>>
	|-Array.InternalArray__Insert<KeyValuePair<object, object>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Playable>>
	|-Array.InternalArray__Insert<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__Insert<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__Insert<KeyValuePair<object, Rect>>
	|-Array.InternalArray__Insert<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__Insert<KeyValuePair<object, float>>
	|-Array.InternalArray__Insert<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__Insert<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__Insert<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__Insert<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__Insert<KeyValuePair<object, InputControlLayout.ControlItem>>
	|-Array.InternalArray__Insert<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__Insert<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__Insert<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__Insert<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__Insert<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__Insert<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__Insert<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__Insert<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__Insert<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__Insert<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__Insert<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__Insert<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Rect, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Scene, object>>
	|-Array.InternalArray__Insert<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__Insert<KeyValuePair<ushort, object>>
	|-Array.InternalArray__Insert<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__Insert<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, int>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, object>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__Insert<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__Insert<KeyValuePair<ulong, object>>
	|-Array.InternalArray__Insert<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__Insert<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__Insert<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__Insert<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__Insert<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__Insert<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__Insert<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__Insert<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__Insert<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__Insert<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__Insert<KeyValue<int, int>>
	|-Array.InternalArray__Insert<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__Insert<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__Insert<NativeArray<NudgeJobData>>
	|-Array.InternalArray__Insert<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__Insert<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__Insert<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__Insert<RBTree.Node<int>>
	|-Array.InternalArray__Insert<RBTree.Node<object>>
	|-Array.InternalArray__Insert<Nullable<DateTime>>
	|-Array.InternalArray__Insert<Nullable<Decimal>>
	|-Array.InternalArray__Insert<TempAllocator.Page<ushort>>
	|-Array.InternalArray__Insert<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__Insert<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__Insert<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__Insert<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__Insert<HashSet.Slot<bool>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__Insert<Set.Slot<char>>
	|-Array.InternalArray__Insert<HashSet.Slot<int>>
	|-Array.InternalArray__Insert<Set.Slot<int>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__Insert<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__Insert<HashSet.Slot<InternedString>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__Insert<HashSet.Slot<object>>
	|-Array.InternalArray__Insert<Set.Slot<object>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__Insert<HashSet.Slot<Scene>>
	|-Array.InternalArray__Insert<HashSet.Slot<uint>>
	|-Array.InternalArray__Insert<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__Insert<HashSet.Slot<ulong>>
	|-Array.InternalArray__Insert<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__Insert<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__Insert<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__Insert<StructMultiKey<object, object>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__Insert<SubArray<int>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__Insert<TextProcessingStack<Color32>>
	|-Array.InternalArray__Insert<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__Insert<TextProcessingStack<int>>
	|-Array.InternalArray__Insert<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__Insert<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__Insert<TextProcessingStack<object>>
	|-Array.InternalArray__Insert<TextProcessingStack<float>>
	|-Array.InternalArray__Insert<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__Insert<TreeViewItemData<object>>
	|-Array.InternalArray__Insert<ValueTuple<bool>>
	|-Array.InternalArray__Insert<ValueTuple<int, int>>
	|-Array.InternalArray__Insert<ValueTuple<int, object>>
	|-Array.InternalArray__Insert<ValueTuple<int, Scene>>
	|-Array.InternalArray__Insert<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__Insert<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__Insert<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__Insert<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__Insert<ValueTuple<object, int>>
	|-Array.InternalArray__Insert<ValueTuple<object, object>>
	|-Array.InternalArray__Insert<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__Insert<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__Insert<ValueTuple<object, object, object>>
	|-Array.InternalArray__Insert<AnimatorClipInfo>
	|-Array.InternalArray__Insert<AppId_t>
	|-Array.InternalArray__Insert<AstarWorkItem>
	|-Array.InternalArray__Insert<AsyncGPUReadbackRequest>
	|-Array.InternalArray__Insert<AttachmentDescriptor>
	|-Array.InternalArray__Insert<Background>
	|-Array.InternalArray__Insert<BackgroundPosition>
	|-Array.InternalArray__Insert<BackgroundRepeat>
	|-Array.InternalArray__Insert<BackgroundSize>
	|-Array.InternalArray__Insert<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__Insert<BezierContour>
	|-Array.InternalArray__Insert<BezierPathSegment>
	|-Array.InternalArray__Insert<BezierSegment>
	|-Array.InternalArray__Insert<BigInteger>
	|-Array.InternalArray__Insert<Board>
	|-Array.InternalArray__Insert<bool>
	|-Array.InternalArray__Insert<BoundingSphere>
	|-Array.InternalArray__Insert<Bounds>
	|-Array.InternalArray__Insert<BoundsInt>
	|-Array.InternalArray__Insert<byte>
	|-Array.InternalArray__Insert<ByteEnum>
	|-Array.InternalArray__Insert<CGSpot>
	|-Array.InternalArray__Insert<CSteamID>
	|-Array.InternalArray__Insert<char>
	|-Array.InternalArray__Insert<Color>
	|-Array.InternalArray__Insert<Color>
	|-Array.InternalArray__Insert<Color32>
	|-Array.InternalArray__Insert<ColorBlock>
	|-Array.InternalArray__Insert<CombineInstance>
	|-Array.InternalArray__Insert<CompactVoxelCell>
	|-Array.InternalArray__Insert<CompactVoxelSpan>
	|-Array.InternalArray__Insert<ComputedStyle>
	|-Array.InternalArray__Insert<ComputedTransitionProperty>
	|-Array.InternalArray__Insert<Connection>
	|-Array.InternalArray__Insert<ContactPairHeader>
	|-Array.InternalArray__Insert<ContactPoint>
	|-Array.InternalArray__Insert<ContactPoint2D>
	|-Array.InternalArray__Insert<ContourVertex>
	|-Array.InternalArray__Insert<ContourVertex>
	|-Array.InternalArray__Insert<ControlPointOption>
	|-Array.InternalArray__Insert<ConvertMeshJobData>
	|-Array.InternalArray__Insert<CoordinateFootprintTilePair>
	|-Array.InternalArray__Insert<CoordinateProceduralTilePair>
	|-Array.InternalArray__Insert<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__Insert<CoordinateStorageTilePair>
	|-Array.InternalArray__Insert<CoordinateTilePair>
	|-Array.InternalArray__Insert<CopyClosingMeshJobData>
	|-Array.InternalArray__Insert<CullingSplit>
	|-Array.InternalArray__Insert<CustomAttributeNamedArgument>
	|-Array.InternalArray__Insert<CustomAttributeTypedArgument>
	|-Array.InternalArray__Insert<DateTime>
	|-Array.InternalArray__Insert<DateTimeOffset>
	|-Array.InternalArray__Insert<DecalEntity>
	|-Array.InternalArray__Insert<DecalSubDrawCall>
	|-Array.InternalArray__Insert<Decimal>
	|-Array.InternalArray__Insert<DepotId_t>
	|-Array.InternalArray__Insert<DictionaryEntry>
	|-Array.InternalArray__Insert<Dimension>
	|-Array.InternalArray__Insert<DisplayInfo>
	|-Array.InternalArray__Insert<double>
	|-Array.InternalArray__Insert<DoublePoint>
	|-Array.InternalArray__Insert<DoublePoint>
	|-Array.InternalArray__Insert<DrawBufferRange>
	|-Array.InternalArray__Insert<DualPrefab>
	|-Array.InternalArray__Insert<DuplicateSamplePoint>
	|-Array.InternalArray__Insert<EasingFunction>
	|-Array.InternalArray__Insert<Entry>
	|-Array.InternalArray__Insert<EnumData>
	|-Array.InternalArray__Insert<Ephemeron>
	|-Array.InternalArray__Insert<EventSummary>
	|-Array.InternalArray__Insert<EventTypeSpec>
	|-Array.InternalArray__Insert<ExtensionFilter>
	|-Array.InternalArray__Insert<FixedString128Bytes>
	|-Array.InternalArray__Insert<FontDefinition>
	|-Array.InternalArray__Insert<FontWeightPair>
	|-Array.InternalArray__Insert<FrameTimeSample>
	|-Array.InternalArray__Insert<FrameTiming>
	|-Array.InternalArray__Insert<FullRank>
	|-Array.InternalArray__Insert<GCHandle>
	|-Array.InternalArray__Insert<GfxUpdateBufferRange>
	|-Array.InternalArray__Insert<GlyphMarshallingStruct>
	|-Array.InternalArray__Insert<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__Insert<GlyphRect>
	|-Array.InternalArray__Insert<GradientAlphaKey>
	|-Array.InternalArray__Insert<GradientColorKey>
	|-Array.InternalArray__Insert<GradientSettings>
	|-Array.InternalArray__Insert<GradientStop>
	|-Array.InternalArray__Insert<Guid>
	|-Array.InternalArray__Insert<HSteamNetConnection>
	|-Array.InternalArray__Insert<Hash128>
	|-Array.InternalArray__Insert<HeaderVariantInfo>
	|-Array.InternalArray__Insert<HighlightState>
	|-Array.InternalArray__Insert<HighlightState>
	|-Array.InternalArray__Insert<HumanBone>
	|-Array.InternalArray__Insert<InclusiveRange>
	|-Array.InternalArray__Insert<IndexField>
	|-Array.InternalArray__Insert<IndexRange>
	|-Array.InternalArray__Insert<InputActionSetHandle_t>
	|-Array.InternalArray__Insert<InputBinding>
	|-Array.InternalArray__Insert<InputControlScheme>
	|-Array.InternalArray__Insert<InputDeviceDescription>
	|-Array.InternalArray__Insert<InputEventPtr>
	|-Array.InternalArray__Insert<InputHandle_t>
	|-Array.InternalArray__Insert<InputUser>
	|-Array.InternalArray__Insert<short>
	|-Array.InternalArray__Insert<Int2>
	|-Array.InternalArray__Insert<Int3>
	|-Array.InternalArray__Insert<int>
	|-Array.InternalArray__Insert<Int32Enum>
	|-Array.InternalArray__Insert<long>
	|-Array.InternalArray__Insert<IntPoint>
	|-Array.InternalArray__Insert<IntPoint>
	|-Array.InternalArray__Insert<IntPtr>
	|-Array.InternalArray__Insert<IntRect>
	|-Array.InternalArray__Insert<IntRegion>
	|-Array.InternalArray__Insert<InternalCodePageDataItem>
	|-Array.InternalArray__Insert<InternalEncodingDataItem>
	|-Array.InternalArray__Insert<InternedString>
	|-Array.InternalArray__Insert<InterpretedFrameInfo>
	|-Array.InternalArray__Insert<IntervalTreeNode>
	|-Array.InternalArray__Insert<JobHandle>
	|-Array.InternalArray__Insert<JsonPosition>
	|-Array.InternalArray__Insert<KeyStruct>
	|-Array.InternalArray__Insert<Keyframe>
	|-Array.InternalArray__Insert<Label>
	|-Array.InternalArray__Insert<LayerBatch>
	|-Array.InternalArray__Insert<LayerMask>
	|-Array.InternalArray__Insert<Length>
	|-Array.InternalArray__Insert<LigatureSubstitutionRecord>
	|-Array.InternalArray__Insert<LigatureSubstitutionRecord>
	|-Array.InternalArray__Insert<Light2DBlendStyle>
	|-Array.InternalArray__Insert<LightDataGI>
	|-Array.InternalArray__Insert<LineInfo>
	|-Array.InternalArray__Insert<LinkInfo>
	|-Array.InternalArray__Insert<LinkedVoxelSpan>
	|-Array.InternalArray__Insert<List>
	|-Array.InternalArray__Insert<LocalDefinition>
	|-Array.InternalArray__Insert<LocalKeyword>
	|-Array.InternalArray__Insert<LocalPacket>
	|-Array.InternalArray__Insert<LocalPacket>
	|-Array.InternalArray__Insert<ManipulatorActivationFilter>
	|-Array.InternalArray__Insert<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__Insert<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__Insert<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__Insert<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__Insert<MarkupAttribute>
	|-Array.InternalArray__Insert<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__Insert<MaterialReference>
	|-Array.InternalArray__Insert<MaterialReference>
	|-Array.InternalArray__Insert<Matrix4x4>
	|-Array.InternalArray__Insert<MeshInfo>
	|-Array.InternalArray__Insert<ModifiableContactPair>
	|-Array.InternalArray__Insert<MultipleSubstitutionRecord>
	|-Array.InternalArray__Insert<MultipleSubstitutionRecord>
	|-Array.InternalArray__Insert<NameAndParameters>
	|-Array.InternalArray__Insert<NamedValue>
	|-Array.InternalArray__Insert<NativeAddr>
	|-Array.InternalArray__Insert<NavMeshBuildMarkup>
	|-Array.InternalArray__Insert<NavMeshBuildSource>
	|-Array.InternalArray__Insert<Navigation>
	|-Array.InternalArray__Insert<NudgeJobData>
	|-Array.InternalArray__Insert<object>
	|-Array.InternalArray__Insert<Packet>
	|-Array.InternalArray__Insert<PageInfo>
	|-Array.InternalArray__Insert<ParameterModifier>
	|-Array.InternalArray__Insert<Plane>
	|-Array.InternalArray__Insert<Playable>
	|-Array.InternalArray__Insert<PlayableBinding>
	|-Array.InternalArray__Insert<PlayerLoopSystem>
	|-Array.InternalArray__Insert<PlayerLoopSystemInternal>
	|-Array.InternalArray__Insert<Point>
	|-Array.InternalArray__Insert<PointF>
	|-Array.InternalArray__Insert<PointerModel>
	|-Array.InternalArray__Insert<Pollfd>
	|-Array.InternalArray__Insert<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__Insert<Progress>
	|-Array.InternalArray__Insert<PublishedFileId_t>
	|-Array.InternalArray__Insert<QosResult>
	|-Array.InternalArray__Insert<Quaternion>
	|-Array.InternalArray__Insert<RangePositionInfo>
	|-Array.InternalArray__Insert<RaycastHit>
	|-Array.InternalArray__Insert<RaycastHit2D>
	|-Array.InternalArray__Insert<RaycastResult>
	|-Array.InternalArray__Insert<Rect>
	|-Array.InternalArray__Insert<RectInt>
	|-Array.InternalArray__Insert<Rectangle>
	|-Array.InternalArray__Insert<RemoteConnectionEvent>
	|-Array.InternalArray__Insert<RenderBuffer>
	|-Array.InternalArray__Insert<RenderInstancedDataLayout>
	|-Array.InternalArray__Insert<RenderStateBlock>
	|-Array.InternalArray__Insert<RenderTargetIdentifier>
	|-Array.InternalArray__Insert<RendererList>
	|-Array.InternalArray__Insert<RendererListHandle>
	|-Array.InternalArray__Insert<RendererListResource>
	|-Array.InternalArray__Insert<Resolution>
	|-Array.InternalArray__Insert<ResourceHandle>
	|-Array.InternalArray__Insert<ResourceLocator>
	|-Array.InternalArray__Insert<RichTextTagAttribute>
	|-Array.InternalArray__Insert<RichTextTagAttribute>
	|-Array.InternalArray__Insert<Rigidbody2DState>
	|-Array.InternalArray__Insert<RigidbodyState>
	|-Array.InternalArray__Insert<Rotate>
	|-Array.InternalArray__Insert<RpcLink>
	|-Array.InternalArray__Insert<RpcLinkType>
	|-Array.InternalArray__Insert<RuleMatcher>
	|-Array.InternalArray__Insert<RuntimeLabel>
	|-Array.InternalArray__Insert<sbyte>
	|-Array.InternalArray__Insert<SByteEnum>
	|-Array.InternalArray__Insert<SamplePointUData>
	|-Array.InternalArray__Insert<SamplePointsPatch>
	|-Array.InternalArray__Insert<ScalableImage>
	|-Array.InternalArray__Insert<Scale>
	|-Array.InternalArray__Insert<Scene>
	|-Array.InternalArray__Insert<SecondarySpriteTexture>
	|-Array.InternalArray__Insert<SelectorMatchRecord>
	|-Array.InternalArray__Insert<SemanticMeaning>
	|-Array.InternalArray__Insert<ShaderKeyword>
	|-Array.InternalArray__Insert<ShaderTagId>
	|-Array.InternalArray__Insert<ShaderVariablesProbeVolumes>
	|-Array.InternalArray__Insert<ShadowSliceData>
	|-Array.InternalArray__Insert<float>
	|-Array.InternalArray__Insert<SkeletonBone>
	|-Array.InternalArray__Insert<SortingLayer>
	|-Array.InternalArray__Insert<SpriteState>
	|-Array.InternalArray__Insert<SqlBinary>
	|-Array.InternalArray__Insert<SqlBoolean>
	|-Array.InternalArray__Insert<SqlByte>
	|-Array.InternalArray__Insert<SqlDateTime>
	|-Array.InternalArray__Insert<SqlDecimal>
	|-Array.InternalArray__Insert<SqlDouble>
	|-Array.InternalArray__Insert<SqlGuid>
	|-Array.InternalArray__Insert<SqlInt16>
	|-Array.InternalArray__Insert<SqlInt32>
	|-Array.InternalArray__Insert<SqlInt64>
	|-Array.InternalArray__Insert<SqlMoney>
	|-Array.InternalArray__Insert<SqlSingle>
	|-Array.InternalArray__Insert<SqlString>
	|-Array.InternalArray__Insert<SteamItemDef_t>
	|-Array.InternalArray__Insert<SteamItemDetails_t>
	|-Array.InternalArray__Insert<SteamItemInstanceID_t>
	|-Array.InternalArray__Insert<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__Insert<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__Insert<StylePropertyName>
	|-Array.InternalArray__Insert<StylePropertyValue>
	|-Array.InternalArray__Insert<StyleSelectorPart>
	|-Array.InternalArray__Insert<StyleSyntaxToken>
	|-Array.InternalArray__Insert<StyleValue>
	|-Array.InternalArray__Insert<StyleValueHandle>
	|-Array.InternalArray__Insert<StyleValueManaged>
	|-Array.InternalArray__Insert<StyleVariable>
	|-Array.InternalArray__Insert<Substring>
	|-Array.InternalArray__Insert<TMP_CharacterInfo>
	|-Array.InternalArray__Insert<TMP_FontWeightPair>
	|-Array.InternalArray__Insert<TMP_LineInfo>
	|-Array.InternalArray__Insert<TMP_LinkInfo>
	|-Array.InternalArray__Insert<TMP_MeshInfo>
	|-Array.InternalArray__Insert<TMP_PageInfo>
	|-Array.InternalArray__Insert<TMP_WordInfo>
	|-Array.InternalArray__Insert<TemperatureEmitterInfo>
	|-Array.InternalArray__Insert<TerrainTileCoord>
	|-Array.InternalArray__Insert<TextElementInfo>
	|-Array.InternalArray__Insert<TextProcessingElement>
	|-Array.InternalArray__Insert<TextShadow>
	|-Array.InternalArray__Insert<TextureHandle>
	|-Array.InternalArray__Insert<TextureId>
	|-Array.InternalArray__Insert<TileData>
	|-Array.InternalArray__Insert<TimeSpan>
	|-Array.InternalArray__Insert<TimeValue>
	|-Array.InternalArray__Insert<Touch>
	|-Array.InternalArray__Insert<Touch>
	|-Array.InternalArray__Insert<Transform3x4>
	|-Array.InternalArray__Insert<TransformOrigin>
	|-Array.InternalArray__Insert<Translate>
	|-Array.InternalArray__Insert<TreeInstance>
	|-Array.InternalArray__Insert<TreeItem>
	|-Array.InternalArray__Insert<TreeViewItemWrapper>
	|-Array.InternalArray__Insert<UEncroachingSegment>
	|-Array.InternalArray__Insert<UEvent>
	|-Array.InternalArray__Insert<UHull>
	|-Array.InternalArray__Insert<UICharInfo>
	|-Array.InternalArray__Insert<UILineInfo>
	|-Array.InternalArray__Insert<UIVertex>
	|-Array.InternalArray__Insert<ushort>
	|-Array.InternalArray__Insert<UInt16Enum>
	|-Array.InternalArray__Insert<uint>
	|-Array.InternalArray__Insert<UInt32Enum>
	|-Array.InternalArray__Insert<ulong>
	|-Array.InternalArray__Insert<UShort2>
	|-Array.InternalArray__Insert<UStar>
	|-Array.InternalArray__Insert<UTriangle>
	|-Array.InternalArray__Insert<UnloadedScene>
	|-Array.InternalArray__Insert<UsageHint>
	|-Array.InternalArray__Insert<Vector2>
	|-Array.InternalArray__Insert<Vector2Int>
	|-Array.InternalArray__Insert<Vector3>
	|-Array.InternalArray__Insert<Vector3Int>
	|-Array.InternalArray__Insert<Vector4>
	|-Array.InternalArray__Insert<VectorImageVertex>
	|-Array.InternalArray__Insert<Vertex>
	|-Array.InternalArray__Insert<VertexAttributeDescriptor>
	|-Array.InternalArray__Insert<VisibleLight>
	|-Array.InternalArray__Insert<VisibleReflectionProbe>
	|-Array.InternalArray__Insert<VoxelContour>
	|-Array.InternalArray__Insert<Win32_IP_ADAPTER_ADDRESSES>
	|-Array.InternalArray__Insert<WordInfo>
	|-Array.InternalArray__Insert<WordWrapState>
	|-Array.InternalArray__Insert<WordWrapState>
	|-Array.InternalArray__Insert<X509ChainStatus>
	|-Array.InternalArray__Insert<XEvent>
	|-Array.InternalArray__Insert<XPathNode>
	|-Array.InternalArray__Insert<XPathNodeRef>
	|-Array.InternalArray__Insert<XRFeatureDescriptor>
	|-Array.InternalArray__Insert<XRView>
	|-Array.InternalArray__Insert<ZipGenericExtraField>
	|-Array.InternalArray__Insert<__Il2CppFullySharedGenericType>
	|-Array.InternalArray__Insert<double2>
	|-Array.InternalArray__Insert<float2>
	|-Array.InternalArray__Insert<float3>
	|-Array.InternalArray__Insert<float4>
	|-Array.InternalArray__Insert<float4x4>
	|-Array.InternalArray__Insert<int2>
	|-Array.InternalArray__Insert<int3>
	|-Array.InternalArray__Insert<int4>
	|-Array.InternalArray__Insert<jvalue>
	|-Array.InternalArray__Insert<quaternion>
	|-Array.InternalArray__Insert<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__Insert<AdvancedSmooth.Turn>
	|-Array.InternalArray__Insert<Agent.VO>
	|-Array.InternalArray__Insert<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__Insert<AnimationWarping.Warp>
	|-Array.InternalArray__Insert<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__Insert<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__Insert<AstarDebugger.GraphPoint>
	|-Array.InternalArray__Insert<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__Insert<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__Insert<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__Insert<AvatarSettings.LayerSetting>
	|-Array.InternalArray__Insert<BBTree.BBTreeBox>
	|-Array.InternalArray__Insert<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__Insert<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__Insert<BinaryHeap.Tuple>
	|-Array.InternalArray__Insert<BitmapAllocator32.Page>
	|-Array.InternalArray__Insert<BlitUtility.Vertex>
	|-Array.InternalArray__Insert<BloomRenderer.Level>
	|-Array.InternalArray__Insert<CameraState.CustomBlendable>
	|-Array.InternalArray__Insert<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__Insert<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__Insert<CinemachineClearShot.Pair>
	|-Array.InternalArray__Insert<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__Insert<CinemachinePath.Waypoint>
	|-Array.InternalArray__Insert<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__Insert<CinemachineTargetGroup.Target>
	|-Array.InternalArray__Insert<ClipperLib.DoublePoint>
	|-Array.InternalArray__Insert<ClipperLib.IntPoint>
	|-Array.InternalArray__Insert<CodePointIndexer.TableRange>
	|-Array.InternalArray__Insert<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__Insert<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__Insert<Cursor.CursorEntry>
	|-Array.InternalArray__Insert<Cursor.CursorImage>
	|-Array.InternalArray__Insert<DataError.ColumnError>
	|-Array.InternalArray__Insert<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__Insert<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__Insert<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__Insert<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__Insert<EventDispatcher.DispatchContext>
	|-Array.InternalArray__Insert<EventDispatcher.EventRecord>
	|-Array.InternalArray__Insert<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__Insert<ExpressionParser.ReservedWords>
	|-Array.InternalArray__Insert<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__Insert<FocusController.FocusedElement>
	|-Array.InternalArray__Insert<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__Insert<Funnel.PathPart>
	|-Array.InternalArray__Insert<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__Insert<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__Insert<GrounderQuadruped.Foot>
	|-Array.InternalArray__Insert<GtkPlus.GdkColor>
	|-Array.InternalArray__Insert<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__Insert<HID.HIDElementDescriptor>
	|-Array.InternalArray__Insert<HIDParser.HIDReportData>
	|-Array.InternalArray__Insert<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__Insert<Hammersley.Hammersley2dSeq16>
	|-Array.InternalArray__Insert<Hammersley.Hammersley2dSeq256>
	|-Array.InternalArray__Insert<Hammersley.Hammersley2dSeq32>
	|-Array.InternalArray__Insert<Hammersley.Hammersley2dSeq64>
	|-Array.InternalArray__Insert<Hashtable.bucket>
	|-Array.InternalArray__Insert<HeadingTracker.Item>
	|-Array.InternalArray__Insert<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__Insert<HebrewNumber.HebrewValue>
	|-Array.InternalArray__Insert<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__Insert<Icon.IconDirEntry>
	|-Array.InternalArray__Insert<InputActionMap.BindingJson>
	|-Array.InternalArray__Insert<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__Insert<InputActionMap.ReadActionJson>
	|-Array.InternalArray__Insert<InputActionMap.ReadMapJson>
	|-Array.InternalArray__Insert<InputActionMap.WriteActionJson>
	|-Array.InternalArray__Insert<InputActionMap.WriteMapJson>
	|-Array.InternalArray__Insert<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__Insert<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__Insert<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__Insert<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__Insert<InputControlLayout.ControlItem>
	|-Array.InternalArray__Insert<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__Insert<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__Insert<InputControlScheme.SchemeJson>
	|-Array.InternalArray__Insert<InputDevice.ControlBitRangeNode>
	|-Array.InternalArray__Insert<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__Insert<InputManager.AvailableDevice>
	|-Array.InternalArray__Insert<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__Insert<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__Insert<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__Insert<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__Insert<InputRemoting.RemoteSender>
	|-Array.InternalArray__Insert<InputStateHistory.Record>
	|-Array.InternalArray__Insert<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__Insert<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__Insert<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__Insert<InputUser.UserData>
	|-Array.InternalArray__Insert<JsonParser.JsonValue>
	|-Array.InternalArray__Insert<LatencySimulator.Message>
	|-Array.InternalArray__Insert<LayerGridGraph.HeightSample>
	|-Array.InternalArray__Insert<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__Insert<LightUtility.LightMeshVertex>
	|-Array.InternalArray__Insert<LiquidVolume.MeshCache>
	|-Array.InternalArray__Insert<ListView.ItemMatrixLocation>
	|-Array.InternalArray__Insert<MemoryHelpers.BitRegion>
	|-Array.InternalArray__Insert<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__Insert<Multipass.TransportIdData>
	|-Array.InternalArray__Insert<NatPunchModule.RequestEventData>
	|-Array.InternalArray__Insert<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__Insert<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__Insert<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__Insert<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__Insert<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__Insert<NetworkAnimator.StateChange>
	|-Array.InternalArray__Insert<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__Insert<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__Insert<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__Insert<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__Insert<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__Insert<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__Insert<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__Insert<PlayingCard.CardData>
	|-Array.InternalArray__Insert<PointKDTree.Node>
	|-Array.InternalArray__Insert<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__Insert<ProbeBrickIndex.Brick>
	|-Array.InternalArray__Insert<ProbeBrickIndex.ReservedBrick>
	|-Array.InternalArray__Insert<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__Insert<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__Insert<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__Insert<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__Insert<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__Insert<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__Insert<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__Insert<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__Insert<RVOQuadtree.Node>
	|-Array.InternalArray__Insert<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__Insert<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__Insert<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__Insert<RegexCharClass.SingleRange>
	|-Array.InternalArray__Insert<ReliableChannel.PendingPacket>
	|-Array.InternalArray__Insert<RenderChain.RenderNodeData>
	|-Array.InternalArray__Insert<RenderGraph.CompiledPassInfo>
	|-Array.InternalArray__Insert<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__Insert<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__Insert<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__Insert<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__Insert<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__Insert<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__Insert<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__Insert<SVGDocument.ClipData>
	|-Array.InternalArray__Insert<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__Insert<SVGDocument.MaskData>
	|-Array.InternalArray__Insert<SVGDocument.NodeGlobalSceneState>
	|-Array.InternalArray__Insert<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__Insert<SVGDocument.NodeWithParent>
	|-Array.InternalArray__Insert<SVGDocument.PatternData>
	|-Array.InternalArray__Insert<SVGDocument.PostponedClip>
	|-Array.InternalArray__Insert<SVGDocument.PostponedStopData>
	|-Array.InternalArray__Insert<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__Insert<SendMouseEvents.HitInfo>
	|-Array.InternalArray__Insert<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__Insert<ServerSocket.ConnectionChange>
	|-Array.InternalArray__Insert<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__Insert<ShaderInput.LightData>
	|-Array.InternalArray__Insert<ShadowUtility.Edge>
	|-Array.InternalArray__Insert<Socket.WSABUF>
	|-Array.InternalArray__Insert<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__Insert<StructySync.ChangeData>
	|-Array.InternalArray__Insert<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__Insert<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__Insert<StyleSheet.ImportStruct>
	|-Array.InternalArray__Insert<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__Insert<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__Insert<SyncStopwatch.ChangeData>
	|-Array.InternalArray__Insert<SyncTimer.ChangeData>
	|-Array.InternalArray__Insert<Syscall._pollfd>
	|-Array.InternalArray__Insert<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__Insert<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__Insert<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__Insert<TargetStateListener.Callback>
	|-Array.InternalArray__Insert<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__Insert<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__Insert<TextSettings.FontReferenceMap>
	|-Array.InternalArray__Insert<TextureBlitter.BlitInfo>
	|-Array.InternalArray__Insert<TexturePacker_JsonArray.Frame>
	|-Array.InternalArray__Insert<TextureRegistry.TextureInfo>
	|-Array.InternalArray__Insert<Tilemap.SyncTile>
	|-Array.InternalArray__Insert<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__Insert<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__Insert<TransportManager.DisconnectingClient>
	|-Array.InternalArray__Insert<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__Insert<UIRStylePainter.Entry>
	|-Array.InternalArray__Insert<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__Insert<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__Insert<UIRenderDevice.AllocToUpdate>
	|-Array.InternalArray__Insert<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__Insert<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__Insert<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__Insert<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__Insert<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__Insert<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__Insert<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__Insert<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__Insert<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__Insert<VolumetricFog.FogOfWarTransition>
	|-Array.InternalArray__Insert<Win32DnD.FORMATETC>
	|-Array.InternalArray__Insert<WordStorage.Entry>
	|-Array.InternalArray__Insert<X11DesktopColors.GdkColorStruct>
	|-Array.InternalArray__Insert<XmlEventCache.XmlEvent>
	|-Array.InternalArray__Insert<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__Insert<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__Insert<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__Insert<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__Insert<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__Insert<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__Insert<XmlTextReaderImpl.ParsingState>
	|-Array.InternalArray__Insert<XmlTextWriter.Namespace>
	|-Array.InternalArray__Insert<XmlTextWriter.TagInfo>
	|-Array.InternalArray__Insert<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__Insert<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__Insert<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__Insert<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__Insert<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__Insert<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|-Array.InternalArray__Insert<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__Insert<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__Insert<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__Insert<InputControlLayout.Collection.LayoutMatcher>
	|-Array.InternalArray__Insert<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__Insert<InputControlScheme.MatchResult.Match>
	|-Array.InternalArray__Insert<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__Insert<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__Insert<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__Insert<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__Insert<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Array.InternalArray__Insert<TargetPositionCache.CacheCurve.Item>
	|-Array.InternalArray__Insert<TargetPositionCache.CacheEntry.RecordingItem>
	|-Array.InternalArray__Insert<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	*/

	// RVA: 0x1C7D1C0 Offset: 0x1C7BBC0 VA: 0x181C7D1C0
	internal void InternalArray__RemoveAt(int index) { }

	// RVA: -1 Offset: -1
	internal int InternalArray__IndexOf<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD3AB0 Offset: 0xDD24B0 VA: 0x180DD3AB0
	|-Array.InternalArray__IndexOf<ArraySegment<byte>>
	|
	|-RVA: 0xDD3C10 Offset: 0xDD2610 VA: 0x180DD3C10
	|-Array.InternalArray__IndexOf<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__IndexOf<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, short>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, float>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int2, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int3, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Int3>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, long>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, ulong>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<long, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, bool>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, char>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Color32>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, double>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, long>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, float>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Scene, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ushort, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IndexOf<KeyValue<int, int>>
	|-Array.InternalArray__IndexOf<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<object>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<ulong>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__IndexOf<AsyncGPUReadbackRequest>
	|-Array.InternalArray__IndexOf<BezierContour>
	|-Array.InternalArray__IndexOf<BoundingSphere>
	|-Array.InternalArray__IndexOf<CompactVoxelSpan>
	|-Array.InternalArray__IndexOf<CoordinateFootprintTilePair>
	|-Array.InternalArray__IndexOf<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__IndexOf<CoordinateStorageTilePair>
	|-Array.InternalArray__IndexOf<CoordinateTilePair>
	|-Array.InternalArray__IndexOf<DictionaryEntry>
	|-Array.InternalArray__IndexOf<DoublePoint>
	|-Array.InternalArray__IndexOf<DoublePoint>
	|-Array.InternalArray__IndexOf<DrawBufferRange>
	|-Array.InternalArray__IndexOf<DualPrefab>
	|-Array.InternalArray__IndexOf<Entry>
	|-Array.InternalArray__IndexOf<Ephemeron>
	|-Array.InternalArray__IndexOf<EventSummary>
	|-Array.InternalArray__IndexOf<ExtensionFilter>
	|-Array.InternalArray__IndexOf<FontWeightPair>
	|-Array.InternalArray__IndexOf<GfxUpdateBufferRange>
	|-Array.InternalArray__IndexOf<HeaderVariantInfo>
	|-Array.InternalArray__IndexOf<InternalCodePageDataItem>
	|-Array.InternalArray__IndexOf<InternalEncodingDataItem>
	|-Array.InternalArray__IndexOf<InterpretedFrameInfo>
	|-Array.InternalArray__IndexOf<JobHandle>
	|-Array.InternalArray__IndexOf<KeyStruct>
	|-Array.InternalArray__IndexOf<LigatureSubstitutionRecord>
	|-Array.InternalArray__IndexOf<LigatureSubstitutionRecord>
	|-Array.InternalArray__IndexOf<LinkedVoxelSpan>
	|-Array.InternalArray__IndexOf<LocalPacket>
	|-Array.InternalArray__IndexOf<LocalPacket>
	|-Array.InternalArray__IndexOf<MarkupAttribute>
	|-Array.InternalArray__IndexOf<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__IndexOf<MultipleSubstitutionRecord>
	|-Array.InternalArray__IndexOf<MultipleSubstitutionRecord>
	|-Array.InternalArray__IndexOf<Plane>
	|-Array.InternalArray__IndexOf<Playable>
	|-Array.InternalArray__IndexOf<Progress>
	|-Array.InternalArray__IndexOf<QosResult>
	|-Array.InternalArray__IndexOf<RangePositionInfo>
	|-Array.InternalArray__IndexOf<RectInt>
	|-Array.InternalArray__IndexOf<RenderBuffer>
	|-Array.InternalArray__IndexOf<RenderInstancedDataLayout>
	|-Array.InternalArray__IndexOf<Resolution>
	|-Array.InternalArray__IndexOf<ResourceLocator>
	|-Array.InternalArray__IndexOf<RpcLink>
	|-Array.InternalArray__IndexOf<RuleMatcher>
	|-Array.InternalArray__IndexOf<ScalableImage>
	|-Array.InternalArray__IndexOf<SecondarySpriteTexture>
	|-Array.InternalArray__IndexOf<SemanticMeaning>
	|-Array.InternalArray__IndexOf<ShaderKeyword>
	|-Array.InternalArray__IndexOf<SteamItemDetails_t>
	|-Array.InternalArray__IndexOf<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__IndexOf<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__IndexOf<StylePropertyValue>
	|-Array.InternalArray__IndexOf<StyleValueManaged>
	|-Array.InternalArray__IndexOf<TMP_FontWeightPair>
	|-Array.InternalArray__IndexOf<TextProcessingElement>
	|-Array.InternalArray__IndexOf<TreeItem>
	|-Array.InternalArray__IndexOf<UILineInfo>
	|-Array.InternalArray__IndexOf<UnloadedScene>
	|-Array.InternalArray__IndexOf<X509ChainStatus>
	|-Array.InternalArray__IndexOf<XPathNodeRef>
	|-Array.InternalArray__IndexOf<ZipGenericExtraField>
	|-Array.InternalArray__IndexOf<AdvancedSmooth.Turn>
	|-Array.InternalArray__IndexOf<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__IndexOf<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__IndexOf<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__IndexOf<BinaryHeap.Tuple>
	|-Array.InternalArray__IndexOf<CameraState.CustomBlendable>
	|-Array.InternalArray__IndexOf<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__IndexOf<CinemachineTargetGroup.Target>
	|-Array.InternalArray__IndexOf<ClipperLib.DoublePoint>
	|-Array.InternalArray__IndexOf<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__IndexOf<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__IndexOf<DataError.ColumnError>
	|-Array.InternalArray__IndexOf<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__IndexOf<EventDispatcher.DispatchContext>
	|-Array.InternalArray__IndexOf<EventDispatcher.EventRecord>
	|-Array.InternalArray__IndexOf<ExpressionParser.ReservedWords>
	|-Array.InternalArray__IndexOf<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__IndexOf<FocusController.FocusedElement>
	|-Array.InternalArray__IndexOf<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__IndexOf<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__IndexOf<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__IndexOf<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__IndexOf<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__IndexOf<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__IndexOf<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__IndexOf<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__IndexOf<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__IndexOf<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__IndexOf<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__IndexOf<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__IndexOf<PointKDTree.Node>
	|-Array.InternalArray__IndexOf<ProbeBrickIndex.Brick>
	|-Array.InternalArray__IndexOf<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__IndexOf<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__IndexOf<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__IndexOf<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__IndexOf<SVGDocument.NodeWithParent>
	|-Array.InternalArray__IndexOf<SendMouseEvents.HitInfo>
	|-Array.InternalArray__IndexOf<ServerSocket.ConnectionChange>
	|-Array.InternalArray__IndexOf<Socket.WSABUF>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__IndexOf<StyleSheet.ImportStruct>
	|-Array.InternalArray__IndexOf<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__IndexOf<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__IndexOf<TargetStateListener.Callback>
	|-Array.InternalArray__IndexOf<TextSettings.FontReferenceMap>
	|-Array.InternalArray__IndexOf<TextureRegistry.TextureInfo>
	|-Array.InternalArray__IndexOf<TransportManager.DisconnectingClient>
	|-Array.InternalArray__IndexOf<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__IndexOf<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__IndexOf<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__IndexOf<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__IndexOf<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__IndexOf<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__IndexOf<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__IndexOf<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__IndexOf<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__IndexOf<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__IndexOf<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__IndexOf<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__IndexOf<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__IndexOf<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__IndexOf<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__IndexOf<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	|
	|-RVA: 0xDD3D90 Offset: 0xDD2790 VA: 0x180DD3D90
	|-Array.InternalArray__IndexOf<SyncList.ChangeData<int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__IndexOf<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int2, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<bool>>
	|-Array.InternalArray__IndexOf<Set.Slot<char>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<int>>
	|-Array.InternalArray__IndexOf<Set.Slot<int>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<Scene>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<uint>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__IndexOf<RuntimeLabel>
	|-Array.InternalArray__IndexOf<UICharInfo>
	|-Array.InternalArray__IndexOf<WordInfo>
	|-Array.InternalArray__IndexOf<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__IndexOf<AstarDebugger.GraphPoint>
	|-Array.InternalArray__IndexOf<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__IndexOf<GtkPlus.GdkColor>
	|-Array.InternalArray__IndexOf<HIDParser.HIDReportData>
	|-Array.InternalArray__IndexOf<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__IndexOf<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__IndexOf<SyncTimer.ChangeData>
	|-Array.InternalArray__IndexOf<X11DesktopColors.GdkColorStruct>
	|
	|-RVA: 0xDD3F20 Offset: 0xDD2920 VA: 0x180DD3F20
	|-Array.InternalArray__IndexOf<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, bool>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, short>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, float>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, uint>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, int>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__IndexOf<AnimatorClipInfo>
	|-Array.InternalArray__IndexOf<CompactVoxelCell>
	|-Array.InternalArray__IndexOf<DecalEntity>
	|-Array.InternalArray__IndexOf<DecalSubDrawCall>
	|-Array.InternalArray__IndexOf<EventTypeSpec>
	|-Array.InternalArray__IndexOf<ParameterModifier>
	|-Array.InternalArray__IndexOf<RemoteConnectionEvent>
	|-Array.InternalArray__IndexOf<RendererListHandle>
	|-Array.InternalArray__IndexOf<ResourceHandle>
	|-Array.InternalArray__IndexOf<RpcLinkType>
	|-Array.InternalArray__IndexOf<StyleValueHandle>
	|-Array.InternalArray__IndexOf<TerrainTileCoord>
	|-Array.InternalArray__IndexOf<TextureHandle>
	|-Array.InternalArray__IndexOf<UsageHint>
	|-Array.InternalArray__IndexOf<jvalue>
	|-Array.InternalArray__IndexOf<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__IndexOf<BitmapAllocator32.Page>
	|-Array.InternalArray__IndexOf<BloomRenderer.Level>
	|-Array.InternalArray__IndexOf<CinemachineClearShot.Pair>
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__IndexOf<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__IndexOf<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__IndexOf<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__IndexOf<ListView.ItemMatrixLocation>
	|-Array.InternalArray__IndexOf<MemoryHelpers.BitRegion>
	|-Array.InternalArray__IndexOf<Multipass.TransportIdData>
	|-Array.InternalArray__IndexOf<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__IndexOf<PlayingCard.CardData>
	|-Array.InternalArray__IndexOf<SVGDocument.PostponedClip>
	|-Array.InternalArray__IndexOf<SVGDocument.PostponedStopData>
	|-Array.InternalArray__IndexOf<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__IndexOf<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__IndexOf<SyncStopwatch.ChangeData>
	|-Array.InternalArray__IndexOf<Syscall._pollfd>
	|-Array.InternalArray__IndexOf<WordStorage.Entry>
	|
	|-RVA: 0xDD4090 Offset: 0xDD2A90 VA: 0x180DD4090
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__IndexOf<SVGDocument.ClipData>
	|
	|-RVA: 0xDD45D0 Offset: 0xDD2FD0 VA: 0x180DD45D0
	|-Array.InternalArray__IndexOf<IntervalTree.Entry<object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, long>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<long, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, double>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, long>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, float>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Guid, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__IndexOf<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Color>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Playable>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Rect>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Rect, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IndexOf<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IndexOf<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IndexOf<TempAllocator.Page<ushort>>
	|-Array.InternalArray__IndexOf<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<InternedString>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__IndexOf<Set.Slot<object>>
	|-Array.InternalArray__IndexOf<TreeViewItemData<object>>
	|-Array.InternalArray__IndexOf<BezierPathSegment>
	|-Array.InternalArray__IndexOf<ComputedTransitionProperty>
	|-Array.InternalArray__IndexOf<ContourVertex>
	|-Array.InternalArray__IndexOf<ContourVertex>
	|-Array.InternalArray__IndexOf<CoordinateProceduralTilePair>
	|-Array.InternalArray__IndexOf<FrameTimeSample>
	|-Array.InternalArray__IndexOf<IntervalTreeNode>
	|-Array.InternalArray__IndexOf<JsonPosition>
	|-Array.InternalArray__IndexOf<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IndexOf<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__IndexOf<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IndexOf<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__IndexOf<NameAndParameters>
	|-Array.InternalArray__IndexOf<Packet>
	|-Array.InternalArray__IndexOf<RendererList>
	|-Array.InternalArray__IndexOf<RichTextTagAttribute>
	|-Array.InternalArray__IndexOf<RichTextTagAttribute>
	|-Array.InternalArray__IndexOf<SelectorMatchRecord>
	|-Array.InternalArray__IndexOf<StyleSelectorPart>
	|-Array.InternalArray__IndexOf<StyleSyntaxToken>
	|-Array.InternalArray__IndexOf<StyleValue>
	|-Array.InternalArray__IndexOf<StyleVariable>
	|-Array.InternalArray__IndexOf<TMP_WordInfo>
	|-Array.InternalArray__IndexOf<TreeViewItemWrapper>
	|-Array.InternalArray__IndexOf<UEvent>
	|-Array.InternalArray__IndexOf<UStar>
	|-Array.InternalArray__IndexOf<XRFeatureDescriptor>
	|-Array.InternalArray__IndexOf<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__IndexOf<AvatarSettings.LayerSetting>
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__IndexOf<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__IndexOf<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__IndexOf<Hashtable.bucket>
	|-Array.InternalArray__IndexOf<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__IndexOf<InputControlScheme.SchemeJson>
	|-Array.InternalArray__IndexOf<InputRemoting.RemoteSender>
	|-Array.InternalArray__IndexOf<LatencySimulator.Message>
	|-Array.InternalArray__IndexOf<LiquidVolume.MeshCache>
	|-Array.InternalArray__IndexOf<NatPunchModule.RequestEventData>
	|-Array.InternalArray__IndexOf<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__IndexOf<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__IndexOf<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__IndexOf<RVOQuadtree.Node>
	|-Array.InternalArray__IndexOf<ReliableChannel.PendingPacket>
	|-Array.InternalArray__IndexOf<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__IndexOf<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__IndexOf<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__IndexOf<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__IndexOf<StructySync.ChangeData>
	|-Array.InternalArray__IndexOf<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__IndexOf<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__IndexOf<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__IndexOf<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__IndexOf<XmlTextWriter.Namespace>
	|-Array.InternalArray__IndexOf<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__IndexOf<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__IndexOf<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xDD4940 Offset: 0xDD3340 VA: 0x180DD4940
	|-Array.InternalArray__IndexOf<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__IndexOf<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IndexOf<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__IndexOf<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Color>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IndexOf<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IndexOf<RBTree.Node<int>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__IndexOf<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<Color32>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<int>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<float>>
	|-Array.InternalArray__IndexOf<AstarWorkItem>
	|-Array.InternalArray__IndexOf<BezierSegment>
	|-Array.InternalArray__IndexOf<GradientSettings>
	|-Array.InternalArray__IndexOf<IndexRange>
	|-Array.InternalArray__IndexOf<Light2DBlendStyle>
	|-Array.InternalArray__IndexOf<NavMeshBuildMarkup>
	|-Array.InternalArray__IndexOf<PlayableBinding>
	|-Array.InternalArray__IndexOf<SpriteState>
	|-Array.InternalArray__IndexOf<VoxelContour>
	|-Array.InternalArray__IndexOf<XPathNode>
	|-Array.InternalArray__IndexOf<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__IndexOf<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__IndexOf<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__IndexOf<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__IndexOf<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__IndexOf<InputActionMap.ReadMapJson>
	|-Array.InternalArray__IndexOf<InputActionMap.WriteMapJson>
	|-Array.InternalArray__IndexOf<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__IndexOf<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__IndexOf<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__IndexOf<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__IndexOf<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__IndexOf<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__IndexOf<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__IndexOf<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__IndexOf<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__IndexOf<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__IndexOf<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__IndexOf<Win32DnD.FORMATETC>
	|-Array.InternalArray__IndexOf<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__IndexOf<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__IndexOf<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__IndexOf<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xDD43C0 Offset: 0xDD2DC0 VA: 0x180DD43C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__IndexOf<ComputedStyle>
	|-Array.InternalArray__IndexOf<FrameTiming>
	|
	|-RVA: 0xDD4AE0 Offset: 0xDD34E0 VA: 0x180DD4AE0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IndexOf<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IndexOf<RBTree.Node<object>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<object>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__IndexOf<ContactPairHeader>
	|-Array.InternalArray__IndexOf<Label>
	|-Array.InternalArray__IndexOf<List>
	|-Array.InternalArray__IndexOf<Navigation>
	|-Array.InternalArray__IndexOf<PlayerLoopSystem>
	|-Array.InternalArray__IndexOf<PlayerLoopSystemInternal>
	|-Array.InternalArray__IndexOf<TMP_LinkInfo>
	|-Array.InternalArray__IndexOf<TreeInstance>
	|-Array.InternalArray__IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__IndexOf<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__IndexOf<GrounderQuadruped.Foot>
	|-Array.InternalArray__IndexOf<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__IndexOf<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__IndexOf<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__IndexOf<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__IndexOf<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__IndexOf<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__IndexOf<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__IndexOf<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__IndexOf<XmlEventCache.XmlEvent>
	|-Array.InternalArray__IndexOf<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xDD5870 Offset: 0xDD4270 VA: 0x180DD5870
	|-Array.InternalArray__IndexOf<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IndexOf<UHull>
	|-Array.InternalArray__IndexOf<HID.HIDElementDescriptor>
	|-Array.InternalArray__IndexOf<InputActionMap.ReadActionJson>
	|-Array.InternalArray__IndexOf<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0xDD4CB0 Offset: 0xDD36B0 VA: 0x180DD4CB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__IndexOf<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__IndexOf<GradientColorKey>
	|-Array.InternalArray__IndexOf<GradientStop>
	|-Array.InternalArray__IndexOf<PageInfo>
	|-Array.InternalArray__IndexOf<TMP_PageInfo>
	|-Array.InternalArray__IndexOf<TemperatureEmitterInfo>
	|-Array.InternalArray__IndexOf<UEncroachingSegment>
	|-Array.InternalArray__IndexOf<CodePointIndexer.TableRange>
	|-Array.InternalArray__IndexOf<Cursor.CursorEntry>
	|-Array.InternalArray__IndexOf<HeadingTracker.Item>
	|-Array.InternalArray__IndexOf<Icon.IconDirEntry>
	|-Array.InternalArray__IndexOf<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xDD4200 Offset: 0xDD2C00 VA: 0x180DD4200
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<RaycastHit2D>
	|-Array.InternalArray__IndexOf<Funnel.PathPart>
	|-Array.InternalArray__IndexOf<LightUtility.LightMeshVertex>
	|-Array.InternalArray__IndexOf<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__IndexOf<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xDD5290 Offset: 0xDD3C90 VA: 0x180DD5290
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__IndexOf<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<Keyframe>
	|-Array.InternalArray__IndexOf<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__IndexOf<BBTree.BBTreeBox>
	|-Array.InternalArray__IndexOf<BlitUtility.Vertex>
	|-Array.InternalArray__IndexOf<CinemachinePath.Waypoint>
	|-Array.InternalArray__IndexOf<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__IndexOf<NetworkAnimator.StateChange>
	|-Array.InternalArray__IndexOf<SVGDocument.PatternData>
	|-Array.InternalArray__IndexOf<ShadowUtility.Edge>
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xDD4E50 Offset: 0xDD3850 VA: 0x180DD4E50
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|
	|-RVA: 0xDD4770 Offset: 0xDD3170 VA: 0x180DD4770
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IndexOf<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__IndexOf<ContactPoint>
	|-Array.InternalArray__IndexOf<CopyClosingMeshJobData>
	|-Array.InternalArray__IndexOf<DisplayInfo>
	|-Array.InternalArray__IndexOf<LinkInfo>
	|-Array.InternalArray__IndexOf<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__IndexOf<Rigidbody2DState>
	|-Array.InternalArray__IndexOf<Transform3x4>
	|-Array.InternalArray__IndexOf<VectorImageVertex>
	|-Array.InternalArray__IndexOf<AnimationWarping.Warp>
	|-Array.InternalArray__IndexOf<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__IndexOf<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__IndexOf<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__IndexOf<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__IndexOf<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__IndexOf<InputControlScheme.MatchResult.Match>
	|
	|-RVA: 0xDD5640 Offset: 0xDD4040 VA: 0x180DD5640
	|-Array.InternalArray__IndexOf<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__IndexOf<CombineInstance>
	|-Array.InternalArray__IndexOf<ModifiableContactPair>
	|
	|-RVA: 0xDD5450 Offset: 0xDD3E50 VA: 0x180DD5450
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__IndexOf<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__IndexOf<EnumData>
	|-Array.InternalArray__IndexOf<HumanBone>
	|-Array.InternalArray__IndexOf<Vertex>
	|-Array.InternalArray__IndexOf<Cursor.CursorImage>
	|-Array.InternalArray__IndexOf<InputActionMap.BindingJson>
	|-Array.InternalArray__IndexOf<InputManager.AvailableDevice>
	|-Array.InternalArray__IndexOf<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__IndexOf<LayerGridGraph.HeightSample>
	|-Array.InternalArray__IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xDD5A70 Offset: 0xDD4470 VA: 0x180DD5A70
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD50A0 Offset: 0xDD3AA0 VA: 0x180DD50A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__IndexOf<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__IndexOf<ContactPoint2D>
	|-Array.InternalArray__IndexOf<MaterialReference>
	|-Array.InternalArray__IndexOf<MaterialReference>
	|-Array.InternalArray__IndexOf<SkeletonBone>
	|-Array.InternalArray__IndexOf<InputActionMap.WriteActionJson>
	|-Array.InternalArray__IndexOf<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__IndexOf<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__IndexOf<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__IndexOf<TextureBlitter.BlitInfo>
	|-Array.InternalArray__IndexOf<XmlTextWriter.TagInfo>
	|
	|-RVA: 0xDD5D10 Offset: 0xDD4710 VA: 0x180DD5D10
	|-Array.InternalArray__IndexOf<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__IndexOf<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__IndexOf<MeshInfo>
	|-Array.InternalArray__IndexOf<RaycastResult>
	|-Array.InternalArray__IndexOf<TMP_MeshInfo>
	|-Array.InternalArray__IndexOf<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__IndexOf<UIRStylePainter.Entry>
	|-Array.InternalArray__IndexOf<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xDD7BC0 Offset: 0xDD65C0 VA: 0x180DD7BC0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__IndexOf<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xDD79C0 Offset: 0xDD63C0 VA: 0x180DD79C0
	|-Array.InternalArray__IndexOf<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__IndexOf<CullingSplit>
	|-Array.InternalArray__IndexOf<LightDataGI>
	|-Array.InternalArray__IndexOf<LineInfo>
	|-Array.InternalArray__IndexOf<NavMeshBuildSource>
	|-Array.InternalArray__IndexOf<TMP_LineInfo>
	|-Array.InternalArray__IndexOf<TileData>
	|-Array.InternalArray__IndexOf<RenderChain.RenderNodeData>
	|
	|-RVA: 0xDD7F60 Offset: 0xDD6960 VA: 0x180DD7F60
	|-Array.InternalArray__IndexOf<KeyValuePair<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD7DF0 Offset: 0xDD67F0 VA: 0x180DD7DF0
	|-Array.InternalArray__IndexOf<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__IndexOf<Color32>
	|-Array.InternalArray__IndexOf<InclusiveRange>
	|-Array.InternalArray__IndexOf<LayerMask>
	|-Array.InternalArray__IndexOf<SortingLayer>
	|-Array.InternalArray__IndexOf<UShort2>
	|-Array.InternalArray__IndexOf<HebrewNumber.HebrewValue>
	|-Array.InternalArray__IndexOf<RegexCharClass.SingleRange>
	|
	|-RVA: 0xDD8200 Offset: 0xDD6C00 VA: 0x180DD8200
	|-Array.InternalArray__IndexOf<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__IndexOf<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__IndexOf<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xDD8340 Offset: 0xDD6D40 VA: 0x180DD8340
	|-Array.InternalArray__IndexOf<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__IndexOf<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__IndexOf<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xDD85F0 Offset: 0xDD6FF0 VA: 0x180DD85F0
	|-Array.InternalArray__IndexOf<Nullable<DateTime>>
	|
	|-RVA: 0xDD8480 Offset: 0xDD6E80 VA: 0x180DD8480
	|-Array.InternalArray__IndexOf<Nullable<Decimal>>
	|
	|-RVA: 0xDD8750 Offset: 0xDD7150 VA: 0x180DD8750
	|-Array.InternalArray__IndexOf<InputStateHistory.Record<TouchState>>
	|
	|-RVA: 0xDD8890 Offset: 0xDD7290 VA: 0x180DD8890
	|-Array.InternalArray__IndexOf<StructMultiKey<object, object>>
	|
	|-RVA: 0xDD89D0 Offset: 0xDD73D0 VA: 0x180DD89D0
	|-Array.InternalArray__IndexOf<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|
	|-RVA: 0xDD8BF0 Offset: 0xDD75F0 VA: 0x180DD8BF0
	|-Array.InternalArray__IndexOf<SubArray<int>>
	|
	|-RVA: 0xDD8D30 Offset: 0xDD7730 VA: 0x180DD8D30
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0xDD8FF0 Offset: 0xDD79F0 VA: 0x180DD8FF0
	|-Array.InternalArray__IndexOf<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__IndexOf<WordWrapState>
	|
	|-RVA: 0xDD9290 Offset: 0xDD7C90 VA: 0x180DD9290
	|-Array.InternalArray__IndexOf<ValueTuple<bool>>
	|
	|-RVA: 0xDD97A0 Offset: 0xDD81A0 VA: 0x180DD97A0
	|-Array.InternalArray__IndexOf<ValueTuple<int, int>>
	|
	|-RVA: 0xDD9EE0 Offset: 0xDD88E0 VA: 0x180DD9EE0
	|-Array.InternalArray__IndexOf<ValueTuple<int, object>>
	|
	|-RVA: 0xDD98C0 Offset: 0xDD82C0 VA: 0x180DD98C0
	|-Array.InternalArray__IndexOf<ValueTuple<int, Scene>>
	|
	|-RVA: 0xDD9660 Offset: 0xDD8060 VA: 0x180DD9660
	|-Array.InternalArray__IndexOf<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xDD99E0 Offset: 0xDD83E0 VA: 0x180DD99E0
	|-Array.InternalArray__IndexOf<ValueTuple<Int32Enum, object>>
	|
	|-RVA: 0xDD9DA0 Offset: 0xDD87A0 VA: 0x180DD9DA0
	|-Array.InternalArray__IndexOf<ValueTuple<IntPtr, object>>
	|
	|-RVA: 0xDD9510 Offset: 0xDD7F10 VA: 0x180DD9510
	|-Array.InternalArray__IndexOf<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xDD9C60 Offset: 0xDD8660 VA: 0x180DD9C60
	|-Array.InternalArray__IndexOf<ValueTuple<object, int>>
	|
	|-RVA: 0xDD9B20 Offset: 0xDD8520 VA: 0x180DD9B20
	|-Array.InternalArray__IndexOf<ValueTuple<object, object>>
	|
	|-RVA: 0xDDA020 Offset: 0xDD8A20 VA: 0x180DDA020
	|-Array.InternalArray__IndexOf<ValueTuple<Vector3, Quaternion>>
	|
	|-RVA: 0xDD93C0 Offset: 0xDD7DC0 VA: 0x180DD93C0
	|-Array.InternalArray__IndexOf<ValueTuple<Vector4, Vector2Int>>
	|
	|-RVA: 0xDDA180 Offset: 0xDD8B80 VA: 0x180DDA180
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object>>
	|
	|-RVA: 0xDD6160 Offset: 0xDD4B60 VA: 0x180DD6160
	|-Array.InternalArray__IndexOf<AppId_t>
	|
	|-RVA: 0xDD62B0 Offset: 0xDD4CB0 VA: 0x180DD62B0
	|-Array.InternalArray__IndexOf<AttachmentDescriptor>
	|
	|-RVA: 0xDD6840 Offset: 0xDD5240 VA: 0x180DD6840
	|-Array.InternalArray__IndexOf<Background>
	|
	|-RVA: 0xDD6490 Offset: 0xDD4E90 VA: 0x180DD6490
	|-Array.InternalArray__IndexOf<BackgroundPosition>
	|
	|-RVA: 0xDD65D0 Offset: 0xDD4FD0 VA: 0x180DD65D0
	|-Array.InternalArray__IndexOf<BackgroundRepeat>
	|
	|-RVA: 0xDD66F0 Offset: 0xDD50F0 VA: 0x180DD66F0
	|-Array.InternalArray__IndexOf<BackgroundSize>
	|
	|-RVA: 0xDD6990 Offset: 0xDD5390 VA: 0x180DD6990
	|-Array.InternalArray__IndexOf<BigInteger>
	|
	|-RVA: 0xDD6AF0 Offset: 0xDD54F0 VA: 0x180DD6AF0
	|-Array.InternalArray__IndexOf<Board>
	|-Array.InternalArray__IndexOf<RendererListResource>
	|
	|-RVA: 0xDD6DA0 Offset: 0xDD57A0 VA: 0x180DD6DA0
	|-Array.InternalArray__IndexOf<bool>
	|
	|-RVA: 0xDD7050 Offset: 0xDD5A50 VA: 0x180DD7050
	|-Array.InternalArray__IndexOf<Bounds>
	|
	|-RVA: 0xDD6F00 Offset: 0xDD5900 VA: 0x180DD6F00
	|-Array.InternalArray__IndexOf<BoundsInt>
	|
	|-RVA: 0xDD7310 Offset: 0xDD5D10 VA: 0x180DD7310
	|-Array.InternalArray__IndexOf<byte>
	|
	|-RVA: 0xDD71A0 Offset: 0xDD5BA0 VA: 0x180DD71A0
	|-Array.InternalArray__IndexOf<ByteEnum>
	|-Array.InternalArray__IndexOf<SByteEnum>
	|
	|-RVA: 0xDD7440 Offset: 0xDD5E40 VA: 0x180DD7440
	|-Array.InternalArray__IndexOf<CGSpot>
	|
	|-RVA: 0xDD75C0 Offset: 0xDD5FC0 VA: 0x180DD75C0
	|-Array.InternalArray__IndexOf<CSteamID>
	|
	|-RVA: 0xDD7710 Offset: 0xDD6110 VA: 0x180DD7710
	|-Array.InternalArray__IndexOf<char>
	|
	|-RVA: 0xDD7870 Offset: 0xDD6270 VA: 0x180DD7870
	|-Array.InternalArray__IndexOf<Color>
	|
	|-RVA: 0xDDAD30 Offset: 0xDD9730 VA: 0x180DDAD30
	|-Array.InternalArray__IndexOf<Color>
	|
	|-RVA: 0xDDAB40 Offset: 0xDD9540 VA: 0x180DDAB40
	|-Array.InternalArray__IndexOf<ColorBlock>
	|
	|-RVA: 0xDDAE70 Offset: 0xDD9870 VA: 0x180DDAE70
	|-Array.InternalArray__IndexOf<Connection>
	|
	|-RVA: 0xDDAFB0 Offset: 0xDD99B0 VA: 0x180DDAFB0
	|-Array.InternalArray__IndexOf<ControlPointOption>
	|
	|-RVA: 0xDDB110 Offset: 0xDD9B10 VA: 0x180DDB110
	|-Array.InternalArray__IndexOf<ConvertMeshJobData>
	|
	|-RVA: 0xDDB390 Offset: 0xDD9D90 VA: 0x180DDB390
	|-Array.InternalArray__IndexOf<CustomAttributeNamedArgument>
	|
	|-RVA: 0xDDB500 Offset: 0xDD9F00 VA: 0x180DDB500
	|-Array.InternalArray__IndexOf<CustomAttributeTypedArgument>
	|
	|-RVA: 0xDDB7A0 Offset: 0xDDA1A0 VA: 0x180DDB7A0
	|-Array.InternalArray__IndexOf<DateTime>
	|
	|-RVA: 0xDDB640 Offset: 0xDDA040 VA: 0x180DDB640
	|-Array.InternalArray__IndexOf<DateTimeOffset>
	|
	|-RVA: 0xDDB8F0 Offset: 0xDDA2F0 VA: 0x180DDB8F0
	|-Array.InternalArray__IndexOf<Decimal>
	|
	|-RVA: 0xDDBA50 Offset: 0xDDA450 VA: 0x180DDBA50
	|-Array.InternalArray__IndexOf<DepotId_t>
	|
	|-RVA: 0xDDBBA0 Offset: 0xDDA5A0 VA: 0x180DDBBA0
	|-Array.InternalArray__IndexOf<Dimension>
	|
	|-RVA: 0xDDBCC0 Offset: 0xDDA6C0 VA: 0x180DDBCC0
	|-Array.InternalArray__IndexOf<double>
	|
	|-RVA: 0xDDBDF0 Offset: 0xDDA7F0 VA: 0x180DDBDF0
	|-Array.InternalArray__IndexOf<DuplicateSamplePoint>
	|
	|-RVA: 0xDDBF30 Offset: 0xDDA930 VA: 0x180DDBF30
	|-Array.InternalArray__IndexOf<EasingFunction>
	|
	|-RVA: 0xDDC050 Offset: 0xDDAA50 VA: 0x180DDC050
	|-Array.InternalArray__IndexOf<FixedString128Bytes>
	|
	|-RVA: 0xDDC230 Offset: 0xDDAC30 VA: 0x180DDC230
	|-Array.InternalArray__IndexOf<FontDefinition>
	|
	|-RVA: 0xDDC370 Offset: 0xDDAD70 VA: 0x180DDC370
	|-Array.InternalArray__IndexOf<FullRank>
	|
	|-RVA: 0xDDC490 Offset: 0xDDAE90 VA: 0x180DDC490
	|-Array.InternalArray__IndexOf<GCHandle>
	|
	|-RVA: 0xDDC5B0 Offset: 0xDDAFB0 VA: 0x180DDC5B0
	|-Array.InternalArray__IndexOf<GlyphMarshallingStruct>
	|-Array.InternalArray__IndexOf<LayerBatch>
	|-Array.InternalArray__IndexOf<UTriangle>
	|
	|-RVA: 0xDDC790 Offset: 0xDDB190 VA: 0x180DDC790
	|-Array.InternalArray__IndexOf<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xDDC910 Offset: 0xDDB310 VA: 0x180DDC910
	|-Array.InternalArray__IndexOf<GlyphRect>
	|
	|-RVA: 0xDDCA70 Offset: 0xDDB470 VA: 0x180DDCA70
	|-Array.InternalArray__IndexOf<GradientAlphaKey>
	|-Array.InternalArray__IndexOf<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__IndexOf<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__IndexOf<SVGDocument.NodeGlobalSceneState>
	|
	|-RVA: 0xDDCC00 Offset: 0xDDB600 VA: 0x180DDCC00
	|-Array.InternalArray__IndexOf<Guid>
	|
	|-RVA: 0xDDCD40 Offset: 0xDDB740 VA: 0x180DDCD40
	|-Array.InternalArray__IndexOf<HSteamNetConnection>
	|
	|-RVA: 0xDDCE90 Offset: 0xDDB890 VA: 0x180DDCE90
	|-Array.InternalArray__IndexOf<Hash128>
	|
	|-RVA: 0xDDCFD0 Offset: 0xDDB9D0 VA: 0x180DDCFD0
	|-Array.InternalArray__IndexOf<HighlightState>
	|
	|-RVA: 0xDDD120 Offset: 0xDDBB20 VA: 0x180DDD120
	|-Array.InternalArray__IndexOf<HighlightState>
	|
	|-RVA: 0xDDD270 Offset: 0xDDBC70 VA: 0x180DDD270
	|-Array.InternalArray__IndexOf<IndexField>
	|
	|-RVA: 0xDDD3B0 Offset: 0xDDBDB0 VA: 0x180DDD3B0
	|-Array.InternalArray__IndexOf<InputActionSetHandle_t>
	|
	|-RVA: 0xDDD4D0 Offset: 0xDDBED0 VA: 0x180DDD4D0
	|-Array.InternalArray__IndexOf<InputBinding>
	|
	|-RVA: 0xDDD690 Offset: 0xDDC090 VA: 0x180DDD690
	|-Array.InternalArray__IndexOf<InputControlScheme>
	|
	|-RVA: 0xDDD7E0 Offset: 0xDDC1E0 VA: 0x180DDD7E0
	|-Array.InternalArray__IndexOf<InputDeviceDescription>
	|
	|-RVA: 0xDDD970 Offset: 0xDDC370 VA: 0x180DDD970
	|-Array.InternalArray__IndexOf<InputEventPtr>
	|
	|-RVA: 0xDDDA90 Offset: 0xDDC490 VA: 0x180DDDA90
	|-Array.InternalArray__IndexOf<InputHandle_t>
	|
	|-RVA: 0xDDDBB0 Offset: 0xDDC5B0 VA: 0x180DDDBB0
	|-Array.InternalArray__IndexOf<InputUser>
	|
	|-RVA: 0xDDDD00 Offset: 0xDDC700 VA: 0x180DDDD00
	|-Array.InternalArray__IndexOf<short>
	|
	|-RVA: 0xDDDE30 Offset: 0xDDC830 VA: 0x180DDDE30
	|-Array.InternalArray__IndexOf<Int2>
	|
	|-RVA: 0xDDE1E0 Offset: 0xDDCBE0 VA: 0x180DDE1E0
	|-Array.InternalArray__IndexOf<Int3>
	|
	|-RVA: 0xDDE0C0 Offset: 0xDDCAC0 VA: 0x180DDE0C0
	|-Array.InternalArray__IndexOf<int>
	|
	|-RVA: 0xDDDF50 Offset: 0xDDC950 VA: 0x180DDDF50
	|-Array.InternalArray__IndexOf<Int32Enum>
	|-Array.InternalArray__IndexOf<UInt32Enum>
	|
	|-RVA: 0xDDE320 Offset: 0xDDCD20 VA: 0x180DDE320
	|-Array.InternalArray__IndexOf<long>
	|
	|-RVA: 0xDDE5B0 Offset: 0xDDCFB0 VA: 0x180DDE5B0
	|-Array.InternalArray__IndexOf<IntPoint>
	|
	|-RVA: 0xDDE440 Offset: 0xDDCE40 VA: 0x180DDE440
	|-Array.InternalArray__IndexOf<IntPoint>
	|
	|-RVA: 0xDDE6F0 Offset: 0xDDD0F0 VA: 0x180DDE6F0
	|-Array.InternalArray__IndexOf<IntPtr>
	|
	|-RVA: 0xDDE810 Offset: 0xDDD210 VA: 0x180DDE810
	|-Array.InternalArray__IndexOf<IntRect>
	|
	|-RVA: 0xDDE950 Offset: 0xDDD350 VA: 0x180DDE950
	|-Array.InternalArray__IndexOf<IntRegion>
	|
	|-RVA: 0xDDEA90 Offset: 0xDDD490 VA: 0x180DDEA90
	|-Array.InternalArray__IndexOf<InternedString>
	|
	|-RVA: 0xDDEBD0 Offset: 0xDDD5D0 VA: 0x180DDEBD0
	|-Array.InternalArray__IndexOf<Length>
	|
	|-RVA: 0xDDECF0 Offset: 0xDDD6F0 VA: 0x180DDECF0
	|-Array.InternalArray__IndexOf<LocalDefinition>
	|
	|-RVA: 0xDDEE30 Offset: 0xDDD830 VA: 0x180DDEE30
	|-Array.InternalArray__IndexOf<LocalKeyword>
	|
	|-RVA: 0xDDEF80 Offset: 0xDDD980 VA: 0x180DDEF80
	|-Array.InternalArray__IndexOf<ManipulatorActivationFilter>
	|
	|-RVA: 0xDDF0C0 Offset: 0xDDDAC0 VA: 0x180DDF0C0
	|-Array.InternalArray__IndexOf<Matrix4x4>
	|
	|-RVA: 0xDDF250 Offset: 0xDDDC50 VA: 0x180DDF250
	|-Array.InternalArray__IndexOf<NamedValue>
	|
	|-RVA: 0xDDF3A0 Offset: 0xDDDDA0 VA: 0x180DDF3A0
	|-Array.InternalArray__IndexOf<NativeAddr>
	|
	|-RVA: 0xDDF4F0 Offset: 0xDDDEF0 VA: 0x180DDF4F0
	|-Array.InternalArray__IndexOf<NudgeJobData>
	|-Array.InternalArray__IndexOf<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__IndexOf<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__IndexOf<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__IndexOf<Tilemap.SyncTile>
	|-Array.InternalArray__IndexOf<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0xDE0AA0 Offset: 0xDDF4A0 VA: 0x180DE0AA0
	|-Array.InternalArray__IndexOf<object>
	|
	|-RVA: 0xDDF860 Offset: 0xDDE260 VA: 0x180DDF860
	|-Array.InternalArray__IndexOf<Point>
	|
	|-RVA: 0xDDF730 Offset: 0xDDE130 VA: 0x180DDF730
	|-Array.InternalArray__IndexOf<PointF>
	|
	|-RVA: 0xDDF980 Offset: 0xDDE380 VA: 0x180DDF980
	|-Array.InternalArray__IndexOf<PointerModel>
	|
	|-RVA: 0xDDFC00 Offset: 0xDDE600 VA: 0x180DDFC00
	|-Array.InternalArray__IndexOf<Pollfd>
	|
	|-RVA: 0xDDFD20 Offset: 0xDDE720 VA: 0x180DDFD20
	|-Array.InternalArray__IndexOf<PublishedFileId_t>
	|
	|-RVA: 0xDDFE70 Offset: 0xDDE870 VA: 0x180DDFE70
	|-Array.InternalArray__IndexOf<Quaternion>
	|
	|-RVA: 0xDDFFB0 Offset: 0xDDE9B0 VA: 0x180DDFFB0
	|-Array.InternalArray__IndexOf<RaycastHit>
	|-Array.InternalArray__IndexOf<VolumetricFog.FogOfWarTransition>
	|
	|-RVA: 0xDE0190 Offset: 0xDDEB90 VA: 0x180DE0190
	|-Array.InternalArray__IndexOf<Rect>
	|
	|-RVA: 0xDE02D0 Offset: 0xDDECD0 VA: 0x180DE02D0
	|-Array.InternalArray__IndexOf<Rectangle>
	|
	|-RVA: 0xDE0410 Offset: 0xDDEE10 VA: 0x180DE0410
	|-Array.InternalArray__IndexOf<RenderStateBlock>
	|
	|-RVA: 0xDE05F0 Offset: 0xDDEFF0 VA: 0x180DE05F0
	|-Array.InternalArray__IndexOf<RenderTargetIdentifier>
	|
	|-RVA: 0xDE0760 Offset: 0xDDF160 VA: 0x180DE0760
	|-Array.InternalArray__IndexOf<RigidbodyState>
	|
	|-RVA: 0xDE0950 Offset: 0xDDF350 VA: 0x180DE0950
	|-Array.InternalArray__IndexOf<Rotate>
	|
	|-RVA: 0xDE0BD0 Offset: 0xDDF5D0 VA: 0x180DE0BD0
	|-Array.InternalArray__IndexOf<sbyte>
	|
	|-RVA: 0xDE0D00 Offset: 0xDDF700 VA: 0x180DE0D00
	|-Array.InternalArray__IndexOf<SamplePointUData>
	|
	|-RVA: 0xDE0E40 Offset: 0xDDF840 VA: 0x180DE0E40
	|-Array.InternalArray__IndexOf<SamplePointsPatch>
	|
	|-RVA: 0xDE0F60 Offset: 0xDDF960 VA: 0x180DE0F60
	|-Array.InternalArray__IndexOf<Scale>
	|
	|-RVA: 0xDE10A0 Offset: 0xDDFAA0 VA: 0x180DE10A0
	|-Array.InternalArray__IndexOf<Scene>
	|
	|-RVA: 0xDE11C0 Offset: 0xDDFBC0 VA: 0x180DE11C0
	|-Array.InternalArray__IndexOf<ShaderTagId>
	|
	|-RVA: 0xDE12E0 Offset: 0xDDFCE0 VA: 0x180DE12E0
	|-Array.InternalArray__IndexOf<ShadowSliceData>
	|
	|-RVA: 0xDE1590 Offset: 0xDDFF90 VA: 0x180DE1590
	|-Array.InternalArray__IndexOf<float>
	|
	|-RVA: 0xDE16C0 Offset: 0xDE00C0 VA: 0x180DE16C0
	|-Array.InternalArray__IndexOf<SqlBinary>
	|
	|-RVA: 0xDE1810 Offset: 0xDE0210 VA: 0x180DE1810
	|-Array.InternalArray__IndexOf<SqlBoolean>
	|
	|-RVA: 0xDE1970 Offset: 0xDE0370 VA: 0x180DE1970
	|-Array.InternalArray__IndexOf<SqlByte>
	|
	|-RVA: 0xDE1AC0 Offset: 0xDE04C0 VA: 0x180DE1AC0
	|-Array.InternalArray__IndexOf<SqlDateTime>
	|
	|-RVA: 0xDE1C30 Offset: 0xDE0630 VA: 0x180DE1C30
	|-Array.InternalArray__IndexOf<SqlDecimal>
	|
	|-RVA: 0xDE1DB0 Offset: 0xDE07B0 VA: 0x180DE1DB0
	|-Array.InternalArray__IndexOf<SqlDouble>
	|
	|-RVA: 0xDE1F10 Offset: 0xDE0910 VA: 0x180DE1F10
	|-Array.InternalArray__IndexOf<SqlGuid>
	|
	|-RVA: 0xDE2060 Offset: 0xDE0A60 VA: 0x180DE2060
	|-Array.InternalArray__IndexOf<SqlInt16>
	|
	|-RVA: 0xDE21B0 Offset: 0xDE0BB0 VA: 0x180DE21B0
	|-Array.InternalArray__IndexOf<SqlInt32>
	|
	|-RVA: 0xDE2300 Offset: 0xDE0D00 VA: 0x180DE2300
	|-Array.InternalArray__IndexOf<SqlInt64>
	|
	|-RVA: 0xDE2460 Offset: 0xDE0E60 VA: 0x180DE2460
	|-Array.InternalArray__IndexOf<SqlMoney>
	|
	|-RVA: 0xDE25C0 Offset: 0xDE0FC0 VA: 0x180DE25C0
	|-Array.InternalArray__IndexOf<SqlSingle>
	|
	|-RVA: 0xDE2710 Offset: 0xDE1110 VA: 0x180DE2710
	|-Array.InternalArray__IndexOf<SqlString>
	|
	|-RVA: 0xDE2890 Offset: 0xDE1290 VA: 0x180DE2890
	|-Array.InternalArray__IndexOf<SteamItemDef_t>
	|
	|-RVA: 0xDE29B0 Offset: 0xDE13B0 VA: 0x180DE29B0
	|-Array.InternalArray__IndexOf<SteamItemInstanceID_t>
	|
	|-RVA: 0xDE2B00 Offset: 0xDE1500 VA: 0x180DE2B00
	|-Array.InternalArray__IndexOf<StylePropertyName>
	|
	|-RVA: 0xDE2C40 Offset: 0xDE1640 VA: 0x180DE2C40
	|-Array.InternalArray__IndexOf<Substring>
	|
	|-RVA: 0xDE2D80 Offset: 0xDE1780 VA: 0x180DE2D80
	|-Array.InternalArray__IndexOf<TMP_CharacterInfo>
	|
	|-RVA: 0xDE4CE0 Offset: 0xDE36E0 VA: 0x180DE4CE0
	|-Array.InternalArray__IndexOf<TextElementInfo>
	|
	|-RVA: 0xDE4F50 Offset: 0xDE3950 VA: 0x180DE4F50
	|-Array.InternalArray__IndexOf<TextShadow>
	|
	|-RVA: 0xDE50B0 Offset: 0xDE3AB0 VA: 0x180DE50B0
	|-Array.InternalArray__IndexOf<TextureId>
	|
	|-RVA: 0xDE5200 Offset: 0xDE3C00 VA: 0x180DE5200
	|-Array.InternalArray__IndexOf<TimeSpan>
	|
	|-RVA: 0xDE5350 Offset: 0xDE3D50 VA: 0x180DE5350
	|-Array.InternalArray__IndexOf<TimeValue>
	|
	|-RVA: 0xDE5470 Offset: 0xDE3E70 VA: 0x180DE5470
	|-Array.InternalArray__IndexOf<Touch>
	|
	|-RVA: 0xDE5660 Offset: 0xDE4060 VA: 0x180DE5660
	|-Array.InternalArray__IndexOf<Touch>
	|
	|-RVA: 0xDE57E0 Offset: 0xDE41E0 VA: 0x180DE57E0
	|-Array.InternalArray__IndexOf<TransformOrigin>
	|
	|-RVA: 0xDE5A70 Offset: 0xDE4470 VA: 0x180DE5A70
	|-Array.InternalArray__IndexOf<Translate>
	|
	|-RVA: 0xDE5BC0 Offset: 0xDE45C0 VA: 0x180DE5BC0
	|-Array.InternalArray__IndexOf<UIVertex>
	|
	|-RVA: 0xDE5F60 Offset: 0xDE4960 VA: 0x180DE5F60
	|-Array.InternalArray__IndexOf<ushort>
	|
	|-RVA: 0xDE5DF0 Offset: 0xDE47F0 VA: 0x180DE5DF0
	|-Array.InternalArray__IndexOf<UInt16Enum>
	|
	|-RVA: 0xDE6090 Offset: 0xDE4A90 VA: 0x180DE6090
	|-Array.InternalArray__IndexOf<uint>
	|
	|-RVA: 0xDE61B0 Offset: 0xDE4BB0 VA: 0x180DE61B0
	|-Array.InternalArray__IndexOf<ulong>
	|
	|-RVA: 0xDE68A0 Offset: 0xDE52A0 VA: 0x180DE68A0
	|-Array.InternalArray__IndexOf<Vector2>
	|
	|-RVA: 0xDE6780 Offset: 0xDE5180 VA: 0x180DE6780
	|-Array.InternalArray__IndexOf<Vector2Int>
	|
	|-RVA: 0xDE6B90 Offset: 0xDE5590 VA: 0x180DE6B90
	|-Array.InternalArray__IndexOf<Vector3>
	|
	|-RVA: 0xDE6A50 Offset: 0xDE5450 VA: 0x180DE6A50
	|-Array.InternalArray__IndexOf<Vector3Int>
	|
	|-RVA: 0xDE6CD0 Offset: 0xDE56D0 VA: 0x180DE6CD0
	|-Array.InternalArray__IndexOf<Vector4>
	|
	|-RVA: 0xDE6E10 Offset: 0xDE5810 VA: 0x180DE6E10
	|-Array.InternalArray__IndexOf<VertexAttributeDescriptor>
	|
	|-RVA: 0xDE6F50 Offset: 0xDE5950 VA: 0x180DE6F50
	|-Array.InternalArray__IndexOf<VisibleLight>
	|
	|-RVA: 0xDE7130 Offset: 0xDE5B30 VA: 0x180DE7130
	|-Array.InternalArray__IndexOf<VisibleReflectionProbe>
	|
	|-RVA: 0xDE7320 Offset: 0xDE5D20 VA: 0x180DE7320
	|-Array.InternalArray__IndexOf<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xDE7590 Offset: 0xDE5F90 VA: 0x180DE7590
	|-Array.InternalArray__IndexOf<WordWrapState>
	|
	|-RVA: 0xDE7810 Offset: 0xDE6210 VA: 0x180DE7810
	|-Array.InternalArray__IndexOf<XEvent>
	|
	|-RVA: 0xDE7AA0 Offset: 0xDE64A0 VA: 0x180DE7AA0
	|-Array.InternalArray__IndexOf<XRView>
	|
	|-RVA: 0xDE44C0 Offset: 0xDE2EC0 VA: 0x180DE44C0
	|-Array.InternalArray__IndexOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDE7D20 Offset: 0xDE6720 VA: 0x180DE7D20
	|-Array.InternalArray__IndexOf<double2>
	|
	|-RVA: 0xDE7E60 Offset: 0xDE6860 VA: 0x180DE7E60
	|-Array.InternalArray__IndexOf<float2>
	|
	|-RVA: 0xDE7F90 Offset: 0xDE6990 VA: 0x180DE7F90
	|-Array.InternalArray__IndexOf<float3>
	|
	|-RVA: 0xDE80D0 Offset: 0xDE6AD0 VA: 0x180DE80D0
	|-Array.InternalArray__IndexOf<float4>
	|
	|-RVA: 0xDE8210 Offset: 0xDE6C10 VA: 0x180DE8210
	|-Array.InternalArray__IndexOf<float4x4>
	|
	|-RVA: 0xDE83A0 Offset: 0xDE6DA0 VA: 0x180DE83A0
	|-Array.InternalArray__IndexOf<int2>
	|
	|-RVA: 0xDE84C0 Offset: 0xDE6EC0 VA: 0x180DE84C0
	|-Array.InternalArray__IndexOf<int3>
	|
	|-RVA: 0xDE8600 Offset: 0xDE7000 VA: 0x180DE8600
	|-Array.InternalArray__IndexOf<int4>
	|
	|-RVA: 0xDE8740 Offset: 0xDE7140 VA: 0x180DE8740
	|-Array.InternalArray__IndexOf<quaternion>
	|
	|-RVA: 0xDE6560 Offset: 0xDE4F60 VA: 0x180DE6560
	|-Array.InternalArray__IndexOf<Agent.VO>
	|
	|-RVA: 0xDE4750 Offset: 0xDE3150 VA: 0x180DE4750
	|-Array.InternalArray__IndexOf<ClipperLib.IntPoint>
	|
	|-RVA: 0xDE3B90 Offset: 0xDE2590 VA: 0x180DE3B90
	|-Array.InternalArray__IndexOf<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xDE3E00 Offset: 0xDE2800 VA: 0x180DE3E00
	|-Array.InternalArray__IndexOf<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xDE3FE0 Offset: 0xDE29E0 VA: 0x180DE3FE0
	|-Array.InternalArray__IndexOf<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xDE4250 Offset: 0xDE2C50 VA: 0x180DE4250
	|-Array.InternalArray__IndexOf<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xDE37B0 Offset: 0xDE21B0 VA: 0x180DE37B0
	|-Array.InternalArray__IndexOf<InputControlLayout.ControlItem>
	|
	|-RVA: 0xDE3A50 Offset: 0xDE2450 VA: 0x180DE3A50
	|-Array.InternalArray__IndexOf<InputControlScheme.DeviceRequirement>
	|
	|-RVA: 0xDE3600 Offset: 0xDE2000 VA: 0x180DE3600
	|-Array.InternalArray__IndexOf<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xDE4BA0 Offset: 0xDE35A0 VA: 0x180DE4BA0
	|-Array.InternalArray__IndexOf<InputStateHistory.Record>
	|
	|-RVA: 0xDE5930 Offset: 0xDE4330 VA: 0x180DE5930
	|-Array.InternalArray__IndexOf<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xDE62D0 Offset: 0xDE4CD0 VA: 0x180DE62D0
	|-Array.InternalArray__IndexOf<InputUser.UserData>
	|
	|-RVA: 0xDE4890 Offset: 0xDE3290 VA: 0x180DE4890
	|-Array.InternalArray__IndexOf<JsonParser.JsonValue>
	|
	|-RVA: 0xDE4A30 Offset: 0xDE3430 VA: 0x180DE4A30
	|-Array.InternalArray__IndexOf<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__IndexOf<SVGDocument.MaskData>
	|
	|-RVA: 0xDE34B0 Offset: 0xDE1EB0 VA: 0x180DE34B0
	|-Array.InternalArray__IndexOf<Regex.CachedCodeEntryKey>
	|
	|-RVA: 0xDE8880 Offset: 0xDE7280 VA: 0x180DE8880
	|-Array.InternalArray__IndexOf<ShaderInput.LightData>
	|
	|-RVA: 0xDE8A80 Offset: 0xDE7480 VA: 0x180DE8A80
	|-Array.InternalArray__IndexOf<XmlSqlBinaryReader.QName>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD1220 Offset: 0xDCFC20 VA: 0x180DD1220
	|-Array.InternalArray__get_Item<ArraySegment<byte>>
	|-Array.InternalArray__get_Item<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__get_Item<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, short>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, float>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int2, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int3, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Int3>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, long>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, ulong>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<long, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, bool>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, char>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Color32>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, double>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, long>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, float>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__get_Item<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Scene, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<ushort, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__get_Item<KeyValue<int, int>>
	|-Array.InternalArray__get_Item<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__get_Item<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__get_Item<NativeArray<NudgeJobData>>
	|-Array.InternalArray__get_Item<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__get_Item<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__get_Item<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__get_Item<Nullable<DateTime>>
	|-Array.InternalArray__get_Item<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__get_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__get_Item<HashSet.Slot<object>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__get_Item<HashSet.Slot<ulong>>
	|-Array.InternalArray__get_Item<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__get_Item<StructMultiKey<object, object>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__get_Item<SubArray<int>>
	|-Array.InternalArray__get_Item<ValueTuple<int, object>>
	|-Array.InternalArray__get_Item<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__get_Item<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__get_Item<ValueTuple<object, int>>
	|-Array.InternalArray__get_Item<ValueTuple<object, object>>
	|-Array.InternalArray__get_Item<AsyncGPUReadbackRequest>
	|-Array.InternalArray__get_Item<BezierContour>
	|-Array.InternalArray__get_Item<BigInteger>
	|-Array.InternalArray__get_Item<BoundingSphere>
	|-Array.InternalArray__get_Item<Color>
	|-Array.InternalArray__get_Item<CompactVoxelSpan>
	|-Array.InternalArray__get_Item<Connection>
	|-Array.InternalArray__get_Item<CoordinateFootprintTilePair>
	|-Array.InternalArray__get_Item<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__get_Item<CoordinateStorageTilePair>
	|-Array.InternalArray__get_Item<CoordinateTilePair>
	|-Array.InternalArray__get_Item<CustomAttributeTypedArgument>
	|-Array.InternalArray__get_Item<DateTimeOffset>
	|-Array.InternalArray__get_Item<Decimal>
	|-Array.InternalArray__get_Item<DictionaryEntry>
	|-Array.InternalArray__get_Item<DoublePoint>
	|-Array.InternalArray__get_Item<DoublePoint>
	|-Array.InternalArray__get_Item<DrawBufferRange>
	|-Array.InternalArray__get_Item<DualPrefab>
	|-Array.InternalArray__get_Item<Entry>
	|-Array.InternalArray__get_Item<Ephemeron>
	|-Array.InternalArray__get_Item<EventSummary>
	|-Array.InternalArray__get_Item<ExtensionFilter>
	|-Array.InternalArray__get_Item<FontDefinition>
	|-Array.InternalArray__get_Item<FontWeightPair>
	|-Array.InternalArray__get_Item<GfxUpdateBufferRange>
	|-Array.InternalArray__get_Item<GlyphRect>
	|-Array.InternalArray__get_Item<Guid>
	|-Array.InternalArray__get_Item<Hash128>
	|-Array.InternalArray__get_Item<HeaderVariantInfo>
	|-Array.InternalArray__get_Item<IndexField>
	|-Array.InternalArray__get_Item<IntPoint>
	|-Array.InternalArray__get_Item<IntRect>
	|-Array.InternalArray__get_Item<InternalCodePageDataItem>
	|-Array.InternalArray__get_Item<InternalEncodingDataItem>
	|-Array.InternalArray__get_Item<InternedString>
	|-Array.InternalArray__get_Item<InterpretedFrameInfo>
	|-Array.InternalArray__get_Item<JobHandle>
	|-Array.InternalArray__get_Item<KeyStruct>
	|-Array.InternalArray__get_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__get_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__get_Item<LinkedVoxelSpan>
	|-Array.InternalArray__get_Item<LocalDefinition>
	|-Array.InternalArray__get_Item<LocalPacket>
	|-Array.InternalArray__get_Item<LocalPacket>
	|-Array.InternalArray__get_Item<MarkupAttribute>
	|-Array.InternalArray__get_Item<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__get_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__get_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__get_Item<Plane>
	|-Array.InternalArray__get_Item<Playable>
	|-Array.InternalArray__get_Item<Progress>
	|-Array.InternalArray__get_Item<QosResult>
	|-Array.InternalArray__get_Item<Quaternion>
	|-Array.InternalArray__get_Item<RangePositionInfo>
	|-Array.InternalArray__get_Item<Rect>
	|-Array.InternalArray__get_Item<RectInt>
	|-Array.InternalArray__get_Item<Rectangle>
	|-Array.InternalArray__get_Item<RenderBuffer>
	|-Array.InternalArray__get_Item<RenderInstancedDataLayout>
	|-Array.InternalArray__get_Item<Resolution>
	|-Array.InternalArray__get_Item<ResourceLocator>
	|-Array.InternalArray__get_Item<RpcLink>
	|-Array.InternalArray__get_Item<RuleMatcher>
	|-Array.InternalArray__get_Item<SamplePointUData>
	|-Array.InternalArray__get_Item<ScalableImage>
	|-Array.InternalArray__get_Item<Scale>
	|-Array.InternalArray__get_Item<SecondarySpriteTexture>
	|-Array.InternalArray__get_Item<SemanticMeaning>
	|-Array.InternalArray__get_Item<ShaderKeyword>
	|-Array.InternalArray__get_Item<SqlDouble>
	|-Array.InternalArray__get_Item<SqlInt64>
	|-Array.InternalArray__get_Item<SqlMoney>
	|-Array.InternalArray__get_Item<SteamItemDetails_t>
	|-Array.InternalArray__get_Item<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__get_Item<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__get_Item<StylePropertyName>
	|-Array.InternalArray__get_Item<StylePropertyValue>
	|-Array.InternalArray__get_Item<StyleValueManaged>
	|-Array.InternalArray__get_Item<Substring>
	|-Array.InternalArray__get_Item<TMP_FontWeightPair>
	|-Array.InternalArray__get_Item<TextProcessingElement>
	|-Array.InternalArray__get_Item<TreeItem>
	|-Array.InternalArray__get_Item<UILineInfo>
	|-Array.InternalArray__get_Item<UnloadedScene>
	|-Array.InternalArray__get_Item<Vector4>
	|-Array.InternalArray__get_Item<VertexAttributeDescriptor>
	|-Array.InternalArray__get_Item<X509ChainStatus>
	|-Array.InternalArray__get_Item<XPathNodeRef>
	|-Array.InternalArray__get_Item<ZipGenericExtraField>
	|-Array.InternalArray__get_Item<double2>
	|-Array.InternalArray__get_Item<float4>
	|-Array.InternalArray__get_Item<int4>
	|-Array.InternalArray__get_Item<quaternion>
	|-Array.InternalArray__get_Item<AdvancedSmooth.Turn>
	|-Array.InternalArray__get_Item<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__get_Item<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__get_Item<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__get_Item<BinaryHeap.Tuple>
	|-Array.InternalArray__get_Item<CameraState.CustomBlendable>
	|-Array.InternalArray__get_Item<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__get_Item<CinemachineTargetGroup.Target>
	|-Array.InternalArray__get_Item<ClipperLib.DoublePoint>
	|-Array.InternalArray__get_Item<ClipperLib.IntPoint>
	|-Array.InternalArray__get_Item<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__get_Item<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__get_Item<DataError.ColumnError>
	|-Array.InternalArray__get_Item<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__get_Item<EventDispatcher.DispatchContext>
	|-Array.InternalArray__get_Item<EventDispatcher.EventRecord>
	|-Array.InternalArray__get_Item<ExpressionParser.ReservedWords>
	|-Array.InternalArray__get_Item<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__get_Item<FocusController.FocusedElement>
	|-Array.InternalArray__get_Item<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__get_Item<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__get_Item<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__get_Item<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__get_Item<InputStateHistory.Record>
	|-Array.InternalArray__get_Item<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__get_Item<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__get_Item<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__get_Item<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__get_Item<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__get_Item<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__get_Item<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__get_Item<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__get_Item<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__get_Item<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__get_Item<PointKDTree.Node>
	|-Array.InternalArray__get_Item<ProbeBrickIndex.Brick>
	|-Array.InternalArray__get_Item<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__get_Item<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__get_Item<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__get_Item<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__get_Item<SVGDocument.NodeWithParent>
	|-Array.InternalArray__get_Item<SendMouseEvents.HitInfo>
	|-Array.InternalArray__get_Item<ServerSocket.ConnectionChange>
	|-Array.InternalArray__get_Item<Socket.WSABUF>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__get_Item<StyleSheet.ImportStruct>
	|-Array.InternalArray__get_Item<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__get_Item<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__get_Item<TargetStateListener.Callback>
	|-Array.InternalArray__get_Item<TextSettings.FontReferenceMap>
	|-Array.InternalArray__get_Item<TextureRegistry.TextureInfo>
	|-Array.InternalArray__get_Item<TransportManager.DisconnectingClient>
	|-Array.InternalArray__get_Item<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__get_Item<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__get_Item<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__get_Item<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__get_Item<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__get_Item<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__get_Item<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__get_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__get_Item<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__get_Item<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__get_Item<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__get_Item<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__get_Item<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__get_Item<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__get_Item<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__get_Item<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	|
	|-RVA: 0xDD1450 Offset: 0xDCFE50 VA: 0x180DD1450
	|-Array.InternalArray__get_Item<SyncList.ChangeData<int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__get_Item<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int2, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__get_Item<HashSet.Slot<bool>>
	|-Array.InternalArray__get_Item<Set.Slot<char>>
	|-Array.InternalArray__get_Item<HashSet.Slot<int>>
	|-Array.InternalArray__get_Item<Set.Slot<int>>
	|-Array.InternalArray__get_Item<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__get_Item<HashSet.Slot<Scene>>
	|-Array.InternalArray__get_Item<HashSet.Slot<uint>>
	|-Array.InternalArray__get_Item<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__get_Item<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__get_Item<BackgroundPosition>
	|-Array.InternalArray__get_Item<DuplicateSamplePoint>
	|-Array.InternalArray__get_Item<Int3>
	|-Array.InternalArray__get_Item<IntRegion>
	|-Array.InternalArray__get_Item<ManipulatorActivationFilter>
	|-Array.InternalArray__get_Item<RuntimeLabel>
	|-Array.InternalArray__get_Item<SqlDateTime>
	|-Array.InternalArray__get_Item<UICharInfo>
	|-Array.InternalArray__get_Item<Vector3>
	|-Array.InternalArray__get_Item<Vector3Int>
	|-Array.InternalArray__get_Item<WordInfo>
	|-Array.InternalArray__get_Item<float3>
	|-Array.InternalArray__get_Item<int3>
	|-Array.InternalArray__get_Item<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__get_Item<AstarDebugger.GraphPoint>
	|-Array.InternalArray__get_Item<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__get_Item<GtkPlus.GdkColor>
	|-Array.InternalArray__get_Item<HIDParser.HIDReportData>
	|-Array.InternalArray__get_Item<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__get_Item<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__get_Item<SyncTimer.ChangeData>
	|-Array.InternalArray__get_Item<X11DesktopColors.GdkColorStruct>
	|
	|-RVA: 0xDD10E0 Offset: 0xDCFAE0 VA: 0x180DD10E0
	|-Array.InternalArray__get_Item<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__get_Item<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, bool>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, short>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, float>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, uint>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, int>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__get_Item<ValueTuple<int, int>>
	|-Array.InternalArray__get_Item<ValueTuple<int, Scene>>
	|-Array.InternalArray__get_Item<AnimatorClipInfo>
	|-Array.InternalArray__get_Item<BackgroundRepeat>
	|-Array.InternalArray__get_Item<CSteamID>
	|-Array.InternalArray__get_Item<CompactVoxelCell>
	|-Array.InternalArray__get_Item<DateTime>
	|-Array.InternalArray__get_Item<DecalEntity>
	|-Array.InternalArray__get_Item<DecalSubDrawCall>
	|-Array.InternalArray__get_Item<Dimension>
	|-Array.InternalArray__get_Item<EventTypeSpec>
	|-Array.InternalArray__get_Item<FullRank>
	|-Array.InternalArray__get_Item<GCHandle>
	|-Array.InternalArray__get_Item<InputActionSetHandle_t>
	|-Array.InternalArray__get_Item<InputEventPtr>
	|-Array.InternalArray__get_Item<InputHandle_t>
	|-Array.InternalArray__get_Item<Int2>
	|-Array.InternalArray__get_Item<long>
	|-Array.InternalArray__get_Item<IntPtr>
	|-Array.InternalArray__get_Item<Length>
	|-Array.InternalArray__get_Item<object>
	|-Array.InternalArray__get_Item<ParameterModifier>
	|-Array.InternalArray__get_Item<Point>
	|-Array.InternalArray__get_Item<Pollfd>
	|-Array.InternalArray__get_Item<PublishedFileId_t>
	|-Array.InternalArray__get_Item<RemoteConnectionEvent>
	|-Array.InternalArray__get_Item<RendererListHandle>
	|-Array.InternalArray__get_Item<ResourceHandle>
	|-Array.InternalArray__get_Item<RpcLinkType>
	|-Array.InternalArray__get_Item<SamplePointsPatch>
	|-Array.InternalArray__get_Item<SqlBinary>
	|-Array.InternalArray__get_Item<SqlGuid>
	|-Array.InternalArray__get_Item<SqlInt32>
	|-Array.InternalArray__get_Item<SqlSingle>
	|-Array.InternalArray__get_Item<SteamItemInstanceID_t>
	|-Array.InternalArray__get_Item<StyleValueHandle>
	|-Array.InternalArray__get_Item<TerrainTileCoord>
	|-Array.InternalArray__get_Item<TextureHandle>
	|-Array.InternalArray__get_Item<TimeSpan>
	|-Array.InternalArray__get_Item<TimeValue>
	|-Array.InternalArray__get_Item<ulong>
	|-Array.InternalArray__get_Item<UsageHint>
	|-Array.InternalArray__get_Item<Vector2Int>
	|-Array.InternalArray__get_Item<int2>
	|-Array.InternalArray__get_Item<jvalue>
	|-Array.InternalArray__get_Item<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__get_Item<BitmapAllocator32.Page>
	|-Array.InternalArray__get_Item<BloomRenderer.Level>
	|-Array.InternalArray__get_Item<CinemachineClearShot.Pair>
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__get_Item<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__get_Item<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__get_Item<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__get_Item<ListView.ItemMatrixLocation>
	|-Array.InternalArray__get_Item<MemoryHelpers.BitRegion>
	|-Array.InternalArray__get_Item<Multipass.TransportIdData>
	|-Array.InternalArray__get_Item<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__get_Item<PlayingCard.CardData>
	|-Array.InternalArray__get_Item<SVGDocument.PostponedClip>
	|-Array.InternalArray__get_Item<SVGDocument.PostponedStopData>
	|-Array.InternalArray__get_Item<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__get_Item<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__get_Item<SyncStopwatch.ChangeData>
	|-Array.InternalArray__get_Item<Syscall._pollfd>
	|-Array.InternalArray__get_Item<WordStorage.Entry>
	|
	|-RVA: 0xDD17D0 Offset: 0xDD01D0 VA: 0x180DD17D0
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__get_Item<ValueTuple<bool>>
	|-Array.InternalArray__get_Item<bool>
	|-Array.InternalArray__get_Item<byte>
	|-Array.InternalArray__get_Item<ByteEnum>
	|-Array.InternalArray__get_Item<sbyte>
	|-Array.InternalArray__get_Item<SByteEnum>
	|-Array.InternalArray__get_Item<SqlBoolean>
	|-Array.InternalArray__get_Item<SVGDocument.ClipData>
	|
	|-RVA: 0xDD1670 Offset: 0xDD0070 VA: 0x180DD1670
	|-Array.InternalArray__get_Item<IntervalTree.Entry<object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, long>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<long, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, double>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, long>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, float>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Guid, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__get_Item<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Playable>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Rect>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__get_Item<KeyValuePair<Rect, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__get_Item<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__get_Item<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__get_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__get_Item<Nullable<Decimal>>
	|-Array.InternalArray__get_Item<TempAllocator.Page<ushort>>
	|-Array.InternalArray__get_Item<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__get_Item<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__get_Item<HashSet.Slot<InternedString>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__get_Item<Set.Slot<object>>
	|-Array.InternalArray__get_Item<TreeViewItemData<object>>
	|-Array.InternalArray__get_Item<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__get_Item<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object>>
	|-Array.InternalArray__get_Item<BezierPathSegment>
	|-Array.InternalArray__get_Item<Bounds>
	|-Array.InternalArray__get_Item<BoundsInt>
	|-Array.InternalArray__get_Item<Color>
	|-Array.InternalArray__get_Item<ComputedTransitionProperty>
	|-Array.InternalArray__get_Item<ContourVertex>
	|-Array.InternalArray__get_Item<ContourVertex>
	|-Array.InternalArray__get_Item<CoordinateProceduralTilePair>
	|-Array.InternalArray__get_Item<FrameTimeSample>
	|-Array.InternalArray__get_Item<InputControlScheme>
	|-Array.InternalArray__get_Item<IntervalTreeNode>
	|-Array.InternalArray__get_Item<JsonPosition>
	|-Array.InternalArray__get_Item<LocalKeyword>
	|-Array.InternalArray__get_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__get_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__get_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__get_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__get_Item<NameAndParameters>
	|-Array.InternalArray__get_Item<NamedValue>
	|-Array.InternalArray__get_Item<Packet>
	|-Array.InternalArray__get_Item<RendererList>
	|-Array.InternalArray__get_Item<RichTextTagAttribute>
	|-Array.InternalArray__get_Item<RichTextTagAttribute>
	|-Array.InternalArray__get_Item<Rotate>
	|-Array.InternalArray__get_Item<SelectorMatchRecord>
	|-Array.InternalArray__get_Item<StyleSelectorPart>
	|-Array.InternalArray__get_Item<StyleSyntaxToken>
	|-Array.InternalArray__get_Item<StyleValue>
	|-Array.InternalArray__get_Item<StyleVariable>
	|-Array.InternalArray__get_Item<TMP_WordInfo>
	|-Array.InternalArray__get_Item<Touch>
	|-Array.InternalArray__get_Item<Translate>
	|-Array.InternalArray__get_Item<TreeViewItemWrapper>
	|-Array.InternalArray__get_Item<UEvent>
	|-Array.InternalArray__get_Item<UStar>
	|-Array.InternalArray__get_Item<XRFeatureDescriptor>
	|-Array.InternalArray__get_Item<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__get_Item<AvatarSettings.LayerSetting>
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__get_Item<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__get_Item<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__get_Item<Hashtable.bucket>
	|-Array.InternalArray__get_Item<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__get_Item<InputControlScheme.SchemeJson>
	|-Array.InternalArray__get_Item<InputRemoting.RemoteSender>
	|-Array.InternalArray__get_Item<LatencySimulator.Message>
	|-Array.InternalArray__get_Item<LiquidVolume.MeshCache>
	|-Array.InternalArray__get_Item<NatPunchModule.RequestEventData>
	|-Array.InternalArray__get_Item<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__get_Item<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__get_Item<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__get_Item<RVOQuadtree.Node>
	|-Array.InternalArray__get_Item<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__get_Item<ReliableChannel.PendingPacket>
	|-Array.InternalArray__get_Item<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__get_Item<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__get_Item<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__get_Item<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__get_Item<StructySync.ChangeData>
	|-Array.InternalArray__get_Item<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__get_Item<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__get_Item<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__get_Item<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__get_Item<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__get_Item<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__get_Item<XmlTextWriter.Namespace>
	|-Array.InternalArray__get_Item<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__get_Item<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__get_Item<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xDD12D0 Offset: 0xDCFCD0 VA: 0x180DD12D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__get_Item<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__get_Item<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__get_Item<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__get_Item<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__get_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__get_Item<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__get_Item<RBTree.Node<int>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__get_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__get_Item<TextProcessingStack<Color32>>
	|-Array.InternalArray__get_Item<TextProcessingStack<int>>
	|-Array.InternalArray__get_Item<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__get_Item<TextProcessingStack<float>>
	|-Array.InternalArray__get_Item<AstarWorkItem>
	|-Array.InternalArray__get_Item<Background>
	|-Array.InternalArray__get_Item<BezierSegment>
	|-Array.InternalArray__get_Item<GradientSettings>
	|-Array.InternalArray__get_Item<IndexRange>
	|-Array.InternalArray__get_Item<Light2DBlendStyle>
	|-Array.InternalArray__get_Item<NativeAddr>
	|-Array.InternalArray__get_Item<NavMeshBuildMarkup>
	|-Array.InternalArray__get_Item<PlayableBinding>
	|-Array.InternalArray__get_Item<SpriteState>
	|-Array.InternalArray__get_Item<SqlString>
	|-Array.InternalArray__get_Item<VoxelContour>
	|-Array.InternalArray__get_Item<XPathNode>
	|-Array.InternalArray__get_Item<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__get_Item<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__get_Item<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__get_Item<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__get_Item<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__get_Item<InputActionMap.ReadMapJson>
	|-Array.InternalArray__get_Item<InputActionMap.WriteMapJson>
	|-Array.InternalArray__get_Item<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__get_Item<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__get_Item<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__get_Item<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__get_Item<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__get_Item<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__get_Item<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__get_Item<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__get_Item<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__get_Item<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__get_Item<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__get_Item<Win32DnD.FORMATETC>
	|-Array.InternalArray__get_Item<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__get_Item<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__get_Item<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__get_Item<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xDD19D0 Offset: 0xDD03D0 VA: 0x180DD19D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__get_Item<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__get_Item<ColorBlock>
	|-Array.InternalArray__get_Item<ComputedStyle>
	|-Array.InternalArray__get_Item<FrameTiming>
	|-Array.InternalArray__get_Item<InputBinding>
	|
	|-RVA: 0xDD1B60 Offset: 0xDD0560 VA: 0x180DD1B60
	|-Array.InternalArray__get_Item<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__get_Item<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__get_Item<RBTree.Node<object>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__get_Item<TextProcessingStack<object>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__get_Item<ContactPairHeader>
	|-Array.InternalArray__get_Item<Label>
	|-Array.InternalArray__get_Item<List>
	|-Array.InternalArray__get_Item<Navigation>
	|-Array.InternalArray__get_Item<PlayerLoopSystem>
	|-Array.InternalArray__get_Item<PlayerLoopSystemInternal>
	|-Array.InternalArray__get_Item<RenderTargetIdentifier>
	|-Array.InternalArray__get_Item<TMP_LinkInfo>
	|-Array.InternalArray__get_Item<TreeInstance>
	|-Array.InternalArray__get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__get_Item<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__get_Item<GrounderQuadruped.Foot>
	|-Array.InternalArray__get_Item<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__get_Item<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__get_Item<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__get_Item<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__get_Item<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__get_Item<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__get_Item<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__get_Item<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__get_Item<XmlEventCache.XmlEvent>
	|-Array.InternalArray__get_Item<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xDD2240 Offset: 0xDD0C40 VA: 0x180DD2240
	|-Array.InternalArray__get_Item<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__get_Item<UHull>
	|-Array.InternalArray__get_Item<HID.HIDElementDescriptor>
	|-Array.InternalArray__get_Item<InputActionMap.ReadActionJson>
	|-Array.InternalArray__get_Item<JsonParser.JsonValue>
	|-Array.InternalArray__get_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0xDD1500 Offset: 0xDCFF00 VA: 0x180DD1500
	|-Array.InternalArray__get_Item<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__get_Item<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__get_Item<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__get_Item<BackgroundSize>
	|-Array.InternalArray__get_Item<GradientColorKey>
	|-Array.InternalArray__get_Item<GradientStop>
	|-Array.InternalArray__get_Item<HighlightState>
	|-Array.InternalArray__get_Item<HighlightState>
	|-Array.InternalArray__get_Item<PageInfo>
	|-Array.InternalArray__get_Item<SqlDecimal>
	|-Array.InternalArray__get_Item<TMP_PageInfo>
	|-Array.InternalArray__get_Item<TemperatureEmitterInfo>
	|-Array.InternalArray__get_Item<TransformOrigin>
	|-Array.InternalArray__get_Item<UEncroachingSegment>
	|-Array.InternalArray__get_Item<CodePointIndexer.TableRange>
	|-Array.InternalArray__get_Item<Cursor.CursorEntry>
	|-Array.InternalArray__get_Item<HeadingTracker.Item>
	|-Array.InternalArray__get_Item<Icon.IconDirEntry>
	|-Array.InternalArray__get_Item<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xDD1CE0 Offset: 0xDD06E0 VA: 0x180DD1CE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__get_Item<ControlPointOption>
	|-Array.InternalArray__get_Item<RaycastHit2D>
	|-Array.InternalArray__get_Item<Funnel.PathPart>
	|-Array.InternalArray__get_Item<LightUtility.LightMeshVertex>
	|-Array.InternalArray__get_Item<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__get_Item<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xDD20C0 Offset: 0xDD0AC0 VA: 0x180DD20C0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__get_Item<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__get_Item<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__get_Item<Keyframe>
	|-Array.InternalArray__get_Item<TextShadow>
	|-Array.InternalArray__get_Item<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__get_Item<BBTree.BBTreeBox>
	|-Array.InternalArray__get_Item<BlitUtility.Vertex>
	|-Array.InternalArray__get_Item<CinemachinePath.Waypoint>
	|-Array.InternalArray__get_Item<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__get_Item<NetworkAnimator.StateChange>
	|-Array.InternalArray__get_Item<SVGDocument.PatternData>
	|-Array.InternalArray__get_Item<ShadowUtility.Edge>
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xDD1FF0 Offset: 0xDD09F0 VA: 0x180DD1FF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__get_Item<VisibleReflectionProbe>
	|
	|-RVA: 0xDD1C20 Offset: 0xDD0620 VA: 0x180DD1C20
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__get_Item<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__get_Item<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__get_Item<ContactPoint>
	|-Array.InternalArray__get_Item<CopyClosingMeshJobData>
	|-Array.InternalArray__get_Item<CustomAttributeNamedArgument>
	|-Array.InternalArray__get_Item<DisplayInfo>
	|-Array.InternalArray__get_Item<IntPoint>
	|-Array.InternalArray__get_Item<LinkInfo>
	|-Array.InternalArray__get_Item<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__get_Item<Rigidbody2DState>
	|-Array.InternalArray__get_Item<Transform3x4>
	|-Array.InternalArray__get_Item<VectorImageVertex>
	|-Array.InternalArray__get_Item<AnimationWarping.Warp>
	|-Array.InternalArray__get_Item<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__get_Item<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__get_Item<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__get_Item<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__get_Item<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__get_Item<InputControlScheme.MatchResult.Match>
	|
	|-RVA: 0xDD1A90 Offset: 0xDD0490 VA: 0x180DD1A90
	|-Array.InternalArray__get_Item<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__get_Item<CombineInstance>
	|-Array.InternalArray__get_Item<ModifiableContactPair>
	|
	|-RVA: 0xDD2180 Offset: 0xDD0B80 VA: 0x180DD2180
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__get_Item<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__get_Item<EnumData>
	|-Array.InternalArray__get_Item<HumanBone>
	|-Array.InternalArray__get_Item<Matrix4x4>
	|-Array.InternalArray__get_Item<Vertex>
	|-Array.InternalArray__get_Item<float4x4>
	|-Array.InternalArray__get_Item<Cursor.CursorImage>
	|-Array.InternalArray__get_Item<InputActionMap.BindingJson>
	|-Array.InternalArray__get_Item<InputManager.AvailableDevice>
	|-Array.InternalArray__get_Item<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__get_Item<LayerGridGraph.HeightSample>
	|-Array.InternalArray__get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xDD2300 Offset: 0xDD0D00 VA: 0x180DD2300
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD15B0 Offset: 0xDCFFB0 VA: 0x180DD15B0
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__get_Item<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__get_Item<ContactPoint2D>
	|-Array.InternalArray__get_Item<InputDeviceDescription>
	|-Array.InternalArray__get_Item<MaterialReference>
	|-Array.InternalArray__get_Item<MaterialReference>
	|-Array.InternalArray__get_Item<SkeletonBone>
	|-Array.InternalArray__get_Item<InputActionMap.WriteActionJson>
	|-Array.InternalArray__get_Item<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__get_Item<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__get_Item<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__get_Item<TextureBlitter.BlitInfo>
	|-Array.InternalArray__get_Item<XmlTextWriter.TagInfo>
	|
	|-RVA: 0xDD25E0 Offset: 0xDD0FE0 VA: 0x180DD25E0
	|-Array.InternalArray__get_Item<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__get_Item<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__get_Item<MeshInfo>
	|-Array.InternalArray__get_Item<RaycastResult>
	|-Array.InternalArray__get_Item<TMP_MeshInfo>
	|-Array.InternalArray__get_Item<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__get_Item<UIRStylePainter.Entry>
	|-Array.InternalArray__get_Item<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xDD23B0 Offset: 0xDD0DB0 VA: 0x180DD23B0
	|-Array.InternalArray__get_Item<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__get_Item<FixedString128Bytes>
	|-Array.InternalArray__get_Item<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xDD1E80 Offset: 0xDD0880 VA: 0x180DD1E80
	|-Array.InternalArray__get_Item<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__get_Item<CullingSplit>
	|-Array.InternalArray__get_Item<LightDataGI>
	|-Array.InternalArray__get_Item<LineInfo>
	|-Array.InternalArray__get_Item<NavMeshBuildSource>
	|-Array.InternalArray__get_Item<TMP_LineInfo>
	|-Array.InternalArray__get_Item<TileData>
	|-Array.InternalArray__get_Item<RenderChain.RenderNodeData>
	|
	|-RVA: 0xDD26A0 Offset: 0xDD10A0 VA: 0x180DD26A0
	|-Array.InternalArray__get_Item<KeyValuePair<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDD1180 Offset: 0xDCFB80 VA: 0x180DD1180
	|-Array.InternalArray__get_Item<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__get_Item<AppId_t>
	|-Array.InternalArray__get_Item<Color32>
	|-Array.InternalArray__get_Item<DepotId_t>
	|-Array.InternalArray__get_Item<EasingFunction>
	|-Array.InternalArray__get_Item<HSteamNetConnection>
	|-Array.InternalArray__get_Item<InclusiveRange>
	|-Array.InternalArray__get_Item<InputUser>
	|-Array.InternalArray__get_Item<int>
	|-Array.InternalArray__get_Item<Int32Enum>
	|-Array.InternalArray__get_Item<LayerMask>
	|-Array.InternalArray__get_Item<Scene>
	|-Array.InternalArray__get_Item<ShaderTagId>
	|-Array.InternalArray__get_Item<SortingLayer>
	|-Array.InternalArray__get_Item<SqlInt16>
	|-Array.InternalArray__get_Item<SteamItemDef_t>
	|-Array.InternalArray__get_Item<TextureId>
	|-Array.InternalArray__get_Item<uint>
	|-Array.InternalArray__get_Item<UInt32Enum>
	|-Array.InternalArray__get_Item<UShort2>
	|-Array.InternalArray__get_Item<HebrewNumber.HebrewValue>
	|-Array.InternalArray__get_Item<RegexCharClass.SingleRange>
	|
	|-RVA: 0xDD2AE0 Offset: 0xDD14E0 VA: 0x180DD2AE0
	|-Array.InternalArray__get_Item<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|
	|-RVA: 0xDD2C60 Offset: 0xDD1660 VA: 0x180DD2C60
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0xDD2DC0 Offset: 0xDD17C0 VA: 0x180DD2DC0
	|-Array.InternalArray__get_Item<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__get_Item<WordWrapState>
	|
	|-RVA: 0xDD1380 Offset: 0xDCFD80 VA: 0x180DD1380
	|-Array.InternalArray__get_Item<AttachmentDescriptor>
	|-Array.InternalArray__get_Item<NudgeJobData>
	|-Array.InternalArray__get_Item<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__get_Item<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__get_Item<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__get_Item<Tilemap.SyncTile>
	|-Array.InternalArray__get_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0xDD1720 Offset: 0xDD0120 VA: 0x180DD1720
	|-Array.InternalArray__get_Item<Board>
	|-Array.InternalArray__get_Item<RendererListResource>
	|
	|-RVA: 0xDD1870 Offset: 0xDD0270 VA: 0x180DD1870
	|-Array.InternalArray__get_Item<CGSpot>
	|-Array.InternalArray__get_Item<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__get_Item<RaycastHit>
	|-Array.InternalArray__get_Item<VolumetricFog.FogOfWarTransition>
	|
	|-RVA: 0xDD1930 Offset: 0xDD0330 VA: 0x180DD1930
	|-Array.InternalArray__get_Item<char>
	|-Array.InternalArray__get_Item<short>
	|-Array.InternalArray__get_Item<SqlByte>
	|-Array.InternalArray__get_Item<ushort>
	|-Array.InternalArray__get_Item<UInt16Enum>
	|-Array.InternalArray__get_Item<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__get_Item<SVGDocument.MaskData>
	|
	|-RVA: 0xDD1DA0 Offset: 0xDD07A0 VA: 0x180DD1DA0
	|-Array.InternalArray__get_Item<ConvertMeshJobData>
	|
	|-RVA: 0xDD1F40 Offset: 0xDD0940 VA: 0x180DD1F40
	|-Array.InternalArray__get_Item<double>
	|
	|-RVA: 0xDD2480 Offset: 0xDD0E80 VA: 0x180DD2480
	|-Array.InternalArray__get_Item<GlyphMarshallingStruct>
	|-Array.InternalArray__get_Item<LayerBatch>
	|-Array.InternalArray__get_Item<UTriangle>
	|
	|-RVA: 0xDD2540 Offset: 0xDD0F40 VA: 0x180DD2540
	|-Array.InternalArray__get_Item<GradientAlphaKey>
	|-Array.InternalArray__get_Item<PointF>
	|-Array.InternalArray__get_Item<Vector2>
	|-Array.InternalArray__get_Item<float2>
	|-Array.InternalArray__get_Item<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__get_Item<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__get_Item<SVGDocument.NodeGlobalSceneState>
	|
	|-RVA: 0xDD2750 Offset: 0xDD1150 VA: 0x180DD2750
	|-Array.InternalArray__get_Item<PointerModel>
	|
	|-RVA: 0xDD2800 Offset: 0xDD1200 VA: 0x180DD2800
	|-Array.InternalArray__get_Item<RenderStateBlock>
	|-Array.InternalArray__get_Item<UIVertex>
	|
	|-RVA: 0xDD28D0 Offset: 0xDD12D0 VA: 0x180DD28D0
	|-Array.InternalArray__get_Item<RigidbodyState>
	|
	|-RVA: 0xDD2990 Offset: 0xDD1390 VA: 0x180DD2990
	|-Array.InternalArray__get_Item<ShadowSliceData>
	|
	|-RVA: 0xDD2A40 Offset: 0xDD1440 VA: 0x180DD2A40
	|-Array.InternalArray__get_Item<float>
	|
	|-RVA: 0xDD2BB0 Offset: 0xDD15B0 VA: 0x180DD2BB0
	|-Array.InternalArray__get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0xDD2D10 Offset: 0xDD1710 VA: 0x180DD2D10
	|-Array.InternalArray__get_Item<TextElementInfo>
	|
	|-RVA: 0xDD2E70 Offset: 0xDD1870 VA: 0x180DD2E70
	|-Array.InternalArray__get_Item<Touch>
	|
	|-RVA: 0xDD3720 Offset: 0xDD2120 VA: 0x180DD3720
	|-Array.InternalArray__get_Item<VisibleLight>
	|
	|-RVA: 0xDD37F0 Offset: 0xDD21F0 VA: 0x180DD37F0
	|-Array.InternalArray__get_Item<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xDD38A0 Offset: 0xDD22A0 VA: 0x180DD38A0
	|-Array.InternalArray__get_Item<WordWrapState>
	|
	|-RVA: 0xDD3950 Offset: 0xDD2350 VA: 0x180DD3950
	|-Array.InternalArray__get_Item<XEvent>
	|
	|-RVA: 0xDD3A00 Offset: 0xDD2400 VA: 0x180DD3A00
	|-Array.InternalArray__get_Item<XRView>
	|
	|-RVA: 0xDD33A0 Offset: 0xDD1DA0 VA: 0x180DD33A0
	|-Array.InternalArray__get_Item<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDD3650 Offset: 0xDD2050 VA: 0x180DD3650
	|-Array.InternalArray__get_Item<Agent.VO>
	|
	|-RVA: 0xDD3090 Offset: 0xDD1A90 VA: 0x180DD3090
	|-Array.InternalArray__get_Item<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xDD3140 Offset: 0xDD1B40 VA: 0x180DD3140
	|-Array.InternalArray__get_Item<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xDD3240 Offset: 0xDD1C40 VA: 0x180DD3240
	|-Array.InternalArray__get_Item<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xDD32F0 Offset: 0xDD1CF0 VA: 0x180DD32F0
	|-Array.InternalArray__get_Item<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xDD2FE0 Offset: 0xDD19E0 VA: 0x180DD2FE0
	|-Array.InternalArray__get_Item<InputControlLayout.ControlItem>
	|
	|-RVA: 0xDD2F30 Offset: 0xDD1930 VA: 0x180DD2F30
	|-Array.InternalArray__get_Item<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xDD35A0 Offset: 0xDD1FA0 VA: 0x180DD35A0
	|-Array.InternalArray__get_Item<InputUser.UserData>
	|
	|-RVA: 0xDD34E0 Offset: 0xDD1EE0 VA: 0x180DD34E0
	|-Array.InternalArray__get_Item<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__set_Item<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE8C20 Offset: 0xDE7620 VA: 0x180DE8C20
	|-Array.InternalArray__set_Item<ArraySegment<byte>>
	|-Array.InternalArray__set_Item<SyncList.CachedOnChange<int>>
	|-Array.InternalArray__set_Item<XHashtable.XHashtableState.Entry<object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<HSteamNetConnection, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, bool>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, ByteEnum>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, HSteamNetConnection>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, short>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Int32Enum>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, float>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, uint>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, bool>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<FullRank, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int2, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int3, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Int3>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, long>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, ulong>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Vector3>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<long, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<IntPtr, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, bool>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, char>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Color32>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, double>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Int32Enum>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, long>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, float>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, TextureId>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, SVGDocument.ClipData>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, SVGDocument.MaskData>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__set_Item<KeyValuePair<PropertyName, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Scene, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<TerrainTileCoord, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<ushort, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Vector2Int, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__set_Item<KeyValue<int, int>>
	|-Array.InternalArray__set_Item<NativeArray<ConvertMeshJobData>>
	|-Array.InternalArray__set_Item<NativeArray<CopyClosingMeshJobData>>
	|-Array.InternalArray__set_Item<NativeArray<NudgeJobData>>
	|-Array.InternalArray__set_Item<NativeSlice<ConvertMeshJobData>>
	|-Array.InternalArray__set_Item<NativeSlice<CopyClosingMeshJobData>>
	|-Array.InternalArray__set_Item<NativeSlice<NudgeJobData>>
	|-Array.InternalArray__set_Item<Nullable<DateTime>>
	|-Array.InternalArray__set_Item<InputStateHistory.Record<TouchState>>
	|-Array.InternalArray__set_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|-Array.InternalArray__set_Item<HashSet.Slot<object>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<object>>
	|-Array.InternalArray__set_Item<HashSet.Slot<ulong>>
	|-Array.InternalArray__set_Item<HashSet.Slot<Vector2Int>>
	|-Array.InternalArray__set_Item<StructMultiKey<object, object>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<int>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<float>>
	|-Array.InternalArray__set_Item<SubArray<int>>
	|-Array.InternalArray__set_Item<ValueTuple<int, object>>
	|-Array.InternalArray__set_Item<ValueTuple<Int32Enum, object>>
	|-Array.InternalArray__set_Item<ValueTuple<IntPtr, object>>
	|-Array.InternalArray__set_Item<ValueTuple<object, int>>
	|-Array.InternalArray__set_Item<ValueTuple<object, object>>
	|-Array.InternalArray__set_Item<AsyncGPUReadbackRequest>
	|-Array.InternalArray__set_Item<BezierContour>
	|-Array.InternalArray__set_Item<BigInteger>
	|-Array.InternalArray__set_Item<BoundingSphere>
	|-Array.InternalArray__set_Item<Color>
	|-Array.InternalArray__set_Item<CompactVoxelSpan>
	|-Array.InternalArray__set_Item<Connection>
	|-Array.InternalArray__set_Item<CoordinateFootprintTilePair>
	|-Array.InternalArray__set_Item<CoordinateStorageFootprintTilePair>
	|-Array.InternalArray__set_Item<CoordinateStorageTilePair>
	|-Array.InternalArray__set_Item<CoordinateTilePair>
	|-Array.InternalArray__set_Item<CustomAttributeTypedArgument>
	|-Array.InternalArray__set_Item<DateTimeOffset>
	|-Array.InternalArray__set_Item<Decimal>
	|-Array.InternalArray__set_Item<DictionaryEntry>
	|-Array.InternalArray__set_Item<DoublePoint>
	|-Array.InternalArray__set_Item<DoublePoint>
	|-Array.InternalArray__set_Item<DrawBufferRange>
	|-Array.InternalArray__set_Item<DualPrefab>
	|-Array.InternalArray__set_Item<Entry>
	|-Array.InternalArray__set_Item<Ephemeron>
	|-Array.InternalArray__set_Item<EventSummary>
	|-Array.InternalArray__set_Item<ExtensionFilter>
	|-Array.InternalArray__set_Item<FontDefinition>
	|-Array.InternalArray__set_Item<FontWeightPair>
	|-Array.InternalArray__set_Item<GfxUpdateBufferRange>
	|-Array.InternalArray__set_Item<GlyphRect>
	|-Array.InternalArray__set_Item<Guid>
	|-Array.InternalArray__set_Item<Hash128>
	|-Array.InternalArray__set_Item<HeaderVariantInfo>
	|-Array.InternalArray__set_Item<IndexField>
	|-Array.InternalArray__set_Item<IntPoint>
	|-Array.InternalArray__set_Item<IntRect>
	|-Array.InternalArray__set_Item<InternalCodePageDataItem>
	|-Array.InternalArray__set_Item<InternalEncodingDataItem>
	|-Array.InternalArray__set_Item<InternedString>
	|-Array.InternalArray__set_Item<InterpretedFrameInfo>
	|-Array.InternalArray__set_Item<JobHandle>
	|-Array.InternalArray__set_Item<KeyStruct>
	|-Array.InternalArray__set_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__set_Item<LigatureSubstitutionRecord>
	|-Array.InternalArray__set_Item<LinkedVoxelSpan>
	|-Array.InternalArray__set_Item<LocalDefinition>
	|-Array.InternalArray__set_Item<LocalPacket>
	|-Array.InternalArray__set_Item<LocalPacket>
	|-Array.InternalArray__set_Item<MarkupAttribute>
	|-Array.InternalArray__set_Item<MatchMakingKeyValuePair_t>
	|-Array.InternalArray__set_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__set_Item<MultipleSubstitutionRecord>
	|-Array.InternalArray__set_Item<Plane>
	|-Array.InternalArray__set_Item<Playable>
	|-Array.InternalArray__set_Item<Progress>
	|-Array.InternalArray__set_Item<QosResult>
	|-Array.InternalArray__set_Item<Quaternion>
	|-Array.InternalArray__set_Item<RangePositionInfo>
	|-Array.InternalArray__set_Item<Rect>
	|-Array.InternalArray__set_Item<RectInt>
	|-Array.InternalArray__set_Item<Rectangle>
	|-Array.InternalArray__set_Item<RenderBuffer>
	|-Array.InternalArray__set_Item<RenderInstancedDataLayout>
	|-Array.InternalArray__set_Item<Resolution>
	|-Array.InternalArray__set_Item<ResourceLocator>
	|-Array.InternalArray__set_Item<RpcLink>
	|-Array.InternalArray__set_Item<RuleMatcher>
	|-Array.InternalArray__set_Item<SamplePointUData>
	|-Array.InternalArray__set_Item<ScalableImage>
	|-Array.InternalArray__set_Item<Scale>
	|-Array.InternalArray__set_Item<SecondarySpriteTexture>
	|-Array.InternalArray__set_Item<SemanticMeaning>
	|-Array.InternalArray__set_Item<ShaderKeyword>
	|-Array.InternalArray__set_Item<SqlDouble>
	|-Array.InternalArray__set_Item<SqlInt64>
	|-Array.InternalArray__set_Item<SqlMoney>
	|-Array.InternalArray__set_Item<SteamItemDetails_t>
	|-Array.InternalArray__set_Item<SteamNetworkingConfigValue_t>
	|-Array.InternalArray__set_Item<SteamPartyBeaconLocation_t>
	|-Array.InternalArray__set_Item<StylePropertyName>
	|-Array.InternalArray__set_Item<StylePropertyValue>
	|-Array.InternalArray__set_Item<StyleValueManaged>
	|-Array.InternalArray__set_Item<Substring>
	|-Array.InternalArray__set_Item<TMP_FontWeightPair>
	|-Array.InternalArray__set_Item<TextProcessingElement>
	|-Array.InternalArray__set_Item<TreeItem>
	|-Array.InternalArray__set_Item<UILineInfo>
	|-Array.InternalArray__set_Item<UnloadedScene>
	|-Array.InternalArray__set_Item<Vector4>
	|-Array.InternalArray__set_Item<VertexAttributeDescriptor>
	|-Array.InternalArray__set_Item<X509ChainStatus>
	|-Array.InternalArray__set_Item<XPathNodeRef>
	|-Array.InternalArray__set_Item<ZipGenericExtraField>
	|-Array.InternalArray__set_Item<double2>
	|-Array.InternalArray__set_Item<float4>
	|-Array.InternalArray__set_Item<int4>
	|-Array.InternalArray__set_Item<quaternion>
	|-Array.InternalArray__set_Item<AdvancedSmooth.Turn>
	|-Array.InternalArray__set_Item<AntialiasingModel.FxaaConsoleSettings>
	|-Array.InternalArray__set_Item<AttributeCollection.AttributeEntry>
	|-Array.InternalArray__set_Item<BeforeRenderHelper.OrderBlock>
	|-Array.InternalArray__set_Item<BinaryHeap.Tuple>
	|-Array.InternalArray__set_Item<CameraState.CustomBlendable>
	|-Array.InternalArray__set_Item<CinemachineSmoothPath.Waypoint>
	|-Array.InternalArray__set_Item<CinemachineTargetGroup.Target>
	|-Array.InternalArray__set_Item<ClipperLib.DoublePoint>
	|-Array.InternalArray__set_Item<ClipperLib.IntPoint>
	|-Array.InternalArray__set_Item<ConfinerOven.PolygonSolution>
	|-Array.InternalArray__set_Item<CookieTokenizer.RecognizedAttribute>
	|-Array.InternalArray__set_Item<DataError.ColumnError>
	|-Array.InternalArray__set_Item<DynamicResolutionHandler.ScalerContainer>
	|-Array.InternalArray__set_Item<EventDispatcher.DispatchContext>
	|-Array.InternalArray__set_Item<EventDispatcher.EventRecord>
	|-Array.InternalArray__set_Item<ExpressionParser.ReservedWords>
	|-Array.InternalArray__set_Item<FinalBlitPass.BlitMaterialData>
	|-Array.InternalArray__set_Item<FocusController.FocusedElement>
	|-Array.InternalArray__set_Item<HeatmapManager.PropertyRegionReference>
	|-Array.InternalArray__set_Item<InputActionTrace.ActionEventPtr>
	|-Array.InternalArray__set_Item<InputBindingCompositeContext.PartBinding>
	|-Array.InternalArray__set_Item<InputControlScheme.DeviceRequirement>
	|-Array.InternalArray__set_Item<InputStateHistory.Record>
	|-Array.InternalArray__set_Item<InputTransformSpots.TransformSpot>
	|-Array.InternalArray__set_Item<InputUser.OngoingAccountSelection>
	|-Array.InternalArray__set_Item<LightCookieManager.LightCookieMapping>
	|-Array.InternalArray__set_Item<MultiColumnCollectionHeader.SortedColumnState>
	|-Array.InternalArray__set_Item<NativeMethods.COMDLG_FILTERSPEC>
	|-Array.InternalArray__set_Item<NativeMethods.TASKDIALOG_BUTTON>
	|-Array.InternalArray__set_Item<NetworkAnimator.ReceivedServerData>
	|-Array.InternalArray__set_Item<NetworkBehaviour.BufferedRpc>
	|-Array.InternalArray__set_Item<OutlineEffect.OutlineTargetGroup>
	|-Array.InternalArray__set_Item<ParameterizedStrings.FormatParam>
	|-Array.InternalArray__set_Item<PointKDTree.Node>
	|-Array.InternalArray__set_Item<ProbeBrickIndex.Brick>
	|-Array.InternalArray__set_Item<ProbeVolumeAsset.CellCounts>
	|-Array.InternalArray__set_Item<ProbeVolumeSceneData.SerializableHasPVItem>
	|-Array.InternalArray__set_Item<ProbeVolumeSceneData.SerializablePVProfile>
	|-Array.InternalArray__set_Item<RigidbodyPrediction.MoveData>
	|-Array.InternalArray__set_Item<SVGDocument.NodeWithParent>
	|-Array.InternalArray__set_Item<SendMouseEvents.HitInfo>
	|-Array.InternalArray__set_Item<ServerSocket.ConnectionChange>
	|-Array.InternalArray__set_Item<Socket.WSABUF>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.ElementPropertyPair>
	|-Array.InternalArray__set_Item<StyleSheet.ImportStruct>
	|-Array.InternalArray__set_Item<StyleVariableResolver.ResolveContext>
	|-Array.InternalArray__set_Item<TMP_Text.TextProcessingElement>
	|-Array.InternalArray__set_Item<TargetStateListener.Callback>
	|-Array.InternalArray__set_Item<TextSettings.FontReferenceMap>
	|-Array.InternalArray__set_Item<TextureRegistry.TextureInfo>
	|-Array.InternalArray__set_Item<TransportManager.DisconnectingClient>
	|-Array.InternalArray__set_Item<TutorialTimeController.KeyFrame>
	|-Array.InternalArray__set_Item<UIRenderDevice.DeviceToFree>
	|-Array.InternalArray__set_Item<UmAlQuraCalendar.DateMapping>
	|-Array.InternalArray__set_Item<VisualTreeAsset.SlotDefinition>
	|-Array.InternalArray__set_Item<VisualTreeAsset.SlotUsageEntry>
	|-Array.InternalArray__set_Item<VisualTreeAsset.UxmlObjectEntry>
	|-Array.InternalArray__set_Item<XmlNodeReaderNavigator.VirtualAttribute>
	|-Array.InternalArray__set_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Array.InternalArray__set_Item<BindingRestrictions.TestBuilder.AndNode>
	|-Array.InternalArray__set_Item<DebugUI.Foldout.ContextMenuItem>
	|-Array.InternalArray__set_Item<Decimal.DecCalc.PowerOvfl>
	|-Array.InternalArray__set_Item<FacetsChecker.FacetsCompiler.Map>
	|-Array.InternalArray__set_Item<InputControlLayout.Collection.PrecompiledLayout>
	|-Array.InternalArray__set_Item<InputControlScheme.SchemeJson.DeviceJson>
	|-Array.InternalArray__set_Item<InputDeviceMatcher.MatcherJson.Capability>
	|-Array.InternalArray__set_Item<VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData>
	|
	|-RVA: 0xDE8D60 Offset: 0xDE7760 VA: 0x180DE8D60
	|-Array.InternalArray__set_Item<SyncList.ChangeData<int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ushort, ushort>>
	|-Array.InternalArray__set_Item<KeyValuePair<CSteamID, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int2, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, CSteamID>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Vector2Int>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Multipass.TransportIdData>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, RpcLinkType>>
	|-Array.InternalArray__set_Item<HashSet.Slot<bool>>
	|-Array.InternalArray__set_Item<Set.Slot<char>>
	|-Array.InternalArray__set_Item<HashSet.Slot<int>>
	|-Array.InternalArray__set_Item<Set.Slot<int>>
	|-Array.InternalArray__set_Item<HashSet.Slot<Int32Enum>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<RemoteConnectionEvent>>
	|-Array.InternalArray__set_Item<HashSet.Slot<Scene>>
	|-Array.InternalArray__set_Item<HashSet.Slot<uint>>
	|-Array.InternalArray__set_Item<HashSet.Slot<UInt32Enum>>
	|-Array.InternalArray__set_Item<ValueTuple<int, Vector2Int>>
	|-Array.InternalArray__set_Item<BackgroundPosition>
	|-Array.InternalArray__set_Item<DuplicateSamplePoint>
	|-Array.InternalArray__set_Item<Int3>
	|-Array.InternalArray__set_Item<IntRegion>
	|-Array.InternalArray__set_Item<ManipulatorActivationFilter>
	|-Array.InternalArray__set_Item<RuntimeLabel>
	|-Array.InternalArray__set_Item<SqlDateTime>
	|-Array.InternalArray__set_Item<UICharInfo>
	|-Array.InternalArray__set_Item<Vector3>
	|-Array.InternalArray__set_Item<Vector3Int>
	|-Array.InternalArray__set_Item<WordInfo>
	|-Array.InternalArray__set_Item<float3>
	|-Array.InternalArray__set_Item<int3>
	|-Array.InternalArray__set_Item<AntialiasingModel.FxaaQualitySettings>
	|-Array.InternalArray__set_Item<AstarDebugger.GraphPoint>
	|-Array.InternalArray__set_Item<DecalEntityIndexer.DecalEntityItem>
	|-Array.InternalArray__set_Item<GtkPlus.GdkColor>
	|-Array.InternalArray__set_Item<HIDParser.HIDReportData>
	|-Array.InternalArray__set_Item<ProbeBrickPool.BrickChunkAlloc>
	|-Array.InternalArray__set_Item<RegexCharClass.LowerCaseMapping>
	|-Array.InternalArray__set_Item<SyncTimer.ChangeData>
	|-Array.InternalArray__set_Item<X11DesktopColors.GdkColorStruct>
	|
	|-RVA: 0xDE8EB0 Offset: 0xDE78B0 VA: 0x180DE8EB0
	|-Array.InternalArray__set_Item<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-Array.InternalArray__set_Item<KeyValuePair<HSteamNetConnection, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, bool>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, ByteEnum>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, HSteamNetConnection>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, short>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Int32Enum>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, float>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, uint>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, bool>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, int>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<ByteEnum>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<int>>
	|-Array.InternalArray__set_Item<ValueTuple<int, int>>
	|-Array.InternalArray__set_Item<ValueTuple<int, Scene>>
	|-Array.InternalArray__set_Item<AnimatorClipInfo>
	|-Array.InternalArray__set_Item<BackgroundRepeat>
	|-Array.InternalArray__set_Item<CSteamID>
	|-Array.InternalArray__set_Item<CompactVoxelCell>
	|-Array.InternalArray__set_Item<DateTime>
	|-Array.InternalArray__set_Item<DecalEntity>
	|-Array.InternalArray__set_Item<DecalSubDrawCall>
	|-Array.InternalArray__set_Item<Dimension>
	|-Array.InternalArray__set_Item<EventTypeSpec>
	|-Array.InternalArray__set_Item<FullRank>
	|-Array.InternalArray__set_Item<GCHandle>
	|-Array.InternalArray__set_Item<InputActionSetHandle_t>
	|-Array.InternalArray__set_Item<InputEventPtr>
	|-Array.InternalArray__set_Item<InputHandle_t>
	|-Array.InternalArray__set_Item<Int2>
	|-Array.InternalArray__set_Item<long>
	|-Array.InternalArray__set_Item<IntPtr>
	|-Array.InternalArray__set_Item<Length>
	|-Array.InternalArray__set_Item<ParameterModifier>
	|-Array.InternalArray__set_Item<Point>
	|-Array.InternalArray__set_Item<Pollfd>
	|-Array.InternalArray__set_Item<PublishedFileId_t>
	|-Array.InternalArray__set_Item<RemoteConnectionEvent>
	|-Array.InternalArray__set_Item<RendererListHandle>
	|-Array.InternalArray__set_Item<ResourceHandle>
	|-Array.InternalArray__set_Item<RpcLinkType>
	|-Array.InternalArray__set_Item<SamplePointsPatch>
	|-Array.InternalArray__set_Item<SqlBinary>
	|-Array.InternalArray__set_Item<SqlGuid>
	|-Array.InternalArray__set_Item<SqlInt32>
	|-Array.InternalArray__set_Item<SqlSingle>
	|-Array.InternalArray__set_Item<SteamItemInstanceID_t>
	|-Array.InternalArray__set_Item<StyleValueHandle>
	|-Array.InternalArray__set_Item<TerrainTileCoord>
	|-Array.InternalArray__set_Item<TextureHandle>
	|-Array.InternalArray__set_Item<TimeSpan>
	|-Array.InternalArray__set_Item<TimeValue>
	|-Array.InternalArray__set_Item<ulong>
	|-Array.InternalArray__set_Item<UsageHint>
	|-Array.InternalArray__set_Item<Vector2Int>
	|-Array.InternalArray__set_Item<int2>
	|-Array.InternalArray__set_Item<jvalue>
	|-Array.InternalArray__set_Item<BaseStyleMatcher.MatchContext>
	|-Array.InternalArray__set_Item<BitmapAllocator32.Page>
	|-Array.InternalArray__set_Item<BloomRenderer.Level>
	|-Array.InternalArray__set_Item<CinemachineClearShot.Pair>
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.HashPair>
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.ParentHash>
	|-Array.InternalArray__set_Item<EventInterestReflectionUtils.DefaultEventInterests>
	|-Array.InternalArray__set_Item<HIDSupport.HIDPageUsage>
	|-Array.InternalArray__set_Item<InputSystemUIInputModule.InputActionReferenceState>
	|-Array.InternalArray__set_Item<ListView.ItemMatrixLocation>
	|-Array.InternalArray__set_Item<MemoryHelpers.BitRegion>
	|-Array.InternalArray__set_Item<Multipass.TransportIdData>
	|-Array.InternalArray__set_Item<ObjectPool.DelayedStoreData>
	|-Array.InternalArray__set_Item<PlayingCard.CardData>
	|-Array.InternalArray__set_Item<SVGDocument.PostponedClip>
	|-Array.InternalArray__set_Item<SVGDocument.PostponedStopData>
	|-Array.InternalArray__set_Item<StyleComplexSelector.PseudoStateData>
	|-Array.InternalArray__set_Item<StyleSheetCache.SheetHandleKey>
	|-Array.InternalArray__set_Item<SyncStopwatch.ChangeData>
	|-Array.InternalArray__set_Item<Syscall._pollfd>
	|-Array.InternalArray__set_Item<WordStorage.Entry>
	|
	|-RVA: 0xDE8FF0 Offset: 0xDE79F0 VA: 0x180DE8FF0
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Background>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Color>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<int>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Length>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<object>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Rotate>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Scale>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<float>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.EmptyData<Translate>>
	|-Array.InternalArray__set_Item<ValueTuple<bool>>
	|-Array.InternalArray__set_Item<bool>
	|-Array.InternalArray__set_Item<byte>
	|-Array.InternalArray__set_Item<ByteEnum>
	|-Array.InternalArray__set_Item<sbyte>
	|-Array.InternalArray__set_Item<SByteEnum>
	|-Array.InternalArray__set_Item<SqlBoolean>
	|-Array.InternalArray__set_Item<SVGDocument.ClipData>
	|
	|-RVA: 0xDE9B20 Offset: 0xDE8520 VA: 0x180DE9B20
	|-Array.InternalArray__set_Item<IntervalTree.Entry<object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<FullRank, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int2, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int3, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Int3>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, long>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, ulong>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Vector3>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<long, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<IntPtr, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, bool>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Color32>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, double>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Int32Enum>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, long>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, float>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, TextureId>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, EventInterestReflectionUtils.DefaultEventInterests>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, InputSystemUIInputModule.InputActionReferenceState>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ObjectPool.DelayedStoreData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, SVGDocument.ClipData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, SVGDocument.MaskData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, SVGDocument.NodeGlobalSceneState>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, StyleComplexSelector.PseudoStateData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Scene, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<TerrainTileCoord, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ushort, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector2Int, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<StyleSheetCache.SheetHandleKey, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<ValueTuple<object, object>, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Guid, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<Hash128, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<Hash128, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, ValueTuple<object, int>>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, TreeItem>>
	|-Array.InternalArray__set_Item<KeyValuePair<InternedString, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Playable>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Rect>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, ResourceLocator>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, StylePropertyValue>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, XPathNodeRef>>
	|-Array.InternalArray__set_Item<KeyValuePair<Rect, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__set_Item<KeyValuePair<Vector3, Vector3>>
	|-Array.InternalArray__set_Item<KeyValuePair<Vector3Int, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__set_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__set_Item<KeyValuePair<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__set_Item<Nullable<Decimal>>
	|-Array.InternalArray__set_Item<TempAllocator.Page<ushort>>
	|-Array.InternalArray__set_Item<TempAllocator.Page<Vertex>>
	|-Array.InternalArray__set_Item<HashSet.Slot<ValueTuple<int, object>>>
	|-Array.InternalArray__set_Item<HashSet.Slot<InternedString>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<LocalPacket>>
	|-Array.InternalArray__set_Item<Set.Slot<object>>
	|-Array.InternalArray__set_Item<TreeViewItemData<object>>
	|-Array.InternalArray__set_Item<ValueTuple<object, ValueTuple<object, int>>>
	|-Array.InternalArray__set_Item<ValueTuple<Vector4, Vector2Int>>
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object>>
	|-Array.InternalArray__set_Item<BezierPathSegment>
	|-Array.InternalArray__set_Item<Bounds>
	|-Array.InternalArray__set_Item<BoundsInt>
	|-Array.InternalArray__set_Item<Color>
	|-Array.InternalArray__set_Item<ComputedTransitionProperty>
	|-Array.InternalArray__set_Item<ContourVertex>
	|-Array.InternalArray__set_Item<ContourVertex>
	|-Array.InternalArray__set_Item<CoordinateProceduralTilePair>
	|-Array.InternalArray__set_Item<FrameTimeSample>
	|-Array.InternalArray__set_Item<InputControlScheme>
	|-Array.InternalArray__set_Item<IntervalTreeNode>
	|-Array.InternalArray__set_Item<JsonPosition>
	|-Array.InternalArray__set_Item<LocalKeyword>
	|-Array.InternalArray__set_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__set_Item<MarkToBaseAdjustmentRecord>
	|-Array.InternalArray__set_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__set_Item<MarkToMarkAdjustmentRecord>
	|-Array.InternalArray__set_Item<NameAndParameters>
	|-Array.InternalArray__set_Item<NamedValue>
	|-Array.InternalArray__set_Item<Packet>
	|-Array.InternalArray__set_Item<RendererList>
	|-Array.InternalArray__set_Item<RichTextTagAttribute>
	|-Array.InternalArray__set_Item<RichTextTagAttribute>
	|-Array.InternalArray__set_Item<Rotate>
	|-Array.InternalArray__set_Item<SelectorMatchRecord>
	|-Array.InternalArray__set_Item<StyleSelectorPart>
	|-Array.InternalArray__set_Item<StyleSyntaxToken>
	|-Array.InternalArray__set_Item<StyleValue>
	|-Array.InternalArray__set_Item<StyleVariable>
	|-Array.InternalArray__set_Item<TMP_WordInfo>
	|-Array.InternalArray__set_Item<Touch>
	|-Array.InternalArray__set_Item<Translate>
	|-Array.InternalArray__set_Item<TreeViewItemWrapper>
	|-Array.InternalArray__set_Item<UEvent>
	|-Array.InternalArray__set_Item<UStar>
	|-Array.InternalArray__set_Item<XRFeatureDescriptor>
	|-Array.InternalArray__set_Item<AstarDebugger.PathTypeDebug>
	|-Array.InternalArray__set_Item<AvatarSettings.LayerSetting>
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.Instruction>
	|-Array.InternalArray__set_Item<GraphUpdateProcessor.GUOSingle>
	|-Array.InternalArray__set_Item<HID.HIDCollectionDescriptor>
	|-Array.InternalArray__set_Item<Hashtable.bucket>
	|-Array.InternalArray__set_Item<InputActionRebindingExtensions.Parameter>
	|-Array.InternalArray__set_Item<InputControlScheme.SchemeJson>
	|-Array.InternalArray__set_Item<InputRemoting.RemoteSender>
	|-Array.InternalArray__set_Item<LatencySimulator.Message>
	|-Array.InternalArray__set_Item<LiquidVolume.MeshCache>
	|-Array.InternalArray__set_Item<NatPunchModule.RequestEventData>
	|-Array.InternalArray__set_Item<NatPunchModule.SuccessEventData>
	|-Array.InternalArray__set_Item<PointerDeviceState.PointerLocation>
	|-Array.InternalArray__set_Item<ProbeVolumePerSceneData.PerScenarioData>
	|-Array.InternalArray__set_Item<RVOQuadtree.Node>
	|-Array.InternalArray__set_Item<Regex.CachedCodeEntryKey>
	|-Array.InternalArray__set_Item<ReliableChannel.PendingPacket>
	|-Array.InternalArray__set_Item<RenderGraph.CompiledResourceInfo>
	|-Array.InternalArray__set_Item<RetainedGizmos.MeshWithHash>
	|-Array.InternalArray__set_Item<SVGDocument.HierarchyUpdate>
	|-Array.InternalArray__set_Item<SteamDatagramRelayAuthTicket.ExtraField>
	|-Array.InternalArray__set_Item<StructySync.ChangeData>
	|-Array.InternalArray__set_Item<TemplateAsset.AttributeOverride>
	|-Array.InternalArray__set_Item<TimeNotificationBehaviour.NotificationEntry>
	|-Array.InternalArray__set_Item<UnitySynchronizationContext.WorkRequest>
	|-Array.InternalArray__set_Item<VisualTreeAsset.UsingEntry>
	|-Array.InternalArray__set_Item<XmlNamespaceManager.NamespaceDeclaration>
	|-Array.InternalArray__set_Item<XmlSqlBinaryReader.QName>
	|-Array.InternalArray__set_Item<XmlTextWriter.Namespace>
	|-Array.InternalArray__set_Item<XmlWellFormedWriter.Namespace>
	|-Array.InternalArray__set_Item<BeautifyRendererFeature.BeautifyRenderPass.BloomMipData>
	|-Array.InternalArray__set_Item<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xDE9570 Offset: 0xDE7F70 VA: 0x180DE9570
	|-Array.InternalArray__set_Item<Dictionary.Entry<KeyValuePair<object, object>, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<StructMultiKey<object, object>, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ValueTuple<object, object>, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Guid, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Hash128, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Hash128, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, TreeItem>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<InternedString, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, KeyValuePair<Int32Enum, object>>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Playable>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Rect>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ResourceLocator>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, StylePropertyValue>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, XPathNodeRef>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, NetworkBehaviour.BufferedRpc>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector3, Vector3>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector3Int, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, Int32Enum>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<StylePropertyAnimationSystem.ElementPropertyPair, object>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Rect, object, float>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<RectInt, object, int>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Vector2, object, float>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Vector2Int, object, int>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Vector3, object, float>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Vector3Int, object, int>>
	|-Array.InternalArray__set_Item<BaseCompositeField.FieldDescription<Vector4, object, float>>
	|-Array.InternalArray__set_Item<KeyValuePair<Bounds, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, TreeViewItemData<object>>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__set_Item<KeyValuePair<InternedString, InternedString>>
	|-Array.InternalArray__set_Item<KeyValuePair<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Bounds>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, Color>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__set_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__set_Item<KeyValuePair<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__set_Item<RBTree.Node<int>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<Packet>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.RequestEventData>>
	|-Array.InternalArray__set_Item<ConcurrentQueue.Segment.Slot<NatPunchModule.SuccessEventData>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Length>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<object>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<Color32>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<int>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<float>>
	|-Array.InternalArray__set_Item<TextProcessingStack<Color32>>
	|-Array.InternalArray__set_Item<TextProcessingStack<int>>
	|-Array.InternalArray__set_Item<TextProcessingStack<Int32Enum>>
	|-Array.InternalArray__set_Item<TextProcessingStack<float>>
	|-Array.InternalArray__set_Item<AstarWorkItem>
	|-Array.InternalArray__set_Item<Background>
	|-Array.InternalArray__set_Item<BezierSegment>
	|-Array.InternalArray__set_Item<GradientSettings>
	|-Array.InternalArray__set_Item<IndexRange>
	|-Array.InternalArray__set_Item<Light2DBlendStyle>
	|-Array.InternalArray__set_Item<NativeAddr>
	|-Array.InternalArray__set_Item<NavMeshBuildMarkup>
	|-Array.InternalArray__set_Item<PlayableBinding>
	|-Array.InternalArray__set_Item<SpriteState>
	|-Array.InternalArray__set_Item<SqlString>
	|-Array.InternalArray__set_Item<VoxelContour>
	|-Array.InternalArray__set_Item<XPathNode>
	|-Array.InternalArray__set_Item<AtlasAllocatorDynamic.AtlasNode>
	|-Array.InternalArray__set_Item<CinemachineBlendListCamera.Instruction>
	|-Array.InternalArray__set_Item<CinemachineBlenderSettings.CustomBlend>
	|-Array.InternalArray__set_Item<DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData>
	|-Array.InternalArray__set_Item<FrameTimingsHUDDisplay.FrameTimingPoint>
	|-Array.InternalArray__set_Item<InputActionMap.ReadMapJson>
	|-Array.InternalArray__set_Item<InputActionMap.WriteMapJson>
	|-Array.InternalArray__set_Item<InputEventTrace.DeviceInfo>
	|-Array.InternalArray__set_Item<InputManager.StateChangeMonitorListener>
	|-Array.InternalArray__set_Item<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|-Array.InternalArray__set_Item<ProbeVolumeSceneData.SerializableBoundItem>
	|-Array.InternalArray__set_Item<SVGDocument.NodeReferenceData>
	|-Array.InternalArray__set_Item<SVGDocument.ViewBoxInfo>
	|-Array.InternalArray__set_Item<TMP_ResourceManager.FontAssetRef>
	|-Array.InternalArray__set_Item<TextResourceManager.FontAssetRef>
	|-Array.InternalArray__set_Item<TrackedDeviceRaycaster.RaycastHitData>
	|-Array.InternalArray__set_Item<UIRStylePainter.RepeatRectUV>
	|-Array.InternalArray__set_Item<VisualTreeAsset.AssetEntry>
	|-Array.InternalArray__set_Item<Win32DnD.FORMATETC>
	|-Array.InternalArray__set_Item<XmlWellFormedWriter.AttrName>
	|-Array.InternalArray__set_Item<InstructionList.DebugView.InstructionView>
	|-Array.InternalArray__set_Item<MotionBlurComponent.FrameBlendingFilter.Frame>
	|-Array.InternalArray__set_Item<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xDE9280 Offset: 0xDE7C80 VA: 0x180DE9280
	|-Array.InternalArray__set_Item<Dictionary.Entry<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, JsonParser.JsonValue>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__set_Item<TextProcessingStack<MaterialReference>>
	|-Array.InternalArray__set_Item<ColorBlock>
	|-Array.InternalArray__set_Item<ComputedStyle>
	|-Array.InternalArray__set_Item<FrameTiming>
	|-Array.InternalArray__set_Item<InputBinding>
	|
	|-RVA: 0xDE96C0 Offset: 0xDE80C0 VA: 0x180DE96C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<Bounds, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, TreeViewItemData<object>>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, NetworkAnimator.StateChange>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<InternedString, InternedString>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<InternedString, InputControlLayout.Collection.PrecompiledLayout>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Bounds>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Color>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, LiquidVolume.MeshCache>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ProbeVolumePerSceneData.PerScenarioData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Regex.CachedCodeEntryKey, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__set_Item<KeyValuePair<NativeAddr, object>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, SVGDocument.PatternData>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__set_Item<RBTree.Node<object>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<object>>
	|-Array.InternalArray__set_Item<TextProcessingStack<object>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Background>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Color>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<int>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Length>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<object>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Rotate>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Scale>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<float>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<TextShadow>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.TimingData<Translate>>
	|-Array.InternalArray__set_Item<ContactPairHeader>
	|-Array.InternalArray__set_Item<Label>
	|-Array.InternalArray__set_Item<List>
	|-Array.InternalArray__set_Item<Navigation>
	|-Array.InternalArray__set_Item<PlayerLoopSystem>
	|-Array.InternalArray__set_Item<PlayerLoopSystemInternal>
	|-Array.InternalArray__set_Item<RenderTargetIdentifier>
	|-Array.InternalArray__set_Item<TMP_LinkInfo>
	|-Array.InternalArray__set_Item<TreeInstance>
	|-Array.InternalArray__set_Item<AnimationOutputWeightProcessor.WeightInfo>
	|-Array.InternalArray__set_Item<DecalEntityManager.CombinedChunks>
	|-Array.InternalArray__set_Item<GrounderQuadruped.Foot>
	|-Array.InternalArray__set_Item<InputActionMap.BindingOverrideJson>
	|-Array.InternalArray__set_Item<InputManager.StateChangeMonitorTimeout>
	|-Array.InternalArray__set_Item<OnScreenControl.OnScreenDeviceInfo>
	|-Array.InternalArray__set_Item<RenderGraphDebugData.PassDebugData>
	|-Array.InternalArray__set_Item<RenderGraphDebugData.ResourceDebugData>
	|-Array.InternalArray__set_Item<SequenceNode.SequenceConstructPosContext>
	|-Array.InternalArray__set_Item<TMP_DynamicFontAssetUtilities.FontReference>
	|-Array.InternalArray__set_Item<UIRenderDevice.AllocToFree>
	|-Array.InternalArray__set_Item<XmlEventCache.XmlEvent>
	|-Array.InternalArray__set_Item<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xDE9F60 Offset: 0xDE8960 VA: 0x180DE9F60
	|-Array.InternalArray__set_Item<Dictionary.Entry<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__set_Item<UHull>
	|-Array.InternalArray__set_Item<HID.HIDElementDescriptor>
	|-Array.InternalArray__set_Item<InputActionMap.ReadActionJson>
	|-Array.InternalArray__set_Item<JsonParser.JsonValue>
	|-Array.InternalArray__set_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0xDE9820 Offset: 0xDE8220 VA: 0x180DE9820
	|-Array.InternalArray__set_Item<Dictionary.Entry<CSteamID, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int2, int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, CSteamID>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Vector2Int>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Multipass.TransportIdData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, NetworkAnimator.SmoothedFloat>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, RpcLinkType>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, Vector4>>
	|-Array.InternalArray__set_Item<KeyValuePair<ushort, RpcLink>>
	|-Array.InternalArray__set_Item<HashSet.Slot<Vector3Int>>
	|-Array.InternalArray__set_Item<BackgroundSize>
	|-Array.InternalArray__set_Item<GradientColorKey>
	|-Array.InternalArray__set_Item<GradientStop>
	|-Array.InternalArray__set_Item<HighlightState>
	|-Array.InternalArray__set_Item<HighlightState>
	|-Array.InternalArray__set_Item<PageInfo>
	|-Array.InternalArray__set_Item<SqlDecimal>
	|-Array.InternalArray__set_Item<TMP_PageInfo>
	|-Array.InternalArray__set_Item<TemperatureEmitterInfo>
	|-Array.InternalArray__set_Item<TransformOrigin>
	|-Array.InternalArray__set_Item<UEncroachingSegment>
	|-Array.InternalArray__set_Item<CodePointIndexer.TableRange>
	|-Array.InternalArray__set_Item<Cursor.CursorEntry>
	|-Array.InternalArray__set_Item<HeadingTracker.Item>
	|-Array.InternalArray__set_Item<Icon.IconDirEntry>
	|-Array.InternalArray__set_Item<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xDE9130 Offset: 0xDE7B30 VA: 0x180DE9130
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__set_Item<ControlPointOption>
	|-Array.InternalArray__set_Item<RaycastHit2D>
	|-Array.InternalArray__set_Item<Funnel.PathPart>
	|-Array.InternalArray__set_Item<LightUtility.LightMeshVertex>
	|-Array.InternalArray__set_Item<NoiseSettings.TransformNoiseParams>
	|-Array.InternalArray__set_Item<SewerMushroomLocation.MushroomLocationData>
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0xDE9C70 Offset: 0xDE8670 VA: 0x180DE9C70
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, RenderInstancedDataLayout>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Vector4>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ushort, RpcLink>>
	|-Array.InternalArray__set_Item<KeyValuePair<int, ValueTuple<Vector4, Vector2Int>>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, MarkToBaseAdjustmentRecord>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, MarkToMarkAdjustmentRecord>>
	|-Array.InternalArray__set_Item<ValueTuple<Vector3, Quaternion>>
	|-Array.InternalArray__set_Item<Keyframe>
	|-Array.InternalArray__set_Item<TextShadow>
	|-Array.InternalArray__set_Item<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|-Array.InternalArray__set_Item<BBTree.BBTreeBox>
	|-Array.InternalArray__set_Item<BlitUtility.Vertex>
	|-Array.InternalArray__set_Item<CinemachinePath.Waypoint>
	|-Array.InternalArray__set_Item<IKSolverLimb.AxisDirection>
	|-Array.InternalArray__set_Item<NetworkAnimator.StateChange>
	|-Array.InternalArray__set_Item<SVGDocument.PatternData>
	|-Array.InternalArray__set_Item<ShadowUtility.Edge>
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xDE9970 Offset: 0xDE8370 VA: 0x180DE9970
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__set_Item<VisibleReflectionProbe>
	|
	|-RVA: 0xDE9410 Offset: 0xDE7E10 VA: 0x180DE9410
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, TMP_ResourceManager.FontAssetRef>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, TextResourceManager.FontAssetRef>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<NativeAddr, object>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ValueTuple<Vector3, Quaternion>>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, SVGDocument.PatternData>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, SVGDocument.ViewBoxInfo>>
	|-Array.InternalArray__set_Item<KeyValuePair<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<HighlightState>>
	|-Array.InternalArray__set_Item<TextProcessingStack<HighlightState>>
	|-Array.InternalArray__set_Item<ContactPoint>
	|-Array.InternalArray__set_Item<CopyClosingMeshJobData>
	|-Array.InternalArray__set_Item<CustomAttributeNamedArgument>
	|-Array.InternalArray__set_Item<DisplayInfo>
	|-Array.InternalArray__set_Item<IntPoint>
	|-Array.InternalArray__set_Item<LinkInfo>
	|-Array.InternalArray__set_Item<ProbeVolumeBakingProcessSettings>
	|-Array.InternalArray__set_Item<Rigidbody2DState>
	|-Array.InternalArray__set_Item<Transform3x4>
	|-Array.InternalArray__set_Item<VectorImageVertex>
	|-Array.InternalArray__set_Item<AnimationWarping.Warp>
	|-Array.InternalArray__set_Item<RigidbodyPauser.Rigidbody2DData>
	|-Array.InternalArray__set_Item<VectorUtils.SceneNodeWorldTransform>
	|-Array.InternalArray__set_Item<XmlSqlBinaryReader.AttrInfo>
	|-Array.InternalArray__set_Item<XmlSqlBinaryReader.ElemInfo>
	|-Array.InternalArray__set_Item<XmlWellFormedWriter.ElementScope>
	|-Array.InternalArray__set_Item<InputControlScheme.MatchResult.Match>
	|
	|-RVA: 0xDE9DD0 Offset: 0xDE87D0 VA: 0x180DE9DD0
	|-Array.InternalArray__set_Item<Dictionary.Entry<long, ComputedStyle>>
	|-Array.InternalArray__set_Item<CombineInstance>
	|-Array.InternalArray__set_Item<ModifiableContactPair>
	|
	|-RVA: 0xDEAE10 Offset: 0xDE9810 VA: 0x180DEAE10
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, RaycastHit>>
	|-Array.InternalArray__set_Item<KeyValuePair<CGSpot, InputTransformSpots.TransformSpot>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Color>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Scale>>
	|-Array.InternalArray__set_Item<EnumData>
	|-Array.InternalArray__set_Item<HumanBone>
	|-Array.InternalArray__set_Item<Matrix4x4>
	|-Array.InternalArray__set_Item<Vertex>
	|-Array.InternalArray__set_Item<float4x4>
	|-Array.InternalArray__set_Item<Cursor.CursorImage>
	|-Array.InternalArray__set_Item<InputActionMap.BindingJson>
	|-Array.InternalArray__set_Item<InputManager.AvailableDevice>
	|-Array.InternalArray__set_Item<InputRemoting.RemoteInputDevice>
	|-Array.InternalArray__set_Item<LayerGridGraph.HeightSample>
	|-Array.InternalArray__set_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xDEAF70 Offset: 0xDE9970 VA: 0x180DEAF70
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDEA3B0 Offset: 0xDE8DB0 VA: 0x180DEA3B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, GlyphPairAdjustmentRecord>>
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, TMP_DynamicFontAssetUtilities.FontReference>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, ProbeVolumeBakingProcessSettings>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, RaycastHit>>
	|-Array.InternalArray__set_Item<BatchCullingOutputDrawCommands>
	|-Array.InternalArray__set_Item<ContactPoint2D>
	|-Array.InternalArray__set_Item<InputDeviceDescription>
	|-Array.InternalArray__set_Item<MaterialReference>
	|-Array.InternalArray__set_Item<MaterialReference>
	|-Array.InternalArray__set_Item<SkeletonBone>
	|-Array.InternalArray__set_Item<InputActionMap.WriteActionJson>
	|-Array.InternalArray__set_Item<InputManager.StateChangeMonitorsForDevice>
	|-Array.InternalArray__set_Item<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|-Array.InternalArray__set_Item<RigidbodyPauser.RigidbodyData>
	|-Array.InternalArray__set_Item<TextureBlitter.BlitInfo>
	|-Array.InternalArray__set_Item<XmlTextWriter.TagInfo>
	|
	|-RVA: 0xDEB580 Offset: 0xDE9F80 VA: 0x180DEB580
	|-Array.InternalArray__set_Item<KeyValuePair<ValueTuple<Int32Enum, object>, EnumData>>
	|-Array.InternalArray__set_Item<KeyValuePair<object, JsonParser.JsonValue>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>
	|-Array.InternalArray__set_Item<MeshInfo>
	|-Array.InternalArray__set_Item<RaycastResult>
	|-Array.InternalArray__set_Item<TMP_MeshInfo>
	|-Array.InternalArray__set_Item<InputControlPath.ParsedPathComponent>
	|-Array.InternalArray__set_Item<UIRStylePainter.Entry>
	|-Array.InternalArray__set_Item<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xDEB140 Offset: 0xDE9B40 VA: 0x180DEB140
	|-Array.InternalArray__set_Item<KeyValuePair<int, ReflectionProbeManager.CachedProbe>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Background>>
	|-Array.InternalArray__set_Item<FixedString128Bytes>
	|-Array.InternalArray__set_Item<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xDEAB50 Offset: 0xDE9550 VA: 0x180DEAB50
	|-Array.InternalArray__set_Item<KeyValuePair<long, ComputedStyle>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Rotate>>
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<Translate>>
	|-Array.InternalArray__set_Item<CullingSplit>
	|-Array.InternalArray__set_Item<LightDataGI>
	|-Array.InternalArray__set_Item<LineInfo>
	|-Array.InternalArray__set_Item<NavMeshBuildSource>
	|-Array.InternalArray__set_Item<TMP_LineInfo>
	|-Array.InternalArray__set_Item<TileData>
	|-Array.InternalArray__set_Item<RenderChain.RenderNodeData>
	|
	|-RVA: 0xDEB6F0 Offset: 0xDEA0F0 VA: 0x180DEB6F0
	|-Array.InternalArray__set_Item<KeyValuePair<object, InputControlLayout.ControlItem>>
	|
	|-RVA: 0xDEA0E0 Offset: 0xDE8AE0 VA: 0x180DEA0E0
	|-Array.InternalArray__set_Item<KeyValuePair<ushort, ushort>>
	|-Array.InternalArray__set_Item<AppId_t>
	|-Array.InternalArray__set_Item<Color32>
	|-Array.InternalArray__set_Item<DepotId_t>
	|-Array.InternalArray__set_Item<EasingFunction>
	|-Array.InternalArray__set_Item<HSteamNetConnection>
	|-Array.InternalArray__set_Item<InclusiveRange>
	|-Array.InternalArray__set_Item<InputUser>
	|-Array.InternalArray__set_Item<int>
	|-Array.InternalArray__set_Item<Int32Enum>
	|-Array.InternalArray__set_Item<LayerMask>
	|-Array.InternalArray__set_Item<Scene>
	|-Array.InternalArray__set_Item<ShaderTagId>
	|-Array.InternalArray__set_Item<SortingLayer>
	|-Array.InternalArray__set_Item<SqlInt16>
	|-Array.InternalArray__set_Item<SteamItemDef_t>
	|-Array.InternalArray__set_Item<TextureId>
	|-Array.InternalArray__set_Item<uint>
	|-Array.InternalArray__set_Item<UInt32Enum>
	|-Array.InternalArray__set_Item<UShort2>
	|-Array.InternalArray__set_Item<HebrewNumber.HebrewValue>
	|-Array.InternalArray__set_Item<RegexCharClass.SingleRange>
	|
	|-RVA: 0xDEC1B0 Offset: 0xDEABB0 VA: 0x180DEC1B0
	|-Array.InternalArray__set_Item<StylePropertyAnimationSystem.Values.StyleData<TextShadow>>
	|
	|-RVA: 0xDEC340 Offset: 0xDEAD40 VA: 0x180DEC340
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0xDEC510 Offset: 0xDEAF10 VA: 0x180DEC510
	|-Array.InternalArray__set_Item<TextProcessingStack<WordWrapState>>
	|-Array.InternalArray__set_Item<WordWrapState>
	|
	|-RVA: 0xDEA210 Offset: 0xDE8C10 VA: 0x180DEA210
	|-Array.InternalArray__set_Item<AttachmentDescriptor>
	|-Array.InternalArray__set_Item<NudgeJobData>
	|-Array.InternalArray__set_Item<GodRaysRenderPass.VisibleLightRemap>
	|-Array.InternalArray__set_Item<InputActionRebindingExtensions.ParameterOverride>
	|-Array.InternalArray__set_Item<ReflectionProbeManager.CachedProbe>
	|-Array.InternalArray__set_Item<Tilemap.SyncTile>
	|-Array.InternalArray__set_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0xDEA520 Offset: 0xDE8F20 VA: 0x180DEA520
	|-Array.InternalArray__set_Item<Board>
	|-Array.InternalArray__set_Item<RendererListResource>
	|
	|-RVA: 0xDEA6F0 Offset: 0xDE90F0 VA: 0x180DEA6F0
	|-Array.InternalArray__set_Item<CGSpot>
	|-Array.InternalArray__set_Item<GlyphPairAdjustmentRecord>
	|-Array.InternalArray__set_Item<RaycastHit>
	|-Array.InternalArray__set_Item<VolumetricFog.FogOfWarTransition>
	|
	|-RVA: 0xDEA850 Offset: 0xDE9250 VA: 0x180DEA850
	|-Array.InternalArray__set_Item<char>
	|-Array.InternalArray__set_Item<short>
	|-Array.InternalArray__set_Item<SqlByte>
	|-Array.InternalArray__set_Item<ushort>
	|-Array.InternalArray__set_Item<UInt16Enum>
	|-Array.InternalArray__set_Item<NetworkAnimator.TriggerUpdate>
	|-Array.InternalArray__set_Item<SVGDocument.MaskData>
	|
	|-RVA: 0xDEA990 Offset: 0xDE9390 VA: 0x180DEA990
	|-Array.InternalArray__set_Item<ConvertMeshJobData>
	|
	|-RVA: 0xDEACD0 Offset: 0xDE96D0 VA: 0x180DEACD0
	|-Array.InternalArray__set_Item<double>
	|
	|-RVA: 0xDEB2E0 Offset: 0xDE9CE0 VA: 0x180DEB2E0
	|-Array.InternalArray__set_Item<GlyphMarshallingStruct>
	|-Array.InternalArray__set_Item<LayerBatch>
	|-Array.InternalArray__set_Item<UTriangle>
	|
	|-RVA: 0xDEB440 Offset: 0xDE9E40 VA: 0x180DEB440
	|-Array.InternalArray__set_Item<GradientAlphaKey>
	|-Array.InternalArray__set_Item<PointF>
	|-Array.InternalArray__set_Item<Vector2>
	|-Array.InternalArray__set_Item<float2>
	|-Array.InternalArray__set_Item<CinemachineFreeLook.Orbit>
	|-Array.InternalArray__set_Item<NetworkAnimator.SmoothedFloat>
	|-Array.InternalArray__set_Item<SVGDocument.NodeGlobalSceneState>
	|
	|-RVA: 0xDEBD80 Offset: 0xDEA780 VA: 0x180DEBD80
	|-Array.InternalArray__set_Item<object>
	|
	|-RVA: 0xDEB8C0 Offset: 0xDEA2C0 VA: 0x180DEB8C0
	|-Array.InternalArray__set_Item<PointerModel>
	|
	|-RVA: 0xDEBA70 Offset: 0xDEA470 VA: 0x180DEBA70
	|-Array.InternalArray__set_Item<RenderStateBlock>
	|-Array.InternalArray__set_Item<UIVertex>
	|
	|-RVA: 0xDEBC10 Offset: 0xDEA610 VA: 0x180DEBC10
	|-Array.InternalArray__set_Item<RigidbodyState>
	|
	|-RVA: 0xDEBEA0 Offset: 0xDEA8A0 VA: 0x180DEBEA0
	|-Array.InternalArray__set_Item<ShadowSliceData>
	|
	|-RVA: 0xDEC070 Offset: 0xDEAA70 VA: 0x180DEC070
	|-Array.InternalArray__set_Item<float>
	|
	|-RVA: 0xDED380 Offset: 0xDEBD80 VA: 0x180DED380
	|-Array.InternalArray__set_Item<TMP_CharacterInfo>
	|
	|-RVA: 0xDED560 Offset: 0xDEBF60 VA: 0x180DED560
	|-Array.InternalArray__set_Item<TextElementInfo>
	|
	|-RVA: 0xDED710 Offset: 0xDEC110 VA: 0x180DED710
	|-Array.InternalArray__set_Item<Touch>
	|
	|-RVA: 0xDEDBE0 Offset: 0xDEC5E0 VA: 0x180DEDBE0
	|-Array.InternalArray__set_Item<VisibleLight>
	|
	|-RVA: 0xDEDD80 Offset: 0xDEC780 VA: 0x180DEDD80
	|-Array.InternalArray__set_Item<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xDEDF30 Offset: 0xDEC930 VA: 0x180DEDF30
	|-Array.InternalArray__set_Item<WordWrapState>
	|
	|-RVA: 0xDEE0E0 Offset: 0xDECAE0 VA: 0x180DEE0E0
	|-Array.InternalArray__set_Item<XEvent>
	|
	|-RVA: 0xDEE2B0 Offset: 0xDECCB0 VA: 0x180DEE2B0
	|-Array.InternalArray__set_Item<XRView>
	|
	|-RVA: 0xDED070 Offset: 0xDEBA70 VA: 0x180DED070
	|-Array.InternalArray__set_Item<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDEDA50 Offset: 0xDEC450 VA: 0x180DEDA50
	|-Array.InternalArray__set_Item<Agent.VO>
	|
	|-RVA: 0xDEC9E0 Offset: 0xDEB3E0 VA: 0x180DEC9E0
	|-Array.InternalArray__set_Item<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xDECB90 Offset: 0xDEB590 VA: 0x180DECB90
	|-Array.InternalArray__set_Item<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xDECD10 Offset: 0xDEB710 VA: 0x180DECD10
	|-Array.InternalArray__set_Item<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xDECEC0 Offset: 0xDEB8C0 VA: 0x180DECEC0
	|-Array.InternalArray__set_Item<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xDEC810 Offset: 0xDEB210 VA: 0x180DEC810
	|-Array.InternalArray__set_Item<InputControlLayout.ControlItem>
	|
	|-RVA: 0xDEC6D0 Offset: 0xDEB0D0 VA: 0x180DEC6D0
	|-Array.InternalArray__set_Item<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xDED880 Offset: 0xDEC280 VA: 0x180DED880
	|-Array.InternalArray__set_Item<InputUser.UserData>
	|
	|-RVA: 0xDED200 Offset: 0xDEBC00 VA: 0x180DED200
	|-Array.InternalArray__set_Item<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	internal void GetGenericValueImpl<T>(int pos, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.GetGenericValueImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void SetGenericValueImpl<T>(int pos, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.SetGenericValueImpl<__Il2CppFullySharedGenericType>
	*/

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7D160 Offset: 0x1C7BB60 VA: 0x181C7D160
	public int get_Length() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7C2E0 Offset: 0x1C7ACE0 VA: 0x181C7C2E0
	public int get_Rank() { }

	// RVA: 0x1C7C2E0 Offset: 0x1C7ACE0 VA: 0x181C7C2E0
	private int GetRank() { }

	// RVA: 0x1C7C2A0 Offset: 0x1C7ACA0 VA: 0x181C7C2A0
	public int GetLength(int dimension) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7C2C0 Offset: 0x1C7ACC0 VA: 0x181C7C2C0
	public int GetLowerBound(int dimension) { }

	// RVA: 0x1C7C670 Offset: 0x1C7B070 VA: 0x181C7C670
	public object GetValue(int[] indices) { }

	// RVA: 0x1C7DDC0 Offset: 0x1C7C7C0 VA: 0x181C7DDC0
	public void SetValue(object value, int[] indices) { }

	// RVA: 0x1C7C350 Offset: 0x1C7AD50 VA: 0x181C7C350
	internal object GetValueImpl(int pos) { }

	// RVA: 0x1C7DA90 Offset: 0x1C7C490 VA: 0x181C7DA90
	internal void SetValueImpl(object value, int pos) { }

	// RVA: 0x1C7C230 Offset: 0x1C7AC30 VA: 0x181C7C230
	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) { }

	// RVA: 0x1C7B620 Offset: 0x1C7A020 VA: 0x181C7B620
	internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7C310 Offset: 0x1C7AD10 VA: 0x181C7C310
	public int GetUpperBound(int dimension) { }

	// RVA: 0x1C7C360 Offset: 0x1C7AD60 VA: 0x181C7C360
	public object GetValue(int index) { }

	// RVA: 0x1C7C8F0 Offset: 0x1C7B2F0 VA: 0x181C7C8F0
	public object GetValue(int index1, int index2) { }

	// RVA: 0x1C7C980 Offset: 0x1C7B380 VA: 0x181C7C980
	public object GetValue(int index1, int index2, int index3) { }

	// RVA: 0x1C7E070 Offset: 0x1C7CA70 VA: 0x181C7E070
	public void SetValue(object value, int index) { }

	// RVA: 0x1C7DD20 Offset: 0x1C7C720 VA: 0x181C7DD20
	public void SetValue(object value, int index1, int index2) { }

	// RVA: 0x1C7DAA0 Offset: 0x1C7C4A0 VA: 0x181C7DAA0
	public void SetValue(object value, int index1, int index2, int index3) { }

	// RVA: 0x1C7F6B0 Offset: 0x1C7E0B0 VA: 0x181C7F6B0
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	// RVA: 0x1C7B6A0 Offset: 0x1C7A0A0 VA: 0x181C7B6A0
	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x1C7F6C0 Offset: 0x1C7E0C0 VA: 0x181C7F6C0
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x1C7B630 Offset: 0x1C7A030 VA: 0x181C7B630
	public static Array CreateInstance(Type elementType, int length) { }

	// RVA: 0x1C7B6A0 Offset: 0x1C7A0A0 VA: 0x181C7B6A0
	public static Array CreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x1C7BFC0 Offset: 0x1C7A9C0 VA: 0x181C7BFC0
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) { }

	// RVA: 0x1C7B730 Offset: 0x1C7A130 VA: 0x181C7B730
	public static Array CreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x1C7BA60 Offset: 0x1C7A460 VA: 0x181C7BA60
	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7A7B0 Offset: 0x1C791B0 VA: 0x181C7A7B0
	public static void Clear(Array array, int index, int length) { }

	// RVA: 0x1C7A7A0 Offset: 0x1C791A0 VA: 0x181C7A7A0
	private static void ClearInternal(Array a, int index, int count) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x1C7AD40 Offset: 0x1C79740 VA: 0x181C7AD40
	public static void Copy(Array sourceArray, Array destinationArray, int length) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x1C7AFC0 Offset: 0x1C799C0 VA: 0x181C7AFC0
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: 0x1C7B5D0 Offset: 0x1C79FD0 VA: 0x181C7B5D0
	private static ArrayTypeMismatchException CreateArrayTypeMismatchException() { }

	// RVA: 0x1C7A6A0 Offset: 0x1C790A0 VA: 0x181C7A6A0
	private static bool CanAssignArrayElement(Type source, Type target) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C7A940 Offset: 0x1C79340 VA: 0x181C7A940
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: -1 Offset: -1
	public static T[] Empty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x454A40 Offset: 0x453440 VA: 0x180454A40
	|-Array.Empty<KeyValuePair<StructMultiKey<object, object>, object>>
	|-Array.Empty<KeyValuePair<int, object>>
	|-Array.Empty<KeyValuePair<object, object>>
	|-Array.Empty<ValueTuple<IntPtr, object>>
	|-Array.Empty<ValueTuple<object, int>>
	|-Array.Empty<byte>
	|-Array.Empty<char>
	|-Array.Empty<CustomAttributeNamedArgument>
	|-Array.Empty<CustomAttributeTypedArgument>
	|-Array.Empty<IndexField>
	|-Array.Empty<short>
	|-Array.Empty<Int2>
	|-Array.Empty<Int3>
	|-Array.Empty<int>
	|-Array.Empty<Int32Enum>
	|-Array.Empty<LocalDefinition>
	|-Array.Empty<LocalPacket>
	|-Array.Empty<LocalPacket>
	|-Array.Empty<Matrix4x4>
	|-Array.Empty<object>
	|-Array.Empty<Packet>
	|-Array.Empty<ParameterModifier>
	|-Array.Empty<Rect>
	|-Array.Empty<float>
	|-Array.Empty<TextureId>
	|-Array.Empty<ushort>
	|-Array.Empty<uint>
	|-Array.Empty<Vector2>
	|-Array.Empty<Vector3>
	|-Array.Empty<__Il2CppFullySharedGenericType>
	|-Array.Empty<jvalue>
	|-Array.Empty<BaseStyleMatcher.MatchContext>
	|-Array.Empty<CinemachineBlendListCamera.Instruction>
	|-Array.Empty<CinemachinePath.Waypoint>
	|-Array.Empty<CinemachineSmoothPath.Waypoint>
	|-Array.Empty<CinemachineStateDrivenCamera.Instruction>
	|-Array.Empty<CinemachineTargetGroup.Target>
	|-Array.Empty<EventDispatcher.DispatchContext>
	|-Array.Empty<EventDispatcher.EventRecord>
	|-Array.Empty<GraphUpdateProcessor.GUOSingle>
	|-Array.Empty<NetworkAnimator.ReceivedServerData>
	|-Array.Empty<NoiseSettings.TransformNoiseParams>
	|-Array.Empty<ProbeBrickPool.BrickChunkAlloc>
	|-Array.Empty<SequenceNode.SequenceConstructPosContext>
	|-Array.Empty<StyleVariableResolver.ResolveContext>
	|-Array.Empty<BindingRestrictions.TestBuilder.AndNode>
	*/

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Initialize() { }

	// RVA: -1 Offset: -1
	private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF8FEF0 Offset: 0xF8E8F0 VA: 0x180F8FEF0
	|-Array.IndexOfImpl<ArraySegment<byte>>
	|
	|-RVA: 0xF91560 Offset: 0xF8FF60 VA: 0x180F91560
	|-Array.IndexOfImpl<SyncList.CachedOnChange<int>>
	|
	|-RVA: 0xF91EC0 Offset: 0xF908C0 VA: 0x180F91EC0
	|-Array.IndexOfImpl<SyncList.ChangeData<int>>
	|
	|-RVA: 0xF95520 Offset: 0xF93F20 VA: 0x180F95520
	|-Array.IndexOfImpl<IntervalTree.Entry<object>>
	|
	|-RVA: 0xF99B40 Offset: 0xF98540 VA: 0x180F99B40
	|-Array.IndexOfImpl<KeyValuePair<int, object>>
	|
	|-RVA: 0xF999B0 Offset: 0xF983B0 VA: 0x180F999B0
	|-Array.IndexOfImpl<KeyValuePair<object, bool>>
	|
	|-RVA: 0xF99CD0 Offset: 0xF986D0 VA: 0x180F99CD0
	|-Array.IndexOfImpl<KeyValuePair<object, char>>
	|
	|-RVA: 0xF9A020 Offset: 0xF98A20 VA: 0x180F9A020
	|-Array.IndexOfImpl<KeyValuePair<object, object>>
	|
	|-RVA: 0xF99E60 Offset: 0xF98860 VA: 0x180F99E60
	|-Array.IndexOfImpl<KeyValuePair<object, JsonParser.JsonValue>>
	|
	|-RVA: 0xF99820 Offset: 0xF98220 VA: 0x180F99820
	|-Array.IndexOfImpl<KeyValuePair<PropertyName, object>>
	|
	|-RVA: 0xF99680 Offset: 0xF98080 VA: 0x180F99680
	|-Array.IndexOfImpl<KeyValuePair<Rect, object>>
	|
	|-RVA: 0xF9C690 Offset: 0xF9B090 VA: 0x180F9C690
	|-Array.IndexOfImpl<NativeArray<ConvertMeshJobData>>
	|
	|-RVA: 0xF9C370 Offset: 0xF9AD70 VA: 0x180F9C370
	|-Array.IndexOfImpl<NativeArray<CopyClosingMeshJobData>>
	|
	|-RVA: 0xF9C500 Offset: 0xF9AF00 VA: 0x180F9C500
	|-Array.IndexOfImpl<NativeArray<NudgeJobData>>
	|
	|-RVA: 0xF9C820 Offset: 0xF9B220 VA: 0x180F9C820
	|-Array.IndexOfImpl<NativeSlice<ConvertMeshJobData>>
	|
	|-RVA: 0xF9CB40 Offset: 0xF9B540 VA: 0x180F9CB40
	|-Array.IndexOfImpl<NativeSlice<CopyClosingMeshJobData>>
	|
	|-RVA: 0xF9C9B0 Offset: 0xF9B3B0 VA: 0x180F9C9B0
	|-Array.IndexOfImpl<NativeSlice<NudgeJobData>>
	|
	|-RVA: 0xF9D6B0 Offset: 0xF9C0B0 VA: 0x180F9D6B0
	|-Array.IndexOfImpl<Nullable<DateTime>>
	|
	|-RVA: 0xF9D510 Offset: 0xF9BF10 VA: 0x180F9D510
	|-Array.IndexOfImpl<Nullable<Decimal>>
	|
	|-RVA: 0xF9DD00 Offset: 0xF9C700 VA: 0x180F9DD00
	|-Array.IndexOfImpl<TempAllocator.Page<ushort>>
	|
	|-RVA: 0xF9E020 Offset: 0xF9CA20 VA: 0x180F9E020
	|-Array.IndexOfImpl<TempAllocator.Page<Vertex>>
	|
	|-RVA: 0xFA1020 Offset: 0xF9FA20 VA: 0x180FA1020
	|-Array.IndexOfImpl<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0xFA32B0 Offset: 0xFA1CB0 VA: 0x180FA32B0
	|-Array.IndexOfImpl<StructMultiKey<object, object>>
	|
	|-RVA: 0xFA3F70 Offset: 0xFA2970 VA: 0x180FA3F70
	|-Array.IndexOfImpl<SubArray<int>>
	|
	|-RVA: 0xFA6500 Offset: 0xFA4F00 VA: 0x180FA6500
	|-Array.IndexOfImpl<ValueTuple<int, int>>
	|
	|-RVA: 0xFA6CB0 Offset: 0xFA56B0 VA: 0x180FA6CB0
	|-Array.IndexOfImpl<ValueTuple<int, object>>
	|
	|-RVA: 0xFA6680 Offset: 0xFA5080 VA: 0x180FA6680
	|-Array.IndexOfImpl<ValueTuple<int, Scene>>
	|
	|-RVA: 0xFA6360 Offset: 0xFA4D60 VA: 0x180FA6360
	|-Array.IndexOfImpl<ValueTuple<int, Vector2Int>>
	|
	|-RVA: 0xFA6B20 Offset: 0xFA5520 VA: 0x180FA6B20
	|-Array.IndexOfImpl<ValueTuple<IntPtr, object>>
	|
	|-RVA: 0xFA61C0 Offset: 0xFA4BC0 VA: 0x180FA61C0
	|-Array.IndexOfImpl<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0xFA6990 Offset: 0xFA5390 VA: 0x180FA6990
	|-Array.IndexOfImpl<ValueTuple<object, int>>
	|
	|-RVA: 0xFA6800 Offset: 0xFA5200 VA: 0x180FA6800
	|-Array.IndexOfImpl<ValueTuple<object, object>>
	|
	|-RVA: 0xF8FD70 Offset: 0xF8E770 VA: 0x180F8FD70
	|-Array.IndexOfImpl<AnimatorClipInfo>
	|
	|-RVA: 0xF90220 Offset: 0xF8EC20 VA: 0x180F90220
	|-Array.IndexOfImpl<AsyncGPUReadbackRequest>
	|
	|-RVA: 0xF90550 Offset: 0xF8EF50 VA: 0x180F90550
	|-Array.IndexOfImpl<BezierContour>
	|
	|-RVA: 0xF906E0 Offset: 0xF8F0E0 VA: 0x180F906E0
	|-Array.IndexOfImpl<BezierPathSegment>
	|
	|-RVA: 0xF90880 Offset: 0xF8F280 VA: 0x180F90880
	|-Array.IndexOfImpl<BezierSegment>
	|
	|-RVA: 0xF90D70 Offset: 0xF8F770 VA: 0x180F90D70
	|-Array.IndexOfImpl<bool>
	|
	|-RVA: 0xF90EF0 Offset: 0xF8F8F0 VA: 0x180F90EF0
	|-Array.IndexOfImpl<Bounds>
	|
	|-RVA: 0xF91230 Offset: 0xF8FC30 VA: 0x180F91230
	|-Array.IndexOfImpl<byte>
	|
	|-RVA: 0xF913B0 Offset: 0xF8FDB0 VA: 0x180F913B0
	|-Array.IndexOfImpl<CGSpot>
	|
	|-RVA: 0xF92060 Offset: 0xF90A60 VA: 0x180F92060
	|-Array.IndexOfImpl<char>
	|
	|-RVA: 0xF92360 Offset: 0xF90D60 VA: 0x180F92360
	|-Array.IndexOfImpl<Color>
	|
	|-RVA: 0xF921E0 Offset: 0xF90BE0 VA: 0x180F921E0
	|-Array.IndexOfImpl<Color32>
	|
	|-RVA: 0xF92690 Offset: 0xF91090 VA: 0x180F92690
	|-Array.IndexOfImpl<CombineInstance>
	|
	|-RVA: 0xF92A10 Offset: 0xF91410 VA: 0x180F92A10
	|-Array.IndexOfImpl<ComputedTransitionProperty>
	|
	|-RVA: 0xF92D40 Offset: 0xF91740 VA: 0x180F92D40
	|-Array.IndexOfImpl<Connection>
	|
	|-RVA: 0xF93060 Offset: 0xF91A60 VA: 0x180F93060
	|-Array.IndexOfImpl<ContourVertex>
	|
	|-RVA: 0xF93410 Offset: 0xF91E10 VA: 0x180F93410
	|-Array.IndexOfImpl<ControlPointOption>
	|
	|-RVA: 0xF935B0 Offset: 0xF91FB0 VA: 0x180F935B0
	|-Array.IndexOfImpl<CoordinateFootprintTilePair>
	|
	|-RVA: 0xF93740 Offset: 0xF92140 VA: 0x180F93740
	|-Array.IndexOfImpl<CoordinateProceduralTilePair>
	|
	|-RVA: 0xF938E0 Offset: 0xF922E0 VA: 0x180F938E0
	|-Array.IndexOfImpl<CoordinateStorageFootprintTilePair>
	|
	|-RVA: 0xF93A70 Offset: 0xF92470 VA: 0x180F93A70
	|-Array.IndexOfImpl<CoordinateStorageTilePair>
	|
	|-RVA: 0xF93C00 Offset: 0xF92600 VA: 0x180F93C00
	|-Array.IndexOfImpl<CoordinateTilePair>
	|
	|-RVA: 0xF940B0 Offset: 0xF92AB0 VA: 0x180F940B0
	|-Array.IndexOfImpl<DateTime>
	|
	|-RVA: 0xF93F20 Offset: 0xF92920 VA: 0x180F93F20
	|-Array.IndexOfImpl<DateTimeOffset>
	|
	|-RVA: 0xF943D0 Offset: 0xF92DD0 VA: 0x180F943D0
	|-Array.IndexOfImpl<Decimal>
	|
	|-RVA: 0xF946F0 Offset: 0xF930F0 VA: 0x180F946F0
	|-Array.IndexOfImpl<DisplayInfo>
	|
	|-RVA: 0xF94D40 Offset: 0xF93740 VA: 0x180F94D40
	|-Array.IndexOfImpl<double>
	|
	|-RVA: 0xF94BB0 Offset: 0xF935B0 VA: 0x180F94BB0
	|-Array.IndexOfImpl<DoublePoint>
	|
	|-RVA: 0xF94890 Offset: 0xF93290 VA: 0x180F94890
	|-Array.IndexOfImpl<DoublePoint>
	|
	|-RVA: 0xF94ED0 Offset: 0xF938D0 VA: 0x180F94ED0
	|-Array.IndexOfImpl<DualPrefab>
	|
	|-RVA: 0xF95060 Offset: 0xF93A60 VA: 0x180F95060
	|-Array.IndexOfImpl<DuplicateSamplePoint>
	|
	|-RVA: 0xF95200 Offset: 0xF93C00 VA: 0x180F95200
	|-Array.IndexOfImpl<EasingFunction>
	|
	|-RVA: 0xF95880 Offset: 0xF94280 VA: 0x180F95880
	|-Array.IndexOfImpl<Entry>
	|
	|-RVA: 0xF95BA0 Offset: 0xF945A0 VA: 0x180F95BA0
	|-Array.IndexOfImpl<EventSummary>
	|
	|-RVA: 0xF96050 Offset: 0xF94A50 VA: 0x180F96050
	|-Array.IndexOfImpl<FrameTimeSample>
	|
	|-RVA: 0xF966E0 Offset: 0xF950E0 VA: 0x180F966E0
	|-Array.IndexOfImpl<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xF96890 Offset: 0xF95290 VA: 0x180F96890
	|-Array.IndexOfImpl<GlyphRect>
	|
	|-RVA: 0xF96A20 Offset: 0xF95420 VA: 0x180F96A20
	|-Array.IndexOfImpl<Guid>
	|
	|-RVA: 0xF97510 Offset: 0xF95F10 VA: 0x180F97510
	|-Array.IndexOfImpl<InputBinding>
	|
	|-RVA: 0xF976E0 Offset: 0xF960E0 VA: 0x180F976E0
	|-Array.IndexOfImpl<InputDeviceDescription>
	|
	|-RVA: 0xF97890 Offset: 0xF96290 VA: 0x180F97890
	|-Array.IndexOfImpl<InputEventPtr>
	|
	|-RVA: 0xF97BB0 Offset: 0xF965B0 VA: 0x180F97BB0
	|-Array.IndexOfImpl<short>
	|
	|-RVA: 0xF97D30 Offset: 0xF96730 VA: 0x180F97D30
	|-Array.IndexOfImpl<Int2>
	|
	|-RVA: 0xF981B0 Offset: 0xF96BB0 VA: 0x180F981B0
	|-Array.IndexOfImpl<Int3>
	|
	|-RVA: 0xF98030 Offset: 0xF96A30 VA: 0x180F98030
	|-Array.IndexOfImpl<int>
	|
	|-RVA: 0xF97EB0 Offset: 0xF968B0 VA: 0x180F97EB0
	|-Array.IndexOfImpl<Int32Enum>
	|
	|-RVA: 0xF98350 Offset: 0xF96D50 VA: 0x180F98350
	|-Array.IndexOfImpl<long>
	|
	|-RVA: 0xF98800 Offset: 0xF97200 VA: 0x180F98800
	|-Array.IndexOfImpl<IntPoint>
	|
	|-RVA: 0xF984D0 Offset: 0xF96ED0 VA: 0x180F984D0
	|-Array.IndexOfImpl<IntPoint>
	|
	|-RVA: 0xF98990 Offset: 0xF97390 VA: 0x180F98990
	|-Array.IndexOfImpl<IntRect>
	|
	|-RVA: 0xF98B20 Offset: 0xF97520 VA: 0x180F98B20
	|-Array.IndexOfImpl<IntRegion>
	|
	|-RVA: 0xF98CC0 Offset: 0xF976C0 VA: 0x180F98CC0
	|-Array.IndexOfImpl<InternedString>
	|
	|-RVA: 0xF98E50 Offset: 0xF97850 VA: 0x180F98E50
	|-Array.IndexOfImpl<InterpretedFrameInfo>
	|
	|-RVA: 0xF98FE0 Offset: 0xF979E0 VA: 0x180F98FE0
	|-Array.IndexOfImpl<IntervalTreeNode>
	|
	|-RVA: 0xF99320 Offset: 0xF97D20 VA: 0x180F99320
	|-Array.IndexOfImpl<JsonPosition>
	|
	|-RVA: 0xF9A1B0 Offset: 0xF98BB0 VA: 0x180F9A1B0
	|-Array.IndexOfImpl<Label>
	|
	|-RVA: 0xF9A690 Offset: 0xF99090 VA: 0x180F9A690
	|-Array.IndexOfImpl<LigatureSubstitutionRecord>
	|
	|-RVA: 0xF9A820 Offset: 0xF99220 VA: 0x180F9A820
	|-Array.IndexOfImpl<LigatureSubstitutionRecord>
	|
	|-RVA: 0xF9AB40 Offset: 0xF99540 VA: 0x180F9AB40
	|-Array.IndexOfImpl<LocalPacket>
	|
	|-RVA: 0xF9A9B0 Offset: 0xF993B0 VA: 0x180F9A9B0
	|-Array.IndexOfImpl<LocalPacket>
	|
	|-RVA: 0xF9ACD0 Offset: 0xF996D0 VA: 0x180F9ACD0
	|-Array.IndexOfImpl<ManipulatorActivationFilter>
	|
	|-RVA: 0xF9AE70 Offset: 0xF99870 VA: 0x180F9AE70
	|-Array.IndexOfImpl<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xF9B010 Offset: 0xF99A10 VA: 0x180F9B010
	|-Array.IndexOfImpl<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0xF9B1B0 Offset: 0xF99BB0 VA: 0x180F9B1B0
	|-Array.IndexOfImpl<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xF9B350 Offset: 0xF99D50 VA: 0x180F9B350
	|-Array.IndexOfImpl<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0xF9B4F0 Offset: 0xF99EF0 VA: 0x180F9B4F0
	|-Array.IndexOfImpl<Matrix4x4>
	|
	|-RVA: 0xF9BD00 Offset: 0xF9A700 VA: 0x180F9BD00
	|-Array.IndexOfImpl<MultipleSubstitutionRecord>
	|
	|-RVA: 0xF9BB70 Offset: 0xF9A570 VA: 0x180F9BB70
	|-Array.IndexOfImpl<MultipleSubstitutionRecord>
	|
	|-RVA: 0xF9C030 Offset: 0xF9AA30 VA: 0x180F9C030
	|-Array.IndexOfImpl<NameAndParameters>
	|
	|-RVA: 0xF9C1D0 Offset: 0xF9ABD0 VA: 0x180F9C1D0
	|-Array.IndexOfImpl<NamedValue>
	|
	|-RVA: 0xF9CCD0 Offset: 0xF9B6D0 VA: 0x180F9CCD0
	|-Array.IndexOfImpl<NavMeshBuildMarkup>
	|
	|-RVA: 0xF9CE70 Offset: 0xF9B870 VA: 0x180F9CE70
	|-Array.IndexOfImpl<NavMeshBuildSource>
	|
	|-RVA: 0xFA1690 Offset: 0xFA0090 VA: 0x180FA1690
	|-Array.IndexOfImpl<object>
	|
	|-RVA: 0xF9DB60 Offset: 0xF9C560 VA: 0x180F9DB60
	|-Array.IndexOfImpl<Packet>
	|
	|-RVA: 0xF9E820 Offset: 0xF9D220 VA: 0x180F9E820
	|-Array.IndexOfImpl<Playable>
	|
	|-RVA: 0xF9E680 Offset: 0xF9D080 VA: 0x180F9E680
	|-Array.IndexOfImpl<PlayableBinding>
	|
	|-RVA: 0xF9EB50 Offset: 0xF9D550 VA: 0x180F9EB50
	|-Array.IndexOfImpl<PlayerLoopSystem>
	|
	|-RVA: 0xF9E9B0 Offset: 0xF9D3B0 VA: 0x180F9E9B0
	|-Array.IndexOfImpl<PlayerLoopSystemInternal>
	|
	|-RVA: 0xF9F310 Offset: 0xF9DD10 VA: 0x180F9F310
	|-Array.IndexOfImpl<Quaternion>
	|
	|-RVA: 0xF9F4A0 Offset: 0xF9DEA0 VA: 0x180F9F4A0
	|-Array.IndexOfImpl<RangePositionInfo>
	|
	|-RVA: 0xF9F970 Offset: 0xF9E370 VA: 0x180F9F970
	|-Array.IndexOfImpl<RaycastHit>
	|
	|-RVA: 0xF9F630 Offset: 0xF9E030 VA: 0x180F9F630
	|-Array.IndexOfImpl<RaycastHit2D>
	|
	|-RVA: 0xF9FB20 Offset: 0xF9E520 VA: 0x180F9FB20
	|-Array.IndexOfImpl<RaycastResult>
	|
	|-RVA: 0xFA0010 Offset: 0xF9EA10 VA: 0x180FA0010
	|-Array.IndexOfImpl<RectInt>
	|
	|-RVA: 0xFA0370 Offset: 0xF9ED70 VA: 0x180FA0370
	|-Array.IndexOfImpl<RenderTargetIdentifier>
	|
	|-RVA: 0xFA0690 Offset: 0xF9F090 VA: 0x180FA0690
	|-Array.IndexOfImpl<RendererList>
	|
	|-RVA: 0xFA0510 Offset: 0xF9EF10 VA: 0x180FA0510
	|-Array.IndexOfImpl<RendererListHandle>
	|
	|-RVA: 0xFA0B70 Offset: 0xF9F570 VA: 0x180FA0B70
	|-Array.IndexOfImpl<Resolution>
	|
	|-RVA: 0xFA0EA0 Offset: 0xF9F8A0 VA: 0x180FA0EA0
	|-Array.IndexOfImpl<ResourceHandle>
	|
	|-RVA: 0xFA1500 Offset: 0xF9FF00 VA: 0x180FA1500
	|-Array.IndexOfImpl<RuleMatcher>
	|
	|-RVA: 0xFA1810 Offset: 0xFA0210 VA: 0x180FA1810
	|-Array.IndexOfImpl<sbyte>
	|
	|-RVA: 0xFA1990 Offset: 0xFA0390 VA: 0x180FA1990
	|-Array.IndexOfImpl<SamplePointUData>
	|
	|-RVA: 0xFA1B20 Offset: 0xFA0520 VA: 0x180FA1B20
	|-Array.IndexOfImpl<SamplePointsPatch>
	|
	|-RVA: 0xFA1CA0 Offset: 0xFA06A0 VA: 0x180FA1CA0
	|-Array.IndexOfImpl<Scene>
	|
	|-RVA: 0xFA1E20 Offset: 0xFA0820 VA: 0x180FA1E20
	|-Array.IndexOfImpl<SelectorMatchRecord>
	|
	|-RVA: 0xFA27D0 Offset: 0xFA11D0 VA: 0x180FA27D0
	|-Array.IndexOfImpl<ShaderTagId>
	|
	|-RVA: 0xFA2C70 Offset: 0xFA1670 VA: 0x180FA2C70
	|-Array.IndexOfImpl<float>
	|
	|-RVA: 0xFA3440 Offset: 0xFA1E40 VA: 0x180FA3440
	|-Array.IndexOfImpl<StylePropertyName>
	|
	|-RVA: 0xFA35D0 Offset: 0xFA1FD0 VA: 0x180FA35D0
	|-Array.IndexOfImpl<StylePropertyValue>
	|
	|-RVA: 0xFA3760 Offset: 0xFA2160 VA: 0x180FA3760
	|-Array.IndexOfImpl<StyleSelectorPart>
	|
	|-RVA: 0xFA3900 Offset: 0xFA2300 VA: 0x180FA3900
	|-Array.IndexOfImpl<StyleSyntaxToken>
	|
	|-RVA: 0xFA3C30 Offset: 0xFA2630 VA: 0x180FA3C30
	|-Array.IndexOfImpl<StyleValue>
	|
	|-RVA: 0xFA3AA0 Offset: 0xFA24A0 VA: 0x180FA3AA0
	|-Array.IndexOfImpl<StyleValueManaged>
	|
	|-RVA: 0xFA3DD0 Offset: 0xFA27D0 VA: 0x180FA3DD0
	|-Array.IndexOfImpl<StyleVariable>
	|
	|-RVA: 0xFA4100 Offset: 0xFA2B00 VA: 0x180FA4100
	|-Array.IndexOfImpl<Substring>
	|
	|-RVA: 0xFA45B0 Offset: 0xFA2FB0 VA: 0x180FA45B0
	|-Array.IndexOfImpl<TimeSpan>
	|
	|-RVA: 0xFA4730 Offset: 0xFA3130 VA: 0x180FA4730
	|-Array.IndexOfImpl<TimeValue>
	|
	|-RVA: 0xFA4A40 Offset: 0xFA3440 VA: 0x180FA4A40
	|-Array.IndexOfImpl<TreeViewItemWrapper>
	|
	|-RVA: 0xFA4EF0 Offset: 0xFA38F0 VA: 0x180FA4EF0
	|-Array.IndexOfImpl<UICharInfo>
	|
	|-RVA: 0xFA5090 Offset: 0xFA3A90 VA: 0x180FA5090
	|-Array.IndexOfImpl<UILineInfo>
	|
	|-RVA: 0xFA5220 Offset: 0xFA3C20 VA: 0x180FA5220
	|-Array.IndexOfImpl<UIVertex>
	|
	|-RVA: 0xFA5400 Offset: 0xFA3E00 VA: 0x180FA5400
	|-Array.IndexOfImpl<ushort>
	|
	|-RVA: 0xFA5700 Offset: 0xFA4100 VA: 0x180FA5700
	|-Array.IndexOfImpl<uint>
	|
	|-RVA: 0xFA5580 Offset: 0xFA3F80 VA: 0x180FA5580
	|-Array.IndexOfImpl<UInt32Enum>
	|
	|-RVA: 0xFA5880 Offset: 0xFA4280 VA: 0x180FA5880
	|-Array.IndexOfImpl<ulong>
	|
	|-RVA: 0xFA5A00 Offset: 0xFA4400 VA: 0x180FA5A00
	|-Array.IndexOfImpl<UShort2>
	|
	|-RVA: 0xFA5B80 Offset: 0xFA4580 VA: 0x180FA5B80
	|-Array.IndexOfImpl<UnloadedScene>
	|
	|-RVA: 0xFA5D10 Offset: 0xFA4710 VA: 0x180FA5D10
	|-Array.IndexOfImpl<UsageHint>
	|
	|-RVA: 0xFA6E40 Offset: 0xFA5840 VA: 0x180FA6E40
	|-Array.IndexOfImpl<Vector2>
	|
	|-RVA: 0xFA6FD0 Offset: 0xFA59D0 VA: 0x180FA6FD0
	|-Array.IndexOfImpl<Vector3>
	|
	|-RVA: 0xFA7170 Offset: 0xFA5B70 VA: 0x180FA7170
	|-Array.IndexOfImpl<Vector4>
	|
	|-RVA: 0xFA7680 Offset: 0xFA6080 VA: 0x180FA7680
	|-Array.IndexOfImpl<VoxelContour>
	|
	|-RVA: 0xFA79C0 Offset: 0xFA63C0 VA: 0x180FA79C0
	|-Array.IndexOfImpl<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xFA7D60 Offset: 0xFA6760 VA: 0x180FA7D60
	|-Array.IndexOfImpl<X509ChainStatus>
	|
	|-RVA: 0xFA7EF0 Offset: 0xFA68F0 VA: 0x180FA7EF0
	|-Array.IndexOfImpl<XRFeatureDescriptor>
	|
	|-RVA: 0xFA8090 Offset: 0xFA6A90 VA: 0x180FA8090
	|-Array.IndexOfImpl<XRView>
	|
	|-RVA: 0xFA8420 Offset: 0xFA6E20 VA: 0x180FA8420
	|-Array.IndexOfImpl<ZipGenericExtraField>
	|
	|-RVA: 0xF973D0 Offset: 0xF95DD0 VA: 0x180F973D0
	|-Array.IndexOfImpl<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xFA2950 Offset: 0xFA1350 VA: 0x180FA2950
	|-Array.IndexOfImpl<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>
	|
	|-RVA: 0xFA4D60 Offset: 0xFA3760 VA: 0x180FA4D60
	|-Array.IndexOfImpl<AdvancedSmooth.Turn>
	|
	|-RVA: 0xFA7820 Offset: 0xFA6220 VA: 0x180FA7820
	|-Array.IndexOfImpl<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0xF9A350 Offset: 0xF98D50 VA: 0x180F9A350
	|-Array.IndexOfImpl<AvatarSettings.LayerSetting>
	|
	|-RVA: 0xF9D840 Offset: 0xF9C240 VA: 0x180F9D840
	|-Array.IndexOfImpl<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0xF9DEA0 Offset: 0xF9C8A0 VA: 0x180F9DEA0
	|-Array.IndexOfImpl<BitmapAllocator32.Page>
	|
	|-RVA: 0xF93D90 Offset: 0xF92790 VA: 0x180F93D90
	|-Array.IndexOfImpl<CameraState.CustomBlendable>
	|
	|-RVA: 0xF9E1C0 Offset: 0xF9CBC0 VA: 0x180F9E1C0
	|-Array.IndexOfImpl<CinemachineClearShot.Pair>
	|
	|-RVA: 0xF970B0 Offset: 0xF95AB0 VA: 0x180F970B0
	|-Array.IndexOfImpl<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0xF94A20 Offset: 0xF93420 VA: 0x180F94A20
	|-Array.IndexOfImpl<ClipperLib.DoublePoint>
	|
	|-RVA: 0xF98670 Offset: 0xF97070 VA: 0x180F98670
	|-Array.IndexOfImpl<ClipperLib.IntPoint>
	|
	|-RVA: 0xF9ECF0 Offset: 0xF9D6F0 VA: 0x180F9ECF0
	|-Array.IndexOfImpl<ConfinerOven.PolygonSolution>
	|
	|-RVA: 0xF94230 Offset: 0xF92C30 VA: 0x180F94230
	|-Array.IndexOfImpl<DecalEntityIndexer.DecalEntityItem>
	|
	|-RVA: 0xF92870 Offset: 0xF91270 VA: 0x180F92870
	|-Array.IndexOfImpl<DecalEntityManager.CombinedChunks>
	|
	|-RVA: 0xF95A10 Offset: 0xF94410 VA: 0x180F95A10
	|-Array.IndexOfImpl<EventDispatcher.EventRecord>
	|
	|-RVA: 0xF95D30 Offset: 0xF94730 VA: 0x180F95D30
	|-Array.IndexOfImpl<FocusController.FocusedElement>
	|
	|-RVA: 0xF961F0 Offset: 0xF94BF0 VA: 0x180F961F0
	|-Array.IndexOfImpl<FrameTimingsHUDDisplay.FrameTimingPoint>
	|
	|-RVA: 0xF9E4E0 Offset: 0xF9CEE0 VA: 0x180F9E4E0
	|-Array.IndexOfImpl<Funnel.PathPart>
	|
	|-RVA: 0xFA7300 Offset: 0xFA5D00 VA: 0x180FA7300
	|-Array.IndexOfImpl<GodRaysRenderPass.VisibleLightRemap>
	|
	|-RVA: 0xF96540 Offset: 0xF94F40 VA: 0x180F96540
	|-Array.IndexOfImpl<GraphUpdateProcessor.GUOSingle>
	|
	|-RVA: 0xF96BB0 Offset: 0xF955B0 VA: 0x180F96BB0
	|-Array.IndexOfImpl<HID.HIDCollectionDescriptor>
	|
	|-RVA: 0xF96D50 Offset: 0xF95750 VA: 0x180F96D50
	|-Array.IndexOfImpl<HID.HIDElementDescriptor>
	|
	|-RVA: 0xF96F10 Offset: 0xF95910 VA: 0x180F96F10
	|-Array.IndexOfImpl<HIDParser.HIDReportData>
	|
	|-RVA: 0xF9F180 Offset: 0xF9DB80 VA: 0x180F9F180
	|-Array.IndexOfImpl<HeatmapManager.PropertyRegionReference>
	|
	|-RVA: 0xF90A20 Offset: 0xF8F420 VA: 0x180F90A20
	|-Array.IndexOfImpl<InputActionMap.BindingOverrideJson>
	|
	|-RVA: 0xF93200 Offset: 0xF91C00 VA: 0x180F93200
	|-Array.IndexOfImpl<InputControlLayout.ControlItem>
	|
	|-RVA: 0xFA48B0 Offset: 0xFA32B0 VA: 0x180FA48B0
	|-Array.IndexOfImpl<InputTransformSpots.TransformSpot>
	|
	|-RVA: 0xF994C0 Offset: 0xF97EC0 VA: 0x180F994C0
	|-Array.IndexOfImpl<JsonParser.JsonValue>
	|
	|-RVA: 0xF9B840 Offset: 0xF9A240 VA: 0x180F9B840
	|-Array.IndexOfImpl<LatencySimulator.Message>
	|
	|-RVA: 0xFA3120 Offset: 0xFA1B20 VA: 0x180FA3120
	|-Array.IndexOfImpl<MultiColumnCollectionHeader.SortedColumnState>
	|
	|-RVA: 0xFA4290 Offset: 0xFA2C90 VA: 0x180FA4290
	|-Array.IndexOfImpl<NativeMethods.TASKDIALOG_BUTTON>
	|
	|-RVA: 0xF9FCE0 Offset: 0xF9E6E0 VA: 0x180F9FCE0
	|-Array.IndexOfImpl<NetworkAnimator.ReceivedServerData>
	|
	|-RVA: 0xFA4BE0 Offset: 0xFA35E0 VA: 0x180FA4BE0
	|-Array.IndexOfImpl<NetworkAnimator.TriggerUpdate>
	|
	|-RVA: 0xF9D9D0 Offset: 0xF9C3D0 VA: 0x180F9D9D0
	|-Array.IndexOfImpl<OutlineEffect.OutlineTargetGroup>
	|
	|-RVA: 0xF91880 Offset: 0xF90280 VA: 0x180F91880
	|-Array.IndexOfImpl<PlayingCard.CardData>
	|
	|-RVA: 0xFA09D0 Offset: 0xF9F3D0 VA: 0x180FA09D0
	|-Array.IndexOfImpl<ProbeBrickIndex.ReservedBrick>
	|
	|-RVA: 0xF91090 Offset: 0xF8FA90 VA: 0x180F91090
	|-Array.IndexOfImpl<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xFA2630 Offset: 0xFA1030 VA: 0x180FA2630
	|-Array.IndexOfImpl<ProbeVolumePerSceneData.SerializablePerScenarioDataItem>
	|
	|-RVA: 0xFA1FC0 Offset: 0xFA09C0 VA: 0x180FA1FC0
	|-Array.IndexOfImpl<ProbeVolumeSceneData.SerializableBoundItem>
	|
	|-RVA: 0xFA2160 Offset: 0xFA0B60 VA: 0x180FA2160
	|-Array.IndexOfImpl<ProbeVolumeSceneData.SerializableHasPVItem>
	|
	|-RVA: 0xFA22F0 Offset: 0xFA0CF0 VA: 0x180FA22F0
	|-Array.IndexOfImpl<ProbeVolumeSceneData.SerializablePVBakeSettings>
	|
	|-RVA: 0xFA24A0 Offset: 0xFA0EA0 VA: 0x180FA24A0
	|-Array.IndexOfImpl<ProbeVolumeSceneData.SerializablePVProfile>
	|
	|-RVA: 0xFA2AF0 Offset: 0xFA14F0 VA: 0x180FA2AF0
	|-Array.IndexOfImpl<RegexCharClass.SingleRange>
	|
	|-RVA: 0xFA01A0 Offset: 0xF9EBA0 VA: 0x180FA01A0
	|-Array.IndexOfImpl<RenderChain.RenderNodeData>
	|
	|-RVA: 0xF9E340 Offset: 0xF9CD40 VA: 0x180F9E340
	|-Array.IndexOfImpl<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0xFA0D00 Offset: 0xF9F700 VA: 0x180FA0D00
	|-Array.IndexOfImpl<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0xF9B6A0 Offset: 0xF9A0A0 VA: 0x180F9B6A0
	|-Array.IndexOfImpl<RetainedGizmos.MeshWithHash>
	|
	|-RVA: 0xFA11B0 Offset: 0xF9FBB0 VA: 0x180FA11B0
	|-Array.IndexOfImpl<RigidbodyPauser.Rigidbody2DData>
	|
	|-RVA: 0xFA1350 Offset: 0xF9FD50 VA: 0x180FA1350
	|-Array.IndexOfImpl<RigidbodyPauser.RigidbodyData>
	|
	|-RVA: 0xF9B9E0 Offset: 0xF9A3E0 VA: 0x180F9B9E0
	|-Array.IndexOfImpl<RigidbodyPrediction.MoveData>
	|
	|-RVA: 0xF97230 Offset: 0xF95C30 VA: 0x180F97230
	|-Array.IndexOfImpl<SVGDocument.HierarchyUpdate>
	|
	|-RVA: 0xF9D040 Offset: 0xF9BA40 VA: 0x180F9D040
	|-Array.IndexOfImpl<SVGDocument.NodeReferenceData>
	|
	|-RVA: 0xF9D1E0 Offset: 0xF9BBE0 VA: 0x180F9D1E0
	|-Array.IndexOfImpl<SVGDocument.NodeWithParent>
	|
	|-RVA: 0xF9EE80 Offset: 0xF9D880 VA: 0x180F9EE80
	|-Array.IndexOfImpl<SVGDocument.PostponedClip>
	|
	|-RVA: 0xF9F000 Offset: 0xF9DA00 VA: 0x180F9F000
	|-Array.IndexOfImpl<SVGDocument.PostponedStopData>
	|
	|-RVA: 0xF92BB0 Offset: 0xF915B0 VA: 0x180F92BB0
	|-Array.IndexOfImpl<ServerSocket.ConnectionChange>
	|
	|-RVA: 0xF9BE90 Offset: 0xF9A890 VA: 0x180F9BE90
	|-Array.IndexOfImpl<SewerMushroomLocation.MushroomLocationData>
	|
	|-RVA: 0xF95380 Offset: 0xF93D80 VA: 0x180F95380
	|-Array.IndexOfImpl<ShadowUtility.Edge>
	|
	|-RVA: 0xF91D20 Offset: 0xF90720 VA: 0x180F91D20
	|-Array.IndexOfImpl<StructySync.ChangeData>
	|
	|-RVA: 0xF91BA0 Offset: 0xF905A0 VA: 0x180F91BA0
	|-Array.IndexOfImpl<SyncStopwatch.ChangeData>
	|
	|-RVA: 0xF91A00 Offset: 0xF90400 VA: 0x180F91A00
	|-Array.IndexOfImpl<SyncTimer.ChangeData>
	|
	|-RVA: 0xF916F0 Offset: 0xF900F0 VA: 0x180F916F0
	|-Array.IndexOfImpl<TargetStateListener.Callback>
	|
	|-RVA: 0xF903B0 Offset: 0xF8EDB0 VA: 0x180F903B0
	|-Array.IndexOfImpl<TemplateAsset.AttributeOverride>
	|
	|-RVA: 0xF95EC0 Offset: 0xF948C0 VA: 0x180F95EC0
	|-Array.IndexOfImpl<TextSettings.FontReferenceMap>
	|
	|-RVA: 0xF90BC0 Offset: 0xF8F5C0 VA: 0x180F90BC0
	|-Array.IndexOfImpl<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xF96390 Offset: 0xF94D90 VA: 0x180F96390
	|-Array.IndexOfImpl<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xFA4420 Offset: 0xFA2E20 VA: 0x180FA4420
	|-Array.IndexOfImpl<TextureRegistry.TextureInfo>
	|
	|-RVA: 0xF9D370 Offset: 0xF9BD70 VA: 0x180F9D370
	|-Array.IndexOfImpl<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0xF9F7D0 Offset: 0xF9E1D0 VA: 0x180F9F7D0
	|-Array.IndexOfImpl<TrackedDeviceRaycaster.RaycastHitData>
	|
	|-RVA: 0xF94560 Offset: 0xF92F60 VA: 0x180F94560
	|-Array.IndexOfImpl<TransportManager.DisconnectingClient>
	|
	|-RVA: 0xF956C0 Offset: 0xF940C0 VA: 0x180F956C0
	|-Array.IndexOfImpl<UIRStylePainter.Entry>
	|
	|-RVA: 0xFA0830 Offset: 0xF9F230 VA: 0x180FA0830
	|-Array.IndexOfImpl<UIRStylePainter.RepeatRectUV>
	|
	|-RVA: 0xF8FA10 Offset: 0xF8E410 VA: 0x180F8FA10
	|-Array.IndexOfImpl<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xF8FBB0 Offset: 0xF8E5B0 VA: 0x180F8FBB0
	|-Array.IndexOfImpl<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xFA7BC0 Offset: 0xFA65C0 VA: 0x180FA7BC0
	|-Array.IndexOfImpl<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0xF90080 Offset: 0xF8EA80 VA: 0x180F90080
	|-Array.IndexOfImpl<VisualTreeAsset.AssetEntry>
	|
	|-RVA: 0xFA2E00 Offset: 0xFA1800 VA: 0x180FA2E00
	|-Array.IndexOfImpl<VisualTreeAsset.SlotDefinition>
	|
	|-RVA: 0xFA2F90 Offset: 0xFA1990 VA: 0x180FA2F90
	|-Array.IndexOfImpl<VisualTreeAsset.SlotUsageEntry>
	|
	|-RVA: 0xFA5E90 Offset: 0xFA4890 VA: 0x180FA5E90
	|-Array.IndexOfImpl<VisualTreeAsset.UsingEntry>
	|
	|-RVA: 0xFA6030 Offset: 0xFA4A30 VA: 0x180FA6030
	|-Array.IndexOfImpl<VisualTreeAsset.UxmlObjectEntry>
	|
	|-RVA: 0xFA8290 Offset: 0xFA6C90 VA: 0x180FA8290
	|-Array.IndexOfImpl<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0xFA74E0 Offset: 0xFA5EE0 VA: 0x180FA74E0
	|-Array.IndexOfImpl<DebugDisplaySettingsVolume.WidgetFactory.VolumeParameterChain>
	|
	|-RVA: 0xF92ED0 Offset: 0xF918D0 VA: 0x180F92ED0
	|-Array.IndexOfImpl<DebugUI.Foldout.ContextMenuItem>
	|
	|-RVA: 0xF9A4F0 Offset: 0xF98EF0 VA: 0x180F9A4F0
	|-Array.IndexOfImpl<InputControlLayout.Collection.LayoutMatcher>
	|
	|-RVA: 0xF97A10 Offset: 0xF96410 VA: 0x180F97A10
	|-Array.IndexOfImpl<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0xF924F0 Offset: 0xF90EF0 VA: 0x180F924F0
	|-Array.IndexOfImpl<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xF99180 Offset: 0xF97B80 VA: 0x180F99180
	|-Array.IndexOfImpl<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0xF9FE70 Offset: 0xF9E870 VA: 0x180F9FE70
	|-Array.IndexOfImpl<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: -1 Offset: -1
	private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEEBF0 Offset: 0xDED5F0 VA: 0x180DEEBF0
	|-Array.LastIndexOfImpl<int>
	|
	|-RVA: 0xDEEA70 Offset: 0xDED470 VA: 0x180DEEA70
	|-Array.LastIndexOfImpl<Int32Enum>
	|
	|-RVA: 0xDEEEF0 Offset: 0xDED8F0 VA: 0x180DEEEF0
	|-Array.LastIndexOfImpl<Matrix4x4>
	|
	|-RVA: 0xDEF3C0 Offset: 0xDEDDC0 VA: 0x180DEF3C0
	|-Array.LastIndexOfImpl<object>
	|
	|-RVA: 0xDEF0A0 Offset: 0xDEDAA0 VA: 0x180DEF0A0
	|-Array.LastIndexOfImpl<Rect>
	|
	|-RVA: 0xDEF6E0 Offset: 0xDEE0E0 VA: 0x180DEF6E0
	|-Array.LastIndexOfImpl<TextureId>
	|
	|-RVA: 0xDEF860 Offset: 0xDEE260 VA: 0x180DEF860
	|-Array.LastIndexOfImpl<Vector2>
	|
	|-RVA: 0xDEE930 Offset: 0xDED330 VA: 0x180DEE930
	|-Array.LastIndexOfImpl<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDEED70 Offset: 0xDED770 VA: 0x180DEED70
	|-Array.LastIndexOfImpl<BaseStyleMatcher.MatchContext>
	|
	|-RVA: 0xDEE7A0 Offset: 0xDED1A0 VA: 0x180DEE7A0
	|-Array.LastIndexOfImpl<EventDispatcher.DispatchContext>
	|
	|-RVA: 0xDEE600 Offset: 0xDED000 VA: 0x180DEE600
	|-Array.LastIndexOfImpl<ProbeBrickPool.BrickChunkAlloc>
	|
	|-RVA: 0xDEF540 Offset: 0xDEDF40 VA: 0x180DEF540
	|-Array.LastIndexOfImpl<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0xDEF230 Offset: 0xDEDC30 VA: 0x180DEF230
	|-Array.LastIndexOfImpl<StyleVariableResolver.ResolveContext>
	|
	|-RVA: 0xDEE470 Offset: 0xDECE70 VA: 0x180DEE470
	|-Array.LastIndexOfImpl<BindingRestrictions.TestBuilder.AndNode>
	*/

	// RVA: 0x1C7E3C0 Offset: 0x1C7CDC0 VA: 0x181C7E3C0
	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	internal static T UnsafeLoad<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE45AD0 Offset: 0xE444D0 VA: 0x180E45AD0
	|-Array.UnsafeLoad<object>
	|
	|-RVA: 0xE45A00 Offset: 0xE44400 VA: 0x180E45A00
	|-Array.UnsafeLoad<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void UnsafeStore<T>(T[] array, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE45BC0 Offset: 0xE445C0 VA: 0x180E45BC0
	|-Array.UnsafeStore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static R UnsafeMov<S, R>(S instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE45B00 Offset: 0xE44500 VA: 0x180E45B00
	|-Array.UnsafeMov<ByteEnum, int>
	|
	|-RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	|-Array.UnsafeMov<Int32Enum, int>
	|-Array.UnsafeMov<UInt32Enum, int>
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-Array.UnsafeMov<object, object>
	|
	|-RVA: 0xE45B10 Offset: 0xE44510 VA: 0x180E45B10
	|-Array.UnsafeMov<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}
