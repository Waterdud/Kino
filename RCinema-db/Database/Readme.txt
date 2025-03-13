CREATE TABLE movies (
  MovieID INT(11) NOT NULL AUTO_INCREMENT,
  MovieName VARCHAR(100) NOT NULL,
  ReleaseDate DATE NOT NULL,
  MovieImage BLOB NOT NULL,
  MovieStart TIME DEFAULT NULL,
  MovieLength TIME DEFAULT NULL,
  MovieYear INT(11) DEFAULT NULL,
  LanguageID INT(11) NOT NULL,
  PlanID INT(11) NOT NULL,
  PRIMARY KEY (MovieID),
  KEY LanguageID (LanguageID),
  KEY PlanID (PlanID),
  FOREIGN KEY (LanguageID) REFERENCES languages(LanguageID) ON DELETE CASCADE,
  FOREIGN KEY (PlanID) REFERENCES moviesplan(PlanID) ON DELETE CASCADE
);

CREATE TABLE moviesplan (
  PlanID INT(11) NOT NULL AUTO_INCREMENT,
  PlanRow INT(11) NOT NULL,
  PlanSeat INT(11) NOT NULL,
  SeatID INT(11) NOT NULL,
  PRIMARY KEY (PlanID),
  KEY SeatID (SeatID),
  FOREIGN KEY (SeatID) REFERENCES seats(SeatID) ON DELETE CASCADE
);

CREATE TABLE purchases (
  PurchaseID INT(11) NOT NULL AUTO_INCREMENT,
  UserID INT(11) NOT NULL,
  TypeID INT(11) NOT NULL,
  MovieID INT(11) NOT NULL,
  PurchaseDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  SeatsCount INT(11) NOT NULL,
  TotalPrice DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (PurchaseID),
  KEY UserID (UserID),
  KEY TypeID (TypeID),
  KEY MovieID (MovieID),
  FOREIGN KEY (UserID) REFERENCES users(UserID) ON DELETE CASCADE,
  FOREIGN KEY (TypeID) REFERENCES tickettype(TypeID) ON DELETE CASCADE,
  FOREIGN KEY (MovieID) REFERENCES movies(MovieID) ON DELETE CASCADE
);

CREATE TABLE purchased_seats (
  PurchaseID INT(11) NOT NULL,
  SeatID INT(11) NOT NULL,
  PRIMARY KEY (PurchaseID, SeatID),
  FOREIGN KEY (PurchaseID) REFERENCES purchases(PurchaseID) ON DELETE CASCADE,
  FOREIGN KEY (SeatID) REFERENCES seats(SeatID) ON DELETE CASCADE
);

CREATE TABLE seats (
  SeatID INT(11) NOT NULL AUTO_INCREMENT,
  SeatName VARCHAR(50) DEFAULT NULL,
  BasePrice DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (SeatID)
);

CREATE TABLE tickettype (
  TypeID INT(11) NOT NULL AUTO_INCREMENT,
  SeatID INT(11) NOT NULL,
  Type VARCHAR(50) NOT NULL,
  Price DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (TypeID),
  KEY SeatID (SeatID),
  FOREIGN KEY (SeatID) REFERENCES seats(SeatID) ON DELETE CASCADE
);

CREATE TABLE users (
  UserID INT(11) NOT NULL AUTO_INCREMENT,
  Username VARCHAR(20) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Password VARCHAR(100) NOT NULL,
  Role VARCHAR(10) DEFAULT 'User',
  PRIMARY KEY (UserID),
  UNIQUE KEY Email (Email)
);


������������ �������� �����. 

����� ������������ �������� ����� ��� ���������, 
������� ���������� ���� ���� ��� ����� ������, ��������� ������ �� ������� moviesplan, 
������� ��������� ����� � ����������� ��������� (seats).

������������ �������� �����. 

����� ���� ��� ������������ �������� �����, 
������� ���������� ��������� ������ ��� ���� ���� (��������, ����������� ��� VIP). 
����� ���� ������ ������� �� ������� tickettype, ������� ������� � �������.

���������� �������. 

����� ������������ ��������� �������, ��������� ������ � ������� purchases, 
��� ����������� ������ � ������������, ���� ������, ������, ���������� ���� � ����� ���������.

������ ��������� ����. 

��� ������ ������� ����������� ������ � ������� purchased_seats,
��� ����������� ��������� ����� � ���������� ��������.

������������ ����. 

����� ������, ����� ����� ���� �������, ����� ������ ��������� ������� purchased_seats, 
� ����� ������������ SeatID ��� ��������� ���������� � ������ ����� ����� ������� seats.