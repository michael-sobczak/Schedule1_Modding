internal struct InlinedArray<TValue> : IEnumerable<TValue>, IEnumerable // TypeDefIndex: 7811
{
	// Fields
	public int length; // 0x0
	public TValue firstValue; // 0x0
	public TValue[] additionalValues; // 0x0

	// Properties
	public int Capacity { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857910 Offset: 0x1856310 VA: 0x181857910
	|-InlinedArray<KeyValuePair<int, int>>.get_Capacity
	|-InlinedArray<GCHandle>.get_Capacity
	|-InlinedArray<object>.get_Capacity
	|-InlinedArray<ulong>.get_Capacity
	|
	|-RVA: 0x186C1B0 Offset: 0x186ABB0 VA: 0x18186C1B0
	|-InlinedArray<int>.get_Capacity
	|
	|-RVA: 0x186C170 Offset: 0x186AB70 VA: 0x18186C170
	|-InlinedArray<InternedString>.get_Capacity
	|-InlinedArray<Substring>.get_Capacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.get_Capacity
	|
	|-RVA: 0x186C230 Offset: 0x186AC30 VA: 0x18186C230
	|-InlinedArray<PointerModel>.get_Capacity
	|
	|-RVA: 0x186C1D0 Offset: 0x186ABD0 VA: 0x18186C1D0
	|-InlinedArray<__Il2CppFullySharedGenericType>.get_Capacity
	|
	|-RVA: 0x186C190 Offset: 0x186AB90 VA: 0x18186C190
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.get_Capacity
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18575F0 Offset: 0x1855FF0 VA: 0x1818575F0
	|-InlinedArray<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x186B860 Offset: 0x186A260 VA: 0x18186B860
	|-InlinedArray<GCHandle>..ctor
	|-InlinedArray<ulong>..ctor
	|
	|-RVA: 0x186A730 Offset: 0x1869130 VA: 0x18186A730
	|-InlinedArray<int>..ctor
	|
	|-RVA: 0x1869B30 Offset: 0x1868530 VA: 0x181869B30
	|-InlinedArray<InternedString>..ctor
	|-InlinedArray<Substring>..ctor
	|-InlinedArray<InputUser.OngoingAccountSelection>..ctor
	|
	|-RVA: 0x18694B0 Offset: 0x1867EB0 VA: 0x1818694B0
	|-InlinedArray<object>..ctor
	|
	|-RVA: 0x186C070 Offset: 0x186AA70 VA: 0x18186C070
	|-InlinedArray<PointerModel>..ctor
	|
	|-RVA: 0x186B8B0 Offset: 0x186A2B0 VA: 0x18186B8B0
	|-InlinedArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x18699C0 Offset: 0x18683C0 VA: 0x1818699C0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>..ctor
	|
	|-RVA: 0x186C120 Offset: 0x186AB20 VA: 0x18186C120
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TValue firstValue, TValue[] additionalValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857610 Offset: 0x1856010 VA: 0x181857610
	|-InlinedArray<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x18696B0 Offset: 0x18680B0 VA: 0x1818696B0
	|-InlinedArray<GCHandle>..ctor
	|-InlinedArray<ulong>..ctor
	|
	|-RVA: 0x186B880 Offset: 0x186A280 VA: 0x18186B880
	|-InlinedArray<int>..ctor
	|
	|-RVA: 0x1869460 Offset: 0x1867E60 VA: 0x181869460
	|-InlinedArray<InternedString>..ctor
	|-InlinedArray<Substring>..ctor
	|-InlinedArray<InputUser.OngoingAccountSelection>..ctor
	|
	|-RVA: 0x1869A10 Offset: 0x1868410 VA: 0x181869A10
	|-InlinedArray<object>..ctor
	|
	|-RVA: 0x1869A60 Offset: 0x1868460 VA: 0x181869A60
	|-InlinedArray<PointerModel>..ctor
	|
	|-RVA: 0x18694F0 Offset: 0x1867EF0 VA: 0x1818694F0
	|-InlinedArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x186B1F0 Offset: 0x1869BF0 VA: 0x18186B1F0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>..ctor
	|
	|-RVA: 0x18693F0 Offset: 0x1867DF0 VA: 0x1818693F0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TValue> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857640 Offset: 0x1856040 VA: 0x181857640
	|-InlinedArray<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x186BDA0 Offset: 0x186A7A0 VA: 0x18186BDA0
	|-InlinedArray<GCHandle>..ctor
	|
	|-RVA: 0x1869B70 Offset: 0x1868570 VA: 0x181869B70
	|-InlinedArray<int>..ctor
	|
	|-RVA: 0x186A430 Offset: 0x1868E30 VA: 0x18186A430
	|-InlinedArray<InternedString>..ctor
	|
	|-RVA: 0x186AEF0 Offset: 0x18698F0 VA: 0x18186AEF0
	|-InlinedArray<object>..ctor
	|
	|-RVA: 0x186AAA0 Offset: 0x18694A0 VA: 0x18186AAA0
	|-InlinedArray<PointerModel>..ctor
	|
	|-RVA: 0x186B560 Offset: 0x1869F60 VA: 0x18186B560
	|-InlinedArray<Substring>..ctor
	|
	|-RVA: 0x18696E0 Offset: 0x18680E0 VA: 0x1818696E0
	|-InlinedArray<ulong>..ctor
	|
	|-RVA: 0x1869E40 Offset: 0x1868840 VA: 0x181869E40
	|-InlinedArray<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x186BA50 Offset: 0x186A450 VA: 0x18186BA50
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>..ctor
	|
	|-RVA: 0x186B260 Offset: 0x1869C60 VA: 0x18186B260
	|-InlinedArray<InputUser.OngoingAccountSelection>..ctor
	|
	|-RVA: 0x186A750 Offset: 0x1869150 VA: 0x18186A750
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857930 Offset: 0x1856330 VA: 0x181857930
	|-InlinedArray<KeyValuePair<int, int>>.get_Item
	|
	|-RVA: 0x186C300 Offset: 0x186AD00 VA: 0x18186C300
	|-InlinedArray<GCHandle>.get_Item
	|-InlinedArray<object>.get_Item
	|-InlinedArray<ulong>.get_Item
	|
	|-RVA: 0x186C680 Offset: 0x186B080 VA: 0x18186C680
	|-InlinedArray<int>.get_Item
	|
	|-RVA: 0x186C250 Offset: 0x186AC50 VA: 0x18186C250
	|-InlinedArray<InternedString>.get_Item
	|-InlinedArray<Substring>.get_Item
	|-InlinedArray<InputUser.OngoingAccountSelection>.get_Item
	|
	|-RVA: 0x186C560 Offset: 0x186AF60 VA: 0x18186C560
	|-InlinedArray<PointerModel>.get_Item
	|
	|-RVA: 0x186C390 Offset: 0x186AD90 VA: 0x18186C390
	|-InlinedArray<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x186C710 Offset: 0x186B110 VA: 0x18186C710
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.get_Item
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18579C0 Offset: 0x18563C0 VA: 0x1818579C0
	|-InlinedArray<KeyValuePair<int, int>>.set_Item
	|
	|-RVA: 0x186C8C0 Offset: 0x186B2C0 VA: 0x18186C8C0
	|-InlinedArray<GCHandle>.set_Item
	|-InlinedArray<ulong>.set_Item
	|
	|-RVA: 0x186C950 Offset: 0x186B350 VA: 0x18186C950
	|-InlinedArray<int>.set_Item
	|
	|-RVA: 0x186C7F0 Offset: 0x186B1F0 VA: 0x18186C7F0
	|-InlinedArray<InternedString>.set_Item
	|-InlinedArray<Substring>.set_Item
	|-InlinedArray<InputUser.OngoingAccountSelection>.set_Item
	|
	|-RVA: 0x186CAE0 Offset: 0x186B4E0 VA: 0x18186CAE0
	|-InlinedArray<object>.set_Item
	|
	|-RVA: 0x186CE30 Offset: 0x186B830 VA: 0x18186CE30
	|-InlinedArray<PointerModel>.set_Item
	|
	|-RVA: 0x186CBA0 Offset: 0x186B5A0 VA: 0x18186CBA0
	|-InlinedArray<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x186CFE0 Offset: 0x186B9E0 VA: 0x18186CFE0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.set_Item
	|
	|-RVA: 0x186C9E0 Offset: 0x186B3E0 VA: 0x18186C9E0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856670 Offset: 0x1855070 VA: 0x181856670
	|-InlinedArray<KeyValuePair<int, int>>.Clear
	|
	|-RVA: 0x185D0F0 Offset: 0x185BAF0 VA: 0x18185D0F0
	|-InlinedArray<GCHandle>.Clear
	|-InlinedArray<object>.Clear
	|-InlinedArray<ulong>.Clear
	|
	|-RVA: 0x185D170 Offset: 0x185BB70 VA: 0x18185D170
	|-InlinedArray<int>.Clear
	|
	|-RVA: 0x185D110 Offset: 0x185BB10 VA: 0x18185D110
	|-InlinedArray<InternedString>.Clear
	|-InlinedArray<Substring>.Clear
	|-InlinedArray<InputUser.OngoingAccountSelection>.Clear
	|
	|-RVA: 0x185D130 Offset: 0x185BB30 VA: 0x18185D130
	|-InlinedArray<PointerModel>.Clear
	|
	|-RVA: 0x185CFB0 Offset: 0x185B9B0 VA: 0x18185CFB0
	|-InlinedArray<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x185CF80 Offset: 0x185B980 VA: 0x18185CF80
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Clear
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Clear
	*/

	// RVA: -1 Offset: -1
	public void ClearWithCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856610 Offset: 0x1855010 VA: 0x181856610
	|-InlinedArray<KeyValuePair<int, int>>.ClearWithCapacity
	|
	|-RVA: 0x185CA50 Offset: 0x185B450 VA: 0x18185CA50
	|-InlinedArray<GCHandle>.ClearWithCapacity
	|-InlinedArray<ulong>.ClearWithCapacity
	|
	|-RVA: 0x185CCA0 Offset: 0x185B6A0 VA: 0x18185CCA0
	|-InlinedArray<int>.ClearWithCapacity
	|
	|-RVA: 0x185C9C0 Offset: 0x185B3C0 VA: 0x18185C9C0
	|-InlinedArray<InternedString>.ClearWithCapacity
	|-InlinedArray<Substring>.ClearWithCapacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.ClearWithCapacity
	|
	|-RVA: 0x185C930 Offset: 0x185B330 VA: 0x18185C930
	|-InlinedArray<object>.ClearWithCapacity
	|
	|-RVA: 0x185CB60 Offset: 0x185B560 VA: 0x18185CB60
	|-InlinedArray<PointerModel>.ClearWithCapacity
	|
	|-RVA: 0x185CD00 Offset: 0x185B700 VA: 0x18185CD00
	|-InlinedArray<__Il2CppFullySharedGenericType>.ClearWithCapacity
	|
	|-RVA: 0x185C880 Offset: 0x185B280 VA: 0x18185C880
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.ClearWithCapacity
	|
	|-RVA: 0x185CAB0 Offset: 0x185B4B0 VA: 0x18185CAB0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.ClearWithCapacity
	*/

	// RVA: -1 Offset: -1
	public InlinedArray<TValue> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856690 Offset: 0x1855090 VA: 0x181856690
	|-InlinedArray<KeyValuePair<int, int>>.Clone
	|
	|-RVA: 0x185D2D0 Offset: 0x185BCD0 VA: 0x18185D2D0
	|-InlinedArray<GCHandle>.Clone
	|-InlinedArray<ulong>.Clone
	|
	|-RVA: 0x185D7F0 Offset: 0x185C1F0 VA: 0x18185D7F0
	|-InlinedArray<int>.Clone
	|
	|-RVA: 0x185D190 Offset: 0x185BB90 VA: 0x18185D190
	|-InlinedArray<InternedString>.Clone
	|-InlinedArray<Substring>.Clone
	|-InlinedArray<InputUser.OngoingAccountSelection>.Clone
	|
	|-RVA: 0x185D230 Offset: 0x185BC30 VA: 0x18185D230
	|-InlinedArray<object>.Clone
	|
	|-RVA: 0x185D870 Offset: 0x185C270 VA: 0x18185D870
	|-InlinedArray<PointerModel>.Clone
	|
	|-RVA: 0x185D4B0 Offset: 0x185BEB0 VA: 0x18185D4B0
	|-InlinedArray<__Il2CppFullySharedGenericType>.Clone
	|
	|-RVA: 0x185D350 Offset: 0x185BD50 VA: 0x18185D350
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Clone
	|
	|-RVA: 0x185D400 Offset: 0x185BE00 VA: 0x18185D400
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Clone
	*/

	// RVA: -1 Offset: -1
	public void SetLength(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857410 Offset: 0x1855E10 VA: 0x181857410
	|-InlinedArray<KeyValuePair<int, int>>.SetLength
	|
	|-RVA: 0x1867E10 Offset: 0x1866810 VA: 0x181867E10
	|-InlinedArray<GCHandle>.SetLength
	|-InlinedArray<ulong>.SetLength
	|
	|-RVA: 0x1868980 Offset: 0x1867380 VA: 0x181868980
	|-InlinedArray<int>.SetLength
	|
	|-RVA: 0x18680C0 Offset: 0x1866AC0 VA: 0x1818680C0
	|-InlinedArray<InternedString>.SetLength
	|-InlinedArray<Substring>.SetLength
	|-InlinedArray<InputUser.OngoingAccountSelection>.SetLength
	|
	|-RVA: 0x1867F60 Offset: 0x1866960 VA: 0x181867F60
	|-InlinedArray<object>.SetLength
	|
	|-RVA: 0x1868230 Offset: 0x1866C30 VA: 0x181868230
	|-InlinedArray<PointerModel>.SetLength
	|
	|-RVA: 0x1868620 Offset: 0x1867020 VA: 0x181868620
	|-InlinedArray<__Il2CppFullySharedGenericType>.SetLength
	|
	|-RVA: 0x1868AD0 Offset: 0x18674D0 VA: 0x181868AD0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.SetLength
	|
	|-RVA: 0x1868490 Offset: 0x1866E90 VA: 0x181868490
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.SetLength
	*/

	// RVA: -1 Offset: -1
	public TValue[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18575A0 Offset: 0x1855FA0 VA: 0x1818575A0
	|-InlinedArray<KeyValuePair<int, int>>.ToArray
	|
	|-RVA: 0x1868E60 Offset: 0x1867860 VA: 0x181868E60
	|-InlinedArray<GCHandle>.ToArray
	|
	|-RVA: 0x1868F80 Offset: 0x1867980 VA: 0x181868F80
	|-InlinedArray<int>.ToArray
	|
	|-RVA: 0x1868FD0 Offset: 0x18679D0 VA: 0x181868FD0
	|-InlinedArray<InternedString>.ToArray
	|-InlinedArray<Substring>.ToArray
	|-InlinedArray<InputUser.OngoingAccountSelection>.ToArray
	|
	|-RVA: 0x18693A0 Offset: 0x1867DA0 VA: 0x1818693A0
	|-InlinedArray<object>.ToArray
	|
	|-RVA: 0x1869030 Offset: 0x1867A30 VA: 0x181869030
	|-InlinedArray<PointerModel>.ToArray
	|
	|-RVA: 0x1868F30 Offset: 0x1867930 VA: 0x181868F30
	|-InlinedArray<ulong>.ToArray
	|
	|-RVA: 0x1869210 Offset: 0x1867C10 VA: 0x181869210
	|-InlinedArray<__Il2CppFullySharedGenericType>.ToArray
	|
	|-RVA: 0x1869190 Offset: 0x1867B90 VA: 0x181869190
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.ToArray
	|
	|-RVA: 0x1868EB0 Offset: 0x18678B0 VA: 0x181868EB0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.ToArray
	*/

	// RVA: -1 Offset: -1
	public TOther[] ToArray<TOther>(Func<TValue, TOther> mapFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC62F0 Offset: 0xDC4CF0 VA: 0x180DC62F0
	|-InlinedArray<InternedString>.ToArray<object>
	|-InlinedArray<Substring>.ToArray<object>
	|
	|-RVA: 0xDC6000 Offset: 0xDC4A00 VA: 0x180DC6000
	|-InlinedArray<__Il2CppFullySharedGenericType>.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18568F0 Offset: 0x18552F0 VA: 0x1818568F0
	|-InlinedArray<KeyValuePair<int, int>>.IndexOf
	|
	|-RVA: 0x185F000 Offset: 0x185DA00 VA: 0x18185F000
	|-InlinedArray<GCHandle>.IndexOf
	|
	|-RVA: 0x185FE00 Offset: 0x185E800 VA: 0x18185FE00
	|-InlinedArray<int>.IndexOf
	|
	|-RVA: 0x185FF00 Offset: 0x185E900 VA: 0x18185FF00
	|-InlinedArray<InternedString>.IndexOf
	|
	|-RVA: 0x185FD00 Offset: 0x185E700 VA: 0x18185FD00
	|-InlinedArray<object>.IndexOf
	|
	|-RVA: 0x185F100 Offset: 0x185DB00 VA: 0x18185F100
	|-InlinedArray<PointerModel>.IndexOf
	|
	|-RVA: 0x185FA00 Offset: 0x185E400 VA: 0x18185FA00
	|-InlinedArray<Substring>.IndexOf
	|
	|-RVA: 0x185EDC0 Offset: 0x185D7C0 VA: 0x18185EDC0
	|-InlinedArray<ulong>.IndexOf
	|
	|-RVA: 0x185F430 Offset: 0x185DE30 VA: 0x18185F430
	|-InlinedArray<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x185FB40 Offset: 0x185E540 VA: 0x18185FB40
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.IndexOf
	|
	|-RVA: 0x185EEC0 Offset: 0x185D8C0 VA: 0x18185EEC0
	|-InlinedArray<InputUser.OngoingAccountSelection>.IndexOf
	|
	|-RVA: 0x185F840 Offset: 0x185E240 VA: 0x18185F840
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Append(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18563D0 Offset: 0x1854DD0 VA: 0x1818563D0
	|-InlinedArray<KeyValuePair<int, int>>.Append
	|
	|-RVA: 0x185B640 Offset: 0x185A040 VA: 0x18185B640
	|-InlinedArray<GCHandle>.Append
	|
	|-RVA: 0x1859210 Offset: 0x1857C10 VA: 0x181859210
	|-InlinedArray<int>.Append
	|
	|-RVA: 0x1858710 Offset: 0x1857110 VA: 0x181858710
	|-InlinedArray<InternedString>.Append
	|-InlinedArray<Substring>.Append
	|-InlinedArray<InputUser.OngoingAccountSelection>.Append
	|
	|-RVA: 0x1858D80 Offset: 0x1857780 VA: 0x181858D80
	|-InlinedArray<object>.Append
	|
	|-RVA: 0x1858840 Offset: 0x1857240 VA: 0x181858840
	|-InlinedArray<PointerModel>.Append
	|
	|-RVA: 0x185A900 Offset: 0x1859300 VA: 0x18185A900
	|-InlinedArray<ulong>.Append
	|
	|-RVA: 0x185B0B0 Offset: 0x1859AB0 VA: 0x18185B0B0
	|-InlinedArray<__Il2CppFullySharedGenericType>.Append
	|
	|-RVA: 0x1859640 Offset: 0x1858040 VA: 0x181859640
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Append
	|
	|-RVA: 0x1859D40 Offset: 0x1858740 VA: 0x181859D40
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Append
	*/

	// RVA: -1 Offset: -1
	public int AppendWithCapacity(TValue value, int capacityIncrement = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856030 Offset: 0x1854A30 VA: 0x181856030
	|-InlinedArray<KeyValuePair<int, int>>.AppendWithCapacity
	|
	|-RVA: 0x1857AF0 Offset: 0x18564F0 VA: 0x181857AF0
	|-InlinedArray<GCHandle>.AppendWithCapacity
	|
	|-RVA: 0x1857F30 Offset: 0x1856930 VA: 0x181857F30
	|-InlinedArray<int>.AppendWithCapacity
	|
	|-RVA: 0x1857A50 Offset: 0x1856450 VA: 0x181857A50
	|-InlinedArray<InternedString>.AppendWithCapacity
	|-InlinedArray<Substring>.AppendWithCapacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.AppendWithCapacity
	|
	|-RVA: 0x1858130 Offset: 0x1856B30 VA: 0x181858130
	|-InlinedArray<object>.AppendWithCapacity
	|
	|-RVA: 0x18581C0 Offset: 0x1856BC0 VA: 0x1818581C0
	|-InlinedArray<PointerModel>.AppendWithCapacity
	|
	|-RVA: 0x1857EB0 Offset: 0x18568B0 VA: 0x181857EB0
	|-InlinedArray<ulong>.AppendWithCapacity
	|
	|-RVA: 0x1857B70 Offset: 0x1856570 VA: 0x181857B70
	|-InlinedArray<__Il2CppFullySharedGenericType>.AppendWithCapacity
	|
	|-RVA: 0x1857FB0 Offset: 0x18569B0 VA: 0x181857FB0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.AppendWithCapacity
	|
	|-RVA: 0x1858070 Offset: 0x1856A70 VA: 0x181858070
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.AppendWithCapacity
	*/

	// RVA: -1 Offset: -1
	public void AssignWithCapacity(InlinedArray<TValue> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18564F0 Offset: 0x1854EF0 VA: 0x1818564F0
	|-InlinedArray<KeyValuePair<int, int>>.AssignWithCapacity
	|
	|-RVA: 0x185C5D0 Offset: 0x185AFD0 VA: 0x18185C5D0
	|-InlinedArray<GCHandle>.AssignWithCapacity
	|
	|-RVA: 0x185C2D0 Offset: 0x185ACD0 VA: 0x18185C2D0
	|-InlinedArray<int>.AssignWithCapacity
	|
	|-RVA: 0x185C4C0 Offset: 0x185AEC0 VA: 0x18185C4C0
	|-InlinedArray<InternedString>.AssignWithCapacity
	|-InlinedArray<Substring>.AssignWithCapacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.AssignWithCapacity
	|
	|-RVA: 0x185BB60 Offset: 0x185A560 VA: 0x18185BB60
	|-InlinedArray<object>.AssignWithCapacity
	|
	|-RVA: 0x185B760 Offset: 0x185A160 VA: 0x18185B760
	|-InlinedArray<PointerModel>.AssignWithCapacity
	|
	|-RVA: 0x185C3B0 Offset: 0x185ADB0 VA: 0x18185C3B0
	|-InlinedArray<ulong>.AssignWithCapacity
	|
	|-RVA: 0x185BC80 Offset: 0x185A680 VA: 0x18185BC80
	|-InlinedArray<__Il2CppFullySharedGenericType>.AssignWithCapacity
	|
	|-RVA: 0x185C140 Offset: 0x185AB40 VA: 0x18185C140
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.AssignWithCapacity
	|
	|-RVA: 0x185C6F0 Offset: 0x185B0F0 VA: 0x18185C6F0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.AssignWithCapacity
	*/

	// RVA: -1 Offset: -1
	public void Append(IEnumerable<TValue> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18560B0 Offset: 0x1854AB0 VA: 0x1818560B0
	|-InlinedArray<KeyValuePair<int, int>>.Append
	|
	|-RVA: 0x185AD90 Offset: 0x1859790 VA: 0x18185AD90
	|-InlinedArray<GCHandle>.Append
	|
	|-RVA: 0x185A270 Offset: 0x1858C70 VA: 0x18185A270
	|-InlinedArray<int>.Append
	|
	|-RVA: 0x185AA20 Offset: 0x1859420 VA: 0x18185AA20
	|-InlinedArray<InternedString>.Append
	|
	|-RVA: 0x18597B0 Offset: 0x18581B0 VA: 0x1818597B0
	|-InlinedArray<object>.Append
	|
	|-RVA: 0x1858AC0 Offset: 0x18574C0 VA: 0x181858AC0
	|-InlinedArray<PointerModel>.Append
	|
	|-RVA: 0x1858EA0 Offset: 0x18578A0 VA: 0x181858EA0
	|-InlinedArray<Substring>.Append
	|
	|-RVA: 0x1859320 Offset: 0x1857D20 VA: 0x181859320
	|-InlinedArray<ulong>.Append
	|
	|-RVA: 0x18599C0 Offset: 0x18583C0 VA: 0x1818599C0
	|-InlinedArray<__Il2CppFullySharedGenericType>.Append
	|
	|-RVA: 0x1859EB0 Offset: 0x18588B0 VA: 0x181859EB0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Append
	|
	|-RVA: 0x185A590 Offset: 0x1858F90 VA: 0x18185A590
	|-InlinedArray<InputUser.OngoingAccountSelection>.Append
	|
	|-RVA: 0x1858340 Offset: 0x1856D40 VA: 0x181858340
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Append
	*/

	// RVA: -1 Offset: -1
	public void Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857270 Offset: 0x1855C70 VA: 0x181857270
	|-InlinedArray<KeyValuePair<int, int>>.Remove
	|
	|-RVA: 0x1867C70 Offset: 0x1866670 VA: 0x181867C70
	|-InlinedArray<GCHandle>.Remove
	|
	|-RVA: 0x1867520 Offset: 0x1865F20 VA: 0x181867520
	|-InlinedArray<int>.Remove
	|
	|-RVA: 0x1867860 Offset: 0x1866260 VA: 0x181867860
	|-InlinedArray<InternedString>.Remove
	|
	|-RVA: 0x18676C0 Offset: 0x18660C0 VA: 0x1818676C0
	|-InlinedArray<object>.Remove
	|
	|-RVA: 0x1866FD0 Offset: 0x18659D0 VA: 0x181866FD0
	|-InlinedArray<PointerModel>.Remove
	|
	|-RVA: 0x1866500 Offset: 0x1864F00 VA: 0x181866500
	|-InlinedArray<Substring>.Remove
	|
	|-RVA: 0x1867380 Offset: 0x1865D80 VA: 0x181867380
	|-InlinedArray<ulong>.Remove
	|
	|-RVA: 0x18668A0 Offset: 0x18652A0 VA: 0x1818668A0
	|-InlinedArray<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x1867A30 Offset: 0x1866430 VA: 0x181867A30
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Remove
	|
	|-RVA: 0x18666D0 Offset: 0x18650D0 VA: 0x1818666D0
	|-InlinedArray<InputUser.OngoingAccountSelection>.Remove
	|
	|-RVA: 0x1866D90 Offset: 0x1865790 VA: 0x181866D90
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtWithCapacity(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856E10 Offset: 0x1855810 VA: 0x181856E10
	|-InlinedArray<KeyValuePair<int, int>>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863920 Offset: 0x1862320 VA: 0x181863920
	|-InlinedArray<GCHandle>.RemoveAtWithCapacity
	|-InlinedArray<ulong>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863FA0 Offset: 0x18629A0 VA: 0x181863FA0
	|-InlinedArray<int>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863DF0 Offset: 0x18627F0 VA: 0x181863DF0
	|-InlinedArray<InternedString>.RemoveAtWithCapacity
	|-InlinedArray<Substring>.RemoveAtWithCapacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.RemoveAtWithCapacity
	|
	|-RVA: 0x1864120 Offset: 0x1862B20 VA: 0x181864120
	|-InlinedArray<object>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863AA0 Offset: 0x18624A0 VA: 0x181863AA0
	|-InlinedArray<PointerModel>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863130 Offset: 0x1861B30 VA: 0x181863130
	|-InlinedArray<__Il2CppFullySharedGenericType>.RemoveAtWithCapacity
	|
	|-RVA: 0x18642C0 Offset: 0x1862CC0 VA: 0x1818642C0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.RemoveAtWithCapacity
	|
	|-RVA: 0x1863720 Offset: 0x1862120 VA: 0x181863720
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.RemoveAtWithCapacity
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856F90 Offset: 0x1855990 VA: 0x181856F90
	|-InlinedArray<KeyValuePair<int, int>>.RemoveAt
	|
	|-RVA: 0x1864C40 Offset: 0x1863640 VA: 0x181864C40
	|-InlinedArray<GCHandle>.RemoveAt
	|-InlinedArray<ulong>.RemoveAt
	|
	|-RVA: 0x1865A00 Offset: 0x1864400 VA: 0x181865A00
	|-InlinedArray<int>.RemoveAt
	|
	|-RVA: 0x18644C0 Offset: 0x1862EC0 VA: 0x1818644C0
	|-InlinedArray<InternedString>.RemoveAt
	|-InlinedArray<Substring>.RemoveAt
	|-InlinedArray<InputUser.OngoingAccountSelection>.RemoveAt
	|
	|-RVA: 0x1864E80 Offset: 0x1863880 VA: 0x181864E80
	|-InlinedArray<object>.RemoveAt
	|
	|-RVA: 0x1864960 Offset: 0x1863360 VA: 0x181864960
	|-InlinedArray<PointerModel>.RemoveAt
	|
	|-RVA: 0x1865320 Offset: 0x1863D20 VA: 0x181865320
	|-InlinedArray<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x18650C0 Offset: 0x1863AC0 VA: 0x1818650C0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.RemoveAt
	|
	|-RVA: 0x1864700 Offset: 0x1863100 VA: 0x181864700
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtByMovingTailWithCapacity(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856CC0 Offset: 0x18556C0 VA: 0x181856CC0
	|-InlinedArray<KeyValuePair<int, int>>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862320 Offset: 0x1860D20 VA: 0x181862320
	|-InlinedArray<GCHandle>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x18625F0 Offset: 0x1860FF0 VA: 0x1818625F0
	|-InlinedArray<int>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862470 Offset: 0x1860E70 VA: 0x181862470
	|-InlinedArray<InternedString>.RemoveAtByMovingTailWithCapacity
	|-InlinedArray<Substring>.RemoveAtByMovingTailWithCapacity
	|-InlinedArray<InputUser.OngoingAccountSelection>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x18621C0 Offset: 0x1860BC0 VA: 0x1818621C0
	|-InlinedArray<object>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862730 Offset: 0x1861130 VA: 0x181862730
	|-InlinedArray<PointerModel>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862B30 Offset: 0x1861530 VA: 0x181862B30
	|-InlinedArray<ulong>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862C80 Offset: 0x1861680 VA: 0x181862C80
	|-InlinedArray<__Il2CppFullySharedGenericType>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862010 Offset: 0x1860A10 VA: 0x181862010
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.RemoveAtByMovingTailWithCapacity
	|
	|-RVA: 0x1862980 Offset: 0x1861380 VA: 0x181862980
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.RemoveAtByMovingTailWithCapacity
	*/

	// RVA: -1 Offset: -1
	public bool RemoveByMovingTailWithCapacity(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18571D0 Offset: 0x1855BD0 VA: 0x1818571D0
	|-InlinedArray<KeyValuePair<int, int>>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x18661A0 Offset: 0x1864BA0 VA: 0x1818661A0
	|-InlinedArray<GCHandle>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1866060 Offset: 0x1864A60 VA: 0x181866060
	|-InlinedArray<int>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865C30 Offset: 0x1864630 VA: 0x181865C30
	|-InlinedArray<InternedString>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1866100 Offset: 0x1864B00 VA: 0x181866100
	|-InlinedArray<object>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x18663F0 Offset: 0x1864DF0 VA: 0x1818663F0
	|-InlinedArray<PointerModel>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865D90 Offset: 0x1864790 VA: 0x181865D90
	|-InlinedArray<Substring>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865E40 Offset: 0x1864840 VA: 0x181865E40
	|-InlinedArray<ulong>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1866240 Offset: 0x1864C40 VA: 0x181866240
	|-InlinedArray<__Il2CppFullySharedGenericType>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865EE0 Offset: 0x18648E0 VA: 0x181865EE0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865CE0 Offset: 0x18646E0 VA: 0x181865CE0
	|-InlinedArray<InputUser.OngoingAccountSelection>.RemoveByMovingTailWithCapacity
	|
	|-RVA: 0x1865FA0 Offset: 0x18649A0 VA: 0x181865FA0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.RemoveByMovingTailWithCapacity
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TValue value, IEqualityComparer<TValue> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856710 Offset: 0x1855110 VA: 0x181856710
	|-InlinedArray<KeyValuePair<int, int>>.Contains
	|
	|-RVA: 0x185E5D0 Offset: 0x185CFD0 VA: 0x18185E5D0
	|-InlinedArray<GCHandle>.Contains
	|
	|-RVA: 0x185DC70 Offset: 0x185C670 VA: 0x18185DC70
	|-InlinedArray<int>.Contains
	|
	|-RVA: 0x185DDD0 Offset: 0x185C7D0 VA: 0x18185DDD0
	|-InlinedArray<InternedString>.Contains
	|-InlinedArray<Substring>.Contains
	|-InlinedArray<InputUser.OngoingAccountSelection>.Contains
	|
	|-RVA: 0x185E190 Offset: 0x185CB90 VA: 0x18185E190
	|-InlinedArray<object>.Contains
	|-InlinedArray<ulong>.Contains
	|
	|-RVA: 0x185E2F0 Offset: 0x185CCF0 VA: 0x18185E2F0
	|-InlinedArray<PointerModel>.Contains
	|
	|-RVA: 0x185DA10 Offset: 0x185C410 VA: 0x18185DA10
	|-InlinedArray<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x185DFC0 Offset: 0x185C9C0 VA: 0x18185DFC0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Contains
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Contains
	*/

	// RVA: -1 Offset: -1
	public void Merge(InlinedArray<TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18569F0 Offset: 0x18553F0 VA: 0x1818569F0
	|-InlinedArray<KeyValuePair<int, int>>.Merge
	|
	|-RVA: 0x18616D0 Offset: 0x18600D0 VA: 0x1818616D0
	|-InlinedArray<GCHandle>.Merge
	|
	|-RVA: 0x1861420 Offset: 0x185FE20 VA: 0x181861420
	|-InlinedArray<int>.Merge
	|
	|-RVA: 0x1861E40 Offset: 0x1860840 VA: 0x181861E40
	|-InlinedArray<InternedString>.Merge
	|
	|-RVA: 0x1861150 Offset: 0x185FB50 VA: 0x181861150
	|-InlinedArray<object>.Merge
	|
	|-RVA: 0x1860040 Offset: 0x185EA40 VA: 0x181860040
	|-InlinedArray<PointerModel>.Merge
	|
	|-RVA: 0x1861C70 Offset: 0x1860670 VA: 0x181861C70
	|-InlinedArray<Substring>.Merge
	|
	|-RVA: 0x18619A0 Offset: 0x18603A0 VA: 0x1818619A0
	|-InlinedArray<ulong>.Merge
	|
	|-RVA: 0x1860440 Offset: 0x185EE40 VA: 0x181860440
	|-InlinedArray<__Il2CppFullySharedGenericType>.Merge
	|
	|-RVA: 0x18609D0 Offset: 0x185F3D0 VA: 0x1818609D0
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.Merge
	|
	|-RVA: 0x1860800 Offset: 0x185F200 VA: 0x181860800
	|-InlinedArray<InputUser.OngoingAccountSelection>.Merge
	|
	|-RVA: 0x1860D90 Offset: 0x185F790 VA: 0x181860D90
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.Merge
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1856870 Offset: 0x1855270 VA: 0x181856870
	|-InlinedArray<KeyValuePair<int, int>>.GetEnumerator
	|-InlinedArray<GCHandle>.GetEnumerator
	|-InlinedArray<ulong>.GetEnumerator
	|
	|-RVA: 0x185ECC0 Offset: 0x185D6C0 VA: 0x18185ECC0
	|-InlinedArray<int>.GetEnumerator
	|
	|-RVA: 0x185E730 Offset: 0x185D130 VA: 0x18185E730
	|-InlinedArray<InternedString>.GetEnumerator
	|-InlinedArray<Substring>.GetEnumerator
	|-InlinedArray<InputUser.OngoingAccountSelection>.GetEnumerator
	|
	|-RVA: 0x185ED40 Offset: 0x185D740 VA: 0x18185ED40
	|-InlinedArray<object>.GetEnumerator
	|
	|-RVA: 0x185EA70 Offset: 0x185D470 VA: 0x18185EA70
	|-InlinedArray<PointerModel>.GetEnumerator
	|
	|-RVA: 0x185E880 Offset: 0x185D280 VA: 0x18185E880
	|-InlinedArray<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x185EC00 Offset: 0x185D600 VA: 0x18185EC00
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.GetEnumerator
	|
	|-RVA: 0x185E7C0 Offset: 0x185D1C0 VA: 0x18185E7C0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1857560 Offset: 0x1855F60 VA: 0x181857560
	|-InlinedArray<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|-InlinedArray<GCHandle>.System.Collections.IEnumerable.GetEnumerator
	|-InlinedArray<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868DE0 Offset: 0x18677E0 VA: 0x181868DE0
	|-InlinedArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868CA0 Offset: 0x18676A0 VA: 0x181868CA0
	|-InlinedArray<InternedString>.System.Collections.IEnumerable.GetEnumerator
	|-InlinedArray<Substring>.System.Collections.IEnumerable.GetEnumerator
	|-InlinedArray<InputUser.OngoingAccountSelection>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868C60 Offset: 0x1867660 VA: 0x181868C60
	|-InlinedArray<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868D60 Offset: 0x1867760 VA: 0x181868D60
	|-InlinedArray<PointerModel>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868CE0 Offset: 0x18676E0 VA: 0x181868CE0
	|-InlinedArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868E20 Offset: 0x1867820 VA: 0x181868E20
	|-InlinedArray<InputManager.StateChangeMonitorTimeout>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1868DA0 Offset: 0x18677A0 VA: 0x181868DA0
	|-InlinedArray<OnScreenControl.OnScreenDeviceInfo>.System.Collections.IEnumerable.GetEnumerator
	*/
}
