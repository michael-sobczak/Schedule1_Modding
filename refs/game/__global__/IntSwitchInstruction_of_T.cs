internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 15267
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	|-IntSwitchInstruction<int>..ctor
	|-IntSwitchInstruction<object>..ctor
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1886F30 Offset: 0x1885930 VA: 0x181886F30
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x1886F60 Offset: 0x1885960 VA: 0x181886F60
	|-IntSwitchInstruction<object>.get_InstructionName
	|
	|-RVA: 0x1886F90 Offset: 0x1885990 VA: 0x181886F90
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|-IntSwitchInstruction<object>.get_ConsumedStack
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1886C70 Offset: 0x1885670 VA: 0x181886C70
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x1886E70 Offset: 0x1885870 VA: 0x181886E70
	|-IntSwitchInstruction<object>.Run
	|
	|-RVA: 0x1886D40 Offset: 0x1885740 VA: 0x181886D40
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.Run
	*/
}
