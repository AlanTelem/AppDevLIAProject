-- Create the Users table
CREATE TABLE Users (
    userId INT PRIMARY KEY IDENTITY(1,1),
    userName NVARCHAR(255) NOT NULL UNIQUE,
    passwordEncrypted NVARCHAR(MAX) NOT NULL
);