public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager> // TypeDefIndex: 10510
{
	// Fields
	public static readonly Color DefaultDefaultGizmoColor; // 0x0
	public static readonly Color DefaultDefaultGizmoSelectionColor; // 0x10
	public static readonly Color DefaultGizmoOrientationColor; // 0x20
	public static bool HideManager; // 0x30
	public static bool SaveGeneratorOutputs; // 0x31
	public static float SceneViewResolution; // 0x34
	public static Color DefaultGizmoColor; // 0x38
	public static Color DefaultGizmoSelectionColor; // 0x48
	public static CurvyInterpolation DefaultInterpolation; // 0x58
	public static float GizmoControlPointSize; // 0x5C
	public static float GizmoOrientationLength; // 0x60
	public static Color GizmoOrientationColor; // 0x64
	public static int SplineLayer; // 0x74
	public static CurvySplineGizmos Gizmos; // 0x78
	private PoolManager poolManager; // 0x20
	private ComponentPool controlPointPool; // 0x28
	private ArrayPoolsSettings arrayPoolsSettings; // 0x30

	// Properties
	public static bool ShowCurveGizmo { get; set; }
	public static bool ShowConnectionsGizmo { get; set; }
	public static bool ShowApproximationGizmo { get; set; }
	public static bool ShowTangentsGizmo { get; set; }
	public static bool ShowOrientationGizmo { get; set; }
	public static bool ShowTFsGizmo { get; set; }
	public static bool ShowRelativeDistancesGizmo { get; set; }
	public static bool ShowLabelsGizmo { get; set; }
	public static bool ShowMetadataGizmo { get; set; }
	public static bool ShowBoundsGizmo { get; set; }
	public static bool ShowOrientationAnchorsGizmo { get; set; }
	public PoolManager PoolManager { get; }
	public ComponentPool ControlPointPool { get; }
	public ArrayPoolsSettings ArrayPoolsSettings { get; }
	public CurvyConnection[] Connections { get; }

	// Methods

	// RVA: 0x4A4CB0 Offset: 0x4A36B0 VA: 0x1804A4CB0
	public static bool get_ShowCurveGizmo() { }

	// RVA: 0x4A5160 Offset: 0x4A3B60 VA: 0x1804A5160
	public static void set_ShowCurveGizmo(bool value) { }

	// RVA: 0x4A4C50 Offset: 0x4A3650 VA: 0x1804A4C50
	public static bool get_ShowConnectionsGizmo() { }

	// RVA: 0x4A50D0 Offset: 0x4A3AD0 VA: 0x1804A50D0
	public static void set_ShowConnectionsGizmo(bool value) { }

	// RVA: 0x4A4B90 Offset: 0x4A3590 VA: 0x1804A4B90
	public static bool get_ShowApproximationGizmo() { }

	// RVA: 0x4A4FB0 Offset: 0x4A39B0 VA: 0x1804A4FB0
	public static void set_ShowApproximationGizmo(bool value) { }

	// RVA: 0x4A4F50 Offset: 0x4A3950 VA: 0x1804A4F50
	public static bool get_ShowTangentsGizmo() { }

	// RVA: 0x4A5550 Offset: 0x4A3F50 VA: 0x1804A5550
	public static void set_ShowTangentsGizmo(bool value) { }

	// RVA: 0x4A4E30 Offset: 0x4A3830 VA: 0x1804A4E30
	public static bool get_ShowOrientationGizmo() { }

	// RVA: 0x4A53A0 Offset: 0x4A3DA0 VA: 0x1804A53A0
	public static void set_ShowOrientationGizmo(bool value) { }

	// RVA: 0x4A4EF0 Offset: 0x4A38F0 VA: 0x1804A4EF0
	public static bool get_ShowTFsGizmo() { }

	// RVA: 0x4A54C0 Offset: 0x4A3EC0 VA: 0x1804A54C0
	public static void set_ShowTFsGizmo(bool value) { }

	// RVA: 0x4A4E90 Offset: 0x4A3890 VA: 0x1804A4E90
	public static bool get_ShowRelativeDistancesGizmo() { }

	// RVA: 0x4A5430 Offset: 0x4A3E30 VA: 0x1804A5430
	public static void set_ShowRelativeDistancesGizmo(bool value) { }

	// RVA: 0x4A4D10 Offset: 0x4A3710 VA: 0x1804A4D10
	public static bool get_ShowLabelsGizmo() { }

	// RVA: 0x4A51F0 Offset: 0x4A3BF0 VA: 0x1804A51F0
	public static void set_ShowLabelsGizmo(bool value) { }

	// RVA: 0x4A4D70 Offset: 0x4A3770 VA: 0x1804A4D70
	public static bool get_ShowMetadataGizmo() { }

	// RVA: 0x4A5280 Offset: 0x4A3C80 VA: 0x1804A5280
	public static void set_ShowMetadataGizmo(bool value) { }

	// RVA: 0x4A4BF0 Offset: 0x4A35F0 VA: 0x1804A4BF0
	public static bool get_ShowBoundsGizmo() { }

	// RVA: 0x4A5040 Offset: 0x4A3A40 VA: 0x1804A5040
	public static void set_ShowBoundsGizmo(bool value) { }

	// RVA: 0x4A4DD0 Offset: 0x4A37D0 VA: 0x1804A4DD0
	public static bool get_ShowOrientationAnchorsGizmo() { }

	// RVA: 0x4A5310 Offset: 0x4A3D10 VA: 0x1804A5310
	public static void set_ShowOrientationAnchorsGizmo(bool value) { }

	// RVA: 0x4A4B00 Offset: 0x4A3500 VA: 0x1804A4B00
	public PoolManager get_PoolManager() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ComponentPool get_ControlPointPool() { }

	// RVA: 0x4A4A30 Offset: 0x4A3430 VA: 0x1804A4A30
	public ArrayPoolsSettings get_ArrayPoolsSettings() { }

	// RVA: 0x4A4AC0 Offset: 0x4A34C0 VA: 0x1804A4AC0
	public CurvyConnection[] get_Connections() { }

	[UsedImplicitly]
	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x4A39F0 Offset: 0x4A23F0 VA: 0x1804A39F0
	public CurvyConnection[] GetContainingConnections(CurvySpline[] splines) { }

	// RVA: 0x4A37C0 Offset: 0x4A21C0 VA: 0x1804A37C0 Slot: 5
	public override void Awake() { }

	[UsedImplicitly]
	// RVA: 0x4A4800 Offset: 0x4A3200 VA: 0x1804A4800
	private void Start() { }

	[UsedImplicitly]
	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x4A3F90 Offset: 0x4A2990 VA: 0x1804A3F90
	private static void InitializeOnLoad() { }

	[RuntimeInitializeOnLoadMethod]
	[UsedImplicitly]
	// RVA: 0x4A3FF0 Offset: 0x4A29F0 VA: 0x1804A3FF0
	private static void LoadRuntimeSettings() { }

	// RVA: 0x4A4530 Offset: 0x4A2F30 VA: 0x1804A4530
	public static void SaveRuntimeSettings() { }

	// RVA: 0x4A43D0 Offset: 0x4A2DD0 VA: 0x1804A43D0 Slot: 6
	public override void MergeDoubleLoaded(IDTSingleton newInstance) { }

	// RVA: 0x4A49D0 Offset: 0x4A33D0 VA: 0x1804A49D0
	public void .ctor() { }

	// RVA: 0x4A48A0 Offset: 0x4A32A0 VA: 0x1804A48A0
	private static void .cctor() { }
}
