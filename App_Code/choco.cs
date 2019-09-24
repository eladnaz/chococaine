using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;

namespace database
{
    public class Choco
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public SqlDecimal price { get; set; }
        public string desc { get; set; }
        public string img { get; set; }

        public Choco(string brand, string name,string type, SqlDecimal price, string desc, string img)
        {
            this.brand = brand;
            this.name = name;
            this.type = type;
            this.price = price;
            this.desc = desc;
            this.img = img;
        }

        public Choco(int Id, string brand,string type, string name,SqlDecimal price, string desc, string img)
        {
            this.Id = Id;
            this.brand = brand;
            this.type = type;
            this.name = name;
            this.price = price;
            this.desc = desc;
            this.img = img;
        }

        public Choco(int Id, string brand, string name, SqlDecimal price, string desc, string img)
        {
            this.Id = Id;
            this.brand = brand;
            this.name = name;
            this.price = price;
            this.desc = desc;
            this.img = img;
        }
        public Choco(string brand, string name, string type, SqlDecimal price, string desc)
        {
            this.brand = brand;
            this.name = name;
            this.type = type;
            this.price = price;
            this.desc = desc;
        }
    }
    
}