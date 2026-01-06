internal interface IKnownFolderManager // TypeDefIndex: 17336
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void FolderIdFromCsidl([In] int nCsidl, out Guid pfid);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FolderIdToCsidl(in Guid rfid, out int pnCsidl);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetFolderIds([Out] IntPtr ppKFId, ref uint pCount);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetFolder(in Guid rfid, out IKnownFolder ppkf);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void GetFolderByName([In] string pszCanonicalName, out IKnownFolder ppkf);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterFolder(in Guid rfid, in NativeMethods.KNOWNFOLDER_DEFINITION pKFD);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterFolder(in Guid rfid);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void FindFolderFromPath([In] string pszPath, [In] NativeMethods.FFFP_MODE mode, out IKnownFolder ppkf);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FindFolderFromIDList([In] IntPtr pidl, out IKnownFolder ppkf);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Redirect(in Guid rfid, [In] IntPtr hwnd, [In] uint Flags, [In] string pszTargetPath, [In] uint cFolders, in Guid pExclusion, out string ppszError);
}
