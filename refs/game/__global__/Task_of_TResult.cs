public class Task<TResult> : Task // TypeDefIndex: 4041
{
	// Fields
	internal TResult m_result; // 0x0
	private static TaskFactory<TResult> s_defaultFactory; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122D560 Offset: 0x122BF60 VA: 0x18122D560
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122F270 Offset: 0x122DC70 VA: 0x18122F270
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122F080 Offset: 0x122DA80 VA: 0x18122F080
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122BFE0 Offset: 0x122A9E0 VA: 0x18122BFE0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122C390 Offset: 0x122AD90 VA: 0x18122C390
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122E270 Offset: 0x122CC70 VA: 0x18122E270
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x12303A0 Offset: 0x122EDA0 VA: 0x1812303A0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122CB00 Offset: 0x122B500 VA: 0x18122CB00
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122F580 Offset: 0x122DF80 VA: 0x18122F580
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122D160 Offset: 0x122BB60 VA: 0x18122D160
	|-Task<bool>..ctor
	|
	|-RVA: 0x122E010 Offset: 0x122CA10 VA: 0x18122E010
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122E060 Offset: 0x122CA60 VA: 0x18122E060
	|-Task<char>..ctor
	|
	|-RVA: 0x122B640 Offset: 0x122A040 VA: 0x18122B640
	|-Task<int>..ctor
	|
	|-RVA: 0x122C030 Offset: 0x122AA30 VA: 0x18122C030
	|-Task<object>..ctor
	|
	|-RVA: 0x122F300 Offset: 0x122DD00 VA: 0x18122F300
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122C340 Offset: 0x122AD40 VA: 0x18122C340
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122F530 Offset: 0x122DF30 VA: 0x18122F530
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122D5B0 Offset: 0x122BFB0 VA: 0x18122D5B0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122EF70 Offset: 0x122D970 VA: 0x18122EF70
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x1230030 Offset: 0x122EA30 VA: 0x181230030
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122B8C0 Offset: 0x122A2C0 VA: 0x18122B8C0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122BE70 Offset: 0x122A870 VA: 0x18122BE70
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122F870 Offset: 0x122E270 VA: 0x18122F870
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122EB80 Offset: 0x122D580 VA: 0x18122EB80
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122D7D0 Offset: 0x122C1D0 VA: 0x18122D7D0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122F7F0 Offset: 0x122E1F0 VA: 0x18122F7F0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122C7A0 Offset: 0x122B1A0 VA: 0x18122C7A0
	|-Task<bool>..ctor
	|
	|-RVA: 0x122BD50 Offset: 0x122A750 VA: 0x18122BD50
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122C520 Offset: 0x122AF20 VA: 0x18122C520
	|-Task<char>..ctor
	|
	|-RVA: 0x122C420 Offset: 0x122AE20 VA: 0x18122C420
	|-Task<int>..ctor
	|
	|-RVA: 0x122D900 Offset: 0x122C300 VA: 0x18122D900
	|-Task<object>..ctor
	|
	|-RVA: 0x122B840 Offset: 0x122A240 VA: 0x18122B840
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122DDF0 Offset: 0x122C7F0 VA: 0x18122DDF0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122C4A0 Offset: 0x122AEA0 VA: 0x18122C4A0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122FEE0 Offset: 0x122E8E0 VA: 0x18122FEE0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122DCF0 Offset: 0x122C6F0 VA: 0x18122DCF0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122E6A0 Offset: 0x122D0A0 VA: 0x18122E6A0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122C8B0 Offset: 0x122B2B0 VA: 0x18122C8B0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122EE30 Offset: 0x122D830 VA: 0x18122EE30
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122B690 Offset: 0x122A090 VA: 0x18122B690
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122CE60 Offset: 0x122B860 VA: 0x18122CE60
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122DF90 Offset: 0x122C990 VA: 0x18122DF90
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122DB00 Offset: 0x122C500 VA: 0x18122DB00
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122FBF0 Offset: 0x122E5F0 VA: 0x18122FBF0
	|-Task<bool>..ctor
	|
	|-RVA: 0x122BB30 Offset: 0x122A530 VA: 0x18122BB30
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122F5D0 Offset: 0x122DFD0 VA: 0x18122F5D0
	|-Task<char>..ctor
	|
	|-RVA: 0x122E980 Offset: 0x122D380 VA: 0x18122E980
	|-Task<int>..ctor
	|
	|-RVA: 0x122EB00 Offset: 0x122D500 VA: 0x18122EB00
	|-Task<object>..ctor
	|
	|-RVA: 0x122F350 Offset: 0x122DD50 VA: 0x18122F350
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122D360 Offset: 0x122BD60 VA: 0x18122D360
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122BC40 Offset: 0x122A640 VA: 0x18122BC40
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122EFF0 Offset: 0x122D9F0 VA: 0x18122EFF0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122BBB0 Offset: 0x122A5B0 VA: 0x18122BBB0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122D4C0 Offset: 0x122BEC0 VA: 0x18122D4C0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122D2C0 Offset: 0x122BCC0 VA: 0x18122D2C0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122CA70 Offset: 0x122B470 VA: 0x18122CA70
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122EDA0 Offset: 0x122D7A0 VA: 0x18122EDA0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122BDD0 Offset: 0x122A7D0 VA: 0x18122BDD0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122D3D0 Offset: 0x122BDD0 VA: 0x18122D3D0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122D0B0 Offset: 0x122BAB0 VA: 0x18122D0B0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122DE70 Offset: 0x122C870 VA: 0x18122DE70
	|-Task<bool>..ctor
	|
	|-RVA: 0x122D980 Offset: 0x122C380 VA: 0x18122D980
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122E840 Offset: 0x122D240 VA: 0x18122E840
	|-Task<char>..ctor
	|
	|-RVA: 0x1230310 Offset: 0x122ED10 VA: 0x181230310
	|-Task<int>..ctor
	|
	|-RVA: 0x122C5E0 Offset: 0x122AFE0 VA: 0x18122C5E0
	|-Task<object>..ctor
	|
	|-RVA: 0x122C680 Offset: 0x122B080 VA: 0x18122C680
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122E610 Offset: 0x122D010 VA: 0x18122E610
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122FDC0 Offset: 0x122E7C0 VA: 0x18122FDC0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122E9F0 Offset: 0x122D3F0 VA: 0x18122E9F0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122EEA0 Offset: 0x122D8A0 VA: 0x18122EEA0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122F2C0 Offset: 0x122DCC0 VA: 0x18122F2C0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122EA30 Offset: 0x122D430 VA: 0x18122EA30
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122F7B0 Offset: 0x122E1B0 VA: 0x18122F7B0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122BEF0 Offset: 0x122A8F0 VA: 0x18122BEF0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122D480 Offset: 0x122BE80 VA: 0x18122D480
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122DC30 Offset: 0x122C630 VA: 0x18122DC30
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122C130 Offset: 0x122AB30 VA: 0x18122C130
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122D1B0 Offset: 0x122BBB0 VA: 0x18122D1B0
	|-Task<bool>..ctor
	|
	|-RVA: 0x122CE20 Offset: 0x122B820 VA: 0x18122CE20
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122CF90 Offset: 0x122B990 VA: 0x18122CF90
	|-Task<char>..ctor
	|
	|-RVA: 0x122C300 Offset: 0x122AD00 VA: 0x18122C300
	|-Task<int>..ctor
	|
	|-RVA: 0x122C760 Offset: 0x122B160 VA: 0x18122C760
	|-Task<object>..ctor
	|
	|-RVA: 0x122BAF0 Offset: 0x122A4F0 VA: 0x18122BAF0
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122E800 Offset: 0x122D200 VA: 0x18122E800
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122E540 Offset: 0x122CF40 VA: 0x18122E540
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122F0D0 Offset: 0x122DAD0 VA: 0x18122F0D0
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122D630 Offset: 0x122C030 VA: 0x18122D630
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122ED20 Offset: 0x122D720 VA: 0x18122ED20
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122EC00 Offset: 0x122D600 VA: 0x18122EC00
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122DCB0 Offset: 0x122C6B0 VA: 0x18122DCB0
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122D280 Offset: 0x122BC80 VA: 0x18122D280
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122C3E0 Offset: 0x122ADE0 VA: 0x18122C3E0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1230160 Offset: 0x122EB60 VA: 0x181230160
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122E340 Offset: 0x122CD40 VA: 0x18122E340
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122C5A0 Offset: 0x122AFA0 VA: 0x18122C5A0
	|-Task<bool>..ctor
	|
	|-RVA: 0x122FC60 Offset: 0x122E660 VA: 0x18122FC60
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122DC70 Offset: 0x122C670 VA: 0x18122DC70
	|-Task<char>..ctor
	|
	|-RVA: 0x122E300 Offset: 0x122CD00 VA: 0x18122E300
	|-Task<int>..ctor
	|
	|-RVA: 0x122ED60 Offset: 0x122D760 VA: 0x18122ED60
	|-Task<object>..ctor
	|
	|-RVA: 0x122C720 Offset: 0x122B120 VA: 0x18122C720
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122B940 Offset: 0x122A340 VA: 0x18122B940
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122E2C0 Offset: 0x122CCC0 VA: 0x18122E2C0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122E720 Offset: 0x122D120 VA: 0x18122E720
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122E0B0 Offset: 0x122CAB0 VA: 0x18122E0B0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122FA30 Offset: 0x122E430 VA: 0x18122FA30
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x1230230 Offset: 0x122EC30 VA: 0x181230230
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122C220 Offset: 0x122AC20 VA: 0x18122C220
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122CD40 Offset: 0x122B740 VA: 0x18122CD40
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122F6D0 Offset: 0x122E0D0 VA: 0x18122F6D0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122EC40 Offset: 0x122D640 VA: 0x18122EC40
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122E190 Offset: 0x122CB90 VA: 0x18122E190
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122FB10 Offset: 0x122E510 VA: 0x18122FB10
	|-Task<bool>..ctor
	|
	|-RVA: 0x122CFD0 Offset: 0x122B9D0 VA: 0x18122CFD0
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122BA10 Offset: 0x122A410 VA: 0x18122BA10
	|-Task<char>..ctor
	|
	|-RVA: 0x122E380 Offset: 0x122CD80 VA: 0x18122E380
	|-Task<int>..ctor
	|
	|-RVA: 0x122DA20 Offset: 0x122C420 VA: 0x18122DA20
	|-Task<object>..ctor
	|
	|-RVA: 0x122FF50 Offset: 0x122E950 VA: 0x18122FF50
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122E460 Offset: 0x122CE60 VA: 0x18122E460
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122F3D0 Offset: 0x122DDD0 VA: 0x18122F3D0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122C930 Offset: 0x122B330 VA: 0x18122C930
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x12300B0 Offset: 0x122EAB0 VA: 0x1812300B0
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122F1C0 Offset: 0x122DBC0 VA: 0x18122F1C0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x122F110 Offset: 0x122DB10 VA: 0x18122F110
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122C170 Offset: 0x122AB70 VA: 0x18122C170
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122E8D0 Offset: 0x122D2D0 VA: 0x18122E8D0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122C080 Offset: 0x122AA80 VA: 0x18122C080
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122D720 Offset: 0x122C120 VA: 0x18122D720
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122F980 Offset: 0x122E380 VA: 0x18122F980
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122B700 Offset: 0x122A100 VA: 0x18122B700
	|-Task<bool>..ctor
	|
	|-RVA: 0x122DB80 Offset: 0x122C580 VA: 0x18122DB80
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122CEE0 Offset: 0x122B8E0 VA: 0x18122CEE0
	|-Task<char>..ctor
	|
	|-RVA: 0x122D850 Offset: 0x122C250 VA: 0x18122D850
	|-Task<int>..ctor
	|
	|-RVA: 0x122CC90 Offset: 0x122B690 VA: 0x18122CC90
	|-Task<object>..ctor
	|
	|-RVA: 0x122D670 Offset: 0x122C070 VA: 0x18122D670
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122CB50 Offset: 0x122B550 VA: 0x18122CB50
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122BF30 Offset: 0x122A930 VA: 0x18122BF30
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122EA70 Offset: 0x122D470 VA: 0x18122EA70
	|-Task<Nullable<bool>>..ctor
	|
	|-RVA: 0x122F640 Offset: 0x122E040 VA: 0x18122F640
	|-Task<Nullable<DateTime>>..ctor
	|
	|-RVA: 0x122F4A0 Offset: 0x122DEA0 VA: 0x18122F4A0
	|-Task<Nullable<DateTimeOffset>>..ctor
	|
	|-RVA: 0x12301A0 Offset: 0x122EBA0 VA: 0x1812301A0
	|-Task<Nullable<Decimal>>..ctor
	|
	|-RVA: 0x122C820 Offset: 0x122B220 VA: 0x18122C820
	|-Task<Nullable<double>>..ctor
	|
	|-RVA: 0x122CC00 Offset: 0x122B600 VA: 0x18122CC00
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x122D1F0 Offset: 0x122BBF0 VA: 0x18122D1F0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x122E580 Offset: 0x122CF80 VA: 0x18122E580
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x122FCA0 Offset: 0x122E6A0 VA: 0x18122FCA0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x122F8F0 Offset: 0x122E2F0 VA: 0x18122F8F0
	|-Task<bool>..ctor
	|
	|-RVA: 0x122C9E0 Offset: 0x122B3E0 VA: 0x18122C9E0
	|-Task<ChannelToken>..ctor
	|
	|-RVA: 0x122EEE0 Offset: 0x122D8E0 VA: 0x18122EEE0
	|-Task<char>..ctor
	|
	|-RVA: 0x122B7B0 Offset: 0x122A1B0 VA: 0x18122B7B0
	|-Task<int>..ctor
	|
	|-RVA: 0x122DF00 Offset: 0x122C900 VA: 0x18122DF00
	|-Task<object>..ctor
	|
	|-RVA: 0x122B980 Offset: 0x122A380 VA: 0x18122B980
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0x122DD60 Offset: 0x122C760 VA: 0x18122DD60
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x122FD30 Offset: 0x122E730 VA: 0x18122FD30
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1229270 Offset: 0x1227C70 VA: 0x181229270
	|-Task<Nullable<bool>>.StartNew
	|
	|-RVA: 0x1229410 Offset: 0x1227E10 VA: 0x181229410
	|-Task<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x122AB80 Offset: 0x1229580 VA: 0x18122AB80
	|-Task<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x1227980 Offset: 0x1226380 VA: 0x181227980
	|-Task<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x1228030 Offset: 0x1226A30 VA: 0x181228030
	|-Task<Nullable<double>>.StartNew
	|
	|-RVA: 0x1228D80 Offset: 0x1227780 VA: 0x181228D80
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1229AD0 Offset: 0x12284D0 VA: 0x181229AD0
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x122A810 Offset: 0x1229210 VA: 0x18122A810
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x1228380 Offset: 0x1226D80 VA: 0x181228380
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x12286D0 Offset: 0x12270D0 VA: 0x1812286D0
	|-Task<bool>.StartNew
	|
	|-RVA: 0x12277E0 Offset: 0x12261E0 VA: 0x1812277E0
	|-Task<ChannelToken>.StartNew
	|
	|-RVA: 0x12290D0 Offset: 0x1227AD0 VA: 0x1812290D0
	|-Task<char>.StartNew
	|
	|-RVA: 0x122A4C0 Offset: 0x1228EC0 VA: 0x18122A4C0
	|-Task<int>.StartNew
	|
	|-RVA: 0x1227490 Offset: 0x1225E90 VA: 0x181227490
	|-Task<object>.StartNew
	|
	|-RVA: 0x1229E20 Offset: 0x1228820 VA: 0x181229E20
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x122A170 Offset: 0x1228B70 VA: 0x18122A170
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x1229910 Offset: 0x1228310 VA: 0x181229910
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1229FC0 Offset: 0x12289C0 VA: 0x181229FC0
	|-Task<Nullable<bool>>.StartNew
	|
	|-RVA: 0x1229760 Offset: 0x1228160 VA: 0x181229760
	|-Task<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x1228BD0 Offset: 0x12275D0 VA: 0x181228BD0
	|-Task<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x12295B0 Offset: 0x1227FB0 VA: 0x1812295B0
	|-Task<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x1227E80 Offset: 0x1226880 VA: 0x181227E80
	|-Task<Nullable<double>>.StartNew
	|
	|-RVA: 0x12281D0 Offset: 0x1226BD0 VA: 0x1812281D0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1228A20 Offset: 0x1227420 VA: 0x181228A20
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x1229C70 Offset: 0x1228670 VA: 0x181229C70
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x122A660 Offset: 0x1229060 VA: 0x18122A660
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x1228520 Offset: 0x1226F20 VA: 0x181228520
	|-Task<bool>.StartNew
	|
	|-RVA: 0x122A310 Offset: 0x1228D10 VA: 0x18122A310
	|-Task<ChannelToken>.StartNew
	|
	|-RVA: 0x1227CD0 Offset: 0x12266D0 VA: 0x181227CD0
	|-Task<char>.StartNew
	|
	|-RVA: 0x1227B20 Offset: 0x1226520 VA: 0x181227B20
	|-Task<int>.StartNew
	|
	|-RVA: 0x1228F20 Offset: 0x1227920 VA: 0x181228F20
	|-Task<object>.StartNew
	|
	|-RVA: 0x1228870 Offset: 0x1227270 VA: 0x181228870
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x1227630 Offset: 0x1226030 VA: 0x181227630
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x122A9B0 Offset: 0x12293B0 VA: 0x18122A9B0
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x122AD20 Offset: 0x1229720 VA: 0x18122AD20
	|-Task<Nullable<bool>>.TrySetResult
	|-Task<char>.TrySetResult
	|
	|-RVA: 0x122AE80 Offset: 0x1229880 VA: 0x18122AE80
	|-Task<Nullable<DateTime>>.TrySetResult
	|-Task<Nullable<double>>.TrySetResult
	|
	|-RVA: 0x122B1F0 Offset: 0x1229BF0 VA: 0x18122B1F0
	|-Task<Nullable<DateTimeOffset>>.TrySetResult
	|-Task<Nullable<Decimal>>.TrySetResult
	|
	|-RVA: 0x122AF30 Offset: 0x1229930 VA: 0x18122AF30
	|-Task<Nullable<int>>.TrySetResult
	|
	|-RVA: 0x122B410 Offset: 0x1229E10 VA: 0x18122B410
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|
	|-RVA: 0x122B580 Offset: 0x1229F80 VA: 0x18122B580
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0x122B130 Offset: 0x1229B30 VA: 0x18122B130
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|
	|-RVA: 0x122B2A0 Offset: 0x1229CA0 VA: 0x18122B2A0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x122B350 Offset: 0x1229D50 VA: 0x18122B350
	|-Task<ChannelToken>.TrySetResult
	|-Task<SerializableProjectConfiguration>.TrySetResult
	|
	|-RVA: 0x122B4D0 Offset: 0x1229ED0 VA: 0x18122B4D0
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x122ADD0 Offset: 0x12297D0 VA: 0x18122ADD0
	|-Task<object>.TrySetResult
	|
	|-RVA: 0x122AFE0 Offset: 0x12299E0 VA: 0x18122AFE0
	|-Task<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1226480 Offset: 0x1224E80 VA: 0x181226480
	|-Task<Nullable<bool>>.DangerousSetResult
	|
	|-RVA: 0x1225D50 Offset: 0x1224750 VA: 0x181225D50
	|-Task<Nullable<DateTime>>.DangerousSetResult
	|-Task<Nullable<double>>.DangerousSetResult
	|
	|-RVA: 0x1225E10 Offset: 0x1224810 VA: 0x181225E10
	|-Task<Nullable<DateTimeOffset>>.DangerousSetResult
	|-Task<Nullable<Decimal>>.DangerousSetResult
	|
	|-RVA: 0x12263D0 Offset: 0x1224DD0 VA: 0x1812263D0
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x12262B0 Offset: 0x1224CB0 VA: 0x1812262B0
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|
	|-RVA: 0x12261D0 Offset: 0x1224BD0 VA: 0x1812261D0
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0x1225C70 Offset: 0x1224670 VA: 0x181225C70
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|
	|-RVA: 0x1225EE0 Offset: 0x12248E0 VA: 0x181225EE0
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x1225BA0 Offset: 0x12245A0 VA: 0x181225BA0
	|-Task<ChannelToken>.DangerousSetResult
	|-Task<SerializableProjectConfiguration>.DangerousSetResult
	|
	|-RVA: 0x1226110 Offset: 0x1224B10 VA: 0x181226110
	|-Task<char>.DangerousSetResult
	|
	|-RVA: 0x1226380 Offset: 0x1224D80 VA: 0x181226380
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x1226170 Offset: 0x1224B70 VA: 0x181226170
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x12260C0 Offset: 0x1224AC0 VA: 0x1812260C0
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1225F90 Offset: 0x1224990 VA: 0x181225F90
	|-Task<__Il2CppFullySharedGenericType>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1230C50 Offset: 0x122F650 VA: 0x181230C50
	|-Task<Nullable<bool>>.get_Result
	|-Task<char>.get_Result
	|
	|-RVA: 0x1230B00 Offset: 0x122F500 VA: 0x181230B00
	|-Task<Nullable<DateTime>>.get_Result
	|-Task<Nullable<double>>.get_Result
	|-Task<ValueTuple<bool, object>>.get_Result
	|-Task<ChannelToken>.get_Result
	|-Task<SerializableProjectConfiguration>.get_Result
	|
	|-RVA: 0x1230930 Offset: 0x122F330 VA: 0x181230930
	|-Task<Nullable<DateTimeOffset>>.get_Result
	|-Task<Nullable<Decimal>>.get_Result
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0x12309E0 Offset: 0x122F3E0 VA: 0x1812309E0
	|-Task<Nullable<int>>.get_Result
	|-Task<object>.get_Result
	|
	|-RVA: 0x1230BA0 Offset: 0x122F5A0 VA: 0x181230BA0
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|
	|-RVA: 0x1230A70 Offset: 0x122F470 VA: 0x181230A70
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1230CE0 Offset: 0x122F6E0 VA: 0x181230CE0
	|-Task<int>.get_Result
	|
	|-RVA: 0x1230D70 Offset: 0x122F770 VA: 0x181230D70
	|-Task<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1230870 Offset: 0x122F270 VA: 0x181230870
	|-Task<Nullable<bool>>.get_ResultOnSuccess
	|-Task<char>.get_ResultOnSuccess
	|
	|-RVA: 0x84E920 Offset: 0x84D320 VA: 0x18084E920
	|-Task<Nullable<DateTime>>.get_ResultOnSuccess
	|-Task<Nullable<double>>.get_ResultOnSuccess
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|-Task<ChannelToken>.get_ResultOnSuccess
	|-Task<SerializableProjectConfiguration>.get_ResultOnSuccess
	|
	|-RVA: 0xCC9F40 Offset: 0xCC8940 VA: 0x180CC9F40
	|-Task<Nullable<DateTimeOffset>>.get_ResultOnSuccess
	|-Task<Nullable<Decimal>>.get_ResultOnSuccess
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x1230850 Offset: 0x122F250 VA: 0x181230850
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x1230880 Offset: 0x122F280 VA: 0x181230880
	|-Task<__Il2CppFullySharedGenericType>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1226670 Offset: 0x1225070 VA: 0x181226670
	|-Task<Nullable<bool>>.GetResultCore
	|-Task<char>.GetResultCore
	|
	|-RVA: 0x1226560 Offset: 0x1224F60 VA: 0x181226560
	|-Task<Nullable<DateTime>>.GetResultCore
	|-Task<Nullable<double>>.GetResultCore
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|-Task<ChannelToken>.GetResultCore
	|-Task<SerializableProjectConfiguration>.GetResultCore
	|
	|-RVA: 0x12266F0 Offset: 0x12250F0 VA: 0x1812266F0
	|-Task<Nullable<DateTimeOffset>>.GetResultCore
	|-Task<Nullable<Decimal>>.GetResultCore
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0x12265F0 Offset: 0x1224FF0 VA: 0x1812265F0
	|-Task<Nullable<int>>.GetResultCore
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x1226790 Offset: 0x1225190 VA: 0x181226790
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|
	|-RVA: 0x1226830 Offset: 0x1225230 VA: 0x181226830
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x12268B0 Offset: 0x12252B0 VA: 0x1812268B0
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x1226930 Offset: 0x1225330 VA: 0x181226930
	|-Task<__Il2CppFullySharedGenericType>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12303F0 Offset: 0x122EDF0 VA: 0x1812303F0
	|-Task<Nullable<bool>>.get_Factory
	|-Task<Nullable<DateTime>>.get_Factory
	|-Task<Nullable<DateTimeOffset>>.get_Factory
	|-Task<Nullable<Decimal>>.get_Factory
	|-Task<Nullable<double>>.get_Factory
	|-Task<Nullable<int>>.get_Factory
	|-Task<ValueTuple<bool, object>>.get_Factory
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<ChannelToken>.get_Factory
	|
	|-RVA: 0x1230540 Offset: 0x122EF40 VA: 0x181230540
	|-Task<char>.get_Factory
	|-Task<int>.get_Factory
	|-Task<object>.get_Factory
	|-Task<SerializableProjectConfiguration>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	|
	|-RVA: 0x12306D0 Offset: 0x122F0D0 VA: 0x1812306D0
	|-Task<__Il2CppFullySharedGenericType>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1227310 Offset: 0x1225D10 VA: 0x181227310
	|-Task<Nullable<bool>>.InnerInvoke
	|-Task<char>.InnerInvoke
	|
	|-RVA: 0x1226FD0 Offset: 0x12259D0 VA: 0x181226FD0
	|-Task<Nullable<DateTime>>.InnerInvoke
	|-Task<Nullable<double>>.InnerInvoke
	|
	|-RVA: 0x1226A40 Offset: 0x1225440 VA: 0x181226A40
	|-Task<Nullable<DateTimeOffset>>.InnerInvoke
	|-Task<Nullable<Decimal>>.InnerInvoke
	|
	|-RVA: 0x12273D0 Offset: 0x1225DD0 VA: 0x1812273D0
	|-Task<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x1227170 Offset: 0x1225B70 VA: 0x181227170
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x1226C70 Offset: 0x1225670 VA: 0x181226C70
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x1226EF0 Offset: 0x12258F0 VA: 0x181226EF0
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x12270A0 Offset: 0x1225AA0 VA: 0x1812270A0
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1226E20 Offset: 0x1225820 VA: 0x181226E20
	|-Task<ChannelToken>.InnerInvoke
	|-Task<SerializableProjectConfiguration>.InnerInvoke
	|
	|-RVA: 0x1226D50 Offset: 0x1225750 VA: 0x181226D50
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x1227240 Offset: 0x1225C40 VA: 0x181227240
	|-Task<object>.InnerInvoke
	|
	|-RVA: 0x1226B10 Offset: 0x1225510 VA: 0x181226B10
	|-Task<__Il2CppFullySharedGenericType>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1226530 Offset: 0x1224F30 VA: 0x181226530
	|-Task<Nullable<bool>>.GetAwaiter
	|-Task<Nullable<DateTime>>.GetAwaiter
	|-Task<Nullable<DateTimeOffset>>.GetAwaiter
	|-Task<Nullable<Decimal>>.GetAwaiter
	|-Task<Nullable<double>>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<ChannelToken>.GetAwaiter
	|-Task<char>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<SerializableProjectConfiguration>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	|-Task<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121D8F0 Offset: 0x121C2F0 VA: 0x18121D8F0
	|-Task<Nullable<bool>>.ConfigureAwait
	|-Task<Nullable<DateTime>>.ConfigureAwait
	|-Task<Nullable<DateTimeOffset>>.ConfigureAwait
	|-Task<Nullable<Decimal>>.ConfigureAwait
	|-Task<Nullable<double>>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<ChannelToken>.ConfigureAwait
	|-Task<char>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<SerializableProjectConfiguration>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	|-Task<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1223480 Offset: 0x1221E80 VA: 0x181223480
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x12206E0 Offset: 0x121F0E0 VA: 0x1812206E0
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x1220500 Offset: 0x121EF00 VA: 0x181220500
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x12255E0 Offset: 0x1223FE0 VA: 0x1812255E0
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x12259C0 Offset: 0x12243C0 VA: 0x1812259C0
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x121FB20 Offset: 0x121E520 VA: 0x18121FB20
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x121EB20 Offset: 0x121D520 VA: 0x18121EB20
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x1222480 Offset: 0x1220E80 VA: 0x181222480
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x1220EA0 Offset: 0x121F8A0 VA: 0x181220EA0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x1224A20 Offset: 0x1223420 VA: 0x181224A20
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1220AC0 Offset: 0x121F4C0 VA: 0x181220AC0
	|-Task<ChannelToken>.ContinueWith
	|
	|-RVA: 0x121F340 Offset: 0x121DD40 VA: 0x18121F340
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x12232A0 Offset: 0x1221CA0 VA: 0x1812232A0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1224C00 Offset: 0x1223600 VA: 0x181224C00
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x1223C40 Offset: 0x1222640 VA: 0x181223C40
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x1223860 Offset: 0x1222260 VA: 0x181223860
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x121ED00 Offset: 0x121D700 VA: 0x18121ED00
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1220CA0 Offset: 0x121F6A0 VA: 0x181220CA0
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x121E320 Offset: 0x121CD20 VA: 0x18121E320
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x1224DE0 Offset: 0x12237E0 VA: 0x181224DE0
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x1222E60 Offset: 0x1221860 VA: 0x181222E60
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x1220300 Offset: 0x121ED00 VA: 0x181220300
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x1222C60 Offset: 0x1221660 VA: 0x181222C60
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1224420 Offset: 0x1222E20 VA: 0x181224420
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x12251E0 Offset: 0x1223BE0 VA: 0x1812251E0
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x1223E20 Offset: 0x1222820 VA: 0x181223E20
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x1224FE0 Offset: 0x12239E0 VA: 0x181224FE0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x121F520 Offset: 0x121DF20 VA: 0x18121F520
	|-Task<ChannelToken>.ContinueWith
	|
	|-RVA: 0x1223660 Offset: 0x1222060 VA: 0x181223660
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x1221080 Offset: 0x121FA80 VA: 0x181221080
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x121ED40 Offset: 0x121D740 VA: 0x18121ED40
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x12257C0 Offset: 0x12241C0 VA: 0x1812257C0
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x121F920 Offset: 0x121E320 VA: 0x18121F920
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x1222080 Offset: 0x1220A80 VA: 0x181222080
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1222A60 Offset: 0x1221460 VA: 0x181222A60
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x1224020 Offset: 0x1222A20 VA: 0x181224020
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x121FD00 Offset: 0x121E700 VA: 0x18121FD00
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x1221680 Offset: 0x1220080 VA: 0x181221680
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x1221480 Offset: 0x121FE80 VA: 0x181221480
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x1221E80 Offset: 0x1220880 VA: 0x181221E80
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1220100 Offset: 0x121EB00 VA: 0x181220100
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x121E120 Offset: 0x121CB20 VA: 0x18121E120
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x1224220 Offset: 0x1222C20 VA: 0x181224220
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x121EF40 Offset: 0x121D940 VA: 0x18121EF40
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1223A40 Offset: 0x1222440 VA: 0x181223A40
	|-Task<ChannelToken>.ContinueWith
	|
	|-RVA: 0x1224620 Offset: 0x1223020 VA: 0x181224620
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x1224820 Offset: 0x1223220 VA: 0x181224820
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1221A80 Offset: 0x1220480 VA: 0x181221A80
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x121E520 Offset: 0x121CF20 VA: 0x18121E520
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x1221280 Offset: 0x121FC80 VA: 0x181221280
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x1223060 Offset: 0x1221A60 VA: 0x181223060
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1221880 Offset: 0x1220280 VA: 0x181221880
	|-Task<Nullable<bool>>.ContinueWith
	|
	|-RVA: 0x121DF20 Offset: 0x121C920 VA: 0x18121DF20
	|-Task<Nullable<DateTime>>.ContinueWith
	|
	|-RVA: 0x121FF00 Offset: 0x121E900 VA: 0x18121FF00
	|-Task<Nullable<DateTimeOffset>>.ContinueWith
	|
	|-RVA: 0x1221C80 Offset: 0x1220680 VA: 0x181221C80
	|-Task<Nullable<Decimal>>.ContinueWith
	|
	|-RVA: 0x1222860 Offset: 0x1221260 VA: 0x181222860
	|-Task<Nullable<double>>.ContinueWith
	|
	|-RVA: 0x121F140 Offset: 0x121DB40 VA: 0x18121F140
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x121E920 Offset: 0x121D320 VA: 0x18121E920
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x1222280 Offset: 0x1220C80 VA: 0x181222280
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x12208C0 Offset: 0x121F2C0 VA: 0x1812208C0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x12253E0 Offset: 0x1223DE0 VA: 0x1812253E0
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x121D920 Offset: 0x121C320 VA: 0x18121D920
	|-Task<ChannelToken>.ContinueWith
	|
	|-RVA: 0x121F720 Offset: 0x121E120 VA: 0x18121F720
	|-Task<char>.ContinueWith
	|
	|-RVA: 0x121E720 Offset: 0x121D120 VA: 0x18121E720
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1222660 Offset: 0x1221060 VA: 0x181222660
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x12230A0 Offset: 0x1221AA0 VA: 0x1812230A0
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0x121DD20 Offset: 0x121C720 VA: 0x18121DD20
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x121DB20 Offset: 0x121C520 VA: 0x18121DB20
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCCAC0 Offset: 0xDCB4C0 VA: 0x180DCCAC0
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0xDCCCD0 Offset: 0xDCB6D0 VA: 0x180DCCCD0
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0xDCC840 Offset: 0xDCB240 VA: 0x180DCC840
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCCEE0 Offset: 0xDCB8E0 VA: 0x180DCCEE0
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0xDCC8E0 Offset: 0xDCB2E0 VA: 0x180DCC8E0
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0xDCC650 Offset: 0xDCB050 VA: 0x180DCC650
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/
}
