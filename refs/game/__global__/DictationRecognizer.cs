public sealed class DictationRecognizer // TypeDefIndex: 11924
{
	// Fields
	private IntPtr m_Recognizer; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CBBD90 Offset: 0x2CBA790 VA: 0x182CBBD90
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBBDB0 Offset: 0x2CBA7B0 VA: 0x182CBBDB0
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBBD50 Offset: 0x2CBA750 VA: 0x182CBBD50
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBBD70 Offset: 0x2CBA770 VA: 0x182CBBD70
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }
}
