using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerOakley : NPC
{
	public new static string NPCId => "officeroakley";

	internal OfficerOakley()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officeroakley"))
	{
	}
}
