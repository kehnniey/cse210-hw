using System.Collections.Generic;


    class YouTubeVideo
    {
        private string Title { get; }
        private string Author { get; }
        private int Length { get; }
        private List<VideoComment> Comments { get; }

        public YouTubeVideo(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<VideoComment>();
        }

        public YouTubeVideo AddComment(string commenter, string text)
        {
            Comments.Add(new VideoComment(commenter, text));
            return this;
        }

        public string GetVideoDetails()
        {
            return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of Comments: {Comments.Count}";
        }

        public List<string> GetComments()
        {
            List<string> commentDetails = new List<string>();
            foreach (var comment in Comments)
            {
                commentDetails.Add(comment.GetCommentDetails());
            }
            return commentDetails;
        }
    }

