using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class JeffGilmore : NPC
{
	public new static string NPCId => "jeff_gilmore";

	internal JeffGilmore()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jeff_gilmore"))
	{
	}
}
