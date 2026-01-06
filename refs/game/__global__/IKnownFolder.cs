internal interface IKnownFolder // TypeDefIndex: 17335
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetId(out Guid pkfid);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void spacer1();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetShellItem([In] uint dwFlags, ref Guid riid, out IShellItem ppv);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetPath([In] uint dwFlags, out string ppszPath);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetPath([In] uint dwFlags, [In] string pszPath);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetLocation([In] uint dwFlags, [Out] IntPtr ppidl);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetFolderType(out Guid pftid);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GetRedirectionCapabilities(out uint pCapabilities);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void spacer2();
}
