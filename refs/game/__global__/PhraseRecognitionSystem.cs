public static class PhraseRecognitionSystem // TypeDefIndex: 11917
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CC2950 Offset: 0x2CC1350 VA: 0x182CC2950
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC29B0 Offset: 0x2CC13B0 VA: 0x182CC29B0
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }
}
