using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MarcoBaron : NPC
{
	public new static string NPCId => "marco_baron";

	internal MarcoBaron()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "marco_baron"))
	{
	}
}
