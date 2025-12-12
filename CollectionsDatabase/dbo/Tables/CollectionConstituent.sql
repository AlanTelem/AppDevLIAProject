-- Create the CollectionConstituent table
CREATE TABLE CollectionConstituent (
    constituentId INT PRIMARY KEY IDENTITY(1,1),
    collectionId INT NOT NULL,
    collectibleId INT NOT NULL,
    FOREIGN KEY (collectionId) REFERENCES Collection(collectionId),
    FOREIGN KEY (collectibleId) REFERENCES Collectible(collectibleId)
);