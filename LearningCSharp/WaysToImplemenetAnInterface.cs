using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class WaysToImplemenetAnInterface
    {
        [Fact]
        public void MakingARegistration()
        {
            var invite = new SpecialEventRegistration(new Emailer())
            {
                DateOfEvent = new DateTime(2021, 4, 20),
                Employee = new Employee("Joe", "DEV", 230000),
                Event = "Fun Time Time"
            };

            invite.Invite();
            
        }
    }

    public enum ContentType { Plain, Html, Rtf }
    public class Emailer: IEmailPartyInvitations
    {
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public ContentType ContentType { get; set; }
        public string Content { get; set; }


        public void Send()
        {
            // actually send the email
        }

        void IEmailPartyInvitations.Invite(string to, string message)
        {
            Recipient = to;
            Content = message;
            ContentType = ContentType.Plain;
            From = "hostemail.com";
            Send();
        }
    }

    public class SpecialEventRegistration
    {
        private IEmailPartyInvitations _emailer;

        public SpecialEventRegistration(IEmailPartyInvitations emailer)
        {
            _emailer = emailer;
        }

        public Employee Employee { get; set; }
        public string Event { get; set; }
        public DateTime DateOfEvent { get; set; }

        public void Invite()
        {
            // save it to our calendar, mark one spot as taken, etc
            // send the employee an email with a reminder
            _emailer.Invite(Employee.Name + "@company.com", "Hi this your email");

        }
    }
}
