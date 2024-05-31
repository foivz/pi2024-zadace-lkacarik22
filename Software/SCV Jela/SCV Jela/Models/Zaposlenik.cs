using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV_Jela.Models
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korime {  get; set; }
        public string lozinka { get; set; }
    }
}
