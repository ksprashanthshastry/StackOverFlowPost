using System;

namespace StackOverFlowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _dateCreated;
        private int _vote = 0;

        public string Title 
        {
            get { return this._title; } 
            set { this._title = value; } 
        }

        public string Description
        {
            get { return this._description; }
            set {this._description = value; } 
        }

        public DateTime DateCreated
        {
            get { return this._dateCreated; }
        }

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._dateCreated = DateTime.Now;
        }

        public Post(string title)
        {
            this._title = title;
            this._dateCreated = DateTime.Now;
        }

        public Post()
        {
            this._dateCreated = DateTime.Now;
        }

        public int VoteCount 
        {
            get { return this._vote; }  
        }

        public void UpVote()
        {
            _vote ++;
        }

        public void DownVote()
        {
            _vote--;
        }
    }
}
