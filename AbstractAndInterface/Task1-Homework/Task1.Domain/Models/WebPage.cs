
using Task1.Domain.Interfaces;

namespace Task1.Domain.Models
{
    public class WebPage : ISearchable
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }

        public WebPage(int id, string url, string content)
        {
            Id = id;
            Url = url;
            Content = content;
        }

        public bool Search(string word)
        {
            if (string.IsNullOrWhiteSpace(Content) || string.IsNullOrWhiteSpace(word))
                return false;

            var words = Content.ToLower().Split(new[] { ' ', '.', ',', ';', ':', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            return words.Any(w => w == word.ToLower());
        }
    }
}
