drop database if exists MusikStreamingDienstDB;
create database MusikStreamingDienstDB;
use MusikStreamingDienstDB;

create table Genre
(Genre_ID int primary key auto_increment not null, Bezeichnung varchar(50));

create table Benutzer
(User_ID int primary key auto_increment not null, Vorname varchar(50),
 Nachname varchar(50), Nickname varchar(50), Username varchar(50),
 E_Mailadresse varchar (50));
 
 create table Band
 (Band_ID int primary key auto_increment not null, BandName varchar(50));

create table Album
(Album_ID int primary key auto_increment not null, Titel Varchar(50),
 ErscheinungsDatum date, Band_ID int, foreign key (Band_ID) references Band(Band_ID), Genre_ID int, foreign key (Genre_ID) references Genre(Genre_ID)); 
 
 insert into Genre values 
 (null, "Electro"),
 (null, "Klassik"),
 (null, "Rock"),
 (null, "RnB/Blues"),
 (null, "Dubstep"),
 (null, "Goa"),
 (null, "Industrial"),
 (null, "Nu_Metal"),
 (null, "Heavy_Metal"),
 (null, "Grunch")
 ;
 
update Genre
set Bezeichnung = "Blues"
where Genre_ID = 4
;

insert into Benutzer ( Vorname ) values
("Alexander"),
("Michael"),
("Nicole")
;

insert into Band values 
(null, "Disturbed"),
(null, "FlyingSteps"),
(null, "Mozart"),
(null, "Feint"),
(null, "Korn")
;

insert into Album values
(null, "Down with the Sickness"),
(null, "B-Town"),
(null, "Symphony no.9"),
(null, "Music for People"),
(null, "Freak on a Leash")
;
 
Select * from Album;
