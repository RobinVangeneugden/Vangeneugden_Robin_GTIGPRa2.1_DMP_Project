DROP TABLE IF EXISTS GroepRepetitie;
DROP TABLE IF EXISTS GroepOptreden;
DROP TABLE IF EXISTS LidGroep;
DROP TABLE IF EXISTS Repetitie;
DROP TABLE IF EXISTS Optreden;
DROP TABLE IF EXISTS Locatie;
DROP TABLE IF EXISTS Groep;
DROP TABLE IF EXISTS LidInstrument;
DROP TABLE IF EXISTS Lid;
DROP TABLE IF EXISTS Instrument;
DROP INDEX IF EXISTS Lid.AK_Lid_rijksregisternr;
DROP INDEX IF EXISTS Lid.AK_Lid_email;
DROP INDEX IF EXISTS Instrument.AK_Instrument_artikelNummer;

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

CREATE TABLE Groep
(
	id					int				IDENTITY(1,1),
	naam				varchar(50)		NOT NULL,
	omschrijving		varchar(100)	NOT NULL,
	externeGroep		bit				NOT NULL,
	dirigentId			int				NULL,
	CONSTRAINT PK_Groep
		PRIMARY KEY (id),
	CONSTRAINT FK_Groep_Dirigent
		FOREIGN KEY(dirigentId)
			REFERENCES Lid(id)
			ON DELETE SET NULL
);

INSERT INTO Groep
	(naam, omschrijving, externeGroep, dirigentId)
	VALUES	('Koninklijke Harmonie van Hasselt', 'Groep die bestaat uit drumband, orkest en majorettes', 'false', 15),
			('Drumband van de KH Hasselt', 'Groep die slaginstrumenten bespeeld', 'false', 13),
			('Orkest van de KH Hasselt', 'Groep die voornamelijk blaas-, snaar- of toetsinstrumenten speelt', 'false', 15),
			('Majorettes van de KH Hasselt', 'Groep van dansers die vooral jongeleren met een stick', 'false', null),
			('Koninklijke Harmonie Demergalm Godsheide', 'Groep die bestaat uit drumband en orkest', 'true', null),
			('Timpana', 'percussieband van Koninklijke Harmonie Demergalm Godsheide', 'true', 13),
			('Orkest van KH Demergalm Godsheide', 'Groep die voornamelijk blaas-, snaar- of toetsinstrumenten speelt', 'true', null),
			('Koninklijke Harmonie der Gilde St-Truiden', 'Groep die bestaat uit orkest met percussie', 'true', null),
			('Muziekvereniging het spoor Hasselt', 'Groep die bestaat uit orkest met percussie', 'true', 15),
			('Koninklijke fanfare Hoop in de Toekomst', 'Groep die enkel bestaat uit een orkest', 'true', null),
			('Koninklijke fanfare St-Cecilia Kermt', 'Groep die enkel bestaat uit een orkest', 'true', null);

CREATE TABLE LidGroep
(
	id					int			IDENTITY(1,1),
	lidId				int			NOT NULL,
	groepId				int			NOT NULL,
	CONSTRAINT PK_LidGroep
		PRIMARY KEY (id),
	CONSTRAINT FK_LidGroep_Lid
		FOREIGN KEY(lidId)
			REFERENCES Lid(id),
	CONSTRAINT FK_LidGroep_Groep
		FOREIGN KEY(groepId)
			REFERENCES Groep(id)
);

INSERT INTO LidGroep
	(lidId, groepId)
	VALUES	(2, 3),
			(4, 3),
			(13, 6),
			(15, 1),
			(15, 9),
			(21, 2),
			(36, 10),
			(45, 2),
			(45, 6),
			(46, 2),
			(46, 6),
			(47, 2),
			(47, 6),
			(52, 7),
			(75, 2),
			(77, 4),
			(82, 1),
			(83, 1),
			(93, 1),
			(94, 3),
			(103, 4),
			(105, 4),
			(106, 4),
			(121, 2);

