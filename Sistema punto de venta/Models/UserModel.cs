﻿using Sales_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace Sistema_punto_de_venta.Models
{
    public class UserModel : PropertyChangedNotification
    {
        public string Email
        {
            get { return GetValue(() => Email); }
            set
            {
                SetValue(() => Email, value);
                EmailMessage = "";
                Message = "";
            }

        }
        public string Password
        {
            get { return GetValue(() => Password); }
            set
            {
                SetValue(() => Password, value);
                PasswordMessage = "";
                Message = "";
            }
        }
        public string Message
        {
            get { return GetValue(() => Message); }
            set { SetValue(() => Message, value); }
        }
        public string EmailMessage
        {
            get { return GetValue(() => EmailMessage); }
            set { SetValue(() => EmailMessage, value); }
        }
        public string PasswordMessage
        {
            get { return GetValue(() => PasswordMessage); }
            set { SetValue(() => PasswordMessage, value); }
        }

        public string Nid
        {
            get { return GetValue(() => Nid); }
            set
            {
                SetValue(() => Nid, value);
                Message = "";
            }
        }
        public string Name
        {
            get { return GetValue(() => Name); }
            set
            {
                SetValue(() => Name, value);
                Message = "";
            }
        }
        public string LastName
        {
            get { return GetValue(() => LastName); }
            set
            {
                SetValue(() => LastName, value);
                Message = "";
            }
        }
        public string Telephone
        {
            get { return GetValue(() => Telephone); }
            set
            {
                SetValue(() => Telephone, value);
                Message = "";
            }
        }
        public string User
        {
            get { return GetValue(() => User); }
            set
            {
                SetValue(() => User, value);
                Message = "";
            }
        }
        public List<string> ListRoles //lista de roles de combobox
        {
            get
            {
                return new List<string>
                {
                    "Admin",
                    "User"
                };
            }
        }
        public string UserTittle
        {
            get { return GetValue(() => UserTittle); }
            set
            {
                if (UserTittle == null || UserTittle.Equals(""))
                {
                    SetValue(()  => UserTittle , "Registrar Usuarios");
                }
                else
                {
                    SetValue(() => UserTittle, value);
                }
            }
        }
        public string SelectedRole
        {
            get { return GetValue(() => SelectedRole); }
            set { SetValue(() => SelectedRole, value); }
        }
    }
}
