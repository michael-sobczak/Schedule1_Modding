internal class AndroidJNISafe // TypeDefIndex: 18342
{
	// Methods

	// RVA: 0x2C67040 Offset: 0x2C65A40 VA: 0x182C67040
	public static void CheckException() { }

	// RVA: 0x2C67C00 Offset: 0x2C66600 VA: 0x182C67C00
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x2C672B0 Offset: 0x2C65CB0 VA: 0x182C672B0
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x2C67260 Offset: 0x2C65C60 VA: 0x182C67260
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x2C67B90 Offset: 0x2C66590 VA: 0x182C67B90
	public static IntPtr NewString(string chars) { }

	// RVA: 0x2C67A50 Offset: 0x2C66450 VA: 0x182C67A50
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x2C67950 Offset: 0x2C66350 VA: 0x182C67950
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x2C679C0 Offset: 0x2C663C0 VA: 0x182C679C0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2C67840 Offset: 0x2C66240 VA: 0x182C67840
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x2C67680 Offset: 0x2C66080 VA: 0x182C67680
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x2C67300 Offset: 0x2C65D00 VA: 0x182C67300
	public static IntPtr FindClass(string name) { }

	// RVA: 0x2C67AC0 Offset: 0x2C664C0 VA: 0x182C67AC0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66C70 Offset: 0x2C65670 VA: 0x182C66C70
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2C66BA0 Offset: 0x2C655A0 VA: 0x182C66BA0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66EA0 Offset: 0x2C658A0 VA: 0x182C66EA0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66780 Offset: 0x2C65180 VA: 0x182C66780
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66850 Offset: 0x2C65250 VA: 0x182C66850
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66930 Offset: 0x2C65330 VA: 0x182C66930
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66AD0 Offset: 0x2C654D0 VA: 0x182C66AD0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66DD0 Offset: 0x2C657D0 VA: 0x182C66DD0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66D00 Offset: 0x2C65700 VA: 0x182C66D00
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C666B0 Offset: 0x2C650B0 VA: 0x182C666B0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66A10 Offset: 0x2C65410 VA: 0x182C66A10
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66440 Offset: 0x2C64E40 VA: 0x182C66440
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66F70 Offset: 0x2C65970 VA: 0x182C66F70
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66020 Offset: 0x2C64A20 VA: 0x182C66020
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C660F0 Offset: 0x2C64AF0 VA: 0x182C660F0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C661D0 Offset: 0x2C64BD0 VA: 0x182C661D0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66370 Offset: 0x2C64D70 VA: 0x182C66370
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C665E0 Offset: 0x2C64FE0 VA: 0x182C665E0
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C66510 Offset: 0x2C64F10 VA: 0x182C66510
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C65F50 Offset: 0x2C64950 VA: 0x182C65F50
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C662B0 Offset: 0x2C64CB0 VA: 0x182C662B0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x2C67450 Offset: 0x2C65E50 VA: 0x182C67450
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x2C674C0 Offset: 0x2C65EC0 VA: 0x182C674C0
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x2C67530 Offset: 0x2C65F30 VA: 0x182C67530
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x2C67610 Offset: 0x2C66010 VA: 0x182C67610
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x2C67760 Offset: 0x2C66160 VA: 0x182C67760
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x2C673E0 Offset: 0x2C65DE0 VA: 0x182C673E0
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x2C676F0 Offset: 0x2C660F0 VA: 0x182C676F0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x2C67370 Offset: 0x2C65D70 VA: 0x182C67370
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x2C675A0 Offset: 0x2C65FA0 VA: 0x182C675A0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x2C68010 Offset: 0x2C66A10 VA: 0x182C68010
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x2C67D40 Offset: 0x2C66740 VA: 0x182C67D40
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x2C67DD0 Offset: 0x2C667D0 VA: 0x182C67DD0
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x2C67E60 Offset: 0x2C66860 VA: 0x182C67E60
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x2C67F80 Offset: 0x2C66980 VA: 0x182C67F80
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x2C68140 Offset: 0x2C66B40 VA: 0x182C68140
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x2C67CD0 Offset: 0x2C666D0 VA: 0x182C67CD0
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2C680B0 Offset: 0x2C66AB0 VA: 0x182C680B0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x2C67C50 Offset: 0x2C66650 VA: 0x182C67C50
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x2C67EF0 Offset: 0x2C668F0 VA: 0x182C67EF0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x2C678D0 Offset: 0x2C662D0 VA: 0x182C678D0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x2C677D0 Offset: 0x2C661D0 VA: 0x182C677D0
	public static int GetArrayLength(IntPtr array) { }
}
