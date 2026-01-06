internal abstract class RtFieldInfo : FieldInfo // TypeDefIndex: 4755
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract object UnsafeGetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract void CheckConsistency(object target);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
