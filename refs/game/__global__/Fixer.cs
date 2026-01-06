public class Fixer : NPC // TypeDefIndex: 1701
{
	// Fields
	public const int ADDITIONAL_SIGNING_FEE_1 = 100;
	public const int ADDITIONAL_SIGNING_FEE_2 = 250;
	public const int MAX_SIGNING_FEE = 500;
	public const int ADDITIONAL_FEE_THRESHOLD = 5;
	public DialogueContainer GreetingDialogue; // 0x2F0
	public string GreetedVariable; // 0x2F8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted; // 0x300
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted; // 0x301

	// Methods

	// RVA: 0x71B2F0 Offset: 0x719CF0 VA: 0x18071B2F0 Slot: 71
	protected override void Start() { }

	// RVA: 0x71AF40 Offset: 0x719940 VA: 0x18071AF40
	private void Loaded() { }

	// RVA: 0x71ABE0 Offset: 0x7195E0 VA: 0x18071ABE0
	private void EnableGreeting() { }

	// RVA: 0x71B160 Offset: 0x719B60 VA: 0x18071B160
	private void SetGreeted() { }

	// RVA: 0x71ACC0 Offset: 0x7196C0 VA: 0x18071ACC0
	public static float GetAdditionalSigningFee() { }

	// RVA: 0x71B3E0 Offset: 0x719DE0 VA: 0x18071B3E0
	public void .ctor() { }

	// RVA: 0x71A990 Offset: 0x719390 VA: 0x18071A990 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71A970 Offset: 0x719370 VA: 0x18071A970 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
