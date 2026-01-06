internal static class ArrayHelpers // TypeDefIndex: 7801
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static int LengthSafe<TValue>(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE49F20 Offset: 0xE48920 VA: 0x180E49F20
	|-ArrayHelpers.LengthSafe<InputBinding>
	|-ArrayHelpers.LengthSafe<InputControlScheme>
	|-ArrayHelpers.LengthSafe<object>
	|-ArrayHelpers.LengthSafe<uint>
	|-ArrayHelpers.LengthSafe<__Il2CppFullySharedGenericType>
	|-ArrayHelpers.LengthSafe<InputEventTrace.DeviceInfo>
	|-ArrayHelpers.LengthSafe<InputManager.StateChangeMonitorsForDevice>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Clear<TValue>(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25860 Offset: 0xE24260 VA: 0x180E25860
	|-ArrayHelpers.Clear<object>
	|-ArrayHelpers.Clear<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Clear<TValue>(TValue[] array, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25880 Offset: 0xE24280 VA: 0x180E25880
	|-ArrayHelpers.Clear<object>
	|-ArrayHelpers.Clear<__Il2CppFullySharedGenericType>
	|-ArrayHelpers.Clear<InputManager.StateChangeMonitorListener>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Clear<TValue>(TValue[] array, ref int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25830 Offset: 0xE24230 VA: 0x180E25830
	|-ArrayHelpers.Clear<object>
	|-ArrayHelpers.Clear<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE264A0 Offset: 0xE24EA0 VA: 0x180E264A0
	|-ArrayHelpers.EnsureCapacity<object>
	|-ArrayHelpers.EnsureCapacity<Touch>
	|
	|-RVA: 0xE263A0 Offset: 0xE24DA0 VA: 0x180E263A0
	|-ArrayHelpers.EnsureCapacity<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void DuplicateWithCapacity<TValue>(ref TValue[] array, int count, int capacity, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE26280 Offset: 0xE24C80 VA: 0x180E26280
	|-ArrayHelpers.DuplicateWithCapacity<object>
	|-ArrayHelpers.DuplicateWithCapacity<Touch>
	|-ArrayHelpers.DuplicateWithCapacity<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Contains<TValue>(TValue[] array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25E90 Offset: 0xE24890 VA: 0x180E25E90
	|-ArrayHelpers.Contains<int>
	|
	|-RVA: 0xE26040 Offset: 0xE24A40 VA: 0x180E26040
	|-ArrayHelpers.Contains<object>
	|
	|-RVA: 0xE25D20 Offset: 0xE24720 VA: 0x180E25D20
	|-ArrayHelpers.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsReference<TValue>(TValue[] array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25C90 Offset: 0xE24690 VA: 0x180E25C90
	|-ArrayHelpers.ContainsReference<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsReference<TFirst, TSecond>(TFirst[] array, int count, TSecond value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25C30 Offset: 0xE24630 VA: 0x180E25C30
	|-ArrayHelpers.ContainsReference<object, object>
	|
	|-RVA: 0xE25AC0 Offset: 0xE244C0 VA: 0x180E25AC0
	|-ArrayHelpers.ContainsReference<__Il2CppFullySharedGenericType, object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsReference<TFirst, TSecond>(TFirst[] array, int startIndex, int count, TSecond value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE25BB0 Offset: 0xE245B0 VA: 0x180E25BB0
	|-ArrayHelpers.ContainsReference<object, object>
	|
	|-RVA: 0xE25B30 Offset: 0xE24530 VA: 0x180E25B30
	|-ArrayHelpers.ContainsReference<__Il2CppFullySharedGenericType, object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool HaveDuplicateReferences<TFirst>(TFirst[] first, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47EA0 Offset: 0xE468A0 VA: 0x180E47EA0
	|-ArrayHelpers.HaveDuplicateReferences<object>
	|
	|-RVA: 0xE47CE0 Offset: 0xE466E0 VA: 0x180E47CE0
	|-ArrayHelpers.HaveDuplicateReferences<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool HaveEqualElements<TValue>(TValue[] first, TValue[] second, int count = 2147483647) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47F60 Offset: 0xE46960 VA: 0x180E47F60
	|-ArrayHelpers.HaveEqualElements<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<TValue>(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE48AF0 Offset: 0xE474F0 VA: 0x180E48AF0
	|-ArrayHelpers.IndexOf<int>
	|
	|-RVA: 0xE48BD0 Offset: 0xE475D0 VA: 0x180E48BD0
	|-ArrayHelpers.IndexOf<object>
	|
	|-RVA: 0xE48850 Offset: 0xE47250 VA: 0x180E48850
	|-ArrayHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<TValue>(TValue[] array, Predicate<TValue> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE489E0 Offset: 0xE473E0 VA: 0x180E489E0
	|-ArrayHelpers.IndexOf<InputBinding>
	|
	|-RVA: 0xE48720 Offset: 0xE47120 VA: 0x180E48720
	|-ArrayHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<TValue>(TValue[] array, Predicate<TValue> predicate, int startIndex = 0, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE485E0 Offset: 0xE46FE0 VA: 0x180E485E0
	|-ArrayHelpers.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE482A0 Offset: 0xE46CA0 VA: 0x180E482A0
	|-ArrayHelpers.IndexOfReference<object, object>
	|
	|-RVA: 0xE48130 Offset: 0xE46B30 VA: 0x180E48130
	|-ArrayHelpers.IndexOfReference<__Il2CppFullySharedGenericType, object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<TFirst, TSecond>(TFirst[] array, TSecond value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE48320 Offset: 0xE46D20 VA: 0x180E48320
	|-ArrayHelpers.IndexOfReference<object, object>
	|
	|-RVA: 0xE481A0 Offset: 0xE46BA0 VA: 0x180E481A0
	|-ArrayHelpers.IndexOfReference<__Il2CppFullySharedGenericType, object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfValue<TValue>(TValue[] array, TValue value, int startIndex = 0, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE48510 Offset: 0xE46F10 VA: 0x180E48510
	|-ArrayHelpers.IndexOfValue<InternedString>
	|
	|-RVA: 0xE48390 Offset: 0xE46D90 VA: 0x180E48390
	|-ArrayHelpers.IndexOfValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4AE20 Offset: 0xE49820 VA: 0x180E4AE20
	|-ArrayHelpers.Resize<ulong>
	|
	|-RVA: 0xE4ACB0 Offset: 0xE496B0 VA: 0x180E4ACB0
	|-ArrayHelpers.Resize<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int Append<TValue>(ref TValue[] array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE251F0 Offset: 0xE23BF0 VA: 0x180E251F0
	|-ArrayHelpers.Append<KeyValuePair<InternedString, object>>
	|-ArrayHelpers.Append<InputControlScheme>
	|
	|-RVA: 0xE25080 Offset: 0xE23A80 VA: 0x180E25080
	|-ArrayHelpers.Append<InputBinding>
	|
	|-RVA: 0xE25310 Offset: 0xE23D10 VA: 0x180E25310
	|-ArrayHelpers.Append<int>
	|
	|-RVA: 0xE247F0 Offset: 0xE231F0 VA: 0x180E247F0
	|-ArrayHelpers.Append<InternedString>
	|-ArrayHelpers.Append<InputControlScheme.DeviceRequirement>
	|-ArrayHelpers.Append<InputDeviceMatcher.MatcherJson.Capability>
	|
	|-RVA: 0xE25640 Offset: 0xE24040 VA: 0x180E25640
	|-ArrayHelpers.Append<object>
	|
	|-RVA: 0xE25730 Offset: 0xE24130 VA: 0x180E25730
	|-ArrayHelpers.Append<Vector2>
	|
	|-RVA: 0xE24E90 Offset: 0xE23890 VA: 0x180E24E90
	|-ArrayHelpers.Append<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE248F0 Offset: 0xE232F0 VA: 0x180E248F0
	|-ArrayHelpers.Append<InputEventTrace.DeviceInfo>
	|
	|-RVA: 0xE253E0 Offset: 0xE23DE0 VA: 0x180E253E0
	|-ArrayHelpers.Append<InputRemoting.RemoteInputDevice>
	|
	|-RVA: 0xE25520 Offset: 0xE23F20 VA: 0x180E25520
	|-ArrayHelpers.Append<InputRemoting.RemoteSender>
	*/

	// RVA: -1 Offset: -1
	public static int Append<TValue>(ref TValue[] array, IEnumerable<TValue> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE24A10 Offset: 0xE23410 VA: 0x180E24A10
	|-ArrayHelpers.Append<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AppendToImmutable<TValue>(ref TValue[] array, TValue[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE22FA0 Offset: 0xE219A0 VA: 0x180E22FA0
	|-ArrayHelpers.AppendToImmutable<InternedString>
	|
	|-RVA: 0xE22EC0 Offset: 0xE218C0 VA: 0x180E22EC0
	|-ArrayHelpers.AppendToImmutable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AppendWithCapacity<TValue>(ref TValue[] array, ref int count, TValue value, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE231E0 Offset: 0xE21BE0 VA: 0x180E231E0
	|-ArrayHelpers.AppendWithCapacity<KeyValuePair<int, int>>
	|-ArrayHelpers.AppendWithCapacity<GCHandle>
	|-ArrayHelpers.AppendWithCapacity<MemoryHelpers.BitRegion>
	|
	|-RVA: 0xE237F0 Offset: 0xE221F0 VA: 0x180E237F0
	|-ArrayHelpers.AppendWithCapacity<InputUser>
	|
	|-RVA: 0xE238E0 Offset: 0xE222E0 VA: 0x180E238E0
	|-ArrayHelpers.AppendWithCapacity<int>
	|
	|-RVA: 0xE239D0 Offset: 0xE223D0 VA: 0x180E239D0
	|-ArrayHelpers.AppendWithCapacity<InternedString>
	|-ArrayHelpers.AppendWithCapacity<Substring>
	|-ArrayHelpers.AppendWithCapacity<InputUser.OngoingAccountSelection>
	|
	|-RVA: 0xE23FD0 Offset: 0xE229D0 VA: 0x180E23FD0
	|-ArrayHelpers.AppendWithCapacity<object>
	|
	|-RVA: 0xE23DF0 Offset: 0xE227F0 VA: 0x180E23DF0
	|-ArrayHelpers.AppendWithCapacity<PointerModel>
	|
	|-RVA: 0xE240E0 Offset: 0xE22AE0 VA: 0x180E240E0
	|-ArrayHelpers.AppendWithCapacity<float>
	|
	|-RVA: 0xE24460 Offset: 0xE22E60 VA: 0x180E24460
	|-ArrayHelpers.AppendWithCapacity<ulong>
	|
	|-RVA: 0xE234D0 Offset: 0xE21ED0 VA: 0x180E234D0
	|-ArrayHelpers.AppendWithCapacity<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE23C40 Offset: 0xE22640 VA: 0x180E23C40
	|-ArrayHelpers.AppendWithCapacity<InputActionRebindingExtensions.ParameterOverride>
	|
	|-RVA: 0xE232D0 Offset: 0xE21CD0 VA: 0x180E232D0
	|-ArrayHelpers.AppendWithCapacity<InputControlLayout.ControlItem>
	|
	|-RVA: 0xE23080 Offset: 0xE21A80 VA: 0x180E23080
	|-ArrayHelpers.AppendWithCapacity<InputManager.AvailableDevice>
	|
	|-RVA: 0xE241D0 Offset: 0xE22BD0 VA: 0x180E241D0
	|-ArrayHelpers.AppendWithCapacity<InputManager.StateChangeMonitorListener>
	|
	|-RVA: 0xE24310 Offset: 0xE22D10 VA: 0x180E24310
	|-ArrayHelpers.AppendWithCapacity<InputManager.StateChangeMonitorTimeout>
	|
	|-RVA: 0xE245E0 Offset: 0xE22FE0 VA: 0x180E245E0
	|-ArrayHelpers.AppendWithCapacity<InputUser.UserData>
	|
	|-RVA: 0xE23AF0 Offset: 0xE224F0 VA: 0x180E23AF0
	|-ArrayHelpers.AppendWithCapacity<OnScreenControl.OnScreenDeviceInfo>
	*/

	// RVA: -1 Offset: -1
	public static int AppendListWithCapacity<TValue, TValues>(ref TValue[] array, ref int length, TValues values, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE22A80 Offset: 0xE21480 VA: 0x180E22A80
	|-ArrayHelpers.AppendListWithCapacity<object, InputControlList<object>>
	|
	|-RVA: 0xE22CA0 Offset: 0xE216A0 VA: 0x180E22CA0
	|-ArrayHelpers.AppendListWithCapacity<object, ReadOnlyArray<object>>
	|
	|-RVA: 0xE22590 Offset: 0xE20F90 VA: 0x180E22590
	|-ArrayHelpers.AppendListWithCapacity<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = 4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE24550 Offset: 0xE22F50 VA: 0x180E24550
	|-ArrayHelpers.AppendWithCapacity<ulong>
	|
	|-RVA: 0xE236E0 Offset: 0xE220E0 VA: 0x180E236E0
	|-ArrayHelpers.AppendWithCapacity<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void InsertAt<TValue>(ref TValue[] array, int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE49170 Offset: 0xE47B70 VA: 0x180E49170
	|-ArrayHelpers.InsertAt<InputBinding>
	|
	|-RVA: 0xE49340 Offset: 0xE47D40 VA: 0x180E49340
	|-ArrayHelpers.InsertAt<object>
	|
	|-RVA: 0xE494A0 Offset: 0xE47EA0 VA: 0x180E494A0
	|-ArrayHelpers.InsertAt<ushort>
	|
	|-RVA: 0xE48F10 Offset: 0xE47910 VA: 0x180E48F10
	|-ArrayHelpers.InsertAt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void InsertAtWithCapacity<TValue>(ref TValue[] array, ref int count, int index, TValue value, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE48E20 Offset: 0xE47820 VA: 0x180E48E20
	|-ArrayHelpers.InsertAtWithCapacity<Touch>
	|
	|-RVA: 0xE48CB0 Offset: 0xE476B0 VA: 0x180E48CB0
	|-ArrayHelpers.InsertAtWithCapacity<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void PutAtIfNotSet<TValue>(ref TValue[] array, int index, Func<TValue> valueFn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4AA40 Offset: 0xE49440 VA: 0x180E4AA40
	|-ArrayHelpers.PutAtIfNotSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GrowBy<TValue>(ref TValue[] array, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE479E0 Offset: 0xE463E0 VA: 0x180E479E0
	|-ArrayHelpers.GrowBy<object>
	|
	|-RVA: 0xE477E0 Offset: 0xE461E0 VA: 0x180E477E0
	|-ArrayHelpers.GrowBy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Allocator allocator = 4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47A90 Offset: 0xE46490 VA: 0x180E47A90
	|-ArrayHelpers.GrowBy<ulong>
	|
	|-RVA: 0xE47890 Offset: 0xE46290 VA: 0x180E47890
	|-ArrayHelpers.GrowBy<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int GrowWithCapacity<TValue>(ref TValue[] array, ref int count, int growBy, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47BB0 Offset: 0xE465B0 VA: 0x180E47BB0
	|-ArrayHelpers.GrowWithCapacity<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = 4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47C40 Offset: 0xE46640 VA: 0x180E47C40
	|-ArrayHelpers.GrowWithCapacity<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static TValue[] Join<TValue>(TValue value, TValue[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE495F0 Offset: 0xE47FF0 VA: 0x180E495F0
	|-ArrayHelpers.Join<KeyValuePair<int, int>>
	|-ArrayHelpers.Join<GCHandle>
	|
	|-RVA: 0xE49890 Offset: 0xE48290 VA: 0x180E49890
	|-ArrayHelpers.Join<int>
	|
	|-RVA: 0xE49960 Offset: 0xE48360 VA: 0x180E49960
	|-ArrayHelpers.Join<InternedString>
	|-ArrayHelpers.Join<Substring>
	|-ArrayHelpers.Join<InputUser.OngoingAccountSelection>
	|
	|-RVA: 0xE49C80 Offset: 0xE48680 VA: 0x180E49C80
	|-ArrayHelpers.Join<object>
	|
	|-RVA: 0xE49B30 Offset: 0xE48530 VA: 0x180E49B30
	|-ArrayHelpers.Join<PointerModel>
	|
	|-RVA: 0xE49E50 Offset: 0xE48850 VA: 0x180E49E50
	|-ArrayHelpers.Join<ulong>
	|
	|-RVA: 0xE496C0 Offset: 0xE480C0 VA: 0x180E496C0
	|-ArrayHelpers.Join<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE49D60 Offset: 0xE48760 VA: 0x180E49D60
	|-ArrayHelpers.Join<InputManager.StateChangeMonitorTimeout>
	|
	|-RVA: 0xE49A40 Offset: 0xE48440 VA: 0x180E49A40
	|-ArrayHelpers.Join<OnScreenControl.OnScreenDeviceInfo>
	*/

	// RVA: -1 Offset: -1
	public static TValue[] Merge<TValue>(TValue[] first, TValue[] second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4A4C0 Offset: 0xE48EC0 VA: 0x180E4A4C0
	|-ArrayHelpers.Merge<InternedString>
	|
	|-RVA: 0xE4A240 Offset: 0xE48C40 VA: 0x180E4A240
	|-ArrayHelpers.Merge<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TValue[] Merge<TValue>(TValue[] first, TValue[] second, IEqualityComparer<TValue> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE49F30 Offset: 0xE48930 VA: 0x180E49F30
	|-ArrayHelpers.Merge<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EraseAt<TValue>(ref TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE26F60 Offset: 0xE25960 VA: 0x180E26F60
	|-ArrayHelpers.EraseAt<InputBinding>
	|-ArrayHelpers.EraseAt<InputControlScheme>
	|-ArrayHelpers.EraseAt<int>
	|-ArrayHelpers.EraseAt<object>
	|-ArrayHelpers.EraseAt<Vector2>
	|-ArrayHelpers.EraseAt<InputRemoting.RemoteSender>
	|
	|-RVA: 0xE26EB0 Offset: 0xE258B0 VA: 0x180E26EB0
	|-ArrayHelpers.EraseAt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void EraseAtWithCapacity<TValue>(TValue[] array, ref int count, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE26E40 Offset: 0xE25840 VA: 0x180E26E40
	|-ArrayHelpers.EraseAtWithCapacity<KeyValuePair<int, int>>
	|-ArrayHelpers.EraseAtWithCapacity<GCHandle>
	|-ArrayHelpers.EraseAtWithCapacity<ulong>
	|-ArrayHelpers.EraseAtWithCapacity<MemoryHelpers.BitRegion>
	|
	|-RVA: 0xE46E80 Offset: 0xE45880 VA: 0x180E46E80
	|-ArrayHelpers.EraseAtWithCapacity<InputUser>
	|-ArrayHelpers.EraseAtWithCapacity<int>
	|-ArrayHelpers.EraseAtWithCapacity<float>
	|
	|-RVA: 0xE46EF0 Offset: 0xE458F0 VA: 0x180E46EF0
	|-ArrayHelpers.EraseAtWithCapacity<InternedString>
	|-ArrayHelpers.EraseAtWithCapacity<Substring>
	|-ArrayHelpers.EraseAtWithCapacity<InputUser.OngoingAccountSelection>
	|
	|-RVA: 0xE47130 Offset: 0xE45B30 VA: 0x180E47130
	|-ArrayHelpers.EraseAtWithCapacity<object>
	|
	|-RVA: 0xE47020 Offset: 0xE45A20 VA: 0x180E47020
	|-ArrayHelpers.EraseAtWithCapacity<PointerModel>
	|
	|-RVA: 0xE46C30 Offset: 0xE45630 VA: 0x180E46C30
	|-ArrayHelpers.EraseAtWithCapacity<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE46B90 Offset: 0xE45590 VA: 0x180E46B90
	|-ArrayHelpers.EraseAtWithCapacity<InputManager.AvailableDevice>
	|
	|-RVA: 0xE471B0 Offset: 0xE45BB0 VA: 0x180E471B0
	|-ArrayHelpers.EraseAtWithCapacity<InputManager.StateChangeMonitorListener>
	|
	|-RVA: 0xE47240 Offset: 0xE45C40 VA: 0x180E47240
	|-ArrayHelpers.EraseAtWithCapacity<InputManager.StateChangeMonitorTimeout>
	|
	|-RVA: 0xE472E0 Offset: 0xE45CE0 VA: 0x180E472E0
	|-ArrayHelpers.EraseAtWithCapacity<InputManager.StateChangeMonitorsForDevice>
	|
	|-RVA: 0xE47430 Offset: 0xE45E30 VA: 0x180E47430
	|-ArrayHelpers.EraseAtWithCapacity<InputUser.UserData>
	|
	|-RVA: 0xE46F80 Offset: 0xE45980 VA: 0x180E46F80
	|-ArrayHelpers.EraseAtWithCapacity<OnScreenControl.OnScreenDeviceInfo>
	*/

	// RVA: -1 Offset: -1
	public static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47390 Offset: 0xE45D90 VA: 0x180E47390
	|-ArrayHelpers.EraseAtWithCapacity<ulong>
	|
	|-RVA: 0xE46DC0 Offset: 0xE457C0 VA: 0x180E46DC0
	|-ArrayHelpers.EraseAtWithCapacity<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool Erase<TValue>(ref TValue[] array, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE27140 Offset: 0xE25B40 VA: 0x180E27140
	|-ArrayHelpers.Erase<int>
	|
	|-RVA: 0xE27240 Offset: 0xE25C40 VA: 0x180E27240
	|-ArrayHelpers.Erase<object>
	|
	|-RVA: 0xE27010 Offset: 0xE25A10 VA: 0x180E27010
	|-ArrayHelpers.Erase<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EraseAtByMovingTail<TValue>(TValue[] array, ref int count, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE26620 Offset: 0xE25020 VA: 0x180E26620
	|-ArrayHelpers.EraseAtByMovingTail<KeyValuePair<int, int>>
	|-ArrayHelpers.EraseAtByMovingTail<GCHandle>
	|
	|-RVA: 0xE268B0 Offset: 0xE252B0 VA: 0x180E268B0
	|-ArrayHelpers.EraseAtByMovingTail<int>
	|
	|-RVA: 0xE26910 Offset: 0xE25310 VA: 0x180E26910
	|-ArrayHelpers.EraseAtByMovingTail<InternedString>
	|-ArrayHelpers.EraseAtByMovingTail<Substring>
	|-ArrayHelpers.EraseAtByMovingTail<InputUser.OngoingAccountSelection>
	|
	|-RVA: 0xE26C50 Offset: 0xE25650 VA: 0x180E26C50
	|-ArrayHelpers.EraseAtByMovingTail<object>
	|
	|-RVA: 0xE26AB0 Offset: 0xE254B0 VA: 0x180E26AB0
	|-ArrayHelpers.EraseAtByMovingTail<PointerModel>
	|
	|-RVA: 0xE26DE0 Offset: 0xE257E0 VA: 0x180E26DE0
	|-ArrayHelpers.EraseAtByMovingTail<ulong>
	|
	|-RVA: 0xE26690 Offset: 0xE25090 VA: 0x180E26690
	|-ArrayHelpers.EraseAtByMovingTail<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE26CF0 Offset: 0xE256F0 VA: 0x180E26CF0
	|-ArrayHelpers.EraseAtByMovingTail<InputManager.StateChangeMonitorTimeout>
	|
	|-RVA: 0xE269C0 Offset: 0xE253C0 VA: 0x180E269C0
	|-ArrayHelpers.EraseAtByMovingTail<OnScreenControl.OnScreenDeviceInfo>
	*/

	// RVA: -1 Offset: -1
	public static TValue[] Copy<TValue>(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE261F0 Offset: 0xE24BF0 VA: 0x180E261F0
	|-ArrayHelpers.Copy<KeyValuePair<int, int>>
	|-ArrayHelpers.Copy<GCHandle>
	|-ArrayHelpers.Copy<int>
	|-ArrayHelpers.Copy<InternedString>
	|-ArrayHelpers.Copy<object>
	|-ArrayHelpers.Copy<PointerModel>
	|-ArrayHelpers.Copy<Substring>
	|-ArrayHelpers.Copy<ulong>
	|-ArrayHelpers.Copy<__Il2CppFullySharedGenericType>
	|-ArrayHelpers.Copy<InputManager.StateChangeMonitorTimeout>
	|-ArrayHelpers.Copy<InputUser.OngoingAccountSelection>
	|-ArrayHelpers.Copy<OnScreenControl.OnScreenDeviceInfo>
	*/

	// RVA: -1 Offset: -1
	public static TValue[] Clone<TValue>(TValue[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE258A0 Offset: 0xE242A0 VA: 0x180E258A0
	|-ArrayHelpers.Clone<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TNew[] Select<TOld, TNew>(TOld[] array, Func<TOld, TNew> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B140 Offset: 0xE49B40 VA: 0x180E4B140
	|-ArrayHelpers.Select<InternedString, object>
	|
	|-RVA: 0xE4B260 Offset: 0xE49C60 VA: 0x180E4B260
	|-ArrayHelpers.Select<object, InternedString>
	|
	|-RVA: 0xE4AF40 Offset: 0xE49940 VA: 0x180E4AF40
	|-ArrayHelpers.Select<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void Swap<TValue>(ref TValue first, ref TValue second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B9E0 Offset: 0xE4A3E0 VA: 0x180E4B9E0
	|-ArrayHelpers.Swap<object>
	|
	|-RVA: 0xE4B840 Offset: 0xE4A240 VA: 0x180E4B840
	|-ArrayHelpers.Swap<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void MoveSlice<TValue>(TValue[] array, int sourceIndex, int destinationIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4A860 Offset: 0xE49260 VA: 0x180E4A860
	|-ArrayHelpers.MoveSlice<object>
	|
	|-RVA: 0xE4A690 Offset: 0xE49090 VA: 0x180E4A690
	|-ArrayHelpers.MoveSlice<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EraseSliceWithCapacity<TValue>(ref TValue[] array, ref int length, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE47730 Offset: 0xE46130 VA: 0x180E47730
	|-ArrayHelpers.EraseSliceWithCapacity<object>
	|
	|-RVA: 0xE47560 Offset: 0xE45F60 VA: 0x180E47560
	|-ArrayHelpers.EraseSliceWithCapacity<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void SwapElements<TValue>(TValue[] array, int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B680 Offset: 0xE4A080 VA: 0x180E4B680
	|-ArrayHelpers.SwapElements<object>
	|
	|-RVA: 0xE4B700 Offset: 0xE4A100 VA: 0x180E4B700
	|-ArrayHelpers.SwapElements<float>
	|
	|-RVA: 0xE4B400 Offset: 0xE49E00 VA: 0x180E4B400
	|-ArrayHelpers.SwapElements<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE4B780 Offset: 0xE4A180 VA: 0x180E4B780
	|-ArrayHelpers.SwapElements<InputManager.StateChangeMonitorListener>
	|
	|-RVA: 0xE4B380 Offset: 0xE49D80 VA: 0x180E4B380
	|-ArrayHelpers.SwapElements<MemoryHelpers.BitRegion>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void SwapElements<TValue>(NativeArray<TValue> array, int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B810 Offset: 0xE4A210 VA: 0x180E4B810
	|-ArrayHelpers.SwapElements<ulong>
	|
	|-RVA: 0xE4B4A0 Offset: 0xE49EA0 VA: 0x180E4B4A0
	|-ArrayHelpers.SwapElements<__Il2CppFullySharedGenericStructType>
	*/
}
