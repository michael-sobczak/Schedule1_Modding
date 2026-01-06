public class CasinoGameController : NetworkBehaviour // TypeDefIndex: 2024
{
	// Fields
	public const float FOV = 65;
	public const float CAMERA_LERP_TIME = 0.2;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x118
	[Header("References")]
	public CasinoGamePlayers Players; // 0x120
	public CasinoGameInteraction Interaction; // 0x128
	public Transform[] DefaultCameraTransforms; // 0x130
	protected Transform localDefaultCameraTransform; // 0x138
	private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted; // 0x141

	// Properties
	public bool IsOpen { get; set; }
	public CasinoGamePlayerData LocalPlayerData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	private void set_IsOpen(bool value) { }

	// RVA: 0x7CA490 Offset: 0x7C8E90 VA: 0x1807CA490
	public CasinoGamePlayerData get_LocalPlayerData() { }

	// RVA: 0x7C9880 Offset: 0x7C8280 VA: 0x1807C9880 Slot: 19
	public override void Awake() { }

	// RVA: 0x7C9EE0 Offset: 0x7C88E0 VA: 0x1807C9EE0 Slot: 20
	protected virtual void OnLocalPlayerRequestJoin(Player player) { }

	// RVA: 0x7C9E40 Offset: 0x7C8840 VA: 0x1807C9E40 Slot: 21
	protected virtual void Exit(ExitAction action) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	protected virtual void FixedUpdate() { }

	// RVA: 0x7C9F00 Offset: 0x7C8900 VA: 0x1807C9F00 Slot: 23
	protected virtual void Open() { }

	// RVA: 0x7C9A10 Offset: 0x7C8410 VA: 0x1807C9A10 Slot: 24
	protected virtual void Close() { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0x7C9EC0 Offset: 0x7C88C0 VA: 0x1807C9EC0 Slot: 25
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7C9EA0 Offset: 0x7C88A0 VA: 0x1807C9EA0 Slot: 26
	public override void NetworkInitialize__Late() { }

	// RVA: 0x703DD0 Offset: 0x7027D0 VA: 0x180703DD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7C9720 Offset: 0x7C8120 VA: 0x1807C9720 Slot: 27
	protected virtual void Awake_UserLogic_ScheduleOne.Casino.CasinoGameController_Assembly-CSharp.dll() { }
}
