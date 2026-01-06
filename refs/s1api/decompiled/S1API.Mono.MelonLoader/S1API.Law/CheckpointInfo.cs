using UnityEngine;

namespace S1API.Law;

public sealed class CheckpointInfo
{
	public CheckpointLocation Location { get; internal set; }

	public bool IsEnabled { get; internal set; }

	public Vector3 Position { get; internal set; }

	public int AssignedOfficerCount { get; internal set; }

	public bool IsGate1Open { get; internal set; }

	public bool IsGate2Open { get; internal set; }

	public bool AreBothGatesClosed => !IsGate1Open && !IsGate2Open;

	public bool IsAnyGateOpen => IsGate1Open || IsGate2Open;

	public bool IsOperational => IsEnabled && AssignedOfficerCount > 0;
}
