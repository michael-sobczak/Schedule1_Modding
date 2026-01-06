public class EFConfig : ScriptableObject // TypeDefIndex: 17975
{
	// Fields
	[Tooltip("Save feedback locally, instead of sending it to Trello")]
	public bool StoreLocal; // 0x18
	public string Token; // 0x20
	public FeedbackBoard Board; // 0x28

	// Methods

	// RVA: 0x43D5F0 Offset: 0x43BFF0 VA: 0x18043D5F0
	public void .ctor() { }
}
