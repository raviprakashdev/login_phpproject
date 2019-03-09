using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Db
{
    #region Users
    public class Users
    {
        #region Member Variables
        protected int _id;
        protected string _name;
        protected string _lname;
        protected string _uname;
        protected string _email;
        protected string _password;
        protected string _picture;
        #endregion
        #region Constructors
        public Users() { }
        public Users(string name, string lname, string uname, string email, string password, string picture)
        {
            this._name=name;
            this._lname=lname;
            this._uname=uname;
            this._email=email;
            this._password=password;
            this._picture=picture;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Lname
        {
            get {return _lname;}
            set {_lname=value;}
        }
        public virtual string Uname
        {
            get {return _uname;}
            set {_uname=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Password
        {
            get {return _password;}
            set {_password=value;}
        }
        public virtual string Picture
        {
            get {return _picture;}
            set {_picture=value;}
        }
        #endregion
    }
    #endregion
}