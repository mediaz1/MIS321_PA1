using System.Diagnostics;
using System.Collections.Generic;
using System;


namespace MDiaz_PA1
{
    public class Posts : IComparable<Posts>
    {
        //creating our getters and setters
        public int ID {get; set;} 
        public string Post {get; set;}
        public  DateTime Timestamp{get; set;}

         public int CompareTo(Posts temp) //comparing posts to id
        {
            return this.ID.CompareTo(temp.ID);
        }
        public static int CompareByDateTime(Posts x, Posts y) //comparing by datetime 
        {
            return x.Timestamp.CompareTo(y.Timestamp);
        }
        public override string ToString()
        {
            return this.ID + " wrote: " + this.Post + " at this time: " + this.Timestamp;

        }
        public string ToFile()
        {
            return ID + "#" + Post + "#" + Timestamp;
        }
        public static void ShowPosts(List<Posts> tweets) //this will display all of the posts that we have in the txt file
        {
            foreach(Posts message in tweets)
            {
                Console.WriteLine(message.ToString());
            }
        }
        public static void AddPosts(List<Posts> tweets) //will add a post to our txt file 
        {
            int id =0;
            string tweet = "";
            DateTime tStamp = DateTime.Now;
            tweets.Sort(); //will sort our post
            
            if(tweets.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = tweets[tweets.Count-1].ID+1;
            }

            Console.WriteLine("What do you want to tweet?");
            tweet = Console.ReadLine();
            tweets.Add(new Posts(){ID = id, Post = tweet, Timestamp = tStamp}); // will add the post in the order listed
            tweets.Reverse(); 
            ShowPosts(tweets); //will display the post so the user can see what they added as well as what was already in there

        }
        public static void DeletePostsById(List<Posts> tweets) //will delete the posts by their id
        {
            //displays the post
            ShowPosts(tweets); 
            //asking the user what post they are wanting to delete
            Console.WriteLine("What post are you wanting to delete?");
            int deleteTweets = int.Parse(Console.ReadLine());
            //sorting the tweets
            tweets.Sort();
            //finding the index of the tweet that the user is wanting to delete
            //uses lambda to find the ID that we are wanting to delete
            int index = tweets.FindIndex(a => a.ID.Equals(deleteTweets));
            //removing tweet at index of users choice
            tweets.Remove(tweets[index]);
            //displaying the post that are left 
            ShowPosts(tweets);

        }

    }
}