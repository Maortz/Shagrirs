using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.ServiceModel;

namespace BLBackend
{
    [ServiceContract]
    interface IBLBackend
    {
        // Shagrirs

        [OperationContract]
        List<Shagrir> GetShagrirs();

        [OperationContract]
        bool AddShagrir(Shagrir shagrirToAdd);

        [OperationContract]
        bool RemoveShagrir(int shagrirId);

        [OperationContract]
        bool UpdateShagrir(Shagrir shagrirToUpdate);

        [OperationContract]
        Shagrir GetShagrir(int shagrirId);

        // Candidates

        [OperationContract]
        List<Candidate> GetCandidates();

        [OperationContract]
        Candidate GetCandidate(int candidateid);

        [OperationContract]
        bool AddCandidate(Candidate candidateToAdd);

        [OperationContract]
        bool UpdateCandidate(Candidate candidateToUpdate);

        [OperationContract]
        bool RemoveCandidate(int candidateId);

        //Relationships and Sharing

        [OperationContract]
        List<Sharing> GetAllSharings();
        
        [OperationContract]
        List<Sharing> GetMyShares(int shagrirId);

        [OperationContract]
        List<Sharing> GetMyShared(int shagrirId);

        [OperationContract]
        bool Share(int ownerId, int reciverId, int candidateId);

        [OperationContract]
        bool RemoveShare(int ownerId, int reciverId, int candidateId);

        [OperationContract]
        bool RemvoeAllSharesBy(Func<Sharing,bool> predicate);

    }
}
