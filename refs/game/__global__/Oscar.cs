public class Oscar : NPC // TypeDefIndex: 1744
{
	// Fields
	public ShopInterface ShopInterface; // 0x2F0
	[Header("Settings")]
	public string[] OrderCompletedLines; // 0x2F8
	public DialogueContainer GreetingDialogue; // 0x300
	public string GreetedVariable; // 0x308
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted; // 0x310
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.OscarAssembly-CSharp.dll_Excuted; // 0x311

	// Methods

	// RVA: 0x741AF0 Offset: 0x7404F0 VA: 0x180741AF0 Slot: 71
	protected override void Start() { }

	// RVA: 0x71A9B0 Offset: 0x7193B0 VA: 0x18071A9B0
	private void OrderCompleted() { }

	// RVA: 0x741740 Offset: 0x740140 VA: 0x180741740
	private void Loaded() { }

	// RVA: 0x741660 Offset: 0x740060 VA: 0x180741660
	private void EnableGreeting() { }

	// RVA: 0x741960 Offset: 0x740360 VA: 0x180741960
	private void SetGreeted() { }

	// RVA: 0x741570 Offset: 0x73FF70 VA: 0x180741570
	public void EnableDeliveries() { }

	// RVA: 0x741CB0 Offset: 0x7406B0 VA: 0x180741CB0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(Oscar.<<EnableDeliveries>g__Wait|9_0>d))]
	// RVA: 0x741C40 Offset: 0x740640 VA: 0x180741C40
	private IEnumerator <EnableDeliveries>g__Wait|9_0() { }

	// RVA: 0x7190A0 Offset: 0x717AA0 VA: 0x1807190A0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71BB20 Offset: 0x71A520 VA: 0x18071BB20 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
