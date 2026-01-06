internal interface IShellItemArray // TypeDefIndex: 17334
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BindToHandler([In] IntPtr pbc, in Guid rbhid, in Guid riid, out IntPtr ppvOut);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetPropertyStore([In] int Flags, in Guid riid, out IntPtr ppv);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetPropertyDescriptionList(in NativeMethods.PROPERTYKEY keyType, in Guid riid, out IntPtr ppv);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetAttributes([In] NativeMethods.SIATTRIBFLAGS dwAttribFlags, [In] uint sfgaoMask, out uint psfgaoAttribs);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetCount(out uint pdwNumItems);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetItemAt([In] uint dwIndex, out IShellItem ppsi);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void EnumItems(out IntPtr ppenumShellItems);
}
