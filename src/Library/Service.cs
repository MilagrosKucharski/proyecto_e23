using System;
using System.Collections;
using System.Collections.Generic;

namespace Library{

    public class Service 
    {
        public Service (string description, double price, DateTime date)
        {
            this.Description=description;
            this.Price = price;
            this.Date = date;

        }
        
        public string Description {get; set; }

        public double Price { get; set; }

        public DateTime Date { get; set; }

        public void SelectCategory ()
        {
            Console.WriteLine(Administrator.CategoryCataloge);

        }

    
    }
}