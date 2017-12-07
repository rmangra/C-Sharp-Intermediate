using System;

namespace StackOverflow
{
    class Post
    {
        private readonly String _title;
        public String Title
        {
            get { return _title; }

        }
        private readonly String _description;
        public String Description
        {
            get { return _description; }

        }
        private readonly DateTime _timestamp;
        public DateTime TimeStamp
        {
            get { return _timestamp; }

        }
        private int _vote;
        public int Vote
        {
            get { return _vote; }

        }

        private Post() { }
        public Post(String title, String description, int vote)
        {
            this._title = title;
            this._description = description;
            this._timestamp = DateTime.Now;
            this._vote = vote;
        }
        public int up_vote()
        {

            return ++_vote;

        }
        public int down_vote()
        {
            if (_vote > 0)
                return --_vote;
            return _vote;
        }
    }
}