public abstract class DynamicOcclusionAbstractBase : MonoBehaviour // TypeDefIndex: 318
{
	// Fields
	public const string ClassName = "DynamicOcclusionAbstractBase";
	public DynamicOcclusionUpdateRate updateRate; // 0x20
	[FormerlySerializedAs("waitFrameCount")]
	public int waitXFrames; // 0x24
	[CompilerGenerated]
	private Action onOcclusionProcessed; // 0x28
	public static bool _INTERNAL_ApplyRandomFrameOffset; // 0x0
	private TransformUtils.Packed m_TransformPacked; // 0x30
	private int m_LastFrameRendered; // 0x58
	protected VolumetricLightBeamSD m_Master; // 0x60
	protected MaterialModifier.Callback m_MaterialModifierCallbackCached; // 0x68

	// Properties
	public int _INTERNAL_LastFrameRendered { get; }

	// Methods

	// RVA: 0x7AE1A0 Offset: 0x7ACBA0 VA: 0x1807AE1A0
	public void ProcessOcclusionManually() { }

	[CompilerGenerated]
	// RVA: 0x7AE480 Offset: 0x7ACE80 VA: 0x1807AE480
	public void add_onOcclusionProcessed(Action value) { }

	[CompilerGenerated]
	// RVA: 0x7AE520 Offset: 0x7ACF20 VA: 0x1807AE520
	public void remove_onOcclusionProcessed(Action value) { }

	// RVA: 0x7AE1B0 Offset: 0x7ACBB0 VA: 0x1807AE1B0
	protected void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get__INTERNAL_LastFrameRendered() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string GetShaderKeyword();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnEnablePostValidate();

	// RVA: 0x7AE0A0 Offset: 0x7ACAA0 VA: 0x1807AE0A0 Slot: 9
	protected virtual void OnValidateProperties() { }

	// RVA: 0x7ADA40 Offset: 0x7AC440 VA: 0x1807ADA40 Slot: 10
	protected virtual void Awake() { }

	// RVA: 0x7ADB00 Offset: 0x7AC500 VA: 0x1807ADB00 Slot: 11
	protected virtual void OnDestroy() { }

	// RVA: 0x7ADD00 Offset: 0x7AC700 VA: 0x1807ADD00 Slot: 12
	protected virtual void OnEnable() { }

	// RVA: 0x7ADB60 Offset: 0x7AC560 VA: 0x1807ADB60 Slot: 13
	protected virtual void OnDisable() { }

	// RVA: 0x7AE0D0 Offset: 0x7ACAD0 VA: 0x1807AE0D0
	private void OnWillCameraRender(Camera cam) { }

	// RVA: 0x7ADAC0 Offset: 0x7AC4C0 VA: 0x1807ADAC0
	private void DisableOcclusion() { }

	// RVA: 0x7AE460 Offset: 0x7ACE60 VA: 0x1807AE460
	protected void .ctor() { }

	// RVA: 0x7AE420 Offset: 0x7ACE20 VA: 0x1807AE420
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x7AE410 Offset: 0x7ACE10 VA: 0x1807AE410
	private void <OnEnable>b__24_0() { }
}
