﻿using FriendsForever.Models;
using FriendsForever.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FriendsForever.Services
{
    public class SecurityService : ISecurityService
    {
        private FriendsForeverEntities _context = null;
        public SecurityService()
        {
            _context = new FriendsForeverEntities();
        }
        public void SaveUserToDB(RegisterViewModel model)
        {
            UserDetails userDetails = new UserDetails();
            userDetails.Email = model.Email;
            userDetails.FristName = model.FristName;
            userDetails.LastName = model.LastName;
            userDetails.Password = model.Password;

            _context.UserDetails.Add(userDetails);
            _context.SaveChanges();
        }
    }
}