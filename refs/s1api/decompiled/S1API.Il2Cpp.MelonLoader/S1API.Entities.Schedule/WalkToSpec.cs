using Il2CppScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class WalkToSpec : IScheduleActionSpec
{
	public Vector3 Destination { get; set; }

	public int StartTime { get; set; }

	public Vector3? Forward { get; set; }

	public bool FaceDestinationDirection { get; set; } = true;

	public float Within { get; set; } = 1f;

	public bool WarpIfSkipped { get; set; } = false;

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		NPCSignal_WalkToLocation val = schedule.AddActionInternal<NPCSignal_WalkToLocation>(StartTime, string.IsNullOrEmpty(Name) ? "WalkTo" : Name);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		Vector3? forward = null;
		Vector3 value;
		if (Forward.HasValue)
		{
			value = Forward.Value;
			if (((Vector3)(ref value)).sqrMagnitude > 0.001f)
			{
				value = Forward.Value;
				forward = ((Vector3)(ref value)).normalized;
				goto IL_00e8;
			}
		}
		Vector3 position = schedule.NPC.gameObject.transform.position;
		Vector3 val2 = Destination - position;
		if (((Vector3)(ref val2)).sqrMagnitude > 0.001f)
		{
			forward = ((Vector3)(ref val2)).normalized;
		}
		goto IL_00e8;
		IL_00e8:
		Transform val3 = NPCDestinationContainer.CreateDestinationMarker(((Object)schedule.NPC.gameObject).name, "Destination", Destination, forward);
		if (!((Object)(object)val3 != (Object)null))
		{
			return;
		}
		val.Destination = val3;
		int faceDestinationDir;
		if (Forward.HasValue)
		{
			value = Forward.Value;
			if (((Vector3)(ref value)).sqrMagnitude > 0.001f)
			{
				faceDestinationDir = 1;
				goto IL_015a;
			}
		}
		faceDestinationDir = (FaceDestinationDirection ? 1 : 0);
		goto IL_015a;
		IL_015a:
		val.FaceDestinationDir = (byte)faceDestinationDir != 0;
		val.DestinationThreshold = Mathf.Max(0.01f, Within);
		val.WarpIfSkipped = WarpIfSkipped;
	}
}
