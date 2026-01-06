using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class GeorgeGreene : NPC
{
	public new static string NPCId => "george_greene";

	internal GeorgeGreene()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "george_greene"))
	{
	}
}
