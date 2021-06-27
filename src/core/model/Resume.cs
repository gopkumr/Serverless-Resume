using System.Collections.Generic;

namespace ResumeApp.Core.Model{
public class Resume
    {
        public Meta meta { get; set; }
        public Basics basics { get; set; }
        public List<Education> education { get; set; }
        public List<Skill> skills { get; set; }
        public List<Award> awards { get; set; }
        public List<Work> work { get; set; }
        
    } 
    public class Meta
    {
        public string theme { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string countryCode { get; set; }
    }

    public class Profile
    {
        public string username { get; set; }
        public string url { get; set; }
        public string network { get; set; }
        public string icon{get;set;}
    }

    public class Basics
    {
        public string name { get; set; }
        public string label { get; set; }
        public string image { get; set; }
        public string summary { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public string phone{get;set;}
        public Location location { get; set; }
        public List<Profile> profiles { get; set; }
        public List<Interest> interests { get; set; }
    }

    public class Education
    {
        public string endDate { get; set; }
        public string startDate { get; set; }
        public string area { get; set; }
        public string studyType { get; set; }
        public string institution { get; set; }
    }

    public class Skill
    {
        public List<string> keywords { get; set; }
        public string level { get; set; }
        public string name { get; set; }
    }

    public class Award
    {
        public string title { get; set; }
        public string awarder { get; set; }
    }

    public class Work
    {
        public List<string> highlights { get; set; }
        public List<string> summary { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string position { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }

    public class Interest
    {
        public string name { get; set; }
    }

}    

