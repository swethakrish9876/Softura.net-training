using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace lynq
{
    class day26_apr_11_taskdoctor
    {
        public static void Main(string[] args)
        {
            IList<doctor> docdata = new List<doctor>()
            {
                new doctor(){doctorid=1,doctorname="Paul",specialisationid=1},
                new doctor(){doctorid=2,doctorname="Marie",specialisationid=2},
                new doctor(){doctorid=3,doctorname="Mani",specialisationid=3},
                new doctor(){doctorid=4,doctorname="Mohan",specialisationid=1},
                new doctor(){doctorid=5,doctorname="Curie",specialisationid=2},

            };

            IList<special> specdata = new List<special>()
            {
                new special(){specialisation="Dentist",specialisationid=1},
                new special(){specialisation="Gynacologist",specialisationid=2},
                new special(){specialisation="Dermatologist",specialisationid=3},
                
            };

            var joindata = docdata.Join(
                specdata,
                doc => doc.specialisationid,
                spec => spec.specialisationid,
                
                (doc, spec) => new
                {
                    doctorname = doc.doctorname,
                    specialisation = spec.specialisation
                }
                );


            foreach (var v in joindata)
                Console.WriteLine(v.doctorname + "        " + v.specialisation);
        }
    }
    class doctor
    {
        public int doctorid { get; set; }
        public int specialisationid { get; set; }
        public string doctorname { get; set; }
    }

    class special
    {
        public int specialisationid { get; set; }
        public string specialisation { get; set; }
    }
}
