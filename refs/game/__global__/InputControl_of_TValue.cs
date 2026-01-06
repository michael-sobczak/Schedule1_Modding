public abstract class InputControl<TValue> : InputControl // TypeDefIndex: 7345
{
	// Fields
	internal InlinedArray<InputProcessor<TValue>> m_ProcessorStack; // 0x0
	private TValue m_CachedValue; // 0x0
	private TValue m_UnprocessedCachedValue; // 0x0
	internal bool evaluateProcessorsEveryRead; // 0x0

	// Properties
	public override Type valueType { get; }
	public override int valueSizeInBytes { get; }
	[IsReadOnly]
	public TValue value { get; }
	[IsReadOnly]
	internal TValue unprocessedValue { get; }
	internal InputProcessor<TValue>[] processors { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Type get_valueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18756F0 Offset: 0x18740F0 VA: 0x1818756F0
	|-InputControl<Bone>.get_valueType
	|
	|-RVA: 0x18755D0 Offset: 0x1873FD0 VA: 0x1818755D0
	|-InputControl<bool>.get_valueType
	|
	|-RVA: 0x1875630 Offset: 0x1874030 VA: 0x181875630
	|-InputControl<double>.get_valueType
	|
	|-RVA: 0x1875690 Offset: 0x1874090 VA: 0x181875690
	|-InputControl<Eyes>.get_valueType
	|
	|-RVA: 0x1881960 Offset: 0x1880360 VA: 0x181881960
	|-InputControl<int>.get_valueType
	|
	|-RVA: 0x1881A20 Offset: 0x1880420 VA: 0x181881A20
	|-InputControl<Int32Enum>.get_valueType
	|
	|-RVA: 0x18819C0 Offset: 0x18803C0 VA: 0x1818819C0
	|-InputControl<PoseState>.get_valueType
	|
	|-RVA: 0x1881900 Offset: 0x1880300 VA: 0x181881900
	|-InputControl<Quaternion>.get_valueType
	|
	|-RVA: 0x1881780 Offset: 0x1880180 VA: 0x181881780
	|-InputControl<float>.get_valueType
	|
	|-RVA: 0x18818A0 Offset: 0x18802A0 VA: 0x1818818A0
	|-InputControl<TouchState>.get_valueType
	|
	|-RVA: 0x18816C0 Offset: 0x18800C0 VA: 0x1818816C0
	|-InputControl<uint>.get_valueType
	|
	|-RVA: 0x18817E0 Offset: 0x18801E0 VA: 0x1818817E0
	|-InputControl<Vector2>.get_valueType
	|
	|-RVA: 0x1881840 Offset: 0x1880240 VA: 0x181881840
	|-InputControl<Vector3>.get_valueType
	|
	|-RVA: 0x1881720 Offset: 0x1880120 VA: 0x181881720
	|-InputControl<__Il2CppFullySharedGenericStructType>.get_valueType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override int get_valueSizeInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF72870 Offset: 0xF71270 VA: 0x180F72870
	|-InputControl<Bone>.get_valueSizeInBytes
	|
	|-RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	|-InputControl<bool>.get_valueSizeInBytes
	|
	|-RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790
	|-InputControl<double>.get_valueSizeInBytes
	|-InputControl<Vector2>.get_valueSizeInBytes
	|
	|-RVA: 0xF729A0 Offset: 0xF713A0 VA: 0x180F729A0
	|-InputControl<Eyes>.get_valueSizeInBytes
	|
	|-RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160
	|-InputControl<int>.get_valueSizeInBytes
	|-InputControl<Int32Enum>.get_valueSizeInBytes
	|-InputControl<float>.get_valueSizeInBytes
	|-InputControl<uint>.get_valueSizeInBytes
	|
	|-RVA: 0xF72A80 Offset: 0xF71480 VA: 0x180F72A80
	|-InputControl<PoseState>.get_valueSizeInBytes
	|
	|-RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420
	|-InputControl<Quaternion>.get_valueSizeInBytes
	|
	|-RVA: 0xF728E0 Offset: 0xF712E0 VA: 0x180F728E0
	|-InputControl<TouchState>.get_valueSizeInBytes
	|
	|-RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0
	|-InputControl<Vector3>.get_valueSizeInBytes
	|
	|-RVA: 0x186DE50 Offset: 0x186C850 VA: 0x18186DE50
	|-InputControl<__Il2CppFullySharedGenericStructType>.get_valueSizeInBytes
	*/

	// RVA: -1 Offset: -1
	public ref TValue get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1875940 Offset: 0x1874340 VA: 0x181875940
	|-InputControl<Bone>.get_value
	|
	|-RVA: 0x1875850 Offset: 0x1874250 VA: 0x181875850
	|-InputControl<bool>.get_value
	|
	|-RVA: 0x1875750 Offset: 0x1874150 VA: 0x181875750
	|-InputControl<double>.get_value
	|
	|-RVA: 0x1875A50 Offset: 0x1874450 VA: 0x181875A50
	|-InputControl<Eyes>.get_value
	|
	|-RVA: 0x1881EC0 Offset: 0x18808C0 VA: 0x181881EC0
	|-InputControl<int>.get_value
	|
	|-RVA: 0x1881A80 Offset: 0x1880480 VA: 0x181881A80
	|-InputControl<Int32Enum>.get_value
	|
	|-RVA: 0x1881D70 Offset: 0x1880770 VA: 0x181881D70
	|-InputControl<PoseState>.get_value
	|
	|-RVA: 0x1881C80 Offset: 0x1880680 VA: 0x181881C80
	|-InputControl<Quaternion>.get_value
	|
	|-RVA: 0x18824C0 Offset: 0x1880EC0 VA: 0x1818824C0
	|-InputControl<float>.get_value
	|
	|-RVA: 0x18820A0 Offset: 0x1880AA0 VA: 0x1818820A0
	|-InputControl<TouchState>.get_value
	|
	|-RVA: 0x1881FB0 Offset: 0x18809B0 VA: 0x181881FB0
	|-InputControl<uint>.get_value
	|
	|-RVA: 0x1881B70 Offset: 0x1880570 VA: 0x181881B70
	|-InputControl<Vector2>.get_value
	|
	|-RVA: 0x18821E0 Offset: 0x1880BE0 VA: 0x1818821E0
	|-InputControl<Vector3>.get_value
	|
	|-RVA: 0x18822F0 Offset: 0x1880CF0 VA: 0x1818822F0
	|-InputControl<__Il2CppFullySharedGenericStructType>.get_value
	*/

	// RVA: -1 Offset: -1
	internal ref TValue get_unprocessedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1875350 Offset: 0x1873D50 VA: 0x181875350
	|-InputControl<Bone>.get_unprocessedValue
	|
	|-RVA: 0x1875430 Offset: 0x1873E30 VA: 0x181875430
	|-InputControl<bool>.get_unprocessedValue
	|
	|-RVA: 0x1875500 Offset: 0x1873F00 VA: 0x181875500
	|-InputControl<double>.get_unprocessedValue
	|
	|-RVA: 0x1875240 Offset: 0x1873C40 VA: 0x181875240
	|-InputControl<Eyes>.get_unprocessedValue
	|
	|-RVA: 0x1880F40 Offset: 0x187F940 VA: 0x181880F40
	|-InputControl<int>.get_unprocessedValue
	|
	|-RVA: 0x18812D0 Offset: 0x187FCD0 VA: 0x1818812D0
	|-InputControl<Int32Enum>.get_unprocessedValue
	|
	|-RVA: 0x18810E0 Offset: 0x187FAE0 VA: 0x1818810E0
	|-InputControl<PoseState>.get_unprocessedValue
	|
	|-RVA: 0x18815F0 Offset: 0x187FFF0 VA: 0x1818815F0
	|-InputControl<Quaternion>.get_unprocessedValue
	|
	|-RVA: 0x1881010 Offset: 0x187FA10 VA: 0x181881010
	|-InputControl<float>.get_unprocessedValue
	|
	|-RVA: 0x1880D60 Offset: 0x187F760 VA: 0x181880D60
	|-InputControl<TouchState>.get_unprocessedValue
	|
	|-RVA: 0x1881520 Offset: 0x187FF20 VA: 0x181881520
	|-InputControl<uint>.get_unprocessedValue
	|
	|-RVA: 0x18811E0 Offset: 0x187FBE0 VA: 0x1818811E0
	|-InputControl<Vector2>.get_unprocessedValue
	|
	|-RVA: 0x1880E60 Offset: 0x187F860 VA: 0x181880E60
	|-InputControl<Vector3>.get_unprocessedValue
	|
	|-RVA: 0x18813A0 Offset: 0x187FDA0 VA: 0x1818813A0
	|-InputControl<__Il2CppFullySharedGenericStructType>.get_unprocessedValue
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1874180 Offset: 0x1872B80 VA: 0x181874180
	|-InputControl<Bone>.ReadValue
	|
	|-RVA: 0x1874250 Offset: 0x1872C50 VA: 0x181874250
	|-InputControl<bool>.ReadValue
	|
	|-RVA: 0x1874220 Offset: 0x1872C20 VA: 0x181874220
	|-InputControl<double>.ReadValue
	|
	|-RVA: 0x18741C0 Offset: 0x1872BC0 VA: 0x1818741C0
	|-InputControl<Eyes>.ReadValue
	|
	|-RVA: 0x187E930 Offset: 0x187D330 VA: 0x18187E930
	|-InputControl<int>.ReadValue
	|
	|-RVA: 0x187E890 Offset: 0x187D290 VA: 0x18187E890
	|-InputControl<Int32Enum>.ReadValue
	|
	|-RVA: 0x187E970 Offset: 0x187D370 VA: 0x18187E970
	|-InputControl<PoseState>.ReadValue
	|
	|-RVA: 0x187E740 Offset: 0x187D140 VA: 0x18187E740
	|-InputControl<Quaternion>.ReadValue
	|
	|-RVA: 0x187E860 Offset: 0x187D260 VA: 0x18187E860
	|-InputControl<float>.ReadValue
	|
	|-RVA: 0x187E8B0 Offset: 0x187D2B0 VA: 0x18187E8B0
	|-InputControl<TouchState>.ReadValue
	|
	|-RVA: 0x187E950 Offset: 0x187D350 VA: 0x18187E950
	|-InputControl<uint>.ReadValue
	|
	|-RVA: 0x187E900 Offset: 0x187D300 VA: 0x18187E900
	|-InputControl<Vector2>.ReadValue
	|
	|-RVA: 0x187E820 Offset: 0x187D220 VA: 0x18187E820
	|-InputControl<Vector3>.ReadValue
	|
	|-RVA: 0x187E780 Offset: 0x187D180 VA: 0x18187E780
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValue
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValueFromPreviousFrame() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1872930 Offset: 0x1871330 VA: 0x181872930
	|-InputControl<Bone>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x1872860 Offset: 0x1871260 VA: 0x181872860
	|-InputControl<bool>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x1872A40 Offset: 0x1871440 VA: 0x181872A40
	|-InputControl<double>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x1872B10 Offset: 0x1871510 VA: 0x181872B10
	|-InputControl<Eyes>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B610 Offset: 0x187A010 VA: 0x18187B610
	|-InputControl<int>.ReadValueFromPreviousFrame
	|-InputControl<Int32Enum>.ReadValueFromPreviousFrame
	|-InputControl<uint>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B820 Offset: 0x187A220 VA: 0x18187B820
	|-InputControl<PoseState>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B970 Offset: 0x187A370 VA: 0x18187B970
	|-InputControl<Quaternion>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B470 Offset: 0x1879E70 VA: 0x18187B470
	|-InputControl<float>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B6E0 Offset: 0x187A0E0 VA: 0x18187B6E0
	|-InputControl<TouchState>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B540 Offset: 0x1879F40 VA: 0x18187B540
	|-InputControl<Vector2>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187BA60 Offset: 0x187A460 VA: 0x18187BA60
	|-InputControl<Vector3>.ReadValueFromPreviousFrame
	|
	|-RVA: 0x187B3A0 Offset: 0x1879DA0 VA: 0x18187B3A0
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromPreviousFrame
	*/

	// RVA: -1 Offset: -1
	public TValue ReadDefaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1871900 Offset: 0x1870300 VA: 0x181871900
	|-InputControl<Bone>.ReadDefaultValue
	|
	|-RVA: 0x1871A30 Offset: 0x1870430 VA: 0x181871A30
	|-InputControl<bool>.ReadDefaultValue
	|
	|-RVA: 0x1871B30 Offset: 0x1870530 VA: 0x181871B30
	|-InputControl<double>.ReadDefaultValue
	|
	|-RVA: 0x1871C30 Offset: 0x1870630 VA: 0x181871C30
	|-InputControl<Eyes>.ReadDefaultValue
	|
	|-RVA: 0x1879270 Offset: 0x1877C70 VA: 0x181879270
	|-InputControl<int>.ReadDefaultValue
	|-InputControl<Int32Enum>.ReadDefaultValue
	|-InputControl<uint>.ReadDefaultValue
	|
	|-RVA: 0x1879A10 Offset: 0x1878410 VA: 0x181879A10
	|-InputControl<PoseState>.ReadDefaultValue
	|
	|-RVA: 0x1879600 Offset: 0x1878000 VA: 0x181879600
	|-InputControl<Quaternion>.ReadDefaultValue
	|
	|-RVA: 0x1879710 Offset: 0x1878110 VA: 0x181879710
	|-InputControl<float>.ReadDefaultValue
	|
	|-RVA: 0x1879370 Offset: 0x1877D70 VA: 0x181879370
	|-InputControl<TouchState>.ReadDefaultValue
	|
	|-RVA: 0x1879910 Offset: 0x1878310 VA: 0x181879910
	|-InputControl<Vector2>.ReadDefaultValue
	|
	|-RVA: 0x18794D0 Offset: 0x1877ED0 VA: 0x1818794D0
	|-InputControl<Vector3>.ReadDefaultValue
	|
	|-RVA: 0x1879810 Offset: 0x1878210 VA: 0x181879810
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadDefaultValue
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValueFromState(void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1873EC0 Offset: 0x18728C0 VA: 0x181873EC0
	|-InputControl<Bone>.ReadValueFromState
	|
	|-RVA: 0x1873E10 Offset: 0x1872810 VA: 0x181873E10
	|-InputControl<bool>.ReadValueFromState
	|
	|-RVA: 0x18740D0 Offset: 0x1872AD0 VA: 0x1818740D0
	|-InputControl<double>.ReadValueFromState
	|
	|-RVA: 0x1873FA0 Offset: 0x18729A0 VA: 0x181873FA0
	|-InputControl<Eyes>.ReadValueFromState
	|
	|-RVA: 0x187E0C0 Offset: 0x187CAC0 VA: 0x18187E0C0
	|-InputControl<int>.ReadValueFromState
	|-InputControl<Int32Enum>.ReadValueFromState
	|-InputControl<uint>.ReadValueFromState
	|
	|-RVA: 0x187E170 Offset: 0x187CB70 VA: 0x18187E170
	|-InputControl<PoseState>.ReadValueFromState
	|
	|-RVA: 0x187E680 Offset: 0x187D080 VA: 0x18187E680
	|-InputControl<Quaternion>.ReadValueFromState
	|
	|-RVA: 0x187E010 Offset: 0x187CA10 VA: 0x18187E010
	|-InputControl<float>.ReadValueFromState
	|
	|-RVA: 0x187E570 Offset: 0x187CF70 VA: 0x18187E570
	|-InputControl<TouchState>.ReadValueFromState
	|
	|-RVA: 0x187E4C0 Offset: 0x187CEC0 VA: 0x18187E4C0
	|-InputControl<Vector2>.ReadValueFromState
	|
	|-RVA: 0x187E290 Offset: 0x187CC90 VA: 0x18187E290
	|-InputControl<Vector3>.ReadValueFromState
	|
	|-RVA: 0x187E370 Offset: 0x187CD70 VA: 0x18187E370
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromState
	*/

	// RVA: -1 Offset: -1
	public TValue ReadValueFromStateWithCaching(void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1873900 Offset: 0x1872300 VA: 0x181873900
	|-InputControl<Bone>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x1873D00 Offset: 0x1872700 VA: 0x181873D00
	|-InputControl<bool>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x1873A40 Offset: 0x1872440 VA: 0x181873A40
	|-InputControl<double>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x1873B50 Offset: 0x1872550 VA: 0x181873B50
	|-InputControl<Eyes>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187D800 Offset: 0x187C200 VA: 0x18187D800
	|-InputControl<int>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187DCA0 Offset: 0x187C6A0 VA: 0x18187DCA0
	|-InputControl<Int32Enum>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187D560 Offset: 0x187BF60 VA: 0x18187D560
	|-InputControl<PoseState>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187D440 Offset: 0x187BE40 VA: 0x18187D440
	|-InputControl<Quaternion>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187D6F0 Offset: 0x187C0F0 VA: 0x18187D6F0
	|-InputControl<float>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187D910 Offset: 0x187C310 VA: 0x18187D910
	|-InputControl<TouchState>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187DB90 Offset: 0x187C590 VA: 0x18187DB90
	|-InputControl<uint>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187DEF0 Offset: 0x187C8F0 VA: 0x18187DEF0
	|-InputControl<Vector2>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187DDB0 Offset: 0x187C7B0 VA: 0x18187DDB0
	|-InputControl<Vector3>.ReadValueFromStateWithCaching
	|
	|-RVA: 0x187DA90 Offset: 0x187C490 VA: 0x18187DA90
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromStateWithCaching
	*/

	// RVA: -1 Offset: -1
	public TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1871DB0 Offset: 0x18707B0 VA: 0x181871DB0
	|-InputControl<Bone>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1871E50 Offset: 0x1870850 VA: 0x181871E50
	|-InputControl<bool>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1871F90 Offset: 0x1870990 VA: 0x181871F90
	|-InputControl<double>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1871ED0 Offset: 0x18708D0 VA: 0x181871ED0
	|-InputControl<Eyes>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879F70 Offset: 0x1878970 VA: 0x181879F70
	|-InputControl<int>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879B80 Offset: 0x1878580 VA: 0x181879B80
	|-InputControl<Int32Enum>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879EB0 Offset: 0x18788B0 VA: 0x181879EB0
	|-InputControl<PoseState>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x187A0A0 Offset: 0x1878AA0 VA: 0x18187A0A0
	|-InputControl<Quaternion>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x187A130 Offset: 0x1878B30 VA: 0x18187A130
	|-InputControl<float>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879FF0 Offset: 0x18789F0 VA: 0x181879FF0
	|-InputControl<TouchState>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879D90 Offset: 0x1878790 VA: 0x181879D90
	|-InputControl<uint>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879C00 Offset: 0x1878600 VA: 0x181879C00
	|-InputControl<Vector2>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879E10 Offset: 0x1878810 VA: 0x181879E10
	|-InputControl<Vector3>.ReadUnprocessedValueFromStateWithCaching
	|
	|-RVA: 0x1879C90 Offset: 0x1878690 VA: 0x181879C90
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadUnprocessedValueFromStateWithCaching
	*/

	// RVA: -1 Offset: -1
	public TValue ReadUnprocessedValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18720C0 Offset: 0x1870AC0 VA: 0x1818720C0
	|-InputControl<Bone>.ReadUnprocessedValue
	|
	|-RVA: 0x1872070 Offset: 0x1870A70 VA: 0x181872070
	|-InputControl<bool>.ReadUnprocessedValue
	|
	|-RVA: 0x1872090 Offset: 0x1870A90 VA: 0x181872090
	|-InputControl<double>.ReadUnprocessedValue
	|
	|-RVA: 0x1872010 Offset: 0x1870A10 VA: 0x181872010
	|-InputControl<Eyes>.ReadUnprocessedValue
	|
	|-RVA: 0x187A290 Offset: 0x1878C90 VA: 0x18187A290
	|-InputControl<int>.ReadUnprocessedValue
	|
	|-RVA: 0x187A1B0 Offset: 0x1878BB0 VA: 0x18187A1B0
	|-InputControl<Int32Enum>.ReadUnprocessedValue
	|
	|-RVA: 0x187A2B0 Offset: 0x1878CB0 VA: 0x18187A2B0
	|-InputControl<PoseState>.ReadUnprocessedValue
	|
	|-RVA: 0x187A340 Offset: 0x1878D40 VA: 0x18187A340
	|-InputControl<Quaternion>.ReadUnprocessedValue
	|
	|-RVA: 0x187A380 Offset: 0x1878D80 VA: 0x18187A380
	|-InputControl<float>.ReadUnprocessedValue
	|
	|-RVA: 0x187A3F0 Offset: 0x1878DF0 VA: 0x18187A3F0
	|-InputControl<TouchState>.ReadUnprocessedValue
	|
	|-RVA: 0x187A1D0 Offset: 0x1878BD0 VA: 0x18187A1D0
	|-InputControl<uint>.ReadUnprocessedValue
	|
	|-RVA: 0x187A310 Offset: 0x1878D10 VA: 0x18187A310
	|-InputControl<Vector2>.ReadUnprocessedValue
	|
	|-RVA: 0x187A3B0 Offset: 0x1878DB0 VA: 0x18187A3B0
	|-InputControl<Vector3>.ReadUnprocessedValue
	|
	|-RVA: 0x187A1F0 Offset: 0x1878BF0 VA: 0x18187A1F0
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadUnprocessedValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract TValue ReadUnprocessedValueFromState(void* statePtr);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadUnprocessedValueFromState
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override object ReadValueFromStateAsObject(void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1872EC0 Offset: 0x18718C0 VA: 0x181872EC0
	|-InputControl<Bone>.ReadValueFromStateAsObject
	|
	|-RVA: 0x1872FD0 Offset: 0x18719D0 VA: 0x181872FD0
	|-InputControl<bool>.ReadValueFromStateAsObject
	|
	|-RVA: 0x1872DE0 Offset: 0x18717E0 VA: 0x181872DE0
	|-InputControl<double>.ReadValueFromStateAsObject
	|
	|-RVA: 0x1872C70 Offset: 0x1871670 VA: 0x181872C70
	|-InputControl<Eyes>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187BEE0 Offset: 0x187A8E0 VA: 0x18187BEE0
	|-InputControl<int>.ReadValueFromStateAsObject
	|-InputControl<Int32Enum>.ReadValueFromStateAsObject
	|-InputControl<uint>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187BB70 Offset: 0x187A570 VA: 0x18187BB70
	|-InputControl<PoseState>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187BFC0 Offset: 0x187A9C0 VA: 0x18187BFC0
	|-InputControl<Quaternion>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187BCC0 Offset: 0x187A6C0 VA: 0x18187BCC0
	|-InputControl<float>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187BDA0 Offset: 0x187A7A0 VA: 0x18187BDA0
	|-InputControl<TouchState>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187C270 Offset: 0x187AC70 VA: 0x18187C270
	|-InputControl<Vector2>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187C160 Offset: 0x187AB60 VA: 0x18187C160
	|-InputControl<Vector3>.ReadValueFromStateAsObject
	|
	|-RVA: 0x187C0B0 Offset: 0x187AAB0 VA: 0x18187C0B0
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromStateAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1873480 Offset: 0x1871E80 VA: 0x181873480
	|-InputControl<Bone>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x18730B0 Offset: 0x1871AB0 VA: 0x1818730B0
	|-InputControl<bool>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x1873290 Offset: 0x1871C90 VA: 0x181873290
	|-InputControl<double>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x18736A0 Offset: 0x18720A0 VA: 0x1818736A0
	|-InputControl<Eyes>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187C9B0 Offset: 0x187B3B0 VA: 0x18187C9B0
	|-InputControl<int>.ReadValueFromStateIntoBuffer
	|-InputControl<Int32Enum>.ReadValueFromStateIntoBuffer
	|-InputControl<uint>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187CFF0 Offset: 0x187B9F0 VA: 0x18187CFF0
	|-InputControl<PoseState>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187C540 Offset: 0x187AF40 VA: 0x18187C540
	|-InputControl<Quaternion>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187C350 Offset: 0x187AD50 VA: 0x18187C350
	|-InputControl<float>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187CDA0 Offset: 0x187B7A0 VA: 0x18187CDA0
	|-InputControl<TouchState>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187D250 Offset: 0x187BC50 VA: 0x18187D250
	|-InputControl<Vector2>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187CB90 Offset: 0x187B590 VA: 0x18187CB90
	|-InputControl<Vector3>.ReadValueFromStateIntoBuffer
	|
	|-RVA: 0x187C740 Offset: 0x187B140 VA: 0x18187C740
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromStateIntoBuffer
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18745F0 Offset: 0x1872FF0 VA: 0x1818745F0
	|-InputControl<Bone>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x1874270 Offset: 0x1872C70 VA: 0x181874270
	|-InputControl<bool>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x18747B0 Offset: 0x18731B0 VA: 0x1818747B0
	|-InputControl<double>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x1874400 Offset: 0x1872E00 VA: 0x181874400
	|-InputControl<Eyes>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187F0A0 Offset: 0x187DAA0 VA: 0x18187F0A0
	|-InputControl<int>.WriteValueFromBufferIntoState
	|-InputControl<Int32Enum>.WriteValueFromBufferIntoState
	|-InputControl<uint>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187F3F0 Offset: 0x187DDF0 VA: 0x18187F3F0
	|-InputControl<PoseState>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187EB70 Offset: 0x187D570 VA: 0x18187EB70
	|-InputControl<Quaternion>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187E9D0 Offset: 0x187D3D0 VA: 0x18187E9D0
	|-InputControl<float>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187EEB0 Offset: 0x187D8B0 VA: 0x18187EEB0
	|-InputControl<TouchState>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187ED20 Offset: 0x187D720 VA: 0x18187ED20
	|-InputControl<Vector2>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187F230 Offset: 0x187DC30 VA: 0x18187F230
	|-InputControl<Vector3>.WriteValueFromBufferIntoState
	|
	|-RVA: 0x187F5F0 Offset: 0x187DFF0 VA: 0x18187F5F0
	|-InputControl<__Il2CppFullySharedGenericStructType>.WriteValueFromBufferIntoState
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override void WriteValueFromObjectIntoState(object value, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1874F60 Offset: 0x1873960 VA: 0x181874F60
	|-InputControl<Bone>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1874950 Offset: 0x1873350 VA: 0x181874950
	|-InputControl<bool>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1874D70 Offset: 0x1873770 VA: 0x181874D70
	|-InputControl<double>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1874B40 Offset: 0x1873540 VA: 0x181874B40
	|-InputControl<Eyes>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x187FE50 Offset: 0x187E850 VA: 0x18187FE50
	|-InputControl<int>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x18808F0 Offset: 0x187F2F0 VA: 0x1818808F0
	|-InputControl<Int32Enum>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1880230 Offset: 0x187EC30 VA: 0x181880230
	|-InputControl<PoseState>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x187FA50 Offset: 0x187E450 VA: 0x18187FA50
	|-InputControl<Quaternion>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x187F860 Offset: 0x187E260 VA: 0x18187F860
	|-InputControl<float>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1880450 Offset: 0x187EE50 VA: 0x181880450
	|-InputControl<TouchState>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1880040 Offset: 0x187EA40 VA: 0x181880040
	|-InputControl<uint>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1880AE0 Offset: 0x187F4E0 VA: 0x181880AE0
	|-InputControl<Vector2>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x187FC50 Offset: 0x187E650 VA: 0x18187FC50
	|-InputControl<Vector3>.WriteValueFromObjectIntoState
	|
	|-RVA: 0x1880660 Offset: 0x187F060 VA: 0x181880660
	|-InputControl<__Il2CppFullySharedGenericStructType>.WriteValueFromObjectIntoState
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public virtual void WriteValueIntoState(TValue value, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1875160 Offset: 0x1873B60 VA: 0x181875160
	|-InputControl<Bone>.WriteValueIntoState
	|-InputControl<bool>.WriteValueIntoState
	|-InputControl<double>.WriteValueIntoState
	|-InputControl<Eyes>.WriteValueIntoState
	|-InputControl<int>.WriteValueIntoState
	|-InputControl<Int32Enum>.WriteValueIntoState
	|-InputControl<PoseState>.WriteValueIntoState
	|-InputControl<Quaternion>.WriteValueIntoState
	|-InputControl<float>.WriteValueIntoState
	|-InputControl<TouchState>.WriteValueIntoState
	|-InputControl<uint>.WriteValueIntoState
	|-InputControl<Vector2>.WriteValueIntoState
	|-InputControl<Vector3>.WriteValueIntoState
	|-InputControl<__Il2CppFullySharedGenericStructType>.WriteValueIntoState
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override object ReadValueFromBufferAsObject(void* buffer, int bufferSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18722C0 Offset: 0x1870CC0 VA: 0x1818722C0
	|-InputControl<Bone>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x18724A0 Offset: 0x1870EA0 VA: 0x1818724A0
	|-InputControl<bool>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x1872100 Offset: 0x1870B00 VA: 0x181872100
	|-InputControl<double>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x1872650 Offset: 0x1871050 VA: 0x181872650
	|-InputControl<Eyes>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187A440 Offset: 0x1878E40 VA: 0x18187A440
	|-InputControl<int>.ReadValueFromBufferAsObject
	|-InputControl<Int32Enum>.ReadValueFromBufferAsObject
	|-InputControl<uint>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187AD50 Offset: 0x1879750 VA: 0x18187AD50
	|-InputControl<PoseState>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187A7B0 Offset: 0x18791B0 VA: 0x18187A7B0
	|-InputControl<Quaternion>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187A5F0 Offset: 0x1878FF0 VA: 0x18187A5F0
	|-InputControl<float>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187A980 Offset: 0x1879380 VA: 0x18187A980
	|-InputControl<TouchState>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187AB90 Offset: 0x1879590 VA: 0x18187AB90
	|-InputControl<Vector2>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187B1D0 Offset: 0x1879BD0 VA: 0x18187B1D0
	|-InputControl<Vector3>.ReadValueFromBufferAsObject
	|
	|-RVA: 0x187AF70 Offset: 0x1879970 VA: 0x18187AF70
	|-InputControl<__Il2CppFullySharedGenericStructType>.ReadValueFromBufferAsObject
	*/

	// RVA: -1 Offset: -1
	private static bool CompareValue(ref TValue firstValue, ref TValue secondValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1870440 Offset: 0x186EE40 VA: 0x181870440
	|-InputControl<Bone>.CompareValue
	|
	|-RVA: 0x18703A0 Offset: 0x186EDA0 VA: 0x1818703A0
	|-InputControl<bool>.CompareValue
	|
	|-RVA: 0x18703F0 Offset: 0x186EDF0 VA: 0x1818703F0
	|-InputControl<double>.CompareValue
	|-InputControl<Vector2>.CompareValue
	|
	|-RVA: 0x1870350 Offset: 0x186ED50 VA: 0x181870350
	|-InputControl<Eyes>.CompareValue
	|
	|-RVA: 0x1875E30 Offset: 0x1874830 VA: 0x181875E30
	|-InputControl<int>.CompareValue
	|-InputControl<Int32Enum>.CompareValue
	|-InputControl<float>.CompareValue
	|-InputControl<uint>.CompareValue
	|
	|-RVA: 0x18768E0 Offset: 0x18752E0 VA: 0x1818768E0
	|-InputControl<PoseState>.CompareValue
	|
	|-RVA: 0x1876B30 Offset: 0x1875530 VA: 0x181876B30
	|-InputControl<Quaternion>.CompareValue
	|
	|-RVA: 0x1876030 Offset: 0x1874A30 VA: 0x181876030
	|-InputControl<TouchState>.CompareValue
	|
	|-RVA: 0x1875DE0 Offset: 0x18747E0 VA: 0x181875DE0
	|-InputControl<Vector3>.CompareValue
	|
	|-RVA: 0x1876EE0 Offset: 0x18758E0 VA: 0x181876EE0
	|-InputControl<__Il2CppFullySharedGenericStructType>.CompareValue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override bool CompareValue(void* firstStatePtr, void* secondStatePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1870640 Offset: 0x186F040 VA: 0x181870640
	|-InputControl<Bone>.CompareValue
	|
	|-RVA: 0x1870490 Offset: 0x186EE90 VA: 0x181870490
	|-InputControl<bool>.CompareValue
	|
	|-RVA: 0x18701A0 Offset: 0x186EBA0 VA: 0x1818701A0
	|-InputControl<double>.CompareValue
	|
	|-RVA: 0x1870840 Offset: 0x186F240 VA: 0x181870840
	|-InputControl<Eyes>.CompareValue
	|
	|-RVA: 0x18762E0 Offset: 0x1874CE0 VA: 0x1818762E0
	|-InputControl<int>.CompareValue
	|-InputControl<Int32Enum>.CompareValue
	|-InputControl<uint>.CompareValue
	|
	|-RVA: 0x1876490 Offset: 0x1874E90 VA: 0x181876490
	|-InputControl<PoseState>.CompareValue
	|
	|-RVA: 0x1876710 Offset: 0x1875110 VA: 0x181876710
	|-InputControl<Quaternion>.CompareValue
	|
	|-RVA: 0x1875E80 Offset: 0x1874880 VA: 0x181875E80
	|-InputControl<float>.CompareValue
	|
	|-RVA: 0x1876080 Offset: 0x1874A80 VA: 0x181876080
	|-InputControl<TouchState>.CompareValue
	|
	|-RVA: 0x1876D30 Offset: 0x1875730 VA: 0x181876D30
	|-InputControl<Vector2>.CompareValue
	|
	|-RVA: 0x1876930 Offset: 0x1875330 VA: 0x181876930
	|-InputControl<Vector3>.CompareValue
	|
	|-RVA: 0x1876B80 Offset: 0x1875580 VA: 0x181876B80
	|-InputControl<__Il2CppFullySharedGenericStructType>.CompareValue
	*/

	// RVA: -1 Offset: -1
	public TValue ProcessValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1871690 Offset: 0x1870090 VA: 0x181871690
	|-InputControl<Bone>.ProcessValue
	|
	|-RVA: 0x18716E0 Offset: 0x18700E0 VA: 0x1818716E0
	|-InputControl<bool>.ProcessValue
	|
	|-RVA: 0x18715F0 Offset: 0x186FFF0 VA: 0x1818715F0
	|-InputControl<double>.ProcessValue
	|
	|-RVA: 0x1871620 Offset: 0x1870020 VA: 0x181871620
	|-InputControl<Eyes>.ProcessValue
	|
	|-RVA: 0x18786E0 Offset: 0x18770E0 VA: 0x1818786E0
	|-InputControl<int>.ProcessValue
	|-InputControl<Int32Enum>.ProcessValue
	|-InputControl<uint>.ProcessValue
	|
	|-RVA: 0x1878710 Offset: 0x1877110 VA: 0x181878710
	|-InputControl<PoseState>.ProcessValue
	|
	|-RVA: 0x1878690 Offset: 0x1877090 VA: 0x181878690
	|-InputControl<Quaternion>.ProcessValue
	|
	|-RVA: 0x1878780 Offset: 0x1877180 VA: 0x181878780
	|-InputControl<float>.ProcessValue
	|
	|-RVA: 0x18791E0 Offset: 0x1877BE0 VA: 0x1818791E0
	|-InputControl<TouchState>.ProcessValue
	|
	|-RVA: 0x1879240 Offset: 0x1877C40 VA: 0x181879240
	|-InputControl<Vector2>.ProcessValue
	|
	|-RVA: 0x1878D10 Offset: 0x1877710 VA: 0x181878D10
	|-InputControl<Vector3>.ProcessValue
	|
	|-RVA: 0x1879130 Offset: 0x1877B30 VA: 0x181879130
	|-InputControl<__Il2CppFullySharedGenericStructType>.ProcessValue
	*/

	// RVA: -1 Offset: -1
	public void ProcessValue(ref TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18714A0 Offset: 0x186FEA0 VA: 0x1818714A0
	|-InputControl<Bone>.ProcessValue
	|
	|-RVA: 0x18713C0 Offset: 0x186FDC0 VA: 0x1818713C0
	|-InputControl<bool>.ProcessValue
	|
	|-RVA: 0x18712E0 Offset: 0x186FCE0 VA: 0x1818712E0
	|-InputControl<double>.ProcessValue
	|
	|-RVA: 0x1871710 Offset: 0x1870110 VA: 0x181871710
	|-InputControl<Eyes>.ProcessValue
	|
	|-RVA: 0x18787B0 Offset: 0x18771B0 VA: 0x1818787B0
	|-InputControl<int>.ProcessValue
	|-InputControl<Int32Enum>.ProcessValue
	|-InputControl<uint>.ProcessValue
	|
	|-RVA: 0x1878D60 Offset: 0x1877760 VA: 0x181878D60
	|-InputControl<PoseState>.ProcessValue
	|
	|-RVA: 0x1879010 Offset: 0x1877A10 VA: 0x181879010
	|-InputControl<Quaternion>.ProcessValue
	|
	|-RVA: 0x1878F30 Offset: 0x1877930 VA: 0x181878F30
	|-InputControl<float>.ProcessValue
	|
	|-RVA: 0x1878890 Offset: 0x1877290 VA: 0x181878890
	|-InputControl<TouchState>.ProcessValue
	|
	|-RVA: 0x18785B0 Offset: 0x1876FB0 VA: 0x1818785B0
	|-InputControl<Vector2>.ProcessValue
	|
	|-RVA: 0x1878470 Offset: 0x1876E70 VA: 0x181878470
	|-InputControl<Vector3>.ProcessValue
	|
	|-RVA: 0x1878A40 Offset: 0x1877440 VA: 0x181878A40
	|-InputControl<__Il2CppFullySharedGenericStructType>.ProcessValue
	*/

	// RVA: -1 Offset: -1
	internal TProcessor TryGetProcessor<TProcessor>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC7150 Offset: 0xDC5B50 VA: 0x180DC7150
	|-InputControl<__Il2CppFullySharedGenericStructType>.TryGetProcessor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override void AddProcessor(object processor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FFA0 Offset: 0x186E9A0 VA: 0x18186FFA0
	|-InputControl<Bone>.AddProcessor
	|-InputControl<bool>.AddProcessor
	|-InputControl<double>.AddProcessor
	|-InputControl<Eyes>.AddProcessor
	|-InputControl<int>.AddProcessor
	|-InputControl<Int32Enum>.AddProcessor
	|-InputControl<PoseState>.AddProcessor
	|-InputControl<Quaternion>.AddProcessor
	|-InputControl<float>.AddProcessor
	|-InputControl<TouchState>.AddProcessor
	|-InputControl<uint>.AddProcessor
	|-InputControl<Vector2>.AddProcessor
	|-InputControl<Vector3>.AddProcessor
	|
	|-RVA: 0x1875BB0 Offset: 0x18745B0 VA: 0x181875BB0
	|-InputControl<__Il2CppFullySharedGenericStructType>.AddProcessor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected override void FinishSetup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1870EE0 Offset: 0x186F8E0 VA: 0x181870EE0
	|-InputControl<Bone>.FinishSetup
	|
	|-RVA: 0x1870AE0 Offset: 0x186F4E0 VA: 0x181870AE0
	|-InputControl<bool>.FinishSetup
	|
	|-RVA: 0x1870CE0 Offset: 0x186F6E0 VA: 0x181870CE0
	|-InputControl<double>.FinishSetup
	|
	|-RVA: 0x18710E0 Offset: 0x186FAE0 VA: 0x1818710E0
	|-InputControl<Eyes>.FinishSetup
	|
	|-RVA: 0x1877410 Offset: 0x1875E10 VA: 0x181877410
	|-InputControl<int>.FinishSetup
	|
	|-RVA: 0x1877610 Offset: 0x1876010 VA: 0x181877610
	|-InputControl<Int32Enum>.FinishSetup
	|
	|-RVA: 0x1877810 Offset: 0x1876210 VA: 0x181877810
	|-InputControl<PoseState>.FinishSetup
	|
	|-RVA: 0x1878270 Offset: 0x1876C70 VA: 0x181878270
	|-InputControl<Quaternion>.FinishSetup
	|
	|-RVA: 0x1877010 Offset: 0x1875A10 VA: 0x181877010
	|-InputControl<float>.FinishSetup
	|
	|-RVA: 0x1877A10 Offset: 0x1876410 VA: 0x181877A10
	|-InputControl<TouchState>.FinishSetup
	|
	|-RVA: 0x1878070 Offset: 0x1876A70 VA: 0x181878070
	|-InputControl<uint>.FinishSetup
	|
	|-RVA: 0x1877E70 Offset: 0x1876870 VA: 0x181877E70
	|-InputControl<Vector2>.FinishSetup
	|
	|-RVA: 0x1877210 Offset: 0x1875C10 VA: 0x181877210
	|-InputControl<Vector3>.FinishSetup
	|
	|-RVA: 0x1877C10 Offset: 0x1876610 VA: 0x181877C10
	|-InputControl<__Il2CppFullySharedGenericStructType>.FinishSetup
	*/

	// RVA: -1 Offset: -1
	internal InputProcessor<TValue>[] get_processors() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18751E0 Offset: 0x1873BE0 VA: 0x1818751E0
	|-InputControl<Bone>.get_processors
	|-InputControl<bool>.get_processors
	|-InputControl<double>.get_processors
	|-InputControl<Eyes>.get_processors
	|
	|-RVA: 0x1880CE0 Offset: 0x187F6E0 VA: 0x181880CE0
	|-InputControl<int>.get_processors
	|-InputControl<Int32Enum>.get_processors
	|-InputControl<PoseState>.get_processors
	|-InputControl<Quaternion>.get_processors
	|-InputControl<float>.get_processors
	|-InputControl<TouchState>.get_processors
	|-InputControl<uint>.get_processors
	|-InputControl<Vector2>.get_processors
	|-InputControl<Vector3>.get_processors
	|
	|-RVA: 0x1880D00 Offset: 0x187F700 VA: 0x181880D00
	|-InputControl<__Il2CppFullySharedGenericStructType>.get_processors
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18751D0 Offset: 0x1873BD0 VA: 0x1818751D0
	|-InputControl<Bone>..ctor
	|-InputControl<bool>..ctor
	|-InputControl<double>..ctor
	|-InputControl<Eyes>..ctor
	|-InputControl<int>..ctor
	|-InputControl<Int32Enum>..ctor
	|-InputControl<PoseState>..ctor
	|-InputControl<Quaternion>..ctor
	|-InputControl<float>..ctor
	|-InputControl<TouchState>..ctor
	|-InputControl<uint>..ctor
	|-InputControl<Vector2>..ctor
	|-InputControl<Vector3>..ctor
	|-InputControl<__Il2CppFullySharedGenericStructType>..ctor
	*/
}
