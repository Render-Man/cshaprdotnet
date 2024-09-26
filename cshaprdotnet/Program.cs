namespace com.csharpdotnet.baikt1
{
    public class Program
    {
        static List<SinhVienDT> svList = new List<SinhVienDT>();

        public static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Write("Menu: 9->10. 0 to exit ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 9:
                        _9();
                        break;
                    case 10:
                        _10();
                        break;
                    case 11:
                        _11();
                        break;
                    case 12:
                        _12();
                        break;
                    case 0:
                        return;
                    default:
                        Console.Write("Menu is not valid in current context");
                        break;
                }
            }
            while (menu != 0);
        }

        private static void _9()
        {
            var sv = new SinhVienDT();
            sv.Input();
            bool match = svList.Any(s => s.Masv == sv.Masv);
            if(match)
            {
                Console.WriteLine($"msv is duplicated {sv.Masv}");
                return;
            }
            svList.Add(sv);
        }

        private static void _10()
        {
            svList.Sort((sv1, sv2) =>
            {
                return sv1.TongDiem() > sv2.TongDiem() ? 1 : 0;
            });

            svList.ForEach(sv =>
            {
                sv.Output();
            });
        }

        private static void _11()
        {
            Console.WriteLine("ddt");
            float ddt = int.Parse(Console.ReadLine());

            svList.ForEach(s =>
            {
                if(s.TongDiem() >= ddt)
                {
                    s.Output();
                }
            });
        }

        private static void _12()
        {
            Console.WriteLine("enter a msv");
            string msv = Console.ReadLine();

            var svEnumerator = svList.Where(s => s.Masv == msv);
            foreach (var sv in svEnumerator)
            {
                sv.Output();
            }
        }
    }
}
