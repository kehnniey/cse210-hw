
    class VideoComment
    {
        private string Commenter { get; }
        private string Text { get; }

        public VideoComment(string commenter, string text)
        {
            Commenter = commenter;
            Text = text;
        }

        public string GetCommentDetails()
        {
            return $"{Commenter}: {Text}";
        }
    }

