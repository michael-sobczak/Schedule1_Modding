public abstract class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType> // TypeDefIndex: 6220
{
	// Fields
	internal List<TValueChoice> m_Choices; // 0x0
	private TextElement m_TextElement; // 0x0
	private VisualElement m_ArrowElement; // 0x0
	internal Func<TValueChoice, string> m_FormatSelectedValueCallback; // 0x0
	internal Func<TValueChoice, string> m_FormatListItemCallback; // 0x0
	internal Func<IGenericMenu> createMenuCallback; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string textUssClassName; // 0x0
	public static readonly string arrowUssClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0

	// Properties
	protected TextElement textElement { get; }
	public virtual List<TValueChoice> choices { set; }

	// Methods

	// RVA: -1 Offset: -1
	protected TextElement get_textElement() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416520 Offset: 0x1414F20 VA: 0x181416520
	|-BasePopupField<object, object>.get_textElement
	|
	|-RVA: 0xFF0CD0 Offset: 0xFEF6D0 VA: 0x180FF0CD0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_textElement
	*/

	// RVA: -1 Offset: -1 Slot: 119
	internal abstract string GetValueToDisplay();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueToDisplay
	*/

	// RVA: -1 Offset: -1 Slot: 120
	internal abstract string GetListItemToDisplay(TValueType item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetListItemToDisplay
	*/

	// RVA: -1 Offset: -1 Slot: 121
	internal abstract void AddMenuItems(IGenericMenu menu);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddMenuItems
	*/

	// RVA: -1 Offset: -1 Slot: 122
	public virtual void set_choices(List<TValueChoice> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1416530 Offset: 0x1414F30 VA: 0x181416530
	|-BasePopupField<object, object>.set_choices
	|
	|-RVA: 0x14165D0 Offset: 0x1414FD0 VA: 0x1814165D0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_choices
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public override void SetValueWithoutNotify(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414720 Offset: 0x1413120 VA: 0x181414720
	|-BasePopupField<object, object>.SetValueWithoutNotify
	|
	|-RVA: 0x14145C0 Offset: 0x1412FC0 VA: 0x1814145C0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(string label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415E60 Offset: 0x1414860 VA: 0x181415E60
	|-BasePopupField<object, object>..ctor
	|
	|-RVA: 0x1415690 Offset: 0x1414090 VA: 0x181415690
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void OnPointerDownEvent(PointerDownEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14142F0 Offset: 0x1412CF0 VA: 0x1814142F0
	|-BasePopupField<object, object>.OnPointerDownEvent
	|
	|-RVA: 0x1414310 Offset: 0x1412D10 VA: 0x181414310
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnPointerDownEvent
	*/

	// RVA: -1 Offset: -1
	private void OnPointerUpEvent(PointerUpEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14144F0 Offset: 0x1412EF0 VA: 0x1814144F0
	|-BasePopupField<object, object>.OnPointerUpEvent
	|
	|-RVA: 0x1414450 Offset: 0x1412E50 VA: 0x181414450
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnPointerUpEvent
	*/

	// RVA: -1 Offset: -1
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414330 Offset: 0x1412D30 VA: 0x181414330
	|-BasePopupField<object, object>.OnPointerMoveEvent
	|
	|-RVA: 0x14143C0 Offset: 0x1412DC0 VA: 0x1814143C0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnPointerMoveEvent
	*/

	// RVA: -1 Offset: -1
	private bool ContainsPointer(int pointerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414070 Offset: 0x1412A70 VA: 0x181414070
	|-BasePopupField<object, object>.ContainsPointer
	|
	|-RVA: 0x1413FE0 Offset: 0x14129E0 VA: 0x181413FE0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsPointer
	*/

	// RVA: -1 Offset: -1
	private void ProcessPointerDown<T>(PointerEventBase<T> evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC55A0 Offset: 0xDC3FA0 VA: 0x180DC55A0
	|-BasePopupField<object, object>.ProcessPointerDown<object>
	|
	|-RVA: 0xDC56C0 Offset: 0xDC40C0 VA: 0x180DC56C0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ProcessPointerDown<object>
	*/

	// RVA: -1 Offset: -1
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414140 Offset: 0x1412B40 VA: 0x181414140
	|-BasePopupField<object, object>.OnNavigationSubmit
	|
	|-RVA: 0x1414100 Offset: 0x1412B00 VA: 0x181414100
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnNavigationSubmit
	*/

	// RVA: -1 Offset: -1
	internal void ShowMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14149A0 Offset: 0x14133A0 VA: 0x1814149A0
	|-BasePopupField<object, object>.ShowMenu
	|
	|-RVA: 0x14147D0 Offset: 0x14131D0 VA: 0x1814147D0
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ShowMenu
	*/

	// RVA: -1 Offset: -1 Slot: 117
	protected override void UpdateMixedValueContent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414B20 Offset: 0x1413520 VA: 0x181414B20
	|-BasePopupField<object, object>.UpdateMixedValueContent
	|
	|-RVA: 0x1414C80 Offset: 0x1413680 VA: 0x181414C80
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UpdateMixedValueContent
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415270 Offset: 0x1413C70 VA: 0x181415270
	|-BasePopupField<object, object>..cctor
	|
	|-RVA: 0x1414E50 Offset: 0x1413850 VA: 0x181414E50
	|-BasePopupField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}
