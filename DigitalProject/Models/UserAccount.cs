using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DigitalProject.Exceptions;
using SqlKata;
using SqlKata.Execution;

namespace DigitalProject.Models
{
    public class UserAccount
    {
        public int UserId;

        public string FirstName;

        public string LastName;

        public string Username;

        public string Password;

        public DateTime DateOfBirth;

        public int Points;

        public static int CreateUserAccount(UserAccount account)
        {
            return DatabaseManager.QueryFactory.Query("Users").InsertGetId<int>(new
            {
                Firstname = account.FirstName,
                Lastname = account.LastName,
                Username = account.Username,
                Password = account.Password,
                DateOfBirth = account.DateOfBirth,
                Points = 0
            });
        }

        public static IEnumerable<UserAccount> GetAccountsOrderByPoints()
        {
            return DatabaseManager.QueryFactory.Query("Users").OrderByDesc("Points").Get<UserAccount>();
        }

        public static UserAccount GetAccount(string username)
        {
            var user = DatabaseManager.QueryFactory.Query("Users").Where("username", username).FirstOrDefault<UserAccount>();
            if (user == null)
            {
                throw new UserNotFoundException(username);
            }

            return user;
        }

        public static UserAccount GetAccount(int id)
        {
            var user = DatabaseManager.QueryFactory.Query("Users").Where("userid", id).FirstOrDefault<UserAccount>();

            return user;
        }

        public bool UpdatePoints(int value)
        {
            int affected = DatabaseManager.QueryFactory.Query("Users").Where("userid", UserId).Update(new
            {
                Points = value
            });

            if (affected > 0)
            {
                return true;
            }

            return false;
        }
    }
}
