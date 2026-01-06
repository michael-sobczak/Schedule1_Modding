public abstract class ConstructorInfo : MethodBase // TypeDefIndex: 4690
{
	// Fields
	public static readonly string ConstructorName; // 0x0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B85620 Offset: 0x1B84020 VA: 0x181B85620
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x1B85740 Offset: 0x1B84140 VA: 0x181B85740
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x1B85660 Offset: 0x1B84060 VA: 0x181B85660
	private static void .cctor() { }
}
