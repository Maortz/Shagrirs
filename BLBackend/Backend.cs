using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data.Entity;

namespace BLBackend
{
    public class Backend : IBLBackend
    {
        DataLayer dal = new DataLayer();

        public List<Shagrir> GetShagrirs()
        {
            return dal.ReadShagrirs().ToList();
        }

        public bool AddShagrir(Shagrir shagrirToAdd)
        {
            var shgs = dal.ReadShagrirs();
            if (shgs.Count(x =>
                x.Id == shagrirToAdd.Id ||
                x.Name == shagrirToAdd.Name ||
                x.Phone == shagrirToAdd.Phone) > 0)
                throw new Exception("Shagrir Already Exist");
            return dal.CreateShagrir(shagrirToAdd);
        }

        public bool RemoveShagrir(int shagrirId)
        {
            var shagrir = GetShagrir(shagrirId);
            return dal.DeleteShagrir(shagrir);
        }

        public bool UpdateShagrir(Shagrir shagrirToUpdate)
        {
            var shgs = dal.ReadShagrirs();
            if (!(shgs.Count(x =>
                x.Id == shagrirToUpdate.Id ||
                x.Name == shagrirToUpdate.Name ||
                x.Phone == shagrirToUpdate.Phone) == 1))
                throw new Exception("Cannot update shagrir");
            return dal.UpdateShagrir(shagrirToUpdate);
        }

        public Shagrir GetShagrir(int shagrirId)
        {
            var shags = dal.ReadShagrirs();
            var shagrir = shags.FirstOrDefault(x => x.Id == shagrirId);
            if (shagrir == default(Shagrir))
                throw new Exception("Shagrir is not exist");
            return shagrir;
        }

        public List<Candidate> GetCandidates()
        {
            return dal.ReadCandidates().ToList();
        }

        public Candidate GetCandidate(int candidateId)
        {
            var cans = dal.ReadCandidates();
            var can = cans.FirstOrDefault(x => x.Id == candidateId);
            if (can == default(Candidate))
                throw new Exception("Candidate is not exist");
            return can;
        }

        public bool AddCandidate(Candidate candidateToAdd)
        {
            var cans = dal.ReadCandidates();
            if (cans.Count(x =>
                x.Id == candidateToAdd.Id ||
                x.Name == candidateToAdd.Name ||
                x.Phone == candidateToAdd.Phone) > 0)
                throw new Exception("Candidate is already exist");
            return dal.CreateCandidate(candidateToAdd);
        }

        bool UpdateCandidate(Candidate candidateToUpdate)
        {
            var cans = dal.ReadCandidates();
            if (!(cans.Count(x =>
                x.Id == candidateToUpdate.Id ||
                x.Name == candidateToUpdate.Name ||
                x.Phone == candidateToUpdate.Phone) == 1))
                throw new Exception("Cannot update candidate");
            return dal.UpdateCandidate(candidateToUpdate);
        }

        public bool RemoveCandidate(int candidateId)
        {
            var can = GetCandidate(candidateId);
            return dal.DeleteCandidate(can);
        }

        public List<Sharing> GetAllSharings()
        {
            return dal.ReadSharings().ToList();
        }

        public List<Sharing> GetMyShares(int shagrirId)
        {
            return dal.ReadSharings().Where(x => x.ShagrirShareId == shagrirId).ToList();
        }

        public List<Sharing> GetMyShared(int shagrirId)
        {
            return dal.ReadSharings().Where(x => x.ShagrirSharedId == shagrirId).ToList();
        }

        public bool Share(int ownerId, int reciverId, int candidateId)
        {
            Sharing share = new Sharing();
            share.ShagrirShareId = ownerId;
            share.ShagrirSharedId = reciverId;
            share.CandidateBeingSharedId = candidateId;

            return dal.CreateSharing(share);
        }

        public bool RemoveShare(int ownerId, int reciverId, int candidateId)
        {
            var shares = dal.ReadSharings();
            var share = shares.FirstOrDefault(x =>
                x.CandidateBeingSharedId == candidateId &&
                x.ShagrirSharedId == reciverId &&
                x.ShagrirShareId == ownerId);
            if (share == default(Sharing))
                throw new Exception("Share not found");
            return dal.DeleteSharing(share);
        }

        public bool RemvoeAllSharesBy(Func<Sharing,bool> predicate)
        {
            var shares = dal.ReadSharings().Where<Sharing>(predicate);
            bool flag = true;
            foreach (var share in shares)
            {
                if (!dal.DeleteSharing(share))
                    flag = false;
            }
            return flag;
        }
    }
}
