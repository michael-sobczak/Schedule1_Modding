public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 14962
{
	// Fields
	private Dictionary<int, bool> m_animations; // 0x20
	private TMP_Text m_TextComponent; // 0x28

	// Methods

	// RVA: 0x2C29200 Offset: 0x2C27C00 VA: 0x182C29200
	private void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnEnable() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnDisable() { }

	// RVA: 0x2C29440 Offset: 0x2C27E40 VA: 0x182C29440
	public void StopAllAnimations() { }

	// RVA: 0x2C29310 Offset: 0x2C27D10 VA: 0x182C29310
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachine(typeof(TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7))]
	// RVA: 0x2C29250 Offset: 0x2C27C50 VA: 0x182C29250
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	// RVA: 0x2C29490 Offset: 0x2C27E90 VA: 0x182C29490
	public void .ctor() { }
}
