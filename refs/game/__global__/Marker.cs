public abstract class Marker : ScriptableObject, IMarker // TypeDefIndex: 17415
{
	// Fields
	[TimeField(1)]
	[SerializeField]
	[Tooltip("Time for the marker")]
	private double m_Time; // 0x18
	[CompilerGenerated]
	private TrackAsset <parent>k__BackingField; // 0x20

	// Properties
	public TrackAsset parent { get; set; }
	public double time { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 6
	public TrackAsset get_parent() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_parent(TrackAsset value) { }

	// RVA: 0x18A4000 Offset: 0x18A2A00 VA: 0x1818A4000 Slot: 4
	public double get_time() { }

	// RVA: 0x2C490C0 Offset: 0x2C47AC0 VA: 0x182C490C0 Slot: 5
	public void set_time(double value) { }

	// RVA: 0x2C48FD0 Offset: 0x2C479D0 VA: 0x182C48FD0 Slot: 7
	private void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void OnInitialize(TrackAsset aPent) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
