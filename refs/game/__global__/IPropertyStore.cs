internal interface IPropertyStore // TypeDefIndex: 17339
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetCount(out uint cProps);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetAt([In] uint iProp, out NativeMethods.PROPERTYKEY pkey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetValue(in NativeMethods.PROPERTYKEY key, out object pv);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetValue(in NativeMethods.PROPERTYKEY key, in object pv);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Commit();
}
