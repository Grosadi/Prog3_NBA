// <copyright file="TeamNotFoundException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// TeamNotFoundException
// </summary>

namespace InfosAboutNBA.Logic
{
    using System;

    /// <summary>
    /// Expection for Teams.
    /// </summary>
    public class TeamNotFoundException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamNotFoundException"/> class.
        /// </summary>
        /// <param name="msg"> Message. </param>
        public TeamNotFoundException(string msg)
            : base(msg)
        {
        }
    }
}
