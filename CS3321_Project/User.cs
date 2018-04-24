﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace CS3321_Project
{    

    public class User 
    {
<<<<<<< HEAD
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
=======
        [JsonProperty("users")]
        public Dictionary<string, UserInfo> allUsers { get; set; }

        public bool userAuth(string username, string password)
        {
            if (allUsers.ContainsKey(username))
            {
                if (allUsers[username].password.Equals(password, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                } else { return false; }
                
            } else {  return false; }
        }

        public void addNewUser(string id, string name, string username, string password, string major, string userType, string courseID, ArrayList assignmentID)
        {
            UserInfo newUser = new UserInfo(id, name, major, userType, username, password, courseID, assignmentID);
            allUsers.Add(username, newUser);

        }

        public UserInfo getInfoOfAUser(string auth, bool UsingID)
        {
            if (UsingID)
            {
                foreach (var pair in allUsers)
                {
                    if (pair.Value.id.Equals(auth))
                    {
                        return allUsers[pair.Key];
                    }
                }
                return null;
            } else
            {
                return allUsers[auth];
            }
        }

        public string getTypeOfAUser(string username)
        {
            return allUsers[username].userType;
        }

    }

    public class UserInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("major")]
        public string major { get; set; }
        [JsonProperty("userType")]
        public string userType { get; set; }
        [JsonProperty("username")]
        public string username { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("courses")]
        public Dictionary<string, enrolledCourseInfo> allEnrolledCourses { get; set; }

        public UserInfo() { }
        
        public UserInfo(string id, string name, string major, string userType, string username, string password, string courseID, ArrayList assignmentIDList)
        {
            this.id = id;
            this.name = name;
            this.major = major;
            this.userType = userType;
            this.username = username;
            this.password = password;
            this.allEnrolledCourses = new Dictionary<string, enrolledCourseInfo>();

            enrolledCourseInfo newCourse = new enrolledCourseInfo(courseID, assignmentIDList);
            allEnrolledCourses.Add(courseID, newCourse);
>>>>>>> pr/5
        }
    }

<<<<<<< HEAD
        public abstract ArrayList GetAllCourseAsAList();
        
=======
    public class enrolledCourseInfo
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }

        public enrolledCourseInfo(string id, ArrayList assignmentIDList)
        {
            this.id = id;
            this.assignmentIDList = assignmentIDList;
        }
>>>>>>> pr/5
    }
}
