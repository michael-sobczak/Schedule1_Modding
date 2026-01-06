public static class AndroidJNI // TypeDefIndex: 18341
{
	// Methods

	[ThreadSafe]
	// RVA: 0x2C69610 Offset: 0x2C68010 VA: 0x182C69610
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x2C69810 Offset: 0x2C68210 VA: 0x182C69810
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x2C695E0 Offset: 0x2C67FE0 VA: 0x182C695E0
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x2C695B0 Offset: 0x2C67FB0 VA: 0x182C695B0
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x2C69AE0 Offset: 0x2C684E0 VA: 0x182C69AE0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69D10 Offset: 0x2C68710 VA: 0x182C69D10
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69CD0 Offset: 0x2C686D0 VA: 0x182C69CD0
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69570 Offset: 0x2C67F70 VA: 0x182C69570
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69B20 Offset: 0x2C68520 VA: 0x182C69B20
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69530 Offset: 0x2C67F30 VA: 0x182C69530
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69A90 Offset: 0x2C68490 VA: 0x182C69A90
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x2C69C10 Offset: 0x2C68610 VA: 0x182C69C10
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C69B60 Offset: 0x2C68560 VA: 0x182C69B60
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x2C699B0 Offset: 0x2C683B0 VA: 0x182C699B0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69910 Offset: 0x2C68310 VA: 0x182C69910
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x2C699F0 Offset: 0x2C683F0 VA: 0x182C699F0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x2C69C90 Offset: 0x2C68690 VA: 0x182C69C90
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x2C69C90 Offset: 0x2C68690 VA: 0x182C69C90
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	// RVA: 0x2C69A50 Offset: 0x2C68450 VA: 0x182C69A50
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x2C69420 Offset: 0x2C67E20 VA: 0x182C69420
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2C693A0 Offset: 0x2C67DA0 VA: 0x182C693A0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C69340 Offset: 0x2C67D40 VA: 0x182C69340
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68770 Offset: 0x2C67170 VA: 0x182C68770
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68710 Offset: 0x2C67110 VA: 0x182C68710
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C685B0 Offset: 0x2C66FB0 VA: 0x182C685B0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68550 Offset: 0x2C66F50 VA: 0x182C68550
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68230 Offset: 0x2C66C30 VA: 0x182C68230
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C681D0 Offset: 0x2C66BD0 VA: 0x182C681D0
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68930 Offset: 0x2C67330 VA: 0x182C68930
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C688D0 Offset: 0x2C672D0 VA: 0x182C688D0
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68850 Offset: 0x2C67250 VA: 0x182C68850
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C687F0 Offset: 0x2C671F0 VA: 0x182C687F0
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68310 Offset: 0x2C66D10 VA: 0x182C68310
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C682B0 Offset: 0x2C66CB0 VA: 0x182C682B0
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C684D0 Offset: 0x2C66ED0 VA: 0x182C684D0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68470 Offset: 0x2C66E70 VA: 0x182C68470
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C683F0 Offset: 0x2C66DF0 VA: 0x182C683F0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68390 Offset: 0x2C66D90 VA: 0x182C68390
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68690 Offset: 0x2C67090 VA: 0x182C68690
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68630 Offset: 0x2C67030 VA: 0x182C68630
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C69270 Offset: 0x2C67C70 VA: 0x182C69270
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x2C691F0 Offset: 0x2C67BF0 VA: 0x182C691F0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C69190 Offset: 0x2C67B90 VA: 0x182C69190
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68F50 Offset: 0x2C67950 VA: 0x182C68F50
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68EF0 Offset: 0x2C678F0 VA: 0x182C68EF0
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68D90 Offset: 0x2C67790 VA: 0x182C68D90
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68D30 Offset: 0x2C67730 VA: 0x182C68D30
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68A10 Offset: 0x2C67410 VA: 0x182C68A10
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C689B0 Offset: 0x2C673B0 VA: 0x182C689B0
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C69110 Offset: 0x2C67B10 VA: 0x182C69110
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C690B0 Offset: 0x2C67AB0 VA: 0x182C690B0
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C69030 Offset: 0x2C67A30 VA: 0x182C69030
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68FD0 Offset: 0x2C679D0 VA: 0x182C68FD0
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68AF0 Offset: 0x2C674F0 VA: 0x182C68AF0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68A90 Offset: 0x2C67490 VA: 0x182C68A90
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68CB0 Offset: 0x2C676B0 VA: 0x182C68CB0
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68C50 Offset: 0x2C67650 VA: 0x182C68C50
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68BD0 Offset: 0x2C675D0 VA: 0x182C68BD0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68B70 Offset: 0x2C67570 VA: 0x182C68B70
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x2C68E70 Offset: 0x2C67870 VA: 0x182C68E70
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x2C68E10 Offset: 0x2C67810 VA: 0x182C68E10
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x2C694F0 Offset: 0x2C67EF0 VA: 0x182C694F0
	private static IntPtr ConvertToBooleanArray(bool[] array) { }

	// RVA: 0x2C69DA0 Offset: 0x2C687A0 VA: 0x182C69DA0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	// RVA: 0x2C69DE0 Offset: 0x2C687E0 VA: 0x182C69DE0
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x2C6A260 Offset: 0x2C68C60 VA: 0x182C6A260
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x2C6A2D0 Offset: 0x2C68CD0 VA: 0x182C6A2D0
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x2C69E60 Offset: 0x2C68860 VA: 0x182C69E60
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x2C69E20 Offset: 0x2C68820 VA: 0x182C69E20
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x2C6A350 Offset: 0x2C68D50 VA: 0x182C6A350
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x2C6A310 Offset: 0x2C68D10 VA: 0x182C6A310
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x2C6A070 Offset: 0x2C68A70 VA: 0x182C6A070
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x2C6A030 Offset: 0x2C68A30 VA: 0x182C6A030
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x2C6A0E0 Offset: 0x2C68AE0 VA: 0x182C6A0E0
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x2C6A150 Offset: 0x2C68B50 VA: 0x182C6A150
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x2C69F80 Offset: 0x2C68980 VA: 0x182C69F80
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x2C69FF0 Offset: 0x2C689F0 VA: 0x182C69FF0
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x2C69ED0 Offset: 0x2C688D0 VA: 0x182C69ED0
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x2C69F40 Offset: 0x2C68940 VA: 0x182C69F40
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x2C6A210 Offset: 0x2C68C10 VA: 0x182C6A210
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x2C6A190 Offset: 0x2C68B90 VA: 0x182C6A190
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	// RVA: 0x2C69650 Offset: 0x2C68050 VA: 0x182C69650
	public static bool[] FromBooleanArray(IntPtr array) { }

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	// RVA: 0x2C69690 Offset: 0x2C68090 VA: 0x182C69690
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69850 Offset: 0x2C68250 VA: 0x182C69850
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C696D0 Offset: 0x2C680D0 VA: 0x182C696D0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69890 Offset: 0x2C68290 VA: 0x182C69890
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69790 Offset: 0x2C68190 VA: 0x182C69790
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C697D0 Offset: 0x2C681D0 VA: 0x182C697D0
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69750 Offset: 0x2C68150 VA: 0x182C69750
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69710 Offset: 0x2C68110 VA: 0x182C69710
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C698D0 Offset: 0x2C682D0 VA: 0x182C698D0
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x2C69BC0 Offset: 0x2C685C0 VA: 0x182C69BC0
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x2C69970 Offset: 0x2C68370 VA: 0x182C69970
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x2C69D50 Offset: 0x2C68750 VA: 0x182C69D50
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }
}
