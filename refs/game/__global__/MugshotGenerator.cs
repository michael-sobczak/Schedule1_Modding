public class MugshotGenerator : Singleton<MugshotGenerator> // TypeDefIndex: 3120
{
	// Fields
	public string OutputPath; // 0x28
	public AvatarSettings Settings; // 0x30
	[Header("References")]
	public Avatar MugshotRig; // 0x38
	public IconGenerator Generator; // 0x40
	public AvatarSettings DefaultSettings; // 0x48
	public Transform LookAtPosition; // 0x50
	private Texture2D finalTexture; // 0x58
	private bool generate; // 0x60

	// Methods

	// RVA: 0x9BBB70 Offset: 0x9BA570 VA: 0x1809BBB70 Slot: 5
	protected override void Awake() { }

	// RVA: 0x9BBF60 Offset: 0x9BA960 VA: 0x1809BBF60
	private void LateUpdate() { }

	// RVA: 0x9BBBE0 Offset: 0x9BA5E0 VA: 0x1809BBBE0
	private void FinalizeMugshot() { }

	[Button]
	// RVA: 0x9BBC80 Offset: 0x9BA680 VA: 0x1809BBC80
	public void GenerateMugshot() { }

	// RVA: 0x9BBCB0 Offset: 0x9BA6B0 VA: 0x1809BBCB0
	public void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback) { }

	// RVA: 0x9BC010 Offset: 0x9BAA10 VA: 0x1809BC010
	public void .ctor() { }
}
