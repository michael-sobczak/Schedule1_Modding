public class Dumpster : GridItem // TypeDefIndex: 3281
{
	// Fields
	public static float capacity; // 0x0
	[SerializeField]
	[Header("References")]
	protected InteractableObject lid_IntObj; // 0x210
	[SerializeField]
	protected InteractableObject inner_IntObj; // 0x218
	[SerializeField]
	protected Transform lid; // 0x220
	[SerializeField]
	protected Transform trash; // 0x228
	public Transform standPoint; // 0x230
	[SerializeField]
	[Header("Settings")]
	protected float trash_MinY; // 0x238
	[SerializeField]
	protected float trash_MaxY; // 0x23C
	[CompilerGenerated]
	private bool <lidOpen>k__BackingField; // 0x240
	[CompilerGenerated]
	private float <currentTrashLevel>k__BackingField; // 0x244
	private float lid_CurrentAngle; // 0x248
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted; // 0x24C
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted; // 0x24D

	// Properties
	public bool lidOpen { get; set; }
	public float currentTrashLevel { get; set; }
	public bool isFull { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA316F0 Offset: 0xA300F0 VA: 0x180A316F0
	public bool get_lidOpen() { }

	[CompilerGenerated]
	// RVA: 0xA31710 Offset: 0xA30110 VA: 0x180A31710
	protected void set_lidOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA31670 Offset: 0xA30070 VA: 0x180A31670
	public float get_currentTrashLevel() { }

	[CompilerGenerated]
	// RVA: 0xA31700 Offset: 0xA30100 VA: 0x180A31700
	protected void set_currentTrashLevel(float value) { }

	// RVA: 0xA31680 Offset: 0xA30080 VA: 0x180A31680
	public bool get_isFull() { }

	// RVA: 0xA31530 Offset: 0xA2FF30 VA: 0x180A31530 Slot: 71
	protected virtual void Update() { }

	// RVA: 0xA31170 Offset: 0xA2FB70 VA: 0x180A31170 Slot: 72
	public virtual void Lid_Hovered() { }

	// RVA: 0xA31200 Offset: 0xA2FC00 VA: 0x180A31200 Slot: 73
	public virtual void Lid_Interacted() { }

	// RVA: 0xA31040 Offset: 0xA2FA40 VA: 0x180A31040
	protected bool DoesPlayerHaveBinEquipped() { }

	// RVA: 0xA30E90 Offset: 0xA2F890 VA: 0x180A30E90
	public void ChangeTrashLevel(float change) { }

	// RVA: 0xA31260 Offset: 0xA2FC60 VA: 0x180A31260
	public void SetTrashLevel(float trashLevel) { }

	// RVA: 0xA31400 Offset: 0xA2FE00 VA: 0x180A31400
	private void UpdateTrashVisuals() { }

	// RVA: 0xA30E10 Offset: 0xA2F810 VA: 0x180A30E10 Slot: 55
	public override bool CanBeDestroyed(out string reason) { }

	// RVA: 0x9CC3C0 Offset: 0x9CADC0 VA: 0x1809CC3C0
	public void .ctor() { }

	// RVA: 0xA31630 Offset: 0xA30030 VA: 0x180A31630
	private static void .cctor() { }

	// RVA: 0xA31240 Offset: 0xA2FC40 VA: 0x180A31240 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA31220 Offset: 0xA2FC20 VA: 0x180A31220 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x873B40 Offset: 0x872540 VA: 0x180873B40 Slot: 47
	public override void Awake() { }
}
