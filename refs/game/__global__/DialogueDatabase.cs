public class DialogueDatabase : ScriptableObject // TypeDefIndex: 1587
{
	// Fields
	public List<DialogueModule> Modules; // 0x18
	public List<Entry> GenericEntries; // 0x20
	private DialogueHandler handler; // 0x28

	// Properties
	private List<DialogueModule> runtimeModules { get; }

	// Methods

	// RVA: 0x5303F0 Offset: 0x52EDF0 VA: 0x1805303F0
	private List<DialogueModule> get_runtimeModules() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void Initialize(DialogueHandler _handler) { }

	// RVA: 0x6F02F0 Offset: 0x6EECF0 VA: 0x1806F02F0
	public DialogueModule GetModule(EDialogueModule moduleType) { }

	// RVA: 0x6F0070 Offset: 0x6EEA70 VA: 0x1806F0070
	public DialogueChain GetChain(EDialogueModule moduleType, string key) { }

	// RVA: 0x6F04A0 Offset: 0x6EEEA0 VA: 0x1806F04A0
	public bool HasChain(EDialogueModule moduleType, string key) { }

	// RVA: 0x6F01A0 Offset: 0x6EEBA0 VA: 0x1806F01A0
	public string GetLine(EDialogueModule moduleType, string key) { }

	// RVA: 0x6F05D0 Offset: 0x6EEFD0 VA: 0x1806F05D0
	public void .ctor() { }
}
