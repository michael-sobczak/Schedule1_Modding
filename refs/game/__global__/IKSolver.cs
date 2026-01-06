public abstract class IKSolver // TypeDefIndex: 14108
{
	// Fields
	[HideInInspector]
	public bool executedInEditor; // 0x10
	[HideInInspector]
	public Vector3 IKPosition; // 0x14
	[Range(0, 1)]
	[Tooltip("The positional or the master weight of the solver.")]
	public float IKPositionWeight; // 0x20
	[CompilerGenerated]
	private bool <initiated>k__BackingField; // 0x24
	public IKSolver.UpdateDelegate OnPreInitiate; // 0x28
	public IKSolver.UpdateDelegate OnPostInitiate; // 0x30
	public IKSolver.UpdateDelegate OnPreUpdate; // 0x38
	public IKSolver.UpdateDelegate OnPostUpdate; // 0x40
	protected bool firstInitiation; // 0x48
	[SerializeField]
	[HideInInspector]
	protected Transform root; // 0x50

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x1EE4D40 Offset: 0x1EE3740 VA: 0x181EE4D40
	public bool IsValid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsValid(ref string message);

	// RVA: 0x1EE4BC0 Offset: 0x1EE35C0 VA: 0x181EE4BC0
	public void Initiate(Transform root) { }

	// RVA: 0x1EE5170 Offset: 0x1EE3B70 VA: 0x181EE5170
	public void Update() { }

	// RVA: 0xFEA290 Offset: 0xFE8C90 VA: 0x180FEA290 Slot: 5
	public virtual Vector3 GetIKPosition() { }

	// RVA: 0x1EC75B0 Offset: 0x1EC5FB0 VA: 0x181EC75B0
	public void SetIKPosition(Vector3 position) { }

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float GetIKPositionWeight() { }

	// RVA: 0x1EE5140 Offset: 0x1EE3B40 VA: 0x181EE5140
	public void SetIKPositionWeight(float weight) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Transform GetRoot() { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_initiated() { }

	[CompilerGenerated]
	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_initiated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IKSolver.Point[] GetPoints();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IKSolver.Point GetPoint(Transform transform);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FixTransforms();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StoreDefaultLocalState();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnInitiate();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnUpdate();

	// RVA: 0x1EE4DA0 Offset: 0x1EE37A0 VA: 0x181EE4DA0
	protected void LogWarning(string message) { }

	// RVA: 0x1EE49E0 Offset: 0x1EE33E0 VA: 0x181EE49E0
	public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones) { }

	// RVA: 0x1EE4B20 Offset: 0x1EE3520 VA: 0x181EE4B20
	public static bool HierarchyIsValid(IKSolver.Bone[] bones) { }

	// RVA: 0x1EE4DC0 Offset: 0x1EE37C0 VA: 0x181EE4DC0
	protected static float PreSolveBones(ref IKSolver.Bone[] bones) { }

	// RVA: 0x1EE51F0 Offset: 0x1EE3BF0 VA: 0x181EE51F0
	protected void .ctor() { }
}
