using System;

namespace InfosAboutNBA.Logic
{
    public class PlayerNotFoundException : ApplicationException
    {
        public string Msg { get; set; }

        public PlayerNotFoundException(string msg)
        {
            this.Msg = msg;
        }
    }
}
