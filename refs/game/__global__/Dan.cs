public class Dan : NPC // TypeDefIndex: 1695
{
	// Fields
	public ShopInterface ShopInterface; // 0x2F0
	[Header("Settings")]
	public string[] OrderCompletedLines; // 0x2F8
	public UnityEvent onGreeting; // 0x300
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted; // 0x308
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted; // 0x309

	// Methods

	// RVA: 0x71A2E0 Offset: 0x718CE0 VA: 0x18071A2E0 Slot: 71
	protected override void Start() { }

	// RVA: 0x71A0D0 Offset: 0x718AD0 VA: 0x18071A0D0
	private void OrderCompleted() { }

	// RVA: 0x701620 Offset: 0x700020 VA: 0x180701620
	public void .ctor() { }

	// RVA: 0x701450 Offset: 0x6FFE50 VA: 0x180701450 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71A0B0 Offset: 0x718AB0 VA: 0x18071A0B0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
