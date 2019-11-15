using System;

namespace InfosAboutNBA.Logic
{
    public class TeamNotFoundException : ApplicationException
    {
        public TeamNotFoundException(string msg)
            : base(msg)
        {
        }
    }
}
