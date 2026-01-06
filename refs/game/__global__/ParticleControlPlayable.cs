public class ParticleControlPlayable : PlayableBehaviour // TypeDefIndex: 17434
{
	// Fields
	private const float kUnsetTime = 3.4028235E+38;
	private float m_LastPlayableTime; // 0x10
	private float m_LastParticleTime; // 0x14
	private uint m_RandomSeed; // 0x18
	[CompilerGenerated]
	private ParticleSystem <particleSystem>k__BackingField; // 0x20

	// Properties
	public ParticleSystem particleSystem { get; set; }

	// Methods

	// RVA: 0x2C5A320 Offset: 0x2C58D20 VA: 0x182C5A320
	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ParticleSystem get_particleSystem() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_particleSystem(ParticleSystem value) { }

	// RVA: 0x2C5A4D0 Offset: 0x2C58ED0 VA: 0x182C5A4D0
	public void Initialize(ParticleSystem ps, uint randomSeed) { }

	// RVA: 0x2C5A7C0 Offset: 0x2C591C0 VA: 0x182C5A7C0
	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) { }

	// RVA: 0x2C5A570 Offset: 0x2C58F70 VA: 0x182C5A570 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData data) { }

	// RVA: 0x2C5A560 Offset: 0x2C58F60 VA: 0x182C5A560 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2C5A560 Offset: 0x2C58F60 VA: 0x182C5A560 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2C5A8E0 Offset: 0x2C592E0 VA: 0x182C5A8E0
	private void Simulate(float time, bool restart) { }

	// RVA: 0x2C5A9C0 Offset: 0x2C593C0 VA: 0x182C5A9C0
	public void .ctor() { }
}
