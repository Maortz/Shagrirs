using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;

namespace DAL
{
    public class DataLayer : IDAL
    {
        PeopleDBEntities contex = new PeopleDBEntities();

        public DbSet<Shagrir> ReadShagrirs()
        {
            return contex.Shagrirs;
        }

        public bool CreateShagrir(Shagrir shagrirToCreate)
        {
            contex.Shagrirs.Add(shagrirToCreate);
            return contex.SaveChanges() > 0;
        }

        public bool UpdateShagrir(Shagrir shagrirToUpdate)
        {
            var shag = contex.Shagrirs.FirstOrDefault<Shagrir>(x => x.Id == shagrirToUpdate.Id);
            if (shag != null)
            {
                CopyShagrir(shagrirToUpdate, ref shag);
                return contex.SaveChanges() > 0;
            }
            else
                return false;
        }

        private static void CopyShagrir(Shagrir shagrirToUpdate, ref Shagrir shag)
        {
            shag.Gender = shagrirToUpdate.Gender;
            shag.Address = shagrirToUpdate.Address;
            shag.BirthDate = shagrirToUpdate.BirthDate;
            shag.Candidates = shagrirToUpdate.Candidates;
            shag.Name = shagrirToUpdate.Name;
            shag.Phone = shagrirToUpdate.Phone;
            shag.Reputation = shagrirToUpdate.Reputation;
        }

        public bool DeleteShagrir(Shagrir shagrirToDelete)
        {
            var shag = contex.Shagrirs.FirstOrDefault<Shagrir>(x => x.Id == shagrirToDelete.Id);
            if (shag != null)
            {
                contex.Shagrirs.Remove(shag);
                return contex.SaveChanges() > 0;
            }
            else
                return false;
        }

        public DbSet<Candidate> ReadCandidates()
        {
            return contex.Candidates;
        }

        public bool CreateCandidate(Candidate candidateToCreate)
        {
            contex.Candidates.Add(candidateToCreate);
            return contex.SaveChanges() > 0;
        }

        public bool UpdateCandidate(Candidate candidateToUpdate)
        {
            var can = contex.Candidates.FirstOrDefault<Candidate>(x => x.Id == candidateToUpdate.Id);
            if (can != null)
            {
                CopyCandidate(candidateToUpdate, ref can);
                return contex.SaveChanges() > 0;
            }
            else
                return false;
        }

        private static void CopyCandidate(Candidate candidateToUpdate, ref Candidate can)
        {
            can.Address = candidateToUpdate.Address;
            can.AgeRange = candidateToUpdate.AgeRange;
            can.BirthDate = candidateToUpdate.BirthDate;
            can.Employment = candidateToUpdate.Employment;
            can.Ethnical = candidateToUpdate.Ethnical;
            can.Gender = candidateToUpdate.Gender;
            can.Height = candidateToUpdate.Height;
            can.HighSchool = candidateToUpdate.HighSchool;
            can.Hobbies = candidateToUpdate.Hobbies;
            can.Info = candidateToUpdate.Info;
            can.LookingAppearance = candidateToUpdate.LookingAppearance;
            can.LookingNature = candidateToUpdate.LookingNature;
            can.More = candidateToUpdate.More;
            can.Name = candidateToUpdate.Name;
            can.Phone = candidateToUpdate.Phone;
            can.Pic1 = candidateToUpdate.Pic1;
            can.Pic2 = candidateToUpdate.Pic2;
            can.Sector = candidateToUpdate.Sector;
            can.Service = candidateToUpdate.Service;
            can.Shagrirs = candidateToUpdate.Shagrirs;
            can.ThirdParty = candidateToUpdate.ThirdParty;
        }

        public bool DeleteCandidate(Candidate candidateToDelete)
        {
            var can = contex.Candidates.FirstOrDefault<Candidate>(x => x.Id == candidateToDelete.Id);
            if (can != null)
            {
                contex.Candidates.Remove(can);
                return contex.SaveChanges() > 0;
            }
            else
                return false;
        }


        public DbSet<Sharing> ReadSharings()
        {
            return contex.Sharings;
        }

        public bool CreateSharing(Sharing sharingToCreate)
        {
            contex.Sharings.Add(sharingToCreate);
            return contex.SaveChanges() > 0;
        }

        public bool DeleteSharing(Sharing sharingToDelete)
        {
            var sha = contex.Sharings.FirstOrDefault<Sharing>(x =>
                x.ShagrirShareId == sharingToDelete.ShagrirShareId &&
                x.ShagrirSharedId == sharingToDelete.ShagrirSharedId &&
                x.CandidateBeingSharedId == sharingToDelete.CandidateBeingSharedId);
            if (sha != null)
            {
                contex.Sharings.Remove(sha);
                return contex.SaveChanges() > 0;
            }
            else
                return false;
        }
    }
}
