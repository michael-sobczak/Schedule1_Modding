internal interface IFileDialogCustomize // TypeDefIndex: 17337
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EnableOpenDropDown([In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddMenu([In] int dwIDCtl, [In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddPushButton([In] int dwIDCtl, [In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddComboBox([In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddRadioButtonList([In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddCheckButton([In] int dwIDCtl, [In] string pszLabel, [In] bool bChecked);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddEditBox([In] int dwIDCtl, [In] string pszText);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AddSeparator([In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void AddText([In] int dwIDCtl, [In] string pszText);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetControlLabel([In] int dwIDCtl, [In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void GetControlState([In] int dwIDCtl, out NativeMethods.CDCONTROLSTATE pdwState);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetControlState([In] int dwIDCtl, [In] NativeMethods.CDCONTROLSTATE dwState);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void GetEditBoxText([In] int dwIDCtl, [Out] IntPtr ppszText);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SetEditBoxText([In] int dwIDCtl, [In] string pszText);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void GetCheckButtonState([In] int dwIDCtl, out bool pbChecked);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetCheckButtonState([In] int dwIDCtl, [In] bool bChecked);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void AddControlItem([In] int dwIDCtl, [In] int dwIDItem, [In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void RemoveControlItem([In] int dwIDCtl, [In] int dwIDItem);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void RemoveAllControlItems([In] int dwIDCtl);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void GetControlItemState([In] int dwIDCtl, [In] int dwIDItem, out NativeMethods.CDCONTROLSTATE pdwState);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetControlItemState([In] int dwIDCtl, [In] int dwIDItem, [In] NativeMethods.CDCONTROLSTATE dwState);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void GetSelectedControlItem([In] int dwIDCtl, out int pdwIDItem);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void SetSelectedControlItem([In] int dwIDCtl, [In] int dwIDItem);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void StartVisualGroup([In] int dwIDCtl, [In] string pszLabel);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void EndVisualGroup();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void MakeProminent([In] int dwIDCtl);
}
