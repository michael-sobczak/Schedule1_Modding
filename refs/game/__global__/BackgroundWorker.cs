public class BackgroundWorker : Component // TypeDefIndex: 9657
{
	// Fields
	private bool _canCancelWorker; // 0x28
	private bool _workerReportsProgress; // 0x29
	private bool _cancellationPending; // 0x2A
	private bool _isRunning; // 0x2B
	private AsyncOperation _asyncOperation; // 0x30
	private readonly SendOrPostCallback _operationCompleted; // 0x38
	private readonly SendOrPostCallback _progressReporter; // 0x40
	[CompilerGenerated]
	private DoWorkEventHandler DoWork; // 0x48
	[CompilerGenerated]
	private ProgressChangedEventHandler ProgressChanged; // 0x50
	[CompilerGenerated]
	private RunWorkerCompletedEventHandler RunWorkerCompleted; // 0x58

	// Properties
	public bool IsBusy { get; }
	public bool WorkerReportsProgress { get; set; }
	public bool WorkerSupportsCancellation { set; }

	// Methods

	// RVA: 0x2642280 Offset: 0x2640C80 VA: 0x182642280
	public void .ctor() { }

	// RVA: 0x2641A10 Offset: 0x2640410 VA: 0x182641A10
	private void AsyncOperationCompleted(object arg) { }

	[CompilerGenerated]
	// RVA: 0x2642360 Offset: 0x2640D60 VA: 0x182642360
	public void add_DoWork(DoWorkEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2642550 Offset: 0x2640F50 VA: 0x182642550
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x2642540 Offset: 0x2640F40 VA: 0x182642540
	public bool get_IsBusy() { }

	// RVA: 0x2641AA0 Offset: 0x26404A0 VA: 0x182641AA0 Slot: 14
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x206BF30 Offset: 0x206A930 VA: 0x18206BF30 Slot: 15
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x2641AC0 Offset: 0x26404C0 VA: 0x182641AC0 Slot: 16
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	[CompilerGenerated]
	// RVA: 0x2642400 Offset: 0x2640E00 VA: 0x182642400
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x26425F0 Offset: 0x2640FF0 VA: 0x1826425F0
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x2641AE0 Offset: 0x26404E0 VA: 0x182641AE0
	private void ProgressReporter(object arg) { }

	// RVA: 0x2641D50 Offset: 0x2640750 VA: 0x182641D50
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x2641B70 Offset: 0x2640570 VA: 0x182641B70
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x2641D60 Offset: 0x2640760 VA: 0x182641D60
	public void RunWorkerAsync(object argument) { }

	[CompilerGenerated]
	// RVA: 0x26424A0 Offset: 0x2640EA0 VA: 0x1826424A0
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2642690 Offset: 0x2641090 VA: 0x182642690
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x2642060 Offset: 0x2640A60 VA: 0x182642060
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2642050 Offset: 0x2640A50 VA: 0x182642050
	private void <RunWorkerAsync>b__27_0(object arg) { }
}
