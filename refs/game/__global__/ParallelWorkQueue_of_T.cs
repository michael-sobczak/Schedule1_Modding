public class ParallelWorkQueue<T> // TypeDefIndex: 13408
{
	// Fields
	public Action<T, int> action; // 0x0
	public readonly int threadCount; // 0x0
	private readonly Queue<T> queue; // 0x0
	private readonly int initialCount; // 0x0
	private ManualResetEvent[] waitEvents; // 0x0
	private Exception innerException; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Queue<T> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F17D0 Offset: 0x10F01D0 VA: 0x1810F17D0
	|-ParallelWorkQueue<Int2>..ctor
	|
	|-RVA: 0x10F16E0 Offset: 0x10F00E0 VA: 0x1810F16E0
	|-ParallelWorkQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(ParallelWorkQueue.<Run>d__7<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<int> Run(int progressTimeoutMillis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1500 Offset: 0x10EFF00 VA: 0x1810F1500
	|-ParallelWorkQueue<Int2>.Run
	|
	|-RVA: 0x10F1460 Offset: 0x10EFE60 VA: 0x1810F1460
	|-ParallelWorkQueue<__Il2CppFullySharedGenericType>.Run
	*/

	// RVA: -1 Offset: -1
	private void RunTask(int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0D70 Offset: 0x10EF770 VA: 0x1810F0D70
	|-ParallelWorkQueue<Int2>.RunTask
	|
	|-RVA: 0x10F1060 Offset: 0x10EFA60 VA: 0x1810F1060
	|-ParallelWorkQueue<__Il2CppFullySharedGenericType>.RunTask
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Run>b__7_0(object threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1650 Offset: 0x10F0050 VA: 0x1810F1650
	|-ParallelWorkQueue<Int2>.<Run>b__7_0
	|
	|-RVA: 0x10F15A0 Offset: 0x10EFFA0 VA: 0x1810F15A0
	|-ParallelWorkQueue<__Il2CppFullySharedGenericType>.<Run>b__7_0
	*/
}
