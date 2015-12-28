using System.Net;

namespace Hexacket2016
{
    class HexaUser
    {
        #region Data
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private int _authkey;
        public int AuthKey
        {
            get { return _authkey; }
            set { _authkey = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _family;
        public string Family
        {
            get { return _family; }
            set { _family = value; }
        }


        private string _nickname;
        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }


        private IPAddress _ip;
        public IPAddress IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        #endregion
    }
}
