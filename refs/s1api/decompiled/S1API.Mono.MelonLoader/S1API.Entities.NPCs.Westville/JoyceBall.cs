using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class JoyceBall : NPC
{
	public new static string NPCId => "joyce_ball";

	internal JoyceBall()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "joyce_ball"))
	{
	}
}
