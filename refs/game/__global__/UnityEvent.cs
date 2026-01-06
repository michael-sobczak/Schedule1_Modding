public class UnityEvent : UnityEventBase // TypeDefIndex: 11965
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CEDE00 Offset: 0x2CEC800 VA: 0x182CEDE00
	public void .ctor() { }

	// RVA: 0x2CEDA50 Offset: 0x2CEC450 VA: 0x182CEDA50
	public void AddListener(UnityAction call) { }

	// RVA: 0x2CEDDB0 Offset: 0x2CEC7B0 VA: 0x182CEDDB0
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x2CEDAE0 Offset: 0x2CEC4E0 VA: 0x182CEDAE0 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2CEDB40 Offset: 0x2CEC540 VA: 0x182CEDB40 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x2CEDBB0 Offset: 0x2CEC5B0 VA: 0x182CEDBB0
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x2CEDC10 Offset: 0x2CEC610 VA: 0x182CEDC10
	public void Invoke() { }
}
