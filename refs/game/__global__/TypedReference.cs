public struct TypedReference // TypeDefIndex: 3826
{
	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1CD01D0 Offset: 0x1CCEBD0 VA: 0x181CD01D0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x1CD01C0 Offset: 0x1CCEBC0 VA: 0x181CD01C0
	private static void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	// RVA: 0x1CD0130 Offset: 0x1CCEB30 VA: 0x181CD0130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CD00D0 Offset: 0x1CCEAD0 VA: 0x181CD00D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1CD07E0 Offset: 0x1CCF1E0 VA: 0x181CD07E0
	internal bool get_IsNull() { }

	[CLSCompliant(False)]
	// RVA: 0x1CD0790 Offset: 0x1CCF190 VA: 0x181CD0790
	public static void SetTypedReference(TypedReference target, object value) { }
}
