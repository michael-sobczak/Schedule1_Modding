public class Snake : TVApp // TypeDefIndex: 629
{
	// Fields
	public const int SIZE_X = 20;
	public const int SIZE_Y = 12;
	[Header("Settings")]
	public SnakeTile TilePrefab; // 0x68
	public float TimePerTile; // 0x70
	[Header("References")]
	public RectTransform PlaySpace; // 0x78
	public SnakeTile[] Tiles; // 0x80
	public TextMeshProUGUI ScoreText; // 0x88
	[CompilerGenerated]
	private Vector2 <HeadPosition>k__BackingField; // 0x90
	[CompilerGenerated]
	private List<Vector2> <Tail>k__BackingField; // 0x98
	[CompilerGenerated]
	private Vector2 <LastTailPosition>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Vector2 <Direction>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Vector2 <QueuedDirection>k__BackingField; // 0xB0
	[CompilerGenerated]
	private Vector2 <NextDirection>k__BackingField; // 0xB8
	private Vector2 lastFoodPosition; // 0xC0
	[CompilerGenerated]
	private Snake.EGameState <GameState>k__BackingField; // 0xC8
	private float _timeSinceLastMove; // 0xCC
	private float _timeOnGameOver; // 0xD0
	public UnityEvent onStart; // 0xD8
	public UnityEvent onEat; // 0xE0
	public UnityEvent onGameOver; // 0xE8
	public UnityEvent onWin; // 0xF0

	// Properties
	public Vector2 HeadPosition { get; set; }
	public List<Vector2> Tail { get; set; }
	public Vector2 LastTailPosition { get; set; }
	public Vector2 Direction { get; set; }
	public Vector2 QueuedDirection { get; set; }
	public Vector2 NextDirection { get; set; }
	public Snake.EGameState GameState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6A5260 Offset: 0x6A3C60 VA: 0x1806A5260
	public Vector2 get_HeadPosition() { }

	[CompilerGenerated]
	// RVA: 0xAA7270 Offset: 0xAA5C70 VA: 0x180AA7270
	private void set_HeadPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public List<Vector2> get_Tail() { }

	[CompilerGenerated]
	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	private void set_Tail(List<Vector2> value) { }

	[CompilerGenerated]
	// RVA: 0xAA71F0 Offset: 0xAA5BF0 VA: 0x180AA71F0
	public Vector2 get_LastTailPosition() { }

	[CompilerGenerated]
	// RVA: 0xAA7280 Offset: 0xAA5C80 VA: 0x180AA7280
	private void set_LastTailPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0xAA71D0 Offset: 0xAA5BD0 VA: 0x180AA71D0
	public Vector2 get_Direction() { }

	[CompilerGenerated]
	// RVA: 0xAA7260 Offset: 0xAA5C60 VA: 0x180AA7260
	private void set_Direction(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0xAA7230 Offset: 0xAA5C30 VA: 0x180AA7230
	public Vector2 get_QueuedDirection() { }

	[CompilerGenerated]
	// RVA: 0xAA72A0 Offset: 0xAA5CA0 VA: 0x180AA72A0
	private void set_QueuedDirection(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0xAA7210 Offset: 0xAA5C10 VA: 0x180AA7210
	public Vector2 get_NextDirection() { }

	[CompilerGenerated]
	// RVA: 0xAA7290 Offset: 0xAA5C90 VA: 0x180AA7290
	private void set_NextDirection(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public Snake.EGameState get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	private void set_GameState(Snake.EGameState value) { }

	// RVA: 0xAA59F0 Offset: 0xAA43F0 VA: 0x180AA59F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xAA6E90 Offset: 0xAA5890 VA: 0x180AA6E90
	private void Update() { }

	// RVA: 0xAA6990 Offset: 0xAA5390 VA: 0x180AA6990
	private void UpdateInput() { }

	// RVA: 0xAA6E30 Offset: 0xAA5830 VA: 0x180AA6E30
	private void UpdateMovement() { }

	// RVA: 0xAA5E00 Offset: 0xAA4800 VA: 0x180AA5E00
	private void MoveSnake() { }

	// RVA: 0xAA5D80 Offset: 0xAA4780 VA: 0x180AA5D80
	private SnakeTile GetTile(Vector2 position) { }

	// RVA: 0xAA6630 Offset: 0xAA5030 VA: 0x180AA6630
	private void StartGame(Vector2 initialDir) { }

	// RVA: 0xAA5C80 Offset: 0xAA4680 VA: 0x180AA5C80
	private void Eat() { }

	// RVA: 0xAA6450 Offset: 0xAA4E50 VA: 0x180AA6450
	private void SpawnFood() { }

	// RVA: 0xAA5D50 Offset: 0xAA4750 VA: 0x180AA5D50
	private void GameOver() { }

	// RVA: 0xAA6FA0 Offset: 0xAA59A0 VA: 0x180AA6FA0
	private void Win() { }

	// RVA: 0xAA6950 Offset: 0xAA5350 VA: 0x180AA6950 Slot: 9
	protected override void TryPause() { }

	[Button]
	// RVA: 0xAA5A00 Offset: 0xAA4400 VA: 0x180AA5A00
	public void CreateTiles() { }

	// RVA: 0xAA6FD0 Offset: 0xAA59D0 VA: 0x180AA6FD0
	public void .ctor() { }
}
