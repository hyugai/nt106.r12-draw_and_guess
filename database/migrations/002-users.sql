IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        UserId          INT IDENTITY(1,1) PRIMARY KEY,
        TenDangNhap     NVARCHAR(20) NOT NULL UNIQUE,
        MatKhauBam      NVARCHAR(64) NOT NULL,
        Salt            NVARCHAR(32) NOT NULL,
        HoTen           NVARCHAR(50) NOT NULL,
        Email           NVARCHAR(100) NULL,
        NgayTao         DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        LanDangNhapCuoi DATETIME2 NULL
    );

    PRINT 'Users table created.';
END
ELSE
    PRINT 'Users table already exists.';
