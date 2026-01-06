public sealed class TimeManager : MonoBehaviour // TypeDefIndex: 12825
{
	// Fields
	[CompilerGenerated]
	private Action<long> OnRoundTripTimeUpdated; // 0x20
	[CompilerGenerated]
	private Action OnPreTick; // 0x28
	[CompilerGenerated]
	private Action OnTick; // 0x30
	[CompilerGenerated]
	private Action<float> OnPrePhysicsSimulation; // 0x38
	[CompilerGenerated]
	private Action<float> OnPostPhysicsSimulation; // 0x40
	[CompilerGenerated]
	private Action OnPostTick; // 0x48
	[CompilerGenerated]
	private Action OnUpdate; // 0x50
	[CompilerGenerated]
	private Action OnLateUpdate; // 0x58
	[CompilerGenerated]
	private Action OnFixedUpdate; // 0x60
	[CompilerGenerated]
	private long <RoundTripTime>k__BackingField; // 0x68
	[CompilerGenerated]
	private uint <LastPacketTick>k__BackingField; // 0x70
	internal uint LastOrderedPacketTick; // 0x74
	[CompilerGenerated]
	private uint <Tick>k__BackingField; // 0x78
	[CompilerGenerated]
	private double <TickDelta>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <FrameTicked>k__BackingField; // 0x88
	[CompilerGenerated]
	private float <ServerUptime>k__BackingField; // 0x8C
	[CompilerGenerated]
	private float <ClientUptime>k__BackingField; // 0x90
	[Tooltip("When to invoke OnUpdate and other Unity callbacks relayed by the TimeManager.")]
	[SerializeField]
	private TimeManager.UpdateOrder _updateOrder; // 0x94
	[SerializeField]
	[Tooltip("Timing for sending and receiving data.")]
	private TimeManager.TimingType _timingType; // 0x98
	[SerializeField]
	[Tooltip("While true clients may drop local ticks if their devices are unable to maintain the tick rate. This could result in a temporary desynchronization but will prevent the client falling further behind on ticks by repeatedly running the logic cycle multiple times per frame.")]
	private bool _allowTickDropping; // 0x9C
	[SerializeField]
	[Tooltip("Maximum number of ticks which may occur in a single frame before remainder are dropped for the frame.")]
	[Range(1, 25)]
	private byte _maximumFrameTicks; // 0x9D
	[SerializeField]
	[Tooltip("How many times per second the server will simulate. This does not limit server frame rate.")]
	[Range(1, 240)]
	private ushort _tickRate; // 0x9E
	[Range(1, 15)]
	[SerializeField]
	[Tooltip("How often in seconds to a connections ping. This is also responsible for approximating server tick. This value does not affect prediction.")]
	private byte _pingInterval; // 0xA0
	[Tooltip("How to perform physics.")]
	[SerializeField]
	private PhysicsMode _physicsMode; // 0xA4
	private uint _clientTicks; // 0xA8
	private uint _lastUpdateTicks; // 0xAC
	private uint _localTick; // 0xB0
	private Stopwatch _pingStopwatch; // 0xB8
	private uint _pingTicks; // 0xC0
	private MovingAverage _pingAverage; // 0xC8
	private double _elapsedTickTime; // 0xD0
	private NetworkManager _networkManager; // 0xD8
	private double _adjustedTickDelta; // 0xE0
	private double[] _clientTimingRange; // 0xE8
	private int _lastIncomingIterationFrame; // 0xF0
	private bool _receivedPong; // 0xF4
	private float _lastMultipleTicksTime; // 0xF8
	private static uint _manualPhysics; // 0x0
	private float _timingTooFastCount; // 0xFC
	private bool _fixedUpdateTimeStep; // 0x100
	internal const float TIMING_INTERVAL = 1;
	public const uint UNSET_TICK = 0;
	private const float CLIENT_TIMING_PERCENT_RANGE = 0.5;
	private const double CLIENT_SPEEDUP_VALUE = 0.035;
	private const double CLIENT_SLOWDOWN_VALUE = 0.02;
	private const string SAVED_FIXED_TIME_TEXT = "SavedFixedTimeFN";
	private TimeManager.TimingUpdateChange _timingUpdateChange; // 0x104
	private float _updateChangeMultiplier; // 0x108

	// Properties
	public long RoundTripTime { get; set; }
	internal bool LowFrameRate { get; }
	public uint LastPacketTick { get; set; }
	public uint Tick { get; set; }
	[HideInInspector]
	public double TickDelta { get; set; }
	public bool FrameTicked { get; set; }
	public float ServerUptime { get; set; }
	public float ClientUptime { get; set; }
	public ushort TickRate { get; set; }
	public byte PingInterval { get; }
	public PhysicsMode PhysicsMode { get; }
	public uint LocalTick { get; set; }
	internal byte RESET_ADJUSTMENT_THRESHOLD { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xDA2410 Offset: 0xDA0E10 VA: 0x180DA2410
	public void add_OnRoundTripTimeUpdated(Action<long> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2A90 Offset: 0xDA1490 VA: 0x180DA2A90
	public void remove_OnRoundTripTimeUpdated(Action<long> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2370 Offset: 0xDA0D70 VA: 0x180DA2370
	public void add_OnPreTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA29F0 Offset: 0xDA13F0 VA: 0x180DA29F0
	public void remove_OnPreTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA24C0 Offset: 0xDA0EC0 VA: 0x180DA24C0
	public void add_OnTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA2B40 Offset: 0xDA1540 VA: 0x180DA2B40
	public void remove_OnTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA22C0 Offset: 0xDA0CC0 VA: 0x180DA22C0
	public void add_OnPrePhysicsSimulation(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2940 Offset: 0xDA1340 VA: 0x180DA2940
	public void remove_OnPrePhysicsSimulation(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2170 Offset: 0xDA0B70 VA: 0x180DA2170
	public void add_OnPostPhysicsSimulation(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0xDA27F0 Offset: 0xDA11F0 VA: 0x180DA27F0
	public void remove_OnPostPhysicsSimulation(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0xDA2220 Offset: 0xDA0C20 VA: 0x180DA2220
	public void add_OnPostTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA28A0 Offset: 0xDA12A0 VA: 0x180DA28A0
	public void remove_OnPostTick(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA2560 Offset: 0xDA0F60 VA: 0x180DA2560
	public void add_OnUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA2BE0 Offset: 0xDA15E0 VA: 0x180DA2BE0
	public void remove_OnUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA20D0 Offset: 0xDA0AD0 VA: 0x180DA20D0
	public void add_OnLateUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA2750 Offset: 0xDA1150 VA: 0x180DA2750
	public void remove_OnLateUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA2030 Offset: 0xDA0A30 VA: 0x180DA2030
	public void add_OnFixedUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0xDA26B0 Offset: 0xDA10B0 VA: 0x180DA26B0
	public void remove_OnFixedUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public long get_RoundTripTime() { }

	[CompilerGenerated]
	// RVA: 0xDA2C90 Offset: 0xDA1690 VA: 0x180DA2C90
	private void set_RoundTripTime(long value) { }

	// RVA: 0xDA2650 Offset: 0xDA1050 VA: 0x180DA2650
	internal bool get_LowFrameRate() { }

	[CompilerGenerated]
	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public uint get_LastPacketTick() { }

	[CompilerGenerated]
	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	private void set_LastPacketTick(uint value) { }

	// RVA: 0xDA1000 Offset: 0xD9FA00 VA: 0x180DA1000
	internal void SetLastPacketTick(uint tick) { }

	[CompilerGenerated]
	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public uint get_Tick() { }

	[CompilerGenerated]
	// RVA: 0x96CF20 Offset: 0x96B920 VA: 0x18096CF20
	internal void set_Tick(uint value) { }

	[CompilerGenerated]
	// RVA: 0xC491B0 Offset: 0xC47BB0 VA: 0x180C491B0
	public double get_TickDelta() { }

	[CompilerGenerated]
	// RVA: 0xC491D0 Offset: 0xC47BD0 VA: 0x180C491D0
	private void set_TickDelta(double value) { }

	[CompilerGenerated]
	// RVA: 0xDA2600 Offset: 0xDA1000 VA: 0x180DA2600
	public bool get_FrameTicked() { }

	[CompilerGenerated]
	// RVA: 0xDA2C80 Offset: 0xDA1680 VA: 0x180DA2C80
	private void set_FrameTicked(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8D2160 Offset: 0x8D0B60 VA: 0x1808D2160
	public float get_ServerUptime() { }

	[CompilerGenerated]
	// RVA: 0xBBA7A0 Offset: 0xBB91A0 VA: 0x180BBA7A0
	private void set_ServerUptime(float value) { }

	[CompilerGenerated]
	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	public float get_ClientUptime() { }

	[CompilerGenerated]
	// RVA: 0x7B13B0 Offset: 0x7AFDB0 VA: 0x1807B13B0
	private void set_ClientUptime(float value) { }

	// RVA: 0xDA26A0 Offset: 0xDA10A0 VA: 0x180DA26A0
	public ushort get_TickRate() { }

	// RVA: 0xDA2CA0 Offset: 0xDA16A0 VA: 0x180DA2CA0
	private void set_TickRate(ushort value) { }

	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	public byte get_PingInterval() { }

	// RVA: 0xBBA760 Offset: 0xBB9160 VA: 0x180BBA760
	public PhysicsMode get_PhysicsMode() { }

	// RVA: 0xDA2610 Offset: 0xDA1010 VA: 0x180DA2610
	public uint get_LocalTick() { }

	// RVA: 0xBBA7C0 Offset: 0xBB91C0 VA: 0x180BBA7C0
	private void set_LocalTick(uint value) { }

	// RVA: 0xDA2680 Offset: 0xDA1080 VA: 0x180DA2680
	internal byte get_RESET_ADJUSTMENT_THRESHOLD() { }

	// RVA: 0xDA11D0 Offset: 0xD9FBD0 VA: 0x180DA11D0
	internal void TickFixedUpdate() { }

	// RVA: 0xDA1340 Offset: 0xD9FD40 VA: 0x180DA1340
	internal void TickUpdate() { }

	// RVA: 0xDA1270 Offset: 0xD9FC70 VA: 0x180DA1270
	internal void TickLateUpdate() { }

	// RVA: 0xDA0170 Offset: 0xD9EB70 VA: 0x180DA0170
	internal void InitializeOnce_Internal(NetworkManager networkManager) { }

	// RVA: 0xD9F8D0 Offset: 0xD9E2D0 VA: 0x180D9F8D0
	private void AddNetworkLoops() { }

	// RVA: 0xD9F9C0 Offset: 0xD9E3C0 VA: 0x180D9F9C0
	private void ClientManager_OnClientConnectionState(ClientConnectionStateArgs obj) { }

	// RVA: 0xDA0DD0 Offset: 0xD9F7D0 VA: 0x180DA0DD0
	private void ServerManager_OnServerConnectionState(ServerConnectionStateArgs obj) { }

	// RVA: 0xDA0EE0 Offset: 0xD9F8E0 VA: 0x180DA0EE0
	private void SetInitialValues() { }

	// RVA: 0xDA1E30 Offset: 0xDA0830 VA: 0x180DA1E30
	private void UnsetSimulationSettings() { }

	// RVA: 0xDA0E20 Offset: 0xD9F820 VA: 0x180DA0E20
	private void SetAutomaticPhysicsSimulation(bool automatic) { }

	// RVA: 0xDA0380 Offset: 0xD9ED80 VA: 0x180DA0380
	private void InitializePhysicsMode(PhysicsMode mode) { }

	// RVA: 0xDA1010 Offset: 0xD9FA10 VA: 0x180DA1010
	public void SetPhysicsMode(PhysicsMode mode) { }

	// RVA: 0xDA0510 Offset: 0xD9EF10 VA: 0x180DA0510
	internal void ModifyPing(uint clientTick) { }

	// RVA: 0xDA1950 Offset: 0xDA0350 VA: 0x180DA1950
	private void TrySendPing(Nullable<uint> tickOverride) { }

	// RVA: 0xDA0970 Offset: 0xD9F370 VA: 0x180DA0970
	internal void SendPong(NetworkConnection conn, uint clientTick) { }

	// RVA: 0xD9FC30 Offset: 0xD9E630 VA: 0x180D9FC30
	private void IncreaseTick() { }

	// RVA: 0xD9FC10 Offset: 0xD9E610 VA: 0x180D9FC10
	public double GetTickPercent() { }

	// RVA: 0xD9FBE0 Offset: 0xD9E5E0 VA: 0x180D9FBE0
	public PreciseTick GetPreciseTick(uint tick) { }

	// RVA: 0xD9FA50 Offset: 0xD9E450 VA: 0x180D9FA50
	public PreciseTick GetPreciseTick(TickType tickType) { }

	// RVA: 0xDA14A0 Offset: 0xD9FEA0 VA: 0x180DA14A0
	public double TicksToTime(TickType tickType = 1) { }

	// RVA: 0xDA1590 Offset: 0xD9FF90 VA: 0x180DA1590
	public double TicksToTime(PreciseTick pt) { }

	// RVA: 0xDA15C0 Offset: 0xD9FFC0 VA: 0x180DA15C0
	public double TicksToTime(uint ticks) { }

	// RVA: 0xDA1620 Offset: 0xDA0020 VA: 0x180DA1620
	public double TimePassed(uint currentTick, uint previousTick) { }

	// RVA: 0xDA1670 Offset: 0xDA0070 VA: 0x180DA1670
	public double TimePassed(PreciseTick preciseTick, bool allowNegative = False) { }

	// RVA: 0xDA15E0 Offset: 0xD9FFE0 VA: 0x180DA15E0
	public double TimePassed(uint previousTick, bool allowNegative = False) { }

	// RVA: 0xDA17C0 Offset: 0xDA01C0 VA: 0x180DA17C0
	public uint TimeToTicks(double time, TickRounding rounding = 2) { }

	// RVA: 0xDA1290 Offset: 0xD9FC90 VA: 0x180DA1290
	public uint TickToLocalTick(uint tick) { }

	// RVA: 0xDA0490 Offset: 0xD9EE90 VA: 0x180DA0490
	public uint LocalTickToTick(uint localTick) { }

	// RVA: 0xDA1890 Offset: 0xDA0290 VA: 0x180DA1890
	private void TryIterateData(bool incoming) { }

	// RVA: 0xDA0AA0 Offset: 0xD9F4A0 VA: 0x180DA0AA0
	private void SendTimingAdjustment() { }

	// RVA: 0xDA0620 Offset: 0xD9F020 VA: 0x180DA0620
	internal void ParseTimingUpdate(PooledReader reader) { }

	// RVA: 0xDA1100 Offset: 0xD9FB00 VA: 0x180DA1100
	public void SetTickRate(ushort value) { }

	// RVA: 0xDA0610 Offset: 0xD9F010 VA: 0x180DA0610
	private void OnValidate() { }

	// RVA: 0xDA1EF0 Offset: 0xDA08F0 VA: 0x180DA1EF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xDA1DD0 Offset: 0xDA07D0 VA: 0x180DA1DD0
	private void <TickUpdate>g__MethodLogic|103_0() { }

	[CompilerGenerated]
	// RVA: 0xDA1D20 Offset: 0xDA0720 VA: 0x180DA1D20
	private void <ParseTimingUpdate>g__UpdateTick|135_0() { }
}
