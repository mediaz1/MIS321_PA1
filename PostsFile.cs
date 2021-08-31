using System;
using System.IO;
using System.Collections.Generic;
namespace MDiaz_PA1
{
    public class PostsFile
    {
        public static List<Posts> GetPosts()
        {
            List<Posts>  newPost = new List<Posts>();
            StreamReader inFile = null;
            
            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Something went wrong.... returning blank posts{0}", e);
                return newPost;
            }
            string line = inFile.ReadLine(); //priming read
            while (line!=null)
            {
                string [] temp = line.Split('#');
                int id= int.Parse(temp[2]);
                DateTime timeStamp = DateTime.Parse(temp[2]);
                newPost.Add(new Posts(){ID = id, TimeStamp = timeStamp, Post = temp[1]});
                line = inFile.ReadLine();  //update read

            }
            inFile.Close();

            return newPost;
        }
    }
}