public struct Nullable<T> // TypeDefIndex: 3699
{
	// Fields
	private readonly bool hasValue; // 0x0
	internal T value; // 0x0

	// Properties
	public bool HasValue { get; }
	public T Value { get; }

	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10AC5B0 Offset: 0x10AAFB0 VA: 0x1810AC5B0
	|-Nullable<SyncVar.CachedOnChange<bool>>..ctor
	|
	|-RVA: 0x10AC270 Offset: 0x10AAC70 VA: 0x1810AC270
	|-Nullable<SyncVar.CachedOnChange<int>>..ctor
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>..ctor
	|-Nullable<SyncVar.CachedOnChange<float>>..ctor
	|-Nullable<RenderQueueRange>..ctor
	|-Nullable<Vector2>..ctor
	|-Nullable<BlitUtility.MeshSetupResult>..ctor
	|
	|-RVA: 0x10AC3F0 Offset: 0x10AADF0 VA: 0x1810AC3F0
	|-Nullable<SyncVar.CachedOnChange<object>>..ctor
	|-Nullable<ReadOnlyArray<object>>..ctor
	|-Nullable<SubArray<CGSpot>>..ctor
	|-Nullable<SubArray<int>>..ctor
	|-Nullable<InputUserAccountHandle>..ctor
	|-Nullable<StreamingContext>..ctor
	|-Nullable<InputAction.CallbackContext>..ctor
	|
	|-RVA: 0x10AC420 Offset: 0x10AAE20 VA: 0x1810AC420
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>..ctor
	|
	|-RVA: 0x10AC1A0 Offset: 0x10AABA0 VA: 0x1810AC1A0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>..ctor
	|-Nullable<Bounds>..ctor
	|
	|-RVA: 0x10AC520 Offset: 0x10AAF20 VA: 0x1810AC520
	|-Nullable<NativeArray<RenderStateBlock>>..ctor
	|-Nullable<NativeArray<ShaderTagId>>..ctor
	|-Nullable<DateTimeOffset>..ctor
	|-Nullable<Decimal>..ctor
	|-Nullable<PrimitiveValue>..ctor
	|
	|-RVA: 0x10AC150 Offset: 0x10AAB50 VA: 0x1810AC150
	|-Nullable<BigInteger>..ctor
	|-Nullable<DisconnectInfo>..ctor
	|-Nullable<LocalDefinition>..ctor
	|-Nullable<RegexPrefix>..ctor
	|-Nullable<InputRemoting.Message>..ctor
	|
	|-RVA: 0x10AC440 Offset: 0x10AAE40 VA: 0x1810AC440
	|-Nullable<bool>..ctor
	|-Nullable<byte>..ctor
	|-Nullable<ByteEnum>..ctor
	|-Nullable<sbyte>..ctor
	|
	|-RVA: 0x10AC1C0 Offset: 0x10AABC0 VA: 0x1810AC1C0
	|-Nullable<char>..ctor
	|-Nullable<short>..ctor
	|-Nullable<Int16Enum>..ctor
	|-Nullable<ushort>..ctor
	|
	|-RVA: 0x10AC4F0 Offset: 0x10AAEF0 VA: 0x1810AC4F0
	|-Nullable<Color>..ctor
	|-Nullable<InputControlScheme>..ctor
	|
	|-RVA: 0x10AC190 Offset: 0x10AAB90 VA: 0x1810AC190
	|-Nullable<Color>..ctor
	|-Nullable<Guid>..ctor
	|-Nullable<Quaternion>..ctor
	|-Nullable<Rect>..ctor
	|-Nullable<Vector4>..ctor
	|
	|-RVA: 0x10AC550 Offset: 0x10AAF50 VA: 0x1810AC550
	|-Nullable<DataKey>..ctor
	|-Nullable<EventDispatcherGate>..ctor
	|-Nullable<InputDeviceMatcher>..ctor
	|-Nullable<SqlBinary>..ctor
	|
	|-RVA: 0x10AC180 Offset: 0x10AAB80 VA: 0x1810AC180
	|-Nullable<DateTime>..ctor
	|-Nullable<long>..ctor
	|-Nullable<TimeSpan>..ctor
	|-Nullable<ulong>..ctor
	|
	|-RVA: 0x10AC610 Offset: 0x10AB010 VA: 0x1810AC610
	|-Nullable<double>..ctor
	|
	|-RVA: 0x10AC580 Offset: 0x10AAF80 VA: 0x1810AC580
	|-Nullable<GlobalDynamicResolutionSettings>..ctor
	|
	|-RVA: 0x10AC280 Offset: 0x10AAC80 VA: 0x1810AC280
	|-Nullable<InputBinding>..ctor
	|
	|-RVA: 0x10AC110 Offset: 0x10AAB10 VA: 0x1810AC110
	|-Nullable<InputUser>..ctor
	|-Nullable<int>..ctor
	|-Nullable<Int32Enum>..ctor
	|-Nullable<uint>..ctor
	|
	|-RVA: 0x10AC120 Offset: 0x10AAB20 VA: 0x1810AC120
	|-Nullable<JsonPosition>..ctor
	|
	|-RVA: 0x10AC620 Offset: 0x10AB020 VA: 0x1810AC620
	|-Nullable<Prefs>..ctor
	|
	|-RVA: 0x10AC670 Offset: 0x10AB070 VA: 0x1810AC670
	|-Nullable<RenderStateBlock>..ctor
	|
	|-RVA: 0x10AC450 Offset: 0x10AAE50 VA: 0x1810AC450
	|-Nullable<RenderTargetIdentifier>..ctor
	|
	|-RVA: 0x10AC6C0 Offset: 0x10AB0C0 VA: 0x1810AC6C0
	|-Nullable<float>..ctor
	|
	|-RVA: 0x10AC530 Offset: 0x10AAF30 VA: 0x1810AC530
	|-Nullable<Token>..ctor
	|-Nullable<Vector3>..ctor
	|
	|-RVA: 0x10AC2D0 Offset: 0x10AACD0 VA: 0x1810AC2D0
	|-Nullable<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x10AC470 Offset: 0x10AAE70 VA: 0x1810AC470
	|-Nullable<Icon.IconDirEntry>..ctor
	|
	|-RVA: 0x10AC490 Offset: 0x10AAE90 VA: 0x1810AC490
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>..ctor
	|
	|-RVA: 0x10AC1D0 Offset: 0x10AABD0 VA: 0x1810AC1D0
	|-Nullable<InputControlLayout.ControlItem>..ctor
	|
	|-RVA: 0x10AC5C0 Offset: 0x10AAFC0 VA: 0x1810AC5C0
	|-Nullable<InputControlScheme.MatchResult>..ctor
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C5450 Offset: 0x4C3E50 VA: 0x1804C5450
	|-Nullable<SyncVar.CachedOnChange<bool>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<int>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<object>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<float>>.get_HasValue
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.get_HasValue
	|-Nullable<NativeArray<RenderStateBlock>>.get_HasValue
	|-Nullable<NativeArray<ShaderTagId>>.get_HasValue
	|-Nullable<ReadOnlyArray<object>>.get_HasValue
	|-Nullable<SubArray<CGSpot>>.get_HasValue
	|-Nullable<SubArray<int>>.get_HasValue
	|-Nullable<BigInteger>.get_HasValue
	|-Nullable<bool>.get_HasValue
	|-Nullable<Bounds>.get_HasValue
	|-Nullable<byte>.get_HasValue
	|-Nullable<ByteEnum>.get_HasValue
	|-Nullable<char>.get_HasValue
	|-Nullable<Color>.get_HasValue
	|-Nullable<Color>.get_HasValue
	|-Nullable<DataKey>.get_HasValue
	|-Nullable<DateTime>.get_HasValue
	|-Nullable<DateTimeOffset>.get_HasValue
	|-Nullable<Decimal>.get_HasValue
	|-Nullable<DisconnectInfo>.get_HasValue
	|-Nullable<double>.get_HasValue
	|-Nullable<EventDispatcherGate>.get_HasValue
	|-Nullable<GlobalDynamicResolutionSettings>.get_HasValue
	|-Nullable<Guid>.get_HasValue
	|-Nullable<InputBinding>.get_HasValue
	|-Nullable<InputControlScheme>.get_HasValue
	|-Nullable<InputDeviceMatcher>.get_HasValue
	|-Nullable<InputUser>.get_HasValue
	|-Nullable<InputUserAccountHandle>.get_HasValue
	|-Nullable<short>.get_HasValue
	|-Nullable<Int16Enum>.get_HasValue
	|-Nullable<int>.get_HasValue
	|-Nullable<Int32Enum>.get_HasValue
	|-Nullable<long>.get_HasValue
	|-Nullable<JsonPosition>.get_HasValue
	|-Nullable<LocalDefinition>.get_HasValue
	|-Nullable<Prefs>.get_HasValue
	|-Nullable<PrimitiveValue>.get_HasValue
	|-Nullable<Quaternion>.get_HasValue
	|-Nullable<Rect>.get_HasValue
	|-Nullable<RegexPrefix>.get_HasValue
	|-Nullable<RenderQueueRange>.get_HasValue
	|-Nullable<RenderStateBlock>.get_HasValue
	|-Nullable<RenderTargetIdentifier>.get_HasValue
	|-Nullable<sbyte>.get_HasValue
	|-Nullable<float>.get_HasValue
	|-Nullable<SqlBinary>.get_HasValue
	|-Nullable<StreamingContext>.get_HasValue
	|-Nullable<TimeSpan>.get_HasValue
	|-Nullable<Token>.get_HasValue
	|-Nullable<ushort>.get_HasValue
	|-Nullable<uint>.get_HasValue
	|-Nullable<ulong>.get_HasValue
	|-Nullable<Vector2>.get_HasValue
	|-Nullable<Vector3>.get_HasValue
	|-Nullable<Vector4>.get_HasValue
	|-Nullable<BlitUtility.MeshSetupResult>.get_HasValue
	|-Nullable<Icon.IconDirEntry>.get_HasValue
	|-Nullable<InputAction.CallbackContext>.get_HasValue
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.get_HasValue
	|-Nullable<InputControlLayout.ControlItem>.get_HasValue
	|-Nullable<InputControlScheme.MatchResult>.get_HasValue
	|-Nullable<InputRemoting.Message>.get_HasValue
	|
	|-RVA: 0x10AC6D0 Offset: 0x10AB0D0 VA: 0x1810AC6D0
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ACA40 Offset: 0x10AB440 VA: 0x1810ACA40
	|-Nullable<SyncVar.CachedOnChange<bool>>.get_Value
	|
	|-RVA: 0x10AC900 Offset: 0x10AB300 VA: 0x1810AC900
	|-Nullable<SyncVar.CachedOnChange<int>>.get_Value
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.get_Value
	|-Nullable<RenderQueueRange>.get_Value
	|-Nullable<BlitUtility.MeshSetupResult>.get_Value
	|
	|-RVA: 0x10AC7F0 Offset: 0x10AB1F0 VA: 0x1810AC7F0
	|-Nullable<SyncVar.CachedOnChange<object>>.get_Value
	|-Nullable<NativeArray<RenderStateBlock>>.get_Value
	|-Nullable<NativeArray<ShaderTagId>>.get_Value
	|-Nullable<ReadOnlyArray<object>>.get_Value
	|-Nullable<SubArray<CGSpot>>.get_Value
	|-Nullable<SubArray<int>>.get_Value
	|-Nullable<BigInteger>.get_Value
	|-Nullable<DateTimeOffset>.get_Value
	|-Nullable<Decimal>.get_Value
	|-Nullable<DisconnectInfo>.get_Value
	|-Nullable<InputUserAccountHandle>.get_Value
	|-Nullable<LocalDefinition>.get_Value
	|-Nullable<PrimitiveValue>.get_Value
	|-Nullable<RegexPrefix>.get_Value
	|-Nullable<StreamingContext>.get_Value
	|-Nullable<InputAction.CallbackContext>.get_Value
	|-Nullable<InputRemoting.Message>.get_Value
	|
	|-RVA: 0x10ACEC0 Offset: 0x10AB8C0 VA: 0x1810ACEC0
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.get_Value
	|
	|-RVA: 0x10AC960 Offset: 0x10AB360 VA: 0x1810AC960
	|-Nullable<SyncVar.CachedOnChange<float>>.get_Value
	|-Nullable<Vector2>.get_Value
	|
	|-RVA: 0x10ACCA0 Offset: 0x10AB6A0 VA: 0x1810ACCA0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.get_Value
	|-Nullable<Bounds>.get_Value
	|
	|-RVA: 0x10AC930 Offset: 0x10AB330 VA: 0x1810AC930
	|-Nullable<bool>.get_Value
	|-Nullable<byte>.get_Value
	|-Nullable<ByteEnum>.get_Value
	|-Nullable<sbyte>.get_Value
	|
	|-RVA: 0x10AC7C0 Offset: 0x10AB1C0 VA: 0x1810AC7C0
	|-Nullable<char>.get_Value
	|-Nullable<short>.get_Value
	|-Nullable<Int16Enum>.get_Value
	|-Nullable<ushort>.get_Value
	|
	|-RVA: 0x10ACD40 Offset: 0x10AB740 VA: 0x1810ACD40
	|-Nullable<Color>.get_Value
	|-Nullable<InputControlScheme>.get_Value
	|-Nullable<JsonPosition>.get_Value
	|
	|-RVA: 0x10AC860 Offset: 0x10AB260 VA: 0x1810AC860
	|-Nullable<Color>.get_Value
	|-Nullable<Guid>.get_Value
	|-Nullable<Quaternion>.get_Value
	|-Nullable<Rect>.get_Value
	|-Nullable<Vector4>.get_Value
	|
	|-RVA: 0x10AC990 Offset: 0x10AB390 VA: 0x1810AC990
	|-Nullable<DataKey>.get_Value
	|-Nullable<DateTime>.get_Value
	|-Nullable<EventDispatcherGate>.get_Value
	|-Nullable<InputDeviceMatcher>.get_Value
	|-Nullable<long>.get_Value
	|-Nullable<SqlBinary>.get_Value
	|-Nullable<TimeSpan>.get_Value
	|-Nullable<ulong>.get_Value
	|
	|-RVA: 0x10AC830 Offset: 0x10AB230 VA: 0x1810AC830
	|-Nullable<double>.get_Value
	|
	|-RVA: 0x10ACC40 Offset: 0x10AB640 VA: 0x1810ACC40
	|-Nullable<GlobalDynamicResolutionSettings>.get_Value
	|
	|-RVA: 0x10AC8A0 Offset: 0x10AB2A0 VA: 0x1810AC8A0
	|-Nullable<InputBinding>.get_Value
	|
	|-RVA: 0x10AC790 Offset: 0x10AB190 VA: 0x1810AC790
	|-Nullable<InputUser>.get_Value
	|-Nullable<int>.get_Value
	|-Nullable<Int32Enum>.get_Value
	|-Nullable<uint>.get_Value
	|
	|-RVA: 0x10ACCE0 Offset: 0x10AB6E0 VA: 0x1810ACCE0
	|-Nullable<Prefs>.get_Value
	|
	|-RVA: 0x10AC720 Offset: 0x10AB120 VA: 0x1810AC720
	|-Nullable<RenderStateBlock>.get_Value
	|
	|-RVA: 0x10ACA70 Offset: 0x10AB470 VA: 0x1810ACA70
	|-Nullable<RenderTargetIdentifier>.get_Value
	|
	|-RVA: 0x10ACE90 Offset: 0x10AB890 VA: 0x1810ACE90
	|-Nullable<float>.get_Value
	|
	|-RVA: 0x10ACA00 Offset: 0x10AB400 VA: 0x1810ACA00
	|-Nullable<Token>.get_Value
	|-Nullable<Vector3>.get_Value
	|
	|-RVA: 0x10ACAC0 Offset: 0x10AB4C0 VA: 0x1810ACAC0
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_Value
	|
	|-RVA: 0x10AC9C0 Offset: 0x10AB3C0 VA: 0x1810AC9C0
	|-Nullable<Icon.IconDirEntry>.get_Value
	|
	|-RVA: 0x10ACBD0 Offset: 0x10AB5D0 VA: 0x1810ACBD0
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.get_Value
	|
	|-RVA: 0x10ACDE0 Offset: 0x10AB7E0 VA: 0x1810ACDE0
	|-Nullable<InputControlLayout.ControlItem>.get_Value
	|
	|-RVA: 0x10ACD80 Offset: 0x10AB780 VA: 0x1810ACD80
	|-Nullable<InputControlScheme.MatchResult>.get_Value
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109FEA0 Offset: 0x109E8A0 VA: 0x18109FEA0
	|-Nullable<SyncVar.CachedOnChange<bool>>.GetValueOrDefault
	|
	|-RVA: 0x109F800 Offset: 0x109E200 VA: 0x18109F800
	|-Nullable<SyncVar.CachedOnChange<int>>.GetValueOrDefault
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.GetValueOrDefault
	|-Nullable<RenderQueueRange>.GetValueOrDefault
	|-Nullable<BlitUtility.MeshSetupResult>.GetValueOrDefault
	|
	|-RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	|-Nullable<SyncVar.CachedOnChange<object>>.GetValueOrDefault
	|-Nullable<NativeArray<RenderStateBlock>>.GetValueOrDefault
	|-Nullable<NativeArray<ShaderTagId>>.GetValueOrDefault
	|-Nullable<ReadOnlyArray<object>>.GetValueOrDefault
	|-Nullable<SubArray<CGSpot>>.GetValueOrDefault
	|-Nullable<SubArray<int>>.GetValueOrDefault
	|-Nullable<BigInteger>.GetValueOrDefault
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|-Nullable<Decimal>.GetValueOrDefault
	|-Nullable<DisconnectInfo>.GetValueOrDefault
	|-Nullable<InputUserAccountHandle>.GetValueOrDefault
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|-Nullable<PrimitiveValue>.GetValueOrDefault
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|-Nullable<StreamingContext>.GetValueOrDefault
	|-Nullable<InputAction.CallbackContext>.GetValueOrDefault
	|-Nullable<InputRemoting.Message>.GetValueOrDefault
	|
	|-RVA: 0x109FAE0 Offset: 0x109E4E0 VA: 0x18109FAE0
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.GetValueOrDefault
	|
	|-RVA: 0x7BCB70 Offset: 0x7BB570 VA: 0x1807BCB70
	|-Nullable<SyncVar.CachedOnChange<float>>.GetValueOrDefault
	|-Nullable<Vector2>.GetValueOrDefault
	|
	|-RVA: 0x109F9C0 Offset: 0x109E3C0 VA: 0x18109F9C0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.GetValueOrDefault
	|-Nullable<Bounds>.GetValueOrDefault
	|
	|-RVA: 0x109F810 Offset: 0x109E210 VA: 0x18109F810
	|-Nullable<bool>.GetValueOrDefault
	|-Nullable<byte>.GetValueOrDefault
	|-Nullable<ByteEnum>.GetValueOrDefault
	|-Nullable<sbyte>.GetValueOrDefault
	|
	|-RVA: 0xCBDFC0 Offset: 0xCBC9C0 VA: 0x180CBDFC0
	|-Nullable<char>.GetValueOrDefault
	|-Nullable<short>.GetValueOrDefault
	|-Nullable<Int16Enum>.GetValueOrDefault
	|-Nullable<ushort>.GetValueOrDefault
	|
	|-RVA: 0x109F5E0 Offset: 0x109DFE0 VA: 0x18109F5E0
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<InputControlScheme>.GetValueOrDefault
	|-Nullable<JsonPosition>.GetValueOrDefault
	|
	|-RVA: 0x109F680 Offset: 0x109E080 VA: 0x18109F680
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<Guid>.GetValueOrDefault
	|-Nullable<Quaternion>.GetValueOrDefault
	|-Nullable<Rect>.GetValueOrDefault
	|-Nullable<Vector4>.GetValueOrDefault
	|
	|-RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	|-Nullable<DataKey>.GetValueOrDefault
	|-Nullable<DateTime>.GetValueOrDefault
	|-Nullable<EventDispatcherGate>.GetValueOrDefault
	|-Nullable<InputDeviceMatcher>.GetValueOrDefault
	|-Nullable<long>.GetValueOrDefault
	|-Nullable<SqlBinary>.GetValueOrDefault
	|-Nullable<TimeSpan>.GetValueOrDefault
	|-Nullable<ulong>.GetValueOrDefault
	|
	|-RVA: 0x109F850 Offset: 0x109E250 VA: 0x18109F850
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x109FE70 Offset: 0x109E870 VA: 0x18109FE70
	|-Nullable<GlobalDynamicResolutionSettings>.GetValueOrDefault
	|
	|-RVA: 0x109F7B0 Offset: 0x109E1B0 VA: 0x18109F7B0
	|-Nullable<InputBinding>.GetValueOrDefault
	|
	|-RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	|-Nullable<InputUser>.GetValueOrDefault
	|-Nullable<int>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|-Nullable<uint>.GetValueOrDefault
	|
	|-RVA: 0x109F610 Offset: 0x109E010 VA: 0x18109F610
	|-Nullable<Prefs>.GetValueOrDefault
	|
	|-RVA: 0x109F9E0 Offset: 0x109E3E0 VA: 0x18109F9E0
	|-Nullable<RenderStateBlock>.GetValueOrDefault
	|
	|-RVA: 0x109FEB0 Offset: 0x109E8B0 VA: 0x18109FEB0
	|-Nullable<RenderTargetIdentifier>.GetValueOrDefault
	|
	|-RVA: 0x474770 Offset: 0x473170 VA: 0x180474770
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x4FB270 Offset: 0x4F9C70 VA: 0x1804FB270
	|-Nullable<Token>.GetValueOrDefault
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x109FB50 Offset: 0x109E550 VA: 0x18109FB50
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	|
	|-RVA: 0x109F880 Offset: 0x109E280 VA: 0x18109F880
	|-Nullable<Icon.IconDirEntry>.GetValueOrDefault
	|
	|-RVA: 0x109FB00 Offset: 0x109E500 VA: 0x18109FB00
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.GetValueOrDefault
	|
	|-RVA: 0x109FDF0 Offset: 0x109E7F0 VA: 0x18109FDF0
	|-Nullable<InputControlLayout.ControlItem>.GetValueOrDefault
	|
	|-RVA: 0x109F780 Offset: 0x109E180 VA: 0x18109F780
	|-Nullable<InputControlScheme.MatchResult>.GetValueOrDefault
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109FED0 Offset: 0x109E8D0 VA: 0x18109FED0
	|-Nullable<SyncVar.CachedOnChange<bool>>.GetValueOrDefault
	|
	|-RVA: 0x109F740 Offset: 0x109E140 VA: 0x18109F740
	|-Nullable<SyncVar.CachedOnChange<int>>.GetValueOrDefault
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.GetValueOrDefault
	|-Nullable<RenderQueueRange>.GetValueOrDefault
	|-Nullable<BlitUtility.MeshSetupResult>.GetValueOrDefault
	|
	|-RVA: 0x109F4D0 Offset: 0x109DED0 VA: 0x18109F4D0
	|-Nullable<SyncVar.CachedOnChange<object>>.GetValueOrDefault
	|-Nullable<NativeArray<RenderStateBlock>>.GetValueOrDefault
	|-Nullable<NativeArray<ShaderTagId>>.GetValueOrDefault
	|-Nullable<ReadOnlyArray<object>>.GetValueOrDefault
	|-Nullable<SubArray<CGSpot>>.GetValueOrDefault
	|-Nullable<SubArray<int>>.GetValueOrDefault
	|-Nullable<BigInteger>.GetValueOrDefault
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|-Nullable<Decimal>.GetValueOrDefault
	|-Nullable<DisconnectInfo>.GetValueOrDefault
	|-Nullable<InputUserAccountHandle>.GetValueOrDefault
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|-Nullable<PrimitiveValue>.GetValueOrDefault
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|-Nullable<StreamingContext>.GetValueOrDefault
	|-Nullable<InputAction.CallbackContext>.GetValueOrDefault
	|-Nullable<InputRemoting.Message>.GetValueOrDefault
	|
	|-RVA: 0x109F820 Offset: 0x109E220 VA: 0x18109F820
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.GetValueOrDefault
	|
	|-RVA: 0x109FAC0 Offset: 0x109E4C0 VA: 0x18109FAC0
	|-Nullable<SyncVar.CachedOnChange<float>>.GetValueOrDefault
	|-Nullable<Vector2>.GetValueOrDefault
	|
	|-RVA: 0x109F5A0 Offset: 0x109DFA0 VA: 0x18109F5A0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.GetValueOrDefault
	|-Nullable<Bounds>.GetValueOrDefault
	|
	|-RVA: 0x109F5D0 Offset: 0x109DFD0 VA: 0x18109F5D0
	|-Nullable<bool>.GetValueOrDefault
	|-Nullable<byte>.GetValueOrDefault
	|-Nullable<ByteEnum>.GetValueOrDefault
	|-Nullable<sbyte>.GetValueOrDefault
	|
	|-RVA: 0x109F7F0 Offset: 0x109E1F0 VA: 0x18109F7F0
	|-Nullable<char>.GetValueOrDefault
	|-Nullable<short>.GetValueOrDefault
	|-Nullable<Int16Enum>.GetValueOrDefault
	|-Nullable<ushort>.GetValueOrDefault
	|
	|-RVA: 0x109F690 Offset: 0x109E090 VA: 0x18109F690
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<InputControlScheme>.GetValueOrDefault
	|-Nullable<JsonPosition>.GetValueOrDefault
	|
	|-RVA: 0x109F860 Offset: 0x109E260 VA: 0x18109F860
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<Guid>.GetValueOrDefault
	|-Nullable<Quaternion>.GetValueOrDefault
	|-Nullable<Rect>.GetValueOrDefault
	|-Nullable<Vector4>.GetValueOrDefault
	|
	|-RVA: 0x109F6C0 Offset: 0x109E0C0 VA: 0x18109F6C0
	|-Nullable<DataKey>.GetValueOrDefault
	|-Nullable<DateTime>.GetValueOrDefault
	|-Nullable<EventDispatcherGate>.GetValueOrDefault
	|-Nullable<InputDeviceMatcher>.GetValueOrDefault
	|-Nullable<long>.GetValueOrDefault
	|-Nullable<SqlBinary>.GetValueOrDefault
	|-Nullable<TimeSpan>.GetValueOrDefault
	|-Nullable<ulong>.GetValueOrDefault
	|
	|-RVA: 0x109F600 Offset: 0x109E000 VA: 0x18109F600
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x109FEE0 Offset: 0x109E8E0 VA: 0x18109FEE0
	|-Nullable<GlobalDynamicResolutionSettings>.GetValueOrDefault
	|
	|-RVA: 0x109FA40 Offset: 0x109E440 VA: 0x18109FA40
	|-Nullable<InputBinding>.GetValueOrDefault
	|
	|-RVA: 0x109F590 Offset: 0x109DF90 VA: 0x18109F590
	|-Nullable<InputUser>.GetValueOrDefault
	|-Nullable<int>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|-Nullable<uint>.GetValueOrDefault
	|
	|-RVA: 0x109F6D0 Offset: 0x109E0D0 VA: 0x18109F6D0
	|-Nullable<Prefs>.GetValueOrDefault
	|
	|-RVA: 0x109F4F0 Offset: 0x109DEF0 VA: 0x18109F4F0
	|-Nullable<RenderStateBlock>.GetValueOrDefault
	|
	|-RVA: 0x109FC30 Offset: 0x109E630 VA: 0x18109FC30
	|-Nullable<RenderTargetIdentifier>.GetValueOrDefault
	|
	|-RVA: 0x109FA30 Offset: 0x109E430 VA: 0x18109FA30
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x109F750 Offset: 0x109E150 VA: 0x18109F750
	|-Nullable<Token>.GetValueOrDefault
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x109F8A0 Offset: 0x109E2A0 VA: 0x18109F8A0
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	|
	|-RVA: 0x109F650 Offset: 0x109E050 VA: 0x18109F650
	|-Nullable<Icon.IconDirEntry>.GetValueOrDefault
	|
	|-RVA: 0x109FF40 Offset: 0x109E940 VA: 0x18109FF40
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.GetValueOrDefault
	|
	|-RVA: 0x109FC70 Offset: 0x109E670 VA: 0x18109FC70
	|-Nullable<InputControlLayout.ControlItem>.GetValueOrDefault
	|
	|-RVA: 0x109FD90 Offset: 0x109E790 VA: 0x18109FD90
	|-Nullable<InputControlScheme.MatchResult>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D890 Offset: 0x109C290 VA: 0x18109D890
	|-Nullable<SyncVar.CachedOnChange<bool>>.Equals
	|
	|-RVA: 0x109B9B0 Offset: 0x109A3B0 VA: 0x18109B9B0
	|-Nullable<SyncVar.CachedOnChange<int>>.Equals
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.Equals
	|-Nullable<BlitUtility.MeshSetupResult>.Equals
	|
	|-RVA: 0x109B7A0 Offset: 0x109A1A0 VA: 0x18109B7A0
	|-Nullable<SyncVar.CachedOnChange<object>>.Equals
	|-Nullable<ReadOnlyArray<object>>.Equals
	|-Nullable<DisconnectInfo>.Equals
	|-Nullable<RegexPrefix>.Equals
	|-Nullable<InputAction.CallbackContext>.Equals
	|-Nullable<InputRemoting.Message>.Equals
	|
	|-RVA: 0x109B4C0 Offset: 0x1099EC0 VA: 0x18109B4C0
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.Equals
	|
	|-RVA: 0x109C620 Offset: 0x109B020 VA: 0x18109C620
	|-Nullable<SyncVar.CachedOnChange<float>>.Equals
	|
	|-RVA: 0x109C6D0 Offset: 0x109B0D0 VA: 0x18109C6D0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.Equals
	|
	|-RVA: 0x109B730 Offset: 0x109A130 VA: 0x18109B730
	|-Nullable<NativeArray<RenderStateBlock>>.Equals
	|-Nullable<NativeArray<ShaderTagId>>.Equals
	|
	|-RVA: 0x109B2D0 Offset: 0x1099CD0 VA: 0x18109B2D0
	|-Nullable<SubArray<CGSpot>>.Equals
	|-Nullable<SubArray<int>>.Equals
	|
	|-RVA: 0x109B400 Offset: 0x1099E00 VA: 0x18109B400
	|-Nullable<BigInteger>.Equals
	|
	|-RVA: 0x109BEC0 Offset: 0x109A8C0 VA: 0x18109BEC0
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x109BA50 Offset: 0x109A450 VA: 0x18109BA50
	|-Nullable<Bounds>.Equals
	|
	|-RVA: 0x109C780 Offset: 0x109B180 VA: 0x18109C780
	|-Nullable<byte>.Equals
	|
	|-RVA: 0x109CE80 Offset: 0x109B880 VA: 0x18109CE80
	|-Nullable<ByteEnum>.Equals
	|
	|-RVA: 0x109C560 Offset: 0x109AF60 VA: 0x18109C560
	|-Nullable<char>.Equals
	|
	|-RVA: 0x109D930 Offset: 0x109C330 VA: 0x18109D930
	|-Nullable<Color>.Equals
	|
	|-RVA: 0x109CD50 Offset: 0x109B750 VA: 0x18109CD50
	|-Nullable<Color>.Equals
	|
	|-RVA: 0x109D610 Offset: 0x109C010 VA: 0x18109D610
	|-Nullable<DataKey>.Equals
	|
	|-RVA: 0x109C240 Offset: 0x109AC40 VA: 0x18109C240
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x109BE00 Offset: 0x109A800 VA: 0x18109BE00
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x109D180 Offset: 0x109BB80 VA: 0x18109D180
	|-Nullable<Decimal>.Equals
	|
	|-RVA: 0x109BCD0 Offset: 0x109A6D0 VA: 0x18109BCD0
	|-Nullable<double>.Equals
	|
	|-RVA: 0x109D730 Offset: 0x109C130 VA: 0x18109D730
	|-Nullable<EventDispatcherGate>.Equals
	|
	|-RVA: 0x109BC00 Offset: 0x109A600 VA: 0x18109BC00
	|-Nullable<GlobalDynamicResolutionSettings>.Equals
	|
	|-RVA: 0x109BF80 Offset: 0x109A980 VA: 0x18109BF80
	|-Nullable<Guid>.Equals
	|
	|-RVA: 0x109B0E0 Offset: 0x1099AE0 VA: 0x18109B0E0
	|-Nullable<InputBinding>.Equals
	|
	|-RVA: 0x109CA80 Offset: 0x109B480 VA: 0x18109CA80
	|-Nullable<InputControlScheme>.Equals
	|
	|-RVA: 0x109CB60 Offset: 0x109B560 VA: 0x18109CB60
	|-Nullable<InputDeviceMatcher>.Equals
	|
	|-RVA: 0x109BD40 Offset: 0x109A740 VA: 0x18109BD40
	|-Nullable<InputUser>.Equals
	|
	|-RVA: 0x109CC20 Offset: 0x109B620 VA: 0x18109CC20
	|-Nullable<InputUserAccountHandle>.Equals
	|
	|-RVA: 0x109BB90 Offset: 0x109A590 VA: 0x18109BB90
	|-Nullable<short>.Equals
	|
	|-RVA: 0x109C370 Offset: 0x109AD70 VA: 0x18109C370
	|-Nullable<Int16Enum>.Equals
	|
	|-RVA: 0x109B6C0 Offset: 0x109A0C0 VA: 0x18109B6C0
	|-Nullable<int>.Equals
	|
	|-RVA: 0x109C1A0 Offset: 0x109ABA0 VA: 0x18109C1A0
	|-Nullable<Int32Enum>.Equals
	|
	|-RVA: 0x109B650 Offset: 0x109A050 VA: 0x18109B650
	|-Nullable<long>.Equals
	|
	|-RVA: 0x109D560 Offset: 0x109BF60 VA: 0x18109D560
	|-Nullable<JsonPosition>.Equals
	|
	|-RVA: 0x109B570 Offset: 0x1099F70 VA: 0x18109B570
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x109D7A0 Offset: 0x109C1A0 VA: 0x18109D7A0
	|-Nullable<Prefs>.Equals
	|
	|-RVA: 0x109CAF0 Offset: 0x109B4F0 VA: 0x18109CAF0
	|-Nullable<PrimitiveValue>.Equals
	|
	|-RVA: 0x109CF20 Offset: 0x109B920 VA: 0x18109CF20
	|-Nullable<Quaternion>.Equals
	|
	|-RVA: 0x109D240 Offset: 0x109BC40 VA: 0x18109D240
	|-Nullable<Rect>.Equals
	|
	|-RVA: 0x109B840 Offset: 0x109A240 VA: 0x18109B840
	|-Nullable<RenderQueueRange>.Equals
	|
	|-RVA: 0x109B260 Offset: 0x1099C60 VA: 0x18109B260
	|-Nullable<RenderStateBlock>.Equals
	|
	|-RVA: 0x109D4F0 Offset: 0x109BEF0 VA: 0x18109D4F0
	|-Nullable<RenderTargetIdentifier>.Equals
	|
	|-RVA: 0x109C4F0 Offset: 0x109AEF0 VA: 0x18109C4F0
	|-Nullable<sbyte>.Equals
	|
	|-RVA: 0x109B5E0 Offset: 0x1099FE0 VA: 0x18109B5E0
	|-Nullable<float>.Equals
	|
	|-RVA: 0x109CC90 Offset: 0x109B690 VA: 0x18109CC90
	|-Nullable<SqlBinary>.Equals
	|
	|-RVA: 0x109D480 Offset: 0x109BE80 VA: 0x18109D480
	|-Nullable<StreamingContext>.Equals
	|
	|-RVA: 0x109B340 Offset: 0x1099D40 VA: 0x18109B340
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x109B900 Offset: 0x109A300 VA: 0x18109B900
	|-Nullable<Token>.Equals
	|
	|-RVA: 0x109C7F0 Offset: 0x109B1F0 VA: 0x18109C7F0
	|-Nullable<ushort>.Equals
	|
	|-RVA: 0x109C300 Offset: 0x109AD00 VA: 0x18109C300
	|-Nullable<uint>.Equals
	|
	|-RVA: 0x109CA10 Offset: 0x109B410 VA: 0x18109CA10
	|-Nullable<ulong>.Equals
	|
	|-RVA: 0x109C0E0 Offset: 0x109AAE0 VA: 0x18109C0E0
	|-Nullable<Vector2>.Equals
	|
	|-RVA: 0x109D3A0 Offset: 0x109BDA0 VA: 0x18109D3A0
	|-Nullable<Vector3>.Equals
	|
	|-RVA: 0x109BFF0 Offset: 0x109A9F0 VA: 0x18109BFF0
	|-Nullable<Vector4>.Equals
	|
	|-RVA: 0x109C860 Offset: 0x109B260 VA: 0x18109C860
	|-Nullable<__Il2CppFullySharedGenericStructType>.Equals
	|
	|-RVA: 0x109D680 Offset: 0x109C080 VA: 0x18109D680
	|-Nullable<Icon.IconDirEntry>.Equals
	|
	|-RVA: 0x109B150 Offset: 0x1099B50 VA: 0x18109B150
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.Equals
	|
	|-RVA: 0x109D050 Offset: 0x109BA50 VA: 0x18109D050
	|-Nullable<InputControlLayout.ControlItem>.Equals
	|
	|-RVA: 0x109C410 Offset: 0x109AE10 VA: 0x18109C410
	|-Nullable<InputControlScheme.MatchResult>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109EA00 Offset: 0x109D400 VA: 0x18109EA00
	|-Nullable<SyncVar.CachedOnChange<bool>>.GetHashCode
	|
	|-RVA: 0x109D9A0 Offset: 0x109C3A0 VA: 0x18109D9A0
	|-Nullable<SyncVar.CachedOnChange<int>>.GetHashCode
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.GetHashCode
	|-Nullable<BlitUtility.MeshSetupResult>.GetHashCode
	|
	|-RVA: 0x109DCE0 Offset: 0x109C6E0 VA: 0x18109DCE0
	|-Nullable<SyncVar.CachedOnChange<object>>.GetHashCode
	|-Nullable<ReadOnlyArray<object>>.GetHashCode
	|-Nullable<DisconnectInfo>.GetHashCode
	|-Nullable<RegexPrefix>.GetHashCode
	|-Nullable<InputAction.CallbackContext>.GetHashCode
	|-Nullable<InputRemoting.Message>.GetHashCode
	|
	|-RVA: 0x109E0C0 Offset: 0x109CAC0 VA: 0x18109E0C0
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.GetHashCode
	|
	|-RVA: 0x109E140 Offset: 0x109CB40 VA: 0x18109E140
	|-Nullable<SyncVar.CachedOnChange<float>>.GetHashCode
	|
	|-RVA: 0x109DA10 Offset: 0x109C410 VA: 0x18109DA10
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.GetHashCode
	|
	|-RVA: 0x109E640 Offset: 0x109D040 VA: 0x18109E640
	|-Nullable<NativeArray<RenderStateBlock>>.GetHashCode
	|-Nullable<NativeArray<ShaderTagId>>.GetHashCode
	|
	|-RVA: 0x109E5F0 Offset: 0x109CFF0 VA: 0x18109E5F0
	|-Nullable<SubArray<CGSpot>>.GetHashCode
	|-Nullable<SubArray<int>>.GetHashCode
	|
	|-RVA: 0x109DFA0 Offset: 0x109C9A0 VA: 0x18109DFA0
	|-Nullable<BigInteger>.GetHashCode
	|
	|-RVA: 0x109DF10 Offset: 0x109C910 VA: 0x18109DF10
	|-Nullable<bool>.GetHashCode
	|
	|-RVA: 0x109E3B0 Offset: 0x109CDB0 VA: 0x18109E3B0
	|-Nullable<Bounds>.GetHashCode
	|
	|-RVA: 0x109DDF0 Offset: 0x109C7F0 VA: 0x18109DDF0
	|-Nullable<byte>.GetHashCode
	|
	|-RVA: 0x109DC70 Offset: 0x109C670 VA: 0x18109DC70
	|-Nullable<ByteEnum>.GetHashCode
	|
	|-RVA: 0x109F0F0 Offset: 0x109DAF0 VA: 0x18109F0F0
	|-Nullable<char>.GetHashCode
	|
	|-RVA: 0x109DEC0 Offset: 0x109C8C0 VA: 0x18109DEC0
	|-Nullable<Color>.GetHashCode
	|
	|-RVA: 0x109F3B0 Offset: 0x109DDB0 VA: 0x18109F3B0
	|-Nullable<Color>.GetHashCode
	|
	|-RVA: 0x109F250 Offset: 0x109DC50 VA: 0x18109F250
	|-Nullable<DataKey>.GetHashCode
	|
	|-RVA: 0x109EEF0 Offset: 0x109D8F0 VA: 0x18109EEF0
	|-Nullable<DateTime>.GetHashCode
	|
	|-RVA: 0x109E240 Offset: 0x109CC40 VA: 0x18109E240
	|-Nullable<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x109F2A0 Offset: 0x109DCA0 VA: 0x18109F2A0
	|-Nullable<Decimal>.GetHashCode
	|
	|-RVA: 0x109E2D0 Offset: 0x109CCD0 VA: 0x18109E2D0
	|-Nullable<double>.GetHashCode
	|
	|-RVA: 0x109E6B0 Offset: 0x109D0B0 VA: 0x18109E6B0
	|-Nullable<EventDispatcherGate>.GetHashCode
	|
	|-RVA: 0x109DAE0 Offset: 0x109C4E0 VA: 0x18109DAE0
	|-Nullable<GlobalDynamicResolutionSettings>.GetHashCode
	|
	|-RVA: 0x109DC90 Offset: 0x109C690 VA: 0x18109DC90
	|-Nullable<Guid>.GetHashCode
	|
	|-RVA: 0x109E4F0 Offset: 0x109CEF0 VA: 0x18109E4F0
	|-Nullable<InputBinding>.GetHashCode
	|
	|-RVA: 0x109ED50 Offset: 0x109D750 VA: 0x18109ED50
	|-Nullable<InputControlScheme>.GetHashCode
	|
	|-RVA: 0x109F060 Offset: 0x109DA60 VA: 0x18109F060
	|-Nullable<InputDeviceMatcher>.GetHashCode
	|
	|-RVA: 0x109E330 Offset: 0x109CD30 VA: 0x18109E330
	|-Nullable<InputUser>.GetHashCode
	|
	|-RVA: 0x109E4A0 Offset: 0x109CEA0 VA: 0x18109E4A0
	|-Nullable<InputUserAccountHandle>.GetHashCode
	|
	|-RVA: 0x109E8D0 Offset: 0x109D2D0 VA: 0x18109E8D0
	|-Nullable<short>.GetHashCode
	|
	|-RVA: 0x109E690 Offset: 0x109D090 VA: 0x18109E690
	|-Nullable<Int16Enum>.GetHashCode
	|
	|-RVA: 0x109F480 Offset: 0x109DE80 VA: 0x18109F480
	|-Nullable<int>.GetHashCode
	|-Nullable<uint>.GetHashCode
	|
	|-RVA: 0x109E540 Offset: 0x109CF40 VA: 0x18109E540
	|-Nullable<Int32Enum>.GetHashCode
	|
	|-RVA: 0x109DB80 Offset: 0x109C580 VA: 0x18109DB80
	|-Nullable<long>.GetHashCode
	|
	|-RVA: 0x109E850 Offset: 0x109D250 VA: 0x18109E850
	|-Nullable<JsonPosition>.GetHashCode
	|
	|-RVA: 0x109E800 Offset: 0x109D200 VA: 0x18109E800
	|-Nullable<LocalDefinition>.GetHashCode
	|
	|-RVA: 0x109EC00 Offset: 0x109D600 VA: 0x18109EC00
	|-Nullable<Prefs>.GetHashCode
	|
	|-RVA: 0x109ED00 Offset: 0x109D700 VA: 0x18109ED00
	|-Nullable<PrimitiveValue>.GetHashCode
	|
	|-RVA: 0x109E960 Offset: 0x109D360 VA: 0x18109E960
	|-Nullable<Quaternion>.GetHashCode
	|
	|-RVA: 0x109DD50 Offset: 0x109C750 VA: 0x18109DD50
	|-Nullable<Rect>.GetHashCode
	|
	|-RVA: 0x109E560 Offset: 0x109CF60 VA: 0x18109E560
	|-Nullable<RenderQueueRange>.GetHashCode
	|
	|-RVA: 0x109DA90 Offset: 0x109C490 VA: 0x18109DA90
	|-Nullable<RenderStateBlock>.GetHashCode
	|
	|-RVA: 0x109E700 Offset: 0x109D100 VA: 0x18109E700
	|-Nullable<RenderTargetIdentifier>.GetHashCode
	|
	|-RVA: 0x109ECB0 Offset: 0x109D6B0 VA: 0x18109ECB0
	|-Nullable<sbyte>.GetHashCode
	|
	|-RVA: 0x109EDA0 Offset: 0x109D7A0 VA: 0x18109EDA0
	|-Nullable<float>.GetHashCode
	|
	|-RVA: 0x109EF80 Offset: 0x109D980 VA: 0x18109EF80
	|-Nullable<SqlBinary>.GetHashCode
	|
	|-RVA: 0x109E920 Offset: 0x109D320 VA: 0x18109E920
	|-Nullable<StreamingContext>.GetHashCode
	|
	|-RVA: 0x109E030 Offset: 0x109CA30 VA: 0x18109E030
	|-Nullable<TimeSpan>.GetHashCode
	|
	|-RVA: 0x109F330 Offset: 0x109DD30 VA: 0x18109F330
	|-Nullable<Token>.GetHashCode
	|
	|-RVA: 0x109DDA0 Offset: 0x109C7A0 VA: 0x18109DDA0
	|-Nullable<ushort>.GetHashCode
	|
	|-RVA: 0x109F010 Offset: 0x109DA10 VA: 0x18109F010
	|-Nullable<ulong>.GetHashCode
	|
	|-RVA: 0x109E7A0 Offset: 0x109D1A0 VA: 0x18109E7A0
	|-Nullable<Vector2>.GetHashCode
	|
	|-RVA: 0x109DE40 Offset: 0x109C840 VA: 0x18109DE40
	|-Nullable<Vector3>.GetHashCode
	|
	|-RVA: 0x109E750 Offset: 0x109D150 VA: 0x18109E750
	|-Nullable<Vector4>.GetHashCode
	|
	|-RVA: 0x109EA70 Offset: 0x109D470 VA: 0x18109EA70
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetHashCode
	|
	|-RVA: 0x109E1C0 Offset: 0x109CBC0 VA: 0x18109E1C0
	|-Nullable<Icon.IconDirEntry>.GetHashCode
	|
	|-RVA: 0x109F180 Offset: 0x109DB80 VA: 0x18109F180
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.GetHashCode
	|
	|-RVA: 0x109EDF0 Offset: 0x109D7F0 VA: 0x18109EDF0
	|-Nullable<InputControlLayout.ControlItem>.GetHashCode
	|
	|-RVA: 0x109DBD0 Offset: 0x109C5D0 VA: 0x18109DBD0
	|-Nullable<InputControlScheme.MatchResult>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A1A80 Offset: 0x10A0480 VA: 0x1810A1A80
	|-Nullable<SyncVar.CachedOnChange<bool>>.ToString
	|
	|-RVA: 0x10A2B60 Offset: 0x10A1560 VA: 0x1810A2B60
	|-Nullable<SyncVar.CachedOnChange<int>>.ToString
	|
	|-RVA: 0x10A2670 Offset: 0x10A1070 VA: 0x1810A2670
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.ToString
	|
	|-RVA: 0x10A0D70 Offset: 0x109F770 VA: 0x1810A0D70
	|-Nullable<SyncVar.CachedOnChange<object>>.ToString
	|
	|-RVA: 0x10A0F00 Offset: 0x109F900 VA: 0x1810A0F00
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.ToString
	|
	|-RVA: 0x10A0980 Offset: 0x109F380 VA: 0x1810A0980
	|-Nullable<SyncVar.CachedOnChange<float>>.ToString
	|
	|-RVA: 0x10A10B0 Offset: 0x109FAB0 VA: 0x1810A10B0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.ToString
	|
	|-RVA: 0x10A0B50 Offset: 0x109F550 VA: 0x1810A0B50
	|-Nullable<NativeArray<RenderStateBlock>>.ToString
	|
	|-RVA: 0x10A2720 Offset: 0x10A1120 VA: 0x1810A2720
	|-Nullable<NativeArray<ShaderTagId>>.ToString
	|
	|-RVA: 0x10A19D0 Offset: 0x10A03D0 VA: 0x1810A19D0
	|-Nullable<ReadOnlyArray<object>>.ToString
	|
	|-RVA: 0x10A2840 Offset: 0x10A1240 VA: 0x1810A2840
	|-Nullable<SubArray<CGSpot>>.ToString
	|
	|-RVA: 0x10A01D0 Offset: 0x109EBD0 VA: 0x1810A01D0
	|-Nullable<SubArray<int>>.ToString
	|
	|-RVA: 0x10A20E0 Offset: 0x10A0AE0 VA: 0x1810A20E0
	|-Nullable<BigInteger>.ToString
	|
	|-RVA: 0x10A2040 Offset: 0x10A0A40 VA: 0x1810A2040
	|-Nullable<bool>.ToString
	|
	|-RVA: 0x10A0C00 Offset: 0x109F600 VA: 0x1810A0C00
	|-Nullable<Bounds>.ToString
	|
	|-RVA: 0x10A18D0 Offset: 0x10A02D0 VA: 0x1810A18D0
	|-Nullable<byte>.ToString
	|
	|-RVA: 0x10A1160 Offset: 0x109FB60 VA: 0x1810A1160
	|-Nullable<ByteEnum>.ToString
	|
	|-RVA: 0x10A12A0 Offset: 0x109FCA0 VA: 0x1810A12A0
	|-Nullable<char>.ToString
	|
	|-RVA: 0x10A0CF0 Offset: 0x109F6F0 VA: 0x1810A0CF0
	|-Nullable<Color>.ToString
	|
	|-RVA: 0x10A0E20 Offset: 0x109F820 VA: 0x1810A0E20
	|-Nullable<Color>.ToString
	|
	|-RVA: 0x10A2A10 Offset: 0x10A1410 VA: 0x1810A2A10
	|-Nullable<DataKey>.ToString
	|
	|-RVA: 0x10A1340 Offset: 0x109FD40 VA: 0x1810A1340
	|-Nullable<DateTime>.ToString
	|
	|-RVA: 0x10A2180 Offset: 0x10A0B80 VA: 0x1810A2180
	|-Nullable<DateTimeOffset>.ToString
	|
	|-RVA: 0x10A0AB0 Offset: 0x109F4B0 VA: 0x1810A0AB0
	|-Nullable<Decimal>.ToString
	|
	|-RVA: 0x10A2540 Offset: 0x10A0F40 VA: 0x1810A2540
	|-Nullable<DisconnectInfo>.ToString
	|
	|-RVA: 0x10A13E0 Offset: 0x109FDE0 VA: 0x1810A13E0
	|-Nullable<double>.ToString
	|
	|-RVA: 0x10A2370 Offset: 0x10A0D70 VA: 0x1810A2370
	|-Nullable<EventDispatcherGate>.ToString
	|
	|-RVA: 0x10A2220 Offset: 0x10A0C20 VA: 0x1810A2220
	|-Nullable<GlobalDynamicResolutionSettings>.ToString
	|
	|-RVA: 0x10A0280 Offset: 0x109EC80 VA: 0x1810A0280
	|-Nullable<Guid>.ToString
	|
	|-RVA: 0x10A25F0 Offset: 0x10A0FF0 VA: 0x1810A25F0
	|-Nullable<InputBinding>.ToString
	|
	|-RVA: 0x10A14D0 Offset: 0x109FED0 VA: 0x1810A14D0
	|-Nullable<InputControlScheme>.ToString
	|
	|-RVA: 0x10A2AC0 Offset: 0x10A14C0 VA: 0x1810A2AC0
	|-Nullable<InputDeviceMatcher>.ToString
	|
	|-RVA: 0x10A1830 Offset: 0x10A0230 VA: 0x1810A1830
	|-Nullable<InputUser>.ToString
	|
	|-RVA: 0x10A2990 Offset: 0x10A1390 VA: 0x1810A2990
	|-Nullable<InputUserAccountHandle>.ToString
	|
	|-RVA: 0x10A0FB0 Offset: 0x109F9B0 VA: 0x1810A0FB0
	|-Nullable<short>.ToString
	|
	|-RVA: 0x10A0690 Offset: 0x109F090 VA: 0x1810A0690
	|-Nullable<Int16Enum>.ToString
	|
	|-RVA: 0x10A1030 Offset: 0x109FA30 VA: 0x1810A1030
	|-Nullable<int>.ToString
	|
	|-RVA: 0x10A0830 Offset: 0x109F230 VA: 0x1810A0830
	|-Nullable<Int32Enum>.ToString
	|
	|-RVA: 0x109FFE0 Offset: 0x109E9E0 VA: 0x18109FFE0
	|-Nullable<long>.ToString
	|
	|-RVA: 0x10A08D0 Offset: 0x109F2D0 VA: 0x1810A08D0
	|-Nullable<JsonPosition>.ToString
	|
	|-RVA: 0x10A05E0 Offset: 0x109EFE0 VA: 0x1810A05E0
	|-Nullable<LocalDefinition>.ToString
	|
	|-RVA: 0x10A0740 Offset: 0x109F140 VA: 0x1810A0740
	|-Nullable<Prefs>.ToString
	|
	|-RVA: 0x10A00E0 Offset: 0x109EAE0 VA: 0x1810A00E0
	|-Nullable<PrimitiveValue>.ToString
	|
	|-RVA: 0x10A0E90 Offset: 0x109F890 VA: 0x1810A0E90
	|-Nullable<Quaternion>.ToString
	|
	|-RVA: 0x10A1460 Offset: 0x109FE60 VA: 0x1810A1460
	|-Nullable<Rect>.ToString
	|
	|-RVA: 0x10A1780 Offset: 0x10A0180 VA: 0x1810A1780
	|-Nullable<RegexPrefix>.ToString
	|
	|-RVA: 0x10A0450 Offset: 0x109EE50 VA: 0x1810A0450
	|-Nullable<RenderQueueRange>.ToString
	|
	|-RVA: 0x10A1BE0 Offset: 0x10A05E0 VA: 0x1810A1BE0
	|-Nullable<RenderStateBlock>.ToString
	|
	|-RVA: 0x10A1950 Offset: 0x10A0350 VA: 0x1810A1950
	|-Nullable<RenderTargetIdentifier>.ToString
	|
	|-RVA: 0x10A0A30 Offset: 0x109F430 VA: 0x1810A0A30
	|-Nullable<sbyte>.ToString
	|
	|-RVA: 0x10A0060 Offset: 0x109EA60 VA: 0x1810A0060
	|-Nullable<float>.ToString
	|
	|-RVA: 0x10A03B0 Offset: 0x109EDB0 VA: 0x1810A03B0
	|-Nullable<SqlBinary>.ToString
	|
	|-RVA: 0x10A2420 Offset: 0x10A0E20 VA: 0x1810A2420
	|-Nullable<StreamingContext>.ToString
	|
	|-RVA: 0x10A1200 Offset: 0x109FC00 VA: 0x1810A1200
	|-Nullable<TimeSpan>.ToString
	|
	|-RVA: 0x10A28F0 Offset: 0x10A12F0 VA: 0x1810A28F0
	|-Nullable<Token>.ToString
	|
	|-RVA: 0x10A0C70 Offset: 0x109F670 VA: 0x1810A0C70
	|-Nullable<ushort>.ToString
	|
	|-RVA: 0x10A1CE0 Offset: 0x10A06E0 VA: 0x1810A1CE0
	|-Nullable<uint>.ToString
	|
	|-RVA: 0x10A1700 Offset: 0x10A0100 VA: 0x1810A1700
	|-Nullable<ulong>.ToString
	|
	|-RVA: 0x10A24D0 Offset: 0x10A0ED0 VA: 0x1810A24D0
	|-Nullable<Vector2>.ToString
	|
	|-RVA: 0x10A0160 Offset: 0x109EB60 VA: 0x1810A0160
	|-Nullable<Vector3>.ToString
	|
	|-RVA: 0x10A27D0 Offset: 0x10A11D0 VA: 0x1810A27D0
	|-Nullable<Vector4>.ToString
	|
	|-RVA: 0x10A1D60 Offset: 0x10A0760 VA: 0x1810A1D60
	|-Nullable<__Il2CppFullySharedGenericStructType>.ToString
	|
	|-RVA: 0x10A1550 Offset: 0x109FF50 VA: 0x1810A1550
	|-Nullable<BlitUtility.MeshSetupResult>.ToString
	|
	|-RVA: 0x10A1B30 Offset: 0x10A0530 VA: 0x1810A1B30
	|-Nullable<Icon.IconDirEntry>.ToString
	|
	|-RVA: 0x10A22F0 Offset: 0x10A0CF0 VA: 0x1810A22F0
	|-Nullable<InputAction.CallbackContext>.ToString
	|
	|-RVA: 0x10A1600 Offset: 0x10A0000 VA: 0x1810A1600
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.ToString
	|
	|-RVA: 0x10A1F10 Offset: 0x10A0910 VA: 0x1810A1F10
	|-Nullable<InputControlLayout.ControlItem>.ToString
	|
	|-RVA: 0x10A0500 Offset: 0x109EF00 VA: 0x1810A0500
	|-Nullable<InputControlScheme.MatchResult>.ToString
	|
	|-RVA: 0x10A0300 Offset: 0x109ED00 VA: 0x1810A0300
	|-Nullable<InputRemoting.Message>.ToString
	*/

