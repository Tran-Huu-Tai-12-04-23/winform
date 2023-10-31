using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_QUANLYKHO.Models
{
    public class Bake
    {
        private string idBake;
        private string name;
        private int amount;
        private float price;
        private string unit;
        private string idUnitBake;
        private bool active;

        public string maBanh
        {
            get { return idBake; } 
            set { idBake = value; }
        }

        public string tenBanh
        {
            get { return name; }
            set { name = value; }   
        }

        public int soLuong
        {
            get { return amount; }
            set { amount = value; }
        }

        public float giaTien
        {
            get { return price; }
            set { price = value; }
        }

        public string donVi
        {
            get { return unit; }
            set { unit = value; }
        }

        public string maLoaiBanh
        {
            get { return idUnitBake; }
            set { idUnitBake = value; }
        }

        public bool hien
        {
            get { return active; }
            set { active = value; }
        }

        public Bake(string maBanh, string tenBanh, int soLuong, float giaTien, string donVi, string maLoaiBanh)
        {
            idBake = maBanh;
            name = tenBanh;
            amount = soLuong;
            price = giaTien;
            unit = donVi;
            idUnitBake = maLoaiBanh;
            active = true;
        }

        public Bake(string tenBanh, int soLuong, float giaTien, string donVi, string maLoaiBanh)
        {
            name = tenBanh;
            amount = soLuong;
            price = giaTien;
            unit = donVi;
            idUnitBake = maLoaiBanh;
            active = true;
        }

        public Bake()
        {
            maBanh = "";
            name = "";
            amount = 0;
            price = 0;
            unit = "";
            maLoaiBanh = "";
        }

    }
}
