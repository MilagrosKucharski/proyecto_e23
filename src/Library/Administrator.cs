using System;
using System.Collections;
namespace Library
{
    public class Administrator
    {
        public static ArrayList CategoryCataloge {get; set;}= new ArrayList ();
        public string NewCategory {get; set; }
        public Category TheCategory {get; set;}
        
        public Administrator (string newCategory)
        {
            this.NewCategory = newCategory;
        }
        public void GetCategory ()
        {
            Category TheCategory = new Category (this.NewCategory);

        }
        public void GetCategories()
        {
           CategoryCataloge.Add(TheCategory);
        }
    }
}