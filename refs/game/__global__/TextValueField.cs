protected abstract class TextValueField.TextValueInput<TValueType> : TextInputBaseField.TextInputBase<TValueType> // TypeDefIndex: 6419
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <formatString>k__BackingField; // 0x0

	// Properties
	private TextValueField<TValueType> textValueFieldParent { get; }
	protected abstract string allowedCharacters { get; }
	public string formatString { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	private TextValueField<TValueType> get_textValueFieldParent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D650 Offset: 0x126C050 VA: 0x18126D650
	|-TextValueField.TextValueInput<double>.get_textValueFieldParent
	|-TextValueField.TextValueInput<int>.get_textValueFieldParent
	|-TextValueField.TextValueInput<long>.get_textValueFieldParent
	|-TextValueField.TextValueInput<float>.get_textValueFieldParent
	|-TextValueField.TextValueInput<uint>.get_textValueFieldParent
	|-TextValueField.TextValueInput<ulong>.get_textValueFieldParent
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.get_textValueFieldParent
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D440 Offset: 0x126BE40 VA: 0x18126D440
	|-TextValueField.TextValueInput<double>..ctor
	|
	|-RVA: 0x126D540 Offset: 0x126BF40 VA: 0x18126D540
	|-TextValueField.TextValueInput<int>..ctor
	|
	|-RVA: 0x126D140 Offset: 0x126BB40 VA: 0x18126D140
	|-TextValueField.TextValueInput<long>..ctor
	|
	|-RVA: 0x126D040 Offset: 0x126BA40 VA: 0x18126D040
	|-TextValueField.TextValueInput<float>..ctor
	|
	|-RVA: 0x126D240 Offset: 0x126BC40 VA: 0x18126D240
	|-TextValueField.TextValueInput<uint>..ctor
	|
	|-RVA: 0x126CF40 Offset: 0x126B940 VA: 0x18126CF40
	|-TextValueField.TextValueInput<ulong>..ctor
	|
	|-RVA: 0x126D340 Offset: 0x126BD40 VA: 0x18126D340
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 103
	internal override bool AcceptCharacter(char c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126C260 Offset: 0x126AC60 VA: 0x18126C260
	|-TextValueField.TextValueInput<double>.AcceptCharacter
	|
	|-RVA: 0x126C1D0 Offset: 0x126ABD0 VA: 0x18126C1D0
	|-TextValueField.TextValueInput<int>.AcceptCharacter
	|
	|-RVA: 0x126C2F0 Offset: 0x126ACF0 VA: 0x18126C2F0
	|-TextValueField.TextValueInput<long>.AcceptCharacter
	|
	|-RVA: 0x126C140 Offset: 0x126AB40 VA: 0x18126C140
	|-TextValueField.TextValueInput<float>.AcceptCharacter
	|
	|-RVA: 0x126C0B0 Offset: 0x126AAB0 VA: 0x18126C0B0
	|-TextValueField.TextValueInput<uint>.AcceptCharacter
	|
	|-RVA: 0x126C020 Offset: 0x126AA20 VA: 0x18126C020
	|-TextValueField.TextValueInput<ulong>.AcceptCharacter
	|
	|-RVA: 0x126C380 Offset: 0x126AD80 VA: 0x18126C380
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.AcceptCharacter
	*/

	// RVA: -1 Offset: -1 Slot: 104
	protected abstract string get_allowedCharacters();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.get_allowedCharacters
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public string get_formatString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D640 Offset: 0x126C040 VA: 0x18126D640
	|-TextValueField.TextValueInput<double>.get_formatString
	|-TextValueField.TextValueInput<int>.get_formatString
	|-TextValueField.TextValueInput<long>.get_formatString
	|-TextValueField.TextValueInput<float>.get_formatString
	|-TextValueField.TextValueInput<uint>.get_formatString
	|-TextValueField.TextValueInput<ulong>.get_formatString
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.get_formatString
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_formatString(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126D6F0 Offset: 0x126C0F0 VA: 0x18126D6F0
	|-TextValueField.TextValueInput<double>.set_formatString
	|-TextValueField.TextValueInput<int>.set_formatString
	|-TextValueField.TextValueInput<long>.set_formatString
	|-TextValueField.TextValueInput<float>.set_formatString
	|-TextValueField.TextValueInput<uint>.set_formatString
	|-TextValueField.TextValueInput<ulong>.set_formatString
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.set_formatString
	*/

	// RVA: -1 Offset: -1 Slot: 105
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.ApplyInputDeviceDelta
	*/

	// RVA: -1 Offset: -1
	public void StartDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126C4F0 Offset: 0x126AEF0 VA: 0x18126C4F0
	|-TextValueField.TextValueInput<double>.StartDragging
	|
	|-RVA: 0x126C470 Offset: 0x126AE70 VA: 0x18126C470
	|-TextValueField.TextValueInput<int>.StartDragging
	|
	|-RVA: 0x126C5B0 Offset: 0x126AFB0 VA: 0x18126C5B0
	|-TextValueField.TextValueInput<long>.StartDragging
	|
	|-RVA: 0x126C4B0 Offset: 0x126AEB0 VA: 0x18126C4B0
	|-TextValueField.TextValueInput<float>.StartDragging
	|
	|-RVA: 0x126C530 Offset: 0x126AF30 VA: 0x18126C530
	|-TextValueField.TextValueInput<uint>.StartDragging
	|
	|-RVA: 0x126C570 Offset: 0x126AF70 VA: 0x18126C570
	|-TextValueField.TextValueInput<ulong>.StartDragging
	|
	|-RVA: 0x126C410 Offset: 0x126AE10 VA: 0x18126C410
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.StartDragging
	*/

	// RVA: -1 Offset: -1
	public void StopDragging() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126C5F0 Offset: 0x126AFF0 VA: 0x18126C5F0
	|-TextValueField.TextValueInput<double>.StopDragging
	|
	|-RVA: 0x126CCF0 Offset: 0x126B6F0 VA: 0x18126CCF0
	|-TextValueField.TextValueInput<int>.StopDragging
	|
	|-RVA: 0x126CA80 Offset: 0x126B480 VA: 0x18126CA80
	|-TextValueField.TextValueInput<long>.StopDragging
	|
	|-RVA: 0x126CB90 Offset: 0x126B590 VA: 0x18126CB90
	|-TextValueField.TextValueInput<float>.StopDragging
	|
	|-RVA: 0x126C860 Offset: 0x126B260 VA: 0x18126C860
	|-TextValueField.TextValueInput<uint>.StopDragging
	|
	|-RVA: 0x126C700 Offset: 0x126B100 VA: 0x18126C700
	|-TextValueField.TextValueInput<ulong>.StopDragging
	|
	|-RVA: 0x126C9C0 Offset: 0x126B3C0 VA: 0x18126C9C0
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.StopDragging
	*/

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract string ValueToString(TValueType value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.ValueToString
	*/

	// RVA: -1 Offset: -1 Slot: 100
	protected override TValueType StringToValue(string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126CE00 Offset: 0x126B800 VA: 0x18126CE00
	|-TextValueField.TextValueInput<double>.StringToValue
	|-TextValueField.TextValueInput<int>.StringToValue
	|-TextValueField.TextValueInput<long>.StringToValue
	|-TextValueField.TextValueInput<float>.StringToValue
	|-TextValueField.TextValueInput<uint>.StringToValue
	|-TextValueField.TextValueInput<ulong>.StringToValue
	|
	|-RVA: 0x126CE30 Offset: 0x126B830 VA: 0x18126CE30
	|-TextValueField.TextValueInput<__Il2CppFullySharedGenericType>.StringToValue
	*/
}
