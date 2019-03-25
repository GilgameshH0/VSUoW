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
	public partial class Calendar : ContentPage
	{
        public List<MeropiList> MeropiList1 { get; set; }
        public Calendar ()
		{
			InitializeComponent ();
            MeropiList1 = new List<MeropiList>();

            MeropiList Ml0 = new MeropiList();
            Ml0.t1 = "06.03.2019";
            Ml0.T1 = "Закрытие ярмарки проектов";
            Ml0.T2 = "Защита проектов, торжественное закрытие ярморики проектов, награждение победителей.";
            MeropiList1.Add(Ml0);

            MeropiList Ml2 = new MeropiList();
            Ml2.t1 = "23.03.2018";
            Ml2.T1 = "День радиста";
            Ml2.T2 = "Всех ждем на дне радиста!";
            MeropiList1.Add(Ml2);

            MeropiList Ml3 = new MeropiList();
            Ml3.t1 = "6.04.2019";
            Ml3.T1 = "День открытых дверей НРУ";
            Ml3.T2 = "6 апреля 2019 года в 12-00 часов состоится День открытых дверей Нижегородского речного училища им.И.П.Кулибина. Место проведения - актовый зал университета. Приглашаются все желающие.";
            MeropiList1.Add(Ml3);

            //MeropiList Ml4 = new MeropiList();
            //Ml4.t1 = "10.03.2019";
            //Ml4.T1 = "Очень важное событие";
            //Ml4.T2 = "оно очень важно, приходите";
            //MeropiList1.Add(Ml4);

            //MeropiList Ml5 = new MeropiList();
            //Ml5.t1 = "10.03.2019";
            //Ml5.T1 = "Очень важное событие";
            //Ml5.T2 = "оно очень важно, приходите";
            //MeropiList1.Add(Ml5);

            //MeropiList Ml6 = new MeropiList();
            //Ml6.t1 = "10.03.2019";
            //Ml6.T1 = "Очень важное событие";
            //Ml6.T2 = "оно очень важно, приходите";
            //MeropiList1.Add(Ml6);

            //MeropiList Ml7 = new MeropiList();
            //Ml7.t1 = "10.03.2019";
            //Ml7.T1 = "Очень важное событие";
            //Ml7.T2 = "оно очень важно, приходите";
            //MeropiList1.Add(Ml7);
            this.BindingContext = this;

           
        }
	}
}