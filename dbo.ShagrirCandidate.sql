CREATE TABLE [dbo].[ShagrirCandidate]
(
	[ShagrirId] INT NOT NULL , 
    [CandidateId] INT NOT NULL, 
    PRIMARY KEY ([CandidateId], [ShagrirId]), 
    CONSTRAINT [FK_ShagrirCandidate_ToTable] FOREIGN KEY ([ShagrirId]) REFERENCES [Shagrir]([Id]), 
    CONSTRAINT [FK_ShagrirCandidate_ToTable_1] FOREIGN KEY ([CandidateId]) REFERENCES [Candidate]([Id])
)
