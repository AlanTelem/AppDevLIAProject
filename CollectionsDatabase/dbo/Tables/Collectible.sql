-- Create the Collectible table
CREATE TABLE Collectible (
    collectibleId INT PRIMARY KEY IDENTITY(1,1),
    collectibleName NVARCHAR(255) NOT NULL,
    thumbnail VARBINARY(MAX) -- Corresponds to BLOB in SQLite
);