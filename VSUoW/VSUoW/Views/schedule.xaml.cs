using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VSUoW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class schedule : ContentPage
	{
        public List<Speciality> Specialities { get; set; }
        public schedule ()
		{
			InitializeComponent ();
            Specialities = new List<Speciality>
            {
                new Speciality { Title = "Радисты", Path = "" },
                new Speciality {Title="Электромеханики"},
                new Speciality {Title="Экономисты"},
                new Speciality {Title="Юристы"}
            };
            this.BindingContext = this;
            
        }
        public class Speciality
        {
            public string Title { get; set; }
            public string Path { get; set; }
           
        }
       

        private void SpecialitiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}