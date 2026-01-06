using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class JackKnight : NPC
{
	public new static string NPCId => "jack_knight";

	internal JackKnight()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "jack_knight"))
	{
	}
}
