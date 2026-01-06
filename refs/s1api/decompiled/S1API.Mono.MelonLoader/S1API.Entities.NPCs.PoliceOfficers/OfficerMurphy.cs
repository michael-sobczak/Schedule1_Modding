using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerMurphy : NPC
{
	public new static string NPCId => "officermurphy";

	internal OfficerMurphy()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officermurphy"))
	{
	}
}
