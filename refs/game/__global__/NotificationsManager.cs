public class NotificationsManager : Singleton<NotificationsManager> // TypeDefIndex: 2646
{
	// Fields
	public const int MAX_NOTIFICATIONS = 6;
	[Header("References")]
	public RectTransform EntryContainer; // 0x28
	public AudioSourceController Sound; // 0x30
	[Header("Prefab")]
	public GameObject NotificationPrefab; // 0x38
	private Dictionary<RectTransform, Coroutine> coroutines; // 0x40
	private List<RectTransform> entries; // 0x48

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Update() { }

	// RVA: 0x8F9360 Offset: 0x8F7D60 VA: 0x1808F9360
	public void SendNotification(string title, string subtitle, Sprite icon, float duration = 5, bool playSound = True) { }

	// RVA: 0x8F98D0 Offset: 0x8F82D0 VA: 0x1808F98D0
	public void .ctor() { }
}
