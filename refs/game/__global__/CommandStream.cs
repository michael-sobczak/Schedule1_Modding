internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 9940
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected CommandStream.PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties
	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x269C010 Offset: 0x269AA10 VA: 0x18269C010
	internal void .ctor(TcpClient client) { }

	// RVA: 0x269A3D0 Offset: 0x2698DD0 VA: 0x18269A3D0 Slot: 40
	internal virtual void Abort(Exception e) { }

	// RVA: 0x269AB10 Offset: 0x2699510 VA: 0x18269AB10 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x269AE30 Offset: 0x2699830 VA: 0x18269AE30
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	internal bool get_RecoverableFailure() { }

	// RVA: 0x269AEB0 Offset: 0x26998B0 VA: 0x18269AEB0
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x269BCF0 Offset: 0x269A6F0 VA: 0x18269BCF0
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x269A610 Offset: 0x2699010 VA: 0x18269A610 Slot: 41
	protected virtual void ClearState() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 42
	protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x269ACF0 Offset: 0x26996F0 VA: 0x18269ACF0
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x269AC40 Offset: 0x2699640 VA: 0x18269AC40
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x269AD70 Offset: 0x2699770 VA: 0x18269AD70
	protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x269A5D0 Offset: 0x2698FD0 VA: 0x18269A5D0
	internal void CheckContinuePipeline() { }

	// RVA: 0x269A630 Offset: 0x2699030 VA: 0x18269A630
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x269B0E0 Offset: 0x2699AE0 VA: 0x18269B0E0
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x269AEC0 Offset: 0x26998C0 VA: 0x18269AEC0
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 43
	protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x269B1D0 Offset: 0x2699BD0 VA: 0x18269B1D0
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x269BD90 Offset: 0x269A790 VA: 0x18269BD90
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	protected Encoding get_Encoding() { }

	// RVA: 0x269C0D0 Offset: 0x269AAD0 VA: 0x18269C0D0
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 44
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x269B9B0 Offset: 0x269A3B0 VA: 0x18269B9B0
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x269B380 Offset: 0x2699D80 VA: 0x18269B380
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x269BF20 Offset: 0x269A920 VA: 0x18269BF20
	private static void .cctor() { }
}
