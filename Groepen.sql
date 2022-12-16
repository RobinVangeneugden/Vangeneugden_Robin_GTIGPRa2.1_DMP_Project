DROP TABLE IF EXISTS Groep;

CREATE TABLE Groep
(
	id					int				IDENTITY(1,1),
	naam				varchar(50)		NOT NULL,
	omschrijving		varchar(100)	NOT NULL,
	externeGroep		bit				NOT NULL,
	CONSTRAINT PK_Groep
		PRIMARY KEY (id)
);

INSERT INTO Groep
	(naam, omschrijving, externeGroep)
	VALUES	('Koninklijke Harmonie van Hasselt', 'Groep die bestaat uit drumband, orkest en majorettes', 'false'),
			('Drumband van de KH Hasselt', 'Groep die slaginstrumenten bespeeld', 'false'),
			('Orkest van de KH Hasselt', 'Groep die voornamelijk blaas-, snaar- of toetsinstrumenten speelt', 'false'),
			('Majorettes van de KH Hasselt', 'Groep van dansers die vooral jongeleren met een stick', 'false'),
			('Koninklijke Harmonie Demergalm Godsheide', 'Groep die bestaat uit drumband en orkest', 'true'),
			('Timpana', 'percussieband van Koninklijke Harmonie Demergalm Godsheide', 'true'),
			('Orkest van KH Demergalm Godsheide', 'Groep die voornamelijk blaas-, snaar- of toetsinstrumenten speelt', 'true'),
			('Koninklijke Harmonie der Gilde St-Truiden', 'Groep die bestaat uit orkest met percussie', 'true'),
			('Muziekvereniging het spoor Hasselt', 'Groep die bestaat uit orkest met percussie', 'true'),
			('Koninklijke fanfare Hoop in de Toekomst', 'Groep die enkel bestaat uit een orkest', 'true'),
			('Koninklijke fanfare St-Cecilia Kermt', 'Groep die enkel bestaat uit een orkest', 'true');