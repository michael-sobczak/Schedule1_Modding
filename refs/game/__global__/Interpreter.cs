internal sealed class Interpreter // TypeDefIndex: 15370
{
	// Fields
	internal static readonly object NoValue; // 0x0
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1FCC7A0 Offset: 0x1FCB1A0 VA: 0x181FCC7A0
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGenerated]
	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	internal int get_LocalCount() { }

	// RVA: 0x1FCC870 Offset: 0x1FCB270 VA: 0x181FCC870
	internal int get_ClosureSize() { }

	// RVA: 0x166C600 Offset: 0x166B000 VA: 0x18166C600
	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1FCC6B0 Offset: 0x1FCB0B0 VA: 0x181FCC6B0
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x1FCC720 Offset: 0x1FCB120 VA: 0x181FCC720
	private static void .cctor() { }
}
