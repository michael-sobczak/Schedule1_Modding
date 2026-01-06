using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class OscarHolland : NPC
{
	public new static string NPCId => "oscar_holland";

	internal OscarHolland()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "oscar_holland"))
	{
	}
}
