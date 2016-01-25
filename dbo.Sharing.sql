CREATE TABLE [dbo].[Sharing]
(
	[ShagrirShareId] INT NOT NULL , 
    [ShagrirSharedId] INT NOT NULL, 
    [CandidateBeingSharedId] INT NOT NULL, 
    PRIMARY KEY ([ShagrirShareId], [ShagrirSharedId], [CandidateBeingSharedId]), 
    CONSTRAINT [FK_Sharing_ToShagrir1] FOREIGN KEY ([ShagrirShareId]) REFERENCES [Shagrir]([Id]),
	CONSTRAINT [FK_Sharing_ToShagrir2] FOREIGN KEY ([ShagrirSharedId]) REFERENCES [Shagrir]([Id]),
	CONSTRAINT [FK_Sharing_ToCandidate] FOREIGN KEY ([CandidateBeingSharedId]) REFERENCES [Candidate]([Id])
)
