using System;
namespace InfosAboutNBA.Logic
{
    public class CoachNotFoundException : ApplicationException
    {
        public string Msg { get; set; }

        public CoachNotFoundException(string msg)
        {
            this.Msg = msg;
        }
    }

}
