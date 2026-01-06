using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerLopez : NPC
{
	public new static string NPCId => "officerlopez";

	internal OfficerLopez()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officerlopez"))
	{
	}
}
