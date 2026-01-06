public abstract class TextValueField<TValueType> : TextInputBaseField<TValueType>, IValueField<TValueType> // TypeDefIndex: 6420
{
	// Fields
	private BaseFieldMouseDragger m_Dragger; // 0x0
	private bool m_ForceUpdateDisplay; // 0x0

	// Properties
	private TextValueField.TextValueInput<TValueType> textValueInput { get; }
	public string formatString { get; }
	public override TValueType value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	private TextValueField.TextValueInput<TValueType> get_textValueInput() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BB60 Offset: 0x126A560 VA: 0x18126BB60
	|-TextValueField<double>.get_textValueInput
	|-TextValueField<int>.get_textValueInput
	|-TextValueField<long>.get_textValueInput
	|-TextValueField<float>.get_textValueInput
	|-TextValueField<uint>.get_textValueInput
	|-TextValueField<ulong>.get_textValueInput
	|
	|-RVA: 0x126BBF0 Offset: 0x126A5F0 VA: 0x18126BBF0
	|-TextValueField<__Il2CppFullySharedGenericType>.get_textValueInput
	*/

	// RVA: -1 Offset: -1
	public string get_formatString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BA80 Offset: 0x126A480 VA: 0x18126BA80
	|-TextValueField<double>.get_formatString
	|-TextValueField<int>.get_formatString
	|-TextValueField<long>.get_formatString
	|-TextValueField<float>.get_formatString
	|-TextValueField<uint>.get_formatString
	|-TextValueField<ulong>.get_formatString
	|
	|-RVA: 0x126BB10 Offset: 0x126A510 VA: 0x18126BB10
	|-TextValueField<__Il2CppFullySharedGenericType>.get_formatString
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(string label, int maxLength, TextValueField.TextValueInput<TValueType> textValueInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126ADC0 Offset: 0x12697C0 VA: 0x18126ADC0
	|-TextValueField<double>..ctor
	|
	|-RVA: 0x126B8F0 Offset: 0x126A2F0 VA: 0x18126B8F0
	|-TextValueField<int>..ctor
	|
	|-RVA: 0x126B160 Offset: 0x1269B60 VA: 0x18126B160
	|-TextValueField<long>..ctor
	|
	|-RVA: 0x126B2F0 Offset: 0x1269CF0 VA: 0x18126B2F0
	|-TextValueField<float>..ctor
	|
	|-RVA: 0x126B6F0 Offset: 0x126A0F0 VA: 0x18126B6F0
	|-TextValueField<uint>..ctor
	|
	|-RVA: 0x126B4F0 Offset: 0x1269EF0 VA: 0x18126B4F0
	|-TextValueField<ulong>..ctor
	|
	|-RVA: 0x126AF50 Offset: 0x1269950 VA: 0x18126AF50
	|-TextValueField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 128
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextValueField<__Il2CppFullySharedGenericType>.ApplyInputDeviceDelta
	*/

	// RVA: -1 Offset: -1 Slot: 126
	public void StartDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1268DE0 Offset: 0x12677E0 VA: 0x181268DE0
	|-TextValueField<double>.StartDragging
	|
	|-RVA: 0x12688B0 Offset: 0x12672B0 VA: 0x1812688B0
	|-TextValueField<int>.StartDragging
	|
	|-RVA: 0x12689A0 Offset: 0x12673A0 VA: 0x1812689A0
	|-TextValueField<long>.StartDragging
	|
	|-RVA: 0x12687C0 Offset: 0x12671C0 VA: 0x1812687C0
	|-TextValueField<float>.StartDragging
	|
	|-RVA: 0x1268A90 Offset: 0x1267490 VA: 0x181268A90
	|-TextValueField<uint>.StartDragging
	|
	|-RVA: 0x1268CF0 Offset: 0x12676F0 VA: 0x181268CF0
	|-TextValueField<ulong>.StartDragging
	|
	|-RVA: 0x1268B80 Offset: 0x1267580 VA: 0x181268B80
	|-TextValueField<__Il2CppFullySharedGenericType>.StartDragging
	*/

	// RVA: -1 Offset: -1 Slot: 127
	public void StopDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12697B0 Offset: 0x12681B0 VA: 0x1812697B0
	|-TextValueField<double>.StopDragging
	|
	|-RVA: 0x1269610 Offset: 0x1268010 VA: 0x181269610
	|-TextValueField<int>.StopDragging
	|
	|-RVA: 0x1269470 Offset: 0x1267E70 VA: 0x181269470
	|-TextValueField<long>.StopDragging
	|
	|-RVA: 0x1269290 Offset: 0x1267C90 VA: 0x181269290
	|-TextValueField<float>.StopDragging
	|
	|-RVA: 0x12690B0 Offset: 0x1267AB0 VA: 0x1812690B0
	|-TextValueField<uint>.StopDragging
	|
	|-RVA: 0x1268ED0 Offset: 0x12678D0 VA: 0x181268ED0
	|-TextValueField<ulong>.StopDragging
	|
	|-RVA: 0x1269950 Offset: 0x1268350 VA: 0x181269950
	|-TextValueField<__Il2CppFullySharedGenericType>.StopDragging
	*/

	// RVA: -1 Offset: -1 Slot: 107
	public override TValueType get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BDE0 Offset: 0x126A7E0 VA: 0x18126BDE0
	|-TextValueField<double>.get_value
	|
	|-RVA: 0x126BCD0 Offset: 0x126A6D0 VA: 0x18126BCD0
	|-TextValueField<int>.get_value
	|-TextValueField<uint>.get_value
	|
	|-RVA: 0x126BCA0 Offset: 0x126A6A0 VA: 0x18126BCA0
	|-TextValueField<long>.get_value
	|-TextValueField<ulong>.get_value
	|
	|-RVA: 0x126BD00 Offset: 0x126A700 VA: 0x18126BD00
	|-TextValueField<float>.get_value
	|
	|-RVA: 0x126BD30 Offset: 0x126A730 VA: 0x18126BD30
	|-TextValueField<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 108
	public override void set_value(TValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126BF00 Offset: 0x126A900 VA: 0x18126BF00
	|-TextValueField<double>.set_value
	|
	|-RVA: 0x126BF60 Offset: 0x126A960 VA: 0x18126BF60
	|-TextValueField<int>.set_value
	|
	|-RVA: 0x126BFC0 Offset: 0x126A9C0 VA: 0x18126BFC0
	|-TextValueField<long>.set_value
	|
	|-RVA: 0x126BF90 Offset: 0x126A990 VA: 0x18126BF90
	|-TextValueField<float>.set_value
	|
	|-RVA: 0x126BFF0 Offset: 0x126A9F0 VA: 0x18126BFF0
	|-TextValueField<uint>.set_value
	|
	|-RVA: 0x126BF30 Offset: 0x126A930 VA: 0x18126BF30
	|-TextValueField<ulong>.set_value
	|
	|-RVA: 0x126BE10 Offset: 0x126A810 VA: 0x18126BE10
	|-TextValueField<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1 Slot: 121
	internal override void UpdateValueFromText() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126AA70 Offset: 0x1269470 VA: 0x18126AA70
	|-TextValueField<double>.UpdateValueFromText
	|
	|-RVA: 0x126AB40 Offset: 0x1269540 VA: 0x18126AB40
	|-TextValueField<int>.UpdateValueFromText
	|
	|-RVA: 0x126A9A0 Offset: 0x12693A0 VA: 0x18126A9A0
	|-TextValueField<long>.UpdateValueFromText
	|
	|-RVA: 0x126A8B0 Offset: 0x12692B0 VA: 0x18126A8B0
	|-TextValueField<float>.UpdateValueFromText
	|
	|-RVA: 0x126A6D0 Offset: 0x12690D0 VA: 0x18126A6D0
	|-TextValueField<uint>.UpdateValueFromText
	|
	|-RVA: 0x126A7C0 Offset: 0x12691C0 VA: 0x18126A7C0
	|-TextValueField<ulong>.UpdateValueFromText
	|
	|-RVA: 0x126AC10 Offset: 0x1269610 VA: 0x18126AC10
	|-TextValueField<__Il2CppFullySharedGenericType>.UpdateValueFromText
	*/

	// RVA: -1 Offset: -1 Slot: 122
	internal override void UpdateTextFromValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126A3A0 Offset: 0x1268DA0 VA: 0x18126A3A0
	|-TextValueField<double>.UpdateTextFromValue
	|
	|-RVA: 0x126A330 Offset: 0x1268D30 VA: 0x18126A330
	|-TextValueField<int>.UpdateTextFromValue
	|
	|-RVA: 0x126A660 Offset: 0x1269060 VA: 0x18126A660
	|-TextValueField<long>.UpdateTextFromValue
	|
	|-RVA: 0x126A2A0 Offset: 0x1268CA0 VA: 0x18126A2A0
	|-TextValueField<float>.UpdateTextFromValue
	|
	|-RVA: 0x126A5D0 Offset: 0x1268FD0 VA: 0x18126A5D0
	|-TextValueField<uint>.UpdateTextFromValue
	|
	|-RVA: 0x126A540 Offset: 0x1268F40 VA: 0x18126A540
	|-TextValueField<ulong>.UpdateTextFromValue
	|
	|-RVA: 0x126A410 Offset: 0x1268E10 VA: 0x18126A410
	|-TextValueField<__Il2CppFullySharedGenericType>.UpdateTextFromValue
	*/

	// RVA: -1 Offset: -1
	private void OnIsReadOnlyChanged(bool newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266A80 Offset: 0x1265480 VA: 0x181266A80
	|-TextValueField<double>.OnIsReadOnlyChanged
	|-TextValueField<int>.OnIsReadOnlyChanged
	|-TextValueField<long>.OnIsReadOnlyChanged
	|-TextValueField<float>.OnIsReadOnlyChanged
	|-TextValueField<uint>.OnIsReadOnlyChanged
	|-TextValueField<ulong>.OnIsReadOnlyChanged
	|
	|-RVA: 0x1266B70 Offset: 0x1265570 VA: 0x181266B70
	|-TextValueField<__Il2CppFullySharedGenericType>.OnIsReadOnlyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 129
	internal virtual bool CanTryParse(string textString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-TextValueField<double>.CanTryParse
	|-TextValueField<int>.CanTryParse
	|-TextValueField<long>.CanTryParse
	|-TextValueField<float>.CanTryParse
	|-TextValueField<uint>.CanTryParse
	|-TextValueField<ulong>.CanTryParse
	|-TextValueField<__Il2CppFullySharedGenericType>.CanTryParse
	*/

	// RVA: -1 Offset: -1
	protected void AddLabelDragger<TDraggerType>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCD0C0 Offset: 0xDCBAC0 VA: 0x180DCD0C0
	|-TextValueField<double>.AddLabelDragger<double>
	|
	|-RVA: 0xDCD320 Offset: 0xDCBD20 VA: 0x180DCD320
	|-TextValueField<int>.AddLabelDragger<int>
	|
	|-RVA: 0xDCD430 Offset: 0xDCBE30 VA: 0x180DCD430
	|-TextValueField<long>.AddLabelDragger<long>
	|
	|-RVA: 0xDCD540 Offset: 0xDCBF40 VA: 0x180DCD540
	|-TextValueField<float>.AddLabelDragger<float>
	|
	|-RVA: 0xDCD650 Offset: 0xDCC050 VA: 0x180DCD650
	|-TextValueField<uint>.AddLabelDragger<uint>
	|
	|-RVA: 0xDCD760 Offset: 0xDCC160 VA: 0x180DCD760
	|-TextValueField<ulong>.AddLabelDragger<ulong>
	|
	|-RVA: 0xDCD1D0 Offset: 0xDCBBD0 VA: 0x180DCD1D0
	|-TextValueField<__Il2CppFullySharedGenericType>.AddLabelDragger<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void EnableLabelDragger(bool enable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1265760 Offset: 0x1264160 VA: 0x181265760
	|-TextValueField<double>.EnableLabelDragger
	|-TextValueField<int>.EnableLabelDragger
	|-TextValueField<long>.EnableLabelDragger
	|-TextValueField<float>.EnableLabelDragger
	|-TextValueField<uint>.EnableLabelDragger
	|-TextValueField<ulong>.EnableLabelDragger
	|
	|-RVA: 0x1265840 Offset: 0x1264240 VA: 0x181265840
	|-TextValueField<__Il2CppFullySharedGenericType>.EnableLabelDragger
	*/

	// RVA: -1 Offset: -1 Slot: 118
	public override void SetValueWithoutNotify(TValueType newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12680A0 Offset: 0x1266AA0 VA: 0x1812680A0
	|-TextValueField<double>.SetValueWithoutNotify
	|
	|-RVA: 0x1268560 Offset: 0x1266F60 VA: 0x181268560
	|-TextValueField<int>.SetValueWithoutNotify
	|
	|-RVA: 0x1268300 Offset: 0x1266D00 VA: 0x181268300
	|-TextValueField<long>.SetValueWithoutNotify
	|
	|-RVA: 0x1267E40 Offset: 0x1266840 VA: 0x181267E40
	|-TextValueField<float>.SetValueWithoutNotify
	|
	|-RVA: 0x1267BE0 Offset: 0x12665E0 VA: 0x181267BE0
	|-TextValueField<uint>.SetValueWithoutNotify
	|
	|-RVA: 0x1267970 Offset: 0x1266370 VA: 0x181267970
	|-TextValueField<ulong>.SetValueWithoutNotify
	|
	|-RVA: 0x12675E0 Offset: 0x1265FE0 VA: 0x1812675E0
	|-TextValueField<__Il2CppFullySharedGenericType>.SetValueWithoutNotify
	*/

	[EventInterest(new[] { typeof(BlurEvent), typeof(FocusEvent) })]
	// RVA: -1 Offset: -1 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12660B0 Offset: 0x1264AB0 VA: 0x1812660B0
	|-TextValueField<double>.ExecuteDefaultAction
	|
	|-RVA: 0x1265E70 Offset: 0x1264870 VA: 0x181265E70
	|-TextValueField<int>.ExecuteDefaultAction
	|
	|-RVA: 0x1266550 Offset: 0x1264F50 VA: 0x181266550
	|-TextValueField<long>.ExecuteDefaultAction
	|
	|-RVA: 0x1265C10 Offset: 0x1264610 VA: 0x181265C10
	|-TextValueField<float>.ExecuteDefaultAction
	|
	|-RVA: 0x12659B0 Offset: 0x12643B0 VA: 0x1812659B0
	|-TextValueField<uint>.ExecuteDefaultAction
	|
	|-RVA: 0x12662F0 Offset: 0x1264CF0 VA: 0x1812662F0
	|-TextValueField<ulong>.ExecuteDefaultAction
	|
	|-RVA: 0x1266790 Offset: 0x1265190 VA: 0x181266790
	|-TextValueField<__Il2CppFullySharedGenericType>.ExecuteDefaultAction
	*/

	// RVA: -1 Offset: -1 Slot: 96
	internal override void OnViewDataReady() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266C10 Offset: 0x1265610 VA: 0x181266C10
	|-TextValueField<double>.OnViewDataReady
	|
	|-RVA: 0x1266B90 Offset: 0x1265590 VA: 0x181266B90
	|-TextValueField<int>.OnViewDataReady
	|
	|-RVA: 0x1266BD0 Offset: 0x12655D0 VA: 0x181266BD0
	|-TextValueField<long>.OnViewDataReady
	|
	|-RVA: 0x1266CC0 Offset: 0x12656C0 VA: 0x181266CC0
	|-TextValueField<float>.OnViewDataReady
	|
	|-RVA: 0x1266BB0 Offset: 0x12655B0 VA: 0x181266BB0
	|-TextValueField<uint>.OnViewDataReady
	|
	|-RVA: 0x1266BF0 Offset: 0x12655F0 VA: 0x181266BF0
	|-TextValueField<ulong>.OnViewDataReady
	|
	|-RVA: 0x1266C30 Offset: 0x1265630 VA: 0x181266C30
	|-TextValueField<__Il2CppFullySharedGenericType>.OnViewDataReady
	*/

	// RVA: -1 Offset: -1 Slot: 115
	internal override void RegisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1266CE0 Offset: 0x12656E0 VA: 0x181266CE0
	|-TextValueField<double>.RegisterEditingCallbacks
	|
	|-RVA: 0x12674A0 Offset: 0x1265EA0 VA: 0x1812674A0
	|-TextValueField<int>.RegisterEditingCallbacks
	|
	|-RVA: 0x1266E20 Offset: 0x1265820 VA: 0x181266E20
	|-TextValueField<long>.RegisterEditingCallbacks
	|
	|-RVA: 0x1266F60 Offset: 0x1265960 VA: 0x181266F60
	|-TextValueField<float>.RegisterEditingCallbacks
	|
	|-RVA: 0x12670A0 Offset: 0x1265AA0 VA: 0x1812670A0
	|-TextValueField<uint>.RegisterEditingCallbacks
	|
	|-RVA: 0x1267360 Offset: 0x1265D60 VA: 0x181267360
	|-TextValueField<ulong>.RegisterEditingCallbacks
	|
	|-RVA: 0x12671E0 Offset: 0x1265BE0 VA: 0x1812671E0
	|-TextValueField<__Il2CppFullySharedGenericType>.RegisterEditingCallbacks
	*/

	// RVA: -1 Offset: -1 Slot: 116
	internal override void UnregisterEditingCallbacks() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1269AE0 Offset: 0x12684E0 VA: 0x181269AE0
	|-TextValueField<double>.UnregisterEditingCallbacks
	|
	|-RVA: 0x126A020 Offset: 0x1268A20 VA: 0x18126A020
	|-TextValueField<int>.UnregisterEditingCallbacks
	|
	|-RVA: 0x126A160 Offset: 0x1268B60 VA: 0x18126A160
	|-TextValueField<long>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1269C20 Offset: 0x1268620 VA: 0x181269C20
	|-TextValueField<float>.UnregisterEditingCallbacks
	|
	|-RVA: 0x12699A0 Offset: 0x12683A0 VA: 0x1812699A0
	|-TextValueField<uint>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1269D60 Offset: 0x1268760 VA: 0x181269D60
	|-TextValueField<ulong>.UnregisterEditingCallbacks
	|
	|-RVA: 0x1269EA0 Offset: 0x12688A0 VA: 0x181269EA0
	|-TextValueField<__Il2CppFullySharedGenericType>.UnregisterEditingCallbacks
	*/
}
