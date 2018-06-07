using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bookApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var books = GetMockBooks();
            bookListView.ItemsSource = books;

        }
        List<BookModel> GetMockBooks()
        {
            var books =new List<BookModel>();
            books.Add(new BookModel()
            {
                BookName = "Book name :Pokemon",
                Author = "Author : dinesh nallagachu",
                Price = "price: 56.3",
                Rating = 3,
                Bookimage = "pokemon.jpg",
               Synopsis= "Synopsis: Ash and company travel to Hoenn, a southern region in the Pokémon World. Ash takes on the role of a teacher and mentor for a novice Pokémon trainer named May. ",
            });

            books.Add(new BookModel()
            {
                BookName = "Book Name: Harry Potter",
                Author = "Author: Rowling",
                Price = "Price: 451",
                Rating = 5,
                Bookimage = "harrypotter.jpg",
                Synopsis= "Synopsis:The novels chronicle the life of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry. ",
            });
            books.Add(new BookModel()
            {
                BookName = "Book name: The Secret",
                Author = "Author: Carolyn",
                Price = "Price: 630",
                Rating = 4,
                Bookimage = "nancydrew.jpg",
                Synopsis = "Synopsis : Nancy Drew is a fictional American character in a mystery fiction series created by publisher Edward Stratemeyer as the female counterpart to his Hardy Boys series",
            }); 
            return books;
        }
        
        private void bookListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBook = e.SelectedItem as BookModel;
            Navigation.PushAsync(new bookdetails(selectedBook));
        }


    }
}
