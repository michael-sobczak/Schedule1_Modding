using Il2CppScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace S1API.Entities.Schedule;

public sealed class LocationDialogueSpec : IScheduleActionSpec
{
	public Vector3 Destination { get; set; }

	public Vector3? Forward { get; set; }

	public int StartTime { get; set; }

	public bool FaceDestinationDirection { get; set; } = true;

	public float Within { get; set; } = 1f;

	public bool WarpIfSkipped { get; set; } = false;

	public int GreetingOverrideToEnable { get; set; } = -1;

	public int ChoiceToEnable { get; set; } = -1;

	public string Name { get; set; }

	void IScheduleActionSpec.ApplyTo(NPCSchedule schedule)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		NPCEvent_LocationDialogue val = schedule.AddActionInternal<NPCEvent_LocationDialogue>(StartTime, string.IsNullOrEmpty(Name) ? "LocationDialogue" : Name);
		if (!((Object)(object)val == (Object)null))
		{
			Transform val2 = NPCDestinationContainer.CreateDestinationMarker(((Object)schedule.NPC.gameObject).name, "Marker", Destination, Forward);
			if ((Object)(object)val2 != (Object)null)
			{
				val.Destination = val2;
				val.FaceDestinationDir = FaceDestinationDirection;
				val.DestinationThreshold = Mathf.Max(0.01f, Within);
				val.WarpIfSkipped = WarpIfSkipped;
				val.GreetingOverrideToEnable = GreetingOverrideToEnable;
				val.ChoiceToEnable = ChoiceToEnable;
			}
		}
	}
}
