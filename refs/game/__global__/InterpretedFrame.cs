internal sealed class InterpretedFrame // TypeDefIndex: 15369
{
	// Fields
	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x1FCC570 Offset: 0x1FCAF70 VA: 0x181FCC570
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x1FCB470 Offset: 0x1FC9E70 VA: 0x181FCB470
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x1FCC690 Offset: 0x1FCB090 VA: 0x181FCC690
	public string get_Name() { }

	// RVA: 0x1FCBAC0 Offset: 0x1FCA4C0 VA: 0x181FCBAC0
	public void Push(object value) { }

	// RVA: 0x1FCBE50 Offset: 0x1FCA850 VA: 0x181FCBE50
	public void Push(bool value) { }

	// RVA: 0x1FCBDC0 Offset: 0x1FCA7C0 VA: 0x181FCBDC0
	public void Push(int value) { }

	// RVA: 0x1FCBC20 Offset: 0x1FCA620 VA: 0x181FCBC20
	public void Push(byte value) { }

	// RVA: 0x1FCBCF0 Offset: 0x1FCA6F0 VA: 0x181FCBCF0
	public void Push(sbyte value) { }

	// RVA: 0x1FCBB50 Offset: 0x1FCA550 VA: 0x181FCBB50
	public void Push(short value) { }

	// RVA: 0x1FCBF50 Offset: 0x1FCA950 VA: 0x181FCBF50
	public void Push(ushort value) { }

	// RVA: 0x1FCB940 Offset: 0x1FCA340 VA: 0x181FCB940
	public object Pop() { }

	// RVA: 0x1FCC2E0 Offset: 0x1FCACE0 VA: 0x181FCC2E0
	internal void SetStackDepth(int depth) { }

	// RVA: 0x1FCB850 Offset: 0x1FCA250 VA: 0x181FCB850
	public object Peek() { }

	// RVA: 0x1FCB350 Offset: 0x1FC9D50 VA: 0x181FCB350
	public void Dup() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachine(typeof(InterpretedFrame.<GetStackTraceDebugInfo>d__29))]
	// RVA: 0x1FCB5A0 Offset: 0x1FC9FA0 VA: 0x181FCB5A0
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x1FCC020 Offset: 0x1FCAA20 VA: 0x181FCC020
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x1FCB3F0 Offset: 0x1FC9DF0 VA: 0x181FCB3F0
	internal InterpretedFrame Enter() { }

	// RVA: 0x1FCB800 Offset: 0x1FCA200 VA: 0x181FCB800
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x1FCB7F0 Offset: 0x1FCA1F0 VA: 0x181FCB7F0
	internal bool IsJumpHappened() { }

	// RVA: 0x127AC90 Offset: 0x1279690 VA: 0x18127AC90
	public void RemoveContinuation() { }

	// RVA: 0x1FCB980 Offset: 0x1FCA380 VA: 0x181FCB980
	public void PushContinuation(int continuation) { }

	// RVA: 0x1FCC300 Offset: 0x1FCAD00 VA: 0x181FCC300
	public int YieldToCurrentContinuation() { }

	// RVA: 0x1FCC380 Offset: 0x1FCAD80 VA: 0x181FCC380
	public int YieldToPendingContinuation() { }

	// RVA: 0x1FCB9C0 Offset: 0x1FCA3C0 VA: 0x181FCB9C0
	internal void PushPendingContinuation() { }

	// RVA: 0x1FCB880 Offset: 0x1FCA280 VA: 0x181FCB880
	internal void PopPendingContinuation() { }

	// RVA: 0x1FCB620 Offset: 0x1FCA020 VA: 0x181FCB620
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}
