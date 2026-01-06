public class PrefabControlPlayable : PlayableBehaviour // TypeDefIndex: 17435
{
	// Fields
	private GameObject m_Instance; // 0x10

	// Properties
	public GameObject prefabInstance { get; }

	// Methods

	// RVA: 0x2C5AAF0 Offset: 0x2C594F0 VA: 0x182C5AAF0
	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public GameObject get_prefabInstance() { }

	// RVA: 0x2C5AC40 Offset: 0x2C59640 VA: 0x182C5AC40
	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0x2C5B040 Offset: 0x2C59A40 VA: 0x182C5B040 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x2C5AFC0 Offset: 0x2C599C0 VA: 0x182C5AFC0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2C5AF20 Offset: 0x2C59920 VA: 0x182C5AF20 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2C5B110 Offset: 0x2C59B10 VA: 0x182C5B110
	private static void SetHideFlagsRecursive(GameObject gameObject) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
