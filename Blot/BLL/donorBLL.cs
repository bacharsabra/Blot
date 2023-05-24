using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blot.BLL
{
    class donorBLL
    {
        public int Donor_ID { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Blood_Type { get; set; }
        public DateTime Added_Date { get; set; }
        public string Image_Name { get; set; }
        public int Added_By { get; set; }

    }
}
