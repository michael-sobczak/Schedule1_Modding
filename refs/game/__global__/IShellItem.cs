internal interface IShellItem // TypeDefIndex: 17333
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BindToHandler([In] IntPtr pbc, in Guid bhid, in Guid riid, out IntPtr ppv);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetParent(out IShellItem ppsi);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetDisplayName([In] NativeMethods.SIGDN sigdnName, out string ppszName);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetAttributes([In] uint sfgaoMask, out uint psfgaoAttribs);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Compare([In] IShellItem psi, [In] uint hint, out int piOrder);
}
