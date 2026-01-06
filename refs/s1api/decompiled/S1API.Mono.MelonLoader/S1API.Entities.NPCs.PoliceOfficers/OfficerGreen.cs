using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerGreen : NPC
{
	public new static string NPCId => "officergreen";

	internal OfficerGreen()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "officergreen"))
	{
	}
}
