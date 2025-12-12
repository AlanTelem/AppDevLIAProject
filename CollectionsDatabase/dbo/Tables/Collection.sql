-- Create the Collection table
CREATE TABLE Collection (
    collectionId INT PRIMARY KEY IDENTITY(1,1),
    collectionTitle NVARCHAR(MAX),
    collectionCreatorId INT NOT NULL,
    FOREIGN KEY (collectionCreatorId) REFERENCES Users(userId)
);