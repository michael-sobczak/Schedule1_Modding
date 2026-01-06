public class AvatarEffects : MonoBehaviour // TypeDefIndex: 3098
{
	// Fields
	[Header("References")]
	public Avatar Avatar; // 0x20
	public ParticleSystem[] StinkParticles; // 0x28
	public ParticleSystem VomitParticles; // 0x30
	public ParticleSystem HeadPoofParticles; // 0x38
	public ParticleSystem FartParticles; // 0x40
	public ParticleSystem AntiGravParticles; // 0x48
	public ParticleSystem FireParticles; // 0x50
	public OptimizedLight FireLight; // 0x58
	public ParticleSystem FoggyEffects; // 0x60
	public Transform HeadBone; // 0x68
	public Transform NeckBone; // 0x70
	public AvatarEffects[] MirrorEffectsTo; // 0x78
	public ParticleSystem ZapParticles; // 0x80
	public CountdownExplosion CountdownExplosion; // 0x88
	public GameObject[] ObjectsToCull; // 0x90
	[Header("Settings")]
	public bool DisableHead; // 0x98
	[Header("Sounds")]
	public AudioSourceController GurgleSound; // 0xA0
	public AudioSourceController VomitSound; // 0xA8
	public AudioSourceController PoofSound; // 0xB0
	public AudioSourceController FartSound; // 0xB8
	public AudioSourceController FireSound; // 0xC0
	public AudioSourceController ZapSound; // 0xC8
	public AudioSourceController ZapLoopSound; // 0xD0
	[SerializeField]
	[Header("Smoothers")]
	private FloatSmoother AdditionalWeightController; // 0xD8
	[SerializeField]
	private FloatSmoother AdditionalGenderController; // 0xE0
	[SerializeField]
	private FloatSmoother HeadSizeBoost; // 0xE8
	[SerializeField]
	private FloatSmoother NeckSizeBoost; // 0xF0
	[SerializeField]
	private ColorSmoother SkinColorSmoother; // 0xF8
	private bool laxativeEnabled; // 0x100
	private Color currentEmission; // 0x104
	private Color targetEmission; // 0x114
	private bool isCulled; // 0x124

	// Methods

	// RVA: 0x98EC30 Offset: 0x98D630 VA: 0x18098EC30
	private void Start() { }

	// RVA: 0x98F110 Offset: 0x98DB10 VA: 0x18098F110
	public void Update() { }

	// RVA: 0x98DA50 Offset: 0x98C450 VA: 0x18098DA50
	private void SetEffectsCulled(bool culled) { }

	// RVA: 0x98E510 Offset: 0x98CF10 VA: 0x18098E510
	public void SetStinkParticlesActive(bool active, bool mirror = True) { }

	// RVA: 0x98EF40 Offset: 0x98D940 VA: 0x18098EF40
	public void TriggerSick(bool mirror = True) { }

	// RVA: 0x98D480 Offset: 0x98BE80 VA: 0x18098D480
	public void SetAntiGrav(bool active, bool mirror = True) { }

	// RVA: 0x98DCD0 Offset: 0x98C6D0 VA: 0x18098DCD0
	public void SetFoggy(bool active, bool mirror = True) { }

	// RVA: 0x98F8E0 Offset: 0x98E2E0 VA: 0x18098F8E0
	public void VanishHair(bool mirror = True) { }

	// RVA: 0x98E600 Offset: 0x98D000 VA: 0x18098E600
	public void SetZapped(bool zapped, bool mirror = True) { }

	// RVA: 0x98D340 Offset: 0x98BD40 VA: 0x18098D340
	public void ReturnHair(bool mirror = True) { }

	// RVA: 0x98CF10 Offset: 0x98B910 VA: 0x18098CF10
	public void OverrideHairColor(Color color, bool mirror = True) { }

	// RVA: 0x98D280 Offset: 0x98BC80 VA: 0x18098D280
	public void ResetHairColor(bool mirror = True) { }

	// RVA: 0x98CDD0 Offset: 0x98B7D0 VA: 0x18098CDD0
	public void OverrideEyeColor(Color color, float emission = 0.115, bool mirror = True) { }

	// RVA: 0x98D1C0 Offset: 0x98BBC0 VA: 0x18098D1C0
	public void ResetEyeColor(bool mirror = True) { }

	// RVA: 0x98DAE0 Offset: 0x98C4E0 VA: 0x18098DAE0
	public void SetEyeLightEmission(float intensity, Color color, bool mirror = True) { }

	// RVA: 0x98CC80 Offset: 0x98B680 VA: 0x18098CC80
	public void EnableLaxative(bool mirror = True) { }

	// RVA: 0x98CC00 Offset: 0x98B600 VA: 0x18098CC00
	public void DisableLaxative(bool mirror = True) { }

	// RVA: 0x98DC10 Offset: 0x98C610 VA: 0x18098DC10
	public void SetFireActive(bool active, bool mirror = True) { }

	// RVA: 0x98D530 Offset: 0x98BF30 VA: 0x18098D530
	public void SetBigHeadActive(bool active, bool mirror = True) { }

	// RVA: 0x98DEA0 Offset: 0x98C8A0 VA: 0x18098DEA0
	public void SetGiraffeActive(bool active, bool mirror = True) { }

	// RVA: 0x98E310 Offset: 0x98CD10 VA: 0x18098E310
	public void SetSkinColorInverted(bool inverted, bool mirror = True) { }

	// RVA: 0x98E0E0 Offset: 0x98CAE0 VA: 0x18098E0E0
	public void SetSicklySkinColor(bool mirror = True) { }

	// RVA: 0x98D940 Offset: 0x98C340 VA: 0x18098D940
	private void SetDefaultSkinColor(bool mirror = True) { }

	// RVA: 0x98DD80 Offset: 0x98C780 VA: 0x18098DD80
	public void SetGenderInverted(bool inverted, bool mirror = True) { }

	// RVA: 0x98CB30 Offset: 0x98B530 VA: 0x18098CB30
	public void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = True) { }

	// RVA: 0x98D120 Offset: 0x98BB20 VA: 0x18098D120
	public void RemoveAdditionalWeightOverride(string label, bool mirror = True) { }

	// RVA: 0x98E050 Offset: 0x98CA50 VA: 0x18098E050
	public void SetGlowingOn(Color color, bool mirror = True) { }

	// RVA: 0x98DFD0 Offset: 0x98C9D0 VA: 0x18098DFD0
	public void SetGlowingOff(bool mirror = True) { }

	// RVA: 0x98EEB0 Offset: 0x98D8B0 VA: 0x18098EEB0
	public void TriggerCountdownExplosion(bool mirror = True) { }

	// RVA: 0x98EE20 Offset: 0x98D820 VA: 0x18098EE20
	public void StopCountdownExplosion(bool mirror = True) { }

	// RVA: 0x98D620 Offset: 0x98C020 VA: 0x18098D620
	public void SetCyclopean(bool enabled, bool mirror = True) { }

	// RVA: 0x98E730 Offset: 0x98D130 VA: 0x18098E730
	public void SetZombified(bool zombified, bool mirror = True) { }

	// RVA: 0x98FA20 Offset: 0x98E420 VA: 0x18098FA20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x98F090 Offset: 0x98DA90 VA: 0x18098F090
	private void <Start>b__32_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(AvatarEffects.<<TriggerSick>g__Routine|36_0>d))]
	// RVA: 0x98F0A0 Offset: 0x98DAA0 VA: 0x18098F0A0
	private IEnumerator <TriggerSick>g__Routine|36_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(AvatarEffects.<<EnableLaxative>g__Routine|47_0>d))]
	// RVA: 0x98F020 Offset: 0x98DA20 VA: 0x18098F020
	private IEnumerator <EnableLaxative>g__Routine|47_0() { }
}
