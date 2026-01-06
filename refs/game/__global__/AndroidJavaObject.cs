public class AndroidJavaObject : IDisposable // TypeDefIndex: 18335
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x2C6B330 Offset: 0x2C69D30 VA: 0x182C6B330
	public void .ctor(string className, object[] args) { }

	// RVA: 0x2C6B1E0 Offset: 0x2C69BE0 VA: 0x182C6B1E0
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x2C6AA70 Offset: 0x2C69470 VA: 0x182C6AA70 Slot: 4
	public void Dispose() { }

	// RVA: 0x2C6AC50 Offset: 0x2C69650 VA: 0x182C6AC50
	public IntPtr GetRawObject() { }

	// RVA: 0x1DF3BB0 Offset: 0x1DF25B0 VA: 0x181DF3BB0
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBFF90 Offset: 0xDBE990 VA: 0x180DBFF90
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0xDC0050 Offset: 0xDBEA50 VA: 0x180DC0050
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0xDC0110 Offset: 0xDBEB10 VA: 0x180DC0110
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0xDC01D0 Offset: 0xDBEBD0 VA: 0x180DC01D0
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0xDC0230 Offset: 0xDBEC30 VA: 0x180DC0230
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0xDC0290 Offset: 0xDBEC90 VA: 0x180DC0290
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0xDC02F0 Offset: 0xDBECF0 VA: 0x180DC02F0
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0xDC0350 Offset: 0xDBED50 VA: 0x180DC0350
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0xDC03B0 Offset: 0xDBEDB0 VA: 0x180DC03B0
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0xDBFDC0 Offset: 0xDBE7C0 VA: 0x180DBFDC0
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBFED0 Offset: 0xDBE8D0 VA: 0x180DBFED0
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0xDBFF30 Offset: 0xDBE930 VA: 0x180DBFF30
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0xDBFDC0 Offset: 0xDBE7C0 VA: 0x180DBFDC0
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C6AA00 Offset: 0x2C69400 VA: 0x182C6AA00
	protected void DebugPrint(string msg) { }

	// RVA: 0x2C6AC70 Offset: 0x2C69670 VA: 0x182C6AC70
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x2C6AEF0 Offset: 0x2C698F0 VA: 0x182C6AEF0
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x2C6ABE0 Offset: 0x2C695E0 VA: 0x182C6ABE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2C6AAE0 Offset: 0x2C694E0 VA: 0x182C6AAE0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC0E30 Offset: 0xDBF830 VA: 0x180DC0E30
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0xDC1F50 Offset: 0xDC0950 VA: 0x180DC1F50
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0xDC4130 Offset: 0xDC2B30 VA: 0x180DC4130
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0xDFB2A0 Offset: 0xDF9CA0 VA: 0x180DFB2A0
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0xDFC390 Offset: 0xDFAD90 VA: 0x180DFC390
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0xDFD4A0 Offset: 0xDFBEA0 VA: 0x180DFD4A0
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0xDFD530 Offset: 0xDFBF30 VA: 0x180DFD530
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0xDFE5E0 Offset: 0xDFCFE0 VA: 0x180DFE5E0
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0xDFE670 Offset: 0xDFD070 VA: 0x180DFE670
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0xDFB160 Offset: 0xDF9B60 VA: 0x180DFB160
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC0EE0 Offset: 0xDBF8E0 VA: 0x180DC0EE0
	|-AndroidJavaObject._Call<bool>
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0xDC2000 Offset: 0xDC0A00 VA: 0x180DC2000
	|-AndroidJavaObject._Call<char>
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0xDC3080 Offset: 0xDC1A80 VA: 0x180DC3080
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0xDFB330 Offset: 0xDF9D30 VA: 0x180DFB330
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0xDFC420 Offset: 0xDFAE20 VA: 0x180DFC420
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0xDFD5C0 Offset: 0xDFBFC0 VA: 0x180DFD5C0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0xDFE700 Offset: 0xDFD100 VA: 0x180DFE700
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0xDF9FF0 Offset: 0xDF89F0 VA: 0x180DF9FF0
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF8EB0 Offset: 0xDF78B0 VA: 0x180DF8EB0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0xDF8F40 Offset: 0xDF7940 VA: 0x180DF8F40
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0xDF7D10 Offset: 0xDF6710 VA: 0x180DF7D10
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF7E50 Offset: 0xDF6850 VA: 0x180DF7E50
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0xDF8FD0 Offset: 0xDF79D0 VA: 0x180DF8FD0
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0xDF6BA0 Offset: 0xDF55A0 VA: 0x180DF6BA0
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C6A920 Offset: 0x2C69320 VA: 0x182C6A920
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x2C6A840 Offset: 0x2C69240 VA: 0x182C6A840
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC0410 Offset: 0xDBEE10 VA: 0x180DC0410
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<bool>
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<sbyte>
	|
	|-RVA: 0xDC0530 Offset: 0xDBEF30 VA: 0x180DC0530
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<char>
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<short>
	|
	|-RVA: 0xDC0650 Offset: 0xDBF050 VA: 0x180DC0650
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<double>
	|
	|-RVA: 0xDC09C0 Offset: 0xDBF3C0 VA: 0x180DC09C0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<int>
	|
	|-RVA: 0xDC0AD0 Offset: 0xDBF4D0 VA: 0x180DC0AD0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<long>
	|
	|-RVA: 0xDC0BF0 Offset: 0xDBF5F0 VA: 0x180DC0BF0
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<object>
	|
	|-RVA: 0xDC0D00 Offset: 0xDBF700 VA: 0x180DC0D00
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<float>
	|
	|-RVA: 0xDC0780 Offset: 0xDBF180 VA: 0x180DC0780
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2C6AC50 Offset: 0x2C69650 VA: 0x182C6AC50
	protected IntPtr _GetRawObject() { }

	// RVA: 0x1DF3BB0 Offset: 0x1DF25B0 VA: 0x181DF3BB0
	protected IntPtr _GetRawClass() { }
}
