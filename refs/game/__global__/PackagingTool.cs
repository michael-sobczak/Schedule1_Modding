public class PackagingTool : MonoBehaviour // TypeDefIndex: 2347
{
	// Fields
	[CompilerGenerated]
	private bool <ReceiveInput>k__BackingField; // 0x20
	private const float FinalizeRange_Min = 255;
	private const float FinalizeRange_Max = 270;
	[Header("Settings")]
	public float ConveyorSpeed; // 0x24
	public float ConveyorAcceleration; // 0x28
	public float BaggieRadius; // 0x2C
	public float JarRadius; // 0x30
	public float DeployAngle; // 0x34
	public float ProductInitialForce; // 0x38
	public float ProductRandomTorque; // 0x3C
	public float KickForce; // 0x40
	public float DropCooldown; // 0x44
	[Header("References")]
	public PackagingStation Station; // 0x48
	public Transform ConveyorModel; // 0x50
	public Animation DoorAnim; // 0x58
	public Animation CapAnim; // 0x60
	public Animation SealAnim; // 0x68
	public Animation KickAnim; // 0x70
	public Clickable LeftButton; // 0x78
	public Clickable RightButton; // 0x80
	public Clickable DropButton; // 0x88
	public Transform PackagingContainer; // 0x90
	public TextMeshPro ProductCountText; // 0x98
	public Transform HopperDropPoint; // 0xA0
	public Transform BaggieStartPoint; // 0xA8
	public Transform JarStartPoint; // 0xB0
	public Transform ProductContainer; // 0xB8
	public Transform KickOrigin; // 0xC0
	public SphereCollider HopperInputCollider; // 0xC8
	public AudioSourceController KickSound; // 0xD0
	public AudioSourceController MotorSound; // 0xD8
	public AudioSourceController DropSound; // 0xE0
	private FunctionalPackaging PackagingPrefab; // 0xE8
	private int ConcealedPackaging; // 0xF0
	private ProductItemInstance ProductItem; // 0xF8
	private FunctionalProduct ProductPrefab; // 0x100
	private int ProductInHopper; // 0x108
	private List<PackagingTool.PackagingInstance> PackagingInstances; // 0x110
	private List<FunctionalProduct> ProductInstances; // 0x118
	private List<FunctionalPackaging> FinalizedPackaging; // 0x120
	private float conveyorVelocity; // 0x128
	private int directionInput; // 0x12C
	private Task task; // 0x130
	private PackagingTool.PackagingInstance finalizeInstance; // 0x138
	private Coroutine finalizeCoroutine; // 0x140
	private bool leftDown; // 0x148
	private bool rightDown; // 0x149
	private bool dropDown; // 0x14A
	private float timeSinceLastDrop; // 0x14C

	// Properties
	public bool ReceiveInput { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_ReceiveInput() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_ReceiveInput(bool value) { }

	// RVA: 0x8630B0 Offset: 0x861AB0 VA: 0x1808630B0
	public void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity) { }

	// RVA: 0x862240 Offset: 0x860C40 VA: 0x180862240
	public void Deinitialize() { }

	// RVA: 0x863330 Offset: 0x861D30 VA: 0x180863330
	private void LoadPackaging(FunctionalPackaging prefab, int quantity) { }

	// RVA: 0x863670 Offset: 0x862070 VA: 0x180863670
	private void UnloadPackaging() { }

	// RVA: 0x863370 Offset: 0x861D70 VA: 0x180863370
	private void LoadProduct(ProductItemInstance product, int quantity) { }

	// RVA: 0x8636B0 Offset: 0x8620B0 VA: 0x1808636B0
	private void UnloadProduct() { }

	// RVA: 0x863AD0 Offset: 0x8624D0 VA: 0x180863AD0
	public void Update() { }

	// RVA: 0x863820 Offset: 0x862220 VA: 0x180863820
	private void UpdateInput() { }

	// RVA: 0x863A50 Offset: 0x862450 VA: 0x180863A50
	private void UpdateScreen() { }

	// RVA: 0x863750 Offset: 0x862150 VA: 0x180863750
	private void UpdateConveyor() { }

	// RVA: 0x863460 Offset: 0x861E60 VA: 0x180863460
	private void Rotate(float angle) { }

	// RVA: 0x861DF0 Offset: 0x8607F0 VA: 0x180861DF0
	private void CheckDeployPackaging() { }

	// RVA: 0x861EB0 Offset: 0x8608B0 VA: 0x180861EB0
	private void CheckFinalize() { }

	// RVA: 0x862FA0 Offset: 0x8619A0 VA: 0x180862FA0
	private void Finalize(PackagingTool.PackagingInstance instance) { }

	// RVA: 0x862CD0 Offset: 0x8616D0 VA: 0x180862CD0
	private void DropProduct() { }

	// RVA: 0x862020 Offset: 0x860A20 VA: 0x180862020
	private void CheckInsertions() { }

	// RVA: 0x863260 Offset: 0x861C60 VA: 0x180863260
	private void InsertIntoHopper(FunctionalProduct product) { }

	// RVA: 0x8626B0 Offset: 0x8610B0 VA: 0x1808626B0
	private void DeployPackaging() { }

	// RVA: 0x863E90 Offset: 0x862890 VA: 0x180863E90
	public void .ctor() { }
}
