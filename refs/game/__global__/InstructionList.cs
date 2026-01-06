internal sealed class InstructionList // TypeDefIndex: 15367
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x1FC9F20 Offset: 0x1FC8920 VA: 0x181FC9F20
	public void Emit(Instruction instruction) { }

	// RVA: 0x1FCAEA0 Offset: 0x1FC98A0 VA: 0x181FCAEA0
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x1FCAD80 Offset: 0x1FC9780 VA: 0x181FCAD80
	public void UnEmit() { }

	// RVA: 0x1FCB110 Offset: 0x1FC9B10 VA: 0x181FCB110
	public int get_Count() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_CurrentStackDepth() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x1FCA190 Offset: 0x1FC8B90 VA: 0x181FCA190
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x1FCAC50 Offset: 0x1FC9650 VA: 0x181FCAC50
	public InstructionArray ToArray() { }

	// RVA: 0x1FC9160 Offset: 0x1FC7B60 VA: 0x181FC9160
	public void EmitLoad(object value) { }

	// RVA: 0x1FC8F70 Offset: 0x1FC7970 VA: 0x181FC8F70
	public void EmitLoad(bool value) { }

	// RVA: 0x1FC8930 Offset: 0x1FC7330 VA: 0x181FC8930
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x1FC77D0 Offset: 0x1FC61D0 VA: 0x181FC77D0
	public void EmitDup() { }

	// RVA: 0x1FC9700 Offset: 0x1FC8100 VA: 0x181FC9700
	public void EmitPop() { }

	// RVA: 0x1FCAB90 Offset: 0x1FC9590 VA: 0x181FCAB90
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x1FC8710 Offset: 0x1FC7110 VA: 0x181FC8710
	public void EmitLoadLocal(int index) { }

	// RVA: 0x1FC8260 Offset: 0x1FC6C60 VA: 0x181FC8260
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x1FCA4F0 Offset: 0x1FC8EF0 VA: 0x181FCA4F0
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x1FC84F0 Offset: 0x1FC6EF0 VA: 0x181FC84F0
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x1FC82D0 Offset: 0x1FC6CD0 VA: 0x181FC82D0
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x1FC6CC0 Offset: 0x1FC56C0 VA: 0x181FC6CC0
	public void EmitAssignLocal(int index) { }

	// RVA: 0x1FC9A40 Offset: 0x1FC8440 VA: 0x181FC9A40
	public void EmitStoreLocal(int index) { }

	// RVA: 0x1FC6A30 Offset: 0x1FC5430 VA: 0x181FC6A30
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x1FC64F0 Offset: 0x1FC4EF0 VA: 0x181FC64F0
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x1FC9960 Offset: 0x1FC8360 VA: 0x181FC9960
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x1FCA980 Offset: 0x1FC9380 VA: 0x181FCA980
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x1FC6AA0 Offset: 0x1FC54A0 VA: 0x181FC6AA0
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x1FC99D0 Offset: 0x1FC83D0 VA: 0x181FC99D0
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x1FC7DE0 Offset: 0x1FC67E0 VA: 0x181FC7DE0
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x1FC7F20 Offset: 0x1FC6920 VA: 0x181FC7F20
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x1FCA920 Offset: 0x1FC9320 VA: 0x181FCA920
	internal static Instruction Parameter(int index) { }

	// RVA: 0x1FCA8C0 Offset: 0x1FC92C0 VA: 0x181FCA8C0
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x1FCA490 Offset: 0x1FC8E90 VA: 0x181FCA490
	internal static Instruction InitReference(int index) { }

	// RVA: 0x1FCA430 Offset: 0x1FC8E30 VA: 0x181FCA430
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x1FC93B0 Offset: 0x1FC7DB0 VA: 0x181FC93B0
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x1FC7C10 Offset: 0x1FC6610 VA: 0x181FC7C10
	public void EmitGetArrayItem() { }

	// RVA: 0x1FC9850 Offset: 0x1FC8250 VA: 0x181FC9850
	public void EmitSetArrayItem() { }

	// RVA: 0x1FC9340 Offset: 0x1FC7D40 VA: 0x181FC9340
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x1FC9240 Offset: 0x1FC7C40 VA: 0x181FC9240
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x1FC92C0 Offset: 0x1FC7CC0 VA: 0x181FC92C0
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x1FC6960 Offset: 0x1FC5360 VA: 0x181FC6960
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x1FC9CE0 Offset: 0x1FC86E0 VA: 0x181FC9CE0
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x1FC91A0 Offset: 0x1FC7BA0 VA: 0x181FC91A0
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x1FC77A0 Offset: 0x1FC61A0 VA: 0x181FC77A0
	public void EmitDiv(Type type) { }

	// RVA: 0x1FC9170 Offset: 0x1FC7B70 VA: 0x181FC9170
	public void EmitModulo(Type type) { }

	// RVA: 0x1FC7BE0 Offset: 0x1FC65E0 VA: 0x181FC7BE0
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x1FC69A0 Offset: 0x1FC53A0 VA: 0x181FC69A0
	public void EmitAnd(Type type) { }

	// RVA: 0x1FC96D0 Offset: 0x1FC80D0 VA: 0x181FC96D0
	public void EmitOr(Type type) { }

	// RVA: 0x1FC8180 Offset: 0x1FC6B80 VA: 0x181FC8180
	public void EmitLeftShift(Type type) { }

	// RVA: 0x1FC9820 Offset: 0x1FC8220 VA: 0x181FC9820
	public void EmitRightShift(Type type) { }

	// RVA: 0x1FC7BA0 Offset: 0x1FC65A0 VA: 0x181FC7BA0
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1FC94B0 Offset: 0x1FC7EB0 VA: 0x181FC94B0
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1FC81F0 Offset: 0x1FC6BF0 VA: 0x181FC81F0
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x1FC81B0 Offset: 0x1FC6BB0 VA: 0x181FC81B0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1FC7D70 Offset: 0x1FC6770 VA: 0x181FC7D70
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x1FC7D30 Offset: 0x1FC6730 VA: 0x181FC7D30
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1FC9590 Offset: 0x1FC7F90 VA: 0x181FC9590
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1FC9630 Offset: 0x1FC8030 VA: 0x181FC9630
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1FC7610 Offset: 0x1FC6010 VA: 0x181FC7610
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1FC7530 Offset: 0x1FC5F30 VA: 0x181FC7530
	public void EmitCast(Type toType) { }

	// RVA: 0x1FC74C0 Offset: 0x1FC5EC0 VA: 0x181FC74C0
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x1FC7450 Offset: 0x1FC5E50 VA: 0x181FC7450
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x1FC94F0 Offset: 0x1FC7EF0 VA: 0x181FC94F0
	public void EmitNot(Type type) { }

	// RVA: 0x1FC7730 Offset: 0x1FC6130 VA: 0x181FC7730
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x1FC9420 Offset: 0x1FC7E20 VA: 0x181FC9420
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x1FC7300 Offset: 0x1FC5D00 VA: 0x181FC7300
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x1FC7690 Offset: 0x1FC6090 VA: 0x181FC7690
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x1FC9E50 Offset: 0x1FC8850 VA: 0x181FC9E50
	public void EmitTypeEquals() { }

	// RVA: 0x1FC69D0 Offset: 0x1FC53D0 VA: 0x181FC69D0
	public void EmitArrayLength() { }

	// RVA: 0x1FC9210 Offset: 0x1FC7C10 VA: 0x181FC9210
	public void EmitNegate(Type type) { }

	// RVA: 0x1FC91E0 Offset: 0x1FC7BE0 VA: 0x181FC91E0
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x1FC7DB0 Offset: 0x1FC67B0 VA: 0x181FC7DB0
	public void EmitIncrement(Type type) { }

	// RVA: 0x1FC7700 Offset: 0x1FC6100 VA: 0x181FC7700
	public void EmitDecrement(Type type) { }

	// RVA: 0x1FC9EB0 Offset: 0x1FC88B0 VA: 0x181FC9EB0
	public void EmitTypeIs(Type type) { }

	// RVA: 0x1FC9DE0 Offset: 0x1FC87E0 VA: 0x181FC9DE0
	public void EmitTypeAs(Type type) { }

	// RVA: 0x1FC8230 Offset: 0x1FC6C30 VA: 0x181FC8230
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x1FCA1F0 Offset: 0x1FC8BF0 VA: 0x181FCA1F0
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x1FC98B0 Offset: 0x1FC82B0 VA: 0x181FC98B0
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x1FC73D0 Offset: 0x1FC5DD0 VA: 0x181FC73D0
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x1FC73A0 Offset: 0x1FC5DA0 VA: 0x181FC73A0
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1FC7240 Offset: 0x1FC5C40 VA: 0x181FC7240
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1FC9520 Offset: 0x1FC7F20 VA: 0x181FC9520
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1FC6700 Offset: 0x1FC5100 VA: 0x181FC6700
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x1FCA700 Offset: 0x1FC9100 VA: 0x181FCA700
	public BranchLabel MakeLabel() { }

	// RVA: 0x1FCA0B0 Offset: 0x1FC8AB0 VA: 0x181FCA0B0
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x1FCA070 Offset: 0x1FC8A70 VA: 0x181FCA070
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x1FCA860 Offset: 0x1FC9260 VA: 0x181FCA860
	public int MarkRuntimeLabel() { }

	// RVA: 0x1FCA830 Offset: 0x1FC9230 VA: 0x181FCA830
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x1FC7C70 Offset: 0x1FC6670 VA: 0x181FC7C70
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1FC71D0 Offset: 0x1FC5BD0 VA: 0x181FC71D0
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x1FC7040 Offset: 0x1FC5A40 VA: 0x181FC7040
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x1FC70F0 Offset: 0x1FC5AF0 VA: 0x181FC70F0
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x1FC7560 Offset: 0x1FC5F60 VA: 0x181FC7560
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x1FC6F90 Offset: 0x1FC5990 VA: 0x181FC6F90
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x1FC6EE0 Offset: 0x1FC58E0 VA: 0x181FC6EE0
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x1FC9D80 Offset: 0x1FC8780 VA: 0x181FC9D80
	public void EmitThrow() { }

	// RVA: 0x1FC9D20 Offset: 0x1FC8720 VA: 0x181FC9D20
	public void EmitThrowVoid() { }

	// RVA: 0x1FC97C0 Offset: 0x1FC81C0 VA: 0x181FC97C0
	public void EmitRethrow() { }

	// RVA: 0x1FC9760 Offset: 0x1FC8160 VA: 0x181FC9760
	public void EmitRethrowVoid() { }

	// RVA: 0x1FC7B40 Offset: 0x1FC6540 VA: 0x181FC7B40
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1FC7A70 Offset: 0x1FC6470 VA: 0x181FC7A70
	public void EmitEnterTryCatch() { }

	// RVA: 0x1FC7AA0 Offset: 0x1FC64A0 VA: 0x181FC7AA0
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x1FC79E0 Offset: 0x1FC63E0 VA: 0x181FC79E0
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1FC8120 Offset: 0x1FC6B20 VA: 0x181FC8120
	public void EmitLeaveFinally() { }

	// RVA: 0x1FC7950 Offset: 0x1FC6350 VA: 0x181FC7950
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x1FC80C0 Offset: 0x1FC6AC0 VA: 0x181FC80C0
	public void EmitLeaveFault() { }

	// RVA: 0x1FC7830 Offset: 0x1FC6230 VA: 0x181FC7830
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x1FC7FC0 Offset: 0x1FC69C0 VA: 0x181FC7FC0
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x1FC7890 Offset: 0x1FC6290 VA: 0x181FC7890
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x1FC78F0 Offset: 0x1FC62F0 VA: 0x181FC78F0
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x1FC8020 Offset: 0x1FC6A20 VA: 0x181FC8020
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3F80 Offset: 0xEE2980 VA: 0x180EE3F80
	|-InstructionList.EmitIntSwitch<int>
	|-InstructionList.EmitIntSwitch<object>
	|
	|-RVA: 0xEE3EF0 Offset: 0xEE28F0 VA: 0x180EE3EF0
	|-InstructionList.EmitIntSwitch<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FC9C60 Offset: 0x1FC8660 VA: 0x181FC9C60
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1FCB090 Offset: 0x1FC9A90 VA: 0x181FCB090
	public void .ctor() { }

	// RVA: 0x1FCAF60 Offset: 0x1FC9960 VA: 0x181FCAF60
	private static void .cctor() { }
}
