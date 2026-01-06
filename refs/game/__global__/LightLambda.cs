internal class LightLambda // TypeDefIndex: 15428
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Properties
	internal string DebugView { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TRet Run0<TRet>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBF50 Offset: 0xEEA950 VA: 0x180EEBF50
	|-LightLambda.Run0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FEF670 Offset: 0x1FEE070 VA: 0x181FEF670
	internal void RunVoid0() { }

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun0<TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FEF600 Offset: 0x1FEE000 VA: 0x181FEF600
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	// RVA: -1 Offset: -1
	internal TRet Run1<T0, TRet>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF0B40 Offset: 0xEEF540 VA: 0x180EF0B40
	|-LightLambda.Run1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid1<T0>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF8640 Offset: 0xEF7040 VA: 0x180EF8640
	|-LightLambda.RunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF0DB0 Offset: 0xEEF7B0 VA: 0x180EF0DB0
	|-LightLambda.Run2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF87F0 Offset: 0xEF71F0 VA: 0x180EF87F0
	|-LightLambda.RunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF1100 Offset: 0xEEFB00 VA: 0x180EF1100
	|-LightLambda.Run3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF8AA0 Offset: 0xEF74A0 VA: 0x180EF8AA0
	|-LightLambda.RunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF1510 Offset: 0xEEFF10 VA: 0x180EF1510
	|-LightLambda.Run4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF8E20 Offset: 0xEF7820 VA: 0x180EF8E20
	|-LightLambda.RunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF19F0 Offset: 0xEF03F0 VA: 0x180EF19F0
	|-LightLambda.Run5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF9280 Offset: 0xEF7C80 VA: 0x180EF9280
	|-LightLambda.RunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF1FA0 Offset: 0xEF09A0 VA: 0x180EF1FA0
	|-LightLambda.Run6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF97B0 Offset: 0xEF81B0 VA: 0x180EF97B0
	|-LightLambda.RunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF2630 Offset: 0xEF1030 VA: 0x180EF2630
	|-LightLambda.Run7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF9DC0 Offset: 0xEF87C0 VA: 0x180EF9DC0
	|-LightLambda.RunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF2DA0 Offset: 0xEF17A0 VA: 0x180EF2DA0
	|-LightLambda.Run8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFA4A0 Offset: 0xEF8EA0 VA: 0x180EFA4A0
	|-LightLambda.RunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF35F0 Offset: 0xEF1FF0 VA: 0x180EF35F0
	|-LightLambda.Run9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFAC60 Offset: 0xEF9660 VA: 0x180EFAC60
	|-LightLambda.RunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEC0E0 Offset: 0xEEAAE0 VA: 0x180EEC0E0
	|-LightLambda.Run10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF3F30 Offset: 0xEF2930 VA: 0x180EF3F30
	|-LightLambda.RunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEECB00 Offset: 0xEEB500 VA: 0x180EECB00
	|-LightLambda.Run11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF48C0 Offset: 0xEF32C0 VA: 0x180EF48C0
	|-LightLambda.RunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEED610 Offset: 0xEEC010 VA: 0x180EED610
	|-LightLambda.Run12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5330 Offset: 0xEF3D30 VA: 0x180EF5330
	|-LightLambda.RunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEE200 Offset: 0xEECC00 VA: 0x180EEE200
	|-LightLambda.Run13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF5E90 Offset: 0xEF4890 VA: 0x180EF5E90
	|-LightLambda.RunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEEED0 Offset: 0xEED8D0 VA: 0x180EEEED0
	|-LightLambda.Run14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF6AE0 Offset: 0xEF54E0 VA: 0x180EF6AE0
	|-LightLambda.RunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEFC90 Offset: 0xEEE690 VA: 0x180EEFC90
	|-LightLambda.Run15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7810 Offset: 0xEF6210 VA: 0x180EF7810
	|-LightLambda.RunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRun15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBED0 Offset: 0xEEA8D0 VA: 0x180EEBED0
	|-LightLambda.MakeRunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FEFC00 Offset: 0x1FEE600 VA: 0x181FEFC00
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x1FEFC70 Offset: 0x1FEE670 VA: 0x181FEFC70
	internal string get_DebugView() { }

	// RVA: 0x1FEEA10 Offset: 0x1FED410 VA: 0x181FEEA10
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1FEEC90 Offset: 0x1FED690 VA: 0x181FEEC90
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1FEE200 Offset: 0x1FECC00 VA: 0x181FEE200
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x1FEEBA0 Offset: 0x1FED5A0 VA: 0x181FEEBA0
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x1FEEC20 Offset: 0x1FED620 VA: 0x181FEEC20
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFB500 Offset: 0xEF9F00 VA: 0x180EFB500
	|-LightLambda.RunVoidRef2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FEF970 Offset: 0x1FEE370 VA: 0x181FEF970
	public object Run(object[] arguments) { }

	// RVA: 0x1FEF780 Offset: 0x1FEE180 VA: 0x181FEF780
	public object RunVoid(object[] arguments) { }

	// RVA: 0x1FEFB70 Offset: 0x1FEE570 VA: 0x181FEFB70
	private static void .cctor() { }
}
