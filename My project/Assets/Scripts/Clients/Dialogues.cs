using System.Collections.Generic;

namespace Clients
{
    public static class Dialogues
    {
        public static Dictionary<string, Dictionary<DialogueState, string[]>> Phrases =
            new Dictionary<string, Dictionary<DialogueState, string[]>>
            {
                { "Abigaile", new Dictionary<DialogueState, string[]>
                    {
                        { DialogueState.Order, new[] {"!"} },
                        { DialogueState.Fail, new[] { "Здравствуйте", "Меня зовут <link=Абигейл>Абигейл</link>" } },
                        { DialogueState.Success, new[] { "Здравствуйте", "Меня зовут <link=Абигейл>Абигейл</link>" } }
                
                    }
                }
            };
    }
}