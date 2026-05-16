CREATE TABLE Tbl_Hastalar (
    Hastaid smallint identity(1,1) primary key,
    HastaAd varchar(50),
    HastaSoyad varchar(50),
    HastaTC char(11),
    HastaTelefon varchar(15),
    HastaSifre varchar(20),
    HastaAdres varchar(150)
)