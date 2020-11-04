﻿using Connection;
using Sistema_punto_de_venta.Library;
using Sistema_punto_de_venta.Models;
using Sistema_punto_de_venta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Sistema_punto_de_venta.ViewModels
{
    public class UserViewModel : UserModel
    {
        private Connections _conn;
        private BitmapImage _bitmapImage;
        //private UploadImage uploadImage;
        private TextBox _textBoxNid, _textBoxName, _textBoxLastName;
        private TextBox _textBoxTelephone, _textBoxUser, _textBoxEmail;
        private TextBox _textBoxPass;
        private string filename, fillPath;

        public UserViewModel()
        {

        }
        public UserViewModel(object[] campos)
        {
            UserTittle = "Registrar usuarios";
            _textBoxNid = (TextBox)campos[0];
            _textBoxName = (TextBox)campos[1];
            _textBoxLastName = (TextBox)campos[2];
            _textBoxTelephone = (TextBox)campos[3];
            _textBoxEmail = (TextBox)campos[4];
            _textBoxPass = (TextBox)campos[5];
            _textBoxUser = (TextBox)campos[6];

            _conn = new Connections();
        }
        public ICommand AddCommand
        {
            get
            {
                return new CommandHandler(() => App.mContentFrame.Navigate(typeof(AddUser)));
            }
        }
        public ICommand AddUser
        {
            get
            {
                return new CommandHandler(async () => await RegisterUserAsync());
            }
        }
        private async Task RegisterUserAsync()
        {

        }
    }
}
