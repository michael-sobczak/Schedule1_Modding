public class Stan : NPC // TypeDefIndex: 1630
{
	// Fields
	public ShopInterface ShopInterface; // 0x2F0
	public DialogueContainer GreetingDialogue; // 0x2F8
	public string GreetedVariable; // 0x300
	[Header("Settings")]
	public string[] OrderCompletedLines; // 0x308
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted; // 0x310
	private bool NetworkInitialize__LateScheduleOne.NPCs.StanAssembly-CSharp.dll_Excuted; // 0x311

	// Methods

	// RVA: 0x719300 Offset: 0x717D00 VA: 0x180719300 Slot: 71
	protected override void Start() { }

	// RVA: 0x718E20 Offset: 0x717820 VA: 0x180718E20
	private void Loaded() { }

	// RVA: 0x718D40 Offset: 0x717740 VA: 0x180718D40
	private void EnableGreeting() { }

	// RVA: 0x719170 Offset: 0x717B70 VA: 0x180719170
	private void SetGreeted() { }

	// RVA: 0x7190C0 Offset: 0x717AC0 VA: 0x1807190C0
	private void OrderCompleted() { }

	// RVA: 0x719450 Offset: 0x717E50 VA: 0x180719450
	public void .ctor() { }

	// RVA: 0x7190A0 Offset: 0x717AA0 VA: 0x1807190A0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x719040 Offset: 0x717A40 VA: 0x180719040 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x701630 Offset: 0x700030 VA: 0x180701630 Slot: 65
	public override void Awake() { }
}
