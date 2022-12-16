DROP TABLE IF EXISTS Lid;

CREATE TABLE Lid
(
	id					int			NOT NULL,
	voornaam			varchar(25)	NOT NULL,
	familienaam			varchar(50)	NOT NULL,
	geslacht			char		NOT NULL,
	straat				varchar(50)	NOT NULL,
	huisnummer			varchar(10)	NOT NULL,
	postcode			varchar(6)	NOT NULL,
	gemeente			varchar(25)	NOT NULL,
	land				varchar(25)	NOT NULL 
	CONSTRAINT DF_Lid_land
		DEFAULT 'Belg�e',
	rijksregisternr		varchar(15)	NOT NULL,
	inschrijvingsDatum	date		NOT NULL,
	telefoon			varchar(25)	NULL,
	email				varchar(50)	NULL,
	CONSTRAINT PK_Lid
		PRIMARY KEY (id),
	CONSTRAINT UK_Lid_id_familienaam
		UNIQUE (id, familienaam),
	CONSTRAINT CK_Lid_geslacht
		CHECK (geslacht = 'M' OR geslacht = 'V' OR geslacht = 'X')
);

INSERT INTO Lid
	(id, voornaam, familienaam, geslacht, straat, huisnummer, postcode, gemeente, land, rijksregisternr, inschrijvingsdatum, telefoon, email)
	VALUES	(2, 'Mari�tte', 'Brans', 'V', 'Europalaan', '95 bus 14', '3600', 'Genk', 'Belg�e', '46 04 28 040 26', '1966-01-21', '089123456', null),
			(4, 'Flor', 'Van der Linden', 'M', 'Philip Spethstraat', '47', '2950', 'Kapellen', 'Belg�e', '35 01 25 201 61', '1968-10-14', '032147258', null),
			(13, 'Kris', 'Vanelderen', 'M', 'Herckenrodesingel', '12', '3500', 'Hasselt', 'Belg�e', '83 11 23 123 45', '1999-05-14', '0477147963', 'kris.vanelderen@skynet.be'),
			(15, 'Jos', 'Meynen', 'M', 'Baneuxwijk', '25', '3500', 'Hasselt', 'Belg�e', '56 04 04 357 95', '1999-06-12', '0493001001', 'Jos.Meynen@live.be'),
			(21, 'Dirk', 'Vangeneugden', 'M', 'Bristerstraat', '21', '2960', 'Brecht', 'Belg�e', '66 01 10 005 82',  '2000-12-05', '0485951620', 'dirkv.66@mijnmail.be'),
			(36, 'Senne', 'Tielens', 'M', 'Wijvestraat', '27', '3520', 'Zonhoven', 'Belg�e', '93 08 23 222 01', '2010-02-16', null, 'senne.tielens@live.com'),
			(45, 'Robin', 'Vangeneugden', 'M', 'Schipperstraat', '8', '3945', 'Kwaadmechelen', 'Belg�e', '92 08 27 567 89',  '2012-09-03', '0497000000', 'robin.vangeneugden@outlook.com'),
			(46, 'Anja', 'Kowalewski', 'V', 'Weg op Zepperen', '22', '3840', 'Rijkel', 'Belg�e', '70 05 10 123 44', '2012-09-03', '0486777777', 'anja.kowa@outlook.com'),
			(47, 'Jorn', 'Vangeneugden', 'M', 'Weg op Zepperen', '22', '3840', 'Rijkel', 'Belg�e', '95 08 23 135 17', '2012-09-03', '0496123456', 'jorn.vang23@hotmail.com'),
			(52, 'Rina', 'Brans', 'V', 'Alesiahof', '119H', '6215SN', 'Maastricht', 'Nederland', '55 12 30 995 66', '2013-11-23', '+31452489156', 'Rina.brans@vodaphone.nl'),
			(75, 'Jochem', 'Vangeneugden', 'M', 'Geiteling', '78', '3580', 'Beringen', 'Belg�e', '95 08 23 456 68', '2014-01-06', '0475123456', 'jochem.vangeneugden@hotmail.com'),
			(77, 'Bo', 'Van der Meer', 'V', 'Weg op Zepperen', '22', '3840', 'Rijkel', 'Belg�e', '12 03 25 128 56', '2019-09-02', null, null),
			(82, 'Dagmara', 'Eysackers', 'V', 'Schipperstraat', '8', '3945', 'Kwaadmechelen', 'Belg�e', '95 02 14 987 53', '2020-04-16', '0468123456', 'dagmara.eysackers@hotmail.com'),
			(83, 'Jessica', 'Ackein', 'V', 'Anjerstraat', '7', '4641SL', 'Woensdrecht', 'Nederland', '95 02 25 155 85', '2020-04-16', '+31485258369', 'jessica.ackein@test.nl'),
			(93, 'Didier', 'Elst', 'M', 'Nicolaylaan', '175', '3970', 'Leopoldsburg', 'Belg�e', '91 03 13 555 55', '2021-07-12', '0468111111', 'didier.elst@gmail.be'),
			(94, 'Jaimy', 'Wieland', 'V', 'Nicolaylaan', '175', '3970', 'Leopoldsburg', 'Belg�e', '93 07 11 333 33', '2021-07-12', '0472135790', 'jaimy.wieland@gmail.com'),
			(103, 'Mel�nia', 'Vangeneugden', 'V', 'Schipperstraat', '8', '3945', 'Kwaadmechelen', 'Belg�e', '17 09 15 145 36', '2022-02-24', null, null),
			(105, 'Kyara', 'Vangeneugden', 'V', 'Schipperstraat', '8', '3945', 'Kwaadmechelen', 'Belg�e', '20 04 15 963 14', '2022-02-24', null, null),
			(106, 'Lorena', 'Vangeneugden', 'V', 'Geiteling', '78', '3580', 'Beringen', 'Belg�e', '18 10 09 457 65', '2022-03-02', null, null),
			(121, 'Yaiden', 'Leanaerts', 'M', 'Bosschelweg', '17', '3950', 'Bocholt', 'Belg�e', '14 11 30 123 45', '2022-03-02', null, null);

CREATE INDEX AK_Lid_rijksregisternr
ON Lid(rijksregisternr);

CREATE INDEX AK_Lid_email
ON Lid(email);