public class TrafficLight : MonoBehaviour // TypeDefIndex: 3379
{
	// Fields
	public static float amberTime; // 0x0
	[Header("References")]
	[SerializeField]
	protected MeshRenderer redMesh; // 0x20
	[SerializeField]
	protected MeshRenderer orangeMesh; // 0x28
	[SerializeField]
	protected MeshRenderer greenMesh; // 0x30
	[Header("Materials")]
	[SerializeField]
	protected Material redOn_Mat; // 0x38
	[SerializeField]
	protected Material redOff_Mat; // 0x40
	[SerializeField]
	protected Material orangeOn_Mat; // 0x48
	[SerializeField]
	protected Material orangeOff_Mat; // 0x50
	[SerializeField]
	protected Material greenOn_Mat; // 0x58
	[SerializeField]
	protected Material greenOff_Mat; // 0x60
	[Header("Settings")]
	public TrafficLight.State state; // 0x68
	private TrafficLight.State appliedState; // 0x6C

	// Methods

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0xA792E0 Offset: 0xA77CE0 VA: 0x180A792E0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0xA79210 Offset: 0xA77C10 VA: 0x180A79210 Slot: 6
	protected virtual void ApplyState() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0xA79300 Offset: 0xA77D00 VA: 0x180A79300
	private static void .cctor() { }
}
