INSERT INTO dbo.Users (
    TenDangNhap,
    MatKhauBam,
    Salt,
    HoTen,
    Email,
    NgayTao,
    LanDangNhapCuoi
)
VALUES
(
    N'player01',
    N'dummy_hash_01',
    N'dummy_salt_01',
    N'Nguyễn Văn An',
    N'player01@example.com',
    '2026-09-01',
    '2026-10-10'
),
(
    N'player02',
    N'dummy_hash_02',
    N'dummy_salt_02',
    N'Trần Minh Bình',
    N'player02@example.com',
    '2026-09-05',
    '2026-10-09'
),
(
    N'player03',
    N'dummy_hash_03',
    N'dummy_salt_03',
    N'Lê Thị Chi',
    N'player03@example.com',
    '2026-09-12',
    '2026-10-08'
);
