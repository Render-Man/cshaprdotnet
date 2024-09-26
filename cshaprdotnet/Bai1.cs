using System;
using System.Collections.Generic;
using System.Linq;
namespace com.csharpdotnet.baikt1
{
    internal class SinhVien
    {
        protected string masv;
        protected string hovaten;
        protected float python;
        protected float java;

        public string Masv => masv;

        public string Hovaten => hovaten;

        public float Python => python;

        public float Java => java;

        public SinhVien(string masv, string hovaten, float python, float english)
        {
            this.masv = masv;
            this.hovaten = hovaten;
            this.python = python;
            this.java = english;
        }

        internal SinhVien()
        {
            // cs8618
            masv = string.Empty;
            hovaten = string.Empty;
        }

        internal virtual float TongDiem() => python + java;
    }
}
