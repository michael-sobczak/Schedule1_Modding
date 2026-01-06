using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerCooper : NPC
{
	public new static string NPCId => "officercooper";

	internal OfficerCooper()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officercooper"))
	{
	}
}
