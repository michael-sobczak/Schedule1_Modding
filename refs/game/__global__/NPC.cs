public class NPC : NetworkBehaviour, IGUIDRegisterable, ISaveable, ICombatTargetable, IDamageable, ISightable // TypeDefIndex: 1635
{
	// Fields
	public const float PANIC_DURATION = 20;
	public const bool RequiresRegionUnlocked = True;
	[Header("Info Settings")]
	public string FirstName; // 0x118
	public bool hasLastName; // 0x120
	public string LastName; // 0x128
	[CompilerGenerated]
	private float <Scale>k__BackingField; // 0x130
	public string ID; // 0x138
	public Sprite MugshotSprite; // 0x140
	public EMapRegion Region; // 0x148
	[Header("If true, NPC will respawn next day instead of waiting 3 days.")]
	public bool IsImportant; // 0x14C
	[Range(0, 1)]
	[Header("Personality")]
	public float Aggression; // 0x150
	[Header("References")]
	[SerializeField]
	protected Transform modelContainer; // 0x158
	[SerializeField]
	protected InteractableObject intObj; // 0x160
	public NPCMovement Movement; // 0x168
	public DialogueHandler DialogueHandler; // 0x170
	public Avatar Avatar; // 0x178
	public NPCAwareness Awareness; // 0x180
	public NPCResponses Responses; // 0x188
	public NPCActions Actions; // 0x190
	public NPCBehaviour Behaviour; // 0x198
	public NPCInventory Inventory; // 0x1A0
	public VOEmitter VoiceOverEmitter; // 0x1A8
	public NPCHealth Health; // 0x1B0
	public EntityVisibility Visibility; // 0x1B8
	[CompilerGenerated]
	private LandVehicle <CurrentVehicle>k__BackingField; // 0x1C0
	public Action<LandVehicle> onEnterVehicle; // 0x1C8
	public Action<LandVehicle> onExitVehicle; // 0x1D0
	[CompilerGenerated]
	private NPCEnterableBuilding <CurrentBuilding>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private StaticDoor <LastEnteredDoor>k__BackingField; // 0x1E0
	[Header("Summoning")]
	public bool CanBeSummoned; // 0x1E8
	[Header("Relationship")]
	public NPCRelationData RelationData; // 0x1F0
	public string NPCUnlockedVariable; // 0x1F8
	public bool ShowRelationshipInfo; // 0x200
	[Header("Messaging")]
	public List<EConversationCategory> ConversationCategories; // 0x208
	public bool MessagingKnownByDefault; // 0x210
	[CompilerGenerated]
	private MSGConversation <MSGConversation>k__BackingField; // 0x218
	public bool ConversationCanBeHidden; // 0x220
	public Action onConversationCreated; // 0x228
	[Header("Other Settings")]
	public bool CanOpenDoors; // 0x230
	public bool OverrideParent; // 0x231
	public Transform OverriddenParent; // 0x238
	public bool IgnoreImpacts; // 0x240
	[SerializeField]
	protected List<GameObject> OutlineRenderers; // 0x248
	protected Outlinable OutlineEffect; // 0x250
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x258
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x260
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x268
	[CompilerGenerated]
	private VisionEvent <HighestProgressionEvent>k__BackingField; // 0x270
	[Header("GUID")]
	public string BakedGUID; // 0x278
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x280
	[CompilerGenerated]
	private bool <isVisible>k__BackingField; // 0x290
	public Action<bool> onVisibilityChanged; // 0x298
	[HideInInspector]
	[SyncVar]
	public NetworkObject PlayerConversant; // 0x2A0
	[CompilerGenerated]
	private bool <isUnsettled>k__BackingField; // 0x2A8
	private Coroutine resetUnsettledCoroutine; // 0x2B0
	[CompilerGenerated]
	private float <TimeSincePanicked>k__BackingField; // 0x2B8
	private List<int> impactHistory; // 0x2C0
	private int headlightStartTime; // 0x2C8
	private int heaedLightsEndTime; // 0x2CC
	protected float defaultAggression; // 0x2D0
	private Coroutine lerpScaleRoutine; // 0x2D8
	public SyncVar<NetworkObject> syncVar___PlayerConversant; // 0x2E0
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted; // 0x2E8
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted; // 0x2E9

	// Properties
	public string fullName { get; }
	public float Scale { get; set; }
	public bool IsConscious { get; }
	public LandVehicle CurrentVehicle { get; set; }
	public bool IsInVehicle { get; }
	public bool isInBuilding { get; }
	public NPCEnterableBuilding CurrentBuilding { get; set; }
	public StaticDoor LastEnteredDoor { get; set; }
	public MSGConversation MSGConversation { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public Vector3 CenterPoint { get; }
	public Transform CenterPointTransform { get; }
	public Vector3 LookAtPoint { get; }
	public bool IsCurrentlyTargetable { get; }
	public float RangedHitChanceMultiplier { get; }
	public Vector3 Velocity { get; }
	public VisionEvent HighestProgressionEvent { get; set; }
	public EntityVisibility VisibilityComponent { get; }
	public Guid GUID { get; set; }
	public bool isVisible { get; set; }
	public bool isUnsettled { get; set; }
	public bool IsPanicked { get; }
	public float TimeSincePanicked { get; set; }
	public NetworkObject SyncAccessor_PlayerConversant { get; set; }

	// Methods

	// RVA: 0x70CCE0 Offset: 0x70B6E0 VA: 0x18070CCE0
	public string get_fullName() { }

	[CompilerGenerated]
	// RVA: 0x718AA0 Offset: 0x7174A0 VA: 0x180718AA0
	public float get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x718C30 Offset: 0x717630 VA: 0x180718C30
	private void set_Scale(float value) { }

	// RVA: 0x7188B0 Offset: 0x7172B0 VA: 0x1807188B0
	public bool get_IsConscious() { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public LandVehicle get_CurrentVehicle() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_CurrentVehicle(LandVehicle value) { }

	// RVA: 0x718960 Offset: 0x717360 VA: 0x180718960
	public bool get_IsInVehicle() { }

	// RVA: 0x718B20 Offset: 0x717520 VA: 0x180718B20
	public bool get_isInBuilding() { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public NPCEnterableBuilding get_CurrentBuilding() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_CurrentBuilding(NPCEnterableBuilding value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public StaticDoor get_LastEnteredDoor() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	public void set_LastEnteredDoor(StaticDoor value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public MSGConversation get_MSGConversation() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_MSGConversation(MSGConversation value) { }

	// RVA: 0x70CCE0 Offset: 0x70B6E0 VA: 0x18070CCE0 Slot: 22
	public string get_SaveFolderName() { }

	// RVA: 0x718A70 Offset: 0x717470 VA: 0x180718A70 Slot: 23
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 24
	public Loader get_Loader() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 25
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x7189E0 Offset: 0x7173E0 VA: 0x1807189E0 Slot: 26
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x718BF0 Offset: 0x7175F0 VA: 0x180718BF0 Slot: 27
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x7189F0 Offset: 0x7173F0 VA: 0x1807189F0 Slot: 28
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x718C10 Offset: 0x717610 VA: 0x180718C10 Slot: 29
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x595640 Offset: 0x594040 VA: 0x180595640 Slot: 30
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x595650 Offset: 0x594050 VA: 0x180595650 Slot: 31
	public void set_HasChanged(bool value) { }

	// RVA: 0x718840 Offset: 0x717240 VA: 0x180718840 Slot: 46
	public Vector3 get_CenterPoint() { }

	// RVA: 0x718810 Offset: 0x717210 VA: 0x180718810 Slot: 47
	public Transform get_CenterPointTransform() { }

	// RVA: 0x718A00 Offset: 0x717400 VA: 0x180718A00 Slot: 48
	public Vector3 get_LookAtPoint() { }

	// RVA: 0x718920 Offset: 0x717320 VA: 0x180718920 Slot: 49
	public bool get_IsCurrentlyTargetable() { }

	// RVA: 0x718A60 Offset: 0x717460 VA: 0x180718A60 Slot: 50
	public float get_RangedHitChanceMultiplier() { }

	// RVA: 0x718AC0 Offset: 0x7174C0 VA: 0x180718AC0 Slot: 51
	public Vector3 get_Velocity() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 52
	public void RecordLastKnownPosition(bool resetTimeSinceLastSeen) { }

	// RVA: 0x70D190 Offset: 0x70BB90 VA: 0x18070D190 Slot: 53
	public float GetSearchTime() { }

	[CompilerGenerated]
	// RVA: 0x7188A0 Offset: 0x7172A0 VA: 0x1807188A0 Slot: 61
	public VisionEvent get_HighestProgressionEvent() { }

	[CompilerGenerated]
	// RVA: 0x718BB0 Offset: 0x7175B0 VA: 0x180718BB0 Slot: 62
	public void set_HighestProgressionEvent(VisionEvent value) { }

	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970 Slot: 63
	public EntityVisibility get_VisibilityComponent() { }

	// RVA: 0x70D2F0 Offset: 0x70BCF0 VA: 0x18070D2F0 Slot: 64
	public bool IsCurrentlySightable() { }

	[CompilerGenerated]
	// RVA: 0x718890 Offset: 0x717290 VA: 0x180718890 Slot: 19
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x718BA0 Offset: 0x7175A0 VA: 0x180718BA0
	protected void set_GUID(Guid value) { }

	[CompilerGenerated]
	// RVA: 0x718B90 Offset: 0x717590 VA: 0x180718B90
	public bool get_isVisible() { }

	[CompilerGenerated]
	// RVA: 0x718C60 Offset: 0x717660 VA: 0x180718C60
	protected void set_isVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x718B80 Offset: 0x717580 VA: 0x180718B80
	public bool get_isUnsettled() { }

	[CompilerGenerated]
	// RVA: 0x718C50 Offset: 0x717650 VA: 0x180718C50
	protected void set_isUnsettled(bool value) { }

	// RVA: 0x7189C0 Offset: 0x7173C0 VA: 0x1807189C0
	public bool get_IsPanicked() { }

	[CompilerGenerated]
	// RVA: 0x718AB0 Offset: 0x7174B0 VA: 0x180718AB0
	public float get_TimeSincePanicked() { }

	[CompilerGenerated]
	// RVA: 0x718C40 Offset: 0x717640 VA: 0x180718C40
	protected void set_TimeSincePanicked(float value) { }

	// RVA: 0x70B490 Offset: 0x709E90 VA: 0x18070B490 Slot: 65
	public override void Awake() { }

	// RVA: 0x70B4E0 Offset: 0x709EE0 VA: 0x18070B4E0 Slot: 66
	protected virtual void CheckAndGetReferences() { }

	// RVA: 0x70D240 Offset: 0x70BC40 VA: 0x18070D240 Slot: 67
	public virtual void InitializeSaveable() { }

	// RVA: 0x716D40 Offset: 0x715740 VA: 0x180716D40 Slot: 21
	public void SetGUID(Guid guid) { }

	// RVA: 0x70EF30 Offset: 0x70D930 VA: 0x18070EF30
	private void PlayerSpawned() { }

	// RVA: 0x70B950 Offset: 0x70A350 VA: 0x18070B950 Slot: 68
	protected virtual void CreateMessageConversation() { }

	// RVA: 0x70CCE0 Offset: 0x70B6E0 VA: 0x18070CCE0 Slot: 69
	protected virtual string GetMessagingName() { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 70
	public virtual Sprite GetMessagingIcon() { }

	// RVA: 0x715F30 Offset: 0x714930 VA: 0x180715F30
	public void SendTextMessage(string message) { }

	// RVA: 0x70E810 Offset: 0x70D210 VA: 0x18070E810 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x717E40 Offset: 0x716840 VA: 0x180717E40 Slot: 71
	protected virtual void Start() { }

	// RVA: 0x70E1C0 Offset: 0x70CBC0 VA: 0x18070E1C0 Slot: 72
	protected virtual void OnDestroy() { }

	// RVA: 0x70E430 Offset: 0x70CE30 VA: 0x18070E430 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ObserversRpc]
	// RVA: 0x716F60 Offset: 0x715960 VA: 0x180716F60
	private void SetTransform(NetworkConnection conn, Vector3 position, Quaternion rotation) { }

	// RVA: 0x70D330 Offset: 0x70BD30 VA: 0x18070D330 Slot: 73
	protected virtual void MinPass() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 74
	protected virtual void OnTick() { }

	// RVA: 0x717410 Offset: 0x715E10 VA: 0x180717410 Slot: 75
	public virtual void SetVisible(bool visible, bool networked = False) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7172C0 Offset: 0x715CC0 VA: 0x1807172C0
	private void SetVisible_Networked(bool visible) { }

	// RVA: 0x716DB0 Offset: 0x7157B0 VA: 0x180716DB0
	public void SetScale(float scale) { }

	// RVA: 0x716DD0 Offset: 0x7157D0 VA: 0x180716DD0
	public void SetScale(float scale, float lerpTime) { }

	// RVA: 0x70A7B0 Offset: 0x7091B0 VA: 0x18070A7B0 Slot: 76
	protected virtual void ApplyScale() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x70A680 Offset: 0x709080 VA: 0x18070A680 Slot: 77
	public virtual void AimedAtByPlayer(NetworkObject player) { }

	// RVA: 0x70E9B0 Offset: 0x70D3B0 VA: 0x18070E9B0
	public void OverrideAggression(float aggression) { }

	// RVA: 0x70F6D0 Offset: 0x70E0D0 VA: 0x18070F6D0
	public void ResetAggression() { }

	// RVA: 0x70E380 Offset: 0x70CD80 VA: 0x18070E380 Slot: 78
	protected virtual void OnDie() { }

	// RVA: 0x70E3B0 Offset: 0x70CDB0 VA: 0x18070E3B0 Slot: 79
	protected virtual void OnKnockedOut() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x715DF0 Offset: 0x7147F0 VA: 0x180715DF0 Slot: 80
	public virtual void SendImpact(Impact impact) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70F1E0 Offset: 0x70DBE0 VA: 0x18070F1E0 Slot: 81
	public virtual void ReceiveImpact(Impact impact) { }

	// RVA: 0x70EF50 Offset: 0x70D950 VA: 0x18070EF50 Slot: 82
	public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x70C400 Offset: 0x70AE00 VA: 0x18070C400 Slot: 83
	public virtual void EnterVehicle(NetworkConnection connection, LandVehicle veh) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70CBC0 Offset: 0x70B5C0 VA: 0x18070CBC0 Slot: 84
	public virtual void ExitVehicle() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x715FF0 Offset: 0x7149F0 VA: 0x180715FF0
	public void SendWorldspaceDialogueReaction(string key, float duration) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70EDB0 Offset: 0x70D7B0 VA: 0x18070EDB0
	private void PlayWorldspaceDialogueReaction(string key, float duration) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x7146A0 Offset: 0x7130A0 VA: 0x1807146A0
	public void SendWorldSpaceDialogue(string text, float duration) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x717CD0 Offset: 0x7166D0 VA: 0x180717CD0
	public void ShowWorldSpaceDialogue(string text, float duration) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x7166B0 Offset: 0x7150B0 VA: 0x1807166B0
	public void SetConversant(NetworkObject player) { }

	// RVA: 0x70D220 Offset: 0x70BC20 VA: 0x18070D220
	private void Hovered_Internal() { }

	// RVA: 0x70D2D0 Offset: 0x70BCD0 VA: 0x18070D2D0
	private void Interacted_Internal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 85
	protected virtual void Hovered() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 86
	protected virtual void Interacted() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70BB00 Offset: 0x70A500 VA: 0x18070BB00
	public void EnterBuilding(NetworkConnection connection, string buildingGUID, int doorIndex) { }

	// RVA: 0x70BDC0 Offset: 0x70A7C0 VA: 0x18070BDC0 Slot: 87
	protected virtual void EnterBuilding(string buildingGUID, int doorIndex) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70CA80 Offset: 0x70B480 VA: 0x18070CA80
	public void ExitBuilding(string buildingID = "") { }

	// RVA: 0x70C660 Offset: 0x70B060 VA: 0x18070C660 Slot: 88
	protected virtual void ExitBuilding(NPCEnterableBuilding building) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x716AA0 Offset: 0x7154A0 VA: 0x180716AA0
	public void SetEquippable_Networked(NetworkConnection conn, string assetPath) { }

	// RVA: 0x716930 Offset: 0x715330 VA: 0x180716930
	public AvatarEquippable SetEquippable_Networked_Return(NetworkConnection conn, string assetPath) { }

	// RVA: 0x716D10 Offset: 0x715710 VA: 0x180716D10
	public AvatarEquippable SetEquippable_Return(string assetPath) { }

	[ObserversRpc(RunLocally = False, ExcludeServer = True)]
	// RVA: 0x713C30 Offset: 0x712630 VA: 0x180713C30
	private void SetEquippable_Networked_ExcludeServer(NetworkConnection conn, string assetPath) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x715B80 Offset: 0x714580 VA: 0x180715B80
	public void SendEquippableMessage_Networked(NetworkConnection conn, string message) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x715820 Offset: 0x714220 VA: 0x180715820
	public void SendEquippableMessage_Networked_Vector(NetworkConnection conn, string message, Vector3 data) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x714300 Offset: 0x712D00 VA: 0x180714300
	public void SendAnimationTrigger(string trigger) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x716410 Offset: 0x714E10 VA: 0x180716410
	public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger) { }

	// RVA: 0x716680 Offset: 0x715080 VA: 0x180716680
	public void SetAnimationTrigger(string trigger) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x70F6E0 Offset: 0x70E0E0 VA: 0x18070F6E0
	public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger) { }

	// RVA: 0x70F950 Offset: 0x70E350 VA: 0x18070F950
	public void ResetAnimationTrigger(string trigger) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7167E0 Offset: 0x7151E0 VA: 0x1807167E0
	public void SetCrouched_Networked(bool crouched) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x716140 Offset: 0x714B40 VA: 0x180716140
	public void SetAnimationBool_Networked(NetworkConnection conn, string id, bool value) { }

	// RVA: 0x7163E0 Offset: 0x714DE0 VA: 0x1807163E0
	public void SetAnimationBool(string trigger, bool val) { }

	// RVA: 0x716FA0 Offset: 0x7159A0 VA: 0x180716FA0 Slot: 89
	protected virtual void SetUnsettled_30s(Player player) { }

	// RVA: 0x717130 Offset: 0x715B30 VA: 0x180717130
	protected void SetUnsettled(float duration) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x714BC0 Offset: 0x7135C0 VA: 0x180714BC0
	public void SetPanicked() { }

	[ObserversRpc]
	// RVA: 0x70F320 Offset: 0x70DD20 VA: 0x18070F320
	private void ReceivePanicked() { }

	[ObserversRpc]
	// RVA: 0x70F5B0 Offset: 0x70DFB0 VA: 0x18070F5B0
	private void RemovePanicked() { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0 Slot: 90
	public virtual string GetNameAddress() { }

	// RVA: 0x70EC40 Offset: 0x70D640 VA: 0x18070EC40
	public void PlayVO(EVOLineType lineType, bool network = False) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x70EB10 Offset: 0x70D510 VA: 0x18070EB10
	private void PlayVO_Server(EVOLineType lineType) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x70E9C0 Offset: 0x70D3C0 VA: 0x18070E9C0
	private void PlayVO_Client(EVOLineType lineType) { }

	[TargetRpc]
	// RVA: 0x70F440 Offset: 0x70DE40 VA: 0x18070F440
	public void ReceiveRelationshipData(NetworkConnection conn, float relationship, bool unlocked) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x714A90 Offset: 0x713490 VA: 0x180714A90
	public void SetIsBeingPickPocketed(bool pickpocketed) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x714560 Offset: 0x712F60 VA: 0x180714560
	public void SendRelationship(float relationship) { }

	[ObserversRpc]
	// RVA: 0x7109F0 Offset: 0x70F3F0 VA: 0x1807109F0
	private void SetRelationship(float relationship) { }

	// RVA: 0x717810 Offset: 0x716210 VA: 0x180717810 Slot: 91
	public void ShowOutline(Color color) { }

	// RVA: 0x70D1A0 Offset: 0x70BBA0 VA: 0x18070D1A0 Slot: 92
	public void HideOutline() { }

	// RVA: 0x717760 Offset: 0x716160 VA: 0x180717760 Slot: 93
	public virtual bool ShouldSave() { }

	// RVA: 0x717720 Offset: 0x716120 VA: 0x180717720 Slot: 94
	protected virtual bool ShouldSaveRelationshipData() { }

	// RVA: 0x7176C0 Offset: 0x7160C0 VA: 0x1807176C0
	protected bool ShouldSaveMessages() { }

	// RVA: 0x717660 Offset: 0x716060 VA: 0x180717660 Slot: 95
	protected virtual bool ShouldSaveInventory() { }

	// RVA: 0x717610 Offset: 0x716010 VA: 0x180717610 Slot: 96
	protected virtual bool ShouldSaveHealth() { }

	// RVA: 0x70D150 Offset: 0x70BB50 VA: 0x18070D150 Slot: 33
	public string GetSaveString() { }

	// RVA: 0x70CD40 Offset: 0x70B740 VA: 0x18070CD40 Slot: 97
	public virtual NPCData GetNPCData() { }

	// RVA: 0x70CDA0 Offset: 0x70B7A0 VA: 0x18070CDA0 Slot: 98
	public virtual DynamicSaveData GetSaveData() { }

	// RVA: 0x718440 Offset: 0x716E40 VA: 0x180718440 Slot: 99
	public virtual List<string> WriteData(string parentFolderPath) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 100
	public virtual void Load(NPCData data, string containerPath) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 101
	public virtual void Load(DynamicSaveData dynamicData, NPCData npcData) { }

	// RVA: 0x7184A0 Offset: 0x716EA0 VA: 0x1807184A0
	public void .ctor() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 45
	private NetworkObject ScheduleOne.Combat.ICombatTargetable.get_NetworkObject() { }

	// RVA: 0x63D6C0 Offset: 0x63C0C0 VA: 0x18063D6C0 Slot: 57
	private GameObject ScheduleOne.Combat.IDamageable.get_gameObject() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 60
	private NetworkObject ScheduleOne.Vision.ISightable.get_NetworkObject() { }

	[CompilerGenerated]
	// RVA: 0x718330 Offset: 0x716D30 VA: 0x180718330
	private void <Awake>g__Unlocked|134_0(NPCRelationData.EUnlockType unlockType, bool notify) { }

	// RVA: 0x70D5D0 Offset: 0x70BFD0 VA: 0x18070D5D0 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x70D580 Offset: 0x70BF80 VA: 0x18070D580 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x713DA0 Offset: 0x7127A0 VA: 0x180713DA0
	private void RpcWriter___Observers_SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation) { }

	// RVA: 0x710EB0 Offset: 0x70F8B0 VA: 0x180710EB0
	private void RpcLogic___SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation) { }

	// RVA: 0x711920 Offset: 0x710320 VA: 0x180711920
	private void RpcReader___Observers_SetTransform_4260003484(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714050 Offset: 0x712A50 VA: 0x180714050
	private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool visible) { }

	// RVA: 0x710F40 Offset: 0x70F940 VA: 0x180710F40
	private void RpcLogic___SetVisible_Networked_1140765316(bool visible) { }

	// RVA: 0x711A40 Offset: 0x710440 VA: 0x180711A40
	private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x70A680 Offset: 0x709080 VA: 0x18070A680
	private void RpcWriter___Server_AimedAtByPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x70F980 Offset: 0x70E380 VA: 0x18070F980 Slot: 104
	public virtual void RpcLogic___AimedAtByPlayer_3323014238(NetworkObject player) { }

	// RVA: 0x711B50 Offset: 0x710550 VA: 0x180711B50
	private void RpcReader___Server_AimedAtByPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x714430 Offset: 0x712E30 VA: 0x180714430
	private void RpcWriter___Server_SendImpact_427288424(Impact impact) { }

	// RVA: 0x7109D0 Offset: 0x70F3D0 VA: 0x1807109D0 Slot: 105
	public virtual void RpcLogic___SendImpact_427288424(Impact impact) { }

	// RVA: 0x711DD0 Offset: 0x7107D0 VA: 0x180711DD0
	private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x713190 Offset: 0x711B90 VA: 0x180713190
	private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact) { }

	// RVA: 0x7101F0 Offset: 0x70EBF0 VA: 0x1807101F0 Slot: 106
	public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact) { }

	// RVA: 0x711230 Offset: 0x70FC30 VA: 0x180711230
	private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x712B40 Offset: 0x711540 VA: 0x180712B40
	private void RpcWriter___Observers_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh) { }

	// RVA: 0x70FA20 Offset: 0x70E420 VA: 0x18070FA20 Slot: 107
	public virtual void RpcLogic___EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh) { }

	// RVA: 0x711020 Offset: 0x70FA20 VA: 0x180711020
	private void RpcReader___Observers_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714E40 Offset: 0x713840 VA: 0x180714E40
	private void RpcWriter___Target_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh) { }

	// RVA: 0x7123C0 Offset: 0x710DC0 VA: 0x1807123C0
	private void RpcReader___Target_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x712DC0 Offset: 0x7117C0 VA: 0x180712DC0
	private void RpcWriter___Observers_ExitVehicle_2166136261() { }

	// RVA: 0x70FDF0 Offset: 0x70E7F0 VA: 0x18070FDF0 Slot: 108
	public virtual void RpcLogic___ExitVehicle_2166136261() { }

	// RVA: 0x7110E0 Offset: 0x70FAE0 VA: 0x1807110E0
	private void RpcReader___Observers_ExitVehicle_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714800 Offset: 0x713200 VA: 0x180714800
	private void RpcWriter___Server_SendWorldspaceDialogueReaction_606697822(string key, float duration) { }

	// RVA: 0x70EDB0 Offset: 0x70D7B0 VA: 0x18070EDB0
	public void RpcLogic___SendWorldspaceDialogueReaction_606697822(string key, float duration) { }

	// RVA: 0x712030 Offset: 0x710A30 VA: 0x180712030
	private void RpcReader___Server_SendWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x713020 Offset: 0x711A20 VA: 0x180713020
	private void RpcWriter___Observers_PlayWorldspaceDialogueReaction_606697822(string key, float duration) { }

	// RVA: 0x7101B0 Offset: 0x70EBB0 VA: 0x1807101B0
	private void RpcLogic___PlayWorldspaceDialogueReaction_606697822(string key, float duration) { }

	// RVA: 0x711190 Offset: 0x70FB90 VA: 0x180711190
	private void RpcReader___Observers_PlayWorldspaceDialogueReaction_606697822(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7146A0 Offset: 0x7130A0 VA: 0x1807146A0
	private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration) { }

	// RVA: 0x710B40 Offset: 0x70F540 VA: 0x180710B40
	public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration) { }

	// RVA: 0x711FC0 Offset: 0x7109C0 VA: 0x180711FC0
	private void RpcReader___Server_SendWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x714190 Offset: 0x712B90 VA: 0x180714190
	private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration) { }

	// RVA: 0x710F60 Offset: 0x70F960 VA: 0x180710F60
	public void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration) { }

	// RVA: 0x711AC0 Offset: 0x7104C0 VA: 0x180711AC0
	private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714960 Offset: 0x713360 VA: 0x180714960
	private void RpcWriter___Server_SetConversant_3323014238(NetworkObject player) { }

	// RVA: 0x710BD0 Offset: 0x70F5D0 VA: 0x180710BD0
	public void RpcLogic___SetConversant_3323014238(NetworkObject player) { }

	// RVA: 0x7120C0 Offset: 0x710AC0 VA: 0x1807120C0
	private void RpcReader___Server_SetConversant_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7129C0 Offset: 0x7113C0 VA: 0x1807129C0
	private void RpcWriter___Observers_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex) { }

	// RVA: 0x70FA00 Offset: 0x70E400 VA: 0x18070FA00
	public void RpcLogic___EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex) { }

	// RVA: 0x710F90 Offset: 0x70F990 VA: 0x180710F90
	private void RpcReader___Observers_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714CD0 Offset: 0x7136D0 VA: 0x180714CD0
	private void RpcWriter___Target_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex) { }

	// RVA: 0x712330 Offset: 0x710D30 VA: 0x180712330
	private void RpcReader___Target_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x712C80 Offset: 0x711680 VA: 0x180712C80
	private void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "") { }

	// RVA: 0x70FC90 Offset: 0x70E690 VA: 0x18070FC90
	public void RpcLogic___ExitBuilding_3615296227(string buildingID = "") { }

	// RVA: 0x711080 Offset: 0x70FA80 VA: 0x180711080
	private void RpcReader___Observers_ExitBuilding_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x713AF0 Offset: 0x7124F0 VA: 0x180713AF0
	private void RpcWriter___Observers_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath) { }

	// RVA: 0x710CA0 Offset: 0x70F6A0 VA: 0x180710CA0
	public void RpcLogic___SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath) { }

	// RVA: 0x7117C0 Offset: 0x7101C0 VA: 0x1807117C0
	private void RpcReader___Observers_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7156C0 Offset: 0x7140C0 VA: 0x1807156C0
	private void RpcWriter___Target_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath) { }

	// RVA: 0x712950 Offset: 0x711350 VA: 0x180712950
	private void RpcReader___Target_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x713C30 Offset: 0x712630 VA: 0x180713C30
	private void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath) { }

	// RVA: 0x710CA0 Offset: 0x70F6A0 VA: 0x180710CA0
	private void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath) { }

	// RVA: 0x711840 Offset: 0x710240 VA: 0x180711840
	private void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x713410 Offset: 0x711E10 VA: 0x180713410
	private void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x7108F0 Offset: 0x70F2F0 VA: 0x1807108F0
	public void RpcLogic___SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x711440 Offset: 0x70FE40 VA: 0x180711440
	private void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x715100 Offset: 0x713B00 VA: 0x180715100
	private void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message) { }

	// RVA: 0x712680 Offset: 0x711080 VA: 0x180712680
	private void RpcReader___Target_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x713550 Offset: 0x711F50 VA: 0x180713550
	private void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data) { }

	// RVA: 0x710930 Offset: 0x70F330 VA: 0x180710930
	public void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data) { }

	// RVA: 0x7114C0 Offset: 0x70FEC0 VA: 0x1807114C0
	private void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x715260 Offset: 0x713C60 VA: 0x180715260
	private void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data) { }

	// RVA: 0x7126F0 Offset: 0x7110F0 VA: 0x1807126F0
	private void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714300 Offset: 0x712D00 VA: 0x180714300
	private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger) { }

	// RVA: 0x7108E0 Offset: 0x70F2E0 VA: 0x1807108E0
	public void RpcLogic___SendAnimationTrigger_3615296227(string trigger) { }

	// RVA: 0x711D70 Offset: 0x710770 VA: 0x180711D70
	private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x713870 Offset: 0x712270 VA: 0x180713870
	private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x710B90 Offset: 0x70F590 VA: 0x180710B90
	public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x7116C0 Offset: 0x7100C0 VA: 0x1807116C0
	private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x715560 Offset: 0x713F60 VA: 0x180715560
	private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x7128E0 Offset: 0x7112E0 VA: 0x1807128E0
	private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7132D0 Offset: 0x711CD0 VA: 0x1807132D0
	private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x7108A0 Offset: 0x70F2A0 VA: 0x1807108A0
	public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x7113D0 Offset: 0x70FDD0 VA: 0x1807113D0
	private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714FA0 Offset: 0x7139A0 VA: 0x180714FA0
	private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger) { }

	// RVA: 0x712610 Offset: 0x711010 VA: 0x180712610
	private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7139B0 Offset: 0x7123B0 VA: 0x1807139B0
	private void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched) { }

	// RVA: 0x710C70 Offset: 0x70F670 VA: 0x180710C70
	public void RpcLogic___SetCrouched_Networked_1140765316(bool crouched) { }

	// RVA: 0x711730 Offset: 0x710130 VA: 0x180711730
	private void RpcReader___Observers_SetCrouched_Networked_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x713700 Offset: 0x712100 VA: 0x180713700
	private void RpcWriter___Observers_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value) { }

	// RVA: 0x710B50 Offset: 0x70F550 VA: 0x180710B50
	public void RpcLogic___SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value) { }

	// RVA: 0x711610 Offset: 0x710010 VA: 0x180711610
	private void RpcReader___Observers_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x715400 Offset: 0x713E00 VA: 0x180715400
	private void RpcWriter___Target_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value) { }

	// RVA: 0x712830 Offset: 0x711230 VA: 0x180712830
	private void RpcReader___Target_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714BC0 Offset: 0x7135C0 VA: 0x180714BC0
	private void RpcWriter___Server_SetPanicked_2166136261() { }

	// RVA: 0x710D30 Offset: 0x70F730 VA: 0x180710D30
	public void RpcLogic___SetPanicked_2166136261() { }

	// RVA: 0x7121D0 Offset: 0x710BD0 VA: 0x1807121D0
	private void RpcReader___Server_SetPanicked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x70F320 Offset: 0x70DD20 VA: 0x18070F320
	private void RpcWriter___Observers_ReceivePanicked_2166136261() { }

	// RVA: 0x710430 Offset: 0x70EE30 VA: 0x180710430
	private void RpcLogic___ReceivePanicked_2166136261() { }

	// RVA: 0x711290 Offset: 0x70FC90 VA: 0x180711290
	private void RpcReader___Observers_ReceivePanicked_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x70F5B0 Offset: 0x70DFB0 VA: 0x18070F5B0
	private void RpcWriter___Observers_RemovePanicked_2166136261() { }

	// RVA: 0x7107A0 Offset: 0x70F1A0 VA: 0x1807107A0
	private void RpcLogic___RemovePanicked_2166136261() { }

	// RVA: 0x7112C0 Offset: 0x70FCC0 VA: 0x1807112C0
	private void RpcReader___Observers_RemovePanicked_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x70EB10 Offset: 0x70D510 VA: 0x18070EB10
	private void RpcWriter___Server_PlayVO_Server_1710085680(EVOLineType lineType) { }

	// RVA: 0x70E9C0 Offset: 0x70D3C0 VA: 0x18070E9C0
	private void RpcLogic___PlayVO_Server_1710085680(EVOLineType lineType) { }

	// RVA: 0x711C00 Offset: 0x710600 VA: 0x180711C00
	private void RpcReader___Server_PlayVO_Server_1710085680(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x712EE0 Offset: 0x7118E0 VA: 0x180712EE0
	private void RpcWriter___Observers_PlayVO_Client_1710085680(EVOLineType lineType) { }

	// RVA: 0x710180 Offset: 0x70EB80 VA: 0x180710180
	private void RpcLogic___PlayVO_Client_1710085680(EVOLineType lineType) { }

	// RVA: 0x711120 Offset: 0x70FB20 VA: 0x180711120
	private void RpcReader___Observers_PlayVO_Client_1710085680(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x70F440 Offset: 0x70DE40 VA: 0x18070F440
	private void RpcWriter___Target_ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked) { }

	// RVA: 0x710620 Offset: 0x70F020 VA: 0x180710620
	public void RpcLogic___ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked) { }

	// RVA: 0x712420 Offset: 0x710E20 VA: 0x180712420
	private void RpcReader___Target_ReceiveRelationshipData_4052192084(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x714A90 Offset: 0x713490 VA: 0x180714A90
	private void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed) { }

	// RVA: 0x710CE0 Offset: 0x70F6E0 VA: 0x180710CE0
	public void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed) { }

	// RVA: 0x712140 Offset: 0x710B40 VA: 0x180712140
	private void RpcReader___Server_SetIsBeingPickPocketed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x714560 Offset: 0x712F60 VA: 0x180714560
	private void RpcWriter___Server_SendRelationship_431000436(float relationship) { }

	// RVA: 0x7109F0 Offset: 0x70F3F0 VA: 0x1807109F0
	public void RpcLogic___SendRelationship_431000436(float relationship) { }

	// RVA: 0x711E50 Offset: 0x710850 VA: 0x180711E50
	private void RpcReader___Server_SendRelationship_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7109F0 Offset: 0x70F3F0 VA: 0x1807109F0
	private void RpcWriter___Observers_SetRelationship_431000436(float relationship) { }

	// RVA: 0x710E80 Offset: 0x70F880 VA: 0x180710E80
	private void RpcLogic___SetRelationship_431000436(float relationship) { }

	// RVA: 0x7118B0 Offset: 0x7102B0 VA: 0x1807118B0
	private void RpcReader___Observers_SetRelationship_431000436(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x718C70 Offset: 0x717670 VA: 0x180718C70
	public NetworkObject sync___get_value_PlayerConversant() { }

	// RVA: 0x718C80 Offset: 0x717680 VA: 0x180718C80
	public void sync___set_value_PlayerConversant(NetworkObject value, bool asServer) { }

	// RVA: 0x70F120 Offset: 0x70DB20 VA: 0x18070F120 Slot: 109
	public override bool ReadSyncVar___ScheduleOne.NPCs.NPC(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x70A800 Offset: 0x709200 VA: 0x18070A800 Slot: 110
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPC_Assembly-CSharp.dll() { }
}
