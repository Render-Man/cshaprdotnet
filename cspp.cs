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

namespace KieuMinhHieu_9._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =  MessageBox.Show("Dong chuong tirnh?", "Dong ct", MessageBoxButton.OKCancel);
            
            if(result == MessageBoxResult.OK)
                Application.Current.Shutdown();
        }

        private void OnAddItem(object sender, RoutedEventArgs e)
        {
            MemberInfo newMember = GetMemberInfoByUserInput();
            listView.Items.Add(newMember);
        }

        MemberInfo GetMemberInfoByUserInput()
        {
            string name = inputName.Text;
            Gender gender = (isMale.IsChecked != null && isMale.IsChecked.Value) ? Gender.Male : Gender.Female;
            bool isMarried = (btnIsMarried.IsChecked != null && btnIsMarried.IsChecked.Value);
            List<string> hobbies = new();

            if (Ok(cbFootball))
                hobbies.Add("Leo nui");
            if (Ok(cbSwimming))
                hobbies.Add("Boi loi");
            if (Ok(cbMusic))
                hobbies.Add("Am nhac");
            if (Ok(cbClimbing))
                hobbies.Add("Leo nui");


            return new MemberInfo(name, gender, isMarried, hobbies.ToArray());
        }

        bool Ok(CheckBox cb)
        {
            return cb.IsChecked != null && cb.IsChecked.Value;
        }
    }

    public class MemberInfo
    {
        string name;
        Gender gender;
        bool isMarried;
        string[] hobbies;

        public MemberInfo() : 
            this("No Name", Gender.Male, false, new string[1] {"No Hobbies"})
        {

        }

        public MemberInfo(
            string name, 
            Gender gender, 
            bool isMarried,
            string[] hobbies)
        {
            this.name = name;
            this.gender = gender;
            this.isMarried = isMarried;
            this.hobbies = hobbies;
        }

        public override string ToString()
        {
            return $"Ho Ten: {name} \n" +
                $"Gioi Tinh: {gender} \n" +
                $"Tinh Trang Hon Nhan: {(isMarried? "Da ket hon": "Chua ket hon")} \n" +
                $"So thich: {hobbies}";
        }
    }

    public enum Gender : byte
    {
        Male,
        Female,
    }
}
