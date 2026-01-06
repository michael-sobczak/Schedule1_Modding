public class TransformMonitor // TypeDefIndex: 10508
{
	// Fields
	[NotNull]
	private readonly Transform transform; // 0x10
	private Vector3 lastCheckedPosition; // 0x18
	private Quaternion lastCheckedRotation; // 0x24
	private Vector3 lastCheckedScale; // 0x34
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x40
	private readonly bool monitorPosition; // 0x41
	private readonly bool monitorRotation; // 0x42
	private readonly bool monitorScale; // 0x43

	// Properties
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	private void set_HasChanged(bool value) { }

	// RVA: 0x4BC610 Offset: 0x4BB010 VA: 0x1804BC610
	public void .ctor(Transform transformToTrack, bool monitorPosition, bool monitorRotation, bool monitorScale) { }

	// RVA: 0x4BC600 Offset: 0x4BB000 VA: 0x1804BC600
	public void ResetMonitoring() { }

	// RVA: 0x4BC2C0 Offset: 0x4BACC0 VA: 0x1804BC2C0
	public bool CheckForChanges() { }

	// RVA: 0x4BC450 Offset: 0x4BAE50 VA: 0x1804BC450
	private bool HaveGlobalCoordinatesChanged() { }

	// RVA: 0x4BC580 Offset: 0x4BAF80 VA: 0x1804BC580
	private void MarkCurrentTransformAsChecked() { }
}
