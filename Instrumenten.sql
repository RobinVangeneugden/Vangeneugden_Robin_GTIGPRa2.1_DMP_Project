DROP TABLE IF EXISTS Instrument;

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

CREATE INDEX AK_Instrument_artikelNummer
ON Instrument(artikelNummer);