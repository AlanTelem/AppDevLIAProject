-- Create the CollectionTracker table
CREATE TABLE CollectionTracker (
    trackerId INT PRIMARY KEY IDENTITY(1,1),
    collectionId INT NOT NULL,
    userId INT NOT NULL,
    FOREIGN KEY (collectionId) REFERENCES Collection(collectionId),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);