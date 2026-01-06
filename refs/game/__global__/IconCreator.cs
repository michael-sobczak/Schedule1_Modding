public class IconCreator : MonoBehaviour // TypeDefIndex: 512
{
	// Fields
	protected bool isCreatingIcons; // 0x20
	public bool useDafaultName; // 0x21
	public bool includeResolutionInFileName; // 0x22
	public string iconFileName; // 0x28
	public IconCreator.SaveLocation pathLocation; // 0x30
	public IconCreator.Mode mode; // 0x34
	public string folderName; // 0x38
	public bool useTransparency; // 0x40
	public bool lookAtObjectCenter; // 0x41
	public bool dynamicFov; // 0x42
	public float fovOffset; // 0x44
	protected string finalPath; // 0x48
	private Vector3 mousePostion; // 0x50
	public KeyCode nextIconKey; // 0x5C
	protected bool CanMove; // 0x60
	public bool preview; // 0x61
	protected Camera whiteCam; // 0x68
	protected Camera blackCam; // 0x70
	public Camera mainCam; // 0x78
	protected Texture2D texBlack; // 0x80
	protected Texture2D texWhite; // 0x88
	protected Texture2D finalTexture; // 0x90
	private CameraClearFlags originalClearFlags; // 0x98
	protected Transform currentObject; // 0xA0

	// Methods

	// RVA: 0xA83E40 Offset: 0xA82840 VA: 0x180A83E40
	private void Awake() { }

	// RVA: 0xA85680 Offset: 0xA84080 VA: 0x180A85680
	protected void Initialize() { }

	// RVA: 0xA84890 Offset: 0xA83290 VA: 0x180A84890
	protected void DeleteCameras() { }

	// RVA: 0xA83F60 Offset: 0xA82960 VA: 0x180A83F60 Slot: 4
	public virtual void BuildIcons() { }

	[IteratorStateMachine(typeof(IconCreator.<CaptureFrame>d__30))]
	// RVA: 0xA84340 Offset: 0xA82D40 VA: 0x180A84340
	protected IEnumerator CaptureFrame(string objectName, int i) { }

	// RVA: 0xA85D80 Offset: 0xA84780 VA: 0x180A85D80 Slot: 5
	protected virtual void Update() { }

	// RVA: 0xA859D0 Offset: 0xA843D0 VA: 0x180A859D0
	private void RenderCamToTexture(Camera cam, Texture2D tex) { }

	// RVA: 0xA844D0 Offset: 0xA82ED0 VA: 0x180A844D0
	private void CreateBlackAndWhiteCameras() { }

	// RVA: 0xA846F0 Offset: 0xA830F0 VA: 0x180A846F0
	protected void CreateNewFolderForIcons() { }

	// RVA: 0xA84B70 Offset: 0xA83570 VA: 0x180A84B70
	public string GetFinalFolder() { }

	// RVA: 0xA86000 Offset: 0xA84A00 VA: 0x180A86000
	private void WriteScreenImageToTexture(Texture2D tex) { }

	// RVA: 0xA84160 Offset: 0xA82B60 VA: 0x180A84160
	private void CalculateOutputTexture() { }

	// RVA: 0xA85A90 Offset: 0xA84490 VA: 0x180A85A90
	private void SavePng(string name, int i) { }

	// RVA: 0xA84A80 Offset: 0xA83480 VA: 0x180A84A80
	public string GetFileName(string name, int i) { }

	// RVA: 0xA83FC0 Offset: 0xA829C0 VA: 0x180A83FC0
	private void CacheAndInitialiseFields() { }

	// RVA: 0xA85C20 Offset: 0xA84620 VA: 0x180A85C20
	protected void UpdateFOV(GameObject targetItem) { }

	// RVA: 0xA85CA0 Offset: 0xA846A0 VA: 0x180A85CA0
	protected void UpdateFOV(float value) { }

	// RVA: 0xA857D0 Offset: 0xA841D0 VA: 0x180A857D0
	protected void LookAtTargetCenter(GameObject targetItem) { }

	// RVA: 0xA84F00 Offset: 0xA83900 VA: 0x180A84F00
	private float GetTargetFov(GameObject a) { }

	// RVA: 0xA84DF0 Offset: 0xA837F0 VA: 0x180A84DF0
	private List<Renderer> GetRenderers(GameObject obj) { }

	// RVA: 0xA84C00 Offset: 0xA83600 VA: 0x180A84C00
	private Vector3 GetMeshCenter(GameObject a) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	protected void RevealInFinder() { }

	// RVA: 0xA843E0 Offset: 0xA82DE0 VA: 0x180A843E0 Slot: 6
	public virtual bool CheckConditions() { }

	// RVA: 0xA84990 Offset: 0xA83390 VA: 0x180A84990
	private string GetBaseLocation() { }

	// RVA: 0xA85940 Offset: 0xA84340 VA: 0x180A85940
	private void OnValidate() { }

	// RVA: 0xA86080 Offset: 0xA84A80 VA: 0x180A86080
	public void .ctor() { }
}
