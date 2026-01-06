using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JeremyWilkinson : NPC
{
	public new static string NPCId => "jeremy_wilkinson";

	internal JeremyWilkinson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jeremy_wilkinson"))
	{
	}
}
