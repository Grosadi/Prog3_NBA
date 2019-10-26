
CREATE TABLE Teams (
  idTeams INT NOT NULL,
  TName		 VARCHAR(100) ,
  HomeTown VARCHAR(100) ,
  Found NUMERIC NOT NULL,
  WinPercentageSinceFounded FLOAT NOT NULL,
  WinPercentageInSeason FLOAT NOT NULL,
  NumberOfChampionships NUMERIC ,
  CONSTRAINT Teams_PRIMARY_KEY PRIMARY KEY (idTeams));

CREATE TABLE Players (
  idPlayers NUMERIC NOT NULL,
  PName VARCHAR(100) ,
  Age NUMERIC NOT NULL,
  NumberOfPlayedSeason NUMERIC ,
  Position VARCHAR(5) ,
  Height FLOAT NOT NULL,
  PWeight FLOAT ,
  NumberOfChampionships NUMERIC,
  LifetimePoints INT ,
  PointsInSeason INT ,
  PValue INT ,
  idTeams INT NOT NULL,
  CONSTRAINT Player_FOREIGN_KEY FOREIGN KEY (idTeams) REFERENCES Teams (idTeams),
  CONSTRAINT Players_PRIMARI_KEY PRIMARY KEY (idPlayers));


CREATE TABLE Coaches (
  idCoaches INT NOT NULL,
  CName VARCHAR(100) ,
  WinPercentage FLOAT ,
  NumberOfSeasons INT ,
  PreviusTeam VARCHAR(100),
  NumberOfChampionships INT,
  idTeams INT NOT NULL,
  CONSTRAINT Coaches_FOREIGN_KEY FOREIGN KEY (idTeams) REFERENCES Teams (idTeams),
  CONSTRAINT Coaches_PRIMARY_KEY PRIMARY KEY (idCoaches));
  


INSERT INTO Teams VALUES (1, 'Lakers', 'Los Angeles', 1960, 0.594, 0.635, 16);
INSERT INTO Teams VALUES (2, 'Rockets', 'Houston', 1971, 0.528, 0.525, 2);
INSERT INTO Teams VALUES (3, 'Celtics', 'Boston', 1946, 0.590, 0.430, 17);
INSERT INTO Teams VALUES (4, '76ers', 'Philadelphia', 1963, 0.515, 0.715, 3);
INSERT INTO Teams VALUES (5, 'Clippers', 'Los Angeles', 1984, 0.406, 0.675, 0);
INSERT INTO Teams VALUES (6, 'Raptors', 'Toronto', 1995, 0.470, 0.375, 1);
INSERT INTO Teams VALUES (7, 'Knicks', 'New York', 1946, 0.486, 0.285, 2);
INSERT INTO Teams VALUES (8, 'Spurs', 'San Antonio', 1976, 0.622, 0.425, 5);
INSERT INTO Teams VALUES (9, 'Warriors', 'Golden State', 1971, 0.485, 0.530, 6);
INSERT INTO Teams VALUES (10, 'Bulls', 'Chicago', 1966, 0.513, 0.356, 6);


