public class IconGenerator : Singleton<IconGenerator> // TypeDefIndex: 1908
{
	// Fields
	public int IconSize; // 0x28
	public string OutputPath; // 0x30
	public bool ModifyLighting; // 0x38
	[Header("References")]
	public Registry Registry; // 0x40
	public Camera CameraPosition; // 0x48
	public Transform MainContainer; // 0x50
	public Transform ItemContainer; // 0x58
	public GameObject Canvas; // 0x60
	public List<IconGenerator.PackagingVisuals> Visuals; // 0x68
	public UniversalRendererData rendererData; // 0x70

	// Methods

	// RVA: 0x77BE40 Offset: 0x77A840 VA: 0x18077BE40 Slot: 5
	protected override void Awake() { }

	[Button]
	// RVA: 0x77BF90 Offset: 0x77A990 VA: 0x18077BF90
	public void GenerateIcon() { }

	// RVA: 0x77C250 Offset: 0x77AC50 VA: 0x18077C250
	public Texture2D GeneratePackagingIcon(string packagingID, string productID) { }

	// RVA: 0x77C770 Offset: 0x77B170 VA: 0x18077C770
	public Texture2D GetTexture(Transform model) { }

	// RVA: 0x77CC80 Offset: 0x77B680 VA: 0x18077CC80
	public void .ctor() { }
}
