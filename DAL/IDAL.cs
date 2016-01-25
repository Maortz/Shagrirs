using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;


namespace DAL
{
    interface IDAL
    {
        // Shagrirs
        DbSet<Shagrir> ReadShagrirs();
        bool CreateShagrir(Shagrir shagrirToCreate);
        bool UpdateShagrir(Shagrir shagrirToUpdate);
        bool DeleteShagrir(Shagrir shagrirToDelete);

        // Candidates
        DbSet<Candidate> ReadCandidates();
        bool CreateCandidate(Candidate candidateToCreate);
        bool UpdateCandidate(Candidate candidateToUpdate);
        bool DeleteCandidate(Candidate candidateToDelete);

        // Sharing
        DbSet<Sharing> ReadSharings();
        bool CreateSharing(Sharing sharingToCreate);
        bool DeleteSharing(Sharing sharingToDelete);
    }
}