CREATE TABLE Locatie
(
	id				int			IDENTITY(1,1),
	naam			varchar(100)	NOT NULL,
	omschrijving	varchar(50)	NULL,
	straat			varchar(50)	NOT NULL,
	huisnummer		varchar(5)	NULL,
	postcode		varchar(6)	NOT NULL,
	gemeente		varchar(25)	NOT NULL,
	land			varchar(25)	NOT NULL 
	CONSTRAINT DF_Locatie_land
		DEFAULT 'Belg�e',
	CONSTRAINT PK_Locatie
		PRIMARY KEY (id),
);

INSERT INTO Locatie
	(naam, omschrijving, straat, huisnummer, postcode, gemeente, land)
	VALUES	('Vrije basisoefenschool Mozaiek', null, 'Kiewitstraat', '101', '3500', 'Hasselt', 'Belg�e'),
			('Zaal Elckerlyc Sporthal', null, 'Pastorijstraat', '4', '3500', 'Hasselt', 'Belg�e'),
			('Ontmoetingscentrum Godsheide', null, 'Kiezelstraat', '118', '3500', 'Hasselt', 'Belg�e'),
			('Parochiezaal Norbertusheem Kortenbos', null, 'Nachtegaal', '124', '3800', 'Sint-Truiden', 'Belg�e'),
			('Ontmoetingscentrum Runkst', null, 'Runkstersteenweg', '149', '3500', 'Runkst', 'Belg�e'),
			('Koninklijke Fanfare Hoop in de Toekomst', 'Repetitie bij de dirigent thuis', 'Beekstraat', '5', '3840', 'Borgloon', 'Belg�e'),
			('Muziekzaal Kermt', null, 'Verbindingsweg', '26', '3510', 'Kermt', 'Belg�e'),
			('Stedelijk conservatorium Hasselt', null, 'Kunstlaan', '12', '3500', 'Hasselt', 'Belg�e'),
			('Muziekkoepel Leopoldsplein', 'muziekkoepel op het plein', 'Leopoldsplein', null, '3500', 'Hasselt', 'Belg�e'),
			('Muziekkoepel grote markt', 'muziekkoepel op het plein', 'Grote markt', null, '3500', 'Hasselt', 'Belg�e'),
			('Provinciaal monument der gesneuvelden Hasselt', 'monument op Dusartplein', 'Kolonel Dusartplein', null, '3500', 'Hasselt', 'Belg�e'),
			('Muziekkoepel grote markt', 'muziekkoepel op het plein', 'Grote markt', null, '3500', 'Hasselt', 'Belg�e'),
			('Parking Veemarkt Sint-Truiden', 'Verzamelplaats voor optocht', 'Sint-Jansstraat', '5', '3800', 'Sint-Truiden', 'Belg�e'),
			('Bovengrondse parking Dusartplein Hasselt', 'Verzamelplaats voor optocht', 'Kolonel Dusartplein', null, '3500', 'Hasselt', 'Belg�e'),
			('Kerk Sint Pieters-Banden Beringen', 'Verzamelplaats voor optocht', 'Markt', null, '3580', 'Beringen', 'Belg�e'),
			('Jenevermuseum', null, 'Witte Nonnenstraat', '19', '3500', 'Hasselt', 'Belg�e'),
			('Het borrelmannetje', 'standbeeld gelegen bij de TT-wijk', 'Maastrichterstraat', '26', '3500', 'Hasselt', 'Belg�e'),
			('Crutzenhof Hasselt', 'feestzaal', 'Oude Kuringerbaan', '93', '3500', 'Hasselt', 'Belg�e'),
			('Oud Stadhuis Hasselt', 'ook Den Nieuwen Bauw genoemd', 'Groenplein', '1', '3500', 'Hasselt', 'Belg�e'),
			('Sint-Lambertuskerk', 'Verzamelplaats voor optocht', 'pastorijstraat', '1', '3500', 'Sint-Lambrechts-Herk', 'Belg�e'),
			('Kermeta Kermt', 'feestzaal en verzamelplaats voor optocht', 'Diestersteenweg', '204', '3510', 'Kermt', 'Belg�e');

