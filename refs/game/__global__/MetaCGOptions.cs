public class MetaCGOptions : CurvyMetadataBase // TypeDefIndex: 10489
{
	// Fields
	[Positive]
	[SerializeField]
	private int m_MaterialID; // 0x38
	[FieldCondition("ShowUvEdgeOrHardEdge", True, False, 0, null, 1)]
	[SerializeField]
	private bool m_HardEdge; // 0x3C
	[SerializeField]
	[Positive(Tooltip = "Max step distance when using optimization")]
	private float m_MaxStepDistance; // 0x40
	[FieldCondition("ShowUvEdgeOrHardEdge", True, False, 0, null, 1)]
	[SerializeField]
	[Section("Extended UV", True, False, 100, HelpURL = "https://curvyeditor.com/doclink/metacgoptions_extendeduv")]
	private bool m_UVEdge; // 0x44
	[Positive]
	[FieldCondition("showExplicitU", True, False, 0, null, 1)]
	[SerializeField]
	private bool m_ExplicitU; // 0x45
	[SerializeField]
	[Positive]
	[FieldCondition("showFirstU", True, False, 0, null, 1)]
	[FieldAction("CBSetFirstU", 7)]
	private float m_FirstU; // 0x48
	[FieldCondition("showSecondU", True, False, 0, null, 1)]
	[Positive]
	[SerializeField]
	private float m_SecondU; // 0x4C
	[SerializeField]
	[HideInInspector]
	private bool uVEdgeUpdated; // 0x50
	private const int DefaultMaterialId = 0;

	// Properties
	public int MaterialID { get; set; }
	public bool HardEdge { get; set; }
	public bool CorrectedHardEdge { get; }
	public bool UVEdge { get; set; }
	public bool CorrectedUVEdge { get; }
	public bool ExplicitU { get; set; }
	public float FirstU { get; set; }
	public float SecondU { get; set; }
	public float MaxStepDistance { get; set; }
	public bool HasDifferentMaterial { get; }
	private bool ShowUvEdgeOrHardEdge { get; }
	private bool showExplicitU { get; }
	private bool showFirstU { get; }
	private bool showSecondU { get; }

	// Methods

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_MaterialID() { }

	// RVA: 0x496130 Offset: 0x494B30 VA: 0x180496130
	public void set_MaterialID(int value) { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_HardEdge() { }

	// RVA: 0x496110 Offset: 0x494B10 VA: 0x180496110
	public void set_HardEdge(bool value) { }

	// RVA: 0x495E10 Offset: 0x494810 VA: 0x180495E10
	public bool get_CorrectedHardEdge() { }

	// RVA: 0x495FF0 Offset: 0x4949F0 VA: 0x180495FF0
	public bool get_UVEdge() { }

	// RVA: 0x4961A0 Offset: 0x494BA0 VA: 0x1804961A0
	public void set_UVEdge(bool value) { }

	// RVA: 0x495E40 Offset: 0x494840 VA: 0x180495E40
	public bool get_CorrectedUVEdge() { }

	// RVA: 0x495E70 Offset: 0x494870 VA: 0x180495E70
	public bool get_ExplicitU() { }

	// RVA: 0x4960D0 Offset: 0x494AD0 VA: 0x1804960D0
	public void set_ExplicitU(bool value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_FirstU() { }

	// RVA: 0x4960F0 Offset: 0x494AF0 VA: 0x1804960F0
	public void set_FirstU(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_SecondU() { }

	// RVA: 0x496180 Offset: 0x494B80 VA: 0x180496180
	public void set_SecondU(float value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_MaxStepDistance() { }

	// RVA: 0x496150 Offset: 0x494B50 VA: 0x180496150
	public void set_MaxStepDistance(float value) { }

	// RVA: 0x495EA0 Offset: 0x4948A0 VA: 0x180495EA0
	public bool get_HasDifferentMaterial() { }

	// RVA: 0x495F80 Offset: 0x494980 VA: 0x180495F80
	private bool get_ShowUvEdgeOrHardEdge() { }

	// RVA: 0x496000 Offset: 0x494A00 VA: 0x180496000
	private bool get_showExplicitU() { }

	// RVA: 0x496090 Offset: 0x494A90 VA: 0x180496090
	private bool get_showFirstU() { }

	// RVA: 0x495E40 Offset: 0x494840 VA: 0x180495E40
	private bool get_showSecondU() { }

	// RVA: 0x495BF0 Offset: 0x4945F0 VA: 0x180495BF0 Slot: 7
	protected override void OnValidate() { }

	// RVA: 0x495BC0 Offset: 0x4945C0 VA: 0x180495BC0 Slot: 4
	protected override void OnEnable() { }

	// RVA: 0x495830 Offset: 0x494230 VA: 0x180495830 Slot: 9
	protected override void Awake() { }

	[UsedImplicitly]
	[Obsolete("Use ResetProperties instead")]
	// RVA: 0x495CF0 Offset: 0x4946F0 VA: 0x180495CF0
	public void Reset() { }

	// RVA: 0x495B10 Offset: 0x494510 VA: 0x180495B10
	public float GetDefinedFirstU(float defaultValue) { }

	// RVA: 0x495B60 Offset: 0x494560 VA: 0x180495B60
	public float GetDefinedSecondU(float defaultValue) { }

	// RVA: 0x495C00 Offset: 0x494600 VA: 0x180495C00
	public void ResetProperties() { }

	// RVA: 0x495A30 Offset: 0x494430 VA: 0x180495A30
	private void EnsureUVEdgeUpdate() { }

	// RVA: 0x495920 Offset: 0x494320 VA: 0x180495920
	private bool CanHaveUvEdgeOrHadrdEdge() { }

	// RVA: 0x495E00 Offset: 0x494800 VA: 0x180495E00
	public void .ctor() { }
}
