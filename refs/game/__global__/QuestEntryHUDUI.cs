public class QuestEntryHUDUI : MonoBehaviour // TypeDefIndex: 2693
{
	// Fields
	[CompilerGenerated]
	private QuestEntry <QuestEntry>k__BackingField; // 0x20
	[Header("References")]
	public TextMeshProUGUI MainLabel; // 0x28
	public Animation Animation; // 0x30

	// Properties
	public QuestEntry QuestEntry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public QuestEntry get_QuestEntry() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_QuestEntry(QuestEntry value) { }

	// RVA: 0x914AD0 Offset: 0x9134D0 VA: 0x180914AD0
	public void Initialize(QuestEntry entry) { }

	// RVA: 0x914480 Offset: 0x912E80 VA: 0x180914480
	public void Destroy() { }

	// RVA: 0x914DD0 Offset: 0x9137D0 VA: 0x180914DD0 Slot: 4
	public virtual void UpdateUI() { }

	// RVA: 0x914860 Offset: 0x913260 VA: 0x180914860
	private void FadeIn() { }

	// RVA: 0x9146D0 Offset: 0x9130D0 VA: 0x1809146D0
	private void EntryEnded() { }

	// RVA: 0x9149C0 Offset: 0x9133C0 VA: 0x1809149C0
	private void FadeOut() { }

	// RVA: 0x914320 Offset: 0x912D20 VA: 0x180914320
	private void Complete() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[IteratorStateMachine(typeof(QuestEntryHUDUI.<<FadeOut>g__Routine|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x914D60 Offset: 0x913760 VA: 0x180914D60
	private IEnumerator <FadeOut>g__Routine|11_0() { }

	[IteratorStateMachine(typeof(QuestEntryHUDUI.<<Complete>g__Routine|12_0>d))]
	[CompilerGenerated]
	// RVA: 0x914CF0 Offset: 0x9136F0 VA: 0x180914CF0
	private IEnumerator <Complete>g__Routine|12_0() { }
}
