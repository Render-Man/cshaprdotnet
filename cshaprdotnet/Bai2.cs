using System;

namespace com.csharpdotnet.baikt1
{
    internal sealed class SinhVienDT : SinhVien
    {
        float english;
        float uutien;

        internal override float TongDiem()
        {
            return python + java + english + uutien;
        }

        internal string XetTuyen(float mark)
        {
            return TongDiem() >= mark ? "Duoc Chon" : "Loai";
        }

        internal void Input()
        {
            Console.WriteLine("enter sv info");
            masv = Console.ReadLine();
            hovaten = Console.ReadLine();
            java = float.Parse(Console.ReadLine());
            python = float.Parse(Console.ReadLine());
            english = float.Parse(Console.ReadLine());

            uutien = english switch
            {
                > 8 => 1.0f,
                >=5 and <=8 => .5f,
                <5 => 0,
            };
        }

        internal void Output()
        {
            Console.WriteLine($"{masv} {hovaten} {java} {python} {english} {uutien}");
        }
    }
}
