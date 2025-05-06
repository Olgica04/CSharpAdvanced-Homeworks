using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Task1.Domain.Interfaces;

namespace Task1.Domain.Models
{
    public class Document : ISearchable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Document(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public bool Search(string word)
        {
            if (string.IsNullOrWhiteSpace(Description) || string.IsNullOrWhiteSpace(word))
                return false;

            var words = Description.ToLower().Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Any(w => w == word.ToLower());
        }
    }
}
