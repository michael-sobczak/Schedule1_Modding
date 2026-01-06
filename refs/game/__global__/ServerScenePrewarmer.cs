public class ServerScenePrewarmer : NetworkBehaviour // TypeDefIndex: 18075
{
	// Fields
	[SerializeField]
	[Scene]
	private string[] _scenes; // 0x118
	private bool NetworkInitialize___EarlyFishNet.Demo.AdditiveScenes.ServerScenePrewarmerFishNet.Demos.dll_Excuted; // 0x120
	private bool NetworkInitialize__LateFishNet.Demo.AdditiveScenes.ServerScenePrewarmerFishNet.Demos.dll_Excuted; // 0x121

	// Methods

	// RVA: 0xCEF120 Offset: 0xCEDB20 VA: 0x180CEF120 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xCEF260 Offset: 0xCEDC60 VA: 0x180CEF260
	public void .ctor() { }

	// RVA: 0x837F50 Offset: 0x836950 VA: 0x180837F50 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5F97A0 Offset: 0x5F81A0 VA: 0x1805F97A0 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
