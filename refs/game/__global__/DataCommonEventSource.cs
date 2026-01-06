internal class DataCommonEventSource : EventSource // TypeDefIndex: 12878
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x206D350 Offset: 0x206BD50 VA: 0x18206D350
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79AC0 Offset: 0xE784C0 VA: 0x180E79AC0
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0xE79B90 Offset: 0xE78590 VA: 0x180E79B90
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0xE785E0 Offset: 0xE76FE0 VA: 0x180E785E0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE78700 Offset: 0xE77100 VA: 0x180E78700
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0xE78800 Offset: 0xE77200 VA: 0x180E78800
	|-DataCommonEventSource.Trace<int, int>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0xE791A0 Offset: 0xE77BA0 VA: 0x180E791A0
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0xE799E0 Offset: 0xE783E0 VA: 0x180E799E0
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0xE78450 Offset: 0xE76E50 VA: 0x180E78450
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE78900 Offset: 0xE77300 VA: 0x180E78900
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0xE79080 Offset: 0xE77A80 VA: 0x180E79080
	|-DataCommonEventSource.Trace<int, int, int>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0xE792A0 Offset: 0xE77CA0 VA: 0x180E792A0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0xE798F0 Offset: 0xE782F0 VA: 0x180E798F0
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0xE78240 Offset: 0xE76C40 VA: 0x180E78240
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE78DF0 Offset: 0xE777F0 VA: 0x180E78DF0
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE79690 Offset: 0xE78090 VA: 0x180E79690
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0xE77E80 Offset: 0xE76880 VA: 0x180E77E80
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE793B0 Offset: 0xE77DB0 VA: 0x180E793B0
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0xE77A00 Offset: 0xE76400 VA: 0x180E77A00
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE78A20 Offset: 0xE77420 VA: 0x180E78A20
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xE77410 Offset: 0xE75E10 VA: 0x180E77410
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x206D270 Offset: 0x206BC70 VA: 0x18206D270
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE77340 Offset: 0xE75D40 VA: 0x180E77340
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0xE76950 Offset: 0xE75350 VA: 0x180E76950
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76A70 Offset: 0xE75470 VA: 0x180E76A70
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0xE76CA0 Offset: 0xE756A0 VA: 0x180E76CA0
	|-DataCommonEventSource.EnterScope<int, int>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0xE77260 Offset: 0xE75C60 VA: 0x180E77260
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0xE767C0 Offset: 0xE751C0 VA: 0x180E767C0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76B70 Offset: 0xE75570 VA: 0x180E76B70
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0xE77040 Offset: 0xE75A40 VA: 0x180E77040
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0xE77150 Offset: 0xE75B50 VA: 0x180E77150
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0xE765B0 Offset: 0xE74FB0 VA: 0x180E765B0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76DA0 Offset: 0xE757A0 VA: 0x180E76DA0
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0xE761E0 Offset: 0xE74BE0 VA: 0x180E761E0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x206D340 Offset: 0x206BD40 VA: 0x18206D340
	internal void ExitScope(long scopeId) { }

	// RVA: 0x1C0B270 Offset: 0x1C09C70 VA: 0x181C0B270
	public void .ctor() { }

	// RVA: 0x206D360 Offset: 0x206BD60 VA: 0x18206D360
	private static void .cctor() { }
}
