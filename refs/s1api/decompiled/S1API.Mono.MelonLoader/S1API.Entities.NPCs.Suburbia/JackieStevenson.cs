using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JackieStevenson : NPC
{
	public new static string NPCId => "jackie_stevenson";

	internal JackieStevenson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jackie_stevenson"))
	{
	}
}
