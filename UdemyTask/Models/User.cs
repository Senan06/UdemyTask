using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTask.Models
{
    public class User : IAccount
    {
        private static int _id;
        private string _email;
        private string _Password;
        private int _Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id++;
            }
        }
        public string FullName { get; set; }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@')
                    {
                        _email = value;
                    }
                }

                Console.WriteLine("Emailinizi düzgün daxil edin!");


            }

        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _Password = value;
                }
                else
                {
                    Console.WriteLine("Qaydalara uyğun şifre daxil edin!");
                }
            }
        }
        public bool PasswordChecker(string Password)
        {
            int UpCount = 0, NumCount = 0, UpntCount = 0;
            if (Password.Length > 7)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Char.IsUpper(Password[i])) UpCount++;
                    if (Char.IsNumber(Password[i])) NumCount++;
                    if (!Char.IsUpper(Password[i])) UpntCount++;

                }
                if ((UpCount - NumCount) != 0 && NumCount != 0 && UpCount != 0) return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"id {_id} Fullname{FullName} Email {Email}");
        }
        //	public User()
        //	{

        //	}
        public User(string Email, string Password)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.Password = Password;
            _Id++;
        }



    }
}
