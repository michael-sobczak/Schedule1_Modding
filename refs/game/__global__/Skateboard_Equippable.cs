public class Skateboard_Equippable : Equippable_Viewmodel // TypeDefIndex: 683
{
	// Fields
	public const float ModelLerpSpeed = 8;
	public const float SurfaceSampleDistance = 0.4;
	public const float SurfaceSampleRayLength = 0.7;
	public const float BoardSpawnUpwardsShift = 0.05;
	public const float BoardSpawnAngleLimit = 30;
	public const float MountTime = 0.33;
	public const float BoardMomentumTransfer = 1.2;
	public const float DismountAngle = 80;
	[CompilerGenerated]
	private bool <IsRiding>k__BackingField; // 0x60
	[CompilerGenerated]
	private Skateboard <ActiveSkateboard>k__BackingField; // 0x68
	public Skateboard SkateboardPrefab; // 0x70
	public bool blockDismount; // 0x78
	[Header("References")]
	public Transform ModelContainer; // 0x80
	public Transform ModelPosition_Raised; // 0x88
	public Transform ModelPosition_Lowered; // 0x90
	private float mountTime; // 0x98

	// Properties
	public bool IsRiding { get; set; }
	public Skateboard ActiveSkateboard { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_IsRiding() { }

	[CompilerGenerated]
	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	private void set_IsRiding(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Skateboard get_ActiveSkateboard() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_ActiveSkateboard(Skateboard value) { }

	// RVA: 0xAC5380 Offset: 0xAC3D80 VA: 0x180AC5380 Slot: 4
	public override void Equip(ItemInstance item) { }

	// RVA: 0xAC54A0 Offset: 0xAC3EA0 VA: 0x180AC54A0
	private void Exit(ExitAction action) { }

	// RVA: 0xAC64F0 Offset: 0xAC4EF0 VA: 0x180AC64F0 Slot: 6
	protected override void Update() { }

	// RVA: 0xAC63D0 Offset: 0xAC4DD0 VA: 0x180AC63D0
	private void UpdateModel() { }

	// RVA: 0xAC62C0 Offset: 0xAC4CC0 VA: 0x180AC62C0 Slot: 5
	public override void Unequip() { }

	// RVA: 0xAC5F60 Offset: 0xAC4960 VA: 0x180AC5F60
	public void Mount() { }

	// RVA: 0xAC4F50 Offset: 0xAC3950 VA: 0x180AC4F50
	public void Dismount() { }

	// RVA: 0xAC4E60 Offset: 0xAC3860 VA: 0x180AC4E60
	private bool CanMountHere() { }

	// RVA: 0xAC54F0 Offset: 0xAC3EF0 VA: 0x180AC54F0
	private Pose GetSkateboardSpawnPose() { }

	// RVA: 0x840740 Offset: 0x83F140 VA: 0x180840740
	public void .ctor() { }
}
