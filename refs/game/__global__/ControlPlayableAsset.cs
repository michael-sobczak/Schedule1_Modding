public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 17401
{
	// Fields
	private const int k_MaxRandInt = 10000;
	private static readonly List<PlayableDirector> k_EmptyDirectorsList; // 0x0
	private static readonly List<ParticleSystem> k_EmptyParticlesList; // 0x8
	private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; // 0x10
	[SerializeField]
	public ExposedReference<GameObject> sourceGameObject; // 0x18
	[SerializeField]
	public GameObject prefabGameObject; // 0x28
	[SerializeField]
	public bool updateParticle; // 0x30
	[SerializeField]
	public uint particleRandomSeed; // 0x34
	[SerializeField]
	public bool updateDirector; // 0x38
	[SerializeField]
	public bool updateITimeControl; // 0x39
	[SerializeField]
	public bool searchHierarchy; // 0x3A
	[SerializeField]
	public bool active; // 0x3B
	[SerializeField]
	public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x3C
	private PlayableAsset m_ControlDirectorAsset; // 0x40
	private double m_Duration; // 0x48
	private bool m_SupportLoop; // 0x50
	private static HashSet<PlayableDirector> s_ProcessedDirectors; // 0x18
	private static HashSet<GameObject> s_CreatedPrefabs; // 0x20
	[CompilerGenerated]
	private bool <controllingDirectors>k__BackingField; // 0x51
	[CompilerGenerated]
	private bool <controllingParticles>k__BackingField; // 0x52

	// Properties
	internal bool controllingDirectors { get; set; }
	internal bool controllingParticles { get; set; }
	public override double duration { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	internal bool get_controllingDirectors() { }

	[CompilerGenerated]
	// RVA: 0x605240 Offset: 0x603C40 VA: 0x180605240
	private void set_controllingDirectors(bool value) { }

	[CompilerGenerated]
	// RVA: 0x605160 Offset: 0x603B60 VA: 0x180605160
	internal bool get_controllingParticles() { }

	[CompilerGenerated]
	// RVA: 0x6051E0 Offset: 0x603BE0 VA: 0x1806051E0
	private void set_controllingParticles(bool value) { }

	// RVA: 0x2C43C60 Offset: 0x2C42660 VA: 0x182C43C60
	public void OnEnable() { }

	// RVA: 0x2C45A60 Offset: 0x2C44460 VA: 0x182C45A60 Slot: 7
	public override double get_duration() { }

	// RVA: 0x2C45A50 Offset: 0x2C44450 VA: 0x182C45A50 Slot: 10
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2C428E0 Offset: 0x2C412E0 VA: 0x182C428E0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x2C42460 Offset: 0x2C40E60 VA: 0x182C42460
	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) { }

	// RVA: 0x2C42670 Offset: 0x2C41070 VA: 0x182C42670
	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x2C44DC0 Offset: 0x2C437C0 VA: 0x182C44DC0
	private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x2C44A30 Offset: 0x2C43430 VA: 0x182C44A30
	private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) { }

	// RVA: 0x2C44730 Offset: 0x2C43130 VA: 0x182C44730
	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x2C423A0 Offset: 0x2C40DA0 VA: 0x182C423A0
	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) { }

	// RVA: -1 Offset: -1
	internal IList<T> GetComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B0E0 Offset: 0xE69AE0 VA: 0x180E6B0E0
	|-ControlPlayableAsset.GetComponent<object>
	|
	|-RVA: 0xE6AFF0 Offset: 0xE699F0 VA: 0x180E6AFF0
	|-ControlPlayableAsset.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ControlPlayableAsset.<GetControlableScripts>d__39))]
	// RVA: 0x2C437C0 Offset: 0x2C421C0 VA: 0x182C437C0
	internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) { }

	// RVA: 0x2C450D0 Offset: 0x2C43AD0 VA: 0x182C450D0
	internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) { }

	// RVA: 0x2C43840 Offset: 0x2C42240 VA: 0x182C43840
	private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) { }

	// RVA: 0x2C439A0 Offset: 0x2C423A0 VA: 0x182C439A0
	private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) { }

	// RVA: 0x2C422B0 Offset: 0x2C40CB0 VA: 0x182C422B0
	private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) { }

	// RVA: 0x2C434A0 Offset: 0x2C41EA0 VA: 0x182C434A0 Slot: 9
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x2C44180 Offset: 0x2C42B80 VA: 0x182C44180
	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) { }

	// RVA: 0x2C43C90 Offset: 0x2C42690 VA: 0x182C43C90
	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) { }

	// RVA: 0x2C444E0 Offset: 0x2C42EE0 VA: 0x182C444E0
	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) { }

	// RVA: 0x2C43EF0 Offset: 0x2C428F0 VA: 0x182C43EF0
	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) { }

	// RVA: 0x2C459D0 Offset: 0x2C443D0 VA: 0x182C459D0
	public void .ctor() { }

	// RVA: 0x2C457B0 Offset: 0x2C441B0 VA: 0x182C457B0
	private static void .cctor() { }
}
