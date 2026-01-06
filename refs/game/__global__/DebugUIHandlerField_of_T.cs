public abstract class DebugUIHandlerField<T> : DebugUIHandlerWidget // TypeDefIndex: 13956
{
	// Fields
	public Text nextButtonText; // 0x0
	public Text previousButtonText; // 0x0
	public Text nameLabel; // 0x0
	public Text valueLabel; // 0x0
	protected internal T m_Field; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E54F0 Offset: 0x14E3EF0 VA: 0x1814E54F0
	|-DebugUIHandlerField<object>.SetWidget
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5320 Offset: 0x14E3D20 VA: 0x1814E5320
	|-DebugUIHandlerField<object>.OnSelection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void OnDeselection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E51E0 Offset: 0x14E3BE0 VA: 0x1814E51E0
	|-DebugUIHandlerField<object>.OnDeselection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnAction() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E51B0 Offset: 0x14E3BB0 VA: 0x1814E51B0
	|-DebugUIHandlerField<object>.OnAction
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UpdateValueLabel();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DebugUIHandlerField<object>.UpdateValueLabel
	*/

	// RVA: -1 Offset: -1
	protected void SetLabelText(string text) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5460 Offset: 0x14E3E60 VA: 0x1814E5460
	|-DebugUIHandlerField<object>.SetLabelText
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E55A0 Offset: 0x14E3FA0 VA: 0x1814E55A0
	|-DebugUIHandlerField<object>..ctor
	*/
}