CREATE TABLE Repetitie
(
	id				int			IDENTITY(1,1),
	omschrijving	varchar(100)	NOT NULL,
	locatieId		int			NOT NULL,
	CONSTRAINT PK_Repetitie
		PRIMARY KEY (id),
	CONSTRAINT FK_Repetitie_Locatie
		FOREIGN KEY(locatieId)
			REFERENCES Locatie(id)
);

INSERT INTO Repetitie
	(omschrijving, locatieId)
	VALUES	('Repetitie Drumband - Inoefenen van Ritmische partituren', 2),
			('Repetitie Drumband - Inoefenen van Ritmische partituren', 3),
			('Repetitie Orkest - Inoefenen van Muziekpartituren', 2),
			('Repetitie Orkest - Inoefenen van Muziekpartituren', 3),
			('Repetitie Orkest - Inoefenen van Muziekpartituren', 4),
			('Repetitie Orkest - Inoefenen van Muziekpartituren', 5),
			('Repetitie Orkest - Inoefenen van Muziekpartituren', 6),
			('Repetitie Orkest met Drumband - Inoefenen van Muziekpartituren met Drums', 2),
			('Repetitie Orkest met Drumband - Inoefenen van Muziekpartituren met Drums', 3),
			('Repetitie Orkest met Drumband & Majorettes - Inoefenen van Muziekpartituren met Drums en dans', 2),
			('Repetitie Majorettes - Inoefenen van dans', 1);

CREATE TABLE GroepRepetitie
(
	id				int			IDENTITY(1,1),
	groepId			int			NOT NULL,
	repetitieId		int			NOT NULL,
	CONSTRAINT PK_GroepRepetitie
		PRIMARY KEY (id),
	CONSTRAINT FK_GroepRepetitie_Groep
		FOREIGN KEY(groepId)
			REFERENCES Groep(id),
	CONSTRAINT FK_GroepRepetitie_Repetitie
		FOREIGN KEY(repetitieId)
			REFERENCES Repetitie(id)
);

INSERT INTO GroepRepetitie
	(groepId, repetitieId)
	VALUES	(1, 10),
			(2, 1),
			(2, 8),
			(3, 3),
			(3, 8),
			(4, 11),
			(5, 8),
			(5, 9),
			(6, 1),
			(6, 2),
			(7, 3),
			(7, 4),
			(7, 8),
			(8, 5),
			(9, 6),
			(10, 7),
			(11, 8);

CREATE TABLE Optreden
(
	id				int			IDENTITY(1,1),
	omschrijving	varchar(50)	NOT NULL,
	locatieId		int			NOT NULL,
	CONSTRAINT PK_Optreden
		PRIMARY KEY (id),
	CONSTRAINT FK_Optreden_Locatie
		FOREIGN KEY(locatieId)
			REFERENCES Locatie(id)
);

INSERT INTO Optreden
	(omschrijving, locatieId)
	VALUES	('Nieuwjaarsconcert', 8),
			('Jeneverfeesten', 12),
			('Jeneverfeesten', 16),
			('Jeneverfeesten', 17),
			('Jeneverfeesten', 19),
			('Processiemars Sint-Lambrechts-Herk', 20),
			('Wapenstilstand optocht', 11),
			('Wapenstilstand optocht', 19),
			('Mosselfeest', 18),
			('Sint-Ceciliafeest', 18),
			('Kindercarnaval Hasselt', 14),
			('Grote carnavalstoet Hasselt', 14),
			('Carnaval Beringen', 15),
			('Carnaval Kermt', 21),
			('Carnaval Sint-Truiden', 13),
			('Kerstboomverbranding', 10),
			('Virga-Jesse feesten', 9),
			('Processiemars Godsheide', 3),
			('Nationale feestdag', 9),
			('Meiavond', 10),
			('Speculaasfeesten', 14),
			('Speculaasfeesten', 16);

CREATE TABLE GroepOptreden
(
	id				int			IDENTITY(1,1),
	groepId			int			NOT NULL,
	optredenId		int			NOT NULL,
	CONSTRAINT PK_GroepOptreden
		PRIMARY KEY (id),
	CONSTRAINT FK_GroepOptreden_Groep
		FOREIGN KEY(groepId)
			REFERENCES Groep(id),
	CONSTRAINT FK_GroepOptreden_Optreden
		FOREIGN KEY(optredenId)
			REFERENCES Optreden(id)
);

