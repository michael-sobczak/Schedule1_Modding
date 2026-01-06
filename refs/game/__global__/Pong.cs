public class Pong : TVApp // TypeDefIndex: 623
{
	// Fields
	[CompilerGenerated]
	private Pong.EGameMode <GameMode>k__BackingField; // 0x68
	[CompilerGenerated]
	private Pong.EState <State>k__BackingField; // 0x6C
	[CompilerGenerated]
	private int <LeftScore>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <RightScore>k__BackingField; // 0x74
	public RectTransform Rect; // 0x78
	public PongPaddle LeftPaddle; // 0x80
	public PongPaddle RightPaddle; // 0x88
	public PongBall Ball; // 0x90
	public TextMeshProUGUI LeftScoreLabel; // 0x98
	public TextMeshProUGUI RightScoreLabel; // 0xA0
	public TextMeshProUGUI WinnerLabel; // 0xA8
	[Header("Settings")]
	public float InitialVelocity; // 0xB0
	public float VelocityGainPerSecond; // 0xB4
	public float MaxVelocity; // 0xB8
	public int GoalsToWin; // 0xBC
	[Header("AI")]
	public float ReactionTime; // 0xC0
	public float TargetRandomization; // 0xC4
	public float SpeedMultiplier; // 0xC8
	public UnityEvent onServe; // 0xD0
	public UnityEvent onLeftScore; // 0xD8
	public UnityEvent onRightScore; // 0xE0
	public UnityEvent onGameOver; // 0xE8
	public UnityEvent onLocalPlayerWin; // 0xF0
	public UnityEvent onReset; // 0xF8
	private Pong.ESide nextBallSide; // 0x100
	private Vector3 ballVelocity; // 0x104
	private float reactionTimer; // 0x110

	// Properties
	public Pong.EGameMode GameMode { get; set; }
	public Pong.EState State { get; set; }
	public int LeftScore { get; set; }
	public int RightScore { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public Pong.EGameMode get_GameMode() { }

	[CompilerGenerated]
	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_GameMode(Pong.EGameMode value) { }

	[CompilerGenerated]
	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public Pong.EState get_State() { }

	[CompilerGenerated]
	// RVA: 0xA9F820 Offset: 0xA9E220 VA: 0x180A9F820
	public void set_State(Pong.EState value) { }

	[CompilerGenerated]
	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public int get_LeftScore() { }

	[CompilerGenerated]
	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_LeftScore(int value) { }

	[CompilerGenerated]
	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	public int get_RightScore() { }

	[CompilerGenerated]
	// RVA: 0xA9F810 Offset: 0xA9E210 VA: 0x180A9F810
	public void set_RightScore(int value) { }

	// RVA: 0xA9F520 Offset: 0xA9DF20 VA: 0x180A9F520
	private void Update() { }

	// RVA: 0xA9E5F0 Offset: 0xA9CFF0 VA: 0x180A9E5F0
	private void FixedUpdate() { }

	// RVA: 0xA9EF20 Offset: 0xA9D920 VA: 0x180A9EF20 Slot: 9
	protected override void TryPause() { }

	// RVA: 0xA9F140 Offset: 0xA9DB40 VA: 0x180A9F140
	public void UpdateInputs() { }

	// RVA: 0xA9EF90 Offset: 0xA9D990 VA: 0x180A9EF90
	private void UpdateAI() { }

	// RVA: 0xA9E8A0 Offset: 0xA9D2A0 VA: 0x180A9E8A0
	public void GoalHit(Pong.ESide side) { }

	// RVA: 0xA9F560 Offset: 0xA9DF60 VA: 0x180A9F560
	private void Win(Pong.ESide winner) { }

	// RVA: 0xA9EA50 Offset: 0xA9D450 VA: 0x180A9EA50
	private void ResetBall() { }

	// RVA: 0xA9EDD0 Offset: 0xA9D7D0 VA: 0x180A9EDD0
	private void ServeBall() { }

	// RVA: 0xA9EC50 Offset: 0xA9D650 VA: 0x180A9EC50
	private void ResetGame() { }

	// RVA: 0xA9EEF0 Offset: 0xA9D8F0 VA: 0x180A9EEF0
	public void SetPaddleTargetY(Pong.ESide player, float y) { }

	// RVA: 0xA9ED60 Offset: 0xA9D760 VA: 0x180A9ED60 Slot: 7
	public override void Resume() { }

	// RVA: 0xA9F730 Offset: 0xA9E130 VA: 0x180A9F730
	public void .ctor() { }
}
