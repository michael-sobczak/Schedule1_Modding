public class RunnerGame : TVApp // TypeDefIndex: 626
{
	// Fields
	public float GameSpeed; // 0x68
	public float MinGameSpeed; // 0x6C
	public float MaxGameSpeed; // 0x70
	public float SpeedIncreaseRate; // 0x74
	public int ScoreRate; // 0x78
	public float Gravity; // 0x7C
	public float JumpForce; // 0x80
	public float GlobalForceMultiplier; // 0x84
	public float DropForce; // 0x88
	public RectTransform Character; // 0x90
	public Flipboard CharacterFlipboard; // 0x98
	public SlidingRect Ground; // 0xA0
	public UISpawner CloudSpawner; // 0xA8
	public UISpawner ObstacleSpawner; // 0xB0
	public TextMeshProUGUI ScoreLabel; // 0xB8
	public TextMeshProUGUI HighScoreLabel; // 0xC0
	public GameObject StartScreen; // 0xC8
	public GameObject GameOverScreen; // 0xD0
	public Animation NewHighScoreAnimation; // 0xD8
	public Sprite JumpSprite; // 0xE0
	private bool isJumping; // 0xE8
	private bool isGrounded; // 0xE9
	private bool isReady; // 0xEA
	private float score; // 0xEC
	private float yVelocity; // 0xF0
	private float defaultCharacterY; // 0xF4
	private List<UIMover> clouds; // 0xF8
	private List<UIMover> obstacles; // 0x100
	public UnityEvent onJump; // 0x108
	public UnityEvent onHit; // 0x110
	public UnityEvent onNewHighScore; // 0x118

	// Methods

	// RVA: 0xAA1740 Offset: 0xAA0140 VA: 0x180AA1740 Slot: 4
	protected override void Awake() { }

	// RVA: 0xAA1C40 Offset: 0xAA0640 VA: 0x180AA1C40 Slot: 5
	public override void Open() { }

	// RVA: 0xAA21B0 Offset: 0xAA0BB0 VA: 0x180AA21B0 Slot: 9
	protected override void TryPause() { }

	// RVA: 0xAA21F0 Offset: 0xAA0BF0 VA: 0x180AA21F0
	public void Update() { }

	// RVA: 0xAA1B20 Offset: 0xAA0520 VA: 0x180AA1B20
	private void Jump() { }

	// RVA: 0xAA18A0 Offset: 0xAA02A0 VA: 0x180AA18A0
	private void CloudSpawned(GameObject cloud) { }

	// RVA: 0xAA1B60 Offset: 0xAA0560 VA: 0x180AA1B60
	private void ObstacleSpawned(GameObject obstacle) { }

	// RVA: 0xAA1CA0 Offset: 0xAA06A0 VA: 0x180AA1CA0
	private void RefreshHighScore() { }

	// RVA: 0xAA1C60 Offset: 0xAA0660 VA: 0x180AA1C60
	public void PlayerCollided() { }

	// RVA: 0xAA1980 Offset: 0xAA0380 VA: 0x180AA1980
	private void EndGame() { }

	// RVA: 0xAA2160 Offset: 0xAA0B60 VA: 0x180AA2160
	private void StartGame() { }

	// RVA: 0xAA1D90 Offset: 0xAA0790 VA: 0x180AA1D90
	private void ResetGame() { }

	// RVA: 0xAA2DA0 Offset: 0xAA17A0 VA: 0x180AA2DA0
	public void .ctor() { }
}
