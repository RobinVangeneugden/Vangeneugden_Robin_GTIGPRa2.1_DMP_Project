DROP TABLE IF EXISTS Optreden;

CREATE TABLE Optreden
(
	id				int			IDENTITY(1,1),
	omschrijving	varchar(50)	NOT NULL,
	CONSTRAINT PK_Optreden
		PRIMARY KEY (id)
);

INSERT INTO Optreden
	(omschrijving)
	VALUES	('Nieuwjaarsconcert Hasselt'),
			('Jeneverfeesten Hasselt'),
			('Processiemars Sint-Lambrechts-Herk'),
			('Wapenstilstand optocht Hasselt'),
			('Mosselfeest Hasselt'),
			('Sint-Ceciliafeest Hasselt'),
			('Kindercarnaval Hasselt'),
			('Grote carnavalstoet Hasselt'),
			('Carnaval Beringen'),
			('Carnaval Kermt'),
			('Carnaval Sint-Truiden'),
			('Kerstboomverbranding Hasselt'),
			('Virga-Jesse feesten Hasselt'),
			('Processiemars Godsheide'),
			('Nationale feestdag optocht Hasselt'),
			('Meiavond Hasselt'),
			('Speculaasfeesten Hasselt');