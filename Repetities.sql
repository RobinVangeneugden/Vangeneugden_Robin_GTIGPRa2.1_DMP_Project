DROP TABLE IF EXISTS Repetitie;

CREATE TABLE Repetitie
(
	id				int			IDENTITY(1,1),
	omschrijving	varchar(100)	NOT NULL,
	CONSTRAINT PK_Repetitie
		PRIMARY KEY (id)
);

INSERT INTO Repetitie
	(omschrijving)
	VALUES	('Repetitie Drumband - Inoefenen van Ritmische partituren'),
			('Repetitie Orkest - Inoefenen van Muziekpartituren'),
			('Repetitie Orkest met Drumband - Inoefenen van Muziekpartituren met Drums'),
			('Repetitie Orkest met Drumband & Majorettes - Inoefenen van Muziekpartituren met Drums en dans'),
			('Repetitie Majorettes - Inoefenen van dans');