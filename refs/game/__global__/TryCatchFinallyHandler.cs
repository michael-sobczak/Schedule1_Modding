internal sealed class TryCatchFinallyHandler // TypeDefIndex: 15410
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal ExceptionHandler[] Handlers { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x1FE2DD0 Offset: 0x1FE17D0 VA: 0x181FE2DD0
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal ExceptionHandler[] get_Handlers() { }

	// RVA: 0x5E0740 Offset: 0x5DF140 VA: 0x1805E0740
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x1FE2D60 Offset: 0x1FE1760 VA: 0x181FE2D60
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x1FE2CF0 Offset: 0x1FE16F0 VA: 0x181FE2CF0
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x1FE2B60 Offset: 0x1FE1560 VA: 0x181FE2B60
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x1FE28E0 Offset: 0x1FE12E0 VA: 0x181FE28E0
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}
