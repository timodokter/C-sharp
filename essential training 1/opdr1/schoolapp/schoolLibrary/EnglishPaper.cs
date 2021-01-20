namespace schoolLibrary
{
    public class EnglishPaper
    {
        public string title { get; set; }
        public int MinimumWordCunt { get; set; }
        public string PaperText { get; set; }

        public int WordCount
        {
            get { return PaperText.WordCount(); }
        }
    }
}