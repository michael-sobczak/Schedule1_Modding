public abstract class CGModule : DTVersionedMonoBehaviour // TypeDefIndex: 10640
{
	// Fields
	[Group("Events", Expanded = False, Sort = 1000)]
	[SerializeField]
	protected CurvyCGEvent m_OnBeforeRefresh; // 0x30
	[Group("Events")]
	[SerializeField]
	protected CurvyCGEvent m_OnRefresh; // 0x38
	[SerializeField]
	[HideInInspector]
	private string m_ModuleName; // 0x40
	[SerializeField]
	[HideInInspector]
	private bool m_Active; // 0x48
	[Group("Seed Options", Expanded = False, Sort = 1001)]
	[GroupCondition("UsesRandom")]
	[FieldAction("CBSeedOptions", 7, ShowBelowProperty = True)]
	[SerializeField]
	private bool m_RandomizeSeed; // 0x49
	[HideInInspector]
	[SerializeField]
	private int m_Seed; // 0x4C
	[SerializeField]
	[HideInInspector]
	private int m_UniqueID; // 0x50
	private CurvyGenerator generator; // 0x58
	private bool isInitialized; // 0x60
	[NotNull]
	private readonly CGModule.ResourceNamer resourceNamer; // 0x68
	[NotNull]
	private readonly CGModule.InformationProvider informationProvider; // 0x70
	[NotNull]
	private readonly CGModule.DirtinessManager dirtinessManager; // 0x78
	[NotNull]
	private readonly CGModule.Slots slots; // 0x80
	[NotNull]
	private readonly CGModule.Identifier identifier; // 0x88
	[NotNull]
	[TupleElementNames(new[] { "ResourceManager", "ResourceName" })]
	private readonly List<ValueTuple<Component, string>> resourceManagers; // 0x90
	public List<string> UIMessages; // 0x98
	[HideInInspector]
	public CGModuleProperties Properties; // 0xA0
	[HideInInspector]
	public List<CGModuleLink> InputLinks; // 0xA8
	[HideInInspector]
	public List<CGModuleLink> OutputLinks; // 0xB0
	[Obsolete]
	[UsedImplicitly]
	internal int SortAncestors; // 0xB8

	// Properties
	public CurvyCGEvent OnBeforeRefresh { get; set; }
	public CurvyCGEvent OnRefresh { get; set; }
	public string ModuleName { get; set; }
	public bool Active { get; set; }
	public int Seed { get; set; }
	public bool RandomizeSeed { get; set; }
	public bool Dirty { get; set; }
	public virtual bool IsConfigured { get; }
	public virtual bool IsInitialized { get; }
	public CurvyGenerator Generator { get; }
	public int UniqueID { get; set; }
	[Obsolete("Use Generator.HasCircularReference instead")]
	[UsedImplicitly]
	public bool CircularReferenceError { get; set; }
	[NotNull]
	public Dictionary<string, CGModuleInputSlot> InputByName { get; }
	[NotNull]
	public Dictionary<string, CGModuleOutputSlot> OutputByName { get; }
	[NotNull]
	public List<CGModuleInputSlot> Input { get; }
	[NotNull]
	public List<CGModuleOutputSlot> Output { get; }
	[CanBeNull]
	[Obsolete]
	[UsedImplicitly]
	public ModuleInfoAttribute Info { get; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CurvyCGEvent get_OnBeforeRefresh() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_OnBeforeRefresh(CurvyCGEvent value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public CurvyCGEvent get_OnRefresh() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_OnRefresh(CurvyCGEvent value) { }

	// RVA: 0x4DD190 Offset: 0x4DBB90 VA: 0x1804DD190
	protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e) { }

	// RVA: 0x4DD550 Offset: 0x4DBF50 VA: 0x1804DD550
	protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e) { }

	// RVA: 0x4DEFE0 Offset: 0x4DD9E0 VA: 0x1804DEFE0
	public string get_ModuleName() { }

	// RVA: 0x4DF540 Offset: 0x4DDF40 VA: 0x1804DF540
	public void set_ModuleName(string value) { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_Active() { }

	// RVA: 0x4DF480 Offset: 0x4DDE80 VA: 0x1804DF480
	public void set_Active(bool value) { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_Seed() { }

	// RVA: 0x4DF5B0 Offset: 0x4DDFB0 VA: 0x1804DF5B0
	public void set_Seed(int value) { }

	// RVA: 0x4D6190 Offset: 0x4D4B90 VA: 0x1804D6190
	public bool get_RandomizeSeed() { }

	// RVA: 0x4D6510 Offset: 0x4D4F10 VA: 0x1804D6510
	public void set_RandomizeSeed(bool value) { }

	// RVA: 0x4DEDF0 Offset: 0x4DD7F0 VA: 0x1804DEDF0
	public bool get_Dirty() { }

	// RVA: 0x4DF520 Offset: 0x4DDF20 VA: 0x1804DF520
	public void set_Dirty(bool value) { }

	// RVA: 0x4DEF70 Offset: 0x4DD970 VA: 0x1804DEF70 Slot: 9
	public virtual bool get_IsConfigured() { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90 Slot: 10
	public virtual bool get_IsInitialized() { }

	// RVA: 0x4DEE10 Offset: 0x4DD810 VA: 0x1804DEE10
	public CurvyGenerator get_Generator() { }

	// RVA: 0x4DF030 Offset: 0x4DDA30 VA: 0x1804DF030
	public int get_UniqueID() { }

	// RVA: 0x4DF5E0 Offset: 0x4DDFE0 VA: 0x1804DF5E0
	public void set_UniqueID(int value) { }

	// RVA: 0x4DEDC0 Offset: 0x4DD7C0 VA: 0x1804DEDC0
	public bool get_CircularReferenceError() { }

	// RVA: 0x4DF4D0 Offset: 0x4DDED0 VA: 0x1804DF4D0
	public void set_CircularReferenceError(bool value) { }

	// RVA: 0x4DEF30 Offset: 0x4DD930 VA: 0x1804DEF30
	public Dictionary<string, CGModuleInputSlot> get_InputByName() { }

	// RVA: 0x4DEFF0 Offset: 0x4DD9F0 VA: 0x1804DEFF0
	public Dictionary<string, CGModuleOutputSlot> get_OutputByName() { }

	// RVA: 0x4DEF50 Offset: 0x4DD950 VA: 0x1804DEF50
	public List<CGModuleInputSlot> get_Input() { }

	// RVA: 0x4DF010 Offset: 0x4DDA10 VA: 0x1804DF010
	public List<CGModuleOutputSlot> get_Output() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 11
	protected virtual void Awake() { }

	// RVA: 0x4DD420 Offset: 0x4DBE20 VA: 0x1804DD420 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x4DD1F0 Offset: 0x4DBBF0 VA: 0x1804DD1F0 Slot: 12
	protected virtual void OnDestroy() { }

	// RVA: 0x4DD650 Offset: 0x4DC050 VA: 0x1804DD650 Slot: 7
	protected override void OnValidate() { }

	[UsedImplicitly]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Update() { }

	// RVA: 0x4DD8B0 Offset: 0x4DC2B0 VA: 0x1804DD8B0 Slot: 13
	public virtual void Reset() { }

	// RVA: 0x4DD6D0 Offset: 0x4DC0D0 VA: 0x1804DD6D0 Slot: 14
	public virtual void Refresh() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	public virtual bool DeleteAllOutputManagedResources() { }

	// RVA: 0x4DD5B0 Offset: 0x4DBFB0 VA: 0x1804DD5B0 Slot: 16
	public virtual void OnStateChange() { }

	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630 Slot: 17
	public virtual void OnTemplateCreated() { }

	// RVA: -1 Offset: -1
	protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5C820 Offset: 0xE5B220 VA: 0x180E5C820
	|-CGModule.GetRequestParameter<object>
	*/

	// RVA: 0x4DD750 Offset: 0x4DC150 VA: 0x1804DD750
	protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request) { }

	// RVA: 0x4DDF60 Offset: 0x4DC960 VA: 0x1804DDF60
	public void .ctor() { }

	// RVA: 0x4DD000 Offset: 0x4DBA00 VA: 0x1804DD000
	public void Initialize() { }

	[CanBeNull]
	// RVA: 0x4DCA10 Offset: 0x4DB410 VA: 0x1804DCA10
	public CGModuleLink GetOutputLink(CGModuleOutputSlot outputSlot, CGModuleInputSlot inputSlot) { }

	[NotNull]
	// RVA: 0x4DCA20 Offset: 0x4DB420 VA: 0x1804DCA20
	public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outputSlot) { }

	[CanBeNull]
	// RVA: 0x4DC040 Offset: 0x4DAA40 VA: 0x1804DC040
	public CGModuleLink GetInputLink(CGModuleInputSlot inputSlot, CGModuleOutputSlot outputSlot) { }

	[NotNull]
	// RVA: 0x4DC050 Offset: 0x4DAA50 VA: 0x1804DC050
	public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inputSlot) { }

	[UsedImplicitly]
	[Obsolete("Use ComponentExt.DuplicateGameObject and CurvyGenerator.AddModule to duplicate the module then add it to the generator ")]
	// RVA: 0x4DBD00 Offset: 0x4DA700 VA: 0x1804DBD00
	public CGModule CopyTo(CurvyGenerator targetGenerator) { }

	// RVA: 0x4DBBE0 Offset: 0x4DA5E0 VA: 0x1804DBBE0
	public Component AddManagedResource(string resourceName, string context = "", int index = -1) { }

	// RVA: 0x4DBEB0 Offset: 0x4DA8B0 VA: 0x1804DBEB0
	public void DeleteManagedResource(string resourceName, Component res, string context = "", bool dontUsePool = False) { }

	// RVA: 0x4DD0D0 Offset: 0x4DBAD0 VA: 0x1804DD0D0
	public bool IsManagedResource(Component res) { }

	// RVA: 0x4DBFB0 Offset: 0x4DA9B0 VA: 0x1804DBFB0
	public List<IPool> GetAllPrefabPools() { }

	// RVA: 0x4DBE20 Offset: 0x4DA820 VA: 0x1804DBE20
	public void DeleteAllPrefabPools() { }

	// RVA: 0x4DBF70 Offset: 0x4DA970 VA: 0x1804DBF70
	public void Delete() { }

	// RVA: 0x4DC060 Offset: 0x4DAA60 VA: 0x1804DC060
	public CGModuleInputSlot GetInputSlot(string name) { }

	// RVA: 0x4DCA30 Offset: 0x4DB430 VA: 0x1804DCA30
	public CGModuleOutputSlot GetOutputSlot(string name) { }

	// RVA: 0x4DC530 Offset: 0x4DAF30 VA: 0x1804DC530
	public bool GetManagedResources(out List<Component> components, out List<string> resourceNames) { }

	// RVA: 0x4DDB80 Offset: 0x4DC580 VA: 0x1804DDB80
	private void SetModuleName() { }

	// RVA: 0x4DD7E0 Offset: 0x4DC1E0 VA: 0x1804DD7E0
	protected void RenameResource(string resourceName, Component resource, int index = -1) { }

	[CanBeNull]
	// RVA: 0x4DC350 Offset: 0x4DAD50 VA: 0x1804DC350
	private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target) { }

	[NotNull]
	// RVA: 0x4DC440 Offset: 0x4DAE40 VA: 0x1804DC440
	private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source) { }

	// RVA: 0x4DCD20 Offset: 0x4DB720 VA: 0x1804DCD20
	protected PrefabPool GetPrefabPool(GameObject prefab) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	protected bool TryDeleteChildrenFromAssociatedPrefab() { }

	// RVA: 0x4DEB30 Offset: 0x4DD530 VA: 0x1804DEB30
	internal void doRefresh() { }

	// RVA: 0x4DE430 Offset: 0x4DCE30 VA: 0x1804DE430
	public void checkOnStateChangedINTERNAL() { }

	[NotNull]
	[Obsolete("This does not return all resource managers. Read todo inside and fix it first")]
	[UsedImplicitly]
	// RVA: 0x4DCE30 Offset: 0x4DB830 VA: 0x1804DCE30
	private List<ValueTuple<Component, string>> GetResourceManagers() { }

	// RVA: 0x4DD810 Offset: 0x4DC210 VA: 0x1804DD810 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x4DDF10 Offset: 0x4DC910 VA: 0x1804DDF10
	private bool UsesRandom() { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x4DF060 Offset: 0x4DDA60 VA: 0x1804DF060
	internal void initializeSort() { }

	[Obsolete]
	[UsedImplicitly]
	// RVA: 0x4DE450 Offset: 0x4DCE50 VA: 0x1804DE450
	internal List<CGModule> decrementChilds() { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x4DDD10 Offset: 0x4DC710 VA: 0x1804DDD10
	public int SetUniqueIdINTERNAL() { }

	// RVA: 0x4DEF10 Offset: 0x4DD910 VA: 0x1804DEF10
	public ModuleInfoAttribute get_Info() { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x4DECD0 Offset: 0x4DD6D0 VA: 0x1804DECD0
	internal ModuleInfoAttribute getInfo() { }

	[Obsolete]
	[UsedImplicitly]
	// RVA: 0x4DF280 Offset: 0x4DDC80 VA: 0x1804DF280
	public void renameManagedResourcesINTERNAL() { }

	[Obsolete]
	[UsedImplicitly]
	// RVA: 0x4DD6A0 Offset: 0x4DC0A0 VA: 0x1804DD6A0
	public void ReInitializeLinkedSlots() { }

	[Obsolete("Will be removed. Copy the method's implementation if needed")]
	[UsedImplicitly]
	// RVA: 0x4DC090 Offset: 0x4DAA90 VA: 0x1804DC090
	public List<CGModuleInputSlot> GetInputSlots(Type filterType) { }

	[Obsolete("Will be removed. Copy the method's implementation if needed")]
	[UsedImplicitly]
	// RVA: 0x4DCA60 Offset: 0x4DB460 VA: 0x1804DCA60
	public List<CGModuleOutputSlot> GetOutputSlots(Type filterType) { }

	[CompilerGenerated]
	// RVA: 0x4DDE60 Offset: 0x4DC860 VA: 0x1804DDE60
	private bool <Reset>b__67_0(CGModule m) { }
}
