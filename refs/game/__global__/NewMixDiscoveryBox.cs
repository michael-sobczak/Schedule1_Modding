public class NewMixDiscoveryBox : MonoBehaviour // TypeDefIndex: 2464
{
	// Fields
	private bool isOpen; // 0x20
	[Header("References")]
	public Transform CameraPosition; // 0x28
	public TextMeshPro PropertiesText; // 0x30
	public Animation Animation; // 0x38
	public InteractableObject IntObj; // 0x40
	public Transform Lid; // 0x48
	public MultiTypeVisualsSetter Visuals; // 0x50
	private Pose closedLidPose; // 0x58
	private NewMixOperation currentMix; // 0x78

	// Methods

	// RVA: 0x8913B0 Offset: 0x88FDB0 VA: 0x1808913B0
	public void Start() { }

	// RVA: 0x890F20 Offset: 0x88F920 VA: 0x180890F20
	public void ShowProduct(ProductDefinition baseDefinition, List<Effect> properties) { }

	// RVA: 0x890E00 Offset: 0x88F800 VA: 0x180890E00
	private void CloseCase() { }

	// RVA: 0x890ED0 Offset: 0x88F8D0 VA: 0x180890ED0
	private void OpenCase() { }

	// RVA: 0x890E60 Offset: 0x88F860 VA: 0x180890E60
	private void Interacted() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
