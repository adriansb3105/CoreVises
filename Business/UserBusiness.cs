﻿using Data;
using Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBusiness
    {
        private UserData userData = new UserData();

        public Boolean UpdateUser(ObjectId objectId, User user)
        {
            return userData.UpdateUser(objectId, user);
        }

        public bool DeleteUser(ObjectId objectId)
        {
           return userData.DeleteUser(objectId);
        }
        public User SignUp(User user)
        {
            return userData.SignUp(user);

        }
        public User SearchUser(string userId)
        {
            return userData.SearchUser(userId);
        }

        public User LogIn(string email, string password)
        {
            return userData.LogIn(email, password);
        }
        public List<User> GetUsers()
        {
            return userData.GetUsers();
        }

        public User LogInAsAdmin(string email, string password)
        {
            return userData.LogInAsAdmin(email, password);
        }
        public bool verifyEmail(string email)
        {
            return userData.verifyEmail(email);
        }
    }
}