INSERT INTO Players VALUES (1, 'Anthony Davis', 26, 7, 'PF/C', 208, 114, 0, 11105, NULL, NULL, 1);
INSERT INTO Players VALUES (2, 'LeBron James', 34, 16, 'SF', 203, 113, 3, 32593, NULL, NULL, 1);
INSERT INTO Players VALUES (3, 'Danny Green', 32, 10, 'SG', 198, 97, 2, 5613, NULL, NULL, 1);
INSERT INTO Players VALUES (4, 'James Harden', 30, 10, 'SG', 196, 99, 0, 18646, NULL, NULL, 2);
INSERT INTO Players VALUES (5, 'Russel Westbrook', 31, 11, 'PG', 190, 90, 0, 18883, NULL, NULL, 2);
INSERT INTO Players VALUES (6, 'Clint Capela', 25, 5, 'C', 208, 108, 0, 3545, NULL, NULL, 2);
INSERT INTO Players VALUES (7, 'Kemba Walker', 29, 8, 'PG', 183, 78, 0, 12043, NULL, NULL, 3);
INSERT INTO Players VALUES (8, 'Gordon Hayward', 30, 9, 'SF/PF', 201, 93, 0, 8944, NULL, NULL, 3);
INSERT INTO Players VALUES (9, 'Jayson Tatum', 22, 2, 'SF', 203, 92, 0, 2401, NULL, NULL, 3);
INSERT INTO Players VALUES (10, 'Joel Embiid', 26, 3, 'C', 213, 113, 0, 3848, NULL, NULL, 4);
INSERT INTO Players VALUES (11, 'Ben Simmons', 23, 2, 'PG', 208, 104, 0, 2640, NULL, NULL, 4);
INSERT INTO Players VALUES (12, 'Al Horford', 33, 12, 'C/PF', 208, 111, 0, 11108, NULL, NULL, 4);
INSERT INTO Players VALUES (13, 'Kawhi Leonard', 28, 8, 'SF', 201, 104, 2, 8301, NULL, NULL, 5);
INSERT INTO Players VALUES (14, 'Paul George', 29, 9, 'SG/SF', 206, 99, 0, 11983, NULL, NULL, 5);
INSERT INTO Players VALUES (15, 'Lou Williams', 33, 14, 'SG/PG', 185, 79, 0, 13348, NULL, NULL, 5);
INSERT INTO Players VALUES (16, 'Marc Gasol', 35, 11, 'C', 216, 115, 1, 11928, NULL, NULL, 6);
INSERT INTO Players VALUES (17, 'Kyle Lowry', 34, 13, 'PG', 185, 88, 1, 12406, NULL, NULL, 6);
INSERT INTO Players VALUES (18, 'Serge Ibaka', 30, 10, 'PF/C', 208, 106, 1, 9324, NULL, NULL, 6);
INSERT INTO Players VALUES (19, 'R. J. Barett', 19, 0, 'SG', 198, 91, 0, NULL , NULL, NULL, 7);
INSERT INTO Players VALUES (20, 'Julius Randle', 25, 5, 'PF/C', 203, 113, 0, 4823, NULL, NULL, 7);
INSERT INTO Players VALUES (21, 'Dennis Smith Jr.', 22, 2, 'PG', 188, 88, 0, 1773, NULL, NULL, 7);
INSERT INTO Players VALUES (22, 'DeMar DeRozan', 30, 10, 'SG', 201, 99, 0, 14944, NULL, NULL, 8);
INSERT INTO Players VALUES (23, 'LaMarcus Aldridge', 34, 13, 'PF/C', 211, 117, 0, 18620, NULL, NULL, 8);
INSERT INTO Players VALUES (24, 'Rudy Gay', 33, 13, 'SF/PF', 203, 104, 0, 15474, NULL, NULL, 8);
INSERT INTO Players VALUES (25, 'Steph Curry', 32, 10, 'PG', 190, 86, 3, 16338, NULL, NULL, 9);
INSERT INTO Players VALUES (26, 'DAngelo Russel', 24, 4, 'PG/SG', 196, 89, 0, 4513, NULL, NULL, 9);
INSERT INTO Players VALUES (27, 'Klay Thompson', 30, 8, 'SG', 201, 97, 3, 11995, NULL, NULL, 9);
INSERT INTO Players VALUES (28, 'Zach LaVine', 25, 5, 'SG', 198, 82, 0, 4763, NULL, NULL, 10);
INSERT INTO Players VALUES (29, 'Thaddeus Young', 31, 12, 'PF', 203, 99, 0, 12068, NULL, NULL, 10);
INSERT INTO Players VALUES (30, 'Lauri Markkanen', 22, 2, 'PF', 213, 108, 0, 2051, NULL, NULL, 10);



INSERT INTO Coaches VALUES (1, 'Gregg Popovich', 0.684, 23, NULL, 5, 8);
INSERT INTO Coaches VALUES (2, 'Doc Rivers', 0.576, 20, 'Celtics', 1, 5);
INSERT INTO Coaches VALUES (3, 'Steve Kerr', 0.785, 5, NULL, 3, 9);
INSERT INTO Coaches VALUES (4, 'Mike DAntoni', 0.557, 15, 'Lakers', 0, 2);
INSERT INTO Coaches VALUES (5, 'Brad Stevens', 0.549, 6, NULL, 0, 3);
INSERT INTO Coaches VALUES (6, 'Brett Brown', 0.362, 6, NULL, 0, 4);
INSERT INTO Coaches VALUES (7, 'Jim Boylen', 0.293, 1, NULL, 0, 10);
INSERT INTO Coaches VALUES (8, 'Frank Vogel', 0.511, 8, 'Magic', 0, 1);
INSERT INTO Coaches VALUES (9, 'Nick Nurse', 0.707, 1, NULL, 1, 6);
INSERT INTO Coaches VALUES (10, 'David Fizdale', 0.366, 3, 'Grizzlies', 0, 7)
