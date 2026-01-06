internal sealed class _AndroidJNIHelper // TypeDefIndex: 18338
{
	// Methods

	// RVA: 0x2C6FA30 Offset: 0x2C6E430 VA: 0x182C6FA30
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x2C65B60 Offset: 0x2C64560 VA: 0x182C65B60
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x2C70F90 Offset: 0x2C6F990 VA: 0x182C70F90
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x2C6F200 Offset: 0x2C6DC00 VA: 0x182C6F200
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x2C71040 Offset: 0x2C6FA40 VA: 0x182C71040
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x2C71720 Offset: 0x2C70120 VA: 0x182C71720
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x2C6D5D0 Offset: 0x2C6BFD0 VA: 0x182C6D5D0
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x2C6FBE0 Offset: 0x2C6E5E0 VA: 0x182C6FBE0
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x2C6E540 Offset: 0x2C6CF40 VA: 0x182C6E540
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF826C0 Offset: 0xF810C0 VA: 0x180F826C0
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0xF83080 Offset: 0xF81A80 VA: 0x180F83080
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0xF83A50 Offset: 0xF82450 VA: 0x180F83A50
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0xF84C30 Offset: 0xF83630 VA: 0x180F84C30
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0xF855F0 Offset: 0xF83FF0 VA: 0x180F855F0
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0xF85FC0 Offset: 0xF849C0 VA: 0x180F85FC0
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0xF869F0 Offset: 0xF853F0 VA: 0x180F869F0
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0xF84410 Offset: 0xF82E10 VA: 0x180F84410
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C65E00 Offset: 0x2C64800 VA: 0x182C65E00
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF873B0 Offset: 0xF85DB0 VA: 0x180F873B0
	|-_AndroidJNIHelper.GetMethodID<bool>
	|-_AndroidJNIHelper.GetMethodID<char>
	|-_AndroidJNIHelper.GetMethodID<double>
	|-_AndroidJNIHelper.GetMethodID<short>
	|-_AndroidJNIHelper.GetMethodID<int>
	|-_AndroidJNIHelper.GetMethodID<long>
	|-_AndroidJNIHelper.GetMethodID<object>
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0xF87430 Offset: 0xF85E30 VA: 0x180F87430
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C6FD60 Offset: 0x2C6E760 VA: 0x182C6FD60
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x2C6FF00 Offset: 0x2C6E900 VA: 0x182C6FF00
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2C6FED0 Offset: 0x2C6E8D0 VA: 0x182C6FED0
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2C701A0 Offset: 0x2C6EBA0 VA: 0x182C701A0
	public static string GetSignature(object obj) { }

	// RVA: 0x2C70080 Offset: 0x2C6EA80 VA: 0x182C70080
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF874C0 Offset: 0xF85EC0 VA: 0x180F874C0
	|-_AndroidJNIHelper.GetSignature<bool>
	|-_AndroidJNIHelper.GetSignature<char>
	|-_AndroidJNIHelper.GetSignature<double>
	|-_AndroidJNIHelper.GetSignature<short>
	|-_AndroidJNIHelper.GetSignature<int>
	|-_AndroidJNIHelper.GetSignature<long>
	|-_AndroidJNIHelper.GetSignature<object>
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|-_AndroidJNIHelper.GetSignature<float>
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/
}
