using Sipos_Vlad_Lab2.Models;

namespace Sipos_Vlad_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}