INSERT INTO GroepOptreden
	(groepId, optredenId)
	VALUES	(1, 1),
			(1, 2),
			(1, 3),
			(1, 4),
			(1, 5),
			(2, 6),
			(1, 7),
			(6, 7),
			(1, 8),
			(6, 8),
			(1, 9),
			(1, 10),
			(2, 11),
			(6, 11),
			(1, 12),
			(5, 12),
			(1, 13),
			(1, 14),
			(1, 15),
			(8, 15),
			(2, 18),
			(6, 18);

CREATE TABLE Instrument
(
	id				int				IDENTITY(1,1),
	artikelNummer	varchar(25)		NOT NULL,
	naam			varchar(25)		NOT NULL,
	soort			varchar(25)		NULL,
	omschrijving	varchar(100)	NULL,
	bouwjaar		date			NULL,
	CONSTRAINT PK_Instrument
		PRIMARY KEY(id)
);

INSERT INTO Instrument
	(artikelnummer, naam, soort, omschrijving, bouwjaar)
	VALUES	('25957', 'marching snaredrum', 'percussie', 'kan zowel gebruikt worden voor scherpe als doffe percussiepartijen', null),
			('515591', 'timptoms', 'percussie', null, null),
			('120915', 'bongo set', 'percussie', 'gemaakt van mahogany', '2018'),
			('517526', 'xylofoon', 'percussie', 'Heeft 3 1/2 octaven', '2021'),
			('139689', 'trombone', 'koperblazer', null, '2008'),
			('387253', 'dwarsfluit', 'houtblazer', null, '2016'),
			('188801', 'klarinet', 'houtblazer', null, '2019'),
			('MAJ75-S5', 'majorettestick', null, 'stick met lengte van 75cm', null),
			('268139', 'pauk', 'percussie', null, '2011'),
			('402287', 'trompet', 'koperblazer', null, '2016'),
			('354834', 'tuba', 'koperblazer', null, '2015'),
			('512550', 'viool', 'snaarinstrument', 'de maat van de viool is 4/4 en is gemaakt van ebony hout', '2021'),
			('220967', 'triangel', 'percussie', null, '2008'),
			('146743', 'saxofoon', 'houtblazer', null, null),
			('375981', 'harp', 'snaarinstrument', null, '2015'),
			('171971', 'hoorn', 'koperblazer', 'dubbele hoorn', '2004'),
			('452294', 'contrabass', 'snaarinstrument', null, '2018'),
			('242352', 'dikke trom', 'percussie', null, '2010'),
			('306134', 'conga set', 'percussie', 'gemaakt van thaise walnoot hout', '2013'),
			('362167', 'fagot', 'houtblazer', null, '2015');

CREATE TABLE LidInstrument
(
	id				int			IDENTITY(1,1),
	lidId			int			NOT NULL,
	instrumentId	int			NOT NULL,
	CONSTRAINT PK_LidInstrument
		PRIMARY KEY(id),
	CONSTRAINT FK_LidInstrument_Lid
		FOREIGN KEY(lidId)
			REFERENCES Lid(id),
	CONSTRAINT FK_LidInstrument_Instrument
		FOREIGN KEY(instrumentId)
			REFERENCES Instrument(id)
);

INSERT INTO LidInstrument
	(lidId, instrumentId)
	VALUES	(2, 6),
			(4, 7),
			(13, 1),
			(15, 7),
			(21, 1),
			(21, 2),
			(21, 3),
			(36, 12),
			(45, 1),
			(45, 2),
			(45, 3),
			(45, 12),
			(45, 18),
			(46, 1),
			(47, 4),
			(52, 5),
			(75, 13),
			(77, 8),
			(82, 16),
			(83, 15),
			(93, 17),
			(94, 11),
			(103, 8),
			(105, 8),
			(106, 8),
			(121, 2);

CREATE INDEX AK_Lid_rijksregisternr
ON Lid(rijksregisternr);

CREATE INDEX AK_Lid_email
ON Lid(email);

CREATE INDEX AK_Instrument_artikelNummer
ON Instrument(artikelNummer);