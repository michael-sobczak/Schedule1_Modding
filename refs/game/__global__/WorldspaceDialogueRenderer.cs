public class WorldspaceDialogueRenderer : MonoBehaviour // TypeDefIndex: 2727
{
	// Fields
	private const float FadeDist = 2;
	[CompilerGenerated]
	private string <ShownText>k__BackingField; // 0x20
	[Header("Settings")]
	public float MaxRange; // 0x28
	public float BaseScale; // 0x2C
	public AnimationCurve Scale; // 0x30
	public Vector2 Padding; // 0x38
	public Vector3 WorldSpaceOffset; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x50
	public CanvasGroup CanvasGroup; // 0x58
	public RectTransform Background; // 0x60
	public TextMeshProUGUI Text; // 0x68
	public Animation Anim; // 0x70
	private Vector3 localOffset; // 0x78
	private float CurrentOpacity; // 0x84
	private Coroutine hideCoroutine; // 0x88

	// Properties
	public string ShownText { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_ShownText() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_ShownText(string value) { }

	// RVA: 0x920E00 Offset: 0x91F800 VA: 0x180920E00
	private void Awake() { }

	// RVA: 0x920E80 Offset: 0x91F880 VA: 0x180920E80
	private void FixedUpdate() { }

	// RVA: 0x9212B0 Offset: 0x91FCB0 VA: 0x1809212B0
	private void LateUpdate() { }

	// RVA: 0x9216B0 Offset: 0x9200B0 VA: 0x1809216B0
	private void UpdatePosition() { }

	// RVA: 0x921330 Offset: 0x91FD30 VA: 0x180921330
	public void ShowText(string text, float duration = 0) { }

	// RVA: 0x921230 Offset: 0x91FC30 VA: 0x180921230
	public void HideText() { }

	// RVA: 0x9212D0 Offset: 0x91FCD0 VA: 0x1809212D0
	private void SetOpacity(float op) { }

	// RVA: 0x921AF0 Offset: 0x9204F0 VA: 0x180921AF0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(WorldspaceDialogueRenderer.<<ShowText>g__Wait|22_0>d))]
	// RVA: 0x921630 Offset: 0x920030 VA: 0x180921630
	private IEnumerator <ShowText>g__Wait|22_0(float dur) { }
}
