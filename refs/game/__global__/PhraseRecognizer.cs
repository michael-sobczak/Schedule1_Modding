public abstract class PhraseRecognizer // TypeDefIndex: 11919
{
	// Fields
	protected IntPtr m_Recognizer; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CC2A70 Offset: 0x2CC1470 VA: 0x182CC2A70
	private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC2BD0 Offset: 0x2CC15D0 VA: 0x182CC2BD0
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }
}
