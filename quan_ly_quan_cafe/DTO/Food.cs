﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_quan_cafe.DTO
{
    public class Food
    {
        public Food(int id, string name,int categoryID,float price) 
        {
            this.Id = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private float price;
        public float Price { get => price; set => price = value; }
        

        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; } 
            set {  categoryID = value; }
        }


        private string name;

        public string Name
        { 
            get { return name; } 
            set { name = value; }
        }
        private int id;

        public int Id 
        { 
            get { return id; } 
            set { id = value; }
        }

    }
}
