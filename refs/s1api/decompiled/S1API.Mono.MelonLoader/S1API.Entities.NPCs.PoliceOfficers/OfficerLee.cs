using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerLee : NPC
{
	public new static string NPCId => "officerlee";

	internal OfficerLee()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officerlee"))
	{
	}
}
