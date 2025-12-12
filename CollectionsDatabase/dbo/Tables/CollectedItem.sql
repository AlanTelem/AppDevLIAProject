-- Create the CollectedItem table
CREATE TABLE CollectedItem (
    collectedId INT PRIMARY KEY IDENTITY(1,1),
    userId INT NOT NULL,
    collectibleId INT NOT NULL,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (collectibleId) REFERENCES Collectible(collectibleId)
);