public class PlayingCard : MonoBehaviour // TypeDefIndex: 2036
{
	// Fields
	[CompilerGenerated]
	private bool <IsFaceUp>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayingCard.ECardSuit <Suit>k__BackingField; // 0x24
	[CompilerGenerated]
	private PlayingCard.ECardValue <Value>k__BackingField; // 0x28
	[CompilerGenerated]
	private CardController <CardController>k__BackingField; // 0x30
	public string CardID; // 0x38
	[Header("References")]
	public SpriteRenderer CardSpriteRenderer; // 0x40
	public PlayingCard.CardSprite[] CardSprites; // 0x48
	public Animation FlipAnimation; // 0x50
	public AnimationClip FlipFaceUpClip; // 0x58
	public AnimationClip FlipFaceDownClip; // 0x60
	[Header("Sound")]
	public AudioSourceController FlipSound; // 0x68
	public AudioSourceController LandSound; // 0x70
	private Coroutine moveRoutine; // 0x78
	private Tuple<Vector3, Quaternion> lastGlideTarget; // 0x80

	// Properties
	public bool IsFaceUp { get; set; }
	public PlayingCard.ECardSuit Suit { get; set; }
	public PlayingCard.ECardValue Value { get; set; }
	public CardController CardController { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsFaceUp() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsFaceUp(bool value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public PlayingCard.ECardSuit get_Suit() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_Suit(PlayingCard.ECardSuit value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public PlayingCard.ECardValue get_Value() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_Value(PlayingCard.ECardValue value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public CardController get_CardController() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_CardController(CardController value) { }

	// RVA: 0x7D0E60 Offset: 0x7CF860 VA: 0x1807D0E60
	private void OnValidate() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void SetCardController(CardController cardController) { }

	// RVA: 0x7D0EE0 Offset: 0x7CF8E0 VA: 0x1807D0EE0
	public void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = True) { }

	// RVA: 0x7D09A0 Offset: 0x7CF3A0 VA: 0x1807D09A0
	public void ClearCard() { }

	// RVA: 0x7D10F0 Offset: 0x7CFAF0 VA: 0x1807D10F0
	public void SetFaceUp(bool faceUp, bool network = True) { }

	// RVA: 0x7D0AA0 Offset: 0x7CF4A0 VA: 0x1807D0AA0
	public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5, bool network = True) { }

	// RVA: 0x7D09C0 Offset: 0x7CF3C0 VA: 0x1807D09C0
	private PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val) { }

	[Button]
	// RVA: 0x7D1310 Offset: 0x7CFD10 VA: 0x1807D1310
	public void VerifyCardSprites() { }

	// RVA: 0x7D1810 Offset: 0x7D0210 VA: 0x1807D1810
	public void .ctor() { }
}
