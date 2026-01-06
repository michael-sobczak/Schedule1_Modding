public class CrimeStatusUI : MonoBehaviour // TypeDefIndex: 2665
{
	// Fields
	public const float SmallTextSize = 0.75;
	public const float LargeTextSize = 1;
	[Header("References")]
	public RectTransform CrimeStatusContainer; // 0x20
	public CanvasGroup CrimeStatusGroup; // 0x28
	public GameObject BodysearchLabel; // 0x30
	public Image InvestigatingMask; // 0x38
	public Image UnderArrestMask; // 0x40
	public Image WantedMask; // 0x48
	public Image WantedDeadMask; // 0x50
	public GameObject ArrestProgressContainer; // 0x58
	private bool animateText; // 0x60
	private Coroutine routine; // 0x68

	// Methods

	// RVA: 0x8F4CA0 Offset: 0x8F36A0 VA: 0x1808F4CA0
	public void UpdateStatus() { }

	// RVA: 0x8F4B70 Offset: 0x8F3570 VA: 0x1808F4B70
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(CrimeStatusUI.<Routine>d__14))]
	// RVA: 0x8F4C30 Offset: 0x8F3630 VA: 0x1808F4C30
	private IEnumerator Routine() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
