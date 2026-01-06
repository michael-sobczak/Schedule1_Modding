public class Aim : NetworkBehaviour // TypeDefIndex: 18106
{
	// Fields
	[CompilerGenerated]
	private PlayerCamera <PlayerCamera>k__BackingField; // 0x118
	private readonly Vector3 _offset; // 0x120
	private bool NetworkInitialize___EarlyFishNet.Example.ColliderRollbacks.AimFishNet.Demos.dll_Excuted; // 0x12C
	private bool NetworkInitialize__LateFishNet.Example.ColliderRollbacks.AimFishNet.Demos.dll_Excuted; // 0x12D

	// Properties
	public PlayerCamera PlayerCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public PlayerCamera get_PlayerCamera() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_PlayerCamera(PlayerCamera value) { }

	// RVA: 0xCE4BA0 Offset: 0xCE35A0 VA: 0x180CE4BA0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xCE4C30 Offset: 0xCE3630 VA: 0x180CE4C30
	private void Update() { }

	// RVA: 0xCE47E0 Offset: 0xCE31E0 VA: 0x180CE47E0
	private void MoveAim() { }

	// RVA: 0xCE4990 Offset: 0xCE3390 VA: 0x180CE4990
	private void MoveCamera() { }

	// RVA: 0xCE4CD0 Offset: 0xCE36D0 VA: 0x180CE4CD0
	public void .ctor() { }

	// RVA: 0xCE4B80 Offset: 0xCE3580 VA: 0x180CE4B80 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCE4B60 Offset: 0xCE3560 VA: 0x180CE4B60 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
