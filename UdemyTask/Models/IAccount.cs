using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTask.Models
{
    
        interface IAccount
        {
            bool PasswordChecker(string Password);



            void ShowInfo();



        }
    
}
