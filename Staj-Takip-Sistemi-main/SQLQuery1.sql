create database Staj Takip Sistemi 

create table Departman(
DepartmanID int primary key identity(1,1),
departmanAd varchar(50)
);
create table Yonetici(
yoneticiID int primary key identity(1,1),
yoneticiAd varchar(50),
yoneticiSoyad varchar(50),
yoneticiSifre varchar(30),
yoneticiEposta varchar(50),
departmanID int FOREIGN KEY REFERENCES Departman(departmanID)
);
create table Personel(
personelID int primary key identity(1,1),
personelAd varchar(20),
personelSoyad varchar(25),
personelNo int,
yoneticiID int FOREIGN KEY REFERENCES Yonetici(yoneticiID),
DepartmanID int FOREIGN KEY REFERENCES Departman(DepartmanID)
);
create table Stajyer(
stajyerID int primary key identity(1,1),
stajyerAd varchar(20),
stajyerSoyad varchar(25),
baslangicTarih varchar(30),
bitisTarih varchar(30),
stajyerNo int,
personelID int FOREIGN KEY REFERENCES Personel(personelID),
DepartmanID int FOREIGN KEY REFERENCES Departman(DepartmanID)
);

INSERT INTO Departman (departmanAd) VALUES ('Bili�im Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Mali ��ler Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Seyir Ve Haberle�me Departman�');
INSERT INTO Departman (departmanAd) VALUES ('�dari Ve Yap� ��leri Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Destek Hizmetleri Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Gemi Trafik Ve K�lavuzluk Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Departman�');
INSERT INTO Departman (departmanAd) VALUES ('Strateji Departman�');

INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Halis', 'Salman', 'halis1234', 'halissalman@kiyiemniyeti.gov.tr',1);
INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Ali', 'Y�lmaz', '1234yilmaz', 'aliyilmaz@kiyiemniyeti.gov.tr',3);
INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Suat Hudaverdi', 'Barlas', '12suat34', 'suatbarlas@kiyiemniyeti.gov.tr',7);
INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Abdurrahman', 'K�se', 'kose123', 'abdurrahmankose@kiyiemniyeti.gov.tr',2);
INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Mustafa', 'Topal', '1234mustafa', 'mustafatopal@kiyiemniyeti.gov.tr',3);
INSERT INTO Yonetici(yoneticiAd, yoneticiSoyad, yoneticiSifre, yoneticiEposta, departmanID) VALUES ('Halis', 'Salman', 'halis1234', 'halissalman@kiyiemniyeti.gov.tr',8);

 INSERT INTO Personel(personelAd, personelSoyad, personelNo) VALUES ('Muttalip', '�im�ek', 200);
INSERT INTO Personel(personelAd, personelSoyad, personelNo) VALUES ('Ensar', 'Aslan', 225);
INSERT INTO Personel(personelAd, personelSoyad, personelNo) VALUES ('Melih Emre', '�zg�r', 145);
INSERT INTO Personel(personelAd, personelSoyad, personelNo) VALUES ('Kayhan', 'Hanverdi', 195);
INSERT INTO Personel(personelAd, personelSoyad, personelNo) VALUES ('Bayram', 'D���nmez', 520);

INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('Ebru', 'K���k', '2023-08-14', '2023-09-11', 244);
INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('Elif Nur', 'Karaca', '2023-08-14', '2023-09-11',176);
INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('Sebile', 'Kayan', '2023-08-14', '2023-09-11',196);
INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('Burak','G�ndo�an', '2023-08-14', '2023-09-11',107);
INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('�mer Furkan', 'Altunta�', '2023-08-14', '2023-09-11',211);
INSERT INTO Stajyer(stajyerAd, stajyerSoyad, baslangicTarih, bitisTarih, stajyerNo) VALUES ('Yi�it Can', 'Girgin', '2023-08-14', '2023-09-11',162);
