public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 3844
{
	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private IntPtr interp_method; // 0x48
	private IntPtr interp_invoke_impl; // 0x50
	private MethodInfo method_info; // 0x58
	private MethodInfo original_method_info; // 0x60
	private DelegateData data; // 0x68
	private bool method_is_virtual; // 0x70

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30
	public MethodInfo get_Method() { }

	// RVA: 0x1CBE9E0 Offset: 0x1CBD3E0 VA: 0x181CBE9E0
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public object get_Target() { }

	// RVA: 0x1CBCAA0 Offset: 0x1CBB4A0 VA: 0x181CBCAA0
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0x1CBECB0 Offset: 0x1CBD6B0 VA: 0x181CBECB0
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0x1CBEE50 Offset: 0x1CBD850 VA: 0x181CBEE50
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0x1CBF040 Offset: 0x1CBDA40 VA: 0x181CBF040
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0x1CBCBA0 Offset: 0x1CBB5A0 VA: 0x181CBCBA0
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0x1CBD7F0 Offset: 0x1CBC1F0 VA: 0x181CBD7F0
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0x1CBD7C0 Offset: 0x1CBC1C0 VA: 0x181CBD7C0
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x1CBD580 Offset: 0x1CBBF80 VA: 0x181CBD580
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0x1CBD6C0 Offset: 0x1CBC0C0 VA: 0x181CBD6C0
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0x1CBE020 Offset: 0x1CBCA20 VA: 0x181CBE020
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x1CBD810 Offset: 0x1CBC210 VA: 0x181CBD810
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x1CBD7A0 Offset: 0x1CBC1A0 VA: 0x181CBD7A0
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0x1CBD6A0 Offset: 0x1CBC0A0 VA: 0x181CBD6A0
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { }

	// RVA: 0x1CBD5B0 Offset: 0x1CBBFB0 VA: 0x181CBD5B0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x1CBCAB0 Offset: 0x1CBB4B0 VA: 0x181CBCAB0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0x1CBDE10 Offset: 0x1CBC810 VA: 0x181CBDE10
	public object DynamicInvoke(object[] args) { }

	// RVA: 0x1CBE9F0 Offset: 0x1CBD3F0 VA: 0x181CBE9F0
	private void InitializeDelegateData() { }

	// RVA: 0x1CBD940 Offset: 0x1CBC340 VA: 0x181CBD940 Slot: 6
	protected virtual object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x1CBC6D0 Offset: 0x1CBB0D0 VA: 0x181CBC6D0 Slot: 7
	public virtual object Clone() { }

	// RVA: 0x1CBDE30 Offset: 0x1CBC830 VA: 0x181CBDE30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CBE540 Offset: 0x1CBCF40 VA: 0x181CBE540 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CBE680 Offset: 0x1CBD080 VA: 0x181CBE680 Slot: 8
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0x1CBE7A0 Offset: 0x1CBD1A0 VA: 0x181CBE7A0 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CBE5E0 Offset: 0x1CBCFE0 VA: 0x181CBE5E0 Slot: 10
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0x1CBC740 Offset: 0x1CBB140 VA: 0x181CBC740
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisible(True)]
	// RVA: 0x1CBC8C0 Offset: 0x1CBB2C0 VA: 0x181CBC8C0
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0x1CBC6E0 Offset: 0x1CBB0E0 VA: 0x181CBC6E0 Slot: 11
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0x1CBEB30 Offset: 0x1CBD530 VA: 0x181CBEB30
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0x1CBEB00 Offset: 0x1CBD500 VA: 0x181CBEB00 Slot: 12
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0x1CBEFC0 Offset: 0x1CBD9C0 VA: 0x181CBEFC0
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0x1CBEFF0 Offset: 0x1CBD9F0 VA: 0x181CBEFF0
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	// RVA: 0x1CBC6C0 Offset: 0x1CBB0C0 VA: 0x181CBC6C0
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }
}
