public abstract class PropertyInfo : MemberInfo // TypeDefIndex: 4720
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanWrite();

	// RVA: 0x1B8F1D0 Offset: 0x1B8DBD0 VA: 0x181B8F1D0 Slot: 20
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x1B7EDD0 Offset: 0x1B7D7D0 VA: 0x181B7EDD0 Slot: 21
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: 0x1B8F0E0 Offset: 0x1B8DAE0 VA: 0x181B8F0E0 Slot: 23
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B8F100 Offset: 0x1B8DB00 VA: 0x181B8F100
	public object GetValue(object obj) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B8F120 Offset: 0x1B8DB20 VA: 0x181B8F120 Slot: 25
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B8F160 Offset: 0x1B8DB60 VA: 0x181B8F160
	public void SetValue(object obj, object value) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B8F190 Offset: 0x1B8DB90 VA: 0x181B8F190 Slot: 27
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x1B893D0 Offset: 0x1B87DD0 VA: 0x181B893D0
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }
}
