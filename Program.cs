using System.IO;
using System;
using System.Collections.Generic;

namespace MDiaz_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Posts> newPost = PostsFile.GetPosts();
           
            //menu should loop so that we dont have to go in it every time 
           
            Console.WriteLine($"What would you like to access?\n" +
            "Enter 1 to Show the Posts\n"+
            "Enter 2 to Add a post\n"+
            "Enter 3 to Delete a Post by the ID\n"+
            "Enter 4 to Exit the Program");
            int userResponse = int.Parse(Console.ReadLine());
            while (userResponse >= 5 && userResponse <=0)
            {
                Console.WriteLine("Invalid Selection. Please choose 1, 2, or 3");
                userResponse = int.Parse(Console.ReadLine());
                Console.Clear();
                
            }
            while(userResponse >=1 && userResponse <=4)
            {
                if (userResponse == 1)
                {
                    Posts.ShowPosts(newPost); //take the user to the show post method
                    Console.WriteLine($"What would you like to to access?\n" +
                    "Enter 1 to Show the Posts\n"+
                    "Enter 2 to Add a post\n"+
                    "Enter 3 to Delete a Post by the ID\n"+
                    "Enter 4 to Exit the Program");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                }
                    else if (userResponse ==2)
                {
                    Posts.AddPosts(newPost); //take the user to the add post method
                    PostsFile.WritePost(newPost);
                    Console.WriteLine($"What would you like to to access?\n" +
                    "Enter 1 to Show the Posts\n"+
                    "Enter 2 to Add a post\n"+
                    "Enter 3 to Delete a Post by the ID\n"+
                    "Enter 4 to Exit the Program");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (userResponse ==3)
                {
                    Posts.DeletePostsById(newPost); //take the user to the delete post method
                    PostsFile.WritePost(newPost);
                    Console.WriteLine($"What would you like to to access?\n" +
                    "Enter 1 to Show the Posts\n"+
                    "Enter 2 to Add a post\n"+
                    "Enter 3 to Delete a Post by the ID\n"+
                    "Enter 4 to Exit the Program");
                    userResponse = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if(userResponse ==4)
                {
                    Console.WriteLine("Have a nice day!");
                    Environment.Exit(0); //exits the program
                    Console.Clear();//console.clear  
                }
            }
            // else 
            // {
            //     Console.WriteLine("Have a nice day!");
            //     Environment.Exit(0); //exits the program
            //     Console.Clear();//console.clear
            // }
            
        }
    }
}