	// RVA: -1 Offset: -1
	private static object Box(Nullable<T> o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109AEF0 Offset: 0x10998F0 VA: 0x18109AEF0
	|-Nullable<SyncVar.CachedOnChange<bool>>.Box
	|
	|-RVA: 0x109A330 Offset: 0x1098D30 VA: 0x18109A330
	|-Nullable<SyncVar.CachedOnChange<int>>.Box
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.Box
	|-Nullable<RenderQueueRange>.Box
	|-Nullable<BlitUtility.MeshSetupResult>.Box
	|
	|-RVA: 0x109A5D0 Offset: 0x1098FD0 VA: 0x18109A5D0
	|-Nullable<SyncVar.CachedOnChange<object>>.Box
	|-Nullable<NativeArray<RenderStateBlock>>.Box
	|-Nullable<NativeArray<ShaderTagId>>.Box
	|-Nullable<ReadOnlyArray<object>>.Box
	|-Nullable<SubArray<CGSpot>>.Box
	|-Nullable<SubArray<int>>.Box
	|-Nullable<BigInteger>.Box
	|-Nullable<DateTimeOffset>.Box
	|-Nullable<Decimal>.Box
	|-Nullable<DisconnectInfo>.Box
	|-Nullable<InputUserAccountHandle>.Box
	|-Nullable<LocalDefinition>.Box
	|-Nullable<PrimitiveValue>.Box
	|-Nullable<RegexPrefix>.Box
	|-Nullable<StreamingContext>.Box
	|-Nullable<InputAction.CallbackContext>.Box
	|-Nullable<InputRemoting.Message>.Box
	|
	|-RVA: 0x109AF40 Offset: 0x1099940 VA: 0x18109AF40
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.Box
	|
	|-RVA: 0x109ACA0 Offset: 0x10996A0 VA: 0x18109ACA0
	|-Nullable<SyncVar.CachedOnChange<float>>.Box
	|-Nullable<Vector2>.Box
	|
	|-RVA: 0x109A380 Offset: 0x1098D80 VA: 0x18109A380
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.Box
	|-Nullable<Bounds>.Box
	|
	|-RVA: 0x109A6F0 Offset: 0x10990F0 VA: 0x18109A6F0
	|-Nullable<bool>.Box
	|-Nullable<byte>.Box
	|-Nullable<ByteEnum>.Box
	|-Nullable<sbyte>.Box
	|
	|-RVA: 0x109A6A0 Offset: 0x10990A0 VA: 0x18109A6A0
	|-Nullable<char>.Box
	|-Nullable<short>.Box
	|-Nullable<Int16Enum>.Box
	|-Nullable<ushort>.Box
	|
	|-RVA: 0x109A630 Offset: 0x1099030 VA: 0x18109A630
	|-Nullable<Color>.Box
	|-Nullable<InputControlScheme>.Box
	|-Nullable<JsonPosition>.Box
	|
	|-RVA: 0x109A7C0 Offset: 0x10991C0 VA: 0x18109A7C0
	|-Nullable<Color>.Box
	|-Nullable<Guid>.Box
	|-Nullable<Quaternion>.Box
	|-Nullable<Rect>.Box
	|-Nullable<Vector4>.Box
	|
	|-RVA: 0x109A580 Offset: 0x1098F80 VA: 0x18109A580
	|-Nullable<DataKey>.Box
	|-Nullable<DateTime>.Box
	|-Nullable<EventDispatcherGate>.Box
	|-Nullable<InputDeviceMatcher>.Box
	|-Nullable<long>.Box
	|-Nullable<SqlBinary>.Box
	|-Nullable<TimeSpan>.Box
	|-Nullable<ulong>.Box
	|
	|-RVA: 0x109B090 Offset: 0x1099A90 VA: 0x18109B090
	|-Nullable<double>.Box
	|
	|-RVA: 0x109A820 Offset: 0x1099220 VA: 0x18109A820
	|-Nullable<GlobalDynamicResolutionSettings>.Box
	|
	|-RVA: 0x109A990 Offset: 0x1099390 VA: 0x18109A990
	|-Nullable<InputBinding>.Box
	|
	|-RVA: 0x109ACF0 Offset: 0x10996F0 VA: 0x18109ACF0
	|-Nullable<InputUser>.Box
	|-Nullable<int>.Box
	|-Nullable<Int32Enum>.Box
	|-Nullable<uint>.Box
	|
	|-RVA: 0x109A8C0 Offset: 0x10992C0 VA: 0x18109A8C0
	|-Nullable<Prefs>.Box
	|
	|-RVA: 0x109AAA0 Offset: 0x10994A0 VA: 0x18109AAA0
	|-Nullable<RenderStateBlock>.Box
	|
	|-RVA: 0x109A740 Offset: 0x1099140 VA: 0x18109A740
	|-Nullable<RenderTargetIdentifier>.Box
	|
	|-RVA: 0x109AD40 Offset: 0x1099740 VA: 0x18109AD40
	|-Nullable<float>.Box
	|
	|-RVA: 0x109AA50 Offset: 0x1099450 VA: 0x18109AA50
	|-Nullable<Token>.Box
	|-Nullable<Vector3>.Box
	|
	|-RVA: 0x109A3F0 Offset: 0x1098DF0 VA: 0x18109A3F0
	|-Nullable<__Il2CppFullySharedGenericStructType>.Box
	|
	|-RVA: 0x109AB80 Offset: 0x1099580 VA: 0x18109AB80
	|-Nullable<Icon.IconDirEntry>.Box
	|
	|-RVA: 0x109AFB0 Offset: 0x10999B0 VA: 0x18109AFB0
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.Box
	|
	|-RVA: 0x109AD90 Offset: 0x1099790 VA: 0x18109AD90
	|-Nullable<InputControlLayout.ControlItem>.Box
	|
	|-RVA: 0x109ABF0 Offset: 0x10995F0 VA: 0x18109ABF0
	|-Nullable<InputControlScheme.MatchResult>.Box
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> Unbox(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10AACC0 Offset: 0x10A96C0 VA: 0x1810AACC0
	|-Nullable<SyncVar.CachedOnChange<bool>>.Unbox
	|
	|-RVA: 0x10AB1F0 Offset: 0x10A9BF0 VA: 0x1810AB1F0
	|-Nullable<SyncVar.CachedOnChange<int>>.Unbox
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.Unbox
	|-Nullable<RenderQueueRange>.Unbox
	|-Nullable<BlitUtility.MeshSetupResult>.Unbox
	|
	|-RVA: 0x10AA8F0 Offset: 0x10A92F0 VA: 0x1810AA8F0
	|-Nullable<SyncVar.CachedOnChange<object>>.Unbox
	|-Nullable<ReadOnlyArray<object>>.Unbox
	|-Nullable<SubArray<CGSpot>>.Unbox
	|-Nullable<SubArray<int>>.Unbox
	|-Nullable<InputUserAccountHandle>.Unbox
	|-Nullable<StreamingContext>.Unbox
	|-Nullable<InputAction.CallbackContext>.Unbox
	|
	|-RVA: 0x10AB7F0 Offset: 0x10AA1F0 VA: 0x1810AB7F0
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.Unbox
	|
	|-RVA: 0x10AAD90 Offset: 0x10A9790 VA: 0x1810AAD90
	|-Nullable<SyncVar.CachedOnChange<float>>.Unbox
	|-Nullable<Vector2>.Unbox
	|
	|-RVA: 0x10AB8F0 Offset: 0x10AA2F0 VA: 0x1810AB8F0
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.Unbox
	|-Nullable<Bounds>.Unbox
	|
	|-RVA: 0x10AA370 Offset: 0x10A8D70 VA: 0x1810AA370
	|-Nullable<NativeArray<RenderStateBlock>>.Unbox
	|-Nullable<NativeArray<ShaderTagId>>.Unbox
	|-Nullable<DateTimeOffset>.Unbox
	|-Nullable<Decimal>.Unbox
	|-Nullable<PrimitiveValue>.Unbox
	|
	|-RVA: 0x10AA750 Offset: 0x10A9150 VA: 0x1810AA750
	|-Nullable<BigInteger>.Unbox
	|-Nullable<DisconnectInfo>.Unbox
	|-Nullable<LocalDefinition>.Unbox
	|-Nullable<RegexPrefix>.Unbox
	|-Nullable<InputRemoting.Message>.Unbox
	|
	|-RVA: 0x10AAC20 Offset: 0x10A9620 VA: 0x1810AAC20
	|-Nullable<bool>.Unbox
	|-Nullable<byte>.Unbox
	|-Nullable<ByteEnum>.Unbox
	|-Nullable<sbyte>.Unbox
	|
	|-RVA: 0x10AA840 Offset: 0x10A9240 VA: 0x1810AA840
	|-Nullable<char>.Unbox
	|-Nullable<short>.Unbox
	|-Nullable<Int16Enum>.Unbox
	|-Nullable<ushort>.Unbox
	|
	|-RVA: 0x10AAE80 Offset: 0x10A9880 VA: 0x1810AAE80
	|-Nullable<Color>.Unbox
	|-Nullable<InputControlScheme>.Unbox
	|
	|-RVA: 0x10AA510 Offset: 0x10A8F10 VA: 0x1810AA510
	|-Nullable<Color>.Unbox
	|-Nullable<Guid>.Unbox
	|-Nullable<Quaternion>.Unbox
	|-Nullable<Rect>.Unbox
	|-Nullable<Vector4>.Unbox
	|
	|-RVA: 0x10AB060 Offset: 0x10A9A60 VA: 0x1810AB060
	|-Nullable<DataKey>.Unbox
	|-Nullable<EventDispatcherGate>.Unbox
	|-Nullable<InputDeviceMatcher>.Unbox
	|-Nullable<SqlBinary>.Unbox
	|
	|-RVA: 0x10AAB50 Offset: 0x10A9550 VA: 0x1810AAB50
	|-Nullable<DateTime>.Unbox
	|-Nullable<long>.Unbox
	|-Nullable<TimeSpan>.Unbox
	|-Nullable<ulong>.Unbox
	|
	|-RVA: 0x10ABBF0 Offset: 0x10AA5F0 VA: 0x1810ABBF0
	|-Nullable<double>.Unbox
	|
	|-RVA: 0x10ABAC0 Offset: 0x10AA4C0 VA: 0x1810ABAC0
	|-Nullable<GlobalDynamicResolutionSettings>.Unbox
	|
	|-RVA: 0x10AB690 Offset: 0x10AA090 VA: 0x1810AB690
	|-Nullable<InputBinding>.Unbox
	|
	|-RVA: 0x10AA460 Offset: 0x10A8E60 VA: 0x1810AA460
	|-Nullable<InputUser>.Unbox
	|-Nullable<int>.Unbox
	|-Nullable<Int32Enum>.Unbox
	|-Nullable<uint>.Unbox
	|
	|-RVA: 0x10ABE50 Offset: 0x10AA850 VA: 0x1810ABE50
	|-Nullable<JsonPosition>.Unbox
	|
	|-RVA: 0x10AA9E0 Offset: 0x10A93E0 VA: 0x1810AA9E0
	|-Nullable<Prefs>.Unbox
	|
	|-RVA: 0x10AB520 Offset: 0x10A9F20 VA: 0x1810AB520
	|-Nullable<RenderStateBlock>.Unbox
	|
	|-RVA: 0x10AA270 Offset: 0x10A8C70 VA: 0x1810AA270
	|-Nullable<RenderTargetIdentifier>.Unbox
	|
	|-RVA: 0x10AB140 Offset: 0x10A9B40 VA: 0x1810AB140
	|-Nullable<float>.Unbox
	|
	|-RVA: 0x10AB9F0 Offset: 0x10AA3F0 VA: 0x1810AB9F0
	|-Nullable<Token>.Unbox
	|-Nullable<Vector3>.Unbox
	|
	|-RVA: 0x10ABF40 Offset: 0x10AA940 VA: 0x1810ABF40
	|-Nullable<__Il2CppFullySharedGenericStructType>.Unbox
	|
	|-RVA: 0x10AAF70 Offset: 0x10A9970 VA: 0x1810AAF70
	|-Nullable<Icon.IconDirEntry>.Unbox
	|
	|-RVA: 0x10ABCC0 Offset: 0x10AA6C0 VA: 0x1810ABCC0
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.Unbox
	|
	|-RVA: 0x10AB2D0 Offset: 0x10A9CD0 VA: 0x1810AB2D0
	|-Nullable<InputControlLayout.ControlItem>.Unbox
	|
	|-RVA: 0x10AA5F0 Offset: 0x10A8FF0 VA: 0x1810AA5F0
	|-Nullable<InputControlScheme.MatchResult>.Unbox
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> UnboxExact(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8B00 Offset: 0x10A7500 VA: 0x1810A8B00
	|-Nullable<SyncVar.CachedOnChange<bool>>.UnboxExact
	|
	|-RVA: 0x10A9080 Offset: 0x10A7A80 VA: 0x1810A9080
	|-Nullable<SyncVar.CachedOnChange<int>>.UnboxExact
	|
	|-RVA: 0x10A4020 Offset: 0x10A2A20 VA: 0x1810A4020
	|-Nullable<SyncVar.CachedOnChange<Int32Enum>>.UnboxExact
	|
	|-RVA: 0x10A3320 Offset: 0x10A1D20 VA: 0x1810A3320
	|-Nullable<SyncVar.CachedOnChange<object>>.UnboxExact
	|
	|-RVA: 0x10A6C50 Offset: 0x10A5650 VA: 0x1810A6C50
	|-Nullable<SyncVar.CachedOnChange<Quaternion>>.UnboxExact
	|
	|-RVA: 0x10A7F40 Offset: 0x10A6940 VA: 0x1810A7F40
	|-Nullable<SyncVar.CachedOnChange<float>>.UnboxExact
	|
	|-RVA: 0x10A3670 Offset: 0x10A2070 VA: 0x1810A3670
	|-Nullable<SyncVar.CachedOnChange<Vector3>>.UnboxExact
	|
	|-RVA: 0x10A8440 Offset: 0x10A6E40 VA: 0x1810A8440
	|-Nullable<NativeArray<RenderStateBlock>>.UnboxExact
	|
	|-RVA: 0x10A7C00 Offset: 0x10A6600 VA: 0x1810A7C00
	|-Nullable<NativeArray<ShaderTagId>>.UnboxExact
	|
	|-RVA: 0x10A7A40 Offset: 0x10A6440 VA: 0x1810A7A40
	|-Nullable<ReadOnlyArray<object>>.UnboxExact
	|
	|-RVA: 0x10AA0B0 Offset: 0x10A8AB0 VA: 0x1810AA0B0
	|-Nullable<SubArray<CGSpot>>.UnboxExact
	|
	|-RVA: 0x10A97F0 Offset: 0x10A81F0 VA: 0x1810A97F0
	|-Nullable<SubArray<int>>.UnboxExact
	|
	|-RVA: 0x10A8940 Offset: 0x10A7340 VA: 0x1810A8940
	|-Nullable<BigInteger>.UnboxExact
	|
	|-RVA: 0x10A5FD0 Offset: 0x10A49D0 VA: 0x1810A5FD0
	|-Nullable<bool>.UnboxExact
	|
	|-RVA: 0x10A4DA0 Offset: 0x10A37A0 VA: 0x1810A4DA0
	|-Nullable<Bounds>.UnboxExact
	|
	|-RVA: 0x10A7510 Offset: 0x10A5F10 VA: 0x1810A7510
	|-Nullable<byte>.UnboxExact
	|
	|-RVA: 0x10A5970 Offset: 0x10A4370 VA: 0x1810A5970
	|-Nullable<ByteEnum>.UnboxExact
	|
	|-RVA: 0x10A3D00 Offset: 0x10A2700 VA: 0x1810A3D00
	|-Nullable<char>.UnboxExact
	|
	|-RVA: 0x10A9EF0 Offset: 0x10A88F0 VA: 0x1810A9EF0
	|-Nullable<Color>.UnboxExact
	|
	|-RVA: 0x10A4550 Offset: 0x10A2F50 VA: 0x1810A4550
	|-Nullable<Color>.UnboxExact
	|
	|-RVA: 0x10A93D0 Offset: 0x10A7DD0 VA: 0x1810A93D0
	|-Nullable<DataKey>.UnboxExact
	|
	|-RVA: 0x10A34E0 Offset: 0x10A1EE0 VA: 0x1810A34E0
	|-Nullable<DateTime>.UnboxExact
	|
	|-RVA: 0x10A3E70 Offset: 0x10A2870 VA: 0x1810A3E70
	|-Nullable<DateTimeOffset>.UnboxExact
	|
	|-RVA: 0x10A8290 Offset: 0x10A6C90 VA: 0x1810A8290
	|-Nullable<Decimal>.UnboxExact
	|
	|-RVA: 0x10A5AE0 Offset: 0x10A44E0 VA: 0x1810A5AE0
	|-Nullable<DisconnectInfo>.UnboxExact
	|
	|-RVA: 0x10A3190 Offset: 0x10A1B90 VA: 0x1810A3190
	|-Nullable<double>.UnboxExact
	|
	|-RVA: 0x10A3B60 Offset: 0x10A2560 VA: 0x1810A3B60
	|-Nullable<EventDispatcherGate>.UnboxExact
	|
	|-RVA: 0x10A6780 Offset: 0x10A5180 VA: 0x1810A6780
	|-Nullable<GlobalDynamicResolutionSettings>.UnboxExact
	|
	|-RVA: 0x10A4C00 Offset: 0x10A3600 VA: 0x1810A4C00
	|-Nullable<Guid>.UnboxExact
	|
	|-RVA: 0x10A72E0 Offset: 0x10A5CE0 VA: 0x1810A72E0
	|-Nullable<InputBinding>.UnboxExact
	|
	|-RVA: 0x10A85F0 Offset: 0x10A6FF0 VA: 0x1810A85F0
	|-Nullable<InputControlScheme>.UnboxExact
	|
	|-RVA: 0x10A9230 Offset: 0x10A7C30 VA: 0x1810A9230
	|-Nullable<InputDeviceMatcher>.UnboxExact
	|
	|-RVA: 0x10A39F0 Offset: 0x10A23F0 VA: 0x1810A39F0
	|-Nullable<InputUser>.UnboxExact
	|
	|-RVA: 0x10A41D0 Offset: 0x10A2BD0 VA: 0x1810A41D0
	|-Nullable<InputUserAccountHandle>.UnboxExact
	|
	|-RVA: 0x10A5E60 Offset: 0x10A4860 VA: 0x1810A5E60
	|-Nullable<short>.UnboxExact
	|
	|-RVA: 0x10A6610 Offset: 0x10A5010 VA: 0x1810A6610
	|-Nullable<Int16Enum>.UnboxExact
	|
	|-RVA: 0x10A7680 Offset: 0x10A6080 VA: 0x1810A7680
	|-Nullable<int>.UnboxExact
	|
	|-RVA: 0x10A7170 Offset: 0x10A5B70 VA: 0x1810A7170
	|-Nullable<Int32Enum>.UnboxExact
	|
	|-RVA: 0x10A99B0 Offset: 0x10A83B0 VA: 0x1810A99B0
	|-Nullable<long>.UnboxExact
	|
	|-RVA: 0x10A57B0 Offset: 0x10A41B0 VA: 0x1810A57B0
	|-Nullable<JsonPosition>.UnboxExact
	|
	|-RVA: 0x10A48A0 Offset: 0x10A32A0 VA: 0x1810A48A0
	|-Nullable<LocalDefinition>.UnboxExact
	|
	|-RVA: 0x10A8E40 Offset: 0x10A7840 VA: 0x1810A8E40
	|-Nullable<Prefs>.UnboxExact
	|
	|-RVA: 0x10A3840 Offset: 0x10A2240 VA: 0x1810A3840
	|-Nullable<PrimitiveValue>.UnboxExact
	|
	|-RVA: 0x10A6300 Offset: 0x10A4D00 VA: 0x1810A6300
	|-Nullable<Quaternion>.UnboxExact
	|
	|-RVA: 0x10A6FD0 Offset: 0x10A59D0 VA: 0x1810A6FD0
	|-Nullable<Rect>.UnboxExact
	|
	|-RVA: 0x10A5110 Offset: 0x10A3B10 VA: 0x1810A5110
	|-Nullable<RegexPrefix>.UnboxExact
	|
	|-RVA: 0x10A46F0 Offset: 0x10A30F0 VA: 0x1810A46F0
	|-Nullable<RenderQueueRange>.UnboxExact
	|
	|-RVA: 0x10A9B40 Offset: 0x10A8540 VA: 0x1810A9B40
	|-Nullable<RenderStateBlock>.UnboxExact
	|
	|-RVA: 0x10A5CA0 Offset: 0x10A46A0 VA: 0x1810A5CA0
	|-Nullable<RenderTargetIdentifier>.UnboxExact
	|
	|-RVA: 0x10A9D80 Offset: 0x10A8780 VA: 0x1810A9D80
	|-Nullable<sbyte>.UnboxExact
	|
	|-RVA: 0x10A6970 Offset: 0x10A5370 VA: 0x1810A6970
	|-Nullable<float>.UnboxExact
	|
	|-RVA: 0x10A2C10 Offset: 0x10A1610 VA: 0x1810A2C10
	|-Nullable<SqlBinary>.UnboxExact
	|
	|-RVA: 0x10A6140 Offset: 0x10A4B40 VA: 0x1810A6140
	|-Nullable<StreamingContext>.UnboxExact
	|
	|-RVA: 0x10A7DB0 Offset: 0x10A67B0 VA: 0x1810A7DB0
	|-Nullable<TimeSpan>.UnboxExact
	|
	|-RVA: 0x10A4A60 Offset: 0x10A3460 VA: 0x1810A4A60
	|-Nullable<Token>.UnboxExact
	|
	|-RVA: 0x10A6AE0 Offset: 0x10A54E0 VA: 0x1810A6AE0
	|-Nullable<ushort>.UnboxExact
	|
	|-RVA: 0x10A64A0 Offset: 0x10A4EA0 VA: 0x1810A64A0
	|-Nullable<uint>.UnboxExact
	|
	|-RVA: 0x10A87B0 Offset: 0x10A71B0 VA: 0x1810A87B0
	|-Nullable<ulong>.UnboxExact
	|
	|-RVA: 0x10A5600 Offset: 0x10A4000 VA: 0x1810A5600
	|-Nullable<Vector2>.UnboxExact
	|
	|-RVA: 0x10A80F0 Offset: 0x10A6AF0 VA: 0x1810A80F0
	|-Nullable<Vector3>.UnboxExact
	|
	|-RVA: 0x10A4F70 Offset: 0x10A3970 VA: 0x1810A4F70
	|-Nullable<Vector4>.UnboxExact
	|
	|-RVA: 0x10A9570 Offset: 0x10A7F70 VA: 0x1810A9570
	|-Nullable<__Il2CppFullySharedGenericStructType>.UnboxExact
	|
	|-RVA: 0x10A2DB0 Offset: 0x10A17B0 VA: 0x1810A2DB0
	|-Nullable<BlitUtility.MeshSetupResult>.UnboxExact
	|
	|-RVA: 0x10A4390 Offset: 0x10A2D90 VA: 0x1810A4390
	|-Nullable<Icon.IconDirEntry>.UnboxExact
	|
	|-RVA: 0x10A8C80 Offset: 0x10A7680 VA: 0x1810A8C80
	|-Nullable<InputAction.CallbackContext>.UnboxExact
	|
	|-RVA: 0x10A77F0 Offset: 0x10A61F0 VA: 0x1810A77F0
	|-Nullable<InputActionRebindingExtensions.ParameterOverride>.UnboxExact
	|
	|-RVA: 0x10A52D0 Offset: 0x10A3CD0 VA: 0x1810A52D0
	|-Nullable<InputControlLayout.ControlItem>.UnboxExact
	|
	|-RVA: 0x10A2F60 Offset: 0x10A1960 VA: 0x1810A2F60
	|-Nullable<InputControlScheme.MatchResult>.UnboxExact
	|
	|-RVA: 0x10A6E10 Offset: 0x10A5810 VA: 0x1810A6E10
	|-Nullable<InputRemoting.Message>.UnboxExact
	*/
}
