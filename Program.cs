using System;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post("first post", "this is the first post");

            post.UpVote();
            Console.WriteLine(post.VoteCount);

            var post1 = new Post();
            post1.Title = "second post";
            post1.Description = "this is the 2nd post";
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.DownVote();
            post1.DownVote();

            Console.WriteLine("2nd Post total votes: " + post1.VoteCount + " Post was created on " + post1.DateCreated);
        }
    }
}
