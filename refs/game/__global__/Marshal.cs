public static class Marshal // TypeDefIndex: 4562
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4
	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache; // 0x8
	internal static readonly object MarshalerInstanceCacheLock; // 0x10

	// Methods

	// RVA: 0x1B65530 Offset: 0x1B63F30 VA: 0x181B65530
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1B65540 Offset: 0x1B63F40 VA: 0x181B65540
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1B65550 Offset: 0x1B63F50 VA: 0x181B65550
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x1B69290 Offset: 0x1B67C90 VA: 0x181B69290
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B69280 Offset: 0x1B67C80 VA: 0x181B69280
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	// RVA: 0x1B693F0 Offset: 0x1B67DF0 VA: 0x181B693F0
	private static bool skip_fixed(Array array, int startIndex) { }

	// RVA: 0x1B69310 Offset: 0x1B67D10 VA: 0x181B69310
	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B665D0 Offset: 0x1B64FD0 VA: 0x181B665D0
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B66A20 Offset: 0x1B65420 VA: 0x181B66A20
	public static void Copy(short[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B66720 Offset: 0x1B65120 VA: 0x181B66720
	public static void Copy(int[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B66820 Offset: 0x1B65220 VA: 0x181B66820
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1B69200 Offset: 0x1B67C00 VA: 0x181B69200
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x1B691F0 Offset: 0x1B67BF0 VA: 0x181B691F0
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	// RVA: 0x1B66E20 Offset: 0x1B65820 VA: 0x181B66E20
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x1B66B20 Offset: 0x1B65520 VA: 0x181B66B20
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x1B66C20 Offset: 0x1B65620 VA: 0x181B66C20
	public static void Copy(IntPtr source, int[] destination, int startIndex, int length) { }

	// RVA: 0x1B66920 Offset: 0x1B65320 VA: 0x181B66920
	public static void Copy(IntPtr source, float[] destination, int startIndex, int length) { }

	// RVA: 0x1B66D20 Offset: 0x1B65720 VA: 0x181B66D20
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	[ComVisible(True)]
	// RVA: 0x1B66F20 Offset: 0x1B65920 VA: 0x181B66F20
	public static void DestroyStructure(IntPtr ptr, Type structuretype) { }

	// RVA: 0x1B670A0 Offset: 0x1B65AA0 VA: 0x181B670A0
	public static void FreeBSTR(IntPtr ptr) { }

	// RVA: 0x1B670B0 Offset: 0x1B65AB0 VA: 0x181B670B0
	public static void FreeCoTaskMem(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B670C0 Offset: 0x1B65AC0 VA: 0x181B670C0
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x1B655B0 Offset: 0x1B63FB0 VA: 0x181B655B0
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x1B69000 Offset: 0x1B67A00 VA: 0x181B69000
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x1B67DA0 Offset: 0x1B667A0 VA: 0x181B67DA0
	public static int GetHRForException(Exception e) { }

	// RVA: 0x1B67DC0 Offset: 0x1B667C0 VA: 0x181B67DC0
	public static bool IsComObject(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B67DB0 Offset: 0x1B667B0 VA: 0x181B67DB0
	public static int GetLastWin32Error() { }

	// RVA: 0x1B67DD0 Offset: 0x1B667D0 VA: 0x181B67DD0
	public static IntPtr OffsetOf(Type t, string fieldName) { }

	// RVA: 0x1B67DE0 Offset: 0x1B667E0 VA: 0x181B67DE0
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x1B67DF0 Offset: 0x1B667F0 VA: 0x181B67DF0
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	// RVA: 0x1B67E00 Offset: 0x1B66800 VA: 0x181B67E00
	public static string PtrToStringAuto(IntPtr ptr) { }

	// RVA: 0x1B67E90 Offset: 0x1B66890 VA: 0x181B67E90
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0x1B67EA0 Offset: 0x1B668A0 VA: 0x181B67EA0
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisible(True)]
	// RVA: 0x1B67EC0 Offset: 0x1B668C0 VA: 0x181B67EC0
	public static void PtrToStructure(IntPtr ptr, object structure) { }

	[ComVisible(True)]
	// RVA: 0x1B67EB0 Offset: 0x1B668B0 VA: 0x181B67EB0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static void PtrToStructure<T>(IntPtr ptr, T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFDB40 Offset: 0xEFC540 VA: 0x180EFDB40
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xEFD840 Offset: 0xEFC240 VA: 0x180EFD840
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFDA50 Offset: 0xEFC450 VA: 0x180EFDA50
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xEFDBA0 Offset: 0xEFC5A0 VA: 0x180EFDBA0
	|-Marshal.PtrToStructure<SteamNetworkingMessage_t>
	|
	|-RVA: 0xEFDD20 Offset: 0xEFC720 VA: 0x180EFDD20
	|-Marshal.PtrToStructure<Win32_FIXED_INFO_Marshal>
	|
	|-RVA: 0xEFDEA0 Offset: 0xEFC8A0 VA: 0x180EFDEA0
	|-Marshal.PtrToStructure<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xEFD920 Offset: 0xEFC320 VA: 0x180EFD920
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B67ED0 Offset: 0x1B668D0 VA: 0x181B67ED0
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x1B67EF0 Offset: 0x1B668F0 VA: 0x181B67EF0
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B67F90 Offset: 0x1B66990 VA: 0x181B67F90
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B67F40 Offset: 0x1B66940 VA: 0x181B67F40
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B67FD0 Offset: 0x1B669D0 VA: 0x181B67FD0
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0x1B68030 Offset: 0x1B66A30 VA: 0x181B68030
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B68190 Offset: 0x1B66B90 VA: 0x181B68190
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B68080 Offset: 0x1B66A80 VA: 0x181B68080
	public static IntPtr ReadIntPtr(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B683E0 Offset: 0x1B66DE0 VA: 0x181B683E0
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1B683F0 Offset: 0x1B66DF0 VA: 0x181B683F0
	public static int Release(IntPtr pUnk) { }

	// RVA: 0x1B68290 Offset: 0x1B66C90 VA: 0x181B68290
	private static int ReleaseComObjectInternal(object co) { }

	// RVA: 0x1B682A0 Offset: 0x1B66CA0 VA: 0x181B682A0
	public static int ReleaseComObject(object o) { }

	[ComVisible(True)]
	// RVA: 0x1B68920 Offset: 0x1B67320 VA: 0x181B68920
	public static int SizeOf(object structure) { }

	// RVA: 0x1B68980 Offset: 0x1B67380 VA: 0x181B68980
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE000 Offset: 0xEFCA00 VA: 0x180EFE000
	|-Marshal.SizeOf<int>
	|-Marshal.SizeOf<Matrix4x4>
	|-Marshal.SizeOf<float>
	|-Marshal.SizeOf<Vector4>
	|-Marshal.SizeOf<__Il2CppFullySharedGenericType>
	|-Marshal.SizeOf<ShaderInput.LightData>
	|-Marshal.SizeOf<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>
	*/

	// RVA: 0x1B68990 Offset: 0x1B67390 VA: 0x181B68990
	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	// RVA: 0x1B689A0 Offset: 0x1B673A0 VA: 0x181B689A0
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0x1B68A20 Offset: 0x1B67420 VA: 0x181B68A20
	public static IntPtr StringToHGlobalAuto(string s) { }

	// RVA: 0x1B68BF0 Offset: 0x1B675F0 VA: 0x181B68BF0
	private static IntPtr StringToHGlobalUni(char* s, int length) { }

	// RVA: 0x1B68B70 Offset: 0x1B67570 VA: 0x181B68B70
	public static IntPtr StringToHGlobalUni(string s) { }

	// RVA: 0x1B684A0 Offset: 0x1B66EA0 VA: 0x181B684A0
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	// RVA: 0x1B686A0 Offset: 0x1B670A0 VA: 0x181B686A0
	internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x1B68530 Offset: 0x1B66F30 VA: 0x181B68530
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ReliabilityContract(3, 1)]
	[ComVisible(True)]
	// RVA: 0x1B68C00 Offset: 0x1B67600 VA: 0x181B68C00
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE180 Offset: 0xEFCB80 VA: 0x180EFE180
	|-Marshal.StructureToPtr<MatchMakingKeyValuePair_t>
	|-Marshal.StructureToPtr<SteamParamStringArray_t>
	|
	|-RVA: 0xEFE220 Offset: 0xEFCC20 VA: 0x180EFE220
	|-Marshal.StructureToPtr<object>
	|
	|-RVA: 0xEFE090 Offset: 0xEFCA90 VA: 0x180EFE090
	|-Marshal.StructureToPtr<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B68C10 Offset: 0x1B67610 VA: 0x181B68C10
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFE290 Offset: 0xEFCC90 VA: 0x180EFE290
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xEFE2F0 Offset: 0xEFCCF0 VA: 0x180EFE2F0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B68C20 Offset: 0x1B67620 VA: 0x181B68C20
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x1B68C50 Offset: 0x1B67650 VA: 0x181B68C50
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x1B68CA0 Offset: 0x1B676A0 VA: 0x181B68CA0
	public static void WriteInt32(IntPtr ptr, int val) { }

	// RVA: 0x1B68CE0 Offset: 0x1B676E0 VA: 0x181B68CE0
	public static void WriteInt32(IntPtr ptr, int ofs, int val) { }

	// RVA: 0x1B68D30 Offset: 0x1B67730 VA: 0x181B68D30
	public static void WriteInt64(IntPtr ptr, long val) { }

	// RVA: 0x1B68D70 Offset: 0x1B67770 VA: 0x181B68D70
	public static void WriteInt64(IntPtr ptr, int ofs, long val) { }

	// RVA: 0x1B68DC0 Offset: 0x1B677C0 VA: 0x181B68DC0
	public static void WriteIntPtr(IntPtr ptr, IntPtr val) { }

	// RVA: 0x1B68ED0 Offset: 0x1B678D0 VA: 0x181B68ED0
	public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val) { }

	// RVA: 0x1B656C0 Offset: 0x1B640C0 VA: 0x181B656C0
	private static Exception ConvertHrToException(int errorCode) { }

	// RVA: 0x1B67C70 Offset: 0x1B66670 VA: 0x181B67C70
	public static Exception GetExceptionForHR(int errorCode) { }

	// RVA: 0x1B67C20 Offset: 0x1B66620 VA: 0x181B67C20
	public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo) { }

	// RVA: 0x1B66F30 Offset: 0x1B65930 VA: 0x181B66F30
	public static int FinalReleaseComObject(object o) { }

	// RVA: 0x1B67970 Offset: 0x1B66370 VA: 0x181B67970
	private static Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t) { }

	// RVA: 0x1B67980 Offset: 0x1B66380 VA: 0x181B67980
	public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t) { }

	// RVA: -1 Offset: -1
	public static TDelegate GetDelegateForFunctionPointer<TDelegate>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD4E0 Offset: 0xEFBEE0 VA: 0x180EFD4E0
	|-Marshal.GetDelegateForFunctionPointer<object>
	|
	|-RVA: 0xEFD3B0 Offset: 0xEFBDB0 VA: 0x180EFD3B0
	|-Marshal.GetDelegateForFunctionPointer<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B67CF0 Offset: 0x1B666F0 VA: 0x181B67CF0
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: 0x1B67D00 Offset: 0x1B66700 VA: 0x181B67D00
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD760 Offset: 0xEFC160 VA: 0x180EFD760
	|-Marshal.GetFunctionPointerForDelegate<object>
	|
	|-RVA: 0xEFD5D0 Offset: 0xEFBFD0 VA: 0x180EFD5D0
	|-Marshal.GetFunctionPointerForDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B670D0 Offset: 0x1B65AD0 VA: 0x181B670D0
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	// RVA: 0x1B69140 Offset: 0x1B67B40 VA: 0x181B69140
	private static void .cctor() { }
}
