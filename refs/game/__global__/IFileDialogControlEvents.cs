internal interface IFileDialogControlEvents // TypeDefIndex: 17338
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnItemSelected([In] IFileDialogCustomize pfdc, [In] int dwIDCtl, [In] int dwIDItem);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnButtonClicked([In] IFileDialogCustomize pfdc, [In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCheckButtonToggled([In] IFileDialogCustomize pfdc, [In] int dwIDCtl, [In] bool bChecked);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnControlActivating([In] IFileDialogCustomize pfdc, [In] int dwIDCtl);
}
