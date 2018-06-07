using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bookApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bookdetails : ContentPage
    {
        private BookModel seletedBook{get; set;}
		public bookdetails (BookModel selectedBook)
		{
			InitializeComponent ();
            selectedBook = selectedBook;
            ImageLable.Source = selectedBook.Bookimage;
            Name.Text = selectedBook.BookName;
            Author.Text = selectedBook.Author;
            Price.Text = selectedBook.Price.ToString();
            Rating.Text = selectedBook.Rating.ToString();
            Synopsis.Text = selectedBook.Synopsis;
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await DisplayAlert("Alert", "Book not available", "OK");  
        }
    }
}