internal sealed class LightCompiler // TypeDefIndex: 15418
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x1FE22E0 Offset: 0x1FE0CE0 VA: 0x181FE22E0
	public void .ctor() { }

	// RVA: 0x1FE22A0 Offset: 0x1FE0CA0 VA: 0x181FE22A0
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public InstructionList get_Instructions() { }

	// RVA: 0x1FDE730 Offset: 0x1FDD130 VA: 0x181FDE730
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x1FE1570 Offset: 0x1FDFF70 VA: 0x181FE1570
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x1FD64D0 Offset: 0x1FD4ED0 VA: 0x181FD64D0
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x1FD76E0 Offset: 0x1FD60E0 VA: 0x181FD76E0
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x1FD75D0 Offset: 0x1FD5FD0 VA: 0x181FD75D0
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x1FE1080 Offset: 0x1FDFA80 VA: 0x181FE1080
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x1FE1BD0 Offset: 0x1FE05D0 VA: 0x181FE1BD0
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x1FD7970 Offset: 0x1FD6370 VA: 0x181FD7970
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x1FE0B80 Offset: 0x1FDF580 VA: 0x181FE0B80
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x1FE1430 Offset: 0x1FDFE30 VA: 0x181FE1430
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x1FE19E0 Offset: 0x1FE03E0 VA: 0x181FE19E0
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x1FD78C0 Offset: 0x1FD62C0 VA: 0x181FD78C0
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x1FDD3F0 Offset: 0x1FDBDF0 VA: 0x181FDD3F0
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x1FDCDB0 Offset: 0x1FDB7B0 VA: 0x181FDCDB0
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x1FD5190 Offset: 0x1FD3B90 VA: 0x181FD5190
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1FD5370 Offset: 0x1FD3D70 VA: 0x181FD5370
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x1FD50C0 Offset: 0x1FD3AC0 VA: 0x181FD50C0
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x1FD8130 Offset: 0x1FD6B30 VA: 0x181FD8130
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x1FE0C40 Offset: 0x1FDF640 VA: 0x181FE0C40
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x1FD7D80 Offset: 0x1FD6780 VA: 0x181FD7D80
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1FDA1C0 Offset: 0x1FD8BC0 VA: 0x181FDA1C0
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1FD9C40 Offset: 0x1FD8640 VA: 0x181FD9C40
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x1FE0860 Offset: 0x1FDF260 VA: 0x181FE0860
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1FD3DF0 Offset: 0x1FD27F0 VA: 0x181FD3DF0
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1FD4060 Offset: 0x1FD2A60 VA: 0x181FD4060
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x1FD7820 Offset: 0x1FD6220 VA: 0x181FD7820
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1FDCC20 Offset: 0x1FDB620 VA: 0x181FDCC20
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1FD6040 Offset: 0x1FD4A40 VA: 0x181FD6040
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x1FD36B0 Offset: 0x1FD20B0 VA: 0x181FD36B0
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x1FD6C40 Offset: 0x1FD5640 VA: 0x181FD6C40
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x1FD6580 Offset: 0x1FD4F80 VA: 0x181FD6580
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x1FDCCC0 Offset: 0x1FDB6C0 VA: 0x181FDCCC0
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x1FE0100 Offset: 0x1FDEB00 VA: 0x181FE0100
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x1FE0F70 Offset: 0x1FDF970 VA: 0x181FE0F70
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x1FE0D50 Offset: 0x1FDF750 VA: 0x181FE0D50
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x1FD3630 Offset: 0x1FD2030 VA: 0x181FD3630
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x1FDCD30 Offset: 0x1FDB730 VA: 0x181FDCD30
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x1FD96F0 Offset: 0x1FD80F0 VA: 0x181FD96F0
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x1FDB180 Offset: 0x1FD9B80 VA: 0x181FDB180
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1FD89D0 Offset: 0x1FD73D0 VA: 0x181FD89D0
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x1FE0730 Offset: 0x1FDF130 VA: 0x181FE0730
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1FD6240 Offset: 0x1FD4C40 VA: 0x181FD6240
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1FD9930 Offset: 0x1FD8330 VA: 0x181FD9930
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x1FDDC60 Offset: 0x1FDC660 VA: 0x181FDDC60
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB3D0 Offset: 0xEE9DD0 VA: 0x180EEB3D0
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0xEEB950 Offset: 0xEEA350 VA: 0x180EEB950
	|-LightCompiler.CompileIntSwitchExpression<object>
	|
	|-RVA: 0xEEADA0 Offset: 0xEE97A0 VA: 0x180EEADA0
	|-LightCompiler.CompileIntSwitchExpression<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1FDD600 Offset: 0x1FDC000 VA: 0x181FDD600
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x1FD84A0 Offset: 0x1FD6EA0 VA: 0x181FD84A0
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x1FD7A50 Offset: 0x1FD6450 VA: 0x181FD7A50
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x1FE1A70 Offset: 0x1FE0470 VA: 0x181FE1A70
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x1FE1A40 Offset: 0x1FE0440 VA: 0x181FE1A40
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x1FE11E0 Offset: 0x1FDFBE0 VA: 0x181FE11E0
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x1FE1B00 Offset: 0x1FE0500 VA: 0x181FE1B00
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x1FE0AE0 Offset: 0x1FDF4E0 VA: 0x181FE0AE0
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x1FE1E00 Offset: 0x1FE0800 VA: 0x181FE1E00
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x1FE09A0 Offset: 0x1FDF3A0 VA: 0x181FE09A0
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x1FD2A80 Offset: 0x1FD1480 VA: 0x181FD2A80
	private void CheckRethrow() { }

	// RVA: 0x1FDE440 Offset: 0x1FDCE40 VA: 0x181FDE440
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1FDEA60 Offset: 0x1FDD460 VA: 0x181FDEA60
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x1FDF6E0 Offset: 0x1FDE0E0 VA: 0x181FDF6E0
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x1FDB0E0 Offset: 0x1FD9AE0 VA: 0x181FDB0E0
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x1FDABA0 Offset: 0x1FD95A0 VA: 0x181FDABA0
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x1FD3940 Offset: 0x1FD2340 VA: 0x181FD3940
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x1FE0D40 Offset: 0x1FDF740 VA: 0x181FE0D40
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x1FE1C40 Offset: 0x1FE0640 VA: 0x181FE1C40
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x1FD2AE0 Offset: 0x1FD14E0 VA: 0x181FD2AE0
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x1FDB360 Offset: 0x1FD9D60 VA: 0x181FDB360
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x1FDBCE0 Offset: 0x1FDA6E0 VA: 0x181FDBCE0
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x1FDA2A0 Offset: 0x1FD8CA0 VA: 0x181FDA2A0
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x1FDA820 Offset: 0x1FD9220 VA: 0x181FDA820
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x1FDB930 Offset: 0x1FDA330 VA: 0x181FDB930
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x1FD73F0 Offset: 0x1FD5DF0 VA: 0x181FD73F0
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x1FDD160 Offset: 0x1FDBB60 VA: 0x181FDD160
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x1FD8770 Offset: 0x1FD7170 VA: 0x181FD8770
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x1FD5880 Offset: 0x1FD4280 VA: 0x181FD5880
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x1FD8210 Offset: 0x1FD6C10 VA: 0x181FD8210
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x1FD9370 Offset: 0x1FD7D70 VA: 0x181FD9370
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x1FD9400 Offset: 0x1FD7E00 VA: 0x181FD9400
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x1FDA350 Offset: 0x1FD8D50 VA: 0x181FDA350
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x1FDA3E0 Offset: 0x1FD8DE0 VA: 0x181FDA3E0
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x1FE12B0 Offset: 0x1FDFCB0 VA: 0x181FE12B0
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x1FDCE30 Offset: 0x1FDB830 VA: 0x181FDCE30
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x1FE05F0 Offset: 0x1FDEFF0 VA: 0x181FE05F0
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x1FDFC10 Offset: 0x1FDE610 VA: 0x181FDFC10
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x1FDFB60 Offset: 0x1FDE560 VA: 0x181FDFB60
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x1FDFE50 Offset: 0x1FDE850 VA: 0x181FDFE50
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x1FE0980 Offset: 0x1FDF380 VA: 0x181FE0980
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x1FD3C50 Offset: 0x1FD2650 VA: 0x181FD3C50
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x1FDC0C0 Offset: 0x1FDAAC0 VA: 0x181FDC0C0
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x1FE0910 Offset: 0x1FDF310 VA: 0x181FE0910
	private void Compile(Expression expr) { }

	// RVA: 0x1FE21E0 Offset: 0x1FE0BE0 VA: 0x181FE21E0
	private static void .cctor() { }
}
