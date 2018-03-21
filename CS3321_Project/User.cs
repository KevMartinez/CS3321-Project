using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    public abstract class User
    {
        private string _userId, _password, _name, _typeOfUser;

        public User(string userId, string password, string name, string type) //constructor 
        {
            this._userId = userId;
            this._password = password;
            this._name = name;
            this._typeOfUser = type;
        }

        public string GetName()
        {
            return this._name;
        }

        public string GetPassword()
        {
            return this._password;
        }

        public string GetId()
        {
            return this._userId;
        }

        public string GetTypeOfUser()
        {
            return this._typeOfUser;
        }

        public abstract ArrayList GetAllCourseAsAList();
        
    }
}
