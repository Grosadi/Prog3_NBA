
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
-----------------------------------------------------------------------------
INSERT INTO Teams VALUES(11,'Nets', 'Brooklyn', 1967, 0.432, 0.640, 2);
INSERT INTO Teams VALUES(12, 'Cavaliers', 'Cleveland', 1970, 0.466, 0.295, 1);
INSERT INTO Teams VALUES(13, 'Pistons', 'Detroit', 1972, 0.487, 0.525, 3);
INSERT INTO Teams VALUES(14, 'Pacers', 'Indiana', 1967, 0.515, 0.425, 3);
INSERT INTO Teams VALUES(15, 'Bucks', 'Milwaukee', 1968, 0.515, 0.675, 1);
INSERT INTO Teams VALUES(16, 'Hawks', 'Atlanta', 1949, 0.495, 0.375, 1);
INSERT INTO Teams VALUES(17, 'Hornets', 'Charlotte', 1988, 0.441, 0.215, 0);
INSERT INTO Teams VALUES(18, 'Heat', 'Miami', 1988, 0.519, 0.495, 3);
INSERT INTO Teams VALUES(19, 'Magic', 'Orlando', 1989, 0.480, 0.315, 0);
INSERT INTO Teams VALUES(20, 'Wizards', 'Washington', 1961, 0.453, 0.395, 1);
INSERT INTO Teams VALUES(21, 'Mavericks', 'Dallas', 1980, 0.499, 0.505, 1);
INSERT INTO Teams VALUES(22, 'Grizzlies', 'Memphis', 1995, 0.412, 0.420, 0);
INSERT INTO Teams VALUES(23, 'Pelicans', 'New Orleans', 2002, 0.466, 0.480, 0);
INSERT INTO Teams VALUES(24, 'Nuggets', 'Denver', 1967, 0.501, 0.635, 0);
INSERT INTO Teams VALUES(25, 'Thunder', 'Oklahoma City', 1967, 0.541, 0.535, 1);
INSERT INTO Teams VALUES(26, 'Trail Blazers', 'Portland', 1970, 0.538, 0.525, 1);
INSERT INTO Teams VALUES(27, 'Jazz', 'Utah', 1974, 0.539, 0.615,0);
INSERT INTO Teams VALUES(28, 'Suns', 'Phoenix', 1968, 0.529, 0.475, 0);
INSERT INTO Teams VALUES(29, 'Kings', 'Sacramento', 1948, 0.456, 0.490, 1);
INSERT INTO Teams VALUES(30, 'Timberwolves', 'Minnesota', 1989, 0.399, 0.515, 0);


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
-----------------------------------------------------------------------------------------------------
INSERT INTO Players VALUES(31, 'Kyrie Irving', 28, 8, 'PG', 188, 88, 1, 11407, NULL, NULL, 11);
INSERT INTO Players VALUES(32, 'DeAndre Jordan',31, 11, 'C', 211, 120, 0, 7851, NULL, NULL, 11);
INSERT INTO Players VALUES(33, 'Kevin Durant',31, 12, 'SF', 208, 108, 2, 22940 ,NULL, NULL, 11);
INSERT INTO Players VALUES(34, 'Kevin Love', 31, 11, 'PF', 203, 97, 1, 12038,NULL, NULL, 12);
INSERT INTO Players VALUES(35, 'Jordan Clarkson', 27, 5, 'SG/PG', 196, 87, 0, 5643,NULL, NULL, 12);
INSERT INTO Players VALUES(36, 'Larry Nance Jr.', 27, 4, 'PF', 206, 104, 0, 2016,NULL, NULL, 12);
INSERT INTO Players VALUES(37, 'Blake Griffin', 31, 9, 'PF', 208, 113, 0, 13200,NULL, NULL, 13);
INSERT INTO Players VALUES(38, 'Derrick Rose', 31, 10, 'PG', 190, 90, 0, 10357, NULL, NULL, 13);
INSERT INTO Players VALUES(39, 'Andre Drummond', 26, 7, 'C', 211, 126, 0, 7727, NULL, NULL, 13);
INSERT INTO Players VALUES(40, 'Victor Oladipo', 27, 6, 'PG/SG', 193, 95, 0, 7028, NULL, NULL, 14);
INSERT INTO Players VALUES(41, 'Myles Turner', 24, 4, 'C', 211, 113, 0, 3640, NULL, Null, 14);
INSERT INTO Players VALUES(42, 'Malcolm Brogdon', 27, 3, 'PG/SG', 196, 103, 0, 2445, NULL, NULL, 14);
INSERT INTO Players VALUES(43, 'Giannis Antetokounmpo', 25, 6, 'SF/PF', 211, 109, 0, 8804, NULL, NULL, 15);
INSERT INTO Players VALUES(44, 'Eric Bledsoe', 30, 9, 'PG', 185, 92, 0, 8055, NULL, NULL, 15);
INSERT INTO Players VALUES(45, 'Khris Middleton', 28, 7, 'SG/SF', 203, 100, 0, 7165, NULL, NULL, 15);
INSERT INTO Players VALUES(46, 'Trae Young', 21, 1, 'PG', 188, 81, 0, 1626, NULL, NULL, 16);
INSERT INTO Players VALUES(47, 'Vince Carter', 43, 21, 'SG', 198, 99, 0, 25431, NULL, NULL, 16);
INSERT INTO Players VALUES(48, 'Parsons Chandler', 31, 8, 'SF', 208, 104, 0, 5557, NULL, NULL, 16);
INSERT INTO Players VALUES(49, 'Nicolas Batum', 31, 11, 'SF', 203, 90, 0, 9039, NULL, NULL, 17);
INSERT INTO Players VALUES(50, 'Miles Bridges', 22, 1, 'SF', 201, 102, 0, 645, NULL, NULL, 17);
INSERT INTO Players VALUES(51, 'Terry Rozier', 26, 4, 'PG', 185, 86, 0, 2127, NULL, NULL, 17);
INSERT INTO Players VALUES(52, 'Jimmy Butler', 30, 8, 'SG/SF', 201, 104, 0, 8730, NULL, NULL, 18);
INSERT INTO Players VALUES(53, 'Goran Dragic', 33, 11, 'SG/PG', 190, 86, 0, 10478, NULL, NULL, 18);
INSERT INTO Players VALUES(54, 'Udonis Haslem', 39, 16, 'C/PF', 203, 106, 3, 6511, NULL, NULL, 18);
INSERT INTO Players VALUES(55, 'Nikola Vucevic', 29, 8, 'C', 213, 117, 0, 8448, NULL, NULL, 19);
INSERT INTO Players VALUES(56, 'Aaron Gordon', 24, 5, 'SF/PF', 206, 99, 0, 4248, NULL, NULL, 19);
INSERT INTO Players VALUES(57, 'Terrence Ross', 29, 7, 'SF/SG', 201, 93, 0, 5181, NULL, NULL, 19);
INSERT INTO Players VALUES(58, 'Bradley Beal', 26, 7, 'SG', 190, 93, 0, 9745, NULL, NULL, 20);
INSERT INTO Players VALUES(59, 'John Wall', 29, 9, 'PG', 193, 95, 0, 10879, NULL, NULL, 20);
INSERT INTO Players VALUES(60, 'C.J. Milels', 33, 14, 'SG/SF', 198, 99, 0, 8044, NULL, NULL, 20);
INSERT INTO Players VALUES(61, 'Luka Doncic', 21, 1, 'PG/SG', 201, 98, 0, 1614, NULL, NULL, 21);
INSERT INTO Players VALUES(62, 'Kristaps Porzingis', 24, 3, 'PF', 221, 108, 0, 3391, NULL, NULL, 21);
INSERT INTO Players VALUES(63, 'Tim Hardaway Jr.', 28, 6, 'SG', 198, 92, 0, 5290, NULL, NULL, 21);
INSERT INTO Players VALUES(64, 'Ja Morant', 20, 0, 'PG', 190, 79, 0, 0, NULL, NULL, 22);
INSERT INTO Players VALUES(65, 'Jonas Valanciunas', 27, 7, 'C', 213, 120, 0, 5936, NULL, NULL, 22);
INSERT INTO Players VALUES(66, 'Jae Crowder', 29, 7, 'SF', 198, 106, 0, 5169, NULL, NULL, 22);
INSERT INTO Players VALUES(67, 'JJ Redick', 35, 13, 'SG', 193, 90, 0, 10817, NULL, NULL, 23);
INSERT INTO Players VALUES(68, 'Zion Williamson', 19, 0, 'PF', 201, 129, 0, 0, NULL, NULL, 23);
INSERT INTO Players VALUES(69, 'Jrue Holiday', 29, 10, 'PG/SG', 193, 92, 0, 10169, NULL, NULL, 23);
INSERT INTO Players VALUES(70, 'Nikola Jokic', 25, 4, 'C', 213, 114, 0, 5049, NULL, NULL, 24);
INSERT INTO Players VALUES(71, 'Paul Millsap', 35, 13, 'PF', 201, 113, 0, 13347, NULL, NULL, 24);
INSERT INTO Players VALUES(72, 'Jamal Murray', 23, 3, 'PG', 193, 91, 0, 3571, NULL, NULL, 24);
INSERT INTO Players VALUES(73, 'Steven Adams', 26, 6, 'C', 213, 120, 0, 4525, NULL, NULL, 25);
INSERT INTO Players VALUES(74, 'Danilo Gallinari', 31, 10, 'SF/SG', 208, 105, 0, 8780, NULL, NULL, 25);
INSERT INTO Players VALUES(75, 'Chris Paul', 34, 14, 'PG', 183, 79, 0, 17635, NULL, NULL, 25);
INSERT INTO Players VALUES(76, 'Damian Lillard', 29, 7, 'PG', 188, 88, 0, 13004, NULL, NULL, 26);
INSERT INTO Players VALUES(77, 'CJ McCollum', 28, 6, 'SG', 190, 89, 0, 7394, NULL, NULL, 26);
INSERT INTO Players VALUES(78, 'Pau Gasol', 39, 18, 'PF', 216, 113, 2, 20894, NULL, NULL, 26);
INSERT INTO Players VALUES(79, 'Donovan Mitchell', 23, 2, 'SG', 190, 97, 0, 3516, NULL, NULL, 27);
INSERT INTO Players VALUES(80, 'Mike Conley', 32, 12, 'PG', 185, 79, 0, 11763, NULL, NULL, 27);
INSERT INTO Players VALUES(81, 'Rudy Gobert', 27, 6, 'C', 216, 111, 0, 4545, NULL, NULL, 27);
INSERT INTO Players VALUES(82, 'Devin Booker', 23, 4, 'SG', 198, 95, 0, 5890, NULL, NULL, 28);
INSERT INTO Players VALUES(83, 'Ricky Rubio', 29, 8, 'PG', 193, 86, 0, 5545, NULL, NULL, 28);
INSERT INTO Players VALUES(84, 'Dario Saric', 26, 3, 'PF', 208, 102, 0, 3067, NULL, NULL, 28);
INSERT INTO Players VALUES(85, 'Buddy Hield', 27, 3, 'SG', 193, 99, 0, 3692, NULL, NULL, 29);
INSERT INTO Players VALUES(86, 'DeAaron Fox', 22, 2, 'PG', 190, 83, 0, 2288, NULL, NULL, 29);
INSERT INTO Players VALUES(87, 'Bogdan Bogdanovic', 27, 2, 'SG', 198, 99, 0, 1935, NULL, NULL, 29);
INSERT INTO Players VALUES(88, 'Jeff Teague', 31, 10, 'PG', 193, 88, 0, 9088, NULL, NULL, 30);
INSERT INTO Players VALUES(89, 'Karl-Anthony Towns', 24, 4, 'C', 213, 112, 0, 7283, NULL, NULL, 30);
INSERT INTO Players VALUES(90, 'Andrew Wiggins', 25, 5, 'SF', 203, 87, 0, 7830, NULL, NULL, 30);



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
--------------------------------------------------------------------------------
INSERT INTO Coaches VALUES(11, 'Kenny Atkinson', 0.200, 4, NULL, 0, 11);
INSERT INTO Coaches VALUES(12, 'John Beilein', 0.500, 1, NULL, 0, 12);
INSERT INTO Coaches VALUES(13, 'Dwane Casey', 0.545, 11, 'Raptors', 0, 13);
INSERT INTO Coaches VALUES(14, 'Nate McMillan', 0.523, 16, 'Trail Blazers', 0, 14);
INSERT INTO Coaches VALUES(15, 'Mike Budenholzer', 0.555, 7, 'Hawks', 0, 15);
INSERT INTO Coaches VALUES(16, 'Lloyd Pierce', 0.369, 2, NULL, 0, 16);
INSERT INTO Coaches VALUES(17, 'James Borrego', 0.435, 3, 'Magic', 0, 17);
INSERT INTO Coaches VALUES(18, 'Erik Spoelstra', 0.591, 12, NULL, 2, 18);
INSERT INTO Coaches VALUES(19, 'Steve Clifford', 0.484, 7, 'Hornets', 0, 19);
INSERT INTO Coaches VALUES(20, 'Scott Brooks', 0.583, 11, 'Thunder', 0, 20);
INSERT INTO Coaches VALUES(21, 'Rick Carlisle', 0.545, 18, 'Pacers', 1, 21);
INSERT INTO Coaches VALUES(22, 'Taylor Jenkins', 0.333, 1, NULL, 0, 22);
INSERT INTO Coaches VALUES(23, 'Alvin Gentry', 0.463, 17, 'Suns', 0, 23);
INSERT INTO Coaches VALUES(24, 'Mike Malone', 0.491, 7, 'Kings', 0, 24);
INSERT INTO Coaches VALUES(25, 'Billy Donovan', 0.604, 5, NULL, 0, 25);
INSERT INTO Coaches VALUES(26, 'Terry Stotts', 0,514, 12, 'Bucks', 0, 26);
INSERT INTO Coaches VALUES(27, 'Quin Snyder', 0.554, 6, NULL, 0, 27);
INSERT INTO Coaches VALUES(28, 'Monty Williams', 0.441, 6, 'Pelicans', 0, 28);
INSERT INTO Coaches VALUES(29, 'Luke Walton', 0.394, 4, 'Lakers', 0, 29);
INSERT INTO Coaches VALUES(30, 'Ryan Saunders', 0.444, 2, NULL, 0, 30);
