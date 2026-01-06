public class StackTrace // TypeDefIndex: 4873
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private const string prefix = "  at ";
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x1C061F0 Offset: 0x1C04BF0 VA: 0x181C061F0
	public void .ctor() { }

	// RVA: 0x1C05FA0 Offset: 0x1C049A0 VA: 0x181C05FA0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x1C06100 Offset: 0x1C04B00 VA: 0x181C06100
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1C06250 Offset: 0x1C04C50 VA: 0x181C06250
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1C06240 Offset: 0x1C04C40 VA: 0x181C06240
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1C06140 Offset: 0x1C04B40 VA: 0x181C06140
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x1C05FE0 Offset: 0x1C049E0 VA: 0x181C05FE0
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1C06220 Offset: 0x1C04C20 VA: 0x181C06220 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x1C056B0 Offset: 0x1C040B0 VA: 0x181C056B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x1C055C0 Offset: 0x1C03FC0 VA: 0x181C055C0
	private static string GetAotId() { }

	// RVA: 0x1C04DB0 Offset: 0x1C037B0 VA: 0x181C04DB0
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	// RVA: 0x1C05720 Offset: 0x1C04120 VA: 0x181C05720
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	// RVA: 0x1C052E0 Offset: 0x1C03CE0 VA: 0x181C052E0
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	// RVA: 0x1C05E00 Offset: 0x1C04800 VA: 0x181C05E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C05F80 Offset: 0x1C04980 VA: 0x181C05F80
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}
