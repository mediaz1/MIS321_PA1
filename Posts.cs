using System;


namespace MDiaz_PA1
{
    public class Posts
    {
    public class Posts : IComparable<Posts>
    {
        public string ID {get; set;}

        public string Post {get; set;}
        public  DateTime Timestamp{get; set;}

         public int CompareTo(Posts temp)
        {
            return this.Posts.CompareTo(temp.Title);
        }
        public static int CompareByAuthor(Book x, Book y)
        {
            return x.Author.Name.CompareTo(y.Author.Name);
        }
        public override string ToString()
        {
            return this.Title + " was written by " + this.Author.Name + " and has " + this.Pages + " pages";

        }

    }
}