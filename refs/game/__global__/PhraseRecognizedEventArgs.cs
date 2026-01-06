public struct PhraseRecognizedEventArgs // TypeDefIndex: 11930
{
	// Fields
	public readonly ConfidenceLevel confidence; // 0x0
	public readonly SemanticMeaning[] semanticMeanings; // 0x8
	public readonly string text; // 0x10
	public readonly DateTime phraseStartTime; // 0x18
	public readonly TimeSpan phraseDuration; // 0x20

	// Methods

	// RVA: 0x2CC2A10 Offset: 0x2CC1410 VA: 0x182CC2A10
	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }
}
