public static class AndroidJNIHelper // TypeDefIndex: 18340
{
	// Methods

	// RVA: 0x2C65F30 Offset: 0x2C64930 VA: 0x182C65F30
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x2C65F40 Offset: 0x2C64940 VA: 0x182C65F40
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x2C65B60 Offset: 0x2C64560 VA: 0x182C65B60
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x2C65940 Offset: 0x2C64340 VA: 0x182C65940
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x2C65810 Offset: 0x2C64210 VA: 0x182C65810
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x2C65C70 Offset: 0x2C64670 VA: 0x182C65C70
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x2C65E00 Offset: 0x2C64800 VA: 0x182C65E00
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBF9F0 Offset: 0xDBE3F0 VA: 0x180DBF9F0
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0xDBFA30 Offset: 0xDBE430 VA: 0x180DBFA30
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0xDBFA70 Offset: 0xDBE470 VA: 0x180DBFA70
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0xDBFBC0 Offset: 0xDBE5C0 VA: 0x180DBFBC0
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0xDBFC00 Offset: 0xDBE600 VA: 0x180DBFC00
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0xDBFC40 Offset: 0xDBE640 VA: 0x180DBFC40
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0xDBFC80 Offset: 0xDBE680 VA: 0x180DBFC80
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0xDBFAB0 Offset: 0xDBE4B0 VA: 0x180DBFAB0
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBFCC0 Offset: 0xDBE6C0 VA: 0x180DBFCC0
	|-AndroidJNIHelper.GetMethodID<bool>
	|-AndroidJNIHelper.GetMethodID<char>
	|-AndroidJNIHelper.GetMethodID<double>
	|-AndroidJNIHelper.GetMethodID<short>
	|-AndroidJNIHelper.GetMethodID<int>
	|-AndroidJNIHelper.GetMethodID<long>
	|-AndroidJNIHelper.GetMethodID<object>
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0xDBFD40 Offset: 0xDBE740 VA: 0x180DBFD40
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C656E0 Offset: 0x2C640E0 VA: 0x182C656E0
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x2C65620 Offset: 0x2C64020 VA: 0x182C65620
	public static IntPtr Box(int value) { }

	// RVA: 0x2C65680 Offset: 0x2C64080 VA: 0x182C65680
	public static IntPtr Box(bool value) { }
}
