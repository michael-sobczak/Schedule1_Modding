using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerJackson : NPC
{
	public new static string NPCId => "officerjackson";

	internal OfficerJackson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officerjackson"))
	{
	}
}
