public class CurvyGenerator : DTVersionedMonoBehaviour // TypeDefIndex: 10676
{
	// Fields
	[SerializeField]
	[Tooltip("Show Debug Output?")]
	private bool m_ShowDebug; // 0x30
	[SerializeField]
	[Tooltip("Whether to automatically refresh the generator's output when necessary")]
	private bool m_AutoRefresh; // 0x31
	[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Play mode. Expressed in milliseconds of real time")]
	[FieldCondition("m_AutoRefresh", True, False, 0, null, 1)]
	[SerializeField]
	private int m_RefreshDelay; // 0x34
	[SerializeField]
	[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Edit mode. Expressed in milliseconds of real time")]
	[FieldCondition("m_AutoRefresh", True, False, 0, null, 1)]
	private int m_RefreshDelayEditor; // 0x38
	[Section("Events", False, False, 1000, HelpURL = "https://curvyeditor.com/doclink/generator_events")]
	[SerializeField]
	protected CurvyCGEvent m_OnRefresh; // 0x40
	[HideInInspector]
	public List<CGModule> Modules; // 0x48
	[CompilerGenerated]
	private bool <Destroying>k__BackingField; // 0x50
	private bool isInitialized; // 0x51
	private bool isInitializedPhaseOne; // 0x52
	private PoolManager poolManager; // 0x58
	[NotNull]
	private readonly CurvyGenerator.Timer autoRefreshTimer; // 0x60
	[NotNull]
	private readonly CurvyGenerator.ModuleSorter moduleSorter; // 0x68
	[NotNull]
	private readonly CurvyGenerator.ModulesSynchronizer modulesSynchronizer; // 0x70
	private const int ModulesReorderingDeltaX = 50;
	private const int ModulesReorderingDeltaY = 20;

	// Properties
	[Obsolete("No more used. Retrieve the Ids from Modules by using Modules[x].UniqueID")]
	[UsedImplicitly]
	internal int m_LastModuleID { get; set; }
	public bool ShowDebug { get; set; }
	public bool AutoRefresh { get; set; }
	public int RefreshDelay { get; set; }
	public int RefreshDelayEditor { get; set; }
	public PoolManager PoolManager { get; }
	public CurvyCGEvent OnRefresh { get; set; }
	public bool IsInitialized { get; }
	public bool Destroying { get; set; }
	[Obsolete("Dictionary no more used. Retrieve he Ids from Modules by using Modules[x].UniqueID")]
	[UsedImplicitly]
	public Dictionary<int, CGModule> ModulesByID { get; set; }
	private bool HasModulesWithSameID { get; }

	// Methods

	// RVA: 0x50A9C0 Offset: 0x5093C0 VA: 0x18050A9C0
	internal int get_m_LastModuleID() { }

	// RVA: 0x50AB80 Offset: 0x509580 VA: 0x18050AB80
	internal void set_m_LastModuleID(int value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_ShowDebug() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_ShowDebug(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_AutoRefresh() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	public void set_AutoRefresh(bool value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_RefreshDelay() { }

	// RVA: 0x50AB60 Offset: 0x509560 VA: 0x18050AB60
	public void set_RefreshDelay(int value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_RefreshDelayEditor() { }

	// RVA: 0x50AB40 Offset: 0x509540 VA: 0x18050AB40
	public void set_RefreshDelayEditor(int value) { }

	// RVA: 0x50A930 Offset: 0x509330 VA: 0x18050A930
	public PoolManager get_PoolManager() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public CurvyCGEvent get_OnRefresh() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_OnRefresh(CurvyCGEvent value) { }

	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	public bool get_IsInitialized() { }

	[CompilerGenerated]
	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_Destroying() { }

	[CompilerGenerated]
	// RVA: 0x49CCF0 Offset: 0x49B6F0 VA: 0x18049CCF0
	private void set_Destroying(bool value) { }

	// RVA: 0x50A760 Offset: 0x509160 VA: 0x18050A760
	public Dictionary<int, CGModule> get_ModulesByID() { }

	// RVA: 0x50AAF0 Offset: 0x5094F0 VA: 0x18050AAF0
	public void set_ModulesByID(Dictionary<int, CGModule> value) { }

	// RVA: 0x5086B0 Offset: 0x5070B0 VA: 0x1805086B0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x508690 Offset: 0x507090 VA: 0x180508690 Slot: 6
	protected override void OnDisable() { }

	[UsedImplicitly]
	// RVA: 0x508680 Offset: 0x507080 VA: 0x180508680
	private void OnDestroy() { }

	[UsedImplicitly]
	// RVA: 0x50A020 Offset: 0x508A20 VA: 0x18050A020
	private void Update() { }

	// RVA: 0x507410 Offset: 0x505E10 VA: 0x180507410
	public static CurvyGenerator Create() { }

	// RVA: -1 Offset: -1
	public T AddModule<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E440 Offset: 0xE6CE40 VA: 0x180E6E440
	|-CurvyGenerator.AddModule<object>
	*/

	[NotNull]
	// RVA: 0x5067C0 Offset: 0x5051C0 VA: 0x1805067C0
	public CGModule AddModule(Type type) { }

	// RVA: 0x5068E0 Offset: 0x5052E0 VA: 0x1805068E0
	public void AddModule(CGModule module) { }

	// RVA: 0x508A40 Offset: 0x507440 VA: 0x180508A40
	public void RemoveModule(CGModule module) { }

	// RVA: 0x506BF0 Offset: 0x5055F0 VA: 0x180506BF0
	public void ArrangeModules() { }

	// RVA: 0x508FA0 Offset: 0x5079A0 VA: 0x180508FA0
	public void ReorderModules() { }

	// RVA: 0x506E80 Offset: 0x505880 VA: 0x180506E80
	public void Clear() { }

	// RVA: 0x5076A0 Offset: 0x5060A0 VA: 0x1805076A0
	public void DeleteModule(CGModule module) { }

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	// RVA: -1 Offset: -1
	public List<T> FindModules<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E6E0 Offset: 0xE6D0E0 VA: 0x180E6E6E0
	|-CurvyGenerator.FindModules<object>
	*/

	// RVA: -1 Offset: -1
	public List<T> FindModules<T>(bool includeOnRequestProcessing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E500 Offset: 0xE6CF00 VA: 0x180E6E500
	|-CurvyGenerator.FindModules<object>
	*/

	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	[UsedImplicitly]
	// RVA: 0x507F20 Offset: 0x506920 VA: 0x180507F20
	public List<CGModule> GetModules() { }

	[Obsolete("Method will be removed. You can copy its implementation if needed.")]
	[UsedImplicitly]
	// RVA: 0x507DA0 Offset: 0x5067A0 VA: 0x180507DA0
	public List<CGModule> GetModules(bool includeOnRequestProcessing) { }

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	// RVA: 0x507C40 Offset: 0x506640 VA: 0x180507C40
	public CGModule GetModule(int moduleID) { }

	[CanBeNull]
	// RVA: 0x507C60 Offset: 0x506660 VA: 0x180507C60
	public CGModule GetModule(int moduleID, bool includeOnRequestProcessing) { }

	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	[UsedImplicitly]
	// RVA: -1 Offset: -1
	public T GetModule<T>(int moduleID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E970 Offset: 0xE6D370 VA: 0x180E6E970
	|-CurvyGenerator.GetModule<object>
	*/

	// RVA: -1 Offset: -1
	public T GetModule<T>(int moduleID, bool includeOnRequestProcessing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E7E0 Offset: 0xE6D1E0 VA: 0x180E6E7E0
	|-CurvyGenerator.GetModule<object>
	*/

	[UsedImplicitly]
	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	// RVA: 0x507C50 Offset: 0x506650 VA: 0x180507C50
	public CGModule GetModule(string moduleName) { }

	// RVA: 0x507B00 Offset: 0x506500 VA: 0x180507B00
	public CGModule GetModule(string moduleName, bool includeOnRequestProcessing) { }

	[Obsolete("Use the overload that has a mandatory includeOnRequestProcessing parameter")]
	[UsedImplicitly]
	// RVA: -1 Offset: -1
	public T GetModule<T>(string moduleName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E8A0 Offset: 0xE6D2A0 VA: 0x180E6E8A0
	|-CurvyGenerator.GetModule<object>
	*/

	// RVA: -1 Offset: -1
	public T GetModule<T>(string moduleName, bool includeOnRequestProcessing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E720 Offset: 0xE6D120 VA: 0x180E6E720
	|-CurvyGenerator.GetModule<object>
	*/

	[UsedImplicitly]
	[Obsolete("Use GetModule and CGModule.GetOutputSlot instead")]
	// RVA: 0x507710 Offset: 0x506110 VA: 0x180507710
	public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName) { }

	[UsedImplicitly]
	[Obsolete("Use GetModule and CGModule.GetOutputSlot instead")]
	// RVA: 0x5077C0 Offset: 0x5061C0 VA: 0x1805077C0
	public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName) { }

	// RVA: 0x5080D0 Offset: 0x506AD0 VA: 0x1805080D0
	public void Initialize(bool force = False) { }

	// RVA: 0x5087C0 Offset: 0x5071C0 VA: 0x1805087C0
	public void Refresh(bool forceUpdate = False) { }

	// RVA: 0x509BA0 Offset: 0x5085A0 VA: 0x180509BA0
	public void TryAutoRefresh() { }

	// RVA: 0x507550 Offset: 0x505F50 VA: 0x180507550
	public bool DeleteAllOutputManagedResources(out bool associatedPrefabWasModified) { }

	// RVA: 0x5079A0 Offset: 0x5063A0 VA: 0x1805079A0
	public string GetModuleUniqueName(CGModule module) { }

	// RVA: 0x507870 Offset: 0x506270 VA: 0x180507870
	public int GetModuleUniqueID(CGModule module) { }

	// RVA: 0x508760 Offset: 0x507160 VA: 0x180508760
	protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e) { }

	// RVA: 0x5096F0 Offset: 0x5080F0 VA: 0x1805096F0 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x508590 Offset: 0x506F90 VA: 0x180508590
	private bool IsModuleNameUnique(CGModule module, string uniqueName) { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x50A320 Offset: 0x508D20 VA: 0x18050A320
	public string getUniqueModuleNameINTERNAL(string name) { }

	// RVA: 0x50ABD0 Offset: 0x5095D0 VA: 0x18050ABD0
	internal void sortModulesINTERNAL() { }

	// RVA: 0x506FB0 Offset: 0x5059B0 VA: 0x180506FB0
	private bool CorrectDuplicateModuleIDs() { }

	[UsedImplicitly]
	// RVA: 0x5095D0 Offset: 0x507FD0 VA: 0x1805095D0
	private void ResetAllModuleLinks() { }

	// RVA: 0x508070 Offset: 0x506A70 VA: 0x180508070
	public bool HasCircularReference(CGModule module) { }

	// RVA: 0x508AD0 Offset: 0x5074D0 VA: 0x180508AD0
	private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs) { }

	// RVA: 0x509D20 Offset: 0x508720 VA: 0x180509D20
	private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd) { }

	// RVA: 0x509A70 Offset: 0x508470 VA: 0x180509A70
	private void SetModulesFromChildren() { }

	// RVA: 0x50A560 Offset: 0x508F60 VA: 0x18050A560
	private bool get_HasModulesWithSameID() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool DeleteAllOutputManagedResourcesFromAssociatedPrefab() { }

	// RVA: 0x509730 Offset: 0x508130 VA: 0x180509730
	public void SaveAllOutputManagedResources() { }

	// RVA: 0x50A120 Offset: 0x508B20 VA: 0x18050A120
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x509C90 Offset: 0x508690 VA: 0x180509C90
	private bool <SetModulesFromChildren>b__86_0(CGModule m) { }
}
