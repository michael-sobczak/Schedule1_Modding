using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerBailey : NPC
{
	public new static string NPCId => "officerbailey";

	internal OfficerBailey()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officerbailey"))
	{
	}
}
