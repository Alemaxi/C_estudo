CREATE TABLE IF NOT EXISTS users(
    userId INT PRIMARY KEY AUTO_INCREMENT,
    userName VARCHAR(100) NOT NULL,
    fullName VARCHAR(200) NOT NULL,
    password VARCHAR(30) NOT NULL,
    refreshToken VARCHAR(150),
    refreshTokenExpiryTime DATETIME);