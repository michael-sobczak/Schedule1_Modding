public class PopupField<T> : BasePopupField<T, T> // TypeDefIndex: 6382
{
	// Fields
	private int m_Index; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0

	// Properties
	public override T value { get; set; }
	public int index { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 119
	internal override string GetValueToDisplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FCAD0 Offset: 0x10FB4D0 VA: 0x1810FCAD0
	|-PopupField<object>.GetValueToDisplay
	|
	|-RVA: 0x10FC7E0 Offset: 0x10FB1E0 VA: 0x1810FC7E0
	|-PopupField<__Il2CppFullySharedGenericType>.GetValueToDisplay
	*/

	// RVA: -1 Offset: -1 Slot: 120
	internal override string GetListItemToDisplay(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FC3E0 Offset: 0x10FADE0 VA: 0x1810FC3E0
	|-PopupField<object>.GetListItemToDisplay
	|
	|-RVA: 0x10FC4D0 Offset: 0x10FAED0 VA: 0x1810FC4D0
	|-PopupField<__Il2CppFullySharedGenericType>.GetListItemToDisplay
	*/

	// RVA: -1 Offset: -1 Slot: 107
	public override T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD7E0 Offset: 0x10FC1E0 VA: 0x1810FD7E0
	|-PopupField<object>.get_value
	|
	|-RVA: 0x10FD6E0 Offset: 0x10FC0E0 VA: 0x1810FD6E0
	|-PopupField<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 108
	public override void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FDD00 Offset: 0x10FC700 VA: 0x1810FDD00
	|-PopupField<object>.set_value
	|
	|-RVA: 0x10FDB30 Offset: 0x10FC530 VA: 0x1810FDB30
	|-PopupField<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public override void SetValueWithoutNotify(T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FCDB0 Offset: 0x10FB7B0 VA: 0x1810FCDB0
	|-PopupField<object>.SetValueWithoutNotify
	|
	|-RVA: 0x10FCBE0 Offset: 0x10FB5E0 VA: 0x1810FCBE0
	|-PopupField<__Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	// RVA: -1 Offset: -1
	public void set_index(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FDAA0 Offset: 0x10FC4A0 VA: 0x1810FDAA0
	|-PopupField<object>.set_index
	|
	|-RVA: 0x10FD810 Offset: 0x10FC210 VA: 0x1810FD810
	|-PopupField<__Il2CppFullySharedGenericType>.set_index
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD340 Offset: 0x10FBD40 VA: 0x1810FD340
	|-PopupField<object>..ctor
	|
	|-RVA: 0x10FD4E0 Offset: 0x10FBEE0 VA: 0x1810FD4E0
	|-PopupField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 121
	internal override void AddMenuItems(IGenericMenu menu) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FBEC0 Offset: 0x10FA8C0 VA: 0x1810FBEC0
	|-PopupField<object>.AddMenuItems
	|
	|-RVA: 0x10FB8A0 Offset: 0x10FA2A0 VA: 0x1810FB8A0
	|-PopupField<__Il2CppFullySharedGenericType>.AddMenuItems
	*/

	// RVA: -1 Offset: -1
	private void ChangeValueFromMenu(T menuItem) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FC3B0 Offset: 0x10FADB0 VA: 0x1810FC3B0
	|-PopupField<object>.ChangeValueFromMenu
	|
	|-RVA: 0x10FC2D0 Offset: 0x10FACD0 VA: 0x1810FC2D0
	|-PopupField<__Il2CppFullySharedGenericType>.ChangeValueFromMenu
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FD0B0 Offset: 0x10FBAB0 VA: 0x1810FD0B0
	|-PopupField<object>..cctor
	|
	|-RVA: 0x10FCE20 Offset: 0x10FB820 VA: 0x1810FCE20
	|-PopupField<__Il2CppFullySharedGenericType>..cctor
	*/
}
