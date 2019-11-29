// <copyright file="CoachNotFoundException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// CoachNotFoundException
// </summary>

namespace InfosAboutNBA.Logic
{
    using System;

    /// <summary>
    /// Exception for Coaches.
    /// </summary>
    public class CoachNotFoundException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachNotFoundException"/> class.
        /// </summary>
        /// <param name="msg"> Message.</param>
        public CoachNotFoundException(string msg)
            : base(msg)
        {
        }
    }
}
