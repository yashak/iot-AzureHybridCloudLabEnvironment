﻿using System.Runtime.Serialization;

namespace Common.Model
{
    [DataContract]
    public class Session : JsonBase<Session>
    {
        public Session(string ipAddress, int port, string username, string password)
        {
            IpAddress = ipAddress;
            Port = port;
            Username = username;
            Password = password;
        }

        [DataMember] public string IpAddress { get; set; }
        [DataMember] public int Port { get; set; }
        [DataMember] public string Username { get; set; }
        [DataMember] public string Password { get; set; }
        
        public override bool Equals(object? obj)
        {
            return obj != null && ((obj as Session)!).ToString().Equals(ToString());
        }

        public override int GetHashCode()
        {
            return (IpAddress + Port + Username + Password).GetHashCode();
        }

        public override string ToString()
        {
            return $"{IpAddress}:{Port} => {Username} : {Password}";
        }
    }
}
