using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerHoward : NPC
{
	public new static string NPCId => "officerhoward";

	internal OfficerHoward()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officerhoward"))
	{
	}
}
