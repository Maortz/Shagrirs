using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using BLBackend;


namespace BackendChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL_CreateAll();
        }

        static void DAL_CreateAll()
        {
            DataLayer dal = new DataLayer();
            var shagrirs = dal.ReadShagrirs();
            
            Shagrir david = shagrirs.First(x => x.Name == "דוד שמעוני");
            List<Shagrir> shl = new List<Shagrir>();
            shl.Add(david);
            
            dal.CreateCandidate(new Candidate
            {
                Address = "רחוק",
                AgeRange = "14-20",
                BirthDate = new DateTime(1993, 7, 25),
                Employment = "אלקטרואופטיקה",
                Ethnical = "יהודי",
                Gender = "זכר",
                Height = 1.6,
                HighSchool = "ישיבה תיכונית כלשהי",
                Hobbies = "חרשן",
                Info = "מידע על עצמי...",
                LookingAppearance = "יפה",
                LookingNature = "צמחונית",
                More = "זה הכל",
                Name = "משה",
                Phone = "058553350",
                Pic1 = "1.jpg",
                Pic2 = "2.jpg",
                Sector = "דתי ורווק",
                Service = "עתודאי. ממש ממש אוהב את המסלול",
                ThirdParty = "יוס יוסי 058553350",
                Shagrirs = shl
            });
            
            
            dal.CreateShagrir(new Shagrir
            {
                Address = "here",
                BirthDate = new DateTime(1993, 7, 25),
                Candidates = new List<Candidate>(),
                Gender = "זכר",
                Name = "משה",
                Phone = "0585553350",
                Reputation = 0
            });
        }
    }
}
