internal sealed class CinemachineMixer : PlayableBehaviour // TypeDefIndex: 16030
{
	// Fields
	public static CinemachineMixer.MasterDirectorDelegate GetMasterPlayableDirector; // 0x0
	private ICameraOverrideStack m_BrainOverrideStack; // 0x10
	private int m_BrainOverrideId; // 0x18
	private bool m_PreviewPlay; // 0x1C

	// Methods

	// RVA: 0xBF0660 Offset: 0xBEF060 VA: 0x180BF0660 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0xBF0730 Offset: 0xBEF130 VA: 0x180BF0730 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0xBF0740 Offset: 0xBEF140 VA: 0x180BF0740 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0xBF05A0 Offset: 0xBEEFA0 VA: 0x180BF05A0
	private float GetDeltaTime(float deltaTime) { }

	// RVA: 0xBF0E80 Offset: 0xBEF880 VA: 0x180BF0E80
	public void .ctor() { }
}
