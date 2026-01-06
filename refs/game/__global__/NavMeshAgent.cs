public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 18858
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 desiredVelocity { get; }
	public float remainingDistance { get; }
	public bool isOnOffMeshLink { get; }
	public OffMeshLinkData currentOffMeshLinkData { get; }
	public bool hasPath { get; }
	public bool pathPending { get; }
	public bool isStopped { set; }
	public NavMeshPath path { get; }
	public int agentTypeID { get; set; }
	public int areaMask { get; }
	public float speed { set; }
	public ObstacleAvoidanceType obstacleAvoidanceType { set; }
	public int avoidancePriority { set; }
	public bool isOnNavMesh { get; }

	// Methods

	// RVA: 0x2C62420 Offset: 0x2C60E20 VA: 0x182C62420
	public bool SetDestination(Vector3 target) { }

	// RVA: 0x2C62930 Offset: 0x2C61330 VA: 0x182C62930
	public Vector3 get_velocity() { }

	// RVA: 0x2C62B30 Offset: 0x2C61530 VA: 0x182C62B30
	public void set_velocity(Vector3 value) { }

	// RVA: 0x2C626B0 Offset: 0x2C610B0 VA: 0x182C626B0
	public Vector3 get_desiredVelocity() { }

	// RVA: 0x2C628A0 Offset: 0x2C612A0 VA: 0x182C628A0
	public float get_remainingDistance() { }

	[NativeName("IsOnOffMeshLink")]
	// RVA: 0x2C62780 Offset: 0x2C61180 VA: 0x182C62780
	public bool get_isOnOffMeshLink() { }

	// RVA: 0x2C625E0 Offset: 0x2C60FE0 VA: 0x182C625E0
	public OffMeshLinkData get_currentOffMeshLinkData() { }

	[FreeFunction("NavMeshAgentScriptBindings::GetCurrentOffMeshLinkDataInternal", HasExplicitThis = True)]
	// RVA: 0x2C62290 Offset: 0x2C60C90 VA: 0x182C62290
	internal OffMeshLinkData GetCurrentOffMeshLinkDataInternal() { }

	// RVA: 0x2C621B0 Offset: 0x2C60BB0 VA: 0x182C621B0
	public void CompleteOffMeshLink() { }

	[NativeName("HasPath")]
	// RVA: 0x2C62700 Offset: 0x2C61100 VA: 0x182C62700
	public bool get_hasPath() { }

	[NativeName("PathPending")]
	// RVA: 0x2C627C0 Offset: 0x2C611C0 VA: 0x182C627C0
	public bool get_pathPending() { }

	// RVA: 0x2C62510 Offset: 0x2C60F10 VA: 0x182C62510
	public bool Warp(Vector3 newPosition) { }

	// RVA: 0x2C62340 Offset: 0x2C60D40 VA: 0x182C62340
	public void Move(Vector3 offset) { }

	[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = True)]
	// RVA: 0x2C62A00 Offset: 0x2C61400 VA: 0x182C62A00
	public void set_isStopped(bool value) { }

	// RVA: 0x2C62390 Offset: 0x2C60D90 VA: 0x182C62390
	public void ResetPath() { }

	// RVA: 0x2C62470 Offset: 0x2C60E70 VA: 0x182C62470
	public bool SetPath(NavMeshPath path) { }

	// RVA: 0x2C62800 Offset: 0x2C61200 VA: 0x182C62800
	public NavMeshPath get_path() { }

	[NativeMethod("CopyPath")]
	// RVA: 0x2C621F0 Offset: 0x2C60BF0 VA: 0x182C621F0
	internal void CopyPathTo(NavMeshPath path) { }

	// RVA: 0x2C62100 Offset: 0x2C60B00 VA: 0x182C62100
	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path) { }

	[FreeFunction("NavMeshAgentScriptBindings::CalculatePathInternal", HasExplicitThis = True)]
	// RVA: 0x2C620A0 Offset: 0x2C60AA0 VA: 0x182C620A0
	private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path) { }

	// RVA: 0x2C62560 Offset: 0x2C60F60 VA: 0x182C62560
	public int get_agentTypeID() { }

	// RVA: 0x2C62980 Offset: 0x2C61380 VA: 0x182C62980
	public void set_agentTypeID(int value) { }

	// RVA: 0x2C625A0 Offset: 0x2C60FA0 VA: 0x182C625A0
	public int get_areaMask() { }

	// RVA: 0x2C62A90 Offset: 0x2C61490 VA: 0x182C62A90
	public void set_speed(float value) { }

	// RVA: 0x2C62A50 Offset: 0x2C61450 VA: 0x182C62A50
	public void set_obstacleAvoidanceType(ObstacleAvoidanceType value) { }

	// RVA: 0x2C629C0 Offset: 0x2C613C0 VA: 0x182C629C0
	public void set_avoidancePriority(int value) { }

	[NativeName("InCrowdSystem")]
	// RVA: 0x2C62740 Offset: 0x2C61140 VA: 0x182C62740
	public bool get_isOnNavMesh() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C623D0 Offset: 0x2C60DD0 VA: 0x182C623D0
	private bool SetDestination_Injected(ref Vector3 target) { }

	// RVA: 0x2C628E0 Offset: 0x2C612E0 VA: 0x182C628E0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2C62AE0 Offset: 0x2C614E0 VA: 0x182C62AE0
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x2C62660 Offset: 0x2C61060 VA: 0x182C62660
	private void get_desiredVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x2C62240 Offset: 0x2C60C40 VA: 0x182C62240
	private void GetCurrentOffMeshLinkDataInternal_Injected(out OffMeshLinkData ret) { }

	// RVA: 0x2C624C0 Offset: 0x2C60EC0 VA: 0x182C624C0
	private bool Warp_Injected(ref Vector3 newPosition) { }

	// RVA: 0x2C622F0 Offset: 0x2C60CF0 VA: 0x182C622F0
	private void Move_Injected(ref Vector3 offset) { }

	// RVA: 0x2C62040 Offset: 0x2C60A40 VA: 0x182C62040
	private bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path) { }
}
