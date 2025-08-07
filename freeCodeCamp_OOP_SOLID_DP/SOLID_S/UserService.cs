using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S
{
    public class UserService
    {
        public void Register(User user)
        {
            //Register user ligic...

            //Send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "We're back #$%^@");
        }
    }
}
