public class TaskFactory<TResult> // TypeDefIndex: 4047
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218990 Offset: 0x1217390 VA: 0x181218990
	|-TaskFactory<Nullable<bool>>..ctor
	|-TaskFactory<Nullable<DateTime>>..ctor
	|-TaskFactory<Nullable<DateTimeOffset>>..ctor
	|-TaskFactory<Nullable<Decimal>>..ctor
	|-TaskFactory<Nullable<double>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<ChannelToken>..ctor
	|-TaskFactory<char>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x121D540 Offset: 0x121BF40 VA: 0x18121D540
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1218910 Offset: 0x1217310 VA: 0x181218910
	|-TaskFactory<Nullable<bool>>..ctor
	|-TaskFactory<Nullable<DateTime>>..ctor
	|-TaskFactory<Nullable<DateTimeOffset>>..ctor
	|-TaskFactory<Nullable<Decimal>>..ctor
	|-TaskFactory<Nullable<double>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<ChannelToken>..ctor
	|-TaskFactory<char>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12182F0 Offset: 0x1216CF0 VA: 0x1812182F0
	|-TaskFactory<Nullable<bool>>.StartNew
	|
	|-RVA: 0x1218870 Offset: 0x1217270 VA: 0x181218870
	|-TaskFactory<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x1218450 Offset: 0x1216E50 VA: 0x181218450
	|-TaskFactory<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x1218030 Offset: 0x1216A30 VA: 0x181218030
	|-TaskFactory<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x1217CB0 Offset: 0x12166B0 VA: 0x181217CB0
	|-TaskFactory<Nullable<double>>.StartNew
	|
	|-RVA: 0x1217C10 Offset: 0x1216610 VA: 0x181217C10
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x12180D0 Offset: 0x1216AD0 VA: 0x1812180D0
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x12184F0 Offset: 0x1216EF0 VA: 0x1812184F0
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x1217ED0 Offset: 0x12168D0 VA: 0x181217ED0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x1217AB0 Offset: 0x12164B0 VA: 0x181217AB0
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1218710 Offset: 0x1217110 VA: 0x181218710
	|-TaskFactory<ChannelToken>.StartNew
	|
	|-RVA: 0x121D370 Offset: 0x121BD70 VA: 0x18121D370
	|-TaskFactory<char>.StartNew
	|
	|-RVA: 0x121C120 Offset: 0x121AB20 VA: 0x18121C120
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x121CFB0 Offset: 0x121B9B0 VA: 0x18121CFB0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x121C6D0 Offset: 0x121B0D0 VA: 0x18121C6D0
	|-TaskFactory<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x121CA90 Offset: 0x121B490 VA: 0x18121CA90
	|-TaskFactory<VoidTaskResult>.StartNew
	|
	|-RVA: 0x121CF10 Offset: 0x121B910 VA: 0x18121CF10
	|-TaskFactory<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1217D50 Offset: 0x1216750 VA: 0x181217D50
	|-TaskFactory<Nullable<bool>>.StartNew
	|
	|-RVA: 0x1218170 Offset: 0x1216B70 VA: 0x181218170
	|-TaskFactory<Nullable<DateTime>>.StartNew
	|
	|-RVA: 0x12179F0 Offset: 0x12163F0 VA: 0x1812179F0
	|-TaskFactory<Nullable<DateTimeOffset>>.StartNew
	|
	|-RVA: 0x1217B50 Offset: 0x1216550 VA: 0x181217B50
	|-TaskFactory<Nullable<Decimal>>.StartNew
	|
	|-RVA: 0x1218390 Offset: 0x1216D90 VA: 0x181218390
	|-TaskFactory<Nullable<double>>.StartNew
	|
	|-RVA: 0x1217E10 Offset: 0x1216810 VA: 0x181217E10
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0x1218590 Offset: 0x1216F90 VA: 0x181218590
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x1218230 Offset: 0x1216C30 VA: 0x181218230
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x12187B0 Offset: 0x12171B0 VA: 0x1812187B0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x1217F70 Offset: 0x1216970 VA: 0x181217F70
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0x1218650 Offset: 0x1217050 VA: 0x181218650
	|-TaskFactory<ChannelToken>.StartNew
	|
	|-RVA: 0x121C8A0 Offset: 0x121B2A0 VA: 0x18121C8A0
	|-TaskFactory<char>.StartNew
	|
	|-RVA: 0x121D180 Offset: 0x121BB80 VA: 0x18121D180
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0x121C2F0 Offset: 0x121ACF0 VA: 0x18121C2F0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0x121CC60 Offset: 0x121B660 VA: 0x18121CC60
	|-TaskFactory<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0x121C4E0 Offset: 0x121AEE0 VA: 0x18121C4E0
	|-TaskFactory<VoidTaskResult>.StartNew
	|
	|-RVA: 0x121CE50 Offset: 0x121B850 VA: 0x18121CE50
	|-TaskFactory<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12139F0 Offset: 0x12123F0 VA: 0x1812139F0
	|-TaskFactory<Nullable<bool>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1214090 Offset: 0x1212A90 VA: 0x181214090
	|-TaskFactory<Nullable<DateTime>>.FromAsyncCoreLogic
	|
	|-RVA: 0x12131C0 Offset: 0x1211BC0 VA: 0x1812131C0
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213830 Offset: 0x1212230 VA: 0x181213830
	|-TaskFactory<Nullable<Decimal>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213020 Offset: 0x1211A20 VA: 0x181213020
	|-TaskFactory<Nullable<double>>.FromAsyncCoreLogic
	|
	|-RVA: 0x12136A0 Offset: 0x12120A0 VA: 0x1812136A0
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213EF0 Offset: 0x12128F0 VA: 0x181213EF0
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213B80 Offset: 0x1212580 VA: 0x181213B80
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213D40 Offset: 0x1212740 VA: 0x181213D40
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213380 Offset: 0x1211D80 VA: 0x181213380
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1213500 Offset: 0x1211F00 VA: 0x181213500
	|-TaskFactory<ChannelToken>.FromAsyncCoreLogic
	|
	|-RVA: 0x1219810 Offset: 0x1218210 VA: 0x181219810
	|-TaskFactory<char>.FromAsyncCoreLogic
	|
	|-RVA: 0x1219DF0 Offset: 0x12187F0 VA: 0x181219DF0
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1219C60 Offset: 0x1218660 VA: 0x181219C60
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1219670 Offset: 0x1218070 VA: 0x181219670
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncCoreLogic
	|
	|-RVA: 0x1219F70 Offset: 0x1218970 VA: 0x181219F70
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x12199A0 Offset: 0x12183A0 VA: 0x1812199A0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12177B0 Offset: 0x12161B0 VA: 0x1812177B0
	|-TaskFactory<Nullable<bool>>.FromAsync
	|
	|-RVA: 0x12177F0 Offset: 0x12161F0 VA: 0x1812177F0
	|-TaskFactory<Nullable<DateTime>>.FromAsync
	|
	|-RVA: 0x1217830 Offset: 0x1216230 VA: 0x181217830
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsync
	|
	|-RVA: 0x1217770 Offset: 0x1216170 VA: 0x181217770
	|-TaskFactory<Nullable<Decimal>>.FromAsync
	|
	|-RVA: 0x12178F0 Offset: 0x12162F0 VA: 0x1812178F0
	|-TaskFactory<Nullable<double>>.FromAsync
	|
	|-RVA: 0x12179B0 Offset: 0x12163B0 VA: 0x1812179B0
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0x1217970 Offset: 0x1216370 VA: 0x181217970
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0x12178B0 Offset: 0x12162B0 VA: 0x1812178B0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0x1217870 Offset: 0x1216270 VA: 0x181217870
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0x1217930 Offset: 0x1216330 VA: 0x181217930
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0x1217730 Offset: 0x1216130 VA: 0x181217730
	|-TaskFactory<ChannelToken>.FromAsync
	|
	|-RVA: 0x121C0E0 Offset: 0x121AAE0 VA: 0x18121C0E0
	|-TaskFactory<char>.FromAsync
	|
	|-RVA: 0x121BF90 Offset: 0x121A990 VA: 0x18121BF90
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0x121C020 Offset: 0x121AA20 VA: 0x18121C020
	|-TaskFactory<object>.FromAsync
	|
	|-RVA: 0x121C060 Offset: 0x121AA60 VA: 0x18121C060
	|-TaskFactory<SerializableProjectConfiguration>.FromAsync
	|
	|-RVA: 0x121C0A0 Offset: 0x121AAA0 VA: 0x18121C0A0
	|-TaskFactory<VoidTaskResult>.FromAsync
	|
	|-RVA: 0x121BFD0 Offset: 0x121A9D0 VA: 0x18121BFD0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1216400 Offset: 0x1214E00 VA: 0x181216400
	|-TaskFactory<Nullable<bool>>.FromAsyncImpl
	|
	|-RVA: 0x12150B0 Offset: 0x1213AB0 VA: 0x1812150B0
	|-TaskFactory<Nullable<DateTime>>.FromAsyncImpl
	|
	|-RVA: 0x1217250 Offset: 0x1215C50 VA: 0x181217250
	|-TaskFactory<Nullable<DateTimeOffset>>.FromAsyncImpl
	|
	|-RVA: 0x12146F0 Offset: 0x12130F0 VA: 0x1812146F0
	|-TaskFactory<Nullable<Decimal>>.FromAsyncImpl
	|
	|-RVA: 0x1215F30 Offset: 0x1214930 VA: 0x181215F30
	|-TaskFactory<Nullable<double>>.FromAsyncImpl
	|
	|-RVA: 0x1214230 Offset: 0x1212C30 VA: 0x181214230
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x1216D80 Offset: 0x1215780 VA: 0x181216D80
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0x1215A50 Offset: 0x1214450 VA: 0x181215A50
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0x1214BD0 Offset: 0x12135D0 VA: 0x181214BD0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0x12168C0 Offset: 0x12152C0 VA: 0x1812168C0
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1215580 Offset: 0x1213F80 VA: 0x181215580
	|-TaskFactory<ChannelToken>.FromAsyncImpl
	|
	|-RVA: 0x121B4A0 Offset: 0x1219EA0 VA: 0x18121B4A0
	|-TaskFactory<char>.FromAsyncImpl
	|
	|-RVA: 0x121AFC0 Offset: 0x12199C0 VA: 0x18121AFC0
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x121A5E0 Offset: 0x1218FE0 VA: 0x18121A5E0
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x121AAC0 Offset: 0x12194C0 VA: 0x18121AAC0
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncImpl
	|
	|-RVA: 0x121A0F0 Offset: 0x1218AF0 VA: 0x18121A0F0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	|
	|-RVA: 0x121B980 Offset: 0x121A380 VA: 0x18121B980
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCC5C0 Offset: 0xDCAFC0 VA: 0x180DCC5C0
	|-TaskFactory<object>.FromAsync<object>
	|
	|-RVA: 0xDCC4A0 Offset: 0xDCAEA0 VA: 0x180DCC4A0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCBB30 Offset: 0xDCA530 VA: 0x180DCBB30
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0xDCB6B0 Offset: 0xDCA0B0 VA: 0x180DCB6B0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	|
	|-RVA: 0xDCABF0 Offset: 0xDC95F0 VA: 0x180DCABF0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCB220 Offset: 0xDC9C20 VA: 0x180DCB220
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, int>
	|
	|-RVA: 0xDCA550 Offset: 0xDC8F50 VA: 0x180DCA550
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCC1A0 Offset: 0xDCABA0 VA: 0x180DCC1A0
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0xDCC320 Offset: 0xDCAD20 VA: 0x180DCC320
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0xDCBFB0 Offset: 0xDCA9B0 VA: 0x180DCBFB0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncTrim<object, __Il2CppFullySharedGenericType>
	*/
}
