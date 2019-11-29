// <copyright file="PlayerNotFoundException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// PlayerNotFoundException
// </summary>

namespace InfosAboutNBA.Logic
{
    using System;

    /// <summary>
    /// Exception for Players.
    /// </summary>
    public class PlayerNotFoundException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerNotFoundException"/> class.
        /// </summary>
        /// <param name="msg"> Message. </param>
        public PlayerNotFoundException(string msg)
            : base(msg)
        {
        }
    }
}
