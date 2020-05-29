using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Info
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();

            Call.Click += Call_Click;
            Write.Click += Write_Click;
            Add.Click += Add_Click;
        }
        
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            "TrueName",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, NameChanged));

        public string TrueName
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        private static void NameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var NameForm = obj as Info;
            NameForm.FName.Text = NameForm.TrueName.ToString();
        }





        public static readonly DependencyProperty SurnameProperty = DependencyProperty.Register(
            "TrueSurame",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, SurnameChanged));

        public string TrueSurame
        {
            get { return (string)GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }

        private static void SurnameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var SurnameForm = obj as Info;
            SurnameForm.FSurname.Text = SurnameForm.TrueSurame.ToString();
        }


        




        public static readonly DependencyProperty AgeProperty = DependencyProperty.Register(
           "TrueAge",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, AgeChanged));

        public string TrueAge
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        private static void AgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var AgeForm = obj as Info;
            AgeForm.FAge.Text = AgeForm.TrueAge.ToString();
        }


        


        public static readonly DependencyProperty CompanyProperty = DependencyProperty.Register(
           "TrueCompany",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, CompanyChanged));

        public string TrueCompany
        {
            get { return (string)GetValue(CompanyProperty); }
            set { SetValue(CompanyProperty, value); }
        }

        private static void CompanyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var CompanyForm = obj as Info;
            CompanyForm.FCompany.Text = CompanyForm.TrueCompany.ToString();
        }


        



        public static readonly DependencyProperty ImgProperty = DependencyProperty.Register(
           "TrueImg",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, ImgChanged));

        public string TrueImg
        {
            get { return (string)GetValue(ImgProperty); }
            set { SetValue(ImgProperty, value); }
        }

        private static void ImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ImgForm = obj as Info;
            ImgForm.ImgX.Source = new BitmapImage(new Uri($"pack://application:,,,/{ImgForm.TrueImg}"));
        }






        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавляем сотрудника в список...");
        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пишем сотруднику...");
        }

        private void Call_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Звоним сотруднику...");
        }
    }
}
