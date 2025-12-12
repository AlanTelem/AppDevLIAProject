-- Create the Friendships table
CREATE TABLE Friendships (
    friendshipId INT PRIMARY KEY IDENTITY(1,1),
    userId INT NOT NULL,
    friendId INT NOT NULL,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (friendId) REFERENCES Users(userId)
);