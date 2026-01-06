public class Outliner : MonoBehaviour // TypeDefIndex: 10836
{
	// Fields
	private static List<Outlinable> temporaryOutlinables; // 0x0
	private OutlineParameters parameters; // 0x20
	private Camera targetCamera; // 0x28
	[SerializeField]
	private RenderStage stage; // 0x30
	[SerializeField]
	private OutlineRenderingStrategy renderingStrategy; // 0x34
	[SerializeField]
	private RenderingMode renderingMode; // 0x38
	[SerializeField]
	private long outlineLayerMask; // 0x40
	[SerializeField]
	private BufferSizeMode primaryBufferSizeMode; // 0x48
	[SerializeField]
	[Range(0.15, 1)]
	private float primaryRendererScale; // 0x4C
	[SerializeField]
	private int primarySizeReference; // 0x50
	[SerializeField]
	[Range(0, 2)]
	private float blurShift; // 0x54
	[SerializeField]
	[Range(0, 2)]
	private float dilateShift; // 0x58
	[SerializeField]
	[FormerlySerializedAs("dilateIterrations")]
	private int dilateIterations; // 0x5C
	[SerializeField]
	private DilateQuality dilateQuality; // 0x60
	[FormerlySerializedAs("blurIterrations")]
	[SerializeField]
	private int blurIterations; // 0x64
	[SerializeField]
	private BlurType blurType; // 0x68

	// Properties
	[Obsolete]
	public float InfoRendererScale { get; set; }
	public int PrimarySizeReference { get; set; }
	public BufferSizeMode PrimaryBufferSizeMode { get; set; }
	private CameraEvent Event { get; }
	public OutlineRenderingStrategy RenderingStrategy { get; set; }
	public RenderStage RenderStage { get; set; }
	public DilateQuality DilateQuality { get; set; }
	private RenderingMode RenderingMode { get; set; }
	public float BlurShift { get; set; }
	public float DilateShift { get; set; }
	public long OutlineLayerMask { get; set; }
	public float PrimaryRendererScale { get; set; }
	[Obsolete("Fixed incorrect spelling. Use BlurIterations instead")]
	public int BlurIterrations { get; set; }
	public int BlurIterations { get; set; }
	public BlurType BlurType { get; set; }
	[Obsolete("Fixed incorrect spelling. Use DilateIterations instead")]
	public int DilateIterration { get; set; }
	public int DilateIterations { get; set; }

	// Methods

	// RVA: 0x54CEF0 Offset: 0x54B8F0 VA: 0x18054CEF0
	public float get_InfoRendererScale() { }

	// RVA: 0x54CFE0 Offset: 0x54B9E0 VA: 0x18054CFE0
	public void set_InfoRendererScale(float value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_PrimarySizeReference() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_PrimarySizeReference(int value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public BufferSizeMode get_PrimaryBufferSizeMode() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_PrimaryBufferSizeMode(BufferSizeMode value) { }

	// RVA: 0x54CED0 Offset: 0x54B8D0 VA: 0x18054CED0
	private CameraEvent get_Event() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public OutlineRenderingStrategy get_RenderingStrategy() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_RenderingStrategy(OutlineRenderingStrategy value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public RenderStage get_RenderStage() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_RenderStage(RenderStage value) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public DilateQuality get_DilateQuality() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	public void set_DilateQuality(DilateQuality value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	private RenderingMode get_RenderingMode() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	private void set_RenderingMode(RenderingMode value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_BlurShift() { }

	// RVA: 0x54CF50 Offset: 0x54B950 VA: 0x18054CF50
	public void set_BlurShift(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_DilateShift() { }

	// RVA: 0x54CFB0 Offset: 0x54B9B0 VA: 0x18054CFB0
	public void set_DilateShift(float value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_OutlineLayerMask() { }

	// RVA: 0x54D020 Offset: 0x54BA20 VA: 0x18054D020
	public void set_OutlineLayerMask(long value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_PrimaryRendererScale() { }

	// RVA: 0x54D030 Offset: 0x54BA30 VA: 0x18054D030
	public void set_PrimaryRendererScale(float value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_BlurIterrations() { }

	// RVA: 0x54CF30 Offset: 0x54B930 VA: 0x18054CF30
	public void set_BlurIterrations(int value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_BlurIterations() { }

	// RVA: 0x54CF30 Offset: 0x54B930 VA: 0x18054CF30
	public void set_BlurIterations(int value) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public BlurType get_BlurType() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_BlurType(BlurType value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public int get_DilateIterration() { }

	// RVA: 0x54CF90 Offset: 0x54B990 VA: 0x18054CF90
	public void set_DilateIterration(int value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public int get_DilateIterations() { }

	// RVA: 0x54CF90 Offset: 0x54B990 VA: 0x18054CF90
	public void set_DilateIterations(int value) { }

	// RVA: 0x54C210 Offset: 0x54AC10 VA: 0x18054C210
	private void OnValidate() { }

	// RVA: 0x54BFE0 Offset: 0x54A9E0 VA: 0x18054BFE0
	private void OnEnable() { }

	// RVA: 0x54BEB0 Offset: 0x54A8B0 VA: 0x18054BEB0
	private void OnDestroy() { }

	// RVA: 0x54BF40 Offset: 0x54A940 VA: 0x18054BF40
	private void OnDisable() { }

	// RVA: 0x54C600 Offset: 0x54B000 VA: 0x18054C600
	private void UpdateBuffer(Camera targetCamera, CommandBuffer buffer, bool removeOnly) { }

	// RVA: 0x54C140 Offset: 0x54AB40 VA: 0x18054C140
	private void OnPreRender() { }

	// RVA: 0x54C230 Offset: 0x54AC30 VA: 0x18054C230
	private void SetupOutline(Camera cameraToUse, OutlineParameters parametersToUse, bool isEditor) { }

	// RVA: 0x54CAA0 Offset: 0x54B4A0 VA: 0x18054CAA0
	public void UpdateSharedParameters(OutlineParameters parameters, Camera camera, bool editorCamera) { }

	// RVA: 0x54C690 Offset: 0x54B090 VA: 0x18054C690
	private void UpdateParameters(OutlineParameters parameters, Camera camera, bool editorCamera) { }

	// RVA: 0x54CC20 Offset: 0x54B620 VA: 0x18054CC20
	public void .ctor() { }

	// RVA: 0x54CB90 Offset: 0x54B590 VA: 0x18054CB90
	private static void .cctor() { }
}
