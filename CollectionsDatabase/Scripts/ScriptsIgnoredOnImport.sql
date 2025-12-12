
SET IDENTITY_INSERT Users ON;
GO

-- Allow explicit insert for IDENTITY column
INSERT INTO Users (userId, userName, passwordEncrypted) VALUES
(1, 'Guest1', 'encrypted'),
(2, 'Usman', 'usmanpassencrypted'),
(3, 'David', 'DavidPassencrypted'),
(4, 'Lucas', 'lucaspassencrypted'),
(5, 'Alan', 'alanpassencrypted'),
(6, 'Guest', 'guestpassencrypted');
GO

SET IDENTITY_INSERT Users OFF;
GO

SET IDENTITY_INSERT Collection ON;
GO

INSERT INTO Collection (collectionId, collectionTitle, collectionCreatorId) VALUES
(1, 'Magic The Gathering -Part 2', 4), -- Lucas (userId 4)
(2, 'Pokemon', 4);
GO

-- Lucas (userId 4)
SET IDENTITY_INSERT Collection OFF;
GO

SET IDENTITY_INSERT Friendships ON;
GO

INSERT INTO Friendships (friendshipId, userId, friendId) VALUES
(1, 4, 5), -- Lucas (4) is friends with Alan (5)
(2, 5, 4);
GO

-- Alan (5) is friends with Lucas (4)
SET IDENTITY_INSERT Friendships OFF;
GO
