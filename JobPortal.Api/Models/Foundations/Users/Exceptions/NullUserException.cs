﻿namespace JobPortal.Api.Models.Foundations.Users.Exceptions
{
    public class NullUserException : Xeption
    {
        public NullUserException()
            : base(message: "User is null.") 
        { }
    }
}
