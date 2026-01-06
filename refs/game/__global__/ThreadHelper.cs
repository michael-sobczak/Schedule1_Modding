internal class ThreadHelper // TypeDefIndex: 3972
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(Delegate start) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x1CE5730 Offset: 0x1CE4130 VA: 0x181CE5730
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x1CE5850 Offset: 0x1CE4250 VA: 0x181CE5850
	internal void ThreadStart(object obj) { }

	// RVA: 0x1CE5970 Offset: 0x1CE4370 VA: 0x181CE5970
	internal void ThreadStart() { }

	// RVA: 0x1CE5A80 Offset: 0x1CE4480 VA: 0x181CE5A80
	private static void .cctor() { }
}
