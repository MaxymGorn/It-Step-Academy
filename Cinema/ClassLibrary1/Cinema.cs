using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Rahon { get; set; }

    }

    public class Zal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCinema { get; set; }
        [Range(0,100, ErrorMessage ="Eror count")]
        public int Count { get; set; }

    }
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Chanr
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProducerId { get; set; }

        public int ChanrId { get; set; }
        public string Desciption { get; set; }

        public string Country { get; set; }
        public TimeSpan Time { get; set; }


    }

    public class Seans
    {
        public int Id { get; set; }
        public int IdZal { get; set; }
        public int IdFilm { get; set; }

        public double Cost { get; set; }


    }
}
