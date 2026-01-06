public class Toaster : MonoBehaviour // TypeDefIndex: 18015
{
	// Fields
	[Tooltip("The toast prefab object")]
	[FormerlySerializedAs("toastPrefab")]
	[SerializeField]
	protected Toast ToastPrefab; // 0x20
	[FormerlySerializedAs("viewportAnchor")]
	[Tooltip("Where the toast will appear on screen")]
	[SerializeField]
	protected Toaster.ToastAnchor ViewportAnchor; // 0x28
	[SerializeField]
	[FormerlySerializedAs("popupDirection")]
	[Tooltip("Direction the toast will move when it appears")]
	protected Toaster.PopoutDirection PopupDirection; // 0x2C
	[FormerlySerializedAs("duration")]
	[SerializeField]
	[Tooltip("How long (seconds) a message remains on screen")]
	protected float Duration; // 0x30
	[SerializeField]
	[FormerlySerializedAs("animationDuration")]
	[Tooltip("How long (seconds) the slide in/out animation takes")]
	protected float AnimationDuration; // 0x34
	private List<Toast> inactive; // 0x38

	// Methods

	// RVA: 0x444470 Offset: 0x442E70 VA: 0x180444470
	public void Toast(string message) { }

	[IteratorStateMachine(typeof(Toaster.<ShowToast>d__7))]
	// RVA: 0x444330 Offset: 0x442D30 VA: 0x180444330
	private IEnumerator ShowToast(string message) { }

	[IteratorStateMachine(typeof(Toaster.<SlideAnim>d__8))]
	// RVA: 0x4443C0 Offset: 0x442DC0 VA: 0x1804443C0
	private IEnumerator SlideAnim(RectTransform rt, Vector2 from, Vector2 to, float speed) { }

	// RVA: 0x443DF0 Offset: 0x4427F0 VA: 0x180443DF0
	private Toast GetToast(string message) { }

	// RVA: 0x444260 Offset: 0x442C60 VA: 0x180444260
	private void ReturnToast(Toast toast) { }

	// RVA: 0x443C30 Offset: 0x442630 VA: 0x180443C30
	private Vector2 GetAnimationDirection(Toaster.PopoutDirection direction) { }

	// RVA: 0x444500 Offset: 0x442F00 VA: 0x180444500
	public void .ctor() { }
}
