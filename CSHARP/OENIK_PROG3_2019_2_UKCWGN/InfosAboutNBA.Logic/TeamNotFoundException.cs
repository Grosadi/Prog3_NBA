using System;

namespace InfosAboutNBA.Logic
{
    public class TeamNotFoundException : ApplicationException
    {
        public string Msg { get; set; }

        public TeamNotFoundException(string msg)
        {
            this.Msg = msg;
        }
    }
}
