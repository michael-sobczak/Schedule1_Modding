public class DialogueModule : MonoBehaviour // TypeDefIndex: 1609
{
	// Fields
	public EDialogueModule ModuleType; // 0x20
	public List<Entry> Entries; // 0x28

	// Methods

	// RVA: 0x7020C0 Offset: 0x700AC0 VA: 0x1807020C0
	public Entry GetEntry(string key) { }

	// RVA: 0x702000 Offset: 0x700A00 VA: 0x180702000
	public DialogueChain GetChain(string key) { }

	// RVA: 0x7022B0 Offset: 0x700CB0 VA: 0x1807022B0
	public bool HasChain(string key) { }

	// RVA: 0x7021C0 Offset: 0x700BC0 VA: 0x1807021C0
	public string GetLine(string key) { }

	// RVA: 0x7022E0 Offset: 0x700CE0 VA: 0x1807022E0
	public void .ctor() { }
}
