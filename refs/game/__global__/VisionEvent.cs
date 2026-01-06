public class VisionEvent // TypeDefIndex: 836
{
	// Fields
	private const float NOTICE_DROP_THRESHOLD = 1;
	[CompilerGenerated]
	private ISightable <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private EntityVisualState <State>k__BackingField; // 0x18
	[CompilerGenerated]
	private VisionCone <Owner>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <FullNoticeTime>k__BackingField; // 0x28
	private float timeSinceSighted; // 0x2C
	private float currentNoticeTime; // 0x30
	public bool playTremolo; // 0x34

	// Properties
	public ISightable Target { get; set; }
	public EntityVisualState State { get; set; }
	public VisionCone Owner { get; set; }
	public float FullNoticeTime { get; set; }
	public float NormalizedNoticeLevel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ISightable get_Target() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Target(ISightable value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public EntityVisualState get_State() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	protected void set_State(EntityVisualState value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public VisionCone get_Owner() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Owner(VisionCone value) { }

	[CompilerGenerated]
	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_FullNoticeTime() { }

	[CompilerGenerated]
	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	protected void set_FullNoticeTime(float value) { }

	// RVA: 0x5BC160 Offset: 0x5BAB60 VA: 0x1805BC160
	public float get_NormalizedNoticeLevel() { }

	// RVA: 0x5BC000 Offset: 0x5BAA00 VA: 0x1805BC000
	public void .ctor(VisionCone _owner, ISightable _target, EntityVisualState _state, float _noticeTime, bool _playTremolo) { }

	// RVA: 0x5BBC80 Offset: 0x5BA680 VA: 0x1805BBC80
	public void UpdateEvent(float visionDeltaThisFrame, float tickTime) { }

	// RVA: 0x5BBBF0 Offset: 0x5BA5F0 VA: 0x1805BBBF0
	public void EndEvent() { }
}
